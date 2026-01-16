\
\ @file fdcan3_s.fs
\ @brief FDCAN register block
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

$000000ff constant FDCAN3_S_FDCAN_CREL_DAY                          \ Timestamp day =18
$0000ff00 constant FDCAN3_S_FDCAN_CREL_MON                          \ Timestamp month = 12
$000f0000 constant FDCAN3_S_FDCAN_CREL_YEAR                         \ Timestamp year = 4
$00f00000 constant FDCAN3_S_FDCAN_CREL_SUBSTEP                      \ Sub-step of core release = 1
$0f000000 constant FDCAN3_S_FDCAN_CREL_STEP                         \ Step of core release = 2
$f0000000 constant FDCAN3_S_FDCAN_CREL_REL                          \ Core release = 3


\
\ @brief FDCAN core release register
\ Address offset: 0x00
\ Reset value: 0x32141218
\

$000000ff constant FDCAN3_S_FDCAN_CCU_CREL_DAY                      \ Timestamp day = 18
$0000ff00 constant FDCAN3_S_FDCAN_CCU_CREL_MON                      \ Timestamp month = 12
$000f0000 constant FDCAN3_S_FDCAN_CCU_CREL_YEAR                     \ Timestamp year =
$00f00000 constant FDCAN3_S_FDCAN_CCU_CREL_SUBSTEP                  \ Sub-step of core release = 1
$0f000000 constant FDCAN3_S_FDCAN_CCU_CREL_STEP                     \ Step of core release = 1
$f0000000 constant FDCAN3_S_FDCAN_CCU_CREL_REL                      \ Core release = 1


\
\ @brief FDCAN Endian register
\ Address offset: 0x04
\ Reset value: 0x87654321
\

$00000000 constant FDCAN3_S_FDCAN_ENDN_ETV                          \ Endiannes Test value


\
\ @brief FDCAN Endian register
\ Address offset: 0x04
\ Reset value: 0x87654321
\

$0000001f constant FDCAN3_S_FDCAN_CCU_CCFG_TQBT                     \ Time quanta per bit time
$00000040 constant FDCAN3_S_FDCAN_CCU_CCFG_BCC                      \ Bypass clock calibration
$00000080 constant FDCAN3_S_FDCAN_CCU_CCFG_CFL                      \ Calibration field length
$0000ff00 constant FDCAN3_S_FDCAN_CCU_CCFG_OCPM                     \ Oscillator clock periods minimum
$000f0000 constant FDCAN3_S_FDCAN_CCU_CCFG_CDIV                     \ Clock divider
$80000000 constant FDCAN3_S_FDCAN_CCU_CCFG_SWR                      \ Software reset


\
\ @brief Calibration status register
\ Address offset: 0x08
\ Reset value: 0x0203FFFF
\

$0003ffff constant FDCAN3_S_FDCAN_CCU_CSTAT_OCPC                    \ Oscillator clock period counter
$1ffc0000 constant FDCAN3_S_FDCAN_CCU_CSTAT_TQC                     \ Time quanta counter
$c0000000 constant FDCAN3_S_FDCAN_CCU_CSTAT_CALS                    \ Calibration state


\
\ @brief FDCAN data bit timing and prescaler register
\ Address offset: 0x0C
\ Reset value: 0x00000A33
\

$0000000f constant FDCAN3_S_FDCAN_DBTP_DSJW                         \ Synchronization jump width
$000000f0 constant FDCAN3_S_FDCAN_DBTP_DTSEG2                       \ Data time segment after sample point
$00001f00 constant FDCAN3_S_FDCAN_DBTP_DTSEG1                       \ Data time segment before sample point
$001f0000 constant FDCAN3_S_FDCAN_DBTP_DBRP                         \ Data bitrate prescaler
$00800000 constant FDCAN3_S_FDCAN_DBTP_TDC                          \ Transceiver delay compensation


\
\ @brief FDCAN data bit timing and prescaler register
\ Address offset: 0x0C
\ Reset value: 0x00000A33
\

$0000ffff constant FDCAN3_S_FDCAN_CCU_CWD_WDC                       \ WDC
$ffff0000 constant FDCAN3_S_FDCAN_CCU_CWD_WDV                       \ Watchdog value


\
\ @brief FDCAN test register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000010 constant FDCAN3_S_FDCAN_TEST_LBCK                         \ Loop back mode
$00000060 constant FDCAN3_S_FDCAN_TEST_TX                           \ Control of transmit pin
$00000080 constant FDCAN3_S_FDCAN_TEST_RX                           \ Receive pin


\
\ @brief FDCAN test register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_CCU_IR_CWE                        \ Calibration watchdog event
$00000002 constant FDCAN3_S_FDCAN_CCU_IR_CSC                        \ Calibration state changed


\
\ @brief FDCAN RAM watchdog register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant FDCAN3_S_FDCAN_RWD_WDC                           \ Watchdog configuration
$0000ff00 constant FDCAN3_S_FDCAN_RWD_WDV                           \ Watchdog value


\
\ @brief FDCAN RAM watchdog register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_CCU_IE_CWEE                       \ Calibration watchdog event enable
$00000002 constant FDCAN3_S_FDCAN_CCU_IE_CSCE                       \ Calibration state changed enable


\
\ @brief FDCAN CC control register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant FDCAN3_S_FDCAN_CCCR_INIT                         \ Initialization
$00000002 constant FDCAN3_S_FDCAN_CCCR_CCE                          \ Configuration change enable
$00000004 constant FDCAN3_S_FDCAN_CCCR_ASM                          \ ASM restricted operation mode
$00000008 constant FDCAN3_S_FDCAN_CCCR_CSA                          \ Clock stop acknowledge
$00000010 constant FDCAN3_S_FDCAN_CCCR_CSR                          \ Clock stop request
$00000020 constant FDCAN3_S_FDCAN_CCCR_MON                          \ Bus monitoring mode
$00000040 constant FDCAN3_S_FDCAN_CCCR_DAR                          \ Disable automatic retransmission
$00000080 constant FDCAN3_S_FDCAN_CCCR_TEST                         \ Test mode enable
$00000100 constant FDCAN3_S_FDCAN_CCCR_FDOE                         \ FD operation enable
$00000200 constant FDCAN3_S_FDCAN_CCCR_BRSE                         \ FDCAN bitrate switching
$00001000 constant FDCAN3_S_FDCAN_CCCR_PXHD                         \ Protocol exception handling disable
$00002000 constant FDCAN3_S_FDCAN_CCCR_EFBI                         \ Edge filtering during bus integration
$00004000 constant FDCAN3_S_FDCAN_CCCR_TXP                          \ If this bit is set, the FDCAN pauses for two CAN bit times before starting the next transmission after successfully transmitting a frame.
$00008000 constant FDCAN3_S_FDCAN_CCCR_NISO                         \ Non ISO operation


\
\ @brief FDCAN nominal bit timing and prescaler register
\ Address offset: 0x1C
\ Reset value: 0x06000A03
\

$0000007f constant FDCAN3_S_FDCAN_NBTP_NTSEG2                       \ Nominal time segment after sample point
$0000ff00 constant FDCAN3_S_FDCAN_NBTP_NTSEG1                       \ Nominal time segment before sample point
$01ff0000 constant FDCAN3_S_FDCAN_NBTP_NBRP                         \ Bitrate prescaler
$fe000000 constant FDCAN3_S_FDCAN_NBTP_NSJW                         \ Nominal (re)synchronization jump width


\
\ @brief FDCAN timestamp counter configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant FDCAN3_S_FDCAN_TSCC_TSS                          \ Timestamp select
$000f0000 constant FDCAN3_S_FDCAN_TSCC_TCP                          \ Timestamp counter prescaler


\
\ @brief FDCAN timestamp counter value register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN3_S_FDCAN_TSCV_TSC                          \ Timestamp counter


\
\ @brief FDCAN timeout counter configuration register
\ Address offset: 0x28
\ Reset value: 0xFFFF0000
\

$00000001 constant FDCAN3_S_FDCAN_TOCC_ETOC                         \ Enable timeout counter
$00000006 constant FDCAN3_S_FDCAN_TOCC_TOS                          \ Timeout select
$ffff0000 constant FDCAN3_S_FDCAN_TOCC_TOP                          \ Timeout period


\
\ @brief FDCAN timeout counter value register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant FDCAN3_S_FDCAN_TOCV_TOC                          \ Timeout counter


\
\ @brief FDCAN error counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant FDCAN3_S_FDCAN_ECR_TEC                           \ Transmit error counter
$00007f00 constant FDCAN3_S_FDCAN_ECR_REC                           \ Receive error counter
$00008000 constant FDCAN3_S_FDCAN_ECR_RP                            \ Receive error passive
$00ff0000 constant FDCAN3_S_FDCAN_ECR_CEL                           \ CAN error logging


\
\ @brief FDCAN protocol status register
\ Address offset: 0x44
\ Reset value: 0x00000707
\

$00000007 constant FDCAN3_S_FDCAN_PSR_LEC                           \ Last error code
$00000018 constant FDCAN3_S_FDCAN_PSR_ACT                           \ Activity
$00000020 constant FDCAN3_S_FDCAN_PSR_EP                            \ Error passive
$00000040 constant FDCAN3_S_FDCAN_PSR_EW                            \ Warning status
$00000080 constant FDCAN3_S_FDCAN_PSR_BO                            \ Bus_Off status
$00000700 constant FDCAN3_S_FDCAN_PSR_DLEC                          \ Data last error code
$00000800 constant FDCAN3_S_FDCAN_PSR_RESI                          \ ESI flag of last received FDCAN message
$00001000 constant FDCAN3_S_FDCAN_PSR_RBRS                          \ BRS flag of last received FDCAN message
$00002000 constant FDCAN3_S_FDCAN_PSR_REDL                          \ Received FDCAN message
$00004000 constant FDCAN3_S_FDCAN_PSR_PXE                           \ Protocol exception event
$007f0000 constant FDCAN3_S_FDCAN_PSR_TDCV                          \ Transmitter delay compensation value


\
\ @brief FDCAN transmitter delay compensation register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant FDCAN3_S_FDCAN_TDCR_TDCF                         \ Transmitter delay compensation filter window length
$00007f00 constant FDCAN3_S_FDCAN_TDCR_TDCO                         \ Transmitter delay compensation offset


\
\ @brief FDCAN interrupt register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_IR_RF0N                           \ Rx FIFO 0 New message
$00000002 constant FDCAN3_S_FDCAN_IR_RF0W                           \ Rx FIFO 0 watermark reached
$00000004 constant FDCAN3_S_FDCAN_IR_RF0F                           \ Rx FIFO 0 full
$00000008 constant FDCAN3_S_FDCAN_IR_RF0L                           \ Rx FIFO 0 message lost
$00000010 constant FDCAN3_S_FDCAN_IR_RF1N                           \ Rx FIFO 1 new message
$00000020 constant FDCAN3_S_FDCAN_IR_RF1W                           \ Rx FIFO 1 watermark reached
$00000040 constant FDCAN3_S_FDCAN_IR_RF1F                           \ Rx FIFO 1 full
$00000080 constant FDCAN3_S_FDCAN_IR_RF1L                           \ Rx FIFO 1 message lost
$00000100 constant FDCAN3_S_FDCAN_IR_HPM                            \ High priority message
$00000200 constant FDCAN3_S_FDCAN_IR_TC                             \ Transmission completed
$00000400 constant FDCAN3_S_FDCAN_IR_TCF                            \ Transmission cancellation finished
$00000800 constant FDCAN3_S_FDCAN_IR_TFE                            \ Tx FIFO empty
$00001000 constant FDCAN3_S_FDCAN_IR_TEFN                           \ Tx event FIFO new entry
$00002000 constant FDCAN3_S_FDCAN_IR_TEFW                           \ Tx event FIFO watermark reached
$00004000 constant FDCAN3_S_FDCAN_IR_TEFF                           \ Tx event FIFO full
$00008000 constant FDCAN3_S_FDCAN_IR_TEFL                           \ Tx event FIFO element lost
$00010000 constant FDCAN3_S_FDCAN_IR_TSW                            \ Timestamp wraparound
$00020000 constant FDCAN3_S_FDCAN_IR_MRAF                           \ Message RAM access failure
$00040000 constant FDCAN3_S_FDCAN_IR_TOO                            \ Timeout occurred
$00080000 constant FDCAN3_S_FDCAN_IR_DRX                            \ Message stored to dedicated Rx buffer
$00400000 constant FDCAN3_S_FDCAN_IR_ELO                            \ Error logging overflow
$00800000 constant FDCAN3_S_FDCAN_IR_EP                             \ Error passive
$01000000 constant FDCAN3_S_FDCAN_IR_EW                             \ Warning status
$02000000 constant FDCAN3_S_FDCAN_IR_BO                             \ Bus_Off status
$04000000 constant FDCAN3_S_FDCAN_IR_WDI                            \ Watchdog interrupt
$08000000 constant FDCAN3_S_FDCAN_IR_PEA                            \ Protocol error in arbitration phase (nominal bit time is used)
$10000000 constant FDCAN3_S_FDCAN_IR_PED                            \ Protocol error in data phase (data bit time is used)
$20000000 constant FDCAN3_S_FDCAN_IR_ARA                            \ Access to reserved address


\
\ @brief FDCAN interrupt enable register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_IE_RF0NE                          \ Rx FIFO 0 new message interrupt enable
$00000002 constant FDCAN3_S_FDCAN_IE_RF0WE                          \ Rx FIFO 0 watermark reached interrupt enable
$00000004 constant FDCAN3_S_FDCAN_IE_RF0FE                          \ Rx FIFO 0 full interrupt enable
$00000008 constant FDCAN3_S_FDCAN_IE_RF0LE                          \ Rx FIFO 0 message lost interrupt enable
$00000010 constant FDCAN3_S_FDCAN_IE_RF1NE                          \ Rx FIFO 1 new message interrupt enable
$00000020 constant FDCAN3_S_FDCAN_IE_RF1WE                          \ Rx FIFO 1 watermark reached interrupt enable
$00000040 constant FDCAN3_S_FDCAN_IE_RF1FE                          \ Rx FIFO 1 full interrupt enable
$00000080 constant FDCAN3_S_FDCAN_IE_RF1LE                          \ Rx FIFO 1 message lost interrupt enable
$00000100 constant FDCAN3_S_FDCAN_IE_HPME                           \ High priority message interrupt enable
$00000200 constant FDCAN3_S_FDCAN_IE_TCE                            \ Transmission completed interrupt enable
$00000400 constant FDCAN3_S_FDCAN_IE_TCFE                           \ Transmission cancellation finished interrupt enable
$00000800 constant FDCAN3_S_FDCAN_IE_TFEE                           \ Tx FIFO empty interrupt enable
$00001000 constant FDCAN3_S_FDCAN_IE_TEFNE                          \ Tx event FIFO new entry interrupt enable
$00002000 constant FDCAN3_S_FDCAN_IE_TEFWE                          \ Tx event FIFO watermark reached interrupt enable
$00004000 constant FDCAN3_S_FDCAN_IE_TEFFE                          \ Tx event FIFO full interrupt enable
$00008000 constant FDCAN3_S_FDCAN_IE_TEFLE                          \ Tx event FIFO element lost interrupt enable
$00010000 constant FDCAN3_S_FDCAN_IE_TSWE                           \ Timestamp wraparound interrupt enable
$00020000 constant FDCAN3_S_FDCAN_IE_MRAFE                          \ Message RAM access failure interrupt enable
$00040000 constant FDCAN3_S_FDCAN_IE_TOOE                           \ Timeout occurred interrupt enable
$00080000 constant FDCAN3_S_FDCAN_IE_DRXE                           \ Message stored to dedicated Rx buffer interrupt enable
$00400000 constant FDCAN3_S_FDCAN_IE_ELOE                           \ Error logging overflow interrupt enable
$00800000 constant FDCAN3_S_FDCAN_IE_EPE                            \ Error passive interrupt enable
$01000000 constant FDCAN3_S_FDCAN_IE_EWE                            \ Warning status interrupt enable
$02000000 constant FDCAN3_S_FDCAN_IE_BOE                            \ Bus_Off status
$04000000 constant FDCAN3_S_FDCAN_IE_WDIE                           \ Watchdog interrupt enable
$08000000 constant FDCAN3_S_FDCAN_IE_PEAE                           \ Protocol error in Arbitration phase enable
$10000000 constant FDCAN3_S_FDCAN_IE_PEDE                           \ Protocol error in data phase enable
$20000000 constant FDCAN3_S_FDCAN_IE_ARAE                           \ Access to Reserved address enable


\
\ @brief FDCAN interrupt line select register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_ILS_RF0NL                         \ Rx FIFO 0 new message interrupt line
$00000002 constant FDCAN3_S_FDCAN_ILS_RF0WL                         \ Rx FIFO 0 watermark reached interrupt line
$00000004 constant FDCAN3_S_FDCAN_ILS_RF0FL                         \ Rx FIFO 0 full interrupt line
$00000008 constant FDCAN3_S_FDCAN_ILS_RF0LL                         \ Rx FIFO 0 message lost interrupt line
$00000010 constant FDCAN3_S_FDCAN_ILS_RF1NL                         \ Rx FIFO 1 new message interrupt line
$00000020 constant FDCAN3_S_FDCAN_ILS_RF1WL                         \ Rx FIFO 1 watermark reached interrupt line
$00000040 constant FDCAN3_S_FDCAN_ILS_RF1FL                         \ Rx FIFO 1 full interrupt line
$00000080 constant FDCAN3_S_FDCAN_ILS_RF1LL                         \ Rx FIFO 1 message lost interrupt line
$00000100 constant FDCAN3_S_FDCAN_ILS_HPML                          \ High priority message interrupt line
$00000200 constant FDCAN3_S_FDCAN_ILS_TCL                           \ Transmission completed interrupt line
$00000400 constant FDCAN3_S_FDCAN_ILS_TCFL                          \ Transmission cancellation finished interrupt line
$00000800 constant FDCAN3_S_FDCAN_ILS_TFEL                          \ Tx FIFO empty interrupt line
$00001000 constant FDCAN3_S_FDCAN_ILS_TEFNL                         \ Tx event FIFO new entry interrupt line
$00002000 constant FDCAN3_S_FDCAN_ILS_TEFWL                         \ Tx event FIFO watermark reached interrupt line
$00004000 constant FDCAN3_S_FDCAN_ILS_TEFFL                         \ Tx event FIFO full interrupt line
$00008000 constant FDCAN3_S_FDCAN_ILS_TEFLL                         \ Tx event FIFO element Lost interrupt line
$00010000 constant FDCAN3_S_FDCAN_ILS_TSWL                          \ Timestamp wraparound interrupt line
$00020000 constant FDCAN3_S_FDCAN_ILS_MRAFL                         \ Message RAM access failure interrupt line
$00040000 constant FDCAN3_S_FDCAN_ILS_TOOL                          \ Timeout occurred interrupt line
$00080000 constant FDCAN3_S_FDCAN_ILS_DRXL                          \ Message stored to dedicated Rx buffer interrupt line
$00400000 constant FDCAN3_S_FDCAN_ILS_ELOL                          \ Error logging overflow interrupt line
$00800000 constant FDCAN3_S_FDCAN_ILS_EPL                           \ Error passive interrupt line
$01000000 constant FDCAN3_S_FDCAN_ILS_EWL                           \ Warning status interrupt line
$02000000 constant FDCAN3_S_FDCAN_ILS_BOL                           \ Bus_Off status
$04000000 constant FDCAN3_S_FDCAN_ILS_WDIL                          \ Watchdog interrupt line
$08000000 constant FDCAN3_S_FDCAN_ILS_PEAL                          \ Protocol error in arbitration phase line
$10000000 constant FDCAN3_S_FDCAN_ILS_PEDL                          \ Protocol error in data phase line
$20000000 constant FDCAN3_S_FDCAN_ILS_ARAL                          \ Access to reserved address line


\
\ @brief FDCAN interrupt line enable register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_ILE_EINT0                         \ Enable interrupt line 0
$00000002 constant FDCAN3_S_FDCAN_ILE_EINT1                         \ Enable interrupt line 1


\
\ @brief FDCAN global filter configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_GFC_RRFE                          \ Reject remote frames extended
$00000002 constant FDCAN3_S_FDCAN_GFC_RRFS                          \ Reject remote frames standard
$0000000c constant FDCAN3_S_FDCAN_GFC_ANFE                          \ Accept non-matching frames extended
$00000030 constant FDCAN3_S_FDCAN_GFC_ANFS                          \ Accept non-matching frames standard


\
\ @brief FDCAN standard ID filter configuration register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN3_S_FDCAN_SIDFC_FLSSA                       \ Filter list standard start address
$00ff0000 constant FDCAN3_S_FDCAN_SIDFC_LSS                         \ List size standard


\
\ @brief FDCAN extended ID filter configuration register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN3_S_FDCAN_XIDFC_FLESA                       \ Filter list extended start address
$00ff0000 constant FDCAN3_S_FDCAN_XIDFC_LSE                         \ List size extended


\
\ @brief FDCAN extended ID and mask register
\ Address offset: 0x90
\ Reset value: 0x1FFFFFFF
\

$1fffffff constant FDCAN3_S_FDCAN_XIDAM_EIDM                        \ Extended ID Mask


\
\ @brief FDCAN high priority message status register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000003f constant FDCAN3_S_FDCAN_HPMS_BIDX                         \ Buffer index
$000000c0 constant FDCAN3_S_FDCAN_HPMS_MSI                          \ Message storage indicator
$00007f00 constant FDCAN3_S_FDCAN_HPMS_FIDX                         \ Filter index
$00008000 constant FDCAN3_S_FDCAN_HPMS_FLST                         \ Filter list


\
\ @brief FDCAN new data 1 register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_NDAT1_ND0                         \ New data[31:0]
$00000002 constant FDCAN3_S_FDCAN_NDAT1_ND1                         \ New data[31:0]
$00000004 constant FDCAN3_S_FDCAN_NDAT1_ND2                         \ New data[31:0]
$00000008 constant FDCAN3_S_FDCAN_NDAT1_ND3                         \ New data[31:0]
$00000010 constant FDCAN3_S_FDCAN_NDAT1_ND4                         \ New data[31:0]
$00000020 constant FDCAN3_S_FDCAN_NDAT1_ND5                         \ New data[31:0]
$00000040 constant FDCAN3_S_FDCAN_NDAT1_ND6                         \ New data[31:0]
$00000080 constant FDCAN3_S_FDCAN_NDAT1_ND7                         \ New data[31:0]
$00000100 constant FDCAN3_S_FDCAN_NDAT1_ND8                         \ New data[31:0]
$00000200 constant FDCAN3_S_FDCAN_NDAT1_ND9                         \ New data[31:0]
$00000400 constant FDCAN3_S_FDCAN_NDAT1_ND10                        \ New data[31:0]
$00000800 constant FDCAN3_S_FDCAN_NDAT1_ND11                        \ New data[31:0]
$00001000 constant FDCAN3_S_FDCAN_NDAT1_ND12                        \ New data[31:0]
$00002000 constant FDCAN3_S_FDCAN_NDAT1_ND13                        \ New data[31:0]
$00004000 constant FDCAN3_S_FDCAN_NDAT1_ND14                        \ New data[31:0]
$00008000 constant FDCAN3_S_FDCAN_NDAT1_ND15                        \ New data[31:0]
$00010000 constant FDCAN3_S_FDCAN_NDAT1_ND16                        \ New data[31:0]
$00020000 constant FDCAN3_S_FDCAN_NDAT1_ND17                        \ New data[31:0]
$00040000 constant FDCAN3_S_FDCAN_NDAT1_ND18                        \ New data[31:0]
$00080000 constant FDCAN3_S_FDCAN_NDAT1_ND19                        \ New data[31:0]
$00100000 constant FDCAN3_S_FDCAN_NDAT1_ND20                        \ New data[31:0]
$00200000 constant FDCAN3_S_FDCAN_NDAT1_ND21                        \ New data[31:0]
$00400000 constant FDCAN3_S_FDCAN_NDAT1_ND22                        \ New data[31:0]
$00800000 constant FDCAN3_S_FDCAN_NDAT1_ND23                        \ New data[31:0]
$01000000 constant FDCAN3_S_FDCAN_NDAT1_ND24                        \ New data[31:0]
$02000000 constant FDCAN3_S_FDCAN_NDAT1_ND25                        \ New data[31:0]
$04000000 constant FDCAN3_S_FDCAN_NDAT1_ND26                        \ New data[31:0]
$08000000 constant FDCAN3_S_FDCAN_NDAT1_ND27                        \ New data[31:0]
$10000000 constant FDCAN3_S_FDCAN_NDAT1_ND28                        \ New data[31:0]
$20000000 constant FDCAN3_S_FDCAN_NDAT1_ND29                        \ New data[31:0]
$40000000 constant FDCAN3_S_FDCAN_NDAT1_ND30                        \ New data[31:0]
$80000000 constant FDCAN3_S_FDCAN_NDAT1_ND31                        \ New data[31:0]


\
\ @brief FDCAN new data 2 register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_NDAT2_ND32                        \ New data[63:32]
$00000002 constant FDCAN3_S_FDCAN_NDAT2_ND33                        \ New data[63:32]
$00000004 constant FDCAN3_S_FDCAN_NDAT2_ND34                        \ New data[63:32]
$00000008 constant FDCAN3_S_FDCAN_NDAT2_ND35                        \ New data[63:32]
$00000010 constant FDCAN3_S_FDCAN_NDAT2_ND36                        \ New data[63:32]
$00000020 constant FDCAN3_S_FDCAN_NDAT2_ND37                        \ New data[63:32]
$00000040 constant FDCAN3_S_FDCAN_NDAT2_ND38                        \ New data[63:32]
$00000080 constant FDCAN3_S_FDCAN_NDAT2_ND39                        \ New data[63:32]
$00000100 constant FDCAN3_S_FDCAN_NDAT2_ND40                        \ New data[63:32]
$00000200 constant FDCAN3_S_FDCAN_NDAT2_ND41                        \ New data[63:32]
$00000400 constant FDCAN3_S_FDCAN_NDAT2_ND42                        \ New data[63:32]
$00000800 constant FDCAN3_S_FDCAN_NDAT2_ND43                        \ New data[63:32]
$00001000 constant FDCAN3_S_FDCAN_NDAT2_ND44                        \ New data[63:32]
$00002000 constant FDCAN3_S_FDCAN_NDAT2_ND45                        \ New data[63:32]
$00004000 constant FDCAN3_S_FDCAN_NDAT2_ND46                        \ New data[63:32]
$00008000 constant FDCAN3_S_FDCAN_NDAT2_ND47                        \ New data[63:32]
$00010000 constant FDCAN3_S_FDCAN_NDAT2_ND48                        \ New data[63:32]
$00020000 constant FDCAN3_S_FDCAN_NDAT2_ND49                        \ New data[63:32]
$00040000 constant FDCAN3_S_FDCAN_NDAT2_ND50                        \ New data[63:32]
$00080000 constant FDCAN3_S_FDCAN_NDAT2_ND51                        \ New data[63:32]
$00100000 constant FDCAN3_S_FDCAN_NDAT2_ND52                        \ New data[63:32]
$00200000 constant FDCAN3_S_FDCAN_NDAT2_ND53                        \ New data[63:32]
$00400000 constant FDCAN3_S_FDCAN_NDAT2_ND54                        \ New data[63:32]
$00800000 constant FDCAN3_S_FDCAN_NDAT2_ND55                        \ New data[63:32]
$01000000 constant FDCAN3_S_FDCAN_NDAT2_ND56                        \ New data[63:32]
$02000000 constant FDCAN3_S_FDCAN_NDAT2_ND57                        \ New data[63:32]
$04000000 constant FDCAN3_S_FDCAN_NDAT2_ND58                        \ New data[63:32]
$08000000 constant FDCAN3_S_FDCAN_NDAT2_ND59                        \ New data[63:32]
$10000000 constant FDCAN3_S_FDCAN_NDAT2_ND60                        \ New data[63:32]
$20000000 constant FDCAN3_S_FDCAN_NDAT2_ND61                        \ New data[63:32]
$40000000 constant FDCAN3_S_FDCAN_NDAT2_ND62                        \ New data[63:32]
$80000000 constant FDCAN3_S_FDCAN_NDAT2_ND63                        \ New data[63:32]


\
\ @brief FDCAN Rx FIFO 0 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN3_S_FDCAN_RXF0C_F0SA                        \ Rx FIFO 0 start address
$007f0000 constant FDCAN3_S_FDCAN_RXF0C_F0S                         \ Rx FIFO 0 size
$7f000000 constant FDCAN3_S_FDCAN_RXF0C_F0WM                        \ FIFO 0 watermark
$80000000 constant FDCAN3_S_FDCAN_RXF0C_F0OM                        \ FIFO 0 operation mode


\
\ @brief FDCAN Rx FIFO 0 status register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000007f constant FDCAN3_S_FDCAN_RXF0S_F0FL                        \ Rx FIFO 0 fill level
$00003f00 constant FDCAN3_S_FDCAN_RXF0S_F0GI                        \ Rx FIFO 0 get index
$003f0000 constant FDCAN3_S_FDCAN_RXF0S_F0PI                        \ Rx FIFO 0 put index
$01000000 constant FDCAN3_S_FDCAN_RXF0S_F0F                         \ Rx FIFO 0 full
$02000000 constant FDCAN3_S_FDCAN_RXF0S_RF0L                        \ Rx FIFO 0 message lost


\
\ @brief FDCAN Rx FIFO 0 acknowledge register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000003f constant FDCAN3_S_FDCAN_RXF0A_F0AI                        \ Rx FIFO 0 acknowledge index


\
\ @brief FDCAN Rx buffer configuration register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN3_S_FDCAN_RXBC_RBSA                         \ Rx buffer start address


\
\ @brief FDCAN Rx FIFO 1 configuration register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN3_S_FDCAN_RXF1C_F1SA                        \ Rx FIFO 1 start address
$007f0000 constant FDCAN3_S_FDCAN_RXF1C_F1S                         \ Rx FIFO 1 size
$7f000000 constant FDCAN3_S_FDCAN_RXF1C_F1WM                        \ Rx FIFO 1 watermark
$80000000 constant FDCAN3_S_FDCAN_RXF1C_F1OM                        \ FIFO 1 operation mode


\
\ @brief FDCAN Rx FIFO 1 status register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant FDCAN3_S_FDCAN_RXF1S_F1FL                        \ Rx FIFO 1 fill level
$00003f00 constant FDCAN3_S_FDCAN_RXF1S_F1GI                        \ Rx FIFO 1 get index
$003f0000 constant FDCAN3_S_FDCAN_RXF1S_F1PI                        \ Rx FIFO 1 put index
$01000000 constant FDCAN3_S_FDCAN_RXF1S_F1F                         \ Rx FIFO 1 full
$02000000 constant FDCAN3_S_FDCAN_RXF1S_RF1L                        \ Rx FIFO 1 message lost
$c0000000 constant FDCAN3_S_FDCAN_RXF1S_DMS                         \ Debug message status


\
\ @brief FDCAN Rx FIFO 1 acknowledge register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$0000003f constant FDCAN3_S_FDCAN_RXF1A_F1AI                        \ Rx FIFO 1 acknowledge index


\
\ @brief FDCAN Rx buffer element size configuration register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000007 constant FDCAN3_S_FDCAN_RXESC_F0DS                        \ Rx FIFO 1 data field size
$00000070 constant FDCAN3_S_FDCAN_RXESC_F1DS                        \ Rx FIFO 0 data field size
$00000700 constant FDCAN3_S_FDCAN_RXESC_RBDS                        \ Rx buffer data field size


\
\ @brief FDCAN Tx buffer configuration register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN3_S_FDCAN_TXBC_TBSA                         \ Tx buffers start address
$003f0000 constant FDCAN3_S_FDCAN_TXBC_NDTB                         \ Number of dedicated transmit buffers
$3f000000 constant FDCAN3_S_FDCAN_TXBC_TFQS                         \ Transmit FIFO/queue size
$40000000 constant FDCAN3_S_FDCAN_TXBC_TFQM                         \ Tx FIFO/queue mode


\
\ @brief FDCAN Tx FIFO/queue status register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$0000003f constant FDCAN3_S_FDCAN_TXFQS_TFFL                        \ Tx FIFO free level
$00001f00 constant FDCAN3_S_FDCAN_TXFQS_TFGI                        \ Tx FIFO get index.
$001f0000 constant FDCAN3_S_FDCAN_TXFQS_TFQPI                       \ Tx FIFO/queue put index
$00200000 constant FDCAN3_S_FDCAN_TXFQS_TFQF                        \ Tx FIFO/queue full


\
\ @brief FDCAN Tx buffer element size configuration register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000007 constant FDCAN3_S_FDCAN_TXESC_TBDS                        \ Tx buffer data Field size:


\
\ @brief FDCAN Tx buffer request pending register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant FDCAN3_S_FDCAN_TXBRP_TRP                         \ Transmission request pending


\
\ @brief FDCAN Tx buffer add request register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant FDCAN3_S_FDCAN_TXBAR_AR                          \ Add request


\
\ @brief FDCAN Tx buffer cancellation request register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000000 constant FDCAN3_S_FDCAN_TXBCR_CR                          \ Cancellation request


\
\ @brief FDCAN Tx buffer transmission occurred register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000000 constant FDCAN3_S_FDCAN_TXBTO_TO                          \ Transmission occurred


\
\ @brief FDCAN Tx buffer cancellation finished register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000000 constant FDCAN3_S_FDCAN_TXBCF_CF                          \ Cancellation finished


\
\ @brief FDCAN Tx buffer transmission interrupt enable register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000000 constant FDCAN3_S_FDCAN_TXBTIE_TIE                        \ Transmission interrupt enable


\
\ @brief FDCAN Tx buffer cancellation finished interrupt enable register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000000 constant FDCAN3_S_FDCAN_TXBCIE_CFIE                       \ Cancellation finished interrupt enable


\
\ @brief FDCAN Tx event FIFO configuration register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN3_S_FDCAN_TXEFC_EFSA                        \ Event FIFO start address
$003f0000 constant FDCAN3_S_FDCAN_TXEFC_EFS                         \ Event FIFO size.
$3f000000 constant FDCAN3_S_FDCAN_TXEFC_EFWM                        \ Event FIFO watermark


\
\ @brief FDCAN Tx event FIFO status register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$0000003f constant FDCAN3_S_FDCAN_TXEFS_EFFL                        \ Event FIFO fill level
$00001f00 constant FDCAN3_S_FDCAN_TXEFS_EFGI                        \ Event FIFO get index
$001f0000 constant FDCAN3_S_FDCAN_TXEFS_EFPI                        \ Event FIFO put index
$01000000 constant FDCAN3_S_FDCAN_TXEFS_EFF                         \ Event FIFO full
$02000000 constant FDCAN3_S_FDCAN_TXEFS_TEFL                        \ Tx event FIFO element lost


\
\ @brief FDCAN Tx event FIFO acknowledge register
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$0000001f constant FDCAN3_S_FDCAN_TXEFA_EFAI                        \ Event FIFO acknowledge index


\
\ @brief FDCAN TT trigger memory configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN3_S_FDCAN_TTTMC_TMSA                        \ Trigger memory start address.
$007f0000 constant FDCAN3_S_FDCAN_TTTMC_TME                         \ Trigger memory elements


\
\ @brief FDCAN TT reference message configuration register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$1fffffff constant FDCAN3_S_FDCAN_TTRMC_RID                         \ Reference identifier.
$40000000 constant FDCAN3_S_FDCAN_TTRMC_XTD                         \ Extended identifier
$80000000 constant FDCAN3_S_FDCAN_TTRMC_RMPS                        \ Reference message payload select


\
\ @brief FDCAN TT operation configuration register
\ Address offset: 0x108
\ Reset value: 0x00010000
\

$00000003 constant FDCAN3_S_FDCAN_TTOCF_OM                          \ Operation mode.
$00000008 constant FDCAN3_S_FDCAN_TTOCF_GEN                         \ Gap enable.
$00000010 constant FDCAN3_S_FDCAN_TTOCF_TM                          \ Time master.
$000000e0 constant FDCAN3_S_FDCAN_TTOCF_LDSDL                       \ LD of synchronization deviation limit.
$00007f00 constant FDCAN3_S_FDCAN_TTOCF_IRTO                        \ Initial reference trigger offset.
$00008000 constant FDCAN3_S_FDCAN_TTOCF_EECS                        \ Enable external clock synchronization
$00ff0000 constant FDCAN3_S_FDCAN_TTOCF_AWL                         \ Application watchdog limit.
$01000000 constant FDCAN3_S_FDCAN_TTOCF_EGTF                        \ Enable global time filtering.
$02000000 constant FDCAN3_S_FDCAN_TTOCF_ECC                         \ Enable clock calibration.
$04000000 constant FDCAN3_S_FDCAN_TTOCF_EVTP                        \ Event trigger polarity.


\
\ @brief FDCAN TT matrix limits register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000003f constant FDCAN3_S_FDCAN_TTMLM_CCM                         \ Cycle count Max
$000000c0 constant FDCAN3_S_FDCAN_TTMLM_CSS                         \ Cycle start synchronization
$00000f00 constant FDCAN3_S_FDCAN_TTMLM_TXEW                        \ Tx enable window
$0fff0000 constant FDCAN3_S_FDCAN_TTMLM_ENTT                        \ Expected number of Tx triggers


\
\ @brief FDCAN TUR configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN3_S_FDCAN_TURCF_NCL                         \ Numerator configuration low.
$3fff0000 constant FDCAN3_S_FDCAN_TURCF_DC                          \ Denominator configuration.
$80000000 constant FDCAN3_S_FDCAN_TURCF_ELT                         \ Enable local time.


\
\ @brief FDCAN TT operation control register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_TTOCN_SGT                         \ Set global time.
$00000002 constant FDCAN3_S_FDCAN_TTOCN_ECS                         \ External clock synchronization.
$00000004 constant FDCAN3_S_FDCAN_TTOCN_SWP                         \ Stop watch polarity.
$00000018 constant FDCAN3_S_FDCAN_TTOCN_SWS                         \ Stop watch source.
$00000020 constant FDCAN3_S_FDCAN_TTOCN_RTIE                        \ Register time mark interrupt pulse enable.
$000000c0 constant FDCAN3_S_FDCAN_TTOCN_TMC                         \ Register time mark compare.
$00000100 constant FDCAN3_S_FDCAN_TTOCN_TTIE                        \ Trigger time mark interrupt pulse enable
$00000200 constant FDCAN3_S_FDCAN_TTOCN_GCS                         \ Gap control select
$00000400 constant FDCAN3_S_FDCAN_TTOCN_FGP                         \ Finish gap.
$00000800 constant FDCAN3_S_FDCAN_TTOCN_TMG                         \ Time mark gap.
$00001000 constant FDCAN3_S_FDCAN_TTOCN_NIG                         \ Next is gap.
$00002000 constant FDCAN3_S_FDCAN_TTOCN_ESCN                        \ External synchronization control
$00008000 constant FDCAN3_S_FDCAN_TTOCN_LCKC                        \ TT operation control register locked.


\
\ @brief FDCAN TT global time preset register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN3_S_FDCAN_TTGTP_TP                          \ Time preset
$ffff0000 constant FDCAN3_S_FDCAN_TTGTP_CTP                         \ Cycle time target phase


\
\ @brief FDCAN TT time mark register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN3_S_FDCAN_TTTMK_TM                          \ Time mark
$007f0000 constant FDCAN3_S_FDCAN_TTTMK_TICC                        \ Time mark cycle code
$80000000 constant FDCAN3_S_FDCAN_TTTMK_LCKM                        \ TT time mark register locked


\
\ @brief FDCAN TT interrupt register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_TTIR_SBC                          \ Start of basic cycle
$00000002 constant FDCAN3_S_FDCAN_TTIR_SMC                          \ Start of matrix cycle
$00000004 constant FDCAN3_S_FDCAN_TTIR_CSM                          \ Change of synchronization mode
$00000008 constant FDCAN3_S_FDCAN_TTIR_SOG                          \ Start of gap
$00000010 constant FDCAN3_S_FDCAN_TTIR_RTMI                         \ Register time mark interrupt
$00000020 constant FDCAN3_S_FDCAN_TTIR_TTMI                         \ Trigger time mark event internal
$00000040 constant FDCAN3_S_FDCAN_TTIR_SWE                          \ Stop watch event
$00000080 constant FDCAN3_S_FDCAN_TTIR_GTW                          \ Global time wrap
$00000100 constant FDCAN3_S_FDCAN_TTIR_GTD                          \ Global time discontinuity
$00000200 constant FDCAN3_S_FDCAN_TTIR_GTE                          \ Global time error
$00000400 constant FDCAN3_S_FDCAN_TTIR_TXU                          \ Tx count underflow
$00000800 constant FDCAN3_S_FDCAN_TTIR_TXO                          \ Tx count overflow
$00001000 constant FDCAN3_S_FDCAN_TTIR_SE1                          \ Scheduling error 1
$00002000 constant FDCAN3_S_FDCAN_TTIR_SE2                          \ Scheduling error 2
$00004000 constant FDCAN3_S_FDCAN_TTIR_ELC                          \ Error level changed
$00008000 constant FDCAN3_S_FDCAN_TTIR_IWTG                         \ Initialization watch trigger
$00010000 constant FDCAN3_S_FDCAN_TTIR_WT                           \ Watch trigger
$00020000 constant FDCAN3_S_FDCAN_TTIR_AW                           \ Application watchdog
$00040000 constant FDCAN3_S_FDCAN_TTIR_CER                          \ Configuration error


\
\ @brief FDCAN TT interrupt enable register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_TTIE_SBCE                         \ Start of basic cycle interrupt enable
$00000002 constant FDCAN3_S_FDCAN_TTIE_SMCE                         \ Start of matrix cycle interrupt enable
$00000004 constant FDCAN3_S_FDCAN_TTIE_CSME                         \ Change of synchronization mode interrupt enable
$00000008 constant FDCAN3_S_FDCAN_TTIE_SOGE                         \ Start of gap interrupt enable
$00000010 constant FDCAN3_S_FDCAN_TTIE_RTMIE                        \ Register time mark interrupt enable
$00000020 constant FDCAN3_S_FDCAN_TTIE_TTMIE                        \ Trigger time mark event internal interrupt enable
$00000040 constant FDCAN3_S_FDCAN_TTIE_SWEE                         \ Stop watch event interrupt enable
$00000080 constant FDCAN3_S_FDCAN_TTIE_GTWE                         \ Global time wrap interrupt enable
$00000100 constant FDCAN3_S_FDCAN_TTIE_GTDE                         \ Global time discontinuity interrupt enable
$00000200 constant FDCAN3_S_FDCAN_TTIE_GTEE                         \ Global time error interrupt enable
$00000400 constant FDCAN3_S_FDCAN_TTIE_TXUE                         \ Tx count underflow interrupt enable
$00000800 constant FDCAN3_S_FDCAN_TTIE_TXOE                         \ Tx count overflow interrupt enable
$00001000 constant FDCAN3_S_FDCAN_TTIE_SE1E                         \ Scheduling error 1 interrupt enable
$00002000 constant FDCAN3_S_FDCAN_TTIE_SE2E                         \ Scheduling error 2 interrupt enable
$00004000 constant FDCAN3_S_FDCAN_TTIE_ELCE                         \ Change error level interrupt enable
$00008000 constant FDCAN3_S_FDCAN_TTIE_IWTE                         \ Initialization watch trigger interrupt enable
$00010000 constant FDCAN3_S_FDCAN_TTIE_WTE                          \ Watch trigger interrupt enable
$00020000 constant FDCAN3_S_FDCAN_TTIE_AWE                          \ Application watchdog interrupt enable
$00040000 constant FDCAN3_S_FDCAN_TTIE_CERE                         \ Configuration error interrupt enable


\
\ @brief FDCAN TT interrupt line select register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000001 constant FDCAN3_S_FDCAN_TTILS_SBCL                        \ Start of basic cycle interrupt line
$00000002 constant FDCAN3_S_FDCAN_TTILS_SMCL                        \ Start of matrix cycle interrupt line
$00000004 constant FDCAN3_S_FDCAN_TTILS_CSML                        \ Change of synchronization mode interrupt line
$00000008 constant FDCAN3_S_FDCAN_TTILS_SOGL                        \ Start of gap interrupt line
$00000010 constant FDCAN3_S_FDCAN_TTILS_RTMIL                       \ Register time mark interrupt line
$00000020 constant FDCAN3_S_FDCAN_TTILS_TTMIL                       \ Trigger time mark event internal interrupt line
$00000040 constant FDCAN3_S_FDCAN_TTILS_SWEL                        \ Stop watch event interrupt line
$00000080 constant FDCAN3_S_FDCAN_TTILS_GTWL                        \ Global time wrap interrupt line
$00000100 constant FDCAN3_S_FDCAN_TTILS_GTDL                        \ Global time discontinuity interrupt line
$00000200 constant FDCAN3_S_FDCAN_TTILS_GTEL                        \ Global time error interrupt line
$00000400 constant FDCAN3_S_FDCAN_TTILS_TXUL                        \ Tx count underflow interrupt line
$00000800 constant FDCAN3_S_FDCAN_TTILS_TXOL                        \ Tx count overflow interrupt line
$00001000 constant FDCAN3_S_FDCAN_TTILS_SE1L                        \ Scheduling error 1 interrupt line
$00002000 constant FDCAN3_S_FDCAN_TTILS_SE2L                        \ Scheduling error 2 interrupt line
$00004000 constant FDCAN3_S_FDCAN_TTILS_ELCL                        \ Change error level interrupt line
$00008000 constant FDCAN3_S_FDCAN_TTILS_IWTL                        \ Initialization watch trigger interrupt line
$00010000 constant FDCAN3_S_FDCAN_TTILS_WTL                         \ Watch trigger interrupt line
$00020000 constant FDCAN3_S_FDCAN_TTILS_AWL                         \ Application watchdog interrupt line
$00040000 constant FDCAN3_S_FDCAN_TTILS_CERL                        \ Configuration error interrupt line


\
\ @brief FDCAN TT operation status register
\ Address offset: 0x12C
\ Reset value: 0x00000080
\

$00000003 constant FDCAN3_S_FDCAN_TTOST_EL                          \ Error level
$0000000c constant FDCAN3_S_FDCAN_TTOST_MS                          \ Master state
$00000030 constant FDCAN3_S_FDCAN_TTOST_SYS                         \ Synchronization state
$00000040 constant FDCAN3_S_FDCAN_TTOST_QGTP                        \ Quality of global time phase
$00000080 constant FDCAN3_S_FDCAN_TTOST_QCS                         \ Quality of clock speed
$0000ff00 constant FDCAN3_S_FDCAN_TTOST_RTO                         \ Reference trigger offset
$00400000 constant FDCAN3_S_FDCAN_TTOST_WGTD                        \ Wait for global time discontinuity
$00800000 constant FDCAN3_S_FDCAN_TTOST_GFI                         \ Gap finished indicator
$07000000 constant FDCAN3_S_FDCAN_TTOST_TMP                         \ Time master priority
$08000000 constant FDCAN3_S_FDCAN_TTOST_GSI                         \ Gap started indicator
$10000000 constant FDCAN3_S_FDCAN_TTOST_WFE                         \ Wait for event
$20000000 constant FDCAN3_S_FDCAN_TTOST_AWE                         \ Application watchdog event
$40000000 constant FDCAN3_S_FDCAN_TTOST_WECS                        \ Wait for external clock synchronization.
$80000000 constant FDCAN3_S_FDCAN_TTOST_SPL                         \ Schedule phase lock


\
\ @brief FDCAN TUR numerator actual register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0003ffff constant FDCAN3_S_FDCAN_TURNA_NAV                         \ Numerator actual value


\
\ @brief FDCAN TT local and global time register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN3_S_FDCAN_TTLGT_LT                          \ Local time
$ffff0000 constant FDCAN3_S_FDCAN_TTLGT_GT                          \ Global time


\
\ @brief FDCAN TT cycle time and count register
\ Address offset: 0x138
\ Reset value: 0x003F0000
\

$0000ffff constant FDCAN3_S_FDCAN_TTCTC_CT                          \ Cycle time
$003f0000 constant FDCAN3_S_FDCAN_TTCTC_CC                          \ Cycle count


\
\ @brief FDCAN TT capture time register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$0000003f constant FDCAN3_S_FDCAN_TTCPT_CCV                         \ Cycle count value
$ffff0000 constant FDCAN3_S_FDCAN_TTCPT_SWV                         \ Stop watch value


\
\ @brief FDCAN TT cycle sync mark register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN3_S_FDCAN_TTCSM_CSM                         \ Cycle sync mark


\
\ @brief FDCAN TT trigger select register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000003 constant FDCAN3_S_FDCAN_TTTS_SWTDEL                       \ Stop watch trigger input selection
$00000030 constant FDCAN3_S_FDCAN_TTTS_EVTSEL                       \ Event trigger input selection


\
\ @brief FDCAN register block
\
$5000e800 constant FDCAN3_S_FDCAN_CREL  \ offset: 0x00 : FDCAN core release register
$5000e800 constant FDCAN3_S_FDCAN_CCU_CREL  \ offset: 0x00 : FDCAN core release register
$5000e804 constant FDCAN3_S_FDCAN_ENDN  \ offset: 0x04 : FDCAN Endian register
$5000e804 constant FDCAN3_S_FDCAN_CCU_CCFG  \ offset: 0x04 : FDCAN Endian register
$5000e808 constant FDCAN3_S_FDCAN_CCU_CSTAT  \ offset: 0x08 : Calibration status register
$5000e80c constant FDCAN3_S_FDCAN_DBTP  \ offset: 0x0C : FDCAN data bit timing and prescaler register
$5000e80c constant FDCAN3_S_FDCAN_CCU_CWD  \ offset: 0x0C : FDCAN data bit timing and prescaler register
$5000e810 constant FDCAN3_S_FDCAN_TEST  \ offset: 0x10 : FDCAN test register
$5000e810 constant FDCAN3_S_FDCAN_CCU_IR  \ offset: 0x10 : FDCAN test register
$5000e814 constant FDCAN3_S_FDCAN_RWD  \ offset: 0x14 : FDCAN RAM watchdog register
$5000e814 constant FDCAN3_S_FDCAN_CCU_IE  \ offset: 0x14 : FDCAN RAM watchdog register
$5000e818 constant FDCAN3_S_FDCAN_CCCR  \ offset: 0x18 : FDCAN CC control register
$5000e81c constant FDCAN3_S_FDCAN_NBTP  \ offset: 0x1C : FDCAN nominal bit timing and prescaler register
$5000e820 constant FDCAN3_S_FDCAN_TSCC  \ offset: 0x20 : FDCAN timestamp counter configuration register
$5000e824 constant FDCAN3_S_FDCAN_TSCV  \ offset: 0x24 : FDCAN timestamp counter value register
$5000e828 constant FDCAN3_S_FDCAN_TOCC  \ offset: 0x28 : FDCAN timeout counter configuration register
$5000e82c constant FDCAN3_S_FDCAN_TOCV  \ offset: 0x2C : FDCAN timeout counter value register
$5000e840 constant FDCAN3_S_FDCAN_ECR  \ offset: 0x40 : FDCAN error counter register
$5000e844 constant FDCAN3_S_FDCAN_PSR  \ offset: 0x44 : FDCAN protocol status register
$5000e848 constant FDCAN3_S_FDCAN_TDCR  \ offset: 0x48 : FDCAN transmitter delay compensation register
$5000e850 constant FDCAN3_S_FDCAN_IR  \ offset: 0x50 : FDCAN interrupt register
$5000e854 constant FDCAN3_S_FDCAN_IE  \ offset: 0x54 : FDCAN interrupt enable register
$5000e858 constant FDCAN3_S_FDCAN_ILS  \ offset: 0x58 : FDCAN interrupt line select register
$5000e85c constant FDCAN3_S_FDCAN_ILE  \ offset: 0x5C : FDCAN interrupt line enable register
$5000e880 constant FDCAN3_S_FDCAN_GFC  \ offset: 0x80 : FDCAN global filter configuration register
$5000e884 constant FDCAN3_S_FDCAN_SIDFC  \ offset: 0x84 : FDCAN standard ID filter configuration register
$5000e888 constant FDCAN3_S_FDCAN_XIDFC  \ offset: 0x88 : FDCAN extended ID filter configuration register
$5000e890 constant FDCAN3_S_FDCAN_XIDAM  \ offset: 0x90 : FDCAN extended ID and mask register
$5000e894 constant FDCAN3_S_FDCAN_HPMS  \ offset: 0x94 : FDCAN high priority message status register
$5000e898 constant FDCAN3_S_FDCAN_NDAT1  \ offset: 0x98 : FDCAN new data 1 register
$5000e89c constant FDCAN3_S_FDCAN_NDAT2  \ offset: 0x9C : FDCAN new data 2 register
$5000e8a0 constant FDCAN3_S_FDCAN_RXF0C  \ offset: 0xA0 : FDCAN Rx FIFO 0 configuration register
$5000e8a4 constant FDCAN3_S_FDCAN_RXF0S  \ offset: 0xA4 : FDCAN Rx FIFO 0 status register
$5000e8a8 constant FDCAN3_S_FDCAN_RXF0A  \ offset: 0xA8 : FDCAN Rx FIFO 0 acknowledge register
$5000e8ac constant FDCAN3_S_FDCAN_RXBC  \ offset: 0xAC : FDCAN Rx buffer configuration register
$5000e8b0 constant FDCAN3_S_FDCAN_RXF1C  \ offset: 0xB0 : FDCAN Rx FIFO 1 configuration register
$5000e8b4 constant FDCAN3_S_FDCAN_RXF1S  \ offset: 0xB4 : FDCAN Rx FIFO 1 status register
$5000e8b8 constant FDCAN3_S_FDCAN_RXF1A  \ offset: 0xB8 : FDCAN Rx FIFO 1 acknowledge register
$5000e8bc constant FDCAN3_S_FDCAN_RXESC  \ offset: 0xBC : FDCAN Rx buffer element size configuration register
$5000e8c0 constant FDCAN3_S_FDCAN_TXBC  \ offset: 0xC0 : FDCAN Tx buffer configuration register
$5000e8c4 constant FDCAN3_S_FDCAN_TXFQS  \ offset: 0xC4 : FDCAN Tx FIFO/queue status register
$5000e8c8 constant FDCAN3_S_FDCAN_TXESC  \ offset: 0xC8 : FDCAN Tx buffer element size configuration register
$5000e8cc constant FDCAN3_S_FDCAN_TXBRP  \ offset: 0xCC : FDCAN Tx buffer request pending register
$5000e8d0 constant FDCAN3_S_FDCAN_TXBAR  \ offset: 0xD0 : FDCAN Tx buffer add request register
$5000e8d4 constant FDCAN3_S_FDCAN_TXBCR  \ offset: 0xD4 : FDCAN Tx buffer cancellation request register
$5000e8d8 constant FDCAN3_S_FDCAN_TXBTO  \ offset: 0xD8 : FDCAN Tx buffer transmission occurred register
$5000e8dc constant FDCAN3_S_FDCAN_TXBCF  \ offset: 0xDC : FDCAN Tx buffer cancellation finished register
$5000e8e0 constant FDCAN3_S_FDCAN_TXBTIE  \ offset: 0xE0 : FDCAN Tx buffer transmission interrupt enable register
$5000e8e4 constant FDCAN3_S_FDCAN_TXBCIE  \ offset: 0xE4 : FDCAN Tx buffer cancellation finished interrupt enable register
$5000e8f0 constant FDCAN3_S_FDCAN_TXEFC  \ offset: 0xF0 : FDCAN Tx event FIFO configuration register
$5000e8f4 constant FDCAN3_S_FDCAN_TXEFS  \ offset: 0xF4 : FDCAN Tx event FIFO status register
$5000e8f8 constant FDCAN3_S_FDCAN_TXEFA  \ offset: 0xF8 : FDCAN Tx event FIFO acknowledge register
$5000e900 constant FDCAN3_S_FDCAN_TTTMC  \ offset: 0x100 : FDCAN TT trigger memory configuration register
$5000e904 constant FDCAN3_S_FDCAN_TTRMC  \ offset: 0x104 : FDCAN TT reference message configuration register
$5000e908 constant FDCAN3_S_FDCAN_TTOCF  \ offset: 0x108 : FDCAN TT operation configuration register
$5000e90c constant FDCAN3_S_FDCAN_TTMLM  \ offset: 0x10C : FDCAN TT matrix limits register
$5000e910 constant FDCAN3_S_FDCAN_TURCF  \ offset: 0x110 : FDCAN TUR configuration register
$5000e914 constant FDCAN3_S_FDCAN_TTOCN  \ offset: 0x114 : FDCAN TT operation control register
$5000e918 constant FDCAN3_S_FDCAN_TTGTP  \ offset: 0x118 : FDCAN TT global time preset register
$5000e91c constant FDCAN3_S_FDCAN_TTTMK  \ offset: 0x11C : FDCAN TT time mark register
$5000e920 constant FDCAN3_S_FDCAN_TTIR  \ offset: 0x120 : FDCAN TT interrupt register
$5000e924 constant FDCAN3_S_FDCAN_TTIE  \ offset: 0x124 : FDCAN TT interrupt enable register
$5000e928 constant FDCAN3_S_FDCAN_TTILS  \ offset: 0x128 : FDCAN TT interrupt line select register
$5000e92c constant FDCAN3_S_FDCAN_TTOST  \ offset: 0x12C : FDCAN TT operation status register
$5000e930 constant FDCAN3_S_FDCAN_TURNA  \ offset: 0x130 : FDCAN TUR numerator actual register
$5000e934 constant FDCAN3_S_FDCAN_TTLGT  \ offset: 0x134 : FDCAN TT local and global time register
$5000e938 constant FDCAN3_S_FDCAN_TTCTC  \ offset: 0x138 : FDCAN TT cycle time and count register
$5000e93c constant FDCAN3_S_FDCAN_TTCPT  \ offset: 0x13C : FDCAN TT capture time register
$5000e940 constant FDCAN3_S_FDCAN_TTCSM  \ offset: 0x140 : FDCAN TT cycle sync mark register
$5000eb00 constant FDCAN3_S_FDCAN_TTTS  \ offset: 0x300 : FDCAN TT trigger select register

