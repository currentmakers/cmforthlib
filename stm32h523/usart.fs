\
\ @file usart.fs
\ @brief USART address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USART_DEF

  [ifdef] USART_USART_CR1_DEF
    \
    \ @brief USART control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USART_UE                       \ [0x00] USART enable
    $01 constant USART_UESM                     \ [0x01] USART enable in low-power mode
    $02 constant USART_RE                       \ [0x02] Receiver enable
    $03 constant USART_TE                       \ [0x03] Transmitter enable
    $04 constant USART_IDLEIE                   \ [0x04] IDLE interrupt enable
    $05 constant USART_RXFNEIE                  \ [0x05] RXFIFO not empty interrupt enable
    $06 constant USART_TCIE                     \ [0x06] Transmission complete interrupt enable
    $07 constant USART_TXFNFIE                  \ [0x07] TXFIFO not full interrupt enable
    $08 constant USART_PEIE                     \ [0x08] PE interrupt enable
    $09 constant USART_PS                       \ [0x09] Parity selection
    $0a constant USART_PCE                      \ [0x0a] Parity control enable
    $0b constant USART_WAKE                     \ [0x0b] Receiver wake-up method
    $0c constant USART_M0                       \ [0x0c] Word length
    $0d constant USART_MME                      \ [0x0d] Mute mode enable
    $0e constant USART_CMIE                     \ [0x0e] Character match interrupt enable
    $0f constant USART_OVER8                    \ [0x0f] Oversampling mode
    $10 constant USART_DEDT                     \ [0x10 : 5] Driver Enable deassertion time
    $15 constant USART_DEAT                     \ [0x15 : 5] Driver Enable assertion time
    $1a constant USART_RTOIE                    \ [0x1a] Receiver timeout interrupt enable
    $1b constant USART_EOBIE                    \ [0x1b] End of block interrupt enable
    $1c constant USART_M1                       \ [0x1c] Word length
    $1d constant USART_FIFOEN                   \ [0x1d] FIFO mode enable
    $1e constant USART_TXFEIE                   \ [0x1e] TXFIFO empty interrupt enable
    $1f constant USART_RXFFIE                   \ [0x1f] RXFIFO Full interrupt enable
  [then]


  [ifdef] USART_USART_CR1_ALTERNATE1_DEF
    \
    \ @brief USART control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USART_UE                       \ [0x00] USART enable
    $01 constant USART_UESM                     \ [0x01] USART enable in low-power mode
    $02 constant USART_RE                       \ [0x02] Receiver enable
    $03 constant USART_TE                       \ [0x03] Transmitter enable
    $04 constant USART_IDLEIE                   \ [0x04] IDLE interrupt enable
    $05 constant USART_RXNEIE                   \ [0x05] Receive data register not empty
    $06 constant USART_TCIE                     \ [0x06] Transmission complete interrupt enable
    $07 constant USART_TXEIE                    \ [0x07] Transmit data register empty
    $08 constant USART_PEIE                     \ [0x08] PE interrupt enable
    $09 constant USART_PS                       \ [0x09] Parity selection
    $0a constant USART_PCE                      \ [0x0a] Parity control enable
    $0b constant USART_WAKE                     \ [0x0b] Receiver wake-up method
    $0c constant USART_M0                       \ [0x0c] Word length
    $0d constant USART_MME                      \ [0x0d] Mute mode enable
    $0e constant USART_CMIE                     \ [0x0e] Character match interrupt enable
    $0f constant USART_OVER8                    \ [0x0f] Oversampling mode
    $10 constant USART_DEDT                     \ [0x10 : 5] Driver Enable deassertion time
    $15 constant USART_DEAT                     \ [0x15 : 5] Driver Enable assertion time
    $1a constant USART_RTOIE                    \ [0x1a] Receiver timeout interrupt enable
    $1b constant USART_EOBIE                    \ [0x1b] End of block interrupt enable
    $1c constant USART_M1                       \ [0x1c] Word length
    $1d constant USART_FIFOEN                   \ [0x1d] FIFO mode enable
  [then]


  [ifdef] USART_USART_CR2_DEF
    \
    \ @brief USART control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USART_SLVEN                    \ [0x00] Synchronous slave mode enable
    $03 constant USART_DIS_NSS                  \ [0x03] When the DIS_NSS bit is set, the NSS pin input is ignored.
    $04 constant USART_ADDM7                    \ [0x04] 7-bit Address Detection/4-bit Address Detection
    $05 constant USART_LBDL                     \ [0x05] LIN break detection length
    $06 constant USART_LBDIE                    \ [0x06] LIN break detection interrupt enable
    $08 constant USART_LBCL                     \ [0x08] Last bit clock pulse
    $09 constant USART_CPHA                     \ [0x09] Clock phase
    $0a constant USART_CPOL                     \ [0x0a] Clock polarity
    $0b constant USART_CLKEN                    \ [0x0b] Clock enable
    $0c constant USART_STOP                     \ [0x0c : 2] stop bits
    $0e constant USART_LINEN                    \ [0x0e] LIN mode enable
    $0f constant USART_SWAP                     \ [0x0f] Swap TX/RX pins
    $10 constant USART_RXINV                    \ [0x10] RX pin active level inversion
    $11 constant USART_TXINV                    \ [0x11] TX pin active level inversion
    $12 constant USART_DATAINV                  \ [0x12] Binary data inversion
    $13 constant USART_MSBFIRST                 \ [0x13] Most significant bit first
    $14 constant USART_ABREN                    \ [0x14] Auto baud rate enable
    $15 constant USART_ABRMOD                   \ [0x15 : 2] Auto baud rate mode
    $17 constant USART_RTOEN                    \ [0x17] Receiver timeout enable
    $18 constant USART_ADD                      \ [0x18 : 8] Address of the USART node
  [then]


  [ifdef] USART_USART_CR3_DEF
    \
    \ @brief USART control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USART_EIE                      \ [0x00] Error interrupt enable
    $01 constant USART_IREN                     \ [0x01] IrDA mode enable
    $02 constant USART_IRLP                     \ [0x02] IrDA low-power
    $03 constant USART_HDSEL                    \ [0x03] Half-duplex selection
    $04 constant USART_NACK                     \ [0x04] Smartcard NACK enable
    $05 constant USART_SCEN                     \ [0x05] Smartcard mode enable
    $06 constant USART_DMAR                     \ [0x06] DMA enable receiver
    $07 constant USART_DMAT                     \ [0x07] DMA enable transmitter
    $08 constant USART_RTSE                     \ [0x08] RTS enable
    $09 constant USART_CTSE                     \ [0x09] CTS enable
    $0a constant USART_CTSIE                    \ [0x0a] CTS interrupt enable
    $0b constant USART_ONEBIT                   \ [0x0b] One sample bit method enable
    $0c constant USART_OVRDIS                   \ [0x0c] Overrun Disable
    $0d constant USART_DDRE                     \ [0x0d] DMA Disable on reception Error
    $0e constant USART_DEM                      \ [0x0e] Driver enable mode
    $0f constant USART_DEP                      \ [0x0f] Driver enable polarity selection
    $11 constant USART_SCARCNT                  \ [0x11 : 3] Smartcard auto-retry count
    $14 constant USART_WUS0                     \ [0x14] Wake-up from low-power mode interrupt flag selection
    $15 constant USART_WUS1                     \ [0x15] Wake-up from low-power mode interrupt flag selection
    $16 constant USART_WUFIE                    \ [0x16] Wake-up from low-power mode interrupt enable
    $17 constant USART_TXFTIE                   \ [0x17] TXFIFO threshold interrupt enable
    $18 constant USART_TCBGTIE                  \ [0x18] Transmission Complete before guard time, interrupt enable
    $19 constant USART_RXFTCFG                  \ [0x19 : 3] Receive FIFO threshold configuration
    $1c constant USART_RXFTIE                   \ [0x1c] RXFIFO threshold interrupt enable
    $1d constant USART_TXFTCFG                  \ [0x1d : 3] TXFIFO threshold configuration
  [then]


  [ifdef] USART_USART_CR3_ALTERNATE1_DEF
    \
    \ @brief USART control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USART_EIE                      \ [0x00] Error interrupt enable
    $01 constant USART_IREN                     \ [0x01] IrDA mode enable
    $02 constant USART_IRLP                     \ [0x02] IrDA low-power
    $03 constant USART_HDSEL                    \ [0x03] Half-duplex selection
    $04 constant USART_NACK                     \ [0x04] Smartcard NACK enable
    $05 constant USART_SCEN                     \ [0x05] Smartcard mode enable
    $06 constant USART_DMAR                     \ [0x06] DMA enable receiver
    $07 constant USART_DMAT                     \ [0x07] DMA enable transmitter
    $08 constant USART_RTSE                     \ [0x08] RTS enable
    $09 constant USART_CTSE                     \ [0x09] CTS enable
    $0a constant USART_CTSIE                    \ [0x0a] CTS interrupt enable
    $0b constant USART_ONEBIT                   \ [0x0b] One sample bit method enable
    $0c constant USART_OVRDIS                   \ [0x0c] Overrun Disable
    $0d constant USART_DDRE                     \ [0x0d] DMA Disable on reception Error
    $0e constant USART_DEM                      \ [0x0e] Driver enable mode
    $0f constant USART_DEP                      \ [0x0f] Driver enable polarity selection
    $11 constant USART_SCARCNT                  \ [0x11 : 3] Smartcard auto-retry count
    $14 constant USART_WUS0                     \ [0x14] Wake-up from low-power mode interrupt flag selection
    $15 constant USART_WUS1                     \ [0x15] Wake-up from low-power mode interrupt flag selection
    $16 constant USART_WUFIE                    \ [0x16] Wake-up from low-power mode interrupt enable
    $18 constant USART_TCBGTIE                  \ [0x18] Transmission Complete before guard time, interrupt enable
  [then]


  [ifdef] USART_USART_BRR_DEF
    \
    \ @brief USART baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USART_BRR                      \ [0x00 : 16] USART baud rate
  [then]


  [ifdef] USART_USART_GTPR_DEF
    \
    \ @brief USART guard time and prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USART_PSC                      \ [0x00 : 8] Prescaler value
    $08 constant USART_GT                       \ [0x08 : 8] Guard time value
  [then]


  [ifdef] USART_USART_RTOR_DEF
    \
    \ @brief USART receiver timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USART_RTO                      \ [0x00 : 24] Receiver timeout value
    $18 constant USART_BLEN                     \ [0x18 : 8] Block Length
  [then]


  [ifdef] USART_USART_RQR_DEF
    \
    \ @brief USART request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USART_ABRRQ                    \ [0x00] Auto baud rate request
    $01 constant USART_SBKRQ                    \ [0x01] Send break request
    $02 constant USART_MMRQ                     \ [0x02] Mute mode request
    $03 constant USART_RXFRQ                    \ [0x03] Receive data flush request
    $04 constant USART_TXFRQ                    \ [0x04] Transmit data flush request
  [then]


  [ifdef] USART_USART_ISR_DEF
    \
    \ @brief USART interrupt and status register
    \ Address offset: 0x1C
    \ Reset value: 0x000000C0
    \
    $00 constant USART_PE                       \ [0x00] Parity error
    $01 constant USART_FE                       \ [0x01] Framing error
    $02 constant USART_NE                       \ [0x02] Noise detection flag
    $03 constant USART_ORE                      \ [0x03] Overrun error
    $04 constant USART_IDLE                     \ [0x04] Idle line detected
    $05 constant USART_RXFNE                    \ [0x05] RXFIFO not empty
    $06 constant USART_TC                       \ [0x06] Transmission complete
    $07 constant USART_TXFNF                    \ [0x07] TXFIFO not full
    $08 constant USART_LBDF                     \ [0x08] LIN break detection flag
    $09 constant USART_CTSIF                    \ [0x09] CTS interrupt flag
    $0a constant USART_CTS                      \ [0x0a] CTS flag
    $0b constant USART_RTOF                     \ [0x0b] Receiver timeout
    $0c constant USART_EOBF                     \ [0x0c] End of block flag
    $0d constant USART_UDR                      \ [0x0d] SPI slave underrun error flag
    $0e constant USART_ABRE                     \ [0x0e] Auto baud rate error
    $0f constant USART_ABRF                     \ [0x0f] Auto baud rate flag
    $10 constant USART_BUSY                     \ [0x10] Busy flag
    $11 constant USART_CMF                      \ [0x11] Character match flag
    $12 constant USART_SBKF                     \ [0x12] Send break flag
    $13 constant USART_RWU                      \ [0x13] Receiver wake-up from mute mode
    $14 constant USART_WUF                      \ [0x14] Wake-up from low-power mode flag
    $15 constant USART_TEACK                    \ [0x15] Transmit enable acknowledge flag
    $16 constant USART_REACK                    \ [0x16] Receive enable acknowledge flag
    $17 constant USART_TXFE                     \ [0x17] TXFIFO Empty
    $18 constant USART_RXFF                     \ [0x18] RXFIFO Full
    $19 constant USART_TCBGT                    \ [0x19] Transmission complete before guard time flag
    $1a constant USART_RXFT                     \ [0x1a] RXFIFO threshold flag
    $1b constant USART_TXFT                     \ [0x1b] TXFIFO threshold flag
  [then]


  [ifdef] USART_USART_ISR_ALTERNATE1_DEF
    \
    \ @brief USART interrupt and status register
    \ Address offset: 0x1C
    \ Reset value: 0x000000C0
    \
    $00 constant USART_PE                       \ [0x00] Parity error
    $01 constant USART_FE                       \ [0x01] Framing error
    $02 constant USART_NE                       \ [0x02] Noise detection flag
    $03 constant USART_ORE                      \ [0x03] Overrun error
    $04 constant USART_IDLE                     \ [0x04] Idle line detected
    $05 constant USART_RXNE                     \ [0x05] Read data register not empty
    $06 constant USART_TC                       \ [0x06] Transmission complete
    $07 constant USART_TXE                      \ [0x07] Transmit data register empty
    $08 constant USART_LBDF                     \ [0x08] LIN break detection flag
    $09 constant USART_CTSIF                    \ [0x09] CTS interrupt flag
    $0a constant USART_CTS                      \ [0x0a] CTS flag
    $0b constant USART_RTOF                     \ [0x0b] Receiver timeout
    $0c constant USART_EOBF                     \ [0x0c] End of block flag
    $0d constant USART_UDR                      \ [0x0d] SPI slave underrun error flag
    $0e constant USART_ABRE                     \ [0x0e] Auto baud rate error
    $0f constant USART_ABRF                     \ [0x0f] Auto baud rate flag
    $10 constant USART_BUSY                     \ [0x10] Busy flag
    $11 constant USART_CMF                      \ [0x11] Character match flag
    $12 constant USART_SBKF                     \ [0x12] Send break flag
    $13 constant USART_RWU                      \ [0x13] Receiver wake-up from mute mode
    $14 constant USART_WUF                      \ [0x14] Wake-up from low-power mode flag
    $15 constant USART_TEACK                    \ [0x15] Transmit enable acknowledge flag
    $16 constant USART_REACK                    \ [0x16] Receive enable acknowledge flag
    $19 constant USART_TCBGT                    \ [0x19] Transmission complete before guard time flag
  [then]


  [ifdef] USART_USART_ICR_DEF
    \
    \ @brief USART interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant USART_PECF                     \ [0x00] Parity error clear flag
    $01 constant USART_FECF                     \ [0x01] Framing error clear flag
    $02 constant USART_NECF                     \ [0x02] Noise detected clear flag
    $03 constant USART_ORECF                    \ [0x03] Overrun error clear flag
    $04 constant USART_IDLECF                   \ [0x04] Idle line detected clear flag
    $05 constant USART_TXFECF                   \ [0x05] TXFIFO empty clear flag
    $06 constant USART_TCCF                     \ [0x06] Transmission complete clear flag
    $07 constant USART_TCBGTCF                  \ [0x07] Transmission complete before Guard time clear flag
    $08 constant USART_LBDCF                    \ [0x08] LIN break detection clear flag
    $09 constant USART_CTSCF                    \ [0x09] CTS clear flag
    $0b constant USART_RTOCF                    \ [0x0b] Receiver timeout clear flag
    $0c constant USART_EOBCF                    \ [0x0c] End of block clear flag
    $0d constant USART_UDRCF                    \ [0x0d] SPI slave underrun clear flag
    $11 constant USART_CMCF                     \ [0x11] Character match clear flag
    $14 constant USART_WUCF                     \ [0x14] Wake-up from low-power mode clear flag
  [then]


  [ifdef] USART_USART_RDR_DEF
    \
    \ @brief USART receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant USART_RDR                      \ [0x00 : 9] Receive data value
  [then]


  [ifdef] USART_USART_TDR_DEF
    \
    \ @brief USART transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant USART_TDR                      \ [0x00 : 9] Transmit data value
  [then]


  [ifdef] USART_USART_PRESC_DEF
    \
    \ @brief USART prescaler register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant USART_PRESCALER                \ [0x00 : 4] Clock prescaler
  [then]

  \
  \ @brief USART address block description
  \
  $00 constant USART_USART_CR1          \ USART control register 1
  $00 constant USART_USART_CR1_ALTERNATE1    \ USART control register 1
  $04 constant USART_USART_CR2          \ USART control register 2
  $08 constant USART_USART_CR3          \ USART control register 3
  $08 constant USART_USART_CR3_ALTERNATE1    \ USART control register 3
  $0C constant USART_USART_BRR          \ USART baud rate register
  $10 constant USART_USART_GTPR         \ USART guard time and prescaler register
  $14 constant USART_USART_RTOR         \ USART receiver timeout register
  $18 constant USART_USART_RQR          \ USART request register
  $1C constant USART_USART_ISR          \ USART interrupt and status register
  $1C constant USART_USART_ISR_ALTERNATE1    \ USART interrupt and status register
  $20 constant USART_USART_ICR          \ USART interrupt flag clear register
  $24 constant USART_USART_RDR          \ USART receive data register
  $28 constant USART_USART_TDR          \ USART transmit data register
  $2C constant USART_USART_PRESC        \ USART prescaler register

: USART_DEF ; [then]
