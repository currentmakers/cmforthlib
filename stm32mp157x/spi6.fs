\
\ @file spi6.fs
\ @brief SPI6 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SPI/I2S control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SPI6_SPI2S_CR1_SPE                               \ SPE
$00000100 constant SPI6_SPI2S_CR1_MASRX                             \ MASRX
$00000200 constant SPI6_SPI2S_CR1_CSTART                            \ CSTART
$00000400 constant SPI6_SPI2S_CR1_CSUSP                             \ CSUSP
$00000800 constant SPI6_SPI2S_CR1_HDDIR                             \ HDDIR
$00001000 constant SPI6_SPI2S_CR1_SSI                               \ SSI
$00002000 constant SPI6_SPI2S_CR1_CRC33_17                          \ CRC33_17
$00004000 constant SPI6_SPI2S_CR1_RCRCINI                           \ RCRCINI
$00008000 constant SPI6_SPI2S_CR1_TCRCINI                           \ TCRCINI
$00010000 constant SPI6_SPI2S_CR1_IOLOCK                            \ IOLOCK


\
\ @brief SPI control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000ffff constant SPI6_SPI_CR2_TSIZE                               \ TSIZE
$ffff0000 constant SPI6_SPI_CR2_TSER                                \ TSER


\
\ @brief Content of this register is write protected when SPI is enabled
\ Address offset: 0x08
\ Reset value: 0x00070007
\

$0000001f constant SPI6_SPI_CFG1_DSIZE                              \ DSIZE
$000001e0 constant SPI6_SPI_CFG1_FTHLV                              \ FTHLV
$00000600 constant SPI6_SPI_CFG1_UDRCFG                             \ UDRCFG
$00001800 constant SPI6_SPI_CFG1_UDRDET                             \ UDRDET
$00004000 constant SPI6_SPI_CFG1_RXDMAEN                            \ RXDMAEN
$00008000 constant SPI6_SPI_CFG1_TXDMAEN                            \ TXDMAEN
$001f0000 constant SPI6_SPI_CFG1_CRCSIZE                            \ CRCSIZE
$00400000 constant SPI6_SPI_CFG1_CRCEN                              \ CRCEN
$70000000 constant SPI6_SPI_CFG1_MBR                                \ MBR


\
\ @brief The content of this register is write protected when SPI is enabled or IOLOCK bit is set at SPI2S_CR1 register.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SPI6_SPI_CFG2_MSSI                               \ MSSI
$000000f0 constant SPI6_SPI_CFG2_MIDI                               \ MIDI
$00008000 constant SPI6_SPI_CFG2_IOSWP                              \ IOSWP
$00060000 constant SPI6_SPI_CFG2_COMM                               \ COMM
$00380000 constant SPI6_SPI_CFG2_SP                                 \ SP
$00400000 constant SPI6_SPI_CFG2_MASTER                             \ MASTER
$00800000 constant SPI6_SPI_CFG2_LSBFRST                            \ LSBFRST
$01000000 constant SPI6_SPI_CFG2_CPHA                               \ CPHA
$02000000 constant SPI6_SPI_CFG2_CPOL                               \ CPOL
$04000000 constant SPI6_SPI_CFG2_SSM                                \ SSM
$10000000 constant SPI6_SPI_CFG2_SSIOP                              \ SSIOP
$20000000 constant SPI6_SPI_CFG2_SSOE                               \ SSOE
$40000000 constant SPI6_SPI_CFG2_SSOM                               \ SSOM
$80000000 constant SPI6_SPI_CFG2_AFCNTR                             \ AFCNTR


\
\ @brief SPI/I2S interrupt enable register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SPI6_SPI2S_IER_RXPIE                             \ RXPIE
$00000002 constant SPI6_SPI2S_IER_TXPIE                             \ TXPIE
$00000004 constant SPI6_SPI2S_IER_DXPIE                             \ DXPIE
$00000008 constant SPI6_SPI2S_IER_EOTIE                             \ EOTIE
$00000010 constant SPI6_SPI2S_IER_TXTFIE                            \ TXTFIE
$00000020 constant SPI6_SPI2S_IER_UDRIE                             \ UDRIE
$00000040 constant SPI6_SPI2S_IER_OVRIE                             \ OVRIE
$00000080 constant SPI6_SPI2S_IER_CRCEIE                            \ CRCEIE
$00000100 constant SPI6_SPI2S_IER_TIFREIE                           \ TIFREIE
$00000200 constant SPI6_SPI2S_IER_MODFIE                            \ MODFIE
$00000400 constant SPI6_SPI2S_IER_TSERFIE                           \ TSERFIE


\
\ @brief SPI/I2S status register
\ Address offset: 0x14
\ Reset value: 0x00001002
\

$00000001 constant SPI6_SPI2S_SR_RXP                                \ RXP
$00000002 constant SPI6_SPI2S_SR_TXP                                \ TXP
$00000004 constant SPI6_SPI2S_SR_DXP                                \ DXP
$00000008 constant SPI6_SPI2S_SR_EOT                                \ EOT
$00000010 constant SPI6_SPI2S_SR_TXTF                               \ TXTF
$00000020 constant SPI6_SPI2S_SR_UDR                                \ UDR
$00000040 constant SPI6_SPI2S_SR_OVR                                \ OVR
$00000080 constant SPI6_SPI2S_SR_CRCE                               \ CRCE
$00000100 constant SPI6_SPI2S_SR_TIFRE                              \ TIFRE
$00000200 constant SPI6_SPI2S_SR_MODF                               \ MODF
$00000400 constant SPI6_SPI2S_SR_TSERF                              \ TSERF
$00000800 constant SPI6_SPI2S_SR_SUSP                               \ SUSP
$00001000 constant SPI6_SPI2S_SR_TXC                                \ TXC
$00006000 constant SPI6_SPI2S_SR_RXPLVL                             \ RXPLVL
$00008000 constant SPI6_SPI2S_SR_RXWNE                              \ RXWNE
$ffff0000 constant SPI6_SPI2S_SR_CTSIZE                             \ CTSIZE


\
\ @brief SPI/I2S interrupt/status flags clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000008 constant SPI6_SPI2S_IFCR_EOTC                             \ EOTC
$00000010 constant SPI6_SPI2S_IFCR_TXTFC                            \ TXTFC
$00000020 constant SPI6_SPI2S_IFCR_UDRC                             \ UDRC
$00000040 constant SPI6_SPI2S_IFCR_OVRC                             \ OVRC
$00000080 constant SPI6_SPI2S_IFCR_CRCEC                            \ CRCEC
$00000100 constant SPI6_SPI2S_IFCR_TIFREC                           \ TIFREC
$00000200 constant SPI6_SPI2S_IFCR_MODFC                            \ MODFC
$00000400 constant SPI6_SPI2S_IFCR_TSERFC                           \ TSERFC
$00000800 constant SPI6_SPI2S_IFCR_SUSPC                            \ SUSPC


\
\ @brief SPI/I2S transmit data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SPI6_SPI2S_TXDR_TXDR                             \ TXDR


\
\ @brief SPI/I2S receive data register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SPI6_SPI2S_RXDR_RXDR                             \ RXDR


\
\ @brief SPI polynomial register
\ Address offset: 0x40
\ Reset value: 0x00000107
\

$00000000 constant SPI6_SPI_CRCPOLY_CRCPOLY                         \ CRCPOLY


\
\ @brief SPI transmitter CRC register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant SPI6_SPI_TXCRC_TXCRC                             \ TXCRC


\
\ @brief SPI receiver CRC register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant SPI6_SPI_RXCRC_RXCRC                             \ RXCRC


\
\ @brief SPI underrun data register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SPI6_SPI_UDRDR_UDRDR                             \ UDRDR


\
\ @brief All documented bits in this register must be configured when the I2S is disabled (SPE = 0).These bits are not used in SPI mode except for I2SMOD which needs to be set to 0 in SPI mode.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SPI6_SPI_I2SCFGR_I2SMOD                          \ I2SMOD
$0000000e constant SPI6_SPI_I2SCFGR_I2SCFG                          \ I2SCFG
$00000030 constant SPI6_SPI_I2SCFGR_I2SSTD                          \ I2SSTD
$00000080 constant SPI6_SPI_I2SCFGR_PCMSYNC                         \ PCMSYNC
$00000300 constant SPI6_SPI_I2SCFGR_DATLEN                          \ DATLEN
$00000400 constant SPI6_SPI_I2SCFGR_CHLEN                           \ CHLEN
$00000800 constant SPI6_SPI_I2SCFGR_CKPOL                           \ CKPOL
$00001000 constant SPI6_SPI_I2SCFGR_FIXCH                           \ FIXCH
$00002000 constant SPI6_SPI_I2SCFGR_WSINV                           \ WSINV
$00004000 constant SPI6_SPI_I2SCFGR_DATFMT                          \ DATFMT
$00ff0000 constant SPI6_SPI_I2SCFGR_I2SDIV                          \ I2SDIV
$01000000 constant SPI6_SPI_I2SCFGR_ODD                             \ ODD
$02000000 constant SPI6_SPI_I2SCFGR_MCKOE                           \ MCKOE


\
\ @brief SPI/I2S hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$0000000f constant SPI6_SPI_I2S_HWCFGR_TXFCFG                       \ TXFCFG
$000000f0 constant SPI6_SPI_I2S_HWCFGR_RXFCFG                       \ RXFCFG
$00000f00 constant SPI6_SPI_I2S_HWCFGR_CRCCFG                       \ CRCCFG
$0000f000 constant SPI6_SPI_I2S_HWCFGR_I2SCFG                       \ I2SCFG
$000f0000 constant SPI6_SPI_I2S_HWCFGR_DSCFG                        \ DSCFG


\
\ @brief SPI/I2S version register
\ Address offset: 0x3F4
\ Reset value: 0x00000011
\

$0000000f constant SPI6_SPI_VERR_MINREV                             \ MINREV
$000000f0 constant SPI6_SPI_VERR_MAJREV                             \ MAJREV


\
\ @brief SPI/I2S identification register
\ Address offset: 0x3F8
\ Reset value: 0x00130022
\

$00000000 constant SPI6_SPI_IPIDR_ID                                \ ID


\
\ @brief SPI/I2S size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant SPI6_SPI_SIDR_SID                                \ SID


\
\ @brief SPI6 global interrupt
\
$5c001000 constant SPI6_SPI2S_CR1  \ offset: 0x00 : SPI/I2S control register 1
$5c001004 constant SPI6_SPI_CR2   \ offset: 0x04 : SPI control register 2
$5c001008 constant SPI6_SPI_CFG1  \ offset: 0x08 : Content of this register is write protected when SPI is enabled
$5c00100c constant SPI6_SPI_CFG2  \ offset: 0x0C : The content of this register is write protected when SPI is enabled or IOLOCK bit is set at SPI2S_CR1 register.
$5c001010 constant SPI6_SPI2S_IER  \ offset: 0x10 : SPI/I2S interrupt enable register
$5c001014 constant SPI6_SPI2S_SR  \ offset: 0x14 : SPI/I2S status register
$5c001018 constant SPI6_SPI2S_IFCR  \ offset: 0x18 : SPI/I2S interrupt/status flags clear register
$5c001020 constant SPI6_SPI2S_TXDR  \ offset: 0x20 : SPI/I2S transmit data register
$5c001030 constant SPI6_SPI2S_RXDR  \ offset: 0x30 : SPI/I2S receive data register
$5c001040 constant SPI6_SPI_CRCPOLY  \ offset: 0x40 : SPI polynomial register
$5c001044 constant SPI6_SPI_TXCRC  \ offset: 0x44 : SPI transmitter CRC register
$5c001048 constant SPI6_SPI_RXCRC  \ offset: 0x48 : SPI receiver CRC register
$5c00104c constant SPI6_SPI_UDRDR  \ offset: 0x4C : SPI underrun data register
$5c001050 constant SPI6_SPI_I2SCFGR  \ offset: 0x50 : All documented bits in this register must be configured when the I2S is disabled (SPE = 0).These bits are not used in SPI mode except for I2SMOD which needs to be set to 0 in SPI mode.
$5c0013f0 constant SPI6_SPI_I2S_HWCFGR  \ offset: 0x3F0 : SPI/I2S hardware configuration register
$5c0013f4 constant SPI6_SPI_VERR  \ offset: 0x3F4 : SPI/I2S version register
$5c0013f8 constant SPI6_SPI_IPIDR  \ offset: 0x3F8 : SPI/I2S identification register
$5c0013fc constant SPI6_SPI_SIDR  \ offset: 0x3FC : SPI/I2S size identification register

