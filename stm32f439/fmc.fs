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
    $0a constant FMC_WRAPMOD                    \ [0x0a] WRAPMOD
    $0b constant FMC_WAITCFG                    \ [0x0b] WAITCFG
    $0c constant FMC_WREN                       \ [0x0c] WREN
    $0d constant FMC_WAITEN                     \ [0x0d] WAITEN
    $0e constant FMC_EXTMOD                     \ [0x0e] EXTMOD
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] ASYNCWAIT
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CPSIZE
    $13 constant FMC_CBURSTRW                   \ [0x13] CBURSTRW
    $14 constant FMC_CCLKEN                     \ [0x14] CCLKEN
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
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CPSIZE
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
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CPSIZE
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
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CPSIZE
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


  [ifdef] FMC_PCR2_DEF
    \
    \ @brief PC Card/NAND Flash control register 2
    \ Address offset: 0x60
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


  [ifdef] FMC_SR2_DEF
    \
    \ @brief FIFO status and interrupt register 2
    \ Address offset: 0x64
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


  [ifdef] FMC_PMEM2_DEF
    \
    \ @brief Common memory space timing register 2
    \ Address offset: 0x68
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_MEMSETx                    \ [0x00 : 8] MEMSETx
    $08 constant FMC_MEMWAITx                   \ [0x08 : 8] MEMWAITx
    $10 constant FMC_MEMHOLDx                   \ [0x10 : 8] MEMHOLDx
    $18 constant FMC_MEMHIZx                    \ [0x18 : 8] MEMHIZx
  [then]


  [ifdef] FMC_PATT2_DEF
    \
    \ @brief Attribute memory space timing register 2
    \ Address offset: 0x6C
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_ATTSETx                    \ [0x00 : 8] ATTSETx
    $08 constant FMC_ATTWAITx                   \ [0x08 : 8] ATTWAITx
    $10 constant FMC_ATTHOLDx                   \ [0x10 : 8] ATTHOLDx
    $18 constant FMC_ATTHIZx                    \ [0x18 : 8] ATTHIZx
  [then]


  [ifdef] FMC_ECCR2_DEF
    \
    \ @brief ECC result register 2
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant FMC_ECCx                       \ [0x00 : 32] ECCx
  [then]


  [ifdef] FMC_PCR3_DEF
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


  [ifdef] FMC_SR3_DEF
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


  [ifdef] FMC_PMEM3_DEF
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


  [ifdef] FMC_PATT3_DEF
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


  [ifdef] FMC_ECCR3_DEF
    \
    \ @brief ECC result register 3
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FMC_ECCx                       \ [0x00 : 32] ECCx
  [then]


  [ifdef] FMC_PCR4_DEF
    \
    \ @brief PC Card/NAND Flash control register 4
    \ Address offset: 0xA0
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


  [ifdef] FMC_SR4_DEF
    \
    \ @brief FIFO status and interrupt register 4
    \ Address offset: 0xA4
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


  [ifdef] FMC_PMEM4_DEF
    \
    \ @brief Common memory space timing register 4
    \ Address offset: 0xA8
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_MEMSETx                    \ [0x00 : 8] MEMSETx
    $08 constant FMC_MEMWAITx                   \ [0x08 : 8] MEMWAITx
    $10 constant FMC_MEMHOLDx                   \ [0x10 : 8] MEMHOLDx
    $18 constant FMC_MEMHIZx                    \ [0x18 : 8] MEMHIZx
  [then]


  [ifdef] FMC_PATT4_DEF
    \
    \ @brief Attribute memory space timing register 4
    \ Address offset: 0xAC
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_ATTSETx                    \ [0x00 : 8] ATTSETx
    $08 constant FMC_ATTWAITx                   \ [0x08 : 8] ATTWAITx
    $10 constant FMC_ATTHOLDx                   \ [0x10 : 8] ATTHOLDx
    $18 constant FMC_ATTHIZx                    \ [0x18 : 8] ATTHIZx
  [then]


  [ifdef] FMC_PIO4_DEF
    \
    \ @brief I/O space timing register 4
    \ Address offset: 0xB0
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_IOSETx                     \ [0x00 : 8] IOSETx
    $08 constant FMC_IOWAITx                    \ [0x08 : 8] IOWAITx
    $10 constant FMC_IOHOLDx                    \ [0x10 : 8] IOHOLDx
    $18 constant FMC_IOHIZx                     \ [0x18 : 8] IOHIZx
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
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_BWTR3_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 3
    \ Address offset: 0x104
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
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
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_BWTR4_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers 4
    \ Address offset: 0x10C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
  [then]


  [ifdef] FMC_SDCR1_DEF
    \
    \ @brief SDRAM Control Register 1
    \ Address offset: 0x140
    \ Reset value: 0x000002D0
    \
    $00 constant FMC_NC                         \ [0x00 : 2] Number of column address bits
    $02 constant FMC_NR                         \ [0x02 : 2] Number of row address bits
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width
    $06 constant FMC_NB                         \ [0x06] Number of internal banks
    $07 constant FMC_CAS                        \ [0x07 : 2] CAS latency
    $09 constant FMC_WP                         \ [0x09] Write protection
    $0a constant FMC_SDCLK                      \ [0x0a : 2] SDRAM clock configuration
    $0c constant FMC_RBURST                     \ [0x0c] Burst read
    $0d constant FMC_RPIPE                      \ [0x0d : 2] Read pipe
  [then]


  [ifdef] FMC_SDCR2_DEF
    \
    \ @brief SDRAM Control Register 2
    \ Address offset: 0x144
    \ Reset value: 0x000002D0
    \
    $00 constant FMC_NC                         \ [0x00 : 2] Number of column address bits
    $02 constant FMC_NR                         \ [0x02 : 2] Number of row address bits
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width
    $06 constant FMC_NB                         \ [0x06] Number of internal banks
    $07 constant FMC_CAS                        \ [0x07 : 2] CAS latency
    $09 constant FMC_WP                         \ [0x09] Write protection
    $0a constant FMC_CLK                        \ [0x0a : 2] SDRAM clock configuration
  [then]


  [ifdef] FMC_SDTR1_DEF
    \
    \ @brief SDRAM Timing register 1
    \ Address offset: 0x148
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_TMRD                       \ [0x00 : 4] Load Mode Register to Active
    $04 constant FMC_TXSR                       \ [0x04 : 4] Exit self-refresh delay
    $08 constant FMC_TRAS                       \ [0x08 : 4] Self refresh time
    $0c constant FMC_TRC                        \ [0x0c : 4] Row cycle delay
    $10 constant FMC_TWR                        \ [0x10 : 4] Recovery delay
    $14 constant FMC_TRP                        \ [0x14 : 4] Row precharge delay
    $18 constant FMC_TRCD                       \ [0x18 : 4] Row to column delay
  [then]


  [ifdef] FMC_SDTR2_DEF
    \
    \ @brief SDRAM Timing register 2
    \ Address offset: 0x14C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_TMRD                       \ [0x00 : 4] Load Mode Register to Active
    $04 constant FMC_TXSR                       \ [0x04 : 4] Exit self-refresh delay
    $08 constant FMC_TRAS                       \ [0x08 : 4] Self refresh time
    $0c constant FMC_TRC                        \ [0x0c : 4] Row cycle delay
    $10 constant FMC_TWR                        \ [0x10 : 4] Recovery delay
    $14 constant FMC_TRP                        \ [0x14 : 4] Row precharge delay
    $18 constant FMC_TRCD                       \ [0x18 : 4] Row to column delay
  [then]


  [ifdef] FMC_SDCMR_DEF
    \
    \ @brief SDRAM Command Mode register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant FMC_MODE                       \ [0x00 : 3] Command mode
    $03 constant FMC_CTB2                       \ [0x03] Command target bank 2
    $04 constant FMC_CTB1                       \ [0x04] Command target bank 1
    $05 constant FMC_NRFS                       \ [0x05 : 4] Number of Auto-refresh
    $09 constant FMC_MRD                        \ [0x09 : 13] Mode Register definition
  [then]


  [ifdef] FMC_SDRTR_DEF
    \
    \ @brief SDRAM Refresh Timer register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CRE                        \ [0x00] Clear Refresh error flag
    $01 constant FMC_COUNT                      \ [0x01 : 13] Refresh Timer Count
    $0e constant FMC_REIE                       \ [0x0e] RES Interrupt Enable
  [then]


  [ifdef] FMC_SDSR_DEF
    \
    \ @brief SDRAM Status register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant FMC_RE                         \ [0x00] Refresh error flag
    $01 constant FMC_MODES1                     \ [0x01 : 2] Status Mode for Bank 1
    $03 constant FMC_MODES2                     \ [0x03 : 2] Status Mode for Bank 2
    $05 constant FMC_BUSY                       \ [0x05] Busy status
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
  $60 constant FMC_PCR2                 \ PC Card/NAND Flash control register 2
  $64 constant FMC_SR2                  \ FIFO status and interrupt register 2
  $68 constant FMC_PMEM2                \ Common memory space timing register 2
  $6C constant FMC_PATT2                \ Attribute memory space timing register 2
  $74 constant FMC_ECCR2                \ ECC result register 2
  $80 constant FMC_PCR3                 \ PC Card/NAND Flash control register 3
  $84 constant FMC_SR3                  \ FIFO status and interrupt register 3
  $88 constant FMC_PMEM3                \ Common memory space timing register 3
  $8C constant FMC_PATT3                \ Attribute memory space timing register 3
  $94 constant FMC_ECCR3                \ ECC result register 3
  $A0 constant FMC_PCR4                 \ PC Card/NAND Flash control register 4
  $A4 constant FMC_SR4                  \ FIFO status and interrupt register 4
  $A8 constant FMC_PMEM4                \ Common memory space timing register 4
  $AC constant FMC_PATT4                \ Attribute memory space timing register 4
  $B0 constant FMC_PIO4                 \ I/O space timing register 4
  $104 constant FMC_BWTR1               \ SRAM/NOR-Flash write timing registers 1
  $104 constant FMC_BWTR3               \ SRAM/NOR-Flash write timing registers 3
  $10C constant FMC_BWTR2               \ SRAM/NOR-Flash write timing registers 2
  $10C constant FMC_BWTR4               \ SRAM/NOR-Flash write timing registers 4
  $140 constant FMC_SDCR1               \ SDRAM Control Register 1
  $144 constant FMC_SDCR2               \ SDRAM Control Register 2
  $148 constant FMC_SDTR1               \ SDRAM Timing register 1
  $14C constant FMC_SDTR2               \ SDRAM Timing register 2
  $150 constant FMC_SDCMR               \ SDRAM Command Mode register
  $154 constant FMC_SDRTR               \ SDRAM Refresh Timer register
  $158 constant FMC_SDSR                \ SDRAM Status register

: FMC_DEF ; [then]
