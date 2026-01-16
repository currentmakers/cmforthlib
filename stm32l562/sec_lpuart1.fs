\
\ @file sec_lpuart1.fs
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

$00000001 constant SEC_LPUART1_CR1_UE                               \ USART enable
$00000002 constant SEC_LPUART1_CR1_UESM                             \ USART enable in Stop mode
$00000004 constant SEC_LPUART1_CR1_RE                               \ Receiver enable
$00000008 constant SEC_LPUART1_CR1_TE                               \ Transmitter enable
$00000010 constant SEC_LPUART1_CR1_IDLEIE                           \ IDLE interrupt enable
$00000020 constant SEC_LPUART1_CR1_RXNEIE                           \ RXNE interrupt enable
$00000040 constant SEC_LPUART1_CR1_TCIE                             \ Transmission complete interrupt enable
$00000080 constant SEC_LPUART1_CR1_TXEIE                            \ interrupt enable
$00000100 constant SEC_LPUART1_CR1_PEIE                             \ PE interrupt enable
$00000200 constant SEC_LPUART1_CR1_PS                               \ Parity selection
$00000400 constant SEC_LPUART1_CR1_PCE                              \ Parity control enable
$00000800 constant SEC_LPUART1_CR1_WAKE                             \ Receiver wakeup method
$00001000 constant SEC_LPUART1_CR1_M0                               \ Word length
$00002000 constant SEC_LPUART1_CR1_MME                              \ Mute mode enable
$00004000 constant SEC_LPUART1_CR1_CMIE                             \ Character match interrupt enable
$001f0000 constant SEC_LPUART1_CR1_DEDT                             \ DEDT
$03e00000 constant SEC_LPUART1_CR1_DEAT                             \ DEAT
$10000000 constant SEC_LPUART1_CR1_M1                               \ Word length
$20000000 constant SEC_LPUART1_CR1_FIFOEN                           \ FIFOEN
$40000000 constant SEC_LPUART1_CR1_TXFEIE                           \ TXFEIE
$80000000 constant SEC_LPUART1_CR1_RXFFIE                           \ RXFFIE


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000010 constant SEC_LPUART1_CR2_ADDM7                            \ 7-bit Address Detection/4-bit Address Detection
$00003000 constant SEC_LPUART1_CR2_STOP                             \ STOP bits
$00008000 constant SEC_LPUART1_CR2_SWAP                             \ Swap TX/RX pins
$00010000 constant SEC_LPUART1_CR2_RXINV                            \ RX pin active level inversion
$00020000 constant SEC_LPUART1_CR2_TXINV                            \ TX pin active level inversion
$00040000 constant SEC_LPUART1_CR2_TAINV                            \ Binary data inversion
$00080000 constant SEC_LPUART1_CR2_MSBFIRST                         \ Most significant bit first
$0f000000 constant SEC_LPUART1_CR2_ADD0_3                           \ Address of the USART node
$f0000000 constant SEC_LPUART1_CR2_ADD4_7                           \ Address of the USART node


\
\ @brief Control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPUART1_CR3_EIE                              \ Error interrupt enable
$00000008 constant SEC_LPUART1_CR3_HDSEL                            \ Half-duplex selection
$00000040 constant SEC_LPUART1_CR3_DMAR                             \ DMA enable receiver
$00000080 constant SEC_LPUART1_CR3_DMAT                             \ DMA enable transmitter
$00000100 constant SEC_LPUART1_CR3_RTSE                             \ RTS enable
$00000200 constant SEC_LPUART1_CR3_CTSE                             \ CTS enable
$00000400 constant SEC_LPUART1_CR3_CTSIE                            \ CTS interrupt enable
$00001000 constant SEC_LPUART1_CR3_OVRDIS                           \ Overrun Disable
$00002000 constant SEC_LPUART1_CR3_DDRE                             \ DMA Disable on Reception Error
$00004000 constant SEC_LPUART1_CR3_DEM                              \ Driver enable mode
$00008000 constant SEC_LPUART1_CR3_DEP                              \ Driver enable polarity selection
$00300000 constant SEC_LPUART1_CR3_WUS                              \ Wakeup from Stop mode interrupt flag selection
$00400000 constant SEC_LPUART1_CR3_WUFIE                            \ Wakeup from Stop mode interrupt enable
$00800000 constant SEC_LPUART1_CR3_TXFTIE                           \ TXFTIE
$0e000000 constant SEC_LPUART1_CR3_RXFTCFG                          \ RXFTCFG
$10000000 constant SEC_LPUART1_CR3_RXFTIE                           \ RXFTIE
$e0000000 constant SEC_LPUART1_CR3_TXFTCFG                          \ TXFTCFG


\
\ @brief Baud rate register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000fffff constant SEC_LPUART1_BRR_BRR                              \ BRR


\
\ @brief Request register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant SEC_LPUART1_RQR_SBKRQ                            \ Send break request
$00000004 constant SEC_LPUART1_RQR_MMRQ                             \ Mute mode request
$00000008 constant SEC_LPUART1_RQR_RXFRQ                            \ Receive data flush request
$00000010 constant SEC_LPUART1_RQR_TXFRQ                            \ TXFRQ


\
\ @brief Interrupt & status register
\ Address offset: 0x1C
\ Reset value: 0x000000C0
\

$00000001 constant SEC_LPUART1_ISR_PE                               \ PE
$00000002 constant SEC_LPUART1_ISR_FE                               \ FE
$00000004 constant SEC_LPUART1_ISR_NF                               \ NF
$00000008 constant SEC_LPUART1_ISR_ORE                              \ ORE
$00000010 constant SEC_LPUART1_ISR_IDLE                             \ IDLE
$00000020 constant SEC_LPUART1_ISR_RXNE                             \ RXNE
$00000040 constant SEC_LPUART1_ISR_TC                               \ TC
$00000080 constant SEC_LPUART1_ISR_TXE                              \ TXE
$00000200 constant SEC_LPUART1_ISR_CTSIF                            \ CTSIF
$00000400 constant SEC_LPUART1_ISR_CTS                              \ CTS
$00010000 constant SEC_LPUART1_ISR_BUSY                             \ BUSY
$00020000 constant SEC_LPUART1_ISR_CMF                              \ CMF
$00040000 constant SEC_LPUART1_ISR_SBKF                             \ SBKF
$00080000 constant SEC_LPUART1_ISR_RWU                              \ RWU
$00100000 constant SEC_LPUART1_ISR_WUF                              \ WUF
$00200000 constant SEC_LPUART1_ISR_TEACK                            \ TEACK
$00400000 constant SEC_LPUART1_ISR_REACK                            \ REACK
$00800000 constant SEC_LPUART1_ISR_TXFE                             \ TXFE
$01000000 constant SEC_LPUART1_ISR_RXFF                             \ RXFF
$04000000 constant SEC_LPUART1_ISR_RXFT                             \ RXFT
$08000000 constant SEC_LPUART1_ISR_TXFT                             \ TXFT


\
\ @brief Interrupt flag clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPUART1_ICR_PECF                             \ Parity error clear flag
$00000002 constant SEC_LPUART1_ICR_FECF                             \ Framing error clear flag
$00000004 constant SEC_LPUART1_ICR_NCF                              \ Noise detected clear flag
$00000008 constant SEC_LPUART1_ICR_ORECF                            \ Overrun error clear flag
$00000010 constant SEC_LPUART1_ICR_IDLECF                           \ Idle line detected clear flag
$00000040 constant SEC_LPUART1_ICR_TCCF                             \ Transmission complete clear flag
$00000200 constant SEC_LPUART1_ICR_CTSCF                            \ CTS clear flag
$00020000 constant SEC_LPUART1_ICR_CMCF                             \ Character match clear flag
$00100000 constant SEC_LPUART1_ICR_WUCF                             \ Wakeup from Stop mode clear flag


\
\ @brief Receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000001ff constant SEC_LPUART1_RDR_RDR                              \ Receive data value


\
\ @brief Transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant SEC_LPUART1_TDR_TDR                              \ Transmit data value


\
\ @brief PRESC
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000000f constant SEC_LPUART1_PRESC_PRESCALER                      \ PRESCALER


\
\ @brief Universal synchronous asynchronous receiver transmitter
\
$50008000 constant SEC_LPUART1_CR1  \ offset: 0x00 : Control register 1
$50008004 constant SEC_LPUART1_CR2  \ offset: 0x04 : Control register 2
$50008008 constant SEC_LPUART1_CR3  \ offset: 0x08 : Control register 3
$5000800c constant SEC_LPUART1_BRR  \ offset: 0x0C : Baud rate register
$50008018 constant SEC_LPUART1_RQR  \ offset: 0x18 : Request register
$5000801c constant SEC_LPUART1_ISR  \ offset: 0x1C : Interrupt & status register
$50008020 constant SEC_LPUART1_ICR  \ offset: 0x20 : Interrupt flag clear register
$50008024 constant SEC_LPUART1_RDR  \ offset: 0x24 : Receive data register
$50008028 constant SEC_LPUART1_TDR  \ offset: 0x28 : Transmit data register
$5000802c constant SEC_LPUART1_PRESC  \ offset: 0x2C : PRESC

