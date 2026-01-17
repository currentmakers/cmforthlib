\
\ @file dlyb.fs
\ @brief DLYB address block description
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
    $00 constant DLYB_SEL                       \ [0x00 : 4] Phase for the output clock.
    $08 constant DLYB_UNIT                      \ [0x08 : 7] Delay of a unit delay cell.
    $10 constant DLYB_LNG                       \ [0x10 : 12] Delay line length value
    $1f constant DLYB_LNGF                      \ [0x1f] Length valid flag
  [then]

  \
  \ @brief DLYB address block description
  \
  $00 constant DLYB_DLYB_CR             \ DLYB control register
  $04 constant DLYB_DLYB_CFGR           \ DLYB configuration register

: DLYB_DEF ; [then]
