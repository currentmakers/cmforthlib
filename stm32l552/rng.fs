\
\ @file rng.fs
\ @brief RNG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RNG control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant RNG_RNG_CR_RNGEN                                 \ Random number generator enable
$00000008 constant RNG_RNG_CR_IE                                    \ Interrupt enable
$00000020 constant RNG_RNG_CR_CED                                   \ Clock error detection Note: The clock error detection can be used only when ck_rc48 or ck_pll1_q (ck_pll1_q = 48MHz) source is selected otherwise, CED bit must be equal to 1. The clock error detection cannot be enabled nor disabled on the fly when RNG peripheral is enabled, to enable or disable CED the RNG must be disabled.
$00000f00 constant RNG_RNG_CR_RNG_CONFIG3                           \ RNG configuration 3
$00001000 constant RNG_RNG_CR_NISTC                                 \ Non NIST compliant
$0000e000 constant RNG_RNG_CR_RNG_CONFIG2                           \ RNG configuration 2
$000f0000 constant RNG_RNG_CR_CLKDIV                                \ Clock divider factor
$03f00000 constant RNG_RNG_CR_RNG_CONFIG1                           \ RNG configuration 1
$40000000 constant RNG_RNG_CR_CONDRST                               \ Conditioning soft reset
$80000000 constant RNG_RNG_CR_CONFIGLOCK                            \ RNG Config Lock


\
\ @brief RNG status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RNG_RNG_SR_DRDY                                  \ Data ready Note: If IE=1 in RNG_CR, an interrupt is generated when DRDY=1. It can rise when the peripheral is disabled. When the output buffer becomes empty (after reading RNG_DR), this bit returns to 0 until a new random value is generated.
$00000002 constant RNG_RNG_SR_CECS                                  \ Clock error current status Note: This bit is meaningless if CED (Clock error detection) bit in RNG_CR is equal to 1.
$00000004 constant RNG_RNG_SR_SECS                                  \ Seed error current status ** More than 64 consecutive bits at the same value (0 or 1) ** More than 32 consecutive alternances of 0 and 1 (0101010101...01)
$00000020 constant RNG_RNG_SR_CEIS                                  \ Clock error interrupt status This bit is set at the same time as CECS. It is cleared by writing it to 0. An interrupt is pending if IE = 1 in the RNG_CR register. Note: This bit is meaningless if CED (Clock error detection) bit in RNG_CR is equal to 1.
$00000040 constant RNG_RNG_SR_SEIS                                  \ Seed error interrupt status This bit is set at the same time as SECS. It is cleared by writing it to 0. ** More than 64 consecutive bits at the same value (0 or 1) ** More than 32 consecutive alternances of 0 and 1 (0101010101...01) An interrupt is pending if IE = 1 in the RNG_CR register.


\
\ @brief The RNG_DR register is a read-only register that delivers a 32-bit random value when read. The content of this register is valid when DRDY= 1, even if RNGEN=0.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant RNG_RNG_DR_RNDATA                                \ Random data 32-bit random data which are valid when DRDY=1.


\
\ @brief The RNG_DR register is a read-only register that delivers a 32-bit random value when read. The content of this register is valid when DRDY= 1, even if RNGEN=0.
\ Address offset: 0x10
\ Reset value: 0x000CAA74
\

$00000000 constant RNG_RNG_HTCR_HTCFG                               \ health test configuration


\
\ @brief RNG
\
$420c0800 constant RNG_RNG_CR     \ offset: 0x00 : RNG control register
$420c0804 constant RNG_RNG_SR     \ offset: 0x04 : RNG status register
$420c0808 constant RNG_RNG_DR     \ offset: 0x08 : The RNG_DR register is a read-only register that delivers a 32-bit random value when read. The content of this register is valid when DRDY= 1, even if RNGEN=0.
$420c0810 constant RNG_RNG_HTCR   \ offset: 0x10 : The RNG_DR register is a read-only register that delivers a 32-bit random value when read. The content of this register is valid when DRDY= 1, even if RNGEN=0.

