\
\ @file fdcan.fs
\ @brief FDCAN register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FDCAN_DEF

  [ifdef] FDCAN_FDCAN_CREL_DEF
    \
    \ @brief FDCAN core release register
    \ Address offset: 0x00
    \ Reset value: 0x32141218
    \
    $00 constant FDCAN_DAY                      \ [0x00 : 8] Timestamp day =18
    $08 constant FDCAN_MON                      \ [0x08 : 8] Timestamp month = 12
    $10 constant FDCAN_YEAR                     \ [0x10 : 4] Timestamp year = 4
    $14 constant FDCAN_SUBSTEP                  \ [0x14 : 4] Sub-step of core release = 1
    $18 constant FDCAN_STEP                     \ [0x18 : 4] Step of core release = 2
    $1c constant FDCAN_REL                      \ [0x1c : 4] Core release = 3
  [then]


  [ifdef] FDCAN_FDCAN_CCU_CREL_DEF
    \
    \ @brief FDCAN core release register
    \ Address offset: 0x00
    \ Reset value: 0x32141218
    \
    $00 constant FDCAN_DAY                      \ [0x00 : 8] Timestamp day = 18
    $08 constant FDCAN_MON                      \ [0x08 : 8] Timestamp month = 12
    $10 constant FDCAN_YEAR                     \ [0x10 : 4] Timestamp year =
    $14 constant FDCAN_SUBSTEP                  \ [0x14 : 4] Sub-step of core release = 1
    $18 constant FDCAN_STEP                     \ [0x18 : 4] Step of core release = 1
    $1c constant FDCAN_REL                      \ [0x1c : 4] Core release = 1
  [then]


  [ifdef] FDCAN_FDCAN_ENDN_DEF
    \
    \ @brief FDCAN Endian register
    \ Address offset: 0x04
    \ Reset value: 0x87654321
    \
    $00 constant FDCAN_ETV                      \ [0x00 : 32] Endiannes Test value
  [then]


  [ifdef] FDCAN_FDCAN_CCU_CCFG_DEF
    \
    \ @brief FDCAN Endian register
    \ Address offset: 0x04
    \ Reset value: 0x87654321
    \
    $00 constant FDCAN_TQBT                     \ [0x00 : 5] Time quanta per bit time
    $06 constant FDCAN_BCC                      \ [0x06] Bypass clock calibration
    $07 constant FDCAN_CFL                      \ [0x07] Calibration field length
    $08 constant FDCAN_OCPM                     \ [0x08 : 8] Oscillator clock periods minimum
    $10 constant FDCAN_CDIV                     \ [0x10 : 4] Clock divider
    $1f constant FDCAN_SWR                      \ [0x1f] Software reset
  [then]


  [ifdef] FDCAN_FDCAN_CCU_CSTAT_DEF
    \
    \ @brief Calibration status register
    \ Address offset: 0x08
    \ Reset value: 0x0203FFFF
    \
    $00 constant FDCAN_OCPC                     \ [0x00 : 18] Oscillator clock period counter
    $12 constant FDCAN_TQC                      \ [0x12 : 11] Time quanta counter
    $1e constant FDCAN_CALS                     \ [0x1e : 2] Calibration state
  [then]


  [ifdef] FDCAN_FDCAN_DBTP_DEF
    \
    \ @brief FDCAN data bit timing and prescaler register
    \ Address offset: 0x0C
    \ Reset value: 0x00000A33
    \
    $00 constant FDCAN_DSJW                     \ [0x00 : 4] Synchronization jump width
    $04 constant FDCAN_DTSEG2                   \ [0x04 : 4] Data time segment after sample point
    $08 constant FDCAN_DTSEG1                   \ [0x08 : 5] Data time segment before sample point
    $10 constant FDCAN_DBRP                     \ [0x10 : 5] Data bitrate prescaler
    $17 constant FDCAN_TDC                      \ [0x17] Transceiver delay compensation
  [then]


  [ifdef] FDCAN_FDCAN_CCU_CWD_DEF
    \
    \ @brief FDCAN data bit timing and prescaler register
    \ Address offset: 0x0C
    \ Reset value: 0x00000A33
    \
    $00 constant FDCAN_WDC                      \ [0x00 : 16] WDC
    $10 constant FDCAN_WDV                      \ [0x10 : 16] Watchdog value
  [then]


  [ifdef] FDCAN_FDCAN_TEST_DEF
    \
    \ @brief FDCAN test register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant FDCAN_LBCK                     \ [0x04] Loop back mode
    $05 constant FDCAN_TX                       \ [0x05 : 2] Control of transmit pin
    $07 constant FDCAN_RX                       \ [0x07] Receive pin
  [then]


  [ifdef] FDCAN_FDCAN_CCU_IR_DEF
    \
    \ @brief FDCAN test register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CWE                      \ [0x00] Calibration watchdog event
    $01 constant FDCAN_CSC                      \ [0x01] Calibration state changed
  [then]


  [ifdef] FDCAN_FDCAN_RWD_DEF
    \
    \ @brief FDCAN RAM watchdog register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_WDC                      \ [0x00 : 8] Watchdog configuration
    $08 constant FDCAN_WDV                      \ [0x08 : 8] Watchdog value
  [then]


  [ifdef] FDCAN_FDCAN_CCU_IE_DEF
    \
    \ @brief FDCAN RAM watchdog register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CWEE                     \ [0x00] Calibration watchdog event enable
    $01 constant FDCAN_CSCE                     \ [0x01] Calibration state changed enable
  [then]


  [ifdef] FDCAN_FDCAN_CCCR_DEF
    \
    \ @brief FDCAN CC control register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant FDCAN_INIT                     \ [0x00] Initialization
    $01 constant FDCAN_CCE                      \ [0x01] Configuration change enable
    $02 constant FDCAN_ASM                      \ [0x02] ASM restricted operation mode
    $03 constant FDCAN_CSA                      \ [0x03] Clock stop acknowledge
    $04 constant FDCAN_CSR                      \ [0x04] Clock stop request
    $05 constant FDCAN_MON                      \ [0x05] Bus monitoring mode
    $06 constant FDCAN_DAR                      \ [0x06] Disable automatic retransmission
    $07 constant FDCAN_TEST                     \ [0x07] Test mode enable
    $08 constant FDCAN_FDOE                     \ [0x08] FD operation enable
    $09 constant FDCAN_BRSE                     \ [0x09] FDCAN bitrate switching
    $0c constant FDCAN_PXHD                     \ [0x0c] Protocol exception handling disable
    $0d constant FDCAN_EFBI                     \ [0x0d] Edge filtering during bus integration
    $0e constant FDCAN_TXP                      \ [0x0e] If this bit is set, the FDCAN pauses for two CAN bit times before starting the next transmission after successfully transmitting a frame.
    $0f constant FDCAN_NISO                     \ [0x0f] Non ISO operation
  [then]


  [ifdef] FDCAN_FDCAN_NBTP_DEF
    \
    \ @brief FDCAN nominal bit timing and prescaler register
    \ Address offset: 0x1C
    \ Reset value: 0x06000A03
    \
    $00 constant FDCAN_NTSEG2                   \ [0x00 : 7] Nominal time segment after sample point
    $08 constant FDCAN_NTSEG1                   \ [0x08 : 8] Nominal time segment before sample point
    $10 constant FDCAN_NBRP                     \ [0x10 : 9] Bitrate prescaler
    $19 constant FDCAN_NSJW                     \ [0x19 : 7] Nominal (re)synchronization jump width
  [then]


  [ifdef] FDCAN_FDCAN_TSCC_DEF
    \
    \ @brief FDCAN timestamp counter configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TSS                      \ [0x00 : 2] Timestamp select
    $10 constant FDCAN_TCP                      \ [0x10 : 4] Timestamp counter prescaler
  [then]


  [ifdef] FDCAN_FDCAN_TSCV_DEF
    \
    \ @brief FDCAN timestamp counter value register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TSC                      \ [0x00 : 16] Timestamp counter
  [then]


  [ifdef] FDCAN_FDCAN_TOCC_DEF
    \
    \ @brief FDCAN timeout counter configuration register
    \ Address offset: 0x28
    \ Reset value: 0xFFFF0000
    \
    $00 constant FDCAN_ETOC                     \ [0x00] Enable timeout counter
    $01 constant FDCAN_TOS                      \ [0x01 : 2] Timeout select
    $10 constant FDCAN_TOP                      \ [0x10 : 16] Timeout period
  [then]


  [ifdef] FDCAN_FDCAN_TOCV_DEF
    \
    \ @brief FDCAN timeout counter value register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant FDCAN_TOC                      \ [0x00 : 16] Timeout counter
  [then]


  [ifdef] FDCAN_FDCAN_ECR_DEF
    \
    \ @brief FDCAN error counter register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TEC                      \ [0x00 : 8] Transmit error counter
    $08 constant FDCAN_REC                      \ [0x08 : 7] Receive error counter
    $0f constant FDCAN_RP                       \ [0x0f] Receive error passive
    $10 constant FDCAN_CEL                      \ [0x10 : 8] CAN error logging
  [then]


  [ifdef] FDCAN_FDCAN_PSR_DEF
    \
    \ @brief FDCAN protocol status register
    \ Address offset: 0x44
    \ Reset value: 0x00000707
    \
    $00 constant FDCAN_LEC                      \ [0x00 : 3] Last error code
    $03 constant FDCAN_ACT                      \ [0x03 : 2] Activity
    $05 constant FDCAN_EP                       \ [0x05] Error passive
    $06 constant FDCAN_EW                       \ [0x06] Warning status
    $07 constant FDCAN_BO                       \ [0x07] Bus_Off status
    $08 constant FDCAN_DLEC                     \ [0x08 : 3] Data last error code
    $0b constant FDCAN_RESI                     \ [0x0b] ESI flag of last received FDCAN message
    $0c constant FDCAN_RBRS                     \ [0x0c] BRS flag of last received FDCAN message
    $0d constant FDCAN_REDL                     \ [0x0d] Received FDCAN message
    $0e constant FDCAN_PXE                      \ [0x0e] Protocol exception event
    $10 constant FDCAN_TDCV                     \ [0x10 : 7] Transmitter delay compensation value
  [then]


  [ifdef] FDCAN_FDCAN_TDCR_DEF
    \
    \ @brief FDCAN transmitter delay compensation register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TDCF                     \ [0x00 : 7] Transmitter delay compensation filter window length
    $08 constant FDCAN_TDCO                     \ [0x08 : 7] Transmitter delay compensation offset
  [then]


  [ifdef] FDCAN_FDCAN_IR_DEF
    \
    \ @brief FDCAN interrupt register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0N                     \ [0x00] Rx FIFO 0 New message
    $01 constant FDCAN_RF0W                     \ [0x01] Rx FIFO 0 watermark reached
    $02 constant FDCAN_RF0F                     \ [0x02] Rx FIFO 0 full
    $03 constant FDCAN_RF0L                     \ [0x03] Rx FIFO 0 message lost
    $04 constant FDCAN_RF1N                     \ [0x04] Rx FIFO 1 new message
    $05 constant FDCAN_RF1W                     \ [0x05] Rx FIFO 1 watermark reached
    $06 constant FDCAN_RF1F                     \ [0x06] Rx FIFO 1 full
    $07 constant FDCAN_RF1L                     \ [0x07] Rx FIFO 1 message lost
    $08 constant FDCAN_HPM                      \ [0x08] High priority message
    $09 constant FDCAN_TC                       \ [0x09] Transmission completed
    $0a constant FDCAN_TCF                      \ [0x0a] Transmission cancellation finished
    $0b constant FDCAN_TFE                      \ [0x0b] Tx FIFO empty
    $0c constant FDCAN_TEFN                     \ [0x0c] Tx event FIFO new entry
    $0d constant FDCAN_TEFW                     \ [0x0d] Tx event FIFO watermark reached
    $0e constant FDCAN_TEFF                     \ [0x0e] Tx event FIFO full
    $0f constant FDCAN_TEFL                     \ [0x0f] Tx event FIFO element lost
    $10 constant FDCAN_TSW                      \ [0x10] Timestamp wraparound
    $11 constant FDCAN_MRAF                     \ [0x11] Message RAM access failure
    $12 constant FDCAN_TOO                      \ [0x12] Timeout occurred
    $13 constant FDCAN_DRX                      \ [0x13] Message stored to dedicated Rx buffer
    $16 constant FDCAN_ELO                      \ [0x16] Error logging overflow
    $17 constant FDCAN_EP                       \ [0x17] Error passive
    $18 constant FDCAN_EW                       \ [0x18] Warning status
    $19 constant FDCAN_BO                       \ [0x19] Bus_Off status
    $1a constant FDCAN_WDI                      \ [0x1a] Watchdog interrupt
    $1b constant FDCAN_PEA                      \ [0x1b] Protocol error in arbitration phase (nominal bit time is used)
    $1c constant FDCAN_PED                      \ [0x1c] Protocol error in data phase (data bit time is used)
    $1d constant FDCAN_ARA                      \ [0x1d] Access to reserved address
  [then]


  [ifdef] FDCAN_FDCAN_IE_DEF
    \
    \ @brief FDCAN interrupt enable register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0NE                    \ [0x00] Rx FIFO 0 new message interrupt enable
    $01 constant FDCAN_RF0WE                    \ [0x01] Rx FIFO 0 watermark reached interrupt enable
    $02 constant FDCAN_RF0FE                    \ [0x02] Rx FIFO 0 full interrupt enable
    $03 constant FDCAN_RF0LE                    \ [0x03] Rx FIFO 0 message lost interrupt enable
    $04 constant FDCAN_RF1NE                    \ [0x04] Rx FIFO 1 new message interrupt enable
    $05 constant FDCAN_RF1WE                    \ [0x05] Rx FIFO 1 watermark reached interrupt enable
    $06 constant FDCAN_RF1FE                    \ [0x06] Rx FIFO 1 full interrupt enable
    $07 constant FDCAN_RF1LE                    \ [0x07] Rx FIFO 1 message lost interrupt enable
    $08 constant FDCAN_HPME                     \ [0x08] High priority message interrupt enable
    $09 constant FDCAN_TCE                      \ [0x09] Transmission completed interrupt enable
    $0a constant FDCAN_TCFE                     \ [0x0a] Transmission cancellation finished interrupt enable
    $0b constant FDCAN_TFEE                     \ [0x0b] Tx FIFO empty interrupt enable
    $0c constant FDCAN_TEFNE                    \ [0x0c] Tx event FIFO new entry interrupt enable
    $0d constant FDCAN_TEFWE                    \ [0x0d] Tx event FIFO watermark reached interrupt enable
    $0e constant FDCAN_TEFFE                    \ [0x0e] Tx event FIFO full interrupt enable
    $0f constant FDCAN_TEFLE                    \ [0x0f] Tx event FIFO element lost interrupt enable
    $10 constant FDCAN_TSWE                     \ [0x10] Timestamp wraparound interrupt enable
    $11 constant FDCAN_MRAFE                    \ [0x11] Message RAM access failure interrupt enable
    $12 constant FDCAN_TOOE                     \ [0x12] Timeout occurred interrupt enable
    $13 constant FDCAN_DRXE                     \ [0x13] Message stored to dedicated Rx buffer interrupt enable
    $16 constant FDCAN_ELOE                     \ [0x16] Error logging overflow interrupt enable
    $17 constant FDCAN_EPE                      \ [0x17] Error passive interrupt enable
    $18 constant FDCAN_EWE                      \ [0x18] Warning status interrupt enable
    $19 constant FDCAN_BOE                      \ [0x19] Bus_Off status
    $1a constant FDCAN_WDIE                     \ [0x1a] Watchdog interrupt enable
    $1b constant FDCAN_PEAE                     \ [0x1b] Protocol error in Arbitration phase enable
    $1c constant FDCAN_PEDE                     \ [0x1c] Protocol error in data phase enable
    $1d constant FDCAN_ARAE                     \ [0x1d] Access to Reserved address enable
  [then]


  [ifdef] FDCAN_FDCAN_ILS_DEF
    \
    \ @brief FDCAN interrupt line select register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0NL                    \ [0x00] Rx FIFO 0 new message interrupt line
    $01 constant FDCAN_RF0WL                    \ [0x01] Rx FIFO 0 watermark reached interrupt line
    $02 constant FDCAN_RF0FL                    \ [0x02] Rx FIFO 0 full interrupt line
    $03 constant FDCAN_RF0LL                    \ [0x03] Rx FIFO 0 message lost interrupt line
    $04 constant FDCAN_RF1NL                    \ [0x04] Rx FIFO 1 new message interrupt line
    $05 constant FDCAN_RF1WL                    \ [0x05] Rx FIFO 1 watermark reached interrupt line
    $06 constant FDCAN_RF1FL                    \ [0x06] Rx FIFO 1 full interrupt line
    $07 constant FDCAN_RF1LL                    \ [0x07] Rx FIFO 1 message lost interrupt line
    $08 constant FDCAN_HPML                     \ [0x08] High priority message interrupt line
    $09 constant FDCAN_TCL                      \ [0x09] Transmission completed interrupt line
    $0a constant FDCAN_TCFL                     \ [0x0a] Transmission cancellation finished interrupt line
    $0b constant FDCAN_TFEL                     \ [0x0b] Tx FIFO empty interrupt line
    $0c constant FDCAN_TEFNL                    \ [0x0c] Tx event FIFO new entry interrupt line
    $0d constant FDCAN_TEFWL                    \ [0x0d] Tx event FIFO watermark reached interrupt line
    $0e constant FDCAN_TEFFL                    \ [0x0e] Tx event FIFO full interrupt line
    $0f constant FDCAN_TEFLL                    \ [0x0f] Tx event FIFO element Lost interrupt line
    $10 constant FDCAN_TSWL                     \ [0x10] Timestamp wraparound interrupt line
    $11 constant FDCAN_MRAFL                    \ [0x11] Message RAM access failure interrupt line
    $12 constant FDCAN_TOOL                     \ [0x12] Timeout occurred interrupt line
    $13 constant FDCAN_DRXL                     \ [0x13] Message stored to dedicated Rx buffer interrupt line
    $16 constant FDCAN_ELOL                     \ [0x16] Error logging overflow interrupt line
    $17 constant FDCAN_EPL                      \ [0x17] Error passive interrupt line
    $18 constant FDCAN_EWL                      \ [0x18] Warning status interrupt line
    $19 constant FDCAN_BOL                      \ [0x19] Bus_Off status
    $1a constant FDCAN_WDIL                     \ [0x1a] Watchdog interrupt line
    $1b constant FDCAN_PEAL                     \ [0x1b] Protocol error in arbitration phase line
    $1c constant FDCAN_PEDL                     \ [0x1c] Protocol error in data phase line
    $1d constant FDCAN_ARAL                     \ [0x1d] Access to reserved address line
  [then]


  [ifdef] FDCAN_FDCAN_ILE_DEF
    \
    \ @brief FDCAN interrupt line enable register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EINT0                    \ [0x00] Enable interrupt line 0
    $01 constant FDCAN_EINT1                    \ [0x01] Enable interrupt line 1
  [then]


  [ifdef] FDCAN_FDCAN_GFC_DEF
    \
    \ @brief FDCAN global filter configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RRFE                     \ [0x00] Reject remote frames extended
    $01 constant FDCAN_RRFS                     \ [0x01] Reject remote frames standard
    $02 constant FDCAN_ANFE                     \ [0x02 : 2] Accept non-matching frames extended
    $04 constant FDCAN_ANFS                     \ [0x04 : 2] Accept non-matching frames standard
  [then]


  [ifdef] FDCAN_FDCAN_SIDFC_DEF
    \
    \ @brief FDCAN standard ID filter configuration register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_FLSSA                    \ [0x02 : 14] Filter list standard start address
    $10 constant FDCAN_LSS                      \ [0x10 : 8] List size standard
  [then]


  [ifdef] FDCAN_FDCAN_XIDFC_DEF
    \
    \ @brief FDCAN extended ID filter configuration register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_FLESA                    \ [0x02 : 14] Filter list extended start address
    $10 constant FDCAN_LSE                      \ [0x10 : 8] List size extended
  [then]


  [ifdef] FDCAN_FDCAN_XIDAM_DEF
    \
    \ @brief FDCAN extended ID and mask register
    \ Address offset: 0x90
    \ Reset value: 0x1FFFFFFF
    \
    $00 constant FDCAN_EIDM                     \ [0x00 : 29] Extended ID Mask
  [then]


  [ifdef] FDCAN_FDCAN_HPMS_DEF
    \
    \ @brief FDCAN high priority message status register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_BIDX                     \ [0x00 : 6] Buffer index
    $06 constant FDCAN_MSI                      \ [0x06 : 2] Message storage indicator
    $08 constant FDCAN_FIDX                     \ [0x08 : 7] Filter index
    $0f constant FDCAN_FLST                     \ [0x0f] Filter list
  [then]


  [ifdef] FDCAN_FDCAN_NDAT1_DEF
    \
    \ @brief FDCAN new data 1 register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_ND0                      \ [0x00] New data[31:0]
    $01 constant FDCAN_ND1                      \ [0x01] New data[31:0]
    $02 constant FDCAN_ND2                      \ [0x02] New data[31:0]
    $03 constant FDCAN_ND3                      \ [0x03] New data[31:0]
    $04 constant FDCAN_ND4                      \ [0x04] New data[31:0]
    $05 constant FDCAN_ND5                      \ [0x05] New data[31:0]
    $06 constant FDCAN_ND6                      \ [0x06] New data[31:0]
    $07 constant FDCAN_ND7                      \ [0x07] New data[31:0]
    $08 constant FDCAN_ND8                      \ [0x08] New data[31:0]
    $09 constant FDCAN_ND9                      \ [0x09] New data[31:0]
    $0a constant FDCAN_ND10                     \ [0x0a] New data[31:0]
    $0b constant FDCAN_ND11                     \ [0x0b] New data[31:0]
    $0c constant FDCAN_ND12                     \ [0x0c] New data[31:0]
    $0d constant FDCAN_ND13                     \ [0x0d] New data[31:0]
    $0e constant FDCAN_ND14                     \ [0x0e] New data[31:0]
    $0f constant FDCAN_ND15                     \ [0x0f] New data[31:0]
    $10 constant FDCAN_ND16                     \ [0x10] New data[31:0]
    $11 constant FDCAN_ND17                     \ [0x11] New data[31:0]
    $12 constant FDCAN_ND18                     \ [0x12] New data[31:0]
    $13 constant FDCAN_ND19                     \ [0x13] New data[31:0]
    $14 constant FDCAN_ND20                     \ [0x14] New data[31:0]
    $15 constant FDCAN_ND21                     \ [0x15] New data[31:0]
    $16 constant FDCAN_ND22                     \ [0x16] New data[31:0]
    $17 constant FDCAN_ND23                     \ [0x17] New data[31:0]
    $18 constant FDCAN_ND24                     \ [0x18] New data[31:0]
    $19 constant FDCAN_ND25                     \ [0x19] New data[31:0]
    $1a constant FDCAN_ND26                     \ [0x1a] New data[31:0]
    $1b constant FDCAN_ND27                     \ [0x1b] New data[31:0]
    $1c constant FDCAN_ND28                     \ [0x1c] New data[31:0]
    $1d constant FDCAN_ND29                     \ [0x1d] New data[31:0]
    $1e constant FDCAN_ND30                     \ [0x1e] New data[31:0]
    $1f constant FDCAN_ND31                     \ [0x1f] New data[31:0]
  [then]


  [ifdef] FDCAN_FDCAN_NDAT2_DEF
    \
    \ @brief FDCAN new data 2 register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_ND32                     \ [0x00] New data[63:32]
    $01 constant FDCAN_ND33                     \ [0x01] New data[63:32]
    $02 constant FDCAN_ND34                     \ [0x02] New data[63:32]
    $03 constant FDCAN_ND35                     \ [0x03] New data[63:32]
    $04 constant FDCAN_ND36                     \ [0x04] New data[63:32]
    $05 constant FDCAN_ND37                     \ [0x05] New data[63:32]
    $06 constant FDCAN_ND38                     \ [0x06] New data[63:32]
    $07 constant FDCAN_ND39                     \ [0x07] New data[63:32]
    $08 constant FDCAN_ND40                     \ [0x08] New data[63:32]
    $09 constant FDCAN_ND41                     \ [0x09] New data[63:32]
    $0a constant FDCAN_ND42                     \ [0x0a] New data[63:32]
    $0b constant FDCAN_ND43                     \ [0x0b] New data[63:32]
    $0c constant FDCAN_ND44                     \ [0x0c] New data[63:32]
    $0d constant FDCAN_ND45                     \ [0x0d] New data[63:32]
    $0e constant FDCAN_ND46                     \ [0x0e] New data[63:32]
    $0f constant FDCAN_ND47                     \ [0x0f] New data[63:32]
    $10 constant FDCAN_ND48                     \ [0x10] New data[63:32]
    $11 constant FDCAN_ND49                     \ [0x11] New data[63:32]
    $12 constant FDCAN_ND50                     \ [0x12] New data[63:32]
    $13 constant FDCAN_ND51                     \ [0x13] New data[63:32]
    $14 constant FDCAN_ND52                     \ [0x14] New data[63:32]
    $15 constant FDCAN_ND53                     \ [0x15] New data[63:32]
    $16 constant FDCAN_ND54                     \ [0x16] New data[63:32]
    $17 constant FDCAN_ND55                     \ [0x17] New data[63:32]
    $18 constant FDCAN_ND56                     \ [0x18] New data[63:32]
    $19 constant FDCAN_ND57                     \ [0x19] New data[63:32]
    $1a constant FDCAN_ND58                     \ [0x1a] New data[63:32]
    $1b constant FDCAN_ND59                     \ [0x1b] New data[63:32]
    $1c constant FDCAN_ND60                     \ [0x1c] New data[63:32]
    $1d constant FDCAN_ND61                     \ [0x1d] New data[63:32]
    $1e constant FDCAN_ND62                     \ [0x1e] New data[63:32]
    $1f constant FDCAN_ND63                     \ [0x1f] New data[63:32]
  [then]


  [ifdef] FDCAN_FDCAN_RXF0C_DEF
    \
    \ @brief FDCAN Rx FIFO 0 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_F0SA                     \ [0x02 : 14] Rx FIFO 0 start address
    $10 constant FDCAN_F0S                      \ [0x10 : 7] Rx FIFO 0 size
    $18 constant FDCAN_F0WM                     \ [0x18 : 7] FIFO 0 watermark
    $1f constant FDCAN_F0OM                     \ [0x1f] FIFO 0 operation mode
  [then]


  [ifdef] FDCAN_FDCAN_RXF0S_DEF
    \
    \ @brief FDCAN Rx FIFO 0 status register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0FL                     \ [0x00 : 7] Rx FIFO 0 fill level
    $08 constant FDCAN_F0GI                     \ [0x08 : 6] Rx FIFO 0 get index
    $10 constant FDCAN_F0PI                     \ [0x10 : 6] Rx FIFO 0 put index
    $18 constant FDCAN_F0F                      \ [0x18] Rx FIFO 0 full
    $19 constant FDCAN_RF0L                     \ [0x19] Rx FIFO 0 message lost
  [then]


  [ifdef] FDCAN_FDCAN_RXF0A_DEF
    \
    \ @brief FDCAN Rx FIFO 0 acknowledge register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0AI                     \ [0x00 : 6] Rx FIFO 0 acknowledge index
  [then]


  [ifdef] FDCAN_FDCAN_RXBC_DEF
    \
    \ @brief FDCAN Rx buffer configuration register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_RBSA                     \ [0x02 : 14] Rx buffer start address
  [then]


  [ifdef] FDCAN_FDCAN_RXF1C_DEF
    \
    \ @brief FDCAN Rx FIFO 1 configuration register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_F1SA                     \ [0x02 : 14] Rx FIFO 1 start address
    $10 constant FDCAN_F1S                      \ [0x10 : 7] Rx FIFO 1 size
    $18 constant FDCAN_F1WM                     \ [0x18 : 7] Rx FIFO 1 watermark
    $1f constant FDCAN_F1OM                     \ [0x1f] FIFO 1 operation mode
  [then]


  [ifdef] FDCAN_FDCAN_RXF1S_DEF
    \
    \ @brief FDCAN Rx FIFO 1 status register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F1FL                     \ [0x00 : 7] Rx FIFO 1 fill level
    $08 constant FDCAN_F1GI                     \ [0x08 : 6] Rx FIFO 1 get index
    $10 constant FDCAN_F1PI                     \ [0x10 : 6] Rx FIFO 1 put index
    $18 constant FDCAN_F1F                      \ [0x18] Rx FIFO 1 full
    $19 constant FDCAN_RF1L                     \ [0x19] Rx FIFO 1 message lost
    $1e constant FDCAN_DMS                      \ [0x1e : 2] Debug message status
  [then]


  [ifdef] FDCAN_FDCAN_RXF1A_DEF
    \
    \ @brief FDCAN Rx FIFO 1 acknowledge register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F1AI                     \ [0x00 : 6] Rx FIFO 1 acknowledge index
  [then]


  [ifdef] FDCAN_FDCAN_RXESC_DEF
    \
    \ @brief FDCAN Rx buffer element size configuration register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0DS                     \ [0x00 : 3] Rx FIFO 1 data field size
    $04 constant FDCAN_F1DS                     \ [0x04 : 3] Rx FIFO 0 data field size
    $08 constant FDCAN_RBDS                     \ [0x08 : 3] Rx buffer data field size
  [then]


  [ifdef] FDCAN_FDCAN_TXBC_DEF
    \
    \ @brief FDCAN Tx buffer configuration register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_TBSA                     \ [0x02 : 14] Tx buffers start address
    $10 constant FDCAN_NDTB                     \ [0x10 : 6] Number of dedicated transmit buffers
    $18 constant FDCAN_TFQS                     \ [0x18 : 6] Transmit FIFO/queue size
    $1e constant FDCAN_TFQM                     \ [0x1e] Tx FIFO/queue mode
  [then]


  [ifdef] FDCAN_FDCAN_TXFQS_DEF
    \
    \ @brief FDCAN Tx FIFO/queue status register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TFFL                     \ [0x00 : 6] Tx FIFO free level
    $08 constant FDCAN_TFGI                     \ [0x08 : 5] Tx FIFO get index.
    $10 constant FDCAN_TFQPI                    \ [0x10 : 5] Tx FIFO/queue put index
    $15 constant FDCAN_TFQF                     \ [0x15] Tx FIFO/queue full
  [then]


  [ifdef] FDCAN_FDCAN_TXESC_DEF
    \
    \ @brief FDCAN Tx buffer element size configuration register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TBDS                     \ [0x00 : 3] Tx buffer data Field size:
  [then]


  [ifdef] FDCAN_FDCAN_TXBRP_DEF
    \
    \ @brief FDCAN Tx buffer request pending register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TRP                      \ [0x00 : 32] Transmission request pending
  [then]


  [ifdef] FDCAN_FDCAN_TXBAR_DEF
    \
    \ @brief FDCAN Tx buffer add request register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_AR                       \ [0x00 : 32] Add request
  [then]


  [ifdef] FDCAN_FDCAN_TXBCR_DEF
    \
    \ @brief FDCAN Tx buffer cancellation request register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CR                       \ [0x00 : 32] Cancellation request
  [then]


  [ifdef] FDCAN_FDCAN_TXBTO_DEF
    \
    \ @brief FDCAN Tx buffer transmission occurred register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TO                       \ [0x00 : 32] Transmission occurred
  [then]


  [ifdef] FDCAN_FDCAN_TXBCF_DEF
    \
    \ @brief FDCAN Tx buffer cancellation finished register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CF                       \ [0x00 : 32] Cancellation finished
  [then]


  [ifdef] FDCAN_FDCAN_TXBTIE_DEF
    \
    \ @brief FDCAN Tx buffer transmission interrupt enable register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TIE                      \ [0x00 : 32] Transmission interrupt enable
  [then]


  [ifdef] FDCAN_FDCAN_TXBCIE_DEF
    \
    \ @brief FDCAN Tx buffer cancellation finished interrupt enable register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CFIE                     \ [0x00 : 32] Cancellation finished interrupt enable
  [then]


  [ifdef] FDCAN_FDCAN_TXEFC_DEF
    \
    \ @brief FDCAN Tx event FIFO configuration register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_EFSA                     \ [0x02 : 14] Event FIFO start address
    $10 constant FDCAN_EFS                      \ [0x10 : 6] Event FIFO size.
    $18 constant FDCAN_EFWM                     \ [0x18 : 6] Event FIFO watermark
  [then]


  [ifdef] FDCAN_FDCAN_TXEFS_DEF
    \
    \ @brief FDCAN Tx event FIFO status register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EFFL                     \ [0x00 : 6] Event FIFO fill level
    $08 constant FDCAN_EFGI                     \ [0x08 : 5] Event FIFO get index
    $10 constant FDCAN_EFPI                     \ [0x10 : 5] Event FIFO put index
    $18 constant FDCAN_EFF                      \ [0x18] Event FIFO full
    $19 constant FDCAN_TEFL                     \ [0x19] Tx event FIFO element lost
  [then]


  [ifdef] FDCAN_FDCAN_TXEFA_DEF
    \
    \ @brief FDCAN Tx event FIFO acknowledge register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EFAI                     \ [0x00 : 5] Event FIFO acknowledge index
  [then]


  [ifdef] FDCAN_FDCAN_TTTMC_DEF
    \
    \ @brief FDCAN TT trigger memory configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $02 constant FDCAN_TMSA                     \ [0x02 : 14] Trigger memory start address.
    $10 constant FDCAN_TME                      \ [0x10 : 7] Trigger memory elements
  [then]


  [ifdef] FDCAN_FDCAN_TTRMC_DEF
    \
    \ @brief FDCAN TT reference message configuration register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RID                      \ [0x00 : 29] Reference identifier.
    $1e constant FDCAN_XTD                      \ [0x1e] Extended identifier
    $1f constant FDCAN_RMPS                     \ [0x1f] Reference message payload select
  [then]


  [ifdef] FDCAN_FDCAN_TTOCF_DEF
    \
    \ @brief FDCAN TT operation configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00010000
    \
    $00 constant FDCAN_OM                       \ [0x00 : 2] Operation mode.
    $03 constant FDCAN_GEN                      \ [0x03] Gap enable.
    $04 constant FDCAN_TM                       \ [0x04] Time master.
    $05 constant FDCAN_LDSDL                    \ [0x05 : 3] LD of synchronization deviation limit.
    $08 constant FDCAN_IRTO                     \ [0x08 : 7] Initial reference trigger offset.
    $0f constant FDCAN_EECS                     \ [0x0f] Enable external clock synchronization
    $10 constant FDCAN_AWL                      \ [0x10 : 8] Application watchdog limit.
    $18 constant FDCAN_EGTF                     \ [0x18] Enable global time filtering.
    $19 constant FDCAN_ECC                      \ [0x19] Enable clock calibration.
    $1a constant FDCAN_EVTP                     \ [0x1a] Event trigger polarity.
  [then]


  [ifdef] FDCAN_FDCAN_TTMLM_DEF
    \
    \ @brief FDCAN TT matrix limits register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CCM                      \ [0x00 : 6] Cycle count Max
    $06 constant FDCAN_CSS                      \ [0x06 : 2] Cycle start synchronization
    $08 constant FDCAN_TXEW                     \ [0x08 : 4] Tx enable window
    $10 constant FDCAN_ENTT                     \ [0x10 : 12] Expected number of Tx triggers
  [then]


  [ifdef] FDCAN_FDCAN_TURCF_DEF
    \
    \ @brief FDCAN TUR configuration register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_NCL                      \ [0x00 : 16] Numerator configuration low.
    $10 constant FDCAN_DC                       \ [0x10 : 14] Denominator configuration.
    $1f constant FDCAN_ELT                      \ [0x1f] Enable local time.
  [then]


  [ifdef] FDCAN_FDCAN_TTOCN_DEF
    \
    \ @brief FDCAN TT operation control register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SGT                      \ [0x00] Set global time.
    $01 constant FDCAN_ECS                      \ [0x01] External clock synchronization.
    $02 constant FDCAN_SWP                      \ [0x02] Stop watch polarity.
    $03 constant FDCAN_SWS                      \ [0x03 : 2] Stop watch source.
    $05 constant FDCAN_RTIE                     \ [0x05] Register time mark interrupt pulse enable.
    $06 constant FDCAN_TMC                      \ [0x06 : 2] Register time mark compare.
    $08 constant FDCAN_TTIE                     \ [0x08] Trigger time mark interrupt pulse enable
    $09 constant FDCAN_GCS                      \ [0x09] Gap control select
    $0a constant FDCAN_FGP                      \ [0x0a] Finish gap.
    $0b constant FDCAN_TMG                      \ [0x0b] Time mark gap.
    $0c constant FDCAN_NIG                      \ [0x0c] Next is gap.
    $0d constant FDCAN_ESCN                     \ [0x0d] External synchronization control
    $0f constant FDCAN_LCKC                     \ [0x0f] TT operation control register locked.
  [then]


  [ifdef] FDCAN_FDCAN_TTGTP_DEF
    \
    \ @brief FDCAN TT global time preset register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TP                       \ [0x00 : 16] Time preset
    $10 constant FDCAN_CTP                      \ [0x10 : 16] Cycle time target phase
  [then]


  [ifdef] FDCAN_FDCAN_TTTMK_DEF
    \
    \ @brief FDCAN TT time mark register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TM                       \ [0x00 : 16] Time mark
    $10 constant FDCAN_TICC                     \ [0x10 : 7] Time mark cycle code
    $1f constant FDCAN_LCKM                     \ [0x1f] TT time mark register locked
  [then]


  [ifdef] FDCAN_FDCAN_TTIR_DEF
    \
    \ @brief FDCAN TT interrupt register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SBC                      \ [0x00] Start of basic cycle
    $01 constant FDCAN_SMC                      \ [0x01] Start of matrix cycle
    $02 constant FDCAN_CSM                      \ [0x02] Change of synchronization mode
    $03 constant FDCAN_SOG                      \ [0x03] Start of gap
    $04 constant FDCAN_RTMI                     \ [0x04] Register time mark interrupt
    $05 constant FDCAN_TTMI                     \ [0x05] Trigger time mark event internal
    $06 constant FDCAN_SWE                      \ [0x06] Stop watch event
    $07 constant FDCAN_GTW                      \ [0x07] Global time wrap
    $08 constant FDCAN_GTD                      \ [0x08] Global time discontinuity
    $09 constant FDCAN_GTE                      \ [0x09] Global time error
    $0a constant FDCAN_TXU                      \ [0x0a] Tx count underflow
    $0b constant FDCAN_TXO                      \ [0x0b] Tx count overflow
    $0c constant FDCAN_SE1                      \ [0x0c] Scheduling error 1
    $0d constant FDCAN_SE2                      \ [0x0d] Scheduling error 2
    $0e constant FDCAN_ELC                      \ [0x0e] Error level changed
    $0f constant FDCAN_IWTG                     \ [0x0f] Initialization watch trigger
    $10 constant FDCAN_WT                       \ [0x10] Watch trigger
    $11 constant FDCAN_AW                       \ [0x11] Application watchdog
    $12 constant FDCAN_CER                      \ [0x12] Configuration error
  [then]


  [ifdef] FDCAN_FDCAN_TTIE_DEF
    \
    \ @brief FDCAN TT interrupt enable register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SBCE                     \ [0x00] Start of basic cycle interrupt enable
    $01 constant FDCAN_SMCE                     \ [0x01] Start of matrix cycle interrupt enable
    $02 constant FDCAN_CSME                     \ [0x02] Change of synchronization mode interrupt enable
    $03 constant FDCAN_SOGE                     \ [0x03] Start of gap interrupt enable
    $04 constant FDCAN_RTMIE                    \ [0x04] Register time mark interrupt enable
    $05 constant FDCAN_TTMIE                    \ [0x05] Trigger time mark event internal interrupt enable
    $06 constant FDCAN_SWEE                     \ [0x06] Stop watch event interrupt enable
    $07 constant FDCAN_GTWE                     \ [0x07] Global time wrap interrupt enable
    $08 constant FDCAN_GTDE                     \ [0x08] Global time discontinuity interrupt enable
    $09 constant FDCAN_GTEE                     \ [0x09] Global time error interrupt enable
    $0a constant FDCAN_TXUE                     \ [0x0a] Tx count underflow interrupt enable
    $0b constant FDCAN_TXOE                     \ [0x0b] Tx count overflow interrupt enable
    $0c constant FDCAN_SE1E                     \ [0x0c] Scheduling error 1 interrupt enable
    $0d constant FDCAN_SE2E                     \ [0x0d] Scheduling error 2 interrupt enable
    $0e constant FDCAN_ELCE                     \ [0x0e] Change error level interrupt enable
    $0f constant FDCAN_IWTE                     \ [0x0f] Initialization watch trigger interrupt enable
    $10 constant FDCAN_WTE                      \ [0x10] Watch trigger interrupt enable
    $11 constant FDCAN_AWE                      \ [0x11] Application watchdog interrupt enable
    $12 constant FDCAN_CERE                     \ [0x12] Configuration error interrupt enable
  [then]


  [ifdef] FDCAN_FDCAN_TTILS_DEF
    \
    \ @brief FDCAN TT interrupt line select register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SBCL                     \ [0x00] Start of basic cycle interrupt line
    $01 constant FDCAN_SMCL                     \ [0x01] Start of matrix cycle interrupt line
    $02 constant FDCAN_CSML                     \ [0x02] Change of synchronization mode interrupt line
    $03 constant FDCAN_SOGL                     \ [0x03] Start of gap interrupt line
    $04 constant FDCAN_RTMIL                    \ [0x04] Register time mark interrupt line
    $05 constant FDCAN_TTMIL                    \ [0x05] Trigger time mark event internal interrupt line
    $06 constant FDCAN_SWEL                     \ [0x06] Stop watch event interrupt line
    $07 constant FDCAN_GTWL                     \ [0x07] Global time wrap interrupt line
    $08 constant FDCAN_GTDL                     \ [0x08] Global time discontinuity interrupt line
    $09 constant FDCAN_GTEL                     \ [0x09] Global time error interrupt line
    $0a constant FDCAN_TXUL                     \ [0x0a] Tx count underflow interrupt line
    $0b constant FDCAN_TXOL                     \ [0x0b] Tx count overflow interrupt line
    $0c constant FDCAN_SE1L                     \ [0x0c] Scheduling error 1 interrupt line
    $0d constant FDCAN_SE2L                     \ [0x0d] Scheduling error 2 interrupt line
    $0e constant FDCAN_ELCL                     \ [0x0e] Change error level interrupt line
    $0f constant FDCAN_IWTL                     \ [0x0f] Initialization watch trigger interrupt line
    $10 constant FDCAN_WTL                      \ [0x10] Watch trigger interrupt line
    $11 constant FDCAN_AWL                      \ [0x11] Application watchdog interrupt line
    $12 constant FDCAN_CERL                     \ [0x12] Configuration error interrupt line
  [then]


  [ifdef] FDCAN_FDCAN_TTOST_DEF
    \
    \ @brief FDCAN TT operation status register
    \ Address offset: 0x12C
    \ Reset value: 0x00000080
    \
    $00 constant FDCAN_EL                       \ [0x00 : 2] Error level
    $02 constant FDCAN_MS                       \ [0x02 : 2] Master state
    $04 constant FDCAN_SYS                      \ [0x04 : 2] Synchronization state
    $06 constant FDCAN_QGTP                     \ [0x06] Quality of global time phase
    $07 constant FDCAN_QCS                      \ [0x07] Quality of clock speed
    $08 constant FDCAN_RTO                      \ [0x08 : 8] Reference trigger offset
    $16 constant FDCAN_WGTD                     \ [0x16] Wait for global time discontinuity
    $17 constant FDCAN_GFI                      \ [0x17] Gap finished indicator
    $18 constant FDCAN_TMP                      \ [0x18 : 3] Time master priority
    $1b constant FDCAN_GSI                      \ [0x1b] Gap started indicator
    $1c constant FDCAN_WFE                      \ [0x1c] Wait for event
    $1d constant FDCAN_AWE                      \ [0x1d] Application watchdog event
    $1e constant FDCAN_WECS                     \ [0x1e] Wait for external clock synchronization.
    $1f constant FDCAN_SPL                      \ [0x1f] Schedule phase lock
  [then]


  [ifdef] FDCAN_FDCAN_TURNA_DEF
    \
    \ @brief FDCAN TUR numerator actual register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_NAV                      \ [0x00 : 18] Numerator actual value
  [then]


  [ifdef] FDCAN_FDCAN_TTLGT_DEF
    \
    \ @brief FDCAN TT local and global time register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_LT                       \ [0x00 : 16] Local time
    $10 constant FDCAN_GT                       \ [0x10 : 16] Global time
  [then]


  [ifdef] FDCAN_FDCAN_TTCTC_DEF
    \
    \ @brief FDCAN TT cycle time and count register
    \ Address offset: 0x138
    \ Reset value: 0x003F0000
    \
    $00 constant FDCAN_CT                       \ [0x00 : 16] Cycle time
    $10 constant FDCAN_CC                       \ [0x10 : 6] Cycle count
  [then]


  [ifdef] FDCAN_FDCAN_TTCPT_DEF
    \
    \ @brief FDCAN TT capture time register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CCV                      \ [0x00 : 6] Cycle count value
    $10 constant FDCAN_SWV                      \ [0x10 : 16] Stop watch value
  [then]


  [ifdef] FDCAN_FDCAN_TTCSM_DEF
    \
    \ @brief FDCAN TT cycle sync mark register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CSM                      \ [0x00 : 16] Cycle sync mark
  [then]


  [ifdef] FDCAN_FDCAN_TTTS_DEF
    \
    \ @brief FDCAN TT trigger select register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_SWTDEL                   \ [0x00 : 2] Stop watch trigger input selection
    $04 constant FDCAN_EVTSEL                   \ [0x04 : 2] Event trigger input selection
  [then]

  \
  \ @brief FDCAN register block
  \
  $00 constant FDCAN_FDCAN_CREL         \ FDCAN core release register
  $00 constant FDCAN_FDCAN_CCU_CREL     \ FDCAN core release register
  $04 constant FDCAN_FDCAN_ENDN         \ FDCAN Endian register
  $04 constant FDCAN_FDCAN_CCU_CCFG     \ FDCAN Endian register
  $08 constant FDCAN_FDCAN_CCU_CSTAT    \ Calibration status register
  $0C constant FDCAN_FDCAN_DBTP         \ FDCAN data bit timing and prescaler register
  $0C constant FDCAN_FDCAN_CCU_CWD      \ FDCAN data bit timing and prescaler register
  $10 constant FDCAN_FDCAN_TEST         \ FDCAN test register
  $10 constant FDCAN_FDCAN_CCU_IR       \ FDCAN test register
  $14 constant FDCAN_FDCAN_RWD          \ FDCAN RAM watchdog register
  $14 constant FDCAN_FDCAN_CCU_IE       \ FDCAN RAM watchdog register
  $18 constant FDCAN_FDCAN_CCCR         \ FDCAN CC control register
  $1C constant FDCAN_FDCAN_NBTP         \ FDCAN nominal bit timing and prescaler register
  $20 constant FDCAN_FDCAN_TSCC         \ FDCAN timestamp counter configuration register
  $24 constant FDCAN_FDCAN_TSCV         \ FDCAN timestamp counter value register
  $28 constant FDCAN_FDCAN_TOCC         \ FDCAN timeout counter configuration register
  $2C constant FDCAN_FDCAN_TOCV         \ FDCAN timeout counter value register
  $40 constant FDCAN_FDCAN_ECR          \ FDCAN error counter register
  $44 constant FDCAN_FDCAN_PSR          \ FDCAN protocol status register
  $48 constant FDCAN_FDCAN_TDCR         \ FDCAN transmitter delay compensation register
  $50 constant FDCAN_FDCAN_IR           \ FDCAN interrupt register
  $54 constant FDCAN_FDCAN_IE           \ FDCAN interrupt enable register
  $58 constant FDCAN_FDCAN_ILS          \ FDCAN interrupt line select register
  $5C constant FDCAN_FDCAN_ILE          \ FDCAN interrupt line enable register
  $80 constant FDCAN_FDCAN_GFC          \ FDCAN global filter configuration register
  $84 constant FDCAN_FDCAN_SIDFC        \ FDCAN standard ID filter configuration register
  $88 constant FDCAN_FDCAN_XIDFC        \ FDCAN extended ID filter configuration register
  $90 constant FDCAN_FDCAN_XIDAM        \ FDCAN extended ID and mask register
  $94 constant FDCAN_FDCAN_HPMS         \ FDCAN high priority message status register
  $98 constant FDCAN_FDCAN_NDAT1        \ FDCAN new data 1 register
  $9C constant FDCAN_FDCAN_NDAT2        \ FDCAN new data 2 register
  $A0 constant FDCAN_FDCAN_RXF0C        \ FDCAN Rx FIFO 0 configuration register
  $A4 constant FDCAN_FDCAN_RXF0S        \ FDCAN Rx FIFO 0 status register
  $A8 constant FDCAN_FDCAN_RXF0A        \ FDCAN Rx FIFO 0 acknowledge register
  $AC constant FDCAN_FDCAN_RXBC         \ FDCAN Rx buffer configuration register
  $B0 constant FDCAN_FDCAN_RXF1C        \ FDCAN Rx FIFO 1 configuration register
  $B4 constant FDCAN_FDCAN_RXF1S        \ FDCAN Rx FIFO 1 status register
  $B8 constant FDCAN_FDCAN_RXF1A        \ FDCAN Rx FIFO 1 acknowledge register
  $BC constant FDCAN_FDCAN_RXESC        \ FDCAN Rx buffer element size configuration register
  $C0 constant FDCAN_FDCAN_TXBC         \ FDCAN Tx buffer configuration register
  $C4 constant FDCAN_FDCAN_TXFQS        \ FDCAN Tx FIFO/queue status register
  $C8 constant FDCAN_FDCAN_TXESC        \ FDCAN Tx buffer element size configuration register
  $CC constant FDCAN_FDCAN_TXBRP        \ FDCAN Tx buffer request pending register
  $D0 constant FDCAN_FDCAN_TXBAR        \ FDCAN Tx buffer add request register
  $D4 constant FDCAN_FDCAN_TXBCR        \ FDCAN Tx buffer cancellation request register
  $D8 constant FDCAN_FDCAN_TXBTO        \ FDCAN Tx buffer transmission occurred register
  $DC constant FDCAN_FDCAN_TXBCF        \ FDCAN Tx buffer cancellation finished register
  $E0 constant FDCAN_FDCAN_TXBTIE       \ FDCAN Tx buffer transmission interrupt enable register
  $E4 constant FDCAN_FDCAN_TXBCIE       \ FDCAN Tx buffer cancellation finished interrupt enable register
  $F0 constant FDCAN_FDCAN_TXEFC        \ FDCAN Tx event FIFO configuration register
  $F4 constant FDCAN_FDCAN_TXEFS        \ FDCAN Tx event FIFO status register
  $F8 constant FDCAN_FDCAN_TXEFA        \ FDCAN Tx event FIFO acknowledge register
  $100 constant FDCAN_FDCAN_TTTMC       \ FDCAN TT trigger memory configuration register
  $104 constant FDCAN_FDCAN_TTRMC       \ FDCAN TT reference message configuration register
  $108 constant FDCAN_FDCAN_TTOCF       \ FDCAN TT operation configuration register
  $10C constant FDCAN_FDCAN_TTMLM       \ FDCAN TT matrix limits register
  $110 constant FDCAN_FDCAN_TURCF       \ FDCAN TUR configuration register
  $114 constant FDCAN_FDCAN_TTOCN       \ FDCAN TT operation control register
  $118 constant FDCAN_FDCAN_TTGTP       \ FDCAN TT global time preset register
  $11C constant FDCAN_FDCAN_TTTMK       \ FDCAN TT time mark register
  $120 constant FDCAN_FDCAN_TTIR        \ FDCAN TT interrupt register
  $124 constant FDCAN_FDCAN_TTIE        \ FDCAN TT interrupt enable register
  $128 constant FDCAN_FDCAN_TTILS       \ FDCAN TT interrupt line select register
  $12C constant FDCAN_FDCAN_TTOST       \ FDCAN TT operation status register
  $130 constant FDCAN_FDCAN_TURNA       \ FDCAN TUR numerator actual register
  $134 constant FDCAN_FDCAN_TTLGT       \ FDCAN TT local and global time register
  $138 constant FDCAN_FDCAN_TTCTC       \ FDCAN TT cycle time and count register
  $13C constant FDCAN_FDCAN_TTCPT       \ FDCAN TT capture time register
  $140 constant FDCAN_FDCAN_TTCSM       \ FDCAN TT cycle sync mark register
  $300 constant FDCAN_FDCAN_TTTS        \ FDCAN TT trigger select register

: FDCAN_DEF ; [then]
