\
\ @file xspi1.fs
\ @brief XSPI register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief XSPI control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_XSPI_CR_EN                                 \ Enable This bit enables the XSPI. The DMA request can be aborted without having received the ACK in case this EN bit is cleared during the operation. Note: In case this bit is set to 0 during a DMA transfer, the REQ signal to DMA returns to inactive state without waiting for the ACK signal from DMA to be active.
$00000002 constant XSPI1_XSPI_CR_ABORT                              \ Abort request This bit aborts the on-going command sequence. It is automatically reset once the abort is completed. This bit stops the current transfer. Note: This bit is always read as 0.
$00000004 constant XSPI1_XSPI_CR_DMAEN                              \ DMA enable In indirect mode, the DMA can be used to input or output data via XSPI_DR. DMA transfers are initiated when FTF is set. Note: Resetting the DMAEN bit while a DMA transfer is ongoing, breaks the handshake with the DMA. Do not write this bit during DMA operation.
$00000008 constant XSPI1_XSPI_CR_TCEN                               \ Timeout counter enable This bit is valid only when the memory-mapped mode (FMODE[1:0] = 11) is selected. This bit enables the timeout counter. Note: This bit can be modified only when BUSY = 0.
$00000040 constant XSPI1_XSPI_CR_DMM                                \ Dual-memory configuration This bit activates the dual-memory configuration, where two external devices are used simultaneously to double the throughput and the capacity Note: This bit can be modified only when BUSY = 0.
$00003f00 constant XSPI1_XSPI_CR_FTHRES                             \ FIFO threshold level This field defines, in indirect mode, the threshold number of bytes in the FIFO that causes the FIFO threshold flag FTF in XSPI_SR, to be set. ... Note: If DMAEN = 1, the DMA controller for the corresponding channel must be disabled before changing the FTHRES[5:0] value.
$00010000 constant XSPI1_XSPI_CR_TEIE                               \ Transfer error interrupt enable This bit enables the transfer error interrupt.
$00020000 constant XSPI1_XSPI_CR_TCIE                               \ Transfer complete interrupt enable This bit enables the transfer complete interrupt.
$00040000 constant XSPI1_XSPI_CR_FTIE                               \ FIFO threshold interrupt enable This bit enables the FIFO threshold interrupt.
$00080000 constant XSPI1_XSPI_CR_SMIE                               \ Status match interrupt enable This bit enables the status match interrupt.
$00100000 constant XSPI1_XSPI_CR_TOIE                               \ Timeout interrupt enable This bit enables the timeout interrupt.
$00400000 constant XSPI1_XSPI_CR_APMS                               \ Automatic status-polling mode stop This bit determines if the automatic status-polling is stopped after a match. Note: This bit can be modified only when BUSY = 0.
$00800000 constant XSPI1_XSPI_CR_PMM                                \ Polling match mode This bit indicates which method must be used to determine a match during the automatic status-polling mode. Note: This bit can be modified only when BUSY = 0.
$01000000 constant XSPI1_XSPI_CR_CSSEL                              \ chip select selection This bit indicates if the XSPI must activate NCS1 or NCS2. Note: This bit can be modified only when BUSY = 0.
$30000000 constant XSPI1_XSPI_CR_FMODE                              \ Functional mode This field defines the XSPI functional mode of operation. If DMAEN = 1 already, then the DMA controller for the corresponding channel must be disabled before changing the FMODE[1:0] value. If FMODE[1:0] and FTHRES[4:0] are wrongly updated while DMAEN = 1, the DMA request signal automatically goes to inactive state. Note: This bitfield can be modified only when BUSY = 0.
$c0000000 constant XSPI1_XSPI_CR_MSEL                               \ Flash select


\
\ @brief XSPI device configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_XSPI_DCR1_CKMODE                           \ clock mode 0/mode 3 This bit indicates the level taken by the CLK between commands (when NCS = 1).
$00000002 constant XSPI1_XSPI_DCR1_FRCK                             \ Free running clock This bit configures the free running clock.
$00003f00 constant XSPI1_XSPI_DCR1_CSHT                             \ Chip-select high time CSHT + 1 defines the minimum number of CLK cycles where the chip-select (NCS) must remain high between commands issued to the external device. ...
$001f0000 constant XSPI1_XSPI_DCR1_DEVSIZE                          \ Device size This field defines the size of the external device using the following formula: Number of bytes in device = 2<sup>[DEVSIZE+1]</sup>. DEVSIZE+1 is effectively the number of address bits required to address the external device. The device capacity can be up to 4 Gbytes (addressed using 32-bits) in indirect mode, but the addressable space in memory-mapped mode is limited to 256 Mbytes. In regular-command protocol, if DMM = 1, DEVSIZE[4:0] indicates the total capacity of the two devices together.
$07000000 constant XSPI1_XSPI_DCR1_MTYP                             \ Memory type This bit indicates the type of memory to be supported. Note: In this mode, DQS signal polarity is inverted with respect to the memory clock signal. This is the default value and care must be taken to change MTYP[2:0] for memories different from Micron. Others: Reserved


\
\ @brief XSPI device configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant XSPI1_XSPI_DCR2_PRESCALER                        \ Clock prescaler This field defines the scaler factor for generating the CLK based on the kernel clock (value + 1). ... For odd clock division factors, the CLK duty cycle is not 50 %. The clock signal remains low one cycle longer than it stays high. Writing this field automatically starts a new calibration of high-speed interface DLL at the start of next transfer, except in case XSPI_CALOSR or XSPI_CALISR have been written in the meantime. BUSY stays high during the whole calibration execution.
$00070000 constant XSPI1_XSPI_DCR2_WRAPSIZE                         \ Wrap size This field indicates the wrap size to which the memory is configured. For memories which have a separate command for wrapped instructions, this field indicates the wrap-size associated with the command held in XSPI_WPIR. Others: reserved


\
\ @brief XSPI device configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant XSPI1_XSPI_DCR3_MAXTRAN                          \ Maximum transfer This field enables the communication regulation feature. The NCS is released every MAXTRAN+1 clock cycles when the other XSPI request the access to the bus. Others: maximum communication is set to MAXTRAN + 1 bytes.
$001f0000 constant XSPI1_XSPI_DCR3_CSBOUND                          \ NCS boundary This field enables the transaction boundary feature. When active, a minimum value of 3 is recommended. The NCS is released on each boundary of 2<sup>CSBOUND</sup> bytes. Others: NCS boundary set to 2<sup>CSBOUND</sup> bytes


\
\ @brief XSPI device configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_DCR4_REFRESH                          \ Refresh rate This field enables the refresh rate feature. The NCS is released every REFRESH + 1 clock cycles for writes, and REFRESH + 4 clock cycles for reads. Note: These two values can be extended with few clock cycles when refresh occurs during a byte transmission in single-, dual- or quad-SPI mode, because the byte transmission must be completed. Others: maximum communication length is set to REFRESH + 1 clock cycles.


\
\ @brief XSPI status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_XSPI_SR_TEF                                \ Transfer error flag This bit is set in indirect mode when an invalid address is being accessed in indirect mode. It is cleared by writing 1 to CTEF.
$00000002 constant XSPI1_XSPI_SR_TCF                                \ Transfer complete flag This bit is set in indirect mode when the programmed number of data has been transferred or in any mode when the transfer has been aborted.It is cleared by writing 1 to CTCF.
$00000004 constant XSPI1_XSPI_SR_FTF                                \ FIFO threshold flag In indirect mode, this bit is set when the FIFO threshold has been reached, or if there is any data left in the FIFO after the reads from the external device are complete. It is cleared automatically as soon as the threshold condition is no longer true. In automatic status-polling mode this bit is set every time the status register is read, and the bit is cleared when the data register is read.
$00000008 constant XSPI1_XSPI_SR_SMF                                \ Status match flag This bit is set in automatic status-polling mode when the unmasked received data matches the corresponding bits in the match register (XSPI_PSMAR). It is cleared by writing 1 to CSMF.
$00000010 constant XSPI1_XSPI_SR_TOF                                \ Timeout flag This bit is set when timeout occurs. It is cleared by writing 1 to CTOF.
$00000020 constant XSPI1_XSPI_SR_BUSY                               \ Busy This bit is set when an operation is ongoing. It is cleared automatically when the operation with the external device is finished and the FIFO is empty.
$00007f00 constant XSPI1_XSPI_SR_FLEVEL                             \ FIFO level This field gives the number of valid bytes that are being held in the FIFO. FLEVEL = 0 when the FIFO is empty, and 64 when it is full. In automatic-status polling mode, FLEVEL is zero.


\
\ @brief XSPI flag clear register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_XSPI_FCR_CTEF                              \ Clear transfer error flag Writing 1 clears the TEF flag in the XSPI_SR register.
$00000002 constant XSPI1_XSPI_FCR_CTCF                              \ Clear transfer complete flag Writing 1 clears the TCF flag in the XSPI_SR register.
$00000008 constant XSPI1_XSPI_FCR_CSMF                              \ Clear status match flag Writing 1 clears the SMF flag in the XSPI_SR register.
$00000010 constant XSPI1_XSPI_FCR_CTOF                              \ Clear timeout flag Writing 1 clears the TOF flag in the XSPI_SR register.


\
\ @brief XSPI data length register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_DLR_DL                                \ Data length


\
\ @brief XSPIaddress register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_AR_ADDRESS                            \ Address Address to be sent to the external device. In HyperBus protocol, this field must be even as this protocol is 16-bit word oriented. In dual-memory configuration, AR[0] is forced to 0. Writes to this field are ignored when BUSY = 1 or when FMODE = 11 (memory-mapped mode). Some memory specifications consider that each address corresponds to a 16-bit value. XSPI considers that each address corresponds to an 8-bit value. So the software needs to multiple the address by two when accessing the memory registers.


\
\ @brief XSPI data register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_DR_DATA                               \ Data Data to be sent/received to/from the external SPI device In indirect-write mode, data written to this register is stored on the FIFO before it is sent to the external device during the data phase. If the FIFO is too full, a write operation is stalled until the FIFO has enough space to accept the amount of data being written. In indirect-read mode, reading this register gives (via the FIFO) the data that was received from the external device. If the FIFO does not have as many bytes as requested by the read operation and if BUSY = 1, the read operation is stalled until enough data is present or until the transfer is complete, whichever happens first. In automatic status-polling mode, this register contains the last data read from the external device (without masking). Word, half-word, and byte accesses to this register are supported. In indirect-write mode, a byte write adds 1 byte to the FIFO, a half-word write 2 bytes, and a word write 4 bytes. Similarly, in indirect-read mode, a byte read removes 1 byte from the FIFO, a halfword read 2 bytes, and a word read 4 bytes. Accesses in indirect mode must be aligned to the bottom of this register: A byte read must read DATA[7:0] and a half-word read must read DATA[15:0].


\
\ @brief XSPI polling status mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_PSMKR_MASK                            \ Status mask Mask to be applied to the status bytes received in automatic status-polling mode For bit n:


\
\ @brief XSPI polling status match register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_PSMAR_MATCH                           \ Status match Value to be compared with the masked status register to get a match


\
\ @brief XSPI polling interval register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant XSPI1_XSPI_PIR_INTERVAL                          \ Polling interval Number of CLK cycle between a read during the automatic status-polling phases


\
\ @brief XSPI communication configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant XSPI1_XSPI_CCR_IMODE                             \ Instruction mode This field defines the instruction phase mode of operation. Others: reserved
$00000008 constant XSPI1_XSPI_CCR_IDTR                              \ Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
$00000030 constant XSPI1_XSPI_CCR_ISIZE                             \ Instruction size This bit defines instruction size.
$00000700 constant XSPI1_XSPI_CCR_ADMODE                            \ Address mode This field defines the address phase mode of operation. Others: reserved
$00000800 constant XSPI1_XSPI_CCR_ADDTR                             \ Address double transfer rate This bit sets the DTR mode for the address phase.
$00003000 constant XSPI1_XSPI_CCR_ADSIZE                            \ Address size This field defines address size.
$00070000 constant XSPI1_XSPI_CCR_ABMODE                            \ Alternate-byte mode This field defines the alternate byte phase mode of operation. Others: reserved
$00080000 constant XSPI1_XSPI_CCR_ABDTR                             \ Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase. Note: This field can be written only when BUSY = 0.
$00300000 constant XSPI1_XSPI_CCR_ABSIZE                            \ Alternate bytes size This bit defines alternate bytes size.
$07000000 constant XSPI1_XSPI_CCR_DMODE                             \ Data mode This field defines the data phase mode of operation. Others: reserved
$08000000 constant XSPI1_XSPI_CCR_DDTR                              \ Data double transfer rate This bit sets the DTR mode for the data phase.
$20000000 constant XSPI1_XSPI_CCR_DQSE                              \ DQS enable This bit enables the data strobe management.


\
\ @brief XSPI timing configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant XSPI1_XSPI_TCR_DCYC                              \ Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31).
$10000000 constant XSPI1_XSPI_TCR_DHQC                              \ Delay hold quarter cycle
$40000000 constant XSPI1_XSPI_TCR_SSHIFT                            \ Sample shift By default, the XSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The software must ensure that SSHIFT = 0 when the data phase is configured in DTR mode (when DDTR = 1.)


\
\ @brief XSPI instruction register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_IR_INSTRUCTION                        \ Instruction Instruction to be sent to the external SPI device


\
\ @brief XSPI alternate bytes register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_ABR_ALTERNATE                         \ Alternate bytes Optional data to be sent to the external SPI device right after the address.


\
\ @brief XSPI low-power timeout register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000ffff constant XSPI1_XSPI_LPTR_TIMEOUT                          \ Timeout period After each access in memory-mapped mode, the XSPI prefetches the subsequent bytes and hold them in the FIFO. This field indicates how many CLK cycles the XSPI waits after the clock becomes inactive and until it raises the NCS, putting the external device in a lower-consumption state.


\
\ @brief XSPI wrap communication configuration register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000007 constant XSPI1_XSPI_WPCCR_IMODE                           \ Instruction mode This field defines the instruction phase mode of operation. Others: reserved
$00000008 constant XSPI1_XSPI_WPCCR_IDTR                            \ Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
$00000030 constant XSPI1_XSPI_WPCCR_ISIZE                           \ Instruction size This field defines instruction size.
$00000700 constant XSPI1_XSPI_WPCCR_ADMODE                          \ Address mode This field defines the address phase mode of operation. Others: reserved
$00000800 constant XSPI1_XSPI_WPCCR_ADDTR                           \ Address double transfer rate This bit sets the DTR mode for the address phase.
$00003000 constant XSPI1_XSPI_WPCCR_ADSIZE                          \ Address size This field defines address size.
$00070000 constant XSPI1_XSPI_WPCCR_ABMODE                          \ Alternate-byte mode This field defines the alternate byte phase mode of operation.
$00080000 constant XSPI1_XSPI_WPCCR_ABDTR                           \ Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase.
$00300000 constant XSPI1_XSPI_WPCCR_ABSIZE                          \ Alternate bytes size This bit defines alternate bytes size.
$07000000 constant XSPI1_XSPI_WPCCR_DMODE                           \ Data mode This field defines the data phase mode of operation. 101; data on 16 lines Others: reserved
$08000000 constant XSPI1_XSPI_WPCCR_DDTR                            \ Data double transfer rate This bit sets the DTR mode for the data phase.
$20000000 constant XSPI1_XSPI_WPCCR_DQSE                            \ DQS enable This bit enables the data strobe management.


\
\ @brief XSPI wrap timing configuration register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000001f constant XSPI1_XSPI_WPTCR_DCYC                            \ Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31).
$10000000 constant XSPI1_XSPI_WPTCR_DHQC                            \ Delay hold quarter cycle Add a quarter cycle delay on the outputs in DTR communication to match hold requirement.
$40000000 constant XSPI1_XSPI_WPTCR_SSHIFT                          \ Sample shift By default, the XSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The firmware must assure that SSHIFT=0 when the data phase is configured in DTR mode (when DDTR = 1).


\
\ @brief XSPI wrap instruction register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_WPIR_INSTRUCTION                      \ Instruction Instruction to be sent to the external SPI device


\
\ @brief XSPI wrap alternate byte register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_WPABR_ALTERNATE                       \ Alternate bytes Optional data to be sent to the external SPI device right after the address


\
\ @brief XSPI write communication configuration register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000007 constant XSPI1_XSPI_WCCR_IMODE                            \ Instruction mode This field defines the instruction phase mode of operation. Others: reserved
$00000008 constant XSPI1_XSPI_WCCR_IDTR                             \ Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
$00000030 constant XSPI1_XSPI_WCCR_ISIZE                            \ Instruction size This bit defines instruction size:
$00000700 constant XSPI1_XSPI_WCCR_ADMODE                           \ Address mode This field defines the address phase mode of operation. Others: reserved
$00000800 constant XSPI1_XSPI_WCCR_ADDTR                            \ Address double transfer rate This bit sets the DTR mode for the address phase.
$00003000 constant XSPI1_XSPI_WCCR_ADSIZE                           \ Address size This field defines address size.
$00070000 constant XSPI1_XSPI_WCCR_ABMODE                           \ Alternate-byte mode This field defines the alternate-byte phase mode of operation. Others: reserved
$00080000 constant XSPI1_XSPI_WCCR_ABDTR                            \ Alternate bytes double-transfer rate This bit sets the DTR mode for the alternate-bytes phase.
$00300000 constant XSPI1_XSPI_WCCR_ABSIZE                           \ Alternate bytes size This field defines alternate bytes size:
$07000000 constant XSPI1_XSPI_WCCR_DMODE                            \ Data mode This field defines the data phase mode of operation.
$08000000 constant XSPI1_XSPI_WCCR_DDTR                             \ data double transfer rate This bit sets the DTR mode for the data phase.
$20000000 constant XSPI1_XSPI_WCCR_DQSE                             \ DQS enable This bit enables the data strobe management.


\
\ @brief XSPI write timing configuration register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000001f constant XSPI1_XSPI_WTCR_DCYC                             \ Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31). It is recommended to have at least 5 dummy cycles when using memories with DQS activated.


\
\ @brief XSPI write instruction register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_WIR_INSTRUCTION                       \ Instruction Instruction to be sent to the external SPI device


\
\ @brief XSPI write alternate byte register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_XSPI_WABR_ALTERNATE                        \ Alternate bytes Optional data to be sent to the external SPI device right after the address


\
\ @brief XSPI HyperBus latency configuration register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_XSPI_HLCR_LM                               \ Latency mode This bit selects the Latency mode. Note: This bit must be set when using the dual-octal HyperBus configuration.
$00000002 constant XSPI1_XSPI_HLCR_WZL                              \ Write zero latency This bit enables zero latency on write operations.
$0000ff00 constant XSPI1_XSPI_HLCR_TACC                             \ Access time Device access time expressed in number of communication clock cycles
$00ff0000 constant XSPI1_XSPI_HLCR_TRWR                             \ Read write recovery time Device read write recovery time expressed in number of communication clock cycles


\
\ @brief XSPI full-cycle calibration configuration
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0000007f constant XSPI1_XSPI_CALFCR_FINE                           \ Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$001f0000 constant XSPI1_XSPI_CALFCR_COARSE                         \ Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$80000000 constant XSPI1_XSPI_CALFCR_CALMAX                         \ Max value This bit gets set when the memory-clock period is outside the range of DLL master, in which case XSPI_CALFCR and XSPI_CALSR are updated with the values for the maximum delay.


\
\ @brief XSPI DLL master calibration configuration
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000007f constant XSPI1_XSPI_CALMR_FINE                            \ Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$001f0000 constant XSPI1_XSPI_CALMR_COARSE                          \ Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).


\
\ @brief XSPI DLL slave output calibration configuration
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000007f constant XSPI1_XSPI_CALSOR_FINE                           \ Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$001f0000 constant XSPI1_XSPI_CALSOR_COARSE                         \ Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).


\
\ @brief XSPI DLL slave input calibration configuration
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$0000007f constant XSPI1_XSPI_CALSIR_FINE                           \ Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
$001f0000 constant XSPI1_XSPI_CALSIR_COARSE                         \ Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).


\
\ @brief XSPI register block
\
$52005000 constant XSPI1_XSPI_CR  \ offset: 0x00 : XSPI control register
$52005008 constant XSPI1_XSPI_DCR1  \ offset: 0x08 : XSPI device configuration register 1
$5200500c constant XSPI1_XSPI_DCR2  \ offset: 0x0C : XSPI device configuration register 2
$52005010 constant XSPI1_XSPI_DCR3  \ offset: 0x10 : XSPI device configuration register 3
$52005014 constant XSPI1_XSPI_DCR4  \ offset: 0x14 : XSPI device configuration register 4
$52005020 constant XSPI1_XSPI_SR  \ offset: 0x20 : XSPI status register
$52005024 constant XSPI1_XSPI_FCR  \ offset: 0x24 : XSPI flag clear register
$52005040 constant XSPI1_XSPI_DLR  \ offset: 0x40 : XSPI data length register
$52005048 constant XSPI1_XSPI_AR  \ offset: 0x48 : XSPIaddress register
$52005050 constant XSPI1_XSPI_DR  \ offset: 0x50 : XSPI data register
$52005080 constant XSPI1_XSPI_PSMKR  \ offset: 0x80 : XSPI polling status mask register
$52005088 constant XSPI1_XSPI_PSMAR  \ offset: 0x88 : XSPI polling status match register
$52005090 constant XSPI1_XSPI_PIR  \ offset: 0x90 : XSPI polling interval register
$52005100 constant XSPI1_XSPI_CCR  \ offset: 0x100 : XSPI communication configuration register
$52005108 constant XSPI1_XSPI_TCR  \ offset: 0x108 : XSPI timing configuration register
$52005110 constant XSPI1_XSPI_IR  \ offset: 0x110 : XSPI instruction register
$52005120 constant XSPI1_XSPI_ABR  \ offset: 0x120 : XSPI alternate bytes register
$52005130 constant XSPI1_XSPI_LPTR  \ offset: 0x130 : XSPI low-power timeout register
$52005140 constant XSPI1_XSPI_WPCCR  \ offset: 0x140 : XSPI wrap communication configuration register
$52005148 constant XSPI1_XSPI_WPTCR  \ offset: 0x148 : XSPI wrap timing configuration register
$52005150 constant XSPI1_XSPI_WPIR  \ offset: 0x150 : XSPI wrap instruction register
$52005160 constant XSPI1_XSPI_WPABR  \ offset: 0x160 : XSPI wrap alternate byte register
$52005180 constant XSPI1_XSPI_WCCR  \ offset: 0x180 : XSPI write communication configuration register
$52005188 constant XSPI1_XSPI_WTCR  \ offset: 0x188 : XSPI write timing configuration register
$52005190 constant XSPI1_XSPI_WIR  \ offset: 0x190 : XSPI write instruction register
$520051a0 constant XSPI1_XSPI_WABR  \ offset: 0x1A0 : XSPI write alternate byte register
$52005200 constant XSPI1_XSPI_HLCR  \ offset: 0x200 : XSPI HyperBus latency configuration register
$52005210 constant XSPI1_XSPI_CALFCR  \ offset: 0x210 : XSPI full-cycle calibration configuration
$52005218 constant XSPI1_XSPI_CALMR  \ offset: 0x218 : XSPI DLL master calibration configuration
$52005220 constant XSPI1_XSPI_CALSOR  \ offset: 0x220 : XSPI DLL slave output calibration configuration
$52005228 constant XSPI1_XSPI_CALSIR  \ offset: 0x228 : XSPI DLL slave input calibration configuration

