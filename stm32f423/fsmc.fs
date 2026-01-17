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
    \ @brief BCR1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_MBKEN                     \ [0x00] Memory bank enable bit
    $01 constant FSMC_MUXEN                     \ [0x01] Memory bank enable bit
    $02 constant FSMC_MTYP                      \ [0x02 : 2] Memory type
    $04 constant FSMC_MWID                      \ [0x04 : 2] Memory data bus width
    $06 constant FSMC_FACCEN                    \ [0x06] Flash access enable
    $08 constant FSMC_BURSTEN                   \ [0x08] Burst enable bit
    $09 constant FSMC_WAITPOL                   \ [0x09] Wait signal polarity bit
    $0b constant FSMC_WAITCFG                   \ [0x0b] Wait timing configuration
    $0c constant FSMC_WREN                      \ [0x0c] Write enable bitWREN
    $0d constant FSMC_WAITEN                    \ [0x0d] Wait enable bit
    $0e constant FSMC_EXTMOD                    \ [0x0e] Extended mode enable
    $0f constant FSMC_ASYNCWAIT                 \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FSMC_CPSIZE                    \ [0x10 : 3] CRAM page size
    $13 constant FSMC_CBURSTRW                  \ [0x13] Write burst enable
    $14 constant FSMC_CCLKEN                    \ [0x14] Continuous Clock Enable
    $15 constant FSMC_WFDIS                     \ [0x15] Write FIFO Disable
  [then]


  [ifdef] FSMC_BTR1_DEF
    \
    \ @brief BTR1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FSMC_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] Clock divide ratio
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] Data latency
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] Access mode
  [then]


  [ifdef] FSMC_BCR2_DEF
    \
    \ @brief BCR2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_MBKEN                     \ [0x00] Memory bank enable bit
    $01 constant FSMC_MUXEN                     \ [0x01] Address/data multiplexing enable bit
    $02 constant FSMC_MTYP                      \ [0x02 : 2] Memory type
    $04 constant FSMC_MWID                      \ [0x04 : 2] Memory data bus width
    $06 constant FSMC_FACCEN                    \ [0x06] Flash access enable
    $08 constant FSMC_BURSTEN                   \ [0x08] Burst enable bit
    $09 constant FSMC_WAITPOL                   \ [0x09] Wait signal polarity bit
    $0b constant FSMC_WAITCFG                   \ [0x0b] Wait timing configuration
    $0c constant FSMC_WREN                      \ [0x0c] Write enable bit
    $0d constant FSMC_WAITEN                    \ [0x0d] Wait enable bit
    $0e constant FSMC_EXTMOD                    \ [0x0e] Extended mode enable
    $0f constant FSMC_ASYNCWAIT                 \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FSMC_CPSIZE                    \ [0x10 : 3] CRAM page size
    $13 constant FSMC_CBURSTRW                  \ [0x13] Write burst enable
    $14 constant FSMC_CCLKEN                    \ [0x14] Continuous Clock Enable
    $15 constant FSMC_WFDIS                     \ [0x15] Write FIFO Disable
  [then]


  [ifdef] FSMC_BTR2_DEF
    \
    \ @brief BTR2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FSMC_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] Clock divide ratio
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] Data latency
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] Access mode
  [then]


  [ifdef] FSMC_BCR3_DEF
    \
    \ @brief BCR3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_MBKEN                     \ [0x00] Memory bank enable bit
    $01 constant FSMC_MUXEN                     \ [0x01] Address/data multiplexing enable bit
    $02 constant FSMC_MTYP                      \ [0x02 : 2] Memory type
    $04 constant FSMC_MWID                      \ [0x04 : 2] Memory data bus width
    $06 constant FSMC_FACCEN                    \ [0x06] Flash access enable
    $08 constant FSMC_BURSTEN                   \ [0x08] Burst enable bit
    $09 constant FSMC_WAITPOL                   \ [0x09] Wait signal polarity bit
    $0b constant FSMC_WAITCFG                   \ [0x0b] Wait timing configuration
    $0c constant FSMC_WREN                      \ [0x0c] Write enable bit
    $0d constant FSMC_WAITEN                    \ [0x0d] Write enable bit
    $0e constant FSMC_EXTMOD                    \ [0x0e] Extended mode enable
    $0f constant FSMC_ASYNCWAIT                 \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FSMC_CPSIZE                    \ [0x10 : 3] CRAM page size
    $13 constant FSMC_CBURSTRW                  \ [0x13] Write burst enable
    $14 constant FSMC_CCLKEN                    \ [0x14] Continuous Clock Enable
    $15 constant FSMC_WFDIS                     \ [0x15] Write FIFO Disable
  [then]


  [ifdef] FSMC_BTR3_DEF
    \
    \ @brief BTR3
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FSMC_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] Clock divide ratio
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] Data latency
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] Access mode
  [then]


  [ifdef] FSMC_BCR4_DEF
    \
    \ @brief BCR4
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_MBKEN                     \ [0x00] Memory bank enable bit
    $01 constant FSMC_MUXEN                     \ [0x01] Address/data multiplexing enable bit
    $02 constant FSMC_MTYP                      \ [0x02 : 2] Memory type
    $04 constant FSMC_MWID                      \ [0x04 : 2] Memory data bus width
    $06 constant FSMC_FACCEN                    \ [0x06] Flash access enable
    $08 constant FSMC_BURSTEN                   \ [0x08] Burst enable bit
    $09 constant FSMC_WAITPOL                   \ [0x09] Wait signal polarity bit
    $0b constant FSMC_WAITCFG                   \ [0x0b] Wait timing configuration
    $0c constant FSMC_WREN                      \ [0x0c] Write enable bit
    $0d constant FSMC_WAITEN                    \ [0x0d] Wait enable bit
    $0e constant FSMC_EXTMOD                    \ [0x0e] Extended mode enable
    $0f constant FSMC_ASYNCWAIT                 \ [0x0f] Extended mode enable
    $10 constant FSMC_CPSIZE                    \ [0x10 : 3] CRAM page size
    $13 constant FSMC_CBURSTRW                  \ [0x13] Write burst enable
    $14 constant FSMC_CCLKEN                    \ [0x14] Continuous Clock Enable
    $15 constant FSMC_WFDIS                     \ [0x15] Write FIFO Disable
  [then]


  [ifdef] FSMC_BTR4_DEF
    \
    \ @brief BTR4
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FSMC_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FSMC_CLKDIV                    \ [0x14 : 4] Clock divide ratio
    $18 constant FSMC_DATLAT                    \ [0x18 : 4] Data latency
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] Access mode
  [then]


  [ifdef] FSMC_BWTR1_DEF
    \
    \ @brief BWTR1
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FSMC_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] Access mode
  [then]


  [ifdef] FSMC_BWTR2_DEF
    \
    \ @brief BWTR2
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FSMC_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] Access mode
  [then]


  [ifdef] FSMC_BWTR3_DEF
    \
    \ @brief BWTR3
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FSMC_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] Access mode
  [then]


  [ifdef] FSMC_BWTR4_DEF
    \
    \ @brief BWTR4
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant FSMC_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FSMC_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FSMC_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FSMC_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FSMC_ACCMOD                    \ [0x1c : 2] Access mode
  [then]

  \
  \ @brief Flexible static memory controller
  \
  $00 constant FSMC_BCR1                \ BCR1
  $04 constant FSMC_BTR1                \ BTR1
  $08 constant FSMC_BCR2                \ BCR2
  $0C constant FSMC_BTR2                \ BTR2
  $10 constant FSMC_BCR3                \ BCR3
  $14 constant FSMC_BTR3                \ BTR3
  $18 constant FSMC_BCR4                \ BCR4
  $1C constant FSMC_BTR4                \ BTR4
  $104 constant FSMC_BWTR1              \ BWTR1
  $10C constant FSMC_BWTR2              \ BWTR2
  $114 constant FSMC_BWTR3              \ BWTR3
  $11C constant FSMC_BWTR4              \ BWTR4

: FSMC_DEF ; [then]
