\
\ @file fdcan.fs
\ @brief FDCAN1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FDCAN_DEF

  [ifdef] FDCAN_FDCAN_CREL_DEF
    \
    \ @brief FDCAN Core Release Register
    \ Address offset: 0x00
    \ Reset value: 0x32141218
    \
    $00 constant FDCAN_DAY                      \ [0x00 : 8] Timestamp Day
    $08 constant FDCAN_MON                      \ [0x08 : 8] Timestamp Month
    $10 constant FDCAN_YEAR                     \ [0x10 : 4] Timestamp Year
    $14 constant FDCAN_SUBSTEP                  \ [0x14 : 4] Sub-step of Core release
    $18 constant FDCAN_STEP                     \ [0x18 : 4] Step of Core release
    $1c constant FDCAN_REL                      \ [0x1c : 4] Core release
  [then]


  [ifdef] FDCAN_FDCAN_ENDN_DEF
    \
    \ @brief FDCAN Core Release Register
    \ Address offset: 0x04
    \ Reset value: 0x87654321
    \
    $00 constant FDCAN_ETV                      \ [0x00 : 32] Endiannes Test Value
  [then]


  [ifdef] FDCAN_FDCAN_DBTP_DEF
    \
    \ @brief FDCAN Data Bit Timing and Prescaler Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000A33
    \
    $00 constant FDCAN_DSJW                     \ [0x00 : 4] Synchronization Jump Width
    $04 constant FDCAN_DTSEG2                   \ [0x04 : 4] Data time segment after sample point
    $08 constant FDCAN_DTSEG1                   \ [0x08 : 5] Data time segment after sample point
    $10 constant FDCAN_DBRP                     \ [0x10 : 5] Data BIt Rate Prescaler
    $17 constant FDCAN_TDC                      \ [0x17] Transceiver Delay Compensation
  [then]


  [ifdef] FDCAN_FDCAN_TEST_DEF
    \
    \ @brief FDCAN Test Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant FDCAN_LBCK                     \ [0x04] Loop Back mode
    $05 constant FDCAN_TX                       \ [0x05 : 2] Loop Back mode
    $07 constant FDCAN_RX                       \ [0x07] Control of Transmit Pin
  [then]


  [ifdef] FDCAN_FDCAN_RWD_DEF
    \
    \ @brief FDCAN RAM Watchdog Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_WDC                      \ [0x00 : 8] Watchdog configuration
    $08 constant FDCAN_WDV                      \ [0x08 : 8] Watchdog value
  [then]


  [ifdef] FDCAN_FDCAN_CCCR_DEF
    \
    \ @brief FDCAN CC Control Register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant FDCAN_INIT                     \ [0x00] Initialization
    $01 constant FDCAN_CCE                      \ [0x01] Configuration Change Enable
    $02 constant FDCAN_ASM                      \ [0x02] ASM Restricted Operation Mode
    $03 constant FDCAN_CSA                      \ [0x03] Clock Stop Acknowledge
    $04 constant FDCAN_CSR                      \ [0x04] Clock Stop Request
    $05 constant FDCAN_MON                      \ [0x05] Bus Monitoring Mode
    $06 constant FDCAN_DAR                      \ [0x06] Disable Automatic Retransmission
    $07 constant FDCAN_TEST                     \ [0x07] Test Mode Enable
    $08 constant FDCAN_FDOE                     \ [0x08] FD Operation Enable
    $09 constant FDCAN_BSE                      \ [0x09] FDCAN Bit Rate Switching
    $0c constant FDCAN_PXHD                     \ [0x0c] Protocol Exception Handling Disable
    $0d constant FDCAN_EFBI                     \ [0x0d] Edge Filtering during Bus Integration
    $0e constant FDCAN_TXP                      \ [0x0e] TXP
    $0f constant FDCAN_NISO                     \ [0x0f] Non ISO Operation
  [then]


  [ifdef] FDCAN_FDCAN_NBTP_DEF
    \
    \ @brief FDCAN Nominal Bit Timing and Prescaler Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000A33
    \
    $00 constant FDCAN_TSEG2                    \ [0x00 : 7] Nominal Time segment after sample point
    $08 constant FDCAN_NTSEG1                   \ [0x08 : 8] Nominal Time segment before sample point
    $10 constant FDCAN_NBRP                     \ [0x10 : 9] Bit Rate Prescaler
    $19 constant FDCAN_NSJW                     \ [0x19 : 7] NSJW: Nominal (Re)Synchronization Jump Width
  [then]


  [ifdef] FDCAN_FDCAN_TSCC_DEF
    \
    \ @brief FDCAN Timestamp Counter Configuration Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TSS                      \ [0x00 : 2] Timestamp Select
    $10 constant FDCAN_TCP                      \ [0x10 : 4] Timestamp Counter Prescaler
  [then]


  [ifdef] FDCAN_FDCAN_TSCV_DEF
    \
    \ @brief FDCAN Timestamp Counter Value Register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TSC                      \ [0x00 : 16] Timestamp Counter
  [then]


  [ifdef] FDCAN_FDCAN_TOCC_DEF
    \
    \ @brief FDCAN Timeout Counter Configuration Register
    \ Address offset: 0x28
    \ Reset value: 0xFFFF0000
    \
    $00 constant FDCAN_ETOC                     \ [0x00] Enable Timeout Counter
    $01 constant FDCAN_TOS                      \ [0x01 : 2] Timeout Select
    $10 constant FDCAN_TOP                      \ [0x10 : 16] Timeout Period
  [then]


  [ifdef] FDCAN_FDCAN_TOCV_DEF
    \
    \ @brief FDCAN Timeout Counter Value Register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant FDCAN_TOC                      \ [0x00 : 16] Timeout Counter
  [then]


  [ifdef] FDCAN_FDCAN_ECR_DEF
    \
    \ @brief FDCAN Error Counter Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TEC                      \ [0x00 : 8] Transmit Error Counter
    $08 constant FDCAN_TREC                     \ [0x08 : 7] Receive Error Counter
    $0f constant FDCAN_RP                       \ [0x0f] Receive Error Passive
    $10 constant FDCAN_CEL                      \ [0x10 : 8] AN Error Logging
  [then]


  [ifdef] FDCAN_FDCAN_PSR_DEF
    \
    \ @brief FDCAN Protocol Status Register
    \ Address offset: 0x44
    \ Reset value: 0x00000707
    \
    $00 constant FDCAN_LEC                      \ [0x00 : 3] Last Error Code
    $03 constant FDCAN_ACT                      \ [0x03 : 2] Activity
    $05 constant FDCAN_EP                       \ [0x05] Error Passive
    $06 constant FDCAN_EW                       \ [0x06] Warning Status
    $07 constant FDCAN_BO                       \ [0x07] Bus_Off Status
    $08 constant FDCAN_DLEC                     \ [0x08 : 3] Data Last Error Code
    $0b constant FDCAN_RESI                     \ [0x0b] ESI flag of last received FDCAN Message
    $0c constant FDCAN_RBRS                     \ [0x0c] BRS flag of last received FDCAN Message
    $0d constant FDCAN_REDL                     \ [0x0d] Received FDCAN Message
    $0e constant FDCAN_PXE                      \ [0x0e] Protocol Exception Event
    $10 constant FDCAN_TDCV                     \ [0x10 : 7] Transmitter Delay Compensation Value
  [then]


  [ifdef] FDCAN_FDCAN_TDCR_DEF
    \
    \ @brief FDCAN Transmitter Delay Compensation Register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TDCF                     \ [0x00 : 7] Transmitter Delay Compensation Filter Window Length
    $08 constant FDCAN_TDCO                     \ [0x08 : 7] Transmitter Delay Compensation Offset
  [then]


  [ifdef] FDCAN_FDCAN_IR_DEF
    \
    \ @brief FDCAN Interrupt Register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0N                     \ [0x00] Rx FIFO 0 New Message
    $01 constant FDCAN_RF0W                     \ [0x01] Rx FIFO 0 Full
    $02 constant FDCAN_RF0F                     \ [0x02] Rx FIFO 0 Full
    $03 constant FDCAN_RF0L                     \ [0x03] Rx FIFO 0 Message Lost
    $04 constant FDCAN_RF1N                     \ [0x04] Rx FIFO 1 New Message
    $05 constant FDCAN_RF1W                     \ [0x05] Rx FIFO 1 Watermark Reached
    $06 constant FDCAN_RF1F                     \ [0x06] Rx FIFO 1 Watermark Reached
    $07 constant FDCAN_RF1L                     \ [0x07] Rx FIFO 1 Message Lost
    $08 constant FDCAN_HPM                      \ [0x08] High Priority Message
    $09 constant FDCAN_TC                       \ [0x09] Transmission Completed
    $0a constant FDCAN_TCF                      \ [0x0a] Transmission Cancellation Finished
    $0b constant FDCAN_TEF                      \ [0x0b] Tx FIFO Empty
    $0c constant FDCAN_TEFN                     \ [0x0c] Tx Event FIFO New Entry
    $0d constant FDCAN_TEFW                     \ [0x0d] Tx Event FIFO Watermark Reached
    $0e constant FDCAN_TEFF                     \ [0x0e] Tx Event FIFO Full
    $0f constant FDCAN_TEFL                     \ [0x0f] Tx Event FIFO Element Lost
    $10 constant FDCAN_TSW                      \ [0x10] Timestamp Wraparound
    $11 constant FDCAN_MRAF                     \ [0x11] Message RAM Access Failure
    $12 constant FDCAN_TOO                      \ [0x12] Timeout Occurred
    $13 constant FDCAN_DRX                      \ [0x13] Message stored to Dedicated Rx Buffer
    $16 constant FDCAN_ELO                      \ [0x16] Error Logging Overflow
    $17 constant FDCAN_EP                       \ [0x17] Error Passive
    $18 constant FDCAN_EW                       \ [0x18] Warning Status
    $19 constant FDCAN_BO                       \ [0x19] Bus_Off Status
    $1a constant FDCAN_WDI                      \ [0x1a] Watchdog Interrupt
    $1b constant FDCAN_PEA                      \ [0x1b] Protocol Error in Arbitration Phase (Nominal Bit Time is used)
    $1c constant FDCAN_PED                      \ [0x1c] Protocol Error in Data Phase (Data Bit Time is used)
    $1d constant FDCAN_ARA                      \ [0x1d] Access to Reserved Address
  [then]


  [ifdef] FDCAN_FDCAN_IE_DEF
    \
    \ @brief FDCAN Interrupt Enable Register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0NE                    \ [0x00] Rx FIFO 0 New Message Enable
    $01 constant FDCAN_RF0WE                    \ [0x01] Rx FIFO 0 Full Enable
    $02 constant FDCAN_RF0FE                    \ [0x02] Rx FIFO 0 Full Enable
    $03 constant FDCAN_RF0LE                    \ [0x03] Rx FIFO 0 Message Lost Enable
    $04 constant FDCAN_RF1NE                    \ [0x04] Rx FIFO 1 New Message Enable
    $05 constant FDCAN_RF1WE                    \ [0x05] Rx FIFO 1 Watermark Reached Enable
    $06 constant FDCAN_RF1FE                    \ [0x06] Rx FIFO 1 Watermark Reached Enable
    $07 constant FDCAN_RF1LE                    \ [0x07] Rx FIFO 1 Message Lost Enable
    $08 constant FDCAN_HPME                     \ [0x08] High Priority Message Enable
    $09 constant FDCAN_TCE                      \ [0x09] Transmission Completed Enable
    $0a constant FDCAN_TCFE                     \ [0x0a] Transmission Cancellation Finished Enable
    $0b constant FDCAN_TEFE                     \ [0x0b] Tx FIFO Empty Enable
    $0c constant FDCAN_TEFNE                    \ [0x0c] Tx Event FIFO New Entry Enable
    $0d constant FDCAN_TEFWE                    \ [0x0d] Tx Event FIFO Watermark Reached Enable
    $0e constant FDCAN_TEFFE                    \ [0x0e] Tx Event FIFO Full Enable
    $0f constant FDCAN_TEFLE                    \ [0x0f] Tx Event FIFO Element Lost Enable
    $10 constant FDCAN_TSWE                     \ [0x10] Timestamp Wraparound Enable
    $11 constant FDCAN_MRAFE                    \ [0x11] Message RAM Access Failure Enable
    $12 constant FDCAN_TOOE                     \ [0x12] Timeout Occurred Enable
    $13 constant FDCAN_DRXE                     \ [0x13] Message stored to Dedicated Rx Buffer Enable
    $14 constant FDCAN_BECE                     \ [0x14] Bit Error Corrected Interrupt Enable
    $15 constant FDCAN_BEUE                     \ [0x15] Bit Error Uncorrected Interrupt Enable
    $16 constant FDCAN_ELOE                     \ [0x16] Error Logging Overflow Enable
    $17 constant FDCAN_EPE                      \ [0x17] Error Passive Enable
    $18 constant FDCAN_EWE                      \ [0x18] Warning Status Enable
    $19 constant FDCAN_BOE                      \ [0x19] Bus_Off Status Enable
    $1a constant FDCAN_WDIE                     \ [0x1a] Watchdog Interrupt Enable
    $1b constant FDCAN_PEAE                     \ [0x1b] Protocol Error in Arbitration Phase Enable
    $1c constant FDCAN_PEDE                     \ [0x1c] Protocol Error in Data Phase Enable
    $1d constant FDCAN_ARAE                     \ [0x1d] Access to Reserved Address Enable
  [then]


  [ifdef] FDCAN_FDCAN_ILS_DEF
    \
    \ @brief FDCAN Interrupt Line Select Register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0NL                    \ [0x00] Rx FIFO 0 New Message Interrupt Line
    $01 constant FDCAN_RF0WL                    \ [0x01] Rx FIFO 0 Watermark Reached Interrupt Line
    $02 constant FDCAN_RF0FL                    \ [0x02] Rx FIFO 0 Full Interrupt Line
    $03 constant FDCAN_RF0LL                    \ [0x03] Rx FIFO 0 Message Lost Interrupt Line
    $04 constant FDCAN_RF1NL                    \ [0x04] Rx FIFO 1 New Message Interrupt Line
    $05 constant FDCAN_RF1WL                    \ [0x05] Rx FIFO 1 Watermark Reached Interrupt Line
    $06 constant FDCAN_RF1FL                    \ [0x06] Rx FIFO 1 Full Interrupt Line
    $07 constant FDCAN_RF1LL                    \ [0x07] Rx FIFO 1 Message Lost Interrupt Line
    $08 constant FDCAN_HPML                     \ [0x08] High Priority Message Interrupt Line
    $09 constant FDCAN_TCL                      \ [0x09] Transmission Completed Interrupt Line
    $0a constant FDCAN_TCFL                     \ [0x0a] Transmission Cancellation Finished Interrupt Line
    $0b constant FDCAN_TEFL                     \ [0x0b] Tx FIFO Empty Interrupt Line
    $0c constant FDCAN_TEFNL                    \ [0x0c] Tx Event FIFO New Entry Interrupt Line
    $0d constant FDCAN_TEFWL                    \ [0x0d] Tx Event FIFO Watermark Reached Interrupt Line
    $0e constant FDCAN_TEFFL                    \ [0x0e] Tx Event FIFO Full Interrupt Line
    $0f constant FDCAN_TEFLL                    \ [0x0f] Tx Event FIFO Element Lost Interrupt Line
    $10 constant FDCAN_TSWL                     \ [0x10] Timestamp Wraparound Interrupt Line
    $11 constant FDCAN_MRAFL                    \ [0x11] Message RAM Access Failure Interrupt Line
    $12 constant FDCAN_TOOL                     \ [0x12] Timeout Occurred Interrupt Line
    $13 constant FDCAN_DRXL                     \ [0x13] Message stored to Dedicated Rx Buffer Interrupt Line
    $14 constant FDCAN_BECL                     \ [0x14] Bit Error Corrected Interrupt Line
    $15 constant FDCAN_BEUL                     \ [0x15] Bit Error Uncorrected Interrupt Line
    $16 constant FDCAN_ELOL                     \ [0x16] Error Logging Overflow Interrupt Line
    $17 constant FDCAN_EPL                      \ [0x17] Error Passive Interrupt Line
    $18 constant FDCAN_EWL                      \ [0x18] Warning Status Interrupt Line
    $19 constant FDCAN_BOL                      \ [0x19] Bus_Off Status
    $1a constant FDCAN_WDIL                     \ [0x1a] Watchdog Interrupt Line
    $1b constant FDCAN_PEAL                     \ [0x1b] Protocol Error in Arbitration Phase Line
    $1c constant FDCAN_PEDL                     \ [0x1c] Protocol Error in Data Phase Line
    $1d constant FDCAN_ARAL                     \ [0x1d] Access to Reserved Address Line
  [then]


  [ifdef] FDCAN_FDCAN_ILE_DEF
    \
    \ @brief FDCAN Interrupt Line Enable Register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EINT0                    \ [0x00] Enable Interrupt Line 0
    $01 constant FDCAN_EINT1                    \ [0x01] Enable Interrupt Line 1
  [then]


  [ifdef] FDCAN_FDCAN_GFC_DEF
    \
    \ @brief FDCAN Global Filter Configuration Register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RRFE                     \ [0x00] Reject Remote Frames Extended
    $01 constant FDCAN_RRFS                     \ [0x01] Reject Remote Frames Standard
    $02 constant FDCAN_ANFE                     \ [0x02 : 2] Accept Non-matching Frames Extended
    $04 constant FDCAN_ANFS                     \ [0x04 : 2] Accept Non-matching Frames Standard
  [then]


  [ifdef] FDCAN_FDCAN_SIDFC_DEF
    \
    \ @brief FDCAN Standard ID Filter Configuration Register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_FLSSA                    \ [0x02 : 14] Filter List Standard Start Address
    $10 constant FDCAN_LSS                      \ [0x10 : 8] List Size Standard
  [then]


  [ifdef] FDCAN_FDCAN_XIDFC_DEF
    \
    \ @brief FDCAN Extended ID Filter Configuration Register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_FLESA                    \ [0x02 : 14] Filter List Standard Start Address
    $10 constant FDCAN_LSE                      \ [0x10 : 8] List Size Extended
  [then]


  [ifdef] FDCAN_FDCAN_XIDAM_DEF
    \
    \ @brief FDCAN Extended ID and Mask Register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EIDM                     \ [0x00 : 29] Extended ID Mask
  [then]


  [ifdef] FDCAN_FDCAN_HPMS_DEF
    \
    \ @brief FDCAN High Priority Message Status Register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_BIDX                     \ [0x00 : 6] Buffer Index
    $06 constant FDCAN_MSI                      \ [0x06 : 2] Message Storage Indicator
    $08 constant FDCAN_FIDX                     \ [0x08 : 7] Filter Index
    $0f constant FDCAN_FLST                     \ [0x0f] Filter List
  [then]


  [ifdef] FDCAN_FDCAN_NDAT1_DEF
    \
    \ @brief FDCAN New Data 1 Register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_ND0                      \ [0x00] New data
    $01 constant FDCAN_ND1                      \ [0x01] New data
    $02 constant FDCAN_ND2                      \ [0x02] New data
    $03 constant FDCAN_ND3                      \ [0x03] New data
    $04 constant FDCAN_ND4                      \ [0x04] New data
    $05 constant FDCAN_ND5                      \ [0x05] New data
    $06 constant FDCAN_ND6                      \ [0x06] New data
    $07 constant FDCAN_ND7                      \ [0x07] New data
    $08 constant FDCAN_ND8                      \ [0x08] New data
    $09 constant FDCAN_ND9                      \ [0x09] New data
    $0a constant FDCAN_ND10                     \ [0x0a] New data
    $0b constant FDCAN_ND11                     \ [0x0b] New data
    $0c constant FDCAN_ND12                     \ [0x0c] New data
    $0d constant FDCAN_ND13                     \ [0x0d] New data
    $0e constant FDCAN_ND14                     \ [0x0e] New data
    $0f constant FDCAN_ND15                     \ [0x0f] New data
    $10 constant FDCAN_ND16                     \ [0x10] New data
    $11 constant FDCAN_ND17                     \ [0x11] New data
    $12 constant FDCAN_ND18                     \ [0x12] New data
    $13 constant FDCAN_ND19                     \ [0x13] New data
    $14 constant FDCAN_ND20                     \ [0x14] New data
    $15 constant FDCAN_ND21                     \ [0x15] New data
    $16 constant FDCAN_ND22                     \ [0x16] New data
    $17 constant FDCAN_ND23                     \ [0x17] New data
    $18 constant FDCAN_ND24                     \ [0x18] New data
    $19 constant FDCAN_ND25                     \ [0x19] New data
    $1a constant FDCAN_ND26                     \ [0x1a] New data
    $1b constant FDCAN_ND27                     \ [0x1b] New data
    $1c constant FDCAN_ND28                     \ [0x1c] New data
    $1d constant FDCAN_ND29                     \ [0x1d] New data
    $1e constant FDCAN_ND30                     \ [0x1e] New data
    $1f constant FDCAN_ND31                     \ [0x1f] New data
  [then]


  [ifdef] FDCAN_FDCAN_NDAT2_DEF
    \
    \ @brief FDCAN New Data 2 Register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_ND32                     \ [0x00] New data
    $01 constant FDCAN_ND33                     \ [0x01] New data
    $02 constant FDCAN_ND34                     \ [0x02] New data
    $03 constant FDCAN_ND35                     \ [0x03] New data
    $04 constant FDCAN_ND36                     \ [0x04] New data
    $05 constant FDCAN_ND37                     \ [0x05] New data
    $06 constant FDCAN_ND38                     \ [0x06] New data
    $07 constant FDCAN_ND39                     \ [0x07] New data
    $08 constant FDCAN_ND40                     \ [0x08] New data
    $09 constant FDCAN_ND41                     \ [0x09] New data
    $0a constant FDCAN_ND42                     \ [0x0a] New data
    $0b constant FDCAN_ND43                     \ [0x0b] New data
    $0c constant FDCAN_ND44                     \ [0x0c] New data
    $0d constant FDCAN_ND45                     \ [0x0d] New data
    $0e constant FDCAN_ND46                     \ [0x0e] New data
    $0f constant FDCAN_ND47                     \ [0x0f] New data
    $10 constant FDCAN_ND48                     \ [0x10] New data
    $11 constant FDCAN_ND49                     \ [0x11] New data
    $12 constant FDCAN_ND50                     \ [0x12] New data
    $13 constant FDCAN_ND51                     \ [0x13] New data
    $14 constant FDCAN_ND52                     \ [0x14] New data
    $15 constant FDCAN_ND53                     \ [0x15] New data
    $16 constant FDCAN_ND54                     \ [0x16] New data
    $17 constant FDCAN_ND55                     \ [0x17] New data
    $18 constant FDCAN_ND56                     \ [0x18] New data
    $19 constant FDCAN_ND57                     \ [0x19] New data
    $1a constant FDCAN_ND58                     \ [0x1a] New data
    $1b constant FDCAN_ND59                     \ [0x1b] New data
    $1c constant FDCAN_ND60                     \ [0x1c] New data
    $1d constant FDCAN_ND61                     \ [0x1d] New data
    $1e constant FDCAN_ND62                     \ [0x1e] New data
    $1f constant FDCAN_ND63                     \ [0x1f] New data
  [then]


  [ifdef] FDCAN_FDCAN_RXF0C_DEF
    \
    \ @brief FDCAN Rx FIFO 0 Configuration Register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_F0SA                     \ [0x02 : 14] Rx FIFO 0 Start Address
    $10 constant FDCAN_F0S                      \ [0x10 : 8] Rx FIFO 0 Size
    $18 constant FDCAN_F0WM                     \ [0x18 : 8] FIFO 0 Watermark
  [then]


  [ifdef] FDCAN_FDCAN_RXF0S_DEF
    \
    \ @brief FDCAN Rx FIFO 0 Status Register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0FL                     \ [0x00 : 7] Rx FIFO 0 Fill Level
    $08 constant FDCAN_F0G                      \ [0x08 : 6] Rx FIFO 0 Get Index
    $10 constant FDCAN_F0P                      \ [0x10 : 6] Rx FIFO 0 Put Index
    $18 constant FDCAN_F0F                      \ [0x18] Rx FIFO 0 Full
    $19 constant FDCAN_RF0L                     \ [0x19] Rx FIFO 0 Message Lost
  [then]


  [ifdef] FDCAN_FDCAN_RXF0A_DEF
    \
    \ @brief CAN Rx FIFO 0 Acknowledge Register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_FA01                     \ [0x00 : 6] Rx FIFO 0 Acknowledge Index
  [then]


  [ifdef] FDCAN_FDCAN_RXBC_DEF
    \
    \ @brief FDCAN Rx Buffer Configuration Register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_RBSA                     \ [0x02 : 14] Rx Buffer Start Address
  [then]


  [ifdef] FDCAN_FDCAN_RXF1C_DEF
    \
    \ @brief FDCAN Rx FIFO 1 Configuration Register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_F1SA                     \ [0x02 : 14] Rx FIFO 1 Start Address
    $10 constant FDCAN_F1S                      \ [0x10 : 7] Rx FIFO 1 Size
    $18 constant FDCAN_F1WM                     \ [0x18 : 7] Rx FIFO 1 Watermark
  [then]


  [ifdef] FDCAN_FDCAN_RXF1S_DEF
    \
    \ @brief FDCAN Rx FIFO 1 Status Register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F1FL                     \ [0x00 : 7] Rx FIFO 1 Fill Level
    $08 constant FDCAN_F1GI                     \ [0x08 : 7] Rx FIFO 1 Get Index
    $10 constant FDCAN_F1PI                     \ [0x10 : 7] Rx FIFO 1 Put Index
    $18 constant FDCAN_F1F                      \ [0x18] Rx FIFO 1 Full
    $19 constant FDCAN_RF1L                     \ [0x19] Rx FIFO 1 Message Lost
    $1e constant FDCAN_DMS                      \ [0x1e : 2] Debug Message Status
  [then]


  [ifdef] FDCAN_FDCAN_RXF1A_DEF
    \
    \ @brief FDCAN Rx FIFO 1 Acknowledge Register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F1AI                     \ [0x00 : 6] Rx FIFO 1 Acknowledge Index
  [then]


  [ifdef] FDCAN_FDCAN_RXESC_DEF
    \
    \ @brief FDCAN Rx Buffer Element Size Configuration Register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0DS                     \ [0x00 : 3] Rx FIFO 1 Data Field Size:
    $04 constant FDCAN_F1DS                     \ [0x04 : 3] Rx FIFO 0 Data Field Size:
    $08 constant FDCAN_RBDS                     \ [0x08 : 3] Rx Buffer Data Field Size:
  [then]


  [ifdef] FDCAN_FDCAN_TXBC_DEF
    \
    \ @brief FDCAN Tx Buffer Configuration Register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_TBSA                     \ [0x02 : 14] Tx Buffers Start Address
    $10 constant FDCAN_NDTB                     \ [0x10 : 6] Number of Dedicated Transmit Buffers
    $18 constant FDCAN_TFQS                     \ [0x18 : 6] Transmit FIFO/Queue Size
    $1e constant FDCAN_TFQM                     \ [0x1e] Tx FIFO/Queue Mode
  [then]


  [ifdef] FDCAN_FDCAN_TXFQS_DEF
    \
    \ @brief FDCAN Tx FIFO/Queue Status Register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TFFL                     \ [0x00 : 6] Tx FIFO Free Level
    $08 constant FDCAN_TFGI                     \ [0x08 : 5] TFGI
    $10 constant FDCAN_TFQPI                    \ [0x10 : 5] Tx FIFO/Queue Put Index
    $15 constant FDCAN_TFQF                     \ [0x15] Tx FIFO/Queue Full
  [then]


  [ifdef] FDCAN_FDCAN_TXESC_DEF
    \
    \ @brief FDCAN Tx Buffer Element Size Configuration Register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TBDS                     \ [0x00 : 3] Tx Buffer Data Field Size:
  [then]


  [ifdef] FDCAN_FDCAN_TXBRP_DEF
    \
    \ @brief FDCAN Tx Buffer Request Pending Register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TRP                      \ [0x00 : 32] Transmission Request Pending
  [then]


  [ifdef] FDCAN_FDCAN_TXBAR_DEF
    \
    \ @brief FDCAN Tx Buffer Add Request Register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_AR                       \ [0x00 : 32] Add Request
  [then]


  [ifdef] FDCAN_FDCAN_TXBCR_DEF
    \
    \ @brief FDCAN Tx Buffer Cancellation Request Register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CR                       \ [0x00 : 32] Cancellation Request
  [then]


  [ifdef] FDCAN_FDCAN_TXBTO_DEF
    \
    \ @brief FDCAN Tx Buffer Transmission Occurred Register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TO                       \ [0x00 : 32] Transmission Occurred.
  [then]


  [ifdef] FDCAN_FDCAN_TXBCF_DEF
    \
    \ @brief FDCAN Tx Buffer Cancellation Finished Register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CF                       \ [0x00 : 32] Cancellation Finished
  [then]


  [ifdef] FDCAN_FDCAN_TXBTIE_DEF
    \
    \ @brief FDCAN Tx Buffer Transmission Interrupt Enable Register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TIE                      \ [0x00 : 32] Transmission Interrupt Enable
  [then]


  [ifdef] FDCAN_FDCAN_TXBCIE_DEF
    \
    \ @brief FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CF                       \ [0x00 : 32] Cancellation Finished Interrupt Enable
  [then]


  [ifdef] FDCAN_FDCAN_TXEFC_DEF
    \
    \ @brief FDCAN Tx Event FIFO Configuration Register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_EFSA                     \ [0x02 : 14] Event FIFO Start Address
    $10 constant FDCAN_EFS                      \ [0x10 : 6] Event FIFO Size
    $18 constant FDCAN_EFWM                     \ [0x18 : 6] Event FIFO Watermark
  [then]


  [ifdef] FDCAN_FDCAN_TXEFS_DEF
    \
    \ @brief FDCAN Tx Event FIFO Status Register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EFFL                     \ [0x00 : 6] Event FIFO Fill Level
    $08 constant FDCAN_EFGI                     \ [0x08 : 5] Event FIFO Get Index.
    $10 constant FDCAN_EFPI                     \ [0x10 : 5] Event FIFO put index.
    $18 constant FDCAN_EFF                      \ [0x18] Event FIFO Full.
    $19 constant FDCAN_TEFL                     \ [0x19] Tx Event FIFO Element Lost.
  [then]


  [ifdef] FDCAN_FDCAN_TXEFA_DEF
    \
    \ @brief FDCAN Tx Event FIFO Acknowledge Register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EFAI                     \ [0x00 : 5] Event FIFO Acknowledge Index
  [then]


  [ifdef] FDCAN_FDCAN_TTTMC_DEF
    \
    \ @brief FDCAN TT Trigger Memory Configuration Register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_TMSA                     \ [0x02 : 14] Trigger Memory Start Address
    $10 constant FDCAN_TME                      \ [0x10 : 7] Trigger Memory Elements
  [then]


  [ifdef] FDCAN_FDCAN_TTRMC_DEF
    \
    \ @brief FDCAN TT Reference Message Configuration Register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RID                      \ [0x00 : 29] Reference Identifier.
    $1e constant FDCAN_XTD                      \ [0x1e] Extended Identifier
    $1f constant FDCAN_RMPS                     \ [0x1f] Reference Message Payload Select
  [then]


  [ifdef] FDCAN_FDCAN_TTOCF_DEF
    \
    \ @brief FDCAN TT Operation Configuration Register
    \ Address offset: 0x108
    \ Reset value: 0x00010000
    \
    $00 constant FDCAN_OM                       \ [0x00 : 2] Operation Mode
    $03 constant FDCAN_GEN                      \ [0x03] Gap Enable
    $04 constant FDCAN_TM                       \ [0x04] Time Master
    $05 constant FDCAN_LDSDL                    \ [0x05 : 3] LD of Synchronization Deviation Limit
    $08 constant FDCAN_IRTO                     \ [0x08 : 7] Initial Reference Trigger Offset
    $0f constant FDCAN_EECS                     \ [0x0f] Enable External Clock Synchronization
    $10 constant FDCAN_AWL                      \ [0x10 : 8] Application Watchdog Limit
    $18 constant FDCAN_EGTF                     \ [0x18] Enable Global Time Filtering
    $19 constant FDCAN_ECC                      \ [0x19] Enable Clock Calibration
    $1a constant FDCAN_EVTP                     \ [0x1a] Event Trigger Polarity
  [then]


  [ifdef] FDCAN_FDCAN_TTMLM_DEF
    \
    \ @brief FDCAN TT Matrix Limits Register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CCM                      \ [0x00 : 6] Cycle Count Max
    $06 constant FDCAN_CSS                      \ [0x06 : 2] Cycle Start Synchronization
    $08 constant FDCAN_TXEW                     \ [0x08 : 4] Tx Enable Window
    $10 constant FDCAN_ENTT                     \ [0x10 : 12] Expected Number of Tx Triggers
  [then]


  [ifdef] FDCAN_FDCAN_TURCF_DEF
    \
    \ @brief FDCAN TUR Configuration Register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_NCL                      \ [0x00 : 16] Numerator Configuration Low.
    $10 constant FDCAN_DC                       \ [0x10 : 14] Denominator Configuration.
    $1f constant FDCAN_ELT                      \ [0x1f] Enable Local Time
  [then]


  [ifdef] FDCAN_FDCAN_TTOCN_DEF
    \
    \ @brief FDCAN TT Operation Control Register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SGT                      \ [0x00] Set Global time
    $01 constant FDCAN_ECS                      \ [0x01] External Clock Synchronization
    $02 constant FDCAN_SWP                      \ [0x02] Stop Watch Polarity
    $03 constant FDCAN_SWS                      \ [0x03 : 2] Stop Watch Source.
    $05 constant FDCAN_RTIE                     \ [0x05] Register Time Mark Interrupt Pulse Enable
    $06 constant FDCAN_TMC                      \ [0x06 : 2] Register Time Mark Compare
    $08 constant FDCAN_TTIE                     \ [0x08] Trigger Time Mark Interrupt Pulse Enable
    $09 constant FDCAN_GCS                      \ [0x09] Gap Control Select
    $0a constant FDCAN_FGP                      \ [0x0a] Finish Gap.
    $0b constant FDCAN_TMG                      \ [0x0b] Time Mark Gap
    $0c constant FDCAN_NIG                      \ [0x0c] Next is Gap
    $0d constant FDCAN_ESCN                     \ [0x0d] External Synchronization Control
    $0f constant FDCAN_LCKC                     \ [0x0f] TT Operation Control Register Locked
  [then]


  [ifdef] FDCAN_CAN_TTGTP_DEF
    \
    \ @brief FDCAN TT Global Time Preset Register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_NCL                      \ [0x00 : 16] Time Preset
    $10 constant FDCAN_CTP                      \ [0x10 : 16] Cycle Time Target Phase
  [then]


  [ifdef] FDCAN_FDCAN_TTTMK_DEF
    \
    \ @brief FDCAN TT Time Mark Register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TM                       \ [0x00 : 16] Time Mark
    $10 constant FDCAN_TICC                     \ [0x10 : 7] Time Mark Cycle Code
    $1f constant FDCAN_LCKM                     \ [0x1f] TT Time Mark Register Locked
  [then]


  [ifdef] FDCAN_FDCAN_TTIR_DEF
    \
    \ @brief FDCAN TT Interrupt Register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SBC                      \ [0x00] Start of Basic Cycle
    $01 constant FDCAN_SMC                      \ [0x01] Start of Matrix Cycle
    $02 constant FDCAN_CSM                      \ [0x02] Change of Synchronization Mode
    $03 constant FDCAN_SOG                      \ [0x03] Start of Gap
    $04 constant FDCAN_RTMI                     \ [0x04] Register Time Mark Interrupt.
    $05 constant FDCAN_TTMI                     \ [0x05] Trigger Time Mark Event Internal
    $06 constant FDCAN_SWE                      \ [0x06] Stop Watch Event
    $07 constant FDCAN_GTW                      \ [0x07] Global Time Wrap
    $08 constant FDCAN_GTD                      \ [0x08] Global Time Discontinuity
    $09 constant FDCAN_GTE                      \ [0x09] Global Time Error
    $0a constant FDCAN_TXU                      \ [0x0a] Tx Count Underflow
    $0b constant FDCAN_TXO                      \ [0x0b] Tx Count Overflow
    $0c constant FDCAN_SE1                      \ [0x0c] Scheduling Error 1
    $0d constant FDCAN_SE2                      \ [0x0d] Scheduling Error 2
    $0e constant FDCAN_ELC                      \ [0x0e] Error Level Changed.
    $0f constant FDCAN_IWTG                     \ [0x0f] Initialization Watch Trigger
    $10 constant FDCAN_WT                       \ [0x10] Watch Trigger
    $11 constant FDCAN_AW                       \ [0x11] Application Watchdog
    $12 constant FDCAN_CER                      \ [0x12] Configuration Error
  [then]


  [ifdef] FDCAN_FDCAN_TTIE_DEF
    \
    \ @brief FDCAN TT Interrupt Enable Register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SBCE                     \ [0x00] Start of Basic Cycle Interrupt Enable
    $01 constant FDCAN_SMCE                     \ [0x01] Start of Matrix Cycle Interrupt Enable
    $02 constant FDCAN_CSME                     \ [0x02] Change of Synchronization Mode Interrupt Enable
    $03 constant FDCAN_SOGE                     \ [0x03] Start of Gap Interrupt Enable
    $04 constant FDCAN_RTMIE                    \ [0x04] Register Time Mark Interrupt Enable
    $05 constant FDCAN_TTMIE                    \ [0x05] Trigger Time Mark Event Internal Interrupt Enable
    $06 constant FDCAN_SWEE                     \ [0x06] Stop Watch Event Interrupt Enable
    $07 constant FDCAN_GTWE                     \ [0x07] Global Time Wrap Interrupt Enable
    $08 constant FDCAN_GTDE                     \ [0x08] Global Time Discontinuity Interrupt Enable
    $09 constant FDCAN_GTEE                     \ [0x09] Global Time Error Interrupt Enable
    $0a constant FDCAN_TXUE                     \ [0x0a] Tx Count Underflow Interrupt Enable
    $0b constant FDCAN_TXOE                     \ [0x0b] Tx Count Overflow Interrupt Enable
    $0c constant FDCAN_SE1E                     \ [0x0c] Scheduling Error 1 Interrupt Enable
    $0d constant FDCAN_SE2E                     \ [0x0d] Scheduling Error 2 Interrupt Enable
    $0e constant FDCAN_ELCE                     \ [0x0e] Change Error Level Interrupt Enable
    $0f constant FDCAN_IWTGE                    \ [0x0f] Initialization Watch Trigger Interrupt Enable
    $10 constant FDCAN_WTE                      \ [0x10] Watch Trigger Interrupt Enable
    $11 constant FDCAN_AWE                      \ [0x11] Application Watchdog Interrupt Enable
    $12 constant FDCAN_CERE                     \ [0x12] Configuration Error Interrupt Enable
  [then]


  [ifdef] FDCAN_FDCAN_TTILS_DEF
    \
    \ @brief FDCAN TT Interrupt Line Select Register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SBCL                     \ [0x00] Start of Basic Cycle Interrupt Line
    $01 constant FDCAN_SMCL                     \ [0x01] Start of Matrix Cycle Interrupt Line
    $02 constant FDCAN_CSML                     \ [0x02] Change of Synchronization Mode Interrupt Line
    $03 constant FDCAN_SOGL                     \ [0x03] Start of Gap Interrupt Line
    $04 constant FDCAN_RTMIL                    \ [0x04] Register Time Mark Interrupt Line
    $05 constant FDCAN_TTMIL                    \ [0x05] Trigger Time Mark Event Internal Interrupt Line
    $06 constant FDCAN_SWEL                     \ [0x06] Stop Watch Event Interrupt Line
    $07 constant FDCAN_GTWL                     \ [0x07] Global Time Wrap Interrupt Line
    $08 constant FDCAN_GTDL                     \ [0x08] Global Time Discontinuity Interrupt Line
    $09 constant FDCAN_GTEL                     \ [0x09] Global Time Error Interrupt Line
    $0a constant FDCAN_TXUL                     \ [0x0a] Tx Count Underflow Interrupt Line
    $0b constant FDCAN_TXOL                     \ [0x0b] Tx Count Overflow Interrupt Line
    $0c constant FDCAN_SE1L                     \ [0x0c] Scheduling Error 1 Interrupt Line
    $0d constant FDCAN_SE2L                     \ [0x0d] Scheduling Error 2 Interrupt Line
    $0e constant FDCAN_ELCL                     \ [0x0e] Change Error Level Interrupt Line
    $0f constant FDCAN_IWTGL                    \ [0x0f] Initialization Watch Trigger Interrupt Line
    $10 constant FDCAN_WTL                      \ [0x10] Watch Trigger Interrupt Line
    $11 constant FDCAN_AWL                      \ [0x11] Application Watchdog Interrupt Line
    $12 constant FDCAN_CERL                     \ [0x12] Configuration Error Interrupt Line
  [then]


  [ifdef] FDCAN_FDCAN_TTOST_DEF
    \
    \ @brief FDCAN TT Operation Status Register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EL                       \ [0x00 : 2] Error Level
    $02 constant FDCAN_MS                       \ [0x02 : 2] Master State.
    $04 constant FDCAN_SYS                      \ [0x04 : 2] Synchronization State
    $06 constant FDCAN_GTP                      \ [0x06] Quality of Global Time Phase
    $07 constant FDCAN_QCS                      \ [0x07] Quality of Clock Speed
    $08 constant FDCAN_RTO                      \ [0x08 : 8] Reference Trigger Offset
    $16 constant FDCAN_WGTD                     \ [0x16] Wait for Global Time Discontinuity
    $17 constant FDCAN_GFI                      \ [0x17] Gap Finished Indicator.
    $18 constant FDCAN_TMP                      \ [0x18 : 3] Time Master Priority
    $1b constant FDCAN_GSI                      \ [0x1b] Gap Started Indicator.
    $1c constant FDCAN_WFE                      \ [0x1c] Wait for Event
    $1d constant FDCAN_AWE                      \ [0x1d] Application Watchdog Event
    $1e constant FDCAN_WECS                     \ [0x1e] Wait for External Clock Synchronization
    $1f constant FDCAN_SPL                      \ [0x1f] Schedule Phase Lock
  [then]


  [ifdef] FDCAN_FDCAN_TURNA_DEF
    \
    \ @brief FDCAN TUR Numerator Actual Register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_NAV                      \ [0x00 : 18] Numerator Actual Value
  [then]


  [ifdef] FDCAN_FDCAN_TTLGT_DEF
    \
    \ @brief FDCAN TT Local and Global Time Register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_LT                       \ [0x00 : 16] Local Time
    $10 constant FDCAN_GT                       \ [0x10 : 16] Global Time
  [then]


  [ifdef] FDCAN_FDCAN_TTCTC_DEF
    \
    \ @brief FDCAN TT Cycle Time and Count Register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CT                       \ [0x00 : 16] Cycle Time
    $10 constant FDCAN_CC                       \ [0x10 : 6] Cycle Count
  [then]


  [ifdef] FDCAN_FDCAN_TTCPT_DEF
    \
    \ @brief FDCAN TT Capture Time Register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CT                       \ [0x00 : 6] Cycle Count Value
    $10 constant FDCAN_SWV                      \ [0x10 : 16] Stop Watch Value
  [then]


  [ifdef] FDCAN_FDCAN_TTCSM_DEF
    \
    \ @brief FDCAN TT Cycle Sync Mark Register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CSM                      \ [0x00 : 16] Cycle Sync Mark
  [then]


  [ifdef] FDCAN_FDCAN_TTTS_DEF
    \
    \ @brief FDCAN TT Trigger Select Register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SWTDEL                   \ [0x00 : 2] Stop watch trigger input selection
    $04 constant FDCAN_EVTSEL                   \ [0x04 : 2] Event trigger input selection
  [then]

  \
  \ @brief FDCAN1
  \
  $00 constant FDCAN_FDCAN_CREL         \ FDCAN Core Release Register
  $04 constant FDCAN_FDCAN_ENDN         \ FDCAN Core Release Register
  $0C constant FDCAN_FDCAN_DBTP         \ FDCAN Data Bit Timing and Prescaler Register
  $10 constant FDCAN_FDCAN_TEST         \ FDCAN Test Register
  $14 constant FDCAN_FDCAN_RWD          \ FDCAN RAM Watchdog Register
  $18 constant FDCAN_FDCAN_CCCR         \ FDCAN CC Control Register
  $1C constant FDCAN_FDCAN_NBTP         \ FDCAN Nominal Bit Timing and Prescaler Register
  $20 constant FDCAN_FDCAN_TSCC         \ FDCAN Timestamp Counter Configuration Register
  $24 constant FDCAN_FDCAN_TSCV         \ FDCAN Timestamp Counter Value Register
  $28 constant FDCAN_FDCAN_TOCC         \ FDCAN Timeout Counter Configuration Register
  $2C constant FDCAN_FDCAN_TOCV         \ FDCAN Timeout Counter Value Register
  $40 constant FDCAN_FDCAN_ECR          \ FDCAN Error Counter Register
  $44 constant FDCAN_FDCAN_PSR          \ FDCAN Protocol Status Register
  $48 constant FDCAN_FDCAN_TDCR         \ FDCAN Transmitter Delay Compensation Register
  $50 constant FDCAN_FDCAN_IR           \ FDCAN Interrupt Register
  $54 constant FDCAN_FDCAN_IE           \ FDCAN Interrupt Enable Register
  $58 constant FDCAN_FDCAN_ILS          \ FDCAN Interrupt Line Select Register
  $5C constant FDCAN_FDCAN_ILE          \ FDCAN Interrupt Line Enable Register
  $80 constant FDCAN_FDCAN_GFC          \ FDCAN Global Filter Configuration Register
  $84 constant FDCAN_FDCAN_SIDFC        \ FDCAN Standard ID Filter Configuration Register
  $88 constant FDCAN_FDCAN_XIDFC        \ FDCAN Extended ID Filter Configuration Register
  $90 constant FDCAN_FDCAN_XIDAM        \ FDCAN Extended ID and Mask Register
  $94 constant FDCAN_FDCAN_HPMS         \ FDCAN High Priority Message Status Register
  $98 constant FDCAN_FDCAN_NDAT1        \ FDCAN New Data 1 Register
  $9C constant FDCAN_FDCAN_NDAT2        \ FDCAN New Data 2 Register
  $A0 constant FDCAN_FDCAN_RXF0C        \ FDCAN Rx FIFO 0 Configuration Register
  $A4 constant FDCAN_FDCAN_RXF0S        \ FDCAN Rx FIFO 0 Status Register
  $A8 constant FDCAN_FDCAN_RXF0A        \ CAN Rx FIFO 0 Acknowledge Register
  $AC constant FDCAN_FDCAN_RXBC         \ FDCAN Rx Buffer Configuration Register
  $B0 constant FDCAN_FDCAN_RXF1C        \ FDCAN Rx FIFO 1 Configuration Register
  $B4 constant FDCAN_FDCAN_RXF1S        \ FDCAN Rx FIFO 1 Status Register
  $B8 constant FDCAN_FDCAN_RXF1A        \ FDCAN Rx FIFO 1 Acknowledge Register
  $BC constant FDCAN_FDCAN_RXESC        \ FDCAN Rx Buffer Element Size Configuration Register
  $C0 constant FDCAN_FDCAN_TXBC         \ FDCAN Tx Buffer Configuration Register
  $C4 constant FDCAN_FDCAN_TXFQS        \ FDCAN Tx FIFO/Queue Status Register
  $C8 constant FDCAN_FDCAN_TXESC        \ FDCAN Tx Buffer Element Size Configuration Register
  $CC constant FDCAN_FDCAN_TXBRP        \ FDCAN Tx Buffer Request Pending Register
  $D0 constant FDCAN_FDCAN_TXBAR        \ FDCAN Tx Buffer Add Request Register
  $D4 constant FDCAN_FDCAN_TXBCR        \ FDCAN Tx Buffer Cancellation Request Register
  $D8 constant FDCAN_FDCAN_TXBTO        \ FDCAN Tx Buffer Transmission Occurred Register
  $DC constant FDCAN_FDCAN_TXBCF        \ FDCAN Tx Buffer Cancellation Finished Register
  $E0 constant FDCAN_FDCAN_TXBTIE       \ FDCAN Tx Buffer Transmission Interrupt Enable Register
  $E4 constant FDCAN_FDCAN_TXBCIE       \ FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
  $F0 constant FDCAN_FDCAN_TXEFC        \ FDCAN Tx Event FIFO Configuration Register
  $F4 constant FDCAN_FDCAN_TXEFS        \ FDCAN Tx Event FIFO Status Register
  $F8 constant FDCAN_FDCAN_TXEFA        \ FDCAN Tx Event FIFO Acknowledge Register
  $100 constant FDCAN_FDCAN_TTTMC       \ FDCAN TT Trigger Memory Configuration Register
  $104 constant FDCAN_FDCAN_TTRMC       \ FDCAN TT Reference Message Configuration Register
  $108 constant FDCAN_FDCAN_TTOCF       \ FDCAN TT Operation Configuration Register
  $10C constant FDCAN_FDCAN_TTMLM       \ FDCAN TT Matrix Limits Register
  $110 constant FDCAN_FDCAN_TURCF       \ FDCAN TUR Configuration Register
  $114 constant FDCAN_FDCAN_TTOCN       \ FDCAN TT Operation Control Register
  $118 constant FDCAN_CAN_TTGTP         \ FDCAN TT Global Time Preset Register
  $11C constant FDCAN_FDCAN_TTTMK       \ FDCAN TT Time Mark Register
  $120 constant FDCAN_FDCAN_TTIR        \ FDCAN TT Interrupt Register
  $124 constant FDCAN_FDCAN_TTIE        \ FDCAN TT Interrupt Enable Register
  $128 constant FDCAN_FDCAN_TTILS       \ FDCAN TT Interrupt Line Select Register
  $12C constant FDCAN_FDCAN_TTOST       \ FDCAN TT Operation Status Register
  $130 constant FDCAN_FDCAN_TURNA       \ FDCAN TUR Numerator Actual Register
  $134 constant FDCAN_FDCAN_TTLGT       \ FDCAN TT Local and Global Time Register
  $138 constant FDCAN_FDCAN_TTCTC       \ FDCAN TT Cycle Time and Count Register
  $13C constant FDCAN_FDCAN_TTCPT       \ FDCAN TT Capture Time Register
  $140 constant FDCAN_FDCAN_TTCSM       \ FDCAN TT Cycle Sync Mark Register
  $300 constant FDCAN_FDCAN_TTTS        \ FDCAN TT Trigger Select Register

: FDCAN_DEF ; [then]
