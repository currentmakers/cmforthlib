\
\ @file venc.fs
\ @brief Video encoder
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] VENC_DEF

  [ifdef] VENC_VENC_SWREG0_DEF
    \
    \ @brief VENC ID register
    \ Address offset: 0x00
    \ Reset value: 0x6E654000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Interrupt register (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG1_DEF
    \
    \ @brief VENC interrupt register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Interrupt register (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG2_DEF
    \
    \ @brief VENC bus interface configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000010
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Bus interface configuration register (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG3_DEF
    \
    \ @brief VENC device configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Device configuration register (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG5_DEF
    \
    \ @brief VENC base address for output stream data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for output stream data (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG6_DEF
    \
    \ @brief VENC base address for output control data register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for output control data (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG7_DEF
    \
    \ @brief VENC base address for reference luma register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for reference luma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG8_DEF
    \
    \ @brief VENC base address for reference chroma register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for reference chroma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG9_DEF
    \
    \ @brief VENC base address for reconstructed luma register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for reconstructed luma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG10_DEF
    \
    \ @brief VENC base address for reconstructed chroma register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for reconstructed chroma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG11_DEF
    \
    \ @brief VENC base address for input picture luma register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for input picture luma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG12_DEF
    \
    \ @brief VENC base address for input picture cb register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for input picture cb (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG13_DEF
    \
    \ @brief VENC base address for input picture cr register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for input picture cr (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG14_DEF
    \
    \ @brief VENC encoder control register 0
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Encoder control register 0 (such as picture information or encoding mode) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG15_DEF
    \
    \ @brief VENC encoder control register 1
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Encoder control register 1 (such as preprocessing control, crop, rotate, input format) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG16_DEF
    \
    \ @brief VENC encoder control register 2
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for second reference luma (H264 control) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG17_DEF
    \
    \ @brief VENC encoder control register 3
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for second reference chroma (H264 control) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG18_DEF
    \
    \ @brief VENC encoder control register 4
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Encoder control register 4 (deblock filter mode, H264 control) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG19_DEF
    \
    \ @brief VENC encoder control register 5
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Encoder control register 5 (input format, motion vector etc) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG20_DEF
    \
    \ @brief VENC encoder control register 6
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Control of data JPEG (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG21_DEF
    \
    \ @brief VENC encoder control register 7
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Control of H264 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG22_DEF
    \
    \ @brief VENC stream header remainder MSB bits register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stream header remainder bits MSB (MSB aligned) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG23_DEF
    \
    \ @brief VENC stream header remainder LSB bits register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stream header remainder bits LSB (MSB aligned) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG24_DEF
    \
    \ @brief VENC stream buffer limit/output stream size register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stream buffer limit (64-bit addresses)/output stream size (bits) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG25_DEF
    \
    \ @brief VENC encoder control register 8
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Control of MAD control and QP sum output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG26_DEF
    \
    \ @brief VENC intra-slice bitmap register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] intra-slice bitmap for probability updates (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG27_DEF
    \
    \ @brief VENC encoder control register 9
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Control of H264 QP (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG28_DEF
    \
    \ @brief VENC encoder control register 10
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] H264 checkpoint 1-2 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG29_DEF
    \
    \ @brief VENC encoder control register 11
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] H.264 Checkpoint 3 -4 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG30_DEF
    \
    \ @brief VENC encoder control register 12
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] H.264 checkpoint 5 -6 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG31_DEF
    \
    \ @brief VENC encoder control register 13
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] H.264 checkpoint 7 -8 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG32_DEF
    \
    \ @brief VENC encoder control register 14
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] H.264 Checkpoint 8 -10 / Encoder control register 14 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG33_DEF
    \
    \ @brief VENC encoder control register 15
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] H.264 Checkpoint word error 1-2 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG34_DEF
    \
    \ @brief VENC encoder control register 16
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] H.264 checkpoint word error 3-4 and the second reference frame control (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG35_DEF
    \
    \ @brief VENC H.264 checkpoint word error 5-6/encoder control register 17
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] H.264 Checkpoint word error 5-6 / Encoder control register 17 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG36_DEF
    \
    \ @brief VENC H.264 checkpoint delta QP 1-8/encoder control register 18
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] H.264 Checkpoint delta QP 1-8 / Encoder control register 18 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG37_DEF
    \
    \ @brief VENC encoder control register 19, stream start offset
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Encoder control register 19 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG38_DEF
    \
    \ @brief VENC macroblock count output register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Macroblock count output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG39_DEF
    \
    \ @brief VENC base address for next pic luminance register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for next pic luminance (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG40_DEF
    \
    \ @brief VENC stabilization mode control register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization mode control (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG41_DEF
    \
    \ @brief VENC stabilization motion sum div8 output register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization motion sum div8 output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG42_DEF
    \
    \ @brief VENC stabilization GMV output, matrix 1, up-left position output register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization GMV output, matrix 1 (up-left position) output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG43_DEF
    \
    \ @brief VENC stabilization GMV output, matrix 2, up position output register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization GMV output, matrix 2 (up position) output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG44_DEF
    \
    \ @brief VENC stabilization matrix 3, up-right position output register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization matrix 3 (up-right position) output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG45_DEF
    \
    \ @brief VENC stabilization matrix 4, left position output register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization matrix 4 (left position) output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG46_DEF
    \
    \ @brief VENC stabilization matrix 5, GMV position output register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization matrix 5 (GMV position) output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG47_DEF
    \
    \ @brief VENC stabilization matrix 6, right position output register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization matrix 6 (right position) output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG48_DEF
    \
    \ @brief VENC stabilization matrix 7, down-left position output register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization matrix 7 (down-left position) output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG49_DEF
    \
    \ @brief VENC stabilization matrix 8, down position output register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization matrix 8 (down position) output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG50_DEF
    \
    \ @brief VENC stabilization matrix 9, down-right position output register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Stabilization matrix 9 (down-right position) output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG51_DEF
    \
    \ @brief VENC base address for cabac context tables H264 register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for cabac context tables (H264) or probability tables (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG52_DEF
    \
    \ @brief VENC base address for MV output writing register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for MV output writing (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG53_DEF
    \
    \ @brief VENC RGB to YUV conversion coefficient A - B register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] RGB to YUV conversion coefficient A - B (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG54_DEF
    \
    \ @brief VENC RGB to YUV conversion coefficient C - E register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] RGB to YUV conversion coefficient C - E (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG55_DEF
    \
    \ @brief VENC RGB to YUV conversion coefficient F, RGB mask MSB bit position register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] RGB to YUV conversion coefficient F, RGB mask MSB bit position (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG56_DEF
    \
    \ @brief VENC intra area register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] intra area (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG57_DEF
    \
    \ @brief VENC CIR intra mb position register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] CIR intra mb position (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG58_DEF
    \
    \ @brief VENC intra slice bitmap for slices 0..31/base address for 1st DCT partition register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] intra slice bitmap for slices 0..31 / Base address for 1st DCT partition (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG59_DEF
    \
    \ @brief VENC intra slice bitmap for slices 32..63/base address for 2nd DCT partition register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] intra slice bitmap for slices 32..63 / Base address for 2nd DCT partition (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG60_DEF
    \
    \ @brief VENC 1st ROI area register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] 1st ROI area (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG61_DEF
    \
    \ @brief VENC 2nd ROI area register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] 2nd ROI area (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG62_DEF
    \
    \ @brief VENC ROI area delta QP, MV register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] ROI area delta QP, MV (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG63_DEF
    \
    \ @brief VENC synthesis configuration register encoder 0 register
    \ Address offset: 0xFC
    \ Reset value: 0x1E622780
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Synthesis configuration register encoder 0 (read only) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG64_DEF
    \
    \ @brief VENC JPEG luma quantization 1/intra 16x16 mode 0-1 penalty register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 1 / intra 16x16 mode 0-1 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG65_DEF
    \
    \ @brief VENC JPEG luma quantization 2/intra 16x16 mode 2-3 penalty register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 2 / intra 16x16 mode 2-3 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG66_DEF
    \
    \ @brief VENC JPEG luma quantization 3/intra 4x4 mode 0-1 penalty register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 3 / intra 4x4 mode 0-1 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG67_DEF
    \
    \ @brief VENC JPEG luma quantization 4/intra 4x4 mode 2-3 penalty register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 4 / intra 4x4 mode 2-3 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG68_DEF
    \
    \ @brief VENC JPEG luma quantization 5/intra 4x4 mode 4-5 penalty register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 5 / intra 4x4 mode 4-5 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG69_DEF
    \
    \ @brief VENC JPEG luma quantization 6/intra 4x4 mode 6-7 penalty register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 6 / intra 4x4 mode 6-7 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG70_DEF
    \
    \ @brief VENC JPEG luma quantization 7/intra 4x4 mode 8-9 penalty register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 7 / intra 4x4 mode 8-9 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG71_DEF
    \
    \ @brief VENC JPEG luma quantization 8/base address for segmentation map register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 8 / Base address for segmentation map (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG72_DEF
    \
    \ @brief VENC JPEG luma quantization 9/segment1 parameter register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 9 / segment1 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG73_DEF
    \
    \ @brief VENC JPEG luma quantization 10/segment1 parameter register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 10 / segment1 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG74_DEF
    \
    \ @brief VENC JPEG luma quantization 11/segment1 parameter register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 11 / segment1 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG75_DEF
    \
    \ @brief VENC JPEG luma quantization 12/segment1 parameter register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 12 / segment1 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG76_DEF
    \
    \ @brief VENC JPEG luma quantization 13/segment1 parameter register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 13 / segment1 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG77_DEF
    \
    \ @brief VENC JPEG luma quantization 14/segment1 parameter register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 14 / segment1 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG78_DEF
    \
    \ @brief VENC JPEG luma quantization 15/segment1 parameter register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 15 / segment1 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG79_DEF
    \
    \ @brief VENC JPEG luma quantization 16/segment2 parameter register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG luma quantization 16 / segment2 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG80_DEF
    \
    \ @brief VENC JPEG chroma quantization 1/segment2 parameter register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 1 / segment2 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG81_DEF
    \
    \ @brief VENC JPEG chroma quantization 2/segment2 parameter register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 2 / segment2 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG82_DEF
    \
    \ @brief VENC JPEG chroma quantization 3/segment2 parameter register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 3 / segment2 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG83_DEF
    \
    \ @brief VENC JPEG chroma quantization 4/segment2 parameter register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 4 / segment2 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG84_DEF
    \
    \ @brief VENC JPEG chroma quantization 5/segment2 parameter register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 5 / segment2 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG85_DEF
    \
    \ @brief VENC JPEG chroma quantization 6/segment2 parameter register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 6 / segment2 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG86_DEF
    \
    \ @brief VENC JPEG chroma quantization 7/segment2 parameter register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 7 / segment2 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG87_DEF
    \
    \ @brief VENC JPEG chroma quantization 8/segment2 parameter register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 8 / segment2 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG88_DEF
    \
    \ @brief VENC JPEG chroma quantization 9/segment3 parameter register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 9 / segment3 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG89_DEF
    \
    \ @brief VENC JPEG chroma quantization 10/segment3 parameter register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 10 / segment3 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG90_DEF
    \
    \ @brief VENC JPEG chroma quantization 11/segment3 parameter register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 11 / segment3 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG91_DEF
    \
    \ @brief VENC JPEG chroma quantization 12/segment3 parameter register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 12 / segment3 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG92_DEF
    \
    \ @brief VENC JPEG chroma quantization 13/segment3 parameter register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 13 / segment3 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG93_DEF
    \
    \ @brief VENC JPEG chroma quantization 14/segment3 parameter register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 14 / segment3 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG94_DEF
    \
    \ @brief VENC JPEG chroma quantization 15/segment3 parameter register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 15 / segment3 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG95_DEF
    \
    \ @brief VENC JPEG chroma quantization 16/segment3 parameter register
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] JPEG chroma quantization 16 / segment3 parameter (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG96_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values 0-3 register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values 0-3 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG97_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values 4-7 register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values 4-7 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG98_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG99_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG100_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG101_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG102_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG103_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG104_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG105_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG106_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG107_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG108_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG109_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG110_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG111_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG112_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG113_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG114_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG115_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG116_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG117_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG118_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1D8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG119_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG120_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG121_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG122_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG123_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG124_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG125_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG126_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values register
    \ Address offset: 0x1F8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG127_DEF
    \
    \ @brief VENC DMV 4p/1p penalty values 124-127 register
    \ Address offset: 0x1FC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV 4p/1p penalty values 124-127 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG128_DEF
    \
    \ @brief VENC DMV qpel penalty values 0-3 register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values 0-3 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG129_DEF
    \
    \ @brief VENC DMV qpel penalty values 4-7 register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values 4-7 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG130_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG131_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG132_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG133_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG134_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG135_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG136_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG137_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG138_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG139_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG140_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG141_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG142_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG143_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG144_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG145_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG146_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG147_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG148_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG149_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG150_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG151_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG152_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG153_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG154_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG155_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG156_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG157_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG158_DEF
    \
    \ @brief VENC DMV qpel penalty values register
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG159_DEF
    \
    \ @brief VENC DMV qpel penalty values 124-127 register
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] DMV qpel penalty values 124-127 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG231_DEF
    \
    \ @brief VENC base address for output of down-scaled encoder image in YUYV 4:2:2 format register
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for output of down-scaled encoder image in YUYV 4:2:2 format (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG232_DEF
    \
    \ @brief VENC scaling control register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Scaling control (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG233_DEF
    \
    \ @brief VENC scaling control register
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Scaling control (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG236_DEF
    \
    \ @brief VENC squared error output calculated for 13x13 pixels per macroblock register
    \ Address offset: 0x3B0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Squared error output calculated for 13x13 pixels per macroblock (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG237_DEF
    \
    \ @brief VENC MAD 2 control and output register
    \ Address offset: 0x3B4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] MAD 2 control and output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG238_DEF
    \
    \ @brief VENC MAD 3 control and output register
    \ Address offset: 0x3B8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] MAD 3 control and output (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG256_DEF
    \
    \ @brief VENC segment 1: intra 16x16 mode 0-2 penalty register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: intra 16x16 mode 0-2 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG257_DEF
    \
    \ @brief VENC segment 1: intra 16x16 mode 3, intra 4x4 0-1 penalty register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: intra 16x16 mode 3 and intra 4x4 0-1 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG258_DEF
    \
    \ @brief VENC segment 1: intra 4x4 mode 2-4 penalty register
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: intra 4x4 mode 2-4 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG259_DEF
    \
    \ @brief VENC segment 1: intra 4x4 mode 5-7 penalty register
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: intra 4x4 mode 5-7 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG260_DEF
    \
    \ @brief VENC segment 1: intra 4x4 mode 8-9 penalty, previous mode favor for H.264 register
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: intra 4x4 mode 8-9 penalty, previous mode favor for H.264 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG261_DEF
    \
    \ @brief VENC segment 1: bit cost of inter type, intra 16x16 mode favor register
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: Bit cost of inter type, intra 16x16 mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG262_DEF
    \
    \ @brief VENC segment 1: inter MB mode favor, skip mode penalty, penalty value for 2nd reference frame register
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: inter MB mode favor, skip mode penalty, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG263_DEF
    \
    \ @brief VENC segment 1: penalty value register
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG264_DEF
    \
    \ @brief VENC segment 1: penalty value register
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG265_DEF
    \
    \ @brief VENC segment 1: deadzone rate multiplier for plane 0-1 register
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: Deadzone rate multiplier for plane 0-1 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG266_DEF
    \
    \ @brief VENC segment 1: deadzone rate multiplier for plane 2-3 register
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: Deadzone rate multiplier for plane 2-3 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG267_DEF
    \
    \ @brief VENC segment 1: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
    \ Address offset: 0x42C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 1: Deadzone rate for macroblock skip token 0-1, dmv penalty coefficient (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG268_DEF
    \
    \ @brief VENC segment 2: intra 16x16 mode 0-2 penalty register
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: intra 16x16 mode 0-2 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG269_DEF
    \
    \ @brief VENC segment 2: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty register
    \ Address offset: 0x434
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG270_DEF
    \
    \ @brief VENC segment 2: intra 4x4 mode 2-4 penalty register
    \ Address offset: 0x438
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: intra 4x4 mode 2-4 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG271_DEF
    \
    \ @brief VENC segment 2: intra 4x4 mode 5-7 penalty register
    \ Address offset: 0x43C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: intra 4x4 mode 5-7 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG272_DEF
    \
    \ @brief VENC segment 2: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 register
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG273_DEF
    \
    \ @brief VENC segment 2: bit cost of inter type, intra 16x16 mode favor register
    \ Address offset: 0x444
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: Bit cost of inter type, intra 16x16 mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG274_DEF
    \
    \ @brief VENC segment 2: inter MB mode favor, skip mode penalty, penalty value register
    \ Address offset: 0x448
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: inter MB mode favor, skip mode penalty, panelty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG275_DEF
    \
    \ @brief VENC segment 2: penalty value register
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG276_DEF
    \
    \ @brief VENC segment 2: penalty value register
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG277_DEF
    \
    \ @brief VENC segment 2: deadzone rate multiplier for plane 0-1 register
    \ Address offset: 0x454
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: Deadzone rate multiplier for plane 0-1 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG278_DEF
    \
    \ @brief VENC segment 2: deadzone rate multiplier for plane 2-3 register
    \ Address offset: 0x458
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: Deadzone rate multiplier for plane 2-3 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG279_DEF
    \
    \ @brief VENC segment 2: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 2: Deadzone rate for macroblock skip token 0-1, dmv penalty coefficient (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG280_DEF
    \
    \ @brief VENC segment 3: intra 16x16 mode 0-2 penalty register
    \ Address offset: 0x460
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: intra 16x16 mode 0-2 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG281_DEF
    \
    \ @brief VENC segment 3: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty register
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG282_DEF
    \
    \ @brief VENC segment 3: intra 4x4 mode 2-4 penalty register
    \ Address offset: 0x468
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: intra 4x4 mode 2-4 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG283_DEF
    \
    \ @brief VENC segment 3: intra 4x4 mode 5-7 penalty register
    \ Address offset: 0x46C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: intra 4x4 mode 5-7 penalty (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG284_DEF
    \
    \ @brief VENC segment 3: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 register
    \ Address offset: 0x470
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG285_DEF
    \
    \ @brief VENC segment 3: bit cost of inter type, intra 16x16 mode favor register
    \ Address offset: 0x474
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: Bit cost of inter type, intra 16x16 mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG286_DEF
    \
    \ @brief VENC segment 3: inter MB mode favor in intra/inter selection, inter MB mode favor, penalty value for second reference frame register
    \ Address offset: 0x478
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: inter MB mode favor in intra/inter selection, inter MB mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG287_DEF
    \
    \ @brief VENC segment 3: penalty value register
    \ Address offset: 0x47C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG288_DEF
    \
    \ @brief VENC segment 3: penalty value register
    \ Address offset: 0x480
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG289_DEF
    \
    \ @brief VENC segment 3: deadzone rate multiplier for plane 0-1 register
    \ Address offset: 0x484
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: Deadzone rate multiplier for plane 0-1 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG290_DEF
    \
    \ @brief VENC segment 3: deadzone rate multiplier for plane 2-3 register
    \ Address offset: 0x488
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: Deadzone rate multiplier for plane 2-3 (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG291_DEF
    \
    \ @brief VENC segment 3: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
    \ Address offset: 0x48C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 3: Deadzone rate for macroblock skip token 0-1, dmv penalty coefficient (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG294_DEF
    \
    \ @brief VENC Mb boost register
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Mb boost (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG295_DEF
    \
    \ @brief VENC variance control, Pskop conding mode register
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Variance control, Pskop conding mode (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG296_DEF
    \
    \ @brief VENC synthesis configuration register encoder 1 read only register
    \ Address offset: 0x4A0
    \ Reset value: 0x06800000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Synthesis configuration register encoder 1 (read only) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG297_DEF
    \
    \ @brief VENC MBRC control register
    \ Address offset: 0x4A4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] MBRC control (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG298_DEF
    \
    \ @brief VENC segment 4: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x4A8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 4: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG299_DEF
    \
    \ @brief VENC segment 4: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x4AC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 4: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG300_DEF
    \
    \ @brief VENC segment 4: penalty value register
    \ Address offset: 0x4B0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 4: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG301_DEF
    \
    \ @brief VENC segment 4: penalty value register
    \ Address offset: 0x4B4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 4: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG302_DEF
    \
    \ @brief VENC segment 5: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x4B8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 5: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG303_DEF
    \
    \ @brief VENC segment 5: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x4BC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 5: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG304_DEF
    \
    \ @brief VENC segment 5: penalty value register
    \ Address offset: 0x4C0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 5: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG305_DEF
    \
    \ @brief VENC segment 5: penalty value register
    \ Address offset: 0x4C4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 5: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG306_DEF
    \
    \ @brief VENC segment 6: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x4C8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 6: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG307_DEF
    \
    \ @brief VENC segment 6: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 6: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG308_DEF
    \
    \ @brief VENC segment 6: penalty value register
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 6: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG309_DEF
    \
    \ @brief VENC segment 6: penalty value register
    \ Address offset: 0x4D4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 6: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG310_DEF
    \
    \ @brief VENC segment 7: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x4D8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 7: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG311_DEF
    \
    \ @brief VENC segment 7: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 7: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG312_DEF
    \
    \ @brief VENC segment 7: penalty value register
    \ Address offset: 0x4E0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 7: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG313_DEF
    \
    \ @brief VENC segment 7: penalty value register
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 7: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG314_DEF
    \
    \ @brief VENC segment 8: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x4E8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 8: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG315_DEF
    \
    \ @brief VENC segment 8: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x4EC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 8: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG316_DEF
    \
    \ @brief VENC segment 8: penalty value register
    \ Address offset: 0x4F0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 8: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG317_DEF
    \
    \ @brief VENC segment 8: penalty value register
    \ Address offset: 0x4F4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 8: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG318_DEF
    \
    \ @brief VENC segment 9: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x4F8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 9: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG319_DEF
    \
    \ @brief VENC segment 9: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x4FC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 9: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG320_DEF
    \
    \ @brief VENC segment 9: penalty value register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 9: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG321_DEF
    \
    \ @brief VENC segment 9: penalty value register
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 9: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG322_DEF
    \
    \ @brief VENC segment 10: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 10: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG323_DEF
    \
    \ @brief VENC segment 10: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 10: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG324_DEF
    \
    \ @brief VENC segment 10: penalty value register
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 10: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG325_DEF
    \
    \ @brief VENC segment 10: penalty value register
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 10: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG326_DEF
    \
    \ @brief VENC segment 11: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 11: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG327_DEF
    \
    \ @brief VENC segment 11: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 11: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG328_DEF
    \
    \ @brief VENC segment 11: penalty value register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 11: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG329_DEF
    \
    \ @brief VENC segment 11: penalty value register
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 11: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG330_DEF
    \
    \ @brief VENC segment 12: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 12: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG331_DEF
    \
    \ @brief VENC segment 12: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 12: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG332_DEF
    \
    \ @brief VENC segment 12: penalty value register
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 12: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG333_DEF
    \
    \ @brief VENC segment 12: penalty value register
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 12: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG334_DEF
    \
    \ @brief VENC segment 13: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x538
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 13: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG335_DEF
    \
    \ @brief VENC segment 13: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x53C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 13: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG336_DEF
    \
    \ @brief VENC segment 13: penalty value register
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 13: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG337_DEF
    \
    \ @brief VENC segment 13: penalty value register
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 13: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG338_DEF
    \
    \ @brief VENC segment 14: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 14: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG339_DEF
    \
    \ @brief VENC segment 14: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 14: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG340_DEF
    \
    \ @brief VENC segment 14: penalty value register
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 14: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG341_DEF
    \
    \ @brief VENC segment 14: penalty value register
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 14: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG342_DEF
    \
    \ @brief VENC segment 15: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x558
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 15: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG343_DEF
    \
    \ @brief VENC segment 15: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 15: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG344_DEF
    \
    \ @brief VENC segment 15: penalty value register
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 15: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG345_DEF
    \
    \ @brief VENC segment 15: penalty value register
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 15: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG346_DEF
    \
    \ @brief VENC segment 16: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 16: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG347_DEF
    \
    \ @brief VENC segment 16: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 16: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG348_DEF
    \
    \ @brief VENC segment 16: penalty value register
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 16: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG349_DEF
    \
    \ @brief VENC segment 16: penalty value register
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 16: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG350_DEF
    \
    \ @brief VENC segment 17: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x578
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 17: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG351_DEF
    \
    \ @brief VENC segment 17: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x57C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 17: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG352_DEF
    \
    \ @brief VENC segment 17: penalty value register
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 17: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG353_DEF
    \
    \ @brief VENC segment 17: penalty value register
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 17: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG354_DEF
    \
    \ @brief VENC segment 18: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 18: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG355_DEF
    \
    \ @brief VENC segment 18: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 18: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG356_DEF
    \
    \ @brief VENC segment 18: penalty value register
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 18: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG357_DEF
    \
    \ @brief VENC segment 18: penalty value register
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 18: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG358_DEF
    \
    \ @brief VENC segment 19: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x598
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 19: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG359_DEF
    \
    \ @brief VENC segment 19: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 19: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG360_DEF
    \
    \ @brief VENC segment 19: penalty value register
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 19: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG361_DEF
    \
    \ @brief VENC segment 19: penalty value register
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 19: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG362_DEF
    \
    \ @brief VENC segment 20: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 20: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG363_DEF
    \
    \ @brief VENC segment 20: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 20: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG364_DEF
    \
    \ @brief VENC segment 20: penalty value register
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 20: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG365_DEF
    \
    \ @brief VENC segment 20: penalty value register
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 20: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG366_DEF
    \
    \ @brief VENC segment 21: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x5B8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 21: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG367_DEF
    \
    \ @brief VENC segment 21: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x5BC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 21: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG368_DEF
    \
    \ @brief VENC segment 21: penalty value register
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 21: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG369_DEF
    \
    \ @brief VENC segment 21: penalty value register
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 21: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG370_DEF
    \
    \ @brief VENC segment 22: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 22: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG371_DEF
    \
    \ @brief VENC segment 22: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 22: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG372_DEF
    \
    \ @brief VENC segment 22: penalty value register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 22: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG373_DEF
    \
    \ @brief VENC segment 22: penalty value register
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 22: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG374_DEF
    \
    \ @brief VENC segment 23: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x5D8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 23: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG375_DEF
    \
    \ @brief VENC segment 23: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 23: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG376_DEF
    \
    \ @brief VENC segment 23: penalty value register
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 23: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG377_DEF
    \
    \ @brief VENC segment 23: penalty value register
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 23: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG378_DEF
    \
    \ @brief VENC segment 24: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 24: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG379_DEF
    \
    \ @brief VENC segment 24: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x5EC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 24: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG380_DEF
    \
    \ @brief VENC segment 24: penalty value register
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 24: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG381_DEF
    \
    \ @brief VENC segment 24: penalty value register
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 24: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG382_DEF
    \
    \ @brief VENC segment 25: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x5F8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 25: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG383_DEF
    \
    \ @brief VENC segment 25: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x5FC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 25: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG384_DEF
    \
    \ @brief VENC segment 25: penalty value register
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 25: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG385_DEF
    \
    \ @brief VENC segment 25: penalty value register
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 25: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG386_DEF
    \
    \ @brief VENC segment 26: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 26: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG387_DEF
    \
    \ @brief VENC segment 26: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 26: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG388_DEF
    \
    \ @brief VENC segment 26: penalty value register
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 26: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG389_DEF
    \
    \ @brief VENC segment 26: penalty value register
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 26: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG390_DEF
    \
    \ @brief VENC segment 27: intra 4x4 previous mode favor, intra 16x16mode favor, penalty value for second reference frame register
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 27: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG391_DEF
    \
    \ @brief VENC segment 27: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 27: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG392_DEF
    \
    \ @brief VENC segment 27: penalty value register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 27: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG393_DEF
    \
    \ @brief VENC segment 27: penalty value register
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 27: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG394_DEF
    \
    \ @brief VENC segment 28: intra 4x4 previous mode favor, intra 16x16mode favor, penalty value for second reference frame register
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 28: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG395_DEF
    \
    \ @brief VENC segment 28: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 28: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG396_DEF
    \
    \ @brief VENC segment 28: penalty value register
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 28: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG397_DEF
    \
    \ @brief VENC segment 28: penalty value register
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 28: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG398_DEF
    \
    \ @brief VENC segment 29: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x638
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 29: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG399_DEF
    \
    \ @brief VENC segment 29: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x63C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 29: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG400_DEF
    \
    \ @brief VENC segment 29: penalty value register
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 29: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG401_DEF
    \
    \ @brief VENC segment 29: penalty value register
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 29: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG402_DEF
    \
    \ @brief VENC segment 30: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 30: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG403_DEF
    \
    \ @brief VENC segment 30: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 30: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG404_DEF
    \
    \ @brief VENC segment 30: penalty value register
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 30: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG405_DEF
    \
    \ @brief VENC segment 30: penalty value register
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 30: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG406_DEF
    \
    \ @brief VENC segment 31: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
    \ Address offset: 0x658
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 31: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG407_DEF
    \
    \ @brief VENC segment 31: skip mode penalty, inter MB mode favor register
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 31: skip mode penalty, inter MB mode favor (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG408_DEF
    \
    \ @brief VENC segment 31: penalty value register
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 31: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG409_DEF
    \
    \ @brief VENC segment 31: penalty value register
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] segment 31: penalty value (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG410_DEF
    \
    \ @brief VENC MBRC control, QP, offset, enable register
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] MBRC control (QP, offset, enable) (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG411_DEF
    \
    \ @brief VENC gain of MB QP delta. 8.8 format register
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] gain of MB QPdelta. 8.8 format (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG412_DEF
    \
    \ @brief VENC average of MB complexity register
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] average of MB complexity (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG413_DEF
    \
    \ @brief VENC reference compression control register
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] average of MB complexity (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG414_DEF
    \
    \ @brief VENC base address for reference luma register
    \ Address offset: 0x678
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] average of MB complexity (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG415_DEF
    \
    \ @brief VENC base address for reference chroma register
    \ Address offset: 0x67C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] average of MB complexity (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG416_DEF
    \
    \ @brief VENC base address for reconstructed luma register
    \ Address offset: 0x680
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] average of MB complexity (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG417_DEF
    \
    \ @brief VENC base address for reconstructed chroma register
    \ Address offset: 0x684
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] average of MB complexity (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG418_DEF
    \
    \ @brief VENC base address for second reference luma register
    \ Address offset: 0x688
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] average of MB complexity (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG419_DEF
    \
    \ @brief VENC base address for second reference chroma register
    \ Address offset: 0x68C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] average of MB complexity (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG420_DEF
    \
    \ @brief VENC limit of chroma RFC buffer register
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] average of MB complexity (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG421_DEF
    \
    \ @brief VENC reorder control register
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Reorder control (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG422_DEF
    \
    \ @brief VENC AXI read ID register
    \ Address offset: 0x698
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] AXI Read ID (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG423_DEF
    \
    \ @brief VENC base address MSB for reference luma compression table register
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] AXI Read ID (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG424_DEF
    \
    \ @brief VENC base address MSB for reference chroma compression table register
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] AXI Read ID (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG425_DEF
    \
    \ @brief VENC base address MSB for reconstructed luma compression table register
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] AXI Read ID (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG426_DEF
    \
    \ @brief VENC base address for reconstructed chroma compression table register
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address for reconstructed chroma compression table (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG427_DEF
    \
    \ @brief VENC base address MSB for second reference luma compression table register
    \ Address offset: 0x6AC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address MSB for second reference luma compression table (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG428_DEF
    \
    \ @brief VENC base address MSB for second reference chroma compression table register
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Base address MSB for second reference chroma compression table (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG429_DEF
    \
    \ @brief VENC high 32 bits of base address for output stream data register
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for output stream data (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG430_DEF
    \
    \ @brief VENC high 32 bits of base address for output control data register
    \ Address offset: 0x6B8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for output control data (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG431_DEF
    \
    \ @brief VENC high 32 bits of base address for reference luma register
    \ Address offset: 0x6BC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for reference luma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG432_DEF
    \
    \ @brief VENC high 32 bits of base address for reference chroma register
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for reference chroma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG433_DEF
    \
    \ @brief VENC high 32 bits of base address for reconstructed luma register
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for reconstructed luma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG434_DEF
    \
    \ @brief VENC high 32 bits of base address for reconstructed chroma register
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for reconstructed chroma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG435_DEF
    \
    \ @brief VENC high 32 bits of base address for input picture luma register
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for input picture luma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG436_DEF
    \
    \ @brief VENC high 32 bits of base address for input picture cb register
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for input picture cb (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG437_DEF
    \
    \ @brief VENC high 32 bits of base address for input picture cr register
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for input picture cr (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG438_DEF
    \
    \ @brief VENC high 32 bits of base address for second reference luma register
    \ Address offset: 0x6D8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for second reference luma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG439_DEF
    \
    \ @brief VENC high 32 bits of base address for second reference chroma register
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for second reference chroma (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG440_DEF
    \
    \ @brief VENC high 32 bits of H264 secondary ref pic base register
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of H264 secondary ref pic base (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG441_DEF
    \
    \ @brief VENC high 32 bits of H264 secondary ref pic base register
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of H264 secondary ref pic base (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG442_DEF
    \
    \ @brief VENC high 32 bits of base address for next pic luminance register
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for next pic luminance (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG443_DEF
    \
    \ @brief VENC high 32 bits of base address for cabac context tables H264 register
    \ Address offset: 0x6EC
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for cabac context tables (H264) or probability tables (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG444_DEF
    \
    \ @brief VENC high 32 bits of base address for MV output writing register
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for MV output writing (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG449_DEF
    \
    \ @brief VENC high 32 bits of base address for output of down-scaled encoder image in YUYV 4:2:2 format register
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] high 32 bits of Base address for output of down-scaled encoder image in YUYV 4:2:2 format (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG497_DEF
    \
    \ @brief VENC low-latency control register
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Low latency control (all format mode)
  [then]


  [ifdef] VENC_VENC_SWREG498_DEF
    \
    \ @brief VENC encoder line buffer offset register
    \ Address offset: 0x7C8
    \ Reset value: 0x00000000
    \
    $00 constant VENC_SWREG_FIELD               \ [0x00 : 32] Low latency control (all format mode)
  [then]

  \
  \ @brief Video encoder
  \
  $00 constant VENC_VENC_SWREG0         \ VENC ID register
  $04 constant VENC_VENC_SWREG1         \ VENC interrupt register
  $08 constant VENC_VENC_SWREG2         \ VENC bus interface configuration register
  $0C constant VENC_VENC_SWREG3         \ VENC device configuration register
  $14 constant VENC_VENC_SWREG5         \ VENC base address for output stream data register
  $18 constant VENC_VENC_SWREG6         \ VENC base address for output control data register
  $1C constant VENC_VENC_SWREG7         \ VENC base address for reference luma register
  $20 constant VENC_VENC_SWREG8         \ VENC base address for reference chroma register
  $24 constant VENC_VENC_SWREG9         \ VENC base address for reconstructed luma register
  $28 constant VENC_VENC_SWREG10        \ VENC base address for reconstructed chroma register
  $2C constant VENC_VENC_SWREG11        \ VENC base address for input picture luma register
  $30 constant VENC_VENC_SWREG12        \ VENC base address for input picture cb register
  $34 constant VENC_VENC_SWREG13        \ VENC base address for input picture cr register
  $38 constant VENC_VENC_SWREG14        \ VENC encoder control register 0
  $3C constant VENC_VENC_SWREG15        \ VENC encoder control register 1
  $40 constant VENC_VENC_SWREG16        \ VENC encoder control register 2
  $44 constant VENC_VENC_SWREG17        \ VENC encoder control register 3
  $48 constant VENC_VENC_SWREG18        \ VENC encoder control register 4
  $4C constant VENC_VENC_SWREG19        \ VENC encoder control register 5
  $50 constant VENC_VENC_SWREG20        \ VENC encoder control register 6
  $54 constant VENC_VENC_SWREG21        \ VENC encoder control register 7
  $58 constant VENC_VENC_SWREG22        \ VENC stream header remainder MSB bits register
  $5C constant VENC_VENC_SWREG23        \ VENC stream header remainder LSB bits register
  $60 constant VENC_VENC_SWREG24        \ VENC stream buffer limit/output stream size register
  $64 constant VENC_VENC_SWREG25        \ VENC encoder control register 8
  $68 constant VENC_VENC_SWREG26        \ VENC intra-slice bitmap register
  $6C constant VENC_VENC_SWREG27        \ VENC encoder control register 9
  $70 constant VENC_VENC_SWREG28        \ VENC encoder control register 10
  $74 constant VENC_VENC_SWREG29        \ VENC encoder control register 11
  $78 constant VENC_VENC_SWREG30        \ VENC encoder control register 12
  $7C constant VENC_VENC_SWREG31        \ VENC encoder control register 13
  $80 constant VENC_VENC_SWREG32        \ VENC encoder control register 14
  $84 constant VENC_VENC_SWREG33        \ VENC encoder control register 15
  $88 constant VENC_VENC_SWREG34        \ VENC encoder control register 16
  $8C constant VENC_VENC_SWREG35        \ VENC H.264 checkpoint word error 5-6/encoder control register 17
  $90 constant VENC_VENC_SWREG36        \ VENC H.264 checkpoint delta QP 1-8/encoder control register 18
  $94 constant VENC_VENC_SWREG37        \ VENC encoder control register 19, stream start offset
  $98 constant VENC_VENC_SWREG38        \ VENC macroblock count output register
  $9C constant VENC_VENC_SWREG39        \ VENC base address for next pic luminance register
  $A0 constant VENC_VENC_SWREG40        \ VENC stabilization mode control register
  $A4 constant VENC_VENC_SWREG41        \ VENC stabilization motion sum div8 output register
  $A8 constant VENC_VENC_SWREG42        \ VENC stabilization GMV output, matrix 1, up-left position output register
  $AC constant VENC_VENC_SWREG43        \ VENC stabilization GMV output, matrix 2, up position output register
  $B0 constant VENC_VENC_SWREG44        \ VENC stabilization matrix 3, up-right position output register
  $B4 constant VENC_VENC_SWREG45        \ VENC stabilization matrix 4, left position output register
  $B8 constant VENC_VENC_SWREG46        \ VENC stabilization matrix 5, GMV position output register
  $BC constant VENC_VENC_SWREG47        \ VENC stabilization matrix 6, right position output register
  $C0 constant VENC_VENC_SWREG48        \ VENC stabilization matrix 7, down-left position output register
  $C4 constant VENC_VENC_SWREG49        \ VENC stabilization matrix 8, down position output register
  $C8 constant VENC_VENC_SWREG50        \ VENC stabilization matrix 9, down-right position output register
  $CC constant VENC_VENC_SWREG51        \ VENC base address for cabac context tables H264 register
  $D0 constant VENC_VENC_SWREG52        \ VENC base address for MV output writing register
  $D4 constant VENC_VENC_SWREG53        \ VENC RGB to YUV conversion coefficient A - B register
  $D8 constant VENC_VENC_SWREG54        \ VENC RGB to YUV conversion coefficient C - E register
  $DC constant VENC_VENC_SWREG55        \ VENC RGB to YUV conversion coefficient F, RGB mask MSB bit position register
  $E0 constant VENC_VENC_SWREG56        \ VENC intra area register
  $E4 constant VENC_VENC_SWREG57        \ VENC CIR intra mb position register
  $E8 constant VENC_VENC_SWREG58        \ VENC intra slice bitmap for slices 0..31/base address for 1st DCT partition register
  $EC constant VENC_VENC_SWREG59        \ VENC intra slice bitmap for slices 32..63/base address for 2nd DCT partition register
  $F0 constant VENC_VENC_SWREG60        \ VENC 1st ROI area register
  $F4 constant VENC_VENC_SWREG61        \ VENC 2nd ROI area register
  $F8 constant VENC_VENC_SWREG62        \ VENC ROI area delta QP, MV register
  $FC constant VENC_VENC_SWREG63        \ VENC synthesis configuration register encoder 0 register
  $100 constant VENC_VENC_SWREG64       \ VENC JPEG luma quantization 1/intra 16x16 mode 0-1 penalty register
  $104 constant VENC_VENC_SWREG65       \ VENC JPEG luma quantization 2/intra 16x16 mode 2-3 penalty register
  $108 constant VENC_VENC_SWREG66       \ VENC JPEG luma quantization 3/intra 4x4 mode 0-1 penalty register
  $10C constant VENC_VENC_SWREG67       \ VENC JPEG luma quantization 4/intra 4x4 mode 2-3 penalty register
  $110 constant VENC_VENC_SWREG68       \ VENC JPEG luma quantization 5/intra 4x4 mode 4-5 penalty register
  $114 constant VENC_VENC_SWREG69       \ VENC JPEG luma quantization 6/intra 4x4 mode 6-7 penalty register
  $118 constant VENC_VENC_SWREG70       \ VENC JPEG luma quantization 7/intra 4x4 mode 8-9 penalty register
  $11C constant VENC_VENC_SWREG71       \ VENC JPEG luma quantization 8/base address for segmentation map register
  $120 constant VENC_VENC_SWREG72       \ VENC JPEG luma quantization 9/segment1 parameter register
  $124 constant VENC_VENC_SWREG73       \ VENC JPEG luma quantization 10/segment1 parameter register
  $128 constant VENC_VENC_SWREG74       \ VENC JPEG luma quantization 11/segment1 parameter register
  $12C constant VENC_VENC_SWREG75       \ VENC JPEG luma quantization 12/segment1 parameter register
  $130 constant VENC_VENC_SWREG76       \ VENC JPEG luma quantization 13/segment1 parameter register
  $134 constant VENC_VENC_SWREG77       \ VENC JPEG luma quantization 14/segment1 parameter register
  $138 constant VENC_VENC_SWREG78       \ VENC JPEG luma quantization 15/segment1 parameter register
  $13C constant VENC_VENC_SWREG79       \ VENC JPEG luma quantization 16/segment2 parameter register
  $140 constant VENC_VENC_SWREG80       \ VENC JPEG chroma quantization 1/segment2 parameter register
  $144 constant VENC_VENC_SWREG81       \ VENC JPEG chroma quantization 2/segment2 parameter register
  $148 constant VENC_VENC_SWREG82       \ VENC JPEG chroma quantization 3/segment2 parameter register
  $14C constant VENC_VENC_SWREG83       \ VENC JPEG chroma quantization 4/segment2 parameter register
  $150 constant VENC_VENC_SWREG84       \ VENC JPEG chroma quantization 5/segment2 parameter register
  $154 constant VENC_VENC_SWREG85       \ VENC JPEG chroma quantization 6/segment2 parameter register
  $158 constant VENC_VENC_SWREG86       \ VENC JPEG chroma quantization 7/segment2 parameter register
  $15C constant VENC_VENC_SWREG87       \ VENC JPEG chroma quantization 8/segment2 parameter register
  $160 constant VENC_VENC_SWREG88       \ VENC JPEG chroma quantization 9/segment3 parameter register
  $164 constant VENC_VENC_SWREG89       \ VENC JPEG chroma quantization 10/segment3 parameter register
  $168 constant VENC_VENC_SWREG90       \ VENC JPEG chroma quantization 11/segment3 parameter register
  $16C constant VENC_VENC_SWREG91       \ VENC JPEG chroma quantization 12/segment3 parameter register
  $170 constant VENC_VENC_SWREG92       \ VENC JPEG chroma quantization 13/segment3 parameter register
  $174 constant VENC_VENC_SWREG93       \ VENC JPEG chroma quantization 14/segment3 parameter register
  $178 constant VENC_VENC_SWREG94       \ VENC JPEG chroma quantization 15/segment3 parameter register
  $17C constant VENC_VENC_SWREG95       \ VENC JPEG chroma quantization 16/segment3 parameter register
  $180 constant VENC_VENC_SWREG96       \ VENC DMV 4p/1p penalty values 0-3 register
  $184 constant VENC_VENC_SWREG97       \ VENC DMV 4p/1p penalty values 4-7 register
  $188 constant VENC_VENC_SWREG98       \ VENC DMV 4p/1p penalty values register
  $18C constant VENC_VENC_SWREG99       \ VENC DMV 4p/1p penalty values register
  $190 constant VENC_VENC_SWREG100      \ VENC DMV 4p/1p penalty values register
  $194 constant VENC_VENC_SWREG101      \ VENC DMV 4p/1p penalty values register
  $198 constant VENC_VENC_SWREG102      \ VENC DMV 4p/1p penalty values register
  $19C constant VENC_VENC_SWREG103      \ VENC DMV 4p/1p penalty values register
  $1A0 constant VENC_VENC_SWREG104      \ VENC DMV 4p/1p penalty values register
  $1A4 constant VENC_VENC_SWREG105      \ VENC DMV 4p/1p penalty values register
  $1A8 constant VENC_VENC_SWREG106      \ VENC DMV 4p/1p penalty values register
  $1AC constant VENC_VENC_SWREG107      \ VENC DMV 4p/1p penalty values register
  $1B0 constant VENC_VENC_SWREG108      \ VENC DMV 4p/1p penalty values register
  $1B4 constant VENC_VENC_SWREG109      \ VENC DMV 4p/1p penalty values register
  $1B8 constant VENC_VENC_SWREG110      \ VENC DMV 4p/1p penalty values register
  $1BC constant VENC_VENC_SWREG111      \ VENC DMV 4p/1p penalty values register
  $1C0 constant VENC_VENC_SWREG112      \ VENC DMV 4p/1p penalty values register
  $1C4 constant VENC_VENC_SWREG113      \ VENC DMV 4p/1p penalty values register
  $1C8 constant VENC_VENC_SWREG114      \ VENC DMV 4p/1p penalty values register
  $1CC constant VENC_VENC_SWREG115      \ VENC DMV 4p/1p penalty values register
  $1D0 constant VENC_VENC_SWREG116      \ VENC DMV 4p/1p penalty values register
  $1D4 constant VENC_VENC_SWREG117      \ VENC DMV 4p/1p penalty values register
  $1D8 constant VENC_VENC_SWREG118      \ VENC DMV 4p/1p penalty values register
  $1DC constant VENC_VENC_SWREG119      \ VENC DMV 4p/1p penalty values register
  $1E0 constant VENC_VENC_SWREG120      \ VENC DMV 4p/1p penalty values register
  $1E4 constant VENC_VENC_SWREG121      \ VENC DMV 4p/1p penalty values register
  $1E8 constant VENC_VENC_SWREG122      \ VENC DMV 4p/1p penalty values register
  $1EC constant VENC_VENC_SWREG123      \ VENC DMV 4p/1p penalty values register
  $1F0 constant VENC_VENC_SWREG124      \ VENC DMV 4p/1p penalty values register
  $1F4 constant VENC_VENC_SWREG125      \ VENC DMV 4p/1p penalty values register
  $1F8 constant VENC_VENC_SWREG126      \ VENC DMV 4p/1p penalty values register
  $1FC constant VENC_VENC_SWREG127      \ VENC DMV 4p/1p penalty values 124-127 register
  $200 constant VENC_VENC_SWREG128      \ VENC DMV qpel penalty values 0-3 register
  $204 constant VENC_VENC_SWREG129      \ VENC DMV qpel penalty values 4-7 register
  $208 constant VENC_VENC_SWREG130      \ VENC DMV qpel penalty values register
  $20C constant VENC_VENC_SWREG131      \ VENC DMV qpel penalty values register
  $210 constant VENC_VENC_SWREG132      \ VENC DMV qpel penalty values register
  $214 constant VENC_VENC_SWREG133      \ VENC DMV qpel penalty values register
  $218 constant VENC_VENC_SWREG134      \ VENC DMV qpel penalty values register
  $21C constant VENC_VENC_SWREG135      \ VENC DMV qpel penalty values register
  $220 constant VENC_VENC_SWREG136      \ VENC DMV qpel penalty values register
  $224 constant VENC_VENC_SWREG137      \ VENC DMV qpel penalty values register
  $228 constant VENC_VENC_SWREG138      \ VENC DMV qpel penalty values register
  $22C constant VENC_VENC_SWREG139      \ VENC DMV qpel penalty values register
  $230 constant VENC_VENC_SWREG140      \ VENC DMV qpel penalty values register
  $234 constant VENC_VENC_SWREG141      \ VENC DMV qpel penalty values register
  $238 constant VENC_VENC_SWREG142      \ VENC DMV qpel penalty values register
  $23C constant VENC_VENC_SWREG143      \ VENC DMV qpel penalty values register
  $240 constant VENC_VENC_SWREG144      \ VENC DMV qpel penalty values register
  $244 constant VENC_VENC_SWREG145      \ VENC DMV qpel penalty values register
  $248 constant VENC_VENC_SWREG146      \ VENC DMV qpel penalty values register
  $24C constant VENC_VENC_SWREG147      \ VENC DMV qpel penalty values register
  $250 constant VENC_VENC_SWREG148      \ VENC DMV qpel penalty values register
  $254 constant VENC_VENC_SWREG149      \ VENC DMV qpel penalty values register
  $258 constant VENC_VENC_SWREG150      \ VENC DMV qpel penalty values register
  $25C constant VENC_VENC_SWREG151      \ VENC DMV qpel penalty values register
  $260 constant VENC_VENC_SWREG152      \ VENC DMV qpel penalty values register
  $264 constant VENC_VENC_SWREG153      \ VENC DMV qpel penalty values register
  $268 constant VENC_VENC_SWREG154      \ VENC DMV qpel penalty values register
  $26C constant VENC_VENC_SWREG155      \ VENC DMV qpel penalty values register
  $270 constant VENC_VENC_SWREG156      \ VENC DMV qpel penalty values register
  $274 constant VENC_VENC_SWREG157      \ VENC DMV qpel penalty values register
  $278 constant VENC_VENC_SWREG158      \ VENC DMV qpel penalty values register
  $27C constant VENC_VENC_SWREG159      \ VENC DMV qpel penalty values 124-127 register
  $39C constant VENC_VENC_SWREG231      \ VENC base address for output of down-scaled encoder image in YUYV 4:2:2 format register
  $3A0 constant VENC_VENC_SWREG232      \ VENC scaling control register
  $3A4 constant VENC_VENC_SWREG233      \ VENC scaling control register
  $3B0 constant VENC_VENC_SWREG236      \ VENC squared error output calculated for 13x13 pixels per macroblock register
  $3B4 constant VENC_VENC_SWREG237      \ VENC MAD 2 control and output register
  $3B8 constant VENC_VENC_SWREG238      \ VENC MAD 3 control and output register
  $400 constant VENC_VENC_SWREG256      \ VENC segment 1: intra 16x16 mode 0-2 penalty register
  $404 constant VENC_VENC_SWREG257      \ VENC segment 1: intra 16x16 mode 3, intra 4x4 0-1 penalty register
  $408 constant VENC_VENC_SWREG258      \ VENC segment 1: intra 4x4 mode 2-4 penalty register
  $40C constant VENC_VENC_SWREG259      \ VENC segment 1: intra 4x4 mode 5-7 penalty register
  $410 constant VENC_VENC_SWREG260      \ VENC segment 1: intra 4x4 mode 8-9 penalty, previous mode favor for H.264 register
  $414 constant VENC_VENC_SWREG261      \ VENC segment 1: bit cost of inter type, intra 16x16 mode favor register
  $418 constant VENC_VENC_SWREG262      \ VENC segment 1: inter MB mode favor, skip mode penalty, penalty value for 2nd reference frame register
  $41C constant VENC_VENC_SWREG263      \ VENC segment 1: penalty value register
  $420 constant VENC_VENC_SWREG264      \ VENC segment 1: penalty value register
  $424 constant VENC_VENC_SWREG265      \ VENC segment 1: deadzone rate multiplier for plane 0-1 register
  $428 constant VENC_VENC_SWREG266      \ VENC segment 1: deadzone rate multiplier for plane 2-3 register
  $42C constant VENC_VENC_SWREG267      \ VENC segment 1: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
  $430 constant VENC_VENC_SWREG268      \ VENC segment 2: intra 16x16 mode 0-2 penalty register
  $434 constant VENC_VENC_SWREG269      \ VENC segment 2: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty register
  $438 constant VENC_VENC_SWREG270      \ VENC segment 2: intra 4x4 mode 2-4 penalty register
  $43C constant VENC_VENC_SWREG271      \ VENC segment 2: intra 4x4 mode 5-7 penalty register
  $440 constant VENC_VENC_SWREG272      \ VENC segment 2: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 register
  $444 constant VENC_VENC_SWREG273      \ VENC segment 2: bit cost of inter type, intra 16x16 mode favor register
  $448 constant VENC_VENC_SWREG274      \ VENC segment 2: inter MB mode favor, skip mode penalty, penalty value register
  $44C constant VENC_VENC_SWREG275      \ VENC segment 2: penalty value register
  $450 constant VENC_VENC_SWREG276      \ VENC segment 2: penalty value register
  $454 constant VENC_VENC_SWREG277      \ VENC segment 2: deadzone rate multiplier for plane 0-1 register
  $458 constant VENC_VENC_SWREG278      \ VENC segment 2: deadzone rate multiplier for plane 2-3 register
  $45C constant VENC_VENC_SWREG279      \ VENC segment 2: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
  $460 constant VENC_VENC_SWREG280      \ VENC segment 3: intra 16x16 mode 0-2 penalty register
  $464 constant VENC_VENC_SWREG281      \ VENC segment 3: intra 16x16 mode 3 penalty, intra 4x4 mode 0-1 penalty register
  $468 constant VENC_VENC_SWREG282      \ VENC segment 3: intra 4x4 mode 2-4 penalty register
  $46C constant VENC_VENC_SWREG283      \ VENC segment 3: intra 4x4 mode 5-7 penalty register
  $470 constant VENC_VENC_SWREG284      \ VENC segment 3: intra 4x4 mode 8-9 penalty, intra 4x4 previous mode favor for H.264 register
  $474 constant VENC_VENC_SWREG285      \ VENC segment 3: bit cost of inter type, intra 16x16 mode favor register
  $478 constant VENC_VENC_SWREG286      \ VENC segment 3: inter MB mode favor in intra/inter selection, inter MB mode favor, penalty value for second reference frame register
  $47C constant VENC_VENC_SWREG287      \ VENC segment 3: penalty value register
  $480 constant VENC_VENC_SWREG288      \ VENC segment 3: penalty value register
  $484 constant VENC_VENC_SWREG289      \ VENC segment 3: deadzone rate multiplier for plane 0-1 register
  $488 constant VENC_VENC_SWREG290      \ VENC segment 3: deadzone rate multiplier for plane 2-3 register
  $48C constant VENC_VENC_SWREG291      \ VENC segment 3: deadzone rate for macroblock skip token 0-1, dmv penalty coefficient register
  $498 constant VENC_VENC_SWREG294      \ VENC Mb boost register
  $49C constant VENC_VENC_SWREG295      \ VENC variance control, Pskop conding mode register
  $4A0 constant VENC_VENC_SWREG296      \ VENC synthesis configuration register encoder 1 read only register
  $4A4 constant VENC_VENC_SWREG297      \ VENC MBRC control register
  $4A8 constant VENC_VENC_SWREG298      \ VENC segment 4: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $4AC constant VENC_VENC_SWREG299      \ VENC segment 4: skip mode penalty, inter MB mode favor register
  $4B0 constant VENC_VENC_SWREG300      \ VENC segment 4: penalty value register
  $4B4 constant VENC_VENC_SWREG301      \ VENC segment 4: penalty value register
  $4B8 constant VENC_VENC_SWREG302      \ VENC segment 5: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $4BC constant VENC_VENC_SWREG303      \ VENC segment 5: skip mode penalty, inter MB mode favor register
  $4C0 constant VENC_VENC_SWREG304      \ VENC segment 5: penalty value register
  $4C4 constant VENC_VENC_SWREG305      \ VENC segment 5: penalty value register
  $4C8 constant VENC_VENC_SWREG306      \ VENC segment 6: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $4CC constant VENC_VENC_SWREG307      \ VENC segment 6: skip mode penalty, inter MB mode favor register
  $4D0 constant VENC_VENC_SWREG308      \ VENC segment 6: penalty value register
  $4D4 constant VENC_VENC_SWREG309      \ VENC segment 6: penalty value register
  $4D8 constant VENC_VENC_SWREG310      \ VENC segment 7: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $4DC constant VENC_VENC_SWREG311      \ VENC segment 7: skip mode penalty, inter MB mode favor register
  $4E0 constant VENC_VENC_SWREG312      \ VENC segment 7: penalty value register
  $4E4 constant VENC_VENC_SWREG313      \ VENC segment 7: penalty value register
  $4E8 constant VENC_VENC_SWREG314      \ VENC segment 8: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $4EC constant VENC_VENC_SWREG315      \ VENC segment 8: skip mode penalty, inter MB mode favor register
  $4F0 constant VENC_VENC_SWREG316      \ VENC segment 8: penalty value register
  $4F4 constant VENC_VENC_SWREG317      \ VENC segment 8: penalty value register
  $4F8 constant VENC_VENC_SWREG318      \ VENC segment 9: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $4FC constant VENC_VENC_SWREG319      \ VENC segment 9: skip mode penalty, inter MB mode favor register
  $500 constant VENC_VENC_SWREG320      \ VENC segment 9: penalty value register
  $504 constant VENC_VENC_SWREG321      \ VENC segment 9: penalty value register
  $508 constant VENC_VENC_SWREG322      \ VENC segment 10: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $50C constant VENC_VENC_SWREG323      \ VENC segment 10: skip mode penalty, inter MB mode favor register
  $510 constant VENC_VENC_SWREG324      \ VENC segment 10: penalty value register
  $514 constant VENC_VENC_SWREG325      \ VENC segment 10: penalty value register
  $518 constant VENC_VENC_SWREG326      \ VENC segment 11: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $51C constant VENC_VENC_SWREG327      \ VENC segment 11: skip mode penalty, inter MB mode favor register
  $520 constant VENC_VENC_SWREG328      \ VENC segment 11: penalty value register
  $524 constant VENC_VENC_SWREG329      \ VENC segment 11: penalty value register
  $528 constant VENC_VENC_SWREG330      \ VENC segment 12: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $52C constant VENC_VENC_SWREG331      \ VENC segment 12: skip mode penalty, inter MB mode favor register
  $530 constant VENC_VENC_SWREG332      \ VENC segment 12: penalty value register
  $534 constant VENC_VENC_SWREG333      \ VENC segment 12: penalty value register
  $538 constant VENC_VENC_SWREG334      \ VENC segment 13: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $53C constant VENC_VENC_SWREG335      \ VENC segment 13: skip mode penalty, inter MB mode favor register
  $540 constant VENC_VENC_SWREG336      \ VENC segment 13: penalty value register
  $544 constant VENC_VENC_SWREG337      \ VENC segment 13: penalty value register
  $548 constant VENC_VENC_SWREG338      \ VENC segment 14: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $54C constant VENC_VENC_SWREG339      \ VENC segment 14: skip mode penalty, inter MB mode favor register
  $550 constant VENC_VENC_SWREG340      \ VENC segment 14: penalty value register
  $554 constant VENC_VENC_SWREG341      \ VENC segment 14: penalty value register
  $558 constant VENC_VENC_SWREG342      \ VENC segment 15: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $55C constant VENC_VENC_SWREG343      \ VENC segment 15: skip mode penalty, inter MB mode favor register
  $560 constant VENC_VENC_SWREG344      \ VENC segment 15: penalty value register
  $564 constant VENC_VENC_SWREG345      \ VENC segment 15: penalty value register
  $568 constant VENC_VENC_SWREG346      \ VENC segment 16: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $56C constant VENC_VENC_SWREG347      \ VENC segment 16: skip mode penalty, inter MB mode favor register
  $570 constant VENC_VENC_SWREG348      \ VENC segment 16: penalty value register
  $574 constant VENC_VENC_SWREG349      \ VENC segment 16: penalty value register
  $578 constant VENC_VENC_SWREG350      \ VENC segment 17: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $57C constant VENC_VENC_SWREG351      \ VENC segment 17: skip mode penalty, inter MB mode favor register
  $580 constant VENC_VENC_SWREG352      \ VENC segment 17: penalty value register
  $584 constant VENC_VENC_SWREG353      \ VENC segment 17: penalty value register
  $588 constant VENC_VENC_SWREG354      \ VENC segment 18: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $58C constant VENC_VENC_SWREG355      \ VENC segment 18: skip mode penalty, inter MB mode favor register
  $590 constant VENC_VENC_SWREG356      \ VENC segment 18: penalty value register
  $594 constant VENC_VENC_SWREG357      \ VENC segment 18: penalty value register
  $598 constant VENC_VENC_SWREG358      \ VENC segment 19: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $59C constant VENC_VENC_SWREG359      \ VENC segment 19: skip mode penalty, inter MB mode favor register
  $5A0 constant VENC_VENC_SWREG360      \ VENC segment 19: penalty value register
  $5A4 constant VENC_VENC_SWREG361      \ VENC segment 19: penalty value register
  $5A8 constant VENC_VENC_SWREG362      \ VENC segment 20: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $5AC constant VENC_VENC_SWREG363      \ VENC segment 20: skip mode penalty, inter MB mode favor register
  $5B0 constant VENC_VENC_SWREG364      \ VENC segment 20: penalty value register
  $5B4 constant VENC_VENC_SWREG365      \ VENC segment 20: penalty value register
  $5B8 constant VENC_VENC_SWREG366      \ VENC segment 21: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $5BC constant VENC_VENC_SWREG367      \ VENC segment 21: skip mode penalty, inter MB mode favor register
  $5C0 constant VENC_VENC_SWREG368      \ VENC segment 21: penalty value register
  $5C4 constant VENC_VENC_SWREG369      \ VENC segment 21: penalty value register
  $5C8 constant VENC_VENC_SWREG370      \ VENC segment 22: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $5CC constant VENC_VENC_SWREG371      \ VENC segment 22: skip mode penalty, inter MB mode favor register
  $5D0 constant VENC_VENC_SWREG372      \ VENC segment 22: penalty value register
  $5D4 constant VENC_VENC_SWREG373      \ VENC segment 22: penalty value register
  $5D8 constant VENC_VENC_SWREG374      \ VENC segment 23: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $5DC constant VENC_VENC_SWREG375      \ VENC segment 23: skip mode penalty, inter MB mode favor register
  $5E0 constant VENC_VENC_SWREG376      \ VENC segment 23: penalty value register
  $5E4 constant VENC_VENC_SWREG377      \ VENC segment 23: penalty value register
  $5E8 constant VENC_VENC_SWREG378      \ VENC segment 24: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $5EC constant VENC_VENC_SWREG379      \ VENC segment 24: skip mode penalty, inter MB mode favor register
  $5F0 constant VENC_VENC_SWREG380      \ VENC segment 24: penalty value register
  $5F4 constant VENC_VENC_SWREG381      \ VENC segment 24: penalty value register
  $5F8 constant VENC_VENC_SWREG382      \ VENC segment 25: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $5FC constant VENC_VENC_SWREG383      \ VENC segment 25: skip mode penalty, inter MB mode favor register
  $600 constant VENC_VENC_SWREG384      \ VENC segment 25: penalty value register
  $604 constant VENC_VENC_SWREG385      \ VENC segment 25: penalty value register
  $608 constant VENC_VENC_SWREG386      \ VENC segment 26: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $60C constant VENC_VENC_SWREG387      \ VENC segment 26: skip mode penalty, inter MB mode favor register
  $610 constant VENC_VENC_SWREG388      \ VENC segment 26: penalty value register
  $614 constant VENC_VENC_SWREG389      \ VENC segment 26: penalty value register
  $618 constant VENC_VENC_SWREG390      \ VENC segment 27: intra 4x4 previous mode favor, intra 16x16mode favor, penalty value for second reference frame register
  $61C constant VENC_VENC_SWREG391      \ VENC segment 27: skip mode penalty, inter MB mode favor register
  $620 constant VENC_VENC_SWREG392      \ VENC segment 27: penalty value register
  $624 constant VENC_VENC_SWREG393      \ VENC segment 27: penalty value register
  $628 constant VENC_VENC_SWREG394      \ VENC segment 28: intra 4x4 previous mode favor, intra 16x16mode favor, penalty value for second reference frame register
  $62C constant VENC_VENC_SWREG395      \ VENC segment 28: skip mode penalty, inter MB mode favor register
  $630 constant VENC_VENC_SWREG396      \ VENC segment 28: penalty value register
  $634 constant VENC_VENC_SWREG397      \ VENC segment 28: penalty value register
  $638 constant VENC_VENC_SWREG398      \ VENC segment 29: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $63C constant VENC_VENC_SWREG399      \ VENC segment 29: skip mode penalty, inter MB mode favor register
  $640 constant VENC_VENC_SWREG400      \ VENC segment 29: penalty value register
  $644 constant VENC_VENC_SWREG401      \ VENC segment 29: penalty value register
  $648 constant VENC_VENC_SWREG402      \ VENC segment 30: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $64C constant VENC_VENC_SWREG403      \ VENC segment 30: skip mode penalty, inter MB mode favor register
  $650 constant VENC_VENC_SWREG404      \ VENC segment 30: penalty value register
  $654 constant VENC_VENC_SWREG405      \ VENC segment 30: penalty value register
  $658 constant VENC_VENC_SWREG406      \ VENC segment 31: intra 4x4 previous mode favor, intra 16x16 mode favor, penalty value for second reference frame register
  $65C constant VENC_VENC_SWREG407      \ VENC segment 31: skip mode penalty, inter MB mode favor register
  $660 constant VENC_VENC_SWREG408      \ VENC segment 31: penalty value register
  $664 constant VENC_VENC_SWREG409      \ VENC segment 31: penalty value register
  $668 constant VENC_VENC_SWREG410      \ VENC MBRC control, QP, offset, enable register
  $66C constant VENC_VENC_SWREG411      \ VENC gain of MB QP delta. 8.8 format register
  $670 constant VENC_VENC_SWREG412      \ VENC average of MB complexity register
  $674 constant VENC_VENC_SWREG413      \ VENC reference compression control register
  $678 constant VENC_VENC_SWREG414      \ VENC base address for reference luma register
  $67C constant VENC_VENC_SWREG415      \ VENC base address for reference chroma register
  $680 constant VENC_VENC_SWREG416      \ VENC base address for reconstructed luma register
  $684 constant VENC_VENC_SWREG417      \ VENC base address for reconstructed chroma register
  $688 constant VENC_VENC_SWREG418      \ VENC base address for second reference luma register
  $68C constant VENC_VENC_SWREG419      \ VENC base address for second reference chroma register
  $690 constant VENC_VENC_SWREG420      \ VENC limit of chroma RFC buffer register
  $694 constant VENC_VENC_SWREG421      \ VENC reorder control register
  $698 constant VENC_VENC_SWREG422      \ VENC AXI read ID register
  $69C constant VENC_VENC_SWREG423      \ VENC base address MSB for reference luma compression table register
  $6A0 constant VENC_VENC_SWREG424      \ VENC base address MSB for reference chroma compression table register
  $6A4 constant VENC_VENC_SWREG425      \ VENC base address MSB for reconstructed luma compression table register
  $6A8 constant VENC_VENC_SWREG426      \ VENC base address for reconstructed chroma compression table register
  $6AC constant VENC_VENC_SWREG427      \ VENC base address MSB for second reference luma compression table register
  $6B0 constant VENC_VENC_SWREG428      \ VENC base address MSB for second reference chroma compression table register
  $6B4 constant VENC_VENC_SWREG429      \ VENC high 32 bits of base address for output stream data register
  $6B8 constant VENC_VENC_SWREG430      \ VENC high 32 bits of base address for output control data register
  $6BC constant VENC_VENC_SWREG431      \ VENC high 32 bits of base address for reference luma register
  $6C0 constant VENC_VENC_SWREG432      \ VENC high 32 bits of base address for reference chroma register
  $6C4 constant VENC_VENC_SWREG433      \ VENC high 32 bits of base address for reconstructed luma register
  $6C8 constant VENC_VENC_SWREG434      \ VENC high 32 bits of base address for reconstructed chroma register
  $6CC constant VENC_VENC_SWREG435      \ VENC high 32 bits of base address for input picture luma register
  $6D0 constant VENC_VENC_SWREG436      \ VENC high 32 bits of base address for input picture cb register
  $6D4 constant VENC_VENC_SWREG437      \ VENC high 32 bits of base address for input picture cr register
  $6D8 constant VENC_VENC_SWREG438      \ VENC high 32 bits of base address for second reference luma register
  $6DC constant VENC_VENC_SWREG439      \ VENC high 32 bits of base address for second reference chroma register
  $6E0 constant VENC_VENC_SWREG440      \ VENC high 32 bits of H264 secondary ref pic base register
  $6E4 constant VENC_VENC_SWREG441      \ VENC high 32 bits of H264 secondary ref pic base register
  $6E8 constant VENC_VENC_SWREG442      \ VENC high 32 bits of base address for next pic luminance register
  $6EC constant VENC_VENC_SWREG443      \ VENC high 32 bits of base address for cabac context tables H264 register
  $6F0 constant VENC_VENC_SWREG444      \ VENC high 32 bits of base address for MV output writing register
  $704 constant VENC_VENC_SWREG449      \ VENC high 32 bits of base address for output of down-scaled encoder image in YUYV 4:2:2 format register
  $7C4 constant VENC_VENC_SWREG497      \ VENC low-latency control register
  $7C8 constant VENC_VENC_SWREG498      \ VENC encoder line buffer offset register

: VENC_DEF ; [then]
