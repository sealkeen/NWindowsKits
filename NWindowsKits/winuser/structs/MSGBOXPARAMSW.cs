// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winuser.h:9229
    [StructLayout(LayoutKind.Sequential)]
    public struct MSGBOXPARAMSW // 3
    {
        public uint cbSize;
        public HWND hwndOwner;
        public HMODULE hInstance;
        public IntPtr lpszText;
        public IntPtr lpszCaption;
        public uint dwStyle;
        public IntPtr lpszIcon;
        public ulong dwContextHelpId;
        public MSGBOXCALLBACK lpfnMsgBoxCallback;
        public uint dwLanguageId;
    }
}