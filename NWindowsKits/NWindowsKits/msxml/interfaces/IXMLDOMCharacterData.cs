// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/msxml.h:2614
    public class IXMLDOMCharacterData : IXMLDOMNode // 1
    {
        static Guid s_uuid = new Guid("2933bf84-7b36-11d2-b20e-00c04f983e60");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int get_data(ref IntPtr data)
        {
            if(m_get_dataFunc==null){
                var fp = GetFunctionPointer(43);
                m_get_dataFunc = (get_dataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_dataFunc));
            } 
            
            return  m_get_dataFunc(m_ptr, ref data);
        }
        delegate int get_dataFunc(IntPtr self, ref IntPtr data);
        get_dataFunc m_get_dataFunc;

        public int put_data(IntPtr data)
        {
            if(m_put_dataFunc==null){
                var fp = GetFunctionPointer(44);
                m_put_dataFunc = (put_dataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(put_dataFunc));
            } 
            
            return  m_put_dataFunc(m_ptr, data);
        }
        delegate int put_dataFunc(IntPtr self, IntPtr data);
        put_dataFunc m_put_dataFunc;

        public int get_length(ref int dataLength)
        {
            if(m_get_lengthFunc==null){
                var fp = GetFunctionPointer(45);
                m_get_lengthFunc = (get_lengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_lengthFunc));
            } 
            
            return  m_get_lengthFunc(m_ptr, ref dataLength);
        }
        delegate int get_lengthFunc(IntPtr self, ref int dataLength);
        get_lengthFunc m_get_lengthFunc;

        public int substringData(int offset, int count, ref IntPtr data)
        {
            if(m_substringDataFunc==null){
                var fp = GetFunctionPointer(46);
                m_substringDataFunc = (substringDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(substringDataFunc));
            } 
            
            return  m_substringDataFunc(m_ptr, offset, count, ref data);
        }
        delegate int substringDataFunc(IntPtr self, int offset, int count, ref IntPtr data);
        substringDataFunc m_substringDataFunc;

        public int appendData(IntPtr data)
        {
            if(m_appendDataFunc==null){
                var fp = GetFunctionPointer(47);
                m_appendDataFunc = (appendDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(appendDataFunc));
            } 
            
            return  m_appendDataFunc(m_ptr, data);
        }
        delegate int appendDataFunc(IntPtr self, IntPtr data);
        appendDataFunc m_appendDataFunc;

        public int insertData(int offset, IntPtr data)
        {
            if(m_insertDataFunc==null){
                var fp = GetFunctionPointer(48);
                m_insertDataFunc = (insertDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(insertDataFunc));
            } 
            
            return  m_insertDataFunc(m_ptr, offset, data);
        }
        delegate int insertDataFunc(IntPtr self, int offset, IntPtr data);
        insertDataFunc m_insertDataFunc;

        public int deleteData(int offset, int count)
        {
            if(m_deleteDataFunc==null){
                var fp = GetFunctionPointer(49);
                m_deleteDataFunc = (deleteDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(deleteDataFunc));
            } 
            
            return  m_deleteDataFunc(m_ptr, offset, count);
        }
        delegate int deleteDataFunc(IntPtr self, int offset, int count);
        deleteDataFunc m_deleteDataFunc;

        public int replaceData(int offset, int count, IntPtr data)
        {
            if(m_replaceDataFunc==null){
                var fp = GetFunctionPointer(50);
                m_replaceDataFunc = (replaceDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(replaceDataFunc));
            } 
            
            return  m_replaceDataFunc(m_ptr, offset, count, data);
        }
        delegate int replaceDataFunc(IntPtr self, int offset, int count, IntPtr data);
        replaceDataFunc m_replaceDataFunc;

    }
}
