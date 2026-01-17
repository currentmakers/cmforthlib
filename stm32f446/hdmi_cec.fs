\
\ @file hdmi_cec.fs
\ @brief HDMI-CEC controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HDMI_CEC_DEF

  [ifdef] HDMI_CEC_CEC_CR_DEF
    \
    \ @brief CEC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_CECEN                 \ [0x00] CEC Enable
    $01 constant HDMI_CEC_TXSOM                 \ [0x01] Tx Start Of Message
    $02 constant HDMI_CEC_TXEOM                 \ [0x02] Tx End Of Message
  [then]


  [ifdef] HDMI_CEC_CEC_CFGR_DEF
    \
    \ @brief CEC configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_SFT                   \ [0x00 : 3] Signal Free Time
    $03 constant HDMI_CEC_RXTOL                 \ [0x03] Rx-Tolerance
    $04 constant HDMI_CEC_BRESTP                \ [0x04] Rx-Stop on Bit Rising Error
    $05 constant HDMI_CEC_BREGEN                \ [0x05] Generate Error-Bit on Bit Rising Error
    $06 constant HDMI_CEC_LBPEGEN               \ [0x06] Generate Error-Bit on Long Bit Period Error
    $07 constant HDMI_CEC_BRDNOGEN              \ [0x07] Avoid Error-Bit Generation in Broadcast
    $08 constant HDMI_CEC_SFTOP                 \ [0x08] SFT Option Bit
    $10 constant HDMI_CEC_OAR                   \ [0x10 : 15] Own addresses configuration
    $1f constant HDMI_CEC_LSTN                  \ [0x1f] Listen mode
  [then]


  [ifdef] HDMI_CEC_CEC_TXDR_DEF
    \
    \ @brief CEC Tx data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_TXD                   \ [0x00 : 8] Tx Data register
  [then]


  [ifdef] HDMI_CEC_CEC_RXDR_DEF
    \
    \ @brief CEC Rx Data Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_RXD                   \ [0x00 : 8] Rx Data register
  [then]


  [ifdef] HDMI_CEC_CEC_ISR_DEF
    \
    \ @brief CEC Interrupt and Status Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_RXBR                  \ [0x00] Rx-Byte Received
    $01 constant HDMI_CEC_RXEND                 \ [0x01] End Of Reception
    $02 constant HDMI_CEC_RXOVR                 \ [0x02] Rx-Overrun
    $03 constant HDMI_CEC_BRE                   \ [0x03] Rx-Bit Rising Error
    $04 constant HDMI_CEC_SBPE                  \ [0x04] Rx-Short Bit Period Error
    $05 constant HDMI_CEC_LBPE                  \ [0x05] Rx-Long Bit Period Error
    $06 constant HDMI_CEC_RXACKE                \ [0x06] Rx-Missing Acknowledge
    $07 constant HDMI_CEC_ARBLST                \ [0x07] Arbitration Lost
    $08 constant HDMI_CEC_TXBR                  \ [0x08] Tx-Byte Request
    $09 constant HDMI_CEC_TXEND                 \ [0x09] End of Transmission
    $0a constant HDMI_CEC_TXUDR                 \ [0x0a] Tx-Buffer Underrun
    $0b constant HDMI_CEC_TXERR                 \ [0x0b] Tx-Error
    $0c constant HDMI_CEC_TXACKE                \ [0x0c] Tx-Missing Acknowledge Error
  [then]


  [ifdef] HDMI_CEC_CEC_IER_DEF
    \
    \ @brief CEC interrupt enable register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_RXBRIE                \ [0x00] Rx-Byte Received Interrupt Enable
    $01 constant HDMI_CEC_RXENDIE               \ [0x01] End Of Reception Interrupt Enable
    $02 constant HDMI_CEC_RXOVRIE               \ [0x02] Rx-Buffer Overrun Interrupt Enable
    $03 constant HDMI_CEC_BREIE                 \ [0x03] Bit Rising Error Interrupt Enable
    $04 constant HDMI_CEC_SBPEIE                \ [0x04] Short Bit Period Error Interrupt Enable
    $05 constant HDMI_CEC_LBPEIE                \ [0x05] Long Bit Period Error Interrupt Enable
    $06 constant HDMI_CEC_RXACKIE               \ [0x06] Rx-Missing Acknowledge Error Interrupt Enable
    $07 constant HDMI_CEC_ARBLSTIE              \ [0x07] Arbitration Lost Interrupt Enable
    $08 constant HDMI_CEC_TXBRIE                \ [0x08] Tx-Byte Request Interrupt Enable
    $09 constant HDMI_CEC_TXENDIE               \ [0x09] Tx-End Of Message Interrupt Enable
    $0a constant HDMI_CEC_TXUDRIE               \ [0x0a] Tx-Underrun Interrupt Enable
    $0b constant HDMI_CEC_TXERRIE               \ [0x0b] Tx-Error Interrupt Enable
    $0c constant HDMI_CEC_TXACKIE               \ [0x0c] Tx-Missing Acknowledge Error Interrupt Enable
  [then]

  \
  \ @brief HDMI-CEC controller
  \
  $00 constant HDMI_CEC_CEC_CR          \ CEC control register
  $04 constant HDMI_CEC_CEC_CFGR        \ CEC configuration register
  $08 constant HDMI_CEC_CEC_TXDR        \ CEC Tx data register
  $0C constant HDMI_CEC_CEC_RXDR        \ CEC Rx Data Register
  $10 constant HDMI_CEC_CEC_ISR         \ CEC Interrupt and Status Register
  $14 constant HDMI_CEC_CEC_IER         \ CEC interrupt enable register

: HDMI_CEC_DEF ; [then]
