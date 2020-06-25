// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:3296
    public class IRpcProxyBuffer : IUnknown // 1
    {
        static Guid s_uuid = new Guid("d5f56a34-593b-101a-b569-08002b2dbf7a");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Connect(IntPtr pRpcChannelBuffer)
        {
            if(m_ConnectFunc==null){
                var fp = GetFunctionPointer(3);
                m_ConnectFunc = (ConnectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConnectFunc));
            } 
            
            return  m_ConnectFunc(m_ptr, pRpcChannelBuffer);
        }
        delegate int ConnectFunc(IntPtr self, IntPtr pRpcChannelBuffer);
        ConnectFunc m_ConnectFunc;

        public void Disconnect()
        {
            if(m_DisconnectFunc==null){
                var fp = GetFunctionPointer(4);
                m_DisconnectFunc = (DisconnectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DisconnectFunc));
            } 
            
             m_DisconnectFunc(m_ptr);
        }
        delegate void DisconnectFunc(IntPtr self);
        DisconnectFunc m_DisconnectFunc;

    }
}
