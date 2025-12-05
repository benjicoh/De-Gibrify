using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace De_Gibrify
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DeGibrifyApplicationContext());
        }
    }

    public class DeGibrifyApplicationContext : ApplicationContext
    {
        private NotifyIcon? _notifyIcon;
        private HiddenWindow? _window;

        // Hotkey constants
        private const int MOD_ALT = 0x0001;
        private const int VK_F10 = 0x79;
        private const int HOTKEY_ID = 9000;

        public DeGibrifyApplicationContext()
        {
            SetupTrayIcon();
            RegisterGlobalHotKey();
        }

        private void SetupTrayIcon()
        {
            _notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Keyboard, // Use a standard system icon
                Text = "De-Gibrify",
                Visible = true
            };

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Exit", null, Exit);
            _notifyIcon.ContextMenuStrip = contextMenu;
        }

        private void RegisterGlobalHotKey()
        {
            _window = new HiddenWindow(this);
            // Register Alt + F10
            if (!NativeMethods.RegisterHotKey(_window.Handle, HOTKEY_ID, MOD_ALT, VK_F10))
            {
                MessageBox.Show("Could not register hotkey Alt+F10. It might be in use.", "De-Gibrify Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit(object? sender, EventArgs e)
        {
            _notifyIcon!.Visible = false;
            if (_window != null)
            {
                NativeMethods.UnregisterHotKey(_window.Handle, HOTKEY_ID);
                _window.DestroyHandle();
            }
            Application.Exit();
        }

        public void HandleHotKey()
        {
            // 1. Simulate Ctrl+X to cut text
            SendCtrlX();

            // 2. Read from Clipboard with a small retry mechanism
            string? originalText = GetClipboardText();
            if (string.IsNullOrEmpty(originalText))
            {
                // Nothing selected or copy failed, abort
                return;
            }

            // 3. Get Foreground Window info and Layouts
            IntPtr hwndForeground = NativeMethods.GetForegroundWindow();
            uint threadId = NativeMethods.GetWindowThreadProcessId(hwndForeground, out _);
            IntPtr currentLayout = NativeMethods.GetKeyboardLayout(threadId);

            // 4. Determine Next Layout
            IntPtr nextLayout = GetNextKeyboardLayout(currentLayout);

            if (nextLayout == currentLayout)
            {
                // Only one layout or failed to find next, just paste back?
                // Or maybe we still try to transform if it's a different expected mapping?
                // Requirement says "looks at windows next keyboard layout". If none, we can't do much.
                return;
            }

            // 5. Transform String
            string newText = TransformString(originalText, currentLayout, nextLayout);

            // 6. Switch System Layout for the foreground window
            NativeMethods.PostMessage(hwndForeground, NativeMethods.WM_INPUTLANGCHANGEREQUEST, IntPtr.Zero, nextLayout);

            // 7. Paste Transformed String
            SetClipboardText(newText);
            SendCtrlV();
        }

        private void SendCtrlX()
        {
            // The user is likely still holding down Alt from the hotkey (Alt+F10).
            // We must explicitly release Alt (VK_MENU) before sending Ctrl+X,
            // otherwise the OS interprets it as Ctrl+Alt+X.
            NativeMethods.keybd_event(NativeMethods.VK_MENU, 0, NativeMethods.KEYEVENTF_KEYUP, 0);

            // Simulating inputs can be tricky. We use keybd_event for simplicity.
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL, 0, 0, 0); // Ctrl Down
            NativeMethods.keybd_event((byte)Keys.X, 0, 0, 0);       // X Down
            NativeMethods.keybd_event((byte)Keys.X, 0, NativeMethods.KEYEVENTF_KEYUP, 0); // X Up
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL, 0, NativeMethods.KEYEVENTF_KEYUP, 0); // Ctrl Up

            // Give the app a moment to process the Cut command
            Thread.Sleep(100);
        }

        private void SendCtrlV()
        {
            // Ensure modifiers are clean before pasting as well, though less critical
            NativeMethods.keybd_event(NativeMethods.VK_MENU, 0, NativeMethods.KEYEVENTF_KEYUP, 0);
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL, 0, 0, 0); // Ctrl Down
            NativeMethods.keybd_event((byte)Keys.V, 0, 0, 0);       // V Down
            NativeMethods.keybd_event((byte)Keys.V, 0, NativeMethods.KEYEVENTF_KEYUP, 0); // V Up
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL, 0, NativeMethods.KEYEVENTF_KEYUP, 0); // Ctrl Up
        }

        private string? GetClipboardText()
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    if (Clipboard.ContainsText())
                    {
                        return Clipboard.GetText();
                    }
                }
                catch (ExternalException)
                {
                    // Clipboard might be locked by another process
                    Thread.Sleep(50);
                }
            }
            return null;
        }

        private void SetClipboardText(string text)
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Clipboard.SetText(text);
                    return;
                }
                catch (ExternalException)
                {
                    Thread.Sleep(50);
                }
            }
        }

        private IntPtr GetNextKeyboardLayout(IntPtr currentLayout)
        {
            int count = NativeMethods.GetKeyboardLayoutList(0, null);
            if (count <= 0) return currentLayout;

            IntPtr[] layouts = new IntPtr[count];
            NativeMethods.GetKeyboardLayoutList(count, layouts);

            // Create a consistent order (Windows order)
            // Just find current index and increment
            int idx = -1;
            // GetKeyboardLayout returns the HKL. The low word is the language identifier.
            // However, exact pointer comparison usually works for HKLs returned by GetKeyboardLayoutList.
            for(int i=0; i<count; i++)
            {
                if(layouts[i] == currentLayout)
                {
                    idx = i;
                    break;
                }
            }

            if (idx == -1) return layouts[0]; // Should not happen
            return layouts[(idx + 1) % count];
        }

        private string TransformString(string input, IntPtr sourceLayout, IntPtr targetLayout)
        {
            StringBuilder result = new StringBuilder();

            // Buffers for ToUnicodeEx
            byte[] keyState = new byte[256];
            StringBuilder charBuff = new StringBuilder(10);

            foreach (char c in input)
            {
                // 1. Inverse Map: Char -> Virtual Key (on Source Layout)
                // VkKeyScanEx returns: Low byte = VK, High byte = Shift State
                short vkScan = NativeMethods.VkKeyScanEx(c, sourceLayout);

                if (vkScan == -1)
                {
                    // Character not defined in source layout, keep as is
                    result.Append(c);
                    continue;
                }

                byte vk = (byte)(vkScan & 0xFF);
                byte shiftState = (byte)((vkScan >> 8) & 0xFF);

                // 2. Prepare KeyState for Target Layout mapping
                // Reset state
                Array.Clear(keyState, 0, 256);

                // VkKeyScanEx Shift State bits:
                // 1: Shift, 2: Ctrl, 4: Alt
                if ((shiftState & 1) != 0) keyState[NativeMethods.VK_SHIFT] = 0x80;
                if ((shiftState & 2) != 0) keyState[NativeMethods.VK_CONTROL] = 0x80;
                if ((shiftState & 4) != 0) keyState[NativeMethods.VK_MENU] = 0x80;

                // 3. Map: VK + State -> Char (on Target Layout)
                // We also need the scan code. MapVirtualKeyEx can give us that.
                uint scanCode = NativeMethods.MapVirtualKeyEx(vk, NativeMethods.MAPVK_VK_TO_VSC, targetLayout);

                charBuff.Clear();
                int rc = NativeMethods.ToUnicodeEx(vk, scanCode, keyState, charBuff, charBuff.Capacity, 0, targetLayout);

                if (rc > 0)
                {
                    result.Append(charBuff.ToString());
                }
                else
                {
                    // Mapping failed or dead key, fallback to original
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        // Hidden Window to receive Window Messages
        private class HiddenWindow : NativeWindow
        {
            private DeGibrifyApplicationContext _context;

            public HiddenWindow(DeGibrifyApplicationContext context)
            {
                _context = context;
                CreateHandle(new CreateParams());
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == NativeMethods.WM_HOTKEY)
                {
                    // Run on a separate thread/task to not block the message loop?
                    // No, we want to block slightly to ensure sequential input processing.
                    // But typically clipboard ops should be quick.
                    _context.HandleHotKey();
                }
                base.WndProc(ref m);
            }
        }
    }

    internal static class NativeMethods
    {
        public const int WM_HOTKEY = 0x0312;
        public const int WM_INPUTLANGCHANGEREQUEST = 0x0050;

        public const byte VK_SHIFT = 0x10;
        public const byte VK_CONTROL = 0x11;
        public const byte VK_MENU = 0x12; // Alt
        public const byte VK_CONTROL_CONST = 0x11;

        public const uint KEYEVENTF_KEYUP = 0x0002;
        public const uint MAPVK_VK_TO_VSC = 0;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern IntPtr GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll")]
        public static extern int GetKeyboardLayoutList(int nBuff, [Out] IntPtr[]? lpList);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern short VkKeyScanEx(char ch, IntPtr dwhkl);

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKeyEx(uint uCode, uint uMapType, IntPtr dwhkl);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState,
            [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
    }
}
