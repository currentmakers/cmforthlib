\
\ @file fmc.fs
\ @brief FMC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMC_DEF

  [ifdef] FMC_FMC_BCR1_DEF
    \
    \ @brief SRAM/NOR-flash chip-select control register for bank 1
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
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM page size
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable
  [then]


  [ifdef] FMC_FMC_BTR1_DEF
    \
    \ @brief SRAM/NOR-flash chip-select timing register for bank 1
    \ Address offset: 0x04
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] (see note below bit descriptions): Data latency for synchronous memory
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_FMC_BCR2_DEF
    \
    \ @brief SRAM/NOR-flash chip-select control register for bank 2
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
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM page size
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable
  [then]


  [ifdef] FMC_FMC_BTR2_DEF
    \
    \ @brief SRAM/NOR-flash chip-select timing register for bank 2
    \ Address offset: 0x0C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] (see note below bit descriptions): Data latency for synchronous memory
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_FMC_BCR3_DEF
    \
    \ @brief SRAM/NOR-flash chip-select control register for bank 3
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
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM page size
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable
  [then]


  [ifdef] FMC_FMC_BTR3_DEF
    \
    \ @brief SRAM/NOR-flash chip-select timing register for bank 3
    \ Address offset: 0x14
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] (see note below bit descriptions): Data latency for synchronous memory
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_FMC_BCR4_DEF
    \
    \ @brief SRAM/NOR-flash chip-select control register for bank 4
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
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CRAM page size
    $13 constant FMC_CBURSTRW                   \ [0x13] Write burst enable
    $14 constant FMC_CCLKEN                     \ [0x14] Continuous clock enable
    $15 constant FMC_WFDIS                      \ [0x15] Write FIFO disable
    $16 constant FMC_NBLSET                     \ [0x16 : 2] Byte lane (NBL) setup
    $1f constant FMC_FMCEN                      \ [0x1f] FMC controller enable
  [then]


  [ifdef] FMC_FMC_BTR4_DEF
    \
    \ @brief SRAM/NOR-flash chip-select timing register for bank 4
    \ Address offset: 0x1C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC_DATLAT                     \ [0x18 : 4] (see note below bit descriptions): Data latency for synchronous memory
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_FMC_PCSCNTR_DEF
    \
    \ @brief PSRAM chip select counter register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CSCOUNT                    \ [0x00 : 16] Chip select counter.
    $10 constant FMC_CNTB1EN                    \ [0x10] Counter Bank 1 enable
    $11 constant FMC_CNTB2EN                    \ [0x11] Counter Bank 2 enable
    $12 constant FMC_CNTB3EN                    \ [0x12] Counter Bank 3 enable
    $13 constant FMC_CNTB4EN                    \ [0x13] Counter Bank 4 enable
  [then]


  [ifdef] FMC_FMC_PCR_DEF
    \
    \ @brief NAND flash control registers
    \ Address offset: 0x80
    \ Reset value: 0x00000018
    \
    $01 constant FMC_PWAITEN                    \ [0x01] Wait feature enable bit
    $02 constant FMC_PBKEN                      \ [0x02] NAND flash memory bank enable bit
    $03 constant FMC_PTYP                       \ [0x03] Memory type
    $04 constant FMC_PWID                       \ [0x04 : 2] Data bus width
    $06 constant FMC_ECCEN                      \ [0x06] ECC computation logic enable bit
    $09 constant FMC_TCLR                       \ [0x09 : 4] CLE to RE delay
    $0d constant FMC_TAR                        \ [0x0d : 3] ALE to RE delay
    $10 constant FMC_TAR3                       \ [0x10] ALE to RE delay
    $11 constant FMC_ECCPS                      \ [0x11 : 3] ECC page size
  [then]


  [ifdef] FMC_FMC_SR_DEF
    \
    \ @brief FIFO status and interrupt register
    \ Address offset: 0x84
    \ Reset value: 0x00000040
    \
    $00 constant FMC_IRS                        \ [0x00] Interrupt rising edge status
    $01 constant FMC_ILS                        \ [0x01] Interrupt high-level status
    $02 constant FMC_IFS                        \ [0x02] Interrupt falling edge status
    $03 constant FMC_IREN                       \ [0x03] Interrupt rising edge detection enable bit
    $04 constant FMC_ILEN                       \ [0x04] Interrupt high-level detection enable bit
    $05 constant FMC_IFEN                       \ [0x05] Interrupt falling edge detection enable bit
    $06 constant FMC_FEMPT                      \ [0x06] FIFO empty
  [then]


  [ifdef] FMC_FMC_PMEM_DEF
    \
    \ @brief Common memory space timing register
    \ Address offset: 0x88
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_MEMSET                     \ [0x00 : 8] Common memory x setup time
    $08 constant FMC_MEMWAIT                    \ [0x08 : 8] Common memory wait time
    $10 constant FMC_MEMHOLD                    \ [0x10 : 8] Common memory hold time
    $18 constant FMC_MEMHIZ                     \ [0x18 : 8] Common memory x data bus Hi-Z time
  [then]


  [ifdef] FMC_FMC_PATT_DEF
    \
    \ @brief Attribute memory space timing register
    \ Address offset: 0x8C
    \ Reset value: 0xFCFCFCFC
    \
    $00 constant FMC_ATTSET                     \ [0x00 : 8] Attribute memory setup time
    $08 constant FMC_ATTWAIT                    \ [0x08 : 8] Attribute memory wait time
    $10 constant FMC_ATTHOLD                    \ [0x10 : 8] Attribute memory hold time
    $18 constant FMC_ATTHIZ                     \ [0x18 : 8] Attribute memory data bus Hi-Z time
  [then]


  [ifdef] FMC_FMC_ECCR_DEF
    \
    \ @brief ECC result registers
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FMC_ECC                        \ [0x00 : 32] ECC result
  [then]


  [ifdef] FMC_FMC_BWTR1_DEF
    \
    \ @brief SRAM/NOR-flash write timing registers 1
    \ Address offset: 0x104
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_FMC_BWTR2_DEF
    \
    \ @brief SRAM/NOR-flash write timing registers 2
    \ Address offset: 0x10C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_FMC_BWTR3_DEF
    \
    \ @brief SRAM/NOR-flash write timing registers 3
    \ Address offset: 0x114
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_FMC_BWTR4_DEF
    \
    \ @brief SRAM/NOR-flash write timing registers 4
    \ Address offset: 0x11C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] Address setup phase duration.
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] Address-hold phase duration.
    $08 constant FMC_DATAST                     \ [0x08 : 8] Data-phase duration.
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] Access mode.
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] Data hold phase duration
  [then]


  [ifdef] FMC_FMC_SDCR1_DEF
    \
    \ @brief SDRAM control registers 1,2
    \ Address offset: 0x140
    \ Reset value: 0x000002D0
    \
    $00 constant FMC_NC                         \ [0x00 : 2] Number of column address bits
    $02 constant FMC_NR                         \ [0x02 : 2] Number of row address bits
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width.
    $06 constant FMC_NB                         \ [0x06] Number of internal banks
    $07 constant FMC_CAS                        \ [0x07 : 2] CAS Latency
    $09 constant FMC_WP                         \ [0x09] Write protection
    $0a constant FMC_SDCLK                      \ [0x0a : 2] SDRAM clock configuration
    $0c constant FMC_RBURST                     \ [0x0c] Burst read
    $0d constant FMC_RPIPE                      \ [0x0d : 2] Read pipe
  [then]


  [ifdef] FMC_FMC_SDCR2_DEF
    \
    \ @brief SDRAM control registers 1,2
    \ Address offset: 0x144
    \ Reset value: 0x000002D0
    \
    $00 constant FMC_NC                         \ [0x00 : 2] Number of column address bits
    $02 constant FMC_NR                         \ [0x02 : 2] Number of row address bits
    $04 constant FMC_MWID                       \ [0x04 : 2] Memory data bus width.
    $06 constant FMC_NB                         \ [0x06] Number of internal banks
    $07 constant FMC_CAS                        \ [0x07 : 2] CAS Latency
    $09 constant FMC_WP                         \ [0x09] Write protection
    $0a constant FMC_SDCLK                      \ [0x0a : 2] SDRAM clock configuration
    $0c constant FMC_RBURST                     \ [0x0c] Burst read
    $0d constant FMC_RPIPE                      \ [0x0d : 2] Read pipe
  [then]


  [ifdef] FMC_FMC_SDTR1_DEF
    \
    \ @brief SDRAM timing registers 1,2
    \ Address offset: 0x148
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_TMRD                       \ [0x00 : 4] Load Mode Register to Active
    $04 constant FMC_TXSR                       \ [0x04 : 4] Exit Self-refresh delay
    $08 constant FMC_TRAS                       \ [0x08 : 4] Self refresh time
    $0c constant FMC_TRC                        \ [0x0c : 4] Row cycle delay
    $10 constant FMC_TWR                        \ [0x10 : 4] Recovery delay
    $14 constant FMC_TRP                        \ [0x14 : 4] Row precharge delay
    $18 constant FMC_TRCD                       \ [0x18 : 4] Row to column delay
  [then]


  [ifdef] FMC_FMC_SDTR2_DEF
    \
    \ @brief SDRAM timing registers 1,2
    \ Address offset: 0x14C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_TMRD                       \ [0x00 : 4] Load Mode Register to Active
    $04 constant FMC_TXSR                       \ [0x04 : 4] Exit Self-refresh delay
    $08 constant FMC_TRAS                       \ [0x08 : 4] Self refresh time
    $0c constant FMC_TRC                        \ [0x0c : 4] Row cycle delay
    $10 constant FMC_TWR                        \ [0x10 : 4] Recovery delay
    $14 constant FMC_TRP                        \ [0x14 : 4] Row precharge delay
    $18 constant FMC_TRCD                       \ [0x18 : 4] Row to column delay
  [then]


  [ifdef] FMC_FMC_SDCMR_DEF
    \
    \ @brief SDRAM Command Mode register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant FMC_MODE                       \ [0x00 : 3] Command mode
    $03 constant FMC_CTB2                       \ [0x03] Command Target Bank 2
    $04 constant FMC_CTB1                       \ [0x04] Command Target Bank 1
    $05 constant FMC_NRFS                       \ [0x05 : 4] Number of Auto-refresh
    $09 constant FMC_MRD                        \ [0x09 : 13] Mode Register definition
  [then]


  [ifdef] FMC_FMC_SDRTR_DEF
    \
    \ @brief SDRAM refresh timer register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CRE                        \ [0x00] Clear Refresh error flag
    $01 constant FMC_COUNT                      \ [0x01 : 13] Refresh Timer Count
    $0e constant FMC_REIE                       \ [0x0e] RES Interrupt Enable
  [then]


  [ifdef] FMC_FMC_SDSR_DEF
    \
    \ @brief SDRAM status register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant FMC_RE                         \ [0x00] Refresh error flag
    $01 constant FMC_MODES1                     \ [0x01 : 2] Status Mode for Bank 1
    $03 constant FMC_MODES2                     \ [0x03 : 2] Status Mode for Bank 2
    $05 constant FMC_BUSY                       \ [0x05] Busy status
  [then]

  \
  \ @brief FMC address block description
  \
  $00 constant FMC_FMC_BCR1             \ SRAM/NOR-flash chip-select control register for bank 1
  $04 constant FMC_FMC_BTR1             \ SRAM/NOR-flash chip-select timing register for bank 1
  $08 constant FMC_FMC_BCR2             \ SRAM/NOR-flash chip-select control register for bank 2
  $0C constant FMC_FMC_BTR2             \ SRAM/NOR-flash chip-select timing register for bank 2
  $10 constant FMC_FMC_BCR3             \ SRAM/NOR-flash chip-select control register for bank 3
  $14 constant FMC_FMC_BTR3             \ SRAM/NOR-flash chip-select timing register for bank 3
  $18 constant FMC_FMC_BCR4             \ SRAM/NOR-flash chip-select control register for bank 4
  $1C constant FMC_FMC_BTR4             \ SRAM/NOR-flash chip-select timing register for bank 4
  $20 constant FMC_FMC_PCSCNTR          \ PSRAM chip select counter register
  $80 constant FMC_FMC_PCR              \ NAND flash control registers
  $84 constant FMC_FMC_SR               \ FIFO status and interrupt register
  $88 constant FMC_FMC_PMEM             \ Common memory space timing register
  $8C constant FMC_FMC_PATT             \ Attribute memory space timing register
  $94 constant FMC_FMC_ECCR             \ ECC result registers
  $104 constant FMC_FMC_BWTR1           \ SRAM/NOR-flash write timing registers 1
  $10C constant FMC_FMC_BWTR2           \ SRAM/NOR-flash write timing registers 2
  $114 constant FMC_FMC_BWTR3           \ SRAM/NOR-flash write timing registers 3
  $11C constant FMC_FMC_BWTR4           \ SRAM/NOR-flash write timing registers 4
  $140 constant FMC_FMC_SDCR1           \ SDRAM control registers 1,2
  $144 constant FMC_FMC_SDCR2           \ SDRAM control registers 1,2
  $148 constant FMC_FMC_SDTR1           \ SDRAM timing registers 1,2
  $14C constant FMC_FMC_SDTR2           \ SDRAM timing registers 1,2
  $150 constant FMC_FMC_SDCMR           \ SDRAM Command Mode register
  $154 constant FMC_FMC_SDRTR           \ SDRAM refresh timer register
  $158 constant FMC_FMC_SDSR            \ SDRAM status register

: FMC_DEF ; [then]
