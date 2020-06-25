// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:2078
    public class ISequentialStream : IUnknown // 1
    {
        static Guid s_uuid = new Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Read(IntPtr pv, uint cb, IntPtr pcbRead)
        {
            if(m_ReadFunc==null){
                var fp = GetFunctionPointer(3);
                m_ReadFunc = (ReadFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadFunc));
            } 
            
            return  m_ReadFunc(m_ptr, pv, cb, pcbRead);
        }
        delegate int ReadFunc(IntPtr self, IntPtr pv, uint cb, IntPtr pcbRead);
        ReadFunc m_ReadFunc;

        public int Write(IntPtr pv, uint cb, IntPtr pcbWritten)
        {
            if(m_WriteFunc==null){
                var fp = GetFunctionPointer(4);
                m_WriteFunc = (WriteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteFunc));
            } 
            
            return  m_WriteFunc(m_ptr, pv, cb, pcbWritten);
        }
        delegate int WriteFunc(IntPtr self, IntPtr pv, uint cb, IntPtr pcbWritten);
        WriteFunc m_WriteFunc;

    }
}
