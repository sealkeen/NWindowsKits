// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:12859
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SERIALKEYSA
    {

        public uint cbSize;
        public uint dwFlags;
        public IntPtr lpszActivePort;
        public IntPtr lpszPort;
        public uint iBaudRate;
        public uint iPortState;
        public uint iActive;
    }
}
