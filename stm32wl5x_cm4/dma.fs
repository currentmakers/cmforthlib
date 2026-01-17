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
    $00 constant DMA_GIF1                       \ [0x00] global interrupt flag for channel 1
    $01 constant DMA_TCIF1                      \ [0x01] transfer complete (TC) flag for channel 1
    $02 constant DMA_HTIF1                      \ [0x02] half transfer (HT) flag for channel 1
    $03 constant DMA_TEIF1                      \ [0x03] transfer error (TE) flag for channel 1
    $04 constant DMA_GIF2                       \ [0x04] global interrupt flag for channel 2
    $05 constant DMA_TCIF2                      \ [0x05] transfer complete (TC) flag for channel 2
    $06 constant DMA_HTIF2                      \ [0x06] half transfer (HT) flag for channel 2
    $07 constant DMA_TEIF2                      \ [0x07] transfer error (TE) flag for channel 2
    $08 constant DMA_GIF3                       \ [0x08] global interrupt flag for channel 3
    $09 constant DMA_TCIF3                      \ [0x09] transfer complete (TC) flag for channel 3
    $0a constant DMA_HTIF3                      \ [0x0a] half transfer (HT) flag for channel 3
    $0b constant DMA_TEIF3                      \ [0x0b] transfer error (TE) flag for channel 3
    $0c constant DMA_GIF4                       \ [0x0c] global interrupt flag for channel 4
    $0d constant DMA_TCIF4                      \ [0x0d] transfer complete (TC) flag for channel 4
    $0e constant DMA_HTIF4                      \ [0x0e] half transfer (HT) flag for channel 4
    $0f constant DMA_TEIF4                      \ [0x0f] transfer error (TE) flag for channel 4
    $10 constant DMA_GIF5                       \ [0x10] global interrupt flag for channel 5
    $11 constant DMA_TCIF5                      \ [0x11] transfer complete (TC) flag for channel 5
    $12 constant DMA_HTIF5                      \ [0x12] half transfer (HT) flag for channel 5
    $13 constant DMA_TEIF5                      \ [0x13] transfer error (TE) flag for channel 5
    $14 constant DMA_GIF6                       \ [0x14] global interrupt flag for channel 6
    $15 constant DMA_TCIF6                      \ [0x15] transfer complete (TC) flag for channel 6
    $16 constant DMA_HTIF6                      \ [0x16] half transfer (HT) flag for channel 6
    $17 constant DMA_TEIF6                      \ [0x17] transfer error (TE) flag for channel 6
    $18 constant DMA_GIF7                       \ [0x18] global interrupt flag for channel 7
    $19 constant DMA_TCIF7                      \ [0x19] transfer complete (TC) flag for channel 7
    $1a constant DMA_HTIF7                      \ [0x1a] half transfer (HT) flag for channel 7
    $1b constant DMA_TEIF7                      \ [0x1b] transfer error (TE) flag for channel 7
  [then]


  [ifdef] DMA_IFCR_DEF
    \
    \ @brief interrupt flag clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA_GIF1                       \ [0x00] global interrupt flag clear for channel 1
    $01 constant DMA_TCIF1                      \ [0x01] transfer complete flag clear for channel 1
    $02 constant DMA_HTIF1                      \ [0x02] half transfer flag clear for channel 1
    $03 constant DMA_TEIF1                      \ [0x03] transfer error flag clear for channel 1
    $04 constant DMA_GIF2                       \ [0x04] global interrupt flag clear for channel 2
    $05 constant DMA_TCIF2                      \ [0x05] transfer complete flag clear for channel 2
    $06 constant DMA_HTIF2                      \ [0x06] half transfer flag clear for channel 2
    $07 constant DMA_TEIF2                      \ [0x07] transfer error flag clear for channel 2
    $08 constant DMA_GIF3                       \ [0x08] global interrupt flag clear for channel 3
    $09 constant DMA_TCIF3                      \ [0x09] transfer complete flag clear for channel 3
    $0a constant DMA_HTIF3                      \ [0x0a] half transfer flag clear for channel 3
    $0b constant DMA_TEIF3                      \ [0x0b] transfer error flag clear for channel 3
    $0c constant DMA_GIF4                       \ [0x0c] global interrupt flag clear for channel 4
    $0d constant DMA_TCIF4                      \ [0x0d] transfer complete flag clear for channel 4
    $0e constant DMA_HTIF4                      \ [0x0e] half transfer flag clear for channel 4
    $0f constant DMA_TEIF4                      \ [0x0f] transfer error flag clear for channel 4
    $10 constant DMA_GIF5                       \ [0x10] global interrupt flag clear for channel 5
    $11 constant DMA_TCIF5                      \ [0x11] transfer complete flag clear for channel 5
    $12 constant DMA_HTIF5                      \ [0x12] half transfer flag clear for channel 5
    $13 constant DMA_TEIF5                      \ [0x13] transfer error flag clear for channel 5
    $14 constant DMA_GIF6                       \ [0x14] global interrupt flag clear for channel 6
    $15 constant DMA_TCIF6                      \ [0x15] transfer complete flag clear for channel 6
    $16 constant DMA_HTIF6                      \ [0x16] half transfer flag clear for channel 6
    $17 constant DMA_TEIF6                      \ [0x17] transfer error flag clear for channel 6
    $18 constant DMA_GIF7                       \ [0x18] global interrupt flag clear for channel 7
    $19 constant DMA_TCIF7                      \ [0x19] transfer complete flag clear for channel 7
    $1a constant DMA_HTIF7                      \ [0x1a] half transfer flag clear for channel 7
    $1b constant DMA_TEIF7                      \ [0x1b] transfer error flag clear for channel 7
  [then]


  [ifdef] DMA_CCR1_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] circular mode
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size
    $0c constant DMA_PL                         \ [0x0c : 2] priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode
    $11 constant DMA_SECM                       \ [0x11] ecure mode
    $12 constant DMA_SSEC                       \ [0x12] ecurity of the DMA transfer from the source
    $13 constant DMA_DSEC                       \ [0x13] ecurity of the DMA transfer to the destination
    $14 constant DMA_PRIV                       \ [0x14] rivileged mode
  [then]


  [ifdef] DMA_CNDTR1_DEF
    \
    \ @brief channel x number of data to transfer register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 18] number of data to transfer (0 to 218 - 1)
  [then]


  [ifdef] DMA_CPAR1_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CMAR1_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CCR2_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] circular mode
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size
    $0c constant DMA_PL                         \ [0x0c : 2] priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode
    $11 constant DMA_SECM                       \ [0x11] ecure mode
    $12 constant DMA_SSEC                       \ [0x12] ecurity of the DMA transfer from the source
    $13 constant DMA_DSEC                       \ [0x13] ecurity of the DMA transfer to the destination
    $14 constant DMA_PRIV                       \ [0x14] rivileged mode
  [then]


  [ifdef] DMA_CNDTR2_DEF
    \
    \ @brief channel x number of data to transfer register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 18] number of data to transfer (0 to 218 - 1)
  [then]


  [ifdef] DMA_CPAR2_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CMAR2_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CCR3_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] circular mode
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size
    $0c constant DMA_PL                         \ [0x0c : 2] priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode
    $11 constant DMA_SECM                       \ [0x11] ecure mode
    $12 constant DMA_SSEC                       \ [0x12] ecurity of the DMA transfer from the source
    $13 constant DMA_DSEC                       \ [0x13] ecurity of the DMA transfer to the destination
    $14 constant DMA_PRIV                       \ [0x14] rivileged mode
  [then]


  [ifdef] DMA_CNDTR3_DEF
    \
    \ @brief channel x number of data to transfer register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 18] number of data to transfer (0 to 218 - 1)
  [then]


  [ifdef] DMA_CPAR3_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CMAR3_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CCR4_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] circular mode
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size
    $0c constant DMA_PL                         \ [0x0c : 2] priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode
    $11 constant DMA_SECM                       \ [0x11] ecure mode
    $12 constant DMA_SSEC                       \ [0x12] ecurity of the DMA transfer from the source
    $13 constant DMA_DSEC                       \ [0x13] ecurity of the DMA transfer to the destination
    $14 constant DMA_PRIV                       \ [0x14] rivileged mode
  [then]


  [ifdef] DMA_CNDTR4_DEF
    \
    \ @brief channel x number of data to transfer register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 18] number of data to transfer (0 to 218 - 1)
  [then]


  [ifdef] DMA_CPAR4_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CMAR4_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CCR5_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] circular mode
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size
    $0c constant DMA_PL                         \ [0x0c : 2] priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode
    $11 constant DMA_SECM                       \ [0x11] ecure mode
    $12 constant DMA_SSEC                       \ [0x12] ecurity of the DMA transfer from the source
    $13 constant DMA_DSEC                       \ [0x13] ecurity of the DMA transfer to the destination
    $14 constant DMA_PRIV                       \ [0x14] rivileged mode
  [then]


  [ifdef] DMA_CNDTR5_DEF
    \
    \ @brief channel x number of data to transfer register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 18] number of data to transfer (0 to 218 - 1)
  [then]


  [ifdef] DMA_CPAR5_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CMAR5_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CCR6_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] circular mode
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size
    $0c constant DMA_PL                         \ [0x0c : 2] priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode
    $11 constant DMA_SECM                       \ [0x11] ecure mode
    $12 constant DMA_SSEC                       \ [0x12] ecurity of the DMA transfer from the source
    $13 constant DMA_DSEC                       \ [0x13] ecurity of the DMA transfer to the destination
    $14 constant DMA_PRIV                       \ [0x14] rivileged mode
  [then]


  [ifdef] DMA_CNDTR6_DEF
    \
    \ @brief channel x number of data to transfer register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 18] number of data to transfer (0 to 218 - 1)
  [then]


  [ifdef] DMA_CPAR6_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CMAR6_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CCR7_DEF
    \
    \ @brief channel x configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] channel enable
    $01 constant DMA_TCIE                       \ [0x01] transfer complete interrupt enable
    $02 constant DMA_HTIE                       \ [0x02] half transfer interrupt enable
    $03 constant DMA_TEIE                       \ [0x03] transfer error interrupt enable
    $04 constant DMA_DIR                        \ [0x04] data transfer direction
    $05 constant DMA_CIRC                       \ [0x05] circular mode
    $06 constant DMA_PINC                       \ [0x06] peripheral increment mode
    $07 constant DMA_MINC                       \ [0x07] memory increment mode
    $08 constant DMA_PSIZE                      \ [0x08 : 2] peripheral size
    $0a constant DMA_MSIZE                      \ [0x0a : 2] memory size
    $0c constant DMA_PL                         \ [0x0c : 2] priority level
    $0e constant DMA_MEM2MEM                    \ [0x0e] memory-to-memory mode
    $11 constant DMA_SECM                       \ [0x11] ecure mode
    $12 constant DMA_SSEC                       \ [0x12] ecurity of the DMA transfer from the source
    $13 constant DMA_DSEC                       \ [0x13] ecurity of the DMA transfer to the destination
    $14 constant DMA_PRIV                       \ [0x14] rivileged mode
  [then]


  [ifdef] DMA_CNDTR7_DEF
    \
    \ @brief channel x number of data to transfer register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 18] number of data to transfer (0 to 218 - 1)
  [then]


  [ifdef] DMA_CPAR7_DEF
    \
    \ @brief channel x peripheral address register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] peripheral address
  [then]


  [ifdef] DMA_CMAR7_DEF
    \
    \ @brief channel x memory address register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_MA                         \ [0x00 : 32] peripheral address
  [then]

  \
  \ @brief Direct memory access controller
  \
  $00 constant DMA_ISR                  \ interrupt status register
  $04 constant DMA_IFCR                 \ interrupt flag clear register
  $08 constant DMA_CCR1                 \ channel x configuration register
  $0C constant DMA_CNDTR1               \ channel x number of data to transfer register
  $10 constant DMA_CPAR1                \ channel x peripheral address register
  $14 constant DMA_CMAR1                \ channel x memory address register
  $1C constant DMA_CCR2                 \ channel x configuration register
  $20 constant DMA_CNDTR2               \ channel x number of data to transfer register
  $24 constant DMA_CPAR2                \ channel x peripheral address register
  $28 constant DMA_CMAR2                \ channel x memory address register
  $30 constant DMA_CCR3                 \ channel x configuration register
  $34 constant DMA_CNDTR3               \ channel x number of data to transfer register
  $38 constant DMA_CPAR3                \ channel x peripheral address register
  $3C constant DMA_CMAR3                \ channel x memory address register
  $44 constant DMA_CCR4                 \ channel x configuration register
  $48 constant DMA_CNDTR4               \ channel x number of data to transfer register
  $4C constant DMA_CPAR4                \ channel x peripheral address register
  $50 constant DMA_CMAR4                \ channel x memory address register
  $58 constant DMA_CCR5                 \ channel x configuration register
  $5C constant DMA_CNDTR5               \ channel x number of data to transfer register
  $60 constant DMA_CPAR5                \ channel x peripheral address register
  $64 constant DMA_CMAR5                \ channel x memory address register
  $6C constant DMA_CCR6                 \ channel x configuration register
  $70 constant DMA_CNDTR6               \ channel x number of data to transfer register
  $74 constant DMA_CPAR6                \ channel x peripheral address register
  $78 constant DMA_CMAR6                \ channel x memory address register
  $80 constant DMA_CCR7                 \ channel x configuration register
  $84 constant DMA_CNDTR7               \ channel x number of data to transfer register
  $88 constant DMA_CPAR7                \ channel x peripheral address register
  $8C constant DMA_CMAR7                \ channel x memory address register

: DMA_DEF ; [then]
