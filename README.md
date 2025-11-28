# Knowledge Chat App

A web application to chat with a knowledge base using a Large Language Model (LLM).

## Architecture

*   **Frontend**: Next.js (based on `langchain-ai/agent-chat-ui`)
*   **Backend**: Python FastAPI with `LangGraph` and `LangChain`
*   **Database**: FAISS (for RAG), `LangGraph` MemorySaver (for conversation state)

## Prerequisites

*   Python 3.13 (or compatible)
*   Node.js & npm/pnpm

## Installation

1.  **Backend Setup**:
    ```bash
    pip install poetry
    poetry install
    # Or use pip directly:
    pip install -r requirements.txt
    ```

2.  **Frontend Setup**:
    ```bash
    cd frontend
    npm install
    # or
    pnpm install
    ```

## Running the App

1.  **Start the Backend**:
    ```bash
    python backend/server.py
    ```
    The backend runs on `http://localhost:8000`.

2.  **Start the Frontend**:
    ```bash
    cd frontend
    npm run dev
    # or
    pnpm dev
    ```
    The frontend runs on `http://localhost:3000`.

3.  **Connect Frontend to Backend**:
    *   Open `http://localhost:3000`.
    *   Enter Deployment URL: `http://localhost:8000`.
    *   Enter Assistant/Graph ID: `agent`.
    *   (Optional) Enter any string for LangSmith API Key if running locally.

## Features

*   **RAG**: Semantic search over Markdown/Text files in the `Markdowns` folder.
*   **Agent**: Uses `LangGraph` to decide when to use tools (search, read file) or answer directly.
*   **Tools**:
    *   `semantic_search`: Search the vector database.
    *   `read_file`: Read file contents.
    *   `search_files`: Find files by pattern.

## Configuration

*   `KNOWLEDGE_BASE_PATH`: Path to the folder containing documents to ingest (default: `Markdowns`).
*   `USE_MOCK_LLM`: Set to `true` to use a mock LLM for testing.

## Recent Updates

*   Updated to Python 3.13.
*   Upgraded to `langchain` 0.3.x and `langgraph` 0.2.x+.
*   Frontend migrated to `agent-chat-ui`.
