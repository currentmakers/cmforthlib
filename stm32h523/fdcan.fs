\
\ @file fdcan.fs
\ @brief FDCAN register blank and RAM
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
    $00 constant FDCAN_DAY                      \ [0x00 : 8] 18
    $08 constant FDCAN_MON                      \ [0x08 : 8] 12
    $10 constant FDCAN_YEAR                     \ [0x10 : 4] 4
    $14 constant FDCAN_SUBSTEP                  \ [0x14 : 4] 1
    $18 constant FDCAN_STEP                     \ [0x18 : 4] 2
    $1c constant FDCAN_REL                      \ [0x1c : 4] 3
  [then]


  [ifdef] FDCAN_FDCAN_ENDN_DEF
    \
    \ @brief FDCAN endian register
    \ Address offset: 0x04
    \ Reset value: 0x87654321
    \
    $00 constant FDCAN_ETV                      \ [0x00 : 32] Endianness test value
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
    $10 constant FDCAN_DBRP                     \ [0x10 : 5] Data bit rate prescaler
    $17 constant FDCAN_TDC                      \ [0x17] Transceiver delay compensation
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


  [ifdef] FDCAN_FDCAN_RWD_DEF
    \
    \ @brief FDCAN RAM watchdog register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_WDC                      \ [0x00 : 8] Watchdog configuration
    $08 constant FDCAN_WDV                      \ [0x08 : 8] Watchdog value
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
    $09 constant FDCAN_BRSE                     \ [0x09] FDCAN bit rate switching
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
    $10 constant FDCAN_NBRP                     \ [0x10 : 9] Bit rate prescaler
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
    $00 constant FDCAN_ETOC                     \ [0x00] Timeout counter enable
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
    $06 constant FDCAN_EW                       \ [0x06] Warning Sstatus
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
    $00 constant FDCAN_RF0N                     \ [0x00] Rx FIFO 0 new message
    $01 constant FDCAN_RF0F                     \ [0x01] Rx FIFO 0 full
    $02 constant FDCAN_RF0L                     \ [0x02] Rx FIFO 0 message lost
    $03 constant FDCAN_RF1N                     \ [0x03] Rx FIFO 1 new message
    $04 constant FDCAN_RF1F                     \ [0x04] Rx FIFO 1 full
    $05 constant FDCAN_RF1L                     \ [0x05] Rx FIFO 1 message lost
    $06 constant FDCAN_HPM                      \ [0x06] High-priority message
    $07 constant FDCAN_TC                       \ [0x07] Transmission completed
    $08 constant FDCAN_TCF                      \ [0x08] Transmission cancellation finished
    $09 constant FDCAN_TFE                      \ [0x09] Tx FIFO empty
    $0a constant FDCAN_TEFN                     \ [0x0a] Tx event FIFO New Entry
    $0b constant FDCAN_TEFF                     \ [0x0b] Tx event FIFO full
    $0c constant FDCAN_TEFL                     \ [0x0c] Tx event FIFO element lost
    $0d constant FDCAN_TSW                      \ [0x0d] Timestamp wraparound
    $0e constant FDCAN_MRAF                     \ [0x0e] Message RAM access failure
    $0f constant FDCAN_TOO                      \ [0x0f] Timeout occurred
    $10 constant FDCAN_ELO                      \ [0x10] Error logging overflow
    $11 constant FDCAN_EP                       \ [0x11] Error passive
    $12 constant FDCAN_EW                       \ [0x12] Warning status
    $13 constant FDCAN_BO                       \ [0x13] Bus_Off status
    $14 constant FDCAN_WDI                      \ [0x14] Watchdog interrupt
    $15 constant FDCAN_PEA                      \ [0x15] Protocol error in arbitration phase (nominal bit time is used)
    $16 constant FDCAN_PED                      \ [0x16] Protocol error in data phase (data bit time is used)
    $17 constant FDCAN_ARA                      \ [0x17] Access to reserved address
  [then]


  [ifdef] FDCAN_FDCAN_IE_DEF
    \
    \ @brief FDCAN interrupt enable register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RF0NE                    \ [0x00] Rx FIFO 0 new message interrupt enable
    $01 constant FDCAN_RF0FE                    \ [0x01] Rx FIFO 0 full interrupt enable
    $02 constant FDCAN_RF0LE                    \ [0x02] Rx FIFO 0 message lost interrupt enable
    $03 constant FDCAN_RF1NE                    \ [0x03] Rx FIFO 1 new message interrupt enable
    $04 constant FDCAN_RF1FE                    \ [0x04] Rx FIFO 1 full interrupt enable
    $05 constant FDCAN_RF1LE                    \ [0x05] Rx FIFO 1 message lost interrupt enable
    $06 constant FDCAN_HPME                     \ [0x06] High-priority message interrupt enable
    $07 constant FDCAN_TCE                      \ [0x07] Transmission completed interrupt enable
    $08 constant FDCAN_TCFE                     \ [0x08] Transmission cancellation finished interrupt enable
    $09 constant FDCAN_TFEE                     \ [0x09] Tx FIFO empty interrupt enable
    $0a constant FDCAN_TEFNE                    \ [0x0a] Tx event FIFO new entry interrupt enable
    $0b constant FDCAN_TEFFE                    \ [0x0b] Tx event FIFO full interrupt enable
    $0c constant FDCAN_TEFLE                    \ [0x0c] Tx event FIFO element lost interrupt enable
    $0d constant FDCAN_TSWE                     \ [0x0d] Timestamp wraparound interrupt enable
    $0e constant FDCAN_MRAFE                    \ [0x0e] Message RAM access failure interrupt enable
    $0f constant FDCAN_TOOE                     \ [0x0f] Timeout occurred interrupt enable
    $10 constant FDCAN_ELOE                     \ [0x10] Error logging overflow interrupt enable
    $11 constant FDCAN_EPE                      \ [0x11] Error passive interrupt enable
    $12 constant FDCAN_EWE                      \ [0x12] Warning status interrupt enable
    $13 constant FDCAN_BOE                      \ [0x13] Bus_Off status
    $14 constant FDCAN_WDIE                     \ [0x14] Watchdog interrupt enable
    $15 constant FDCAN_PEAE                     \ [0x15] Protocol error in arbitration phase enable
    $16 constant FDCAN_PEDE                     \ [0x16] Protocol error in data phase enable
    $17 constant FDCAN_ARAE                     \ [0x17] Access to reserved address enable
  [then]


  [ifdef] FDCAN_FDCAN_ILS_DEF
    \
    \ @brief FDCAN interrupt line select register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RXFIFO0                  \ [0x00] RX FIFO bit grouping the following interruption
    $01 constant FDCAN_RXFIFO1                  \ [0x01] RX FIFO bit grouping the following interruption
    $02 constant FDCAN_SMSG                     \ [0x02] Status message bit grouping the following interruption
    $03 constant FDCAN_TFERR                    \ [0x03] Tx FIFO ERROR grouping the following interruption
    $04 constant FDCAN_MISC                     \ [0x04] Interrupt regrouping the following interruption
    $05 constant FDCAN_BERR                     \ [0x05] Bit and line error grouping the following interruption
    $06 constant FDCAN_PERR                     \ [0x06] Protocol error grouping the following interruption
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


  [ifdef] FDCAN_FDCAN_RXGFC_DEF
    \
    \ @brief FDCAN global filter configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_RRFE                     \ [0x00] Reject remote frames extended
    $01 constant FDCAN_RRFS                     \ [0x01] Reject remote frames standard
    $02 constant FDCAN_ANFE                     \ [0x02 : 2] Accept non-matching frames extended
    $04 constant FDCAN_ANFS                     \ [0x04 : 2] Accept Non-matching frames standard
    $08 constant FDCAN_F1OM                     \ [0x08] FIFO 1 operation mode (overwrite or blocking)
    $09 constant FDCAN_F0OM                     \ [0x09] FIFO 0 operation mode (overwrite or blocking)
    $10 constant FDCAN_LSS                      \ [0x10 : 5] List size standard
    $18 constant FDCAN_LSE                      \ [0x18 : 4] List size extended
  [then]


  [ifdef] FDCAN_FDCAN_XIDAM_DEF
    \
    \ @brief FDCAN extended ID and mask register
    \ Address offset: 0x84
    \ Reset value: 0x1FFFFFFF
    \
    $00 constant FDCAN_EIDM                     \ [0x00 : 29] Extended ID mask
  [then]


  [ifdef] FDCAN_FDCAN_HPMS_DEF
    \
    \ @brief FDCAN high-priority message status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_BIDX                     \ [0x00 : 3] Buffer index
    $06 constant FDCAN_MSI                      \ [0x06 : 2] Message storage indicator
    $08 constant FDCAN_FIDX                     \ [0x08 : 5] Filter index
    $0f constant FDCAN_FLST                     \ [0x0f] Filter list
  [then]


  [ifdef] FDCAN_FDCAN_RXF0S_DEF
    \
    \ @brief FDCAN Rx FIFO 0 status register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0FL                     \ [0x00 : 4] Rx FIFO 0 fill level
    $08 constant FDCAN_F0GI                     \ [0x08 : 2] Rx FIFO 0 get index
    $10 constant FDCAN_F0PI                     \ [0x10 : 2] Rx FIFO 0 put index
    $18 constant FDCAN_F0F                      \ [0x18] Rx FIFO 0 full
    $19 constant FDCAN_RF0L                     \ [0x19] Rx FIFO 0 message lost
  [then]


  [ifdef] FDCAN_FDCAN_RXF0A_DEF
    \
    \ @brief CAN Rx FIFO 0 acknowledge register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F0AI                     \ [0x00 : 3] Rx FIFO 0 acknowledge index
  [then]


  [ifdef] FDCAN_FDCAN_RXF1S_DEF
    \
    \ @brief FDCAN Rx FIFO 1 status register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F1FL                     \ [0x00 : 4] Rx FIFO 1 fill level
    $08 constant FDCAN_F1GI                     \ [0x08 : 2] Rx FIFO 1 get index
    $10 constant FDCAN_F1PI                     \ [0x10 : 2] Rx FIFO 1 put index
    $18 constant FDCAN_F1F                      \ [0x18] Rx FIFO 1 full
    $19 constant FDCAN_RF1L                     \ [0x19] Rx FIFO 1 message lost
  [then]


  [ifdef] FDCAN_FDCAN_RXF1A_DEF
    \
    \ @brief FDCAN Rx FIFO 1 acknowledge register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_F1AI                     \ [0x00 : 3] Rx FIFO 1 acknowledge index
  [then]


  [ifdef] FDCAN_FDCAN_TXBC_DEF
    \
    \ @brief FDCAN Tx buffer configuration register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $18 constant FDCAN_TFQM                     \ [0x18] Tx FIFO/queue mode
  [then]


  [ifdef] FDCAN_FDCAN_TXFQS_DEF
    \
    \ @brief FDCAN Tx FIFO/queue status register
    \ Address offset: 0xC4
    \ Reset value: 0x00000003
    \
    $00 constant FDCAN_TFFL                     \ [0x00 : 3] Tx FIFO free level
    $08 constant FDCAN_TFGI                     \ [0x08 : 2] Tx FIFO get index
    $10 constant FDCAN_TFQPI                    \ [0x10 : 2] Tx FIFO/queue put index
    $15 constant FDCAN_TFQF                     \ [0x15] Tx FIFO/queue full
  [then]


  [ifdef] FDCAN_FDCAN_TXBRP_DEF
    \
    \ @brief FDCAN Tx buffer request pending register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TRP                      \ [0x00 : 3] Transmission request pending
  [then]


  [ifdef] FDCAN_FDCAN_TXBAR_DEF
    \
    \ @brief FDCAN Tx buffer add request register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_AR                       \ [0x00 : 3] Add request
  [then]


  [ifdef] FDCAN_FDCAN_TXBCR_DEF
    \
    \ @brief FDCAN Tx buffer cancellation request register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CR                       \ [0x00 : 3] Cancellation request
  [then]


  [ifdef] FDCAN_FDCAN_TXBTO_DEF
    \
    \ @brief FDCAN Tx buffer transmission occurred register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TO                       \ [0x00 : 3] Transmission occurred.
  [then]


  [ifdef] FDCAN_FDCAN_TXBCF_DEF
    \
    \ @brief FDCAN Tx buffer cancellation finished register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CF                       \ [0x00 : 3] Cancellation finished
  [then]


  [ifdef] FDCAN_FDCAN_TXBTIE_DEF
    \
    \ @brief FDCAN Tx buffer transmission interrupt enable register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_TIE                      \ [0x00 : 3] Transmission interrupt enable
  [then]


  [ifdef] FDCAN_FDCAN_TXBCIE_DEF
    \
    \ @brief FDCAN Tx buffer cancellation finished interrupt enable register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_CFIE                     \ [0x00 : 3] Cancellation finished interrupt enable.
  [then]


  [ifdef] FDCAN_FDCAN_TXEFS_DEF
    \
    \ @brief FDCAN Tx event FIFO status register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EFFL                     \ [0x00 : 3] Event FIFO fill level
    $08 constant FDCAN_EFGI                     \ [0x08 : 2] Event FIFO get index
    $10 constant FDCAN_EFPI                     \ [0x10 : 2] Event FIFO put index
    $18 constant FDCAN_EFF                      \ [0x18] Event FIFO full
    $19 constant FDCAN_TEFL                     \ [0x19] Tx event FIFO element lost
  [then]


  [ifdef] FDCAN_FDCAN_TXEFA_DEF
    \
    \ @brief FDCAN Tx event FIFO acknowledge register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_EFAI                     \ [0x00 : 2] Event FIFO acknowledge index
  [then]


  [ifdef] FDCAN_FDCAN_CKDIV_DEF
    \
    \ @brief FDCAN CFG clock divider register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN_PDIV                     \ [0x00 : 4] input clock divider
  [then]

  \
  \ @brief FDCAN register blank and RAM
  \
  $00 constant FDCAN_FDCAN_CREL         \ FDCAN core release register
  $04 constant FDCAN_FDCAN_ENDN         \ FDCAN endian register
  $0C constant FDCAN_FDCAN_DBTP         \ FDCAN data bit timing and prescaler register
  $10 constant FDCAN_FDCAN_TEST         \ FDCAN test register
  $14 constant FDCAN_FDCAN_RWD          \ FDCAN RAM watchdog register
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
  $80 constant FDCAN_FDCAN_RXGFC        \ FDCAN global filter configuration register
  $84 constant FDCAN_FDCAN_XIDAM        \ FDCAN extended ID and mask register
  $88 constant FDCAN_FDCAN_HPMS         \ FDCAN high-priority message status register
  $90 constant FDCAN_FDCAN_RXF0S        \ FDCAN Rx FIFO 0 status register
  $94 constant FDCAN_FDCAN_RXF0A        \ CAN Rx FIFO 0 acknowledge register
  $98 constant FDCAN_FDCAN_RXF1S        \ FDCAN Rx FIFO 1 status register
  $9C constant FDCAN_FDCAN_RXF1A        \ FDCAN Rx FIFO 1 acknowledge register
  $C0 constant FDCAN_FDCAN_TXBC         \ FDCAN Tx buffer configuration register
  $C4 constant FDCAN_FDCAN_TXFQS        \ FDCAN Tx FIFO/queue status register
  $C8 constant FDCAN_FDCAN_TXBRP        \ FDCAN Tx buffer request pending register
  $CC constant FDCAN_FDCAN_TXBAR        \ FDCAN Tx buffer add request register
  $D0 constant FDCAN_FDCAN_TXBCR        \ FDCAN Tx buffer cancellation request register
  $D4 constant FDCAN_FDCAN_TXBTO        \ FDCAN Tx buffer transmission occurred register
  $D8 constant FDCAN_FDCAN_TXBCF        \ FDCAN Tx buffer cancellation finished register
  $DC constant FDCAN_FDCAN_TXBTIE       \ FDCAN Tx buffer transmission interrupt enable register
  $E0 constant FDCAN_FDCAN_TXBCIE       \ FDCAN Tx buffer cancellation finished interrupt enable register
  $E4 constant FDCAN_FDCAN_TXEFS        \ FDCAN Tx event FIFO status register
  $E8 constant FDCAN_FDCAN_TXEFA        \ FDCAN Tx event FIFO acknowledge register
  $100 constant FDCAN_FDCAN_CKDIV       \ FDCAN CFG clock divider register

: FDCAN_DEF ; [then]
