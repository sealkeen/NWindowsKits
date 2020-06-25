// This source code was generated by ClangCaster

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3dcommon.h:622
    public enum D3D_SHADER_VARIABLE_TYPE // 1
    {
        D3D_SVT_VOID = 0x0,
        D3D_SVT_BOOL = 0x1,
        D3D_SVT_INT = 0x2,
        D3D_SVT_FLOAT = 0x3,
        D3D_SVT_STRING = 0x4,
        D3D_SVT_TEXTURE = 0x5,
        D3D_SVT_TEXTURE1D = 0x6,
        D3D_SVT_TEXTURE2D = 0x7,
        D3D_SVT_TEXTURE3D = 0x8,
        D3D_SVT_TEXTURECUBE = 0x9,
        D3D_SVT_SAMPLER = 0xa,
        D3D_SVT_SAMPLER1D = 0xb,
        D3D_SVT_SAMPLER2D = 0xc,
        D3D_SVT_SAMPLER3D = 0xd,
        D3D_SVT_SAMPLERCUBE = 0xe,
        D3D_SVT_PIXELSHADER = 0xf,
        D3D_SVT_VERTEXSHADER = 0x10,
        D3D_SVT_PIXELFRAGMENT = 0x11,
        D3D_SVT_VERTEXFRAGMENT = 0x12,
        D3D_SVT_UINT = 0x13,
        D3D_SVT_UINT8 = 0x14,
        D3D_SVT_GEOMETRYSHADER = 0x15,
        D3D_SVT_RASTERIZER = 0x16,
        D3D_SVT_DEPTHSTENCIL = 0x17,
        D3D_SVT_BLEND = 0x18,
        D3D_SVT_BUFFER = 0x19,
        D3D_SVT_CBUFFER = 0x1a,
        D3D_SVT_TBUFFER = 0x1b,
        D3D_SVT_TEXTURE1DARRAY = 0x1c,
        D3D_SVT_TEXTURE2DARRAY = 0x1d,
        D3D_SVT_RENDERTARGETVIEW = 0x1e,
        D3D_SVT_DEPTHSTENCILVIEW = 0x1f,
        D3D_SVT_TEXTURE2DMS = 0x20,
        D3D_SVT_TEXTURE2DMSARRAY = 0x21,
        D3D_SVT_TEXTURECUBEARRAY = 0x22,
        D3D_SVT_HULLSHADER = 0x23,
        D3D_SVT_DOMAINSHADER = 0x24,
        D3D_SVT_INTERFACE_POINTER = 0x25,
        D3D_SVT_COMPUTESHADER = 0x26,
        D3D_SVT_DOUBLE = 0x27,
        D3D_SVT_RWTEXTURE1D = 0x28,
        D3D_SVT_RWTEXTURE1DARRAY = 0x29,
        D3D_SVT_RWTEXTURE2D = 0x2a,
        D3D_SVT_RWTEXTURE2DARRAY = 0x2b,
        D3D_SVT_RWTEXTURE3D = 0x2c,
        D3D_SVT_RWBUFFER = 0x2d,
        D3D_SVT_BYTEADDRESS_BUFFER = 0x2e,
        D3D_SVT_RWBYTEADDRESS_BUFFER = 0x2f,
        D3D_SVT_STRUCTURED_BUFFER = 0x30,
        D3D_SVT_RWSTRUCTURED_BUFFER = 0x31,
        D3D_SVT_APPEND_STRUCTURED_BUFFER = 0x32,
        D3D_SVT_CONSUME_STRUCTURED_BUFFER = 0x33,
        D3D_SVT_MIN8FLOAT = 0x34,
        D3D_SVT_MIN10FLOAT = 0x35,
        D3D_SVT_MIN16FLOAT = 0x36,
        D3D_SVT_MIN12INT = 0x37,
        D3D_SVT_MIN16INT = 0x38,
        D3D_SVT_MIN16UINT = 0x39,
        D3D10_SVT_VOID = 0x0,
        D3D10_SVT_BOOL = 0x1,
        D3D10_SVT_INT = 0x2,
        D3D10_SVT_FLOAT = 0x3,
        D3D10_SVT_STRING = 0x4,
        D3D10_SVT_TEXTURE = 0x5,
        D3D10_SVT_TEXTURE1D = 0x6,
        D3D10_SVT_TEXTURE2D = 0x7,
        D3D10_SVT_TEXTURE3D = 0x8,
        D3D10_SVT_TEXTURECUBE = 0x9,
        D3D10_SVT_SAMPLER = 0xa,
        D3D10_SVT_SAMPLER1D = 0xb,
        D3D10_SVT_SAMPLER2D = 0xc,
        D3D10_SVT_SAMPLER3D = 0xd,
        D3D10_SVT_SAMPLERCUBE = 0xe,
        D3D10_SVT_PIXELSHADER = 0xf,
        D3D10_SVT_VERTEXSHADER = 0x10,
        D3D10_SVT_PIXELFRAGMENT = 0x11,
        D3D10_SVT_VERTEXFRAGMENT = 0x12,
        D3D10_SVT_UINT = 0x13,
        D3D10_SVT_UINT8 = 0x14,
        D3D10_SVT_GEOMETRYSHADER = 0x15,
        D3D10_SVT_RASTERIZER = 0x16,
        D3D10_SVT_DEPTHSTENCIL = 0x17,
        D3D10_SVT_BLEND = 0x18,
        D3D10_SVT_BUFFER = 0x19,
        D3D10_SVT_CBUFFER = 0x1a,
        D3D10_SVT_TBUFFER = 0x1b,
        D3D10_SVT_TEXTURE1DARRAY = 0x1c,
        D3D10_SVT_TEXTURE2DARRAY = 0x1d,
        D3D10_SVT_RENDERTARGETVIEW = 0x1e,
        D3D10_SVT_DEPTHSTENCILVIEW = 0x1f,
        D3D10_SVT_TEXTURE2DMS = 0x20,
        D3D10_SVT_TEXTURE2DMSARRAY = 0x21,
        D3D10_SVT_TEXTURECUBEARRAY = 0x22,
        D3D11_SVT_HULLSHADER = 0x23,
        D3D11_SVT_DOMAINSHADER = 0x24,
        D3D11_SVT_INTERFACE_POINTER = 0x25,
        D3D11_SVT_COMPUTESHADER = 0x26,
        D3D11_SVT_DOUBLE = 0x27,
        D3D11_SVT_RWTEXTURE1D = 0x28,
        D3D11_SVT_RWTEXTURE1DARRAY = 0x29,
        D3D11_SVT_RWTEXTURE2D = 0x2a,
        D3D11_SVT_RWTEXTURE2DARRAY = 0x2b,
        D3D11_SVT_RWTEXTURE3D = 0x2c,
        D3D11_SVT_RWBUFFER = 0x2d,
        D3D11_SVT_BYTEADDRESS_BUFFER = 0x2e,
        D3D11_SVT_RWBYTEADDRESS_BUFFER = 0x2f,
        D3D11_SVT_STRUCTURED_BUFFER = 0x30,
        D3D11_SVT_RWSTRUCTURED_BUFFER = 0x31,
        D3D11_SVT_APPEND_STRUCTURED_BUFFER = 0x32,
        D3D11_SVT_CONSUME_STRUCTURED_BUFFER = 0x33,
        D3D_SVT_FORCE_DWORD = unchecked((int)0x7fffffff),
    }
}