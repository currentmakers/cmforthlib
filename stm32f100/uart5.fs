\
\ @file uart5.fs
\ @brief Universal asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] UART5_DEF

  [ifdef] UART5_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant UART5_PE                       \ [0x00] PE
    $01 constant UART5_FE                       \ [0x01] FE
    $02 constant UART5_NE                       \ [0x02] NE
    $03 constant UART5_ORE                      \ [0x03] ORE
    $04 constant UART5_IDLE                     \ [0x04] IDLE
    $05 constant UART5_RXNE                     \ [0x05] RXNE
    $06 constant UART5_TC                       \ [0x06] TC
    $07 constant UART5_TXE                      \ [0x07] TXE
    $08 constant UART5_LBD                      \ [0x08] LBD
  [then]


  [ifdef] UART5_DR_DEF
    \
    \ @brief Data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant UART5_DR                       \ [0x00 : 9] DR
  [then]


  [ifdef] UART5_BRR_DEF
    \
    \ @brief Baud rate register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant UART5_DIV_Fraction             \ [0x00 : 4] DIV_Fraction
    $04 constant UART5_DIV_Mantissa             \ [0x04 : 12] DIV_Mantissa
  [then]


  [ifdef] UART5_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant UART5_SBK                      \ [0x00] SBK
    $01 constant UART5_RWU                      \ [0x01] RWU
    $02 constant UART5_RE                       \ [0x02] RE
    $03 constant UART5_TE                       \ [0x03] TE
    $04 constant UART5_IDLEIE                   \ [0x04] IDLEIE
    $05 constant UART5_RXNEIE                   \ [0x05] RXNEIE
    $06 constant UART5_TCIE                     \ [0x06] TCIE
    $07 constant UART5_TXEIE                    \ [0x07] TXEIE
    $08 constant UART5_PEIE                     \ [0x08] PEIE
    $09 constant UART5_PS                       \ [0x09] PS
    $0a constant UART5_PCE                      \ [0x0a] PCE
    $0b constant UART5_WAKE                     \ [0x0b] WAKE
    $0c constant UART5_M                        \ [0x0c] M
    $0d constant UART5_UE                       \ [0x0d] UE
  [then]


  [ifdef] UART5_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant UART5_ADD                      \ [0x00 : 4] ADD
    $05 constant UART5_LBDL                     \ [0x05] LBDL
    $06 constant UART5_LBDIE                    \ [0x06] LBDIE
    $0c constant UART5_STOP                     \ [0x0c : 2] STOP
    $0e constant UART5_LINEN                    \ [0x0e] LINEN
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
    $07 constant UART5_DMAT                     \ [0x07] DMA enable transmitter
  [then]

  \
  \ @brief Universal asynchronous receiver transmitter
  \
  $00 constant UART5_SR                 \ Status register
  $04 constant UART5_DR                 \ Data register
  $08 constant UART5_BRR                \ Baud rate register
  $0C constant UART5_CR1                \ Control register 1
  $10 constant UART5_CR2                \ Control register 2
  $14 constant UART5_CR3                \ Control register 3

: UART5_DEF ; [then]
