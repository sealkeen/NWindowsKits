// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:1924
    public class IPropertyPage2 : IPropertyPage // 1
    {
        static Guid s_uuid = new Guid("01e44665-24ac-101b-84ed-08002b2ec713");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int EditProperty(int dispID)
        {
            if(m_EditPropertyFunc==null){
                var fp = GetFunctionPointer(14);
                m_EditPropertyFunc = (EditPropertyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EditPropertyFunc));
            } 
            
            return  m_EditPropertyFunc(m_ptr, dispID);
        }
        delegate int EditPropertyFunc(IntPtr self, int dispID);
        EditPropertyFunc m_EditPropertyFunc;

    }
}