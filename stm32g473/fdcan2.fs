\
\ @file fdcan2.fs
\ @brief FDCAN2 interrupt 0
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FDCAN Core Release Register
\ Address offset: 0x00
\ Reset value: 0x32141218
\

$000000ff constant FDCAN2_CREL_DAY                                  \ DAY
$0000ff00 constant FDCAN2_CREL_MON                                  \ MON
$000f0000 constant FDCAN2_CREL_YEAR                                 \ YEAR
$00f00000 constant FDCAN2_CREL_SUBSTEP                              \ SUBSTEP
$0f000000 constant FDCAN2_CREL_STEP                                 \ STEP
$f0000000 constant FDCAN2_CREL_REL                                  \ REL


\
\ @brief FDCAN Core Release Register
\ Address offset: 0x04
\ Reset value: 0x87654321
\

$00000000 constant FDCAN2_ENDN_ETV                                  \ ETV


\
\ @brief This register is only writable if bits CCCR.CCE and CCCR.INIT are set. The CAN bit time may be programed in the range of 4 to 25 time quanta. The CAN time quantum may be programmed in the range of 1 to 1024 FDCAN clock periods. tq = (DBRP + 1) FDCAN clock period. DTSEG1 is the sum of Prop_Seg and Phase_Seg1. DTSEG2 is Phase_Seg2. Therefore the length of the bit time is (programmed values) [DTSEG1 + DTSEG2 + 3] tq or (functional values) [Sync_Seg + Prop_Seg + Phase_Seg1 + Phase_Seg2] tq. The Information Processing Time (IPT) is zero, meaning the data for the next bit is available at the first clock edge after the sample point.
\ Address offset: 0x0C
\ Reset value: 0x00000A33
\

$0000000f constant FDCAN2_DBTP_DSJW                                 \ DSJW
$000000f0 constant FDCAN2_DBTP_DTSEG2                               \ DTSEG2
$00001f00 constant FDCAN2_DBTP_DTSEG1                               \ DTSEG1
$001f0000 constant FDCAN2_DBTP_DBRP                                 \ DBRP
$00800000 constant FDCAN2_DBTP_TDC                                  \ TDC


\
\ @brief Write access to the Test Register has to be enabled by setting bit CCCR[TEST] to 1 . All Test Register functions are set to their reset values when bit CCCR[TEST] is reset. Loop Back mode and software control of Tx pin FDCANx_TX are hardware test modes. Programming TX differently from 00 may disturb the message transfer on the CAN bus.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000010 constant FDCAN2_TEST_LBCK                                 \ LBCK
$00000060 constant FDCAN2_TEST_TX                                   \ TX
$00000080 constant FDCAN2_TEST_RX                                   \ RX


\
\ @brief The RAM Watchdog monitors the READY output of the Message RAM. A Message RAM access starts the Message RAM Watchdog Counter with the value configured by the RWD[WDC] bits. The counter is reloaded with RWD[WDC] bits when the Message RAM signals successful completion by activating its READY output. In case there is no response from the Message RAM until the counter has counted down to 0, the counter stops and interrupt flag IR[WDI] bit is set. The RAM Watchdog Counter is clocked by the fdcan_pclk clock.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant FDCAN2_RWD_WDC                                   \ WDC
$0000ff00 constant FDCAN2_RWD_WDV                                   \ WDV


\
\ @brief For details about setting and resetting of single bits see Software initialization.
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant FDCAN2_CCCR_INIT                                 \ INIT
$00000002 constant FDCAN2_CCCR_CCE                                  \ CCE
$00000004 constant FDCAN2_CCCR_ASM                                  \ ASM
$00000008 constant FDCAN2_CCCR_CSA                                  \ CSA
$00000010 constant FDCAN2_CCCR_CSR                                  \ CSR
$00000020 constant FDCAN2_CCCR_MON                                  \ MON
$00000040 constant FDCAN2_CCCR_DAR                                  \ DAR
$00000080 constant FDCAN2_CCCR_TEST                                 \ TEST
$00000100 constant FDCAN2_CCCR_FDOE                                 \ FDOE
$00000200 constant FDCAN2_CCCR_BRSE                                 \ BRSE
$00001000 constant FDCAN2_CCCR_PXHD                                 \ PXHD
$00002000 constant FDCAN2_CCCR_EFBI                                 \ EFBI
$00004000 constant FDCAN2_CCCR_TXP                                  \ TXP
$00008000 constant FDCAN2_CCCR_NISO                                 \ NISO


\
\ @brief FDCAN_NBTP
\ Address offset: 0x1C
\ Reset value: 0x06000A03
\

$0000007f constant FDCAN2_NBTP_NTSEG2                               \ NTSEG2
$0000ff00 constant FDCAN2_NBTP_NTSEG1                               \ NTSEG1
$01ff0000 constant FDCAN2_NBTP_NBRP                                 \ NBRP
$fe000000 constant FDCAN2_NBTP_NSJW                                 \ NSJW


\
\ @brief FDCAN Timestamp Counter Configuration Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant FDCAN2_TSCC_TSS                                  \ TSS
$000f0000 constant FDCAN2_TSCC_TCP                                  \ TCP


\
\ @brief FDCAN Timestamp Counter Value Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN2_TSCV_TSC                                  \ TSC


\
\ @brief FDCAN Timeout Counter Configuration Register
\ Address offset: 0x28
\ Reset value: 0xFFFF0000
\

$00000001 constant FDCAN2_TOCC_ETOC                                 \ ETOC
$00000006 constant FDCAN2_TOCC_TOS                                  \ TOS
$ffff0000 constant FDCAN2_TOCC_TOP                                  \ TOP


\
\ @brief FDCAN Timeout Counter Value Register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant FDCAN2_TOCV_TOC                                  \ TOC


\
\ @brief FDCAN Error Counter Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant FDCAN2_ECR_TEC                                   \ TEC
$00007f00 constant FDCAN2_ECR_REC                                   \ TREC
$00008000 constant FDCAN2_ECR_RP                                    \ RP
$00ff0000 constant FDCAN2_ECR_CEL                                   \ CEL


\
\ @brief FDCAN Protocol Status Register
\ Address offset: 0x44
\ Reset value: 0x00000707
\

$00000007 constant FDCAN2_PSR_LEC                                   \ LEC
$00000018 constant FDCAN2_PSR_ACT                                   \ ACT
$00000020 constant FDCAN2_PSR_EP                                    \ EP
$00000040 constant FDCAN2_PSR_EW                                    \ EW
$00000080 constant FDCAN2_PSR_BO                                    \ BO
$00000700 constant FDCAN2_PSR_DLEC                                  \ DLEC
$00000800 constant FDCAN2_PSR_RESI                                  \ RESI
$00001000 constant FDCAN2_PSR_RBRS                                  \ RBRS
$00002000 constant FDCAN2_PSR_REDL                                  \ REDL
$00004000 constant FDCAN2_PSR_PXE                                   \ PXE
$007f0000 constant FDCAN2_PSR_TDCV                                  \ TDCV


\
\ @brief FDCAN Transmitter Delay Compensation Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant FDCAN2_TDCR_TDCF                                 \ TDCF
$00007f00 constant FDCAN2_TDCR_TDCO                                 \ TDCO


\
\ @brief The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of IE controls whether an interrupt is generated. The configuration of ILS controls on which interrupt line an interrupt is signaled.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant FDCAN2_IR_RF0N                                   \ RF0N
$00000002 constant FDCAN2_IR_RF0F                                   \ RF0F
$00000004 constant FDCAN2_IR_RF0L                                   \ RF0L
$00000008 constant FDCAN2_IR_RF1N                                   \ RF1N
$00000010 constant FDCAN2_IR_RF1F                                   \ RF1F
$00000020 constant FDCAN2_IR_RF1L                                   \ RF1L
$00000040 constant FDCAN2_IR_HPM                                    \ HPM
$00000080 constant FDCAN2_IR_TC                                     \ TC
$00000100 constant FDCAN2_IR_TCF                                    \ TCF
$00000200 constant FDCAN2_IR_TFE                                    \ TFE
$00000400 constant FDCAN2_IR_TEFN                                   \ TEFN
$00000800 constant FDCAN2_IR_TEFF                                   \ TEFF
$00001000 constant FDCAN2_IR_TEFL                                   \ TEFL
$00002000 constant FDCAN2_IR_TSW                                    \ TSW
$00004000 constant FDCAN2_IR_MRAF                                   \ MRAF
$00008000 constant FDCAN2_IR_TOO                                    \ TOO
$00010000 constant FDCAN2_IR_ELO                                    \ ELO
$00020000 constant FDCAN2_IR_EP                                     \ EP
$00040000 constant FDCAN2_IR_EW                                     \ EW
$00080000 constant FDCAN2_IR_BO                                     \ BO
$00100000 constant FDCAN2_IR_WDI                                    \ WDI
$00200000 constant FDCAN2_IR_PEA                                    \ PEA
$00400000 constant FDCAN2_IR_PED                                    \ PED
$00800000 constant FDCAN2_IR_ARA                                    \ ARA


\
\ @brief The settings in the Interrupt Enable register determine which status changes in the Interrupt Register will be signaled on an interrupt line.
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant FDCAN2_IE_RF0NE                                  \ RF0NE
$00000002 constant FDCAN2_IE_RF0FE                                  \ RF0FE
$00000004 constant FDCAN2_IE_RF0LE                                  \ RF0LE
$00000008 constant FDCAN2_IE_RF1NE                                  \ RF1NE
$00000010 constant FDCAN2_IE_RF1FE                                  \ RF1FE
$00000020 constant FDCAN2_IE_RF1LE                                  \ RF1LE
$00000040 constant FDCAN2_IE_HPME                                   \ HPME
$00000080 constant FDCAN2_IE_TCE                                    \ TCE
$00000100 constant FDCAN2_IE_TCFE                                   \ TCFE
$00000200 constant FDCAN2_IE_TFEE                                   \ TFEE
$00000400 constant FDCAN2_IE_TEFNE                                  \ TEFNE
$00000800 constant FDCAN2_IE_TEFFE                                  \ TEFFE
$00001000 constant FDCAN2_IE_TEFLE                                  \ TEFLE
$00002000 constant FDCAN2_IE_TSWE                                   \ TSWE
$00004000 constant FDCAN2_IE_MRAFE                                  \ MRAFE
$00008000 constant FDCAN2_IE_TOOE                                   \ TOOE
$00010000 constant FDCAN2_IE_ELOE                                   \ ELOE
$00020000 constant FDCAN2_IE_EPE                                    \ EPE
$00040000 constant FDCAN2_IE_EWE                                    \ EWE
$00080000 constant FDCAN2_IE_BOE                                    \ BOE
$00100000 constant FDCAN2_IE_WDIE                                   \ WDIE
$00200000 constant FDCAN2_IE_PEAE                                   \ PEAE
$00400000 constant FDCAN2_IE_PEDE                                   \ PEDE
$00800000 constant FDCAN2_IE_ARAE                                   \ ARAE


\
\ @brief The Interrupt Line Select register assigns an interrupt generated by a specific interrupt flag from the Interrupt Register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via ILE[EINT0] and ILE[EINT1].
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant FDCAN2_ILS_RXFIFO0                               \ RxFIFO0
$00000002 constant FDCAN2_ILS_RXFIFO1                               \ RxFIFO1
$00000004 constant FDCAN2_ILS_SMSG                                  \ SMSG
$00000008 constant FDCAN2_ILS_TFERR                                 \ TFERR
$00000010 constant FDCAN2_ILS_MISC                                  \ MISC
$00000020 constant FDCAN2_ILS_BERR                                  \ BERR
$00000040 constant FDCAN2_ILS_PERR                                  \ PERR


\
\ @brief Each of the two interrupt lines to the CPU can be enabled/disabled separately by programming bits EINT0 and EINT1.
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant FDCAN2_ILE_EINT0                                 \ EINT0
$00000002 constant FDCAN2_ILE_EINT1                                 \ EINT1


\
\ @brief Global settings for Message ID filtering. The Global Filter Configuration controls the filter path for standard and extended messages as described in Figure706: Standard Message ID filter path and Figure707: Extended Message ID filter path.
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant FDCAN2_RXGFC_RRFE                                \ RRFE
$00000002 constant FDCAN2_RXGFC_RRFS                                \ RRFS
$0000000c constant FDCAN2_RXGFC_ANFE                                \ ANFE
$00000030 constant FDCAN2_RXGFC_ANFS                                \ ANFS
$00000100 constant FDCAN2_RXGFC_F1OM                                \ F1OM
$00000200 constant FDCAN2_RXGFC_F0OM                                \ F0OM
$001f0000 constant FDCAN2_RXGFC_LSS                                 \ LSS
$0f000000 constant FDCAN2_RXGFC_LSE                                 \ LSE


\
\ @brief FDCAN Extended ID and Mask Register
\ Address offset: 0x84
\ Reset value: 0x1FFFFFFF
\

$1fffffff constant FDCAN2_XIDAM_EIDM                                \ EIDM


\
\ @brief This register is updated every time a Message ID filter element configured to generate a priority event match. This can be used to monitor the status of incoming high priority messages and to enable fast access to these messages.
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_HPMS_BIDX                                 \ BIDX
$000000c0 constant FDCAN2_HPMS_MSI                                  \ MSI
$00001f00 constant FDCAN2_HPMS_FIDX                                 \ FIDX
$00008000 constant FDCAN2_HPMS_FLST                                 \ FLST


\
\ @brief FDCAN Rx FIFO 0 Status Register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000000f constant FDCAN2_RXF0S_F0FL                                \ F0FL
$00000300 constant FDCAN2_RXF0S_F0GI                                \ F0GI
$00030000 constant FDCAN2_RXF0S_F0PI                                \ F0PI
$01000000 constant FDCAN2_RXF0S_F0F                                 \ F0F
$02000000 constant FDCAN2_RXF0S_RF0L                                \ RF0L


\
\ @brief CAN Rx FIFO 0 Acknowledge Register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_RXF0A_F0AI                                \ F0AI


\
\ @brief FDCAN Rx FIFO 1 Status Register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000000f constant FDCAN2_RXF1S_F1FL                                \ F1FL
$00000300 constant FDCAN2_RXF1S_F1GI                                \ F1GI
$00030000 constant FDCAN2_RXF1S_F1PI                                \ F1PI
$01000000 constant FDCAN2_RXF1S_F1F                                 \ F1F
$02000000 constant FDCAN2_RXF1S_RF1L                                \ RF1L


\
\ @brief FDCAN Rx FIFO 1 Acknowledge Register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_RXF1A_F1AI                                \ F1AI


\
\ @brief FDCAN Tx Buffer Configuration Register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$01000000 constant FDCAN2_TXBC_TFQM                                 \ TFQM


\
\ @brief The Tx FIFO/Queue status is related to the pending Tx requests listed in register TXBRP. Therefore the effect of Add/Cancellation requests may be delayed due to a running Tx scan (TXBRP not yet updated).
\ Address offset: 0xC4
\ Reset value: 0x00000003
\

$00000007 constant FDCAN2_TXFQS_TFFL                                \ TFFL
$00000300 constant FDCAN2_TXFQS_TFGI                                \ TFGI
$00030000 constant FDCAN2_TXFQS_TFQPI                               \ TFQPI
$00200000 constant FDCAN2_TXFQS_TFQF                                \ TFQF


\
\ @brief FDCAN Tx Buffer Request Pending Register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_TXBRP_TRP                                 \ TRP


\
\ @brief FDCAN Tx Buffer Add Request Register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_TXBAR_AR                                  \ AR


\
\ @brief FDCAN Tx Buffer Cancellation Request Register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_TXBCR_CR                                  \ CR


\
\ @brief FDCAN Tx Buffer Transmission Occurred Register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_TXBTO_TO                                  \ TO


\
\ @brief FDCAN Tx Buffer Cancellation Finished Register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_TXBCF_CF                                  \ CF


\
\ @brief FDCAN Tx Buffer Transmission Interrupt Enable Register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_TXBTIE_TIE                                \ TIE


\
\ @brief FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_TXBCIE_CFIE                               \ CFIE


\
\ @brief FDCAN Tx Event FIFO Status Register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000007 constant FDCAN2_TXEFS_EFFL                                \ EFFL
$00000300 constant FDCAN2_TXEFS_EFGI                                \ EFGI
$00030000 constant FDCAN2_TXEFS_EFPI                                \ EFPI
$01000000 constant FDCAN2_TXEFS_EFF                                 \ EFF
$02000000 constant FDCAN2_TXEFS_TEFL                                \ TEFL


\
\ @brief FDCAN Tx Event FIFO Acknowledge Register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000003 constant FDCAN2_TXEFA_EFAI                                \ EFAI


\
\ @brief FDCAN CFG clock divider register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000000f constant FDCAN2_CKDIV_PDIV                                \ input clock divider. the APB clock could be divided prior to be used by the CAN sub


\
\ @brief FDCAN2 interrupt 0
\
$40006800 constant FDCAN2_CREL    \ offset: 0x00 : FDCAN Core Release Register
$40006804 constant FDCAN2_ENDN    \ offset: 0x04 : FDCAN Core Release Register
$4000680c constant FDCAN2_DBTP    \ offset: 0x0C : This register is only writable if bits CCCR.CCE and CCCR.INIT are set. The CAN bit time may be programed in the range of 4 to 25 time quanta. The CAN time quantum may be programmed in the range of 1 to 1024 FDCAN clock periods. tq = (DBRP + 1) FDCAN clock period. DTSEG1 is the sum of Prop_Seg and Phase_Seg1. DTSEG2 is Phase_Seg2. Therefore the length of the bit time is (programmed values) [DTSEG1 + DTSEG2 + 3] tq or (functional values) [Sync_Seg + Prop_Seg + Phase_Seg1 + Phase_Seg2] tq. The Information Processing Time (IPT) is zero, meaning the data for the next bit is available at the first clock edge after the sample point.
$40006810 constant FDCAN2_TEST    \ offset: 0x10 : Write access to the Test Register has to be enabled by setting bit CCCR[TEST] to 1 . All Test Register functions are set to their reset values when bit CCCR[TEST] is reset. Loop Back mode and software control of Tx pin FDCANx_TX are hardware test modes. Programming TX differently from 00 may disturb the message transfer on the CAN bus.
$40006814 constant FDCAN2_RWD     \ offset: 0x14 : The RAM Watchdog monitors the READY output of the Message RAM. A Message RAM access starts the Message RAM Watchdog Counter with the value configured by the RWD[WDC] bits. The counter is reloaded with RWD[WDC] bits when the Message RAM signals successful completion by activating its READY output. In case there is no response from the Message RAM until the counter has counted down to 0, the counter stops and interrupt flag IR[WDI] bit is set. The RAM Watchdog Counter is clocked by the fdcan_pclk clock.
$40006818 constant FDCAN2_CCCR    \ offset: 0x18 : For details about setting and resetting of single bits see Software initialization.
$4000681c constant FDCAN2_NBTP    \ offset: 0x1C : FDCAN_NBTP
$40006820 constant FDCAN2_TSCC    \ offset: 0x20 : FDCAN Timestamp Counter Configuration Register
$40006824 constant FDCAN2_TSCV    \ offset: 0x24 : FDCAN Timestamp Counter Value Register
$40006828 constant FDCAN2_TOCC    \ offset: 0x28 : FDCAN Timeout Counter Configuration Register
$4000682c constant FDCAN2_TOCV    \ offset: 0x2C : FDCAN Timeout Counter Value Register
$40006840 constant FDCAN2_ECR     \ offset: 0x40 : FDCAN Error Counter Register
$40006844 constant FDCAN2_PSR     \ offset: 0x44 : FDCAN Protocol Status Register
$40006848 constant FDCAN2_TDCR    \ offset: 0x48 : FDCAN Transmitter Delay Compensation Register
$40006850 constant FDCAN2_IR      \ offset: 0x50 : The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of IE controls whether an interrupt is generated. The configuration of ILS controls on which interrupt line an interrupt is signaled.
$40006854 constant FDCAN2_IE      \ offset: 0x54 : The settings in the Interrupt Enable register determine which status changes in the Interrupt Register will be signaled on an interrupt line.
$40006858 constant FDCAN2_ILS     \ offset: 0x58 : The Interrupt Line Select register assigns an interrupt generated by a specific interrupt flag from the Interrupt Register to one of the two module interrupt lines. For interrupt generation the respective interrupt line has to be enabled via ILE[EINT0] and ILE[EINT1].
$4000685c constant FDCAN2_ILE     \ offset: 0x5C : Each of the two interrupt lines to the CPU can be enabled/disabled separately by programming bits EINT0 and EINT1.
$40006880 constant FDCAN2_RXGFC   \ offset: 0x80 : Global settings for Message ID filtering. The Global Filter Configuration controls the filter path for standard and extended messages as described in Figure706: Standard Message ID filter path and Figure707: Extended Message ID filter path.
$40006884 constant FDCAN2_XIDAM   \ offset: 0x84 : FDCAN Extended ID and Mask Register
$40006888 constant FDCAN2_HPMS    \ offset: 0x88 : This register is updated every time a Message ID filter element configured to generate a priority event match. This can be used to monitor the status of incoming high priority messages and to enable fast access to these messages.
$40006890 constant FDCAN2_RXF0S   \ offset: 0x90 : FDCAN Rx FIFO 0 Status Register
$40006894 constant FDCAN2_RXF0A   \ offset: 0x94 : CAN Rx FIFO 0 Acknowledge Register
$40006898 constant FDCAN2_RXF1S   \ offset: 0x98 : FDCAN Rx FIFO 1 Status Register
$4000689c constant FDCAN2_RXF1A   \ offset: 0x9C : FDCAN Rx FIFO 1 Acknowledge Register
$400068c0 constant FDCAN2_TXBC    \ offset: 0xC0 : FDCAN Tx Buffer Configuration Register
$400068c4 constant FDCAN2_TXFQS   \ offset: 0xC4 : The Tx FIFO/Queue status is related to the pending Tx requests listed in register TXBRP. Therefore the effect of Add/Cancellation requests may be delayed due to a running Tx scan (TXBRP not yet updated).
$400068c8 constant FDCAN2_TXBRP   \ offset: 0xC8 : FDCAN Tx Buffer Request Pending Register
$400068cc constant FDCAN2_TXBAR   \ offset: 0xCC : FDCAN Tx Buffer Add Request Register
$400068d0 constant FDCAN2_TXBCR   \ offset: 0xD0 : FDCAN Tx Buffer Cancellation Request Register
$400068d4 constant FDCAN2_TXBTO   \ offset: 0xD4 : FDCAN Tx Buffer Transmission Occurred Register
$400068d8 constant FDCAN2_TXBCF   \ offset: 0xD8 : FDCAN Tx Buffer Cancellation Finished Register
$400068dc constant FDCAN2_TXBTIE  \ offset: 0xDC : FDCAN Tx Buffer Transmission Interrupt Enable Register
$400068e0 constant FDCAN2_TXBCIE  \ offset: 0xE0 : FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
$400068e4 constant FDCAN2_TXEFS   \ offset: 0xE4 : FDCAN Tx Event FIFO Status Register
$400068e8 constant FDCAN2_TXEFA   \ offset: 0xE8 : FDCAN Tx Event FIFO Acknowledge Register
$40006900 constant FDCAN2_CKDIV   \ offset: 0x100 : FDCAN CFG clock divider register

