\
\ @file uart8.fs
\ @brief USART2 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Status register
\ Address offset: 0x00
\ Reset value: 0x00C00000
\

$00000001 constant UART8_SR_PE                                      \ Parity error
$00000002 constant UART8_SR_FE                                      \ Framing error
$00000004 constant UART8_SR_NF                                      \ Noise detected flag
$00000008 constant UART8_SR_ORE                                     \ Overrun error
$00000010 constant UART8_SR_IDLE                                    \ IDLE line detected
$00000020 constant UART8_SR_RXNE                                    \ Read data register not empty
$00000040 constant UART8_SR_TC                                      \ Transmission complete
$00000080 constant UART8_SR_TXE                                     \ Transmit data register empty
$00000100 constant UART8_SR_LBD                                     \ LIN break detection flag
$00000200 constant UART8_SR_CTS                                     \ CTS flag


\
\ @brief Data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000001ff constant UART8_DR_DR                                      \ Data value


\
\ @brief Baud rate register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant UART8_BRR_DIV_FRACTION                           \ fraction of USARTDIV
$0000fff0 constant UART8_BRR_DIV_MANTISSA                           \ mantissa of USARTDIV


\
\ @brief Control register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant UART8_CR1_SBK                                    \ Send break
$00000002 constant UART8_CR1_RWU                                    \ Receiver wakeup
$00000004 constant UART8_CR1_RE                                     \ Receiver enable
$00000008 constant UART8_CR1_TE                                     \ Transmitter enable
$00000010 constant UART8_CR1_IDLEIE                                 \ IDLE interrupt enable
$00000020 constant UART8_CR1_RXNEIE                                 \ RXNE interrupt enable
$00000040 constant UART8_CR1_TCIE                                   \ Transmission complete interrupt enable
$00000080 constant UART8_CR1_TXEIE                                  \ TXE interrupt enable
$00000100 constant UART8_CR1_PEIE                                   \ PE interrupt enable
$00000200 constant UART8_CR1_PS                                     \ Parity selection
$00000400 constant UART8_CR1_PCE                                    \ Parity control enable
$00000800 constant UART8_CR1_WAKE                                   \ Wakeup method
$00001000 constant UART8_CR1_M                                      \ Word length
$00002000 constant UART8_CR1_UE                                     \ USART enable
$00008000 constant UART8_CR1_OVER8                                  \ Oversampling mode


\
\ @brief Control register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant UART8_CR2_ADD                                    \ Address of the USART node
$00000020 constant UART8_CR2_LBDL                                   \ lin break detection length
$00000040 constant UART8_CR2_LBDIE                                  \ LIN break detection interrupt enable
$00000100 constant UART8_CR2_LBCL                                   \ Last bit clock pulse
$00000200 constant UART8_CR2_CPHA                                   \ Clock phase
$00000400 constant UART8_CR2_CPOL                                   \ Clock polarity
$00000800 constant UART8_CR2_CLKEN                                  \ Clock enable
$00003000 constant UART8_CR2_STOP                                   \ STOP bits
$00004000 constant UART8_CR2_LINEN                                  \ LIN mode enable


\
\ @brief Control register 3
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant UART8_CR3_EIE                                    \ Error interrupt enable
$00000002 constant UART8_CR3_IREN                                   \ IrDA mode enable
$00000004 constant UART8_CR3_IRLP                                   \ IrDA low-power
$00000008 constant UART8_CR3_HDSEL                                  \ Half-duplex selection
$00000010 constant UART8_CR3_NACK                                   \ Smartcard NACK enable
$00000020 constant UART8_CR3_SCEN                                   \ Smartcard mode enable
$00000040 constant UART8_CR3_DMAR                                   \ DMA enable receiver
$00000080 constant UART8_CR3_DMAT                                   \ DMA enable transmitter
$00000100 constant UART8_CR3_RTSE                                   \ RTS enable
$00000200 constant UART8_CR3_CTSE                                   \ CTS enable
$00000400 constant UART8_CR3_CTSIE                                  \ CTS interrupt enable
$00000800 constant UART8_CR3_ONEBIT                                 \ One sample bit method enable


\
\ @brief Guard time and prescaler register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant UART8_GTPR_PSC                                   \ Prescaler value
$0000ff00 constant UART8_GTPR_GT                                    \ Guard time value


\
\ @brief USART2 global interrupt
\
$40007c00 constant UART8_SR       \ offset: 0x00 : Status register
$40007c04 constant UART8_DR       \ offset: 0x04 : Data register
$40007c08 constant UART8_BRR      \ offset: 0x08 : Baud rate register
$40007c0c constant UART8_CR1      \ offset: 0x0C : Control register 1
$40007c10 constant UART8_CR2      \ offset: 0x10 : Control register 2
$40007c14 constant UART8_CR3      \ offset: 0x14 : Control register 3
$40007c18 constant UART8_GTPR     \ offset: 0x18 : Guard time and prescaler register

