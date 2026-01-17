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
    $02 constant SCB_ACTRL_DISFOLD              \ [0x02] DISFOLD
    $0a constant SCB_ACTRL_FPEXCODIS            \ [0x0a] FPEXCODIS
    $0b constant SCB_ACTRL_DISRAMODE            \ [0x0b] DISRAMODE
    $0c constant SCB_ACTRL_DISITMATBFLUSH       \ [0x0c] DISITMATBFLUSH
  [then]

  \
  \ @brief System control block ACTLR
  \
  $00 constant SCB_ACTRL_ACTRL          \ Auxiliary control register

: SCB_ACTRL_DEF ; [then]
