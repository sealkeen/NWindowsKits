// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10sdklayers.h:108
    public class ID3D10Debug : IUnknown // 1
    {
        static Guid s_uuid = new Guid("9b7e4e01-342c-4106-a19f-4f2704f689f0");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetFeatureMask(uint Mask)
        {
            if(m_SetFeatureMaskFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetFeatureMaskFunc = (SetFeatureMaskFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFeatureMaskFunc));
            } 
            
            return  m_SetFeatureMaskFunc(m_ptr, Mask);
        }
        delegate int SetFeatureMaskFunc(IntPtr self, uint Mask);
        SetFeatureMaskFunc m_SetFeatureMaskFunc;

        public uint GetFeatureMask()
        {
            if(m_GetFeatureMaskFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetFeatureMaskFunc = (GetFeatureMaskFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFeatureMaskFunc));
            } 
            
            return  m_GetFeatureMaskFunc(m_ptr);
        }
        delegate uint GetFeatureMaskFunc(IntPtr self);
        GetFeatureMaskFunc m_GetFeatureMaskFunc;

        public int SetPresentPerRenderOpDelay(uint Milliseconds)
        {
            if(m_SetPresentPerRenderOpDelayFunc==null){
                var fp = GetFunctionPointer(5);
                m_SetPresentPerRenderOpDelayFunc = (SetPresentPerRenderOpDelayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetPresentPerRenderOpDelayFunc));
            } 
            
            return  m_SetPresentPerRenderOpDelayFunc(m_ptr, Milliseconds);
        }
        delegate int SetPresentPerRenderOpDelayFunc(IntPtr self, uint Milliseconds);
        SetPresentPerRenderOpDelayFunc m_SetPresentPerRenderOpDelayFunc;

        public uint GetPresentPerRenderOpDelay()
        {
            if(m_GetPresentPerRenderOpDelayFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetPresentPerRenderOpDelayFunc = (GetPresentPerRenderOpDelayFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPresentPerRenderOpDelayFunc));
            } 
            
            return  m_GetPresentPerRenderOpDelayFunc(m_ptr);
        }
        delegate uint GetPresentPerRenderOpDelayFunc(IntPtr self);
        GetPresentPerRenderOpDelayFunc m_GetPresentPerRenderOpDelayFunc;

        public int SetSwapChain(IntPtr pSwapChain)
        {
            if(m_SetSwapChainFunc==null){
                var fp = GetFunctionPointer(7);
                m_SetSwapChainFunc = (SetSwapChainFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSwapChainFunc));
            } 
            
            return  m_SetSwapChainFunc(m_ptr, pSwapChain);
        }
        delegate int SetSwapChainFunc(IntPtr self, IntPtr pSwapChain);
        SetSwapChainFunc m_SetSwapChainFunc;

        public int GetSwapChain(ref IntPtr ppSwapChain)
        {
            if(m_GetSwapChainFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetSwapChainFunc = (GetSwapChainFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSwapChainFunc));
            } 
            
            return  m_GetSwapChainFunc(m_ptr, ref ppSwapChain);
        }
        delegate int GetSwapChainFunc(IntPtr self, ref IntPtr ppSwapChain);
        GetSwapChainFunc m_GetSwapChainFunc;

        public int Validate()
        {
            if(m_ValidateFunc==null){
                var fp = GetFunctionPointer(9);
                m_ValidateFunc = (ValidateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ValidateFunc));
            } 
            
            return  m_ValidateFunc(m_ptr);
        }
        delegate int ValidateFunc(IntPtr self);
        ValidateFunc m_ValidateFunc;

    }
}