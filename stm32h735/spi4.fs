\
\ @file spi4.fs
\ @brief SPI4 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SPI4_CR1_SPE                                     \ Serial Peripheral Enable
$00000100 constant SPI4_CR1_MASRX                                   \ Master automatic SUSP in Receive mode
$00000200 constant SPI4_CR1_CSTART                                  \ Master transfer start
$00000400 constant SPI4_CR1_CSUSP                                   \ Master SUSPend request
$00000800 constant SPI4_CR1_HDDIR                                   \ Rx/Tx direction at Half-duplex mode
$00001000 constant SPI4_CR1_SSI                                     \ Internal SS signal input level
$00002000 constant SPI4_CR1_CRC33_17                                \ 32-bit CRC polynomial configuration
$00004000 constant SPI4_CR1_RCRCI                                   \ CRC calculation initialization pattern control for receiver
$00008000 constant SPI4_CR1_TCRCI                                   \ CRC calculation initialization pattern control for transmitter
$00010000 constant SPI4_CR1_IOLOCK                                  \ Locking the AF configuration of associated IOs


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000ffff constant SPI4_CR2_TSIZE                                   \ Number of data at current transfer
$ffff0000 constant SPI4_CR2_TSER                                    \ Number of data transfer extension to be reload into TSIZE just when a previous


\
\ @brief configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00070007
\

$0000001f constant SPI4_CFG1_DSIZE                                  \ Number of bits in at single SPI data frame
$000001e0 constant SPI4_CFG1_FTHVL                                  \ threshold level
$00000600 constant SPI4_CFG1_UDRCFG                                 \ Behavior of slave transmitter at underrun condition
$00001800 constant SPI4_CFG1_UDRDET                                 \ Detection of underrun condition at slave transmitter
$00004000 constant SPI4_CFG1_RXDMAEN                                \ Rx DMA stream enable
$00008000 constant SPI4_CFG1_TXDMAEN                                \ Tx DMA stream enable
$001f0000 constant SPI4_CFG1_CRCSIZE                                \ Length of CRC frame to be transacted and compared
$00400000 constant SPI4_CFG1_CRCEN                                  \ Hardware CRC computation enable
$70000000 constant SPI4_CFG1_MBR                                    \ Master baud rate


\
\ @brief configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SPI4_CFG2_MSSI                                   \ Master SS Idleness
$000000f0 constant SPI4_CFG2_MIDI                                   \ Master Inter-Data Idleness
$00008000 constant SPI4_CFG2_IOSWP                                  \ Swap functionality of MISO and MOSI pins
$00060000 constant SPI4_CFG2_COMM                                   \ SPI Communication Mode
$00380000 constant SPI4_CFG2_SP                                     \ Serial Protocol
$00400000 constant SPI4_CFG2_MASTER                                 \ SPI Master
$00800000 constant SPI4_CFG2_LSBFRST                                \ Data frame format
$01000000 constant SPI4_CFG2_CPHA                                   \ Clock phase
$02000000 constant SPI4_CFG2_CPOL                                   \ Clock polarity
$04000000 constant SPI4_CFG2_SSM                                    \ Software management of SS signal input
$10000000 constant SPI4_CFG2_SSIOP                                  \ SS input/output polarity
$20000000 constant SPI4_CFG2_SSOE                                   \ SS output enable
$40000000 constant SPI4_CFG2_SSOM                                   \ SS output management in master mode
$80000000 constant SPI4_CFG2_AFCNTR                                 \ Alternate function GPIOs control


\
\ @brief Interrupt Enable Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SPI4_IER_RXPIE                                   \ RXP Interrupt Enable
$00000002 constant SPI4_IER_TXPIE                                   \ TXP interrupt enable
$00000004 constant SPI4_IER_DPXPIE                                  \ DXP interrupt enabled
$00000008 constant SPI4_IER_EOTIE                                   \ EOT, SUSP and TXC interrupt enable
$00000010 constant SPI4_IER_TXTFIE                                  \ TXTFIE interrupt enable
$00000020 constant SPI4_IER_UDRIE                                   \ UDR interrupt enable
$00000040 constant SPI4_IER_OVRIE                                   \ OVR interrupt enable
$00000080 constant SPI4_IER_CRCEIE                                  \ CRC Interrupt enable
$00000100 constant SPI4_IER_TIFREIE                                 \ TIFRE interrupt enable
$00000200 constant SPI4_IER_MODFIE                                  \ Mode Fault interrupt enable
$00000400 constant SPI4_IER_TSERFIE                                 \ Additional number of transactions reload interrupt enable


\
\ @brief Status Register
\ Address offset: 0x14
\ Reset value: 0x00001002
\

$00000001 constant SPI4_SR_RXP                                      \ Rx-Packet available
$00000002 constant SPI4_SR_TXP                                      \ Tx-Packet space available
$00000004 constant SPI4_SR_DXP                                      \ Duplex Packet
$00000008 constant SPI4_SR_EOT                                      \ End Of Transfer
$00000010 constant SPI4_SR_TXTF                                     \ Transmission Transfer Filled
$00000020 constant SPI4_SR_UDR                                      \ Underrun at slave transmission mode
$00000040 constant SPI4_SR_OVR                                      \ Overrun
$00000080 constant SPI4_SR_CRCE                                     \ CRC Error
$00000100 constant SPI4_SR_TIFRE                                    \ TI frame format error
$00000200 constant SPI4_SR_MODF                                     \ Mode Fault
$00000400 constant SPI4_SR_TSERF                                    \ Additional number of SPI data to be transacted was reload
$00000800 constant SPI4_SR_SUSP                                     \ SUSPend
$00001000 constant SPI4_SR_TXC                                      \ TxFIFO transmission complete
$00006000 constant SPI4_SR_RXPLVL                                   \ RxFIFO Packing LeVeL
$00008000 constant SPI4_SR_RXWNE                                    \ RxFIFO Word Not Empty
$ffff0000 constant SPI4_SR_CTSIZE                                   \ Number of data frames remaining in current TSIZE session


\
\ @brief Interrupt/Status Flags Clear Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000008 constant SPI4_IFCR_EOTC                                   \ End Of Transfer flag clear
$00000010 constant SPI4_IFCR_TXTFC                                  \ Transmission Transfer Filled flag clear
$00000020 constant SPI4_IFCR_UDRC                                   \ Underrun flag clear
$00000040 constant SPI4_IFCR_OVRC                                   \ Overrun flag clear
$00000080 constant SPI4_IFCR_CRCEC                                  \ CRC Error flag clear
$00000100 constant SPI4_IFCR_TIFREC                                 \ TI frame format error flag clear
$00000200 constant SPI4_IFCR_MODFC                                  \ Mode Fault flag clear
$00000400 constant SPI4_IFCR_TSERFC                                 \ TSERFC flag clear
$00000800 constant SPI4_IFCR_SUSPC                                  \ SUSPend flag clear


\
\ @brief Transmit Data Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SPI4_TXDR_TXDR                                   \ Transmit data register


\
\ @brief Receive Data Register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SPI4_RXDR_RXDR                                   \ Receive data register


\
\ @brief Polynomial Register
\ Address offset: 0x40
\ Reset value: 0x00000107
\

$00000000 constant SPI4_CRCPOLY_CRCPOLY                             \ CRC polynomial register


\
\ @brief Transmitter CRC Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant SPI4_TXCRC_TXCRC                                 \ CRC register for transmitter


\
\ @brief Receiver CRC Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant SPI4_RXCRC_RXCRC                                 \ CRC register for receiver


\
\ @brief Underrun Data Register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SPI4_UDRDR_UDRDR                                 \ Data at slave underrun condition


\
\ @brief configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SPI4_I2SCFGR_I2SMOD                              \ I2S mode selection
$0000000e constant SPI4_I2SCFGR_I2SCFG                              \ I2S configuration mode
$00000030 constant SPI4_I2SCFGR_I2SSTD                              \ I2S standard selection
$00000080 constant SPI4_I2SCFGR_PCMSYNC                             \ PCM frame synchronization
$00000300 constant SPI4_I2SCFGR_DATLEN                              \ Data length to be transferred
$00000400 constant SPI4_I2SCFGR_CHLEN                               \ Channel length (number of bits per audio channel)
$00000800 constant SPI4_I2SCFGR_CKPOL                               \ Serial audio clock polarity
$00001000 constant SPI4_I2SCFGR_FIXCH                               \ Word select inversion
$00002000 constant SPI4_I2SCFGR_WSINV                               \ Fixed channel length in SLAVE
$00004000 constant SPI4_I2SCFGR_DATFMT                              \ Data format
$00ff0000 constant SPI4_I2SCFGR_I2SDIV                              \ I2S linear prescaler
$01000000 constant SPI4_I2SCFGR_ODD                                 \ Odd factor for the prescaler
$02000000 constant SPI4_I2SCFGR_MCKOE                               \ Master clock output enable


\
\ @brief SPI4 global interrupt
\
$40013400 constant SPI4_CR1       \ offset: 0x00 : control register 1
$40013404 constant SPI4_CR2       \ offset: 0x04 : control register 2
$40013408 constant SPI4_CFG1      \ offset: 0x08 : configuration register 1
$4001340c constant SPI4_CFG2      \ offset: 0x0C : configuration register 2
$40013410 constant SPI4_IER       \ offset: 0x10 : Interrupt Enable Register
$40013414 constant SPI4_SR        \ offset: 0x14 : Status Register
$40013418 constant SPI4_IFCR      \ offset: 0x18 : Interrupt/Status Flags Clear Register
$40013420 constant SPI4_TXDR      \ offset: 0x20 : Transmit Data Register
$40013430 constant SPI4_RXDR      \ offset: 0x30 : Receive Data Register
$40013440 constant SPI4_CRCPOLY   \ offset: 0x40 : Polynomial Register
$40013444 constant SPI4_TXCRC     \ offset: 0x44 : Transmitter CRC Register
$40013448 constant SPI4_RXCRC     \ offset: 0x48 : Receiver CRC Register
$4001344c constant SPI4_UDRDR     \ offset: 0x4C : Underrun Data Register
$40013450 constant SPI4_I2SCFGR   \ offset: 0x50 : configuration register

