// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:3386
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D11_SHADER_RESOURCE_VIEW_DESC
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:3390
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0
        {
    
    
            [FieldOffset(0)] public D3D11_BUFFER_SRV Buffer;
    
            [FieldOffset(0)] public D3D11_TEX1D_SRV Texture1D;
    
            [FieldOffset(0)] public D3D11_TEX1D_ARRAY_SRV Texture1DArray;
    
            [FieldOffset(0)] public D3D11_TEX2D_SRV Texture2D;
    
            [FieldOffset(0)] public D3D11_TEX2D_ARRAY_SRV Texture2DArray;
    
            [FieldOffset(0)] public D3D11_TEX2DMS_SRV Texture2DMS;
    
            [FieldOffset(0)] public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;
    
            [FieldOffset(0)] public D3D11_TEX3D_SRV Texture3D;
    
            [FieldOffset(0)] public D3D11_TEXCUBE_SRV TextureCube;
    
            [FieldOffset(0)] public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;
    
            [FieldOffset(0)] public D3D11_BUFFEREX_SRV BufferEx;
        }
    

        public DXGI_FORMAT Format;
        public D3D_SRV_DIMENSION ViewDimension;
        public __Anonymous__0 __field__2;
    }
}
