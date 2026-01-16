\
\ @file usart3.fs
\ @brief USART3 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Status register
\ Address offset: 0x00
\ Reset value: 0x000000C0
\

$00000001 constant USART3_SR_PE                                     \ Parity error
$00000002 constant USART3_SR_FE                                     \ Framing error
$00000004 constant USART3_SR_NF                                     \ Noise detected flag
$00000008 constant USART3_SR_ORE                                    \ Overrun error
$00000010 constant USART3_SR_IDLE                                   \ IDLE line detected
$00000020 constant USART3_SR_RXNE                                   \ Read data register not empty
$00000040 constant USART3_SR_TC                                     \ Transmission complete
$00000080 constant USART3_SR_TXE                                    \ Transmit data register empty
$00000100 constant USART3_SR_LBD                                    \ LIN break detection flag
$00000200 constant USART3_SR_CTS                                    \ CTS flag


\
\ @brief Data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000001ff constant USART3_DR_DR                                     \ Data value


\
\ @brief Baud rate register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant USART3_BRR_DIV_FRACTION                          \ fraction of USARTDIV
$0000fff0 constant USART3_BRR_DIV_MANTISSA                          \ mantissa of USARTDIV


\
\ @brief Control register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant USART3_CR1_SBK                                   \ Send break
$00000002 constant USART3_CR1_RWU                                   \ Receiver wakeup
$00000004 constant USART3_CR1_RE                                    \ Receiver enable
$00000008 constant USART3_CR1_TE                                    \ Transmitter enable
$00000010 constant USART3_CR1_IDLEIE                                \ IDLE interrupt enable
$00000020 constant USART3_CR1_RXNEIE                                \ RXNE interrupt enable
$00000040 constant USART3_CR1_TCIE                                  \ Transmission complete interrupt enable
$00000080 constant USART3_CR1_TXEIE                                 \ TXE interrupt enable
$00000100 constant USART3_CR1_PEIE                                  \ PE interrupt enable
$00000200 constant USART3_CR1_PS                                    \ Parity selection
$00000400 constant USART3_CR1_PCE                                   \ Parity control enable
$00000800 constant USART3_CR1_WAKE                                  \ Wakeup method
$00001000 constant USART3_CR1_M                                     \ Word length
$00002000 constant USART3_CR1_UE                                    \ USART enable
$00008000 constant USART3_CR1_OVER8                                 \ Oversampling mode


\
\ @brief Control register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant USART3_CR2_ADD                                   \ Address of the USART node
$00000020 constant USART3_CR2_LBDL                                  \ lin break detection length
$00000040 constant USART3_CR2_LBDIE                                 \ LIN break detection interrupt enable
$00000100 constant USART3_CR2_LBCL                                  \ Last bit clock pulse
$00000200 constant USART3_CR2_CPHA                                  \ Clock phase
$00000400 constant USART3_CR2_CPOL                                  \ Clock polarity
$00000800 constant USART3_CR2_CLKEN                                 \ Clock enable
$00003000 constant USART3_CR2_STOP                                  \ STOP bits
$00004000 constant USART3_CR2_LINEN                                 \ LIN mode enable


\
\ @brief Control register 3
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant USART3_CR3_EIE                                   \ Error interrupt enable
$00000002 constant USART3_CR3_IREN                                  \ IrDA mode enable
$00000004 constant USART3_CR3_IRLP                                  \ IrDA low-power
$00000008 constant USART3_CR3_HDSEL                                 \ Half-duplex selection
$00000010 constant USART3_CR3_NACK                                  \ Smartcard NACK enable
$00000020 constant USART3_CR3_SCEN                                  \ Smartcard mode enable
$00000040 constant USART3_CR3_DMAR                                  \ DMA enable receiver
$00000080 constant USART3_CR3_DMAT                                  \ DMA enable transmitter
$00000100 constant USART3_CR3_RTSE                                  \ RTS enable
$00000200 constant USART3_CR3_CTSE                                  \ CTS enable
$00000400 constant USART3_CR3_CTSIE                                 \ CTS interrupt enable
$00000800 constant USART3_CR3_ONEBIT                                \ One sample bit method enable


\
\ @brief Guard time and prescaler register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant USART3_GTPR_PSC                                  \ Prescaler value
$0000ff00 constant USART3_GTPR_GT                                   \ Guard time value


\
\ @brief USART3 global interrupt
\
$40004800 constant USART3_SR      \ offset: 0x00 : Status register
$40004804 constant USART3_DR      \ offset: 0x04 : Data register
$40004808 constant USART3_BRR     \ offset: 0x08 : Baud rate register
$4000480c constant USART3_CR1     \ offset: 0x0C : Control register 1
$40004810 constant USART3_CR2     \ offset: 0x10 : Control register 2
$40004814 constant USART3_CR3     \ offset: 0x14 : Control register 3
$40004818 constant USART3_GTPR    \ offset: 0x18 : Guard time and prescaler register

