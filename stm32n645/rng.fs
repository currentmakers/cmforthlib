\
\ @file rng.fs
\ @brief True random number generator
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
$00000020 constant RNG_RNG_CR_CED                                   \ Clock error detection
$00000080 constant RNG_RNG_CR_ARDIS                                 \ Auto reset disable
$00000f00 constant RNG_RNG_CR_RNG_CONFIG3                           \ RNG configuration 3
$00001000 constant RNG_RNG_CR_NISTC                                 \ NIST custom
$0000e000 constant RNG_RNG_CR_RNG_CONFIG2                           \ RNG configuration 2
$000f0000 constant RNG_RNG_CR_CLKDIV                                \ Clock divider factor
$03f00000 constant RNG_RNG_CR_RNG_CONFIG1                           \ RNG configuration 1
$40000000 constant RNG_RNG_CR_CONDRST                               \ Conditioning soft reset
$80000000 constant RNG_RNG_CR_CONFIGLOCK                            \ RNG Config lock


\
\ @brief RNG status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RNG_RNG_SR_DRDY                                  \ Data ready
$00000002 constant RNG_RNG_SR_CECS                                  \ Clock error current status
$00000004 constant RNG_RNG_SR_SECS                                  \ Seed error current status
$00000020 constant RNG_RNG_SR_CEIS                                  \ Clock error interrupt status
$00000040 constant RNG_RNG_SR_SEIS                                  \ Seed error interrupt status


\
\ @brief RNG data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant RNG_RNG_DR_RNDATA                                \ Random data


\
\ @brief RNG noise source control register
\ Address offset: 0x0C
\ Reset value: 0x0003FFFF
\

$00000007 constant RNG_RNG_NSCR_EN_OSC1                             \ Each bit drives one oscillator enable signal input of instance number 1, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator). Bit is ignored otherwise.
$00000038 constant RNG_RNG_NSCR_EN_OSC2                             \ Each bit drives one oscillator enable signal input of instance number 2, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator). Bit is ignored otherwise.
$000001c0 constant RNG_RNG_NSCR_EN_OSC3                             \ Each bit drives one oscillator enable signal input of instance number 3, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator). Bit is ignored otherwise.
$00000e00 constant RNG_RNG_NSCR_EN_OSC4                             \ Each bit drives one oscillator enable signal input of instance number 4, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator). Bit is ignored otherwise.
$00007000 constant RNG_RNG_NSCR_EN_OSC5                             \ Each bit drives one oscillator enable signal input of instance number 5, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator). Bit is ignored otherwise.
$00038000 constant RNG_RNG_NSCR_EN_OSC6                             \ Each bit drives one oscillator enable signal input of instance number 6, gated with the RNGEN bit in RNG_CR (set bit to enable the oscillator). Bit is ignored otherwise.


\
\ @brief RNG health test control register
\ Address offset: 0x10
\ Reset value: 0x000072AC
\

$00000000 constant RNG_RNG_HTCR_HTCFG                               \ health test configuration


\
\ @brief True random number generator
\
$44020000 constant RNG_RNG_CR     \ offset: 0x00 : RNG control register
$44020004 constant RNG_RNG_SR     \ offset: 0x04 : RNG status register
$44020008 constant RNG_RNG_DR     \ offset: 0x08 : RNG data register
$4402000c constant RNG_RNG_NSCR   \ offset: 0x0C : RNG noise source control register
$44020010 constant RNG_RNG_HTCR   \ offset: 0x10 : RNG health test control register

