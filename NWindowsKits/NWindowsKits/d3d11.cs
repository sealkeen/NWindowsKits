// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:14457
    public delegate int PFN_D3D11_CREATE_DEVICE(
        IntPtr __param__0,
        D3D_DRIVER_TYPE __param__1,
        HMODULE __param__2,
        uint __param__3,
        ref D3D_FEATURE_LEVEL __param__4,
        uint FeatureLevels,
        uint __param__6,
        ref IntPtr __param__7,
        ref D3D_FEATURE_LEVEL __param__8,
        ref IntPtr __param__9
    );

    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:14530
    public delegate int PFN_D3D11_CREATE_DEVICE_AND_SWAP_CHAIN(
        IntPtr __param__0,
        D3D_DRIVER_TYPE __param__1,
        HMODULE __param__2,
        uint __param__3,
        ref D3D_FEATURE_LEVEL __param__4,
        uint FeatureLevels,
        uint __param__6,
        ref DXGI_SWAP_CHAIN_DESC __param__7,
        ref IntPtr __param__8,
        ref IntPtr __param__9,
        ref D3D_FEATURE_LEVEL __param__10,
        ref IntPtr __param__11
    );

    public static partial class d3d11
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:14463
        [DllImport("d3d11.dll")]
        public static extern int D3D11CreateDevice(
            IntPtr pAdapter,
            D3D_DRIVER_TYPE DriverType,
            HMODULE Software,
            uint Flags,
            ref D3D_FEATURE_LEVEL pFeatureLevels,
            uint FeatureLevels,
            uint SDKVersion,
            ref IntPtr ppDevice,
            ref D3D_FEATURE_LEVEL pFeatureLevel,
            ref IntPtr ppImmediateContext
        );

        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:14537
        [DllImport("d3d11.dll")]
        public static extern int D3D11CreateDeviceAndSwapChain(
            IntPtr pAdapter,
            D3D_DRIVER_TYPE DriverType,
            HMODULE Software,
            uint Flags,
            ref D3D_FEATURE_LEVEL pFeatureLevels,
            uint FeatureLevels,
            uint SDKVersion,
            ref DXGI_SWAP_CHAIN_DESC pSwapChainDesc,
            ref IntPtr ppSwapChain,
            ref IntPtr ppDevice,
            ref D3D_FEATURE_LEVEL pFeatureLevel,
            ref IntPtr ppImmediateContext
        );

    }
}
