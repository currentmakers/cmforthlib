\
\ @file lpuart1_s.fs
\ @brief Low-power universal asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPUART control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPUART1_S_LPUART_CR1_ENABLED_UE                  \ LPUART enable
$00000002 constant LPUART1_S_LPUART_CR1_ENABLED_UESM                \ LPUART enable in low-power mode
$00000004 constant LPUART1_S_LPUART_CR1_ENABLED_RE                  \ Receiver enable
$00000008 constant LPUART1_S_LPUART_CR1_ENABLED_TE                  \ Transmitter enable
$00000010 constant LPUART1_S_LPUART_CR1_ENABLED_IDLEIE              \ IDLE interrupt enable
$00000020 constant LPUART1_S_LPUART_CR1_ENABLED_RXFNEIE             \ RXFIFO not empty interrupt enable
$00000040 constant LPUART1_S_LPUART_CR1_ENABLED_TCIE                \ Transmission complete interrupt enable
$00000080 constant LPUART1_S_LPUART_CR1_ENABLED_TXFNFIE             \ TXFIFO not full interrupt enable
$00000100 constant LPUART1_S_LPUART_CR1_ENABLED_PEIE                \ PE interrupt enable
$00000200 constant LPUART1_S_LPUART_CR1_ENABLED_PS                  \ Parity selection
$00000400 constant LPUART1_S_LPUART_CR1_ENABLED_PCE                 \ Parity control enable
$00000800 constant LPUART1_S_LPUART_CR1_ENABLED_WAKE                \ Receiver wake-up method
$00001000 constant LPUART1_S_LPUART_CR1_ENABLED_M0                  \ Word length
$00002000 constant LPUART1_S_LPUART_CR1_ENABLED_MME                 \ Mute mode enable
$00004000 constant LPUART1_S_LPUART_CR1_ENABLED_CMIE                \ Character match interrupt enable
$001f0000 constant LPUART1_S_LPUART_CR1_ENABLED_DEDT                \ Driver Enable deassertion time
$03e00000 constant LPUART1_S_LPUART_CR1_ENABLED_DEAT                \ Driver Enable assertion time
$10000000 constant LPUART1_S_LPUART_CR1_ENABLED_M1                  \ Word length
$20000000 constant LPUART1_S_LPUART_CR1_ENABLED_FIFOEN              \ FIFO mode enable
$40000000 constant LPUART1_S_LPUART_CR1_ENABLED_TXFEIE              \ TXFIFO empty interrupt enable
$80000000 constant LPUART1_S_LPUART_CR1_ENABLED_RXFFIE              \ RXFIFO Full interrupt enable


\
\ @brief LPUART control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPUART1_S_LPUART_CR1_DISABLED_UE                 \ LPUART enable
$00000002 constant LPUART1_S_LPUART_CR1_DISABLED_UESM               \ LPUART enable in low-power mode
$00000004 constant LPUART1_S_LPUART_CR1_DISABLED_RE                 \ Receiver enable
$00000008 constant LPUART1_S_LPUART_CR1_DISABLED_TE                 \ Transmitter enable
$00000010 constant LPUART1_S_LPUART_CR1_DISABLED_IDLEIE             \ IDLE interrupt enable
$00000020 constant LPUART1_S_LPUART_CR1_DISABLED_RXNEIE             \ Receive data register not empty
$00000040 constant LPUART1_S_LPUART_CR1_DISABLED_TCIE               \ Transmission complete interrupt enable
$00000080 constant LPUART1_S_LPUART_CR1_DISABLED_TXEIE              \ Transmit data register empty
$00000100 constant LPUART1_S_LPUART_CR1_DISABLED_PEIE               \ PE interrupt enable
$00000200 constant LPUART1_S_LPUART_CR1_DISABLED_PS                 \ Parity selection
$00000400 constant LPUART1_S_LPUART_CR1_DISABLED_PCE                \ Parity control enable
$00000800 constant LPUART1_S_LPUART_CR1_DISABLED_WAKE               \ Receiver wake-up method
$00001000 constant LPUART1_S_LPUART_CR1_DISABLED_M0                 \ Word length
$00002000 constant LPUART1_S_LPUART_CR1_DISABLED_MME                \ Mute mode enable
$00004000 constant LPUART1_S_LPUART_CR1_DISABLED_CMIE               \ Character match interrupt enable
$001f0000 constant LPUART1_S_LPUART_CR1_DISABLED_DEDT               \ Driver Enable deassertion time
$03e00000 constant LPUART1_S_LPUART_CR1_DISABLED_DEAT               \ Driver Enable assertion time
$10000000 constant LPUART1_S_LPUART_CR1_DISABLED_M1                 \ Word length
$20000000 constant LPUART1_S_LPUART_CR1_DISABLED_FIFOEN             \ FIFO mode enable


\
\ @brief LPUART control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000010 constant LPUART1_S_LPUART_CR2_ADDM7                       \ 7-bit Address Detection/4-bit Address Detection
$00003000 constant LPUART1_S_LPUART_CR2_STOP                        \ STOP bits
$00008000 constant LPUART1_S_LPUART_CR2_SWAP                        \ Swap TX/RX pins
$00010000 constant LPUART1_S_LPUART_CR2_RXINV                       \ RX pin active level inversion
$00020000 constant LPUART1_S_LPUART_CR2_TXINV                       \ TX pin active level inversion
$00040000 constant LPUART1_S_LPUART_CR2_DATAINV                     \ Binary data inversion
$00080000 constant LPUART1_S_LPUART_CR2_MSBFIRST                    \ Most significant bit first
$ff000000 constant LPUART1_S_LPUART_CR2_ADD                         \ Address of the LPUART node


\
\ @brief LPUART control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPUART1_S_LPUART_CR3_EIE                         \ Error interrupt enable
$00000008 constant LPUART1_S_LPUART_CR3_HDSEL                       \ Half-duplex selection
$00000040 constant LPUART1_S_LPUART_CR3_DMAR                        \ DMA enable receiver
$00000080 constant LPUART1_S_LPUART_CR3_DMAT                        \ DMA enable transmitter
$00000100 constant LPUART1_S_LPUART_CR3_RTSE                        \ RTS enable
$00000200 constant LPUART1_S_LPUART_CR3_CTSE                        \ CTS enable
$00000400 constant LPUART1_S_LPUART_CR3_CTSIE                       \ CTS interrupt enable
$00001000 constant LPUART1_S_LPUART_CR3_OVRDIS                      \ Overrun Disable
$00002000 constant LPUART1_S_LPUART_CR3_DDRE                        \ DMA Disable on Reception Error
$00004000 constant LPUART1_S_LPUART_CR3_DEM                         \ Driver enable mode
$00008000 constant LPUART1_S_LPUART_CR3_DEP                         \ Driver enable polarity selection
$00100000 constant LPUART1_S_LPUART_CR3_WUS0                        \ Wake-up from low-power mode interrupt flag selection
$00200000 constant LPUART1_S_LPUART_CR3_WUS1                        \ Wake-up from low-power mode interrupt flag selection
$00400000 constant LPUART1_S_LPUART_CR3_WUFIE                       \ Wake-up from low-power mode interrupt enable
$00800000 constant LPUART1_S_LPUART_CR3_TXFTIE                      \ TXFIFO threshold interrupt enable
$0e000000 constant LPUART1_S_LPUART_CR3_RXFTCFG                     \ Receive FIFO threshold configuration
$10000000 constant LPUART1_S_LPUART_CR3_RXFTIE                      \ RXFIFO threshold interrupt enable
$e0000000 constant LPUART1_S_LPUART_CR3_TXFTCFG                     \ TXFIFO threshold configuration


\
\ @brief LPUART baud rate register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000fffff constant LPUART1_S_LPUART_BRR_BRR                         \ LPUART baud rate division (LPUARTDIV)


\
\ @brief LPUART request register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant LPUART1_S_LPUART_RQR_SBKRQ                       \ Send break request
$00000004 constant LPUART1_S_LPUART_RQR_MMRQ                        \ Mute mode request
$00000008 constant LPUART1_S_LPUART_RQR_RXFRQ                       \ Receive data flush request
$00000010 constant LPUART1_S_LPUART_RQR_TXFRQ                       \ Transmit data flush request


\
\ @brief LPUART interrupt and status register
\ Address offset: 0x1C
\ Reset value: 0x008000C0
\

$00000001 constant LPUART1_S_LPUART_ISR_ENABLED_PE                  \ Parity error
$00000002 constant LPUART1_S_LPUART_ISR_ENABLED_FE                  \ Framing error
$00000004 constant LPUART1_S_LPUART_ISR_ENABLED_NE                  \ Start bit noise detection flag
$00000008 constant LPUART1_S_LPUART_ISR_ENABLED_ORE                 \ Overrun error
$00000010 constant LPUART1_S_LPUART_ISR_ENABLED_IDLE                \ Idle line detected
$00000020 constant LPUART1_S_LPUART_ISR_ENABLED_RXFNE               \ RXFIFO not empty
$00000040 constant LPUART1_S_LPUART_ISR_ENABLED_TC                  \ Transmission complete
$00000080 constant LPUART1_S_LPUART_ISR_ENABLED_TXFNF               \ TXFIFO not full
$00000200 constant LPUART1_S_LPUART_ISR_ENABLED_CTSIF               \ CTS interrupt flag
$00000400 constant LPUART1_S_LPUART_ISR_ENABLED_CTS                 \ CTS flag
$00010000 constant LPUART1_S_LPUART_ISR_ENABLED_BUSY                \ Busy flag
$00020000 constant LPUART1_S_LPUART_ISR_ENABLED_CMF                 \ Character match flag
$00040000 constant LPUART1_S_LPUART_ISR_ENABLED_SBKF                \ Send break flag
$00080000 constant LPUART1_S_LPUART_ISR_ENABLED_RWU                 \ Receiver wake-up from Mute mode
$00100000 constant LPUART1_S_LPUART_ISR_ENABLED_WUF                 \ Wake-up from low-power mode flag
$00200000 constant LPUART1_S_LPUART_ISR_ENABLED_TEACK               \ Transmit enable acknowledge flag
$00400000 constant LPUART1_S_LPUART_ISR_ENABLED_REACK               \ Receive enable acknowledge flag
$00800000 constant LPUART1_S_LPUART_ISR_ENABLED_TXFE                \ TXFIFO Empty
$01000000 constant LPUART1_S_LPUART_ISR_ENABLED_RXFF                \ RXFIFO Full
$04000000 constant LPUART1_S_LPUART_ISR_ENABLED_RXFT                \ RXFIFO threshold flag
$08000000 constant LPUART1_S_LPUART_ISR_ENABLED_TXFT                \ TXFIFO threshold flag


\
\ @brief LPUART interrupt and status register
\ Address offset: 0x1C
\ Reset value: 0x008000C0
\

$00000001 constant LPUART1_S_LPUART_ISR_DISABLED_PE                 \ Parity error
$00000002 constant LPUART1_S_LPUART_ISR_DISABLED_FE                 \ Framing error
$00000004 constant LPUART1_S_LPUART_ISR_DISABLED_NE                 \ Start bit noise detection flag
$00000008 constant LPUART1_S_LPUART_ISR_DISABLED_ORE                \ Overrun error
$00000010 constant LPUART1_S_LPUART_ISR_DISABLED_IDLE               \ Idle line detected
$00000020 constant LPUART1_S_LPUART_ISR_DISABLED_RXNE               \ Read data register not empty
$00000040 constant LPUART1_S_LPUART_ISR_DISABLED_TC                 \ Transmission complete
$00000080 constant LPUART1_S_LPUART_ISR_DISABLED_TXE                \ Transmit data register empty
$00000200 constant LPUART1_S_LPUART_ISR_DISABLED_CTSIF              \ CTS interrupt flag
$00000400 constant LPUART1_S_LPUART_ISR_DISABLED_CTS                \ CTS flag
$00010000 constant LPUART1_S_LPUART_ISR_DISABLED_BUSY               \ Busy flag
$00020000 constant LPUART1_S_LPUART_ISR_DISABLED_CMF                \ Character match flag
$00040000 constant LPUART1_S_LPUART_ISR_DISABLED_SBKF               \ Send break flag
$00080000 constant LPUART1_S_LPUART_ISR_DISABLED_RWU                \ Receiver wake-up from Mute mode
$00100000 constant LPUART1_S_LPUART_ISR_DISABLED_WUF                \ Wake-up from low-power mode flag
$00200000 constant LPUART1_S_LPUART_ISR_DISABLED_TEACK              \ Transmit enable acknowledge flag
$00400000 constant LPUART1_S_LPUART_ISR_DISABLED_REACK              \ Receive enable acknowledge flag


\
\ @brief LPUART interrupt flag clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant LPUART1_S_LPUART_ICR_PECF                        \ Parity error clear flag
$00000002 constant LPUART1_S_LPUART_ICR_FECF                        \ Framing error clear flag
$00000004 constant LPUART1_S_LPUART_ICR_NECF                        \ Noise detected clear flag
$00000008 constant LPUART1_S_LPUART_ICR_ORECF                       \ Overrun error clear flag
$00000010 constant LPUART1_S_LPUART_ICR_IDLECF                      \ Idle line detected clear flag
$00000040 constant LPUART1_S_LPUART_ICR_TCCF                        \ Transmission complete clear flag
$00000200 constant LPUART1_S_LPUART_ICR_CTSCF                       \ CTS clear flag
$00020000 constant LPUART1_S_LPUART_ICR_CMCF                        \ Character match clear flag
$00100000 constant LPUART1_S_LPUART_ICR_WUCF                        \ Wake-up from low-power mode clear flag


\
\ @brief LPUART receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000001ff constant LPUART1_S_LPUART_RDR_RDR                         \ Receive data value


\
\ @brief LPUART transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant LPUART1_S_LPUART_TDR_TDR                         \ Transmit data value


\
\ @brief LPUART prescaler register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000000f constant LPUART1_S_LPUART_PRESC_PRESCALER                 \ Clock prescaler


\
\ @brief Low-power universal asynchronous receiver transmitter
\
$56000c00 constant LPUART1_S_LPUART_CR1_ENABLED  \ offset: 0x00 : LPUART control register 1
$56000c00 constant LPUART1_S_LPUART_CR1_DISABLED  \ offset: 0x00 : LPUART control register 1
$56000c04 constant LPUART1_S_LPUART_CR2  \ offset: 0x04 : LPUART control register 2
$56000c08 constant LPUART1_S_LPUART_CR3  \ offset: 0x08 : LPUART control register 3
$56000c0c constant LPUART1_S_LPUART_BRR  \ offset: 0x0C : LPUART baud rate register
$56000c18 constant LPUART1_S_LPUART_RQR  \ offset: 0x18 : LPUART request register
$56000c1c constant LPUART1_S_LPUART_ISR_ENABLED  \ offset: 0x1C : LPUART interrupt and status register
$56000c1c constant LPUART1_S_LPUART_ISR_DISABLED  \ offset: 0x1C : LPUART interrupt and status register
$56000c20 constant LPUART1_S_LPUART_ICR  \ offset: 0x20 : LPUART interrupt flag clear register
$56000c24 constant LPUART1_S_LPUART_RDR  \ offset: 0x24 : LPUART receive data register
$56000c28 constant LPUART1_S_LPUART_TDR  \ offset: 0x28 : LPUART transmit data register
$56000c2c constant LPUART1_S_LPUART_PRESC  \ offset: 0x2C : LPUART prescaler register

