\
\ @file uart.fs
\ @brief Universal asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] UART_DEF

  [ifdef] UART_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant UART_PE                        \ [0x00] Parity error
    $01 constant UART_FE                        \ [0x01] Framing error
    $02 constant UART_NE                        \ [0x02] Noise error flag
    $03 constant UART_ORE                       \ [0x03] Overrun error
    $04 constant UART_IDLE                      \ [0x04] IDLE line detected
    $05 constant UART_RXNE                      \ [0x05] Read data register not empty
    $06 constant UART_TC                        \ [0x06] Transmission complete
    $07 constant UART_TXE                       \ [0x07] Transmit data register empty
    $08 constant UART_LBD                       \ [0x08] LIN break detection flag
  [then]


  [ifdef] UART_DR_DEF
    \
    \ @brief Data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant UART_DR                        \ [0x00 : 9] DR
  [then]


  [ifdef] UART_BRR_DEF
    \
    \ @brief Baud rate register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant UART_DIV_Fraction              \ [0x00 : 4] DIV_Fraction
    $04 constant UART_DIV_Mantissa              \ [0x04 : 12] DIV_Mantissa
  [then]


  [ifdef] UART_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant UART_SBK                       \ [0x00] Send break
    $01 constant UART_RWU                       \ [0x01] Receiver wakeup
    $02 constant UART_RE                        \ [0x02] Receiver enable
    $03 constant UART_TE                        \ [0x03] Transmitter enable
    $04 constant UART_IDLEIE                    \ [0x04] IDLE interrupt enable
    $05 constant UART_RXNEIE                    \ [0x05] RXNE interrupt enable
    $06 constant UART_TCIE                      \ [0x06] Transmission complete interrupt enable
    $07 constant UART_TXEIE                     \ [0x07] TXE interrupt enable
    $08 constant UART_PEIE                      \ [0x08] PE interrupt enable
    $09 constant UART_PS                        \ [0x09] Parity selection
    $0a constant UART_PCE                       \ [0x0a] Parity control enable
    $0b constant UART_WAKE                      \ [0x0b] Wakeup method
    $0c constant UART_M                         \ [0x0c] Word length
    $0d constant UART_UE                        \ [0x0d] USART enable
  [then]


  [ifdef] UART_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant UART_ADD                       \ [0x00 : 4] Address of the USART node
    $05 constant UART_LBDL                      \ [0x05] lin break detection length
    $06 constant UART_LBDIE                     \ [0x06] LIN break detection interrupt enable
    $0c constant UART_STOP                      \ [0x0c : 2] STOP bits
    $0e constant UART_LINEN                     \ [0x0e] LIN mode enable
  [then]


  [ifdef] UART_CR3_DEF
    \
    \ @brief Control register 3
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant UART_EIE                       \ [0x00] Error interrupt enable
    $01 constant UART_IREN                      \ [0x01] IrDA mode enable
    $02 constant UART_IRLP                      \ [0x02] IrDA low-power
    $03 constant UART_HDSEL                     \ [0x03] Half-duplex selection
    $06 constant UART_DMAR                      \ [0x06] DMA enable receiver
    $07 constant UART_DMAT                      \ [0x07] DMA enable transmitter
  [then]

  \
  \ @brief Universal asynchronous receiver transmitter
  \
  $00 constant UART_SR                  \ Status register
  $04 constant UART_DR                  \ Data register
  $08 constant UART_BRR                 \ Baud rate register
  $0C constant UART_CR1                 \ Control register 1
  $10 constant UART_CR2                 \ Control register 2
  $14 constant UART_CR3                 \ Control register 3

: UART_DEF ; [then]
