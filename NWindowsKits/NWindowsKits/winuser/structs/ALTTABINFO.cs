// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:14738
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ALTTABINFO
    {

        public uint cbSize;
        public int cItems;
        public int cColumns;
        public int cRows;
        public int iColFocus;
        public int iRowFocus;
        public int cxItem;
        public int cyItem;
        public POINT ptStart;
    }
}
