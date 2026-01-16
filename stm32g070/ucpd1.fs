\
\ @file ucpd1.fs
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

$0000003f constant UCPD1_CFG1_HBITCLKDIV                            \ HBITCLKDIV
$000007c0 constant UCPD1_CFG1_IFRGAP                                \ IFRGAP
$0000f800 constant UCPD1_CFG1_TRANSWIN                              \ TRANSWIN
$000e0000 constant UCPD1_CFG1_PSC_USBPDCLK                          \ PSC_USBPDCLK
$1ff00000 constant UCPD1_CFG1_RXORDSETEN                            \ RXORDSETEN
$20000000 constant UCPD1_CFG1_TXDMAEN                               \ TXDMAEN
$40000000 constant UCPD1_CFG1_RXDMAEN                               \ RXDMAEN:
$80000000 constant UCPD1_CFG1_UCPDEN                                \ UCPDEN


\
\ @brief UCPD configuration register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant UCPD1_CFG2_RXFILTDIS                             \ RXFILTDIS
$00000002 constant UCPD1_CFG2_RXFILT2N3                             \ RXFILT2N3
$00000004 constant UCPD1_CFG2_FORCECLK                              \ FORCECLK
$00000008 constant UCPD1_CFG2_WUPEN                                 \ WUPEN


\
\ @brief UCPD configuration register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant UCPD1_CFG3_TRIM1_NG_CCRPD                        \ TRIM1_NG_CCRPD
$000001f0 constant UCPD1_CFG3_TRIM1_NG_CC1A5                        \ TRIM1_NG_CC1A5
$00001e00 constant UCPD1_CFG3_TRIM1_NG_CC3A0                        \ TRIM1_NG_CC3A0
$000f0000 constant UCPD1_CFG3_TRIM2_NG_CCRPD                        \ TRIM2_NG_CCRPD
$01f00000 constant UCPD1_CFG3_TRIM2_NG_CC1A5                        \ TRIM2_NG_CC1A5
$1e000000 constant UCPD1_CFG3_TRIM2_NG_CC3A0                        \ TRIM2_NG_CC3A0


\
\ @brief UCPD control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant UCPD1_CR_TXMODE                                  \ TXMODE
$00000004 constant UCPD1_CR_TXSEND                                  \ TXSEND
$00000008 constant UCPD1_CR_TXHRST                                  \ TXHRST
$00000010 constant UCPD1_CR_RXMODE                                  \ RXMODE
$00000020 constant UCPD1_CR_PHYRXEN                                 \ PHYRXEN
$00000040 constant UCPD1_CR_PHYCCSEL                                \ PHYCCSEL
$00000180 constant UCPD1_CR_ANASUBMODE                              \ ANASUBMODE
$00000200 constant UCPD1_CR_ANAMODE                                 \ ANAMODE
$00000c00 constant UCPD1_CR_CCENABLE                                \ CCENABLE
$00008000 constant UCPD1_CR_DBATTEN                                 \ DBATTEN
$00010000 constant UCPD1_CR_FRSRXEN                                 \ FRSRXEN
$00020000 constant UCPD1_CR_FRSTX                                   \ FRSTX
$00040000 constant UCPD1_CR_RDCH                                    \ RDCH
$00100000 constant UCPD1_CR_CC1TCDIS                                \ CC1TCDIS
$00200000 constant UCPD1_CR_CC2TCDIS                                \ CC2TCDIS


\
\ @brief UCPD Interrupt Mask Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant UCPD1_IMR_TXISIE                                 \ TXISIE
$00000002 constant UCPD1_IMR_TXMSGDISCIE                            \ TXMSGDISCIE
$00000004 constant UCPD1_IMR_TXMSGSENTIE                            \ TXMSGSENTIE
$00000008 constant UCPD1_IMR_TXMSGABTIE                             \ TXMSGABTIE
$00000010 constant UCPD1_IMR_HRSTDISCIE                             \ HRSTDISCIE
$00000020 constant UCPD1_IMR_HRSTSENTIE                             \ HRSTSENTIE
$00000040 constant UCPD1_IMR_TXUNDIE                                \ TXUNDIE
$00000100 constant UCPD1_IMR_RXNEIE                                 \ RXNEIE
$00000200 constant UCPD1_IMR_RXORDDETIE                             \ RXORDDETIE
$00000400 constant UCPD1_IMR_RXHRSTDETIE                            \ RXHRSTDETIE
$00000800 constant UCPD1_IMR_RXOVRIE                                \ RXOVRIE
$00001000 constant UCPD1_IMR_RXMSGENDIE                             \ RXMSGENDIE
$00004000 constant UCPD1_IMR_TYPECEVT1IE                            \ TYPECEVT1IE
$00008000 constant UCPD1_IMR_TYPECEVT2IE                            \ TYPECEVT2IE
$00100000 constant UCPD1_IMR_FRSEVTIE                               \ FRSEVTIE


\
\ @brief UCPD Status Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant UCPD1_SR_TXIS                                    \ TXIS
$00000002 constant UCPD1_SR_TXMSGDISC                               \ TXMSGDISC
$00000004 constant UCPD1_SR_TXMSGSENT                               \ TXMSGSENT
$00000008 constant UCPD1_SR_TXMSGABT                                \ TXMSGABT
$00000010 constant UCPD1_SR_HRSTDISC                                \ HRSTDISC
$00000020 constant UCPD1_SR_HRSTSENT                                \ HRSTSENT
$00000040 constant UCPD1_SR_TXUND                                   \ TXUND
$00000100 constant UCPD1_SR_RXNE                                    \ RXNE
$00000200 constant UCPD1_SR_RXORDDET                                \ RXORDDET
$00000400 constant UCPD1_SR_RXHRSTDET                               \ RXHRSTDET
$00000800 constant UCPD1_SR_RXOVR                                   \ RXOVR
$00001000 constant UCPD1_SR_RXMSGEND                                \ RXMSGEND
$00002000 constant UCPD1_SR_RXERR                                   \ RXERR
$00004000 constant UCPD1_SR_TYPECEVT1                               \ TYPECEVT1
$00008000 constant UCPD1_SR_TYPECEVT2                               \ TYPECEVT2
$00030000 constant UCPD1_SR_TYPEC_VSTATE_CC1                        \ TYPEC_VSTATE_CC1
$000c0000 constant UCPD1_SR_TYPEC_VSTATE_CC2                        \ TYPEC_VSTATE_CC2
$00100000 constant UCPD1_SR_FRSEVT                                  \ FRSEVT


\
\ @brief UCPD Interrupt Clear Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant UCPD1_ICR_TXMSGDISCCF                            \ TXMSGDISCCF
$00000004 constant UCPD1_ICR_TXMSGSENTCF                            \ TXMSGSENTCF
$00000008 constant UCPD1_ICR_TXMSGABTCF                             \ TXMSGABTCF
$00000010 constant UCPD1_ICR_HRSTDISCCF                             \ HRSTDISCCF
$00000020 constant UCPD1_ICR_HRSTSENTCF                             \ HRSTSENTCF
$00000040 constant UCPD1_ICR_TXUNDCF                                \ TXUNDCF
$00000200 constant UCPD1_ICR_RXORDDETCF                             \ RXORDDETCF
$00000400 constant UCPD1_ICR_RXHRSTDETCF                            \ RXHRSTDETCF
$00000800 constant UCPD1_ICR_RXOVRCF                                \ RXOVRCF
$00001000 constant UCPD1_ICR_RXMSGENDCF                             \ RXMSGENDCF
$00004000 constant UCPD1_ICR_TYPECEVT1CF                            \ TYPECEVT1CF
$00008000 constant UCPD1_ICR_TYPECEVT2CF                            \ TYPECEVT2CF
$00100000 constant UCPD1_ICR_FRSEVTCF                               \ FRSEVTCF


\
\ @brief UCPD Tx Ordered Set Type Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000fffff constant UCPD1_TX_ORDSET_TXORDSET                         \ TXORDSET


\
\ @brief UCPD Tx Paysize Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000003ff constant UCPD1_TX_PAYSZ_TXPAYSZ                           \ TXPAYSZ


\
\ @brief UCPD Tx Data Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant UCPD1_TXDR_TXDATA                                \ TXDATA


\
\ @brief UCPD Rx Ordered Set Register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000007 constant UCPD1_RX_ORDSET_RXORDSET                         \ RXORDSET
$00000008 constant UCPD1_RX_ORDSET_RXSOP3OF4                        \ RXSOP3OF4
$00000070 constant UCPD1_RX_ORDSET_RXSOPKINVALID                    \ RXSOPKINVALID


\
\ @brief UCPD Rx Paysize Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000003ff constant UCPD1_RX_PAYSZ_RXPAYSZ                           \ RXPAYSZ


\
\ @brief UCPD Receive Data Register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant UCPD1_RXDR_RXDATA                                \ RXDATA


\
\ @brief UCPD Rx Ordered Set Extension Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant UCPD1_RX_ORDEXT1_RXSOPX1                         \ RXSOPX1


\
\ @brief UCPD Rx Ordered Set Extension Register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant UCPD1_RX_ORDEXT2_RXSOPX2                         \ RXSOPX2


\
\ @brief UCPD IP ID register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$00000000 constant UCPD1_IPVER_IPVER                                \ IPVER


\
\ @brief UCPD IP ID register
\ Address offset: 0x3F8
\ Reset value: 0x00150021
\

$00000000 constant UCPD1_IPID_IPID                                  \ IPID


\
\ @brief UCPD IP ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant UCPD1_MID_IPID                                   \ IPID


\
\ @brief USB Power Delivery interface
\
$4000a000 constant UCPD1_CFG1     \ offset: 0x00 : UCPD configuration register
$4000a004 constant UCPD1_CFG2     \ offset: 0x04 : UCPD configuration register 2
$4000a008 constant UCPD1_CFG3     \ offset: 0x08 : UCPD configuration register 3
$4000a00c constant UCPD1_CR       \ offset: 0x0C : UCPD control register
$4000a010 constant UCPD1_IMR      \ offset: 0x10 : UCPD Interrupt Mask Register
$4000a014 constant UCPD1_SR       \ offset: 0x14 : UCPD Status Register
$4000a018 constant UCPD1_ICR      \ offset: 0x18 : UCPD Interrupt Clear Register
$4000a01c constant UCPD1_TX_ORDSET  \ offset: 0x1C : UCPD Tx Ordered Set Type Register
$4000a020 constant UCPD1_TX_PAYSZ  \ offset: 0x20 : UCPD Tx Paysize Register
$4000a024 constant UCPD1_TXDR     \ offset: 0x24 : UCPD Tx Data Register
$4000a028 constant UCPD1_RX_ORDSET  \ offset: 0x28 : UCPD Rx Ordered Set Register
$4000a02c constant UCPD1_RX_PAYSZ  \ offset: 0x2C : UCPD Rx Paysize Register
$4000a030 constant UCPD1_RXDR     \ offset: 0x30 : UCPD Receive Data Register
$4000a034 constant UCPD1_RX_ORDEXT1  \ offset: 0x34 : UCPD Rx Ordered Set Extension Register
$4000a038 constant UCPD1_RX_ORDEXT2  \ offset: 0x38 : UCPD Rx Ordered Set Extension Register
$4000a3f4 constant UCPD1_IPVER    \ offset: 0x3F4 : UCPD IP ID register
$4000a3f8 constant UCPD1_IPID     \ offset: 0x3F8 : UCPD IP ID register
$4000a3fc constant UCPD1_MID      \ offset: 0x3FC : UCPD IP ID register

