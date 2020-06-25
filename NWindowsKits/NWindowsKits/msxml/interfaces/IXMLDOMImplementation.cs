// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/msxml.h:448
    public class IXMLDOMImplementation : IDispatch // 1
    {
        static Guid s_uuid = new Guid("2933bf8f-7b36-11d2-b20e-00c04f983e60");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int hasFeature(IntPtr feature, IntPtr version, ref short hasFeature)
        {
            if(m_hasFeatureFunc==null){
                var fp = GetFunctionPointer(7);
                m_hasFeatureFunc = (hasFeatureFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(hasFeatureFunc));
            } 
            
            return  m_hasFeatureFunc(m_ptr, feature, version, ref hasFeature);
        }
        delegate int hasFeatureFunc(IntPtr self, IntPtr feature, IntPtr version, ref short hasFeature);
        hasFeatureFunc m_hasFeatureFunc;

    }
}
