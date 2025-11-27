from typing import List, Dict, Any, Callable, Optional, Sequence
import json
import requests
from langchain_core.language_models.chat_models import BaseChatModel
from langchain_core.messages import BaseMessage, HumanMessage, AIMessage, ToolMessage
from langchain_core.callbacks import CallbackManagerForLLMRun
from langchain_core.outputs import ChatResult, ChatGeneration
from langchain_core.tools import BaseTool
from pydantic import Field

class BedrockAPIGatewayChat(BaseChatModel):
    """Custom chat model for AWS Bedrock via API Gateway with API key authentication."""

    bedrock_base_url: str = Field(default="https://genaiapigwna.jnj.com/model")
    bedrock_secret_key: str = Field(default="yT8Yt00gKn1K0a8dcq2Bc1vnmVboehFG7DkEhIEJ")
    model_id: str = Field(default="us.anthropic.claude-sonnet-4-20250514-v1:0")
    temperature: float = Field(default=0.7)
    top_p: float = Field(default=0.95)
    max_tokens: int = Field(default=4000)
    bound_tools: List[dict] = Field(default_factory=list)

    @property
    def _llm_type(self) -> str:
        return "bedrock-api-gateway"

    def bind_tools(
        self,
        tools: Sequence[Dict[str, Any] | type | Callable | BaseTool],
        **kwargs: Any,
    ) -> "BedrockAPIGatewayChat":
        """Bind tools to the model."""
        from langchain_core.utils.function_calling import convert_to_openai_tool

        formatted_tools = [convert_to_openai_tool(tool) for tool in tools]
        return self.model_copy(update={"bound_tools": formatted_tools})

    def _generate(
        self,
        messages: List[BaseMessage],
        stop: Optional[List[str]] = None,
        run_manager: Optional[CallbackManagerForLLMRun] = None,
        **kwargs: Any,
    ) -> ChatResult:
        # Convert LangChain messages to Bedrock format
        bedrock_messages = []
        for msg in messages:
            if isinstance(msg, HumanMessage):
                role = "user"
                content = [{"text": msg.content}]
            elif isinstance(msg, AIMessage):
                role = "assistant"
                content = [{"text": msg.content}]
                # Handle tool calls in AI messages
                if hasattr(msg, 'tool_calls') and msg.tool_calls:
                    content = []
                    if msg.content:
                        content.append({"text": msg.content})
                    for tool_call in msg.tool_calls:
                        content.append({
                            "toolUse": {
                                "toolUseId": tool_call.get("id", ""),
                                "name": tool_call.get("name", ""),
                                "input": tool_call.get("args", {})
                            }
                        })
            elif isinstance(msg, ToolMessage):
                # Tool results go in user message
                role = "user"
                content = [{
                    "toolResult": {
                        "toolUseId": msg.tool_call_id,
                        "content": [{"text": msg.content}]
                    }
                }]
            else:
                role = "user"
                content = [{"text": str(msg.content)}]

            bedrock_messages.append({
                "role": role,
                "content": content
            })

        # Prepare API request
        api_url = f"{self.bedrock_base_url}/{self.model_id}/converse"
        headers = {
            "X-API-Key": self.bedrock_secret_key,
            "Content-Type": "application/json"
        }

        payload = {
            "messages": bedrock_messages,
            "inferenceConfig": {
                "temperature": kwargs.get("temperature", self.temperature),
                "topP": kwargs.get("top_p", self.top_p),
                "maxTokens": kwargs.get("max_tokens", self.max_tokens)
            }
        }

        # Add tools if bound
        if self.bound_tools:
            tools_list = []
            for tool in self.bound_tools:
                # Convert OpenAI tool format to Bedrock format
                params = tool["function"].get("parameters", {})
                tool_spec = {
                    "toolSpec": {
                        "name": tool["function"]["name"],
                        "description": tool["function"].get("description", ""),
                        "inputSchema": {
                            "json": params
                        }
                    }
                }
                tools_list.append(tool_spec)

            payload["toolConfig"] = {"tools": tools_list}

        # Make API call
        response = requests.post(api_url, headers=headers, json=payload)
        response.raise_for_status()

        # Parse response
        result = response.json()

        # Extract content and tool calls
        output_content = result["output"]["message"]["content"]
        text_content = ""
        tool_calls = []

        for content_block in output_content:
            if "text" in content_block:
                text_content += content_block["text"]
            elif "toolUse" in content_block:
                tool_use = content_block["toolUse"]
                tool_call = {
                    "name": tool_use["name"],
                    "args": tool_use["input"],
                    "id": tool_use["toolUseId"]
                }
                tool_calls.append(tool_call)
                # Log tool call
                print(f"\n🔧 Tool Call: {tool_call['name']}")
                print(f"   Parameters: {json.dumps(tool_call['args'], indent=2)}\n")

        # Create AI message with tool calls if present
        if tool_calls:
            message = AIMessage(
                content=text_content,
                tool_calls=tool_calls
            )
        else:
            message = AIMessage(content=text_content)

        generation = ChatGeneration(message=message)
        return ChatResult(generations=[generation])


class MockBedrockChat(BaseChatModel):
    """Mock chat model for testing without API access."""

    bound_tools: List[dict] = Field(default_factory=list)

    @property
    def _llm_type(self) -> str:
        return "mock-bedrock-chat"

    def bind_tools(
        self,
        tools: Sequence[Dict[str, Any] | type | Callable | BaseTool],
        **kwargs: Any,
    ) -> "MockBedrockChat":
        from langchain_core.utils.function_calling import convert_to_openai_tool
        formatted_tools = [convert_to_openai_tool(tool) for tool in tools]
        return self.model_copy(update={"bound_tools": formatted_tools})

    def _generate(
        self,
        messages: List[BaseMessage],
        stop: Optional[List[str]] = None,
        run_manager: Optional[CallbackManagerForLLMRun] = None,
        **kwargs: Any,
    ) -> ChatResult:
        last_message = messages[-1]

        # Simple logic to simulate tool use vs final answer
        # If the last message is from human, and contains "search" or "read", trigger a tool.
        # Otherwise, just answer.

        content = last_message.content
        if isinstance(content, list):
             # Handle complex content if necessary, but usually it's string in simple tests
             pass

        text_content = str(content).lower()

        # Check if we already have a tool result in the history (last message is ToolMessage)
        if isinstance(last_message, ToolMessage):
             # We got the result, now provide the answer
             message = AIMessage(content=f"Based on the tool result: {last_message.content}, here is the answer.")
             return ChatResult(generations=[ChatGeneration(message=message)])

        # If it's a user message, check if we should call a tool
        if "search" in text_content or "read" in text_content:
            # Pick a tool to call. For simplicity, pick the first one or specific one.
            # This is a dumb mock.
            if self.bound_tools:
                tool_name = self.bound_tools[0]["function"]["name"]
                tool_call = {
                    "name": tool_name,
                    "args": {"pattern": "*.md"} if "search" in tool_name else {"query": "something"},
                    "id": "call_mock_123"
                }
                if "read" in text_content and "file" in text_content:
                     # try to find read tool
                     tool_call["args"] = {"filepath": "README.md"}

                message = AIMessage(content="Thinking...", tool_calls=[tool_call])
                return ChatResult(generations=[ChatGeneration(message=message)])

        # Default response
        message = AIMessage(content="I am a mock agent. I received your message: " + str(content))
        return ChatResult(generations=[ChatGeneration(message=message)])
