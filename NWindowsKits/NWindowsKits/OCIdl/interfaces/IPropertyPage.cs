// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:1742
    public class IPropertyPage : IUnknown // 1
    {
        static Guid s_uuid = new Guid("b196b28d-bab4-101a-b69c-00aa00341d07");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetPageSite(IntPtr pPageSite)
        {
            if(m_SetPageSiteFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetPageSiteFunc = (SetPageSiteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPageSiteFunc));
            } 
            
            return  m_SetPageSiteFunc(m_ptr, pPageSite);
        }
        delegate int SetPageSiteFunc(IntPtr self, IntPtr pPageSite);
        SetPageSiteFunc m_SetPageSiteFunc;

        public int Activate(HWND hWndParent, ref RECT pRect, int bModal)
        {
            if(m_ActivateFunc==null){
                var fp = GetFunctionPointer(4);
                m_ActivateFunc = (ActivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ActivateFunc));
            } 
            
            return  m_ActivateFunc(m_ptr, hWndParent, ref pRect, bModal);
        }
        delegate int ActivateFunc(IntPtr self, HWND hWndParent, ref RECT pRect, int bModal);
        ActivateFunc m_ActivateFunc;

        public int Deactivate()
        {
            if(m_DeactivateFunc==null){
                var fp = GetFunctionPointer(5);
                m_DeactivateFunc = (DeactivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeactivateFunc));
            } 
            
            return  m_DeactivateFunc(m_ptr);
        }
        delegate int DeactivateFunc(IntPtr self);
        DeactivateFunc m_DeactivateFunc;

        public int GetPageInfo(ref PROPPAGEINFO pPageInfo)
        {
            if(m_GetPageInfoFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetPageInfoFunc = (GetPageInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPageInfoFunc));
            } 
            
            return  m_GetPageInfoFunc(m_ptr, ref pPageInfo);
        }
        delegate int GetPageInfoFunc(IntPtr self, ref PROPPAGEINFO pPageInfo);
        GetPageInfoFunc m_GetPageInfoFunc;

        public int SetObjects(uint cObjects, ref IntPtr ppUnk)
        {
            if(m_SetObjectsFunc==null){
                var fp = GetFunctionPointer(7);
                m_SetObjectsFunc = (SetObjectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetObjectsFunc));
            } 
            
            return  m_SetObjectsFunc(m_ptr, cObjects, ref ppUnk);
        }
        delegate int SetObjectsFunc(IntPtr self, uint cObjects, ref IntPtr ppUnk);
        SetObjectsFunc m_SetObjectsFunc;

        public int Show(uint nCmdShow)
        {
            if(m_ShowFunc==null){
                var fp = GetFunctionPointer(8);
                m_ShowFunc = (ShowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ShowFunc));
            } 
            
            return  m_ShowFunc(m_ptr, nCmdShow);
        }
        delegate int ShowFunc(IntPtr self, uint nCmdShow);
        ShowFunc m_ShowFunc;

        public int Move(ref RECT pRect)
        {
            if(m_MoveFunc==null){
                var fp = GetFunctionPointer(9);
                m_MoveFunc = (MoveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MoveFunc));
            } 
            
            return  m_MoveFunc(m_ptr, ref pRect);
        }
        delegate int MoveFunc(IntPtr self, ref RECT pRect);
        MoveFunc m_MoveFunc;

        public int IsPageDirty()
        {
            if(m_IsPageDirtyFunc==null){
                var fp = GetFunctionPointer(10);
                m_IsPageDirtyFunc = (IsPageDirtyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsPageDirtyFunc));
            } 
            
            return  m_IsPageDirtyFunc(m_ptr);
        }
        delegate int IsPageDirtyFunc(IntPtr self);
        IsPageDirtyFunc m_IsPageDirtyFunc;

        public int Apply()
        {
            if(m_ApplyFunc==null){
                var fp = GetFunctionPointer(11);
                m_ApplyFunc = (ApplyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ApplyFunc));
            } 
            
            return  m_ApplyFunc(m_ptr);
        }
        delegate int ApplyFunc(IntPtr self);
        ApplyFunc m_ApplyFunc;

        public int Help(IntPtr pszHelpDir)
        {
            if(m_HelpFunc==null){
                var fp = GetFunctionPointer(12);
                m_HelpFunc = (HelpFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HelpFunc));
            } 
            
            return  m_HelpFunc(m_ptr, pszHelpDir);
        }
        delegate int HelpFunc(IntPtr self, IntPtr pszHelpDir);
        HelpFunc m_HelpFunc;

        public int TranslateAcceleratorA(ref MSG pMsg)
        {
            if(m_TranslateAcceleratorAFunc==null){
                var fp = GetFunctionPointer(13);
                m_TranslateAcceleratorAFunc = (TranslateAcceleratorAFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TranslateAcceleratorAFunc));
            } 
            
            return  m_TranslateAcceleratorAFunc(m_ptr, ref pMsg);
        }
        delegate int TranslateAcceleratorAFunc(IntPtr self, ref MSG pMsg);
        TranslateAcceleratorAFunc m_TranslateAcceleratorAFunc;

    }
}
