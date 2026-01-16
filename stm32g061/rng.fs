\
\ @file rng.fs
\ @brief Random number generator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant RNG_RNG_CR_RNGEN                                 \ True random number generator enable
$00000008 constant RNG_RNG_CR_IE                                    \ Interrupt Enable
$00000020 constant RNG_RNG_CR_CED                                   \ Clock error detection The clock error detection cannot be enabled nor disabled on-the-fly when the RNG is enabled, i.e. to enable or disable CED the RNG must be disabled.


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RNG_RNG_SR_DRDY                                  \ Data Ready Once the output buffer becomes empty (after reading the RNG_DR register), this bit returns to 0 until a new random value is generated. Note: The DRDY bit can rise when the peripheral is disabled (RNGEN=0 in the RNG_CR register). If IE=1 in the RNG_CR register, an interrupt is generated when DRDY=1.
$00000002 constant RNG_RNG_SR_CECS                                  \ Clock error current status Note: CECS bit is valid only if the CED bit in the RNG_CR register is set to 0.
$00000004 constant RNG_RNG_SR_SECS                                  \ Seed error current status One of the noise source has provided more than 64 consecutive bits at a constant value ('0' or '1'), or more than 32 consecutive occurrence of two bit patterns ('01' or '10') Both noise sources have delivered more than 32 consecutive bits at a constant value ('0' or '1'), or more than 16 consecutive occurrence of two bit patterns ('01' or '10')
$00000020 constant RNG_RNG_SR_CEIS                                  \ Clock error interrupt status This bit is set at the same time as CECS. It is cleared by writing 0. Writing 1 has no effect. An interrupt is pending if IE = 1 in the RNG_CR register.
$00000040 constant RNG_RNG_SR_SEIS                                  \ Seed error interrupt status This bit is set at the same time as SECS. It is cleared by writing 0. Writing 1 has no effect. An interrupt is pending if IE = 1 in the RNG_CR register.


\
\ @brief RNG data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant RNG_RNG_DR_RNDATA                                \ Random data 32-bit random data which are valid when DRDY=1. When DRDY=0 RNDATA value is zero. It is recommended to always verify that RNG_DR is different from zero. Because when it is the case a seed error occurred between RNG_SR polling and RND_DR output reading (rare event).


\
\ @brief Random number generator
\
$40025000 constant RNG_RNG_CR     \ offset: 0x00 : control register
$40025004 constant RNG_RNG_SR     \ offset: 0x04 : status register
$40025008 constant RNG_RNG_DR     \ offset: 0x08 : RNG data register

