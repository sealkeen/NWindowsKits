// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:1203
    public class IOleObject : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000112-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetClientSite(IntPtr pClientSite)
        {
            if(m_SetClientSiteFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetClientSiteFunc = (SetClientSiteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetClientSiteFunc));
            } 
            
            return  m_SetClientSiteFunc(m_ptr, pClientSite);
        }
        delegate int SetClientSiteFunc(IntPtr self, IntPtr pClientSite);
        SetClientSiteFunc m_SetClientSiteFunc;

        public int GetClientSite(ref IntPtr ppClientSite)
        {
            if(m_GetClientSiteFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetClientSiteFunc = (GetClientSiteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClientSiteFunc));
            } 
            
            return  m_GetClientSiteFunc(m_ptr, ref ppClientSite);
        }
        delegate int GetClientSiteFunc(IntPtr self, ref IntPtr ppClientSite);
        GetClientSiteFunc m_GetClientSiteFunc;

        public int SetHostNames(IntPtr szContainerApp, IntPtr szContainerObj)
        {
            if(m_SetHostNamesFunc==null){
                var fp = GetFunctionPointer(5);
                m_SetHostNamesFunc = (SetHostNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetHostNamesFunc));
            } 
            
            return  m_SetHostNamesFunc(m_ptr, szContainerApp, szContainerObj);
        }
        delegate int SetHostNamesFunc(IntPtr self, IntPtr szContainerApp, IntPtr szContainerObj);
        SetHostNamesFunc m_SetHostNamesFunc;

        public int Close(uint dwSaveOption)
        {
            if(m_CloseFunc==null){
                var fp = GetFunctionPointer(6);
                m_CloseFunc = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
            } 
            
            return  m_CloseFunc(m_ptr, dwSaveOption);
        }
        delegate int CloseFunc(IntPtr self, uint dwSaveOption);
        CloseFunc m_CloseFunc;

        public int SetMoniker(uint dwWhichMoniker, IntPtr pmk)
        {
            if(m_SetMonikerFunc==null){
                var fp = GetFunctionPointer(7);
                m_SetMonikerFunc = (SetMonikerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMonikerFunc));
            } 
            
            return  m_SetMonikerFunc(m_ptr, dwWhichMoniker, pmk);
        }
        delegate int SetMonikerFunc(IntPtr self, uint dwWhichMoniker, IntPtr pmk);
        SetMonikerFunc m_SetMonikerFunc;

        public int GetMoniker(uint dwAssign, uint dwWhichMoniker, ref IntPtr ppmk)
        {
            if(m_GetMonikerFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetMonikerFunc = (GetMonikerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMonikerFunc));
            } 
            
            return  m_GetMonikerFunc(m_ptr, dwAssign, dwWhichMoniker, ref ppmk);
        }
        delegate int GetMonikerFunc(IntPtr self, uint dwAssign, uint dwWhichMoniker, ref IntPtr ppmk);
        GetMonikerFunc m_GetMonikerFunc;

        public int InitFromData(IntPtr pDataObject, int fCreation, uint dwReserved)
        {
            if(m_InitFromDataFunc==null){
                var fp = GetFunctionPointer(9);
                m_InitFromDataFunc = (InitFromDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InitFromDataFunc));
            } 
            
            return  m_InitFromDataFunc(m_ptr, pDataObject, fCreation, dwReserved);
        }
        delegate int InitFromDataFunc(IntPtr self, IntPtr pDataObject, int fCreation, uint dwReserved);
        InitFromDataFunc m_InitFromDataFunc;

        public int GetClipboardData(uint dwReserved, ref IntPtr ppDataObject)
        {
            if(m_GetClipboardDataFunc==null){
                var fp = GetFunctionPointer(10);
                m_GetClipboardDataFunc = (GetClipboardDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClipboardDataFunc));
            } 
            
            return  m_GetClipboardDataFunc(m_ptr, dwReserved, ref ppDataObject);
        }
        delegate int GetClipboardDataFunc(IntPtr self, uint dwReserved, ref IntPtr ppDataObject);
        GetClipboardDataFunc m_GetClipboardDataFunc;

        public int DoVerb(int iVerb, ref MSG lpmsg, IntPtr pActiveSite, int lindex, HWND hwndParent, ref RECT lprcPosRect)
        {
            if(m_DoVerbFunc==null){
                var fp = GetFunctionPointer(11);
                m_DoVerbFunc = (DoVerbFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DoVerbFunc));
            } 
            
            return  m_DoVerbFunc(m_ptr, iVerb, ref lpmsg, pActiveSite, lindex, hwndParent, ref lprcPosRect);
        }
        delegate int DoVerbFunc(IntPtr self, int iVerb, ref MSG lpmsg, IntPtr pActiveSite, int lindex, HWND hwndParent, ref RECT lprcPosRect);
        DoVerbFunc m_DoVerbFunc;

        public int EnumVerbs(ref IntPtr ppEnumOleVerb)
        {
            if(m_EnumVerbsFunc==null){
                var fp = GetFunctionPointer(12);
                m_EnumVerbsFunc = (EnumVerbsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumVerbsFunc));
            } 
            
            return  m_EnumVerbsFunc(m_ptr, ref ppEnumOleVerb);
        }
        delegate int EnumVerbsFunc(IntPtr self, ref IntPtr ppEnumOleVerb);
        EnumVerbsFunc m_EnumVerbsFunc;

        public int Update()
        {
            if(m_UpdateFunc==null){
                var fp = GetFunctionPointer(13);
                m_UpdateFunc = (UpdateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UpdateFunc));
            } 
            
            return  m_UpdateFunc(m_ptr);
        }
        delegate int UpdateFunc(IntPtr self);
        UpdateFunc m_UpdateFunc;

        public int IsUpToDate()
        {
            if(m_IsUpToDateFunc==null){
                var fp = GetFunctionPointer(14);
                m_IsUpToDateFunc = (IsUpToDateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsUpToDateFunc));
            } 
            
            return  m_IsUpToDateFunc(m_ptr);
        }
        delegate int IsUpToDateFunc(IntPtr self);
        IsUpToDateFunc m_IsUpToDateFunc;

        public int GetUserClassID(IntPtr pClsid)
        {
            if(m_GetUserClassIDFunc==null){
                var fp = GetFunctionPointer(15);
                m_GetUserClassIDFunc = (GetUserClassIDFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetUserClassIDFunc));
            } 
            
            return  m_GetUserClassIDFunc(m_ptr, pClsid);
        }
        delegate int GetUserClassIDFunc(IntPtr self, IntPtr pClsid);
        GetUserClassIDFunc m_GetUserClassIDFunc;

        public int GetUserType(uint dwFormOfType, ref IntPtr pszUserType)
        {
            if(m_GetUserTypeFunc==null){
                var fp = GetFunctionPointer(16);
                m_GetUserTypeFunc = (GetUserTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetUserTypeFunc));
            } 
            
            return  m_GetUserTypeFunc(m_ptr, dwFormOfType, ref pszUserType);
        }
        delegate int GetUserTypeFunc(IntPtr self, uint dwFormOfType, ref IntPtr pszUserType);
        GetUserTypeFunc m_GetUserTypeFunc;

        public int SetExtent(uint dwDrawAspect, IntPtr psizel)
        {
            if(m_SetExtentFunc==null){
                var fp = GetFunctionPointer(17);
                m_SetExtentFunc = (SetExtentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetExtentFunc));
            } 
            
            return  m_SetExtentFunc(m_ptr, dwDrawAspect, psizel);
        }
        delegate int SetExtentFunc(IntPtr self, uint dwDrawAspect, IntPtr psizel);
        SetExtentFunc m_SetExtentFunc;

        public int GetExtent(uint dwDrawAspect, IntPtr psizel)
        {
            if(m_GetExtentFunc==null){
                var fp = GetFunctionPointer(18);
                m_GetExtentFunc = (GetExtentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtentFunc));
            } 
            
            return  m_GetExtentFunc(m_ptr, dwDrawAspect, psizel);
        }
        delegate int GetExtentFunc(IntPtr self, uint dwDrawAspect, IntPtr psizel);
        GetExtentFunc m_GetExtentFunc;

        public int Advise(IntPtr pAdvSink, ref uint pdwConnection)
        {
            if(m_AdviseFunc==null){
                var fp = GetFunctionPointer(19);
                m_AdviseFunc = (AdviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AdviseFunc));
            } 
            
            return  m_AdviseFunc(m_ptr, pAdvSink, ref pdwConnection);
        }
        delegate int AdviseFunc(IntPtr self, IntPtr pAdvSink, ref uint pdwConnection);
        AdviseFunc m_AdviseFunc;

        public int Unadvise(uint dwConnection)
        {
            if(m_UnadviseFunc==null){
                var fp = GetFunctionPointer(20);
                m_UnadviseFunc = (UnadviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnadviseFunc));
            } 
            
            return  m_UnadviseFunc(m_ptr, dwConnection);
        }
        delegate int UnadviseFunc(IntPtr self, uint dwConnection);
        UnadviseFunc m_UnadviseFunc;

        public int EnumAdvise(ref IntPtr ppenumAdvise)
        {
            if(m_EnumAdviseFunc==null){
                var fp = GetFunctionPointer(21);
                m_EnumAdviseFunc = (EnumAdviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumAdviseFunc));
            } 
            
            return  m_EnumAdviseFunc(m_ptr, ref ppenumAdvise);
        }
        delegate int EnumAdviseFunc(IntPtr self, ref IntPtr ppenumAdvise);
        EnumAdviseFunc m_EnumAdviseFunc;

        public int GetMiscStatus(uint dwAspect, ref uint pdwStatus)
        {
            if(m_GetMiscStatusFunc==null){
                var fp = GetFunctionPointer(22);
                m_GetMiscStatusFunc = (GetMiscStatusFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetMiscStatusFunc));
            } 
            
            return  m_GetMiscStatusFunc(m_ptr, dwAspect, ref pdwStatus);
        }
        delegate int GetMiscStatusFunc(IntPtr self, uint dwAspect, ref uint pdwStatus);
        GetMiscStatusFunc m_GetMiscStatusFunc;

        public int SetColorScheme(ref LOGPALETTE pLogpal)
        {
            if(m_SetColorSchemeFunc==null){
                var fp = GetFunctionPointer(23);
                m_SetColorSchemeFunc = (SetColorSchemeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetColorSchemeFunc));
            } 
            
            return  m_SetColorSchemeFunc(m_ptr, ref pLogpal);
        }
        delegate int SetColorSchemeFunc(IntPtr self, ref LOGPALETTE pLogpal);
        SetColorSchemeFunc m_SetColorSchemeFunc;

    }
}
