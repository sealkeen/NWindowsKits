// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:10439
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MENUITEMTEMPLATE // 2
    {
        public ushort mtOption;
        public ushort mtID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] public string mtString;
    }
}
