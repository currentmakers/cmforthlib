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
$a0000104 constant FSMC_BWTR1     \ offset: 0x104 : SRAM/NOR-Flash write timing registers 1
$a000010c constant FSMC_BWTR2     \ offset: 0x10C : SRAM/NOR-Flash write timing registers 2
$a0000114 constant FSMC_BWTR3     \ offset: 0x114 : SRAM/NOR-Flash write timing registers 3
$a000011c constant FSMC_BWTR4     \ offset: 0x11C : SRAM/NOR-Flash write timing registers 4

