\
\ @file cec.fs
\ @brief HDMI-CEC controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CEC_DEF

  [ifdef] CEC_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant CEC_CECEN                      \ [0x00] CEC Enable
    $01 constant CEC_TXSOM                      \ [0x01] Tx start of message
    $02 constant CEC_TXEOM                      \ [0x02] Tx End Of Message
  [then]


  [ifdef] CEC_CFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CEC_OAR                        \ [0x00 : 4] Own Address
    $04 constant CEC_LSTN                       \ [0x04] Listen mode
    $05 constant CEC_SFT                        \ [0x05 : 3] Signal Free Time
    $08 constant CEC_RXTOL                      \ [0x08] Rx-Tolerance
    $09 constant CEC_BRESTP                     \ [0x09] Rx-stop on bit rising error
    $0a constant CEC_BREGEN                     \ [0x0a] Generate error-bit on bit rising error
    $0b constant CEC_LBPEGEN                    \ [0x0b] Generate Error-Bit on Long Bit Period Error
  [then]


  [ifdef] CEC_TXDR_DEF
    \
    \ @brief Tx data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CEC_TXD                        \ [0x00 : 8] Tx Data register
  [then]


  [ifdef] CEC_RXDR_DEF
    \
    \ @brief Rx Data Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CEC_RXDR                       \ [0x00 : 8] CEC Rx Data Register
  [then]


  [ifdef] CEC_ISR_DEF
    \
    \ @brief Interrupt and Status Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CEC_RXBR                       \ [0x00] Rx-Byte Received
    $01 constant CEC_RXEND                      \ [0x01] End Of Reception
    $02 constant CEC_RXOVR                      \ [0x02] Rx-Overrun
    $03 constant CEC_BRE                        \ [0x03] Rx-Bit rising error
    $04 constant CEC_SBPE                       \ [0x04] Rx-Short Bit period error
    $05 constant CEC_LBPE                       \ [0x05] Rx-Long Bit Period Error
    $06 constant CEC_RXACKE                     \ [0x06] Rx-Missing Acknowledge
    $07 constant CEC_ARBLST                     \ [0x07] Arbitration Lost
    $08 constant CEC_TXBR                       \ [0x08] Tx-Byte Request
    $09 constant CEC_TXEND                      \ [0x09] End of Transmission
    $0a constant CEC_TXUDR                      \ [0x0a] Tx-Buffer Underrun
    $0b constant CEC_TXERR                      \ [0x0b] Tx-Error
    $0c constant CEC_TXACKE                     \ [0x0c] Tx-Missing acknowledge error
  [then]


  [ifdef] CEC_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CEC_RXBRIE                     \ [0x00] Rx-Byte Received Interrupt Enable
    $01 constant CEC_RXENDIE                    \ [0x01] End Of Reception Interrupt Enable
    $02 constant CEC_RXOVRIE                    \ [0x02] Rx-Buffer Overrun Interrupt Enable
    $03 constant CEC_BREIE                      \ [0x03] Bit Rising Error Interrupt Enable
    $04 constant CEC_SBPEIE                     \ [0x04] Short Bit Period Error Interrupt Enable
    $05 constant CEC_LBPEIE                     \ [0x05] Long Bit Period Error Interrupt Enable
    $06 constant CEC_RXACKIE                    \ [0x06] Rx-Missing Acknowledge Error Interrupt Enable
    $07 constant CEC_ARBLSTIE                   \ [0x07] Arbitration Lost Interrupt Enable
    $08 constant CEC_TXBRIE                     \ [0x08] Tx-Byte Request Interrupt Enable
    $09 constant CEC_TXENDIE                    \ [0x09] Tx-End of message interrupt enable
    $0a constant CEC_TXUDRIE                    \ [0x0a] Tx-Underrun interrupt enable
    $0b constant CEC_TXERRIE                    \ [0x0b] Tx-Error Interrupt Enable
    $0c constant CEC_TXACKIE                    \ [0x0c] Tx-Missing Acknowledge Error Interrupt Enable
  [then]

  \
  \ @brief HDMI-CEC controller
  \
  $00 constant CEC_CR                   \ control register
  $04 constant CEC_CFGR                 \ configuration register
  $08 constant CEC_TXDR                 \ Tx data register
  $0C constant CEC_RXDR                 \ Rx Data Register
  $10 constant CEC_ISR                  \ Interrupt and Status Register
  $14 constant CEC_IER                  \ interrupt enable register

: CEC_DEF ; [then]
