// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:4420
    public class IOleInPlaceSiteWindowless : IOleInPlaceSiteEx // 1
    {
        static Guid s_uuid = new Guid("922eada0-3424-11cf-b670-00aa004cd6d8");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int CanWindowlessActivate()
        {
            if(m_CanWindowlessActivateFunc==null){
                var fp = GetFunctionPointer(18);
                m_CanWindowlessActivateFunc = (CanWindowlessActivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CanWindowlessActivateFunc));
            } 
            
            return  m_CanWindowlessActivateFunc(m_ptr);
        }
        delegate int CanWindowlessActivateFunc(IntPtr self);
        CanWindowlessActivateFunc m_CanWindowlessActivateFunc;

        public int GetCapture()
        {
            if(m_GetCaptureFunc==null){
                var fp = GetFunctionPointer(19);
                m_GetCaptureFunc = (GetCaptureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCaptureFunc));
            } 
            
            return  m_GetCaptureFunc(m_ptr);
        }
        delegate int GetCaptureFunc(IntPtr self);
        GetCaptureFunc m_GetCaptureFunc;

        public int SetCapture(int fCapture)
        {
            if(m_SetCaptureFunc==null){
                var fp = GetFunctionPointer(20);
                m_SetCaptureFunc = (SetCaptureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetCaptureFunc));
            } 
            
            return  m_SetCaptureFunc(m_ptr, fCapture);
        }
        delegate int SetCaptureFunc(IntPtr self, int fCapture);
        SetCaptureFunc m_SetCaptureFunc;

        public int GetFocus()
        {
            if(m_GetFocusFunc==null){
                var fp = GetFunctionPointer(21);
                m_GetFocusFunc = (GetFocusFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFocusFunc));
            } 
            
            return  m_GetFocusFunc(m_ptr);
        }
        delegate int GetFocusFunc(IntPtr self);
        GetFocusFunc m_GetFocusFunc;

        public int SetFocus(int fFocus)
        {
            if(m_SetFocusFunc==null){
                var fp = GetFunctionPointer(22);
                m_SetFocusFunc = (SetFocusFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFocusFunc));
            } 
            
            return  m_SetFocusFunc(m_ptr, fFocus);
        }
        delegate int SetFocusFunc(IntPtr self, int fFocus);
        SetFocusFunc m_SetFocusFunc;

        public int GetDC(ref RECT pRect, uint grfFlags, ref HDC phDC)
        {
            if(m_GetDCFunc==null){
                var fp = GetFunctionPointer(23);
                m_GetDCFunc = (GetDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDCFunc));
            } 
            
            return  m_GetDCFunc(m_ptr, ref pRect, grfFlags, ref phDC);
        }
        delegate int GetDCFunc(IntPtr self, ref RECT pRect, uint grfFlags, ref HDC phDC);
        GetDCFunc m_GetDCFunc;

        public int ReleaseDC(HDC hDC)
        {
            if(m_ReleaseDCFunc==null){
                var fp = GetFunctionPointer(24);
                m_ReleaseDCFunc = (ReleaseDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseDCFunc));
            } 
            
            return  m_ReleaseDCFunc(m_ptr, hDC);
        }
        delegate int ReleaseDCFunc(IntPtr self, HDC hDC);
        ReleaseDCFunc m_ReleaseDCFunc;

        public int InvalidateRect(ref RECT pRect, int fErase)
        {
            if(m_InvalidateRectFunc==null){
                var fp = GetFunctionPointer(25);
                m_InvalidateRectFunc = (InvalidateRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InvalidateRectFunc));
            } 
            
            return  m_InvalidateRectFunc(m_ptr, ref pRect, fErase);
        }
        delegate int InvalidateRectFunc(IntPtr self, ref RECT pRect, int fErase);
        InvalidateRectFunc m_InvalidateRectFunc;

        public int InvalidateRgn(HRGN hRGN, int fErase)
        {
            if(m_InvalidateRgnFunc==null){
                var fp = GetFunctionPointer(26);
                m_InvalidateRgnFunc = (InvalidateRgnFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InvalidateRgnFunc));
            } 
            
            return  m_InvalidateRgnFunc(m_ptr, hRGN, fErase);
        }
        delegate int InvalidateRgnFunc(IntPtr self, HRGN hRGN, int fErase);
        InvalidateRgnFunc m_InvalidateRgnFunc;

        public int ScrollRect(int dx, int dy, ref RECT pRectScroll, ref RECT pRectClip)
        {
            if(m_ScrollRectFunc==null){
                var fp = GetFunctionPointer(27);
                m_ScrollRectFunc = (ScrollRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ScrollRectFunc));
            } 
            
            return  m_ScrollRectFunc(m_ptr, dx, dy, ref pRectScroll, ref pRectClip);
        }
        delegate int ScrollRectFunc(IntPtr self, int dx, int dy, ref RECT pRectScroll, ref RECT pRectClip);
        ScrollRectFunc m_ScrollRectFunc;

        public int AdjustRect(ref RECT prc)
        {
            if(m_AdjustRectFunc==null){
                var fp = GetFunctionPointer(28);
                m_AdjustRectFunc = (AdjustRectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AdjustRectFunc));
            } 
            
            return  m_AdjustRectFunc(m_ptr, ref prc);
        }
        delegate int AdjustRectFunc(IntPtr self, ref RECT prc);
        AdjustRectFunc m_AdjustRectFunc;

        public int OnDefWindowMessage(uint msg, ulong wParam, long lParam, IntPtr plResult)
        {
            if(m_OnDefWindowMessageFunc==null){
                var fp = GetFunctionPointer(29);
                m_OnDefWindowMessageFunc = (OnDefWindowMessageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnDefWindowMessageFunc));
            } 
            
            return  m_OnDefWindowMessageFunc(m_ptr, msg, wParam, lParam, plResult);
        }
        delegate int OnDefWindowMessageFunc(IntPtr self, uint msg, ulong wParam, long lParam, IntPtr plResult);
        OnDefWindowMessageFunc m_OnDefWindowMessageFunc;

    }
}