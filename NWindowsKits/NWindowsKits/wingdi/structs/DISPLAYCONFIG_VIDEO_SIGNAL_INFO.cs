// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wingdi.h:2842
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO // 1
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wingdi.h:2850
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0 // 0
        {
    
    
            [FieldOffset(0)] public __Anonymous__1 __field__0;
    
            [FieldOffset(0)] public __Anonymous__1 AdditionalSignalInfo;
    
            [FieldOffset(0)] public uint videoStandard;
        }
    
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wingdi.h:2852
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct __Anonymous__1 // 1
        {
    
            public uint videoStandard;
            public uint vSyncFreqDivider;
            public uint reserved;
        }
    

        public ulong pixelRate;
        public DISPLAYCONFIG_RATIONAL hSyncFreq;
        public DISPLAYCONFIG_RATIONAL vSyncFreq;
        public DISPLAYCONFIG_2DREGION activeSize;
        public DISPLAYCONFIG_2DREGION totalSize;
        public __Anonymous__0 __field__5;
        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
    }
}
