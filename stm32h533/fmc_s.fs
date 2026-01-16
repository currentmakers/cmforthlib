\
\ @file fmc_s.fs
\ @brief FMC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SRAM/NOR-flash chip-select control register for bank 1
\ Address offset: 0x00
\ Reset value: 0x000030DB
\

$00000001 constant FMC_S_FMC_BCR1_MBKEN                             \ Memory bank enable bit
$00000002 constant FMC_S_FMC_BCR1_MUXEN                             \ Address/data multiplexing enable bit
$0000000c constant FMC_S_FMC_BCR1_MTYP                              \ Memory type
$00000030 constant FMC_S_FMC_BCR1_MWID                              \ Memory data bus width
$00000040 constant FMC_S_FMC_BCR1_FACCEN                            \ Flash access enable
$00000100 constant FMC_S_FMC_BCR1_BURSTEN                           \ Burst enable bit
$00000200 constant FMC_S_FMC_BCR1_WAITPOL                           \ Wait signal polarity bit
$00000800 constant FMC_S_FMC_BCR1_WAITCFG                           \ Wait timing configuration
$00001000 constant FMC_S_FMC_BCR1_WREN                              \ Write enable bit
$00002000 constant FMC_S_FMC_BCR1_WAITEN                            \ Wait enable bit
$00004000 constant FMC_S_FMC_BCR1_EXTMOD                            \ Extended mode enable
$00008000 constant FMC_S_FMC_BCR1_ASYNCWAIT                         \ Wait signal during asynchronous transfers
$00070000 constant FMC_S_FMC_BCR1_CPSIZE                            \ CRAM page size
$00080000 constant FMC_S_FMC_BCR1_CBURSTRW                          \ Write burst enable
$00100000 constant FMC_S_FMC_BCR1_CCLKEN                            \ Continuous clock enable
$00200000 constant FMC_S_FMC_BCR1_WFDIS                             \ Write FIFO disable
$00c00000 constant FMC_S_FMC_BCR1_NBLSET                            \ Byte lane (NBL) setup
$80000000 constant FMC_S_FMC_BCR1_FMCEN                             \ FMC controller enable


\
\ @brief SRAM/NOR-flash chip-select timing register for bank 1
\ Address offset: 0x04
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_BTR1_ADDSET                            \ Address setup phase duration
$000000f0 constant FMC_S_FMC_BTR1_ADDHLD                            \ Address-hold phase duration
$0000ff00 constant FMC_S_FMC_BTR1_DATAST                            \ Data-phase duration
$000f0000 constant FMC_S_FMC_BTR1_BUSTURN                           \ Bus turnaround phase duration
$00f00000 constant FMC_S_FMC_BTR1_CLKDIV                            \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC_S_FMC_BTR1_DATLAT                            \ (see note below bit descriptions): Data latency for synchronous memory
$30000000 constant FMC_S_FMC_BTR1_ACCMOD                            \ Access mode
$c0000000 constant FMC_S_FMC_BTR1_DATAHLD                           \ Data hold phase duration


\
\ @brief SRAM/NOR-flash chip-select control register for bank 2
\ Address offset: 0x08
\ Reset value: 0x000030D2
\

$00000001 constant FMC_S_FMC_BCR2_MBKEN                             \ Memory bank enable bit
$00000002 constant FMC_S_FMC_BCR2_MUXEN                             \ Address/data multiplexing enable bit
$0000000c constant FMC_S_FMC_BCR2_MTYP                              \ Memory type
$00000030 constant FMC_S_FMC_BCR2_MWID                              \ Memory data bus width
$00000040 constant FMC_S_FMC_BCR2_FACCEN                            \ Flash access enable
$00000100 constant FMC_S_FMC_BCR2_BURSTEN                           \ Burst enable bit
$00000200 constant FMC_S_FMC_BCR2_WAITPOL                           \ Wait signal polarity bit
$00000800 constant FMC_S_FMC_BCR2_WAITCFG                           \ Wait timing configuration
$00001000 constant FMC_S_FMC_BCR2_WREN                              \ Write enable bit
$00002000 constant FMC_S_FMC_BCR2_WAITEN                            \ Wait enable bit
$00004000 constant FMC_S_FMC_BCR2_EXTMOD                            \ Extended mode enable
$00008000 constant FMC_S_FMC_BCR2_ASYNCWAIT                         \ Wait signal during asynchronous transfers
$00070000 constant FMC_S_FMC_BCR2_CPSIZE                            \ CRAM page size
$00080000 constant FMC_S_FMC_BCR2_CBURSTRW                          \ Write burst enable
$00100000 constant FMC_S_FMC_BCR2_CCLKEN                            \ Continuous clock enable
$00200000 constant FMC_S_FMC_BCR2_WFDIS                             \ Write FIFO disable
$00c00000 constant FMC_S_FMC_BCR2_NBLSET                            \ Byte lane (NBL) setup
$80000000 constant FMC_S_FMC_BCR2_FMCEN                             \ FMC controller enable


\
\ @brief SRAM/NOR-flash chip-select timing register for bank 2
\ Address offset: 0x0C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_BTR2_ADDSET                            \ Address setup phase duration
$000000f0 constant FMC_S_FMC_BTR2_ADDHLD                            \ Address-hold phase duration
$0000ff00 constant FMC_S_FMC_BTR2_DATAST                            \ Data-phase duration
$000f0000 constant FMC_S_FMC_BTR2_BUSTURN                           \ Bus turnaround phase duration
$00f00000 constant FMC_S_FMC_BTR2_CLKDIV                            \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC_S_FMC_BTR2_DATLAT                            \ (see note below bit descriptions): Data latency for synchronous memory
$30000000 constant FMC_S_FMC_BTR2_ACCMOD                            \ Access mode
$c0000000 constant FMC_S_FMC_BTR2_DATAHLD                           \ Data hold phase duration


\
\ @brief SRAM/NOR-flash chip-select control register for bank 3
\ Address offset: 0x10
\ Reset value: 0x000030D2
\

$00000001 constant FMC_S_FMC_BCR3_MBKEN                             \ Memory bank enable bit
$00000002 constant FMC_S_FMC_BCR3_MUXEN                             \ Address/data multiplexing enable bit
$0000000c constant FMC_S_FMC_BCR3_MTYP                              \ Memory type
$00000030 constant FMC_S_FMC_BCR3_MWID                              \ Memory data bus width
$00000040 constant FMC_S_FMC_BCR3_FACCEN                            \ Flash access enable
$00000100 constant FMC_S_FMC_BCR3_BURSTEN                           \ Burst enable bit
$00000200 constant FMC_S_FMC_BCR3_WAITPOL                           \ Wait signal polarity bit
$00000800 constant FMC_S_FMC_BCR3_WAITCFG                           \ Wait timing configuration
$00001000 constant FMC_S_FMC_BCR3_WREN                              \ Write enable bit
$00002000 constant FMC_S_FMC_BCR3_WAITEN                            \ Wait enable bit
$00004000 constant FMC_S_FMC_BCR3_EXTMOD                            \ Extended mode enable
$00008000 constant FMC_S_FMC_BCR3_ASYNCWAIT                         \ Wait signal during asynchronous transfers
$00070000 constant FMC_S_FMC_BCR3_CPSIZE                            \ CRAM page size
$00080000 constant FMC_S_FMC_BCR3_CBURSTRW                          \ Write burst enable
$00100000 constant FMC_S_FMC_BCR3_CCLKEN                            \ Continuous clock enable
$00200000 constant FMC_S_FMC_BCR3_WFDIS                             \ Write FIFO disable
$00c00000 constant FMC_S_FMC_BCR3_NBLSET                            \ Byte lane (NBL) setup
$80000000 constant FMC_S_FMC_BCR3_FMCEN                             \ FMC controller enable


\
\ @brief SRAM/NOR-flash chip-select timing register for bank 3
\ Address offset: 0x14
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_BTR3_ADDSET                            \ Address setup phase duration
$000000f0 constant FMC_S_FMC_BTR3_ADDHLD                            \ Address-hold phase duration
$0000ff00 constant FMC_S_FMC_BTR3_DATAST                            \ Data-phase duration
$000f0000 constant FMC_S_FMC_BTR3_BUSTURN                           \ Bus turnaround phase duration
$00f00000 constant FMC_S_FMC_BTR3_CLKDIV                            \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC_S_FMC_BTR3_DATLAT                            \ (see note below bit descriptions): Data latency for synchronous memory
$30000000 constant FMC_S_FMC_BTR3_ACCMOD                            \ Access mode
$c0000000 constant FMC_S_FMC_BTR3_DATAHLD                           \ Data hold phase duration


\
\ @brief SRAM/NOR-flash chip-select control register for bank 4
\ Address offset: 0x18
\ Reset value: 0x000030D2
\

$00000001 constant FMC_S_FMC_BCR4_MBKEN                             \ Memory bank enable bit
$00000002 constant FMC_S_FMC_BCR4_MUXEN                             \ Address/data multiplexing enable bit
$0000000c constant FMC_S_FMC_BCR4_MTYP                              \ Memory type
$00000030 constant FMC_S_FMC_BCR4_MWID                              \ Memory data bus width
$00000040 constant FMC_S_FMC_BCR4_FACCEN                            \ Flash access enable
$00000100 constant FMC_S_FMC_BCR4_BURSTEN                           \ Burst enable bit
$00000200 constant FMC_S_FMC_BCR4_WAITPOL                           \ Wait signal polarity bit
$00000800 constant FMC_S_FMC_BCR4_WAITCFG                           \ Wait timing configuration
$00001000 constant FMC_S_FMC_BCR4_WREN                              \ Write enable bit
$00002000 constant FMC_S_FMC_BCR4_WAITEN                            \ Wait enable bit
$00004000 constant FMC_S_FMC_BCR4_EXTMOD                            \ Extended mode enable
$00008000 constant FMC_S_FMC_BCR4_ASYNCWAIT                         \ Wait signal during asynchronous transfers
$00070000 constant FMC_S_FMC_BCR4_CPSIZE                            \ CRAM page size
$00080000 constant FMC_S_FMC_BCR4_CBURSTRW                          \ Write burst enable
$00100000 constant FMC_S_FMC_BCR4_CCLKEN                            \ Continuous clock enable
$00200000 constant FMC_S_FMC_BCR4_WFDIS                             \ Write FIFO disable
$00c00000 constant FMC_S_FMC_BCR4_NBLSET                            \ Byte lane (NBL) setup
$80000000 constant FMC_S_FMC_BCR4_FMCEN                             \ FMC controller enable


\
\ @brief SRAM/NOR-flash chip-select timing register for bank 4
\ Address offset: 0x1C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_BTR4_ADDSET                            \ Address setup phase duration
$000000f0 constant FMC_S_FMC_BTR4_ADDHLD                            \ Address-hold phase duration
$0000ff00 constant FMC_S_FMC_BTR4_DATAST                            \ Data-phase duration
$000f0000 constant FMC_S_FMC_BTR4_BUSTURN                           \ Bus turnaround phase duration
$00f00000 constant FMC_S_FMC_BTR4_CLKDIV                            \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC_S_FMC_BTR4_DATLAT                            \ (see note below bit descriptions): Data latency for synchronous memory
$30000000 constant FMC_S_FMC_BTR4_ACCMOD                            \ Access mode
$c0000000 constant FMC_S_FMC_BTR4_DATAHLD                           \ Data hold phase duration


\
\ @brief PSRAM chip select counter register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant FMC_S_FMC_PCSCNTR_CSCOUNT                        \ Chip select counter.
$00010000 constant FMC_S_FMC_PCSCNTR_CNTB1EN                        \ Counter Bank 1 enable
$00020000 constant FMC_S_FMC_PCSCNTR_CNTB2EN                        \ Counter Bank 2 enable
$00040000 constant FMC_S_FMC_PCSCNTR_CNTB3EN                        \ Counter Bank 3 enable
$00080000 constant FMC_S_FMC_PCSCNTR_CNTB4EN                        \ Counter Bank 4 enable


\
\ @brief NAND flash control registers
\ Address offset: 0x80
\ Reset value: 0x00000018
\

$00000002 constant FMC_S_FMC_PCR_PWAITEN                            \ Wait feature enable bit
$00000004 constant FMC_S_FMC_PCR_PBKEN                              \ NAND flash memory bank enable bit
$00000008 constant FMC_S_FMC_PCR_PTYP                               \ Memory type
$00000030 constant FMC_S_FMC_PCR_PWID                               \ Data bus width
$00000040 constant FMC_S_FMC_PCR_ECCEN                              \ ECC computation logic enable bit
$00001e00 constant FMC_S_FMC_PCR_TCLR                               \ CLE to RE delay
$0000e000 constant FMC_S_FMC_PCR_TAR                                \ ALE to RE delay
$00010000 constant FMC_S_FMC_PCR_TAR3                               \ ALE to RE delay
$000e0000 constant FMC_S_FMC_PCR_ECCPS                              \ ECC page size


\
\ @brief FIFO status and interrupt register
\ Address offset: 0x84
\ Reset value: 0x00000040
\

$00000001 constant FMC_S_FMC_SR_IRS                                 \ Interrupt rising edge status
$00000002 constant FMC_S_FMC_SR_ILS                                 \ Interrupt high-level status
$00000004 constant FMC_S_FMC_SR_IFS                                 \ Interrupt falling edge status
$00000008 constant FMC_S_FMC_SR_IREN                                \ Interrupt rising edge detection enable bit
$00000010 constant FMC_S_FMC_SR_ILEN                                \ Interrupt high-level detection enable bit
$00000020 constant FMC_S_FMC_SR_IFEN                                \ Interrupt falling edge detection enable bit
$00000040 constant FMC_S_FMC_SR_FEMPT                               \ FIFO empty


\
\ @brief Common memory space timing register
\ Address offset: 0x88
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FMC_S_FMC_PMEM_MEMSET                            \ Common memory x setup time
$0000ff00 constant FMC_S_FMC_PMEM_MEMWAIT                           \ Common memory wait time
$00ff0000 constant FMC_S_FMC_PMEM_MEMHOLD                           \ Common memory hold time
$ff000000 constant FMC_S_FMC_PMEM_MEMHIZ                            \ Common memory x data bus Hi-Z time


\
\ @brief Attribute memory space timing register
\ Address offset: 0x8C
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FMC_S_FMC_PATT_ATTSET                            \ Attribute memory setup time
$0000ff00 constant FMC_S_FMC_PATT_ATTWAIT                           \ Attribute memory wait time
$00ff0000 constant FMC_S_FMC_PATT_ATTHOLD                           \ Attribute memory hold time
$ff000000 constant FMC_S_FMC_PATT_ATTHIZ                            \ Attribute memory data bus Hi-Z time


\
\ @brief ECC result registers
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant FMC_S_FMC_ECCR_ECC                               \ ECC result


\
\ @brief SRAM/NOR-flash write timing registers 1
\ Address offset: 0x104
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_BWTR1_ADDSET                           \ Address setup phase duration.
$000000f0 constant FMC_S_FMC_BWTR1_ADDHLD                           \ Address-hold phase duration.
$0000ff00 constant FMC_S_FMC_BWTR1_DATAST                           \ Data-phase duration.
$000f0000 constant FMC_S_FMC_BWTR1_BUSTURN                          \ Bus turnaround phase duration
$30000000 constant FMC_S_FMC_BWTR1_ACCMOD                           \ Access mode.
$c0000000 constant FMC_S_FMC_BWTR1_DATAHLD                          \ Data hold phase duration


\
\ @brief SRAM/NOR-flash write timing registers 2
\ Address offset: 0x10C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_BWTR2_ADDSET                           \ Address setup phase duration.
$000000f0 constant FMC_S_FMC_BWTR2_ADDHLD                           \ Address-hold phase duration.
$0000ff00 constant FMC_S_FMC_BWTR2_DATAST                           \ Data-phase duration.
$000f0000 constant FMC_S_FMC_BWTR2_BUSTURN                          \ Bus turnaround phase duration
$30000000 constant FMC_S_FMC_BWTR2_ACCMOD                           \ Access mode.
$c0000000 constant FMC_S_FMC_BWTR2_DATAHLD                          \ Data hold phase duration


\
\ @brief SRAM/NOR-flash write timing registers 3
\ Address offset: 0x114
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_BWTR3_ADDSET                           \ Address setup phase duration.
$000000f0 constant FMC_S_FMC_BWTR3_ADDHLD                           \ Address-hold phase duration.
$0000ff00 constant FMC_S_FMC_BWTR3_DATAST                           \ Data-phase duration.
$000f0000 constant FMC_S_FMC_BWTR3_BUSTURN                          \ Bus turnaround phase duration
$30000000 constant FMC_S_FMC_BWTR3_ACCMOD                           \ Access mode.
$c0000000 constant FMC_S_FMC_BWTR3_DATAHLD                          \ Data hold phase duration


\
\ @brief SRAM/NOR-flash write timing registers 4
\ Address offset: 0x11C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_BWTR4_ADDSET                           \ Address setup phase duration.
$000000f0 constant FMC_S_FMC_BWTR4_ADDHLD                           \ Address-hold phase duration.
$0000ff00 constant FMC_S_FMC_BWTR4_DATAST                           \ Data-phase duration.
$000f0000 constant FMC_S_FMC_BWTR4_BUSTURN                          \ Bus turnaround phase duration
$30000000 constant FMC_S_FMC_BWTR4_ACCMOD                           \ Access mode.
$c0000000 constant FMC_S_FMC_BWTR4_DATAHLD                          \ Data hold phase duration


\
\ @brief SDRAM control registers 1,2
\ Address offset: 0x140
\ Reset value: 0x000002D0
\

$00000003 constant FMC_S_FMC_SDCR1_NC                               \ Number of column address bits
$0000000c constant FMC_S_FMC_SDCR1_NR                               \ Number of row address bits
$00000030 constant FMC_S_FMC_SDCR1_MWID                             \ Memory data bus width.
$00000040 constant FMC_S_FMC_SDCR1_NB                               \ Number of internal banks
$00000180 constant FMC_S_FMC_SDCR1_CAS                              \ CAS Latency
$00000200 constant FMC_S_FMC_SDCR1_WP                               \ Write protection
$00000c00 constant FMC_S_FMC_SDCR1_SDCLK                            \ SDRAM clock configuration
$00001000 constant FMC_S_FMC_SDCR1_RBURST                           \ Burst read
$00006000 constant FMC_S_FMC_SDCR1_RPIPE                            \ Read pipe


\
\ @brief SDRAM control registers 1,2
\ Address offset: 0x144
\ Reset value: 0x000002D0
\

$00000003 constant FMC_S_FMC_SDCR2_NC                               \ Number of column address bits
$0000000c constant FMC_S_FMC_SDCR2_NR                               \ Number of row address bits
$00000030 constant FMC_S_FMC_SDCR2_MWID                             \ Memory data bus width.
$00000040 constant FMC_S_FMC_SDCR2_NB                               \ Number of internal banks
$00000180 constant FMC_S_FMC_SDCR2_CAS                              \ CAS Latency
$00000200 constant FMC_S_FMC_SDCR2_WP                               \ Write protection
$00000c00 constant FMC_S_FMC_SDCR2_SDCLK                            \ SDRAM clock configuration
$00001000 constant FMC_S_FMC_SDCR2_RBURST                           \ Burst read
$00006000 constant FMC_S_FMC_SDCR2_RPIPE                            \ Read pipe


\
\ @brief SDRAM timing registers 1,2
\ Address offset: 0x148
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_SDTR1_TMRD                             \ Load Mode Register to Active
$000000f0 constant FMC_S_FMC_SDTR1_TXSR                             \ Exit Self-refresh delay
$00000f00 constant FMC_S_FMC_SDTR1_TRAS                             \ Self refresh time
$0000f000 constant FMC_S_FMC_SDTR1_TRC                              \ Row cycle delay
$000f0000 constant FMC_S_FMC_SDTR1_TWR                              \ Recovery delay
$00f00000 constant FMC_S_FMC_SDTR1_TRP                              \ Row precharge delay
$0f000000 constant FMC_S_FMC_SDTR1_TRCD                             \ Row to column delay


\
\ @brief SDRAM timing registers 1,2
\ Address offset: 0x14C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_S_FMC_SDTR2_TMRD                             \ Load Mode Register to Active
$000000f0 constant FMC_S_FMC_SDTR2_TXSR                             \ Exit Self-refresh delay
$00000f00 constant FMC_S_FMC_SDTR2_TRAS                             \ Self refresh time
$0000f000 constant FMC_S_FMC_SDTR2_TRC                              \ Row cycle delay
$000f0000 constant FMC_S_FMC_SDTR2_TWR                              \ Recovery delay
$00f00000 constant FMC_S_FMC_SDTR2_TRP                              \ Row precharge delay
$0f000000 constant FMC_S_FMC_SDTR2_TRCD                             \ Row to column delay


\
\ @brief SDRAM Command Mode register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000007 constant FMC_S_FMC_SDCMR_MODE                             \ Command mode
$00000008 constant FMC_S_FMC_SDCMR_CTB2                             \ Command Target Bank 2
$00000010 constant FMC_S_FMC_SDCMR_CTB1                             \ Command Target Bank 1
$000001e0 constant FMC_S_FMC_SDCMR_NRFS                             \ Number of Auto-refresh
$003ffe00 constant FMC_S_FMC_SDCMR_MRD                              \ Mode Register definition


\
\ @brief SDRAM refresh timer register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000001 constant FMC_S_FMC_SDRTR_CRE                              \ Clear Refresh error flag
$00003ffe constant FMC_S_FMC_SDRTR_COUNT                            \ Refresh Timer Count
$00004000 constant FMC_S_FMC_SDRTR_REIE                             \ RES Interrupt Enable


\
\ @brief SDRAM status register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000001 constant FMC_S_FMC_SDSR_RE                                \ Refresh error flag
$00000006 constant FMC_S_FMC_SDSR_MODES1                            \ Status Mode for Bank 1
$00000018 constant FMC_S_FMC_SDSR_MODES2                            \ Status Mode for Bank 2
$00000020 constant FMC_S_FMC_SDSR_BUSY                              \ Busy status


\
\ @brief FMC address block description
\
$57000400 constant FMC_S_FMC_BCR1  \ offset: 0x00 : SRAM/NOR-flash chip-select control register for bank 1
$57000404 constant FMC_S_FMC_BTR1  \ offset: 0x04 : SRAM/NOR-flash chip-select timing register for bank 1
$57000408 constant FMC_S_FMC_BCR2  \ offset: 0x08 : SRAM/NOR-flash chip-select control register for bank 2
$5700040c constant FMC_S_FMC_BTR2  \ offset: 0x0C : SRAM/NOR-flash chip-select timing register for bank 2
$57000410 constant FMC_S_FMC_BCR3  \ offset: 0x10 : SRAM/NOR-flash chip-select control register for bank 3
$57000414 constant FMC_S_FMC_BTR3  \ offset: 0x14 : SRAM/NOR-flash chip-select timing register for bank 3
$57000418 constant FMC_S_FMC_BCR4  \ offset: 0x18 : SRAM/NOR-flash chip-select control register for bank 4
$5700041c constant FMC_S_FMC_BTR4  \ offset: 0x1C : SRAM/NOR-flash chip-select timing register for bank 4
$57000420 constant FMC_S_FMC_PCSCNTR  \ offset: 0x20 : PSRAM chip select counter register
$57000480 constant FMC_S_FMC_PCR  \ offset: 0x80 : NAND flash control registers
$57000484 constant FMC_S_FMC_SR   \ offset: 0x84 : FIFO status and interrupt register
$57000488 constant FMC_S_FMC_PMEM  \ offset: 0x88 : Common memory space timing register
$5700048c constant FMC_S_FMC_PATT  \ offset: 0x8C : Attribute memory space timing register
$57000494 constant FMC_S_FMC_ECCR  \ offset: 0x94 : ECC result registers
$57000504 constant FMC_S_FMC_BWTR1  \ offset: 0x104 : SRAM/NOR-flash write timing registers 1
$5700050c constant FMC_S_FMC_BWTR2  \ offset: 0x10C : SRAM/NOR-flash write timing registers 2
$57000514 constant FMC_S_FMC_BWTR3  \ offset: 0x114 : SRAM/NOR-flash write timing registers 3
$5700051c constant FMC_S_FMC_BWTR4  \ offset: 0x11C : SRAM/NOR-flash write timing registers 4
$57000540 constant FMC_S_FMC_SDCR1  \ offset: 0x140 : SDRAM control registers 1,2
$57000544 constant FMC_S_FMC_SDCR2  \ offset: 0x144 : SDRAM control registers 1,2
$57000548 constant FMC_S_FMC_SDTR1  \ offset: 0x148 : SDRAM timing registers 1,2
$5700054c constant FMC_S_FMC_SDTR2  \ offset: 0x14C : SDRAM timing registers 1,2
$57000550 constant FMC_S_FMC_SDCMR  \ offset: 0x150 : SDRAM Command Mode register
$57000554 constant FMC_S_FMC_SDRTR  \ offset: 0x154 : SDRAM refresh timer register
$57000558 constant FMC_S_FMC_SDSR  \ offset: 0x158 : SDRAM status register

