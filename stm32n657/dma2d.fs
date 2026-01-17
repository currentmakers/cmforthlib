\
\ @file dma2d.fs
\ @brief Chrom-ART Accelerator controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA2D_DEF

  [ifdef] DMA2D_DMA2D_CR_DEF
    \
    \ @brief DMA2D control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_START                    \ [0x00] Start
    $01 constant DMA2D_SUSP                     \ [0x01] Suspend
    $02 constant DMA2D_ABORT                    \ [0x02] Abort
    $06 constant DMA2D_LOM                      \ [0x06] Line offset mode
    $08 constant DMA2D_TEIE                     \ [0x08] Transfer error (TE) interrupt enable
    $09 constant DMA2D_TCIE                     \ [0x09] Transfer complete (TC) interrupt enable
    $0a constant DMA2D_TWIE                     \ [0x0a] Transfer watermark (TW) interrupt enable
    $0b constant DMA2D_CAEIE                    \ [0x0b] CLUT access error (CAE) interrupt enable
    $0c constant DMA2D_CTCIE                    \ [0x0c] CLUT transfer complete (CTC) interrupt enable
    $0d constant DMA2D_CEIE                     \ [0x0d] Configuration error (CE) interrupt enable
    $10 constant DMA2D_MODE                     \ [0x10 : 3] DMA2D mode
  [then]


  [ifdef] DMA2D_DMA2D_ISR_DEF
    \
    \ @brief DMA2D interrupt status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_TEIF                     \ [0x00] Transfer error interrupt flag
    $01 constant DMA2D_TCIF                     \ [0x01] Transfer complete interrupt flag
    $02 constant DMA2D_TWIF                     \ [0x02] Transfer watermark interrupt flag
    $03 constant DMA2D_CAEIF                    \ [0x03] CLUT access error interrupt flag
    $04 constant DMA2D_CTCIF                    \ [0x04] CLUT transfer complete interrupt flag
    $05 constant DMA2D_CEIF                     \ [0x05] Configuration error interrupt flag
  [then]


  [ifdef] DMA2D_DMA2D_IFCR_DEF
    \
    \ @brief DMA2D interrupt flag clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CTEIF                    \ [0x00] Clear transfer error interrupt flag
    $01 constant DMA2D_CTCIF                    \ [0x01] Clear transfer complete interrupt flag
    $02 constant DMA2D_CTWIF                    \ [0x02] Clear transfer watermark interrupt flag
    $03 constant DMA2D_CAECIF                   \ [0x03] Clear CLUT access error interrupt flag
    $04 constant DMA2D_CCTCIF                   \ [0x04] Clear CLUT transfer complete interrupt flag
    $05 constant DMA2D_CCEIF                    \ [0x05] Clear configuration error interrupt flag
  [then]


  [ifdef] DMA2D_DMA2D_FGMAR_DEF
    \
    \ @brief DMA2D foreground memory address register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address, address of the data used for the foreground image
  [then]


  [ifdef] DMA2D_DMA2D_FGOR_DEF
    \
    \ @brief DMA2D foreground offset register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LO                       \ [0x00 : 16] Line offset
  [then]


  [ifdef] DMA2D_DMA2D_BGMAR_DEF
    \
    \ @brief DMA2D background memory address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address, address of the data used for the background image
  [then]


  [ifdef] DMA2D_DMA2D_BGOR_DEF
    \
    \ @brief DMA2D background offset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LO                       \ [0x00 : 16] Line offset
  [then]


  [ifdef] DMA2D_DMA2D_FGPFCCR_DEF
    \
    \ @brief DMA2D foreground PFC control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CM                       \ [0x00 : 4] Color mode
    $04 constant DMA2D_CCM                      \ [0x04] CLUT color mode
    $05 constant DMA2D_START                    \ [0x05] Start
    $08 constant DMA2D_CS                       \ [0x08 : 8] CLUT size
    $10 constant DMA2D_AM                       \ [0x10 : 2] Alpha mode
    $12 constant DMA2D_CSS                      \ [0x12 : 2] Chroma subsampling
    $14 constant DMA2D_AI                       \ [0x14] Alpha inverted
    $15 constant DMA2D_RBS                      \ [0x15] Red/Blue swap
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha value
  [then]


  [ifdef] DMA2D_DMA2D_FGCOLR_DEF
    \
    \ @brief DMA2D foreground color register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue value for the A4 or A8 mode of the foreground image
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green value for the A4 or A8 mode of the foreground image
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red value for the A4 or A8 mode of the foreground image
  [then]


  [ifdef] DMA2D_DMA2D_BGPFCCR_DEF
    \
    \ @brief DMA2D background PFC control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CM                       \ [0x00 : 4] Color mode
    $04 constant DMA2D_CCM                      \ [0x04] CLUT color mode
    $05 constant DMA2D_START                    \ [0x05] Start
    $08 constant DMA2D_CS                       \ [0x08 : 8] CLUT size
    $10 constant DMA2D_AM                       \ [0x10 : 2] Alpha mode
    $14 constant DMA2D_AI                       \ [0x14] Alpha Inverted
    $15 constant DMA2D_RBS                      \ [0x15] Red/Blue swap
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha value
  [then]


  [ifdef] DMA2D_DMA2D_BGCOLR_DEF
    \
    \ @brief DMA2D background color register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue value for the A4 or A8 mode of the background
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green value for the A4 or A8 mode of the background
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red value for the A4 or A8 mode of the background
  [then]


  [ifdef] DMA2D_DMA2D_FGCMAR_DEF
    \
    \ @brief DMA2D foreground CLUT memory address register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA2D_DMA2D_BGCMAR_DEF
    \
    \ @brief DMA2D background CLUT memory address register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA2D_DMA2D_OPFCCR_DEF
    \
    \ @brief DMA2D output PFC control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CM                       \ [0x00 : 3] Color mode
    $08 constant DMA2D_SB                       \ [0x08] Swap bytes
    $14 constant DMA2D_AI                       \ [0x14] Alpha Inverted
    $15 constant DMA2D_RBS                      \ [0x15] Red/Blue swap
  [then]


  [ifdef] DMA2D_DMA2D_OCOLR_RGB888_DEF
    \
    \ @brief DMA2D output color register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue value of the output image in ARGB8888 or RGB888
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green value of the output image in ARGB8888 or RGB888
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red value of the output image in ARGB8888 or RGB888 mode
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha channel value of the output color in ARGB8888 mode (otherwise reserved)
  [then]


  [ifdef] DMA2D_DMA2D_OCOLR_RGB565_DEF
    \
    \ @brief DMA2D output color register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 5] Blue value of the output image in RGB565 mode
    $05 constant DMA2D_GREEN                    \ [0x05 : 6] Green value of the output image in RGB565 mode
    $0b constant DMA2D_RED                      \ [0x0b : 5] Red value of the output image in RGB565 mode
  [then]


  [ifdef] DMA2D_DMA2D_OCOLR_ARGB1555_DEF
    \
    \ @brief DMA2D output color register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 5] Blue value of the output image in ARGB1555 mode
    $05 constant DMA2D_GREEN                    \ [0x05 : 5] Green value of the output image in ARGB1555 mode
    $0a constant DMA2D_RED                      \ [0x0a : 5] Red value of the output image in ARGB1555 mode
    $0f constant DMA2D_A                        \ [0x0f] Alpha channel value of the output color in ARGB1555 mode
  [then]


  [ifdef] DMA2D_DMA2D_OCOLR_ARGB4444_DEF
    \
    \ @brief DMA2D output color register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 4] Blue value of the output image in ARGB4444 mode
    $04 constant DMA2D_GREEN                    \ [0x04 : 4] Green value of the output image in ARGB4444 mode
    $08 constant DMA2D_RED                      \ [0x08 : 4] Red value of the output image in ARGB4444 mode
    $0c constant DMA2D_ALPHA                    \ [0x0c : 4] Alpha channel of the output color value in ARGB4444
  [then]


  [ifdef] DMA2D_DMA2D_OMAR_DEF
    \
    \ @brief DMA2D output memory address register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA2D_DMA2D_OOR_DEF
    \
    \ @brief DMA2D output offset register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LO                       \ [0x00 : 16] Line offset
  [then]


  [ifdef] DMA2D_DMA2D_NLR_DEF
    \
    \ @brief DMA2D number of line register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_NL                       \ [0x00 : 16] Number of lines of the area to be transferred.
    $10 constant DMA2D_PL                       \ [0x10 : 14] Pixel per lines per lines of the area to be transferred
  [then]


  [ifdef] DMA2D_DMA2D_LWR_DEF
    \
    \ @brief DMA2D line watermark register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LW                       \ [0x00 : 16] Line watermark for interrupt generation
  [then]


  [ifdef] DMA2D_DMA2D_AMTCR_DEF
    \
    \ @brief DMA2D AXI master timer configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_EN                       \ [0x00] Dead-time functionality enable
    $08 constant DMA2D_DT                       \ [0x08 : 8] Dead time
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT0_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT1_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT2_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT3_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT4_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT5_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT6_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT7_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT8_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT9_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT10_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT11_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x42C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT12_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT13_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x434
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT14_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x438
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT15_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x43C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT16_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT17_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x444
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT18_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x448
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT19_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT20_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT21_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x454
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT22_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x458
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT23_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT24_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x460
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT25_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT26_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x468
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT27_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x46C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT28_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x470
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT29_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x474
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT30_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x478
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT31_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x47C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT32_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x480
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT33_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x484
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT34_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x488
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT35_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x48C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT36_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT37_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT38_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT39_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT40_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT41_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4A4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT42_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4A8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT43_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4AC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT44_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4B0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT45_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4B4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT46_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4B8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT47_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4BC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT48_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4C0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT49_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4C4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT50_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4C8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT51_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT52_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT53_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4D4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT54_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4D8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT55_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT56_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4E0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT57_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT58_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4E8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT59_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4EC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT60_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4F0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT61_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4F4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT62_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4F8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT63_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x4FC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT64_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT65_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT66_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT67_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT68_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT69_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT70_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT71_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT72_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT73_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT74_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT75_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT76_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT77_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT78_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x538
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT79_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x53C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT80_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT81_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT82_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT83_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT84_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT85_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT86_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x558
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT87_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT88_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT89_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT90_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT91_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT92_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT93_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT94_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x578
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT95_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x57C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT96_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT97_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT98_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT99_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT100_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT101_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT102_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x598
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT103_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT104_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT105_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT106_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT107_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT108_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT109_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT110_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5B8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT111_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5BC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT112_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT113_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT114_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT115_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT116_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT117_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT118_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5D8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT119_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT120_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT121_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT122_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT123_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5EC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT124_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT125_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT126_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5F8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT127_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x5FC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT128_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT129_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT130_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT131_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT132_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT133_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT134_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT135_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT136_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT137_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT138_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT139_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT140_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT141_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT142_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x638
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT143_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x63C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT144_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT145_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT146_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT147_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT148_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT149_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT150_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x658
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT151_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT152_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT153_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT154_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT155_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT156_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT157_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT158_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x678
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT159_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x67C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT160_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x680
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT161_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x684
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT162_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x688
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT163_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x68C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT164_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT165_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT166_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x698
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT167_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT168_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT169_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT170_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT171_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6AC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT172_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT173_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT174_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6B8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT175_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6BC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT176_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT177_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT178_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT179_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT180_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT181_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT182_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6D8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT183_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT184_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT185_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT186_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT187_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6EC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT188_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT189_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6F4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT190_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6F8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT191_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x6FC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT192_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT193_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT194_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT195_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x70C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT196_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT197_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x714
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT198_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x718
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT199_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x71C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT200_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x720
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT201_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x724
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT202_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x728
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT203_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x72C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT204_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x730
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT205_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x734
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT206_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x738
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT207_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x73C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT208_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x740
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT209_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x744
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT210_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x748
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT211_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT212_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT213_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x754
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT214_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x758
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT215_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x75C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT216_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x760
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT217_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x764
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT218_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x768
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT219_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x76C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT220_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x770
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT221_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x774
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT222_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x778
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT223_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x77C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT224_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x780
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT225_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x784
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT226_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x788
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT227_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x78C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT228_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x790
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT229_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT230_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT231_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x79C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT232_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7A0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT233_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7A4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT234_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7A8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT235_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7AC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT236_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7B0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT237_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7B4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT238_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7B8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT239_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7BC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT240_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7C0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT241_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT242_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7C8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT243_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7CC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT244_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7D0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT245_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7D4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT246_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7D8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT247_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7DC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT248_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7E0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT249_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7E4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT250_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7E8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT251_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7EC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT252_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7F0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT253_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7F4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT254_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7F8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_FGCLUT255_DEF
    \
    \ @brief DMA2D foreground CLUT
    \ Address offset: 0x7FC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT0_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x800
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT1_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x804
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT2_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x808
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT3_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x80C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT4_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT5_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT6_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT7_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT8_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x820
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT9_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x824
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT10_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x828
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT11_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x82C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT12_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x830
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT13_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x834
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT14_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x838
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT15_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x83C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT16_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x840
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT17_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x844
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT18_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x848
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT19_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x84C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT20_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x850
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT21_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x854
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT22_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x858
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT23_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x85C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT24_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x860
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT25_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x864
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT26_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x868
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT27_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x86C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT28_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x870
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT29_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x874
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT30_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x878
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT31_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x87C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT32_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x880
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT33_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x884
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT34_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x888
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT35_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x88C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT36_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x890
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT37_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x894
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT38_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x898
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT39_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x89C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT40_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8A0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT41_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8A4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT42_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8A8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT43_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8AC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT44_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8B0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT45_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8B4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT46_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8B8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT47_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8BC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT48_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8C0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT49_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8C4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT50_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8C8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT51_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8CC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT52_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8D0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT53_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8D4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT54_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8D8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT55_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8DC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT56_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8E0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT57_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8E4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT58_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8E8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT59_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8EC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT60_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8F0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT61_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8F4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT62_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8F8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT63_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x8FC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT64_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT65_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x904
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT66_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x908
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT67_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x90C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT68_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT69_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT70_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x918
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT71_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x91C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT72_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x920
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT73_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x924
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT74_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x928
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT75_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x92C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT76_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT77_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT78_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x938
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT79_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x93C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT80_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT81_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x944
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT82_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x948
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT83_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x94C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT84_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x950
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT85_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x954
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT86_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x958
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT87_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x95C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT88_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x960
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT89_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x964
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT90_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x968
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT91_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x96C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT92_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x970
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT93_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x974
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT94_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x978
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT95_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x97C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT96_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x980
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT97_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x984
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT98_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x988
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT99_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x98C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT100_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x990
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT101_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x994
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT102_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x998
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT103_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x99C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT104_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9A0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT105_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9A4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT106_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9A8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT107_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9AC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT108_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9B0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT109_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9B4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT110_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9B8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT111_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9BC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT112_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9C0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT113_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9C4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT114_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9C8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT115_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9CC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT116_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9D0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT117_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9D4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT118_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9D8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT119_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9DC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT120_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9E0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT121_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9E4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT122_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9E8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT123_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9EC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT124_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9F0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT125_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9F4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT126_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9F8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT127_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0x9FC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT128_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA00
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT129_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA04
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT130_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA08
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT131_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT132_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA10
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT133_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA14
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT134_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA18
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT135_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT136_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA20
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT137_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA24
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT138_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA28
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT139_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA2C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT140_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA30
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT141_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA34
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT142_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA38
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT143_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT144_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA40
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT145_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA44
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT146_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA48
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT147_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT148_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA50
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT149_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA54
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT150_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA58
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT151_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT152_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA60
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT153_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA64
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT154_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA68
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT155_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA6C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT156_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA70
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT157_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA74
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT158_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA78
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT159_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA7C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT160_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA80
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT161_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA84
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT162_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA88
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT163_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA8C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT164_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA90
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT165_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA94
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT166_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA98
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT167_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xA9C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT168_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAA0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT169_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAA4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT170_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAA8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT171_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAAC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT172_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAB0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT173_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAB4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT174_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAB8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT175_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xABC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT176_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAC0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT177_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAC4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT178_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAC8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT179_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xACC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT180_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAD0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT181_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAD4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT182_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAD8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT183_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xADC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT184_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAE0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT185_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAE4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT186_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAE8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT187_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAEC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT188_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAF0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT189_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAF4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT190_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAF8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT191_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xAFC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT192_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB00
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT193_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB04
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT194_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB08
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT195_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT196_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT197_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT198_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB18
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT199_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT200_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT201_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB24
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT202_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB28
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT203_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB2C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT204_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT205_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT206_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB38
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT207_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT208_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT209_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB44
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT210_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB48
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT211_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT212_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT213_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT214_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB58
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT215_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT216_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB60
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT217_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB64
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT218_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB68
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT219_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB6C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT220_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT221_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB74
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT222_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB78
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT223_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB7C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT224_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT225_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB84
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT226_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB88
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT227_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB8C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT228_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB90
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT229_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB94
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT230_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB98
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT231_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xB9C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT232_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBA0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT233_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBA4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT234_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBA8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT235_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBAC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT236_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBB0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT237_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBB4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT238_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBB8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT239_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBBC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT240_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT241_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBC4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT242_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBC8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT243_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBCC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT244_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBD0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT245_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBD4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT246_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBD8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT247_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBDC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT248_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBE0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT249_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBE4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT250_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBE8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT251_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBEC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT252_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBF0
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT253_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBF4
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT254_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBF8
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]


  [ifdef] DMA2D_DMA2D_BGCLUT255_DEF
    \
    \ @brief DMA2D background CLUT
    \ Address offset: 0xBFC
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha
  [then]

  \
  \ @brief Chrom-ART Accelerator controller
  \
  $00 constant DMA2D_DMA2D_CR           \ DMA2D control register
  $04 constant DMA2D_DMA2D_ISR          \ DMA2D interrupt status register
  $08 constant DMA2D_DMA2D_IFCR         \ DMA2D interrupt flag clear register
  $0C constant DMA2D_DMA2D_FGMAR        \ DMA2D foreground memory address register
  $10 constant DMA2D_DMA2D_FGOR         \ DMA2D foreground offset register
  $14 constant DMA2D_DMA2D_BGMAR        \ DMA2D background memory address register
  $18 constant DMA2D_DMA2D_BGOR         \ DMA2D background offset register
  $1C constant DMA2D_DMA2D_FGPFCCR      \ DMA2D foreground PFC control register
  $20 constant DMA2D_DMA2D_FGCOLR       \ DMA2D foreground color register
  $24 constant DMA2D_DMA2D_BGPFCCR      \ DMA2D background PFC control register
  $28 constant DMA2D_DMA2D_BGCOLR       \ DMA2D background color register
  $2C constant DMA2D_DMA2D_FGCMAR       \ DMA2D foreground CLUT memory address register
  $30 constant DMA2D_DMA2D_BGCMAR       \ DMA2D background CLUT memory address register
  $34 constant DMA2D_DMA2D_OPFCCR       \ DMA2D output PFC control register
  $38 constant DMA2D_DMA2D_OCOLR_RGB888 \ DMA2D output color register
  $38 constant DMA2D_DMA2D_OCOLR_RGB565 \ DMA2D output color register
  $38 constant DMA2D_DMA2D_OCOLR_ARGB1555    \ DMA2D output color register
  $38 constant DMA2D_DMA2D_OCOLR_ARGB4444    \ DMA2D output color register
  $3C constant DMA2D_DMA2D_OMAR         \ DMA2D output memory address register
  $40 constant DMA2D_DMA2D_OOR          \ DMA2D output offset register
  $44 constant DMA2D_DMA2D_NLR          \ DMA2D number of line register
  $48 constant DMA2D_DMA2D_LWR          \ DMA2D line watermark register
  $4C constant DMA2D_DMA2D_AMTCR        \ DMA2D AXI master timer configuration register
  $400 constant DMA2D_DMA2D_FGCLUT0     \ DMA2D foreground CLUT
  $404 constant DMA2D_DMA2D_FGCLUT1     \ DMA2D foreground CLUT
  $408 constant DMA2D_DMA2D_FGCLUT2     \ DMA2D foreground CLUT
  $40C constant DMA2D_DMA2D_FGCLUT3     \ DMA2D foreground CLUT
  $410 constant DMA2D_DMA2D_FGCLUT4     \ DMA2D foreground CLUT
  $414 constant DMA2D_DMA2D_FGCLUT5     \ DMA2D foreground CLUT
  $418 constant DMA2D_DMA2D_FGCLUT6     \ DMA2D foreground CLUT
  $41C constant DMA2D_DMA2D_FGCLUT7     \ DMA2D foreground CLUT
  $420 constant DMA2D_DMA2D_FGCLUT8     \ DMA2D foreground CLUT
  $424 constant DMA2D_DMA2D_FGCLUT9     \ DMA2D foreground CLUT
  $428 constant DMA2D_DMA2D_FGCLUT10    \ DMA2D foreground CLUT
  $42C constant DMA2D_DMA2D_FGCLUT11    \ DMA2D foreground CLUT
  $430 constant DMA2D_DMA2D_FGCLUT12    \ DMA2D foreground CLUT
  $434 constant DMA2D_DMA2D_FGCLUT13    \ DMA2D foreground CLUT
  $438 constant DMA2D_DMA2D_FGCLUT14    \ DMA2D foreground CLUT
  $43C constant DMA2D_DMA2D_FGCLUT15    \ DMA2D foreground CLUT
  $440 constant DMA2D_DMA2D_FGCLUT16    \ DMA2D foreground CLUT
  $444 constant DMA2D_DMA2D_FGCLUT17    \ DMA2D foreground CLUT
  $448 constant DMA2D_DMA2D_FGCLUT18    \ DMA2D foreground CLUT
  $44C constant DMA2D_DMA2D_FGCLUT19    \ DMA2D foreground CLUT
  $450 constant DMA2D_DMA2D_FGCLUT20    \ DMA2D foreground CLUT
  $454 constant DMA2D_DMA2D_FGCLUT21    \ DMA2D foreground CLUT
  $458 constant DMA2D_DMA2D_FGCLUT22    \ DMA2D foreground CLUT
  $45C constant DMA2D_DMA2D_FGCLUT23    \ DMA2D foreground CLUT
  $460 constant DMA2D_DMA2D_FGCLUT24    \ DMA2D foreground CLUT
  $464 constant DMA2D_DMA2D_FGCLUT25    \ DMA2D foreground CLUT
  $468 constant DMA2D_DMA2D_FGCLUT26    \ DMA2D foreground CLUT
  $46C constant DMA2D_DMA2D_FGCLUT27    \ DMA2D foreground CLUT
  $470 constant DMA2D_DMA2D_FGCLUT28    \ DMA2D foreground CLUT
  $474 constant DMA2D_DMA2D_FGCLUT29    \ DMA2D foreground CLUT
  $478 constant DMA2D_DMA2D_FGCLUT30    \ DMA2D foreground CLUT
  $47C constant DMA2D_DMA2D_FGCLUT31    \ DMA2D foreground CLUT
  $480 constant DMA2D_DMA2D_FGCLUT32    \ DMA2D foreground CLUT
  $484 constant DMA2D_DMA2D_FGCLUT33    \ DMA2D foreground CLUT
  $488 constant DMA2D_DMA2D_FGCLUT34    \ DMA2D foreground CLUT
  $48C constant DMA2D_DMA2D_FGCLUT35    \ DMA2D foreground CLUT
  $490 constant DMA2D_DMA2D_FGCLUT36    \ DMA2D foreground CLUT
  $494 constant DMA2D_DMA2D_FGCLUT37    \ DMA2D foreground CLUT
  $498 constant DMA2D_DMA2D_FGCLUT38    \ DMA2D foreground CLUT
  $49C constant DMA2D_DMA2D_FGCLUT39    \ DMA2D foreground CLUT
  $4A0 constant DMA2D_DMA2D_FGCLUT40    \ DMA2D foreground CLUT
  $4A4 constant DMA2D_DMA2D_FGCLUT41    \ DMA2D foreground CLUT
  $4A8 constant DMA2D_DMA2D_FGCLUT42    \ DMA2D foreground CLUT
  $4AC constant DMA2D_DMA2D_FGCLUT43    \ DMA2D foreground CLUT
  $4B0 constant DMA2D_DMA2D_FGCLUT44    \ DMA2D foreground CLUT
  $4B4 constant DMA2D_DMA2D_FGCLUT45    \ DMA2D foreground CLUT
  $4B8 constant DMA2D_DMA2D_FGCLUT46    \ DMA2D foreground CLUT
  $4BC constant DMA2D_DMA2D_FGCLUT47    \ DMA2D foreground CLUT
  $4C0 constant DMA2D_DMA2D_FGCLUT48    \ DMA2D foreground CLUT
  $4C4 constant DMA2D_DMA2D_FGCLUT49    \ DMA2D foreground CLUT
  $4C8 constant DMA2D_DMA2D_FGCLUT50    \ DMA2D foreground CLUT
  $4CC constant DMA2D_DMA2D_FGCLUT51    \ DMA2D foreground CLUT
  $4D0 constant DMA2D_DMA2D_FGCLUT52    \ DMA2D foreground CLUT
  $4D4 constant DMA2D_DMA2D_FGCLUT53    \ DMA2D foreground CLUT
  $4D8 constant DMA2D_DMA2D_FGCLUT54    \ DMA2D foreground CLUT
  $4DC constant DMA2D_DMA2D_FGCLUT55    \ DMA2D foreground CLUT
  $4E0 constant DMA2D_DMA2D_FGCLUT56    \ DMA2D foreground CLUT
  $4E4 constant DMA2D_DMA2D_FGCLUT57    \ DMA2D foreground CLUT
  $4E8 constant DMA2D_DMA2D_FGCLUT58    \ DMA2D foreground CLUT
  $4EC constant DMA2D_DMA2D_FGCLUT59    \ DMA2D foreground CLUT
  $4F0 constant DMA2D_DMA2D_FGCLUT60    \ DMA2D foreground CLUT
  $4F4 constant DMA2D_DMA2D_FGCLUT61    \ DMA2D foreground CLUT
  $4F8 constant DMA2D_DMA2D_FGCLUT62    \ DMA2D foreground CLUT
  $4FC constant DMA2D_DMA2D_FGCLUT63    \ DMA2D foreground CLUT
  $500 constant DMA2D_DMA2D_FGCLUT64    \ DMA2D foreground CLUT
  $504 constant DMA2D_DMA2D_FGCLUT65    \ DMA2D foreground CLUT
  $508 constant DMA2D_DMA2D_FGCLUT66    \ DMA2D foreground CLUT
  $50C constant DMA2D_DMA2D_FGCLUT67    \ DMA2D foreground CLUT
  $510 constant DMA2D_DMA2D_FGCLUT68    \ DMA2D foreground CLUT
  $514 constant DMA2D_DMA2D_FGCLUT69    \ DMA2D foreground CLUT
  $518 constant DMA2D_DMA2D_FGCLUT70    \ DMA2D foreground CLUT
  $51C constant DMA2D_DMA2D_FGCLUT71    \ DMA2D foreground CLUT
  $520 constant DMA2D_DMA2D_FGCLUT72    \ DMA2D foreground CLUT
  $524 constant DMA2D_DMA2D_FGCLUT73    \ DMA2D foreground CLUT
  $528 constant DMA2D_DMA2D_FGCLUT74    \ DMA2D foreground CLUT
  $52C constant DMA2D_DMA2D_FGCLUT75    \ DMA2D foreground CLUT
  $530 constant DMA2D_DMA2D_FGCLUT76    \ DMA2D foreground CLUT
  $534 constant DMA2D_DMA2D_FGCLUT77    \ DMA2D foreground CLUT
  $538 constant DMA2D_DMA2D_FGCLUT78    \ DMA2D foreground CLUT
  $53C constant DMA2D_DMA2D_FGCLUT79    \ DMA2D foreground CLUT
  $540 constant DMA2D_DMA2D_FGCLUT80    \ DMA2D foreground CLUT
  $544 constant DMA2D_DMA2D_FGCLUT81    \ DMA2D foreground CLUT
  $548 constant DMA2D_DMA2D_FGCLUT82    \ DMA2D foreground CLUT
  $54C constant DMA2D_DMA2D_FGCLUT83    \ DMA2D foreground CLUT
  $550 constant DMA2D_DMA2D_FGCLUT84    \ DMA2D foreground CLUT
  $554 constant DMA2D_DMA2D_FGCLUT85    \ DMA2D foreground CLUT
  $558 constant DMA2D_DMA2D_FGCLUT86    \ DMA2D foreground CLUT
  $55C constant DMA2D_DMA2D_FGCLUT87    \ DMA2D foreground CLUT
  $560 constant DMA2D_DMA2D_FGCLUT88    \ DMA2D foreground CLUT
  $564 constant DMA2D_DMA2D_FGCLUT89    \ DMA2D foreground CLUT
  $568 constant DMA2D_DMA2D_FGCLUT90    \ DMA2D foreground CLUT
  $56C constant DMA2D_DMA2D_FGCLUT91    \ DMA2D foreground CLUT
  $570 constant DMA2D_DMA2D_FGCLUT92    \ DMA2D foreground CLUT
  $574 constant DMA2D_DMA2D_FGCLUT93    \ DMA2D foreground CLUT
  $578 constant DMA2D_DMA2D_FGCLUT94    \ DMA2D foreground CLUT
  $57C constant DMA2D_DMA2D_FGCLUT95    \ DMA2D foreground CLUT
  $580 constant DMA2D_DMA2D_FGCLUT96    \ DMA2D foreground CLUT
  $584 constant DMA2D_DMA2D_FGCLUT97    \ DMA2D foreground CLUT
  $588 constant DMA2D_DMA2D_FGCLUT98    \ DMA2D foreground CLUT
  $58C constant DMA2D_DMA2D_FGCLUT99    \ DMA2D foreground CLUT
  $590 constant DMA2D_DMA2D_FGCLUT100   \ DMA2D foreground CLUT
  $594 constant DMA2D_DMA2D_FGCLUT101   \ DMA2D foreground CLUT
  $598 constant DMA2D_DMA2D_FGCLUT102   \ DMA2D foreground CLUT
  $59C constant DMA2D_DMA2D_FGCLUT103   \ DMA2D foreground CLUT
  $5A0 constant DMA2D_DMA2D_FGCLUT104   \ DMA2D foreground CLUT
  $5A4 constant DMA2D_DMA2D_FGCLUT105   \ DMA2D foreground CLUT
  $5A8 constant DMA2D_DMA2D_FGCLUT106   \ DMA2D foreground CLUT
  $5AC constant DMA2D_DMA2D_FGCLUT107   \ DMA2D foreground CLUT
  $5B0 constant DMA2D_DMA2D_FGCLUT108   \ DMA2D foreground CLUT
  $5B4 constant DMA2D_DMA2D_FGCLUT109   \ DMA2D foreground CLUT
  $5B8 constant DMA2D_DMA2D_FGCLUT110   \ DMA2D foreground CLUT
  $5BC constant DMA2D_DMA2D_FGCLUT111   \ DMA2D foreground CLUT
  $5C0 constant DMA2D_DMA2D_FGCLUT112   \ DMA2D foreground CLUT
  $5C4 constant DMA2D_DMA2D_FGCLUT113   \ DMA2D foreground CLUT
  $5C8 constant DMA2D_DMA2D_FGCLUT114   \ DMA2D foreground CLUT
  $5CC constant DMA2D_DMA2D_FGCLUT115   \ DMA2D foreground CLUT
  $5D0 constant DMA2D_DMA2D_FGCLUT116   \ DMA2D foreground CLUT
  $5D4 constant DMA2D_DMA2D_FGCLUT117   \ DMA2D foreground CLUT
  $5D8 constant DMA2D_DMA2D_FGCLUT118   \ DMA2D foreground CLUT
  $5DC constant DMA2D_DMA2D_FGCLUT119   \ DMA2D foreground CLUT
  $5E0 constant DMA2D_DMA2D_FGCLUT120   \ DMA2D foreground CLUT
  $5E4 constant DMA2D_DMA2D_FGCLUT121   \ DMA2D foreground CLUT
  $5E8 constant DMA2D_DMA2D_FGCLUT122   \ DMA2D foreground CLUT
  $5EC constant DMA2D_DMA2D_FGCLUT123   \ DMA2D foreground CLUT
  $5F0 constant DMA2D_DMA2D_FGCLUT124   \ DMA2D foreground CLUT
  $5F4 constant DMA2D_DMA2D_FGCLUT125   \ DMA2D foreground CLUT
  $5F8 constant DMA2D_DMA2D_FGCLUT126   \ DMA2D foreground CLUT
  $5FC constant DMA2D_DMA2D_FGCLUT127   \ DMA2D foreground CLUT
  $600 constant DMA2D_DMA2D_FGCLUT128   \ DMA2D foreground CLUT
  $604 constant DMA2D_DMA2D_FGCLUT129   \ DMA2D foreground CLUT
  $608 constant DMA2D_DMA2D_FGCLUT130   \ DMA2D foreground CLUT
  $60C constant DMA2D_DMA2D_FGCLUT131   \ DMA2D foreground CLUT
  $610 constant DMA2D_DMA2D_FGCLUT132   \ DMA2D foreground CLUT
  $614 constant DMA2D_DMA2D_FGCLUT133   \ DMA2D foreground CLUT
  $618 constant DMA2D_DMA2D_FGCLUT134   \ DMA2D foreground CLUT
  $61C constant DMA2D_DMA2D_FGCLUT135   \ DMA2D foreground CLUT
  $620 constant DMA2D_DMA2D_FGCLUT136   \ DMA2D foreground CLUT
  $624 constant DMA2D_DMA2D_FGCLUT137   \ DMA2D foreground CLUT
  $628 constant DMA2D_DMA2D_FGCLUT138   \ DMA2D foreground CLUT
  $62C constant DMA2D_DMA2D_FGCLUT139   \ DMA2D foreground CLUT
  $630 constant DMA2D_DMA2D_FGCLUT140   \ DMA2D foreground CLUT
  $634 constant DMA2D_DMA2D_FGCLUT141   \ DMA2D foreground CLUT
  $638 constant DMA2D_DMA2D_FGCLUT142   \ DMA2D foreground CLUT
  $63C constant DMA2D_DMA2D_FGCLUT143   \ DMA2D foreground CLUT
  $640 constant DMA2D_DMA2D_FGCLUT144   \ DMA2D foreground CLUT
  $644 constant DMA2D_DMA2D_FGCLUT145   \ DMA2D foreground CLUT
  $648 constant DMA2D_DMA2D_FGCLUT146   \ DMA2D foreground CLUT
  $64C constant DMA2D_DMA2D_FGCLUT147   \ DMA2D foreground CLUT
  $650 constant DMA2D_DMA2D_FGCLUT148   \ DMA2D foreground CLUT
  $654 constant DMA2D_DMA2D_FGCLUT149   \ DMA2D foreground CLUT
  $658 constant DMA2D_DMA2D_FGCLUT150   \ DMA2D foreground CLUT
  $65C constant DMA2D_DMA2D_FGCLUT151   \ DMA2D foreground CLUT
  $660 constant DMA2D_DMA2D_FGCLUT152   \ DMA2D foreground CLUT
  $664 constant DMA2D_DMA2D_FGCLUT153   \ DMA2D foreground CLUT
  $668 constant DMA2D_DMA2D_FGCLUT154   \ DMA2D foreground CLUT
  $66C constant DMA2D_DMA2D_FGCLUT155   \ DMA2D foreground CLUT
  $670 constant DMA2D_DMA2D_FGCLUT156   \ DMA2D foreground CLUT
  $674 constant DMA2D_DMA2D_FGCLUT157   \ DMA2D foreground CLUT
  $678 constant DMA2D_DMA2D_FGCLUT158   \ DMA2D foreground CLUT
  $67C constant DMA2D_DMA2D_FGCLUT159   \ DMA2D foreground CLUT
  $680 constant DMA2D_DMA2D_FGCLUT160   \ DMA2D foreground CLUT
  $684 constant DMA2D_DMA2D_FGCLUT161   \ DMA2D foreground CLUT
  $688 constant DMA2D_DMA2D_FGCLUT162   \ DMA2D foreground CLUT
  $68C constant DMA2D_DMA2D_FGCLUT163   \ DMA2D foreground CLUT
  $690 constant DMA2D_DMA2D_FGCLUT164   \ DMA2D foreground CLUT
  $694 constant DMA2D_DMA2D_FGCLUT165   \ DMA2D foreground CLUT
  $698 constant DMA2D_DMA2D_FGCLUT166   \ DMA2D foreground CLUT
  $69C constant DMA2D_DMA2D_FGCLUT167   \ DMA2D foreground CLUT
  $6A0 constant DMA2D_DMA2D_FGCLUT168   \ DMA2D foreground CLUT
  $6A4 constant DMA2D_DMA2D_FGCLUT169   \ DMA2D foreground CLUT
  $6A8 constant DMA2D_DMA2D_FGCLUT170   \ DMA2D foreground CLUT
  $6AC constant DMA2D_DMA2D_FGCLUT171   \ DMA2D foreground CLUT
  $6B0 constant DMA2D_DMA2D_FGCLUT172   \ DMA2D foreground CLUT
  $6B4 constant DMA2D_DMA2D_FGCLUT173   \ DMA2D foreground CLUT
  $6B8 constant DMA2D_DMA2D_FGCLUT174   \ DMA2D foreground CLUT
  $6BC constant DMA2D_DMA2D_FGCLUT175   \ DMA2D foreground CLUT
  $6C0 constant DMA2D_DMA2D_FGCLUT176   \ DMA2D foreground CLUT
  $6C4 constant DMA2D_DMA2D_FGCLUT177   \ DMA2D foreground CLUT
  $6C8 constant DMA2D_DMA2D_FGCLUT178   \ DMA2D foreground CLUT
  $6CC constant DMA2D_DMA2D_FGCLUT179   \ DMA2D foreground CLUT
  $6D0 constant DMA2D_DMA2D_FGCLUT180   \ DMA2D foreground CLUT
  $6D4 constant DMA2D_DMA2D_FGCLUT181   \ DMA2D foreground CLUT
  $6D8 constant DMA2D_DMA2D_FGCLUT182   \ DMA2D foreground CLUT
  $6DC constant DMA2D_DMA2D_FGCLUT183   \ DMA2D foreground CLUT
  $6E0 constant DMA2D_DMA2D_FGCLUT184   \ DMA2D foreground CLUT
  $6E4 constant DMA2D_DMA2D_FGCLUT185   \ DMA2D foreground CLUT
  $6E8 constant DMA2D_DMA2D_FGCLUT186   \ DMA2D foreground CLUT
  $6EC constant DMA2D_DMA2D_FGCLUT187   \ DMA2D foreground CLUT
  $6F0 constant DMA2D_DMA2D_FGCLUT188   \ DMA2D foreground CLUT
  $6F4 constant DMA2D_DMA2D_FGCLUT189   \ DMA2D foreground CLUT
  $6F8 constant DMA2D_DMA2D_FGCLUT190   \ DMA2D foreground CLUT
  $6FC constant DMA2D_DMA2D_FGCLUT191   \ DMA2D foreground CLUT
  $700 constant DMA2D_DMA2D_FGCLUT192   \ DMA2D foreground CLUT
  $704 constant DMA2D_DMA2D_FGCLUT193   \ DMA2D foreground CLUT
  $708 constant DMA2D_DMA2D_FGCLUT194   \ DMA2D foreground CLUT
  $70C constant DMA2D_DMA2D_FGCLUT195   \ DMA2D foreground CLUT
  $710 constant DMA2D_DMA2D_FGCLUT196   \ DMA2D foreground CLUT
  $714 constant DMA2D_DMA2D_FGCLUT197   \ DMA2D foreground CLUT
  $718 constant DMA2D_DMA2D_FGCLUT198   \ DMA2D foreground CLUT
  $71C constant DMA2D_DMA2D_FGCLUT199   \ DMA2D foreground CLUT
  $720 constant DMA2D_DMA2D_FGCLUT200   \ DMA2D foreground CLUT
  $724 constant DMA2D_DMA2D_FGCLUT201   \ DMA2D foreground CLUT
  $728 constant DMA2D_DMA2D_FGCLUT202   \ DMA2D foreground CLUT
  $72C constant DMA2D_DMA2D_FGCLUT203   \ DMA2D foreground CLUT
  $730 constant DMA2D_DMA2D_FGCLUT204   \ DMA2D foreground CLUT
  $734 constant DMA2D_DMA2D_FGCLUT205   \ DMA2D foreground CLUT
  $738 constant DMA2D_DMA2D_FGCLUT206   \ DMA2D foreground CLUT
  $73C constant DMA2D_DMA2D_FGCLUT207   \ DMA2D foreground CLUT
  $740 constant DMA2D_DMA2D_FGCLUT208   \ DMA2D foreground CLUT
  $744 constant DMA2D_DMA2D_FGCLUT209   \ DMA2D foreground CLUT
  $748 constant DMA2D_DMA2D_FGCLUT210   \ DMA2D foreground CLUT
  $74C constant DMA2D_DMA2D_FGCLUT211   \ DMA2D foreground CLUT
  $750 constant DMA2D_DMA2D_FGCLUT212   \ DMA2D foreground CLUT
  $754 constant DMA2D_DMA2D_FGCLUT213   \ DMA2D foreground CLUT
  $758 constant DMA2D_DMA2D_FGCLUT214   \ DMA2D foreground CLUT
  $75C constant DMA2D_DMA2D_FGCLUT215   \ DMA2D foreground CLUT
  $760 constant DMA2D_DMA2D_FGCLUT216   \ DMA2D foreground CLUT
  $764 constant DMA2D_DMA2D_FGCLUT217   \ DMA2D foreground CLUT
  $768 constant DMA2D_DMA2D_FGCLUT218   \ DMA2D foreground CLUT
  $76C constant DMA2D_DMA2D_FGCLUT219   \ DMA2D foreground CLUT
  $770 constant DMA2D_DMA2D_FGCLUT220   \ DMA2D foreground CLUT
  $774 constant DMA2D_DMA2D_FGCLUT221   \ DMA2D foreground CLUT
  $778 constant DMA2D_DMA2D_FGCLUT222   \ DMA2D foreground CLUT
  $77C constant DMA2D_DMA2D_FGCLUT223   \ DMA2D foreground CLUT
  $780 constant DMA2D_DMA2D_FGCLUT224   \ DMA2D foreground CLUT
  $784 constant DMA2D_DMA2D_FGCLUT225   \ DMA2D foreground CLUT
  $788 constant DMA2D_DMA2D_FGCLUT226   \ DMA2D foreground CLUT
  $78C constant DMA2D_DMA2D_FGCLUT227   \ DMA2D foreground CLUT
  $790 constant DMA2D_DMA2D_FGCLUT228   \ DMA2D foreground CLUT
  $794 constant DMA2D_DMA2D_FGCLUT229   \ DMA2D foreground CLUT
  $798 constant DMA2D_DMA2D_FGCLUT230   \ DMA2D foreground CLUT
  $79C constant DMA2D_DMA2D_FGCLUT231   \ DMA2D foreground CLUT
  $7A0 constant DMA2D_DMA2D_FGCLUT232   \ DMA2D foreground CLUT
  $7A4 constant DMA2D_DMA2D_FGCLUT233   \ DMA2D foreground CLUT
  $7A8 constant DMA2D_DMA2D_FGCLUT234   \ DMA2D foreground CLUT
  $7AC constant DMA2D_DMA2D_FGCLUT235   \ DMA2D foreground CLUT
  $7B0 constant DMA2D_DMA2D_FGCLUT236   \ DMA2D foreground CLUT
  $7B4 constant DMA2D_DMA2D_FGCLUT237   \ DMA2D foreground CLUT
  $7B8 constant DMA2D_DMA2D_FGCLUT238   \ DMA2D foreground CLUT
  $7BC constant DMA2D_DMA2D_FGCLUT239   \ DMA2D foreground CLUT
  $7C0 constant DMA2D_DMA2D_FGCLUT240   \ DMA2D foreground CLUT
  $7C4 constant DMA2D_DMA2D_FGCLUT241   \ DMA2D foreground CLUT
  $7C8 constant DMA2D_DMA2D_FGCLUT242   \ DMA2D foreground CLUT
  $7CC constant DMA2D_DMA2D_FGCLUT243   \ DMA2D foreground CLUT
  $7D0 constant DMA2D_DMA2D_FGCLUT244   \ DMA2D foreground CLUT
  $7D4 constant DMA2D_DMA2D_FGCLUT245   \ DMA2D foreground CLUT
  $7D8 constant DMA2D_DMA2D_FGCLUT246   \ DMA2D foreground CLUT
  $7DC constant DMA2D_DMA2D_FGCLUT247   \ DMA2D foreground CLUT
  $7E0 constant DMA2D_DMA2D_FGCLUT248   \ DMA2D foreground CLUT
  $7E4 constant DMA2D_DMA2D_FGCLUT249   \ DMA2D foreground CLUT
  $7E8 constant DMA2D_DMA2D_FGCLUT250   \ DMA2D foreground CLUT
  $7EC constant DMA2D_DMA2D_FGCLUT251   \ DMA2D foreground CLUT
  $7F0 constant DMA2D_DMA2D_FGCLUT252   \ DMA2D foreground CLUT
  $7F4 constant DMA2D_DMA2D_FGCLUT253   \ DMA2D foreground CLUT
  $7F8 constant DMA2D_DMA2D_FGCLUT254   \ DMA2D foreground CLUT
  $7FC constant DMA2D_DMA2D_FGCLUT255   \ DMA2D foreground CLUT
  $800 constant DMA2D_DMA2D_BGCLUT0     \ DMA2D background CLUT
  $804 constant DMA2D_DMA2D_BGCLUT1     \ DMA2D background CLUT
  $808 constant DMA2D_DMA2D_BGCLUT2     \ DMA2D background CLUT
  $80C constant DMA2D_DMA2D_BGCLUT3     \ DMA2D background CLUT
  $810 constant DMA2D_DMA2D_BGCLUT4     \ DMA2D background CLUT
  $814 constant DMA2D_DMA2D_BGCLUT5     \ DMA2D background CLUT
  $818 constant DMA2D_DMA2D_BGCLUT6     \ DMA2D background CLUT
  $81C constant DMA2D_DMA2D_BGCLUT7     \ DMA2D background CLUT
  $820 constant DMA2D_DMA2D_BGCLUT8     \ DMA2D background CLUT
  $824 constant DMA2D_DMA2D_BGCLUT9     \ DMA2D background CLUT
  $828 constant DMA2D_DMA2D_BGCLUT10    \ DMA2D background CLUT
  $82C constant DMA2D_DMA2D_BGCLUT11    \ DMA2D background CLUT
  $830 constant DMA2D_DMA2D_BGCLUT12    \ DMA2D background CLUT
  $834 constant DMA2D_DMA2D_BGCLUT13    \ DMA2D background CLUT
  $838 constant DMA2D_DMA2D_BGCLUT14    \ DMA2D background CLUT
  $83C constant DMA2D_DMA2D_BGCLUT15    \ DMA2D background CLUT
  $840 constant DMA2D_DMA2D_BGCLUT16    \ DMA2D background CLUT
  $844 constant DMA2D_DMA2D_BGCLUT17    \ DMA2D background CLUT
  $848 constant DMA2D_DMA2D_BGCLUT18    \ DMA2D background CLUT
  $84C constant DMA2D_DMA2D_BGCLUT19    \ DMA2D background CLUT
  $850 constant DMA2D_DMA2D_BGCLUT20    \ DMA2D background CLUT
  $854 constant DMA2D_DMA2D_BGCLUT21    \ DMA2D background CLUT
  $858 constant DMA2D_DMA2D_BGCLUT22    \ DMA2D background CLUT
  $85C constant DMA2D_DMA2D_BGCLUT23    \ DMA2D background CLUT
  $860 constant DMA2D_DMA2D_BGCLUT24    \ DMA2D background CLUT
  $864 constant DMA2D_DMA2D_BGCLUT25    \ DMA2D background CLUT
  $868 constant DMA2D_DMA2D_BGCLUT26    \ DMA2D background CLUT
  $86C constant DMA2D_DMA2D_BGCLUT27    \ DMA2D background CLUT
  $870 constant DMA2D_DMA2D_BGCLUT28    \ DMA2D background CLUT
  $874 constant DMA2D_DMA2D_BGCLUT29    \ DMA2D background CLUT
  $878 constant DMA2D_DMA2D_BGCLUT30    \ DMA2D background CLUT
  $87C constant DMA2D_DMA2D_BGCLUT31    \ DMA2D background CLUT
  $880 constant DMA2D_DMA2D_BGCLUT32    \ DMA2D background CLUT
  $884 constant DMA2D_DMA2D_BGCLUT33    \ DMA2D background CLUT
  $888 constant DMA2D_DMA2D_BGCLUT34    \ DMA2D background CLUT
  $88C constant DMA2D_DMA2D_BGCLUT35    \ DMA2D background CLUT
  $890 constant DMA2D_DMA2D_BGCLUT36    \ DMA2D background CLUT
  $894 constant DMA2D_DMA2D_BGCLUT37    \ DMA2D background CLUT
  $898 constant DMA2D_DMA2D_BGCLUT38    \ DMA2D background CLUT
  $89C constant DMA2D_DMA2D_BGCLUT39    \ DMA2D background CLUT
  $8A0 constant DMA2D_DMA2D_BGCLUT40    \ DMA2D background CLUT
  $8A4 constant DMA2D_DMA2D_BGCLUT41    \ DMA2D background CLUT
  $8A8 constant DMA2D_DMA2D_BGCLUT42    \ DMA2D background CLUT
  $8AC constant DMA2D_DMA2D_BGCLUT43    \ DMA2D background CLUT
  $8B0 constant DMA2D_DMA2D_BGCLUT44    \ DMA2D background CLUT
  $8B4 constant DMA2D_DMA2D_BGCLUT45    \ DMA2D background CLUT
  $8B8 constant DMA2D_DMA2D_BGCLUT46    \ DMA2D background CLUT
  $8BC constant DMA2D_DMA2D_BGCLUT47    \ DMA2D background CLUT
  $8C0 constant DMA2D_DMA2D_BGCLUT48    \ DMA2D background CLUT
  $8C4 constant DMA2D_DMA2D_BGCLUT49    \ DMA2D background CLUT
  $8C8 constant DMA2D_DMA2D_BGCLUT50    \ DMA2D background CLUT
  $8CC constant DMA2D_DMA2D_BGCLUT51    \ DMA2D background CLUT
  $8D0 constant DMA2D_DMA2D_BGCLUT52    \ DMA2D background CLUT
  $8D4 constant DMA2D_DMA2D_BGCLUT53    \ DMA2D background CLUT
  $8D8 constant DMA2D_DMA2D_BGCLUT54    \ DMA2D background CLUT
  $8DC constant DMA2D_DMA2D_BGCLUT55    \ DMA2D background CLUT
  $8E0 constant DMA2D_DMA2D_BGCLUT56    \ DMA2D background CLUT
  $8E4 constant DMA2D_DMA2D_BGCLUT57    \ DMA2D background CLUT
  $8E8 constant DMA2D_DMA2D_BGCLUT58    \ DMA2D background CLUT
  $8EC constant DMA2D_DMA2D_BGCLUT59    \ DMA2D background CLUT
  $8F0 constant DMA2D_DMA2D_BGCLUT60    \ DMA2D background CLUT
  $8F4 constant DMA2D_DMA2D_BGCLUT61    \ DMA2D background CLUT
  $8F8 constant DMA2D_DMA2D_BGCLUT62    \ DMA2D background CLUT
  $8FC constant DMA2D_DMA2D_BGCLUT63    \ DMA2D background CLUT
  $900 constant DMA2D_DMA2D_BGCLUT64    \ DMA2D background CLUT
  $904 constant DMA2D_DMA2D_BGCLUT65    \ DMA2D background CLUT
  $908 constant DMA2D_DMA2D_BGCLUT66    \ DMA2D background CLUT
  $90C constant DMA2D_DMA2D_BGCLUT67    \ DMA2D background CLUT
  $910 constant DMA2D_DMA2D_BGCLUT68    \ DMA2D background CLUT
  $914 constant DMA2D_DMA2D_BGCLUT69    \ DMA2D background CLUT
  $918 constant DMA2D_DMA2D_BGCLUT70    \ DMA2D background CLUT
  $91C constant DMA2D_DMA2D_BGCLUT71    \ DMA2D background CLUT
  $920 constant DMA2D_DMA2D_BGCLUT72    \ DMA2D background CLUT
  $924 constant DMA2D_DMA2D_BGCLUT73    \ DMA2D background CLUT
  $928 constant DMA2D_DMA2D_BGCLUT74    \ DMA2D background CLUT
  $92C constant DMA2D_DMA2D_BGCLUT75    \ DMA2D background CLUT
  $930 constant DMA2D_DMA2D_BGCLUT76    \ DMA2D background CLUT
  $934 constant DMA2D_DMA2D_BGCLUT77    \ DMA2D background CLUT
  $938 constant DMA2D_DMA2D_BGCLUT78    \ DMA2D background CLUT
  $93C constant DMA2D_DMA2D_BGCLUT79    \ DMA2D background CLUT
  $940 constant DMA2D_DMA2D_BGCLUT80    \ DMA2D background CLUT
  $944 constant DMA2D_DMA2D_BGCLUT81    \ DMA2D background CLUT
  $948 constant DMA2D_DMA2D_BGCLUT82    \ DMA2D background CLUT
  $94C constant DMA2D_DMA2D_BGCLUT83    \ DMA2D background CLUT
  $950 constant DMA2D_DMA2D_BGCLUT84    \ DMA2D background CLUT
  $954 constant DMA2D_DMA2D_BGCLUT85    \ DMA2D background CLUT
  $958 constant DMA2D_DMA2D_BGCLUT86    \ DMA2D background CLUT
  $95C constant DMA2D_DMA2D_BGCLUT87    \ DMA2D background CLUT
  $960 constant DMA2D_DMA2D_BGCLUT88    \ DMA2D background CLUT
  $964 constant DMA2D_DMA2D_BGCLUT89    \ DMA2D background CLUT
  $968 constant DMA2D_DMA2D_BGCLUT90    \ DMA2D background CLUT
  $96C constant DMA2D_DMA2D_BGCLUT91    \ DMA2D background CLUT
  $970 constant DMA2D_DMA2D_BGCLUT92    \ DMA2D background CLUT
  $974 constant DMA2D_DMA2D_BGCLUT93    \ DMA2D background CLUT
  $978 constant DMA2D_DMA2D_BGCLUT94    \ DMA2D background CLUT
  $97C constant DMA2D_DMA2D_BGCLUT95    \ DMA2D background CLUT
  $980 constant DMA2D_DMA2D_BGCLUT96    \ DMA2D background CLUT
  $984 constant DMA2D_DMA2D_BGCLUT97    \ DMA2D background CLUT
  $988 constant DMA2D_DMA2D_BGCLUT98    \ DMA2D background CLUT
  $98C constant DMA2D_DMA2D_BGCLUT99    \ DMA2D background CLUT
  $990 constant DMA2D_DMA2D_BGCLUT100   \ DMA2D background CLUT
  $994 constant DMA2D_DMA2D_BGCLUT101   \ DMA2D background CLUT
  $998 constant DMA2D_DMA2D_BGCLUT102   \ DMA2D background CLUT
  $99C constant DMA2D_DMA2D_BGCLUT103   \ DMA2D background CLUT
  $9A0 constant DMA2D_DMA2D_BGCLUT104   \ DMA2D background CLUT
  $9A4 constant DMA2D_DMA2D_BGCLUT105   \ DMA2D background CLUT
  $9A8 constant DMA2D_DMA2D_BGCLUT106   \ DMA2D background CLUT
  $9AC constant DMA2D_DMA2D_BGCLUT107   \ DMA2D background CLUT
  $9B0 constant DMA2D_DMA2D_BGCLUT108   \ DMA2D background CLUT
  $9B4 constant DMA2D_DMA2D_BGCLUT109   \ DMA2D background CLUT
  $9B8 constant DMA2D_DMA2D_BGCLUT110   \ DMA2D background CLUT
  $9BC constant DMA2D_DMA2D_BGCLUT111   \ DMA2D background CLUT
  $9C0 constant DMA2D_DMA2D_BGCLUT112   \ DMA2D background CLUT
  $9C4 constant DMA2D_DMA2D_BGCLUT113   \ DMA2D background CLUT
  $9C8 constant DMA2D_DMA2D_BGCLUT114   \ DMA2D background CLUT
  $9CC constant DMA2D_DMA2D_BGCLUT115   \ DMA2D background CLUT
  $9D0 constant DMA2D_DMA2D_BGCLUT116   \ DMA2D background CLUT
  $9D4 constant DMA2D_DMA2D_BGCLUT117   \ DMA2D background CLUT
  $9D8 constant DMA2D_DMA2D_BGCLUT118   \ DMA2D background CLUT
  $9DC constant DMA2D_DMA2D_BGCLUT119   \ DMA2D background CLUT
  $9E0 constant DMA2D_DMA2D_BGCLUT120   \ DMA2D background CLUT
  $9E4 constant DMA2D_DMA2D_BGCLUT121   \ DMA2D background CLUT
  $9E8 constant DMA2D_DMA2D_BGCLUT122   \ DMA2D background CLUT
  $9EC constant DMA2D_DMA2D_BGCLUT123   \ DMA2D background CLUT
  $9F0 constant DMA2D_DMA2D_BGCLUT124   \ DMA2D background CLUT
  $9F4 constant DMA2D_DMA2D_BGCLUT125   \ DMA2D background CLUT
  $9F8 constant DMA2D_DMA2D_BGCLUT126   \ DMA2D background CLUT
  $9FC constant DMA2D_DMA2D_BGCLUT127   \ DMA2D background CLUT
  $A00 constant DMA2D_DMA2D_BGCLUT128   \ DMA2D background CLUT
  $A04 constant DMA2D_DMA2D_BGCLUT129   \ DMA2D background CLUT
  $A08 constant DMA2D_DMA2D_BGCLUT130   \ DMA2D background CLUT
  $A0C constant DMA2D_DMA2D_BGCLUT131   \ DMA2D background CLUT
  $A10 constant DMA2D_DMA2D_BGCLUT132   \ DMA2D background CLUT
  $A14 constant DMA2D_DMA2D_BGCLUT133   \ DMA2D background CLUT
  $A18 constant DMA2D_DMA2D_BGCLUT134   \ DMA2D background CLUT
  $A1C constant DMA2D_DMA2D_BGCLUT135   \ DMA2D background CLUT
  $A20 constant DMA2D_DMA2D_BGCLUT136   \ DMA2D background CLUT
  $A24 constant DMA2D_DMA2D_BGCLUT137   \ DMA2D background CLUT
  $A28 constant DMA2D_DMA2D_BGCLUT138   \ DMA2D background CLUT
  $A2C constant DMA2D_DMA2D_BGCLUT139   \ DMA2D background CLUT
  $A30 constant DMA2D_DMA2D_BGCLUT140   \ DMA2D background CLUT
  $A34 constant DMA2D_DMA2D_BGCLUT141   \ DMA2D background CLUT
  $A38 constant DMA2D_DMA2D_BGCLUT142   \ DMA2D background CLUT
  $A3C constant DMA2D_DMA2D_BGCLUT143   \ DMA2D background CLUT
  $A40 constant DMA2D_DMA2D_BGCLUT144   \ DMA2D background CLUT
  $A44 constant DMA2D_DMA2D_BGCLUT145   \ DMA2D background CLUT
  $A48 constant DMA2D_DMA2D_BGCLUT146   \ DMA2D background CLUT
  $A4C constant DMA2D_DMA2D_BGCLUT147   \ DMA2D background CLUT
  $A50 constant DMA2D_DMA2D_BGCLUT148   \ DMA2D background CLUT
  $A54 constant DMA2D_DMA2D_BGCLUT149   \ DMA2D background CLUT
  $A58 constant DMA2D_DMA2D_BGCLUT150   \ DMA2D background CLUT
  $A5C constant DMA2D_DMA2D_BGCLUT151   \ DMA2D background CLUT
  $A60 constant DMA2D_DMA2D_BGCLUT152   \ DMA2D background CLUT
  $A64 constant DMA2D_DMA2D_BGCLUT153   \ DMA2D background CLUT
  $A68 constant DMA2D_DMA2D_BGCLUT154   \ DMA2D background CLUT
  $A6C constant DMA2D_DMA2D_BGCLUT155   \ DMA2D background CLUT
  $A70 constant DMA2D_DMA2D_BGCLUT156   \ DMA2D background CLUT
  $A74 constant DMA2D_DMA2D_BGCLUT157   \ DMA2D background CLUT
  $A78 constant DMA2D_DMA2D_BGCLUT158   \ DMA2D background CLUT
  $A7C constant DMA2D_DMA2D_BGCLUT159   \ DMA2D background CLUT
  $A80 constant DMA2D_DMA2D_BGCLUT160   \ DMA2D background CLUT
  $A84 constant DMA2D_DMA2D_BGCLUT161   \ DMA2D background CLUT
  $A88 constant DMA2D_DMA2D_BGCLUT162   \ DMA2D background CLUT
  $A8C constant DMA2D_DMA2D_BGCLUT163   \ DMA2D background CLUT
  $A90 constant DMA2D_DMA2D_BGCLUT164   \ DMA2D background CLUT
  $A94 constant DMA2D_DMA2D_BGCLUT165   \ DMA2D background CLUT
  $A98 constant DMA2D_DMA2D_BGCLUT166   \ DMA2D background CLUT
  $A9C constant DMA2D_DMA2D_BGCLUT167   \ DMA2D background CLUT
  $AA0 constant DMA2D_DMA2D_BGCLUT168   \ DMA2D background CLUT
  $AA4 constant DMA2D_DMA2D_BGCLUT169   \ DMA2D background CLUT
  $AA8 constant DMA2D_DMA2D_BGCLUT170   \ DMA2D background CLUT
  $AAC constant DMA2D_DMA2D_BGCLUT171   \ DMA2D background CLUT
  $AB0 constant DMA2D_DMA2D_BGCLUT172   \ DMA2D background CLUT
  $AB4 constant DMA2D_DMA2D_BGCLUT173   \ DMA2D background CLUT
  $AB8 constant DMA2D_DMA2D_BGCLUT174   \ DMA2D background CLUT
  $ABC constant DMA2D_DMA2D_BGCLUT175   \ DMA2D background CLUT
  $AC0 constant DMA2D_DMA2D_BGCLUT176   \ DMA2D background CLUT
  $AC4 constant DMA2D_DMA2D_BGCLUT177   \ DMA2D background CLUT
  $AC8 constant DMA2D_DMA2D_BGCLUT178   \ DMA2D background CLUT
  $ACC constant DMA2D_DMA2D_BGCLUT179   \ DMA2D background CLUT
  $AD0 constant DMA2D_DMA2D_BGCLUT180   \ DMA2D background CLUT
  $AD4 constant DMA2D_DMA2D_BGCLUT181   \ DMA2D background CLUT
  $AD8 constant DMA2D_DMA2D_BGCLUT182   \ DMA2D background CLUT
  $ADC constant DMA2D_DMA2D_BGCLUT183   \ DMA2D background CLUT
  $AE0 constant DMA2D_DMA2D_BGCLUT184   \ DMA2D background CLUT
  $AE4 constant DMA2D_DMA2D_BGCLUT185   \ DMA2D background CLUT
  $AE8 constant DMA2D_DMA2D_BGCLUT186   \ DMA2D background CLUT
  $AEC constant DMA2D_DMA2D_BGCLUT187   \ DMA2D background CLUT
  $AF0 constant DMA2D_DMA2D_BGCLUT188   \ DMA2D background CLUT
  $AF4 constant DMA2D_DMA2D_BGCLUT189   \ DMA2D background CLUT
  $AF8 constant DMA2D_DMA2D_BGCLUT190   \ DMA2D background CLUT
  $AFC constant DMA2D_DMA2D_BGCLUT191   \ DMA2D background CLUT
  $B00 constant DMA2D_DMA2D_BGCLUT192   \ DMA2D background CLUT
  $B04 constant DMA2D_DMA2D_BGCLUT193   \ DMA2D background CLUT
  $B08 constant DMA2D_DMA2D_BGCLUT194   \ DMA2D background CLUT
  $B0C constant DMA2D_DMA2D_BGCLUT195   \ DMA2D background CLUT
  $B10 constant DMA2D_DMA2D_BGCLUT196   \ DMA2D background CLUT
  $B14 constant DMA2D_DMA2D_BGCLUT197   \ DMA2D background CLUT
  $B18 constant DMA2D_DMA2D_BGCLUT198   \ DMA2D background CLUT
  $B1C constant DMA2D_DMA2D_BGCLUT199   \ DMA2D background CLUT
  $B20 constant DMA2D_DMA2D_BGCLUT200   \ DMA2D background CLUT
  $B24 constant DMA2D_DMA2D_BGCLUT201   \ DMA2D background CLUT
  $B28 constant DMA2D_DMA2D_BGCLUT202   \ DMA2D background CLUT
  $B2C constant DMA2D_DMA2D_BGCLUT203   \ DMA2D background CLUT
  $B30 constant DMA2D_DMA2D_BGCLUT204   \ DMA2D background CLUT
  $B34 constant DMA2D_DMA2D_BGCLUT205   \ DMA2D background CLUT
  $B38 constant DMA2D_DMA2D_BGCLUT206   \ DMA2D background CLUT
  $B3C constant DMA2D_DMA2D_BGCLUT207   \ DMA2D background CLUT
  $B40 constant DMA2D_DMA2D_BGCLUT208   \ DMA2D background CLUT
  $B44 constant DMA2D_DMA2D_BGCLUT209   \ DMA2D background CLUT
  $B48 constant DMA2D_DMA2D_BGCLUT210   \ DMA2D background CLUT
  $B4C constant DMA2D_DMA2D_BGCLUT211   \ DMA2D background CLUT
  $B50 constant DMA2D_DMA2D_BGCLUT212   \ DMA2D background CLUT
  $B54 constant DMA2D_DMA2D_BGCLUT213   \ DMA2D background CLUT
  $B58 constant DMA2D_DMA2D_BGCLUT214   \ DMA2D background CLUT
  $B5C constant DMA2D_DMA2D_BGCLUT215   \ DMA2D background CLUT
  $B60 constant DMA2D_DMA2D_BGCLUT216   \ DMA2D background CLUT
  $B64 constant DMA2D_DMA2D_BGCLUT217   \ DMA2D background CLUT
  $B68 constant DMA2D_DMA2D_BGCLUT218   \ DMA2D background CLUT
  $B6C constant DMA2D_DMA2D_BGCLUT219   \ DMA2D background CLUT
  $B70 constant DMA2D_DMA2D_BGCLUT220   \ DMA2D background CLUT
  $B74 constant DMA2D_DMA2D_BGCLUT221   \ DMA2D background CLUT
  $B78 constant DMA2D_DMA2D_BGCLUT222   \ DMA2D background CLUT
  $B7C constant DMA2D_DMA2D_BGCLUT223   \ DMA2D background CLUT
  $B80 constant DMA2D_DMA2D_BGCLUT224   \ DMA2D background CLUT
  $B84 constant DMA2D_DMA2D_BGCLUT225   \ DMA2D background CLUT
  $B88 constant DMA2D_DMA2D_BGCLUT226   \ DMA2D background CLUT
  $B8C constant DMA2D_DMA2D_BGCLUT227   \ DMA2D background CLUT
  $B90 constant DMA2D_DMA2D_BGCLUT228   \ DMA2D background CLUT
  $B94 constant DMA2D_DMA2D_BGCLUT229   \ DMA2D background CLUT
  $B98 constant DMA2D_DMA2D_BGCLUT230   \ DMA2D background CLUT
  $B9C constant DMA2D_DMA2D_BGCLUT231   \ DMA2D background CLUT
  $BA0 constant DMA2D_DMA2D_BGCLUT232   \ DMA2D background CLUT
  $BA4 constant DMA2D_DMA2D_BGCLUT233   \ DMA2D background CLUT
  $BA8 constant DMA2D_DMA2D_BGCLUT234   \ DMA2D background CLUT
  $BAC constant DMA2D_DMA2D_BGCLUT235   \ DMA2D background CLUT
  $BB0 constant DMA2D_DMA2D_BGCLUT236   \ DMA2D background CLUT
  $BB4 constant DMA2D_DMA2D_BGCLUT237   \ DMA2D background CLUT
  $BB8 constant DMA2D_DMA2D_BGCLUT238   \ DMA2D background CLUT
  $BBC constant DMA2D_DMA2D_BGCLUT239   \ DMA2D background CLUT
  $BC0 constant DMA2D_DMA2D_BGCLUT240   \ DMA2D background CLUT
  $BC4 constant DMA2D_DMA2D_BGCLUT241   \ DMA2D background CLUT
  $BC8 constant DMA2D_DMA2D_BGCLUT242   \ DMA2D background CLUT
  $BCC constant DMA2D_DMA2D_BGCLUT243   \ DMA2D background CLUT
  $BD0 constant DMA2D_DMA2D_BGCLUT244   \ DMA2D background CLUT
  $BD4 constant DMA2D_DMA2D_BGCLUT245   \ DMA2D background CLUT
  $BD8 constant DMA2D_DMA2D_BGCLUT246   \ DMA2D background CLUT
  $BDC constant DMA2D_DMA2D_BGCLUT247   \ DMA2D background CLUT
  $BE0 constant DMA2D_DMA2D_BGCLUT248   \ DMA2D background CLUT
  $BE4 constant DMA2D_DMA2D_BGCLUT249   \ DMA2D background CLUT
  $BE8 constant DMA2D_DMA2D_BGCLUT250   \ DMA2D background CLUT
  $BEC constant DMA2D_DMA2D_BGCLUT251   \ DMA2D background CLUT
  $BF0 constant DMA2D_DMA2D_BGCLUT252   \ DMA2D background CLUT
  $BF4 constant DMA2D_DMA2D_BGCLUT253   \ DMA2D background CLUT
  $BF8 constant DMA2D_DMA2D_BGCLUT254   \ DMA2D background CLUT
  $BFC constant DMA2D_DMA2D_BGCLUT255   \ DMA2D background CLUT

: DMA2D_DEF ; [then]
