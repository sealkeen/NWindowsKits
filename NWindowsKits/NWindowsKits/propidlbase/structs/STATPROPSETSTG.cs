// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/propidlbase.h:464
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct STATPROPSETSTG // 1
    {
        public GUID fmtid;
        public GUID clsid;
        public uint grfFlags;
        public FILETIME mtime;
        public FILETIME ctime;
        public FILETIME atime;
        public uint dwOSVersion;
    }
}
