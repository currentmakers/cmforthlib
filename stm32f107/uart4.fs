\
\ @file uart4.fs
\ @brief Universal asynchronous receiver       transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief UART4 SR
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant UART4_SR_PE                                      \ Parity error
$00000002 constant UART4_SR_FE                                      \ Framing error
$00000004 constant UART4_SR_NE                                      \ Noise error flag
$00000008 constant UART4_SR_ORE                                     \ Overrun error
$00000010 constant UART4_SR_IDLE                                    \ IDLE line detected
$00000020 constant UART4_SR_RXNE                                    \ Read data register not empty
$00000040 constant UART4_SR_TC                                      \ Transmission complete
$00000080 constant UART4_SR_TXE                                     \ Transmit data register empty
$00000100 constant UART4_SR_LBD                                     \ LIN break detection flag


\
\ @brief UART4 DR
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000001ff constant UART4_DR_DR                                      \ DR


\
\ @brief UART4 BRR
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant UART4_BRR_DIV_FRACTION                           \ DIV_Fraction
$0000fff0 constant UART4_BRR_DIV_MANTISSA                           \ DIV_Mantissa


\
\ @brief UART4 CR1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant UART4_CR1_SBK                                    \ Send break
$00000002 constant UART4_CR1_RWU                                    \ Receiver wakeup
$00000004 constant UART4_CR1_RE                                     \ Receiver enable
$00000008 constant UART4_CR1_TE                                     \ Transmitter enable
$00000010 constant UART4_CR1_IDLEIE                                 \ IDLE interrupt enable
$00000020 constant UART4_CR1_RXNEIE                                 \ RXNE interrupt enable
$00000040 constant UART4_CR1_TCIE                                   \ Transmission complete interrupt enable
$00000080 constant UART4_CR1_TXEIE                                  \ TXE interrupt enable
$00000100 constant UART4_CR1_PEIE                                   \ PE interrupt enable
$00000200 constant UART4_CR1_PS                                     \ Parity selection
$00000400 constant UART4_CR1_PCE                                    \ Parity control enable
$00000800 constant UART4_CR1_WAKE                                   \ Wakeup method
$00001000 constant UART4_CR1_M                                      \ Word length
$00002000 constant UART4_CR1_UE                                     \ USART enable


\
\ @brief UART4 CR2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant UART4_CR2_ADD                                    \ Address of the USART node
$00000020 constant UART4_CR2_LBDL                                   \ lin break detection length
$00000040 constant UART4_CR2_LBDIE                                  \ LIN break detection interrupt enable
$00003000 constant UART4_CR2_STOP                                   \ STOP bits
$00004000 constant UART4_CR2_LINEN                                  \ LIN mode enable


\
\ @brief UART4 CR3
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant UART4_CR3_EIE                                    \ Error interrupt enable
$00000002 constant UART4_CR3_IREN                                   \ IrDA mode enable
$00000004 constant UART4_CR3_IRLP                                   \ IrDA low-power
$00000008 constant UART4_CR3_HDSEL                                  \ Half-duplex selection
$00000040 constant UART4_CR3_DMAR                                   \ DMA enable receiver
$00000080 constant UART4_CR3_DMAT                                   \ DMA enable transmitter


\
\ @brief Universal asynchronous receiver transmitter
\
$40004c00 constant UART4_SR       \ offset: 0x00 : UART4 SR
$40004c04 constant UART4_DR       \ offset: 0x04 : UART4 DR
$40004c08 constant UART4_BRR      \ offset: 0x08 : UART4 BRR
$40004c0c constant UART4_CR1      \ offset: 0x0C : UART4 CR1
$40004c10 constant UART4_CR2      \ offset: 0x10 : UART4 CR2
$40004c14 constant UART4_CR3      \ offset: 0x14 : UART4 CR3

