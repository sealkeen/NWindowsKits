// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/mmsyscom.h:107
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MMTIME
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/mmsyscom.h:110
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0
        {
    
    
            [FieldOffset(0)] public uint ms;
    
            [FieldOffset(0)] public uint sample;
    
            [FieldOffset(0)] public uint cb;
    
            [FieldOffset(0)] public uint ticks;
    
            [FieldOffset(0)] public __Anonymous__1 __field__4;
    
            [FieldOffset(0)] public __Anonymous__1 smpte;
    
            [FieldOffset(0)] public __Anonymous__2 __field__6;
    
            [FieldOffset(0)] public __Anonymous__2 midi;
        }
    
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/mmsyscom.h:118
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct __Anonymous__1
        {
    
            public byte hour;
            public byte min;
            public byte sec;
            public byte frame;
            public byte fps;
            public byte dummy;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] public byte[] pad;
        }
    
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/mmsyscom.h:132
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct __Anonymous__2
        {
    
            public uint songptrpos;
        }
    

        public uint wType;
        public __Anonymous__0 __field__1;
        public __Anonymous__0 u;
    }
}
