\
\ @file can2.fs
\ @brief Controller area network
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CAN_MCR
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant CAN2_CAN_MCR_INRQ                                \ INRQ
$00000002 constant CAN2_CAN_MCR_SLEEP                               \ SLEEP
$00000004 constant CAN2_CAN_MCR_TXFP                                \ TXFP
$00000008 constant CAN2_CAN_MCR_RFLM                                \ RFLM
$00000010 constant CAN2_CAN_MCR_NART                                \ NART
$00000020 constant CAN2_CAN_MCR_AWUM                                \ AWUM
$00000040 constant CAN2_CAN_MCR_ABOM                                \ ABOM
$00000080 constant CAN2_CAN_MCR_TTCM                                \ TTCM
$00008000 constant CAN2_CAN_MCR_RESET                               \ RESET
$00010000 constant CAN2_CAN_MCR_DBF                                 \ DBF


\
\ @brief CAN_MSR
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant CAN2_CAN_MSR_INAK                                \ INAK
$00000002 constant CAN2_CAN_MSR_SLAK                                \ SLAK
$00000004 constant CAN2_CAN_MSR_ERRI                                \ ERRI
$00000008 constant CAN2_CAN_MSR_WKUI                                \ WKUI
$00000010 constant CAN2_CAN_MSR_SLAKI                               \ SLAKI
$00000100 constant CAN2_CAN_MSR_TXM                                 \ TXM
$00000200 constant CAN2_CAN_MSR_RXM                                 \ RXM
$00000400 constant CAN2_CAN_MSR_SAMP                                \ SAMP
$00000800 constant CAN2_CAN_MSR_RX                                  \ RX


\
\ @brief CAN_TSR
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant CAN2_CAN_TSR_RQCP0                               \ RQCP0
$00000002 constant CAN2_CAN_TSR_TXOK0                               \ TXOK0
$00000004 constant CAN2_CAN_TSR_ALST0                               \ ALST0
$00000008 constant CAN2_CAN_TSR_TERR0                               \ TERR0
$00000080 constant CAN2_CAN_TSR_ABRQ0                               \ ABRQ0
$00000100 constant CAN2_CAN_TSR_RQCP1                               \ RQCP1
$00000200 constant CAN2_CAN_TSR_TXOK1                               \ TXOK1
$00000400 constant CAN2_CAN_TSR_ALST1                               \ ALST1
$00000800 constant CAN2_CAN_TSR_TERR1                               \ TERR1
$00008000 constant CAN2_CAN_TSR_ABRQ1                               \ ABRQ1
$00010000 constant CAN2_CAN_TSR_RQCP2                               \ RQCP2
$00020000 constant CAN2_CAN_TSR_TXOK2                               \ TXOK2
$00040000 constant CAN2_CAN_TSR_ALST2                               \ ALST2
$00080000 constant CAN2_CAN_TSR_TERR2                               \ TERR2
$00800000 constant CAN2_CAN_TSR_ABRQ2                               \ ABRQ2
$03000000 constant CAN2_CAN_TSR_CODE                                \ CODE
$04000000 constant CAN2_CAN_TSR_TME0                                \ Lowest priority flag for mailbox 0
$08000000 constant CAN2_CAN_TSR_TME1                                \ Lowest priority flag for mailbox 1
$10000000 constant CAN2_CAN_TSR_TME2                                \ Lowest priority flag for mailbox 2
$20000000 constant CAN2_CAN_TSR_LOW0                                \ Lowest priority flag for mailbox 0
$40000000 constant CAN2_CAN_TSR_LOW1                                \ Lowest priority flag for mailbox 1
$80000000 constant CAN2_CAN_TSR_LOW2                                \ Lowest priority flag for mailbox 2


\
\ @brief CAN_RF0R
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant CAN2_CAN_RF0R_FMP0                               \ FMP0
$00000008 constant CAN2_CAN_RF0R_FULL0                              \ FULL0
$00000010 constant CAN2_CAN_RF0R_FOVR0                              \ FOVR0
$00000020 constant CAN2_CAN_RF0R_RFOM0                              \ RFOM0


\
\ @brief CAN_RF1R
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000003 constant CAN2_CAN_RF1R_FMP1                               \ FMP1
$00000008 constant CAN2_CAN_RF1R_FULL1                              \ FULL1
$00000010 constant CAN2_CAN_RF1R_FOVR1                              \ FOVR1
$00000020 constant CAN2_CAN_RF1R_RFOM1                              \ RFOM1


\
\ @brief CAN_IER
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CAN2_CAN_IER_TMEIE                               \ TMEIE
$00000002 constant CAN2_CAN_IER_FMPIE0                              \ FMPIE0
$00000004 constant CAN2_CAN_IER_FFIE0                               \ FFIE0
$00000008 constant CAN2_CAN_IER_FOVIE0                              \ FOVIE0
$00000010 constant CAN2_CAN_IER_FMPIE1                              \ FMPIE1
$00000020 constant CAN2_CAN_IER_FFIE1                               \ FFIE1
$00000040 constant CAN2_CAN_IER_FOVIE1                              \ FOVIE1
$00000100 constant CAN2_CAN_IER_EWGIE                               \ EWGIE
$00000200 constant CAN2_CAN_IER_EPVIE                               \ EPVIE
$00000400 constant CAN2_CAN_IER_BOFIE                               \ BOFIE
$00000800 constant CAN2_CAN_IER_LECIE                               \ LECIE
$00008000 constant CAN2_CAN_IER_ERRIE                               \ ERRIE
$00010000 constant CAN2_CAN_IER_WKUIE                               \ WKUIE
$00020000 constant CAN2_CAN_IER_SLKIE                               \ SLKIE


\
\ @brief CAN_ESR
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant CAN2_CAN_ESR_EWGF                                \ EWGF
$00000002 constant CAN2_CAN_ESR_EPVF                                \ EPVF
$00000004 constant CAN2_CAN_ESR_BOFF                                \ BOFF
$00000070 constant CAN2_CAN_ESR_LEC                                 \ LEC
$00ff0000 constant CAN2_CAN_ESR_TEC                                 \ TEC
$ff000000 constant CAN2_CAN_ESR_REC                                 \ REC


\
\ @brief CAN_BTR
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000003ff constant CAN2_CAN_BTR_BRP                                 \ BRP
$000f0000 constant CAN2_CAN_BTR_TS1                                 \ TS1
$00700000 constant CAN2_CAN_BTR_TS2                                 \ TS2
$03000000 constant CAN2_CAN_BTR_SJW                                 \ SJW
$40000000 constant CAN2_CAN_BTR_LBKM                                \ LBKM
$80000000 constant CAN2_CAN_BTR_SILM                                \ SILM


\
\ @brief CAN_TI0R
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant CAN2_CAN_TI0R_TXRQ                               \ TXRQ
$00000002 constant CAN2_CAN_TI0R_RTR                                \ RTR
$00000004 constant CAN2_CAN_TI0R_IDE                                \ IDE
$001ffff8 constant CAN2_CAN_TI0R_EXID                               \ EXID
$ffe00000 constant CAN2_CAN_TI0R_STID                               \ STID


\
\ @brief CAN_TDT0R
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$0000000f constant CAN2_CAN_TDT0R_DLC                               \ DLC
$00000100 constant CAN2_CAN_TDT0R_TGT                               \ TGT
$ffff0000 constant CAN2_CAN_TDT0R_TIME                              \ TIME


\
\ @brief CAN_TDL0R
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_TDL0R_DATA0                             \ DATA0
$0000ff00 constant CAN2_CAN_TDL0R_DATA1                             \ DATA1
$00ff0000 constant CAN2_CAN_TDL0R_DATA2                             \ DATA2
$ff000000 constant CAN2_CAN_TDL0R_DATA3                             \ DATA3


\
\ @brief CAN_TDH0R
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_TDH0R_DATA4                             \ DATA4
$0000ff00 constant CAN2_CAN_TDH0R_DATA5                             \ DATA5
$00ff0000 constant CAN2_CAN_TDH0R_DATA6                             \ DATA6
$ff000000 constant CAN2_CAN_TDH0R_DATA7                             \ DATA7


\
\ @brief CAN_TI1R
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000001 constant CAN2_CAN_TI1R_TXRQ                               \ TXRQ
$00000002 constant CAN2_CAN_TI1R_RTR                                \ RTR
$00000004 constant CAN2_CAN_TI1R_IDE                                \ IDE
$001ffff8 constant CAN2_CAN_TI1R_EXID                               \ EXID
$ffe00000 constant CAN2_CAN_TI1R_STID                               \ STID


\
\ @brief CAN_TDT1R
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0000000f constant CAN2_CAN_TDT1R_DLC                               \ DLC
$00000100 constant CAN2_CAN_TDT1R_TGT                               \ TGT
$ffff0000 constant CAN2_CAN_TDT1R_TIME                              \ TIME


\
\ @brief CAN_TDL1R
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_TDL1R_DATA0                             \ DATA0
$0000ff00 constant CAN2_CAN_TDL1R_DATA1                             \ DATA1
$00ff0000 constant CAN2_CAN_TDL1R_DATA2                             \ DATA2
$ff000000 constant CAN2_CAN_TDL1R_DATA3                             \ DATA3


\
\ @brief CAN_TDH1R
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_TDH1R_DATA4                             \ DATA4
$0000ff00 constant CAN2_CAN_TDH1R_DATA5                             \ DATA5
$00ff0000 constant CAN2_CAN_TDH1R_DATA6                             \ DATA6
$ff000000 constant CAN2_CAN_TDH1R_DATA7                             \ DATA7


\
\ @brief CAN_TI2R
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000001 constant CAN2_CAN_TI2R_TXRQ                               \ TXRQ
$00000002 constant CAN2_CAN_TI2R_RTR                                \ RTR
$00000004 constant CAN2_CAN_TI2R_IDE                                \ IDE
$001ffff8 constant CAN2_CAN_TI2R_EXID                               \ EXID
$ffe00000 constant CAN2_CAN_TI2R_STID                               \ STID


\
\ @brief CAN_TDT2R
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000000f constant CAN2_CAN_TDT2R_DLC                               \ DLC
$00000100 constant CAN2_CAN_TDT2R_TGT                               \ TGT
$ffff0000 constant CAN2_CAN_TDT2R_TIME                              \ TIME


\
\ @brief CAN_TDL2R
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_TDL2R_DATA0                             \ DATA0
$0000ff00 constant CAN2_CAN_TDL2R_DATA1                             \ DATA1
$00ff0000 constant CAN2_CAN_TDL2R_DATA2                             \ DATA2
$ff000000 constant CAN2_CAN_TDL2R_DATA3                             \ DATA3


\
\ @brief CAN_TDH2R
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_TDH2R_DATA4                             \ DATA4
$0000ff00 constant CAN2_CAN_TDH2R_DATA5                             \ DATA5
$00ff0000 constant CAN2_CAN_TDH2R_DATA6                             \ DATA6
$ff000000 constant CAN2_CAN_TDH2R_DATA7                             \ DATA7


\
\ @brief CAN_RI0R
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000002 constant CAN2_CAN_RI0R_RTR                                \ RTR
$00000004 constant CAN2_CAN_RI0R_IDE                                \ IDE
$001ffff8 constant CAN2_CAN_RI0R_EXID                               \ EXID
$ffe00000 constant CAN2_CAN_RI0R_STID                               \ STID


\
\ @brief CAN_RDT0R
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$0000000f constant CAN2_CAN_RDT0R_DLC                               \ DLC
$0000ff00 constant CAN2_CAN_RDT0R_FMI                               \ FMI
$ffff0000 constant CAN2_CAN_RDT0R_TIME                              \ TIME


\
\ @brief CAN_RDL0R
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_RDL0R_DATA0                             \ DATA0
$0000ff00 constant CAN2_CAN_RDL0R_DATA1                             \ DATA1
$00ff0000 constant CAN2_CAN_RDL0R_DATA2                             \ DATA2
$ff000000 constant CAN2_CAN_RDL0R_DATA3                             \ DATA3


\
\ @brief CAN_RDH0R
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_RDH0R_DATA4                             \ DATA4
$0000ff00 constant CAN2_CAN_RDH0R_DATA5                             \ DATA5
$00ff0000 constant CAN2_CAN_RDH0R_DATA6                             \ DATA6
$ff000000 constant CAN2_CAN_RDH0R_DATA7                             \ DATA7


\
\ @brief CAN_RI1R
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000002 constant CAN2_CAN_RI1R_RTR                                \ RTR
$00000004 constant CAN2_CAN_RI1R_IDE                                \ IDE
$001ffff8 constant CAN2_CAN_RI1R_EXID                               \ EXID
$ffe00000 constant CAN2_CAN_RI1R_STID                               \ STID


\
\ @brief CAN_RDT1R
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$0000000f constant CAN2_CAN_RDT1R_DLC                               \ DLC
$0000ff00 constant CAN2_CAN_RDT1R_FMI                               \ FMI
$ffff0000 constant CAN2_CAN_RDT1R_TIME                              \ TIME


\
\ @brief CAN_RDL1R
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_RDL1R_DATA0                             \ DATA0
$0000ff00 constant CAN2_CAN_RDL1R_DATA1                             \ DATA1
$00ff0000 constant CAN2_CAN_RDL1R_DATA2                             \ DATA2
$ff000000 constant CAN2_CAN_RDL1R_DATA3                             \ DATA3


\
\ @brief CAN_RDH1R
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$000000ff constant CAN2_CAN_RDH1R_DATA4                             \ DATA4
$0000ff00 constant CAN2_CAN_RDH1R_DATA5                             \ DATA5
$00ff0000 constant CAN2_CAN_RDH1R_DATA6                             \ DATA6
$ff000000 constant CAN2_CAN_RDH1R_DATA7                             \ DATA7


\
\ @brief Controller area network
\
$40006800 constant CAN2_CAN_MCR   \ offset: 0x00 : CAN_MCR
$40006804 constant CAN2_CAN_MSR   \ offset: 0x04 : CAN_MSR
$40006808 constant CAN2_CAN_TSR   \ offset: 0x08 : CAN_TSR
$4000680c constant CAN2_CAN_RF0R  \ offset: 0x0C : CAN_RF0R
$40006810 constant CAN2_CAN_RF1R  \ offset: 0x10 : CAN_RF1R
$40006814 constant CAN2_CAN_IER   \ offset: 0x14 : CAN_IER
$40006818 constant CAN2_CAN_ESR   \ offset: 0x18 : CAN_ESR
$4000681c constant CAN2_CAN_BTR   \ offset: 0x1C : CAN_BTR
$40006980 constant CAN2_CAN_TI0R  \ offset: 0x180 : CAN_TI0R
$40006984 constant CAN2_CAN_TDT0R  \ offset: 0x184 : CAN_TDT0R
$40006988 constant CAN2_CAN_TDL0R  \ offset: 0x188 : CAN_TDL0R
$4000698c constant CAN2_CAN_TDH0R  \ offset: 0x18C : CAN_TDH0R
$40006990 constant CAN2_CAN_TI1R  \ offset: 0x190 : CAN_TI1R
$40006994 constant CAN2_CAN_TDT1R  \ offset: 0x194 : CAN_TDT1R
$40006998 constant CAN2_CAN_TDL1R  \ offset: 0x198 : CAN_TDL1R
$4000699c constant CAN2_CAN_TDH1R  \ offset: 0x19C : CAN_TDH1R
$400069a0 constant CAN2_CAN_TI2R  \ offset: 0x1A0 : CAN_TI2R
$400069a4 constant CAN2_CAN_TDT2R  \ offset: 0x1A4 : CAN_TDT2R
$400069a8 constant CAN2_CAN_TDL2R  \ offset: 0x1A8 : CAN_TDL2R
$400069ac constant CAN2_CAN_TDH2R  \ offset: 0x1AC : CAN_TDH2R
$400069b0 constant CAN2_CAN_RI0R  \ offset: 0x1B0 : CAN_RI0R
$400069b4 constant CAN2_CAN_RDT0R  \ offset: 0x1B4 : CAN_RDT0R
$400069b8 constant CAN2_CAN_RDL0R  \ offset: 0x1B8 : CAN_RDL0R
$400069bc constant CAN2_CAN_RDH0R  \ offset: 0x1BC : CAN_RDH0R
$400069c0 constant CAN2_CAN_RI1R  \ offset: 0x1C0 : CAN_RI1R
$400069c4 constant CAN2_CAN_RDT1R  \ offset: 0x1C4 : CAN_RDT1R
$400069c8 constant CAN2_CAN_RDL1R  \ offset: 0x1C8 : CAN_RDL1R
$400069cc constant CAN2_CAN_RDH1R  \ offset: 0x1CC : CAN_RDH1R

