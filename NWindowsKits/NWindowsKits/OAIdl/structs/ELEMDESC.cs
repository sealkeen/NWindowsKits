// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:723
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ELEMDESC
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:725
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0
        {
    
    
            [FieldOffset(0)] public IDLDESC idldesc;
    
            [FieldOffset(0)] public PARAMDESC paramdesc;
        }
    

        public TYPEDESC tdesc;
        public __Anonymous__0 __field__1;
    }
}
