\
\ @file spi3.fs
\ @brief SPI address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI3_DEF

  [ifdef] SPI3_SPIx_CR1_DEF
    \
    \ @brief SPI control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_CPHA                      \ [0x00] Clock phase Note: This bit should not be changed when communication is ongoing. Note: This bit is not used in I<sup>2</sup>S mode and SPI TI mode except the case when CRC is applied at TI mode.
    $01 constant SPI3_CPOL                      \ [0x01] Clock polarity Note: This bit should not be changed when communication is ongoing. Note: This bit is not used in I<sup>2</sup>S mode and SPI TI mode except the case when CRC is applied at TI mode.
    $02 constant SPI3_MSTR                      \ [0x02] Master selection Note: This bit should not be changed when communication is ongoing. Note: This bit is not used in I<sup>2</sup>S mode.
    $03 constant SPI3_BR                        \ [0x03 : 3] Baud rate control Note: These bits should not be changed when communication is ongoing. Note: These bits are not used in I<sup>2</sup>S mode.
    $06 constant SPI3_SPE                       \ [0x06] SPI enable Note: When disabling the SPI, follow the procedure described in Procedure for disabling the SPI on page 789. Note: This bit is not used in I<sup>2</sup>S mode.
    $07 constant SPI3_LSBFIRST                  \ [0x07] Frame format Note: 1. This bit should not be changed when communication is ongoing. Note: 2. This bit is not used in I<sup>2</sup>S mode and SPI TI mode.
    $08 constant SPI3_SSI                       \ [0x08] Internal slave select This bit has an effect only when the SSM bit is set. The value of this bit is forced onto the NSS pin and the I/O value of the NSS pin is ignored. Note: This bit is not used in I<sup>2</sup>S mode and SPI TI mode.
    $09 constant SPI3_SSM                       \ [0x09] Software slave management When the SSM bit is set, the NSS pin input is replaced with the value from the SSI bit. Note: This bit is not used in I<sup>2</sup>S mode and SPI TI mode.
    $0a constant SPI3_RXONLY                    \ [0x0a] Receive only mode enabled. This bit enables simplex communication using a single unidirectional line to receive data exclusively. Keep BIDIMODE bit clear when receive only mode is active.This bit is also useful in a multislave system in which this particular slave is not accessed, the output from the accessed slave is not corrupted. Note: This bit is not used in I<sup>2</sup>S mode.
    $0b constant SPI3_CRCL                      \ [0x0b] CRC length This bit is set and cleared by software to select the CRC length. Note: This bit should be written only when SPI is disabled (SPE = 0 ) for correct operation. Note: This bit is not used in I<sup>2</sup>S mode.
    $0c constant SPI3_CRCNEXT                   \ [0x0c] Transmit CRC next Note: This bit has to be written as soon as the last data is written in the SPIx_DR register. Note: This bit is not used in I<sup>2</sup>S mode.
    $0d constant SPI3_CRCEN                     \ [0x0d] Hardware CRC calculation enable Note: This bit should be written only when SPI is disabled (SPE = 0 ) for correct operation. Note: This bit is not used in I<sup>2</sup>S mode.
    $0e constant SPI3_BIDIOE                    \ [0x0e] Output enable in bidirectional mode This bit combined with the BIDIMODE bit selects the direction of transfer in bidirectional mode. Note: In master mode, the MOSI pin is used and in slave mode, the MISO pin is used. Note: This bit is not used in I<sup>2</sup>S mode.
    $0f constant SPI3_BIDIMODE                  \ [0x0f] Bidirectional data mode enable. This bit enables half-duplex communication using common single bidirectional data line. Keep RXONLY bit clear when bidirectional mode is active. Note: This bit is not used in I<sup>2</sup>S mode.
  [then]


  [ifdef] SPI3_SPIx_CR2_DEF
    \
    \ @brief SPI control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000700
    \
    $00 constant SPI3_RXDMAEN                   \ [0x00] Rx buffer DMA enable When this bit is set, a DMA request is generated whenever the RXNE flag is set.
    $01 constant SPI3_TXDMAEN                   \ [0x01] Tx buffer DMA enable When this bit is set, a DMA request is generated whenever the TXE flag is set.
    $02 constant SPI3_SSOE                      \ [0x02] SS output enable Note: This bit is not used in I<sup>2</sup>S mode and SPI TI mode.
    $03 constant SPI3_NSSP                      \ [0x03] NSS pulse management This bit is used in master mode only. it allows the SPI to generate an NSS pulse between two consecutive data when doing continuous transfers. In the case of a single data transfer, it forces the NSS pin high level after the transfer. It has no meaning if CPHA = 1 , or FRF = 1 . Note: 1. This bit must be written only when the SPI is disabled (SPE=0). Note: 2. This bit is not used in I<sup>2</sup>S mode and SPI TI mode.
    $04 constant SPI3_FRF                       \ [0x04] Frame format 1 SPI TI mode Note: This bit must be written only when the SPI is disabled (SPE=0). Note: This bit is not used in I<sup>2</sup>S mode.
    $05 constant SPI3_ERRIE                     \ [0x05] Error interrupt enable This bit controls the generation of an interrupt when an error condition occurs (CRCERR, OVR, MODF in SPI mode, FRE at TI mode and UDR, OVR, and FRE in I<sup>2</sup>S mode).
    $06 constant SPI3_RXNEIE                    \ [0x06] RX buffer not empty interrupt enable
    $07 constant SPI3_TXEIE                     \ [0x07] Tx buffer empty interrupt enable
    $08 constant SPI3_DS                        \ [0x08 : 4] Data size These bits configure the data length for SPI transfers. If software attempts to write one of the Not used values, they are forced to the value 0111 (8-bit) Note: These bits are not used in I<sup>2</sup>S mode.
    $0c constant SPI3_FRXTH                     \ [0x0c] FIFO reception threshold This bit is used to set the threshold of the RXFIFO that triggers an RXNE event Note: This bit is not used in I<sup>2</sup>S mode.
    $0d constant SPI3_LDMA_RX                   \ [0x0d] Last DMA transfer for reception This bit is used in data packing mode, to define if the total number of data to receive by DMA is odd or even. It has significance only if the RXDMAEN bit in the SPIx_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPIx_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPIx_CR1 register). Note: Refer to Procedure for disabling the SPI on page 789 if the CRCEN bit is set. Note: This bit is not used in I S mode.
    $0e constant SPI3_LDMA_TX                   \ [0x0e] Last DMA transfer for transmission This bit is used in data packing mode, to define if the total number of data to transmit by DMA is odd or even. It has significance only if the TXDMAEN bit in the SPIx_CR2 register is set and if packing mode is used (data length =< 8-bit and write access to SPIx_DR is 16-bit wide). It has to be written when the SPI is disabled (SPE = 0 in the SPIx_CR1 register). Note: Refer to Procedure for disabling the SPI on page 789 if the CRCEN bit is set. Note: This bit is not used in I S mode.
  [then]


  [ifdef] SPI3_SPIx_SR_DEF
    \
    \ @brief SPI status register
    \ Address offset: 0x08
    \ Reset value: 0x00000002
    \
    $00 constant SPI3_RXNE                      \ [0x00] Receive buffer not empty
    $01 constant SPI3_TXE                       \ [0x01] Transmit buffer empty
    $02 constant SPI3_CHSIDE                    \ [0x02] Channel side Note: This bit is not used in SPI mode. It has no significance in PCM mode.
    $03 constant SPI3_UDR                       \ [0x03] Underrun flag This flag is set by hardware and reset by a software sequence. Refer to I2S error flags on page 821 for the software sequence. Note: This bit is not used in SPI mode.
    $04 constant SPI3_CRCERR                    \ [0x04] CRC error flag Note: This flag is set by hardware and cleared by software writing 0. Note: This bit is not used in I<sup>2</sup>S mode.
    $05 constant SPI3_MODF                      \ [0x05] Mode fault This flag is set by hardware and reset by a software sequence. Refer to Section : Mode fault (MODF) on page 799 for the software sequence. Note: This bit is not used in I<sup>2</sup>S mode.
    $06 constant SPI3_OVR                       \ [0x06] Overrun flag This flag is set by hardware and reset by a software sequence. Refer to I2S error flags on page 821 for the software sequence.
    $07 constant SPI3_BSY                       \ [0x07] Busy flag This flag is set and cleared by hardware. Note: The BSY flag must be used with caution: refer to Section 27.5.10: SPI status flags and Procedure for disabling the SPI on page 789.
    $08 constant SPI3_FRE                       \ [0x08] Frame format error This flag is used for SPI in TI slave mode and I<sup>2</sup>S slave mode. Refer to Section 27.5.11: SPI error flags and Section 27.7.8: I2S error flags. This flag is set by hardware and reset when SPIx_SR is read by software.
    $09 constant SPI3_FRLVL                     \ [0x09 : 2] FIFO reception level These bits are set and cleared by hardware. Note: These bits are not used in I S mode and in SPI receive-only mode while CRC calculation is enabled.
    $0b constant SPI3_FTLVL                     \ [0x0b : 2] FIFO transmission level These bits are set and cleared by hardware. Note: This bit is not used in I<sup>2</sup>S mode.
  [then]


  [ifdef] SPI3_SPIx_DR_DEF
    \
    \ @brief SPI data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_DR                        \ [0x00 : 16] Data register Data received or to be transmitted The data register serves as an interface between the Rx and Tx FIFOs. When the data register is read, RxFIFO is accessed while the write to data register accesses TxFIFO (See Section 27.5.9: Data transmission and reception procedures). Note: Data is always right-aligned. Unused bits are ignored when writing to the register, and read as zero when the register is read. The Rx threshold setting must always correspond with the read access currently used.
  [then]


  [ifdef] SPI3_SPIx_CRCPR_DEF
    \
    \ @brief SPI CRC polynomial register
    \ Address offset: 0x10
    \ Reset value: 0x00000007
    \
    $00 constant SPI3_CRCPOLY                   \ [0x00 : 16] CRC polynomial register This register contains the polynomial for the CRC calculation. The CRC polynomial (0x0007) is the reset value of this register. Another polynomial can be configured as required.
  [then]


  [ifdef] SPI3_SPIx_RXCRCR_DEF
    \
    \ @brief SPI Rx CRC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_RXCRC                     \ [0x00 : 16] Rx CRC register When CRC calculation is enabled, the RXCRC[15:0] bits contain the computed CRC value of the subsequently received bytes. This register is reset when the CRCEN bit in SPIx_CR1 register is written to 1. The CRC is calculated serially using the polynomial programmed in the SPIx_CRCPR register. Only the 8 LSB bits are considered when the CRC frame format is set to be 8-bit length (CRCL bit in the SPIx_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit CRC frame format is selected (CRCL bit in the SPIx_CR1 register is set). CRC calculation is done based on any CRC16 standard. Note: A read to this register when the BSY Flag is set could return an incorrect value. Note: These bits are not used in I<sup>2</sup>S mode.
  [then]


  [ifdef] SPI3_SPIx_TXCRCR_DEF
    \
    \ @brief SPI Tx CRC register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_TXCRC                     \ [0x00 : 16] Tx CRC register When CRC calculation is enabled, the TXCRC[7:0] bits contain the computed CRC value of the subsequently transmitted bytes. This register is reset when the CRCEN bit of SPIx_CR1 is written to 1. The CRC is calculated serially using the polynomial programmed in the SPIx_CRCPR register. Only the 8 LSB bits are considered when the CRC frame format is set to be 8-bit length (CRCL bit in the SPIx_CR1 is cleared). CRC calculation is done based on any CRC8 standard. The entire 16-bits of this register are considered when a 16-bit CRC frame format is selected (CRCL bit in the SPIx_CR1 register is set). CRC calculation is done based on any CRC16 standard. Note: A read to this register when the BSY flag is set could return an incorrect value. Note: These bits are not used in I<sup>2</sup>S mode.
  [then]


  [ifdef] SPI3_SPIx_I2SCFGR_DEF
    \
    \ @brief SPIx_I2S configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SPI3_CHLEN                     \ [0x00] Channel length (number of bits per audio channel) The bit write operation has a meaning only if DATLEN = 00 otherwise the channel length is fixed to 32-bit by hardware whatever the value filled in. Note: For correct operation, this bit should be configured when the I2S is disabled. Note: It is not used in SPI mode.
    $01 constant SPI3_DATLEN                    \ [0x01 : 2] Data length to be transferred Note: For correct operation, these bits should be configured when the I2S is disabled. Note: They are not used in SPI mode.
    $03 constant SPI3_CKPOL                     \ [0x03] Inactive state clock polarity Note: For correct operation, this bit should be configured when the I2S is disabled. Note: It is not used in SPI mode. Note: The bit CKPOL does not affect the CK edge sensitivity used to receive or transmit the SD and WS signals.
    $04 constant SPI3_I2SSTD                    \ [0x04 : 2] I2S standard selection For more details on I<sup>2</sup>S standards, refer to Section 27.7.2 on page 805 Note: For correct operation, these bits should be configured when the I2S is disabled. Note: They are not used in SPI mode.
    $07 constant SPI3_PCMSYNC                   \ [0x07] PCM frame synchronization Note: This bit has a meaning only if I2SSTD = 11 (PCM standard is used). Note: It is not used in SPI mode.
    $08 constant SPI3_I2SCFG                    \ [0x08 : 2] I2S configuration mode Note: These bits should be configured when the I2S is disabled. Note: They are not used in SPI mode.
    $0a constant SPI3_I2SE                      \ [0x0a] I2S enable Note: This bit is not used in SPI mode.
    $0b constant SPI3_I2SMOD                    \ [0x0b] I2S mode selection Note: This bit should be configured when the SPI is disabled.
    $0c constant SPI3_ASTRTEN                   \ [0x0c] Asynchronous start enable. When the I2S is enabled in slave mode, the hardware starts the transfer when the I2S clock is received and an appropriate transition is detected on the WS signal. When the I2S is enabled in slave mode, the hardware starts the transfer when the I2S clock is received and the appropriate level is detected on the WS signal. Note: The appropriate transition is a falling edge on WS signal when I<sup>2</sup>S Philips Standard is used, or a rising edge for other standards. Note: The appropriate level is a low level on WS signal when I<sup>2</sup>S Philips Standard is used, or a high level for other standards. Note: Please refer to Section 27.7.3: Start-up description for additional information.
  [then]


  [ifdef] SPI3_SPIx_I2SPR_DEF
    \
    \ @brief SPIx_I2S prescaler register
    \ Address offset: 0x20
    \ Reset value: 0x    NULL
    \
    $00 constant SPI3_I2SDIV                    \ [0x00 : 8] I2S linear prescaler I2SDIV [7:0] = 0 or I2SDIV [7:0] = 1 are forbidden values. Refer to Section 27.7.3 on page 812. Note: These bits should be configured when the I2S is disabled. They are used only when the I2S is in master mode. Note: They are not used in SPI mode.
    $08 constant SPI3_ODD                       \ [0x08] Odd factor for the prescaler Refer to Section 27.7.3 on page 812. Note: This bit should be configured when the I2S is disabled. It is used only when the I2S is in master mode. Note: It is not used in SPI mode.
    $09 constant SPI3_MCKOE                     \ [0x09] Master clock output enable Note: This bit should be configured when the I2S is disabled. It is used only when the I2S is in master mode. Note: It is not used in SPI mode.
  [then]

  \
  \ @brief SPI address block description
  \
  $00 constant SPI3_SPIX_CR1            \ SPI control register 1
  $04 constant SPI3_SPIX_CR2            \ SPI control register 2
  $08 constant SPI3_SPIX_SR             \ SPI status register
  $0C constant SPI3_SPIX_DR             \ SPI data register
  $10 constant SPI3_SPIX_CRCPR          \ SPI CRC polynomial register
  $14 constant SPI3_SPIX_RXCRCR         \ SPI Rx CRC register
  $18 constant SPI3_SPIX_TXCRCR         \ SPI Tx CRC register
  $1C constant SPI3_SPIX_I2SCFGR        \ SPIx_I2S configuration register
  $20 constant SPI3_SPIX_I2SPR          \ SPIx_I2S prescaler register

: SPI3_DEF ; [then]
