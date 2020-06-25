// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:2091
    public class IAuthenticateEx : IAuthenticate // 1
    {
        static Guid s_uuid = new Guid("2ad1edaf-d83d-48b5-9adf-03dbe19f53bd");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int AuthenticateEx(ref HWND phwnd, ref IntPtr pszUsername, ref IntPtr pszPassword, ref AUTHENTICATEINFO pauthinfo)
        {
            if(m_AuthenticateExFunc==null){
                var fp = GetFunctionPointer(4);
                m_AuthenticateExFunc = (AuthenticateExFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AuthenticateExFunc));
            } 
            
            return  m_AuthenticateExFunc(m_ptr, ref phwnd, ref pszUsername, ref pszPassword, ref pauthinfo);
        }
        delegate int AuthenticateExFunc(IntPtr self, ref HWND phwnd, ref IntPtr pszUsername, ref IntPtr pszPassword, ref AUTHENTICATEINFO pauthinfo);
        AuthenticateExFunc m_AuthenticateExFunc;

    }
}