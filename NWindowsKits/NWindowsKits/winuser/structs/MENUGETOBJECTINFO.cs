// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:7776
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MENUGETOBJECTINFO // 2
    {

        public uint dwFlags;
        public uint uPos;
        public HMENU hmenu;
        public IntPtr riid;
        public IntPtr pvObj;
    }
}
