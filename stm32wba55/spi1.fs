\
\ @file spi1.fs
\ @brief Serial peripheral interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPI1_DEF

  [ifdef] SPI1_SPI_CR1_DEF
    \
    \ @brief SPI control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_SPE                       \ [0x00] serial peripheral enable This bit is set by and cleared by software. When SPE = 1, SPI data transfer is enabled, SPI_CFG1 and SPI_CFG2 configuration registers, CRCPOLY, UDRDR, part of SPI_AUTOCR register and IOLOCK bit in the SPI_CR1 register are write protected. They can be changed only when SPE = 0. When SPE = 0 any SPI operation is stopped and disabled, all the pending requests of the events with enabled interrupt are blocked except the MODF interrupt request (but their pending still propagates the request of the spi_plck clock), the SS output is deactivated at master, the RDY signal keeps not ready status at slave, the internal state machine is reseted, all the FIFOs content is flushed, CRC calculation initialized, receive data register is read zero. SPE is cleared and cannot be set when MODF error flag is active.
    $08 constant SPI1_MASRX                     \ [0x08] master automatic suspension in Receive mode This bit is set and cleared by software to control continuous SPI transfer in master receiver mode and automatic management in order to avoid overrun condition. When SPI communication is suspended by hardware automatically, it could happen that few bits of next frame are already clocked out due to internal synchronization delay. This is why, the automatic suspension is not quite reliable when size of data drops below 8 bits. In this case, a safe suspension can be achieved by combination with delay inserted between data frames applied when MIDI parameter keeps a non zero value; sum of data size and the interleaved SPI cycles should always produce interval at length of 8 SPI clock periods at minimum. After software clearing of the SUSP bit, the communication resumes and continues by subsequent bits transaction without any next constraint. Prior the SUSP bit is cleared, the user must release the RxFIFO space as much as possible by reading out all the data packets available at RxFIFO based on the RXP flag indication to prevent any subsequent suspension.
    $09 constant SPI1_CSTART                    \ [0x09] master transfer start This bit can be set by software if SPI is enabled only to start an SPI communication. it is cleared by hardware when end of transfer (EOT) flag is set or when a transaction suspend request is accepted. In SPI mode, the bit is taken into account at master mode only. If transmission is enabled, communication starts or continues only if any data is available in the transmission FIFO.
    $0a constant SPI1_CSUSP                     \ [0x0a] master suspend request This bit reads as zero. In Master mode, when this bit is set by software, the CSTART bit is reset at the end of the current frame and communication is suspended. The user has to check SUSP flag to check end of the frame transaction. The Master mode communication must be suspended (using this bit or keeping TXDR empty) before going to Low-power mode. Can be used in SPI or I2S mode. After software suspension, SUSP flag must be cleared and SPI disabled and re-enabled before the next transaction starts.
    $0b constant SPI1_HDDIR                     \ [0x0b] Rx/Tx direction at Half-duplex mode In Half-Duplex configuration the HDDIR bit establishes the Rx/Tx direction of the data transfer. This bit is ignored in Full-Duplex or any Simplex configuration.
    $0c constant SPI1_SSI                       \ [0x0c] internal SS signal input level This bit has an effect only when the SSM bit is set. The value of this bit is forced onto the peripheral SS input internally and the I/O value of the SS pin is ignored.
    $0d constant SPI1_CRC33_17                  \ [0x0d] 32-bit CRC polynomial configuration
    $0e constant SPI1_RCRCINI                   \ [0x0e] CRC calculation initialization pattern control for receiver
    $0f constant SPI1_TCRCINI                   \ [0x0f] CRC calculation initialization pattern control for transmitter
    $10 constant SPI1_IOLOCK                    \ [0x10] locking the AF configuration of associated I/Os This bit is set by software and cleared by hardware whenever the SPE bit is changed from 1 to 0. When this bit is set, SPI_CFG2 register content cannot be modified. This bit can be set when SPI is disabled only else it is write protected. It is cleared and cannot be set when MODF bit is set.
  [then]


  [ifdef] SPI1_SPI_CR2_DEF
    \
    \ @brief SPI control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_TSIZE                     \ [0x00 : 16] number of data at current transfer When these bits are changed by software, the SPI must be disabled. Endless transaction is initialized when CSTART is set while zero value is stored at TSIZE. TSIZE cannot be set to 0xFFFF respective 0x3FFF value when CRC is enabled. Note: TSIZE[15:10] bits are reserved at limited feature set instances and must be kept at reset value.
  [then]


  [ifdef] SPI1_SPI_CFG1_DEF
    \
    \ @brief SPI configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00070007
    \
    $00 constant SPI1_DSIZE                     \ [0x00 : 5] number of bits in at single SPI data frame ..... Maximum data size can be limited up to 16-bits at some instances. At instances with limited set of features, DSIZE2:0] bits are reserved and must be kept at reset state. DSIZE[4:3] bits then control next settings of data size: 00xxx: 8-bits 01xxx: 16-bits 10xxx: 24-bits Note: 11xxx: 32-bits.
    $05 constant SPI1_FTHLV                     \ [0x05 : 4] FIFO threshold level Defines number of data frames at single data packet. Size of the packet should not exceed 1/2 of FIFO space. SPI interface is more efficient if configured packet sizes are aligned with data register access parallelism: If SPI data register is accessed as a 16-bit register and DSIZE less than or equal 8 bit, better to select FTHLV = 2, 4, 6. If SPI data register is accessed as a 32-bit register and DSIZE 8 bit, better to select FTHLV = 2, 4, 6, while if DSIZE less than or equal 8bit, better to select FTHLV = 4, 8, 12. Note: FTHLV[3:2] bits are reserved at instances with limited set of features
    $09 constant SPI1_UDRCFG                    \ [0x09] behavior of slave transmitter at underrun condition For more details see Figure977: Optional configurations of slave detecting underrun condition.
    $0e constant SPI1_RXDMAEN                   \ [0x0e] Rx DMA stream enable
    $0f constant SPI1_TXDMAEN                   \ [0x0f] Tx DMA stream enable
    $10 constant SPI1_CRCSIZE                   \ [0x10 : 5] length of CRC frame to be transacted and compared Most significant bits are taken into account from polynomial calculation when CRC result is transacted or compared. The length of the polynomial is not affected by this setting. ..... The value must be set equal or multiply of data size (DSIZE[4:0]). Its maximum size corresponds to DSIZE maximum at the instance. Note: The most significant bit at CRCSIZE bit field is reserved at the peripheral instances where data size is limited to 16-bit.
    $16 constant SPI1_CRCEN                     \ [0x16] hardware CRC computation enable
    $1c constant SPI1_MBR                       \ [0x1c : 3] master baud rate prescaler setting Note: MBR setting is considered at slave working at TI mode, too (see Section80.5.1: TI mode).
    $1f constant SPI1_BPASS                     \ [0x1f] bypass of the prescaler at master baud rate clock generator
  [then]


  [ifdef] SPI1_SPI_CFG2_DEF
    \
    \ @brief SPI configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_MSSI                      \ [0x00 : 4] Master SS Idleness Specifies an extra delay, expressed in number of SPI clock cycle periods, inserted additionally between active edge of SS opening a session and the beginning of the first data frame of the session in Master mode when SSOE is enabled. ... This feature is not supported in TI mode. Note: To include the delay, the SPI must be disabled and re-enabled between sessions.
    $04 constant SPI1_MIDI                      \ [0x04 : 4] master Inter-Data Idleness Specifies minimum time delay (expressed in SPI clock cycles periods) inserted between two consecutive data frames in Master mode. ... Note: This feature is not supported in TI mode.
    $0d constant SPI1_RDIOM                     \ [0x0d] RDY signal input/output management Note: When DSIZE at the SPI_CFG1 register is configured shorter than 8-bit, the RDIOM bit must be kept at zero.
    $0e constant SPI1_RDIOP                     \ [0x0e] RDY signal input/output polarity
    $0f constant SPI1_IOSWP                     \ [0x0f] swap functionality of MISO and MOSI pins When this bit is set, the function of MISO and MOSI pins alternate functions are inverted. Original MISO pin becomes MOSI and original MOSI pin becomes MISO.
    $11 constant SPI1_COMM                      \ [0x11 : 2] SPI Communication Mode
    $13 constant SPI1_SP                        \ [0x13 : 3] serial protocol others: reserved, must not be used
    $16 constant SPI1_MASTER                    \ [0x16] SPI Master
    $17 constant SPI1_LSBFRST                   \ [0x17] data frame format Note: 1: LSB transmitted first
    $18 constant SPI1_CPHA                      \ [0x18] clock phase
    $19 constant SPI1_CPOL                      \ [0x19] clock polarity
    $1a constant SPI1_SSM                       \ [0x1a] software management of SS signal input When master uses hardware SS output (SSM = 0 and SSOE = 1) the SS signal input is forced to not active state internally to prevent master mode fault error.
    $1c constant SPI1_SSIOP                     \ [0x1c] SS input/output polarity
    $1d constant SPI1_SSOE                      \ [0x1d] SS output enable This bit is taken into account in Master mode only
    $1e constant SPI1_SSOM                      \ [0x1e] SS output management in Master mode This bit is taken into account in Master mode when SSOE is enabled. It allows the SS output to be configured between two consecutive data transfers.
    $1f constant SPI1_AFCNTR                    \ [0x1f] alternate function GPIOs control This bit is taken into account when SPE = 0 only Note: When SPI must be disabled temporary for a specific configuration reason (e.g. CRC reset, CPHA or HDDIR change) setting this bit prevents any glitches on the associated outputs configured at alternate function mode by keeping them forced at state corresponding the current SPI configuration.
  [then]


  [ifdef] SPI1_SPI_IER_DEF
    \
    \ @brief SPI interrupt enable register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_RXPIE                     \ [0x00] RXP interrupt enable
    $01 constant SPI1_TXPIE                     \ [0x01] TXP interrupt enable TXPIE is set by software and cleared by TXTF flag set event.
    $02 constant SPI1_DXPIE                     \ [0x02] DXP interrupt enabled DXPIE is set by software and cleared by TXTF flag set event.
    $03 constant SPI1_EOTIE                     \ [0x03] EOT, SUSP and TXC interrupt enable
    $04 constant SPI1_TXTFIE                    \ [0x04] TXTFIE interrupt enable
    $05 constant SPI1_UDRIE                     \ [0x05] UDR interrupt enable
    $06 constant SPI1_OVRIE                     \ [0x06] OVR interrupt enable
    $07 constant SPI1_CRCEIE                    \ [0x07] CRC error interrupt enable
    $08 constant SPI1_TIFREIE                   \ [0x08] TIFRE interrupt enable
    $09 constant SPI1_MODFIE                    \ [0x09] mode Fault interrupt enable
  [then]


  [ifdef] SPI1_SPI_SR_DEF
    \
    \ @brief SPI status register
    \ Address offset: 0x14
    \ Reset value: 0x00001002
    \
    $00 constant SPI1_RXP                       \ [0x00] Rx-Packet available In I2S mode, it must be interpreted as follow: RxFIFO level is lower than FTHLV In I2S mode, it must be interpreted as follow: RxFIFO level is higher or equal to FTHLV RXP flag is changed by hardware. It monitors number of overall data currently available at RxFIFO if SPI is enabled. It must be checked once a data packet is completely read out from RxFIFO.
    $01 constant SPI1_TXP                       \ [0x01] Tx-Packet space available In I2S mode, it must be interpreted as follow: there is less than FTHLV free locations in the TxFIFO In I2S mode, it must be interpreted as follow: there is FTHLV or more than FTHLV free locations in the TxFIFO TXP flag is changed by hardware. It monitors overall space currently available at TxFIFO no matter if SPI is enabled or not. It must be checked once a complete data packet is stored at TxFIFO.
    $02 constant SPI1_DXP                       \ [0x02] duplex packet DXP flag is set whenever both TXP and RXP flags are set regardless SPI mode.
    $03 constant SPI1_EOT                       \ [0x03] end of transfer EOT is set by hardware as soon as a full transfer is complete, that is when SPI is re-enabled or when TSIZE number of data have been transmitted and/or received on the SPI. EOT is cleared when SPI is re-enabled or by writing 1 to EOTC bit of SPI_IFCR optionally. EOT flag triggers an interrupt if EOTIE bit is set. If DXP flag is used until TXTF flag is set and DXPIE is cleared, EOT can be used to download the last packets contained into RxFIFO in one-shot. In master, EOT event terminates the data transaction and handles SS output optionally. When CRC is applied, the EOT event is extended over the CRC frame transaction. To restart the internal state machine properly, SPI is strongly suggested to be disabled and re-enabled before next transaction starts despite its setting is not changed.
    $04 constant SPI1_TXTF                      \ [0x04] transmission transfer filled TXTF is set by hardware as soon as all of the data packets in a transfer have been submitted for transmission by application software or DMA, that is when TSIZE number of data have been pushed into the TxFIFO. This bit is cleared by software write 1 to TXTFC bit of SPI_IFCR exclusively. TXTF flag triggers an interrupt if TXTFIE bit is set. TXTF setting clears the TXPIE and DXPIE masks so to off-load application software from calculating when to disable TXP and DXP interrupts.
    $05 constant SPI1_UDR                       \ [0x05] underrun This bit is cleared when SPI is re-enabled or by writing 1 to UDRC bit of SPI_IFCR optionally. Note: In SPI mode, the UDR flag applies to Slave mode only. In I2S/PCM mode, (when available) this flag applies to Master and Slave mode
    $06 constant SPI1_OVR                       \ [0x06] overrun This bit is cleared when SPI is re-enabled or by writing 1 to OVRC bit of SPI_IFCR optionally.
    $07 constant SPI1_CRCE                      \ [0x07] CRC error This bit is cleared when SPI is re-enabled or by writing 1 to CRCEC bit of SPI_IFCR optionally.
    $08 constant SPI1_TIFRE                     \ [0x08] TI frame format error This bit is cleared by writing 1 to TIFREC bit of SPI_IFCR exclusively.
    $09 constant SPI1_MODF                      \ [0x09] mode fault This bit is cleared by writing 1 to MODFC bit of SPI_IFCR exclusively.
    $0b constant SPI1_SUSP                      \ [0x0b] suspension status In Master mode, SUSP is set by hardware either as soon as the current frame is completed after CSUSP request is done or at master automatic suspend receive mode (MASRX bit is set at SPI_CR1 register) on RxFIFO full condition. SUSP generates an interrupt when EOTIE is set. This bit must be cleared prior SPI is disabled and this is done by writing 1 to SUSPC bit of SPI_IFCR exclusively.
    $0c constant SPI1_TXC                       \ [0x0c] TxFIFO transmission complete The flag behavior depends on TSIZE setting. When TSIZE = 0 the TXC is changed by hardware exclusively and it raises each time the TxFIFO becomes empty and there is no activity on the bus. If TSIZE different 0 there is no specific reason to monitor TXC as it just copies the EOT flag value including its software clearing. The TXC generates an interrupt when EOTIE is set.
    $0d constant SPI1_RXPLVL                    \ [0x0d : 2] RxFIFO packing level When RXWNE = 0 and data size is set up to 16-bit, the value gives number of remaining data frames persisting at RxFIFO. Note: (*): Optional value when data size is set up to 8-bit only. When data size is greater than 16-bit, these bits are always read as 00. In that consequence, the single data frame received at the FIFO cannot be detected neither by RWNE nor by RXPLVL bits if data size is set from 17 to 24 bits. The user then must apply other methods like TSIZE 0 or FTHLV = 0.
    $0f constant SPI1_RXWNE                     \ [0x0f] RxFIFO word not empty Note: This bit value does not depend on DSIZE setting and keeps together with RXPLVL[1:0] information about RxFIFO occupancy by residual data.
    $10 constant SPI1_CTSIZE                    \ [0x10 : 16] number of data frames remaining in current TSIZE session The value is not quite reliable when traffic is ongoing on bus or during autonomous operation in low-power mode. Note: CTSIZE[15:0] bits are not available in instances with limited set of features.
  [then]


  [ifdef] SPI1_SPI_IFCR_DEF
    \
    \ @brief SPI interrupt/status flags clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant SPI1_EOTC                      \ [0x03] end of transfer flag clear Writing a 1 into this bit clears EOT flag in the SPI_SR register
    $04 constant SPI1_TXTFC                     \ [0x04] transmission transfer filled flag clear Writing a 1 into this bit clears TXTF flag in the SPI_SR register
    $05 constant SPI1_UDRC                      \ [0x05] underrun flag clear Writing a 1 into this bit clears UDR flag in the SPI_SR register
    $06 constant SPI1_OVRC                      \ [0x06] overrun flag clear Writing a 1 into this bit clears OVR flag in the SPI_SR register
    $07 constant SPI1_CRCEC                     \ [0x07] CRC error flag clear Writing a 1 into this bit clears CRCE flag in the SPI_SR register
    $08 constant SPI1_TIFREC                    \ [0x08] TI frame format error flag clear Writing a 1 into this bit clears TIFRE flag in the SPI_SR register
    $09 constant SPI1_MODFC                     \ [0x09] mode fault flag clear Writing a 1 into this bit clears MODF flag in the SPI_SR register
    $0b constant SPI1_SUSPC                     \ [0x0b] Suspend flag clear Writing a 1 into this bit clears SUSP flag in the SPI_SR register
  [then]


  [ifdef] SPI1_SPI_AUTOCR_DEF
    \
    \ @brief SPI autonomous mode control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $10 constant SPI1_TRIGSEL                   \ [0x10 : 4] trigger selection (refer Section: Description of SPI interconnections). ... Note: these bits can be written only when SPE=0.
    $14 constant SPI1_TRIGPOL                   \ [0x14] trigger polarity Note: This bit can be written only when SPE=0.
    $15 constant SPI1_TRIGEN                    \ [0x15] HW control of CSTART triggering enable Note: if user cannot prevent trigger event during write, the TRIGEN must be changed when SPI is disabled
  [then]


  [ifdef] SPI1_SPI_TXDR_DEF
    \
    \ @brief SPI transmit data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_TXDR                      \ [0x00 : 32] transmit data register The register serves as an interface with TxFIFO. A write to it accesses TxFIFO. Note: data is always right-aligned. Unused bits are ignored when writing to the register, and read as zero when the register is read. Note: DR can be accessed byte-wise (8-bit access): in this case only one data-byte is written by single access. Note: halfword-wise (16 bit access) in this case 2 data-bytes or 1 halfword-data can be written by single access. Note: word-wise (32 bit access). In this case 4 data-bytes or 2 halfword-data or word-data can be written by single access. Note: Write access of this register less than the configured data size is forbidden.
  [then]


  [ifdef] SPI1_SPI_RXDR_DEF
    \
    \ @brief SPI receive data register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_RXDR                      \ [0x00 : 32] receive data register The register serves as an interface with RxFIFO. When it is read, RxFIFO is accessed. Note: data is always right-aligned. Unused bits are read as zero when the register is read. Writing to the register is ignored. Note: DR can be accessed byte-wise (8-bit access): in this case only one data-byte is read by single access Note: halfword-wise (16 bit access) in this case 2 data-bytes or 1 halfword-data can be read by single access Note: word-wise (32 bit access). In this case 4 data-bytes or 2 halfword-data or word-data can be read by single access. Note: Read access of this register less than the configured data size is forbidden.
  [then]


  [ifdef] SPI1_SPI_CRCPOLY_DEF
    \
    \ @brief SPI polynomial register
    \ Address offset: 0x40
    \ Reset value: 0x00000107
    \
    $00 constant SPI1_CRCPOLY                   \ [0x00 : 32] CRC polynomial register This register contains the polynomial for the CRC calculation. The default 9-bit polynomial setting 0x107 corresponds to default 8-bit setting of DSIZE. It is compatible with setting 0x07 used in other ST products with fixed length of the polynomial string, where the most significant bit of the string is always kept hidden. Length of the polynomial is given by the most significant bit of the value stored in this register. It must be set greater than DSIZE. CRC33_17 bit must be set additionally with CRCPOLY register when DSIZE is configured to maximum 32-bit or 16-bit size and CRC is enabled (to keep polynomial length grater than data size). Note: CRCPOLY[31:16] bits are reserved at instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored.
  [then]


  [ifdef] SPI1_SPI_TXCRC_DEF
    \
    \ @brief SPI transmitter CRC register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_TXCRC                     \ [0x00 : 32] CRC register for transmitter When CRC calculation is enabled, the TXCRC[31:0] bits contain the computed CRC value of the subsequently transmitted bytes. CRC calculation is initialized when the CRCEN bit of SPI_CR1 is written to 1 or when a data block is transacted completely. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPOLY register. The number of bits considered at calculation depends on SPI_CRCPOLY register and CRCSIZE bits settings at SPI_CFG1 register. Note: a read to this register when the communication is ongoing could return an incorrect value. Note: TXCRC[31-16] bits are reserved at instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored. Note: The configuration of CRCSIZE bit field is not taken into account when the content of this register is read by software. No masking is applied for unused bits in this case.
  [then]


  [ifdef] SPI1_SPI_RXCRC_DEF
    \
    \ @brief SPI receiver CRC register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_RXCRC                     \ [0x00 : 32] CRC register for receiver When CRC calculation is enabled, the RXCRC[31:0] bits contain the computed CRC value of the subsequently received bytes. CRC calculation is initialized when the CRCEN bit of SPI_CR1 is written to 1 or when a data block is transacted completely. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPOLY register. The number of bits considered at calculation depends on SPI_CRCPOLY register and CRCSIZE bits settings at SPI_CFG1 register. Note: a read to this register when the communication is ongoing could return an incorrect value. Note: RXCRC[31-16] bits are reserved at the peripheral instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored. Note: The configuration of CRCSIZE bit field is not taken into account when the content of this register is read by software. No masking is applied for unused bits in this case.
  [then]


  [ifdef] SPI1_SPI_UDRDR_DEF
    \
    \ @brief SPI underrun data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant SPI1_UDRDR                     \ [0x00 : 32] data at slave underrun condition The register is taken into account in Slave mode and at underrun condition only. The number of bits considered depends on DSIZE bit settings of the SPI_CFG1 register. Underrun condition handling depends on setting UDRCFG bit at SPI_CFG1 register. Note: UDRDR[31-16] bits are reserved at the peripheral instances with data size limited to 16-bit. There is no constraint when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored.
  [then]

  \
  \ @brief Serial peripheral interface
  \
  $00 constant SPI1_SPI_CR1             \ SPI control register 1
  $04 constant SPI1_SPI_CR2             \ SPI control register 2
  $08 constant SPI1_SPI_CFG1            \ SPI configuration register 1
  $0C constant SPI1_SPI_CFG2            \ SPI configuration register 2
  $10 constant SPI1_SPI_IER             \ SPI interrupt enable register
  $14 constant SPI1_SPI_SR              \ SPI status register
  $18 constant SPI1_SPI_IFCR            \ SPI interrupt/status flags clear register
  $1C constant SPI1_SPI_AUTOCR          \ SPI autonomous mode control register
  $20 constant SPI1_SPI_TXDR            \ SPI transmit data register
  $30 constant SPI1_SPI_RXDR            \ SPI receive data register
  $40 constant SPI1_SPI_CRCPOLY         \ SPI polynomial register
  $44 constant SPI1_SPI_TXCRC           \ SPI transmitter CRC register
  $48 constant SPI1_SPI_RXCRC           \ SPI receiver CRC register
  $4C constant SPI1_SPI_UDRDR           \ SPI underrun data register

: SPI1_DEF ; [then]
