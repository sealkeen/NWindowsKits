// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/msxml.h:5764
    public class IXMLDOMDocumentType : IXMLDOMNode // 1
    {
        static Guid s_uuid = new Guid("2933bf8b-7b36-11d2-b20e-00c04f983e60");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int get_name(ref IntPtr rootName)
        {
            if(m_get_nameFunc==null){
                var fp = GetFunctionPointer(43);
                m_get_nameFunc = (get_nameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_nameFunc));
            } 
            
            return  m_get_nameFunc(m_ptr, ref rootName);
        }
        delegate int get_nameFunc(IntPtr self, ref IntPtr rootName);
        get_nameFunc m_get_nameFunc;

        public int get_entities(ref IntPtr entityMap)
        {
            if(m_get_entitiesFunc==null){
                var fp = GetFunctionPointer(44);
                m_get_entitiesFunc = (get_entitiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_entitiesFunc));
            } 
            
            return  m_get_entitiesFunc(m_ptr, ref entityMap);
        }
        delegate int get_entitiesFunc(IntPtr self, ref IntPtr entityMap);
        get_entitiesFunc m_get_entitiesFunc;

        public int get_notations(ref IntPtr notationMap)
        {
            if(m_get_notationsFunc==null){
                var fp = GetFunctionPointer(45);
                m_get_notationsFunc = (get_notationsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_notationsFunc));
            } 
            
            return  m_get_notationsFunc(m_ptr, ref notationMap);
        }
        delegate int get_notationsFunc(IntPtr self, ref IntPtr notationMap);
        get_notationsFunc m_get_notationsFunc;

    }
}
