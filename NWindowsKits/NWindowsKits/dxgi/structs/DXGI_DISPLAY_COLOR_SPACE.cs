// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi.h:2390
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_DISPLAY_COLOR_SPACE // 1
    {

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public float[][] PrimaryCoordinates;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] public float[][] WhitePoints;
    }
}
