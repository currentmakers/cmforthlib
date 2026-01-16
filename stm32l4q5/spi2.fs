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

$00000001 constant SPI2_CR1_CPHA                                    \ Clock phase
$00000002 constant SPI2_CR1_CPOL                                    \ Clock polarity
$00000004 constant SPI2_CR1_MSTR                                    \ Master selection
$00000038 constant SPI2_CR1_BR                                      \ Baud rate control
$00000040 constant SPI2_CR1_SPE                                     \ SPI enable
$00000080 constant SPI2_CR1_LSBFIRST                                \ Frame format
$00000100 constant SPI2_CR1_SSI                                     \ Internal slave select
$00000200 constant SPI2_CR1_SSM                                     \ Software slave management
$00000400 constant SPI2_CR1_RXONLY                                  \ Receive only
$00000800 constant SPI2_CR1_DFF                                     \ Data frame format
$00001000 constant SPI2_CR1_CRCNEXT                                 \ CRC transfer next
$00002000 constant SPI2_CR1_CRCEN                                   \ Hardware CRC calculation enable
$00004000 constant SPI2_CR1_BIDIOE                                  \ Output enable in bidirectional mode
$00008000 constant SPI2_CR1_BIDIMODE                                \ Bidirectional data mode enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SPI2_CR2_RXDMAEN                                 \ Rx buffer DMA enable
$00000002 constant SPI2_CR2_TXDMAEN                                 \ Tx buffer DMA enable
$00000004 constant SPI2_CR2_SSOE                                    \ SS output enable
$00000008 constant SPI2_CR2_NSSP                                    \ NSS pulse management
$00000010 constant SPI2_CR2_FRF                                     \ Frame format
$00000020 constant SPI2_CR2_ERRIE                                   \ Error interrupt enable
$00000040 constant SPI2_CR2_RXNEIE                                  \ RX buffer not empty interrupt enable
$00000080 constant SPI2_CR2_TXEIE                                   \ Tx buffer empty interrupt enable
$00000f00 constant SPI2_CR2_DS                                      \ Data size
$00001000 constant SPI2_CR2_FRXTH                                   \ FIFO reception threshold
$00002000 constant SPI2_CR2_LDMA_RX                                 \ Last DMA transfer for reception
$00004000 constant SPI2_CR2_LDMA_TX                                 \ Last DMA transfer for transmission


\
\ @brief status register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000001 constant SPI2_SR_RXNE                                     \ Receive buffer not empty
$00000002 constant SPI2_SR_TXE                                      \ Transmit buffer empty
$00000010 constant SPI2_SR_CRCERR                                   \ CRC error flag
$00000020 constant SPI2_SR_MODF                                     \ Mode fault
$00000040 constant SPI2_SR_OVR                                      \ Overrun flag
$00000080 constant SPI2_SR_BSY                                      \ Busy flag
$00000100 constant SPI2_SR_TIFRFE                                   \ TI frame format error
$00000600 constant SPI2_SR_FRLVL                                    \ FIFO reception level
$00001800 constant SPI2_SR_FTLVL                                    \ FIFO transmission level


\
\ @brief data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SPI2_DR_DR                                       \ Data register


\
\ @brief CRC polynomial register
\ Address offset: 0x10
\ Reset value: 0x00000007
\

$0000ffff constant SPI2_CRCPR_CRCPOLY                               \ CRC polynomial register


\
\ @brief RX CRC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPI2_RXCRCR_RXCRC                                \ Rx CRC register


\
\ @brief TX CRC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant SPI2_TXCRCR_TXCRC                                \ Tx CRC register


\
\ @brief SPI2 global interrupt
\
$40003800 constant SPI2_CR1       \ offset: 0x00 : control register 1
$40003804 constant SPI2_CR2       \ offset: 0x04 : control register 2
$40003808 constant SPI2_SR        \ offset: 0x08 : status register
$4000380c constant SPI2_DR        \ offset: 0x0C : data register
$40003810 constant SPI2_CRCPR     \ offset: 0x10 : CRC polynomial register
$40003814 constant SPI2_RXCRCR    \ offset: 0x14 : RX CRC register
$40003818 constant SPI2_TXCRCR    \ offset: 0x18 : TX CRC register

