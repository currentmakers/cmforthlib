\
\ @file usart8.fs
\ @brief Universal synchronous asynchronous receiver       transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant USART8_CR1_UE                                    \ USART enable
$00000002 constant USART8_CR1_UESM                                  \ USART enable in Stop mode
$00000004 constant USART8_CR1_RE                                    \ Receiver enable
$00000008 constant USART8_CR1_TE                                    \ Transmitter enable
$00000010 constant USART8_CR1_IDLEIE                                \ IDLE interrupt enable
$00000020 constant USART8_CR1_RXNEIE                                \ RXNE interrupt enable
$00000040 constant USART8_CR1_TCIE                                  \ Transmission complete interrupt enable
$00000080 constant USART8_CR1_TXEIE                                 \ interrupt enable
$00000100 constant USART8_CR1_PEIE                                  \ PE interrupt enable
$00000200 constant USART8_CR1_PS                                    \ Parity selection
$00000400 constant USART8_CR1_PCE                                   \ Parity control enable
$00000800 constant USART8_CR1_WAKE                                  \ Receiver wakeup method
$00001000 constant USART8_CR1_M                                     \ Word length
$00002000 constant USART8_CR1_MME                                   \ Mute mode enable
$00004000 constant USART8_CR1_CMIE                                  \ Character match interrupt enable
$00008000 constant USART8_CR1_OVER8                                 \ Oversampling mode
$001f0000 constant USART8_CR1_DEDT                                  \ Driver Enable deassertion time
$03e00000 constant USART8_CR1_DEAT                                  \ Driver Enable assertion time
$04000000 constant USART8_CR1_RTOIE                                 \ Receiver timeout interrupt enable
$08000000 constant USART8_CR1_EOBIE                                 \ End of Block interrupt enable
$10000000 constant USART8_CR1_M1                                    \ Word length


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000010 constant USART8_CR2_ADDM7                                 \ 7-bit Address Detection/4-bit Address Detection
$00000020 constant USART8_CR2_LBDL                                  \ LIN break detection length
$00000040 constant USART8_CR2_LBDIE                                 \ LIN break detection interrupt enable
$00000100 constant USART8_CR2_LBCL                                  \ Last bit clock pulse
$00000200 constant USART8_CR2_CPHA                                  \ Clock phase
$00000400 constant USART8_CR2_CPOL                                  \ Clock polarity
$00000800 constant USART8_CR2_CLKEN                                 \ Clock enable
$00003000 constant USART8_CR2_STOP                                  \ STOP bits
$00004000 constant USART8_CR2_LINEN                                 \ LIN mode enable
$00008000 constant USART8_CR2_SWAP                                  \ Swap TX/RX pins
$00010000 constant USART8_CR2_RXINV                                 \ RX pin active level inversion
$00020000 constant USART8_CR2_TXINV                                 \ TX pin active level inversion
$00040000 constant USART8_CR2_DATAINV                               \ Binary data inversion
$00080000 constant USART8_CR2_MSBFIRST                              \ Most significant bit first
$00100000 constant USART8_CR2_ABREN                                 \ Auto baud rate enable
$00600000 constant USART8_CR2_ABRMOD                                \ Auto baud rate mode
$00800000 constant USART8_CR2_RTOEN                                 \ Receiver timeout enable
$0f000000 constant USART8_CR2_ADD0                                  \ Address of the USART node
$f0000000 constant USART8_CR2_ADD4                                  \ Address of the USART node


\
\ @brief Control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant USART8_CR3_EIE                                   \ Error interrupt enable
$00000002 constant USART8_CR3_IREN                                  \ IrDA mode enable
$00000004 constant USART8_CR3_IRLP                                  \ IrDA low-power
$00000008 constant USART8_CR3_HDSEL                                 \ Half-duplex selection
$00000010 constant USART8_CR3_NACK                                  \ Smartcard NACK enable
$00000020 constant USART8_CR3_SCEN                                  \ Smartcard mode enable
$00000040 constant USART8_CR3_DMAR                                  \ DMA enable receiver
$00000080 constant USART8_CR3_DMAT                                  \ DMA enable transmitter
$00000100 constant USART8_CR3_RTSE                                  \ RTS enable
$00000200 constant USART8_CR3_CTSE                                  \ CTS enable
$00000400 constant USART8_CR3_CTSIE                                 \ CTS interrupt enable
$00000800 constant USART8_CR3_ONEBIT                                \ One sample bit method enable
$00001000 constant USART8_CR3_OVRDIS                                \ Overrun Disable
$00002000 constant USART8_CR3_DDRE                                  \ DMA Disable on Reception Error
$00004000 constant USART8_CR3_DEM                                   \ Driver enable mode
$00008000 constant USART8_CR3_DEP                                   \ Driver enable polarity selection
$000e0000 constant USART8_CR3_SCARCNT                               \ Smartcard auto-retry count
$00300000 constant USART8_CR3_WUS                                   \ Wakeup from Stop mode interrupt flag selection
$00400000 constant USART8_CR3_WUFIE                                 \ Wakeup from Stop mode interrupt enable


\
\ @brief Baud rate register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant USART8_BRR_DIV_FRACTION                          \ fraction of USARTDIV
$0000fff0 constant USART8_BRR_DIV_MANTISSA                          \ mantissa of USARTDIV


\
\ @brief Guard time and prescaler register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant USART8_GTPR_PSC                                  \ Prescaler value
$0000ff00 constant USART8_GTPR_GT                                   \ Guard time value


\
\ @brief Receiver timeout register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00ffffff constant USART8_RTOR_RTO                                  \ Receiver timeout value
$ff000000 constant USART8_RTOR_BLEN                                 \ Block Length


\
\ @brief Request register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant USART8_RQR_ABRRQ                                 \ Auto baud rate request
$00000002 constant USART8_RQR_SBKRQ                                 \ Send break request
$00000004 constant USART8_RQR_MMRQ                                  \ Mute mode request
$00000008 constant USART8_RQR_RXFRQ                                 \ Receive data flush request
$00000010 constant USART8_RQR_TXFRQ                                 \ Transmit data flush request


\
\ @brief Interrupt & status register
\ Address offset: 0x1C
\ Reset value: 0x000000C0
\

$00000001 constant USART8_ISR_PE                                    \ Parity error
$00000002 constant USART8_ISR_FE                                    \ Framing error
$00000004 constant USART8_ISR_NF                                    \ Noise detected flag
$00000008 constant USART8_ISR_ORE                                   \ Overrun error
$00000010 constant USART8_ISR_IDLE                                  \ Idle line detected
$00000020 constant USART8_ISR_RXNE                                  \ Read data register not empty
$00000040 constant USART8_ISR_TC                                    \ Transmission complete
$00000080 constant USART8_ISR_TXE                                   \ Transmit data register empty
$00000100 constant USART8_ISR_LBDF                                  \ LIN break detection flag
$00000200 constant USART8_ISR_CTSIF                                 \ CTS interrupt flag
$00000400 constant USART8_ISR_CTS                                   \ CTS flag
$00000800 constant USART8_ISR_RTOF                                  \ Receiver timeout
$00001000 constant USART8_ISR_EOBF                                  \ End of block flag
$00004000 constant USART8_ISR_ABRE                                  \ Auto baud rate error
$00008000 constant USART8_ISR_ABRF                                  \ Auto baud rate flag
$00010000 constant USART8_ISR_BUSY                                  \ Busy flag
$00020000 constant USART8_ISR_CMF                                   \ character match flag
$00040000 constant USART8_ISR_SBKF                                  \ Send break flag
$00080000 constant USART8_ISR_RWU                                   \ Receiver wakeup from Mute mode
$00100000 constant USART8_ISR_WUF                                   \ Wakeup from Stop mode flag
$00200000 constant USART8_ISR_TEACK                                 \ Transmit enable acknowledge flag
$00400000 constant USART8_ISR_REACK                                 \ Receive enable acknowledge flag


\
\ @brief Interrupt flag clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant USART8_ICR_PECF                                  \ Parity error clear flag
$00000002 constant USART8_ICR_FECF                                  \ Framing error clear flag
$00000004 constant USART8_ICR_NCF                                   \ Noise detected clear flag
$00000008 constant USART8_ICR_ORECF                                 \ Overrun error clear flag
$00000010 constant USART8_ICR_IDLECF                                \ Idle line detected clear flag
$00000040 constant USART8_ICR_TCCF                                  \ Transmission complete clear flag
$00000100 constant USART8_ICR_LBDCF                                 \ LIN break detection clear flag
$00000200 constant USART8_ICR_CTSCF                                 \ CTS clear flag
$00000800 constant USART8_ICR_RTOCF                                 \ Receiver timeout clear flag
$00001000 constant USART8_ICR_EOBCF                                 \ End of timeout clear flag
$00020000 constant USART8_ICR_CMCF                                  \ Character match clear flag
$00100000 constant USART8_ICR_WUCF                                  \ Wakeup from Stop mode clear flag


\
\ @brief Receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000001ff constant USART8_RDR_RDR                                   \ Receive data value


\
\ @brief Transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant USART8_TDR_TDR                                   \ Transmit data value


\
\ @brief Universal synchronous asynchronous receiver transmitter
\
$40011c00 constant USART8_CR1     \ offset: 0x00 : Control register 1
$40011c04 constant USART8_CR2     \ offset: 0x04 : Control register 2
$40011c08 constant USART8_CR3     \ offset: 0x08 : Control register 3
$40011c0c constant USART8_BRR     \ offset: 0x0C : Baud rate register
$40011c10 constant USART8_GTPR    \ offset: 0x10 : Guard time and prescaler register
$40011c14 constant USART8_RTOR    \ offset: 0x14 : Receiver timeout register
$40011c18 constant USART8_RQR     \ offset: 0x18 : Request register
$40011c1c constant USART8_ISR     \ offset: 0x1C : Interrupt & status register
$40011c20 constant USART8_ICR     \ offset: 0x20 : Interrupt flag clear register
$40011c24 constant USART8_RDR     \ offset: 0x24 : Receive data register
$40011c28 constant USART8_TDR     \ offset: 0x28 : Transmit data register

