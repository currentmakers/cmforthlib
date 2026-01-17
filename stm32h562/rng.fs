\
\ @file rng.fs
\ @brief True random number generator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_RNG_CR_DEF
    \
    \ @brief RNG control register
    \ Address offset: 0x00
    \ Reset value: 0x00871F00
    \
    $02 constant RNG_RNGEN                      \ [0x02] True random number generator enable
    $03 constant RNG_IE                         \ [0x03] Interrupt Enable
    $05 constant RNG_CED                        \ [0x05] Clock error detection The clock error detection cannot be enabled nor disabled on-the-fly when the RNG is enabled, i.e. to enable or disable CED the RNG must be disabled. Writing this bit is taken into account only if CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK=1.
    $07 constant RNG_ARDIS                      \ [0x07] Auto reset disable When auto-reset is enabled application still need to clear SEIS bit after a noise source error. Writing this bit is taken into account only if CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK=1.
    $08 constant RNG_RNG_CONFIG3                \ [0x08 : 4] RNG configuration 3 Reserved to the RNG configuration (bitfield 3). Refer to RNG_CONFIG1 bitfield for details. If NISTC bit is cleared in this register RNG_CONFIG3 bitfield values are ignored by RNG.
    $0c constant RNG_NISTC                      \ [0x0c] Non NIST compliant four conditioning loops are performed and 512 bits of noise source are used. Writing this bit is taken into account only if CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK=1.
    $0d constant RNG_RNG_CONFIG2                \ [0x0d : 3] RNG configuration 2 Reserved to the RNG configuration (bitfield 2). Refer to RNG_CONFIG1 bitfield for details.
    $10 constant RNG_CLKDIV                     \ [0x10 : 4] Clock divider factor This value used to configure an internal programmable divider (from 1 to 16) acting on the incoming RNG clock. These bits can be written only when the core is disabled (RNGEN=0). ... Writing these bits is taken into account only if CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK=1.
    $14 constant RNG_RNG_CONFIG1                \ [0x14 : 6] RNG configuration 1 Reserved to the RNG configuration (bitfield 1). Must be initialized using the recommended value documented in . Writing any bit of RNG_CONFIG1 is taken into account only if CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK=1.
    $1e constant RNG_CONDRST                    \ [0x1e] Conditioning soft reset Write 1 and then write 0 to reset the conditioning logic, clear all the FIFOs and start a new RNG initialization process, with RNG_SR cleared. Registers RNG_CR and RNG_NSCR are not changed by CONDRST. This bit must be set to 1 in the same access that set any configuration bits [29:4]. In other words, when CONDRST bit is set to 1 correct configuration in bits [29:4] must also be written. When CONDRST is set to 0 by software its value goes to 0 when the reset process is done. It takes about 2 AHB clock cycles + 2 RNG clock cycles.
    $1f constant RNG_CONFIGLOCK                 \ [0x1f] RNG Config Lock This bitfield is set once: if this bit is set it can only be reset to 0 if RNG is reset.
  [then]


  [ifdef] RNG_RNG_SR_DEF
    \
    \ @brief RNG status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_DRDY                       \ [0x00] Data Ready Once the output buffer becomes empty (after reading the RNG_DR register), this bit returns to 0 until a new random value is generated. Note: The DRDY bit can rise when the peripheral is disabled (RNGEN=0 in the RNG_CR register). If IE=1 in the RNG_CR register, an interrupt is generated when DRDY=1.
    $01 constant RNG_CECS                       \ [0x01] Clock error current status Note: CECS bit is valid only if the CED bit in the RNG_CR register is set to 0.
    $02 constant RNG_SECS                       \ [0x02] Seed error current status Run-time repetition count test failed (noise source has provided more than 24 consecutive bits at a constant value 0' or 1', or more than 32 consecutive occurrence of two bits patterns 01' or 10') Start-up or continuous adaptive proportion test on noise source failed. Start-up post-processing/conditioning sanity check failed.
    $05 constant RNG_CEIS                       \ [0x05] Clock error interrupt status This bit is set at the same time as CECS. It is cleared by writing 0. Writing 1 has no effect. An interrupt is pending if IE = 1 in the RNG_CR register.
    $06 constant RNG_SEIS                       \ [0x06] Seed error interrupt status This bit is set at the same time as SECS. It is cleared by writing 0 (unless CONDRST is used). Writing 1 has no effect. An interrupt is pending if IE = 1 in the RNG_CR register.
  [then]


  [ifdef] RNG_RNG_DR_DEF
    \
    \ @brief RNG data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RNDATA                     \ [0x00 : 32] Random data 32-bit random data which are valid when DRDY=1. When DRDY=0 RNDATA value is zero. It is recommended to always verify that RNG_DR is different from zero. Because when it is the case a seed error occurred between RNG_SR polling and RND_DR output reading (rare event).
  [then]


  [ifdef] RNG_RNG_NSCR_DEF
    \
    \ @brief RNG noise source control register
    \ Address offset: 0x0C
    \ Reset value: 0x0003FFFF
    \
    $00 constant RNG_EN_OSC1                    \ [0x00 : 3] When the RNG is enabled (RNGEN bit set), each bit of this bitfield enables one of the three inputs from the oscillator instance number 1.
    $03 constant RNG_EN_OSC2                    \ [0x03 : 3] When the RNG is enabled (RNGEN bit set), each bit of this bitfield enables one of the three inputs from the oscillator instance number 2.
    $06 constant RNG_EN_OSC3                    \ [0x06 : 3] When the RNG is enabled (RNGEN bit set), each bit of this bitfield enables one of the three inputs from the oscillator instance number 3.
    $09 constant RNG_EN_OSC4                    \ [0x09 : 3] When the RNG is enabled (RNGEN bit set), each bit of this bitfield enables one of the three inputs from the oscillator instance number 4.
    $0c constant RNG_EN_OSC5                    \ [0x0c : 3] When the RNG is enabled (RNGEN bit set), each bit of this bitfield enables one of the three inputs from the oscillator instance number 5.
    $0f constant RNG_EN_OSC6                    \ [0x0f : 3] When the RNG is enabled (RNGEN bit set), each bit of this bitfield enables one of the three inputs from the oscillator instance number 6.
  [then]


  [ifdef] RNG_RNG_HTCR_DEF
    \
    \ @brief RNG health test control register
    \ Address offset: 0x10
    \ Reset value: 0x000072AC
    \
    $00 constant RNG_HTCFG                      \ [0x00 : 32] health test configuration This configuration is used by RNG to configure the health tests. See entropy source validation for the recommended value. Note: The RNG behavior, including the read to this register, is not guaranteed if a different value from the recommended value is written.
  [then]

  \
  \ @brief True random number generator
  \
  $00 constant RNG_RNG_CR               \ RNG control register
  $04 constant RNG_RNG_SR               \ RNG status register
  $08 constant RNG_RNG_DR               \ RNG data register
  $0C constant RNG_RNG_NSCR             \ RNG noise source control register
  $10 constant RNG_RNG_HTCR             \ RNG health test control register

: RNG_DEF ; [then]
