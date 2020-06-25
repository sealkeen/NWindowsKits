// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:1518
    public class IMultiQI : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000020-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int QueryMultipleInterfaces(uint cMQIs, ref MULTI_QI pMQIs)
        {
            if(m_QueryMultipleInterfacesFunc==null){
                var fp = GetFunctionPointer(3);
                m_QueryMultipleInterfacesFunc = (QueryMultipleInterfacesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryMultipleInterfacesFunc));
            } 
            
            return  m_QueryMultipleInterfacesFunc(m_ptr, cMQIs, ref pMQIs);
        }
        delegate int QueryMultipleInterfacesFunc(IntPtr self, uint cMQIs, ref MULTI_QI pMQIs);
        QueryMultipleInterfacesFunc m_QueryMultipleInterfacesFunc;

    }
}
