// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:6113
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct INPUT // 3
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:6116
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0 // 0
        {
    
    
            [FieldOffset(0)] public MOUSEINPUT mi;
    
            [FieldOffset(0)] public KEYBDINPUT ki;
    
            [FieldOffset(0)] public HARDWAREINPUT hi;
        }
    

        public uint type;
        public __Anonymous__0 __field__1;
    }
}
