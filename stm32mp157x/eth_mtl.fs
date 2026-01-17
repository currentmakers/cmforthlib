\
\ @file eth_mtl.fs
\ @brief ETH_MTL
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETH_MTL_DEF

  [ifdef] ETH_MTL_ETH_MTLOMR_DEF
    \
    \ @brief The Operating Mode register establishes the Transmit and Receive operating modes and commands.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $01 constant ETH_MTL_DTXSTS                 \ [0x01] DTXSTS
    $02 constant ETH_MTL_RAA                    \ [0x02] RAA
    $05 constant ETH_MTL_SCHALG                 \ [0x05 : 2] SCHALG
    $08 constant ETH_MTL_CNTPRST                \ [0x08] CNTPRST
    $09 constant ETH_MTL_CNTCLR                 \ [0x09] CNTCLR
  [then]


  [ifdef] ETH_MTL_ETH_MTLISR_DEF
    \
    \ @brief The software driver (application) reads this register during interrupt service routine or polling to determine the interrupt status of MTL queues and the MAC.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_Q0IS                   \ [0x00] Q0IS
    $01 constant ETH_MTL_Q1IS                   \ [0x01] Q1IS
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ0OMR_DEF
    \
    \ @brief Tx queue 0 operating mode Register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_FTQ                    \ [0x00] FTQ
    $01 constant ETH_MTL_TSF                    \ [0x01] TSF
    $02 constant ETH_MTL_TXQEN                  \ [0x02 : 2] TXQEN
    $04 constant ETH_MTL_TTC                    \ [0x04 : 2] TTC
    $10 constant ETH_MTL_TQS                    \ [0x10 : 9] TQS
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ0UR_DEF
    \
    \ @brief Tx queue 0 underflow register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_UFFRMCNT               \ [0x00 : 11] UFFRMCNT
    $0b constant ETH_MTL_UFCNTOVF               \ [0x0b] UFCNTOVF
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ0DR_DEF
    \
    \ @brief Tx queue 0 underflow register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_TXQPAUSED              \ [0x00] TXQPAUSED
    $01 constant ETH_MTL_TRCSTS                 \ [0x01 : 2] TRCSTS
    $03 constant ETH_MTL_TWCSTS                 \ [0x03] TWCSTS
    $04 constant ETH_MTL_TXQSTS                 \ [0x04] TXQSTS
    $05 constant ETH_MTL_TXSTSFSTS              \ [0x05] TXSTSFSTS
    $10 constant ETH_MTL_PTXQ                   \ [0x10 : 3] PTXQ
    $14 constant ETH_MTL_STXSTSF                \ [0x14 : 3] STXSTSF
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ0ESR_DEF
    \
    \ @brief Tx queue x ETS status Register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_ABS                    \ [0x00 : 24] ABS
  [then]


  [ifdef] ETH_MTL_ETH_MTLQ0ICSR_DEF
    \
    \ @brief Queue 0 interrupt control status Register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_TXUNFIS                \ [0x00] TXUNFIS
    $01 constant ETH_MTL_ABPSIS                 \ [0x01] ABPSIS
    $08 constant ETH_MTL_TXUIE                  \ [0x08] TXUIE
    $09 constant ETH_MTL_ABPSIE                 \ [0x09] ABPSIE
    $10 constant ETH_MTL_RXOVFIS                \ [0x10] RXOVFIS
    $18 constant ETH_MTL_RXOIE                  \ [0x18] RXOIE
  [then]


  [ifdef] ETH_MTL_ETH_MTLRxQ0OMR_DEF
    \
    \ @brief Rx queue 0 operating mode register
    \ Address offset: 0x130
    \ Reset value: 0x00700000
    \
    $00 constant ETH_MTL_RTC                    \ [0x00 : 2] RTC
    $03 constant ETH_MTL_FUP                    \ [0x03] FUP
    $04 constant ETH_MTL_FEP                    \ [0x04] FEP
    $05 constant ETH_MTL_RSF                    \ [0x05] RSF
    $06 constant ETH_MTL_DIS_TCP_EF             \ [0x06] DIS_TCP_EF
    $07 constant ETH_MTL_EHFC                   \ [0x07] EHFC
    $08 constant ETH_MTL_RFA                    \ [0x08 : 3] RFA
    $0e constant ETH_MTL_RFD                    \ [0x0e : 3] RFD
    $14 constant ETH_MTL_RQS                    \ [0x14 : 4] RQS
  [then]


  [ifdef] ETH_MTL_ETH_MTLRxQ0MPOCR_DEF
    \
    \ @brief Rx queue 0 missed packet and overflow counter register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_OVFPKTCNT              \ [0x00 : 11] OVFPKTCNT
    $0b constant ETH_MTL_OVFCNTOVF              \ [0x0b] OVFCNTOVF
    $10 constant ETH_MTL_MISPKTCNT              \ [0x10 : 11] MISPKTCNT
    $1b constant ETH_MTL_MISCNTOVF              \ [0x1b] MISCNTOVF
  [then]


  [ifdef] ETH_MTL_ETH_MTLRxQ0DR_DEF
    \
    \ @brief Rx queue i debug register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_RWCSTS                 \ [0x00] RWCSTS
    $01 constant ETH_MTL_RRCSTS                 \ [0x01 : 2] RRCSTS
    $04 constant ETH_MTL_RXQSTS                 \ [0x04 : 2] RXQSTS
    $10 constant ETH_MTL_PRXQ                   \ [0x10 : 14] PRXQ
  [then]


  [ifdef] ETH_MTL_ETH_MTLRxQ0CR_DEF
    \
    \ @brief Rx queue 0 control register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_RXQ_WEGT               \ [0x00 : 3] RXQ_WEGT
    $03 constant ETH_MTL_RXQ_FRM_ARBIT          \ [0x03] RXQ_FRM_ARBIT
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ1OMR_DEF
    \
    \ @brief Tx queue 1 operating mode Register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_FTQ                    \ [0x00] FTQ
    $01 constant ETH_MTL_TSF                    \ [0x01] TSF
    $02 constant ETH_MTL_TXQEN                  \ [0x02 : 2] TXQEN
    $04 constant ETH_MTL_TTC                    \ [0x04 : 2] TTC
    $10 constant ETH_MTL_TQS                    \ [0x10 : 9] TQS
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ1UR_DEF
    \
    \ @brief Tx queue 1 underflow register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_UFFRMCNT               \ [0x00 : 11] UFFRMCNT
    $0b constant ETH_MTL_UFCNTOVF               \ [0x0b] UFCNTOVF
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ1DR_DEF
    \
    \ @brief Tx queue 1 underflow register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_TXQPAUSED              \ [0x00] TXQPAUSED
    $01 constant ETH_MTL_TRCSTS                 \ [0x01 : 2] TRCSTS
    $03 constant ETH_MTL_TWCSTS                 \ [0x03] TWCSTS
    $04 constant ETH_MTL_TXQSTS                 \ [0x04] TXQSTS
    $05 constant ETH_MTL_TXSTSFSTS              \ [0x05] TXSTSFSTS
    $10 constant ETH_MTL_PTXQ                   \ [0x10 : 3] PTXQ
    $14 constant ETH_MTL_STXSTSF                \ [0x14 : 3] STXSTSF
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ1ECR_DEF
    \
    \ @brief The Queue ETS Control register controls the enhanced transmission selection operation.
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $02 constant ETH_MTL_AVALG                  \ [0x02] AVALG
    $03 constant ETH_MTL_CC                     \ [0x03] CC
    $04 constant ETH_MTL_SLC                    \ [0x04 : 3] SLC
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ1ESR_DEF
    \
    \ @brief Tx queue x ETS status Register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_ABS                    \ [0x00 : 24] ABS
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ1QWR_DEF
    \
    \ @brief This register provides the average traffic transmitted on queue 1.
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_ISCQW                  \ [0x00 : 21] ISCQW
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ1SSCR_DEF
    \
    \ @brief The sendSlopeCredit register contains the sendSlope credit value required for the credit-based shaper algorithm for the Queue.
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_SSC                    \ [0x00 : 14] SSC
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ1HCR_DEF
    \
    \ @brief The hiCredit register contains the hiCredit value required for the credit-based shaper algorithm for the Queue.
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_HC                     \ [0x00 : 29] HC
  [then]


  [ifdef] ETH_MTL_ETH_MTLTxQ1LCR_DEF
    \
    \ @brief The loCredit register contains the loCredit value required for the credit-based shaper algorithm for the Queue.
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_LC                     \ [0x00 : 29] LC
  [then]


  [ifdef] ETH_MTL_ETH_MTLQ1ICSR_DEF
    \
    \ @brief Queue 1 interrupt control status Register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_TXUNFIS                \ [0x00] TXUNFIS
    $01 constant ETH_MTL_ABPSIS                 \ [0x01] ABPSIS
    $08 constant ETH_MTL_TXUIE                  \ [0x08] TXUIE
    $09 constant ETH_MTL_ABPSIE                 \ [0x09] ABPSIE
    $10 constant ETH_MTL_RXOVFIS                \ [0x10] RXOVFIS
    $18 constant ETH_MTL_RXOIE                  \ [0x18] RXOIE
  [then]


  [ifdef] ETH_MTL_ETH_MTLRxQ1OMR_DEF
    \
    \ @brief Rx queue 1 operating mode register
    \ Address offset: 0x170
    \ Reset value: 0x00700000
    \
    $00 constant ETH_MTL_RTC                    \ [0x00 : 2] RTC
    $03 constant ETH_MTL_FUP                    \ [0x03] FUP
    $04 constant ETH_MTL_FEP                    \ [0x04] FEP
    $05 constant ETH_MTL_RSF                    \ [0x05] RSF
    $06 constant ETH_MTL_DIS_TCP_EF             \ [0x06] DIS_TCP_EF
    $07 constant ETH_MTL_EHFC                   \ [0x07] EHFC
    $08 constant ETH_MTL_RFA                    \ [0x08 : 3] RFA
    $0e constant ETH_MTL_RFD                    \ [0x0e : 3] RFD
    $14 constant ETH_MTL_RQS                    \ [0x14 : 4] RQS
  [then]


  [ifdef] ETH_MTL_ETH_MTLRxQ1MPOCR_DEF
    \
    \ @brief Rx queue 1 missed packet and overflow counter register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_OVFPKTCNT              \ [0x00 : 11] OVFPKTCNT
    $0b constant ETH_MTL_OVFCNTOVF              \ [0x0b] OVFCNTOVF
    $10 constant ETH_MTL_MISPKTCNT              \ [0x10 : 11] MISPKTCNT
    $1b constant ETH_MTL_MISCNTOVF              \ [0x1b] MISCNTOVF
  [then]


  [ifdef] ETH_MTL_ETH_MTLRxQ1DR_DEF
    \
    \ @brief Rx queue i debug register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_RWCSTS                 \ [0x00] RWCSTS
    $01 constant ETH_MTL_RRCSTS                 \ [0x01 : 2] RRCSTS
    $04 constant ETH_MTL_RXQSTS                 \ [0x04 : 2] RXQSTS
    $10 constant ETH_MTL_PRXQ                   \ [0x10 : 14] PRXQ
  [then]


  [ifdef] ETH_MTL_ETH_MTLRxQ1CR_DEF
    \
    \ @brief Rx queue 1 control register
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MTL_RXQ_WEGT               \ [0x00 : 3] RXQ_WEGT
    $03 constant ETH_MTL_RXQ_FRM_ARBIT          \ [0x03] RXQ_FRM_ARBIT
  [then]

  \
  \ @brief ETH_MTL
  \
  $00 constant ETH_MTL_ETH_MTLOMR       \ The Operating Mode register establishes the Transmit and Receive operating modes and commands.
  $20 constant ETH_MTL_ETH_MTLISR       \ The software driver (application) reads this register during interrupt service routine or polling to determine the interrupt status of MTL queues and the MAC.
  $100 constant ETH_MTL_ETH_MTLTXQ0OMR  \ Tx queue 0 operating mode Register
  $104 constant ETH_MTL_ETH_MTLTXQ0UR   \ Tx queue 0 underflow register
  $108 constant ETH_MTL_ETH_MTLTXQ0DR   \ Tx queue 0 underflow register
  $114 constant ETH_MTL_ETH_MTLTXQ0ESR  \ Tx queue x ETS status Register
  $12C constant ETH_MTL_ETH_MTLQ0ICSR   \ Queue 0 interrupt control status Register
  $130 constant ETH_MTL_ETH_MTLRXQ0OMR  \ Rx queue 0 operating mode register
  $134 constant ETH_MTL_ETH_MTLRXQ0MPOCR    \ Rx queue 0 missed packet and overflow counter register
  $138 constant ETH_MTL_ETH_MTLRXQ0DR   \ Rx queue i debug register
  $13C constant ETH_MTL_ETH_MTLRXQ0CR   \ Rx queue 0 control register
  $140 constant ETH_MTL_ETH_MTLTXQ1OMR  \ Tx queue 1 operating mode Register
  $144 constant ETH_MTL_ETH_MTLTXQ1UR   \ Tx queue 1 underflow register
  $148 constant ETH_MTL_ETH_MTLTXQ1DR   \ Tx queue 1 underflow register
  $150 constant ETH_MTL_ETH_MTLTXQ1ECR  \ The Queue ETS Control register controls the enhanced transmission selection operation.
  $154 constant ETH_MTL_ETH_MTLTXQ1ESR  \ Tx queue x ETS status Register
  $158 constant ETH_MTL_ETH_MTLTXQ1QWR  \ This register provides the average traffic transmitted on queue 1.
  $15C constant ETH_MTL_ETH_MTLTXQ1SSCR \ The sendSlopeCredit register contains the sendSlope credit value required for the credit-based shaper algorithm for the Queue.
  $160 constant ETH_MTL_ETH_MTLTXQ1HCR  \ The hiCredit register contains the hiCredit value required for the credit-based shaper algorithm for the Queue.
  $164 constant ETH_MTL_ETH_MTLTXQ1LCR  \ The loCredit register contains the loCredit value required for the credit-based shaper algorithm for the Queue.
  $16C constant ETH_MTL_ETH_MTLQ1ICSR   \ Queue 1 interrupt control status Register
  $170 constant ETH_MTL_ETH_MTLRXQ1OMR  \ Rx queue 1 operating mode register
  $174 constant ETH_MTL_ETH_MTLRXQ1MPOCR    \ Rx queue 1 missed packet and overflow counter register
  $178 constant ETH_MTL_ETH_MTLRXQ1DR   \ Rx queue i debug register
  $17C constant ETH_MTL_ETH_MTLRXQ1CR   \ Rx queue 1 control register

: ETH_MTL_DEF ; [then]
