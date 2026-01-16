\
\ @file fdcan1.fs
\ @brief FDCAN1
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

$000000ff constant FDCAN1_FDCAN_CREL_DAY                            \ Timestamp Day
$0000ff00 constant FDCAN1_FDCAN_CREL_MON                            \ Timestamp Month
$000f0000 constant FDCAN1_FDCAN_CREL_YEAR                           \ Timestamp Year
$00f00000 constant FDCAN1_FDCAN_CREL_SUBSTEP                        \ Sub-step of Core release
$0f000000 constant FDCAN1_FDCAN_CREL_STEP                           \ Step of Core release
$f0000000 constant FDCAN1_FDCAN_CREL_REL                            \ Core release


\
\ @brief FDCAN Core Release Register
\ Address offset: 0x04
\ Reset value: 0x87654321
\

$00000000 constant FDCAN1_FDCAN_ENDN_ETV                            \ Endiannes Test Value


\
\ @brief FDCAN Data Bit Timing and Prescaler Register
\ Address offset: 0x0C
\ Reset value: 0x00000A33
\

$0000000f constant FDCAN1_FDCAN_DBTP_DSJW                           \ Synchronization Jump Width
$000000f0 constant FDCAN1_FDCAN_DBTP_DTSEG2                         \ Data time segment after sample point
$00001f00 constant FDCAN1_FDCAN_DBTP_DTSEG1                         \ Data time segment after sample point
$001f0000 constant FDCAN1_FDCAN_DBTP_DBRP                           \ Data BIt Rate Prescaler
$00800000 constant FDCAN1_FDCAN_DBTP_TDC                            \ Transceiver Delay Compensation


\
\ @brief FDCAN Test Register
\ Address offset: 0x10
\ Reset value: 0x00000010
\

$00000010 constant FDCAN1_FDCAN_TEST_LBCK                           \ Loop Back mode
$00000060 constant FDCAN1_FDCAN_TEST_TX                             \ Loop Back mode
$00000080 constant FDCAN1_FDCAN_TEST_RX                             \ Control of Transmit Pin


\
\ @brief FDCAN RAM Watchdog Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant FDCAN1_FDCAN_RWD_WDC                             \ Watchdog configuration
$0000ff00 constant FDCAN1_FDCAN_RWD_WDV                             \ Watchdog value


\
\ @brief FDCAN CC Control Register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant FDCAN1_FDCAN_CCCR_INIT                           \ Initialization
$00000002 constant FDCAN1_FDCAN_CCCR_CCE                            \ Configuration Change Enable
$00000004 constant FDCAN1_FDCAN_CCCR_ASM                            \ ASM Restricted Operation Mode
$00000008 constant FDCAN1_FDCAN_CCCR_CSA                            \ Clock Stop Acknowledge
$00000010 constant FDCAN1_FDCAN_CCCR_CSR                            \ Clock Stop Request
$00000020 constant FDCAN1_FDCAN_CCCR_MON                            \ Bus Monitoring Mode
$00000040 constant FDCAN1_FDCAN_CCCR_DAR                            \ Disable Automatic Retransmission
$00000080 constant FDCAN1_FDCAN_CCCR_TEST                           \ Test Mode Enable
$00000100 constant FDCAN1_FDCAN_CCCR_FDOE                           \ FD Operation Enable
$00000200 constant FDCAN1_FDCAN_CCCR_BSE                            \ FDCAN Bit Rate Switching
$00001000 constant FDCAN1_FDCAN_CCCR_PXHD                           \ Protocol Exception Handling Disable
$00002000 constant FDCAN1_FDCAN_CCCR_EFBI                           \ Edge Filtering during Bus Integration
$00004000 constant FDCAN1_FDCAN_CCCR_TXP                            \ TXP
$00008000 constant FDCAN1_FDCAN_CCCR_NISO                           \ Non ISO Operation


\
\ @brief FDCAN Nominal Bit Timing and Prescaler Register
\ Address offset: 0x1C
\ Reset value: 0x06000A03
\

$0000007f constant FDCAN1_FDCAN_NBTP_TSEG2                          \ Nominal Time segment after sample point
$0000ff00 constant FDCAN1_FDCAN_NBTP_NTSEG1                         \ Nominal Time segment before sample point
$01ff0000 constant FDCAN1_FDCAN_NBTP_NBRP                           \ Bit Rate Prescaler
$fe000000 constant FDCAN1_FDCAN_NBTP_NSJW                           \ NSJW: Nominal (Re)Synchronization Jump Width


\
\ @brief FDCAN Timestamp Counter Configuration Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant FDCAN1_FDCAN_TSCC_TSS                            \ Timestamp Select
$000f0000 constant FDCAN1_FDCAN_TSCC_TCP                            \ Timestamp Counter Prescaler


\
\ @brief FDCAN Timestamp Counter Value Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN1_FDCAN_TSCV_TSC                            \ Timestamp Counter


\
\ @brief FDCAN Timeout Counter Configuration Register
\ Address offset: 0x28
\ Reset value: 0xFFFF0000
\

$00000001 constant FDCAN1_FDCAN_TOCC_ETOC                           \ Enable Timeout Counter
$00000006 constant FDCAN1_FDCAN_TOCC_TOS                            \ Timeout Select
$ffff0000 constant FDCAN1_FDCAN_TOCC_TOP                            \ Timeout Period


\
\ @brief FDCAN Timeout Counter Value Register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant FDCAN1_FDCAN_TOCV_TOC                            \ Timeout Counter


\
\ @brief FDCAN Error Counter Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant FDCAN1_FDCAN_ECR_TEC                             \ Transmit Error Counter
$00007f00 constant FDCAN1_FDCAN_ECR_REC                             \ Receive Error Counter
$00008000 constant FDCAN1_FDCAN_ECR_RP                              \ Receive Error Passive
$00ff0000 constant FDCAN1_FDCAN_ECR_CEL                             \ AN Error Logging


\
\ @brief FDCAN Protocol Status Register
\ Address offset: 0x44
\ Reset value: 0x00000707
\

$00000007 constant FDCAN1_FDCAN_PSR_LEC                             \ Last Error Code
$00000018 constant FDCAN1_FDCAN_PSR_ACT                             \ Activity
$00000020 constant FDCAN1_FDCAN_PSR_EP                              \ Error Passive
$00000040 constant FDCAN1_FDCAN_PSR_EW                              \ Warning Status
$00000080 constant FDCAN1_FDCAN_PSR_BO                              \ Bus_Off Status
$00000700 constant FDCAN1_FDCAN_PSR_DLEC                            \ Data Last Error Code
$00000800 constant FDCAN1_FDCAN_PSR_RESI                            \ ESI flag of last received FDCAN Message
$00001000 constant FDCAN1_FDCAN_PSR_RBRS                            \ BRS flag of last received FDCAN Message
$00002000 constant FDCAN1_FDCAN_PSR_REDL                            \ Received FDCAN Message
$00004000 constant FDCAN1_FDCAN_PSR_PXE                             \ Protocol Exception Event
$007f0000 constant FDCAN1_FDCAN_PSR_TDCV                            \ Transmitter Delay Compensation Value


\
\ @brief FDCAN Transmitter Delay Compensation Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant FDCAN1_FDCAN_TDCR_TDCF                           \ Transmitter Delay Compensation Filter Window Length
$00007f00 constant FDCAN1_FDCAN_TDCR_TDCO                           \ Transmitter Delay Compensation Offset


\
\ @brief FDCAN Interrupt Register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_IR_RF0N                             \ RF0N
$00000002 constant FDCAN1_FDCAN_IR_RF0F                             \ RF0F
$00000004 constant FDCAN1_FDCAN_IR_RF0L                             \ RF0L
$00000008 constant FDCAN1_FDCAN_IR_RF1N                             \ RF1N
$00000010 constant FDCAN1_FDCAN_IR_RF1F                             \ RF1F
$00000020 constant FDCAN1_FDCAN_IR_RF1L                             \ RF1L
$00000040 constant FDCAN1_FDCAN_IR_HPM                              \ HPM
$00000080 constant FDCAN1_FDCAN_IR_TC                               \ TC
$00000100 constant FDCAN1_FDCAN_IR_TCF                              \ TCF
$00000200 constant FDCAN1_FDCAN_IR_TFE                              \ TFE
$00000400 constant FDCAN1_FDCAN_IR_TEFN                             \ TEFN
$00000800 constant FDCAN1_FDCAN_IR_TEFF                             \ TEFF
$00001000 constant FDCAN1_FDCAN_IR_TEFL                             \ TEFL
$00002000 constant FDCAN1_FDCAN_IR_TSW                              \ TSW
$00004000 constant FDCAN1_FDCAN_IR_MRAF                             \ MRAF
$00008000 constant FDCAN1_FDCAN_IR_TOO                              \ TOO
$00010000 constant FDCAN1_FDCAN_IR_ELO                              \ ELO
$00020000 constant FDCAN1_FDCAN_IR_EP                               \ EP
$00040000 constant FDCAN1_FDCAN_IR_EW                               \ EW
$00080000 constant FDCAN1_FDCAN_IR_BO                               \ BO
$00100000 constant FDCAN1_FDCAN_IR_WDI                              \ WDI
$00200000 constant FDCAN1_FDCAN_IR_PEA                              \ PEA
$00400000 constant FDCAN1_FDCAN_IR_PED                              \ PED
$00800000 constant FDCAN1_FDCAN_IR_ARA                              \ ARA


\
\ @brief FDCAN Interrupt Enable Register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_IE_RF0NE                            \ Rx FIFO 0 New Message Enable
$00000002 constant FDCAN1_FDCAN_IE_RF0FE                            \ Rx FIFO 0 Full Enable
$00000004 constant FDCAN1_FDCAN_IE_RF0LE                            \ Rx FIFO 0 Message Lost Enable
$00000008 constant FDCAN1_FDCAN_IE_RF1NE                            \ Rx FIFO 1 New Message Enable
$00000010 constant FDCAN1_FDCAN_IE_RF1FE                            \ Rx FIFO 1 Watermark Reached Enable
$00000020 constant FDCAN1_FDCAN_IE_RF1LE                            \ Rx FIFO 1 Message Lost Enable
$00000040 constant FDCAN1_FDCAN_IE_HPME                             \ High Priority Message Enable
$00000080 constant FDCAN1_FDCAN_IE_TCE                              \ Transmission Completed Enable
$00000100 constant FDCAN1_FDCAN_IE_TCFE                             \ Transmission Cancellation Finished Enable
$00000200 constant FDCAN1_FDCAN_IE_TEFE                             \ Tx FIFO Empty Enable
$00000400 constant FDCAN1_FDCAN_IE_TEFNE                            \ Tx Event FIFO New Entry Enable
$00000800 constant FDCAN1_FDCAN_IE_TEFFE                            \ Tx Event FIFO Full Enable
$00001000 constant FDCAN1_FDCAN_IE_TEFLE                            \ Tx Event FIFO Element Lost Enable
$00002000 constant FDCAN1_FDCAN_IE_MRAFE                            \ Message RAM Access Failure Enable
$00004000 constant FDCAN1_FDCAN_IE_TOOE                             \ Timeout Occurred Enable
$00008000 constant FDCAN1_FDCAN_IE_ELOE                             \ Error Logging Overflow Enable
$00010000 constant FDCAN1_FDCAN_IE_EPE                              \ Error Passive Enable
$00020000 constant FDCAN1_FDCAN_IE_EWE                              \ Warning Status Enable
$00040000 constant FDCAN1_FDCAN_IE_BOE                              \ Bus_Off Status Enable
$00080000 constant FDCAN1_FDCAN_IE_WDIE                             \ Watchdog Interrupt Enable
$00100000 constant FDCAN1_FDCAN_IE_PEAE                             \ Protocol Error in Arbitration Phase Enable
$00200000 constant FDCAN1_FDCAN_IE_PEDE                             \ Protocol Error in Data Phase Enable
$00400000 constant FDCAN1_FDCAN_IE_ARAE                             \ Access to Reserved Address Enable


\
\ @brief FDCAN Interrupt Line Select Register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_ILS_RXFIFO0                         \ RxFIFO0
$00000002 constant FDCAN1_FDCAN_ILS_RXFIFO1                         \ RxFIFO1
$00000004 constant FDCAN1_FDCAN_ILS_SMSG                            \ SMSG
$00000008 constant FDCAN1_FDCAN_ILS_TFERR                           \ TFERR
$00000010 constant FDCAN1_FDCAN_ILS_MISC                            \ MISC
$00000020 constant FDCAN1_FDCAN_ILS_BERR                            \ BERR
$00000040 constant FDCAN1_FDCAN_ILS_PERR                            \ PERR


\
\ @brief FDCAN Interrupt Line Enable Register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_ILE_EINT0                           \ Enable Interrupt Line 0
$00000002 constant FDCAN1_FDCAN_ILE_EINT1                           \ Enable Interrupt Line 1


\
\ @brief FDCAN Global Filter Configuration Register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant FDCAN1_FDCAN_RXGFC_RRFE                          \ Reject Remote Frames Extended
$00000002 constant FDCAN1_FDCAN_RXGFC_RRFS                          \ Reject Remote Frames Standard
$0000000c constant FDCAN1_FDCAN_RXGFC_ANFE                          \ Accept Non-matching Frames Extended
$00000030 constant FDCAN1_FDCAN_RXGFC_ANFS                          \ Accept Non-matching Frames Standard
$00000100 constant FDCAN1_FDCAN_RXGFC_F1OM                          \ F1OM
$00000200 constant FDCAN1_FDCAN_RXGFC_F0OM                          \ F0OM
$001f0000 constant FDCAN1_FDCAN_RXGFC_LSS                           \ LSS
$0f000000 constant FDCAN1_FDCAN_RXGFC_LSE                           \ LSE


\
\ @brief FDCAN Extended ID and Mask Register
\ Address offset: 0x84
\ Reset value: 0x1FFFFFFF
\

$1fffffff constant FDCAN1_FDCAN_XIDAM_EIDM                          \ Extended ID Mask


\
\ @brief FDCAN High Priority Message Status Register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_HPMS_BIDX                           \ Buffer Index
$000000c0 constant FDCAN1_FDCAN_HPMS_MSI                            \ Message Storage Indicator
$00001f00 constant FDCAN1_FDCAN_HPMS_FIDX                           \ Filter Index
$00008000 constant FDCAN1_FDCAN_HPMS_FLST                           \ Filter List


\
\ @brief FDCAN Rx FIFO 0 Status Register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000000f constant FDCAN1_FDCAN_RXF0S_F0FL                          \ Rx FIFO 0 Fill Level
$00000300 constant FDCAN1_FDCAN_RXF0S_F0GI                          \ Rx FIFO 0 Get Index
$00030000 constant FDCAN1_FDCAN_RXF0S_F0PI                          \ Rx FIFO 0 Put Index
$01000000 constant FDCAN1_FDCAN_RXF0S_F0F                           \ Rx FIFO 0 Full
$02000000 constant FDCAN1_FDCAN_RXF0S_RF0L                          \ Rx FIFO 0 Message Lost


\
\ @brief CAN Rx FIFO 0 Acknowledge Register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_RXF0A_F0AI                          \ Rx FIFO 0 Acknowledge Index


\
\ @brief FDCAN Rx FIFO 1 Status Register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000000f constant FDCAN1_FDCAN_RXF1S_F1FL                          \ Rx FIFO 1 Fill Level
$00000300 constant FDCAN1_FDCAN_RXF1S_F1GI                          \ Rx FIFO 1 Get Index
$00030000 constant FDCAN1_FDCAN_RXF1S_F1PI                          \ Rx FIFO 1 Put Index
$01000000 constant FDCAN1_FDCAN_RXF1S_F1F                           \ Rx FIFO 1 Full
$02000000 constant FDCAN1_FDCAN_RXF1S_RF1L                          \ Rx FIFO 1 Message Lost


\
\ @brief FDCAN Rx FIFO 1 Acknowledge Register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_RXF1A_F1AI                          \ Rx FIFO 1 Acknowledge Index


\
\ @brief FDCAN Tx buffer configuration register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$01000000 constant FDCAN1_FDCAN_TXBC_TFQM                           \ Tx FIFO/Queue Mode


\
\ @brief FDCAN Tx FIFO/Queue Status Register
\ Address offset: 0xC4
\ Reset value: 0x00000003
\

$00000007 constant FDCAN1_FDCAN_TXFQS_TFFL                          \ Tx FIFO Free Level
$00000300 constant FDCAN1_FDCAN_TXFQS_TFGI                          \ TFGI
$00030000 constant FDCAN1_FDCAN_TXFQS_TFQPI                         \ Tx FIFO/Queue Put Index
$00200000 constant FDCAN1_FDCAN_TXFQS_TFQF                          \ Tx FIFO/Queue Full


\
\ @brief FDCAN Tx Buffer Request Pending Register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_TXBRP_TRP                           \ Transmission Request Pending


\
\ @brief FDCAN Tx Buffer Add Request Register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_TXBAR_AR                            \ Add Request


\
\ @brief FDCAN Tx Buffer Cancellation Request Register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_TXBCR_CR                            \ Cancellation Request


\
\ @brief FDCAN Tx Buffer Transmission Occurred Register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_TXBTO_TO                            \ Transmission Occurred.


\
\ @brief FDCAN Tx Buffer Cancellation Finished Register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_TXBCF_CF                            \ Cancellation Finished


\
\ @brief FDCAN Tx Buffer Transmission Interrupt Enable Register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_TXBTIE_TIE                          \ Transmission Interrupt Enable


\
\ @brief FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_TXBCIE_CF                           \ Cancellation Finished Interrupt Enable


\
\ @brief FDCAN Tx Event FIFO Status Register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000007 constant FDCAN1_FDCAN_TXEFS_EFFL                          \ Event FIFO Fill Level
$00000300 constant FDCAN1_FDCAN_TXEFS_EFGI                          \ Event FIFO Get Index.
$00030000 constant FDCAN1_FDCAN_TXEFS_EFPI                          \ Event FIFO Put Index
$01000000 constant FDCAN1_FDCAN_TXEFS_EFF                           \ Event FIFO Full.
$02000000 constant FDCAN1_FDCAN_TXEFS_TEFL                          \ Tx Event FIFO Element Lost.


\
\ @brief FDCAN Tx Event FIFO Acknowledge Register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000003 constant FDCAN1_FDCAN_TXEFA_EFAI                          \ Event FIFO Acknowledge Index


\
\ @brief FDCAN TT Trigger Memory Configuration Register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000000f constant FDCAN1_FDCAN_CKDIV_PDIV                          \ PDIV


\
\ @brief FDCAN1
\
$4000a400 constant FDCAN1_FDCAN_CREL  \ offset: 0x00 : FDCAN Core Release Register
$4000a404 constant FDCAN1_FDCAN_ENDN  \ offset: 0x04 : FDCAN Core Release Register
$4000a40c constant FDCAN1_FDCAN_DBTP  \ offset: 0x0C : FDCAN Data Bit Timing and Prescaler Register
$4000a410 constant FDCAN1_FDCAN_TEST  \ offset: 0x10 : FDCAN Test Register
$4000a414 constant FDCAN1_FDCAN_RWD  \ offset: 0x14 : FDCAN RAM Watchdog Register
$4000a418 constant FDCAN1_FDCAN_CCCR  \ offset: 0x18 : FDCAN CC Control Register
$4000a41c constant FDCAN1_FDCAN_NBTP  \ offset: 0x1C : FDCAN Nominal Bit Timing and Prescaler Register
$4000a420 constant FDCAN1_FDCAN_TSCC  \ offset: 0x20 : FDCAN Timestamp Counter Configuration Register
$4000a424 constant FDCAN1_FDCAN_TSCV  \ offset: 0x24 : FDCAN Timestamp Counter Value Register
$4000a428 constant FDCAN1_FDCAN_TOCC  \ offset: 0x28 : FDCAN Timeout Counter Configuration Register
$4000a42c constant FDCAN1_FDCAN_TOCV  \ offset: 0x2C : FDCAN Timeout Counter Value Register
$4000a440 constant FDCAN1_FDCAN_ECR  \ offset: 0x40 : FDCAN Error Counter Register
$4000a444 constant FDCAN1_FDCAN_PSR  \ offset: 0x44 : FDCAN Protocol Status Register
$4000a448 constant FDCAN1_FDCAN_TDCR  \ offset: 0x48 : FDCAN Transmitter Delay Compensation Register
$4000a450 constant FDCAN1_FDCAN_IR  \ offset: 0x50 : FDCAN Interrupt Register
$4000a454 constant FDCAN1_FDCAN_IE  \ offset: 0x54 : FDCAN Interrupt Enable Register
$4000a458 constant FDCAN1_FDCAN_ILS  \ offset: 0x58 : FDCAN Interrupt Line Select Register
$4000a45c constant FDCAN1_FDCAN_ILE  \ offset: 0x5C : FDCAN Interrupt Line Enable Register
$4000a480 constant FDCAN1_FDCAN_RXGFC  \ offset: 0x80 : FDCAN Global Filter Configuration Register
$4000a484 constant FDCAN1_FDCAN_XIDAM  \ offset: 0x84 : FDCAN Extended ID and Mask Register
$4000a488 constant FDCAN1_FDCAN_HPMS  \ offset: 0x88 : FDCAN High Priority Message Status Register
$4000a490 constant FDCAN1_FDCAN_RXF0S  \ offset: 0x90 : FDCAN Rx FIFO 0 Status Register
$4000a494 constant FDCAN1_FDCAN_RXF0A  \ offset: 0x94 : CAN Rx FIFO 0 Acknowledge Register
$4000a498 constant FDCAN1_FDCAN_RXF1S  \ offset: 0x98 : FDCAN Rx FIFO 1 Status Register
$4000a49c constant FDCAN1_FDCAN_RXF1A  \ offset: 0x9C : FDCAN Rx FIFO 1 Acknowledge Register
$4000a4c0 constant FDCAN1_FDCAN_TXBC  \ offset: 0xC0 : FDCAN Tx buffer configuration register
$4000a4c4 constant FDCAN1_FDCAN_TXFQS  \ offset: 0xC4 : FDCAN Tx FIFO/Queue Status Register
$4000a4c8 constant FDCAN1_FDCAN_TXBRP  \ offset: 0xC8 : FDCAN Tx Buffer Request Pending Register
$4000a4cc constant FDCAN1_FDCAN_TXBAR  \ offset: 0xCC : FDCAN Tx Buffer Add Request Register
$4000a4d0 constant FDCAN1_FDCAN_TXBCR  \ offset: 0xD0 : FDCAN Tx Buffer Cancellation Request Register
$4000a4d4 constant FDCAN1_FDCAN_TXBTO  \ offset: 0xD4 : FDCAN Tx Buffer Transmission Occurred Register
$4000a4d8 constant FDCAN1_FDCAN_TXBCF  \ offset: 0xD8 : FDCAN Tx Buffer Cancellation Finished Register
$4000a4dc constant FDCAN1_FDCAN_TXBTIE  \ offset: 0xDC : FDCAN Tx Buffer Transmission Interrupt Enable Register
$4000a4e0 constant FDCAN1_FDCAN_TXBCIE  \ offset: 0xE0 : FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
$4000a4e4 constant FDCAN1_FDCAN_TXEFS  \ offset: 0xE4 : FDCAN Tx Event FIFO Status Register
$4000a4e8 constant FDCAN1_FDCAN_TXEFA  \ offset: 0xE8 : FDCAN Tx Event FIFO Acknowledge Register
$4000a500 constant FDCAN1_FDCAN_CKDIV  \ offset: 0x100 : FDCAN TT Trigger Memory Configuration Register

