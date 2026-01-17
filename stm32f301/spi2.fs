\
\ @file spi2.fs
\ @brief Serial peripheral interface/Inter-IC sound
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI2_DEF

  [ifdef] SPI2_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI2_CPHA                      \ [0x00] Clock phase
    $01 constant SPI2_CPOL                      \ [0x01] Clock polarity
    $02 constant SPI2_MSTR                      \ [0x02] Master selection
    $03 constant SPI2_BR                        \ [0x03 : 3] Baud rate control
    $06 constant SPI2_SPE                       \ [0x06] SPI enable
    $07 constant SPI2_LSBFIRST                  \ [0x07] Frame format
    $08 constant SPI2_SSI                       \ [0x08] Internal slave select
    $09 constant SPI2_SSM                       \ [0x09] Software slave management
    $0a constant SPI2_RXONLY                    \ [0x0a] Receive only
    $0b constant SPI2_CRCL                      \ [0x0b] CRC length
    $0c constant SPI2_CRCNEXT                   \ [0x0c] CRC transfer next
    $0d constant SPI2_CRCEN                     \ [0x0d] Hardware CRC calculation enable
    $0e constant SPI2_BIDIOE                    \ [0x0e] Output enable in bidirectional mode
    $0f constant SPI2_BIDIMODE                  \ [0x0f] Bidirectional data mode enable
  [then]


  [ifdef] SPI2_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPI2_RXDMAEN                   \ [0x00] Rx buffer DMA enable
    $01 constant SPI2_TXDMAEN                   \ [0x01] Tx buffer DMA enable
    $02 constant SPI2_SSOE                      \ [0x02] SS output enable
    $03 constant SPI2_NSSP                      \ [0x03] NSS pulse management
    $04 constant SPI2_FRF                       \ [0x04] Frame format
    $05 constant SPI2_ERRIE                     \ [0x05] Error interrupt enable
    $06 constant SPI2_RXNEIE                    \ [0x06] RX buffer not empty interrupt enable
    $07 constant SPI2_TXEIE                     \ [0x07] Tx buffer empty interrupt enable
    $08 constant SPI2_DS                        \ [0x08 : 4] Data size
    $0c constant SPI2_FRXTH                     \ [0x0c] FIFO reception threshold
    $0d constant SPI2_LDMA_RX                   \ [0x0d] Last DMA transfer for reception
    $0e constant SPI2_LDMA_TX                   \ [0x0e] Last DMA transfer for transmission
  [then]


  [ifdef] SPI2_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x08
    \ Reset value: 0x00000002
    \
    $00 constant SPI2_RXNE                      \ [0x00] Receive buffer not empty
    $01 constant SPI2_TXE                       \ [0x01] Transmit buffer empty
    $02 constant SPI2_CHSIDE                    \ [0x02] Channel side
    $03 constant SPI2_UDR                       \ [0x03] Underrun flag
    $04 constant SPI2_CRCERR                    \ [0x04] CRC error flag
    $05 constant SPI2_MODF                      \ [0x05] Mode fault
    $06 constant SPI2_OVR                       \ [0x06] Overrun flag
    $07 constant SPI2_BSY                       \ [0x07] Busy flag
    $08 constant SPI2_TIFRFE                    \ [0x08] TI frame format error
    $09 constant SPI2_FRLVL                     \ [0x09 : 2] FIFO reception level
    $0b constant SPI2_FTLVL                     \ [0x0b : 2] FIFO transmission level
  [then]


  [ifdef] SPI2_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI2_DR                        \ [0x00 : 16] Data register
  [then]


  [ifdef] SPI2_CRCPR_DEF
    \
    \ @brief CRC polynomial register
    \ Address offset: 0x10
    \ Reset value: 0x00000007
    \
    $00 constant SPI2_CRCPOLY                   \ [0x00 : 16] CRC polynomial register
  [then]


  [ifdef] SPI2_RXCRCR_DEF
    \
    \ @brief RX CRC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPI2_RxCRC                     \ [0x00 : 16] Rx CRC register
  [then]


  [ifdef] SPI2_TXCRCR_DEF
    \
    \ @brief TX CRC register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPI2_TxCRC                     \ [0x00 : 16] Tx CRC register
  [then]


  [ifdef] SPI2_I2SCFGR_DEF
    \
    \ @brief I2S configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SPI2_CHLEN                     \ [0x00] Channel length (number of bits per audio channel)
    $01 constant SPI2_DATLEN                    \ [0x01 : 2] Data length to be transferred
    $03 constant SPI2_CKPOL                     \ [0x03] Steady state clock polarity
    $04 constant SPI2_I2SSTD                    \ [0x04 : 2] I2S standard selection
    $07 constant SPI2_PCMSYNC                   \ [0x07] PCM frame synchronization
    $08 constant SPI2_I2SCFG                    \ [0x08 : 2] I2S configuration mode
    $0a constant SPI2_I2SE                      \ [0x0a] I2S Enable
    $0b constant SPI2_I2SMOD                    \ [0x0b] I2S mode selection
  [then]


  [ifdef] SPI2_I2SPR_DEF
    \
    \ @brief I2S prescaler register
    \ Address offset: 0x20
    \ Reset value: 0x00000010
    \
    $00 constant SPI2_I2SDIV                    \ [0x00 : 8] I2S Linear prescaler
    $08 constant SPI2_ODD                       \ [0x08] Odd factor for the prescaler
    $09 constant SPI2_MCKOE                     \ [0x09] Master clock output enable
  [then]

  \
  \ @brief Serial peripheral interface/Inter-IC sound
  \
  $00 constant SPI2_CR1                 \ control register 1
  $04 constant SPI2_CR2                 \ control register 2
  $08 constant SPI2_SR                  \ status register
  $0C constant SPI2_DR                  \ data register
  $10 constant SPI2_CRCPR               \ CRC polynomial register
  $14 constant SPI2_RXCRCR              \ RX CRC register
  $18 constant SPI2_TXCRCR              \ TX CRC register
  $1C constant SPI2_I2SCFGR             \ I2S configuration register
  $20 constant SPI2_I2SPR               \ I2S prescaler register

: SPI2_DEF ; [then]
