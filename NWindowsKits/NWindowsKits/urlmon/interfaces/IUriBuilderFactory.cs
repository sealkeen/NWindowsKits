// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:3839
    public class IUriBuilderFactory : IUnknown // 1
    {
        static Guid s_uuid = new Guid("e982ce48-0b96-440c-bc37-0c869b27a29e");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int CreateIUriBuilder(uint dwFlags, ulong dwReserved, ref IntPtr ppIUriBuilder)
        {
            if(m_CreateIUriBuilderFunc==null){
                var fp = GetFunctionPointer(3);
                m_CreateIUriBuilderFunc = (CreateIUriBuilderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateIUriBuilderFunc));
            } 
            
            return  m_CreateIUriBuilderFunc(m_ptr, dwFlags, dwReserved, ref ppIUriBuilder);
        }
        delegate int CreateIUriBuilderFunc(IntPtr self, uint dwFlags, ulong dwReserved, ref IntPtr ppIUriBuilder);
        CreateIUriBuilderFunc m_CreateIUriBuilderFunc;

        public int CreateInitializedIUriBuilder(uint dwFlags, ulong dwReserved, ref IntPtr ppIUriBuilder)
        {
            if(m_CreateInitializedIUriBuilderFunc==null){
                var fp = GetFunctionPointer(4);
                m_CreateInitializedIUriBuilderFunc = (CreateInitializedIUriBuilderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateInitializedIUriBuilderFunc));
            } 
            
            return  m_CreateInitializedIUriBuilderFunc(m_ptr, dwFlags, dwReserved, ref ppIUriBuilder);
        }
        delegate int CreateInitializedIUriBuilderFunc(IntPtr self, uint dwFlags, ulong dwReserved, ref IntPtr ppIUriBuilder);
        CreateInitializedIUriBuilderFunc m_CreateInitializedIUriBuilderFunc;

    }
}
