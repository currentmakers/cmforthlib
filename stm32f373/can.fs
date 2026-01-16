\
\ @file can.fs
\ @brief Controller area network
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief master control register
\ Address offset: 0x00
\ Reset value: 0x00010002
\

$00000001 constant CAN_MCR_INRQ                                     \ INRQ
$00000002 constant CAN_MCR_SLEEP                                    \ SLEEP
$00000004 constant CAN_MCR_TXFP                                     \ TXFP
$00000008 constant CAN_MCR_RFLM                                     \ RFLM
$00000010 constant CAN_MCR_NART                                     \ NART
$00000020 constant CAN_MCR_AWUM                                     \ AWUM
$00000040 constant CAN_MCR_ABOM                                     \ ABOM
$00000080 constant CAN_MCR_TTCM                                     \ TTCM
$00008000 constant CAN_MCR_RESET                                    \ RESET
$00010000 constant CAN_MCR_DBF                                      \ DBF


\
\ @brief master status register
\ Address offset: 0x04
\ Reset value: 0x00000C02
\

$00000001 constant CAN_MSR_INAK                                     \ INAK
$00000002 constant CAN_MSR_SLAK                                     \ SLAK
$00000004 constant CAN_MSR_ERRI                                     \ ERRI
$00000008 constant CAN_MSR_WKUI                                     \ WKUI
$00000010 constant CAN_MSR_SLAKI                                    \ SLAKI
$00000100 constant CAN_MSR_TXM                                      \ TXM
$00000200 constant CAN_MSR_RXM                                      \ RXM
$00000400 constant CAN_MSR_SAMP                                     \ SAMP
$00000800 constant CAN_MSR_RX                                       \ RX


\
\ @brief transmit status register
\ Address offset: 0x08
\ Reset value: 0x1C000000
\

$00000001 constant CAN_TSR_RQCP0                                    \ RQCP0
$00000002 constant CAN_TSR_TXOK0                                    \ TXOK0
$00000004 constant CAN_TSR_ALST0                                    \ ALST0
$00000008 constant CAN_TSR_TERR0                                    \ TERR0
$00000080 constant CAN_TSR_ABRQ0                                    \ ABRQ0
$00000100 constant CAN_TSR_RQCP1                                    \ RQCP1
$00000200 constant CAN_TSR_TXOK1                                    \ TXOK1
$00000400 constant CAN_TSR_ALST1                                    \ ALST1
$00000800 constant CAN_TSR_TERR1                                    \ TERR1
$00008000 constant CAN_TSR_ABRQ1                                    \ ABRQ1
$00010000 constant CAN_TSR_RQCP2                                    \ RQCP2
$00020000 constant CAN_TSR_TXOK2                                    \ TXOK2
$00040000 constant CAN_TSR_ALST2                                    \ ALST2
$00080000 constant CAN_TSR_TERR2                                    \ TERR2
$00800000 constant CAN_TSR_ABRQ2                                    \ ABRQ2
$03000000 constant CAN_TSR_CODE                                     \ CODE
$04000000 constant CAN_TSR_TME0                                     \ Lowest priority flag for mailbox 0
$08000000 constant CAN_TSR_TME1                                     \ Lowest priority flag for mailbox 1
$10000000 constant CAN_TSR_TME2                                     \ Lowest priority flag for mailbox 2
$20000000 constant CAN_TSR_LOW0                                     \ Lowest priority flag for mailbox 0
$40000000 constant CAN_TSR_LOW1                                     \ Lowest priority flag for mailbox 1
$80000000 constant CAN_TSR_LOW2                                     \ Lowest priority flag for mailbox 2


\
\ @brief receive FIFO 0 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant CAN_RF0R_FMP0                                    \ FMP0
$00000008 constant CAN_RF0R_FULL0                                   \ FULL0
$00000010 constant CAN_RF0R_FOVR0                                   \ FOVR0
$00000020 constant CAN_RF0R_RFOM0                                   \ RFOM0


\
\ @brief receive FIFO 1 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000003 constant CAN_RF1R_FMP1                                    \ FMP1
$00000008 constant CAN_RF1R_FULL1                                   \ FULL1
$00000010 constant CAN_RF1R_FOVR1                                   \ FOVR1
$00000020 constant CAN_RF1R_RFOM1                                   \ RFOM1


\
\ @brief interrupt enable register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CAN_IER_TMEIE                                    \ TMEIE
$00000002 constant CAN_IER_FMPIE0                                   \ FMPIE0
$00000004 constant CAN_IER_FFIE0                                    \ FFIE0
$00000008 constant CAN_IER_FOVIE0                                   \ FOVIE0
$00000010 constant CAN_IER_FMPIE1                                   \ FMPIE1
$00000020 constant CAN_IER_FFIE1                                    \ FFIE1
$00000040 constant CAN_IER_FOVIE1                                   \ FOVIE1
$00000100 constant CAN_IER_EWGIE                                    \ EWGIE
$00000200 constant CAN_IER_EPVIE                                    \ EPVIE
$00000400 constant CAN_IER_BOFIE                                    \ BOFIE
$00000800 constant CAN_IER_LECIE                                    \ LECIE
$00008000 constant CAN_IER_ERRIE                                    \ ERRIE
$00010000 constant CAN_IER_WKUIE                                    \ WKUIE
$00020000 constant CAN_IER_SLKIE                                    \ SLKIE


\
\ @brief error status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant CAN_ESR_EWGF                                     \ EWGF
$00000002 constant CAN_ESR_EPVF                                     \ EPVF
$00000004 constant CAN_ESR_BOFF                                     \ BOFF
$00000070 constant CAN_ESR_LEC                                      \ LEC
$00ff0000 constant CAN_ESR_TEC                                      \ TEC
$ff000000 constant CAN_ESR_REC                                      \ REC


\
\ @brief bit timing register
\ Address offset: 0x1C
\ Reset value: 0x01230000
\

$000003ff constant CAN_BTR_BRP                                      \ BRP
$000f0000 constant CAN_BTR_TS1                                      \ TS1
$00700000 constant CAN_BTR_TS2                                      \ TS2
$03000000 constant CAN_BTR_SJW                                      \ SJW
$40000000 constant CAN_BTR_LBKM                                     \ LBKM
$80000000 constant CAN_BTR_SILM                                     \ SILM


\
\ @brief TX mailbox identifier register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant CAN_TI0R_TXRQ                                    \ TXRQ
$00000002 constant CAN_TI0R_RTR                                     \ RTR
$00000004 constant CAN_TI0R_IDE                                     \ IDE
$001ffff8 constant CAN_TI0R_EXID                                    \ EXID
$ffe00000 constant CAN_TI0R_STID                                    \ STID


\
\ @brief mailbox data length control and time stamp register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$0000000f constant CAN_TDT0R_DLC                                    \ DLC
$00000100 constant CAN_TDT0R_TGT                                    \ TGT
$ffff0000 constant CAN_TDT0R_TIME                                   \ TIME


\
\ @brief mailbox data low register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$000000ff constant CAN_TDL0R_DATA0                                  \ DATA0
$0000ff00 constant CAN_TDL0R_DATA1                                  \ DATA1
$00ff0000 constant CAN_TDL0R_DATA2                                  \ DATA2
$ff000000 constant CAN_TDL0R_DATA3                                  \ DATA3


\
\ @brief mailbox data high register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$000000ff constant CAN_TDH0R_DATA4                                  \ DATA4
$0000ff00 constant CAN_TDH0R_DATA5                                  \ DATA5
$00ff0000 constant CAN_TDH0R_DATA6                                  \ DATA6
$ff000000 constant CAN_TDH0R_DATA7                                  \ DATA7


\
\ @brief TX mailbox identifier register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000001 constant CAN_TI1R_TXRQ                                    \ TXRQ
$00000002 constant CAN_TI1R_RTR                                     \ RTR
$00000004 constant CAN_TI1R_IDE                                     \ IDE
$001ffff8 constant CAN_TI1R_EXID                                    \ EXID
$ffe00000 constant CAN_TI1R_STID                                    \ STID


\
\ @brief mailbox data length control and time stamp register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0000000f constant CAN_TDT1R_DLC                                    \ DLC
$00000100 constant CAN_TDT1R_TGT                                    \ TGT
$ffff0000 constant CAN_TDT1R_TIME                                   \ TIME


\
\ @brief mailbox data low register
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$000000ff constant CAN_TDL1R_DATA0                                  \ DATA0
$0000ff00 constant CAN_TDL1R_DATA1                                  \ DATA1
$00ff0000 constant CAN_TDL1R_DATA2                                  \ DATA2
$ff000000 constant CAN_TDL1R_DATA3                                  \ DATA3


\
\ @brief mailbox data high register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$000000ff constant CAN_TDH1R_DATA4                                  \ DATA4
$0000ff00 constant CAN_TDH1R_DATA5                                  \ DATA5
$00ff0000 constant CAN_TDH1R_DATA6                                  \ DATA6
$ff000000 constant CAN_TDH1R_DATA7                                  \ DATA7


\
\ @brief TX mailbox identifier register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000001 constant CAN_TI2R_TXRQ                                    \ TXRQ
$00000002 constant CAN_TI2R_RTR                                     \ RTR
$00000004 constant CAN_TI2R_IDE                                     \ IDE
$001ffff8 constant CAN_TI2R_EXID                                    \ EXID
$ffe00000 constant CAN_TI2R_STID                                    \ STID


\
\ @brief mailbox data length control and time stamp register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000000f constant CAN_TDT2R_DLC                                    \ DLC
$00000100 constant CAN_TDT2R_TGT                                    \ TGT
$ffff0000 constant CAN_TDT2R_TIME                                   \ TIME


\
\ @brief mailbox data low register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$000000ff constant CAN_TDL2R_DATA0                                  \ DATA0
$0000ff00 constant CAN_TDL2R_DATA1                                  \ DATA1
$00ff0000 constant CAN_TDL2R_DATA2                                  \ DATA2
$ff000000 constant CAN_TDL2R_DATA3                                  \ DATA3


\
\ @brief mailbox data high register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$000000ff constant CAN_TDH2R_DATA4                                  \ DATA4
$0000ff00 constant CAN_TDH2R_DATA5                                  \ DATA5
$00ff0000 constant CAN_TDH2R_DATA6                                  \ DATA6
$ff000000 constant CAN_TDH2R_DATA7                                  \ DATA7


\
\ @brief receive FIFO mailbox identifier register
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000002 constant CAN_RI0R_RTR                                     \ RTR
$00000004 constant CAN_RI0R_IDE                                     \ IDE
$001ffff8 constant CAN_RI0R_EXID                                    \ EXID
$ffe00000 constant CAN_RI0R_STID                                    \ STID


\
\ @brief receive FIFO mailbox data length control and time stamp register
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$0000000f constant CAN_RDT0R_DLC                                    \ DLC
$0000ff00 constant CAN_RDT0R_FMI                                    \ FMI
$ffff0000 constant CAN_RDT0R_TIME                                   \ TIME


\
\ @brief receive FIFO mailbox data low register
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$000000ff constant CAN_RDL0R_DATA0                                  \ DATA0
$0000ff00 constant CAN_RDL0R_DATA1                                  \ DATA1
$00ff0000 constant CAN_RDL0R_DATA2                                  \ DATA2
$ff000000 constant CAN_RDL0R_DATA3                                  \ DATA3


\
\ @brief receive FIFO mailbox data high register
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$000000ff constant CAN_RDH0R_DATA4                                  \ DATA4
$0000ff00 constant CAN_RDH0R_DATA5                                  \ DATA5
$00ff0000 constant CAN_RDH0R_DATA6                                  \ DATA6
$ff000000 constant CAN_RDH0R_DATA7                                  \ DATA7


\
\ @brief receive FIFO mailbox identifier register
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000002 constant CAN_RI1R_RTR                                     \ RTR
$00000004 constant CAN_RI1R_IDE                                     \ IDE
$001ffff8 constant CAN_RI1R_EXID                                    \ EXID
$ffe00000 constant CAN_RI1R_STID                                    \ STID


\
\ @brief receive FIFO mailbox data length control and time stamp register
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$0000000f constant CAN_RDT1R_DLC                                    \ DLC
$0000ff00 constant CAN_RDT1R_FMI                                    \ FMI
$ffff0000 constant CAN_RDT1R_TIME                                   \ TIME


\
\ @brief receive FIFO mailbox data low register
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$000000ff constant CAN_RDL1R_DATA0                                  \ DATA0
$0000ff00 constant CAN_RDL1R_DATA1                                  \ DATA1
$00ff0000 constant CAN_RDL1R_DATA2                                  \ DATA2
$ff000000 constant CAN_RDL1R_DATA3                                  \ DATA3


\
\ @brief receive FIFO mailbox data high register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$000000ff constant CAN_RDH1R_DATA4                                  \ DATA4
$0000ff00 constant CAN_RDH1R_DATA5                                  \ DATA5
$00ff0000 constant CAN_RDH1R_DATA6                                  \ DATA6
$ff000000 constant CAN_RDH1R_DATA7                                  \ DATA7


\
\ @brief filter master register
\ Address offset: 0x200
\ Reset value: 0x2A1C0E01
\

$00000001 constant CAN_FMR_FINIT                                    \ FINIT
$00003f00 constant CAN_FMR_CAN2SB                                   \ CAN2SB


\
\ @brief filter mode register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant CAN_FM1R_FBM0                                    \ Filter mode
$00000002 constant CAN_FM1R_FBM1                                    \ Filter mode
$00000004 constant CAN_FM1R_FBM2                                    \ Filter mode
$00000008 constant CAN_FM1R_FBM3                                    \ Filter mode
$00000010 constant CAN_FM1R_FBM4                                    \ Filter mode
$00000020 constant CAN_FM1R_FBM5                                    \ Filter mode
$00000040 constant CAN_FM1R_FBM6                                    \ Filter mode
$00000080 constant CAN_FM1R_FBM7                                    \ Filter mode
$00000100 constant CAN_FM1R_FBM8                                    \ Filter mode
$00000200 constant CAN_FM1R_FBM9                                    \ Filter mode
$00000400 constant CAN_FM1R_FBM10                                   \ Filter mode
$00000800 constant CAN_FM1R_FBM11                                   \ Filter mode
$00001000 constant CAN_FM1R_FBM12                                   \ Filter mode
$00002000 constant CAN_FM1R_FBM13                                   \ Filter mode
$00004000 constant CAN_FM1R_FBM14                                   \ Filter mode
$00008000 constant CAN_FM1R_FBM15                                   \ Filter mode
$00010000 constant CAN_FM1R_FBM16                                   \ Filter mode
$00020000 constant CAN_FM1R_FBM17                                   \ Filter mode
$00040000 constant CAN_FM1R_FBM18                                   \ Filter mode
$00080000 constant CAN_FM1R_FBM19                                   \ Filter mode
$00100000 constant CAN_FM1R_FBM20                                   \ Filter mode
$00200000 constant CAN_FM1R_FBM21                                   \ Filter mode
$00400000 constant CAN_FM1R_FBM22                                   \ Filter mode
$00800000 constant CAN_FM1R_FBM23                                   \ Filter mode
$01000000 constant CAN_FM1R_FBM24                                   \ Filter mode
$02000000 constant CAN_FM1R_FBM25                                   \ Filter mode
$04000000 constant CAN_FM1R_FBM26                                   \ Filter mode
$08000000 constant CAN_FM1R_FBM27                                   \ Filter mode


\
\ @brief filter scale register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant CAN_FS1R_FSC0                                    \ Filter scale configuration
$00000002 constant CAN_FS1R_FSC1                                    \ Filter scale configuration
$00000004 constant CAN_FS1R_FSC2                                    \ Filter scale configuration
$00000008 constant CAN_FS1R_FSC3                                    \ Filter scale configuration
$00000010 constant CAN_FS1R_FSC4                                    \ Filter scale configuration
$00000020 constant CAN_FS1R_FSC5                                    \ Filter scale configuration
$00000040 constant CAN_FS1R_FSC6                                    \ Filter scale configuration
$00000080 constant CAN_FS1R_FSC7                                    \ Filter scale configuration
$00000100 constant CAN_FS1R_FSC8                                    \ Filter scale configuration
$00000200 constant CAN_FS1R_FSC9                                    \ Filter scale configuration
$00000400 constant CAN_FS1R_FSC10                                   \ Filter scale configuration
$00000800 constant CAN_FS1R_FSC11                                   \ Filter scale configuration
$00001000 constant CAN_FS1R_FSC12                                   \ Filter scale configuration
$00002000 constant CAN_FS1R_FSC13                                   \ Filter scale configuration
$00004000 constant CAN_FS1R_FSC14                                   \ Filter scale configuration
$00008000 constant CAN_FS1R_FSC15                                   \ Filter scale configuration
$00010000 constant CAN_FS1R_FSC16                                   \ Filter scale configuration
$00020000 constant CAN_FS1R_FSC17                                   \ Filter scale configuration
$00040000 constant CAN_FS1R_FSC18                                   \ Filter scale configuration
$00080000 constant CAN_FS1R_FSC19                                   \ Filter scale configuration
$00100000 constant CAN_FS1R_FSC20                                   \ Filter scale configuration
$00200000 constant CAN_FS1R_FSC21                                   \ Filter scale configuration
$00400000 constant CAN_FS1R_FSC22                                   \ Filter scale configuration
$00800000 constant CAN_FS1R_FSC23                                   \ Filter scale configuration
$01000000 constant CAN_FS1R_FSC24                                   \ Filter scale configuration
$02000000 constant CAN_FS1R_FSC25                                   \ Filter scale configuration
$04000000 constant CAN_FS1R_FSC26                                   \ Filter scale configuration
$08000000 constant CAN_FS1R_FSC27                                   \ Filter scale configuration


\
\ @brief filter FIFO assignment register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000001 constant CAN_FFA1R_FFA0                                   \ Filter FIFO assignment for filter 0
$00000002 constant CAN_FFA1R_FFA1                                   \ Filter FIFO assignment for filter 1
$00000004 constant CAN_FFA1R_FFA2                                   \ Filter FIFO assignment for filter 2
$00000008 constant CAN_FFA1R_FFA3                                   \ Filter FIFO assignment for filter 3
$00000010 constant CAN_FFA1R_FFA4                                   \ Filter FIFO assignment for filter 4
$00000020 constant CAN_FFA1R_FFA5                                   \ Filter FIFO assignment for filter 5
$00000040 constant CAN_FFA1R_FFA6                                   \ Filter FIFO assignment for filter 6
$00000080 constant CAN_FFA1R_FFA7                                   \ Filter FIFO assignment for filter 7
$00000100 constant CAN_FFA1R_FFA8                                   \ Filter FIFO assignment for filter 8
$00000200 constant CAN_FFA1R_FFA9                                   \ Filter FIFO assignment for filter 9
$00000400 constant CAN_FFA1R_FFA10                                  \ Filter FIFO assignment for filter 10
$00000800 constant CAN_FFA1R_FFA11                                  \ Filter FIFO assignment for filter 11
$00001000 constant CAN_FFA1R_FFA12                                  \ Filter FIFO assignment for filter 12
$00002000 constant CAN_FFA1R_FFA13                                  \ Filter FIFO assignment for filter 13
$00004000 constant CAN_FFA1R_FFA14                                  \ Filter FIFO assignment for filter 14
$00008000 constant CAN_FFA1R_FFA15                                  \ Filter FIFO assignment for filter 15
$00010000 constant CAN_FFA1R_FFA16                                  \ Filter FIFO assignment for filter 16
$00020000 constant CAN_FFA1R_FFA17                                  \ Filter FIFO assignment for filter 17
$00040000 constant CAN_FFA1R_FFA18                                  \ Filter FIFO assignment for filter 18
$00080000 constant CAN_FFA1R_FFA19                                  \ Filter FIFO assignment for filter 19
$00100000 constant CAN_FFA1R_FFA20                                  \ Filter FIFO assignment for filter 20
$00200000 constant CAN_FFA1R_FFA21                                  \ Filter FIFO assignment for filter 21
$00400000 constant CAN_FFA1R_FFA22                                  \ Filter FIFO assignment for filter 22
$00800000 constant CAN_FFA1R_FFA23                                  \ Filter FIFO assignment for filter 23
$01000000 constant CAN_FFA1R_FFA24                                  \ Filter FIFO assignment for filter 24
$02000000 constant CAN_FFA1R_FFA25                                  \ Filter FIFO assignment for filter 25
$04000000 constant CAN_FFA1R_FFA26                                  \ Filter FIFO assignment for filter 26
$08000000 constant CAN_FFA1R_FFA27                                  \ Filter FIFO assignment for filter 27


\
\ @brief CAN filter activation register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000001 constant CAN_FA1R_FACT0                                   \ Filter active
$00000002 constant CAN_FA1R_FACT1                                   \ Filter active
$00000004 constant CAN_FA1R_FACT2                                   \ Filter active
$00000008 constant CAN_FA1R_FACT3                                   \ Filter active
$00000010 constant CAN_FA1R_FACT4                                   \ Filter active
$00000020 constant CAN_FA1R_FACT5                                   \ Filter active
$00000040 constant CAN_FA1R_FACT6                                   \ Filter active
$00000080 constant CAN_FA1R_FACT7                                   \ Filter active
$00000100 constant CAN_FA1R_FACT8                                   \ Filter active
$00000200 constant CAN_FA1R_FACT9                                   \ Filter active
$00000400 constant CAN_FA1R_FACT10                                  \ Filter active
$00000800 constant CAN_FA1R_FACT11                                  \ Filter active
$00001000 constant CAN_FA1R_FACT12                                  \ Filter active
$00002000 constant CAN_FA1R_FACT13                                  \ Filter active
$00004000 constant CAN_FA1R_FACT14                                  \ Filter active
$00008000 constant CAN_FA1R_FACT15                                  \ Filter active
$00010000 constant CAN_FA1R_FACT16                                  \ Filter active
$00020000 constant CAN_FA1R_FACT17                                  \ Filter active
$00040000 constant CAN_FA1R_FACT18                                  \ Filter active
$00080000 constant CAN_FA1R_FACT19                                  \ Filter active
$00100000 constant CAN_FA1R_FACT20                                  \ Filter active
$00200000 constant CAN_FA1R_FACT21                                  \ Filter active
$00400000 constant CAN_FA1R_FACT22                                  \ Filter active
$00800000 constant CAN_FA1R_FACT23                                  \ Filter active
$01000000 constant CAN_FA1R_FACT24                                  \ Filter active
$02000000 constant CAN_FA1R_FACT25                                  \ Filter active
$04000000 constant CAN_FA1R_FACT26                                  \ Filter active
$08000000 constant CAN_FA1R_FACT27                                  \ Filter active


\
\ @brief Filter bank 0 register 1
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000001 constant CAN_F0R1_FB0                                     \ Filter bits
$00000002 constant CAN_F0R1_FB1                                     \ Filter bits
$00000004 constant CAN_F0R1_FB2                                     \ Filter bits
$00000008 constant CAN_F0R1_FB3                                     \ Filter bits
$00000010 constant CAN_F0R1_FB4                                     \ Filter bits
$00000020 constant CAN_F0R1_FB5                                     \ Filter bits
$00000040 constant CAN_F0R1_FB6                                     \ Filter bits
$00000080 constant CAN_F0R1_FB7                                     \ Filter bits
$00000100 constant CAN_F0R1_FB8                                     \ Filter bits
$00000200 constant CAN_F0R1_FB9                                     \ Filter bits
$00000400 constant CAN_F0R1_FB10                                    \ Filter bits
$00000800 constant CAN_F0R1_FB11                                    \ Filter bits
$00001000 constant CAN_F0R1_FB12                                    \ Filter bits
$00002000 constant CAN_F0R1_FB13                                    \ Filter bits
$00004000 constant CAN_F0R1_FB14                                    \ Filter bits
$00008000 constant CAN_F0R1_FB15                                    \ Filter bits
$00010000 constant CAN_F0R1_FB16                                    \ Filter bits
$00020000 constant CAN_F0R1_FB17                                    \ Filter bits
$00040000 constant CAN_F0R1_FB18                                    \ Filter bits
$00080000 constant CAN_F0R1_FB19                                    \ Filter bits
$00100000 constant CAN_F0R1_FB20                                    \ Filter bits
$00200000 constant CAN_F0R1_FB21                                    \ Filter bits
$00400000 constant CAN_F0R1_FB22                                    \ Filter bits
$00800000 constant CAN_F0R1_FB23                                    \ Filter bits
$01000000 constant CAN_F0R1_FB24                                    \ Filter bits
$02000000 constant CAN_F0R1_FB25                                    \ Filter bits
$04000000 constant CAN_F0R1_FB26                                    \ Filter bits
$08000000 constant CAN_F0R1_FB27                                    \ Filter bits
$10000000 constant CAN_F0R1_FB28                                    \ Filter bits
$20000000 constant CAN_F0R1_FB29                                    \ Filter bits
$40000000 constant CAN_F0R1_FB30                                    \ Filter bits
$80000000 constant CAN_F0R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 0 register 2
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000001 constant CAN_F0R2_FB0                                     \ Filter bits
$00000002 constant CAN_F0R2_FB1                                     \ Filter bits
$00000004 constant CAN_F0R2_FB2                                     \ Filter bits
$00000008 constant CAN_F0R2_FB3                                     \ Filter bits
$00000010 constant CAN_F0R2_FB4                                     \ Filter bits
$00000020 constant CAN_F0R2_FB5                                     \ Filter bits
$00000040 constant CAN_F0R2_FB6                                     \ Filter bits
$00000080 constant CAN_F0R2_FB7                                     \ Filter bits
$00000100 constant CAN_F0R2_FB8                                     \ Filter bits
$00000200 constant CAN_F0R2_FB9                                     \ Filter bits
$00000400 constant CAN_F0R2_FB10                                    \ Filter bits
$00000800 constant CAN_F0R2_FB11                                    \ Filter bits
$00001000 constant CAN_F0R2_FB12                                    \ Filter bits
$00002000 constant CAN_F0R2_FB13                                    \ Filter bits
$00004000 constant CAN_F0R2_FB14                                    \ Filter bits
$00008000 constant CAN_F0R2_FB15                                    \ Filter bits
$00010000 constant CAN_F0R2_FB16                                    \ Filter bits
$00020000 constant CAN_F0R2_FB17                                    \ Filter bits
$00040000 constant CAN_F0R2_FB18                                    \ Filter bits
$00080000 constant CAN_F0R2_FB19                                    \ Filter bits
$00100000 constant CAN_F0R2_FB20                                    \ Filter bits
$00200000 constant CAN_F0R2_FB21                                    \ Filter bits
$00400000 constant CAN_F0R2_FB22                                    \ Filter bits
$00800000 constant CAN_F0R2_FB23                                    \ Filter bits
$01000000 constant CAN_F0R2_FB24                                    \ Filter bits
$02000000 constant CAN_F0R2_FB25                                    \ Filter bits
$04000000 constant CAN_F0R2_FB26                                    \ Filter bits
$08000000 constant CAN_F0R2_FB27                                    \ Filter bits
$10000000 constant CAN_F0R2_FB28                                    \ Filter bits
$20000000 constant CAN_F0R2_FB29                                    \ Filter bits
$40000000 constant CAN_F0R2_FB30                                    \ Filter bits
$80000000 constant CAN_F0R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 1 register 1
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000001 constant CAN_F1R1_FB0                                     \ Filter bits
$00000002 constant CAN_F1R1_FB1                                     \ Filter bits
$00000004 constant CAN_F1R1_FB2                                     \ Filter bits
$00000008 constant CAN_F1R1_FB3                                     \ Filter bits
$00000010 constant CAN_F1R1_FB4                                     \ Filter bits
$00000020 constant CAN_F1R1_FB5                                     \ Filter bits
$00000040 constant CAN_F1R1_FB6                                     \ Filter bits
$00000080 constant CAN_F1R1_FB7                                     \ Filter bits
$00000100 constant CAN_F1R1_FB8                                     \ Filter bits
$00000200 constant CAN_F1R1_FB9                                     \ Filter bits
$00000400 constant CAN_F1R1_FB10                                    \ Filter bits
$00000800 constant CAN_F1R1_FB11                                    \ Filter bits
$00001000 constant CAN_F1R1_FB12                                    \ Filter bits
$00002000 constant CAN_F1R1_FB13                                    \ Filter bits
$00004000 constant CAN_F1R1_FB14                                    \ Filter bits
$00008000 constant CAN_F1R1_FB15                                    \ Filter bits
$00010000 constant CAN_F1R1_FB16                                    \ Filter bits
$00020000 constant CAN_F1R1_FB17                                    \ Filter bits
$00040000 constant CAN_F1R1_FB18                                    \ Filter bits
$00080000 constant CAN_F1R1_FB19                                    \ Filter bits
$00100000 constant CAN_F1R1_FB20                                    \ Filter bits
$00200000 constant CAN_F1R1_FB21                                    \ Filter bits
$00400000 constant CAN_F1R1_FB22                                    \ Filter bits
$00800000 constant CAN_F1R1_FB23                                    \ Filter bits
$01000000 constant CAN_F1R1_FB24                                    \ Filter bits
$02000000 constant CAN_F1R1_FB25                                    \ Filter bits
$04000000 constant CAN_F1R1_FB26                                    \ Filter bits
$08000000 constant CAN_F1R1_FB27                                    \ Filter bits
$10000000 constant CAN_F1R1_FB28                                    \ Filter bits
$20000000 constant CAN_F1R1_FB29                                    \ Filter bits
$40000000 constant CAN_F1R1_FB30                                    \ Filter bits
$80000000 constant CAN_F1R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 1 register 2
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000001 constant CAN_F1R2_FB0                                     \ Filter bits
$00000002 constant CAN_F1R2_FB1                                     \ Filter bits
$00000004 constant CAN_F1R2_FB2                                     \ Filter bits
$00000008 constant CAN_F1R2_FB3                                     \ Filter bits
$00000010 constant CAN_F1R2_FB4                                     \ Filter bits
$00000020 constant CAN_F1R2_FB5                                     \ Filter bits
$00000040 constant CAN_F1R2_FB6                                     \ Filter bits
$00000080 constant CAN_F1R2_FB7                                     \ Filter bits
$00000100 constant CAN_F1R2_FB8                                     \ Filter bits
$00000200 constant CAN_F1R2_FB9                                     \ Filter bits
$00000400 constant CAN_F1R2_FB10                                    \ Filter bits
$00000800 constant CAN_F1R2_FB11                                    \ Filter bits
$00001000 constant CAN_F1R2_FB12                                    \ Filter bits
$00002000 constant CAN_F1R2_FB13                                    \ Filter bits
$00004000 constant CAN_F1R2_FB14                                    \ Filter bits
$00008000 constant CAN_F1R2_FB15                                    \ Filter bits
$00010000 constant CAN_F1R2_FB16                                    \ Filter bits
$00020000 constant CAN_F1R2_FB17                                    \ Filter bits
$00040000 constant CAN_F1R2_FB18                                    \ Filter bits
$00080000 constant CAN_F1R2_FB19                                    \ Filter bits
$00100000 constant CAN_F1R2_FB20                                    \ Filter bits
$00200000 constant CAN_F1R2_FB21                                    \ Filter bits
$00400000 constant CAN_F1R2_FB22                                    \ Filter bits
$00800000 constant CAN_F1R2_FB23                                    \ Filter bits
$01000000 constant CAN_F1R2_FB24                                    \ Filter bits
$02000000 constant CAN_F1R2_FB25                                    \ Filter bits
$04000000 constant CAN_F1R2_FB26                                    \ Filter bits
$08000000 constant CAN_F1R2_FB27                                    \ Filter bits
$10000000 constant CAN_F1R2_FB28                                    \ Filter bits
$20000000 constant CAN_F1R2_FB29                                    \ Filter bits
$40000000 constant CAN_F1R2_FB30                                    \ Filter bits
$80000000 constant CAN_F1R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 2 register 1
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000001 constant CAN_F2R1_FB0                                     \ Filter bits
$00000002 constant CAN_F2R1_FB1                                     \ Filter bits
$00000004 constant CAN_F2R1_FB2                                     \ Filter bits
$00000008 constant CAN_F2R1_FB3                                     \ Filter bits
$00000010 constant CAN_F2R1_FB4                                     \ Filter bits
$00000020 constant CAN_F2R1_FB5                                     \ Filter bits
$00000040 constant CAN_F2R1_FB6                                     \ Filter bits
$00000080 constant CAN_F2R1_FB7                                     \ Filter bits
$00000100 constant CAN_F2R1_FB8                                     \ Filter bits
$00000200 constant CAN_F2R1_FB9                                     \ Filter bits
$00000400 constant CAN_F2R1_FB10                                    \ Filter bits
$00000800 constant CAN_F2R1_FB11                                    \ Filter bits
$00001000 constant CAN_F2R1_FB12                                    \ Filter bits
$00002000 constant CAN_F2R1_FB13                                    \ Filter bits
$00004000 constant CAN_F2R1_FB14                                    \ Filter bits
$00008000 constant CAN_F2R1_FB15                                    \ Filter bits
$00010000 constant CAN_F2R1_FB16                                    \ Filter bits
$00020000 constant CAN_F2R1_FB17                                    \ Filter bits
$00040000 constant CAN_F2R1_FB18                                    \ Filter bits
$00080000 constant CAN_F2R1_FB19                                    \ Filter bits
$00100000 constant CAN_F2R1_FB20                                    \ Filter bits
$00200000 constant CAN_F2R1_FB21                                    \ Filter bits
$00400000 constant CAN_F2R1_FB22                                    \ Filter bits
$00800000 constant CAN_F2R1_FB23                                    \ Filter bits
$01000000 constant CAN_F2R1_FB24                                    \ Filter bits
$02000000 constant CAN_F2R1_FB25                                    \ Filter bits
$04000000 constant CAN_F2R1_FB26                                    \ Filter bits
$08000000 constant CAN_F2R1_FB27                                    \ Filter bits
$10000000 constant CAN_F2R1_FB28                                    \ Filter bits
$20000000 constant CAN_F2R1_FB29                                    \ Filter bits
$40000000 constant CAN_F2R1_FB30                                    \ Filter bits
$80000000 constant CAN_F2R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 2 register 2
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000001 constant CAN_F2R2_FB0                                     \ Filter bits
$00000002 constant CAN_F2R2_FB1                                     \ Filter bits
$00000004 constant CAN_F2R2_FB2                                     \ Filter bits
$00000008 constant CAN_F2R2_FB3                                     \ Filter bits
$00000010 constant CAN_F2R2_FB4                                     \ Filter bits
$00000020 constant CAN_F2R2_FB5                                     \ Filter bits
$00000040 constant CAN_F2R2_FB6                                     \ Filter bits
$00000080 constant CAN_F2R2_FB7                                     \ Filter bits
$00000100 constant CAN_F2R2_FB8                                     \ Filter bits
$00000200 constant CAN_F2R2_FB9                                     \ Filter bits
$00000400 constant CAN_F2R2_FB10                                    \ Filter bits
$00000800 constant CAN_F2R2_FB11                                    \ Filter bits
$00001000 constant CAN_F2R2_FB12                                    \ Filter bits
$00002000 constant CAN_F2R2_FB13                                    \ Filter bits
$00004000 constant CAN_F2R2_FB14                                    \ Filter bits
$00008000 constant CAN_F2R2_FB15                                    \ Filter bits
$00010000 constant CAN_F2R2_FB16                                    \ Filter bits
$00020000 constant CAN_F2R2_FB17                                    \ Filter bits
$00040000 constant CAN_F2R2_FB18                                    \ Filter bits
$00080000 constant CAN_F2R2_FB19                                    \ Filter bits
$00100000 constant CAN_F2R2_FB20                                    \ Filter bits
$00200000 constant CAN_F2R2_FB21                                    \ Filter bits
$00400000 constant CAN_F2R2_FB22                                    \ Filter bits
$00800000 constant CAN_F2R2_FB23                                    \ Filter bits
$01000000 constant CAN_F2R2_FB24                                    \ Filter bits
$02000000 constant CAN_F2R2_FB25                                    \ Filter bits
$04000000 constant CAN_F2R2_FB26                                    \ Filter bits
$08000000 constant CAN_F2R2_FB27                                    \ Filter bits
$10000000 constant CAN_F2R2_FB28                                    \ Filter bits
$20000000 constant CAN_F2R2_FB29                                    \ Filter bits
$40000000 constant CAN_F2R2_FB30                                    \ Filter bits
$80000000 constant CAN_F2R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 3 register 1
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000001 constant CAN_F3R1_FB0                                     \ Filter bits
$00000002 constant CAN_F3R1_FB1                                     \ Filter bits
$00000004 constant CAN_F3R1_FB2                                     \ Filter bits
$00000008 constant CAN_F3R1_FB3                                     \ Filter bits
$00000010 constant CAN_F3R1_FB4                                     \ Filter bits
$00000020 constant CAN_F3R1_FB5                                     \ Filter bits
$00000040 constant CAN_F3R1_FB6                                     \ Filter bits
$00000080 constant CAN_F3R1_FB7                                     \ Filter bits
$00000100 constant CAN_F3R1_FB8                                     \ Filter bits
$00000200 constant CAN_F3R1_FB9                                     \ Filter bits
$00000400 constant CAN_F3R1_FB10                                    \ Filter bits
$00000800 constant CAN_F3R1_FB11                                    \ Filter bits
$00001000 constant CAN_F3R1_FB12                                    \ Filter bits
$00002000 constant CAN_F3R1_FB13                                    \ Filter bits
$00004000 constant CAN_F3R1_FB14                                    \ Filter bits
$00008000 constant CAN_F3R1_FB15                                    \ Filter bits
$00010000 constant CAN_F3R1_FB16                                    \ Filter bits
$00020000 constant CAN_F3R1_FB17                                    \ Filter bits
$00040000 constant CAN_F3R1_FB18                                    \ Filter bits
$00080000 constant CAN_F3R1_FB19                                    \ Filter bits
$00100000 constant CAN_F3R1_FB20                                    \ Filter bits
$00200000 constant CAN_F3R1_FB21                                    \ Filter bits
$00400000 constant CAN_F3R1_FB22                                    \ Filter bits
$00800000 constant CAN_F3R1_FB23                                    \ Filter bits
$01000000 constant CAN_F3R1_FB24                                    \ Filter bits
$02000000 constant CAN_F3R1_FB25                                    \ Filter bits
$04000000 constant CAN_F3R1_FB26                                    \ Filter bits
$08000000 constant CAN_F3R1_FB27                                    \ Filter bits
$10000000 constant CAN_F3R1_FB28                                    \ Filter bits
$20000000 constant CAN_F3R1_FB29                                    \ Filter bits
$40000000 constant CAN_F3R1_FB30                                    \ Filter bits
$80000000 constant CAN_F3R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 3 register 2
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000001 constant CAN_F3R2_FB0                                     \ Filter bits
$00000002 constant CAN_F3R2_FB1                                     \ Filter bits
$00000004 constant CAN_F3R2_FB2                                     \ Filter bits
$00000008 constant CAN_F3R2_FB3                                     \ Filter bits
$00000010 constant CAN_F3R2_FB4                                     \ Filter bits
$00000020 constant CAN_F3R2_FB5                                     \ Filter bits
$00000040 constant CAN_F3R2_FB6                                     \ Filter bits
$00000080 constant CAN_F3R2_FB7                                     \ Filter bits
$00000100 constant CAN_F3R2_FB8                                     \ Filter bits
$00000200 constant CAN_F3R2_FB9                                     \ Filter bits
$00000400 constant CAN_F3R2_FB10                                    \ Filter bits
$00000800 constant CAN_F3R2_FB11                                    \ Filter bits
$00001000 constant CAN_F3R2_FB12                                    \ Filter bits
$00002000 constant CAN_F3R2_FB13                                    \ Filter bits
$00004000 constant CAN_F3R2_FB14                                    \ Filter bits
$00008000 constant CAN_F3R2_FB15                                    \ Filter bits
$00010000 constant CAN_F3R2_FB16                                    \ Filter bits
$00020000 constant CAN_F3R2_FB17                                    \ Filter bits
$00040000 constant CAN_F3R2_FB18                                    \ Filter bits
$00080000 constant CAN_F3R2_FB19                                    \ Filter bits
$00100000 constant CAN_F3R2_FB20                                    \ Filter bits
$00200000 constant CAN_F3R2_FB21                                    \ Filter bits
$00400000 constant CAN_F3R2_FB22                                    \ Filter bits
$00800000 constant CAN_F3R2_FB23                                    \ Filter bits
$01000000 constant CAN_F3R2_FB24                                    \ Filter bits
$02000000 constant CAN_F3R2_FB25                                    \ Filter bits
$04000000 constant CAN_F3R2_FB26                                    \ Filter bits
$08000000 constant CAN_F3R2_FB27                                    \ Filter bits
$10000000 constant CAN_F3R2_FB28                                    \ Filter bits
$20000000 constant CAN_F3R2_FB29                                    \ Filter bits
$40000000 constant CAN_F3R2_FB30                                    \ Filter bits
$80000000 constant CAN_F3R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 4 register 1
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000001 constant CAN_F4R1_FB0                                     \ Filter bits
$00000002 constant CAN_F4R1_FB1                                     \ Filter bits
$00000004 constant CAN_F4R1_FB2                                     \ Filter bits
$00000008 constant CAN_F4R1_FB3                                     \ Filter bits
$00000010 constant CAN_F4R1_FB4                                     \ Filter bits
$00000020 constant CAN_F4R1_FB5                                     \ Filter bits
$00000040 constant CAN_F4R1_FB6                                     \ Filter bits
$00000080 constant CAN_F4R1_FB7                                     \ Filter bits
$00000100 constant CAN_F4R1_FB8                                     \ Filter bits
$00000200 constant CAN_F4R1_FB9                                     \ Filter bits
$00000400 constant CAN_F4R1_FB10                                    \ Filter bits
$00000800 constant CAN_F4R1_FB11                                    \ Filter bits
$00001000 constant CAN_F4R1_FB12                                    \ Filter bits
$00002000 constant CAN_F4R1_FB13                                    \ Filter bits
$00004000 constant CAN_F4R1_FB14                                    \ Filter bits
$00008000 constant CAN_F4R1_FB15                                    \ Filter bits
$00010000 constant CAN_F4R1_FB16                                    \ Filter bits
$00020000 constant CAN_F4R1_FB17                                    \ Filter bits
$00040000 constant CAN_F4R1_FB18                                    \ Filter bits
$00080000 constant CAN_F4R1_FB19                                    \ Filter bits
$00100000 constant CAN_F4R1_FB20                                    \ Filter bits
$00200000 constant CAN_F4R1_FB21                                    \ Filter bits
$00400000 constant CAN_F4R1_FB22                                    \ Filter bits
$00800000 constant CAN_F4R1_FB23                                    \ Filter bits
$01000000 constant CAN_F4R1_FB24                                    \ Filter bits
$02000000 constant CAN_F4R1_FB25                                    \ Filter bits
$04000000 constant CAN_F4R1_FB26                                    \ Filter bits
$08000000 constant CAN_F4R1_FB27                                    \ Filter bits
$10000000 constant CAN_F4R1_FB28                                    \ Filter bits
$20000000 constant CAN_F4R1_FB29                                    \ Filter bits
$40000000 constant CAN_F4R1_FB30                                    \ Filter bits
$80000000 constant CAN_F4R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 4 register 2
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000001 constant CAN_F4R2_FB0                                     \ Filter bits
$00000002 constant CAN_F4R2_FB1                                     \ Filter bits
$00000004 constant CAN_F4R2_FB2                                     \ Filter bits
$00000008 constant CAN_F4R2_FB3                                     \ Filter bits
$00000010 constant CAN_F4R2_FB4                                     \ Filter bits
$00000020 constant CAN_F4R2_FB5                                     \ Filter bits
$00000040 constant CAN_F4R2_FB6                                     \ Filter bits
$00000080 constant CAN_F4R2_FB7                                     \ Filter bits
$00000100 constant CAN_F4R2_FB8                                     \ Filter bits
$00000200 constant CAN_F4R2_FB9                                     \ Filter bits
$00000400 constant CAN_F4R2_FB10                                    \ Filter bits
$00000800 constant CAN_F4R2_FB11                                    \ Filter bits
$00001000 constant CAN_F4R2_FB12                                    \ Filter bits
$00002000 constant CAN_F4R2_FB13                                    \ Filter bits
$00004000 constant CAN_F4R2_FB14                                    \ Filter bits
$00008000 constant CAN_F4R2_FB15                                    \ Filter bits
$00010000 constant CAN_F4R2_FB16                                    \ Filter bits
$00020000 constant CAN_F4R2_FB17                                    \ Filter bits
$00040000 constant CAN_F4R2_FB18                                    \ Filter bits
$00080000 constant CAN_F4R2_FB19                                    \ Filter bits
$00100000 constant CAN_F4R2_FB20                                    \ Filter bits
$00200000 constant CAN_F4R2_FB21                                    \ Filter bits
$00400000 constant CAN_F4R2_FB22                                    \ Filter bits
$00800000 constant CAN_F4R2_FB23                                    \ Filter bits
$01000000 constant CAN_F4R2_FB24                                    \ Filter bits
$02000000 constant CAN_F4R2_FB25                                    \ Filter bits
$04000000 constant CAN_F4R2_FB26                                    \ Filter bits
$08000000 constant CAN_F4R2_FB27                                    \ Filter bits
$10000000 constant CAN_F4R2_FB28                                    \ Filter bits
$20000000 constant CAN_F4R2_FB29                                    \ Filter bits
$40000000 constant CAN_F4R2_FB30                                    \ Filter bits
$80000000 constant CAN_F4R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 5 register 1
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000001 constant CAN_F5R1_FB0                                     \ Filter bits
$00000002 constant CAN_F5R1_FB1                                     \ Filter bits
$00000004 constant CAN_F5R1_FB2                                     \ Filter bits
$00000008 constant CAN_F5R1_FB3                                     \ Filter bits
$00000010 constant CAN_F5R1_FB4                                     \ Filter bits
$00000020 constant CAN_F5R1_FB5                                     \ Filter bits
$00000040 constant CAN_F5R1_FB6                                     \ Filter bits
$00000080 constant CAN_F5R1_FB7                                     \ Filter bits
$00000100 constant CAN_F5R1_FB8                                     \ Filter bits
$00000200 constant CAN_F5R1_FB9                                     \ Filter bits
$00000400 constant CAN_F5R1_FB10                                    \ Filter bits
$00000800 constant CAN_F5R1_FB11                                    \ Filter bits
$00001000 constant CAN_F5R1_FB12                                    \ Filter bits
$00002000 constant CAN_F5R1_FB13                                    \ Filter bits
$00004000 constant CAN_F5R1_FB14                                    \ Filter bits
$00008000 constant CAN_F5R1_FB15                                    \ Filter bits
$00010000 constant CAN_F5R1_FB16                                    \ Filter bits
$00020000 constant CAN_F5R1_FB17                                    \ Filter bits
$00040000 constant CAN_F5R1_FB18                                    \ Filter bits
$00080000 constant CAN_F5R1_FB19                                    \ Filter bits
$00100000 constant CAN_F5R1_FB20                                    \ Filter bits
$00200000 constant CAN_F5R1_FB21                                    \ Filter bits
$00400000 constant CAN_F5R1_FB22                                    \ Filter bits
$00800000 constant CAN_F5R1_FB23                                    \ Filter bits
$01000000 constant CAN_F5R1_FB24                                    \ Filter bits
$02000000 constant CAN_F5R1_FB25                                    \ Filter bits
$04000000 constant CAN_F5R1_FB26                                    \ Filter bits
$08000000 constant CAN_F5R1_FB27                                    \ Filter bits
$10000000 constant CAN_F5R1_FB28                                    \ Filter bits
$20000000 constant CAN_F5R1_FB29                                    \ Filter bits
$40000000 constant CAN_F5R1_FB30                                    \ Filter bits
$80000000 constant CAN_F5R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 5 register 2
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000001 constant CAN_F5R2_FB0                                     \ Filter bits
$00000002 constant CAN_F5R2_FB1                                     \ Filter bits
$00000004 constant CAN_F5R2_FB2                                     \ Filter bits
$00000008 constant CAN_F5R2_FB3                                     \ Filter bits
$00000010 constant CAN_F5R2_FB4                                     \ Filter bits
$00000020 constant CAN_F5R2_FB5                                     \ Filter bits
$00000040 constant CAN_F5R2_FB6                                     \ Filter bits
$00000080 constant CAN_F5R2_FB7                                     \ Filter bits
$00000100 constant CAN_F5R2_FB8                                     \ Filter bits
$00000200 constant CAN_F5R2_FB9                                     \ Filter bits
$00000400 constant CAN_F5R2_FB10                                    \ Filter bits
$00000800 constant CAN_F5R2_FB11                                    \ Filter bits
$00001000 constant CAN_F5R2_FB12                                    \ Filter bits
$00002000 constant CAN_F5R2_FB13                                    \ Filter bits
$00004000 constant CAN_F5R2_FB14                                    \ Filter bits
$00008000 constant CAN_F5R2_FB15                                    \ Filter bits
$00010000 constant CAN_F5R2_FB16                                    \ Filter bits
$00020000 constant CAN_F5R2_FB17                                    \ Filter bits
$00040000 constant CAN_F5R2_FB18                                    \ Filter bits
$00080000 constant CAN_F5R2_FB19                                    \ Filter bits
$00100000 constant CAN_F5R2_FB20                                    \ Filter bits
$00200000 constant CAN_F5R2_FB21                                    \ Filter bits
$00400000 constant CAN_F5R2_FB22                                    \ Filter bits
$00800000 constant CAN_F5R2_FB23                                    \ Filter bits
$01000000 constant CAN_F5R2_FB24                                    \ Filter bits
$02000000 constant CAN_F5R2_FB25                                    \ Filter bits
$04000000 constant CAN_F5R2_FB26                                    \ Filter bits
$08000000 constant CAN_F5R2_FB27                                    \ Filter bits
$10000000 constant CAN_F5R2_FB28                                    \ Filter bits
$20000000 constant CAN_F5R2_FB29                                    \ Filter bits
$40000000 constant CAN_F5R2_FB30                                    \ Filter bits
$80000000 constant CAN_F5R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 6 register 1
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000001 constant CAN_F6R1_FB0                                     \ Filter bits
$00000002 constant CAN_F6R1_FB1                                     \ Filter bits
$00000004 constant CAN_F6R1_FB2                                     \ Filter bits
$00000008 constant CAN_F6R1_FB3                                     \ Filter bits
$00000010 constant CAN_F6R1_FB4                                     \ Filter bits
$00000020 constant CAN_F6R1_FB5                                     \ Filter bits
$00000040 constant CAN_F6R1_FB6                                     \ Filter bits
$00000080 constant CAN_F6R1_FB7                                     \ Filter bits
$00000100 constant CAN_F6R1_FB8                                     \ Filter bits
$00000200 constant CAN_F6R1_FB9                                     \ Filter bits
$00000400 constant CAN_F6R1_FB10                                    \ Filter bits
$00000800 constant CAN_F6R1_FB11                                    \ Filter bits
$00001000 constant CAN_F6R1_FB12                                    \ Filter bits
$00002000 constant CAN_F6R1_FB13                                    \ Filter bits
$00004000 constant CAN_F6R1_FB14                                    \ Filter bits
$00008000 constant CAN_F6R1_FB15                                    \ Filter bits
$00010000 constant CAN_F6R1_FB16                                    \ Filter bits
$00020000 constant CAN_F6R1_FB17                                    \ Filter bits
$00040000 constant CAN_F6R1_FB18                                    \ Filter bits
$00080000 constant CAN_F6R1_FB19                                    \ Filter bits
$00100000 constant CAN_F6R1_FB20                                    \ Filter bits
$00200000 constant CAN_F6R1_FB21                                    \ Filter bits
$00400000 constant CAN_F6R1_FB22                                    \ Filter bits
$00800000 constant CAN_F6R1_FB23                                    \ Filter bits
$01000000 constant CAN_F6R1_FB24                                    \ Filter bits
$02000000 constant CAN_F6R1_FB25                                    \ Filter bits
$04000000 constant CAN_F6R1_FB26                                    \ Filter bits
$08000000 constant CAN_F6R1_FB27                                    \ Filter bits
$10000000 constant CAN_F6R1_FB28                                    \ Filter bits
$20000000 constant CAN_F6R1_FB29                                    \ Filter bits
$40000000 constant CAN_F6R1_FB30                                    \ Filter bits
$80000000 constant CAN_F6R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 6 register 2
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000001 constant CAN_F6R2_FB0                                     \ Filter bits
$00000002 constant CAN_F6R2_FB1                                     \ Filter bits
$00000004 constant CAN_F6R2_FB2                                     \ Filter bits
$00000008 constant CAN_F6R2_FB3                                     \ Filter bits
$00000010 constant CAN_F6R2_FB4                                     \ Filter bits
$00000020 constant CAN_F6R2_FB5                                     \ Filter bits
$00000040 constant CAN_F6R2_FB6                                     \ Filter bits
$00000080 constant CAN_F6R2_FB7                                     \ Filter bits
$00000100 constant CAN_F6R2_FB8                                     \ Filter bits
$00000200 constant CAN_F6R2_FB9                                     \ Filter bits
$00000400 constant CAN_F6R2_FB10                                    \ Filter bits
$00000800 constant CAN_F6R2_FB11                                    \ Filter bits
$00001000 constant CAN_F6R2_FB12                                    \ Filter bits
$00002000 constant CAN_F6R2_FB13                                    \ Filter bits
$00004000 constant CAN_F6R2_FB14                                    \ Filter bits
$00008000 constant CAN_F6R2_FB15                                    \ Filter bits
$00010000 constant CAN_F6R2_FB16                                    \ Filter bits
$00020000 constant CAN_F6R2_FB17                                    \ Filter bits
$00040000 constant CAN_F6R2_FB18                                    \ Filter bits
$00080000 constant CAN_F6R2_FB19                                    \ Filter bits
$00100000 constant CAN_F6R2_FB20                                    \ Filter bits
$00200000 constant CAN_F6R2_FB21                                    \ Filter bits
$00400000 constant CAN_F6R2_FB22                                    \ Filter bits
$00800000 constant CAN_F6R2_FB23                                    \ Filter bits
$01000000 constant CAN_F6R2_FB24                                    \ Filter bits
$02000000 constant CAN_F6R2_FB25                                    \ Filter bits
$04000000 constant CAN_F6R2_FB26                                    \ Filter bits
$08000000 constant CAN_F6R2_FB27                                    \ Filter bits
$10000000 constant CAN_F6R2_FB28                                    \ Filter bits
$20000000 constant CAN_F6R2_FB29                                    \ Filter bits
$40000000 constant CAN_F6R2_FB30                                    \ Filter bits
$80000000 constant CAN_F6R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 7 register 1
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$00000001 constant CAN_F7R1_FB0                                     \ Filter bits
$00000002 constant CAN_F7R1_FB1                                     \ Filter bits
$00000004 constant CAN_F7R1_FB2                                     \ Filter bits
$00000008 constant CAN_F7R1_FB3                                     \ Filter bits
$00000010 constant CAN_F7R1_FB4                                     \ Filter bits
$00000020 constant CAN_F7R1_FB5                                     \ Filter bits
$00000040 constant CAN_F7R1_FB6                                     \ Filter bits
$00000080 constant CAN_F7R1_FB7                                     \ Filter bits
$00000100 constant CAN_F7R1_FB8                                     \ Filter bits
$00000200 constant CAN_F7R1_FB9                                     \ Filter bits
$00000400 constant CAN_F7R1_FB10                                    \ Filter bits
$00000800 constant CAN_F7R1_FB11                                    \ Filter bits
$00001000 constant CAN_F7R1_FB12                                    \ Filter bits
$00002000 constant CAN_F7R1_FB13                                    \ Filter bits
$00004000 constant CAN_F7R1_FB14                                    \ Filter bits
$00008000 constant CAN_F7R1_FB15                                    \ Filter bits
$00010000 constant CAN_F7R1_FB16                                    \ Filter bits
$00020000 constant CAN_F7R1_FB17                                    \ Filter bits
$00040000 constant CAN_F7R1_FB18                                    \ Filter bits
$00080000 constant CAN_F7R1_FB19                                    \ Filter bits
$00100000 constant CAN_F7R1_FB20                                    \ Filter bits
$00200000 constant CAN_F7R1_FB21                                    \ Filter bits
$00400000 constant CAN_F7R1_FB22                                    \ Filter bits
$00800000 constant CAN_F7R1_FB23                                    \ Filter bits
$01000000 constant CAN_F7R1_FB24                                    \ Filter bits
$02000000 constant CAN_F7R1_FB25                                    \ Filter bits
$04000000 constant CAN_F7R1_FB26                                    \ Filter bits
$08000000 constant CAN_F7R1_FB27                                    \ Filter bits
$10000000 constant CAN_F7R1_FB28                                    \ Filter bits
$20000000 constant CAN_F7R1_FB29                                    \ Filter bits
$40000000 constant CAN_F7R1_FB30                                    \ Filter bits
$80000000 constant CAN_F7R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 7 register 2
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000001 constant CAN_F7R2_FB0                                     \ Filter bits
$00000002 constant CAN_F7R2_FB1                                     \ Filter bits
$00000004 constant CAN_F7R2_FB2                                     \ Filter bits
$00000008 constant CAN_F7R2_FB3                                     \ Filter bits
$00000010 constant CAN_F7R2_FB4                                     \ Filter bits
$00000020 constant CAN_F7R2_FB5                                     \ Filter bits
$00000040 constant CAN_F7R2_FB6                                     \ Filter bits
$00000080 constant CAN_F7R2_FB7                                     \ Filter bits
$00000100 constant CAN_F7R2_FB8                                     \ Filter bits
$00000200 constant CAN_F7R2_FB9                                     \ Filter bits
$00000400 constant CAN_F7R2_FB10                                    \ Filter bits
$00000800 constant CAN_F7R2_FB11                                    \ Filter bits
$00001000 constant CAN_F7R2_FB12                                    \ Filter bits
$00002000 constant CAN_F7R2_FB13                                    \ Filter bits
$00004000 constant CAN_F7R2_FB14                                    \ Filter bits
$00008000 constant CAN_F7R2_FB15                                    \ Filter bits
$00010000 constant CAN_F7R2_FB16                                    \ Filter bits
$00020000 constant CAN_F7R2_FB17                                    \ Filter bits
$00040000 constant CAN_F7R2_FB18                                    \ Filter bits
$00080000 constant CAN_F7R2_FB19                                    \ Filter bits
$00100000 constant CAN_F7R2_FB20                                    \ Filter bits
$00200000 constant CAN_F7R2_FB21                                    \ Filter bits
$00400000 constant CAN_F7R2_FB22                                    \ Filter bits
$00800000 constant CAN_F7R2_FB23                                    \ Filter bits
$01000000 constant CAN_F7R2_FB24                                    \ Filter bits
$02000000 constant CAN_F7R2_FB25                                    \ Filter bits
$04000000 constant CAN_F7R2_FB26                                    \ Filter bits
$08000000 constant CAN_F7R2_FB27                                    \ Filter bits
$10000000 constant CAN_F7R2_FB28                                    \ Filter bits
$20000000 constant CAN_F7R2_FB29                                    \ Filter bits
$40000000 constant CAN_F7R2_FB30                                    \ Filter bits
$80000000 constant CAN_F7R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 8 register 1
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant CAN_F8R1_FB0                                     \ Filter bits
$00000002 constant CAN_F8R1_FB1                                     \ Filter bits
$00000004 constant CAN_F8R1_FB2                                     \ Filter bits
$00000008 constant CAN_F8R1_FB3                                     \ Filter bits
$00000010 constant CAN_F8R1_FB4                                     \ Filter bits
$00000020 constant CAN_F8R1_FB5                                     \ Filter bits
$00000040 constant CAN_F8R1_FB6                                     \ Filter bits
$00000080 constant CAN_F8R1_FB7                                     \ Filter bits
$00000100 constant CAN_F8R1_FB8                                     \ Filter bits
$00000200 constant CAN_F8R1_FB9                                     \ Filter bits
$00000400 constant CAN_F8R1_FB10                                    \ Filter bits
$00000800 constant CAN_F8R1_FB11                                    \ Filter bits
$00001000 constant CAN_F8R1_FB12                                    \ Filter bits
$00002000 constant CAN_F8R1_FB13                                    \ Filter bits
$00004000 constant CAN_F8R1_FB14                                    \ Filter bits
$00008000 constant CAN_F8R1_FB15                                    \ Filter bits
$00010000 constant CAN_F8R1_FB16                                    \ Filter bits
$00020000 constant CAN_F8R1_FB17                                    \ Filter bits
$00040000 constant CAN_F8R1_FB18                                    \ Filter bits
$00080000 constant CAN_F8R1_FB19                                    \ Filter bits
$00100000 constant CAN_F8R1_FB20                                    \ Filter bits
$00200000 constant CAN_F8R1_FB21                                    \ Filter bits
$00400000 constant CAN_F8R1_FB22                                    \ Filter bits
$00800000 constant CAN_F8R1_FB23                                    \ Filter bits
$01000000 constant CAN_F8R1_FB24                                    \ Filter bits
$02000000 constant CAN_F8R1_FB25                                    \ Filter bits
$04000000 constant CAN_F8R1_FB26                                    \ Filter bits
$08000000 constant CAN_F8R1_FB27                                    \ Filter bits
$10000000 constant CAN_F8R1_FB28                                    \ Filter bits
$20000000 constant CAN_F8R1_FB29                                    \ Filter bits
$40000000 constant CAN_F8R1_FB30                                    \ Filter bits
$80000000 constant CAN_F8R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 8 register 2
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000001 constant CAN_F8R2_FB0                                     \ Filter bits
$00000002 constant CAN_F8R2_FB1                                     \ Filter bits
$00000004 constant CAN_F8R2_FB2                                     \ Filter bits
$00000008 constant CAN_F8R2_FB3                                     \ Filter bits
$00000010 constant CAN_F8R2_FB4                                     \ Filter bits
$00000020 constant CAN_F8R2_FB5                                     \ Filter bits
$00000040 constant CAN_F8R2_FB6                                     \ Filter bits
$00000080 constant CAN_F8R2_FB7                                     \ Filter bits
$00000100 constant CAN_F8R2_FB8                                     \ Filter bits
$00000200 constant CAN_F8R2_FB9                                     \ Filter bits
$00000400 constant CAN_F8R2_FB10                                    \ Filter bits
$00000800 constant CAN_F8R2_FB11                                    \ Filter bits
$00001000 constant CAN_F8R2_FB12                                    \ Filter bits
$00002000 constant CAN_F8R2_FB13                                    \ Filter bits
$00004000 constant CAN_F8R2_FB14                                    \ Filter bits
$00008000 constant CAN_F8R2_FB15                                    \ Filter bits
$00010000 constant CAN_F8R2_FB16                                    \ Filter bits
$00020000 constant CAN_F8R2_FB17                                    \ Filter bits
$00040000 constant CAN_F8R2_FB18                                    \ Filter bits
$00080000 constant CAN_F8R2_FB19                                    \ Filter bits
$00100000 constant CAN_F8R2_FB20                                    \ Filter bits
$00200000 constant CAN_F8R2_FB21                                    \ Filter bits
$00400000 constant CAN_F8R2_FB22                                    \ Filter bits
$00800000 constant CAN_F8R2_FB23                                    \ Filter bits
$01000000 constant CAN_F8R2_FB24                                    \ Filter bits
$02000000 constant CAN_F8R2_FB25                                    \ Filter bits
$04000000 constant CAN_F8R2_FB26                                    \ Filter bits
$08000000 constant CAN_F8R2_FB27                                    \ Filter bits
$10000000 constant CAN_F8R2_FB28                                    \ Filter bits
$20000000 constant CAN_F8R2_FB29                                    \ Filter bits
$40000000 constant CAN_F8R2_FB30                                    \ Filter bits
$80000000 constant CAN_F8R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 9 register 1
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000001 constant CAN_F9R1_FB0                                     \ Filter bits
$00000002 constant CAN_F9R1_FB1                                     \ Filter bits
$00000004 constant CAN_F9R1_FB2                                     \ Filter bits
$00000008 constant CAN_F9R1_FB3                                     \ Filter bits
$00000010 constant CAN_F9R1_FB4                                     \ Filter bits
$00000020 constant CAN_F9R1_FB5                                     \ Filter bits
$00000040 constant CAN_F9R1_FB6                                     \ Filter bits
$00000080 constant CAN_F9R1_FB7                                     \ Filter bits
$00000100 constant CAN_F9R1_FB8                                     \ Filter bits
$00000200 constant CAN_F9R1_FB9                                     \ Filter bits
$00000400 constant CAN_F9R1_FB10                                    \ Filter bits
$00000800 constant CAN_F9R1_FB11                                    \ Filter bits
$00001000 constant CAN_F9R1_FB12                                    \ Filter bits
$00002000 constant CAN_F9R1_FB13                                    \ Filter bits
$00004000 constant CAN_F9R1_FB14                                    \ Filter bits
$00008000 constant CAN_F9R1_FB15                                    \ Filter bits
$00010000 constant CAN_F9R1_FB16                                    \ Filter bits
$00020000 constant CAN_F9R1_FB17                                    \ Filter bits
$00040000 constant CAN_F9R1_FB18                                    \ Filter bits
$00080000 constant CAN_F9R1_FB19                                    \ Filter bits
$00100000 constant CAN_F9R1_FB20                                    \ Filter bits
$00200000 constant CAN_F9R1_FB21                                    \ Filter bits
$00400000 constant CAN_F9R1_FB22                                    \ Filter bits
$00800000 constant CAN_F9R1_FB23                                    \ Filter bits
$01000000 constant CAN_F9R1_FB24                                    \ Filter bits
$02000000 constant CAN_F9R1_FB25                                    \ Filter bits
$04000000 constant CAN_F9R1_FB26                                    \ Filter bits
$08000000 constant CAN_F9R1_FB27                                    \ Filter bits
$10000000 constant CAN_F9R1_FB28                                    \ Filter bits
$20000000 constant CAN_F9R1_FB29                                    \ Filter bits
$40000000 constant CAN_F9R1_FB30                                    \ Filter bits
$80000000 constant CAN_F9R1_FB31                                    \ Filter bits


\
\ @brief Filter bank 9 register 2
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000001 constant CAN_F9R2_FB0                                     \ Filter bits
$00000002 constant CAN_F9R2_FB1                                     \ Filter bits
$00000004 constant CAN_F9R2_FB2                                     \ Filter bits
$00000008 constant CAN_F9R2_FB3                                     \ Filter bits
$00000010 constant CAN_F9R2_FB4                                     \ Filter bits
$00000020 constant CAN_F9R2_FB5                                     \ Filter bits
$00000040 constant CAN_F9R2_FB6                                     \ Filter bits
$00000080 constant CAN_F9R2_FB7                                     \ Filter bits
$00000100 constant CAN_F9R2_FB8                                     \ Filter bits
$00000200 constant CAN_F9R2_FB9                                     \ Filter bits
$00000400 constant CAN_F9R2_FB10                                    \ Filter bits
$00000800 constant CAN_F9R2_FB11                                    \ Filter bits
$00001000 constant CAN_F9R2_FB12                                    \ Filter bits
$00002000 constant CAN_F9R2_FB13                                    \ Filter bits
$00004000 constant CAN_F9R2_FB14                                    \ Filter bits
$00008000 constant CAN_F9R2_FB15                                    \ Filter bits
$00010000 constant CAN_F9R2_FB16                                    \ Filter bits
$00020000 constant CAN_F9R2_FB17                                    \ Filter bits
$00040000 constant CAN_F9R2_FB18                                    \ Filter bits
$00080000 constant CAN_F9R2_FB19                                    \ Filter bits
$00100000 constant CAN_F9R2_FB20                                    \ Filter bits
$00200000 constant CAN_F9R2_FB21                                    \ Filter bits
$00400000 constant CAN_F9R2_FB22                                    \ Filter bits
$00800000 constant CAN_F9R2_FB23                                    \ Filter bits
$01000000 constant CAN_F9R2_FB24                                    \ Filter bits
$02000000 constant CAN_F9R2_FB25                                    \ Filter bits
$04000000 constant CAN_F9R2_FB26                                    \ Filter bits
$08000000 constant CAN_F9R2_FB27                                    \ Filter bits
$10000000 constant CAN_F9R2_FB28                                    \ Filter bits
$20000000 constant CAN_F9R2_FB29                                    \ Filter bits
$40000000 constant CAN_F9R2_FB30                                    \ Filter bits
$80000000 constant CAN_F9R2_FB31                                    \ Filter bits


\
\ @brief Filter bank 10 register 1
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000001 constant CAN_F10R1_FB0                                    \ Filter bits
$00000002 constant CAN_F10R1_FB1                                    \ Filter bits
$00000004 constant CAN_F10R1_FB2                                    \ Filter bits
$00000008 constant CAN_F10R1_FB3                                    \ Filter bits
$00000010 constant CAN_F10R1_FB4                                    \ Filter bits
$00000020 constant CAN_F10R1_FB5                                    \ Filter bits
$00000040 constant CAN_F10R1_FB6                                    \ Filter bits
$00000080 constant CAN_F10R1_FB7                                    \ Filter bits
$00000100 constant CAN_F10R1_FB8                                    \ Filter bits
$00000200 constant CAN_F10R1_FB9                                    \ Filter bits
$00000400 constant CAN_F10R1_FB10                                   \ Filter bits
$00000800 constant CAN_F10R1_FB11                                   \ Filter bits
$00001000 constant CAN_F10R1_FB12                                   \ Filter bits
$00002000 constant CAN_F10R1_FB13                                   \ Filter bits
$00004000 constant CAN_F10R1_FB14                                   \ Filter bits
$00008000 constant CAN_F10R1_FB15                                   \ Filter bits
$00010000 constant CAN_F10R1_FB16                                   \ Filter bits
$00020000 constant CAN_F10R1_FB17                                   \ Filter bits
$00040000 constant CAN_F10R1_FB18                                   \ Filter bits
$00080000 constant CAN_F10R1_FB19                                   \ Filter bits
$00100000 constant CAN_F10R1_FB20                                   \ Filter bits
$00200000 constant CAN_F10R1_FB21                                   \ Filter bits
$00400000 constant CAN_F10R1_FB22                                   \ Filter bits
$00800000 constant CAN_F10R1_FB23                                   \ Filter bits
$01000000 constant CAN_F10R1_FB24                                   \ Filter bits
$02000000 constant CAN_F10R1_FB25                                   \ Filter bits
$04000000 constant CAN_F10R1_FB26                                   \ Filter bits
$08000000 constant CAN_F10R1_FB27                                   \ Filter bits
$10000000 constant CAN_F10R1_FB28                                   \ Filter bits
$20000000 constant CAN_F10R1_FB29                                   \ Filter bits
$40000000 constant CAN_F10R1_FB30                                   \ Filter bits
$80000000 constant CAN_F10R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 10 register 2
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00000001 constant CAN_F10R2_FB0                                    \ Filter bits
$00000002 constant CAN_F10R2_FB1                                    \ Filter bits
$00000004 constant CAN_F10R2_FB2                                    \ Filter bits
$00000008 constant CAN_F10R2_FB3                                    \ Filter bits
$00000010 constant CAN_F10R2_FB4                                    \ Filter bits
$00000020 constant CAN_F10R2_FB5                                    \ Filter bits
$00000040 constant CAN_F10R2_FB6                                    \ Filter bits
$00000080 constant CAN_F10R2_FB7                                    \ Filter bits
$00000100 constant CAN_F10R2_FB8                                    \ Filter bits
$00000200 constant CAN_F10R2_FB9                                    \ Filter bits
$00000400 constant CAN_F10R2_FB10                                   \ Filter bits
$00000800 constant CAN_F10R2_FB11                                   \ Filter bits
$00001000 constant CAN_F10R2_FB12                                   \ Filter bits
$00002000 constant CAN_F10R2_FB13                                   \ Filter bits
$00004000 constant CAN_F10R2_FB14                                   \ Filter bits
$00008000 constant CAN_F10R2_FB15                                   \ Filter bits
$00010000 constant CAN_F10R2_FB16                                   \ Filter bits
$00020000 constant CAN_F10R2_FB17                                   \ Filter bits
$00040000 constant CAN_F10R2_FB18                                   \ Filter bits
$00080000 constant CAN_F10R2_FB19                                   \ Filter bits
$00100000 constant CAN_F10R2_FB20                                   \ Filter bits
$00200000 constant CAN_F10R2_FB21                                   \ Filter bits
$00400000 constant CAN_F10R2_FB22                                   \ Filter bits
$00800000 constant CAN_F10R2_FB23                                   \ Filter bits
$01000000 constant CAN_F10R2_FB24                                   \ Filter bits
$02000000 constant CAN_F10R2_FB25                                   \ Filter bits
$04000000 constant CAN_F10R2_FB26                                   \ Filter bits
$08000000 constant CAN_F10R2_FB27                                   \ Filter bits
$10000000 constant CAN_F10R2_FB28                                   \ Filter bits
$20000000 constant CAN_F10R2_FB29                                   \ Filter bits
$40000000 constant CAN_F10R2_FB30                                   \ Filter bits
$80000000 constant CAN_F10R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 11 register 1
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000001 constant CAN_F11R1_FB0                                    \ Filter bits
$00000002 constant CAN_F11R1_FB1                                    \ Filter bits
$00000004 constant CAN_F11R1_FB2                                    \ Filter bits
$00000008 constant CAN_F11R1_FB3                                    \ Filter bits
$00000010 constant CAN_F11R1_FB4                                    \ Filter bits
$00000020 constant CAN_F11R1_FB5                                    \ Filter bits
$00000040 constant CAN_F11R1_FB6                                    \ Filter bits
$00000080 constant CAN_F11R1_FB7                                    \ Filter bits
$00000100 constant CAN_F11R1_FB8                                    \ Filter bits
$00000200 constant CAN_F11R1_FB9                                    \ Filter bits
$00000400 constant CAN_F11R1_FB10                                   \ Filter bits
$00000800 constant CAN_F11R1_FB11                                   \ Filter bits
$00001000 constant CAN_F11R1_FB12                                   \ Filter bits
$00002000 constant CAN_F11R1_FB13                                   \ Filter bits
$00004000 constant CAN_F11R1_FB14                                   \ Filter bits
$00008000 constant CAN_F11R1_FB15                                   \ Filter bits
$00010000 constant CAN_F11R1_FB16                                   \ Filter bits
$00020000 constant CAN_F11R1_FB17                                   \ Filter bits
$00040000 constant CAN_F11R1_FB18                                   \ Filter bits
$00080000 constant CAN_F11R1_FB19                                   \ Filter bits
$00100000 constant CAN_F11R1_FB20                                   \ Filter bits
$00200000 constant CAN_F11R1_FB21                                   \ Filter bits
$00400000 constant CAN_F11R1_FB22                                   \ Filter bits
$00800000 constant CAN_F11R1_FB23                                   \ Filter bits
$01000000 constant CAN_F11R1_FB24                                   \ Filter bits
$02000000 constant CAN_F11R1_FB25                                   \ Filter bits
$04000000 constant CAN_F11R1_FB26                                   \ Filter bits
$08000000 constant CAN_F11R1_FB27                                   \ Filter bits
$10000000 constant CAN_F11R1_FB28                                   \ Filter bits
$20000000 constant CAN_F11R1_FB29                                   \ Filter bits
$40000000 constant CAN_F11R1_FB30                                   \ Filter bits
$80000000 constant CAN_F11R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 11 register 2
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000001 constant CAN_F11R2_FB0                                    \ Filter bits
$00000002 constant CAN_F11R2_FB1                                    \ Filter bits
$00000004 constant CAN_F11R2_FB2                                    \ Filter bits
$00000008 constant CAN_F11R2_FB3                                    \ Filter bits
$00000010 constant CAN_F11R2_FB4                                    \ Filter bits
$00000020 constant CAN_F11R2_FB5                                    \ Filter bits
$00000040 constant CAN_F11R2_FB6                                    \ Filter bits
$00000080 constant CAN_F11R2_FB7                                    \ Filter bits
$00000100 constant CAN_F11R2_FB8                                    \ Filter bits
$00000200 constant CAN_F11R2_FB9                                    \ Filter bits
$00000400 constant CAN_F11R2_FB10                                   \ Filter bits
$00000800 constant CAN_F11R2_FB11                                   \ Filter bits
$00001000 constant CAN_F11R2_FB12                                   \ Filter bits
$00002000 constant CAN_F11R2_FB13                                   \ Filter bits
$00004000 constant CAN_F11R2_FB14                                   \ Filter bits
$00008000 constant CAN_F11R2_FB15                                   \ Filter bits
$00010000 constant CAN_F11R2_FB16                                   \ Filter bits
$00020000 constant CAN_F11R2_FB17                                   \ Filter bits
$00040000 constant CAN_F11R2_FB18                                   \ Filter bits
$00080000 constant CAN_F11R2_FB19                                   \ Filter bits
$00100000 constant CAN_F11R2_FB20                                   \ Filter bits
$00200000 constant CAN_F11R2_FB21                                   \ Filter bits
$00400000 constant CAN_F11R2_FB22                                   \ Filter bits
$00800000 constant CAN_F11R2_FB23                                   \ Filter bits
$01000000 constant CAN_F11R2_FB24                                   \ Filter bits
$02000000 constant CAN_F11R2_FB25                                   \ Filter bits
$04000000 constant CAN_F11R2_FB26                                   \ Filter bits
$08000000 constant CAN_F11R2_FB27                                   \ Filter bits
$10000000 constant CAN_F11R2_FB28                                   \ Filter bits
$20000000 constant CAN_F11R2_FB29                                   \ Filter bits
$40000000 constant CAN_F11R2_FB30                                   \ Filter bits
$80000000 constant CAN_F11R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 4 register 1
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000001 constant CAN_F12R1_FB0                                    \ Filter bits
$00000002 constant CAN_F12R1_FB1                                    \ Filter bits
$00000004 constant CAN_F12R1_FB2                                    \ Filter bits
$00000008 constant CAN_F12R1_FB3                                    \ Filter bits
$00000010 constant CAN_F12R1_FB4                                    \ Filter bits
$00000020 constant CAN_F12R1_FB5                                    \ Filter bits
$00000040 constant CAN_F12R1_FB6                                    \ Filter bits
$00000080 constant CAN_F12R1_FB7                                    \ Filter bits
$00000100 constant CAN_F12R1_FB8                                    \ Filter bits
$00000200 constant CAN_F12R1_FB9                                    \ Filter bits
$00000400 constant CAN_F12R1_FB10                                   \ Filter bits
$00000800 constant CAN_F12R1_FB11                                   \ Filter bits
$00001000 constant CAN_F12R1_FB12                                   \ Filter bits
$00002000 constant CAN_F12R1_FB13                                   \ Filter bits
$00004000 constant CAN_F12R1_FB14                                   \ Filter bits
$00008000 constant CAN_F12R1_FB15                                   \ Filter bits
$00010000 constant CAN_F12R1_FB16                                   \ Filter bits
$00020000 constant CAN_F12R1_FB17                                   \ Filter bits
$00040000 constant CAN_F12R1_FB18                                   \ Filter bits
$00080000 constant CAN_F12R1_FB19                                   \ Filter bits
$00100000 constant CAN_F12R1_FB20                                   \ Filter bits
$00200000 constant CAN_F12R1_FB21                                   \ Filter bits
$00400000 constant CAN_F12R1_FB22                                   \ Filter bits
$00800000 constant CAN_F12R1_FB23                                   \ Filter bits
$01000000 constant CAN_F12R1_FB24                                   \ Filter bits
$02000000 constant CAN_F12R1_FB25                                   \ Filter bits
$04000000 constant CAN_F12R1_FB26                                   \ Filter bits
$08000000 constant CAN_F12R1_FB27                                   \ Filter bits
$10000000 constant CAN_F12R1_FB28                                   \ Filter bits
$20000000 constant CAN_F12R1_FB29                                   \ Filter bits
$40000000 constant CAN_F12R1_FB30                                   \ Filter bits
$80000000 constant CAN_F12R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 12 register 2
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$00000001 constant CAN_F12R2_FB0                                    \ Filter bits
$00000002 constant CAN_F12R2_FB1                                    \ Filter bits
$00000004 constant CAN_F12R2_FB2                                    \ Filter bits
$00000008 constant CAN_F12R2_FB3                                    \ Filter bits
$00000010 constant CAN_F12R2_FB4                                    \ Filter bits
$00000020 constant CAN_F12R2_FB5                                    \ Filter bits
$00000040 constant CAN_F12R2_FB6                                    \ Filter bits
$00000080 constant CAN_F12R2_FB7                                    \ Filter bits
$00000100 constant CAN_F12R2_FB8                                    \ Filter bits
$00000200 constant CAN_F12R2_FB9                                    \ Filter bits
$00000400 constant CAN_F12R2_FB10                                   \ Filter bits
$00000800 constant CAN_F12R2_FB11                                   \ Filter bits
$00001000 constant CAN_F12R2_FB12                                   \ Filter bits
$00002000 constant CAN_F12R2_FB13                                   \ Filter bits
$00004000 constant CAN_F12R2_FB14                                   \ Filter bits
$00008000 constant CAN_F12R2_FB15                                   \ Filter bits
$00010000 constant CAN_F12R2_FB16                                   \ Filter bits
$00020000 constant CAN_F12R2_FB17                                   \ Filter bits
$00040000 constant CAN_F12R2_FB18                                   \ Filter bits
$00080000 constant CAN_F12R2_FB19                                   \ Filter bits
$00100000 constant CAN_F12R2_FB20                                   \ Filter bits
$00200000 constant CAN_F12R2_FB21                                   \ Filter bits
$00400000 constant CAN_F12R2_FB22                                   \ Filter bits
$00800000 constant CAN_F12R2_FB23                                   \ Filter bits
$01000000 constant CAN_F12R2_FB24                                   \ Filter bits
$02000000 constant CAN_F12R2_FB25                                   \ Filter bits
$04000000 constant CAN_F12R2_FB26                                   \ Filter bits
$08000000 constant CAN_F12R2_FB27                                   \ Filter bits
$10000000 constant CAN_F12R2_FB28                                   \ Filter bits
$20000000 constant CAN_F12R2_FB29                                   \ Filter bits
$40000000 constant CAN_F12R2_FB30                                   \ Filter bits
$80000000 constant CAN_F12R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 13 register 1
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$00000001 constant CAN_F13R1_FB0                                    \ Filter bits
$00000002 constant CAN_F13R1_FB1                                    \ Filter bits
$00000004 constant CAN_F13R1_FB2                                    \ Filter bits
$00000008 constant CAN_F13R1_FB3                                    \ Filter bits
$00000010 constant CAN_F13R1_FB4                                    \ Filter bits
$00000020 constant CAN_F13R1_FB5                                    \ Filter bits
$00000040 constant CAN_F13R1_FB6                                    \ Filter bits
$00000080 constant CAN_F13R1_FB7                                    \ Filter bits
$00000100 constant CAN_F13R1_FB8                                    \ Filter bits
$00000200 constant CAN_F13R1_FB9                                    \ Filter bits
$00000400 constant CAN_F13R1_FB10                                   \ Filter bits
$00000800 constant CAN_F13R1_FB11                                   \ Filter bits
$00001000 constant CAN_F13R1_FB12                                   \ Filter bits
$00002000 constant CAN_F13R1_FB13                                   \ Filter bits
$00004000 constant CAN_F13R1_FB14                                   \ Filter bits
$00008000 constant CAN_F13R1_FB15                                   \ Filter bits
$00010000 constant CAN_F13R1_FB16                                   \ Filter bits
$00020000 constant CAN_F13R1_FB17                                   \ Filter bits
$00040000 constant CAN_F13R1_FB18                                   \ Filter bits
$00080000 constant CAN_F13R1_FB19                                   \ Filter bits
$00100000 constant CAN_F13R1_FB20                                   \ Filter bits
$00200000 constant CAN_F13R1_FB21                                   \ Filter bits
$00400000 constant CAN_F13R1_FB22                                   \ Filter bits
$00800000 constant CAN_F13R1_FB23                                   \ Filter bits
$01000000 constant CAN_F13R1_FB24                                   \ Filter bits
$02000000 constant CAN_F13R1_FB25                                   \ Filter bits
$04000000 constant CAN_F13R1_FB26                                   \ Filter bits
$08000000 constant CAN_F13R1_FB27                                   \ Filter bits
$10000000 constant CAN_F13R1_FB28                                   \ Filter bits
$20000000 constant CAN_F13R1_FB29                                   \ Filter bits
$40000000 constant CAN_F13R1_FB30                                   \ Filter bits
$80000000 constant CAN_F13R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 13 register 2
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$00000001 constant CAN_F13R2_FB0                                    \ Filter bits
$00000002 constant CAN_F13R2_FB1                                    \ Filter bits
$00000004 constant CAN_F13R2_FB2                                    \ Filter bits
$00000008 constant CAN_F13R2_FB3                                    \ Filter bits
$00000010 constant CAN_F13R2_FB4                                    \ Filter bits
$00000020 constant CAN_F13R2_FB5                                    \ Filter bits
$00000040 constant CAN_F13R2_FB6                                    \ Filter bits
$00000080 constant CAN_F13R2_FB7                                    \ Filter bits
$00000100 constant CAN_F13R2_FB8                                    \ Filter bits
$00000200 constant CAN_F13R2_FB9                                    \ Filter bits
$00000400 constant CAN_F13R2_FB10                                   \ Filter bits
$00000800 constant CAN_F13R2_FB11                                   \ Filter bits
$00001000 constant CAN_F13R2_FB12                                   \ Filter bits
$00002000 constant CAN_F13R2_FB13                                   \ Filter bits
$00004000 constant CAN_F13R2_FB14                                   \ Filter bits
$00008000 constant CAN_F13R2_FB15                                   \ Filter bits
$00010000 constant CAN_F13R2_FB16                                   \ Filter bits
$00020000 constant CAN_F13R2_FB17                                   \ Filter bits
$00040000 constant CAN_F13R2_FB18                                   \ Filter bits
$00080000 constant CAN_F13R2_FB19                                   \ Filter bits
$00100000 constant CAN_F13R2_FB20                                   \ Filter bits
$00200000 constant CAN_F13R2_FB21                                   \ Filter bits
$00400000 constant CAN_F13R2_FB22                                   \ Filter bits
$00800000 constant CAN_F13R2_FB23                                   \ Filter bits
$01000000 constant CAN_F13R2_FB24                                   \ Filter bits
$02000000 constant CAN_F13R2_FB25                                   \ Filter bits
$04000000 constant CAN_F13R2_FB26                                   \ Filter bits
$08000000 constant CAN_F13R2_FB27                                   \ Filter bits
$10000000 constant CAN_F13R2_FB28                                   \ Filter bits
$20000000 constant CAN_F13R2_FB29                                   \ Filter bits
$40000000 constant CAN_F13R2_FB30                                   \ Filter bits
$80000000 constant CAN_F13R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 14 register 1
\ Address offset: 0x2B0
\ Reset value: 0x00000000
\

$00000001 constant CAN_F14R1_FB0                                    \ Filter bits
$00000002 constant CAN_F14R1_FB1                                    \ Filter bits
$00000004 constant CAN_F14R1_FB2                                    \ Filter bits
$00000008 constant CAN_F14R1_FB3                                    \ Filter bits
$00000010 constant CAN_F14R1_FB4                                    \ Filter bits
$00000020 constant CAN_F14R1_FB5                                    \ Filter bits
$00000040 constant CAN_F14R1_FB6                                    \ Filter bits
$00000080 constant CAN_F14R1_FB7                                    \ Filter bits
$00000100 constant CAN_F14R1_FB8                                    \ Filter bits
$00000200 constant CAN_F14R1_FB9                                    \ Filter bits
$00000400 constant CAN_F14R1_FB10                                   \ Filter bits
$00000800 constant CAN_F14R1_FB11                                   \ Filter bits
$00001000 constant CAN_F14R1_FB12                                   \ Filter bits
$00002000 constant CAN_F14R1_FB13                                   \ Filter bits
$00004000 constant CAN_F14R1_FB14                                   \ Filter bits
$00008000 constant CAN_F14R1_FB15                                   \ Filter bits
$00010000 constant CAN_F14R1_FB16                                   \ Filter bits
$00020000 constant CAN_F14R1_FB17                                   \ Filter bits
$00040000 constant CAN_F14R1_FB18                                   \ Filter bits
$00080000 constant CAN_F14R1_FB19                                   \ Filter bits
$00100000 constant CAN_F14R1_FB20                                   \ Filter bits
$00200000 constant CAN_F14R1_FB21                                   \ Filter bits
$00400000 constant CAN_F14R1_FB22                                   \ Filter bits
$00800000 constant CAN_F14R1_FB23                                   \ Filter bits
$01000000 constant CAN_F14R1_FB24                                   \ Filter bits
$02000000 constant CAN_F14R1_FB25                                   \ Filter bits
$04000000 constant CAN_F14R1_FB26                                   \ Filter bits
$08000000 constant CAN_F14R1_FB27                                   \ Filter bits
$10000000 constant CAN_F14R1_FB28                                   \ Filter bits
$20000000 constant CAN_F14R1_FB29                                   \ Filter bits
$40000000 constant CAN_F14R1_FB30                                   \ Filter bits
$80000000 constant CAN_F14R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 14 register 2
\ Address offset: 0x2B4
\ Reset value: 0x00000000
\

$00000001 constant CAN_F14R2_FB0                                    \ Filter bits
$00000002 constant CAN_F14R2_FB1                                    \ Filter bits
$00000004 constant CAN_F14R2_FB2                                    \ Filter bits
$00000008 constant CAN_F14R2_FB3                                    \ Filter bits
$00000010 constant CAN_F14R2_FB4                                    \ Filter bits
$00000020 constant CAN_F14R2_FB5                                    \ Filter bits
$00000040 constant CAN_F14R2_FB6                                    \ Filter bits
$00000080 constant CAN_F14R2_FB7                                    \ Filter bits
$00000100 constant CAN_F14R2_FB8                                    \ Filter bits
$00000200 constant CAN_F14R2_FB9                                    \ Filter bits
$00000400 constant CAN_F14R2_FB10                                   \ Filter bits
$00000800 constant CAN_F14R2_FB11                                   \ Filter bits
$00001000 constant CAN_F14R2_FB12                                   \ Filter bits
$00002000 constant CAN_F14R2_FB13                                   \ Filter bits
$00004000 constant CAN_F14R2_FB14                                   \ Filter bits
$00008000 constant CAN_F14R2_FB15                                   \ Filter bits
$00010000 constant CAN_F14R2_FB16                                   \ Filter bits
$00020000 constant CAN_F14R2_FB17                                   \ Filter bits
$00040000 constant CAN_F14R2_FB18                                   \ Filter bits
$00080000 constant CAN_F14R2_FB19                                   \ Filter bits
$00100000 constant CAN_F14R2_FB20                                   \ Filter bits
$00200000 constant CAN_F14R2_FB21                                   \ Filter bits
$00400000 constant CAN_F14R2_FB22                                   \ Filter bits
$00800000 constant CAN_F14R2_FB23                                   \ Filter bits
$01000000 constant CAN_F14R2_FB24                                   \ Filter bits
$02000000 constant CAN_F14R2_FB25                                   \ Filter bits
$04000000 constant CAN_F14R2_FB26                                   \ Filter bits
$08000000 constant CAN_F14R2_FB27                                   \ Filter bits
$10000000 constant CAN_F14R2_FB28                                   \ Filter bits
$20000000 constant CAN_F14R2_FB29                                   \ Filter bits
$40000000 constant CAN_F14R2_FB30                                   \ Filter bits
$80000000 constant CAN_F14R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 15 register 1
\ Address offset: 0x2B8
\ Reset value: 0x00000000
\

$00000001 constant CAN_F15R1_FB0                                    \ Filter bits
$00000002 constant CAN_F15R1_FB1                                    \ Filter bits
$00000004 constant CAN_F15R1_FB2                                    \ Filter bits
$00000008 constant CAN_F15R1_FB3                                    \ Filter bits
$00000010 constant CAN_F15R1_FB4                                    \ Filter bits
$00000020 constant CAN_F15R1_FB5                                    \ Filter bits
$00000040 constant CAN_F15R1_FB6                                    \ Filter bits
$00000080 constant CAN_F15R1_FB7                                    \ Filter bits
$00000100 constant CAN_F15R1_FB8                                    \ Filter bits
$00000200 constant CAN_F15R1_FB9                                    \ Filter bits
$00000400 constant CAN_F15R1_FB10                                   \ Filter bits
$00000800 constant CAN_F15R1_FB11                                   \ Filter bits
$00001000 constant CAN_F15R1_FB12                                   \ Filter bits
$00002000 constant CAN_F15R1_FB13                                   \ Filter bits
$00004000 constant CAN_F15R1_FB14                                   \ Filter bits
$00008000 constant CAN_F15R1_FB15                                   \ Filter bits
$00010000 constant CAN_F15R1_FB16                                   \ Filter bits
$00020000 constant CAN_F15R1_FB17                                   \ Filter bits
$00040000 constant CAN_F15R1_FB18                                   \ Filter bits
$00080000 constant CAN_F15R1_FB19                                   \ Filter bits
$00100000 constant CAN_F15R1_FB20                                   \ Filter bits
$00200000 constant CAN_F15R1_FB21                                   \ Filter bits
$00400000 constant CAN_F15R1_FB22                                   \ Filter bits
$00800000 constant CAN_F15R1_FB23                                   \ Filter bits
$01000000 constant CAN_F15R1_FB24                                   \ Filter bits
$02000000 constant CAN_F15R1_FB25                                   \ Filter bits
$04000000 constant CAN_F15R1_FB26                                   \ Filter bits
$08000000 constant CAN_F15R1_FB27                                   \ Filter bits
$10000000 constant CAN_F15R1_FB28                                   \ Filter bits
$20000000 constant CAN_F15R1_FB29                                   \ Filter bits
$40000000 constant CAN_F15R1_FB30                                   \ Filter bits
$80000000 constant CAN_F15R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 15 register 2
\ Address offset: 0x2BC
\ Reset value: 0x00000000
\

$00000001 constant CAN_F15R2_FB0                                    \ Filter bits
$00000002 constant CAN_F15R2_FB1                                    \ Filter bits
$00000004 constant CAN_F15R2_FB2                                    \ Filter bits
$00000008 constant CAN_F15R2_FB3                                    \ Filter bits
$00000010 constant CAN_F15R2_FB4                                    \ Filter bits
$00000020 constant CAN_F15R2_FB5                                    \ Filter bits
$00000040 constant CAN_F15R2_FB6                                    \ Filter bits
$00000080 constant CAN_F15R2_FB7                                    \ Filter bits
$00000100 constant CAN_F15R2_FB8                                    \ Filter bits
$00000200 constant CAN_F15R2_FB9                                    \ Filter bits
$00000400 constant CAN_F15R2_FB10                                   \ Filter bits
$00000800 constant CAN_F15R2_FB11                                   \ Filter bits
$00001000 constant CAN_F15R2_FB12                                   \ Filter bits
$00002000 constant CAN_F15R2_FB13                                   \ Filter bits
$00004000 constant CAN_F15R2_FB14                                   \ Filter bits
$00008000 constant CAN_F15R2_FB15                                   \ Filter bits
$00010000 constant CAN_F15R2_FB16                                   \ Filter bits
$00020000 constant CAN_F15R2_FB17                                   \ Filter bits
$00040000 constant CAN_F15R2_FB18                                   \ Filter bits
$00080000 constant CAN_F15R2_FB19                                   \ Filter bits
$00100000 constant CAN_F15R2_FB20                                   \ Filter bits
$00200000 constant CAN_F15R2_FB21                                   \ Filter bits
$00400000 constant CAN_F15R2_FB22                                   \ Filter bits
$00800000 constant CAN_F15R2_FB23                                   \ Filter bits
$01000000 constant CAN_F15R2_FB24                                   \ Filter bits
$02000000 constant CAN_F15R2_FB25                                   \ Filter bits
$04000000 constant CAN_F15R2_FB26                                   \ Filter bits
$08000000 constant CAN_F15R2_FB27                                   \ Filter bits
$10000000 constant CAN_F15R2_FB28                                   \ Filter bits
$20000000 constant CAN_F15R2_FB29                                   \ Filter bits
$40000000 constant CAN_F15R2_FB30                                   \ Filter bits
$80000000 constant CAN_F15R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 16 register 1
\ Address offset: 0x2C0
\ Reset value: 0x00000000
\

$00000001 constant CAN_F16R1_FB0                                    \ Filter bits
$00000002 constant CAN_F16R1_FB1                                    \ Filter bits
$00000004 constant CAN_F16R1_FB2                                    \ Filter bits
$00000008 constant CAN_F16R1_FB3                                    \ Filter bits
$00000010 constant CAN_F16R1_FB4                                    \ Filter bits
$00000020 constant CAN_F16R1_FB5                                    \ Filter bits
$00000040 constant CAN_F16R1_FB6                                    \ Filter bits
$00000080 constant CAN_F16R1_FB7                                    \ Filter bits
$00000100 constant CAN_F16R1_FB8                                    \ Filter bits
$00000200 constant CAN_F16R1_FB9                                    \ Filter bits
$00000400 constant CAN_F16R1_FB10                                   \ Filter bits
$00000800 constant CAN_F16R1_FB11                                   \ Filter bits
$00001000 constant CAN_F16R1_FB12                                   \ Filter bits
$00002000 constant CAN_F16R1_FB13                                   \ Filter bits
$00004000 constant CAN_F16R1_FB14                                   \ Filter bits
$00008000 constant CAN_F16R1_FB15                                   \ Filter bits
$00010000 constant CAN_F16R1_FB16                                   \ Filter bits
$00020000 constant CAN_F16R1_FB17                                   \ Filter bits
$00040000 constant CAN_F16R1_FB18                                   \ Filter bits
$00080000 constant CAN_F16R1_FB19                                   \ Filter bits
$00100000 constant CAN_F16R1_FB20                                   \ Filter bits
$00200000 constant CAN_F16R1_FB21                                   \ Filter bits
$00400000 constant CAN_F16R1_FB22                                   \ Filter bits
$00800000 constant CAN_F16R1_FB23                                   \ Filter bits
$01000000 constant CAN_F16R1_FB24                                   \ Filter bits
$02000000 constant CAN_F16R1_FB25                                   \ Filter bits
$04000000 constant CAN_F16R1_FB26                                   \ Filter bits
$08000000 constant CAN_F16R1_FB27                                   \ Filter bits
$10000000 constant CAN_F16R1_FB28                                   \ Filter bits
$20000000 constant CAN_F16R1_FB29                                   \ Filter bits
$40000000 constant CAN_F16R1_FB30                                   \ Filter bits
$80000000 constant CAN_F16R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 16 register 2
\ Address offset: 0x2C4
\ Reset value: 0x00000000
\

$00000001 constant CAN_F16R2_FB0                                    \ Filter bits
$00000002 constant CAN_F16R2_FB1                                    \ Filter bits
$00000004 constant CAN_F16R2_FB2                                    \ Filter bits
$00000008 constant CAN_F16R2_FB3                                    \ Filter bits
$00000010 constant CAN_F16R2_FB4                                    \ Filter bits
$00000020 constant CAN_F16R2_FB5                                    \ Filter bits
$00000040 constant CAN_F16R2_FB6                                    \ Filter bits
$00000080 constant CAN_F16R2_FB7                                    \ Filter bits
$00000100 constant CAN_F16R2_FB8                                    \ Filter bits
$00000200 constant CAN_F16R2_FB9                                    \ Filter bits
$00000400 constant CAN_F16R2_FB10                                   \ Filter bits
$00000800 constant CAN_F16R2_FB11                                   \ Filter bits
$00001000 constant CAN_F16R2_FB12                                   \ Filter bits
$00002000 constant CAN_F16R2_FB13                                   \ Filter bits
$00004000 constant CAN_F16R2_FB14                                   \ Filter bits
$00008000 constant CAN_F16R2_FB15                                   \ Filter bits
$00010000 constant CAN_F16R2_FB16                                   \ Filter bits
$00020000 constant CAN_F16R2_FB17                                   \ Filter bits
$00040000 constant CAN_F16R2_FB18                                   \ Filter bits
$00080000 constant CAN_F16R2_FB19                                   \ Filter bits
$00100000 constant CAN_F16R2_FB20                                   \ Filter bits
$00200000 constant CAN_F16R2_FB21                                   \ Filter bits
$00400000 constant CAN_F16R2_FB22                                   \ Filter bits
$00800000 constant CAN_F16R2_FB23                                   \ Filter bits
$01000000 constant CAN_F16R2_FB24                                   \ Filter bits
$02000000 constant CAN_F16R2_FB25                                   \ Filter bits
$04000000 constant CAN_F16R2_FB26                                   \ Filter bits
$08000000 constant CAN_F16R2_FB27                                   \ Filter bits
$10000000 constant CAN_F16R2_FB28                                   \ Filter bits
$20000000 constant CAN_F16R2_FB29                                   \ Filter bits
$40000000 constant CAN_F16R2_FB30                                   \ Filter bits
$80000000 constant CAN_F16R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 17 register 1
\ Address offset: 0x2C8
\ Reset value: 0x00000000
\

$00000001 constant CAN_F17R1_FB0                                    \ Filter bits
$00000002 constant CAN_F17R1_FB1                                    \ Filter bits
$00000004 constant CAN_F17R1_FB2                                    \ Filter bits
$00000008 constant CAN_F17R1_FB3                                    \ Filter bits
$00000010 constant CAN_F17R1_FB4                                    \ Filter bits
$00000020 constant CAN_F17R1_FB5                                    \ Filter bits
$00000040 constant CAN_F17R1_FB6                                    \ Filter bits
$00000080 constant CAN_F17R1_FB7                                    \ Filter bits
$00000100 constant CAN_F17R1_FB8                                    \ Filter bits
$00000200 constant CAN_F17R1_FB9                                    \ Filter bits
$00000400 constant CAN_F17R1_FB10                                   \ Filter bits
$00000800 constant CAN_F17R1_FB11                                   \ Filter bits
$00001000 constant CAN_F17R1_FB12                                   \ Filter bits
$00002000 constant CAN_F17R1_FB13                                   \ Filter bits
$00004000 constant CAN_F17R1_FB14                                   \ Filter bits
$00008000 constant CAN_F17R1_FB15                                   \ Filter bits
$00010000 constant CAN_F17R1_FB16                                   \ Filter bits
$00020000 constant CAN_F17R1_FB17                                   \ Filter bits
$00040000 constant CAN_F17R1_FB18                                   \ Filter bits
$00080000 constant CAN_F17R1_FB19                                   \ Filter bits
$00100000 constant CAN_F17R1_FB20                                   \ Filter bits
$00200000 constant CAN_F17R1_FB21                                   \ Filter bits
$00400000 constant CAN_F17R1_FB22                                   \ Filter bits
$00800000 constant CAN_F17R1_FB23                                   \ Filter bits
$01000000 constant CAN_F17R1_FB24                                   \ Filter bits
$02000000 constant CAN_F17R1_FB25                                   \ Filter bits
$04000000 constant CAN_F17R1_FB26                                   \ Filter bits
$08000000 constant CAN_F17R1_FB27                                   \ Filter bits
$10000000 constant CAN_F17R1_FB28                                   \ Filter bits
$20000000 constant CAN_F17R1_FB29                                   \ Filter bits
$40000000 constant CAN_F17R1_FB30                                   \ Filter bits
$80000000 constant CAN_F17R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 17 register 2
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$00000001 constant CAN_F17R2_FB0                                    \ Filter bits
$00000002 constant CAN_F17R2_FB1                                    \ Filter bits
$00000004 constant CAN_F17R2_FB2                                    \ Filter bits
$00000008 constant CAN_F17R2_FB3                                    \ Filter bits
$00000010 constant CAN_F17R2_FB4                                    \ Filter bits
$00000020 constant CAN_F17R2_FB5                                    \ Filter bits
$00000040 constant CAN_F17R2_FB6                                    \ Filter bits
$00000080 constant CAN_F17R2_FB7                                    \ Filter bits
$00000100 constant CAN_F17R2_FB8                                    \ Filter bits
$00000200 constant CAN_F17R2_FB9                                    \ Filter bits
$00000400 constant CAN_F17R2_FB10                                   \ Filter bits
$00000800 constant CAN_F17R2_FB11                                   \ Filter bits
$00001000 constant CAN_F17R2_FB12                                   \ Filter bits
$00002000 constant CAN_F17R2_FB13                                   \ Filter bits
$00004000 constant CAN_F17R2_FB14                                   \ Filter bits
$00008000 constant CAN_F17R2_FB15                                   \ Filter bits
$00010000 constant CAN_F17R2_FB16                                   \ Filter bits
$00020000 constant CAN_F17R2_FB17                                   \ Filter bits
$00040000 constant CAN_F17R2_FB18                                   \ Filter bits
$00080000 constant CAN_F17R2_FB19                                   \ Filter bits
$00100000 constant CAN_F17R2_FB20                                   \ Filter bits
$00200000 constant CAN_F17R2_FB21                                   \ Filter bits
$00400000 constant CAN_F17R2_FB22                                   \ Filter bits
$00800000 constant CAN_F17R2_FB23                                   \ Filter bits
$01000000 constant CAN_F17R2_FB24                                   \ Filter bits
$02000000 constant CAN_F17R2_FB25                                   \ Filter bits
$04000000 constant CAN_F17R2_FB26                                   \ Filter bits
$08000000 constant CAN_F17R2_FB27                                   \ Filter bits
$10000000 constant CAN_F17R2_FB28                                   \ Filter bits
$20000000 constant CAN_F17R2_FB29                                   \ Filter bits
$40000000 constant CAN_F17R2_FB30                                   \ Filter bits
$80000000 constant CAN_F17R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 18 register 1
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$00000001 constant CAN_F18R1_FB0                                    \ Filter bits
$00000002 constant CAN_F18R1_FB1                                    \ Filter bits
$00000004 constant CAN_F18R1_FB2                                    \ Filter bits
$00000008 constant CAN_F18R1_FB3                                    \ Filter bits
$00000010 constant CAN_F18R1_FB4                                    \ Filter bits
$00000020 constant CAN_F18R1_FB5                                    \ Filter bits
$00000040 constant CAN_F18R1_FB6                                    \ Filter bits
$00000080 constant CAN_F18R1_FB7                                    \ Filter bits
$00000100 constant CAN_F18R1_FB8                                    \ Filter bits
$00000200 constant CAN_F18R1_FB9                                    \ Filter bits
$00000400 constant CAN_F18R1_FB10                                   \ Filter bits
$00000800 constant CAN_F18R1_FB11                                   \ Filter bits
$00001000 constant CAN_F18R1_FB12                                   \ Filter bits
$00002000 constant CAN_F18R1_FB13                                   \ Filter bits
$00004000 constant CAN_F18R1_FB14                                   \ Filter bits
$00008000 constant CAN_F18R1_FB15                                   \ Filter bits
$00010000 constant CAN_F18R1_FB16                                   \ Filter bits
$00020000 constant CAN_F18R1_FB17                                   \ Filter bits
$00040000 constant CAN_F18R1_FB18                                   \ Filter bits
$00080000 constant CAN_F18R1_FB19                                   \ Filter bits
$00100000 constant CAN_F18R1_FB20                                   \ Filter bits
$00200000 constant CAN_F18R1_FB21                                   \ Filter bits
$00400000 constant CAN_F18R1_FB22                                   \ Filter bits
$00800000 constant CAN_F18R1_FB23                                   \ Filter bits
$01000000 constant CAN_F18R1_FB24                                   \ Filter bits
$02000000 constant CAN_F18R1_FB25                                   \ Filter bits
$04000000 constant CAN_F18R1_FB26                                   \ Filter bits
$08000000 constant CAN_F18R1_FB27                                   \ Filter bits
$10000000 constant CAN_F18R1_FB28                                   \ Filter bits
$20000000 constant CAN_F18R1_FB29                                   \ Filter bits
$40000000 constant CAN_F18R1_FB30                                   \ Filter bits
$80000000 constant CAN_F18R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 18 register 2
\ Address offset: 0x2D4
\ Reset value: 0x00000000
\

$00000001 constant CAN_F18R2_FB0                                    \ Filter bits
$00000002 constant CAN_F18R2_FB1                                    \ Filter bits
$00000004 constant CAN_F18R2_FB2                                    \ Filter bits
$00000008 constant CAN_F18R2_FB3                                    \ Filter bits
$00000010 constant CAN_F18R2_FB4                                    \ Filter bits
$00000020 constant CAN_F18R2_FB5                                    \ Filter bits
$00000040 constant CAN_F18R2_FB6                                    \ Filter bits
$00000080 constant CAN_F18R2_FB7                                    \ Filter bits
$00000100 constant CAN_F18R2_FB8                                    \ Filter bits
$00000200 constant CAN_F18R2_FB9                                    \ Filter bits
$00000400 constant CAN_F18R2_FB10                                   \ Filter bits
$00000800 constant CAN_F18R2_FB11                                   \ Filter bits
$00001000 constant CAN_F18R2_FB12                                   \ Filter bits
$00002000 constant CAN_F18R2_FB13                                   \ Filter bits
$00004000 constant CAN_F18R2_FB14                                   \ Filter bits
$00008000 constant CAN_F18R2_FB15                                   \ Filter bits
$00010000 constant CAN_F18R2_FB16                                   \ Filter bits
$00020000 constant CAN_F18R2_FB17                                   \ Filter bits
$00040000 constant CAN_F18R2_FB18                                   \ Filter bits
$00080000 constant CAN_F18R2_FB19                                   \ Filter bits
$00100000 constant CAN_F18R2_FB20                                   \ Filter bits
$00200000 constant CAN_F18R2_FB21                                   \ Filter bits
$00400000 constant CAN_F18R2_FB22                                   \ Filter bits
$00800000 constant CAN_F18R2_FB23                                   \ Filter bits
$01000000 constant CAN_F18R2_FB24                                   \ Filter bits
$02000000 constant CAN_F18R2_FB25                                   \ Filter bits
$04000000 constant CAN_F18R2_FB26                                   \ Filter bits
$08000000 constant CAN_F18R2_FB27                                   \ Filter bits
$10000000 constant CAN_F18R2_FB28                                   \ Filter bits
$20000000 constant CAN_F18R2_FB29                                   \ Filter bits
$40000000 constant CAN_F18R2_FB30                                   \ Filter bits
$80000000 constant CAN_F18R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 19 register 1
\ Address offset: 0x2D8
\ Reset value: 0x00000000
\

$00000001 constant CAN_F19R1_FB0                                    \ Filter bits
$00000002 constant CAN_F19R1_FB1                                    \ Filter bits
$00000004 constant CAN_F19R1_FB2                                    \ Filter bits
$00000008 constant CAN_F19R1_FB3                                    \ Filter bits
$00000010 constant CAN_F19R1_FB4                                    \ Filter bits
$00000020 constant CAN_F19R1_FB5                                    \ Filter bits
$00000040 constant CAN_F19R1_FB6                                    \ Filter bits
$00000080 constant CAN_F19R1_FB7                                    \ Filter bits
$00000100 constant CAN_F19R1_FB8                                    \ Filter bits
$00000200 constant CAN_F19R1_FB9                                    \ Filter bits
$00000400 constant CAN_F19R1_FB10                                   \ Filter bits
$00000800 constant CAN_F19R1_FB11                                   \ Filter bits
$00001000 constant CAN_F19R1_FB12                                   \ Filter bits
$00002000 constant CAN_F19R1_FB13                                   \ Filter bits
$00004000 constant CAN_F19R1_FB14                                   \ Filter bits
$00008000 constant CAN_F19R1_FB15                                   \ Filter bits
$00010000 constant CAN_F19R1_FB16                                   \ Filter bits
$00020000 constant CAN_F19R1_FB17                                   \ Filter bits
$00040000 constant CAN_F19R1_FB18                                   \ Filter bits
$00080000 constant CAN_F19R1_FB19                                   \ Filter bits
$00100000 constant CAN_F19R1_FB20                                   \ Filter bits
$00200000 constant CAN_F19R1_FB21                                   \ Filter bits
$00400000 constant CAN_F19R1_FB22                                   \ Filter bits
$00800000 constant CAN_F19R1_FB23                                   \ Filter bits
$01000000 constant CAN_F19R1_FB24                                   \ Filter bits
$02000000 constant CAN_F19R1_FB25                                   \ Filter bits
$04000000 constant CAN_F19R1_FB26                                   \ Filter bits
$08000000 constant CAN_F19R1_FB27                                   \ Filter bits
$10000000 constant CAN_F19R1_FB28                                   \ Filter bits
$20000000 constant CAN_F19R1_FB29                                   \ Filter bits
$40000000 constant CAN_F19R1_FB30                                   \ Filter bits
$80000000 constant CAN_F19R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 19 register 2
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000001 constant CAN_F19R2_FB0                                    \ Filter bits
$00000002 constant CAN_F19R2_FB1                                    \ Filter bits
$00000004 constant CAN_F19R2_FB2                                    \ Filter bits
$00000008 constant CAN_F19R2_FB3                                    \ Filter bits
$00000010 constant CAN_F19R2_FB4                                    \ Filter bits
$00000020 constant CAN_F19R2_FB5                                    \ Filter bits
$00000040 constant CAN_F19R2_FB6                                    \ Filter bits
$00000080 constant CAN_F19R2_FB7                                    \ Filter bits
$00000100 constant CAN_F19R2_FB8                                    \ Filter bits
$00000200 constant CAN_F19R2_FB9                                    \ Filter bits
$00000400 constant CAN_F19R2_FB10                                   \ Filter bits
$00000800 constant CAN_F19R2_FB11                                   \ Filter bits
$00001000 constant CAN_F19R2_FB12                                   \ Filter bits
$00002000 constant CAN_F19R2_FB13                                   \ Filter bits
$00004000 constant CAN_F19R2_FB14                                   \ Filter bits
$00008000 constant CAN_F19R2_FB15                                   \ Filter bits
$00010000 constant CAN_F19R2_FB16                                   \ Filter bits
$00020000 constant CAN_F19R2_FB17                                   \ Filter bits
$00040000 constant CAN_F19R2_FB18                                   \ Filter bits
$00080000 constant CAN_F19R2_FB19                                   \ Filter bits
$00100000 constant CAN_F19R2_FB20                                   \ Filter bits
$00200000 constant CAN_F19R2_FB21                                   \ Filter bits
$00400000 constant CAN_F19R2_FB22                                   \ Filter bits
$00800000 constant CAN_F19R2_FB23                                   \ Filter bits
$01000000 constant CAN_F19R2_FB24                                   \ Filter bits
$02000000 constant CAN_F19R2_FB25                                   \ Filter bits
$04000000 constant CAN_F19R2_FB26                                   \ Filter bits
$08000000 constant CAN_F19R2_FB27                                   \ Filter bits
$10000000 constant CAN_F19R2_FB28                                   \ Filter bits
$20000000 constant CAN_F19R2_FB29                                   \ Filter bits
$40000000 constant CAN_F19R2_FB30                                   \ Filter bits
$80000000 constant CAN_F19R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 20 register 1
\ Address offset: 0x2E0
\ Reset value: 0x00000000
\

$00000001 constant CAN_F20R1_FB0                                    \ Filter bits
$00000002 constant CAN_F20R1_FB1                                    \ Filter bits
$00000004 constant CAN_F20R1_FB2                                    \ Filter bits
$00000008 constant CAN_F20R1_FB3                                    \ Filter bits
$00000010 constant CAN_F20R1_FB4                                    \ Filter bits
$00000020 constant CAN_F20R1_FB5                                    \ Filter bits
$00000040 constant CAN_F20R1_FB6                                    \ Filter bits
$00000080 constant CAN_F20R1_FB7                                    \ Filter bits
$00000100 constant CAN_F20R1_FB8                                    \ Filter bits
$00000200 constant CAN_F20R1_FB9                                    \ Filter bits
$00000400 constant CAN_F20R1_FB10                                   \ Filter bits
$00000800 constant CAN_F20R1_FB11                                   \ Filter bits
$00001000 constant CAN_F20R1_FB12                                   \ Filter bits
$00002000 constant CAN_F20R1_FB13                                   \ Filter bits
$00004000 constant CAN_F20R1_FB14                                   \ Filter bits
$00008000 constant CAN_F20R1_FB15                                   \ Filter bits
$00010000 constant CAN_F20R1_FB16                                   \ Filter bits
$00020000 constant CAN_F20R1_FB17                                   \ Filter bits
$00040000 constant CAN_F20R1_FB18                                   \ Filter bits
$00080000 constant CAN_F20R1_FB19                                   \ Filter bits
$00100000 constant CAN_F20R1_FB20                                   \ Filter bits
$00200000 constant CAN_F20R1_FB21                                   \ Filter bits
$00400000 constant CAN_F20R1_FB22                                   \ Filter bits
$00800000 constant CAN_F20R1_FB23                                   \ Filter bits
$01000000 constant CAN_F20R1_FB24                                   \ Filter bits
$02000000 constant CAN_F20R1_FB25                                   \ Filter bits
$04000000 constant CAN_F20R1_FB26                                   \ Filter bits
$08000000 constant CAN_F20R1_FB27                                   \ Filter bits
$10000000 constant CAN_F20R1_FB28                                   \ Filter bits
$20000000 constant CAN_F20R1_FB29                                   \ Filter bits
$40000000 constant CAN_F20R1_FB30                                   \ Filter bits
$80000000 constant CAN_F20R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 20 register 2
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000001 constant CAN_F20R2_FB0                                    \ Filter bits
$00000002 constant CAN_F20R2_FB1                                    \ Filter bits
$00000004 constant CAN_F20R2_FB2                                    \ Filter bits
$00000008 constant CAN_F20R2_FB3                                    \ Filter bits
$00000010 constant CAN_F20R2_FB4                                    \ Filter bits
$00000020 constant CAN_F20R2_FB5                                    \ Filter bits
$00000040 constant CAN_F20R2_FB6                                    \ Filter bits
$00000080 constant CAN_F20R2_FB7                                    \ Filter bits
$00000100 constant CAN_F20R2_FB8                                    \ Filter bits
$00000200 constant CAN_F20R2_FB9                                    \ Filter bits
$00000400 constant CAN_F20R2_FB10                                   \ Filter bits
$00000800 constant CAN_F20R2_FB11                                   \ Filter bits
$00001000 constant CAN_F20R2_FB12                                   \ Filter bits
$00002000 constant CAN_F20R2_FB13                                   \ Filter bits
$00004000 constant CAN_F20R2_FB14                                   \ Filter bits
$00008000 constant CAN_F20R2_FB15                                   \ Filter bits
$00010000 constant CAN_F20R2_FB16                                   \ Filter bits
$00020000 constant CAN_F20R2_FB17                                   \ Filter bits
$00040000 constant CAN_F20R2_FB18                                   \ Filter bits
$00080000 constant CAN_F20R2_FB19                                   \ Filter bits
$00100000 constant CAN_F20R2_FB20                                   \ Filter bits
$00200000 constant CAN_F20R2_FB21                                   \ Filter bits
$00400000 constant CAN_F20R2_FB22                                   \ Filter bits
$00800000 constant CAN_F20R2_FB23                                   \ Filter bits
$01000000 constant CAN_F20R2_FB24                                   \ Filter bits
$02000000 constant CAN_F20R2_FB25                                   \ Filter bits
$04000000 constant CAN_F20R2_FB26                                   \ Filter bits
$08000000 constant CAN_F20R2_FB27                                   \ Filter bits
$10000000 constant CAN_F20R2_FB28                                   \ Filter bits
$20000000 constant CAN_F20R2_FB29                                   \ Filter bits
$40000000 constant CAN_F20R2_FB30                                   \ Filter bits
$80000000 constant CAN_F20R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 21 register 1
\ Address offset: 0x2E8
\ Reset value: 0x00000000
\

$00000001 constant CAN_F21R1_FB0                                    \ Filter bits
$00000002 constant CAN_F21R1_FB1                                    \ Filter bits
$00000004 constant CAN_F21R1_FB2                                    \ Filter bits
$00000008 constant CAN_F21R1_FB3                                    \ Filter bits
$00000010 constant CAN_F21R1_FB4                                    \ Filter bits
$00000020 constant CAN_F21R1_FB5                                    \ Filter bits
$00000040 constant CAN_F21R1_FB6                                    \ Filter bits
$00000080 constant CAN_F21R1_FB7                                    \ Filter bits
$00000100 constant CAN_F21R1_FB8                                    \ Filter bits
$00000200 constant CAN_F21R1_FB9                                    \ Filter bits
$00000400 constant CAN_F21R1_FB10                                   \ Filter bits
$00000800 constant CAN_F21R1_FB11                                   \ Filter bits
$00001000 constant CAN_F21R1_FB12                                   \ Filter bits
$00002000 constant CAN_F21R1_FB13                                   \ Filter bits
$00004000 constant CAN_F21R1_FB14                                   \ Filter bits
$00008000 constant CAN_F21R1_FB15                                   \ Filter bits
$00010000 constant CAN_F21R1_FB16                                   \ Filter bits
$00020000 constant CAN_F21R1_FB17                                   \ Filter bits
$00040000 constant CAN_F21R1_FB18                                   \ Filter bits
$00080000 constant CAN_F21R1_FB19                                   \ Filter bits
$00100000 constant CAN_F21R1_FB20                                   \ Filter bits
$00200000 constant CAN_F21R1_FB21                                   \ Filter bits
$00400000 constant CAN_F21R1_FB22                                   \ Filter bits
$00800000 constant CAN_F21R1_FB23                                   \ Filter bits
$01000000 constant CAN_F21R1_FB24                                   \ Filter bits
$02000000 constant CAN_F21R1_FB25                                   \ Filter bits
$04000000 constant CAN_F21R1_FB26                                   \ Filter bits
$08000000 constant CAN_F21R1_FB27                                   \ Filter bits
$10000000 constant CAN_F21R1_FB28                                   \ Filter bits
$20000000 constant CAN_F21R1_FB29                                   \ Filter bits
$40000000 constant CAN_F21R1_FB30                                   \ Filter bits
$80000000 constant CAN_F21R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 21 register 2
\ Address offset: 0x2EC
\ Reset value: 0x00000000
\

$00000001 constant CAN_F21R2_FB0                                    \ Filter bits
$00000002 constant CAN_F21R2_FB1                                    \ Filter bits
$00000004 constant CAN_F21R2_FB2                                    \ Filter bits
$00000008 constant CAN_F21R2_FB3                                    \ Filter bits
$00000010 constant CAN_F21R2_FB4                                    \ Filter bits
$00000020 constant CAN_F21R2_FB5                                    \ Filter bits
$00000040 constant CAN_F21R2_FB6                                    \ Filter bits
$00000080 constant CAN_F21R2_FB7                                    \ Filter bits
$00000100 constant CAN_F21R2_FB8                                    \ Filter bits
$00000200 constant CAN_F21R2_FB9                                    \ Filter bits
$00000400 constant CAN_F21R2_FB10                                   \ Filter bits
$00000800 constant CAN_F21R2_FB11                                   \ Filter bits
$00001000 constant CAN_F21R2_FB12                                   \ Filter bits
$00002000 constant CAN_F21R2_FB13                                   \ Filter bits
$00004000 constant CAN_F21R2_FB14                                   \ Filter bits
$00008000 constant CAN_F21R2_FB15                                   \ Filter bits
$00010000 constant CAN_F21R2_FB16                                   \ Filter bits
$00020000 constant CAN_F21R2_FB17                                   \ Filter bits
$00040000 constant CAN_F21R2_FB18                                   \ Filter bits
$00080000 constant CAN_F21R2_FB19                                   \ Filter bits
$00100000 constant CAN_F21R2_FB20                                   \ Filter bits
$00200000 constant CAN_F21R2_FB21                                   \ Filter bits
$00400000 constant CAN_F21R2_FB22                                   \ Filter bits
$00800000 constant CAN_F21R2_FB23                                   \ Filter bits
$01000000 constant CAN_F21R2_FB24                                   \ Filter bits
$02000000 constant CAN_F21R2_FB25                                   \ Filter bits
$04000000 constant CAN_F21R2_FB26                                   \ Filter bits
$08000000 constant CAN_F21R2_FB27                                   \ Filter bits
$10000000 constant CAN_F21R2_FB28                                   \ Filter bits
$20000000 constant CAN_F21R2_FB29                                   \ Filter bits
$40000000 constant CAN_F21R2_FB30                                   \ Filter bits
$80000000 constant CAN_F21R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 22 register 1
\ Address offset: 0x2F0
\ Reset value: 0x00000000
\

$00000001 constant CAN_F22R1_FB0                                    \ Filter bits
$00000002 constant CAN_F22R1_FB1                                    \ Filter bits
$00000004 constant CAN_F22R1_FB2                                    \ Filter bits
$00000008 constant CAN_F22R1_FB3                                    \ Filter bits
$00000010 constant CAN_F22R1_FB4                                    \ Filter bits
$00000020 constant CAN_F22R1_FB5                                    \ Filter bits
$00000040 constant CAN_F22R1_FB6                                    \ Filter bits
$00000080 constant CAN_F22R1_FB7                                    \ Filter bits
$00000100 constant CAN_F22R1_FB8                                    \ Filter bits
$00000200 constant CAN_F22R1_FB9                                    \ Filter bits
$00000400 constant CAN_F22R1_FB10                                   \ Filter bits
$00000800 constant CAN_F22R1_FB11                                   \ Filter bits
$00001000 constant CAN_F22R1_FB12                                   \ Filter bits
$00002000 constant CAN_F22R1_FB13                                   \ Filter bits
$00004000 constant CAN_F22R1_FB14                                   \ Filter bits
$00008000 constant CAN_F22R1_FB15                                   \ Filter bits
$00010000 constant CAN_F22R1_FB16                                   \ Filter bits
$00020000 constant CAN_F22R1_FB17                                   \ Filter bits
$00040000 constant CAN_F22R1_FB18                                   \ Filter bits
$00080000 constant CAN_F22R1_FB19                                   \ Filter bits
$00100000 constant CAN_F22R1_FB20                                   \ Filter bits
$00200000 constant CAN_F22R1_FB21                                   \ Filter bits
$00400000 constant CAN_F22R1_FB22                                   \ Filter bits
$00800000 constant CAN_F22R1_FB23                                   \ Filter bits
$01000000 constant CAN_F22R1_FB24                                   \ Filter bits
$02000000 constant CAN_F22R1_FB25                                   \ Filter bits
$04000000 constant CAN_F22R1_FB26                                   \ Filter bits
$08000000 constant CAN_F22R1_FB27                                   \ Filter bits
$10000000 constant CAN_F22R1_FB28                                   \ Filter bits
$20000000 constant CAN_F22R1_FB29                                   \ Filter bits
$40000000 constant CAN_F22R1_FB30                                   \ Filter bits
$80000000 constant CAN_F22R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 22 register 2
\ Address offset: 0x2F4
\ Reset value: 0x00000000
\

$00000001 constant CAN_F22R2_FB0                                    \ Filter bits
$00000002 constant CAN_F22R2_FB1                                    \ Filter bits
$00000004 constant CAN_F22R2_FB2                                    \ Filter bits
$00000008 constant CAN_F22R2_FB3                                    \ Filter bits
$00000010 constant CAN_F22R2_FB4                                    \ Filter bits
$00000020 constant CAN_F22R2_FB5                                    \ Filter bits
$00000040 constant CAN_F22R2_FB6                                    \ Filter bits
$00000080 constant CAN_F22R2_FB7                                    \ Filter bits
$00000100 constant CAN_F22R2_FB8                                    \ Filter bits
$00000200 constant CAN_F22R2_FB9                                    \ Filter bits
$00000400 constant CAN_F22R2_FB10                                   \ Filter bits
$00000800 constant CAN_F22R2_FB11                                   \ Filter bits
$00001000 constant CAN_F22R2_FB12                                   \ Filter bits
$00002000 constant CAN_F22R2_FB13                                   \ Filter bits
$00004000 constant CAN_F22R2_FB14                                   \ Filter bits
$00008000 constant CAN_F22R2_FB15                                   \ Filter bits
$00010000 constant CAN_F22R2_FB16                                   \ Filter bits
$00020000 constant CAN_F22R2_FB17                                   \ Filter bits
$00040000 constant CAN_F22R2_FB18                                   \ Filter bits
$00080000 constant CAN_F22R2_FB19                                   \ Filter bits
$00100000 constant CAN_F22R2_FB20                                   \ Filter bits
$00200000 constant CAN_F22R2_FB21                                   \ Filter bits
$00400000 constant CAN_F22R2_FB22                                   \ Filter bits
$00800000 constant CAN_F22R2_FB23                                   \ Filter bits
$01000000 constant CAN_F22R2_FB24                                   \ Filter bits
$02000000 constant CAN_F22R2_FB25                                   \ Filter bits
$04000000 constant CAN_F22R2_FB26                                   \ Filter bits
$08000000 constant CAN_F22R2_FB27                                   \ Filter bits
$10000000 constant CAN_F22R2_FB28                                   \ Filter bits
$20000000 constant CAN_F22R2_FB29                                   \ Filter bits
$40000000 constant CAN_F22R2_FB30                                   \ Filter bits
$80000000 constant CAN_F22R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 23 register 1
\ Address offset: 0x2F8
\ Reset value: 0x00000000
\

$00000001 constant CAN_F23R1_FB0                                    \ Filter bits
$00000002 constant CAN_F23R1_FB1                                    \ Filter bits
$00000004 constant CAN_F23R1_FB2                                    \ Filter bits
$00000008 constant CAN_F23R1_FB3                                    \ Filter bits
$00000010 constant CAN_F23R1_FB4                                    \ Filter bits
$00000020 constant CAN_F23R1_FB5                                    \ Filter bits
$00000040 constant CAN_F23R1_FB6                                    \ Filter bits
$00000080 constant CAN_F23R1_FB7                                    \ Filter bits
$00000100 constant CAN_F23R1_FB8                                    \ Filter bits
$00000200 constant CAN_F23R1_FB9                                    \ Filter bits
$00000400 constant CAN_F23R1_FB10                                   \ Filter bits
$00000800 constant CAN_F23R1_FB11                                   \ Filter bits
$00001000 constant CAN_F23R1_FB12                                   \ Filter bits
$00002000 constant CAN_F23R1_FB13                                   \ Filter bits
$00004000 constant CAN_F23R1_FB14                                   \ Filter bits
$00008000 constant CAN_F23R1_FB15                                   \ Filter bits
$00010000 constant CAN_F23R1_FB16                                   \ Filter bits
$00020000 constant CAN_F23R1_FB17                                   \ Filter bits
$00040000 constant CAN_F23R1_FB18                                   \ Filter bits
$00080000 constant CAN_F23R1_FB19                                   \ Filter bits
$00100000 constant CAN_F23R1_FB20                                   \ Filter bits
$00200000 constant CAN_F23R1_FB21                                   \ Filter bits
$00400000 constant CAN_F23R1_FB22                                   \ Filter bits
$00800000 constant CAN_F23R1_FB23                                   \ Filter bits
$01000000 constant CAN_F23R1_FB24                                   \ Filter bits
$02000000 constant CAN_F23R1_FB25                                   \ Filter bits
$04000000 constant CAN_F23R1_FB26                                   \ Filter bits
$08000000 constant CAN_F23R1_FB27                                   \ Filter bits
$10000000 constant CAN_F23R1_FB28                                   \ Filter bits
$20000000 constant CAN_F23R1_FB29                                   \ Filter bits
$40000000 constant CAN_F23R1_FB30                                   \ Filter bits
$80000000 constant CAN_F23R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 23 register 2
\ Address offset: 0x2FC
\ Reset value: 0x00000000
\

$00000001 constant CAN_F23R2_FB0                                    \ Filter bits
$00000002 constant CAN_F23R2_FB1                                    \ Filter bits
$00000004 constant CAN_F23R2_FB2                                    \ Filter bits
$00000008 constant CAN_F23R2_FB3                                    \ Filter bits
$00000010 constant CAN_F23R2_FB4                                    \ Filter bits
$00000020 constant CAN_F23R2_FB5                                    \ Filter bits
$00000040 constant CAN_F23R2_FB6                                    \ Filter bits
$00000080 constant CAN_F23R2_FB7                                    \ Filter bits
$00000100 constant CAN_F23R2_FB8                                    \ Filter bits
$00000200 constant CAN_F23R2_FB9                                    \ Filter bits
$00000400 constant CAN_F23R2_FB10                                   \ Filter bits
$00000800 constant CAN_F23R2_FB11                                   \ Filter bits
$00001000 constant CAN_F23R2_FB12                                   \ Filter bits
$00002000 constant CAN_F23R2_FB13                                   \ Filter bits
$00004000 constant CAN_F23R2_FB14                                   \ Filter bits
$00008000 constant CAN_F23R2_FB15                                   \ Filter bits
$00010000 constant CAN_F23R2_FB16                                   \ Filter bits
$00020000 constant CAN_F23R2_FB17                                   \ Filter bits
$00040000 constant CAN_F23R2_FB18                                   \ Filter bits
$00080000 constant CAN_F23R2_FB19                                   \ Filter bits
$00100000 constant CAN_F23R2_FB20                                   \ Filter bits
$00200000 constant CAN_F23R2_FB21                                   \ Filter bits
$00400000 constant CAN_F23R2_FB22                                   \ Filter bits
$00800000 constant CAN_F23R2_FB23                                   \ Filter bits
$01000000 constant CAN_F23R2_FB24                                   \ Filter bits
$02000000 constant CAN_F23R2_FB25                                   \ Filter bits
$04000000 constant CAN_F23R2_FB26                                   \ Filter bits
$08000000 constant CAN_F23R2_FB27                                   \ Filter bits
$10000000 constant CAN_F23R2_FB28                                   \ Filter bits
$20000000 constant CAN_F23R2_FB29                                   \ Filter bits
$40000000 constant CAN_F23R2_FB30                                   \ Filter bits
$80000000 constant CAN_F23R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 24 register 1
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant CAN_F24R1_FB0                                    \ Filter bits
$00000002 constant CAN_F24R1_FB1                                    \ Filter bits
$00000004 constant CAN_F24R1_FB2                                    \ Filter bits
$00000008 constant CAN_F24R1_FB3                                    \ Filter bits
$00000010 constant CAN_F24R1_FB4                                    \ Filter bits
$00000020 constant CAN_F24R1_FB5                                    \ Filter bits
$00000040 constant CAN_F24R1_FB6                                    \ Filter bits
$00000080 constant CAN_F24R1_FB7                                    \ Filter bits
$00000100 constant CAN_F24R1_FB8                                    \ Filter bits
$00000200 constant CAN_F24R1_FB9                                    \ Filter bits
$00000400 constant CAN_F24R1_FB10                                   \ Filter bits
$00000800 constant CAN_F24R1_FB11                                   \ Filter bits
$00001000 constant CAN_F24R1_FB12                                   \ Filter bits
$00002000 constant CAN_F24R1_FB13                                   \ Filter bits
$00004000 constant CAN_F24R1_FB14                                   \ Filter bits
$00008000 constant CAN_F24R1_FB15                                   \ Filter bits
$00010000 constant CAN_F24R1_FB16                                   \ Filter bits
$00020000 constant CAN_F24R1_FB17                                   \ Filter bits
$00040000 constant CAN_F24R1_FB18                                   \ Filter bits
$00080000 constant CAN_F24R1_FB19                                   \ Filter bits
$00100000 constant CAN_F24R1_FB20                                   \ Filter bits
$00200000 constant CAN_F24R1_FB21                                   \ Filter bits
$00400000 constant CAN_F24R1_FB22                                   \ Filter bits
$00800000 constant CAN_F24R1_FB23                                   \ Filter bits
$01000000 constant CAN_F24R1_FB24                                   \ Filter bits
$02000000 constant CAN_F24R1_FB25                                   \ Filter bits
$04000000 constant CAN_F24R1_FB26                                   \ Filter bits
$08000000 constant CAN_F24R1_FB27                                   \ Filter bits
$10000000 constant CAN_F24R1_FB28                                   \ Filter bits
$20000000 constant CAN_F24R1_FB29                                   \ Filter bits
$40000000 constant CAN_F24R1_FB30                                   \ Filter bits
$80000000 constant CAN_F24R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 24 register 2
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant CAN_F24R2_FB0                                    \ Filter bits
$00000002 constant CAN_F24R2_FB1                                    \ Filter bits
$00000004 constant CAN_F24R2_FB2                                    \ Filter bits
$00000008 constant CAN_F24R2_FB3                                    \ Filter bits
$00000010 constant CAN_F24R2_FB4                                    \ Filter bits
$00000020 constant CAN_F24R2_FB5                                    \ Filter bits
$00000040 constant CAN_F24R2_FB6                                    \ Filter bits
$00000080 constant CAN_F24R2_FB7                                    \ Filter bits
$00000100 constant CAN_F24R2_FB8                                    \ Filter bits
$00000200 constant CAN_F24R2_FB9                                    \ Filter bits
$00000400 constant CAN_F24R2_FB10                                   \ Filter bits
$00000800 constant CAN_F24R2_FB11                                   \ Filter bits
$00001000 constant CAN_F24R2_FB12                                   \ Filter bits
$00002000 constant CAN_F24R2_FB13                                   \ Filter bits
$00004000 constant CAN_F24R2_FB14                                   \ Filter bits
$00008000 constant CAN_F24R2_FB15                                   \ Filter bits
$00010000 constant CAN_F24R2_FB16                                   \ Filter bits
$00020000 constant CAN_F24R2_FB17                                   \ Filter bits
$00040000 constant CAN_F24R2_FB18                                   \ Filter bits
$00080000 constant CAN_F24R2_FB19                                   \ Filter bits
$00100000 constant CAN_F24R2_FB20                                   \ Filter bits
$00200000 constant CAN_F24R2_FB21                                   \ Filter bits
$00400000 constant CAN_F24R2_FB22                                   \ Filter bits
$00800000 constant CAN_F24R2_FB23                                   \ Filter bits
$01000000 constant CAN_F24R2_FB24                                   \ Filter bits
$02000000 constant CAN_F24R2_FB25                                   \ Filter bits
$04000000 constant CAN_F24R2_FB26                                   \ Filter bits
$08000000 constant CAN_F24R2_FB27                                   \ Filter bits
$10000000 constant CAN_F24R2_FB28                                   \ Filter bits
$20000000 constant CAN_F24R2_FB29                                   \ Filter bits
$40000000 constant CAN_F24R2_FB30                                   \ Filter bits
$80000000 constant CAN_F24R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 25 register 1
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant CAN_F25R1_FB0                                    \ Filter bits
$00000002 constant CAN_F25R1_FB1                                    \ Filter bits
$00000004 constant CAN_F25R1_FB2                                    \ Filter bits
$00000008 constant CAN_F25R1_FB3                                    \ Filter bits
$00000010 constant CAN_F25R1_FB4                                    \ Filter bits
$00000020 constant CAN_F25R1_FB5                                    \ Filter bits
$00000040 constant CAN_F25R1_FB6                                    \ Filter bits
$00000080 constant CAN_F25R1_FB7                                    \ Filter bits
$00000100 constant CAN_F25R1_FB8                                    \ Filter bits
$00000200 constant CAN_F25R1_FB9                                    \ Filter bits
$00000400 constant CAN_F25R1_FB10                                   \ Filter bits
$00000800 constant CAN_F25R1_FB11                                   \ Filter bits
$00001000 constant CAN_F25R1_FB12                                   \ Filter bits
$00002000 constant CAN_F25R1_FB13                                   \ Filter bits
$00004000 constant CAN_F25R1_FB14                                   \ Filter bits
$00008000 constant CAN_F25R1_FB15                                   \ Filter bits
$00010000 constant CAN_F25R1_FB16                                   \ Filter bits
$00020000 constant CAN_F25R1_FB17                                   \ Filter bits
$00040000 constant CAN_F25R1_FB18                                   \ Filter bits
$00080000 constant CAN_F25R1_FB19                                   \ Filter bits
$00100000 constant CAN_F25R1_FB20                                   \ Filter bits
$00200000 constant CAN_F25R1_FB21                                   \ Filter bits
$00400000 constant CAN_F25R1_FB22                                   \ Filter bits
$00800000 constant CAN_F25R1_FB23                                   \ Filter bits
$01000000 constant CAN_F25R1_FB24                                   \ Filter bits
$02000000 constant CAN_F25R1_FB25                                   \ Filter bits
$04000000 constant CAN_F25R1_FB26                                   \ Filter bits
$08000000 constant CAN_F25R1_FB27                                   \ Filter bits
$10000000 constant CAN_F25R1_FB28                                   \ Filter bits
$20000000 constant CAN_F25R1_FB29                                   \ Filter bits
$40000000 constant CAN_F25R1_FB30                                   \ Filter bits
$80000000 constant CAN_F25R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 25 register 2
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000001 constant CAN_F25R2_FB0                                    \ Filter bits
$00000002 constant CAN_F25R2_FB1                                    \ Filter bits
$00000004 constant CAN_F25R2_FB2                                    \ Filter bits
$00000008 constant CAN_F25R2_FB3                                    \ Filter bits
$00000010 constant CAN_F25R2_FB4                                    \ Filter bits
$00000020 constant CAN_F25R2_FB5                                    \ Filter bits
$00000040 constant CAN_F25R2_FB6                                    \ Filter bits
$00000080 constant CAN_F25R2_FB7                                    \ Filter bits
$00000100 constant CAN_F25R2_FB8                                    \ Filter bits
$00000200 constant CAN_F25R2_FB9                                    \ Filter bits
$00000400 constant CAN_F25R2_FB10                                   \ Filter bits
$00000800 constant CAN_F25R2_FB11                                   \ Filter bits
$00001000 constant CAN_F25R2_FB12                                   \ Filter bits
$00002000 constant CAN_F25R2_FB13                                   \ Filter bits
$00004000 constant CAN_F25R2_FB14                                   \ Filter bits
$00008000 constant CAN_F25R2_FB15                                   \ Filter bits
$00010000 constant CAN_F25R2_FB16                                   \ Filter bits
$00020000 constant CAN_F25R2_FB17                                   \ Filter bits
$00040000 constant CAN_F25R2_FB18                                   \ Filter bits
$00080000 constant CAN_F25R2_FB19                                   \ Filter bits
$00100000 constant CAN_F25R2_FB20                                   \ Filter bits
$00200000 constant CAN_F25R2_FB21                                   \ Filter bits
$00400000 constant CAN_F25R2_FB22                                   \ Filter bits
$00800000 constant CAN_F25R2_FB23                                   \ Filter bits
$01000000 constant CAN_F25R2_FB24                                   \ Filter bits
$02000000 constant CAN_F25R2_FB25                                   \ Filter bits
$04000000 constant CAN_F25R2_FB26                                   \ Filter bits
$08000000 constant CAN_F25R2_FB27                                   \ Filter bits
$10000000 constant CAN_F25R2_FB28                                   \ Filter bits
$20000000 constant CAN_F25R2_FB29                                   \ Filter bits
$40000000 constant CAN_F25R2_FB30                                   \ Filter bits
$80000000 constant CAN_F25R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 26 register 1
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000001 constant CAN_F26R1_FB0                                    \ Filter bits
$00000002 constant CAN_F26R1_FB1                                    \ Filter bits
$00000004 constant CAN_F26R1_FB2                                    \ Filter bits
$00000008 constant CAN_F26R1_FB3                                    \ Filter bits
$00000010 constant CAN_F26R1_FB4                                    \ Filter bits
$00000020 constant CAN_F26R1_FB5                                    \ Filter bits
$00000040 constant CAN_F26R1_FB6                                    \ Filter bits
$00000080 constant CAN_F26R1_FB7                                    \ Filter bits
$00000100 constant CAN_F26R1_FB8                                    \ Filter bits
$00000200 constant CAN_F26R1_FB9                                    \ Filter bits
$00000400 constant CAN_F26R1_FB10                                   \ Filter bits
$00000800 constant CAN_F26R1_FB11                                   \ Filter bits
$00001000 constant CAN_F26R1_FB12                                   \ Filter bits
$00002000 constant CAN_F26R1_FB13                                   \ Filter bits
$00004000 constant CAN_F26R1_FB14                                   \ Filter bits
$00008000 constant CAN_F26R1_FB15                                   \ Filter bits
$00010000 constant CAN_F26R1_FB16                                   \ Filter bits
$00020000 constant CAN_F26R1_FB17                                   \ Filter bits
$00040000 constant CAN_F26R1_FB18                                   \ Filter bits
$00080000 constant CAN_F26R1_FB19                                   \ Filter bits
$00100000 constant CAN_F26R1_FB20                                   \ Filter bits
$00200000 constant CAN_F26R1_FB21                                   \ Filter bits
$00400000 constant CAN_F26R1_FB22                                   \ Filter bits
$00800000 constant CAN_F26R1_FB23                                   \ Filter bits
$01000000 constant CAN_F26R1_FB24                                   \ Filter bits
$02000000 constant CAN_F26R1_FB25                                   \ Filter bits
$04000000 constant CAN_F26R1_FB26                                   \ Filter bits
$08000000 constant CAN_F26R1_FB27                                   \ Filter bits
$10000000 constant CAN_F26R1_FB28                                   \ Filter bits
$20000000 constant CAN_F26R1_FB29                                   \ Filter bits
$40000000 constant CAN_F26R1_FB30                                   \ Filter bits
$80000000 constant CAN_F26R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 26 register 2
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000001 constant CAN_F26R2_FB0                                    \ Filter bits
$00000002 constant CAN_F26R2_FB1                                    \ Filter bits
$00000004 constant CAN_F26R2_FB2                                    \ Filter bits
$00000008 constant CAN_F26R2_FB3                                    \ Filter bits
$00000010 constant CAN_F26R2_FB4                                    \ Filter bits
$00000020 constant CAN_F26R2_FB5                                    \ Filter bits
$00000040 constant CAN_F26R2_FB6                                    \ Filter bits
$00000080 constant CAN_F26R2_FB7                                    \ Filter bits
$00000100 constant CAN_F26R2_FB8                                    \ Filter bits
$00000200 constant CAN_F26R2_FB9                                    \ Filter bits
$00000400 constant CAN_F26R2_FB10                                   \ Filter bits
$00000800 constant CAN_F26R2_FB11                                   \ Filter bits
$00001000 constant CAN_F26R2_FB12                                   \ Filter bits
$00002000 constant CAN_F26R2_FB13                                   \ Filter bits
$00004000 constant CAN_F26R2_FB14                                   \ Filter bits
$00008000 constant CAN_F26R2_FB15                                   \ Filter bits
$00010000 constant CAN_F26R2_FB16                                   \ Filter bits
$00020000 constant CAN_F26R2_FB17                                   \ Filter bits
$00040000 constant CAN_F26R2_FB18                                   \ Filter bits
$00080000 constant CAN_F26R2_FB19                                   \ Filter bits
$00100000 constant CAN_F26R2_FB20                                   \ Filter bits
$00200000 constant CAN_F26R2_FB21                                   \ Filter bits
$00400000 constant CAN_F26R2_FB22                                   \ Filter bits
$00800000 constant CAN_F26R2_FB23                                   \ Filter bits
$01000000 constant CAN_F26R2_FB24                                   \ Filter bits
$02000000 constant CAN_F26R2_FB25                                   \ Filter bits
$04000000 constant CAN_F26R2_FB26                                   \ Filter bits
$08000000 constant CAN_F26R2_FB27                                   \ Filter bits
$10000000 constant CAN_F26R2_FB28                                   \ Filter bits
$20000000 constant CAN_F26R2_FB29                                   \ Filter bits
$40000000 constant CAN_F26R2_FB30                                   \ Filter bits
$80000000 constant CAN_F26R2_FB31                                   \ Filter bits


\
\ @brief Filter bank 27 register 1
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000001 constant CAN_F27R1_FB0                                    \ Filter bits
$00000002 constant CAN_F27R1_FB1                                    \ Filter bits
$00000004 constant CAN_F27R1_FB2                                    \ Filter bits
$00000008 constant CAN_F27R1_FB3                                    \ Filter bits
$00000010 constant CAN_F27R1_FB4                                    \ Filter bits
$00000020 constant CAN_F27R1_FB5                                    \ Filter bits
$00000040 constant CAN_F27R1_FB6                                    \ Filter bits
$00000080 constant CAN_F27R1_FB7                                    \ Filter bits
$00000100 constant CAN_F27R1_FB8                                    \ Filter bits
$00000200 constant CAN_F27R1_FB9                                    \ Filter bits
$00000400 constant CAN_F27R1_FB10                                   \ Filter bits
$00000800 constant CAN_F27R1_FB11                                   \ Filter bits
$00001000 constant CAN_F27R1_FB12                                   \ Filter bits
$00002000 constant CAN_F27R1_FB13                                   \ Filter bits
$00004000 constant CAN_F27R1_FB14                                   \ Filter bits
$00008000 constant CAN_F27R1_FB15                                   \ Filter bits
$00010000 constant CAN_F27R1_FB16                                   \ Filter bits
$00020000 constant CAN_F27R1_FB17                                   \ Filter bits
$00040000 constant CAN_F27R1_FB18                                   \ Filter bits
$00080000 constant CAN_F27R1_FB19                                   \ Filter bits
$00100000 constant CAN_F27R1_FB20                                   \ Filter bits
$00200000 constant CAN_F27R1_FB21                                   \ Filter bits
$00400000 constant CAN_F27R1_FB22                                   \ Filter bits
$00800000 constant CAN_F27R1_FB23                                   \ Filter bits
$01000000 constant CAN_F27R1_FB24                                   \ Filter bits
$02000000 constant CAN_F27R1_FB25                                   \ Filter bits
$04000000 constant CAN_F27R1_FB26                                   \ Filter bits
$08000000 constant CAN_F27R1_FB27                                   \ Filter bits
$10000000 constant CAN_F27R1_FB28                                   \ Filter bits
$20000000 constant CAN_F27R1_FB29                                   \ Filter bits
$40000000 constant CAN_F27R1_FB30                                   \ Filter bits
$80000000 constant CAN_F27R1_FB31                                   \ Filter bits


\
\ @brief Filter bank 27 register 2
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000001 constant CAN_F27R2_FB0                                    \ Filter bits
$00000002 constant CAN_F27R2_FB1                                    \ Filter bits
$00000004 constant CAN_F27R2_FB2                                    \ Filter bits
$00000008 constant CAN_F27R2_FB3                                    \ Filter bits
$00000010 constant CAN_F27R2_FB4                                    \ Filter bits
$00000020 constant CAN_F27R2_FB5                                    \ Filter bits
$00000040 constant CAN_F27R2_FB6                                    \ Filter bits
$00000080 constant CAN_F27R2_FB7                                    \ Filter bits
$00000100 constant CAN_F27R2_FB8                                    \ Filter bits
$00000200 constant CAN_F27R2_FB9                                    \ Filter bits
$00000400 constant CAN_F27R2_FB10                                   \ Filter bits
$00000800 constant CAN_F27R2_FB11                                   \ Filter bits
$00001000 constant CAN_F27R2_FB12                                   \ Filter bits
$00002000 constant CAN_F27R2_FB13                                   \ Filter bits
$00004000 constant CAN_F27R2_FB14                                   \ Filter bits
$00008000 constant CAN_F27R2_FB15                                   \ Filter bits
$00010000 constant CAN_F27R2_FB16                                   \ Filter bits
$00020000 constant CAN_F27R2_FB17                                   \ Filter bits
$00040000 constant CAN_F27R2_FB18                                   \ Filter bits
$00080000 constant CAN_F27R2_FB19                                   \ Filter bits
$00100000 constant CAN_F27R2_FB20                                   \ Filter bits
$00200000 constant CAN_F27R2_FB21                                   \ Filter bits
$00400000 constant CAN_F27R2_FB22                                   \ Filter bits
$00800000 constant CAN_F27R2_FB23                                   \ Filter bits
$01000000 constant CAN_F27R2_FB24                                   \ Filter bits
$02000000 constant CAN_F27R2_FB25                                   \ Filter bits
$04000000 constant CAN_F27R2_FB26                                   \ Filter bits
$08000000 constant CAN_F27R2_FB27                                   \ Filter bits
$10000000 constant CAN_F27R2_FB28                                   \ Filter bits
$20000000 constant CAN_F27R2_FB29                                   \ Filter bits
$40000000 constant CAN_F27R2_FB30                                   \ Filter bits
$80000000 constant CAN_F27R2_FB31                                   \ Filter bits


\
\ @brief Controller area network
\
$40006400 constant CAN_MCR        \ offset: 0x00 : master control register
$40006404 constant CAN_MSR        \ offset: 0x04 : master status register
$40006408 constant CAN_TSR        \ offset: 0x08 : transmit status register
$4000640c constant CAN_RF0R       \ offset: 0x0C : receive FIFO 0 register
$40006410 constant CAN_RF1R       \ offset: 0x10 : receive FIFO 1 register
$40006414 constant CAN_IER        \ offset: 0x14 : interrupt enable register
$40006418 constant CAN_ESR        \ offset: 0x18 : error status register
$4000641c constant CAN_BTR        \ offset: 0x1C : bit timing register
$40006580 constant CAN_TI0R       \ offset: 0x180 : TX mailbox identifier register
$40006584 constant CAN_TDT0R      \ offset: 0x184 : mailbox data length control and time stamp register
$40006588 constant CAN_TDL0R      \ offset: 0x188 : mailbox data low register
$4000658c constant CAN_TDH0R      \ offset: 0x18C : mailbox data high register
$40006590 constant CAN_TI1R       \ offset: 0x190 : TX mailbox identifier register
$40006594 constant CAN_TDT1R      \ offset: 0x194 : mailbox data length control and time stamp register
$40006598 constant CAN_TDL1R      \ offset: 0x198 : mailbox data low register
$4000659c constant CAN_TDH1R      \ offset: 0x19C : mailbox data high register
$400065a0 constant CAN_TI2R       \ offset: 0x1A0 : TX mailbox identifier register
$400065a4 constant CAN_TDT2R      \ offset: 0x1A4 : mailbox data length control and time stamp register
$400065a8 constant CAN_TDL2R      \ offset: 0x1A8 : mailbox data low register
$400065ac constant CAN_TDH2R      \ offset: 0x1AC : mailbox data high register
$400065b0 constant CAN_RI0R       \ offset: 0x1B0 : receive FIFO mailbox identifier register
$400065b4 constant CAN_RDT0R      \ offset: 0x1B4 : receive FIFO mailbox data length control and time stamp register
$400065b8 constant CAN_RDL0R      \ offset: 0x1B8 : receive FIFO mailbox data low register
$400065bc constant CAN_RDH0R      \ offset: 0x1BC : receive FIFO mailbox data high register
$400065c0 constant CAN_RI1R       \ offset: 0x1C0 : receive FIFO mailbox identifier register
$400065c4 constant CAN_RDT1R      \ offset: 0x1C4 : receive FIFO mailbox data length control and time stamp register
$400065c8 constant CAN_RDL1R      \ offset: 0x1C8 : receive FIFO mailbox data low register
$400065cc constant CAN_RDH1R      \ offset: 0x1CC : receive FIFO mailbox data high register
$40006600 constant CAN_FMR        \ offset: 0x200 : filter master register
$40006604 constant CAN_FM1R       \ offset: 0x204 : filter mode register
$4000660c constant CAN_FS1R       \ offset: 0x20C : filter scale register
$40006614 constant CAN_FFA1R      \ offset: 0x214 : filter FIFO assignment register
$4000661c constant CAN_FA1R       \ offset: 0x21C : CAN filter activation register
$40006640 constant CAN_F0R1       \ offset: 0x240 : Filter bank 0 register 1
$40006644 constant CAN_F0R2       \ offset: 0x244 : Filter bank 0 register 2
$40006648 constant CAN_F1R1       \ offset: 0x248 : Filter bank 1 register 1
$4000664c constant CAN_F1R2       \ offset: 0x24C : Filter bank 1 register 2
$40006650 constant CAN_F2R1       \ offset: 0x250 : Filter bank 2 register 1
$40006654 constant CAN_F2R2       \ offset: 0x254 : Filter bank 2 register 2
$40006658 constant CAN_F3R1       \ offset: 0x258 : Filter bank 3 register 1
$4000665c constant CAN_F3R2       \ offset: 0x25C : Filter bank 3 register 2
$40006660 constant CAN_F4R1       \ offset: 0x260 : Filter bank 4 register 1
$40006664 constant CAN_F4R2       \ offset: 0x264 : Filter bank 4 register 2
$40006668 constant CAN_F5R1       \ offset: 0x268 : Filter bank 5 register 1
$4000666c constant CAN_F5R2       \ offset: 0x26C : Filter bank 5 register 2
$40006670 constant CAN_F6R1       \ offset: 0x270 : Filter bank 6 register 1
$40006674 constant CAN_F6R2       \ offset: 0x274 : Filter bank 6 register 2
$40006678 constant CAN_F7R1       \ offset: 0x278 : Filter bank 7 register 1
$4000667c constant CAN_F7R2       \ offset: 0x27C : Filter bank 7 register 2
$40006680 constant CAN_F8R1       \ offset: 0x280 : Filter bank 8 register 1
$40006684 constant CAN_F8R2       \ offset: 0x284 : Filter bank 8 register 2
$40006688 constant CAN_F9R1       \ offset: 0x288 : Filter bank 9 register 1
$4000668c constant CAN_F9R2       \ offset: 0x28C : Filter bank 9 register 2
$40006690 constant CAN_F10R1      \ offset: 0x290 : Filter bank 10 register 1
$40006694 constant CAN_F10R2      \ offset: 0x294 : Filter bank 10 register 2
$40006698 constant CAN_F11R1      \ offset: 0x298 : Filter bank 11 register 1
$4000669c constant CAN_F11R2      \ offset: 0x29C : Filter bank 11 register 2
$400066a0 constant CAN_F12R1      \ offset: 0x2A0 : Filter bank 4 register 1
$400066a4 constant CAN_F12R2      \ offset: 0x2A4 : Filter bank 12 register 2
$400066a8 constant CAN_F13R1      \ offset: 0x2A8 : Filter bank 13 register 1
$400066ac constant CAN_F13R2      \ offset: 0x2AC : Filter bank 13 register 2
$400066b0 constant CAN_F14R1      \ offset: 0x2B0 : Filter bank 14 register 1
$400066b4 constant CAN_F14R2      \ offset: 0x2B4 : Filter bank 14 register 2
$400066b8 constant CAN_F15R1      \ offset: 0x2B8 : Filter bank 15 register 1
$400066bc constant CAN_F15R2      \ offset: 0x2BC : Filter bank 15 register 2
$400066c0 constant CAN_F16R1      \ offset: 0x2C0 : Filter bank 16 register 1
$400066c4 constant CAN_F16R2      \ offset: 0x2C4 : Filter bank 16 register 2
$400066c8 constant CAN_F17R1      \ offset: 0x2C8 : Filter bank 17 register 1
$400066cc constant CAN_F17R2      \ offset: 0x2CC : Filter bank 17 register 2
$400066d0 constant CAN_F18R1      \ offset: 0x2D0 : Filter bank 18 register 1
$400066d4 constant CAN_F18R2      \ offset: 0x2D4 : Filter bank 18 register 2
$400066d8 constant CAN_F19R1      \ offset: 0x2D8 : Filter bank 19 register 1
$400066dc constant CAN_F19R2      \ offset: 0x2DC : Filter bank 19 register 2
$400066e0 constant CAN_F20R1      \ offset: 0x2E0 : Filter bank 20 register 1
$400066e4 constant CAN_F20R2      \ offset: 0x2E4 : Filter bank 20 register 2
$400066e8 constant CAN_F21R1      \ offset: 0x2E8 : Filter bank 21 register 1
$400066ec constant CAN_F21R2      \ offset: 0x2EC : Filter bank 21 register 2
$400066f0 constant CAN_F22R1      \ offset: 0x2F0 : Filter bank 22 register 1
$400066f4 constant CAN_F22R2      \ offset: 0x2F4 : Filter bank 22 register 2
$400066f8 constant CAN_F23R1      \ offset: 0x2F8 : Filter bank 23 register 1
$400066fc constant CAN_F23R2      \ offset: 0x2FC : Filter bank 23 register 2
$40006700 constant CAN_F24R1      \ offset: 0x300 : Filter bank 24 register 1
$40006704 constant CAN_F24R2      \ offset: 0x304 : Filter bank 24 register 2
$40006708 constant CAN_F25R1      \ offset: 0x308 : Filter bank 25 register 1
$4000670c constant CAN_F25R2      \ offset: 0x30C : Filter bank 25 register 2
$40006710 constant CAN_F26R1      \ offset: 0x310 : Filter bank 26 register 1
$40006714 constant CAN_F26R2      \ offset: 0x314 : Filter bank 26 register 2
$40006718 constant CAN_F27R1      \ offset: 0x318 : Filter bank 27 register 1
$4000671c constant CAN_F27R2      \ offset: 0x31C : Filter bank 27 register 2

