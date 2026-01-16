\
\ @file rng.fs
\ @brief TRNG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RNG_CR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant RNG_RNG_CR_RNG_DIS                               \ RNG Disable bit.
$00000008 constant RNG_RNG_CR_TST_CLK                               \ RNG Test Clock bit.


\
\ @brief RNG_SR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RNG_RNG_SR_RNGRDY                                \ New Random Value Ready.
$00000002 constant RNG_RNG_SR_REVCLK                                \ RNGCLK Clock Reveal bit.
$00000004 constant RNG_RNG_SR_FAULT                                 \ Fault Reveal bit.


\
\ @brief RNG_VAL register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant RNG_RNG_VAL_RANDOM_VALUE                         \ Random Value


\
\ @brief TRNG
\
$48600000 constant RNG_RNG_CR     \ offset: 0x00 : RNG_CR register
$48600004 constant RNG_RNG_SR     \ offset: 0x04 : RNG_SR register
$48600008 constant RNG_RNG_VAL    \ offset: 0x08 : RNG_VAL register

