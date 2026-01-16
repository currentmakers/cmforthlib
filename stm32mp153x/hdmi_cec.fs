\
\ @file hdmi_cec.fs
\ @brief HDMI_CEC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CEC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant HDMI_CEC_CEC_CR_CECEN                            \ CECEN
$00000002 constant HDMI_CEC_CEC_CR_TXSOM                            \ TXSOM
$00000004 constant HDMI_CEC_CEC_CR_TXEOM                            \ TXEOM


\
\ @brief This register is used to configure the HDMI-CEC controller. It is mandatory to write CEC_CFGR only when CECEN=0.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant HDMI_CEC_CEC_CFGR_SFT                            \ SFT
$00000008 constant HDMI_CEC_CEC_CFGR_RXTOL                          \ RXTOL
$00000010 constant HDMI_CEC_CEC_CFGR_BRESTP                         \ BRESTP
$00000020 constant HDMI_CEC_CEC_CFGR_BREGEN                         \ BREGEN
$00000040 constant HDMI_CEC_CEC_CFGR_LBPEGEN                        \ LBPEGEN
$00000080 constant HDMI_CEC_CEC_CFGR_BRDNOGEN                       \ BRDNOGEN
$00000100 constant HDMI_CEC_CEC_CFGR_SFTOP                          \ SFTOP
$7fff0000 constant HDMI_CEC_CEC_CFGR_OAR                            \ OAR
$80000000 constant HDMI_CEC_CEC_CFGR_LSTN                           \ LSTN


\
\ @brief CEC Tx data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant HDMI_CEC_CEC_TXDR_TXD                            \ TXD


\
\ @brief CEC Rx data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant HDMI_CEC_CEC_RXDR_RXD                            \ RXD


\
\ @brief CEC Interrupt and Status Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant HDMI_CEC_CEC_ISR_RXBR                            \ RXBR
$00000002 constant HDMI_CEC_CEC_ISR_RXEND                           \ RXEND
$00000004 constant HDMI_CEC_CEC_ISR_RXOVR                           \ RXOVR
$00000008 constant HDMI_CEC_CEC_ISR_BRE                             \ BRE
$00000010 constant HDMI_CEC_CEC_ISR_SBPE                            \ SBPE
$00000020 constant HDMI_CEC_CEC_ISR_LBPE                            \ LBPE
$00000040 constant HDMI_CEC_CEC_ISR_RXACKE                          \ RXACKE
$00000080 constant HDMI_CEC_CEC_ISR_ARBLST                          \ ARBLST
$00000100 constant HDMI_CEC_CEC_ISR_TXBR                            \ TXBR
$00000200 constant HDMI_CEC_CEC_ISR_TXEND                           \ TXEND
$00000400 constant HDMI_CEC_CEC_ISR_TXUDR                           \ TXUDR
$00000800 constant HDMI_CEC_CEC_ISR_TXERR                           \ TXERR
$00001000 constant HDMI_CEC_CEC_ISR_TXACKE                          \ TXACKE


\
\ @brief CEC interrupt enable register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant HDMI_CEC_CEC_IER_RXBRIE                          \ RXBRIE
$00000002 constant HDMI_CEC_CEC_IER_RXENDIE                         \ RXENDIE
$00000004 constant HDMI_CEC_CEC_IER_RXOVRIE                         \ RXOVRIE
$00000008 constant HDMI_CEC_CEC_IER_BREIE                           \ BREIE
$00000010 constant HDMI_CEC_CEC_IER_SBPEIE                          \ SBPEIE
$00000020 constant HDMI_CEC_CEC_IER_LBPEIE                          \ LBPEIE
$00000040 constant HDMI_CEC_CEC_IER_RXACKIE                         \ RXACKIE
$00000080 constant HDMI_CEC_CEC_IER_ARBLSTIE                        \ ARBLSTIE
$00000100 constant HDMI_CEC_CEC_IER_TXBRIE                          \ TXBRIE
$00000200 constant HDMI_CEC_CEC_IER_TXENDIE                         \ TXENDIE
$00000400 constant HDMI_CEC_CEC_IER_TXUDRIE                         \ TXUDRIE
$00000800 constant HDMI_CEC_CEC_IER_TXERRIE                         \ TXERRIE
$00001000 constant HDMI_CEC_CEC_IER_TXACKIE                         \ TXACKIE


\
\ @brief HDMI_CEC
\
$40016000 constant HDMI_CEC_CEC_CR  \ offset: 0x00 : CEC control register
$40016004 constant HDMI_CEC_CEC_CFGR  \ offset: 0x04 : This register is used to configure the HDMI-CEC controller. It is mandatory to write CEC_CFGR only when CECEN=0.
$40016008 constant HDMI_CEC_CEC_TXDR  \ offset: 0x08 : CEC Tx data register
$4001600c constant HDMI_CEC_CEC_RXDR  \ offset: 0x0C : CEC Rx data register
$40016010 constant HDMI_CEC_CEC_ISR  \ offset: 0x10 : CEC Interrupt and Status Register
$40016014 constant HDMI_CEC_CEC_IER  \ offset: 0x14 : CEC interrupt enable register

