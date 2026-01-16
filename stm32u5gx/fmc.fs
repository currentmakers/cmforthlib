\
\ @file fmc.fs
\ @brief FMC
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

$00000001 constant FMC_BCR1_MBKEN                                   \ Memory bank enable bit
$00000002 constant FMC_BCR1_MUXEN                                   \ Address/data multiplexing enable bit
$0000000c constant FMC_BCR1_MTYP                                    \ Memory type
$00000030 constant FMC_BCR1_MWID                                    \ Memory data bus width
$00000040 constant FMC_BCR1_FACCEN                                  \ Flash access enable
$00000100 constant FMC_BCR1_BURSTEN                                 \ Burst enable bit
$00000200 constant FMC_BCR1_WAITPOL                                 \ Wait signal polarity bit
$00000800 constant FMC_BCR1_WAITCFG                                 \ Wait timing configuration
$00001000 constant FMC_BCR1_WREN                                    \ Write enable bit
$00002000 constant FMC_BCR1_WAITEN                                  \ Wait enable bit
$00004000 constant FMC_BCR1_EXTMOD                                  \ Extended mode enable
$00008000 constant FMC_BCR1_ASYNCWAIT                               \ Wait signal during asynchronous transfers
$00070000 constant FMC_BCR1_CPSIZE                                  \ CRAM Page Size
$00080000 constant FMC_BCR1_CBURSTRW                                \ Write burst enable
$00100000 constant FMC_BCR1_CCLKEN                                  \ Continuous clock enable
$00200000 constant FMC_BCR1_WFDIS                                   \ Write FIFO disable
$00c00000 constant FMC_BCR1_NBLSET                                  \ Byte lane (NBL) setup
$80000000 constant FMC_BCR1_FMCEN                                   \ FMC controller enable


\
\ @brief SRAM/NOR-Flash chip-select timing register for bank 1
\ Address offset: 0x04
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BTR1_ADDSET                                  \ Address setup phase duration
$000000f0 constant FMC_BTR1_ADDHLD                                  \ Address-hold phase duration
$0000ff00 constant FMC_BTR1_DATAST                                  \ Data-phase duration
$000f0000 constant FMC_BTR1_BUSTURN                                 \ Bus turnaround phase duration
$00f00000 constant FMC_BTR1_CLKDIV                                  \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC_BTR1_DATLAT                                  \ Data latency for synchronous memory
$30000000 constant FMC_BTR1_ACCMOD                                  \ Access mode
$c0000000 constant FMC_BTR1_DATAHLD                                 \ Data hold phase duration


\
\ @brief SRAM/NOR-Flash chip-select control register for bank 2
\ Address offset: 0x08
\ Reset value: 0x000030D2
\

$00000001 constant FMC_BCR2_MBKEN                                   \ Memory bank enable bit
$00000002 constant FMC_BCR2_MUXEN                                   \ Address/data multiplexing enable bit
$0000000c constant FMC_BCR2_MTYP                                    \ Memory type
$00000030 constant FMC_BCR2_MWID                                    \ Memory data bus width
$00000040 constant FMC_BCR2_FACCEN                                  \ Flash access enable
$00000100 constant FMC_BCR2_BURSTEN                                 \ Burst enable bit
$00000200 constant FMC_BCR2_WAITPOL                                 \ Wait signal polarity bit
$00000800 constant FMC_BCR2_WAITCFG                                 \ Wait timing configuration
$00001000 constant FMC_BCR2_WREN                                    \ Write enable bit
$00002000 constant FMC_BCR2_WAITEN                                  \ Wait enable bit
$00004000 constant FMC_BCR2_EXTMOD                                  \ Extended mode enable
$00008000 constant FMC_BCR2_ASYNCWAIT                               \ Wait signal during asynchronous transfers
$00070000 constant FMC_BCR2_CPSIZE                                  \ CRAM Page Size
$00080000 constant FMC_BCR2_CBURSTRW                                \ Write burst enable
$00100000 constant FMC_BCR2_CCLKEN                                  \ Continuous clock enable
$00200000 constant FMC_BCR2_WFDIS                                   \ Write FIFO disable
$00c00000 constant FMC_BCR2_NBLSET                                  \ Byte lane (NBL) setup
$80000000 constant FMC_BCR2_FMCEN                                   \ FMC controller enable


\
\ @brief SRAM/NOR-Flash chip-select timing register for bank 2
\ Address offset: 0x0C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BTR2_ADDSET                                  \ Address setup phase duration
$000000f0 constant FMC_BTR2_ADDHLD                                  \ Address-hold phase duration
$0000ff00 constant FMC_BTR2_DATAST                                  \ Data-phase duration
$000f0000 constant FMC_BTR2_BUSTURN                                 \ Bus turnaround phase duration
$00f00000 constant FMC_BTR2_CLKDIV                                  \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC_BTR2_DATLAT                                  \ Data latency for synchronous memory
$30000000 constant FMC_BTR2_ACCMOD                                  \ Access mode
$c0000000 constant FMC_BTR2_DATAHLD                                 \ Data hold phase duration


\
\ @brief SRAM/NOR-Flash chip-select control register for bank 3
\ Address offset: 0x10
\ Reset value: 0x000030D2
\

$00000001 constant FMC_BCR3_MBKEN                                   \ Memory bank enable bit
$00000002 constant FMC_BCR3_MUXEN                                   \ Address/data multiplexing enable bit
$0000000c constant FMC_BCR3_MTYP                                    \ Memory type
$00000030 constant FMC_BCR3_MWID                                    \ Memory data bus width
$00000040 constant FMC_BCR3_FACCEN                                  \ Flash access enable
$00000100 constant FMC_BCR3_BURSTEN                                 \ Burst enable bit
$00000200 constant FMC_BCR3_WAITPOL                                 \ Wait signal polarity bit
$00000800 constant FMC_BCR3_WAITCFG                                 \ Wait timing configuration
$00001000 constant FMC_BCR3_WREN                                    \ Write enable bit
$00002000 constant FMC_BCR3_WAITEN                                  \ Wait enable bit
$00004000 constant FMC_BCR3_EXTMOD                                  \ Extended mode enable
$00008000 constant FMC_BCR3_ASYNCWAIT                               \ Wait signal during asynchronous transfers
$00070000 constant FMC_BCR3_CPSIZE                                  \ CRAM Page Size
$00080000 constant FMC_BCR3_CBURSTRW                                \ Write burst enable
$00100000 constant FMC_BCR3_CCLKEN                                  \ Continuous clock enable
$00200000 constant FMC_BCR3_WFDIS                                   \ Write FIFO disable
$00c00000 constant FMC_BCR3_NBLSET                                  \ Byte lane (NBL) setup
$80000000 constant FMC_BCR3_FMCEN                                   \ FMC controller enable


\
\ @brief SRAM/NOR-Flash chip-select timing register for bank 3
\ Address offset: 0x14
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BTR3_ADDSET                                  \ Address setup phase duration
$000000f0 constant FMC_BTR3_ADDHLD                                  \ Address-hold phase duration
$0000ff00 constant FMC_BTR3_DATAST                                  \ Data-phase duration
$000f0000 constant FMC_BTR3_BUSTURN                                 \ Bus turnaround phase duration
$00f00000 constant FMC_BTR3_CLKDIV                                  \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC_BTR3_DATLAT                                  \ Data latency for synchronous memory
$30000000 constant FMC_BTR3_ACCMOD                                  \ Access mode
$c0000000 constant FMC_BTR3_DATAHLD                                 \ Data hold phase duration


\
\ @brief SRAM/NOR-Flash chip-select control register for bank 4
\ Address offset: 0x18
\ Reset value: 0x000030D2
\

$00000001 constant FMC_BCR4_MBKEN                                   \ Memory bank enable bit
$00000002 constant FMC_BCR4_MUXEN                                   \ Address/data multiplexing enable bit
$0000000c constant FMC_BCR4_MTYP                                    \ Memory type
$00000030 constant FMC_BCR4_MWID                                    \ Memory data bus width
$00000040 constant FMC_BCR4_FACCEN                                  \ Flash access enable
$00000100 constant FMC_BCR4_BURSTEN                                 \ Burst enable bit
$00000200 constant FMC_BCR4_WAITPOL                                 \ Wait signal polarity bit
$00000800 constant FMC_BCR4_WAITCFG                                 \ Wait timing configuration
$00001000 constant FMC_BCR4_WREN                                    \ Write enable bit
$00002000 constant FMC_BCR4_WAITEN                                  \ Wait enable bit
$00004000 constant FMC_BCR4_EXTMOD                                  \ Extended mode enable
$00008000 constant FMC_BCR4_ASYNCWAIT                               \ Wait signal during asynchronous transfers
$00070000 constant FMC_BCR4_CPSIZE                                  \ CRAM Page Size
$00080000 constant FMC_BCR4_CBURSTRW                                \ Write burst enable
$00100000 constant FMC_BCR4_CCLKEN                                  \ Continuous clock enable
$00200000 constant FMC_BCR4_WFDIS                                   \ Write FIFO disable
$00c00000 constant FMC_BCR4_NBLSET                                  \ Byte lane (NBL) setup
$80000000 constant FMC_BCR4_FMCEN                                   \ FMC controller enable


\
\ @brief SRAM/NOR-Flash chip-select timing register for bank 4
\ Address offset: 0x1C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BTR4_ADDSET                                  \ Address setup phase duration
$000000f0 constant FMC_BTR4_ADDHLD                                  \ Address-hold phase duration
$0000ff00 constant FMC_BTR4_DATAST                                  \ Data-phase duration
$000f0000 constant FMC_BTR4_BUSTURN                                 \ Bus turnaround phase duration
$00f00000 constant FMC_BTR4_CLKDIV                                  \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC_BTR4_DATLAT                                  \ Data latency for synchronous memory
$30000000 constant FMC_BTR4_ACCMOD                                  \ Access mode
$c0000000 constant FMC_BTR4_DATAHLD                                 \ Data hold phase duration


\
\ @brief PSRAM chip select counter register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant FMC_PCSCNTR_CSCOUNT                              \ Chip select counter
$00010000 constant FMC_PCSCNTR_CNTB1EN                              \ Counter Bank 1 enable
$00020000 constant FMC_PCSCNTR_CNTB2EN                              \ Counter Bank 2 enable
$00040000 constant FMC_PCSCNTR_CNTB3EN                              \ Counter Bank 3 enable
$00080000 constant FMC_PCSCNTR_CNTB4EN                              \ Counter Bank 4 enable


\
\ @brief NAND Flash control registers
\ Address offset: 0x80
\ Reset value: 0x00000018
\

$00000002 constant FMC_PCR_PWAITEN                                  \ Wait feature enable bit
$00000004 constant FMC_PCR_PBKEN                                    \ NAND Flash memory bank enable bit
$00000008 constant FMC_PCR_PTYP                                     \ Memory type
$00000030 constant FMC_PCR_PWID                                     \ Data bus width
$00000040 constant FMC_PCR_ECCEN                                    \ ECC computation logic enable bit
$00001e00 constant FMC_PCR_TCLR                                     \ CLE to RE delay
$0000e000 constant FMC_PCR_TAR                                      \ ALE to RE delay
$000e0000 constant FMC_PCR_ECCPS                                    \ ECC page size


\
\ @brief status and interrupt register
\ Address offset: 0x84
\ Reset value: 0x00000040
\

$00000001 constant FMC_SR_IRS                                       \ Interrupt rising edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it will be set.
$00000002 constant FMC_SR_ILS                                       \ Interrupt high-level status The flag is set by hardware and reset by software.
$00000004 constant FMC_SR_IFS                                       \ Interrupt falling edge status The flag is set by hardware and reset by software. Note: If this bit is written by software to 1 it will be set.
$00000008 constant FMC_SR_IREN                                      \ Interrupt rising edge detection enable bit
$00000010 constant FMC_SR_ILEN                                      \ Interrupt high-level detection enable bit
$00000020 constant FMC_SR_IFEN                                      \ Interrupt falling edge detection enable bit
$00000040 constant FMC_SR_FEMPT                                     \ FIFO empty. Read-only bit that provides the status of the FIFO


\
\ @brief Common memory space timing register
\ Address offset: 0x88
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FMC_PMEM_MEMSET                                  \ Common memory x setup time These bits define the number of KCK_FMC (+1) clock cycles to set up the address before the command assertion (NWE, NOE), for NAND Flash read or write access to common memory space:
$0000ff00 constant FMC_PMEM_MEMWAIT                                 \ Common memory wait time These bits define the minimum number of KCK_FMC (+1) clock cycles to assert the command (NWE, NOE), for NAND Flash read or write access to common memory space. The duration of command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of KCK_FMC:
$00ff0000 constant FMC_PMEM_MEMHOLD                                 \ Common memory hold time These bits define the number of KCK_FMC clock cycles for write accesses and KCK_FMC+1 clock cycles for read accesses during which the address is held (and data for write accesses) after the command is de-asserted (NWE, NOE), for NAND Flash read or write access to common memory space:
$ff000000 constant FMC_PMEM_MEMHIZ                                  \ Common memory x data bus Hi-Z time These bits define the number of KCK_FMC clock cycles during which the data bus is kept Hi-Z after the start of a NAND Flash write access to common memory space. This is only valid for write transactions:


\
\ @brief The FMC_PATT read/write register contains the timing information for NAND Flash memory bank. It is used for 8-bit accesses to the attribute memory space of the NAND Flash for the last address write access if the timing must differ from that of previous accesses (for Ready/Busy management, refer to Section20.8.5: NAND Flash prewait feature).
\ Address offset: 0x8C
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FMC_PATT_ATTSET                                  \ Attribute memory setup time These bits define the number of KCK_FMC (+1) clock cycles to set up address before the command assertion (NWE, NOE), for NAND Flash read or write access to attribute memory space:
$0000ff00 constant FMC_PATT_ATTWAIT                                 \ Attribute memory wait time These bits define the minimum number of x KCK_FMC (+1) clock cycles to assert the command (NWE, NOE), for NAND Flash read or write access to attribute memory space. The duration for command assertion is extended if the wait signal (NWAIT) is active (low) at the end of the programmed value of KCK_FMC:
$00ff0000 constant FMC_PATT_ATTHOLD                                 \ Attribute memory hold time These bits define the number of KCK_FMC clock cycles during which the address is held (and data for write access) after the command de-assertion (NWE, NOE), for NAND Flash read or write access to attribute memory space:
$ff000000 constant FMC_PATT_ATTHIZ                                  \ Attribute memory data bus Hi-Z time These bits define the number of KCK_FMC clock cycles during which the data bus is kept in Hi-Z after the start of a NAND Flash write access to attribute memory space on socket. Only valid for writ transaction:


\
\ @brief This register contain the current error correction code value computed by the ECC computation modules of the FMC NAND controller. When the CPU reads/writes the data from a NAND Flash memory page at the correct address (refer to Section20.8.6: Computation of the error correction code (ECC) in NAND Flash memory), the data read/written from/to the NAND Flash memory are processed automatically by the ECC computation module. When X bytes have been read (according to the ECCPS field in the FMC_PCR registers), the CPU must read the computed ECC value from the FMC_ECC registers. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and, to correct it otherwise. The FMC_ECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant FMC_ECCR_ECC                                     \ ECC result This field contains the value computed by the ECC computation logic. Table167 describes the contents of these bit fields.


\
\ @brief SRAM/NOR-Flash write timing registers 1
\ Address offset: 0x104
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BWTR1_ADDSET                                 \ Address setup phase duration
$000000f0 constant FMC_BWTR1_ADDHLD                                 \ Address-hold phase duration
$0000ff00 constant FMC_BWTR1_DATAST                                 \ Data-phase duration
$000f0000 constant FMC_BWTR1_BUSTURN                                \ Bus turnaround phase duration
$30000000 constant FMC_BWTR1_ACCMOD                                 \ Access mode
$c0000000 constant FMC_BWTR1_DATAHLD                                \ Data hold phase duration


\
\ @brief SRAM/NOR-Flash write timing registers 2
\ Address offset: 0x10C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BWTR2_ADDSET                                 \ Address setup phase duration
$000000f0 constant FMC_BWTR2_ADDHLD                                 \ Address-hold phase duration
$0000ff00 constant FMC_BWTR2_DATAST                                 \ Data-phase duration
$000f0000 constant FMC_BWTR2_BUSTURN                                \ Bus turnaround phase duration
$30000000 constant FMC_BWTR2_ACCMOD                                 \ Access mode
$c0000000 constant FMC_BWTR2_DATAHLD                                \ Data hold phase duration


\
\ @brief SRAM/NOR-Flash write timing registers 3
\ Address offset: 0x114
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BWTR3_ADDSET                                 \ Address setup phase duration
$000000f0 constant FMC_BWTR3_ADDHLD                                 \ Address-hold phase duration
$0000ff00 constant FMC_BWTR3_DATAST                                 \ Data-phase duration
$000f0000 constant FMC_BWTR3_BUSTURN                                \ Bus turnaround phase duration
$30000000 constant FMC_BWTR3_ACCMOD                                 \ Access mode
$c0000000 constant FMC_BWTR3_DATAHLD                                \ Data hold phase duration


\
\ @brief SRAM/NOR-Flash write timing registers 4
\ Address offset: 0x11C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BWTR4_ADDSET                                 \ Address setup phase duration
$000000f0 constant FMC_BWTR4_ADDHLD                                 \ Address-hold phase duration
$0000ff00 constant FMC_BWTR4_DATAST                                 \ Data-phase duration
$000f0000 constant FMC_BWTR4_BUSTURN                                \ Bus turnaround phase duration
$30000000 constant FMC_BWTR4_ACCMOD                                 \ Access mode
$c0000000 constant FMC_BWTR4_DATAHLD                                \ Data hold phase duration


\
\ @brief FMC
\
$420d0400 constant FMC_BCR1       \ offset: 0x00 : SRAM/NOR-Flash chip-select control register for bank 1
$420d0404 constant FMC_BTR1       \ offset: 0x04 : SRAM/NOR-Flash chip-select timing register for bank 1
$420d0408 constant FMC_BCR2       \ offset: 0x08 : SRAM/NOR-Flash chip-select control register for bank 2
$420d040c constant FMC_BTR2       \ offset: 0x0C : SRAM/NOR-Flash chip-select timing register for bank 2
$420d0410 constant FMC_BCR3       \ offset: 0x10 : SRAM/NOR-Flash chip-select control register for bank 3
$420d0414 constant FMC_BTR3       \ offset: 0x14 : SRAM/NOR-Flash chip-select timing register for bank 3
$420d0418 constant FMC_BCR4       \ offset: 0x18 : SRAM/NOR-Flash chip-select control register for bank 4
$420d041c constant FMC_BTR4       \ offset: 0x1C : SRAM/NOR-Flash chip-select timing register for bank 4
$420d0420 constant FMC_PCSCNTR    \ offset: 0x20 : PSRAM chip select counter register
$420d0480 constant FMC_PCR        \ offset: 0x80 : NAND Flash control registers
$420d0484 constant FMC_SR         \ offset: 0x84 : status and interrupt register
$420d0488 constant FMC_PMEM       \ offset: 0x88 : Common memory space timing register
$420d048c constant FMC_PATT       \ offset: 0x8C : The FMC_PATT read/write register contains the timing information for NAND Flash memory bank. It is used for 8-bit accesses to the attribute memory space of the NAND Flash for the last address write access if the timing must differ from that of previous accesses (for Ready/Busy management, refer to Section20.8.5: NAND Flash prewait feature).
$420d0494 constant FMC_ECCR       \ offset: 0x94 : This register contain the current error correction code value computed by the ECC computation modules of the FMC NAND controller. When the CPU reads/writes the data from a NAND Flash memory page at the correct address (refer to Section20.8.6: Computation of the error correction code (ECC) in NAND Flash memory), the data read/written from/to the NAND Flash memory are processed automatically by the ECC computation module. When X bytes have been read (according to the ECCPS field in the FMC_PCR registers), the CPU must read the computed ECC value from the FMC_ECC registers. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and, to correct it otherwise. The FMC_ECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
$420d0504 constant FMC_BWTR1      \ offset: 0x104 : SRAM/NOR-Flash write timing registers 1
$420d050c constant FMC_BWTR2      \ offset: 0x10C : SRAM/NOR-Flash write timing registers 2
$420d0514 constant FMC_BWTR3      \ offset: 0x114 : SRAM/NOR-Flash write timing registers 3
$420d051c constant FMC_BWTR4      \ offset: 0x11C : SRAM/NOR-Flash write timing registers 4

