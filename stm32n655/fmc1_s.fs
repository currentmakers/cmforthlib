\
\ @file fmc1_s.fs
\ @brief Flexible memory controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SRAM/NOR Flash chip-select control register for memory region 1
\ Address offset: 0x00
\ Reset value: 0x000030DB
\

$00000001 constant FMC1_S_FMC_BCR1_MBKEN                            \ Memory region enable bit
$00000002 constant FMC1_S_FMC_BCR1_MUXEN                            \ Address/data multiplexing enable bit
$0000000c constant FMC1_S_FMC_BCR1_MTYP                             \ Memory type
$00000030 constant FMC1_S_FMC_BCR1_MWID                             \ Memory data bus width
$00000040 constant FMC1_S_FMC_BCR1_FACCEN                           \ Flash memory access enable
$00000100 constant FMC1_S_FMC_BCR1_BURSTEN                          \ Burst enable bit
$00000200 constant FMC1_S_FMC_BCR1_WAITPOL                          \ Wait signal polarity bit
$00000800 constant FMC1_S_FMC_BCR1_WAITCFG                          \ Wait timing configuration
$00001000 constant FMC1_S_FMC_BCR1_WREN                             \ Write enable bit
$00002000 constant FMC1_S_FMC_BCR1_WAITEN                           \ Wait enable bit
$00004000 constant FMC1_S_FMC_BCR1_EXTMOD                           \ Extended mode enable
$00008000 constant FMC1_S_FMC_BCR1_ASYNCWAIT                        \ Wait signal during asynchronous transfers
$00070000 constant FMC1_S_FMC_BCR1_CPSIZE                           \ CRAM page size
$00080000 constant FMC1_S_FMC_BCR1_CBURSTRW                         \ Write burst enable
$00300000 constant FMC1_S_FMC_BCR1_CSCOUNT0                         \ Chip Select (CS) counter
$00c00000 constant FMC1_S_FMC_BCR1_NBLSET                           \ Byte lane (NBL) setup


\
\ @brief SRAM/NOR Flash chip-select timing registers for memory region 1
\ Address offset: 0x04
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC1_S_FMC_BTR1_ADDSET                           \ Address setup phase duration
$000000f0 constant FMC1_S_FMC_BTR1_ADDHLD                           \ Address-hold phase duration
$0000ff00 constant FMC1_S_FMC_BTR1_DATAST                           \ Data-phase duration
$000f0000 constant FMC1_S_FMC_BTR1_BUSTURN                          \ Bus turnaround phase duration
$00f00000 constant FMC1_S_FMC_BTR1_CLKDIV                           \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC1_S_FMC_BTR1_DATLAT                           \ Data latency for synchronous memory (see note below bit descriptions)
$30000000 constant FMC1_S_FMC_BTR1_ACCMOD                           \ Access mode
$c0000000 constant FMC1_S_FMC_BTR1_DATAHLD                          \ Data Hold phase duration


\
\ @brief SRAM/NOR Flash chip-select control register for memory region 2
\ Address offset: 0x08
\ Reset value: 0x000030D2
\

$00000001 constant FMC1_S_FMC_BCR2_MBKEN                            \ Memory region enable bit
$00000002 constant FMC1_S_FMC_BCR2_MUXEN                            \ Address/data multiplexing enable bit
$0000000c constant FMC1_S_FMC_BCR2_MTYP                             \ Memory type
$00000030 constant FMC1_S_FMC_BCR2_MWID                             \ Memory data bus width
$00000040 constant FMC1_S_FMC_BCR2_FACCEN                           \ Flash memory access enable
$00000100 constant FMC1_S_FMC_BCR2_BURSTEN                          \ Burst enable bit
$00000200 constant FMC1_S_FMC_BCR2_WAITPOL                          \ Wait signal polarity bit
$00000800 constant FMC1_S_FMC_BCR2_WAITCFG                          \ Wait timing configuration
$00001000 constant FMC1_S_FMC_BCR2_WREN                             \ Write enable bit
$00002000 constant FMC1_S_FMC_BCR2_WAITEN                           \ Wait enable bit
$00004000 constant FMC1_S_FMC_BCR2_EXTMOD                           \ Extended mode enable
$00008000 constant FMC1_S_FMC_BCR2_ASYNCWAIT                        \ Wait signal during asynchronous transfers
$00070000 constant FMC1_S_FMC_BCR2_CPSIZE                           \ CRAM page size
$00080000 constant FMC1_S_FMC_BCR2_CBURSTRW                         \ Write burst enable
$00100000 constant FMC1_S_FMC_BCR2_CSCOUNT0                         \ Chip Select (CS) counter
$00200000 constant FMC1_S_FMC_BCR2_CSCOUNT1                         \ Chip Select (CS) counter
$00c00000 constant FMC1_S_FMC_BCR2_NBLSET                           \ Byte lane (NBL) setup


\
\ @brief SRAM/NOR Flash chip-select timing registers for memory region 2
\ Address offset: 0x0C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC1_S_FMC_BTR2_ADDSET                           \ Address setup phase duration
$000000f0 constant FMC1_S_FMC_BTR2_ADDHLD                           \ Address-hold phase duration
$0000ff00 constant FMC1_S_FMC_BTR2_DATAST                           \ Data-phase duration
$000f0000 constant FMC1_S_FMC_BTR2_BUSTURN                          \ Bus turnaround phase duration
$00f00000 constant FMC1_S_FMC_BTR2_CLKDIV                           \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC1_S_FMC_BTR2_DATLAT                           \ Data latency for synchronous memory (see note below bit descriptions)
$30000000 constant FMC1_S_FMC_BTR2_ACCMOD                           \ Access mode
$c0000000 constant FMC1_S_FMC_BTR2_DATAHLD                          \ Data Hold phase duration


\
\ @brief SRAM/NOR Flash chip-select control register for memory region 3
\ Address offset: 0x10
\ Reset value: 0x000030D2
\

$00000001 constant FMC1_S_FMC_BCR3_MBKEN                            \ Memory region enable bit
$00000002 constant FMC1_S_FMC_BCR3_MUXEN                            \ Address/data multiplexing enable bit
$0000000c constant FMC1_S_FMC_BCR3_MTYP                             \ Memory type
$00000030 constant FMC1_S_FMC_BCR3_MWID                             \ Memory data bus width
$00000040 constant FMC1_S_FMC_BCR3_FACCEN                           \ Flash memory access enable
$00000100 constant FMC1_S_FMC_BCR3_BURSTEN                          \ Burst enable bit
$00000200 constant FMC1_S_FMC_BCR3_WAITPOL                          \ Wait signal polarity bit
$00000800 constant FMC1_S_FMC_BCR3_WAITCFG                          \ Wait timing configuration
$00001000 constant FMC1_S_FMC_BCR3_WREN                             \ Write enable bit
$00002000 constant FMC1_S_FMC_BCR3_WAITEN                           \ Wait enable bit
$00004000 constant FMC1_S_FMC_BCR3_EXTMOD                           \ Extended mode enable
$00008000 constant FMC1_S_FMC_BCR3_ASYNCWAIT                        \ Wait signal during asynchronous transfers
$00070000 constant FMC1_S_FMC_BCR3_CPSIZE                           \ CRAM page size
$00080000 constant FMC1_S_FMC_BCR3_CBURSTRW                         \ Write burst enable
$00100000 constant FMC1_S_FMC_BCR3_CSCOUNT0                         \ Chip Select (CS) counter
$00200000 constant FMC1_S_FMC_BCR3_CSCOUNT1                         \ Chip Select (CS) counter
$00c00000 constant FMC1_S_FMC_BCR3_NBLSET                           \ Byte lane (NBL) setup


\
\ @brief SRAM/NOR Flash chip-select timing registers for memory region 3
\ Address offset: 0x14
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC1_S_FMC_BTR3_ADDSET                           \ Address setup phase duration
$000000f0 constant FMC1_S_FMC_BTR3_ADDHLD                           \ Address-hold phase duration
$0000ff00 constant FMC1_S_FMC_BTR3_DATAST                           \ Data-phase duration
$000f0000 constant FMC1_S_FMC_BTR3_BUSTURN                          \ Bus turnaround phase duration
$00f00000 constant FMC1_S_FMC_BTR3_CLKDIV                           \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC1_S_FMC_BTR3_DATLAT                           \ Data latency for synchronous memory (see note below bit descriptions)
$30000000 constant FMC1_S_FMC_BTR3_ACCMOD                           \ Access mode
$c0000000 constant FMC1_S_FMC_BTR3_DATAHLD                          \ Data Hold phase duration


\
\ @brief SRAM/NOR Flash chip-select control register for memory region 4
\ Address offset: 0x18
\ Reset value: 0x000030D2
\

$00000001 constant FMC1_S_FMC_BCR4_MBKEN                            \ Memory region enable bit
$00000002 constant FMC1_S_FMC_BCR4_MUXEN                            \ Address/data multiplexing enable bit
$0000000c constant FMC1_S_FMC_BCR4_MTYP                             \ Memory type
$00000030 constant FMC1_S_FMC_BCR4_MWID                             \ Memory data bus width
$00000040 constant FMC1_S_FMC_BCR4_FACCEN                           \ Flash memory access enable
$00000100 constant FMC1_S_FMC_BCR4_BURSTEN                          \ Burst enable bit
$00000200 constant FMC1_S_FMC_BCR4_WAITPOL                          \ Wait signal polarity bit
$00000800 constant FMC1_S_FMC_BCR4_WAITCFG                          \ Wait timing configuration
$00001000 constant FMC1_S_FMC_BCR4_WREN                             \ Write enable bit
$00002000 constant FMC1_S_FMC_BCR4_WAITEN                           \ Wait enable bit
$00004000 constant FMC1_S_FMC_BCR4_EXTMOD                           \ Extended mode enable
$00008000 constant FMC1_S_FMC_BCR4_ASYNCWAIT                        \ Wait signal during asynchronous transfers
$00070000 constant FMC1_S_FMC_BCR4_CPSIZE                           \ CRAM page size
$00080000 constant FMC1_S_FMC_BCR4_CBURSTRW                         \ Write burst enable
$00100000 constant FMC1_S_FMC_BCR4_CSCOUNT0                         \ Chip Select (CS) counter
$00200000 constant FMC1_S_FMC_BCR4_CSCOUNT1                         \ Chip Select (CS) counter
$00c00000 constant FMC1_S_FMC_BCR4_NBLSET                           \ Byte lane (NBL) setup


\
\ @brief SRAM/NOR Flash chip-select timing registers for memory region 4
\ Address offset: 0x1C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC1_S_FMC_BTR4_ADDSET                           \ Address setup phase duration
$000000f0 constant FMC1_S_FMC_BTR4_ADDHLD                           \ Address-hold phase duration
$0000ff00 constant FMC1_S_FMC_BTR4_DATAST                           \ Data-phase duration
$000f0000 constant FMC1_S_FMC_BTR4_BUSTURN                          \ Bus turnaround phase duration
$00f00000 constant FMC1_S_FMC_BTR4_CLKDIV                           \ Clock divide ratio (for FMC_CLK signal)
$0f000000 constant FMC1_S_FMC_BTR4_DATLAT                           \ Data latency for synchronous memory (see note below bit descriptions)
$30000000 constant FMC1_S_FMC_BTR4_ACCMOD                           \ Access mode
$c0000000 constant FMC1_S_FMC_BTR4_DATAHLD                          \ Data Hold phase duration


\
\ @brief FMC common configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000f0000 constant FMC1_S_FMC_CFGR_CLKDIV                           \ Clock divide ratio (for FMC_CLK signal)
$00100000 constant FMC1_S_FMC_CFGR_CCLKEN                           \ Continuous clock enable
$01000000 constant FMC1_S_FMC_CFGR_BMAP0                            \ FMC memory region mapping
$02000000 constant FMC1_S_FMC_CFGR_BMAP1                            \ FMC memory region mapping
$80000000 constant FMC1_S_FMC_CFGR_FMCEN                            \ FMC controller enable


\
\ @brief NAND Flash programmable control register
\ Address offset: 0x80
\ Reset value: 0x0007FE08
\

$00000002 constant FMC1_S_FMC_PCR_PWAITEN                           \ Wait feature enable bit
$00000004 constant FMC1_S_FMC_PCR_PBKEN                             \ NAND Flash memory region enable bit
$00000030 constant FMC1_S_FMC_PCR_PWID                              \ Data bus width
$00000040 constant FMC1_S_FMC_PCR_ECCEN                             \ ECC computation logic enable bit
$00000100 constant FMC1_S_FMC_PCR_ECCALG                            \ ECC algorithm
$00001e00 constant FMC1_S_FMC_PCR_TCLR                              \ CLE to RE delay.
$0001e000 constant FMC1_S_FMC_PCR_TAR                               \ ALE to RE delay.
$000e0000 constant FMC1_S_FMC_PCR_ECCSS                             \ ECC sector size (used to access spare area)
$01000000 constant FMC1_S_FMC_PCR_BCHECC                            \ BCH error correction capability
$02000000 constant FMC1_S_FMC_PCR_WEN                               \ Write enable


\
\ @brief FMC status register
\ Address offset: 0x84
\ Reset value: 0x00000053
\

$00000003 constant FMC1_S_FMC_SR_ISOST                              \ FMC isolation state with respect to the AXI interface
$00000010 constant FMC1_S_FMC_SR_PEF                                \ Pipe Empty Flag
$00000040 constant FMC1_S_FMC_SR_NWRF                               \ NAND write request flag


\
\ @brief FMC common memory space timing register
\ Address offset: 0x88
\ Reset value: 0x0A0A0A0A
\

$000000ff constant FMC1_S_FMC_PMEM_MEMSET                           \ Common memory setup time
$0000ff00 constant FMC1_S_FMC_PMEM_MEMWAIT                          \ Common memory wait time
$00ff0000 constant FMC1_S_FMC_PMEM_MEMHOLD                          \ Common memory hold time
$ff000000 constant FMC1_S_FMC_PMEM_MEMHIZ                           \ Common memory data bus Hi-Z time


\
\ @brief FMC attribute memory space timing registers
\ Address offset: 0x8C
\ Reset value: 0x0A0A0A0A
\

$000000ff constant FMC1_S_FMC_PATT_ATTSET                           \ Attribute memory setup time
$0000ff00 constant FMC1_S_FMC_PATT_ATTWAIT                          \ Attribute memory wait time
$00ff0000 constant FMC1_S_FMC_PATT_ATTHOLD                          \ Attribute memory hold time
$ff000000 constant FMC1_S_FMC_PATT_ATTHIZ                           \ Attribute memory data bus Hi-Z time


\
\ @brief FMC Hamming parity result registers
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant FMC1_S_FMC_HPR_HPR                               \ Hamming parity result


\
\ @brief FMC Hamming code ECC result register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant FMC1_S_FMC_HECCR_HECC                            \ ECC result


\
\ @brief SRAM/NOR-Flash write timing registers for memory region 1
\ Address offset: 0x104
\ Reset value: 0x000FFFFF
\

$0000000f constant FMC1_S_FMC_BWTR1_ADDSET                          \ Address setup phase duration.
$000000f0 constant FMC1_S_FMC_BWTR1_ADDHLD                          \ Address-hold phase duration.
$0000ff00 constant FMC1_S_FMC_BWTR1_DATAST                          \ Data-phase duration.
$000f0000 constant FMC1_S_FMC_BWTR1_BUSTURN                         \ Bus turnaround phase duration
$30000000 constant FMC1_S_FMC_BWTR1_ACCMOD                          \ Access mode.
$c0000000 constant FMC1_S_FMC_BWTR1_DATAHLD                         \ Data Hold phase duration


\
\ @brief SRAM/NOR-Flash write timing registers for memory region 2
\ Address offset: 0x10C
\ Reset value: 0x000FFFFF
\

$0000000f constant FMC1_S_FMC_BWTR2_ADDSET                          \ Address setup phase duration.
$000000f0 constant FMC1_S_FMC_BWTR2_ADDHLD                          \ Address-hold phase duration.
$0000ff00 constant FMC1_S_FMC_BWTR2_DATAST                          \ Data-phase duration.
$000f0000 constant FMC1_S_FMC_BWTR2_BUSTURN                         \ Bus turnaround phase duration
$30000000 constant FMC1_S_FMC_BWTR2_ACCMOD                          \ Access mode.
$c0000000 constant FMC1_S_FMC_BWTR2_DATAHLD                         \ Data Hold phase duration


\
\ @brief SRAM/NOR-Flash write timing registers for memory region 3
\ Address offset: 0x114
\ Reset value: 0x000FFFFF
\

$0000000f constant FMC1_S_FMC_BWTR3_ADDSET                          \ Address setup phase duration.
$000000f0 constant FMC1_S_FMC_BWTR3_ADDHLD                          \ Address-hold phase duration.
$0000ff00 constant FMC1_S_FMC_BWTR3_DATAST                          \ Data-phase duration.
$000f0000 constant FMC1_S_FMC_BWTR3_BUSTURN                         \ Bus turnaround phase duration
$30000000 constant FMC1_S_FMC_BWTR3_ACCMOD                          \ Access mode.
$c0000000 constant FMC1_S_FMC_BWTR3_DATAHLD                         \ Data Hold phase duration


\
\ @brief SRAM/NOR-Flash write timing registers for memory region 4
\ Address offset: 0x11C
\ Reset value: 0x000FFFFF
\

$0000000f constant FMC1_S_FMC_BWTR4_ADDSET                          \ Address setup phase duration.
$000000f0 constant FMC1_S_FMC_BWTR4_ADDHLD                          \ Address-hold phase duration.
$0000ff00 constant FMC1_S_FMC_BWTR4_DATAST                          \ Data-phase duration.
$000f0000 constant FMC1_S_FMC_BWTR4_BUSTURN                         \ Bus turnaround phase duration
$30000000 constant FMC1_S_FMC_BWTR4_ACCMOD                          \ Access mode.
$c0000000 constant FMC1_S_FMC_BWTR4_DATAHLD                         \ Data Hold phase duration


\
\ @brief SDRAM control registers for SDRAM device 1
\ Address offset: 0x140
\ Reset value: 0x000002D0
\

$00000003 constant FMC1_S_FMC_SDCR1_NC                              \ Number of column address bits
$0000000c constant FMC1_S_FMC_SDCR1_NR                              \ Number of row address bits
$00000030 constant FMC1_S_FMC_SDCR1_MWID                            \ Memory data bus width.
$00000040 constant FMC1_S_FMC_SDCR1_NB                              \ Number of banks
$00000180 constant FMC1_S_FMC_SDCR1_CAS                             \ CAS Latency
$00000200 constant FMC1_S_FMC_SDCR1_WP                              \ Write protection
$00000c00 constant FMC1_S_FMC_SDCR1_SDCLK                           \ SDRAM clock configuration
$00006000 constant FMC1_S_FMC_SDCR1_RPIPE                           \ Read pipe
$00010000 constant FMC1_S_FMC_SDCR1_SDEN                            \ SDRAM device enable
$00020000 constant FMC1_S_FMC_SDCR1_SDINIT                          \ SDRAM device initialization


\
\ @brief SDRAM control registers for SDRAM device 2
\ Address offset: 0x144
\ Reset value: 0x000002D0
\

$00000003 constant FMC1_S_FMC_SDCR2_NC                              \ Number of column address bits
$0000000c constant FMC1_S_FMC_SDCR2_NR                              \ Number of row address bits
$00000030 constant FMC1_S_FMC_SDCR2_MWID                            \ Memory data bus width.
$00000040 constant FMC1_S_FMC_SDCR2_NB                              \ Number of banks
$00000180 constant FMC1_S_FMC_SDCR2_CAS                             \ CAS Latency
$00000200 constant FMC1_S_FMC_SDCR2_WP                              \ Write protection
$00010000 constant FMC1_S_FMC_SDCR2_SDEN                            \ SDRAM device enable
$00020000 constant FMC1_S_FMC_SDCR2_SDINIT                          \ SDRAM device initialization


\
\ @brief SDRAM timing register
\ Address offset: 0x148
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC1_S_FMC_SDTR_TMRD                             \ Load mode register to active
$000000f0 constant FMC1_S_FMC_SDTR_TXSR                             \ Exit self-refresh delay
$00000f00 constant FMC1_S_FMC_SDTR_TRAS                             \ Self-refresh time
$0000f000 constant FMC1_S_FMC_SDTR_TRC                              \ Row cycle delay
$000f0000 constant FMC1_S_FMC_SDTR_TWR                              \ Recovery delay
$00f00000 constant FMC1_S_FMC_SDTR_TRP                              \ Row precharge delay
$0f000000 constant FMC1_S_FMC_SDTR_TRCD                             \ Row to column delay


\
\ @brief SDRAM command mode register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000007 constant FMC1_S_FMC_SDCMR_MODE                            \ Command mode
$00000008 constant FMC1_S_FMC_SDCMR_DS2                             \ Command targeting SDRAM device 2
$00000010 constant FMC1_S_FMC_SDCMR_DS1                             \ Command targeting SDRAM device 1
$000001e0 constant FMC1_S_FMC_SDCMR_NRFS                            \ Number of Refresh commands
$007ffe00 constant FMC1_S_FMC_SDCMR_MRD                             \ Mode register definition


\
\ @brief SDRAM refresh timer register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_SDRTR_CRE                             \ Clear Refresh error flag
$00003ffe constant FMC1_S_FMC_SDRTR_RFSCNT                          \ Refresh Timer Count
$00004000 constant FMC1_S_FMC_SDRTR_REIE                            \ RES Interrupt Enable


\
\ @brief SDRAM status register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_SDSR_RE                               \ Refresh error flag
$00000006 constant FMC1_S_FMC_SDSR_MODES1                           \ Status Mode for SDRAM device 1
$00000018 constant FMC1_S_FMC_SDSR_MODES2                           \ Status mode for SDRAM device 2
$00008000 constant FMC1_S_FMC_SDSR_CMDOK                            \ Previous command status


\
\ @brief FMC NAND interrupt enable register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_IER_IREE                              \ Interrupt rising edge detection enable bit
$00000002 constant FMC1_S_FMC_IER_IHLE                              \ Interrupt high-level detection enable bit
$00000004 constant FMC1_S_FMC_IER_IFEE                              \ Interrupt falling edge detection enable bit


\
\ @brief FMC controller interrupt status register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_ISR_IREF                              \ Interrupt rising edge flag
$00000002 constant FMC1_S_FMC_ISR_IHLF                              \ Interrupt high-level flag
$00000004 constant FMC1_S_FMC_ISR_IFEF                              \ Interrupt falling edge flag


\
\ @brief FMC NAND controller interrupt clear register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_ICR_CIREF                             \ Clear Interrupt rising edge flag
$00000002 constant FMC1_S_FMC_ICR_CIHLF                             \ Clear Interrupt high-level flag
$00000004 constant FMC1_S_FMC_ICR_CIFEF                             \ Clear Interrupt falling edge flag


\
\ @brief FMC NAND command sequencer control register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_CSQCR_CSQSTART                        \ Command Sequencer Enable


\
\ @brief FMC NAND command sequencer configuration register 1
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000002 constant FMC1_S_FMC_CSQCFGR1_CMD2EN                       \ Command cycle 2 Enable
$00000004 constant FMC1_S_FMC_CSQCFGR1_DMADEN                       \ Command sequencer DMA request data enable
$00000070 constant FMC1_S_FMC_CSQCFGR1_ACYNBR                       \ Address Cycle number
$0000ff00 constant FMC1_S_FMC_CSQCFGR1_CMD1                         \ Command 1 sequencer
$00ff0000 constant FMC1_S_FMC_CSQCFGR1_CMD2                         \ Command 2 sequencer
$01000000 constant FMC1_S_FMC_CSQCFGR1_CMD1T                        \ Command 1 Sequencer timings
$02000000 constant FMC1_S_FMC_CSQCFGR1_CMD2T                        \ Command 2 Sequencer timings


\
\ @brief FMC NAND command sequencer configuration register 2
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_CSQCFGR2_SQSDTEN                      \ Sequencer spare data transfer enable
$00000002 constant FMC1_S_FMC_CSQCFGR2_RCMD2EN                      \ Random Command 2 sequencer enable
$00000004 constant FMC1_S_FMC_CSQCFGR2_DMASEN                       \ Command sequencer DMA request decoding status enable
$0000ff00 constant FMC1_S_FMC_CSQCFGR2_RCMD1                        \ Random Command 1 sequencer
$00ff0000 constant FMC1_S_FMC_CSQCFGR2_RCMD2                        \ Random Command 2 sequencer
$01000000 constant FMC1_S_FMC_CSQCFGR2_RCMD1T                       \ Command 1 sequencer timings
$02000000 constant FMC1_S_FMC_CSQCFGR2_RCMD2T                       \ Command 1 sequencer timings


\
\ @brief FMC NAND sequencer configuration register 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00003f00 constant FMC1_S_FMC_CSQCFGR3_SNBR                         \ Number of sectors to be read/written
$00010000 constant FMC1_S_FMC_CSQCFGR3_AC1T                         \ Address cycle 1 sequencer timings
$00020000 constant FMC1_S_FMC_CSQCFGR3_AC2T                         \ Address cycle 2 sequencer timings
$00040000 constant FMC1_S_FMC_CSQCFGR3_AC3T                         \ Address cycle 3 sequencer timings
$00080000 constant FMC1_S_FMC_CSQCFGR3_AC4T                         \ Address cycle 4sequencer timings
$00100000 constant FMC1_S_FMC_CSQCFGR3_AC5T                         \ Address cycle 5 sequencer timings
$00200000 constant FMC1_S_FMC_CSQCFGR3_SDT                          \ Spare data transfer sequencer timings
$00400000 constant FMC1_S_FMC_CSQCFGR3_RAC1T                        \ Random Address cycle 1 sequencer timings
$00800000 constant FMC1_S_FMC_CSQCFGR3_RAC2T                        \ Random Address cycle 2 sequencer timings


\
\ @brief FMC NAND command sequencer address register 1
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$000000ff constant FMC1_S_FMC_CSQAR1_ADDC1                          \ Address Cycle 1
$0000ff00 constant FMC1_S_FMC_CSQAR1_ADDC2                          \ Address Cycle 2
$00ff0000 constant FMC1_S_FMC_CSQAR1_ADDC3                          \ Address Cycle 3
$ff000000 constant FMC1_S_FMC_CSQAR1_ADDC4                          \ Address Cycle 4


\
\ @brief FMC NAND command sequencer address register 2
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant FMC1_S_FMC_CSQAR2_ADDC5                          \ Address Cycle 5
$ffff0000 constant FMC1_S_FMC_CSQAR2_SAO                            \ Spare Area Address Offset


\
\ @brief FMC NAND command sequencer interrupt enable register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_CSQIER_TCIE                           \ Transfer Complete Interrupt enable
$00000002 constant FMC1_S_FMC_CSQIER_SCIE                           \ Sector Complete interrupt enable
$00000004 constant FMC1_S_FMC_CSQIER_SEIE                           \ Sector Error interrupt enable
$00000008 constant FMC1_S_FMC_CSQIER_SUEIE                          \ Sector Uncorrectable Error interrupt enable
$00000010 constant FMC1_S_FMC_CSQIER_CMDTCIE                        \ Command Transfer Complete interrupt enable


\
\ @brief FMC NAND command sequencer interrupt status register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_CSQISR_TCF                            \ Transfer Complete flag
$00000002 constant FMC1_S_FMC_CSQISR_SCF                            \ Sector Complete flag
$00000004 constant FMC1_S_FMC_CSQISR_SEF                            \ Sector Error flag
$00000008 constant FMC1_S_FMC_CSQISR_SUEF                           \ Sector Uncorrectable Error flag
$00000010 constant FMC1_S_FMC_CSQISR_CMDTCF                         \ Command Transfer Complete flag


\
\ @brief FMC NAND command sequencer interrupt clear register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_CSQICR_CTCF                           \ Clear Transfer Complete flag
$00000002 constant FMC1_S_FMC_CSQICR_CSCF                           \ Clear Sector Complete flag
$00000004 constant FMC1_S_FMC_CSQICR_CSEF                           \ Clear Sector Error flag
$00000008 constant FMC1_S_FMC_CSQICR_CSUEF                          \ Clear Sector uncorrectable Error flag
$00000010 constant FMC1_S_FMC_CSQICR_CCMDTCF                        \ Clear Command Transfer Complete flag


\
\ @brief FMC command sequencer error mapping status register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$0000ffff constant FMC1_S_FMC_CSQEMSR_SEM                           \ Sector Error mapping


\
\ @brief FMC BCH interrupt enable register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_BCHIER_DUEIE                          \ Decoder Uncorrectable Errors Interrupt enable
$00000002 constant FMC1_S_FMC_BCHIER_DERIE                          \ Decoder Error Ready Interrupt enable
$00000004 constant FMC1_S_FMC_BCHIER_DEFIE                          \ Decoder Error Found Interrupt enable
$00000008 constant FMC1_S_FMC_BCHIER_DSRIE                          \ Decoder Syndrome Ready Interrupt enable
$00000010 constant FMC1_S_FMC_BCHIER_EPBRIE                         \ Decoder Parity Bits Ready Interrupt enable


\
\ @brief FMC BCH interrupt and status register
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_BCHISR_DUEF                           \ Decoder Uncorrectable Errors flag
$00000002 constant FMC1_S_FMC_BCHISR_DERF                           \ Decoder Error Ready flag
$00000004 constant FMC1_S_FMC_BCHISR_DEFF                           \ Decoder Error Found flag
$00000008 constant FMC1_S_FMC_BCHISR_DSRF                           \ Decoder Syndrome Ready flag
$00000010 constant FMC1_S_FMC_BCHISR_EPBRF                          \ Encoder Parity Bits Ready flag


\
\ @brief FMC BCH interrupt clear register
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_BCHICR_CDUEF                          \ Clear Decoder Uncorrectable Error flag
$00000002 constant FMC1_S_FMC_BCHICR_CDERF                          \ Clear Decoder Error ready flag
$00000004 constant FMC1_S_FMC_BCHICR_CDEFF                          \ Clear Decoder Error Found flag
$00000008 constant FMC1_S_FMC_BCHICR_CDSRF                          \ Clear Decoder Syndrome Ready flag
$00000010 constant FMC1_S_FMC_BCHICR_CEPBRF                         \ Clear Encoder Parity Bits Ready flag


\
\ @brief FMC BCH parity bits register 1
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000000 constant FMC1_S_FMC_BCHPBR1_BCHPB                         \ BCH parity bits


\
\ @brief FMC BCH parity bits register 2
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant FMC1_S_FMC_BCHPBR2_BCHPB                         \ BCH parity bits


\
\ @brief FMC BCH parity bits register 3
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000000 constant FMC1_S_FMC_BCHPBR3_BCHPB                         \ BCH parity bits


\
\ @brief FMC BCH parity bits register 4
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$000000ff constant FMC1_S_FMC_BCHPBR4_BCHPB                         \ BCH parity bits


\
\ @brief FMC BCH decoder status register 0
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000001 constant FMC1_S_FMC_BCHDSR0_DUE                           \ Decoder uncorrectable error
$00000002 constant FMC1_S_FMC_BCHDSR0_DEF                           \ Decoder error found
$000000f0 constant FMC1_S_FMC_BCHDSR0_DEN                           \ Decoder error number


\
\ @brief FMC BCH decoder status register for memory region 1
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00001fff constant FMC1_S_FMC_BCHDSR1_EBP1                          \ Error bit position for error number 1
$1fff0000 constant FMC1_S_FMC_BCHDSR1_EBP2                          \ Error bit position for error number 2


\
\ @brief FMC BCH decoder status register for memory region 2
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00001fff constant FMC1_S_FMC_BCHDSR2_EBP3                          \ Error bit position for error number 3
$1fff0000 constant FMC1_S_FMC_BCHDSR2_EBP4                          \ Error bit position for error number 4


\
\ @brief FMC BCH decoder status register for memory region 3
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00001fff constant FMC1_S_FMC_BCHDSR3_EBP5                          \ Error bit position for error number 5
$1fff0000 constant FMC1_S_FMC_BCHDSR3_EBP6                          \ Error bit position for error number 6


\
\ @brief FMC BCH decoder status register for memory region 4
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00001fff constant FMC1_S_FMC_BCHDSR4_EBP7                          \ Error bit position for error number 7
$1fff0000 constant FMC1_S_FMC_BCHDSR4_EBP8                          \ Error bit position for error number 8


\
\ @brief Flexible memory controller
\
$58024000 constant FMC1_S_FMC_BCR1  \ offset: 0x00 : SRAM/NOR Flash chip-select control register for memory region 1
$58024004 constant FMC1_S_FMC_BTR1  \ offset: 0x04 : SRAM/NOR Flash chip-select timing registers for memory region 1
$58024008 constant FMC1_S_FMC_BCR2  \ offset: 0x08 : SRAM/NOR Flash chip-select control register for memory region 2
$5802400c constant FMC1_S_FMC_BTR2  \ offset: 0x0C : SRAM/NOR Flash chip-select timing registers for memory region 2
$58024010 constant FMC1_S_FMC_BCR3  \ offset: 0x10 : SRAM/NOR Flash chip-select control register for memory region 3
$58024014 constant FMC1_S_FMC_BTR3  \ offset: 0x14 : SRAM/NOR Flash chip-select timing registers for memory region 3
$58024018 constant FMC1_S_FMC_BCR4  \ offset: 0x18 : SRAM/NOR Flash chip-select control register for memory region 4
$5802401c constant FMC1_S_FMC_BTR4  \ offset: 0x1C : SRAM/NOR Flash chip-select timing registers for memory region 4
$58024020 constant FMC1_S_FMC_CFGR  \ offset: 0x20 : FMC common configuration register
$58024080 constant FMC1_S_FMC_PCR  \ offset: 0x80 : NAND Flash programmable control register
$58024084 constant FMC1_S_FMC_SR  \ offset: 0x84 : FMC status register
$58024088 constant FMC1_S_FMC_PMEM  \ offset: 0x88 : FMC common memory space timing register
$5802408c constant FMC1_S_FMC_PATT  \ offset: 0x8C : FMC attribute memory space timing registers
$58024090 constant FMC1_S_FMC_HPR  \ offset: 0x90 : FMC Hamming parity result registers
$58024094 constant FMC1_S_FMC_HECCR  \ offset: 0x94 : FMC Hamming code ECC result register
$58024104 constant FMC1_S_FMC_BWTR1  \ offset: 0x104 : SRAM/NOR-Flash write timing registers for memory region 1
$5802410c constant FMC1_S_FMC_BWTR2  \ offset: 0x10C : SRAM/NOR-Flash write timing registers for memory region 2
$58024114 constant FMC1_S_FMC_BWTR3  \ offset: 0x114 : SRAM/NOR-Flash write timing registers for memory region 3
$5802411c constant FMC1_S_FMC_BWTR4  \ offset: 0x11C : SRAM/NOR-Flash write timing registers for memory region 4
$58024140 constant FMC1_S_FMC_SDCR1  \ offset: 0x140 : SDRAM control registers for SDRAM device 1
$58024144 constant FMC1_S_FMC_SDCR2  \ offset: 0x144 : SDRAM control registers for SDRAM device 2
$58024148 constant FMC1_S_FMC_SDTR  \ offset: 0x148 : SDRAM timing register
$58024150 constant FMC1_S_FMC_SDCMR  \ offset: 0x150 : SDRAM command mode register
$58024154 constant FMC1_S_FMC_SDRTR  \ offset: 0x154 : SDRAM refresh timer register
$58024158 constant FMC1_S_FMC_SDSR  \ offset: 0x158 : SDRAM status register
$58024180 constant FMC1_S_FMC_IER  \ offset: 0x180 : FMC NAND interrupt enable register
$58024184 constant FMC1_S_FMC_ISR  \ offset: 0x184 : FMC controller interrupt status register
$58024188 constant FMC1_S_FMC_ICR  \ offset: 0x188 : FMC NAND controller interrupt clear register
$58024200 constant FMC1_S_FMC_CSQCR  \ offset: 0x200 : FMC NAND command sequencer control register
$58024204 constant FMC1_S_FMC_CSQCFGR1  \ offset: 0x204 : FMC NAND command sequencer configuration register 1
$58024208 constant FMC1_S_FMC_CSQCFGR2  \ offset: 0x208 : FMC NAND command sequencer configuration register 2
$5802420c constant FMC1_S_FMC_CSQCFGR3  \ offset: 0x20C : FMC NAND sequencer configuration register 3
$58024210 constant FMC1_S_FMC_CSQAR1  \ offset: 0x210 : FMC NAND command sequencer address register 1
$58024214 constant FMC1_S_FMC_CSQAR2  \ offset: 0x214 : FMC NAND command sequencer address register 2
$58024220 constant FMC1_S_FMC_CSQIER  \ offset: 0x220 : FMC NAND command sequencer interrupt enable register
$58024224 constant FMC1_S_FMC_CSQISR  \ offset: 0x224 : FMC NAND command sequencer interrupt status register
$58024228 constant FMC1_S_FMC_CSQICR  \ offset: 0x228 : FMC NAND command sequencer interrupt clear register
$58024230 constant FMC1_S_FMC_CSQEMSR  \ offset: 0x230 : FMC command sequencer error mapping status register
$58024250 constant FMC1_S_FMC_BCHIER  \ offset: 0x250 : FMC BCH interrupt enable register
$58024254 constant FMC1_S_FMC_BCHISR  \ offset: 0x254 : FMC BCH interrupt and status register
$58024258 constant FMC1_S_FMC_BCHICR  \ offset: 0x258 : FMC BCH interrupt clear register
$58024260 constant FMC1_S_FMC_BCHPBR1  \ offset: 0x260 : FMC BCH parity bits register 1
$58024264 constant FMC1_S_FMC_BCHPBR2  \ offset: 0x264 : FMC BCH parity bits register 2
$58024268 constant FMC1_S_FMC_BCHPBR3  \ offset: 0x268 : FMC BCH parity bits register 3
$5802426c constant FMC1_S_FMC_BCHPBR4  \ offset: 0x26C : FMC BCH parity bits register 4
$5802427c constant FMC1_S_FMC_BCHDSR0  \ offset: 0x27C : FMC BCH decoder status register 0
$58024280 constant FMC1_S_FMC_BCHDSR1  \ offset: 0x280 : FMC BCH decoder status register for memory region 1
$58024284 constant FMC1_S_FMC_BCHDSR2  \ offset: 0x284 : FMC BCH decoder status register for memory region 2
$58024288 constant FMC1_S_FMC_BCHDSR3  \ offset: 0x288 : FMC BCH decoder status register for memory region 3
$5802428c constant FMC1_S_FMC_BCHDSR4  \ offset: 0x28C : FMC BCH decoder status register for memory region 4

