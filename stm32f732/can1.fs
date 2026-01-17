\
\ @file can1.fs
\ @brief Controller area network
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CAN1_DEF

  [ifdef] CAN1_MCR_DEF
    \
    \ @brief master control register
    \ Address offset: 0x00
    \ Reset value: 0x00010002
    \
    $00 constant CAN1_INRQ                      \ [0x00] INRQ
    $01 constant CAN1_SLEEP                     \ [0x01] SLEEP
    $02 constant CAN1_TXFP                      \ [0x02] TXFP
    $03 constant CAN1_RFLM                      \ [0x03] RFLM
    $04 constant CAN1_NART                      \ [0x04] NART
    $05 constant CAN1_AWUM                      \ [0x05] AWUM
    $06 constant CAN1_ABOM                      \ [0x06] ABOM
    $07 constant CAN1_TTCM                      \ [0x07] TTCM
    $0f constant CAN1_RESET                     \ [0x0f] RESET
    $10 constant CAN1_DBF                       \ [0x10] DBF
  [then]


  [ifdef] CAN1_MSR_DEF
    \
    \ @brief master status register
    \ Address offset: 0x04
    \ Reset value: 0x00000C02
    \
    $00 constant CAN1_INAK                      \ [0x00] INAK
    $01 constant CAN1_SLAK                      \ [0x01] SLAK
    $02 constant CAN1_ERRI                      \ [0x02] ERRI
    $03 constant CAN1_WKUI                      \ [0x03] WKUI
    $04 constant CAN1_SLAKI                     \ [0x04] SLAKI
    $08 constant CAN1_TXM                       \ [0x08] TXM
    $09 constant CAN1_RXM                       \ [0x09] RXM
    $0a constant CAN1_SAMP                      \ [0x0a] SAMP
    $0b constant CAN1_RX                        \ [0x0b] RX
  [then]


  [ifdef] CAN1_TSR_DEF
    \
    \ @brief transmit status register
    \ Address offset: 0x08
    \ Reset value: 0x1C000000
    \
    $00 constant CAN1_RQCP0                     \ [0x00] RQCP0
    $01 constant CAN1_TXOK0                     \ [0x01] TXOK0
    $02 constant CAN1_ALST0                     \ [0x02] ALST0
    $03 constant CAN1_TERR0                     \ [0x03] TERR0
    $07 constant CAN1_ABRQ0                     \ [0x07] ABRQ0
    $08 constant CAN1_RQCP1                     \ [0x08] RQCP1
    $09 constant CAN1_TXOK1                     \ [0x09] TXOK1
    $0a constant CAN1_ALST1                     \ [0x0a] ALST1
    $0b constant CAN1_TERR1                     \ [0x0b] TERR1
    $0f constant CAN1_ABRQ1                     \ [0x0f] ABRQ1
    $10 constant CAN1_RQCP2                     \ [0x10] RQCP2
    $11 constant CAN1_TXOK2                     \ [0x11] TXOK2
    $12 constant CAN1_ALST2                     \ [0x12] ALST2
    $13 constant CAN1_TERR2                     \ [0x13] TERR2
    $17 constant CAN1_ABRQ2                     \ [0x17] ABRQ2
    $18 constant CAN1_CODE                      \ [0x18 : 2] CODE
    $1a constant CAN1_TME0                      \ [0x1a] Lowest priority flag for mailbox 0
    $1b constant CAN1_TME1                      \ [0x1b] Lowest priority flag for mailbox 1
    $1c constant CAN1_TME2                      \ [0x1c] Lowest priority flag for mailbox 2
    $1d constant CAN1_LOW0                      \ [0x1d] Lowest priority flag for mailbox 0
    $1e constant CAN1_LOW1                      \ [0x1e] Lowest priority flag for mailbox 1
    $1f constant CAN1_LOW2                      \ [0x1f] Lowest priority flag for mailbox 2
  [then]


  [ifdef] CAN1_RF0R_DEF
    \
    \ @brief receive FIFO 0 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FMP0                      \ [0x00 : 2] FMP0
    $03 constant CAN1_FULL0                     \ [0x03] FULL0
    $04 constant CAN1_FOVR0                     \ [0x04] FOVR0
    $05 constant CAN1_RFOM0                     \ [0x05] RFOM0
  [then]


  [ifdef] CAN1_RF1R_DEF
    \
    \ @brief receive FIFO 1 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FMP1                      \ [0x00 : 2] FMP1
    $03 constant CAN1_FULL1                     \ [0x03] FULL1
    $04 constant CAN1_FOVR1                     \ [0x04] FOVR1
    $05 constant CAN1_RFOM1                     \ [0x05] RFOM1
  [then]


  [ifdef] CAN1_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_TMEIE                     \ [0x00] TMEIE
    $01 constant CAN1_FMPIE0                    \ [0x01] FMPIE0
    $02 constant CAN1_FFIE0                     \ [0x02] FFIE0
    $03 constant CAN1_FOVIE0                    \ [0x03] FOVIE0
    $04 constant CAN1_FMPIE1                    \ [0x04] FMPIE1
    $05 constant CAN1_FFIE1                     \ [0x05] FFIE1
    $06 constant CAN1_FOVIE1                    \ [0x06] FOVIE1
    $08 constant CAN1_EWGIE                     \ [0x08] EWGIE
    $09 constant CAN1_EPVIE                     \ [0x09] EPVIE
    $0a constant CAN1_BOFIE                     \ [0x0a] BOFIE
    $0b constant CAN1_LECIE                     \ [0x0b] LECIE
    $0f constant CAN1_ERRIE                     \ [0x0f] ERRIE
    $10 constant CAN1_WKUIE                     \ [0x10] WKUIE
    $11 constant CAN1_SLKIE                     \ [0x11] SLKIE
  [then]


  [ifdef] CAN1_ESR_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_EWGF                      \ [0x00] EWGF
    $01 constant CAN1_EPVF                      \ [0x01] EPVF
    $02 constant CAN1_BOFF                      \ [0x02] BOFF
    $04 constant CAN1_LEC                       \ [0x04 : 3] LEC
    $10 constant CAN1_TEC                       \ [0x10 : 8] TEC
    $18 constant CAN1_REC                       \ [0x18 : 8] REC
  [then]


  [ifdef] CAN1_BTR_DEF
    \
    \ @brief bit timing register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_BRP                       \ [0x00 : 10] BRP
    $10 constant CAN1_TS1                       \ [0x10 : 4] TS1
    $14 constant CAN1_TS2                       \ [0x14 : 3] TS2
    $18 constant CAN1_SJW                       \ [0x18 : 2] SJW
    $1e constant CAN1_LBKM                      \ [0x1e] LBKM
    $1f constant CAN1_SILM                      \ [0x1f] SILM
  [then]


  [ifdef] CAN1_TI0R_DEF
    \
    \ @brief TX mailbox identifier register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_TXRQ                      \ [0x00] TXRQ
    $01 constant CAN1_RTR                       \ [0x01] RTR
    $02 constant CAN1_IDE                       \ [0x02] IDE
    $03 constant CAN1_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN1_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN1_TDT0R_DEF
    \
    \ @brief mailbox data length control and time stamp register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN1_TGT                       \ [0x08] TGT
    $10 constant CAN1_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN1_TDL0R_DEF
    \
    \ @brief mailbox data low register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN1_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN1_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN1_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN1_TDH0R_DEF
    \
    \ @brief mailbox data high register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN1_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN1_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN1_DATA7                     \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN1_TI1R_DEF
    \
    \ @brief mailbox identifier register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_TXRQ                      \ [0x00] TXRQ
    $01 constant CAN1_RTR                       \ [0x01] RTR
    $02 constant CAN1_IDE                       \ [0x02] IDE
    $03 constant CAN1_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN1_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN1_TDT1R_DEF
    \
    \ @brief mailbox data length control and time stamp register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN1_TGT                       \ [0x08] TGT
    $10 constant CAN1_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN1_TDL1R_DEF
    \
    \ @brief mailbox data low register
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN1_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN1_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN1_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN1_TDH1R_DEF
    \
    \ @brief mailbox data high register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN1_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN1_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN1_DATA7                     \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN1_TI2R_DEF
    \
    \ @brief mailbox identifier register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_TXRQ                      \ [0x00] TXRQ
    $01 constant CAN1_RTR                       \ [0x01] RTR
    $02 constant CAN1_IDE                       \ [0x02] IDE
    $03 constant CAN1_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN1_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN1_TDT2R_DEF
    \
    \ @brief mailbox data length control and time stamp register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN1_TGT                       \ [0x08] TGT
    $10 constant CAN1_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN1_TDL2R_DEF
    \
    \ @brief mailbox data low register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN1_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN1_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN1_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN1_TDH2R_DEF
    \
    \ @brief mailbox data high register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN1_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN1_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN1_DATA7                     \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN1_RI0R_DEF
    \
    \ @brief receive FIFO mailbox identifier register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $01 constant CAN1_RTR                       \ [0x01] RTR
    $02 constant CAN1_IDE                       \ [0x02] IDE
    $03 constant CAN1_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN1_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN1_RDT0R_DEF
    \
    \ @brief mailbox data high register
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN1_FMI                       \ [0x08 : 8] FMI
    $10 constant CAN1_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN1_RDL0R_DEF
    \
    \ @brief mailbox data high register
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN1_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN1_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN1_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN1_RDH0R_DEF
    \
    \ @brief receive FIFO mailbox data high register
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN1_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN1_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN1_DATA7                     \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN1_RI1R_DEF
    \
    \ @brief mailbox data high register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $01 constant CAN1_RTR                       \ [0x01] RTR
    $02 constant CAN1_IDE                       \ [0x02] IDE
    $03 constant CAN1_EXID                      \ [0x03 : 18] EXID
    $15 constant CAN1_STID                      \ [0x15 : 11] STID
  [then]


  [ifdef] CAN1_RDT1R_DEF
    \
    \ @brief mailbox data high register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DLC                       \ [0x00 : 4] DLC
    $08 constant CAN1_FMI                       \ [0x08 : 8] FMI
    $10 constant CAN1_TIME                      \ [0x10 : 16] TIME
  [then]


  [ifdef] CAN1_RDL1R_DEF
    \
    \ @brief mailbox data high register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA0                     \ [0x00 : 8] DATA0
    $08 constant CAN1_DATA1                     \ [0x08 : 8] DATA1
    $10 constant CAN1_DATA2                     \ [0x10 : 8] DATA2
    $18 constant CAN1_DATA3                     \ [0x18 : 8] DATA3
  [then]


  [ifdef] CAN1_RDH1R_DEF
    \
    \ @brief mailbox data high register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_DATA4                     \ [0x00 : 8] DATA4
    $08 constant CAN1_DATA5                     \ [0x08 : 8] DATA5
    $10 constant CAN1_DATA6                     \ [0x10 : 8] DATA6
    $18 constant CAN1_DATA7                     \ [0x18 : 8] DATA7
  [then]


  [ifdef] CAN1_FMR_DEF
    \
    \ @brief filter master register
    \ Address offset: 0x200
    \ Reset value: 0x2A1C0E01
    \
    $00 constant CAN1_FINIT                     \ [0x00] FINIT
  [then]


  [ifdef] CAN1_FM1R_DEF
    \
    \ @brief filter mode register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FBM0                      \ [0x00] Filter mode
    $01 constant CAN1_FBM1                      \ [0x01] Filter mode
    $02 constant CAN1_FBM2                      \ [0x02] Filter mode
    $03 constant CAN1_FBM3                      \ [0x03] Filter mode
    $04 constant CAN1_FBM4                      \ [0x04] Filter mode
    $05 constant CAN1_FBM5                      \ [0x05] Filter mode
    $06 constant CAN1_FBM6                      \ [0x06] Filter mode
    $07 constant CAN1_FBM7                      \ [0x07] Filter mode
    $08 constant CAN1_FBM8                      \ [0x08] Filter mode
    $09 constant CAN1_FBM9                      \ [0x09] Filter mode
    $0a constant CAN1_FBM10                     \ [0x0a] Filter mode
    $0b constant CAN1_FBM11                     \ [0x0b] Filter mode
    $0c constant CAN1_FBM12                     \ [0x0c] Filter mode
    $0d constant CAN1_FBM13                     \ [0x0d] Filter mode
  [then]


  [ifdef] CAN1_FS1R_DEF
    \
    \ @brief filter scale register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FSC0                      \ [0x00] Filter scale configuration
    $01 constant CAN1_FSC1                      \ [0x01] Filter scale configuration
    $02 constant CAN1_FSC2                      \ [0x02] Filter scale configuration
    $03 constant CAN1_FSC3                      \ [0x03] Filter scale configuration
    $04 constant CAN1_FSC4                      \ [0x04] Filter scale configuration
    $05 constant CAN1_FSC5                      \ [0x05] Filter scale configuration
    $06 constant CAN1_FSC6                      \ [0x06] Filter scale configuration
    $07 constant CAN1_FSC7                      \ [0x07] Filter scale configuration
    $08 constant CAN1_FSC8                      \ [0x08] Filter scale configuration
    $09 constant CAN1_FSC9                      \ [0x09] Filter scale configuration
    $0a constant CAN1_FSC10                     \ [0x0a] Filter scale configuration
    $0b constant CAN1_FSC11                     \ [0x0b] Filter scale configuration
    $0c constant CAN1_FSC12                     \ [0x0c] Filter scale configuration
    $0d constant CAN1_FSC13                     \ [0x0d] Filter scale configuration
  [then]


  [ifdef] CAN1_FFA1R_DEF
    \
    \ @brief filter FIFO assignment register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FFA0                      \ [0x00] Filter FIFO assignment for filter 0
    $01 constant CAN1_FFA1                      \ [0x01] Filter FIFO assignment for filter 1
    $02 constant CAN1_FFA2                      \ [0x02] Filter FIFO assignment for filter 2
    $03 constant CAN1_FFA3                      \ [0x03] Filter FIFO assignment for filter 3
    $04 constant CAN1_FFA4                      \ [0x04] Filter FIFO assignment for filter 4
    $05 constant CAN1_FFA5                      \ [0x05] Filter FIFO assignment for filter 5
    $06 constant CAN1_FFA6                      \ [0x06] Filter FIFO assignment for filter 6
    $07 constant CAN1_FFA7                      \ [0x07] Filter FIFO assignment for filter 7
    $08 constant CAN1_FFA8                      \ [0x08] Filter FIFO assignment for filter 8
    $09 constant CAN1_FFA9                      \ [0x09] Filter FIFO assignment for filter 9
    $0a constant CAN1_FFA10                     \ [0x0a] Filter FIFO assignment for filter 10
    $0b constant CAN1_FFA11                     \ [0x0b] Filter FIFO assignment for filter 11
    $0c constant CAN1_FFA12                     \ [0x0c] Filter FIFO assignment for filter 12
    $0d constant CAN1_FFA13                     \ [0x0d] Filter FIFO assignment for filter 13
  [then]


  [ifdef] CAN1_FA1R_DEF
    \
    \ @brief filter activation register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FACT0                     \ [0x00] Filter active
    $01 constant CAN1_FACT1                     \ [0x01] Filter active
    $02 constant CAN1_FACT2                     \ [0x02] Filter active
    $03 constant CAN1_FACT3                     \ [0x03] Filter active
    $04 constant CAN1_FACT4                     \ [0x04] Filter active
    $05 constant CAN1_FACT5                     \ [0x05] Filter active
    $06 constant CAN1_FACT6                     \ [0x06] Filter active
    $07 constant CAN1_FACT7                     \ [0x07] Filter active
    $08 constant CAN1_FACT8                     \ [0x08] Filter active
    $09 constant CAN1_FACT9                     \ [0x09] Filter active
    $0a constant CAN1_FACT10                    \ [0x0a] Filter active
    $0b constant CAN1_FACT11                    \ [0x0b] Filter active
    $0c constant CAN1_FACT12                    \ [0x0c] Filter active
    $0d constant CAN1_FACT13                    \ [0x0d] Filter active
  [then]


  [ifdef] CAN1_F0R1_DEF
    \
    \ @brief Filter bank 0 register 1
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F0R2_DEF
    \
    \ @brief Filter bank 0 register 2
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F1R1_DEF
    \
    \ @brief Filter bank 1 register 1
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F1R2_DEF
    \
    \ @brief Filter bank 1 register 2
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F2R1_DEF
    \
    \ @brief Filter bank 2 register 1
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F2R2_DEF
    \
    \ @brief Filter bank 2 register 2
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F3R1_DEF
    \
    \ @brief Filter bank 3 register 1
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F3R2_DEF
    \
    \ @brief Filter bank 3 register 2
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F4R1_DEF
    \
    \ @brief Filter bank 4 register 1
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F4R2_DEF
    \
    \ @brief Filter bank 4 register 2
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F5R1_DEF
    \
    \ @brief Filter bank 5 register 1
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F5R2_DEF
    \
    \ @brief Filter bank 5 register 2
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F6R1_DEF
    \
    \ @brief Filter bank 6 register 1
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F6R2_DEF
    \
    \ @brief Filter bank 6 register 2
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F7R1_DEF
    \
    \ @brief Filter bank 7 register 1
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F7R2_DEF
    \
    \ @brief Filter bank 7 register 2
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F8R1_DEF
    \
    \ @brief Filter bank 8 register 1
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F8R2_DEF
    \
    \ @brief Filter bank 8 register 2
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F9R1_DEF
    \
    \ @brief Filter bank 9 register 1
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F9R2_DEF
    \
    \ @brief Filter bank 9 register 2
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F10R1_DEF
    \
    \ @brief Filter bank 10 register 1
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F10R2_DEF
    \
    \ @brief Filter bank 10 register 2
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F11R1_DEF
    \
    \ @brief Filter bank 11 register 1
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F11R2_DEF
    \
    \ @brief Filter bank 11 register 2
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F12R1_DEF
    \
    \ @brief Filter bank 4 register 1
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F12R2_DEF
    \
    \ @brief Filter bank 12 register 2
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F13R1_DEF
    \
    \ @brief Filter bank 13 register 1
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F13R2_DEF
    \
    \ @brief Filter bank 13 register 2
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F14R1_DEF
    \
    \ @brief Filter bank 14 register 1
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F14R2_DEF
    \
    \ @brief Filter bank 14 register 2
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F15R1_DEF
    \
    \ @brief Filter bank 15 register 1
    \ Address offset: 0x2B8
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F15R2_DEF
    \
    \ @brief Filter bank 15 register 2
    \ Address offset: 0x2BC
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F16R1_DEF
    \
    \ @brief Filter bank 16 register 1
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F16R2_DEF
    \
    \ @brief Filter bank 16 register 2
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F17R1_DEF
    \
    \ @brief Filter bank 17 register 1
    \ Address offset: 0x2C8
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F17R2_DEF
    \
    \ @brief Filter bank 17 register 2
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F18R1_DEF
    \
    \ @brief Filter bank 18 register 1
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F18R2_DEF
    \
    \ @brief Filter bank 18 register 2
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F19R1_DEF
    \
    \ @brief Filter bank 19 register 1
    \ Address offset: 0x2D8
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F19R2_DEF
    \
    \ @brief Filter bank 19 register 2
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F20R1_DEF
    \
    \ @brief Filter bank 20 register 1
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F20R2_DEF
    \
    \ @brief Filter bank 20 register 2
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F21R1_DEF
    \
    \ @brief Filter bank 21 register 1
    \ Address offset: 0x2E8
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F21R2_DEF
    \
    \ @brief Filter bank 21 register 2
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F22R1_DEF
    \
    \ @brief Filter bank 22 register 1
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F22R2_DEF
    \
    \ @brief Filter bank 22 register 2
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F23R1_DEF
    \
    \ @brief Filter bank 23 register 1
    \ Address offset: 0x2F8
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F23R2_DEF
    \
    \ @brief Filter bank 23 register 2
    \ Address offset: 0x2FC
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F24R1_DEF
    \
    \ @brief Filter bank 24 register 1
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F24R2_DEF
    \
    \ @brief Filter bank 24 register 2
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F25R1_DEF
    \
    \ @brief Filter bank 25 register 1
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F25R2_DEF
    \
    \ @brief Filter bank 25 register 2
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F26R1_DEF
    \
    \ @brief Filter bank 26 register 1
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F26R2_DEF
    \
    \ @brief Filter bank 26 register 2
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F27R1_DEF
    \
    \ @brief Filter bank 27 register 1
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]


  [ifdef] CAN1_F27R2_DEF
    \
    \ @brief Filter bank 27 register 2
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant CAN1_FB0                       \ [0x00] Filter bits
    $01 constant CAN1_FB1                       \ [0x01] Filter bits
    $02 constant CAN1_FB2                       \ [0x02] Filter bits
    $03 constant CAN1_FB3                       \ [0x03] Filter bits
    $04 constant CAN1_FB4                       \ [0x04] Filter bits
    $05 constant CAN1_FB5                       \ [0x05] Filter bits
    $06 constant CAN1_FB6                       \ [0x06] Filter bits
    $07 constant CAN1_FB7                       \ [0x07] Filter bits
    $08 constant CAN1_FB8                       \ [0x08] Filter bits
    $09 constant CAN1_FB9                       \ [0x09] Filter bits
    $0a constant CAN1_FB10                      \ [0x0a] Filter bits
    $0b constant CAN1_FB11                      \ [0x0b] Filter bits
    $0c constant CAN1_FB12                      \ [0x0c] Filter bits
    $0d constant CAN1_FB13                      \ [0x0d] Filter bits
    $0e constant CAN1_FB14                      \ [0x0e] Filter bits
    $0f constant CAN1_FB15                      \ [0x0f] Filter bits
    $10 constant CAN1_FB16                      \ [0x10] Filter bits
    $11 constant CAN1_FB17                      \ [0x11] Filter bits
    $12 constant CAN1_FB18                      \ [0x12] Filter bits
    $13 constant CAN1_FB19                      \ [0x13] Filter bits
    $14 constant CAN1_FB20                      \ [0x14] Filter bits
    $15 constant CAN1_FB21                      \ [0x15] Filter bits
    $16 constant CAN1_FB22                      \ [0x16] Filter bits
    $17 constant CAN1_FB23                      \ [0x17] Filter bits
    $18 constant CAN1_FB24                      \ [0x18] Filter bits
    $19 constant CAN1_FB25                      \ [0x19] Filter bits
    $1a constant CAN1_FB26                      \ [0x1a] Filter bits
    $1b constant CAN1_FB27                      \ [0x1b] Filter bits
    $1c constant CAN1_FB28                      \ [0x1c] Filter bits
    $1d constant CAN1_FB29                      \ [0x1d] Filter bits
    $1e constant CAN1_FB30                      \ [0x1e] Filter bits
    $1f constant CAN1_FB31                      \ [0x1f] Filter bits
  [then]

  \
  \ @brief Controller area network
  \
  $00 constant CAN1_MCR                 \ master control register
  $04 constant CAN1_MSR                 \ master status register
  $08 constant CAN1_TSR                 \ transmit status register
  $0C constant CAN1_RF0R                \ receive FIFO 0 register
  $10 constant CAN1_RF1R                \ receive FIFO 1 register
  $14 constant CAN1_IER                 \ interrupt enable register
  $18 constant CAN1_ESR                 \ interrupt enable register
  $1C constant CAN1_BTR                 \ bit timing register
  $180 constant CAN1_TI0R               \ TX mailbox identifier register
  $184 constant CAN1_TDT0R              \ mailbox data length control and time stamp register
  $188 constant CAN1_TDL0R              \ mailbox data low register
  $18C constant CAN1_TDH0R              \ mailbox data high register
  $190 constant CAN1_TI1R               \ mailbox identifier register
  $194 constant CAN1_TDT1R              \ mailbox data length control and time stamp register
  $198 constant CAN1_TDL1R              \ mailbox data low register
  $19C constant CAN1_TDH1R              \ mailbox data high register
  $1A0 constant CAN1_TI2R               \ mailbox identifier register
  $1A4 constant CAN1_TDT2R              \ mailbox data length control and time stamp register
  $1A8 constant CAN1_TDL2R              \ mailbox data low register
  $1AC constant CAN1_TDH2R              \ mailbox data high register
  $1B0 constant CAN1_RI0R               \ receive FIFO mailbox identifier register
  $1B4 constant CAN1_RDT0R              \ mailbox data high register
  $1B8 constant CAN1_RDL0R              \ mailbox data high register
  $1BC constant CAN1_RDH0R              \ receive FIFO mailbox data high register
  $1C0 constant CAN1_RI1R               \ mailbox data high register
  $1C4 constant CAN1_RDT1R              \ mailbox data high register
  $1C8 constant CAN1_RDL1R              \ mailbox data high register
  $1CC constant CAN1_RDH1R              \ mailbox data high register
  $200 constant CAN1_FMR                \ filter master register
  $204 constant CAN1_FM1R               \ filter mode register
  $20C constant CAN1_FS1R               \ filter scale register
  $214 constant CAN1_FFA1R              \ filter FIFO assignment register
  $21C constant CAN1_FA1R               \ filter activation register
  $240 constant CAN1_F0R1               \ Filter bank 0 register 1
  $244 constant CAN1_F0R2               \ Filter bank 0 register 2
  $248 constant CAN1_F1R1               \ Filter bank 1 register 1
  $24C constant CAN1_F1R2               \ Filter bank 1 register 2
  $250 constant CAN1_F2R1               \ Filter bank 2 register 1
  $254 constant CAN1_F2R2               \ Filter bank 2 register 2
  $258 constant CAN1_F3R1               \ Filter bank 3 register 1
  $25C constant CAN1_F3R2               \ Filter bank 3 register 2
  $260 constant CAN1_F4R1               \ Filter bank 4 register 1
  $264 constant CAN1_F4R2               \ Filter bank 4 register 2
  $268 constant CAN1_F5R1               \ Filter bank 5 register 1
  $26C constant CAN1_F5R2               \ Filter bank 5 register 2
  $270 constant CAN1_F6R1               \ Filter bank 6 register 1
  $274 constant CAN1_F6R2               \ Filter bank 6 register 2
  $278 constant CAN1_F7R1               \ Filter bank 7 register 1
  $27C constant CAN1_F7R2               \ Filter bank 7 register 2
  $280 constant CAN1_F8R1               \ Filter bank 8 register 1
  $284 constant CAN1_F8R2               \ Filter bank 8 register 2
  $288 constant CAN1_F9R1               \ Filter bank 9 register 1
  $28C constant CAN1_F9R2               \ Filter bank 9 register 2
  $290 constant CAN1_F10R1              \ Filter bank 10 register 1
  $294 constant CAN1_F10R2              \ Filter bank 10 register 2
  $298 constant CAN1_F11R1              \ Filter bank 11 register 1
  $29C constant CAN1_F11R2              \ Filter bank 11 register 2
  $2A0 constant CAN1_F12R1              \ Filter bank 4 register 1
  $2A4 constant CAN1_F12R2              \ Filter bank 12 register 2
  $2A8 constant CAN1_F13R1              \ Filter bank 13 register 1
  $2AC constant CAN1_F13R2              \ Filter bank 13 register 2
  $2B0 constant CAN1_F14R1              \ Filter bank 14 register 1
  $2B4 constant CAN1_F14R2              \ Filter bank 14 register 2
  $2B8 constant CAN1_F15R1              \ Filter bank 15 register 1
  $2BC constant CAN1_F15R2              \ Filter bank 15 register 2
  $2C0 constant CAN1_F16R1              \ Filter bank 16 register 1
  $2C4 constant CAN1_F16R2              \ Filter bank 16 register 2
  $2C8 constant CAN1_F17R1              \ Filter bank 17 register 1
  $2CC constant CAN1_F17R2              \ Filter bank 17 register 2
  $2D0 constant CAN1_F18R1              \ Filter bank 18 register 1
  $2D4 constant CAN1_F18R2              \ Filter bank 18 register 2
  $2D8 constant CAN1_F19R1              \ Filter bank 19 register 1
  $2DC constant CAN1_F19R2              \ Filter bank 19 register 2
  $2E0 constant CAN1_F20R1              \ Filter bank 20 register 1
  $2E4 constant CAN1_F20R2              \ Filter bank 20 register 2
  $2E8 constant CAN1_F21R1              \ Filter bank 21 register 1
  $2EC constant CAN1_F21R2              \ Filter bank 21 register 2
  $2F0 constant CAN1_F22R1              \ Filter bank 22 register 1
  $2F4 constant CAN1_F22R2              \ Filter bank 22 register 2
  $2F8 constant CAN1_F23R1              \ Filter bank 23 register 1
  $2FC constant CAN1_F23R2              \ Filter bank 23 register 2
  $300 constant CAN1_F24R1              \ Filter bank 24 register 1
  $304 constant CAN1_F24R2              \ Filter bank 24 register 2
  $308 constant CAN1_F25R1              \ Filter bank 25 register 1
  $30C constant CAN1_F25R2              \ Filter bank 25 register 2
  $310 constant CAN1_F26R1              \ Filter bank 26 register 1
  $314 constant CAN1_F26R2              \ Filter bank 26 register 2
  $318 constant CAN1_F27R1              \ Filter bank 27 register 1
  $31C constant CAN1_F27R2              \ Filter bank 27 register 2

: CAN1_DEF ; [then]
