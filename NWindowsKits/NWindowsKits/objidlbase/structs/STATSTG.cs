// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:2213
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct STATSTG // 1
    {
        public IntPtr pwcsName;
        public uint type;
        public ULARGE_INTEGER cbSize;
        public FILETIME mtime;
        public FILETIME ctime;
        public FILETIME atime;
        public uint grfMode;
        public uint grfLocksSupported;
        public GUID clsid;
        public uint grfStateBits;
        public uint reserved;
    }
}