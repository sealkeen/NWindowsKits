// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi1_2.h:279
    public class IDXGIOutputDuplication : IDXGIObject // 1
    {
        static Guid s_uuid = new Guid("191cfac3-a341-470d-b26e-a864f428319c");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetDesc(ref DXGI_OUTDUPL_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
            
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref DXGI_OUTDUPL_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public int AcquireNextFrame(uint TimeoutInMilliseconds, ref DXGI_OUTDUPL_FRAME_INFO pFrameInfo, ref IntPtr ppDesktopResource)
        {
            if(m_AcquireNextFrameFunc==null){
                var fp = GetFunctionPointer(8);
                m_AcquireNextFrameFunc = (AcquireNextFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AcquireNextFrameFunc));
            } 
            
            return  m_AcquireNextFrameFunc(m_ptr, TimeoutInMilliseconds, ref pFrameInfo, ref ppDesktopResource);
        }
        delegate int AcquireNextFrameFunc(IntPtr self, uint TimeoutInMilliseconds, ref DXGI_OUTDUPL_FRAME_INFO pFrameInfo, ref IntPtr ppDesktopResource);
        AcquireNextFrameFunc m_AcquireNextFrameFunc;

        public int GetFrameDirtyRects(uint DirtyRectsBufferSize, ref RECT pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired)
        {
            if(m_GetFrameDirtyRectsFunc==null){
                var fp = GetFunctionPointer(9);
                m_GetFrameDirtyRectsFunc = (GetFrameDirtyRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameDirtyRectsFunc));
            } 
            
            return  m_GetFrameDirtyRectsFunc(m_ptr, DirtyRectsBufferSize, ref pDirtyRectsBuffer, ref pDirtyRectsBufferSizeRequired);
        }
        delegate int GetFrameDirtyRectsFunc(IntPtr self, uint DirtyRectsBufferSize, ref RECT pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired);
        GetFrameDirtyRectsFunc m_GetFrameDirtyRectsFunc;

        public int GetFrameMoveRects(uint MoveRectsBufferSize, ref DXGI_OUTDUPL_MOVE_RECT pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired)
        {
            if(m_GetFrameMoveRectsFunc==null){
                var fp = GetFunctionPointer(10);
                m_GetFrameMoveRectsFunc = (GetFrameMoveRectsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameMoveRectsFunc));
            } 
            
            return  m_GetFrameMoveRectsFunc(m_ptr, MoveRectsBufferSize, ref pMoveRectBuffer, ref pMoveRectsBufferSizeRequired);
        }
        delegate int GetFrameMoveRectsFunc(IntPtr self, uint MoveRectsBufferSize, ref DXGI_OUTDUPL_MOVE_RECT pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired);
        GetFrameMoveRectsFunc m_GetFrameMoveRectsFunc;

        public int GetFramePointerShape(uint PointerShapeBufferSize, IntPtr pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref DXGI_OUTDUPL_POINTER_SHAPE_INFO pPointerShapeInfo)
        {
            if(m_GetFramePointerShapeFunc==null){
                var fp = GetFunctionPointer(11);
                m_GetFramePointerShapeFunc = (GetFramePointerShapeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFramePointerShapeFunc));
            } 
            
            return  m_GetFramePointerShapeFunc(m_ptr, PointerShapeBufferSize, pPointerShapeBuffer, ref pPointerShapeBufferSizeRequired, ref pPointerShapeInfo);
        }
        delegate int GetFramePointerShapeFunc(IntPtr self, uint PointerShapeBufferSize, IntPtr pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref DXGI_OUTDUPL_POINTER_SHAPE_INFO pPointerShapeInfo);
        GetFramePointerShapeFunc m_GetFramePointerShapeFunc;

        public int MapDesktopSurface(ref DXGI_MAPPED_RECT pLockedRect)
        {
            if(m_MapDesktopSurfaceFunc==null){
                var fp = GetFunctionPointer(12);
                m_MapDesktopSurfaceFunc = (MapDesktopSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapDesktopSurfaceFunc));
            } 
            
            return  m_MapDesktopSurfaceFunc(m_ptr, ref pLockedRect);
        }
        delegate int MapDesktopSurfaceFunc(IntPtr self, ref DXGI_MAPPED_RECT pLockedRect);
        MapDesktopSurfaceFunc m_MapDesktopSurfaceFunc;

        public int UnMapDesktopSurface()
        {
            if(m_UnMapDesktopSurfaceFunc==null){
                var fp = GetFunctionPointer(13);
                m_UnMapDesktopSurfaceFunc = (UnMapDesktopSurfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnMapDesktopSurfaceFunc));
            } 
            
            return  m_UnMapDesktopSurfaceFunc(m_ptr);
        }
        delegate int UnMapDesktopSurfaceFunc(IntPtr self);
        UnMapDesktopSurfaceFunc m_UnMapDesktopSurfaceFunc;

        public int ReleaseFrame()
        {
            if(m_ReleaseFrameFunc==null){
                var fp = GetFunctionPointer(14);
                m_ReleaseFrameFunc = (ReleaseFrameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFrameFunc));
            } 
            
            return  m_ReleaseFrameFunc(m_ptr);
        }
        delegate int ReleaseFrameFunc(IntPtr self);
        ReleaseFrameFunc m_ReleaseFrameFunc;

    }
}
