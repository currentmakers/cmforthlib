\
\ @file rng.fs
\ @brief Random number generator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_RNG_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant RNG_RNGEN                      \ [0x02] True random number generator enable
    $03 constant RNG_IE                         \ [0x03] Interrupt Enable
    $05 constant RNG_CED                        \ [0x05] Clock error detection The clock error detection cannot be enabled nor disabled on-the-fly when the RNG is enabled, i.e. to enable or disable CED the RNG must be disabled.
  [then]


  [ifdef] RNG_RNG_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_DRDY                       \ [0x00] Data Ready Once the output buffer becomes empty (after reading the RNG_DR register), this bit returns to 0 until a new random value is generated. Note: The DRDY bit can rise when the peripheral is disabled (RNGEN=0 in the RNG_CR register). If IE=1 in the RNG_CR register, an interrupt is generated when DRDY=1.
    $01 constant RNG_CECS                       \ [0x01] Clock error current status Note: CECS bit is valid only if the CED bit in the RNG_CR register is set to 0.
    $02 constant RNG_SECS                       \ [0x02] Seed error current status One of the noise source has provided more than 64 consecutive bits at a constant value ('0' or '1'), or more than 32 consecutive occurrence of two bit patterns ('01' or '10') Both noise sources have delivered more than 32 consecutive bits at a constant value ('0' or '1'), or more than 16 consecutive occurrence of two bit patterns ('01' or '10')
    $05 constant RNG_CEIS                       \ [0x05] Clock error interrupt status This bit is set at the same time as CECS. It is cleared by writing 0. Writing 1 has no effect. An interrupt is pending if IE = 1 in the RNG_CR register.
    $06 constant RNG_SEIS                       \ [0x06] Seed error interrupt status This bit is set at the same time as SECS. It is cleared by writing 0. Writing 1 has no effect. An interrupt is pending if IE = 1 in the RNG_CR register.
  [then]


  [ifdef] RNG_RNG_DR_DEF
    \
    \ @brief RNG data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RNDATA                     \ [0x00 : 32] Random data 32-bit random data which are valid when DRDY=1. When DRDY=0 RNDATA value is zero. It is recommended to always verify that RNG_DR is different from zero. Because when it is the case a seed error occurred between RNG_SR polling and RND_DR output reading (rare event).
  [then]

  \
  \ @brief Random number generator
  \
  $00 constant RNG_RNG_CR               \ control register
  $04 constant RNG_RNG_SR               \ status register
  $08 constant RNG_RNG_DR               \ RNG data register

: RNG_DEF ; [then]
