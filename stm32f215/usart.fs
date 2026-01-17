\
\ @file usart.fs
\ @brief Universal synchronous asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USART_DEF

  [ifdef] USART_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x00
    \ Reset value: 0x000000C0
    \
    $00 constant USART_PE                       \ [0x00] Parity error
    $01 constant USART_FE                       \ [0x01] Framing error
    $02 constant USART_NF                       \ [0x02] Noise detected flag
    $03 constant USART_ORE                      \ [0x03] Overrun error
    $04 constant USART_IDLE                     \ [0x04] IDLE line detected
    $05 constant USART_RXNE                     \ [0x05] Read data register not empty
    $06 constant USART_TC                       \ [0x06] Transmission complete
    $07 constant USART_TXE                      \ [0x07] Transmit data register empty
    $08 constant USART_LBD                      \ [0x08] LIN break detection flag
    $09 constant USART_CTS                      \ [0x09] CTS flag
  [then]


  [ifdef] USART_DR_DEF
    \
    \ @brief Data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USART_DR                       \ [0x00 : 9] Data value
  [then]


  [ifdef] USART_BRR_DEF
    \
    \ @brief Baud rate register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USART_DIV_Fraction             \ [0x00 : 4] fraction of USARTDIV
    $04 constant USART_DIV_Mantissa             \ [0x04 : 12] mantissa of USARTDIV
  [then]


  [ifdef] USART_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USART_SBK                      \ [0x00] Send break
    $01 constant USART_RWU                      \ [0x01] Receiver wakeup
    $02 constant USART_RE                       \ [0x02] Receiver enable
    $03 constant USART_TE                       \ [0x03] Transmitter enable
    $04 constant USART_IDLEIE                   \ [0x04] IDLE interrupt enable
    $05 constant USART_RXNEIE                   \ [0x05] RXNE interrupt enable
    $06 constant USART_TCIE                     \ [0x06] Transmission complete interrupt enable
    $07 constant USART_TXEIE                    \ [0x07] TXE interrupt enable
    $08 constant USART_PEIE                     \ [0x08] PE interrupt enable
    $09 constant USART_PS                       \ [0x09] Parity selection
    $0a constant USART_PCE                      \ [0x0a] Parity control enable
    $0b constant USART_WAKE                     \ [0x0b] Wakeup method
    $0c constant USART_M                        \ [0x0c] Word length
    $0d constant USART_UE                       \ [0x0d] USART enable
    $0f constant USART_OVER8                    \ [0x0f] Oversampling mode
  [then]


  [ifdef] USART_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USART_ADD                      \ [0x00 : 4] Address of the USART node
    $05 constant USART_LBDL                     \ [0x05] lin break detection length
    $06 constant USART_LBDIE                    \ [0x06] LIN break detection interrupt enable
    $08 constant USART_LBCL                     \ [0x08] Last bit clock pulse
    $09 constant USART_CPHA                     \ [0x09] Clock phase
    $0a constant USART_CPOL                     \ [0x0a] Clock polarity
    $0b constant USART_CLKEN                    \ [0x0b] Clock enable
    $0c constant USART_STOP                     \ [0x0c : 2] STOP bits
    $0e constant USART_LINEN                    \ [0x0e] LIN mode enable
  [then]


  [ifdef] USART_CR3_DEF
    \
    \ @brief Control register 3
    \ Address offset: 0x14
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
  [then]


  [ifdef] USART_GTPR_DEF
    \
    \ @brief Guard time and prescaler register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USART_PSC                      \ [0x00 : 8] Prescaler value
    $08 constant USART_GT                       \ [0x08 : 8] Guard time value
  [then]

  \
  \ @brief Universal synchronous asynchronous receiver transmitter
  \
  $00 constant USART_SR                 \ Status register
  $04 constant USART_DR                 \ Data register
  $08 constant USART_BRR                \ Baud rate register
  $0C constant USART_CR1                \ Control register 1
  $10 constant USART_CR2                \ Control register 2
  $14 constant USART_CR3                \ Control register 3
  $18 constant USART_GTPR               \ Guard time and prescaler register

: USART_DEF ; [then]
