\
\ @file octospi.fs
\ @brief Octo-SPI interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OCTOSPI_DEF

  [ifdef] OCTOSPI_OCTOSPI_CR_DEF
    \
    \ @brief OCTOSPI control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_EN                     \ [0x00] Enable This bit enables the OCTOSPI. Note: The DMA request can be aborted without having received the ACK in case this EN bit is cleared during the operation. In case this bit is set to 0 during a DMA transfer, the REQ signal to DMA returns to inactive state without waiting for the ACK signal from DMA to be active.
    $01 constant OCTOSPI_ABORT                  \ [0x01] Abort request This bit aborts the ongoing command sequence. It is automatically reset once the abort is completed. This bit stops the current transfer. Note: This bit is always read as 0.
    $02 constant OCTOSPI_DMAEN                  \ [0x02] DMA enable In Indirect mode, the DMA can be used to input or output data via OCTOSPI_DR. DMA transfers are initiated when FTF is set. Note: Resetting the DMAEN bit while a DMA transfer is ongoing, breaks the handshake with the DMA. Do not write this bit during DMA operation.
    $03 constant OCTOSPI_TCEN                   \ [0x03] Timeout counter enable This bit is valid only when the Memory-mapped mode (FMODE[1:0] = 11) is selected. This bit enables the timeout counter.
    $06 constant OCTOSPI_DMM                    \ [0x06] Dual-memory configuration This bit activates the dual-memory configuration, where two external devices are used simultaneously to double the throughput and the capacity
    $07 constant OCTOSPI_FSEL                   \ [0x07] Flash select This bit selects the Flash memory to be addressed in Single-, Dual-, Quad-SPI mode in single-memory configuration (when DMM = 0). This bit is ignored when DMM = 1 or when Octal-SPI mode is selected.
    $08 constant OCTOSPI_FTHRES                 \ [0x08 : 5] FIFO threshold level This field defines, in Indirect mode, the threshold number of bytes in the FIFO that causes the FIFO threshold flag FTF in OCTOSPI_SR, to be set. ... Note: If DMAEN = 1, the DMA controller for the corresponding channel must be disabled before changing the FTHRES[4:0] value.
    $10 constant OCTOSPI_TEIE                   \ [0x10] Transfer error interrupt enable This bit enables the transfer error interrupt.
    $11 constant OCTOSPI_TCIE                   \ [0x11] Transfer complete interrupt enable This bit enables the transfer complete interrupt.
    $12 constant OCTOSPI_FTIE                   \ [0x12] FIFO threshold interrupt enable This bit enables the FIFO threshold interrupt.
    $13 constant OCTOSPI_SMIE                   \ [0x13] Status match interrupt enable This bit enables the status match interrupt.
    $14 constant OCTOSPI_TOIE                   \ [0x14] Timeout interrupt enable This bit enables the timeout interrupt.
    $16 constant OCTOSPI_APMS                   \ [0x16] Automatic status-polling mode stop This bit determines if the Automatic status-polling mode is stopped after a match.
    $17 constant OCTOSPI_PMM                    \ [0x17] Polling match mode This bit indicates which method must be used to determine a match during the Automatic status-polling mode.
    $1c constant OCTOSPI_FMODE                  \ [0x1c : 2] Functional mode This field defines the OCTOSPI functional mode of operation. If DMAEN = 1 already, then the DMA controller for the corresponding channel must be disabled before changing the FMODE[1:0] value. If FMODE[1:0] and FTHRES[4:0] are wrongly updated while DMAEN = 1, the DMA request signal automatically goes to inactive state.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_DCR1_DEF
    \
    \ @brief OCTOSPI device configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_CKMODE                 \ [0x00] Mode 0/Mode 3 This bit indicates the level taken by the CLK between commands (when NCS = 1).
    $01 constant OCTOSPI_FRCK                   \ [0x01] Free running clock This bit configures the free running clock.
    $03 constant OCTOSPI_DLYBYP                 \ [0x03] Delay block bypass
    $08 constant OCTOSPI_CSHT                   \ [0x08 : 6] Chip-select high time CSHT + 1 defines the minimum number of CLK cycles where the chip-select (NCS) must remain high between commands issued to the external device. ...
    $10 constant OCTOSPI_DEVSIZE                \ [0x10 : 5] Device size This field defines the size of the external device using the following formula: Number of bytes in device = 2[DEVSIZE+1]. DEVSIZE+1 is effectively the number of address bits required to address the external device. The device capacity can be up to 4 Gbytes (addressed using 32-bits) in Indirect mode, but the addressable space in Memory-mapped mode is limited to 256 Mbytes. In Regular-command protocol, if DMM = 1, DEVSIZE[4:0] indicates the total capacity of the two devices together.
    $18 constant OCTOSPI_MTYP                   \ [0x18 : 3] Memory type This bit indicates the type of memory to be supported. Note: In this mode, DQS signal polarity is inverted with respect to the memory clock signal. This is the default value and care must be taken to change MTYP[2:0] for memories different from Micron. Others: Reserved
  [then]


  [ifdef] OCTOSPI_OCTOSPI_DCR2_DEF
    \
    \ @brief OCTOSPI device configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_PRESCALER              \ [0x00 : 8] Clock prescaler This field defines the scaler factor for generating the CLK based on the kernel clock (value + 1). 2: FCLK = FKERNEL/3 ... 255: FCLK = FKERNEL/256 For odd clock division factors, the CLK duty cycle is not 50 %. The clock signal remains low one cycle longer than it stays high.
    $10 constant OCTOSPI_WRAPSIZE               \ [0x10 : 3] Wrap size This field indicates the wrap size to which the memory is configured. For memories which have a separate command for wrapped instructions, this field indicates the wrap-size associated with the command held in the OCTOSPI1_WPIR register. 110-111: Reserved
  [then]


  [ifdef] OCTOSPI_OCTOSPI_DCR3_DEF
    \
    \ @brief OCTOSPI device configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $10 constant OCTOSPI_CSBOUND                \ [0x10 : 5] NCS boundary This field enables the transaction boundary feature. When active, a minimum value of 3 is recommended. The NCS is released on each boundary of 2CSBOUND bytes. others: NCS boundary set to 2CSBOUND bytes
  [then]


  [ifdef] OCTOSPI_OCTOSPI_DCR4_DEF
    \
    \ @brief OCTOSPI device configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_REFRESH                \ [0x00 : 32] Refresh rate This field enables the refresh rate feature. The NCS is released every REFRESH + 1 clock cycles for writes, and REFRESH + 4 clock cycles for reads. Note: These two values can be extended with few clock cycles when refresh occurs during a byte transmission in Single-, Dual- or Quad-SPI mode, because the byte transmission must be completed. others: Maximum communication length is set to REFRESH + 1 clock cycles.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_SR_DEF
    \
    \ @brief OCTOSPI status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_TEF                    \ [0x00] Transfer error flag This bit is set in Indirect mode when an invalid address is being accessed in Indirect mode. It is cleared by writing 1 to CTEF.
    $01 constant OCTOSPI_TCF                    \ [0x01] Transfer complete flag This bit is set in Indirect mode when the programmed number of data has been transferred or in any mode when the transfer has been aborted.It is cleared by writing 1 to CTCF.
    $02 constant OCTOSPI_FTF                    \ [0x02] FIFO threshold flag In Indirect mode, this bit is set when the FIFO threshold has been reached, or if there is any data left in the FIFO after the reads from the external device are complete. It is cleared automatically as soon as the threshold condition is no longer true. In Automatic status-polling mode, this bit is set every time the status register is read, and the bit is cleared when the data register is read.
    $03 constant OCTOSPI_SMF                    \ [0x03] Status match flag This bit is set in Automatic status-polling mode when the unmasked received data matches the corresponding bits in the match register (OCTOSPI_PSMAR). It is cleared by writing 1 to CSMF.
    $04 constant OCTOSPI_TOF                    \ [0x04] Timeout flag This bit is set when timeout occurs. It is cleared by writing 1 to CTOF.
    $05 constant OCTOSPI_BUSY                   \ [0x05] Busy This bit is set when an operation is ongoing. It is cleared automatically when the operation with the external device is finished and the FIFO is empty.
    $08 constant OCTOSPI_FLEVEL                 \ [0x08 : 6] FIFO level This field gives the number of valid bytes that are being held in the FIFO. FLEVEL = 0 when the FIFO is empty, and 32 when it is full. In Automatic status-polling mode, FLEVEL is zero.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_FCR_DEF
    \
    \ @brief OCTOSPI flag clear register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_CTEF                   \ [0x00] Clear transfer error flag Writing 1 clears the TEF flag in the OCTOSPI_SR register.
    $01 constant OCTOSPI_CTCF                   \ [0x01] Clear transfer complete flag Writing 1 clears the TCF flag in the OCTOSPI_SR register.
    $03 constant OCTOSPI_CSMF                   \ [0x03] Clear status match flag Writing 1 clears the SMF flag in the OCTOSPI_SR register.
    $04 constant OCTOSPI_CTOF                   \ [0x04] Clear timeout flag Writing 1 clears the TOF flag in the OCTOSPI_SR register.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_DLR_DEF
    \
    \ @brief OCTOSPI data length register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_DL                     \ [0x00 : 32] [31: 0]: Data length Number of data to be retrieved (value+1) in Indirect and Automatic status-polling modes. A value not greater than three (indicating 4 bytes) must be used for Automatic status-polling mode. All 1's in Indirect mode means undefined length, where OCTOSPI continues until the end of the memory, as defined by DEVSIZE. 0x0000_0000: 1 byte is to be transferred. 0x0000_0001: 2 bytes are to be transferred. 0x0000_0002: 3 bytes are to be transferred. 0x0000_0003: 4 bytes are to be transferred. ... 0xFFFF_FFFD: 4,294,967,294 (4G-2) bytes are to be transferred. 0xFFFF_FFFE: 4,294,967,295 (4G-1) bytes are to be transferred. 0xFFFF_FFFF: undefined length; all bytes, until the end of the external device, (as defined by DEVSIZE) are to be transferred. Continue reading indefinitely if DEVSIZE = 0x1F. DL[0] is stuck at 1 in dual-memory configuration (DMM = 1) even when 0 is written to this bit, thus assuring that each access transfers an even number of bytes. This field has no effect in Memory-mapped mode.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_AR_DEF
    \
    \ @brief OCTOSPI address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_ADDRESS                \ [0x00 : 32] Address Address to be sent to the external device. In HyperBus protocol, this field must be even as this protocol is 16-bit word oriented. In dual-memory configuration, AR[0] is forced to 1. Writes to this field are ignored when BUSY = 1 or when FMODE = 11 (Memory-mapped mode).
  [then]


  [ifdef] OCTOSPI_OCTOSPI_DR_DEF
    \
    \ @brief OCTOSPI data register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_DATA                   \ [0x00 : 32] [31: 0]: Data Data to be sent/received to/from the external SPI device In Indirect-write mode, data written to this register is stored on the FIFO before it is sent to the external device during the data phase. If the FIFO is too full, a write operation is stalled until the FIFO has enough space to accept the amount of data being written. In Indirect-read mode, reading this register gives (via the FIFO) the data that was received from the external device. If the FIFO does not have as many bytes as requested by the read operation and if BUSY = 1, the read operation is stalled until enough data is present or until the transfer is complete, whichever happens first. In Automatic status-polling mode, this register contains the last data read from the external device (without masking). Word, half-word, and byte accesses to this register are supported. In Indirect-write mode, a byte write adds 1 byte to the FIFO, a half-word write 2 bytes, and a word write 4 bytes. Similarly, in Indirect-read mode, a byte read removes 1 byte from the FIFO, a halfword read 2 bytes, and a word read 4 bytes. Accesses in Indirect mode must be aligned to the bottom of this register: A byte read must read DATA[7:0] and a half-word read must read DATA[15:0].
  [then]


  [ifdef] OCTOSPI_OCTOSPI_PSMKR_DEF
    \
    \ @brief OCTOSPI polling status mask register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_MASK                   \ [0x00 : 32] Status mask Mask to be applied to the status bytes received in Automatic status-polling mode For bit n:
  [then]


  [ifdef] OCTOSPI_OCTOSPI_PSMAR_DEF
    \
    \ @brief OCTOSPI polling status match register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_MATCH                  \ [0x00 : 32] [31: 0]: Status match Value to be compared with the masked status register to get a match
  [then]


  [ifdef] OCTOSPI_OCTOSPI_PIR_DEF
    \
    \ @brief OCTOSPI polling interval register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_INTERVAL               \ [0x00 : 16] [15: 0]: Polling interval Number of CLK cycle between a read during the Automatic status-polling phases
  [then]


  [ifdef] OCTOSPI_OCTOSPI_CCR_DEF
    \
    \ @brief OCTOSPI communication configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_IMODE                  \ [0x00 : 3] Instruction mode This field defines the instruction phase mode of operation. 101-111: Reserved
    $03 constant OCTOSPI_IDTR                   \ [0x03] Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
    $04 constant OCTOSPI_ISIZE                  \ [0x04 : 2] Instruction size This bit defines instruction size.
    $08 constant OCTOSPI_ADMODE                 \ [0x08 : 3] Address mode This field defines the address phase mode of operation. 101-111: Reserved
    $0b constant OCTOSPI_ADDTR                  \ [0x0b] Address double transfer rate This bit sets the DTR mode for the address phase.
    $0c constant OCTOSPI_ADSIZE                 \ [0x0c : 2] Address size This field defines address size.
    $10 constant OCTOSPI_ABMODE                 \ [0x10 : 3] Alternate-byte mode This field defines the alternate-byte phase mode of operation. 101-111: Reserved
    $13 constant OCTOSPI_ABDTR                  \ [0x13] Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase. This field can be written only when BUSY = 0.
    $14 constant OCTOSPI_ABSIZE                 \ [0x14 : 2] Alternate bytes size This bit defines alternate bytes size.
    $18 constant OCTOSPI_DMODE                  \ [0x18 : 3] Data mode This field defines the data phase mode of operation. 101-111: Reserved
    $1b constant OCTOSPI_DDTR                   \ [0x1b] Data double transfer rate This bit sets the DTR mode for the data phase.
    $1d constant OCTOSPI_DQSE                   \ [0x1d] DQS enable This bit enables the data strobe management.
    $1f constant OCTOSPI_SIOO                   \ [0x1f] Send instruction only once mode This bit has no effect when IMODE = 00 (see ).
  [then]


  [ifdef] OCTOSPI_OCTOSPI_TCR_DEF
    \
    \ @brief OCTOSPI timing configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_DCYC                   \ [0x00 : 5] Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31). It is recommended to have at least six dummy cycles when using memories with DQS activated.
    $1c constant OCTOSPI_DHQC                   \ [0x1c] Delay hold quarter cycle
    $1e constant OCTOSPI_SSHIFT                 \ [0x1e] Sample shift By default, the OCTOSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The software must ensure that SSHIFT = 0 when the data phase is configured in DTR mode (when DDTR = 1.)
  [then]


  [ifdef] OCTOSPI_OCTOSPI_IR_DEF
    \
    \ @brief OCTOSPI instruction register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_INSTRUCTION            \ [0x00 : 32] Instruction Instruction to be sent to the external SPI device
  [then]


  [ifdef] OCTOSPI_OCTOSPI_ABR_DEF
    \
    \ @brief OCTOSPI alternate bytes register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_ALTERNATE              \ [0x00 : 32] [31: 0]: Alternate bytes Optional data to be sent to the external SPI device right after the address.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_LPTR_DEF
    \
    \ @brief OCTOSPI low-power timeout register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_TIMEOUT                \ [0x00 : 16] [15: 0]: Timeout period After each access in Memory-mapped mode, the OCTOSPI prefetches the subsequent bytes and hold them in the FIFO. This field indicates how many CLK cycles the OCTOSPI waits after the clock becomes inactive and until it raises the NCS, putting the external device in a lower-consumption state.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_WPCCR_DEF
    \
    \ @brief OCTOSPI wrap communication configuration register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_IMODE                  \ [0x00 : 3] Instruction mode This field defines the instruction phase mode of operation. 101-111: Reserved
    $03 constant OCTOSPI_IDTR                   \ [0x03] Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
    $04 constant OCTOSPI_ISIZE                  \ [0x04 : 2] Instruction size This field defines instruction size.
    $08 constant OCTOSPI_ADMODE                 \ [0x08 : 3] Address mode This field defines the address phase mode of operation. 101-111: Reserved
    $0b constant OCTOSPI_ADDTR                  \ [0x0b] Address double transfer rate This bit sets the DTR mode for the address phase.
    $0c constant OCTOSPI_ADSIZE                 \ [0x0c : 2] Address size This field defines address size.
    $10 constant OCTOSPI_ABMODE                 \ [0x10 : 3] Alternate-byte mode This field defines the alternate byte phase mode of operation. 101-111: Reserved
    $13 constant OCTOSPI_ABDTR                  \ [0x13] Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase.
    $14 constant OCTOSPI_ABSIZE                 \ [0x14 : 2] Alternate bytes size This bit defines alternate bytes size.
    $18 constant OCTOSPI_DMODE                  \ [0x18 : 3] Data mode This field defines the data phase mode of operation. 101-111: Reserved
    $1b constant OCTOSPI_DDTR                   \ [0x1b] Data double transfer rate This bit sets the DTR mode for the data phase.
    $1d constant OCTOSPI_DQSE                   \ [0x1d] DQS enable This bit enables the data strobe management.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_WPTCR_DEF
    \
    \ @brief OCTOSPI wrap timing configuration register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_DCYC                   \ [0x00 : 5] Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31). It is recommended to have at least 5 dummy cycles when using memories with DQS activated.
    $1c constant OCTOSPI_DHQC                   \ [0x1c] Delay hold quarter cycle Add a quarter cycle delay on the outputs in DTR communication to match hold requirement.
    $1e constant OCTOSPI_SSHIFT                 \ [0x1e] Sample shift By default, the OCTOSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The firmware must assure that SSHIFT=0 when the data phase is configured in DTR mode (when DDTR = 1).
  [then]


  [ifdef] OCTOSPI_OCTOSPI_WPIR_DEF
    \
    \ @brief OCTOSPI wrap instruction register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_INSTRUCTION            \ [0x00 : 32] [31: 0]: Instruction Instruction to be sent to the external SPI device
  [then]


  [ifdef] OCTOSPI_OCTOSPI_WPABR_DEF
    \
    \ @brief OCTOSPI wrap alternate bytes register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_ALTERNATE              \ [0x00 : 32] [31: 0]: Alternate bytes Optional data to be sent to the external SPI device right after the address
  [then]


  [ifdef] OCTOSPI_OCTOSPI_WCCR_DEF
    \
    \ @brief OCTOSPI write communication configuration register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_IMODE                  \ [0x00 : 3] Instruction mode This field defines the instruction phase mode of operation. 101-111: Reserved
    $03 constant OCTOSPI_IDTR                   \ [0x03] Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
    $04 constant OCTOSPI_ISIZE                  \ [0x04 : 2] Instruction size This bit defines instruction size:
    $08 constant OCTOSPI_ADMODE                 \ [0x08 : 3] Address mode This field defines the address phase mode of operation. 101-111: Reserved
    $0b constant OCTOSPI_ADDTR                  \ [0x0b] Address double transfer rate This bit sets the DTR mode for the address phase.
    $0c constant OCTOSPI_ADSIZE                 \ [0x0c : 2] Address size This field defines address size.
    $10 constant OCTOSPI_ABMODE                 \ [0x10 : 3] Alternate-byte mode This field defines the alternate-byte phase mode of operation. 101-111: Reserved
    $13 constant OCTOSPI_ABDTR                  \ [0x13] Alternate bytes double transfer rate This bit sets the DTR mode for the alternate-bytes phase.
    $14 constant OCTOSPI_ABSIZE                 \ [0x14 : 2] Alternate bytes size This field defines alternate bytes size:
    $18 constant OCTOSPI_DMODE                  \ [0x18 : 3] Data mode This field defines the data phase mode of operation. 101-111: Reserved
    $1b constant OCTOSPI_DDTR                   \ [0x1b] data double transfer rate This bit sets the DTR mode for the data phase.
    $1d constant OCTOSPI_DQSE                   \ [0x1d] DQS enable This bit enables the data strobe management.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_WTCR_DEF
    \
    \ @brief OCTOSPI write timing configuration register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_DCYC                   \ [0x00 : 5] Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31). It is recommended to have at least 5 dummy cycles when using memories with DQS activated.
  [then]


  [ifdef] OCTOSPI_OCTOSPI_WIR_DEF
    \
    \ @brief OCTOSPI write instruction register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_INSTRUCTION            \ [0x00 : 32] Instruction Instruction to be sent to the external SPI device
  [then]


  [ifdef] OCTOSPI_OCTOSPI_WABR_DEF
    \
    \ @brief OCTOSPI write alternate bytes register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_ALTERNATE              \ [0x00 : 32] [31: 0]: Alternate bytes Optional data to be sent to the external SPI device right after the address
  [then]


  [ifdef] OCTOSPI_OCTOSPI_HLCR_DEF
    \
    \ @brief OCTOSPI HyperBus latency configuration register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_LM                     \ [0x00] Latency mode This bit selects the Latency mode.
    $01 constant OCTOSPI_WZL                    \ [0x01] Write zero latency This bit enables zero latency on write operations.
    $08 constant OCTOSPI_TACC                   \ [0x08 : 8] [7: 0]: Access time Device access time expressed in number of communication clock cycles
    $10 constant OCTOSPI_TRWR                   \ [0x10 : 8] Read write recovery time Device read write recovery time expressed in number of communication clock cycles
  [then]

  \
  \ @brief Octo-SPI interface
  \
  $00 constant OCTOSPI_OCTOSPI_CR       \ OCTOSPI control register
  $08 constant OCTOSPI_OCTOSPI_DCR1     \ OCTOSPI device configuration register 1
  $0C constant OCTOSPI_OCTOSPI_DCR2     \ OCTOSPI device configuration register 2
  $10 constant OCTOSPI_OCTOSPI_DCR3     \ OCTOSPI device configuration register 3
  $14 constant OCTOSPI_OCTOSPI_DCR4     \ OCTOSPI device configuration register 4
  $20 constant OCTOSPI_OCTOSPI_SR       \ OCTOSPI status register
  $24 constant OCTOSPI_OCTOSPI_FCR      \ OCTOSPI flag clear register
  $40 constant OCTOSPI_OCTOSPI_DLR      \ OCTOSPI data length register
  $48 constant OCTOSPI_OCTOSPI_AR       \ OCTOSPI address register
  $50 constant OCTOSPI_OCTOSPI_DR       \ OCTOSPI data register
  $80 constant OCTOSPI_OCTOSPI_PSMKR    \ OCTOSPI polling status mask register
  $88 constant OCTOSPI_OCTOSPI_PSMAR    \ OCTOSPI polling status match register
  $90 constant OCTOSPI_OCTOSPI_PIR      \ OCTOSPI polling interval register
  $100 constant OCTOSPI_OCTOSPI_CCR     \ OCTOSPI communication configuration register
  $108 constant OCTOSPI_OCTOSPI_TCR     \ OCTOSPI timing configuration register
  $110 constant OCTOSPI_OCTOSPI_IR      \ OCTOSPI instruction register
  $120 constant OCTOSPI_OCTOSPI_ABR     \ OCTOSPI alternate bytes register
  $130 constant OCTOSPI_OCTOSPI_LPTR    \ OCTOSPI low-power timeout register
  $140 constant OCTOSPI_OCTOSPI_WPCCR   \ OCTOSPI wrap communication configuration register
  $148 constant OCTOSPI_OCTOSPI_WPTCR   \ OCTOSPI wrap timing configuration register
  $150 constant OCTOSPI_OCTOSPI_WPIR    \ OCTOSPI wrap instruction register
  $160 constant OCTOSPI_OCTOSPI_WPABR   \ OCTOSPI wrap alternate bytes register
  $180 constant OCTOSPI_OCTOSPI_WCCR    \ OCTOSPI write communication configuration register
  $188 constant OCTOSPI_OCTOSPI_WTCR    \ OCTOSPI write timing configuration register
  $190 constant OCTOSPI_OCTOSPI_WIR     \ OCTOSPI write instruction register
  $1A0 constant OCTOSPI_OCTOSPI_WABR    \ OCTOSPI write alternate bytes register
  $200 constant OCTOSPI_OCTOSPI_HLCR    \ OCTOSPI HyperBus latency configuration register

: OCTOSPI_DEF ; [then]
