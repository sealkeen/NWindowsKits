// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:9233
    public class IPersistStream : IPersist // 1
    {
        static Guid s_uuid = new Guid("00000109-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

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

        public int Load(IntPtr pStm)
        {
            if(m_LoadFunc==null){
                var fp = GetFunctionPointer(5);
                m_LoadFunc = (LoadFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LoadFunc));
            } 
            
            return  m_LoadFunc(m_ptr, pStm);
        }
        delegate int LoadFunc(IntPtr self, IntPtr pStm);
        LoadFunc m_LoadFunc;

        public int Save(IntPtr pStm, int fClearDirty)
        {
            if(m_SaveFunc==null){
                var fp = GetFunctionPointer(6);
                m_SaveFunc = (SaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SaveFunc));
            } 
            
            return  m_SaveFunc(m_ptr, pStm, fClearDirty);
        }
        delegate int SaveFunc(IntPtr self, IntPtr pStm, int fClearDirty);
        SaveFunc m_SaveFunc;

        public int GetSizeMax(ref ULARGE_INTEGER pcbSize)
        {
            if(m_GetSizeMaxFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetSizeMaxFunc = (GetSizeMaxFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeMaxFunc));
            } 
            
            return  m_GetSizeMaxFunc(m_ptr, ref pcbSize);
        }
        delegate int GetSizeMaxFunc(IntPtr self, ref ULARGE_INTEGER pcbSize);
        GetSizeMaxFunc m_GetSizeMaxFunc;

    }
}
