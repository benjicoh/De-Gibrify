using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        private const int MOD_ALT = 0x0001;
        private const int VK_F10 = 0x79;
        private const int HOTKEY_ID = 9000;

        private HotkeyConfig _hotkeyConfig = new HotkeyConfig();
        private List<IntPtr> _loadedLayouts = new List<IntPtr>();

        public DeGibrifyApplicationContext()
        {
            _hotkeyConfig = HotkeyConfig.LoadOrCreateDefault();
            LoadConfiguredLayouts();
            SetupTrayIcon();
            RegisterGlobalHotKey();
        }

        private void LoadConfiguredLayouts()
        {
            _loadedLayouts.Clear();
            if (_hotkeyConfig.Languages == null || _hotkeyConfig.Languages.Count < 2)
            {
                // Fallback defaults
                _hotkeyConfig.Languages = new List<string> { "en-US", "he-IL" };
            }

            foreach (var lang in _hotkeyConfig.Languages)
            {
                try
                {
                    IntPtr hkl = LoadLayoutFromCulture(lang);
                    if (hkl != IntPtr.Zero)
                    {
                        _loadedLayouts.Add(hkl);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Failed to load layout for {lang}: {ex.Message}");
                }
            }

            if (_loadedLayouts.Count < 2)
            {
                MessageBox.Show("Could not load at least 2 keyboard layouts. De-Gibrify might not work correctly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private IntPtr LoadLayoutFromCulture(string cultureName)
        {
            try
            {
                var culture = new CultureInfo(cultureName);
                int lcid = culture.LCID;
                string klid = lcid.ToString("X8");
                return NativeMethods.LoadKeyboardLayout(klid, NativeMethods.KLF_NOTELLSHELL);
            }
            catch
            {
                return IntPtr.Zero;
            }
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
            ClipboardHelper.WaitForClipboardUpdate(startSequence);

            //3. Read from Clipboard
            string? originalText = ClipboardHelper.GetText();
            if (string.IsNullOrEmpty(originalText) || _loadedLayouts.Count < 2)
            {
                // Nothing selected or copy failed, or not enough layouts
                return;
            }

            //4. Determine Languages
            IntPtr sourceLayout, targetLayout;
            DetectBestLayout(originalText, _loadedLayouts, out sourceLayout, out targetLayout);

            Debug.WriteLine($"Source Layout: 0x{sourceLayout.ToInt64():X}");
            Debug.WriteLine($"Target Layout: 0x{targetLayout.ToInt64():X}");

            //5. Transform String
            Debug.WriteLine($"Transforming {originalText}");
            string newText = TransformString(originalText, sourceLayout, targetLayout);
            Debug.WriteLine($"Transformed to {newText}");

            //6. Paste Transformed String
            if (ClipboardHelper.SetText(newText))
            {
                SendCtrlV();
            }

            //7. Switch Layout for Foreground Window
            // We use PostMessage to request the language change.
            IntPtr hwndForeground = NativeMethods.GetForegroundWindow();
            if (hwndForeground != IntPtr.Zero)
            {
                NativeMethods.PostMessage(hwndForeground, NativeMethods.WM_INPUTLANGCHANGEREQUEST, IntPtr.Zero, targetLayout);
            }
        }

        private void DetectBestLayout(string text, List<IntPtr> layouts, out IntPtr bestSource, out IntPtr bestTarget)
        {
            // Default to first two
            bestSource = layouts[0];
            bestTarget = layouts[1];

            int bestScore = -1;

            // Score each layout
            // Score = count of characters that map successfully to a VK on this layout
            for (int i = 0; i < layouts.Count; i++)
            {
                IntPtr layout = layouts[i];
                int score = 0;
                foreach (char c in text)
                {
                    if (char.IsWhiteSpace(c)) continue; // Ignore spaces for scoring
                    short scan = NativeMethods.VkKeyScanEx(c, layout);
                    if (scan != -1)
                    {
                        score++;
                    }
                }

                if (score > bestScore)
                {
                    bestScore = score;
                    bestSource = layout;
                    // Set target to the "other" one.
                    // Simple logic: if we picked index i, pick index (i+1)%count as target?
                    // Or specifically if we have 2, pick the other one.
                    // If we have more than 2, it's ambiguous what the target should be.
                    // Assuming 2 languages mostly.
                    int targetIndex = (i + 1) % layouts.Count;
                    bestTarget = layouts[targetIndex];
                }
            }
        }

        private void SendCtrlX()
        {
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL,0,0,0); // Ctrl Down
            NativeMethods.keybd_event((byte)Keys.X,0,0,0); // X Down
            NativeMethods.keybd_event((byte)Keys.X,0, NativeMethods.KEYEVENTF_KEYUP,0); // X Up
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL,0, NativeMethods.KEYEVENTF_KEYUP,0); // Ctrl Up

        }

        private void SendCtrlV()
        {
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL,0,0,0); // Ctrl Down
            NativeMethods.keybd_event((byte)Keys.V,0,0,0); // V Down
            NativeMethods.keybd_event((byte)Keys.V,0, NativeMethods.KEYEVENTF_KEYUP,0); // V Up
            NativeMethods.keybd_event(NativeMethods.VK_CONTROL,0, NativeMethods.KEYEVENTF_KEYUP,0); // Ctrl Up
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
        public static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);

        public const uint KLF_NOTELLSHELL = 0x00000080;

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
