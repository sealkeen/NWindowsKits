// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:7318
    public class IInternetSecurityManagerEx : IInternetSecurityManager // 1
    {
        static Guid s_uuid = new Guid("f164edf1-cc7c-4f0d-9a94-34222625c393");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int ProcessUrlActionEx([MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, uint dwAction, ref byte pPolicy, uint cbPolicy, ref byte pContext, uint cbContext, uint dwFlags, uint dwReserved, ref uint pdwOutFlags)
        {
            if(m_ProcessUrlActionExFunc==null){
                var fp = GetFunctionPointer(11);
                m_ProcessUrlActionExFunc = (ProcessUrlActionExFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ProcessUrlActionExFunc));
            } 
            
            return  m_ProcessUrlActionExFunc(m_ptr, pwszUrl, dwAction, ref pPolicy, cbPolicy, ref pContext, cbContext, dwFlags, dwReserved, ref pdwOutFlags);
        }
        delegate int ProcessUrlActionExFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, uint dwAction, ref byte pPolicy, uint cbPolicy, ref byte pContext, uint cbContext, uint dwFlags, uint dwReserved, ref uint pdwOutFlags);
        ProcessUrlActionExFunc m_ProcessUrlActionExFunc;

    }
}
