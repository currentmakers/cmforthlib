\
\ @file fmc.fs
\ @brief FMC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMC_DEF

  [ifdef] FMC_FMC_BCR1_DEF
    \
    \ @brief FMC_BCR1
    \ Address offset: 0x00
    \ Reset value: 0x000030DB
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit This bit enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AXI bus.
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type These bits define the type of external memory attached to the corresponding memory bank:
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width Defines the external memory device width, valid for all type of memories.
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable This bit enables NOR Flash memory access operations.
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode:
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit This bit defines the polarity of the wait signal from memory used for either in synchronous or asynchronous mode:
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC:
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in synchronous mode.
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable. This bit enables the FMC to program the write timings for asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the extended mode is disabled, the FMC can operate in Mode1 or Mode2 as follows: ** Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP =0x0 or 0x01) ** Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM Page Size These are used for Cellular RAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Other configuration: reserved.
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous Clock Enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in synchronous mode to generate the FMC_CLK continuous clock. If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is dont care. If the synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO Disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.
    $16 constant FMC_NBLSET                     \ [0x16 : 2] NBLSET
  [then]


  [ifdef] FMC_FMC_BTR1_DEF
    \
    \ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, 2 registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
    \ Address offset: 0x04
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure81 to Figure93), used in SRAMs, ROMs and asynchronous NOR Flash: For each access mode address setup phase duration, please refer to the respective figure (refer to Figure81 to Figure93). Note: In synchronous accesses, this value is dont care. In Muxed mode or Mode D, the minimum value for ADDSET is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure81 to Figure93), used in mode D or multiplexed accesses: For each access mode address-hold phase duration, please refer to the respective figure (Figure81 to Figure93). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure81 to Figure93), used in asynchronous accesses: For each memory type and access mode data-phase duration, please refer to the respective figure (Figure81 to Figure93). Example: Mode1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 KCK_FMC clock cycles. Note: In synchronous accesses, this value is dont care.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of a write-to-read or read-to write transaction. The programmed bus turnaround delay is inserted between an asynchronous read (in muxed or mode D) or write transaction and any other asynchronous /synchronous read/write from/to a static bank. If a read operation is performed, the bank can be the same or a different one, whereas it must be different in case of write operation to the bank, except in muxed mode or mode D. In some cases, whatever the programmed BUSTRUN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except in muxed mode and mode D. There is a bus turnaround delay of 1 FMC clock cycle between: Two consecutive asynchronous read transfers to the same static memory bank except for modes muxed and D. An asynchronous read to an asynchronous or synchronous write to any static bank or dynamic bank except in modes muxed and D mode. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to the same bank. A synchronous write (burst or single) access and an asynchronous write or read transfer to or from static memory bank (the bank can be the same or a different one in case of a read operation. Two consecutive synchronous read operations (in Burst or Single mode) followed by any synchronous/asynchronous read or write from/to another static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to different static banks. A synchronous write access (in Burst or Single mode) and a synchronous read from the same or a different bank. The bus turnaround delay allows to match the minimum time between consecutive transactions (tEHEL from NEx high to NEx low) and the maximum time required by the memory to free the data bus after a read access (tEHQZ): (BUSTRUN + 1) KCK_FMC period &#8805; tEHELmin and (BUSTRUN + 2)KCK_FMC period &#8805; tEHQZmax if EXTMOD = 0 (BUSTRUN + 2)KCK_FMC period &#8805; max (tEHELmin, tEHQZmax) if EXTMOD = 126. ...
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal) These bits define the period of FMC_CLK clock output signal, expressed in number of KCK_FMC cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is dont care. Note: Refer to Section20.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] Data latency for synchronous memory For synchronous access with read write burst mode enabled these bits define the number of memory clock cycles
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode These bits specify the asynchronous access modes as shown in the timing diagrams. They are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_BCR2_DEF
    \
    \ @brief FMC_BCR2
    \ Address offset: 0x08
    \ Reset value: 0x000030D2
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit This bit enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AXI bus.
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type These bits define the type of external memory attached to the corresponding memory bank:
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width Defines the external memory device width, valid for all type of memories.
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable This bit enables NOR Flash memory access operations.
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode:
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit This bit defines the polarity of the wait signal from memory used for either in synchronous or asynchronous mode:
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC:
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in synchronous mode.
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable. This bit enables the FMC to program the write timings for asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the extended mode is disabled, the FMC can operate in Mode1 or Mode2 as follows: ** Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP =0x0 or 0x01) ** Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM Page Size These are used for Cellular RAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Other configuration: reserved.
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous Clock Enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in synchronous mode to generate the FMC_CLK continuous clock. If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is dont care. If the synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO Disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.
    $16 constant FMC_NBLSET                     \ [0x16 : 2] NBLSET
  [then]


  [ifdef] FMC_FMC_BTR2_DEF
    \
    \ @brief FMC_BTR2
    \ Address offset: 0x0C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure81 to Figure93), used in SRAMs, ROMs and asynchronous NOR Flash: For each access mode address setup phase duration, please refer to the respective figure (refer to Figure81 to Figure93). Note: In synchronous accesses, this value is dont care. In Muxed mode or Mode D, the minimum value for ADDSET is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure81 to Figure93), used in mode D or multiplexed accesses: For each access mode address-hold phase duration, please refer to the respective figure (Figure81 to Figure93). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure81 to Figure93), used in asynchronous accesses: For each memory type and access mode data-phase duration, please refer to the respective figure (Figure81 to Figure93). Example: Mode1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 KCK_FMC clock cycles. Note: In synchronous accesses, this value is dont care.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of a write-to-read or read-to write transaction. The programmed bus turnaround delay is inserted between an asynchronous read (in muxed or mode D) or write transaction and any other asynchronous /synchronous read/write from/to a static bank. If a read operation is performed, the bank can be the same or a different one, whereas it must be different in case of write operation to the bank, except in muxed mode or mode D. In some cases, whatever the programmed BUSTRUN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except in muxed mode and mode D. There is a bus turnaround delay of 1 FMC clock cycle between: Two consecutive asynchronous read transfers to the same static memory bank except for modes muxed and D. An asynchronous read to an asynchronous or synchronous write to any static bank or dynamic bank except in modes muxed and D mode. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to the same bank. A synchronous write (burst or single) access and an asynchronous write or read transfer to or from static memory bank (the bank can be the same or a different one in case of a read operation. Two consecutive synchronous read operations (in Burst or Single mode) followed by any synchronous/asynchronous read or write from/to another static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to different static banks. A synchronous write access (in Burst or Single mode) and a synchronous read from the same or a different bank. The bus turnaround delay allows to match the minimum time between consecutive transactions (tEHEL from NEx high to NEx low) and the maximum time required by the memory to free the data bus after a read access (tEHQZ): (BUSTRUN + 1) KCK_FMC period &#8805; tEHELmin and (BUSTRUN + 2)KCK_FMC period &#8805; tEHQZmax if EXTMOD = 0 (BUSTRUN + 2)KCK_FMC period &#8805; max (tEHELmin, tEHQZmax) if EXTMOD = 126. ...
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal) These bits define the period of FMC_CLK clock output signal, expressed in number of KCK_FMC cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is dont care. Note: Refer to Section20.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] Data latency for synchronous memory For synchronous access with read write burst mode enabled these bits define the number of memory clock cycles
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode These bits specify the asynchronous access modes as shown in the timing diagrams. They are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_BCR3_DEF
    \
    \ @brief >FMC_BCR3
    \ Address offset: 0x10
    \ Reset value: 0x000030D2
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit This bit enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AXI bus.
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type These bits define the type of external memory attached to the corresponding memory bank:
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width Defines the external memory device width, valid for all type of memories.
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable This bit enables NOR Flash memory access operations.
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode:
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit This bit defines the polarity of the wait signal from memory used for either in synchronous or asynchronous mode:
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC:
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in synchronous mode.
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable. This bit enables the FMC to program the write timings for asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the extended mode is disabled, the FMC can operate in Mode1 or Mode2 as follows: ** Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP =0x0 or 0x01) ** Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM Page Size These are used for Cellular RAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Other configuration: reserved.
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous Clock Enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in synchronous mode to generate the FMC_CLK continuous clock. If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is dont care. If the synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO Disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.
    $16 constant FMC_NBLSET                     \ [0x16 : 2] NBLSET
  [then]


  [ifdef] FMC_FMC_BTR3_DEF
    \
    \ @brief FMC_BTR3
    \ Address offset: 0x14
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure81 to Figure93), used in SRAMs, ROMs and asynchronous NOR Flash: For each access mode address setup phase duration, please refer to the respective figure (refer to Figure81 to Figure93). Note: In synchronous accesses, this value is dont care. In Muxed mode or Mode D, the minimum value for ADDSET is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure81 to Figure93), used in mode D or multiplexed accesses: For each access mode address-hold phase duration, please refer to the respective figure (Figure81 to Figure93). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure81 to Figure93), used in asynchronous accesses: For each memory type and access mode data-phase duration, please refer to the respective figure (Figure81 to Figure93). Example: Mode1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 KCK_FMC clock cycles. Note: In synchronous accesses, this value is dont care.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of a write-to-read or read-to write transaction. The programmed bus turnaround delay is inserted between an asynchronous read (in muxed or mode D) or write transaction and any other asynchronous /synchronous read/write from/to a static bank. If a read operation is performed, the bank can be the same or a different one, whereas it must be different in case of write operation to the bank, except in muxed mode or mode D. In some cases, whatever the programmed BUSTRUN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except in muxed mode and mode D. There is a bus turnaround delay of 1 FMC clock cycle between: Two consecutive asynchronous read transfers to the same static memory bank except for modes muxed and D. An asynchronous read to an asynchronous or synchronous write to any static bank or dynamic bank except in modes muxed and D mode. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to the same bank. A synchronous write (burst or single) access and an asynchronous write or read transfer to or from static memory bank (the bank can be the same or a different one in case of a read operation. Two consecutive synchronous read operations (in Burst or Single mode) followed by any synchronous/asynchronous read or write from/to another static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to different static banks. A synchronous write access (in Burst or Single mode) and a synchronous read from the same or a different bank. The bus turnaround delay allows to match the minimum time between consecutive transactions (tEHEL from NEx high to NEx low) and the maximum time required by the memory to free the data bus after a read access (tEHQZ): (BUSTRUN + 1) KCK_FMC period &#8805; tEHELmin and (BUSTRUN + 2)KCK_FMC period &#8805; tEHQZmax if EXTMOD = 0 (BUSTRUN + 2)KCK_FMC period &#8805; max (tEHELmin, tEHQZmax) if EXTMOD = 126. ...
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal) These bits define the period of FMC_CLK clock output signal, expressed in number of KCK_FMC cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is dont care. Note: Refer to Section20.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] Data latency for synchronous memory For synchronous access with read write burst mode enabled these bits define the number of memory clock cycles
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode These bits specify the asynchronous access modes as shown in the timing diagrams. They are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_BCR4_DEF
    \
    \ @brief >FMC_BCR4
    \ Address offset: 0x18
    \ Reset value: 0x000030D2
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit This bit enables the memory bank. After reset Bank1 is enabled, all others are disabled. Accessing a disabled bank causes an ERROR on AXI bus.
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit When this bit is set, the address and data values are multiplexed on the data bus, valid only with NOR and PSRAM memories:
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type These bits define the type of external memory attached to the corresponding memory bank:
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width Defines the external memory device width, valid for all type of memories.
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable This bit enables NOR Flash memory access operations.
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit This bit enables/disables synchronous accesses during read operations. It is valid only for synchronous memories operating in Burst mode:
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit This bit defines the polarity of the wait signal from memory used for either in synchronous or asynchronous mode:
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration The NWAIT signal indicates whether the data from the memory are valid or if a wait state must be inserted when accessing the memory in synchronous mode. This configuration bit determines if NWAIT is asserted by the memory one clock cycle before the wait state or during the wait state:
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit This bit indicates whether write operations are enabled/disabled in the bank by the FMC:
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit This bit enables/disables wait-state insertion via the NWAIT signal when accessing the memory in synchronous mode.
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable. This bit enables the FMC to program the write timings for asynchronous accesses inside the FMC_BWTR register, thus resulting in different timings for read and write operations. Note: When the extended mode is disabled, the FMC can operate in Mode1 or Mode2 as follows: ** Mode 1 is the default mode when the SRAM/PSRAM memory type is selected (MTYP =0x0 or 0x01) ** Mode 2 is the default mode when the NOR memory type is selected (MTYP = 0x10).
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers This bit enables/disables the FMC to use the wait signal even during an asynchronous protocol.
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM Page Size These are used for Cellular RAM 1.5 which does not allow burst access to cross the address boundaries between pages. When these bits are configured, the FMC controller splits automatically the burst access when the memory page size is reached (refer to memory datasheet for page size). Other configuration: reserved.
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable For PSRAM (CRAM) operating in Burst mode, the bit enables synchronous accesses during write operations. The enable bit for synchronous read accesses is the BURSTEN bit in the FMC_BCRx register.
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous Clock Enable This bit enables the FMC_CLK clock output to external memory devices. Note: The CCLKEN bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register. Bank 1 must be configured in synchronous mode to generate the FMC_CLK continuous clock. If CCLKEN bit is set, the FMC_CLK clock ratio is specified by CLKDIV value in the FMC_BTR1 register. CLKDIV in FMC_BWTR1 is dont care. If the synchronous mode is used and CCLKEN bit is set, the synchronous memories connected to other banks than Bank 1 are clocked by the same clock (the CLKDIV value in the FMC_BTR2..4 and FMC_BWTR2..4 registers for other banks has no effect.)
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO Disable This bit disables the Write FIFO used by the FMC controller. Note: The WFDIS bit of the FMC_BCR2..4 registers is dont care. It is only enabled through the FMC_BCR1 register.
    $16 constant FMC_NBLSET                     \ [0x16 : 2] NBLSET
  [then]


  [ifdef] FMC_FMC_BTR4_DEF
    \
    \ @brief FMC_BTR4
    \ Address offset: 0x1C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration These bits are written by software to define the duration of the address setup phase (refer to Figure81 to Figure93), used in SRAMs, ROMs and asynchronous NOR Flash: For each access mode address setup phase duration, please refer to the respective figure (refer to Figure81 to Figure93). Note: In synchronous accesses, this value is dont care. In Muxed mode or Mode D, the minimum value for ADDSET is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration These bits are written by software to define the duration of the address hold phase (refer to Figure81 to Figure93), used in mode D or multiplexed accesses: For each access mode address-hold phase duration, please refer to the respective figure (Figure81 to Figure93). Note: In synchronous accesses, this value is not used, the address hold phase is always 1 memory clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration These bits are written by software to define the duration of the data phase (refer to Figure81 to Figure93), used in asynchronous accesses: For each memory type and access mode data-phase duration, please refer to the respective figure (Figure81 to Figure93). Example: Mode1, write access, DATAST=1: Data-phase duration= DATAST+1 = 2 KCK_FMC clock cycles. Note: In synchronous accesses, this value is dont care.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of a write-to-read or read-to write transaction. The programmed bus turnaround delay is inserted between an asynchronous read (in muxed or mode D) or write transaction and any other asynchronous /synchronous read/write from/to a static bank. If a read operation is performed, the bank can be the same or a different one, whereas it must be different in case of write operation to the bank, except in muxed mode or mode D. In some cases, whatever the programmed BUSTRUN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except in muxed mode and mode D. There is a bus turnaround delay of 1 FMC clock cycle between: Two consecutive asynchronous read transfers to the same static memory bank except for modes muxed and D. An asynchronous read to an asynchronous or synchronous write to any static bank or dynamic bank except in modes muxed and D mode. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to the same bank. A synchronous write (burst or single) access and an asynchronous write or read transfer to or from static memory bank (the bank can be the same or a different one in case of a read operation. Two consecutive synchronous read operations (in Burst or Single mode) followed by any synchronous/asynchronous read or write from/to another static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to different static banks. A synchronous write access (in Burst or Single mode) and a synchronous read from the same or a different bank. The bus turnaround delay allows to match the minimum time between consecutive transactions (tEHEL from NEx high to NEx low) and the maximum time required by the memory to free the data bus after a read access (tEHQZ): (BUSTRUN + 1) KCK_FMC period &#8805; tEHELmin and (BUSTRUN + 2)KCK_FMC period &#8805; tEHQZmax if EXTMOD = 0 (BUSTRUN + 2)KCK_FMC period &#8805; max (tEHELmin, tEHQZmax) if EXTMOD = 126. ...
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal) These bits define the period of FMC_CLK clock output signal, expressed in number of KCK_FMC cycles: In asynchronous NOR Flash, SRAM or PSRAM accesses, this value is dont care. Note: Refer to Section20.6.5: Synchronous transactions for FMC_CLK divider ratio formula)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] Data latency for synchronous memory For synchronous access with read write burst mode enabled these bits define the number of memory clock cycles
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode These bits specify the asynchronous access modes as shown in the timing diagrams. They are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_PCSCNTR_DEF
    \
    \ @brief PCSCNTR
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CSCOUNT                    \ [0x00 : 16] Chip select counter
    $10 constant FMC_CNTB1EN                    \ [0x10] Counter Bank 1 enable
    $11 constant FMC_CNTB2EN                    \ [0x11] Counter Bank 2 enable
    $12 constant FMC_CNTB3EN                    \ [0x12] Counter Bank 3 enable
    $13 constant FMC_CNTB4EN                    \ [0x13] Counter Bank 4 enable
  [then]


  [ifdef] FMC_FMC_PCR_DEF
    \
    \ @brief NAND Flash control registers
    \ Address offset: 0x80
    \ Reset value: 0x00000018
    \
    $01 constant FMC_PWAITEN                    \ [0x01] Wait feature enable bit. This bit enables the Wait feature for the NAND Flash memory bank:
    $02 constant FMC_PBKEN                      \ [0x02] NAND Flash memory bank enable bit. This bit enables the memory bank. Accessing a disabled memory bank causes an ERROR on AXI bus
    $03 constant FMC_PTYP                       \ [0x03] Memory type
    $04 constant FMC_PWID                       \ [0x04 : 2] Data bus width. These bits define the external memory device width.
    $06 constant FMC_ECCEN                      \ [0x06] ECC computation logic enable bit
    $09 constant FMC_TCLR                       \ [0x09 : 4] CLE to RE delay. These bits set time from CLE low to RE low in number of KCK_FMC clock cycles. The time is give by the following formula: t_clr = (TCLR + SET + 2) TKCK_FMC where TKCK_FMC is the KCK_FMC clock period Note: Set is MEMSET or ATTSET according to the addressed space.
    $0d constant FMC_TAR                        \ [0x0d : 4] ALE to RE delay. These bits set time from ALE low to RE low in number of KCK_FMC clock cycles. Time is: t_ar = (TAR + SET + 2) TKCK_FMC where TKCK_FMC is the FMC clock period Note: Set is MEMSET or ATTSET according to the addressed space.
    $11 constant FMC_ECCPS                      \ [0x11 : 3] ECC page size. These bits define the page size for the extended ECC:
  [then]


  [ifdef] FMC_FMC_SR_DEF
    \
    \ @brief This register contains information about the FIFO status and interrupt. The FMC features a FIFO that is used when writing to memories to transfer up to 16 words of data.This is used to quickly write to the FIFO and free the AXI bus for transactions to peripherals other than the FMC, while the FMC is draining its FIFO into the memory. One of these register bits indicates the status of the FIFO, for ECC purposes.The ECC is calculated while the data are written to the memory. To read the correct ECC, the software must consequently wait until the FIFO is empty.
    \ Address offset: 0x84
    \ Reset value: 0x00000040
    \
    $00 constant FMC_IRS                        \ [0x00] Interrupt rising edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it will be set.
    $01 constant FMC_ILS                        \ [0x01] Interrupt high-level status The flag is set by hardware and reset by software.
    $02 constant FMC_IFS                        \ [0x02] Interrupt falling edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it will be set.
    $03 constant FMC_IREN                       \ [0x03] Interrupt rising edge detection enable bit
    $04 constant FMC_ILEN                       \ [0x04] Interrupt high-level detection enable bit
    $05 constant FMC_IFEN                       \ [0x05] Interrupt falling edge detection enable bit
    $06 constant FMC_FEMPT                      \ [0x06] FIFO empty. Read-only bit that provides the status of the FIFO
  [then]


  [ifdef] FMC_FMC_PMEM_DEF
    \
    \ @brief The FMC_PMEM read/write register contains the timing information for NAND Flash memory bank. This information is used to access either the common memory space of the NAND Flash for command, address write access and data read/write access.
    \ Address offset: 0x88
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_MEMSET                     \ [0x00 : 8] Common memory x setup time These bits define the number of KCK_FMC (+1) clock cycles to set up the address before the command assertion (NWE, NOE), for NAND Flash read or write access to common memory space:
    $08 constant FMC_MEMWAIT                    \ [0x08 : 8] Common memory wait time These bits define the minimum number of KCK_FMC (+1) clock cycles to assert the command (NWE, NOE), for NAND Flash read or write access to common memory space. The duration of command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of KCK_FMC:
    $10 constant FMC_MEMHOLD                    \ [0x10 : 8] Common memory hold time These bits define the number of KCK_FMC clock cycles for write accesses and KCK_FMC+1 clock cycles for read accesses during which the address is held (and data for write accesses) after the command is de-asserted (NWE, NOE), for NAND Flash read or write access to common memory space:
    $18 constant FMC_MEMHIZ                     \ [0x18 : 8] Common memory x data bus Hi-Z time These bits define the number of KCK_FMC clock cycles during which the data bus is kept Hi-Z after the start of a NAND Flash write access to common memory space. This is only valid for write transactions:
  [then]


  [ifdef] FMC_FMC_PATT_DEF
    \
    \ @brief The FMC_PATT read/write register contains the timing information for NAND Flash memory bank. It is used for 8-bit accesses to the attribute memory space of the NAND Flash for the last address write access if the timing must differ from that of previous accesses (for Ready/Busy management, refer to Section20.8.5: NAND Flash prewait feature).
    \ Address offset: 0x8C
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_ATTSET                     \ [0x00 : 8] Attribute memory setup time These bits define the number of KCK_FMC (+1) clock cycles to set up address before the command assertion (NWE, NOE), for NAND Flash read or write access to attribute memory space:
    $08 constant FMC_ATTWAIT                    \ [0x08 : 8] Attribute memory wait time These bits define the minimum number of x KCK_FMC (+1) clock cycles to assert the command (NWE, NOE), for NAND Flash read or write access to attribute memory space. The duration for command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of KCK_FMC:
    $10 constant FMC_ATTHOLD                    \ [0x10 : 8] Attribute memory hold time These bits define the number of KCK_FMC clock cycles during which the address is held (and data for write access) after the command de-assertion (NWE, NOE), for NAND Flash read or write access to attribute memory space:
    $18 constant FMC_ATTHIZ                     \ [0x18 : 8] Attribute memory data bus Hi-Z time These bits define the number of KCK_FMC clock cycles during which the data bus is kept in Hi-Z after the start of a NAND Flash write access to attribute memory space on socket. Only valid for writ transaction:
  [then]


  [ifdef] FMC_FMC_ECCR_DEF
    \
    \ @brief This register contain the current error correction code value computed by the ECC computation modules of the FMC NAND controller. When the CPU reads/writes the data from a NAND Flash memory page at the correct address (refer to Section20.8.6: Computation of the error correction code (ECC) in NAND Flash memory), the data read/written from/to the NAND Flash memory are processed automatically by the ECC computation module. When X bytes have been read (according to the ECCPS field in the FMC_PCR registers), the CPU must read the computed ECC value from the FMC_ECC registers. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and, to correct it otherwise. The FMC_ECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FMC_ECC                        \ [0x00 : 32] ECC result This field contains the value computed by the ECC computation logic. Table167 describes the contents of these bit fields.
  [then]


  [ifdef] FMC_FMC_BWTR1_DEF
    \
    \ @brief This register contains the control information of each memory bank. It is used for SRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
    \ Address offset: 0x104
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration. These bits are written by software to define the duration of the address setup phase in KCK_FMC cycles (refer to Figure81 to Figure93), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure81 to Figure93), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure81 to Figure93), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses:
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of a write transaction to match the minimum time between consecutive transactions (tEHEL from ENx high to ENx low): (BUSTRUN + 1) KCK_FMC period &#8805; tEHELmin. The programmed bus turnaround delay is inserted between a an asynchronous write transfer and any other asynchronous /synchronous read or write transfer to or from a static bank. If a read operation is performed, the bank can be the same or a different one, whereas it must be different in case of write operation to the bank, except in muxed mode or mode D. In some cases, whatever the programmed BUSTRUN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed mode and mode D. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to the same bank A synchronous write transfer ((in Burst or Single mode) and an asynchronous write or read transfer to or from static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to different static banks. A synchronous write transfer (in Burst or Single mode) and a synchronous read from the same or a different bank. ...
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode. These bits specify the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
  [then]


  [ifdef] FMC_FMC_BWTR2_DEF
    \
    \ @brief This register contains the control information of each memory bank. It is used for SRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
    \ Address offset: 0x10C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration. These bits are written by software to define the duration of the address setup phase in KCK_FMC cycles (refer to Figure81 to Figure93), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure81 to Figure93), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure81 to Figure93), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses:
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of a write transaction to match the minimum time between consecutive transactions (tEHEL from ENx high to ENx low): (BUSTRUN + 1) KCK_FMC period &#8805; tEHELmin. The programmed bus turnaround delay is inserted between a an asynchronous write transfer and any other asynchronous /synchronous read or write transfer to or from a static bank. If a read operation is performed, the bank can be the same or a different one, whereas it must be different in case of write operation to the bank, except in muxed mode or mode D. In some cases, whatever the programmed BUSTRUN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed mode and mode D. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to the same bank A synchronous write transfer ((in Burst or Single mode) and an asynchronous write or read transfer to or from static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to different static banks. A synchronous write transfer (in Burst or Single mode) and a synchronous read from the same or a different bank. ...
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode. These bits specify the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
  [then]


  [ifdef] FMC_FMC_BWTR3_DEF
    \
    \ @brief This register contains the control information of each memory bank. It is used for SRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
    \ Address offset: 0x114
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration. These bits are written by software to define the duration of the address setup phase in KCK_FMC cycles (refer to Figure81 to Figure93), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure81 to Figure93), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure81 to Figure93), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses:
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of a write transaction to match the minimum time between consecutive transactions (tEHEL from ENx high to ENx low): (BUSTRUN + 1) KCK_FMC period &#8805; tEHELmin. The programmed bus turnaround delay is inserted between a an asynchronous write transfer and any other asynchronous /synchronous read or write transfer to or from a static bank. If a read operation is performed, the bank can be the same or a different one, whereas it must be different in case of write operation to the bank, except in muxed mode or mode D. In some cases, whatever the programmed BUSTRUN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed mode and mode D. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to the same bank A synchronous write transfer ((in Burst or Single mode) and an asynchronous write or read transfer to or from static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to different static banks. A synchronous write transfer (in Burst or Single mode) and a synchronous read from the same or a different bank. ...
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode. These bits specify the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
  [then]


  [ifdef] FMC_FMC_BWTR4_DEF
    \
    \ @brief This register contains the control information of each memory bank. It is used for SRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
    \ Address offset: 0x11C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration. These bits are written by software to define the duration of the address setup phase in KCK_FMC cycles (refer to Figure81 to Figure93), used in asynchronous accesses: ... Note: In synchronous accesses, this value is not used, the address setup phase is always 1 Flash clock period duration. In muxed mode, the minimum ADDSET value is 1.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration. These bits are written by software to define the duration of the address hold phase (refer to Figure81 to Figure93), used in asynchronous multiplexed accesses: ... Note: In synchronous NOR Flash accesses, this value is not used, the address hold phase is always 1 Flash clock period duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration. These bits are written by software to define the duration of the data phase (refer to Figure81 to Figure93), used in asynchronous SRAM, PSRAM and NOR Flash memory accesses:
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration These bits are written by software to add a delay at the end of a write transaction to match the minimum time between consecutive transactions (tEHEL from ENx high to ENx low): (BUSTRUN + 1) KCK_FMC period &#8805; tEHELmin. The programmed bus turnaround delay is inserted between a an asynchronous write transfer and any other asynchronous /synchronous read or write transfer to or from a static bank. If a read operation is performed, the bank can be the same or a different one, whereas it must be different in case of write operation to the bank, except in muxed mode or mode D. In some cases, whatever the programmed BUSTRUN values, the bus turnaround delay is fixed as follows: The bus turnaround delay is not inserted between two consecutive asynchronous write transfers to the same static memory bank except for muxed mode and mode D. There is a bus turnaround delay of 2 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to the same bank A synchronous write transfer ((in Burst or Single mode) and an asynchronous write or read transfer to or from static memory bank. There is a bus turnaround delay of 3 FMC clock cycle between: Two consecutive synchronous write operations (in Burst or Single mode) to different static banks. A synchronous write transfer (in Burst or Single mode) and a synchronous read from the same or a different bank. ...
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode. These bits specify the asynchronous access modes as shown in the next timing diagrams.These bits are taken into account only when the EXTMOD bit in the FMC_BCRx register is 1.
  [then]

  \
  \ @brief FMC
  \
  $00 constant FMC_FMC_BCR1             \ FMC_BCR1
  $04 constant FMC_FMC_BTR1             \ This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, 2 registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
  $08 constant FMC_FMC_BCR2             \ FMC_BCR2
  $0C constant FMC_FMC_BTR2             \ FMC_BTR2
  $10 constant FMC_FMC_BCR3             \ >FMC_BCR3
  $14 constant FMC_FMC_BTR3             \ FMC_BTR3
  $18 constant FMC_FMC_BCR4             \ >FMC_BCR4
  $1C constant FMC_FMC_BTR4             \ FMC_BTR4
  $20 constant FMC_PCSCNTR              \ PCSCNTR
  $80 constant FMC_FMC_PCR              \ NAND Flash control registers
  $84 constant FMC_FMC_SR               \ This register contains information about the FIFO status and interrupt. The FMC features a FIFO that is used when writing to memories to transfer up to 16 words of data.This is used to quickly write to the FIFO and free the AXI bus for transactions to peripherals other than the FMC, while the FMC is draining its FIFO into the memory. One of these register bits indicates the status of the FIFO, for ECC purposes.The ECC is calculated while the data are written to the memory. To read the correct ECC, the software must consequently wait until the FIFO is empty.
  $88 constant FMC_FMC_PMEM             \ The FMC_PMEM read/write register contains the timing information for NAND Flash memory bank. This information is used to access either the common memory space of the NAND Flash for command, address write access and data read/write access.
  $8C constant FMC_FMC_PATT             \ The FMC_PATT read/write register contains the timing information for NAND Flash memory bank. It is used for 8-bit accesses to the attribute memory space of the NAND Flash for the last address write access if the timing must differ from that of previous accesses (for Ready/Busy management, refer to Section20.8.5: NAND Flash prewait feature).
  $94 constant FMC_FMC_ECCR             \ This register contain the current error correction code value computed by the ECC computation modules of the FMC NAND controller. When the CPU reads/writes the data from a NAND Flash memory page at the correct address (refer to Section20.8.6: Computation of the error correction code (ECC) in NAND Flash memory), the data read/written from/to the NAND Flash memory are processed automatically by the ECC computation module. When X bytes have been read (according to the ECCPS field in the FMC_PCR registers), the CPU must read the computed ECC value from the FMC_ECC registers. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and, to correct it otherwise. The FMC_ECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
  $104 constant FMC_FMC_BWTR1           \ This register contains the control information of each memory bank. It is used for SRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
  $10C constant FMC_FMC_BWTR2           \ This register contains the control information of each memory bank. It is used for SRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
  $114 constant FMC_FMC_BWTR3           \ This register contains the control information of each memory bank. It is used for SRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
  $11C constant FMC_FMC_BWTR4           \ This register contains the control information of each memory bank. It is used for SRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.

: FMC_DEF ; [then]
