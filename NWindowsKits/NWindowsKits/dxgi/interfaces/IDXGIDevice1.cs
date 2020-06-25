// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi.h:2750
    public class IDXGIDevice1 : IDXGIDevice // 1
    {
        static Guid s_uuid = new Guid("77db970f-6276-48ba-ba28-070143b4392c");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetMaximumFrameLatency(uint MaxLatency)
        {
            if(m_SetMaximumFrameLatencyFunc==null){
                var fp = GetFunctionPointer(12);
                m_SetMaximumFrameLatencyFunc = (SetMaximumFrameLatencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMaximumFrameLatencyFunc));
            } 
            
            return  m_SetMaximumFrameLatencyFunc(m_ptr, MaxLatency);
        }
        delegate int SetMaximumFrameLatencyFunc(IntPtr self, uint MaxLatency);
        SetMaximumFrameLatencyFunc m_SetMaximumFrameLatencyFunc;

        public int GetMaximumFrameLatency(ref uint pMaxLatency)
        {
            if(m_GetMaximumFrameLatencyFunc==null){
                var fp = GetFunctionPointer(13);
                m_GetMaximumFrameLatencyFunc = (GetMaximumFrameLatencyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMaximumFrameLatencyFunc));
            } 
            
            return  m_GetMaximumFrameLatencyFunc(m_ptr, ref pMaxLatency);
        }
        delegate int GetMaximumFrameLatencyFunc(IntPtr self, ref uint pMaxLatency);
        GetMaximumFrameLatencyFunc m_GetMaximumFrameLatencyFunc;

    }
}
