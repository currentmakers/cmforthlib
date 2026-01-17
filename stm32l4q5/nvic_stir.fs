\
\ @file nvic_stir.fs
\ @brief Nested vectored interrupt controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] NVIC_STIR_DEF

  [ifdef] NVIC_STIR_STIR_DEF
    \
    \ @brief Software trigger interrupt register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_STIR_INTID                \ [0x00 : 9] Software generated interrupt ID
  [then]

  \
  \ @brief Nested vectored interrupt controller
  \
  $00 constant NVIC_STIR_STIR           \ Software trigger interrupt register

: NVIC_STIR_DEF ; [then]
