// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:1133
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MSLLHOOKSTRUCT // 3
    {
        public POINT pt;
        public uint mouseData;
        public uint flags;
        public uint time;
        public ulong dwExtraInfo;
    }
}