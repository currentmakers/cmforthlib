\
\ @file fmc.fs
\ @brief Flexible memory controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SRAM/NOR-flash chip-select control registers for bank 1
\ Address offset: 0x00
\ Reset value: 0x000030DB
\

$00000001 constant FMC_FMC_BCR1_MBKEN                               \ Memory bank enable bit This bit enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AXI bus.
$00000002 constant FMC_FMC_BCR1_MUXEN                               \ Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
$0000000c constant FMC_FMC_BCR1_MTYP                                \ Memory type These bits define the type of external memory attached to the corresponding memory bank:
$00000030 constant FMC_FMC_BCR1_MWID                                \ Memory data bus width Defines the external memory device width, valid for all type of memories.
$00000040 constant FMC_FMC_BCR1_FACCEN                              \ Flash access enable This bit enables NOR flash memory access operations.
$00000100 constant FMC_FMC_BCR1_BURSTEN                             \ Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode:
$00000200 constant FMC_FMC_BCR1_WAITPOL                             \ Wait signal polarity bit This bit defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode:
$00000800 constant FMC_FMC_BCR1_WAITCFG                             \ Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
$00001000 constant FMC_FMC_BCR1_WREN                                \ Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC:
$00002000 constant FMC_FMC_BCR1_WAITEN                              \ Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
$00004000 constant FMC_FMC_BCR1_EXTMOD                              \ Extended mode enable. This bit enables the FMC to program the write timings for asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in Mode1 or Mode2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP =0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
$00008000 constant FMC_FMC_BCR1_ASYNCWAIT                           \ Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
$00070000 constant FMC_FMC_BCR1_CPSIZE                              \ CRAM Page Size These are used for Cellular RAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Other configuration: reserved.
$00080000 constant FMC_FMC_BCR1_CBURSTRW                            \ Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
$00100000 constant FMC_FMC_BCR1_CCLKEN                              \ Continuous Clock Enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is dont care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
$00200000 constant FMC_FMC_BCR1_WFDIS                               \ Write FIFO Disable This bit disables the Write FIFO used by the FMC. Note: The WFDIS bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.
$03000000 constant FMC_FMC_BCR1_BMAP                                \ FMC bank mapping These bits allow different remap or swap of the FMC NOR/PSRAM and SDRAM banks (refer to Table 144). Note: The BMAP bits of the FMC_BCR2..4 registers are dont care. It is only enabled through the FMC_BCR1 register.
$80000000 constant FMC_FMC_BCR1_FMCEN                               \ FMC Enable This bit enables/disables the FMC. Note: The FMCEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.


\
\ @brief SRAM/NOR-flash chip-select timing registers for bank 1
\ Address offset: 0x04
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BTR1_ADDSET                              \ Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 109 to Figure 121), used in SRAMs, ROMs and asynchronous NOR flash: ... For each access mode address setup phase duration, please refer to the respective figure (refer to Figure 109 to Figure 121). Note: In synchronous accesses, this value is dont care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
$000000f0 constant FMC_FMC_BTR1_ADDHLD                              \ Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 109 to Figure 121), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, please refer to the respective figure (Figure 109 to Figure 121). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
$0000ff00 constant FMC_FMC_BTR1_DATAST                              \ Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 109 to Figure 121), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, please refer to the respective figure (Figure 109 to Figure 121). Example: Mode1, write access, DATAST = 1: Data-phase duration = DATAST+1 = 1 x fmc_ker_ck clock cycles. Note: In synchronous accesses, this value is dont care.
$000f0000 constant FMC_FMC_BTR1_BUSTURN                             \ Bus turnaround phase duration These bits are written by software to add a delay at the end of a write-to-read (and read-to-write) transaction. This delay allows to match the minimum time between consecutive transactions (t<sub>EHEL</sub> from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t<sub>EHQZ</sub>). The programmed bus turnaround delay is inserted between an asynchronous read (muxed or mode D) or write transaction and any other asynchronous /synchronous read or write to or from a static bank. The bank can be the same or different in case of read, in case of write the bank can be different except for muxed or mode D. In some cases, whatever the programmed BUSTURN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed and D modes. There is a bus turnaround delay of 1 FMC clock cycle between: Two consecutive asynchronous read transfers to the same static memory bank except for muxed and D modes. An asynchronous read to an asynchronous or synchronous write to any static bank or dynamic bank except for muxed and D modes. An asynchronous (modes 1, 2, A, B or C) read and a read from another static bank. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to the same bank. A synchronous write (burst or single) access and an asynchronous write or read transfer to or from static memory bank (the bank can be the same or different for the case of read. Two consecutive synchronous reads (burst or single) followed by any synchronous/asynchronous read or write from/to another static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to different static bank. A synchronous write (burst or single) access and a synchronous read from the same or a different bank. ...
$00f00000 constant FMC_FMC_BTR1_CLKDIV                              \ Clock divide ratio (for FMC_CLK signal) These bits define the period of FMC_CLK clock output signal, expressed in number of fmc_ker_ck cycles: In asynchronous NOR flash, SRAM or PSRAM accesses, this value is dont care. Note: Refer to Section 23.7.5: Synchronous transactions for FMC_CLK divider ratio formula)
$0f000000 constant FMC_FMC_BTR1_DATLAT                              \ (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), these bits define the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in fmc_ker_ck periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
$30000000 constant FMC_FMC_BTR1_ACCMOD                              \ Access mode These bits specify the Asynchronous access modes as shown in the timing diagrams. They are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.


\
\ @brief SRAM/NOR-flash chip-select control registers for bank 2
\ Address offset: 0x08
\ Reset value: 0x000030D2
\

$00000001 constant FMC_FMC_BCR2_MBKEN                               \ Memory bank enable bit This bit enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AXI bus.
$00000002 constant FMC_FMC_BCR2_MUXEN                               \ Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
$0000000c constant FMC_FMC_BCR2_MTYP                                \ Memory type These bits define the type of external memory attached to the corresponding memory bank:
$00000030 constant FMC_FMC_BCR2_MWID                                \ Memory data bus width Defines the external memory device width, valid for all type of memories.
$00000040 constant FMC_FMC_BCR2_FACCEN                              \ Flash access enable This bit enables NOR flash memory access operations.
$00000100 constant FMC_FMC_BCR2_BURSTEN                             \ Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode:
$00000200 constant FMC_FMC_BCR2_WAITPOL                             \ Wait signal polarity bit This bit defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode:
$00000800 constant FMC_FMC_BCR2_WAITCFG                             \ Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
$00001000 constant FMC_FMC_BCR2_WREN                                \ Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC:
$00002000 constant FMC_FMC_BCR2_WAITEN                              \ Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
$00004000 constant FMC_FMC_BCR2_EXTMOD                              \ Extended mode enable. This bit enables the FMC to program the write timings for asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in Mode1 or Mode2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP =0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
$00008000 constant FMC_FMC_BCR2_ASYNCWAIT                           \ Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
$00070000 constant FMC_FMC_BCR2_CPSIZE                              \ CRAM Page Size These are used for Cellular RAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Other configuration: reserved.
$00080000 constant FMC_FMC_BCR2_CBURSTRW                            \ Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
$00100000 constant FMC_FMC_BCR2_CCLKEN                              \ Continuous Clock Enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is dont care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
$00200000 constant FMC_FMC_BCR2_WFDIS                               \ Write FIFO Disable This bit disables the Write FIFO used by the FMC. Note: The WFDIS bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.
$03000000 constant FMC_FMC_BCR2_BMAP                                \ FMC bank mapping These bits allow different remap or swap of the FMC NOR/PSRAM and SDRAM banks (refer to Table 144). Note: The BMAP bits of the FMC_BCR2..4 registers are dont care. It is only enabled through the FMC_BCR1 register.
$80000000 constant FMC_FMC_BCR2_FMCEN                               \ FMC Enable This bit enables/disables the FMC. Note: The FMCEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.


\
\ @brief SRAM/NOR-flash chip-select timing registers for bank 2
\ Address offset: 0x0C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BTR2_ADDSET                              \ Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 109 to Figure 121), used in SRAMs, ROMs and asynchronous NOR flash: ... For each access mode address setup phase duration, please refer to the respective figure (refer to Figure 109 to Figure 121). Note: In synchronous accesses, this value is dont care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
$000000f0 constant FMC_FMC_BTR2_ADDHLD                              \ Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 109 to Figure 121), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, please refer to the respective figure (Figure 109 to Figure 121). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
$0000ff00 constant FMC_FMC_BTR2_DATAST                              \ Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 109 to Figure 121), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, please refer to the respective figure (Figure 109 to Figure 121). Example: Mode1, write access, DATAST = 1: Data-phase duration = DATAST+1 = 1 x fmc_ker_ck clock cycles. Note: In synchronous accesses, this value is dont care.
$000f0000 constant FMC_FMC_BTR2_BUSTURN                             \ Bus turnaround phase duration These bits are written by software to add a delay at the end of a write-to-read (and read-to-write) transaction. This delay allows to match the minimum time between consecutive transactions (t<sub>EHEL</sub> from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t<sub>EHQZ</sub>). The programmed bus turnaround delay is inserted between an asynchronous read (muxed or mode D) or write transaction and any other asynchronous /synchronous read or write to or from a static bank. The bank can be the same or different in case of read, in case of write the bank can be different except for muxed or mode D. In some cases, whatever the programmed BUSTURN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed and D modes. There is a bus turnaround delay of 1 FMC clock cycle between: Two consecutive asynchronous read transfers to the same static memory bank except for muxed and D modes. An asynchronous read to an asynchronous or synchronous write to any static bank or dynamic bank except for muxed and D modes. An asynchronous (modes 1, 2, A, B or C) read and a read from another static bank. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to the same bank. A synchronous write (burst or single) access and an asynchronous write or read transfer to or from static memory bank (the bank can be the same or different for the case of read. Two consecutive synchronous reads (burst or single) followed by any synchronous/asynchronous read or write from/to another static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to different static bank. A synchronous write (burst or single) access and a synchronous read from the same or a different bank. ...
$00f00000 constant FMC_FMC_BTR2_CLKDIV                              \ Clock divide ratio (for FMC_CLK signal) These bits define the period of FMC_CLK clock output signal, expressed in number of fmc_ker_ck cycles: In asynchronous NOR flash, SRAM or PSRAM accesses, this value is dont care. Note: Refer to Section 23.7.5: Synchronous transactions for FMC_CLK divider ratio formula)
$0f000000 constant FMC_FMC_BTR2_DATLAT                              \ (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), these bits define the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in fmc_ker_ck periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
$30000000 constant FMC_FMC_BTR2_ACCMOD                              \ Access mode These bits specify the Asynchronous access modes as shown in the timing diagrams. They are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.


\
\ @brief SRAM/NOR-flash chip-select control registers for bank 3
\ Address offset: 0x10
\ Reset value: 0x000030D2
\

$00000001 constant FMC_FMC_BCR3_MBKEN                               \ Memory bank enable bit This bit enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AXI bus.
$00000002 constant FMC_FMC_BCR3_MUXEN                               \ Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
$0000000c constant FMC_FMC_BCR3_MTYP                                \ Memory type These bits define the type of external memory attached to the corresponding memory bank:
$00000030 constant FMC_FMC_BCR3_MWID                                \ Memory data bus width Defines the external memory device width, valid for all type of memories.
$00000040 constant FMC_FMC_BCR3_FACCEN                              \ Flash access enable This bit enables NOR flash memory access operations.
$00000100 constant FMC_FMC_BCR3_BURSTEN                             \ Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode:
$00000200 constant FMC_FMC_BCR3_WAITPOL                             \ Wait signal polarity bit This bit defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode:
$00000800 constant FMC_FMC_BCR3_WAITCFG                             \ Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
$00001000 constant FMC_FMC_BCR3_WREN                                \ Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC:
$00002000 constant FMC_FMC_BCR3_WAITEN                              \ Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
$00004000 constant FMC_FMC_BCR3_EXTMOD                              \ Extended mode enable. This bit enables the FMC to program the write timings for asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in Mode1 or Mode2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP =0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
$00008000 constant FMC_FMC_BCR3_ASYNCWAIT                           \ Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
$00070000 constant FMC_FMC_BCR3_CPSIZE                              \ CRAM Page Size These are used for Cellular RAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Other configuration: reserved.
$00080000 constant FMC_FMC_BCR3_CBURSTRW                            \ Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
$00100000 constant FMC_FMC_BCR3_CCLKEN                              \ Continuous Clock Enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is dont care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
$00200000 constant FMC_FMC_BCR3_WFDIS                               \ Write FIFO Disable This bit disables the Write FIFO used by the FMC. Note: The WFDIS bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.
$03000000 constant FMC_FMC_BCR3_BMAP                                \ FMC bank mapping These bits allow different remap or swap of the FMC NOR/PSRAM and SDRAM banks (refer to Table 144). Note: The BMAP bits of the FMC_BCR2..4 registers are dont care. It is only enabled through the FMC_BCR1 register.
$80000000 constant FMC_FMC_BCR3_FMCEN                               \ FMC Enable This bit enables/disables the FMC. Note: The FMCEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.


\
\ @brief SRAM/NOR-flash chip-select timing registers for bank 3
\ Address offset: 0x14
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BTR3_ADDSET                              \ Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 109 to Figure 121), used in SRAMs, ROMs and asynchronous NOR flash: ... For each access mode address setup phase duration, please refer to the respective figure (refer to Figure 109 to Figure 121). Note: In synchronous accesses, this value is dont care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
$000000f0 constant FMC_FMC_BTR3_ADDHLD                              \ Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 109 to Figure 121), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, please refer to the respective figure (Figure 109 to Figure 121). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
$0000ff00 constant FMC_FMC_BTR3_DATAST                              \ Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 109 to Figure 121), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, please refer to the respective figure (Figure 109 to Figure 121). Example: Mode1, write access, DATAST = 1: Data-phase duration = DATAST+1 = 1 x fmc_ker_ck clock cycles. Note: In synchronous accesses, this value is dont care.
$000f0000 constant FMC_FMC_BTR3_BUSTURN                             \ Bus turnaround phase duration These bits are written by software to add a delay at the end of a write-to-read (and read-to-write) transaction. This delay allows to match the minimum time between consecutive transactions (t<sub>EHEL</sub> from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t<sub>EHQZ</sub>). The programmed bus turnaround delay is inserted between an asynchronous read (muxed or mode D) or write transaction and any other asynchronous /synchronous read or write to or from a static bank. The bank can be the same or different in case of read, in case of write the bank can be different except for muxed or mode D. In some cases, whatever the programmed BUSTURN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed and D modes. There is a bus turnaround delay of 1 FMC clock cycle between: Two consecutive asynchronous read transfers to the same static memory bank except for muxed and D modes. An asynchronous read to an asynchronous or synchronous write to any static bank or dynamic bank except for muxed and D modes. An asynchronous (modes 1, 2, A, B or C) read and a read from another static bank. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to the same bank. A synchronous write (burst or single) access and an asynchronous write or read transfer to or from static memory bank (the bank can be the same or different for the case of read. Two consecutive synchronous reads (burst or single) followed by any synchronous/asynchronous read or write from/to another static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to different static bank. A synchronous write (burst or single) access and a synchronous read from the same or a different bank. ...
$00f00000 constant FMC_FMC_BTR3_CLKDIV                              \ Clock divide ratio (for FMC_CLK signal) These bits define the period of FMC_CLK clock output signal, expressed in number of fmc_ker_ck cycles: In asynchronous NOR flash, SRAM or PSRAM accesses, this value is dont care. Note: Refer to Section 23.7.5: Synchronous transactions for FMC_CLK divider ratio formula)
$0f000000 constant FMC_FMC_BTR3_DATLAT                              \ (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), these bits define the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in fmc_ker_ck periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
$30000000 constant FMC_FMC_BTR3_ACCMOD                              \ Access mode These bits specify the Asynchronous access modes as shown in the timing diagrams. They are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.


\
\ @brief SRAM/NOR-flash chip-select control registers for bank 4
\ Address offset: 0x18
\ Reset value: 0x000030D2
\

$00000001 constant FMC_FMC_BCR4_MBKEN                               \ Memory bank enable bit This bit enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AXI bus.
$00000002 constant FMC_FMC_BCR4_MUXEN                               \ Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
$0000000c constant FMC_FMC_BCR4_MTYP                                \ Memory type These bits define the type of external memory attached to the corresponding memory bank:
$00000030 constant FMC_FMC_BCR4_MWID                                \ Memory data bus width Defines the external memory device width, valid for all type of memories.
$00000040 constant FMC_FMC_BCR4_FACCEN                              \ Flash access enable This bit enables NOR flash memory access operations.
$00000100 constant FMC_FMC_BCR4_BURSTEN                             \ Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode:
$00000200 constant FMC_FMC_BCR4_WAITPOL                             \ Wait signal polarity bit This bit defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode:
$00000800 constant FMC_FMC_BCR4_WAITCFG                             \ Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
$00001000 constant FMC_FMC_BCR4_WREN                                \ Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC:
$00002000 constant FMC_FMC_BCR4_WAITEN                              \ Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
$00004000 constant FMC_FMC_BCR4_EXTMOD                              \ Extended mode enable. This bit enables the FMC to program the write timings for asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in Mode1 or Mode2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP =0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
$00008000 constant FMC_FMC_BCR4_ASYNCWAIT                           \ Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
$00070000 constant FMC_FMC_BCR4_CPSIZE                              \ CRAM Page Size These are used for Cellular RAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Other configuration: reserved.
$00080000 constant FMC_FMC_BCR4_CBURSTRW                            \ Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
$00100000 constant FMC_FMC_BCR4_CCLKEN                              \ Continuous Clock Enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is dont care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
$00200000 constant FMC_FMC_BCR4_WFDIS                               \ Write FIFO Disable This bit disables the Write FIFO used by the FMC. Note: The WFDIS bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.
$03000000 constant FMC_FMC_BCR4_BMAP                                \ FMC bank mapping These bits allow different remap or swap of the FMC NOR/PSRAM and SDRAM banks (refer to Table 144). Note: The BMAP bits of the FMC_BCR2..4 registers are dont care. It is only enabled through the FMC_BCR1 register.
$80000000 constant FMC_FMC_BCR4_FMCEN                               \ FMC Enable This bit enables/disables the FMC. Note: The FMCEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.


\
\ @brief SRAM/NOR-flash chip-select timing registers for bank 4
\ Address offset: 0x1C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BTR4_ADDSET                              \ Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 109 to Figure 121), used in SRAMs, ROMs and asynchronous NOR flash: ... For each access mode address setup phase duration, please refer to the respective figure (refer to Figure 109 to Figure 121). Note: In synchronous accesses, this value is dont care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
$000000f0 constant FMC_FMC_BTR4_ADDHLD                              \ Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 109 to Figure 121), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, please refer to the respective figure (Figure 109 to Figure 121). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
$0000ff00 constant FMC_FMC_BTR4_DATAST                              \ Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 109 to Figure 121), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, please refer to the respective figure (Figure 109 to Figure 121). Example: Mode1, write access, DATAST = 1: Data-phase duration = DATAST+1 = 1 x fmc_ker_ck clock cycles. Note: In synchronous accesses, this value is dont care.
$000f0000 constant FMC_FMC_BTR4_BUSTURN                             \ Bus turnaround phase duration These bits are written by software to add a delay at the end of a write-to-read (and read-to-write) transaction. This delay allows to match the minimum time between consecutive transactions (t<sub>EHEL</sub> from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t<sub>EHQZ</sub>). The programmed bus turnaround delay is inserted between an asynchronous read (muxed or mode D) or write transaction and any other asynchronous /synchronous read or write to or from a static bank. The bank can be the same or different in case of read, in case of write the bank can be different except for muxed or mode D. In some cases, whatever the programmed BUSTURN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed and D modes. There is a bus turnaround delay of 1 FMC clock cycle between: Two consecutive asynchronous read transfers to the same static memory bank except for muxed and D modes. An asynchronous read to an asynchronous or synchronous write to any static bank or dynamic bank except for muxed and D modes. An asynchronous (modes 1, 2, A, B or C) read and a read from another static bank. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to the same bank. A synchronous write (burst or single) access and an asynchronous write or read transfer to or from static memory bank (the bank can be the same or different for the case of read. Two consecutive synchronous reads (burst or single) followed by any synchronous/asynchronous read or write from/to another static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to different static bank. A synchronous write (burst or single) access and a synchronous read from the same or a different bank. ...
$00f00000 constant FMC_FMC_BTR4_CLKDIV                              \ Clock divide ratio (for FMC_CLK signal) These bits define the period of FMC_CLK clock output signal, expressed in number of fmc_ker_ck cycles: In asynchronous NOR flash, SRAM or PSRAM accesses, this value is dont care. Note: Refer to Section 23.7.5: Synchronous transactions for FMC_CLK divider ratio formula)
$0f000000 constant FMC_FMC_BTR4_DATLAT                              \ (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), these bits define the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in fmc_ker_ck periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
$30000000 constant FMC_FMC_BTR4_ACCMOD                              \ Access mode These bits specify the Asynchronous access modes as shown in the timing diagrams. They are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.


\
\ @brief NAND flash control registers
\ Address offset: 0x80
\ Reset value: 0x00000018
\

$00000002 constant FMC_FMC_PCR_PWAITEN                              \ Wait feature enable bit. This bit enables the Wait feature for the NAND flash memory bank:
$00000004 constant FMC_FMC_PCR_PBKEN                                \ NAND flash memory bank enable bit. This bit enables the memory bank. Accessing a disabled memory bank causes an ERROR on AXI bus
$00000030 constant FMC_FMC_PCR_PWID                                 \ Data bus width. These bits define the external memory device width.
$00000040 constant FMC_FMC_PCR_ECCEN                                \ ECC computation logic enable bit
$00001e00 constant FMC_FMC_PCR_TCLR                                 \ CLE to RE delay. These bits set time from CLE low to RE low in number of fmc_ker_ck clock cycles. The time is give by the following formula: t_clr = (TCLR + SET + 2) t<sub>fmc_ker_ck</sub> where t<sub>fmc_ker_ck</sub> is the fmc_ker_ck clock period Note: Set is MEMSET or ATTSET according to the addressed space.
$00002000 constant FMC_FMC_PCR_TAR0                                 \ ALE to RE delay. These bits set time from ALE low to RE low in number of fmc_ker_ck clock cycles. Time is: t_ar = (TAR + SET + 2) t<sub>fmc_ker_ck</sub> where t<sub>fmc_ker_ck</sub> is the FMC clock period Note: Set is MEMSET or ATTSET according to the addressed space.
$00004000 constant FMC_FMC_PCR_TAR1                                 \ ALE to RE delay. These bits set time from ALE low to RE low in number of fmc_ker_ck clock cycles. Time is: t_ar = (TAR + SET + 2) t<sub>fmc_ker_ck</sub> where t<sub>fmc_ker_ck</sub> is the FMC clock period Note: Set is MEMSET or ATTSET according to the addressed space.
$00008000 constant FMC_FMC_PCR_TAR2                                 \ ALE to RE delay. These bits set time from ALE low to RE low in number of fmc_ker_ck clock cycles. Time is: t_ar = (TAR + SET + 2) t<sub>fmc_ker_ck</sub> where t<sub>fmc_ker_ck</sub> is the FMC clock period Note: Set is MEMSET or ATTSET according to the addressed space.
$00010000 constant FMC_FMC_PCR_TAR3                                 \ ALE to RE delay. These bits set time from ALE low to RE low in number of fmc_ker_ck clock cycles. Time is: t_ar = (TAR + SET + 2) t<sub>fmc_ker_ck</sub> where t<sub>fmc_ker_ck</sub> is the FMC clock period Note: Set is MEMSET or ATTSET according to the addressed space.
$000e0000 constant FMC_FMC_PCR_ECCPS                                \ ECC page size. These bits define the page size for the extended ECC:


\
\ @brief FIFO status and interrupt register
\ Address offset: 0x84
\ Reset value: 0x00000040
\

$00000001 constant FMC_FMC_SR_IRS                                   \ Interrupt rising edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it will be set.
$00000002 constant FMC_FMC_SR_ILS                                   \ Interrupt high-level status The flag is set by hardware and reset by software.
$00000004 constant FMC_FMC_SR_IFS                                   \ Interrupt falling edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it will be set.
$00000008 constant FMC_FMC_SR_IREN                                  \ Interrupt rising edge detection enable bit
$00000010 constant FMC_FMC_SR_ILEN                                  \ Interrupt high-level detection enable bit
$00000020 constant FMC_FMC_SR_IFEN                                  \ Interrupt falling edge detection enable bit
$00000040 constant FMC_FMC_SR_FEMPT                                 \ FIFO empty. Read-only bit that provides the status of the FIFO


\
\ @brief Common memory space timing register
\ Address offset: 0x88
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FMC_FMC_PMEM_MEMSET                              \ Common memory x setup time These bits define the number of fmc_ker_ck (+1) clock cycles to set up the address before the command assertion (NWE, NOE), for NAND flash read or write access to common memory space:
$0000ff00 constant FMC_FMC_PMEM_MEMWAIT                             \ Common memory wait time These bits define the minimum number of fmc_ker_ck (+1) clock cycles to assert the command (NWE, NOE), for NAND flash read or write access to common memory space. The duration of command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of fmc_ker_ck:
$00ff0000 constant FMC_FMC_PMEM_MEMHOLD                             \ Common memory hold time These bits define the number of fmc_ker_ck clock cycles for write accesses and fmc_ker_ck+1 clock cycles for read accesses during which the address is held (and data for write accesses) after the command is deasserted (NWE, NOE), for NAND flash read or write access to common memory space:
$ff000000 constant FMC_FMC_PMEM_MEMHIZ                              \ Common memory x data bus Hi-Z time These bits define the number of fmc_ker_ck clock cycles during which the data bus is kept Hi-Z after the start of a NAND flash write access to common memory space. This is only valid for write transactions:


\
\ @brief Attribute memory space timing registers
\ Address offset: 0x8C
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FMC_FMC_PATT_ATTSET                              \ Attribute memory setup time These bits define the number of fmc_ker_ck (+1) clock cycles to set up address before the command assertion (NWE, NOE), for NAND flash read or write access to attribute memory space:
$0000ff00 constant FMC_FMC_PATT_ATTWAIT                             \ Attribute memory wait time These bits define the minimum number of x fmc_ker_ck (+1) clock cycles to assert the command (NWE, NOE), for NAND flash read or write access to attribute memory space. The duration for command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of fmc_ker_ck:
$00ff0000 constant FMC_FMC_PATT_ATTHOLD                             \ Attribute memory hold time These bits define the number of fmc_ker_ck clock cycles during which the address is held (and data for write access) after the command deassertion (NWE, NOE), for NAND flash read or write access to attribute memory space:
$ff000000 constant FMC_FMC_PATT_ATTHIZ                              \ Attribute memory data bus Hi-Z time These bits define the number of fmc_ker_ck clock cycles during which the data bus is kept in Hi-Z after the start of a NAND flash write access to attribute memory space on socket. Only valid for writ transaction:


\
\ @brief ECC result registers
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant FMC_FMC_ECCR_ECC                                 \ ECC result This field contains the value computed by the ECC computation logic. Table 184 describes the contents of these bitfields.


\
\ @brief SRAM/NOR-flash write timing registers for bank 1
\ Address offset: 0x104
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BWTR1_ADDSET                             \ Address setup phase duration. These bits are written by software to define the duration of the address setup phase in fmc_ker_ck cycles (refer to Figure 109 to Figure 121), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
$000000f0 constant FMC_FMC_BWTR1_ADDHLD                             \ Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 109 to Figure 121), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR flash accesses, this value is not used, the address hold phase is always 1 flash clock period duration.
$0000ff00 constant FMC_FMC_BWTR1_DATAST                             \ Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 109 to Figure 121), used in asynchronous SRAM, PSRAM and NOR flash memory accesses: ...
$000f0000 constant FMC_FMC_BWTR1_BUSTURN                            \ Bus turnaround phase duration These bits are written by software to add a delay at the end of a write transaction to match the minimum time between consecutive transactions (t<sub>EHEL</sub> from ENx high to ENx low): (BUSTRUN + 1) fmc_ker_ck period more or equal to t<sub>EHELmin</sub>. The programmed bus turnaround delay is inserted between an asynchronous write transfer and any other asynchronous /synchronous read or write transfer to or from a static bank. The bank can be the same or different in case of read, in case of write the bank can be different expect for muxed or mode D. In some cases, whatever the programmed BUSTURN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed and D modes. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to the same bank. A synchronous write (burst or single) transfer and an asynchronous write or read transfer to or from static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to different static bank. A synchronous write (burst or single) transfer and a synchronous read from the same or a different bank. ...
$30000000 constant FMC_FMC_BWTR1_ACCMOD                             \ Access mode. These bits specify the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.


\
\ @brief SRAM/NOR-flash write timing registers for bank 2
\ Address offset: 0x10C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BWTR2_ADDSET                             \ Address setup phase duration. These bits are written by software to define the duration of the address setup phase in fmc_ker_ck cycles (refer to Figure 109 to Figure 121), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
$000000f0 constant FMC_FMC_BWTR2_ADDHLD                             \ Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 109 to Figure 121), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR flash accesses, this value is not used, the address hold phase is always 1 flash clock period duration.
$0000ff00 constant FMC_FMC_BWTR2_DATAST                             \ Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 109 to Figure 121), used in asynchronous SRAM, PSRAM and NOR flash memory accesses: ...
$000f0000 constant FMC_FMC_BWTR2_BUSTURN                            \ Bus turnaround phase duration These bits are written by software to add a delay at the end of a write transaction to match the minimum time between consecutive transactions (t<sub>EHEL</sub> from ENx high to ENx low): (BUSTRUN + 1) fmc_ker_ck period more or equal to t<sub>EHELmin</sub>. The programmed bus turnaround delay is inserted between an asynchronous write transfer and any other asynchronous /synchronous read or write transfer to or from a static bank. The bank can be the same or different in case of read, in case of write the bank can be different expect for muxed or mode D. In some cases, whatever the programmed BUSTURN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed and D modes. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to the same bank. A synchronous write (burst or single) transfer and an asynchronous write or read transfer to or from static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to different static bank. A synchronous write (burst or single) transfer and a synchronous read from the same or a different bank. ...
$30000000 constant FMC_FMC_BWTR2_ACCMOD                             \ Access mode. These bits specify the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.


\
\ @brief SRAM/NOR-flash write timing registers for bank 3
\ Address offset: 0x114
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BWTR3_ADDSET                             \ Address setup phase duration. These bits are written by software to define the duration of the address setup phase in fmc_ker_ck cycles (refer to Figure 109 to Figure 121), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
$000000f0 constant FMC_FMC_BWTR3_ADDHLD                             \ Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 109 to Figure 121), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR flash accesses, this value is not used, the address hold phase is always 1 flash clock period duration.
$0000ff00 constant FMC_FMC_BWTR3_DATAST                             \ Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 109 to Figure 121), used in asynchronous SRAM, PSRAM and NOR flash memory accesses: ...
$000f0000 constant FMC_FMC_BWTR3_BUSTURN                            \ Bus turnaround phase duration These bits are written by software to add a delay at the end of a write transaction to match the minimum time between consecutive transactions (t<sub>EHEL</sub> from ENx high to ENx low): (BUSTRUN + 1) fmc_ker_ck period more or equal to t<sub>EHELmin</sub>. The programmed bus turnaround delay is inserted between an asynchronous write transfer and any other asynchronous /synchronous read or write transfer to or from a static bank. The bank can be the same or different in case of read, in case of write the bank can be different expect for muxed or mode D. In some cases, whatever the programmed BUSTURN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed and D modes. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to the same bank. A synchronous write (burst or single) transfer and an asynchronous write or read transfer to or from static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to different static bank. A synchronous write (burst or single) transfer and a synchronous read from the same or a different bank. ...
$30000000 constant FMC_FMC_BWTR3_ACCMOD                             \ Access mode. These bits specify the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.


\
\ @brief SRAM/NOR-flash write timing registers for bank 4
\ Address offset: 0x11C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BWTR4_ADDSET                             \ Address setup phase duration. These bits are written by software to define the duration of the address setup phase in fmc_ker_ck cycles (refer to Figure 109 to Figure 121), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
$000000f0 constant FMC_FMC_BWTR4_ADDHLD                             \ Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 109 to Figure 121), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR flash accesses, this value is not used, the address hold phase is always 1 flash clock period duration.
$0000ff00 constant FMC_FMC_BWTR4_DATAST                             \ Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 109 to Figure 121), used in asynchronous SRAM, PSRAM and NOR flash memory accesses: ...
$000f0000 constant FMC_FMC_BWTR4_BUSTURN                            \ Bus turnaround phase duration These bits are written by software to add a delay at the end of a write transaction to match the minimum time between consecutive transactions (t<sub>EHEL</sub> from ENx high to ENx low): (BUSTRUN + 1) fmc_ker_ck period more or equal to t<sub>EHELmin</sub>. The programmed bus turnaround delay is inserted between an asynchronous write transfer and any other asynchronous /synchronous read or write transfer to or from a static bank. The bank can be the same or different in case of read, in case of write the bank can be different expect for muxed or mode D. In some cases, whatever the programmed BUSTURN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed and D modes. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to the same bank. A synchronous write (burst or single) transfer and an asynchronous write or read transfer to or from static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous writes (burst or single) to different static bank. A synchronous write (burst or single) transfer and a synchronous read from the same or a different bank. ...
$30000000 constant FMC_FMC_BWTR4_ACCMOD                             \ Access mode. These bits specify the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.


\
\ @brief SDRAM Control registers for SDRAM memory bank 1
\ Address offset: 0x140
\ Reset value: 0x000002D0
\

$00000003 constant FMC_FMC_SDCR1_NC                                 \ Number of column address bits These bits define the number of bits of a column address.
$0000000c constant FMC_FMC_SDCR1_NR                                 \ Number of row address bits These bits define the number of bits of a row address.
$00000030 constant FMC_FMC_SDCR1_MWID                               \ Memory data bus width. These bits define the memory device width.
$00000040 constant FMC_FMC_SDCR1_NB                                 \ Number of internal banks This bit sets the number of internal banks.
$00000180 constant FMC_FMC_SDCR1_CAS                                \ CAS Latency This bits sets the SDRAM CAS latency in number of memory clock cycles
$00000200 constant FMC_FMC_SDCR1_WP                                 \ Write protection This bit enables Write mode access to the SDRAM bank.
$00000c00 constant FMC_FMC_SDCR1_SDCLK                              \ SDRAM clock configuration These bits define the SDRAM clock period for both SDRAM banks and allow disabling the clock before changing the frequency. In this case the SDRAM must be re-initialized. Note: The corresponding bits in the FMC_SDCR2 register is read only.
$00001000 constant FMC_FMC_SDCR1_RBURST                             \ Burst read This bit enables Burst read mode. The SDRAM controller anticipates the next read commands during the CAS latency and stores data in the Read FIFO. Note: The corresponding bit in the FMC_SDCR2 register is read only.
$00006000 constant FMC_FMC_SDCR1_RPIPE                              \ Read pipe These bits define the delay, in fmc_ker_ck clock cycles, for reading data after CAS latency. Note: The corresponding bits in the FMC_SDCR2 register is read only.


\
\ @brief SDRAM Control registers for SDRAM memory bank 2
\ Address offset: 0x144
\ Reset value: 0x000002D0
\

$00000003 constant FMC_FMC_SDCR2_NC                                 \ Number of column address bits These bits define the number of bits of a column address.
$0000000c constant FMC_FMC_SDCR2_NR                                 \ Number of row address bits These bits define the number of bits of a row address.
$00000030 constant FMC_FMC_SDCR2_MWID                               \ Memory data bus width. These bits define the memory device width.
$00000040 constant FMC_FMC_SDCR2_NB                                 \ Number of internal banks This bit sets the number of internal banks.
$00000180 constant FMC_FMC_SDCR2_CAS                                \ CAS Latency This bits sets the SDRAM CAS latency in number of memory clock cycles
$00000200 constant FMC_FMC_SDCR2_WP                                 \ Write protection This bit enables Write mode access to the SDRAM bank.
$00000c00 constant FMC_FMC_SDCR2_SDCLK                              \ SDRAM clock configuration These bits define the SDRAM clock period for both SDRAM banks and allow disabling the clock before changing the frequency. In this case the SDRAM must be re-initialized. Note: The corresponding bits in the FMC_SDCR2 register is read only.
$00001000 constant FMC_FMC_SDCR2_RBURST                             \ Burst read This bit enables Burst read mode. The SDRAM controller anticipates the next read commands during the CAS latency and stores data in the Read FIFO. Note: The corresponding bit in the FMC_SDCR2 register is read only.
$00006000 constant FMC_FMC_SDCR2_RPIPE                              \ Read pipe These bits define the delay, in fmc_ker_ck clock cycles, for reading data after CAS latency. Note: The corresponding bits in the FMC_SDCR2 register is read only.


\
\ @brief SDRAM Timing registers for SDRAM memory bank 1
\ Address offset: 0x148
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_SDTR1_TMRD                               \ Load Mode Register to Active These bits define the delay between a Load Mode Register command and an Active or Refresh command in number of memory clock cycles. ....
$000000f0 constant FMC_FMC_SDTR1_TXSR                               \ Exit Self-refresh delay These bits define the delay from releasing the Self-refresh command to issuing the Activate command in number of memory clock cycles. .... Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TXSR timing corresponding to the slowest SDRAM device.
$00000f00 constant FMC_FMC_SDTR1_TRAS                               \ Self refresh time These bits define the minimum Self-refresh period in number of memory clock cycles. ....
$0000f000 constant FMC_FMC_SDTR1_TRC                                \ Row cycle delay These bits define the delay between the Refresh command and the Activate command, as well as the delay between two consecutive Refresh commands. It is expressed in number of memory clock cycles. The TRC timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRC must be programmed with the timings of the slowest device. .... Note: TRC must match the TRC and TRFC (Auto Refresh period) timings defined in the SDRAM device datasheet. Note: The corresponding bits in the FMC_SDTR2 register are dont care.
$000f0000 constant FMC_FMC_SDTR1_TWR                                \ Recovery delay These bits define the delay between a Write and a Precharge command in number of memory clock cycles. .... Note: TWR must be programmed to match the write recovery time (t<sub>WR</sub>) defined in the SDRAM datasheet, and to guarantee that: Note: TWR TRAS - TRCD and TWR TRC - TRCD - TRP Note: Example: TRAS= 4 cycles, TRCD= 2 cycles. So, TWR >= 2 cycles. TWR must be programmed to 0x1. Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TWR timing corresponding to the slowest SDRAM device. Note: If only one SDRAM device is used, the TWR timing must be kept at reset value (0xF) for the not used bank.
$00f00000 constant FMC_FMC_SDTR1_TRP                                \ Row precharge delay These bits define the delay between a Precharge command and another command in number of memory clock cycles. The TRP timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRP must be programmed with the timing of the slowest device. .... Note: The corresponding bits in the FMC_SDTR2 register are dont care.
$0f000000 constant FMC_FMC_SDTR1_TRCD                               \ Row to column delay These bits define the delay between the Activate command and a Read/Write command in number of memory clock cycles. ....


\
\ @brief SDRAM Timing registers for SDRAM memory bank 2
\ Address offset: 0x14C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_SDTR2_TMRD                               \ Load Mode Register to Active These bits define the delay between a Load Mode Register command and an Active or Refresh command in number of memory clock cycles. ....
$000000f0 constant FMC_FMC_SDTR2_TXSR                               \ Exit Self-refresh delay These bits define the delay from releasing the Self-refresh command to issuing the Activate command in number of memory clock cycles. .... Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TXSR timing corresponding to the slowest SDRAM device.
$00000f00 constant FMC_FMC_SDTR2_TRAS                               \ Self refresh time These bits define the minimum Self-refresh period in number of memory clock cycles. ....
$0000f000 constant FMC_FMC_SDTR2_TRC                                \ Row cycle delay These bits define the delay between the Refresh command and the Activate command, as well as the delay between two consecutive Refresh commands. It is expressed in number of memory clock cycles. The TRC timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRC must be programmed with the timings of the slowest device. .... Note: TRC must match the TRC and TRFC (Auto Refresh period) timings defined in the SDRAM device datasheet. Note: The corresponding bits in the FMC_SDTR2 register are dont care.
$000f0000 constant FMC_FMC_SDTR2_TWR                                \ Recovery delay These bits define the delay between a Write and a Precharge command in number of memory clock cycles. .... Note: TWR must be programmed to match the write recovery time (t<sub>WR</sub>) defined in the SDRAM datasheet, and to guarantee that: Note: TWR TRAS - TRCD and TWR TRC - TRCD - TRP Note: Example: TRAS= 4 cycles, TRCD= 2 cycles. So, TWR >= 2 cycles. TWR must be programmed to 0x1. Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TWR timing corresponding to the slowest SDRAM device. Note: If only one SDRAM device is used, the TWR timing must be kept at reset value (0xF) for the not used bank.
$00f00000 constant FMC_FMC_SDTR2_TRP                                \ Row precharge delay These bits define the delay between a Precharge command and another command in number of memory clock cycles. The TRP timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRP must be programmed with the timing of the slowest device. .... Note: The corresponding bits in the FMC_SDTR2 register are dont care.
$0f000000 constant FMC_FMC_SDTR2_TRCD                               \ Row to column delay These bits define the delay between the Activate command and a Read/Write command in number of memory clock cycles. ....


\
\ @brief SDRAM Command mode register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000007 constant FMC_FMC_SDCMR_MODE                               \ Command mode These bits define the command issued to the SDRAM device. Note: When a command is issued, at least one Command Target Bank bit ( CTB1 or CTB2) must be set otherwise the command will be ignored. Note: If two SDRAM banks are used, the Auto-refresh and PALL command must be issued simultaneously to the two devices with CTB1 and CTB2 bits set otherwise the command will be ignored. Note: If only one SDRAM bank is used and a command is issued with its associated CTB bit set, the other CTB bit of the unused bank must be kept to 0.
$00000008 constant FMC_FMC_SDCMR_CTB2                               \ Command Target Bank 2 This bit indicates whether the command will be issued to SDRAM Bank 2 or not.
$00000010 constant FMC_FMC_SDCMR_CTB1                               \ Command Target Bank 1 This bit indicates whether the command will be issued to SDRAM Bank 1 or not.
$000001e0 constant FMC_FMC_SDCMR_NRFS                               \ Number of Auto-refresh These bits define the number of consecutive Auto-refresh commands issued when MODE = 011. ....
$007ffe00 constant FMC_FMC_SDCMR_MRD                                \ Mode Register definition This 14-bit field defines the SDRAM Mode Register content. The Mode Register is programmed using the Load Mode Register command. The MRD[13:0] bits are also used to program the extended mode register for mobile SDRAM.


\
\ @brief SDRAM refresh timer register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_SDRTR_CRE                                \ Clear Refresh error flag This bit is used to clear the Refresh Error Flag (RE) in the Status Register.
$00003ffe constant FMC_FMC_SDRTR_COUNT                              \ Refresh Timer Count This 13-bit field defines the refresh rate of the SDRAM device. It is expressed in number of memory clock cycles. It must be set at least to 41 SDRAM clock cycles (0x29). Refresh rate = (COUNT + 1) x SDRAM frequency clock COUNT = (SDRAM refresh period / Number of rows) - 20
$00004000 constant FMC_FMC_SDRTR_REIE                               \ RES Interrupt Enable


\
\ @brief SDRAM Status register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_SDSR_RE                                  \ Refresh error flag An interrupt is generated if REIE = 1 and RE = 1
$00000006 constant FMC_FMC_SDSR_MODES1                              \ Status Mode for Bank 1 These bits define the Status Mode of SDRAM Bank 1.
$00000018 constant FMC_FMC_SDSR_MODES2                              \ Status Mode for Bank 2 These bits define the Status Mode of SDRAM Bank 2.


\
\ @brief Flexible memory controller
\
$52004000 constant FMC_FMC_BCR1   \ offset: 0x00 : SRAM/NOR-flash chip-select control registers for bank 1
$52004004 constant FMC_FMC_BTR1   \ offset: 0x04 : SRAM/NOR-flash chip-select timing registers for bank 1
$52004008 constant FMC_FMC_BCR2   \ offset: 0x08 : SRAM/NOR-flash chip-select control registers for bank 2
$5200400c constant FMC_FMC_BTR2   \ offset: 0x0C : SRAM/NOR-flash chip-select timing registers for bank 2
$52004010 constant FMC_FMC_BCR3   \ offset: 0x10 : SRAM/NOR-flash chip-select control registers for bank 3
$52004014 constant FMC_FMC_BTR3   \ offset: 0x14 : SRAM/NOR-flash chip-select timing registers for bank 3
$52004018 constant FMC_FMC_BCR4   \ offset: 0x18 : SRAM/NOR-flash chip-select control registers for bank 4
$5200401c constant FMC_FMC_BTR4   \ offset: 0x1C : SRAM/NOR-flash chip-select timing registers for bank 4
$52004080 constant FMC_FMC_PCR    \ offset: 0x80 : NAND flash control registers
$52004084 constant FMC_FMC_SR     \ offset: 0x84 : FIFO status and interrupt register
$52004088 constant FMC_FMC_PMEM   \ offset: 0x88 : Common memory space timing register
$5200408c constant FMC_FMC_PATT   \ offset: 0x8C : Attribute memory space timing registers
$52004094 constant FMC_FMC_ECCR   \ offset: 0x94 : ECC result registers
$52004104 constant FMC_FMC_BWTR1  \ offset: 0x104 : SRAM/NOR-flash write timing registers for bank 1
$5200410c constant FMC_FMC_BWTR2  \ offset: 0x10C : SRAM/NOR-flash write timing registers for bank 2
$52004114 constant FMC_FMC_BWTR3  \ offset: 0x114 : SRAM/NOR-flash write timing registers for bank 3
$5200411c constant FMC_FMC_BWTR4  \ offset: 0x11C : SRAM/NOR-flash write timing registers for bank 4
$52004140 constant FMC_FMC_SDCR1  \ offset: 0x140 : SDRAM Control registers for SDRAM memory bank 1
$52004144 constant FMC_FMC_SDCR2  \ offset: 0x144 : SDRAM Control registers for SDRAM memory bank 2
$52004148 constant FMC_FMC_SDTR1  \ offset: 0x148 : SDRAM Timing registers for SDRAM memory bank 1
$5200414c constant FMC_FMC_SDTR2  \ offset: 0x14C : SDRAM Timing registers for SDRAM memory bank 2
$52004150 constant FMC_FMC_SDCMR  \ offset: 0x150 : SDRAM Command mode register
$52004154 constant FMC_FMC_SDRTR  \ offset: 0x154 : SDRAM refresh timer register
$52004158 constant FMC_FMC_SDSR   \ offset: 0x158 : SDRAM Status register

