// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10effect.h:327
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D10_EFFECT_VARIABLE_DESC
    {

        [MarshalAs(UnmanagedType.LPStr)] public string Name;
        [MarshalAs(UnmanagedType.LPStr)] public string Semantic;
        public uint Flags;
        public uint Annotations;
        public uint BufferOffset;
        public uint ExplicitBindPoint;
    }
}
