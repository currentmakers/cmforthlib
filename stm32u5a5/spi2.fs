\
\ @file spi2.fs
\ @brief SPI2 global interrupt
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

$00000001 constant SPI2_CR1_SPE                                     \ SPE
$00000100 constant SPI2_CR1_MASRX                                   \ MASRX
$00000200 constant SPI2_CR1_CSTART                                  \ CSTART
$00000400 constant SPI2_CR1_CSUSP                                   \ CSUSP
$00000800 constant SPI2_CR1_HDDIR                                   \ HDDIR
$00001000 constant SPI2_CR1_SSI                                     \ SSI
$00002000 constant SPI2_CR1_CRC33_17                                \ CRC33_17
$00004000 constant SPI2_CR1_RCRCINI                                 \ RCRCINI
$00008000 constant SPI2_CR1_TCRCINI                                 \ TCRCINI
$00010000 constant SPI2_CR1_IOLOCK                                  \ IOLOCK


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000ffff constant SPI2_CR2_TSIZE                                   \ TSIZE


\
\ @brief configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00070007
\

$0000001f constant SPI2_CFG1_DSIZE                                  \ Number of bits in at single SPI data frame
$000001e0 constant SPI2_CFG1_FTHVL                                  \ threshold level
$00000200 constant SPI2_CFG1_UDRCFG                                 \ Behavior of slave transmitter at underrun condition
$00004000 constant SPI2_CFG1_RXDMAEN                                \ Rx DMA stream enable
$00008000 constant SPI2_CFG1_TXDMAEN                                \ Tx DMA stream enable
$001f0000 constant SPI2_CFG1_CRCSIZE                                \ Length of CRC frame to be transacted and compared
$00400000 constant SPI2_CFG1_CRCEN                                  \ Hardware CRC computation enable
$70000000 constant SPI2_CFG1_MBR                                    \ Master baud rate
$80000000 constant SPI2_CFG1_BPASS                                  \ BPASS


\
\ @brief configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SPI2_CFG2_MSSI                                   \ Master SS Idleness
$000000f0 constant SPI2_CFG2_MIDI                                   \ Master Inter-Data Idleness
$00002000 constant SPI2_CFG2_RDIMM                                  \ RDIMM
$00004000 constant SPI2_CFG2_RDIOP                                  \ RDIOP
$00008000 constant SPI2_CFG2_IOSWP                                  \ Swap functionality of MISO and MOSI pins
$00060000 constant SPI2_CFG2_COMM                                   \ SPI Communication Mode
$00380000 constant SPI2_CFG2_SP                                     \ Serial Protocol
$00400000 constant SPI2_CFG2_MASTER                                 \ SPI Master
$00800000 constant SPI2_CFG2_LSBFRST                                \ Data frame format
$01000000 constant SPI2_CFG2_CPHA                                   \ Clock phase
$02000000 constant SPI2_CFG2_CPOL                                   \ Clock polarity
$04000000 constant SPI2_CFG2_SSM                                    \ Software management of SS signal input
$10000000 constant SPI2_CFG2_SSIOP                                  \ SS input/output polarity
$20000000 constant SPI2_CFG2_SSOE                                   \ SS output enable
$40000000 constant SPI2_CFG2_SSOM                                   \ SS output management in master mode
$80000000 constant SPI2_CFG2_AFCNTR                                 \ Alternate function GPIOs control


\
\ @brief Interrupt Enable Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SPI2_IER_RXPIE                                   \ RXP Interrupt Enable
$00000002 constant SPI2_IER_TXPIE                                   \ TXP interrupt enable
$00000004 constant SPI2_IER_DPXPIE                                  \ DXP interrupt enabled
$00000008 constant SPI2_IER_EOTIE                                   \ EOT, SUSP and TXC interrupt enable
$00000010 constant SPI2_IER_TXTFIE                                  \ TXTFIE interrupt enable
$00000020 constant SPI2_IER_UDRIE                                   \ UDR interrupt enable
$00000040 constant SPI2_IER_OVRIE                                   \ OVR interrupt enable
$00000080 constant SPI2_IER_CRCEIE                                  \ CRC Interrupt enable
$00000100 constant SPI2_IER_TIFREIE                                 \ TIFRE interrupt enable
$00000200 constant SPI2_IER_MODFIE                                  \ Mode Fault interrupt enable


\
\ @brief Status Register
\ Address offset: 0x14
\ Reset value: 0x00001002
\

$00000001 constant SPI2_SR_RXP                                      \ Rx-Packet available
$00000002 constant SPI2_SR_TXP                                      \ Tx-Packet space available
$00000004 constant SPI2_SR_DXP                                      \ Duplex Packet
$00000008 constant SPI2_SR_EOT                                      \ End Of Transfer
$00000010 constant SPI2_SR_TXTF                                     \ Transmission Transfer Filled
$00000020 constant SPI2_SR_UDR                                      \ Underrun at slave transmission mode
$00000040 constant SPI2_SR_OVR                                      \ Overrun
$00000080 constant SPI2_SR_CRCE                                     \ CRC Error
$00000100 constant SPI2_SR_TIFRE                                    \ TI frame format error
$00000200 constant SPI2_SR_MODF                                     \ Mode Fault
$00000800 constant SPI2_SR_SUSP                                     \ SUSPend
$00001000 constant SPI2_SR_TXC                                      \ TxFIFO transmission complete
$00006000 constant SPI2_SR_RXPLVL                                   \ RxFIFO Packing LeVeL
$00008000 constant SPI2_SR_RXWNE                                    \ RxFIFO Word Not Empty
$ffff0000 constant SPI2_SR_CTSIZE                                   \ Number of data frames remaining in current TSIZE session


\
\ @brief Interrupt/Status Flags Clear Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000008 constant SPI2_IFCR_EOTC                                   \ End Of Transfer flag clear
$00000010 constant SPI2_IFCR_TXTFC                                  \ Transmission Transfer Filled flag clear
$00000020 constant SPI2_IFCR_UDRC                                   \ Underrun flag clear
$00000040 constant SPI2_IFCR_OVRC                                   \ Overrun flag clear
$00000080 constant SPI2_IFCR_CRCEC                                  \ CRC Error flag clear
$00000100 constant SPI2_IFCR_TIFREC                                 \ TI frame format error flag clear
$00000200 constant SPI2_IFCR_MODFC                                  \ Mode Fault flag clear
$00000800 constant SPI2_IFCR_SUSPC                                  \ SUSPend flag clear


\
\ @brief SPI autonomous mode control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000f0000 constant SPI2_AUTOCR_TRIGSEL                              \ TRIGSEL
$00100000 constant SPI2_AUTOCR_TRIGPOL                              \ TRIGPOL
$00200000 constant SPI2_AUTOCR_TRIGEN                               \ TRIGEN


\
\ @brief Transmit Data Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SPI2_TXDR_TXDR                                   \ Transmit data register


\
\ @brief Receive Data Register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SPI2_RXDR_RXDR                                   \ Receive data register


\
\ @brief Polynomial Register
\ Address offset: 0x40
\ Reset value: 0x00000107
\

$00000000 constant SPI2_CRCPOLY_CRCPOLY                             \ CRC polynomial register


\
\ @brief Transmitter CRC Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant SPI2_TXCRC_TXCRC                                 \ CRC register for transmitter


\
\ @brief Receiver CRC Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant SPI2_RXCRC_RXCRC                                 \ CRC register for receiver


\
\ @brief Underrun Data Register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SPI2_UDRDR_UDRDR                                 \ Data at slave underrun condition


\
\ @brief SPI2 global interrupt
\
$40003800 constant SPI2_CR1       \ offset: 0x00 : control register 1
$40003804 constant SPI2_CR2       \ offset: 0x04 : control register 2
$40003808 constant SPI2_CFG1      \ offset: 0x08 : configuration register 1
$4000380c constant SPI2_CFG2      \ offset: 0x0C : configuration register 2
$40003810 constant SPI2_IER       \ offset: 0x10 : Interrupt Enable Register
$40003814 constant SPI2_SR        \ offset: 0x14 : Status Register
$40003818 constant SPI2_IFCR      \ offset: 0x18 : Interrupt/Status Flags Clear Register
$4000381c constant SPI2_AUTOCR    \ offset: 0x1C : SPI autonomous mode control register
$40003820 constant SPI2_TXDR      \ offset: 0x20 : Transmit Data Register
$40003830 constant SPI2_RXDR      \ offset: 0x30 : Receive Data Register
$40003840 constant SPI2_CRCPOLY   \ offset: 0x40 : Polynomial Register
$40003844 constant SPI2_TXCRC     \ offset: 0x44 : Transmitter CRC Register
$40003848 constant SPI2_RXCRC     \ offset: 0x48 : Receiver CRC Register
$4000384c constant SPI2_UDRDR     \ offset: 0x4C : Underrun Data Register

