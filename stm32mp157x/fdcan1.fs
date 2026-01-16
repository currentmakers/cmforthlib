\
\ @file fdcan1.fs
\ @brief FDCAN1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FDCAN core release register
\ Address offset: 0x00
\ Reset value: 0x32141218
\

$000000ff constant FDCAN1_FDCAN_CREL_DAY                            \ DAY
$0000ff00 constant FDCAN1_FDCAN_CREL_MON                            \ MON
$000f0000 constant FDCAN1_FDCAN_CREL_YEAR                           \ YEAR
$00f00000 constant FDCAN1_FDCAN_CREL_SUBSTEP                        \ SUBSTEP
$0f000000 constant FDCAN1_FDCAN_CREL_STEP                           \ STEP
$f0000000 constant FDCAN1_FDCAN_CREL_REL                            \ REL


\
\ @brief FDCAN Endian register
\ Address offset: 0x04
\ Reset value: 0x87654321
\

$00000000 constant FDCAN1_FDCAN_ENDN_ETV                            \ ETV


\
\ @brief This register is dedicated to data bit timing phase and only writable if bits FDCAN_CCCR.CCE and FDCAN_CCCR.INIT are set. The CAN time quantum may be programmed in the range from 1 to 32 FDCAN clock periods. tq = (DBRP + 1) FDCAN clock periods. DTSEG1 is the sum of Prop_Seg and Phase_Seg1. DTSEG2 is Phase_Seg2. Therefore the length of the bit time is (DTSEG1 + DTSEG2 + 3) tq for programmed values, or (Sync_Seg+Prop_Seg+Phase_Seg1+Phase_Seg2) tq for functional values. The information processing time (IPT) is zero, meaning the data for the next bit is available at the first clock edge after the sample point.
\ Address offset: 0x0C
\ Reset value: 0x00000A33
\

$0000000f constant FDCAN1_FDCAN_DBTP_DSJW                           \ DSJW
$000000f0 constant FDCAN1_FDCAN_DBTP_DTSEG2                         \ DTSEG2
$00001f00 constant FDCAN1_FDCAN_DBTP_DTSEG1                         \ DTSEG1
$001f0000 constant FDCAN1_FDCAN_DBTP_DBRP                           \ DBRP
$00800000 constant FDCAN1_FDCAN_DBTP_TDC                            \ TDC


\
\ @brief Write access to this register has to be enabled by setting bit FDCAN_CCCR.TEST to 1. All register functions are set to their reset values when bit FDCAN_CCCR.TEST is reset. Loop back mode and software control of Tx pin FDCANx_TX are hardware test modes. Programming TX differently from 00 may disturb the message transfer on the CAN bus.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000010 constant FDCAN1_FDCAN_TEST_LBCK                           \ LBCK
$00000060 constant FDCAN1_FDCAN_TEST_TX                             \ TX
$00000080 constant FDCAN1_FDCAN_TEST_RX                             \ RX


\
\ @brief The RAM watchdog monitors the READY output of the message RAM. A message RAM access starts the message RAM watchdog counter with the value configured by the FDCAN_RWD.WDC bits. The counter is reloaded with FDCAN_RWD.WDC bits when the message RAM signals successful completion by activating its READY output. In case there is no response from the message RAM until the counter has counted down to 0, the counter stops and interrupt flag FDCAN_IR.WDI bit is set. The RAM watchdog counter is clocked by the fdcan_pclk clock.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant FDCAN1_FDCAN_RWD_WDC                             \ WDC
$0000ff00 constant FDCAN1_FDCAN_RWD_WDV                             \ WDV


\
\ @brief For details about setting and resetting of single bits see Software initialization.
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant FDCAN1_FDCAN_CCCR_INIT                           \ INIT
$00000002 constant FDCAN1_FDCAN_CCCR_CCE                            \ CCE
$00000004 constant FDCAN1_FDCAN_CCCR_ASM                            \ ASM
$00000008 constant FDCAN1_FDCAN_CCCR_CSA                            \ CSA
$00000010 constant FDCAN1_FDCAN_CCCR_CSR                            \ CSR
$00000020 constant FDCAN1_FDCAN_CCCR_MON                            \ MON
$00000040 constant FDCAN1_FDCAN_CCCR_DAR                            \ DAR
$00000080 constant FDCAN1_FDCAN_CCCR_TEST                           \ TEST
$00000100 constant FDCAN1_FDCAN_CCCR_FDOE                           \ FDOE
$00000200 constant FDCAN1_FDCAN_CCCR_BRSE                           \ BRSE
$00001000 constant FDCAN1_FDCAN_CCCR_PXHD                           \ PXHD
$00002000 constant FDCAN1_FDCAN_CCCR_EFBI                           \ EFBI
$00004000 constant FDCAN1_FDCAN_CCCR_TXP                            \ TXP
$00008000 constant FDCAN1_FDCAN_CCCR_NISO                           \ NISO


\
\ @brief This register is dedicated to the nominal bit timing used during the arbitration phase.
\ Address offset: 0x1C
\ Reset value: 0x00000A33
\

$0000007f constant FDCAN1_FDCAN_NBTP_NTSEG2                         \ NTSEG2
$0000ff00 constant FDCAN1_FDCAN_NBTP_NTSEG1                         \ NTSEG1
$01ff0000 constant FDCAN1_FDCAN_NBTP_NBRP                           \ NBRP
$fe000000 constant FDCAN1_FDCAN_NBTP_NSJW                           \ NSJW


\
\ @brief FDCAN timestamp counter configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant FDCAN1_FDCAN_TSCC_TSS                            \ TSS
$000f0000 constant FDCAN1_FDCAN_TSCC_TCP                            \ TCP


\
\ @brief FDCAN timestamp counter value register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN1_FDCAN_TSCV_TSC                            \ TSC


\
\ @brief FDCAN timeout counter configuration register
\ Address offset: 0x28
\ Reset value: 0xFFFF0000
\

$00000001 constant FDCAN1_FDCAN_TOCC_ETOC                           \ ETOC
$00000006 constant FDCAN1_FDCAN_TOCC_TOS                            \ TOS
$ffff0000 constant FDCAN1_FDCAN_TOCC_TOP                            \ TOP


\
\ @brief FDCAN timeout counter value register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant FDCAN1_FDCAN_TOCV_TOC                            \ TOC


\
\ @brief FDCAN error counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant FDCAN1_FDCAN_ECR_TEC                             \ TEC
$00007f00 constant FDCAN1_FDCAN_ECR_TREC                            \ TREC
$00008000 constant FDCAN1_FDCAN_ECR_RP                              \ RP
$00ff0000 constant FDCAN1_FDCAN_ECR_CEL                             \ CEL


\
\ @brief FDCAN protocol status register
\ Address offset: 0x44
\ Reset value: 0x00000707
\

$00000007 constant FDCAN1_FDCAN_PSR_LEC                             \ LEC
$00000018 constant FDCAN1_FDCAN_PSR_ACT                             \ ACT
$00000020 constant FDCAN1_FDCAN_PSR_EP                              \ EP
$00000040 constant FDCAN1_FDCAN_PSR_EW                              \ EW
$00000080 constant FDCAN1_FDCAN_PSR_BO                              \ BO
$00000700 constant FDCAN1_FDCAN_PSR_DLEC                            \ DLEC
$00000800 constant FDCAN1_FDCAN_PSR_RESI                            \ RESI
$00001000 constant FDCAN1_FDCAN_PSR_RBRS                            \ RBRS
$00002000 constant FDCAN1_FDCAN_PSR_REDL                            \ REDL
$00004000 constant FDCAN1_FDCAN_PSR_PXE                             \ PXE
$007f0000 constant FDCAN1_FDCAN_PSR_TDCV                            \ TDCV


\
\ @brief FDCAN transmitter delay compensation register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant FDCAN1_FDCAN_TDCR_TDCF                           \ TDCF
$00007f00 constant FDCAN1_FDCAN_TDCR_TDCO                           \ TDCO


\
\ @brief The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of IE controls whether an interrupt is generated. The configuration of ILS controls on which interrupt line an interrupt is signaled.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_IR_RF0N                             \ RF0N
$00000002 constant FDCAN1_FDCAN_IR_RF0W                             \ RF0W
$00000004 constant FDCAN1_FDCAN_IR_RF0F                             \ RF0F
$00000008 constant FDCAN1_FDCAN_IR_RF0L                             \ RF0L
$00000010 constant FDCAN1_FDCAN_IR_RF1N                             \ RF1N
$00000020 constant FDCAN1_FDCAN_IR_RF1W                             \ RF1W
$00000040 constant FDCAN1_FDCAN_IR_RF1F                             \ RF1F
$00000080 constant FDCAN1_FDCAN_IR_RF1L                             \ RF1L
$00000100 constant FDCAN1_FDCAN_IR_HPM                              \ HPM
$00000200 constant FDCAN1_FDCAN_IR_TC                               \ TC
$00000400 constant FDCAN1_FDCAN_IR_TCF                              \ TCF
$00000800 constant FDCAN1_FDCAN_IR_TFE                              \ TFE
$00001000 constant FDCAN1_FDCAN_IR_TEFN                             \ TEFN
$00002000 constant FDCAN1_FDCAN_IR_TEFW                             \ TEFW
$00004000 constant FDCAN1_FDCAN_IR_TEFF                             \ TEFF
$00008000 constant FDCAN1_FDCAN_IR_TEFL                             \ TEFL
$00010000 constant FDCAN1_FDCAN_IR_TSW                              \ TSW
$00020000 constant FDCAN1_FDCAN_IR_MRAF                             \ MRAF
$00040000 constant FDCAN1_FDCAN_IR_TOO                              \ TOO
$00080000 constant FDCAN1_FDCAN_IR_DRX                              \ DRX
$00400000 constant FDCAN1_FDCAN_IR_ELO                              \ ELO
$00800000 constant FDCAN1_FDCAN_IR_EP                               \ EP
$01000000 constant FDCAN1_FDCAN_IR_EW                               \ EW
$02000000 constant FDCAN1_FDCAN_IR_BO                               \ BO
$04000000 constant FDCAN1_FDCAN_IR_WDI                              \ WDI
$08000000 constant FDCAN1_FDCAN_IR_PEA                              \ PEA
$10000000 constant FDCAN1_FDCAN_IR_PED                              \ PED
$20000000 constant FDCAN1_FDCAN_IR_ARA                              \ ARA


\
\ @brief The settings in the interrupt enable register determine which status changes in the interrupt register will be signaled on an interrupt line.
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_IE_RF0NE                            \ RF0NE
$00000002 constant FDCAN1_FDCAN_IE_RF0WE                            \ RF0WE
$00000004 constant FDCAN1_FDCAN_IE_RF0FE                            \ RF0FE
$00000008 constant FDCAN1_FDCAN_IE_RF0LE                            \ RF0LE
$00000010 constant FDCAN1_FDCAN_IE_RF1NE                            \ RF1NE
$00000020 constant FDCAN1_FDCAN_IE_RF1WE                            \ RF1WE
$00000040 constant FDCAN1_FDCAN_IE_RF1FE                            \ RF1FE
$00000080 constant FDCAN1_FDCAN_IE_RF1LE                            \ RF1LE
$00000100 constant FDCAN1_FDCAN_IE_HPME                             \ HPME
$00000200 constant FDCAN1_FDCAN_IE_TCE                              \ TCE
$00000400 constant FDCAN1_FDCAN_IE_TCFE                             \ TCFE
$00000800 constant FDCAN1_FDCAN_IE_TFEE                             \ TFEE
$00001000 constant FDCAN1_FDCAN_IE_TEFNE                            \ TEFNE
$00002000 constant FDCAN1_FDCAN_IE_TEFWE                            \ TEFWE
$00004000 constant FDCAN1_FDCAN_IE_TEFFE                            \ TEFFE
$00008000 constant FDCAN1_FDCAN_IE_TEFLE                            \ TEFLE
$00010000 constant FDCAN1_FDCAN_IE_TSWE                             \ TSWE
$00020000 constant FDCAN1_FDCAN_IE_MRAFE                            \ MRAFE
$00040000 constant FDCAN1_FDCAN_IE_TOOE                             \ TOOE
$00080000 constant FDCAN1_FDCAN_IE_DRXE                             \ DRXE
$00100000 constant FDCAN1_FDCAN_IE_BECE                             \ BECE
$00200000 constant FDCAN1_FDCAN_IE_BEUE                             \ BEUE
$00400000 constant FDCAN1_FDCAN_IE_ELOE                             \ ELOE
$00800000 constant FDCAN1_FDCAN_IE_EPE                              \ EPE
$01000000 constant FDCAN1_FDCAN_IE_EWE                              \ EWE
$02000000 constant FDCAN1_FDCAN_IE_BOE                              \ BOE
$04000000 constant FDCAN1_FDCAN_IE_WDIE                             \ WDIE
$08000000 constant FDCAN1_FDCAN_IE_PEAE                             \ PEAE
$10000000 constant FDCAN1_FDCAN_IE_PEDE                             \ PEDE
$20000000 constant FDCAN1_FDCAN_IE_ARAE                             \ ARAE


\
\ @brief This register assigns an interrupt generated by a specific interrupt flag from the interrupt register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via FDCAN_ILE.EINT0 and FDCAN_ILE.EINT1.
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_ILS_RF0NL                           \ RF0NL
$00000002 constant FDCAN1_FDCAN_ILS_RF0WL                           \ RF0WL
$00000004 constant FDCAN1_FDCAN_ILS_RF0FL                           \ RF0FL
$00000008 constant FDCAN1_FDCAN_ILS_RF0LL                           \ RF0LL
$00000010 constant FDCAN1_FDCAN_ILS_RF1NL                           \ RF1NL
$00000020 constant FDCAN1_FDCAN_ILS_RF1WL                           \ RF1WL
$00000040 constant FDCAN1_FDCAN_ILS_RF1FL                           \ RF1FL
$00000080 constant FDCAN1_FDCAN_ILS_RF1LL                           \ RF1LL
$00000100 constant FDCAN1_FDCAN_ILS_HPML                            \ HPML
$00000200 constant FDCAN1_FDCAN_ILS_TCL                             \ TCL
$00000400 constant FDCAN1_FDCAN_ILS_TCFL                            \ TCFL
$00000800 constant FDCAN1_FDCAN_ILS_TFEL                            \ TFEL
$00001000 constant FDCAN1_FDCAN_ILS_TEFNL                           \ TEFNL
$00002000 constant FDCAN1_FDCAN_ILS_TEFWL                           \ TEFWL
$00004000 constant FDCAN1_FDCAN_ILS_TEFFL                           \ TEFFL
$00008000 constant FDCAN1_FDCAN_ILS_TEFLL                           \ TEFLL
$00010000 constant FDCAN1_FDCAN_ILS_TSWL                            \ TSWL
$00020000 constant FDCAN1_FDCAN_ILS_MRAFL                           \ MRAFL
$00040000 constant FDCAN1_FDCAN_ILS_TOOL                            \ TOOL
$00080000 constant FDCAN1_FDCAN_ILS_DRXL                            \ DRXL
$00100000 constant FDCAN1_FDCAN_ILS_BECL                            \ BECL
$00200000 constant FDCAN1_FDCAN_ILS_BEUL                            \ BEUL
$00400000 constant FDCAN1_FDCAN_ILS_ELOL                            \ ELOL
$00800000 constant FDCAN1_FDCAN_ILS_EPL                             \ EPL
$01000000 constant FDCAN1_FDCAN_ILS_EWL                             \ EWL
$02000000 constant FDCAN1_FDCAN_ILS_BOL                             \ BOL
$04000000 constant FDCAN1_FDCAN_ILS_WDIL                            \ WDIL
$08000000 constant FDCAN1_FDCAN_ILS_PEAL                            \ PEAL
$10000000 constant FDCAN1_FDCAN_ILS_PEDL                            \ PEDL
$20000000 constant FDCAN1_FDCAN_ILS_ARAL                            \ ARAL


\
\ @brief Each of the two interrupt lines to the CPU can be enabled/disabled separately by programming bits EINT0 and EINT1.
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_ILE_EINT0                           \ EINT0
$00000002 constant FDCAN1_FDCAN_ILE_EINT1                           \ EINT1


\
\ @brief Global settings for message ID filtering. The global filter configuration register controls the filter path for standard and extended messages as described in Figure708: Standard message ID filter path and Figure709: Extended message ID filter path.
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_GFC_RRFE                            \ RRFE
$00000002 constant FDCAN1_FDCAN_GFC_RRFS                            \ RRFS
$0000000c constant FDCAN1_FDCAN_GFC_ANFE                            \ ANFE
$00000030 constant FDCAN1_FDCAN_GFC_ANFS                            \ ANFS


\
\ @brief Settings for 11-bit standard message ID filtering.The standard ID filter configuration register controls the filter path for standard messages as described in Figure708.
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN1_FDCAN_SIDFC_FLSSA                         \ FLSSA
$00ff0000 constant FDCAN1_FDCAN_SIDFC_LSS                           \ LSS


\
\ @brief Settings for 29-bit extended message ID filtering. The FDCAN extended ID filter configuration register controls the filter path for standard messages as described in Figure709: Extended message ID filter path.
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN1_FDCAN_XIDFC_FLESA                         \ FLESA
$00ff0000 constant FDCAN1_FDCAN_XIDFC_LSE                           \ LSE


\
\ @brief FDCAN extended ID and mask register
\ Address offset: 0x90
\ Reset value: 0x1FFFFFFF
\

$1fffffff constant FDCAN1_FDCAN_XIDAM_EIDM                          \ EIDM


\
\ @brief This register is updated every time a message ID filter element configured to generate a priority event match. This can be used to monitor the status of incoming high priority messages and to enable fast access to these messages.
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000003f constant FDCAN1_FDCAN_HPMS_BIDX                           \ BIDX
$000000c0 constant FDCAN1_FDCAN_HPMS_MSI                            \ MSI
$00007f00 constant FDCAN1_FDCAN_HPMS_FIDX                           \ FIDX
$00008000 constant FDCAN1_FDCAN_HPMS_FLST                           \ FLST


\
\ @brief FDCAN new data 1 register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_NDAT1_ND0                           \ ND0
$00000002 constant FDCAN1_FDCAN_NDAT1_ND1                           \ ND1
$00000004 constant FDCAN1_FDCAN_NDAT1_ND2                           \ ND2
$00000008 constant FDCAN1_FDCAN_NDAT1_ND3                           \ ND3
$00000010 constant FDCAN1_FDCAN_NDAT1_ND4                           \ ND4
$00000020 constant FDCAN1_FDCAN_NDAT1_ND5                           \ ND5
$00000040 constant FDCAN1_FDCAN_NDAT1_ND6                           \ ND6
$00000080 constant FDCAN1_FDCAN_NDAT1_ND7                           \ ND7
$00000100 constant FDCAN1_FDCAN_NDAT1_ND8                           \ ND8
$00000200 constant FDCAN1_FDCAN_NDAT1_ND9                           \ ND9
$00000400 constant FDCAN1_FDCAN_NDAT1_ND10                          \ ND10
$00000800 constant FDCAN1_FDCAN_NDAT1_ND11                          \ ND11
$00001000 constant FDCAN1_FDCAN_NDAT1_ND12                          \ ND12
$00002000 constant FDCAN1_FDCAN_NDAT1_ND13                          \ ND13
$00004000 constant FDCAN1_FDCAN_NDAT1_ND14                          \ ND14
$00008000 constant FDCAN1_FDCAN_NDAT1_ND15                          \ ND15
$00010000 constant FDCAN1_FDCAN_NDAT1_ND16                          \ ND16
$00020000 constant FDCAN1_FDCAN_NDAT1_ND17                          \ ND17
$00040000 constant FDCAN1_FDCAN_NDAT1_ND18                          \ ND18
$00080000 constant FDCAN1_FDCAN_NDAT1_ND19                          \ ND19
$00100000 constant FDCAN1_FDCAN_NDAT1_ND20                          \ ND20
$00200000 constant FDCAN1_FDCAN_NDAT1_ND21                          \ ND21
$00400000 constant FDCAN1_FDCAN_NDAT1_ND22                          \ ND22
$00800000 constant FDCAN1_FDCAN_NDAT1_ND23                          \ ND23
$01000000 constant FDCAN1_FDCAN_NDAT1_ND24                          \ ND24
$02000000 constant FDCAN1_FDCAN_NDAT1_ND25                          \ ND25
$04000000 constant FDCAN1_FDCAN_NDAT1_ND26                          \ ND26
$08000000 constant FDCAN1_FDCAN_NDAT1_ND27                          \ ND27
$10000000 constant FDCAN1_FDCAN_NDAT1_ND28                          \ ND28
$20000000 constant FDCAN1_FDCAN_NDAT1_ND29                          \ ND29
$40000000 constant FDCAN1_FDCAN_NDAT1_ND30                          \ ND30
$80000000 constant FDCAN1_FDCAN_NDAT1_ND31                          \ ND31


\
\ @brief FDCAN new data 2 register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_NDAT2_ND32                          \ ND32
$00000002 constant FDCAN1_FDCAN_NDAT2_ND33                          \ ND33
$00000004 constant FDCAN1_FDCAN_NDAT2_ND34                          \ ND34
$00000008 constant FDCAN1_FDCAN_NDAT2_ND35                          \ ND35
$00000010 constant FDCAN1_FDCAN_NDAT2_ND36                          \ ND36
$00000020 constant FDCAN1_FDCAN_NDAT2_ND37                          \ ND37
$00000040 constant FDCAN1_FDCAN_NDAT2_ND38                          \ ND38
$00000080 constant FDCAN1_FDCAN_NDAT2_ND39                          \ ND39
$00000100 constant FDCAN1_FDCAN_NDAT2_ND40                          \ ND40
$00000200 constant FDCAN1_FDCAN_NDAT2_ND41                          \ ND41
$00000400 constant FDCAN1_FDCAN_NDAT2_ND42                          \ ND42
$00000800 constant FDCAN1_FDCAN_NDAT2_ND43                          \ ND43
$00001000 constant FDCAN1_FDCAN_NDAT2_ND44                          \ ND44
$00002000 constant FDCAN1_FDCAN_NDAT2_ND45                          \ ND45
$00004000 constant FDCAN1_FDCAN_NDAT2_ND46                          \ ND46
$00008000 constant FDCAN1_FDCAN_NDAT2_ND47                          \ ND47
$00010000 constant FDCAN1_FDCAN_NDAT2_ND48                          \ ND48
$00020000 constant FDCAN1_FDCAN_NDAT2_ND49                          \ ND49
$00040000 constant FDCAN1_FDCAN_NDAT2_ND50                          \ ND50
$00080000 constant FDCAN1_FDCAN_NDAT2_ND51                          \ ND51
$00100000 constant FDCAN1_FDCAN_NDAT2_ND52                          \ ND52
$00200000 constant FDCAN1_FDCAN_NDAT2_ND53                          \ ND53
$00400000 constant FDCAN1_FDCAN_NDAT2_ND54                          \ ND54
$00800000 constant FDCAN1_FDCAN_NDAT2_ND55                          \ ND55
$01000000 constant FDCAN1_FDCAN_NDAT2_ND56                          \ ND56
$02000000 constant FDCAN1_FDCAN_NDAT2_ND57                          \ ND57
$04000000 constant FDCAN1_FDCAN_NDAT2_ND58                          \ ND58
$08000000 constant FDCAN1_FDCAN_NDAT2_ND59                          \ ND59
$10000000 constant FDCAN1_FDCAN_NDAT2_ND60                          \ ND60
$20000000 constant FDCAN1_FDCAN_NDAT2_ND61                          \ ND61
$40000000 constant FDCAN1_FDCAN_NDAT2_ND62                          \ ND62
$80000000 constant FDCAN1_FDCAN_NDAT2_ND63                          \ ND63


\
\ @brief FDCAN Rx FIFO 0 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN1_FDCAN_RXF0C_F0SA                          \ F0SA
$007f0000 constant FDCAN1_FDCAN_RXF0C_F0S                           \ F0S
$7f000000 constant FDCAN1_FDCAN_RXF0C_F0WM                          \ F0WM
$80000000 constant FDCAN1_FDCAN_RXF0C_F0OM                          \ F0OM


\
\ @brief FDCAN Rx FIFO 0 status register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000007f constant FDCAN1_FDCAN_RXF0S_F0FL                          \ F0FL
$00003f00 constant FDCAN1_FDCAN_RXF0S_F0GI                          \ F0GI
$003f0000 constant FDCAN1_FDCAN_RXF0S_F0PI                          \ F0PI
$01000000 constant FDCAN1_FDCAN_RXF0S_F0F                           \ F0F
$02000000 constant FDCAN1_FDCAN_RXF0S_RF0L                          \ RF0L


\
\ @brief FDCAN Rx FIFO 0 acknowledge register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000003f constant FDCAN1_FDCAN_RXF0A_F0AI                          \ F0AI


\
\ @brief FDCAN Rx buffer configuration register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN1_FDCAN_RXBC_RBSA                           \ RBSA


\
\ @brief FDCAN Rx FIFO 1 configuration register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN1_FDCAN_RXF1C_F1SA                          \ F1SA
$007f0000 constant FDCAN1_FDCAN_RXF1C_F1S                           \ F1S
$7f000000 constant FDCAN1_FDCAN_RXF1C_F1WM                          \ F1WM
$80000000 constant FDCAN1_FDCAN_RXF1C_F1OM                          \ F1OM


\
\ @brief FDCAN Rx FIFO 1 status register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant FDCAN1_FDCAN_RXF1S_F1FL                          \ F1FL
$00003f00 constant FDCAN1_FDCAN_RXF1S_F1GI                          \ F1GI
$003f0000 constant FDCAN1_FDCAN_RXF1S_F1PI                          \ F1PI
$01000000 constant FDCAN1_FDCAN_RXF1S_F1F                           \ F1F
$02000000 constant FDCAN1_FDCAN_RXF1S_RF1L                          \ RF1L
$c0000000 constant FDCAN1_FDCAN_RXF1S_DMS                           \ DMS


\
\ @brief FDCAN Rx FIFO 1 acknowledge register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$0000003f constant FDCAN1_FDCAN_RXF1A_F1AI                          \ F1AI


\
\ @brief Configures the number of data bytes belonging to an Rx buffer / Rx FIFO element. Data field sizes higher than 8 bytes are intended for CAN FD operation only.
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_RXESC_F0DS                          \ F0DS
$00000070 constant FDCAN1_FDCAN_RXESC_F1DS                          \ F1DS
$00000700 constant FDCAN1_FDCAN_RXESC_RBDS                          \ RBDS


\
\ @brief FDCAN Tx buffer configuration register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN1_FDCAN_TXBC_TBSA                           \ TBSA
$003f0000 constant FDCAN1_FDCAN_TXBC_NDTB                           \ NDTB
$3f000000 constant FDCAN1_FDCAN_TXBC_TFQS                           \ TFQS
$40000000 constant FDCAN1_FDCAN_TXBC_TFQM                           \ TFQM


\
\ @brief The Tx FIFO/queue status is related to the pending Tx requests listed in register FDCAN_TXBRP. Therefore the effect of add/cancellation requests may be delayed due to a running Tx scan (FDCAN_TXBRP not yet updated).
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$0000003f constant FDCAN1_FDCAN_TXFQS_TFFL                          \ TFFL
$00001f00 constant FDCAN1_FDCAN_TXFQS_TFGI                          \ TFGI
$001f0000 constant FDCAN1_FDCAN_TXFQS_TFQPI                         \ TFQPI
$00200000 constant FDCAN1_FDCAN_TXFQS_TFQF                          \ TFQF


\
\ @brief Configures the number of data bytes belonging to a Tx buffer element. Data field sizes &gt;8 bytes are intended for CAN FD operation only.
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_TXESC_TBDS                          \ TBDS


\
\ @brief FDCAN Tx buffer add request register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant FDCAN1_FDCAN_TXBAR_AR                            \ AR


\
\ @brief FDCAN Tx buffer cancellation request register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000000 constant FDCAN1_FDCAN_TXBCR_CR                            \ CR


\
\ @brief FDCAN Tx buffer transmission occurred register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000000 constant FDCAN1_FDCAN_TXBTO_TO                            \ TO


\
\ @brief FDCAN Tx buffer cancellation finished register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000000 constant FDCAN1_FDCAN_TXBCF_CF                            \ CF


\
\ @brief FDCAN Tx buffer transmission interrupt enable register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000000 constant FDCAN1_FDCAN_TXBTIE_TIE                          \ TIE


\
\ @brief FDCAN Tx buffer cancellation finished interrupt enable register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000000 constant FDCAN1_FDCAN_TXBCIE_CFIE                         \ CFIE


\
\ @brief FDCAN Tx event FIFO configuration register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN1_FDCAN_TXEFC_EFSA                          \ EFSA
$003f0000 constant FDCAN1_FDCAN_TXEFC_EFS                           \ EFS
$3f000000 constant FDCAN1_FDCAN_TXEFC_EFWM                          \ EFWM


\
\ @brief FDCAN Tx event FIFO status register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$0000003f constant FDCAN1_FDCAN_TXEFS_EFFL                          \ EFFL
$00001f00 constant FDCAN1_FDCAN_TXEFS_EFGI                          \ EFGI
$001f0000 constant FDCAN1_FDCAN_TXEFS_EFPI                          \ EFPI
$01000000 constant FDCAN1_FDCAN_TXEFS_EFF                           \ EFF
$02000000 constant FDCAN1_FDCAN_TXEFS_TEFL                          \ TEFL


\
\ @brief FDCAN Tx event FIFO acknowledge register
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$0000001f constant FDCAN1_FDCAN_TXEFA_EFAI                          \ EFAI


\
\ @brief FDCAN TT trigger memory configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN1_FDCAN_TTTMC_TMSA                          \ TMSA
$007f0000 constant FDCAN1_FDCAN_TTTMC_TME                           \ TME


\
\ @brief FDCAN TT reference message configuration register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$1fffffff constant FDCAN1_FDCAN_TTRMC_RID                           \ RID
$40000000 constant FDCAN1_FDCAN_TTRMC_XTD                           \ XTD
$80000000 constant FDCAN1_FDCAN_TTRMC_RMPS                          \ RMPS


\
\ @brief FDCAN TT operation configuration register
\ Address offset: 0x108
\ Reset value: 0x00010000
\

$00000003 constant FDCAN1_FDCAN_TTOCF_OM                            \ OM
$00000008 constant FDCAN1_FDCAN_TTOCF_GEN                           \ GEN
$00000010 constant FDCAN1_FDCAN_TTOCF_TM                            \ TM
$000000e0 constant FDCAN1_FDCAN_TTOCF_LDSDL                         \ LDSDL
$00007f00 constant FDCAN1_FDCAN_TTOCF_IRTO                          \ IRTO
$00008000 constant FDCAN1_FDCAN_TTOCF_EECS                          \ EECS
$00ff0000 constant FDCAN1_FDCAN_TTOCF_AWL                           \ AWL
$01000000 constant FDCAN1_FDCAN_TTOCF_EGTF                          \ EGTF
$02000000 constant FDCAN1_FDCAN_TTOCF_ECC                           \ ECC
$04000000 constant FDCAN1_FDCAN_TTOCF_EVTP                          \ EVTP


\
\ @brief FDCAN TT matrix limits register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000003f constant FDCAN1_FDCAN_TTMLM_CCM                           \ CCM
$000000c0 constant FDCAN1_FDCAN_TTMLM_CSS                           \ CSS
$00000f00 constant FDCAN1_FDCAN_TTMLM_TXEW                          \ TXEW
$0fff0000 constant FDCAN1_FDCAN_TTMLM_ENTT                          \ ENTT


\
\ @brief The length of the NTU is given by: NTU = CAN clock period x NC/DC. NC is an 18-bit value. Its high part, NCH[17:16] is hard wired to 0b01. Therefore the range of NC extends from 0x10000 to 0x1FFFF. The value configured by NCL is the initial value for FDCAN_TURNA.NAV[15:0]. DC is set to 0x1000 by hardware reset and it may not be written to 0x0000. Level 1: NC 4 * DC and NTU = CAN bit time Levels 0 and 2: NC 8 * DC The actual value of FDCAN_TUR may be changed by the clock drift compensation function of TTCAN level 0 and level 2 in order to adjust the node local view of the NTU to the time master view of the NTU. DC will not be changed by the automatic drift compensation, FDCAN_TURNA.NAV may be adjusted around NC in the range of the synchronization deviation limit given by FDCAN_TTOCF.LDSDL. NC and DC should be programmed to the largest suitable values in achieve the best computational accuracy for the drift compensation process.
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN1_FDCAN_TURCF_NCL                           \ NCL
$3fff0000 constant FDCAN1_FDCAN_TURCF_DC                            \ DC
$80000000 constant FDCAN1_FDCAN_TURCF_ELT                           \ ELT


\
\ @brief FDCAN TT operation control register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_TTOCN_SGT                           \ SGT
$00000002 constant FDCAN1_FDCAN_TTOCN_ECS                           \ ECS
$00000004 constant FDCAN1_FDCAN_TTOCN_SWP                           \ SWP
$00000018 constant FDCAN1_FDCAN_TTOCN_SWS                           \ SWS
$00000020 constant FDCAN1_FDCAN_TTOCN_RTIE                          \ RTIE
$000000c0 constant FDCAN1_FDCAN_TTOCN_TMC                           \ TMC
$00000100 constant FDCAN1_FDCAN_TTOCN_TTIE                          \ TTIE
$00000200 constant FDCAN1_FDCAN_TTOCN_GCS                           \ GCS
$00000400 constant FDCAN1_FDCAN_TTOCN_FGP                           \ FGP
$00000800 constant FDCAN1_FDCAN_TTOCN_TMG                           \ TMG
$00001000 constant FDCAN1_FDCAN_TTOCN_NIG                           \ NIG
$00002000 constant FDCAN1_FDCAN_TTOCN_ESCN                          \ ESCN
$00008000 constant FDCAN1_FDCAN_TTOCN_LCKC                          \ LCKC


\
\ @brief If TTOST.WGDT is set, the next reference message will be transmitted with the Master_Ref_Mark modified by the preset value and with Disc_Bit = 1, presetting the global time in all nodes simultaneously. TP is reset to 0x0000 each time a reference message with Disc_Bit = 1 becomes valid or if the node is not the current time master. TP is locked while FDCAN_TTOST.WGTD = 1 after setting FDCAN_TTOCN.SGT until the reference message with Disc_Bit = 1 becomes valid or until the node is no longer the current time master.
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN1_FDCAN_TTGTP_TP                            \ TP
$ffff0000 constant FDCAN1_FDCAN_TTGTP_CTP                           \ CTP


\
\ @brief A time mark interrupt (FDCAN_TTIR.TMI = 1) is generated when the time base indicated by FDCAN_TTOCN.TMC (cycle time, local time, or global time) has the same value as TM.
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN1_FDCAN_TTTMK_TM                            \ TM
$007f0000 constant FDCAN1_FDCAN_TTTMK_TICC                          \ TICC
$80000000 constant FDCAN1_FDCAN_TTTMK_LCKM                          \ LCKM


\
\ @brief The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register.
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_TTIR_SBC                            \ SBC
$00000002 constant FDCAN1_FDCAN_TTIR_SMC                            \ SMC
$00000004 constant FDCAN1_FDCAN_TTIR_CSM                            \ CSM
$00000008 constant FDCAN1_FDCAN_TTIR_SOG                            \ SOG
$00000010 constant FDCAN1_FDCAN_TTIR_RTMI                           \ RTMI
$00000020 constant FDCAN1_FDCAN_TTIR_TTMI                           \ TTMI
$00000040 constant FDCAN1_FDCAN_TTIR_SWE                            \ SWE
$00000080 constant FDCAN1_FDCAN_TTIR_GTW                            \ GTW
$00000100 constant FDCAN1_FDCAN_TTIR_GTD                            \ GTD
$00000200 constant FDCAN1_FDCAN_TTIR_GTE                            \ GTE
$00000400 constant FDCAN1_FDCAN_TTIR_TXU                            \ TXU
$00000800 constant FDCAN1_FDCAN_TTIR_TXO                            \ TXO
$00001000 constant FDCAN1_FDCAN_TTIR_SE1                            \ SE1
$00002000 constant FDCAN1_FDCAN_TTIR_SE2                            \ SE2
$00004000 constant FDCAN1_FDCAN_TTIR_ELC                            \ ELC
$00008000 constant FDCAN1_FDCAN_TTIR_IWTG                           \ IWTG
$00010000 constant FDCAN1_FDCAN_TTIR_WT                             \ WT
$00020000 constant FDCAN1_FDCAN_TTIR_AW                             \ AW
$00040000 constant FDCAN1_FDCAN_TTIR_CER                            \ CER


\
\ @brief The settings in the TT interrupt enable register determine which status changes in the TT interrupt register will result in an interrupt.
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_TTIE_SBCE                           \ SBCE
$00000002 constant FDCAN1_FDCAN_TTIE_SMCE                           \ SMCE
$00000004 constant FDCAN1_FDCAN_TTIE_CSME                           \ CSME
$00000008 constant FDCAN1_FDCAN_TTIE_SOGE                           \ SOGE
$00000010 constant FDCAN1_FDCAN_TTIE_RTMIE                          \ RTMIE
$00000020 constant FDCAN1_FDCAN_TTIE_TTMIE                          \ TTMIE
$00000040 constant FDCAN1_FDCAN_TTIE_SWEE                           \ SWEE
$00000080 constant FDCAN1_FDCAN_TTIE_GTWE                           \ GTWE
$00000100 constant FDCAN1_FDCAN_TTIE_GTDE                           \ GTDE
$00000200 constant FDCAN1_FDCAN_TTIE_GTEE                           \ GTEE
$00000400 constant FDCAN1_FDCAN_TTIE_TXUE                           \ TXUE
$00000800 constant FDCAN1_FDCAN_TTIE_TXOE                           \ TXOE
$00001000 constant FDCAN1_FDCAN_TTIE_SE1E                           \ SE1E
$00002000 constant FDCAN1_FDCAN_TTIE_SE2E                           \ SE2E
$00004000 constant FDCAN1_FDCAN_TTIE_ELCE                           \ ELCE
$00008000 constant FDCAN1_FDCAN_TTIE_IWTE                           \ IWTE
$00010000 constant FDCAN1_FDCAN_TTIE_WTE                            \ WTE
$00020000 constant FDCAN1_FDCAN_TTIE_AWE                            \ AWE
$00040000 constant FDCAN1_FDCAN_TTIE_CERE                           \ CERE


\
\ @brief The TT interrupt Line select register assigns an interrupt generated by a specific interrupt flag from the TT interrupt register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via FDCAN_ILE.EINT0 and FDCAN_ILE.EINT1.
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_TTILS_SBCL                          \ SBCL
$00000002 constant FDCAN1_FDCAN_TTILS_SMCL                          \ SMCL
$00000004 constant FDCAN1_FDCAN_TTILS_CSML                          \ CSML
$00000008 constant FDCAN1_FDCAN_TTILS_SOGL                          \ SOGL
$00000010 constant FDCAN1_FDCAN_TTILS_RTMIL                         \ RTMIL
$00000020 constant FDCAN1_FDCAN_TTILS_TTMIL                         \ TTMIL
$00000040 constant FDCAN1_FDCAN_TTILS_SWEL                          \ SWEL
$00000080 constant FDCAN1_FDCAN_TTILS_GTWL                          \ GTWL
$00000100 constant FDCAN1_FDCAN_TTILS_GTDL                          \ GTDL
$00000200 constant FDCAN1_FDCAN_TTILS_GTEL                          \ GTEL
$00000400 constant FDCAN1_FDCAN_TTILS_TXUL                          \ TXUL
$00000800 constant FDCAN1_FDCAN_TTILS_TXOL                          \ TXOL
$00001000 constant FDCAN1_FDCAN_TTILS_SE1L                          \ SE1L
$00002000 constant FDCAN1_FDCAN_TTILS_SE2L                          \ SE2L
$00004000 constant FDCAN1_FDCAN_TTILS_ELCL                          \ ELCL
$00008000 constant FDCAN1_FDCAN_TTILS_IWTL                          \ IWTL
$00010000 constant FDCAN1_FDCAN_TTILS_WTL                           \ WTL
$00020000 constant FDCAN1_FDCAN_TTILS_AWL                           \ AWL
$00040000 constant FDCAN1_FDCAN_TTILS_CERL                          \ CERL


\
\ @brief FDCAN TT operation status register
\ Address offset: 0x12C
\ Reset value: 0x00000080
\

$00000003 constant FDCAN1_FDCAN_TTOST_EL                            \ EL
$0000000c constant FDCAN1_FDCAN_TTOST_MS                            \ MS
$00000030 constant FDCAN1_FDCAN_TTOST_SYS                           \ SYS
$00000040 constant FDCAN1_FDCAN_TTOST_QGTP                          \ QGTP
$00000080 constant FDCAN1_FDCAN_TTOST_QCS                           \ QCS
$0000ff00 constant FDCAN1_FDCAN_TTOST_RTO                           \ RTO
$00400000 constant FDCAN1_FDCAN_TTOST_WGTD                          \ WGTD
$00800000 constant FDCAN1_FDCAN_TTOST_GFI                           \ GFI
$07000000 constant FDCAN1_FDCAN_TTOST_TMP                           \ TMP
$08000000 constant FDCAN1_FDCAN_TTOST_GSI                           \ GSI
$10000000 constant FDCAN1_FDCAN_TTOST_WFE                           \ WFE
$20000000 constant FDCAN1_FDCAN_TTOST_AWE                           \ AWE
$40000000 constant FDCAN1_FDCAN_TTOST_WECS                          \ WECS
$80000000 constant FDCAN1_FDCAN_TTOST_SPL                           \ SPL


\
\ @brief There is no drift compensation in TTCAN level 1.
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0003ffff constant FDCAN1_FDCAN_TURNA_NAV                           \ NAV


\
\ @brief FDCAN TT local and global time register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN1_FDCAN_TTLGT_LT                            \ LT
$ffff0000 constant FDCAN1_FDCAN_TTLGT_GT                            \ GT


\
\ @brief FDCAN TT cycle time and count register
\ Address offset: 0x138
\ Reset value: 0x003F0000
\

$0000ffff constant FDCAN1_FDCAN_TTCTC_CT                            \ CT
$003f0000 constant FDCAN1_FDCAN_TTCTC_CC                            \ CC


\
\ @brief FDCAN TT capture time register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$0000003f constant FDCAN1_FDCAN_TTCPT_CCV                           \ CCV
$ffff0000 constant FDCAN1_FDCAN_TTCPT_SWV                           \ SWV


\
\ @brief FDCAN TT cycle sync mark register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN1_FDCAN_TTCSM_CSM                           \ CSM


\
\ @brief The settings in the FDCAN_TTTS register select the input to be used as event trigger and stop watch trigger.
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000003 constant FDCAN1_FDCAN_TTTS_SWTDEL                         \ SWTDEL
$00000030 constant FDCAN1_FDCAN_TTTS_EVTSEL                         \ EVTSEL


\
\ @brief FDCAN1
\
$4400e000 constant FDCAN1_FDCAN_CREL  \ offset: 0x00 : FDCAN core release register
$4400e004 constant FDCAN1_FDCAN_ENDN  \ offset: 0x04 : FDCAN Endian register
$4400e00c constant FDCAN1_FDCAN_DBTP  \ offset: 0x0C : This register is dedicated to data bit timing phase and only writable if bits FDCAN_CCCR.CCE and FDCAN_CCCR.INIT are set. The CAN time quantum may be programmed in the range from 1 to 32 FDCAN clock periods. tq = (DBRP + 1) FDCAN clock periods. DTSEG1 is the sum of Prop_Seg and Phase_Seg1. DTSEG2 is Phase_Seg2. Therefore the length of the bit time is (DTSEG1 + DTSEG2 + 3) tq for programmed values, or (Sync_Seg+Prop_Seg+Phase_Seg1+Phase_Seg2) tq for functional values. The information processing time (IPT) is zero, meaning the data for the next bit is available at the first clock edge after the sample point.
$4400e010 constant FDCAN1_FDCAN_TEST  \ offset: 0x10 : Write access to this register has to be enabled by setting bit FDCAN_CCCR.TEST to 1. All register functions are set to their reset values when bit FDCAN_CCCR.TEST is reset. Loop back mode and software control of Tx pin FDCANx_TX are hardware test modes. Programming TX differently from 00 may disturb the message transfer on the CAN bus.
$4400e014 constant FDCAN1_FDCAN_RWD  \ offset: 0x14 : The RAM watchdog monitors the READY output of the message RAM. A message RAM access starts the message RAM watchdog counter with the value configured by the FDCAN_RWD.WDC bits. The counter is reloaded with FDCAN_RWD.WDC bits when the message RAM signals successful completion by activating its READY output. In case there is no response from the message RAM until the counter has counted down to 0, the counter stops and interrupt flag FDCAN_IR.WDI bit is set. The RAM watchdog counter is clocked by the fdcan_pclk clock.
$4400e018 constant FDCAN1_FDCAN_CCCR  \ offset: 0x18 : For details about setting and resetting of single bits see Software initialization.
$4400e01c constant FDCAN1_FDCAN_NBTP  \ offset: 0x1C : This register is dedicated to the nominal bit timing used during the arbitration phase.
$4400e020 constant FDCAN1_FDCAN_TSCC  \ offset: 0x20 : FDCAN timestamp counter configuration register
$4400e024 constant FDCAN1_FDCAN_TSCV  \ offset: 0x24 : FDCAN timestamp counter value register
$4400e028 constant FDCAN1_FDCAN_TOCC  \ offset: 0x28 : FDCAN timeout counter configuration register
$4400e02c constant FDCAN1_FDCAN_TOCV  \ offset: 0x2C : FDCAN timeout counter value register
$4400e040 constant FDCAN1_FDCAN_ECR  \ offset: 0x40 : FDCAN error counter register
$4400e044 constant FDCAN1_FDCAN_PSR  \ offset: 0x44 : FDCAN protocol status register
$4400e048 constant FDCAN1_FDCAN_TDCR  \ offset: 0x48 : FDCAN transmitter delay compensation register
$4400e050 constant FDCAN1_FDCAN_IR  \ offset: 0x50 : The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of IE controls whether an interrupt is generated. The configuration of ILS controls on which interrupt line an interrupt is signaled.
$4400e054 constant FDCAN1_FDCAN_IE  \ offset: 0x54 : The settings in the interrupt enable register determine which status changes in the interrupt register will be signaled on an interrupt line.
$4400e058 constant FDCAN1_FDCAN_ILS  \ offset: 0x58 : This register assigns an interrupt generated by a specific interrupt flag from the interrupt register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via FDCAN_ILE.EINT0 and FDCAN_ILE.EINT1.
$4400e05c constant FDCAN1_FDCAN_ILE  \ offset: 0x5C : Each of the two interrupt lines to the CPU can be enabled/disabled separately by programming bits EINT0 and EINT1.
$4400e080 constant FDCAN1_FDCAN_GFC  \ offset: 0x80 : Global settings for message ID filtering. The global filter configuration register controls the filter path for standard and extended messages as described in Figure708: Standard message ID filter path and Figure709: Extended message ID filter path.
$4400e084 constant FDCAN1_FDCAN_SIDFC  \ offset: 0x84 : Settings for 11-bit standard message ID filtering.The standard ID filter configuration register controls the filter path for standard messages as described in Figure708.
$4400e088 constant FDCAN1_FDCAN_XIDFC  \ offset: 0x88 : Settings for 29-bit extended message ID filtering. The FDCAN extended ID filter configuration register controls the filter path for standard messages as described in Figure709: Extended message ID filter path.
$4400e090 constant FDCAN1_FDCAN_XIDAM  \ offset: 0x90 : FDCAN extended ID and mask register
$4400e094 constant FDCAN1_FDCAN_HPMS  \ offset: 0x94 : This register is updated every time a message ID filter element configured to generate a priority event match. This can be used to monitor the status of incoming high priority messages and to enable fast access to these messages.
$4400e098 constant FDCAN1_FDCAN_NDAT1  \ offset: 0x98 : FDCAN new data 1 register
$4400e09c constant FDCAN1_FDCAN_NDAT2  \ offset: 0x9C : FDCAN new data 2 register
$4400e0a0 constant FDCAN1_FDCAN_RXF0C  \ offset: 0xA0 : FDCAN Rx FIFO 0 configuration register
$4400e0a4 constant FDCAN1_FDCAN_RXF0S  \ offset: 0xA4 : FDCAN Rx FIFO 0 status register
$4400e0a8 constant FDCAN1_FDCAN_RXF0A  \ offset: 0xA8 : FDCAN Rx FIFO 0 acknowledge register
$4400e0ac constant FDCAN1_FDCAN_RXBC  \ offset: 0xAC : FDCAN Rx buffer configuration register
$4400e0b0 constant FDCAN1_FDCAN_RXF1C  \ offset: 0xB0 : FDCAN Rx FIFO 1 configuration register
$4400e0b4 constant FDCAN1_FDCAN_RXF1S  \ offset: 0xB4 : FDCAN Rx FIFO 1 status register
$4400e0b8 constant FDCAN1_FDCAN_RXF1A  \ offset: 0xB8 : FDCAN Rx FIFO 1 acknowledge register
$4400e0bc constant FDCAN1_FDCAN_RXESC  \ offset: 0xBC : Configures the number of data bytes belonging to an Rx buffer / Rx FIFO element. Data field sizes higher than 8 bytes are intended for CAN FD operation only.
$4400e0c0 constant FDCAN1_FDCAN_TXBC  \ offset: 0xC0 : FDCAN Tx buffer configuration register
$4400e0c4 constant FDCAN1_FDCAN_TXFQS  \ offset: 0xC4 : The Tx FIFO/queue status is related to the pending Tx requests listed in register FDCAN_TXBRP. Therefore the effect of add/cancellation requests may be delayed due to a running Tx scan (FDCAN_TXBRP not yet updated).
$4400e0c8 constant FDCAN1_FDCAN_TXESC  \ offset: 0xC8 : Configures the number of data bytes belonging to a Tx buffer element. Data field sizes &gt;8 bytes are intended for CAN FD operation only.
$4400e0d0 constant FDCAN1_FDCAN_TXBAR  \ offset: 0xD0 : FDCAN Tx buffer add request register
$4400e0d4 constant FDCAN1_FDCAN_TXBCR  \ offset: 0xD4 : FDCAN Tx buffer cancellation request register
$4400e0d8 constant FDCAN1_FDCAN_TXBTO  \ offset: 0xD8 : FDCAN Tx buffer transmission occurred register
$4400e0dc constant FDCAN1_FDCAN_TXBCF  \ offset: 0xDC : FDCAN Tx buffer cancellation finished register
$4400e0e0 constant FDCAN1_FDCAN_TXBTIE  \ offset: 0xE0 : FDCAN Tx buffer transmission interrupt enable register
$4400e0e4 constant FDCAN1_FDCAN_TXBCIE  \ offset: 0xE4 : FDCAN Tx buffer cancellation finished interrupt enable register
$4400e0f0 constant FDCAN1_FDCAN_TXEFC  \ offset: 0xF0 : FDCAN Tx event FIFO configuration register
$4400e0f4 constant FDCAN1_FDCAN_TXEFS  \ offset: 0xF4 : FDCAN Tx event FIFO status register
$4400e0f8 constant FDCAN1_FDCAN_TXEFA  \ offset: 0xF8 : FDCAN Tx event FIFO acknowledge register
$4400e100 constant FDCAN1_FDCAN_TTTMC  \ offset: 0x100 : FDCAN TT trigger memory configuration register
$4400e104 constant FDCAN1_FDCAN_TTRMC  \ offset: 0x104 : FDCAN TT reference message configuration register
$4400e108 constant FDCAN1_FDCAN_TTOCF  \ offset: 0x108 : FDCAN TT operation configuration register
$4400e10c constant FDCAN1_FDCAN_TTMLM  \ offset: 0x10C : FDCAN TT matrix limits register
$4400e110 constant FDCAN1_FDCAN_TURCF  \ offset: 0x110 : The length of the NTU is given by: NTU = CAN clock period x NC/DC. NC is an 18-bit value. Its high part, NCH[17:16] is hard wired to 0b01. Therefore the range of NC extends from 0x10000 to 0x1FFFF. The value configured by NCL is the initial value for FDCAN_TURNA.NAV[15:0]. DC is set to 0x1000 by hardware reset and it may not be written to 0x0000. Level 1: NC 4 * DC and NTU = CAN bit time Levels 0 and 2: NC 8 * DC The actual value of FDCAN_TUR may be changed by the clock drift compensation function of TTCAN level 0 and level 2 in order to adjust the node local view of the NTU to the time master view of the NTU. DC will not be changed by the automatic drift compensation, FDCAN_TURNA.NAV may be adjusted around NC in the range of the synchronization deviation limit given by FDCAN_TTOCF.LDSDL. NC and DC should be programmed to the largest suitable values in achieve the best computational accuracy for the drift compensation process.
$4400e114 constant FDCAN1_FDCAN_TTOCN  \ offset: 0x114 : FDCAN TT operation control register
$4400e118 constant FDCAN1_FDCAN_TTGTP  \ offset: 0x118 : If TTOST.WGDT is set, the next reference message will be transmitted with the Master_Ref_Mark modified by the preset value and with Disc_Bit = 1, presetting the global time in all nodes simultaneously. TP is reset to 0x0000 each time a reference message with Disc_Bit = 1 becomes valid or if the node is not the current time master. TP is locked while FDCAN_TTOST.WGTD = 1 after setting FDCAN_TTOCN.SGT until the reference message with Disc_Bit = 1 becomes valid or until the node is no longer the current time master.
$4400e11c constant FDCAN1_FDCAN_TTTMK  \ offset: 0x11C : A time mark interrupt (FDCAN_TTIR.TMI = 1) is generated when the time base indicated by FDCAN_TTOCN.TMC (cycle time, local time, or global time) has the same value as TM.
$4400e120 constant FDCAN1_FDCAN_TTIR  \ offset: 0x120 : The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register.
$4400e124 constant FDCAN1_FDCAN_TTIE  \ offset: 0x124 : The settings in the TT interrupt enable register determine which status changes in the TT interrupt register will result in an interrupt.
$4400e128 constant FDCAN1_FDCAN_TTILS  \ offset: 0x128 : The TT interrupt Line select register assigns an interrupt generated by a specific interrupt flag from the TT interrupt register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via FDCAN_ILE.EINT0 and FDCAN_ILE.EINT1.
$4400e12c constant FDCAN1_FDCAN_TTOST  \ offset: 0x12C : FDCAN TT operation status register
$4400e130 constant FDCAN1_FDCAN_TURNA  \ offset: 0x130 : There is no drift compensation in TTCAN level 1.
$4400e134 constant FDCAN1_FDCAN_TTLGT  \ offset: 0x134 : FDCAN TT local and global time register
$4400e138 constant FDCAN1_FDCAN_TTCTC  \ offset: 0x138 : FDCAN TT cycle time and count register
$4400e13c constant FDCAN1_FDCAN_TTCPT  \ offset: 0x13C : FDCAN TT capture time register
$4400e140 constant FDCAN1_FDCAN_TTCSM  \ offset: 0x140 : FDCAN TT cycle sync mark register
$4400e300 constant FDCAN1_FDCAN_TTTS  \ offset: 0x300 : The settings in the FDCAN_TTTS register select the input to be used as event trigger and stop watch trigger.

