// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:644
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D10_INPUT_ELEMENT_DESC // 1
    {
        [MarshalAs(UnmanagedType.LPStr)] public string SemanticName;
        public uint SemanticIndex;
        public DXGI_FORMAT Format;
        public uint InputSlot;
        public uint AlignedByteOffset;
        public D3D10_INPUT_CLASSIFICATION InputSlotClass;
        public uint InstanceDataStepRate;
    }
}
