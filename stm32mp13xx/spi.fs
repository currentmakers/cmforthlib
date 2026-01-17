\
\ @file spi.fs
\ @brief SPI1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI_DEF

  [ifdef] SPI_SPI_CR1_DEF
    \
    \ @brief SPI/I2S control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI_SPE                        \ [0x00] serial peripheral enable This bit is set by and cleared by software. When SPE=1, the SPI data transfer is enabled, the configuration registers SPI_CFG1, SPI_CFG2, CRCPOLY and UDRDR and the IOLOCK bit in SPI_CR1 are write protected. They can be changed only when SPE=0. When SPE=0 any SPI operation is stopped and disabled, all the not cleared requests with enabled interrupt stay pending and propagates the spi_plck clock request, the SS output is deactivated at master, internal state machine is reseted, all the FIFOs content is flushed, CRC calculation initialized, receive data register is read zero. SPE is cleared and cannot be set when MODF error flag is active.
    $08 constant SPI_MASRX                      \ [0x08] master automatic SUSP in Receive mode This bit is set and cleared by software to control continuous SPI transfer in master receiver mode and automatic management in order to avoid overrun condition. When SPI communication is suspended by hardware automatically, it could happen that few bits of next frame are already clocked out due to internal synchronization delay. That is why the automatic suspension is not quite reliable when size of data drops below 8 bits. In this case, a safe suspension can be achieved by combination with delay inserted between data frames applied when MIDI parameter keeps a non zero value; sum of data size and the interleaved SPI cycles must always produce interval at length of 8 SPI clock periods at minimum. After software clearing of the SUSP bit, the communication resumes and continues by subsequent bits transaction without any next constraint. Prior the SUSP bit is cleared, the user must release the RxFIFO space as much as possible by reading out all the data packets available at RxFIFO based on the RXP flag indication to prevent any subsequent suspension.
    $09 constant SPI_CSTART                     \ [0x09] master transfer start This bit is set by software to start an SPI or I2S/PCM communication. In SPI mode, it is cleared by hardware when End Of Transfer (EOT) flag is set or when a transaction suspend request is accepted. In I2S/PCM mode, it is also cleared by hardware as described in the section stop sequence. In SPI mode, the bit is taken into account at master mode only. If transmission is enabled, communication starts or continues only if any data is available in the transmission FIFO.
    $0a constant SPI_CSUSP                      \ [0x0a] master suspend request This bit reads as zero. In master mode, when this bit is set by software, CSTART bit is reset at the end of the current frame and SPI communication is suspended. The user has to check SUSP flag to check end of the frame transaction. The master mode communication must be suspended (using this bit or keeping TXDR empty) before disabling the SPI or going to low-power mode. After software suspension, the SUSP flag has to be cleared and the SPI disabled and re-enabled before any next transaction starts.
    $0b constant SPI_HDDIR                      \ [0x0b] Rx/Tx direction at Half-duplex mode In Half-Duplex configuration the HDDIR bit establishes the Rx/Tx direction of the data transfer. This bit is ignored in Full-Duplex or any Simplex configuration.
    $0c constant SPI_SSI                        \ [0x0c] internal SS signal input level This bit has an effect only when the SSM bit is set. The value of this bit is forced onto the peripheral SS input and the I/O value of the SS pin is ignored.
    $0d constant SPI_CRC33_17                   \ [0x0d] 32-bit CRC polynomial configuration
    $0e constant SPI_RCRCINI                    \ [0x0e] CRC calculation initialization pattern control for receiver
    $0f constant SPI_TCRCINI                    \ [0x0f] CRC calculation initialization pattern control for transmitter
    $10 constant SPI_IOLOCK                     \ [0x10] locking the AF configuration of associated IOs This bit is set by software and cleared by hardware whenever SPE bit is changed from 1 to 0. When this bit is set, the SPI_CFG2 register content cannot be modified. This bit can be set when SPI is disabled only else it is write protected. It is cleared and cannot be set when the MODF bit is set.
  [then]


  [ifdef] SPI_SPI_CR2_DEF
    \
    \ @brief SPI control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TSIZE                      \ [0x00 : 16] number of data at current transfer When these bits are changed by software, the SPI must be disabled. The field can be updated by hardware optionally, too, to be reloaded by the TSER value if applicable. Endless transaction is initialized when CSTART is set while zero value is stored at TSIZE. TSIZE cannot be set to 0xFFFF value when CRC is enabled.
    $10 constant SPI_TSER                       \ [0x10 : 16] number of data transfer extension to be reload into TSIZE just when a previous number of data stored at TSIZE is transacted This register can be set by software when its content is cleared only. It is cleared by hardware once TSIZE reload is done. The TSER value must be programmed in advance before CTSIZE counter reaches zero otherwise the reload is not taken into account and traffic terminates with normal EOT event.
  [then]


  [ifdef] SPI_SPI_CFG1_DEF
    \
    \ @brief SPI configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00070007
    \
    $00 constant SPI_DSIZE                      \ [0x00 : 5] number of bits in at single SPI data frame ..... Note: The most significant bit at DSIZE bit field is reserved at the peripheral instances where data size is limited to 16-bit.
    $05 constant SPI_FTHLV                      \ [0x05 : 4] FIFO threshold level Defines number of data frames at single data packet. The size of the packet must not exceed 1/2 of FIFO space. SPI interface is more efficient if configured packet sizes are aligned with data register access parallelism: If SPI data register is accessed as a 16-bit register and DSIZE<=8bit, better to select FTHLV=2, 4, 6 etc, If SPI data register is accessed as a 32-bit register and DSIZE>8bit, better to select FTHLV=2, 4, 6 etc, while if DSIZE<=8bit, better to select FTHLV=4, 8, 12 etc
    $09 constant SPI_UDRCFG                     \ [0x09 : 2] behavior of slave transmitter at underrun condition When slave is configured at transmit only mode (COMM[1:0]=01), slave repeats all zeros pattern at UDRCFG[1:0]=01 setting. For more details see underrun condition.
    $0b constant SPI_UDRDET                     \ [0x0b : 2] detection of underrun condition at slave transmitter For more details see underrun condition.
    $0e constant SPI_RXDMAEN                    \ [0x0e] Rx DMA stream enable
    $0f constant SPI_TXDMAEN                    \ [0x0f] Tx DMA stream enable
    $10 constant SPI_CRCSIZE                    \ [0x10 : 5] length of CRC frame to be transacted and compared Most significant bits are taken into account from polynomial calculation when CRC result is transacted or compared. The length of the polynomial is not affected by this setting. ..... The value must be set equal or multiply of data size (DSIZE[4:0]). Its maximum size cannot exceed the DSIZE maximum at the instance. Note: If crc calculation is disabled by CRCEN=0, the CRCSIZE field must be kept at its default setting. Note: The most significant bit at CRCSIZE bit field is reserved at the peripheral instances where the data size is limited to 16-bit.
    $16 constant SPI_CRCEN                      \ [0x16] hardware CRC computation enable
    $1c constant SPI_MBR                        \ [0x1c : 3] master baud rate Note: MBR setting is considered at slave working at TI mode, too (see mode).
  [then]


  [ifdef] SPI_SPI_CFG2_DEF
    \
    \ @brief SPI configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_MSSI                       \ [0x00 : 4] master SS idleness Specifies an extra delay, expressed in number of SPI clock cycle periods, inserted additionally between active edge of SS and first data of a session start in master mode when SSOE is enabled. ... Note: This feature is not supported in TI mode.
    $04 constant SPI_MIDI                       \ [0x04 : 4] master Inter-Data Idleness Specifies minimum time delay (expressed in SPI clock cycles periods) inserted between two consecutive data frames in master mode. ... Note: This feature is not supported in TI mode.
    $0f constant SPI_IOSWP                      \ [0x0f] swap functionality of MISO and MOSI pins When this bit is set, the function of MISO and MOSI pins alternate functions are inverted. Original MISO pin becomes MOSI and original MOSI pin becomes MISO. Note: This bit can be also used in PCM and I2S modes.
    $11 constant SPI_COMM                       \ [0x11 : 2] SPI communication mode
    $13 constant SPI_SP                         \ [0x13 : 3] Serial protocol others: Reserved, must not be used
    $16 constant SPI_MASTER                     \ [0x16] SPI master
    $17 constant SPI_LSBFRST                    \ [0x17] data frame format Note: This bit can be also used in PCM and I2S modes.
    $18 constant SPI_CPHA                       \ [0x18] clock phase
    $19 constant SPI_CPOL                       \ [0x19] clock polarity
    $1a constant SPI_SSM                        \ [0x1a] software management of SS signal input When master uses hardware SS output (SSM=0 and SSOE=1), the SS signal input is forced to non active state internally to prevent master mode fault error.
    $1c constant SPI_SSIOP                      \ [0x1c] SS input/output polarity
    $1d constant SPI_SSOE                       \ [0x1d] SS output enable This bit is taken into account at master mode only
    $1e constant SPI_SSOM                       \ [0x1e] SS output management in master mode This bit is taken into account in master mode when SSOE is enabled. It allows to configure SS output between two consecutive data transfers.
    $1f constant SPI_AFCNTR                     \ [0x1f] alternate function GPIOs control This bit is taken into account when SPE=0 only When SPI master has to be disabled temporary for a specific configuration reason (e.g. CRC reset, CPHA or HDDIR change) setting this bit prevents any glitches on the associated outputs configured at alternate function mode by keeping them forced at state corresponding the current SPI configuration. This bit must be never used at slave mode as any slave transmitter must not force its MISO output once the SPI is disabled. Note: This bit can be also used in PCM and I2S modes.
  [then]


  [ifdef] SPI_SPI_IER_DEF
    \
    \ @brief SPI/I2S interrupt enable register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXPIE                      \ [0x00] RXP Interrupt Enable
    $01 constant SPI_TXPIE                      \ [0x01] TXP interrupt enable TXPIE is set by software and cleared by TXTF flag set event.
    $02 constant SPI_DXPIE                      \ [0x02] DXP interrupt enabled DXPIE is set by software and cleared by TXTF flag set event.
    $03 constant SPI_EOTIE                      \ [0x03] EOT, SUSP and TXC interrupt enable
    $04 constant SPI_TXTFIE                     \ [0x04] TXTFIE interrupt enable
    $05 constant SPI_UDRIE                      \ [0x05] UDR interrupt enable
    $06 constant SPI_OVRIE                      \ [0x06] OVR interrupt enable
    $07 constant SPI_CRCEIE                     \ [0x07] CRC error interrupt enable
    $08 constant SPI_TIFREIE                    \ [0x08] TIFRE interrupt enable
    $09 constant SPI_MODFIE                     \ [0x09] mode fault interrupt enable
    $0a constant SPI_TSERFIE                    \ [0x0a] additional number of transactions reload interrupt enable
  [then]


  [ifdef] SPI_SPI_SR_DEF
    \
    \ @brief SPI/I2S status register
    \ Address offset: 0x14
    \ Reset value: 0x00001002
    \
    $00 constant SPI_RXP                        \ [0x00] Rx-packet available RXP flag is changed by hardware. It monitors number of overall data currently available at RxFIFO if SPI is enabled. It has to be checked once a data packet is completely read out from RxFIFO.
    $01 constant SPI_TXP                        \ [0x01] Tx-packet space available TXP flag is changed by hardware. It monitors overall space currently available at TxFIFO if SPI is enabled. It has to be checked once a complete data packet is stored at TxFIFO.
    $02 constant SPI_DXP                        \ [0x02] duplex packet The DXP flag is set whenever both TXP and RXP flags are set regardless the SPI mode.
    $03 constant SPI_EOT                        \ [0x03] end of transfer EOT is set by hardware as soon as a full transfer is complete, that is when TSIZE number of data have been transmitted and/or received on the SPI. EOT is cleared by software write 1 to EOTC bit at SPI_IFCR. EOT flag triggers an interrupt if EOTIE bit is set. If DXP flag is used until TXTF flag is set and DXPIE is cleared, EOT can be used to download the last packets contained into RxFIFO in one-shot. In master, EOT event terminates the data transaction and handles SS output optionally. When CRC is applied, the EOT event is extended over the CRC frame transaction.
    $04 constant SPI_TXTF                       \ [0x04] transmission transfer filled TXTF is set by hardware as soon as all of the data packets in a transfer have been submitted for transmission by application software or DMA, that is when TSIZE number of data have been pushed into the TxFIFO. This bit is cleared by software write 1 to TXTFC bit at SPI_IFCR TXTF flag triggers an interrupt if TXTFIE bit is set. TXTF setting clears the TXIE and DXPIE masks so to off-load application software from calculating when to disable TXP and DXP interrupts.
    $05 constant SPI_UDR                        \ [0x05] underrun at slave transmission mode This bit is cleared by write 1 to UDRC bit at SPI_IFCR Note: UDR flag applies to Slave mode only
    $06 constant SPI_OVR                        \ [0x06] overrun This bit is cleared by write 1 to OVRC bit at SPI_IFCR
    $07 constant SPI_CRCE                       \ [0x07] CRC error This bit is cleared by write 1 to CRCEC bit at SPI_IFCR
    $08 constant SPI_TIFRE                      \ [0x08] TI frame format error This bit is cleared by write 1 to TIFREC bit at SPI_IFCR
    $09 constant SPI_MODF                       \ [0x09] mode fault This bit is cleared by write 1 to MODFC bit at SPI_IFCR. When MODF is set, the SPE and IOLOCK bits at the SPI_CR1 register are reset and their setting is blocked.
    $0a constant SPI_TSERF                      \ [0x0a] additional number of SPI data to be transacted was reload This bit is cleared by write 1 to TSERFC bit at SPI_IFCR or by writing the TSER[15:0] (SPI_CR2) register
    $0b constant SPI_SUSP                       \ [0x0b] suspension status In Master mode, SUSP is set by hardware when a CSUSP request is done, either as soon as the current frame is completed after CSUSP request is done or at master automatic suspend receive mode (MASRX bit is set at SPI_CR1 register) on RxFIFO full condition. SUSP generates an interrupt when EOTIE is set. This bit has to be cleared prior SPI is disabled by write 1 to SUSPC bit at SPI_IFCR
    $0c constant SPI_TXC                        \ [0x0c] TxFIFO transmission complete The flag behavior depends on TSIZE setting. When TSIZE=0 the TXC is changed by hardware exclusively and it raises each time the TxFIFO becomes empty and there is no activity on the bus. If TSIZE <>0 there is no specific reason to monitor TXC as it just copies the EOT flag value including its software clearing. The TXC generates an interrupt when EOTIE is set.
    $0d constant SPI_RXPLVL                     \ [0x0d : 2] RxFIFO packing leveL When RXWNE=0 and data size is set up to 16-bit, the value gives number of remaining data frames persisting at RxFIFO. (*) optional count when the data size is set up to 8-bit. When the frame size is greater than 16-bit, these bits read as 00. In consequence, the single data frame received at the FIFO cannot be detected neither by RWNE nor by RXPLVL bits if data size is set from 17 to 24 bits. The user then must apply other methods like TSIZE>0 or FTHLV=0.
    $0f constant SPI_RXWNE                      \ [0x0f] RxFIFO word not empty Note: This bit value does not depend on DSIZE setting and keeps together with RXPLVL[1:0] information about RxFIFO occupancy by residual data.
    $10 constant SPI_CTSIZE                     \ [0x10 : 16] number of data frames remaining in current TSIZE session The value is not quite reliable when traffic is ongoing on bus and at LP mode too.
  [then]


  [ifdef] SPI_SPI_IFCR_DEF
    \
    \ @brief SPI/I2S interrupt/status flags clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant SPI_EOTC                       \ [0x03] end of transfer flag clear Writing a 1 into this bit clears EOT flag in the SPI_SR register
    $04 constant SPI_TXTFC                      \ [0x04] transmission Transfer Filled flag clear Writing a 1 into this bit clears TXTF flag in the SPI_SR register
    $05 constant SPI_UDRC                       \ [0x05] underrun flag clear Writing a 1 into this bit clears UDR flag in the SPI_SR register
    $06 constant SPI_OVRC                       \ [0x06] overrun flag clear Writing a 1 into this bit clears OVR flag in the SPI_SR register
    $07 constant SPI_CRCEC                      \ [0x07] CRC error flag clear Writing a 1 into this bit clears CRCE flag in the SPI_SR register
    $08 constant SPI_TIFREC                     \ [0x08] TI frame format error flag clear Writing a 1 into this bit clears TIFRE flag in the SPI_SR register
    $09 constant SPI_MODFC                      \ [0x09] mode fault flag clear Writing a 1 into this bit clears MODF flag in the SPI_SR register
    $0a constant SPI_TSERFC                     \ [0x0a] TSERFC flag clear Writing a 1 into this bit clears TSERF flag in the SPI_SR register Note: TSERF is also reset by writing the TSER[15:0] (SPI_CR2) register
    $0b constant SPI_SUSPC                      \ [0x0b] SUSPend flag clear Writing a 1 into this bit clears SUSP flag in the SPI_SR register
  [then]


  [ifdef] SPI_SPI_TXDR_DEF
    \
    \ @brief SPI/I2S transmit data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXDR                       \ [0x00 : 32] transmit data register The register serves as an interface with TxFIFO. A write to it accesses TxFIFO. Note: data is always right-aligned. Unused bits are ignored when writing to the register, and read as zero when the register is read. Note: DR can be accessed byte-wise (8-bit access): in this case only one data-byte is written by single access. halfword-wise (16 bit access) in this case 2 data-bytes or 1 halfword-data can be written by single access. word-wise (32 bit access). In this case 4 data-bytes or 2 halfword-data or word-data can be written by single access. Write access of this register less than the configured data size is forbidden.
  [then]


  [ifdef] SPI_SPI_RXDR_DEF
    \
    \ @brief SPI/I2S receive data register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXDR                       \ [0x00 : 32] receive data register The register serves as an interface with RxFIFO. When it is read, RxFIFO is accessed. Note: Data is always right-aligned. Unused bits are read as zero when the register is read. Writing to the register is ignored. Note: DR can be accessed byte-wise (8-bit access): in this case only one data-byte is read by single access. halfword-wise (16 bit access) in this case 2 data-bytes or 1 halfword-data can be read by single access word-wise (32 bit access). In this case 4 data-bytes or 2 halfword-data or word-data can be read by single access. Read access of this register less than the configured data size is forbidden.
  [then]


  [ifdef] SPI_SPI_CRCPOLY_DEF
    \
    \ @brief SPI polynomial register
    \ Address offset: 0x40
    \ Reset value: 0x00000107
    \
    $00 constant SPI_CRCPOLY                    \ [0x00 : 32] CRC polynomial register This register contains the polynomial for the CRC calculation. The default 9-bit polynomial setting 0x107 corresponds to default 8-bit setting of DSIZE. It is compatible with setting 0x07 used at some other ST products with fixed length of the polynomial string where the most significant bit of the string is always kept hidden. Length of the polynomial is given by the most significant bit of the value stored at this register. It has to be set greater than DSIZE. CRC33_17 bit has to be set additionally with CRCPOLY register when DSIZE is configured to maximum 32-bit or 16-bit size and CRC is enabled (to keep polynomial length grater than data size). Bits 31-16 are reserved at the peripheral instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored.
  [then]


  [ifdef] SPI_SPI_TXCRC_DEF
    \
    \ @brief SPI transmitter CRC register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXCRC                      \ [0x00 : 32] CRC register for transmitter When CRC calculation is enabled, the TXCRC[31:0] bits contain the computed CRC value of the subsequently transmitted bytes. CRC calculation is initialized when the CRCEN bit of SPI_CR1 is written to 1 or when a data block is transacted completely. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPOLY register. The number of bits considered at calculation depends on SPI_CRCPOLY register and CRCSIZE bits settings at SPI_CFG1 register. Note: A read to this register when the communication is ongoing could return an incorrect value. Not used for the I2S mode. Bits 31-16 are reserved at the peripheral instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored. Note: The configuration of CRCSIZE bit field is not taken into account when the content of this register is read by software. No masking is applied for unused bits at this case.
  [then]


  [ifdef] SPI_SPI_RXCRC_DEF
    \
    \ @brief SPI receiver CRC register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SPI_RXCRC                      \ [0x00 : 32] CRC register for receiver When CRC calculation is enabled, the RXCRC[31:0] bits contain the computed CRC value of the subsequently received bytes. CRC calculation is initialized when the CRCEN bit of SPI_CR1 is written to 1 or when a data block is transacted completely. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPOLY register. The number of bits considered at calculation depends on SPI_CRCPOLY register and CRCSIZE bits settings at SPI_CFG1 register. Note: A read to this register when the communication is ongoing could return an incorrect value. Not used for the I2S mode. Bits 31-16 are reserved at the peripheral instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored. Note: The configuration of CRCSIZE bit field is not taken into account when the content of this register is read by software. No masking is applied for unused bits at this case.
  [then]


  [ifdef] SPI_SPI_UDRDR_DEF
    \
    \ @brief SPI underrun data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant SPI_UDRDR                      \ [0x00 : 32] data at slave underrun condition The register is taken into account at slave mode and at underrun condition only. The number of bits considered depends on DSIZE bit settings at SPI_CFG1 register. Underrun condition handling depends on setting if UDRDET and UDRCFG bits at SPI_CFG1 register. Bits 31-16 are reserved at the peripheral instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored.
  [then]


  [ifdef] SPI_SPI_I2SCFGR_DEF
    \
    \ @brief SPI/I2S configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SPI_I2SMOD                     \ [0x00] I2S mode selection
    $01 constant SPI_I2SCFG                     \ [0x01 : 3] I2S configuration mode others, not used
    $04 constant SPI_I2SSTD                     \ [0x04 : 2] I2S standard selection For more details on I2S standards, refer to
    $07 constant SPI_PCMSYNC                    \ [0x07] PCM frame synchronization
    $08 constant SPI_DATLEN                     \ [0x08 : 2] data length to be transferred
    $0a constant SPI_CHLEN                      \ [0x0a] channel length (number of bits per audio channel) The bit write operation has a meaning only if DATLEN = 00 otherwise the channel length is fixed to 32-bit by hardware whatever the value filled in.
    $0b constant SPI_CKPOL                      \ [0x0b] serial audio clock polarity
    $0c constant SPI_FIXCH                      \ [0x0c] fixed channel length in slave
    $0d constant SPI_WSINV                      \ [0x0d] Word select inversion This bit is used to invert the default polarity of WS signal. WS is low. In PCM mode the start of frame is indicated by a rising edge. WS is high. In PCM mode the start of frame is indicated by a falling edge.
    $0e constant SPI_DATFMT                     \ [0x0e] data format
    $10 constant SPI_I2SDIV                     \ [0x10 : 8] I2S linear prescaler I2SDIV can take any values except the value 1, when ODD is also equal to 1. Refer to for details
    $18 constant SPI_ODD                        \ [0x18] odd factor for the prescaler Refer to for details
    $19 constant SPI_MCKOE                      \ [0x19] master clock output enable
  [then]


  [ifdef] SPI_SPI_I2S_HWCFGR_DEF
    \
    \ @brief SPI/I2S hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant SPI_TXFCFG                     \ [0x00 : 4] TxFIFO size 0002: the FIFO size is 4 bytes 0003: the FIFO size is 8 bytes 0004: the FIFO size is 16 bytes 0005: the FIFO size is 32 bytes All the other combinations are reserved.
    $04 constant SPI_RXFCFG                     \ [0x04 : 4] RxFIFO size 0002: the FIFO size is 4 bytes 0003: the FIFO size is 8 bytes 0004: the FIFO size is 16 bytes 0005: the FIFO size is 32 bytes All the other combinations are reserved.
    $08 constant SPI_CRCCFG                     \ [0x08 : 4] CRC configuration for SPI All the other combinations are reserved.
    $0c constant SPI_I2SCFG                     \ [0x0c : 4] I2S configuration All the other combinations are reserved.
    $10 constant SPI_DSCFG                      \ [0x10 : 4] SPI data size configuration All the other combinations are reserved.
  [then]


  [ifdef] SPI_SPI_VERR_DEF
    \
    \ @brief SPI/I2S version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000011
    \
    $00 constant SPI_MINREV                     \ [0x00 : 4] minor revision of the IP.
    $04 constant SPI_MAJREV                     \ [0x04 : 4] major revision of the IP.
  [then]


  [ifdef] SPI_SPI_IPIDR_DEF
    \
    \ @brief SPI/I2S identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00130022
    \
    $00 constant SPI_ID                         \ [0x00 : 32] IP identification MCD identification code which identifies the IP.
  [then]


  [ifdef] SPI_SPI_SIDR_DEF
    \
    \ @brief SPI/I2S size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant SPI_SID                        \ [0x00 : 32] size identification Bits[31:8]: fixed code 0xA3C5DD0 Bits[7:0]: range of address decoding boundary All the other combination are reserved.
  [then]

  \
  \ @brief SPI1
  \
  $00 constant SPI_SPI_CR1              \ SPI/I2S control register 1
  $04 constant SPI_SPI_CR2              \ SPI control register 2
  $08 constant SPI_SPI_CFG1             \ SPI configuration register 1
  $0C constant SPI_SPI_CFG2             \ SPI configuration register 2
  $10 constant SPI_SPI_IER              \ SPI/I2S interrupt enable register
  $14 constant SPI_SPI_SR               \ SPI/I2S status register
  $18 constant SPI_SPI_IFCR             \ SPI/I2S interrupt/status flags clear register
  $20 constant SPI_SPI_TXDR             \ SPI/I2S transmit data register
  $30 constant SPI_SPI_RXDR             \ SPI/I2S receive data register
  $40 constant SPI_SPI_CRCPOLY          \ SPI polynomial register
  $44 constant SPI_SPI_TXCRC            \ SPI transmitter CRC register
  $48 constant SPI_SPI_RXCRC            \ SPI receiver CRC register
  $4C constant SPI_SPI_UDRDR            \ SPI underrun data register
  $50 constant SPI_SPI_I2SCFGR          \ SPI/I2S configuration register
  $3F0 constant SPI_SPI_I2S_HWCFGR      \ SPI/I2S hardware configuration register
  $3F4 constant SPI_SPI_VERR            \ SPI/I2S version register
  $3F8 constant SPI_SPI_IPIDR           \ SPI/I2S identification register
  $3FC constant SPI_SPI_SIDR            \ SPI/I2S size identification register

: SPI_DEF ; [then]
