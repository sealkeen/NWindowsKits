// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:868
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct VARDESC // 2
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:872
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0 // 0
        {
    
    
            [FieldOffset(0)] public uint oInst;
    
            [FieldOffset(0)] public IntPtr lpvarValue;
        }
    

        public int memid;
        public IntPtr lpstrSchema;
        public __Anonymous__0 __field__2;
        public ELEMDESC elemdescVar;
        public ushort wVarFlags;
        public VARKIND varkind;
    }
}
