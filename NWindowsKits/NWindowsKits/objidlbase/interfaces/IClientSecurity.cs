// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:3979
    public class IClientSecurity : IUnknown // 1
    {
        static Guid s_uuid = new Guid("0000013d-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int QueryBlanket(IntPtr pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref IntPtr pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref IntPtr pAuthInfo, ref uint pCapabilites)
        {
            if(m_QueryBlanketFunc==null){
                var fp = GetFunctionPointer(3);
                m_QueryBlanketFunc = (QueryBlanketFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryBlanketFunc));
            } 
            
            return  m_QueryBlanketFunc(m_ptr, pProxy, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }
        delegate int QueryBlanketFunc(IntPtr self, IntPtr pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref IntPtr pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref IntPtr pAuthInfo, ref uint pCapabilites);
        QueryBlanketFunc m_QueryBlanketFunc;

        public int SetBlanket(IntPtr pProxy, uint dwAuthnSvc, uint dwAuthzSvc, IntPtr pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, IntPtr pAuthInfo, uint dwCapabilities)
        {
            if(m_SetBlanketFunc==null){
                var fp = GetFunctionPointer(4);
                m_SetBlanketFunc = (SetBlanketFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBlanketFunc));
            } 
            
            return  m_SetBlanketFunc(m_ptr, pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
        }
        delegate int SetBlanketFunc(IntPtr self, IntPtr pProxy, uint dwAuthnSvc, uint dwAuthzSvc, IntPtr pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, IntPtr pAuthInfo, uint dwCapabilities);
        SetBlanketFunc m_SetBlanketFunc;

        public int CopyProxy(IntPtr pProxy, ref IntPtr ppCopy)
        {
            if(m_CopyProxyFunc==null){
                var fp = GetFunctionPointer(5);
                m_CopyProxyFunc = (CopyProxyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyProxyFunc));
            } 
            
            return  m_CopyProxyFunc(m_ptr, pProxy, ref ppCopy);
        }
        delegate int CopyProxyFunc(IntPtr self, IntPtr pProxy, ref IntPtr ppCopy);
        CopyProxyFunc m_CopyProxyFunc;

    }
}
