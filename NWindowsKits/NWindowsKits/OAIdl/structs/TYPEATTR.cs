// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:733
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct TYPEATTR // 2
    {
        public GUID guid;
        public uint lcid;
        public uint dwReserved;
        public int memidConstructor;
        public int memidDestructor;
        public IntPtr lpstrSchema;
        public uint cbSizeInstance;
        public TYPEKIND typekind;
        public ushort cFuncs;
        public ushort cVars;
        public ushort cImplTypes;
        public ushort cbSizeVft;
        public ushort cbAlignment;
        public ushort wTypeFlags;
        public ushort wMajorVerNum;
        public ushort wMinorVerNum;
        public TYPEDESC tdescAlias;
        public IDLDESC idldescType;
    }
}
