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
    $00 constant SPI_SPE                        \ [0x00] Serial Peripheral Enable
    $08 constant SPI_MASRX                      \ [0x08] Master automatic SUSP in Receive mode
    $09 constant SPI_CSTART                     \ [0x09] Master transfer start
    $0a constant SPI_CSUSP                      \ [0x0a] Master SUSPend request
    $0b constant SPI_HDDIR                      \ [0x0b] Rx/Tx direction at Half-duplex mode
    $0c constant SPI_SSI                        \ [0x0c] Internal SS signal input level
    $0d constant SPI_CRC33_17                   \ [0x0d] 32-bit CRC polynomial configuration
    $0e constant SPI_RCRCI                      \ [0x0e] CRC calculation initialization pattern control for receiver
    $0f constant SPI_TCRCI                      \ [0x0f] CRC calculation initialization pattern control for transmitter
    $10 constant SPI_IOLOCK                     \ [0x10] Locking the AF configuration of associated IOs
  [then]


  [ifdef] SPI_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TSIZE                      \ [0x00 : 16] Number of data at current transfer
    $10 constant SPI_TSER                       \ [0x10 : 16] Number of data transfer extension to be reload into TSIZE just when a previous
  [then]


  [ifdef] SPI_CFG1_DEF
    \
    \ @brief configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00070007
    \
    $00 constant SPI_DSIZE                      \ [0x00 : 5] Number of bits in at single SPI data frame
    $05 constant SPI_FTHVL                      \ [0x05 : 4] threshold level
    $09 constant SPI_UDRCFG                     \ [0x09 : 2] Behavior of slave transmitter at underrun condition
    $0b constant SPI_UDRDET                     \ [0x0b : 2] Detection of underrun condition at slave transmitter
    $0e constant SPI_RXDMAEN                    \ [0x0e] Rx DMA stream enable
    $0f constant SPI_TXDMAEN                    \ [0x0f] Tx DMA stream enable
    $10 constant SPI_CRCSIZE                    \ [0x10 : 5] Length of CRC frame to be transacted and compared
    $16 constant SPI_CRCEN                      \ [0x16] Hardware CRC computation enable
    $1c constant SPI_MBR                        \ [0x1c : 3] Master baud rate
  [then]


  [ifdef] SPI_CFG2_DEF
    \
    \ @brief configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_MSSI                       \ [0x00 : 4] Master SS Idleness
    $04 constant SPI_MIDI                       \ [0x04 : 4] Master Inter-Data Idleness
    $0f constant SPI_IOSWP                      \ [0x0f] Swap functionality of MISO and MOSI pins
    $11 constant SPI_COMM                       \ [0x11 : 2] SPI Communication Mode
    $13 constant SPI_SP                         \ [0x13 : 3] Serial Protocol
    $16 constant SPI_MASTER                     \ [0x16] SPI Master
    $17 constant SPI_LSBFRST                    \ [0x17] Data frame format
    $18 constant SPI_CPHA                       \ [0x18] Clock phase
    $19 constant SPI_CPOL                       \ [0x19] Clock polarity
    $1a constant SPI_SSM                        \ [0x1a] Software management of SS signal input
    $1c constant SPI_SSIOP                      \ [0x1c] SS input/output polarity
    $1d constant SPI_SSOE                       \ [0x1d] SS output enable
    $1e constant SPI_SSOM                       \ [0x1e] SS output management in master mode
    $1f constant SPI_AFCNTR                     \ [0x1f] Alternate function GPIOs control
  [then]


  [ifdef] SPI_IER_DEF
    \
    \ @brief Interrupt Enable Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXPIE                      \ [0x00] RXP Interrupt Enable
    $01 constant SPI_TXPIE                      \ [0x01] TXP interrupt enable
    $02 constant SPI_DPXPIE                     \ [0x02] DXP interrupt enabled
    $03 constant SPI_EOTIE                      \ [0x03] EOT, SUSP and TXC interrupt enable
    $04 constant SPI_TXTFIE                     \ [0x04] TXTFIE interrupt enable
    $05 constant SPI_UDRIE                      \ [0x05] UDR interrupt enable
    $06 constant SPI_OVRIE                      \ [0x06] OVR interrupt enable
    $07 constant SPI_CRCEIE                     \ [0x07] CRC Interrupt enable
    $08 constant SPI_TIFREIE                    \ [0x08] TIFRE interrupt enable
    $09 constant SPI_MODFIE                     \ [0x09] Mode Fault interrupt enable
    $0a constant SPI_TSERFIE                    \ [0x0a] Additional number of transactions reload interrupt enable
  [then]


  [ifdef] SPI_SR_DEF
    \
    \ @brief Status Register
    \ Address offset: 0x14
    \ Reset value: 0x00001002
    \
    $00 constant SPI_RXP                        \ [0x00] Rx-Packet available
    $01 constant SPI_TXP                        \ [0x01] Tx-Packet space available
    $02 constant SPI_DXP                        \ [0x02] Duplex Packet
    $03 constant SPI_EOT                        \ [0x03] End Of Transfer
    $04 constant SPI_TXTF                       \ [0x04] Transmission Transfer Filled
    $05 constant SPI_UDR                        \ [0x05] Underrun at slave transmission mode
    $06 constant SPI_OVR                        \ [0x06] Overrun
    $07 constant SPI_CRCE                       \ [0x07] CRC Error
    $08 constant SPI_TIFRE                      \ [0x08] TI frame format error
    $09 constant SPI_MODF                       \ [0x09] Mode Fault
    $0a constant SPI_TSERF                      \ [0x0a] Additional number of SPI data to be transacted was reload
    $0b constant SPI_SUSP                       \ [0x0b] SUSPend
    $0c constant SPI_TXC                        \ [0x0c] TxFIFO transmission complete
    $0d constant SPI_RXPLVL                     \ [0x0d : 2] RxFIFO Packing LeVeL
    $0f constant SPI_RXWNE                      \ [0x0f] RxFIFO Word Not Empty
    $10 constant SPI_CTSIZE                     \ [0x10 : 16] Number of data frames remaining in current TSIZE session
  [then]


  [ifdef] SPI_IFCR_DEF
    \
    \ @brief Interrupt/Status Flags Clear Register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant SPI_EOTC                       \ [0x03] End Of Transfer flag clear
    $04 constant SPI_TXTFC                      \ [0x04] Transmission Transfer Filled flag clear
    $05 constant SPI_UDRC                       \ [0x05] Underrun flag clear
    $06 constant SPI_OVRC                       \ [0x06] Overrun flag clear
    $07 constant SPI_CRCEC                      \ [0x07] CRC Error flag clear
    $08 constant SPI_TIFREC                     \ [0x08] TI frame format error flag clear
    $09 constant SPI_MODFC                      \ [0x09] Mode Fault flag clear
    $0a constant SPI_TSERFC                     \ [0x0a] TSERFC flag clear
    $0b constant SPI_SUSPC                      \ [0x0b] SUSPend flag clear
  [then]


  [ifdef] SPI_TXDR_DEF
    \
    \ @brief Transmit Data Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXDR                       \ [0x00 : 32] Transmit data register
  [then]


  [ifdef] SPI_RXDR_DEF
    \
    \ @brief Receive Data Register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXDR                       \ [0x00 : 32] Receive data register
  [then]


  [ifdef] SPI_CRCPOLY_DEF
    \
    \ @brief Polynomial Register
    \ Address offset: 0x40
    \ Reset value: 0x00000107
    \
    $00 constant SPI_CRCPOLY                    \ [0x00 : 32] CRC polynomial register
  [then]


  [ifdef] SPI_TXCRC_DEF
    \
    \ @brief Transmitter CRC Register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXCRC                      \ [0x00 : 32] CRC register for transmitter
  [then]


  [ifdef] SPI_RXCRC_DEF
    \
    \ @brief Receiver CRC Register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXCRC                      \ [0x00 : 32] CRC register for receiver
  [then]


  [ifdef] SPI_UDRDR_DEF
    \
    \ @brief Underrun Data Register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_UDRDR                      \ [0x00 : 32] Data at slave underrun condition
  [then]


  [ifdef] SPI_CGFR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SPI_I2SMOD                     \ [0x00] I2S mode selection
    $01 constant SPI_I2SCFG                     \ [0x01 : 3] I2S configuration mode
    $04 constant SPI_I2SSTD                     \ [0x04 : 2] I2S standard selection
    $07 constant SPI_PCMSYNC                    \ [0x07] PCM frame synchronization
    $08 constant SPI_DATLEN                     \ [0x08 : 2] Data length to be transferred
    $0a constant SPI_CHLEN                      \ [0x0a] Channel length (number of bits per audio channel)
    $0b constant SPI_CKPOL                      \ [0x0b] Serial audio clock polarity
    $0c constant SPI_FIXCH                      \ [0x0c] Word select inversion
    $0d constant SPI_WSINV                      \ [0x0d] Fixed channel length in SLAVE
    $0e constant SPI_DATFMT                     \ [0x0e] Data format
    $10 constant SPI_I2SDIV                     \ [0x10 : 8] I2S linear prescaler
    $18 constant SPI_ODD                        \ [0x18] Odd factor for the prescaler
    $19 constant SPI_MCKOE                      \ [0x19] Master clock output enable
  [then]

  \
  \ @brief Serial peripheral interface
  \
  $00 constant SPI_CR1                  \ control register 1
  $04 constant SPI_CR2                  \ control register 2
  $08 constant SPI_CFG1                 \ configuration register 1
  $0C constant SPI_CFG2                 \ configuration register 2
  $10 constant SPI_IER                  \ Interrupt Enable Register
  $14 constant SPI_SR                   \ Status Register
  $18 constant SPI_IFCR                 \ Interrupt/Status Flags Clear Register
  $20 constant SPI_TXDR                 \ Transmit Data Register
  $30 constant SPI_RXDR                 \ Receive Data Register
  $40 constant SPI_CRCPOLY              \ Polynomial Register
  $44 constant SPI_TXCRC                \ Transmitter CRC Register
  $48 constant SPI_RXCRC                \ Receiver CRC Register
  $4C constant SPI_UDRDR                \ Underrun Data Register
  $50 constant SPI_CGFR                 \ configuration register

: SPI_DEF ; [then]
