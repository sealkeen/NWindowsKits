// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:8529
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ZONEATTRIBUTES // 2
    {

        public uint cbSize;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 200)] public string szDescription;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] public string szIconPath;
        public uint dwTemplateMinLevel;
        public uint dwTemplateRecommended;
        public uint dwTemplateCurrentLevel;
        public uint dwFlags;
    }
}
