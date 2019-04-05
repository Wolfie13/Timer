using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Timer
{
    class Utils
    {
        [DllImport("user32")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32")]
        private static extern UInt32 GetWindowThreadProcessId(IntPtr hWnd, out Int32 lpdwProcessId);

        private Int32 GetWindowProcessID(IntPtr hWnd)
        {
            Int32 pid = -1;
            GetWindowThreadProcessId(hWnd, out pid);
            return pid;
        }


        public string GetActiveWindowProcessName()
        {
            IntPtr hWnd = GetForegroundWindow();
            if (hWnd != null)
            {
                Int32 ID = GetWindowProcessID(hWnd);
                if (ID == -1)
                {
                    return "";
                }
                //string appProcessName = Process.GetProcessById(ID).ProcessName;
                string appExePath = Process.GetProcessById(ID).MainModule.FileName;
                string appExeName = appExePath.Substring(appExePath.LastIndexOf(@"\") + 1);

                return appExeName.ToLower();
            }

            return "";
        }
    }
}
