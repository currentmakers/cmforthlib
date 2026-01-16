\
\ @file ucpd2.fs
\ @brief USB Power Delivery interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief UCPD configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000003f constant UCPD2_CFG1_HBITCLKDIV                            \ HBITCLKDIV
$000007c0 constant UCPD2_CFG1_IFRGAP                                \ IFRGAP
$0000f800 constant UCPD2_CFG1_TRANSWIN                              \ TRANSWIN
$000e0000 constant UCPD2_CFG1_PSC_USBPDCLK                          \ PSC_USBPDCLK
$1ff00000 constant UCPD2_CFG1_RXORDSETEN                            \ RXORDSETEN
$20000000 constant UCPD2_CFG1_TXDMAEN                               \ TXDMAEN
$40000000 constant UCPD2_CFG1_RXDMAEN                               \ RXDMAEN:
$80000000 constant UCPD2_CFG1_UCPDEN                                \ UCPDEN


\
\ @brief UCPD configuration register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant UCPD2_CFG2_RXFILTDIS                             \ RXFILTDIS
$00000002 constant UCPD2_CFG2_RXFILT2N3                             \ RXFILT2N3
$00000004 constant UCPD2_CFG2_FORCECLK                              \ FORCECLK
$00000008 constant UCPD2_CFG2_WUPEN                                 \ WUPEN


\
\ @brief UCPD configuration register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant UCPD2_CFG3_TRIM1_NG_CCRPD                        \ TRIM1_NG_CCRPD
$000001f0 constant UCPD2_CFG3_TRIM1_NG_CC1A5                        \ TRIM1_NG_CC1A5
$00001e00 constant UCPD2_CFG3_TRIM1_NG_CC3A0                        \ TRIM1_NG_CC3A0
$000f0000 constant UCPD2_CFG3_TRIM2_NG_CCRPD                        \ TRIM2_NG_CCRPD
$01f00000 constant UCPD2_CFG3_TRIM2_NG_CC1A5                        \ TRIM2_NG_CC1A5
$1e000000 constant UCPD2_CFG3_TRIM2_NG_CC3A0                        \ TRIM2_NG_CC3A0


\
\ @brief UCPD control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant UCPD2_CR_TXMODE                                  \ TXMODE
$00000004 constant UCPD2_CR_TXSEND                                  \ TXSEND
$00000008 constant UCPD2_CR_TXHRST                                  \ TXHRST
$00000010 constant UCPD2_CR_RXMODE                                  \ RXMODE
$00000020 constant UCPD2_CR_PHYRXEN                                 \ PHYRXEN
$00000040 constant UCPD2_CR_PHYCCSEL                                \ PHYCCSEL
$00000180 constant UCPD2_CR_ANASUBMODE                              \ ANASUBMODE
$00000200 constant UCPD2_CR_ANAMODE                                 \ ANAMODE
$00000c00 constant UCPD2_CR_CCENABLE                                \ CCENABLE
$00008000 constant UCPD2_CR_DBATTEN                                 \ DBATTEN
$00010000 constant UCPD2_CR_FRSRXEN                                 \ FRSRXEN
$00020000 constant UCPD2_CR_FRSTX                                   \ FRSTX
$00040000 constant UCPD2_CR_RDCH                                    \ RDCH
$00100000 constant UCPD2_CR_CC1TCDIS                                \ CC1TCDIS
$00200000 constant UCPD2_CR_CC2TCDIS                                \ CC2TCDIS


\
\ @brief UCPD Interrupt Mask Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant UCPD2_IMR_TXISIE                                 \ TXISIE
$00000002 constant UCPD2_IMR_TXMSGDISCIE                            \ TXMSGDISCIE
$00000004 constant UCPD2_IMR_TXMSGSENTIE                            \ TXMSGSENTIE
$00000008 constant UCPD2_IMR_TXMSGABTIE                             \ TXMSGABTIE
$00000010 constant UCPD2_IMR_HRSTDISCIE                             \ HRSTDISCIE
$00000020 constant UCPD2_IMR_HRSTSENTIE                             \ HRSTSENTIE
$00000040 constant UCPD2_IMR_TXUNDIE                                \ TXUNDIE
$00000100 constant UCPD2_IMR_RXNEIE                                 \ RXNEIE
$00000200 constant UCPD2_IMR_RXORDDETIE                             \ RXORDDETIE
$00000400 constant UCPD2_IMR_RXHRSTDETIE                            \ RXHRSTDETIE
$00000800 constant UCPD2_IMR_RXOVRIE                                \ RXOVRIE
$00001000 constant UCPD2_IMR_RXMSGENDIE                             \ RXMSGENDIE
$00004000 constant UCPD2_IMR_TYPECEVT1IE                            \ TYPECEVT1IE
$00008000 constant UCPD2_IMR_TYPECEVT2IE                            \ TYPECEVT2IE
$00100000 constant UCPD2_IMR_FRSEVTIE                               \ FRSEVTIE


\
\ @brief UCPD Status Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant UCPD2_SR_TXIS                                    \ TXIS
$00000002 constant UCPD2_SR_TXMSGDISC                               \ TXMSGDISC
$00000004 constant UCPD2_SR_TXMSGSENT                               \ TXMSGSENT
$00000008 constant UCPD2_SR_TXMSGABT                                \ TXMSGABT
$00000010 constant UCPD2_SR_HRSTDISC                                \ HRSTDISC
$00000020 constant UCPD2_SR_HRSTSENT                                \ HRSTSENT
$00000040 constant UCPD2_SR_TXUND                                   \ TXUND
$00000100 constant UCPD2_SR_RXNE                                    \ RXNE
$00000200 constant UCPD2_SR_RXORDDET                                \ RXORDDET
$00000400 constant UCPD2_SR_RXHRSTDET                               \ RXHRSTDET
$00000800 constant UCPD2_SR_RXOVR                                   \ RXOVR
$00001000 constant UCPD2_SR_RXMSGEND                                \ RXMSGEND
$00002000 constant UCPD2_SR_RXERR                                   \ RXERR
$00004000 constant UCPD2_SR_TYPECEVT1                               \ TYPECEVT1
$00008000 constant UCPD2_SR_TYPECEVT2                               \ TYPECEVT2
$00030000 constant UCPD2_SR_TYPEC_VSTATE_CC1                        \ TYPEC_VSTATE_CC1
$000c0000 constant UCPD2_SR_TYPEC_VSTATE_CC2                        \ TYPEC_VSTATE_CC2
$00100000 constant UCPD2_SR_FRSEVT                                  \ FRSEVT


\
\ @brief UCPD Interrupt Clear Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant UCPD2_ICR_TXMSGDISCCF                            \ TXMSGDISCCF
$00000004 constant UCPD2_ICR_TXMSGSENTCF                            \ TXMSGSENTCF
$00000008 constant UCPD2_ICR_TXMSGABTCF                             \ TXMSGABTCF
$00000010 constant UCPD2_ICR_HRSTDISCCF                             \ HRSTDISCCF
$00000020 constant UCPD2_ICR_HRSTSENTCF                             \ HRSTSENTCF
$00000040 constant UCPD2_ICR_TXUNDCF                                \ TXUNDCF
$00000200 constant UCPD2_ICR_RXORDDETCF                             \ RXORDDETCF
$00000400 constant UCPD2_ICR_RXHRSTDETCF                            \ RXHRSTDETCF
$00000800 constant UCPD2_ICR_RXOVRCF                                \ RXOVRCF
$00001000 constant UCPD2_ICR_RXMSGENDCF                             \ RXMSGENDCF
$00004000 constant UCPD2_ICR_TYPECEVT1CF                            \ TYPECEVT1CF
$00008000 constant UCPD2_ICR_TYPECEVT2CF                            \ TYPECEVT2CF
$00100000 constant UCPD2_ICR_FRSEVTCF                               \ FRSEVTCF


\
\ @brief UCPD Tx Ordered Set Type Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000fffff constant UCPD2_TX_ORDSET_TXORDSET                         \ TXORDSET


\
\ @brief UCPD Tx Paysize Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000003ff constant UCPD2_TX_PAYSZ_TXPAYSZ                           \ TXPAYSZ


\
\ @brief UCPD Tx Data Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant UCPD2_TXDR_TXDATA                                \ TXDATA


\
\ @brief UCPD Rx Ordered Set Register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000007 constant UCPD2_RX_ORDSET_RXORDSET                         \ RXORDSET
$00000008 constant UCPD2_RX_ORDSET_RXSOP3OF4                        \ RXSOP3OF4
$00000070 constant UCPD2_RX_ORDSET_RXSOPKINVALID                    \ RXSOPKINVALID


\
\ @brief UCPD Rx Paysize Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000003ff constant UCPD2_RX_PAYSZ_RXPAYSZ                           \ RXPAYSZ


\
\ @brief UCPD Receive Data Register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant UCPD2_RXDR_RXDATA                                \ RXDATA


\
\ @brief UCPD Rx Ordered Set Extension Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant UCPD2_RX_ORDEXT1_RXSOPX1                         \ RXSOPX1


\
\ @brief UCPD Rx Ordered Set Extension Register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant UCPD2_RX_ORDEXT2_RXSOPX2                         \ RXSOPX2


\
\ @brief UCPD IP ID register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$00000000 constant UCPD2_IPVER_IPVER                                \ IPVER


\
\ @brief UCPD IP ID register
\ Address offset: 0x3F8
\ Reset value: 0x00150021
\

$00000000 constant UCPD2_IPID_IPID                                  \ IPID


\
\ @brief UCPD IP ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant UCPD2_MID_IPID                                   \ IPID


\
\ @brief USB Power Delivery interface
\
$4000a400 constant UCPD2_CFG1     \ offset: 0x00 : UCPD configuration register
$4000a404 constant UCPD2_CFG2     \ offset: 0x04 : UCPD configuration register 2
$4000a408 constant UCPD2_CFG3     \ offset: 0x08 : UCPD configuration register 3
$4000a40c constant UCPD2_CR       \ offset: 0x0C : UCPD control register
$4000a410 constant UCPD2_IMR      \ offset: 0x10 : UCPD Interrupt Mask Register
$4000a414 constant UCPD2_SR       \ offset: 0x14 : UCPD Status Register
$4000a418 constant UCPD2_ICR      \ offset: 0x18 : UCPD Interrupt Clear Register
$4000a41c constant UCPD2_TX_ORDSET  \ offset: 0x1C : UCPD Tx Ordered Set Type Register
$4000a420 constant UCPD2_TX_PAYSZ  \ offset: 0x20 : UCPD Tx Paysize Register
$4000a424 constant UCPD2_TXDR     \ offset: 0x24 : UCPD Tx Data Register
$4000a428 constant UCPD2_RX_ORDSET  \ offset: 0x28 : UCPD Rx Ordered Set Register
$4000a42c constant UCPD2_RX_PAYSZ  \ offset: 0x2C : UCPD Rx Paysize Register
$4000a430 constant UCPD2_RXDR     \ offset: 0x30 : UCPD Receive Data Register
$4000a434 constant UCPD2_RX_ORDEXT1  \ offset: 0x34 : UCPD Rx Ordered Set Extension Register
$4000a438 constant UCPD2_RX_ORDEXT2  \ offset: 0x38 : UCPD Rx Ordered Set Extension Register
$4000a7f4 constant UCPD2_IPVER    \ offset: 0x3F4 : UCPD IP ID register
$4000a7f8 constant UCPD2_IPID     \ offset: 0x3F8 : UCPD IP ID register
$4000a7fc constant UCPD2_MID      \ offset: 0x3FC : UCPD IP ID register

