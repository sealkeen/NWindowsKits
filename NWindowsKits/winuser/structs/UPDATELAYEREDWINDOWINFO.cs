// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winuser.h:4557
    [StructLayout(LayoutKind.Sequential)]
    public struct UPDATELAYEREDWINDOWINFO // 2
    {
        public uint cbSize;
        public HDC hdcDst;
        public IntPtr pptDst;
        public IntPtr psize;
        public HDC hdcSrc;
        public IntPtr pptSrc;
        public uint crKey;
        public IntPtr pblend;
        public uint dwFlags;
        public IntPtr prcDirty;
    }
}
