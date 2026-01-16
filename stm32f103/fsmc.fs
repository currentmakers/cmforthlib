\
\ @file fsmc.fs
\ @brief Flexible static memory controller
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

$00000001 constant FSMC_BCR1_MBKEN                                  \ MBKEN
$00000002 constant FSMC_BCR1_MUXEN                                  \ MUXEN
$0000000c constant FSMC_BCR1_MTYP                                   \ MTYP
$00000030 constant FSMC_BCR1_MWID                                   \ MWID
$00000040 constant FSMC_BCR1_FACCEN                                 \ FACCEN
$00000100 constant FSMC_BCR1_BURSTEN                                \ BURSTEN
$00000200 constant FSMC_BCR1_WAITPOL                                \ WAITPOL
$00000800 constant FSMC_BCR1_WAITCFG                                \ WAITCFG
$00001000 constant FSMC_BCR1_WREN                                   \ WREN
$00002000 constant FSMC_BCR1_WAITEN                                 \ WAITEN
$00004000 constant FSMC_BCR1_EXTMOD                                 \ EXTMOD
$00008000 constant FSMC_BCR1_ASYNCWAIT                              \ ASYNCWAIT
$00080000 constant FSMC_BCR1_CBURSTRW                               \ CBURSTRW


\
\ @brief SRAM/NOR-Flash chip-select timing register 1
\ Address offset: 0x04
\ Reset value: 0xFFFFFFFF
\

$0000000f constant FSMC_BTR1_ADDSET                                 \ ADDSET
$000000f0 constant FSMC_BTR1_ADDHLD                                 \ ADDHLD
$0000ff00 constant FSMC_BTR1_DATAST                                 \ DATAST
$000f0000 constant FSMC_BTR1_BUSTURN                                \ BUSTURN
$00f00000 constant FSMC_BTR1_CLKDIV                                 \ CLKDIV
$0f000000 constant FSMC_BTR1_DATLAT                                 \ DATLAT
$30000000 constant FSMC_BTR1_ACCMOD                                 \ ACCMOD


\
\ @brief SRAM/NOR-Flash chip-select control register 2
\ Address offset: 0x08
\ Reset value: 0x000030D0
\

$00000001 constant FSMC_BCR2_MBKEN                                  \ MBKEN
$00000002 constant FSMC_BCR2_MUXEN                                  \ MUXEN
$0000000c constant FSMC_BCR2_MTYP                                   \ MTYP
$00000030 constant FSMC_BCR2_MWID                                   \ MWID
$00000040 constant FSMC_BCR2_FACCEN                                 \ FACCEN
$00000100 constant FSMC_BCR2_BURSTEN                                \ BURSTEN
$00000200 constant FSMC_BCR2_WAITPOL                                \ WAITPOL
$00000400 constant FSMC_BCR2_WRAPMOD                                \ WRAPMOD
$00000800 constant FSMC_BCR2_WAITCFG                                \ WAITCFG
$00001000 constant FSMC_BCR2_WREN                                   \ WREN
$00002000 constant FSMC_BCR2_WAITEN                                 \ WAITEN
$00004000 constant FSMC_BCR2_EXTMOD                                 \ EXTMOD
$00008000 constant FSMC_BCR2_ASYNCWAIT                              \ ASYNCWAIT
$00080000 constant FSMC_BCR2_CBURSTRW                               \ CBURSTRW


\
\ @brief SRAM/NOR-Flash chip-select timing register 2
\ Address offset: 0x0C
\ Reset value: 0xFFFFFFFF
\

$0000000f constant FSMC_BTR2_ADDSET                                 \ ADDSET
$000000f0 constant FSMC_BTR2_ADDHLD                                 \ ADDHLD
$0000ff00 constant FSMC_BTR2_DATAST                                 \ DATAST
$000f0000 constant FSMC_BTR2_BUSTURN                                \ BUSTURN
$00f00000 constant FSMC_BTR2_CLKDIV                                 \ CLKDIV
$0f000000 constant FSMC_BTR2_DATLAT                                 \ DATLAT
$30000000 constant FSMC_BTR2_ACCMOD                                 \ ACCMOD


\
\ @brief SRAM/NOR-Flash chip-select control register 3
\ Address offset: 0x10
\ Reset value: 0x000030D0
\

$00000001 constant FSMC_BCR3_MBKEN                                  \ MBKEN
$00000002 constant FSMC_BCR3_MUXEN                                  \ MUXEN
$0000000c constant FSMC_BCR3_MTYP                                   \ MTYP
$00000030 constant FSMC_BCR3_MWID                                   \ MWID
$00000040 constant FSMC_BCR3_FACCEN                                 \ FACCEN
$00000100 constant FSMC_BCR3_BURSTEN                                \ BURSTEN
$00000200 constant FSMC_BCR3_WAITPOL                                \ WAITPOL
$00000400 constant FSMC_BCR3_WRAPMOD                                \ WRAPMOD
$00000800 constant FSMC_BCR3_WAITCFG                                \ WAITCFG
$00001000 constant FSMC_BCR3_WREN                                   \ WREN
$00002000 constant FSMC_BCR3_WAITEN                                 \ WAITEN
$00004000 constant FSMC_BCR3_EXTMOD                                 \ EXTMOD
$00008000 constant FSMC_BCR3_ASYNCWAIT                              \ ASYNCWAIT
$00080000 constant FSMC_BCR3_CBURSTRW                               \ CBURSTRW


\
\ @brief SRAM/NOR-Flash chip-select timing register 3
\ Address offset: 0x14
\ Reset value: 0xFFFFFFFF
\

$0000000f constant FSMC_BTR3_ADDSET                                 \ ADDSET
$000000f0 constant FSMC_BTR3_ADDHLD                                 \ ADDHLD
$0000ff00 constant FSMC_BTR3_DATAST                                 \ DATAST
$000f0000 constant FSMC_BTR3_BUSTURN                                \ BUSTURN
$00f00000 constant FSMC_BTR3_CLKDIV                                 \ CLKDIV
$0f000000 constant FSMC_BTR3_DATLAT                                 \ DATLAT
$30000000 constant FSMC_BTR3_ACCMOD                                 \ ACCMOD


\
\ @brief SRAM/NOR-Flash chip-select control register 4
\ Address offset: 0x18
\ Reset value: 0x000030D0
\

$00000001 constant FSMC_BCR4_MBKEN                                  \ MBKEN
$00000002 constant FSMC_BCR4_MUXEN                                  \ MUXEN
$0000000c constant FSMC_BCR4_MTYP                                   \ MTYP
$00000030 constant FSMC_BCR4_MWID                                   \ MWID
$00000040 constant FSMC_BCR4_FACCEN                                 \ FACCEN
$00000100 constant FSMC_BCR4_BURSTEN                                \ BURSTEN
$00000200 constant FSMC_BCR4_WAITPOL                                \ WAITPOL
$00000400 constant FSMC_BCR4_WRAPMOD                                \ WRAPMOD
$00000800 constant FSMC_BCR4_WAITCFG                                \ WAITCFG
$00001000 constant FSMC_BCR4_WREN                                   \ WREN
$00002000 constant FSMC_BCR4_WAITEN                                 \ WAITEN
$00004000 constant FSMC_BCR4_EXTMOD                                 \ EXTMOD
$00008000 constant FSMC_BCR4_ASYNCWAIT                              \ ASYNCWAIT
$00080000 constant FSMC_BCR4_CBURSTRW                               \ CBURSTRW


\
\ @brief SRAM/NOR-Flash chip-select timing register 4
\ Address offset: 0x1C
\ Reset value: 0xFFFFFFFF
\

$0000000f constant FSMC_BTR4_ADDSET                                 \ ADDSET
$000000f0 constant FSMC_BTR4_ADDHLD                                 \ ADDHLD
$0000ff00 constant FSMC_BTR4_DATAST                                 \ DATAST
$000f0000 constant FSMC_BTR4_BUSTURN                                \ BUSTURN
$00f00000 constant FSMC_BTR4_CLKDIV                                 \ CLKDIV
$0f000000 constant FSMC_BTR4_DATLAT                                 \ DATLAT
$30000000 constant FSMC_BTR4_ACCMOD                                 \ ACCMOD


\
\ @brief PC Card/NAND Flash control register 2
\ Address offset: 0x60
\ Reset value: 0x00000018
\

$00000002 constant FSMC_PCR2_PWAITEN                                \ PWAITEN
$00000004 constant FSMC_PCR2_PBKEN                                  \ PBKEN
$00000008 constant FSMC_PCR2_PTYP                                   \ PTYP
$00000030 constant FSMC_PCR2_PWID                                   \ PWID
$00000040 constant FSMC_PCR2_ECCEN                                  \ ECCEN
$00001e00 constant FSMC_PCR2_TCLR                                   \ TCLR
$0001e000 constant FSMC_PCR2_TAR                                    \ TAR
$000e0000 constant FSMC_PCR2_ECCPS                                  \ ECCPS


\
\ @brief FIFO status and interrupt register 2
\ Address offset: 0x64
\ Reset value: 0x00000040
\

$00000001 constant FSMC_SR2_IRS                                     \ IRS
$00000002 constant FSMC_SR2_ILS                                     \ ILS
$00000004 constant FSMC_SR2_IFS                                     \ IFS
$00000008 constant FSMC_SR2_IREN                                    \ IREN
$00000010 constant FSMC_SR2_ILEN                                    \ ILEN
$00000020 constant FSMC_SR2_IFEN                                    \ IFEN
$00000040 constant FSMC_SR2_FEMPT                                   \ FEMPT


\
\ @brief Common memory space timing register 2
\ Address offset: 0x68
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FSMC_PMEM2_MEMSETX                               \ MEMSETx
$0000ff00 constant FSMC_PMEM2_MEMWAITX                              \ MEMWAITx
$00ff0000 constant FSMC_PMEM2_MEMHOLDX                              \ MEMHOLDx
$ff000000 constant FSMC_PMEM2_MEMHIZX                               \ MEMHIZx


\
\ @brief Attribute memory space timing register 2
\ Address offset: 0x6C
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FSMC_PATT2_ATTSETX                               \ Attribute memory x setup time
$0000ff00 constant FSMC_PATT2_ATTWAITX                              \ Attribute memory x wait time
$00ff0000 constant FSMC_PATT2_ATTHOLDX                              \ Attribute memory x hold time
$ff000000 constant FSMC_PATT2_ATTHIZX                               \ Attribute memory x databus HiZ time


\
\ @brief ECC result register 2
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant FSMC_ECCR2_ECCX                                  \ ECC result


\
\ @brief PC Card/NAND Flash control register 3
\ Address offset: 0x80
\ Reset value: 0x00000018
\

$00000002 constant FSMC_PCR3_PWAITEN                                \ PWAITEN
$00000004 constant FSMC_PCR3_PBKEN                                  \ PBKEN
$00000008 constant FSMC_PCR3_PTYP                                   \ PTYP
$00000030 constant FSMC_PCR3_PWID                                   \ PWID
$00000040 constant FSMC_PCR3_ECCEN                                  \ ECCEN
$00001e00 constant FSMC_PCR3_TCLR                                   \ TCLR
$0001e000 constant FSMC_PCR3_TAR                                    \ TAR
$000e0000 constant FSMC_PCR3_ECCPS                                  \ ECCPS


\
\ @brief FIFO status and interrupt register 3
\ Address offset: 0x84
\ Reset value: 0x00000040
\

$00000001 constant FSMC_SR3_IRS                                     \ IRS
$00000002 constant FSMC_SR3_ILS                                     \ ILS
$00000004 constant FSMC_SR3_IFS                                     \ IFS
$00000008 constant FSMC_SR3_IREN                                    \ IREN
$00000010 constant FSMC_SR3_ILEN                                    \ ILEN
$00000020 constant FSMC_SR3_IFEN                                    \ IFEN
$00000040 constant FSMC_SR3_FEMPT                                   \ FEMPT


\
\ @brief Common memory space timing register 3
\ Address offset: 0x88
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FSMC_PMEM3_MEMSETX                               \ MEMSETx
$0000ff00 constant FSMC_PMEM3_MEMWAITX                              \ MEMWAITx
$00ff0000 constant FSMC_PMEM3_MEMHOLDX                              \ MEMHOLDx
$ff000000 constant FSMC_PMEM3_MEMHIZX                               \ MEMHIZx


\
\ @brief Attribute memory space timing register 3
\ Address offset: 0x8C
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FSMC_PATT3_ATTSETX                               \ ATTSETx
$0000ff00 constant FSMC_PATT3_ATTWAITX                              \ ATTWAITx
$00ff0000 constant FSMC_PATT3_ATTHOLDX                              \ ATTHOLDx
$ff000000 constant FSMC_PATT3_ATTHIZX                               \ ATTHIZx


\
\ @brief ECC result register 3
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant FSMC_ECCR3_ECCX                                  \ ECCx


\
\ @brief PC Card/NAND Flash control register 4
\ Address offset: 0xA0
\ Reset value: 0x00000018
\

$00000002 constant FSMC_PCR4_PWAITEN                                \ PWAITEN
$00000004 constant FSMC_PCR4_PBKEN                                  \ PBKEN
$00000008 constant FSMC_PCR4_PTYP                                   \ PTYP
$00000030 constant FSMC_PCR4_PWID                                   \ PWID
$00000040 constant FSMC_PCR4_ECCEN                                  \ ECCEN
$00001e00 constant FSMC_PCR4_TCLR                                   \ TCLR
$0001e000 constant FSMC_PCR4_TAR                                    \ TAR
$000e0000 constant FSMC_PCR4_ECCPS                                  \ ECCPS


\
\ @brief FIFO status and interrupt register 4
\ Address offset: 0xA4
\ Reset value: 0x00000040
\

$00000001 constant FSMC_SR4_IRS                                     \ IRS
$00000002 constant FSMC_SR4_ILS                                     \ ILS
$00000004 constant FSMC_SR4_IFS                                     \ IFS
$00000008 constant FSMC_SR4_IREN                                    \ IREN
$00000010 constant FSMC_SR4_ILEN                                    \ ILEN
$00000020 constant FSMC_SR4_IFEN                                    \ IFEN
$00000040 constant FSMC_SR4_FEMPT                                   \ FEMPT


\
\ @brief Common memory space timing register 4
\ Address offset: 0xA8
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FSMC_PMEM4_MEMSETX                               \ MEMSETx
$0000ff00 constant FSMC_PMEM4_MEMWAITX                              \ MEMWAITx
$00ff0000 constant FSMC_PMEM4_MEMHOLDX                              \ MEMHOLDx
$ff000000 constant FSMC_PMEM4_MEMHIZX                               \ MEMHIZx


\
\ @brief Attribute memory space timing register 4
\ Address offset: 0xAC
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FSMC_PATT4_ATTSETX                               \ ATTSETx
$0000ff00 constant FSMC_PATT4_ATTWAITX                              \ ATTWAITx
$00ff0000 constant FSMC_PATT4_ATTHOLDX                              \ ATTHOLDx
$ff000000 constant FSMC_PATT4_ATTHIZX                               \ ATTHIZx


\
\ @brief I/O space timing register 4
\ Address offset: 0xB0
\ Reset value: 0xFCFCFCFC
\

$000000ff constant FSMC_PIO4_IOSETX                                 \ IOSETx
$0000ff00 constant FSMC_PIO4_IOWAITX                                \ IOWAITx
$00ff0000 constant FSMC_PIO4_IOHOLDX                                \ IOHOLDx
$ff000000 constant FSMC_PIO4_IOHIZX                                 \ IOHIZx


\
\ @brief SRAM/NOR-Flash write timing registers 1
\ Address offset: 0x104
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FSMC_BWTR1_ADDSET                                \ ADDSET
$000000f0 constant FSMC_BWTR1_ADDHLD                                \ ADDHLD
$0000ff00 constant FSMC_BWTR1_DATAST                                \ DATAST
$00f00000 constant FSMC_BWTR1_CLKDIV                                \ CLKDIV
$0f000000 constant FSMC_BWTR1_DATLAT                                \ DATLAT
$30000000 constant FSMC_BWTR1_ACCMOD                                \ ACCMOD


\
\ @brief SRAM/NOR-Flash write timing registers 2
\ Address offset: 0x10C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FSMC_BWTR2_ADDSET                                \ ADDSET
$000000f0 constant FSMC_BWTR2_ADDHLD                                \ ADDHLD
$0000ff00 constant FSMC_BWTR2_DATAST                                \ DATAST
$00f00000 constant FSMC_BWTR2_CLKDIV                                \ CLKDIV
$0f000000 constant FSMC_BWTR2_DATLAT                                \ DATLAT
$30000000 constant FSMC_BWTR2_ACCMOD                                \ ACCMOD


\
\ @brief SRAM/NOR-Flash write timing registers 3
\ Address offset: 0x114
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FSMC_BWTR3_ADDSET                                \ ADDSET
$000000f0 constant FSMC_BWTR3_ADDHLD                                \ ADDHLD
$0000ff00 constant FSMC_BWTR3_DATAST                                \ DATAST
$00f00000 constant FSMC_BWTR3_CLKDIV                                \ CLKDIV
$0f000000 constant FSMC_BWTR3_DATLAT                                \ DATLAT
$30000000 constant FSMC_BWTR3_ACCMOD                                \ ACCMOD


\
\ @brief SRAM/NOR-Flash write timing registers 4
\ Address offset: 0x11C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FSMC_BWTR4_ADDSET                                \ ADDSET
$000000f0 constant FSMC_BWTR4_ADDHLD                                \ ADDHLD
$0000ff00 constant FSMC_BWTR4_DATAST                                \ DATAST
$00f00000 constant FSMC_BWTR4_CLKDIV                                \ CLKDIV
$0f000000 constant FSMC_BWTR4_DATLAT                                \ DATLAT
$30000000 constant FSMC_BWTR4_ACCMOD                                \ ACCMOD


\
\ @brief Flexible static memory controller
\
$a0000000 constant FSMC_BCR1      \ offset: 0x00 : SRAM/NOR-Flash chip-select control register 1
$a0000004 constant FSMC_BTR1      \ offset: 0x04 : SRAM/NOR-Flash chip-select timing register 1
$a0000008 constant FSMC_BCR2      \ offset: 0x08 : SRAM/NOR-Flash chip-select control register 2
$a000000c constant FSMC_BTR2      \ offset: 0x0C : SRAM/NOR-Flash chip-select timing register 2
$a0000010 constant FSMC_BCR3      \ offset: 0x10 : SRAM/NOR-Flash chip-select control register 3
$a0000014 constant FSMC_BTR3      \ offset: 0x14 : SRAM/NOR-Flash chip-select timing register 3
$a0000018 constant FSMC_BCR4      \ offset: 0x18 : SRAM/NOR-Flash chip-select control register 4
$a000001c constant FSMC_BTR4      \ offset: 0x1C : SRAM/NOR-Flash chip-select timing register 4
$a0000060 constant FSMC_PCR2      \ offset: 0x60 : PC Card/NAND Flash control register 2
$a0000064 constant FSMC_SR2       \ offset: 0x64 : FIFO status and interrupt register 2
$a0000068 constant FSMC_PMEM2     \ offset: 0x68 : Common memory space timing register 2
$a000006c constant FSMC_PATT2     \ offset: 0x6C : Attribute memory space timing register 2
$a0000074 constant FSMC_ECCR2     \ offset: 0x74 : ECC result register 2
$a0000080 constant FSMC_PCR3      \ offset: 0x80 : PC Card/NAND Flash control register 3
$a0000084 constant FSMC_SR3       \ offset: 0x84 : FIFO status and interrupt register 3
$a0000088 constant FSMC_PMEM3     \ offset: 0x88 : Common memory space timing register 3
$a000008c constant FSMC_PATT3     \ offset: 0x8C : Attribute memory space timing register 3
$a0000094 constant FSMC_ECCR3     \ offset: 0x94 : ECC result register 3
$a00000a0 constant FSMC_PCR4      \ offset: 0xA0 : PC Card/NAND Flash control register 4
$a00000a4 constant FSMC_SR4       \ offset: 0xA4 : FIFO status and interrupt register 4
$a00000a8 constant FSMC_PMEM4     \ offset: 0xA8 : Common memory space timing register 4
$a00000ac constant FSMC_PATT4     \ offset: 0xAC : Attribute memory space timing register 4
$a00000b0 constant FSMC_PIO4      \ offset: 0xB0 : I/O space timing register 4
$a0000104 constant FSMC_BWTR1     \ offset: 0x104 : SRAM/NOR-Flash write timing registers 1
$a000010c constant FSMC_BWTR2     \ offset: 0x10C : SRAM/NOR-Flash write timing registers 2
$a0000114 constant FSMC_BWTR3     \ offset: 0x114 : SRAM/NOR-Flash write timing registers 3
$a000011c constant FSMC_BWTR4     \ offset: 0x11C : SRAM/NOR-Flash write timing registers 4

