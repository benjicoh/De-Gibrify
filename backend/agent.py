from typing import TypedDict, Annotated, Sequence, Union, Optional
import operator
import os

from langchain_core.messages import BaseMessage, HumanMessage, AIMessage
from langgraph.graph import StateGraph, END, START
from langgraph.prebuilt import ToolNode
from langgraph.checkpoint.base import BaseCheckpointSaver

from backend.model import BedrockAPIGatewayChat, MockBedrockChat
from backend.tools import get_tools

# Define the state
class AgentState(TypedDict):
    messages: Annotated[Sequence[BaseMessage], operator.add]

# Define the model selector
def get_model():
    use_mock = True # os.environ.get("USE_MOCK_LLM", "false").lower() == "true"
    tools = get_tools()

    if use_mock:
        model = MockBedrockChat()
    else:
        model = BedrockAPIGatewayChat()

    # Bind tools
    model = model.bind_tools(tools)
    return model

def call_model(state: AgentState):
    messages = state["messages"]
    model = get_model()
    response = model.invoke(messages)
    return {"messages": [response]}

def should_continue(state: AgentState):
    messages = state["messages"]
    last_message = messages[-1]

    if hasattr(last_message, "tool_calls") and last_message.tool_calls:
        return "tools"
    return END

# Define the graph
def create_agent_graph(checkpointer: Optional[BaseCheckpointSaver] = None):
    tools = get_tools()
    tool_node = ToolNode(tools)

    workflow = StateGraph(AgentState)

    workflow.add_node("agent", call_model)
    workflow.add_node("tools", tool_node)

    workflow.add_edge(START, "agent")

    workflow.add_conditional_edges(
        "agent",
        should_continue,
        {
            "tools": "tools",
            END: END
        }
    )

    workflow.add_edge("tools", "agent")

    return workflow.compile(checkpointer=checkpointer)
