\
\ @file uart5.fs
\ @brief UART5 Global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief USART control register 1 [alternate]
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant UART5_USART_CR1_FIFO_ENABLED_UE                  \ USART enable
$00000002 constant UART5_USART_CR1_FIFO_ENABLED_UESM                \ USART enable in low-power mode
$00000004 constant UART5_USART_CR1_FIFO_ENABLED_RE                  \ Receiver enable
$00000008 constant UART5_USART_CR1_FIFO_ENABLED_TE                  \ Transmitter enable
$00000010 constant UART5_USART_CR1_FIFO_ENABLED_IDLEIE              \ IDLE interrupt enable
$00000020 constant UART5_USART_CR1_FIFO_ENABLED_RXFNEIE             \ RXFIFO not empty interrupt enable
$00000040 constant UART5_USART_CR1_FIFO_ENABLED_TCIE                \ Transmission complete interrupt enable
$00000080 constant UART5_USART_CR1_FIFO_ENABLED_TXFNFIE             \ TXFIFO not full interrupt enable
$00000100 constant UART5_USART_CR1_FIFO_ENABLED_PEIE                \ PE interrupt enable
$00000200 constant UART5_USART_CR1_FIFO_ENABLED_PS                  \ Parity selection
$00000400 constant UART5_USART_CR1_FIFO_ENABLED_PCE                 \ Parity control enable
$00000800 constant UART5_USART_CR1_FIFO_ENABLED_WAKE                \ Receiver wakeup method
$00001000 constant UART5_USART_CR1_FIFO_ENABLED_M0                  \ Word length
$00002000 constant UART5_USART_CR1_FIFO_ENABLED_MME                 \ Mute mode enable
$00004000 constant UART5_USART_CR1_FIFO_ENABLED_CMIE                \ Character match interrupt enable
$00008000 constant UART5_USART_CR1_FIFO_ENABLED_OVER8               \ Oversampling mode
$001f0000 constant UART5_USART_CR1_FIFO_ENABLED_DEDT                \ Driver Enable deassertion time
$03e00000 constant UART5_USART_CR1_FIFO_ENABLED_DEAT                \ Driver Enable assertion time
$04000000 constant UART5_USART_CR1_FIFO_ENABLED_RTOIE               \ Receiver timeout interrupt enable
$08000000 constant UART5_USART_CR1_FIFO_ENABLED_EOBIE               \ End of Block interrupt enable
$10000000 constant UART5_USART_CR1_FIFO_ENABLED_M1                  \ Word length
$20000000 constant UART5_USART_CR1_FIFO_ENABLED_FIFOEN              \ FIFO mode enable
$40000000 constant UART5_USART_CR1_FIFO_ENABLED_TXFEIE              \ TXFIFO empty interrupt enable
$80000000 constant UART5_USART_CR1_FIFO_ENABLED_RXFFIE              \ RXFIFO Full interrupt enable


\
\ @brief USART control register 1 [alternate]
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant UART5_USART_CR1_FIFO_DISABLED_UE                 \ USART enable
$00000002 constant UART5_USART_CR1_FIFO_DISABLED_UESM               \ USART enable in low-power mode
$00000004 constant UART5_USART_CR1_FIFO_DISABLED_RE                 \ Receiver enable
$00000008 constant UART5_USART_CR1_FIFO_DISABLED_TE                 \ Transmitter enable
$00000010 constant UART5_USART_CR1_FIFO_DISABLED_IDLEIE             \ IDLE interrupt enable
$00000020 constant UART5_USART_CR1_FIFO_DISABLED_RXNEIE             \ Receive data register not empty
$00000040 constant UART5_USART_CR1_FIFO_DISABLED_TCIE               \ Transmission complete interrupt enable
$00000080 constant UART5_USART_CR1_FIFO_DISABLED_TXEIE              \ Transmit data register empty
$00000100 constant UART5_USART_CR1_FIFO_DISABLED_PEIE               \ PE interrupt enable
$00000200 constant UART5_USART_CR1_FIFO_DISABLED_PS                 \ Parity selection
$00000400 constant UART5_USART_CR1_FIFO_DISABLED_PCE                \ Parity control enable
$00000800 constant UART5_USART_CR1_FIFO_DISABLED_WAKE               \ Receiver wakeup method
$00001000 constant UART5_USART_CR1_FIFO_DISABLED_M0                 \ Word length
$00002000 constant UART5_USART_CR1_FIFO_DISABLED_MME                \ Mute mode enable
$00004000 constant UART5_USART_CR1_FIFO_DISABLED_CMIE               \ Character match interrupt enable
$00008000 constant UART5_USART_CR1_FIFO_DISABLED_OVER8              \ Oversampling mode
$001f0000 constant UART5_USART_CR1_FIFO_DISABLED_DEDT               \ Driver Enable deassertion time
$03e00000 constant UART5_USART_CR1_FIFO_DISABLED_DEAT               \ Driver Enable assertion time
$04000000 constant UART5_USART_CR1_FIFO_DISABLED_RTOIE              \ Receiver timeout interrupt enable
$08000000 constant UART5_USART_CR1_FIFO_DISABLED_EOBIE              \ End of Block interrupt enable
$10000000 constant UART5_USART_CR1_FIFO_DISABLED_M1                 \ Word length
$20000000 constant UART5_USART_CR1_FIFO_DISABLED_FIFOEN             \ FIFO mode enable


\
\ @brief USART control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant UART5_USART_CR2_SLVEN                            \ Synchronous Slave mode enable
$00000008 constant UART5_USART_CR2_DIS_NSS                          \ When the DIS_NSS bit is set, the NSS pin input is ignored.
$00000010 constant UART5_USART_CR2_ADDM7                            \ 7-bit Address Detection/4-bit Address Detection
$00000020 constant UART5_USART_CR2_LBDL                             \ LIN break detection length
$00000040 constant UART5_USART_CR2_LBDIE                            \ LIN break detection interrupt enable
$00000100 constant UART5_USART_CR2_LBCL                             \ Last bit clock pulse
$00000200 constant UART5_USART_CR2_CPHA                             \ Clock phase
$00000400 constant UART5_USART_CR2_CPOL                             \ Clock polarity
$00000800 constant UART5_USART_CR2_CLKEN                            \ Clock enable
$00003000 constant UART5_USART_CR2_STOP                             \ stop bits
$00004000 constant UART5_USART_CR2_LINEN                            \ LIN mode enable
$00008000 constant UART5_USART_CR2_SWAP                             \ Swap TX/RX pins
$00010000 constant UART5_USART_CR2_RXINV                            \ RX pin active level inversion
$00020000 constant UART5_USART_CR2_TXINV                            \ TX pin active level inversion
$00040000 constant UART5_USART_CR2_DATAINV                          \ Binary data inversion
$00080000 constant UART5_USART_CR2_MSBFIRST                         \ Most significant bit first
$00100000 constant UART5_USART_CR2_ABREN                            \ Auto baud rate enable
$00600000 constant UART5_USART_CR2_ABRMOD                           \ Auto baud rate mode
$00800000 constant UART5_USART_CR2_RTOEN                            \ Receiver timeout enable
$ff000000 constant UART5_USART_CR2_ADD                              \ Address of the USART node


\
\ @brief USART control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant UART5_USART_CR3_EIE                              \ Error interrupt enable
$00000002 constant UART5_USART_CR3_IREN                             \ IrDA mode enable
$00000004 constant UART5_USART_CR3_IRLP                             \ IrDA low-power
$00000008 constant UART5_USART_CR3_HDSEL                            \ Half-duplex selection
$00000010 constant UART5_USART_CR3_NACK                             \ Smartcard NACK enable
$00000020 constant UART5_USART_CR3_SCEN                             \ Smartcard mode enable
$00000040 constant UART5_USART_CR3_DMAR                             \ DMA enable receiver
$00000080 constant UART5_USART_CR3_DMAT                             \ DMA enable transmitter
$00000100 constant UART5_USART_CR3_RTSE                             \ RTS enable
$00000200 constant UART5_USART_CR3_CTSE                             \ CTS enable
$00000400 constant UART5_USART_CR3_CTSIE                            \ CTS interrupt enable
$00000800 constant UART5_USART_CR3_ONEBIT                           \ One sample bit method enable
$00001000 constant UART5_USART_CR3_OVRDIS                           \ Overrun Disable
$00002000 constant UART5_USART_CR3_DDRE                             \ DMA Disable on Reception Error
$00004000 constant UART5_USART_CR3_DEM                              \ Driver enable mode
$00008000 constant UART5_USART_CR3_DEP                              \ Driver enable polarity selection
$000e0000 constant UART5_USART_CR3_SCARCNT                          \ Smartcard auto-retry count
$00100000 constant UART5_USART_CR3_WUS0                             \ Wakeup from low-power mode interrupt flag selection
$00200000 constant UART5_USART_CR3_WUS1                             \ Wakeup from low-power mode interrupt flag selection
$00400000 constant UART5_USART_CR3_WUFIE                            \ Wakeup from low-power mode interrupt enable
$00800000 constant UART5_USART_CR3_TXFTIE                           \ TXFIFO threshold interrupt enable
$01000000 constant UART5_USART_CR3_TCBGTIE                          \ Transmission Complete before guard time, interrupt enable
$0e000000 constant UART5_USART_CR3_RXFTCFG                          \ Receive FIFO threshold configuration
$10000000 constant UART5_USART_CR3_RXFTIE                           \ RXFIFO threshold interrupt enable
$e0000000 constant UART5_USART_CR3_TXFTCFG                          \ TXFIFO threshold configuration


\
\ @brief USART baud rate register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant UART5_USART_BRR_BRR                              \ USART baud rate


\
\ @brief USART guard time and prescaler register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant UART5_USART_GTPR_PSC                             \ Prescaler value
$0000ff00 constant UART5_USART_GTPR_GT                              \ Guard time value


\
\ @brief USART receiver timeout register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00ffffff constant UART5_USART_RTOR_RTO                             \ Receiver timeout value
$ff000000 constant UART5_USART_RTOR_BLEN                            \ Block Length


\
\ @brief USART request register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant UART5_USART_RQR_ABRRQ                            \ Auto baud rate request
$00000002 constant UART5_USART_RQR_SBKRQ                            \ Send break request
$00000004 constant UART5_USART_RQR_MMRQ                             \ Mute mode request
$00000008 constant UART5_USART_RQR_RXFRQ                            \ Receive data flush request
$00000010 constant UART5_USART_RQR_TXFRQ                            \ Transmit data flush request


\
\ @brief USART interrupt and status register [alternate]
\ Address offset: 0x1C
\ Reset value: 0x000000C0
\

$00000001 constant UART5_USART_ISR_FIFO_ENABLED_PE                  \ Parity error
$00000002 constant UART5_USART_ISR_FIFO_ENABLED_FE                  \ Framing error
$00000004 constant UART5_USART_ISR_FIFO_ENABLED_NE                  \ Noise detection flag
$00000008 constant UART5_USART_ISR_FIFO_ENABLED_ORE                 \ Overrun error
$00000010 constant UART5_USART_ISR_FIFO_ENABLED_IDLE                \ Idle line detected
$00000020 constant UART5_USART_ISR_FIFO_ENABLED_RXFNE               \ RXFIFO not empty
$00000040 constant UART5_USART_ISR_FIFO_ENABLED_TC                  \ Transmission complete
$00000080 constant UART5_USART_ISR_FIFO_ENABLED_TXFNF               \ TXFIFO not full
$00000100 constant UART5_USART_ISR_FIFO_ENABLED_LBDF                \ LIN break detection flag
$00000200 constant UART5_USART_ISR_FIFO_ENABLED_CTSIF               \ CTS interrupt flag
$00000400 constant UART5_USART_ISR_FIFO_ENABLED_CTS                 \ CTS flag
$00000800 constant UART5_USART_ISR_FIFO_ENABLED_RTOF                \ Receiver timeout
$00001000 constant UART5_USART_ISR_FIFO_ENABLED_EOBF                \ End of block flag
$00002000 constant UART5_USART_ISR_FIFO_ENABLED_UDR                 \ SPI slave underrun error flag
$00004000 constant UART5_USART_ISR_FIFO_ENABLED_ABRE                \ Auto baud rate error
$00008000 constant UART5_USART_ISR_FIFO_ENABLED_ABRF                \ Auto baud rate flag
$00010000 constant UART5_USART_ISR_FIFO_ENABLED_BUSY                \ Busy flag
$00020000 constant UART5_USART_ISR_FIFO_ENABLED_CMF                 \ Character match flag
$00040000 constant UART5_USART_ISR_FIFO_ENABLED_SBKF                \ Send break flag
$00080000 constant UART5_USART_ISR_FIFO_ENABLED_RWU                 \ Receiver wakeup from Mute mode
$00100000 constant UART5_USART_ISR_FIFO_ENABLED_WUF                 \ Wakeup from low-power mode flag
$00200000 constant UART5_USART_ISR_FIFO_ENABLED_TEACK               \ Transmit enable acknowledge flag
$00400000 constant UART5_USART_ISR_FIFO_ENABLED_REACK               \ Receive enable acknowledge flag
$00800000 constant UART5_USART_ISR_FIFO_ENABLED_TXFE                \ TXFIFO Empty
$01000000 constant UART5_USART_ISR_FIFO_ENABLED_RXFF                \ RXFIFO Full
$02000000 constant UART5_USART_ISR_FIFO_ENABLED_TCBGT               \ Transmission complete before guard time flag
$04000000 constant UART5_USART_ISR_FIFO_ENABLED_RXFT                \ RXFIFO threshold flag
$08000000 constant UART5_USART_ISR_FIFO_ENABLED_TXFT                \ TXFIFO threshold flag


\
\ @brief USART interrupt and status register [alternate]
\ Address offset: 0x1C
\ Reset value: 0x000000C0
\

$00000001 constant UART5_USART_ISR_FIFO_DISABLED_PE                 \ Parity error
$00000002 constant UART5_USART_ISR_FIFO_DISABLED_FE                 \ Framing error
$00000004 constant UART5_USART_ISR_FIFO_DISABLED_NE                 \ Noise detection flag
$00000008 constant UART5_USART_ISR_FIFO_DISABLED_ORE                \ Overrun error
$00000010 constant UART5_USART_ISR_FIFO_DISABLED_IDLE               \ Idle line detected
$00000020 constant UART5_USART_ISR_FIFO_DISABLED_RXNE               \ Read data register not empty
$00000040 constant UART5_USART_ISR_FIFO_DISABLED_TC                 \ Transmission complete
$00000080 constant UART5_USART_ISR_FIFO_DISABLED_TXE                \ Transmit data register empty
$00000100 constant UART5_USART_ISR_FIFO_DISABLED_LBDF               \ LIN break detection flag
$00000200 constant UART5_USART_ISR_FIFO_DISABLED_CTSIF              \ CTS interrupt flag
$00000400 constant UART5_USART_ISR_FIFO_DISABLED_CTS                \ CTS flag
$00000800 constant UART5_USART_ISR_FIFO_DISABLED_RTOF               \ Receiver timeout
$00001000 constant UART5_USART_ISR_FIFO_DISABLED_EOBF               \ End of block flag
$00002000 constant UART5_USART_ISR_FIFO_DISABLED_UDR                \ SPI slave underrun error flag
$00004000 constant UART5_USART_ISR_FIFO_DISABLED_ABRE               \ Auto baud rate error
$00008000 constant UART5_USART_ISR_FIFO_DISABLED_ABRF               \ Auto baud rate flag
$00010000 constant UART5_USART_ISR_FIFO_DISABLED_BUSY               \ Busy flag
$00020000 constant UART5_USART_ISR_FIFO_DISABLED_CMF                \ Character match flag
$00040000 constant UART5_USART_ISR_FIFO_DISABLED_SBKF               \ Send break flag
$00080000 constant UART5_USART_ISR_FIFO_DISABLED_RWU                \ Receiver wakeup from Mute mode
$00100000 constant UART5_USART_ISR_FIFO_DISABLED_WUF                \ Wakeup from low-power mode flag
$00200000 constant UART5_USART_ISR_FIFO_DISABLED_TEACK              \ Transmit enable acknowledge flag
$00400000 constant UART5_USART_ISR_FIFO_DISABLED_REACK              \ Receive enable acknowledge flag
$02000000 constant UART5_USART_ISR_FIFO_DISABLED_TCBGT              \ Transmission complete before guard time flag


\
\ @brief USART interrupt flag clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant UART5_USART_ICR_PECF                             \ Parity error clear flag
$00000002 constant UART5_USART_ICR_FECF                             \ Framing error clear flag
$00000004 constant UART5_USART_ICR_NECF                             \ Noise detected clear flag
$00000008 constant UART5_USART_ICR_ORECF                            \ Overrun error clear flag
$00000010 constant UART5_USART_ICR_IDLECF                           \ Idle line detected clear flag
$00000020 constant UART5_USART_ICR_TXFECF                           \ TXFIFO empty clear flag
$00000040 constant UART5_USART_ICR_TCCF                             \ Transmission complete clear flag
$00000080 constant UART5_USART_ICR_TCBGTCF                          \ Transmission complete before Guard time clear flag
$00000100 constant UART5_USART_ICR_LBDCF                            \ LIN break detection clear flag
$00000200 constant UART5_USART_ICR_CTSCF                            \ CTS clear flag
$00000800 constant UART5_USART_ICR_RTOCF                            \ Receiver timeout clear flag
$00001000 constant UART5_USART_ICR_EOBCF                            \ End of block clear flag
$00002000 constant UART5_USART_ICR_UDRCF                            \ SPI slave underrun clear flag
$00020000 constant UART5_USART_ICR_CMCF                             \ Character match clear flag
$00100000 constant UART5_USART_ICR_WUCF                             \ Wakeup from low-power mode clear flag


\
\ @brief USART receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000001ff constant UART5_USART_RDR_RDR                              \ Receive data value


\
\ @brief USART transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant UART5_USART_TDR_TDR                              \ Transmit data value


\
\ @brief USART prescaler register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000000f constant UART5_USART_PRESC_PRESCALER                      \ Clock prescaler


\
\ @brief UART5 Global interrupt
\
$40005000 constant UART5_USART_CR1_FIFO_ENABLED  \ offset: 0x00 : USART control register 1 [alternate]
$40005000 constant UART5_USART_CR1_FIFO_DISABLED  \ offset: 0x00 : USART control register 1 [alternate]
$40005004 constant UART5_USART_CR2  \ offset: 0x04 : USART control register 2
$40005008 constant UART5_USART_CR3  \ offset: 0x08 : USART control register 3
$4000500c constant UART5_USART_BRR  \ offset: 0x0C : USART baud rate register
$40005010 constant UART5_USART_GTPR  \ offset: 0x10 : USART guard time and prescaler register
$40005014 constant UART5_USART_RTOR  \ offset: 0x14 : USART receiver timeout register
$40005018 constant UART5_USART_RQR  \ offset: 0x18 : USART request register
$4000501c constant UART5_USART_ISR_FIFO_ENABLED  \ offset: 0x1C : USART interrupt and status register [alternate]
$4000501c constant UART5_USART_ISR_FIFO_DISABLED  \ offset: 0x1C : USART interrupt and status register [alternate]
$40005020 constant UART5_USART_ICR  \ offset: 0x20 : USART interrupt flag clear register
$40005024 constant UART5_USART_RDR  \ offset: 0x24 : USART receive data register
$40005028 constant UART5_USART_TDR  \ offset: 0x28 : USART transmit data register
$4000502c constant UART5_USART_PRESC  \ offset: 0x2C : USART prescaler register

