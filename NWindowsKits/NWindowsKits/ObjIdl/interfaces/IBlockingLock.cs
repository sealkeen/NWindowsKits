// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:13278
    public class IBlockingLock : IUnknown // 1
    {
        static Guid s_uuid = new Guid("30f3d47a-6447-11d1-8e3c-00c04fb9386d");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Lock(uint dwTimeout)
        {
            if(m_LockFunc==null){
                var fp = GetFunctionPointer(3);
                m_LockFunc = (LockFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LockFunc));
            } 
            
            return  m_LockFunc(m_ptr, dwTimeout);
        }
        delegate int LockFunc(IntPtr self, uint dwTimeout);
        LockFunc m_LockFunc;

        public int Unlock()
        {
            if(m_UnlockFunc==null){
                var fp = GetFunctionPointer(4);
                m_UnlockFunc = (UnlockFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnlockFunc));
            } 
            
            return  m_UnlockFunc(m_ptr);
        }
        delegate int UnlockFunc(IntPtr self);
        UnlockFunc m_UnlockFunc;

    }
}
