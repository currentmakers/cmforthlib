\
\ @file sec_spi1.fs
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

$00000001 constant SEC_SPI1_CR1_CPHA                                \ Clock phase
$00000002 constant SEC_SPI1_CR1_CPOL                                \ Clock polarity
$00000004 constant SEC_SPI1_CR1_MSTR                                \ Master selection
$00000038 constant SEC_SPI1_CR1_BR                                  \ Baud rate control
$00000040 constant SEC_SPI1_CR1_SPE                                 \ SPI enable
$00000080 constant SEC_SPI1_CR1_LSBFIRST                            \ Frame format
$00000100 constant SEC_SPI1_CR1_SSI                                 \ Internal slave select
$00000200 constant SEC_SPI1_CR1_SSM                                 \ Software slave management
$00000400 constant SEC_SPI1_CR1_RXONLY                              \ Receive only
$00000800 constant SEC_SPI1_CR1_CRCL                                \ CRC length
$00001000 constant SEC_SPI1_CR1_CRCNEXT                             \ CRC transfer next
$00002000 constant SEC_SPI1_CR1_CRCEN                               \ Hardware CRC calculation enable
$00004000 constant SEC_SPI1_CR1_BIDIOE                              \ Output enable in bidirectional mode
$00008000 constant SEC_SPI1_CR1_BIDIMODE                            \ Bidirectional data mode enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_SPI1_CR2_RXDMAEN                             \ Rx buffer DMA enable
$00000002 constant SEC_SPI1_CR2_TXDMAEN                             \ Tx buffer DMA enable
$00000004 constant SEC_SPI1_CR2_SSOE                                \ SS output enable
$00000008 constant SEC_SPI1_CR2_NSSP                                \ NSS pulse management
$00000010 constant SEC_SPI1_CR2_FRF                                 \ Frame format
$00000020 constant SEC_SPI1_CR2_ERRIE                               \ Error interrupt enable
$00000040 constant SEC_SPI1_CR2_RXNEIE                              \ RX buffer not empty interrupt enable
$00000080 constant SEC_SPI1_CR2_TXEIE                               \ Tx buffer empty interrupt enable
$00000f00 constant SEC_SPI1_CR2_DS                                  \ Data size
$00001000 constant SEC_SPI1_CR2_FRXTH                               \ FIFO reception threshold
$00002000 constant SEC_SPI1_CR2_LDMA_RX                             \ Last DMA transfer for reception
$00004000 constant SEC_SPI1_CR2_LDMA_TX                             \ Last DMA transfer for transmission


\
\ @brief status register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000001 constant SEC_SPI1_SR_RXNE                                 \ Receive buffer not empty
$00000002 constant SEC_SPI1_SR_TXE                                  \ Transmit buffer empty
$00000010 constant SEC_SPI1_SR_CRCERR                               \ CRC error flag
$00000020 constant SEC_SPI1_SR_MODF                                 \ Mode fault
$00000040 constant SEC_SPI1_SR_OVR                                  \ Overrun flag
$00000080 constant SEC_SPI1_SR_BSY                                  \ Busy flag
$00000100 constant SEC_SPI1_SR_TIFRFE                               \ TI frame format error
$00000600 constant SEC_SPI1_SR_FRLVL                                \ FIFO reception level
$00001800 constant SEC_SPI1_SR_FTLVL                                \ FIFO transmission level


\
\ @brief data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_SPI1_DR_DR                                   \ Data register


\
\ @brief CRC polynomial register
\ Address offset: 0x10
\ Reset value: 0x00000007
\

$0000ffff constant SEC_SPI1_CRCPR_CRCPOLY                           \ CRC polynomial register


\
\ @brief RX CRC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SEC_SPI1_RXCRCR_RXCRC                            \ Rx CRC register


\
\ @brief TX CRC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant SEC_SPI1_TXCRCR_TXCRC                            \ Tx CRC register


\
\ @brief Serial peripheral interface
\
$50013000 constant SEC_SPI1_CR1   \ offset: 0x00 : control register 1
$50013004 constant SEC_SPI1_CR2   \ offset: 0x04 : control register 2
$50013008 constant SEC_SPI1_SR    \ offset: 0x08 : status register
$5001300c constant SEC_SPI1_DR    \ offset: 0x0C : data register
$50013010 constant SEC_SPI1_CRCPR  \ offset: 0x10 : CRC polynomial register
$50013014 constant SEC_SPI1_RXCRCR  \ offset: 0x14 : RX CRC register
$50013018 constant SEC_SPI1_TXCRCR  \ offset: 0x18 : TX CRC register

