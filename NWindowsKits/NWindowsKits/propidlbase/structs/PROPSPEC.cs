// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/propidlbase.h:441
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct PROPSPEC // 1
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/propidlbase.h:444
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0 // 0
        {
    
    
            [FieldOffset(0)] public uint propid;
    
            [FieldOffset(0)] public IntPtr lpwstr;
        }
    

        public uint ulKind;
        public __Anonymous__0 __field__1;
    }
}
