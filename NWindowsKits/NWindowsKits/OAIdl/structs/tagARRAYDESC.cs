// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:655
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct tagARRAYDESC // 2
    {

        public TYPEDESC tdescElem;
        public ushort cDims;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public SAFEARRAYBOUND[] rgbounds;
    }
}
