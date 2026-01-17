\
\ @file usart.fs
\ @brief Universal synchronous asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USART_DEF

  [ifdef] USART_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USART_UE                       \ [0x00] USART enable
    $01 constant USART_UESM                     \ [0x01] USART enable in low-power mode
    $02 constant USART_RE                       \ [0x02] Receiver enable
    $03 constant USART_TE                       \ [0x03] Transmitter enable
    $04 constant USART_IDLEIE                   \ [0x04] IDLE interrupt enable
    $05 constant USART_RXNEIE                   \ [0x05] Receive data register not empty/RXFIFO not empty interrupt enable
    $06 constant USART_TCIE                     \ [0x06] Transmission complete interrupt enable
    $07 constant USART_TXEIE                    \ [0x07] Transmit data register empty/TXFIFO not full interrupt enable
    $08 constant USART_PEIE                     \ [0x08] PE interrupt enable
    $09 constant USART_PS                       \ [0x09] Parity selection
    $0a constant USART_PCE                      \ [0x0a] Parity control enable
    $0b constant USART_WAKE                     \ [0x0b] Receiver wakeup method
    $0c constant USART_M                        \ [0x0c] Word length
    $0d constant USART_MME                      \ [0x0d] Mute mode enable
    $0e constant USART_CMIE                     \ [0x0e] Character match interrupt enable
    $0f constant USART_OVER8                    \ [0x0f] Oversampling mode
    $10 constant USART_DEDT0                    \ [0x10] DEDT0
    $11 constant USART_DEDT1                    \ [0x11] DEDT1
    $12 constant USART_DEDT2                    \ [0x12] DEDT2
    $13 constant USART_DEDT3                    \ [0x13] DEDT3
    $14 constant USART_DEDT4                    \ [0x14] Driver Enable deassertion time
    $15 constant USART_DEAT0                    \ [0x15] DEAT0
    $16 constant USART_DEAT1                    \ [0x16] DEAT1
    $17 constant USART_DEAT2                    \ [0x17] DEAT2
    $18 constant USART_DEAT3                    \ [0x18] DEAT3
    $19 constant USART_DEAT4                    \ [0x19] Driver Enable assertion time
    $1a constant USART_RTOIE                    \ [0x1a] Receiver timeout interrupt enable
    $1b constant USART_EOBIE                    \ [0x1b] End of Block interrupt enable
    $1c constant USART_M1                       \ [0x1c] Word length
    $1d constant USART_FIFOEN                   \ [0x1d] FIFO mode enable
    $1e constant USART_TXFEIE                   \ [0x1e] TXFIFO empty interrupt enable
    $1f constant USART_RXFFIE                   \ [0x1f] RXFIFO Full interrupt enable
  [then]


  [ifdef] USART_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USART_SLVEN                    \ [0x00] Synchronous Slave mode enable
    $03 constant USART_DIS_NSS                  \ [0x03] DIS_NSS
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
    $15 constant USART_ABRMOD0                  \ [0x15] ABRMOD0
    $16 constant USART_ABRMOD1                  \ [0x16] Auto baud rate mode
    $17 constant USART_RTOEN                    \ [0x17] Receiver timeout enable
    $18 constant USART_ADD3_0                   \ [0x18 : 4] Address of the USART node
    $1c constant USART_ADD7_4                   \ [0x1c : 4] Address of the USART node
  [then]


  [ifdef] USART_CR3_DEF
    \
    \ @brief control register 3
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
    $0c constant USART_OVRDIS                   \ [0x0c] OVRDIS: Overrun Disable
    $0d constant USART_DDRE                     \ [0x0d] DMA Disable on Reception Error
    $0e constant USART_DEM                      \ [0x0e] Driver enable mode
    $0f constant USART_DEP                      \ [0x0f] Driver enable polarity selection
    $11 constant USART_SCARCNT2_0               \ [0x11 : 3] Smartcard auto-retry count
    $14 constant USART_WUS                      \ [0x14 : 2] Wakeup from low-power mode interrupt flag selection
    $16 constant USART_WUFIE                    \ [0x16] Wakeup from low-power mode interrupt enable
    $17 constant USART_TXFTIE                   \ [0x17] TXFIFO threshold interrupt enable
    $18 constant USART_TCBGTIE                  \ [0x18] Transmission Complete before guard time, interrupt enable
    $19 constant USART_RXFTCFG                  \ [0x19 : 3] Receive FIFO threshold configuration
    $1c constant USART_RXFTIE                   \ [0x1c] RXFIFO threshold interrupt enable
    $1d constant USART_TXFTCFG                  \ [0x1d : 3] TXFIFO threshold configuration
  [then]


  [ifdef] USART_BRR_DEF
    \
    \ @brief baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USART_BRR                      \ [0x00 : 16] BRR
  [then]


  [ifdef] USART_GTPR_DEF
    \
    \ @brief guard time and prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USART_PSC                      \ [0x00 : 8] Prescaler value
    $08 constant USART_GT                       \ [0x08 : 8] Guard time value
  [then]


  [ifdef] USART_RTOR_DEF
    \
    \ @brief receiver timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USART_RTO                      \ [0x00 : 24] Receiver timeout value
    $18 constant USART_BLEN                     \ [0x18 : 8] Block Length
  [then]


  [ifdef] USART_RQR_DEF
    \
    \ @brief request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USART_ABRRQ                    \ [0x00] Auto baud rate request
    $01 constant USART_SBKRQ                    \ [0x01] Send break request
    $02 constant USART_MMRQ                     \ [0x02] Mute mode request
    $03 constant USART_RXFRQ                    \ [0x03] Receive data flush request
    $04 constant USART_TXFRQ                    \ [0x04] Transmit data flush request
  [then]


  [ifdef] USART_ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USART_PE                       \ [0x00] PE
    $01 constant USART_FE                       \ [0x01] FE
    $02 constant USART_NE                       \ [0x02] NE
    $03 constant USART_ORE                      \ [0x03] ORE
    $04 constant USART_IDLE                     \ [0x04] IDLE
    $05 constant USART_RXNE                     \ [0x05] RXNE
    $06 constant USART_TC                       \ [0x06] TC
    $07 constant USART_TXE                      \ [0x07] TXE
    $08 constant USART_LBDF                     \ [0x08] LBDF
    $09 constant USART_CTSIF                    \ [0x09] CTSIF
    $0a constant USART_CTS                      \ [0x0a] CTS
    $0b constant USART_RTOF                     \ [0x0b] RTOF
    $0c constant USART_EOBF                     \ [0x0c] EOBF
    $0d constant USART_UDR                      \ [0x0d] UDR
    $0e constant USART_ABRE                     \ [0x0e] ABRE
    $0f constant USART_ABRF                     \ [0x0f] ABRF
    $10 constant USART_BUSY                     \ [0x10] BUSY
    $11 constant USART_CMF                      \ [0x11] CMF
    $12 constant USART_SBKF                     \ [0x12] SBKF
    $13 constant USART_RWU                      \ [0x13] RWU
    $14 constant USART_WUF                      \ [0x14] WUF
    $15 constant USART_TEACK                    \ [0x15] TEACK
    $16 constant USART_REACK                    \ [0x16] REACK
    $17 constant USART_TXFE                     \ [0x17] TXFE
    $18 constant USART_RXFF                     \ [0x18] RXFF
    $19 constant USART_TCBGT                    \ [0x19] TCBGT
    $1a constant USART_RXFT                     \ [0x1a] RXFT
    $1b constant USART_TXFT                     \ [0x1b] TXFT
  [then]


  [ifdef] USART_ICR_DEF
    \
    \ @brief interrupt flag clear register
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
    $14 constant USART_WUCF                     \ [0x14] Wakeup from low-power mode clear flag
  [then]


  [ifdef] USART_RDR_DEF
    \
    \ @brief receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant USART_RDR                      \ [0x00 : 9] Receive data value
  [then]


  [ifdef] USART_TDR_DEF
    \
    \ @brief transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant USART_TDR                      \ [0x00 : 9] Transmit data value
  [then]


  [ifdef] USART_PRESC_DEF
    \
    \ @brief prescaler register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant USART_PRESCALER                \ [0x00 : 4] Clock prescaler
  [then]

  \
  \ @brief Universal synchronous asynchronous receiver transmitter
  \
  $00 constant USART_CR1                \ control register 1
  $04 constant USART_CR2                \ control register 2
  $08 constant USART_CR3                \ control register 3
  $0C constant USART_BRR                \ baud rate register
  $10 constant USART_GTPR               \ guard time and prescaler register
  $14 constant USART_RTOR               \ receiver timeout register
  $18 constant USART_RQR                \ request register
  $1C constant USART_ISR                \ interrupt and status register
  $20 constant USART_ICR                \ interrupt flag clear register
  $24 constant USART_RDR                \ receive data register
  $28 constant USART_TDR                \ transmit data register
  $2C constant USART_PRESC              \ prescaler register

: USART_DEF ; [then]
