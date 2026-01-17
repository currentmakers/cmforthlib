\
\ @file pka.fs
\ @brief PKA register blank and RAM
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PKA_DEF

  [ifdef] PKA_PKA_CR_DEF
    \
    \ @brief PKA control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PKA_EN                         \ [0x00] PKA enable
    $01 constant PKA_START                      \ [0x01] start the operation
    $08 constant PKA_MODE                       \ [0x08 : 6] PKA operation code
    $11 constant PKA_PROCENDIE                  \ [0x11] End of operation interrupt enable
    $13 constant PKA_RAMERRIE                   \ [0x13] RAM error interrupt enable
    $14 constant PKA_ADDRERRIE                  \ [0x14] Address error interrupt enable
    $15 constant PKA_OPERRIE                    \ [0x15] Operation error interrupt enable
  [then]


  [ifdef] PKA_PKA_SR_DEF
    \
    \ @brief PKA status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PKA_INITOK                     \ [0x00] PKA initialization OK
    $01 constant PKA_LMF                        \ [0x01] Limited mode flag
    $10 constant PKA_BUSY                       \ [0x10] Busy flag
    $11 constant PKA_PROCENDF                   \ [0x11] PKA end of operation flag
    $13 constant PKA_RAMERRF                    \ [0x13] PKA RAM error flag
    $14 constant PKA_ADDRERRF                   \ [0x14] Address error flag
    $15 constant PKA_OPERRF                     \ [0x15] Operation error flag
  [then]


  [ifdef] PKA_PKA_CLRFR_DEF
    \
    \ @brief PKA clear flag register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $11 constant PKA_PROCENDFC                  \ [0x11] Clear PKA end of operation flag
    $13 constant PKA_RAMERRFC                   \ [0x13] Clear PKA RAM error flag
    $14 constant PKA_ADDRERRFC                  \ [0x14] Clear address error flag
    $15 constant PKA_OPERRFC                    \ [0x15] Clear operation error flag
  [then]

  \
  \ @brief PKA register blank and RAM
  \
  $00 constant PKA_PKA_CR               \ PKA control register
  $04 constant PKA_PKA_SR               \ PKA status register
  $08 constant PKA_PKA_CLRFR            \ PKA clear flag register

: PKA_DEF ; [then]
