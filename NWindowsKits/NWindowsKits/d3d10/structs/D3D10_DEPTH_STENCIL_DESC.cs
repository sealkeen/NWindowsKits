// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:998
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D10_DEPTH_STENCIL_DESC
    {

        public int DepthEnable;
        public D3D10_DEPTH_WRITE_MASK DepthWriteMask;
        public D3D10_COMPARISON_FUNC DepthFunc;
        public int StencilEnable;
        public byte StencilReadMask;
        public byte StencilWriteMask;
        public D3D10_DEPTH_STENCILOP_DESC FrontFace;
        public D3D10_DEPTH_STENCILOP_DESC BackFace;
    }
}
