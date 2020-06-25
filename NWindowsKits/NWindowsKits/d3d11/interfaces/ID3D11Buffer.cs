// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:2405
    public class ID3D11Buffer : ID3D11Resource // 1
    {
        static Guid s_uuid = new Guid("48570b85-d1ee-4fcd-a250-eb350722b037");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetDesc(ref D3D11_BUFFER_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(10);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
            
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref D3D11_BUFFER_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
