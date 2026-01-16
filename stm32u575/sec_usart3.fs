\
\ @file sec_usart3.fs
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

$00000001 constant SEC_USART3_CR1_ENABLED_UE                        \ USART enable
$00000002 constant SEC_USART3_CR1_ENABLED_UESM                      \ USART enable in Stop mode
$00000004 constant SEC_USART3_CR1_ENABLED_RE                        \ Receiver enable
$00000008 constant SEC_USART3_CR1_ENABLED_TE                        \ Transmitter enable
$00000010 constant SEC_USART3_CR1_ENABLED_IDLEIE                    \ IDLE interrupt enable
$00000020 constant SEC_USART3_CR1_ENABLED_RXFNEIE                   \ RXFIFO not empty interrupt enable
$00000040 constant SEC_USART3_CR1_ENABLED_TCIE                      \ Transmission complete interrupt enable
$00000080 constant SEC_USART3_CR1_ENABLED_TXFNFIE                   \ TXFIFO not full interrupt enable
$00000100 constant SEC_USART3_CR1_ENABLED_PEIE                      \ PE interrupt enable
$00000200 constant SEC_USART3_CR1_ENABLED_PS                        \ Parity selection
$00000400 constant SEC_USART3_CR1_ENABLED_PCE                       \ Parity control enable
$00000800 constant SEC_USART3_CR1_ENABLED_WAKE                      \ Receiver wakeup method
$00001000 constant SEC_USART3_CR1_ENABLED_M0                        \ Word length
$00002000 constant SEC_USART3_CR1_ENABLED_MME                       \ Mute mode enable
$00004000 constant SEC_USART3_CR1_ENABLED_CMIE                      \ Character match interrupt enable
$00008000 constant SEC_USART3_CR1_ENABLED_OVER8                     \ Oversampling mode
$001f0000 constant SEC_USART3_CR1_ENABLED_DEDT                      \ DEDT
$03e00000 constant SEC_USART3_CR1_ENABLED_DEAT                      \ DEAT
$04000000 constant SEC_USART3_CR1_ENABLED_RTOIE                     \ Receiver timeout interrupt
$08000000 constant SEC_USART3_CR1_ENABLED_EOBIE                     \ End of Block interruptenable
$10000000 constant SEC_USART3_CR1_ENABLED_M1                        \ Word length
$20000000 constant SEC_USART3_CR1_ENABLED_FIFOEN                    \ FIFOEN
$40000000 constant SEC_USART3_CR1_ENABLED_TXFEIE                    \ TXFEIE
$80000000 constant SEC_USART3_CR1_ENABLED_RXFFIE                    \ RXFFIE


\
\ @brief Control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_USART3_CR1_DISABLED_UE                       \ USART enable
$00000002 constant SEC_USART3_CR1_DISABLED_UESM                     \ USART enable in Stop mode
$00000004 constant SEC_USART3_CR1_DISABLED_RE                       \ Receiver enable
$00000008 constant SEC_USART3_CR1_DISABLED_TE                       \ Transmitter enable
$00000010 constant SEC_USART3_CR1_DISABLED_IDLEIE                   \ IDLE interrupt enable
$00000020 constant SEC_USART3_CR1_DISABLED_RXFNEIE                  \ RXFIFO not empty interrupt enable
$00000040 constant SEC_USART3_CR1_DISABLED_TCIE                     \ Transmission complete interrupt enable
$00000080 constant SEC_USART3_CR1_DISABLED_TXFNFIE                  \ TXFIFO not full interrupt enable
$00000100 constant SEC_USART3_CR1_DISABLED_PEIE                     \ PE interrupt enable
$00000200 constant SEC_USART3_CR1_DISABLED_PS                       \ Parity selection
$00000400 constant SEC_USART3_CR1_DISABLED_PCE                      \ Parity control enable
$00000800 constant SEC_USART3_CR1_DISABLED_WAKE                     \ Receiver wakeup method
$00001000 constant SEC_USART3_CR1_DISABLED_M0                       \ Word length
$00002000 constant SEC_USART3_CR1_DISABLED_MME                      \ Mute mode enable
$00004000 constant SEC_USART3_CR1_DISABLED_CMIE                     \ Character match interrupt enable
$00008000 constant SEC_USART3_CR1_DISABLED_OVER8                    \ Oversampling mode
$001f0000 constant SEC_USART3_CR1_DISABLED_DEDT                     \ DEDT
$03e00000 constant SEC_USART3_CR1_DISABLED_DEAT                     \ DEAT
$04000000 constant SEC_USART3_CR1_DISABLED_RTOIE                    \ Receiver timeout interrupt enable
$08000000 constant SEC_USART3_CR1_DISABLED_EOBIE                    \ End of Block interrupt enable
$10000000 constant SEC_USART3_CR1_DISABLED_M1                       \ Word length
$20000000 constant SEC_USART3_CR1_DISABLED_FIFOEN                   \ FIFOEN


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_USART3_CR2_SLVEN                             \ SLVEN
$00000008 constant SEC_USART3_CR2_DIS_NSS                           \ DIS_NSS
$00000010 constant SEC_USART3_CR2_ADDM7                             \ 7-bit Address Detection/4-bit Address Detection
$00000020 constant SEC_USART3_CR2_LBDL                              \ LIN break detection length
$00000040 constant SEC_USART3_CR2_LBDIE                             \ LIN break detection interrupt enable
$00000100 constant SEC_USART3_CR2_LBCL                              \ Last bit clock pulse
$00000200 constant SEC_USART3_CR2_CPHA                              \ Clock phase
$00000400 constant SEC_USART3_CR2_CPOL                              \ Clock polarity
$00000800 constant SEC_USART3_CR2_CLKEN                             \ Clock enable
$00003000 constant SEC_USART3_CR2_STOP                              \ STOP bits
$00004000 constant SEC_USART3_CR2_LINEN                             \ LIN mode enable
$00008000 constant SEC_USART3_CR2_SWAP                              \ Swap TX/RX pins
$00010000 constant SEC_USART3_CR2_RXINV                             \ RX pin active level inversion
$00020000 constant SEC_USART3_CR2_TXINV                             \ TX pin active level inversion
$00040000 constant SEC_USART3_CR2_DATAINV                           \ Binary data inversion
$00080000 constant SEC_USART3_CR2_MSBFIRST                          \ Most significant bit first
$00100000 constant SEC_USART3_CR2_ABREN                             \ Auto baud rate enable
$00600000 constant SEC_USART3_CR2_ABRMOD                            \ Auto baud rate mode
$00800000 constant SEC_USART3_CR2_RTOEN                             \ Receiver timeout enable
$ff000000 constant SEC_USART3_CR2_ADD                               \ Address of the USART node


\
\ @brief Control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_USART3_CR3_EIE                               \ Error interrupt enable
$00000002 constant SEC_USART3_CR3_IREN                              \ Ir mode enable
$00000004 constant SEC_USART3_CR3_IRLP                              \ Ir low-power
$00000008 constant SEC_USART3_CR3_HDSEL                             \ Half-duplex selection
$00000010 constant SEC_USART3_CR3_NACK                              \ Smartcard NACK enable
$00000020 constant SEC_USART3_CR3_SCEN                              \ Smartcard mode enable
$00000040 constant SEC_USART3_CR3_DMAR                              \ DMA enable receiver
$00000080 constant SEC_USART3_CR3_DMAT                              \ DMA enable transmitter
$00000100 constant SEC_USART3_CR3_RTSE                              \ RTS enable
$00000200 constant SEC_USART3_CR3_CTSE                              \ CTS enable
$00000400 constant SEC_USART3_CR3_CTSIE                             \ CTS interrupt enable
$00000800 constant SEC_USART3_CR3_ONEBIT                            \ One sample bit method enable
$00001000 constant SEC_USART3_CR3_OVRDIS                            \ Overrun Disable
$00002000 constant SEC_USART3_CR3_DDRE                              \ DMA Disable on Reception Error
$00004000 constant SEC_USART3_CR3_DEM                               \ Driver enable mode
$00008000 constant SEC_USART3_CR3_DEP                               \ Driver enable polarity selection
$000e0000 constant SEC_USART3_CR3_SCARCNT                           \ Smartcard auto-retry count
$00800000 constant SEC_USART3_CR3_TXFTIE                            \ TXFTIE
$01000000 constant SEC_USART3_CR3_TCBGTIE                           \ TCBGTIE
$0e000000 constant SEC_USART3_CR3_RXFTCFG                           \ RXFTCFG
$10000000 constant SEC_USART3_CR3_RXFTIE                            \ RXFTIE
$e0000000 constant SEC_USART3_CR3_TXFTCFG                           \ TXFTCFG


\
\ @brief Baud rate register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_USART3_BRR_BRR                               \ BRR


\
\ @brief Guard time and prescaler register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant SEC_USART3_GTPR_PSC                              \ Prescaler value
$0000ff00 constant SEC_USART3_GTPR_GT                               \ Guard time value


\
\ @brief Receiver timeout register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00ffffff constant SEC_USART3_RTOR_RTO                              \ Receiver timeout value
$ff000000 constant SEC_USART3_RTOR_BLEN                             \ Block Length


\
\ @brief Request register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_USART3_RQR_ABRRQ                             \ Auto baud rate request
$00000002 constant SEC_USART3_RQR_SBKRQ                             \ Send break request
$00000004 constant SEC_USART3_RQR_MMRQ                              \ Mute mode request
$00000008 constant SEC_USART3_RQR_RXFRQ                             \ Receive data flush request
$00000010 constant SEC_USART3_RQR_TXFRQ                             \ Transmit data flush request


\
\ @brief Interrupt & status register
\ Address offset: 0x1C
\ Reset value: 0x028000C0
\

$00000001 constant SEC_USART3_ISR_ENABLED_PE                        \ PE
$00000002 constant SEC_USART3_ISR_ENABLED_FE                        \ FE
$00000004 constant SEC_USART3_ISR_ENABLED_NE                        \ NE
$00000008 constant SEC_USART3_ISR_ENABLED_ORE                       \ ORE
$00000010 constant SEC_USART3_ISR_ENABLED_IDLE                      \ IDLE
$00000020 constant SEC_USART3_ISR_ENABLED_RXFNE                     \ RXFNE
$00000040 constant SEC_USART3_ISR_ENABLED_TC                        \ TC
$00000080 constant SEC_USART3_ISR_ENABLED_TXFNF                     \ TXFNF
$00000100 constant SEC_USART3_ISR_ENABLED_LBDF                      \ LBDF
$00000200 constant SEC_USART3_ISR_ENABLED_CTSIF                     \ CTSIF
$00000400 constant SEC_USART3_ISR_ENABLED_CTS                       \ CTS
$00000800 constant SEC_USART3_ISR_ENABLED_RTOF                      \ RTOF
$00001000 constant SEC_USART3_ISR_ENABLED_EOBF                      \ EOBF
$00004000 constant SEC_USART3_ISR_ENABLED_ABRE                      \ ABRE
$00008000 constant SEC_USART3_ISR_ENABLED_ABRF                      \ ABRF
$00010000 constant SEC_USART3_ISR_ENABLED_BUSY                      \ BUSY
$00020000 constant SEC_USART3_ISR_ENABLED_CMF                       \ CMF
$00040000 constant SEC_USART3_ISR_ENABLED_SBKF                      \ SBKF
$00080000 constant SEC_USART3_ISR_ENABLED_RWU                       \ RWU
$00200000 constant SEC_USART3_ISR_ENABLED_TEACK                     \ TEACK
$00400000 constant SEC_USART3_ISR_ENABLED_REACK                     \ REACK
$00800000 constant SEC_USART3_ISR_ENABLED_TXFE                      \ TXFE
$01000000 constant SEC_USART3_ISR_ENABLED_RXFF                      \ RXFF
$02000000 constant SEC_USART3_ISR_ENABLED_TCBGT                     \ TCBGT
$04000000 constant SEC_USART3_ISR_ENABLED_RXFT                      \ RXFT
$08000000 constant SEC_USART3_ISR_ENABLED_TXFT                      \ TXFT


\
\ @brief Interrupt & status register
\ Address offset: 0x1C
\ Reset value: 0x000000C0
\

$00000001 constant SEC_USART3_ISR_DISABLED_PE                       \ PE
$00000002 constant SEC_USART3_ISR_DISABLED_FE                       \ FE
$00000004 constant SEC_USART3_ISR_DISABLED_NE                       \ NE
$00000008 constant SEC_USART3_ISR_DISABLED_ORE                      \ ORE
$00000010 constant SEC_USART3_ISR_DISABLED_IDLE                     \ IDLE
$00000020 constant SEC_USART3_ISR_DISABLED_RXFNE                    \ RXFNE
$00000040 constant SEC_USART3_ISR_DISABLED_TC                       \ TC
$00000080 constant SEC_USART3_ISR_DISABLED_TXFNF                    \ TXFNF
$00000100 constant SEC_USART3_ISR_DISABLED_LBDF                     \ LBDF
$00000200 constant SEC_USART3_ISR_DISABLED_CTSIF                    \ CTSIF
$00000400 constant SEC_USART3_ISR_DISABLED_CTS                      \ CTS
$00000800 constant SEC_USART3_ISR_DISABLED_RTOF                     \ RTOF
$00001000 constant SEC_USART3_ISR_DISABLED_EOBF                     \ EOBF
$00002000 constant SEC_USART3_ISR_DISABLED_UDR                      \ UDR
$00004000 constant SEC_USART3_ISR_DISABLED_ABRE                     \ ABRE
$00008000 constant SEC_USART3_ISR_DISABLED_ABRF                     \ ABRF
$00010000 constant SEC_USART3_ISR_DISABLED_BUSY                     \ BUSY
$00020000 constant SEC_USART3_ISR_DISABLED_CMF                      \ CMF
$00040000 constant SEC_USART3_ISR_DISABLED_SBKF                     \ SBKF
$00080000 constant SEC_USART3_ISR_DISABLED_RWU                      \ RWU
$00200000 constant SEC_USART3_ISR_DISABLED_TEACK                    \ TEACK
$00400000 constant SEC_USART3_ISR_DISABLED_REACK                    \ REACK
$02000000 constant SEC_USART3_ISR_DISABLED_TCBGT                    \ TCBGT


\
\ @brief Interrupt flag clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_USART3_ICR_PECF                              \ Parity error clear flag
$00000002 constant SEC_USART3_ICR_FECF                              \ Framing error clear flag
$00000004 constant SEC_USART3_ICR_NECF                              \ Noise detected clear flag
$00000008 constant SEC_USART3_ICR_ORECF                             \ Overrun error clear flag
$00000010 constant SEC_USART3_ICR_IDLECF                            \ Idle line detected clear flag
$00000020 constant SEC_USART3_ICR_TXFECF                            \ TXFECF
$00000040 constant SEC_USART3_ICR_TCCF                              \ Transmission complete clear flag
$00000080 constant SEC_USART3_ICR_TCBGTCF                           \ TCBGTCF
$00000100 constant SEC_USART3_ICR_LBDCF                             \ LIN break detection clear flag
$00000200 constant SEC_USART3_ICR_CTSCF                             \ CTS clear flag
$00000800 constant SEC_USART3_ICR_RTOCF                             \ Receiver timeout clear flag
$00001000 constant SEC_USART3_ICR_EOBCF                             \ End of block clear flag
$00002000 constant SEC_USART3_ICR_UDRCF                             \ UDRCF
$00020000 constant SEC_USART3_ICR_CMCF                              \ Character match clear flag


\
\ @brief Receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000001ff constant SEC_USART3_RDR_RDR                               \ Receive data value


\
\ @brief Transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant SEC_USART3_TDR_TDR                               \ Transmit data value


\
\ @brief PRESC
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000000f constant SEC_USART3_PRESC_PRESCALER                       \ PRESCALER


\
\ @brief AUTOCR
\ Address offset: 0x30
\ Reset value: 0x80000000
\

$0000ffff constant SEC_USART3_AUTOCR_TDN                            \ TDN
$00010000 constant SEC_USART3_AUTOCR_TRIGPOL                        \ TRIPOL
$00020000 constant SEC_USART3_AUTOCR_TRIGEN                         \ TRIGEN
$00040000 constant SEC_USART3_AUTOCR_IDLEDIS                        \ IDLEDIS
$00780000 constant SEC_USART3_AUTOCR_TRIGSEL                        \ TRIGSEL
$80000000 constant SEC_USART3_AUTOCR_TECLREN                        \ TECLREN


\
\ @brief Universal synchronous asynchronous receiver transmitter
\
$50004800 constant SEC_USART3_CR1_ENABLED  \ offset: 0x00 : Control register 1
$50004800 constant SEC_USART3_CR1_DISABLED  \ offset: 0x00 : Control register 1
$50004804 constant SEC_USART3_CR2  \ offset: 0x04 : Control register 2
$50004808 constant SEC_USART3_CR3  \ offset: 0x08 : Control register 3
$5000480c constant SEC_USART3_BRR  \ offset: 0x0C : Baud rate register
$50004810 constant SEC_USART3_GTPR  \ offset: 0x10 : Guard time and prescaler register
$50004814 constant SEC_USART3_RTOR  \ offset: 0x14 : Receiver timeout register
$50004818 constant SEC_USART3_RQR  \ offset: 0x18 : Request register
$5000481c constant SEC_USART3_ISR_ENABLED  \ offset: 0x1C : Interrupt & status register
$5000481c constant SEC_USART3_ISR_DISABLED  \ offset: 0x1C : Interrupt & status register
$50004820 constant SEC_USART3_ICR  \ offset: 0x20 : Interrupt flag clear register
$50004824 constant SEC_USART3_RDR  \ offset: 0x24 : Receive data register
$50004828 constant SEC_USART3_TDR  \ offset: 0x28 : Transmit data register
$5000482c constant SEC_USART3_PRESC  \ offset: 0x2C : PRESC
$50004830 constant SEC_USART3_AUTOCR  \ offset: 0x30 : AUTOCR

