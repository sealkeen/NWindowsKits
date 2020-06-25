// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:257
    public class IOleAdviseHolder : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000111-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Advise(IntPtr pAdvise, ref uint pdwConnection)
        {
            if(m_AdviseFunc==null){
                var fp = GetFunctionPointer(3);
                m_AdviseFunc = (AdviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AdviseFunc));
            } 
            
            return  m_AdviseFunc(m_ptr, pAdvise, ref pdwConnection);
        }
        delegate int AdviseFunc(IntPtr self, IntPtr pAdvise, ref uint pdwConnection);
        AdviseFunc m_AdviseFunc;

        public int Unadvise(uint dwConnection)
        {
            if(m_UnadviseFunc==null){
                var fp = GetFunctionPointer(4);
                m_UnadviseFunc = (UnadviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnadviseFunc));
            } 
            
            return  m_UnadviseFunc(m_ptr, dwConnection);
        }
        delegate int UnadviseFunc(IntPtr self, uint dwConnection);
        UnadviseFunc m_UnadviseFunc;

        public int EnumAdvise(ref IntPtr ppenumAdvise)
        {
            if(m_EnumAdviseFunc==null){
                var fp = GetFunctionPointer(5);
                m_EnumAdviseFunc = (EnumAdviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumAdviseFunc));
            } 
            
            return  m_EnumAdviseFunc(m_ptr, ref ppenumAdvise);
        }
        delegate int EnumAdviseFunc(IntPtr self, ref IntPtr ppenumAdvise);
        EnumAdviseFunc m_EnumAdviseFunc;

        public int SendOnRename(IntPtr pmk)
        {
            if(m_SendOnRenameFunc==null){
                var fp = GetFunctionPointer(6);
                m_SendOnRenameFunc = (SendOnRenameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SendOnRenameFunc));
            } 
            
            return  m_SendOnRenameFunc(m_ptr, pmk);
        }
        delegate int SendOnRenameFunc(IntPtr self, IntPtr pmk);
        SendOnRenameFunc m_SendOnRenameFunc;

        public int SendOnSave()
        {
            if(m_SendOnSaveFunc==null){
                var fp = GetFunctionPointer(7);
                m_SendOnSaveFunc = (SendOnSaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SendOnSaveFunc));
            } 
            
            return  m_SendOnSaveFunc(m_ptr);
        }
        delegate int SendOnSaveFunc(IntPtr self);
        SendOnSaveFunc m_SendOnSaveFunc;

        public int SendOnClose()
        {
            if(m_SendOnCloseFunc==null){
                var fp = GetFunctionPointer(8);
                m_SendOnCloseFunc = (SendOnCloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SendOnCloseFunc));
            } 
            
            return  m_SendOnCloseFunc(m_ptr);
        }
        delegate int SendOnCloseFunc(IntPtr self);
        SendOnCloseFunc m_SendOnCloseFunc;

    }
}
