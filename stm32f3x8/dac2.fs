\
\ @file dac2.fs
\ @brief Digital-to-analog converter
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

$00000001 constant DAC2_CR_EN1                                      \ DAC channel1 enable
$00000002 constant DAC2_CR_BOFF1                                    \ DAC channel1 output buffer disable
$00000004 constant DAC2_CR_TEN1                                     \ DAC channel1 trigger enable
$00000038 constant DAC2_CR_TSEL1                                    \ DAC channel1 trigger selection
$00000040 constant DAC2_CR_WAVE2                                    \ WAVE2
$00000080 constant DAC2_CR_WAVE1                                    \ DAC channel1 noise/triangle wave generation enable
$00000100 constant DAC2_CR_MAMP10                                   \ MAMP10
$00000200 constant DAC2_CR_MAMP11                                   \ MAMP11
$00000400 constant DAC2_CR_MAMP12                                   \ MAMP12
$00000800 constant DAC2_CR_MAMP13                                   \ DAC channel1 mask/amplitude selector
$00001000 constant DAC2_CR_DMAEN1                                   \ DAC channel1 DMA enable
$00002000 constant DAC2_CR_DMAUDRIE1                                \ DAC channel1 DMA Underrun Interrupt enable


\
\ @brief software trigger register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DAC2_SWTRIGR_SWTRIG1                             \ DAC channel1 software trigger


\
\ @brief channel1 12-bit right-aligned data holding register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000fff constant DAC2_DHR12R1_DACC1DHR                            \ DAC channel1 12-bit right-aligned data


\
\ @brief DAC channel1 12-bit left aligned data holding register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000fff0 constant DAC2_DHR12L1_DACC1DHR                            \ DAC channel1 12-bit left-aligned data


\
\ @brief DAC channel1 8-bit right aligned data holding register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DAC2_DHR8R1_DACC1DHR                             \ DAC channel1 8-bit right-aligned data


\
\ @brief DAC channel1 data output register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant DAC2_DOR1_DACC1DOR                               \ DAC channel1 data output


\
\ @brief DAC status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00002000 constant DAC2_SR_DMAUDR1                                  \ DAC channel1 DMA underrun flag


\
\ @brief Digital-to-analog converter
\
$40009800 constant DAC2_CR        \ offset: 0x00 : control register
$40009804 constant DAC2_SWTRIGR   \ offset: 0x04 : software trigger register
$40009808 constant DAC2_DHR12R1   \ offset: 0x08 : channel1 12-bit right-aligned data holding register
$4000980c constant DAC2_DHR12L1   \ offset: 0x0C : DAC channel1 12-bit left aligned data holding register
$40009810 constant DAC2_DHR8R1    \ offset: 0x10 : DAC channel1 8-bit right aligned data holding register
$4000982c constant DAC2_DOR1      \ offset: 0x2C : DAC channel1 data output register
$40009834 constant DAC2_SR        \ offset: 0x34 : DAC status register

