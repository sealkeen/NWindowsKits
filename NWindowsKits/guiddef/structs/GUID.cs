// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/include/10.0.18362.0/shared/guiddef.h:22
    [StructLayout(LayoutKind.Sequential)]
    public struct GUID // 1
    {
        public uint Data1;
        public ushort Data2;
        public ushort Data3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public byte[] Data4;
    }
}
