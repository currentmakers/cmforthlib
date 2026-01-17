\
\ @file xspi.fs
\ @brief XSPI register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] XSPI_DEF

  [ifdef] XSPI_XSPI_CR_DEF
    \
    \ @brief XSPI control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_EN                        \ [0x00] Enable This bit enables the XSPI. The DMA request can be aborted without having received the ACK in case this EN bit is cleared during the operation. Note: In case this bit is set to 0 during a DMA transfer, the REQ signal to DMA returns to inactive state without waiting for the ACK signal from DMA to be active.
    $01 constant XSPI_ABORT                     \ [0x01] Abort request This bit aborts the on-going command sequence. It is automatically reset once the abort is completed. This bit stops the current transfer. Note: This bit is always read as 0.
    $02 constant XSPI_DMAEN                     \ [0x02] DMA enable In indirect mode, the DMA can be used to input or output data via XSPI_DR. DMA transfers are initiated when FTF is set. Note: Resetting the DMAEN bit while a DMA transfer is ongoing, breaks the handshake with the DMA. Do not write this bit during DMA operation.
    $03 constant XSPI_TCEN                      \ [0x03] Timeout counter enable This bit is valid only when the memory-mapped mode (FMODE[1:0] = 11) is selected. This bit enables the timeout counter. Note: This bit can be modified only when BUSY = 0.
    $06 constant XSPI_DMM                       \ [0x06] Dual-memory configuration This bit activates the dual-memory configuration, where two external devices are used simultaneously to double the throughput and the capacity Note: This bit can be modified only when BUSY = 0.
    $08 constant XSPI_FTHRES                    \ [0x08 : 6] FIFO threshold level This field defines, in indirect mode, the threshold number of bytes in the FIFO that causes the FIFO threshold flag FTF in XSPI_SR, to be set. ... Note: If DMAEN = 1, the DMA controller for the corresponding channel must be disabled before changing the FTHRES[5:0] value.
    $10 constant XSPI_TEIE                      \ [0x10] Transfer error interrupt enable This bit enables the transfer error interrupt.
    $11 constant XSPI_TCIE                      \ [0x11] Transfer complete interrupt enable This bit enables the transfer complete interrupt.
    $12 constant XSPI_FTIE                      \ [0x12] FIFO threshold interrupt enable This bit enables the FIFO threshold interrupt.
    $13 constant XSPI_SMIE                      \ [0x13] Status match interrupt enable This bit enables the status match interrupt.
    $14 constant XSPI_TOIE                      \ [0x14] Timeout interrupt enable This bit enables the timeout interrupt.
    $16 constant XSPI_APMS                      \ [0x16] Automatic status-polling mode stop This bit determines if the automatic status-polling is stopped after a match. Note: This bit can be modified only when BUSY = 0.
    $17 constant XSPI_PMM                       \ [0x17] Polling match mode This bit indicates which method must be used to determine a match during the automatic status-polling mode. Note: This bit can be modified only when BUSY = 0.
    $18 constant XSPI_CSSEL                     \ [0x18] chip select selection This bit indicates if the XSPI must activate NCS1 or NCS2. Note: This bit can be modified only when BUSY = 0.
    $1c constant XSPI_FMODE                     \ [0x1c : 2] Functional mode This field defines the XSPI functional mode of operation. If DMAEN = 1 already, then the DMA controller for the corresponding channel must be disabled before changing the FMODE[1:0] value. If FMODE[1:0] and FTHRES[4:0] are wrongly updated while DMAEN = 1, the DMA request signal automatically goes to inactive state. Note: This bitfield can be modified only when BUSY = 0.
    $1e constant XSPI_MSEL                      \ [0x1e : 2] Flash select
  [then]


  [ifdef] XSPI_XSPI_DCR1_DEF
    \
    \ @brief XSPI device configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_CKMODE                    \ [0x00] clock mode 0/mode 3 This bit indicates the level taken by the CLK between commands (when NCS = 1).
    $01 constant XSPI_FRCK                      \ [0x01] Free running clock This bit configures the free running clock.
    $08 constant XSPI_CSHT                      \ [0x08 : 6] Chip-select high time CSHT + 1 defines the minimum number of CLK cycles where the chip-select (NCS) must remain high between commands issued to the external device. ...
    $10 constant XSPI_DEVSIZE                   \ [0x10 : 5] Device size This field defines the size of the external device using the following formula: Number of bytes in device = 2<sup>[DEVSIZE+1]</sup>. DEVSIZE+1 is effectively the number of address bits required to address the external device. The device capacity can be up to 4 Gbytes (addressed using 32-bits) in indirect mode, but the addressable space in memory-mapped mode is limited to 256 Mbytes. In regular-command protocol, if DMM = 1, DEVSIZE[4:0] indicates the total capacity of the two devices together.
    $18 constant XSPI_MTYP                      \ [0x18 : 3] Memory type This bit indicates the type of memory to be supported. Note: In this mode, DQS signal polarity is inverted with respect to the memory clock signal. This is the default value and care must be taken to change MTYP[2:0] for memories different from Micron. Others: Reserved
  [then]


  [ifdef] XSPI_XSPI_DCR2_DEF
    \
    \ @brief XSPI device configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_PRESCALER                 \ [0x00 : 8] Clock prescaler This field defines the scaler factor for generating the CLK based on the kernel clock (value + 1). ... For odd clock division factors, the CLK duty cycle is not 50 %. The clock signal remains low one cycle longer than it stays high. Writing this field automatically starts a new calibration of high-speed interface DLL at the start of next transfer, except in case XSPI_CALOSR or XSPI_CALISR have been written in the meantime. BUSY stays high during the whole calibration execution.
    $10 constant XSPI_WRAPSIZE                  \ [0x10 : 3] Wrap size This field indicates the wrap size to which the memory is configured. For memories which have a separate command for wrapped instructions, this field indicates the wrap-size associated with the command held in XSPI_WPIR. Others: reserved
  [then]


  [ifdef] XSPI_XSPI_DCR3_DEF
    \
    \ @brief XSPI device configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_MAXTRAN                   \ [0x00 : 8] Maximum transfer This field enables the communication regulation feature. The NCS is released every MAXTRAN+1 clock cycles when the other XSPI request the access to the bus. Others: maximum communication is set to MAXTRAN + 1 bytes.
    $10 constant XSPI_CSBOUND                   \ [0x10 : 5] NCS boundary This field enables the transaction boundary feature. When active, a minimum value of 3 is recommended. The NCS is released on each boundary of 2<sup>CSBOUND</sup> bytes. Others: NCS boundary set to 2<sup>CSBOUND</sup> bytes
  [then]


  [ifdef] XSPI_XSPI_DCR4_DEF
    \
    \ @brief XSPI device configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_REFRESH                   \ [0x00 : 32] Refresh rate This field enables the refresh rate feature. The NCS is released every REFRESH + 1 clock cycles for writes, and REFRESH + 4 clock cycles for reads. Note: These two values can be extended with few clock cycles when refresh occurs during a byte transmission in single-, dual- or quad-SPI mode, because the byte transmission must be completed. Others: maximum communication length is set to REFRESH + 1 clock cycles.
  [then]


  [ifdef] XSPI_XSPI_SR_DEF
    \
    \ @brief XSPI status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_TEF                       \ [0x00] Transfer error flag This bit is set in indirect mode when an invalid address is being accessed in indirect mode. It is cleared by writing 1 to CTEF.
    $01 constant XSPI_TCF                       \ [0x01] Transfer complete flag This bit is set in indirect mode when the programmed number of data has been transferred or in any mode when the transfer has been aborted.It is cleared by writing 1 to CTCF.
    $02 constant XSPI_FTF                       \ [0x02] FIFO threshold flag In indirect mode, this bit is set when the FIFO threshold has been reached, or if there is any data left in the FIFO after the reads from the external device are complete. It is cleared automatically as soon as the threshold condition is no longer true. In automatic status-polling mode this bit is set every time the status register is read, and the bit is cleared when the data register is read.
    $03 constant XSPI_SMF                       \ [0x03] Status match flag This bit is set in automatic status-polling mode when the unmasked received data matches the corresponding bits in the match register (XSPI_PSMAR). It is cleared by writing 1 to CSMF.
    $04 constant XSPI_TOF                       \ [0x04] Timeout flag This bit is set when timeout occurs. It is cleared by writing 1 to CTOF.
    $05 constant XSPI_BUSY                      \ [0x05] Busy This bit is set when an operation is ongoing. It is cleared automatically when the operation with the external device is finished and the FIFO is empty.
    $08 constant XSPI_FLEVEL                    \ [0x08 : 7] FIFO level This field gives the number of valid bytes that are being held in the FIFO. FLEVEL = 0 when the FIFO is empty, and 64 when it is full. In automatic-status polling mode, FLEVEL is zero.
  [then]


  [ifdef] XSPI_XSPI_FCR_DEF
    \
    \ @brief XSPI flag clear register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_CTEF                      \ [0x00] Clear transfer error flag Writing 1 clears the TEF flag in the XSPI_SR register.
    $01 constant XSPI_CTCF                      \ [0x01] Clear transfer complete flag Writing 1 clears the TCF flag in the XSPI_SR register.
    $03 constant XSPI_CSMF                      \ [0x03] Clear status match flag Writing 1 clears the SMF flag in the XSPI_SR register.
    $04 constant XSPI_CTOF                      \ [0x04] Clear timeout flag Writing 1 clears the TOF flag in the XSPI_SR register.
  [then]


  [ifdef] XSPI_XSPI_DLR_DEF
    \
    \ @brief XSPI data length register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DL                        \ [0x00 : 32] Data length
  [then]


  [ifdef] XSPI_XSPI_AR_DEF
    \
    \ @brief XSPIaddress register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_ADDRESS                   \ [0x00 : 32] Address Address to be sent to the external device. In HyperBus protocol, this field must be even as this protocol is 16-bit word oriented. In dual-memory configuration, AR[0] is forced to 0. Writes to this field are ignored when BUSY = 1 or when FMODE = 11 (memory-mapped mode). Some memory specifications consider that each address corresponds to a 16-bit value. XSPI considers that each address corresponds to an 8-bit value. So the software needs to multiple the address by two when accessing the memory registers.
  [then]


  [ifdef] XSPI_XSPI_DR_DEF
    \
    \ @brief XSPI data register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DATA                      \ [0x00 : 32] Data Data to be sent/received to/from the external SPI device In indirect-write mode, data written to this register is stored on the FIFO before it is sent to the external device during the data phase. If the FIFO is too full, a write operation is stalled until the FIFO has enough space to accept the amount of data being written. In indirect-read mode, reading this register gives (via the FIFO) the data that was received from the external device. If the FIFO does not have as many bytes as requested by the read operation and if BUSY = 1, the read operation is stalled until enough data is present or until the transfer is complete, whichever happens first. In automatic status-polling mode, this register contains the last data read from the external device (without masking). Word, half-word, and byte accesses to this register are supported. In indirect-write mode, a byte write adds 1 byte to the FIFO, a half-word write 2 bytes, and a word write 4 bytes. Similarly, in indirect-read mode, a byte read removes 1 byte from the FIFO, a halfword read 2 bytes, and a word read 4 bytes. Accesses in indirect mode must be aligned to the bottom of this register: A byte read must read DATA[7:0] and a half-word read must read DATA[15:0].
  [then]


  [ifdef] XSPI_XSPI_PSMKR_DEF
    \
    \ @brief XSPI polling status mask register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_MASK                      \ [0x00 : 32] Status mask Mask to be applied to the status bytes received in automatic status-polling mode For bit n:
  [then]


  [ifdef] XSPI_XSPI_PSMAR_DEF
    \
    \ @brief XSPI polling status match register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_MATCH                     \ [0x00 : 32] Status match Value to be compared with the masked status register to get a match
  [then]


  [ifdef] XSPI_XSPI_PIR_DEF
    \
    \ @brief XSPI polling interval register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_INTERVAL                  \ [0x00 : 16] Polling interval Number of CLK cycle between a read during the automatic status-polling phases
  [then]


  [ifdef] XSPI_XSPI_CCR_DEF
    \
    \ @brief XSPI communication configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_IMODE                     \ [0x00 : 3] Instruction mode This field defines the instruction phase mode of operation. Others: reserved
    $03 constant XSPI_IDTR                      \ [0x03] Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
    $04 constant XSPI_ISIZE                     \ [0x04 : 2] Instruction size This bit defines instruction size.
    $08 constant XSPI_ADMODE                    \ [0x08 : 3] Address mode This field defines the address phase mode of operation. Others: reserved
    $0b constant XSPI_ADDTR                     \ [0x0b] Address double transfer rate This bit sets the DTR mode for the address phase.
    $0c constant XSPI_ADSIZE                    \ [0x0c : 2] Address size This field defines address size.
    $10 constant XSPI_ABMODE                    \ [0x10 : 3] Alternate-byte mode This field defines the alternate byte phase mode of operation. Others: reserved
    $13 constant XSPI_ABDTR                     \ [0x13] Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase. Note: This field can be written only when BUSY = 0.
    $14 constant XSPI_ABSIZE                    \ [0x14 : 2] Alternate bytes size This bit defines alternate bytes size.
    $18 constant XSPI_DMODE                     \ [0x18 : 3] Data mode This field defines the data phase mode of operation. Others: reserved
    $1b constant XSPI_DDTR                      \ [0x1b] Data double transfer rate This bit sets the DTR mode for the data phase.
    $1d constant XSPI_DQSE                      \ [0x1d] DQS enable This bit enables the data strobe management.
  [then]


  [ifdef] XSPI_XSPI_TCR_DEF
    \
    \ @brief XSPI timing configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DCYC                      \ [0x00 : 5] Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31).
    $1c constant XSPI_DHQC                      \ [0x1c] Delay hold quarter cycle
    $1e constant XSPI_SSHIFT                    \ [0x1e] Sample shift By default, the XSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The software must ensure that SSHIFT = 0 when the data phase is configured in DTR mode (when DDTR = 1.)
  [then]


  [ifdef] XSPI_XSPI_IR_DEF
    \
    \ @brief XSPI instruction register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_INSTRUCTION               \ [0x00 : 32] Instruction Instruction to be sent to the external SPI device
  [then]


  [ifdef] XSPI_XSPI_ABR_DEF
    \
    \ @brief XSPI alternate bytes register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_ALTERNATE                 \ [0x00 : 32] Alternate bytes Optional data to be sent to the external SPI device right after the address.
  [then]


  [ifdef] XSPI_XSPI_LPTR_DEF
    \
    \ @brief XSPI low-power timeout register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_TIMEOUT                   \ [0x00 : 16] Timeout period After each access in memory-mapped mode, the XSPI prefetches the subsequent bytes and hold them in the FIFO. This field indicates how many CLK cycles the XSPI waits after the clock becomes inactive and until it raises the NCS, putting the external device in a lower-consumption state.
  [then]


  [ifdef] XSPI_XSPI_WPCCR_DEF
    \
    \ @brief XSPI wrap communication configuration register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_IMODE                     \ [0x00 : 3] Instruction mode This field defines the instruction phase mode of operation. Others: reserved
    $03 constant XSPI_IDTR                      \ [0x03] Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
    $04 constant XSPI_ISIZE                     \ [0x04 : 2] Instruction size This field defines instruction size.
    $08 constant XSPI_ADMODE                    \ [0x08 : 3] Address mode This field defines the address phase mode of operation. Others: reserved
    $0b constant XSPI_ADDTR                     \ [0x0b] Address double transfer rate This bit sets the DTR mode for the address phase.
    $0c constant XSPI_ADSIZE                    \ [0x0c : 2] Address size This field defines address size.
    $10 constant XSPI_ABMODE                    \ [0x10 : 3] Alternate-byte mode This field defines the alternate byte phase mode of operation.
    $13 constant XSPI_ABDTR                     \ [0x13] Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase.
    $14 constant XSPI_ABSIZE                    \ [0x14 : 2] Alternate bytes size This bit defines alternate bytes size.
    $18 constant XSPI_DMODE                     \ [0x18 : 3] Data mode This field defines the data phase mode of operation. 101; data on 16 lines Others: reserved
    $1b constant XSPI_DDTR                      \ [0x1b] Data double transfer rate This bit sets the DTR mode for the data phase.
    $1d constant XSPI_DQSE                      \ [0x1d] DQS enable This bit enables the data strobe management.
  [then]


  [ifdef] XSPI_XSPI_WPTCR_DEF
    \
    \ @brief XSPI wrap timing configuration register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DCYC                      \ [0x00 : 5] Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31).
    $1c constant XSPI_DHQC                      \ [0x1c] Delay hold quarter cycle Add a quarter cycle delay on the outputs in DTR communication to match hold requirement.
    $1e constant XSPI_SSHIFT                    \ [0x1e] Sample shift By default, the XSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The firmware must assure that SSHIFT=0 when the data phase is configured in DTR mode (when DDTR = 1).
  [then]


  [ifdef] XSPI_XSPI_WPIR_DEF
    \
    \ @brief XSPI wrap instruction register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_INSTRUCTION               \ [0x00 : 32] Instruction Instruction to be sent to the external SPI device
  [then]


  [ifdef] XSPI_XSPI_WPABR_DEF
    \
    \ @brief XSPI wrap alternate byte register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_ALTERNATE                 \ [0x00 : 32] Alternate bytes Optional data to be sent to the external SPI device right after the address
  [then]


  [ifdef] XSPI_XSPI_WCCR_DEF
    \
    \ @brief XSPI write communication configuration register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_IMODE                     \ [0x00 : 3] Instruction mode This field defines the instruction phase mode of operation. Others: reserved
    $03 constant XSPI_IDTR                      \ [0x03] Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
    $04 constant XSPI_ISIZE                     \ [0x04 : 2] Instruction size This bit defines instruction size:
    $08 constant XSPI_ADMODE                    \ [0x08 : 3] Address mode This field defines the address phase mode of operation. Others: reserved
    $0b constant XSPI_ADDTR                     \ [0x0b] Address double transfer rate This bit sets the DTR mode for the address phase.
    $0c constant XSPI_ADSIZE                    \ [0x0c : 2] Address size This field defines address size.
    $10 constant XSPI_ABMODE                    \ [0x10 : 3] Alternate-byte mode This field defines the alternate-byte phase mode of operation. Others: reserved
    $13 constant XSPI_ABDTR                     \ [0x13] Alternate bytes double-transfer rate This bit sets the DTR mode for the alternate-bytes phase.
    $14 constant XSPI_ABSIZE                    \ [0x14 : 2] Alternate bytes size This field defines alternate bytes size:
    $18 constant XSPI_DMODE                     \ [0x18 : 3] Data mode This field defines the data phase mode of operation.
    $1b constant XSPI_DDTR                      \ [0x1b] data double transfer rate This bit sets the DTR mode for the data phase.
    $1d constant XSPI_DQSE                      \ [0x1d] DQS enable This bit enables the data strobe management.
  [then]


  [ifdef] XSPI_XSPI_WTCR_DEF
    \
    \ @brief XSPI write timing configuration register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DCYC                      \ [0x00 : 5] Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31). It is recommended to have at least 5 dummy cycles when using memories with DQS activated.
  [then]


  [ifdef] XSPI_XSPI_WIR_DEF
    \
    \ @brief XSPI write instruction register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_INSTRUCTION               \ [0x00 : 32] Instruction Instruction to be sent to the external SPI device
  [then]


  [ifdef] XSPI_XSPI_WABR_DEF
    \
    \ @brief XSPI write alternate byte register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_ALTERNATE                 \ [0x00 : 32] Alternate bytes Optional data to be sent to the external SPI device right after the address
  [then]


  [ifdef] XSPI_XSPI_HLCR_DEF
    \
    \ @brief XSPI HyperBus latency configuration register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_LM                        \ [0x00] Latency mode This bit selects the Latency mode. Note: This bit must be set when using the dual-octal HyperBus configuration.
    $01 constant XSPI_WZL                       \ [0x01] Write zero latency This bit enables zero latency on write operations.
    $08 constant XSPI_TACC                      \ [0x08 : 8] Access time Device access time expressed in number of communication clock cycles
    $10 constant XSPI_TRWR                      \ [0x10 : 8] Read write recovery time Device read write recovery time expressed in number of communication clock cycles
  [then]


  [ifdef] XSPI_XSPI_CALFCR_DEF
    \
    \ @brief XSPI full-cycle calibration configuration
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_FINE                      \ [0x00 : 7] Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $10 constant XSPI_COARSE                    \ [0x10 : 5] Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $1f constant XSPI_CALMAX                    \ [0x1f] Max value This bit gets set when the memory-clock period is outside the range of DLL master, in which case XSPI_CALFCR and XSPI_CALSR are updated with the values for the maximum delay.
  [then]


  [ifdef] XSPI_XSPI_CALMR_DEF
    \
    \ @brief XSPI DLL master calibration configuration
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_FINE                      \ [0x00 : 7] Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $10 constant XSPI_COARSE                    \ [0x10 : 5] Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
  [then]


  [ifdef] XSPI_XSPI_CALSOR_DEF
    \
    \ @brief XSPI DLL slave output calibration configuration
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_FINE                      \ [0x00 : 7] Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $10 constant XSPI_COARSE                    \ [0x10 : 5] Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
  [then]


  [ifdef] XSPI_XSPI_CALSIR_DEF
    \
    \ @brief XSPI DLL slave input calibration configuration
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_FINE                      \ [0x00 : 7] Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $10 constant XSPI_COARSE                    \ [0x10 : 5] Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
  [then]

  \
  \ @brief XSPI register block
  \
  $00 constant XSPI_XSPI_CR             \ XSPI control register
  $08 constant XSPI_XSPI_DCR1           \ XSPI device configuration register 1
  $0C constant XSPI_XSPI_DCR2           \ XSPI device configuration register 2
  $10 constant XSPI_XSPI_DCR3           \ XSPI device configuration register 3
  $14 constant XSPI_XSPI_DCR4           \ XSPI device configuration register 4
  $20 constant XSPI_XSPI_SR             \ XSPI status register
  $24 constant XSPI_XSPI_FCR            \ XSPI flag clear register
  $40 constant XSPI_XSPI_DLR            \ XSPI data length register
  $48 constant XSPI_XSPI_AR             \ XSPIaddress register
  $50 constant XSPI_XSPI_DR             \ XSPI data register
  $80 constant XSPI_XSPI_PSMKR          \ XSPI polling status mask register
  $88 constant XSPI_XSPI_PSMAR          \ XSPI polling status match register
  $90 constant XSPI_XSPI_PIR            \ XSPI polling interval register
  $100 constant XSPI_XSPI_CCR           \ XSPI communication configuration register
  $108 constant XSPI_XSPI_TCR           \ XSPI timing configuration register
  $110 constant XSPI_XSPI_IR            \ XSPI instruction register
  $120 constant XSPI_XSPI_ABR           \ XSPI alternate bytes register
  $130 constant XSPI_XSPI_LPTR          \ XSPI low-power timeout register
  $140 constant XSPI_XSPI_WPCCR         \ XSPI wrap communication configuration register
  $148 constant XSPI_XSPI_WPTCR         \ XSPI wrap timing configuration register
  $150 constant XSPI_XSPI_WPIR          \ XSPI wrap instruction register
  $160 constant XSPI_XSPI_WPABR         \ XSPI wrap alternate byte register
  $180 constant XSPI_XSPI_WCCR          \ XSPI write communication configuration register
  $188 constant XSPI_XSPI_WTCR          \ XSPI write timing configuration register
  $190 constant XSPI_XSPI_WIR           \ XSPI write instruction register
  $1A0 constant XSPI_XSPI_WABR          \ XSPI write alternate byte register
  $200 constant XSPI_XSPI_HLCR          \ XSPI HyperBus latency configuration register
  $210 constant XSPI_XSPI_CALFCR        \ XSPI full-cycle calibration configuration
  $218 constant XSPI_XSPI_CALMR         \ XSPI DLL master calibration configuration
  $220 constant XSPI_XSPI_CALSOR        \ XSPI DLL slave output calibration configuration
  $228 constant XSPI_XSPI_CALSIR        \ XSPI DLL slave input calibration configuration

: XSPI_DEF ; [then]
