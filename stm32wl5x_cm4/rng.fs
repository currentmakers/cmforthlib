\
\ @file rng.fs
\ @brief True random number generator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00800000
\

$00000004 constant RNG_CR_RNGEN                                     \ True random number generator enable
$00000008 constant RNG_CR_IE                                        \ Interrupt Enable
$00000020 constant RNG_CR_CED                                       \ Interrupt Enable
$00000f00 constant RNG_CR_RNG_CONFIG3                               \ RNG_CONFIG3
$00001000 constant RNG_CR_NISTC                                     \ NISTC
$0000e000 constant RNG_CR_RNG_CONFIG2                               \ RNG_CONFIG2
$000f0000 constant RNG_CR_CLKDIV                                    \ CLKDIV
$03f00000 constant RNG_CR_RNG_CONFIG1                               \ RNG_CONFIG1
$40000000 constant RNG_CR_CONDRST                                   \ Conditioning soft reset
$80000000 constant RNG_CR_CONFIGLOCK                                \ CONFIGLOCK


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant RNG_SR_DRDY                                      \ Data Ready
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
\ @brief health test control register
\ Address offset: 0x10
\ Reset value: 0x00005A4E
\

$00000000 constant RNG_HTCR_HTCFG                                   \ health test configuration


\
\ @brief True random number generator
\
$58001000 constant RNG_CR         \ offset: 0x00 : control register
$58001004 constant RNG_SR         \ offset: 0x04 : status register
$58001008 constant RNG_DR         \ offset: 0x08 : data register
$58001010 constant RNG_HTCR       \ offset: 0x10 : health test control register

