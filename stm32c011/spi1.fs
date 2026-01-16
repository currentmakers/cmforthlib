\
\ @file spi1.fs
\ @brief Serial peripheral interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SPI control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SPI1_SPIX_CR1_CPHA                               \ Clock phase Note: This bit should not be changed when communication is ongoing. This bit is not used in I2S mode and SPI TI mode except the case when CRC is applied at TI mode.
$00000002 constant SPI1_SPIX_CR1_CPOL                               \ Clock polarity Note: This bit should not be changed when communication is ongoing. This bit is not used in I2S mode and SPI TI mode except the case when CRC is applied at TI mode.
$00000004 constant SPI1_SPIX_CR1_MSTR                               \ Master selection Note: This bit should not be changed when communication is ongoing. This bit is not used in I2S mode.
$00000038 constant SPI1_SPIX_CR1_BR                                 \ Baud rate control Note: These bits should not be changed when communication is ongoing. These bits are not used in I2S mode.
$00000040 constant SPI1_SPIX_CR1_SPE                                \ SPI enable Note: When disabling the SPI, follow the procedure described in SPI on page 1349. This bit is not used in I2S mode.
$00000080 constant SPI1_SPIX_CR1_LSBFIRST                           \ Frame format Note: 1. This bit should not be changed when communication is ongoing. 2. This bit is not used in I2S mode and SPI TI mode.
$00000100 constant SPI1_SPIX_CR1_SSI                                \ Internal slave select This bit has an effect only when the SSM bit is set. The value of this bit is forced onto the NSS pin and the I/O value of the NSS pin is ignored. Note: This bit is not used in I2S mode and SPI TI mode.
$00000200 constant SPI1_SPIX_CR1_SSM                                \ Software slave management When the SSM bit is set, the NSS pin input is replaced with the value from the SSI bit. Note: This bit is not used in I2S mode and SPI TI mode.
$00000400 constant SPI1_SPIX_CR1_RXONLY                             \ Receive only mode enabled. This bit enables simplex communication using a single unidirectional line to receive data exclusively. Keep BIDIMODE bit clear when receive only mode is active.This bit is also useful in a multislave system in which this particular slave is not accessed, the output from the accessed slave is not corrupted. Note: This bit is not used in I2S mode.
$00000800 constant SPI1_SPIX_CR1_CRCL                               \ CRC length This bit is set and cleared by software to select the CRC length. Note: This bit should be written only when SPI is disabled (SPE = 0) for correct operation. This bit is not used in I2S mode.
$00001000 constant SPI1_SPIX_CR1_CRCNEXT                            \ Transmit CRC next Note: This bit has to be written as soon as the last data is written in the SPI_DR register. This bit is not used in I2S mode.
$00002000 constant SPI1_SPIX_CR1_CRCEN                              \ Hardware CRC calculation enable Note: This bit should be written only when SPI is disabled (SPE = 0) for correct operation. This bit is not used in I2S mode.
$00004000 constant SPI1_SPIX_CR1_BIDIOE                             \ Output enable in bidirectional mode This bit combined with the BIDIMODE bit selects the direction of transfer in bidirectional mode. Note: In master mode, the MOSI pin is used and in slave mode, the MISO pin is used. This bit is not used in I2S mode.
$00008000 constant SPI1_SPIX_CR1_BIDIMODE                           \ Bidirectional data mode enable. This bit enables half-duplex communication using common single bidirectional data line. Keep RXONLY bit clear when bidirectional mode is active. Note: This bit is not used in I2S mode.


\
\ @brief SPI control register 2
\ Address offset: 0x04
\ Reset value: 0x00000700
\

$00000001 constant SPI1_SPIX_CR2_RXDMAEN                            \ Rx buffer DMA enable When this bit is set, a DMA request is generated whenever the RXNE flag is set.
$00000002 constant SPI1_SPIX_CR2_TXDMAEN                            \ Tx buffer DMA enable When this bit is set, a DMA request is generated whenever the TXE flag is set.
$00000004 constant SPI1_SPIX_CR2_SSOE                               \ SS output enable Note: This bit is not used in I2S mode and SPI TI mode.
$00000008 constant SPI1_SPIX_CR2_NSSP                               \ NSS pulse management This bit is used in master mode only. it allows the SPI to generate an NSS pulse between two consecutive data when doing continuous transfers. In the case of a single data transfer, it forces the NSS pin high level after the transfer. It has no meaning if CPHA = 1, or FRF = 1. Note: 1. This bit must be written only when the SPI is disabled (SPE=0). 2. This bit is not used in I2S mode and SPI TI mode.
$00000010 constant SPI1_SPIX_CR2_FRF                                \ Frame format 1 SPI TI mode Note: This bit must be written only when the SPI is disabled (SPE=0). This bit is not used in I2S mode.
$00000020 constant SPI1_SPIX_CR2_ERRIE                              \ Error interrupt enable This bit controls the generation of an interrupt when an error condition occurs (CRCERR, OVR, MODF in SPI mode, FRE at TI mode and UDR, OVR, and FRE in I2S mode).
$00000040 constant SPI1_SPIX_CR2_RXNEIE                             \ RX buffer not empty interrupt enable
$00000080 constant SPI1_SPIX_CR2_TXEIE                              \ Tx buffer empty interrupt enable
$00000f00 constant SPI1_SPIX_CR2_DS                                 \ Data size These bits configure the data length for SPI transfers. If software attempts to write one of the Not used values, they are forced to the value 0111 (8-bit) Note: These bits are not used in I2S mode.
$00001000 constant SPI1_SPIX_CR2_FRXTH                              \ FIFO reception threshold This bit is used to set the threshold of the RXFIFO that triggers an RXNE event Note: This bit is not used in I2S mode.
$00002000 constant SPI1_SPIX_CR2_LDMA_RX                            \ Last DMA transfer for reception This bit is used in data packing mode, to define if the total number of data to receive by DMA is odd or even. It has significance only if the RXDMAEN bit in the SPI_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPI_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPI_CR1 register). Note: Refer to if the CRCEN bit is set. This bit is not used in IS mode.
$00004000 constant SPI1_SPIX_CR2_LDMA_TX                            \ Last DMA transfer for transmission This bit is used in data packing mode, to define if the total number of data to transmit by DMA is odd or even. It has significance only if the TXDMAEN bit in the SPI_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPI_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPI_CR1 register). Note: Refer to if the CRCEN bit is set. This bit is not used in ImS mode.


\
\ @brief SPI status register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000001 constant SPI1_SPIX_SR_RXNE                                \ Receive buffer not empty
$00000002 constant SPI1_SPIX_SR_TXE                                 \ Transmit buffer empty
$00000004 constant SPI1_SPIX_SR_CHSIDE                              \ Channel side Note: This bit is not used in SPI mode. It has no significance in PCM mode.
$00000008 constant SPI1_SPIX_SR_UDR                                 \ Underrun flag This flag is set by hardware and reset by a software sequence. Refer to page 1385 for the software sequence. Note: This bit is not used in SPI mode.
$00000010 constant SPI1_SPIX_SR_CRCERR                              \ CRC error flag Note: This flag is set by hardware and cleared by software writing 0. This bit is not used in I2S mode.
$00000020 constant SPI1_SPIX_SR_MODF                                \ Mode fault This flag is set by hardware and reset by a software sequence. Refer to (MODF) on page 1359 for the software sequence. Note: This bit is not used in I2S mode.
$00000040 constant SPI1_SPIX_SR_OVR                                 \ Overrun flag This flag is set by hardware and reset by a software sequence. Refer to page 1385 for the software sequence.
$00000080 constant SPI1_SPIX_SR_BSY                                 \ Busy flag This flag is set and cleared by hardware. Note: The BSY flag must be used with caution: refer to and .
$00000100 constant SPI1_SPIX_SR_FRE                                 \ Frame format error This flag is used for SPI in TI slave mode and I2S slave mode. Refer to error flags and . This flag is set by hardware and reset when SPI_SR is read by software.
$00000600 constant SPI1_SPIX_SR_FRLVL                               \ FIFO reception level These bits are set and cleared by hardware. Note: These bits are not used in ImS mode and in SPI receive-only mode while CRC calculation is enabled.
$00001800 constant SPI1_SPIX_SR_FTLVL                               \ FIFO transmission level These bits are set and cleared by hardware. Note: This bit is not used in I2S mode.


\
\ @brief SPI data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_SPIX_DR_DR                                  \ Data register Data received or to be transmitted The data register serves as an interface between the Rx and Tx FIFOs. When the data register is read, RxFIFO is accessed while the write to data register accesses TxFIFO (See ). Note: Data is always right-aligned. Unused bits are ignored when writing to the register, and read as zero when the register is read. The Rx threshold setting must always correspond with the read access currently used.


\
\ @brief SPI CRC polynomial register
\ Address offset: 0x10
\ Reset value: 0x00000007
\

$0000ffff constant SPI1_SPIX_CRCPR_CRCPOLY                          \ CRC polynomial register This register contains the polynomial for the CRC calculation. The CRC polynomial (0x0007) is the reset value of this register. Another polynomial can be configured as required.


\
\ @brief SPI Rx CRC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_SPIX_RXCRCR_RXCRC                           \ Rx CRC register When CRC calculation is enabled, the RXCRC[15:0] bits contain the computed CRC value of the subsequently received bytes. This register is reset when the CRCEN bit in SPI_CR1 register is written to 1. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPR register. Only the 8 LSB bits are considered when the CRC frame format is set to be 8-bit length (CRCL bit in the SPI_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit CRC frame format is selected (CRCL bit in the SPI_CR1 register is set). CRC calculation is done based on any CRC16 standard. Note: A read to this register when the BSY Flag is set could return an incorrect value. These bits are not used in I2S mode.


\
\ @brief SPI Tx CRC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_SPIX_TXCRCR_TXCRC                           \ Tx CRC register When CRC calculation is enabled, the TXCRC[7:0] bits contain the computed CRC value of the subsequently transmitted bytes. This register is reset when the CRCEN bit of SPI_CR1 is written to 1. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPR register. Only the 8 LSB bits are considered when the CRC frame format is set to be 8-bit length (CRCL bit in the SPI_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit CRC frame format is selected (CRCL bit in the SPI_CR1 register is set). CRC calculation is done based on any CRC16 standard. Note: A read to this register when the BSY flag is set could return an incorrect value. These bits are not used in I2S mode.


\
\ @brief SPIx_I2S configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SPI1_SPIX_I2SCFGR_CHLEN                          \ Channel length (number of bits per audio channel) The bit write operation has a meaning only if DATLEN = 00 otherwise the channel length is fixed to 32-bit by hardware whatever the value filled in. Note: For correct operation, this bit should be configured when the I2S is disabled. It is not used in SPI mode.
$00000006 constant SPI1_SPIX_I2SCFGR_DATLEN                         \ Data length to be transferred Note: For correct operation, these bits should be configured when the I2S is disabled. They are not used in SPI mode.
$00000008 constant SPI1_SPIX_I2SCFGR_CKPOL                          \ Inactive state clock polarity Note: For correct operation, this bit should be configured when the I2S is disabled. It is not used in SPI mode. The bit CKPOL does not affect the CK edge sensitivity used to receive or transmit the SD and WS signals.
$00000030 constant SPI1_SPIX_I2SCFGR_I2SSTD                         \ I2S standard selection For more details on I2S standards, refer to Note: For correct operation, these bits should be configured when the I2S is disabled. They are not used in SPI mode.
$00000080 constant SPI1_SPIX_I2SCFGR_PCMSYNC                        \ PCM frame synchronization Note: This bit has a meaning only if I2SSTD = 11 (PCM standard is used). It is not used in SPI mode.
$00000300 constant SPI1_SPIX_I2SCFGR_I2SCFG                         \ I2S configuration mode Note: These bits should be configured when the I2S is disabled. They are not used in SPI mode.
$00000400 constant SPI1_SPIX_I2SCFGR_I2SE                           \ I2S enable Note: This bit is not used in SPI mode.
$00000800 constant SPI1_SPIX_I2SCFGR_I2SMOD                         \ I2S mode selection Note: This bit should be configured when the SPI is disabled.
$00001000 constant SPI1_SPIX_I2SCFGR_ASTRTEN                        \ Asynchronous start enable. When the I2S is enabled in slave mode, the hardware starts the transfer when the I2S clock is received and an appropriate transition is detected on the WS signal. When the I2S is enabled in slave mode, the hardware starts the transfer when the I2S clock is received and the appropriate level is detected on the WS signal. Note: The appropriate transition is a falling edge on WS signal when I2S Philips Standard is used, or a rising edge for other standards. The appropriate level is a low level on WS signal when I2S Philips Standard is used, or a high level for other standards. Please refer to for additional information.


\
\ @brief SPI_I2S prescaler register
\ Address offset: 0x20
\ Reset value: 0x00000002
\

$000000ff constant SPI1_SPIX_I2SPR_I2SDIV                           \ I2S linear prescaler I2SDIV [7:0] = 0 or I2SDIV [7:0] = 1 are forbidden values. Refer to . Note: These bits should be configured when the I2S is disabled. They are used only when the I2S is in master mode. They are not used in SPI mode.
$00000100 constant SPI1_SPIX_I2SPR_ODD                              \ Odd factor for the prescaler Refer to . Note: This bit should be configured when the I2S is disabled. It is used only when the I2S is in master mode. It is not used in SPI mode.
$00000200 constant SPI1_SPIX_I2SPR_MCKOE                            \ Master clock output enable Note: This bit should be configured when the I2S is disabled. It is used only when the I2S is in master mode. It is not used in SPI mode.


\
\ @brief Serial peripheral interface
\
$40013000 constant SPI1_SPIX_CR1  \ offset: 0x00 : SPI control register 1
$40013004 constant SPI1_SPIX_CR2  \ offset: 0x04 : SPI control register 2
$40013008 constant SPI1_SPIX_SR   \ offset: 0x08 : SPI status register
$4001300c constant SPI1_SPIX_DR   \ offset: 0x0C : SPI data register
$40013010 constant SPI1_SPIX_CRCPR  \ offset: 0x10 : SPI CRC polynomial register
$40013014 constant SPI1_SPIX_RXCRCR  \ offset: 0x14 : SPI Rx CRC register
$40013018 constant SPI1_SPIX_TXCRCR  \ offset: 0x18 : SPI Tx CRC register
$4001301c constant SPI1_SPIX_I2SCFGR  \ offset: 0x1C : SPIx_I2S configuration register
$40013020 constant SPI1_SPIX_I2SPR  \ offset: 0x20 : SPI_I2S prescaler register

