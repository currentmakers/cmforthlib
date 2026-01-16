\
\ @file usart2.fs
\ @brief USART2 global interrupt
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

$00000001 constant USART2_CR1_UE                                    \ USART enable
$00000004 constant USART2_CR1_RE                                    \ Receiver enable
$00000008 constant USART2_CR1_TE                                    \ Transmitter enable
$00000010 constant USART2_CR1_IDLEIE                                \ IDLE interrupt enable
$00000020 constant USART2_CR1_RXNEIE                                \ RXNE interrupt enable
$00000040 constant USART2_CR1_TCIE                                  \ Transmission complete interrupt enable
$00000080 constant USART2_CR1_TXEIE                                 \ interrupt enable
$00000100 constant USART2_CR1_PEIE                                  \ PE interrupt enable
$00000200 constant USART2_CR1_PS                                    \ Parity selection
$00000400 constant USART2_CR1_PCE                                   \ Parity control enable
$00000800 constant USART2_CR1_WAKE                                  \ Receiver wakeup method
$00001000 constant USART2_CR1_M0                                    \ Word length
$00002000 constant USART2_CR1_MME                                   \ Mute mode enable
$00004000 constant USART2_CR1_CMIE                                  \ Character match interrupt enable
$00008000 constant USART2_CR1_OVER8                                 \ Oversampling mode
$00010000 constant USART2_CR1_DEDT0                                 \ DEDT0
$00020000 constant USART2_CR1_DEDT1                                 \ DEDT1
$00040000 constant USART2_CR1_DEDT2                                 \ DEDT2
$00080000 constant USART2_CR1_DEDT3                                 \ DEDT3
$00100000 constant USART2_CR1_DEDT4                                 \ Driver Enable de-assertion time
$00200000 constant USART2_CR1_DEAT0                                 \ DEAT0
$00400000 constant USART2_CR1_DEAT1                                 \ DEAT1
$00800000 constant USART2_CR1_DEAT2                                 \ DEAT2
$01000000 constant USART2_CR1_DEAT3                                 \ DEAT3
$02000000 constant USART2_CR1_DEAT4                                 \ Driver Enable assertion time
$04000000 constant USART2_CR1_RTOIE                                 \ Receiver timeout interrupt enable
$08000000 constant USART2_CR1_EOBIE                                 \ End of Block interrupt enable
$10000000 constant USART2_CR1_M1                                    \ Word length


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000010 constant USART2_CR2_ADDM7                                 \ 7-bit Address Detection/4-bit Address Detection
$00000020 constant USART2_CR2_LBDL                                  \ LIN break detection length
$00000040 constant USART2_CR2_LBDIE                                 \ LIN break detection interrupt enable
$00000100 constant USART2_CR2_LBCL                                  \ Last bit clock pulse
$00000200 constant USART2_CR2_CPHA                                  \ Clock phase
$00000400 constant USART2_CR2_CPOL                                  \ Clock polarity
$00000800 constant USART2_CR2_CLKEN                                 \ Clock enable
$00003000 constant USART2_CR2_STOP                                  \ STOP bits
$00004000 constant USART2_CR2_LINEN                                 \ LIN mode enable
$00008000 constant USART2_CR2_SWAP                                  \ Swap TX/RX pins
$00010000 constant USART2_CR2_RXINV                                 \ RX pin active level inversion
$00020000 constant USART2_CR2_TXINV                                 \ TX pin active level inversion
$00040000 constant USART2_CR2_TAINV                                 \ Binary data inversion
$00080000 constant USART2_CR2_MSBFIRST                              \ Most significant bit first
$00100000 constant USART2_CR2_ABREN                                 \ Auto baud rate enable
$00200000 constant USART2_CR2_ABRMOD0                               \ ABRMOD0
$00400000 constant USART2_CR2_ABRMOD1                               \ Auto baud rate mode
$00800000 constant USART2_CR2_RTOEN                                 \ Receiver timeout enable
$0f000000 constant USART2_CR2_ADD0_3                                \ Address of the USART node
$f0000000 constant USART2_CR2_ADD4_7                                \ Address of the USART node


\
\ @brief Control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant USART2_CR3_EIE                                   \ Error interrupt enable
$00000002 constant USART2_CR3_IREN                                  \ Ir mode enable
$00000004 constant USART2_CR3_IRLP                                  \ Ir low-power
$00000008 constant USART2_CR3_HDSEL                                 \ Half-duplex selection
$00000010 constant USART2_CR3_NACK                                  \ Smartcard NACK enable
$00000020 constant USART2_CR3_SCEN                                  \ Smartcard mode enable
$00000040 constant USART2_CR3_DMAR                                  \ DMA enable receiver
$00000080 constant USART2_CR3_DMAT                                  \ DMA enable transmitter
$00000100 constant USART2_CR3_RTSE                                  \ RTS enable
$00000200 constant USART2_CR3_CTSE                                  \ CTS enable
$00000400 constant USART2_CR3_CTSIE                                 \ CTS interrupt enable
$00000800 constant USART2_CR3_ONEBIT                                \ One sample bit method enable
$00001000 constant USART2_CR3_OVRDIS                                \ Overrun Disable
$00002000 constant USART2_CR3_DDRE                                  \ DMA Disable on Reception Error
$00004000 constant USART2_CR3_DEM                                   \ Driver enable mode
$00008000 constant USART2_CR3_DEP                                   \ Driver enable polarity selection
$000e0000 constant USART2_CR3_SCARCNT                               \ Smartcard auto-retry count
$01000000 constant USART2_CR3_TCBGTIE                               \ Transmission complete before guard time interrupt enable


\
\ @brief Baud rate register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant USART2_BRR_BRR                                   \ USARTDIV


\
\ @brief Guard time and prescaler register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant USART2_GTPR_PSC                                  \ Prescaler value
$0000ff00 constant USART2_GTPR_GT                                   \ Guard time value


\
\ @brief Receiver timeout register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00ffffff constant USART2_RTOR_RTO                                  \ Receiver timeout value
$ff000000 constant USART2_RTOR_BLEN                                 \ Block Length


\
\ @brief Request register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant USART2_RQR_ABRRQ                                 \ Auto baud rate request
$00000002 constant USART2_RQR_SBKRQ                                 \ Send break request
$00000004 constant USART2_RQR_MMRQ                                  \ Mute mode request
$00000008 constant USART2_RQR_RXFRQ                                 \ Receive data flush request
$00000010 constant USART2_RQR_TXFRQ                                 \ Transmit data flush request


\
\ @brief Interrupt & status register
\ Address offset: 0x1C
\ Reset value: 0x000000C0
\

$00000001 constant USART2_ISR_PE                                    \ PE
$00000002 constant USART2_ISR_FE                                    \ FE
$00000004 constant USART2_ISR_NF                                    \ NF
$00000008 constant USART2_ISR_ORE                                   \ ORE
$00000010 constant USART2_ISR_IDLE                                  \ IDLE
$00000020 constant USART2_ISR_RXNE                                  \ RXNE
$00000040 constant USART2_ISR_TC                                    \ TC
$00000080 constant USART2_ISR_TXE                                   \ TXE
$00000100 constant USART2_ISR_LBDF                                  \ LBDF
$00000200 constant USART2_ISR_CTSIF                                 \ CTSIF
$00000400 constant USART2_ISR_CTS                                   \ CTS
$00000800 constant USART2_ISR_RTOF                                  \ RTOF
$00001000 constant USART2_ISR_EOBF                                  \ EOBF
$00004000 constant USART2_ISR_ABRE                                  \ ABRE
$00008000 constant USART2_ISR_ABRF                                  \ ABRF
$00010000 constant USART2_ISR_BUSY                                  \ BUSY
$00020000 constant USART2_ISR_CMF                                   \ CMF
$00040000 constant USART2_ISR_SBKF                                  \ SBKF
$00200000 constant USART2_ISR_TEACK                                 \ TEACK
$02000000 constant USART2_ISR_TCBGT                                 \ Transmission complete before guard time completion


\
\ @brief Interrupt flag clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant USART2_ICR_PECF                                  \ Parity error clear flag
$00000002 constant USART2_ICR_FECF                                  \ Framing error clear flag
$00000004 constant USART2_ICR_NCF                                   \ Noise detected clear flag
$00000008 constant USART2_ICR_ORECF                                 \ Overrun error clear flag
$00000010 constant USART2_ICR_IDLECF                                \ Idle line detected clear flag
$00000040 constant USART2_ICR_TCCF                                  \ Transmission complete clear flag
$00000080 constant USART2_ICR_TCBGTCF                               \ Transmission completed before guard time clear flag
$00000100 constant USART2_ICR_LBDCF                                 \ LIN break detection clear flag
$00000200 constant USART2_ICR_CTSCF                                 \ CTS clear flag
$00000800 constant USART2_ICR_RTOCF                                 \ Receiver timeout clear flag
$00001000 constant USART2_ICR_EOBCF                                 \ End of block clear flag
$00020000 constant USART2_ICR_CMCF                                  \ Character match clear flag


\
\ @brief Receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000001ff constant USART2_RDR_RDR                                   \ Receive data value


\
\ @brief Transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant USART2_TDR_TDR                                   \ Transmit data value


\
\ @brief USART2 global interrupt
\
$40004400 constant USART2_CR1     \ offset: 0x00 : Control register 1
$40004404 constant USART2_CR2     \ offset: 0x04 : Control register 2
$40004408 constant USART2_CR3     \ offset: 0x08 : Control register 3
$4000440c constant USART2_BRR     \ offset: 0x0C : Baud rate register
$40004410 constant USART2_GTPR    \ offset: 0x10 : Guard time and prescaler register
$40004414 constant USART2_RTOR    \ offset: 0x14 : Receiver timeout register
$40004418 constant USART2_RQR     \ offset: 0x18 : Request register
$4000441c constant USART2_ISR     \ offset: 0x1C : Interrupt & status register
$40004420 constant USART2_ICR     \ offset: 0x20 : Interrupt flag clear register
$40004424 constant USART2_RDR     \ offset: 0x24 : Receive data register
$40004428 constant USART2_TDR     \ offset: 0x28 : Transmit data register

