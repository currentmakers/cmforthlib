\
\ @file cec.fs
\ @brief HDMI-CEC controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant CEC_CR_CECEN                                     \ CEC Enable
$00000002 constant CEC_CR_TXSOM                                     \ Tx start of message
$00000004 constant CEC_CR_TXEOM                                     \ Tx End Of Message


\
\ @brief configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant CEC_CFGR_SFT                                     \ Signal Free Time
$00000008 constant CEC_CFGR_RXTOL                                   \ Rx-Tolerance
$00000010 constant CEC_CFGR_BRESTP                                  \ Rx-stop on bit rising error
$00000020 constant CEC_CFGR_BREGEN                                  \ Generate error-bit on bit rising error
$00000040 constant CEC_CFGR_LBPEGEN                                 \ Generate Error-Bit on Long Bit Period Error
$00000080 constant CEC_CFGR_BRDNOGEN                                \ Avoid Error-Bit Generation in Broadcast
$00000100 constant CEC_CFGR_SFTOP                                   \ SFT Option Bit
$7fff0000 constant CEC_CFGR_OAR                                     \ Own addresses configuration
$80000000 constant CEC_CFGR_LSTN                                    \ Listen mode


\
\ @brief Tx data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant CEC_TXDR_TXD                                     \ Tx Data register


\
\ @brief Rx Data Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant CEC_RXDR_RXDR                                    \ CEC Rx Data Register


\
\ @brief Interrupt and Status Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CEC_ISR_RXBR                                     \ Rx-Byte Received
$00000002 constant CEC_ISR_RXEND                                    \ End Of Reception
$00000004 constant CEC_ISR_RXOVR                                    \ Rx-Overrun
$00000008 constant CEC_ISR_BRE                                      \ Rx-Bit rising error
$00000010 constant CEC_ISR_SBPE                                     \ Rx-Short Bit period error
$00000020 constant CEC_ISR_LBPE                                     \ Rx-Long Bit Period Error
$00000040 constant CEC_ISR_RXACKE                                   \ Rx-Missing Acknowledge
$00000080 constant CEC_ISR_ARBLST                                   \ Arbitration Lost
$00000100 constant CEC_ISR_TXBR                                     \ Tx-Byte Request
$00000200 constant CEC_ISR_TXEND                                    \ End of Transmission
$00000400 constant CEC_ISR_TXUDR                                    \ Tx-Buffer Underrun
$00000800 constant CEC_ISR_TXERR                                    \ Tx-Error
$00001000 constant CEC_ISR_TXACKE                                   \ Tx-Missing acknowledge error


\
\ @brief interrupt enable register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CEC_IER_RXBRIE                                   \ Rx-Byte Received Interrupt Enable
$00000002 constant CEC_IER_RXENDIE                                  \ End Of Reception Interrupt Enable
$00000004 constant CEC_IER_RXOVRIE                                  \ Rx-Buffer Overrun Interrupt Enable
$00000008 constant CEC_IER_BREIE                                    \ Bit Rising Error Interrupt Enable
$00000010 constant CEC_IER_SBPEIE                                   \ Short Bit Period Error Interrupt Enable
$00000020 constant CEC_IER_LBPEIE                                   \ Long Bit Period Error Interrupt Enable
$00000040 constant CEC_IER_RXACKIE                                  \ Rx-Missing Acknowledge Error Interrupt Enable
$00000080 constant CEC_IER_ARBLSTIE                                 \ Arbitration Lost Interrupt Enable
$00000100 constant CEC_IER_TXBRIE                                   \ Tx-Byte Request Interrupt Enable
$00000200 constant CEC_IER_TXENDIE                                  \ Tx-End of message interrupt enable
$00000400 constant CEC_IER_TXUDRIE                                  \ Tx-Underrun interrupt enable
$00000800 constant CEC_IER_TXERRIE                                  \ Tx-Error Interrupt Enable
$00001000 constant CEC_IER_TXACKIE                                  \ Tx-Missing Acknowledge Error Interrupt Enable


\
\ @brief HDMI-CEC controller
\
$40006c00 constant CEC_CR         \ offset: 0x00 : control register
$40006c04 constant CEC_CFGR       \ offset: 0x04 : configuration register
$40006c08 constant CEC_TXDR       \ offset: 0x08 : Tx data register
$40006c0c constant CEC_RXDR       \ offset: 0x0C : Rx Data Register
$40006c10 constant CEC_ISR        \ offset: 0x10 : Interrupt and Status Register
$40006c14 constant CEC_IER        \ offset: 0x14 : interrupt enable register

