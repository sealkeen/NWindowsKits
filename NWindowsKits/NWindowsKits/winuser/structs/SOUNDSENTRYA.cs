// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:13327
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SOUNDSENTRYA
    {

        public uint cbSize;
        public uint dwFlags;
        public uint iFSTextEffect;
        public uint iFSTextEffectMSec;
        public uint iFSTextEffectColorBits;
        public uint iFSGrafEffect;
        public uint iFSGrafEffectMSec;
        public uint iFSGrafEffectColor;
        public uint iWindowsEffect;
        public uint iWindowsEffectMSec;
        public IntPtr lpszWindowsEffectDLL;
        public uint iWindowsEffectOrdinal;
    }
}
