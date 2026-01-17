\
\ @file rng.fs
\ @brief RNG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_CR_DEF
    \
    \ @brief RNG control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant RNG_RNGEN                      \ [0x02] Random number generator enable
    $03 constant RNG_IE                         \ [0x03] Interrupt enable
    $05 constant RNG_CED                        \ [0x05] Clock error detection Note: The clock error detection can be used only when ck_rc48 or ck_pll1_q (ck_pll1_q = 48MHz) source is selected otherwise, CED bit must be equal to 1. The clock error detection cannot be enabled nor disabled on the fly when RNG peripheral is enabled, to enable or disable CED the RNG must be disabled.
  [then]


  [ifdef] RNG_SR_DEF
    \
    \ @brief RNG status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_DRDY                       \ [0x00] Data ready Note: If IE=1 in RNG_CR, an interrupt is generated when DRDY=1. It can rise when the peripheral is disabled. When the output buffer becomes empty (after reading RNG_DR), this bit returns to 0 until a new random value is generated.
    $01 constant RNG_CECS                       \ [0x01] Clock error current status Note: This bit is meaningless if CED (Clock error detection) bit in RNG_CR is equal to 1.
    $02 constant RNG_SECS                       \ [0x02] Seed error current status ** More than 64 consecutive bits at the same value (0 or 1) ** More than 32 consecutive alternances of 0 and 1 (0101010101...01)
    $05 constant RNG_CEIS                       \ [0x05] Clock error interrupt status This bit is set at the same time as CECS. It is cleared by writing it to 0. An interrupt is pending if IE = 1 in the RNG_CR register. Note: This bit is meaningless if CED (Clock error detection) bit in RNG_CR is equal to 1.
    $06 constant RNG_SEIS                       \ [0x06] Seed error interrupt status This bit is set at the same time as SECS. It is cleared by writing it to 0. ** More than 64 consecutive bits at the same value (0 or 1) ** More than 32 consecutive alternances of 0 and 1 (0101010101...01) An interrupt is pending if IE = 1 in the RNG_CR register.
  [then]


  [ifdef] RNG_DR_DEF
    \
    \ @brief The RNG_DR register is a read-only register that delivers a 32-bit random value when read. The content of this register is valid when DRDY= 1, even if RNGEN=0.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RNDATA                     \ [0x00 : 32] Random data 32-bit random data which are valid when DRDY=1.
  [then]

  \
  \ @brief RNG
  \
  $00 constant RNG_CR                   \ RNG control register
  $04 constant RNG_SR                   \ RNG status register
  $08 constant RNG_DR                   \ The RNG_DR register is a read-only register that delivers a 32-bit random value when read. The content of this register is valid when DRDY= 1, even if RNGEN=0.

: RNG_DEF ; [then]
