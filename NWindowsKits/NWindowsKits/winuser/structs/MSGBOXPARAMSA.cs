// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:9216
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MSGBOXPARAMSA
    {

        public uint cbSize;
        public HWND hwndOwner;
        public HINSTANCE hInstance;
        [MarshalAs(UnmanagedType.LPStr)] public string lpszText;
        [MarshalAs(UnmanagedType.LPStr)] public string lpszCaption;
        public uint dwStyle;
        [MarshalAs(UnmanagedType.LPStr)] public string lpszIcon;
        public ulong dwContextHelpId;
        public MSGBOXCALLBACK lpfnMsgBoxCallback;
        public uint dwLanguageId;
    }
}
