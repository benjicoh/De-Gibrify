import os
import uuid
import json
import asyncio
import time
import logging
from typing import Dict, List, Optional, Any, Union, cast
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

# Configure logging
logging.basicConfig(
    level=logging.INFO,
    format="%(asctime)s %(levelname)s %(name)s %(message)s",
)
logger = logging.getLogger("backend.server")
# If running under uvicorn, reuse its handlers so logs appear in the same place
try:
    uv_err_logger = logging.getLogger("uvicorn.error")
    if uv_err_logger.handlers:
        for h in uv_err_logger.handlers:
            logger.addHandler(h)
        logger.setLevel(uv_err_logger.level or logging.INFO)
    else:
        # Ensure root logger handles output when uvicorn isn't configured yet
        logging.getLogger().setLevel(logging.INFO)
except Exception:
    logging.getLogger().setLevel(logging.INFO)


# Emit a tiny startup test log so user can verify log file existence quickly
logger.info("backend.server logger configured")

# CORS
app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)


# Middleware to log each incoming request and duration
@app.middleware("http")
async def log_requests(request: Request, call_next):
    request_id = str(uuid.uuid4())[:8]
    logger.info(f"[{request_id}] Start {request.method} {request.url}")
    start_time = time.time()
    try:
        response = await call_next(request)
    except Exception as exc:
        logger.exception(f"[{request_id}] Exception handling {request.method} {request.url}: {exc}")
        raise
    process_time = time.time() - start_time
    logger.info(
        f"[{request_id}] Completed {request.method} {request.url} -> {getattr(response, 'status_code', '??')} in {process_time:.3f}s"
    )
    return response

# --- LangGraph Cloud API Compatibility Layer ---

@app.get("/info")
async def get_info():
    logger.info("GET /info called")
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
    logger.info(f"POST /assistants/search called limit={request.limit} offset={request.offset}")
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
    logger.info(f"GET /assistants/{assistant_id} called")
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
    logger.info(f"POST /threads created thread_id={thread_id} metadata_keys={list((thread.metadata or {}).keys())}")
    return {"thread_id": thread_id, "metadata": thread.metadata}

@app.get("/threads")
async def list_threads():
    logger.info("GET /threads called")
    return []

@app.get("/threads/{thread_id}/state")
async def get_thread_state(thread_id: str):
    logger.info(f"GET /threads/{thread_id}/state called")
    config = {"configurable": {"thread_id": thread_id}}
    try:
        # Check if thread exists (has state)
        # MemorySaver.get() returns None if not found usually, but StateGraph.get_state raises error if no snapshot?
        # Actually agent_graph.get_state() returns a StateSnapshot
        state = agent_graph.get_state(cast(Any, config))
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
    logger.info(f"POST /threads/{thread_id}/runs/stream called stream_mode={run.stream_mode} input_keys={list((run.input or {}).keys()) if isinstance(run.input, dict) else 'non-dict'}")
    input_data = run.input
    config = run.config or {}
    config["configurable"] = config.get("configurable", {})
    config["configurable"]["thread_id"] = thread_id

    stream_modes = run.stream_mode or ["values"]

    async def event_generator():
        try:
            # We prioritize "values" stream mode as it is the most stable for our custom server
            if "values" in stream_modes:
                async for chunk in agent_graph.astream(input_data, cast(Any, config), stream_mode="values"):
                    # chunk is the state
                    logger.debug(f"stream chunk: {str(chunk)[:200]}")
                    yield f"event: values\ndata: {json.dumps(chunk, default=str)}\n\n"
            else:
                 # Fallback to events or custom stream
                 async for event in agent_graph.astream_events(input_data, cast(Any, config), version="v1"):
                    kind = event.get("event")
                    if kind == "on_chat_model_stream":
                        chunk = event.get("data", {}).get("chunk")
                        if chunk is None:
                            c_dict = {"content": ""}
                        elif hasattr(chunk, "dict"):
                            c_dict = chunk.dict()
                        else:
                            c_dict = {"content": str(getattr(chunk, 'content', ''))}

                        logger.debug(f"stream event partial: {str(c_dict)[:200]}")
                        yield f"event: messages/partial\ndata: {json.dumps([c_dict], default=str)}\n\n"

        except Exception as e:
            yield f"event: error\ndata: {json.dumps({'message': str(e)})}\n\n"

        yield "event: end\ndata: {}\n\n"

    return StreamingResponse(event_generator(), media_type="text/event-stream")

@app.post("/threads/{thread_id}/runs")
async def create_run(thread_id: str, run: RunCreate):
    logger.info(f"POST /threads/{thread_id}/runs called - delegating to stream_run")
    # fallback to stream
    return await stream_run(thread_id, run)

# --- End API Layer ---

@app.on_event("startup")
async def startup_event():
    logger.info("Server starting up...")
    if os.path.exists(KNOWLEDGE_BASE_PATH):
         logger.info("Skipping automatic ingestion for stability. Please run ingestion manually if needed.")
    else:
        logger.warning(f"Knowledge base path {KNOWLEDGE_BASE_PATH} does not exist.")

# Serve frontend build artifacts
STATIC_DIR = os.path.join(os.getcwd(), "frontend/out")
if os.path.exists(STATIC_DIR):
    app.mount("/", StaticFiles(directory=STATIC_DIR, html=True), name="static")
else:
    # If static dir doesn't exist (because we haven't built it), try to serve from frontend/public or warn
    logger.warning(f"Frontend static files not found at {STATIC_DIR}. API will work, but UI won't be served directly from root.")

if __name__ == "__main__":
    logger.info(f"Running server on {HOST}:{PORT}")
    uvicorn.run(app, host=HOST, port=PORT)
