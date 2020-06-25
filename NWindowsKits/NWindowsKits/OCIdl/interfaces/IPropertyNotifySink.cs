// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:2204
    public class IPropertyNotifySink : IUnknown // 1
    {
        static Guid s_uuid = new Guid("9bfbbc02-eff1-101a-84ed-00aa00341d07");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int OnChanged(int dispID)
        {
            if(m_OnChangedFunc==null){
                var fp = GetFunctionPointer(3);
                m_OnChangedFunc = (OnChangedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnChangedFunc));
            } 
            
            return  m_OnChangedFunc(m_ptr, dispID);
        }
        delegate int OnChangedFunc(IntPtr self, int dispID);
        OnChangedFunc m_OnChangedFunc;

        public int OnRequestEdit(int dispID)
        {
            if(m_OnRequestEditFunc==null){
                var fp = GetFunctionPointer(4);
                m_OnRequestEditFunc = (OnRequestEditFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnRequestEditFunc));
            } 
            
            return  m_OnRequestEditFunc(m_ptr, dispID);
        }
        delegate int OnRequestEditFunc(IntPtr self, int dispID);
        OnRequestEditFunc m_OnRequestEditFunc;

    }
}
