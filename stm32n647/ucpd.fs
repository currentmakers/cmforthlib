\
\ @file ucpd.fs
\ @brief USB Type-C/USB Power Delivery interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief UCPD configuration register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000003f constant UCPD_UCPD_CFGR1_HBITCLKDIV                       \ Division ratio for producing half-bit clock
$000007c0 constant UCPD_UCPD_CFGR1_IFRGAP                           \ Division ratio for producing inter-frame gap timer clock
$0000f800 constant UCPD_UCPD_CFGR1_TRANSWIN                         \ Transition window duration
$000e0000 constant UCPD_UCPD_CFGR1_PSC_USBPDCLK                     \ Pre-scaler division ratio for generating ucpd_clk
$1ff00000 constant UCPD_UCPD_CFGR1_RXORDSETEN                       \ Receiver ordered set enable
$20000000 constant UCPD_UCPD_CFGR1_TXDMAEN                          \ Transmission DMA mode enable
$40000000 constant UCPD_UCPD_CFGR1_RXDMAEN                          \ Reception DMA mode enable
$80000000 constant UCPD_UCPD_CFGR1_UCPDEN                           \ UCPD peripheral enable


\
\ @brief UCPD configuration register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant UCPD_UCPD_CFGR2_RXFILTDIS                        \ BMC decoder Rx pre-filter enable
$00000002 constant UCPD_UCPD_CFGR2_RXFILT2N3                        \ BMC decoder Rx pre-filter sampling method
$00000004 constant UCPD_UCPD_CFGR2_FORCECLK                         \ Force ClkReq clock request
$00000008 constant UCPD_UCPD_CFGR2_WUPEN                            \ Wakeup from Stop mode enable


\
\ @brief UCPD control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant UCPD_UCPD_CR_TXMODE                              \ Type of Tx packet
$00000004 constant UCPD_UCPD_CR_TXSEND                              \ Command to send a Tx packet
$00000008 constant UCPD_UCPD_CR_TXHRST                              \ Command to send a Tx Hard Reset
$00000010 constant UCPD_UCPD_CR_RXMODE                              \ Receiver mode
$00000020 constant UCPD_UCPD_CR_PHYRXEN                             \ USB Power Delivery receiver enable
$00000040 constant UCPD_UCPD_CR_PHYCCSEL                            \ CC1/CC2 line selector for USB Power Delivery signaling
$00000180 constant UCPD_UCPD_CR_ANASUBMODE                          \ Analog PHY sub-mode
$00000200 constant UCPD_UCPD_CR_ANAMODE                             \ Analog PHY operating mode
$00000c00 constant UCPD_UCPD_CR_CCENABLE                            \ CC line enable
$00010000 constant UCPD_UCPD_CR_FRSRXEN                             \ FRS event detection enable
$00020000 constant UCPD_UCPD_CR_FRSTX                               \ FRS Tx signaling enable.
$00040000 constant UCPD_UCPD_CR_RDCH                                \ Rdch condition drive
$00100000 constant UCPD_UCPD_CR_CC1TCDIS                            \ CC1 Type-C detector disable
$00200000 constant UCPD_UCPD_CR_CC2TCDIS                            \ CC2 Type-C detector disable


\
\ @brief UCPD interrupt mask register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant UCPD_UCPD_IMR_TXISIE                             \ TXIS interrupt enable
$00000002 constant UCPD_UCPD_IMR_TXMSGDISCIE                        \ TXMSGDISC interrupt enable
$00000004 constant UCPD_UCPD_IMR_TXMSGSENTIE                        \ TXMSGSENT interrupt enable
$00000008 constant UCPD_UCPD_IMR_TXMSGABTIE                         \ TXMSGABT interrupt enable
$00000010 constant UCPD_UCPD_IMR_HRSTDISCIE                         \ HRSTDISC interrupt enable
$00000020 constant UCPD_UCPD_IMR_HRSTSENTIE                         \ HRSTSENT interrupt enable
$00000040 constant UCPD_UCPD_IMR_TXUNDIE                            \ TXUND interrupt enable
$00000100 constant UCPD_UCPD_IMR_RXNEIE                             \ RXNE interrupt enable
$00000200 constant UCPD_UCPD_IMR_RXORDDETIE                         \ RXORDDET interrupt enable
$00000400 constant UCPD_UCPD_IMR_RXHRSTDETIE                        \ RXHRSTDET interrupt enable
$00000800 constant UCPD_UCPD_IMR_RXOVRIE                            \ RXOVR interrupt enable
$00001000 constant UCPD_UCPD_IMR_RXMSGENDIE                         \ RXMSGEND interrupt enable
$00004000 constant UCPD_UCPD_IMR_TYPECEVT1IE                        \ TYPECEVT1 interrupt enable
$00008000 constant UCPD_UCPD_IMR_TYPECEVT2IE                        \ TYPECEVT2 interrupt enable
$00100000 constant UCPD_UCPD_IMR_FRSEVTIE                           \ FRSEVT interrupt enable


\
\ @brief UCPD status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant UCPD_UCPD_SR_TXIS                                \ Transmit interrupt status
$00000002 constant UCPD_UCPD_SR_TXMSGDISC                           \ Message transmission discarded
$00000004 constant UCPD_UCPD_SR_TXMSGSENT                           \ Message transmission completed
$00000008 constant UCPD_UCPD_SR_TXMSGABT                            \ Transmit message abort
$00000010 constant UCPD_UCPD_SR_HRSTDISC                            \ Hard Reset discarded
$00000020 constant UCPD_UCPD_SR_HRSTSENT                            \ Hard Reset message sent
$00000040 constant UCPD_UCPD_SR_TXUND                               \ Tx data underrun detection
$00000100 constant UCPD_UCPD_SR_RXNE                                \ Receive data register not empty detection
$00000200 constant UCPD_UCPD_SR_RXORDDET                            \ Rx ordered set (4 K-codes) detection
$00000400 constant UCPD_UCPD_SR_RXHRSTDET                           \ Rx Hard Reset receipt detection
$00000800 constant UCPD_UCPD_SR_RXOVR                               \ Rx data overflow detection
$00001000 constant UCPD_UCPD_SR_RXMSGEND                            \ Rx message received
$00002000 constant UCPD_UCPD_SR_RXERR                               \ Receive message error
$00004000 constant UCPD_UCPD_SR_TYPECEVT1                           \ Type-C voltage level event on CC1 line
$00008000 constant UCPD_UCPD_SR_TYPECEVT2                           \ Type-C voltage level event on CC2 line
$00030000 constant UCPD_UCPD_SR_TYPEC_VSTATE_CC1                    \ The status bitfield indicates the voltage level on the CC1 line in its steady state.
$000c0000 constant UCPD_UCPD_SR_TYPEC_VSTATE_CC2                    \ CC2 line voltage level
$00100000 constant UCPD_UCPD_SR_FRSEVT                              \ FRS detection event


\
\ @brief UCPD interrupt clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant UCPD_UCPD_ICR_TXMSGDISCCF                        \ Tx message discard flag (TXMSGDISC) clear
$00000004 constant UCPD_UCPD_ICR_TXMSGSENTCF                        \ Tx message send flag (TXMSGSENT) clear
$00000008 constant UCPD_UCPD_ICR_TXMSGABTCF                         \ Tx message abort flag (TXMSGABT) clear
$00000010 constant UCPD_UCPD_ICR_HRSTDISCCF                         \ Hard reset discard flag (HRSTDISC) clear
$00000020 constant UCPD_UCPD_ICR_HRSTSENTCF                         \ Hard reset send flag (HRSTSENT) clear
$00000040 constant UCPD_UCPD_ICR_TXUNDCF                            \ Tx underflow flag (TXUND) clear
$00000200 constant UCPD_UCPD_ICR_RXORDDETCF                         \ Rx ordered set detect flag (RXORDDET) clear
$00000400 constant UCPD_UCPD_ICR_RXHRSTDETCF                        \ Rx Hard Reset detect flag (RXHRSTDET) clear
$00000800 constant UCPD_UCPD_ICR_RXOVRCF                            \ Rx overflow flag (RXOVR) clear
$00001000 constant UCPD_UCPD_ICR_RXMSGENDCF                         \ Rx message received flag (RXMSGEND) clear
$00004000 constant UCPD_UCPD_ICR_TYPECEVT1CF                        \ Type-C CC1 event flag (TYPECEVT1) clear
$00008000 constant UCPD_UCPD_ICR_TYPECEVT2CF                        \ Type-C CC2 line event flag (TYPECEVT2) clear
$00100000 constant UCPD_UCPD_ICR_FRSEVTCF                           \ FRS event flag (FRSEVT) clear


\
\ @brief UCPD Tx ordered set type register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000fffff constant UCPD_UCPD_TX_ORDSETR_TXORDSET                    \ Ordered set to transmit


\
\ @brief UCPD Tx payload size register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000003ff constant UCPD_UCPD_TX_PAYSZR_TXPAYSZ                      \ Payload size yet to transmit


\
\ @brief UCPD Tx data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant UCPD_UCPD_TXDR_TXDATA                            \ Data byte to transmit


\
\ @brief UCPD Rx ordered set register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000007 constant UCPD_UCPD_RX_ORDSETR_RXORDSET                    \ Rx ordered set code detected
$00000008 constant UCPD_UCPD_RX_ORDSETR_RXSOP3OF4                   \ The bit indicates the number of correct K-codes. For debug purposes only.
$00000070 constant UCPD_UCPD_RX_ORDSETR_RXSOPKINVALID               \ The bitfield is for debug purposes only.


\
\ @brief UCPD Rx payload size register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000003ff constant UCPD_UCPD_RX_PAYSZR_RXPAYSZ                      \ Rx payload size received


\
\ @brief UCPD receive data register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant UCPD_UCPD_RXDR_RXDATA                            \ Data byte received


\
\ @brief UCPD Rx ordered set extension register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant UCPD_UCPD_RX_ORDEXTR1_RXSOPX1                    \ Ordered set 1 received


\
\ @brief UCPD Rx ordered set extension register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant UCPD_UCPD_RX_ORDEXTR2_RXSOPX2                    \ Ordered set 2 received


\
\ @brief USB Type-C/USB Power Delivery interface
\
$4000fc00 constant UCPD_UCPD_CFGR1  \ offset: 0x00 : UCPD configuration register 1
$4000fc04 constant UCPD_UCPD_CFGR2  \ offset: 0x04 : UCPD configuration register 2
$4000fc0c constant UCPD_UCPD_CR   \ offset: 0x0C : UCPD control register
$4000fc10 constant UCPD_UCPD_IMR  \ offset: 0x10 : UCPD interrupt mask register
$4000fc14 constant UCPD_UCPD_SR   \ offset: 0x14 : UCPD status register
$4000fc18 constant UCPD_UCPD_ICR  \ offset: 0x18 : UCPD interrupt clear register
$4000fc1c constant UCPD_UCPD_TX_ORDSETR  \ offset: 0x1C : UCPD Tx ordered set type register
$4000fc20 constant UCPD_UCPD_TX_PAYSZR  \ offset: 0x20 : UCPD Tx payload size register
$4000fc24 constant UCPD_UCPD_TXDR  \ offset: 0x24 : UCPD Tx data register
$4000fc28 constant UCPD_UCPD_RX_ORDSETR  \ offset: 0x28 : UCPD Rx ordered set register
$4000fc2c constant UCPD_UCPD_RX_PAYSZR  \ offset: 0x2C : UCPD Rx payload size register
$4000fc30 constant UCPD_UCPD_RXDR  \ offset: 0x30 : UCPD receive data register
$4000fc34 constant UCPD_UCPD_RX_ORDEXTR1  \ offset: 0x34 : UCPD Rx ordered set extension register 1
$4000fc38 constant UCPD_UCPD_RX_ORDEXTR2  \ offset: 0x38 : UCPD Rx ordered set extension register 2

