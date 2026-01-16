\
\ @file spi3.fs
\ @brief Sub-GHz radio SPI global interrupt
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

$00000001 constant SPI3_CR1_CPHA                                    \ Clock phase
$00000002 constant SPI3_CR1_CPOL                                    \ Clock polarity
$00000004 constant SPI3_CR1_MSTR                                    \ Master selection
$00000038 constant SPI3_CR1_BR                                      \ Baud rate control
$00000040 constant SPI3_CR1_SPE                                     \ SPI enable
$00000080 constant SPI3_CR1_LSBFIRST                                \ Frame format
$00000100 constant SPI3_CR1_SSI                                     \ Internal slave select
$00000200 constant SPI3_CR1_SSM                                     \ Software slave management
$00000400 constant SPI3_CR1_RXONLY                                  \ Receive only
$00000800 constant SPI3_CR1_DFF                                     \ Data frame format
$00001000 constant SPI3_CR1_CRCNEXT                                 \ CRC transfer next
$00002000 constant SPI3_CR1_CRCEN                                   \ Hardware CRC calculation enable
$00004000 constant SPI3_CR1_BIDIOE                                  \ Output enable in bidirectional mode
$00008000 constant SPI3_CR1_BIDIMODE                                \ Bidirectional data mode enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SPI3_CR2_RXDMAEN                                 \ Rx buffer DMA enable
$00000002 constant SPI3_CR2_TXDMAEN                                 \ Tx buffer DMA enable
$00000004 constant SPI3_CR2_SSOE                                    \ SS output enable
$00000008 constant SPI3_CR2_NSSP                                    \ NSS pulse management
$00000010 constant SPI3_CR2_FRF                                     \ Frame format
$00000020 constant SPI3_CR2_ERRIE                                   \ Error interrupt enable
$00000040 constant SPI3_CR2_RXNEIE                                  \ RX buffer not empty interrupt enable
$00000080 constant SPI3_CR2_TXEIE                                   \ Tx buffer empty interrupt enable
$00000f00 constant SPI3_CR2_DS                                      \ Data size
$00001000 constant SPI3_CR2_FRXTH                                   \ FIFO reception threshold
$00002000 constant SPI3_CR2_LDMA_RX                                 \ Last DMA transfer for reception
$00004000 constant SPI3_CR2_LDMA_TX                                 \ Last DMA transfer for transmission


\
\ @brief status register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000001 constant SPI3_SR_RXNE                                     \ Receive buffer not empty
$00000002 constant SPI3_SR_TXE                                      \ Transmit buffer empty
$00000004 constant SPI3_SR_CHSIDE                                   \ CHSIDE
$00000008 constant SPI3_SR_UDR                                      \ UDR
$00000010 constant SPI3_SR_CRCERR                                   \ CRC error flag
$00000020 constant SPI3_SR_MODF                                     \ Mode fault
$00000040 constant SPI3_SR_OVR                                      \ Overrun flag
$00000080 constant SPI3_SR_BSY                                      \ Busy flag
$00000100 constant SPI3_SR_TIFRFE                                   \ TI frame format error
$00000600 constant SPI3_SR_FRLVL                                    \ FIFO reception level
$00001800 constant SPI3_SR_FTLVL                                    \ FIFO transmission level


\
\ @brief data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SPI3_DR_DR                                       \ Data register


\
\ @brief CRC polynomial register
\ Address offset: 0x10
\ Reset value: 0x00000007
\

$0000ffff constant SPI3_CRCPR_CRCPOLY                               \ CRC polynomial register


\
\ @brief RX CRC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPI3_RXCRCR_RXCRC                                \ Rx CRC register


\
\ @brief TX CRC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant SPI3_TXCRCR_TXCRC                                \ Tx CRC register


\
\ @brief configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SPI3_I2SCFGR_CHLEN                               \ CHLEN
$00000006 constant SPI3_I2SCFGR_DATLEN                              \ DATLEN
$00000008 constant SPI3_I2SCFGR_CKPOL                               \ CKPOL
$00000030 constant SPI3_I2SCFGR_I2SSTD                              \ I2SSTD
$00000080 constant SPI3_I2SCFGR_PCMSYNC                             \ PCMSYNC
$00000300 constant SPI3_I2SCFGR_I2SCFG                              \ I2SCFG
$00000400 constant SPI3_I2SCFGR_I2SE                                \ I2SE
$00000800 constant SPI3_I2SCFGR_I2SMOD                              \ I2SMOD
$00001000 constant SPI3_I2SCFGR_ASTRTEN                             \ ASTRTEN


\
\ @brief prescaler register
\ Address offset: 0x20
\ Reset value: 0x00000002
\

$000000ff constant SPI3_I2SPR_I2SDIV                                \ I2SDIV
$00000100 constant SPI3_I2SPR_ODD                                   \ ODD
$00000200 constant SPI3_I2SPR_MCKOE                                 \ MCKOE


\
\ @brief Sub-GHz radio SPI global interrupt
\
$58010000 constant SPI3_CR1       \ offset: 0x00 : control register 1
$58010004 constant SPI3_CR2       \ offset: 0x04 : control register 2
$58010008 constant SPI3_SR        \ offset: 0x08 : status register
$5801000c constant SPI3_DR        \ offset: 0x0C : data register
$58010010 constant SPI3_CRCPR     \ offset: 0x10 : CRC polynomial register
$58010014 constant SPI3_RXCRCR    \ offset: 0x14 : RX CRC register
$58010018 constant SPI3_TXCRCR    \ offset: 0x18 : TX CRC register
$5801001c constant SPI3_I2SCFGR   \ offset: 0x1C : configuration register
$58010020 constant SPI3_I2SPR     \ offset: 0x20 : prescaler register

