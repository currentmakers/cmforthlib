\
\ @file rng.fs
\ @brief RNG_CR register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RNG_CR register
\ Address offset: 0x00
\ Reset value: 0x0000FF00
\

$00000002 constant RNG_RNG_CR_RNG_DIS                               \ This bit enables or disables the random number generator. 0: RNG is enabled (default) 1: RNG is disabled. The internal free-running oscillators are put in power-down mode and the RNG clock is stopped at the input of the block.
$00000008 constant RNG_RNG_CR_TST_CLK                               \ Reset reveal clock error flags when writing a '1' without resetting the whole TRNG. When writing a 1, the value remains until it is seen by RNG core clock domain after resynchronization. Then it is automatically reset.


\
\ @brief RNG_SR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RNG_RNG_SR_RNGRDY                                \ New random value ready
$00000002 constant RNG_RNG_SR_REVCLK                                \ RNGCLK clock reveal bit.
$00000004 constant RNG_RNG_SR_FAULT                                 \ Fault reveal bit.


\
\ @brief RNG_VAL register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant RNG_RNG_VAL_RND_VAL                              \ Random value


\
\ @brief RNG_CR register
\
$48600000 constant RNG_RNG_CR     \ offset: 0x00 : RNG_CR register
$48600004 constant RNG_RNG_SR     \ offset: 0x04 : RNG_SR register
$48600008 constant RNG_RNG_VAL    \ offset: 0x08 : RNG_VAL register

