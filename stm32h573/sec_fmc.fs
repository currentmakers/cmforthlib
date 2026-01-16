\
\ @file sec_fmc.fs
\ @brief Flexible memory controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SRAM/NOR-Flash chip-select control register for bank 1
\ Address offset: 0x00
\ Reset value: 0x000030DB
\

$00000001 constant SEC_FMC_FMC_BCR1_MBKEN                           \ Memory bank enable bit Enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AHB bus.
$00000002 constant SEC_FMC_FMC_BCR1_MUXEN                           \ Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
$0000000c constant SEC_FMC_FMC_BCR1_MTYP                            \ Memory type Defines the type of external memory attached to the corresponding memory bank.
$00000030 constant SEC_FMC_FMC_BCR1_MWID                            \ Memory data bus width Defines the external memory device width, valid for all type of memories.
$00000040 constant SEC_FMC_FMC_BCR1_FACCEN                          \ Flash access enable Enables NOR Flash memory access operations.
$00000100 constant SEC_FMC_FMC_BCR1_BURSTEN                         \ Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode.
$00000200 constant SEC_FMC_FMC_BCR1_WAITPOL                         \ Wait signal polarity bit Defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode.
$00000800 constant SEC_FMC_FMC_BCR1_WAITCFG                         \ Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
$00001000 constant SEC_FMC_FMC_BCR1_WREN                            \ Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC.
$00002000 constant SEC_FMC_FMC_BCR1_WAITEN                          \ Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
$00004000 constant SEC_FMC_FMC_BCR1_EXTMOD                          \ Extended mode enable This bit enables the FMC to program the write timings for non multiplexed asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in mode 1 or mode 2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP = 0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
$00008000 constant SEC_FMC_FMC_BCR1_ASYNCWAIT                       \ Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
$00070000 constant SEC_FMC_FMC_BCR1_CPSIZE                          \ CRAM page size These are used for CellularRAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Others: reserved
$00080000 constant SEC_FMC_FMC_BCR1_CBURSTRW                        \ Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
$00100000 constant SEC_FMC_FMC_BCR1_CCLKEN                          \ Continuous clock enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is don't care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
$00200000 constant SEC_FMC_FMC_BCR1_WFDIS                           \ Write FIFO disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
$00c00000 constant SEC_FMC_FMC_BCR1_NBLSET                          \ Byte lane (NBL) setup These bits configure the NBL setup timing from NBLx low to chip select NEx low.
$80000000 constant SEC_FMC_FMC_BCR1_FMCEN                           \ FMC controller enable This bit enables or disables the FMC controller. Note: The FMCEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.


\
\ @brief SRAM/NOR-Flash chip-select timing register for bank 1
\ Address offset: 0x04
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_BTR1_ADDSET                          \ Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 21 to Figure 33), used in SRAMs, ROMs, asynchronous NOR Flash and PSRAM: ... For each access mode address setup phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is don't care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
$000000f0 constant SEC_FMC_FMC_BTR1_ADDHLD                          \ Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 21 to Figure 33), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
$0000ff00 constant SEC_FMC_FMC_BTR1_DATAST                          \ Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, refer to the respective figure (Figure 21 to Figure 33). Example: Mode 1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 HCLK clock cycles. Note: In synchronous accesses, this value is don't care.
$000f0000 constant SEC_FMC_FMC_BTR1_BUSTURN                         \ Bus turnaround phase duration These bits are written by software to add a delay at the end of current read or write transaction to next transaction on the same bank. This delay allows to match the minimum time between consecutive transactions (t sub EHEL /sub from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t sub EHQZ /sub , chip enable high to output Hi-Z). This delay is recommended for mode D and muxed mode. For non-muxed memory, the bus turnaround delay can be set to minimum value. (BUSTURN + 1)HCLK period greater than or equal max(t sub EHEL /sub min, t sub EHQZ /sub max) For FRAM memories, the bus turnaround delay should be configured to match the minimum tPC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read) to match the tPC memory timing. The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal t sub PC /sub min ...
$00f00000 constant SEC_FMC_FMC_BTR1_CLKDIV                          \ Clock divide ratio (for FMC_CLK signal) Defines the period of FMC_CLK clock output signal, expressed in number of HCLK cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is don't care. Note: Refer to Section 5.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
$0f000000 constant SEC_FMC_FMC_BTR1_DATLAT                          \ (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), defines the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in HCLK periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
$30000000 constant SEC_FMC_FMC_BTR1_ACCMOD                          \ Access mode Specifies the asynchronous access modes as shown in the timing diagrams. These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
$c0000000 constant SEC_FMC_FMC_BTR1_DATAHLD                         \ Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: For read accesses For write accesses


\
\ @brief SRAM/NOR-Flash chip-select control register for bank 2
\ Address offset: 0x08
\ Reset value: 0x000030D2
\

$00000001 constant SEC_FMC_FMC_BCR2_MBKEN                           \ Memory bank enable bit Enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AHB bus.
$00000002 constant SEC_FMC_FMC_BCR2_MUXEN                           \ Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
$0000000c constant SEC_FMC_FMC_BCR2_MTYP                            \ Memory type Defines the type of external memory attached to the corresponding memory bank.
$00000030 constant SEC_FMC_FMC_BCR2_MWID                            \ Memory data bus width Defines the external memory device width, valid for all type of memories.
$00000040 constant SEC_FMC_FMC_BCR2_FACCEN                          \ Flash access enable Enables NOR Flash memory access operations.
$00000100 constant SEC_FMC_FMC_BCR2_BURSTEN                         \ Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode.
$00000200 constant SEC_FMC_FMC_BCR2_WAITPOL                         \ Wait signal polarity bit Defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode.
$00000800 constant SEC_FMC_FMC_BCR2_WAITCFG                         \ Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
$00001000 constant SEC_FMC_FMC_BCR2_WREN                            \ Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC.
$00002000 constant SEC_FMC_FMC_BCR2_WAITEN                          \ Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
$00004000 constant SEC_FMC_FMC_BCR2_EXTMOD                          \ Extended mode enable This bit enables the FMC to program the write timings for non multiplexed asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in mode 1 or mode 2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP = 0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
$00008000 constant SEC_FMC_FMC_BCR2_ASYNCWAIT                       \ Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
$00070000 constant SEC_FMC_FMC_BCR2_CPSIZE                          \ CRAM page size These are used for CellularRAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Others: reserved
$00080000 constant SEC_FMC_FMC_BCR2_CBURSTRW                        \ Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
$00100000 constant SEC_FMC_FMC_BCR2_CCLKEN                          \ Continuous clock enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is don't care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
$00200000 constant SEC_FMC_FMC_BCR2_WFDIS                           \ Write FIFO disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
$00c00000 constant SEC_FMC_FMC_BCR2_NBLSET                          \ Byte lane (NBL) setup These bits configure the NBL setup timing from NBLx low to chip select NEx low.
$80000000 constant SEC_FMC_FMC_BCR2_FMCEN                           \ FMC controller enable This bit enables or disables the FMC controller. Note: The FMCEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.


\
\ @brief SRAM/NOR-Flash chip-select timing register for bank 2
\ Address offset: 0x0C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_BTR2_ADDSET                          \ Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 21 to Figure 33), used in SRAMs, ROMs, asynchronous NOR Flash and PSRAM: ... For each access mode address setup phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is don't care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
$000000f0 constant SEC_FMC_FMC_BTR2_ADDHLD                          \ Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 21 to Figure 33), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
$0000ff00 constant SEC_FMC_FMC_BTR2_DATAST                          \ Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, refer to the respective figure (Figure 21 to Figure 33). Example: Mode 1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 HCLK clock cycles. Note: In synchronous accesses, this value is don't care.
$000f0000 constant SEC_FMC_FMC_BTR2_BUSTURN                         \ Bus turnaround phase duration These bits are written by software to add a delay at the end of current read or write transaction to next transaction on the same bank. This delay allows to match the minimum time between consecutive transactions (t sub EHEL /sub from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t sub EHQZ /sub , chip enable high to output Hi-Z). This delay is recommended for mode D and muxed mode. For non-muxed memory, the bus turnaround delay can be set to minimum value. (BUSTURN + 1)HCLK period greater than or equal max(t sub EHEL /sub min, t sub EHQZ /sub max) For FRAM memories, the bus turnaround delay should be configured to match the minimum tPC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read) to match the tPC memory timing. The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal t sub PC /sub min ...
$00f00000 constant SEC_FMC_FMC_BTR2_CLKDIV                          \ Clock divide ratio (for FMC_CLK signal) Defines the period of FMC_CLK clock output signal, expressed in number of HCLK cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is don't care. Note: Refer to Section 5.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
$0f000000 constant SEC_FMC_FMC_BTR2_DATLAT                          \ (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), defines the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in HCLK periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
$30000000 constant SEC_FMC_FMC_BTR2_ACCMOD                          \ Access mode Specifies the asynchronous access modes as shown in the timing diagrams. These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
$c0000000 constant SEC_FMC_FMC_BTR2_DATAHLD                         \ Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: For read accesses For write accesses


\
\ @brief SRAM/NOR-Flash chip-select control register for bank 3
\ Address offset: 0x10
\ Reset value: 0x000030D2
\

$00000001 constant SEC_FMC_FMC_BCR3_MBKEN                           \ Memory bank enable bit Enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AHB bus.
$00000002 constant SEC_FMC_FMC_BCR3_MUXEN                           \ Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
$0000000c constant SEC_FMC_FMC_BCR3_MTYP                            \ Memory type Defines the type of external memory attached to the corresponding memory bank.
$00000030 constant SEC_FMC_FMC_BCR3_MWID                            \ Memory data bus width Defines the external memory device width, valid for all type of memories.
$00000040 constant SEC_FMC_FMC_BCR3_FACCEN                          \ Flash access enable Enables NOR Flash memory access operations.
$00000100 constant SEC_FMC_FMC_BCR3_BURSTEN                         \ Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode.
$00000200 constant SEC_FMC_FMC_BCR3_WAITPOL                         \ Wait signal polarity bit Defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode.
$00000800 constant SEC_FMC_FMC_BCR3_WAITCFG                         \ Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
$00001000 constant SEC_FMC_FMC_BCR3_WREN                            \ Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC.
$00002000 constant SEC_FMC_FMC_BCR3_WAITEN                          \ Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
$00004000 constant SEC_FMC_FMC_BCR3_EXTMOD                          \ Extended mode enable This bit enables the FMC to program the write timings for non multiplexed asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in mode 1 or mode 2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP = 0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
$00008000 constant SEC_FMC_FMC_BCR3_ASYNCWAIT                       \ Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
$00070000 constant SEC_FMC_FMC_BCR3_CPSIZE                          \ CRAM page size These are used for CellularRAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Others: reserved
$00080000 constant SEC_FMC_FMC_BCR3_CBURSTRW                        \ Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
$00100000 constant SEC_FMC_FMC_BCR3_CCLKEN                          \ Continuous clock enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is don't care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
$00200000 constant SEC_FMC_FMC_BCR3_WFDIS                           \ Write FIFO disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
$00c00000 constant SEC_FMC_FMC_BCR3_NBLSET                          \ Byte lane (NBL) setup These bits configure the NBL setup timing from NBLx low to chip select NEx low.
$80000000 constant SEC_FMC_FMC_BCR3_FMCEN                           \ FMC controller enable This bit enables or disables the FMC controller. Note: The FMCEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.


\
\ @brief SRAM/NOR-Flash chip-select timing register for bank 3
\ Address offset: 0x14
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_BTR3_ADDSET                          \ Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 21 to Figure 33), used in SRAMs, ROMs, asynchronous NOR Flash and PSRAM: ... For each access mode address setup phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is don't care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
$000000f0 constant SEC_FMC_FMC_BTR3_ADDHLD                          \ Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 21 to Figure 33), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
$0000ff00 constant SEC_FMC_FMC_BTR3_DATAST                          \ Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, refer to the respective figure (Figure 21 to Figure 33). Example: Mode 1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 HCLK clock cycles. Note: In synchronous accesses, this value is don't care.
$000f0000 constant SEC_FMC_FMC_BTR3_BUSTURN                         \ Bus turnaround phase duration These bits are written by software to add a delay at the end of current read or write transaction to next transaction on the same bank. This delay allows to match the minimum time between consecutive transactions (t sub EHEL /sub from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t sub EHQZ /sub , chip enable high to output Hi-Z). This delay is recommended for mode D and muxed mode. For non-muxed memory, the bus turnaround delay can be set to minimum value. (BUSTURN + 1)HCLK period greater than or equal max(t sub EHEL /sub min, t sub EHQZ /sub max) For FRAM memories, the bus turnaround delay should be configured to match the minimum tPC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read) to match the tPC memory timing. The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal t sub PC /sub min ...
$00f00000 constant SEC_FMC_FMC_BTR3_CLKDIV                          \ Clock divide ratio (for FMC_CLK signal) Defines the period of FMC_CLK clock output signal, expressed in number of HCLK cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is don't care. Note: Refer to Section 5.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
$0f000000 constant SEC_FMC_FMC_BTR3_DATLAT                          \ (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), defines the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in HCLK periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
$30000000 constant SEC_FMC_FMC_BTR3_ACCMOD                          \ Access mode Specifies the asynchronous access modes as shown in the timing diagrams. These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
$c0000000 constant SEC_FMC_FMC_BTR3_DATAHLD                         \ Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: For read accesses For write accesses


\
\ @brief SRAM/NOR-Flash chip-select control register for bank 4
\ Address offset: 0x18
\ Reset value: 0x000030D2
\

$00000001 constant SEC_FMC_FMC_BCR4_MBKEN                           \ Memory bank enable bit Enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AHB bus.
$00000002 constant SEC_FMC_FMC_BCR4_MUXEN                           \ Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
$0000000c constant SEC_FMC_FMC_BCR4_MTYP                            \ Memory type Defines the type of external memory attached to the corresponding memory bank.
$00000030 constant SEC_FMC_FMC_BCR4_MWID                            \ Memory data bus width Defines the external memory device width, valid for all type of memories.
$00000040 constant SEC_FMC_FMC_BCR4_FACCEN                          \ Flash access enable Enables NOR Flash memory access operations.
$00000100 constant SEC_FMC_FMC_BCR4_BURSTEN                         \ Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode.
$00000200 constant SEC_FMC_FMC_BCR4_WAITPOL                         \ Wait signal polarity bit Defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode.
$00000800 constant SEC_FMC_FMC_BCR4_WAITCFG                         \ Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
$00001000 constant SEC_FMC_FMC_BCR4_WREN                            \ Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC.
$00002000 constant SEC_FMC_FMC_BCR4_WAITEN                          \ Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
$00004000 constant SEC_FMC_FMC_BCR4_EXTMOD                          \ Extended mode enable This bit enables the FMC to program the write timings for non multiplexed asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in mode 1 or mode 2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP = 0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
$00008000 constant SEC_FMC_FMC_BCR4_ASYNCWAIT                       \ Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
$00070000 constant SEC_FMC_FMC_BCR4_CPSIZE                          \ CRAM page size These are used for CellularRAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Others: reserved
$00080000 constant SEC_FMC_FMC_BCR4_CBURSTRW                        \ Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
$00100000 constant SEC_FMC_FMC_BCR4_CCLKEN                          \ Continuous clock enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is don't care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
$00200000 constant SEC_FMC_FMC_BCR4_WFDIS                           \ Write FIFO disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
$00c00000 constant SEC_FMC_FMC_BCR4_NBLSET                          \ Byte lane (NBL) setup These bits configure the NBL setup timing from NBLx low to chip select NEx low.
$80000000 constant SEC_FMC_FMC_BCR4_FMCEN                           \ FMC controller enable This bit enables or disables the FMC controller. Note: The FMCEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.


\
\ @brief SRAM/NOR-Flash chip-select timing register for bank 4
\ Address offset: 0x1C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_BTR4_ADDSET                          \ Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 21 to Figure 33), used in SRAMs, ROMs, asynchronous NOR Flash and PSRAM: ... For each access mode address setup phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is don't care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
$000000f0 constant SEC_FMC_FMC_BTR4_ADDHLD                          \ Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 21 to Figure 33), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
$0000ff00 constant SEC_FMC_FMC_BTR4_DATAST                          \ Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, refer to the respective figure (Figure 21 to Figure 33). Example: Mode 1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 HCLK clock cycles. Note: In synchronous accesses, this value is don't care.
$000f0000 constant SEC_FMC_FMC_BTR4_BUSTURN                         \ Bus turnaround phase duration These bits are written by software to add a delay at the end of current read or write transaction to next transaction on the same bank. This delay allows to match the minimum time between consecutive transactions (t sub EHEL /sub from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t sub EHQZ /sub , chip enable high to output Hi-Z). This delay is recommended for mode D and muxed mode. For non-muxed memory, the bus turnaround delay can be set to minimum value. (BUSTURN + 1)HCLK period greater than or equal max(t sub EHEL /sub min, t sub EHQZ /sub max) For FRAM memories, the bus turnaround delay should be configured to match the minimum tPC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read) to match the tPC memory timing. The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal t sub PC /sub min ...
$00f00000 constant SEC_FMC_FMC_BTR4_CLKDIV                          \ Clock divide ratio (for FMC_CLK signal) Defines the period of FMC_CLK clock output signal, expressed in number of HCLK cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is don't care. Note: Refer to Section 5.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
$0f000000 constant SEC_FMC_FMC_BTR4_DATLAT                          \ (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), defines the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in HCLK periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
$30000000 constant SEC_FMC_FMC_BTR4_ACCMOD                          \ Access mode Specifies the asynchronous access modes as shown in the timing diagrams. These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
$c0000000 constant SEC_FMC_FMC_BTR4_DATAHLD                         \ Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: For read accesses For write accesses


\
\ @brief PSRAM chip select counter register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant SEC_FMC_FMC_PCSCNTR_CSCOUNT                      \ Chip select counter. These bits are written by software to define the maximum chip select low pulse duration. It is expressed in FMC_CLK cycles for synchronous accesses and in HCLK cycles for asynchronous accesses. The counter is disabled if the programmed value is 0.
$00010000 constant SEC_FMC_FMC_PCSCNTR_CNTB1EN                      \ Counter Bank 1 enable This bit enables the chip select counter for PSRAM/NOR Bank 1.
$00020000 constant SEC_FMC_FMC_PCSCNTR_CNTB2EN                      \ Counter Bank 2 enable This bit enables the chip select counter for PSRAM/NOR Bank 2.
$00040000 constant SEC_FMC_FMC_PCSCNTR_CNTB3EN                      \ Counter Bank 3 enable This bit enables the chip select counter for PSRAM/NOR Bank 3.
$00080000 constant SEC_FMC_FMC_PCSCNTR_CNTB4EN                      \ Counter Bank 4 enable This bit enables the chip select counter for PSRAM/NOR Bank 4.


\
\ @brief NAND Flash control registers
\ Address offset: 0x80
\ Reset value: 0x00000018
\

$00000002 constant SEC_FMC_FMC_PCR_PWAITEN                          \ Wait feature enable bit Enables the Wait feature for the NAND Flash memory bank:
$00000004 constant SEC_FMC_FMC_PCR_PBKEN                            \ NAND Flash memory bank enable bit Enables the memory bank. Accessing a disabled memory bank causes an ERROR on AHB bus
$00000008 constant SEC_FMC_FMC_PCR_PTYP                             \ Memory type Defines the type of device attached to the corresponding memory bank:
$00000030 constant SEC_FMC_FMC_PCR_PWID                             \ Data bus width Defines the external memory device width.
$00000040 constant SEC_FMC_FMC_PCR_ECCEN                            \ ECC computation logic enable bit
$00001e00 constant SEC_FMC_FMC_PCR_TCLR                             \ CLE to RE delay Sets time from CLE low to RE low in number of AHB clock cycles (HCLK). Time is t_clr = (TCLR + SET + 2) THCLK where THCLK is the HCLK clock period Note: SET is MEMSET or ATTSET according to the addressed space.
$0000e000 constant SEC_FMC_FMC_PCR_TAR                              \ ALE to RE delay Sets time from ALE low to RE low in number of AHB clock cycles (HCLK). Time is: t_ar = (TAR + SET + 2) THCLK where THCLK is the HCLK clock period Note: SET is MEMSET or ATTSET according to the addressed space.
$00010000 constant SEC_FMC_FMC_PCR_TAR3                             \ ALE to RE delay Sets time from ALE low to RE low in number of AHB clock cycles (HCLK). Time is: t_ar = (TAR + SET + 2) THCLK where THCLK is the HCLK clock period Note: SET is MEMSET or ATTSET according to the addressed space.
$000e0000 constant SEC_FMC_FMC_PCR_ECCPS                            \ ECC page size Defines the page size for the extended ECC:


\
\ @brief FIFO status and interrupt register
\ Address offset: 0x84
\ Reset value: 0x00000040
\

$00000001 constant SEC_FMC_FMC_SR_IRS                               \ Interrupt rising edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it is set.
$00000002 constant SEC_FMC_FMC_SR_ILS                               \ Interrupt high-level status The flag is set by hardware and reset by software.
$00000004 constant SEC_FMC_FMC_SR_IFS                               \ Interrupt falling edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it is set.
$00000008 constant SEC_FMC_FMC_SR_IREN                              \ Interrupt rising edge detection enable bit
$00000010 constant SEC_FMC_FMC_SR_ILEN                              \ Interrupt high-level detection enable bit
$00000020 constant SEC_FMC_FMC_SR_IFEN                              \ Interrupt falling edge detection enable bit
$00000040 constant SEC_FMC_FMC_SR_FEMPT                             \ FIFO empty Read-only bit that provides the status of the FIFO


\
\ @brief Common memory space timing register
\ Address offset: 0x88
\ Reset value: 0xFCFCFCFC
\

$000000ff constant SEC_FMC_FMC_PMEM_MEMSET                          \ Common memory x setup time Defines the number of HCLK (+1) clock cycles to set up the address before the command assertion (NWE, NOE), for NAND Flash read or write access to common memory space on socket x:
$0000ff00 constant SEC_FMC_FMC_PMEM_MEMWAIT                         \ Common memory wait time Defines the minimum number of HCLK (+1) clock cycles to assert the command (NWE, NOE), for NAND Flash read or write access to common memory space on socket. The duration of command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of HCLK:
$00ff0000 constant SEC_FMC_FMC_PMEM_MEMHOLD                         \ Common memory hold time Defines the number of HCLK clock cycles for write access and HCLK (+2) clock cycles for read access during which the address is held (and data for write accesses) after the command is deasserted (NWE, NOE), for NAND Flash read or write access to common memory space on socket x:
$ff000000 constant SEC_FMC_FMC_PMEM_MEMHIZ                          \ Common memory x data bus Hi-Z time Defines the number of HCLK clock cycles during which the data bus is kept Hi-Z after the start of a NAND Flash write access to common memory space on socket. This is only valid for write transactions:


\
\ @brief Attribute memory space timing register
\ Address offset: 0x8C
\ Reset value: 0xFCFCFCFC
\

$000000ff constant SEC_FMC_FMC_PATT_ATTSET                          \ Attribute memory setup time Defines the number of HCLK (+1) clock cycles to set up address before the command assertion (NWE, NOE), for NAND Flash read or write access to attribute memory space on socket:
$0000ff00 constant SEC_FMC_FMC_PATT_ATTWAIT                         \ Attribute memory wait time Defines the minimum number of HCLK (+1) clock cycles to assert the command (NWE, NOE), for NAND Flash read or write access to attribute memory space on socket x. The duration for command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of HCLK:
$00ff0000 constant SEC_FMC_FMC_PATT_ATTHOLD                         \ Attribute memory hold time Defines the number of HCLK clock cycles for write access and HCLK (+2) clock cycles for read access during which the address is held (and data for write access) after the command deassertion (NWE, NOE), for NAND Flash read or write access to attribute memory space on socket:
$ff000000 constant SEC_FMC_FMC_PATT_ATTHIZ                          \ Attribute memory data bus Hi-Z time Defines the number of HCLK clock cycles during which the data bus is kept in Hi-Z after the start of a NAND Flash write access to attribute memory space on socket. Only valid for writ transaction:


\
\ @brief ECC result registers
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant SEC_FMC_FMC_ECCR_ECC                             \ ECC result This field contains the value computed by the ECC computation logic. Table 99 describes the contents of these bitfields.


\
\ @brief SRAM/NOR-Flash write timing registers 1
\ Address offset: 0x104
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_BWTR1_ADDSET                         \ Address setup phase duration. These bits are written by software to define the duration of the address setup phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
$000000f0 constant SEC_FMC_FMC_BWTR1_ADDHLD                         \ Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 30 to Figure 33), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
$0000ff00 constant SEC_FMC_FMC_BWTR1_DATAST                         \ Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses: ...
$000f0000 constant SEC_FMC_FMC_BWTR1_BUSTURN                        \ Bus turnaround phase duration These bits are written by software to add a delay at the end of current write transaction to next transaction on the same bank. For FRAM memories, the bus turnaround delay should be configured to match the minimum t sub PC /sub (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read). The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal tPC min ...
$30000000 constant SEC_FMC_FMC_BWTR1_ACCMOD                         \ Access mode. Specifies the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
$c0000000 constant SEC_FMC_FMC_BWTR1_DATAHLD                        \ Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous write accesses:


\
\ @brief SRAM/NOR-Flash write timing registers 2
\ Address offset: 0x10C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_BWTR2_ADDSET                         \ Address setup phase duration. These bits are written by software to define the duration of the address setup phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
$000000f0 constant SEC_FMC_FMC_BWTR2_ADDHLD                         \ Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 30 to Figure 33), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
$0000ff00 constant SEC_FMC_FMC_BWTR2_DATAST                         \ Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses: ...
$000f0000 constant SEC_FMC_FMC_BWTR2_BUSTURN                        \ Bus turnaround phase duration These bits are written by software to add a delay at the end of current write transaction to next transaction on the same bank. For FRAM memories, the bus turnaround delay should be configured to match the minimum t sub PC /sub (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read). The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal tPC min ...
$30000000 constant SEC_FMC_FMC_BWTR2_ACCMOD                         \ Access mode. Specifies the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
$c0000000 constant SEC_FMC_FMC_BWTR2_DATAHLD                        \ Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous write accesses:


\
\ @brief SRAM/NOR-Flash write timing registers 3
\ Address offset: 0x114
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_BWTR3_ADDSET                         \ Address setup phase duration. These bits are written by software to define the duration of the address setup phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
$000000f0 constant SEC_FMC_FMC_BWTR3_ADDHLD                         \ Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 30 to Figure 33), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
$0000ff00 constant SEC_FMC_FMC_BWTR3_DATAST                         \ Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses: ...
$000f0000 constant SEC_FMC_FMC_BWTR3_BUSTURN                        \ Bus turnaround phase duration These bits are written by software to add a delay at the end of current write transaction to next transaction on the same bank. For FRAM memories, the bus turnaround delay should be configured to match the minimum t sub PC /sub (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read). The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal tPC min ...
$30000000 constant SEC_FMC_FMC_BWTR3_ACCMOD                         \ Access mode. Specifies the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
$c0000000 constant SEC_FMC_FMC_BWTR3_DATAHLD                        \ Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous write accesses:


\
\ @brief SRAM/NOR-Flash write timing registers 4
\ Address offset: 0x11C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_BWTR4_ADDSET                         \ Address setup phase duration. These bits are written by software to define the duration of the address setup phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
$000000f0 constant SEC_FMC_FMC_BWTR4_ADDHLD                         \ Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 30 to Figure 33), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
$0000ff00 constant SEC_FMC_FMC_BWTR4_DATAST                         \ Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses: ...
$000f0000 constant SEC_FMC_FMC_BWTR4_BUSTURN                        \ Bus turnaround phase duration These bits are written by software to add a delay at the end of current write transaction to next transaction on the same bank. For FRAM memories, the bus turnaround delay should be configured to match the minimum t sub PC /sub (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read). The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal tPC min ...
$30000000 constant SEC_FMC_FMC_BWTR4_ACCMOD                         \ Access mode. Specifies the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
$c0000000 constant SEC_FMC_FMC_BWTR4_DATAHLD                        \ Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous write accesses:


\
\ @brief SDRAM control registers 1
\ Address offset: 0x140
\ Reset value: 0x000002D0
\

$00000003 constant SEC_FMC_FMC_SDCR1_NC                             \ Number of column address bits These bits define the number of bits of a column address.
$0000000c constant SEC_FMC_FMC_SDCR1_NR                             \ Number of row address bits These bits define the number of bits of a row address.
$00000030 constant SEC_FMC_FMC_SDCR1_MWID                           \ Memory data bus width. These bits define the memory device width.
$00000040 constant SEC_FMC_FMC_SDCR1_NB                             \ Number of internal banks This bit sets the number of internal banks.
$00000180 constant SEC_FMC_FMC_SDCR1_CAS                            \ CAS Latency This bits sets the SDRAM CAS latency in number of memory clock cycles
$00000200 constant SEC_FMC_FMC_SDCR1_WP                             \ Write protection This bit enables write mode access to the SDRAM bank.
$00000c00 constant SEC_FMC_FMC_SDCR1_SDCLK                          \ SDRAM clock configuration These bits define the SDRAM clock period for both SDRAM banks and allow disabling the clock before changing the frequency. In this case the SDRAM must be re-initialized. Note: The corresponding bits in the FMC_SDCR2 register are don't care.
$00001000 constant SEC_FMC_FMC_SDCR1_RBURST                         \ Burst read This bit enables Burst read mode. The SDRAM controller anticipates the next read commands during the CAS latency and stores data in the Read FIFO. Note: The corresponding bit in the FMC_SDCR2 register is don't care.
$00006000 constant SEC_FMC_FMC_SDCR1_RPIPE                          \ Read pipe These bits define the delay, in clock cycles, for reading data after CAS latency. Note: The corresponding bits in the FMC_SDCR2 register is read only.


\
\ @brief SDRAM control registers 2
\ Address offset: 0x144
\ Reset value: 0x000002D0
\

$00000003 constant SEC_FMC_FMC_SDCR2_NC                             \ Number of column address bits These bits define the number of bits of a column address.
$0000000c constant SEC_FMC_FMC_SDCR2_NR                             \ Number of row address bits These bits define the number of bits of a row address.
$00000030 constant SEC_FMC_FMC_SDCR2_MWID                           \ Memory data bus width. These bits define the memory device width.
$00000040 constant SEC_FMC_FMC_SDCR2_NB                             \ Number of internal banks This bit sets the number of internal banks.
$00000180 constant SEC_FMC_FMC_SDCR2_CAS                            \ CAS Latency This bits sets the SDRAM CAS latency in number of memory clock cycles
$00000200 constant SEC_FMC_FMC_SDCR2_WP                             \ Write protection This bit enables write mode access to the SDRAM bank.
$00000c00 constant SEC_FMC_FMC_SDCR2_SDCLK                          \ SDRAM clock configuration These bits define the SDRAM clock period for both SDRAM banks and allow disabling the clock before changing the frequency. In this case the SDRAM must be re-initialized. Note: The corresponding bits in the FMC_SDCR2 register are don't care.
$00001000 constant SEC_FMC_FMC_SDCR2_RBURST                         \ Burst read This bit enables Burst read mode. The SDRAM controller anticipates the next read commands during the CAS latency and stores data in the Read FIFO. Note: The corresponding bit in the FMC_SDCR2 register is don't care.
$00006000 constant SEC_FMC_FMC_SDCR2_RPIPE                          \ Read pipe These bits define the delay, in clock cycles, for reading data after CAS latency. Note: The corresponding bits in the FMC_SDCR2 register is read only.


\
\ @brief SDRAM timing registers 1
\ Address offset: 0x148
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_SDTR1_TMRD                           \ Load Mode Register to Active These bits define the delay between a Load Mode Register command and an Active or Refresh command in number of memory clock cycles. ....
$000000f0 constant SEC_FMC_FMC_SDTR1_TXSR                           \ Exit Self-refresh delay These bits define the delay from releasing the Self-refresh command to issuing the Activate command in number of memory clock cycles. .... Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TXSR timing corresponding to the slowest SDRAM device.
$00000f00 constant SEC_FMC_FMC_SDTR1_TRAS                           \ Self refresh time These bits define the minimum Self-refresh period in number of memory clock cycles. ....
$0000f000 constant SEC_FMC_FMC_SDTR1_TRC                            \ Row cycle delay These bits define the delay between the Refresh command and the Activate command, as well as the delay between two consecutive Refresh commands. It is expressed in number of memory clock cycles. The TRC timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRC must be programmed with the timings of the slowest device. .... Note: TRC must match the TRC and TRFC (Auto Refresh period) timings defined in the SDRAM device datasheet. Note: The corresponding bits in the FMC_SDTR2 register are don't care.
$000f0000 constant SEC_FMC_FMC_SDTR1_TWR                            \ Recovery delay These bits define the delay between a Write and a Precharge command in number of memory clock cycles. .... Note: TWR must be programmed to match the write recovery time (t sub WR /sub ) defined in the SDRAM datasheet, and to guarantee that: Note: TWR greater than or equal TRAS TRCD and TWR greater than or equalTRC TRCD TRP Note: Example: TRAS= 4 cycles, TRCD= 2 cycles. So, TWR = 2 cycles. TWR must be programmed to 0x1. Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TWR timing corresponding to the slowest SDRAM device. Note: If only one SDRAM device is used, the TWR timing must be kept at reset value (0xF) for the not used bank.
$00f00000 constant SEC_FMC_FMC_SDTR1_TRP                            \ Row precharge delay These bits define the delay between a Precharge command and another command in number of memory clock cycles. The TRP timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRP must be programmed with the timing of the slowest device. .... Note: The corresponding bits in the FMC_SDTR2 register are don't care.
$0f000000 constant SEC_FMC_FMC_SDTR1_TRCD                           \ Row to column delay These bits define the delay between the Activate command and a Read/Write command in number of memory clock cycles. ....


\
\ @brief SDRAM timing registers 2
\ Address offset: 0x14C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant SEC_FMC_FMC_SDTR2_TMRD                           \ Load Mode Register to Active These bits define the delay between a Load Mode Register command and an Active or Refresh command in number of memory clock cycles. ....
$000000f0 constant SEC_FMC_FMC_SDTR2_TXSR                           \ Exit Self-refresh delay These bits define the delay from releasing the Self-refresh command to issuing the Activate command in number of memory clock cycles. .... Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TXSR timing corresponding to the slowest SDRAM device.
$00000f00 constant SEC_FMC_FMC_SDTR2_TRAS                           \ Self refresh time These bits define the minimum Self-refresh period in number of memory clock cycles. ....
$0000f000 constant SEC_FMC_FMC_SDTR2_TRC                            \ Row cycle delay These bits define the delay between the Refresh command and the Activate command, as well as the delay between two consecutive Refresh commands. It is expressed in number of memory clock cycles. The TRC timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRC must be programmed with the timings of the slowest device. .... Note: TRC must match the TRC and TRFC (Auto Refresh period) timings defined in the SDRAM device datasheet. Note: The corresponding bits in the FMC_SDTR2 register are don't care.
$000f0000 constant SEC_FMC_FMC_SDTR2_TWR                            \ Recovery delay These bits define the delay between a Write and a Precharge command in number of memory clock cycles. .... Note: TWR must be programmed to match the write recovery time (t sub WR /sub ) defined in the SDRAM datasheet, and to guarantee that: Note: TWR greater than or equal TRAS TRCD and TWR greater than or equalTRC TRCD TRP Note: Example: TRAS= 4 cycles, TRCD= 2 cycles. So, TWR = 2 cycles. TWR must be programmed to 0x1. Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TWR timing corresponding to the slowest SDRAM device. Note: If only one SDRAM device is used, the TWR timing must be kept at reset value (0xF) for the not used bank.
$00f00000 constant SEC_FMC_FMC_SDTR2_TRP                            \ Row precharge delay These bits define the delay between a Precharge command and another command in number of memory clock cycles. The TRP timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRP must be programmed with the timing of the slowest device. .... Note: The corresponding bits in the FMC_SDTR2 register are don't care.
$0f000000 constant SEC_FMC_FMC_SDTR2_TRCD                           \ Row to column delay These bits define the delay between the Activate command and a Read/Write command in number of memory clock cycles. ....


\
\ @brief SDRAM Command Mode register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000007 constant SEC_FMC_FMC_SDCMR_MODE                           \ Command mode These bits define the command issued to the SDRAM device. Note: When a command is issued, at least one Command Target Bank bit ( CTB1 or CTB2) must be set otherwise the command will be ignored. Note: If two SDRAM banks are used, the Auto-refresh and PALL command must be issued simultaneously to the two devices with CTB1 and CTB2 bits set otherwise the command will be ignored. Note: If only one SDRAM bank is used and a command is issued with it's associated CTB bit set, the other CTB bit of the the unused bank must be kept to 0.
$00000008 constant SEC_FMC_FMC_SDCMR_CTB2                           \ Command Target Bank 2 This bit indicates whether the command will be issued to SDRAM Bank 2 or not.
$00000010 constant SEC_FMC_FMC_SDCMR_CTB1                           \ Command Target Bank 1 This bit indicates whether the command will be issued to SDRAM Bank 1 or not.
$000001e0 constant SEC_FMC_FMC_SDCMR_NRFS                           \ Number of Auto-refresh These bits define the number of consecutive Auto-refresh commands issued when MODE = '011'. ....
$003ffe00 constant SEC_FMC_FMC_SDCMR_MRD                            \ Mode Register definition This 13-bit field defines the SDRAM Mode Register content. The Mode Register is programmed using the Load Mode Register command.


\
\ @brief SDRAM refresh timer register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000001 constant SEC_FMC_FMC_SDRTR_CRE                            \ Clear Refresh error flag This bit is used to clear the Refresh Error Flag (RE) in the Status Register.
$00003ffe constant SEC_FMC_FMC_SDRTR_COUNT                          \ Refresh Timer Count This 13-bit field defines the refresh rate of the SDRAM device. It is expressed in number of memory clock cycles. It must be set at least to 41 SDRAM clock cycles (0x29). Refresh rate = (COUNT + 1) x SDRAM frequency clock COUNT = (SDRAM refresh period / Number of rows) 20
$00004000 constant SEC_FMC_FMC_SDRTR_REIE                           \ RES Interrupt Enable


\
\ @brief SDRAM status register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000001 constant SEC_FMC_FMC_SDSR_RE                              \ Refresh error flag An interrupt is generated if REIE = 1 and RE = 1
$00000006 constant SEC_FMC_FMC_SDSR_MODES1                          \ Status Mode for Bank 1 This bit defines the Status Mode of SDRAM Bank 1.
$00000018 constant SEC_FMC_FMC_SDSR_MODES2                          \ Status Mode for Bank 2 This bit defines the Status Mode of SDRAM Bank 2.
$00000020 constant SEC_FMC_FMC_SDSR_BUSY                            \ Busy status This bit defines the status of the SDRAM controller after a Command Mode request 1; SDRAM Controller is not ready to accept a new request


\
\ @brief Flexible memory controller
\
$57000400 constant SEC_FMC_FMC_BCR1  \ offset: 0x00 : SRAM/NOR-Flash chip-select control register for bank 1
$57000404 constant SEC_FMC_FMC_BTR1  \ offset: 0x04 : SRAM/NOR-Flash chip-select timing register for bank 1
$57000408 constant SEC_FMC_FMC_BCR2  \ offset: 0x08 : SRAM/NOR-Flash chip-select control register for bank 2
$5700040c constant SEC_FMC_FMC_BTR2  \ offset: 0x0C : SRAM/NOR-Flash chip-select timing register for bank 2
$57000410 constant SEC_FMC_FMC_BCR3  \ offset: 0x10 : SRAM/NOR-Flash chip-select control register for bank 3
$57000414 constant SEC_FMC_FMC_BTR3  \ offset: 0x14 : SRAM/NOR-Flash chip-select timing register for bank 3
$57000418 constant SEC_FMC_FMC_BCR4  \ offset: 0x18 : SRAM/NOR-Flash chip-select control register for bank 4
$5700041c constant SEC_FMC_FMC_BTR4  \ offset: 0x1C : SRAM/NOR-Flash chip-select timing register for bank 4
$57000420 constant SEC_FMC_FMC_PCSCNTR  \ offset: 0x20 : PSRAM chip select counter register
$57000480 constant SEC_FMC_FMC_PCR  \ offset: 0x80 : NAND Flash control registers
$57000484 constant SEC_FMC_FMC_SR  \ offset: 0x84 : FIFO status and interrupt register
$57000488 constant SEC_FMC_FMC_PMEM  \ offset: 0x88 : Common memory space timing register
$5700048c constant SEC_FMC_FMC_PATT  \ offset: 0x8C : Attribute memory space timing register
$57000494 constant SEC_FMC_FMC_ECCR  \ offset: 0x94 : ECC result registers
$57000504 constant SEC_FMC_FMC_BWTR1  \ offset: 0x104 : SRAM/NOR-Flash write timing registers 1
$5700050c constant SEC_FMC_FMC_BWTR2  \ offset: 0x10C : SRAM/NOR-Flash write timing registers 2
$57000514 constant SEC_FMC_FMC_BWTR3  \ offset: 0x114 : SRAM/NOR-Flash write timing registers 3
$5700051c constant SEC_FMC_FMC_BWTR4  \ offset: 0x11C : SRAM/NOR-Flash write timing registers 4
$57000540 constant SEC_FMC_FMC_SDCR1  \ offset: 0x140 : SDRAM control registers 1
$57000544 constant SEC_FMC_FMC_SDCR2  \ offset: 0x144 : SDRAM control registers 2
$57000548 constant SEC_FMC_FMC_SDTR1  \ offset: 0x148 : SDRAM timing registers 1
$5700054c constant SEC_FMC_FMC_SDTR2  \ offset: 0x14C : SDRAM timing registers 2
$57000550 constant SEC_FMC_FMC_SDCMR  \ offset: 0x150 : SDRAM Command Mode register
$57000554 constant SEC_FMC_FMC_SDRTR  \ offset: 0x154 : SDRAM refresh timer register
$57000558 constant SEC_FMC_FMC_SDSR  \ offset: 0x158 : SDRAM status register

