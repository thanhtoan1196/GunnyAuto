using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunnyAuto
{
    class ProcessKeyboard
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowNam);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect retangle);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        public const int MOUSEEVENTF_MOVE = 0x01;
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        public const int WM_KEYDOWN = 0x100;
        public const int WM_SYSCOMMAND = 0x018;
        public const int SC_CLOSE = 0x053;

        //This simulates a left mouse click
        public static void LeftMouseClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        public void SendKeyWithTime(int start, int end, string key)
        {
            for (int i = start; i < end; i++)
            {
                SendKeys.SendWait(key);
            }
        }

        string nameWindow = "Gunny-TonyHoang";
        string nameProcess = "GunnyAuto";
        public void Start(string key)
        {
            IntPtr zero = IntPtr.Zero;
            Thread.Sleep(5);
            zero = FindWindow(null, nameWindow);
            if (zero != IntPtr.Zero)
            {
                SetForegroundWindow(zero);

                Process[] processes = Process.GetProcessesByName(nameProcess);
                Process gu = processes[0];
                IntPtr ptr = gu.MainWindowHandle;
                Rect gunnyRect = new Rect();
                GetWindowRect(ptr, ref gunnyRect);
                int top = gunnyRect.Top + 60;
                int left = gunnyRect.Left + 10;
                LeftMouseClick(left, top);

                SendKeys.SendWait(key);
                SendKeys.Flush();
            }
        }

        public void SendKey(string key)
        {
            SendKeys.SendWait(key);
            SendKeys.Flush();
        }

        public void SendKeystroke(int key)
        {
            IntPtr zero = IntPtr.Zero;
            zero = FindWindow(null, nameWindow);
            if (zero != IntPtr.Zero)
            {
                IntPtr result = SendMessage(zero, WM_KEYDOWN, (IntPtr)key, (IntPtr)0);
            }

        }

    }
}
