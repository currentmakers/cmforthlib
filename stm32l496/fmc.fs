\
\ @file fmc.fs
\ @brief Flexible memory controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMC_DEF

  [ifdef] FMC_BCR1_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register 1
    \ Address offset: 0x00
    \ Reset value: 0x000030D0
    \
    $00 constant FMC_MBKEN                      \ [0x00] MBKEN
    $01 constant FMC_MUXEN                      \ [0x01] MUXEN
    $02 constant FMC_MTYP                       \ [0x02 : 2] MTYP
    $04 constant FMC_MWID                       \ [0x04 : 2] MWID
    $06 constant FMC_FACCEN                     \ [0x06] FACCEN
    $08 constant FMC_BURSTEN                    \ [0x08] BURSTEN
    $09 constant FMC_WAITPOL                    \ [0x09] WAITPOL
    $0b constant FMC_WAITCFG                    \ [0x0b] WAITCFG
    $0c constant FMC_WREN                       \ [0x0c] WREN
    $0d constant FMC_WAITEN                     \ [0x0d] WAITEN
    $0e constant FMC_EXTMOD                     \ [0x0e] EXTMOD
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] ASYNCWAIT
    $13 constant FMC_CBURSTRW                   \ [0x13] CBURSTRW
    $14 constant FMC_CCLKEN                     \ [0x14] CCLKEN
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO Disable
  [then]


  [ifdef] FMC_BTR1_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register 1
    \ Address offset: 0x04
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_BCR2_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register 2
    \ Address offset: 0x08
    \ Reset value: 0x000030D0
    \
    $00 constant FMC_MBKEN                      \ [0x00] MBKEN
    $01 constant FMC_MUXEN                      \ [0x01] MUXEN
    $02 constant FMC_MTYP                       \ [0x02 : 2] MTYP
    $04 constant FMC_MWID                       \ [0x04 : 2] MWID
    $06 constant FMC_FACCEN                     \ [0x06] FACCEN
    $08 constant FMC_BURSTEN                    \ [0x08] BURSTEN
    $09 constant FMC_WAITPOL                    \ [0x09] WAITPOL
    $0a constant FMC_WRAPMOD                    \ [0x0a] WRAPMOD
    $0b constant FMC_WAITCFG                    \ [0x0b] WAITCFG
    $0c constant FMC_WREN                       \ [0x0c] WREN
    $0d constant FMC_WAITEN                     \ [0x0d] WAITEN
    $0e constant FMC_EXTMOD                     \ [0x0e] EXTMOD
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] ASYNCWAIT
    $13 constant FMC_CBURSTRW                   \ [0x13] CBURSTRW
  [then]


  [ifdef] FMC_BTR2_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register 2
    \ Address offset: 0x0C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_BCR3_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register 3
    \ Address offset: 0x10
    \ Reset value: 0x000030D0
    \
    $00 constant FMC_MBKEN                      \ [0x00] MBKEN
    $01 constant FMC_MUXEN                      \ [0x01] MUXEN
    $02 constant FMC_MTYP                       \ [0x02 : 2] MTYP
    $04 constant FMC_MWID                       \ [0x04 : 2] MWID
    $06 constant FMC_FACCEN                     \ [0x06] FACCEN
    $08 constant FMC_BURSTEN                    \ [0x08] BURSTEN
    $09 constant FMC_WAITPOL                    \ [0x09] WAITPOL
    $0a constant FMC_WRAPMOD                    \ [0x0a] WRAPMOD
    $0b constant FMC_WAITCFG                    \ [0x0b] WAITCFG
    $0c constant FMC_WREN                       \ [0x0c] WREN
    $0d constant FMC_WAITEN                     \ [0x0d] WAITEN
    $0e constant FMC_EXTMOD                     \ [0x0e] EXTMOD
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] ASYNCWAIT
    $13 constant FMC_CBURSTRW                   \ [0x13] CBURSTRW
  [then]


  [ifdef] FMC_BTR3_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register 3
    \ Address offset: 0x14
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_BCR4_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select control register 4
    \ Address offset: 0x18
    \ Reset value: 0x000030D0
    \
    $00 constant FMC_MBKEN                      \ [0x00] MBKEN
    $01 constant FMC_MUXEN                      \ [0x01] MUXEN
    $02 constant FMC_MTYP                       \ [0x02 : 2] MTYP
    $04 constant FMC_MWID                       \ [0x04 : 2] MWID
    $06 constant FMC_FACCEN                     \ [0x06] FACCEN
    $08 constant FMC_BURSTEN                    \ [0x08] BURSTEN
    $09 constant FMC_WAITPOL                    \ [0x09] WAITPOL
    $0a constant FMC_WRAPMOD                    \ [0x0a] WRAPMOD
    $0b constant FMC_WAITCFG                    \ [0x0b] WAITCFG
    $0c constant FMC_WREN                       \ [0x0c] WREN
    $0d constant FMC_WAITEN                     \ [0x0d] WAITEN
    $0e constant FMC_EXTMOD                     \ [0x0e] EXTMOD
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] ASYNCWAIT
    $13 constant FMC_CBURSTRW                   \ [0x13] CBURSTRW
  [then]


  [ifdef] FMC_BTR4_DEF
    \
    \ @brief SRAM/NOR-Flash chip-select timing register 4
    \ Address offset: 0x1C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_PCR_DEF
    \
    \ @brief PC Card/NAND Flash control register 3
    \ Address offset: 0x80
    \ Reset value: 0x00000018
    \
    $01 constant FMC_PWAITEN                    \ [0x01] PWAITEN
    $02 constant FMC_PBKEN                      \ [0x02] PBKEN
    $03 constant FMC_PTYP                       \ [0x03] PTYP
    $04 constant FMC_PWID                       \ [0x04 : 2] PWID
    $06 constant FMC_ECCEN                      \ [0x06] ECCEN
    $09 constant FMC_TCLR                       \ [0x09 : 4] TCLR
    $0d constant FMC_TAR                        \ [0x0d : 4] TAR
    $11 constant FMC_ECCPS                      \ [0x11 : 3] ECCPS
  [then]


  [ifdef] FMC_SR_DEF
    \
    \ @brief FIFO status and interrupt register 3
    \ Address offset: 0x84
    \ Reset value: 0x00000040
    \
    $00 constant FMC_IRS                        \ [0x00] IRS
    $01 constant FMC_ILS                        \ [0x01] ILS
    $02 constant FMC_IFS                        \ [0x02] IFS
    $03 constant FMC_IREN                       \ [0x03] IREN
    $04 constant FMC_ILEN                       \ [0x04] ILEN
    $05 constant FMC_IFEN                       \ [0x05] IFEN
    $06 constant FMC_FEMPT                      \ [0x06] FEMPT
  [then]


  [ifdef] FMC_PMEM_DEF
    \
    \ @brief Common memory space timing register 3
    \ Address offset: 0x88
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_MEMSETx                    \ [0x00 : 8] MEMSETx
    $08 constant FMC_MEMWAITx                   \ [0x08 : 8] MEMWAITx
    $10 constant FMC_MEMHOLDx                   \ [0x10 : 8] MEMHOLDx
    $18 constant FMC_MEMHIZx                    \ [0x18 : 8] MEMHIZx
  [then]


  [ifdef] FMC_PATT_DEF
    \
    \ @brief Attribute memory space timing register 3
    \ Address offset: 0x8C
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_ATTSETx                    \ [0x00 : 8] ATTSETx
    $08 constant FMC_ATTWAITx                   \ [0x08 : 8] ATTWAITx
    $10 constant FMC_ATTHOLDx                   \ [0x10 : 8] ATTHOLDx
    $18 constant FMC_ATTHIZx                    \ [0x18 : 8] ATTHIZx
  [then]


  [ifdef] FMC_ECCR_DEF
    \
    \ @brief ECC result register 3
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FMC_ECCx                       \ [0x00 : 32] ECCx
  [then]


  [ifdef] FMC_BWTR1_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 1
    \ Address offset: 0x104
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_BWTR2_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 2
    \ Address offset: 0x10C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_BWTR3_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 3
    \ Address offset: 0x114
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_BWTR4_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 4
    \ Address offset: 0x11C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]

  \
  \ @brief Flexible memory controller
  \
  $00 constant FMC_BCR1                 \ SRAM/NOR-Flash chip-select control register 1
  $04 constant FMC_BTR1                 \ SRAM/NOR-Flash chip-select timing register 1
  $08 constant FMC_BCR2                 \ SRAM/NOR-Flash chip-select control register 2
  $0C constant FMC_BTR2                 \ SRAM/NOR-Flash chip-select timing register 2
  $10 constant FMC_BCR3                 \ SRAM/NOR-Flash chip-select control register 3
  $14 constant FMC_BTR3                 \ SRAM/NOR-Flash chip-select timing register 3
  $18 constant FMC_BCR4                 \ SRAM/NOR-Flash chip-select control register 4
  $1C constant FMC_BTR4                 \ SRAM/NOR-Flash chip-select timing register 4
  $80 constant FMC_PCR                  \ PC Card/NAND Flash control register 3
  $84 constant FMC_SR                   \ FIFO status and interrupt register 3
  $88 constant FMC_PMEM                 \ Common memory space timing register 3
  $8C constant FMC_PATT                 \ Attribute memory space timing register 3
  $94 constant FMC_ECCR                 \ ECC result register 3
  $104 constant FMC_BWTR1               \ SRAM/NOR-Flash write timing registers 1
  $10C constant FMC_BWTR2               \ SRAM/NOR-Flash write timing registers 2
  $114 constant FMC_BWTR3               \ SRAM/NOR-Flash write timing registers 3
  $11C constant FMC_BWTR4               \ SRAM/NOR-Flash write timing registers 4

: FMC_DEF ; [then]
