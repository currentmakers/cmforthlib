\
\ @file spi1_s.fs
\ @brief Serial peripheral interface
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

$00000001 constant SPI1_S_SPI_CR1_SPE                               \ serial peripheral enable
$00000100 constant SPI1_S_SPI_CR1_MASRX                             \ master automatic suspension in Receive mode
$00000200 constant SPI1_S_SPI_CR1_CSTART                            \ master transfer start
$00000400 constant SPI1_S_SPI_CR1_CSUSP                             \ master suspend request
$00000800 constant SPI1_S_SPI_CR1_HDDIR                             \ Rx/Tx direction at Half-duplex mode
$00001000 constant SPI1_S_SPI_CR1_SSI                               \ internal SS signal input level
$00002000 constant SPI1_S_SPI_CR1_CRC33_17                          \ 32-bit CRC polynomial configuration
$00004000 constant SPI1_S_SPI_CR1_RCRCINI                           \ CRC calculation initialization pattern control for receiver
$00008000 constant SPI1_S_SPI_CR1_TCRCINI                           \ CRC calculation initialization pattern control for transmitter
$00010000 constant SPI1_S_SPI_CR1_IOLOCK                            \ locking the AF configuration of associated I/Os


\
\ @brief SPI/I2S control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_S_SPI_CR2_TSIZE                             \ number of data at current transfer


\
\ @brief SPI/I2S configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00070007
\

$0000001f constant SPI1_S_SPI_CFG1_DSIZE                            \ number of bits in at single SPI data frame
$000001e0 constant SPI1_S_SPI_CFG1_FTHLV                            \ FIFO threshold level
$00000200 constant SPI1_S_SPI_CFG1_UDRCFG                           \ behavior of slave transmitter at underrun condition
$00004000 constant SPI1_S_SPI_CFG1_RXDMAEN                          \ Rx DMA stream enable
$00008000 constant SPI1_S_SPI_CFG1_TXDMAEN                          \ Tx DMA stream enable
$001f0000 constant SPI1_S_SPI_CFG1_CRCSIZE                          \ length of CRC frame to be transacted and compared
$00400000 constant SPI1_S_SPI_CFG1_CRCEN                            \ hardware CRC computation enable
$70000000 constant SPI1_S_SPI_CFG1_MBR                              \ master baud rate prescaler setting
$80000000 constant SPI1_S_SPI_CFG1_BPASS                            \ bypass of the prescaler at master baud rate clock generator


\
\ @brief SPI/I2S configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SPI1_S_SPI_CFG2_MSSI                             \ Master SS Idleness
$000000f0 constant SPI1_S_SPI_CFG2_MIDI                             \ master Inter-Data Idleness
$00002000 constant SPI1_S_SPI_CFG2_RDIOM                            \ RDY signal input/output management
$00004000 constant SPI1_S_SPI_CFG2_RDIOP                            \ RDY signal input/output polarity
$00008000 constant SPI1_S_SPI_CFG2_IOSWP                            \ swap functionality of MISO and MOSI pins
$00060000 constant SPI1_S_SPI_CFG2_COMM                             \ SPI Communication Mode
$00380000 constant SPI1_S_SPI_CFG2_SP                               \ serial protocol
$00400000 constant SPI1_S_SPI_CFG2_MASTER                           \ SPI Master
$00800000 constant SPI1_S_SPI_CFG2_LSBFRST                          \ data frame format
$01000000 constant SPI1_S_SPI_CFG2_CPHA                             \ clock phase
$02000000 constant SPI1_S_SPI_CFG2_CPOL                             \ clock polarity
$04000000 constant SPI1_S_SPI_CFG2_SSM                              \ software management of SS signal input
$10000000 constant SPI1_S_SPI_CFG2_SSIOP                            \ SS input/output polarity
$20000000 constant SPI1_S_SPI_CFG2_SSOE                             \ SS output enable
$40000000 constant SPI1_S_SPI_CFG2_SSOM                             \ SS output management in Master mode
$80000000 constant SPI1_S_SPI_CFG2_AFCNTR                           \ alternate function GPIOs control


\
\ @brief SPI/I2S interrupt enable register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SPI1_S_SPI_IER_RXPIE                             \ RXP interrupt enable
$00000002 constant SPI1_S_SPI_IER_TXPIE                             \ TXP interrupt enable
$00000004 constant SPI1_S_SPI_IER_DXPIE                             \ DXP interrupt enabled
$00000008 constant SPI1_S_SPI_IER_EOTIE                             \ EOT, SUSP and TXC interrupt enable
$00000010 constant SPI1_S_SPI_IER_TXTFIE                            \ TXTFIE interrupt enable
$00000020 constant SPI1_S_SPI_IER_UDRIE                             \ UDR interrupt enable
$00000040 constant SPI1_S_SPI_IER_OVRIE                             \ OVR interrupt enable
$00000080 constant SPI1_S_SPI_IER_CRCEIE                            \ CRC error interrupt enable
$00000100 constant SPI1_S_SPI_IER_TIFREIE                           \ TIFRE interrupt enable
$00000200 constant SPI1_S_SPI_IER_MODFIE                            \ mode Fault interrupt enable


\
\ @brief SPI/I2S status register
\ Address offset: 0x14
\ Reset value: 0x00001002
\

$00000001 constant SPI1_S_SPI_SR_RXP                                \ Rx-packet available
$00000002 constant SPI1_S_SPI_SR_TXP                                \ Tx-packet space available
$00000004 constant SPI1_S_SPI_SR_DXP                                \ duplex packet
$00000008 constant SPI1_S_SPI_SR_EOT                                \ end of transfer
$00000010 constant SPI1_S_SPI_SR_TXTF                               \ transmission transfer filled
$00000020 constant SPI1_S_SPI_SR_UDR                                \ underrun
$00000040 constant SPI1_S_SPI_SR_OVR                                \ overrun
$00000080 constant SPI1_S_SPI_SR_CRCE                               \ CRC error
$00000100 constant SPI1_S_SPI_SR_TIFRE                              \ TI frame format error
$00000200 constant SPI1_S_SPI_SR_MODF                               \ mode fault
$00000800 constant SPI1_S_SPI_SR_SUSP                               \ suspension status
$00001000 constant SPI1_S_SPI_SR_TXC                                \ TxFIFO transmission complete
$00006000 constant SPI1_S_SPI_SR_RXPLVL                             \ RxFIFO packing level
$00008000 constant SPI1_S_SPI_SR_RXWNE                              \ RxFIFO word not empty
$ffff0000 constant SPI1_S_SPI_SR_CTSIZE                             \ number of data frames remaining in current TSIZE session


\
\ @brief SPI/I2S interrupt/status flags clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000008 constant SPI1_S_SPI_IFCR_EOTC                             \ end of transfer flag clear
$00000010 constant SPI1_S_SPI_IFCR_TXTFC                            \ transmission transfer filled flag clear
$00000020 constant SPI1_S_SPI_IFCR_UDRC                             \ underrun flag clear
$00000040 constant SPI1_S_SPI_IFCR_OVRC                             \ overrun flag clear
$00000080 constant SPI1_S_SPI_IFCR_CRCEC                            \ CRC error flag clear
$00000100 constant SPI1_S_SPI_IFCR_TIFREC                           \ TI frame format error flag clear
$00000200 constant SPI1_S_SPI_IFCR_MODFC                            \ mode fault flag clear
$00000800 constant SPI1_S_SPI_IFCR_SUSPC                            \ Suspend flag clear


\
\ @brief SPI/I2S transmit data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SPI1_S_SPI_TXDR_TXDR                             \ transmit data register


\
\ @brief SPI/I2S receive data register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SPI1_S_SPI_RXDR_RXDR                             \ receive data register


\
\ @brief SPI/I2S polynomial register
\ Address offset: 0x40
\ Reset value: 0x00000107
\

$00000000 constant SPI1_S_SPI_CRCPOLY_CRCPOLY                       \ CRC polynomial register


\
\ @brief SPI/I2S transmitter CRC register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant SPI1_S_SPI_TXCRC_TXCRC                           \ CRC register for transmitter


\
\ @brief SPI/I2S receiver CRC register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant SPI1_S_SPI_RXCRC_RXCRC                           \ CRC register for receiver


\
\ @brief SPI/I2S underrun data register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SPI1_S_SPI_UDRDR_UDRDR                           \ data at slave underrun condition


\
\ @brief SPI/I2S configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SPI1_S_SPI_I2SCFGR_I2SMOD                        \ I2S mode selection
$0000000e constant SPI1_S_SPI_I2SCFGR_I2SCFG                        \ I2S configuration mode
$00000030 constant SPI1_S_SPI_I2SCFGR_I2SSTD                        \ Iless thansup>2less than/sup>S standard selection
$00000080 constant SPI1_S_SPI_I2SCFGR_PCMSYNC                       \ PCM frame synchronization
$00000300 constant SPI1_S_SPI_I2SCFGR_DATLEN                        \ data length to be transferred. Data width of 24 and 32 bits are not always supported, (DATLEN = 01 or 10), refer to Section 58.3: SPI implementation to check the supported data size.
$00000400 constant SPI1_S_SPI_I2SCFGR_CHLEN                         \ channel length (number of bits per audio channel)
$00000800 constant SPI1_S_SPI_I2SCFGR_CKPOL                         \ serial audio clock polarity
$00001000 constant SPI1_S_SPI_I2SCFGR_FIXCH                         \ fixed channel length in slave
$00002000 constant SPI1_S_SPI_I2SCFGR_WSINV                         \ word select inversion
$00004000 constant SPI1_S_SPI_I2SCFGR_DATFMT                        \ data format
$00ff0000 constant SPI1_S_SPI_I2SCFGR_I2SDIV                        \ Iless thansup>2less than/sup>S linear prescaler
$01000000 constant SPI1_S_SPI_I2SCFGR_ODD                           \ odd factor for the prescaler
$02000000 constant SPI1_S_SPI_I2SCFGR_MCKOE                         \ master clock output enable


\
\ @brief Serial peripheral interface
\
$52003000 constant SPI1_S_SPI_CR1  \ offset: 0x00 : SPI/I2S control register 1
$52003004 constant SPI1_S_SPI_CR2  \ offset: 0x04 : SPI/I2S control register 2
$52003008 constant SPI1_S_SPI_CFG1  \ offset: 0x08 : SPI/I2S configuration register 1
$5200300c constant SPI1_S_SPI_CFG2  \ offset: 0x0C : SPI/I2S configuration register 2
$52003010 constant SPI1_S_SPI_IER  \ offset: 0x10 : SPI/I2S interrupt enable register
$52003014 constant SPI1_S_SPI_SR  \ offset: 0x14 : SPI/I2S status register
$52003018 constant SPI1_S_SPI_IFCR  \ offset: 0x18 : SPI/I2S interrupt/status flags clear register
$52003020 constant SPI1_S_SPI_TXDR  \ offset: 0x20 : SPI/I2S transmit data register
$52003030 constant SPI1_S_SPI_RXDR  \ offset: 0x30 : SPI/I2S receive data register
$52003040 constant SPI1_S_SPI_CRCPOLY  \ offset: 0x40 : SPI/I2S polynomial register
$52003044 constant SPI1_S_SPI_TXCRC  \ offset: 0x44 : SPI/I2S transmitter CRC register
$52003048 constant SPI1_S_SPI_RXCRC  \ offset: 0x48 : SPI/I2S receiver CRC register
$5200304c constant SPI1_S_SPI_UDRDR  \ offset: 0x4C : SPI/I2S underrun data register
$52003050 constant SPI1_S_SPI_I2SCFGR  \ offset: 0x50 : SPI/I2S configuration register

