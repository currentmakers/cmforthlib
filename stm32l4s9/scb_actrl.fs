\
\ @file scb_actrl.fs
\ @brief System control block ACTLR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SCB_ACTRL_DEF

  [ifdef] SCB_ACTRL_ACTRL_DEF
    \
    \ @brief Auxiliary control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SCB_ACTRL_DISMCYCINT           \ [0x00] DISMCYCINT
    $01 constant SCB_ACTRL_DISDEFWBUF           \ [0x01] DISDEFWBUF
    $02 constant SCB_ACTRL_DISFOLD              \ [0x02] DISFOLD
    $08 constant SCB_ACTRL_DISFPCA              \ [0x08] DISFPCA
    $09 constant SCB_ACTRL_DISOOFP              \ [0x09] DISOOFP
  [then]

  \
  \ @brief System control block ACTLR
  \
  $00 constant SCB_ACTRL_ACTRL          \ Auxiliary control register

: SCB_ACTRL_DEF ; [then]
