// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:5512
    public class ICallFactory : IUnknown // 1
    {
        static Guid s_uuid = new Guid("1c733a30-2a1c-11ce-ade5-00aa0044773d");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int CreateCall(ref Guid riid, IntPtr pCtrlUnk, ref Guid riid2, ref IntPtr ppv)
        {
            if(m_CreateCallFunc==null){
                var fp = GetFunctionPointer(3);
                m_CreateCallFunc = (CreateCallFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateCallFunc));
            } 
            
            return  m_CreateCallFunc(m_ptr, ref riid, pCtrlUnk, ref riid2, ref ppv);
        }
        delegate int CreateCallFunc(IntPtr self, ref Guid riid, IntPtr pCtrlUnk, ref Guid riid2, ref IntPtr ppv);
        CreateCallFunc m_CreateCallFunc;

    }
}
