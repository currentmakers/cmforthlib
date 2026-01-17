\
\ @file dlyb.fs
\ @brief DLYB register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DLYB_DEF

  [ifdef] DLYB_DLYB_CR_DEF
    \
    \ @brief DLYB control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DLYB_DEN                       \ [0x00] Delay block enable bit
    $01 constant DLYB_SEN                       \ [0x01] Sampler length enable bit
  [then]


  [ifdef] DLYB_DLYB_CFGR_DEF
    \
    \ @brief DLYB configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DLYB_SEL                       \ [0x00 : 4] Phase for the output clock. These bits can only be written when SEN = 1. Output clock phase = input clock + SEL[3:0] x unit delay
    $08 constant DLYB_UNIT                      \ [0x08 : 7] Delay of a unit delay cell. These bits can only be written when SEN = 1. Unit delay = initial delay + UNIT[6:0] x delay step
    $10 constant DLYB_LNG                       \ [0x10 : 12] Delay line length value These bits reflect the 12 unit delay values sampled at the rising edge of the input clock. The value is only valid when LNGF = 1.
    $1f constant DLYB_LNGF                      \ [0x1f] Length valid flag This flag indicates when the delay line length value contained in LNG[11:0] is valid after UNIT[6:0] bits changed.
  [then]

  \
  \ @brief DLYB register block
  \
  $00 constant DLYB_DLYB_CR             \ DLYB control register
  $04 constant DLYB_DLYB_CFGR           \ DLYB configuration register

: DLYB_DEF ; [then]
