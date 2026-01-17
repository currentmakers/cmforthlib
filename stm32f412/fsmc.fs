\
\ @file fsmc.fs
\ @brief Flexible static memory controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FSMC_DEF

  [ifdef] FSMC_BCR1_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register 1
    \ Address offset: 0x00
    \ Reset value: 0x000030D0
    \
    $00 constant FSMC_MBKEN                     \ [0x00] MBKEN
    $01 constant FSMC_MUXEN                     \ [0x01] MUXEN
    $02 constant FSMC_MTYP                      \ [0x02 : 2] MTYP
    $04 constant FSMC_MWID                      \ [0x04 : 2] MWID
    $06 constant FSMC_FACCEN                    \ [0x06] FACCEN
    $08 constant FSMC_BURSTEN                   \ [0x08] BURSTEN
    $09 constant FSMC_WAITPOL                   \ [0x09] WAITPOL
    $0b constant FSMC_WAITCFG                   \ [0x0b] WAITCFG
    $0c constant FSMC_WREN                      \ [0x0c] WREN
    $0d constant FSMC_WAITEN                    \ [0x0d] WAITEN
    $0e constant FSMC_EXTMOD                    \ [0x0e] EXTMOD
    $0f constant FSMC_ASYNCWAIT                 \ [0x0f] ASYNCWAIT
    $13 constant FSMC_CBURSTRW                  \ [0x13] CBURSTRW
  [then]


  [ifdef] FSMC_BTR1_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register 1
    \ Address offset: 0x04
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] ADDSET
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] ADDHLD
    $08 constant FSMC_DATAST                    \ [0x08 : 8] DATAST
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] BUSTURN
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] CLKDIV
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] DATLAT
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FSMC_BCR2_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register 2
    \ Address offset: 0x08
    \ Reset value: 0x000030D0
    \
    $00 constant FSMC_MBKEN                     \ [0x00] MBKEN
    $01 constant FSMC_MUXEN                     \ [0x01] MUXEN
    $02 constant FSMC_MTYP                      \ [0x02 : 2] MTYP
    $04 constant FSMC_MWID                      \ [0x04 : 2] MWID
    $06 constant FSMC_FACCEN                    \ [0x06] FACCEN
    $08 constant FSMC_BURSTEN                   \ [0x08] BURSTEN
    $09 constant FSMC_WAITPOL                   \ [0x09] WAITPOL
    $0a constant FSMC_WRAPMOD                   \ [0x0a] WRAPMOD
    $0b constant FSMC_WAITCFG                   \ [0x0b] WAITCFG
    $0c constant FSMC_WREN                      \ [0x0c] WREN
    $0d constant FSMC_WAITEN                    \ [0x0d] WAITEN
    $0e constant FSMC_EXTMOD                    \ [0x0e] EXTMOD
    $0f constant FSMC_ASYNCWAIT                 \ [0x0f] ASYNCWAIT
    $13 constant FSMC_CBURSTRW                  \ [0x13] CBURSTRW
  [then]


  [ifdef] FSMC_BTR2_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register 2
    \ Address offset: 0x0C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] ADDSET
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] ADDHLD
    $08 constant FSMC_DATAST                    \ [0x08 : 8] DATAST
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] BUSTURN
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] CLKDIV
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] DATLAT
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FSMC_BCR3_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register 3
    \ Address offset: 0x10
    \ Reset value: 0x000030D0
    \
    $00 constant FSMC_MBKEN                     \ [0x00] MBKEN
    $01 constant FSMC_MUXEN                     \ [0x01] MUXEN
    $02 constant FSMC_MTYP                      \ [0x02 : 2] MTYP
    $04 constant FSMC_MWID                      \ [0x04 : 2] MWID
    $06 constant FSMC_FACCEN                    \ [0x06] FACCEN
    $08 constant FSMC_BURSTEN                   \ [0x08] BURSTEN
    $09 constant FSMC_WAITPOL                   \ [0x09] WAITPOL
    $0a constant FSMC_WRAPMOD                   \ [0x0a] WRAPMOD
    $0b constant FSMC_WAITCFG                   \ [0x0b] WAITCFG
    $0c constant FSMC_WREN                      \ [0x0c] WREN
    $0d constant FSMC_WAITEN                    \ [0x0d] WAITEN
    $0e constant FSMC_EXTMOD                    \ [0x0e] EXTMOD
    $0f constant FSMC_ASYNCWAIT                 \ [0x0f] ASYNCWAIT
    $13 constant FSMC_CBURSTRW                  \ [0x13] CBURSTRW
  [then]


  [ifdef] FSMC_BTR3_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register 3
    \ Address offset: 0x14
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] ADDSET
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] ADDHLD
    $08 constant FSMC_DATAST                    \ [0x08 : 8] DATAST
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] BUSTURN
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] CLKDIV
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] DATLAT
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FSMC_BCR4_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register 4
    \ Address offset: 0x18
    \ Reset value: 0x000030D0
    \
    $00 constant FSMC_MBKEN                     \ [0x00] MBKEN
    $01 constant FSMC_MUXEN                     \ [0x01] MUXEN
    $02 constant FSMC_MTYP                      \ [0x02 : 2] MTYP
    $04 constant FSMC_MWID                      \ [0x04 : 2] MWID
    $06 constant FSMC_FACCEN                    \ [0x06] FACCEN
    $08 constant FSMC_BURSTEN                   \ [0x08] BURSTEN
    $09 constant FSMC_WAITPOL                   \ [0x09] WAITPOL
    $0a constant FSMC_WRAPMOD                   \ [0x0a] WRAPMOD
    $0b constant FSMC_WAITCFG                   \ [0x0b] WAITCFG
    $0c constant FSMC_WREN                      \ [0x0c] WREN
    $0d constant FSMC_WAITEN                    \ [0x0d] WAITEN
    $0e constant FSMC_EXTMOD                    \ [0x0e] EXTMOD
    $0f constant FSMC_ASYNCWAIT                 \ [0x0f] ASYNCWAIT
    $13 constant FSMC_CBURSTRW                  \ [0x13] CBURSTRW
  [then]


  [ifdef] FSMC_BTR4_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register 4
    \ Address offset: 0x1C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] ADDSET
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] ADDHLD
    $08 constant FSMC_DATAST                    \ [0x08 : 8] DATAST
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] BUSTURN
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] CLKDIV
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] DATLAT
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FSMC_PCR2_DEF
    \
    \ @brief PC Card/NAND Flash control register 2
    \ Address offset: 0x60
    \ Reset value: 0x00000018
    \
    $01 constant FSMC_PWAITEN                   \ [0x01] PWAITEN
    $02 constant FSMC_PBKEN                     \ [0x02] PBKEN
    $03 constant FSMC_PTYP                      \ [0x03] PTYP
    $04 constant FSMC_PWID                      \ [0x04 : 2] PWID
    $06 constant FSMC_ECCEN                     \ [0x06] ECCEN
    $09 constant FSMC_TCLR                      \ [0x09 : 4] TCLR
    $0d constant FSMC_TAR                       \ [0x0d : 4] TAR
    $11 constant FSMC_ECCPS                     \ [0x11 : 3] ECCPS
  [then]


  [ifdef] FSMC_SR2_DEF
    \
    \ @brief FIFO status and interrupt register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000040
    \
    $00 constant FSMC_IRS                       \ [0x00] IRS
    $01 constant FSMC_ILS                       \ [0x01] ILS
    $02 constant FSMC_IFS                       \ [0x02] IFS
    $03 constant FSMC_IREN                      \ [0x03] IREN
    $04 constant FSMC_ILEN                      \ [0x04] ILEN
    $05 constant FSMC_IFEN                      \ [0x05] IFEN
    $06 constant FSMC_FEMPT                     \ [0x06] FEMPT
  [then]


  [ifdef] FSMC_PMEM2_DEF
    \
    \ @brief Common memory space timing register 2
    \ Address offset: 0x68
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FSMC_MEMSETx                   \ [0x00 : 8] MEMSETx
    $08 constant FSMC_MEMWAITx                  \ [0x08 : 8] MEMWAITx
    $10 constant FSMC_MEMHOLDx                  \ [0x10 : 8] MEMHOLDx
    $18 constant FSMC_MEMHIZx                   \ [0x18 : 8] MEMHIZx
  [then]


  [ifdef] FSMC_PATT2_DEF
    \
    \ @brief Attribute memory space timing register 2
    \ Address offset: 0x6C
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FSMC_ATTSETx                   \ [0x00 : 8] ATTSETx
    $08 constant FSMC_ATTWAITx                  \ [0x08 : 8] ATTWAITx
    $10 constant FSMC_ATTHOLDx                  \ [0x10 : 8] ATTHOLDx
    $18 constant FSMC_ATTHIZx                   \ [0x18 : 8] ATTHIZx
  [then]


  [ifdef] FSMC_ECCR2_DEF
    \
    \ @brief ECC result register 2
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ECCx                      \ [0x00 : 32] ECCx
  [then]


  [ifdef] FSMC_PCR3_DEF
    \
    \ @brief PC Card/NAND Flash control register 3
    \ Address offset: 0x80
    \ Reset value: 0x00000018
    \
    $01 constant FSMC_PWAITEN                   \ [0x01] PWAITEN
    $02 constant FSMC_PBKEN                     \ [0x02] PBKEN
    $03 constant FSMC_PTYP                      \ [0x03] PTYP
    $04 constant FSMC_PWID                      \ [0x04 : 2] PWID
    $06 constant FSMC_ECCEN                     \ [0x06] ECCEN
    $09 constant FSMC_TCLR                      \ [0x09 : 4] TCLR
    $0d constant FSMC_TAR                       \ [0x0d : 4] TAR
    $11 constant FSMC_ECCPS                     \ [0x11 : 3] ECCPS
  [then]


  [ifdef] FSMC_SR3_DEF
    \
    \ @brief FIFO status and interrupt register 3
    \ Address offset: 0x84
    \ Reset value: 0x00000040
    \
    $00 constant FSMC_IRS                       \ [0x00] IRS
    $01 constant FSMC_ILS                       \ [0x01] ILS
    $02 constant FSMC_IFS                       \ [0x02] IFS
    $03 constant FSMC_IREN                      \ [0x03] IREN
    $04 constant FSMC_ILEN                      \ [0x04] ILEN
    $05 constant FSMC_IFEN                      \ [0x05] IFEN
    $06 constant FSMC_FEMPT                     \ [0x06] FEMPT
  [then]


  [ifdef] FSMC_PMEM3_DEF
    \
    \ @brief Common memory space timing register 3
    \ Address offset: 0x88
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FSMC_MEMSETx                   \ [0x00 : 8] MEMSETx
    $08 constant FSMC_MEMWAITx                  \ [0x08 : 8] MEMWAITx
    $10 constant FSMC_MEMHOLDx                  \ [0x10 : 8] MEMHOLDx
    $18 constant FSMC_MEMHIZx                   \ [0x18 : 8] MEMHIZx
  [then]


  [ifdef] FSMC_PATT3_DEF
    \
    \ @brief Attribute memory space timing register 3
    \ Address offset: 0x8C
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FSMC_ATTSETx                   \ [0x00 : 8] ATTSETx
    $08 constant FSMC_ATTWAITx                  \ [0x08 : 8] ATTWAITx
    $10 constant FSMC_ATTHOLDx                  \ [0x10 : 8] ATTHOLDx
    $18 constant FSMC_ATTHIZx                   \ [0x18 : 8] ATTHIZx
  [then]


  [ifdef] FSMC_ECCR3_DEF
    \
    \ @brief ECC result register 3
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ECCx                      \ [0x00 : 32] ECCx
  [then]


  [ifdef] FSMC_PCR4_DEF
    \
    \ @brief PC Card/NAND Flash control register 4
    \ Address offset: 0xA0
    \ Reset value: 0x00000018
    \
    $01 constant FSMC_PWAITEN                   \ [0x01] PWAITEN
    $02 constant FSMC_PBKEN                     \ [0x02] PBKEN
    $03 constant FSMC_PTYP                      \ [0x03] PTYP
    $04 constant FSMC_PWID                      \ [0x04 : 2] PWID
    $06 constant FSMC_ECCEN                     \ [0x06] ECCEN
    $09 constant FSMC_TCLR                      \ [0x09 : 4] TCLR
    $0d constant FSMC_TAR                       \ [0x0d : 4] TAR
    $11 constant FSMC_ECCPS                     \ [0x11 : 3] ECCPS
  [then]


  [ifdef] FSMC_SR4_DEF
    \
    \ @brief FIFO status and interrupt register 4
    \ Address offset: 0xA4
    \ Reset value: 0x00000040
    \
    $00 constant FSMC_IRS                       \ [0x00] IRS
    $01 constant FSMC_ILS                       \ [0x01] ILS
    $02 constant FSMC_IFS                       \ [0x02] IFS
    $03 constant FSMC_IREN                      \ [0x03] IREN
    $04 constant FSMC_ILEN                      \ [0x04] ILEN
    $05 constant FSMC_IFEN                      \ [0x05] IFEN
    $06 constant FSMC_FEMPT                     \ [0x06] FEMPT
  [then]


  [ifdef] FSMC_PMEM4_DEF
    \
    \ @brief Common memory space timing register 4
    \ Address offset: 0xA8
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FSMC_MEMSETx                   \ [0x00 : 8] MEMSETx
    $08 constant FSMC_MEMWAITx                  \ [0x08 : 8] MEMWAITx
    $10 constant FSMC_MEMHOLDx                  \ [0x10 : 8] MEMHOLDx
    $18 constant FSMC_MEMHIZx                   \ [0x18 : 8] MEMHIZx
  [then]


  [ifdef] FSMC_PATT4_DEF
    \
    \ @brief Attribute memory space timing register 4
    \ Address offset: 0xAC
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FSMC_ATTSETx                   \ [0x00 : 8] ATTSETx
    $08 constant FSMC_ATTWAITx                  \ [0x08 : 8] ATTWAITx
    $10 constant FSMC_ATTHOLDx                  \ [0x10 : 8] ATTHOLDx
    $18 constant FSMC_ATTHIZx                   \ [0x18 : 8] ATTHIZx
  [then]


  [ifdef] FSMC_PIO4_DEF
    \
    \ @brief I/O space timing register 4
    \ Address offset: 0xB0
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FSMC_IOSETx                    \ [0x00 : 8] IOSETx
    $08 constant FSMC_IOWAITx                   \ [0x08 : 8] IOWAITx
    $10 constant FSMC_IOHOLDx                   \ [0x10 : 8] IOHOLDx
    $18 constant FSMC_IOHIZx                    \ [0x18 : 8] IOHIZx
  [then]


  [ifdef] FSMC_BWTR1_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 1
    \ Address offset: 0x104
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] ADDSET
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] ADDHLD
    $08 constant FSMC_DATAST                    \ [0x08 : 8] DATAST
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] CLKDIV
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] DATLAT
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FSMC_BWTR2_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 2
    \ Address offset: 0x10C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] ADDSET
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] ADDHLD
    $08 constant FSMC_DATAST                    \ [0x08 : 8] DATAST
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] CLKDIV
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] DATLAT
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FSMC_BWTR3_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 3
    \ Address offset: 0x114
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] ADDSET
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] ADDHLD
    $08 constant FSMC_DATAST                    \ [0x08 : 8] DATAST
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] CLKDIV
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] DATLAT
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FSMC_BWTR4_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 4
    \ Address offset: 0x11C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] ADDSET
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] ADDHLD
    $08 constant FSMC_DATAST                    \ [0x08 : 8] DATAST
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] CLKDIV
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] DATLAT
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] ACCMOD
  [then]

  \
  \ @brief Flexible static memory controller
  \
  $00 constant FSMC_BCR1                \ SRAM/NOR-Flash chip-select control register 1
  $04 constant FSMC_BTR1                \ SRAM/NOR-Flash chip-select timing register 1
  $08 constant FSMC_BCR2                \ SRAM/NOR-Flash chip-select control register 2
  $0C constant FSMC_BTR2                \ SRAM/NOR-Flash chip-select timing register 2
  $10 constant FSMC_BCR3                \ SRAM/NOR-Flash chip-select control register 3
  $14 constant FSMC_BTR3                \ SRAM/NOR-Flash chip-select timing register 3
  $18 constant FSMC_BCR4                \ SRAM/NOR-Flash chip-select control register 4
  $1C constant FSMC_BTR4                \ SRAM/NOR-Flash chip-select timing register 4
  $60 constant FSMC_PCR2                \ PC Card/NAND Flash control register 2
  $64 constant FSMC_SR2                 \ FIFO status and interrupt register 2
  $68 constant FSMC_PMEM2               \ Common memory space timing register 2
  $6C constant FSMC_PATT2               \ Attribute memory space timing register 2
  $74 constant FSMC_ECCR2               \ ECC result register 2
  $80 constant FSMC_PCR3                \ PC Card/NAND Flash control register 3
  $84 constant FSMC_SR3                 \ FIFO status and interrupt register 3
  $88 constant FSMC_PMEM3               \ Common memory space timing register 3
  $8C constant FSMC_PATT3               \ Attribute memory space timing register 3
  $94 constant FSMC_ECCR3               \ ECC result register 3
  $A0 constant FSMC_PCR4                \ PC Card/NAND Flash control register 4
  $A4 constant FSMC_SR4                 \ FIFO status and interrupt register 4
  $A8 constant FSMC_PMEM4               \ Common memory space timing register 4
  $AC constant FSMC_PATT4               \ Attribute memory space timing register 4
  $B0 constant FSMC_PIO4                \ I/O space timing register 4
  $104 constant FSMC_BWTR1              \ SRAM/NOR-Flash write timing registers 1
  $10C constant FSMC_BWTR2              \ SRAM/NOR-Flash write timing registers 2
  $114 constant FSMC_BWTR3              \ SRAM/NOR-Flash write timing registers 3
  $11C constant FSMC_BWTR4              \ SRAM/NOR-Flash write timing registers 4

: FSMC_DEF ; [then]
