\
\ @file lpuart1.fs
\ @brief Universal synchronous asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPUART1_DEF

  [ifdef] LPUART1_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_UE                     \ [0x00] USART enable
    $01 constant LPUART1_UESM                   \ [0x01] USART enable in Stop mode
    $02 constant LPUART1_RE                     \ [0x02] Receiver enable
    $03 constant LPUART1_TE                     \ [0x03] Transmitter enable
    $04 constant LPUART1_IDLEIE                 \ [0x04] IDLE interrupt enable
    $05 constant LPUART1_RXNEIE                 \ [0x05] RXNE interrupt enable
    $06 constant LPUART1_TCIE                   \ [0x06] Transmission complete interrupt enable
    $07 constant LPUART1_TXEIE                  \ [0x07] interrupt enable
    $08 constant LPUART1_PEIE                   \ [0x08] PE interrupt enable
    $09 constant LPUART1_PS                     \ [0x09] Parity selection
    $0a constant LPUART1_PCE                    \ [0x0a] Parity control enable
    $0b constant LPUART1_WAKE                   \ [0x0b] Receiver wakeup method
    $0c constant LPUART1_M0                     \ [0x0c] Word length
    $0d constant LPUART1_MME                    \ [0x0d] Mute mode enable
    $0e constant LPUART1_CMIE                   \ [0x0e] Character match interrupt enable
    $0f constant LPUART1_OVER8                  \ [0x0f] Oversampling mode
    $10 constant LPUART1_DEDT0                  \ [0x10] DEDT0
    $11 constant LPUART1_DEDT1                  \ [0x11] DEDT1
    $12 constant LPUART1_DEDT2                  \ [0x12] DEDT2
    $13 constant LPUART1_DEDT3                  \ [0x13] DEDT3
    $14 constant LPUART1_DEDT4                  \ [0x14] Driver Enable de-assertion time
    $15 constant LPUART1_DEAT0                  \ [0x15] DEAT0
    $16 constant LPUART1_DEAT1                  \ [0x16] DEAT1
    $17 constant LPUART1_DEAT2                  \ [0x17] DEAT2
    $18 constant LPUART1_DEAT3                  \ [0x18] DEAT3
    $19 constant LPUART1_DEAT4                  \ [0x19] Driver Enable assertion time
    $1a constant LPUART1_RTOIE                  \ [0x1a] Receiver timeout interrupt enable
    $1b constant LPUART1_EOBIE                  \ [0x1b] End of Block interrupt enable
    $1c constant LPUART1_M1                     \ [0x1c] Word length
    $1d constant LPUART1_FIFOEN                 \ [0x1d] FIFO mode enable
    $1e constant LPUART1_TXFEIE                 \ [0x1e] TXFIFO empty interrupt enable
    $1f constant LPUART1_RXFFIE                 \ [0x1f] RXFIFO Full interrupt enable
  [then]


  [ifdef] LPUART1_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_SLVEN                  \ [0x00] Synchronous Slave mode enable
    $03 constant LPUART1_DIS_NSS                \ [0x03] When the DSI_NSS bit is set, the NSS pin input will be ignored
    $04 constant LPUART1_ADDM7                  \ [0x04] 7-bit Address Detection/4-bit Address Detection
    $05 constant LPUART1_LBDL                   \ [0x05] LIN break detection length
    $06 constant LPUART1_LBDIE                  \ [0x06] LIN break detection interrupt enable
    $08 constant LPUART1_LBCL                   \ [0x08] Last bit clock pulse
    $09 constant LPUART1_CPHA                   \ [0x09] Clock phase
    $0a constant LPUART1_CPOL                   \ [0x0a] Clock polarity
    $0b constant LPUART1_CLKEN                  \ [0x0b] Clock enable
    $0c constant LPUART1_STOP                   \ [0x0c : 2] STOP bits
    $0e constant LPUART1_LINEN                  \ [0x0e] LIN mode enable
    $0f constant LPUART1_SWAP                   \ [0x0f] Swap TX/RX pins
    $10 constant LPUART1_RXINV                  \ [0x10] RX pin active level inversion
    $11 constant LPUART1_TXINV                  \ [0x11] TX pin active level inversion
    $12 constant LPUART1_TAINV                  \ [0x12] Binary data inversion
    $13 constant LPUART1_MSBFIRST               \ [0x13] Most significant bit first
    $14 constant LPUART1_ABREN                  \ [0x14] Auto baud rate enable
    $15 constant LPUART1_ABRMOD0                \ [0x15] ABRMOD0
    $16 constant LPUART1_ABRMOD1                \ [0x16] Auto baud rate mode
    $17 constant LPUART1_RTOEN                  \ [0x17] Receiver timeout enable
    $18 constant LPUART1_ADD0_3                 \ [0x18 : 4] Address of the USART node
    $1c constant LPUART1_ADD4_7                 \ [0x1c : 4] Address of the USART node
  [then]


  [ifdef] LPUART1_CR3_DEF
    \
    \ @brief Control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_EIE                    \ [0x00] Error interrupt enable
    $01 constant LPUART1_IREN                   \ [0x01] Ir mode enable
    $02 constant LPUART1_IRLP                   \ [0x02] Ir low-power
    $03 constant LPUART1_HDSEL                  \ [0x03] Half-duplex selection
    $04 constant LPUART1_NACK                   \ [0x04] Smartcard NACK enable
    $05 constant LPUART1_SCEN                   \ [0x05] Smartcard mode enable
    $06 constant LPUART1_DMAR                   \ [0x06] DMA enable receiver
    $07 constant LPUART1_DMAT                   \ [0x07] DMA enable transmitter
    $08 constant LPUART1_RTSE                   \ [0x08] RTS enable
    $09 constant LPUART1_CTSE                   \ [0x09] CTS enable
    $0a constant LPUART1_CTSIE                  \ [0x0a] CTS interrupt enable
    $0b constant LPUART1_ONEBIT                 \ [0x0b] One sample bit method enable
    $0c constant LPUART1_OVRDIS                 \ [0x0c] Overrun Disable
    $0d constant LPUART1_DDRE                   \ [0x0d] DMA Disable on Reception Error
    $0e constant LPUART1_DEM                    \ [0x0e] Driver enable mode
    $0f constant LPUART1_DEP                    \ [0x0f] Driver enable polarity selection
    $11 constant LPUART1_SCARCNT                \ [0x11 : 3] Smartcard auto-retry count
    $14 constant LPUART1_WUS                    \ [0x14 : 2] Wakeup from Stop mode interrupt flag selection
    $16 constant LPUART1_WUFIE                  \ [0x16] Wakeup from Stop mode interrupt enable
    $17 constant LPUART1_TXFTIE                 \ [0x17] threshold interrupt enable
    $18 constant LPUART1_TCBGTIE                \ [0x18] Tr Complete before guard time, interrupt enable
    $19 constant LPUART1_RXFTCFG                \ [0x19 : 3] Receive FIFO threshold configuration
    $1c constant LPUART1_RXFTIE                 \ [0x1c] RXFIFO threshold interrupt enable
    $1d constant LPUART1_TXFTCFG                \ [0x1d : 3] TXFIFO threshold configuration
  [then]


  [ifdef] LPUART1_BRR_DEF
    \
    \ @brief Baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_BRR                    \ [0x00 : 16] BRR_4_15
  [then]


  [ifdef] LPUART1_GTPR_DEF
    \
    \ @brief Guard time and prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_PSC                    \ [0x00 : 8] Prescaler value
    $08 constant LPUART1_GT                     \ [0x08 : 8] Guard time value
  [then]


  [ifdef] LPUART1_RTOR_DEF
    \
    \ @brief Receiver timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_RTO                    \ [0x00 : 24] Receiver timeout value
    $18 constant LPUART1_BLEN                   \ [0x18 : 8] Block Length
  [then]


  [ifdef] LPUART1_RQR_DEF
    \
    \ @brief Request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_ABRRQ                  \ [0x00] Auto baud rate request
    $01 constant LPUART1_SBKRQ                  \ [0x01] Send break request
    $02 constant LPUART1_MMRQ                   \ [0x02] Mute mode request
    $03 constant LPUART1_RXFRQ                  \ [0x03] Receive data flush request
    $04 constant LPUART1_TXFRQ                  \ [0x04] Transmit data flush request
  [then]


  [ifdef] LPUART1_ISR_DEF
    \
    \ @brief Interrupt & status register
    \ Address offset: 0x1C
    \ Reset value: 0x000000C0
    \
    $00 constant LPUART1_PE                     \ [0x00] PE
    $01 constant LPUART1_FE                     \ [0x01] FE
    $02 constant LPUART1_NF                     \ [0x02] NF
    $03 constant LPUART1_ORE                    \ [0x03] ORE
    $04 constant LPUART1_IDLE                   \ [0x04] IDLE
    $05 constant LPUART1_RXNE                   \ [0x05] RXNE
    $06 constant LPUART1_TC                     \ [0x06] TC
    $07 constant LPUART1_TXE                    \ [0x07] TXE
    $08 constant LPUART1_LBDF                   \ [0x08] LBDF
    $09 constant LPUART1_CTSIF                  \ [0x09] CTSIF
    $0a constant LPUART1_CTS                    \ [0x0a] CTS
    $0b constant LPUART1_RTOF                   \ [0x0b] RTOF
    $0c constant LPUART1_EOBF                   \ [0x0c] EOBF
    $0d constant LPUART1_UDR                    \ [0x0d] SPI slave underrun error flag
    $0e constant LPUART1_ABRE                   \ [0x0e] ABRE
    $0f constant LPUART1_ABRF                   \ [0x0f] ABRF
    $10 constant LPUART1_BUSY                   \ [0x10] BUSY
    $11 constant LPUART1_CMF                    \ [0x11] CMF
    $12 constant LPUART1_SBKF                   \ [0x12] SBKF
    $13 constant LPUART1_RWU                    \ [0x13] RWU
    $14 constant LPUART1_WUF                    \ [0x14] WUF
    $15 constant LPUART1_TEACK                  \ [0x15] TEACK
    $16 constant LPUART1_REACK                  \ [0x16] REACK
    $17 constant LPUART1_TXFE                   \ [0x17] TXFIFO Empty
    $18 constant LPUART1_RXFF                   \ [0x18] RXFIFO Full
    $19 constant LPUART1_TCBGT                  \ [0x19] Transmission complete before guard time flag
    $1a constant LPUART1_RXFT                   \ [0x1a] RXFIFO threshold flag
    $1b constant LPUART1_TXFT                   \ [0x1b] TXFIFO threshold flag
  [then]


  [ifdef] LPUART1_ICR_DEF
    \
    \ @brief Interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_PECF                   \ [0x00] Parity error clear flag
    $01 constant LPUART1_FECF                   \ [0x01] Framing error clear flag
    $02 constant LPUART1_NCF                    \ [0x02] Noise detected clear flag
    $03 constant LPUART1_ORECF                  \ [0x03] Overrun error clear flag
    $04 constant LPUART1_IDLECF                 \ [0x04] Idle line detected clear flag
    $05 constant LPUART1_TXFECF                 \ [0x05] TXFIFO empty clear flag
    $06 constant LPUART1_TCCF                   \ [0x06] Transmission complete clear flag
    $07 constant LPUART1_TCBGTCF                \ [0x07] Transmission complete before Guard time clear flag
    $08 constant LPUART1_LBDCF                  \ [0x08] LIN break detection clear flag
    $09 constant LPUART1_CTSCF                  \ [0x09] CTS clear flag
    $0b constant LPUART1_RTOCF                  \ [0x0b] Receiver timeout clear flag
    $0c constant LPUART1_EOBCF                  \ [0x0c] End of block clear flag
    $0d constant LPUART1_UDRCF                  \ [0x0d] SPI slave underrun clear flag
    $11 constant LPUART1_CMCF                   \ [0x11] Character match clear flag
    $14 constant LPUART1_WUCF                   \ [0x14] Wakeup from Stop mode clear flag
  [then]


  [ifdef] LPUART1_RDR_DEF
    \
    \ @brief Receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_RDR                    \ [0x00 : 9] Receive data value
  [then]


  [ifdef] LPUART1_TDR_DEF
    \
    \ @brief Transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_TDR                    \ [0x00 : 9] Transmit data value
  [then]


  [ifdef] LPUART1_PRESC_DEF
    \
    \ @brief Prescaler register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_PRESCALER              \ [0x00 : 4] Clock prescaler
  [then]

  \
  \ @brief Universal synchronous asynchronous receiver transmitter
  \
  $00 constant LPUART1_CR1              \ Control register 1
  $04 constant LPUART1_CR2              \ Control register 2
  $08 constant LPUART1_CR3              \ Control register 3
  $0C constant LPUART1_BRR              \ Baud rate register
  $10 constant LPUART1_GTPR             \ Guard time and prescaler register
  $14 constant LPUART1_RTOR             \ Receiver timeout register
  $18 constant LPUART1_RQR              \ Request register
  $1C constant LPUART1_ISR              \ Interrupt & status register
  $20 constant LPUART1_ICR              \ Interrupt flag clear register
  $24 constant LPUART1_RDR              \ Receive data register
  $28 constant LPUART1_TDR              \ Transmit data register
  $2C constant LPUART1_PRESC            \ Prescaler register

: LPUART1_DEF ; [then]
