// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:8506
    public class IBindCtx : IUnknown // 1
    {
        static Guid s_uuid = new Guid("0000000e-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int RegisterObjectBound(IntPtr punk)
        {
            if(m_RegisterObjectBoundFunc==null){
                var fp = GetFunctionPointer(3);
                m_RegisterObjectBoundFunc = (RegisterObjectBoundFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterObjectBoundFunc));
            } 
            
            return  m_RegisterObjectBoundFunc(m_ptr, punk);
        }
        delegate int RegisterObjectBoundFunc(IntPtr self, IntPtr punk);
        RegisterObjectBoundFunc m_RegisterObjectBoundFunc;

        public int RevokeObjectBound(IntPtr punk)
        {
            if(m_RevokeObjectBoundFunc==null){
                var fp = GetFunctionPointer(4);
                m_RevokeObjectBoundFunc = (RevokeObjectBoundFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RevokeObjectBoundFunc));
            } 
            
            return  m_RevokeObjectBoundFunc(m_ptr, punk);
        }
        delegate int RevokeObjectBoundFunc(IntPtr self, IntPtr punk);
        RevokeObjectBoundFunc m_RevokeObjectBoundFunc;

        public int ReleaseBoundObjects()
        {
            if(m_ReleaseBoundObjectsFunc==null){
                var fp = GetFunctionPointer(5);
                m_ReleaseBoundObjectsFunc = (ReleaseBoundObjectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseBoundObjectsFunc));
            } 
            
            return  m_ReleaseBoundObjectsFunc(m_ptr);
        }
        delegate int ReleaseBoundObjectsFunc(IntPtr self);
        ReleaseBoundObjectsFunc m_ReleaseBoundObjectsFunc;

        public int SetBindOptions(ref BIND_OPTS pbindopts)
        {
            if(m_SetBindOptionsFunc==null){
                var fp = GetFunctionPointer(6);
                m_SetBindOptionsFunc = (SetBindOptionsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBindOptionsFunc));
            } 
            
            return  m_SetBindOptionsFunc(m_ptr, ref pbindopts);
        }
        delegate int SetBindOptionsFunc(IntPtr self, ref BIND_OPTS pbindopts);
        SetBindOptionsFunc m_SetBindOptionsFunc;

        public int GetBindOptions(ref BIND_OPTS pbindopts)
        {
            if(m_GetBindOptionsFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetBindOptionsFunc = (GetBindOptionsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBindOptionsFunc));
            } 
            
            return  m_GetBindOptionsFunc(m_ptr, ref pbindopts);
        }
        delegate int GetBindOptionsFunc(IntPtr self, ref BIND_OPTS pbindopts);
        GetBindOptionsFunc m_GetBindOptionsFunc;

        public int GetRunningObjectTable(ref IntPtr pprot)
        {
            if(m_GetRunningObjectTableFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetRunningObjectTableFunc = (GetRunningObjectTableFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRunningObjectTableFunc));
            } 
            
            return  m_GetRunningObjectTableFunc(m_ptr, ref pprot);
        }
        delegate int GetRunningObjectTableFunc(IntPtr self, ref IntPtr pprot);
        GetRunningObjectTableFunc m_GetRunningObjectTableFunc;

        public int RegisterObjectParam(IntPtr pszKey, IntPtr punk)
        {
            if(m_RegisterObjectParamFunc==null){
                var fp = GetFunctionPointer(9);
                m_RegisterObjectParamFunc = (RegisterObjectParamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterObjectParamFunc));
            } 
            
            return  m_RegisterObjectParamFunc(m_ptr, pszKey, punk);
        }
        delegate int RegisterObjectParamFunc(IntPtr self, IntPtr pszKey, IntPtr punk);
        RegisterObjectParamFunc m_RegisterObjectParamFunc;

        public int GetObjectParam(IntPtr pszKey, ref IntPtr ppunk)
        {
            if(m_GetObjectParamFunc==null){
                var fp = GetFunctionPointer(10);
                m_GetObjectParamFunc = (GetObjectParamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetObjectParamFunc));
            } 
            
            return  m_GetObjectParamFunc(m_ptr, pszKey, ref ppunk);
        }
        delegate int GetObjectParamFunc(IntPtr self, IntPtr pszKey, ref IntPtr ppunk);
        GetObjectParamFunc m_GetObjectParamFunc;

        public int EnumObjectParam(ref IntPtr ppenum)
        {
            if(m_EnumObjectParamFunc==null){
                var fp = GetFunctionPointer(11);
                m_EnumObjectParamFunc = (EnumObjectParamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumObjectParamFunc));
            } 
            
            return  m_EnumObjectParamFunc(m_ptr, ref ppenum);
        }
        delegate int EnumObjectParamFunc(IntPtr self, ref IntPtr ppenum);
        EnumObjectParamFunc m_EnumObjectParamFunc;

        public int RevokeObjectParam(IntPtr pszKey)
        {
            if(m_RevokeObjectParamFunc==null){
                var fp = GetFunctionPointer(12);
                m_RevokeObjectParamFunc = (RevokeObjectParamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RevokeObjectParamFunc));
            } 
            
            return  m_RevokeObjectParamFunc(m_ptr, pszKey);
        }
        delegate int RevokeObjectParamFunc(IntPtr self, IntPtr pszKey);
        RevokeObjectParamFunc m_RevokeObjectParamFunc;

    }
}
