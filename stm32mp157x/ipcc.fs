\
\ @file ipcc.fs
\ @brief IPCC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] IPCC_DEF

  [ifdef] IPCC_IPCC_C1CR_DEF
    \
    \ @brief IPCC Processor 1 control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_RXOIE                     \ [0x00] RXOIE
    $10 constant IPCC_TXFIE                     \ [0x10] TXFIE
  [then]


  [ifdef] IPCC_IPCC_C1MR_DEF
    \
    \ @brief IPCC Processor 1 mask register
    \ Address offset: 0x04
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant IPCC_CHxOM                     \ [0x00 : 6] CHxOM
    $10 constant IPCC_CHxFM                     \ [0x10 : 6] CHxFM
  [then]


  [ifdef] IPCC_IPCC_C1SCR_DEF
    \
    \ @brief Reading this register will always return 0x0000 0000.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CHxC                      \ [0x00 : 6] CHxC
    $10 constant IPCC_CHxS                      \ [0x10 : 6] CHxS
  [then]


  [ifdef] IPCC_IPCC_C1TOC2SR_DEF
    \
    \ @brief IPCC processor 1 to processor 2 status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CHxF                      \ [0x00 : 6] CHxF
  [then]


  [ifdef] IPCC_IPCC_C2CR_DEF
    \
    \ @brief IPCC Processor 2 control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_RXOIE                     \ [0x00] RXOIE
    $10 constant IPCC_TXFIE                     \ [0x10] TXFIE
  [then]


  [ifdef] IPCC_IPCC_C2MR_DEF
    \
    \ @brief IPCC Processor 2 mask register
    \ Address offset: 0x14
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant IPCC_CHxOM                     \ [0x00 : 6] CHxOM
    $10 constant IPCC_CHxFM                     \ [0x10 : 6] CHxFM
  [then]


  [ifdef] IPCC_IPCC_C2SCR_DEF
    \
    \ @brief Reading this register will always return 0x0000 0000.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CHxC                      \ [0x00 : 6] CHxC
    $10 constant IPCC_CHxS                      \ [0x10 : 6] CHxS
  [then]


  [ifdef] IPCC_IPCC_C2TOC1SR_DEF
    \
    \ @brief IPCC processor 2 to processor 1 status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CHxF                      \ [0x00 : 6] CHxF
  [then]


  [ifdef] IPCC_IPCC_HWCFGR_DEF
    \
    \ @brief IPCC Hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000002
    \
    $00 constant IPCC_CHANNELS                  \ [0x00 : 8] CHANNELS
  [then]


  [ifdef] IPCC_IPCC_VER_DEF
    \
    \ @brief IPCC IP Version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant IPCC_MINREV                    \ [0x00 : 4] MINREV
    $04 constant IPCC_MAJREV                    \ [0x04 : 4] MAJREV
  [then]


  [ifdef] IPCC_IPCC_ID_DEF
    \
    \ @brief IPCC IP Identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00100071
    \
    $00 constant IPCC_IPID                      \ [0x00 : 32] IPID
  [then]


  [ifdef] IPCC_IPCC_SID_DEF
    \
    \ @brief IPCC Size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant IPCC_SID                       \ [0x00 : 32] SID
  [then]

  \
  \ @brief IPCC
  \
  $00 constant IPCC_IPCC_C1CR           \ IPCC Processor 1 control register
  $04 constant IPCC_IPCC_C1MR           \ IPCC Processor 1 mask register
  $08 constant IPCC_IPCC_C1SCR          \ Reading this register will always return 0x0000 0000.
  $0C constant IPCC_IPCC_C1TOC2SR       \ IPCC processor 1 to processor 2 status register
  $10 constant IPCC_IPCC_C2CR           \ IPCC Processor 2 control register
  $14 constant IPCC_IPCC_C2MR           \ IPCC Processor 2 mask register
  $18 constant IPCC_IPCC_C2SCR          \ Reading this register will always return 0x0000 0000.
  $1C constant IPCC_IPCC_C2TOC1SR       \ IPCC processor 2 to processor 1 status register
  $3F0 constant IPCC_IPCC_HWCFGR        \ IPCC Hardware configuration register
  $3F4 constant IPCC_IPCC_VER           \ IPCC IP Version register
  $3F8 constant IPCC_IPCC_ID            \ IPCC IP Identification register
  $3FC constant IPCC_IPCC_SID           \ IPCC Size ID register

: IPCC_DEF ; [then]
