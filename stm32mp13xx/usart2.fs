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

$00000001 constant USART2_CR1_FIFO_ENABLED_UE                       \ USART enable
$00000002 constant USART2_CR1_FIFO_ENABLED_UESM                     \ USART enable in Stop mode
$00000004 constant USART2_CR1_FIFO_ENABLED_RE                       \ Receiver enable
$00000008 constant USART2_CR1_FIFO_ENABLED_TE                       \ Transmitter enable
$00000010 constant USART2_CR1_FIFO_ENABLED_IDLEIE                   \ IDLE interrupt enable
$00000020 constant USART2_CR1_FIFO_ENABLED_RXNEIE                   \ RXNE interrupt enable
$00000040 constant USART2_CR1_FIFO_ENABLED_TCIE                     \ Transmission complete interrupt enable
$00000080 constant USART2_CR1_FIFO_ENABLED_TXEIE                    \ interrupt enable
$00000100 constant USART2_CR1_FIFO_ENABLED_PEIE                     \ PE interrupt enable
$00000200 constant USART2_CR1_FIFO_ENABLED_PS                       \ Parity selection
$00000400 constant USART2_CR1_FIFO_ENABLED_PCE                      \ Parity control enable
$00000800 constant USART2_CR1_FIFO_ENABLED_WAKE                     \ Receiver wakeup method
$00001000 constant USART2_CR1_FIFO_ENABLED_M0                       \ Word length
$00002000 constant USART2_CR1_FIFO_ENABLED_MME                      \ Mute mode enable
$00004000 constant USART2_CR1_FIFO_ENABLED_CMIE                     \ Character match interrupt enable
$00008000 constant USART2_CR1_FIFO_ENABLED_OVER8                    \ Oversampling mode
$001f0000 constant USART2_CR1_FIFO_ENABLED_DEDT                     \ DEDT
$03e00000 constant USART2_CR1_FIFO_ENABLED_DEAT                     \ DEAT
$04000000 constant USART2_CR1_FIFO_ENABLED_RTOIE                    \ Receiver timeout interrupt enable
$08000000 constant USART2_CR1_FIFO_ENABLED_EOBIE                    \ End of Block interrupt enable
$10000000 constant USART2_CR1_FIFO_ENABLED_M1                       \ Word length
$20000000 constant USART2_CR1_FIFO_ENABLED_FIFOEN                   \ FIFO mode enable
$40000000 constant USART2_CR1_FIFO_ENABLED_TXFEIE                   \ TXFIFO empty interrupt enable
$80000000 constant USART2_CR1_FIFO_ENABLED_RXFFIE                   \ RXFIFO Full interrupt enable


\
\ @brief Control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant USART2_CR1_FIFO_DISABLED_UE                      \ USART enable
$00000002 constant USART2_CR1_FIFO_DISABLED_UESM                    \ USART enable in Stop mode
$00000004 constant USART2_CR1_FIFO_DISABLED_RE                      \ Receiver enable
$00000008 constant USART2_CR1_FIFO_DISABLED_TE                      \ Transmitter enable
$00000010 constant USART2_CR1_FIFO_DISABLED_IDLEIE                  \ IDLE interrupt enable
$00000020 constant USART2_CR1_FIFO_DISABLED_RXNEIE                  \ RXNE interrupt enable
$00000040 constant USART2_CR1_FIFO_DISABLED_TCIE                    \ Transmission complete interrupt enable
$00000080 constant USART2_CR1_FIFO_DISABLED_TXEIE                   \ interrupt enable
$00000100 constant USART2_CR1_FIFO_DISABLED_PEIE                    \ PE interrupt enable
$00000200 constant USART2_CR1_FIFO_DISABLED_PS                      \ Parity selection
$00000400 constant USART2_CR1_FIFO_DISABLED_PCE                     \ Parity control enable
$00000800 constant USART2_CR1_FIFO_DISABLED_WAKE                    \ Receiver wakeup method
$00001000 constant USART2_CR1_FIFO_DISABLED_M0                      \ Word length
$00002000 constant USART2_CR1_FIFO_DISABLED_MME                     \ Mute mode enable
$00004000 constant USART2_CR1_FIFO_DISABLED_CMIE                    \ Character match interrupt enable
$00008000 constant USART2_CR1_FIFO_DISABLED_OVER8                   \ Oversampling mode
$001f0000 constant USART2_CR1_FIFO_DISABLED_DEDT                    \ DEDT
$03e00000 constant USART2_CR1_FIFO_DISABLED_DEAT                    \ DEAT
$04000000 constant USART2_CR1_FIFO_DISABLED_RTOIE                   \ Receiver timeout interrupt enable
$08000000 constant USART2_CR1_FIFO_DISABLED_EOBIE                   \ End of Block interrupt enable
$10000000 constant USART2_CR1_FIFO_DISABLED_M1                      \ Word length
$20000000 constant USART2_CR1_FIFO_DISABLED_FIFOEN                  \ FIFO mode enable


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant USART2_CR2_SLVEN                                 \ Synchronous Slave mode enable
$00000008 constant USART2_CR2_DIS_NSS                               \ When the DSI_NSS bit is set, the NSS pin input will be ignored
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
$00600000 constant USART2_CR2_ABRMOD                                \ Auto baud rate mode
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
$00300000 constant USART2_CR3_WUS                                   \ Wakeup from Stop mode interrupt flag selection
$00400000 constant USART2_CR3_WUFIE                                 \ Wakeup from Stop mode interrupt enable
$00800000 constant USART2_CR3_TXFTIE                                \ threshold interrupt enable
$01000000 constant USART2_CR3_TCBGTIE                               \ Tr Complete before guard time, interrupt enable
$0e000000 constant USART2_CR3_RXFTCFG                               \ Receive FIFO threshold configuration
$10000000 constant USART2_CR3_RXFTIE                                \ RXFIFO threshold interrupt enable
$e0000000 constant USART2_CR3_TXFTCFG                               \ TXFIFO threshold configuration


\
\ @brief Baud rate register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant USART2_BRR_BRR_0_3                               \ BRR_0_3
$0000fff0 constant USART2_BRR_BRR_4_15                              \ BRR_4_15


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
\ @brief USART interrupt and status register
\ Address offset: 0x1C
\ Reset value: 0x000000C0
\

$00000001 constant USART2_ISR_FIFO_ENABLED_PE                       \ PE
$00000002 constant USART2_ISR_FIFO_ENABLED_FE                       \ FE
$00000004 constant USART2_ISR_FIFO_ENABLED_NF                       \ NF
$00000008 constant USART2_ISR_FIFO_ENABLED_ORE                      \ ORE
$00000010 constant USART2_ISR_FIFO_ENABLED_IDLE                     \ IDLE
$00000020 constant USART2_ISR_FIFO_ENABLED_RXNE                     \ RXNE
$00000040 constant USART2_ISR_FIFO_ENABLED_TC                       \ TC
$00000080 constant USART2_ISR_FIFO_ENABLED_TXE                      \ TXE
$00000100 constant USART2_ISR_FIFO_ENABLED_LBDF                     \ LBDF
$00000200 constant USART2_ISR_FIFO_ENABLED_CTSIF                    \ CTSIF
$00000400 constant USART2_ISR_FIFO_ENABLED_CTS                      \ CTS
$00000800 constant USART2_ISR_FIFO_ENABLED_RTOF                     \ RTOF
$00001000 constant USART2_ISR_FIFO_ENABLED_EOBF                     \ EOBF
$00002000 constant USART2_ISR_FIFO_ENABLED_UDR                      \ SPI slave underrun error flag
$00004000 constant USART2_ISR_FIFO_ENABLED_ABRE                     \ ABRE
$00008000 constant USART2_ISR_FIFO_ENABLED_ABRF                     \ ABRF
$00010000 constant USART2_ISR_FIFO_ENABLED_BUSY                     \ BUSY
$00020000 constant USART2_ISR_FIFO_ENABLED_CMF                      \ CMF
$00040000 constant USART2_ISR_FIFO_ENABLED_SBKF                     \ SBKF
$00080000 constant USART2_ISR_FIFO_ENABLED_RWU                      \ RWU
$00100000 constant USART2_ISR_FIFO_ENABLED_WUF                      \ WUF
$00200000 constant USART2_ISR_FIFO_ENABLED_TEACK                    \ TEACK
$00400000 constant USART2_ISR_FIFO_ENABLED_REACK                    \ REACK
$00800000 constant USART2_ISR_FIFO_ENABLED_TXFE                     \ TXFIFO Empty
$01000000 constant USART2_ISR_FIFO_ENABLED_RXFF                     \ RXFIFO Full
$02000000 constant USART2_ISR_FIFO_ENABLED_TCBGT                    \ Transmission complete before guard time flag
$04000000 constant USART2_ISR_FIFO_ENABLED_RXFT                     \ RXFIFO threshold flag
$08000000 constant USART2_ISR_FIFO_ENABLED_TXFT                     \ TXFIFO threshold flag


\
\ @brief USART interrupt and status register
\ Address offset: 0x1C
\ Reset value: 0x000000C0
\

$00000001 constant USART2_ISR_FIFO_DISABLED_PE                      \ PE
$00000002 constant USART2_ISR_FIFO_DISABLED_FE                      \ FE
$00000004 constant USART2_ISR_FIFO_DISABLED_NF                      \ NF
$00000008 constant USART2_ISR_FIFO_DISABLED_ORE                     \ ORE
$00000010 constant USART2_ISR_FIFO_DISABLED_IDLE                    \ IDLE
$00000020 constant USART2_ISR_FIFO_DISABLED_RXNE                    \ RXNE
$00000040 constant USART2_ISR_FIFO_DISABLED_TC                      \ TC
$00000080 constant USART2_ISR_FIFO_DISABLED_TXE                     \ TXE
$00000100 constant USART2_ISR_FIFO_DISABLED_LBDF                    \ LBDF
$00000200 constant USART2_ISR_FIFO_DISABLED_CTSIF                   \ CTSIF
$00000400 constant USART2_ISR_FIFO_DISABLED_CTS                     \ CTS
$00000800 constant USART2_ISR_FIFO_DISABLED_RTOF                    \ RTOF
$00001000 constant USART2_ISR_FIFO_DISABLED_EOBF                    \ EOBF
$00002000 constant USART2_ISR_FIFO_DISABLED_UDR                     \ SPI slave underrun error flag
$00004000 constant USART2_ISR_FIFO_DISABLED_ABRE                    \ ABRE
$00008000 constant USART2_ISR_FIFO_DISABLED_ABRF                    \ ABRF
$00010000 constant USART2_ISR_FIFO_DISABLED_BUSY                    \ BUSY
$00020000 constant USART2_ISR_FIFO_DISABLED_CMF                     \ CMF
$00040000 constant USART2_ISR_FIFO_DISABLED_SBKF                    \ SBKF
$00080000 constant USART2_ISR_FIFO_DISABLED_RWU                     \ RWU
$00100000 constant USART2_ISR_FIFO_DISABLED_WUF                     \ WUF
$00200000 constant USART2_ISR_FIFO_DISABLED_TEACK                   \ TEACK
$00400000 constant USART2_ISR_FIFO_DISABLED_REACK                   \ REACK
$02000000 constant USART2_ISR_FIFO_DISABLED_TCBGT                   \ Transmission complete before guard time flag


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
$00000020 constant USART2_ICR_TXFECF                                \ TXFIFO empty clear flag
$00000040 constant USART2_ICR_TCCF                                  \ Transmission complete clear flag
$00000080 constant USART2_ICR_TCBGTCF                               \ Transmission complete before Guard time clear flag
$00000100 constant USART2_ICR_LBDCF                                 \ LIN break detection clear flag
$00000200 constant USART2_ICR_CTSCF                                 \ CTS clear flag
$00000800 constant USART2_ICR_RTOCF                                 \ Receiver timeout clear flag
$00001000 constant USART2_ICR_EOBCF                                 \ End of block clear flag
$00002000 constant USART2_ICR_UDRCF                                 \ SPI slave underrun clear flag
$00020000 constant USART2_ICR_CMCF                                  \ Character match clear flag
$00100000 constant USART2_ICR_WUCF                                  \ Wakeup from Stop mode clear flag


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
\ @brief Prescaler register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000000f constant USART2_PRESC_PRESCALER                           \ Clock prescaler


\
\ @brief USART Hardware Configuration register 2
\ Address offset: 0x3EC
\ Reset value: 0x00000014
\

$0000000f constant USART2_HWCFGR2_CFG1                              \ CFG1
$000000f0 constant USART2_HWCFGR2_CFG2                              \ CFG2


\
\ @brief USART Hardware Configuration register 1
\ Address offset: 0x3F0
\ Reset value: 0x00000014
\

$0000000f constant USART2_HWCFGR1_CFG1                              \ CFG1
$000000f0 constant USART2_HWCFGR1_CFG2                              \ CFG2
$00000f00 constant USART2_HWCFGR1_CFG3                              \ CFG3
$0000f000 constant USART2_HWCFGR1_CFG4                              \ CFG4
$000f0000 constant USART2_HWCFGR1_CFG5                              \ CFG5
$00f00000 constant USART2_HWCFGR1_CFG6                              \ CFG6
$0f000000 constant USART2_HWCFGR1_CFG7                              \ CFG7
$f0000000 constant USART2_HWCFGR1_CFG8                              \ CFG8


\
\ @brief EXTI IP Version register
\ Address offset: 0x3F4
\ Reset value: 0x00000023
\

$0000000f constant USART2_VERR_MINREV                               \ Minor Revision number
$000000f0 constant USART2_VERR_MAJREV                               \ Major Revision number


\
\ @brief EXTI Identification register
\ Address offset: 0x3F8
\ Reset value: 0x00130003
\

$00000000 constant USART2_IPIDR_IPID                                \ IP Identification


\
\ @brief EXTI Size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant USART2_SIDR_SID                                  \ Size Identification


\
\ @brief USART2 global interrupt
\
$4c001000 constant USART2_CR1_FIFO_ENABLED  \ offset: 0x00 : Control register 1
$4c001000 constant USART2_CR1_FIFO_DISABLED  \ offset: 0x00 : Control register 1
$4c001004 constant USART2_CR2     \ offset: 0x04 : Control register 2
$4c001008 constant USART2_CR3     \ offset: 0x08 : Control register 3
$4c00100c constant USART2_BRR     \ offset: 0x0C : Baud rate register
$4c001010 constant USART2_GTPR    \ offset: 0x10 : Guard time and prescaler register
$4c001014 constant USART2_RTOR    \ offset: 0x14 : Receiver timeout register
$4c001018 constant USART2_RQR     \ offset: 0x18 : Request register
$4c00101c constant USART2_ISR_FIFO_ENABLED  \ offset: 0x1C : USART interrupt and status register
$4c00101c constant USART2_ISR_FIFO_DISABLED  \ offset: 0x1C : USART interrupt and status register
$4c001020 constant USART2_ICR     \ offset: 0x20 : Interrupt flag clear register
$4c001024 constant USART2_RDR     \ offset: 0x24 : Receive data register
$4c001028 constant USART2_TDR     \ offset: 0x28 : Transmit data register
$4c00102c constant USART2_PRESC   \ offset: 0x2C : Prescaler register
$4c0013ec constant USART2_HWCFGR2  \ offset: 0x3EC : USART Hardware Configuration register 2
$4c0013f0 constant USART2_HWCFGR1  \ offset: 0x3F0 : USART Hardware Configuration register 1
$4c0013f4 constant USART2_VERR    \ offset: 0x3F4 : EXTI IP Version register
$4c0013f8 constant USART2_IPIDR   \ offset: 0x3F8 : EXTI Identification register
$4c0013fc constant USART2_SIDR    \ offset: 0x3FC : EXTI Size ID register

