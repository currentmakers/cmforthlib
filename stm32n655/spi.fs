\
\ @file spi.fs
\ @brief Serial peripheral interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI_DEF

  [ifdef] SPI_SPI_CR1_DEF
    \
    \ @brief SPI/I2S control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI_SPE                        \ [0x00] serial peripheral enable
    $08 constant SPI_MASRX                      \ [0x08] master automatic suspension in Receive mode
    $09 constant SPI_CSTART                     \ [0x09] master transfer start
    $0a constant SPI_CSUSP                      \ [0x0a] master suspend request
    $0b constant SPI_HDDIR                      \ [0x0b] Rx/Tx direction at Half-duplex mode
    $0c constant SPI_SSI                        \ [0x0c] internal SS signal input level
    $0d constant SPI_CRC33_17                   \ [0x0d] 32-bit CRC polynomial configuration
    $0e constant SPI_RCRCINI                    \ [0x0e] CRC calculation initialization pattern control for receiver
    $0f constant SPI_TCRCINI                    \ [0x0f] CRC calculation initialization pattern control for transmitter
    $10 constant SPI_IOLOCK                     \ [0x10] locking the AF configuration of associated I/Os
  [then]


  [ifdef] SPI_SPI_CR2_DEF
    \
    \ @brief SPI/I2S control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TSIZE                      \ [0x00 : 16] number of data at current transfer
  [then]


  [ifdef] SPI_SPI_CFG1_DEF
    \
    \ @brief SPI/I2S configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00070007
    \
    $00 constant SPI_DSIZE                      \ [0x00 : 5] number of bits in at single SPI data frame
    $05 constant SPI_FTHLV                      \ [0x05 : 4] FIFO threshold level
    $09 constant SPI_UDRCFG                     \ [0x09] behavior of slave transmitter at underrun condition
    $0e constant SPI_RXDMAEN                    \ [0x0e] Rx DMA stream enable
    $0f constant SPI_TXDMAEN                    \ [0x0f] Tx DMA stream enable
    $10 constant SPI_CRCSIZE                    \ [0x10 : 5] length of CRC frame to be transacted and compared
    $16 constant SPI_CRCEN                      \ [0x16] hardware CRC computation enable
    $1c constant SPI_MBR                        \ [0x1c : 3] master baud rate prescaler setting
    $1f constant SPI_BPASS                      \ [0x1f] bypass of the prescaler at master baud rate clock generator
  [then]


  [ifdef] SPI_SPI_CFG2_DEF
    \
    \ @brief SPI/I2S configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_MSSI                       \ [0x00 : 4] Master SS Idleness
    $04 constant SPI_MIDI                       \ [0x04 : 4] master Inter-Data Idleness
    $0d constant SPI_RDIOM                      \ [0x0d] RDY signal input/output management
    $0e constant SPI_RDIOP                      \ [0x0e] RDY signal input/output polarity
    $0f constant SPI_IOSWP                      \ [0x0f] swap functionality of MISO and MOSI pins
    $11 constant SPI_COMM                       \ [0x11 : 2] SPI Communication Mode
    $13 constant SPI_SP                         \ [0x13 : 3] serial protocol
    $16 constant SPI_MASTER                     \ [0x16] SPI Master
    $17 constant SPI_LSBFRST                    \ [0x17] data frame format
    $18 constant SPI_CPHA                       \ [0x18] clock phase
    $19 constant SPI_CPOL                       \ [0x19] clock polarity
    $1a constant SPI_SSM                        \ [0x1a] software management of SS signal input
    $1c constant SPI_SSIOP                      \ [0x1c] SS input/output polarity
    $1d constant SPI_SSOE                       \ [0x1d] SS output enable
    $1e constant SPI_SSOM                       \ [0x1e] SS output management in Master mode
    $1f constant SPI_AFCNTR                     \ [0x1f] alternate function GPIOs control
  [then]


  [ifdef] SPI_SPI_IER_DEF
    \
    \ @brief SPI/I2S interrupt enable register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXPIE                      \ [0x00] RXP interrupt enable
    $01 constant SPI_TXPIE                      \ [0x01] TXP interrupt enable
    $02 constant SPI_DXPIE                      \ [0x02] DXP interrupt enabled
    $03 constant SPI_EOTIE                      \ [0x03] EOT, SUSP and TXC interrupt enable
    $04 constant SPI_TXTFIE                     \ [0x04] TXTFIE interrupt enable
    $05 constant SPI_UDRIE                      \ [0x05] UDR interrupt enable
    $06 constant SPI_OVRIE                      \ [0x06] OVR interrupt enable
    $07 constant SPI_CRCEIE                     \ [0x07] CRC error interrupt enable
    $08 constant SPI_TIFREIE                    \ [0x08] TIFRE interrupt enable
    $09 constant SPI_MODFIE                     \ [0x09] mode Fault interrupt enable
  [then]


  [ifdef] SPI_SPI_SR_DEF
    \
    \ @brief SPI/I2S status register
    \ Address offset: 0x14
    \ Reset value: 0x00001002
    \
    $00 constant SPI_RXP                        \ [0x00] Rx-packet available
    $01 constant SPI_TXP                        \ [0x01] Tx-packet space available
    $02 constant SPI_DXP                        \ [0x02] duplex packet
    $03 constant SPI_EOT                        \ [0x03] end of transfer
    $04 constant SPI_TXTF                       \ [0x04] transmission transfer filled
    $05 constant SPI_UDR                        \ [0x05] underrun
    $06 constant SPI_OVR                        \ [0x06] overrun
    $07 constant SPI_CRCE                       \ [0x07] CRC error
    $08 constant SPI_TIFRE                      \ [0x08] TI frame format error
    $09 constant SPI_MODF                       \ [0x09] mode fault
    $0b constant SPI_SUSP                       \ [0x0b] suspension status
    $0c constant SPI_TXC                        \ [0x0c] TxFIFO transmission complete
    $0d constant SPI_RXPLVL                     \ [0x0d : 2] RxFIFO packing level
    $0f constant SPI_RXWNE                      \ [0x0f] RxFIFO word not empty
    $10 constant SPI_CTSIZE                     \ [0x10 : 16] number of data frames remaining in current TSIZE session
  [then]


  [ifdef] SPI_SPI_IFCR_DEF
    \
    \ @brief SPI/I2S interrupt/status flags clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant SPI_EOTC                       \ [0x03] end of transfer flag clear
    $04 constant SPI_TXTFC                      \ [0x04] transmission transfer filled flag clear
    $05 constant SPI_UDRC                       \ [0x05] underrun flag clear
    $06 constant SPI_OVRC                       \ [0x06] overrun flag clear
    $07 constant SPI_CRCEC                      \ [0x07] CRC error flag clear
    $08 constant SPI_TIFREC                     \ [0x08] TI frame format error flag clear
    $09 constant SPI_MODFC                      \ [0x09] mode fault flag clear
    $0b constant SPI_SUSPC                      \ [0x0b] Suspend flag clear
  [then]


  [ifdef] SPI_SPI_TXDR_DEF
    \
    \ @brief SPI/I2S transmit data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXDR                       \ [0x00 : 32] transmit data register
  [then]


  [ifdef] SPI_SPI_RXDR_DEF
    \
    \ @brief SPI/I2S receive data register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXDR                       \ [0x00 : 32] receive data register
  [then]


  [ifdef] SPI_SPI_CRCPOLY_DEF
    \
    \ @brief SPI/I2S polynomial register
    \ Address offset: 0x40
    \ Reset value: 0x00000107
    \
    $00 constant SPI_CRCPOLY                    \ [0x00 : 32] CRC polynomial register
  [then]


  [ifdef] SPI_SPI_TXCRC_DEF
    \
    \ @brief SPI/I2S transmitter CRC register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXCRC                      \ [0x00 : 32] CRC register for transmitter
  [then]


  [ifdef] SPI_SPI_RXCRC_DEF
    \
    \ @brief SPI/I2S receiver CRC register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXCRC                      \ [0x00 : 32] CRC register for receiver
  [then]


  [ifdef] SPI_SPI_UDRDR_DEF
    \
    \ @brief SPI/I2S underrun data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_UDRDR                      \ [0x00 : 32] data at slave underrun condition
  [then]


  [ifdef] SPI_SPI_I2SCFGR_DEF
    \
    \ @brief SPI/I2S configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SPI_I2SMOD                     \ [0x00] I2S mode selection
    $01 constant SPI_I2SCFG                     \ [0x01 : 3] I2S configuration mode
    $04 constant SPI_I2SSTD                     \ [0x04 : 2] Iless thansup>2less than/sup>S standard selection
    $07 constant SPI_PCMSYNC                    \ [0x07] PCM frame synchronization
    $08 constant SPI_DATLEN                     \ [0x08 : 2] data length to be transferred. Data width of 24 and 32 bits are not always supported, (DATLEN = 01 or 10), refer to Section 58.3: SPI implementation to check the supported data size.
    $0a constant SPI_CHLEN                      \ [0x0a] channel length (number of bits per audio channel)
    $0b constant SPI_CKPOL                      \ [0x0b] serial audio clock polarity
    $0c constant SPI_FIXCH                      \ [0x0c] fixed channel length in slave
    $0d constant SPI_WSINV                      \ [0x0d] word select inversion
    $0e constant SPI_DATFMT                     \ [0x0e] data format
    $10 constant SPI_I2SDIV                     \ [0x10 : 8] Iless thansup>2less than/sup>S linear prescaler
    $18 constant SPI_ODD                        \ [0x18] odd factor for the prescaler
    $19 constant SPI_MCKOE                      \ [0x19] master clock output enable
  [then]

  \
  \ @brief Serial peripheral interface
  \
  $00 constant SPI_SPI_CR1              \ SPI/I2S control register 1
  $04 constant SPI_SPI_CR2              \ SPI/I2S control register 2
  $08 constant SPI_SPI_CFG1             \ SPI/I2S configuration register 1
  $0C constant SPI_SPI_CFG2             \ SPI/I2S configuration register 2
  $10 constant SPI_SPI_IER              \ SPI/I2S interrupt enable register
  $14 constant SPI_SPI_SR               \ SPI/I2S status register
  $18 constant SPI_SPI_IFCR             \ SPI/I2S interrupt/status flags clear register
  $20 constant SPI_SPI_TXDR             \ SPI/I2S transmit data register
  $30 constant SPI_SPI_RXDR             \ SPI/I2S receive data register
  $40 constant SPI_SPI_CRCPOLY          \ SPI/I2S polynomial register
  $44 constant SPI_SPI_TXCRC            \ SPI/I2S transmitter CRC register
  $48 constant SPI_SPI_RXCRC            \ SPI/I2S receiver CRC register
  $4C constant SPI_SPI_UDRDR            \ SPI/I2S underrun data register
  $50 constant SPI_SPI_I2SCFGR          \ SPI/I2S configuration register

: SPI_DEF ; [then]
