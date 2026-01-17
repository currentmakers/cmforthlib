\
\ @file uart5.fs
\ @brief Universal synchronous asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] UART5_DEF

  [ifdef] UART5_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x00
    \ Reset value: 0x000000C0
    \
    $00 constant UART5_PE                       \ [0x00] Parity error
    $01 constant UART5_FE                       \ [0x01] Framing error
    $02 constant UART5_NF                       \ [0x02] Noise detected flag
    $03 constant UART5_ORE                      \ [0x03] Overrun error
    $04 constant UART5_IDLE                     \ [0x04] IDLE line detected
    $05 constant UART5_RXNE                     \ [0x05] Read data register not empty
    $06 constant UART5_TC                       \ [0x06] Transmission complete
    $07 constant UART5_TXE                      \ [0x07] Transmit data register empty
    $08 constant UART5_LBD                      \ [0x08] LIN break detection flag
  [then]


  [ifdef] UART5_DR_DEF
    \
    \ @brief Data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant UART5_DR                       \ [0x00 : 9] Data value
  [then]


  [ifdef] UART5_BRR_DEF
    \
    \ @brief Baud rate register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant UART5_DIV_Fraction             \ [0x00 : 4] fraction of USARTDIV
    $04 constant UART5_DIV_Mantissa             \ [0x04 : 12] mantissa of USARTDIV
  [then]


  [ifdef] UART5_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant UART5_SBK                      \ [0x00] Send break
    $01 constant UART5_RWU                      \ [0x01] Receiver wakeup
    $02 constant UART5_RE                       \ [0x02] Receiver enable
    $03 constant UART5_TE                       \ [0x03] Transmitter enable
    $04 constant UART5_IDLEIE                   \ [0x04] IDLE interrupt enable
    $05 constant UART5_RXNEIE                   \ [0x05] RXNE interrupt enable
    $06 constant UART5_TCIE                     \ [0x06] Transmission complete interrupt enable
    $07 constant UART5_TXEIE                    \ [0x07] TXE interrupt enable
    $08 constant UART5_PEIE                     \ [0x08] PE interrupt enable
    $09 constant UART5_PS                       \ [0x09] Parity selection
    $0a constant UART5_PCE                      \ [0x0a] Parity control enable
    $0b constant UART5_WAKE                     \ [0x0b] Wakeup method
    $0c constant UART5_M                        \ [0x0c] Word length
    $0d constant UART5_UE                       \ [0x0d] USART enable
    $0f constant UART5_OVER8                    \ [0x0f] Oversampling mode
  [then]


  [ifdef] UART5_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant UART5_ADD                      \ [0x00 : 4] Address of the USART node
    $05 constant UART5_LBDL                     \ [0x05] lin break detection length
    $06 constant UART5_LBDIE                    \ [0x06] LIN break detection interrupt enable
    $0c constant UART5_STOP                     \ [0x0c : 2] STOP bits
    $0e constant UART5_LINEN                    \ [0x0e] LIN mode enable
  [then]


  [ifdef] UART5_CR3_DEF
    \
    \ @brief Control register 3
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant UART5_EIE                      \ [0x00] Error interrupt enable
    $01 constant UART5_IREN                     \ [0x01] IrDA mode enable
    $02 constant UART5_IRLP                     \ [0x02] IrDA low-power
    $03 constant UART5_HDSEL                    \ [0x03] Half-duplex selection
    $0b constant UART5_ONEBIT                   \ [0x0b] One sample bit method enable
  [then]

  \
  \ @brief Universal synchronous asynchronous receiver transmitter
  \
  $00 constant UART5_SR                 \ Status register
  $04 constant UART5_DR                 \ Data register
  $08 constant UART5_BRR                \ Baud rate register
  $0C constant UART5_CR1                \ Control register 1
  $10 constant UART5_CR2                \ Control register 2
  $14 constant UART5_CR3                \ Control register 3

: UART5_DEF ; [then]
