\
\ @file rng.fs
\ @brief RNG1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_RNG_CR_DEF
    \
    \ @brief RNG control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant RNG_RNGEN                      \ [0x02] RNGEN
    $03 constant RNG_IE                         \ [0x03] IE
    $05 constant RNG_CED                        \ [0x05] CED
  [then]


  [ifdef] RNG_RNG_SR_DEF
    \
    \ @brief RNG status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_DRDY                       \ [0x00] DRDY
    $01 constant RNG_CECS                       \ [0x01] CECS
    $02 constant RNG_SECS                       \ [0x02] SECS
    $05 constant RNG_CEIS                       \ [0x05] CEIS
    $06 constant RNG_SEIS                       \ [0x06] SEIS
  [then]


  [ifdef] RNG_RNG_DR_DEF
    \
    \ @brief The RNG_DR register is a read-only register.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RNDATA                     \ [0x00 : 32] RNDATA
  [then]


  [ifdef] RNG_RNG_HWCFGR_DEF
    \
    \ @brief RNG hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000006
    \
  [then]


  [ifdef] RNG_RNG_VERR_DEF
    \
    \ @brief RNG version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000021
    \
    $00 constant RNG_MINREV                     \ [0x00 : 4] MINREV
    $04 constant RNG_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] RNG_RNG_IPIDR_DEF
    \
    \ @brief RNG identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00170041
    \
    $00 constant RNG_ID                         \ [0x00 : 32] ID
  [then]


  [ifdef] RNG_RNG_SIDR_DEF
    \
    \ @brief RNG size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant RNG_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief RNG1
  \
  $00 constant RNG_RNG_CR               \ RNG control register
  $04 constant RNG_RNG_SR               \ RNG status register
  $08 constant RNG_RNG_DR               \ The RNG_DR register is a read-only register.
  $3F0 constant RNG_RNG_HWCFGR          \ RNG hardware configuration register
  $3F4 constant RNG_RNG_VERR            \ RNG version register
  $3F8 constant RNG_RNG_IPIDR           \ RNG identification register
  $3FC constant RNG_RNG_SIDR            \ RNG size ID register

: RNG_DEF ; [then]
