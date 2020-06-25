// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:6203
    public class IInternetThreadSwitch : IUnknown // 1
    {
        static Guid s_uuid = new Guid("79eac9e8-baf9-11ce-8c82-00aa004ba90b");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Prepare()
        {
            if(m_PrepareFunc==null){
                var fp = GetFunctionPointer(3);
                m_PrepareFunc = (PrepareFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PrepareFunc));
            } 
            
            return  m_PrepareFunc(m_ptr);
        }
        delegate int PrepareFunc(IntPtr self);
        PrepareFunc m_PrepareFunc;

        public int Continue()
        {
            if(m_ContinueFunc==null){
                var fp = GetFunctionPointer(4);
                m_ContinueFunc = (ContinueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ContinueFunc));
            } 
            
            return  m_ContinueFunc(m_ptr);
        }
        delegate int ContinueFunc(IntPtr self);
        ContinueFunc m_ContinueFunc;

    }
}