\
\ @file hdmi_cec.fs
\ @brief HDMI-CEC controller
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

$00000001 constant HDMI_CEC_CEC_CR_CECEN                            \ CEC Enable
$00000002 constant HDMI_CEC_CEC_CR_TXSOM                            \ Tx Start Of Message
$00000004 constant HDMI_CEC_CEC_CR_TXEOM                            \ Tx End Of Message


\
\ @brief CEC configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant HDMI_CEC_CEC_CFGR_SFT                            \ Signal Free Time
$00000008 constant HDMI_CEC_CEC_CFGR_RXTOL                          \ Rx-Tolerance
$00000010 constant HDMI_CEC_CEC_CFGR_BRESTP                         \ Rx-Stop on Bit Rising Error
$00000020 constant HDMI_CEC_CEC_CFGR_BREGEN                         \ Generate Error-Bit on Bit Rising Error
$00000040 constant HDMI_CEC_CEC_CFGR_LBPEGEN                        \ Generate Error-Bit on Long Bit Period Error
$00000080 constant HDMI_CEC_CEC_CFGR_BRDNOGEN                       \ Avoid Error-Bit Generation in Broadcast
$00000100 constant HDMI_CEC_CEC_CFGR_SFTOP                          \ SFT Option Bit
$7fff0000 constant HDMI_CEC_CEC_CFGR_OAR                            \ Own addresses configuration
$80000000 constant HDMI_CEC_CEC_CFGR_LSTN                           \ Listen mode


\
\ @brief CEC Tx data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant HDMI_CEC_CEC_TXDR_TXD                            \ Tx Data register


\
\ @brief CEC Rx Data Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant HDMI_CEC_CEC_RXDR_RXD                            \ Rx Data register


\
\ @brief CEC Interrupt and Status Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant HDMI_CEC_CEC_ISR_RXBR                            \ Rx-Byte Received
$00000002 constant HDMI_CEC_CEC_ISR_RXEND                           \ End Of Reception
$00000004 constant HDMI_CEC_CEC_ISR_RXOVR                           \ Rx-Overrun
$00000008 constant HDMI_CEC_CEC_ISR_BRE                             \ Rx-Bit Rising Error
$00000010 constant HDMI_CEC_CEC_ISR_SBPE                            \ Rx-Short Bit Period Error
$00000020 constant HDMI_CEC_CEC_ISR_LBPE                            \ Rx-Long Bit Period Error
$00000040 constant HDMI_CEC_CEC_ISR_RXACKE                          \ Rx-Missing Acknowledge
$00000080 constant HDMI_CEC_CEC_ISR_ARBLST                          \ Arbitration Lost
$00000100 constant HDMI_CEC_CEC_ISR_TXBR                            \ Tx-Byte Request
$00000200 constant HDMI_CEC_CEC_ISR_TXEND                           \ End of Transmission
$00000400 constant HDMI_CEC_CEC_ISR_TXUDR                           \ Tx-Buffer Underrun
$00000800 constant HDMI_CEC_CEC_ISR_TXERR                           \ Tx-Error
$00001000 constant HDMI_CEC_CEC_ISR_TXACKE                          \ Tx-Missing Acknowledge Error


\
\ @brief CEC interrupt enable register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant HDMI_CEC_CEC_IER_RXBRIE                          \ Rx-Byte Received Interrupt Enable
$00000002 constant HDMI_CEC_CEC_IER_RXENDIE                         \ End Of Reception Interrupt Enable
$00000004 constant HDMI_CEC_CEC_IER_RXOVRIE                         \ Rx-Buffer Overrun Interrupt Enable
$00000008 constant HDMI_CEC_CEC_IER_BREIE                           \ Bit Rising Error Interrupt Enable
$00000010 constant HDMI_CEC_CEC_IER_SBPEIE                          \ Short Bit Period Error Interrupt Enable
$00000020 constant HDMI_CEC_CEC_IER_LBPEIE                          \ Long Bit Period Error Interrupt Enable
$00000040 constant HDMI_CEC_CEC_IER_RXACKIE                         \ Rx-Missing Acknowledge Error Interrupt Enable
$00000080 constant HDMI_CEC_CEC_IER_ARBLSTIE                        \ Arbitration Lost Interrupt Enable
$00000100 constant HDMI_CEC_CEC_IER_TXBRIE                          \ Tx-Byte Request Interrupt Enable
$00000200 constant HDMI_CEC_CEC_IER_TXENDIE                         \ Tx-End Of Message Interrupt Enable
$00000400 constant HDMI_CEC_CEC_IER_TXUDRIE                         \ Tx-Underrun Interrupt Enable
$00000800 constant HDMI_CEC_CEC_IER_TXERRIE                         \ Tx-Error Interrupt Enable
$00001000 constant HDMI_CEC_CEC_IER_TXACKIE                         \ Tx-Missing Acknowledge Error Interrupt Enable


\
\ @brief HDMI-CEC controller
\
$40006c00 constant HDMI_CEC_CEC_CR  \ offset: 0x00 : CEC control register
$40006c04 constant HDMI_CEC_CEC_CFGR  \ offset: 0x04 : CEC configuration register
$40006c08 constant HDMI_CEC_CEC_TXDR  \ offset: 0x08 : CEC Tx data register
$40006c0c constant HDMI_CEC_CEC_RXDR  \ offset: 0x0C : CEC Rx Data Register
$40006c10 constant HDMI_CEC_CEC_ISR  \ offset: 0x10 : CEC Interrupt and Status Register
$40006c14 constant HDMI_CEC_CEC_IER  \ offset: 0x14 : CEC interrupt enable register

