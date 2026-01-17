\
\ @file spi3.fs
\ @brief Serial peripheral interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI3_DEF

  [ifdef] SPI3_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_CPHA                      \ [0x00] Clock phase
    $01 constant SPI3_CPOL                      \ [0x01] Clock polarity
    $02 constant SPI3_MSTR                      \ [0x02] Master selection
    $03 constant SPI3_BR                        \ [0x03 : 3] Baud rate control
    $06 constant SPI3_SPE                       \ [0x06] SPI enable
    $07 constant SPI3_LSBFIRST                  \ [0x07] Frame format
    $08 constant SPI3_SSI                       \ [0x08] Internal slave select
    $09 constant SPI3_SSM                       \ [0x09] Software slave management
    $0a constant SPI3_RXONLY                    \ [0x0a] Receive only
    $0b constant SPI3_CRCL                      \ [0x0b] CRC length
    $0c constant SPI3_CRCNEXT                   \ [0x0c] CRC transfer next
    $0d constant SPI3_CRCEN                     \ [0x0d] Hardware CRC calculation enable
    $0e constant SPI3_BIDIOE                    \ [0x0e] Output enable in bidirectional mode
    $0f constant SPI3_BIDIMODE                  \ [0x0f] Bidirectional data mode enable
  [then]


  [ifdef] SPI3_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000700
    \
    $00 constant SPI3_RXDMAEN                   \ [0x00] Rx buffer DMA enable
    $01 constant SPI3_TXDMAEN                   \ [0x01] Tx buffer DMA enable
    $02 constant SPI3_SSOE                      \ [0x02] SS output enable
    $03 constant SPI3_NSSP                      \ [0x03] NSS pulse management
    $04 constant SPI3_FRF                       \ [0x04] Frame format
    $05 constant SPI3_ERRIE                     \ [0x05] Error interrupt enable
    $06 constant SPI3_RXNEIE                    \ [0x06] RX buffer not empty interrupt enable
    $07 constant SPI3_TXEIE                     \ [0x07] Tx buffer empty interrupt enable
    $08 constant SPI3_DS                        \ [0x08 : 4] Data size
    $0c constant SPI3_FRXTH                     \ [0x0c] FIFO reception threshold
    $0d constant SPI3_LDMA_RX                   \ [0x0d] Last DMA transfer for reception
    $0e constant SPI3_LDMA_TX                   \ [0x0e] Last DMA transfer for transmission
  [then]


  [ifdef] SPI3_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x08
    \ Reset value: 0x00000002
    \
    $00 constant SPI3_RXNE                      \ [0x00] Receive buffer not empty
    $01 constant SPI3_TXE                       \ [0x01] Transmit buffer empty
    $02 constant SPI3_CHSIDE                    \ [0x02] Channel side
    $03 constant SPI3_UDR                       \ [0x03] Underrun flag
    $04 constant SPI3_CRCERR                    \ [0x04] CRC error flag
    $05 constant SPI3_MODF                      \ [0x05] Mode fault
    $06 constant SPI3_OVR                       \ [0x06] Overrun flag
    $07 constant SPI3_BSY                       \ [0x07] Busy flag
    $08 constant SPI3__FRE                      \ [0x08] Frame format error
    $09 constant SPI3_FRLVL                     \ [0x09 : 2] FIFO reception level
    $0b constant SPI3_FTLVL                     \ [0x0b : 2] FIFO Transmission Level
  [then]


  [ifdef] SPI3_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_DR                        \ [0x00 : 16] Data register
  [then]


  [ifdef] SPI3_CRCPR_DEF
    \
    \ @brief CRC polynomial register
    \ Address offset: 0x10
    \ Reset value: 0x00000007
    \
    $00 constant SPI3_CRCPOLY                   \ [0x00 : 16] CRC polynomial register
  [then]


  [ifdef] SPI3_RXCRCR_DEF
    \
    \ @brief RX CRC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_RxCRC                     \ [0x00 : 16] Rx CRC register
  [then]


  [ifdef] SPI3_TXCRCR_DEF
    \
    \ @brief TX CRC register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_TxCRC                     \ [0x00 : 16] Tx CRC register
  [then]


  [ifdef] SPI3_I2SCFGR_DEF
    \
    \ @brief I2S configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_CHLEN                     \ [0x00] Channel length (number of bits per audio channel)
    $01 constant SPI3_DATLEN                    \ [0x01 : 2] Data length to be transferred
    $03 constant SPI3_CKPOL                     \ [0x03] Steady state clock polarity
    $04 constant SPI3_I2SSTD                    \ [0x04 : 2] I2S standard selection
    $07 constant SPI3_PCMSYNC                   \ [0x07] PCM frame synchronization
    $08 constant SPI3_I2SCFG                    \ [0x08 : 2] I2S configuration mode
    $0a constant SPI3_I2SE                      \ [0x0a] I2S Enable
    $0b constant SPI3_I2SMOD                    \ [0x0b] I2S mode selection
    $0c constant SPI3_ASTRTEN                   \ [0x0c] Asynchronous start enable
  [then]


  [ifdef] SPI3_I2SPR_DEF
    \
    \ @brief I2S prescaler register
    \ Address offset: 0x20
    \ Reset value: 0x0000000A
    \
    $00 constant SPI3_I2SDIV                    \ [0x00 : 8] I2S Linear prescaler
    $08 constant SPI3_ODD                       \ [0x08] Odd factor for the prescaler
    $09 constant SPI3_MCKOE                     \ [0x09] Master clock output enable
  [then]

  \
  \ @brief Serial peripheral interface
  \
  $00 constant SPI3_CR1                 \ control register 1
  $04 constant SPI3_CR2                 \ control register 2
  $08 constant SPI3_SR                  \ status register
  $0C constant SPI3_DR                  \ data register
  $10 constant SPI3_CRCPR               \ CRC polynomial register
  $14 constant SPI3_RXCRCR              \ RX CRC register
  $18 constant SPI3_TXCRCR              \ TX CRC register
  $1C constant SPI3_I2SCFGR             \ I2S configuration register
  $20 constant SPI3_I2SPR               \ I2S prescaler register

: SPI3_DEF ; [then]
