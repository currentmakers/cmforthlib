\
\ @file rng.fs
\ @brief TRNG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_RNG_CR_DEF
    \
    \ @brief RNG_CR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant RNG_RNG_DIS                    \ [0x02] RNG Disable bit.
    $03 constant RNG_TST_CLK                    \ [0x03] RNG Test Clock bit.
  [then]


  [ifdef] RNG_RNG_SR_DEF
    \
    \ @brief RNG_SR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RNGRDY                     \ [0x00] New Random Value Ready.
    $01 constant RNG_REVCLK                     \ [0x01] RNGCLK Clock Reveal bit.
    $02 constant RNG_FAULT                      \ [0x02] Fault Reveal bit.
  [then]


  [ifdef] RNG_RNG_VAL_DEF
    \
    \ @brief RNG_VAL register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RANDOM_VALUE               \ [0x00 : 16] Random Value
  [then]

  \
  \ @brief TRNG
  \
  $00 constant RNG_RNG_CR               \ RNG_CR register
  $04 constant RNG_RNG_SR               \ RNG_SR register
  $08 constant RNG_RNG_VAL              \ RNG_VAL register

: RNG_DEF ; [then]
