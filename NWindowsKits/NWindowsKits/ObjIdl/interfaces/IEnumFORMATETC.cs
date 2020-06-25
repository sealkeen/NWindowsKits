// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:10854
    public class IEnumFORMATETC : IUnknown // 2
    {
        static Guid s_uuid = new Guid("00000103-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Next(uint celt, ref FORMATETC rgelt, IntPtr pceltFetched)
        {
            if(m_NextFunc==null){
                var fp = GetFunctionPointer(3);
                m_NextFunc = (NextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NextFunc));
            } 
            
            return  m_NextFunc(m_ptr, celt, ref rgelt, pceltFetched);
        }
        delegate int NextFunc(IntPtr self, uint celt, ref FORMATETC rgelt, IntPtr pceltFetched);
        NextFunc m_NextFunc;

        public int Skip(uint celt)
        {
            if(m_SkipFunc==null){
                var fp = GetFunctionPointer(4);
                m_SkipFunc = (SkipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SkipFunc));
            } 
            
            return  m_SkipFunc(m_ptr, celt);
        }
        delegate int SkipFunc(IntPtr self, uint celt);
        SkipFunc m_SkipFunc;

        public int Reset()
        {
            if(m_ResetFunc==null){
                var fp = GetFunctionPointer(5);
                m_ResetFunc = (ResetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResetFunc));
            } 
            
            return  m_ResetFunc(m_ptr);
        }
        delegate int ResetFunc(IntPtr self);
        ResetFunc m_ResetFunc;

        public int Clone(ref IntPtr ppenum)
        {
            if(m_CloneFunc==null){
                var fp = GetFunctionPointer(6);
                m_CloneFunc = (CloneFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloneFunc));
            } 
            
            return  m_CloneFunc(m_ptr, ref ppenum);
        }
        delegate int CloneFunc(IntPtr self, ref IntPtr ppenum);
        CloneFunc m_CloneFunc;

    }
}
