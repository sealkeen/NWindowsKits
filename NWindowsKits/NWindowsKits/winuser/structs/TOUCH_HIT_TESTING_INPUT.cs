// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:6692
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct TOUCH_HIT_TESTING_INPUT // 2
    {
        public uint pointerId;
        public POINT point;
        public RECT boundingBox;
        public RECT nonOccludedBoundingBox;
        public uint orientation;
    }
}