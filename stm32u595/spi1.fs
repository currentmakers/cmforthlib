\
\ @file spi1.fs
\ @brief Serial peripheral interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI1_DEF

  [ifdef] SPI1_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_SPE                       \ [0x00] SPE
    $08 constant SPI1_MASRX                     \ [0x08] MASRX
    $09 constant SPI1_CSTART                    \ [0x09] CSTART
    $0a constant SPI1_CSUSP                     \ [0x0a] CSUSP
    $0b constant SPI1_HDDIR                     \ [0x0b] HDDIR
    $0c constant SPI1_SSI                       \ [0x0c] SSI
    $0d constant SPI1_CRC33_17                  \ [0x0d] CRC33_17
    $0e constant SPI1_RCRCINI                   \ [0x0e] RCRCINI
    $0f constant SPI1_TCRCINI                   \ [0x0f] TCRCINI
    $10 constant SPI1_IOLOCK                    \ [0x10] IOLOCK
  [then]


  [ifdef] SPI1_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_TSIZE                     \ [0x00 : 16] TSIZE
  [then]


  [ifdef] SPI1_CFG1_DEF
    \
    \ @brief configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00070007
    \
    $00 constant SPI1_DSIZE                     \ [0x00 : 5] Number of bits in at single SPI data frame
    $05 constant SPI1_FTHVL                     \ [0x05 : 4] threshold level
    $09 constant SPI1_UDRCFG                    \ [0x09] Behavior of slave transmitter at underrun condition
    $0e constant SPI1_RXDMAEN                   \ [0x0e] Rx DMA stream enable
    $0f constant SPI1_TXDMAEN                   \ [0x0f] Tx DMA stream enable
    $10 constant SPI1_CRCSIZE                   \ [0x10 : 5] Length of CRC frame to be transacted and compared
    $16 constant SPI1_CRCEN                     \ [0x16] Hardware CRC computation enable
    $1c constant SPI1_MBR                       \ [0x1c : 3] Master baud rate
    $1f constant SPI1_BPASS                     \ [0x1f] BPASS
  [then]


  [ifdef] SPI1_CFG2_DEF
    \
    \ @brief configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_MSSI                      \ [0x00 : 4] Master SS Idleness
    $04 constant SPI1_MIDI                      \ [0x04 : 4] Master Inter-Data Idleness
    $0d constant SPI1_RDIMM                     \ [0x0d] RDIMM
    $0e constant SPI1_RDIOP                     \ [0x0e] RDIOP
    $0f constant SPI1_IOSWP                     \ [0x0f] Swap functionality of MISO and MOSI pins
    $11 constant SPI1_COMM                      \ [0x11 : 2] SPI Communication Mode
    $13 constant SPI1_SP                        \ [0x13 : 3] Serial Protocol
    $16 constant SPI1_MASTER                    \ [0x16] SPI Master
    $17 constant SPI1_LSBFRST                   \ [0x17] Data frame format
    $18 constant SPI1_CPHA                      \ [0x18] Clock phase
    $19 constant SPI1_CPOL                      \ [0x19] Clock polarity
    $1a constant SPI1_SSM                       \ [0x1a] Software management of SS signal input
    $1c constant SPI1_SSIOP                     \ [0x1c] SS input/output polarity
    $1d constant SPI1_SSOE                      \ [0x1d] SS output enable
    $1e constant SPI1_SSOM                      \ [0x1e] SS output management in master mode
    $1f constant SPI1_AFCNTR                    \ [0x1f] Alternate function GPIOs control
  [then]


  [ifdef] SPI1_IER_DEF
    \
    \ @brief Interrupt Enable Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_RXPIE                     \ [0x00] RXP Interrupt Enable
    $01 constant SPI1_TXPIE                     \ [0x01] TXP interrupt enable
    $02 constant SPI1_DPXPIE                    \ [0x02] DXP interrupt enabled
    $03 constant SPI1_EOTIE                     \ [0x03] EOT, SUSP and TXC interrupt enable
    $04 constant SPI1_TXTFIE                    \ [0x04] TXTFIE interrupt enable
    $05 constant SPI1_UDRIE                     \ [0x05] UDR interrupt enable
    $06 constant SPI1_OVRIE                     \ [0x06] OVR interrupt enable
    $07 constant SPI1_CRCEIE                    \ [0x07] CRC Interrupt enable
    $08 constant SPI1_TIFREIE                   \ [0x08] TIFRE interrupt enable
    $09 constant SPI1_MODFIE                    \ [0x09] Mode Fault interrupt enable
  [then]


  [ifdef] SPI1_SR_DEF
    \
    \ @brief Status Register
    \ Address offset: 0x14
    \ Reset value: 0x00001002
    \
    $00 constant SPI1_RXP                       \ [0x00] Rx-Packet available
    $01 constant SPI1_TXP                       \ [0x01] Tx-Packet space available
    $02 constant SPI1_DXP                       \ [0x02] Duplex Packet
    $03 constant SPI1_EOT                       \ [0x03] End Of Transfer
    $04 constant SPI1_TXTF                      \ [0x04] Transmission Transfer Filled
    $05 constant SPI1_UDR                       \ [0x05] Underrun at slave transmission mode
    $06 constant SPI1_OVR                       \ [0x06] Overrun
    $07 constant SPI1_CRCE                      \ [0x07] CRC Error
    $08 constant SPI1_TIFRE                     \ [0x08] TI frame format error
    $09 constant SPI1_MODF                      \ [0x09] Mode Fault
    $0b constant SPI1_SUSP                      \ [0x0b] SUSPend
    $0c constant SPI1_TXC                       \ [0x0c] TxFIFO transmission complete
    $0d constant SPI1_RXPLVL                    \ [0x0d : 2] RxFIFO Packing LeVeL
    $0f constant SPI1_RXWNE                     \ [0x0f] RxFIFO Word Not Empty
    $10 constant SPI1_CTSIZE                    \ [0x10 : 16] Number of data frames remaining in current TSIZE session
  [then]


  [ifdef] SPI1_IFCR_DEF
    \
    \ @brief Interrupt/Status Flags Clear Register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant SPI1_EOTC                      \ [0x03] End Of Transfer flag clear
    $04 constant SPI1_TXTFC                     \ [0x04] Transmission Transfer Filled flag clear
    $05 constant SPI1_UDRC                      \ [0x05] Underrun flag clear
    $06 constant SPI1_OVRC                      \ [0x06] Overrun flag clear
    $07 constant SPI1_CRCEC                     \ [0x07] CRC Error flag clear
    $08 constant SPI1_TIFREC                    \ [0x08] TI frame format error flag clear
    $09 constant SPI1_MODFC                     \ [0x09] Mode Fault flag clear
    $0b constant SPI1_SUSPC                     \ [0x0b] SUSPend flag clear
  [then]


  [ifdef] SPI1_AUTOCR_DEF
    \
    \ @brief SPI autonomous mode control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $10 constant SPI1_TRIGSEL                   \ [0x10 : 4] TRIGSEL
    $14 constant SPI1_TRIGPOL                   \ [0x14] TRIGPOL
    $15 constant SPI1_TRIGEN                    \ [0x15] TRIGEN
  [then]


  [ifdef] SPI1_TXDR_DEF
    \
    \ @brief Transmit Data Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_TXDR                      \ [0x00 : 32] Transmit data register
  [then]


  [ifdef] SPI1_RXDR_DEF
    \
    \ @brief Receive Data Register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_RXDR                      \ [0x00 : 32] Receive data register
  [then]


  [ifdef] SPI1_CRCPOLY_DEF
    \
    \ @brief Polynomial Register
    \ Address offset: 0x40
    \ Reset value: 0x00000107
    \
    $00 constant SPI1_CRCPOLY                   \ [0x00 : 32] CRC polynomial register
  [then]


  [ifdef] SPI1_TXCRC_DEF
    \
    \ @brief Transmitter CRC Register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_TXCRC                     \ [0x00 : 32] CRC register for transmitter
  [then]


  [ifdef] SPI1_RXCRC_DEF
    \
    \ @brief Receiver CRC Register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_RXCRC                     \ [0x00 : 32] CRC register for receiver
  [then]


  [ifdef] SPI1_UDRDR_DEF
    \
    \ @brief Underrun Data Register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_UDRDR                     \ [0x00 : 32] Data at slave underrun condition
  [then]

  \
  \ @brief Serial peripheral interface
  \
  $00 constant SPI1_CR1                 \ control register 1
  $04 constant SPI1_CR2                 \ control register 2
  $08 constant SPI1_CFG1                \ configuration register 1
  $0C constant SPI1_CFG2                \ configuration register 2
  $10 constant SPI1_IER                 \ Interrupt Enable Register
  $14 constant SPI1_SR                  \ Status Register
  $18 constant SPI1_IFCR                \ Interrupt/Status Flags Clear Register
  $1C constant SPI1_AUTOCR              \ SPI autonomous mode control register
  $20 constant SPI1_TXDR                \ Transmit Data Register
  $30 constant SPI1_RXDR                \ Receive Data Register
  $40 constant SPI1_CRCPOLY             \ Polynomial Register
  $44 constant SPI1_TXCRC               \ Transmitter CRC Register
  $48 constant SPI1_RXCRC               \ Receiver CRC Register
  $4C constant SPI1_UDRDR               \ Underrun Data Register

: SPI1_DEF ; [then]
