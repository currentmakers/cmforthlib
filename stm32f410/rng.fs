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

$00000004 constant RNG_CR_RNGEN                                     \ Random number generator enable
$00000008 constant RNG_CR_IE                                        \ Interrupt enable


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RNG_SR_DRDY                                      \ Data ready
$00000002 constant RNG_SR_CECS                                      \ Clock error current status
$00000004 constant RNG_SR_SECS                                      \ Seed error current status
$00000020 constant RNG_SR_CEIS                                      \ Clock error interrupt status
$00000040 constant RNG_SR_SEIS                                      \ Seed error interrupt status


\
\ @brief data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant RNG_DR_RNDATA                                    \ Random data


\
\ @brief Random number generator
\
$40080000 constant RNG_CR         \ offset: 0x00 : control register
$40080004 constant RNG_SR         \ offset: 0x04 : status register
$40080008 constant RNG_DR         \ offset: 0x08 : data register

