﻿namespace Ryujinx.Graphics.Gal
{
    public enum GalFrameBufferFormat
    {
        Bitmap               = 0x1c,
        Unknown1D            = 0x1d,
        RGBA32Float          = 0xc0,
        RGBA32Sint           = 0xc1,
        RGBA32Uint           = 0xc2,
        RGBX32Float          = 0xc3,
        RGBX32Sint           = 0xc4,
        RGBX32Uint           = 0xc5,
        RGBA16Unorm          = 0xc6,
        RGBA16Snorm          = 0xc7,
        RGBA16Sint           = 0xc8,
        RGBA16Uint           = 0xc9,
        RGBA16Float          = 0xca,
        RG32Float            = 0xcb,
        RG32Sint             = 0xcc,
        RG32Uint             = 0xcd,
        RGBX16Float          = 0xce,
        BGRA8Unorm           = 0xcf,
        BGRA8Srgb            = 0xd0,
        RGB10A2Unorm         = 0xd1,
        RGB10A2Uint          = 0xd2,
        RGBA8Unorm           = 0xd5,
        RGBA8Srgb            = 0xd6,
        RGBA8Snorm           = 0xd7,
        RGBA8Sint            = 0xd8,
        RGBA8Uint            = 0xd9,
        RG16Unorm            = 0xda,
        RG16Snorm            = 0xdb,
        RG16Sint             = 0xdc,
        RG16Uint             = 0xdd,
        RG16Float            = 0xde,
        BGR10A2Unorm         = 0xdf,
        R11G11B10Float       = 0xe0,
        R32Sint              = 0xe3,
        R32Uint              = 0xe4,
        R32Float             = 0xe5,
        BGRX8Unorm           = 0xe6,
        BGRX8Srgb            = 0xe7,
        B5G6R5Unorm          = 0xe8,
        BGR5A1Unorm          = 0xe9,
        RG8Unorm             = 0xea,
        RG8Snorm             = 0xeb,
        RG8Sint              = 0xec,
        RG8Uint              = 0xed,
        R16Unorm             = 0xee,
        R16Snorm             = 0xef,
        R16Sint              = 0xf0,
        R16Uint              = 0xf1,
        R16Float             = 0xf2,
        R8Unorm              = 0xf3,
        R8Snorm              = 0xf4,
        R8Sint               = 0xf5,
        R8Uint               = 0xf6,
        A8Unorm              = 0xf7,
        BGR5X1Unorm          = 0xf8,
        RGBX8Unorm           = 0xf9,
        RGBX8Srgb            = 0xfa,
        BGR5X1UnormUnknownFB = 0xfb,
        BGR5X1UnormUnknownFC = 0xfc,
        BGRX8UnormUnknownFD  = 0xfd,
        BGRX8UnormUnknownFE  = 0xfe,
        Y32UintUnknownFF     = 0xff
    }
}