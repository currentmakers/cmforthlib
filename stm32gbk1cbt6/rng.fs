\
\ @file rng.fs
\ @brief Random number generator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant RNG_RNGEN                      \ [0x02] Random number generator enable
    $03 constant RNG_IE                         \ [0x03] Interrupt enable
    $05 constant RNG_CED                        \ [0x05] Clock error detection
  [then]


  [ifdef] RNG_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_DRDY                       \ [0x00] Data ready
    $01 constant RNG_CECS                       \ [0x01] Clock error current status
    $02 constant RNG_SECS                       \ [0x02] Seed error current status
    $05 constant RNG_CEIS                       \ [0x05] Clock error interrupt status
    $06 constant RNG_SEIS                       \ [0x06] Seed error interrupt status
  [then]


  [ifdef] RNG_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RNDATA                     \ [0x00 : 32] Random data
  [then]

  \
  \ @brief Random number generator
  \
  $00 constant RNG_CR                   \ control register
  $04 constant RNG_SR                   \ status register
  $08 constant RNG_DR                   \ data register

: RNG_DEF ; [then]
