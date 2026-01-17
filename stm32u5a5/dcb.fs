\
\ @file dcb.fs
\ @brief Debug Control Block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DCB_DEF

  [ifdef] DCB_DSCSR_DEF
    \
    \ @brief Debug Security Control and Status Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $10 constant DCB_CDS                        \ [0x10] Current domain Secure
  [then]

  \
  \ @brief Debug Control Block
  \
  $00 constant DCB_DSCSR                \ Debug Security Control and Status Register

: DCB_DEF ; [then]
