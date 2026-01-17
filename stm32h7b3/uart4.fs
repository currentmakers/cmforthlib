\
\ @file uart4.fs
\ @brief Universal synchronous asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] UART4_DEF

  [ifdef] UART4_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant UART4_UE                       \ [0x00] USART enable
    $01 constant UART4_UESM                     \ [0x01] USART enable in Stop mode
    $02 constant UART4_RE                       \ [0x02] Receiver enable
    $03 constant UART4_TE                       \ [0x03] Transmitter enable
    $04 constant UART4_IDLEIE                   \ [0x04] IDLE interrupt enable
    $05 constant UART4_RXNEIE                   \ [0x05] RXNE interrupt enable
    $06 constant UART4_TCIE                     \ [0x06] Transmission complete interrupt enable
    $07 constant UART4_TXEIE                    \ [0x07] interrupt enable
    $08 constant UART4_PEIE                     \ [0x08] PE interrupt enable
    $09 constant UART4_PS                       \ [0x09] Parity selection
    $0a constant UART4_PCE                      \ [0x0a] Parity control enable
    $0b constant UART4_WAKE                     \ [0x0b] Receiver wakeup method
    $0c constant UART4_M0                       \ [0x0c] Word length
    $0d constant UART4_MME                      \ [0x0d] Mute mode enable
    $0e constant UART4_CMIE                     \ [0x0e] Character match interrupt enable
    $0f constant UART4_OVER8                    \ [0x0f] Oversampling mode
    $10 constant UART4_DEDT0                    \ [0x10] DEDT0
    $11 constant UART4_DEDT1                    \ [0x11] DEDT1
    $12 constant UART4_DEDT2                    \ [0x12] DEDT2
    $13 constant UART4_DEDT3                    \ [0x13] DEDT3
    $14 constant UART4_DEDT4                    \ [0x14] Driver Enable de-assertion time
    $15 constant UART4_DEAT0                    \ [0x15] DEAT0
    $16 constant UART4_DEAT1                    \ [0x16] DEAT1
    $17 constant UART4_DEAT2                    \ [0x17] DEAT2
    $18 constant UART4_DEAT3                    \ [0x18] DEAT3
    $19 constant UART4_DEAT4                    \ [0x19] Driver Enable assertion time
    $1a constant UART4_RTOIE                    \ [0x1a] Receiver timeout interrupt enable
    $1b constant UART4_EOBIE                    \ [0x1b] End of Block interrupt enable
    $1c constant UART4_M1                       \ [0x1c] Word length
    $1d constant UART4_FIFOEN                   \ [0x1d] FIFO mode enable
    $1e constant UART4_TXFEIE                   \ [0x1e] TXFIFO empty interrupt enable
    $1f constant UART4_RXFFIE                   \ [0x1f] RXFIFO Full interrupt enable
  [then]


  [ifdef] UART4_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant UART4_SLVEN                    \ [0x00] Synchronous Slave mode enable
    $03 constant UART4_DIS_NSS                  \ [0x03] When the DSI_NSS bit is set, the NSS pin input is ignored
    $04 constant UART4_ADDM7                    \ [0x04] 7-bit Address Detection/4-bit Address Detection
    $05 constant UART4_LBDL                     \ [0x05] LIN break detection length
    $06 constant UART4_LBDIE                    \ [0x06] LIN break detection interrupt enable
    $08 constant UART4_LBCL                     \ [0x08] Last bit clock pulse
    $09 constant UART4_CPHA                     \ [0x09] Clock phase
    $0a constant UART4_CPOL                     \ [0x0a] Clock polarity
    $0b constant UART4_CLKEN                    \ [0x0b] Clock enable
    $0c constant UART4_STOP                     \ [0x0c : 2] STOP bits
    $0e constant UART4_LINEN                    \ [0x0e] LIN mode enable
    $0f constant UART4_SWAP                     \ [0x0f] Swap TX/RX pins
    $10 constant UART4_RXINV                    \ [0x10] RX pin active level inversion
    $11 constant UART4_TXINV                    \ [0x11] TX pin active level inversion
    $12 constant UART4_TAINV                    \ [0x12] Binary data inversion
    $13 constant UART4_MSBFIRST                 \ [0x13] Most significant bit first
    $14 constant UART4_ABREN                    \ [0x14] Auto baud rate enable
    $15 constant UART4_ABRMOD0                  \ [0x15] ABRMOD0
    $16 constant UART4_ABRMOD1                  \ [0x16] Auto baud rate mode
    $17 constant UART4_RTOEN                    \ [0x17] Receiver timeout enable
    $18 constant UART4_ADD0_3                   \ [0x18 : 4] Address of the USART node
    $1c constant UART4_ADD4_7                   \ [0x1c : 4] Address of the USART node
  [then]


  [ifdef] UART4_CR3_DEF
    \
    \ @brief Control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant UART4_EIE                      \ [0x00] Error interrupt enable
    $01 constant UART4_IREN                     \ [0x01] Ir mode enable
    $02 constant UART4_IRLP                     \ [0x02] Ir low-power
    $03 constant UART4_HDSEL                    \ [0x03] Half-duplex selection
    $04 constant UART4_NACK                     \ [0x04] Smartcard NACK enable
    $05 constant UART4_SCEN                     \ [0x05] Smartcard mode enable
    $06 constant UART4_DMAR                     \ [0x06] DMA enable receiver
    $07 constant UART4_DMAT                     \ [0x07] DMA enable transmitter
    $08 constant UART4_RTSE                     \ [0x08] RTS enable
    $09 constant UART4_CTSE                     \ [0x09] CTS enable
    $0a constant UART4_CTSIE                    \ [0x0a] CTS interrupt enable
    $0b constant UART4_ONEBIT                   \ [0x0b] One sample bit method enable
    $0c constant UART4_OVRDIS                   \ [0x0c] Overrun Disable
    $0d constant UART4_DDRE                     \ [0x0d] DMA Disable on Reception Error
    $0e constant UART4_DEM                      \ [0x0e] Driver enable mode
    $0f constant UART4_DEP                      \ [0x0f] Driver enable polarity selection
    $11 constant UART4_SCARCNT                  \ [0x11 : 3] Smartcard auto-retry count
    $14 constant UART4_WUS                      \ [0x14 : 2] Wakeup from Stop mode interrupt flag selection
    $16 constant UART4_WUFIE                    \ [0x16] Wakeup from Stop mode interrupt enable
    $17 constant UART4_TXFTIE                   \ [0x17] TXFIFO threshold interrupt enable
    $18 constant UART4_TCBGTIE                  \ [0x18] Transmission Complete before guard time, interrupt enable
    $19 constant UART4_RXFTCFG                  \ [0x19 : 3] Receive FIFO threshold configuration
    $1c constant UART4_RXFTIE                   \ [0x1c] RXFIFO threshold interrupt enable
    $1d constant UART4_TXFTCFG                  \ [0x1d : 3] TXFIFO threshold configuration
  [then]


  [ifdef] UART4_BRR_DEF
    \
    \ @brief Baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant UART4_BRR_0_3                  \ [0x00 : 4] DIV_Fraction
    $04 constant UART4_BRR_4_15                 \ [0x04 : 12] DIV_Mantissa
  [then]


  [ifdef] UART4_GTPR_DEF
    \
    \ @brief Guard time and prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant UART4_PSC                      \ [0x00 : 8] Prescaler value
    $08 constant UART4_GT                       \ [0x08 : 8] Guard time value
  [then]


  [ifdef] UART4_RTOR_DEF
    \
    \ @brief Receiver timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant UART4_RTO                      \ [0x00 : 24] Receiver timeout value
    $18 constant UART4_BLEN                     \ [0x18 : 8] Block Length
  [then]


  [ifdef] UART4_RQR_DEF
    \
    \ @brief Request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant UART4_ABRRQ                    \ [0x00] Auto baud rate request
    $01 constant UART4_SBKRQ                    \ [0x01] Send break request
    $02 constant UART4_MMRQ                     \ [0x02] Mute mode request
    $03 constant UART4_RXFRQ                    \ [0x03] Receive data flush request
    $04 constant UART4_TXFRQ                    \ [0x04] Transmit data flush request
  [then]


  [ifdef] UART4_ISR_DEF
    \
    \ @brief Interrupt & status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant UART4_PE                       \ [0x00] PE
    $01 constant UART4_FE                       \ [0x01] FE
    $02 constant UART4_NF                       \ [0x02] NF
    $03 constant UART4_ORE                      \ [0x03] ORE
    $04 constant UART4_IDLE                     \ [0x04] IDLE
    $05 constant UART4_RXNE                     \ [0x05] RXNE
    $06 constant UART4_TC                       \ [0x06] TC
    $07 constant UART4_TXE                      \ [0x07] TXE
    $08 constant UART4_LBDF                     \ [0x08] LBDF
    $09 constant UART4_CTSIF                    \ [0x09] CTSIF
    $0a constant UART4_CTS                      \ [0x0a] CTS
    $0b constant UART4_RTOF                     \ [0x0b] RTOF
    $0c constant UART4_EOBF                     \ [0x0c] EOBF
    $0d constant UART4_UDR                      \ [0x0d] SPI slave underrun error flag
    $0e constant UART4_ABRE                     \ [0x0e] ABRE
    $0f constant UART4_ABRF                     \ [0x0f] ABRF
    $10 constant UART4_BUSY                     \ [0x10] BUSY
    $11 constant UART4_CMF                      \ [0x11] CMF
    $12 constant UART4_SBKF                     \ [0x12] SBKF
    $13 constant UART4_RWU                      \ [0x13] RWU
    $14 constant UART4_WUF                      \ [0x14] WUF
    $15 constant UART4_TEACK                    \ [0x15] TEACK
    $16 constant UART4_REACK                    \ [0x16] REACK
    $17 constant UART4_TXFE                     \ [0x17] TXFIFO Empty
    $18 constant UART4_RXFF                     \ [0x18] RXFIFO Full
    $19 constant UART4_TCBGT                    \ [0x19] Transmission complete before guard time flag
    $1a constant UART4_RXFT                     \ [0x1a] RXFIFO threshold flag
    $1b constant UART4_TXFT                     \ [0x1b] TXFIFO threshold flag
  [then]


  [ifdef] UART4_ICR_DEF
    \
    \ @brief Interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant UART4_PECF                     \ [0x00] Parity error clear flag
    $01 constant UART4_FECF                     \ [0x01] Framing error clear flag
    $02 constant UART4_NCF                      \ [0x02] Noise detected clear flag
    $03 constant UART4_ORECF                    \ [0x03] Overrun error clear flag
    $04 constant UART4_IDLECF                   \ [0x04] Idle line detected clear flag
    $05 constant UART4_TXFECF                   \ [0x05] TXFIFO empty clear flag
    $06 constant UART4_TCCF                     \ [0x06] Transmission complete clear flag
    $07 constant UART4_TCBGTC                   \ [0x07] Transmission complete before Guard time clear flag
    $08 constant UART4_LBDCF                    \ [0x08] LIN break detection clear flag
    $09 constant UART4_CTSCF                    \ [0x09] CTS clear flag
    $0b constant UART4_RTOCF                    \ [0x0b] Receiver timeout clear flag
    $0c constant UART4_EOBCF                    \ [0x0c] End of block clear flag
    $0d constant UART4_UDRCF                    \ [0x0d] SPI slave underrun clear flag
    $11 constant UART4_CMCF                     \ [0x11] Character match clear flag
    $14 constant UART4_WUCF                     \ [0x14] Wakeup from Stop mode clear flag
  [then]


  [ifdef] UART4_RDR_DEF
    \
    \ @brief Receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant UART4_RDR                      \ [0x00 : 9] Receive data value
  [then]


  [ifdef] UART4_TDR_DEF
    \
    \ @brief Transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant UART4_TDR                      \ [0x00 : 9] Transmit data value
  [then]


  [ifdef] UART4_PRESC_DEF
    \
    \ @brief USART prescaler register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant UART4_PRESCALER                \ [0x00 : 4] Clock prescaler
  [then]

  \
  \ @brief Universal synchronous asynchronous receiver transmitter
  \
  $00 constant UART4_CR1                \ Control register 1
  $04 constant UART4_CR2                \ Control register 2
  $08 constant UART4_CR3                \ Control register 3
  $0C constant UART4_BRR                \ Baud rate register
  $10 constant UART4_GTPR               \ Guard time and prescaler register
  $14 constant UART4_RTOR               \ Receiver timeout register
  $18 constant UART4_RQR                \ Request register
  $1C constant UART4_ISR                \ Interrupt & status register
  $20 constant UART4_ICR                \ Interrupt flag clear register
  $24 constant UART4_RDR                \ Receive data register
  $28 constant UART4_TDR                \ Transmit data register
  $2C constant UART4_PRESC              \ USART prescaler register

: UART4_DEF ; [then]
