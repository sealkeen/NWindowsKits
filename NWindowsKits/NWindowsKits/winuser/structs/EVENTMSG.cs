// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:1064
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct EVENTMSG // 7
    {

        public uint message;
        public uint paramL;
        public uint paramH;
        public uint time;
        public HWND hwnd;
    }
}
