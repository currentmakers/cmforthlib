\
\ @file pka.fs
\ @brief PKA
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
    $02 constant PKA_SECLVL                     \ [0x02] Security Enable
    $08 constant PKA_MODE                       \ [0x08 : 6] PKA Operation Mode
    $11 constant PKA_PROCENDIE                  \ [0x11] End of operation interrupt enable
    $13 constant PKA_RAMERRIE                   \ [0x13] RAM error interrupt enable
    $14 constant PKA_ADDRERRIE                  \ [0x14] Address error interrupt enable
  [then]


  [ifdef] PKA_SR_DEF
    \
    \ @brief PKA status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $10 constant PKA_BUSY                       \ [0x10] PKA Operation in progress
    $11 constant PKA_PROCENDF                   \ [0x11] PKA End of Operation flag
    $13 constant PKA_RAMERRF                    \ [0x13] RAM error flag
    $14 constant PKA_ADDRERRF                   \ [0x14] Address error flag
  [then]


  [ifdef] PKA_CLRFR_DEF
    \
    \ @brief PKA clear flag register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $11 constant PKA_PROCENDFC                  \ [0x11] Clear PKA End of Operation flag
    $13 constant PKA_RAMERRFC                   \ [0x13] Clear RAM error flag
    $14 constant PKA_ADDRERRFC                  \ [0x14] Clear Address error flag
  [then]


  [ifdef] PKA_VERR_DEF
    \
    \ @brief PKA version register
    \ Address offset: 0x1FF4
    \ Reset value: 0x00000010
    \
    $00 constant PKA_MINREV                     \ [0x00 : 4] Minor revision
    $04 constant PKA_MAJREV                     \ [0x04 : 4] Major revision
  [then]


  [ifdef] PKA_IPIDR_DEF
    \
    \ @brief PKA identification register
    \ Address offset: 0x1FF8
    \ Reset value: 0x00170061
    \
    $00 constant PKA_ID                         \ [0x00 : 32] Identification Code
  [then]


  [ifdef] PKA_SIDR_DEF
    \
    \ @brief PKA size ID register
    \ Address offset: 0x1FFC
    \ Reset value: 0xA3C5DD08
    \
    $00 constant PKA_SID                        \ [0x00 : 32] Side Identification Code
  [then]

  \
  \ @brief PKA
  \
  $00 constant PKA_CR                   \ Control register
  $04 constant PKA_SR                   \ PKA status register
  $08 constant PKA_CLRFR                \ PKA clear flag register
  $1FF4 constant PKA_VERR               \ PKA version register
  $1FF8 constant PKA_IPIDR              \ PKA identification register
  $1FFC constant PKA_SIDR               \ PKA size ID register

: PKA_DEF ; [then]
