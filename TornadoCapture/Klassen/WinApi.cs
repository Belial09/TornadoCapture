using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TornadoCapture_v2.Klassen
{
    public class WinApi
    {
        private const int SmCxscreen = 0;
        private const int SmCyscreen = 1;
        private const int SwpShowwindow = 64; // 0x0040
        private static readonly IntPtr HwndTop = IntPtr.Zero;

        public static int ScreenX
        {
            get { return GetSystemMetrics(SmCxscreen); }
        }

        public static int ScreenY
        {
            get { return GetSystemMetrics(SmCyscreen); }
        }

        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int which);

        [DllImport("user32.dll")]
        public static extern void SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int width, int height,
            uint flags);

        public static void SetWinFullScreen(IntPtr hwnd)
        {
            SetWindowPos(hwnd, HwndTop, SystemInformation.VirtualScreen.Left, SystemInformation.VirtualScreen.Top,
                SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height, SwpShowwindow);
        }
    }
}