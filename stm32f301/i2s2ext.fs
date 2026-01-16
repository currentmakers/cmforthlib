\
\ @file i2s2ext.fs
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

$00000001 constant I2S2EXT_CR1_CPHA                                 \ Clock phase
$00000002 constant I2S2EXT_CR1_CPOL                                 \ Clock polarity
$00000004 constant I2S2EXT_CR1_MSTR                                 \ Master selection
$00000038 constant I2S2EXT_CR1_BR                                   \ Baud rate control
$00000040 constant I2S2EXT_CR1_SPE                                  \ SPI enable
$00000080 constant I2S2EXT_CR1_LSBFIRST                             \ Frame format
$00000100 constant I2S2EXT_CR1_SSI                                  \ Internal slave select
$00000200 constant I2S2EXT_CR1_SSM                                  \ Software slave management
$00000400 constant I2S2EXT_CR1_RXONLY                               \ Receive only
$00000800 constant I2S2EXT_CR1_CRCL                                 \ CRC length
$00001000 constant I2S2EXT_CR1_CRCNEXT                              \ CRC transfer next
$00002000 constant I2S2EXT_CR1_CRCEN                                \ Hardware CRC calculation enable
$00004000 constant I2S2EXT_CR1_BIDIOE                               \ Output enable in bidirectional mode
$00008000 constant I2S2EXT_CR1_BIDIMODE                             \ Bidirectional data mode enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant I2S2EXT_CR2_RXDMAEN                              \ Rx buffer DMA enable
$00000002 constant I2S2EXT_CR2_TXDMAEN                              \ Tx buffer DMA enable
$00000004 constant I2S2EXT_CR2_SSOE                                 \ SS output enable
$00000008 constant I2S2EXT_CR2_NSSP                                 \ NSS pulse management
$00000010 constant I2S2EXT_CR2_FRF                                  \ Frame format
$00000020 constant I2S2EXT_CR2_ERRIE                                \ Error interrupt enable
$00000040 constant I2S2EXT_CR2_RXNEIE                               \ RX buffer not empty interrupt enable
$00000080 constant I2S2EXT_CR2_TXEIE                                \ Tx buffer empty interrupt enable
$00000f00 constant I2S2EXT_CR2_DS                                   \ Data size
$00001000 constant I2S2EXT_CR2_FRXTH                                \ FIFO reception threshold
$00002000 constant I2S2EXT_CR2_LDMA_RX                              \ Last DMA transfer for reception
$00004000 constant I2S2EXT_CR2_LDMA_TX                              \ Last DMA transfer for transmission


\
\ @brief status register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000001 constant I2S2EXT_SR_RXNE                                  \ Receive buffer not empty
$00000002 constant I2S2EXT_SR_TXE                                   \ Transmit buffer empty
$00000004 constant I2S2EXT_SR_CHSIDE                                \ Channel side
$00000008 constant I2S2EXT_SR_UDR                                   \ Underrun flag
$00000010 constant I2S2EXT_SR_CRCERR                                \ CRC error flag
$00000020 constant I2S2EXT_SR_MODF                                  \ Mode fault
$00000040 constant I2S2EXT_SR_OVR                                   \ Overrun flag
$00000080 constant I2S2EXT_SR_BSY                                   \ Busy flag
$00000100 constant I2S2EXT_SR_TIFRFE                                \ TI frame format error
$00000600 constant I2S2EXT_SR_FRLVL                                 \ FIFO reception level
$00001800 constant I2S2EXT_SR_FTLVL                                 \ FIFO transmission level


\
\ @brief data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant I2S2EXT_DR_DR                                    \ Data register


\
\ @brief CRC polynomial register
\ Address offset: 0x10
\ Reset value: 0x00000007
\

$0000ffff constant I2S2EXT_CRCPR_CRCPOLY                            \ CRC polynomial register


\
\ @brief RX CRC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant I2S2EXT_RXCRCR_RXCRC                             \ Rx CRC register


\
\ @brief TX CRC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant I2S2EXT_TXCRCR_TXCRC                             \ Tx CRC register


\
\ @brief I2S configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant I2S2EXT_I2SCFGR_CHLEN                            \ Channel length (number of bits per audio channel)
$00000006 constant I2S2EXT_I2SCFGR_DATLEN                           \ Data length to be transferred
$00000008 constant I2S2EXT_I2SCFGR_CKPOL                            \ Steady state clock polarity
$00000030 constant I2S2EXT_I2SCFGR_I2SSTD                           \ I2S standard selection
$00000080 constant I2S2EXT_I2SCFGR_PCMSYNC                          \ PCM frame synchronization
$00000300 constant I2S2EXT_I2SCFGR_I2SCFG                           \ I2S configuration mode
$00000400 constant I2S2EXT_I2SCFGR_I2SE                             \ I2S Enable
$00000800 constant I2S2EXT_I2SCFGR_I2SMOD                           \ I2S mode selection


\
\ @brief I2S prescaler register
\ Address offset: 0x20
\ Reset value: 0x00000010
\

$000000ff constant I2S2EXT_I2SPR_I2SDIV                             \ I2S Linear prescaler
$00000100 constant I2S2EXT_I2SPR_ODD                                \ Odd factor for the prescaler
$00000200 constant I2S2EXT_I2SPR_MCKOE                              \ Master clock output enable


\
\ @brief Serial peripheral interface/Inter-IC sound
\
$40003400 constant I2S2EXT_CR1    \ offset: 0x00 : control register 1
$40003404 constant I2S2EXT_CR2    \ offset: 0x04 : control register 2
$40003408 constant I2S2EXT_SR     \ offset: 0x08 : status register
$4000340c constant I2S2EXT_DR     \ offset: 0x0C : data register
$40003410 constant I2S2EXT_CRCPR  \ offset: 0x10 : CRC polynomial register
$40003414 constant I2S2EXT_RXCRCR  \ offset: 0x14 : RX CRC register
$40003418 constant I2S2EXT_TXCRCR  \ offset: 0x18 : TX CRC register
$4000341c constant I2S2EXT_I2SCFGR  \ offset: 0x1C : I2S configuration register
$40003420 constant I2S2EXT_I2SPR  \ offset: 0x20 : I2S prescaler register

