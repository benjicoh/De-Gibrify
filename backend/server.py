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

@app.get("/api/info")
async def get_info():
    return {"ok": True}

class ThreadCreate(BaseModel):
    metadata: Optional[Dict] = {}

@app.post("/api/threads")
async def create_thread(thread: ThreadCreate):
    thread_id = str(uuid.uuid4())
    return {"thread_id": thread_id, "metadata": thread.metadata}

@app.get("/api/threads")
async def list_threads():
    return []

@app.get("/api/threads/{thread_id}/state")
async def get_thread_state(thread_id: str):
    config = {"configurable": {"thread_id": thread_id}}
    try:
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
        return {"values": {}, "next": [], "metadata": {}}

class RunCreate(BaseModel):
    assistant_id: str
    input: Optional[Dict] = None
    config: Optional[Dict] = {}
    stream_mode: Optional[List[str]] = ["values"]

@app.post("/api/threads/{thread_id}/runs/stream")
async def stream_run(thread_id: str, run: RunCreate):
    input_data = run.input
    config = run.config or {}
    config["configurable"] = config.get("configurable", {})
    config["configurable"]["thread_id"] = thread_id

    stream_modes = run.stream_mode or ["values"]

    async def event_generator():
        try:
            # We use astream_events to support both values and token streaming if possible
            # But astream_events is complex to map to "values".
            # If "values" is in stream_modes, we prioritize that for simplicity (whole state updates).
            # If "messages" is requested, we try to stream tokens.

            if "values" in stream_modes:
                async for chunk in agent_graph.astream(input_data, config, stream_mode="values"):
                    # chunk is the state
                    # We need to wrap it in the expected format
                    # event: values
                    # data: ...
                    yield f"event: values\ndata: {json.dumps(chunk, default=str)}\n\n"
            else:
                 # Fallback to events or custom stream
                 async for event in agent_graph.astream_events(input_data, config, version="v1"):
                    kind = event["event"]
                    # Map to messages/partial if it's a model stream
                    if kind == "on_chat_model_stream":
                        chunk = event["data"]["chunk"]
                        # Serializing chunk is tricky, use its dict
                        if hasattr(chunk, "dict"):
                            c_dict = chunk.dict()
                        else:
                            c_dict = {"content": str(chunk.content)}

                        yield f"event: messages/partial\ndata: {json.dumps([c_dict], default=str)}\n\n"

                    # Also yield metadata or other events if needed
                    # For now, minimal support

        except Exception as e:
            yield f"event: error\ndata: {json.dumps({'message': str(e)})}\n\n"

        yield "event: end\ndata: {}\n\n"

    return StreamingResponse(event_generator(), media_type="text/event-stream")

@app.post("/api/threads/{thread_id}/runs")
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

STATIC_DIR = os.path.join(os.getcwd(), "frontend/out")
if os.path.exists(STATIC_DIR):
    app.mount("/", StaticFiles(directory=STATIC_DIR, html=True), name="static")
else:
    print(f"Frontend static files not found at {STATIC_DIR}. API will work, but UI won't be served.")

if __name__ == "__main__":
    uvicorn.run(app, host=HOST, port=PORT)
