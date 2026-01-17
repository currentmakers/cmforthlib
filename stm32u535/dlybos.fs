\
\ @file dlybos.fs
\ @brief The delay block (DLYB) is used to generate an output clock that is dephased from the input clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DLYBOS_DEF

  [ifdef] DLYBOS_DLYB_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DLYBOS_DEN                     \ [0x00] Operational amplifier Enable
    $01 constant DLYBOS_SEN                     \ [0x01] OPALPM
  [then]


  [ifdef] DLYBOS_DLYB_CFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DLYBOS_SEL                     \ [0x00 : 4] SEL
    $08 constant DLYBOS_UNIT                    \ [0x08 : 7] UNIT
    $10 constant DLYBOS_LNG                     \ [0x10 : 12] LNG
    $1f constant DLYBOS_LNGF                    \ [0x1f] LNGF
  [then]

  \
  \ @brief The delay block (DLYB) is used to generate an output clock that is dephased from the input clock
  \
  $00 constant DLYBOS_DLYB_CR           \ control register
  $04 constant DLYBOS_DLYB_CFGR         \ configuration register

: DLYBOS_DEF ; [then]
