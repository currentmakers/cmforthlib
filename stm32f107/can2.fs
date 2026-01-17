\
\ @file can2.fs
\ @brief Controller area network
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CAN2_DEF

  [ifdef] CAN2_CAN_MCR_DEF
    \
    \ @brief CAN_MCR
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_INRQ                      \ [0x00] INRQ
    $01 constant CAN2_SLEEP                     \ [0x01] SLEEP
    $02 constant CAN2_TXFP                      \ [0x02] TXFP
    $03 constant CAN2_RFLM                      \ [0x03] RFLM
    $04 constant CAN2_NART                      \ [0x04] NART
    $05 constant CAN2_AWUM                      \ [0x05] AWUM
    $06 constant CAN2_ABOM                      \ [0x06] ABOM
    $07 constant CAN2_TTCM                      \ [0x07] TTCM
    $0f constant CAN2_RESET                     \ [0x0f] RESET
    $10 constant CAN2_DBF                       \ [0x10] DBF
  [then]


  [ifdef] CAN2_CAN_MSR_DEF
    \
    \ @brief CAN_MSR
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_INAK                      \ [0x00] INAK
    $01 constant CAN2_SLAK                      \ [0x01] SLAK
    $02 constant CAN2_ERRI                      \ [0x02] ERRI
    $03 constant CAN2_WKUI                      \ [0x03] WKUI
    $04 constant CAN2_SLAKI                     \ [0x04] SLAKI
    $08 constant CAN2_TXM                       \ [0x08] TXM
    $09 constant CAN2_RXM                       \ [0x09] RXM
    $0a constant CAN2_SAMP                      \ [0x0a] SAMP
    $0b constant CAN2_RX                        \ [0x0b] RX
  [then]


  [ifdef] CAN2_CAN_TSR_DEF
    \
    \ @brief CAN_TSR
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_RQCP0                     \ [0x00] RQCP0
    $01 constant CAN2_TXOK0                     \ [0x01] TXOK0
    $02 constant CAN2_ALST0                     \ [0x02] ALST0
    $03 constant CAN2_TERR0                     \ [0x03] TERR0
    $07 constant CAN2_ABRQ0                     \ [0x07] ABRQ0
    $08 constant CAN2_RQCP1                     \ [0x08] RQCP1
    $09 constant CAN2_TXOK1                     \ [0x09] TXOK1
    $0a constant CAN2_ALST1                     \ [0x0a] ALST1
    $0b constant CAN2_TERR1                     \ [0x0b] TERR1
    $0f constant CAN2_ABRQ1                     \ [0x0f] ABRQ1
    $10 constant CAN2_RQCP2                     \ [0x10] RQCP2
    $11 constant CAN2_TXOK2                     \ [0x11] TXOK2
    $12 constant CAN2_ALST2                     \ [0x12] ALST2
    $13 constant CAN2_TERR2                     \ [0x13] TERR2
    $17 constant CAN2_ABRQ2                     \ [0x17] ABRQ2
    $18 constant CAN2_CODE                      \ [0x18 : 2] CODE
    $1a constant CAN2_TME0                      \ [0x1a] Lowest priority flag for mailbox 0
    $1b constant CAN2_TME1                      \ [0x1b] Lowest priority flag for mailbox 1
    $1c constant CAN2_TME2                      \ [0x1c] Lowest priority flag for mailbox 2
    $1d constant CAN2_LOW0                      \ [0x1d] Lowest priority flag for mailbox 0
    $1e constant CAN2_LOW1                      \ [0x1e] Lowest priority flag for mailbox 1
    $1f constant CAN2_LOW2                      \ [0x1f] Lowest priority flag for mailbox 2
  [then]


  [ifdef] CAN2_CAN_RF0R_DEF
    \
    \ @brief CAN_RF0R
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_FMP0                      \ [0x00 : 2] FMP0
    $03 constant CAN2_FULL0                     \ [0x03] FULL0
    $04 constant CAN2_FOVR0                     \ [0x04] FOVR0
    $05 constant CAN2_RFOM0                     \ [0x05] RFOM0
  [then]


  [ifdef] CAN2_CAN_RF1R_DEF
    \
    \ @brief CAN_RF1R
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_FMP1                      \ [0x00 : 2] FMP1
    $03 constant CAN2_FULL1                     \ [0x03] FULL1
    $04 constant CAN2_FOVR1                     \ [0x04] FOVR1
    $05 constant CAN2_RFOM1                     \ [0x05] RFOM1
  [then]


  [ifdef] CAN2_CAN_IER_DEF
    \
    \ @brief CAN_IER
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_TMEIE                     \ [0x00] TMEIE
    $01 constant CAN2_FMPIE0                    \ [0x01] FMPIE0
    $02 constant CAN2_FFIE0                     \ [0x02] FFIE0
    $03 constant CAN2_FOVIE0                    \ [0x03] FOVIE0
    $04 constant CAN2_FMPIE1                    \ [0x04] FMPIE1
    $05 constant CAN2_FFIE1                     \ [0x05] FFIE1
    $06 constant CAN2_FOVIE1                    \ [0x06] FOVIE1
    $08 constant CAN2_EWGIE                     \ [0x08] EWGIE
    $09 constant CAN2_EPVIE                     \ [0x09] EPVIE
    $0a constant CAN2_BOFIE                     \ [0x0a] BOFIE
    $0b constant CAN2_LECIE                     \ [0x0b] LECIE
    $0f constant CAN2_ERRIE                     \ [0x0f] ERRIE
    $10 constant CAN2_WKUIE                     \ [0x10] WKUIE
    $11 constant CAN2_SLKIE                     \ [0x11] SLKIE
  [then]


  [ifdef] CAN2_CAN_ESR_DEF
    \
    \ @brief CAN_ESR
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_EWGF                      \ [0x00] EWGF
    $01 constant CAN2_EPVF                      \ [0x01] EPVF
    $02 constant CAN2_BOFF                      \ [0x02] BOFF
    $04 constant CAN2_LEC                       \ [0x04 : 3] LEC
    $10 constant CAN2_TEC                       \ [0x10 : 8] TEC
    $18 constant CAN2_REC                       \ [0x18 : 8] REC
  [then]


  [ifdef] CAN2_CAN_BTR_DEF
    \
    \ @brief CAN_BTR
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_BRP                       \ [0x00 : 10] BRP
    $10 constant CAN2_TS1                       \ [0x10 : 4] TS1
    $14 constant CAN2_TS2                       \ [0x14 : 3] TS2
    $18 constant CAN2_SJW                       \ [0x18 : 2] SJW
    $1e constant CAN2_LBKM                      \ [0x1e] LBKM
    $1f constant CAN2_SILM                      \ [0x1f] SILM
  [then]


  [ifdef] CAN2_CAN_TI0R_DEF
    \
    \ @brief CAN_TI0R
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_TXRQ                      \ [0x00] TXRQ
    $01 constant CAN2_RTR                       \ [0x01] RTR
    $02 constant CAN2_IDE                       \ [0x02] IDE
    $03 constant CAN2_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN2_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN2_CAN_TDT0R_DEF
    \
    \ @brief CAN_TDT0R
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN2_TGT                       \ [0x08] TGT
    $10 constant CAN2_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN2_CAN_TDL0R_DEF
    \
    \ @brief CAN_TDL0R
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN2_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN2_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN2_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN2_CAN_TDH0R_DEF
    \
    \ @brief CAN_TDH0R
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN2_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN2_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN2_DATA7                     \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN2_CAN_TI1R_DEF
    \
    \ @brief CAN_TI1R
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_TXRQ                      \ [0x00] TXRQ
    $01 constant CAN2_RTR                       \ [0x01] RTR
    $02 constant CAN2_IDE                       \ [0x02] IDE
    $03 constant CAN2_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN2_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN2_CAN_TDT1R_DEF
    \
    \ @brief CAN_TDT1R
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN2_TGT                       \ [0x08] TGT
    $10 constant CAN2_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN2_CAN_TDL1R_DEF
    \
    \ @brief CAN_TDL1R
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN2_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN2_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN2_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN2_CAN_TDH1R_DEF
    \
    \ @brief CAN_TDH1R
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN2_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN2_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN2_DATA7                     \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN2_CAN_TI2R_DEF
    \
    \ @brief CAN_TI2R
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_TXRQ                      \ [0x00] TXRQ
    $01 constant CAN2_RTR                       \ [0x01] RTR
    $02 constant CAN2_IDE                       \ [0x02] IDE
    $03 constant CAN2_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN2_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN2_CAN_TDT2R_DEF
    \
    \ @brief CAN_TDT2R
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN2_TGT                       \ [0x08] TGT
    $10 constant CAN2_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN2_CAN_TDL2R_DEF
    \
    \ @brief CAN_TDL2R
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN2_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN2_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN2_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN2_CAN_TDH2R_DEF
    \
    \ @brief CAN_TDH2R
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN2_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN2_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN2_DATA7                     \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN2_CAN_RI0R_DEF
    \
    \ @brief CAN_RI0R
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $01 constant CAN2_RTR                       \ [0x01] RTR
    $02 constant CAN2_IDE                       \ [0x02] IDE
    $03 constant CAN2_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN2_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN2_CAN_RDT0R_DEF
    \
    \ @brief CAN_RDT0R
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN2_FMI                       \ [0x08 : 8] FMI
    $10 constant CAN2_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN2_CAN_RDL0R_DEF
    \
    \ @brief CAN_RDL0R
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN2_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN2_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN2_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN2_CAN_RDH0R_DEF
    \
    \ @brief CAN_RDH0R
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN2_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN2_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN2_DATA7                     \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN2_CAN_RI1R_DEF
    \
    \ @brief CAN_RI1R
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $01 constant CAN2_RTR                       \ [0x01] RTR
    $02 constant CAN2_IDE                       \ [0x02] IDE
    $03 constant CAN2_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN2_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN2_CAN_RDT1R_DEF
    \
    \ @brief CAN_RDT1R
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN2_FMI                       \ [0x08 : 8] FMI
    $10 constant CAN2_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN2_CAN_RDL1R_DEF
    \
    \ @brief CAN_RDL1R
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN2_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN2_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN2_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN2_CAN_RDH1R_DEF
    \
    \ @brief CAN_RDH1R
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant CAN2_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN2_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN2_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN2_DATA7                     \ [0x18 : 8] DATA7
  [then]

  \
  \ @brief Controller area network
  \
  $00 constant CAN2_CAN_MCR             \ CAN_MCR
  $04 constant CAN2_CAN_MSR             \ CAN_MSR
  $08 constant CAN2_CAN_TSR             \ CAN_TSR
  $0C constant CAN2_CAN_RF0R            \ CAN_RF0R
  $10 constant CAN2_CAN_RF1R            \ CAN_RF1R
  $14 constant CAN2_CAN_IER             \ CAN_IER
  $18 constant CAN2_CAN_ESR             \ CAN_ESR
  $1C constant CAN2_CAN_BTR             \ CAN_BTR
  $180 constant CAN2_CAN_TI0R           \ CAN_TI0R
  $184 constant CAN2_CAN_TDT0R          \ CAN_TDT0R
  $188 constant CAN2_CAN_TDL0R          \ CAN_TDL0R
  $18C constant CAN2_CAN_TDH0R          \ CAN_TDH0R
  $190 constant CAN2_CAN_TI1R           \ CAN_TI1R
  $194 constant CAN2_CAN_TDT1R          \ CAN_TDT1R
  $198 constant CAN2_CAN_TDL1R          \ CAN_TDL1R
  $19C constant CAN2_CAN_TDH1R          \ CAN_TDH1R
  $1A0 constant CAN2_CAN_TI2R           \ CAN_TI2R
  $1A4 constant CAN2_CAN_TDT2R          \ CAN_TDT2R
  $1A8 constant CAN2_CAN_TDL2R          \ CAN_TDL2R
  $1AC constant CAN2_CAN_TDH2R          \ CAN_TDH2R
  $1B0 constant CAN2_CAN_RI0R           \ CAN_RI0R
  $1B4 constant CAN2_CAN_RDT0R          \ CAN_RDT0R
  $1B8 constant CAN2_CAN_RDL0R          \ CAN_RDL0R
  $1BC constant CAN2_CAN_RDH0R          \ CAN_RDH0R
  $1C0 constant CAN2_CAN_RI1R           \ CAN_RI1R
  $1C4 constant CAN2_CAN_RDT1R          \ CAN_RDT1R
  $1C8 constant CAN2_CAN_RDL1R          \ CAN_RDL1R
  $1CC constant CAN2_CAN_RDH1R          \ CAN_RDH1R

: CAN2_DEF ; [then]
