// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:11559
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC // 1
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:11562
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0 // 0
        {
    
    
            [FieldOffset(0)] public D3D11_TEX2D_VPOV Texture2D;
    
            [FieldOffset(0)] public D3D11_TEX2D_ARRAY_VPOV Texture2DArray;
        }
    

        public D3D11_VPOV_DIMENSION ViewDimension;
        public __Anonymous__0 __field__1;
    }
}
