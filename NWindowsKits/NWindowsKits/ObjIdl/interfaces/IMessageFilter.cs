// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:12595
    public class IMessageFilter : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000016-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public uint HandleInComingCall(uint dwCallType, HTASK htaskCaller, uint dwTickCount, ref LPINTERFACEINFO lpInterfaceInfo)
        {
            if(m_HandleInComingCallFunc==null){
                var fp = GetFunctionPointer(3);
                m_HandleInComingCallFunc = (HandleInComingCallFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HandleInComingCallFunc));
            } 
            
            return  m_HandleInComingCallFunc(m_ptr, dwCallType, htaskCaller, dwTickCount, ref lpInterfaceInfo);
        }
        delegate uint HandleInComingCallFunc(IntPtr self, uint dwCallType, HTASK htaskCaller, uint dwTickCount, ref LPINTERFACEINFO lpInterfaceInfo);
        HandleInComingCallFunc m_HandleInComingCallFunc;

        public uint RetryRejectedCall(HTASK htaskCallee, uint dwTickCount, uint dwRejectType)
        {
            if(m_RetryRejectedCallFunc==null){
                var fp = GetFunctionPointer(4);
                m_RetryRejectedCallFunc = (RetryRejectedCallFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RetryRejectedCallFunc));
            } 
            
            return  m_RetryRejectedCallFunc(m_ptr, htaskCallee, dwTickCount, dwRejectType);
        }
        delegate uint RetryRejectedCallFunc(IntPtr self, HTASK htaskCallee, uint dwTickCount, uint dwRejectType);
        RetryRejectedCallFunc m_RetryRejectedCallFunc;

        public uint MessagePending(HTASK htaskCallee, uint dwTickCount, uint dwPendingType)
        {
            if(m_MessagePendingFunc==null){
                var fp = GetFunctionPointer(5);
                m_MessagePendingFunc = (MessagePendingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MessagePendingFunc));
            } 
            
            return  m_MessagePendingFunc(m_ptr, htaskCallee, dwTickCount, dwPendingType);
        }
        delegate uint MessagePendingFunc(IntPtr self, HTASK htaskCallee, uint dwTickCount, uint dwPendingType);
        MessagePendingFunc m_MessagePendingFunc;

    }
}
