\
\ @file sec_rng.fs
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

$00000004 constant SEC_RNG_CR_RNGEN                                 \ True random number generator enable
$00000008 constant SEC_RNG_CR_IE                                    \ Interrupt Enable
$00000020 constant SEC_RNG_CR_CED                                   \ Clock error detection
$00000080 constant SEC_RNG_CR_ARDIS                                 \ Auto reset disable
$00000f00 constant SEC_RNG_CR_RNG_CONFIG3                           \ RNG configuration 3
$00001000 constant SEC_RNG_CR_NISTC                                 \ Non NIST compliant
$0000e000 constant SEC_RNG_CR_RNG_CONFIG2                           \ RNG configuration 2
$000f0000 constant SEC_RNG_CR_CLKDIV                                \ Clock divider factor
$03f00000 constant SEC_RNG_CR_RNG_CONFIG1                           \ RNG configuration 1
$40000000 constant SEC_RNG_CR_CONDRST                               \ Conditioning soft reset
$80000000 constant SEC_RNG_CR_CONFIGLOCK                            \ RNG Config Lock


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_RNG_SR_DRDY                                  \ Data ready
$00000002 constant SEC_RNG_SR_CECS                                  \ Clock error current status
$00000004 constant SEC_RNG_SR_SECS                                  \ Seed error current status
$00000020 constant SEC_RNG_SR_CEIS                                  \ Clock error interrupt status
$00000040 constant SEC_RNG_SR_SEIS                                  \ Seed error interrupt status


\
\ @brief data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_RNG_DR_RNDATA                                \ Random data


\
\ @brief health test control register
\ Address offset: 0x10
\ Reset value: 0x00006274
\

$00000000 constant SEC_RNG_HTCR_HTCFG                               \ health test configuration


\
\ @brief Random number generator
\
$520c0800 constant SEC_RNG_CR     \ offset: 0x00 : control register
$520c0804 constant SEC_RNG_SR     \ offset: 0x04 : status register
$520c0808 constant SEC_RNG_DR     \ offset: 0x08 : data register
$520c0810 constant SEC_RNG_HTCR   \ offset: 0x10 : health test control register

