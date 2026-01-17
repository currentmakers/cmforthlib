\
\ @file pka.fs
\ @brief Private key accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PKA_DEF

  [ifdef] PKA_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PKA_EN                         \ [0x00] Peripheral Enable
    $01 constant PKA_START                      \ [0x01] Start the operation
    $08 constant PKA_MODE                       \ [0x08 : 6] PKA Operation Mode
    $11 constant PKA_PROCENDIE                  \ [0x11] End of operation interrupt enable
    $13 constant PKA_RAMERRIE                   \ [0x13] RAM error interrupt enable
    $14 constant PKA_ADDRERRIE                  \ [0x14] Address error interrupt enable
    $15 constant PKA_OPERRIE                    \ [0x15] Operation error interrupt enable
  [then]


  [ifdef] PKA_SR_DEF
    \
    \ @brief PKA status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PKA_INITOK                     \ [0x00] INITOK
    $10 constant PKA_BUSY                       \ [0x10] PKA operation is in progress
    $11 constant PKA_PROCENDF                   \ [0x11] PKA End of Operation flag
    $13 constant PKA_RAMERRF                    \ [0x13] RAMERRF
    $14 constant PKA_ADDRERRF                   \ [0x14] ADDRERRF
    $15 constant PKA_OPERRF                     \ [0x15] OPERRF
  [then]


  [ifdef] PKA_CLRFR_DEF
    \
    \ @brief PKA clear flag register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $11 constant PKA_PROCENDFC                  \ [0x11] Clear PKA End of Operation flag
    $13 constant PKA_RAMERRFC                   \ [0x13] RAMERRFC
    $14 constant PKA_ADDRERRFC                  \ [0x14] ADDRERRFC
    $15 constant PKA_OPERRFC                    \ [0x15] OPERRFC
  [then]

  \
  \ @brief Private key accelerator
  \
  $00 constant PKA_CR                   \ Control register
  $04 constant PKA_SR                   \ PKA status register
  $08 constant PKA_CLRFR                \ PKA clear flag register

: PKA_DEF ; [then]
