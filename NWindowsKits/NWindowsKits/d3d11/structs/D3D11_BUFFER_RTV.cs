// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:3753
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D11_BUFFER_RTV // 1
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:3755
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0 // 0
        {
    
    
            [FieldOffset(0)] public uint FirstElement;
    
            [FieldOffset(0)] public uint ElementOffset;
        }
    
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:3760
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__1 // 0
        {
    
    
            [FieldOffset(0)] public uint NumElements;
    
            [FieldOffset(0)] public uint ElementWidth;
        }
    

        public __Anonymous__0 __field__0;
        public __Anonymous__1 __field__1;
    }
}
