// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi.h:313
    public class IDXGIObject : IUnknown // 1
    {
        static Guid s_uuid = new Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetPrivateData(ref GUID Name, uint DataSize, IntPtr pData)
        {
            if(m_SetPrivateDataFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetPrivateDataFunc = (SetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataFunc));
            } 
            
            return  m_SetPrivateDataFunc(m_ptr, ref Name, DataSize, pData);
        }
        delegate int SetPrivateDataFunc(IntPtr self, ref GUID Name, uint DataSize, IntPtr pData);
        SetPrivateDataFunc m_SetPrivateDataFunc;

        public int SetPrivateDataInterface(ref GUID Name, IntPtr pUnknown)
        {
            if(m_SetPrivateDataInterfaceFunc==null){
                var fp = GetFunctionPointer(4);
                m_SetPrivateDataInterfaceFunc = (SetPrivateDataInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPrivateDataInterfaceFunc));
            } 
            
            return  m_SetPrivateDataInterfaceFunc(m_ptr, ref Name, pUnknown);
        }
        delegate int SetPrivateDataInterfaceFunc(IntPtr self, ref GUID Name, IntPtr pUnknown);
        SetPrivateDataInterfaceFunc m_SetPrivateDataInterfaceFunc;

        public int GetPrivateData(ref GUID Name, ref uint pDataSize, IntPtr pData)
        {
            if(m_GetPrivateDataFunc==null){
                var fp = GetFunctionPointer(5);
                m_GetPrivateDataFunc = (GetPrivateDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPrivateDataFunc));
            } 
            
            return  m_GetPrivateDataFunc(m_ptr, ref Name, ref pDataSize, pData);
        }
        delegate int GetPrivateDataFunc(IntPtr self, ref GUID Name, ref uint pDataSize, IntPtr pData);
        GetPrivateDataFunc m_GetPrivateDataFunc;

        public int GetParent(ref Guid riid, ref IntPtr ppParent)
        {
            if(m_GetParentFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetParentFunc = (GetParentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetParentFunc));
            } 
            
            return  m_GetParentFunc(m_ptr, ref riid, ref ppParent);
        }
        delegate int GetParentFunc(IntPtr self, ref Guid riid, ref IntPtr ppParent);
        GetParentFunc m_GetParentFunc;

    }
}
