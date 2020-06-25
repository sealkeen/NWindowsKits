// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:10027
    public class IWrappedProtocol : IUnknown // 1
    {
        static Guid s_uuid = new Guid("53c84785-8425-4dc5-971b-e58d9c19f9b6");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetWrapperCode(ref int pnCode, ulong dwReserved)
        {
            if(m_GetWrapperCodeFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetWrapperCodeFunc = (GetWrapperCodeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetWrapperCodeFunc));
            } 
            
            return  m_GetWrapperCodeFunc(m_ptr, ref pnCode, dwReserved);
        }
        delegate int GetWrapperCodeFunc(IntPtr self, ref int pnCode, ulong dwReserved);
        GetWrapperCodeFunc m_GetWrapperCodeFunc;

    }
}
