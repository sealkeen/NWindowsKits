// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:5946
    public class ID3D11SamplerState : ID3D11DeviceChild // 1
    {
        static Guid s_uuid = new Guid("da6fea51-564c-4487-9810-f0d0f9b4e3a5");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetDesc(ref D3D11_SAMPLER_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
            
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref D3D11_SAMPLER_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
