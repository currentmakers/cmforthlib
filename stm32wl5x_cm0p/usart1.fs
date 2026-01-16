\
\ @file usart1.fs
\ @brief Universal synchronous asynchronous receiver       transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant USART1_CR1_UE                                    \ USART enable
$00000002 constant USART1_CR1_UESM                                  \ USART enable in low-power mode
$00000004 constant USART1_CR1_RE                                    \ Receiver enable
$00000008 constant USART1_CR1_TE                                    \ Transmitter enable
$00000010 constant USART1_CR1_IDLEIE                                \ IDLE interrupt enable
$00000020 constant USART1_CR1_RXNEIE                                \ Receive data register not empty/RXFIFO not empty interrupt enable
$00000040 constant USART1_CR1_TCIE                                  \ Transmission complete interrupt enable
$00000080 constant USART1_CR1_TXEIE                                 \ Transmit data register empty/TXFIFO not full interrupt enable
$00000100 constant USART1_CR1_PEIE                                  \ PE interrupt enable
$00000200 constant USART1_CR1_PS                                    \ Parity selection
$00000400 constant USART1_CR1_PCE                                   \ Parity control enable
$00000800 constant USART1_CR1_WAKE                                  \ Receiver wakeup method
$00001000 constant USART1_CR1_M                                     \ Word length
$00002000 constant USART1_CR1_MME                                   \ Mute mode enable
$00004000 constant USART1_CR1_CMIE                                  \ Character match interrupt enable
$00008000 constant USART1_CR1_OVER8                                 \ Oversampling mode
$00010000 constant USART1_CR1_DEDT0                                 \ DEDT0
$00020000 constant USART1_CR1_DEDT1                                 \ DEDT1
$00040000 constant USART1_CR1_DEDT2                                 \ DEDT2
$00080000 constant USART1_CR1_DEDT3                                 \ DEDT3
$00100000 constant USART1_CR1_DEDT4                                 \ Driver Enable deassertion time
$00200000 constant USART1_CR1_DEAT0                                 \ DEAT0
$00400000 constant USART1_CR1_DEAT1                                 \ DEAT1
$00800000 constant USART1_CR1_DEAT2                                 \ DEAT2
$01000000 constant USART1_CR1_DEAT3                                 \ DEAT3
$02000000 constant USART1_CR1_DEAT4                                 \ Driver Enable assertion time
$04000000 constant USART1_CR1_RTOIE                                 \ Receiver timeout interrupt enable
$08000000 constant USART1_CR1_EOBIE                                 \ End of Block interrupt enable
$10000000 constant USART1_CR1_M1                                    \ Word length
$20000000 constant USART1_CR1_FIFOEN                                \ FIFO mode enable
$40000000 constant USART1_CR1_TXFEIE                                \ TXFIFO empty interrupt enable
$80000000 constant USART1_CR1_RXFFIE                                \ RXFIFO Full interrupt enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant USART1_CR2_SLVEN                                 \ Synchronous Slave mode enable
$00000008 constant USART1_CR2_DIS_NSS                               \ DIS_NSS
$00000010 constant USART1_CR2_ADDM7                                 \ 7-bit Address Detection/4-bit Address Detection
$00000020 constant USART1_CR2_LBDL                                  \ LIN break detection length
$00000040 constant USART1_CR2_LBDIE                                 \ LIN break detection interrupt enable
$00000100 constant USART1_CR2_LBCL                                  \ Last bit clock pulse
$00000200 constant USART1_CR2_CPHA                                  \ Clock phase
$00000400 constant USART1_CR2_CPOL                                  \ Clock polarity
$00000800 constant USART1_CR2_CLKEN                                 \ Clock enable
$00003000 constant USART1_CR2_STOP                                  \ stop bits
$00004000 constant USART1_CR2_LINEN                                 \ LIN mode enable
$00008000 constant USART1_CR2_SWAP                                  \ Swap TX/RX pins
$00010000 constant USART1_CR2_RXINV                                 \ RX pin active level inversion
$00020000 constant USART1_CR2_TXINV                                 \ TX pin active level inversion
$00040000 constant USART1_CR2_DATAINV                               \ Binary data inversion
$00080000 constant USART1_CR2_MSBFIRST                              \ Most significant bit first
$00100000 constant USART1_CR2_ABREN                                 \ Auto baud rate enable
$00200000 constant USART1_CR2_ABRMOD0                               \ ABRMOD0
$00400000 constant USART1_CR2_ABRMOD1                               \ Auto baud rate mode
$00800000 constant USART1_CR2_RTOEN                                 \ Receiver timeout enable
$0f000000 constant USART1_CR2_ADD3_0                                \ Address of the USART node
$f0000000 constant USART1_CR2_ADD7_4                                \ Address of the USART node


\
\ @brief control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant USART1_CR3_EIE                                   \ Error interrupt enable
$00000002 constant USART1_CR3_IREN                                  \ IrDA mode enable
$00000004 constant USART1_CR3_IRLP                                  \ IrDA low-power
$00000008 constant USART1_CR3_HDSEL                                 \ Half-duplex selection
$00000010 constant USART1_CR3_NACK                                  \ Smartcard NACK enable
$00000020 constant USART1_CR3_SCEN                                  \ Smartcard mode enable
$00000040 constant USART1_CR3_DMAR                                  \ DMA enable receiver
$00000080 constant USART1_CR3_DMAT                                  \ DMA enable transmitter
$00000100 constant USART1_CR3_RTSE                                  \ RTS enable
$00000200 constant USART1_CR3_CTSE                                  \ CTS enable
$00000400 constant USART1_CR3_CTSIE                                 \ CTS interrupt enable
$00000800 constant USART1_CR3_ONEBIT                                \ One sample bit method enable
$00001000 constant USART1_CR3_OVRDIS                                \ OVRDIS: Overrun Disable
$00002000 constant USART1_CR3_DDRE                                  \ DMA Disable on Reception Error
$00004000 constant USART1_CR3_DEM                                   \ Driver enable mode
$00008000 constant USART1_CR3_DEP                                   \ Driver enable polarity selection
$000e0000 constant USART1_CR3_SCARCNT2_0                            \ Smartcard auto-retry count
$00300000 constant USART1_CR3_WUS                                   \ Wakeup from low-power mode interrupt flag selection
$00400000 constant USART1_CR3_WUFIE                                 \ Wakeup from low-power mode interrupt enable
$00800000 constant USART1_CR3_TXFTIE                                \ TXFIFO threshold interrupt enable
$01000000 constant USART1_CR3_TCBGTIE                               \ Transmission Complete before guard time, interrupt enable
$0e000000 constant USART1_CR3_RXFTCFG                               \ Receive FIFO threshold configuration
$10000000 constant USART1_CR3_RXFTIE                                \ RXFIFO threshold interrupt enable
$e0000000 constant USART1_CR3_TXFTCFG                               \ TXFIFO threshold configuration


\
\ @brief baud rate register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant USART1_BRR_BRR                                   \ BRR


\
\ @brief guard time and prescaler register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant USART1_GTPR_PSC                                  \ Prescaler value
$0000ff00 constant USART1_GTPR_GT                                   \ Guard time value


\
\ @brief receiver timeout register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00ffffff constant USART1_RTOR_RTO                                  \ Receiver timeout value
$ff000000 constant USART1_RTOR_BLEN                                 \ Block Length


\
\ @brief request register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant USART1_RQR_ABRRQ                                 \ Auto baud rate request
$00000002 constant USART1_RQR_SBKRQ                                 \ Send break request
$00000004 constant USART1_RQR_MMRQ                                  \ Mute mode request
$00000008 constant USART1_RQR_RXFRQ                                 \ Receive data flush request
$00000010 constant USART1_RQR_TXFRQ                                 \ Transmit data flush request


\
\ @brief interrupt and status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant USART1_ISR_PE                                    \ PE
$00000002 constant USART1_ISR_FE                                    \ FE
$00000004 constant USART1_ISR_NE                                    \ NE
$00000008 constant USART1_ISR_ORE                                   \ ORE
$00000010 constant USART1_ISR_IDLE                                  \ IDLE
$00000020 constant USART1_ISR_RXNE                                  \ RXNE
$00000040 constant USART1_ISR_TC                                    \ TC
$00000080 constant USART1_ISR_TXE                                   \ TXE
$00000100 constant USART1_ISR_LBDF                                  \ LBDF
$00000200 constant USART1_ISR_CTSIF                                 \ CTSIF
$00000400 constant USART1_ISR_CTS                                   \ CTS
$00000800 constant USART1_ISR_RTOF                                  \ RTOF
$00001000 constant USART1_ISR_EOBF                                  \ EOBF
$00002000 constant USART1_ISR_UDR                                   \ UDR
$00004000 constant USART1_ISR_ABRE                                  \ ABRE
$00008000 constant USART1_ISR_ABRF                                  \ ABRF
$00010000 constant USART1_ISR_BUSY                                  \ BUSY
$00020000 constant USART1_ISR_CMF                                   \ CMF
$00040000 constant USART1_ISR_SBKF                                  \ SBKF
$00080000 constant USART1_ISR_RWU                                   \ RWU
$00100000 constant USART1_ISR_WUF                                   \ WUF
$00200000 constant USART1_ISR_TEACK                                 \ TEACK
$00400000 constant USART1_ISR_REACK                                 \ REACK
$00800000 constant USART1_ISR_TXFE                                  \ TXFE
$01000000 constant USART1_ISR_RXFF                                  \ RXFF
$02000000 constant USART1_ISR_TCBGT                                 \ TCBGT
$04000000 constant USART1_ISR_RXFT                                  \ RXFT
$08000000 constant USART1_ISR_TXFT                                  \ TXFT


\
\ @brief interrupt flag clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant USART1_ICR_PECF                                  \ Parity error clear flag
$00000002 constant USART1_ICR_FECF                                  \ Framing error clear flag
$00000004 constant USART1_ICR_NECF                                  \ Noise detected clear flag
$00000008 constant USART1_ICR_ORECF                                 \ Overrun error clear flag
$00000010 constant USART1_ICR_IDLECF                                \ Idle line detected clear flag
$00000020 constant USART1_ICR_TXFECF                                \ TXFIFO empty clear flag
$00000040 constant USART1_ICR_TCCF                                  \ Transmission complete clear flag
$00000080 constant USART1_ICR_TCBGTCF                               \ Transmission complete before Guard time clear flag
$00000100 constant USART1_ICR_LBDCF                                 \ LIN break detection clear flag
$00000200 constant USART1_ICR_CTSCF                                 \ CTS clear flag
$00000800 constant USART1_ICR_RTOCF                                 \ Receiver timeout clear flag
$00001000 constant USART1_ICR_EOBCF                                 \ End of block clear flag
$00002000 constant USART1_ICR_UDRCF                                 \ SPI slave underrun clear flag
$00020000 constant USART1_ICR_CMCF                                  \ Character match clear flag
$00100000 constant USART1_ICR_WUCF                                  \ Wakeup from low-power mode clear flag


\
\ @brief receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000001ff constant USART1_RDR_RDR                                   \ Receive data value


\
\ @brief transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant USART1_TDR_TDR                                   \ Transmit data value


\
\ @brief prescaler register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000000f constant USART1_PRESC_PRESCALER                           \ Clock prescaler


\
\ @brief Universal synchronous asynchronous receiver transmitter
\
$40013800 constant USART1_CR1     \ offset: 0x00 : control register 1
$40013804 constant USART1_CR2     \ offset: 0x04 : control register 2
$40013808 constant USART1_CR3     \ offset: 0x08 : control register 3
$4001380c constant USART1_BRR     \ offset: 0x0C : baud rate register
$40013810 constant USART1_GTPR    \ offset: 0x10 : guard time and prescaler register
$40013814 constant USART1_RTOR    \ offset: 0x14 : receiver timeout register
$40013818 constant USART1_RQR     \ offset: 0x18 : request register
$4001381c constant USART1_ISR     \ offset: 0x1C : interrupt and status register
$40013820 constant USART1_ICR     \ offset: 0x20 : interrupt flag clear register
$40013824 constant USART1_RDR     \ offset: 0x24 : receive data register
$40013828 constant USART1_TDR     \ offset: 0x28 : transmit data register
$4001382c constant USART1_PRESC   \ offset: 0x2C : prescaler register

