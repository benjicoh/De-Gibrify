import uuid
import sys
from typing import cast, Any

from langchain_core.messages import HumanMessage, AIMessage, ToolMessage
from langgraph.checkpoint.memory import MemorySaver

# Ensure backend can be imported
import os
sys.path.append(os.getcwd())

from backend.agent import create_agent_graph

def main():
    print("Initializing Chat Utility...")

    # Initialize the graph with memory
    checkpointer = MemorySaver()
    graph = create_agent_graph(checkpointer=checkpointer)

    thread_id = str(uuid.uuid4())
    config = {"configurable": {"thread_id": thread_id}}

    print(f"Session started. Thread ID: {thread_id}")
    print("Type 'quit', 'exit', or 'q' to stop.")
    print("-" * 50)

    while True:
        try:
            user_input = input("User: ")
        except EOFError:
            break

        if user_input.lower() in ["quit", "exit", "q"]:
            print("Goodbye!")
            break

        print("\n--- Processing ---\n")

        # Stream the execution
        # We use stream_mode="updates" to see what each node produces,
        # or "values" to see the state after each step.
        # "values" is often easier to track the full conversation.

        try:
            inputs = {"messages": [HumanMessage(content=user_input)]}

            for event in graph.stream(inputs, config=cast(Any, config), stream_mode="values"):
                # event is the state (AgentState)
                messages = event.get("messages", [])
                if messages:
                    last_message = messages[-1]

                    # We only want to print the latest message to avoid repetition,
                    # but stream("values") emits the whole state at every step.
                    # A better way might be to track what we've printed or just print the last one
                    # if it's new.

                    # For a simple debug utility, let's just inspect the last message type.
                    # To distinguish if it's the final output or an intermediate step, we check the type.

                    if isinstance(last_message, AIMessage):
                        if last_message.tool_calls:
                            print(f"\n🤖 AI (Tool Call):")
                            for tc in last_message.tool_calls:
                                print(f"  - Tool: {tc.get('name')}")
                                print(f"  - Args: {tc.get('args')}")
                        elif last_message.content:
                            print(f"\n🤖 AI: {last_message.content}")

                    elif isinstance(last_message, ToolMessage):
                        print(f"\n🔧 Tool Output ({last_message.name}):")
                        # Truncate if too long
                        content = str(last_message.content)
                        if len(content) > 200:
                            print(f"  {content[:200]}... (truncated)")
                        else:
                            print(f"  {content}")

            print("\n" + "-" * 50 + "\n")

        except Exception as e:
            print(f"Error: {e}")

if __name__ == "__main__":
    main()
