import os
import glob
from typing import List
from langchain_community.document_loaders import TextLoader
from langchain_text_splitters import RecursiveCharacterTextSplitter
from langchain_community.embeddings import HuggingFaceEmbeddings
from langchain_community.vectorstores import FAISS
from langchain_core.vectorstores import VectorStoreRetriever

EMBEDDING_MODEL_NAME = "all-MiniLM-L6-v2"
INDEX_FOLDER = "faiss_index"

def load_documents(folder_path: str) -> List:
    documents = []
    # Support both markdown and text files
    for ext in ["**/*.md", "**/*.txt"]:
        files = glob.glob(os.path.join(folder_path, ext), recursive=True)
        for file_path in files:
            try:
                loader = TextLoader(file_path, encoding="utf-8")
                documents.extend(loader.load())
            except Exception as e:
                print(f"Error loading {file_path}: {e}")
    return documents

def ingest_knowledge_base(folder_path: str, force_reindex: bool = False):
    """Ingests documents from the folder and creates/updates the FAISS index."""

    if os.path.exists(INDEX_FOLDER) and not force_reindex:
        print("Index already exists. Skipping ingestion.")
        return

    print(f"Ingesting documents from {folder_path}...")
    documents = load_documents(folder_path)

    if not documents:
        print("No documents found to ingest.")
        # Create an empty index to avoid errors
        # FAISS requires at least one text to initialize usually, or we can handle it gracefully
        return

    text_splitter = RecursiveCharacterTextSplitter(
        chunk_size=1000,
        chunk_overlap=200,
        length_function=len,
    )
    texts = text_splitter.split_documents(documents)

    print(f"Creating embeddings for {len(texts)} chunks...")
    embeddings = HuggingFaceEmbeddings(model_name=EMBEDDING_MODEL_NAME)

    vectorstore = FAISS.from_documents(texts, embeddings)
    vectorstore.save_local(INDEX_FOLDER)
    print("Ingestion complete.")

def get_retriever() -> VectorStoreRetriever:
    """Returns a retriever for the vector store."""
    if not os.path.exists(INDEX_FOLDER):
        raise ValueError("Index not found. Please run ingestion first.")

    embeddings = HuggingFaceEmbeddings(model_name=EMBEDDING_MODEL_NAME)
    vectorstore = FAISS.load_local(INDEX_FOLDER, embeddings, allow_dangerous_deserialization=True)

    return vectorstore.as_retriever(search_kwargs={"k": 4})
