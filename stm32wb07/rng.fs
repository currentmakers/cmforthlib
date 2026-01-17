\
\ @file rng.fs
\ @brief RNG_CR register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_RNG_CR_DEF
    \
    \ @brief RNG_CR register
    \ Address offset: 0x00
    \ Reset value: 0x0000FF00
    \
    $01 constant RNG_RNG_DIS                    \ [0x01] This bit enables or disables the random number generator. 0: RNG is enabled (default) 1: RNG is disabled. The internal free-running oscillators are put in power-down mode and the RNG clock is stopped at the input of the block.
    $03 constant RNG_TST_CLK                    \ [0x03] Reset reveal clock error flags when writing a '1' without resetting the whole TRNG. When writing a 1, the value remains until it is seen by RNG core clock domain after resynchronization. Then it is automatically reset.
  [then]


  [ifdef] RNG_RNG_SR_DEF
    \
    \ @brief RNG_SR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RNGRDY                     \ [0x00] New random value ready
    $01 constant RNG_REVCLK                     \ [0x01] RNGCLK clock reveal bit.
    $02 constant RNG_FAULT                      \ [0x02] Fault reveal bit.
  [then]


  [ifdef] RNG_RNG_VAL_DEF
    \
    \ @brief RNG_VAL register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RND_VAL                    \ [0x00 : 16] Random value
  [then]

  \
  \ @brief RNG_CR register
  \
  $00 constant RNG_RNG_CR               \ RNG_CR register
  $04 constant RNG_RNG_SR               \ RNG_SR register
  $08 constant RNG_RNG_VAL              \ RNG_VAL register

: RNG_DEF ; [then]
