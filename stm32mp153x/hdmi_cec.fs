\
\ @file hdmi_cec.fs
\ @brief HDMI_CEC
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
    $00 constant HDMI_CEC_CECEN                 \ [0x00] CECEN
    $01 constant HDMI_CEC_TXSOM                 \ [0x01] TXSOM
    $02 constant HDMI_CEC_TXEOM                 \ [0x02] TXEOM
  [then]


  [ifdef] HDMI_CEC_CEC_CFGR_DEF
    \
    \ @brief This register is used to configure the HDMI-CEC controller. It is mandatory to write CEC_CFGR only when CECEN=0.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_SFT                   \ [0x00 : 3] SFT
    $03 constant HDMI_CEC_RXTOL                 \ [0x03] RXTOL
    $04 constant HDMI_CEC_BRESTP                \ [0x04] BRESTP
    $05 constant HDMI_CEC_BREGEN                \ [0x05] BREGEN
    $06 constant HDMI_CEC_LBPEGEN               \ [0x06] LBPEGEN
    $07 constant HDMI_CEC_BRDNOGEN              \ [0x07] BRDNOGEN
    $08 constant HDMI_CEC_SFTOP                 \ [0x08] SFTOP
    $10 constant HDMI_CEC_OAR                   \ [0x10 : 15] OAR
    $1f constant HDMI_CEC_LSTN                  \ [0x1f] LSTN
  [then]


  [ifdef] HDMI_CEC_CEC_TXDR_DEF
    \
    \ @brief CEC Tx data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_TXD                   \ [0x00 : 8] TXD
  [then]


  [ifdef] HDMI_CEC_CEC_RXDR_DEF
    \
    \ @brief CEC Rx data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_RXD                   \ [0x00 : 8] RXD
  [then]


  [ifdef] HDMI_CEC_CEC_ISR_DEF
    \
    \ @brief CEC Interrupt and Status Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_RXBR                  \ [0x00] RXBR
    $01 constant HDMI_CEC_RXEND                 \ [0x01] RXEND
    $02 constant HDMI_CEC_RXOVR                 \ [0x02] RXOVR
    $03 constant HDMI_CEC_BRE                   \ [0x03] BRE
    $04 constant HDMI_CEC_SBPE                  \ [0x04] SBPE
    $05 constant HDMI_CEC_LBPE                  \ [0x05] LBPE
    $06 constant HDMI_CEC_RXACKE                \ [0x06] RXACKE
    $07 constant HDMI_CEC_ARBLST                \ [0x07] ARBLST
    $08 constant HDMI_CEC_TXBR                  \ [0x08] TXBR
    $09 constant HDMI_CEC_TXEND                 \ [0x09] TXEND
    $0a constant HDMI_CEC_TXUDR                 \ [0x0a] TXUDR
    $0b constant HDMI_CEC_TXERR                 \ [0x0b] TXERR
    $0c constant HDMI_CEC_TXACKE                \ [0x0c] TXACKE
  [then]


  [ifdef] HDMI_CEC_CEC_IER_DEF
    \
    \ @brief CEC interrupt enable register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HDMI_CEC_RXBRIE                \ [0x00] RXBRIE
    $01 constant HDMI_CEC_RXENDIE               \ [0x01] RXENDIE
    $02 constant HDMI_CEC_RXOVRIE               \ [0x02] RXOVRIE
    $03 constant HDMI_CEC_BREIE                 \ [0x03] BREIE
    $04 constant HDMI_CEC_SBPEIE                \ [0x04] SBPEIE
    $05 constant HDMI_CEC_LBPEIE                \ [0x05] LBPEIE
    $06 constant HDMI_CEC_RXACKIE               \ [0x06] RXACKIE
    $07 constant HDMI_CEC_ARBLSTIE              \ [0x07] ARBLSTIE
    $08 constant HDMI_CEC_TXBRIE                \ [0x08] TXBRIE
    $09 constant HDMI_CEC_TXENDIE               \ [0x09] TXENDIE
    $0a constant HDMI_CEC_TXUDRIE               \ [0x0a] TXUDRIE
    $0b constant HDMI_CEC_TXERRIE               \ [0x0b] TXERRIE
    $0c constant HDMI_CEC_TXACKIE               \ [0x0c] TXACKIE
  [then]

  \
  \ @brief HDMI_CEC
  \
  $00 constant HDMI_CEC_CEC_CR          \ CEC control register
  $04 constant HDMI_CEC_CEC_CFGR        \ This register is used to configure the HDMI-CEC controller. It is mandatory to write CEC_CFGR only when CECEN=0.
  $08 constant HDMI_CEC_CEC_TXDR        \ CEC Tx data register
  $0C constant HDMI_CEC_CEC_RXDR        \ CEC Rx data register
  $10 constant HDMI_CEC_CEC_ISR         \ CEC Interrupt and Status Register
  $14 constant HDMI_CEC_CEC_IER         \ CEC interrupt enable register

: HDMI_CEC_DEF ; [then]
