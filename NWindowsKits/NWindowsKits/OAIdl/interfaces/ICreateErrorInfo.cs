// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:4493
    public class ICreateErrorInfo : IUnknown // 1
    {
        static Guid s_uuid = new Guid("22f03340-547d-101b-8e65-08002b2bd119");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetGUID(ref GUID rguid)
        {
            if(m_SetGUIDFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetGUIDFunc = (SetGUIDFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGUIDFunc));
            } 
            
            return  m_SetGUIDFunc(m_ptr, ref rguid);
        }
        delegate int SetGUIDFunc(IntPtr self, ref GUID rguid);
        SetGUIDFunc m_SetGUIDFunc;

        public int SetSource(IntPtr szSource)
        {
            if(m_SetSourceFunc==null){
                var fp = GetFunctionPointer(4);
                m_SetSourceFunc = (SetSourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSourceFunc));
            } 
            
            return  m_SetSourceFunc(m_ptr, szSource);
        }
        delegate int SetSourceFunc(IntPtr self, IntPtr szSource);
        SetSourceFunc m_SetSourceFunc;

        public int SetDescription(IntPtr szDescription)
        {
            if(m_SetDescriptionFunc==null){
                var fp = GetFunctionPointer(5);
                m_SetDescriptionFunc = (SetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDescriptionFunc));
            } 
            
            return  m_SetDescriptionFunc(m_ptr, szDescription);
        }
        delegate int SetDescriptionFunc(IntPtr self, IntPtr szDescription);
        SetDescriptionFunc m_SetDescriptionFunc;

        public int SetHelpFile(IntPtr szHelpFile)
        {
            if(m_SetHelpFileFunc==null){
                var fp = GetFunctionPointer(6);
                m_SetHelpFileFunc = (SetHelpFileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetHelpFileFunc));
            } 
            
            return  m_SetHelpFileFunc(m_ptr, szHelpFile);
        }
        delegate int SetHelpFileFunc(IntPtr self, IntPtr szHelpFile);
        SetHelpFileFunc m_SetHelpFileFunc;

        public int SetHelpContext(uint dwHelpContext)
        {
            if(m_SetHelpContextFunc==null){
                var fp = GetFunctionPointer(7);
                m_SetHelpContextFunc = (SetHelpContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetHelpContextFunc));
            } 
            
            return  m_SetHelpContextFunc(m_ptr, dwHelpContext);
        }
        delegate int SetHelpContextFunc(IntPtr self, uint dwHelpContext);
        SetHelpContextFunc m_SetHelpContextFunc;

    }
}