\
\ @file ucpd1.fs
\ @brief USB Power Delivery interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] UCPD1_DEF

  [ifdef] UCPD1_CFG1_DEF
    \
    \ @brief UCPD configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_HBITCLKDIV               \ [0x00 : 6] HBITCLKDIV
    $06 constant UCPD1_IFRGAP                   \ [0x06 : 5] IFRGAP
    $0b constant UCPD1_TRANSWIN                 \ [0x0b : 5] TRANSWIN
    $11 constant UCPD1_PSC_USBPDCLK             \ [0x11 : 3] PSC_USBPDCLK
    $14 constant UCPD1_RXORDSETEN               \ [0x14 : 9] RXORDSETEN
    $1d constant UCPD1_TXDMAEN                  \ [0x1d] TXDMAEN
    $1e constant UCPD1_RXDMAEN                  \ [0x1e] RXDMAEN:
    $1f constant UCPD1_UCPDEN                   \ [0x1f] UCPDEN
  [then]


  [ifdef] UCPD1_CFG2_DEF
    \
    \ @brief UCPD configuration register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXFILTDIS                \ [0x00] RXFILTDIS
    $01 constant UCPD1_RXFILT2N3                \ [0x01] RXFILT2N3
    $02 constant UCPD1_FORCECLK                 \ [0x02] FORCECLK
    $03 constant UCPD1_WUPEN                    \ [0x03] WUPEN
  [then]


  [ifdef] UCPD1_CFG3_DEF
    \
    \ @brief UCPD configuration register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TRIM1_NG_CCRPD           \ [0x00 : 4] TRIM1_NG_CCRPD
    $04 constant UCPD1_TRIM1_NG_CC1A5           \ [0x04 : 5] TRIM1_NG_CC1A5
    $09 constant UCPD1_TRIM1_NG_CC3A0           \ [0x09 : 4] TRIM1_NG_CC3A0
    $10 constant UCPD1_TRIM2_NG_CCRPD           \ [0x10 : 4] TRIM2_NG_CCRPD
    $14 constant UCPD1_TRIM2_NG_CC1A5           \ [0x14 : 5] TRIM2_NG_CC1A5
    $19 constant UCPD1_TRIM2_NG_CC3A0           \ [0x19 : 4] TRIM2_NG_CC3A0
  [then]


  [ifdef] UCPD1_CR_DEF
    \
    \ @brief UCPD control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXMODE                   \ [0x00 : 2] TXMODE
    $02 constant UCPD1_TXSEND                   \ [0x02] TXSEND
    $03 constant UCPD1_TXHRST                   \ [0x03] TXHRST
    $04 constant UCPD1_RXMODE                   \ [0x04] RXMODE
    $05 constant UCPD1_PHYRXEN                  \ [0x05] PHYRXEN
    $06 constant UCPD1_PHYCCSEL                 \ [0x06] PHYCCSEL
    $07 constant UCPD1_ANASUBMODE               \ [0x07 : 2] ANASUBMODE
    $09 constant UCPD1_ANAMODE                  \ [0x09] ANAMODE
    $0a constant UCPD1_CCENABLE                 \ [0x0a : 2] CCENABLE
    $10 constant UCPD1_FRSRXEN                  \ [0x10] FRSRXEN
    $11 constant UCPD1_FRSTX                    \ [0x11] FRSTX
    $12 constant UCPD1_RDCH                     \ [0x12] RDCH
    $14 constant UCPD1_CC1TCDIS                 \ [0x14] CC1TCDIS
    $15 constant UCPD1_CC2TCDIS                 \ [0x15] CC2TCDIS
  [then]


  [ifdef] UCPD1_IMR_DEF
    \
    \ @brief UCPD Interrupt Mask Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXISIE                   \ [0x00] TXISIE
    $01 constant UCPD1_TXMSGDISCIE              \ [0x01] TXMSGDISCIE
    $02 constant UCPD1_TXMSGSENTIE              \ [0x02] TXMSGSENTIE
    $03 constant UCPD1_TXMSGABTIE               \ [0x03] TXMSGABTIE
    $04 constant UCPD1_HRSTDISCIE               \ [0x04] HRSTDISCIE
    $05 constant UCPD1_HRSTSENTIE               \ [0x05] HRSTSENTIE
    $06 constant UCPD1_TXUNDIE                  \ [0x06] TXUNDIE
    $08 constant UCPD1_RXNEIE                   \ [0x08] RXNEIE
    $09 constant UCPD1_RXORDDETIE               \ [0x09] RXORDDETIE
    $0a constant UCPD1_RXHRSTDETIE              \ [0x0a] RXHRSTDETIE
    $0b constant UCPD1_RXOVRIE                  \ [0x0b] RXOVRIE
    $0c constant UCPD1_RXMSGENDIE               \ [0x0c] RXMSGENDIE
    $0e constant UCPD1_TYPECEVT1IE              \ [0x0e] TYPECEVT1IE
    $0f constant UCPD1_TYPECEVT2IE              \ [0x0f] TYPECEVT2IE
    $14 constant UCPD1_FRSEVTIE                 \ [0x14] FRSEVTIE
  [then]


  [ifdef] UCPD1_SR_DEF
    \
    \ @brief UCPD Status Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXIS                     \ [0x00] TXIS
    $01 constant UCPD1_TXMSGDISC                \ [0x01] TXMSGDISC
    $02 constant UCPD1_TXMSGSENT                \ [0x02] TXMSGSENT
    $03 constant UCPD1_TXMSGABT                 \ [0x03] TXMSGABT
    $04 constant UCPD1_HRSTDISC                 \ [0x04] HRSTDISC
    $05 constant UCPD1_HRSTSENT                 \ [0x05] HRSTSENT
    $06 constant UCPD1_TXUND                    \ [0x06] TXUND
    $08 constant UCPD1_RXNE                     \ [0x08] RXNE
    $09 constant UCPD1_RXORDDET                 \ [0x09] RXORDDET
    $0a constant UCPD1_RXHRSTDET                \ [0x0a] RXHRSTDET
    $0b constant UCPD1_RXOVR                    \ [0x0b] RXOVR
    $0c constant UCPD1_RXMSGEND                 \ [0x0c] RXMSGEND
    $0d constant UCPD1_RXERR                    \ [0x0d] RXERR
    $0e constant UCPD1_TYPECEVT1                \ [0x0e] TYPECEVT1
    $0f constant UCPD1_TYPECEVT2                \ [0x0f] TYPECEVT2
    $10 constant UCPD1_TYPEC_VSTATE_CC1         \ [0x10 : 2] TYPEC_VSTATE_CC1
    $12 constant UCPD1_TYPEC_VSTATE_CC2         \ [0x12 : 2] TYPEC_VSTATE_CC2
    $14 constant UCPD1_FRSEVT                   \ [0x14] FRSEVT
  [then]


  [ifdef] UCPD1_ICR_DEF
    \
    \ @brief UCPD Interrupt Clear Register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant UCPD1_TXMSGDISCCF              \ [0x01] TXMSGDISCCF
    $02 constant UCPD1_TXMSGSENTCF              \ [0x02] TXMSGSENTCF
    $03 constant UCPD1_TXMSGABTCF               \ [0x03] TXMSGABTCF
    $04 constant UCPD1_HRSTDISCCF               \ [0x04] HRSTDISCCF
    $05 constant UCPD1_HRSTSENTCF               \ [0x05] HRSTSENTCF
    $06 constant UCPD1_TXUNDCF                  \ [0x06] TXUNDCF
    $09 constant UCPD1_RXORDDETCF               \ [0x09] RXORDDETCF
    $0a constant UCPD1_RXHRSTDETCF              \ [0x0a] RXHRSTDETCF
    $0b constant UCPD1_RXOVRCF                  \ [0x0b] RXOVRCF
    $0c constant UCPD1_RXMSGENDCF               \ [0x0c] RXMSGENDCF
    $0e constant UCPD1_TYPECEVT1CF              \ [0x0e] TYPECEVT1CF
    $0f constant UCPD1_TYPECEVT2CF              \ [0x0f] TYPECEVT2CF
    $14 constant UCPD1_FRSEVTCF                 \ [0x14] FRSEVTCF
  [then]


  [ifdef] UCPD1_TX_ORDSET_DEF
    \
    \ @brief UCPD Tx Ordered Set Type Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXORDSET                 \ [0x00 : 20] TXORDSET
  [then]


  [ifdef] UCPD1_TX_PAYSZ_DEF
    \
    \ @brief UCPD Tx Paysize Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXPAYSZ                  \ [0x00 : 10] TXPAYSZ
  [then]


  [ifdef] UCPD1_TXDR_DEF
    \
    \ @brief UCPD Tx Data Register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_TXDATA                   \ [0x00 : 8] TXDATA
  [then]


  [ifdef] UCPD1_RX_ORDSET_DEF
    \
    \ @brief UCPD Rx Ordered Set Register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXORDSET                 \ [0x00 : 3] RXORDSET
    $03 constant UCPD1_RXSOP3OF4                \ [0x03] RXSOP3OF4
    $04 constant UCPD1_RXSOPKINVALID            \ [0x04 : 3] RXSOPKINVALID
  [then]


  [ifdef] UCPD1_RX_PAYSZ_DEF
    \
    \ @brief UCPD Rx Paysize Register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXPAYSZ                  \ [0x00 : 10] RXPAYSZ
  [then]


  [ifdef] UCPD1_RXDR_DEF
    \
    \ @brief UCPD Receive Data Register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXDATA                   \ [0x00 : 8] RXDATA
  [then]


  [ifdef] UCPD1_RX_ORDEXT1_DEF
    \
    \ @brief UCPD Rx Ordered Set Extension Register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXSOPX1                  \ [0x00 : 20] RXSOPX1
  [then]


  [ifdef] UCPD1_RX_ORDEXT2_DEF
    \
    \ @brief UCPD Rx Ordered Set Extension Register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant UCPD1_RXSOPX2                  \ [0x00 : 20] RXSOPX2
  [then]

  \
  \ @brief USB Power Delivery interface
  \
  $00 constant UCPD1_CFG1               \ UCPD configuration register
  $04 constant UCPD1_CFG2               \ UCPD configuration register 2
  $08 constant UCPD1_CFG3               \ UCPD configuration register 3
  $0C constant UCPD1_CR                 \ UCPD control register
  $10 constant UCPD1_IMR                \ UCPD Interrupt Mask Register
  $14 constant UCPD1_SR                 \ UCPD Status Register
  $18 constant UCPD1_ICR                \ UCPD Interrupt Clear Register
  $1C constant UCPD1_TX_ORDSET          \ UCPD Tx Ordered Set Type Register
  $20 constant UCPD1_TX_PAYSZ           \ UCPD Tx Paysize Register
  $24 constant UCPD1_TXDR               \ UCPD Tx Data Register
  $28 constant UCPD1_RX_ORDSET          \ UCPD Rx Ordered Set Register
  $2C constant UCPD1_RX_PAYSZ           \ UCPD Rx Paysize Register
  $30 constant UCPD1_RXDR               \ UCPD Receive Data Register
  $34 constant UCPD1_RX_ORDEXT1         \ UCPD Rx Ordered Set Extension Register
  $38 constant UCPD1_RX_ORDEXT2         \ UCPD Rx Ordered Set Extension Register

: UCPD1_DEF ; [then]
