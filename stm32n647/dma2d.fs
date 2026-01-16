\
\ @file dma2d.fs
\ @brief Chrom-ART Accelerator controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA2D control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DMA2D_DMA2D_CR_START                             \ Start
$00000002 constant DMA2D_DMA2D_CR_SUSP                              \ Suspend
$00000004 constant DMA2D_DMA2D_CR_ABORT                             \ Abort
$00000040 constant DMA2D_DMA2D_CR_LOM                               \ Line offset mode
$00000100 constant DMA2D_DMA2D_CR_TEIE                              \ Transfer error (TE) interrupt enable
$00000200 constant DMA2D_DMA2D_CR_TCIE                              \ Transfer complete (TC) interrupt enable
$00000400 constant DMA2D_DMA2D_CR_TWIE                              \ Transfer watermark (TW) interrupt enable
$00000800 constant DMA2D_DMA2D_CR_CAEIE                             \ CLUT access error (CAE) interrupt enable
$00001000 constant DMA2D_DMA2D_CR_CTCIE                             \ CLUT transfer complete (CTC) interrupt enable
$00002000 constant DMA2D_DMA2D_CR_CEIE                              \ Configuration error (CE) interrupt enable
$00070000 constant DMA2D_DMA2D_CR_MODE                              \ DMA2D mode


\
\ @brief DMA2D interrupt status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DMA2D_DMA2D_ISR_TEIF                             \ Transfer error interrupt flag
$00000002 constant DMA2D_DMA2D_ISR_TCIF                             \ Transfer complete interrupt flag
$00000004 constant DMA2D_DMA2D_ISR_TWIF                             \ Transfer watermark interrupt flag
$00000008 constant DMA2D_DMA2D_ISR_CAEIF                            \ CLUT access error interrupt flag
$00000010 constant DMA2D_DMA2D_ISR_CTCIF                            \ CLUT transfer complete interrupt flag
$00000020 constant DMA2D_DMA2D_ISR_CEIF                             \ Configuration error interrupt flag


\
\ @brief DMA2D interrupt flag clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DMA2D_DMA2D_IFCR_CTEIF                           \ Clear transfer error interrupt flag
$00000002 constant DMA2D_DMA2D_IFCR_CTCIF                           \ Clear transfer complete interrupt flag
$00000004 constant DMA2D_DMA2D_IFCR_CTWIF                           \ Clear transfer watermark interrupt flag
$00000008 constant DMA2D_DMA2D_IFCR_CAECIF                          \ Clear CLUT access error interrupt flag
$00000010 constant DMA2D_DMA2D_IFCR_CCTCIF                          \ Clear CLUT transfer complete interrupt flag
$00000020 constant DMA2D_DMA2D_IFCR_CCEIF                           \ Clear configuration error interrupt flag


\
\ @brief DMA2D foreground memory address register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_DMA2D_FGMAR_MA                             \ Memory address, address of the data used for the foreground image


\
\ @brief DMA2D foreground offset register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant DMA2D_DMA2D_FGOR_LO                              \ Line offset


\
\ @brief DMA2D background memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_DMA2D_BGMAR_MA                             \ Memory address, address of the data used for the background image


\
\ @brief DMA2D background offset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant DMA2D_DMA2D_BGOR_LO                              \ Line offset


\
\ @brief DMA2D foreground PFC control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant DMA2D_DMA2D_FGPFCCR_CM                           \ Color mode
$00000010 constant DMA2D_DMA2D_FGPFCCR_CCM                          \ CLUT color mode
$00000020 constant DMA2D_DMA2D_FGPFCCR_START                        \ Start
$0000ff00 constant DMA2D_DMA2D_FGPFCCR_CS                           \ CLUT size
$00030000 constant DMA2D_DMA2D_FGPFCCR_AM                           \ Alpha mode
$000c0000 constant DMA2D_DMA2D_FGPFCCR_CSS                          \ Chroma subsampling
$00100000 constant DMA2D_DMA2D_FGPFCCR_AI                           \ Alpha inverted
$00200000 constant DMA2D_DMA2D_FGPFCCR_RBS                          \ Red/Blue swap
$ff000000 constant DMA2D_DMA2D_FGPFCCR_ALPHA                        \ Alpha value


\
\ @brief DMA2D foreground color register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCOLR_BLUE                          \ Blue value for the A4 or A8 mode of the foreground image
$0000ff00 constant DMA2D_DMA2D_FGCOLR_GREEN                         \ Green value for the A4 or A8 mode of the foreground image
$00ff0000 constant DMA2D_DMA2D_FGCOLR_RED                           \ Red value for the A4 or A8 mode of the foreground image


\
\ @brief DMA2D background PFC control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant DMA2D_DMA2D_BGPFCCR_CM                           \ Color mode
$00000010 constant DMA2D_DMA2D_BGPFCCR_CCM                          \ CLUT color mode
$00000020 constant DMA2D_DMA2D_BGPFCCR_START                        \ Start
$0000ff00 constant DMA2D_DMA2D_BGPFCCR_CS                           \ CLUT size
$00030000 constant DMA2D_DMA2D_BGPFCCR_AM                           \ Alpha mode
$00100000 constant DMA2D_DMA2D_BGPFCCR_AI                           \ Alpha Inverted
$00200000 constant DMA2D_DMA2D_BGPFCCR_RBS                          \ Red/Blue swap
$ff000000 constant DMA2D_DMA2D_BGPFCCR_ALPHA                        \ Alpha value


\
\ @brief DMA2D background color register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCOLR_BLUE                          \ Blue value for the A4 or A8 mode of the background
$0000ff00 constant DMA2D_DMA2D_BGCOLR_GREEN                         \ Green value for the A4 or A8 mode of the background
$00ff0000 constant DMA2D_DMA2D_BGCOLR_RED                           \ Red value for the A4 or A8 mode of the background


\
\ @brief DMA2D foreground CLUT memory address register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_DMA2D_FGCMAR_MA                            \ Memory address


\
\ @brief DMA2D background CLUT memory address register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_DMA2D_BGCMAR_MA                            \ Memory address


\
\ @brief DMA2D output PFC control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000007 constant DMA2D_DMA2D_OPFCCR_CM                            \ Color mode
$00000100 constant DMA2D_DMA2D_OPFCCR_SB                            \ Swap bytes
$00100000 constant DMA2D_DMA2D_OPFCCR_AI                            \ Alpha Inverted
$00200000 constant DMA2D_DMA2D_OPFCCR_RBS                           \ Red/Blue swap


\
\ @brief DMA2D output color register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_OCOLR_RGB888_BLUE                    \ Blue value of the output image in ARGB8888 or RGB888
$0000ff00 constant DMA2D_DMA2D_OCOLR_RGB888_GREEN                   \ Green value of the output image in ARGB8888 or RGB888
$00ff0000 constant DMA2D_DMA2D_OCOLR_RGB888_RED                     \ Red value of the output image in ARGB8888 or RGB888 mode
$ff000000 constant DMA2D_DMA2D_OCOLR_RGB888_ALPHA                   \ Alpha channel value of the output color in ARGB8888 mode (otherwise reserved)


\
\ @brief DMA2D output color register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant DMA2D_DMA2D_OCOLR_RGB565_BLUE                    \ Blue value of the output image in RGB565 mode
$000007e0 constant DMA2D_DMA2D_OCOLR_RGB565_GREEN                   \ Green value of the output image in RGB565 mode
$0000f800 constant DMA2D_DMA2D_OCOLR_RGB565_RED                     \ Red value of the output image in RGB565 mode


\
\ @brief DMA2D output color register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant DMA2D_DMA2D_OCOLR_ARGB1555_BLUE                  \ Blue value of the output image in ARGB1555 mode
$000003e0 constant DMA2D_DMA2D_OCOLR_ARGB1555_GREEN                 \ Green value of the output image in ARGB1555 mode
$00007c00 constant DMA2D_DMA2D_OCOLR_ARGB1555_RED                   \ Red value of the output image in ARGB1555 mode
$00008000 constant DMA2D_DMA2D_OCOLR_ARGB1555_A                     \ Alpha channel value of the output color in ARGB1555 mode


\
\ @brief DMA2D output color register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000000f constant DMA2D_DMA2D_OCOLR_ARGB4444_BLUE                  \ Blue value of the output image in ARGB4444 mode
$000000f0 constant DMA2D_DMA2D_OCOLR_ARGB4444_GREEN                 \ Green value of the output image in ARGB4444 mode
$00000f00 constant DMA2D_DMA2D_OCOLR_ARGB4444_RED                   \ Red value of the output image in ARGB4444 mode
$0000f000 constant DMA2D_DMA2D_OCOLR_ARGB4444_ALPHA                 \ Alpha channel of the output color value in ARGB4444


\
\ @brief DMA2D output memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant DMA2D_DMA2D_OMAR_MA                              \ Memory address


\
\ @brief DMA2D output offset register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant DMA2D_DMA2D_OOR_LO                               \ Line offset


\
\ @brief DMA2D number of line register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant DMA2D_DMA2D_NLR_NL                               \ Number of lines of the area to be transferred.
$3fff0000 constant DMA2D_DMA2D_NLR_PL                               \ Pixel per lines per lines of the area to be transferred


\
\ @brief DMA2D line watermark register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant DMA2D_DMA2D_LWR_LW                               \ Line watermark for interrupt generation


\
\ @brief DMA2D AXI master timer configuration register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant DMA2D_DMA2D_AMTCR_EN                             \ Dead-time functionality enable
$0000ff00 constant DMA2D_DMA2D_AMTCR_DT                             \ Dead time


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT0_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT0_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT0_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT0_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT1_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT1_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT1_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT1_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT2_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT2_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT2_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT2_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT3_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT3_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT3_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT3_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT4_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT4_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT4_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT4_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT5_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT5_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT5_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT5_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT6_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT6_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT6_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT6_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT7_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT7_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT7_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT7_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT8_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT8_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT8_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT8_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT9_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT9_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT9_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT9_ALPHA                        \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT10_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT10_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT10_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT10_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x42C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT11_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT11_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT11_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT11_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT12_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT12_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT12_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT12_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x434
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT13_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT13_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT13_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT13_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x438
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT14_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT14_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT14_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT14_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x43C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT15_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT15_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT15_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT15_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT16_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT16_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT16_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT16_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x444
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT17_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT17_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT17_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT17_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x448
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT18_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT18_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT18_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT18_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT19_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT19_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT19_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT19_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x450
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT20_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT20_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT20_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT20_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x454
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT21_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT21_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT21_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT21_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x458
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT22_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT22_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT22_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT22_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x45C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT23_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT23_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT23_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT23_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x460
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT24_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT24_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT24_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT24_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT25_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT25_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT25_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT25_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x468
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT26_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT26_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT26_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT26_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x46C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT27_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT27_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT27_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT27_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x470
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT28_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT28_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT28_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT28_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x474
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT29_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT29_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT29_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT29_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x478
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT30_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT30_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT30_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT30_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x47C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT31_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT31_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT31_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT31_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x480
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT32_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT32_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT32_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT32_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x484
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT33_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT33_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT33_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT33_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x488
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT34_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT34_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT34_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT34_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x48C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT35_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT35_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT35_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT35_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT36_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT36_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT36_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT36_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT37_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT37_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT37_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT37_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT38_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT38_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT38_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT38_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT39_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT39_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT39_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT39_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT40_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT40_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT40_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT40_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4A4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT41_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT41_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT41_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT41_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4A8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT42_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT42_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT42_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT42_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4AC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT43_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT43_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT43_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT43_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4B0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT44_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT44_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT44_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT44_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4B4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT45_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT45_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT45_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT45_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4B8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT46_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT46_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT46_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT46_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4BC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT47_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT47_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT47_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT47_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4C0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT48_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT48_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT48_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT48_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4C4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT49_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT49_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT49_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT49_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4C8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT50_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT50_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT50_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT50_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4CC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT51_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT51_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT51_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT51_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4D0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT52_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT52_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT52_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT52_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4D4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT53_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT53_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT53_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT53_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4D8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT54_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT54_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT54_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT54_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4DC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT55_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT55_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT55_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT55_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4E0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT56_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT56_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT56_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT56_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4E4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT57_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT57_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT57_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT57_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4E8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT58_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT58_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT58_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT58_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4EC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT59_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT59_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT59_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT59_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4F0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT60_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT60_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT60_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT60_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4F4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT61_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT61_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT61_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT61_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4F8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT62_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT62_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT62_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT62_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x4FC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT63_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT63_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT63_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT63_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT64_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT64_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT64_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT64_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT65_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT65_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT65_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT65_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT66_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT66_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT66_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT66_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT67_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT67_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT67_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT67_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT68_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT68_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT68_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT68_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT69_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT69_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT69_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT69_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x518
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT70_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT70_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT70_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT70_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x51C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT71_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT71_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT71_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT71_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT72_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT72_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT72_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT72_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x524
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT73_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT73_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT73_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT73_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT74_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT74_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT74_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT74_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x52C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT75_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT75_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT75_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT75_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT76_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT76_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT76_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT76_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x534
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT77_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT77_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT77_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT77_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x538
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT78_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT78_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT78_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT78_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x53C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT79_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT79_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT79_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT79_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT80_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT80_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT80_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT80_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x544
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT81_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT81_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT81_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT81_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT82_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT82_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT82_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT82_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT83_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT83_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT83_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT83_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT84_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT84_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT84_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT84_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x554
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT85_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT85_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT85_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT85_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x558
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT86_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT86_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT86_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT86_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x55C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT87_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT87_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT87_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT87_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT88_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT88_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT88_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT88_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT89_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT89_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT89_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT89_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x568
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT90_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT90_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT90_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT90_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x56C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT91_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT91_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT91_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT91_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x570
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT92_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT92_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT92_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT92_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x574
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT93_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT93_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT93_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT93_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x578
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT94_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT94_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT94_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT94_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x57C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT95_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT95_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT95_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT95_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x580
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT96_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT96_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT96_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT96_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x584
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT97_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT97_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT97_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT97_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x588
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT98_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT98_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT98_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT98_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x58C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT99_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT99_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT99_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT99_ALPHA                       \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT100_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT100_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT100_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT100_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT101_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT101_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT101_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT101_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x598
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT102_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT102_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT102_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT102_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x59C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT103_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT103_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT103_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT103_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT104_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT104_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT104_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT104_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5A4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT105_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT105_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT105_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT105_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5A8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT106_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT106_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT106_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT106_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5AC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT107_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT107_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT107_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT107_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT108_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT108_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT108_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT108_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5B4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT109_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT109_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT109_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT109_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5B8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT110_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT110_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT110_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT110_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5BC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT111_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT111_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT111_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT111_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT112_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT112_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT112_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT112_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT113_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT113_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT113_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT113_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT114_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT114_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT114_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT114_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT115_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT115_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT115_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT115_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT116_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT116_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT116_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT116_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5D4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT117_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT117_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT117_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT117_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5D8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT118_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT118_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT118_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT118_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5DC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT119_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT119_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT119_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT119_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT120_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT120_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT120_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT120_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT121_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT121_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT121_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT121_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT122_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT122_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT122_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT122_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5EC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT123_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT123_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT123_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT123_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT124_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT124_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT124_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT124_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT125_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT125_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT125_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT125_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5F8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT126_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT126_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT126_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT126_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x5FC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT127_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT127_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT127_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT127_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT128_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT128_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT128_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT128_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT129_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT129_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT129_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT129_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT130_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT130_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT130_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT130_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT131_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT131_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT131_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT131_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT132_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT132_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT132_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT132_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT133_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT133_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT133_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT133_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT134_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT134_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT134_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT134_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT135_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT135_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT135_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT135_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT136_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT136_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT136_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT136_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT137_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT137_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT137_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT137_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT138_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT138_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT138_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT138_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x62C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT139_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT139_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT139_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT139_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT140_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT140_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT140_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT140_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT141_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT141_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT141_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT141_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x638
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT142_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT142_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT142_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT142_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x63C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT143_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT143_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT143_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT143_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT144_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT144_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT144_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT144_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT145_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT145_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT145_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT145_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT146_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT146_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT146_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT146_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT147_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT147_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT147_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT147_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT148_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT148_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT148_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT148_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT149_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT149_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT149_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT149_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x658
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT150_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT150_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT150_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT150_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT151_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT151_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT151_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT151_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT152_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT152_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT152_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT152_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT153_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT153_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT153_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT153_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT154_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT154_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT154_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT154_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x66C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT155_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT155_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT155_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT155_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT156_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT156_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT156_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT156_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x674
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT157_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT157_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT157_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT157_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x678
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT158_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT158_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT158_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT158_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x67C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT159_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT159_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT159_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT159_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x680
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT160_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT160_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT160_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT160_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x684
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT161_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT161_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT161_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT161_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x688
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT162_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT162_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT162_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT162_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x68C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT163_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT163_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT163_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT163_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x690
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT164_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT164_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT164_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT164_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT165_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT165_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT165_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT165_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x698
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT166_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT166_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT166_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT166_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x69C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT167_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT167_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT167_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT167_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT168_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT168_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT168_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT168_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT169_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT169_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT169_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT169_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT170_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT170_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT170_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT170_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6AC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT171_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT171_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT171_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT171_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6B0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT172_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT172_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT172_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT172_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6B4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT173_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT173_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT173_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT173_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6B8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT174_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT174_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT174_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT174_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6BC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT175_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT175_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT175_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT175_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6C0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT176_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT176_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT176_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT176_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6C4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT177_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT177_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT177_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT177_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6C8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT178_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT178_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT178_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT178_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT179_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT179_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT179_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT179_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT180_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT180_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT180_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT180_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT181_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT181_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT181_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT181_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6D8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT182_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT182_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT182_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT182_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6DC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT183_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT183_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT183_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT183_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6E0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT184_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT184_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT184_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT184_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT185_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT185_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT185_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT185_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6E8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT186_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT186_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT186_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT186_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6EC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT187_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT187_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT187_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT187_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6F0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT188_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT188_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT188_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT188_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6F4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT189_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT189_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT189_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT189_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6F8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT190_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT190_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT190_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT190_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x6FC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT191_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT191_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT191_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT191_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT192_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT192_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT192_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT192_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT193_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT193_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT193_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT193_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x708
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT194_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT194_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT194_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT194_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x70C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT195_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT195_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT195_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT195_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x710
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT196_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT196_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT196_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT196_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x714
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT197_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT197_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT197_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT197_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x718
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT198_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT198_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT198_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT198_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x71C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT199_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT199_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT199_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT199_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x720
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT200_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT200_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT200_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT200_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x724
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT201_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT201_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT201_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT201_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x728
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT202_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT202_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT202_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT202_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x72C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT203_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT203_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT203_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT203_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x730
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT204_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT204_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT204_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT204_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x734
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT205_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT205_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT205_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT205_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x738
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT206_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT206_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT206_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT206_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x73C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT207_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT207_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT207_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT207_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x740
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT208_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT208_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT208_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT208_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x744
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT209_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT209_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT209_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT209_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x748
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT210_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT210_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT210_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT210_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x74C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT211_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT211_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT211_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT211_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x750
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT212_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT212_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT212_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT212_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x754
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT213_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT213_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT213_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT213_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x758
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT214_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT214_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT214_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT214_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x75C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT215_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT215_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT215_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT215_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x760
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT216_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT216_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT216_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT216_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x764
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT217_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT217_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT217_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT217_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x768
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT218_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT218_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT218_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT218_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x76C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT219_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT219_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT219_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT219_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x770
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT220_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT220_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT220_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT220_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x774
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT221_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT221_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT221_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT221_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x778
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT222_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT222_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT222_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT222_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x77C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT223_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT223_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT223_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT223_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x780
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT224_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT224_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT224_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT224_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x784
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT225_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT225_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT225_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT225_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x788
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT226_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT226_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT226_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT226_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x78C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT227_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT227_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT227_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT227_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x790
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT228_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT228_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT228_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT228_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT229_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT229_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT229_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT229_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x798
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT230_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT230_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT230_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT230_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x79C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT231_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT231_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT231_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT231_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7A0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT232_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT232_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT232_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT232_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7A4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT233_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT233_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT233_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT233_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7A8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT234_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT234_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT234_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT234_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7AC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT235_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT235_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT235_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT235_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7B0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT236_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT236_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT236_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT236_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7B4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT237_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT237_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT237_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT237_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7B8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT238_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT238_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT238_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT238_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7BC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT239_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT239_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT239_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT239_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7C0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT240_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT240_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT240_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT240_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT241_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT241_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT241_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT241_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7C8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT242_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT242_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT242_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT242_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7CC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT243_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT243_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT243_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT243_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7D0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT244_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT244_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT244_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT244_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7D4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT245_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT245_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT245_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT245_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7D8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT246_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT246_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT246_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT246_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7DC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT247_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT247_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT247_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT247_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7E0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT248_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT248_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT248_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT248_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7E4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT249_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT249_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT249_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT249_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7E8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT250_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT250_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT250_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT250_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7EC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT251_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT251_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT251_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT251_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7F0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT252_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT252_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT252_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT252_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7F4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT253_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT253_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT253_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT253_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7F8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT254_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT254_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT254_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT254_ALPHA                      \ Alpha


\
\ @brief DMA2D foreground CLUT
\ Address offset: 0x7FC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_FGCLUT255_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_FGCLUT255_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_FGCLUT255_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_FGCLUT255_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x800
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT0_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT0_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT0_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT0_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x804
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT1_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT1_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT1_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT1_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x808
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT2_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT2_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT2_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT2_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x80C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT3_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT3_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT3_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT3_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x810
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT4_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT4_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT4_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT4_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT5_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT5_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT5_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT5_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT6_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT6_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT6_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT6_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT7_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT7_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT7_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT7_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x820
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT8_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT8_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT8_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT8_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x824
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT9_BLUE                         \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT9_GREEN                        \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT9_RED                          \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT9_ALPHA                        \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x828
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT10_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT10_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT10_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT10_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x82C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT11_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT11_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT11_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT11_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x830
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT12_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT12_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT12_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT12_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x834
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT13_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT13_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT13_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT13_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x838
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT14_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT14_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT14_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT14_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x83C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT15_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT15_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT15_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT15_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x840
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT16_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT16_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT16_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT16_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x844
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT17_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT17_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT17_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT17_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x848
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT18_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT18_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT18_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT18_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x84C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT19_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT19_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT19_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT19_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x850
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT20_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT20_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT20_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT20_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x854
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT21_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT21_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT21_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT21_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x858
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT22_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT22_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT22_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT22_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x85C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT23_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT23_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT23_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT23_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x860
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT24_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT24_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT24_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT24_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x864
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT25_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT25_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT25_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT25_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x868
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT26_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT26_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT26_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT26_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x86C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT27_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT27_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT27_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT27_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x870
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT28_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT28_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT28_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT28_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x874
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT29_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT29_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT29_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT29_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x878
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT30_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT30_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT30_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT30_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x87C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT31_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT31_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT31_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT31_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x880
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT32_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT32_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT32_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT32_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x884
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT33_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT33_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT33_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT33_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x888
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT34_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT34_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT34_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT34_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x88C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT35_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT35_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT35_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT35_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x890
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT36_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT36_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT36_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT36_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x894
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT37_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT37_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT37_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT37_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x898
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT38_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT38_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT38_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT38_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x89C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT39_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT39_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT39_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT39_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8A0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT40_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT40_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT40_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT40_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8A4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT41_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT41_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT41_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT41_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8A8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT42_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT42_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT42_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT42_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8AC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT43_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT43_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT43_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT43_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8B0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT44_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT44_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT44_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT44_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8B4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT45_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT45_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT45_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT45_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8B8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT46_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT46_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT46_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT46_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8BC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT47_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT47_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT47_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT47_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8C0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT48_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT48_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT48_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT48_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8C4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT49_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT49_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT49_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT49_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8C8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT50_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT50_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT50_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT50_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8CC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT51_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT51_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT51_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT51_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8D0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT52_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT52_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT52_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT52_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8D4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT53_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT53_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT53_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT53_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8D8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT54_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT54_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT54_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT54_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8DC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT55_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT55_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT55_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT55_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8E0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT56_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT56_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT56_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT56_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8E4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT57_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT57_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT57_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT57_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8E8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT58_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT58_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT58_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT58_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8EC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT59_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT59_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT59_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT59_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8F0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT60_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT60_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT60_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT60_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8F4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT61_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT61_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT61_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT61_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8F8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT62_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT62_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT62_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT62_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x8FC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT63_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT63_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT63_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT63_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT64_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT64_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT64_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT64_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x904
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT65_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT65_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT65_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT65_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x908
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT66_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT66_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT66_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT66_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x90C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT67_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT67_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT67_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT67_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT68_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT68_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT68_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT68_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT69_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT69_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT69_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT69_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x918
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT70_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT70_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT70_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT70_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x91C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT71_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT71_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT71_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT71_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x920
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT72_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT72_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT72_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT72_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x924
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT73_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT73_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT73_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT73_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x928
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT74_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT74_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT74_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT74_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x92C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT75_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT75_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT75_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT75_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT76_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT76_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT76_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT76_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x934
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT77_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT77_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT77_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT77_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x938
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT78_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT78_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT78_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT78_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x93C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT79_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT79_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT79_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT79_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT80_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT80_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT80_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT80_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x944
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT81_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT81_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT81_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT81_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x948
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT82_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT82_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT82_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT82_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x94C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT83_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT83_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT83_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT83_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x950
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT84_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT84_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT84_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT84_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x954
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT85_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT85_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT85_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT85_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x958
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT86_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT86_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT86_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT86_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x95C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT87_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT87_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT87_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT87_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x960
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT88_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT88_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT88_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT88_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x964
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT89_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT89_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT89_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT89_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x968
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT90_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT90_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT90_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT90_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x96C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT91_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT91_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT91_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT91_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x970
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT92_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT92_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT92_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT92_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x974
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT93_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT93_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT93_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT93_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x978
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT94_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT94_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT94_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT94_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x97C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT95_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT95_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT95_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT95_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x980
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT96_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT96_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT96_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT96_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x984
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT97_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT97_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT97_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT97_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x988
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT98_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT98_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT98_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT98_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x98C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT99_BLUE                        \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT99_GREEN                       \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT99_RED                         \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT99_ALPHA                       \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x990
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT100_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT100_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT100_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT100_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x994
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT101_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT101_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT101_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT101_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x998
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT102_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT102_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT102_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT102_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x99C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT103_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT103_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT103_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT103_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9A0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT104_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT104_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT104_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT104_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9A4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT105_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT105_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT105_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT105_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9A8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT106_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT106_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT106_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT106_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9AC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT107_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT107_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT107_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT107_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9B0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT108_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT108_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT108_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT108_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9B4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT109_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT109_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT109_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT109_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9B8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT110_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT110_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT110_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT110_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9BC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT111_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT111_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT111_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT111_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9C0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT112_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT112_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT112_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT112_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9C4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT113_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT113_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT113_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT113_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9C8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT114_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT114_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT114_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT114_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9CC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT115_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT115_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT115_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT115_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9D0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT116_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT116_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT116_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT116_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9D4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT117_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT117_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT117_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT117_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9D8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT118_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT118_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT118_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT118_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9DC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT119_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT119_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT119_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT119_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9E0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT120_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT120_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT120_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT120_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9E4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT121_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT121_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT121_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT121_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9E8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT122_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT122_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT122_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT122_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9EC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT123_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT123_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT123_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT123_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9F0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT124_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT124_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT124_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT124_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9F4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT125_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT125_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT125_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT125_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9F8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT126_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT126_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT126_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT126_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0x9FC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT127_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT127_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT127_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT127_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA00
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT128_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT128_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT128_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT128_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA04
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT129_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT129_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT129_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT129_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA08
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT130_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT130_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT130_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT130_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA0C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT131_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT131_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT131_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT131_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA10
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT132_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT132_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT132_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT132_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA14
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT133_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT133_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT133_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT133_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA18
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT134_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT134_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT134_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT134_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA1C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT135_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT135_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT135_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT135_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA20
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT136_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT136_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT136_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT136_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA24
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT137_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT137_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT137_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT137_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA28
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT138_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT138_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT138_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT138_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA2C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT139_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT139_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT139_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT139_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA30
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT140_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT140_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT140_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT140_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA34
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT141_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT141_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT141_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT141_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA38
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT142_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT142_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT142_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT142_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA3C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT143_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT143_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT143_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT143_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA40
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT144_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT144_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT144_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT144_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA44
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT145_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT145_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT145_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT145_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA48
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT146_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT146_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT146_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT146_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA4C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT147_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT147_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT147_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT147_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA50
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT148_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT148_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT148_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT148_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA54
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT149_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT149_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT149_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT149_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA58
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT150_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT150_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT150_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT150_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA5C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT151_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT151_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT151_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT151_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA60
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT152_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT152_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT152_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT152_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA64
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT153_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT153_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT153_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT153_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA68
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT154_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT154_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT154_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT154_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA6C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT155_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT155_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT155_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT155_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA70
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT156_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT156_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT156_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT156_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA74
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT157_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT157_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT157_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT157_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA78
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT158_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT158_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT158_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT158_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA7C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT159_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT159_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT159_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT159_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA80
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT160_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT160_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT160_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT160_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA84
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT161_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT161_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT161_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT161_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA88
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT162_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT162_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT162_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT162_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA8C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT163_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT163_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT163_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT163_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA90
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT164_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT164_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT164_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT164_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA94
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT165_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT165_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT165_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT165_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA98
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT166_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT166_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT166_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT166_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xA9C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT167_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT167_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT167_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT167_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAA0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT168_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT168_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT168_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT168_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAA4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT169_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT169_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT169_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT169_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAA8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT170_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT170_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT170_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT170_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAAC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT171_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT171_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT171_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT171_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAB0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT172_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT172_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT172_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT172_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAB4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT173_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT173_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT173_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT173_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAB8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT174_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT174_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT174_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT174_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xABC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT175_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT175_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT175_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT175_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAC0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT176_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT176_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT176_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT176_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAC4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT177_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT177_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT177_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT177_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAC8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT178_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT178_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT178_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT178_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xACC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT179_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT179_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT179_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT179_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAD0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT180_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT180_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT180_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT180_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAD4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT181_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT181_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT181_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT181_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAD8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT182_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT182_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT182_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT182_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xADC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT183_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT183_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT183_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT183_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAE0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT184_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT184_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT184_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT184_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAE4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT185_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT185_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT185_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT185_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAE8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT186_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT186_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT186_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT186_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAEC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT187_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT187_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT187_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT187_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAF0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT188_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT188_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT188_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT188_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAF4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT189_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT189_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT189_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT189_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAF8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT190_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT190_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT190_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT190_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xAFC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT191_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT191_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT191_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT191_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB00
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT192_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT192_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT192_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT192_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB04
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT193_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT193_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT193_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT193_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB08
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT194_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT194_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT194_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT194_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB0C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT195_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT195_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT195_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT195_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB10
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT196_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT196_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT196_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT196_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB14
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT197_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT197_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT197_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT197_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB18
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT198_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT198_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT198_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT198_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB1C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT199_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT199_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT199_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT199_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT200_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT200_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT200_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT200_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB24
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT201_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT201_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT201_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT201_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB28
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT202_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT202_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT202_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT202_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB2C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT203_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT203_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT203_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT203_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB30
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT204_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT204_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT204_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT204_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB34
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT205_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT205_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT205_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT205_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB38
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT206_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT206_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT206_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT206_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB3C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT207_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT207_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT207_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT207_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT208_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT208_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT208_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT208_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB44
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT209_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT209_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT209_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT209_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB48
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT210_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT210_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT210_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT210_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB4C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT211_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT211_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT211_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT211_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB50
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT212_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT212_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT212_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT212_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB54
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT213_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT213_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT213_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT213_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB58
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT214_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT214_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT214_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT214_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB5C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT215_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT215_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT215_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT215_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB60
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT216_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT216_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT216_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT216_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB64
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT217_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT217_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT217_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT217_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB68
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT218_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT218_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT218_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT218_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB6C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT219_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT219_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT219_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT219_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB70
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT220_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT220_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT220_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT220_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB74
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT221_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT221_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT221_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT221_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB78
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT222_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT222_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT222_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT222_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB7C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT223_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT223_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT223_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT223_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT224_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT224_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT224_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT224_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB84
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT225_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT225_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT225_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT225_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB88
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT226_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT226_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT226_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT226_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB8C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT227_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT227_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT227_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT227_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB90
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT228_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT228_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT228_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT228_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB94
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT229_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT229_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT229_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT229_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB98
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT230_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT230_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT230_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT230_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xB9C
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT231_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT231_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT231_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT231_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBA0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT232_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT232_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT232_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT232_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBA4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT233_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT233_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT233_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT233_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBA8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT234_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT234_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT234_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT234_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBAC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT235_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT235_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT235_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT235_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBB0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT236_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT236_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT236_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT236_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBB4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT237_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT237_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT237_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT237_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBB8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT238_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT238_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT238_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT238_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBBC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT239_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT239_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT239_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT239_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT240_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT240_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT240_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT240_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBC4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT241_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT241_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT241_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT241_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBC8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT242_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT242_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT242_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT242_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBCC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT243_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT243_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT243_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT243_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBD0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT244_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT244_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT244_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT244_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBD4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT245_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT245_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT245_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT245_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBD8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT246_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT246_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT246_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT246_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBDC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT247_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT247_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT247_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT247_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBE0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT248_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT248_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT248_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT248_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBE4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT249_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT249_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT249_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT249_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBE8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT250_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT250_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT250_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT250_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBEC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT251_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT251_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT251_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT251_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBF0
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT252_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT252_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT252_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT252_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBF4
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT253_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT253_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT253_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT253_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBF8
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT254_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT254_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT254_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT254_ALPHA                      \ Alpha


\
\ @brief DMA2D background CLUT
\ Address offset: 0xBFC
\ Reset value: 0x00000000
\

$000000ff constant DMA2D_DMA2D_BGCLUT255_BLUE                       \ Blue
$0000ff00 constant DMA2D_DMA2D_BGCLUT255_GREEN                      \ Green
$00ff0000 constant DMA2D_DMA2D_BGCLUT255_RED                        \ Red
$ff000000 constant DMA2D_DMA2D_BGCLUT255_ALPHA                      \ Alpha


\
\ @brief Chrom-ART Accelerator controller
\
$48021000 constant DMA2D_DMA2D_CR  \ offset: 0x00 : DMA2D control register
$48021004 constant DMA2D_DMA2D_ISR  \ offset: 0x04 : DMA2D interrupt status register
$48021008 constant DMA2D_DMA2D_IFCR  \ offset: 0x08 : DMA2D interrupt flag clear register
$4802100c constant DMA2D_DMA2D_FGMAR  \ offset: 0x0C : DMA2D foreground memory address register
$48021010 constant DMA2D_DMA2D_FGOR  \ offset: 0x10 : DMA2D foreground offset register
$48021014 constant DMA2D_DMA2D_BGMAR  \ offset: 0x14 : DMA2D background memory address register
$48021018 constant DMA2D_DMA2D_BGOR  \ offset: 0x18 : DMA2D background offset register
$4802101c constant DMA2D_DMA2D_FGPFCCR  \ offset: 0x1C : DMA2D foreground PFC control register
$48021020 constant DMA2D_DMA2D_FGCOLR  \ offset: 0x20 : DMA2D foreground color register
$48021024 constant DMA2D_DMA2D_BGPFCCR  \ offset: 0x24 : DMA2D background PFC control register
$48021028 constant DMA2D_DMA2D_BGCOLR  \ offset: 0x28 : DMA2D background color register
$4802102c constant DMA2D_DMA2D_FGCMAR  \ offset: 0x2C : DMA2D foreground CLUT memory address register
$48021030 constant DMA2D_DMA2D_BGCMAR  \ offset: 0x30 : DMA2D background CLUT memory address register
$48021034 constant DMA2D_DMA2D_OPFCCR  \ offset: 0x34 : DMA2D output PFC control register
$48021038 constant DMA2D_DMA2D_OCOLR_RGB888  \ offset: 0x38 : DMA2D output color register
$48021038 constant DMA2D_DMA2D_OCOLR_RGB565  \ offset: 0x38 : DMA2D output color register
$48021038 constant DMA2D_DMA2D_OCOLR_ARGB1555  \ offset: 0x38 : DMA2D output color register
$48021038 constant DMA2D_DMA2D_OCOLR_ARGB4444  \ offset: 0x38 : DMA2D output color register
$4802103c constant DMA2D_DMA2D_OMAR  \ offset: 0x3C : DMA2D output memory address register
$48021040 constant DMA2D_DMA2D_OOR  \ offset: 0x40 : DMA2D output offset register
$48021044 constant DMA2D_DMA2D_NLR  \ offset: 0x44 : DMA2D number of line register
$48021048 constant DMA2D_DMA2D_LWR  \ offset: 0x48 : DMA2D line watermark register
$4802104c constant DMA2D_DMA2D_AMTCR  \ offset: 0x4C : DMA2D AXI master timer configuration register
$48021400 constant DMA2D_DMA2D_FGCLUT0  \ offset: 0x400 : DMA2D foreground CLUT
$48021404 constant DMA2D_DMA2D_FGCLUT1  \ offset: 0x404 : DMA2D foreground CLUT
$48021408 constant DMA2D_DMA2D_FGCLUT2  \ offset: 0x408 : DMA2D foreground CLUT
$4802140c constant DMA2D_DMA2D_FGCLUT3  \ offset: 0x40C : DMA2D foreground CLUT
$48021410 constant DMA2D_DMA2D_FGCLUT4  \ offset: 0x410 : DMA2D foreground CLUT
$48021414 constant DMA2D_DMA2D_FGCLUT5  \ offset: 0x414 : DMA2D foreground CLUT
$48021418 constant DMA2D_DMA2D_FGCLUT6  \ offset: 0x418 : DMA2D foreground CLUT
$4802141c constant DMA2D_DMA2D_FGCLUT7  \ offset: 0x41C : DMA2D foreground CLUT
$48021420 constant DMA2D_DMA2D_FGCLUT8  \ offset: 0x420 : DMA2D foreground CLUT
$48021424 constant DMA2D_DMA2D_FGCLUT9  \ offset: 0x424 : DMA2D foreground CLUT
$48021428 constant DMA2D_DMA2D_FGCLUT10  \ offset: 0x428 : DMA2D foreground CLUT
$4802142c constant DMA2D_DMA2D_FGCLUT11  \ offset: 0x42C : DMA2D foreground CLUT
$48021430 constant DMA2D_DMA2D_FGCLUT12  \ offset: 0x430 : DMA2D foreground CLUT
$48021434 constant DMA2D_DMA2D_FGCLUT13  \ offset: 0x434 : DMA2D foreground CLUT
$48021438 constant DMA2D_DMA2D_FGCLUT14  \ offset: 0x438 : DMA2D foreground CLUT
$4802143c constant DMA2D_DMA2D_FGCLUT15  \ offset: 0x43C : DMA2D foreground CLUT
$48021440 constant DMA2D_DMA2D_FGCLUT16  \ offset: 0x440 : DMA2D foreground CLUT
$48021444 constant DMA2D_DMA2D_FGCLUT17  \ offset: 0x444 : DMA2D foreground CLUT
$48021448 constant DMA2D_DMA2D_FGCLUT18  \ offset: 0x448 : DMA2D foreground CLUT
$4802144c constant DMA2D_DMA2D_FGCLUT19  \ offset: 0x44C : DMA2D foreground CLUT
$48021450 constant DMA2D_DMA2D_FGCLUT20  \ offset: 0x450 : DMA2D foreground CLUT
$48021454 constant DMA2D_DMA2D_FGCLUT21  \ offset: 0x454 : DMA2D foreground CLUT
$48021458 constant DMA2D_DMA2D_FGCLUT22  \ offset: 0x458 : DMA2D foreground CLUT
$4802145c constant DMA2D_DMA2D_FGCLUT23  \ offset: 0x45C : DMA2D foreground CLUT
$48021460 constant DMA2D_DMA2D_FGCLUT24  \ offset: 0x460 : DMA2D foreground CLUT
$48021464 constant DMA2D_DMA2D_FGCLUT25  \ offset: 0x464 : DMA2D foreground CLUT
$48021468 constant DMA2D_DMA2D_FGCLUT26  \ offset: 0x468 : DMA2D foreground CLUT
$4802146c constant DMA2D_DMA2D_FGCLUT27  \ offset: 0x46C : DMA2D foreground CLUT
$48021470 constant DMA2D_DMA2D_FGCLUT28  \ offset: 0x470 : DMA2D foreground CLUT
$48021474 constant DMA2D_DMA2D_FGCLUT29  \ offset: 0x474 : DMA2D foreground CLUT
$48021478 constant DMA2D_DMA2D_FGCLUT30  \ offset: 0x478 : DMA2D foreground CLUT
$4802147c constant DMA2D_DMA2D_FGCLUT31  \ offset: 0x47C : DMA2D foreground CLUT
$48021480 constant DMA2D_DMA2D_FGCLUT32  \ offset: 0x480 : DMA2D foreground CLUT
$48021484 constant DMA2D_DMA2D_FGCLUT33  \ offset: 0x484 : DMA2D foreground CLUT
$48021488 constant DMA2D_DMA2D_FGCLUT34  \ offset: 0x488 : DMA2D foreground CLUT
$4802148c constant DMA2D_DMA2D_FGCLUT35  \ offset: 0x48C : DMA2D foreground CLUT
$48021490 constant DMA2D_DMA2D_FGCLUT36  \ offset: 0x490 : DMA2D foreground CLUT
$48021494 constant DMA2D_DMA2D_FGCLUT37  \ offset: 0x494 : DMA2D foreground CLUT
$48021498 constant DMA2D_DMA2D_FGCLUT38  \ offset: 0x498 : DMA2D foreground CLUT
$4802149c constant DMA2D_DMA2D_FGCLUT39  \ offset: 0x49C : DMA2D foreground CLUT
$480214a0 constant DMA2D_DMA2D_FGCLUT40  \ offset: 0x4A0 : DMA2D foreground CLUT
$480214a4 constant DMA2D_DMA2D_FGCLUT41  \ offset: 0x4A4 : DMA2D foreground CLUT
$480214a8 constant DMA2D_DMA2D_FGCLUT42  \ offset: 0x4A8 : DMA2D foreground CLUT
$480214ac constant DMA2D_DMA2D_FGCLUT43  \ offset: 0x4AC : DMA2D foreground CLUT
$480214b0 constant DMA2D_DMA2D_FGCLUT44  \ offset: 0x4B0 : DMA2D foreground CLUT
$480214b4 constant DMA2D_DMA2D_FGCLUT45  \ offset: 0x4B4 : DMA2D foreground CLUT
$480214b8 constant DMA2D_DMA2D_FGCLUT46  \ offset: 0x4B8 : DMA2D foreground CLUT
$480214bc constant DMA2D_DMA2D_FGCLUT47  \ offset: 0x4BC : DMA2D foreground CLUT
$480214c0 constant DMA2D_DMA2D_FGCLUT48  \ offset: 0x4C0 : DMA2D foreground CLUT
$480214c4 constant DMA2D_DMA2D_FGCLUT49  \ offset: 0x4C4 : DMA2D foreground CLUT
$480214c8 constant DMA2D_DMA2D_FGCLUT50  \ offset: 0x4C8 : DMA2D foreground CLUT
$480214cc constant DMA2D_DMA2D_FGCLUT51  \ offset: 0x4CC : DMA2D foreground CLUT
$480214d0 constant DMA2D_DMA2D_FGCLUT52  \ offset: 0x4D0 : DMA2D foreground CLUT
$480214d4 constant DMA2D_DMA2D_FGCLUT53  \ offset: 0x4D4 : DMA2D foreground CLUT
$480214d8 constant DMA2D_DMA2D_FGCLUT54  \ offset: 0x4D8 : DMA2D foreground CLUT
$480214dc constant DMA2D_DMA2D_FGCLUT55  \ offset: 0x4DC : DMA2D foreground CLUT
$480214e0 constant DMA2D_DMA2D_FGCLUT56  \ offset: 0x4E0 : DMA2D foreground CLUT
$480214e4 constant DMA2D_DMA2D_FGCLUT57  \ offset: 0x4E4 : DMA2D foreground CLUT
$480214e8 constant DMA2D_DMA2D_FGCLUT58  \ offset: 0x4E8 : DMA2D foreground CLUT
$480214ec constant DMA2D_DMA2D_FGCLUT59  \ offset: 0x4EC : DMA2D foreground CLUT
$480214f0 constant DMA2D_DMA2D_FGCLUT60  \ offset: 0x4F0 : DMA2D foreground CLUT
$480214f4 constant DMA2D_DMA2D_FGCLUT61  \ offset: 0x4F4 : DMA2D foreground CLUT
$480214f8 constant DMA2D_DMA2D_FGCLUT62  \ offset: 0x4F8 : DMA2D foreground CLUT
$480214fc constant DMA2D_DMA2D_FGCLUT63  \ offset: 0x4FC : DMA2D foreground CLUT
$48021500 constant DMA2D_DMA2D_FGCLUT64  \ offset: 0x500 : DMA2D foreground CLUT
$48021504 constant DMA2D_DMA2D_FGCLUT65  \ offset: 0x504 : DMA2D foreground CLUT
$48021508 constant DMA2D_DMA2D_FGCLUT66  \ offset: 0x508 : DMA2D foreground CLUT
$4802150c constant DMA2D_DMA2D_FGCLUT67  \ offset: 0x50C : DMA2D foreground CLUT
$48021510 constant DMA2D_DMA2D_FGCLUT68  \ offset: 0x510 : DMA2D foreground CLUT
$48021514 constant DMA2D_DMA2D_FGCLUT69  \ offset: 0x514 : DMA2D foreground CLUT
$48021518 constant DMA2D_DMA2D_FGCLUT70  \ offset: 0x518 : DMA2D foreground CLUT
$4802151c constant DMA2D_DMA2D_FGCLUT71  \ offset: 0x51C : DMA2D foreground CLUT
$48021520 constant DMA2D_DMA2D_FGCLUT72  \ offset: 0x520 : DMA2D foreground CLUT
$48021524 constant DMA2D_DMA2D_FGCLUT73  \ offset: 0x524 : DMA2D foreground CLUT
$48021528 constant DMA2D_DMA2D_FGCLUT74  \ offset: 0x528 : DMA2D foreground CLUT
$4802152c constant DMA2D_DMA2D_FGCLUT75  \ offset: 0x52C : DMA2D foreground CLUT
$48021530 constant DMA2D_DMA2D_FGCLUT76  \ offset: 0x530 : DMA2D foreground CLUT
$48021534 constant DMA2D_DMA2D_FGCLUT77  \ offset: 0x534 : DMA2D foreground CLUT
$48021538 constant DMA2D_DMA2D_FGCLUT78  \ offset: 0x538 : DMA2D foreground CLUT
$4802153c constant DMA2D_DMA2D_FGCLUT79  \ offset: 0x53C : DMA2D foreground CLUT
$48021540 constant DMA2D_DMA2D_FGCLUT80  \ offset: 0x540 : DMA2D foreground CLUT
$48021544 constant DMA2D_DMA2D_FGCLUT81  \ offset: 0x544 : DMA2D foreground CLUT
$48021548 constant DMA2D_DMA2D_FGCLUT82  \ offset: 0x548 : DMA2D foreground CLUT
$4802154c constant DMA2D_DMA2D_FGCLUT83  \ offset: 0x54C : DMA2D foreground CLUT
$48021550 constant DMA2D_DMA2D_FGCLUT84  \ offset: 0x550 : DMA2D foreground CLUT
$48021554 constant DMA2D_DMA2D_FGCLUT85  \ offset: 0x554 : DMA2D foreground CLUT
$48021558 constant DMA2D_DMA2D_FGCLUT86  \ offset: 0x558 : DMA2D foreground CLUT
$4802155c constant DMA2D_DMA2D_FGCLUT87  \ offset: 0x55C : DMA2D foreground CLUT
$48021560 constant DMA2D_DMA2D_FGCLUT88  \ offset: 0x560 : DMA2D foreground CLUT
$48021564 constant DMA2D_DMA2D_FGCLUT89  \ offset: 0x564 : DMA2D foreground CLUT
$48021568 constant DMA2D_DMA2D_FGCLUT90  \ offset: 0x568 : DMA2D foreground CLUT
$4802156c constant DMA2D_DMA2D_FGCLUT91  \ offset: 0x56C : DMA2D foreground CLUT
$48021570 constant DMA2D_DMA2D_FGCLUT92  \ offset: 0x570 : DMA2D foreground CLUT
$48021574 constant DMA2D_DMA2D_FGCLUT93  \ offset: 0x574 : DMA2D foreground CLUT
$48021578 constant DMA2D_DMA2D_FGCLUT94  \ offset: 0x578 : DMA2D foreground CLUT
$4802157c constant DMA2D_DMA2D_FGCLUT95  \ offset: 0x57C : DMA2D foreground CLUT
$48021580 constant DMA2D_DMA2D_FGCLUT96  \ offset: 0x580 : DMA2D foreground CLUT
$48021584 constant DMA2D_DMA2D_FGCLUT97  \ offset: 0x584 : DMA2D foreground CLUT
$48021588 constant DMA2D_DMA2D_FGCLUT98  \ offset: 0x588 : DMA2D foreground CLUT
$4802158c constant DMA2D_DMA2D_FGCLUT99  \ offset: 0x58C : DMA2D foreground CLUT
$48021590 constant DMA2D_DMA2D_FGCLUT100  \ offset: 0x590 : DMA2D foreground CLUT
$48021594 constant DMA2D_DMA2D_FGCLUT101  \ offset: 0x594 : DMA2D foreground CLUT
$48021598 constant DMA2D_DMA2D_FGCLUT102  \ offset: 0x598 : DMA2D foreground CLUT
$4802159c constant DMA2D_DMA2D_FGCLUT103  \ offset: 0x59C : DMA2D foreground CLUT
$480215a0 constant DMA2D_DMA2D_FGCLUT104  \ offset: 0x5A0 : DMA2D foreground CLUT
$480215a4 constant DMA2D_DMA2D_FGCLUT105  \ offset: 0x5A4 : DMA2D foreground CLUT
$480215a8 constant DMA2D_DMA2D_FGCLUT106  \ offset: 0x5A8 : DMA2D foreground CLUT
$480215ac constant DMA2D_DMA2D_FGCLUT107  \ offset: 0x5AC : DMA2D foreground CLUT
$480215b0 constant DMA2D_DMA2D_FGCLUT108  \ offset: 0x5B0 : DMA2D foreground CLUT
$480215b4 constant DMA2D_DMA2D_FGCLUT109  \ offset: 0x5B4 : DMA2D foreground CLUT
$480215b8 constant DMA2D_DMA2D_FGCLUT110  \ offset: 0x5B8 : DMA2D foreground CLUT
$480215bc constant DMA2D_DMA2D_FGCLUT111  \ offset: 0x5BC : DMA2D foreground CLUT
$480215c0 constant DMA2D_DMA2D_FGCLUT112  \ offset: 0x5C0 : DMA2D foreground CLUT
$480215c4 constant DMA2D_DMA2D_FGCLUT113  \ offset: 0x5C4 : DMA2D foreground CLUT
$480215c8 constant DMA2D_DMA2D_FGCLUT114  \ offset: 0x5C8 : DMA2D foreground CLUT
$480215cc constant DMA2D_DMA2D_FGCLUT115  \ offset: 0x5CC : DMA2D foreground CLUT
$480215d0 constant DMA2D_DMA2D_FGCLUT116  \ offset: 0x5D0 : DMA2D foreground CLUT
$480215d4 constant DMA2D_DMA2D_FGCLUT117  \ offset: 0x5D4 : DMA2D foreground CLUT
$480215d8 constant DMA2D_DMA2D_FGCLUT118  \ offset: 0x5D8 : DMA2D foreground CLUT
$480215dc constant DMA2D_DMA2D_FGCLUT119  \ offset: 0x5DC : DMA2D foreground CLUT
$480215e0 constant DMA2D_DMA2D_FGCLUT120  \ offset: 0x5E0 : DMA2D foreground CLUT
$480215e4 constant DMA2D_DMA2D_FGCLUT121  \ offset: 0x5E4 : DMA2D foreground CLUT
$480215e8 constant DMA2D_DMA2D_FGCLUT122  \ offset: 0x5E8 : DMA2D foreground CLUT
$480215ec constant DMA2D_DMA2D_FGCLUT123  \ offset: 0x5EC : DMA2D foreground CLUT
$480215f0 constant DMA2D_DMA2D_FGCLUT124  \ offset: 0x5F0 : DMA2D foreground CLUT
$480215f4 constant DMA2D_DMA2D_FGCLUT125  \ offset: 0x5F4 : DMA2D foreground CLUT
$480215f8 constant DMA2D_DMA2D_FGCLUT126  \ offset: 0x5F8 : DMA2D foreground CLUT
$480215fc constant DMA2D_DMA2D_FGCLUT127  \ offset: 0x5FC : DMA2D foreground CLUT
$48021600 constant DMA2D_DMA2D_FGCLUT128  \ offset: 0x600 : DMA2D foreground CLUT
$48021604 constant DMA2D_DMA2D_FGCLUT129  \ offset: 0x604 : DMA2D foreground CLUT
$48021608 constant DMA2D_DMA2D_FGCLUT130  \ offset: 0x608 : DMA2D foreground CLUT
$4802160c constant DMA2D_DMA2D_FGCLUT131  \ offset: 0x60C : DMA2D foreground CLUT
$48021610 constant DMA2D_DMA2D_FGCLUT132  \ offset: 0x610 : DMA2D foreground CLUT
$48021614 constant DMA2D_DMA2D_FGCLUT133  \ offset: 0x614 : DMA2D foreground CLUT
$48021618 constant DMA2D_DMA2D_FGCLUT134  \ offset: 0x618 : DMA2D foreground CLUT
$4802161c constant DMA2D_DMA2D_FGCLUT135  \ offset: 0x61C : DMA2D foreground CLUT
$48021620 constant DMA2D_DMA2D_FGCLUT136  \ offset: 0x620 : DMA2D foreground CLUT
$48021624 constant DMA2D_DMA2D_FGCLUT137  \ offset: 0x624 : DMA2D foreground CLUT
$48021628 constant DMA2D_DMA2D_FGCLUT138  \ offset: 0x628 : DMA2D foreground CLUT
$4802162c constant DMA2D_DMA2D_FGCLUT139  \ offset: 0x62C : DMA2D foreground CLUT
$48021630 constant DMA2D_DMA2D_FGCLUT140  \ offset: 0x630 : DMA2D foreground CLUT
$48021634 constant DMA2D_DMA2D_FGCLUT141  \ offset: 0x634 : DMA2D foreground CLUT
$48021638 constant DMA2D_DMA2D_FGCLUT142  \ offset: 0x638 : DMA2D foreground CLUT
$4802163c constant DMA2D_DMA2D_FGCLUT143  \ offset: 0x63C : DMA2D foreground CLUT
$48021640 constant DMA2D_DMA2D_FGCLUT144  \ offset: 0x640 : DMA2D foreground CLUT
$48021644 constant DMA2D_DMA2D_FGCLUT145  \ offset: 0x644 : DMA2D foreground CLUT
$48021648 constant DMA2D_DMA2D_FGCLUT146  \ offset: 0x648 : DMA2D foreground CLUT
$4802164c constant DMA2D_DMA2D_FGCLUT147  \ offset: 0x64C : DMA2D foreground CLUT
$48021650 constant DMA2D_DMA2D_FGCLUT148  \ offset: 0x650 : DMA2D foreground CLUT
$48021654 constant DMA2D_DMA2D_FGCLUT149  \ offset: 0x654 : DMA2D foreground CLUT
$48021658 constant DMA2D_DMA2D_FGCLUT150  \ offset: 0x658 : DMA2D foreground CLUT
$4802165c constant DMA2D_DMA2D_FGCLUT151  \ offset: 0x65C : DMA2D foreground CLUT
$48021660 constant DMA2D_DMA2D_FGCLUT152  \ offset: 0x660 : DMA2D foreground CLUT
$48021664 constant DMA2D_DMA2D_FGCLUT153  \ offset: 0x664 : DMA2D foreground CLUT
$48021668 constant DMA2D_DMA2D_FGCLUT154  \ offset: 0x668 : DMA2D foreground CLUT
$4802166c constant DMA2D_DMA2D_FGCLUT155  \ offset: 0x66C : DMA2D foreground CLUT
$48021670 constant DMA2D_DMA2D_FGCLUT156  \ offset: 0x670 : DMA2D foreground CLUT
$48021674 constant DMA2D_DMA2D_FGCLUT157  \ offset: 0x674 : DMA2D foreground CLUT
$48021678 constant DMA2D_DMA2D_FGCLUT158  \ offset: 0x678 : DMA2D foreground CLUT
$4802167c constant DMA2D_DMA2D_FGCLUT159  \ offset: 0x67C : DMA2D foreground CLUT
$48021680 constant DMA2D_DMA2D_FGCLUT160  \ offset: 0x680 : DMA2D foreground CLUT
$48021684 constant DMA2D_DMA2D_FGCLUT161  \ offset: 0x684 : DMA2D foreground CLUT
$48021688 constant DMA2D_DMA2D_FGCLUT162  \ offset: 0x688 : DMA2D foreground CLUT
$4802168c constant DMA2D_DMA2D_FGCLUT163  \ offset: 0x68C : DMA2D foreground CLUT
$48021690 constant DMA2D_DMA2D_FGCLUT164  \ offset: 0x690 : DMA2D foreground CLUT
$48021694 constant DMA2D_DMA2D_FGCLUT165  \ offset: 0x694 : DMA2D foreground CLUT
$48021698 constant DMA2D_DMA2D_FGCLUT166  \ offset: 0x698 : DMA2D foreground CLUT
$4802169c constant DMA2D_DMA2D_FGCLUT167  \ offset: 0x69C : DMA2D foreground CLUT
$480216a0 constant DMA2D_DMA2D_FGCLUT168  \ offset: 0x6A0 : DMA2D foreground CLUT
$480216a4 constant DMA2D_DMA2D_FGCLUT169  \ offset: 0x6A4 : DMA2D foreground CLUT
$480216a8 constant DMA2D_DMA2D_FGCLUT170  \ offset: 0x6A8 : DMA2D foreground CLUT
$480216ac constant DMA2D_DMA2D_FGCLUT171  \ offset: 0x6AC : DMA2D foreground CLUT
$480216b0 constant DMA2D_DMA2D_FGCLUT172  \ offset: 0x6B0 : DMA2D foreground CLUT
$480216b4 constant DMA2D_DMA2D_FGCLUT173  \ offset: 0x6B4 : DMA2D foreground CLUT
$480216b8 constant DMA2D_DMA2D_FGCLUT174  \ offset: 0x6B8 : DMA2D foreground CLUT
$480216bc constant DMA2D_DMA2D_FGCLUT175  \ offset: 0x6BC : DMA2D foreground CLUT
$480216c0 constant DMA2D_DMA2D_FGCLUT176  \ offset: 0x6C0 : DMA2D foreground CLUT
$480216c4 constant DMA2D_DMA2D_FGCLUT177  \ offset: 0x6C4 : DMA2D foreground CLUT
$480216c8 constant DMA2D_DMA2D_FGCLUT178  \ offset: 0x6C8 : DMA2D foreground CLUT
$480216cc constant DMA2D_DMA2D_FGCLUT179  \ offset: 0x6CC : DMA2D foreground CLUT
$480216d0 constant DMA2D_DMA2D_FGCLUT180  \ offset: 0x6D0 : DMA2D foreground CLUT
$480216d4 constant DMA2D_DMA2D_FGCLUT181  \ offset: 0x6D4 : DMA2D foreground CLUT
$480216d8 constant DMA2D_DMA2D_FGCLUT182  \ offset: 0x6D8 : DMA2D foreground CLUT
$480216dc constant DMA2D_DMA2D_FGCLUT183  \ offset: 0x6DC : DMA2D foreground CLUT
$480216e0 constant DMA2D_DMA2D_FGCLUT184  \ offset: 0x6E0 : DMA2D foreground CLUT
$480216e4 constant DMA2D_DMA2D_FGCLUT185  \ offset: 0x6E4 : DMA2D foreground CLUT
$480216e8 constant DMA2D_DMA2D_FGCLUT186  \ offset: 0x6E8 : DMA2D foreground CLUT
$480216ec constant DMA2D_DMA2D_FGCLUT187  \ offset: 0x6EC : DMA2D foreground CLUT
$480216f0 constant DMA2D_DMA2D_FGCLUT188  \ offset: 0x6F0 : DMA2D foreground CLUT
$480216f4 constant DMA2D_DMA2D_FGCLUT189  \ offset: 0x6F4 : DMA2D foreground CLUT
$480216f8 constant DMA2D_DMA2D_FGCLUT190  \ offset: 0x6F8 : DMA2D foreground CLUT
$480216fc constant DMA2D_DMA2D_FGCLUT191  \ offset: 0x6FC : DMA2D foreground CLUT
$48021700 constant DMA2D_DMA2D_FGCLUT192  \ offset: 0x700 : DMA2D foreground CLUT
$48021704 constant DMA2D_DMA2D_FGCLUT193  \ offset: 0x704 : DMA2D foreground CLUT
$48021708 constant DMA2D_DMA2D_FGCLUT194  \ offset: 0x708 : DMA2D foreground CLUT
$4802170c constant DMA2D_DMA2D_FGCLUT195  \ offset: 0x70C : DMA2D foreground CLUT
$48021710 constant DMA2D_DMA2D_FGCLUT196  \ offset: 0x710 : DMA2D foreground CLUT
$48021714 constant DMA2D_DMA2D_FGCLUT197  \ offset: 0x714 : DMA2D foreground CLUT
$48021718 constant DMA2D_DMA2D_FGCLUT198  \ offset: 0x718 : DMA2D foreground CLUT
$4802171c constant DMA2D_DMA2D_FGCLUT199  \ offset: 0x71C : DMA2D foreground CLUT
$48021720 constant DMA2D_DMA2D_FGCLUT200  \ offset: 0x720 : DMA2D foreground CLUT
$48021724 constant DMA2D_DMA2D_FGCLUT201  \ offset: 0x724 : DMA2D foreground CLUT
$48021728 constant DMA2D_DMA2D_FGCLUT202  \ offset: 0x728 : DMA2D foreground CLUT
$4802172c constant DMA2D_DMA2D_FGCLUT203  \ offset: 0x72C : DMA2D foreground CLUT
$48021730 constant DMA2D_DMA2D_FGCLUT204  \ offset: 0x730 : DMA2D foreground CLUT
$48021734 constant DMA2D_DMA2D_FGCLUT205  \ offset: 0x734 : DMA2D foreground CLUT
$48021738 constant DMA2D_DMA2D_FGCLUT206  \ offset: 0x738 : DMA2D foreground CLUT
$4802173c constant DMA2D_DMA2D_FGCLUT207  \ offset: 0x73C : DMA2D foreground CLUT
$48021740 constant DMA2D_DMA2D_FGCLUT208  \ offset: 0x740 : DMA2D foreground CLUT
$48021744 constant DMA2D_DMA2D_FGCLUT209  \ offset: 0x744 : DMA2D foreground CLUT
$48021748 constant DMA2D_DMA2D_FGCLUT210  \ offset: 0x748 : DMA2D foreground CLUT
$4802174c constant DMA2D_DMA2D_FGCLUT211  \ offset: 0x74C : DMA2D foreground CLUT
$48021750 constant DMA2D_DMA2D_FGCLUT212  \ offset: 0x750 : DMA2D foreground CLUT
$48021754 constant DMA2D_DMA2D_FGCLUT213  \ offset: 0x754 : DMA2D foreground CLUT
$48021758 constant DMA2D_DMA2D_FGCLUT214  \ offset: 0x758 : DMA2D foreground CLUT
$4802175c constant DMA2D_DMA2D_FGCLUT215  \ offset: 0x75C : DMA2D foreground CLUT
$48021760 constant DMA2D_DMA2D_FGCLUT216  \ offset: 0x760 : DMA2D foreground CLUT
$48021764 constant DMA2D_DMA2D_FGCLUT217  \ offset: 0x764 : DMA2D foreground CLUT
$48021768 constant DMA2D_DMA2D_FGCLUT218  \ offset: 0x768 : DMA2D foreground CLUT
$4802176c constant DMA2D_DMA2D_FGCLUT219  \ offset: 0x76C : DMA2D foreground CLUT
$48021770 constant DMA2D_DMA2D_FGCLUT220  \ offset: 0x770 : DMA2D foreground CLUT
$48021774 constant DMA2D_DMA2D_FGCLUT221  \ offset: 0x774 : DMA2D foreground CLUT
$48021778 constant DMA2D_DMA2D_FGCLUT222  \ offset: 0x778 : DMA2D foreground CLUT
$4802177c constant DMA2D_DMA2D_FGCLUT223  \ offset: 0x77C : DMA2D foreground CLUT
$48021780 constant DMA2D_DMA2D_FGCLUT224  \ offset: 0x780 : DMA2D foreground CLUT
$48021784 constant DMA2D_DMA2D_FGCLUT225  \ offset: 0x784 : DMA2D foreground CLUT
$48021788 constant DMA2D_DMA2D_FGCLUT226  \ offset: 0x788 : DMA2D foreground CLUT
$4802178c constant DMA2D_DMA2D_FGCLUT227  \ offset: 0x78C : DMA2D foreground CLUT
$48021790 constant DMA2D_DMA2D_FGCLUT228  \ offset: 0x790 : DMA2D foreground CLUT
$48021794 constant DMA2D_DMA2D_FGCLUT229  \ offset: 0x794 : DMA2D foreground CLUT
$48021798 constant DMA2D_DMA2D_FGCLUT230  \ offset: 0x798 : DMA2D foreground CLUT
$4802179c constant DMA2D_DMA2D_FGCLUT231  \ offset: 0x79C : DMA2D foreground CLUT
$480217a0 constant DMA2D_DMA2D_FGCLUT232  \ offset: 0x7A0 : DMA2D foreground CLUT
$480217a4 constant DMA2D_DMA2D_FGCLUT233  \ offset: 0x7A4 : DMA2D foreground CLUT
$480217a8 constant DMA2D_DMA2D_FGCLUT234  \ offset: 0x7A8 : DMA2D foreground CLUT
$480217ac constant DMA2D_DMA2D_FGCLUT235  \ offset: 0x7AC : DMA2D foreground CLUT
$480217b0 constant DMA2D_DMA2D_FGCLUT236  \ offset: 0x7B0 : DMA2D foreground CLUT
$480217b4 constant DMA2D_DMA2D_FGCLUT237  \ offset: 0x7B4 : DMA2D foreground CLUT
$480217b8 constant DMA2D_DMA2D_FGCLUT238  \ offset: 0x7B8 : DMA2D foreground CLUT
$480217bc constant DMA2D_DMA2D_FGCLUT239  \ offset: 0x7BC : DMA2D foreground CLUT
$480217c0 constant DMA2D_DMA2D_FGCLUT240  \ offset: 0x7C0 : DMA2D foreground CLUT
$480217c4 constant DMA2D_DMA2D_FGCLUT241  \ offset: 0x7C4 : DMA2D foreground CLUT
$480217c8 constant DMA2D_DMA2D_FGCLUT242  \ offset: 0x7C8 : DMA2D foreground CLUT
$480217cc constant DMA2D_DMA2D_FGCLUT243  \ offset: 0x7CC : DMA2D foreground CLUT
$480217d0 constant DMA2D_DMA2D_FGCLUT244  \ offset: 0x7D0 : DMA2D foreground CLUT
$480217d4 constant DMA2D_DMA2D_FGCLUT245  \ offset: 0x7D4 : DMA2D foreground CLUT
$480217d8 constant DMA2D_DMA2D_FGCLUT246  \ offset: 0x7D8 : DMA2D foreground CLUT
$480217dc constant DMA2D_DMA2D_FGCLUT247  \ offset: 0x7DC : DMA2D foreground CLUT
$480217e0 constant DMA2D_DMA2D_FGCLUT248  \ offset: 0x7E0 : DMA2D foreground CLUT
$480217e4 constant DMA2D_DMA2D_FGCLUT249  \ offset: 0x7E4 : DMA2D foreground CLUT
$480217e8 constant DMA2D_DMA2D_FGCLUT250  \ offset: 0x7E8 : DMA2D foreground CLUT
$480217ec constant DMA2D_DMA2D_FGCLUT251  \ offset: 0x7EC : DMA2D foreground CLUT
$480217f0 constant DMA2D_DMA2D_FGCLUT252  \ offset: 0x7F0 : DMA2D foreground CLUT
$480217f4 constant DMA2D_DMA2D_FGCLUT253  \ offset: 0x7F4 : DMA2D foreground CLUT
$480217f8 constant DMA2D_DMA2D_FGCLUT254  \ offset: 0x7F8 : DMA2D foreground CLUT
$480217fc constant DMA2D_DMA2D_FGCLUT255  \ offset: 0x7FC : DMA2D foreground CLUT
$48021800 constant DMA2D_DMA2D_BGCLUT0  \ offset: 0x800 : DMA2D background CLUT
$48021804 constant DMA2D_DMA2D_BGCLUT1  \ offset: 0x804 : DMA2D background CLUT
$48021808 constant DMA2D_DMA2D_BGCLUT2  \ offset: 0x808 : DMA2D background CLUT
$4802180c constant DMA2D_DMA2D_BGCLUT3  \ offset: 0x80C : DMA2D background CLUT
$48021810 constant DMA2D_DMA2D_BGCLUT4  \ offset: 0x810 : DMA2D background CLUT
$48021814 constant DMA2D_DMA2D_BGCLUT5  \ offset: 0x814 : DMA2D background CLUT
$48021818 constant DMA2D_DMA2D_BGCLUT6  \ offset: 0x818 : DMA2D background CLUT
$4802181c constant DMA2D_DMA2D_BGCLUT7  \ offset: 0x81C : DMA2D background CLUT
$48021820 constant DMA2D_DMA2D_BGCLUT8  \ offset: 0x820 : DMA2D background CLUT
$48021824 constant DMA2D_DMA2D_BGCLUT9  \ offset: 0x824 : DMA2D background CLUT
$48021828 constant DMA2D_DMA2D_BGCLUT10  \ offset: 0x828 : DMA2D background CLUT
$4802182c constant DMA2D_DMA2D_BGCLUT11  \ offset: 0x82C : DMA2D background CLUT
$48021830 constant DMA2D_DMA2D_BGCLUT12  \ offset: 0x830 : DMA2D background CLUT
$48021834 constant DMA2D_DMA2D_BGCLUT13  \ offset: 0x834 : DMA2D background CLUT
$48021838 constant DMA2D_DMA2D_BGCLUT14  \ offset: 0x838 : DMA2D background CLUT
$4802183c constant DMA2D_DMA2D_BGCLUT15  \ offset: 0x83C : DMA2D background CLUT
$48021840 constant DMA2D_DMA2D_BGCLUT16  \ offset: 0x840 : DMA2D background CLUT
$48021844 constant DMA2D_DMA2D_BGCLUT17  \ offset: 0x844 : DMA2D background CLUT
$48021848 constant DMA2D_DMA2D_BGCLUT18  \ offset: 0x848 : DMA2D background CLUT
$4802184c constant DMA2D_DMA2D_BGCLUT19  \ offset: 0x84C : DMA2D background CLUT
$48021850 constant DMA2D_DMA2D_BGCLUT20  \ offset: 0x850 : DMA2D background CLUT
$48021854 constant DMA2D_DMA2D_BGCLUT21  \ offset: 0x854 : DMA2D background CLUT
$48021858 constant DMA2D_DMA2D_BGCLUT22  \ offset: 0x858 : DMA2D background CLUT
$4802185c constant DMA2D_DMA2D_BGCLUT23  \ offset: 0x85C : DMA2D background CLUT
$48021860 constant DMA2D_DMA2D_BGCLUT24  \ offset: 0x860 : DMA2D background CLUT
$48021864 constant DMA2D_DMA2D_BGCLUT25  \ offset: 0x864 : DMA2D background CLUT
$48021868 constant DMA2D_DMA2D_BGCLUT26  \ offset: 0x868 : DMA2D background CLUT
$4802186c constant DMA2D_DMA2D_BGCLUT27  \ offset: 0x86C : DMA2D background CLUT
$48021870 constant DMA2D_DMA2D_BGCLUT28  \ offset: 0x870 : DMA2D background CLUT
$48021874 constant DMA2D_DMA2D_BGCLUT29  \ offset: 0x874 : DMA2D background CLUT
$48021878 constant DMA2D_DMA2D_BGCLUT30  \ offset: 0x878 : DMA2D background CLUT
$4802187c constant DMA2D_DMA2D_BGCLUT31  \ offset: 0x87C : DMA2D background CLUT
$48021880 constant DMA2D_DMA2D_BGCLUT32  \ offset: 0x880 : DMA2D background CLUT
$48021884 constant DMA2D_DMA2D_BGCLUT33  \ offset: 0x884 : DMA2D background CLUT
$48021888 constant DMA2D_DMA2D_BGCLUT34  \ offset: 0x888 : DMA2D background CLUT
$4802188c constant DMA2D_DMA2D_BGCLUT35  \ offset: 0x88C : DMA2D background CLUT
$48021890 constant DMA2D_DMA2D_BGCLUT36  \ offset: 0x890 : DMA2D background CLUT
$48021894 constant DMA2D_DMA2D_BGCLUT37  \ offset: 0x894 : DMA2D background CLUT
$48021898 constant DMA2D_DMA2D_BGCLUT38  \ offset: 0x898 : DMA2D background CLUT
$4802189c constant DMA2D_DMA2D_BGCLUT39  \ offset: 0x89C : DMA2D background CLUT
$480218a0 constant DMA2D_DMA2D_BGCLUT40  \ offset: 0x8A0 : DMA2D background CLUT
$480218a4 constant DMA2D_DMA2D_BGCLUT41  \ offset: 0x8A4 : DMA2D background CLUT
$480218a8 constant DMA2D_DMA2D_BGCLUT42  \ offset: 0x8A8 : DMA2D background CLUT
$480218ac constant DMA2D_DMA2D_BGCLUT43  \ offset: 0x8AC : DMA2D background CLUT
$480218b0 constant DMA2D_DMA2D_BGCLUT44  \ offset: 0x8B0 : DMA2D background CLUT
$480218b4 constant DMA2D_DMA2D_BGCLUT45  \ offset: 0x8B4 : DMA2D background CLUT
$480218b8 constant DMA2D_DMA2D_BGCLUT46  \ offset: 0x8B8 : DMA2D background CLUT
$480218bc constant DMA2D_DMA2D_BGCLUT47  \ offset: 0x8BC : DMA2D background CLUT
$480218c0 constant DMA2D_DMA2D_BGCLUT48  \ offset: 0x8C0 : DMA2D background CLUT
$480218c4 constant DMA2D_DMA2D_BGCLUT49  \ offset: 0x8C4 : DMA2D background CLUT
$480218c8 constant DMA2D_DMA2D_BGCLUT50  \ offset: 0x8C8 : DMA2D background CLUT
$480218cc constant DMA2D_DMA2D_BGCLUT51  \ offset: 0x8CC : DMA2D background CLUT
$480218d0 constant DMA2D_DMA2D_BGCLUT52  \ offset: 0x8D0 : DMA2D background CLUT
$480218d4 constant DMA2D_DMA2D_BGCLUT53  \ offset: 0x8D4 : DMA2D background CLUT
$480218d8 constant DMA2D_DMA2D_BGCLUT54  \ offset: 0x8D8 : DMA2D background CLUT
$480218dc constant DMA2D_DMA2D_BGCLUT55  \ offset: 0x8DC : DMA2D background CLUT
$480218e0 constant DMA2D_DMA2D_BGCLUT56  \ offset: 0x8E0 : DMA2D background CLUT
$480218e4 constant DMA2D_DMA2D_BGCLUT57  \ offset: 0x8E4 : DMA2D background CLUT
$480218e8 constant DMA2D_DMA2D_BGCLUT58  \ offset: 0x8E8 : DMA2D background CLUT
$480218ec constant DMA2D_DMA2D_BGCLUT59  \ offset: 0x8EC : DMA2D background CLUT
$480218f0 constant DMA2D_DMA2D_BGCLUT60  \ offset: 0x8F0 : DMA2D background CLUT
$480218f4 constant DMA2D_DMA2D_BGCLUT61  \ offset: 0x8F4 : DMA2D background CLUT
$480218f8 constant DMA2D_DMA2D_BGCLUT62  \ offset: 0x8F8 : DMA2D background CLUT
$480218fc constant DMA2D_DMA2D_BGCLUT63  \ offset: 0x8FC : DMA2D background CLUT
$48021900 constant DMA2D_DMA2D_BGCLUT64  \ offset: 0x900 : DMA2D background CLUT
$48021904 constant DMA2D_DMA2D_BGCLUT65  \ offset: 0x904 : DMA2D background CLUT
$48021908 constant DMA2D_DMA2D_BGCLUT66  \ offset: 0x908 : DMA2D background CLUT
$4802190c constant DMA2D_DMA2D_BGCLUT67  \ offset: 0x90C : DMA2D background CLUT
$48021910 constant DMA2D_DMA2D_BGCLUT68  \ offset: 0x910 : DMA2D background CLUT
$48021914 constant DMA2D_DMA2D_BGCLUT69  \ offset: 0x914 : DMA2D background CLUT
$48021918 constant DMA2D_DMA2D_BGCLUT70  \ offset: 0x918 : DMA2D background CLUT
$4802191c constant DMA2D_DMA2D_BGCLUT71  \ offset: 0x91C : DMA2D background CLUT
$48021920 constant DMA2D_DMA2D_BGCLUT72  \ offset: 0x920 : DMA2D background CLUT
$48021924 constant DMA2D_DMA2D_BGCLUT73  \ offset: 0x924 : DMA2D background CLUT
$48021928 constant DMA2D_DMA2D_BGCLUT74  \ offset: 0x928 : DMA2D background CLUT
$4802192c constant DMA2D_DMA2D_BGCLUT75  \ offset: 0x92C : DMA2D background CLUT
$48021930 constant DMA2D_DMA2D_BGCLUT76  \ offset: 0x930 : DMA2D background CLUT
$48021934 constant DMA2D_DMA2D_BGCLUT77  \ offset: 0x934 : DMA2D background CLUT
$48021938 constant DMA2D_DMA2D_BGCLUT78  \ offset: 0x938 : DMA2D background CLUT
$4802193c constant DMA2D_DMA2D_BGCLUT79  \ offset: 0x93C : DMA2D background CLUT
$48021940 constant DMA2D_DMA2D_BGCLUT80  \ offset: 0x940 : DMA2D background CLUT
$48021944 constant DMA2D_DMA2D_BGCLUT81  \ offset: 0x944 : DMA2D background CLUT
$48021948 constant DMA2D_DMA2D_BGCLUT82  \ offset: 0x948 : DMA2D background CLUT
$4802194c constant DMA2D_DMA2D_BGCLUT83  \ offset: 0x94C : DMA2D background CLUT
$48021950 constant DMA2D_DMA2D_BGCLUT84  \ offset: 0x950 : DMA2D background CLUT
$48021954 constant DMA2D_DMA2D_BGCLUT85  \ offset: 0x954 : DMA2D background CLUT
$48021958 constant DMA2D_DMA2D_BGCLUT86  \ offset: 0x958 : DMA2D background CLUT
$4802195c constant DMA2D_DMA2D_BGCLUT87  \ offset: 0x95C : DMA2D background CLUT
$48021960 constant DMA2D_DMA2D_BGCLUT88  \ offset: 0x960 : DMA2D background CLUT
$48021964 constant DMA2D_DMA2D_BGCLUT89  \ offset: 0x964 : DMA2D background CLUT
$48021968 constant DMA2D_DMA2D_BGCLUT90  \ offset: 0x968 : DMA2D background CLUT
$4802196c constant DMA2D_DMA2D_BGCLUT91  \ offset: 0x96C : DMA2D background CLUT
$48021970 constant DMA2D_DMA2D_BGCLUT92  \ offset: 0x970 : DMA2D background CLUT
$48021974 constant DMA2D_DMA2D_BGCLUT93  \ offset: 0x974 : DMA2D background CLUT
$48021978 constant DMA2D_DMA2D_BGCLUT94  \ offset: 0x978 : DMA2D background CLUT
$4802197c constant DMA2D_DMA2D_BGCLUT95  \ offset: 0x97C : DMA2D background CLUT
$48021980 constant DMA2D_DMA2D_BGCLUT96  \ offset: 0x980 : DMA2D background CLUT
$48021984 constant DMA2D_DMA2D_BGCLUT97  \ offset: 0x984 : DMA2D background CLUT
$48021988 constant DMA2D_DMA2D_BGCLUT98  \ offset: 0x988 : DMA2D background CLUT
$4802198c constant DMA2D_DMA2D_BGCLUT99  \ offset: 0x98C : DMA2D background CLUT
$48021990 constant DMA2D_DMA2D_BGCLUT100  \ offset: 0x990 : DMA2D background CLUT
$48021994 constant DMA2D_DMA2D_BGCLUT101  \ offset: 0x994 : DMA2D background CLUT
$48021998 constant DMA2D_DMA2D_BGCLUT102  \ offset: 0x998 : DMA2D background CLUT
$4802199c constant DMA2D_DMA2D_BGCLUT103  \ offset: 0x99C : DMA2D background CLUT
$480219a0 constant DMA2D_DMA2D_BGCLUT104  \ offset: 0x9A0 : DMA2D background CLUT
$480219a4 constant DMA2D_DMA2D_BGCLUT105  \ offset: 0x9A4 : DMA2D background CLUT
$480219a8 constant DMA2D_DMA2D_BGCLUT106  \ offset: 0x9A8 : DMA2D background CLUT
$480219ac constant DMA2D_DMA2D_BGCLUT107  \ offset: 0x9AC : DMA2D background CLUT
$480219b0 constant DMA2D_DMA2D_BGCLUT108  \ offset: 0x9B0 : DMA2D background CLUT
$480219b4 constant DMA2D_DMA2D_BGCLUT109  \ offset: 0x9B4 : DMA2D background CLUT
$480219b8 constant DMA2D_DMA2D_BGCLUT110  \ offset: 0x9B8 : DMA2D background CLUT
$480219bc constant DMA2D_DMA2D_BGCLUT111  \ offset: 0x9BC : DMA2D background CLUT
$480219c0 constant DMA2D_DMA2D_BGCLUT112  \ offset: 0x9C0 : DMA2D background CLUT
$480219c4 constant DMA2D_DMA2D_BGCLUT113  \ offset: 0x9C4 : DMA2D background CLUT
$480219c8 constant DMA2D_DMA2D_BGCLUT114  \ offset: 0x9C8 : DMA2D background CLUT
$480219cc constant DMA2D_DMA2D_BGCLUT115  \ offset: 0x9CC : DMA2D background CLUT
$480219d0 constant DMA2D_DMA2D_BGCLUT116  \ offset: 0x9D0 : DMA2D background CLUT
$480219d4 constant DMA2D_DMA2D_BGCLUT117  \ offset: 0x9D4 : DMA2D background CLUT
$480219d8 constant DMA2D_DMA2D_BGCLUT118  \ offset: 0x9D8 : DMA2D background CLUT
$480219dc constant DMA2D_DMA2D_BGCLUT119  \ offset: 0x9DC : DMA2D background CLUT
$480219e0 constant DMA2D_DMA2D_BGCLUT120  \ offset: 0x9E0 : DMA2D background CLUT
$480219e4 constant DMA2D_DMA2D_BGCLUT121  \ offset: 0x9E4 : DMA2D background CLUT
$480219e8 constant DMA2D_DMA2D_BGCLUT122  \ offset: 0x9E8 : DMA2D background CLUT
$480219ec constant DMA2D_DMA2D_BGCLUT123  \ offset: 0x9EC : DMA2D background CLUT
$480219f0 constant DMA2D_DMA2D_BGCLUT124  \ offset: 0x9F0 : DMA2D background CLUT
$480219f4 constant DMA2D_DMA2D_BGCLUT125  \ offset: 0x9F4 : DMA2D background CLUT
$480219f8 constant DMA2D_DMA2D_BGCLUT126  \ offset: 0x9F8 : DMA2D background CLUT
$480219fc constant DMA2D_DMA2D_BGCLUT127  \ offset: 0x9FC : DMA2D background CLUT
$48021a00 constant DMA2D_DMA2D_BGCLUT128  \ offset: 0xA00 : DMA2D background CLUT
$48021a04 constant DMA2D_DMA2D_BGCLUT129  \ offset: 0xA04 : DMA2D background CLUT
$48021a08 constant DMA2D_DMA2D_BGCLUT130  \ offset: 0xA08 : DMA2D background CLUT
$48021a0c constant DMA2D_DMA2D_BGCLUT131  \ offset: 0xA0C : DMA2D background CLUT
$48021a10 constant DMA2D_DMA2D_BGCLUT132  \ offset: 0xA10 : DMA2D background CLUT
$48021a14 constant DMA2D_DMA2D_BGCLUT133  \ offset: 0xA14 : DMA2D background CLUT
$48021a18 constant DMA2D_DMA2D_BGCLUT134  \ offset: 0xA18 : DMA2D background CLUT
$48021a1c constant DMA2D_DMA2D_BGCLUT135  \ offset: 0xA1C : DMA2D background CLUT
$48021a20 constant DMA2D_DMA2D_BGCLUT136  \ offset: 0xA20 : DMA2D background CLUT
$48021a24 constant DMA2D_DMA2D_BGCLUT137  \ offset: 0xA24 : DMA2D background CLUT
$48021a28 constant DMA2D_DMA2D_BGCLUT138  \ offset: 0xA28 : DMA2D background CLUT
$48021a2c constant DMA2D_DMA2D_BGCLUT139  \ offset: 0xA2C : DMA2D background CLUT
$48021a30 constant DMA2D_DMA2D_BGCLUT140  \ offset: 0xA30 : DMA2D background CLUT
$48021a34 constant DMA2D_DMA2D_BGCLUT141  \ offset: 0xA34 : DMA2D background CLUT
$48021a38 constant DMA2D_DMA2D_BGCLUT142  \ offset: 0xA38 : DMA2D background CLUT
$48021a3c constant DMA2D_DMA2D_BGCLUT143  \ offset: 0xA3C : DMA2D background CLUT
$48021a40 constant DMA2D_DMA2D_BGCLUT144  \ offset: 0xA40 : DMA2D background CLUT
$48021a44 constant DMA2D_DMA2D_BGCLUT145  \ offset: 0xA44 : DMA2D background CLUT
$48021a48 constant DMA2D_DMA2D_BGCLUT146  \ offset: 0xA48 : DMA2D background CLUT
$48021a4c constant DMA2D_DMA2D_BGCLUT147  \ offset: 0xA4C : DMA2D background CLUT
$48021a50 constant DMA2D_DMA2D_BGCLUT148  \ offset: 0xA50 : DMA2D background CLUT
$48021a54 constant DMA2D_DMA2D_BGCLUT149  \ offset: 0xA54 : DMA2D background CLUT
$48021a58 constant DMA2D_DMA2D_BGCLUT150  \ offset: 0xA58 : DMA2D background CLUT
$48021a5c constant DMA2D_DMA2D_BGCLUT151  \ offset: 0xA5C : DMA2D background CLUT
$48021a60 constant DMA2D_DMA2D_BGCLUT152  \ offset: 0xA60 : DMA2D background CLUT
$48021a64 constant DMA2D_DMA2D_BGCLUT153  \ offset: 0xA64 : DMA2D background CLUT
$48021a68 constant DMA2D_DMA2D_BGCLUT154  \ offset: 0xA68 : DMA2D background CLUT
$48021a6c constant DMA2D_DMA2D_BGCLUT155  \ offset: 0xA6C : DMA2D background CLUT
$48021a70 constant DMA2D_DMA2D_BGCLUT156  \ offset: 0xA70 : DMA2D background CLUT
$48021a74 constant DMA2D_DMA2D_BGCLUT157  \ offset: 0xA74 : DMA2D background CLUT
$48021a78 constant DMA2D_DMA2D_BGCLUT158  \ offset: 0xA78 : DMA2D background CLUT
$48021a7c constant DMA2D_DMA2D_BGCLUT159  \ offset: 0xA7C : DMA2D background CLUT
$48021a80 constant DMA2D_DMA2D_BGCLUT160  \ offset: 0xA80 : DMA2D background CLUT
$48021a84 constant DMA2D_DMA2D_BGCLUT161  \ offset: 0xA84 : DMA2D background CLUT
$48021a88 constant DMA2D_DMA2D_BGCLUT162  \ offset: 0xA88 : DMA2D background CLUT
$48021a8c constant DMA2D_DMA2D_BGCLUT163  \ offset: 0xA8C : DMA2D background CLUT
$48021a90 constant DMA2D_DMA2D_BGCLUT164  \ offset: 0xA90 : DMA2D background CLUT
$48021a94 constant DMA2D_DMA2D_BGCLUT165  \ offset: 0xA94 : DMA2D background CLUT
$48021a98 constant DMA2D_DMA2D_BGCLUT166  \ offset: 0xA98 : DMA2D background CLUT
$48021a9c constant DMA2D_DMA2D_BGCLUT167  \ offset: 0xA9C : DMA2D background CLUT
$48021aa0 constant DMA2D_DMA2D_BGCLUT168  \ offset: 0xAA0 : DMA2D background CLUT
$48021aa4 constant DMA2D_DMA2D_BGCLUT169  \ offset: 0xAA4 : DMA2D background CLUT
$48021aa8 constant DMA2D_DMA2D_BGCLUT170  \ offset: 0xAA8 : DMA2D background CLUT
$48021aac constant DMA2D_DMA2D_BGCLUT171  \ offset: 0xAAC : DMA2D background CLUT
$48021ab0 constant DMA2D_DMA2D_BGCLUT172  \ offset: 0xAB0 : DMA2D background CLUT
$48021ab4 constant DMA2D_DMA2D_BGCLUT173  \ offset: 0xAB4 : DMA2D background CLUT
$48021ab8 constant DMA2D_DMA2D_BGCLUT174  \ offset: 0xAB8 : DMA2D background CLUT
$48021abc constant DMA2D_DMA2D_BGCLUT175  \ offset: 0xABC : DMA2D background CLUT
$48021ac0 constant DMA2D_DMA2D_BGCLUT176  \ offset: 0xAC0 : DMA2D background CLUT
$48021ac4 constant DMA2D_DMA2D_BGCLUT177  \ offset: 0xAC4 : DMA2D background CLUT
$48021ac8 constant DMA2D_DMA2D_BGCLUT178  \ offset: 0xAC8 : DMA2D background CLUT
$48021acc constant DMA2D_DMA2D_BGCLUT179  \ offset: 0xACC : DMA2D background CLUT
$48021ad0 constant DMA2D_DMA2D_BGCLUT180  \ offset: 0xAD0 : DMA2D background CLUT
$48021ad4 constant DMA2D_DMA2D_BGCLUT181  \ offset: 0xAD4 : DMA2D background CLUT
$48021ad8 constant DMA2D_DMA2D_BGCLUT182  \ offset: 0xAD8 : DMA2D background CLUT
$48021adc constant DMA2D_DMA2D_BGCLUT183  \ offset: 0xADC : DMA2D background CLUT
$48021ae0 constant DMA2D_DMA2D_BGCLUT184  \ offset: 0xAE0 : DMA2D background CLUT
$48021ae4 constant DMA2D_DMA2D_BGCLUT185  \ offset: 0xAE4 : DMA2D background CLUT
$48021ae8 constant DMA2D_DMA2D_BGCLUT186  \ offset: 0xAE8 : DMA2D background CLUT
$48021aec constant DMA2D_DMA2D_BGCLUT187  \ offset: 0xAEC : DMA2D background CLUT
$48021af0 constant DMA2D_DMA2D_BGCLUT188  \ offset: 0xAF0 : DMA2D background CLUT
$48021af4 constant DMA2D_DMA2D_BGCLUT189  \ offset: 0xAF4 : DMA2D background CLUT
$48021af8 constant DMA2D_DMA2D_BGCLUT190  \ offset: 0xAF8 : DMA2D background CLUT
$48021afc constant DMA2D_DMA2D_BGCLUT191  \ offset: 0xAFC : DMA2D background CLUT
$48021b00 constant DMA2D_DMA2D_BGCLUT192  \ offset: 0xB00 : DMA2D background CLUT
$48021b04 constant DMA2D_DMA2D_BGCLUT193  \ offset: 0xB04 : DMA2D background CLUT
$48021b08 constant DMA2D_DMA2D_BGCLUT194  \ offset: 0xB08 : DMA2D background CLUT
$48021b0c constant DMA2D_DMA2D_BGCLUT195  \ offset: 0xB0C : DMA2D background CLUT
$48021b10 constant DMA2D_DMA2D_BGCLUT196  \ offset: 0xB10 : DMA2D background CLUT
$48021b14 constant DMA2D_DMA2D_BGCLUT197  \ offset: 0xB14 : DMA2D background CLUT
$48021b18 constant DMA2D_DMA2D_BGCLUT198  \ offset: 0xB18 : DMA2D background CLUT
$48021b1c constant DMA2D_DMA2D_BGCLUT199  \ offset: 0xB1C : DMA2D background CLUT
$48021b20 constant DMA2D_DMA2D_BGCLUT200  \ offset: 0xB20 : DMA2D background CLUT
$48021b24 constant DMA2D_DMA2D_BGCLUT201  \ offset: 0xB24 : DMA2D background CLUT
$48021b28 constant DMA2D_DMA2D_BGCLUT202  \ offset: 0xB28 : DMA2D background CLUT
$48021b2c constant DMA2D_DMA2D_BGCLUT203  \ offset: 0xB2C : DMA2D background CLUT
$48021b30 constant DMA2D_DMA2D_BGCLUT204  \ offset: 0xB30 : DMA2D background CLUT
$48021b34 constant DMA2D_DMA2D_BGCLUT205  \ offset: 0xB34 : DMA2D background CLUT
$48021b38 constant DMA2D_DMA2D_BGCLUT206  \ offset: 0xB38 : DMA2D background CLUT
$48021b3c constant DMA2D_DMA2D_BGCLUT207  \ offset: 0xB3C : DMA2D background CLUT
$48021b40 constant DMA2D_DMA2D_BGCLUT208  \ offset: 0xB40 : DMA2D background CLUT
$48021b44 constant DMA2D_DMA2D_BGCLUT209  \ offset: 0xB44 : DMA2D background CLUT
$48021b48 constant DMA2D_DMA2D_BGCLUT210  \ offset: 0xB48 : DMA2D background CLUT
$48021b4c constant DMA2D_DMA2D_BGCLUT211  \ offset: 0xB4C : DMA2D background CLUT
$48021b50 constant DMA2D_DMA2D_BGCLUT212  \ offset: 0xB50 : DMA2D background CLUT
$48021b54 constant DMA2D_DMA2D_BGCLUT213  \ offset: 0xB54 : DMA2D background CLUT
$48021b58 constant DMA2D_DMA2D_BGCLUT214  \ offset: 0xB58 : DMA2D background CLUT
$48021b5c constant DMA2D_DMA2D_BGCLUT215  \ offset: 0xB5C : DMA2D background CLUT
$48021b60 constant DMA2D_DMA2D_BGCLUT216  \ offset: 0xB60 : DMA2D background CLUT
$48021b64 constant DMA2D_DMA2D_BGCLUT217  \ offset: 0xB64 : DMA2D background CLUT
$48021b68 constant DMA2D_DMA2D_BGCLUT218  \ offset: 0xB68 : DMA2D background CLUT
$48021b6c constant DMA2D_DMA2D_BGCLUT219  \ offset: 0xB6C : DMA2D background CLUT
$48021b70 constant DMA2D_DMA2D_BGCLUT220  \ offset: 0xB70 : DMA2D background CLUT
$48021b74 constant DMA2D_DMA2D_BGCLUT221  \ offset: 0xB74 : DMA2D background CLUT
$48021b78 constant DMA2D_DMA2D_BGCLUT222  \ offset: 0xB78 : DMA2D background CLUT
$48021b7c constant DMA2D_DMA2D_BGCLUT223  \ offset: 0xB7C : DMA2D background CLUT
$48021b80 constant DMA2D_DMA2D_BGCLUT224  \ offset: 0xB80 : DMA2D background CLUT
$48021b84 constant DMA2D_DMA2D_BGCLUT225  \ offset: 0xB84 : DMA2D background CLUT
$48021b88 constant DMA2D_DMA2D_BGCLUT226  \ offset: 0xB88 : DMA2D background CLUT
$48021b8c constant DMA2D_DMA2D_BGCLUT227  \ offset: 0xB8C : DMA2D background CLUT
$48021b90 constant DMA2D_DMA2D_BGCLUT228  \ offset: 0xB90 : DMA2D background CLUT
$48021b94 constant DMA2D_DMA2D_BGCLUT229  \ offset: 0xB94 : DMA2D background CLUT
$48021b98 constant DMA2D_DMA2D_BGCLUT230  \ offset: 0xB98 : DMA2D background CLUT
$48021b9c constant DMA2D_DMA2D_BGCLUT231  \ offset: 0xB9C : DMA2D background CLUT
$48021ba0 constant DMA2D_DMA2D_BGCLUT232  \ offset: 0xBA0 : DMA2D background CLUT
$48021ba4 constant DMA2D_DMA2D_BGCLUT233  \ offset: 0xBA4 : DMA2D background CLUT
$48021ba8 constant DMA2D_DMA2D_BGCLUT234  \ offset: 0xBA8 : DMA2D background CLUT
$48021bac constant DMA2D_DMA2D_BGCLUT235  \ offset: 0xBAC : DMA2D background CLUT
$48021bb0 constant DMA2D_DMA2D_BGCLUT236  \ offset: 0xBB0 : DMA2D background CLUT
$48021bb4 constant DMA2D_DMA2D_BGCLUT237  \ offset: 0xBB4 : DMA2D background CLUT
$48021bb8 constant DMA2D_DMA2D_BGCLUT238  \ offset: 0xBB8 : DMA2D background CLUT
$48021bbc constant DMA2D_DMA2D_BGCLUT239  \ offset: 0xBBC : DMA2D background CLUT
$48021bc0 constant DMA2D_DMA2D_BGCLUT240  \ offset: 0xBC0 : DMA2D background CLUT
$48021bc4 constant DMA2D_DMA2D_BGCLUT241  \ offset: 0xBC4 : DMA2D background CLUT
$48021bc8 constant DMA2D_DMA2D_BGCLUT242  \ offset: 0xBC8 : DMA2D background CLUT
$48021bcc constant DMA2D_DMA2D_BGCLUT243  \ offset: 0xBCC : DMA2D background CLUT
$48021bd0 constant DMA2D_DMA2D_BGCLUT244  \ offset: 0xBD0 : DMA2D background CLUT
$48021bd4 constant DMA2D_DMA2D_BGCLUT245  \ offset: 0xBD4 : DMA2D background CLUT
$48021bd8 constant DMA2D_DMA2D_BGCLUT246  \ offset: 0xBD8 : DMA2D background CLUT
$48021bdc constant DMA2D_DMA2D_BGCLUT247  \ offset: 0xBDC : DMA2D background CLUT
$48021be0 constant DMA2D_DMA2D_BGCLUT248  \ offset: 0xBE0 : DMA2D background CLUT
$48021be4 constant DMA2D_DMA2D_BGCLUT249  \ offset: 0xBE4 : DMA2D background CLUT
$48021be8 constant DMA2D_DMA2D_BGCLUT250  \ offset: 0xBE8 : DMA2D background CLUT
$48021bec constant DMA2D_DMA2D_BGCLUT251  \ offset: 0xBEC : DMA2D background CLUT
$48021bf0 constant DMA2D_DMA2D_BGCLUT252  \ offset: 0xBF0 : DMA2D background CLUT
$48021bf4 constant DMA2D_DMA2D_BGCLUT253  \ offset: 0xBF4 : DMA2D background CLUT
$48021bf8 constant DMA2D_DMA2D_BGCLUT254  \ offset: 0xBF8 : DMA2D background CLUT
$48021bfc constant DMA2D_DMA2D_BGCLUT255  \ offset: 0xBFC : DMA2D background CLUT

