\
\ @file usart3.fs
\ @brief Universal synchronous asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USART3_DEF

  [ifdef] USART3_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x00
    \ Reset value: 0x00C00000
    \
    $00 constant USART3_PE                      \ [0x00] Parity error
    $01 constant USART3_FE                      \ [0x01] Framing error
    $02 constant USART3_NF                      \ [0x02] Noise detected flag
    $03 constant USART3_ORE                     \ [0x03] Overrun error
    $04 constant USART3_IDLE                    \ [0x04] IDLE line detected
    $05 constant USART3_RXNE                    \ [0x05] Read data register not empty
    $06 constant USART3_TC                      \ [0x06] Transmission complete
    $07 constant USART3_TXE                     \ [0x07] Transmit data register empty
    $08 constant USART3_LBD                     \ [0x08] LIN break detection flag
    $09 constant USART3_CTS                     \ [0x09] CTS flag
  [then]


  [ifdef] USART3_DR_DEF
    \
    \ @brief Data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USART3_DR                      \ [0x00 : 9] Data value
  [then]


  [ifdef] USART3_BRR_DEF
    \
    \ @brief Baud rate register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USART3_DIV_Fraction            \ [0x00 : 4] fraction of USARTDIV
    $04 constant USART3_DIV_Mantissa            \ [0x04 : 12] mantissa of USARTDIV
  [then]


  [ifdef] USART3_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USART3_SBK                     \ [0x00] Send break
    $01 constant USART3_RWU                     \ [0x01] Receiver wakeup
    $02 constant USART3_RE                      \ [0x02] Receiver enable
    $03 constant USART3_TE                      \ [0x03] Transmitter enable
    $04 constant USART3_IDLEIE                  \ [0x04] IDLE interrupt enable
    $05 constant USART3_RXNEIE                  \ [0x05] RXNE interrupt enable
    $06 constant USART3_TCIE                    \ [0x06] Transmission complete interrupt enable
    $07 constant USART3_TXEIE                   \ [0x07] TXE interrupt enable
    $08 constant USART3_PEIE                    \ [0x08] PE interrupt enable
    $09 constant USART3_PS                      \ [0x09] Parity selection
    $0a constant USART3_PCE                     \ [0x0a] Parity control enable
    $0b constant USART3_WAKE                    \ [0x0b] Wakeup method
    $0c constant USART3_M                       \ [0x0c] Word length
    $0d constant USART3_UE                      \ [0x0d] USART enable
    $0f constant USART3_OVER8                   \ [0x0f] Oversampling mode
  [then]


  [ifdef] USART3_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USART3_ADD                     \ [0x00 : 4] Address of the USART node
    $05 constant USART3_LBDL                    \ [0x05] lin break detection length
    $06 constant USART3_LBDIE                   \ [0x06] LIN break detection interrupt enable
    $08 constant USART3_LBCL                    \ [0x08] Last bit clock pulse
    $09 constant USART3_CPHA                    \ [0x09] Clock phase
    $0a constant USART3_CPOL                    \ [0x0a] Clock polarity
    $0b constant USART3_CLKEN                   \ [0x0b] Clock enable
    $0c constant USART3_STOP                    \ [0x0c : 2] STOP bits
    $0e constant USART3_LINEN                   \ [0x0e] LIN mode enable
  [then]


  [ifdef] USART3_CR3_DEF
    \
    \ @brief Control register 3
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USART3_EIE                     \ [0x00] Error interrupt enable
    $01 constant USART3_IREN                    \ [0x01] IrDA mode enable
    $02 constant USART3_IRLP                    \ [0x02] IrDA low-power
    $03 constant USART3_HDSEL                   \ [0x03] Half-duplex selection
    $04 constant USART3_NACK                    \ [0x04] Smartcard NACK enable
    $05 constant USART3_SCEN                    \ [0x05] Smartcard mode enable
    $06 constant USART3_DMAR                    \ [0x06] DMA enable receiver
    $07 constant USART3_DMAT                    \ [0x07] DMA enable transmitter
    $08 constant USART3_RTSE                    \ [0x08] RTS enable
    $09 constant USART3_CTSE                    \ [0x09] CTS enable
    $0a constant USART3_CTSIE                   \ [0x0a] CTS interrupt enable
    $0b constant USART3_ONEBIT                  \ [0x0b] One sample bit method enable
  [then]


  [ifdef] USART3_GTPR_DEF
    \
    \ @brief Guard time and prescaler register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USART3_PSC                     \ [0x00 : 8] Prescaler value
    $08 constant USART3_GT                      \ [0x08 : 8] Guard time value
  [then]

  \
  \ @brief Universal synchronous asynchronous receiver transmitter
  \
  $00 constant USART3_SR                \ Status register
  $04 constant USART3_DR                \ Data register
  $08 constant USART3_BRR               \ Baud rate register
  $0C constant USART3_CR1               \ Control register 1
  $10 constant USART3_CR2               \ Control register 2
  $14 constant USART3_CR3               \ Control register 3
  $18 constant USART3_GTPR              \ Guard time and prescaler register

: USART3_DEF ; [then]
