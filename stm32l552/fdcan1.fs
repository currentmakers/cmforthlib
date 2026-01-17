\
\ @file fdcan1.fs
\ @brief FDCAN1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FDCAN1_DEF

  [ifdef] FDCAN1_FDCAN_CREL_DEF
    \
    \ @brief FDCAN Core Release Register
    \ Address offset: 0x00
    \ Reset value: 0x32141218
    \
    $00 constant FDCAN1_DAY                     \ [0x00 : 8] Timestamp Day
    $08 constant FDCAN1_MON                     \ [0x08 : 8] Timestamp Month
    $10 constant FDCAN1_YEAR                    \ [0x10 : 4] Timestamp Year
    $14 constant FDCAN1_SUBSTEP                 \ [0x14 : 4] Sub-step of Core release
    $18 constant FDCAN1_STEP                    \ [0x18 : 4] Step of Core release
    $1c constant FDCAN1_REL                     \ [0x1c : 4] Core release
  [then]


  [ifdef] FDCAN1_FDCAN_ENDN_DEF
    \
    \ @brief FDCAN Core Release Register
    \ Address offset: 0x04
    \ Reset value: 0x87654321
    \
    $00 constant FDCAN1_ETV                     \ [0x00 : 32] Endiannes Test Value
  [then]


  [ifdef] FDCAN1_FDCAN_DBTP_DEF
    \
    \ @brief FDCAN Data Bit Timing and Prescaler Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000A33
    \
    $00 constant FDCAN1_DSJW                    \ [0x00 : 4] Synchronization Jump Width
    $04 constant FDCAN1_DTSEG2                  \ [0x04 : 4] Data time segment after sample point
    $08 constant FDCAN1_DTSEG1                  \ [0x08 : 5] Data time segment after sample point
    $10 constant FDCAN1_DBRP                    \ [0x10 : 5] Data BIt Rate Prescaler
    $17 constant FDCAN1_TDC                     \ [0x17] Transceiver Delay Compensation
  [then]


  [ifdef] FDCAN1_FDCAN_TEST_DEF
    \
    \ @brief FDCAN Test Register
    \ Address offset: 0x10
    \ Reset value: 0x00000010
    \
    $04 constant FDCAN1_LBCK                    \ [0x04] Loop Back mode
    $05 constant FDCAN1_TX                      \ [0x05 : 2] Loop Back mode
    $07 constant FDCAN1_RX                      \ [0x07] Control of Transmit Pin
  [then]


  [ifdef] FDCAN1_FDCAN_RWD_DEF
    \
    \ @brief FDCAN RAM Watchdog Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_WDC                     \ [0x00 : 8] Watchdog configuration
    $08 constant FDCAN1_WDV                     \ [0x08 : 8] Watchdog value
  [then]


  [ifdef] FDCAN1_FDCAN_CCCR_DEF
    \
    \ @brief FDCAN CC Control Register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant FDCAN1_INIT                    \ [0x00] Initialization
    $01 constant FDCAN1_CCE                     \ [0x01] Configuration Change Enable
    $02 constant FDCAN1_ASM                     \ [0x02] ASM Restricted Operation Mode
    $03 constant FDCAN1_CSA                     \ [0x03] Clock Stop Acknowledge
    $04 constant FDCAN1_CSR                     \ [0x04] Clock Stop Request
    $05 constant FDCAN1_MON                     \ [0x05] Bus Monitoring Mode
    $06 constant FDCAN1_DAR                     \ [0x06] Disable Automatic Retransmission
    $07 constant FDCAN1_TEST                    \ [0x07] Test Mode Enable
    $08 constant FDCAN1_FDOE                    \ [0x08] FD Operation Enable
    $09 constant FDCAN1_BSE                     \ [0x09] FDCAN Bit Rate Switching
    $0c constant FDCAN1_PXHD                    \ [0x0c] Protocol Exception Handling Disable
    $0d constant FDCAN1_EFBI                    \ [0x0d] Edge Filtering during Bus Integration
    $0e constant FDCAN1_TXP                     \ [0x0e] TXP
    $0f constant FDCAN1_NISO                    \ [0x0f] Non ISO Operation
  [then]


  [ifdef] FDCAN1_FDCAN_NBTP_DEF
    \
    \ @brief FDCAN Nominal Bit Timing and Prescaler Register
    \ Address offset: 0x1C
    \ Reset value: 0x06000A03
    \
    $00 constant FDCAN1_TSEG2                   \ [0x00 : 7] Nominal Time segment after sample point
    $08 constant FDCAN1_NTSEG1                  \ [0x08 : 8] Nominal Time segment before sample point
    $10 constant FDCAN1_NBRP                    \ [0x10 : 9] Bit Rate Prescaler
    $19 constant FDCAN1_NSJW                    \ [0x19 : 7] NSJW: Nominal (Re)Synchronization Jump Width
  [then]


  [ifdef] FDCAN1_FDCAN_TSCC_DEF
    \
    \ @brief FDCAN Timestamp Counter Configuration Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TSS                     \ [0x00 : 2] Timestamp Select
    $10 constant FDCAN1_TCP                     \ [0x10 : 4] Timestamp Counter Prescaler
  [then]


  [ifdef] FDCAN1_FDCAN_TSCV_DEF
    \
    \ @brief FDCAN Timestamp Counter Value Register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TSC                     \ [0x00 : 16] Timestamp Counter
  [then]


  [ifdef] FDCAN1_FDCAN_TOCC_DEF
    \
    \ @brief FDCAN Timeout Counter Configuration Register
    \ Address offset: 0x28
    \ Reset value: 0xFFFF0000
    \
    $00 constant FDCAN1_ETOC                    \ [0x00] Enable Timeout Counter
    $01 constant FDCAN1_TOS                     \ [0x01 : 2] Timeout Select
    $10 constant FDCAN1_TOP                     \ [0x10 : 16] Timeout Period
  [then]


  [ifdef] FDCAN1_FDCAN_TOCV_DEF
    \
    \ @brief FDCAN Timeout Counter Value Register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant FDCAN1_TOC                     \ [0x00 : 16] Timeout Counter
  [then]


  [ifdef] FDCAN1_FDCAN_ECR_DEF
    \
    \ @brief FDCAN Error Counter Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TEC                     \ [0x00 : 8] Transmit Error Counter
    $08 constant FDCAN1_REC                     \ [0x08 : 7] Receive Error Counter
    $0f constant FDCAN1_RP                      \ [0x0f] Receive Error Passive
    $10 constant FDCAN1_CEL                     \ [0x10 : 8] AN Error Logging
  [then]


  [ifdef] FDCAN1_FDCAN_PSR_DEF
    \
    \ @brief FDCAN Protocol Status Register
    \ Address offset: 0x44
    \ Reset value: 0x00000707
    \
    $00 constant FDCAN1_LEC                     \ [0x00 : 3] Last Error Code
    $03 constant FDCAN1_ACT                     \ [0x03 : 2] Activity
    $05 constant FDCAN1_EP                      \ [0x05] Error Passive
    $06 constant FDCAN1_EW                      \ [0x06] Warning Status
    $07 constant FDCAN1_BO                      \ [0x07] Bus_Off Status
    $08 constant FDCAN1_DLEC                    \ [0x08 : 3] Data Last Error Code
    $0b constant FDCAN1_RESI                    \ [0x0b] ESI flag of last received FDCAN Message
    $0c constant FDCAN1_RBRS                    \ [0x0c] BRS flag of last received FDCAN Message
    $0d constant FDCAN1_REDL                    \ [0x0d] Received FDCAN Message
    $0e constant FDCAN1_PXE                     \ [0x0e] Protocol Exception Event
    $10 constant FDCAN1_TDCV                    \ [0x10 : 7] Transmitter Delay Compensation Value
  [then]


  [ifdef] FDCAN1_FDCAN_TDCR_DEF
    \
    \ @brief FDCAN Transmitter Delay Compensation Register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TDCF                    \ [0x00 : 7] Transmitter Delay Compensation Filter Window Length
    $08 constant FDCAN1_TDCO                    \ [0x08 : 7] Transmitter Delay Compensation Offset
  [then]


  [ifdef] FDCAN1_FDCAN_IR_DEF
    \
    \ @brief FDCAN Interrupt Register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RF0N                    \ [0x00] RF0N
    $01 constant FDCAN1_RF0F                    \ [0x01] RF0F
    $02 constant FDCAN1_RF0L                    \ [0x02] RF0L
    $03 constant FDCAN1_RF1N                    \ [0x03] RF1N
    $04 constant FDCAN1_RF1F                    \ [0x04] RF1F
    $05 constant FDCAN1_RF1L                    \ [0x05] RF1L
    $06 constant FDCAN1_HPM                     \ [0x06] HPM
    $07 constant FDCAN1_TC                      \ [0x07] TC
    $08 constant FDCAN1_TCF                     \ [0x08] TCF
    $09 constant FDCAN1_TFE                     \ [0x09] TFE
    $0a constant FDCAN1_TEFN                    \ [0x0a] TEFN
    $0b constant FDCAN1_TEFF                    \ [0x0b] TEFF
    $0c constant FDCAN1_TEFL                    \ [0x0c] TEFL
    $0d constant FDCAN1_TSW                     \ [0x0d] TSW
    $0e constant FDCAN1_MRAF                    \ [0x0e] MRAF
    $0f constant FDCAN1_TOO                     \ [0x0f] TOO
    $10 constant FDCAN1_ELO                     \ [0x10] ELO
    $11 constant FDCAN1_EP                      \ [0x11] EP
    $12 constant FDCAN1_EW                      \ [0x12] EW
    $13 constant FDCAN1_BO                      \ [0x13] BO
    $14 constant FDCAN1_WDI                     \ [0x14] WDI
    $15 constant FDCAN1_PEA                     \ [0x15] PEA
    $16 constant FDCAN1_PED                     \ [0x16] PED
    $17 constant FDCAN1_ARA                     \ [0x17] ARA
  [then]


  [ifdef] FDCAN1_FDCAN_IE_DEF
    \
    \ @brief FDCAN Interrupt Enable Register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RF0NE                   \ [0x00] Rx FIFO 0 New Message Enable
    $01 constant FDCAN1_RF0FE                   \ [0x01] Rx FIFO 0 Full Enable
    $02 constant FDCAN1_RF0LE                   \ [0x02] Rx FIFO 0 Message Lost Enable
    $03 constant FDCAN1_RF1NE                   \ [0x03] Rx FIFO 1 New Message Enable
    $04 constant FDCAN1_RF1FE                   \ [0x04] Rx FIFO 1 Watermark Reached Enable
    $05 constant FDCAN1_RF1LE                   \ [0x05] Rx FIFO 1 Message Lost Enable
    $06 constant FDCAN1_HPME                    \ [0x06] High Priority Message Enable
    $07 constant FDCAN1_TCE                     \ [0x07] Transmission Completed Enable
    $08 constant FDCAN1_TCFE                    \ [0x08] Transmission Cancellation Finished Enable
    $09 constant FDCAN1_TEFE                    \ [0x09] Tx FIFO Empty Enable
    $0a constant FDCAN1_TEFNE                   \ [0x0a] Tx Event FIFO New Entry Enable
    $0b constant FDCAN1_TEFFE                   \ [0x0b] Tx Event FIFO Full Enable
    $0c constant FDCAN1_TEFLE                   \ [0x0c] Tx Event FIFO Element Lost Enable
    $0d constant FDCAN1_MRAFE                   \ [0x0d] Message RAM Access Failure Enable
    $0e constant FDCAN1_TOOE                    \ [0x0e] Timeout Occurred Enable
    $0f constant FDCAN1_ELOE                    \ [0x0f] Error Logging Overflow Enable
    $10 constant FDCAN1_EPE                     \ [0x10] Error Passive Enable
    $11 constant FDCAN1_EWE                     \ [0x11] Warning Status Enable
    $12 constant FDCAN1_BOE                     \ [0x12] Bus_Off Status Enable
    $13 constant FDCAN1_WDIE                    \ [0x13] Watchdog Interrupt Enable
    $14 constant FDCAN1_PEAE                    \ [0x14] Protocol Error in Arbitration Phase Enable
    $15 constant FDCAN1_PEDE                    \ [0x15] Protocol Error in Data Phase Enable
    $16 constant FDCAN1_ARAE                    \ [0x16] Access to Reserved Address Enable
  [then]


  [ifdef] FDCAN1_FDCAN_ILS_DEF
    \
    \ @brief FDCAN Interrupt Line Select Register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RxFIFO0                 \ [0x00] RxFIFO0
    $01 constant FDCAN1_RxFIFO1                 \ [0x01] RxFIFO1
    $02 constant FDCAN1_SMSG                    \ [0x02] SMSG
    $03 constant FDCAN1_TFERR                   \ [0x03] TFERR
    $04 constant FDCAN1_MISC                    \ [0x04] MISC
    $05 constant FDCAN1_BERR                    \ [0x05] BERR
    $06 constant FDCAN1_PERR                    \ [0x06] PERR
  [then]


  [ifdef] FDCAN1_FDCAN_ILE_DEF
    \
    \ @brief FDCAN Interrupt Line Enable Register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_EINT0                   \ [0x00] Enable Interrupt Line 0
    $01 constant FDCAN1_EINT1                   \ [0x01] Enable Interrupt Line 1
  [then]


  [ifdef] FDCAN1_FDCAN_RXGFC_DEF
    \
    \ @brief FDCAN Global Filter Configuration Register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RRFE                    \ [0x00] Reject Remote Frames Extended
    $01 constant FDCAN1_RRFS                    \ [0x01] Reject Remote Frames Standard
    $02 constant FDCAN1_ANFE                    \ [0x02 : 2] Accept Non-matching Frames Extended
    $04 constant FDCAN1_ANFS                    \ [0x04 : 2] Accept Non-matching Frames Standard
    $08 constant FDCAN1_F1OM                    \ [0x08] F1OM
    $09 constant FDCAN1_F0OM                    \ [0x09] F0OM
    $10 constant FDCAN1_LSS                     \ [0x10 : 5] LSS
    $18 constant FDCAN1_LSE                     \ [0x18 : 4] LSE
  [then]


  [ifdef] FDCAN1_FDCAN_XIDAM_DEF
    \
    \ @brief FDCAN Extended ID and Mask Register
    \ Address offset: 0x84
    \ Reset value: 0x1FFFFFFF
    \
    $00 constant FDCAN1_EIDM                    \ [0x00 : 29] Extended ID Mask
  [then]


  [ifdef] FDCAN1_FDCAN_HPMS_DEF
    \
    \ @brief FDCAN High Priority Message Status Register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_BIDX                    \ [0x00 : 3] Buffer Index
    $06 constant FDCAN1_MSI                     \ [0x06 : 2] Message Storage Indicator
    $08 constant FDCAN1_FIDX                    \ [0x08 : 5] Filter Index
    $0f constant FDCAN1_FLST                    \ [0x0f] Filter List
  [then]


  [ifdef] FDCAN1_FDCAN_RXF0S_DEF
    \
    \ @brief FDCAN Rx FIFO 0 Status Register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F0FL                    \ [0x00 : 4] Rx FIFO 0 Fill Level
    $08 constant FDCAN1_F0GI                    \ [0x08 : 2] Rx FIFO 0 Get Index
    $10 constant FDCAN1_F0PI                    \ [0x10 : 2] Rx FIFO 0 Put Index
    $18 constant FDCAN1_F0F                     \ [0x18] Rx FIFO 0 Full
    $19 constant FDCAN1_RF0L                    \ [0x19] Rx FIFO 0 Message Lost
  [then]


  [ifdef] FDCAN1_FDCAN_RXF0A_DEF
    \
    \ @brief CAN Rx FIFO 0 Acknowledge Register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F0AI                    \ [0x00 : 3] Rx FIFO 0 Acknowledge Index
  [then]


  [ifdef] FDCAN1_FDCAN_RXF1S_DEF
    \
    \ @brief FDCAN Rx FIFO 1 Status Register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F1FL                    \ [0x00 : 4] Rx FIFO 1 Fill Level
    $08 constant FDCAN1_F1GI                    \ [0x08 : 2] Rx FIFO 1 Get Index
    $10 constant FDCAN1_F1PI                    \ [0x10 : 2] Rx FIFO 1 Put Index
    $18 constant FDCAN1_F1F                     \ [0x18] Rx FIFO 1 Full
    $19 constant FDCAN1_RF1L                    \ [0x19] Rx FIFO 1 Message Lost
  [then]


  [ifdef] FDCAN1_FDCAN_RXF1A_DEF
    \
    \ @brief FDCAN Rx FIFO 1 Acknowledge Register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F1AI                    \ [0x00 : 3] Rx FIFO 1 Acknowledge Index
  [then]


  [ifdef] FDCAN1_FDCAN_TXBC_DEF
    \
    \ @brief FDCAN Tx buffer configuration register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $18 constant FDCAN1_TFQM                    \ [0x18] Tx FIFO/Queue Mode
  [then]


  [ifdef] FDCAN1_FDCAN_TXFQS_DEF
    \
    \ @brief FDCAN Tx FIFO/Queue Status Register
    \ Address offset: 0xC4
    \ Reset value: 0x00000003
    \
    $00 constant FDCAN1_TFFL                    \ [0x00 : 3] Tx FIFO Free Level
    $08 constant FDCAN1_TFGI                    \ [0x08 : 2] TFGI
    $10 constant FDCAN1_TFQPI                   \ [0x10 : 2] Tx FIFO/Queue Put Index
    $15 constant FDCAN1_TFQF                    \ [0x15] Tx FIFO/Queue Full
  [then]


  [ifdef] FDCAN1_FDCAN_TXBRP_DEF
    \
    \ @brief FDCAN Tx Buffer Request Pending Register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TRP                     \ [0x00 : 3] Transmission Request Pending
  [then]


  [ifdef] FDCAN1_FDCAN_TXBAR_DEF
    \
    \ @brief FDCAN Tx Buffer Add Request Register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_AR                      \ [0x00 : 3] Add Request
  [then]


  [ifdef] FDCAN1_FDCAN_TXBCR_DEF
    \
    \ @brief FDCAN Tx Buffer Cancellation Request Register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_CR                      \ [0x00 : 3] Cancellation Request
  [then]


  [ifdef] FDCAN1_FDCAN_TXBTO_DEF
    \
    \ @brief FDCAN Tx Buffer Transmission Occurred Register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TO                      \ [0x00 : 3] Transmission Occurred.
  [then]


  [ifdef] FDCAN1_FDCAN_TXBCF_DEF
    \
    \ @brief FDCAN Tx Buffer Cancellation Finished Register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_CF                      \ [0x00 : 3] Cancellation Finished
  [then]


  [ifdef] FDCAN1_FDCAN_TXBTIE_DEF
    \
    \ @brief FDCAN Tx Buffer Transmission Interrupt Enable Register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TIE                     \ [0x00 : 3] Transmission Interrupt Enable
  [then]


  [ifdef] FDCAN1_FDCAN_TXBCIE_DEF
    \
    \ @brief FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_CF                      \ [0x00 : 3] Cancellation Finished Interrupt Enable
  [then]


  [ifdef] FDCAN1_FDCAN_TXEFS_DEF
    \
    \ @brief FDCAN Tx Event FIFO Status Register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_EFFL                    \ [0x00 : 3] Event FIFO Fill Level
    $08 constant FDCAN1_EFGI                    \ [0x08 : 2] Event FIFO Get Index.
    $10 constant FDCAN1_EFPI                    \ [0x10 : 2] Event FIFO Put Index
    $18 constant FDCAN1_EFF                     \ [0x18] Event FIFO Full.
    $19 constant FDCAN1_TEFL                    \ [0x19] Tx Event FIFO Element Lost.
  [then]


  [ifdef] FDCAN1_FDCAN_TXEFA_DEF
    \
    \ @brief FDCAN Tx Event FIFO Acknowledge Register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_EFAI                    \ [0x00 : 2] Event FIFO Acknowledge Index
  [then]


  [ifdef] FDCAN1_FDCAN_CKDIV_DEF
    \
    \ @brief FDCAN TT Trigger Memory Configuration Register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_PDIV                    \ [0x00 : 4] PDIV
  [then]

  \
  \ @brief FDCAN1
  \
  $00 constant FDCAN1_FDCAN_CREL        \ FDCAN Core Release Register
  $04 constant FDCAN1_FDCAN_ENDN        \ FDCAN Core Release Register
  $0C constant FDCAN1_FDCAN_DBTP        \ FDCAN Data Bit Timing and Prescaler Register
  $10 constant FDCAN1_FDCAN_TEST        \ FDCAN Test Register
  $14 constant FDCAN1_FDCAN_RWD         \ FDCAN RAM Watchdog Register
  $18 constant FDCAN1_FDCAN_CCCR        \ FDCAN CC Control Register
  $1C constant FDCAN1_FDCAN_NBTP        \ FDCAN Nominal Bit Timing and Prescaler Register
  $20 constant FDCAN1_FDCAN_TSCC        \ FDCAN Timestamp Counter Configuration Register
  $24 constant FDCAN1_FDCAN_TSCV        \ FDCAN Timestamp Counter Value Register
  $28 constant FDCAN1_FDCAN_TOCC        \ FDCAN Timeout Counter Configuration Register
  $2C constant FDCAN1_FDCAN_TOCV        \ FDCAN Timeout Counter Value Register
  $40 constant FDCAN1_FDCAN_ECR         \ FDCAN Error Counter Register
  $44 constant FDCAN1_FDCAN_PSR         \ FDCAN Protocol Status Register
  $48 constant FDCAN1_FDCAN_TDCR        \ FDCAN Transmitter Delay Compensation Register
  $50 constant FDCAN1_FDCAN_IR          \ FDCAN Interrupt Register
  $54 constant FDCAN1_FDCAN_IE          \ FDCAN Interrupt Enable Register
  $58 constant FDCAN1_FDCAN_ILS         \ FDCAN Interrupt Line Select Register
  $5C constant FDCAN1_FDCAN_ILE         \ FDCAN Interrupt Line Enable Register
  $80 constant FDCAN1_FDCAN_RXGFC       \ FDCAN Global Filter Configuration Register
  $84 constant FDCAN1_FDCAN_XIDAM       \ FDCAN Extended ID and Mask Register
  $88 constant FDCAN1_FDCAN_HPMS        \ FDCAN High Priority Message Status Register
  $90 constant FDCAN1_FDCAN_RXF0S       \ FDCAN Rx FIFO 0 Status Register
  $94 constant FDCAN1_FDCAN_RXF0A       \ CAN Rx FIFO 0 Acknowledge Register
  $98 constant FDCAN1_FDCAN_RXF1S       \ FDCAN Rx FIFO 1 Status Register
  $9C constant FDCAN1_FDCAN_RXF1A       \ FDCAN Rx FIFO 1 Acknowledge Register
  $C0 constant FDCAN1_FDCAN_TXBC        \ FDCAN Tx buffer configuration register
  $C4 constant FDCAN1_FDCAN_TXFQS       \ FDCAN Tx FIFO/Queue Status Register
  $C8 constant FDCAN1_FDCAN_TXBRP       \ FDCAN Tx Buffer Request Pending Register
  $CC constant FDCAN1_FDCAN_TXBAR       \ FDCAN Tx Buffer Add Request Register
  $D0 constant FDCAN1_FDCAN_TXBCR       \ FDCAN Tx Buffer Cancellation Request Register
  $D4 constant FDCAN1_FDCAN_TXBTO       \ FDCAN Tx Buffer Transmission Occurred Register
  $D8 constant FDCAN1_FDCAN_TXBCF       \ FDCAN Tx Buffer Cancellation Finished Register
  $DC constant FDCAN1_FDCAN_TXBTIE      \ FDCAN Tx Buffer Transmission Interrupt Enable Register
  $E0 constant FDCAN1_FDCAN_TXBCIE      \ FDCAN Tx Buffer Cancellation Finished Interrupt Enable Register
  $E4 constant FDCAN1_FDCAN_TXEFS       \ FDCAN Tx Event FIFO Status Register
  $E8 constant FDCAN1_FDCAN_TXEFA       \ FDCAN Tx Event FIFO Acknowledge Register
  $100 constant FDCAN1_FDCAN_CKDIV      \ FDCAN TT Trigger Memory Configuration Register

: FDCAN1_DEF ; [then]
