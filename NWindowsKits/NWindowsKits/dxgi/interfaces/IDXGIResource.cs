// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi.h:583
    public class IDXGIResource : IDXGIDeviceSubObject // 1
    {
        static Guid s_uuid = new Guid("035f3ab4-482e-4e50-b41f-8a7f8bd8960b");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetSharedHandle(ref IntPtr pSharedHandle)
        {
            if(m_GetSharedHandleFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetSharedHandleFunc = (GetSharedHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSharedHandleFunc));
            } 
            
            return  m_GetSharedHandleFunc(m_ptr, ref pSharedHandle);
        }
        delegate int GetSharedHandleFunc(IntPtr self, ref IntPtr pSharedHandle);
        GetSharedHandleFunc m_GetSharedHandleFunc;

        public int GetUsage(IntPtr pUsage)
        {
            if(m_GetUsageFunc==null){
                var fp = GetFunctionPointer(9);
                m_GetUsageFunc = (GetUsageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetUsageFunc));
            } 
            
            return  m_GetUsageFunc(m_ptr, pUsage);
        }
        delegate int GetUsageFunc(IntPtr self, IntPtr pUsage);
        GetUsageFunc m_GetUsageFunc;

        public int SetEvictionPriority(uint EvictionPriority)
        {
            if(m_SetEvictionPriorityFunc==null){
                var fp = GetFunctionPointer(10);
                m_SetEvictionPriorityFunc = (SetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetEvictionPriorityFunc));
            } 
            
            return  m_SetEvictionPriorityFunc(m_ptr, EvictionPriority);
        }
        delegate int SetEvictionPriorityFunc(IntPtr self, uint EvictionPriority);
        SetEvictionPriorityFunc m_SetEvictionPriorityFunc;

        public int GetEvictionPriority(IntPtr pEvictionPriority)
        {
            if(m_GetEvictionPriorityFunc==null){
                var fp = GetFunctionPointer(11);
                m_GetEvictionPriorityFunc = (GetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEvictionPriorityFunc));
            } 
            
            return  m_GetEvictionPriorityFunc(m_ptr, pEvictionPriority);
        }
        delegate int GetEvictionPriorityFunc(IntPtr self, IntPtr pEvictionPriority);
        GetEvictionPriorityFunc m_GetEvictionPriorityFunc;

    }
}
