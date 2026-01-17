\
\ @file can.fs
\ @brief Controller area network
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CAN_DEF

  [ifdef] CAN_CAN_MCR_DEF
    \
    \ @brief CAN_MCR
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant CAN_INRQ                       \ [0x00] INRQ
    $01 constant CAN_SLEEP                      \ [0x01] SLEEP
    $02 constant CAN_TXFP                       \ [0x02] TXFP
    $03 constant CAN_RFLM                       \ [0x03] RFLM
    $04 constant CAN_NART                       \ [0x04] NART
    $05 constant CAN_AWUM                       \ [0x05] AWUM
    $06 constant CAN_ABOM                       \ [0x06] ABOM
    $07 constant CAN_TTCM                       \ [0x07] TTCM
    $0f constant CAN_RESET                      \ [0x0f] RESET
    $10 constant CAN_DBF                        \ [0x10] DBF
  [then]


  [ifdef] CAN_CAN_MSR_DEF
    \
    \ @brief CAN_MSR
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CAN_INAK                       \ [0x00] INAK
    $01 constant CAN_SLAK                       \ [0x01] SLAK
    $02 constant CAN_ERRI                       \ [0x02] ERRI
    $03 constant CAN_WKUI                       \ [0x03] WKUI
    $04 constant CAN_SLAKI                      \ [0x04] SLAKI
    $08 constant CAN_TXM                        \ [0x08] TXM
    $09 constant CAN_RXM                        \ [0x09] RXM
    $0a constant CAN_SAMP                       \ [0x0a] SAMP
    $0b constant CAN_RX                         \ [0x0b] RX
  [then]


  [ifdef] CAN_CAN_TSR_DEF
    \
    \ @brief CAN_TSR
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CAN_RQCP0                      \ [0x00] RQCP0
    $01 constant CAN_TXOK0                      \ [0x01] TXOK0
    $02 constant CAN_ALST0                      \ [0x02] ALST0
    $03 constant CAN_TERR0                      \ [0x03] TERR0
    $07 constant CAN_ABRQ0                      \ [0x07] ABRQ0
    $08 constant CAN_RQCP1                      \ [0x08] RQCP1
    $09 constant CAN_TXOK1                      \ [0x09] TXOK1
    $0a constant CAN_ALST1                      \ [0x0a] ALST1
    $0b constant CAN_TERR1                      \ [0x0b] TERR1
    $0f constant CAN_ABRQ1                      \ [0x0f] ABRQ1
    $10 constant CAN_RQCP2                      \ [0x10] RQCP2
    $11 constant CAN_TXOK2                      \ [0x11] TXOK2
    $12 constant CAN_ALST2                      \ [0x12] ALST2
    $13 constant CAN_TERR2                      \ [0x13] TERR2
    $17 constant CAN_ABRQ2                      \ [0x17] ABRQ2
    $18 constant CAN_CODE                       \ [0x18 : 2] CODE
    $1a constant CAN_TME0                       \ [0x1a] Lowest priority flag for mailbox 0
    $1b constant CAN_TME1                       \ [0x1b] Lowest priority flag for mailbox 1
    $1c constant CAN_TME2                       \ [0x1c] Lowest priority flag for mailbox 2
    $1d constant CAN_LOW0                       \ [0x1d] Lowest priority flag for mailbox 0
    $1e constant CAN_LOW1                       \ [0x1e] Lowest priority flag for mailbox 1
    $1f constant CAN_LOW2                       \ [0x1f] Lowest priority flag for mailbox 2
  [then]


  [ifdef] CAN_CAN_RF0R_DEF
    \
    \ @brief CAN_RF0R
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FMP0                       \ [0x00 : 2] FMP0
    $03 constant CAN_FULL0                      \ [0x03] FULL0
    $04 constant CAN_FOVR0                      \ [0x04] FOVR0
    $05 constant CAN_RFOM0                      \ [0x05] RFOM0
  [then]


  [ifdef] CAN_CAN_RF1R_DEF
    \
    \ @brief CAN_RF1R
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FMP1                       \ [0x00 : 2] FMP1
    $03 constant CAN_FULL1                      \ [0x03] FULL1
    $04 constant CAN_FOVR1                      \ [0x04] FOVR1
    $05 constant CAN_RFOM1                      \ [0x05] RFOM1
  [then]


  [ifdef] CAN_CAN_IER_DEF
    \
    \ @brief CAN_IER
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CAN_TMEIE                      \ [0x00] TMEIE
    $01 constant CAN_FMPIE0                     \ [0x01] FMPIE0
    $02 constant CAN_FFIE0                      \ [0x02] FFIE0
    $03 constant CAN_FOVIE0                     \ [0x03] FOVIE0
    $04 constant CAN_FMPIE1                     \ [0x04] FMPIE1
    $05 constant CAN_FFIE1                      \ [0x05] FFIE1
    $06 constant CAN_FOVIE1                     \ [0x06] FOVIE1
    $08 constant CAN_EWGIE                      \ [0x08] EWGIE
    $09 constant CAN_EPVIE                      \ [0x09] EPVIE
    $0a constant CAN_BOFIE                      \ [0x0a] BOFIE
    $0b constant CAN_LECIE                      \ [0x0b] LECIE
    $0f constant CAN_ERRIE                      \ [0x0f] ERRIE
    $10 constant CAN_WKUIE                      \ [0x10] WKUIE
    $11 constant CAN_SLKIE                      \ [0x11] SLKIE
  [then]


  [ifdef] CAN_CAN_ESR_DEF
    \
    \ @brief CAN_ESR
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant CAN_EWGF                       \ [0x00] EWGF
    $01 constant CAN_EPVF                       \ [0x01] EPVF
    $02 constant CAN_BOFF                       \ [0x02] BOFF
    $04 constant CAN_LEC                        \ [0x04 : 3] LEC
    $10 constant CAN_TEC                        \ [0x10 : 8] TEC
    $18 constant CAN_REC                        \ [0x18 : 8] REC
  [then]


  [ifdef] CAN_CAN_BTR_DEF
    \
    \ @brief CAN_BTR
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_BRP                        \ [0x00 : 10] BRP
    $10 constant CAN_TS1                        \ [0x10 : 4] TS1
    $14 constant CAN_TS2                        \ [0x14 : 3] TS2
    $18 constant CAN_SJW                        \ [0x18 : 2] SJW
    $1e constant CAN_LBKM                       \ [0x1e] LBKM
    $1f constant CAN_SILM                       \ [0x1f] SILM
  [then]


  [ifdef] CAN_CAN_TI0R_DEF
    \
    \ @brief CAN_TI0R
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant CAN_TXRQ                       \ [0x00] TXRQ
    $01 constant CAN_RTR                        \ [0x01] RTR
    $02 constant CAN_IDE                        \ [0x02] IDE
    $03 constant CAN_EXID                       \ [0x03 : 18] EXID
    $15 constant CAN_STID                       \ [0x15 : 11] STID
  [then]


  [ifdef] CAN_CAN_TDT0R_DEF
    \
    \ @brief CAN_TDT0R
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DLC                        \ [0x00 : 4] DLC
    $08 constant CAN_TGT                        \ [0x08] TGT
    $10 constant CAN_TIME                       \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN_CAN_TDL0R_DEF
    \
    \ @brief CAN_TDL0R
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA0                      \ [0x00 : 8] DATA0
    $08 constant CAN_DATA1                      \ [0x08 : 8] DATA1
    $10 constant CAN_DATA2                      \ [0x10 : 8] DATA2
    $18 constant CAN_DATA3                      \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN_CAN_TDH0R_DEF
    \
    \ @brief CAN_TDH0R
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA4                      \ [0x00 : 8] DATA4
    $08 constant CAN_DATA5                      \ [0x08 : 8] DATA5
    $10 constant CAN_DATA6                      \ [0x10 : 8] DATA6
    $18 constant CAN_DATA7                      \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN_CAN_TI1R_DEF
    \
    \ @brief CAN_TI1R
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant CAN_TXRQ                       \ [0x00] TXRQ
    $01 constant CAN_RTR                        \ [0x01] RTR
    $02 constant CAN_IDE                        \ [0x02] IDE
    $03 constant CAN_EXID                       \ [0x03 : 18] EXID
    $15 constant CAN_STID                       \ [0x15 : 11] STID
  [then]


  [ifdef] CAN_CAN_TDT1R_DEF
    \
    \ @brief CAN_TDT1R
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DLC                        \ [0x00 : 4] DLC
    $08 constant CAN_TGT                        \ [0x08] TGT
    $10 constant CAN_TIME                       \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN_CAN_TDL1R_DEF
    \
    \ @brief CAN_TDL1R
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA0                      \ [0x00 : 8] DATA0
    $08 constant CAN_DATA1                      \ [0x08 : 8] DATA1
    $10 constant CAN_DATA2                      \ [0x10 : 8] DATA2
    $18 constant CAN_DATA3                      \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN_CAN_TDH1R_DEF
    \
    \ @brief CAN_TDH1R
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA4                      \ [0x00 : 8] DATA4
    $08 constant CAN_DATA5                      \ [0x08 : 8] DATA5
    $10 constant CAN_DATA6                      \ [0x10 : 8] DATA6
    $18 constant CAN_DATA7                      \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN_CAN_TI2R_DEF
    \
    \ @brief CAN_TI2R
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant CAN_TXRQ                       \ [0x00] TXRQ
    $01 constant CAN_RTR                        \ [0x01] RTR
    $02 constant CAN_IDE                        \ [0x02] IDE
    $03 constant CAN_EXID                       \ [0x03 : 18] EXID
    $15 constant CAN_STID                       \ [0x15 : 11] STID
  [then]


  [ifdef] CAN_CAN_TDT2R_DEF
    \
    \ @brief CAN_TDT2R
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DLC                        \ [0x00 : 4] DLC
    $08 constant CAN_TGT                        \ [0x08] TGT
    $10 constant CAN_TIME                       \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN_CAN_TDL2R_DEF
    \
    \ @brief CAN_TDL2R
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA0                      \ [0x00 : 8] DATA0
    $08 constant CAN_DATA1                      \ [0x08 : 8] DATA1
    $10 constant CAN_DATA2                      \ [0x10 : 8] DATA2
    $18 constant CAN_DATA3                      \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN_CAN_TDH2R_DEF
    \
    \ @brief CAN_TDH2R
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA4                      \ [0x00 : 8] DATA4
    $08 constant CAN_DATA5                      \ [0x08 : 8] DATA5
    $10 constant CAN_DATA6                      \ [0x10 : 8] DATA6
    $18 constant CAN_DATA7                      \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN_CAN_RI0R_DEF
    \
    \ @brief CAN_RI0R
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $01 constant CAN_RTR                        \ [0x01] RTR
    $02 constant CAN_IDE                        \ [0x02] IDE
    $03 constant CAN_EXID                       \ [0x03 : 18] EXID
    $15 constant CAN_STID                       \ [0x15 : 11] STID
  [then]


  [ifdef] CAN_CAN_RDT0R_DEF
    \
    \ @brief CAN_RDT0R
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DLC                        \ [0x00 : 4] DLC
    $08 constant CAN_FMI                        \ [0x08 : 8] FMI
    $10 constant CAN_TIME                       \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN_CAN_RDL0R_DEF
    \
    \ @brief CAN_RDL0R
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA0                      \ [0x00 : 8] DATA0
    $08 constant CAN_DATA1                      \ [0x08 : 8] DATA1
    $10 constant CAN_DATA2                      \ [0x10 : 8] DATA2
    $18 constant CAN_DATA3                      \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN_CAN_RDH0R_DEF
    \
    \ @brief CAN_RDH0R
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA4                      \ [0x00 : 8] DATA4
    $08 constant CAN_DATA5                      \ [0x08 : 8] DATA5
    $10 constant CAN_DATA6                      \ [0x10 : 8] DATA6
    $18 constant CAN_DATA7                      \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN_CAN_RI1R_DEF
    \
    \ @brief CAN_RI1R
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $01 constant CAN_RTR                        \ [0x01] RTR
    $02 constant CAN_IDE                        \ [0x02] IDE
    $03 constant CAN_EXID                       \ [0x03 : 18] EXID
    $15 constant CAN_STID                       \ [0x15 : 11] STID
  [then]


  [ifdef] CAN_CAN_RDT1R_DEF
    \
    \ @brief CAN_RDT1R
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DLC                        \ [0x00 : 4] DLC
    $08 constant CAN_FMI                        \ [0x08 : 8] FMI
    $10 constant CAN_TIME                       \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN_CAN_RDL1R_DEF
    \
    \ @brief CAN_RDL1R
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA0                      \ [0x00 : 8] DATA0
    $08 constant CAN_DATA1                      \ [0x08 : 8] DATA1
    $10 constant CAN_DATA2                      \ [0x10 : 8] DATA2
    $18 constant CAN_DATA3                      \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN_CAN_RDH1R_DEF
    \
    \ @brief CAN_RDH1R
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant CAN_DATA4                      \ [0x00 : 8] DATA4
    $08 constant CAN_DATA5                      \ [0x08 : 8] DATA5
    $10 constant CAN_DATA6                      \ [0x10 : 8] DATA6
    $18 constant CAN_DATA7                      \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN_CAN_FMR_DEF
    \
    \ @brief CAN_FMR
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FINIT                      \ [0x00] FINIT
  [then]


  [ifdef] CAN_CAN_FM1R_DEF
    \
    \ @brief CAN_FM1R
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FBM0                       \ [0x00] Filter mode
    $01 constant CAN_FBM1                       \ [0x01] Filter mode
    $02 constant CAN_FBM2                       \ [0x02] Filter mode
    $03 constant CAN_FBM3                       \ [0x03] Filter mode
    $04 constant CAN_FBM4                       \ [0x04] Filter mode
    $05 constant CAN_FBM5                       \ [0x05] Filter mode
    $06 constant CAN_FBM6                       \ [0x06] Filter mode
    $07 constant CAN_FBM7                       \ [0x07] Filter mode
    $08 constant CAN_FBM8                       \ [0x08] Filter mode
    $09 constant CAN_FBM9                       \ [0x09] Filter mode
    $0a constant CAN_FBM10                      \ [0x0a] Filter mode
    $0b constant CAN_FBM11                      \ [0x0b] Filter mode
    $0c constant CAN_FBM12                      \ [0x0c] Filter mode
    $0d constant CAN_FBM13                      \ [0x0d] Filter mode
  [then]


  [ifdef] CAN_CAN_FS1R_DEF
    \
    \ @brief CAN_FS1R
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FSC0                       \ [0x00] Filter scale configuration
    $01 constant CAN_FSC1                       \ [0x01] Filter scale configuration
    $02 constant CAN_FSC2                       \ [0x02] Filter scale configuration
    $03 constant CAN_FSC3                       \ [0x03] Filter scale configuration
    $04 constant CAN_FSC4                       \ [0x04] Filter scale configuration
    $05 constant CAN_FSC5                       \ [0x05] Filter scale configuration
    $06 constant CAN_FSC6                       \ [0x06] Filter scale configuration
    $07 constant CAN_FSC7                       \ [0x07] Filter scale configuration
    $08 constant CAN_FSC8                       \ [0x08] Filter scale configuration
    $09 constant CAN_FSC9                       \ [0x09] Filter scale configuration
    $0a constant CAN_FSC10                      \ [0x0a] Filter scale configuration
    $0b constant CAN_FSC11                      \ [0x0b] Filter scale configuration
    $0c constant CAN_FSC12                      \ [0x0c] Filter scale configuration
    $0d constant CAN_FSC13                      \ [0x0d] Filter scale configuration
  [then]


  [ifdef] CAN_CAN_FFA1R_DEF
    \
    \ @brief CAN_FFA1R
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FFA0                       \ [0x00] Filter FIFO assignment for filter 0
    $01 constant CAN_FFA1                       \ [0x01] Filter FIFO assignment for filter 1
    $02 constant CAN_FFA2                       \ [0x02] Filter FIFO assignment for filter 2
    $03 constant CAN_FFA3                       \ [0x03] Filter FIFO assignment for filter 3
    $04 constant CAN_FFA4                       \ [0x04] Filter FIFO assignment for filter 4
    $05 constant CAN_FFA5                       \ [0x05] Filter FIFO assignment for filter 5
    $06 constant CAN_FFA6                       \ [0x06] Filter FIFO assignment for filter 6
    $07 constant CAN_FFA7                       \ [0x07] Filter FIFO assignment for filter 7
    $08 constant CAN_FFA8                       \ [0x08] Filter FIFO assignment for filter 8
    $09 constant CAN_FFA9                       \ [0x09] Filter FIFO assignment for filter 9
    $0a constant CAN_FFA10                      \ [0x0a] Filter FIFO assignment for filter 10
    $0b constant CAN_FFA11                      \ [0x0b] Filter FIFO assignment for filter 11
    $0c constant CAN_FFA12                      \ [0x0c] Filter FIFO assignment for filter 12
    $0d constant CAN_FFA13                      \ [0x0d] Filter FIFO assignment for filter 13
  [then]


  [ifdef] CAN_CAN_FA1R_DEF
    \
    \ @brief CAN_FA1R
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FACT0                      \ [0x00] Filter active
    $01 constant CAN_FACT1                      \ [0x01] Filter active
    $02 constant CAN_FACT2                      \ [0x02] Filter active
    $03 constant CAN_FACT3                      \ [0x03] Filter active
    $04 constant CAN_FACT4                      \ [0x04] Filter active
    $05 constant CAN_FACT5                      \ [0x05] Filter active
    $06 constant CAN_FACT6                      \ [0x06] Filter active
    $07 constant CAN_FACT7                      \ [0x07] Filter active
    $08 constant CAN_FACT8                      \ [0x08] Filter active
    $09 constant CAN_FACT9                      \ [0x09] Filter active
    $0a constant CAN_FACT10                     \ [0x0a] Filter active
    $0b constant CAN_FACT11                     \ [0x0b] Filter active
    $0c constant CAN_FACT12                     \ [0x0c] Filter active
    $0d constant CAN_FACT13                     \ [0x0d] Filter active
  [then]


  [ifdef] CAN_F0R1_DEF
    \
    \ @brief Filter bank 0 register 1
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F0R2_DEF
    \
    \ @brief Filter bank 0 register 2
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F1R1_DEF
    \
    \ @brief Filter bank 1 register 1
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F1R2_DEF
    \
    \ @brief Filter bank 1 register 2
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F2R1_DEF
    \
    \ @brief Filter bank 2 register 1
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F2R2_DEF
    \
    \ @brief Filter bank 2 register 2
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F3R1_DEF
    \
    \ @brief Filter bank 3 register 1
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F3R2_DEF
    \
    \ @brief Filter bank 3 register 2
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F4R1_DEF
    \
    \ @brief Filter bank 4 register 1
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F4R2_DEF
    \
    \ @brief Filter bank 4 register 2
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F5R1_DEF
    \
    \ @brief Filter bank 5 register 1
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F5R2_DEF
    \
    \ @brief Filter bank 5 register 2
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F6R1_DEF
    \
    \ @brief Filter bank 6 register 1
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F6R2_DEF
    \
    \ @brief Filter bank 6 register 2
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F7R1_DEF
    \
    \ @brief Filter bank 7 register 1
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F7R2_DEF
    \
    \ @brief Filter bank 7 register 2
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F8R1_DEF
    \
    \ @brief Filter bank 8 register 1
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F8R2_DEF
    \
    \ @brief Filter bank 8 register 2
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F9R1_DEF
    \
    \ @brief Filter bank 9 register 1
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F9R2_DEF
    \
    \ @brief Filter bank 9 register 2
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F10R1_DEF
    \
    \ @brief Filter bank 10 register 1
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F10R2_DEF
    \
    \ @brief Filter bank 10 register 2
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F11R1_DEF
    \
    \ @brief Filter bank 11 register 1
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F11R2_DEF
    \
    \ @brief Filter bank 11 register 2
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F12R1_DEF
    \
    \ @brief Filter bank 4 register 1
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F12R2_DEF
    \
    \ @brief Filter bank 12 register 2
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F13R1_DEF
    \
    \ @brief Filter bank 13 register 1
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]


  [ifdef] CAN_F13R2_DEF
    \
    \ @brief Filter bank 13 register 2
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant CAN_FB0                        \ [0x00] Filter bits
    $01 constant CAN_FB1                        \ [0x01] Filter bits
    $02 constant CAN_FB2                        \ [0x02] Filter bits
    $03 constant CAN_FB3                        \ [0x03] Filter bits
    $04 constant CAN_FB4                        \ [0x04] Filter bits
    $05 constant CAN_FB5                        \ [0x05] Filter bits
    $06 constant CAN_FB6                        \ [0x06] Filter bits
    $07 constant CAN_FB7                        \ [0x07] Filter bits
    $08 constant CAN_FB8                        \ [0x08] Filter bits
    $09 constant CAN_FB9                        \ [0x09] Filter bits
    $0a constant CAN_FB10                       \ [0x0a] Filter bits
    $0b constant CAN_FB11                       \ [0x0b] Filter bits
    $0c constant CAN_FB12                       \ [0x0c] Filter bits
    $0d constant CAN_FB13                       \ [0x0d] Filter bits
    $0e constant CAN_FB14                       \ [0x0e] Filter bits
    $0f constant CAN_FB15                       \ [0x0f] Filter bits
    $10 constant CAN_FB16                       \ [0x10] Filter bits
    $11 constant CAN_FB17                       \ [0x11] Filter bits
    $12 constant CAN_FB18                       \ [0x12] Filter bits
    $13 constant CAN_FB19                       \ [0x13] Filter bits
    $14 constant CAN_FB20                       \ [0x14] Filter bits
    $15 constant CAN_FB21                       \ [0x15] Filter bits
    $16 constant CAN_FB22                       \ [0x16] Filter bits
    $17 constant CAN_FB23                       \ [0x17] Filter bits
    $18 constant CAN_FB24                       \ [0x18] Filter bits
    $19 constant CAN_FB25                       \ [0x19] Filter bits
    $1a constant CAN_FB26                       \ [0x1a] Filter bits
    $1b constant CAN_FB27                       \ [0x1b] Filter bits
    $1c constant CAN_FB28                       \ [0x1c] Filter bits
    $1d constant CAN_FB29                       \ [0x1d] Filter bits
    $1e constant CAN_FB30                       \ [0x1e] Filter bits
    $1f constant CAN_FB31                       \ [0x1f] Filter bits
  [then]

  \
  \ @brief Controller area network
  \
  $00 constant CAN_CAN_MCR              \ CAN_MCR
  $04 constant CAN_CAN_MSR              \ CAN_MSR
  $08 constant CAN_CAN_TSR              \ CAN_TSR
  $0C constant CAN_CAN_RF0R             \ CAN_RF0R
  $10 constant CAN_CAN_RF1R             \ CAN_RF1R
  $14 constant CAN_CAN_IER              \ CAN_IER
  $18 constant CAN_CAN_ESR              \ CAN_ESR
  $1C constant CAN_CAN_BTR              \ CAN_BTR
  $180 constant CAN_CAN_TI0R            \ CAN_TI0R
  $184 constant CAN_CAN_TDT0R           \ CAN_TDT0R
  $188 constant CAN_CAN_TDL0R           \ CAN_TDL0R
  $18C constant CAN_CAN_TDH0R           \ CAN_TDH0R
  $190 constant CAN_CAN_TI1R            \ CAN_TI1R
  $194 constant CAN_CAN_TDT1R           \ CAN_TDT1R
  $198 constant CAN_CAN_TDL1R           \ CAN_TDL1R
  $19C constant CAN_CAN_TDH1R           \ CAN_TDH1R
  $1A0 constant CAN_CAN_TI2R            \ CAN_TI2R
  $1A4 constant CAN_CAN_TDT2R           \ CAN_TDT2R
  $1A8 constant CAN_CAN_TDL2R           \ CAN_TDL2R
  $1AC constant CAN_CAN_TDH2R           \ CAN_TDH2R
  $1B0 constant CAN_CAN_RI0R            \ CAN_RI0R
  $1B4 constant CAN_CAN_RDT0R           \ CAN_RDT0R
  $1B8 constant CAN_CAN_RDL0R           \ CAN_RDL0R
  $1BC constant CAN_CAN_RDH0R           \ CAN_RDH0R
  $1C0 constant CAN_CAN_RI1R            \ CAN_RI1R
  $1C4 constant CAN_CAN_RDT1R           \ CAN_RDT1R
  $1C8 constant CAN_CAN_RDL1R           \ CAN_RDL1R
  $1CC constant CAN_CAN_RDH1R           \ CAN_RDH1R
  $200 constant CAN_CAN_FMR             \ CAN_FMR
  $204 constant CAN_CAN_FM1R            \ CAN_FM1R
  $20C constant CAN_CAN_FS1R            \ CAN_FS1R
  $214 constant CAN_CAN_FFA1R           \ CAN_FFA1R
  $21C constant CAN_CAN_FA1R            \ CAN_FA1R
  $240 constant CAN_F0R1                \ Filter bank 0 register 1
  $244 constant CAN_F0R2                \ Filter bank 0 register 2
  $248 constant CAN_F1R1                \ Filter bank 1 register 1
  $24C constant CAN_F1R2                \ Filter bank 1 register 2
  $250 constant CAN_F2R1                \ Filter bank 2 register 1
  $254 constant CAN_F2R2                \ Filter bank 2 register 2
  $258 constant CAN_F3R1                \ Filter bank 3 register 1
  $25C constant CAN_F3R2                \ Filter bank 3 register 2
  $260 constant CAN_F4R1                \ Filter bank 4 register 1
  $264 constant CAN_F4R2                \ Filter bank 4 register 2
  $268 constant CAN_F5R1                \ Filter bank 5 register 1
  $26C constant CAN_F5R2                \ Filter bank 5 register 2
  $270 constant CAN_F6R1                \ Filter bank 6 register 1
  $274 constant CAN_F6R2                \ Filter bank 6 register 2
  $278 constant CAN_F7R1                \ Filter bank 7 register 1
  $27C constant CAN_F7R2                \ Filter bank 7 register 2
  $280 constant CAN_F8R1                \ Filter bank 8 register 1
  $284 constant CAN_F8R2                \ Filter bank 8 register 2
  $288 constant CAN_F9R1                \ Filter bank 9 register 1
  $28C constant CAN_F9R2                \ Filter bank 9 register 2
  $290 constant CAN_F10R1               \ Filter bank 10 register 1
  $294 constant CAN_F10R2               \ Filter bank 10 register 2
  $298 constant CAN_F11R1               \ Filter bank 11 register 1
  $29C constant CAN_F11R2               \ Filter bank 11 register 2
  $2A0 constant CAN_F12R1               \ Filter bank 4 register 1
  $2A4 constant CAN_F12R2               \ Filter bank 12 register 2
  $2A8 constant CAN_F13R1               \ Filter bank 13 register 1
  $2AC constant CAN_F13R2               \ Filter bank 13 register 2

: CAN_DEF ; [then]
