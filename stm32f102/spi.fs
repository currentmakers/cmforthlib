\
\ @file spi.fs
\ @brief Serial peripheral interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI_DEF

  [ifdef] SPI_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI_CPHA                       \ [0x00] Clock phase
    $01 constant SPI_CPOL                       \ [0x01] Clock polarity
    $02 constant SPI_MSTR                       \ [0x02] Master selection
    $03 constant SPI_BR                         \ [0x03 : 3] Baud rate control
    $06 constant SPI_SPE                        \ [0x06] SPI enable
    $07 constant SPI_LSBFIRST                   \ [0x07] Frame format
    $08 constant SPI_SSI                        \ [0x08] Internal slave select
    $09 constant SPI_SSM                        \ [0x09] Software slave management
    $0a constant SPI_RXONLY                     \ [0x0a] Receive only
    $0b constant SPI_DFF                        \ [0x0b] Data frame format
    $0c constant SPI_CRCNEXT                    \ [0x0c] CRC transfer next
    $0d constant SPI_CRCEN                      \ [0x0d] Hardware CRC calculation enable
    $0e constant SPI_BIDIOE                     \ [0x0e] Output enable in bidirectional mode
    $0f constant SPI_BIDIMODE                   \ [0x0f] Bidirectional data mode enable
  [then]


  [ifdef] SPI_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXDMAEN                    \ [0x00] Rx buffer DMA enable
    $01 constant SPI_TXDMAEN                    \ [0x01] Tx buffer DMA enable
    $02 constant SPI_SSOE                       \ [0x02] SS output enable
    $05 constant SPI_ERRIE                      \ [0x05] Error interrupt enable
    $06 constant SPI_RXNEIE                     \ [0x06] RX buffer not empty interrupt enable
    $07 constant SPI_TXEIE                      \ [0x07] Tx buffer empty interrupt enable
  [then]


  [ifdef] SPI_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x08
    \ Reset value: 0x00000002
    \
    $00 constant SPI_RXNE                       \ [0x00] Receive buffer not empty
    $01 constant SPI_TXE                        \ [0x01] Transmit buffer empty
    $04 constant SPI_CRCERR                     \ [0x04] CRC error flag
    $05 constant SPI_MODF                       \ [0x05] Mode fault
    $06 constant SPI_OVR                        \ [0x06] Overrun flag
    $07 constant SPI_BSY                        \ [0x07] Busy flag
  [then]


  [ifdef] SPI_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_DR                         \ [0x00 : 16] Data register
  [then]


  [ifdef] SPI_CRCPR_DEF
    \
    \ @brief CRC polynomial register
    \ Address offset: 0x10
    \ Reset value: 0x00000007
    \
    $00 constant SPI_CRCPOLY                    \ [0x00 : 16] CRC polynomial register
  [then]


  [ifdef] SPI_RXCRCR_DEF
    \
    \ @brief RX CRC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RxCRC                      \ [0x00 : 16] Rx CRC register
  [then]


  [ifdef] SPI_TXCRCR_DEF
    \
    \ @brief TX CRC register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TxCRC                      \ [0x00 : 16] Tx CRC register
  [then]

  \
  \ @brief Serial peripheral interface
  \
  $00 constant SPI_CR1                  \ control register 1
  $04 constant SPI_CR2                  \ control register 2
  $08 constant SPI_SR                   \ status register
  $0C constant SPI_DR                   \ data register
  $10 constant SPI_CRCPR                \ CRC polynomial register
  $14 constant SPI_RXCRCR               \ RX CRC register
  $18 constant SPI_TXCRCR               \ TX CRC register

: SPI_DEF ; [then]
