// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/include/10.0.18362.0/um/wingdi.h:2738
    [StructLayout(LayoutKind.Sequential)]
    public struct _DISPLAY_DEVICEW // 3
    {
        public uint cb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public ushort[] DeviceName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)] public ushort[] DeviceString;
        public uint StateFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)] public ushort[] DeviceID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)] public ushort[] DeviceKey;
    }
}