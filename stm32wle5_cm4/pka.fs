\
\ @file pka.fs
\ @brief Public key accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PKA_DEF

  [ifdef] PKA_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PKA_EN                         \ [0x00] PKA enable.
    $01 constant PKA_START                      \ [0x01] start the operation
    $08 constant PKA_MODE                       \ [0x08 : 6] PKA operation code
    $11 constant PKA_PROCENDIE                  \ [0x11] PROCENDIE
    $13 constant PKA_RAMERRIE                   \ [0x13] RAM error interrupt enable
    $14 constant PKA_ADDRERRIE                  \ [0x14] Address error interrupt enable
  [then]


  [ifdef] PKA_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $10 constant PKA_BUSY                       \ [0x10] PKA operation is in progressThis bit is set to 1 whenever START bit in the PKA_CR is set. It is automatically cleared when the computation is complete, meaning that PKA RAM can be safely accessed and a new operation can be started.
    $11 constant PKA_PROCENDF                   \ [0x11] PKA End of Operation flag
    $13 constant PKA_RAMERRF                    \ [0x13] PKA RAM error flag
    $14 constant PKA_ADDRERRF                   \ [0x14] Address error flag
  [then]


  [ifdef] PKA_CLRFR_DEF
    \
    \ @brief clear flag register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $11 constant PKA_PROCENDFC                  \ [0x11] Clear PKA End of Operation flag
    $13 constant PKA_RAMERRFC                   \ [0x13] Clear PKA RAM error flag
    $14 constant PKA_ADDRERRFC                  \ [0x14] Clear Address error flag
  [then]

  \
  \ @brief Public key accelerator
  \
  $00 constant PKA_CR                   \ control register
  $04 constant PKA_SR                   \ status register
  $08 constant PKA_CLRFR                \ clear flag register

: PKA_DEF ; [then]
