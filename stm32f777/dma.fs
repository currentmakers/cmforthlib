\
\ @file dma.fs
\ @brief DMA controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA_DEF

  [ifdef] DMA_LISR_DEF
    \
    \ @brief low interrupt status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA_FEIF0                      \ [0x00] Stream x FIFO error interrupt flag (x=3..0)
    $02 constant DMA_DMEIF0                     \ [0x02] Stream x direct mode error interrupt flag (x=3..0)
    $03 constant DMA_TEIF0                      \ [0x03] Stream x transfer error interrupt flag (x=3..0)
    $04 constant DMA_HTIF0                      \ [0x04] Stream x half transfer interrupt flag (x=3..0)
    $05 constant DMA_TCIF0                      \ [0x05] Stream x transfer complete interrupt flag (x = 3..0)
    $06 constant DMA_FEIF1                      \ [0x06] Stream x FIFO error interrupt flag (x=3..0)
    $08 constant DMA_DMEIF1                     \ [0x08] Stream x direct mode error interrupt flag (x=3..0)
    $09 constant DMA_TEIF1                      \ [0x09] Stream x transfer error interrupt flag (x=3..0)
    $0a constant DMA_HTIF1                      \ [0x0a] Stream x half transfer interrupt flag (x=3..0)
    $0b constant DMA_TCIF1                      \ [0x0b] Stream x transfer complete interrupt flag (x = 3..0)
    $10 constant DMA_FEIF2                      \ [0x10] Stream x FIFO error interrupt flag (x=3..0)
    $12 constant DMA_DMEIF2                     \ [0x12] Stream x direct mode error interrupt flag (x=3..0)
    $13 constant DMA_TEIF2                      \ [0x13] Stream x transfer error interrupt flag (x=3..0)
    $14 constant DMA_HTIF2                      \ [0x14] Stream x half transfer interrupt flag (x=3..0)
    $15 constant DMA_TCIF2                      \ [0x15] Stream x transfer complete interrupt flag (x = 3..0)
    $16 constant DMA_FEIF3                      \ [0x16] Stream x FIFO error interrupt flag (x=3..0)
    $18 constant DMA_DMEIF3                     \ [0x18] Stream x direct mode error interrupt flag (x=3..0)
    $19 constant DMA_TEIF3                      \ [0x19] Stream x transfer error interrupt flag (x=3..0)
    $1a constant DMA_HTIF3                      \ [0x1a] Stream x half transfer interrupt flag (x=3..0)
    $1b constant DMA_TCIF3                      \ [0x1b] Stream x transfer complete interrupt flag (x = 3..0)
  [then]


  [ifdef] DMA_HISR_DEF
    \
    \ @brief high interrupt status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA_FEIF4                      \ [0x00] Stream x FIFO error interrupt flag (x=7..4)
    $02 constant DMA_DMEIF4                     \ [0x02] Stream x direct mode error interrupt flag (x=7..4)
    $03 constant DMA_TEIF4                      \ [0x03] Stream x transfer error interrupt flag (x=7..4)
    $04 constant DMA_HTIF4                      \ [0x04] Stream x half transfer interrupt flag (x=7..4)
    $05 constant DMA_TCIF4                      \ [0x05] Stream x transfer complete interrupt flag (x=7..4)
    $06 constant DMA_FEIF5                      \ [0x06] Stream x FIFO error interrupt flag (x=7..4)
    $08 constant DMA_DMEIF5                     \ [0x08] Stream x direct mode error interrupt flag (x=7..4)
    $09 constant DMA_TEIF5                      \ [0x09] Stream x transfer error interrupt flag (x=7..4)
    $0a constant DMA_HTIF5                      \ [0x0a] Stream x half transfer interrupt flag (x=7..4)
    $0b constant DMA_TCIF5                      \ [0x0b] Stream x transfer complete interrupt flag (x=7..4)
    $10 constant DMA_FEIF6                      \ [0x10] Stream x FIFO error interrupt flag (x=7..4)
    $12 constant DMA_DMEIF6                     \ [0x12] Stream x direct mode error interrupt flag (x=7..4)
    $13 constant DMA_TEIF6                      \ [0x13] Stream x transfer error interrupt flag (x=7..4)
    $14 constant DMA_HTIF6                      \ [0x14] Stream x half transfer interrupt flag (x=7..4)
    $15 constant DMA_TCIF6                      \ [0x15] Stream x transfer complete interrupt flag (x=7..4)
    $16 constant DMA_FEIF7                      \ [0x16] Stream x FIFO error interrupt flag (x=7..4)
    $18 constant DMA_DMEIF7                     \ [0x18] Stream x direct mode error interrupt flag (x=7..4)
    $19 constant DMA_TEIF7                      \ [0x19] Stream x transfer error interrupt flag (x=7..4)
    $1a constant DMA_HTIF7                      \ [0x1a] Stream x half transfer interrupt flag (x=7..4)
    $1b constant DMA_TCIF7                      \ [0x1b] Stream x transfer complete interrupt flag (x=7..4)
  [then]


  [ifdef] DMA_LIFCR_DEF
    \
    \ @brief low interrupt flag clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CFEIF0                     \ [0x00] Stream x clear FIFO error interrupt flag (x = 3..0)
    $02 constant DMA_CDMEIF0                    \ [0x02] Stream x clear direct mode error interrupt flag (x = 3..0)
    $03 constant DMA_CTEIF0                     \ [0x03] Stream x clear transfer error interrupt flag (x = 3..0)
    $04 constant DMA_CHTIF0                     \ [0x04] Stream x clear half transfer interrupt flag (x = 3..0)
    $05 constant DMA_CTCIF0                     \ [0x05] Stream x clear transfer complete interrupt flag (x = 3..0)
    $06 constant DMA_CFEIF1                     \ [0x06] Stream x clear FIFO error interrupt flag (x = 3..0)
    $08 constant DMA_CDMEIF1                    \ [0x08] Stream x clear direct mode error interrupt flag (x = 3..0)
    $09 constant DMA_CTEIF1                     \ [0x09] Stream x clear transfer error interrupt flag (x = 3..0)
    $0a constant DMA_CHTIF1                     \ [0x0a] Stream x clear half transfer interrupt flag (x = 3..0)
    $0b constant DMA_CTCIF1                     \ [0x0b] Stream x clear transfer complete interrupt flag (x = 3..0)
    $10 constant DMA_CFEIF2                     \ [0x10] Stream x clear FIFO error interrupt flag (x = 3..0)
    $12 constant DMA_CDMEIF2                    \ [0x12] Stream x clear direct mode error interrupt flag (x = 3..0)
    $13 constant DMA_CTEIF2                     \ [0x13] Stream x clear transfer error interrupt flag (x = 3..0)
    $14 constant DMA_CHTIF2                     \ [0x14] Stream x clear half transfer interrupt flag (x = 3..0)
    $15 constant DMA_CTCIF2                     \ [0x15] Stream x clear transfer complete interrupt flag (x = 3..0)
    $16 constant DMA_CFEIF3                     \ [0x16] Stream x clear FIFO error interrupt flag (x = 3..0)
    $18 constant DMA_CDMEIF3                    \ [0x18] Stream x clear direct mode error interrupt flag (x = 3..0)
    $19 constant DMA_CTEIF3                     \ [0x19] Stream x clear transfer error interrupt flag (x = 3..0)
    $1a constant DMA_CHTIF3                     \ [0x1a] Stream x clear half transfer interrupt flag (x = 3..0)
    $1b constant DMA_CTCIF3                     \ [0x1b] Stream x clear transfer complete interrupt flag (x = 3..0)
  [then]


  [ifdef] DMA_HIFCR_DEF
    \
    \ @brief high interrupt flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CFEIF4                     \ [0x00] Stream x clear FIFO error interrupt flag (x = 7..4)
    $02 constant DMA_CDMEIF4                    \ [0x02] Stream x clear direct mode error interrupt flag (x = 7..4)
    $03 constant DMA_CTEIF4                     \ [0x03] Stream x clear transfer error interrupt flag (x = 7..4)
    $04 constant DMA_CHTIF4                     \ [0x04] Stream x clear half transfer interrupt flag (x = 7..4)
    $05 constant DMA_CTCIF4                     \ [0x05] Stream x clear transfer complete interrupt flag (x = 7..4)
    $06 constant DMA_CFEIF5                     \ [0x06] Stream x clear FIFO error interrupt flag (x = 7..4)
    $08 constant DMA_CDMEIF5                    \ [0x08] Stream x clear direct mode error interrupt flag (x = 7..4)
    $09 constant DMA_CTEIF5                     \ [0x09] Stream x clear transfer error interrupt flag (x = 7..4)
    $0a constant DMA_CHTIF5                     \ [0x0a] Stream x clear half transfer interrupt flag (x = 7..4)
    $0b constant DMA_CTCIF5                     \ [0x0b] Stream x clear transfer complete interrupt flag (x = 7..4)
    $10 constant DMA_CFEIF6                     \ [0x10] Stream x clear FIFO error interrupt flag (x = 7..4)
    $12 constant DMA_CDMEIF6                    \ [0x12] Stream x clear direct mode error interrupt flag (x = 7..4)
    $13 constant DMA_CTEIF6                     \ [0x13] Stream x clear transfer error interrupt flag (x = 7..4)
    $14 constant DMA_CHTIF6                     \ [0x14] Stream x clear half transfer interrupt flag (x = 7..4)
    $15 constant DMA_CTCIF6                     \ [0x15] Stream x clear transfer complete interrupt flag (x = 7..4)
    $16 constant DMA_CFEIF7                     \ [0x16] Stream x clear FIFO error interrupt flag (x = 7..4)
    $18 constant DMA_CDMEIF7                    \ [0x18] Stream x clear direct mode error interrupt flag (x = 7..4)
    $19 constant DMA_CTEIF7                     \ [0x19] Stream x clear transfer error interrupt flag (x = 7..4)
    $1a constant DMA_CHTIF7                     \ [0x1a] Stream x clear half transfer interrupt flag (x = 7..4)
    $1b constant DMA_CTCIF7                     \ [0x1b] Stream x clear transfer complete interrupt flag (x = 7..4)
  [then]


  [ifdef] DMA_S0CR_DEF
    \
    \ @brief stream x configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Stream enable / flag stream ready when read low
    $01 constant DMA_DMEIE                      \ [0x01] Direct mode error interrupt enable
    $02 constant DMA_TEIE                       \ [0x02] Transfer error interrupt enable
    $03 constant DMA_HTIE                       \ [0x03] Half transfer interrupt enable
    $04 constant DMA_TCIE                       \ [0x04] Transfer complete interrupt enable
    $05 constant DMA_PFCTRL                     \ [0x05] Peripheral flow controller
    $06 constant DMA_DIR                        \ [0x06 : 2] Data transfer direction
    $08 constant DMA_CIRC                       \ [0x08] Circular mode
    $09 constant DMA_PINC                       \ [0x09] Peripheral increment mode
    $0a constant DMA_MINC                       \ [0x0a] Memory increment mode
    $0b constant DMA_PSIZE                      \ [0x0b : 2] Peripheral data size
    $0d constant DMA_MSIZE                      \ [0x0d : 2] Memory data size
    $0f constant DMA_PINCOS                     \ [0x0f] Peripheral increment offset size
    $10 constant DMA_PL                         \ [0x10 : 2] Priority level
    $12 constant DMA_DBM                        \ [0x12] Double buffer mode
    $13 constant DMA_CT                         \ [0x13] Current target (only in double buffer mode)
    $15 constant DMA_PBURST                     \ [0x15 : 2] Peripheral burst transfer configuration
    $17 constant DMA_MBURST                     \ [0x17 : 2] Memory burst transfer configuration
    $19 constant DMA_CHSEL                      \ [0x19 : 4] Channel selection
  [then]


  [ifdef] DMA_S0NDTR_DEF
    \
    \ @brief stream x number of data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data items to transfer
  [then]


  [ifdef] DMA_S0PAR_DEF
    \
    \ @brief stream x peripheral address register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_S0M0AR_DEF
    \
    \ @brief stream x memory 0 address register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] Memory 0 address
  [then]


  [ifdef] DMA_S0M1AR_DEF
    \
    \ @brief stream x memory 1 address register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] Memory 1 address (used in case of Double buffer mode)
  [then]


  [ifdef] DMA_S0FCR_DEF
    \
    \ @brief stream x FIFO control register
    \ Address offset: 0x24
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection
    $02 constant DMA_DMDIS                      \ [0x02] Direct mode disable
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable
  [then]


  [ifdef] DMA_S1CR_DEF
    \
    \ @brief stream x configuration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Stream enable / flag stream ready when read low
    $01 constant DMA_DMEIE                      \ [0x01] Direct mode error interrupt enable
    $02 constant DMA_TEIE                       \ [0x02] Transfer error interrupt enable
    $03 constant DMA_HTIE                       \ [0x03] Half transfer interrupt enable
    $04 constant DMA_TCIE                       \ [0x04] Transfer complete interrupt enable
    $05 constant DMA_PFCTRL                     \ [0x05] Peripheral flow controller
    $06 constant DMA_DIR                        \ [0x06 : 2] Data transfer direction
    $08 constant DMA_CIRC                       \ [0x08] Circular mode
    $09 constant DMA_PINC                       \ [0x09] Peripheral increment mode
    $0a constant DMA_MINC                       \ [0x0a] Memory increment mode
    $0b constant DMA_PSIZE                      \ [0x0b : 2] Peripheral data size
    $0d constant DMA_MSIZE                      \ [0x0d : 2] Memory data size
    $0f constant DMA_PINCOS                     \ [0x0f] Peripheral increment offset size
    $10 constant DMA_PL                         \ [0x10 : 2] Priority level
    $12 constant DMA_DBM                        \ [0x12] Double buffer mode
    $13 constant DMA_CT                         \ [0x13] Current target (only in double buffer mode)
    $14 constant DMA_ACK                        \ [0x14] ACK
    $15 constant DMA_PBURST                     \ [0x15 : 2] Peripheral burst transfer configuration
    $17 constant DMA_MBURST                     \ [0x17 : 2] Memory burst transfer configuration
    $19 constant DMA_CHSEL                      \ [0x19 : 4] Channel selection
  [then]


  [ifdef] DMA_S1NDTR_DEF
    \
    \ @brief stream x number of data register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data items to transfer
  [then]


  [ifdef] DMA_S1PAR_DEF
    \
    \ @brief stream x peripheral address register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_S1M0AR_DEF
    \
    \ @brief stream x memory 0 address register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] Memory 0 address
  [then]


  [ifdef] DMA_S1M1AR_DEF
    \
    \ @brief stream x memory 1 address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] Memory 1 address (used in case of Double buffer mode)
  [then]


  [ifdef] DMA_S1FCR_DEF
    \
    \ @brief stream x FIFO control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection
    $02 constant DMA_DMDIS                      \ [0x02] Direct mode disable
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable
  [then]


  [ifdef] DMA_S2CR_DEF
    \
    \ @brief stream x configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Stream enable / flag stream ready when read low
    $01 constant DMA_DMEIE                      \ [0x01] Direct mode error interrupt enable
    $02 constant DMA_TEIE                       \ [0x02] Transfer error interrupt enable
    $03 constant DMA_HTIE                       \ [0x03] Half transfer interrupt enable
    $04 constant DMA_TCIE                       \ [0x04] Transfer complete interrupt enable
    $05 constant DMA_PFCTRL                     \ [0x05] Peripheral flow controller
    $06 constant DMA_DIR                        \ [0x06 : 2] Data transfer direction
    $08 constant DMA_CIRC                       \ [0x08] Circular mode
    $09 constant DMA_PINC                       \ [0x09] Peripheral increment mode
    $0a constant DMA_MINC                       \ [0x0a] Memory increment mode
    $0b constant DMA_PSIZE                      \ [0x0b : 2] Peripheral data size
    $0d constant DMA_MSIZE                      \ [0x0d : 2] Memory data size
    $0f constant DMA_PINCOS                     \ [0x0f] Peripheral increment offset size
    $10 constant DMA_PL                         \ [0x10 : 2] Priority level
    $12 constant DMA_DBM                        \ [0x12] Double buffer mode
    $13 constant DMA_CT                         \ [0x13] Current target (only in double buffer mode)
    $14 constant DMA_ACK                        \ [0x14] ACK
    $15 constant DMA_PBURST                     \ [0x15 : 2] Peripheral burst transfer configuration
    $17 constant DMA_MBURST                     \ [0x17 : 2] Memory burst transfer configuration
    $19 constant DMA_CHSEL                      \ [0x19 : 4] Channel selection
  [then]


  [ifdef] DMA_S2NDTR_DEF
    \
    \ @brief stream x number of data register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data items to transfer
  [then]


  [ifdef] DMA_S2PAR_DEF
    \
    \ @brief stream x peripheral address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_S2M0AR_DEF
    \
    \ @brief stream x memory 0 address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] Memory 0 address
  [then]


  [ifdef] DMA_S2M1AR_DEF
    \
    \ @brief stream x memory 1 address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] Memory 1 address (used in case of Double buffer mode)
  [then]


  [ifdef] DMA_S2FCR_DEF
    \
    \ @brief stream x FIFO control register
    \ Address offset: 0x54
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection
    $02 constant DMA_DMDIS                      \ [0x02] Direct mode disable
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable
  [then]


  [ifdef] DMA_S3CR_DEF
    \
    \ @brief stream x configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Stream enable / flag stream ready when read low
    $01 constant DMA_DMEIE                      \ [0x01] Direct mode error interrupt enable
    $02 constant DMA_TEIE                       \ [0x02] Transfer error interrupt enable
    $03 constant DMA_HTIE                       \ [0x03] Half transfer interrupt enable
    $04 constant DMA_TCIE                       \ [0x04] Transfer complete interrupt enable
    $05 constant DMA_PFCTRL                     \ [0x05] Peripheral flow controller
    $06 constant DMA_DIR                        \ [0x06 : 2] Data transfer direction
    $08 constant DMA_CIRC                       \ [0x08] Circular mode
    $09 constant DMA_PINC                       \ [0x09] Peripheral increment mode
    $0a constant DMA_MINC                       \ [0x0a] Memory increment mode
    $0b constant DMA_PSIZE                      \ [0x0b : 2] Peripheral data size
    $0d constant DMA_MSIZE                      \ [0x0d : 2] Memory data size
    $0f constant DMA_PINCOS                     \ [0x0f] Peripheral increment offset size
    $10 constant DMA_PL                         \ [0x10 : 2] Priority level
    $12 constant DMA_DBM                        \ [0x12] Double buffer mode
    $13 constant DMA_CT                         \ [0x13] Current target (only in double buffer mode)
    $14 constant DMA_ACK                        \ [0x14] ACK
    $15 constant DMA_PBURST                     \ [0x15 : 2] Peripheral burst transfer configuration
    $17 constant DMA_MBURST                     \ [0x17 : 2] Memory burst transfer configuration
    $19 constant DMA_CHSEL                      \ [0x19 : 4] Channel selection
  [then]


  [ifdef] DMA_S3NDTR_DEF
    \
    \ @brief stream x number of data register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data items to transfer
  [then]


  [ifdef] DMA_S3PAR_DEF
    \
    \ @brief stream x peripheral address register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_S3M0AR_DEF
    \
    \ @brief stream x memory 0 address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] Memory 0 address
  [then]


  [ifdef] DMA_S3M1AR_DEF
    \
    \ @brief stream x memory 1 address register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] Memory 1 address (used in case of Double buffer mode)
  [then]


  [ifdef] DMA_S3FCR_DEF
    \
    \ @brief stream x FIFO control register
    \ Address offset: 0x6C
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection
    $02 constant DMA_DMDIS                      \ [0x02] Direct mode disable
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable
  [then]


  [ifdef] DMA_S4CR_DEF
    \
    \ @brief stream x configuration register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Stream enable / flag stream ready when read low
    $01 constant DMA_DMEIE                      \ [0x01] Direct mode error interrupt enable
    $02 constant DMA_TEIE                       \ [0x02] Transfer error interrupt enable
    $03 constant DMA_HTIE                       \ [0x03] Half transfer interrupt enable
    $04 constant DMA_TCIE                       \ [0x04] Transfer complete interrupt enable
    $05 constant DMA_PFCTRL                     \ [0x05] Peripheral flow controller
    $06 constant DMA_DIR                        \ [0x06 : 2] Data transfer direction
    $08 constant DMA_CIRC                       \ [0x08] Circular mode
    $09 constant DMA_PINC                       \ [0x09] Peripheral increment mode
    $0a constant DMA_MINC                       \ [0x0a] Memory increment mode
    $0b constant DMA_PSIZE                      \ [0x0b : 2] Peripheral data size
    $0d constant DMA_MSIZE                      \ [0x0d : 2] Memory data size
    $0f constant DMA_PINCOS                     \ [0x0f] Peripheral increment offset size
    $10 constant DMA_PL                         \ [0x10 : 2] Priority level
    $12 constant DMA_DBM                        \ [0x12] Double buffer mode
    $13 constant DMA_CT                         \ [0x13] Current target (only in double buffer mode)
    $14 constant DMA_ACK                        \ [0x14] ACK
    $15 constant DMA_PBURST                     \ [0x15 : 2] Peripheral burst transfer configuration
    $17 constant DMA_MBURST                     \ [0x17 : 2] Memory burst transfer configuration
    $19 constant DMA_CHSEL                      \ [0x19 : 3] Channel selection
  [then]


  [ifdef] DMA_S4NDTR_DEF
    \
    \ @brief stream x number of data register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data items to transfer
  [then]


  [ifdef] DMA_S4PAR_DEF
    \
    \ @brief stream x peripheral address register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_S4M0AR_DEF
    \
    \ @brief stream x memory 0 address register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] Memory 0 address
  [then]


  [ifdef] DMA_S4M1AR_DEF
    \
    \ @brief stream x memory 1 address register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] Memory 1 address (used in case of Double buffer mode)
  [then]


  [ifdef] DMA_S4FCR_DEF
    \
    \ @brief stream x FIFO control register
    \ Address offset: 0x84
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection
    $02 constant DMA_DMDIS                      \ [0x02] Direct mode disable
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable
  [then]


  [ifdef] DMA_S5CR_DEF
    \
    \ @brief stream x configuration register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Stream enable / flag stream ready when read low
    $01 constant DMA_DMEIE                      \ [0x01] Direct mode error interrupt enable
    $02 constant DMA_TEIE                       \ [0x02] Transfer error interrupt enable
    $03 constant DMA_HTIE                       \ [0x03] Half transfer interrupt enable
    $04 constant DMA_TCIE                       \ [0x04] Transfer complete interrupt enable
    $05 constant DMA_PFCTRL                     \ [0x05] Peripheral flow controller
    $06 constant DMA_DIR                        \ [0x06 : 2] Data transfer direction
    $08 constant DMA_CIRC                       \ [0x08] Circular mode
    $09 constant DMA_PINC                       \ [0x09] Peripheral increment mode
    $0a constant DMA_MINC                       \ [0x0a] Memory increment mode
    $0b constant DMA_PSIZE                      \ [0x0b : 2] Peripheral data size
    $0d constant DMA_MSIZE                      \ [0x0d : 2] Memory data size
    $0f constant DMA_PINCOS                     \ [0x0f] Peripheral increment offset size
    $10 constant DMA_PL                         \ [0x10 : 2] Priority level
    $12 constant DMA_DBM                        \ [0x12] Double buffer mode
    $13 constant DMA_CT                         \ [0x13] Current target (only in double buffer mode)
    $14 constant DMA_ACK                        \ [0x14] ACK
    $15 constant DMA_PBURST                     \ [0x15 : 2] Peripheral burst transfer configuration
    $17 constant DMA_MBURST                     \ [0x17 : 2] Memory burst transfer configuration
    $19 constant DMA_CHSEL                      \ [0x19 : 4] Channel selection
  [then]


  [ifdef] DMA_S5NDTR_DEF
    \
    \ @brief stream x number of data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data items to transfer
  [then]


  [ifdef] DMA_S5PAR_DEF
    \
    \ @brief stream x peripheral address register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_S5M0AR_DEF
    \
    \ @brief stream x memory 0 address register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] Memory 0 address
  [then]


  [ifdef] DMA_S5M1AR_DEF
    \
    \ @brief stream x memory 1 address register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] Memory 1 address (used in case of Double buffer mode)
  [then]


  [ifdef] DMA_S5FCR_DEF
    \
    \ @brief stream x FIFO control register
    \ Address offset: 0x9C
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection
    $02 constant DMA_DMDIS                      \ [0x02] Direct mode disable
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable
  [then]


  [ifdef] DMA_S6CR_DEF
    \
    \ @brief stream x configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Stream enable / flag stream ready when read low
    $01 constant DMA_DMEIE                      \ [0x01] Direct mode error interrupt enable
    $02 constant DMA_TEIE                       \ [0x02] Transfer error interrupt enable
    $03 constant DMA_HTIE                       \ [0x03] Half transfer interrupt enable
    $04 constant DMA_TCIE                       \ [0x04] Transfer complete interrupt enable
    $05 constant DMA_PFCTRL                     \ [0x05] Peripheral flow controller
    $06 constant DMA_DIR                        \ [0x06 : 2] Data transfer direction
    $08 constant DMA_CIRC                       \ [0x08] Circular mode
    $09 constant DMA_PINC                       \ [0x09] Peripheral increment mode
    $0a constant DMA_MINC                       \ [0x0a] Memory increment mode
    $0b constant DMA_PSIZE                      \ [0x0b : 2] Peripheral data size
    $0d constant DMA_MSIZE                      \ [0x0d : 2] Memory data size
    $0f constant DMA_PINCOS                     \ [0x0f] Peripheral increment offset size
    $10 constant DMA_PL                         \ [0x10 : 2] Priority level
    $12 constant DMA_DBM                        \ [0x12] Double buffer mode
    $13 constant DMA_CT                         \ [0x13] Current target (only in double buffer mode)
    $14 constant DMA_ACK                        \ [0x14] ACK
    $15 constant DMA_PBURST                     \ [0x15 : 2] Peripheral burst transfer configuration
    $17 constant DMA_MBURST                     \ [0x17 : 2] Memory burst transfer configuration
    $19 constant DMA_CHSEL                      \ [0x19 : 4] Channel selection
  [then]


  [ifdef] DMA_S6NDTR_DEF
    \
    \ @brief stream x number of data register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data items to transfer
  [then]


  [ifdef] DMA_S6PAR_DEF
    \
    \ @brief stream x peripheral address register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_S6M0AR_DEF
    \
    \ @brief stream x memory 0 address register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] Memory 0 address
  [then]


  [ifdef] DMA_S6M1AR_DEF
    \
    \ @brief stream x memory 1 address register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] Memory 1 address (used in case of Double buffer mode)
  [then]


  [ifdef] DMA_S6FCR_DEF
    \
    \ @brief stream x FIFO control register
    \ Address offset: 0xB4
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection
    $02 constant DMA_DMDIS                      \ [0x02] Direct mode disable
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable
  [then]


  [ifdef] DMA_S7CR_DEF
    \
    \ @brief stream x configuration register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] Stream enable / flag stream ready when read low
    $01 constant DMA_DMEIE                      \ [0x01] Direct mode error interrupt enable
    $02 constant DMA_TEIE                       \ [0x02] Transfer error interrupt enable
    $03 constant DMA_HTIE                       \ [0x03] Half transfer interrupt enable
    $04 constant DMA_TCIE                       \ [0x04] Transfer complete interrupt enable
    $05 constant DMA_PFCTRL                     \ [0x05] Peripheral flow controller
    $06 constant DMA_DIR                        \ [0x06 : 2] Data transfer direction
    $08 constant DMA_CIRC                       \ [0x08] Circular mode
    $09 constant DMA_PINC                       \ [0x09] Peripheral increment mode
    $0a constant DMA_MINC                       \ [0x0a] Memory increment mode
    $0b constant DMA_PSIZE                      \ [0x0b : 2] Peripheral data size
    $0d constant DMA_MSIZE                      \ [0x0d : 2] Memory data size
    $0f constant DMA_PINCOS                     \ [0x0f] Peripheral increment offset size
    $10 constant DMA_PL                         \ [0x10 : 2] Priority level
    $12 constant DMA_DBM                        \ [0x12] Double buffer mode
    $13 constant DMA_CT                         \ [0x13] Current target (only in double buffer mode)
    $14 constant DMA_ACK                        \ [0x14] ACK
    $15 constant DMA_PBURST                     \ [0x15 : 2] Peripheral burst transfer configuration
    $17 constant DMA_MBURST                     \ [0x17 : 2] Memory burst transfer configuration
    $19 constant DMA_CHSEL                      \ [0x19 : 4] Channel selection
  [then]


  [ifdef] DMA_S7NDTR_DEF
    \
    \ @brief stream x number of data register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] Number of data items to transfer
  [then]


  [ifdef] DMA_S7PAR_DEF
    \
    \ @brief stream x peripheral address register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PA                         \ [0x00 : 32] Peripheral address
  [then]


  [ifdef] DMA_S7M0AR_DEF
    \
    \ @brief stream x memory 0 address register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] Memory 0 address
  [then]


  [ifdef] DMA_S7M1AR_DEF
    \
    \ @brief stream x memory 1 address register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] Memory 1 address (used in case of Double buffer mode)
  [then]


  [ifdef] DMA_S7FCR_DEF
    \
    \ @brief stream x FIFO control register
    \ Address offset: 0xCC
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FIFO threshold selection
    $02 constant DMA_DMDIS                      \ [0x02] Direct mode disable
    $03 constant DMA_FS                         \ [0x03 : 3] FIFO status
    $07 constant DMA_FEIE                       \ [0x07] FIFO error interrupt enable
  [then]

  \
  \ @brief DMA controller
  \
  $00 constant DMA_LISR                 \ low interrupt status register
  $04 constant DMA_HISR                 \ high interrupt status register
  $08 constant DMA_LIFCR                \ low interrupt flag clear register
  $0C constant DMA_HIFCR                \ high interrupt flag clear register
  $10 constant DMA_S0CR                 \ stream x configuration register
  $14 constant DMA_S0NDTR               \ stream x number of data register
  $18 constant DMA_S0PAR                \ stream x peripheral address register
  $1C constant DMA_S0M0AR               \ stream x memory 0 address register
  $20 constant DMA_S0M1AR               \ stream x memory 1 address register
  $24 constant DMA_S0FCR                \ stream x FIFO control register
  $28 constant DMA_S1CR                 \ stream x configuration register
  $2C constant DMA_S1NDTR               \ stream x number of data register
  $30 constant DMA_S1PAR                \ stream x peripheral address register
  $34 constant DMA_S1M0AR               \ stream x memory 0 address register
  $38 constant DMA_S1M1AR               \ stream x memory 1 address register
  $3C constant DMA_S1FCR                \ stream x FIFO control register
  $40 constant DMA_S2CR                 \ stream x configuration register
  $44 constant DMA_S2NDTR               \ stream x number of data register
  $48 constant DMA_S2PAR                \ stream x peripheral address register
  $4C constant DMA_S2M0AR               \ stream x memory 0 address register
  $50 constant DMA_S2M1AR               \ stream x memory 1 address register
  $54 constant DMA_S2FCR                \ stream x FIFO control register
  $58 constant DMA_S3CR                 \ stream x configuration register
  $5C constant DMA_S3NDTR               \ stream x number of data register
  $60 constant DMA_S3PAR                \ stream x peripheral address register
  $64 constant DMA_S3M0AR               \ stream x memory 0 address register
  $68 constant DMA_S3M1AR               \ stream x memory 1 address register
  $6C constant DMA_S3FCR                \ stream x FIFO control register
  $70 constant DMA_S4CR                 \ stream x configuration register
  $74 constant DMA_S4NDTR               \ stream x number of data register
  $78 constant DMA_S4PAR                \ stream x peripheral address register
  $7C constant DMA_S4M0AR               \ stream x memory 0 address register
  $80 constant DMA_S4M1AR               \ stream x memory 1 address register
  $84 constant DMA_S4FCR                \ stream x FIFO control register
  $88 constant DMA_S5CR                 \ stream x configuration register
  $8C constant DMA_S5NDTR               \ stream x number of data register
  $90 constant DMA_S5PAR                \ stream x peripheral address register
  $94 constant DMA_S5M0AR               \ stream x memory 0 address register
  $98 constant DMA_S5M1AR               \ stream x memory 1 address register
  $9C constant DMA_S5FCR                \ stream x FIFO control register
  $A0 constant DMA_S6CR                 \ stream x configuration register
  $A4 constant DMA_S6NDTR               \ stream x number of data register
  $A8 constant DMA_S6PAR                \ stream x peripheral address register
  $AC constant DMA_S6M0AR               \ stream x memory 0 address register
  $B0 constant DMA_S6M1AR               \ stream x memory 1 address register
  $B4 constant DMA_S6FCR                \ stream x FIFO control register
  $B8 constant DMA_S7CR                 \ stream x configuration register
  $BC constant DMA_S7NDTR               \ stream x number of data register
  $C0 constant DMA_S7PAR                \ stream x peripheral address register
  $C4 constant DMA_S7M0AR               \ stream x memory 0 address register
  $C8 constant DMA_S7M1AR               \ stream x memory 1 address register
  $CC constant DMA_S7FCR                \ stream x FIFO control register

: DMA_DEF ; [then]
