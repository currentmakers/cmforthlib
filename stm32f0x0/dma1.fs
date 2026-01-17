\
\ @file dma1.fs
\ @brief DMA controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA1_DEF

  [ifdef] DMA1_ISR_DEF
    \
    \ @brief DMA interrupt status register (DMA_ISR)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_GIF1                      \ [0x00] Channel 1 Global interrupt flag
    $01 constant DMA1_TCIF1                     \ [0x01] Channel 1 Transfer Complete flag
    $02 constant DMA1_HTIF1                     \ [0x02] Channel 1 Half Transfer Complete flag
    $03 constant DMA1_TEIF1                     \ [0x03] Channel 1 Transfer Error flag
    $04 constant DMA1_GIF2                      \ [0x04] Channel 2 Global interrupt flag
    $05 constant DMA1_TCIF2                     \ [0x05] Channel 2 Transfer Complete flag
    $06 constant DMA1_HTIF2                     \ [0x06] Channel 2 Half Transfer Complete flag
    $07 constant DMA1_TEIF2                     \ [0x07] Channel 2 Transfer Error flag
    $08 constant DMA1_GIF3                      \ [0x08] Channel 3 Global interrupt flag
    $09 constant DMA1_TCIF3                     \ [0x09] Channel 3 Transfer Complete flag
    $0a constant DMA1_HTIF3                     \ [0x0a] Channel 3 Half Transfer Complete flag
    $0b constant DMA1_TEIF3                     \ [0x0b] Channel 3 Transfer Error flag
    $0c constant DMA1_GIF4                      \ [0x0c] Channel 4 Global interrupt flag
    $0d constant DMA1_TCIF4                     \ [0x0d] Channel 4 Transfer Complete flag
    $0e constant DMA1_HTIF4                     \ [0x0e] Channel 4 Half Transfer Complete flag
    $0f constant DMA1_TEIF4                     \ [0x0f] Channel 4 Transfer Error flag
    $10 constant DMA1_GIF5                      \ [0x10] Channel 5 Global interrupt flag
    $11 constant DMA1_TCIF5                     \ [0x11] Channel 5 Transfer Complete flag
    $12 constant DMA1_HTIF5                     \ [0x12] Channel 5 Half Transfer Complete flag
    $13 constant DMA1_TEIF5                     \ [0x13] Channel 5 Transfer Error flag
    $14 constant DMA1_GIF6                      \ [0x14] Channel 6 Global interrupt flag
    $15 constant DMA1_TCIF6                     \ [0x15] Channel 6 Transfer Complete flag
    $16 constant DMA1_HTIF6                     \ [0x16] Channel 6 Half Transfer Complete flag
    $17 constant DMA1_TEIF6                     \ [0x17] Channel 6 Transfer Error flag
    $18 constant DMA1_GIF7                      \ [0x18] Channel 7 Global interrupt flag
    $19 constant DMA1_TCIF7                     \ [0x19] Channel 7 Transfer Complete flag
    $1a constant DMA1_HTIF7                     \ [0x1a] Channel 7 Half Transfer Complete flag
    $1b constant DMA1_TEIF7                     \ [0x1b] Channel 7 Transfer Error flag
  [then]


  [ifdef] DMA1_IFCR_DEF
    \
    \ @brief DMA interrupt flag clear register (DMA_IFCR)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_CGIF1                     \ [0x00] Channel 1 Global interrupt clear
    $01 constant DMA1_CTCIF1                    \ [0x01] Channel 1 Transfer Complete clear
    $02 constant DMA1_CHTIF1                    \ [0x02] Channel 1 Half Transfer clear
    $03 constant DMA1_CTEIF1                    \ [0x03] Channel 1 Transfer Error clear
    $04 constant DMA1_CGIF2                     \ [0x04] Channel 2 Global interrupt clear
    $05 constant DMA1_CTCIF2                    \ [0x05] Channel 2 Transfer Complete clear
    $06 constant DMA1_CHTIF2                    \ [0x06] Channel 2 Half Transfer clear
    $07 constant DMA1_CTEIF2                    \ [0x07] Channel 2 Transfer Error clear
    $08 constant DMA1_CGIF3                     \ [0x08] Channel 3 Global interrupt clear
    $09 constant DMA1_CTCIF3                    \ [0x09] Channel 3 Transfer Complete clear
    $0a constant DMA1_CHTIF3                    \ [0x0a] Channel 3 Half Transfer clear
    $0b constant DMA1_CTEIF3                    \ [0x0b] Channel 3 Transfer Error clear
    $0c constant DMA1_CGIF4                     \ [0x0c] Channel 4 Global interrupt clear
    $0d constant DMA1_CTCIF4                    \ [0x0d] Channel 4 Transfer Complete clear
    $0e constant DMA1_CHTIF4                    \ [0x0e] Channel 4 Half Transfer clear
    $0f constant DMA1_CTEIF4                    \ [0x0f] Channel 4 Transfer Error clear
    $10 constant DMA1_CGIF5                     \ [0x10] Channel 5 Global interrupt clear
    $11 constant DMA1_CTCIF5                    \ [0x11] Channel 5 Transfer Complete clear
    $12 constant DMA1_CHTIF5                    \ [0x12] Channel 5 Half Transfer clear
    $13 constant DMA1_CTEIF5                    \ [0x13] Channel 5 Transfer Error clear
    $14 constant DMA1_CGIF6                     \ [0x14] Channel 6 Global interrupt clear
    $15 constant DMA1_CTCIF6                    \ [0x15] Channel 6 Transfer Complete clear
    $16 constant DMA1_CHTIF6                    \ [0x16] Channel 6 Half Transfer clear
    $17 constant DMA1_CTEIF6                    \ [0x17] Channel 6 Transfer Error clear
    $18 constant DMA1_CGIF7                     \ [0x18] Channel 7 Global interrupt clear
    $19 constant DMA1_CTCIF7                    \ [0x19] Channel 7 Transfer Complete clear
    $1a constant DMA1_CHTIF7                    \ [0x1a] Channel 7 Half Transfer clear
    $1b constant DMA1_CTEIF7                    \ [0x1b] Channel 7 Transfer Error clear
  [then]


  [ifdef] DMA1_CCR1_DEF
    \
    \ @brief DMA channel configuration register (DMA_CCR)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_EN                        \ [0x00] Channel enable
    $01 constant DMA1_TCIE                      \ [0x01] Transfer complete interrupt enable
    $02 constant DMA1_HTIE                      \ [0x02] Half Transfer interrupt enable
    $03 constant DMA1_TEIE                      \ [0x03] Transfer error interrupt enable
    $04 constant DMA1_DIR                       \ [0x04] Data transfer direction
    $05 constant DMA1_CIRC                      \ [0x05] Circular mode
    $06 constant DMA1_PINC                      \ [0x06] Peripheral increment mode
    $07 constant DMA1_MINC                      \ [0x07] Memory increment mode
    $08 constant DMA1_PSIZE                     \ [0x08 : 2] Peripheral size
    $0a constant DMA1_MSIZE                     \ [0x0a : 2] Memory size
    $0c constant DMA1_PL                        \ [0x0c : 2] Channel Priority level
    $0e constant DMA1_MEM2MEM                   \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA1_CNDTR1_DEF
    \
    \ @brief DMA channel 1 number of data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_NDT                       \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA1_CPAR1_DEF
    \
    \ @brief DMA channel 1 peripheral address register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_PA                        \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA1_CMAR1_DEF
    \
    \ @brief DMA channel 1 memory address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_MA                        \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA1_CCR2_DEF
    \
    \ @brief DMA channel configuration register (DMA_CCR)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_EN                        \ [0x00] Channel enable
    $01 constant DMA1_TCIE                      \ [0x01] Transfer complete interrupt enable
    $02 constant DMA1_HTIE                      \ [0x02] Half Transfer interrupt enable
    $03 constant DMA1_TEIE                      \ [0x03] Transfer error interrupt enable
    $04 constant DMA1_DIR                       \ [0x04] Data transfer direction
    $05 constant DMA1_CIRC                      \ [0x05] Circular mode
    $06 constant DMA1_PINC                      \ [0x06] Peripheral increment mode
    $07 constant DMA1_MINC                      \ [0x07] Memory increment mode
    $08 constant DMA1_PSIZE                     \ [0x08 : 2] Peripheral size
    $0a constant DMA1_MSIZE                     \ [0x0a : 2] Memory size
    $0c constant DMA1_PL                        \ [0x0c : 2] Channel Priority level
    $0e constant DMA1_MEM2MEM                   \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA1_CNDTR2_DEF
    \
    \ @brief DMA channel 2 number of data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_NDT                       \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA1_CPAR2_DEF
    \
    \ @brief DMA channel 2 peripheral address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_PA                        \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA1_CMAR2_DEF
    \
    \ @brief DMA channel 2 memory address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_MA                        \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA1_CCR3_DEF
    \
    \ @brief DMA channel configuration register (DMA_CCR)
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_EN                        \ [0x00] Channel enable
    $01 constant DMA1_TCIE                      \ [0x01] Transfer complete interrupt enable
    $02 constant DMA1_HTIE                      \ [0x02] Half Transfer interrupt enable
    $03 constant DMA1_TEIE                      \ [0x03] Transfer error interrupt enable
    $04 constant DMA1_DIR                       \ [0x04] Data transfer direction
    $05 constant DMA1_CIRC                      \ [0x05] Circular mode
    $06 constant DMA1_PINC                      \ [0x06] Peripheral increment mode
    $07 constant DMA1_MINC                      \ [0x07] Memory increment mode
    $08 constant DMA1_PSIZE                     \ [0x08 : 2] Peripheral size
    $0a constant DMA1_MSIZE                     \ [0x0a : 2] Memory size
    $0c constant DMA1_PL                        \ [0x0c : 2] Channel Priority level
    $0e constant DMA1_MEM2MEM                   \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA1_CNDTR3_DEF
    \
    \ @brief DMA channel 3 number of data register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_NDT                       \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA1_CPAR3_DEF
    \
    \ @brief DMA channel 3 peripheral address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_PA                        \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA1_CMAR3_DEF
    \
    \ @brief DMA channel 3 memory address register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_MA                        \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA1_CCR4_DEF
    \
    \ @brief DMA channel configuration register (DMA_CCR)
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_EN                        \ [0x00] Channel enable
    $01 constant DMA1_TCIE                      \ [0x01] Transfer complete interrupt enable
    $02 constant DMA1_HTIE                      \ [0x02] Half Transfer interrupt enable
    $03 constant DMA1_TEIE                      \ [0x03] Transfer error interrupt enable
    $04 constant DMA1_DIR                       \ [0x04] Data transfer direction
    $05 constant DMA1_CIRC                      \ [0x05] Circular mode
    $06 constant DMA1_PINC                      \ [0x06] Peripheral increment mode
    $07 constant DMA1_MINC                      \ [0x07] Memory increment mode
    $08 constant DMA1_PSIZE                     \ [0x08 : 2] Peripheral size
    $0a constant DMA1_MSIZE                     \ [0x0a : 2] Memory size
    $0c constant DMA1_PL                        \ [0x0c : 2] Channel Priority level
    $0e constant DMA1_MEM2MEM                   \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA1_CNDTR4_DEF
    \
    \ @brief DMA channel 4 number of data register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_NDT                       \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA1_CPAR4_DEF
    \
    \ @brief DMA channel 4 peripheral address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_PA                        \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA1_CMAR4_DEF
    \
    \ @brief DMA channel 4 memory address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_MA                        \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA1_CCR5_DEF
    \
    \ @brief DMA channel configuration register (DMA_CCR)
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_EN                        \ [0x00] Channel enable
    $01 constant DMA1_TCIE                      \ [0x01] Transfer complete interrupt enable
    $02 constant DMA1_HTIE                      \ [0x02] Half Transfer interrupt enable
    $03 constant DMA1_TEIE                      \ [0x03] Transfer error interrupt enable
    $04 constant DMA1_DIR                       \ [0x04] Data transfer direction
    $05 constant DMA1_CIRC                      \ [0x05] Circular mode
    $06 constant DMA1_PINC                      \ [0x06] Peripheral increment mode
    $07 constant DMA1_MINC                      \ [0x07] Memory increment mode
    $08 constant DMA1_PSIZE                     \ [0x08 : 2] Peripheral size
    $0a constant DMA1_MSIZE                     \ [0x0a : 2] Memory size
    $0c constant DMA1_PL                        \ [0x0c : 2] Channel Priority level
    $0e constant DMA1_MEM2MEM                   \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA1_CNDTR5_DEF
    \
    \ @brief DMA channel 5 number of data register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_NDT                       \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA1_CPAR5_DEF
    \
    \ @brief DMA channel 5 peripheral address register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_PA                        \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA1_CMAR5_DEF
    \
    \ @brief DMA channel 5 memory address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_MA                        \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA1_CCR6_DEF
    \
    \ @brief DMA channel configuration register (DMA_CCR)
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_EN                        \ [0x00] Channel enable
    $01 constant DMA1_TCIE                      \ [0x01] Transfer complete interrupt enable
    $02 constant DMA1_HTIE                      \ [0x02] Half Transfer interrupt enable
    $03 constant DMA1_TEIE                      \ [0x03] Transfer error interrupt enable
    $04 constant DMA1_DIR                       \ [0x04] Data transfer direction
    $05 constant DMA1_CIRC                      \ [0x05] Circular mode
    $06 constant DMA1_PINC                      \ [0x06] Peripheral increment mode
    $07 constant DMA1_MINC                      \ [0x07] Memory increment mode
    $08 constant DMA1_PSIZE                     \ [0x08 : 2] Peripheral size
    $0a constant DMA1_MSIZE                     \ [0x0a : 2] Memory size
    $0c constant DMA1_PL                        \ [0x0c : 2] Channel Priority level
    $0e constant DMA1_MEM2MEM                   \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA1_CNDTR6_DEF
    \
    \ @brief DMA channel 6 number of data register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_NDT                       \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA1_CPAR6_DEF
    \
    \ @brief DMA channel 6 peripheral address register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_PA                        \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA1_CMAR6_DEF
    \
    \ @brief DMA channel 6 memory address register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_MA                        \ [0x00 : 32] Memory address
  [then]


  [ifdef] DMA1_CCR7_DEF
    \
    \ @brief DMA channel configuration register (DMA_CCR)
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_EN                        \ [0x00] Channel enable
    $01 constant DMA1_TCIE                      \ [0x01] Transfer complete interrupt enable
    $02 constant DMA1_HTIE                      \ [0x02] Half Transfer interrupt enable
    $03 constant DMA1_TEIE                      \ [0x03] Transfer error interrupt enable
    $04 constant DMA1_DIR                       \ [0x04] Data transfer direction
    $05 constant DMA1_CIRC                      \ [0x05] Circular mode
    $06 constant DMA1_PINC                      \ [0x06] Peripheral increment mode
    $07 constant DMA1_MINC                      \ [0x07] Memory increment mode
    $08 constant DMA1_PSIZE                     \ [0x08 : 2] Peripheral size
    $0a constant DMA1_MSIZE                     \ [0x0a : 2] Memory size
    $0c constant DMA1_PL                        \ [0x0c : 2] Channel Priority level
    $0e constant DMA1_MEM2MEM                   \ [0x0e] Memory to memory mode
  [then]


  [ifdef] DMA1_CNDTR7_DEF
    \
    \ @brief DMA channel 7 number of data register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_NDT                       \ [0x00 : 16] Number of data to transfer
  [then]


  [ifdef] DMA1_CPAR7_DEF
    \
    \ @brief DMA channel 7 peripheral address register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_PA                        \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA1_CMAR7_DEF
    \
    \ @brief DMA channel 7 memory address register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DMA1_MA                        \ [0x00 : 32] Memory address
  [then]

  \
  \ @brief DMA controller
  \
  $00 constant DMA1_ISR                 \ DMA interrupt status register (DMA_ISR)
  $04 constant DMA1_IFCR                \ DMA interrupt flag clear register (DMA_IFCR)
  $08 constant DMA1_CCR1                \ DMA channel configuration register (DMA_CCR)
  $0C constant DMA1_CNDTR1              \ DMA channel 1 number of data register
  $10 constant DMA1_CPAR1               \ DMA channel 1 peripheral address register
  $14 constant DMA1_CMAR1               \ DMA channel 1 memory address register
  $1C constant DMA1_CCR2                \ DMA channel configuration register (DMA_CCR)
  $20 constant DMA1_CNDTR2              \ DMA channel 2 number of data register
  $24 constant DMA1_CPAR2               \ DMA channel 2 peripheral address register
  $28 constant DMA1_CMAR2               \ DMA channel 2 memory address register
  $30 constant DMA1_CCR3                \ DMA channel configuration register (DMA_CCR)
  $34 constant DMA1_CNDTR3              \ DMA channel 3 number of data register
  $38 constant DMA1_CPAR3               \ DMA channel 3 peripheral address register
  $3C constant DMA1_CMAR3               \ DMA channel 3 memory address register
  $44 constant DMA1_CCR4                \ DMA channel configuration register (DMA_CCR)
  $48 constant DMA1_CNDTR4              \ DMA channel 4 number of data register
  $4C constant DMA1_CPAR4               \ DMA channel 4 peripheral address register
  $50 constant DMA1_CMAR4               \ DMA channel 4 memory address register
  $58 constant DMA1_CCR5                \ DMA channel configuration register (DMA_CCR)
  $5C constant DMA1_CNDTR5              \ DMA channel 5 number of data register
  $60 constant DMA1_CPAR5               \ DMA channel 5 peripheral address register
  $64 constant DMA1_CMAR5               \ DMA channel 5 memory address register
  $6C constant DMA1_CCR6                \ DMA channel configuration register (DMA_CCR)
  $70 constant DMA1_CNDTR6              \ DMA channel 6 number of data register
  $74 constant DMA1_CPAR6               \ DMA channel 6 peripheral address register
  $78 constant DMA1_CMAR6               \ DMA channel 6 memory address register
  $80 constant DMA1_CCR7                \ DMA channel configuration register (DMA_CCR)
  $84 constant DMA1_CNDTR7              \ DMA channel 7 number of data register
  $88 constant DMA1_CPAR7               \ DMA channel 7 peripheral address register
  $8C constant DMA1_CMAR7               \ DMA channel 7 memory address register

: DMA1_DEF ; [then]
