\
\ @file dma.fs
\ @brief Direct memory access controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA_DEF

  [ifdef] DMA_ISR_DEF
    \
    \ @brief interrupt status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA_GIF1                       \ [0x00] Channel x global interrupt flag (x = 1 ..7)
    $01 constant DMA_TCIF1                      \ [0x01] Channel x transfer complete flag (x = 1 ..7)
    $02 constant DMA_HTIF1                      \ [0x02] Channel x half transfer flag (x = 1 ..7)
    $03 constant DMA_TEIF1                      \ [0x03] Channel x transfer error flag (x = 1 ..7)
    $04 constant DMA_GIF2                       \ [0x04] Channel x global interrupt flag (x = 1 ..7)
    $05 constant DMA_TCIF2                      \ [0x05] Channel x transfer complete flag (x = 1 ..7)
    $06 constant DMA_HTIF2                      \ [0x06] Channel x half transfer flag (x = 1 ..7)
    $07 constant DMA_TEIF2                      \ [0x07] Channel x transfer error flag (x = 1 ..7)
    $08 constant DMA_GIF3                       \ [0x08] Channel x global interrupt flag (x = 1 ..7)
    $09 constant DMA_TCIF3                      \ [0x09] Channel x transfer complete flag (x = 1 ..7)
    $0a constant DMA_HTIF3                      \ [0x0a] Channel x half transfer flag (x = 1 ..7)
    $0b constant DMA_TEIF3                      \ [0x0b] Channel x transfer error flag (x = 1 ..7)
    $0c constant DMA_GIF4                       \ [0x0c] Channel x global interrupt flag (x = 1 ..7)
    $0d constant DMA_TCIF4                      \ [0x0d] Channel x transfer complete flag (x = 1 ..7)
    $0e constant DMA_HTIF4                      \ [0x0e] Channel x half transfer flag (x = 1 ..7)
    $0f constant DMA_TEIF4                      \ [0x0f] Channel x transfer error flag (x = 1 ..7)
    $10 constant DMA_GIF5                       \ [0x10] Channel x global interrupt flag (x = 1 ..7)
    $11 constant DMA_TCIF5                      \ [0x11] Channel x transfer complete flag (x = 1 ..7)
    $12 constant DMA_HTIF5                      \ [0x12] Channel x half transfer flag (x = 1 ..7)
    $13 constant DMA_TEIF5                      \ [0x13] Channel x transfer error flag (x = 1 ..7)
    $14 constant DMA_GIF6                       \ [0x14] Channel x global interrupt flag (x = 1 ..7)
    $15 constant DMA_TCIF6                      \ [0x15] Channel x transfer complete flag (x = 1 ..7)
    $16 constant DMA_HTIF6                      \ [0x16] Channel x half transfer flag (x = 1 ..7)
    $17 constant DMA_TEIF6                      \ [0x17] Channel x transfer error flag (x = 1 ..7)
    $18 constant DMA_GIF7                       \ [0x18] Channel x global interrupt flag (x = 1 ..7)
    $19 constant DMA_TCIF7                      \ [0x19] Channel x transfer complete flag (x = 1 ..7)
    $1a constant DMA_HTIF7                      \ [0x1a] Channel x half transfer flag (x = 1 ..7)
    $1b constant DMA_TEIF7                      \ [0x1b] Channel x transfer error flag (x = 1 ..7)
  [then]


  [ifdef] DMA_IFCR_DEF
    \
    \ @brief interrupt flag clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CGIF1                      \ [0x00] Channel x global interrupt clear (x = 1 ..7)
    $01 constant DMA_CTCIF1                     \ [0x01] Channel x transfer complete clear (x = 1 ..7)
    $02 constant DMA_CHTIF1                     \ [0x02] Channel x half transfer clear (x = 1 ..7)
    $03 constant DMA_CTEIF1                     \ [0x03] Channel x transfer error clear (x = 1 ..7)
    $04 constant DMA_CGIF2                      \ [0x04] Channel x global interrupt clear (x = 1 ..7)
    $05 constant DMA_CTCIF2                     \ [0x05] Channel x transfer complete clear (x = 1 ..7)
    $06 constant DMA_CHTIF2                     \ [0x06] Channel x half transfer clear (x = 1 ..7)
    $07 constant DMA_CTEIF2                     \ [0x07] Channel x transfer error clear (x = 1 ..7)
    $08 constant DMA_CGIF3                      \ [0x08] Channel x global interrupt clear (x = 1 ..7)
    $09 constant DMA_CTCIF3                     \ [0x09] Channel x transfer complete clear (x = 1 ..7)
    $0a constant DMA_CHTIF3                     \ [0x0a] Channel x half transfer clear (x = 1 ..7)
    $0b constant DMA_CTEIF3                     \ [0x0b] Channel x transfer error clear (x = 1 ..7)
    $0c constant DMA_CGIF4                      \ [0x0c] Channel x global interrupt clear (x = 1 ..7)
    $0d constant DMA_CTCIF4                     \ [0x0d] Channel x transfer complete clear (x = 1 ..7)
    $0e constant DMA_CHTIF4                     \ [0x0e] Channel x half transfer clear (x = 1 ..7)
    $0f constant DMA_CTEIF4                     \ [0x0f] Channel x transfer error clear (x = 1 ..7)
    $10 constant DMA_CGIF5                      \ [0x10] Channel x global interrupt clear (x = 1 ..7)
    $11 constant DMA_CTCIF5                     \ [0x11] Channel x transfer complete clear (x = 1 ..7)
    $12 constant DMA_CHTIF5                     \ [0x12] Channel x half transfer clear (x = 1 ..7)
    $13 constant DMA_CTEIF5                     \ [0x13] Channel x transfer error clear (x = 1 ..7)
    $14 constant DMA_CGIF6                      \ [0x14] Channel x global interrupt clear (x = 1 ..7)
    $15 constant DMA_CTCIF6                     \ [0x15] Channel x transfer complete clear (x = 1 ..7)
    $16 constant DMA_CHTIF6                     \ [0x16] Channel x half transfer clear (x = 1 ..7)
    $17 constant DMA_CTEIF6                     \ [0x17] Channel x transfer error clear (x = 1 ..7)
    $18 constant DMA_CGIF7                      \ [0x18] Channel x global interrupt clear (x = 1 ..7)
    $19 constant DMA_CTCIF7                     \ [0x19] Channel x transfer complete clear (x = 1 ..7)
    $1a constant DMA_CHTIF7                     \ [0x1a] Channel x half transfer clear (x = 1 ..7)
    $1b constant DMA_CTEIF7                     \ [0x1b] Channel x transfer error clear (x = 1 ..7)
  [then]


  [ifdef] DMA_CCR1_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] Circular mode
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size
    $0c constant DMA_PL                         \ [0x0c : 2] Channel priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA_CNDTR1_DEF
    \
    \ @brief channel x number of data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA_CPAR1_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_CMAR1_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA_CCR2_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] Circular mode
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size
    $0c constant DMA_PL                         \ [0x0c : 2] Channel priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA_CNDTR2_DEF
    \
    \ @brief channel x number of data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA_CPAR2_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_CMAR2_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA_CCR3_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] Circular mode
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size
    $0c constant DMA_PL                         \ [0x0c : 2] Channel priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA_CNDTR3_DEF
    \
    \ @brief channel x number of data register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA_CPAR3_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_CMAR3_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA_CCR4_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] Circular mode
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size
    $0c constant DMA_PL                         \ [0x0c : 2] Channel priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA_CNDTR4_DEF
    \
    \ @brief channel x number of data register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA_CPAR4_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_CMAR4_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA_CCR5_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] Circular mode
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size
    $0c constant DMA_PL                         \ [0x0c : 2] Channel priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA_CNDTR5_DEF
    \
    \ @brief channel x number of data register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA_CPAR5_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_CMAR5_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA_CCR6_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] Circular mode
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size
    $0c constant DMA_PL                         \ [0x0c : 2] Channel priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA_CNDTR6_DEF
    \
    \ @brief channel x number of data register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA_CPAR6_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_CMAR6_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA_CCR7_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Channel enable
    $01 constant DMA_TCIE                       \ [0x01] Transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] Half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] Transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] Data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] Circular mode
    $06 constant DMA_PINC                       \ [0x06] Peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] Memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] Peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] Memory size
    $0c constant DMA_PL                         \ [0x0c : 2] Channel priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA_CNDTR7_DEF
    \
    \ @brief channel x number of data register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA_CPAR7_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_CMAR7_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA_CSELR_DEF
    \
    \ @brief channel selection register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_C1S                        \ [0x00 : 4] DMA channel 1 selection
    $04 constant DMA_C2S                        \ [0x04 : 4] DMA channel 2 selection
    $08 constant DMA_C3S                        \ [0x08 : 4] DMA channel 3 selection
    $0c constant DMA_C4S                        \ [0x0c : 4] DMA channel 4 selection
    $10 constant DMA_C5S                        \ [0x10 : 4] DMA channel 5 selection
    $14 constant DMA_C6S                        \ [0x14 : 4] DMA channel 6 selection
    $18 constant DMA_C7S                        \ [0x18 : 4] DMA channel 7 selection
  [then]

  \
  \ @brief Direct memory access controller
  \
  $00 constant DMA_ISR                  \ interrupt status register
  $04 constant DMA_IFCR                 \ interrupt flag clear register
  $08 constant DMA_CCR1                 \ channel x configuration register
  $0C constant DMA_CNDTR1               \ channel x number of data register
  $10 constant DMA_CPAR1                \ channel x peripheral address register
  $14 constant DMA_CMAR1                \ channel x memory address register
  $1C constant DMA_CCR2                 \ channel x configuration register
  $20 constant DMA_CNDTR2               \ channel x number of data register
  $24 constant DMA_CPAR2                \ channel x peripheral address register
  $28 constant DMA_CMAR2                \ channel x memory address register
  $30 constant DMA_CCR3                 \ channel x configuration register
  $34 constant DMA_CNDTR3               \ channel x number of data register
  $38 constant DMA_CPAR3                \ channel x peripheral address register
  $3C constant DMA_CMAR3                \ channel x memory address register
  $44 constant DMA_CCR4                 \ channel x configuration register
  $48 constant DMA_CNDTR4               \ channel x number of data register
  $4C constant DMA_CPAR4                \ channel x peripheral address register
  $50 constant DMA_CMAR4                \ channel x memory address register
  $58 constant DMA_CCR5                 \ channel x configuration register
  $5C constant DMA_CNDTR5               \ channel x number of data register
  $60 constant DMA_CPAR5                \ channel x peripheral address register
  $64 constant DMA_CMAR5                \ channel x memory address register
  $6C constant DMA_CCR6                 \ channel x configuration register
  $70 constant DMA_CNDTR6               \ channel x number of data register
  $74 constant DMA_CPAR6                \ channel x peripheral address register
  $78 constant DMA_CMAR6                \ channel x memory address register
  $80 constant DMA_CCR7                 \ channel x configuration register
  $84 constant DMA_CNDTR7               \ channel x number of data register
  $88 constant DMA_CPAR7                \ channel x peripheral address register
  $8C constant DMA_CMAR7                \ channel x memory address register
  $A8 constant DMA_CSELR                \ channel selection register

: DMA_DEF ; [then]
