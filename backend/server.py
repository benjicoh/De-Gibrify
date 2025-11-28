import os
import uuid
import json
import asyncio
from typing import Dict, List, Optional, Any, Union
import uvicorn
from fastapi import FastAPI, HTTPException, Request
from fastapi.middleware.cors import CORSMiddleware
from fastapi.responses import JSONResponse, StreamingResponse
from fastapi.staticfiles import StaticFiles
from pydantic import BaseModel

from langgraph.checkpoint.memory import MemorySaver
from langchain_core.messages import HumanMessage, AIMessage, ToolMessage, BaseMessage
from langgraph.graph import StateGraph

from backend.agent import create_agent_graph
from backend.rag import ingest_knowledge_base

# Configuration
KNOWLEDGE_BASE_PATH = os.environ.get("KNOWLEDGE_BASE_PATH", "Markdowns")
HOST = "0.0.0.0"
PORT = 8000

# Initialize Graph with Checkpointer
checkpointer = MemorySaver()
agent_graph = create_agent_graph(checkpointer=checkpointer)

app = FastAPI(title="Knowledge Chat Agent")

# CORS
app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)

# --- LangGraph Cloud API Compatibility Layer ---

@app.get("/info")
async def get_info():
    return {"ok": True}

# Assistant Endpoints
class Assistant(BaseModel):
    assistant_id: str
    graph_id: str
    config: Optional[Dict] = {}
    metadata: Optional[Dict] = {}

class AssistantSearchRequest(BaseModel):
    limit: int = 10
    offset: int = 0
    metadata: Optional[Dict] = {}

@app.post("/assistants/search")
async def search_assistants(request: AssistantSearchRequest):
    # We only have one static assistant "agent"
    return [
        {
            "assistant_id": "agent",
            "graph_id": "agent",
            "config": {},
            "metadata": {},
            "created_at": "2024-01-01T00:00:00Z",
            "updated_at": "2024-01-01T00:00:00Z"
        }
    ]

@app.get("/assistants/{assistant_id}")
async def get_assistant(assistant_id: str):
    # Accept any ID, but ideally "agent"
    return {
        "assistant_id": assistant_id,
        "graph_id": "agent",
        "config": {},
        "metadata": {},
        "created_at": "2024-01-01T00:00:00Z",
        "updated_at": "2024-01-01T00:00:00Z"
    }

# Thread Endpoints
class ThreadCreate(BaseModel):
    metadata: Optional[Dict] = {}

@app.post("/threads")
async def create_thread(thread: ThreadCreate):
    thread_id = str(uuid.uuid4())
    return {"thread_id": thread_id, "metadata": thread.metadata}

@app.get("/threads")
async def list_threads():
    return []

@app.get("/threads/{thread_id}/state")
async def get_thread_state(thread_id: str):
    config = {"configurable": {"thread_id": thread_id}}
    try:
        # Check if thread exists (has state)
        # MemorySaver.get() returns None if not found usually, but StateGraph.get_state raises error if no snapshot?
        # Actually agent_graph.get_state() returns a StateSnapshot
        state = agent_graph.get_state(config)
        return {
            "values": state.values,
            "next": state.next,
            "metadata": state.metadata,
            "config": state.config,
            "created_at": "2024-01-01T00:00:00Z",
            "parent_config": state.parent_config
        }
    except Exception:
        # If no state, return empty or 404.
        # LangGraph Cloud might expect empty values if thread exists but no run yet.
        return {"values": {}, "next": [], "metadata": {}}

class RunCreate(BaseModel):
    assistant_id: str
    input: Optional[Dict] = None
    config: Optional[Dict] = {}
    stream_mode: Optional[List[str]] = ["values"]

@app.post("/threads/{thread_id}/runs/stream")
async def stream_run(thread_id: str, run: RunCreate):
    input_data = run.input
    config = run.config or {}
    config["configurable"] = config.get("configurable", {})
    config["configurable"]["thread_id"] = thread_id

    stream_modes = run.stream_mode or ["values"]

    async def event_generator():
        try:
            # We prioritize "values" stream mode as it is the most stable for our custom server
            if "values" in stream_modes:
                async for chunk in agent_graph.astream(input_data, config, stream_mode="values"):
                    # chunk is the state
                    yield f"event: values\ndata: {json.dumps(chunk, default=str)}\n\n"
            else:
                 # Fallback to events or custom stream
                 async for event in agent_graph.astream_events(input_data, config, version="v1"):
                    kind = event["event"]
                    if kind == "on_chat_model_stream":
                        chunk = event["data"]["chunk"]
                        if hasattr(chunk, "dict"):
                            c_dict = chunk.dict()
                        else:
                            c_dict = {"content": str(chunk.content)}

                        yield f"event: messages/partial\ndata: {json.dumps([c_dict], default=str)}\n\n"

        except Exception as e:
            yield f"event: error\ndata: {json.dumps({'message': str(e)})}\n\n"

        yield "event: end\ndata: {}\n\n"

    return StreamingResponse(event_generator(), media_type="text/event-stream")

@app.post("/threads/{thread_id}/runs")
async def create_run(thread_id: str, run: RunCreate):
    # fallback to stream
    return await stream_run(thread_id, run)

# --- End API Layer ---

@app.on_event("startup")
async def startup_event():
    print("Server starting up...")
    if os.path.exists(KNOWLEDGE_BASE_PATH):
         print("Skipping automatic ingestion for stability. Please run ingestion manually if needed.")
    else:
        print(f"Warning: Knowledge base path {KNOWLEDGE_BASE_PATH} does not exist.")

# Serve frontend build artifacts
STATIC_DIR = os.path.join(os.getcwd(), "frontend/out")
if os.path.exists(STATIC_DIR):
    app.mount("/", StaticFiles(directory=STATIC_DIR, html=True), name="static")
else:
    # If static dir doesn't exist (because we haven't built it), try to serve from frontend/public or warn
    print(f"Frontend static files not found at {STATIC_DIR}. API will work, but UI won't be served directly from root.")

if __name__ == "__main__":
    uvicorn.run(app, host=HOST, port=PORT)
