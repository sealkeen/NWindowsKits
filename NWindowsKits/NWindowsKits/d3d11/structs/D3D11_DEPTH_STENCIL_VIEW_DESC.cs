// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:4315
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D11_DEPTH_STENCIL_VIEW_DESC
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:4320
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0
        {
    
    
            [FieldOffset(0)] public D3D11_TEX1D_DSV Texture1D;
    
            [FieldOffset(0)] public D3D11_TEX1D_ARRAY_DSV Texture1DArray;
    
            [FieldOffset(0)] public D3D11_TEX2D_DSV Texture2D;
    
            [FieldOffset(0)] public D3D11_TEX2D_ARRAY_DSV Texture2DArray;
    
            [FieldOffset(0)] public D3D11_TEX2DMS_DSV Texture2DMS;
    
            [FieldOffset(0)] public D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray;
        }
    

        public DXGI_FORMAT Format;
        public D3D11_DSV_DIMENSION ViewDimension;
        public uint Flags;
        public __Anonymous__0 __field__3;
    }
}
