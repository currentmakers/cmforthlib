\
\ @file spi2.fs
\ @brief SPI2 global interrupt
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

$00000001 constant SPI2_SPI_CR1_CPHA                                \ Clock phase Note: This bit should not be changed when communication is ongoing. Note: This bit is not used in SPI TI mode except the case when CRC is applied at TI mode.
$00000002 constant SPI2_SPI_CR1_CPOL                                \ Clock polarity Note: This bit should not be changed when communication is ongoing. Note: This bit is not used in SPI TI mode except the case when CRC is applied at TI mode.
$00000004 constant SPI2_SPI_CR1_MSTR                                \ Master selection Note: This bit should not be changed when communication is ongoing.
$00000038 constant SPI2_SPI_CR1_BR                                  \ Baud rate control Note: These bits should not be changed when communication is ongoing.
$00000040 constant SPI2_SPI_CR1_SPE                                 \ SPI enable Note: When disabling the SPI, follow the procedure described in Procedure for disabling the SPI on page1954.
$00000080 constant SPI2_SPI_CR1_LSBFIRST                            \ Frame format Note: 1. This bit should not be changed when communication is ongoing. Note: 2. This bit is not used in SPI TI mode.
$00000100 constant SPI2_SPI_CR1_SSI                                 \ Internal slave select This bit has an effect only when the SSM bit is set. The value of this bit is forced onto the NSS pin and the I/O value of the NSS pin is ignored. Note: This bit is not used in SPI TI mode.
$00000200 constant SPI2_SPI_CR1_SSM                                 \ Software slave management When the SSM bit is set, the NSS pin input is replaced with the value from the SSI bit. Note: This bit is not used in SPI TI mode.
$00000400 constant SPI2_SPI_CR1_RXONLY                              \ Receive only mode enabled. This bit enables simplex communication using a single unidirectional line to receive data exclusively. Keep BIDIMODE bit clear when receive only mode is active.This bit is also useful in a multislave system in which this particular slave is not accessed, the output from the accessed slave is not corrupted.
$00000800 constant SPI2_SPI_CR1_CRCL                                \ CRC length This bit is set and cleared by software to select the CRC length. Note: This bit should be written only when SPI is disabled (SPE = 0) for correct operation.
$00001000 constant SPI2_SPI_CR1_CRCNEXT                             \ Transmit CRC next Note: This bit has to be written as soon as the last data is written in the SPI_DR register.
$00002000 constant SPI2_SPI_CR1_CRCEN                               \ Hardware CRC calculation enable Note: This bit should be written only when SPI is disabled (SPE = 0) for correct operation.
$00004000 constant SPI2_SPI_CR1_BIDIOE                              \ Output enable in bidirectional mode This bit combined with the BIDIMODE bit selects the direction of transfer in bidirectional mode. Note: In master mode, the MOSI pin is used and in slave mode, the MISO pin is used.
$00008000 constant SPI2_SPI_CR1_BIDIMODE                            \ Bidirectional data mode enable. This bit enables half-duplex communication using common single bidirectional data line. Keep RXONLY bit clear when bidirectional mode is active.


\
\ @brief SPI control register 2
\ Address offset: 0x04
\ Reset value: 0x00000700
\

$00000001 constant SPI2_SPI_CR2_RXDMAEN                             \ Rx buffer DMA enable When this bit is set, a DMA request is generated whenever the RXNE flag is set.
$00000002 constant SPI2_SPI_CR2_TXDMAEN                             \ Tx buffer DMA enable When this bit is set, a DMA request is generated whenever the TXE flag is set.
$00000004 constant SPI2_SPI_CR2_SSOE                                \ SS output enable Note: This bit is not used in SPI TI mode.
$00000008 constant SPI2_SPI_CR2_NSSP                                \ NSS pulse management This bit is used in master mode only. it allows the SPI to generate an NSS pulse between two consecutive data when doing continuous transfers. In the case of a single data transfer, it forces the NSS pin high level after the transfer. It has no meaning if CPHA = 1, or FRF = 1. Note: 1. This bit must be written only when the SPI is disabled (SPE=0). Note: 2. This bit is not used in SPI TI mode.
$00000010 constant SPI2_SPI_CR2_FRF                                 \ Frame format 1 SPI TI mode Note: This bit must be written only when the SPI is disabled (SPE=0).
$00000020 constant SPI2_SPI_CR2_ERRIE                               \ Error interrupt enable This bit controls the generation of an interrupt when an error condition occurs (CRCERR, OVR, MODF in SPI mode, FRE at TI mode).
$00000040 constant SPI2_SPI_CR2_RXNEIE                              \ RX buffer not empty interrupt enable
$00000080 constant SPI2_SPI_CR2_TXEIE                               \ Tx buffer empty interrupt enable
$00000f00 constant SPI2_SPI_CR2_DS                                  \ Data size These bits configure the data length for SPI transfers. If software attempts to write one of the Not used values, they are forced to the value 0111 (8-bit)
$00001000 constant SPI2_SPI_CR2_FRXTH                               \ FIFO reception threshold This bit is used to set the threshold of the RXFIFO that triggers an RXNE event
$00002000 constant SPI2_SPI_CR2_LDMA_RX                             \ Last DMA transfer for reception This bit is used in data packing mode, to define if the total number of data to receive by DMA is odd or even. It has significance only if the RXDMAEN bit in the SPI_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPI_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPI_CR1 register). Note: Refer to Procedure for disabling the SPI on page1954 if the CRCEN bit is set.
$00004000 constant SPI2_SPI_CR2_LDMA_TX                             \ Last DMA transfer for transmission This bit is used in data packing mode, to define if the total number of data to transmit by DMA is odd or even. It has significance only if the TXDMAEN bit in the SPI_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPI_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPI_CR1 register). Note: Refer to Procedure for disabling the SPI on page1954 if the CRCEN bit is set.


\
\ @brief SPI status register
\ Address offset: 0x08
\ Reset value: 0x00000002
\

$00000001 constant SPI2_SPI_SR_RXNE                                 \ Receive buffer not empty
$00000002 constant SPI2_SPI_SR_TXE                                  \ Transmit buffer empty
$00000010 constant SPI2_SPI_SR_CRCERR                               \ CRC error flag Note: This flag is set by hardware and cleared by software writing 0.
$00000020 constant SPI2_SPI_SR_MODF                                 \ Mode fault This flag is set by hardware and reset by a software sequence. Refer to Section1: Mode fault (MODF) on page1964 for the software sequence.
$00000040 constant SPI2_SPI_SR_OVR                                  \ Overrun flag This flag is set by hardware and reset by a software sequence.
$00000080 constant SPI2_SPI_SR_BSY                                  \ Busy flag This flag is set and cleared by hardware. Note: The BSY flag must be used with caution: refer to Section133.4.10: SPI status flags and Procedure for disabling the SPI on page1954.
$00000100 constant SPI2_SPI_SR_FRE                                  \ Frame format error This flag is used for SPI in TI slave mode. Refer to Section133.4.11: SPI error flags. This flag is set by hardware and reset when SPI_SR is read by software.
$00000600 constant SPI2_SPI_SR_FRLVL                                \ FIFO reception level These bits are set and cleared by hardware. Note: These bits are not used in SPI receive-only mode while CRC calculation is enabled.
$00001800 constant SPI2_SPI_SR_FTLVL                                \ FIFO transmission level These bits are set and cleared by hardware.


\
\ @brief SPI data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SPI2_SPI_DR_DR                                   \ Data register Data received or to be transmitted The data register serves as an interface between the Rx and Tx FIFOs. When the data register is read, RxFIFO is accessed while the write to data register accesses TxFIFO (See Section133.4.9: Data transmission and reception procedures). Note: Data is always right-aligned. Unused bits are ignored when writing to the register, and read as zero when the register is read. The Rx threshold setting must always correspond with the read access currently used.


\
\ @brief SPI CRC polynomial register
\ Address offset: 0x10
\ Reset value: 0x00000007
\

$0000ffff constant SPI2_SPI_CRCPR_CRCPOLY                           \ CRC polynomial register This register contains the polynomial for the CRC calculation. The CRC polynomial (0x0007) is the reset value of this register. Another polynomial can be configured as required.


\
\ @brief SPI Rx CRC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPI2_SPI_RXCRCR_RXCRC                            \ Rx CRC register When CRC calculation is enabled, the RXCRC[15:0] bits contain the computed CRC value of the subsequently received bytes. This register is reset when the CRCEN bit in SPI_CR1 register is written to 1. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPR register. Only the 8 LSB bits are considered when the CRC frame format is set to be 8-bit length (CRCL bit in the SPI_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit CRC frame format is selected (CRCL bit in the SPI_CR1 register is set). CRC calculation is done based on any CRC16 standard. Note: A read to this register when the BSY Flag is set could return an incorrect value.


\
\ @brief SPI Tx CRC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant SPI2_SPI_TXCRCR_TXCRC                            \ Tx CRC register When CRC calculation is enabled, the TXCRC[7:0] bits contain the computed CRC value of the subsequently transmitted bytes. This register is reset when the CRCEN bit of SPI_CR1 is written to 1. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPR register. Only the 8 LSB bits are considered when the CRC frame format is set to be 8-bit length (CRCL bit in the SPI_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit CRC frame format is selected (CRCL bit in the SPI_CR1 register is set). CRC calculation is done based on any CRC16 standard. Note: A read to this register when the BSY flag is set could return an incorrect value.


\
\ @brief SPI2 global interrupt
\
$40003800 constant SPI2_SPI_CR1   \ offset: 0x00 : SPI control register 1
$40003804 constant SPI2_SPI_CR2   \ offset: 0x04 : SPI control register 2
$40003808 constant SPI2_SPI_SR    \ offset: 0x08 : SPI status register
$4000380c constant SPI2_SPI_DR    \ offset: 0x0C : SPI data register
$40003810 constant SPI2_SPI_CRCPR  \ offset: 0x10 : SPI CRC polynomial register
$40003814 constant SPI2_SPI_RXCRCR  \ offset: 0x14 : SPI Rx CRC register
$40003818 constant SPI2_SPI_TXCRCR  \ offset: 0x18 : SPI Tx CRC register

