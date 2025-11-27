import unittest
import os
import shutil
from backend.model import MockBedrockChat
from backend.tools import get_tools
from backend.rag import ingest_knowledge_base, get_retriever

class TestBackend(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        # Setup a dummy knowledge base
        os.makedirs("TestMarkdowns", exist_ok=True)
        with open("TestMarkdowns/test_doc.txt", "w") as f:
            f.write("This is a secret document about Project Zeta.")

        # Run ingestion
        ingest_knowledge_base("TestMarkdowns", force_reindex=True)

    @classmethod
    def tearDownClass(cls):
        shutil.rmtree("TestMarkdowns", ignore_errors=True)
        # We don't delete the index to avoid breaking other things, or we can restore it.
        # Ideally we should use a temporary folder for index.
        pass

    def test_mock_chat(self):
        model = MockBedrockChat()
        from langchain_core.messages import HumanMessage
        response = model.invoke([HumanMessage(content="Hello")])
        self.assertIn("mock agent", response.content)

    def test_tools(self):
        tools = get_tools()
        tool_names = [t.name for t in tools]
        self.assertIn("read_file", tool_names)
        self.assertIn("search_files", tool_names)
        self.assertIn("search_within_files", tool_names)
        self.assertIn("semantic_search", tool_names)

    def test_rag_search(self):
        # We assume the index created in setUpClass is active or default index is used.
        # ingest_knowledge_base saves to 'faiss_index'.
        tools = get_tools()
        rag_tool = next(t for t in tools if t.name == "semantic_search")
        result = rag_tool.invoke({"query": "Project Zeta"})
        self.assertIn("Project Zeta", result)

if __name__ == "__main__":
    unittest.main()
