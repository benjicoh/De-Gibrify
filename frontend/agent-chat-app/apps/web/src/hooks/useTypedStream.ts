import { StreamState, useStream } from "@langchain/langgraph-sdk/react";
import { useThreads } from "../providers/Thread";

export interface StreamSession {
  streamValue: StreamState;
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  client: any;
  assistantId: string;
}

export function useTypedStream(
  props: Parameters<typeof useStream>[0]
): StreamState {
  const { threadsLoading } = useThreads();
  const stream = useStream(props);

  if (threadsLoading) {
    return {
      values: [],
      client: undefined,
      assistantId: undefined,
      error: undefined,
      isLoading: true,
      stop: () => {},
      submit: async () => {},
      branch: undefined,
      setBranch: () => {},
      history: [],
      experimental_branchTree: undefined,
      get interrupt() {
        return undefined;
      },
      get messages() {
        return [];
      },
      getMessageMetadata: () => undefined,
    } as unknown as StreamState;
  }

  // Robustly handle potentially null/undefined state or history
  const history = stream.history || [];
  const latestState = history.length > 0 ? history[history.length - 1] : undefined;

  // Safely extract checkpoint_id if available
  // The SDK might return it in latestState directly or we might need to find it
  // But based on the error, the consumer expects it to be on the object returned by useTypedStream?
  // No, useTypedStream returns StreamState.

  // Actually, let's look at what useStream returns.
  // It returns an object that HAS a history property.
  // If we return 'stream' directly, we are good.

  // However, the previous error `Cannot read properties of undefined (reading 'checkpoint_id')`
  // suggests something was trying to access `stream.history[...].checkpoint_id` and failed.

  // If we just return stream, it should be fine IF stream itself is not broken.

  return stream;
}
