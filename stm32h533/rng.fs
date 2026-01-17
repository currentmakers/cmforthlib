\
\ @file rng.fs
\ @brief RNG address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_RNG_CR_DEF
    \
    \ @brief RNG control register
    \ Address offset: 0x00
    \ Reset value: 0x00800D00
    \
    $02 constant RNG_RNGEN                      \ [0x02] True random number generator enable
    $03 constant RNG_IE                         \ [0x03] Interrupt enable
    $05 constant RNG_CED                        \ [0x05] Clock error detection
    $07 constant RNG_ARDIS                      \ [0x07] Auto reset disable
    $08 constant RNG_RNG_CONFIG3                \ [0x08 : 4] RNG configuration 3
    $0c constant RNG_NISTC                      \ [0x0c] NIST custom
    $0d constant RNG_RNG_CONFIG2                \ [0x0d : 3] RNG configuration 2
    $10 constant RNG_CLKDIV                     \ [0x10 : 4] Clock divider factor
    $14 constant RNG_RNG_CONFIG1                \ [0x14 : 6] RNG configuration 1
    $1e constant RNG_CONDRST                    \ [0x1e] Conditioning soft reset
    $1f constant RNG_CONFIGLOCK                 \ [0x1f] RNG Config lock
  [then]


  [ifdef] RNG_RNG_SR_DEF
    \
    \ @brief RNG status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_DRDY                       \ [0x00] Data ready
    $01 constant RNG_CECS                       \ [0x01] Clock error current status
    $02 constant RNG_SECS                       \ [0x02] Seed error current status
    $05 constant RNG_CEIS                       \ [0x05] Clock error interrupt status
    $06 constant RNG_SEIS                       \ [0x06] Seed error interrupt status
  [then]


  [ifdef] RNG_RNG_DR_DEF
    \
    \ @brief RNG data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RNDATA                     \ [0x00 : 32] Random data
  [then]


  [ifdef] RNG_RNG_NSCR_DEF
    \
    \ @brief RNG noise source control register
    \ Address offset: 0x0C
    \ Reset value: 0x0003FFFF
    \
    $00 constant RNG_EN_OSC1                    \ [0x00 : 3] Each bit drives one oscillator enable signal input of instance number 1, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator).
    $03 constant RNG_EN_OSC2                    \ [0x03 : 3] Each bit drives one oscillator enable signal input of instance number 2, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator).
    $06 constant RNG_EN_OSC3                    \ [0x06 : 3] Each bit drives one oscillator enable signal input of instance number 3, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator).
    $09 constant RNG_EN_OSC4                    \ [0x09 : 3] Each bit drives one oscillator enable signal input of instance number 4, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator).
    $0c constant RNG_EN_OSC5                    \ [0x0c : 3] Each bit drives one oscillator enable signal input of instance number 5, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator).
    $0f constant RNG_EN_OSC6                    \ [0x0f : 3] Each bit drives one oscillator enable signal input of instance number 6, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator).
  [then]


  [ifdef] RNG_RNG_HTCR_DEF
    \
    \ @brief RNG health test control register
    \ Address offset: 0x10
    \ Reset value: 0x000072AC
    \
    $00 constant RNG_HTCFG                      \ [0x00 : 32] health test configuration
  [then]

  \
  \ @brief RNG address block description
  \
  $00 constant RNG_RNG_CR               \ RNG control register
  $04 constant RNG_RNG_SR               \ RNG status register
  $08 constant RNG_RNG_DR               \ RNG data register
  $0C constant RNG_RNG_NSCR             \ RNG noise source control register
  $10 constant RNG_RNG_HTCR             \ RNG health test control register

: RNG_DEF ; [then]
