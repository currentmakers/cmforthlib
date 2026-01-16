\
\ @file fdcan.fs
\ @brief FDCAN register blank and RAM
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

$000000ff constant FDCAN_FDCAN_CREL_DAY                             \ 18
$0000ff00 constant FDCAN_FDCAN_CREL_MON                             \ 12
$000f0000 constant FDCAN_FDCAN_CREL_YEAR                            \ 4
$00f00000 constant FDCAN_FDCAN_CREL_SUBSTEP                         \ 1
$0f000000 constant FDCAN_FDCAN_CREL_STEP                            \ 2
$f0000000 constant FDCAN_FDCAN_CREL_REL                             \ 3


\
\ @brief FDCAN endian register
\ Address offset: 0x04
\ Reset value: 0x87654321
\

$00000000 constant FDCAN_FDCAN_ENDN_ETV                             \ Endianness test value


\
\ @brief FDCAN data bit timing and prescaler register
\ Address offset: 0x0C
\ Reset value: 0x00000A33
\

$0000000f constant FDCAN_FDCAN_DBTP_DSJW                            \ Synchronization jump width
$000000f0 constant FDCAN_FDCAN_DBTP_DTSEG2                          \ Data time segment after sample point
$00001f00 constant FDCAN_FDCAN_DBTP_DTSEG1                          \ Data time segment before sample point
$001f0000 constant FDCAN_FDCAN_DBTP_DBRP                            \ Data bit rate prescaler
$00800000 constant FDCAN_FDCAN_DBTP_TDC                             \ Transceiver delay compensation


\
\ @brief FDCAN test register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000010 constant FDCAN_FDCAN_TEST_LBCK                            \ Loop back mode
$00000060 constant FDCAN_FDCAN_TEST_TX                              \ Control of transmit pin
$00000080 constant FDCAN_FDCAN_TEST_RX                              \ Receive pin


\
\ @brief FDCAN RAM watchdog register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant FDCAN_FDCAN_RWD_WDC                              \ Watchdog configuration
$0000ff00 constant FDCAN_FDCAN_RWD_WDV                              \ Watchdog value


\
\ @brief FDCAN CC control register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant FDCAN_FDCAN_CCCR_INIT                            \ Initialization
$00000002 constant FDCAN_FDCAN_CCCR_CCE                             \ Configuration change enable
$00000004 constant FDCAN_FDCAN_CCCR_ASM                             \ ASM restricted operation mode
$00000008 constant FDCAN_FDCAN_CCCR_CSA                             \ Clock stop acknowledge
$00000010 constant FDCAN_FDCAN_CCCR_CSR                             \ Clock stop request
$00000020 constant FDCAN_FDCAN_CCCR_MON                             \ Bus monitoring mode
$00000040 constant FDCAN_FDCAN_CCCR_DAR                             \ Disable automatic retransmission
$00000080 constant FDCAN_FDCAN_CCCR_TEST                            \ Test mode enable
$00000100 constant FDCAN_FDCAN_CCCR_FDOE                            \ FD operation enable
$00000200 constant FDCAN_FDCAN_CCCR_BRSE                            \ FDCAN bit rate switching
$00001000 constant FDCAN_FDCAN_CCCR_PXHD                            \ Protocol exception handling disable
$00002000 constant FDCAN_FDCAN_CCCR_EFBI                            \ Edge filtering during bus integration
$00004000 constant FDCAN_FDCAN_CCCR_TXP                             \ If this bit is set, the FDCAN pauses for two CAN bit times before starting the next transmission after successfully transmitting a frame.
$00008000 constant FDCAN_FDCAN_CCCR_NISO                            \ Non ISO operation


\
\ @brief FDCAN nominal bit timing and prescaler register
\ Address offset: 0x1C
\ Reset value: 0x06000A03
\

$0000007f constant FDCAN_FDCAN_NBTP_NTSEG2                          \ Nominal time segment after sample point
$0000ff00 constant FDCAN_FDCAN_NBTP_NTSEG1                          \ Nominal time segment before sample point
$01ff0000 constant FDCAN_FDCAN_NBTP_NBRP                            \ Bit rate prescaler
$fe000000 constant FDCAN_FDCAN_NBTP_NSJW                            \ Nominal (re)synchronization jump width


\
\ @brief FDCAN timestamp counter configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant FDCAN_FDCAN_TSCC_TSS                             \ Timestamp select
$000f0000 constant FDCAN_FDCAN_TSCC_TCP                             \ Timestamp counter prescaler


\
\ @brief FDCAN timestamp counter value register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN_FDCAN_TSCV_TSC                             \ Timestamp counter


\
\ @brief FDCAN timeout counter configuration register
\ Address offset: 0x28
\ Reset value: 0xFFFF0000
\

$00000001 constant FDCAN_FDCAN_TOCC_ETOC                            \ Timeout counter enable
$00000006 constant FDCAN_FDCAN_TOCC_TOS                             \ Timeout select
$ffff0000 constant FDCAN_FDCAN_TOCC_TOP                             \ Timeout period


\
\ @brief FDCAN timeout counter value register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant FDCAN_FDCAN_TOCV_TOC                             \ Timeout counter


\
\ @brief FDCAN error counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant FDCAN_FDCAN_ECR_TEC                              \ Transmit error counter
$00007f00 constant FDCAN_FDCAN_ECR_REC                              \ Receive error counter
$00008000 constant FDCAN_FDCAN_ECR_RP                               \ Receive error passive
$00ff0000 constant FDCAN_FDCAN_ECR_CEL                              \ CAN error logging


\
\ @brief FDCAN protocol status register
\ Address offset: 0x44
\ Reset value: 0x00000707
\

$00000007 constant FDCAN_FDCAN_PSR_LEC                              \ Last error code
$00000018 constant FDCAN_FDCAN_PSR_ACT                              \ Activity
$00000020 constant FDCAN_FDCAN_PSR_EP                               \ Error passive
$00000040 constant FDCAN_FDCAN_PSR_EW                               \ Warning Sstatus
$00000080 constant FDCAN_FDCAN_PSR_BO                               \ Bus_Off status
$00000700 constant FDCAN_FDCAN_PSR_DLEC                             \ Data last error code
$00000800 constant FDCAN_FDCAN_PSR_RESI                             \ ESI flag of last received FDCAN message
$00001000 constant FDCAN_FDCAN_PSR_RBRS                             \ BRS flag of last received FDCAN message
$00002000 constant FDCAN_FDCAN_PSR_REDL                             \ Received FDCAN message
$00004000 constant FDCAN_FDCAN_PSR_PXE                              \ Protocol exception event
$007f0000 constant FDCAN_FDCAN_PSR_TDCV                             \ Transmitter delay compensation value


\
\ @brief FDCAN transmitter delay compensation register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant FDCAN_FDCAN_TDCR_TDCF                            \ Transmitter delay compensation filter window length
$00007f00 constant FDCAN_FDCAN_TDCR_TDCO                            \ Transmitter delay compensation offset


\
\ @brief FDCAN interrupt register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_IR_RF0N                              \ Rx FIFO 0 new message
$00000002 constant FDCAN_FDCAN_IR_RF0F                              \ Rx FIFO 0 full
$00000004 constant FDCAN_FDCAN_IR_RF0L                              \ Rx FIFO 0 message lost
$00000008 constant FDCAN_FDCAN_IR_RF1N                              \ Rx FIFO 1 new message
$00000010 constant FDCAN_FDCAN_IR_RF1F                              \ Rx FIFO 1 full
$00000020 constant FDCAN_FDCAN_IR_RF1L                              \ Rx FIFO 1 message lost
$00000040 constant FDCAN_FDCAN_IR_HPM                               \ High-priority message
$00000080 constant FDCAN_FDCAN_IR_TC                                \ Transmission completed
$00000100 constant FDCAN_FDCAN_IR_TCF                               \ Transmission cancellation finished
$00000200 constant FDCAN_FDCAN_IR_TFE                               \ Tx FIFO empty
$00000400 constant FDCAN_FDCAN_IR_TEFN                              \ Tx event FIFO New Entry
$00000800 constant FDCAN_FDCAN_IR_TEFF                              \ Tx event FIFO full
$00001000 constant FDCAN_FDCAN_IR_TEFL                              \ Tx event FIFO element lost
$00002000 constant FDCAN_FDCAN_IR_TSW                               \ Timestamp wraparound
$00004000 constant FDCAN_FDCAN_IR_MRAF                              \ Message RAM access failure
$00008000 constant FDCAN_FDCAN_IR_TOO                               \ Timeout occurred
$00010000 constant FDCAN_FDCAN_IR_ELO                               \ Error logging overflow
$00020000 constant FDCAN_FDCAN_IR_EP                                \ Error passive
$00040000 constant FDCAN_FDCAN_IR_EW                                \ Warning status
$00080000 constant FDCAN_FDCAN_IR_BO                                \ Bus_Off status
$00100000 constant FDCAN_FDCAN_IR_WDI                               \ Watchdog interrupt
$00200000 constant FDCAN_FDCAN_IR_PEA                               \ Protocol error in arbitration phase (nominal bit time is used)
$00400000 constant FDCAN_FDCAN_IR_PED                               \ Protocol error in data phase (data bit time is used)
$00800000 constant FDCAN_FDCAN_IR_ARA                               \ Access to reserved address


\
\ @brief FDCAN interrupt enable register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_IE_RF0NE                             \ Rx FIFO 0 new message interrupt enable
$00000002 constant FDCAN_FDCAN_IE_RF0FE                             \ Rx FIFO 0 full interrupt enable
$00000004 constant FDCAN_FDCAN_IE_RF0LE                             \ Rx FIFO 0 message lost interrupt enable
$00000008 constant FDCAN_FDCAN_IE_RF1NE                             \ Rx FIFO 1 new message interrupt enable
$00000010 constant FDCAN_FDCAN_IE_RF1FE                             \ Rx FIFO 1 full interrupt enable
$00000020 constant FDCAN_FDCAN_IE_RF1LE                             \ Rx FIFO 1 message lost interrupt enable
$00000040 constant FDCAN_FDCAN_IE_HPME                              \ High-priority message interrupt enable
$00000080 constant FDCAN_FDCAN_IE_TCE                               \ Transmission completed interrupt enable
$00000100 constant FDCAN_FDCAN_IE_TCFE                              \ Transmission cancellation finished interrupt enable
$00000200 constant FDCAN_FDCAN_IE_TFEE                              \ Tx FIFO empty interrupt enable
$00000400 constant FDCAN_FDCAN_IE_TEFNE                             \ Tx event FIFO new entry interrupt enable
$00000800 constant FDCAN_FDCAN_IE_TEFFE                             \ Tx event FIFO full interrupt enable
$00001000 constant FDCAN_FDCAN_IE_TEFLE                             \ Tx event FIFO element lost interrupt enable
$00002000 constant FDCAN_FDCAN_IE_TSWE                              \ Timestamp wraparound interrupt enable
$00004000 constant FDCAN_FDCAN_IE_MRAFE                             \ Message RAM access failure interrupt enable
$00008000 constant FDCAN_FDCAN_IE_TOOE                              \ Timeout occurred interrupt enable
$00010000 constant FDCAN_FDCAN_IE_ELOE                              \ Error logging overflow interrupt enable
$00020000 constant FDCAN_FDCAN_IE_EPE                               \ Error passive interrupt enable
$00040000 constant FDCAN_FDCAN_IE_EWE                               \ Warning status interrupt enable
$00080000 constant FDCAN_FDCAN_IE_BOE                               \ Bus_Off status
$00100000 constant FDCAN_FDCAN_IE_WDIE                              \ Watchdog interrupt enable
$00200000 constant FDCAN_FDCAN_IE_PEAE                              \ Protocol error in arbitration phase enable
$00400000 constant FDCAN_FDCAN_IE_PEDE                              \ Protocol error in data phase enable
$00800000 constant FDCAN_FDCAN_IE_ARAE                              \ Access to reserved address enable


\
\ @brief FDCAN interrupt line select register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_ILS_RXFIFO0                          \ RX FIFO bit grouping the following interruption
$00000002 constant FDCAN_FDCAN_ILS_RXFIFO1                          \ RX FIFO bit grouping the following interruption
$00000004 constant FDCAN_FDCAN_ILS_SMSG                             \ Status message bit grouping the following interruption
$00000008 constant FDCAN_FDCAN_ILS_TFERR                            \ Tx FIFO ERROR grouping the following interruption
$00000010 constant FDCAN_FDCAN_ILS_MISC                             \ Interrupt regrouping the following interruption
$00000020 constant FDCAN_FDCAN_ILS_BERR                             \ Bit and line error grouping the following interruption
$00000040 constant FDCAN_FDCAN_ILS_PERR                             \ Protocol error grouping the following interruption


\
\ @brief FDCAN interrupt line enable register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_ILE_EINT0                            \ Enable interrupt line 0
$00000002 constant FDCAN_FDCAN_ILE_EINT1                            \ Enable interrupt line 1


\
\ @brief FDCAN global filter configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_RXGFC_RRFE                           \ Reject remote frames extended
$00000002 constant FDCAN_FDCAN_RXGFC_RRFS                           \ Reject remote frames standard
$0000000c constant FDCAN_FDCAN_RXGFC_ANFE                           \ Accept non-matching frames extended
$00000030 constant FDCAN_FDCAN_RXGFC_ANFS                           \ Accept Non-matching frames standard
$00000100 constant FDCAN_FDCAN_RXGFC_F1OM                           \ FIFO 1 operation mode (overwrite or blocking)
$00000200 constant FDCAN_FDCAN_RXGFC_F0OM                           \ FIFO 0 operation mode (overwrite or blocking)
$001f0000 constant FDCAN_FDCAN_RXGFC_LSS                            \ List size standard
$0f000000 constant FDCAN_FDCAN_RXGFC_LSE                            \ List size extended


\
\ @brief FDCAN extended ID and mask register
\ Address offset: 0x84
\ Reset value: 0x1FFFFFFF
\

$1fffffff constant FDCAN_FDCAN_XIDAM_EIDM                           \ Extended ID mask


\
\ @brief FDCAN high-priority message status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_HPMS_BIDX                            \ Buffer index
$000000c0 constant FDCAN_FDCAN_HPMS_MSI                             \ Message storage indicator
$00001f00 constant FDCAN_FDCAN_HPMS_FIDX                            \ Filter index
$00008000 constant FDCAN_FDCAN_HPMS_FLST                            \ Filter list


\
\ @brief FDCAN Rx FIFO 0 status register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000000f constant FDCAN_FDCAN_RXF0S_F0FL                           \ Rx FIFO 0 fill level
$00000300 constant FDCAN_FDCAN_RXF0S_F0GI                           \ Rx FIFO 0 get index
$00030000 constant FDCAN_FDCAN_RXF0S_F0PI                           \ Rx FIFO 0 put index
$01000000 constant FDCAN_FDCAN_RXF0S_F0F                            \ Rx FIFO 0 full
$02000000 constant FDCAN_FDCAN_RXF0S_RF0L                           \ Rx FIFO 0 message lost


\
\ @brief CAN Rx FIFO 0 acknowledge register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_RXF0A_F0AI                           \ Rx FIFO 0 acknowledge index


\
\ @brief FDCAN Rx FIFO 1 status register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000000f constant FDCAN_FDCAN_RXF1S_F1FL                           \ Rx FIFO 1 fill level
$00000300 constant FDCAN_FDCAN_RXF1S_F1GI                           \ Rx FIFO 1 get index
$00030000 constant FDCAN_FDCAN_RXF1S_F1PI                           \ Rx FIFO 1 put index
$01000000 constant FDCAN_FDCAN_RXF1S_F1F                            \ Rx FIFO 1 full
$02000000 constant FDCAN_FDCAN_RXF1S_RF1L                           \ Rx FIFO 1 message lost


\
\ @brief FDCAN Rx FIFO 1 acknowledge register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_RXF1A_F1AI                           \ Rx FIFO 1 acknowledge index


\
\ @brief FDCAN Tx buffer configuration register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$01000000 constant FDCAN_FDCAN_TXBC_TFQM                            \ Tx FIFO/queue mode


\
\ @brief FDCAN Tx FIFO/queue status register
\ Address offset: 0xC4
\ Reset value: 0x00000003
\

$00000007 constant FDCAN_FDCAN_TXFQS_TFFL                           \ Tx FIFO free level
$00000300 constant FDCAN_FDCAN_TXFQS_TFGI                           \ Tx FIFO get index
$00030000 constant FDCAN_FDCAN_TXFQS_TFQPI                          \ Tx FIFO/queue put index
$00200000 constant FDCAN_FDCAN_TXFQS_TFQF                           \ Tx FIFO/queue full


\
\ @brief FDCAN Tx buffer request pending register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_TXBRP_TRP                            \ Transmission request pending


\
\ @brief FDCAN Tx buffer add request register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_TXBAR_AR                             \ Add request


\
\ @brief FDCAN Tx buffer cancellation request register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_TXBCR_CR                             \ Cancellation request


\
\ @brief FDCAN Tx buffer transmission occurred register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_TXBTO_TO                             \ Transmission occurred.


\
\ @brief FDCAN Tx buffer cancellation finished register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_TXBCF_CF                             \ Cancellation finished


\
\ @brief FDCAN Tx buffer transmission interrupt enable register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_TXBTIE_TIE                           \ Transmission interrupt enable


\
\ @brief FDCAN Tx buffer cancellation finished interrupt enable register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_TXBCIE_CFIE                          \ Cancellation finished interrupt enable.


\
\ @brief FDCAN Tx event FIFO status register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_TXEFS_EFFL                           \ Event FIFO fill level
$00000300 constant FDCAN_FDCAN_TXEFS_EFGI                           \ Event FIFO get index
$00030000 constant FDCAN_FDCAN_TXEFS_EFPI                           \ Event FIFO put index
$01000000 constant FDCAN_FDCAN_TXEFS_EFF                            \ Event FIFO full
$02000000 constant FDCAN_FDCAN_TXEFS_TEFL                           \ Tx event FIFO element lost


\
\ @brief FDCAN Tx event FIFO acknowledge register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000003 constant FDCAN_FDCAN_TXEFA_EFAI                           \ Event FIFO acknowledge index


\
\ @brief FDCAN CFG clock divider register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000000f constant FDCAN_FDCAN_CKDIV_PDIV                           \ input clock divider


\
\ @brief FDCAN register blank and RAM
\
$4000a400 constant FDCAN_FDCAN_CREL  \ offset: 0x00 : FDCAN core release register
$4000a404 constant FDCAN_FDCAN_ENDN  \ offset: 0x04 : FDCAN endian register
$4000a40c constant FDCAN_FDCAN_DBTP  \ offset: 0x0C : FDCAN data bit timing and prescaler register
$4000a410 constant FDCAN_FDCAN_TEST  \ offset: 0x10 : FDCAN test register
$4000a414 constant FDCAN_FDCAN_RWD  \ offset: 0x14 : FDCAN RAM watchdog register
$4000a418 constant FDCAN_FDCAN_CCCR  \ offset: 0x18 : FDCAN CC control register
$4000a41c constant FDCAN_FDCAN_NBTP  \ offset: 0x1C : FDCAN nominal bit timing and prescaler register
$4000a420 constant FDCAN_FDCAN_TSCC  \ offset: 0x20 : FDCAN timestamp counter configuration register
$4000a424 constant FDCAN_FDCAN_TSCV  \ offset: 0x24 : FDCAN timestamp counter value register
$4000a428 constant FDCAN_FDCAN_TOCC  \ offset: 0x28 : FDCAN timeout counter configuration register
$4000a42c constant FDCAN_FDCAN_TOCV  \ offset: 0x2C : FDCAN timeout counter value register
$4000a440 constant FDCAN_FDCAN_ECR  \ offset: 0x40 : FDCAN error counter register
$4000a444 constant FDCAN_FDCAN_PSR  \ offset: 0x44 : FDCAN protocol status register
$4000a448 constant FDCAN_FDCAN_TDCR  \ offset: 0x48 : FDCAN transmitter delay compensation register
$4000a450 constant FDCAN_FDCAN_IR  \ offset: 0x50 : FDCAN interrupt register
$4000a454 constant FDCAN_FDCAN_IE  \ offset: 0x54 : FDCAN interrupt enable register
$4000a458 constant FDCAN_FDCAN_ILS  \ offset: 0x58 : FDCAN interrupt line select register
$4000a45c constant FDCAN_FDCAN_ILE  \ offset: 0x5C : FDCAN interrupt line enable register
$4000a480 constant FDCAN_FDCAN_RXGFC  \ offset: 0x80 : FDCAN global filter configuration register
$4000a484 constant FDCAN_FDCAN_XIDAM  \ offset: 0x84 : FDCAN extended ID and mask register
$4000a488 constant FDCAN_FDCAN_HPMS  \ offset: 0x88 : FDCAN high-priority message status register
$4000a490 constant FDCAN_FDCAN_RXF0S  \ offset: 0x90 : FDCAN Rx FIFO 0 status register
$4000a494 constant FDCAN_FDCAN_RXF0A  \ offset: 0x94 : CAN Rx FIFO 0 acknowledge register
$4000a498 constant FDCAN_FDCAN_RXF1S  \ offset: 0x98 : FDCAN Rx FIFO 1 status register
$4000a49c constant FDCAN_FDCAN_RXF1A  \ offset: 0x9C : FDCAN Rx FIFO 1 acknowledge register
$4000a4c0 constant FDCAN_FDCAN_TXBC  \ offset: 0xC0 : FDCAN Tx buffer configuration register
$4000a4c4 constant FDCAN_FDCAN_TXFQS  \ offset: 0xC4 : FDCAN Tx FIFO/queue status register
$4000a4c8 constant FDCAN_FDCAN_TXBRP  \ offset: 0xC8 : FDCAN Tx buffer request pending register
$4000a4cc constant FDCAN_FDCAN_TXBAR  \ offset: 0xCC : FDCAN Tx buffer add request register
$4000a4d0 constant FDCAN_FDCAN_TXBCR  \ offset: 0xD0 : FDCAN Tx buffer cancellation request register
$4000a4d4 constant FDCAN_FDCAN_TXBTO  \ offset: 0xD4 : FDCAN Tx buffer transmission occurred register
$4000a4d8 constant FDCAN_FDCAN_TXBCF  \ offset: 0xD8 : FDCAN Tx buffer cancellation finished register
$4000a4dc constant FDCAN_FDCAN_TXBTIE  \ offset: 0xDC : FDCAN Tx buffer transmission interrupt enable register
$4000a4e0 constant FDCAN_FDCAN_TXBCIE  \ offset: 0xE0 : FDCAN Tx buffer cancellation finished interrupt enable register
$4000a4e4 constant FDCAN_FDCAN_TXEFS  \ offset: 0xE4 : FDCAN Tx event FIFO status register
$4000a4e8 constant FDCAN_FDCAN_TXEFA  \ offset: 0xE8 : FDCAN Tx event FIFO acknowledge register
$4000a500 constant FDCAN_FDCAN_CKDIV  \ offset: 0x100 : FDCAN CFG clock divider register

