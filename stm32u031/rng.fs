\
\ @file rng.fs
\ @brief RNG address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RNG control register
\ Address offset: 0x00
\ Reset value: 0x00800D00
\

$00000004 constant RNG_RNG_CR_RNGEN                                 \ True random number generator enable
$00000008 constant RNG_RNG_CR_IE                                    \ Interrupt enable
$00000020 constant RNG_RNG_CR_CED                                   \ Clock error detection The clock error detection cannot be enabled nor disabled on-the-fly when the RNG is enabled, that is to enable or disable CED, the RNG must be disabled. Writing this bit is taken into account only if the CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK1=11.
$00000080 constant RNG_RNG_CR_ARDIS                                 \ Auto reset disable When auto-reset is enabled the application still need to clear the SEIS bit after a noise source error. Writing this bit is taken into account only if CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK1=11.
$00000f00 constant RNG_RNG_CR_RNG_CONFIG3                           \ RNG configuration 3 Reserved to the RNG configuration (bitfield 3). Refer to RNG_CONFIG1 bitfield for details. If the NISTC bit is cleared in this register RNG_CONFIG3 bitfield values are ignored by RNG.
$00001000 constant RNG_RNG_CR_NISTC                                 \ NIST custom two conditioning loops are performed and 256 bits of noise source are used. Writing this bit is taken into account only if CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK1=11.
$0000e000 constant RNG_RNG_CR_RNG_CONFIG2                           \ RNG configuration 2 Reserved to the RNG configuration (bitfield 2). Bit 13 can be set when RNG power consumption is critical. See Section120.3.8: RNG low-power use. Refer to the RNG_CONFIG1 bitfield for details.
$000f0000 constant RNG_RNG_CR_CLKDIV                                \ Clock divider factor This value used to configure an internal programmable divider (from 1 to 16) acting on the incoming RNG clock. These bits can be written only when the core is disabled (RNGEN1=10). ... Writing these bits is taken into account only if the CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK1=11.
$03f00000 constant RNG_RNG_CR_RNG_CONFIG1                           \ RNG configuration 1 Reserved to the RNG configuration (bitfield 1). Must be initialized using the recommended value documented in Section120.6: RNG entropy source validation. Writing any bit of RNG_CONFIG1 is taken into account only if the CONDRST bit is set to 1 in the same access, while CONFIGLOCK remains at 0. Writing to this bit is ignored if CONFIGLOCK1=11.
$40000000 constant RNG_RNG_CR_CONDRST                               \ Conditioning soft reset Write 1 and then write 0 to reset the conditioning logic, clear all the FIFOs and start a new RNG initialization process, with RNG_SR cleared. Registers RNG_CR and RNG_HTCR are not changed by CONDRST. This bit must be set to 1 in the same access that set any configuration bits [29:4]. In other words, when CONDRST bit is set to 1 correct configuration in bits [29:4] must also be written. When CONDRST is set to 0 by the software, its value goes to 0 when the reset process is done. It takes about 2 AHB clock cycles + 2 RNG clock cycles.
$80000000 constant RNG_RNG_CR_CONFIGLOCK                            \ RNG Config lock This bitfield is set once: if this bit is set it can only be reset to 0 if RNG is reset.


\
\ @brief RNG status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RNG_RNG_SR_DRDY                                  \ Data ready Once the output buffer becomes empty (after reading the RNG_DR register), this bit returns to 0 until a new random value is generated. Note: The DRDY bit can rise when the peripheral is disabled (RNGEN1=10 in the RNG_CR register). If IE=1 in the RNG_CR register, an interrupt is generated when DRDY1=11.
$00000002 constant RNG_RNG_SR_CECS                                  \ Clock error current status Note: CECS bit is valid only if the CED bit in the RNG_CR register is set to 0.
$00000004 constant RNG_RNG_SR_SECS                                  \ Seed error current status Runtime repetition count test failed (noise source has provided more than 24 consecutive bits at a constant value 0 or 1, or more than 32 consecutive occurrence of two bits patterns 01 or 10) Startup or continuous adaptive proportion test on noise source failed. Startup post-processing/conditioning sanity check failed.
$00000020 constant RNG_RNG_SR_CEIS                                  \ Clock error interrupt status This bit is set at the same time as CECS. It is cleared by writing 0. Writing 1 has no effect. An interrupt is pending if IE = 1 in the RNG_CR register.
$00000040 constant RNG_RNG_SR_SEIS                                  \ Seed error interrupt status This bit is set at the same time as SECS. It is cleared by writing 0 (unless CONDRST is used). Writing 1 has no effect. An interrupt is pending if IE = 1 in the RNG_CR register.


\
\ @brief RNG data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant RNG_RNG_DR_RNDATA                                \ Random data 32-bit random data, which are valid when DRDY1=11. When DRDY1=10, the RNDATA value is1zero. When DRDY is set, it is recommended to always verify that RNG_DR is different from zero. Because when it is the case a seed error occurred between RNG_SR polling and RND_DR output reading (rare event).


\
\ @brief RNG health test control register
\ Address offset: 0x10
\ Reset value: 0x000072AC
\

$00000000 constant RNG_RNG_HTCR_HTCFG                               \ health test configuration This configuration is used by RNG to configure the health tests. See Section120.6: RNG entropy source validation for the recommended value. Note: The RNG behavior, including the read to this register, is not guaranteed if a different value from the recommended value is written.


\
\ @brief RNG address block description
\
$40025000 constant RNG_RNG_CR     \ offset: 0x00 : RNG control register
$40025004 constant RNG_RNG_SR     \ offset: 0x04 : RNG status register
$40025008 constant RNG_RNG_DR     \ offset: 0x08 : RNG data register
$40025010 constant RNG_RNG_HTCR   \ offset: 0x10 : RNG health test control register

