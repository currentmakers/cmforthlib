\
\ @file spi.fs
\ @brief SPI1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI_DEF

  [ifdef] SPI_SPI2S_CR1_DEF
    \
    \ @brief SPI/I2S control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI_SPE                        \ [0x00] SPE
    $08 constant SPI_MASRX                      \ [0x08] MASRX
    $09 constant SPI_CSTART                     \ [0x09] CSTART
    $0a constant SPI_CSUSP                      \ [0x0a] CSUSP
    $0b constant SPI_HDDIR                      \ [0x0b] HDDIR
    $0c constant SPI_SSI                        \ [0x0c] SSI
    $0d constant SPI_CRC33_17                   \ [0x0d] CRC33_17
    $0e constant SPI_RCRCINI                    \ [0x0e] RCRCINI
    $0f constant SPI_TCRCINI                    \ [0x0f] TCRCINI
    $10 constant SPI_IOLOCK                     \ [0x10] IOLOCK
  [then]


  [ifdef] SPI_SPI_CR2_DEF
    \
    \ @brief SPI control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TSIZE                      \ [0x00 : 16] TSIZE
    $10 constant SPI_TSER                       \ [0x10 : 16] TSER
  [then]


  [ifdef] SPI_SPI_CFG1_DEF
    \
    \ @brief Content of this register is write protected when SPI is enabled
    \ Address offset: 0x08
    \ Reset value: 0x00070007
    \
    $00 constant SPI_DSIZE                      \ [0x00 : 5] DSIZE
    $05 constant SPI_FTHLV                      \ [0x05 : 4] FTHLV
    $09 constant SPI_UDRCFG                     \ [0x09 : 2] UDRCFG
    $0b constant SPI_UDRDET                     \ [0x0b : 2] UDRDET
    $0e constant SPI_RXDMAEN                    \ [0x0e] RXDMAEN
    $0f constant SPI_TXDMAEN                    \ [0x0f] TXDMAEN
    $10 constant SPI_CRCSIZE                    \ [0x10 : 5] CRCSIZE
    $16 constant SPI_CRCEN                      \ [0x16] CRCEN
    $1c constant SPI_MBR                        \ [0x1c : 3] MBR
  [then]


  [ifdef] SPI_SPI_CFG2_DEF
    \
    \ @brief The content of this register is write protected when SPI is enabled or IOLOCK bit is set at SPI2S_CR1 register.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_MSSI                       \ [0x00 : 4] MSSI
    $04 constant SPI_MIDI                       \ [0x04 : 4] MIDI
    $0f constant SPI_IOSWP                      \ [0x0f] IOSWP
    $11 constant SPI_COMM                       \ [0x11 : 2] COMM
    $13 constant SPI_SP                         \ [0x13 : 3] SP
    $16 constant SPI_MASTER                     \ [0x16] MASTER
    $17 constant SPI_LSBFRST                    \ [0x17] LSBFRST
    $18 constant SPI_CPHA                       \ [0x18] CPHA
    $19 constant SPI_CPOL                       \ [0x19] CPOL
    $1a constant SPI_SSM                        \ [0x1a] SSM
    $1c constant SPI_SSIOP                      \ [0x1c] SSIOP
    $1d constant SPI_SSOE                       \ [0x1d] SSOE
    $1e constant SPI_SSOM                       \ [0x1e] SSOM
    $1f constant SPI_AFCNTR                     \ [0x1f] AFCNTR
  [then]


  [ifdef] SPI_SPI2S_IER_DEF
    \
    \ @brief SPI/I2S interrupt enable register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXPIE                      \ [0x00] RXPIE
    $01 constant SPI_TXPIE                      \ [0x01] TXPIE
    $02 constant SPI_DXPIE                      \ [0x02] DXPIE
    $03 constant SPI_EOTIE                      \ [0x03] EOTIE
    $04 constant SPI_TXTFIE                     \ [0x04] TXTFIE
    $05 constant SPI_UDRIE                      \ [0x05] UDRIE
    $06 constant SPI_OVRIE                      \ [0x06] OVRIE
    $07 constant SPI_CRCEIE                     \ [0x07] CRCEIE
    $08 constant SPI_TIFREIE                    \ [0x08] TIFREIE
    $09 constant SPI_MODFIE                     \ [0x09] MODFIE
    $0a constant SPI_TSERFIE                    \ [0x0a] TSERFIE
  [then]


  [ifdef] SPI_SPI2S_SR_DEF
    \
    \ @brief SPI/I2S status register
    \ Address offset: 0x14
    \ Reset value: 0x00001002
    \
    $00 constant SPI_RXP                        \ [0x00] RXP
    $01 constant SPI_TXP                        \ [0x01] TXP
    $02 constant SPI_DXP                        \ [0x02] DXP
    $03 constant SPI_EOT                        \ [0x03] EOT
    $04 constant SPI_TXTF                       \ [0x04] TXTF
    $05 constant SPI_UDR                        \ [0x05] UDR
    $06 constant SPI_OVR                        \ [0x06] OVR
    $07 constant SPI_CRCE                       \ [0x07] CRCE
    $08 constant SPI_TIFRE                      \ [0x08] TIFRE
    $09 constant SPI_MODF                       \ [0x09] MODF
    $0a constant SPI_TSERF                      \ [0x0a] TSERF
    $0b constant SPI_SUSP                       \ [0x0b] SUSP
    $0c constant SPI_TXC                        \ [0x0c] TXC
    $0d constant SPI_RXPLVL                     \ [0x0d : 2] RXPLVL
    $0f constant SPI_RXWNE                      \ [0x0f] RXWNE
    $10 constant SPI_CTSIZE                     \ [0x10 : 16] CTSIZE
  [then]


  [ifdef] SPI_SPI2S_IFCR_DEF
    \
    \ @brief SPI/I2S interrupt/status flags clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant SPI_EOTC                       \ [0x03] EOTC
    $04 constant SPI_TXTFC                      \ [0x04] TXTFC
    $05 constant SPI_UDRC                       \ [0x05] UDRC
    $06 constant SPI_OVRC                       \ [0x06] OVRC
    $07 constant SPI_CRCEC                      \ [0x07] CRCEC
    $08 constant SPI_TIFREC                     \ [0x08] TIFREC
    $09 constant SPI_MODFC                      \ [0x09] MODFC
    $0a constant SPI_TSERFC                     \ [0x0a] TSERFC
    $0b constant SPI_SUSPC                      \ [0x0b] SUSPC
  [then]


  [ifdef] SPI_SPI2S_TXDR_DEF
    \
    \ @brief SPI/I2S transmit data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXDR                       \ [0x00 : 32] TXDR
  [then]


  [ifdef] SPI_SPI2S_RXDR_DEF
    \
    \ @brief SPI/I2S receive data register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXDR                       \ [0x00 : 32] RXDR
  [then]


  [ifdef] SPI_SPI_CRCPOLY_DEF
    \
    \ @brief SPI polynomial register
    \ Address offset: 0x40
    \ Reset value: 0x00000107
    \
    $00 constant SPI_CRCPOLY                    \ [0x00 : 32] CRCPOLY
  [then]


  [ifdef] SPI_SPI_TXCRC_DEF
    \
    \ @brief SPI transmitter CRC register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXCRC                      \ [0x00 : 32] TXCRC
  [then]


  [ifdef] SPI_SPI_RXCRC_DEF
    \
    \ @brief SPI receiver CRC register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXCRC                      \ [0x00 : 32] RXCRC
  [then]


  [ifdef] SPI_SPI_UDRDR_DEF
    \
    \ @brief SPI underrun data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_UDRDR                      \ [0x00 : 32] UDRDR
  [then]


  [ifdef] SPI_SPI_I2SCFGR_DEF
    \
    \ @brief All documented bits in this register must be configured when the I2S is disabled (SPE = 0).These bits are not used in SPI mode except for I2SMOD which needs to be set to 0 in SPI mode.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SPI_I2SMOD                     \ [0x00] I2SMOD
    $01 constant SPI_I2SCFG                     \ [0x01 : 3] I2SCFG
    $04 constant SPI_I2SSTD                     \ [0x04 : 2] I2SSTD
    $07 constant SPI_PCMSYNC                    \ [0x07] PCMSYNC
    $08 constant SPI_DATLEN                     \ [0x08 : 2] DATLEN
    $0a constant SPI_CHLEN                      \ [0x0a] CHLEN
    $0b constant SPI_CKPOL                      \ [0x0b] CKPOL
    $0c constant SPI_FIXCH                      \ [0x0c] FIXCH
    $0d constant SPI_WSINV                      \ [0x0d] WSINV
    $0e constant SPI_DATFMT                     \ [0x0e] DATFMT
    $10 constant SPI_I2SDIV                     \ [0x10 : 8] I2SDIV
    $18 constant SPI_ODD                        \ [0x18] ODD
    $19 constant SPI_MCKOE                      \ [0x19] MCKOE
  [then]


  [ifdef] SPI_SPI_I2S_HWCFGR_DEF
    \
    \ @brief SPI/I2S hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXFCFG                     \ [0x00 : 4] TXFCFG
    $04 constant SPI_RXFCFG                     \ [0x04 : 4] RXFCFG
    $08 constant SPI_CRCCFG                     \ [0x08 : 4] CRCCFG
    $0c constant SPI_I2SCFG                     \ [0x0c : 4] I2SCFG
    $10 constant SPI_DSCFG                      \ [0x10 : 4] DSCFG
  [then]


  [ifdef] SPI_SPI_VERR_DEF
    \
    \ @brief SPI/I2S version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000011
    \
    $00 constant SPI_MINREV                     \ [0x00 : 4] MINREV
    $04 constant SPI_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] SPI_SPI_IPIDR_DEF
    \
    \ @brief SPI/I2S identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00130022
    \
    $00 constant SPI_ID                         \ [0x00 : 32] ID
  [then]


  [ifdef] SPI_SPI_SIDR_DEF
    \
    \ @brief SPI/I2S size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant SPI_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief SPI1
  \
  $00 constant SPI_SPI2S_CR1            \ SPI/I2S control register 1
  $04 constant SPI_SPI_CR2              \ SPI control register 2
  $08 constant SPI_SPI_CFG1             \ Content of this register is write protected when SPI is enabled
  $0C constant SPI_SPI_CFG2             \ The content of this register is write protected when SPI is enabled or IOLOCK bit is set at SPI2S_CR1 register.
  $10 constant SPI_SPI2S_IER            \ SPI/I2S interrupt enable register
  $14 constant SPI_SPI2S_SR             \ SPI/I2S status register
  $18 constant SPI_SPI2S_IFCR           \ SPI/I2S interrupt/status flags clear register
  $20 constant SPI_SPI2S_TXDR           \ SPI/I2S transmit data register
  $30 constant SPI_SPI2S_RXDR           \ SPI/I2S receive data register
  $40 constant SPI_SPI_CRCPOLY          \ SPI polynomial register
  $44 constant SPI_SPI_TXCRC            \ SPI transmitter CRC register
  $48 constant SPI_SPI_RXCRC            \ SPI receiver CRC register
  $4C constant SPI_SPI_UDRDR            \ SPI underrun data register
  $50 constant SPI_SPI_I2SCFGR          \ All documented bits in this register must be configured when the I2S is disabled (SPE = 0).These bits are not used in SPI mode except for I2SMOD which needs to be set to 0 in SPI mode.
  $3F0 constant SPI_SPI_I2S_HWCFGR      \ SPI/I2S hardware configuration register
  $3F4 constant SPI_SPI_VERR            \ SPI/I2S version register
  $3F8 constant SPI_SPI_IPIDR           \ SPI/I2S identification register
  $3FC constant SPI_SPI_SIDR            \ SPI/I2S size identification register

: SPI_DEF ; [then]
