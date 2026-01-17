\
\ @file rng.fs
\ @brief True random number generator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00800000
    \
    $02 constant RNG_RNGEN                      \ [0x02] True random number generator enable
    $03 constant RNG_IE                         \ [0x03] Interrupt Enable
    $05 constant RNG_CED                        \ [0x05] Interrupt Enable
    $08 constant RNG_RNG_CONFIG3                \ [0x08 : 4] RNG_CONFIG3
    $0c constant RNG_NISTC                      \ [0x0c] NISTC
    $0d constant RNG_RNG_CONFIG2                \ [0x0d : 3] RNG_CONFIG2
    $10 constant RNG_CLKDIV                     \ [0x10 : 4] CLKDIV
    $14 constant RNG_RNG_CONFIG1                \ [0x14 : 6] RNG_CONFIG1
    $1e constant RNG_CONDRST                    \ [0x1e] Conditioning soft reset
    $1f constant RNG_CONFIGLOCK                 \ [0x1f] CONFIGLOCK
  [then]


  [ifdef] RNG_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_DRDY                       \ [0x00] Data Ready
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


  [ifdef] RNG_HTCR_DEF
    \
    \ @brief health test control register
    \ Address offset: 0x10
    \ Reset value: 0x00005A4E
    \
    $00 constant RNG_HTCFG                      \ [0x00 : 32] health test configuration
  [then]

  \
  \ @brief True random number generator
  \
  $00 constant RNG_CR                   \ control register
  $04 constant RNG_SR                   \ status register
  $08 constant RNG_DR                   \ data register
  $10 constant RNG_HTCR                 \ health test control register

: RNG_DEF ; [then]
