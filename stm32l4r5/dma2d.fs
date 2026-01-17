\
\ @file dma2d.fs
\ @brief DMA2D controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA2D_DEF

  [ifdef] DMA2D_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_START                    \ [0x00] Start
    $01 constant DMA2D_SUSP                     \ [0x01] Suspend
    $02 constant DMA2D_ABORT                    \ [0x02] Abort
    $08 constant DMA2D_TEIE                     \ [0x08] Transfer error interrupt enable
    $09 constant DMA2D_TCIE                     \ [0x09] Transfer complete interrupt enable
    $0a constant DMA2D_TWIE                     \ [0x0a] Transfer watermark interrupt enable
    $0b constant DMA2D_CAEIE                    \ [0x0b] CLUT access error interrupt enable
    $0c constant DMA2D_CTCIE                    \ [0x0c] CLUT transfer complete interrupt enable
    $0d constant DMA2D_CEIE                     \ [0x0d] Configuration Error Interrupt Enable
    $10 constant DMA2D_MODE                     \ [0x10 : 2] DMA2D mode
  [then]


  [ifdef] DMA2D_ISR_DEF
    \
    \ @brief Interrupt Status Register
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


  [ifdef] DMA2D_IFCR_DEF
    \
    \ @brief interrupt flag clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CTEIF                    \ [0x00] Clear Transfer error interrupt flag
    $01 constant DMA2D_CTCIF                    \ [0x01] Clear transfer complete interrupt flag
    $02 constant DMA2D_CTWIF                    \ [0x02] Clear transfer watermark interrupt flag
    $03 constant DMA2D_CAECIF                   \ [0x03] Clear CLUT access error interrupt flag
    $04 constant DMA2D_CCTCIF                   \ [0x04] Clear CLUT transfer complete interrupt flag
    $05 constant DMA2D_CCEIF                    \ [0x05] Clear configuration error interrupt flag
  [then]


  [ifdef] DMA2D_FGMAR_DEF
    \
    \ @brief foreground memory address register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA2D_FGOR_DEF
    \
    \ @brief foreground offset register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LO                       \ [0x00 : 14] Line offset
  [then]


  [ifdef] DMA2D_BGMAR_DEF
    \
    \ @brief background memory address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA2D_BGOR_DEF
    \
    \ @brief background offset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LO                       \ [0x00 : 14] Line offset
  [then]


  [ifdef] DMA2D_FGPFCCR_DEF
    \
    \ @brief foreground PFC control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CM                       \ [0x00 : 4] Color mode
    $04 constant DMA2D_CCM                      \ [0x04] CLUT color mode
    $05 constant DMA2D_START                    \ [0x05] Start
    $08 constant DMA2D_CS                       \ [0x08 : 8] CLUT size
    $10 constant DMA2D_AM                       \ [0x10 : 2] Alpha mode
    $14 constant DMA2D_AI                       \ [0x14] Alpha Inverted
    $15 constant DMA2D_RBS                      \ [0x15] Red Blue Swap
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha value
  [then]


  [ifdef] DMA2D_FGCOLR_DEF
    \
    \ @brief foreground color register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue Value
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green Value
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red Value
  [then]


  [ifdef] DMA2D_BGPFCCR_DEF
    \
    \ @brief background PFC control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CM                       \ [0x00 : 4] Color mode
    $04 constant DMA2D_CCM                      \ [0x04] CLUT Color mode
    $05 constant DMA2D_START                    \ [0x05] Start
    $08 constant DMA2D_CS                       \ [0x08 : 8] CLUT size
    $10 constant DMA2D_AM                       \ [0x10 : 2] Alpha mode
    $14 constant DMA2D_AI                       \ [0x14] Alpha Inverted
    $15 constant DMA2D_RBS                      \ [0x15] Red Blue Swap
    $18 constant DMA2D_ALPHA                    \ [0x18 : 8] Alpha value
  [then]


  [ifdef] DMA2D_BGCOLR_DEF
    \
    \ @brief background color register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue Value
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green Value
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red Value
  [then]


  [ifdef] DMA2D_FGCMAR_DEF
    \
    \ @brief foreground CLUT memory address register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory Address
  [then]


  [ifdef] DMA2D_BGCMAR_DEF
    \
    \ @brief background CLUT memory address register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA2D_OPFCCR_DEF
    \
    \ @brief output PFC control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_CM                       \ [0x00 : 3] Color mode
    $14 constant DMA2D_AI                       \ [0x14] Alpha Inverted
    $15 constant DMA2D_RBS                      \ [0x15] Red Blue Swap
  [then]


  [ifdef] DMA2D_OCOLR_DEF
    \
    \ @brief output color register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] Blue Value
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] Green Value
    $10 constant DMA2D_RED                      \ [0x10 : 8] Red Value
    $18 constant DMA2D_APLHA                    \ [0x18 : 8] Alpha Channel Value
  [then]


  [ifdef] DMA2D_OMAR_DEF
    \
    \ @brief output memory address register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_MA                       \ [0x00 : 32] Memory Address
  [then]


  [ifdef] DMA2D_OOR_DEF
    \
    \ @brief output offset register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LO                       \ [0x00 : 14] Line Offset
  [then]


  [ifdef] DMA2D_NLR_DEF
    \
    \ @brief number of line register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_NL                       \ [0x00 : 16] Number of lines
    $10 constant DMA2D_PL                       \ [0x10 : 14] Pixel per lines
  [then]


  [ifdef] DMA2D_LWR_DEF
    \
    \ @brief line watermark register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_LW                       \ [0x00 : 16] Line watermark
  [then]


  [ifdef] DMA2D_AMTCR_DEF
    \
    \ @brief AHB master timer configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_EN                       \ [0x00] Enable
    $08 constant DMA2D_DT                       \ [0x08 : 8] Dead Time
  [then]


  [ifdef] DMA2D_FGCLUT_DEF
    \
    \ @brief FGCLUT
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] BLUE
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] GREEN
    $10 constant DMA2D_RED                      \ [0x10 : 8] RED
    $18 constant DMA2D_APLHA                    \ [0x18 : 8] APLHA
  [then]


  [ifdef] DMA2D_BGCLUT_DEF
    \
    \ @brief BGCLUT
    \ Address offset: 0x800
    \ Reset value: 0x00000000
    \
    $00 constant DMA2D_BLUE                     \ [0x00 : 8] BLUE
    $08 constant DMA2D_GREEN                    \ [0x08 : 8] GREEN
    $10 constant DMA2D_RED                      \ [0x10 : 8] RED
    $18 constant DMA2D_APLHA                    \ [0x18 : 8] APLHA
  [then]

  \
  \ @brief DMA2D controller
  \
  $00 constant DMA2D_CR                 \ control register
  $04 constant DMA2D_ISR                \ Interrupt Status Register
  $08 constant DMA2D_IFCR               \ interrupt flag clear register
  $0C constant DMA2D_FGMAR              \ foreground memory address register
  $10 constant DMA2D_FGOR               \ foreground offset register
  $14 constant DMA2D_BGMAR              \ background memory address register
  $18 constant DMA2D_BGOR               \ background offset register
  $1C constant DMA2D_FGPFCCR            \ foreground PFC control register
  $20 constant DMA2D_FGCOLR             \ foreground color register
  $24 constant DMA2D_BGPFCCR            \ background PFC control register
  $28 constant DMA2D_BGCOLR             \ background color register
  $2C constant DMA2D_FGCMAR             \ foreground CLUT memory address register
  $30 constant DMA2D_BGCMAR             \ background CLUT memory address register
  $34 constant DMA2D_OPFCCR             \ output PFC control register
  $38 constant DMA2D_OCOLR              \ output color register
  $3C constant DMA2D_OMAR               \ output memory address register
  $40 constant DMA2D_OOR                \ output offset register
  $44 constant DMA2D_NLR                \ number of line register
  $48 constant DMA2D_LWR                \ line watermark register
  $4C constant DMA2D_AMTCR              \ AHB master timer configuration register
  $400 constant DMA2D_FGCLUT            \ FGCLUT
  $800 constant DMA2D_BGCLUT            \ BGCLUT

: DMA2D_DEF ; [then]
