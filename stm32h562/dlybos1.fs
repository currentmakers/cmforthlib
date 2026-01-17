\
\ @file dlybos1.fs
\ @brief Delay block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DLYBOS1_DEF

  [ifdef] DLYBOS1_DLYB_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DLYBOS1_DEN                    \ [0x00] Operational amplifier Enable
    $01 constant DLYBOS1_SEN                    \ [0x01] OPALPM
  [then]


  [ifdef] DLYBOS1_DLYB_CFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DLYBOS1_SEL                    \ [0x00 : 4] SEL
    $08 constant DLYBOS1_UNIT                   \ [0x08 : 7] UNIT
    $10 constant DLYBOS1_LNG                    \ [0x10 : 12] LNG
    $1f constant DLYBOS1_LNGF                   \ [0x1f] LNGF
  [then]

  \
  \ @brief Delay block
  \
  $00 constant DLYBOS1_DLYB_CR          \ control register
  $04 constant DLYBOS1_DLYB_CFGR        \ configuration register

: DLYBOS1_DEF ; [then]
