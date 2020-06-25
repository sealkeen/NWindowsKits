// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:794
    public class IPersistMoniker : IUnknown // 1
    {
        static Guid s_uuid = new Guid("79eac9c9-baf9-11ce-8c82-00aa004ba90b");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetClassID(IntPtr pClassID)
        {
            if(m_GetClassIDFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetClassIDFunc = (GetClassIDFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClassIDFunc));
            } 
            
            return  m_GetClassIDFunc(m_ptr, pClassID);
        }
        delegate int GetClassIDFunc(IntPtr self, IntPtr pClassID);
        GetClassIDFunc m_GetClassIDFunc;

        public int IsDirty()
        {
            if(m_IsDirtyFunc==null){
                var fp = GetFunctionPointer(4);
                m_IsDirtyFunc = (IsDirtyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsDirtyFunc));
            } 
            
            return  m_IsDirtyFunc(m_ptr);
        }
        delegate int IsDirtyFunc(IntPtr self);
        IsDirtyFunc m_IsDirtyFunc;

        public int Load(int fFullyAvailable, IntPtr pimkName, IntPtr pibc, uint grfMode)
        {
            if(m_LoadFunc==null){
                var fp = GetFunctionPointer(5);
                m_LoadFunc = (LoadFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LoadFunc));
            } 
            
            return  m_LoadFunc(m_ptr, fFullyAvailable, pimkName, pibc, grfMode);
        }
        delegate int LoadFunc(IntPtr self, int fFullyAvailable, IntPtr pimkName, IntPtr pibc, uint grfMode);
        LoadFunc m_LoadFunc;

        public int Save(IntPtr pimkName, IntPtr pbc, int fRemember)
        {
            if(m_SaveFunc==null){
                var fp = GetFunctionPointer(6);
                m_SaveFunc = (SaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SaveFunc));
            } 
            
            return  m_SaveFunc(m_ptr, pimkName, pbc, fRemember);
        }
        delegate int SaveFunc(IntPtr self, IntPtr pimkName, IntPtr pbc, int fRemember);
        SaveFunc m_SaveFunc;

        public int SaveCompleted(IntPtr pimkName, IntPtr pibc)
        {
            if(m_SaveCompletedFunc==null){
                var fp = GetFunctionPointer(7);
                m_SaveCompletedFunc = (SaveCompletedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SaveCompletedFunc));
            } 
            
            return  m_SaveCompletedFunc(m_ptr, pimkName, pibc);
        }
        delegate int SaveCompletedFunc(IntPtr self, IntPtr pimkName, IntPtr pibc);
        SaveCompletedFunc m_SaveCompletedFunc;

        public int GetCurMoniker(ref IntPtr ppimkName)
        {
            if(m_GetCurMonikerFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetCurMonikerFunc = (GetCurMonikerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCurMonikerFunc));
            } 
            
            return  m_GetCurMonikerFunc(m_ptr, ref ppimkName);
        }
        delegate int GetCurMonikerFunc(IntPtr self, ref IntPtr ppimkName);
        GetCurMonikerFunc m_GetCurMonikerFunc;

    }
}
