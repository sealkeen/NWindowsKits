// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:5761
    public class IInternetProtocolSink : IUnknown // 1
    {
        static Guid s_uuid = new Guid("79eac9e5-baf9-11ce-8c82-00aa004ba90b");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Switch(ref PROTOCOLDATA pProtocolData)
        {
            if(m_SwitchFunc==null){
                var fp = GetFunctionPointer(3);
                m_SwitchFunc = (SwitchFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SwitchFunc));
            } 
            
            return  m_SwitchFunc(m_ptr, ref pProtocolData);
        }
        delegate int SwitchFunc(IntPtr self, ref PROTOCOLDATA pProtocolData);
        SwitchFunc m_SwitchFunc;

        public int ReportProgress(uint ulStatusCode, [MarshalAs(UnmanagedType.LPWStr)] string szStatusText)
        {
            if(m_ReportProgressFunc==null){
                var fp = GetFunctionPointer(4);
                m_ReportProgressFunc = (ReportProgressFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReportProgressFunc));
            } 
            
            return  m_ReportProgressFunc(m_ptr, ulStatusCode, szStatusText);
        }
        delegate int ReportProgressFunc(IntPtr self, uint ulStatusCode, [MarshalAs(UnmanagedType.LPWStr)] string szStatusText);
        ReportProgressFunc m_ReportProgressFunc;

        public int ReportData(uint grfBSCF, uint ulProgress, uint ulProgressMax)
        {
            if(m_ReportDataFunc==null){
                var fp = GetFunctionPointer(5);
                m_ReportDataFunc = (ReportDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReportDataFunc));
            } 
            
            return  m_ReportDataFunc(m_ptr, grfBSCF, ulProgress, ulProgressMax);
        }
        delegate int ReportDataFunc(IntPtr self, uint grfBSCF, uint ulProgress, uint ulProgressMax);
        ReportDataFunc m_ReportDataFunc;

        public int ReportResult(int hrResult, uint dwError, [MarshalAs(UnmanagedType.LPWStr)] string szResult)
        {
            if(m_ReportResultFunc==null){
                var fp = GetFunctionPointer(6);
                m_ReportResultFunc = (ReportResultFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReportResultFunc));
            } 
            
            return  m_ReportResultFunc(m_ptr, hrResult, dwError, szResult);
        }
        delegate int ReportResultFunc(IntPtr self, int hrResult, uint dwError, [MarshalAs(UnmanagedType.LPWStr)] string szResult);
        ReportResultFunc m_ReportResultFunc;

    }
}
