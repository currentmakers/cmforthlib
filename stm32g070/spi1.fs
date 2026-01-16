\
\ @file spi1.fs
\ @brief Serial peripheral interface/Inter-IC       sound
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

$00000001 constant SPI1_CR1_CPHA                                    \ Clock phase
$00000002 constant SPI1_CR1_CPOL                                    \ Clock polarity
$00000004 constant SPI1_CR1_MSTR                                    \ Master selection
$00000038 constant SPI1_CR1_BR                                      \ Baud rate control
$00000040 constant SPI1_CR1_SPE                                     \ SPI enable
$00000080 constant SPI1_CR1_LSBFIRST                                \ Frame format
$00000100 constant SPI1_CR1_SSI                                     \ Internal slave select
$00000200 constant SPI1_CR1_SSM                                     \ Software slave management
$00000400 constant SPI1_CR1_RXONLY                                  \ Receive only
$00000800 constant SPI1_CR1_DFF                                     \ Data frame format
$00001000 constant SPI1_CR1_CRCNEXT                                 \ CRC transfer next
$00002000 constant SPI1_CR1_CRCEN                                   \ Hardware CRC calculation enable
$00004000 constant SPI1_CR1_BIDIOE                                  \ Output enable in bidirectional mode
$00008000 constant SPI1_CR1_BIDIMODE                                \ Bidirectional data mode enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SPI1_CR2_RXDMAEN                                 \ Rx buffer DMA enable
$00000002 constant SPI1_CR2_TXDMAEN                                 \ Tx buffer DMA enable
$00000004 constant SPI1_CR2_SSOE                                    \ SS output enable
$00000008 constant SPI1_CR2_NSSP                                    \ NSS pulse management
$00000010 constant SPI1_CR2_FRF                                     \ Frame format
$00000020 constant SPI1_CR2_ERRIE                                   \ Error interrupt enable
$00000040 constant SPI1_CR2_RXNEIE                                  \ RX buffer not empty interrupt enable
$00000080 constant SPI1_CR2_TXEIE                                   \ Tx buffer empty interrupt enable
$00000f00 constant SPI1_CR2_DS                                      \ Data size
$00001000 constant SPI1_CR2_FRXTH                                   \ FIFO reception threshold
$00002000 constant SPI1_CR2_LDMA_RX                                 \ Last DMA transfer for reception
$00004000 constant SPI1_CR2_LDMA_TX                                 \ Last DMA transfer for transmission


\
\ @brief status register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000001 constant SPI1_SR_RXNE                                     \ Receive buffer not empty
$00000002 constant SPI1_SR_TXE                                      \ Transmit buffer empty
$00000004 constant SPI1_SR_CHSIDE                                   \ Channel side
$00000008 constant SPI1_SR_UDR                                      \ Underrun flag
$00000010 constant SPI1_SR_CRCERR                                   \ CRC error flag
$00000020 constant SPI1_SR_MODF                                     \ Mode fault
$00000040 constant SPI1_SR_OVR                                      \ Overrun flag
$00000080 constant SPI1_SR_BSY                                      \ Busy flag
$00000100 constant SPI1_SR_TIFRFE                                   \ TI frame format error
$00000600 constant SPI1_SR_FRLVL                                    \ FIFO reception level
$00001800 constant SPI1_SR_FTLVL                                    \ FIFO transmission level


\
\ @brief data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_DR_DR                                       \ Data register


\
\ @brief CRC polynomial register
\ Address offset: 0x10
\ Reset value: 0x00000007
\

$0000ffff constant SPI1_CRCPR_CRCPOLY                               \ CRC polynomial register


\
\ @brief RX CRC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_RXCRCR_RXCRC                                \ Rx CRC register


\
\ @brief TX CRC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_TXCRCR_TXCRC                                \ Tx CRC register


\
\ @brief configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SPI1_I2SCFGR_CHLEN                               \ Channel length (number of bits per audio channel)
$00000006 constant SPI1_I2SCFGR_DATLEN                              \ Data length to be transferred
$00000008 constant SPI1_I2SCFGR_CKPOL                               \ Inactive state clock polarity
$00000030 constant SPI1_I2SCFGR_I2SSTD                              \ standard selection
$00000080 constant SPI1_I2SCFGR_PCMSYNC                             \ PCM frame synchronization
$00000300 constant SPI1_I2SCFGR_I2SCFG                              \ I2S configuration mode
$00000400 constant SPI1_I2SCFGR_SE2                                 \ I2S enable
$00000800 constant SPI1_I2SCFGR_I2SMOD                              \ I2S mode selection


\
\ @brief prescaler register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SPI1_I2SPR_I2SDIV                                \ linear prescaler
$00000100 constant SPI1_I2SPR_ODD                                   \ Odd factor for the prescaler
$00000200 constant SPI1_I2SPR_MCKOE                                 \ Master clock output enable


\
\ @brief hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$0000000f constant SPI1_HWCFGR_CRCCFG                               \ CRC capable at SPI mode
$000000f0 constant SPI1_HWCFGR_I2SCFG                               \ I2S mode implementation
$00000f00 constant SPI1_HWCFGR_I2SCKCFG                             \ I2S master clock generator at I2S mode
$0000f000 constant SPI1_HWCFGR_DSCFG                                \ SPI data size configuration
$000f0000 constant SPI1_HWCFGR_NSSCFG                               \ NSS pulse feature enhancement at SPI master


\
\ @brief EXTI IP Version register
\ Address offset: 0x3F4
\ Reset value: 0x00000000
\

$0000000f constant SPI1_VERR_MINREV                                 \ Minor Revision number
$000000f0 constant SPI1_VERR_MAJREV                                 \ Major Revision number


\
\ @brief EXTI Identification register
\ Address offset: 0x3F8
\ Reset value: 0x00000000
\

$00000000 constant SPI1_IPIDR_IPID                                  \ IP Identification


\
\ @brief EXTI Size ID register
\ Address offset: 0x3FC
\ Reset value: 0x00000000
\

$00000000 constant SPI1_SIDR_SID                                    \ Size Identification


\
\ @brief Serial peripheral interface/Inter-IC sound
\
$40013000 constant SPI1_CR1       \ offset: 0x00 : control register 1
$40013004 constant SPI1_CR2       \ offset: 0x04 : control register 2
$40013008 constant SPI1_SR        \ offset: 0x08 : status register
$4001300c constant SPI1_DR        \ offset: 0x0C : data register
$40013010 constant SPI1_CRCPR     \ offset: 0x10 : CRC polynomial register
$40013014 constant SPI1_RXCRCR    \ offset: 0x14 : RX CRC register
$40013018 constant SPI1_TXCRCR    \ offset: 0x18 : TX CRC register
$4001301c constant SPI1_I2SCFGR   \ offset: 0x1C : configuration register
$40013020 constant SPI1_I2SPR     \ offset: 0x20 : prescaler register
$400133f0 constant SPI1_HWCFGR    \ offset: 0x3F0 : hardware configuration register
$400133f4 constant SPI1_VERR      \ offset: 0x3F4 : EXTI IP Version register
$400133f8 constant SPI1_IPIDR     \ offset: 0x3F8 : EXTI Identification register
$400133fc constant SPI1_SIDR      \ offset: 0x3FC : EXTI Size ID register

