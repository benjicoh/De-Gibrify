using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

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

        // Hotkey constants (kept for fallback)
        private const int MOD_ALT =0x0001;
        private const int VK_F10 =0x79;
        private const int HOTKEY_ID =9000;

        private HotkeyConfig _hotkeyConfig = new HotkeyConfig();

        public DeGibrifyApplicationContext()
        {
            _hotkeyConfig = HotkeyConfig.LoadOrCreateDefault();
            SetupTrayIcon();
            RegisterGlobalHotKey();
        }

        private void SetupTrayIcon()
        {
            Icon iconToUse;
            string icoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Gibbrish.ico");
            try
            {
                if (File.Exists(icoPath))
                {
                    iconToUse = new Icon(icoPath);
                }
                else
                {
                    iconToUse = SystemIcons.Application;
                }
            }
            catch
            {
                iconToUse = SystemIcons.Application;
            }

            _notifyIcon = new NotifyIcon
            {
                Icon = iconToUse,
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

            int modifiers = _hotkeyConfig?.GetModifierMask() ?? MOD_ALT;
            int vk = _hotkeyConfig?.GetVirtualKey() ?? VK_F10;

            // Register hotkey from config
            if (!NativeMethods.RegisterHotKey(_window.Handle, HOTKEY_ID, modifiers, vk))
            {
                MessageBox.Show($"Could not register hotkey {_hotkeyConfig.Key} with modifiers {string.Join(",", _hotkeyConfig.Modifiers)}. It might be in use.", "De-Gibrify Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Try fallback to Alt+F10
                if (!NativeMethods.RegisterHotKey(_window.Handle, HOTKEY_ID, MOD_ALT, VK_F10))
                {
                    MessageBox.Show("Could not register fallback hotkey Alt+F10.", "De-Gibrify Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Exit(object? sender, EventArgs e)
        {
            if (_notifyIcon != null)
            {
                _notifyIcon.Visible = false;
                _notifyIcon.Dispose();
                _notifyIcon = null;
            }

            if (_window != null)
            {
                NativeMethods.UnregisterHotKey(_window.Handle, HOTKEY_ID);
                _window.DestroyHandle();
            }
            Application.Exit();
        }

        public async Task HandleHotKey()
        {
            //0. Prepare for Clipboard Race Condition
            uint startSequence = ClipboardHelper.GetSequenceNumber();

            //1. Simulate Ctrl+X to cut text
            SendCtrlX();

            //2. Wait for Clipboard to update (Wait for the App to actually write the data)
            // This fixes the issue where we read too early.
            // If it times out, we assume the cut failed or no selection, but we still try to read once.
            ClipboardHelper.WaitForClipboardUpdate(startSequence);

            //3. Read from Clipboard using robust retry mechanism
            string? originalText = ClipboardHelper.GetText();
            if (string.IsNullOrEmpty(originalText))
            {
                // Nothing selected or copy failed, abort
                return;
            }

            //4. Synchronize Input with Foreground Window
            IntPtr hwndForeground = NativeMethods.GetForegroundWindow();
            uint idThreadForeground = NativeMethods.GetWindowThreadProcessId(hwndForeground, out _);
            uint idThreadSelf = NativeMethods.GetCurrentThreadId();

            bool attached = false;
            IntPtr currentLayout = IntPtr.Zero;
            IntPtr nextLayout = IntPtr.Zero;

            try
            {
                if (idThreadForeground != idThreadSelf)
                {
                    attached = NativeMethods.AttachThreadInput(idThreadSelf, idThreadForeground, true);
                }

                currentLayout = NativeMethods.GetKeyboardLayout(idThreadForeground);
                Debug.WriteLine($"Current Layout: 0x{currentLayout.ToInt64():X}");

                SendWinSpace();
                await Task.Delay(500);
                nextLayout = NativeMethods.GetKeyboardLayout(idThreadForeground);
                Debug.WriteLine($"Next Layout: 0x{nextLayout.ToInt64():X}");
            }
            finally
            {
                if (attached)
                {
                    NativeMethods.AttachThreadInput(idThreadSelf, idThreadForeground, false);
                }
            }

            //5. Transform String
            // We use the layouts we found. Note: TransformString might rely on API calls.
            // Some API calls like VkKeyScanEx take a HKL. They don't depend on thread state,
            // so we can do this after detaching.
            Debug.WriteLine($"Transforming {originalText}");
            string newText = TransformString(originalText, currentLayout, nextLayout);
            Debug.WriteLine($"Transformed to {newText}");
            //6. Paste Transformed String
            if (ClipboardHelper.SetText(newText))
            {
                SendCtrlV();
            }
        }

        private void SendCtrlX()
        {
            // The user is likely still holding down Alt from the hotkey (Alt+F10).
            // We must explicitly release Alt (VK_MENU) before sending Ctrl+X.
            NativeMethods.keybd_event(NativeMethods.VK_MENU,0, NativeMethods.KEYEVENTF_KEYUP,0);

            NativeMethods.keybd_event(NativeMethods.VK_CONTROL,0,0,0); // Ctrl Down
            NativeMethods.keybd_event((byte)Keys.X,0,0,0); // X Down
            NativeMethods.keybd_event((byte)Keys.X,0, NativeMethods.KEYEVENTF_KEYUP,0); // X Up
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL,0, NativeMethods.KEYEVENTF_KEYUP,0); // Ctrl Up

            // Sleep is less critical now due to WaitForClipboardUpdate, but good for safety
            Thread.Sleep(50);
        }

        private void SendCtrlV()
        {
            NativeMethods.keybd_event(NativeMethods.VK_MENU,0, NativeMethods.KEYEVENTF_KEYUP,0);
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL,0,0,0); // Ctrl Down
            NativeMethods.keybd_event((byte)Keys.V,0,0,0); // V Down
            NativeMethods.keybd_event((byte)Keys.V,0, NativeMethods.KEYEVENTF_KEYUP,0); // V Up
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL,0, NativeMethods.KEYEVENTF_KEYUP,0); // Ctrl Up
        }

        //Mimic language switch by win + space
        private void SendWinSpace()
        {
            NativeMethods.keybd_event((byte)Keys.LWin,0,0,0); // Win Down
            NativeMethods.keybd_event((byte)Keys.Space,0,0,0); // Space Down
            NativeMethods.keybd_event((byte)Keys.Space,0, NativeMethods.KEYEVENTF_KEYUP,0); // Space Up
            NativeMethods.keybd_event((byte)Keys.LWin,0, NativeMethods.KEYEVENTF_KEYUP,0); // Win Up
        }

        private string TransformString(string input, IntPtr sourceLayout, IntPtr targetLayout)
        {
            StringBuilder result = new StringBuilder();
            byte[] keyState = new byte[256];
            StringBuilder charBuff = new StringBuilder(10);

            foreach (char c in input)
            {
                short vkScan = NativeMethods.VkKeyScanEx(c, sourceLayout);
                if (vkScan == -1)
                {
                    result.Append(c);
                    continue;
                }

                byte vk = (byte)(vkScan &0xFF);
                byte shiftState = (byte)((vkScan >>8) &0xFF);

                Array.Clear(keyState,0,256);
                if ((shiftState &1) !=0) keyState[NativeMethods.VK_SHIFT] =0x80;
                if ((shiftState &2) !=0) keyState[NativeMethods.VK_CONTROL] =0x80;
                if ((shiftState &4) !=0) keyState[NativeMethods.VK_MENU] =0x80;

                uint scanCode = NativeMethods.MapVirtualKeyEx(vk, NativeMethods.MAPVK_VK_TO_VSC, targetLayout);

                charBuff.Clear();
                int rc = NativeMethods.ToUnicodeEx(vk, scanCode, keyState, charBuff, charBuff.Capacity,0, targetLayout);

                if (rc >0)
                {
                    result.Append(charBuff.ToString());
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

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
                    Task.Run(async () =>
                    {
                        await Task.Delay(250);
                        await _context.HandleHotKey();
                    });
                }
                base.WndProc(ref m);
            }
        }
    }

    internal static class NativeMethods
    {
        public const int WM_HOTKEY =0x0312;
        public const int WM_INPUTLANGCHANGEREQUEST =0x0050;

        public const byte VK_SHIFT =0x10;
        public const byte VK_CONTROL =0x11;
        public const byte VK_MENU =0x12;
        public const byte VK_CONTROL_CONST =0x11;

        public const uint KEYEVENTF_KEYUP =0x0002;
        public const uint MAPVK_VK_TO_VSC =0;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("kernel32.dll")]
        public static extern uint GetCurrentThreadId();

        [DllImport("user32.dll")]
        public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("user32.dll")]
        public static extern IntPtr GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll")]
        public static extern IntPtr ActivateKeyboardLayout(IntPtr hkl, uint Flags);

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
