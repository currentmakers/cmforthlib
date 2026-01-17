\
\ @file fmac.fs
\ @brief Filter Math Accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMAC_DEF

  [ifdef] FMAC_X1BUFCFG_DEF
    \
    \ @brief FMAC X1 Buffer Configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_X1_BASE                   \ [0x00 : 8] X1_BASE
    $08 constant FMAC_X1_BUF_SIZE               \ [0x08 : 8] X1_BUF_SIZE
    $18 constant FMAC_FULL_WM                   \ [0x18 : 2] FULL_WM
  [then]


  [ifdef] FMAC_X2BUFCFG_DEF
    \
    \ @brief FMAC X2 Buffer Configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_X2_BASE                   \ [0x00 : 8] X1_BASE
    $08 constant FMAC_X2_BUF_SIZE               \ [0x08 : 8] X1_BUF_SIZE
  [then]


  [ifdef] FMAC_YBUFCFG_DEF
    \
    \ @brief FMAC Y Buffer Configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_Y_BASE                    \ [0x00 : 8] X1_BASE
    $08 constant FMAC_Y_BUF_SIZE                \ [0x08 : 8] X1_BUF_SIZE
    $18 constant FMAC_EMPTY_WM                  \ [0x18 : 2] EMPTY_WM
  [then]


  [ifdef] FMAC_PARAM_DEF
    \
    \ @brief FMAC Parameter register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_P                         \ [0x00 : 8] P
    $08 constant FMAC_Q                         \ [0x08 : 8] Q
    $10 constant FMAC_R                         \ [0x10 : 8] R
    $18 constant FMAC_FUNC                      \ [0x18 : 7] FUNC
    $1f constant FMAC_START                     \ [0x1f] START
  [then]


  [ifdef] FMAC_CR_DEF
    \
    \ @brief FMAC Control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_RIEN                      \ [0x00] RIEN
    $01 constant FMAC_WIEN                      \ [0x01] WIEN
    $02 constant FMAC_OVFLIEN                   \ [0x02] OVFLIEN
    $03 constant FMAC_UNFLIEN                   \ [0x03] UNFLIEN
    $04 constant FMAC_SATIEN                    \ [0x04] SATIEN
    $08 constant FMAC_DMAREN                    \ [0x08] DMAREN
    $09 constant FMAC_DMAWEN                    \ [0x09] DMAWEN
    $0f constant FMAC_CLIPEN                    \ [0x0f] CLIPEN
    $10 constant FMAC_RESET                     \ [0x10] RESET
  [then]


  [ifdef] FMAC_SR_DEF
    \
    \ @brief FMAC Status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_YEMPTY                    \ [0x00] YEMPTY
    $01 constant FMAC_X1FULL                    \ [0x01] X1FULL
    $08 constant FMAC_OVFL                      \ [0x08] OVFL
    $09 constant FMAC_UNFL                      \ [0x09] UNFL
    $0a constant FMAC_SAT                       \ [0x0a] SAT
  [then]


  [ifdef] FMAC_WDATA_DEF
    \
    \ @brief FMAC Write Data register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_WDATA                     \ [0x00 : 16] WDATA
  [then]


  [ifdef] FMAC_RDATA_DEF
    \
    \ @brief FMAC Read Data register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_RDATA                     \ [0x00 : 16] RDATA
  [then]

  \
  \ @brief Filter Math Accelerator
  \
  $00 constant FMAC_X1BUFCFG            \ FMAC X1 Buffer Configuration register
  $04 constant FMAC_X2BUFCFG            \ FMAC X2 Buffer Configuration register
  $08 constant FMAC_YBUFCFG             \ FMAC Y Buffer Configuration register
  $0C constant FMAC_PARAM               \ FMAC Parameter register
  $10 constant FMAC_CR                  \ FMAC Control register
  $14 constant FMAC_SR                  \ FMAC Status register
  $18 constant FMAC_WDATA               \ FMAC Write Data register
  $1C constant FMAC_RDATA               \ FMAC Read Data register

: FMAC_DEF ; [then]
