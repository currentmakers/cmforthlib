\
\ @file ucpd.fs
\ @brief UCPD register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] UCPD_DEF

  [ifdef] UCPD_UCPD_CFGR1_DEF
    \
    \ @brief UCPD configuration register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_HBITCLKDIV                \ [0x00 : 6] Division ratio for producing half-bit clock
    $06 constant UCPD_IFRGAP                    \ [0x06 : 5] Division ratio for producing inter-frame gap timer clock
    $0b constant UCPD_TRANSWIN                  \ [0x0b : 5] Transition window duration
    $11 constant UCPD_PSC_USBPDCLK              \ [0x11 : 3] Pre-scaler division ratio for generating ucpd_clk
    $14 constant UCPD_RXORDSETEN                \ [0x14 : 9] Receiver ordered set enable
    $1d constant UCPD_TXDMAEN                   \ [0x1d] Transmission DMA mode enable
    $1e constant UCPD_RXDMAEN                   \ [0x1e] Reception DMA mode enable
    $1f constant UCPD_UCPDEN                    \ [0x1f] UCPD peripheral enable
  [then]


  [ifdef] UCPD_UCPD_CFGR2_DEF
    \
    \ @brief UCPD configuration register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXFILTDIS                 \ [0x00] BMC decoder Rx pre-filter enable
    $01 constant UCPD_RXFILT2N3                 \ [0x01] BMC decoder Rx pre-filter sampling method
    $02 constant UCPD_FORCECLK                  \ [0x02] Force ClkReq clock request
    $03 constant UCPD_WUPEN                     \ [0x03] Wake-up from Stop mode enable
    $08 constant UCPD_RXAFILTEN                 \ [0x08] Rx analog filter enable
  [then]


  [ifdef] UCPD_UCPD_CFGR3_DEF
    \
    \ @brief UCPD configuration register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TRIM_CC1_RD               \ [0x00 : 4] SW trim value for Rd resistor on the CC1 line
    $09 constant UCPD_TRIM_CC1_RP               \ [0x09 : 4] SW trim value for Rp current sources on the CC1 line
    $10 constant UCPD_TRIM_CC2_RD               \ [0x10 : 4] SW trim value for Rd resistor on the CC2 line
    $19 constant UCPD_TRIM_CC2_RP               \ [0x19 : 4] SW trim value for Rp current sources on the CC2 line
  [then]


  [ifdef] UCPD_UCPD_CR_DEF
    \
    \ @brief UCPD control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXMODE                    \ [0x00 : 2] Type of Tx packet
    $02 constant UCPD_TXSEND                    \ [0x02] Command to send a Tx packet
    $03 constant UCPD_TXHRST                    \ [0x03] Command to send a Tx Hard Reset
    $04 constant UCPD_RXMODE                    \ [0x04] Receiver mode
    $05 constant UCPD_PHYRXEN                   \ [0x05] USB Power Delivery receiver enable
    $06 constant UCPD_PHYCCSEL                  \ [0x06] CC1/CC2 line selector for USB Power Delivery signaling
    $07 constant UCPD_ANASUBMODE                \ [0x07 : 2] Analog PHY sub-mode
    $09 constant UCPD_ANAMODE                   \ [0x09] Analog PHY operating mode
    $0a constant UCPD_CCENABLE                  \ [0x0a : 2] CC line enable
    $10 constant UCPD_FRSRXEN                   \ [0x10] FRS event detection enable
    $11 constant UCPD_FRSTX                     \ [0x11] FRS Tx signaling enable.
    $12 constant UCPD_RDCH                      \ [0x12] Rdch condition drive
    $14 constant UCPD_CC1TCDIS                  \ [0x14] CC1 Type-C detector disable
    $15 constant UCPD_CC2TCDIS                  \ [0x15] CC2 Type-C detector disable
  [then]


  [ifdef] UCPD_UCPD_IMR_DEF
    \
    \ @brief UCPD interrupt mask register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXISIE                    \ [0x00] TXIS interrupt enable
    $01 constant UCPD_TXMSGDISCIE               \ [0x01] TXMSGDISC interrupt enable
    $02 constant UCPD_TXMSGSENTIE               \ [0x02] TXMSGSENT interrupt enable
    $03 constant UCPD_TXMSGABTIE                \ [0x03] TXMSGABT interrupt enable
    $04 constant UCPD_HRSTDISCIE                \ [0x04] HRSTDISC interrupt enable
    $05 constant UCPD_HRSTSENTIE                \ [0x05] HRSTSENT interrupt enable
    $06 constant UCPD_TXUNDIE                   \ [0x06] TXUND interrupt enable
    $08 constant UCPD_RXNEIE                    \ [0x08] RXNE interrupt enable
    $09 constant UCPD_RXORDDETIE                \ [0x09] RXORDDET interrupt enable
    $0a constant UCPD_RXHRSTDETIE               \ [0x0a] RXHRSTDET interrupt enable
    $0b constant UCPD_RXOVRIE                   \ [0x0b] RXOVR interrupt enable
    $0c constant UCPD_RXMSGENDIE                \ [0x0c] RXMSGEND interrupt enable
    $0e constant UCPD_TYPECEVT1IE               \ [0x0e] TYPECEVT1 interrupt enable
    $0f constant UCPD_TYPECEVT2IE               \ [0x0f] TYPECEVT2 interrupt enable
    $14 constant UCPD_FRSEVTIE                  \ [0x14] FRSEVT interrupt enable
  [then]


  [ifdef] UCPD_UCPD_SR_DEF
    \
    \ @brief UCPD status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXIS                      \ [0x00] Transmit interrupt status
    $01 constant UCPD_TXMSGDISC                 \ [0x01] Message transmission discarded
    $02 constant UCPD_TXMSGSENT                 \ [0x02] Message transmission completed
    $03 constant UCPD_TXMSGABT                  \ [0x03] Transmit message abort
    $04 constant UCPD_HRSTDISC                  \ [0x04] Hard Reset discarded
    $05 constant UCPD_HRSTSENT                  \ [0x05] Hard Reset message sent
    $06 constant UCPD_TXUND                     \ [0x06] Tx data underrun detection
    $08 constant UCPD_RXNE                      \ [0x08] Receive data register not empty detection
    $09 constant UCPD_RXORDDET                  \ [0x09] Rx ordered set (4 K-codes) detection
    $0a constant UCPD_RXHRSTDET                 \ [0x0a] Rx Hard Reset receipt detection
    $0b constant UCPD_RXOVR                     \ [0x0b] Rx data overflow detection
    $0c constant UCPD_RXMSGEND                  \ [0x0c] Rx message received
    $0d constant UCPD_RXERR                     \ [0x0d] Receive message error
    $0e constant UCPD_TYPECEVT1                 \ [0x0e] Type-C voltage level event on CC1 line
    $0f constant UCPD_TYPECEVT2                 \ [0x0f] Type-C voltage level event on CC2 line
    $10 constant UCPD_TYPEC_VSTATE_CC1          \ [0x10 : 2] The status bitfield indicates the voltage level on the CC1 line in its steady state.
    $12 constant UCPD_TYPEC_VSTATE_CC2          \ [0x12 : 2] CC2 line voltage level
    $14 constant UCPD_FRSEVT                    \ [0x14] FRS detection event
  [then]


  [ifdef] UCPD_UCPD_ICR_DEF
    \
    \ @brief UCPD interrupt clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant UCPD_TXMSGDISCCF               \ [0x01] Tx message discard flag (TXMSGDISC) clear
    $02 constant UCPD_TXMSGSENTCF               \ [0x02] Tx message send flag (TXMSGSENT) clear
    $03 constant UCPD_TXMSGABTCF                \ [0x03] Tx message abort flag (TXMSGABT) clear
    $04 constant UCPD_HRSTDISCCF                \ [0x04] Hard reset discard flag (HRSTDISC) clear
    $05 constant UCPD_HRSTSENTCF                \ [0x05] Hard reset send flag (HRSTSENT) clear
    $06 constant UCPD_TXUNDCF                   \ [0x06] Tx underflow flag (TXUND) clear
    $09 constant UCPD_RXORDDETCF                \ [0x09] Rx ordered set detect flag (RXORDDET) clear
    $0a constant UCPD_RXHRSTDETCF               \ [0x0a] Rx Hard Reset detect flag (RXHRSTDET) clear
    $0b constant UCPD_RXOVRCF                   \ [0x0b] Rx overflow flag (RXOVR) clear
    $0c constant UCPD_RXMSGENDCF                \ [0x0c] Rx message received flag (RXMSGEND) clear
    $0e constant UCPD_TYPECEVT1CF               \ [0x0e] Type-C CC1 event flag (TYPECEVT1) clear
    $0f constant UCPD_TYPECEVT2CF               \ [0x0f] Type-C CC2 line event flag (TYPECEVT2) clear
    $14 constant UCPD_FRSEVTCF                  \ [0x14] FRS event flag (FRSEVT) clear
  [then]


  [ifdef] UCPD_UCPD_TX_ORDSETR_DEF
    \
    \ @brief UCPD Tx ordered set type register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXORDSET                  \ [0x00 : 20] Ordered set to transmit
  [then]


  [ifdef] UCPD_UCPD_TX_PAYSZR_DEF
    \
    \ @brief UCPD Tx payload size register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXPAYSZ                   \ [0x00 : 10] Payload size yet to transmit
  [then]


  [ifdef] UCPD_UCPD_TXDR_DEF
    \
    \ @brief UCPD Tx data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_TXDATA                    \ [0x00 : 8] Data byte to transmit
  [then]


  [ifdef] UCPD_UCPD_RX_ORDSETR_DEF
    \
    \ @brief UCPD Rx ordered set register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXORDSET                  \ [0x00 : 3] Rx ordered set code detected
    $03 constant UCPD_RXSOP3OF4                 \ [0x03] The bit indicates the number of correct K-codes.
    $04 constant UCPD_RXSOPKINVALID             \ [0x04 : 3] The bitfield is for debug purposes only.
  [then]


  [ifdef] UCPD_UCPD_RX_PAYSZR_DEF
    \
    \ @brief UCPD Rx payload size register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXPAYSZ                   \ [0x00 : 10] Rx payload size received
  [then]


  [ifdef] UCPD_UCPD_RXDR_DEF
    \
    \ @brief UCPD receive data register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXDATA                    \ [0x00 : 8] Data byte received
  [then]


  [ifdef] UCPD_UCPD_RX_ORDEXTR1_DEF
    \
    \ @brief UCPD Rx ordered set extension register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXSOPX1                   \ [0x00 : 20] Ordered set 1 received
  [then]


  [ifdef] UCPD_UCPD_RX_ORDEXTR2_DEF
    \
    \ @brief UCPD Rx ordered set extension register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant UCPD_RXSOPX2                   \ [0x00 : 20] Ordered set 2 received
  [then]

  \
  \ @brief UCPD register block
  \
  $00 constant UCPD_UCPD_CFGR1          \ UCPD configuration register 1
  $04 constant UCPD_UCPD_CFGR2          \ UCPD configuration register 2
  $08 constant UCPD_UCPD_CFGR3          \ UCPD configuration register 3
  $0C constant UCPD_UCPD_CR             \ UCPD control register
  $10 constant UCPD_UCPD_IMR            \ UCPD interrupt mask register
  $14 constant UCPD_UCPD_SR             \ UCPD status register
  $18 constant UCPD_UCPD_ICR            \ UCPD interrupt clear register
  $1C constant UCPD_UCPD_TX_ORDSETR     \ UCPD Tx ordered set type register
  $20 constant UCPD_UCPD_TX_PAYSZR      \ UCPD Tx payload size register
  $24 constant UCPD_UCPD_TXDR           \ UCPD Tx data register
  $28 constant UCPD_UCPD_RX_ORDSETR     \ UCPD Rx ordered set register
  $2C constant UCPD_UCPD_RX_PAYSZR      \ UCPD Rx payload size register
  $30 constant UCPD_UCPD_RXDR           \ UCPD receive data register
  $34 constant UCPD_UCPD_RX_ORDEXTR1    \ UCPD Rx ordered set extension register 1
  $38 constant UCPD_UCPD_RX_ORDEXTR2    \ UCPD Rx ordered set extension register 2

: UCPD_DEF ; [then]
