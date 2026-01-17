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
    $00 constant FMAC_X1_BASE                   \ [0x00 : 8] Base address of X1 buffer
    $08 constant FMAC_X1_BUF_SIZE               \ [0x08 : 8] Allocated size of X1 buffer in 16-bit words
    $18 constant FMAC_FULL_WM                   \ [0x18 : 2] Watermark for buffer full flag
  [then]


  [ifdef] FMAC_X2BUFCFG_DEF
    \
    \ @brief FMAC X2 Buffer Configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_X2_BASE                   \ [0x00 : 8] Base address of X2 buffer
    $08 constant FMAC_X2_BUF_SIZE               \ [0x08 : 8] Size of X2 buffer in 16-bit words
  [then]


  [ifdef] FMAC_YBUFCFG_DEF
    \
    \ @brief FMAC Y Buffer Configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_Y_BASE                    \ [0x00 : 8] Base address of Y buffer
    $08 constant FMAC_Y_BUF_SIZE                \ [0x08 : 8] Size of Y buffer in 16-bit words
    $18 constant FMAC_EMPTY_WM                  \ [0x18 : 2] Watermark for buffer empty flag
  [then]


  [ifdef] FMAC_PARAM_DEF
    \
    \ @brief FMAC Parameter register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_P                         \ [0x00 : 8] Input parameter P
    $08 constant FMAC_Q                         \ [0x08 : 8] Input parameter Q
    $10 constant FMAC_R                         \ [0x10 : 8] Input parameter R
    $18 constant FMAC_FUNC                      \ [0x18 : 7] Function
    $1f constant FMAC_START                     \ [0x1f] Enable execution
  [then]


  [ifdef] FMAC_CR_DEF
    \
    \ @brief FMAC Control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_RIEN                      \ [0x00] Enable read interrupt
    $01 constant FMAC_WIEN                      \ [0x01] Enable write interrupt
    $02 constant FMAC_OVFLIEN                   \ [0x02] Enable overflow error interrupts
    $03 constant FMAC_UNFLIEN                   \ [0x03] Enable underflow error interrupts
    $04 constant FMAC_SATIEN                    \ [0x04] Enable saturation error interrupts
    $08 constant FMAC_DMAREN                    \ [0x08] Enable DMA read channel requests
    $09 constant FMAC_DMAWEN                    \ [0x09] Enable DMA write channel requests
    $0f constant FMAC_CLIPEN                    \ [0x0f] Enable clipping
    $10 constant FMAC_RESET                     \ [0x10] Reset FMAC unit
  [then]


  [ifdef] FMAC_SR_DEF
    \
    \ @brief FMAC Status register
    \ Address offset: 0x14
    \ Reset value: 0x00000001
    \
    $00 constant FMAC_YEMPTY                    \ [0x00] Y buffer empty flag
    $01 constant FMAC_X1FULL                    \ [0x01] X1 buffer full flag
    $08 constant FMAC_OVFL                      \ [0x08] Overflow error flag
    $09 constant FMAC_UNFL                      \ [0x09] Underflow error flag
    $0a constant FMAC_SAT                       \ [0x0a] Saturation error flag
  [then]


  [ifdef] FMAC_WDATA_DEF
    \
    \ @brief FMAC Write Data register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_WDATA                     \ [0x00 : 16] Write data
  [then]


  [ifdef] FMAC_RDATA_DEF
    \
    \ @brief FMAC Read Data register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant FMAC_RDATA                     \ [0x00 : 16] Read data
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
