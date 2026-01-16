\
\ @file fdcan.fs
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

$000000ff constant FDCAN_FDCAN_CREL_DAY                             \ Timestamp Day
$0000ff00 constant FDCAN_FDCAN_CREL_MON                             \ Timestamp Month
$000f0000 constant FDCAN_FDCAN_CREL_YEAR                            \ Timestamp Year
$00f00000 constant FDCAN_FDCAN_CREL_SUBSTEP                         \ Sub-step of Core release
$0f000000 constant FDCAN_FDCAN_CREL_STEP                            \ Step of Core release
$f0000000 constant FDCAN_FDCAN_CREL_REL                             \ Core release


\
\ @brief FDCAN Core Release Register
\ Address offset: 0x04
\ Reset value: 0x87654321
\

$00000000 constant FDCAN_FDCAN_ENDN_ETV                             \ Endiannes Test Value


\
\ @brief FDCAN Data Bit Timing and Prescaler Register
\ Address offset: 0x0C
\ Reset value: 0x00000A33
\

$0000000f constant FDCAN_FDCAN_DBTP_DSJW                            \ Synchronization Jump Width
$000000f0 constant FDCAN_FDCAN_DBTP_DTSEG2                          \ Data time segment after sample point
$00001f00 constant FDCAN_FDCAN_DBTP_DTSEG1                          \ Data time segment after sample point
$001f0000 constant FDCAN_FDCAN_DBTP_DBRP                            \ Data BIt Rate Prescaler
$00800000 constant FDCAN_FDCAN_DBTP_TDC                             \ Transceiver Delay Compensation


\
\ @brief FDCAN Test Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000010 constant FDCAN_FDCAN_TEST_LBCK                            \ Loop Back mode
$00000060 constant FDCAN_FDCAN_TEST_TX                              \ Loop Back mode
$00000080 constant FDCAN_FDCAN_TEST_RX                              \ Control of Transmit Pin


\
\ @brief FDCAN RAM Watchdog Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant FDCAN_FDCAN_RWD_WDC                              \ Watchdog configuration
$0000ff00 constant FDCAN_FDCAN_RWD_WDV                              \ Watchdog value


\
\ @brief FDCAN CC Control Register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant FDCAN_FDCAN_CCCR_INIT                            \ Initialization
$00000002 constant FDCAN_FDCAN_CCCR_CCE                             \ Configuration Change Enable
$00000004 constant FDCAN_FDCAN_CCCR_ASM                             \ ASM Restricted Operation Mode
$00000008 constant FDCAN_FDCAN_CCCR_CSA                             \ Clock Stop Acknowledge
$00000010 constant FDCAN_FDCAN_CCCR_CSR                             \ Clock Stop Request
$00000020 constant FDCAN_FDCAN_CCCR_MON                             \ Bus Monitoring Mode
$00000040 constant FDCAN_FDCAN_CCCR_DAR                             \ Disable Automatic Retransmission
$00000080 constant FDCAN_FDCAN_CCCR_TEST                            \ Test Mode Enable
$00000100 constant FDCAN_FDCAN_CCCR_FDOE                            \ FD Operation Enable
$00000200 constant FDCAN_FDCAN_CCCR_BSE                             \ FDCAN Bit Rate Switching
$00001000 constant FDCAN_FDCAN_CCCR_PXHD                            \ Protocol Exception Handling Disable
$00002000 constant FDCAN_FDCAN_CCCR_EFBI                            \ Edge Filtering during Bus Integration
$00004000 constant FDCAN_FDCAN_CCCR_TXP                             \ TXP
$00008000 constant FDCAN_FDCAN_CCCR_NISO                            \ Non ISO Operation


\
\ @brief FDCAN Nominal Bit Timing and Prescaler Register
\ Address offset: 0x1C
\ Reset value: 0x00000A33
\

$0000007f constant FDCAN_FDCAN_NBTP_TSEG2                           \ Nominal Time segment after sample point
$0000ff00 constant FDCAN_FDCAN_NBTP_NTSEG1                          \ Nominal Time segment before sample point
$01ff0000 constant FDCAN_FDCAN_NBTP_NBRP                            \ Bit Rate Prescaler
$fe000000 constant FDCAN_FDCAN_NBTP_NSJW                            \ NSJW: Nominal (Re)Synchronization Jump Width


\
\ @brief FDCAN Timestamp Counter Configuration Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant FDCAN_FDCAN_TSCC_TSS                             \ Timestamp Select
$000f0000 constant FDCAN_FDCAN_TSCC_TCP                             \ Timestamp Counter Prescaler


\
\ @brief FDCAN Timestamp Counter Value Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN_FDCAN_TSCV_TSC                             \ Timestamp Counter


\
\ @brief FDCAN Timeout Counter Configuration Register
\ Address offset: 0x28
\ Reset value: 0xFFFF0000
\

$00000001 constant FDCAN_FDCAN_TOCC_ETOC                            \ Enable Timeout Counter
$00000006 constant FDCAN_FDCAN_TOCC_TOS                             \ Timeout Select
$ffff0000 constant FDCAN_FDCAN_TOCC_TOP                             \ Timeout Period


\
\ @brief FDCAN Timeout Counter Value Register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant FDCAN_FDCAN_TOCV_TOC                             \ Timeout Counter


\
\ @brief FDCAN Error Counter Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant FDCAN_FDCAN_ECR_TEC                              \ Transmit Error Counter
$00007f00 constant FDCAN_FDCAN_ECR_TREC                             \ Receive Error Counter
$00008000 constant FDCAN_FDCAN_ECR_RP                               \ Receive Error Passive
$00ff0000 constant FDCAN_FDCAN_ECR_CEL                              \ AN Error Logging


\
\ @brief FDCAN Protocol Status Register
\ Address offset: 0x44
\ Reset value: 0x00000707
\

$00000007 constant FDCAN_FDCAN_PSR_LEC                              \ Last Error Code
$00000018 constant FDCAN_FDCAN_PSR_ACT                              \ Activity
$00000020 constant FDCAN_FDCAN_PSR_EP                               \ Error Passive
$00000040 constant FDCAN_FDCAN_PSR_EW                               \ Warning Status
$00000080 constant FDCAN_FDCAN_PSR_BO                               \ Bus_Off Status
$00000700 constant FDCAN_FDCAN_PSR_DLEC                             \ Data Last Error Code
$00000800 constant FDCAN_FDCAN_PSR_RESI                             \ ESI flag of last received FDCAN Message
$00001000 constant FDCAN_FDCAN_PSR_RBRS                             \ BRS flag of last received FDCAN Message
$00002000 constant FDCAN_FDCAN_PSR_REDL                             \ Received FDCAN Message
$00004000 constant FDCAN_FDCAN_PSR_PXE                              \ Protocol Exception Event
$007f0000 constant FDCAN_FDCAN_PSR_TDCV                             \ Transmitter Delay Compensation Value


\
\ @brief FDCAN Transmitter Delay Compensation Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant FDCAN_FDCAN_TDCR_TDCF                            \ Transmitter Delay Compensation Filter Window Length
$00007f00 constant FDCAN_FDCAN_TDCR_TDCO                            \ Transmitter Delay Compensation Offset


\
\ @brief FDCAN Interrupt Register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_IR_RF0N                              \ Rx FIFO 0 New Message
$00000002 constant FDCAN_FDCAN_IR_RF0W                              \ Rx FIFO 0 Full
$00000004 constant FDCAN_FDCAN_IR_RF0F                              \ Rx FIFO 0 Full
$00000008 constant FDCAN_FDCAN_IR_RF0L                              \ Rx FIFO 0 Message Lost
$00000010 constant FDCAN_FDCAN_IR_RF1N                              \ Rx FIFO 1 New Message
$00000020 constant FDCAN_FDCAN_IR_RF1W                              \ Rx FIFO 1 Watermark Reached
$00000040 constant FDCAN_FDCAN_IR_RF1F                              \ Rx FIFO 1 Watermark Reached
$00000080 constant FDCAN_FDCAN_IR_RF1L                              \ Rx FIFO 1 Message Lost
$00000100 constant FDCAN_FDCAN_IR_HPM                               \ High Priority Message
$00000200 constant FDCAN_FDCAN_IR_TC                                \ Transmission Completed
$00000400 constant FDCAN_FDCAN_IR_TCF                               \ Transmission Cancellation Finished
$00000800 constant FDCAN_FDCAN_IR_TEF                               \ Tx FIFO Empty
$00001000 constant FDCAN_FDCAN_IR_TEFN                              \ Tx Event FIFO New Entry
$00002000 constant FDCAN_FDCAN_IR_TEFW                              \ Tx Event FIFO Watermark Reached
$00004000 constant FDCAN_FDCAN_IR_TEFF                              \ Tx Event FIFO Full
$00008000 constant FDCAN_FDCAN_IR_TEFL                              \ Tx Event FIFO Element Lost
$00010000 constant FDCAN_FDCAN_IR_TSW                               \ Timestamp Wraparound
$00020000 constant FDCAN_FDCAN_IR_MRAF                              \ Message RAM Access Failure
$00040000 constant FDCAN_FDCAN_IR_TOO                               \ Timeout Occurred
$00080000 constant FDCAN_FDCAN_IR_DRX                               \ Message stored to Dedicated Rx Buffer
$00400000 constant FDCAN_FDCAN_IR_ELO                               \ Error Logging Overflow
$00800000 constant FDCAN_FDCAN_IR_EP                                \ Error Passive
$01000000 constant FDCAN_FDCAN_IR_EW                                \ Warning Status
$02000000 constant FDCAN_FDCAN_IR_BO                                \ Bus_Off Status
$04000000 constant FDCAN_FDCAN_IR_WDI                               \ Watchdog Interrupt
$08000000 constant FDCAN_FDCAN_IR_PEA                               \ Protocol Error in Arbitration Phase (Nominal Bit Time is used)
$10000000 constant FDCAN_FDCAN_IR_PED                               \ Protocol Error in Data Phase (Data Bit Time is used)
$20000000 constant FDCAN_FDCAN_IR_ARA                               \ Access to Reserved Address


\
\ @brief FDCAN Interrupt Enable Register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_IE_RF0NE                             \ Rx FIFO 0 New Message Enable
$00000002 constant FDCAN_FDCAN_IE_RF0WE                             \ Rx FIFO 0 Full Enable
$00000004 constant FDCAN_FDCAN_IE_RF0FE                             \ Rx FIFO 0 Full Enable
$00000008 constant FDCAN_FDCAN_IE_RF0LE                             \ Rx FIFO 0 Message Lost Enable
$00000010 constant FDCAN_FDCAN_IE_RF1NE                             \ Rx FIFO 1 New Message Enable
$00000020 constant FDCAN_FDCAN_IE_RF1WE                             \ Rx FIFO 1 Watermark Reached Enable
$00000040 constant FDCAN_FDCAN_IE_RF1FE                             \ Rx FIFO 1 Watermark Reached Enable
$00000080 constant FDCAN_FDCAN_IE_RF1LE                             \ Rx FIFO 1 Message Lost Enable
$00000100 constant FDCAN_FDCAN_IE_HPME                              \ High Priority Message Enable
$00000200 constant FDCAN_FDCAN_IE_TCE                               \ Transmission Completed Enable
$00000400 constant FDCAN_FDCAN_IE_TCFE                              \ Transmission Cancellation Finished Enable
$00000800 constant FDCAN_FDCAN_IE_TEFE                              \ Tx FIFO Empty Enable
$00001000 constant FDCAN_FDCAN_IE_TEFNE                             \ Tx Event FIFO New Entry Enable
$00002000 constant FDCAN_FDCAN_IE_TEFWE                             \ Tx Event FIFO Watermark Reached Enable
$00004000 constant FDCAN_FDCAN_IE_TEFFE                             \ Tx Event FIFO Full Enable
$00008000 constant FDCAN_FDCAN_IE_TEFLE                             \ Tx Event FIFO Element Lost Enable
$00010000 constant FDCAN_FDCAN_IE_TSWE                              \ Timestamp Wraparound Enable
$00020000 constant FDCAN_FDCAN_IE_MRAFE                             \ Message RAM Access Failure Enable
$00040000 constant FDCAN_FDCAN_IE_TOOE                              \ Timeout Occurred Enable
$00080000 constant FDCAN_FDCAN_IE_DRXE                              \ Message stored to Dedicated Rx Buffer Enable
$00100000 constant FDCAN_FDCAN_IE_BECE                              \ Bit Error Corrected Interrupt Enable
$00200000 constant FDCAN_FDCAN_IE_BEUE                              \ Bit Error Uncorrected Interrupt Enable
$00400000 constant FDCAN_FDCAN_IE_ELOE                              \ Error Logging Overflow Enable
$00800000 constant FDCAN_FDCAN_IE_EPE                               \ Error Passive Enable
$01000000 constant FDCAN_FDCAN_IE_EWE                               \ Warning Status Enable
$02000000 constant FDCAN_FDCAN_IE_BOE                               \ Bus_Off Status Enable
$04000000 constant FDCAN_FDCAN_IE_WDIE                              \ Watchdog Interrupt Enable
$08000000 constant FDCAN_FDCAN_IE_PEAE                              \ Protocol Error in Arbitration Phase Enable
$10000000 constant FDCAN_FDCAN_IE_PEDE                              \ Protocol Error in Data Phase Enable
$20000000 constant FDCAN_FDCAN_IE_ARAE                              \ Access to Reserved Address Enable


\
\ @brief FDCAN Interrupt Line Select Register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_ILS_RF0NL                            \ Rx FIFO 0 New Message Interrupt Line
$00000002 constant FDCAN_FDCAN_ILS_RF0WL                            \ Rx FIFO 0 Watermark Reached Interrupt Line
$00000004 constant FDCAN_FDCAN_ILS_RF0FL                            \ Rx FIFO 0 Full Interrupt Line
$00000008 constant FDCAN_FDCAN_ILS_RF0LL                            \ Rx FIFO 0 Message Lost Interrupt Line
$00000010 constant FDCAN_FDCAN_ILS_RF1NL                            \ Rx FIFO 1 New Message Interrupt Line
$00000020 constant FDCAN_FDCAN_ILS_RF1WL                            \ Rx FIFO 1 Watermark Reached Interrupt Line
$00000040 constant FDCAN_FDCAN_ILS_RF1FL                            \ Rx FIFO 1 Full Interrupt Line
$00000080 constant FDCAN_FDCAN_ILS_RF1LL                            \ Rx FIFO 1 Message Lost Interrupt Line
$00000100 constant FDCAN_FDCAN_ILS_HPML                             \ High Priority Message Interrupt Line
$00000200 constant FDCAN_FDCAN_ILS_TCL                              \ Transmission Completed Interrupt Line
$00000400 constant FDCAN_FDCAN_ILS_TCFL                             \ Transmission Cancellation Finished Interrupt Line
$00000800 constant FDCAN_FDCAN_ILS_TEFL                             \ Tx FIFO Empty Interrupt Line
$00001000 constant FDCAN_FDCAN_ILS_TEFNL                            \ Tx Event FIFO New Entry Interrupt Line
$00002000 constant FDCAN_FDCAN_ILS_TEFWL                            \ Tx Event FIFO Watermark Reached Interrupt Line
$00004000 constant FDCAN_FDCAN_ILS_TEFFL                            \ Tx Event FIFO Full Interrupt Line
$00008000 constant FDCAN_FDCAN_ILS_TEFLL                            \ Tx Event FIFO Element Lost Interrupt Line
$00010000 constant FDCAN_FDCAN_ILS_TSWL                             \ Timestamp Wraparound Interrupt Line
$00020000 constant FDCAN_FDCAN_ILS_MRAFL                            \ Message RAM Access Failure Interrupt Line
$00040000 constant FDCAN_FDCAN_ILS_TOOL                             \ Timeout Occurred Interrupt Line
$00080000 constant FDCAN_FDCAN_ILS_DRXL                             \ Message stored to Dedicated Rx Buffer Interrupt Line
$00100000 constant FDCAN_FDCAN_ILS_BECL                             \ Bit Error Corrected Interrupt Line
$00200000 constant FDCAN_FDCAN_ILS_BEUL                             \ Bit Error Uncorrected Interrupt Line
$00400000 constant FDCAN_FDCAN_ILS_ELOL                             \ Error Logging Overflow Interrupt Line
$00800000 constant FDCAN_FDCAN_ILS_EPL                              \ Error Passive Interrupt Line
$01000000 constant FDCAN_FDCAN_ILS_EWL                              \ Warning Status Interrupt Line
$02000000 constant FDCAN_FDCAN_ILS_BOL                              \ Bus_Off Status
$04000000 constant FDCAN_FDCAN_ILS_WDIL                             \ Watchdog Interrupt Line
$08000000 constant FDCAN_FDCAN_ILS_PEAL                             \ Protocol Error in Arbitration Phase Line
$10000000 constant FDCAN_FDCAN_ILS_PEDL                             \ Protocol Error in Data Phase Line
$20000000 constant FDCAN_FDCAN_ILS_ARAL                             \ Access to Reserved Address Line


\
\ @brief FDCAN Interrupt Line Enable Register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_ILE_EINT0                            \ Enable Interrupt Line 0
$00000002 constant FDCAN_FDCAN_ILE_EINT1                            \ Enable Interrupt Line 1


\
\ @brief FDCAN Global Filter Configuration Register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_GFC_RRFE                             \ Reject Remote Frames Extended
$00000002 constant FDCAN_FDCAN_GFC_RRFS                             \ Reject Remote Frames Standard
$0000000c constant FDCAN_FDCAN_GFC_ANFE                             \ Accept Non-matching Frames Extended
$00000030 constant FDCAN_FDCAN_GFC_ANFS                             \ Accept Non-matching Frames Standard


\
\ @brief FDCAN Standard ID Filter Configuration Register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN_FDCAN_SIDFC_FLSSA                          \ Filter List Standard Start Address
$00ff0000 constant FDCAN_FDCAN_SIDFC_LSS                            \ List Size Standard


\
\ @brief FDCAN Extended ID Filter Configuration Register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN_FDCAN_XIDFC_FLESA                          \ Filter List Standard Start Address
$00ff0000 constant FDCAN_FDCAN_XIDFC_LSE                            \ List Size Extended


\
\ @brief FDCAN Extended ID and Mask Register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$1fffffff constant FDCAN_FDCAN_XIDAM_EIDM                           \ Extended ID Mask


\
\ @brief FDCAN High Priority Message Status Register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000003f constant FDCAN_FDCAN_HPMS_BIDX                            \ Buffer Index
$000000c0 constant FDCAN_FDCAN_HPMS_MSI                             \ Message Storage Indicator
$00007f00 constant FDCAN_FDCAN_HPMS_FIDX                            \ Filter Index
$00008000 constant FDCAN_FDCAN_HPMS_FLST                            \ Filter List


\
\ @brief FDCAN New Data 1 Register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_NDAT1_ND0                            \ New data
$00000002 constant FDCAN_FDCAN_NDAT1_ND1                            \ New data
$00000004 constant FDCAN_FDCAN_NDAT1_ND2                            \ New data
$00000008 constant FDCAN_FDCAN_NDAT1_ND3                            \ New data
$00000010 constant FDCAN_FDCAN_NDAT1_ND4                            \ New data
$00000020 constant FDCAN_FDCAN_NDAT1_ND5                            \ New data
$00000040 constant FDCAN_FDCAN_NDAT1_ND6                            \ New data
$00000080 constant FDCAN_FDCAN_NDAT1_ND7                            \ New data
$00000100 constant FDCAN_FDCAN_NDAT1_ND8                            \ New data
$00000200 constant FDCAN_FDCAN_NDAT1_ND9                            \ New data
$00000400 constant FDCAN_FDCAN_NDAT1_ND10                           \ New data
$00000800 constant FDCAN_FDCAN_NDAT1_ND11                           \ New data
$00001000 constant FDCAN_FDCAN_NDAT1_ND12                           \ New data
$00002000 constant FDCAN_FDCAN_NDAT1_ND13                           \ New data
$00004000 constant FDCAN_FDCAN_NDAT1_ND14                           \ New data
$00008000 constant FDCAN_FDCAN_NDAT1_ND15                           \ New data
$00010000 constant FDCAN_FDCAN_NDAT1_ND16                           \ New data
$00020000 constant FDCAN_FDCAN_NDAT1_ND17                           \ New data
$00040000 constant FDCAN_FDCAN_NDAT1_ND18                           \ New data
$00080000 constant FDCAN_FDCAN_NDAT1_ND19                           \ New data
$00100000 constant FDCAN_FDCAN_NDAT1_ND20                           \ New data
$00200000 constant FDCAN_FDCAN_NDAT1_ND21                           \ New data
$00400000 constant FDCAN_FDCAN_NDAT1_ND22                           \ New data
$00800000 constant FDCAN_FDCAN_NDAT1_ND23                           \ New data
$01000000 constant FDCAN_FDCAN_NDAT1_ND24                           \ New data
$02000000 constant FDCAN_FDCAN_NDAT1_ND25                           \ New data
$04000000 constant FDCAN_FDCAN_NDAT1_ND26                           \ New data
$08000000 constant FDCAN_FDCAN_NDAT1_ND27                           \ New data
$10000000 constant FDCAN_FDCAN_NDAT1_ND28                           \ New data
$20000000 constant FDCAN_FDCAN_NDAT1_ND29                           \ New data
$40000000 constant FDCAN_FDCAN_NDAT1_ND30                           \ New data
$80000000 constant FDCAN_FDCAN_NDAT1_ND31                           \ New data


\
\ @brief FDCAN New Data 2 Register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_NDAT2_ND32                           \ New data
$00000002 constant FDCAN_FDCAN_NDAT2_ND33                           \ New data
$00000004 constant FDCAN_FDCAN_NDAT2_ND34                           \ New data
$00000008 constant FDCAN_FDCAN_NDAT2_ND35                           \ New data
$00000010 constant FDCAN_FDCAN_NDAT2_ND36                           \ New data
$00000020 constant FDCAN_FDCAN_NDAT2_ND37                           \ New data
$00000040 constant FDCAN_FDCAN_NDAT2_ND38                           \ New data
$00000080 constant FDCAN_FDCAN_NDAT2_ND39                           \ New data
$00000100 constant FDCAN_FDCAN_NDAT2_ND40                           \ New data
$00000200 constant FDCAN_FDCAN_NDAT2_ND41                           \ New data
$00000400 constant FDCAN_FDCAN_NDAT2_ND42                           \ New data
$00000800 constant FDCAN_FDCAN_NDAT2_ND43                           \ New data
$00001000 constant FDCAN_FDCAN_NDAT2_ND44                           \ New data
$00002000 constant FDCAN_FDCAN_NDAT2_ND45                           \ New data
$00004000 constant FDCAN_FDCAN_NDAT2_ND46                           \ New data
$00008000 constant FDCAN_FDCAN_NDAT2_ND47                           \ New data
$00010000 constant FDCAN_FDCAN_NDAT2_ND48                           \ New data
$00020000 constant FDCAN_FDCAN_NDAT2_ND49                           \ New data
$00040000 constant FDCAN_FDCAN_NDAT2_ND50                           \ New data
$00080000 constant FDCAN_FDCAN_NDAT2_ND51                           \ New data
$00100000 constant FDCAN_FDCAN_NDAT2_ND52                           \ New data
$00200000 constant FDCAN_FDCAN_NDAT2_ND53                           \ New data
$00400000 constant FDCAN_FDCAN_NDAT2_ND54                           \ New data
$00800000 constant FDCAN_FDCAN_NDAT2_ND55                           \ New data
$01000000 constant FDCAN_FDCAN_NDAT2_ND56                           \ New data
$02000000 constant FDCAN_FDCAN_NDAT2_ND57                           \ New data
$04000000 constant FDCAN_FDCAN_NDAT2_ND58                           \ New data
$08000000 constant FDCAN_FDCAN_NDAT2_ND59                           \ New data
$10000000 constant FDCAN_FDCAN_NDAT2_ND60                           \ New data
$20000000 constant FDCAN_FDCAN_NDAT2_ND61                           \ New data
$40000000 constant FDCAN_FDCAN_NDAT2_ND62                           \ New data
$80000000 constant FDCAN_FDCAN_NDAT2_ND63                           \ New data


\
\ @brief FDCAN Rx FIFO 0 Configuration Register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN_FDCAN_RXF0C_F0SA                           \ Rx FIFO 0 Start Address
$00ff0000 constant FDCAN_FDCAN_RXF0C_F0S                            \ Rx FIFO 0 Size
$ff000000 constant FDCAN_FDCAN_RXF0C_F0WM                           \ FIFO 0 Watermark


\
\ @brief FDCAN Rx FIFO 0 Status Register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000007f constant FDCAN_FDCAN_RXF0S_F0FL                           \ Rx FIFO 0 Fill Level
$00003f00 constant FDCAN_FDCAN_RXF0S_F0G                            \ Rx FIFO 0 Get Index
$003f0000 constant FDCAN_FDCAN_RXF0S_F0P                            \ Rx FIFO 0 Put Index
$01000000 constant FDCAN_FDCAN_RXF0S_F0F                            \ Rx FIFO 0 Full
$02000000 constant FDCAN_FDCAN_RXF0S_RF0L                           \ Rx FIFO 0 Message Lost


\
\ @brief CAN Rx FIFO 0 Acknowledge Register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000003f constant FDCAN_FDCAN_RXF0A_FA01                           \ Rx FIFO 0 Acknowledge Index


\
\ @brief FDCAN Rx Buffer Configuration Register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN_FDCAN_RXBC_RBSA                            \ Rx Buffer Start Address


\
\ @brief FDCAN Rx FIFO 1 Configuration Register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN_FDCAN_RXF1C_F1SA                           \ Rx FIFO 1 Start Address
$007f0000 constant FDCAN_FDCAN_RXF1C_F1S                            \ Rx FIFO 1 Size
$7f000000 constant FDCAN_FDCAN_RXF1C_F1WM                           \ Rx FIFO 1 Watermark


\
\ @brief FDCAN Rx FIFO 1 Status Register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant FDCAN_FDCAN_RXF1S_F1FL                           \ Rx FIFO 1 Fill Level
$00007f00 constant FDCAN_FDCAN_RXF1S_F1GI                           \ Rx FIFO 1 Get Index
$007f0000 constant FDCAN_FDCAN_RXF1S_F1PI                           \ Rx FIFO 1 Put Index
$01000000 constant FDCAN_FDCAN_RXF1S_F1F                            \ Rx FIFO 1 Full
$02000000 constant FDCAN_FDCAN_RXF1S_RF1L                           \ Rx FIFO 1 Message Lost
$c0000000 constant FDCAN_FDCAN_RXF1S_DMS                            \ Debug Message Status


\
\ @brief FDCAN Rx FIFO 1 Acknowledge Register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$0000003f constant FDCAN_FDCAN_RXF1A_F1AI                           \ Rx FIFO 1 Acknowledge Index


\
\ @brief FDCAN Rx Buffer Element Size Configuration Register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_RXESC_F0DS                           \ Rx FIFO 1 Data Field Size:
$00000070 constant FDCAN_FDCAN_RXESC_F1DS                           \ Rx FIFO 0 Data Field Size:
$00000700 constant FDCAN_FDCAN_RXESC_RBDS                           \ Rx Buffer Data Field Size:


\
\ @brief FDCAN Tx Buffer Configuration Register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN_FDCAN_TXBC_TBSA                            \ Tx Buffers Start Address
$003f0000 constant FDCAN_FDCAN_TXBC_NDTB                            \ Number of Dedicated Transmit Buffers
$3f000000 constant FDCAN_FDCAN_TXBC_TFQS                            \ Transmit FIFO/Queue Size
$40000000 constant FDCAN_FDCAN_TXBC_TFQM                            \ Tx FIFO/Queue Mode


\
\ @brief FDCAN Tx FIFO/Queue Status Register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$0000003f constant FDCAN_FDCAN_TXFQS_TFFL                           \ Tx FIFO Free Level
$00001f00 constant FDCAN_FDCAN_TXFQS_TFGI                           \ TFGI
$001f0000 constant FDCAN_FDCAN_TXFQS_TFQPI                          \ Tx FIFO/Queue Put Index
$00200000 constant FDCAN_FDCAN_TXFQS_TFQF                           \ Tx FIFO/Queue Full


\
\ @brief FDCAN Tx Buffer Element Size Configuration Register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000007 constant FDCAN_FDCAN_TXESC_TBDS                           \ Tx Buffer Data Field Size:


\
\ @brief FDCAN Tx Buffer Request Pending Register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant FDCAN_FDCAN_TXBRP_TRP                            \ Transmission Request Pending


\
\ @brief FDCAN Tx Buffer Add Request Register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant FDCAN_FDCAN_TXBAR_AR                             \ Add Request


\
\ @brief FDCAN Tx Buffer Cancellation Request Register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000000 constant FDCAN_FDCAN_TXBCR_CR                             \ Cancellation Request


\
\ @brief FDCAN Tx Buffer Transmission Occurred Register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000000 constant FDCAN_FDCAN_TXBTO_TO                             \ Transmission Occurred.


\
\ @brief FDCAN Tx Buffer Cancellation Finished Register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000000 constant FDCAN_FDCAN_TXBCF_CF                             \ Cancellation Finished


\
\ @brief FDCAN Tx Buffer Transmission Interrupt Enable Register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000000 constant FDCAN_FDCAN_TXBTIE_TIE                           \ Transmission Interrupt Enable


\
\ @brief FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000000 constant FDCAN_FDCAN_TXBCIE_CF                            \ Cancellation Finished Interrupt Enable


\
\ @brief FDCAN Tx Event FIFO Configuration Register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN_FDCAN_TXEFC_EFSA                           \ Event FIFO Start Address
$003f0000 constant FDCAN_FDCAN_TXEFC_EFS                            \ Event FIFO Size
$3f000000 constant FDCAN_FDCAN_TXEFC_EFWM                           \ Event FIFO Watermark


\
\ @brief FDCAN Tx Event FIFO Status Register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$0000003f constant FDCAN_FDCAN_TXEFS_EFFL                           \ Event FIFO Fill Level
$00001f00 constant FDCAN_FDCAN_TXEFS_EFGI                           \ Event FIFO Get Index.
$001f0000 constant FDCAN_FDCAN_TXEFS_EFPI                           \ Event FIFO put index.
$01000000 constant FDCAN_FDCAN_TXEFS_EFF                            \ Event FIFO Full.
$02000000 constant FDCAN_FDCAN_TXEFS_TEFL                           \ Tx Event FIFO Element Lost.


\
\ @brief FDCAN Tx Event FIFO Acknowledge Register
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$0000001f constant FDCAN_FDCAN_TXEFA_EFAI                           \ Event FIFO Acknowledge Index


\
\ @brief FDCAN TT Trigger Memory Configuration Register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000fffc constant FDCAN_FDCAN_TTTMC_TMSA                           \ Trigger Memory Start Address
$007f0000 constant FDCAN_FDCAN_TTTMC_TME                            \ Trigger Memory Elements


\
\ @brief FDCAN TT Reference Message Configuration Register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$1fffffff constant FDCAN_FDCAN_TTRMC_RID                            \ Reference Identifier.
$40000000 constant FDCAN_FDCAN_TTRMC_XTD                            \ Extended Identifier
$80000000 constant FDCAN_FDCAN_TTRMC_RMPS                           \ Reference Message Payload Select


\
\ @brief FDCAN TT Operation Configuration Register
\ Address offset: 0x108
\ Reset value: 0x00010000
\

$00000003 constant FDCAN_FDCAN_TTOCF_OM                             \ Operation Mode
$00000008 constant FDCAN_FDCAN_TTOCF_GEN                            \ Gap Enable
$00000010 constant FDCAN_FDCAN_TTOCF_TM                             \ Time Master
$000000e0 constant FDCAN_FDCAN_TTOCF_LDSDL                          \ LD of Synchronization Deviation Limit
$00007f00 constant FDCAN_FDCAN_TTOCF_IRTO                           \ Initial Reference Trigger Offset
$00008000 constant FDCAN_FDCAN_TTOCF_EECS                           \ Enable External Clock Synchronization
$00ff0000 constant FDCAN_FDCAN_TTOCF_AWL                            \ Application Watchdog Limit
$01000000 constant FDCAN_FDCAN_TTOCF_EGTF                           \ Enable Global Time Filtering
$02000000 constant FDCAN_FDCAN_TTOCF_ECC                            \ Enable Clock Calibration
$04000000 constant FDCAN_FDCAN_TTOCF_EVTP                           \ Event Trigger Polarity


\
\ @brief FDCAN TT Matrix Limits Register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000003f constant FDCAN_FDCAN_TTMLM_CCM                            \ Cycle Count Max
$000000c0 constant FDCAN_FDCAN_TTMLM_CSS                            \ Cycle Start Synchronization
$00000f00 constant FDCAN_FDCAN_TTMLM_TXEW                           \ Tx Enable Window
$0fff0000 constant FDCAN_FDCAN_TTMLM_ENTT                           \ Expected Number of Tx Triggers


\
\ @brief FDCAN TUR Configuration Register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN_FDCAN_TURCF_NCL                            \ Numerator Configuration Low.
$3fff0000 constant FDCAN_FDCAN_TURCF_DC                             \ Denominator Configuration.
$80000000 constant FDCAN_FDCAN_TURCF_ELT                            \ Enable Local Time


\
\ @brief FDCAN TT Operation Control Register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_TTOCN_SGT                            \ Set Global time
$00000002 constant FDCAN_FDCAN_TTOCN_ECS                            \ External Clock Synchronization
$00000004 constant FDCAN_FDCAN_TTOCN_SWP                            \ Stop Watch Polarity
$00000018 constant FDCAN_FDCAN_TTOCN_SWS                            \ Stop Watch Source.
$00000020 constant FDCAN_FDCAN_TTOCN_RTIE                           \ Register Time Mark Interrupt Pulse Enable
$000000c0 constant FDCAN_FDCAN_TTOCN_TMC                            \ Register Time Mark Compare
$00000100 constant FDCAN_FDCAN_TTOCN_TTIE                           \ Trigger Time Mark Interrupt Pulse Enable
$00000200 constant FDCAN_FDCAN_TTOCN_GCS                            \ Gap Control Select
$00000400 constant FDCAN_FDCAN_TTOCN_FGP                            \ Finish Gap.
$00000800 constant FDCAN_FDCAN_TTOCN_TMG                            \ Time Mark Gap
$00001000 constant FDCAN_FDCAN_TTOCN_NIG                            \ Next is Gap
$00002000 constant FDCAN_FDCAN_TTOCN_ESCN                           \ External Synchronization Control
$00008000 constant FDCAN_FDCAN_TTOCN_LCKC                           \ TT Operation Control Register Locked


\
\ @brief FDCAN TT Global Time Preset Register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN_CAN_TTGTP_NCL                              \ Time Preset
$ffff0000 constant FDCAN_CAN_TTGTP_CTP                              \ Cycle Time Target Phase


\
\ @brief FDCAN TT Time Mark Register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN_FDCAN_TTTMK_TM                             \ Time Mark
$007f0000 constant FDCAN_FDCAN_TTTMK_TICC                           \ Time Mark Cycle Code
$80000000 constant FDCAN_FDCAN_TTTMK_LCKM                           \ TT Time Mark Register Locked


\
\ @brief FDCAN TT Interrupt Register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_TTIR_SBC                             \ Start of Basic Cycle
$00000002 constant FDCAN_FDCAN_TTIR_SMC                             \ Start of Matrix Cycle
$00000004 constant FDCAN_FDCAN_TTIR_CSM                             \ Change of Synchronization Mode
$00000008 constant FDCAN_FDCAN_TTIR_SOG                             \ Start of Gap
$00000010 constant FDCAN_FDCAN_TTIR_RTMI                            \ Register Time Mark Interrupt.
$00000020 constant FDCAN_FDCAN_TTIR_TTMI                            \ Trigger Time Mark Event Internal
$00000040 constant FDCAN_FDCAN_TTIR_SWE                             \ Stop Watch Event
$00000080 constant FDCAN_FDCAN_TTIR_GTW                             \ Global Time Wrap
$00000100 constant FDCAN_FDCAN_TTIR_GTD                             \ Global Time Discontinuity
$00000200 constant FDCAN_FDCAN_TTIR_GTE                             \ Global Time Error
$00000400 constant FDCAN_FDCAN_TTIR_TXU                             \ Tx Count Underflow
$00000800 constant FDCAN_FDCAN_TTIR_TXO                             \ Tx Count Overflow
$00001000 constant FDCAN_FDCAN_TTIR_SE1                             \ Scheduling Error 1
$00002000 constant FDCAN_FDCAN_TTIR_SE2                             \ Scheduling Error 2
$00004000 constant FDCAN_FDCAN_TTIR_ELC                             \ Error Level Changed.
$00008000 constant FDCAN_FDCAN_TTIR_IWTG                            \ Initialization Watch Trigger
$00010000 constant FDCAN_FDCAN_TTIR_WT                              \ Watch Trigger
$00020000 constant FDCAN_FDCAN_TTIR_AW                              \ Application Watchdog
$00040000 constant FDCAN_FDCAN_TTIR_CER                             \ Configuration Error


\
\ @brief FDCAN TT Interrupt Enable Register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_TTIE_SBCE                            \ Start of Basic Cycle Interrupt Enable
$00000002 constant FDCAN_FDCAN_TTIE_SMCE                            \ Start of Matrix Cycle Interrupt Enable
$00000004 constant FDCAN_FDCAN_TTIE_CSME                            \ Change of Synchronization Mode Interrupt Enable
$00000008 constant FDCAN_FDCAN_TTIE_SOGE                            \ Start of Gap Interrupt Enable
$00000010 constant FDCAN_FDCAN_TTIE_RTMIE                           \ Register Time Mark Interrupt Enable
$00000020 constant FDCAN_FDCAN_TTIE_TTMIE                           \ Trigger Time Mark Event Internal Interrupt Enable
$00000040 constant FDCAN_FDCAN_TTIE_SWEE                            \ Stop Watch Event Interrupt Enable
$00000080 constant FDCAN_FDCAN_TTIE_GTWE                            \ Global Time Wrap Interrupt Enable
$00000100 constant FDCAN_FDCAN_TTIE_GTDE                            \ Global Time Discontinuity Interrupt Enable
$00000200 constant FDCAN_FDCAN_TTIE_GTEE                            \ Global Time Error Interrupt Enable
$00000400 constant FDCAN_FDCAN_TTIE_TXUE                            \ Tx Count Underflow Interrupt Enable
$00000800 constant FDCAN_FDCAN_TTIE_TXOE                            \ Tx Count Overflow Interrupt Enable
$00001000 constant FDCAN_FDCAN_TTIE_SE1E                            \ Scheduling Error 1 Interrupt Enable
$00002000 constant FDCAN_FDCAN_TTIE_SE2E                            \ Scheduling Error 2 Interrupt Enable
$00004000 constant FDCAN_FDCAN_TTIE_ELCE                            \ Change Error Level Interrupt Enable
$00008000 constant FDCAN_FDCAN_TTIE_IWTGE                           \ Initialization Watch Trigger Interrupt Enable
$00010000 constant FDCAN_FDCAN_TTIE_WTE                             \ Watch Trigger Interrupt Enable
$00020000 constant FDCAN_FDCAN_TTIE_AWE                             \ Application Watchdog Interrupt Enable
$00040000 constant FDCAN_FDCAN_TTIE_CERE                            \ Configuration Error Interrupt Enable


\
\ @brief FDCAN TT Interrupt Line Select Register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000001 constant FDCAN_FDCAN_TTILS_SBCL                           \ Start of Basic Cycle Interrupt Line
$00000002 constant FDCAN_FDCAN_TTILS_SMCL                           \ Start of Matrix Cycle Interrupt Line
$00000004 constant FDCAN_FDCAN_TTILS_CSML                           \ Change of Synchronization Mode Interrupt Line
$00000008 constant FDCAN_FDCAN_TTILS_SOGL                           \ Start of Gap Interrupt Line
$00000010 constant FDCAN_FDCAN_TTILS_RTMIL                          \ Register Time Mark Interrupt Line
$00000020 constant FDCAN_FDCAN_TTILS_TTMIL                          \ Trigger Time Mark Event Internal Interrupt Line
$00000040 constant FDCAN_FDCAN_TTILS_SWEL                           \ Stop Watch Event Interrupt Line
$00000080 constant FDCAN_FDCAN_TTILS_GTWL                           \ Global Time Wrap Interrupt Line
$00000100 constant FDCAN_FDCAN_TTILS_GTDL                           \ Global Time Discontinuity Interrupt Line
$00000200 constant FDCAN_FDCAN_TTILS_GTEL                           \ Global Time Error Interrupt Line
$00000400 constant FDCAN_FDCAN_TTILS_TXUL                           \ Tx Count Underflow Interrupt Line
$00000800 constant FDCAN_FDCAN_TTILS_TXOL                           \ Tx Count Overflow Interrupt Line
$00001000 constant FDCAN_FDCAN_TTILS_SE1L                           \ Scheduling Error 1 Interrupt Line
$00002000 constant FDCAN_FDCAN_TTILS_SE2L                           \ Scheduling Error 2 Interrupt Line
$00004000 constant FDCAN_FDCAN_TTILS_ELCL                           \ Change Error Level Interrupt Line
$00008000 constant FDCAN_FDCAN_TTILS_IWTGL                          \ Initialization Watch Trigger Interrupt Line
$00010000 constant FDCAN_FDCAN_TTILS_WTL                            \ Watch Trigger Interrupt Line
$00020000 constant FDCAN_FDCAN_TTILS_AWL                            \ Application Watchdog Interrupt Line
$00040000 constant FDCAN_FDCAN_TTILS_CERL                           \ Configuration Error Interrupt Line


\
\ @brief FDCAN TT Operation Status Register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000003 constant FDCAN_FDCAN_TTOST_EL                             \ Error Level
$0000000c constant FDCAN_FDCAN_TTOST_MS                             \ Master State.
$00000030 constant FDCAN_FDCAN_TTOST_SYS                            \ Synchronization State
$00000040 constant FDCAN_FDCAN_TTOST_GTP                            \ Quality of Global Time Phase
$00000080 constant FDCAN_FDCAN_TTOST_QCS                            \ Quality of Clock Speed
$0000ff00 constant FDCAN_FDCAN_TTOST_RTO                            \ Reference Trigger Offset
$00400000 constant FDCAN_FDCAN_TTOST_WGTD                           \ Wait for Global Time Discontinuity
$00800000 constant FDCAN_FDCAN_TTOST_GFI                            \ Gap Finished Indicator.
$07000000 constant FDCAN_FDCAN_TTOST_TMP                            \ Time Master Priority
$08000000 constant FDCAN_FDCAN_TTOST_GSI                            \ Gap Started Indicator.
$10000000 constant FDCAN_FDCAN_TTOST_WFE                            \ Wait for Event
$20000000 constant FDCAN_FDCAN_TTOST_AWE                            \ Application Watchdog Event
$40000000 constant FDCAN_FDCAN_TTOST_WECS                           \ Wait for External Clock Synchronization
$80000000 constant FDCAN_FDCAN_TTOST_SPL                            \ Schedule Phase Lock


\
\ @brief FDCAN TUR Numerator Actual Register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0003ffff constant FDCAN_FDCAN_TURNA_NAV                            \ Numerator Actual Value


\
\ @brief FDCAN TT Local and Global Time Register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN_FDCAN_TTLGT_LT                             \ Local Time
$ffff0000 constant FDCAN_FDCAN_TTLGT_GT                             \ Global Time


\
\ @brief FDCAN TT Cycle Time and Count Register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN_FDCAN_TTCTC_CT                             \ Cycle Time
$003f0000 constant FDCAN_FDCAN_TTCTC_CC                             \ Cycle Count


\
\ @brief FDCAN TT Capture Time Register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$0000003f constant FDCAN_FDCAN_TTCPT_CT                             \ Cycle Count Value
$ffff0000 constant FDCAN_FDCAN_TTCPT_SWV                            \ Stop Watch Value


\
\ @brief FDCAN TT Cycle Sync Mark Register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$0000ffff constant FDCAN_FDCAN_TTCSM_CSM                            \ Cycle Sync Mark


\
\ @brief FDCAN TT Trigger Select Register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000003 constant FDCAN_FDCAN_TTTS_SWTDEL                          \ Stop watch trigger input selection
$00000030 constant FDCAN_FDCAN_TTTS_EVTSEL                          \ Event trigger input selection


\
\ @brief FDCAN1
\
$4000a400 constant FDCAN_FDCAN_CREL  \ offset: 0x00 : FDCAN Core Release Register
$4000a404 constant FDCAN_FDCAN_ENDN  \ offset: 0x04 : FDCAN Core Release Register
$4000a40c constant FDCAN_FDCAN_DBTP  \ offset: 0x0C : FDCAN Data Bit Timing and Prescaler Register
$4000a410 constant FDCAN_FDCAN_TEST  \ offset: 0x10 : FDCAN Test Register
$4000a414 constant FDCAN_FDCAN_RWD  \ offset: 0x14 : FDCAN RAM Watchdog Register
$4000a418 constant FDCAN_FDCAN_CCCR  \ offset: 0x18 : FDCAN CC Control Register
$4000a41c constant FDCAN_FDCAN_NBTP  \ offset: 0x1C : FDCAN Nominal Bit Timing and Prescaler Register
$4000a420 constant FDCAN_FDCAN_TSCC  \ offset: 0x20 : FDCAN Timestamp Counter Configuration Register
$4000a424 constant FDCAN_FDCAN_TSCV  \ offset: 0x24 : FDCAN Timestamp Counter Value Register
$4000a428 constant FDCAN_FDCAN_TOCC  \ offset: 0x28 : FDCAN Timeout Counter Configuration Register
$4000a42c constant FDCAN_FDCAN_TOCV  \ offset: 0x2C : FDCAN Timeout Counter Value Register
$4000a440 constant FDCAN_FDCAN_ECR  \ offset: 0x40 : FDCAN Error Counter Register
$4000a444 constant FDCAN_FDCAN_PSR  \ offset: 0x44 : FDCAN Protocol Status Register
$4000a448 constant FDCAN_FDCAN_TDCR  \ offset: 0x48 : FDCAN Transmitter Delay Compensation Register
$4000a450 constant FDCAN_FDCAN_IR  \ offset: 0x50 : FDCAN Interrupt Register
$4000a454 constant FDCAN_FDCAN_IE  \ offset: 0x54 : FDCAN Interrupt Enable Register
$4000a458 constant FDCAN_FDCAN_ILS  \ offset: 0x58 : FDCAN Interrupt Line Select Register
$4000a45c constant FDCAN_FDCAN_ILE  \ offset: 0x5C : FDCAN Interrupt Line Enable Register
$4000a480 constant FDCAN_FDCAN_GFC  \ offset: 0x80 : FDCAN Global Filter Configuration Register
$4000a484 constant FDCAN_FDCAN_SIDFC  \ offset: 0x84 : FDCAN Standard ID Filter Configuration Register
$4000a488 constant FDCAN_FDCAN_XIDFC  \ offset: 0x88 : FDCAN Extended ID Filter Configuration Register
$4000a490 constant FDCAN_FDCAN_XIDAM  \ offset: 0x90 : FDCAN Extended ID and Mask Register
$4000a494 constant FDCAN_FDCAN_HPMS  \ offset: 0x94 : FDCAN High Priority Message Status Register
$4000a498 constant FDCAN_FDCAN_NDAT1  \ offset: 0x98 : FDCAN New Data 1 Register
$4000a49c constant FDCAN_FDCAN_NDAT2  \ offset: 0x9C : FDCAN New Data 2 Register
$4000a4a0 constant FDCAN_FDCAN_RXF0C  \ offset: 0xA0 : FDCAN Rx FIFO 0 Configuration Register
$4000a4a4 constant FDCAN_FDCAN_RXF0S  \ offset: 0xA4 : FDCAN Rx FIFO 0 Status Register
$4000a4a8 constant FDCAN_FDCAN_RXF0A  \ offset: 0xA8 : CAN Rx FIFO 0 Acknowledge Register
$4000a4ac constant FDCAN_FDCAN_RXBC  \ offset: 0xAC : FDCAN Rx Buffer Configuration Register
$4000a4b0 constant FDCAN_FDCAN_RXF1C  \ offset: 0xB0 : FDCAN Rx FIFO 1 Configuration Register
$4000a4b4 constant FDCAN_FDCAN_RXF1S  \ offset: 0xB4 : FDCAN Rx FIFO 1 Status Register
$4000a4b8 constant FDCAN_FDCAN_RXF1A  \ offset: 0xB8 : FDCAN Rx FIFO 1 Acknowledge Register
$4000a4bc constant FDCAN_FDCAN_RXESC  \ offset: 0xBC : FDCAN Rx Buffer Element Size Configuration Register
$4000a4c0 constant FDCAN_FDCAN_TXBC  \ offset: 0xC0 : FDCAN Tx Buffer Configuration Register
$4000a4c4 constant FDCAN_FDCAN_TXFQS  \ offset: 0xC4 : FDCAN Tx FIFO/Queue Status Register
$4000a4c8 constant FDCAN_FDCAN_TXESC  \ offset: 0xC8 : FDCAN Tx Buffer Element Size Configuration Register
$4000a4cc constant FDCAN_FDCAN_TXBRP  \ offset: 0xCC : FDCAN Tx Buffer Request Pending Register
$4000a4d0 constant FDCAN_FDCAN_TXBAR  \ offset: 0xD0 : FDCAN Tx Buffer Add Request Register
$4000a4d4 constant FDCAN_FDCAN_TXBCR  \ offset: 0xD4 : FDCAN Tx Buffer Cancellation Request Register
$4000a4d8 constant FDCAN_FDCAN_TXBTO  \ offset: 0xD8 : FDCAN Tx Buffer Transmission Occurred Register
$4000a4dc constant FDCAN_FDCAN_TXBCF  \ offset: 0xDC : FDCAN Tx Buffer Cancellation Finished Register
$4000a4e0 constant FDCAN_FDCAN_TXBTIE  \ offset: 0xE0 : FDCAN Tx Buffer Transmission Interrupt Enable Register
$4000a4e4 constant FDCAN_FDCAN_TXBCIE  \ offset: 0xE4 : FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
$4000a4f0 constant FDCAN_FDCAN_TXEFC  \ offset: 0xF0 : FDCAN Tx Event FIFO Configuration Register
$4000a4f4 constant FDCAN_FDCAN_TXEFS  \ offset: 0xF4 : FDCAN Tx Event FIFO Status Register
$4000a4f8 constant FDCAN_FDCAN_TXEFA  \ offset: 0xF8 : FDCAN Tx Event FIFO Acknowledge Register
$4000a500 constant FDCAN_FDCAN_TTTMC  \ offset: 0x100 : FDCAN TT Trigger Memory Configuration Register
$4000a504 constant FDCAN_FDCAN_TTRMC  \ offset: 0x104 : FDCAN TT Reference Message Configuration Register
$4000a508 constant FDCAN_FDCAN_TTOCF  \ offset: 0x108 : FDCAN TT Operation Configuration Register
$4000a50c constant FDCAN_FDCAN_TTMLM  \ offset: 0x10C : FDCAN TT Matrix Limits Register
$4000a510 constant FDCAN_FDCAN_TURCF  \ offset: 0x110 : FDCAN TUR Configuration Register
$4000a514 constant FDCAN_FDCAN_TTOCN  \ offset: 0x114 : FDCAN TT Operation Control Register
$4000a518 constant FDCAN_CAN_TTGTP  \ offset: 0x118 : FDCAN TT Global Time Preset Register
$4000a51c constant FDCAN_FDCAN_TTTMK  \ offset: 0x11C : FDCAN TT Time Mark Register
$4000a520 constant FDCAN_FDCAN_TTIR  \ offset: 0x120 : FDCAN TT Interrupt Register
$4000a524 constant FDCAN_FDCAN_TTIE  \ offset: 0x124 : FDCAN TT Interrupt Enable Register
$4000a528 constant FDCAN_FDCAN_TTILS  \ offset: 0x128 : FDCAN TT Interrupt Line Select Register
$4000a52c constant FDCAN_FDCAN_TTOST  \ offset: 0x12C : FDCAN TT Operation Status Register
$4000a530 constant FDCAN_FDCAN_TURNA  \ offset: 0x130 : FDCAN TUR Numerator Actual Register
$4000a534 constant FDCAN_FDCAN_TTLGT  \ offset: 0x134 : FDCAN TT Local and Global Time Register
$4000a538 constant FDCAN_FDCAN_TTCTC  \ offset: 0x138 : FDCAN TT Cycle Time and Count Register
$4000a53c constant FDCAN_FDCAN_TTCPT  \ offset: 0x13C : FDCAN TT Capture Time Register
$4000a540 constant FDCAN_FDCAN_TTCSM  \ offset: 0x140 : FDCAN TT Cycle Sync Mark Register
$4000a700 constant FDCAN_FDCAN_TTTS  \ offset: 0x300 : FDCAN TT Trigger Select Register

