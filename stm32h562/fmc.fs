\
\ @file fmc.fs
\ @brief Flexible memory controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMC_DEF

  [ifdef] FMC_FMC_BCR1_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register for bank 1
    \ Address offset: 0x00
    \ Reset value: 0x000030DB
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit Enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AHB bus.
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type Defines the type of external memory attached to the corresponding memory bank.
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width Defines the external memory device width, valid for all type of memories.
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable Enables NOR Flash memory access operations.
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode.
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit Defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode.
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC.
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable This bit enables the FMC to program the write timings for non multiplexed asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in mode 1 or mode 2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP = 0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM page size These are used for CellularRAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Others: reserved
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is don't care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup These bits configure the NBL setup timing from NBLx low to chip select NEx low.
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable This bit enables or disables the FMC controller. Note: The FMCEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
  [then]


  [ifdef] FMC_FMC_BTR1_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register for bank 1
    \ Address offset: 0x04
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 21 to Figure 33), used in SRAMs, ROMs, asynchronous NOR Flash and PSRAM: ... For each access mode address setup phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is don't care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 21 to Figure 33), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, refer to the respective figure (Figure 21 to Figure 33). Example: Mode 1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 HCLK clock cycles. Note: In synchronous accesses, this value is don't care.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of current read or write transaction to next transaction on the same bank. This delay allows to match the minimum time between consecutive transactions (t EHEL from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t EHQZ , chip enable high to output Hi-Z). This delay is recommended for mode D and muxed mode. For non-muxed memory, the bus turnaround delay can be set to minimum value. (BUSTURN + 1)HCLK period greater than or equal max(t EHEL min, t EHQZ max) For FRAM memories, the bus turnaround delay should be configured to match the minimum tPC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read) to match the tPC memory timing. The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal t PC min ...
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal) Defines the period of FMC_CLK clock output signal, expressed in number of HCLK cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is don't care. Note: Refer to Section 5.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), defines the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in HCLK periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode Specifies the asynchronous access modes as shown in the timing diagrams. These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: For read accesses For write accesses
  [then]


  [ifdef] FMC_FMC_BCR2_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register for bank 2
    \ Address offset: 0x08
    \ Reset value: 0x000030D2
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit Enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AHB bus.
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type Defines the type of external memory attached to the corresponding memory bank.
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width Defines the external memory device width, valid for all type of memories.
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable Enables NOR Flash memory access operations.
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode.
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit Defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode.
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC.
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable This bit enables the FMC to program the write timings for non multiplexed asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in mode 1 or mode 2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP = 0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM page size These are used for CellularRAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Others: reserved
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is don't care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup These bits configure the NBL setup timing from NBLx low to chip select NEx low.
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable This bit enables or disables the FMC controller. Note: The FMCEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
  [then]


  [ifdef] FMC_FMC_BTR2_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register for bank 2
    \ Address offset: 0x0C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 21 to Figure 33), used in SRAMs, ROMs, asynchronous NOR Flash and PSRAM: ... For each access mode address setup phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is don't care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 21 to Figure 33), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, refer to the respective figure (Figure 21 to Figure 33). Example: Mode 1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 HCLK clock cycles. Note: In synchronous accesses, this value is don't care.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of current read or write transaction to next transaction on the same bank. This delay allows to match the minimum time between consecutive transactions (t EHEL from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t EHQZ , chip enable high to output Hi-Z). This delay is recommended for mode D and muxed mode. For non-muxed memory, the bus turnaround delay can be set to minimum value. (BUSTURN + 1)HCLK period greater than or equal max(t EHEL min, t EHQZ max) For FRAM memories, the bus turnaround delay should be configured to match the minimum tPC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read) to match the tPC memory timing. The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal t PC min ...
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal) Defines the period of FMC_CLK clock output signal, expressed in number of HCLK cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is don't care. Note: Refer to Section 5.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), defines the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in HCLK periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode Specifies the asynchronous access modes as shown in the timing diagrams. These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: For read accesses For write accesses
  [then]


  [ifdef] FMC_FMC_BCR3_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register for bank 3
    \ Address offset: 0x10
    \ Reset value: 0x000030D2
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit Enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AHB bus.
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type Defines the type of external memory attached to the corresponding memory bank.
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width Defines the external memory device width, valid for all type of memories.
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable Enables NOR Flash memory access operations.
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode.
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit Defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode.
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC.
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable This bit enables the FMC to program the write timings for non multiplexed asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in mode 1 or mode 2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP = 0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM page size These are used for CellularRAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Others: reserved
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is don't care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup These bits configure the NBL setup timing from NBLx low to chip select NEx low.
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable This bit enables or disables the FMC controller. Note: The FMCEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
  [then]


  [ifdef] FMC_FMC_BTR3_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register for bank 3
    \ Address offset: 0x14
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 21 to Figure 33), used in SRAMs, ROMs, asynchronous NOR Flash and PSRAM: ... For each access mode address setup phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is don't care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 21 to Figure 33), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, refer to the respective figure (Figure 21 to Figure 33). Example: Mode 1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 HCLK clock cycles. Note: In synchronous accesses, this value is don't care.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of current read or write transaction to next transaction on the same bank. This delay allows to match the minimum time between consecutive transactions (t EHEL from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t EHQZ , chip enable high to output Hi-Z). This delay is recommended for mode D and muxed mode. For non-muxed memory, the bus turnaround delay can be set to minimum value. (BUSTURN + 1)HCLK period greater than or equal max(t EHEL min, t EHQZ max) For FRAM memories, the bus turnaround delay should be configured to match the minimum tPC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read) to match the tPC memory timing. The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal t PC min ...
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal) Defines the period of FMC_CLK clock output signal, expressed in number of HCLK cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is don't care. Note: Refer to Section 5.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), defines the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in HCLK periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode Specifies the asynchronous access modes as shown in the timing diagrams. These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: For read accesses For write accesses
  [then]


  [ifdef] FMC_FMC_BCR4_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register for bank 4
    \ Address offset: 0x18
    \ Reset value: 0x000030D2
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit Enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AHB bus.
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type Defines the type of external memory attached to the corresponding memory bank.
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width Defines the external memory device width, valid for all type of memories.
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable Enables NOR Flash memory access operations.
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode.
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit Defines the polarity of the wait signal from memory used for either in Synchronous or Asynchronous mode.
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in Synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC.
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in Synchronous mode.
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable This bit enables the FMC to program the write timings for non multiplexed asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the Extended mode is disabled, the FMC can operate in mode 1 or mode 2 as follows: Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP = 0x0 or 0x01) Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM page size These are used for CellularRAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Others: reserved
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in Synchronous mode to generate the FMC_CLK continuous clock. Note: If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is don't care. Note: If the Synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup These bits configure the NBL setup timing from NBLx low to chip select NEx low.
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable This bit enables or disables the FMC controller. Note: The FMCEN bit of the FMC_BCR2..4 registers is don't care. It is only enabled through the FMC_BCR1 register.
  [then]


  [ifdef] FMC_FMC_BTR4_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register for bank 4
    \ Address offset: 0x1C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure 21 to Figure 33), used in SRAMs, ROMs, asynchronous NOR Flash and PSRAM: ... For each access mode address setup phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is don't care. Note: In Muxed mode or mode D, the minimum value for ADDSET is 1. Note: In mode 1 and PSRAM memory, the minimum value for ADDSET is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure 21 to Figure 33), used in mode D or multiplexed accesses: ... For each access mode address-hold phase duration, refer to the respective figure (Figure 21 to Figure 33). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... For each memory type and access mode data-phase duration, refer to the respective figure (Figure 21 to Figure 33). Example: Mode 1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 HCLK clock cycles. Note: In synchronous accesses, this value is don't care.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of current read or write transaction to next transaction on the same bank. This delay allows to match the minimum time between consecutive transactions (t EHEL from NEx high to NEx low) and the maximum time needed by the memory to free the data bus after a read access (t EHQZ , chip enable high to output Hi-Z). This delay is recommended for mode D and muxed mode. For non-muxed memory, the bus turnaround delay can be set to minimum value. (BUSTURN + 1)HCLK period greater than or equal max(t EHEL min, t EHQZ max) For FRAM memories, the bus turnaround delay should be configured to match the minimum tPC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read) to match the tPC memory timing. The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal t PC min ...
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal) Defines the period of FMC_CLK clock output signal, expressed in number of HCLK cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is don't care. Note: Refer to Section 5.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] (see note below bit descriptions): Data latency for synchronous memory For synchronous access with read/write Burst mode enabled (BURSTEN / CBURSTRW bits set), defines the number of memory clock cycles (+2) to issue to the memory before reading/writing the first data: This timing parameter is not expressed in HCLK periods, but in FMC_CLK periods. For asynchronous access, this value is don't care.
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode Specifies the asynchronous access modes as shown in the timing diagrams. These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: For read accesses For write accesses
  [then]


  [ifdef] FMC_FMC_PCSCNTR_DEF
    \
    \ @brief PSRAM chip select counter register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CSCOUNT                    \ [0x00 : 16] Chip select counter. These bits are written by software to define the maximum chip select low pulse duration. It is expressed in FMC_CLK cycles for synchronous accesses and in HCLK cycles for asynchronous accesses. The counter is disabled if the programmed value is 0.
    $10 constant FMC_CNTB1EN                    \ [0x10] Counter Bank 1 enable This bit enables the chip select counter for PSRAM/NOR Bank 1.
    $11 constant FMC_CNTB2EN                    \ [0x11] Counter Bank 2 enable This bit enables the chip select counter for PSRAM/NOR Bank 2.
    $12 constant FMC_CNTB3EN                    \ [0x12] Counter Bank 3 enable This bit enables the chip select counter for PSRAM/NOR Bank 3.
    $13 constant FMC_CNTB4EN                    \ [0x13] Counter Bank 4 enable This bit enables the chip select counter for PSRAM/NOR Bank 4.
  [then]


  [ifdef] FMC_FMC_PCR_DEF
    \
    \ @brief NAND Flash control registers
    \ Address offset: 0x80
    \ Reset value: 0x00000018
    \
    $01 constant FMC_PWAITEN                    \ [0x01] Wait feature enable bit Enables the Wait feature for the NAND Flash memory bank:
    $02 constant FMC_PBKEN                      \ [0x02] NAND Flash memory bank enable bit Enables the memory bank. Accessing a disabled memory bank causes an ERROR on AHB bus
    $03 constant FMC_PTYP                       \ [0x03] Memory type Defines the type of device attached to the corresponding memory bank:
    $04 constant FMC_PWID                       \ [0x04 : 2] Data bus width Defines the external memory device width.
    $06 constant FMC_ECCEN                      \ [0x06] ECC computation logic enable bit
    $09 constant FMC_TCLR                       \ [0x09 : 4] CLE to RE delay Sets time from CLE low to RE low in number of AHB clock cycles (HCLK). Time is t_clr = (TCLR + SET + 2) THCLK where THCLK is the HCLK clock period Note: SET is MEMSET or ATTSET according to the addressed space.
    $0d constant FMC_TAR                        \ [0x0d : 3] ALE to RE delay Sets time from ALE low to RE low in number of AHB clock cycles (HCLK). Time is: t_ar = (TAR + SET + 2) THCLK where THCLK is the HCLK clock period Note: SET is MEMSET or ATTSET according to the addressed space.
    $10 constant FMC_TAR3                       \ [0x10] ALE to RE delay Sets time from ALE low to RE low in number of AHB clock cycles (HCLK). Time is: t_ar = (TAR + SET + 2) THCLK where THCLK is the HCLK clock period Note: SET is MEMSET or ATTSET according to the addressed space.
    $11 constant FMC_ECCPS                      \ [0x11 : 3] ECC page size Defines the page size for the extended ECC:
  [then]


  [ifdef] FMC_FMC_SR_DEF
    \
    \ @brief FIFO status and interrupt register
    \ Address offset: 0x84
    \ Reset value: 0x00000040
    \
    $00 constant FMC_IRS                        \ [0x00] Interrupt rising edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it is set.
    $01 constant FMC_ILS                        \ [0x01] Interrupt high-level status The flag is set by hardware and reset by software.
    $02 constant FMC_IFS                        \ [0x02] Interrupt falling edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it is set.
    $03 constant FMC_IREN                       \ [0x03] Interrupt rising edge detection enable bit
    $04 constant FMC_ILEN                       \ [0x04] Interrupt high-level detection enable bit
    $05 constant FMC_IFEN                       \ [0x05] Interrupt falling edge detection enable bit
    $06 constant FMC_FEMPT                      \ [0x06] FIFO empty Read-only bit that provides the status of the FIFO
  [then]


  [ifdef] FMC_FMC_PMEM_DEF
    \
    \ @brief Common memory space timing register
    \ Address offset: 0x88
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_MEMSET                     \ [0x00 : 8] Common memory x setup time Defines the number of HCLK (+1) clock cycles to set up the address before the command assertion (NWE, NOE), for NAND Flash read or write access to common memory space on socket x:
    $08 constant FMC_MEMWAIT                    \ [0x08 : 8] Common memory wait time Defines the minimum number of HCLK (+1) clock cycles to assert the command (NWE, NOE), for NAND Flash read or write access to common memory space on socket. The duration of command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of HCLK:
    $10 constant FMC_MEMHOLD                    \ [0x10 : 8] Common memory hold time Defines the number of HCLK clock cycles for write access and HCLK (+2) clock cycles for read access during which the address is held (and data for write accesses) after the command is deasserted (NWE, NOE), for NAND Flash read or write access to common memory space on socket x:
    $18 constant FMC_MEMHIZ                     \ [0x18 : 8] Common memory x data bus Hi-Z time Defines the number of HCLK clock cycles during which the data bus is kept Hi-Z after the start of a NAND Flash write access to common memory space on socket. This is only valid for write transactions:
  [then]


  [ifdef] FMC_FMC_PATT_DEF
    \
    \ @brief Attribute memory space timing register
    \ Address offset: 0x8C
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_ATTSET                     \ [0x00 : 8] Attribute memory setup time Defines the number of HCLK (+1) clock cycles to set up address before the command assertion (NWE, NOE), for NAND Flash read or write access to attribute memory space on socket:
    $08 constant FMC_ATTWAIT                    \ [0x08 : 8] Attribute memory wait time Defines the minimum number of HCLK (+1) clock cycles to assert the command (NWE, NOE), for NAND Flash read or write access to attribute memory space on socket x. The duration for command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of HCLK:
    $10 constant FMC_ATTHOLD                    \ [0x10 : 8] Attribute memory hold time Defines the number of HCLK clock cycles for write access and HCLK (+2) clock cycles for read access during which the address is held (and data for write access) after the command deassertion (NWE, NOE), for NAND Flash read or write access to attribute memory space on socket:
    $18 constant FMC_ATTHIZ                     \ [0x18 : 8] Attribute memory data bus Hi-Z time Defines the number of HCLK clock cycles during which the data bus is kept in Hi-Z after the start of a NAND Flash write access to attribute memory space on socket. Only valid for writ transaction:
  [then]


  [ifdef] FMC_FMC_ECCR_DEF
    \
    \ @brief ECC result registers
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FMC_ECC                        \ [0x00 : 32] ECC result This field contains the value computed by the ECC computation logic. Table 99 describes the contents of these bitfields.
  [then]


  [ifdef] FMC_FMC_BWTR1_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 1
    \ Address offset: 0x104
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration. These bits are written by software to define the duration of the address setup phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 30 to Figure 33), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses: ...
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of current write transaction to next transaction on the same bank. For FRAM memories, the bus turnaround delay should be configured to match the minimum t PC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read). The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal tPC min ...
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode. Specifies the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous write accesses:
  [then]


  [ifdef] FMC_FMC_BWTR2_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 2
    \ Address offset: 0x10C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration. These bits are written by software to define the duration of the address setup phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 30 to Figure 33), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses: ...
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of current write transaction to next transaction on the same bank. For FRAM memories, the bus turnaround delay should be configured to match the minimum t PC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read). The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal tPC min ...
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode. Specifies the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous write accesses:
  [then]


  [ifdef] FMC_FMC_BWTR3_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 3
    \ Address offset: 0x114
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration. These bits are written by software to define the duration of the address setup phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 30 to Figure 33), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses: ...
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of current write transaction to next transaction on the same bank. For FRAM memories, the bus turnaround delay should be configured to match the minimum t PC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read). The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal tPC min ...
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode. Specifies the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous write accesses:
  [then]


  [ifdef] FMC_FMC_BWTR4_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 4
    \ Address offset: 0x11C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration. These bits are written by software to define the duration of the address setup phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure 30 to Figure 33), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure 21 to Figure 33), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses: ...
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of current write transaction to next transaction on the same bank. For FRAM memories, the bus turnaround delay should be configured to match the minimum t PC (precharge time) timings. The bus turnaround delay is inserted between any consecutive transactions on the same bank (read/read, write/write, read/write and write/read). The chip select is toggling between any consecutive accesses. (BUSTURN + 1)HCLK period greater than or equal tPC min ...
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode. Specifies the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration These bits are written by software to define the duration of the data hold phase in HCLK cycles (refer to Figure 21 to Figure 33), used in asynchronous write accesses:
  [then]


  [ifdef] FMC_FMC_SDCR1_DEF
    \
    \ @brief SDRAM control registers 1
    \ Address offset: 0x140
    \ Reset value: 0x000002D0
    \
    $00 constant FMC_NC                         \ [0x00 : 2] Number of column address bits These bits define the number of bits of a column address.
    $02 constant FMC_NR                         \ [0x02 : 2] Number of row address bits These bits define the number of bits of a row address.
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width. These bits define the memory device width.
    $06 constant FMC_NB                         \ [0x06] Number of internal banks This bit sets the number of internal banks.
    $07 constant FMC_CAS                        \ [0x07 : 2] CAS Latency This bits sets the SDRAM CAS latency in number of memory clock cycles
    $09 constant FMC_WP                         \ [0x09] Write protection This bit enables write mode access to the SDRAM bank.
    $0a constant FMC_SDCLK                      \ [0x0a : 2] SDRAM clock configuration These bits define the SDRAM clock period for both SDRAM banks and allow disabling the clock before changing the frequency. In this case the SDRAM must be re-initialized. Note: The corresponding bits in the FMC_SDCR2 register are don't care.
    $0c constant FMC_RBURST                     \ [0x0c] Burst read This bit enables Burst read mode. The SDRAM controller anticipates the next read commands during the CAS latency and stores data in the Read FIFO. Note: The corresponding bit in the FMC_SDCR2 register is don't care.
    $0d constant FMC_RPIPE                      \ [0x0d : 2] Read pipe These bits define the delay, in clock cycles, for reading data after CAS latency. Note: The corresponding bits in the FMC_SDCR2 register is read only.
  [then]


  [ifdef] FMC_FMC_SDCR2_DEF
    \
    \ @brief SDRAM control registers 2
    \ Address offset: 0x144
    \ Reset value: 0x000002D0
    \
    $00 constant FMC_NC                         \ [0x00 : 2] Number of column address bits These bits define the number of bits of a column address.
    $02 constant FMC_NR                         \ [0x02 : 2] Number of row address bits These bits define the number of bits of a row address.
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width. These bits define the memory device width.
    $06 constant FMC_NB                         \ [0x06] Number of internal banks This bit sets the number of internal banks.
    $07 constant FMC_CAS                        \ [0x07 : 2] CAS Latency This bits sets the SDRAM CAS latency in number of memory clock cycles
    $09 constant FMC_WP                         \ [0x09] Write protection This bit enables write mode access to the SDRAM bank.
    $0a constant FMC_SDCLK                      \ [0x0a : 2] SDRAM clock configuration These bits define the SDRAM clock period for both SDRAM banks and allow disabling the clock before changing the frequency. In this case the SDRAM must be re-initialized. Note: The corresponding bits in the FMC_SDCR2 register are don't care.
    $0c constant FMC_RBURST                     \ [0x0c] Burst read This bit enables Burst read mode. The SDRAM controller anticipates the next read commands during the CAS latency and stores data in the Read FIFO. Note: The corresponding bit in the FMC_SDCR2 register is don't care.
    $0d constant FMC_RPIPE                      \ [0x0d : 2] Read pipe These bits define the delay, in clock cycles, for reading data after CAS latency. Note: The corresponding bits in the FMC_SDCR2 register is read only.
  [then]


  [ifdef] FMC_FMC_SDTR1_DEF
    \
    \ @brief SDRAM timing registers 1
    \ Address offset: 0x148
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_TMRD                       \ [0x00 : 4] Load Mode Register to Active These bits define the delay between a Load Mode Register command and an Active or Refresh command in number of memory clock cycles. ....
    $04 constant FMC_TXSR                       \ [0x04 : 4] Exit Self-refresh delay These bits define the delay from releasing the Self-refresh command to issuing the Activate command in number of memory clock cycles. .... Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TXSR timing corresponding to the slowest SDRAM device.
    $08 constant FMC_TRAS                       \ [0x08 : 4] Self refresh time These bits define the minimum Self-refresh period in number of memory clock cycles. ....
    $0c constant FMC_TRC                        \ [0x0c : 4] Row cycle delay These bits define the delay between the Refresh command and the Activate command, as well as the delay between two consecutive Refresh commands. It is expressed in number of memory clock cycles. The TRC timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRC must be programmed with the timings of the slowest device. .... Note: TRC must match the TRC and TRFC (Auto Refresh period) timings defined in the SDRAM device datasheet. Note: The corresponding bits in the FMC_SDTR2 register are don't care.
    $10 constant FMC_TWR                        \ [0x10 : 4] Recovery delay These bits define the delay between a Write and a Precharge command in number of memory clock cycles. .... Note: TWR must be programmed to match the write recovery time (t WR ) defined in the SDRAM datasheet, and to guarantee that: Note: TWR greater than or equal TRAS TRCD and TWR greater than or equalTRC TRCD TRP Note: Example: TRAS= 4 cycles, TRCD= 2 cycles. So, TWR = 2 cycles. TWR must be programmed to 0x1. Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TWR timing corresponding to the slowest SDRAM device. Note: If only one SDRAM device is used, the TWR timing must be kept at reset value (0xF) for the not used bank.
    $14 constant FMC_TRP                        \ [0x14 : 4] Row precharge delay These bits define the delay between a Precharge command and another command in number of memory clock cycles. The TRP timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRP must be programmed with the timing of the slowest device. .... Note: The corresponding bits in the FMC_SDTR2 register are don't care.
    $18 constant FMC_TRCD                       \ [0x18 : 4] Row to column delay These bits define the delay between the Activate command and a Read/Write command in number of memory clock cycles. ....
  [then]


  [ifdef] FMC_FMC_SDTR2_DEF
    \
    \ @brief SDRAM timing registers 2
    \ Address offset: 0x14C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_TMRD                       \ [0x00 : 4] Load Mode Register to Active These bits define the delay between a Load Mode Register command and an Active or Refresh command in number of memory clock cycles. ....
    $04 constant FMC_TXSR                       \ [0x04 : 4] Exit Self-refresh delay These bits define the delay from releasing the Self-refresh command to issuing the Activate command in number of memory clock cycles. .... Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TXSR timing corresponding to the slowest SDRAM device.
    $08 constant FMC_TRAS                       \ [0x08 : 4] Self refresh time These bits define the minimum Self-refresh period in number of memory clock cycles. ....
    $0c constant FMC_TRC                        \ [0x0c : 4] Row cycle delay These bits define the delay between the Refresh command and the Activate command, as well as the delay between two consecutive Refresh commands. It is expressed in number of memory clock cycles. The TRC timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRC must be programmed with the timings of the slowest device. .... Note: TRC must match the TRC and TRFC (Auto Refresh period) timings defined in the SDRAM device datasheet. Note: The corresponding bits in the FMC_SDTR2 register are don't care.
    $10 constant FMC_TWR                        \ [0x10 : 4] Recovery delay These bits define the delay between a Write and a Precharge command in number of memory clock cycles. .... Note: TWR must be programmed to match the write recovery time (t WR ) defined in the SDRAM datasheet, and to guarantee that: Note: TWR greater than or equal TRAS TRCD and TWR greater than or equalTRC TRCD TRP Note: Example: TRAS= 4 cycles, TRCD= 2 cycles. So, TWR = 2 cycles. TWR must be programmed to 0x1. Note: If two SDRAM devices are used, the FMC_SDTR1 and FMC_SDTR2 must be programmed with the same TWR timing corresponding to the slowest SDRAM device. Note: If only one SDRAM device is used, the TWR timing must be kept at reset value (0xF) for the not used bank.
    $14 constant FMC_TRP                        \ [0x14 : 4] Row precharge delay These bits define the delay between a Precharge command and another command in number of memory clock cycles. The TRP timing is only configured in the FMC_SDTR1 register. If two SDRAM devices are used, the TRP must be programmed with the timing of the slowest device. .... Note: The corresponding bits in the FMC_SDTR2 register are don't care.
    $18 constant FMC_TRCD                       \ [0x18 : 4] Row to column delay These bits define the delay between the Activate command and a Read/Write command in number of memory clock cycles. ....
  [then]


  [ifdef] FMC_FMC_SDCMR_DEF
    \
    \ @brief SDRAM Command Mode register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant FMC_MODE                       \ [0x00 : 3] Command mode These bits define the command issued to the SDRAM device. Note: When a command is issued, at least one Command Target Bank bit ( CTB1 or CTB2) must be set otherwise the command will be ignored. Note: If two SDRAM banks are used, the Auto-refresh and PALL command must be issued simultaneously to the two devices with CTB1 and CTB2 bits set otherwise the command will be ignored. Note: If only one SDRAM bank is used and a command is issued with it's associated CTB bit set, the other CTB bit of the the unused bank must be kept to 0.
    $03 constant FMC_CTB2                       \ [0x03] Command Target Bank 2 This bit indicates whether the command will be issued to SDRAM Bank 2 or not.
    $04 constant FMC_CTB1                       \ [0x04] Command Target Bank 1 This bit indicates whether the command will be issued to SDRAM Bank 1 or not.
    $05 constant FMC_NRFS                       \ [0x05 : 4] Number of Auto-refresh These bits define the number of consecutive Auto-refresh commands issued when MODE = '011'. ....
    $09 constant FMC_MRD                        \ [0x09 : 13] Mode Register definition This 13-bit field defines the SDRAM Mode Register content. The Mode Register is programmed using the Load Mode Register command.
  [then]


  [ifdef] FMC_FMC_SDRTR_DEF
    \
    \ @brief SDRAM refresh timer register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CRE                        \ [0x00] Clear Refresh error flag This bit is used to clear the Refresh Error Flag (RE) in the Status Register.
    $01 constant FMC_COUNT                      \ [0x01 : 13] Refresh Timer Count This 13-bit field defines the refresh rate of the SDRAM device. It is expressed in number of memory clock cycles. It must be set at least to 41 SDRAM clock cycles (0x29). Refresh rate = (COUNT + 1) x SDRAM frequency clock COUNT = (SDRAM refresh period / Number of rows) 20
    $0e constant FMC_REIE                       \ [0x0e] RES Interrupt Enable
  [then]


  [ifdef] FMC_FMC_SDSR_DEF
    \
    \ @brief SDRAM status register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant FMC_RE                         \ [0x00] Refresh error flag An interrupt is generated if REIE = 1 and RE = 1
    $01 constant FMC_MODES1                     \ [0x01 : 2] Status Mode for Bank 1 This bit defines the Status Mode of SDRAM Bank 1.
    $03 constant FMC_MODES2                     \ [0x03 : 2] Status Mode for Bank 2 This bit defines the Status Mode of SDRAM Bank 2.
    $05 constant FMC_BUSY                       \ [0x05] Busy status This bit defines the status of the SDRAM controller after a Command Mode request 1; SDRAM Controller is not ready to accept a new request
  [then]

  \
  \ @brief Flexible memory controller
  \
  $00 constant FMC_FMC_BCR1             \ SRAM/NOR-Flash chip-select control register for bank 1
  $04 constant FMC_FMC_BTR1             \ SRAM/NOR-Flash chip-select timing register for bank 1
  $08 constant FMC_FMC_BCR2             \ SRAM/NOR-Flash chip-select control register for bank 2
  $0C constant FMC_FMC_BTR2             \ SRAM/NOR-Flash chip-select timing register for bank 2
  $10 constant FMC_FMC_BCR3             \ SRAM/NOR-Flash chip-select control register for bank 3
  $14 constant FMC_FMC_BTR3             \ SRAM/NOR-Flash chip-select timing register for bank 3
  $18 constant FMC_FMC_BCR4             \ SRAM/NOR-Flash chip-select control register for bank 4
  $1C constant FMC_FMC_BTR4             \ SRAM/NOR-Flash chip-select timing register for bank 4
  $20 constant FMC_FMC_PCSCNTR          \ PSRAM chip select counter register
  $80 constant FMC_FMC_PCR              \ NAND Flash control registers
  $84 constant FMC_FMC_SR               \ FIFO status and interrupt register
  $88 constant FMC_FMC_PMEM             \ Common memory space timing register
  $8C constant FMC_FMC_PATT             \ Attribute memory space timing register
  $94 constant FMC_FMC_ECCR             \ ECC result registers
  $104 constant FMC_FMC_BWTR1           \ SRAM/NOR-Flash write timing registers 1
  $10C constant FMC_FMC_BWTR2           \ SRAM/NOR-Flash write timing registers 2
  $114 constant FMC_FMC_BWTR3           \ SRAM/NOR-Flash write timing registers 3
  $11C constant FMC_FMC_BWTR4           \ SRAM/NOR-Flash write timing registers 4
  $140 constant FMC_FMC_SDCR1           \ SDRAM control registers 1
  $144 constant FMC_FMC_SDCR2           \ SDRAM control registers 2
  $148 constant FMC_FMC_SDTR1           \ SDRAM timing registers 1
  $14C constant FMC_FMC_SDTR2           \ SDRAM timing registers 2
  $150 constant FMC_FMC_SDCMR           \ SDRAM Command Mode register
  $154 constant FMC_FMC_SDRTR           \ SDRAM refresh timer register
  $158 constant FMC_FMC_SDSR            \ SDRAM status register

: FMC_DEF ; [then]
