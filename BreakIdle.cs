using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace home_idle
{
    internal class BreakIdle
    {

        public bool sessionIsLocked = false;
        public DateTime lastSessionLock;

        public BreakIdle()
        {
            //Microsoft.Win32.SystemEvents.SessionSwitch += new Microsoft.Win32.SessionSwitchEventHandler(OnSessionSwitchEvent);
            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(OnSessionSwitchEvent);
        }

        private void OnSessionSwitchEvent(object sender, SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                sessionIsLocked = true;
                lastSessionLock = DateTime.Now;
            }
            else
            {
                sessionIsLocked = false;
            }
        }

        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(out LASTINPUTINFO plii);

        [DllImport("user32.dll")]
        static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [StructLayout(LayoutKind.Sequential)]
        struct LASTINPUTINFO
        {
            public static readonly int SizeOf =
                   Marshal.SizeOf(typeof(LASTINPUTINFO));

            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public int dwTime;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            public uint type;
            public InputUnion inputUnion;
        }

        [StructLayout(LayoutKind.Explicit)]
        struct InputUnion
        {
            [FieldOffset(0)]
            public MOUSEINPUT mi;

            [FieldOffset(0)]
            public KEYBDINPUT ki;

            [FieldOffset(0)]
            public HARDWAREINPUT hi;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct HARDWAREINPUT
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }

        public int secondsIdle()
        {
            int idleTime = 0;
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = Marshal.SizeOf(lastInputInfo);
            lastInputInfo.dwTime = 0;

            int envTicks = Environment.TickCount;

            if (GetLastInputInfo(out lastInputInfo))
            {
                int lastInputTick = lastInputInfo.dwTime;
                idleTime = envTicks - lastInputTick;
            }

            int seconds;

            if (idleTime > 0)
                seconds = idleTime / 1000;
            else
                seconds = idleTime;

            return seconds;
        }

        public void resetIdle()
        {
            // Simulate a key press and release to reset the LASTINPUTINFO structure
            INPUT[] inputs = new INPUT[2];

            inputs[0].type = 1; // INPUT_KEYBOARD
            inputs[0].inputUnion.ki.wVk = 0x87; // Virtual Key Code for 'VK_F24'
            inputs[0].inputUnion.ki.wScan = 0;
            inputs[0].inputUnion.ki.dwFlags = 0;
            inputs[0].inputUnion.ki.time = 0;
            inputs[0].inputUnion.ki.dwExtraInfo = IntPtr.Zero;

            inputs[1].type = 1; // INPUT_KEYBOARD
            inputs[1].inputUnion.ki.wVk = 0x87; // Virtual Key Code for 'VK_F24'
            inputs[1].inputUnion.ki.wScan = 0;
            inputs[1].inputUnion.ki.dwFlags = 2; // KEYEVENTF_KEYUP
            inputs[1].inputUnion.ki.time = 0;
            inputs[1].inputUnion.ki.dwExtraInfo = IntPtr.Zero;

            SendInput(2, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
    }
}
