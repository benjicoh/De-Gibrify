import os
import glob
from typing import Optional, List
from langchain_core.tools import tool
from backend.rag import get_retriever

# We can define tools using the @tool decorator or just functions.
# Since we need to use them in the agent, @tool is convenient.

@tool
def read_file(filepath: str, start_line: Optional[int] = None, end_line: Optional[int] = None) -> str:
    """
    Reads the content of a file.
    Args:
        filepath: The path to the file to read.
        start_line: The starting line number (1-based, inclusive). Optional.
        end_line: The ending line number (1-based, inclusive). Optional.
    Returns:
        The content of the file or a specific range of lines.
    """
    try:
        # Security check: prevent path traversal
        abs_path = os.path.abspath(filepath)
        root_path = os.path.abspath(os.getcwd())

        if not abs_path.startswith(root_path):
             return "Error: Access denied. You can only read files within the project directory."

        if not os.path.exists(abs_path):
             return f"Error: File {filepath} does not exist."

        with open(abs_path, 'r', encoding='utf-8') as f:
            lines = f.readlines()

        if start_line is None:
            start_line = 1
        if end_line is None:
            end_line = len(lines)

        # Adjust for 0-based indexing
        start_index = max(0, start_line - 1)
        end_index = min(len(lines), end_line)

        return "".join(lines[start_index:end_index])
    except Exception as e:
        return f"Error reading file: {e}"

@tool
def search_files(pattern: str) -> str:
    """
    Searches for files matching a glob pattern.
    Args:
        pattern: The glob pattern to search for (e.g., "**/*.py", "src/foo.txt").
    Returns:
        A list of matching file paths.
    """
    try:
        files = glob.glob(pattern, recursive=True)
        return "\n".join(files) if files else "No files found."
    except Exception as e:
        return f"Error searching files: {e}"

@tool
def search_within_files(pattern: str, file_pattern: str = "**/*") -> str:
    """
    Searches for a text pattern within files.
    Args:
        pattern: The text to search for.
        file_pattern: glob pattern for files to search in. Defaults to all files.
    Returns:
        Lines containing the pattern prefixed with filepath and line number.
    """
    results = []
    try:
        files = glob.glob(file_pattern, recursive=True)
        for filepath in files:
            if os.path.isfile(filepath):
                try:
                    with open(filepath, 'r', encoding='utf-8') as f:
                        for i, line in enumerate(f):
                            if pattern in line:
                                results.append(f"{filepath}:{i+1}: {line.strip()}")
                except Exception:
                    # Skip binary files or read errors
                    continue
        return "\n".join(results) if results else "No matches found."
    except Exception as e:
        return f"Error searching within files: {e}"

@tool
def semantic_search(query: str) -> str:
    """
    Performs a semantic search (RAG) on the knowledge base.
    Args:
        query: The query string to search for.
    Returns:
        Relevant text chunks from the knowledge base.
    """
    try:
        retriever = get_retriever()
        docs = retriever.invoke(query)
        return "\n\n".join([d.page_content for d in docs])
    except Exception as e:
        return f"Error performing semantic search: {e}"

def get_tools():
    return [read_file, search_files, search_within_files, semantic_search]
