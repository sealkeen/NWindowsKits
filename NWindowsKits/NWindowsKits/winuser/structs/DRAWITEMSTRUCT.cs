// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:3350
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DRAWITEMSTRUCT // 3
    {
        public uint CtlType;
        public uint CtlID;
        public uint itemID;
        public uint itemAction;
        public uint itemState;
        public HWND hwndItem;
        public HDC hDC;
        public RECT rcItem;
        public ulong itemData;
    }
}
