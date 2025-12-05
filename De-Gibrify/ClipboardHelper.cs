using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace De_Gibrify
{
    public static class ClipboardHelper
    {
        // Clipboard Formats
        private const uint CF_UNICODETEXT = 13;

        // Memory Flags
        private const uint GMEM_MOVEABLE = 0x0002;
        private const uint GMEM_ZEROINIT = 0x0040;

        // Error Codes
        private const int ERROR_ACCESS_DENIED = 5;

        #region P/Invoke

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool CloseClipboard();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool EmptyClipboard();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetClipboardData(uint uFormat);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetClipboardData(uint uFormat, IntPtr hMem);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetClipboardSequenceNumber();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GlobalAlloc(uint uFlags, UIntPtr dwBytes);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GlobalLock(IntPtr hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GlobalUnlock(IntPtr hMem);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GlobalFree(IntPtr hMem);

        #endregion

        /// <summary>
        /// Gets the current clipboard sequence number.
        /// </summary>
        public static uint GetSequenceNumber()
        {
            return GetClipboardSequenceNumber();
        }

        /// <summary>
        /// Waits for the clipboard sequence number to change from the starting value.
        /// Returns true if changed, false if timed out.
        /// </summary>
        public static bool WaitForClipboardUpdate(uint startSequence, int timeoutMs = 2000)
        {
            int elapsed = 0;
            int interval = 50;

            while (elapsed < timeoutMs)
            {
                uint current = GetClipboardSequenceNumber();
                if (current != startSequence)
                {
                    return true;
                }
                Thread.Sleep(interval);
                elapsed += interval;
            }
            return false;
        }

        /// <summary>
        /// Tries to open the clipboard with retries.
        /// </summary>
        private static bool TryOpenClipboard(int retries = 10, int delayMs = 100)
        {
            for (int i = 0; i < retries; i++)
            {
                if (OpenClipboard(IntPtr.Zero))
                {
                    return true;
                }
                Thread.Sleep(delayMs);
            }
            return false;
        }

        public static string? GetText()
        {
            if (!TryOpenClipboard())
            {
                return null;
            }

            try
            {
                IntPtr hGlobal = GetClipboardData(CF_UNICODETEXT);
                if (hGlobal == IntPtr.Zero)
                {
                    return null;
                }

                IntPtr ptr = GlobalLock(hGlobal);
                if (ptr == IntPtr.Zero)
                {
                    return null;
                }

                try
                {
                    return Marshal.PtrToStringUni(ptr);
                }
                finally
                {
                    GlobalUnlock(hGlobal);
                }
            }
            finally
            {
                CloseClipboard();
            }
        }

        public static bool SetText(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;

            // Allocate global memory for the text
            // (Length + 1) * 2 for null terminator and Unicode chars
            int bytes = (text.Length + 1) * 2;
            IntPtr hGlobal = GlobalAlloc(GMEM_MOVEABLE | GMEM_ZEROINIT, (UIntPtr)bytes);

            if (hGlobal == IntPtr.Zero) return false;

            bool success = false;

            try
            {
                IntPtr ptr = GlobalLock(hGlobal);
                if (ptr == IntPtr.Zero) return false;

                try
                {
                    // Copy string to global memory
                    char[] chars = text.ToCharArray();
                    Marshal.Copy(chars, 0, ptr, chars.Length);
                    // Null terminator is handled by GlobalAlloc zero init or we can set it explicitly
                    // But Marshal.Copy doesn't append null.
                    // Actually, let's use Marshal.Copy which copies the char array.
                    // The last 2 bytes are 0 because of GMEM_ZEROINIT and size+1.
                }
                finally
                {
                    GlobalUnlock(hGlobal);
                }

                if (TryOpenClipboard())
                {
                    try
                    {
                        EmptyClipboard();
                        if (SetClipboardData(CF_UNICODETEXT, hGlobal) != IntPtr.Zero)
                        {
                            success = true;
                        }
                    }
                    finally
                    {
                        CloseClipboard();
                    }
                }
            }
            finally
            {
                if (!success)
                {
                    // If we failed to set it to clipboard, we must free the memory.
                    // If SetClipboardData succeeded, the system owns the memory.
                    GlobalFree(hGlobal);
                }
            }

            return success;
        }
    }
}
