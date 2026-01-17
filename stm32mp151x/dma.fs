\
\ @file dma.fs
\ @brief DMA1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DMA_DEF

  [ifdef] DMA_DMA_LISR_DEF
    \
    \ @brief DMA low interrupt status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DMA_FEIF0                      \ [0x00] FEIF0
    $02 constant DMA_DMEIF0                     \ [0x02] DMEIF0
    $03 constant DMA_TEIF0                      \ [0x03] TEIF0
    $04 constant DMA_HTIF0                      \ [0x04] HTIF0
    $05 constant DMA_TCIF0                      \ [0x05] TCIF0
    $06 constant DMA_FEIF1                      \ [0x06] FEIF1
    $08 constant DMA_DMEIF1                     \ [0x08] DMEIF1
    $09 constant DMA_TEIF1                      \ [0x09] TEIF1
    $0a constant DMA_HTIF1                      \ [0x0a] HTIF1
    $0b constant DMA_TCIF1                      \ [0x0b] TCIF1
    $10 constant DMA_FEIF2                      \ [0x10] FEIF2
    $12 constant DMA_DMEIF2                     \ [0x12] DMEIF2
    $13 constant DMA_TEIF2                      \ [0x13] TEIF2
    $14 constant DMA_HTIF2                      \ [0x14] HTIF2
    $15 constant DMA_TCIF2                      \ [0x15] TCIF2
    $16 constant DMA_FEIF3                      \ [0x16] FEIF3
    $18 constant DMA_DMEIF3                     \ [0x18] DMEIF3
    $19 constant DMA_TEIF3                      \ [0x19] TEIF3
    $1a constant DMA_HTIF3                      \ [0x1a] HTIF3
    $1b constant DMA_TCIF3                      \ [0x1b] TCIF3
  [then]


  [ifdef] DMA_DMA_HISR_DEF
    \
    \ @brief DMA high interrupt status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DMA_FEIF4                      \ [0x00] FEIF4
    $02 constant DMA_DMEIF4                     \ [0x02] DMEIF4
    $03 constant DMA_TEIF4                      \ [0x03] TEIF4
    $04 constant DMA_HTIF4                      \ [0x04] HTIF4
    $05 constant DMA_TCIF4                      \ [0x05] TCIF4
    $06 constant DMA_FEIF5                      \ [0x06] FEIF5
    $08 constant DMA_DMEIF5                     \ [0x08] DMEIF5
    $09 constant DMA_TEIF5                      \ [0x09] TEIF5
    $0a constant DMA_HTIF5                      \ [0x0a] HTIF5
    $0b constant DMA_TCIF5                      \ [0x0b] TCIF5
    $10 constant DMA_FEIF6                      \ [0x10] FEIF6
    $12 constant DMA_DMEIF6                     \ [0x12] DMEIF6
    $13 constant DMA_TEIF6                      \ [0x13] TEIF6
    $14 constant DMA_HTIF6                      \ [0x14] HTIF6
    $15 constant DMA_TCIF6                      \ [0x15] TCIF6
    $16 constant DMA_FEIF7                      \ [0x16] FEIF7
    $18 constant DMA_DMEIF7                     \ [0x18] DMEIF7
    $19 constant DMA_TEIF7                      \ [0x19] TEIF7
    $1a constant DMA_HTIF7                      \ [0x1a] HTIF7
    $1b constant DMA_TCIF7                      \ [0x1b] TCIF7
  [then]


  [ifdef] DMA_DMA_LIFCR_DEF
    \
    \ @brief DMA low interrupt flag clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CFEIF0                     \ [0x00] CFEIF0
    $02 constant DMA_CDMEIF0                    \ [0x02] CDMEIF0
    $03 constant DMA_CTEIF0                     \ [0x03] CTEIF0
    $04 constant DMA_CHTIF0                     \ [0x04] CHTIF0
    $05 constant DMA_CTCIF0                     \ [0x05] CTCIF0
    $06 constant DMA_CFEIF1                     \ [0x06] CFEIF1
    $08 constant DMA_CDMEIF1                    \ [0x08] CDMEIF1
    $09 constant DMA_CTEIF1                     \ [0x09] CTEIF1
    $0a constant DMA_CHTIF1                     \ [0x0a] CHTIF1
    $0b constant DMA_CTCIF1                     \ [0x0b] CTCIF1
    $10 constant DMA_CFEIF2                     \ [0x10] CFEIF2
    $12 constant DMA_CDMEIF2                    \ [0x12] CDMEIF2
    $13 constant DMA_CTEIF2                     \ [0x13] CTEIF2
    $14 constant DMA_CHTIF2                     \ [0x14] CHTIF2
    $15 constant DMA_CTCIF2                     \ [0x15] CTCIF2
    $16 constant DMA_CFEIF3                     \ [0x16] CFEIF3
    $18 constant DMA_CDMEIF3                    \ [0x18] CDMEIF3
    $19 constant DMA_CTEIF3                     \ [0x19] CTEIF3
    $1a constant DMA_CHTIF3                     \ [0x1a] CHTIF3
    $1b constant DMA_CTCIF3                     \ [0x1b] CTCIF3
  [then]


  [ifdef] DMA_DMA_HIFCR_DEF
    \
    \ @brief DMA high interrupt flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_CFEIF4                     \ [0x00] CFEIF4
    $02 constant DMA_CDMEIF4                    \ [0x02] CDMEIF4
    $03 constant DMA_CTEIF4                     \ [0x03] CTEIF4
    $04 constant DMA_CHTIF4                     \ [0x04] CHTIF4
    $05 constant DMA_CTCIF4                     \ [0x05] CTCIF4
    $06 constant DMA_CFEIF5                     \ [0x06] CFEIF5
    $08 constant DMA_CDMEIF5                    \ [0x08] CDMEIF5
    $09 constant DMA_CTEIF5                     \ [0x09] CTEIF5
    $0a constant DMA_CHTIF5                     \ [0x0a] CHTIF5
    $0b constant DMA_CTCIF5                     \ [0x0b] CTCIF5
    $10 constant DMA_CFEIF6                     \ [0x10] CFEIF6
    $12 constant DMA_CDMEIF6                    \ [0x12] CDMEIF6
    $13 constant DMA_CTEIF6                     \ [0x13] CTEIF6
    $14 constant DMA_CHTIF6                     \ [0x14] CHTIF6
    $15 constant DMA_CTCIF6                     \ [0x15] CTCIF6
    $16 constant DMA_CFEIF7                     \ [0x16] CFEIF7
    $18 constant DMA_CDMEIF7                    \ [0x18] CDMEIF7
    $19 constant DMA_CTEIF7                     \ [0x19] CTEIF7
    $1a constant DMA_CHTIF7                     \ [0x1a] CHTIF7
    $1b constant DMA_CTCIF7                     \ [0x1b] CTCIF7
  [then]


  [ifdef] DMA_DMA_S0CR_DEF
    \
    \ @brief This register is used to configure the concerned stream.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN
    $01 constant DMA_DMEIE                      \ [0x01] DMEIE
    $02 constant DMA_TEIE                       \ [0x02] TEIE
    $03 constant DMA_HTIE                       \ [0x03] HTIE
    $04 constant DMA_TCIE                       \ [0x04] TCIE
    $05 constant DMA_PFCTRL                     \ [0x05] PFCTRL
    $06 constant DMA_DIR                        \ [0x06 : 2] DIR
    $08 constant DMA_CIRC                       \ [0x08] CIRC
    $09 constant DMA_PINC                       \ [0x09] PINC
    $0a constant DMA_MINC                       \ [0x0a] MINC
    $0b constant DMA_PSIZE                      \ [0x0b : 2] PSIZE
    $0d constant DMA_MSIZE                      \ [0x0d : 2] MSIZE
    $0f constant DMA_PINCOS                     \ [0x0f] PINCOS
    $10 constant DMA_PL                         \ [0x10 : 2] PL
    $12 constant DMA_DBM                        \ [0x12] DBM
    $13 constant DMA_CT                         \ [0x13] CT
    $15 constant DMA_PBURST                     \ [0x15 : 2] PBURST
    $17 constant DMA_MBURST                     \ [0x17 : 2] MBURST
  [then]


  [ifdef] DMA_DMA_S0NDTR_DEF
    \
    \ @brief DMA stream 0 number of data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT
  [then]


  [ifdef] DMA_DMA_S0PAR_DEF
    \
    \ @brief DMA stream 0 peripheral address register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] PAR
  [then]


  [ifdef] DMA_DMA_S0M0AR_DEF
    \
    \ @brief DMA stream 0 memory 0 address register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] M0A
  [then]


  [ifdef] DMA_DMA_S0M1AR_DEF
    \
    \ @brief DMA stream 0 memory 1 address register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] M1A
  [then]


  [ifdef] DMA_DMA_S0FCR_DEF
    \
    \ @brief DMA stream 0 FIFO control register
    \ Address offset: 0x24
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FTH
    $02 constant DMA_DMDIS                      \ [0x02] DMDIS
    $03 constant DMA_FS                         \ [0x03 : 3] FS
    $07 constant DMA_FEIE                       \ [0x07] FEIE
  [then]


  [ifdef] DMA_DMA_S1CR_DEF
    \
    \ @brief This register is used to configure the concerned stream.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN
    $01 constant DMA_DMEIE                      \ [0x01] DMEIE
    $02 constant DMA_TEIE                       \ [0x02] TEIE
    $03 constant DMA_HTIE                       \ [0x03] HTIE
    $04 constant DMA_TCIE                       \ [0x04] TCIE
    $05 constant DMA_PFCTRL                     \ [0x05] PFCTRL
    $06 constant DMA_DIR                        \ [0x06 : 2] DIR
    $08 constant DMA_CIRC                       \ [0x08] CIRC
    $09 constant DMA_PINC                       \ [0x09] PINC
    $0a constant DMA_MINC                       \ [0x0a] MINC
    $0b constant DMA_PSIZE                      \ [0x0b : 2] PSIZE
    $0d constant DMA_MSIZE                      \ [0x0d : 2] MSIZE
    $0f constant DMA_PINCOS                     \ [0x0f] PINCOS
    $10 constant DMA_PL                         \ [0x10 : 2] PL
    $12 constant DMA_DBM                        \ [0x12] DBM
    $13 constant DMA_CT                         \ [0x13] CT
    $15 constant DMA_PBURST                     \ [0x15 : 2] PBURST
    $17 constant DMA_MBURST                     \ [0x17 : 2] MBURST
  [then]


  [ifdef] DMA_DMA_S1NDTR_DEF
    \
    \ @brief DMA stream 1 number of data register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT
  [then]


  [ifdef] DMA_DMA_S1PAR_DEF
    \
    \ @brief DMA stream 1 peripheral address register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] PAR
  [then]


  [ifdef] DMA_DMA_S1M0AR_DEF
    \
    \ @brief DMA stream 1 memory 0 address register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] M0A
  [then]


  [ifdef] DMA_DMA_S1M1AR_DEF
    \
    \ @brief DMA stream 1 memory 1 address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] M1A
  [then]


  [ifdef] DMA_DMA_S1FCR_DEF
    \
    \ @brief DMA stream 1 FIFO control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FTH
    $02 constant DMA_DMDIS                      \ [0x02] DMDIS
    $03 constant DMA_FS                         \ [0x03 : 3] FS
    $07 constant DMA_FEIE                       \ [0x07] FEIE
  [then]


  [ifdef] DMA_DMA_S2CR_DEF
    \
    \ @brief This register is used to configure the concerned stream.
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN
    $01 constant DMA_DMEIE                      \ [0x01] DMEIE
    $02 constant DMA_TEIE                       \ [0x02] TEIE
    $03 constant DMA_HTIE                       \ [0x03] HTIE
    $04 constant DMA_TCIE                       \ [0x04] TCIE
    $05 constant DMA_PFCTRL                     \ [0x05] PFCTRL
    $06 constant DMA_DIR                        \ [0x06 : 2] DIR
    $08 constant DMA_CIRC                       \ [0x08] CIRC
    $09 constant DMA_PINC                       \ [0x09] PINC
    $0a constant DMA_MINC                       \ [0x0a] MINC
    $0b constant DMA_PSIZE                      \ [0x0b : 2] PSIZE
    $0d constant DMA_MSIZE                      \ [0x0d : 2] MSIZE
    $0f constant DMA_PINCOS                     \ [0x0f] PINCOS
    $10 constant DMA_PL                         \ [0x10 : 2] PL
    $12 constant DMA_DBM                        \ [0x12] DBM
    $13 constant DMA_CT                         \ [0x13] CT
    $15 constant DMA_PBURST                     \ [0x15 : 2] PBURST
    $17 constant DMA_MBURST                     \ [0x17 : 2] MBURST
  [then]


  [ifdef] DMA_DMA_S2NDTR_DEF
    \
    \ @brief DMA stream 2 number of data register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT
  [then]


  [ifdef] DMA_DMA_S2PAR_DEF
    \
    \ @brief DMA stream 2 peripheral address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] PAR
  [then]


  [ifdef] DMA_DMA_S2M0AR_DEF
    \
    \ @brief DMA stream 2 memory 0 address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] M0A
  [then]


  [ifdef] DMA_DMA_S2M1AR_DEF
    \
    \ @brief DMA stream 2 memory 1 address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] M1A
  [then]


  [ifdef] DMA_DMA_S2FCR_DEF
    \
    \ @brief DMA stream 2 FIFO control register
    \ Address offset: 0x54
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FTH
    $02 constant DMA_DMDIS                      \ [0x02] DMDIS
    $03 constant DMA_FS                         \ [0x03 : 3] FS
    $07 constant DMA_FEIE                       \ [0x07] FEIE
  [then]


  [ifdef] DMA_DMA_S3CR_DEF
    \
    \ @brief This register is used to configure the concerned stream.
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN
    $01 constant DMA_DMEIE                      \ [0x01] DMEIE
    $02 constant DMA_TEIE                       \ [0x02] TEIE
    $03 constant DMA_HTIE                       \ [0x03] HTIE
    $04 constant DMA_TCIE                       \ [0x04] TCIE
    $05 constant DMA_PFCTRL                     \ [0x05] PFCTRL
    $06 constant DMA_DIR                        \ [0x06 : 2] DIR
    $08 constant DMA_CIRC                       \ [0x08] CIRC
    $09 constant DMA_PINC                       \ [0x09] PINC
    $0a constant DMA_MINC                       \ [0x0a] MINC
    $0b constant DMA_PSIZE                      \ [0x0b : 2] PSIZE
    $0d constant DMA_MSIZE                      \ [0x0d : 2] MSIZE
    $0f constant DMA_PINCOS                     \ [0x0f] PINCOS
    $10 constant DMA_PL                         \ [0x10 : 2] PL
    $12 constant DMA_DBM                        \ [0x12] DBM
    $13 constant DMA_CT                         \ [0x13] CT
    $15 constant DMA_PBURST                     \ [0x15 : 2] PBURST
    $17 constant DMA_MBURST                     \ [0x17 : 2] MBURST
  [then]


  [ifdef] DMA_DMA_S3NDTR_DEF
    \
    \ @brief DMA stream 3 number of data register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT
  [then]


  [ifdef] DMA_DMA_S3PAR_DEF
    \
    \ @brief DMA stream 3 peripheral address register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] PAR
  [then]


  [ifdef] DMA_DMA_S3M0AR_DEF
    \
    \ @brief DMA stream 3 memory 0 address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] M0A
  [then]


  [ifdef] DMA_DMA_S3M1AR_DEF
    \
    \ @brief DMA stream 3 memory 1 address register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] M1A
  [then]


  [ifdef] DMA_DMA_S3FCR_DEF
    \
    \ @brief DMA stream 3 FIFO control register
    \ Address offset: 0x6C
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FTH
    $02 constant DMA_DMDIS                      \ [0x02] DMDIS
    $03 constant DMA_FS                         \ [0x03 : 3] FS
    $07 constant DMA_FEIE                       \ [0x07] FEIE
  [then]


  [ifdef] DMA_DMA_S4CR_DEF
    \
    \ @brief This register is used to configure the concerned stream.
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN
    $01 constant DMA_DMEIE                      \ [0x01] DMEIE
    $02 constant DMA_TEIE                       \ [0x02] TEIE
    $03 constant DMA_HTIE                       \ [0x03] HTIE
    $04 constant DMA_TCIE                       \ [0x04] TCIE
    $05 constant DMA_PFCTRL                     \ [0x05] PFCTRL
    $06 constant DMA_DIR                        \ [0x06 : 2] DIR
    $08 constant DMA_CIRC                       \ [0x08] CIRC
    $09 constant DMA_PINC                       \ [0x09] PINC
    $0a constant DMA_MINC                       \ [0x0a] MINC
    $0b constant DMA_PSIZE                      \ [0x0b : 2] PSIZE
    $0d constant DMA_MSIZE                      \ [0x0d : 2] MSIZE
    $0f constant DMA_PINCOS                     \ [0x0f] PINCOS
    $10 constant DMA_PL                         \ [0x10 : 2] PL
    $12 constant DMA_DBM                        \ [0x12] DBM
    $13 constant DMA_CT                         \ [0x13] CT
    $15 constant DMA_PBURST                     \ [0x15 : 2] PBURST
    $17 constant DMA_MBURST                     \ [0x17 : 2] MBURST
  [then]


  [ifdef] DMA_DMA_S4NDTR_DEF
    \
    \ @brief DMA stream 4 number of data register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT
  [then]


  [ifdef] DMA_DMA_S4PAR_DEF
    \
    \ @brief DMA stream 4 peripheral address register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] PAR
  [then]


  [ifdef] DMA_DMA_S4M0AR_DEF
    \
    \ @brief DMA stream 4 memory 0 address register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] M0A
  [then]


  [ifdef] DMA_DMA_S4M1AR_DEF
    \
    \ @brief DMA stream 4 memory 1 address register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] M1A
  [then]


  [ifdef] DMA_DMA_S4FCR_DEF
    \
    \ @brief DMA stream 4 FIFO control register
    \ Address offset: 0x84
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FTH
    $02 constant DMA_DMDIS                      \ [0x02] DMDIS
    $03 constant DMA_FS                         \ [0x03 : 3] FS
    $07 constant DMA_FEIE                       \ [0x07] FEIE
  [then]


  [ifdef] DMA_DMA_S5CR_DEF
    \
    \ @brief This register is used to configure the concerned stream.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN
    $01 constant DMA_DMEIE                      \ [0x01] DMEIE
    $02 constant DMA_TEIE                       \ [0x02] TEIE
    $03 constant DMA_HTIE                       \ [0x03] HTIE
    $04 constant DMA_TCIE                       \ [0x04] TCIE
    $05 constant DMA_PFCTRL                     \ [0x05] PFCTRL
    $06 constant DMA_DIR                        \ [0x06 : 2] DIR
    $08 constant DMA_CIRC                       \ [0x08] CIRC
    $09 constant DMA_PINC                       \ [0x09] PINC
    $0a constant DMA_MINC                       \ [0x0a] MINC
    $0b constant DMA_PSIZE                      \ [0x0b : 2] PSIZE
    $0d constant DMA_MSIZE                      \ [0x0d : 2] MSIZE
    $0f constant DMA_PINCOS                     \ [0x0f] PINCOS
    $10 constant DMA_PL                         \ [0x10 : 2] PL
    $12 constant DMA_DBM                        \ [0x12] DBM
    $13 constant DMA_CT                         \ [0x13] CT
    $15 constant DMA_PBURST                     \ [0x15 : 2] PBURST
    $17 constant DMA_MBURST                     \ [0x17 : 2] MBURST
  [then]


  [ifdef] DMA_DMA_S5NDTR_DEF
    \
    \ @brief DMA stream 5 number of data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT
  [then]


  [ifdef] DMA_DMA_S5PAR_DEF
    \
    \ @brief DMA stream 5 peripheral address register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] PAR
  [then]


  [ifdef] DMA_DMA_S5M0AR_DEF
    \
    \ @brief DMA stream 5 memory 0 address register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] M0A
  [then]


  [ifdef] DMA_DMA_S5M1AR_DEF
    \
    \ @brief DMA stream 5 memory 1 address register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] M1A
  [then]


  [ifdef] DMA_DMA_S5FCR_DEF
    \
    \ @brief DMA stream 5 FIFO control register
    \ Address offset: 0x9C
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FTH
    $02 constant DMA_DMDIS                      \ [0x02] DMDIS
    $03 constant DMA_FS                         \ [0x03 : 3] FS
    $07 constant DMA_FEIE                       \ [0x07] FEIE
  [then]


  [ifdef] DMA_DMA_S6CR_DEF
    \
    \ @brief This register is used to configure the concerned stream.
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN
    $01 constant DMA_DMEIE                      \ [0x01] DMEIE
    $02 constant DMA_TEIE                       \ [0x02] TEIE
    $03 constant DMA_HTIE                       \ [0x03] HTIE
    $04 constant DMA_TCIE                       \ [0x04] TCIE
    $05 constant DMA_PFCTRL                     \ [0x05] PFCTRL
    $06 constant DMA_DIR                        \ [0x06 : 2] DIR
    $08 constant DMA_CIRC                       \ [0x08] CIRC
    $09 constant DMA_PINC                       \ [0x09] PINC
    $0a constant DMA_MINC                       \ [0x0a] MINC
    $0b constant DMA_PSIZE                      \ [0x0b : 2] PSIZE
    $0d constant DMA_MSIZE                      \ [0x0d : 2] MSIZE
    $0f constant DMA_PINCOS                     \ [0x0f] PINCOS
    $10 constant DMA_PL                         \ [0x10 : 2] PL
    $12 constant DMA_DBM                        \ [0x12] DBM
    $13 constant DMA_CT                         \ [0x13] CT
    $15 constant DMA_PBURST                     \ [0x15 : 2] PBURST
    $17 constant DMA_MBURST                     \ [0x17 : 2] MBURST
  [then]


  [ifdef] DMA_DMA_S6NDTR_DEF
    \
    \ @brief DMA stream 6 number of data register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT
  [then]


  [ifdef] DMA_DMA_S6PAR_DEF
    \
    \ @brief DMA stream 6 peripheral address register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] PAR
  [then]


  [ifdef] DMA_DMA_S6M0AR_DEF
    \
    \ @brief DMA stream 6 memory 0 address register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] M0A
  [then]


  [ifdef] DMA_DMA_S6M1AR_DEF
    \
    \ @brief DMA stream 6 memory 1 address register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] M1A
  [then]


  [ifdef] DMA_DMA_S6FCR_DEF
    \
    \ @brief DMA stream 6 FIFO control register
    \ Address offset: 0xB4
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FTH
    $02 constant DMA_DMDIS                      \ [0x02] DMDIS
    $03 constant DMA_FS                         \ [0x03 : 3] FS
    $07 constant DMA_FEIE                       \ [0x07] FEIE
  [then]


  [ifdef] DMA_DMA_S7CR_DEF
    \
    \ @brief This register is used to configure the concerned stream.
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_EN                         \ [0x00] EN
    $01 constant DMA_DMEIE                      \ [0x01] DMEIE
    $02 constant DMA_TEIE                       \ [0x02] TEIE
    $03 constant DMA_HTIE                       \ [0x03] HTIE
    $04 constant DMA_TCIE                       \ [0x04] TCIE
    $05 constant DMA_PFCTRL                     \ [0x05] PFCTRL
    $06 constant DMA_DIR                        \ [0x06 : 2] DIR
    $08 constant DMA_CIRC                       \ [0x08] CIRC
    $09 constant DMA_PINC                       \ [0x09] PINC
    $0a constant DMA_MINC                       \ [0x0a] MINC
    $0b constant DMA_PSIZE                      \ [0x0b : 2] PSIZE
    $0d constant DMA_MSIZE                      \ [0x0d : 2] MSIZE
    $0f constant DMA_PINCOS                     \ [0x0f] PINCOS
    $10 constant DMA_PL                         \ [0x10 : 2] PL
    $12 constant DMA_DBM                        \ [0x12] DBM
    $13 constant DMA_CT                         \ [0x13] CT
    $15 constant DMA_PBURST                     \ [0x15 : 2] PBURST
    $17 constant DMA_MBURST                     \ [0x17 : 2] MBURST
  [then]


  [ifdef] DMA_DMA_S7NDTR_DEF
    \
    \ @brief DMA stream 7 number of data register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant DMA_NDT                        \ [0x00 : 16] NDT
  [then]


  [ifdef] DMA_DMA_S7PAR_DEF
    \
    \ @brief DMA stream 7 peripheral address register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DMA_PAR                        \ [0x00 : 32] PAR
  [then]


  [ifdef] DMA_DMA_S7M0AR_DEF
    \
    \ @brief DMA stream 7 memory 0 address register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M0A                        \ [0x00 : 32] M0A
  [then]


  [ifdef] DMA_DMA_S7M1AR_DEF
    \
    \ @brief DMA stream 7 memory 1 address register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DMA_M1A                        \ [0x00 : 32] M1A
  [then]


  [ifdef] DMA_DMA_S7FCR_DEF
    \
    \ @brief DMA stream 7 FIFO control register
    \ Address offset: 0xCC
    \ Reset value: 0x00000021
    \
    $00 constant DMA_FTH                        \ [0x00 : 2] FTH
    $02 constant DMA_DMDIS                      \ [0x02] DMDIS
    $03 constant DMA_FS                         \ [0x03 : 3] FS
    $07 constant DMA_FEIE                       \ [0x07] FEIE
  [then]


  [ifdef] DMA_DMA_HWCFGR2_DEF
    \
    \ @brief DMA hardware configuration 2register
    \ Address offset: 0x3EC
    \ Reset value: 0x00000001
    \
    $00 constant DMA_FIFO_SIZE                  \ [0x00 : 2] FIFO_SIZE
    $04 constant DMA_WRITE_BUFFERABLE           \ [0x04] WRITE_BUFFERABLE
    $08 constant DMA_CHSEL_WIDTH                \ [0x08 : 3] CHSEL_WIDTH
  [then]


  [ifdef] DMA_DMA_HWCFGR1_DEF
    \
    \ @brief DMA hardware configuration 1 register
    \ Address offset: 0x3F0
    \ Reset value: 0x22222222
    \
    $00 constant DMA_DMA_DEF0                   \ [0x00 : 2] DMA_DEF0
    $04 constant DMA_DMA_DEF1                   \ [0x04 : 2] DMA_DEF1
    $08 constant DMA_DMA_DEF2                   \ [0x08 : 2] DMA_DEF2
    $0c constant DMA_DMA_DEF3                   \ [0x0c : 2] DMA_DEF3
    $10 constant DMA_DMA_DEF4                   \ [0x10 : 2] DMA_DEF4
    $14 constant DMA_DMA_DEF5                   \ [0x14 : 2] DMA_DEF5
    $18 constant DMA_DMA_DEF6                   \ [0x18 : 2] DMA_DEF6
    $1c constant DMA_DMA_DEF7                   \ [0x1c : 2] DMA_DEF7
  [then]


  [ifdef] DMA_DMA_VERR_DEF
    \
    \ @brief This register identifies the version of the IP.
    \ Address offset: 0x3F4
    \ Reset value: 0x00000014
    \
    $00 constant DMA_MINREV                     \ [0x00 : 4] MINREV
    $04 constant DMA_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] DMA_DMA_IPDR_DEF
    \
    \ @brief DMA IP identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00100002
    \
    $00 constant DMA_ID                         \ [0x00 : 32] ID
  [then]


  [ifdef] DMA_DMA_SIDR_DEF
    \
    \ @brief DMA size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant DMA_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief DMA1
  \
  $00 constant DMA_DMA_LISR             \ DMA low interrupt status register
  $04 constant DMA_DMA_HISR             \ DMA high interrupt status register
  $08 constant DMA_DMA_LIFCR            \ DMA low interrupt flag clear register
  $0C constant DMA_DMA_HIFCR            \ DMA high interrupt flag clear register
  $10 constant DMA_DMA_S0CR             \ This register is used to configure the concerned stream.
  $14 constant DMA_DMA_S0NDTR           \ DMA stream 0 number of data register
  $18 constant DMA_DMA_S0PAR            \ DMA stream 0 peripheral address register
  $1C constant DMA_DMA_S0M0AR           \ DMA stream 0 memory 0 address register
  $20 constant DMA_DMA_S0M1AR           \ DMA stream 0 memory 1 address register
  $24 constant DMA_DMA_S0FCR            \ DMA stream 0 FIFO control register
  $28 constant DMA_DMA_S1CR             \ This register is used to configure the concerned stream.
  $2C constant DMA_DMA_S1NDTR           \ DMA stream 1 number of data register
  $30 constant DMA_DMA_S1PAR            \ DMA stream 1 peripheral address register
  $34 constant DMA_DMA_S1M0AR           \ DMA stream 1 memory 0 address register
  $38 constant DMA_DMA_S1M1AR           \ DMA stream 1 memory 1 address register
  $3C constant DMA_DMA_S1FCR            \ DMA stream 1 FIFO control register
  $40 constant DMA_DMA_S2CR             \ This register is used to configure the concerned stream.
  $44 constant DMA_DMA_S2NDTR           \ DMA stream 2 number of data register
  $48 constant DMA_DMA_S2PAR            \ DMA stream 2 peripheral address register
  $4C constant DMA_DMA_S2M0AR           \ DMA stream 2 memory 0 address register
  $50 constant DMA_DMA_S2M1AR           \ DMA stream 2 memory 1 address register
  $54 constant DMA_DMA_S2FCR            \ DMA stream 2 FIFO control register
  $58 constant DMA_DMA_S3CR             \ This register is used to configure the concerned stream.
  $5C constant DMA_DMA_S3NDTR           \ DMA stream 3 number of data register
  $60 constant DMA_DMA_S3PAR            \ DMA stream 3 peripheral address register
  $64 constant DMA_DMA_S3M0AR           \ DMA stream 3 memory 0 address register
  $68 constant DMA_DMA_S3M1AR           \ DMA stream 3 memory 1 address register
  $6C constant DMA_DMA_S3FCR            \ DMA stream 3 FIFO control register
  $70 constant DMA_DMA_S4CR             \ This register is used to configure the concerned stream.
  $74 constant DMA_DMA_S4NDTR           \ DMA stream 4 number of data register
  $78 constant DMA_DMA_S4PAR            \ DMA stream 4 peripheral address register
  $7C constant DMA_DMA_S4M0AR           \ DMA stream 4 memory 0 address register
  $80 constant DMA_DMA_S4M1AR           \ DMA stream 4 memory 1 address register
  $84 constant DMA_DMA_S4FCR            \ DMA stream 4 FIFO control register
  $88 constant DMA_DMA_S5CR             \ This register is used to configure the concerned stream.
  $8C constant DMA_DMA_S5NDTR           \ DMA stream 5 number of data register
  $90 constant DMA_DMA_S5PAR            \ DMA stream 5 peripheral address register
  $94 constant DMA_DMA_S5M0AR           \ DMA stream 5 memory 0 address register
  $98 constant DMA_DMA_S5M1AR           \ DMA stream 5 memory 1 address register
  $9C constant DMA_DMA_S5FCR            \ DMA stream 5 FIFO control register
  $A0 constant DMA_DMA_S6CR             \ This register is used to configure the concerned stream.
  $A4 constant DMA_DMA_S6NDTR           \ DMA stream 6 number of data register
  $A8 constant DMA_DMA_S6PAR            \ DMA stream 6 peripheral address register
  $AC constant DMA_DMA_S6M0AR           \ DMA stream 6 memory 0 address register
  $B0 constant DMA_DMA_S6M1AR           \ DMA stream 6 memory 1 address register
  $B4 constant DMA_DMA_S6FCR            \ DMA stream 6 FIFO control register
  $B8 constant DMA_DMA_S7CR             \ This register is used to configure the concerned stream.
  $BC constant DMA_DMA_S7NDTR           \ DMA stream 7 number of data register
  $C0 constant DMA_DMA_S7PAR            \ DMA stream 7 peripheral address register
  $C4 constant DMA_DMA_S7M0AR           \ DMA stream 7 memory 0 address register
  $C8 constant DMA_DMA_S7M1AR           \ DMA stream 7 memory 1 address register
  $CC constant DMA_DMA_S7FCR            \ DMA stream 7 FIFO control register
  $3EC constant DMA_DMA_HWCFGR2         \ DMA hardware configuration 2register
  $3F0 constant DMA_DMA_HWCFGR1         \ DMA hardware configuration 1 register
  $3F4 constant DMA_DMA_VERR            \ This register identifies the version of the IP.
  $3F8 constant DMA_DMA_IPDR            \ DMA IP identification register
  $3FC constant DMA_DMA_SIDR            \ DMA size identification register

: DMA_DEF ; [then]
