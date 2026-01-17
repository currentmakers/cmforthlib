\
\ @file hspi1.fs
\ @brief HSPI1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HSPI1_DEF

  [ifdef] HSPI1_HSPI_CR_DEF
    \
    \ @brief HSPI control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_EN                       \ [0x00] Enable This bit enables the HSPI. Note: The DMA request can be aborted without having received the ACK in case this EN bit is cleared during the operation. In case this bit is set to 0 during a DMA transfer, the REQ signal to DMA returns to inactive state without waiting for the ACK signal from DMA to be active.
    $01 constant HSPI1_ABORT                    \ [0x01] Abort request This bit aborts the on-going command sequence. It is automatically reset once the abort is completed. This bit stops the current transfer. Note: This bit is always read as 0.
    $02 constant HSPI1_DMAEN                    \ [0x02] DMA enable In Indirect mode, the DMA can be used to input or output data via HSPI_DR. DMA transfers are initiated when FTF is set. Note: Resetting the DMAEN bit while a DMA transfer is ongoing, breaks the handshake with the DMA. Do not write this bit during DMA operation.
    $03 constant HSPI1_TCEN                     \ [0x03] Timeout counter enable This bit is valid only when the Memory-mapped mode (FMODE[1:0]Â =Â 11) is selected. This bit enables the timeout counter.
    $06 constant HSPI1_DMM                      \ [0x06] Dual-memory mode This bit activates the Dual-memory mode, where two external devices are used simultaneously to double the throughput and the capacity
    $07 constant HSPI1_FSEL                     \ [0x07] Memory select This bit is the mirror of bit 30. Refer to the description of MSEL[1:0] above. This bit is set when 1 is written in bit 30 or bit 7. When this bit is set, both b30 and b7 are read as 1. This bit is reset when bit 30 and bit7 are set to 0. When this bit is reset, both bit 30 and bit7 are read as 0.
    $08 constant HSPI1_FTHRES                   \ [0x08 : 6] FIFO threshold level This field defines, in Indirect mode, the threshold number of bytes in the FIFO that causes the FIFO threshold flag FTF in HSPI_SR, to be set. ... Note: If DMAENÂ =Â 1, the DMA controller for the corresponding channel must be disabled before changing the FTHRES[5:0] value.
    $10 constant HSPI1_TEIE                     \ [0x10] Transfer error interrupt enable This bit enables the transfer error interrupt.
    $11 constant HSPI1_TCIE                     \ [0x11] Transfer complete interrupt enable This bit enables the transfer complete interrupt.
    $12 constant HSPI1_FTIE                     \ [0x12] FIFO threshold interrupt enable This bit enables the FIFO threshold interrupt.
    $13 constant HSPI1_SMIE                     \ [0x13] Status match interrupt enable This bit enables the status match interrupt.
    $14 constant HSPI1_TOIE                     \ [0x14] Timeout interrupt enable This bit enables the timeout interrupt.
    $16 constant HSPI1_APMS                     \ [0x16] Automatic-polling mode stop This bit determines if the automatic polling is stopped after a match.
    $17 constant HSPI1_PMM                      \ [0x17] Polling match mode This bit indicates which method must be used to determine a match during the Automatic-polling mode.
    $1c constant HSPI1_FMODE                    \ [0x1c : 2] Functional mode This field defines the HSPI functional mode of operation. If DMAENÂ =Â 1 already, then the DMA controller for the corresponding channel must be disabled before changing the FMODE[1:0] value. If FMODE[1:0] and FTHRES[4:0] are wrongly updated while DMAENÂ =Â 1, the DMA request signal automatically goes to inactive state.
    $1e constant HSPI1_MSEL                     \ [0x1e : 2] Flash select These bits select the memory to be addressed in Single, Dual, Quad or Octal mode in singleâmemory configuration (when DMM = 0). - when in Quad mode: - when in Octal mode or Dual-quad mode: 0x: data exchanged over IO[7:0] 1x: data exchanged over IO[15:8] These bits are ignored when in dual-octal configuration (data on 8 bits and DMMÂ =Â 1) or 16âbit configuration (data exchanged over IO[15:0]).
  [then]


  [ifdef] HSPI1_HSPI_DCR1_DEF
    \
    \ @brief HSPI device configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_CKMODE                   \ [0x00] Mode 0/Mode 3 This bit indicates the level taken by the CLK between commands (when nCSÂ =Â 1).
    $01 constant HSPI1_FRCK                     \ [0x01] Free running clock This bit configures the free running clock.
    $03 constant HSPI1_DLYBYP                   \ [0x03] Delay block bypass
    $08 constant HSPI1_CSHT                     \ [0x08 : 6] Chip-select high time CSHTÂ +Â 1 defines the minimum number of CLK cycles where the chip-select (nCS) must remain high between commands issued to the external device. ... 63: nCS stays high for at least 64 cycles between external device commands. Note: When the extended CSHT timeout feature is not supported, CSHT[5:3] are reserved and the number of cycles is limited to eight (refer to implementation).
    $10 constant HSPI1_DEVSIZE                  \ [0x10 : 5] Device size This field defines the size of the external device using the following formula: Number of bytes in device = 2[DEVSIZE+1]. DEVSIZE+1 is effectively the number of address bits required to address the external device. The device capacity can be up to 4Â Gbytes (addressed using 32-bits) in Indirect mode, but the addressable space in Memory-mapped mode is limited to 256Â Mbytes. In Regular-command mode, if DMMÂ =Â 1, DEVSIZE[4:0] indicates the total capacity of the two devices together.
    $18 constant HSPI1_MTYP                     \ [0x18 : 3] Memory type This bit indicates the type of memory to be supported. Note: In this mode, DQS signal polarity is inverted with respect to the memory clock signal. This is the default value and care must be taken to change MTYP[2:0] for memories different from Micron. Others: Reserved
  [then]


  [ifdef] HSPI1_HSPI_DCR2_DEF
    \
    \ @brief HSPI device configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_PRESCALER                \ [0x00 : 8] Clock prescaler This field defines the scaler factor for generating the CLK based on the kernel clock (valueÂ +Â 1). 2: FCLK = FKERNEL/3 ... 255: FCLK = FKERNEL/256 For odd clock division factors, the CLK duty cycle is not 50Â %. The clock signal remains low one cycle longer than it stays high. Writing this field automatically starts a new calibration of high-speed interface DLL at the start of next transfer, except in case HSPI_CALOSR or HSPI_CALISR have been written in the meantime. BUSY stays high during the whole calibration execution.
    $10 constant HSPI1_WRAPSIZE                 \ [0x10 : 3] Wrap size This field indicates the wrap size to which the memory is configured. For memories which have a separate command for wrapped instructions, this field indicates the wrap-size associated with the command held in the HSPI_WPIR register. 110-111: Reserved
  [then]


  [ifdef] HSPI1_HSPI_DCR3_DEF
    \
    \ @brief HSPI device configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_MAXTRAN                  \ [0x00 : 8] Maximum transfer This field enables the communication regulation feature. The nCS is released every MAXTRAN+1 clock cycles when the other HSPI request the access to the bus. others: Maximum communication is set to MAXTRAN+1 bytes
    $10 constant HSPI1_CSBOUND                  \ [0x10 : 5] CS boundary This field enables the transaction boundary feature. When active, a minimum value of 3 is recommended. The nCS is released on each boundary of 2CSBOUND bytes. others: CS boundary set to 2CSBOUND bytes
  [then]


  [ifdef] HSPI1_HSPI_DCR4_DEF
    \
    \ @brief HSPI device configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_REFRESH                  \ [0x00 : 32] Refresh rate This field enables the refresh rate feature. The nCS is released every REFRESH+1 clock cycles for writes, and REFRESH+4 clock cycles for reads. Note: These two values can be extended with few clock cycles when refresh occurs during a byte transmission in single, dual or quad mode, because the byte transmission must be completed. others: Maximum communication length is set to REFRESH+1 clock cycles.
  [then]


  [ifdef] HSPI1_HSPI_SR_DEF
    \
    \ @brief Transfer error flag This bit is set in Indirect mode when an invalid address is being accessed in Indirect mode. It is cleared by writing 1 to CTEF.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_TEF                      \ [0x00] Transfer error flag This bit is set in Indirect mode when an invalid address is being accessed in Indirect mode. It is cleared by writing 1 to CTEF.
    $01 constant HSPI1_TCF                      \ [0x01] Transfer complete flag This bit is set in Indirect mode when the programmed number of data has been transferred or in any mode when the transfer has been aborted.It is cleared by writing 1 to CTCF.
    $02 constant HSPI1_FTF                      \ [0x02] FIFO threshold flag In Indirect mode, this bit is set when the FIFO threshold has been reached, or if there is any data left in the FIFO after the reads from the external device are complete. It is cleared automatically as soon as the threshold condition is no longer true. In Automatic-polling mode this bit is set every time the status register is read, and the bit is cleared when the data register is read.
    $03 constant HSPI1_SMF                      \ [0x03] Status match flag This bit is set in Automatic-polling mode when the unmasked received data matches the corresponding bits in the match register (HSPI_PSMAR). It is cleared by writing 1 to CSMF.
    $04 constant HSPI1_TOF                      \ [0x04] Timeout flag This bit is set when timeout occurs. It is cleared by writing 1 to CTOF.
    $05 constant HSPI1_BUSY                     \ [0x05] Busy This bit is set when an operation is ongoing. It is cleared automatically when the operation with the external device is finished and the FIFO is empty.
    $08 constant HSPI1_FLEVEL                   \ [0x08 : 7] FIFO level This field gives the number of valid bytes that are being held in the FIFO. FLEVELÂ =Â 0 when the FIFO is empty, and 64 when it is full. In Automatic-status polling mode, FLEVEL is zero.
  [then]


  [ifdef] HSPI1_HSPI_FCR_DEF
    \
    \ @brief Clear transfer error flag Writing 1 clears the TEF flag in the HSPI_SR register.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_CTEF                     \ [0x00] Clear transfer error flag Writing 1 clears the TEF flag in the HSPI_SR register.
    $01 constant HSPI1_CTCF                     \ [0x01] Clear transfer complete flag Writing 1 clears the TCF flag in the HSPI_SR register.
    $03 constant HSPI1_CSMF                     \ [0x03] Clear status match flag Writing 1 clears the SMF flag in the HSPI_SR register.
    $04 constant HSPI1_CTOF                     \ [0x04] Clear timeout flag Writing 1 clears the TOF flag in the HSPI_SR register.
  [then]


  [ifdef] HSPI1_HSPI_DLR_DEF
    \
    \ @brief HSPI data length register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_DL                       \ [0x00 : 32] [31: 0]: Data length Number of data to be retrieved (value+1) in Indirect and Status-polling modes. A value not greater than three (indicating 4 bytes) must be used for status polling-mode. All 1's in Indirect mode means undefined length, where HSPI continues until the end of the memory, as defined by DEVSIZE. 0x0000_0000: 1 byte is to be transferred. 0x0000_0001: 2 bytes are to be transferred. 0x0000_0002: 3 bytes are to be transferred. 0x0000_0003: 4 bytes are to be transferred. ... 0xFFFF_FFFD: 4,294,967,294 (4G-2) bytes are to be transferred. 0xFFFF_FFFE: 4,294,967,295 (4G-1) bytes are to be transferred. 0xFFFF_FFFF: undefined length; all bytes, until the end of the external device, (as defined by DEVSIZE) are to be transferred. Continue reading indefinitely if DEVSIZEÂ =Â 0x1F. DL[0] is stuck at 1 in Dual-memory mode (DMMÂ =Â 1) even when 0 is written to this bit, thus assuring that each access transfers an even number of bytes. This field has no effect when in Memory-mapped mode.
  [then]


  [ifdef] HSPI1_HSPI_AR_DEF
    \
    \ @brief Address Address to be sent to the external device. In HyperBus mode, this field must be even as this protocol is 16-bit word oriented. In dual-memory mode, AR[0] is forced to 1. Writes to this field are ignored when BUSYÂ =Â 1 or when FMODE = 11 (Memory-mapped mode).
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_ADDRESS                  \ [0x00 : 32] Address Address to be sent to the external device. In HyperBus mode, this field must be even as this protocol is 16-bit word oriented. In dual-memory mode, AR[0] is forced to 1. Writes to this field are ignored when BUSYÂ =Â 1 or when FMODE = 11 (Memory-mapped mode).
  [then]


  [ifdef] HSPI1_HSPI_DR_DEF
    \
    \ @brief [31: 0]: Data Data to be sent/received to/from the external SPI device In Indirect-write mode, data written to this register is stored on the FIFO before it is sent to the external device during the data phase. If the FIFO is too full, a write operation is stalled until the FIFO has enough space to accept the amount of data being written. In Indirect-read mode, reading this register gives (via the FIFO) the data that was received from the external device. If the FIFO does not have as many bytes as requested by the read operation and if BUSYÂ =Â 1, the read operation is stalled until enough data is present or until the transfer is complete, whichever happens first. In Automatic-polling mode, this register contains the last data read from the external device (without masking). Word, half-word, and byte accesses to this register are supported. In Indirect-write mode, a byte write adds 1 byte to the FIFO, a half-word write 2 bytes, and a word write 4 bytes. Similarly, in Indirect-read mode, a byte read removes 1 byte from the FIFO, a halfword read 2Â bytes, and a word read 4Â bytes. Accesses in Indirect mode must be aligned to the bottom of this register: A byte read must read DATA[7:0] and a half-word read must read DATA[15:0].
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_DATA                     \ [0x00 : 32] [31: 0]: Data Data to be sent/received to/from the external SPI device In Indirect-write mode, data written to this register is stored on the FIFO before it is sent to the external device during the data phase. If the FIFO is too full, a write operation is stalled until the FIFO has enough space to accept the amount of data being written. In Indirect-read mode, reading this register gives (via the FIFO) the data that was received from the external device. If the FIFO does not have as many bytes as requested by the read operation and if BUSYÂ =Â 1, the read operation is stalled until enough data is present or until the transfer is complete, whichever happens first. In Automatic-polling mode, this register contains the last data read from the external device (without masking). Word, half-word, and byte accesses to this register are supported. In Indirect-write mode, a byte write adds 1 byte to the FIFO, a half-word write 2 bytes, and a word write 4 bytes. Similarly, in Indirect-read mode, a byte read removes 1 byte from the FIFO, a halfword read 2Â bytes, and a word read 4Â bytes. Accesses in Indirect mode must be aligned to the bottom of this register: A byte read must read DATA[7:0] and a half-word read must read DATA[15:0].
  [then]


  [ifdef] HSPI1_HSPI_PSMKR_DEF
    \
    \ @brief HSPI polling status mask register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_MASK                     \ [0x00 : 32] Status mask Mask to be applied to the status bytes received in Polling mode For bit n:
  [then]


  [ifdef] HSPI1_HSPI_PSMAR_DEF
    \
    \ @brief HSPI polling status match register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_MATCH                    \ [0x00 : 32] [31: 0]: Status match Value to be compared with the masked status register to get a match
  [then]


  [ifdef] HSPI1_HSPI_PIR_DEF
    \
    \ @brief HSPI polling interval register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_INTERVAL                 \ [0x00 : 16] [15: 0]: Polling interval Number of CLK cycle between a read during the automatic-polling phases
  [then]


  [ifdef] HSPI1_HSPI_CCR_DEF
    \
    \ @brief HSPI communication configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_IMODE                    \ [0x00 : 3] Instruction mode This field defines the instruction phase mode of operation. 101-111: Reserved
    $03 constant HSPI1_IDTR                     \ [0x03] Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
    $04 constant HSPI1_ISIZE                    \ [0x04 : 2] Instruction size This bit defines instruction size.
    $08 constant HSPI1_ADMODE                   \ [0x08 : 3] Address mode This field defines the address phase mode of operation. 101-111: Reserved
    $0b constant HSPI1_ADDTR                    \ [0x0b] Address double transfer rate This bit sets the DTR mode for the address phase.
    $0c constant HSPI1_ADSIZE                   \ [0x0c : 2] Address size This field defines address size.
    $10 constant HSPI1_ABMODE                   \ [0x10 : 3] Alternate-byte mode This field defines the alternate byte phase mode of operation. 100-111: Reserved
    $13 constant HSPI1_ABDTR                    \ [0x13] Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase. This field can be written only when BUSYÂ =Â 0.
    $14 constant HSPI1_ABSIZE                   \ [0x14 : 2] Alternate bytes size This bit defines alternate bytes size.
    $18 constant HSPI1_DMODE                    \ [0x18 : 3] Data mode This field defines the data phase mode of operation. 110-111: Reserved
    $1b constant HSPI1_DDTR                     \ [0x1b] Data double transfer rate This bit sets the DTR mode for the data phase.
    $1d constant HSPI1_DQSE                     \ [0x1d] DQS enable This bit enables the data strobe management.
    $1f constant HSPI1_SIOO                     \ [0x1f] Send instruction only once mode This bit has no effect when IMODEÂ =Â 00 (see ).
  [then]


  [ifdef] HSPI1_HSPI_TCR_DEF
    \
    \ @brief HSPI timing configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_DCYC                     \ [0x00 : 5] Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31).
    $1c constant HSPI1_DHQC                     \ [0x1c] Delay hold quarter cycle
    $1e constant HSPI1_SSHIFT                   \ [0x1e] Sample shift By default, the HSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The software must ensure that SSHIFTÂ =Â 0 when the data phase is configured in DTR mode (when DDTRÂ =Â 1.)
  [then]


  [ifdef] HSPI1_HSPI_IR_DEF
    \
    \ @brief HSPI instruction register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_INSTRUCTION              \ [0x00 : 32] Instruction Instruction to be sent to the external SPI device
  [then]


  [ifdef] HSPI1_HSPI_ABR_DEF
    \
    \ @brief HSPI alternate bytes register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_ALTERNATE                \ [0x00 : 32] [31: 0]: Alternate bytes Optional data to be send to the external SPI device right after the address.
  [then]


  [ifdef] HSPI1_HSPI_LPTR_DEF
    \
    \ @brief HSPI low-power timeout register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_TIMEOUT                  \ [0x00 : 16] [15: 0]: Timeout period After each access in Memory-mapped mode, the HSPI prefetches the subsequent bytes and hold them in the FIFO. This field indicates how many CLK cycles the HSPI waits after the clock becomes inactive and until it raises the nCS, putting the external device in a lower-consumption state.
  [then]


  [ifdef] HSPI1_HSPI_WPCCR_DEF
    \
    \ @brief HSPI wrap communication configuration register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_IMODE                    \ [0x00 : 3] Instruction mode This field defines the instruction phase mode of operation. 101-111: Reserved
    $03 constant HSPI1_IDTR                     \ [0x03] Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
    $04 constant HSPI1_ISIZE                    \ [0x04 : 2] Instruction size This field defines instruction size.
    $08 constant HSPI1_ADMODE                   \ [0x08 : 3] Address mode This field defines the address phase mode of operation. 101-111: Reserved
    $0b constant HSPI1_ADDTR                    \ [0x0b] Address double transfer rate This bit sets the DTR mode for the address phase.
    $0c constant HSPI1_ADSIZE                   \ [0x0c : 2] Address size This field defines address size.
    $10 constant HSPI1_ABMODE                   \ [0x10 : 3] Alternate-byte mode This field defines the alternate byte phase mode of operation.
    $13 constant HSPI1_ABDTR                    \ [0x13] Alternate bytes double transfer rate This bit sets the DTR mode for the alternate bytes phase.
    $14 constant HSPI1_ABSIZE                   \ [0x14 : 2] Alternate bytes size This bit defines alternate bytes size.
    $18 constant HSPI1_DMODE                    \ [0x18 : 3] Data mode This field defines the data phase mode of operation. 101; Data on 16 lines 110-111: Reserved
    $1b constant HSPI1_DDTR                     \ [0x1b] Data double transfer rate This bit sets the DTR mode for the data phase.
    $1d constant HSPI1_DQSE                     \ [0x1d] DQS enable This bit enables the data strobe management.
  [then]


  [ifdef] HSPI1_HSPI_WPTCR_DEF
    \
    \ @brief HSPI wrap timing configuration register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_DCYC                     \ [0x00 : 5] Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31). It is recommended to have at least 5 dummy cycles when using memories with DQS activated.
    $1c constant HSPI1_DHQC                     \ [0x1c] Delay hold quarter cycle Add a quarter cycle delay on the outputs in DTR communication to match hold requirement.
    $1e constant HSPI1_SSHIFT                   \ [0x1e] Sample shift By default, the HSPI samples data 1/2 of a CLK cycle after the data is driven by the external device. This bit allows the data to be sampled later in order to consider the external signal delays. The firmware must assure that SSHIFT=0 when the data phase is configured in DTR mode (when DDTRÂ =Â 1).
  [then]


  [ifdef] HSPI1_HSPI_WPIR_DEF
    \
    \ @brief HSPI wrap instruction register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_INSTRUCTION              \ [0x00 : 32] [31: 0]: Instruction Instruction to be sent to the external SPI device
  [then]


  [ifdef] HSPI1_HSPI_WPABR_DEF
    \
    \ @brief HSPI wrap alternate bytes register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_ALTERNATE                \ [0x00 : 32] [31: 0]: Alternate bytes Optional data to be sent to the external SPI device right after the address
  [then]


  [ifdef] HSPI1_HSPI_WCCR_DEF
    \
    \ @brief HSPI write communication configuration register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_IMODE                    \ [0x00 : 3] Instruction mode This field defines the instruction phase mode of operation. 101-111: Reserved
    $03 constant HSPI1_IDTR                     \ [0x03] Instruction double transfer rate This bit sets the DTR mode for the instruction phase.
    $04 constant HSPI1_ISIZE                    \ [0x04 : 2] Instruction size This bit defines instruction size:
    $08 constant HSPI1_ADMODE                   \ [0x08 : 3] Address mode This field defines the address phase mode of operation. 101-111: Reserved
    $0b constant HSPI1_ADDTR                    \ [0x0b] Address double transfer rate This bit sets the DTR mode for the address phase.
    $0c constant HSPI1_ADSIZE                   \ [0x0c : 2] Address size This field defines address size.
    $10 constant HSPI1_ABMODE                   \ [0x10 : 3] Alternate-byte mode This field defines the alternate-byte phase mode of operation. 101-111: Reserved
    $13 constant HSPI1_ABDTR                    \ [0x13] Alternate bytes double-transfer rate This bit sets the DTR mode for the alternate-bytes phase.
    $14 constant HSPI1_ABSIZE                   \ [0x14 : 2] Alternate bytes size This field defines alternate bytes size:
    $18 constant HSPI1_DMODE                    \ [0x18 : 3] Data mode This field defines the data phase mode of operation.
    $1b constant HSPI1_DDTR                     \ [0x1b] data double transfer rate This bit sets the DTR mode for the data phase.
    $1d constant HSPI1_DQSE                     \ [0x1d] DQS enable This bit enables the data strobe management.
  [then]


  [ifdef] HSPI1_HSPI_WTCR_DEF
    \
    \ @brief HSPI write timing configuration register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_DCYC                     \ [0x00 : 5] Number of dummy cycles This field defines the duration of the dummy phase. In both SDR and DTR modes, it specifies a number of CLK cycles (0-31). It is recommended to have at least 5 dummy cycles when using memories with DQS activated.
  [then]


  [ifdef] HSPI1_HSPI_WIR_DEF
    \
    \ @brief HSPI write instruction register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_INSTRUCTION              \ [0x00 : 32] Instruction Instruction to be sent to the external SPI device
  [then]


  [ifdef] HSPI1_HSPI_WABR_DEF
    \
    \ @brief HSPI write alternate bytes register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_ALTERNATE                \ [0x00 : 32] [31: 0]: Alternate bytes Optional data to be sent to the external SPI device right after the address
  [then]


  [ifdef] HSPI1_HSPI_HLCR_DEF
    \
    \ @brief HSPI HyperBus latency configuration register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_LM                       \ [0x00] Latency mode This bit selects the Latency mode.
    $01 constant HSPI1_WZL                      \ [0x01] Write zero latency This bit enables zero latency on write operations.
    $08 constant HSPI1_TACC                     \ [0x08 : 8] [7: 0]: Access time Device access time expressed in number of communication clock cycles
    $10 constant HSPI1_TRWR                     \ [0x10 : 8] Read write recovery time Device read write recovery time expressed in number of communication clock cycles
  [then]


  [ifdef] HSPI1_HSPI_CALFCR_DEF
    \
    \ @brief HSPI full-cycle calibration configuration
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_FINE                     \ [0x00 : 7] [6: 0]: Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $10 constant HSPI1_COARSE                   \ [0x10 : 5] [4: 0]: Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $1f constant HSPI1_CALMAX                   \ [0x1f] Max value This bit gets set when the memory-clock period is outside the range of DLLM, in which case HSPI_CALFCR and HSPI_CALSR are updated with the values for the maximum delay.
  [then]


  [ifdef] HSPI1_HSPI_CALMR_DEF
    \
    \ @brief HSPI DLL master calibration configuration
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_FINE                     \ [0x00 : 7] [6: 0]: Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $10 constant HSPI1_COARSE                   \ [0x10 : 5] [4: 0]: Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
  [then]


  [ifdef] HSPI1_HSPI_CALSOR_DEF
    \
    \ @brief HSPI DLL slave output calibration configuration
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_FINE                     \ [0x00 : 7] [6: 0]: Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $10 constant HSPI1_COARSE                   \ [0x10 : 5] [4: 0]: Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
  [then]


  [ifdef] HSPI1_HSPI_CALSIR_DEF
    \
    \ @brief HSPI DLL slave input calibration configuration
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant HSPI1_FINE                     \ [0x00 : 7] [6: 0]: Fine calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
    $10 constant HSPI1_COARSE                   \ [0x10 : 5] [4: 0]: Coarse calibration The unitary value of delay for this field depends on product technology (refer to the product datasheet).
  [then]

  \
  \ @brief HSPI1
  \
  $00 constant HSPI1_HSPI_CR            \ HSPI control register
  $08 constant HSPI1_HSPI_DCR1          \ HSPI device configuration register 1
  $0C constant HSPI1_HSPI_DCR2          \ HSPI device configuration register 2
  $10 constant HSPI1_HSPI_DCR3          \ HSPI device configuration register 3
  $14 constant HSPI1_HSPI_DCR4          \ HSPI device configuration register 4
  $20 constant HSPI1_HSPI_SR            \ Transfer error flag This bit is set in Indirect mode when an invalid address is being accessed in Indirect mode. It is cleared by writing 1 to CTEF.
  $24 constant HSPI1_HSPI_FCR           \ Clear transfer error flag Writing 1 clears the TEF flag in the HSPI_SR register.
  $40 constant HSPI1_HSPI_DLR           \ HSPI data length register
  $48 constant HSPI1_HSPI_AR            \ Address Address to be sent to the external device. In HyperBus mode, this field must be even as this protocol is 16-bit word oriented. In dual-memory mode, AR[0] is forced to 1. Writes to this field are ignored when BUSYÂ =Â 1 or when FMODE = 11 (Memory-mapped mode).
  $50 constant HSPI1_HSPI_DR            \ [31: 0]: Data Data to be sent/received to/from the external SPI device In Indirect-write mode, data written to this register is stored on the FIFO before it is sent to the external device during the data phase. If the FIFO is too full, a write operation is stalled until the FIFO has enough space to accept the amount of data being written. In Indirect-read mode, reading this register gives (via the FIFO) the data that was received from the external device. If the FIFO does not have as many bytes as requested by the read operation and if BUSYÂ =Â 1, the read operation is stalled until enough data is present or until the transfer is complete, whichever happens first. In Automatic-polling mode, this register contains the last data read from the external device (without masking). Word, half-word, and byte accesses to this register are supported. In Indirect-write mode, a byte write adds 1 byte to the FIFO, a half-word write 2 bytes, and a word write 4 bytes. Similarly, in Indirect-read mode, a byte read removes 1 byte from the FIFO, a halfword read 2Â bytes, and a word read 4Â bytes. Accesses in Indirect mode must be aligned to the bottom of this register: A byte read must read DATA[7:0] and a half-word read must read DATA[15:0].
  $80 constant HSPI1_HSPI_PSMKR         \ HSPI polling status mask register
  $88 constant HSPI1_HSPI_PSMAR         \ HSPI polling status match register
  $90 constant HSPI1_HSPI_PIR           \ HSPI polling interval register
  $100 constant HSPI1_HSPI_CCR          \ HSPI communication configuration register
  $108 constant HSPI1_HSPI_TCR          \ HSPI timing configuration register
  $110 constant HSPI1_HSPI_IR           \ HSPI instruction register
  $120 constant HSPI1_HSPI_ABR          \ HSPI alternate bytes register
  $130 constant HSPI1_HSPI_LPTR         \ HSPI low-power timeout register
  $140 constant HSPI1_HSPI_WPCCR        \ HSPI wrap communication configuration register
  $148 constant HSPI1_HSPI_WPTCR        \ HSPI wrap timing configuration register
  $150 constant HSPI1_HSPI_WPIR         \ HSPI wrap instruction register
  $160 constant HSPI1_HSPI_WPABR        \ HSPI wrap alternate bytes register
  $180 constant HSPI1_HSPI_WCCR         \ HSPI write communication configuration register
  $188 constant HSPI1_HSPI_WTCR         \ HSPI write timing configuration register
  $190 constant HSPI1_HSPI_WIR          \ HSPI write instruction register
  $1A0 constant HSPI1_HSPI_WABR         \ HSPI write alternate bytes register
  $200 constant HSPI1_HSPI_HLCR         \ HSPI HyperBus latency configuration register
  $210 constant HSPI1_HSPI_CALFCR       \ HSPI full-cycle calibration configuration
  $218 constant HSPI1_HSPI_CALMR        \ HSPI DLL master calibration configuration
  $220 constant HSPI1_HSPI_CALSOR       \ HSPI DLL slave output calibration configuration
  $228 constant HSPI1_HSPI_CALSIR       \ HSPI DLL slave input calibration configuration

: HSPI1_DEF ; [then]
