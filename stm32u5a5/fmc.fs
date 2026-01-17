\
\ @file fmc.fs
\ @brief FMC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMC_DEF

  [ifdef] FMC_BCR1_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register for bank 1
    \ Address offset: 0x00
    \ Reset value: 0x000030DB
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM Page Size
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable
  [then]


  [ifdef] FMC_BTR1_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register for bank 1
    \ Address offset: 0x04
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] Data latency for synchronous memory
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_BCR2_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register for bank 2
    \ Address offset: 0x08
    \ Reset value: 0x000030D2
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM Page Size
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable
  [then]


  [ifdef] FMC_BTR2_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register for bank 2
    \ Address offset: 0x0C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] Data latency for synchronous memory
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_BCR3_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register for bank 3
    \ Address offset: 0x10
    \ Reset value: 0x000030D2
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM Page Size
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable
  [then]


  [ifdef] FMC_BTR3_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register for bank 3
    \ Address offset: 0x14
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] Data latency for synchronous memory
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_BCR4_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register for bank 4
    \ Address offset: 0x18
    \ Reset value: 0x000030D2
    \
    $00 constant FMC_MBKEN                      \ [0x00] Memory bank enable bit
    $01 constant FMC_MUXEN                      \ [0x01] Address/data multiplexing enable bit
    $02 constant FMC_MTYP                       \ [0x02 : 2] Memory type
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width
    $06 constant FMC_FACCEN                     \ [0x06] Flash access enable
    $08 constant FMC_BURSTEN                    \ [0x08] Burst enable bit
    $09 constant FMC_WAITPOL                    \ [0x09] Wait signal polarity bit
    $0b constant FMC_WAITCFG                    \ [0x0b] Wait timing configuration
    $0c constant FMC_WREN                       \ [0x0c] Write enable bit
    $0d constant FMC_WAITEN                     \ [0x0d] Wait enable bit
    $0e constant FMC_EXTMOD                     \ [0x0e] Extended mode enable
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM Page Size
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable
  [then]


  [ifdef] FMC_BTR4_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register for bank 4
    \ Address offset: 0x1C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] Data latency for synchronous memory
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_PCSCNTR_DEF
    \
    \ @brief PSRAM chip select counter register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CSCOUNT                    \ [0x00 : 16] Chip select counter
    $10 constant FMC_CNTB1EN                    \ [0x10] Counter Bank 1 enable
    $11 constant FMC_CNTB2EN                    \ [0x11] Counter Bank 2 enable
    $12 constant FMC_CNTB3EN                    \ [0x12] Counter Bank 3 enable
    $13 constant FMC_CNTB4EN                    \ [0x13] Counter Bank 4 enable
  [then]


  [ifdef] FMC_PCR_DEF
    \
    \ @brief NAND Flash control registers
    \ Address offset: 0x80
    \ Reset value: 0x00000018
    \
    $01 constant FMC_PWAITEN                    \ [0x01] Wait feature enable bit
    $02 constant FMC_PBKEN                      \ [0x02] NAND Flash memory bank enable bit
    $03 constant FMC_PTYP                       \ [0x03] Memory type
    $04 constant FMC_PWID                       \ [0x04 : 2] Data bus width
    $06 constant FMC_ECCEN                      \ [0x06] ECC computation logic enable bit
    $09 constant FMC_TCLR                       \ [0x09 : 4] CLE to RE delay
    $0d constant FMC_TAR                        \ [0x0d : 3] ALE to RE delay
    $11 constant FMC_ECCPS                      \ [0x11 : 3] ECC page size
  [then]


  [ifdef] FMC_SR_DEF
    \
    \ @brief status and interrupt register
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


  [ifdef] FMC_PMEM_DEF
    \
    \ @brief Common memory space timing register
    \ Address offset: 0x88
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_MEMSET                     \ [0x00 : 8] Common memory x setup time These bits define the number of KCK_FMC (+1) clock cycles to set up the address before the command assertion (NWE, NOE), for NAND Flash read or write access to common memory space:
    $08 constant FMC_MEMWAIT                    \ [0x08 : 8] Common memory wait time These bits define the minimum number of KCK_FMC (+1) clock cycles to assert the command (NWE, NOE), for NAND Flash read or write access to common memory space. The duration of command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of KCK_FMC:
    $10 constant FMC_MEMHOLD                    \ [0x10 : 8] Common memory hold time These bits define the number of KCK_FMC clock cycles for write accesses and KCK_FMC+1 clock cycles for read accesses during which the address is held (and data for write accesses) after the command is de-asserted (NWE, NOE), for NAND Flash read or write access to common memory space:
    $18 constant FMC_MEMHIZ                     \ [0x18 : 8] Common memory x data bus Hi-Z time These bits define the number of KCK_FMC clock cycles during which the data bus is kept Hi-Z after the start of a NAND Flash write access to common memory space. This is only valid for write transactions:
  [then]


  [ifdef] FMC_PATT_DEF
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


  [ifdef] FMC_ECCR_DEF
    \
    \ @brief This register contain the current error correction code value computed by the ECC computation modules of the FMC NAND controller. When the CPU reads/writes the data from a NAND Flash memory page at the correct address (refer to Section20.8.6: Computation of the error correction code (ECC) in NAND Flash memory), the data read/written from/to the NAND Flash memory are processed automatically by the ECC computation module. When X bytes have been read (according to the ECCPS field in the FMC_PCR registers), the CPU must read the computed ECC value from the FMC_ECC registers. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and, to correct it otherwise. The FMC_ECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FMC_ECC                        \ [0x00 : 32] ECC result This field contains the value computed by the ECC computation logic. Table167 describes the contents of these bit fields.
  [then]


  [ifdef] FMC_BWTR1_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 1
    \ Address offset: 0x104
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_BWTR2_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 2
    \ Address offset: 0x10C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_BWTR3_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 3
    \ Address offset: 0x114
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_BWTR4_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 4
    \ Address offset: 0x11C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]

  \
  \ @brief FMC
  \
  $00 constant FMC_BCR1                 \ SRAM/NOR-Flash chip-select control register for bank 1
  $04 constant FMC_BTR1                 \ SRAM/NOR-Flash chip-select timing register for bank 1
  $08 constant FMC_BCR2                 \ SRAM/NOR-Flash chip-select control register for bank 2
  $0C constant FMC_BTR2                 \ SRAM/NOR-Flash chip-select timing register for bank 2
  $10 constant FMC_BCR3                 \ SRAM/NOR-Flash chip-select control register for bank 3
  $14 constant FMC_BTR3                 \ SRAM/NOR-Flash chip-select timing register for bank 3
  $18 constant FMC_BCR4                 \ SRAM/NOR-Flash chip-select control register for bank 4
  $1C constant FMC_BTR4                 \ SRAM/NOR-Flash chip-select timing register for bank 4
  $20 constant FMC_PCSCNTR              \ PSRAM chip select counter register
  $80 constant FMC_PCR                  \ NAND Flash control registers
  $84 constant FMC_SR                   \ status and interrupt register
  $88 constant FMC_PMEM                 \ Common memory space timing register
  $8C constant FMC_PATT                 \ The FMC_PATT read/write register contains the timing information for NAND Flash memory bank. It is used for 8-bit accesses to the attribute memory space of the NAND Flash for the last address write access if the timing must differ from that of previous accesses (for Ready/Busy management, refer to Section20.8.5: NAND Flash prewait feature).
  $94 constant FMC_ECCR                 \ This register contain the current error correction code value computed by the ECC computation modules of the FMC NAND controller. When the CPU reads/writes the data from a NAND Flash memory page at the correct address (refer to Section20.8.6: Computation of the error correction code (ECC) in NAND Flash memory), the data read/written from/to the NAND Flash memory are processed automatically by the ECC computation module. When X bytes have been read (according to the ECCPS field in the FMC_PCR registers), the CPU must read the computed ECC value from the FMC_ECC registers. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and, to correct it otherwise. The FMC_ECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
  $104 constant FMC_BWTR1               \ SRAM/NOR-Flash write timing registers 1
  $10C constant FMC_BWTR2               \ SRAM/NOR-Flash write timing registers 2
  $114 constant FMC_BWTR3               \ SRAM/NOR-Flash write timing registers 3
  $11C constant FMC_BWTR4               \ SRAM/NOR-Flash write timing registers 4

: FMC_DEF ; [then]
