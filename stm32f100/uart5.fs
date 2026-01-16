\
\ @file uart5.fs
\ @brief Universal asynchronous receiver       transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant UART5_SR_PE                                      \ PE
$00000002 constant UART5_SR_FE                                      \ FE
$00000004 constant UART5_SR_NE                                      \ NE
$00000008 constant UART5_SR_ORE                                     \ ORE
$00000010 constant UART5_SR_IDLE                                    \ IDLE
$00000020 constant UART5_SR_RXNE                                    \ RXNE
$00000040 constant UART5_SR_TC                                      \ TC
$00000080 constant UART5_SR_TXE                                     \ TXE
$00000100 constant UART5_SR_LBD                                     \ LBD


\
\ @brief Data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000001ff constant UART5_DR_DR                                      \ DR


\
\ @brief Baud rate register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant UART5_BRR_DIV_FRACTION                           \ DIV_Fraction
$0000fff0 constant UART5_BRR_DIV_MANTISSA                           \ DIV_Mantissa


\
\ @brief Control register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant UART5_CR1_SBK                                    \ SBK
$00000002 constant UART5_CR1_RWU                                    \ RWU
$00000004 constant UART5_CR1_RE                                     \ RE
$00000008 constant UART5_CR1_TE                                     \ TE
$00000010 constant UART5_CR1_IDLEIE                                 \ IDLEIE
$00000020 constant UART5_CR1_RXNEIE                                 \ RXNEIE
$00000040 constant UART5_CR1_TCIE                                   \ TCIE
$00000080 constant UART5_CR1_TXEIE                                  \ TXEIE
$00000100 constant UART5_CR1_PEIE                                   \ PEIE
$00000200 constant UART5_CR1_PS                                     \ PS
$00000400 constant UART5_CR1_PCE                                    \ PCE
$00000800 constant UART5_CR1_WAKE                                   \ WAKE
$00001000 constant UART5_CR1_M                                      \ M
$00002000 constant UART5_CR1_UE                                     \ UE


\
\ @brief Control register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant UART5_CR2_ADD                                    \ ADD
$00000020 constant UART5_CR2_LBDL                                   \ LBDL
$00000040 constant UART5_CR2_LBDIE                                  \ LBDIE
$00003000 constant UART5_CR2_STOP                                   \ STOP
$00004000 constant UART5_CR2_LINEN                                  \ LINEN


\
\ @brief Control register 3
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant UART5_CR3_EIE                                    \ Error interrupt enable
$00000002 constant UART5_CR3_IREN                                   \ IrDA mode enable
$00000004 constant UART5_CR3_IRLP                                   \ IrDA low-power
$00000008 constant UART5_CR3_HDSEL                                  \ Half-duplex selection
$00000080 constant UART5_CR3_DMAT                                   \ DMA enable transmitter


\
\ @brief Universal asynchronous receiver transmitter
\
$40005000 constant UART5_SR       \ offset: 0x00 : Status register
$40005004 constant UART5_DR       \ offset: 0x04 : Data register
$40005008 constant UART5_BRR      \ offset: 0x08 : Baud rate register
$4000500c constant UART5_CR1      \ offset: 0x0C : Control register 1
$40005010 constant UART5_CR2      \ offset: 0x10 : Control register 2
$40005014 constant UART5_CR3      \ offset: 0x14 : Control register 3

