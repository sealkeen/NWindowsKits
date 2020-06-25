// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:1586
    public class IOleControlSite : IUnknown // 1
    {
        static Guid s_uuid = new Guid("b196b289-bab4-101a-b69c-00aa00341d07");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int OnControlInfoChanged()
        {
            if(m_OnControlInfoChangedFunc==null){
                var fp = GetFunctionPointer(3);
                m_OnControlInfoChangedFunc = (OnControlInfoChangedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnControlInfoChangedFunc));
            } 
            
            return  m_OnControlInfoChangedFunc(m_ptr);
        }
        delegate int OnControlInfoChangedFunc(IntPtr self);
        OnControlInfoChangedFunc m_OnControlInfoChangedFunc;

        public int LockInPlaceActive(int fLock)
        {
            if(m_LockInPlaceActiveFunc==null){
                var fp = GetFunctionPointer(4);
                m_LockInPlaceActiveFunc = (LockInPlaceActiveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LockInPlaceActiveFunc));
            } 
            
            return  m_LockInPlaceActiveFunc(m_ptr, fLock);
        }
        delegate int LockInPlaceActiveFunc(IntPtr self, int fLock);
        LockInPlaceActiveFunc m_LockInPlaceActiveFunc;

        public int GetExtendedControl(ref IntPtr ppDisp)
        {
            if(m_GetExtendedControlFunc==null){
                var fp = GetFunctionPointer(5);
                m_GetExtendedControlFunc = (GetExtendedControlFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtendedControlFunc));
            } 
            
            return  m_GetExtendedControlFunc(m_ptr, ref ppDisp);
        }
        delegate int GetExtendedControlFunc(IntPtr self, ref IntPtr ppDisp);
        GetExtendedControlFunc m_GetExtendedControlFunc;

        public int TransformCoords(ref POINTL pPtlHimetric, ref POINTF pPtfContainer, uint dwFlags)
        {
            if(m_TransformCoordsFunc==null){
                var fp = GetFunctionPointer(6);
                m_TransformCoordsFunc = (TransformCoordsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TransformCoordsFunc));
            } 
            
            return  m_TransformCoordsFunc(m_ptr, ref pPtlHimetric, ref pPtfContainer, dwFlags);
        }
        delegate int TransformCoordsFunc(IntPtr self, ref POINTL pPtlHimetric, ref POINTF pPtfContainer, uint dwFlags);
        TransformCoordsFunc m_TransformCoordsFunc;

        public int TranslateAcceleratorA(ref MSG pMsg, uint grfModifiers)
        {
            if(m_TranslateAcceleratorAFunc==null){
                var fp = GetFunctionPointer(7);
                m_TranslateAcceleratorAFunc = (TranslateAcceleratorAFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TranslateAcceleratorAFunc));
            } 
            
            return  m_TranslateAcceleratorAFunc(m_ptr, ref pMsg, grfModifiers);
        }
        delegate int TranslateAcceleratorAFunc(IntPtr self, ref MSG pMsg, uint grfModifiers);
        TranslateAcceleratorAFunc m_TranslateAcceleratorAFunc;

        public int OnFocus(int fGotFocus)
        {
            if(m_OnFocusFunc==null){
                var fp = GetFunctionPointer(8);
                m_OnFocusFunc = (OnFocusFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnFocusFunc));
            } 
            
            return  m_OnFocusFunc(m_ptr, fGotFocus);
        }
        delegate int OnFocusFunc(IntPtr self, int fGotFocus);
        OnFocusFunc m_OnFocusFunc;

        public int ShowPropertyFrame()
        {
            if(m_ShowPropertyFrameFunc==null){
                var fp = GetFunctionPointer(9);
                m_ShowPropertyFrameFunc = (ShowPropertyFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ShowPropertyFrameFunc));
            } 
            
            return  m_ShowPropertyFrameFunc(m_ptr);
        }
        delegate int ShowPropertyFrameFunc(IntPtr self);
        ShowPropertyFrameFunc m_ShowPropertyFrameFunc;

    }
}