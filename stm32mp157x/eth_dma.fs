\
\ @file eth_dma.fs
\ @brief ETH_DMA
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETH_DMA_DEF

  [ifdef] ETH_DMA_ETH_DMAMR_DEF
    \
    \ @brief DMA mode register
    \ Address offset: 0x00
    \ Reset value: 0x00008000
    \
    $00 constant ETH_DMA_SWR                    \ [0x00] Software Reset
    $02 constant ETH_DMA_TAA                    \ [0x02 : 3] TAA
    $0b constant ETH_DMA_TXPR                   \ [0x0b] Transmit priority
    $0c constant ETH_DMA_PR                     \ [0x0c : 3] Priority ratio
    $10 constant ETH_DMA_INTM                   \ [0x10 : 2] Interrupt Mode
  [then]


  [ifdef] ETH_DMA_ETH_DMASBMR_DEF
    \
    \ @brief System bus mode register
    \ Address offset: 0x04
    \ Reset value: 0x00008000
    \
    $00 constant ETH_DMA_FB                     \ [0x00] Fixed Burst Length
    $01 constant ETH_DMA_BLEN4                  \ [0x01] BLEN4
    $02 constant ETH_DMA_BLEN8                  \ [0x02] BLEN8
    $03 constant ETH_DMA_BLEN16                 \ [0x03] BLEN16
    $04 constant ETH_DMA_BLEN32                 \ [0x04] BLEN32
    $05 constant ETH_DMA_BLEN64                 \ [0x05] BLEN64
    $06 constant ETH_DMA_BLEN128                \ [0x06] BLEN128
    $07 constant ETH_DMA_BLEN256                \ [0x07] BLEN256
    $0c constant ETH_DMA_AAL                    \ [0x0c] Address-Aligned Beats
    $0d constant ETH_DMA_ONEKBBE                \ [0x0d] ONEKBBE
    $10 constant ETH_DMA_RD_OSR_LMT             \ [0x10 : 2] RD_OSR_LMT
    $18 constant ETH_DMA_WR_OSR_LMT             \ [0x18 : 2] WR_OSR_LMT
    $1e constant ETH_DMA_LPI_XIT_PKT            \ [0x1e] LPI_XIT_PKT
    $1f constant ETH_DMA_EN_LPI                 \ [0x1f] EN_LPI
  [then]


  [ifdef] ETH_DMA_ETH_DMAISR_DEF
    \
    \ @brief Interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00008000
    \
    $00 constant ETH_DMA_DC0IS                  \ [0x00] DMA Channel Interrupt Status
    $01 constant ETH_DMA_DC1IS                  \ [0x01] DC1IS
    $10 constant ETH_DMA_MTLIS                  \ [0x10] MTL Interrupt Status
    $11 constant ETH_DMA_MACIS                  \ [0x11] MAC Interrupt Status
  [then]


  [ifdef] ETH_DMA_ETH_DMADSR_DEF
    \
    \ @brief Debug status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_AXWHSTS                \ [0x00] AHB Master Write Channel
    $01 constant ETH_DMA_AXRHSTS                \ [0x01] AXRHSTS
    $08 constant ETH_DMA_RPS0                   \ [0x08 : 4] RPS0
    $0c constant ETH_DMA_TPS0                   \ [0x0c : 4] TPS0
    $10 constant ETH_DMA_RPS1                   \ [0x10 : 4] RPS1
    $14 constant ETH_DMA_TPS1                   \ [0x14 : 4] TPS1
  [then]


  [ifdef] ETH_DMA_ETH_DMAA4TxACR_DEF
    \
    \ @brief AXI4 transmit channel ACE control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_TDRC                   \ [0x00 : 4] TDRC
    $08 constant ETH_DMA_TEC                    \ [0x08 : 4] TEC
    $10 constant ETH_DMA_THC                    \ [0x10 : 4] THC
  [then]


  [ifdef] ETH_DMA_ETH_DMAA4RxACR_DEF
    \
    \ @brief AXI4 receive channel ACE control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_RDWC                   \ [0x00 : 4] RDWC
    $08 constant ETH_DMA_RPC                    \ [0x08 : 4] RPC
    $10 constant ETH_DMA_RHC                    \ [0x10 : 4] RHC
    $18 constant ETH_DMA_RDC                    \ [0x18 : 2] RDC
  [then]


  [ifdef] ETH_DMA_ETH_DMAA4DACR_DEF
    \
    \ @brief AXI4 descriptor ACE control register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_TDWC                   \ [0x00 : 4] TDWC
    $04 constant ETH_DMA_TDWD                   \ [0x04 : 2] TDWD
    $08 constant ETH_DMA_RDRC                   \ [0x08 : 4] RDRC
    $10 constant ETH_DMA_RDP                    \ [0x10 : 3] RDP
    $14 constant ETH_DMA_WRP                    \ [0x14 : 3] WRP
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0CR_DEF
    \
    \ @brief Channel 0 control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_MSS                    \ [0x00 : 14] MSS
    $10 constant ETH_DMA_PBLX8                  \ [0x10] PBLX8
    $12 constant ETH_DMA_DSL                    \ [0x12 : 3] DSL
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0TxCR_DEF
    \
    \ @brief Channel 0 transmit control register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_ST                     \ [0x00] ST
    $01 constant ETH_DMA_TCW                    \ [0x01 : 3] TCW
    $04 constant ETH_DMA_OSF                    \ [0x04] OSF
    $0c constant ETH_DMA_TSE                    \ [0x0c] TSE
    $10 constant ETH_DMA_TXPBL                  \ [0x10 : 6] TXPBL
    $18 constant ETH_DMA_TQOS                   \ [0x18 : 4] TQOS
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0RxCR_DEF
    \
    \ @brief Channel receive control register
    \ Address offset: 0x108
    \ Reset value: 0x00008000
    \
    $00 constant ETH_DMA_SR                     \ [0x00] Start or Stop Receive Command
    $01 constant ETH_DMA_RBSZ                   \ [0x01 : 14] Receive Buffer size
    $10 constant ETH_DMA_RXPBL                  \ [0x10 : 6] RXPBL
    $18 constant ETH_DMA_RQOS                   \ [0x18 : 4] RQOS
    $1f constant ETH_DMA_RPF                    \ [0x1f] DMA Rx Channel Packet Flush
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0TxDLAR_DEF
    \
    \ @brief Channel i Tx descriptor list address register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $03 constant ETH_DMA_TDESLA                 \ [0x03 : 29] Start of Transmit List
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0RxDLAR_DEF
    \
    \ @brief Channel Rx descriptor list address register
    \ Address offset: 0x11C
    \ Reset value: 0x00008000
    \
    $03 constant ETH_DMA_RDESLA                 \ [0x03 : 29] Start of Receive List
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0TxDTPR_DEF
    \
    \ @brief Channel Tx descriptor tail pointer register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $03 constant ETH_DMA_TDT                    \ [0x03 : 29] Transmit Descriptor Tail Pointer
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0RxDTPR_DEF
    \
    \ @brief Channel Rx descriptor tail pointer register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $03 constant ETH_DMA_RDT                    \ [0x03 : 29] Receive Descriptor Tail Pointer
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0TxRLR_DEF
    \
    \ @brief Channel Tx descriptor ring length register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_TDRL                   \ [0x00 : 10] Transmit Descriptor Ring Length
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0RxRLR_DEF
    \
    \ @brief Channel Rx descriptor ring length register
    \ Address offset: 0x130
    \ Reset value: 0x00008000
    \
    $00 constant ETH_DMA_RDRL                   \ [0x00 : 10] Receive Descriptor Ring Length
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0IER_DEF
    \
    \ @brief Channel interrupt enable register
    \ Address offset: 0x134
    \ Reset value: 0x00008000
    \
    $00 constant ETH_DMA_TIE                    \ [0x00] Transmit Interrupt Enable
    $01 constant ETH_DMA_TXSE                   \ [0x01] Transmit Stopped Enable
    $02 constant ETH_DMA_TBUE                   \ [0x02] Transmit Buffer Unavailable Enable
    $06 constant ETH_DMA_RIE                    \ [0x06] Receive Interrupt Enable
    $07 constant ETH_DMA_RBUE                   \ [0x07] Receive Buffer Unavailable Enable
    $08 constant ETH_DMA_RSE                    \ [0x08] Receive Stopped Enable
    $09 constant ETH_DMA_RWTE                   \ [0x09] Receive Watchdog Timeout Enable
    $0a constant ETH_DMA_ETIE                   \ [0x0a] Early Transmit Interrupt Enable
    $0b constant ETH_DMA_ERIE                   \ [0x0b] Early Receive Interrupt Enable
    $0c constant ETH_DMA_FBEE                   \ [0x0c] Fatal Bus Error Enable
    $0d constant ETH_DMA_CDEE                   \ [0x0d] Context Descriptor Error Enable
    $0e constant ETH_DMA_AIE                    \ [0x0e] Abnormal Interrupt Summary Enable
    $0f constant ETH_DMA_NIE                    \ [0x0f] Normal Interrupt Summary Enable
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0RxIWTR_DEF
    \
    \ @brief Channel Rx interrupt watchdog timer register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_RWT                    \ [0x00 : 8] Receive Interrupt Watchdog Timer Count
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0SFCSR_DEF
    \
    \ @brief Channel i slot function control status register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_ESC                    \ [0x00] ESC
    $01 constant ETH_DMA_ASC                    \ [0x01] ASC
    $10 constant ETH_DMA_RSN                    \ [0x10 : 4] RSN
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0CATxDR_DEF
    \
    \ @brief Channel current application transmit descriptor register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_CURTDESAPTR            \ [0x00 : 32] Application Transmit Descriptor Address Pointer
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0CARxDR_DEF
    \
    \ @brief Channel 0 current application receive descriptor register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_CURRDESAPTR            \ [0x00 : 32] Application Transmit Descriptor Address Pointer
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0CATxBR_DEF
    \
    \ @brief Channel 0 current application transmit buffer register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_CURTBUFAPTR            \ [0x00 : 32] Application Transmit Buffer Address Pointer
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0CARxBR_DEF
    \
    \ @brief Channel current application receive buffer register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_CURRBUFAPTR            \ [0x00 : 32] Application Receive Buffer Address Pointer
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0SR_DEF
    \
    \ @brief Channel status register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_TI                     \ [0x00] Transmit Interrupt
    $01 constant ETH_DMA_TPS                    \ [0x01] Transmit Process Stopped
    $02 constant ETH_DMA_TBU                    \ [0x02] Transmit Buffer Unavailable
    $06 constant ETH_DMA_RI                     \ [0x06] Receive Interrupt
    $07 constant ETH_DMA_RBU                    \ [0x07] Receive Buffer Unavailable
    $08 constant ETH_DMA_RPS                    \ [0x08] Receive Process Stopped
    $09 constant ETH_DMA_RWT                    \ [0x09] Receive Watchdog Timeout
    $0a constant ETH_DMA_ETI                    \ [0x0a] Early Transmit Interrupt
    $0b constant ETH_DMA_ERI                    \ [0x0b] Early Receive Interrupt
    $0c constant ETH_DMA_FBE                    \ [0x0c] Fatal Bus Error
    $0d constant ETH_DMA_CDE                    \ [0x0d] Context Descriptor Error
    $0e constant ETH_DMA_AIS                    \ [0x0e] Abnormal Interrupt Summary
    $0f constant ETH_DMA_NIS                    \ [0x0f] Normal Interrupt Summary
    $10 constant ETH_DMA_TEB                    \ [0x10 : 3] Tx DMA Error Bits
    $13 constant ETH_DMA_REB                    \ [0x13 : 3] Rx DMA Error Bits
  [then]


  [ifdef] ETH_DMA_ETH_DMAC0MFCR_DEF
    \
    \ @brief Channel missed frame count register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_MFC                    \ [0x00 : 11] Dropped Packet Counters
    $0f constant ETH_DMA_MFCO                   \ [0x0f] Overflow status of the MFC Counter
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1CR_DEF
    \
    \ @brief Channel 1 control register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_MSS                    \ [0x00 : 14] MSS
    $10 constant ETH_DMA_PBLX8                  \ [0x10] PBLX8
    $12 constant ETH_DMA_DSL                    \ [0x12 : 3] DSL
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1TxCR_DEF
    \
    \ @brief Channel 1 transmit control register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_ST                     \ [0x00] ST
    $01 constant ETH_DMA_TCW                    \ [0x01 : 3] TCW
    $04 constant ETH_DMA_OSF                    \ [0x04] OSF
    $0c constant ETH_DMA_TSE                    \ [0x0c] TSE
    $10 constant ETH_DMA_TXPBL                  \ [0x10 : 6] TXPBL
    $18 constant ETH_DMA_TQOS                   \ [0x18 : 4] TQOS
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1TxDLAR_DEF
    \
    \ @brief Channel i Tx descriptor list address register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $03 constant ETH_DMA_TDESLA                 \ [0x03 : 29] Start of Transmit List
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1TxDTPR_DEF
    \
    \ @brief Channel Tx descriptor tail pointer register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $03 constant ETH_DMA_TDT                    \ [0x03 : 29] Transmit Descriptor Tail Pointer
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1TxRLR_DEF
    \
    \ @brief Channel Tx descriptor ring length register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_TDRL                   \ [0x00 : 10] Transmit Descriptor Ring Length
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1IER_DEF
    \
    \ @brief Channel interrupt enable register
    \ Address offset: 0x1B4
    \ Reset value: 0x00008000
    \
    $00 constant ETH_DMA_TIE                    \ [0x00] Transmit Interrupt Enable
    $01 constant ETH_DMA_TXSE                   \ [0x01] Transmit Stopped Enable
    $02 constant ETH_DMA_TBUE                   \ [0x02] Transmit Buffer Unavailable Enable
    $06 constant ETH_DMA_RIE                    \ [0x06] Receive Interrupt Enable
    $07 constant ETH_DMA_RBUE                   \ [0x07] Receive Buffer Unavailable Enable
    $08 constant ETH_DMA_RSE                    \ [0x08] Receive Stopped Enable
    $09 constant ETH_DMA_RWTE                   \ [0x09] Receive Watchdog Timeout Enable
    $0a constant ETH_DMA_ETIE                   \ [0x0a] Early Transmit Interrupt Enable
    $0b constant ETH_DMA_ERIE                   \ [0x0b] Early Receive Interrupt Enable
    $0c constant ETH_DMA_FBEE                   \ [0x0c] Fatal Bus Error Enable
    $0d constant ETH_DMA_CDEE                   \ [0x0d] Context Descriptor Error Enable
    $0e constant ETH_DMA_AIE                    \ [0x0e] Abnormal Interrupt Summary Enable
    $0f constant ETH_DMA_NIE                    \ [0x0f] Normal Interrupt Summary Enable
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1SFCSR_DEF
    \
    \ @brief Channel i slot function control status register
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_ESC                    \ [0x00] ESC
    $01 constant ETH_DMA_ASC                    \ [0x01] ASC
    $10 constant ETH_DMA_RSN                    \ [0x10 : 4] RSN
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1CATxDR_DEF
    \
    \ @brief Channel current application transmit descriptor register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_CURTDESAPTR            \ [0x00 : 32] Application Transmit Descriptor Address Pointer
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1CATxBR_DEF
    \
    \ @brief Channel 0 current application transmit buffer register
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_CURTBUFAPTR            \ [0x00 : 32] Application Transmit Buffer Address Pointer
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1SR_DEF
    \
    \ @brief Channel status register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_TI                     \ [0x00] Transmit Interrupt
    $01 constant ETH_DMA_TPS                    \ [0x01] Transmit Process Stopped
    $02 constant ETH_DMA_TBU                    \ [0x02] Transmit Buffer Unavailable
    $06 constant ETH_DMA_RI                     \ [0x06] Receive Interrupt
    $07 constant ETH_DMA_RBU                    \ [0x07] Receive Buffer Unavailable
    $08 constant ETH_DMA_RPS                    \ [0x08] Receive Process Stopped
    $09 constant ETH_DMA_RWT                    \ [0x09] Receive Watchdog Timeout
    $0a constant ETH_DMA_ETI                    \ [0x0a] Early Transmit Interrupt
    $0b constant ETH_DMA_ERI                    \ [0x0b] Early Receive Interrupt
    $0c constant ETH_DMA_FBE                    \ [0x0c] Fatal Bus Error
    $0d constant ETH_DMA_CDE                    \ [0x0d] Context Descriptor Error
    $0e constant ETH_DMA_AIS                    \ [0x0e] Abnormal Interrupt Summary
    $0f constant ETH_DMA_NIS                    \ [0x0f] Normal Interrupt Summary
    $10 constant ETH_DMA_TEB                    \ [0x10 : 3] Tx DMA Error Bits
    $13 constant ETH_DMA_REB                    \ [0x13 : 3] Rx DMA Error Bits
  [then]


  [ifdef] ETH_DMA_ETH_DMAC1MFCR_DEF
    \
    \ @brief Channel missed frame count register
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DMA_MFC                    \ [0x00 : 11] Dropped Packet Counters
    $0f constant ETH_DMA_MFCO                   \ [0x0f] Overflow status of the MFC Counter
  [then]

  \
  \ @brief ETH_DMA
  \
  $00 constant ETH_DMA_ETH_DMAMR        \ DMA mode register
  $04 constant ETH_DMA_ETH_DMASBMR      \ System bus mode register
  $08 constant ETH_DMA_ETH_DMAISR       \ Interrupt status register
  $0C constant ETH_DMA_ETH_DMADSR       \ Debug status register
  $20 constant ETH_DMA_ETH_DMAA4TXACR   \ AXI4 transmit channel ACE control register
  $24 constant ETH_DMA_ETH_DMAA4RXACR   \ AXI4 receive channel ACE control register
  $28 constant ETH_DMA_ETH_DMAA4DACR    \ AXI4 descriptor ACE control register
  $100 constant ETH_DMA_ETH_DMAC0CR     \ Channel 0 control register
  $104 constant ETH_DMA_ETH_DMAC0TXCR   \ Channel 0 transmit control register
  $108 constant ETH_DMA_ETH_DMAC0RXCR   \ Channel receive control register
  $114 constant ETH_DMA_ETH_DMAC0TXDLAR \ Channel i Tx descriptor list address register
  $11C constant ETH_DMA_ETH_DMAC0RXDLAR \ Channel Rx descriptor list address register
  $120 constant ETH_DMA_ETH_DMAC0TXDTPR \ Channel Tx descriptor tail pointer register
  $128 constant ETH_DMA_ETH_DMAC0RXDTPR \ Channel Rx descriptor tail pointer register
  $12C constant ETH_DMA_ETH_DMAC0TXRLR  \ Channel Tx descriptor ring length register
  $130 constant ETH_DMA_ETH_DMAC0RXRLR  \ Channel Rx descriptor ring length register
  $134 constant ETH_DMA_ETH_DMAC0IER    \ Channel interrupt enable register
  $138 constant ETH_DMA_ETH_DMAC0RXIWTR \ Channel Rx interrupt watchdog timer register
  $13C constant ETH_DMA_ETH_DMAC0SFCSR  \ Channel i slot function control status register
  $144 constant ETH_DMA_ETH_DMAC0CATXDR \ Channel current application transmit descriptor register
  $14C constant ETH_DMA_ETH_DMAC0CARXDR \ Channel 0 current application receive descriptor register
  $154 constant ETH_DMA_ETH_DMAC0CATXBR \ Channel 0 current application transmit buffer register
  $15C constant ETH_DMA_ETH_DMAC0CARXBR \ Channel current application receive buffer register
  $160 constant ETH_DMA_ETH_DMAC0SR     \ Channel status register
  $16C constant ETH_DMA_ETH_DMAC0MFCR   \ Channel missed frame count register
  $180 constant ETH_DMA_ETH_DMAC1CR     \ Channel 1 control register
  $184 constant ETH_DMA_ETH_DMAC1TXCR   \ Channel 1 transmit control register
  $194 constant ETH_DMA_ETH_DMAC1TXDLAR \ Channel i Tx descriptor list address register
  $1A0 constant ETH_DMA_ETH_DMAC1TXDTPR \ Channel Tx descriptor tail pointer register
  $1AC constant ETH_DMA_ETH_DMAC1TXRLR  \ Channel Tx descriptor ring length register
  $1B4 constant ETH_DMA_ETH_DMAC1IER    \ Channel interrupt enable register
  $1BC constant ETH_DMA_ETH_DMAC1SFCSR  \ Channel i slot function control status register
  $1C4 constant ETH_DMA_ETH_DMAC1CATXDR \ Channel current application transmit descriptor register
  $1D4 constant ETH_DMA_ETH_DMAC1CATXBR \ Channel 0 current application transmit buffer register
  $1E0 constant ETH_DMA_ETH_DMAC1SR     \ Channel status register
  $1EC constant ETH_DMA_ETH_DMAC1MFCR   \ Channel missed frame count register

: ETH_DMA_DEF ; [then]
