\
\ @file fmc.fs
\ @brief Flexible memory controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SRAM/NOR-Flash chip-select control register 1
\ Address offset: 0x00
\ Reset value: 0x000030D0
\

$00000001 constant FMC_BCR1_MBKEN                                   \ MBKEN
$00000002 constant FMC_BCR1_MUXEN                                   \ MUXEN
$0000000c constant FMC_BCR1_MTYP                                    \ MTYP
$00000030 constant FMC_BCR1_MWID                                    \ MWID
$00000040 constant FMC_BCR1_FACCEN                                  \ FACCEN
$00000100 constant FMC_BCR1_BURSTEN                                 \ BURSTEN
$00000200 constant FMC_BCR1_WAITPOL                                 \ WAITPOL
$00000800 constant FMC_BCR1_WAITCFG                                 \ WAITCFG
$00001000 constant FMC_BCR1_WREN                                    \ WREN
$00002000 constant FMC_BCR1_WAITEN                                  \ WAITEN
$00004000 constant FMC_BCR1_EXTMOD                                  \ EXTMOD
$00008000 constant FMC_BCR1_ASYNCWAIT                               \ ASYNCWAIT
$00080000 constant FMC_BCR1_CBURSTRW                                \ CBURSTRW
$00100000 constant FMC_BCR1_CCLKEN                                  \ CCLKEN


\
\ @brief SRAM/NOR-Flash chip-select timing register 1
\ Address offset: 0x04
\ Reset value: 0xFFFFFFFF
\

$0000000f constant FMC_BTR1_ADDSET                                  \ ADDSET
$000000f0 constant FMC_BTR1_ADDHLD                                  \ ADDHLD
$0000ff00 constant FMC_BTR1_DATAST                                  \ DATAST
$000f0000 constant FMC_BTR1_BUSTURN                                 \ BUSTURN
$00f00000 constant FMC_BTR1_CLKDIV                                  \ CLKDIV
$0f000000 constant FMC_BTR1_DATLAT                                  \ DATLAT
$30000000 constant FMC_BTR1_ACCMOD                                  \ ACCMOD


\
\ @brief SRAM/NOR-Flash chip-select control register 2
\ Address offset: 0x08
\ Reset value: 0x000030D0
\

$00000001 constant FMC_BCR2_MBKEN                                   \ MBKEN
$00000002 constant FMC_BCR2_MUXEN                                   \ MUXEN
$0000000c constant FMC_BCR2_MTYP                                    \ MTYP
$00000030 constant FMC_BCR2_MWID                                    \ MWID
$00000040 constant FMC_BCR2_FACCEN                                  \ FACCEN
$00000100 constant FMC_BCR2_BURSTEN                                 \ BURSTEN
$00000200 constant FMC_BCR2_WAITPOL                                 \ WAITPOL
$00000400 constant FMC_BCR2_WRAPMOD                                 \ WRAPMOD
$00000800 constant FMC_BCR2_WAITCFG                                 \ WAITCFG
$00001000 constant FMC_BCR2_WREN                                    \ WREN
$00002000 constant FMC_BCR2_WAITEN                                  \ WAITEN
$00004000 constant FMC_BCR2_EXTMOD                                  \ EXTMOD
$00008000 constant FMC_BCR2_ASYNCWAIT                               \ ASYNCWAIT
$00080000 constant FMC_BCR2_CBURSTRW                                \ CBURSTRW


\
\ @brief SRAM/NOR-Flash chip-select timing register 2
\ Address offset: 0x0C
\ Reset value: 0xFFFFFFFF
\

$0000000f constant FMC_BTR2_ADDSET                                  \ ADDSET
$000000f0 constant FMC_BTR2_ADDHLD                                  \ ADDHLD
$0000ff00 constant FMC_BTR2_DATAST                                  \ DATAST
$000f0000 constant FMC_BTR2_BUSTURN                                 \ BUSTURN
$00f00000 constant FMC_BTR2_CLKDIV                                  \ CLKDIV
$0f000000 constant FMC_BTR2_DATLAT                                  \ DATLAT
$30000000 constant FMC_BTR2_ACCMOD                                  \ ACCMOD


\
\ @brief SRAM/NOR-Flash chip-select control register 3
\ Address offset: 0x10
\ Reset value: 0x000030D0
\

$00000001 constant FMC_BCR3_MBKEN                                   \ MBKEN
$00000002 constant FMC_BCR3_MUXEN                                   \ MUXEN
$0000000c constant FMC_BCR3_MTYP                                    \ MTYP
$00000030 constant FMC_BCR3_MWID                                    \ MWID
$00000040 constant FMC_BCR3_FACCEN                                  \ FACCEN
$00000100 constant FMC_BCR3_BURSTEN                                 \ BURSTEN
$00000200 constant FMC_BCR3_WAITPOL                                 \ WAITPOL
$00000400 constant FMC_BCR3_WRAPMOD                                 \ WRAPMOD
$00000800 constant FMC_BCR3_WAITCFG                                 \ WAITCFG
$00001000 constant FMC_BCR3_WREN                                    \ WREN
$00002000 constant FMC_BCR3_WAITEN                                  \ WAITEN
$00004000 constant FMC_BCR3_EXTMOD                                  \ EXTMOD
$00008000 constant FMC_BCR3_ASYNCWAIT                               \ ASYNCWAIT
$00080000 constant FMC_BCR3_CBURSTRW                                \ CBURSTRW


\
\ @brief SRAM/NOR-Flash chip-select timing register 3
\ Address offset: 0x14
\ Reset value: 0xFFFFFFFF
\

$0000000f constant FMC_BTR3_ADDSET                                  \ ADDSET
$000000f0 constant FMC_BTR3_ADDHLD                                  \ ADDHLD
$0000ff00 constant FMC_BTR3_DATAST                                  \ DATAST
$000f0000 constant FMC_BTR3_BUSTURN                                 \ BUSTURN
$00f00000 constant FMC_BTR3_CLKDIV                                  \ CLKDIV
$0f000000 constant FMC_BTR3_DATLAT                                  \ DATLAT
$30000000 constant FMC_BTR3_ACCMOD                                  \ ACCMOD


\
\ @brief SRAM/NOR-Flash chip-select control register 4
\ Address offset: 0x18
\ Reset value: 0x000030D0
\

$00000001 constant FMC_BCR4_MBKEN                                   \ MBKEN
$00000002 constant FMC_BCR4_MUXEN                                   \ MUXEN
$0000000c constant FMC_BCR4_MTYP                                    \ MTYP
$00000030 constant FMC_BCR4_MWID                                    \ MWID
$00000040 constant FMC_BCR4_FACCEN                                  \ FACCEN
$00000100 constant FMC_BCR4_BURSTEN                                 \ BURSTEN
$00000200 constant FMC_BCR4_WAITPOL                                 \ WAITPOL
$00000400 constant FMC_BCR4_WRAPMOD                                 \ WRAPMOD
$00000800 constant FMC_BCR4_WAITCFG                                 \ WAITCFG
$00001000 constant FMC_BCR4_WREN                                    \ WREN
$00002000 constant FMC_BCR4_WAITEN                                  \ WAITEN
$00004000 constant FMC_BCR4_EXTMOD                                  \ EXTMOD
$00008000 constant FMC_BCR4_ASYNCWAIT                               \ ASYNCWAIT
$00080000 constant FMC_BCR4_CBURSTRW                                \ CBURSTRW


\
\ @brief SRAM/NOR-Flash chip-select timing register 4
\ Address offset: 0x1C
\ Reset value: 0xFFFFFFFF
\

$0000000f constant FMC_BTR4_ADDSET                                  \ ADDSET
$000000f0 constant FMC_BTR4_ADDHLD                                  \ ADDHLD
$0000ff00 constant FMC_BTR4_DATAST                                  \ DATAST
$000f0000 constant FMC_BTR4_BUSTURN                                 \ BUSTURN
$00f00000 constant FMC_BTR4_CLKDIV                                  \ CLKDIV
$0f000000 constant FMC_BTR4_DATLAT                                  \ DATLAT
$30000000 constant FMC_BTR4_ACCMOD                                  \ ACCMOD


\
\ @brief PC Card/NAND Flash control register
\ Address offset: 0x80
\ Reset value: 0x00000018
\

$00000002 constant FMC_PCR_PWAITEN                                  \ PWAITEN
$00000004 constant FMC_PCR_PBKEN                                    \ PBKEN
$00000008 constant FMC_PCR_PTYP                                     \ PTYP
$00000030 constant FMC_PCR_PWID                                     \ PWID
$00000040 constant FMC_PCR_ECCEN                                    \ ECCEN
$00001e00 constant FMC_PCR_TCLR                                     \ TCLR
$0001e000 constant FMC_PCR_TAR                                      \ TAR
$000e0000 constant FMC_PCR_ECCPS                                    \ ECCPS


\
\ @brief FIFO status and interrupt register
\ Address offset: 0x84
\ Reset value: 0x00000040
\

$00000001 constant FMC_SR_IRS                                       \ IRS
$00000002 constant FMC_SR_ILS                                       \ ILS
$00000004 constant FMC_SR_IFS                                       \ IFS
$00000008 constant FMC_SR_IREN                                      \ IREN
$00000010 constant FMC_SR_ILEN                                      \ ILEN
$00000020 constant FMC_SR_IFEN                                      \ IFEN
$00000040 constant FMC_SR_FEMPT                                     \ FEMPT


\
\ @brief Common memory space timing register
\ Address offset: 0x88
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FMC_PMEM_MEMSETX                                 \ MEMSETx
$0000ff00 constant FMC_PMEM_MEMWAITX                                \ MEMWAITx
$00ff0000 constant FMC_PMEM_MEMHOLDX                                \ MEMHOLDx
$ff000000 constant FMC_PMEM_MEMHIZX                                 \ MEMHIZx


\
\ @brief Attribute memory space timing register
\ Address offset: 0x8C
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FMC_PATT_ATTSETX                                 \ ATTSETx
$0000ff00 constant FMC_PATT_ATTWAITX                                \ ATTWAITx
$00ff0000 constant FMC_PATT_ATTHOLDX                                \ ATTHOLDx
$ff000000 constant FMC_PATT_ATTHIZX                                 \ ATTHIZx


\
\ @brief ECC result register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant FMC_ECCR_ECCX                                    \ ECCx


\
\ @brief SRAM/NOR-Flash write timing registers 1
\ Address offset: 0x104
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BWTR1_ADDSET                                 \ ADDSET
$000000f0 constant FMC_BWTR1_ADDHLD                                 \ ADDHLD
$0000ff00 constant FMC_BWTR1_DATAST                                 \ DATAST
$00f00000 constant FMC_BWTR1_CLKDIV                                 \ CLKDIV
$0f000000 constant FMC_BWTR1_DATLAT                                 \ DATLAT
$30000000 constant FMC_BWTR1_ACCMOD                                 \ ACCMOD


\
\ @brief SRAM/NOR-Flash write timing registers 2
\ Address offset: 0x10C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BWTR2_ADDSET                                 \ ADDSET
$000000f0 constant FMC_BWTR2_ADDHLD                                 \ ADDHLD
$0000ff00 constant FMC_BWTR2_DATAST                                 \ DATAST
$00f00000 constant FMC_BWTR2_CLKDIV                                 \ CLKDIV
$0f000000 constant FMC_BWTR2_DATLAT                                 \ DATLAT
$30000000 constant FMC_BWTR2_ACCMOD                                 \ ACCMOD


\
\ @brief SRAM/NOR-Flash write timing registers 3
\ Address offset: 0x114
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BWTR3_ADDSET                                 \ ADDSET
$000000f0 constant FMC_BWTR3_ADDHLD                                 \ ADDHLD
$0000ff00 constant FMC_BWTR3_DATAST                                 \ DATAST
$00f00000 constant FMC_BWTR3_CLKDIV                                 \ CLKDIV
$0f000000 constant FMC_BWTR3_DATLAT                                 \ DATLAT
$30000000 constant FMC_BWTR3_ACCMOD                                 \ ACCMOD


\
\ @brief SRAM/NOR-Flash write timing registers 4
\ Address offset: 0x11C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_BWTR4_ADDSET                                 \ ADDSET
$000000f0 constant FMC_BWTR4_ADDHLD                                 \ ADDHLD
$0000ff00 constant FMC_BWTR4_DATAST                                 \ DATAST
$00f00000 constant FMC_BWTR4_CLKDIV                                 \ CLKDIV
$0f000000 constant FMC_BWTR4_DATLAT                                 \ DATLAT
$30000000 constant FMC_BWTR4_ACCMOD                                 \ ACCMOD


\
\ @brief SDRAM Control Register 1
\ Address offset: 0x140
\ Reset value: 0x000002D0
\

$00000003 constant FMC_SDCR1_NC                                     \ Number of column address bits
$0000000c constant FMC_SDCR1_NR                                     \ Number of row address bits
$00000030 constant FMC_SDCR1_MWID                                   \ Memory data bus width
$00000040 constant FMC_SDCR1_NB                                     \ Number of internal banks
$00000180 constant FMC_SDCR1_CAS                                    \ CAS latency
$00000200 constant FMC_SDCR1_WP                                     \ Write protection
$00000c00 constant FMC_SDCR1_SDCLK                                  \ SDRAM clock configuration
$00001000 constant FMC_SDCR1_RBURST                                 \ Burst read
$00006000 constant FMC_SDCR1_RPIPE                                  \ Read pipe


\
\ @brief SDRAM Control Register 2
\ Address offset: 0x144
\ Reset value: 0x000002D0
\

$00000003 constant FMC_SDCR2_NC                                     \ Number of column address bits
$0000000c constant FMC_SDCR2_NR                                     \ Number of row address bits
$00000030 constant FMC_SDCR2_MWID                                   \ Memory data bus width
$00000040 constant FMC_SDCR2_NB                                     \ Number of internal banks
$00000180 constant FMC_SDCR2_CAS                                    \ CAS latency
$00000200 constant FMC_SDCR2_WP                                     \ Write protection
$00000c00 constant FMC_SDCR2_SDCLK                                  \ SDRAM clock configuration
$00001000 constant FMC_SDCR2_RBURST                                 \ Burst read
$00006000 constant FMC_SDCR2_RPIPE                                  \ Read pipe


\
\ @brief SDRAM Timing register 1
\ Address offset: 0x148
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_SDTR1_TMRD                                   \ Load Mode Register to Active
$000000f0 constant FMC_SDTR1_TXSR                                   \ Exit self-refresh delay
$00000f00 constant FMC_SDTR1_TRAS                                   \ Self refresh time
$0000f000 constant FMC_SDTR1_TRC                                    \ Row cycle delay
$000f0000 constant FMC_SDTR1_TWR                                    \ Recovery delay
$00f00000 constant FMC_SDTR1_TRP                                    \ Row precharge delay
$0f000000 constant FMC_SDTR1_TRCD                                   \ Row to column delay


\
\ @brief SDRAM Timing register 2
\ Address offset: 0x14C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_SDTR2_TMRD                                   \ Load Mode Register to Active
$000000f0 constant FMC_SDTR2_TXSR                                   \ Exit self-refresh delay
$00000f00 constant FMC_SDTR2_TRAS                                   \ Self refresh time
$0000f000 constant FMC_SDTR2_TRC                                    \ Row cycle delay
$000f0000 constant FMC_SDTR2_TWR                                    \ Recovery delay
$00f00000 constant FMC_SDTR2_TRP                                    \ Row precharge delay
$0f000000 constant FMC_SDTR2_TRCD                                   \ Row to column delay


\
\ @brief SDRAM Command Mode register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000007 constant FMC_SDCMR_MODE                                   \ Command mode
$00000008 constant FMC_SDCMR_CTB2                                   \ Command target bank 2
$00000010 constant FMC_SDCMR_CTB1                                   \ Command target bank 1
$000001e0 constant FMC_SDCMR_NRFS                                   \ Number of Auto-refresh
$003ffe00 constant FMC_SDCMR_MRD                                    \ Mode Register definition


\
\ @brief SDRAM Refresh Timer register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000001 constant FMC_SDRTR_CRE                                    \ Clear Refresh error flag
$00003ffe constant FMC_SDRTR_COUNT                                  \ Refresh Timer Count
$00004000 constant FMC_SDRTR_REIE                                   \ RES Interrupt Enable


\
\ @brief SDRAM Status register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000001 constant FMC_SDSR_RE                                      \ Refresh error flag
$00000006 constant FMC_SDSR_MODES1                                  \ Status Mode for Bank 1
$00000018 constant FMC_SDSR_MODES2                                  \ Status Mode for Bank 2
$00000020 constant FMC_SDSR_BUSY                                    \ Busy status


\
\ @brief Flexible memory controller
\
$a0000000 constant FMC_BCR1       \ offset: 0x00 : SRAM/NOR-Flash chip-select control register 1
$a0000004 constant FMC_BTR1       \ offset: 0x04 : SRAM/NOR-Flash chip-select timing register 1
$a0000008 constant FMC_BCR2       \ offset: 0x08 : SRAM/NOR-Flash chip-select control register 2
$a000000c constant FMC_BTR2       \ offset: 0x0C : SRAM/NOR-Flash chip-select timing register 2
$a0000010 constant FMC_BCR3       \ offset: 0x10 : SRAM/NOR-Flash chip-select control register 3
$a0000014 constant FMC_BTR3       \ offset: 0x14 : SRAM/NOR-Flash chip-select timing register 3
$a0000018 constant FMC_BCR4       \ offset: 0x18 : SRAM/NOR-Flash chip-select control register 4
$a000001c constant FMC_BTR4       \ offset: 0x1C : SRAM/NOR-Flash chip-select timing register 4
$a0000080 constant FMC_PCR        \ offset: 0x80 : PC Card/NAND Flash control register
$a0000084 constant FMC_SR         \ offset: 0x84 : FIFO status and interrupt register
$a0000088 constant FMC_PMEM       \ offset: 0x88 : Common memory space timing register
$a000008c constant FMC_PATT       \ offset: 0x8C : Attribute memory space timing register
$a0000094 constant FMC_ECCR       \ offset: 0x94 : ECC result register
$a0000104 constant FMC_BWTR1      \ offset: 0x104 : SRAM/NOR-Flash write timing registers 1
$a000010c constant FMC_BWTR2      \ offset: 0x10C : SRAM/NOR-Flash write timing registers 2
$a0000114 constant FMC_BWTR3      \ offset: 0x114 : SRAM/NOR-Flash write timing registers 3
$a000011c constant FMC_BWTR4      \ offset: 0x11C : SRAM/NOR-Flash write timing registers 4
$a0000140 constant FMC_SDCR1      \ offset: 0x140 : SDRAM Control Register 1
$a0000144 constant FMC_SDCR2      \ offset: 0x144 : SDRAM Control Register 2
$a0000148 constant FMC_SDTR1      \ offset: 0x148 : SDRAM Timing register 1
$a000014c constant FMC_SDTR2      \ offset: 0x14C : SDRAM Timing register 2
$a0000150 constant FMC_SDCMR      \ offset: 0x150 : SDRAM Command Mode register
$a0000154 constant FMC_SDRTR      \ offset: 0x154 : SDRAM Refresh Timer register
$a0000158 constant FMC_SDSR       \ offset: 0x158 : SDRAM Status register

