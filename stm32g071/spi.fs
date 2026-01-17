\
\ @file spi.fs
\ @brief Serial peripheral interface/Inter-IC sound
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
    $03 constant SPI_NSSP                       \ [0x03] NSS pulse management
    $04 constant SPI_FRF                        \ [0x04] Frame format
    $05 constant SPI_ERRIE                      \ [0x05] Error interrupt enable
    $06 constant SPI_RXNEIE                     \ [0x06] RX buffer not empty interrupt enable
    $07 constant SPI_TXEIE                      \ [0x07] Tx buffer empty interrupt enable
    $08 constant SPI_DS                         \ [0x08 : 4] Data size
    $0c constant SPI_FRXTH                      \ [0x0c] FIFO reception threshold
    $0d constant SPI_LDMA_RX                    \ [0x0d] Last DMA transfer for reception
    $0e constant SPI_LDMA_TX                    \ [0x0e] Last DMA transfer for transmission
  [then]


  [ifdef] SPI_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x08
    \ Reset value: 0x00000002
    \
    $00 constant SPI_RXNE                       \ [0x00] Receive buffer not empty
    $01 constant SPI_TXE                        \ [0x01] Transmit buffer empty
    $02 constant SPI_CHSIDE                     \ [0x02] Channel side
    $03 constant SPI_UDR                        \ [0x03] Underrun flag
    $04 constant SPI_CRCERR                     \ [0x04] CRC error flag
    $05 constant SPI_MODF                       \ [0x05] Mode fault
    $06 constant SPI_OVR                        \ [0x06] Overrun flag
    $07 constant SPI_BSY                        \ [0x07] Busy flag
    $08 constant SPI_TIFRFE                     \ [0x08] TI frame format error
    $09 constant SPI_FRLVL                      \ [0x09 : 2] FIFO reception level
    $0b constant SPI_FTLVL                      \ [0x0b : 2] FIFO transmission level
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


  [ifdef] SPI_I2SCFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_CHLEN                      \ [0x00] Channel length (number of bits per audio channel)
    $01 constant SPI_DATLEN                     \ [0x01 : 2] Data length to be transferred
    $03 constant SPI_CKPOL                      \ [0x03] Inactive state clock polarity
    $04 constant SPI_I2SSTD                     \ [0x04 : 2] standard selection
    $07 constant SPI_PCMSYNC                    \ [0x07] PCM frame synchronization
    $08 constant SPI_I2SCFG                     \ [0x08 : 2] I2S configuration mode
    $0a constant SPI_SE2                        \ [0x0a] I2S enable
    $0b constant SPI_I2SMOD                     \ [0x0b] I2S mode selection
  [then]


  [ifdef] SPI_I2SPR_DEF
    \
    \ @brief prescaler register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SPI_I2SDIV                     \ [0x00 : 8] linear prescaler
    $08 constant SPI_ODD                        \ [0x08] Odd factor for the prescaler
    $09 constant SPI_MCKOE                      \ [0x09] Master clock output enable
  [then]


  [ifdef] SPI_HWCFGR_DEF
    \
    \ @brief hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant SPI_CRCCFG                     \ [0x00 : 4] CRC capable at SPI mode
    $04 constant SPI_I2SCFG                     \ [0x04 : 4] I2S mode implementation
    $08 constant SPI_I2SCKCFG                   \ [0x08 : 4] I2S master clock generator at I2S mode
    $0c constant SPI_DSCFG                      \ [0x0c : 4] SPI data size configuration
    $10 constant SPI_NSSCFG                     \ [0x10 : 4] NSS pulse feature enhancement at SPI master
  [then]


  [ifdef] SPI_VERR_DEF
    \
    \ @brief EXTI IP Version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000000
    \
    $00 constant SPI_MINREV                     \ [0x00 : 4] Minor Revision number
    $04 constant SPI_MAJREV                     \ [0x04 : 4] Major Revision number
  [then]


  [ifdef] SPI_IPIDR_DEF
    \
    \ @brief EXTI Identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00000000
    \
    $00 constant SPI_IPID                       \ [0x00 : 32] IP Identification
  [then]


  [ifdef] SPI_SIDR_DEF
    \
    \ @brief EXTI Size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0x00000000
    \
    $00 constant SPI_SID                        \ [0x00 : 32] Size Identification
  [then]

  \
  \ @brief Serial peripheral interface/Inter-IC sound
  \
  $00 constant SPI_CR1                  \ control register 1
  $04 constant SPI_CR2                  \ control register 2
  $08 constant SPI_SR                   \ status register
  $0C constant SPI_DR                   \ data register
  $10 constant SPI_CRCPR                \ CRC polynomial register
  $14 constant SPI_RXCRCR               \ RX CRC register
  $18 constant SPI_TXCRCR               \ TX CRC register
  $1C constant SPI_I2SCFGR              \ configuration register
  $20 constant SPI_I2SPR                \ prescaler register
  $3F0 constant SPI_HWCFGR              \ hardware configuration register
  $3F4 constant SPI_VERR                \ EXTI IP Version register
  $3F8 constant SPI_IPIDR               \ EXTI Identification register
  $3FC constant SPI_SIDR                \ EXTI Size ID register

: SPI_DEF ; [then]
