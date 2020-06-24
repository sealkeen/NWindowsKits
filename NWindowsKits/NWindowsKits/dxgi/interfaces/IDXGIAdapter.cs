// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi.h:1256
    public class IDXGIAdapter : IDXGIObject // 1
    {
        static Guid s_uuid = new Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int EnumOutputs(uint Output, ref IntPtr ppOutput)
        {
            if(m_EnumOutputsFunc==null){
                var fp = GetFunctionPointer(7);
                m_EnumOutputsFunc = (EnumOutputsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumOutputsFunc));
            } 
            
            return  m_EnumOutputsFunc(m_ptr, Output, ref ppOutput);
        }
        delegate int EnumOutputsFunc(IntPtr self, uint Output, ref IntPtr ppOutput);
        EnumOutputsFunc m_EnumOutputsFunc;

        public int GetDesc(ref DXGI_ADAPTER_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
            
            return  m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate int GetDescFunc(IntPtr self, ref DXGI_ADAPTER_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public int CheckInterfaceSupport(ref GUID InterfaceName, ref LARGE_INTEGER pUMDVersion)
        {
            if(m_CheckInterfaceSupportFunc==null){
                var fp = GetFunctionPointer(9);
                m_CheckInterfaceSupportFunc = (CheckInterfaceSupportFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CheckInterfaceSupportFunc));
            } 
            
            return  m_CheckInterfaceSupportFunc(m_ptr, ref InterfaceName, ref pUMDVersion);
        }
        delegate int CheckInterfaceSupportFunc(IntPtr self, ref GUID InterfaceName, ref LARGE_INTEGER pUMDVersion);
        CheckInterfaceSupportFunc m_CheckInterfaceSupportFunc;

    }
}