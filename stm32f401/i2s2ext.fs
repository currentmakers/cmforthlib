\
\ @file i2s2ext.fs
\ @brief Serial peripheral interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] I2S2EXT_DEF

  [ifdef] I2S2EXT_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I2S2EXT_CPHA                   \ [0x00] Clock phase
    $01 constant I2S2EXT_CPOL                   \ [0x01] Clock polarity
    $02 constant I2S2EXT_MSTR                   \ [0x02] Master selection
    $03 constant I2S2EXT_BR                     \ [0x03 : 3] Baud rate control
    $06 constant I2S2EXT_SPE                    \ [0x06] SPI enable
    $07 constant I2S2EXT_LSBFIRST               \ [0x07] Frame format
    $08 constant I2S2EXT_SSI                    \ [0x08] Internal slave select
    $09 constant I2S2EXT_SSM                    \ [0x09] Software slave management
    $0a constant I2S2EXT_RXONLY                 \ [0x0a] Receive only
    $0b constant I2S2EXT_DFF                    \ [0x0b] Data frame format
    $0c constant I2S2EXT_CRCNEXT                \ [0x0c] CRC transfer next
    $0d constant I2S2EXT_CRCEN                  \ [0x0d] Hardware CRC calculation enable
    $0e constant I2S2EXT_BIDIOE                 \ [0x0e] Output enable in bidirectional mode
    $0f constant I2S2EXT_BIDIMODE               \ [0x0f] Bidirectional data mode enable
  [then]


  [ifdef] I2S2EXT_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant I2S2EXT_RXDMAEN                \ [0x00] Rx buffer DMA enable
    $01 constant I2S2EXT_TXDMAEN                \ [0x01] Tx buffer DMA enable
    $02 constant I2S2EXT_SSOE                   \ [0x02] SS output enable
    $04 constant I2S2EXT_FRF                    \ [0x04] Frame format
    $05 constant I2S2EXT_ERRIE                  \ [0x05] Error interrupt enable
    $06 constant I2S2EXT_RXNEIE                 \ [0x06] RX buffer not empty interrupt enable
    $07 constant I2S2EXT_TXEIE                  \ [0x07] Tx buffer empty interrupt enable
  [then]


  [ifdef] I2S2EXT_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x08
    \ Reset value: 0x00000002
    \
    $00 constant I2S2EXT_RXNE                   \ [0x00] Receive buffer not empty
    $01 constant I2S2EXT_TXE                    \ [0x01] Transmit buffer empty
    $02 constant I2S2EXT_CHSIDE                 \ [0x02] Channel side
    $03 constant I2S2EXT_UDR                    \ [0x03] Underrun flag
    $04 constant I2S2EXT_CRCERR                 \ [0x04] CRC error flag
    $05 constant I2S2EXT_MODF                   \ [0x05] Mode fault
    $06 constant I2S2EXT_OVR                    \ [0x06] Overrun flag
    $07 constant I2S2EXT_BSY                    \ [0x07] Busy flag
    $08 constant I2S2EXT_TIFRFE                 \ [0x08] TI frame format error
  [then]


  [ifdef] I2S2EXT_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant I2S2EXT_DR                     \ [0x00 : 16] Data register
  [then]


  [ifdef] I2S2EXT_CRCPR_DEF
    \
    \ @brief CRC polynomial register
    \ Address offset: 0x10
    \ Reset value: 0x00000007
    \
    $00 constant I2S2EXT_CRCPOLY                \ [0x00 : 16] CRC polynomial register
  [then]


  [ifdef] I2S2EXT_RXCRCR_DEF
    \
    \ @brief RX CRC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant I2S2EXT_RxCRC                  \ [0x00 : 16] Rx CRC register
  [then]


  [ifdef] I2S2EXT_TXCRCR_DEF
    \
    \ @brief TX CRC register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant I2S2EXT_TxCRC                  \ [0x00 : 16] Tx CRC register
  [then]


  [ifdef] I2S2EXT_I2SCFGR_DEF
    \
    \ @brief I2S configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant I2S2EXT_CHLEN                  \ [0x00] Channel length (number of bits per audio channel)
    $01 constant I2S2EXT_DATLEN                 \ [0x01 : 2] Data length to be transferred
    $03 constant I2S2EXT_CKPOL                  \ [0x03] Steady state clock polarity
    $04 constant I2S2EXT_I2SSTD                 \ [0x04 : 2] I2S standard selection
    $07 constant I2S2EXT_PCMSYNC                \ [0x07] PCM frame synchronization
    $08 constant I2S2EXT_I2SCFG                 \ [0x08 : 2] I2S configuration mode
    $0a constant I2S2EXT_I2SE                   \ [0x0a] I2S Enable
    $0b constant I2S2EXT_I2SMOD                 \ [0x0b] I2S mode selection
  [then]


  [ifdef] I2S2EXT_I2SPR_DEF
    \
    \ @brief I2S prescaler register
    \ Address offset: 0x20
    \ Reset value: 0x0000000A
    \
    $00 constant I2S2EXT_I2SDIV                 \ [0x00 : 8] I2S Linear prescaler
    $08 constant I2S2EXT_ODD                    \ [0x08] Odd factor for the prescaler
    $09 constant I2S2EXT_MCKOE                  \ [0x09] Master clock output enable
  [then]

  \
  \ @brief Serial peripheral interface
  \
  $00 constant I2S2EXT_CR1              \ control register 1
  $04 constant I2S2EXT_CR2              \ control register 2
  $08 constant I2S2EXT_SR               \ status register
  $0C constant I2S2EXT_DR               \ data register
  $10 constant I2S2EXT_CRCPR            \ CRC polynomial register
  $14 constant I2S2EXT_RXCRCR           \ RX CRC register
  $18 constant I2S2EXT_TXCRCR           \ TX CRC register
  $1C constant I2S2EXT_I2SCFGR          \ I2S configuration register
  $20 constant I2S2EXT_I2SPR            \ I2S prescaler register

: I2S2EXT_DEF ; [then]
