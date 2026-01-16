\
\ @file sec_dma2d.fs
\ @brief DMA2D controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA2D_CR_START                               \ Start
$00000002 constant SEC_DMA2D_CR_SUSP                                \ Suspend
$00000004 constant SEC_DMA2D_CR_ABORT                               \ Abort
$00000040 constant SEC_DMA2D_CR_LOM                                 \ Line Offset Mode
$00000100 constant SEC_DMA2D_CR_TEIE                                \ Transfer error interrupt enable
$00000200 constant SEC_DMA2D_CR_TCIE                                \ Transfer complete interrupt enable
$00000400 constant SEC_DMA2D_CR_TWIE                                \ Transfer watermark interrupt enable
$00000800 constant SEC_DMA2D_CR_CAEIE                               \ CLUT access error interrupt enable
$00001000 constant SEC_DMA2D_CR_CTCIE                               \ CLUT transfer complete interrupt enable
$00002000 constant SEC_DMA2D_CR_CEIE                                \ Configuration Error Interrupt Enable
$00070000 constant SEC_DMA2D_CR_MODE                                \ DMA2D mode


\
\ @brief Interrupt Status Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA2D_ISR_TEIF                               \ Transfer error interrupt flag
$00000002 constant SEC_DMA2D_ISR_TCIF                               \ Transfer complete interrupt flag
$00000004 constant SEC_DMA2D_ISR_TWIF                               \ Transfer watermark interrupt flag
$00000008 constant SEC_DMA2D_ISR_CAEIF                              \ CLUT access error interrupt flag
$00000010 constant SEC_DMA2D_ISR_CTCIF                              \ CLUT transfer complete interrupt flag
$00000020 constant SEC_DMA2D_ISR_CEIF                               \ Configuration error interrupt flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA2D_IFCR_CTEIF                             \ Clear Transfer error interrupt flag
$00000002 constant SEC_DMA2D_IFCR_CTCIF                             \ Clear transfer complete interrupt flag
$00000004 constant SEC_DMA2D_IFCR_CTWIF                             \ Clear transfer watermark interrupt flag
$00000008 constant SEC_DMA2D_IFCR_CAECIF                            \ Clear CLUT access error interrupt flag
$00000010 constant SEC_DMA2D_IFCR_CCTCIF                            \ Clear CLUT transfer complete interrupt flag
$00000020 constant SEC_DMA2D_IFCR_CCEIF                             \ Clear configuration error interrupt flag


\
\ @brief foreground memory address register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA2D_FGMAR_MA                               \ Memory address


\
\ @brief foreground offset register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DMA2D_FGOR_LO                                \ Line offset


\
\ @brief background memory address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA2D_BGMAR_MA                               \ Memory address


\
\ @brief background offset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DMA2D_BGOR_LO                                \ Line offset


\
\ @brief foreground PFC control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant SEC_DMA2D_FGPFCCR_CM                             \ Color mode
$00000010 constant SEC_DMA2D_FGPFCCR_CCM                            \ CLUT color mode
$00000020 constant SEC_DMA2D_FGPFCCR_START                          \ Start
$0000ff00 constant SEC_DMA2D_FGPFCCR_CS                             \ CLUT size
$00030000 constant SEC_DMA2D_FGPFCCR_AM                             \ Alpha mode
$00100000 constant SEC_DMA2D_FGPFCCR_AI                             \ Alpha Inverted
$00200000 constant SEC_DMA2D_FGPFCCR_RBS                            \ Red Blue Swap
$ff000000 constant SEC_DMA2D_FGPFCCR_ALPHA                          \ Alpha value


\
\ @brief foreground color register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SEC_DMA2D_FGCOLR_BLUE                            \ Blue Value
$0000ff00 constant SEC_DMA2D_FGCOLR_GREEN                           \ Green Value
$00ff0000 constant SEC_DMA2D_FGCOLR_RED                             \ Red Value


\
\ @brief background PFC control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant SEC_DMA2D_BGPFCCR_CM                             \ Color mode
$00000010 constant SEC_DMA2D_BGPFCCR_CCM                            \ CLUT Color mode
$00000020 constant SEC_DMA2D_BGPFCCR_START                          \ Start
$0000ff00 constant SEC_DMA2D_BGPFCCR_CS                             \ CLUT size
$00030000 constant SEC_DMA2D_BGPFCCR_AM                             \ Alpha mode
$00100000 constant SEC_DMA2D_BGPFCCR_AI                             \ Alpha Inverted
$00200000 constant SEC_DMA2D_BGPFCCR_RBS                            \ Red Blue Swap
$ff000000 constant SEC_DMA2D_BGPFCCR_ALPHA                          \ Alpha value


\
\ @brief background color register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant SEC_DMA2D_BGCOLR_BLUE                            \ Blue Value
$0000ff00 constant SEC_DMA2D_BGCOLR_GREEN                           \ Green Value
$00ff0000 constant SEC_DMA2D_BGCOLR_RED                             \ Red Value


\
\ @brief foreground CLUT memory address register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA2D_FGCMAR_MA                              \ Memory Address


\
\ @brief background CLUT memory address register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA2D_BGCMAR_MA                              \ Memory address


\
\ @brief output PFC control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000007 constant SEC_DMA2D_OPFCCR_CM                              \ Color mode
$00000200 constant SEC_DMA2D_OPFCCR_SB                              \ Swap Bytes
$00100000 constant SEC_DMA2D_OPFCCR_AI                              \ Alpha Inverted
$00200000 constant SEC_DMA2D_OPFCCR_RBS                             \ Red Blue Swap


\
\ @brief output color register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000ff constant SEC_DMA2D_OCOLR_RGB888_BLUE                      \ Blue Value
$0000ff00 constant SEC_DMA2D_OCOLR_RGB888_GREEN                     \ Green Value
$00ff0000 constant SEC_DMA2D_OCOLR_RGB888_RED                       \ Red Value
$ff000000 constant SEC_DMA2D_OCOLR_RGB888_APLHA                     \ Alpha Channel Value


\
\ @brief output color register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant SEC_DMA2D_OCOLR_RGB565_BLUE                      \ Blue value in RGB565 mode
$000007e0 constant SEC_DMA2D_OCOLR_RGB565_GREEN                     \ Green value in RGB565 mode
$0000f800 constant SEC_DMA2D_OCOLR_RGB565_RED                       \ Red value in RGB565 mode


\
\ @brief output color register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant SEC_DMA2D_OCOLR_ARGB1555_BLUE                    \ Blue value in ARGB1555 mode
$000003e0 constant SEC_DMA2D_OCOLR_ARGB1555_GREEN                   \ Green value in ARGB1555 mode
$00007c00 constant SEC_DMA2D_OCOLR_ARGB1555_RED                     \ Red value in ARGB1555 mode
$00008000 constant SEC_DMA2D_OCOLR_ARGB1555_A                       \ Alpha channel value in ARGB1555 mode


\
\ @brief output color register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000000f constant SEC_DMA2D_OCOLR_ARGB4444_BLUE                    \ Blue value in ARGB4444 mode
$000000f0 constant SEC_DMA2D_OCOLR_ARGB4444_GREEN                   \ Green value in ARGB4444 mode
$00000f00 constant SEC_DMA2D_OCOLR_ARGB4444_RED                     \ Red value in ARGB4444 mode
$0000f000 constant SEC_DMA2D_OCOLR_ARGB4444_ALPHA                   \ Alpha channel value in ARGB4444


\
\ @brief output memory address register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SEC_DMA2D_OMAR_MA                                \ Memory Address


\
\ @brief output offset register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DMA2D_OOR_LO                                 \ Line Offset


\
\ @brief number of line register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DMA2D_NLR_NL                                 \ Number of lines
$3fff0000 constant SEC_DMA2D_NLR_PL                                 \ Pixel per lines


\
\ @brief line watermark register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DMA2D_LWR_LW                                 \ Line watermark


\
\ @brief AHB master timer configuration register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant SEC_DMA2D_AMTCR_EN                               \ Enable
$0000ff00 constant SEC_DMA2D_AMTCR_DT                               \ Dead Time


\
\ @brief FGCLUT
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$000000ff constant SEC_DMA2D_FGCLUT_BLUE                            \ BLUE
$0000ff00 constant SEC_DMA2D_FGCLUT_GREEN                           \ GREEN
$00ff0000 constant SEC_DMA2D_FGCLUT_RED                             \ RED
$ff000000 constant SEC_DMA2D_FGCLUT_APLHA                           \ APLHA


\
\ @brief BGCLUT
\ Address offset: 0x800
\ Reset value: 0x00000000
\

$000000ff constant SEC_DMA2D_BGCLUT_BLUE                            \ BLUE
$0000ff00 constant SEC_DMA2D_BGCLUT_GREEN                           \ GREEN
$00ff0000 constant SEC_DMA2D_BGCLUT_RED                             \ RED
$ff000000 constant SEC_DMA2D_BGCLUT_APLHA                           \ APLHA


\
\ @brief DMA2D controller
\
$5002b000 constant SEC_DMA2D_CR   \ offset: 0x00 : control register
$5002b004 constant SEC_DMA2D_ISR  \ offset: 0x04 : Interrupt Status Register
$5002b008 constant SEC_DMA2D_IFCR  \ offset: 0x08 : interrupt flag clear register
$5002b00c constant SEC_DMA2D_FGMAR  \ offset: 0x0C : foreground memory address register
$5002b010 constant SEC_DMA2D_FGOR  \ offset: 0x10 : foreground offset register
$5002b014 constant SEC_DMA2D_BGMAR  \ offset: 0x14 : background memory address register
$5002b018 constant SEC_DMA2D_BGOR  \ offset: 0x18 : background offset register
$5002b01c constant SEC_DMA2D_FGPFCCR  \ offset: 0x1C : foreground PFC control register
$5002b020 constant SEC_DMA2D_FGCOLR  \ offset: 0x20 : foreground color register
$5002b024 constant SEC_DMA2D_BGPFCCR  \ offset: 0x24 : background PFC control register
$5002b028 constant SEC_DMA2D_BGCOLR  \ offset: 0x28 : background color register
$5002b02c constant SEC_DMA2D_FGCMAR  \ offset: 0x2C : foreground CLUT memory address register
$5002b030 constant SEC_DMA2D_BGCMAR  \ offset: 0x30 : background CLUT memory address register
$5002b034 constant SEC_DMA2D_OPFCCR  \ offset: 0x34 : output PFC control register
$5002b038 constant SEC_DMA2D_OCOLR_RGB888  \ offset: 0x38 : output color register
$5002b038 constant SEC_DMA2D_OCOLR_RGB565  \ offset: 0x38 : output color register
$5002b038 constant SEC_DMA2D_OCOLR_ARGB1555  \ offset: 0x38 : output color register
$5002b038 constant SEC_DMA2D_OCOLR_ARGB4444  \ offset: 0x38 : output color register
$5002b03c constant SEC_DMA2D_OMAR  \ offset: 0x3C : output memory address register
$5002b040 constant SEC_DMA2D_OOR  \ offset: 0x40 : output offset register
$5002b044 constant SEC_DMA2D_NLR  \ offset: 0x44 : number of line register
$5002b048 constant SEC_DMA2D_LWR  \ offset: 0x48 : line watermark register
$5002b04c constant SEC_DMA2D_AMTCR  \ offset: 0x4C : AHB master timer configuration register
$5002b400 constant SEC_DMA2D_FGCLUT  \ offset: 0x400 : FGCLUT
$5002b800 constant SEC_DMA2D_BGCLUT  \ offset: 0x800 : BGCLUT

