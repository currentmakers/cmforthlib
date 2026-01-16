\
\ @file spi1.fs
\ @brief SPI1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SPI/I2S control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SPI1_SPI_CR1_SPE                                 \ serial peripheral enable This bit is set by and cleared by software. When SPE=1, the SPI data transfer is enabled, the configuration registers SPI_CFG1, SPI_CFG2, CRCPOLY and UDRDR and the IOLOCK bit in SPI_CR1 are write protected. They can be changed only when SPE=0. When SPE=0 any SPI operation is stopped and disabled, all the not cleared requests with enabled interrupt stay pending and propagates the spi_plck clock request, the SS output is deactivated at master, internal state machine is reseted, all the FIFOs content is flushed, CRC calculation initialized, receive data register is read zero. SPE is cleared and cannot be set when MODF error flag is active.
$00000100 constant SPI1_SPI_CR1_MASRX                               \ master automatic SUSP in Receive mode This bit is set and cleared by software to control continuous SPI transfer in master receiver mode and automatic management in order to avoid overrun condition. When SPI communication is suspended by hardware automatically, it could happen that few bits of next frame are already clocked out due to internal synchronization delay. That is why the automatic suspension is not quite reliable when size of data drops below 8 bits. In this case, a safe suspension can be achieved by combination with delay inserted between data frames applied when MIDI parameter keeps a non zero value; sum of data size and the interleaved SPI cycles must always produce interval at length of 8 SPI clock periods at minimum. After software clearing of the SUSP bit, the communication resumes and continues by subsequent bits transaction without any next constraint. Prior the SUSP bit is cleared, the user must release the RxFIFO space as much as possible by reading out all the data packets available at RxFIFO based on the RXP flag indication to prevent any subsequent suspension.
$00000200 constant SPI1_SPI_CR1_CSTART                              \ master transfer start This bit is set by software to start an SPI or I2S/PCM communication. In SPI mode, it is cleared by hardware when End Of Transfer (EOT) flag is set or when a transaction suspend request is accepted. In I2S/PCM mode, it is also cleared by hardware as described in the section stop sequence. In SPI mode, the bit is taken into account at master mode only. If transmission is enabled, communication starts or continues only if any data is available in the transmission FIFO.
$00000400 constant SPI1_SPI_CR1_CSUSP                               \ master suspend request This bit reads as zero. In master mode, when this bit is set by software, CSTART bit is reset at the end of the current frame and SPI communication is suspended. The user has to check SUSP flag to check end of the frame transaction. The master mode communication must be suspended (using this bit or keeping TXDR empty) before disabling the SPI or going to low-power mode. After software suspension, the SUSP flag has to be cleared and the SPI disabled and re-enabled before any next transaction starts.
$00000800 constant SPI1_SPI_CR1_HDDIR                               \ Rx/Tx direction at Half-duplex mode In Half-Duplex configuration the HDDIR bit establishes the Rx/Tx direction of the data transfer. This bit is ignored in Full-Duplex or any Simplex configuration.
$00001000 constant SPI1_SPI_CR1_SSI                                 \ internal SS signal input level This bit has an effect only when the SSM bit is set. The value of this bit is forced onto the peripheral SS input and the I/O value of the SS pin is ignored.
$00002000 constant SPI1_SPI_CR1_CRC33_17                            \ 32-bit CRC polynomial configuration
$00004000 constant SPI1_SPI_CR1_RCRCINI                             \ CRC calculation initialization pattern control for receiver
$00008000 constant SPI1_SPI_CR1_TCRCINI                             \ CRC calculation initialization pattern control for transmitter
$00010000 constant SPI1_SPI_CR1_IOLOCK                              \ locking the AF configuration of associated IOs This bit is set by software and cleared by hardware whenever SPE bit is changed from 1 to 0. When this bit is set, the SPI_CFG2 register content cannot be modified. This bit can be set when SPI is disabled only else it is write protected. It is cleared and cannot be set when the MODF bit is set.


\
\ @brief SPI control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000ffff constant SPI1_SPI_CR2_TSIZE                               \ number of data at current transfer When these bits are changed by software, the SPI must be disabled. The field can be updated by hardware optionally, too, to be reloaded by the TSER value if applicable. Endless transaction is initialized when CSTART is set while zero value is stored at TSIZE. TSIZE cannot be set to 0xFFFF value when CRC is enabled.
$ffff0000 constant SPI1_SPI_CR2_TSER                                \ number of data transfer extension to be reload into TSIZE just when a previous number of data stored at TSIZE is transacted This register can be set by software when its content is cleared only. It is cleared by hardware once TSIZE reload is done. The TSER value must be programmed in advance before CTSIZE counter reaches zero otherwise the reload is not taken into account and traffic terminates with normal EOT event.


\
\ @brief SPI configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00070007
\

$0000001f constant SPI1_SPI_CFG1_DSIZE                              \ number of bits in at single SPI data frame ..... Note: The most significant bit at DSIZE bit field is reserved at the peripheral instances where data size is limited to 16-bit.
$000001e0 constant SPI1_SPI_CFG1_FTHLV                              \ FIFO threshold level Defines number of data frames at single data packet. The size of the packet must not exceed 1/2 of FIFO space. SPI interface is more efficient if configured packet sizes are aligned with data register access parallelism: If SPI data register is accessed as a 16-bit register and DSIZE<=8bit, better to select FTHLV=2, 4, 6 etc, If SPI data register is accessed as a 32-bit register and DSIZE>8bit, better to select FTHLV=2, 4, 6 etc, while if DSIZE<=8bit, better to select FTHLV=4, 8, 12 etc
$00000600 constant SPI1_SPI_CFG1_UDRCFG                             \ behavior of slave transmitter at underrun condition When slave is configured at transmit only mode (COMM[1:0]=01), slave repeats all zeros pattern at UDRCFG[1:0]=01 setting. For more details see underrun condition.
$00001800 constant SPI1_SPI_CFG1_UDRDET                             \ detection of underrun condition at slave transmitter For more details see underrun condition.
$00004000 constant SPI1_SPI_CFG1_RXDMAEN                            \ Rx DMA stream enable
$00008000 constant SPI1_SPI_CFG1_TXDMAEN                            \ Tx DMA stream enable
$001f0000 constant SPI1_SPI_CFG1_CRCSIZE                            \ length of CRC frame to be transacted and compared Most significant bits are taken into account from polynomial calculation when CRC result is transacted or compared. The length of the polynomial is not affected by this setting. ..... The value must be set equal or multiply of data size (DSIZE[4:0]). Its maximum size cannot exceed the DSIZE maximum at the instance. Note: If crc calculation is disabled by CRCEN=0, the CRCSIZE field must be kept at its default setting. Note: The most significant bit at CRCSIZE bit field is reserved at the peripheral instances where the data size is limited to 16-bit.
$00400000 constant SPI1_SPI_CFG1_CRCEN                              \ hardware CRC computation enable
$70000000 constant SPI1_SPI_CFG1_MBR                                \ master baud rate Note: MBR setting is considered at slave working at TI mode, too (see mode).


\
\ @brief SPI configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SPI1_SPI_CFG2_MSSI                               \ master SS idleness Specifies an extra delay, expressed in number of SPI clock cycle periods, inserted additionally between active edge of SS and first data of a session start in master mode when SSOE is enabled. ... Note: This feature is not supported in TI mode.
$000000f0 constant SPI1_SPI_CFG2_MIDI                               \ master Inter-Data Idleness Specifies minimum time delay (expressed in SPI clock cycles periods) inserted between two consecutive data frames in master mode. ... Note: This feature is not supported in TI mode.
$00008000 constant SPI1_SPI_CFG2_IOSWP                              \ swap functionality of MISO and MOSI pins When this bit is set, the function of MISO and MOSI pins alternate functions are inverted. Original MISO pin becomes MOSI and original MOSI pin becomes MISO. Note: This bit can be also used in PCM and I2S modes.
$00060000 constant SPI1_SPI_CFG2_COMM                               \ SPI communication mode
$00380000 constant SPI1_SPI_CFG2_SP                                 \ Serial protocol others: Reserved, must not be used
$00400000 constant SPI1_SPI_CFG2_MASTER                             \ SPI master
$00800000 constant SPI1_SPI_CFG2_LSBFRST                            \ data frame format Note: This bit can be also used in PCM and I2S modes.
$01000000 constant SPI1_SPI_CFG2_CPHA                               \ clock phase
$02000000 constant SPI1_SPI_CFG2_CPOL                               \ clock polarity
$04000000 constant SPI1_SPI_CFG2_SSM                                \ software management of SS signal input When master uses hardware SS output (SSM=0 and SSOE=1), the SS signal input is forced to non active state internally to prevent master mode fault error.
$10000000 constant SPI1_SPI_CFG2_SSIOP                              \ SS input/output polarity
$20000000 constant SPI1_SPI_CFG2_SSOE                               \ SS output enable This bit is taken into account at master mode only
$40000000 constant SPI1_SPI_CFG2_SSOM                               \ SS output management in master mode This bit is taken into account in master mode when SSOE is enabled. It allows to configure SS output between two consecutive data transfers.
$80000000 constant SPI1_SPI_CFG2_AFCNTR                             \ alternate function GPIOs control This bit is taken into account when SPE=0 only When SPI master has to be disabled temporary for a specific configuration reason (e.g. CRC reset, CPHA or HDDIR change) setting this bit prevents any glitches on the associated outputs configured at alternate function mode by keeping them forced at state corresponding the current SPI configuration. This bit must be never used at slave mode as any slave transmitter must not force its MISO output once the SPI is disabled. Note: This bit can be also used in PCM and I2S modes.


\
\ @brief SPI/I2S interrupt enable register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SPI1_SPI_IER_RXPIE                               \ RXP Interrupt Enable
$00000002 constant SPI1_SPI_IER_TXPIE                               \ TXP interrupt enable TXPIE is set by software and cleared by TXTF flag set event.
$00000004 constant SPI1_SPI_IER_DXPIE                               \ DXP interrupt enabled DXPIE is set by software and cleared by TXTF flag set event.
$00000008 constant SPI1_SPI_IER_EOTIE                               \ EOT, SUSP and TXC interrupt enable
$00000010 constant SPI1_SPI_IER_TXTFIE                              \ TXTFIE interrupt enable
$00000020 constant SPI1_SPI_IER_UDRIE                               \ UDR interrupt enable
$00000040 constant SPI1_SPI_IER_OVRIE                               \ OVR interrupt enable
$00000080 constant SPI1_SPI_IER_CRCEIE                              \ CRC error interrupt enable
$00000100 constant SPI1_SPI_IER_TIFREIE                             \ TIFRE interrupt enable
$00000200 constant SPI1_SPI_IER_MODFIE                              \ mode fault interrupt enable
$00000400 constant SPI1_SPI_IER_TSERFIE                             \ additional number of transactions reload interrupt enable


\
\ @brief SPI/I2S status register
\ Address offset: 0x14
\ Reset value: 0x00001002
\

$00000001 constant SPI1_SPI_SR_RXP                                  \ Rx-packet available RXP flag is changed by hardware. It monitors number of overall data currently available at RxFIFO if SPI is enabled. It has to be checked once a data packet is completely read out from RxFIFO.
$00000002 constant SPI1_SPI_SR_TXP                                  \ Tx-packet space available TXP flag is changed by hardware. It monitors overall space currently available at TxFIFO if SPI is enabled. It has to be checked once a complete data packet is stored at TxFIFO.
$00000004 constant SPI1_SPI_SR_DXP                                  \ duplex packet The DXP flag is set whenever both TXP and RXP flags are set regardless the SPI mode.
$00000008 constant SPI1_SPI_SR_EOT                                  \ end of transfer EOT is set by hardware as soon as a full transfer is complete, that is when TSIZE number of data have been transmitted and/or received on the SPI. EOT is cleared by software write 1 to EOTC bit at SPI_IFCR. EOT flag triggers an interrupt if EOTIE bit is set. If DXP flag is used until TXTF flag is set and DXPIE is cleared, EOT can be used to download the last packets contained into RxFIFO in one-shot. In master, EOT event terminates the data transaction and handles SS output optionally. When CRC is applied, the EOT event is extended over the CRC frame transaction.
$00000010 constant SPI1_SPI_SR_TXTF                                 \ transmission transfer filled TXTF is set by hardware as soon as all of the data packets in a transfer have been submitted for transmission by application software or DMA, that is when TSIZE number of data have been pushed into the TxFIFO. This bit is cleared by software write 1 to TXTFC bit at SPI_IFCR TXTF flag triggers an interrupt if TXTFIE bit is set. TXTF setting clears the TXIE and DXPIE masks so to off-load application software from calculating when to disable TXP and DXP interrupts.
$00000020 constant SPI1_SPI_SR_UDR                                  \ underrun at slave transmission mode This bit is cleared by write 1 to UDRC bit at SPI_IFCR Note: UDR flag applies to Slave mode only
$00000040 constant SPI1_SPI_SR_OVR                                  \ overrun This bit is cleared by write 1 to OVRC bit at SPI_IFCR
$00000080 constant SPI1_SPI_SR_CRCE                                 \ CRC error This bit is cleared by write 1 to CRCEC bit at SPI_IFCR
$00000100 constant SPI1_SPI_SR_TIFRE                                \ TI frame format error This bit is cleared by write 1 to TIFREC bit at SPI_IFCR
$00000200 constant SPI1_SPI_SR_MODF                                 \ mode fault This bit is cleared by write 1 to MODFC bit at SPI_IFCR. When MODF is set, the SPE and IOLOCK bits at the SPI_CR1 register are reset and their setting is blocked.
$00000400 constant SPI1_SPI_SR_TSERF                                \ additional number of SPI data to be transacted was reload This bit is cleared by write 1 to TSERFC bit at SPI_IFCR or by writing the TSER[15:0] (SPI_CR2) register
$00000800 constant SPI1_SPI_SR_SUSP                                 \ suspension status In Master mode, SUSP is set by hardware when a CSUSP request is done, either as soon as the current frame is completed after CSUSP request is done or at master automatic suspend receive mode (MASRX bit is set at SPI_CR1 register) on RxFIFO full condition. SUSP generates an interrupt when EOTIE is set. This bit has to be cleared prior SPI is disabled by write 1 to SUSPC bit at SPI_IFCR
$00001000 constant SPI1_SPI_SR_TXC                                  \ TxFIFO transmission complete The flag behavior depends on TSIZE setting. When TSIZE=0 the TXC is changed by hardware exclusively and it raises each time the TxFIFO becomes empty and there is no activity on the bus. If TSIZE <>0 there is no specific reason to monitor TXC as it just copies the EOT flag value including its software clearing. The TXC generates an interrupt when EOTIE is set.
$00006000 constant SPI1_SPI_SR_RXPLVL                               \ RxFIFO packing leveL When RXWNE=0 and data size is set up to 16-bit, the value gives number of remaining data frames persisting at RxFIFO. (*) optional count when the data size is set up to 8-bit. When the frame size is greater than 16-bit, these bits read as 00. In consequence, the single data frame received at the FIFO cannot be detected neither by RWNE nor by RXPLVL bits if data size is set from 17 to 24 bits. The user then must apply other methods like TSIZE>0 or FTHLV=0.
$00008000 constant SPI1_SPI_SR_RXWNE                                \ RxFIFO word not empty Note: This bit value does not depend on DSIZE setting and keeps together with RXPLVL[1:0] information about RxFIFO occupancy by residual data.
$ffff0000 constant SPI1_SPI_SR_CTSIZE                               \ number of data frames remaining in current TSIZE session The value is not quite reliable when traffic is ongoing on bus and at LP mode too.


\
\ @brief SPI/I2S interrupt/status flags clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000008 constant SPI1_SPI_IFCR_EOTC                               \ end of transfer flag clear Writing a 1 into this bit clears EOT flag in the SPI_SR register
$00000010 constant SPI1_SPI_IFCR_TXTFC                              \ transmission Transfer Filled flag clear Writing a 1 into this bit clears TXTF flag in the SPI_SR register
$00000020 constant SPI1_SPI_IFCR_UDRC                               \ underrun flag clear Writing a 1 into this bit clears UDR flag in the SPI_SR register
$00000040 constant SPI1_SPI_IFCR_OVRC                               \ overrun flag clear Writing a 1 into this bit clears OVR flag in the SPI_SR register
$00000080 constant SPI1_SPI_IFCR_CRCEC                              \ CRC error flag clear Writing a 1 into this bit clears CRCE flag in the SPI_SR register
$00000100 constant SPI1_SPI_IFCR_TIFREC                             \ TI frame format error flag clear Writing a 1 into this bit clears TIFRE flag in the SPI_SR register
$00000200 constant SPI1_SPI_IFCR_MODFC                              \ mode fault flag clear Writing a 1 into this bit clears MODF flag in the SPI_SR register
$00000400 constant SPI1_SPI_IFCR_TSERFC                             \ TSERFC flag clear Writing a 1 into this bit clears TSERF flag in the SPI_SR register Note: TSERF is also reset by writing the TSER[15:0] (SPI_CR2) register
$00000800 constant SPI1_SPI_IFCR_SUSPC                              \ SUSPend flag clear Writing a 1 into this bit clears SUSP flag in the SPI_SR register


\
\ @brief SPI/I2S transmit data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SPI1_SPI_TXDR_TXDR                               \ transmit data register The register serves as an interface with TxFIFO. A write to it accesses TxFIFO. Note: data is always right-aligned. Unused bits are ignored when writing to the register, and read as zero when the register is read. Note: DR can be accessed byte-wise (8-bit access): in this case only one data-byte is written by single access. halfword-wise (16 bit access) in this case 2 data-bytes or 1 halfword-data can be written by single access. word-wise (32 bit access). In this case 4 data-bytes or 2 halfword-data or word-data can be written by single access. Write access of this register less than the configured data size is forbidden.


\
\ @brief SPI/I2S receive data register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SPI1_SPI_RXDR_RXDR                               \ receive data register The register serves as an interface with RxFIFO. When it is read, RxFIFO is accessed. Note: Data is always right-aligned. Unused bits are read as zero when the register is read. Writing to the register is ignored. Note: DR can be accessed byte-wise (8-bit access): in this case only one data-byte is read by single access. halfword-wise (16 bit access) in this case 2 data-bytes or 1 halfword-data can be read by single access word-wise (32 bit access). In this case 4 data-bytes or 2 halfword-data or word-data can be read by single access. Read access of this register less than the configured data size is forbidden.


\
\ @brief SPI polynomial register
\ Address offset: 0x40
\ Reset value: 0x00000107
\

$00000000 constant SPI1_SPI_CRCPOLY_CRCPOLY                         \ CRC polynomial register This register contains the polynomial for the CRC calculation. The default 9-bit polynomial setting 0x107 corresponds to default 8-bit setting of DSIZE. It is compatible with setting 0x07 used at some other ST products with fixed length of the polynomial string where the most significant bit of the string is always kept hidden. Length of the polynomial is given by the most significant bit of the value stored at this register. It has to be set greater than DSIZE. CRC33_17 bit has to be set additionally with CRCPOLY register when DSIZE is configured to maximum 32-bit or 16-bit size and CRC is enabled (to keep polynomial length grater than data size). Bits 31-16 are reserved at the peripheral instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored.


\
\ @brief SPI transmitter CRC register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant SPI1_SPI_TXCRC_TXCRC                             \ CRC register for transmitter When CRC calculation is enabled, the TXCRC[31:0] bits contain the computed CRC value of the subsequently transmitted bytes. CRC calculation is initialized when the CRCEN bit of SPI_CR1 is written to 1 or when a data block is transacted completely. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPOLY register. The number of bits considered at calculation depends on SPI_CRCPOLY register and CRCSIZE bits settings at SPI_CFG1 register. Note: A read to this register when the communication is ongoing could return an incorrect value. Not used for the I2S mode. Bits 31-16 are reserved at the peripheral instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored. Note: The configuration of CRCSIZE bit field is not taken into account when the content of this register is read by software. No masking is applied for unused bits at this case.


\
\ @brief SPI receiver CRC register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant SPI1_SPI_RXCRC_RXCRC                             \ CRC register for receiver When CRC calculation is enabled, the RXCRC[31:0] bits contain the computed CRC value of the subsequently received bytes. CRC calculation is initialized when the CRCEN bit of SPI_CR1 is written to 1 or when a data block is transacted completely. The CRC is calculated serially using the polynomial programmed in the SPI_CRCPOLY register. The number of bits considered at calculation depends on SPI_CRCPOLY register and CRCSIZE bits settings at SPI_CFG1 register. Note: A read to this register when the communication is ongoing could return an incorrect value. Not used for the I2S mode. Bits 31-16 are reserved at the peripheral instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored. Note: The configuration of CRCSIZE bit field is not taken into account when the content of this register is read by software. No masking is applied for unused bits at this case.


\
\ @brief SPI underrun data register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SPI1_SPI_UDRDR_UDRDR                             \ data at slave underrun condition The register is taken into account at slave mode and at underrun condition only. The number of bits considered depends on DSIZE bit settings at SPI_CFG1 register. Underrun condition handling depends on setting if UDRDET and UDRCFG bits at SPI_CFG1 register. Bits 31-16 are reserved at the peripheral instances with data size limited to 16-bit. There is no constrain when 32-bit access is applied at these addresses. Reserved bits 31-16 are always read zero while any write to them is ignored.


\
\ @brief SPI/I2S configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SPI1_SPI_I2SCFGR_I2SMOD                          \ I2S mode selection
$0000000e constant SPI1_SPI_I2SCFGR_I2SCFG                          \ I2S configuration mode others, not used
$00000030 constant SPI1_SPI_I2SCFGR_I2SSTD                          \ I2S standard selection For more details on I2S standards, refer to
$00000080 constant SPI1_SPI_I2SCFGR_PCMSYNC                         \ PCM frame synchronization
$00000300 constant SPI1_SPI_I2SCFGR_DATLEN                          \ data length to be transferred
$00000400 constant SPI1_SPI_I2SCFGR_CHLEN                           \ channel length (number of bits per audio channel) The bit write operation has a meaning only if DATLEN = 00 otherwise the channel length is fixed to 32-bit by hardware whatever the value filled in.
$00000800 constant SPI1_SPI_I2SCFGR_CKPOL                           \ serial audio clock polarity
$00001000 constant SPI1_SPI_I2SCFGR_FIXCH                           \ fixed channel length in slave
$00002000 constant SPI1_SPI_I2SCFGR_WSINV                           \ Word select inversion This bit is used to invert the default polarity of WS signal. WS is low. In PCM mode the start of frame is indicated by a rising edge. WS is high. In PCM mode the start of frame is indicated by a falling edge.
$00004000 constant SPI1_SPI_I2SCFGR_DATFMT                          \ data format
$00ff0000 constant SPI1_SPI_I2SCFGR_I2SDIV                          \ I2S linear prescaler I2SDIV can take any values except the value 1, when ODD is also equal to 1. Refer to for details
$01000000 constant SPI1_SPI_I2SCFGR_ODD                             \ odd factor for the prescaler Refer to for details
$02000000 constant SPI1_SPI_I2SCFGR_MCKOE                           \ master clock output enable


\
\ @brief SPI/I2S hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$0000000f constant SPI1_SPI_I2S_HWCFGR_TXFCFG                       \ TxFIFO size 0002: the FIFO size is 4 bytes 0003: the FIFO size is 8 bytes 0004: the FIFO size is 16 bytes 0005: the FIFO size is 32 bytes All the other combinations are reserved.
$000000f0 constant SPI1_SPI_I2S_HWCFGR_RXFCFG                       \ RxFIFO size 0002: the FIFO size is 4 bytes 0003: the FIFO size is 8 bytes 0004: the FIFO size is 16 bytes 0005: the FIFO size is 32 bytes All the other combinations are reserved.
$00000f00 constant SPI1_SPI_I2S_HWCFGR_CRCCFG                       \ CRC configuration for SPI All the other combinations are reserved.
$0000f000 constant SPI1_SPI_I2S_HWCFGR_I2SCFG                       \ I2S configuration All the other combinations are reserved.
$000f0000 constant SPI1_SPI_I2S_HWCFGR_DSCFG                        \ SPI data size configuration All the other combinations are reserved.


\
\ @brief SPI/I2S version register
\ Address offset: 0x3F4
\ Reset value: 0x00000011
\

$0000000f constant SPI1_SPI_VERR_MINREV                             \ minor revision of the IP.
$000000f0 constant SPI1_SPI_VERR_MAJREV                             \ major revision of the IP.


\
\ @brief SPI/I2S identification register
\ Address offset: 0x3F8
\ Reset value: 0x00130022
\

$00000000 constant SPI1_SPI_IPIDR_ID                                \ IP identification MCD identification code which identifies the IP.


\
\ @brief SPI/I2S size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant SPI1_SPI_SIDR_SID                                \ size identification Bits[31:8]: fixed code 0xA3C5DD0 Bits[7:0]: range of address decoding boundary All the other combination are reserved.


\
\ @brief SPI1
\
$44004000 constant SPI1_SPI_CR1   \ offset: 0x00 : SPI/I2S control register 1
$44004004 constant SPI1_SPI_CR2   \ offset: 0x04 : SPI control register 2
$44004008 constant SPI1_SPI_CFG1  \ offset: 0x08 : SPI configuration register 1
$4400400c constant SPI1_SPI_CFG2  \ offset: 0x0C : SPI configuration register 2
$44004010 constant SPI1_SPI_IER   \ offset: 0x10 : SPI/I2S interrupt enable register
$44004014 constant SPI1_SPI_SR    \ offset: 0x14 : SPI/I2S status register
$44004018 constant SPI1_SPI_IFCR  \ offset: 0x18 : SPI/I2S interrupt/status flags clear register
$44004020 constant SPI1_SPI_TXDR  \ offset: 0x20 : SPI/I2S transmit data register
$44004030 constant SPI1_SPI_RXDR  \ offset: 0x30 : SPI/I2S receive data register
$44004040 constant SPI1_SPI_CRCPOLY  \ offset: 0x40 : SPI polynomial register
$44004044 constant SPI1_SPI_TXCRC  \ offset: 0x44 : SPI transmitter CRC register
$44004048 constant SPI1_SPI_RXCRC  \ offset: 0x48 : SPI receiver CRC register
$4400404c constant SPI1_SPI_UDRDR  \ offset: 0x4C : SPI underrun data register
$44004050 constant SPI1_SPI_I2SCFGR  \ offset: 0x50 : SPI/I2S configuration register
$440043f0 constant SPI1_SPI_I2S_HWCFGR  \ offset: 0x3F0 : SPI/I2S hardware configuration register
$440043f4 constant SPI1_SPI_VERR  \ offset: 0x3F4 : SPI/I2S version register
$440043f8 constant SPI1_SPI_IPIDR  \ offset: 0x3F8 : SPI/I2S identification register
$440043fc constant SPI1_SPI_SIDR  \ offset: 0x3FC : SPI/I2S size identification register

