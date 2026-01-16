\
\ @file spi1.fs
\ @brief SPI1 interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SPI1_CR1 register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SPI1_SPI1_CR1_CPHA                               \ Clock phase - 0: The first clock transition is the first data capture edge - 1: The second clock transition is the first data capture edge
$00000002 constant SPI1_SPI1_CR1_CPOL                               \ Clock polarity - 0: CK to 0 when idle - 1: CK to 1 when idle
$00000004 constant SPI1_SPI1_CR1_MSTR                               \ Master selection - 0: Slave configuration - 1: Master configuration
$00000038 constant SPI1_SPI1_CR1_BR                                 \ Baud rate control - 000: fPCLK/2 - 001: fPCLK/4 - 010: fPCLK/8 - 011: fPCLK/16 - 100: fPCLK/32 - 101: fPCLK/64 - 110: fPCLK/128 - 111: fPCLK/256
$00000040 constant SPI1_SPI1_CR1_SPE                                \ SPI enable - 0: Peripheral disabled - 1: Peripheral enabled
$00000080 constant SPI1_SPI1_CR1_LSBFIRST                           \ Frame format - 0: data is transmitted / received with the MSB first - 1: data is transmitted / received with the LSB first
$00000100 constant SPI1_SPI1_CR1_SSI                                \ Internal slave select This bit has an effect only when the SSM bit is set. The value of this bit is forced onto the NSS pin and the I/O value of the NSS pin is ignored.
$00000200 constant SPI1_SPI1_CR1_SSM                                \ Software slave management When the SSM bit is set, the NSS pin input is replaced with the value from the SSI bit. - 0: Software slave management disabled - 1: Software slave management enabled
$00000400 constant SPI1_SPI1_CR1_RXONLY                             \ Receive only mode enabled. This bit enables simplex communication using a single unidirectional line to receive data exclusively. Keep BIDIMODE bit clear when receive only mode is active.This bit is also useful in a multislave system in which this particular slave is not accessed, the output from the accessed slave is not corrupted. - 0: Full duplex (Transmit and receive) - 1: Output disabled (Receive-only mode)
$00000800 constant SPI1_SPI1_CR1_CRCL                               \ CRC length This bit is set and cleared by software to select the CRC length. - 0: 8-bit CRC length - 1: 16-bit CRC length
$00001000 constant SPI1_SPI1_CR1_CRCNEXT                            \ Transmit CRC next - 0: Next transmit value is from Tx buffer - 1: Next transmit value is from Tx CRC register
$00002000 constant SPI1_SPI1_CR1_CRCEN                              \ Hardware CRC calculation enable - 0: CRC calculation disabled - 1: CRC calculation Enabled
$00004000 constant SPI1_SPI1_CR1_BIDIOE                             \ Output enable in bidirectional mode This bit combined with the BIDIMODE bit selects the direction of transfer in bidirectional mode - 0: Output disabled (receive-only mode) - 1: Output enabled (transmit-only mode)
$00008000 constant SPI1_SPI1_CR1_BIDIMODE                           \ Bidirectional data mode enable. This bit enables half-duplex communication using common single bidirectional data line. Keep RXONLY bit clear when bidirectional mode is active. - 0: 2-line unidirectional data mode selected - 1: 1-line bidirectional data mode selected


\
\ @brief SPI1_CR2 register
\ Address offset: 0x04
\ Reset value: 0x00000700
\

$00000001 constant SPI1_SPI1_CR2_RXDMAEN                            \ Rx buffer DMA enable When this bit is set, a DMA request is generated whenever the RXNE flag is set. - 0: Rx buffer DMA disabled - 1: Rx buffer DMA enabled
$00000002 constant SPI1_SPI1_CR2_TXDMAEN                            \ Tx buffer DMA enable When this bit is set, a DMA request is generated whenever the TXE flag is set. - 0: Tx buffer DMA disabled - 1: Tx buffer DMA enabled
$00000004 constant SPI1_SPI1_CR2_SSOE                               \ SS output enable - 0: SS output is disabled in master mode and the SPI interface can work in multimaster configuration - 1: SS output is enabled in master mode and when the SPI interface is enabled. The SPI interface cannot work in a multimaster environment.
$00000008 constant SPI1_SPI1_CR2_NSSP                               \ NSS pulse management This bit is used in master mode only. it allow the SPI to generate an NSS pulse between two consecutive data when doing continuous transfers. In the case of a single data transfer, it forces the NSS pin high level after the transfer. It has no meaning if CPHA = 1, or FRF = 1. - 0: No NSS pulse - 1: NSS pulse generated
$00000010 constant SPI1_SPI1_CR2_FRF                                \ Frame format - 0: SPI Motorola mode - 1 SPI TI mode
$00000020 constant SPI1_SPI1_CR2_ERRIE                              \ Error interrupt enable This bit controls the generation of an interrupt when an error condition occurs (CRCERR, OVR, MODF in SPI mode, FRE at TI mode and UDR, OVR, and FRE in I2S mode). - 0: Error interrupt is masked - 1: Error interrupt is enabled
$00000040 constant SPI1_SPI1_CR2_RXNEIE                             \ RX buffer not empty interrupt enable - 0: RXNE interrupt masked - 1: RXNE interrupt not masked. Used to generate an interrupt request when the RXNE flag is set.
$00000080 constant SPI1_SPI1_CR2_TXEIE                              \ Tx buffer empty interrupt enable - 0: TXE interrupt masked - 1: TXE interrupt not masked. Used to generate an interrupt request when the TXE flag is set.
$00000f00 constant SPI1_SPI1_CR2_DS                                 \ Data size These bits configure the data length for SPI transfers: - 0000: Not used - 0001: Not used - 0010: Not used - 0011: 4-bit - 0100: 5-bit - 0101: 6-bit - 0110: 7-bit - 0111: 8-bit - 1000: 9-bit - 1001: 10-bit - 1010: 11-bit - 1011: 12-bit - 1100: 13-bit - 1101: 14-bit - 1110: 15-bit - 1111: 16-bit If software attempts to write one of the Not used values, they are forced to the value 0111(8-bit).
$00001000 constant SPI1_SPI1_CR2_FRXTH                              \ FIFO reception threshold FRXTH shall be set according the read access (16-bit or 8-bit) to the FIFO. This bit is used to set the threshold of the RXFIFO that triggers an RXNE event - 0: RXNE event is generated if the FIFO level is greater than or equal to 1/2 (16-bit) - 1: RXNE event is generated if the FIFO level is greater than or equal to 1/4 (8-bit)
$00002000 constant SPI1_SPI1_CR2_LDMA_RX                            \ Last DMA transfer for reception This bit is used in data packing mode, to define if the total number of data to receive by DMA is odd or even. It has significance only if the RXDMAEN bit in the SPIx_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPIx_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPIx_CR1 register). - 0: Number of data to transfer is even - 1: Number of data to transfer is odd
$00004000 constant SPI1_SPI1_CR2_LDMA_TX                            \ Last DMA transfer for transmission This bit is used in data packing mode, to define if the total number of data to transmit by DMA is odd or even. It has significance only if the TXDMAEN bit in the SPIx_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPIx_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPIx_CR1 register). - 0: Number of data to transfer is even - 1: Number of data to transfer is odd


\
\ @brief SPI1_SR register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000001 constant SPI1_SPI1_SR_RXNE                                \ Receive buffer not empty - 0: Rx buffer empty - 1: Rx buffer not empty
$00000002 constant SPI1_SPI1_SR_TXE                                 \ Transmit buffer empty - 0: No more empty space in Tx buffer. (software shall not write data to the Tx buffer). - 1: At least one empty space in Tx buffer. (software may write data to the Tx buffer).
$00000004 constant SPI1_SPI1_SR_CHSIDE                              \ Channel side - 0: Channel Left has to be transmitted or has been received - 1: Channel Right has to be transmitted or has been received
$00000008 constant SPI1_SPI1_SR_UDR                                 \ Underrun flag - 0: No underrun occurred - 1: Underrun occurred
$00000010 constant SPI1_SPI1_SR_CRCERR                              \ CRC error flag - 0: CRC value received matches the SPIx_RXCRCR value - 1: CRC value received does not match the SPIx_RXCRCR value This flag is set by hardware and cleared by software writing 0.
$00000020 constant SPI1_SPI1_SR_MODF                                \ Mode fault - 0: No mode fault occurred - 1: Mode fault occurred
$00000040 constant SPI1_SPI1_SR_OVR                                 \ Overrun flag - 0: No overrun occurred - 1: Overrun occurred
$00000080 constant SPI1_SPI1_SR_BSY                                 \ Busy flag - 0: SPI (or I2S) not busy - 1: SPI (or I2S) is busy in communication or Tx buffer is not empty This flag is set and cleared by hardware.
$00000100 constant SPI1_SPI1_SR_FRE                                 \ Frame format error This flag is used for SPI in TI slave mode and I2S slave mode. Refer to Section 18.5.10: SPI error flags and Section 18.7.6: I2S error flags. This flag is set by hardware and reset when SPIx_SR is read by software. - 0: No frame format error - 1: A frame format error occurred
$00000600 constant SPI1_SPI1_SR_FRLVL                               \ FIFO reception level These bits are set and cleared by hardware. - 00: FIFO empty - 01: 1/4 FIFO - 10: 1/2 FIFO - 11: FIFO full
$00001800 constant SPI1_SPI1_SR_FTLVL                               \ FIFO Transmission Level These bits are set and cleared by hardware. - 00: FIFO empty - 01: 1/4 FIFO - 10: 1/2 FIFO - 11: FIFO full (considered as FULL when the FIFO threshold is greater than 1/2)


\
\ @brief SPI1_DR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_SPI1_DR_DR                                  \ Data register Data received or to be transmitted The data register serves as an interface between the Rx and Tx FIFOs. When the data register is read, RxFIFO is accessed while the write to data register accesses TxFIFO (See Section 18.5.8: Data transmission and reception procedures). Note: Data is always right-aligned. Unused bits are ignored when writing to the register, and read as zero when the register is read. The Rx threshold setting must always correspond with the read access currently used.


\
\ @brief SPI1_CRCPR register
\ Address offset: 0x10
\ Reset value: 0x00000007
\

$0000ffff constant SPI1_SPI1_CRCPR_CRCPOLY                          \ CRC polynomial register This register contains the polynomial for the CRC calculation. The CRC polynomial (0007h) is the reset value of this register. Another polynomial can be configured as required.


\
\ @brief SPI1_RXCRCR register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_SPI1_RXCRCR_RXCRC                           \ Rx CRC register When CRC calculation is enabled, the RxCRC[15:0] bits contain the computed CRC value of the subsequently received bytes. This register is reset when the CRCEN bit in SPIx_CR1 register is written to 1. The CRC is calculated serially using the polynomial programmed in the SPIx_CRCPR register. Only the 8 LSB bits are considered when the data frame format is set to be 8-bit data (CRCL bit in the SPIx_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit data frame format is selected (CRCL bit in the SPIx_CR1 register is set). CRC calculation is done based on any CRC16 standard. A read to this register when the BSY Flag is set could return an incorrect value.


\
\ @brief SPI1_TXCRCR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_SPI1_TXCRCR_TXCRC                           \ Tx CRC register When CRC calculation is enabled, the TxCRC[7:0] bits contain the computed CRC value of the subsequently transmitted bytes. This register is reset when the CRCEN bit of SPIx_CR1 is written to 1. The CRC is calculated serially using the polynomial programmed in the Tx CRC register When CRC calculation is enabled, the TxCRC[7:0] bits contain the computed CRC value of the subsequently transmitted bytes. This register is reset when the CRCEN bit of SPIx_CR1 is written to 1. The CRC is calculated serially using the polynomial programmed in the SPIx_CRCPR register. Only the 8 LSB bits are considered when the data frame format is set to be 8-bit data (CRCL bit in the SPIx_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit data frame format is selected (CRCL bit in the SPIx_CR1 register is set). CRC calculation is done based on any CRC16 standard. Note: A read to this register when the BSY flag is set could return an incorrect value. These bits are not used in I2S mode.


\
\ @brief SPI1_I2SCFGR register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SPI1_SPI1_I2SCFGR_CHLEN                          \ Channel length (number of bits per audio channel) - 0: 16-bit wide - 1: 32-bit wide The bit write operation has a meaning only if DATLEN = 00 otherwise the channel length is fixed to 32-bit by hardware whatever the value filled in.
$00000006 constant SPI1_SPI1_I2SCFGR_DATLEN                         \ Data length to be transferred - 00: 16-bit data length - 01: 24-bit data length - 10: 32-bit data length - 11: Not allowed
$00000008 constant SPI1_SPI1_I2SCFGR_CKPOL                          \ Steady state clock polarity - 0: I2S clock steady state is low level - 1: I2S clock steady state is high level
$00000030 constant SPI1_SPI1_I2SCFGR_I2SSTD                         \ I2S standard selection - 00: I2S Philips standard. - 01: MSB justified standard (left justified) - 10: LSB justified standard (right justified) - 11: PCM standard
$00000080 constant SPI1_SPI1_I2SCFGR_PCMSYNC                        \ PCM frame synchronization - 0: Short frame synchronization - 1: Long frame synchronization Note: This bit has a meaning only if I2SSTD = 11 (PCM standard is used). It is not used in SPI mode.
$00000300 constant SPI1_SPI1_I2SCFGR_I2SCFG                         \ I2S configuration mode - 00: Slave - transmit - 01: Slave - receive - 10: Master - transmit - 11: Master - receive
$00000400 constant SPI1_SPI1_I2SCFGR_I2SE                           \ I2S enable - 0: I2S peripheral is disabled - 1: I2S peripheral is enabled Note: This bit is not used in SPI mode.
$00000800 constant SPI1_SPI1_I2SCFGR_I2SMOD                         \ I2S mode selection - 0: SPI mode is selected - 1: I2S mode is selected Note: This bit should be configured when the SPI is disabled.
$00001000 constant SPI1_SPI1_I2SCFGR_ASTREN                         \ Asynchronous start enable. - 0: The Asynchronous start is disabled. When the I2S is enabled in slave mode, the I2S slave starts the transfer when the I2S clock is received and an appropriate transition (depending on the protocol selected) is detected on the WS signal. - 1: The Asynchronous start is enabled. When the I2S is enabled in slave mode, the I2S slave starts immediately the transfer when the I2S clock is received from the master without checking the expected transition of WS signal. Note: The appropriate transition is a falling edge on WS signal when I2S Philips Standard is used, or a rising edge for other standards.


\
\ @brief SPI1_I2SPR register
\ Address offset: 0x20
\ Reset value: 0x    NULL
\

$000000ff constant SPI1_SPI1_I2SPR_I2SDIV                           \ I2S linear prescaler I2SDIV [7:0] = 0 or I2SDIV [7:0] = 1 are forbidden values.
$00000100 constant SPI1_SPI1_I2SPR_ODD                              \ Odd factor for the prescaler - 0: Real divider value is = I2SDIV *2 - 1: Real divider value is = (I2SDIV * 2)+1
$00000200 constant SPI1_SPI1_I2SPR_MCKOE                            \ Master clock output enable - 0: Master clock output is disabled - 1: Master clock output is enabled


\
\ @brief SPI1 interrupt
\
$41002000 constant SPI1_SPI1_CR1  \ offset: 0x00 : SPI1_CR1 register
$41002004 constant SPI1_SPI1_CR2  \ offset: 0x04 : SPI1_CR2 register
$41002008 constant SPI1_SPI1_SR   \ offset: 0x08 : SPI1_SR register
$4100200c constant SPI1_SPI1_DR   \ offset: 0x0C : SPI1_DR register
$41002010 constant SPI1_SPI1_CRCPR  \ offset: 0x10 : SPI1_CRCPR register
$41002014 constant SPI1_SPI1_RXCRCR  \ offset: 0x14 : SPI1_RXCRCR register
$41002018 constant SPI1_SPI1_TXCRCR  \ offset: 0x18 : SPI1_TXCRCR register
$4100201c constant SPI1_SPI1_I2SCFGR  \ offset: 0x1C : SPI1_I2SCFGR register
$41002020 constant SPI1_SPI1_I2SPR  \ offset: 0x20 : SPI1_I2SPR register

