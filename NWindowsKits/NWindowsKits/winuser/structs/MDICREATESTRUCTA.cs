// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:11993
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MDICREATESTRUCTA
    {

        [MarshalAs(UnmanagedType.LPStr)] public string szClass;
        [MarshalAs(UnmanagedType.LPStr)] public string szTitle;
        public IntPtr hOwner;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public uint style;
        public long lParam;
    }
}
