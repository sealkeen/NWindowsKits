// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:9027
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct HELPINFO
    {

        public uint cbSize;
        public int iContextType;
        public int iCtrlId;
        public IntPtr hItemHandle;
        public ulong dwContextId;
        public POINT MousePos;
    }
}
