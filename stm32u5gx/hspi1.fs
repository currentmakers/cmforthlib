\
\ @file hspi1.fs
\ @brief HSPI1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief HSPI control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant HSPI1_HSPI_CR_EN                                 \ Enable This bit enables the HSPI. Note: The DMA request can be aborted without having received the ACK in case this EN bit is cleared during the operation. In case this bit is set to 0 during a DMA transfer, the REQ signal to DMA returns to inactive state without waiting for the ACK signal from DMA to be active.
$00000002 constant HSPI1_HSPI_CR_ABORT                              \ Abort request This bit aborts the on-going command sequence. It is automatically reset once the abort is completed. This bit stops the current transfer. Note: This bit is always read as 0.
$00000004 constant HSPI1_HSPI_CR_DMAEN                              \ DMA enable In Indirect mode, the DMA can be used to input or output data via HSPI_DR. DMA transfers are initiated when FTF is set. Note: Resetting the DMAEN bit while a DMA transfer is ongoing, breaks the handshake with the DMA. Do not write this bit during DMA operation.
$00000008 constant HSPI1_HSPI_CR_TCEN                               \ Timeout counter enable This bit is valid only when the Memory-mapped mode (FMODE[1:0]Â =Â 11) is selected. This bit enables the timeout counter.
$00000040 constant HSPI1_HSPI_CR_DMM                                \ Dual-memory mode This bit activates the Dual-memory mode, where two external devices are used simultaneously to double the throughput and the capacity
$00000080 constant HSPI1_HSPI_CR_FSEL                               \ Memory select This bit is the mirror of bit 30. Refer to the description of MSEL[1:0] above. This bit is set when 1 is written in bit 30 or bit 7. When this bit is set, both b30 and b7 are read as 1. This bit is reset when bit 30 and bit7 are set to 0. When this bit is reset, both bit 30 and bit7 are read as 0.
$00003f00 constant HSPI1_HSPI_CR_FTHRES                             \ FIFO threshold level This field defines, in Indirect mode, the threshold number of bytes in the FIFO that causes the FIFO threshold flag FTF in HSPI_SR, to be set. ... Note: If DMAENÂ =Â 1, the DMA controller for the corresponding channel must be disabled before changing the FTHRES[5:0] value.
$00010000 constant HSPI1_HSPI_CR_TEIE                               \ Transfer error interrupt enable This bit enables the transfer error interrupt.
$00020000 constant HSPI1_HSPI_CR_TCIE                               \ Transfer complete interrupt enable This bit enables the transfer complete interrupt.
$00040000 constant HSPI1_HSPI_CR_FTIE                               \ FIFO threshold interrupt enable This bit enables the FIFO threshold interrupt.
$00080000 constant HSPI1_HSPI_CR_SMIE                               \ Status match interrupt enable This bit enables the status match interrupt.
$00100000 constant HSPI1_HSPI_CR_TOIE                               \ Timeout interrupt enable This bit enables the timeout interrupt.
$00400000 constant HSPI1_HSPI_CR_APMS                               \ Automatic-polling mode stop This bit determines if the automatic polling is stopped after a match.
$00800000 constant HSPI1_HSPI_CR_PMM                                \ Polling match mode This bit indicates which method must be used to determine a match during the Automatic-polling mode.
$30000000 constant HSPI1_HSPI_CR_FMODE                              \ Functional mode This field defines the HSPI functional mode of operation. If DMAENÂ =Â 1 already, then the DMA controller for the corresponding channel must be disabled before changing the FMODE[1:0] value. If FMODE[1:0] and FTHRES[4:0] are wrongly updated while DMAENÂ =Â 1, the DMA request signal automatically goes to inactive state.
$c0000000 constant HSPI1_HSPI_CR_MSEL                               \ Flash select These bits select the memory to be addressed in Single, Dual, Quad or Octal mode in singleâmemory configuration (when DMM = 0). - when in Quad mode: - when in Octal mode or Dual-quad mode: 0x: data exchanged over IO[7:0] 1x: data exchanged over IO[15:8] These bits are ignored when in dual-octal configuration (data on 8 bits and DMMÂ =Â 1) or 16âbit configuration (data exchanged over IO[15:0]).


\
\ @brief HSPI device configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant HSPI1_HSPI_DCR1_CKMODE                           \ Mode 0/Mode 3 This bit indicates the level taken by the CLK between commands (when nCSÂ =Â 1).
$00000002 constant HSPI1_HSPI_DCR1_FRCK                             \ Free running clock This bit configures the free running clock.
$00000008 constant HSPI1_HSPI_DCR1_DLYBYP                           \ Delay block bypass
$00003f00 constant HSPI1_HSPI_DCR1_CSHT                             \ Chip-select high time CSHTÂ +Â 1 defines the minimum number of CLK cycles where the chip-select (nCS) must remain high between commands issued to the external device. ... 63: nCS stays high for at least 64 cycles between external device commands. Note: When the extended CSHT timeout feature is not supported, CSHT[5:3] are reserved and the number of cycles is limited to eight (refer to implementation).
$001f0000 constant HSPI1_HSPI_DCR1_DEVSIZE                          \ Device size This field defines the size of the external device using the following formula: Number of bytes in device = 2[DEVSIZE+1]. DEVSIZE+1 is effectively the number of address bits required to address the external device. The device capacity can be up to 4Â Gbytes (addressed using 32-bits) in Indirect mode, but the addressable space in Memory-mapped mode is limited to 256Â Mbytes. In Regular-command mode, if DMMÂ =Â 1, DEVSIZE[4:0] indicates the total capacity of the two devices together.
$07000000 constant HSPI1_HSPI_DCR1_MTYP                             \ Memory type This bit indicates the type of memory to be supported. Note: In this mode, DQS signal polarity is inverted with respect to the memory clock signal. This is the default value and care must be taken to change MTYP[2:0] for memories different from Micron. Others: Reserved


\
\ @brief HSPI device configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant HSPI1_HSPI_DCR2_PRESCALER                        \ Clock prescaler This field defines the scaler factor for generating the CLK based on the kernel clock (valueÂ +Â 1). 2: FCLK = FKERNEL/3 ... 255: FCLK = FKERNEL/256 For odd clock division factors, the CLK duty cycle is not 50Â %. The clock signal remains low one cycle longer than it stays high. Writing this field automatically starts a new calibration of high-speed interface DLL at the start of next transfer, except in case HSPI_CALOSR or HSPI_CALISR have been written in the meantime. BUSY stays high during the whole calibration execution.
$00070000 constant HSPI1_HSPI_DCR2_WRAPSIZE                         \ Wrap size This field indicates the wrap size to which the memory is configured. For memories which have a separate command for wrapped instructions, this field indicates the wrap-size associated with the command held in the HSPI_WPIR register. 110-111: Reserved


\
\ @brief HSPI device configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant HSPI1_HSPI_DCR3_MAXTRAN                          \ Maximum transfer This field enables the communication regulation feature. The nCS is released every MAXTRAN+1 clock cycles when the other HSPI request the access to the bus. others: Maximum communication is set to MAXTRAN+1 bytes
$001f0000 constant HSPI1_HSPI_DCR3_CSBOUND                          \ CS boundary This field enables the transaction boundary feature. When active, a minimum value of 3 is recommended. The nCS is released on each boundary of 2CSBOUND bytes. others: CS boundary set to 2CSBOUND bytes


\
\ @brief HSPI device configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_DCR4_REFRESH                          \ Refresh rate This field enables the refresh rate feature. The nCS is released every REFRESH+1 clock cycles for writes, and REFRESH+4 clock cycles for reads. Note: These two values can be extended with few clock cycles when refresh occurs during a byte transmission in single, dual or quad mode, because the byte transmission must be completed. others: Maximum communication length is set to REFRESH+1 clock cycles.


\
\ @brief Transfer error flag This bit is set in Indirect mode when an invalid address is being accessed in Indirect mode. It is cleared by writing 1 to CTEF.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant HSPI1_HSPI_SR_TEF                                \ Transfer error flag This bit is set in Indirect mode when an invalid address is being accessed in Indirect mode. It is cleared by writing 1 to CTEF.
$00000002 constant HSPI1_HSPI_SR_TCF                                \ Transfer complete flag This bit is set in Indirect mode when the programmed number of data has been transferred or in any mode when the transfer has been aborted.It is cleared by writing 1 to CTCF.
$00000004 constant HSPI1_HSPI_SR_FTF                                \ FIFO threshold flag In Indirect mode, this bit is set when the FIFO threshold has been reached, or if there is any data left in the FIFO after the reads from the external device are complete. It is cleared automatically as soon as the threshold condition is no longer true. In Automatic-polling mode this bit is set every time the status register is read, and the bit is cleared when the data register is read.
$00000008 constant HSPI1_HSPI_SR_SMF                                \ Status match flag This bit is set in Automatic-polling mode when the unmasked received data matches the corresponding bits in the match register (HSPI_PSMAR). It is cleared by writing 1 to CSMF.
$00000010 constant HSPI1_HSPI_SR_TOF                                \ Timeout flag This bit is set when timeout occurs. It is cleared by writing 1 to CTOF.
$00000020 constant HSPI1_HSPI_SR_BUSY                               \ Busy This bit is set when an operation is ongoing. It is cleared automatically when the operation with the external device is finished and the FIFO is empty.
$00007f00 constant HSPI1_HSPI_SR_FLEVEL                             \ FIFO level This field gives the number of valid bytes that are being held in the FIFO. FLEVELÂ =Â 0 when the FIFO is empty, and 64 when it is full. In Automatic-status polling mode, FLEVEL is zero.


\
\ @brief Clear transfer error flag Writing 1 clears the TEF flag in the HSPI_SR register.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant HSPI1_HSPI_FCR_CTEF                              \ Clear transfer error flag Writing 1 clears the TEF flag in the HSPI_SR register.
$00000002 constant HSPI1_HSPI_FCR_CTCF                              \ Clear transfer complete flag Writing 1 clears the TCF flag in the HSPI_SR register.
$00000008 constant HSPI1_HSPI_FCR_CSMF                              \ Clear status match flag Writing 1 clears the SMF flag in the HSPI_SR register.
$00000010 constant HSPI1_HSPI_FCR_CTOF                              \ Clear timeout flag Writing 1 clears the TOF flag in the HSPI_SR register.


\
\ @brief HSPI data length register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_DLR_DL                                \ [31: 0]: Data length Number of data to be retrieved (value+1) in Indirect and Status-polling modes. A value not greater than three (indicating 4 bytes) must be used for status polling-mode. All 1's in Indirect mode means undefined length, where HSPI continues until the end of the memory, as defined by DEVSIZE. 0x0000_0000: 1 byte is to be transferred. 0x0000_0001: 2 bytes are to be transferred. 0x0000_0002: 3 bytes are to be transferred. 0x0000_0003: 4 bytes are to be transferred. ... 0xFFFF_FFFD: 4,294,967,294 (4G-2) bytes are to be transferred. 0xFFFF_FFFE: 4,294,967,295 (4G-1) bytes are to be transferred. 0xFFFF_FFFF: undefined length; all bytes, until the end of the external device, (as defined by DEVSIZE) are to be transferred. Continue reading indefinitely if DEVSIZEÂ =Â 0x1F. DL[0] is stuck at 1 in Dual-memory mode (DMMÂ =Â 1) even when 0 is written to this bit, thus assuring that each access transfers an even number of bytes. This field has no effect when in Memory-mapped mode.


\
\ @brief Address Address to be sent to the external device. In HyperBus mode, this field must be even as this protocol is 16-bit word oriented. In dual-memory mode, AR[0] is forced to 1. Writes to this field are ignored when BUSYÂ =Â 1 or when FMODE = 11 (Memory-mapped mode).
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_AR_ADDRESS                            \ Address Address to be sent to the external device. In HyperBus mode, this field must be even as this protocol is 16-bit word oriented. In dual-memory mode, AR[0] is forced to 1. Writes to this field are ignored when BUSYÂ =Â 1 or when FMODE = 11 (Memory-mapped mode).


\
\ @brief [31: 0]: Data Data to be sent/received to/from the external SPI device In Indirect-write mode, data written to this register is stored on the FIFO before it is sent to the external device during the data phase. If the FIFO is too full, a write operation is stalled until the FIFO has enough space to accept the amount of data being written. In Indirect-read mode, reading this register gives (via the FIFO) the data that was received from the external device. If the FIFO does not have as many bytes as requested by the read operation and if BUSYÂ =Â 1, the read operation is stalled until enough data is present or until the transfer is complete, whichever happens first. In Automatic-polling mode, this register contains the last data read from the external device (without masking). Word, half-word, and byte accesses to this register are supported. In Indirect-write mode, a byte write adds 1 byte to the FIFO, a half-word write 2 bytes, and a word write 4 bytes. Similarly, in Indirect-read mode, a byte read removes 1 byte from the FIFO, a halfword read 2Â bytes, and a word read 4Â bytes. Accesses in Indirect mode must be aligned to the bottom of this register: A byte read must read DATA[7:0] and a half-word read must read DATA[15:0].
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_DR_DATA                               \ [31: 0]: Data Data to be sent/received to/from the external SPI device In Indirect-write mode, data written to this register is stored on the FIFO before it is sent to the external device during the data phase. If the FIFO is too full, a write operation is stalled until the FIFO has enough space to accept the amount of data being written. In Indirect-read mode, reading this register gives (via the FIFO) the data that was received from the external device. If the FIFO does not have as many bytes as requested by the read operation and if BUSYÂ =Â 1, the read operation is stalled until enough data is present or until the transfer is complete, whichever happens first. In Automatic-polling mode, this register contains the last data read from the external device (without masking). Word, half-word, and byte accesses to this register are supported. In Indirect-write mode, a byte write adds 1 byte to the FIFO, a half-word write 2 bytes, and a word write 4 bytes. Similarly, in Indirect-read mode, a byte read removes 1 byte from the FIFO, a halfword read 2Â bytes, and a word read 4Â bytes. Accesses in Indirect mode must be aligned to the bottom of this register: A byte read must read DATA[7:0] and a half-word read must read DATA[15:0].


\
\ @brief HSPI polling status mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_PSMKR_MASK                            \ Status mask Mask to be applied to the status bytes received in Polling mode For bit n:


\
\ @brief HSPI polling status match register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_PSMAR_MATCH                           \ [31: 0]: Status match Value to be compared with the masked status register to get a match


\
\ @brief HSPI polling interval register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant HSPI1_HSPI_PIR_INTERVAL                          \ [15: 0]: Polling interval Number of CLK cycle between a read during the automatic-polling phases


\
\ @brief HSPI communication configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant HSPI1_HSPI_CCR_IMODE                             \ Instruction mode This field defines the instruction phase mode of operation. 101-111: Reserved
$00000008 constant HSPI1_HSPI_CCR_IDTR                              \ Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
$00000030 constant HSPI1_HSPI_CCR_ISIZE                             \ Instruction size This bit defines instruction size.
$00000700 constant HSPI1_HSPI_CCR_ADMODE                            \ Address mode This field defines the address phase mode of operation. 101-111: Reserved
$00000800 constant HSPI1_HSPI_CCR_ADDTR                             \ Address double transfer rate This bit sets the DTR mode for the address phase.
$00003000 constant HSPI1_HSPI_CCR_ADSIZE                            \ Address size This field defines address size.
$00070000 constant HSPI1_HSPI_CCR_ABMODE                            \ Alternate-byte mode This field defines the alternate byte phase mode of operation. 100-111: Reserved
$00080000 constant HSPI1_HSPI_CCR_ABDTR                             \ Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase. This field can be written only when BUSYÂ =Â 0.
$00300000 constant HSPI1_HSPI_CCR_ABSIZE                            \ Alternate bytes size This bit defines alternate bytes size.
$07000000 constant HSPI1_HSPI_CCR_DMODE                             \ Data mode This field defines the data phase mode of operation. 110-111: Reserved
$08000000 constant HSPI1_HSPI_CCR_DDTR                              \ Data double transfer rate This bit sets the DTR mode for the data phase.
$20000000 constant HSPI1_HSPI_CCR_DQSE                              \ DQS enable This bit enables the data strobe management.
$80000000 constant HSPI1_HSPI_CCR_SIOO                              \ Send instruction only once mode This bit has no effect when IMODEÂ =Â 00 (see ).


\
\ @brief HSPI timing configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant HSPI1_HSPI_TCR_DCYC                              \ Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31).
$10000000 constant HSPI1_HSPI_TCR_DHQC                              \ Delay hold quarter cycle
$40000000 constant HSPI1_HSPI_TCR_SSHIFT                            \ Sample shift By default, the HSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The software must ensure that SSHIFTÂ =Â 0 when the data phase is configured in DTR mode (when DDTRÂ =Â 1.)


\
\ @brief HSPI instruction register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_IR_INSTRUCTION                        \ Instruction Instruction to be sent to the external SPI device


\
\ @brief HSPI alternate bytes register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_ABR_ALTERNATE                         \ [31: 0]: Alternate bytes Optional data to be send to the external SPI device right after the address.


\
\ @brief HSPI low-power timeout register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000ffff constant HSPI1_HSPI_LPTR_TIMEOUT                          \ [15: 0]: Timeout period After each access in Memory-mapped mode, the HSPI prefetches the subsequent bytes and hold them in the FIFO. This field indicates how many CLK cycles the HSPI waits after the clock becomes inactive and until it raises the nCS, putting the external device in a lower-consumption state.


\
\ @brief HSPI wrap communication configuration register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000007 constant HSPI1_HSPI_WPCCR_IMODE                           \ Instruction mode This field defines the instruction phase mode of operation. 101-111: Reserved
$00000008 constant HSPI1_HSPI_WPCCR_IDTR                            \ Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
$00000030 constant HSPI1_HSPI_WPCCR_ISIZE                           \ Instruction size This field defines instruction size.
$00000700 constant HSPI1_HSPI_WPCCR_ADMODE                          \ Address mode This field defines the address phase mode of operation. 101-111: Reserved
$00000800 constant HSPI1_HSPI_WPCCR_ADDTR                           \ Address double transfer rate This bit sets the DTR mode for the address phase.
$00003000 constant HSPI1_HSPI_WPCCR_ADSIZE                          \ Address size This field defines address size.
$00070000 constant HSPI1_HSPI_WPCCR_ABMODE                          \ Alternate-byte mode This field defines the alternate byte phase mode of operation.
$00080000 constant HSPI1_HSPI_WPCCR_ABDTR                           \ Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase.
$00300000 constant HSPI1_HSPI_WPCCR_ABSIZE                          \ Alternate bytes size This bit defines alternate bytes size.
$07000000 constant HSPI1_HSPI_WPCCR_DMODE                           \ Data mode This field defines the data phase mode of operation. 101; Data on 16 lines 110-111: Reserved
$08000000 constant HSPI1_HSPI_WPCCR_DDTR                            \ Data double transfer rate This bit sets the DTR mode for the data phase.
$20000000 constant HSPI1_HSPI_WPCCR_DQSE                            \ DQS enable This bit enables the data strobe management.


\
\ @brief HSPI wrap timing configuration register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000001f constant HSPI1_HSPI_WPTCR_DCYC                            \ Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31). It is recommended to have at least 5 dummy cycles when using memories with DQS activated.
$10000000 constant HSPI1_HSPI_WPTCR_DHQC                            \ Delay hold quarter cycle Add a quarter cycle delay on the outputs in DTR communication to match hold requirement.
$40000000 constant HSPI1_HSPI_WPTCR_SSHIFT                          \ Sample shift By default, the HSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The firmware must assure that SSHIFT=0 when the data phase is configured in DTR mode (when DDTRÂ =Â 1).


\
\ @brief HSPI wrap instruction register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_WPIR_INSTRUCTION                      \ [31: 0]: Instruction Instruction to be sent to the external SPI device


\
\ @brief HSPI wrap alternate bytes register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_WPABR_ALTERNATE                       \ [31: 0]: Alternate bytes Optional data to be sent to the external SPI device right after the address


\
\ @brief HSPI write communication configuration register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000007 constant HSPI1_HSPI_WCCR_IMODE                            \ Instruction mode This field defines the instruction phase mode of operation. 101-111: Reserved
$00000008 constant HSPI1_HSPI_WCCR_IDTR                             \ Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
$00000030 constant HSPI1_HSPI_WCCR_ISIZE                            \ Instruction size This bit defines instruction size:
$00000700 constant HSPI1_HSPI_WCCR_ADMODE                           \ Address mode This field defines the address phase mode of operation. 101-111: Reserved
$00000800 constant HSPI1_HSPI_WCCR_ADDTR                            \ Address double transfer rate This bit sets the DTR mode for the address phase.
$00003000 constant HSPI1_HSPI_WCCR_ADSIZE                           \ Address size This field defines address size.
$00070000 constant HSPI1_HSPI_WCCR_ABMODE                           \ Alternate-byte mode This field defines the alternate-byte phase mode of operation. 101-111: Reserved
$00080000 constant HSPI1_HSPI_WCCR_ABDTR                            \ Alternate bytes double-transfer rate This bit sets the DTR mode for the alternate-bytes phase.
$00300000 constant HSPI1_HSPI_WCCR_ABSIZE                           \ Alternate bytes size This field defines alternate bytes size:
$07000000 constant HSPI1_HSPI_WCCR_DMODE                            \ Data mode This field defines the data phase mode of operation.
$08000000 constant HSPI1_HSPI_WCCR_DDTR                             \ data double transfer rate This bit sets the DTR mode for the data phase.
$20000000 constant HSPI1_HSPI_WCCR_DQSE                             \ DQS enable This bit enables the data strobe management.


\
\ @brief HSPI write timing configuration register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000001f constant HSPI1_HSPI_WTCR_DCYC                             \ Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31). It is recommended to have at least 5 dummy cycles when using memories with DQS activated.


\
\ @brief HSPI write instruction register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_WIR_INSTRUCTION                       \ Instruction Instruction to be sent to the external SPI device


\
\ @brief HSPI write alternate bytes register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant HSPI1_HSPI_WABR_ALTERNATE                        \ [31: 0]: Alternate bytes Optional data to be sent to the external SPI device right after the address


\
\ @brief HSPI HyperBus latency configuration register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant HSPI1_HSPI_HLCR_LM                               \ Latency mode This bit selects the Latency mode.
$00000002 constant HSPI1_HSPI_HLCR_WZL                              \ Write zero latency This bit enables zero latency on write operations.
$0000ff00 constant HSPI1_HSPI_HLCR_TACC                             \ [7: 0]: Access time Device access time expressed in number of communication clock cycles
$00ff0000 constant HSPI1_HSPI_HLCR_TRWR                             \ Read write recovery time Device read write recovery time expressed in number of communication clock cycles


\
\ @brief HSPI full-cycle calibration configuration
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0000007f constant HSPI1_HSPI_CALFCR_FINE                           \ [6: 0]: Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$001f0000 constant HSPI1_HSPI_CALFCR_COARSE                         \ [4: 0]: Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$80000000 constant HSPI1_HSPI_CALFCR_CALMAX                         \ Max value This bit gets set when the memory-clock period is outside the range of DLLM, in which case HSPI_CALFCR and HSPI_CALSR are updated with the values for the maximum delay.


\
\ @brief HSPI DLL master calibration configuration
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000007f constant HSPI1_HSPI_CALMR_FINE                            \ [6: 0]: Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$001f0000 constant HSPI1_HSPI_CALMR_COARSE                          \ [4: 0]: Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).


\
\ @brief HSPI DLL slave output calibration configuration
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000007f constant HSPI1_HSPI_CALSOR_FINE                           \ [6: 0]: Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$001f0000 constant HSPI1_HSPI_CALSOR_COARSE                         \ [4: 0]: Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).


\
\ @brief HSPI DLL slave input calibration configuration
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$0000007f constant HSPI1_HSPI_CALSIR_FINE                           \ [6: 0]: Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$001f0000 constant HSPI1_HSPI_CALSIR_COARSE                         \ [4: 0]: Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).


\
\ @brief HSPI1
\
$420d3400 constant HSPI1_HSPI_CR  \ offset: 0x00 : HSPI control register
$420d3408 constant HSPI1_HSPI_DCR1  \ offset: 0x08 : HSPI device configuration register 1
$420d340c constant HSPI1_HSPI_DCR2  \ offset: 0x0C : HSPI device configuration register 2
$420d3410 constant HSPI1_HSPI_DCR3  \ offset: 0x10 : HSPI device configuration register 3
$420d3414 constant HSPI1_HSPI_DCR4  \ offset: 0x14 : HSPI device configuration register 4
$420d3420 constant HSPI1_HSPI_SR  \ offset: 0x20 : Transfer error flag This bit is set in Indirect mode when an invalid address is being accessed in Indirect mode. It is cleared by writing 1 to CTEF.
$420d3424 constant HSPI1_HSPI_FCR  \ offset: 0x24 : Clear transfer error flag Writing 1 clears the TEF flag in the HSPI_SR register.
$420d3440 constant HSPI1_HSPI_DLR  \ offset: 0x40 : HSPI data length register
$420d3448 constant HSPI1_HSPI_AR  \ offset: 0x48 : Address Address to be sent to the external device. In HyperBus mode, this field must be even as this protocol is 16-bit word oriented. In dual-memory mode, AR[0] is forced to 1. Writes to this field are ignored when BUSYÂ =Â 1 or when FMODE = 11 (Memory-mapped mode).
$420d3450 constant HSPI1_HSPI_DR  \ offset: 0x50 : [31: 0]: Data Data to be sent/received to/from the external SPI device In Indirect-write mode, data written to this register is stored on the FIFO before it is sent to the external device during the data phase. If the FIFO is too full, a write operation is stalled until the FIFO has enough space to accept the amount of data being written. In Indirect-read mode, reading this register gives (via the FIFO) the data that was received from the external device. If the FIFO does not have as many bytes as requested by the read operation and if BUSYÂ =Â 1, the read operation is stalled until enough data is present or until the transfer is complete, whichever happens first. In Automatic-polling mode, this register contains the last data read from the external device (without masking). Word, half-word, and byte accesses to this register are supported. In Indirect-write mode, a byte write adds 1 byte to the FIFO, a half-word write 2 bytes, and a word write 4 bytes. Similarly, in Indirect-read mode, a byte read removes 1 byte from the FIFO, a halfword read 2Â bytes, and a word read 4Â bytes. Accesses in Indirect mode must be aligned to the bottom of this register: A byte read must read DATA[7:0] and a half-word read must read DATA[15:0].
$420d3480 constant HSPI1_HSPI_PSMKR  \ offset: 0x80 : HSPI polling status mask register
$420d3488 constant HSPI1_HSPI_PSMAR  \ offset: 0x88 : HSPI polling status match register
$420d3490 constant HSPI1_HSPI_PIR  \ offset: 0x90 : HSPI polling interval register
$420d3500 constant HSPI1_HSPI_CCR  \ offset: 0x100 : HSPI communication configuration register
$420d3508 constant HSPI1_HSPI_TCR  \ offset: 0x108 : HSPI timing configuration register
$420d3510 constant HSPI1_HSPI_IR  \ offset: 0x110 : HSPI instruction register
$420d3520 constant HSPI1_HSPI_ABR  \ offset: 0x120 : HSPI alternate bytes register
$420d3530 constant HSPI1_HSPI_LPTR  \ offset: 0x130 : HSPI low-power timeout register
$420d3540 constant HSPI1_HSPI_WPCCR  \ offset: 0x140 : HSPI wrap communication configuration register
$420d3548 constant HSPI1_HSPI_WPTCR  \ offset: 0x148 : HSPI wrap timing configuration register
$420d3550 constant HSPI1_HSPI_WPIR  \ offset: 0x150 : HSPI wrap instruction register
$420d3560 constant HSPI1_HSPI_WPABR  \ offset: 0x160 : HSPI wrap alternate bytes register
$420d3580 constant HSPI1_HSPI_WCCR  \ offset: 0x180 : HSPI write communication configuration register
$420d3588 constant HSPI1_HSPI_WTCR  \ offset: 0x188 : HSPI write timing configuration register
$420d3590 constant HSPI1_HSPI_WIR  \ offset: 0x190 : HSPI write instruction register
$420d35a0 constant HSPI1_HSPI_WABR  \ offset: 0x1A0 : HSPI write alternate bytes register
$420d3600 constant HSPI1_HSPI_HLCR  \ offset: 0x200 : HSPI HyperBus latency configuration register
$420d3610 constant HSPI1_HSPI_CALFCR  \ offset: 0x210 : HSPI full-cycle calibration configuration
$420d3618 constant HSPI1_HSPI_CALMR  \ offset: 0x218 : HSPI DLL master calibration configuration
$420d3620 constant HSPI1_HSPI_CALSOR  \ offset: 0x220 : HSPI DLL slave output calibration configuration
$420d3628 constant HSPI1_HSPI_CALSIR  \ offset: 0x228 : HSPI DLL slave input calibration configuration

