\
\ @file spi1.fs
\ @brief Serial peripheral interface
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
\ Reset value: 0x00000700
\

$00000001 constant SPI1_CR2_RXDMAEN                                 \ Rx buffer DMA enable
$00000002 constant SPI1_CR2_TXDMAEN                                 \ Tx buffer DMA enable
$00000004 constant SPI1_CR2_SSOE                                    \ SS output enable
$00000010 constant SPI1_CR2_FRF                                     \ Frame format
$00000020 constant SPI1_CR2_ERRIE                                   \ Error interrupt enable
$00000040 constant SPI1_CR2_RXNEIE                                  \ RX buffer not empty interrupt enable
$00000080 constant SPI1_CR2_TXEIE                                   \ Tx buffer empty interrupt enable


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
\ @brief I2S configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SPI1_I2SCFGR_CHLEN                               \ Channel length (number of bits per audio channel)
$00000006 constant SPI1_I2SCFGR_DATLEN                              \ Data length to be transferred
$00000008 constant SPI1_I2SCFGR_CKPOL                               \ Steady state clock polarity
$00000030 constant SPI1_I2SCFGR_I2SSTD                              \ I2S standard selection
$00000080 constant SPI1_I2SCFGR_PCMSYNC                             \ PCM frame synchronization
$00000300 constant SPI1_I2SCFGR_I2SCFG                              \ I2S configuration mode
$00000400 constant SPI1_I2SCFGR_I2SE                                \ I2S Enable
$00000800 constant SPI1_I2SCFGR_I2SMOD                              \ I2S mode selection


\
\ @brief I2S prescaler register
\ Address offset: 0x20
\ Reset value: 0x00000002
\

$000000ff constant SPI1_I2SPR_I2SDIV                                \ I2S Linear prescaler
$00000100 constant SPI1_I2SPR_ODD                                   \ Odd factor for the prescaler
$00000200 constant SPI1_I2SPR_MCKOE                                 \ Master clock output enable


\
\ @brief Serial peripheral interface
\
$40013000 constant SPI1_CR1       \ offset: 0x00 : control register 1
$40013004 constant SPI1_CR2       \ offset: 0x04 : control register 2
$40013008 constant SPI1_SR        \ offset: 0x08 : status register
$4001300c constant SPI1_DR        \ offset: 0x0C : data register
$40013010 constant SPI1_CRCPR     \ offset: 0x10 : CRC polynomial register
$40013014 constant SPI1_RXCRCR    \ offset: 0x14 : RX CRC register
$40013018 constant SPI1_TXCRCR    \ offset: 0x18 : TX CRC register
$4001301c constant SPI1_I2SCFGR   \ offset: 0x1C : I2S configuration register
$40013020 constant SPI1_I2SPR     \ offset: 0x20 : I2S prescaler register

