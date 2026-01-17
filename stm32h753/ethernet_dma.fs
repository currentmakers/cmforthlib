\
\ @file ethernet_dma.fs
\ @brief Ethernet: DMA mode register (DMA)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETHERNET_DMA_DEF

  [ifdef] ETHERNET_DMA_DMAMR_DEF
    \
    \ @brief DMA mode register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_SWR               \ [0x00] Software Reset
    $01 constant ETHERNET_DMA_DA                \ [0x01] DMA Tx or Rx Arbitration Scheme
    $0b constant ETHERNET_DMA_TXPR              \ [0x0b] Transmit priority
    $0c constant ETHERNET_DMA_PR                \ [0x0c : 3] Priority ratio
    $10 constant ETHERNET_DMA_INTM              \ [0x10] Interrupt Mode
  [then]


  [ifdef] ETHERNET_DMA_DMASBMR_DEF
    \
    \ @brief System bus mode register
    \ Address offset: 0x04
    \ Reset value: 0x01010000
    \
    $00 constant ETHERNET_DMA_FB                \ [0x00] Fixed Burst Length
    $0c constant ETHERNET_DMA_AAL               \ [0x0c] Address-Aligned Beats
    $0e constant ETHERNET_DMA_MB                \ [0x0e] Mixed Burst
    $0f constant ETHERNET_DMA_RB                \ [0x0f] Rebuild INCRx Burst
  [then]


  [ifdef] ETHERNET_DMA_DMAISR_DEF
    \
    \ @brief Interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_DC0IS             \ [0x00] DMA Channel Interrupt Status
    $10 constant ETHERNET_DMA_MTLIS             \ [0x10] MTL Interrupt Status
    $11 constant ETHERNET_DMA_MACIS             \ [0x11] MAC Interrupt Status
  [then]


  [ifdef] ETHERNET_DMA_DMADSR_DEF
    \
    \ @brief Debug status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_AXWHSTS           \ [0x00] AHB Master Write Channel
    $08 constant ETHERNET_DMA_RPS0              \ [0x08 : 4] DMA Channel Receive Process State
    $0c constant ETHERNET_DMA_TPS0              \ [0x0c : 4] DMA Channel Transmit Process State
  [then]


  [ifdef] ETHERNET_DMA_DMACCR_DEF
    \
    \ @brief Channel control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_MSS               \ [0x00 : 14] Maximum Segment Size
    $10 constant ETHERNET_DMA_PBLX8             \ [0x10] 8xPBL mode
    $12 constant ETHERNET_DMA_DSL               \ [0x12 : 3] Descriptor Skip Length
  [then]


  [ifdef] ETHERNET_DMA_DMACTxCR_DEF
    \
    \ @brief Channel transmit control register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_ST                \ [0x00] Start or Stop Transmission Command
    $04 constant ETHERNET_DMA_OSF               \ [0x04] Operate on Second Packet
    $0c constant ETHERNET_DMA_TSE               \ [0x0c] TCP Segmentation Enabled
    $10 constant ETHERNET_DMA_TXPBL             \ [0x10 : 6] Transmit Programmable Burst Length
  [then]


  [ifdef] ETHERNET_DMA_DMACRxCR_DEF
    \
    \ @brief Channel receive control register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_SR                \ [0x00] Start or Stop Receive Command
    $01 constant ETHERNET_DMA_RBSZ              \ [0x01 : 14] Receive Buffer size
    $10 constant ETHERNET_DMA_RXPBL             \ [0x10 : 6] RXPBL
    $1f constant ETHERNET_DMA_RPF               \ [0x1f] DMA Rx Channel Packet Flush
  [then]


  [ifdef] ETHERNET_DMA_DMACTxDLAR_DEF
    \
    \ @brief Channel Tx descriptor list address register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $02 constant ETHERNET_DMA_TDESLA            \ [0x02 : 30] Start of Transmit List
  [then]


  [ifdef] ETHERNET_DMA_DMACRxDLAR_DEF
    \
    \ @brief Channel Rx descriptor list address register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $02 constant ETHERNET_DMA_RDESLA            \ [0x02 : 30] Start of Receive List
  [then]


  [ifdef] ETHERNET_DMA_DMACTxDTPR_DEF
    \
    \ @brief Channel Tx descriptor tail pointer register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $02 constant ETHERNET_DMA_TDT               \ [0x02 : 30] Transmit Descriptor Tail Pointer
  [then]


  [ifdef] ETHERNET_DMA_DMACRxDTPR_DEF
    \
    \ @brief Channel Rx descriptor tail pointer register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $02 constant ETHERNET_DMA_RDT               \ [0x02 : 30] Receive Descriptor Tail Pointer
  [then]


  [ifdef] ETHERNET_DMA_DMACTxRLR_DEF
    \
    \ @brief Channel Tx descriptor ring length register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_TDRL              \ [0x00 : 10] Transmit Descriptor Ring Length
  [then]


  [ifdef] ETHERNET_DMA_DMACRxRLR_DEF
    \
    \ @brief Channel Rx descriptor ring length register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_RDRL              \ [0x00 : 10] Receive Descriptor Ring Length
  [then]


  [ifdef] ETHERNET_DMA_DMACIER_DEF
    \
    \ @brief Channel interrupt enable register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_TIE               \ [0x00] Transmit Interrupt Enable
    $01 constant ETHERNET_DMA_TXSE              \ [0x01] Transmit Stopped Enable
    $02 constant ETHERNET_DMA_TBUE              \ [0x02] Transmit Buffer Unavailable Enable
    $06 constant ETHERNET_DMA_RIE               \ [0x06] Receive Interrupt Enable
    $07 constant ETHERNET_DMA_RBUE              \ [0x07] Receive Buffer Unavailable Enable
    $08 constant ETHERNET_DMA_RSE               \ [0x08] Receive Stopped Enable
    $09 constant ETHERNET_DMA_RWTE              \ [0x09] Receive Watchdog Timeout Enable
    $0a constant ETHERNET_DMA_ETIE              \ [0x0a] Early Transmit Interrupt Enable
    $0b constant ETHERNET_DMA_ERIE              \ [0x0b] Early Receive Interrupt Enable
    $0c constant ETHERNET_DMA_FBEE              \ [0x0c] Fatal Bus Error Enable
    $0d constant ETHERNET_DMA_CDEE              \ [0x0d] Context Descriptor Error Enable
    $0e constant ETHERNET_DMA_AIE               \ [0x0e] Abnormal Interrupt Summary Enable
    $0f constant ETHERNET_DMA_NIE               \ [0x0f] Normal Interrupt Summary Enable
  [then]


  [ifdef] ETHERNET_DMA_DMACRxIWTR_DEF
    \
    \ @brief Channel Rx interrupt watchdog timer register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_RWT               \ [0x00 : 8] Receive Interrupt Watchdog Timer Count
  [then]


  [ifdef] ETHERNET_DMA_DMACCATxDR_DEF
    \
    \ @brief Channel current application transmit descriptor register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_CURTDESAPTR       \ [0x00 : 32] Application Transmit Descriptor Address Pointer
  [then]


  [ifdef] ETHERNET_DMA_DMACCARxDR_DEF
    \
    \ @brief Channel current application receive descriptor register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_CURRDESAPTR       \ [0x00 : 32] Application Receive Descriptor Address Pointer
  [then]


  [ifdef] ETHERNET_DMA_DMACCATxBR_DEF
    \
    \ @brief Channel current application transmit buffer register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_CURTBUFAPTR       \ [0x00 : 32] Application Transmit Buffer Address Pointer
  [then]


  [ifdef] ETHERNET_DMA_DMACCARxBR_DEF
    \
    \ @brief Channel current application receive buffer register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_CURRBUFAPTR       \ [0x00 : 32] Application Receive Buffer Address Pointer
  [then]


  [ifdef] ETHERNET_DMA_DMACSR_DEF
    \
    \ @brief Channel status register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_TI                \ [0x00] Transmit Interrupt
    $01 constant ETHERNET_DMA_TPS               \ [0x01] Transmit Process Stopped
    $02 constant ETHERNET_DMA_TBU               \ [0x02] Transmit Buffer Unavailable
    $06 constant ETHERNET_DMA_RI                \ [0x06] Receive Interrupt
    $07 constant ETHERNET_DMA_RBU               \ [0x07] Receive Buffer Unavailable
    $08 constant ETHERNET_DMA_RPS               \ [0x08] Receive Process Stopped
    $09 constant ETHERNET_DMA_RWT               \ [0x09] Receive Watchdog Timeout
    $0a constant ETHERNET_DMA_ET                \ [0x0a] Early Transmit Interrupt
    $0b constant ETHERNET_DMA_ER                \ [0x0b] Early Receive Interrupt
    $0c constant ETHERNET_DMA_FBE               \ [0x0c] Fatal Bus Error
    $0d constant ETHERNET_DMA_CDE               \ [0x0d] Context Descriptor Error
    $0e constant ETHERNET_DMA_AIS               \ [0x0e] Abnormal Interrupt Summary
    $0f constant ETHERNET_DMA_NIS               \ [0x0f] Normal Interrupt Summary
    $10 constant ETHERNET_DMA_TEB               \ [0x10 : 3] Tx DMA Error Bits
    $13 constant ETHERNET_DMA_REB               \ [0x13 : 3] Rx DMA Error Bits
  [then]


  [ifdef] ETHERNET_DMA_DMACMFCR_DEF
    \
    \ @brief Channel missed frame count register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_MFC               \ [0x00 : 11] Dropped Packet Counters
    $0f constant ETHERNET_DMA_MFCO              \ [0x0f] Overflow status of the MFC Counter
  [then]

  \
  \ @brief Ethernet: DMA mode register (DMA)
  \
  $00 constant ETHERNET_DMA_DMAMR       \ DMA mode register
  $04 constant ETHERNET_DMA_DMASBMR     \ System bus mode register
  $08 constant ETHERNET_DMA_DMAISR      \ Interrupt status register
  $0C constant ETHERNET_DMA_DMADSR      \ Debug status register
  $100 constant ETHERNET_DMA_DMACCR     \ Channel control register
  $104 constant ETHERNET_DMA_DMACTXCR   \ Channel transmit control register
  $108 constant ETHERNET_DMA_DMACRXCR   \ Channel receive control register
  $114 constant ETHERNET_DMA_DMACTXDLAR \ Channel Tx descriptor list address register
  $11C constant ETHERNET_DMA_DMACRXDLAR \ Channel Rx descriptor list address register
  $120 constant ETHERNET_DMA_DMACTXDTPR \ Channel Tx descriptor tail pointer register
  $128 constant ETHERNET_DMA_DMACRXDTPR \ Channel Rx descriptor tail pointer register
  $12C constant ETHERNET_DMA_DMACTXRLR  \ Channel Tx descriptor ring length register
  $130 constant ETHERNET_DMA_DMACRXRLR  \ Channel Rx descriptor ring length register
  $134 constant ETHERNET_DMA_DMACIER    \ Channel interrupt enable register
  $138 constant ETHERNET_DMA_DMACRXIWTR \ Channel Rx interrupt watchdog timer register
  $144 constant ETHERNET_DMA_DMACCATXDR \ Channel current application transmit descriptor register
  $14C constant ETHERNET_DMA_DMACCARXDR \ Channel current application receive descriptor register
  $154 constant ETHERNET_DMA_DMACCATXBR \ Channel current application transmit buffer register
  $15C constant ETHERNET_DMA_DMACCARXBR \ Channel current application receive buffer register
  $160 constant ETHERNET_DMA_DMACSR     \ Channel status register
  $16C constant ETHERNET_DMA_DMACMFCR   \ Channel missed frame count register

: ETHERNET_DMA_DEF ; [then]
