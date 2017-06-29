using System;
using System.Runtime.InteropServices;

namespace PlayBoxMonitor
{
    public static class NativeMethods
    {
        [DllImport("user32.dll",CharSet = CharSet.Auto,ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll",CharSet = CharSet.Auto,SetLastError = true)]
        public static extern int GetWindowThreadProcessId(IntPtr handle,out int processId);

        [DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();

        [DllImport("user32.dll")]
        public static extern bool FlashWindow(IntPtr hwnd,bool bInvert);
    }
}