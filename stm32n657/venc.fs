\
\ @file venc.fs
\ @brief Video encoder
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief VENC ID register
\ Address offset: 0x00
\ Reset value: 0x6E654000
\

$00000000 constant VENC_VENC_SWREG0_SWREG_FIELD                     \ Interrupt register (all format mode)


\
\ @brief VENC interrupt register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG1_SWREG_FIELD                     \ Interrupt register (all format mode)


\
\ @brief VENC bus interface configuration register
\ Address offset: 0x08
\ Reset value: 0x00000010
\

$00000000 constant VENC_VENC_SWREG2_SWREG_FIELD                     \ Bus interface configuration register (all format mode)


\
\ @brief VENC device configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG3_SWREG_FIELD                     \ Device configuration register (all format mode)


\
\ @brief VENC base address for output stream data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG5_SWREG_FIELD                     \ Base address for output stream data (all format mode)


\
\ @brief VENC base address for output control data register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG6_SWREG_FIELD                     \ Base address for output control data (all format mode)


\
\ @brief VENC base address for reference luma register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG7_SWREG_FIELD                     \ Base address for reference luma (all format mode)


\
\ @brief VENC base address for reference chroma register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG8_SWREG_FIELD                     \ Base address for reference chroma (all format mode)


\
\ @brief VENC base address for reconstructed luma register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG9_SWREG_FIELD                     \ Base address for reconstructed luma (all format mode)


\
\ @brief VENC base address for reconstructed chroma register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG10_SWREG_FIELD                    \ Base address for reconstructed chroma (all format mode)


\
\ @brief VENC base address for input picture luma register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG11_SWREG_FIELD                    \ Base address for input picture luma (all format mode)


\
\ @brief VENC base address for input picture cb register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG12_SWREG_FIELD                    \ Base address for input picture cb (all format mode)


\
\ @brief VENC base address for input picture cr register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG13_SWREG_FIELD                    \ Base address for input picture cr (all format mode)


\
\ @brief VENC encoder control register 0
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG14_SWREG_FIELD                    \ Encoder control register 0 (such as picture information or encoding mode) (all format mode)


\
\ @brief VENC encoder control register 1
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG15_SWREG_FIELD                    \ Encoder control register 1 (such as preprocessing control, crop, rotate, input format) (all format mode)


\
\ @brief VENC encoder control register 2
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG16_SWREG_FIELD                    \ Base address for second reference luma (H264 control) (all format mode)


\
\ @brief VENC encoder control register 3
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG17_SWREG_FIELD                    \ Base address for second reference chroma (H264 control) (all format mode)


\
\ @brief VENC encoder control register 4
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG18_SWREG_FIELD                    \ Encoder control register 4 (deblock filter mode, H264 control) (all format mode)


\
\ @brief VENC encoder control register 5
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG19_SWREG_FIELD                    \ Encoder control register 5 (input format, motion vector etc) (all format mode)


\
\ @brief VENC encoder control register 6
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG20_SWREG_FIELD                    \ Control of data JPEG (all format mode)


\
\ @brief VENC encoder control register 7
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG21_SWREG_FIELD                    \ Control of H264 (all format mode)


\
\ @brief VENC stream header remainder MSB bits register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG22_SWREG_FIELD                    \ Stream header remainder bits MSB (MSB aligned) (all format mode)


\
\ @brief VENC stream header remainder LSB bits register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG23_SWREG_FIELD                    \ Stream header remainder bits LSB (MSB aligned) (all format mode)


\
\ @brief VENC stream buffer limit/output stream size register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG24_SWREG_FIELD                    \ Stream buffer limit (64-bit addresses)/output stream size (bits) (all format mode)


\
\ @brief VENC encoder control register 8
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG25_SWREG_FIELD                    \ Control of MAD control and QP sum output (all format mode)


\
\ @brief VENC intra-slice bitmap register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG26_SWREG_FIELD                    \ intra-slice bitmap for probability updates (all format mode)


\
\ @brief VENC encoder control register 9
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG27_SWREG_FIELD                    \ Control of H264 QP (all format mode)


\
\ @brief VENC encoder control register 10
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG28_SWREG_FIELD                    \ H264 checkpoint 1-2 (all format mode)


\
\ @brief VENC encoder control register 11
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG29_SWREG_FIELD                    \ H.264 Checkpoint 3 -4 (all format mode)


\
\ @brief VENC encoder control register 12
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG30_SWREG_FIELD                    \ H.264 checkpoint 5 -6 (all format mode)


\
\ @brief VENC encoder control register 13
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG31_SWREG_FIELD                    \ H.264 checkpoint 7 -8 (all format mode)


\
\ @brief VENC encoder control register 14
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG32_SWREG_FIELD                    \ H.264 Checkpoint 8 -10 / Encoder control register 14 (all format mode)


\
\ @brief VENC encoder control register 15
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG33_SWREG_FIELD                    \ H.264 Checkpoint word error 1-2 (all format mode)


\
\ @brief VENC encoder control register 16
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG34_SWREG_FIELD                    \ H.264 checkpoint word error 3-4 and the second reference frame control (all format mode)


\
\ @brief VENC H.264 checkpoint word error 5-6/encoder control register 17
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG35_SWREG_FIELD                    \ H.264 Checkpoint word error 5-6 / Encoder control register 17 (all format mode)


\
\ @brief VENC H.264 checkpoint delta QP 1-8/encoder control register 18
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG36_SWREG_FIELD                    \ H.264 Checkpoint delta QP 1-8 / Encoder control register 18 (all format mode)


\
\ @brief VENC encoder control register 19, stream start offset
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG37_SWREG_FIELD                    \ Encoder control register 19 (all format mode)


\
\ @brief VENC macroblock count output register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG38_SWREG_FIELD                    \ Macroblock count output (all format mode)


\
\ @brief VENC base address for next pic luminance register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG39_SWREG_FIELD                    \ Base address for next pic luminance (all format mode)


\
\ @brief VENC stabilization mode control register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG40_SWREG_FIELD                    \ Stabilization mode control (all format mode)


\
\ @brief VENC stabilization motion sum div8 output register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG41_SWREG_FIELD                    \ Stabilization motion sum div8 output (all format mode)


\
\ @brief VENC stabilization GMV output, matrix 1, up-left position output register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG42_SWREG_FIELD                    \ Stabilization GMV output, matrix 1 (up-left position) output (all format mode)


\
\ @brief VENC stabilization GMV output, matrix 2, up position output register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG43_SWREG_FIELD                    \ Stabilization GMV output, matrix 2 (up position) output (all format mode)


\
\ @brief VENC stabilization matrix 3, up-right position output register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG44_SWREG_FIELD                    \ Stabilization matrix 3 (up-right position) output (all format mode)


\
\ @brief VENC stabilization matrix 4, left position output register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG45_SWREG_FIELD                    \ Stabilization matrix 4 (left position) output (all format mode)


\
\ @brief VENC stabilization matrix 5, GMV position output register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG46_SWREG_FIELD                    \ Stabilization matrix 5 (GMV position) output (all format mode)


\
\ @brief VENC stabilization matrix 6, right position output register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG47_SWREG_FIELD                    \ Stabilization matrix 6 (right position) output (all format mode)


\
\ @brief VENC stabilization matrix 7, down-left position output register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG48_SWREG_FIELD                    \ Stabilization matrix 7 (down-left position) output (all format mode)


\
\ @brief VENC stabilization matrix 8, down position output register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG49_SWREG_FIELD                    \ Stabilization matrix 8 (down position) output (all format mode)


\
\ @brief VENC stabilization matrix 9, down-right position output register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG50_SWREG_FIELD                    \ Stabilization matrix 9 (down-right position) output (all format mode)


\
\ @brief VENC base address for cabac context tables H264 register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG51_SWREG_FIELD                    \ Base address for cabac context tables (H264) or probability tables (all format mode)


\
\ @brief VENC base address for MV output writing register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG52_SWREG_FIELD                    \ Base address for MV output writing (all format mode)


\
\ @brief VENC RGB to YUV conversion coefficient A - B register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG53_SWREG_FIELD                    \ RGB to YUV conversion coefficient A - B (all format mode)


\
\ @brief VENC RGB to YUV conversion coefficient C - E register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG54_SWREG_FIELD                    \ RGB to YUV conversion coefficient C - E (all format mode)


\
\ @brief VENC RGB to YUV conversion coefficient F, RGB mask MSB bit position register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG55_SWREG_FIELD                    \ RGB to YUV conversion coefficient F, RGB mask MSB bit position (all format mode)


\
\ @brief VENC intra area register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG56_SWREG_FIELD                    \ intra area (all format mode)


\
\ @brief VENC CIR intra mb position register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG57_SWREG_FIELD                    \ CIR intra mb position (all format mode)


\
\ @brief VENC intra slice bitmap for slices 0..31/base address for 1st DCT partition register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG58_SWREG_FIELD                    \ intra slice bitmap for slices 0..31 / Base address for 1st DCT partition (all format mode)


\
\ @brief VENC intra slice bitmap for slices 32..63/base address for 2nd DCT partition register
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG59_SWREG_FIELD                    \ intra slice bitmap for slices 32..63 / Base address for 2nd DCT partition (all format mode)


\
\ @brief VENC 1st ROI area register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG60_SWREG_FIELD                    \ 1st ROI area (all format mode)


\
\ @brief VENC 2nd ROI area register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG61_SWREG_FIELD                    \ 2nd ROI area (all format mode)


\
\ @brief VENC ROI area delta QP, MV register
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG62_SWREG_FIELD                    \ ROI area delta QP, MV (all format mode)


\
\ @brief VENC synthesis configuration register encoder 0 register
\ Address offset: 0xFC
\ Reset value: 0x1E622780
\

$00000000 constant VENC_VENC_SWREG63_SWREG_FIELD                    \ Synthesis configuration register encoder 0 (read only) (all format mode)


\
\ @brief VENC JPEG luma quantization 1/intra 16x16 mode 0-1 penalty register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG64_SWREG_FIELD                    \ JPEG luma quantization 1 / intra 16x16 mode 0-1 penalty (all format mode)


\
\ @brief VENC JPEG luma quantization 2/intra 16x16 mode 2-3 penalty register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG65_SWREG_FIELD                    \ JPEG luma quantization 2 / intra 16x16 mode 2-3 penalty (all format mode)


\
\ @brief VENC JPEG luma quantization 3/intra 4x4 mode 0-1 penalty register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG66_SWREG_FIELD                    \ JPEG luma quantization 3 / intra 4x4 mode 0-1 penalty (all format mode)


\
\ @brief VENC JPEG luma quantization 4/intra 4x4 mode 2-3 penalty register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG67_SWREG_FIELD                    \ JPEG luma quantization 4 / intra 4x4 mode 2-3 penalty (all format mode)


\
\ @brief VENC JPEG luma quantization 5/intra 4x4 mode 4-5 penalty register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG68_SWREG_FIELD                    \ JPEG luma quantization 5 / intra 4x4 mode 4-5 penalty (all format mode)


\
\ @brief VENC JPEG luma quantization 6/intra 4x4 mode 6-7 penalty register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG69_SWREG_FIELD                    \ JPEG luma quantization 6 / intra 4x4 mode 6-7 penalty (all format mode)


\
\ @brief VENC JPEG luma quantization 7/intra 4x4 mode 8-9 penalty register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG70_SWREG_FIELD                    \ JPEG luma quantization 7 / intra 4x4 mode 8-9 penalty (all format mode)


\
\ @brief VENC JPEG luma quantization 8/base address for segmentation map register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG71_SWREG_FIELD                    \ JPEG luma quantization 8 / Base address for segmentation map (all format mode)


\
\ @brief VENC JPEG luma quantization 9/segment1 parameter register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG72_SWREG_FIELD                    \ JPEG luma quantization 9 / segment1 parameter (all format mode)


\
\ @brief VENC JPEG luma quantization 10/segment1 parameter register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG73_SWREG_FIELD                    \ JPEG luma quantization 10 / segment1 parameter (all format mode)


\
\ @brief VENC JPEG luma quantization 11/segment1 parameter register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG74_SWREG_FIELD                    \ JPEG luma quantization 11 / segment1 parameter (all format mode)


\
\ @brief VENC JPEG luma quantization 12/segment1 parameter register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG75_SWREG_FIELD                    \ JPEG luma quantization 12 / segment1 parameter (all format mode)


\
\ @brief VENC JPEG luma quantization 13/segment1 parameter register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG76_SWREG_FIELD                    \ JPEG luma quantization 13 / segment1 parameter (all format mode)


\
\ @brief VENC JPEG luma quantization 14/segment1 parameter register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG77_SWREG_FIELD                    \ JPEG luma quantization 14 / segment1 parameter (all format mode)


\
\ @brief VENC JPEG luma quantization 15/segment1 parameter register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG78_SWREG_FIELD                    \ JPEG luma quantization 15 / segment1 parameter (all format mode)


\
\ @brief VENC JPEG luma quantization 16/segment2 parameter register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG79_SWREG_FIELD                    \ JPEG luma quantization 16 / segment2 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 1/segment2 parameter register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG80_SWREG_FIELD                    \ JPEG chroma quantization 1 / segment2 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 2/segment2 parameter register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG81_SWREG_FIELD                    \ JPEG chroma quantization 2 / segment2 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 3/segment2 parameter register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG82_SWREG_FIELD                    \ JPEG chroma quantization 3 / segment2 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 4/segment2 parameter register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG83_SWREG_FIELD                    \ JPEG chroma quantization 4 / segment2 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 5/segment2 parameter register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG84_SWREG_FIELD                    \ JPEG chroma quantization 5 / segment2 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 6/segment2 parameter register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG85_SWREG_FIELD                    \ JPEG chroma quantization 6 / segment2 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 7/segment2 parameter register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG86_SWREG_FIELD                    \ JPEG chroma quantization 7 / segment2 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 8/segment2 parameter register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG87_SWREG_FIELD                    \ JPEG chroma quantization 8 / segment2 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 9/segment3 parameter register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG88_SWREG_FIELD                    \ JPEG chroma quantization 9 / segment3 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 10/segment3 parameter register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG89_SWREG_FIELD                    \ JPEG chroma quantization 10 / segment3 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 11/segment3 parameter register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG90_SWREG_FIELD                    \ JPEG chroma quantization 11 / segment3 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 12/segment3 parameter register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG91_SWREG_FIELD                    \ JPEG chroma quantization 12 / segment3 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 13/segment3 parameter register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG92_SWREG_FIELD                    \ JPEG chroma quantization 13 / segment3 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 14/segment3 parameter register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG93_SWREG_FIELD                    \ JPEG chroma quantization 14 / segment3 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 15/segment3 parameter register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG94_SWREG_FIELD                    \ JPEG chroma quantization 15 / segment3 parameter (all format mode)


\
\ @brief VENC JPEG chroma quantization 16/segment3 parameter register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG95_SWREG_FIELD                    \ JPEG chroma quantization 16 / segment3 parameter (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values 0-3 register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG96_SWREG_FIELD                    \ DMV 4p/1p penalty values 0-3 (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values 4-7 register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG97_SWREG_FIELD                    \ DMV 4p/1p penalty values 4-7 (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG98_SWREG_FIELD                    \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG99_SWREG_FIELD                    \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG100_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG101_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG102_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG103_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG104_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG105_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG106_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG107_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG108_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG109_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG110_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG111_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG112_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG113_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG114_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG115_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG116_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG117_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1D8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG118_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG119_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG120_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG121_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG122_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG123_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG124_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG125_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values register
\ Address offset: 0x1F8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG126_SWREG_FIELD                   \ DMV 4p/1p penalty values (all format mode)


\
\ @brief VENC DMV 4p/1p penalty values 124-127 register
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG127_SWREG_FIELD                   \ DMV 4p/1p penalty values 124-127 (all format mode)


\
\ @brief VENC DMV qpel penalty values 0-3 register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG128_SWREG_FIELD                   \ DMV qpel penalty values 0-3 (all format mode)


\
\ @brief VENC DMV qpel penalty values 4-7 register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG129_SWREG_FIELD                   \ DMV qpel penalty values 4-7 (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG130_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG131_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG132_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG133_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG134_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG135_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG136_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG137_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG138_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG139_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG140_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG141_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG142_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG143_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG144_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG145_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG146_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG147_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG148_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG149_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG150_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG151_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG152_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG153_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG154_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG155_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG156_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG157_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values register
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG158_SWREG_FIELD                   \ DMV qpel penalty values (all format mode)


\
\ @brief VENC DMV qpel penalty values 124-127 register
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG159_SWREG_FIELD                   \ DMV qpel penalty values 124-127 (all format mode)


\
\ @brief VENC base address for output of down-scaled encoder image in YUYV 4:2:2 format register
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG231_SWREG_FIELD                   \ Base address for output of down-scaled encoder image in YUYV 4:2:2 format (all format mode)


\
\ @brief VENC scaling control register
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG232_SWREG_FIELD                   \ Scaling control (all format mode)


\
\ @brief VENC scaling control register
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG233_SWREG_FIELD                   \ Scaling control (all format mode)


\
\ @brief VENC squared error output calculated for 13x13 pixels per macroblock register
\ Address offset: 0x3B0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG236_SWREG_FIELD                   \ Squared error output calculated for 13x13 pixels per macroblock (all format mode)


\
\ @brief VENC MAD 2 control and output register
\ Address offset: 0x3B4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG237_SWREG_FIELD                   \ MAD 2 control and output (all format mode)


\
\ @brief VENC MAD 3 control and output register
\ Address offset: 0x3B8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG238_SWREG_FIELD                   \ MAD 3 control and output (all format mode)


\
\ @brief VENC segment 1: intra 16x16 mode 0-2 penalty register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG256_SWREG_FIELD                   \ segment 1: intra 16x16 mode 0-2 penalty (all format mode)


\
\ @brief VENC segment 1: intra 16x16 mode 3, intra 4x4 0-1 penalty register
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG257_SWREG_FIELD                   \ segment 1: intra 16x16 mode 3 and intra 4x4 0-1 penalty (all format mode)


\
\ @brief VENC segment 1: intra 4x4 mode 2-4 penalty register
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG258_SWREG_FIELD                   \ segment 1: intra 4x4 mode 2-4 penalty (all format mode)


\
\ @brief VENC segment 1: intra 4x4 mode 5-7 penalty register
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG259_SWREG_FIELD                   \ segment 1: intra 4x4 mode 5-7 penalty (all format mode)


\
\ @brief VENC segment 1: intra 4x4 mode 8-9 penalty, previous mode favor for H.264 register
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG260_SWREG_FIELD                   \ segment 1: intra 4x4 mode 8-9 penalty, previous mode favor for H.264 (all format mode)


\
\ @brief VENC segment 1: bit cost of inter type, intra 16x16 mode favor register
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG261_SWREG_FIELD                   \ segment 1: Bit cost of inter type, intra 16x16 mode favor (all format mode)


\
\ @brief VENC segment 1: inter MB mode favor, skip mode penalty, penalty value for 2nd reference frame register
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG262_SWREG_FIELD                   \ segment 1: inter MB mode favor, skip mode penalty, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 1: penalty value register
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG263_SWREG_FIELD                   \ segment 1: penalty value (all format mode)


\
\ @brief VENC segment 1: penalty value register
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG264_SWREG_FIELD                   \ segment 1: penalty value (all format mode)


\
\ @brief VENC segment 1: deadzone rate multiplier for plane 0-1 register
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG265_SWREG_FIELD                   \ segment 1: Deadzone rate multiplier for plane 0-1 (all format mode)


\
\ @brief VENC segment 1: deadzone rate multiplier for plane 2-3 register
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG266_SWREG_FIELD                   \ segment 1: Deadzone rate multiplier for plane 2-3 (all format mode)


\
\ @brief VENC segment 1: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
\ Address offset: 0x42C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG267_SWREG_FIELD                   \ segment 1: Deadzone rate for macroblock skip token 0-1, dmv penalty coefficient (all format mode)


\
\ @brief VENC segment 2: intra 16x16 mode 0-2 penalty register
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG268_SWREG_FIELD                   \ segment 2: intra 16x16 mode 0-2 penalty (all format mode)


\
\ @brief VENC segment 2: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty register
\ Address offset: 0x434
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG269_SWREG_FIELD                   \ segment 2: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty (all format mode)


\
\ @brief VENC segment 2: intra 4x4 mode 2-4 penalty register
\ Address offset: 0x438
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG270_SWREG_FIELD                   \ segment 2: intra 4x4 mode 2-4 penalty (all format mode)


\
\ @brief VENC segment 2: intra 4x4 mode 5-7 penalty register
\ Address offset: 0x43C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG271_SWREG_FIELD                   \ segment 2: intra 4x4 mode 5-7 penalty (all format mode)


\
\ @brief VENC segment 2: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 register
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG272_SWREG_FIELD                   \ segment 2: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 (all format mode)


\
\ @brief VENC segment 2: bit cost of inter type, intra 16x16 mode favor register
\ Address offset: 0x444
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG273_SWREG_FIELD                   \ segment 2: Bit cost of inter type, intra 16x16 mode favor (all format mode)


\
\ @brief VENC segment 2: inter MB mode favor, skip mode penalty, penalty value register
\ Address offset: 0x448
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG274_SWREG_FIELD                   \ segment 2: inter MB mode favor, skip mode penalty, panelty value (all format mode)


\
\ @brief VENC segment 2: penalty value register
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG275_SWREG_FIELD                   \ segment 2: penalty value (all format mode)


\
\ @brief VENC segment 2: penalty value register
\ Address offset: 0x450
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG276_SWREG_FIELD                   \ segment 2: penalty value (all format mode)


\
\ @brief VENC segment 2: deadzone rate multiplier for plane 0-1 register
\ Address offset: 0x454
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG277_SWREG_FIELD                   \ segment 2: Deadzone rate multiplier for plane 0-1 (all format mode)


\
\ @brief VENC segment 2: deadzone rate multiplier for plane 2-3 register
\ Address offset: 0x458
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG278_SWREG_FIELD                   \ segment 2: Deadzone rate multiplier for plane 2-3 (all format mode)


\
\ @brief VENC segment 2: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
\ Address offset: 0x45C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG279_SWREG_FIELD                   \ segment 2: Deadzone rate for macroblock skip token 0-1, dmv penalty coefficient (all format mode)


\
\ @brief VENC segment 3: intra 16x16 mode 0-2 penalty register
\ Address offset: 0x460
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG280_SWREG_FIELD                   \ segment 3: intra 16x16 mode 0-2 penalty (all format mode)


\
\ @brief VENC segment 3: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty register
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG281_SWREG_FIELD                   \ segment 3: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty (all format mode)


\
\ @brief VENC segment 3: intra 4x4 mode 2-4 penalty register
\ Address offset: 0x468
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG282_SWREG_FIELD                   \ segment 3: intra 4x4 mode 2-4 penalty (all format mode)


\
\ @brief VENC segment 3: intra 4x4 mode 5-7 penalty register
\ Address offset: 0x46C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG283_SWREG_FIELD                   \ segment 3: intra 4x4 mode 5-7 penalty (all format mode)


\
\ @brief VENC segment 3: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 register
\ Address offset: 0x470
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG284_SWREG_FIELD                   \ segment 3: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 (all format mode)


\
\ @brief VENC segment 3: bit cost of inter type, intra 16x16 mode favor register
\ Address offset: 0x474
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG285_SWREG_FIELD                   \ segment 3: Bit cost of inter type, intra 16x16 mode favor (all format mode)


\
\ @brief VENC segment 3: inter MB mode favor in intra/inter selection, inter MB mode favor, penalty value for second reference frame register
\ Address offset: 0x478
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG286_SWREG_FIELD                   \ segment 3: inter MB mode favor in intra/inter selection, inter MB mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 3: penalty value register
\ Address offset: 0x47C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG287_SWREG_FIELD                   \ segment 3: penalty value (all format mode)


\
\ @brief VENC segment 3: penalty value register
\ Address offset: 0x480
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG288_SWREG_FIELD                   \ segment 3: penalty value (all format mode)


\
\ @brief VENC segment 3: deadzone rate multiplier for plane 0-1 register
\ Address offset: 0x484
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG289_SWREG_FIELD                   \ segment 3: Deadzone rate multiplier for plane 0-1 (all format mode)


\
\ @brief VENC segment 3: deadzone rate multiplier for plane 2-3 register
\ Address offset: 0x488
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG290_SWREG_FIELD                   \ segment 3: Deadzone rate multiplier for plane 2-3 (all format mode)


\
\ @brief VENC segment 3: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
\ Address offset: 0x48C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG291_SWREG_FIELD                   \ segment 3: Deadzone rate for macroblock skip token 0-1, dmv penalty coefficient (all format mode)


\
\ @brief VENC Mb boost register
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG294_SWREG_FIELD                   \ Mb boost (all format mode)


\
\ @brief VENC variance control, Pskop conding mode register
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG295_SWREG_FIELD                   \ Variance control, Pskop conding mode (all format mode)


\
\ @brief VENC synthesis configuration register encoder 1 read only register
\ Address offset: 0x4A0
\ Reset value: 0x06800000
\

$00000000 constant VENC_VENC_SWREG296_SWREG_FIELD                   \ Synthesis configuration register encoder 1 (read only) (all format mode)


\
\ @brief VENC MBRC control register
\ Address offset: 0x4A4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG297_SWREG_FIELD                   \ MBRC control (all format mode)


\
\ @brief VENC segment 4: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x4A8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG298_SWREG_FIELD                   \ segment 4: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 4: skip mode penalty, inter MB mode favor register
\ Address offset: 0x4AC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG299_SWREG_FIELD                   \ segment 4: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 4: penalty value register
\ Address offset: 0x4B0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG300_SWREG_FIELD                   \ segment 4: penalty value (all format mode)


\
\ @brief VENC segment 4: penalty value register
\ Address offset: 0x4B4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG301_SWREG_FIELD                   \ segment 4: penalty value (all format mode)


\
\ @brief VENC segment 5: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x4B8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG302_SWREG_FIELD                   \ segment 5: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 5: skip mode penalty, inter MB mode favor register
\ Address offset: 0x4BC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG303_SWREG_FIELD                   \ segment 5: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 5: penalty value register
\ Address offset: 0x4C0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG304_SWREG_FIELD                   \ segment 5: penalty value (all format mode)


\
\ @brief VENC segment 5: penalty value register
\ Address offset: 0x4C4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG305_SWREG_FIELD                   \ segment 5: penalty value (all format mode)


\
\ @brief VENC segment 6: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x4C8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG306_SWREG_FIELD                   \ segment 6: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 6: skip mode penalty, inter MB mode favor register
\ Address offset: 0x4CC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG307_SWREG_FIELD                   \ segment 6: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 6: penalty value register
\ Address offset: 0x4D0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG308_SWREG_FIELD                   \ segment 6: penalty value (all format mode)


\
\ @brief VENC segment 6: penalty value register
\ Address offset: 0x4D4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG309_SWREG_FIELD                   \ segment 6: penalty value (all format mode)


\
\ @brief VENC segment 7: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x4D8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG310_SWREG_FIELD                   \ segment 7: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 7: skip mode penalty, inter MB mode favor register
\ Address offset: 0x4DC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG311_SWREG_FIELD                   \ segment 7: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 7: penalty value register
\ Address offset: 0x4E0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG312_SWREG_FIELD                   \ segment 7: penalty value (all format mode)


\
\ @brief VENC segment 7: penalty value register
\ Address offset: 0x4E4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG313_SWREG_FIELD                   \ segment 7: penalty value (all format mode)


\
\ @brief VENC segment 8: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x4E8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG314_SWREG_FIELD                   \ segment 8: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 8: skip mode penalty, inter MB mode favor register
\ Address offset: 0x4EC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG315_SWREG_FIELD                   \ segment 8: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 8: penalty value register
\ Address offset: 0x4F0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG316_SWREG_FIELD                   \ segment 8: penalty value (all format mode)


\
\ @brief VENC segment 8: penalty value register
\ Address offset: 0x4F4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG317_SWREG_FIELD                   \ segment 8: penalty value (all format mode)


\
\ @brief VENC segment 9: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x4F8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG318_SWREG_FIELD                   \ segment 9: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 9: skip mode penalty, inter MB mode favor register
\ Address offset: 0x4FC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG319_SWREG_FIELD                   \ segment 9: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 9: penalty value register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG320_SWREG_FIELD                   \ segment 9: penalty value (all format mode)


\
\ @brief VENC segment 9: penalty value register
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG321_SWREG_FIELD                   \ segment 9: penalty value (all format mode)


\
\ @brief VENC segment 10: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG322_SWREG_FIELD                   \ segment 10: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 10: skip mode penalty, inter MB mode favor register
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG323_SWREG_FIELD                   \ segment 10: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 10: penalty value register
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG324_SWREG_FIELD                   \ segment 10: penalty value (all format mode)


\
\ @brief VENC segment 10: penalty value register
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG325_SWREG_FIELD                   \ segment 10: penalty value (all format mode)


\
\ @brief VENC segment 11: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x518
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG326_SWREG_FIELD                   \ segment 11: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 11: skip mode penalty, inter MB mode favor register
\ Address offset: 0x51C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG327_SWREG_FIELD                   \ segment 11: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 11: penalty value register
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG328_SWREG_FIELD                   \ segment 11: penalty value (all format mode)


\
\ @brief VENC segment 11: penalty value register
\ Address offset: 0x524
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG329_SWREG_FIELD                   \ segment 11: penalty value (all format mode)


\
\ @brief VENC segment 12: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG330_SWREG_FIELD                   \ segment 12: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 12: skip mode penalty, inter MB mode favor register
\ Address offset: 0x52C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG331_SWREG_FIELD                   \ segment 12: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 12: penalty value register
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG332_SWREG_FIELD                   \ segment 12: penalty value (all format mode)


\
\ @brief VENC segment 12: penalty value register
\ Address offset: 0x534
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG333_SWREG_FIELD                   \ segment 12: penalty value (all format mode)


\
\ @brief VENC segment 13: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x538
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG334_SWREG_FIELD                   \ segment 13: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 13: skip mode penalty, inter MB mode favor register
\ Address offset: 0x53C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG335_SWREG_FIELD                   \ segment 13: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 13: penalty value register
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG336_SWREG_FIELD                   \ segment 13: penalty value (all format mode)


\
\ @brief VENC segment 13: penalty value register
\ Address offset: 0x544
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG337_SWREG_FIELD                   \ segment 13: penalty value (all format mode)


\
\ @brief VENC segment 14: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG338_SWREG_FIELD                   \ segment 14: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 14: skip mode penalty, inter MB mode favor register
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG339_SWREG_FIELD                   \ segment 14: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 14: penalty value register
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG340_SWREG_FIELD                   \ segment 14: penalty value (all format mode)


\
\ @brief VENC segment 14: penalty value register
\ Address offset: 0x554
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG341_SWREG_FIELD                   \ segment 14: penalty value (all format mode)


\
\ @brief VENC segment 15: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x558
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG342_SWREG_FIELD                   \ segment 15: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 15: skip mode penalty, inter MB mode favor register
\ Address offset: 0x55C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG343_SWREG_FIELD                   \ segment 15: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 15: penalty value register
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG344_SWREG_FIELD                   \ segment 15: penalty value (all format mode)


\
\ @brief VENC segment 15: penalty value register
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG345_SWREG_FIELD                   \ segment 15: penalty value (all format mode)


\
\ @brief VENC segment 16: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x568
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG346_SWREG_FIELD                   \ segment 16: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 16: skip mode penalty, inter MB mode favor register
\ Address offset: 0x56C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG347_SWREG_FIELD                   \ segment 16: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 16: penalty value register
\ Address offset: 0x570
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG348_SWREG_FIELD                   \ segment 16: penalty value (all format mode)


\
\ @brief VENC segment 16: penalty value register
\ Address offset: 0x574
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG349_SWREG_FIELD                   \ segment 16: penalty value (all format mode)


\
\ @brief VENC segment 17: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x578
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG350_SWREG_FIELD                   \ segment 17: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 17: skip mode penalty, inter MB mode favor register
\ Address offset: 0x57C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG351_SWREG_FIELD                   \ segment 17: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 17: penalty value register
\ Address offset: 0x580
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG352_SWREG_FIELD                   \ segment 17: penalty value (all format mode)


\
\ @brief VENC segment 17: penalty value register
\ Address offset: 0x584
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG353_SWREG_FIELD                   \ segment 17: penalty value (all format mode)


\
\ @brief VENC segment 18: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x588
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG354_SWREG_FIELD                   \ segment 18: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 18: skip mode penalty, inter MB mode favor register
\ Address offset: 0x58C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG355_SWREG_FIELD                   \ segment 18: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 18: penalty value register
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG356_SWREG_FIELD                   \ segment 18: penalty value (all format mode)


\
\ @brief VENC segment 18: penalty value register
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG357_SWREG_FIELD                   \ segment 18: penalty value (all format mode)


\
\ @brief VENC segment 19: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x598
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG358_SWREG_FIELD                   \ segment 19: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 19: skip mode penalty, inter MB mode favor register
\ Address offset: 0x59C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG359_SWREG_FIELD                   \ segment 19: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 19: penalty value register
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG360_SWREG_FIELD                   \ segment 19: penalty value (all format mode)


\
\ @brief VENC segment 19: penalty value register
\ Address offset: 0x5A4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG361_SWREG_FIELD                   \ segment 19: penalty value (all format mode)


\
\ @brief VENC segment 20: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x5A8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG362_SWREG_FIELD                   \ segment 20: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 20: skip mode penalty, inter MB mode favor register
\ Address offset: 0x5AC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG363_SWREG_FIELD                   \ segment 20: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 20: penalty value register
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG364_SWREG_FIELD                   \ segment 20: penalty value (all format mode)


\
\ @brief VENC segment 20: penalty value register
\ Address offset: 0x5B4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG365_SWREG_FIELD                   \ segment 20: penalty value (all format mode)


\
\ @brief VENC segment 21: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x5B8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG366_SWREG_FIELD                   \ segment 21: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 21: skip mode penalty, inter MB mode favor register
\ Address offset: 0x5BC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG367_SWREG_FIELD                   \ segment 21: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 21: penalty value register
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG368_SWREG_FIELD                   \ segment 21: penalty value (all format mode)


\
\ @brief VENC segment 21: penalty value register
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG369_SWREG_FIELD                   \ segment 21: penalty value (all format mode)


\
\ @brief VENC segment 22: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG370_SWREG_FIELD                   \ segment 22: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 22: skip mode penalty, inter MB mode favor register
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG371_SWREG_FIELD                   \ segment 22: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 22: penalty value register
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG372_SWREG_FIELD                   \ segment 22: penalty value (all format mode)


\
\ @brief VENC segment 22: penalty value register
\ Address offset: 0x5D4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG373_SWREG_FIELD                   \ segment 22: penalty value (all format mode)


\
\ @brief VENC segment 23: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x5D8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG374_SWREG_FIELD                   \ segment 23: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 23: skip mode penalty, inter MB mode favor register
\ Address offset: 0x5DC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG375_SWREG_FIELD                   \ segment 23: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 23: penalty value register
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG376_SWREG_FIELD                   \ segment 23: penalty value (all format mode)


\
\ @brief VENC segment 23: penalty value register
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG377_SWREG_FIELD                   \ segment 23: penalty value (all format mode)


\
\ @brief VENC segment 24: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG378_SWREG_FIELD                   \ segment 24: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 24: skip mode penalty, inter MB mode favor register
\ Address offset: 0x5EC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG379_SWREG_FIELD                   \ segment 24: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 24: penalty value register
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG380_SWREG_FIELD                   \ segment 24: penalty value (all format mode)


\
\ @brief VENC segment 24: penalty value register
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG381_SWREG_FIELD                   \ segment 24: penalty value (all format mode)


\
\ @brief VENC segment 25: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x5F8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG382_SWREG_FIELD                   \ segment 25: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 25: skip mode penalty, inter MB mode favor register
\ Address offset: 0x5FC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG383_SWREG_FIELD                   \ segment 25: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 25: penalty value register
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG384_SWREG_FIELD                   \ segment 25: penalty value (all format mode)


\
\ @brief VENC segment 25: penalty value register
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG385_SWREG_FIELD                   \ segment 25: penalty value (all format mode)


\
\ @brief VENC segment 26: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG386_SWREG_FIELD                   \ segment 26: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 26: skip mode penalty, inter MB mode favor register
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG387_SWREG_FIELD                   \ segment 26: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 26: penalty value register
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG388_SWREG_FIELD                   \ segment 26: penalty value (all format mode)


\
\ @brief VENC segment 26: penalty value register
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG389_SWREG_FIELD                   \ segment 26: penalty value (all format mode)


\
\ @brief VENC segment 27: intra 4x4 previous mode favor, intra 16x16mode favor, penalty value for second reference frame register
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG390_SWREG_FIELD                   \ segment 27: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 27: skip mode penalty, inter MB mode favor register
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG391_SWREG_FIELD                   \ segment 27: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 27: penalty value register
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG392_SWREG_FIELD                   \ segment 27: penalty value (all format mode)


\
\ @brief VENC segment 27: penalty value register
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG393_SWREG_FIELD                   \ segment 27: penalty value (all format mode)


\
\ @brief VENC segment 28: intra 4x4 previous mode favor, intra 16x16mode favor, penalty value for second reference frame register
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG394_SWREG_FIELD                   \ segment 28: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 28: skip mode penalty, inter MB mode favor register
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG395_SWREG_FIELD                   \ segment 28: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 28: penalty value register
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG396_SWREG_FIELD                   \ segment 28: penalty value (all format mode)


\
\ @brief VENC segment 28: penalty value register
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG397_SWREG_FIELD                   \ segment 28: penalty value (all format mode)


\
\ @brief VENC segment 29: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x638
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG398_SWREG_FIELD                   \ segment 29: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 29: skip mode penalty, inter MB mode favor register
\ Address offset: 0x63C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG399_SWREG_FIELD                   \ segment 29: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 29: penalty value register
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG400_SWREG_FIELD                   \ segment 29: penalty value (all format mode)


\
\ @brief VENC segment 29: penalty value register
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG401_SWREG_FIELD                   \ segment 29: penalty value (all format mode)


\
\ @brief VENC segment 30: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG402_SWREG_FIELD                   \ segment 30: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 30: skip mode penalty, inter MB mode favor register
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG403_SWREG_FIELD                   \ segment 30: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 30: penalty value register
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG404_SWREG_FIELD                   \ segment 30: penalty value (all format mode)


\
\ @brief VENC segment 30: penalty value register
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG405_SWREG_FIELD                   \ segment 30: penalty value (all format mode)


\
\ @brief VENC segment 31: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
\ Address offset: 0x658
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG406_SWREG_FIELD                   \ segment 31: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)


\
\ @brief VENC segment 31: skip mode penalty, inter MB mode favor register
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG407_SWREG_FIELD                   \ segment 31: skip mode penalty, inter MB mode favor (all format mode)


\
\ @brief VENC segment 31: penalty value register
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG408_SWREG_FIELD                   \ segment 31: penalty value (all format mode)


\
\ @brief VENC segment 31: penalty value register
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG409_SWREG_FIELD                   \ segment 31: penalty value (all format mode)


\
\ @brief VENC MBRC control, QP, offset, enable register
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG410_SWREG_FIELD                   \ MBRC control (QP, offset, enable) (all format mode)


\
\ @brief VENC gain of MB QP delta. 8.8 format register
\ Address offset: 0x66C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG411_SWREG_FIELD                   \ gain of MB QPdelta. 8.8 format (all format mode)


\
\ @brief VENC average of MB complexity register
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG412_SWREG_FIELD                   \ average of MB complexity (all format mode)


\
\ @brief VENC reference compression control register
\ Address offset: 0x674
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG413_SWREG_FIELD                   \ average of MB complexity (all format mode)


\
\ @brief VENC base address for reference luma register
\ Address offset: 0x678
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG414_SWREG_FIELD                   \ average of MB complexity (all format mode)


\
\ @brief VENC base address for reference chroma register
\ Address offset: 0x67C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG415_SWREG_FIELD                   \ average of MB complexity (all format mode)


\
\ @brief VENC base address for reconstructed luma register
\ Address offset: 0x680
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG416_SWREG_FIELD                   \ average of MB complexity (all format mode)


\
\ @brief VENC base address for reconstructed chroma register
\ Address offset: 0x684
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG417_SWREG_FIELD                   \ average of MB complexity (all format mode)


\
\ @brief VENC base address for second reference luma register
\ Address offset: 0x688
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG418_SWREG_FIELD                   \ average of MB complexity (all format mode)


\
\ @brief VENC base address for second reference chroma register
\ Address offset: 0x68C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG419_SWREG_FIELD                   \ average of MB complexity (all format mode)


\
\ @brief VENC limit of chroma RFC buffer register
\ Address offset: 0x690
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG420_SWREG_FIELD                   \ average of MB complexity (all format mode)


\
\ @brief VENC reorder control register
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG421_SWREG_FIELD                   \ Reorder control (all format mode)


\
\ @brief VENC AXI read ID register
\ Address offset: 0x698
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG422_SWREG_FIELD                   \ AXI Read ID (all format mode)


\
\ @brief VENC base address MSB for reference luma compression table register
\ Address offset: 0x69C
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG423_SWREG_FIELD                   \ AXI Read ID (all format mode)


\
\ @brief VENC base address MSB for reference chroma compression table register
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG424_SWREG_FIELD                   \ AXI Read ID (all format mode)


\
\ @brief VENC base address MSB for reconstructed luma compression table register
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG425_SWREG_FIELD                   \ AXI Read ID (all format mode)


\
\ @brief VENC base address for reconstructed chroma compression table register
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG426_SWREG_FIELD                   \ Base address for reconstructed chroma compression table (all format mode)


\
\ @brief VENC base address MSB for second reference luma compression table register
\ Address offset: 0x6AC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG427_SWREG_FIELD                   \ Base address MSB for second reference luma compression table (all format mode)


\
\ @brief VENC base address MSB for second reference chroma compression table register
\ Address offset: 0x6B0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG428_SWREG_FIELD                   \ Base address MSB for second reference chroma compression table (all format mode)


\
\ @brief VENC high 32 bits of base address for output stream data register
\ Address offset: 0x6B4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG429_SWREG_FIELD                   \ high 32 bits of Base address for output stream data (all format mode)


\
\ @brief VENC high 32 bits of base address for output control data register
\ Address offset: 0x6B8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG430_SWREG_FIELD                   \ high 32 bits of Base address for output control data (all format mode)


\
\ @brief VENC high 32 bits of base address for reference luma register
\ Address offset: 0x6BC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG431_SWREG_FIELD                   \ high 32 bits of Base address for reference luma (all format mode)


\
\ @brief VENC high 32 bits of base address for reference chroma register
\ Address offset: 0x6C0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG432_SWREG_FIELD                   \ high 32 bits of Base address for reference chroma (all format mode)


\
\ @brief VENC high 32 bits of base address for reconstructed luma register
\ Address offset: 0x6C4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG433_SWREG_FIELD                   \ high 32 bits of Base address for reconstructed luma (all format mode)


\
\ @brief VENC high 32 bits of base address for reconstructed chroma register
\ Address offset: 0x6C8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG434_SWREG_FIELD                   \ high 32 bits of Base address for reconstructed chroma (all format mode)


\
\ @brief VENC high 32 bits of base address for input picture luma register
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG435_SWREG_FIELD                   \ high 32 bits of Base address for input picture luma (all format mode)


\
\ @brief VENC high 32 bits of base address for input picture cb register
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG436_SWREG_FIELD                   \ high 32 bits of Base address for input picture cb (all format mode)


\
\ @brief VENC high 32 bits of base address for input picture cr register
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG437_SWREG_FIELD                   \ high 32 bits of Base address for input picture cr (all format mode)


\
\ @brief VENC high 32 bits of base address for second reference luma register
\ Address offset: 0x6D8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG438_SWREG_FIELD                   \ high 32 bits of Base address for second reference luma (all format mode)


\
\ @brief VENC high 32 bits of base address for second reference chroma register
\ Address offset: 0x6DC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG439_SWREG_FIELD                   \ high 32 bits of Base address for second reference chroma (all format mode)


\
\ @brief VENC high 32 bits of H264 secondary ref pic base register
\ Address offset: 0x6E0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG440_SWREG_FIELD                   \ high 32 bits of H264 secondary ref pic base (all format mode)


\
\ @brief VENC high 32 bits of H264 secondary ref pic base register
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG441_SWREG_FIELD                   \ high 32 bits of H264 secondary ref pic base (all format mode)


\
\ @brief VENC high 32 bits of base address for next pic luminance register
\ Address offset: 0x6E8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG442_SWREG_FIELD                   \ high 32 bits of Base address for next pic luminance (all format mode)


\
\ @brief VENC high 32 bits of base address for cabac context tables H264 register
\ Address offset: 0x6EC
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG443_SWREG_FIELD                   \ high 32 bits of Base address for cabac context tables (H264) or probability tables (all format mode)


\
\ @brief VENC high 32 bits of base address for MV output writing register
\ Address offset: 0x6F0
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG444_SWREG_FIELD                   \ high 32 bits of Base address for MV output writing (all format mode)


\
\ @brief VENC high 32 bits of base address for output of down-scaled encoder image in YUYV 4:2:2 format register
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG449_SWREG_FIELD                   \ high 32 bits of Base address for output of down-scaled encoder image in YUYV 4:2:2 format (all format mode)


\
\ @brief VENC low-latency control register
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG497_SWREG_FIELD                   \ Low latency control (all format mode)


\
\ @brief VENC encoder line buffer offset register
\ Address offset: 0x7C8
\ Reset value: 0x00000000
\

$00000000 constant VENC_VENC_SWREG498_SWREG_FIELD                   \ Low latency control (all format mode)


\
\ @brief Video encoder
\
$48005000 constant VENC_VENC_SWREG0  \ offset: 0x00 : VENC ID register
$48005004 constant VENC_VENC_SWREG1  \ offset: 0x04 : VENC interrupt register
$48005008 constant VENC_VENC_SWREG2  \ offset: 0x08 : VENC bus interface configuration register
$4800500c constant VENC_VENC_SWREG3  \ offset: 0x0C : VENC device configuration register
$48005014 constant VENC_VENC_SWREG5  \ offset: 0x14 : VENC base address for output stream data register
$48005018 constant VENC_VENC_SWREG6  \ offset: 0x18 : VENC base address for output control data register
$4800501c constant VENC_VENC_SWREG7  \ offset: 0x1C : VENC base address for reference luma register
$48005020 constant VENC_VENC_SWREG8  \ offset: 0x20 : VENC base address for reference chroma register
$48005024 constant VENC_VENC_SWREG9  \ offset: 0x24 : VENC base address for reconstructed luma register
$48005028 constant VENC_VENC_SWREG10  \ offset: 0x28 : VENC base address for reconstructed chroma register
$4800502c constant VENC_VENC_SWREG11  \ offset: 0x2C : VENC base address for input picture luma register
$48005030 constant VENC_VENC_SWREG12  \ offset: 0x30 : VENC base address for input picture cb register
$48005034 constant VENC_VENC_SWREG13  \ offset: 0x34 : VENC base address for input picture cr register
$48005038 constant VENC_VENC_SWREG14  \ offset: 0x38 : VENC encoder control register 0
$4800503c constant VENC_VENC_SWREG15  \ offset: 0x3C : VENC encoder control register 1
$48005040 constant VENC_VENC_SWREG16  \ offset: 0x40 : VENC encoder control register 2
$48005044 constant VENC_VENC_SWREG17  \ offset: 0x44 : VENC encoder control register 3
$48005048 constant VENC_VENC_SWREG18  \ offset: 0x48 : VENC encoder control register 4
$4800504c constant VENC_VENC_SWREG19  \ offset: 0x4C : VENC encoder control register 5
$48005050 constant VENC_VENC_SWREG20  \ offset: 0x50 : VENC encoder control register 6
$48005054 constant VENC_VENC_SWREG21  \ offset: 0x54 : VENC encoder control register 7
$48005058 constant VENC_VENC_SWREG22  \ offset: 0x58 : VENC stream header remainder MSB bits register
$4800505c constant VENC_VENC_SWREG23  \ offset: 0x5C : VENC stream header remainder LSB bits register
$48005060 constant VENC_VENC_SWREG24  \ offset: 0x60 : VENC stream buffer limit/output stream size register
$48005064 constant VENC_VENC_SWREG25  \ offset: 0x64 : VENC encoder control register 8
$48005068 constant VENC_VENC_SWREG26  \ offset: 0x68 : VENC intra-slice bitmap register
$4800506c constant VENC_VENC_SWREG27  \ offset: 0x6C : VENC encoder control register 9
$48005070 constant VENC_VENC_SWREG28  \ offset: 0x70 : VENC encoder control register 10
$48005074 constant VENC_VENC_SWREG29  \ offset: 0x74 : VENC encoder control register 11
$48005078 constant VENC_VENC_SWREG30  \ offset: 0x78 : VENC encoder control register 12
$4800507c constant VENC_VENC_SWREG31  \ offset: 0x7C : VENC encoder control register 13
$48005080 constant VENC_VENC_SWREG32  \ offset: 0x80 : VENC encoder control register 14
$48005084 constant VENC_VENC_SWREG33  \ offset: 0x84 : VENC encoder control register 15
$48005088 constant VENC_VENC_SWREG34  \ offset: 0x88 : VENC encoder control register 16
$4800508c constant VENC_VENC_SWREG35  \ offset: 0x8C : VENC H.264 checkpoint word error 5-6/encoder control register 17
$48005090 constant VENC_VENC_SWREG36  \ offset: 0x90 : VENC H.264 checkpoint delta QP 1-8/encoder control register 18
$48005094 constant VENC_VENC_SWREG37  \ offset: 0x94 : VENC encoder control register 19, stream start offset
$48005098 constant VENC_VENC_SWREG38  \ offset: 0x98 : VENC macroblock count output register
$4800509c constant VENC_VENC_SWREG39  \ offset: 0x9C : VENC base address for next pic luminance register
$480050a0 constant VENC_VENC_SWREG40  \ offset: 0xA0 : VENC stabilization mode control register
$480050a4 constant VENC_VENC_SWREG41  \ offset: 0xA4 : VENC stabilization motion sum div8 output register
$480050a8 constant VENC_VENC_SWREG42  \ offset: 0xA8 : VENC stabilization GMV output, matrix 1, up-left position output register
$480050ac constant VENC_VENC_SWREG43  \ offset: 0xAC : VENC stabilization GMV output, matrix 2, up position output register
$480050b0 constant VENC_VENC_SWREG44  \ offset: 0xB0 : VENC stabilization matrix 3, up-right position output register
$480050b4 constant VENC_VENC_SWREG45  \ offset: 0xB4 : VENC stabilization matrix 4, left position output register
$480050b8 constant VENC_VENC_SWREG46  \ offset: 0xB8 : VENC stabilization matrix 5, GMV position output register
$480050bc constant VENC_VENC_SWREG47  \ offset: 0xBC : VENC stabilization matrix 6, right position output register
$480050c0 constant VENC_VENC_SWREG48  \ offset: 0xC0 : VENC stabilization matrix 7, down-left position output register
$480050c4 constant VENC_VENC_SWREG49  \ offset: 0xC4 : VENC stabilization matrix 8, down position output register
$480050c8 constant VENC_VENC_SWREG50  \ offset: 0xC8 : VENC stabilization matrix 9, down-right position output register
$480050cc constant VENC_VENC_SWREG51  \ offset: 0xCC : VENC base address for cabac context tables H264 register
$480050d0 constant VENC_VENC_SWREG52  \ offset: 0xD0 : VENC base address for MV output writing register
$480050d4 constant VENC_VENC_SWREG53  \ offset: 0xD4 : VENC RGB to YUV conversion coefficient A - B register
$480050d8 constant VENC_VENC_SWREG54  \ offset: 0xD8 : VENC RGB to YUV conversion coefficient C - E register
$480050dc constant VENC_VENC_SWREG55  \ offset: 0xDC : VENC RGB to YUV conversion coefficient F, RGB mask MSB bit position register
$480050e0 constant VENC_VENC_SWREG56  \ offset: 0xE0 : VENC intra area register
$480050e4 constant VENC_VENC_SWREG57  \ offset: 0xE4 : VENC CIR intra mb position register
$480050e8 constant VENC_VENC_SWREG58  \ offset: 0xE8 : VENC intra slice bitmap for slices 0..31/base address for 1st DCT partition register
$480050ec constant VENC_VENC_SWREG59  \ offset: 0xEC : VENC intra slice bitmap for slices 32..63/base address for 2nd DCT partition register
$480050f0 constant VENC_VENC_SWREG60  \ offset: 0xF0 : VENC 1st ROI area register
$480050f4 constant VENC_VENC_SWREG61  \ offset: 0xF4 : VENC 2nd ROI area register
$480050f8 constant VENC_VENC_SWREG62  \ offset: 0xF8 : VENC ROI area delta QP, MV register
$480050fc constant VENC_VENC_SWREG63  \ offset: 0xFC : VENC synthesis configuration register encoder 0 register
$48005100 constant VENC_VENC_SWREG64  \ offset: 0x100 : VENC JPEG luma quantization 1/intra 16x16 mode 0-1 penalty register
$48005104 constant VENC_VENC_SWREG65  \ offset: 0x104 : VENC JPEG luma quantization 2/intra 16x16 mode 2-3 penalty register
$48005108 constant VENC_VENC_SWREG66  \ offset: 0x108 : VENC JPEG luma quantization 3/intra 4x4 mode 0-1 penalty register
$4800510c constant VENC_VENC_SWREG67  \ offset: 0x10C : VENC JPEG luma quantization 4/intra 4x4 mode 2-3 penalty register
$48005110 constant VENC_VENC_SWREG68  \ offset: 0x110 : VENC JPEG luma quantization 5/intra 4x4 mode 4-5 penalty register
$48005114 constant VENC_VENC_SWREG69  \ offset: 0x114 : VENC JPEG luma quantization 6/intra 4x4 mode 6-7 penalty register
$48005118 constant VENC_VENC_SWREG70  \ offset: 0x118 : VENC JPEG luma quantization 7/intra 4x4 mode 8-9 penalty register
$4800511c constant VENC_VENC_SWREG71  \ offset: 0x11C : VENC JPEG luma quantization 8/base address for segmentation map register
$48005120 constant VENC_VENC_SWREG72  \ offset: 0x120 : VENC JPEG luma quantization 9/segment1 parameter register
$48005124 constant VENC_VENC_SWREG73  \ offset: 0x124 : VENC JPEG luma quantization 10/segment1 parameter register
$48005128 constant VENC_VENC_SWREG74  \ offset: 0x128 : VENC JPEG luma quantization 11/segment1 parameter register
$4800512c constant VENC_VENC_SWREG75  \ offset: 0x12C : VENC JPEG luma quantization 12/segment1 parameter register
$48005130 constant VENC_VENC_SWREG76  \ offset: 0x130 : VENC JPEG luma quantization 13/segment1 parameter register
$48005134 constant VENC_VENC_SWREG77  \ offset: 0x134 : VENC JPEG luma quantization 14/segment1 parameter register
$48005138 constant VENC_VENC_SWREG78  \ offset: 0x138 : VENC JPEG luma quantization 15/segment1 parameter register
$4800513c constant VENC_VENC_SWREG79  \ offset: 0x13C : VENC JPEG luma quantization 16/segment2 parameter register
$48005140 constant VENC_VENC_SWREG80  \ offset: 0x140 : VENC JPEG chroma quantization 1/segment2 parameter register
$48005144 constant VENC_VENC_SWREG81  \ offset: 0x144 : VENC JPEG chroma quantization 2/segment2 parameter register
$48005148 constant VENC_VENC_SWREG82  \ offset: 0x148 : VENC JPEG chroma quantization 3/segment2 parameter register
$4800514c constant VENC_VENC_SWREG83  \ offset: 0x14C : VENC JPEG chroma quantization 4/segment2 parameter register
$48005150 constant VENC_VENC_SWREG84  \ offset: 0x150 : VENC JPEG chroma quantization 5/segment2 parameter register
$48005154 constant VENC_VENC_SWREG85  \ offset: 0x154 : VENC JPEG chroma quantization 6/segment2 parameter register
$48005158 constant VENC_VENC_SWREG86  \ offset: 0x158 : VENC JPEG chroma quantization 7/segment2 parameter register
$4800515c constant VENC_VENC_SWREG87  \ offset: 0x15C : VENC JPEG chroma quantization 8/segment2 parameter register
$48005160 constant VENC_VENC_SWREG88  \ offset: 0x160 : VENC JPEG chroma quantization 9/segment3 parameter register
$48005164 constant VENC_VENC_SWREG89  \ offset: 0x164 : VENC JPEG chroma quantization 10/segment3 parameter register
$48005168 constant VENC_VENC_SWREG90  \ offset: 0x168 : VENC JPEG chroma quantization 11/segment3 parameter register
$4800516c constant VENC_VENC_SWREG91  \ offset: 0x16C : VENC JPEG chroma quantization 12/segment3 parameter register
$48005170 constant VENC_VENC_SWREG92  \ offset: 0x170 : VENC JPEG chroma quantization 13/segment3 parameter register
$48005174 constant VENC_VENC_SWREG93  \ offset: 0x174 : VENC JPEG chroma quantization 14/segment3 parameter register
$48005178 constant VENC_VENC_SWREG94  \ offset: 0x178 : VENC JPEG chroma quantization 15/segment3 parameter register
$4800517c constant VENC_VENC_SWREG95  \ offset: 0x17C : VENC JPEG chroma quantization 16/segment3 parameter register
$48005180 constant VENC_VENC_SWREG96  \ offset: 0x180 : VENC DMV 4p/1p penalty values 0-3 register
$48005184 constant VENC_VENC_SWREG97  \ offset: 0x184 : VENC DMV 4p/1p penalty values 4-7 register
$48005188 constant VENC_VENC_SWREG98  \ offset: 0x188 : VENC DMV 4p/1p penalty values register
$4800518c constant VENC_VENC_SWREG99  \ offset: 0x18C : VENC DMV 4p/1p penalty values register
$48005190 constant VENC_VENC_SWREG100  \ offset: 0x190 : VENC DMV 4p/1p penalty values register
$48005194 constant VENC_VENC_SWREG101  \ offset: 0x194 : VENC DMV 4p/1p penalty values register
$48005198 constant VENC_VENC_SWREG102  \ offset: 0x198 : VENC DMV 4p/1p penalty values register
$4800519c constant VENC_VENC_SWREG103  \ offset: 0x19C : VENC DMV 4p/1p penalty values register
$480051a0 constant VENC_VENC_SWREG104  \ offset: 0x1A0 : VENC DMV 4p/1p penalty values register
$480051a4 constant VENC_VENC_SWREG105  \ offset: 0x1A4 : VENC DMV 4p/1p penalty values register
$480051a8 constant VENC_VENC_SWREG106  \ offset: 0x1A8 : VENC DMV 4p/1p penalty values register
$480051ac constant VENC_VENC_SWREG107  \ offset: 0x1AC : VENC DMV 4p/1p penalty values register
$480051b0 constant VENC_VENC_SWREG108  \ offset: 0x1B0 : VENC DMV 4p/1p penalty values register
$480051b4 constant VENC_VENC_SWREG109  \ offset: 0x1B4 : VENC DMV 4p/1p penalty values register
$480051b8 constant VENC_VENC_SWREG110  \ offset: 0x1B8 : VENC DMV 4p/1p penalty values register
$480051bc constant VENC_VENC_SWREG111  \ offset: 0x1BC : VENC DMV 4p/1p penalty values register
$480051c0 constant VENC_VENC_SWREG112  \ offset: 0x1C0 : VENC DMV 4p/1p penalty values register
$480051c4 constant VENC_VENC_SWREG113  \ offset: 0x1C4 : VENC DMV 4p/1p penalty values register
$480051c8 constant VENC_VENC_SWREG114  \ offset: 0x1C8 : VENC DMV 4p/1p penalty values register
$480051cc constant VENC_VENC_SWREG115  \ offset: 0x1CC : VENC DMV 4p/1p penalty values register
$480051d0 constant VENC_VENC_SWREG116  \ offset: 0x1D0 : VENC DMV 4p/1p penalty values register
$480051d4 constant VENC_VENC_SWREG117  \ offset: 0x1D4 : VENC DMV 4p/1p penalty values register
$480051d8 constant VENC_VENC_SWREG118  \ offset: 0x1D8 : VENC DMV 4p/1p penalty values register
$480051dc constant VENC_VENC_SWREG119  \ offset: 0x1DC : VENC DMV 4p/1p penalty values register
$480051e0 constant VENC_VENC_SWREG120  \ offset: 0x1E0 : VENC DMV 4p/1p penalty values register
$480051e4 constant VENC_VENC_SWREG121  \ offset: 0x1E4 : VENC DMV 4p/1p penalty values register
$480051e8 constant VENC_VENC_SWREG122  \ offset: 0x1E8 : VENC DMV 4p/1p penalty values register
$480051ec constant VENC_VENC_SWREG123  \ offset: 0x1EC : VENC DMV 4p/1p penalty values register
$480051f0 constant VENC_VENC_SWREG124  \ offset: 0x1F0 : VENC DMV 4p/1p penalty values register
$480051f4 constant VENC_VENC_SWREG125  \ offset: 0x1F4 : VENC DMV 4p/1p penalty values register
$480051f8 constant VENC_VENC_SWREG126  \ offset: 0x1F8 : VENC DMV 4p/1p penalty values register
$480051fc constant VENC_VENC_SWREG127  \ offset: 0x1FC : VENC DMV 4p/1p penalty values 124-127 register
$48005200 constant VENC_VENC_SWREG128  \ offset: 0x200 : VENC DMV qpel penalty values 0-3 register
$48005204 constant VENC_VENC_SWREG129  \ offset: 0x204 : VENC DMV qpel penalty values 4-7 register
$48005208 constant VENC_VENC_SWREG130  \ offset: 0x208 : VENC DMV qpel penalty values register
$4800520c constant VENC_VENC_SWREG131  \ offset: 0x20C : VENC DMV qpel penalty values register
$48005210 constant VENC_VENC_SWREG132  \ offset: 0x210 : VENC DMV qpel penalty values register
$48005214 constant VENC_VENC_SWREG133  \ offset: 0x214 : VENC DMV qpel penalty values register
$48005218 constant VENC_VENC_SWREG134  \ offset: 0x218 : VENC DMV qpel penalty values register
$4800521c constant VENC_VENC_SWREG135  \ offset: 0x21C : VENC DMV qpel penalty values register
$48005220 constant VENC_VENC_SWREG136  \ offset: 0x220 : VENC DMV qpel penalty values register
$48005224 constant VENC_VENC_SWREG137  \ offset: 0x224 : VENC DMV qpel penalty values register
$48005228 constant VENC_VENC_SWREG138  \ offset: 0x228 : VENC DMV qpel penalty values register
$4800522c constant VENC_VENC_SWREG139  \ offset: 0x22C : VENC DMV qpel penalty values register
$48005230 constant VENC_VENC_SWREG140  \ offset: 0x230 : VENC DMV qpel penalty values register
$48005234 constant VENC_VENC_SWREG141  \ offset: 0x234 : VENC DMV qpel penalty values register
$48005238 constant VENC_VENC_SWREG142  \ offset: 0x238 : VENC DMV qpel penalty values register
$4800523c constant VENC_VENC_SWREG143  \ offset: 0x23C : VENC DMV qpel penalty values register
$48005240 constant VENC_VENC_SWREG144  \ offset: 0x240 : VENC DMV qpel penalty values register
$48005244 constant VENC_VENC_SWREG145  \ offset: 0x244 : VENC DMV qpel penalty values register
$48005248 constant VENC_VENC_SWREG146  \ offset: 0x248 : VENC DMV qpel penalty values register
$4800524c constant VENC_VENC_SWREG147  \ offset: 0x24C : VENC DMV qpel penalty values register
$48005250 constant VENC_VENC_SWREG148  \ offset: 0x250 : VENC DMV qpel penalty values register
$48005254 constant VENC_VENC_SWREG149  \ offset: 0x254 : VENC DMV qpel penalty values register
$48005258 constant VENC_VENC_SWREG150  \ offset: 0x258 : VENC DMV qpel penalty values register
$4800525c constant VENC_VENC_SWREG151  \ offset: 0x25C : VENC DMV qpel penalty values register
$48005260 constant VENC_VENC_SWREG152  \ offset: 0x260 : VENC DMV qpel penalty values register
$48005264 constant VENC_VENC_SWREG153  \ offset: 0x264 : VENC DMV qpel penalty values register
$48005268 constant VENC_VENC_SWREG154  \ offset: 0x268 : VENC DMV qpel penalty values register
$4800526c constant VENC_VENC_SWREG155  \ offset: 0x26C : VENC DMV qpel penalty values register
$48005270 constant VENC_VENC_SWREG156  \ offset: 0x270 : VENC DMV qpel penalty values register
$48005274 constant VENC_VENC_SWREG157  \ offset: 0x274 : VENC DMV qpel penalty values register
$48005278 constant VENC_VENC_SWREG158  \ offset: 0x278 : VENC DMV qpel penalty values register
$4800527c constant VENC_VENC_SWREG159  \ offset: 0x27C : VENC DMV qpel penalty values 124-127 register
$4800539c constant VENC_VENC_SWREG231  \ offset: 0x39C : VENC base address for output of down-scaled encoder image in YUYV 4:2:2 format register
$480053a0 constant VENC_VENC_SWREG232  \ offset: 0x3A0 : VENC scaling control register
$480053a4 constant VENC_VENC_SWREG233  \ offset: 0x3A4 : VENC scaling control register
$480053b0 constant VENC_VENC_SWREG236  \ offset: 0x3B0 : VENC squared error output calculated for 13x13 pixels per macroblock register
$480053b4 constant VENC_VENC_SWREG237  \ offset: 0x3B4 : VENC MAD 2 control and output register
$480053b8 constant VENC_VENC_SWREG238  \ offset: 0x3B8 : VENC MAD 3 control and output register
$48005400 constant VENC_VENC_SWREG256  \ offset: 0x400 : VENC segment 1: intra 16x16 mode 0-2 penalty register
$48005404 constant VENC_VENC_SWREG257  \ offset: 0x404 : VENC segment 1: intra 16x16 mode 3, intra 4x4 0-1 penalty register
$48005408 constant VENC_VENC_SWREG258  \ offset: 0x408 : VENC segment 1: intra 4x4 mode 2-4 penalty register
$4800540c constant VENC_VENC_SWREG259  \ offset: 0x40C : VENC segment 1: intra 4x4 mode 5-7 penalty register
$48005410 constant VENC_VENC_SWREG260  \ offset: 0x410 : VENC segment 1: intra 4x4 mode 8-9 penalty, previous mode favor for H.264 register
$48005414 constant VENC_VENC_SWREG261  \ offset: 0x414 : VENC segment 1: bit cost of inter type, intra 16x16 mode favor register
$48005418 constant VENC_VENC_SWREG262  \ offset: 0x418 : VENC segment 1: inter MB mode favor, skip mode penalty, penalty value for 2nd reference frame register
$4800541c constant VENC_VENC_SWREG263  \ offset: 0x41C : VENC segment 1: penalty value register
$48005420 constant VENC_VENC_SWREG264  \ offset: 0x420 : VENC segment 1: penalty value register
$48005424 constant VENC_VENC_SWREG265  \ offset: 0x424 : VENC segment 1: deadzone rate multiplier for plane 0-1 register
$48005428 constant VENC_VENC_SWREG266  \ offset: 0x428 : VENC segment 1: deadzone rate multiplier for plane 2-3 register
$4800542c constant VENC_VENC_SWREG267  \ offset: 0x42C : VENC segment 1: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
$48005430 constant VENC_VENC_SWREG268  \ offset: 0x430 : VENC segment 2: intra 16x16 mode 0-2 penalty register
$48005434 constant VENC_VENC_SWREG269  \ offset: 0x434 : VENC segment 2: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty register
$48005438 constant VENC_VENC_SWREG270  \ offset: 0x438 : VENC segment 2: intra 4x4 mode 2-4 penalty register
$4800543c constant VENC_VENC_SWREG271  \ offset: 0x43C : VENC segment 2: intra 4x4 mode 5-7 penalty register
$48005440 constant VENC_VENC_SWREG272  \ offset: 0x440 : VENC segment 2: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 register
$48005444 constant VENC_VENC_SWREG273  \ offset: 0x444 : VENC segment 2: bit cost of inter type, intra 16x16 mode favor register
$48005448 constant VENC_VENC_SWREG274  \ offset: 0x448 : VENC segment 2: inter MB mode favor, skip mode penalty, penalty value register
$4800544c constant VENC_VENC_SWREG275  \ offset: 0x44C : VENC segment 2: penalty value register
$48005450 constant VENC_VENC_SWREG276  \ offset: 0x450 : VENC segment 2: penalty value register
$48005454 constant VENC_VENC_SWREG277  \ offset: 0x454 : VENC segment 2: deadzone rate multiplier for plane 0-1 register
$48005458 constant VENC_VENC_SWREG278  \ offset: 0x458 : VENC segment 2: deadzone rate multiplier for plane 2-3 register
$4800545c constant VENC_VENC_SWREG279  \ offset: 0x45C : VENC segment 2: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
$48005460 constant VENC_VENC_SWREG280  \ offset: 0x460 : VENC segment 3: intra 16x16 mode 0-2 penalty register
$48005464 constant VENC_VENC_SWREG281  \ offset: 0x464 : VENC segment 3: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty register
$48005468 constant VENC_VENC_SWREG282  \ offset: 0x468 : VENC segment 3: intra 4x4 mode 2-4 penalty register
$4800546c constant VENC_VENC_SWREG283  \ offset: 0x46C : VENC segment 3: intra 4x4 mode 5-7 penalty register
$48005470 constant VENC_VENC_SWREG284  \ offset: 0x470 : VENC segment 3: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 register
$48005474 constant VENC_VENC_SWREG285  \ offset: 0x474 : VENC segment 3: bit cost of inter type, intra 16x16 mode favor register
$48005478 constant VENC_VENC_SWREG286  \ offset: 0x478 : VENC segment 3: inter MB mode favor in intra/inter selection, inter MB mode favor, penalty value for second reference frame register
$4800547c constant VENC_VENC_SWREG287  \ offset: 0x47C : VENC segment 3: penalty value register
$48005480 constant VENC_VENC_SWREG288  \ offset: 0x480 : VENC segment 3: penalty value register
$48005484 constant VENC_VENC_SWREG289  \ offset: 0x484 : VENC segment 3: deadzone rate multiplier for plane 0-1 register
$48005488 constant VENC_VENC_SWREG290  \ offset: 0x488 : VENC segment 3: deadzone rate multiplier for plane 2-3 register
$4800548c constant VENC_VENC_SWREG291  \ offset: 0x48C : VENC segment 3: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
$48005498 constant VENC_VENC_SWREG294  \ offset: 0x498 : VENC Mb boost register
$4800549c constant VENC_VENC_SWREG295  \ offset: 0x49C : VENC variance control, Pskop conding mode register
$480054a0 constant VENC_VENC_SWREG296  \ offset: 0x4A0 : VENC synthesis configuration register encoder 1 read only register
$480054a4 constant VENC_VENC_SWREG297  \ offset: 0x4A4 : VENC MBRC control register
$480054a8 constant VENC_VENC_SWREG298  \ offset: 0x4A8 : VENC segment 4: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480054ac constant VENC_VENC_SWREG299  \ offset: 0x4AC : VENC segment 4: skip mode penalty, inter MB mode favor register
$480054b0 constant VENC_VENC_SWREG300  \ offset: 0x4B0 : VENC segment 4: penalty value register
$480054b4 constant VENC_VENC_SWREG301  \ offset: 0x4B4 : VENC segment 4: penalty value register
$480054b8 constant VENC_VENC_SWREG302  \ offset: 0x4B8 : VENC segment 5: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480054bc constant VENC_VENC_SWREG303  \ offset: 0x4BC : VENC segment 5: skip mode penalty, inter MB mode favor register
$480054c0 constant VENC_VENC_SWREG304  \ offset: 0x4C0 : VENC segment 5: penalty value register
$480054c4 constant VENC_VENC_SWREG305  \ offset: 0x4C4 : VENC segment 5: penalty value register
$480054c8 constant VENC_VENC_SWREG306  \ offset: 0x4C8 : VENC segment 6: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480054cc constant VENC_VENC_SWREG307  \ offset: 0x4CC : VENC segment 6: skip mode penalty, inter MB mode favor register
$480054d0 constant VENC_VENC_SWREG308  \ offset: 0x4D0 : VENC segment 6: penalty value register
$480054d4 constant VENC_VENC_SWREG309  \ offset: 0x4D4 : VENC segment 6: penalty value register
$480054d8 constant VENC_VENC_SWREG310  \ offset: 0x4D8 : VENC segment 7: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480054dc constant VENC_VENC_SWREG311  \ offset: 0x4DC : VENC segment 7: skip mode penalty, inter MB mode favor register
$480054e0 constant VENC_VENC_SWREG312  \ offset: 0x4E0 : VENC segment 7: penalty value register
$480054e4 constant VENC_VENC_SWREG313  \ offset: 0x4E4 : VENC segment 7: penalty value register
$480054e8 constant VENC_VENC_SWREG314  \ offset: 0x4E8 : VENC segment 8: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480054ec constant VENC_VENC_SWREG315  \ offset: 0x4EC : VENC segment 8: skip mode penalty, inter MB mode favor register
$480054f0 constant VENC_VENC_SWREG316  \ offset: 0x4F0 : VENC segment 8: penalty value register
$480054f4 constant VENC_VENC_SWREG317  \ offset: 0x4F4 : VENC segment 8: penalty value register
$480054f8 constant VENC_VENC_SWREG318  \ offset: 0x4F8 : VENC segment 9: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480054fc constant VENC_VENC_SWREG319  \ offset: 0x4FC : VENC segment 9: skip mode penalty, inter MB mode favor register
$48005500 constant VENC_VENC_SWREG320  \ offset: 0x500 : VENC segment 9: penalty value register
$48005504 constant VENC_VENC_SWREG321  \ offset: 0x504 : VENC segment 9: penalty value register
$48005508 constant VENC_VENC_SWREG322  \ offset: 0x508 : VENC segment 10: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800550c constant VENC_VENC_SWREG323  \ offset: 0x50C : VENC segment 10: skip mode penalty, inter MB mode favor register
$48005510 constant VENC_VENC_SWREG324  \ offset: 0x510 : VENC segment 10: penalty value register
$48005514 constant VENC_VENC_SWREG325  \ offset: 0x514 : VENC segment 10: penalty value register
$48005518 constant VENC_VENC_SWREG326  \ offset: 0x518 : VENC segment 11: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800551c constant VENC_VENC_SWREG327  \ offset: 0x51C : VENC segment 11: skip mode penalty, inter MB mode favor register
$48005520 constant VENC_VENC_SWREG328  \ offset: 0x520 : VENC segment 11: penalty value register
$48005524 constant VENC_VENC_SWREG329  \ offset: 0x524 : VENC segment 11: penalty value register
$48005528 constant VENC_VENC_SWREG330  \ offset: 0x528 : VENC segment 12: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800552c constant VENC_VENC_SWREG331  \ offset: 0x52C : VENC segment 12: skip mode penalty, inter MB mode favor register
$48005530 constant VENC_VENC_SWREG332  \ offset: 0x530 : VENC segment 12: penalty value register
$48005534 constant VENC_VENC_SWREG333  \ offset: 0x534 : VENC segment 12: penalty value register
$48005538 constant VENC_VENC_SWREG334  \ offset: 0x538 : VENC segment 13: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800553c constant VENC_VENC_SWREG335  \ offset: 0x53C : VENC segment 13: skip mode penalty, inter MB mode favor register
$48005540 constant VENC_VENC_SWREG336  \ offset: 0x540 : VENC segment 13: penalty value register
$48005544 constant VENC_VENC_SWREG337  \ offset: 0x544 : VENC segment 13: penalty value register
$48005548 constant VENC_VENC_SWREG338  \ offset: 0x548 : VENC segment 14: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800554c constant VENC_VENC_SWREG339  \ offset: 0x54C : VENC segment 14: skip mode penalty, inter MB mode favor register
$48005550 constant VENC_VENC_SWREG340  \ offset: 0x550 : VENC segment 14: penalty value register
$48005554 constant VENC_VENC_SWREG341  \ offset: 0x554 : VENC segment 14: penalty value register
$48005558 constant VENC_VENC_SWREG342  \ offset: 0x558 : VENC segment 15: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800555c constant VENC_VENC_SWREG343  \ offset: 0x55C : VENC segment 15: skip mode penalty, inter MB mode favor register
$48005560 constant VENC_VENC_SWREG344  \ offset: 0x560 : VENC segment 15: penalty value register
$48005564 constant VENC_VENC_SWREG345  \ offset: 0x564 : VENC segment 15: penalty value register
$48005568 constant VENC_VENC_SWREG346  \ offset: 0x568 : VENC segment 16: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800556c constant VENC_VENC_SWREG347  \ offset: 0x56C : VENC segment 16: skip mode penalty, inter MB mode favor register
$48005570 constant VENC_VENC_SWREG348  \ offset: 0x570 : VENC segment 16: penalty value register
$48005574 constant VENC_VENC_SWREG349  \ offset: 0x574 : VENC segment 16: penalty value register
$48005578 constant VENC_VENC_SWREG350  \ offset: 0x578 : VENC segment 17: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800557c constant VENC_VENC_SWREG351  \ offset: 0x57C : VENC segment 17: skip mode penalty, inter MB mode favor register
$48005580 constant VENC_VENC_SWREG352  \ offset: 0x580 : VENC segment 17: penalty value register
$48005584 constant VENC_VENC_SWREG353  \ offset: 0x584 : VENC segment 17: penalty value register
$48005588 constant VENC_VENC_SWREG354  \ offset: 0x588 : VENC segment 18: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800558c constant VENC_VENC_SWREG355  \ offset: 0x58C : VENC segment 18: skip mode penalty, inter MB mode favor register
$48005590 constant VENC_VENC_SWREG356  \ offset: 0x590 : VENC segment 18: penalty value register
$48005594 constant VENC_VENC_SWREG357  \ offset: 0x594 : VENC segment 18: penalty value register
$48005598 constant VENC_VENC_SWREG358  \ offset: 0x598 : VENC segment 19: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800559c constant VENC_VENC_SWREG359  \ offset: 0x59C : VENC segment 19: skip mode penalty, inter MB mode favor register
$480055a0 constant VENC_VENC_SWREG360  \ offset: 0x5A0 : VENC segment 19: penalty value register
$480055a4 constant VENC_VENC_SWREG361  \ offset: 0x5A4 : VENC segment 19: penalty value register
$480055a8 constant VENC_VENC_SWREG362  \ offset: 0x5A8 : VENC segment 20: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480055ac constant VENC_VENC_SWREG363  \ offset: 0x5AC : VENC segment 20: skip mode penalty, inter MB mode favor register
$480055b0 constant VENC_VENC_SWREG364  \ offset: 0x5B0 : VENC segment 20: penalty value register
$480055b4 constant VENC_VENC_SWREG365  \ offset: 0x5B4 : VENC segment 20: penalty value register
$480055b8 constant VENC_VENC_SWREG366  \ offset: 0x5B8 : VENC segment 21: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480055bc constant VENC_VENC_SWREG367  \ offset: 0x5BC : VENC segment 21: skip mode penalty, inter MB mode favor register
$480055c0 constant VENC_VENC_SWREG368  \ offset: 0x5C0 : VENC segment 21: penalty value register
$480055c4 constant VENC_VENC_SWREG369  \ offset: 0x5C4 : VENC segment 21: penalty value register
$480055c8 constant VENC_VENC_SWREG370  \ offset: 0x5C8 : VENC segment 22: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480055cc constant VENC_VENC_SWREG371  \ offset: 0x5CC : VENC segment 22: skip mode penalty, inter MB mode favor register
$480055d0 constant VENC_VENC_SWREG372  \ offset: 0x5D0 : VENC segment 22: penalty value register
$480055d4 constant VENC_VENC_SWREG373  \ offset: 0x5D4 : VENC segment 22: penalty value register
$480055d8 constant VENC_VENC_SWREG374  \ offset: 0x5D8 : VENC segment 23: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480055dc constant VENC_VENC_SWREG375  \ offset: 0x5DC : VENC segment 23: skip mode penalty, inter MB mode favor register
$480055e0 constant VENC_VENC_SWREG376  \ offset: 0x5E0 : VENC segment 23: penalty value register
$480055e4 constant VENC_VENC_SWREG377  \ offset: 0x5E4 : VENC segment 23: penalty value register
$480055e8 constant VENC_VENC_SWREG378  \ offset: 0x5E8 : VENC segment 24: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480055ec constant VENC_VENC_SWREG379  \ offset: 0x5EC : VENC segment 24: skip mode penalty, inter MB mode favor register
$480055f0 constant VENC_VENC_SWREG380  \ offset: 0x5F0 : VENC segment 24: penalty value register
$480055f4 constant VENC_VENC_SWREG381  \ offset: 0x5F4 : VENC segment 24: penalty value register
$480055f8 constant VENC_VENC_SWREG382  \ offset: 0x5F8 : VENC segment 25: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$480055fc constant VENC_VENC_SWREG383  \ offset: 0x5FC : VENC segment 25: skip mode penalty, inter MB mode favor register
$48005600 constant VENC_VENC_SWREG384  \ offset: 0x600 : VENC segment 25: penalty value register
$48005604 constant VENC_VENC_SWREG385  \ offset: 0x604 : VENC segment 25: penalty value register
$48005608 constant VENC_VENC_SWREG386  \ offset: 0x608 : VENC segment 26: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800560c constant VENC_VENC_SWREG387  \ offset: 0x60C : VENC segment 26: skip mode penalty, inter MB mode favor register
$48005610 constant VENC_VENC_SWREG388  \ offset: 0x610 : VENC segment 26: penalty value register
$48005614 constant VENC_VENC_SWREG389  \ offset: 0x614 : VENC segment 26: penalty value register
$48005618 constant VENC_VENC_SWREG390  \ offset: 0x618 : VENC segment 27: intra 4x4 previous mode favor, intra 16x16mode favor, penalty value for second reference frame register
$4800561c constant VENC_VENC_SWREG391  \ offset: 0x61C : VENC segment 27: skip mode penalty, inter MB mode favor register
$48005620 constant VENC_VENC_SWREG392  \ offset: 0x620 : VENC segment 27: penalty value register
$48005624 constant VENC_VENC_SWREG393  \ offset: 0x624 : VENC segment 27: penalty value register
$48005628 constant VENC_VENC_SWREG394  \ offset: 0x628 : VENC segment 28: intra 4x4 previous mode favor, intra 16x16mode favor, penalty value for second reference frame register
$4800562c constant VENC_VENC_SWREG395  \ offset: 0x62C : VENC segment 28: skip mode penalty, inter MB mode favor register
$48005630 constant VENC_VENC_SWREG396  \ offset: 0x630 : VENC segment 28: penalty value register
$48005634 constant VENC_VENC_SWREG397  \ offset: 0x634 : VENC segment 28: penalty value register
$48005638 constant VENC_VENC_SWREG398  \ offset: 0x638 : VENC segment 29: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800563c constant VENC_VENC_SWREG399  \ offset: 0x63C : VENC segment 29: skip mode penalty, inter MB mode favor register
$48005640 constant VENC_VENC_SWREG400  \ offset: 0x640 : VENC segment 29: penalty value register
$48005644 constant VENC_VENC_SWREG401  \ offset: 0x644 : VENC segment 29: penalty value register
$48005648 constant VENC_VENC_SWREG402  \ offset: 0x648 : VENC segment 30: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800564c constant VENC_VENC_SWREG403  \ offset: 0x64C : VENC segment 30: skip mode penalty, inter MB mode favor register
$48005650 constant VENC_VENC_SWREG404  \ offset: 0x650 : VENC segment 30: penalty value register
$48005654 constant VENC_VENC_SWREG405  \ offset: 0x654 : VENC segment 30: penalty value register
$48005658 constant VENC_VENC_SWREG406  \ offset: 0x658 : VENC segment 31: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
$4800565c constant VENC_VENC_SWREG407  \ offset: 0x65C : VENC segment 31: skip mode penalty, inter MB mode favor register
$48005660 constant VENC_VENC_SWREG408  \ offset: 0x660 : VENC segment 31: penalty value register
$48005664 constant VENC_VENC_SWREG409  \ offset: 0x664 : VENC segment 31: penalty value register
$48005668 constant VENC_VENC_SWREG410  \ offset: 0x668 : VENC MBRC control, QP, offset, enable register
$4800566c constant VENC_VENC_SWREG411  \ offset: 0x66C : VENC gain of MB QP delta. 8.8 format register
$48005670 constant VENC_VENC_SWREG412  \ offset: 0x670 : VENC average of MB complexity register
$48005674 constant VENC_VENC_SWREG413  \ offset: 0x674 : VENC reference compression control register
$48005678 constant VENC_VENC_SWREG414  \ offset: 0x678 : VENC base address for reference luma register
$4800567c constant VENC_VENC_SWREG415  \ offset: 0x67C : VENC base address for reference chroma register
$48005680 constant VENC_VENC_SWREG416  \ offset: 0x680 : VENC base address for reconstructed luma register
$48005684 constant VENC_VENC_SWREG417  \ offset: 0x684 : VENC base address for reconstructed chroma register
$48005688 constant VENC_VENC_SWREG418  \ offset: 0x688 : VENC base address for second reference luma register
$4800568c constant VENC_VENC_SWREG419  \ offset: 0x68C : VENC base address for second reference chroma register
$48005690 constant VENC_VENC_SWREG420  \ offset: 0x690 : VENC limit of chroma RFC buffer register
$48005694 constant VENC_VENC_SWREG421  \ offset: 0x694 : VENC reorder control register
$48005698 constant VENC_VENC_SWREG422  \ offset: 0x698 : VENC AXI read ID register
$4800569c constant VENC_VENC_SWREG423  \ offset: 0x69C : VENC base address MSB for reference luma compression table register
$480056a0 constant VENC_VENC_SWREG424  \ offset: 0x6A0 : VENC base address MSB for reference chroma compression table register
$480056a4 constant VENC_VENC_SWREG425  \ offset: 0x6A4 : VENC base address MSB for reconstructed luma compression table register
$480056a8 constant VENC_VENC_SWREG426  \ offset: 0x6A8 : VENC base address for reconstructed chroma compression table register
$480056ac constant VENC_VENC_SWREG427  \ offset: 0x6AC : VENC base address MSB for second reference luma compression table register
$480056b0 constant VENC_VENC_SWREG428  \ offset: 0x6B0 : VENC base address MSB for second reference chroma compression table register
$480056b4 constant VENC_VENC_SWREG429  \ offset: 0x6B4 : VENC high 32 bits of base address for output stream data register
$480056b8 constant VENC_VENC_SWREG430  \ offset: 0x6B8 : VENC high 32 bits of base address for output control data register
$480056bc constant VENC_VENC_SWREG431  \ offset: 0x6BC : VENC high 32 bits of base address for reference luma register
$480056c0 constant VENC_VENC_SWREG432  \ offset: 0x6C0 : VENC high 32 bits of base address for reference chroma register
$480056c4 constant VENC_VENC_SWREG433  \ offset: 0x6C4 : VENC high 32 bits of base address for reconstructed luma register
$480056c8 constant VENC_VENC_SWREG434  \ offset: 0x6C8 : VENC high 32 bits of base address for reconstructed chroma register
$480056cc constant VENC_VENC_SWREG435  \ offset: 0x6CC : VENC high 32 bits of base address for input picture luma register
$480056d0 constant VENC_VENC_SWREG436  \ offset: 0x6D0 : VENC high 32 bits of base address for input picture cb register
$480056d4 constant VENC_VENC_SWREG437  \ offset: 0x6D4 : VENC high 32 bits of base address for input picture cr register
$480056d8 constant VENC_VENC_SWREG438  \ offset: 0x6D8 : VENC high 32 bits of base address for second reference luma register
$480056dc constant VENC_VENC_SWREG439  \ offset: 0x6DC : VENC high 32 bits of base address for second reference chroma register
$480056e0 constant VENC_VENC_SWREG440  \ offset: 0x6E0 : VENC high 32 bits of H264 secondary ref pic base register
$480056e4 constant VENC_VENC_SWREG441  \ offset: 0x6E4 : VENC high 32 bits of H264 secondary ref pic base register
$480056e8 constant VENC_VENC_SWREG442  \ offset: 0x6E8 : VENC high 32 bits of base address for next pic luminance register
$480056ec constant VENC_VENC_SWREG443  \ offset: 0x6EC : VENC high 32 bits of base address for cabac context tables H264 register
$480056f0 constant VENC_VENC_SWREG444  \ offset: 0x6F0 : VENC high 32 bits of base address for MV output writing register
$48005704 constant VENC_VENC_SWREG449  \ offset: 0x704 : VENC high 32 bits of base address for output of down-scaled encoder image in YUYV 4:2:2 format register
$480057c4 constant VENC_VENC_SWREG497  \ offset: 0x7C4 : VENC low-latency control register
$480057c8 constant VENC_VENC_SWREG498  \ offset: 0x7C8 : VENC encoder line buffer offset register

