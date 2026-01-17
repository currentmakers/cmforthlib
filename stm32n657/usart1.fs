\
\ @file usart1.fs
\ @brief Universal synchronous/asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USART1_DEF

  [ifdef] USART1_USART_CR1_FIFO_ENABLED_DEF
    \
    \ @brief USART control register 1 [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USART1_UE                      \ [0x00] USART enable
    $01 constant USART1_UESM                    \ [0x01] USART enable in low-power mode
    $02 constant USART1_RE                      \ [0x02] Receiver enable
    $03 constant USART1_TE                      \ [0x03] Transmitter enable
    $04 constant USART1_IDLEIE                  \ [0x04] IDLE interrupt enable
    $05 constant USART1_RXFNEIE                 \ [0x05] RXFIFO not empty interrupt enable
    $06 constant USART1_TCIE                    \ [0x06] Transmission complete interrupt enable
    $07 constant USART1_TXFNFIE                 \ [0x07] TXFIFO not full interrupt enable
    $08 constant USART1_PEIE                    \ [0x08] PE interrupt enable
    $09 constant USART1_PS                      \ [0x09] Parity selection
    $0a constant USART1_PCE                     \ [0x0a] Parity control enable
    $0b constant USART1_WAKE                    \ [0x0b] Receiver wakeup method
    $0c constant USART1_M0                      \ [0x0c] Word length
    $0d constant USART1_MME                     \ [0x0d] Mute mode enable
    $0e constant USART1_CMIE                    \ [0x0e] Character match interrupt enable
    $0f constant USART1_OVER8                   \ [0x0f] Oversampling mode
    $10 constant USART1_DEDT                    \ [0x10 : 5] Driver Enable deassertion time
    $15 constant USART1_DEAT                    \ [0x15 : 5] Driver Enable assertion time
    $1a constant USART1_RTOIE                   \ [0x1a] Receiver timeout interrupt enable
    $1b constant USART1_EOBIE                   \ [0x1b] End of Block interrupt enable
    $1c constant USART1_M1                      \ [0x1c] Word length
    $1d constant USART1_FIFOEN                  \ [0x1d] FIFO mode enable
    $1e constant USART1_TXFEIE                  \ [0x1e] TXFIFO empty interrupt enable
    $1f constant USART1_RXFFIE                  \ [0x1f] RXFIFO Full interrupt enable
  [then]


  [ifdef] USART1_USART_CR1_FIFO_DISABLED_DEF
    \
    \ @brief USART control register 1 [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USART1_UE                      \ [0x00] USART enable
    $01 constant USART1_UESM                    \ [0x01] USART enable in low-power mode
    $02 constant USART1_RE                      \ [0x02] Receiver enable
    $03 constant USART1_TE                      \ [0x03] Transmitter enable
    $04 constant USART1_IDLEIE                  \ [0x04] IDLE interrupt enable
    $05 constant USART1_RXNEIE                  \ [0x05] Receive data register not empty
    $06 constant USART1_TCIE                    \ [0x06] Transmission complete interrupt enable
    $07 constant USART1_TXEIE                   \ [0x07] Transmit data register empty
    $08 constant USART1_PEIE                    \ [0x08] PE interrupt enable
    $09 constant USART1_PS                      \ [0x09] Parity selection
    $0a constant USART1_PCE                     \ [0x0a] Parity control enable
    $0b constant USART1_WAKE                    \ [0x0b] Receiver wakeup method
    $0c constant USART1_M0                      \ [0x0c] Word length
    $0d constant USART1_MME                     \ [0x0d] Mute mode enable
    $0e constant USART1_CMIE                    \ [0x0e] Character match interrupt enable
    $0f constant USART1_OVER8                   \ [0x0f] Oversampling mode
    $10 constant USART1_DEDT                    \ [0x10 : 5] Driver Enable deassertion time
    $15 constant USART1_DEAT                    \ [0x15 : 5] Driver Enable assertion time
    $1a constant USART1_RTOIE                   \ [0x1a] Receiver timeout interrupt enable
    $1b constant USART1_EOBIE                   \ [0x1b] End of Block interrupt enable
    $1c constant USART1_M1                      \ [0x1c] Word length
    $1d constant USART1_FIFOEN                  \ [0x1d] FIFO mode enable
  [then]


  [ifdef] USART1_USART_CR2_DEF
    \
    \ @brief USART control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USART1_SLVEN                   \ [0x00] Synchronous Slave mode enable
    $03 constant USART1_DIS_NSS                 \ [0x03] When the DIS_NSS bit is set, the NSS pin input is ignored.
    $04 constant USART1_ADDM7                   \ [0x04] 7-bit Address Detection/4-bit Address Detection
    $05 constant USART1_LBDL                    \ [0x05] LIN break detection length
    $06 constant USART1_LBDIE                   \ [0x06] LIN break detection interrupt enable
    $08 constant USART1_LBCL                    \ [0x08] Last bit clock pulse
    $09 constant USART1_CPHA                    \ [0x09] Clock phase
    $0a constant USART1_CPOL                    \ [0x0a] Clock polarity
    $0b constant USART1_CLKEN                   \ [0x0b] Clock enable
    $0c constant USART1_STOP                    \ [0x0c : 2] stop bits
    $0e constant USART1_LINEN                   \ [0x0e] LIN mode enable
    $0f constant USART1_SWAP                    \ [0x0f] Swap TX/RX pins
    $10 constant USART1_RXINV                   \ [0x10] RX pin active level inversion
    $11 constant USART1_TXINV                   \ [0x11] TX pin active level inversion
    $12 constant USART1_DATAINV                 \ [0x12] Binary data inversion
    $13 constant USART1_MSBFIRST                \ [0x13] Most significant bit first
    $14 constant USART1_ABREN                   \ [0x14] Auto baud rate enable
    $15 constant USART1_ABRMOD                  \ [0x15 : 2] Auto baud rate mode
    $17 constant USART1_RTOEN                   \ [0x17] Receiver timeout enable
    $18 constant USART1_ADD                     \ [0x18 : 8] Address of the USART node
  [then]


  [ifdef] USART1_USART_CR3_DEF
    \
    \ @brief USART control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USART1_EIE                     \ [0x00] Error interrupt enable
    $01 constant USART1_IREN                    \ [0x01] IrDA mode enable
    $02 constant USART1_IRLP                    \ [0x02] IrDA low-power
    $03 constant USART1_HDSEL                   \ [0x03] Half-duplex selection
    $04 constant USART1_NACK                    \ [0x04] Smartcard NACK enable
    $05 constant USART1_SCEN                    \ [0x05] Smartcard mode enable
    $06 constant USART1_DMAR                    \ [0x06] DMA enable receiver
    $07 constant USART1_DMAT                    \ [0x07] DMA enable transmitter
    $08 constant USART1_RTSE                    \ [0x08] RTS enable
    $09 constant USART1_CTSE                    \ [0x09] CTS enable
    $0a constant USART1_CTSIE                   \ [0x0a] CTS interrupt enable
    $0b constant USART1_ONEBIT                  \ [0x0b] One sample bit method enable
    $0c constant USART1_OVRDIS                  \ [0x0c] Overrun Disable
    $0d constant USART1_DDRE                    \ [0x0d] DMA Disable on Reception Error
    $0e constant USART1_DEM                     \ [0x0e] Driver enable mode
    $0f constant USART1_DEP                     \ [0x0f] Driver enable polarity selection
    $11 constant USART1_SCARCNT                 \ [0x11 : 3] Smartcard auto-retry count
    $14 constant USART1_WUS0                    \ [0x14] Wakeup from low-power mode interrupt flag selection
    $15 constant USART1_WUS1                    \ [0x15] Wakeup from low-power mode interrupt flag selection
    $16 constant USART1_WUFIE                   \ [0x16] Wakeup from low-power mode interrupt enable
    $17 constant USART1_TXFTIE                  \ [0x17] TXFIFO threshold interrupt enable
    $18 constant USART1_TCBGTIE                 \ [0x18] Transmission Complete before guard time, interrupt enable
    $19 constant USART1_RXFTCFG                 \ [0x19 : 3] Receive FIFO threshold configuration
    $1c constant USART1_RXFTIE                  \ [0x1c] RXFIFO threshold interrupt enable
    $1d constant USART1_TXFTCFG                 \ [0x1d : 3] TXFIFO threshold configuration
  [then]


  [ifdef] USART1_USART_BRR_DEF
    \
    \ @brief USART baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USART1_BRR                     \ [0x00 : 16] USART baud rate
  [then]


  [ifdef] USART1_USART_GTPR_DEF
    \
    \ @brief USART guard time and prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USART1_PSC                     \ [0x00 : 8] Prescaler value
    $08 constant USART1_GT                      \ [0x08 : 8] Guard time value
  [then]


  [ifdef] USART1_USART_RTOR_DEF
    \
    \ @brief USART receiver timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USART1_RTO                     \ [0x00 : 24] Receiver timeout value
    $18 constant USART1_BLEN                    \ [0x18 : 8] Block Length
  [then]


  [ifdef] USART1_USART_RQR_DEF
    \
    \ @brief USART request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USART1_ABRRQ                   \ [0x00] Auto baud rate request
    $01 constant USART1_SBKRQ                   \ [0x01] Send break request
    $02 constant USART1_MMRQ                    \ [0x02] Mute mode request
    $03 constant USART1_RXFRQ                   \ [0x03] Receive data flush request
    $04 constant USART1_TXFRQ                   \ [0x04] Transmit data flush request
  [then]


  [ifdef] USART1_USART_ISR_FIFO_ENABLED_DEF
    \
    \ @brief USART interrupt and status register [alternate]
    \ Address offset: 0x1C
    \ Reset value: 0x000000C0
    \
    $00 constant USART1_PE                      \ [0x00] Parity error
    $01 constant USART1_FE                      \ [0x01] Framing error
    $02 constant USART1_NE                      \ [0x02] Noise detection flag
    $03 constant USART1_ORE                     \ [0x03] Overrun error
    $04 constant USART1_IDLE                    \ [0x04] Idle line detected
    $05 constant USART1_RXFNE                   \ [0x05] RXFIFO not empty
    $06 constant USART1_TC                      \ [0x06] Transmission complete
    $07 constant USART1_TXFNF                   \ [0x07] TXFIFO not full
    $08 constant USART1_LBDF                    \ [0x08] LIN break detection flag
    $09 constant USART1_CTSIF                   \ [0x09] CTS interrupt flag
    $0a constant USART1_CTS                     \ [0x0a] CTS flag
    $0b constant USART1_RTOF                    \ [0x0b] Receiver timeout
    $0c constant USART1_EOBF                    \ [0x0c] End of block flag
    $0d constant USART1_UDR                     \ [0x0d] SPI slave underrun error flag
    $0e constant USART1_ABRE                    \ [0x0e] Auto baud rate error
    $0f constant USART1_ABRF                    \ [0x0f] Auto baud rate flag
    $10 constant USART1_BUSY                    \ [0x10] Busy flag
    $11 constant USART1_CMF                     \ [0x11] Character match flag
    $12 constant USART1_SBKF                    \ [0x12] Send break flag
    $13 constant USART1_RWU                     \ [0x13] Receiver wakeup from Mute mode
    $14 constant USART1_WUF                     \ [0x14] Wakeup from low-power mode flag
    $15 constant USART1_TEACK                   \ [0x15] Transmit enable acknowledge flag
    $16 constant USART1_REACK                   \ [0x16] Receive enable acknowledge flag
    $17 constant USART1_TXFE                    \ [0x17] TXFIFO Empty
    $18 constant USART1_RXFF                    \ [0x18] RXFIFO Full
    $19 constant USART1_TCBGT                   \ [0x19] Transmission complete before guard time flag
    $1a constant USART1_RXFT                    \ [0x1a] RXFIFO threshold flag
    $1b constant USART1_TXFT                    \ [0x1b] TXFIFO threshold flag
  [then]


  [ifdef] USART1_USART_ISR_FIFO_DISABLED_DEF
    \
    \ @brief USART interrupt and status register [alternate]
    \ Address offset: 0x1C
    \ Reset value: 0x000000C0
    \
    $00 constant USART1_PE                      \ [0x00] Parity error
    $01 constant USART1_FE                      \ [0x01] Framing error
    $02 constant USART1_NE                      \ [0x02] Noise detection flag
    $03 constant USART1_ORE                     \ [0x03] Overrun error
    $04 constant USART1_IDLE                    \ [0x04] Idle line detected
    $05 constant USART1_RXNE                    \ [0x05] Read data register not empty
    $06 constant USART1_TC                      \ [0x06] Transmission complete
    $07 constant USART1_TXE                     \ [0x07] Transmit data register empty
    $08 constant USART1_LBDF                    \ [0x08] LIN break detection flag
    $09 constant USART1_CTSIF                   \ [0x09] CTS interrupt flag
    $0a constant USART1_CTS                     \ [0x0a] CTS flag
    $0b constant USART1_RTOF                    \ [0x0b] Receiver timeout
    $0c constant USART1_EOBF                    \ [0x0c] End of block flag
    $0d constant USART1_UDR                     \ [0x0d] SPI slave underrun error flag
    $0e constant USART1_ABRE                    \ [0x0e] Auto baud rate error
    $0f constant USART1_ABRF                    \ [0x0f] Auto baud rate flag
    $10 constant USART1_BUSY                    \ [0x10] Busy flag
    $11 constant USART1_CMF                     \ [0x11] Character match flag
    $12 constant USART1_SBKF                    \ [0x12] Send break flag
    $13 constant USART1_RWU                     \ [0x13] Receiver wakeup from Mute mode
    $14 constant USART1_WUF                     \ [0x14] Wakeup from low-power mode flag
    $15 constant USART1_TEACK                   \ [0x15] Transmit enable acknowledge flag
    $16 constant USART1_REACK                   \ [0x16] Receive enable acknowledge flag
    $19 constant USART1_TCBGT                   \ [0x19] Transmission complete before guard time flag
  [then]


  [ifdef] USART1_USART_ICR_DEF
    \
    \ @brief USART interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant USART1_PECF                    \ [0x00] Parity error clear flag
    $01 constant USART1_FECF                    \ [0x01] Framing error clear flag
    $02 constant USART1_NECF                    \ [0x02] Noise detected clear flag
    $03 constant USART1_ORECF                   \ [0x03] Overrun error clear flag
    $04 constant USART1_IDLECF                  \ [0x04] Idle line detected clear flag
    $05 constant USART1_TXFECF                  \ [0x05] TXFIFO empty clear flag
    $06 constant USART1_TCCF                    \ [0x06] Transmission complete clear flag
    $07 constant USART1_TCBGTCF                 \ [0x07] Transmission complete before Guard time clear flag
    $08 constant USART1_LBDCF                   \ [0x08] LIN break detection clear flag
    $09 constant USART1_CTSCF                   \ [0x09] CTS clear flag
    $0b constant USART1_RTOCF                   \ [0x0b] Receiver timeout clear flag
    $0c constant USART1_EOBCF                   \ [0x0c] End of block clear flag
    $0d constant USART1_UDRCF                   \ [0x0d] SPI slave underrun clear flag
    $11 constant USART1_CMCF                    \ [0x11] Character match clear flag
    $14 constant USART1_WUCF                    \ [0x14] Wakeup from low-power mode clear flag
  [then]


  [ifdef] USART1_USART_RDR_DEF
    \
    \ @brief USART receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant USART1_RDR                     \ [0x00 : 9] Receive data value
  [then]


  [ifdef] USART1_USART_TDR_DEF
    \
    \ @brief USART transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant USART1_TDR                     \ [0x00 : 9] Transmit data value
  [then]


  [ifdef] USART1_USART_PRESC_DEF
    \
    \ @brief USART prescaler register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant USART1_PRESCALER               \ [0x00 : 4] Clock prescaler
  [then]

  \
  \ @brief Universal synchronous/asynchronous receiver transmitter
  \
  $00 constant USART1_USART_CR1_FIFO_ENABLED    \ USART control register 1 [alternate]
  $00 constant USART1_USART_CR1_FIFO_DISABLED    \ USART control register 1 [alternate]
  $04 constant USART1_USART_CR2         \ USART control register 2
  $08 constant USART1_USART_CR3         \ USART control register 3
  $0C constant USART1_USART_BRR         \ USART baud rate register
  $10 constant USART1_USART_GTPR        \ USART guard time and prescaler register
  $14 constant USART1_USART_RTOR        \ USART receiver timeout register
  $18 constant USART1_USART_RQR         \ USART request register
  $1C constant USART1_USART_ISR_FIFO_ENABLED    \ USART interrupt and status register [alternate]
  $1C constant USART1_USART_ISR_FIFO_DISABLED    \ USART interrupt and status register [alternate]
  $20 constant USART1_USART_ICR         \ USART interrupt flag clear register
  $24 constant USART1_USART_RDR         \ USART receive data register
  $28 constant USART1_USART_TDR         \ USART transmit data register
  $2C constant USART1_USART_PRESC       \ USART prescaler register

: USART1_DEF ; [then]
