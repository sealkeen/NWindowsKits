// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:6465
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct POINTER_TYPE_INFO
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:6467
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0
        {
    
    
            [FieldOffset(0)] public POINTER_TOUCH_INFO touchInfo;
    
            [FieldOffset(0)] public POINTER_PEN_INFO penInfo;
        }
    

        public uint type;
        public __Anonymous__0 __field__1;
    }
}
