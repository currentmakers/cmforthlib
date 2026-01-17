\
\ @file swpmi1.fs
\ @brief Single Wire Protocol Master Interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SWPMI1_DEF

  [ifdef] SWPMI1_CR_DEF
    \
    \ @brief SWPMI Configuration/Control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SWPMI1_RXDMA                   \ [0x00] Reception DMA enable
    $01 constant SWPMI1_TXDMA                   \ [0x01] Transmission DMA enable
    $02 constant SWPMI1_RXMODE                  \ [0x02] Reception buffering mode
    $03 constant SWPMI1_TXMODE                  \ [0x03] Transmission buffering mode
    $04 constant SWPMI1_LPBK                    \ [0x04] Loopback mode enable
    $05 constant SWPMI1_SWPME                   \ [0x05] Single wire protocol master interface enable
    $0a constant SWPMI1_DEACT                   \ [0x0a] Single wire protocol master interface deactivate
  [then]


  [ifdef] SWPMI1_BRR_DEF
    \
    \ @brief SWPMI Bitrate register
    \ Address offset: 0x04
    \ Reset value: 0x00000001
    \
    $00 constant SWPMI1_BR                      \ [0x00 : 6] Bitrate prescaler
  [then]


  [ifdef] SWPMI1_ISR_DEF
    \
    \ @brief SWPMI Interrupt and Status register
    \ Address offset: 0x0C
    \ Reset value: 0x000002C2
    \
    $00 constant SWPMI1_RXBFF                   \ [0x00] Receive buffer full flag
    $01 constant SWPMI1_TXBEF                   \ [0x01] Transmit buffer empty flag
    $02 constant SWPMI1_RXBERF                  \ [0x02] Receive CRC error flag
    $03 constant SWPMI1_RXOVRF                  \ [0x03] Receive overrun error flag
    $04 constant SWPMI1_TXUNRF                  \ [0x04] Transmit underrun error flag
    $05 constant SWPMI1_RXNE                    \ [0x05] Receive data register not empty
    $06 constant SWPMI1_TXE                     \ [0x06] Transmit data register empty
    $07 constant SWPMI1_TCF                     \ [0x07] Transfer complete flag
    $08 constant SWPMI1_SRF                     \ [0x08] Slave resume flag
    $09 constant SWPMI1_SUSP                    \ [0x09] SUSPEND flag
    $0a constant SWPMI1_DEACTF                  \ [0x0a] DEACTIVATED flag
  [then]


  [ifdef] SWPMI1_ICR_DEF
    \
    \ @brief SWPMI Interrupt Flag Clear register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SWPMI1_CRXBFF                  \ [0x00] Clear receive buffer full flag
    $01 constant SWPMI1_CTXBEF                  \ [0x01] Clear transmit buffer empty flag
    $02 constant SWPMI1_CRXBERF                 \ [0x02] Clear receive CRC error flag
    $03 constant SWPMI1_CRXOVRF                 \ [0x03] Clear receive overrun error flag
    $04 constant SWPMI1_CTXUNRF                 \ [0x04] Clear transmit underrun error flag
    $07 constant SWPMI1_CTCF                    \ [0x07] Clear transfer complete flag
    $08 constant SWPMI1_CSRF                    \ [0x08] Clear slave resume flag
  [then]


  [ifdef] SWPMI1_IER_DEF
    \
    \ @brief SWPMI Interrupt Enable register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SWPMI1_RXBFIE                  \ [0x00] Receive buffer full interrupt enable
    $01 constant SWPMI1_TXBEIE                  \ [0x01] Transmit buffer empty interrupt enable
    $02 constant SWPMI1_RXBERIE                 \ [0x02] Receive CRC error interrupt enable
    $03 constant SWPMI1_RXOVRIE                 \ [0x03] Receive overrun error interrupt enable
    $04 constant SWPMI1_TXUNRIE                 \ [0x04] Transmit underrun error interrupt enable
    $05 constant SWPMI1_RIE                     \ [0x05] Receive interrupt enable
    $06 constant SWPMI1_TIE                     \ [0x06] Transmit interrupt enable
    $07 constant SWPMI1_TCIE                    \ [0x07] Transmit complete interrupt enable
    $08 constant SWPMI1_SRIE                    \ [0x08] Slave resume interrupt enable
  [then]


  [ifdef] SWPMI1_RFL_DEF
    \
    \ @brief SWPMI Receive Frame Length register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SWPMI1_RFL                     \ [0x00 : 5] Receive frame length
  [then]


  [ifdef] SWPMI1_TDR_DEF
    \
    \ @brief SWPMI Transmit data register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SWPMI1_TD                      \ [0x00 : 32] Transmit data
  [then]


  [ifdef] SWPMI1_RDR_DEF
    \
    \ @brief SWPMI Receive data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SWPMI1_RD                      \ [0x00 : 32] received data
  [then]


  [ifdef] SWPMI1_OR_DEF
    \
    \ @brief SWPMI Option register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SWPMI1_SWP_TBYP                \ [0x00] SWP transceiver bypass
    $01 constant SWPMI1_SWP_CLASS               \ [0x01] SWP class selection
  [then]

  \
  \ @brief Single Wire Protocol Master Interface
  \
  $00 constant SWPMI1_CR                \ SWPMI Configuration/Control register
  $04 constant SWPMI1_BRR               \ SWPMI Bitrate register
  $0C constant SWPMI1_ISR               \ SWPMI Interrupt and Status register
  $10 constant SWPMI1_ICR               \ SWPMI Interrupt Flag Clear register
  $14 constant SWPMI1_IER               \ SWPMI Interrupt Enable register
  $18 constant SWPMI1_RFL               \ SWPMI Receive Frame Length register
  $1C constant SWPMI1_TDR               \ SWPMI Transmit data register
  $20 constant SWPMI1_RDR               \ SWPMI Receive data register
  $24 constant SWPMI1_OR                \ SWPMI Option register

: SWPMI1_DEF ; [then]
