\
\ @file spi.fs
\ @brief SPI address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI_DEF

  [ifdef] SPI_SPI_CR1_DEF
    \
    \ @brief SPI control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI_CPHA                       \ [0x00] Clock phase Note: This bit should not be changed when communication is ongoing. Note: This bit is not used in SPI TI mode except the case when CRC is applied at TI mode.
    $01 constant SPI_CPOL                       \ [0x01] Clock polarity Note: This bit should not be changed when communication is ongoing. Note: This bit is not used in SPI TI mode except the case when CRC is applied at TI mode.
    $02 constant SPI_MSTR                       \ [0x02] Master selection Note: This bit should not be changed when communication is ongoing.
    $03 constant SPI_BR                         \ [0x03 : 3] Baud rate control Note: These bits should not be changed when communication is ongoing.
    $06 constant SPI_SPE                        \ [0x06] SPI enable Note: When disabling the SPI, follow the procedure described in Procedure for disabling the SPI on page1954.
    $07 constant SPI_LSBFIRST                   \ [0x07] Frame format Note: 1. This bit should not be changed when communication is ongoing. Note: 2. This bit is not used in SPI TI mode.
    $08 constant SPI_SSI                        \ [0x08] Internal slave select This bit has an effect only when the SSM bit is set. The value of this bit is forced onto the NSS pin and the I/O value of the NSS pin is ignored. Note: This bit is not used in SPI TI mode.
    $09 constant SPI_SSM                        \ [0x09] Software slave management When the SSM bit is set, the NSS pin input is replaced with the value from the SSI bit. Note: This bit is not used in SPI TI mode.
    $0a constant SPI_RXONLY                     \ [0x0a] Receive only mode enabled. This bit enables simplex communication using a single unidirectional line to receive data exclusively. Keep BIDIMODE bit clear when receive only mode is active.This bit is also useful in a multislave system in which this particular slave is not accessed, the output from the accessed slave is not corrupted.
    $0b constant SPI_CRCL                       \ [0x0b] CRC length This bit is set and cleared by software to select the CRC length. Note: This bit should be written only when SPI is disabled (SPE = 0) for correct operation.
    $0c constant SPI_CRCNEXT                    \ [0x0c] Transmit CRC next Note: This bit has to be written as soon as the last data is written in the SPI_DR register.
    $0d constant SPI_CRCEN                      \ [0x0d] Hardware CRC calculation enable Note: This bit should be written only when SPI is disabled (SPE = 0) for correct operation.
    $0e constant SPI_BIDIOE                     \ [0x0e] Output enable in bidirectional mode This bit combined with the BIDIMODE bit selects the direction of transfer in bidirectional mode. Note: In master mode, the MOSI pin is used and in slave mode, the MISO pin is used.
    $0f constant SPI_BIDIMODE                   \ [0x0f] Bidirectional data mode enable. This bit enables half-duplex communication using common single bidirectional data line. Keep RXONLY bit clear when bidirectional mode is active.
  [then]


  [ifdef] SPI_SPI_CR2_DEF
    \
    \ @brief SPI control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000700
    \
    $00 constant SPI_RXDMAEN                    \ [0x00] Rx buffer DMA enable When this bit is set, a DMA request is generated whenever the RXNE flag is set.
    $01 constant SPI_TXDMAEN                    \ [0x01] Tx buffer DMA enable When this bit is set, a DMA request is generated whenever the TXE flag is set.
    $02 constant SPI_SSOE                       \ [0x02] SS output enable Note: This bit is not used in SPI TI mode.
    $03 constant SPI_NSSP                       \ [0x03] NSS pulse management This bit is used in master mode only. it allows the SPI to generate an NSS pulse between two consecutive data when doing continuous transfers. In the case of a single data transfer, it forces the NSS pin high level after the transfer. It has no meaning if CPHA = 1, or FRF = 1. Note: 1. This bit must be written only when the SPI is disabled (SPE=0). Note: 2. This bit is not used in SPI TI mode.
    $04 constant SPI_FRF                        \ [0x04] Frame format 1 SPI TI mode Note: This bit must be written only when the SPI is disabled (SPE=0).
    $05 constant SPI_ERRIE                      \ [0x05] Error interrupt enable This bit controls the generation of an interrupt when an error condition occurs (CRCERR, OVR, MODF in SPI mode, FRE at TI mode).
    $06 constant SPI_RXNEIE                     \ [0x06] RX buffer not empty interrupt enable
    $07 constant SPI_TXEIE                      \ [0x07] Tx buffer empty interrupt enable
    $08 constant SPI_DS                         \ [0x08 : 4] Data size These bits configure the data length for SPI transfers. If software attempts to write one of the Not used values, they are forced to the value 0111 (8-bit)
    $0c constant SPI_FRXTH                      \ [0x0c] FIFO reception threshold This bit is used to set the threshold of the RXFIFO that triggers an RXNE event
    $0d constant SPI_LDMA_RX                    \ [0x0d] Last DMA transfer for reception This bit is used in data packing mode, to define if the total number of data to receive by DMA is odd or even. It has significance only if the RXDMAEN bit in the SPI_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPI_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPI_CR1 register). Note: Refer to Procedure for disabling the SPI on page1954 if the CRCEN bit is set.
    $0e constant SPI_LDMA_TX                    \ [0x0e] Last DMA transfer for transmission This bit is used in data packing mode, to define if the total number of data to transmit by DMA is odd or even. It has significance only if the TXDMAEN bit in the SPI_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPI_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPI_CR1 register). Note: Refer to Procedure for disabling the SPI on page1954 if the CRCEN bit is set.
  [then]


  [ifdef] SPI_SPI_SR_DEF
    \
    \ @brief SPI status register
    \ Address offset: 0x08
    \ Reset value: 0x00000002
    \
    $00 constant SPI_RXNE                       \ [0x00] Receive buffer not empty
    $01 constant SPI_TXE                        \ [0x01] Transmit buffer empty
    $04 constant SPI_CRCERR                     \ [0x04] CRC error flag Note: This flag is set by hardware and cleared by software writing 0.
    $05 constant SPI_MODF                       \ [0x05] Mode fault This flag is set by hardware and reset by a software sequence. Refer to Section1: Mode fault (MODF) on page1964 for the software sequence.
    $06 constant SPI_OVR                        \ [0x06] Overrun flag This flag is set by hardware and reset by a software sequence.
    $07 constant SPI_BSY                        \ [0x07] Busy flag This flag is set and cleared by hardware. Note: The BSY flag must be used with caution: refer to Section133.4.10: SPI status flags and Procedure for disabling the SPI on page1954.
    $08 constant SPI_FRE                        \ [0x08] Frame format error This flag is used for SPI in TI slave mode. Refer to Section133.4.11: SPI error flags. This flag is set by hardware and reset when SPI_SR is read by software.
    $09 constant SPI_FRLVL                      \ [0x09 : 2] FIFO reception level These bits are set and cleared by hardware. Note: These bits are not used in SPI receive-only mode while CRC calculation is enabled.
    $0b constant SPI_FTLVL                      \ [0x0b : 2] FIFO transmission level These bits are set and cleared by hardware.
  [then]


  [ifdef] SPI_SPI_DR_DEF
    \
    \ @brief SPI data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_DR                         \ [0x00 : 16] Data register Data received or to be transmitted The data register serves as an interface between the Rx and Tx FIFOs. When the data register is read, RxFIFO is accessed while the write to data register accesses TxFIFO (See Section133.4.9: Data transmission and reception procedures). Note: Data is always right-aligned. Unused bits are ignored when writing to the register, and read as zero when the register is read. The Rx threshold setting must always correspond with the read access currently used.
  [then]


  [ifdef] SPI_SPI_CRCPR_DEF
    \
    \ @brief SPI CRC polynomial register
    \ Address offset: 0x10
    \ Reset value: 0x00000007
    \
    $00 constant SPI_CRCPOLY                    \ [0x00 : 16] CRC polynomial register This register contains the polynomial for the CRC calculation. The CRC polynomial (0x0007) is the reset value of this register. Another polynomial can be configured as required.
  [then]


  [ifdef] SPI_SPI_RXCRCR_DEF
    \
    \ @brief SPI Rx CRC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXCRC                      \ [0x00 : 16] Rx CRC register When CRC calculation is enabled, the RXCRC[15:0] bits contain the computed CRC value of the subsequently received bytes. This register is reset when the CRCEN bit in SPI_CR1 register is written to 1. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPR register. Only the 8 LSB bits are considered when the CRC frame format is set to be 8-bit length (CRCL bit in the SPI_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit CRC frame format is selected (CRCL bit in the SPI_CR1 register is set). CRC calculation is done based on any CRC16 standard. Note: A read to this register when the BSY Flag is set could return an incorrect value.
  [then]


  [ifdef] SPI_SPI_TXCRCR_DEF
    \
    \ @brief SPI Tx CRC register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXCRC                      \ [0x00 : 16] Tx CRC register When CRC calculation is enabled, the TXCRC[7:0] bits contain the computed CRC value of the subsequently transmitted bytes. This register is reset when the CRCEN bit of SPI_CR1 is written to 1. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPR register. Only the 8 LSB bits are considered when the CRC frame format is set to be 8-bit length (CRCL bit in the SPI_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit CRC frame format is selected (CRCL bit in the SPI_CR1 register is set). CRC calculation is done based on any CRC16 standard. Note: A read to this register when the BSY flag is set could return an incorrect value.
  [then]

  \
  \ @brief SPI address block description
  \
  $00 constant SPI_SPI_CR1              \ SPI control register 1
  $04 constant SPI_SPI_CR2              \ SPI control register 2
  $08 constant SPI_SPI_SR               \ SPI status register
  $0C constant SPI_SPI_DR               \ SPI data register
  $10 constant SPI_SPI_CRCPR            \ SPI CRC polynomial register
  $14 constant SPI_SPI_RXCRCR           \ SPI Rx CRC register
  $18 constant SPI_SPI_TXCRCR           \ SPI Tx CRC register

: SPI_DEF ; [then]
