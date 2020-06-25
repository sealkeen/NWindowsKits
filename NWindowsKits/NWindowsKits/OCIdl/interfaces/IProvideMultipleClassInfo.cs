// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:1318
    public class IProvideMultipleClassInfo : IProvideClassInfo2 // 1
    {
        static Guid s_uuid = new Guid("a7aba9c1-8983-11cf-8f20-00805f2cd064");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetMultiTypeInfoCount(IntPtr pcti)
        {
            if(m_GetMultiTypeInfoCountFunc==null){
                var fp = GetFunctionPointer(5);
                m_GetMultiTypeInfoCountFunc = (GetMultiTypeInfoCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMultiTypeInfoCountFunc));
            } 
            
            return  m_GetMultiTypeInfoCountFunc(m_ptr, pcti);
        }
        delegate int GetMultiTypeInfoCountFunc(IntPtr self, IntPtr pcti);
        GetMultiTypeInfoCountFunc m_GetMultiTypeInfoCountFunc;

        public int GetInfoOfIndex(uint iti, uint dwFlags, ref IntPtr pptiCoClass, ref uint pdwTIFlags, IntPtr pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
        {
            if(m_GetInfoOfIndexFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetInfoOfIndexFunc = (GetInfoOfIndexFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetInfoOfIndexFunc));
            } 
            
            return  m_GetInfoOfIndexFunc(m_ptr, iti, dwFlags, ref pptiCoClass, ref pdwTIFlags, pcdispidReserved, ref piidPrimary, ref piidSource);
        }
        delegate int GetInfoOfIndexFunc(IntPtr self, uint iti, uint dwFlags, ref IntPtr pptiCoClass, ref uint pdwTIFlags, IntPtr pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource);
        GetInfoOfIndexFunc m_GetInfoOfIndexFunc;

    }
}