// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:5402
    public class IAsyncManager : IUnknown // 1
    {
        static Guid s_uuid = new Guid("0000002a-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int CompleteCall(int Result)
        {
            if(m_CompleteCallFunc==null){
                var fp = GetFunctionPointer(3);
                m_CompleteCallFunc = (CompleteCallFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CompleteCallFunc));
            } 
            
            return  m_CompleteCallFunc(m_ptr, Result);
        }
        delegate int CompleteCallFunc(IntPtr self, int Result);
        CompleteCallFunc m_CompleteCallFunc;

        public int GetCallContext(ref Guid riid, ref IntPtr pInterface)
        {
            if(m_GetCallContextFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetCallContextFunc = (GetCallContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCallContextFunc));
            } 
            
            return  m_GetCallContextFunc(m_ptr, ref riid, ref pInterface);
        }
        delegate int GetCallContextFunc(IntPtr self, ref Guid riid, ref IntPtr pInterface);
        GetCallContextFunc m_GetCallContextFunc;

        public int GetState(IntPtr pulStateFlags)
        {
            if(m_GetStateFunc==null){
                var fp = GetFunctionPointer(5);
                m_GetStateFunc = (GetStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetStateFunc));
            } 
            
            return  m_GetStateFunc(m_ptr, pulStateFlags);
        }
        delegate int GetStateFunc(IntPtr self, IntPtr pulStateFlags);
        GetStateFunc m_GetStateFunc;

    }
}
