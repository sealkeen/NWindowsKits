// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10_1.h:154
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D10_BLEND_DESC1 // 1
    {
        public int AlphaToCoverageEnable;
        public int IndependentBlendEnable;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public D3D10_RENDER_TARGET_BLEND_DESC1[] RenderTarget;
    }
}