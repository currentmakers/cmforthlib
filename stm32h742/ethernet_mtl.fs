\
\ @file ethernet_mtl.fs
\ @brief Ethernet: MTL mode register (MTL)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETHERNET_MTL_DEF

  [ifdef] ETHERNET_MTL_MTLOMR_DEF
    \
    \ @brief Operating mode Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $01 constant ETHERNET_MTL_DTXSTS            \ [0x01] DTXSTS
    $08 constant ETHERNET_MTL_CNTPRST           \ [0x08] CNTPRST
    $09 constant ETHERNET_MTL_CNTCLR            \ [0x09] CNTCLR
  [then]


  [ifdef] ETHERNET_MTL_MTLISR_DEF
    \
    \ @brief Interrupt status Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MTL_Q0IS              \ [0x00] Queue interrupt status
  [then]


  [ifdef] ETHERNET_MTL_MTLTxQOMR_DEF
    \
    \ @brief Tx queue operating mode Register
    \ Address offset: 0x100
    \ Reset value: 0x00070008
    \
    $00 constant ETHERNET_MTL_FTQ               \ [0x00] Flush Transmit Queue
    $01 constant ETHERNET_MTL_TSF               \ [0x01] Transmit Store and Forward
    $02 constant ETHERNET_MTL_TXQEN             \ [0x02 : 2] Transmit Queue Enable
    $04 constant ETHERNET_MTL_TTC               \ [0x04 : 3] Transmit Threshold Control
    $10 constant ETHERNET_MTL_TQS               \ [0x10 : 3] Transmit Queue Size
  [then]


  [ifdef] ETHERNET_MTL_MTLTxQUR_DEF
    \
    \ @brief Tx queue underflow register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MTL_UFFRMCNT          \ [0x00 : 11] Underflow Packet Counter
    $0b constant ETHERNET_MTL_UFCNTOVF          \ [0x0b] UFCNTOVF
  [then]


  [ifdef] ETHERNET_MTL_MTLTxQDR_DEF
    \
    \ @brief Tx queue debug Register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MTL_TXQPAUSED         \ [0x00] TXQPAUSED
    $01 constant ETHERNET_MTL_TRCSTS            \ [0x01 : 2] TRCSTS
    $03 constant ETHERNET_MTL_TWCSTS            \ [0x03] TWCSTS
    $04 constant ETHERNET_MTL_TXQSTS            \ [0x04] TXQSTS
    $05 constant ETHERNET_MTL_TXSTSFSTS         \ [0x05] TXSTSFSTS
    $10 constant ETHERNET_MTL_PTXQ              \ [0x10 : 3] PTXQ
    $14 constant ETHERNET_MTL_STXSTSF           \ [0x14 : 3] STXSTSF
  [then]


  [ifdef] ETHERNET_MTL_MTLQICSR_DEF
    \
    \ @brief Queue interrupt control status Register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MTL_TXUNFIS           \ [0x00] TXUNFIS
    $08 constant ETHERNET_MTL_TXUIE             \ [0x08] TXUIE
    $10 constant ETHERNET_MTL_RXOVFIS           \ [0x10] RXOVFIS
    $18 constant ETHERNET_MTL_RXOIE             \ [0x18] RXOIE
  [then]


  [ifdef] ETHERNET_MTL_MTLRxQOMR_DEF
    \
    \ @brief Rx queue operating mode register
    \ Address offset: 0x130
    \ Reset value: 0x00700000
    \
    $00 constant ETHERNET_MTL_RTC               \ [0x00 : 2] RTC
    $03 constant ETHERNET_MTL_FUP               \ [0x03] FUP
    $04 constant ETHERNET_MTL_FEP               \ [0x04] FEP
    $05 constant ETHERNET_MTL_RSF               \ [0x05] RSF
    $06 constant ETHERNET_MTL_DIS_TCP_EF        \ [0x06] DIS_TCP_EF
    $07 constant ETHERNET_MTL_EHFC              \ [0x07] EHFC
    $08 constant ETHERNET_MTL_RFA               \ [0x08 : 3] RFA
    $0e constant ETHERNET_MTL_RFD               \ [0x0e : 3] RFD
    $14 constant ETHERNET_MTL_RQS               \ [0x14 : 3] RQS
  [then]


  [ifdef] ETHERNET_MTL_MTLRxQMPOCR_DEF
    \
    \ @brief Rx queue missed packet and overflow counter register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MTL_OVFPKTCNT         \ [0x00 : 11] OVFPKTCNT
    $0b constant ETHERNET_MTL_OVFCNTOVF         \ [0x0b] OVFCNTOVF
    $10 constant ETHERNET_MTL_MISPKTCNT         \ [0x10 : 11] MISPKTCNT
    $1b constant ETHERNET_MTL_MISCNTOVF         \ [0x1b] MISCNTOVF
  [then]


  [ifdef] ETHERNET_MTL_MTLRxQDR_DEF
    \
    \ @brief Rx queue debug register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MTL_RWCSTS            \ [0x00] RWCSTS
    $01 constant ETHERNET_MTL_RRCSTS            \ [0x01 : 2] RRCSTS
    $04 constant ETHERNET_MTL_RXQSTS            \ [0x04 : 2] RXQSTS
    $10 constant ETHERNET_MTL_PRXQ              \ [0x10 : 14] PRXQ
  [then]

  \
  \ @brief Ethernet: MTL mode register (MTL)
  \
  $00 constant ETHERNET_MTL_MTLOMR      \ Operating mode Register
  $20 constant ETHERNET_MTL_MTLISR      \ Interrupt status Register
  $100 constant ETHERNET_MTL_MTLTXQOMR  \ Tx queue operating mode Register
  $104 constant ETHERNET_MTL_MTLTXQUR   \ Tx queue underflow register
  $108 constant ETHERNET_MTL_MTLTXQDR   \ Tx queue debug Register
  $12C constant ETHERNET_MTL_MTLQICSR   \ Queue interrupt control status Register
  $130 constant ETHERNET_MTL_MTLRXQOMR  \ Rx queue operating mode register
  $134 constant ETHERNET_MTL_MTLRXQMPOCR    \ Rx queue missed packet and overflow counter register
  $138 constant ETHERNET_MTL_MTLRXQDR   \ Rx queue debug register

: ETHERNET_MTL_DEF ; [then]
