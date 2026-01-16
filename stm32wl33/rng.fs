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
\ @brief RNG_TCR register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant RNG_RNG_TCR_TCR                                  \ Test-control register


\
\ @brief RNG_ITIP register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant RNG_RNG_ITIP_ITIP                                \ Integration-test input register


\
\ @brief RNGPeriphID0 register
\ Address offset: 0xFE0
\ Reset value: 0x000000E1
\

$000000ff constant RNG_RNGPERIPHID0_PARTNUMBER0                     \ These bits are read back as 0xE1


\
\ @brief RNGPeriphID1 register
\ Address offset: 0xFE4
\ Reset value: 0x00000005
\

$0000000f constant RNG_RNGPERIPHID1_PARTNUMBER1                     \ These bits are read back as 0x05
$000000f0 constant RNG_RNGPERIPHID1_DESIGNER0                       \ These bits are read back as 0x00


\
\ @brief RNGPeriphID2 register
\ Address offset: 0xFE8
\ Reset value: 0x00000028
\

$0000000f constant RNG_RNGPERIPHID2_DESIGNER1                       \ These bits are read back as 0x08
$000000f0 constant RNG_RNGPERIPHID2_REVISION                        \ These bits are read back as 0x02


\
\ @brief RNGPeriphID3 register
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$000000ff constant RNG_RNGPERIPHID3_CONFIGURATION                   \ These bits are read back as 0x00


\
\ @brief RNGPCellID0 register
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant RNG_RNGPCELLID0_RNGPCELLID0                      \ These bits are read back as 0x0D


\
\ @brief RNGPCellID1 register
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$000000ff constant RNG_RNGPCELLID1_RNGPCELLID1                      \ These bits are read back as 0xF0


\
\ @brief RNGPCellID2 register
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$000000ff constant RNG_RNGPCELLID2_RNGPCELLID2                      \ These bits are read back as 0x05


\
\ @brief RNGPCellID3 register
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant RNG_RNGPCELLID3_RNGPCELLID3                      \ These bits are read back as 0xB1


\
\ @brief RNG_CR register
\
$48600000 constant RNG_RNG_CR     \ offset: 0x00 : RNG_CR register
$48600004 constant RNG_RNG_SR     \ offset: 0x04 : RNG_SR register
$48600008 constant RNG_RNG_VAL    \ offset: 0x08 : RNG_VAL register
$48600080 constant RNG_RNG_TCR    \ offset: 0x80 : RNG_TCR register
$48600084 constant RNG_RNG_ITIP   \ offset: 0x84 : RNG_ITIP register
$48600fe0 constant RNG_RNGPERIPHID0  \ offset: 0xFE0 : RNGPeriphID0 register
$48600fe4 constant RNG_RNGPERIPHID1  \ offset: 0xFE4 : RNGPeriphID1 register
$48600fe8 constant RNG_RNGPERIPHID2  \ offset: 0xFE8 : RNGPeriphID2 register
$48600fec constant RNG_RNGPERIPHID3  \ offset: 0xFEC : RNGPeriphID3 register
$48600ff0 constant RNG_RNGPCELLID0  \ offset: 0xFF0 : RNGPCellID0 register
$48600ff4 constant RNG_RNGPCELLID1  \ offset: 0xFF4 : RNGPCellID1 register
$48600ff8 constant RNG_RNGPCELLID2  \ offset: 0xFF8 : RNGPCellID2 register
$48600ffc constant RNG_RNGPCELLID3  \ offset: 0xFFC : RNGPCellID3 register

