\
\ @file uart4.fs
\ @brief Universal asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] UART4_DEF

  [ifdef] UART4_SR_DEF
    \
    \ @brief UART4 SR
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant UART4_PE                       \ [0x00] Parity error
    $01 constant UART4_FE                       \ [0x01] Framing error
    $02 constant UART4_NE                       \ [0x02] Noise error flag
    $03 constant UART4_ORE                      \ [0x03] Overrun error
    $04 constant UART4_IDLE                     \ [0x04] IDLE line detected
    $05 constant UART4_RXNE                     \ [0x05] Read data register not empty
    $06 constant UART4_TC                       \ [0x06] Transmission complete
    $07 constant UART4_TXE                      \ [0x07] Transmit data register empty
    $08 constant UART4_LBD                      \ [0x08] LIN break detection flag
  [then]


  [ifdef] UART4_DR_DEF
    \
    \ @brief UART4 DR
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant UART4_DR                       \ [0x00 : 9] DR
  [then]


  [ifdef] UART4_BRR_DEF
    \
    \ @brief UART4 BRR
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant UART4_DIV_Fraction             \ [0x00 : 4] DIV_Fraction
    $04 constant UART4_DIV_Mantissa             \ [0x04 : 12] DIV_Mantissa
  [then]


  [ifdef] UART4_CR1_DEF
    \
    \ @brief UART4 CR1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant UART4_SBK                      \ [0x00] Send break
    $01 constant UART4_RWU                      \ [0x01] Receiver wakeup
    $02 constant UART4_RE                       \ [0x02] Receiver enable
    $03 constant UART4_TE                       \ [0x03] Transmitter enable
    $04 constant UART4_IDLEIE                   \ [0x04] IDLE interrupt enable
    $05 constant UART4_RXNEIE                   \ [0x05] RXNE interrupt enable
    $06 constant UART4_TCIE                     \ [0x06] Transmission complete interrupt enable
    $07 constant UART4_TXEIE                    \ [0x07] TXE interrupt enable
    $08 constant UART4_PEIE                     \ [0x08] PE interrupt enable
    $09 constant UART4_PS                       \ [0x09] Parity selection
    $0a constant UART4_PCE                      \ [0x0a] Parity control enable
    $0b constant UART4_WAKE                     \ [0x0b] Wakeup method
    $0c constant UART4_M                        \ [0x0c] Word length
    $0d constant UART4_UE                       \ [0x0d] USART enable
  [then]


  [ifdef] UART4_CR2_DEF
    \
    \ @brief UART4 CR2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant UART4_ADD                      \ [0x00 : 4] Address of the USART node
    $05 constant UART4_LBDL                     \ [0x05] lin break detection length
    $06 constant UART4_LBDIE                    \ [0x06] LIN break detection interrupt enable
    $0c constant UART4_STOP                     \ [0x0c : 2] STOP bits
    $0e constant UART4_LINEN                    \ [0x0e] LIN mode enable
  [then]


  [ifdef] UART4_CR3_DEF
    \
    \ @brief UART4 CR3
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant UART4_EIE                      \ [0x00] Error interrupt enable
    $01 constant UART4_IREN                     \ [0x01] IrDA mode enable
    $02 constant UART4_IRLP                     \ [0x02] IrDA low-power
    $03 constant UART4_HDSEL                    \ [0x03] Half-duplex selection
    $06 constant UART4_DMAR                     \ [0x06] DMA enable receiver
    $07 constant UART4_DMAT                     \ [0x07] DMA enable transmitter
  [then]

  \
  \ @brief Universal asynchronous receiver transmitter
  \
  $00 constant UART4_SR                 \ UART4 SR
  $04 constant UART4_DR                 \ UART4 DR
  $08 constant UART4_BRR                \ UART4 BRR
  $0C constant UART4_CR1                \ UART4 CR1
  $10 constant UART4_CR2                \ UART4 CR2
  $14 constant UART4_CR3                \ UART4 CR3

: UART4_DEF ; [then]
