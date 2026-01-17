\
\ @file ucpd.fs
\ @brief USB Power Delivery interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] UCPD_DEF

  [ifdef] UCPD_CFG1_DEF
    \
    \ @brief UCPD configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_HBITCLKDIV                \ [0x00 : 6] HBITCLKDIV
    $06 constant UCPD_IFRGAP                    \ [0x06 : 5] IFRGAP
    $0b constant UCPD_TRANSWIN                  \ [0x0b : 5] TRANSWIN
    $11 constant UCPD_PSC_USBPDCLK              \ [0x11 : 3] PSC_USBPDCLK
    $14 constant UCPD_RXORDSETEN                \ [0x14 : 9] RXORDSETEN
    $1d constant UCPD_TXDMAEN                   \ [0x1d] TXDMAEN
    $1e constant UCPD_RXDMAEN                   \ [0x1e] RXDMAEN:
    $1f constant UCPD_UCPDEN                    \ [0x1f] UCPDEN
  [then]


  [ifdef] UCPD_CFG2_DEF
    \
    \ @brief UCPD configuration register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXFILTDIS                 \ [0x00] RXFILTDIS
    $01 constant UCPD_RXFILT2N3                 \ [0x01] RXFILT2N3
    $02 constant UCPD_FORCECLK                  \ [0x02] FORCECLK
    $03 constant UCPD_WUPEN                     \ [0x03] WUPEN
  [then]


  [ifdef] UCPD_CFG3_DEF
    \
    \ @brief UCPD configuration register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TRIM1_NG_CCRPD            \ [0x00 : 4] TRIM1_NG_CCRPD
    $04 constant UCPD_TRIM1_NG_CC1A5            \ [0x04 : 5] TRIM1_NG_CC1A5
    $09 constant UCPD_TRIM1_NG_CC3A0            \ [0x09 : 4] TRIM1_NG_CC3A0
    $10 constant UCPD_TRIM2_NG_CCRPD            \ [0x10 : 4] TRIM2_NG_CCRPD
    $14 constant UCPD_TRIM2_NG_CC1A5            \ [0x14 : 5] TRIM2_NG_CC1A5
    $19 constant UCPD_TRIM2_NG_CC3A0            \ [0x19 : 4] TRIM2_NG_CC3A0
  [then]


  [ifdef] UCPD_CR_DEF
    \
    \ @brief UCPD control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXMODE                    \ [0x00 : 2] TXMODE
    $02 constant UCPD_TXSEND                    \ [0x02] TXSEND
    $03 constant UCPD_TXHRST                    \ [0x03] TXHRST
    $04 constant UCPD_RXMODE                    \ [0x04] RXMODE
    $05 constant UCPD_PHYRXEN                   \ [0x05] PHYRXEN
    $06 constant UCPD_PHYCCSEL                  \ [0x06] PHYCCSEL
    $07 constant UCPD_ANASUBMODE                \ [0x07 : 2] ANASUBMODE
    $09 constant UCPD_ANAMODE                   \ [0x09] ANAMODE
    $0a constant UCPD_CCENABLE                  \ [0x0a : 2] CCENABLE
    $0f constant UCPD_DBATTEN                   \ [0x0f] DBATTEN
    $10 constant UCPD_FRSRXEN                   \ [0x10] FRSRXEN
    $11 constant UCPD_FRSTX                     \ [0x11] FRSTX
    $12 constant UCPD_RDCH                      \ [0x12] RDCH
    $14 constant UCPD_CC1TCDIS                  \ [0x14] CC1TCDIS
    $15 constant UCPD_CC2TCDIS                  \ [0x15] CC2TCDIS
  [then]


  [ifdef] UCPD_IMR_DEF
    \
    \ @brief UCPD Interrupt Mask Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXISIE                    \ [0x00] TXISIE
    $01 constant UCPD_TXMSGDISCIE               \ [0x01] TXMSGDISCIE
    $02 constant UCPD_TXMSGSENTIE               \ [0x02] TXMSGSENTIE
    $03 constant UCPD_TXMSGABTIE                \ [0x03] TXMSGABTIE
    $04 constant UCPD_HRSTDISCIE                \ [0x04] HRSTDISCIE
    $05 constant UCPD_HRSTSENTIE                \ [0x05] HRSTSENTIE
    $06 constant UCPD_TXUNDIE                   \ [0x06] TXUNDIE
    $08 constant UCPD_RXNEIE                    \ [0x08] RXNEIE
    $09 constant UCPD_RXORDDETIE                \ [0x09] RXORDDETIE
    $0a constant UCPD_RXHRSTDETIE               \ [0x0a] RXHRSTDETIE
    $0b constant UCPD_RXOVRIE                   \ [0x0b] RXOVRIE
    $0c constant UCPD_RXMSGENDIE                \ [0x0c] RXMSGENDIE
    $0e constant UCPD_TYPECEVT1IE               \ [0x0e] TYPECEVT1IE
    $0f constant UCPD_TYPECEVT2IE               \ [0x0f] TYPECEVT2IE
    $14 constant UCPD_FRSEVTIE                  \ [0x14] FRSEVTIE
  [then]


  [ifdef] UCPD_SR_DEF
    \
    \ @brief UCPD Status Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXIS                      \ [0x00] TXIS
    $01 constant UCPD_TXMSGDISC                 \ [0x01] TXMSGDISC
    $02 constant UCPD_TXMSGSENT                 \ [0x02] TXMSGSENT
    $03 constant UCPD_TXMSGABT                  \ [0x03] TXMSGABT
    $04 constant UCPD_HRSTDISC                  \ [0x04] HRSTDISC
    $05 constant UCPD_HRSTSENT                  \ [0x05] HRSTSENT
    $06 constant UCPD_TXUND                     \ [0x06] TXUND
    $08 constant UCPD_RXNE                      \ [0x08] RXNE
    $09 constant UCPD_RXORDDET                  \ [0x09] RXORDDET
    $0a constant UCPD_RXHRSTDET                 \ [0x0a] RXHRSTDET
    $0b constant UCPD_RXOVR                     \ [0x0b] RXOVR
    $0c constant UCPD_RXMSGEND                  \ [0x0c] RXMSGEND
    $0d constant UCPD_RXERR                     \ [0x0d] RXERR
    $0e constant UCPD_TYPECEVT1                 \ [0x0e] TYPECEVT1
    $0f constant UCPD_TYPECEVT2                 \ [0x0f] TYPECEVT2
    $10 constant UCPD_TYPEC_VSTATE_CC1          \ [0x10 : 2] TYPEC_VSTATE_CC1
    $12 constant UCPD_TYPEC_VSTATE_CC2          \ [0x12 : 2] TYPEC_VSTATE_CC2
    $14 constant UCPD_FRSEVT                    \ [0x14] FRSEVT
  [then]


  [ifdef] UCPD_ICR_DEF
    \
    \ @brief UCPD Interrupt Clear Register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant UCPD_TXMSGDISCCF               \ [0x01] TXMSGDISCCF
    $02 constant UCPD_TXMSGSENTCF               \ [0x02] TXMSGSENTCF
    $03 constant UCPD_TXMSGABTCF                \ [0x03] TXMSGABTCF
    $04 constant UCPD_HRSTDISCCF                \ [0x04] HRSTDISCCF
    $05 constant UCPD_HRSTSENTCF                \ [0x05] HRSTSENTCF
    $06 constant UCPD_TXUNDCF                   \ [0x06] TXUNDCF
    $09 constant UCPD_RXORDDETCF                \ [0x09] RXORDDETCF
    $0a constant UCPD_RXHRSTDETCF               \ [0x0a] RXHRSTDETCF
    $0b constant UCPD_RXOVRCF                   \ [0x0b] RXOVRCF
    $0c constant UCPD_RXMSGENDCF                \ [0x0c] RXMSGENDCF
    $0e constant UCPD_TYPECEVT1CF               \ [0x0e] TYPECEVT1CF
    $0f constant UCPD_TYPECEVT2CF               \ [0x0f] TYPECEVT2CF
    $14 constant UCPD_FRSEVTCF                  \ [0x14] FRSEVTCF
  [then]


  [ifdef] UCPD_TX_ORDSET_DEF
    \
    \ @brief UCPD Tx Ordered Set Type Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXORDSET                  \ [0x00 : 20] TXORDSET
  [then]


  [ifdef] UCPD_TX_PAYSZ_DEF
    \
    \ @brief UCPD Tx Paysize Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXPAYSZ                   \ [0x00 : 10] TXPAYSZ
  [then]


  [ifdef] UCPD_TXDR_DEF
    \
    \ @brief UCPD Tx Data Register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXDATA                    \ [0x00 : 8] TXDATA
  [then]


  [ifdef] UCPD_RX_ORDSET_DEF
    \
    \ @brief UCPD Rx Ordered Set Register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXORDSET                  \ [0x00 : 3] RXORDSET
    $03 constant UCPD_RXSOP3OF4                 \ [0x03] RXSOP3OF4
    $04 constant UCPD_RXSOPKINVALID             \ [0x04 : 3] RXSOPKINVALID
  [then]


  [ifdef] UCPD_RX_PAYSZ_DEF
    \
    \ @brief UCPD Rx Paysize Register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXPAYSZ                   \ [0x00 : 10] RXPAYSZ
  [then]


  [ifdef] UCPD_RXDR_DEF
    \
    \ @brief UCPD Receive Data Register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXDATA                    \ [0x00 : 8] RXDATA
  [then]


  [ifdef] UCPD_RX_ORDEXT1_DEF
    \
    \ @brief UCPD Rx Ordered Set Extension Register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXSOPX1                   \ [0x00 : 20] RXSOPX1
  [then]


  [ifdef] UCPD_RX_ORDEXT2_DEF
    \
    \ @brief UCPD Rx Ordered Set Extension Register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXSOPX2                   \ [0x00 : 20] RXSOPX2
  [then]


  [ifdef] UCPD_IPVER_DEF
    \
    \ @brief UCPD IP ID register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant UCPD_IPVER                     \ [0x00 : 32] IPVER
  [then]


  [ifdef] UCPD_IPID_DEF
    \
    \ @brief UCPD IP ID register
    \ Address offset: 0x3F8
    \ Reset value: 0x00150021
    \
    $00 constant UCPD_IPID                      \ [0x00 : 32] IPID
  [then]


  [ifdef] UCPD_MID_DEF
    \
    \ @brief UCPD IP ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant UCPD_IPID                      \ [0x00 : 32] IPID
  [then]

  \
  \ @brief USB Power Delivery interface
  \
  $00 constant UCPD_CFG1                \ UCPD configuration register
  $04 constant UCPD_CFG2                \ UCPD configuration register 2
  $08 constant UCPD_CFG3                \ UCPD configuration register 3
  $0C constant UCPD_CR                  \ UCPD control register
  $10 constant UCPD_IMR                 \ UCPD Interrupt Mask Register
  $14 constant UCPD_SR                  \ UCPD Status Register
  $18 constant UCPD_ICR                 \ UCPD Interrupt Clear Register
  $1C constant UCPD_TX_ORDSET           \ UCPD Tx Ordered Set Type Register
  $20 constant UCPD_TX_PAYSZ            \ UCPD Tx Paysize Register
  $24 constant UCPD_TXDR                \ UCPD Tx Data Register
  $28 constant UCPD_RX_ORDSET           \ UCPD Rx Ordered Set Register
  $2C constant UCPD_RX_PAYSZ            \ UCPD Rx Paysize Register
  $30 constant UCPD_RXDR                \ UCPD Receive Data Register
  $34 constant UCPD_RX_ORDEXT1          \ UCPD Rx Ordered Set Extension Register
  $38 constant UCPD_RX_ORDEXT2          \ UCPD Rx Ordered Set Extension Register
  $3F4 constant UCPD_IPVER              \ UCPD IP ID register
  $3F8 constant UCPD_IPID               \ UCPD IP ID register
  $3FC constant UCPD_MID                \ UCPD IP ID register

: UCPD_DEF ; [then]
