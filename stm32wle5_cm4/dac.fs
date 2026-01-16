\
\ @file dac.fs
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

$00000001 constant DAC_CR_EN1                                       \ DAC channel1 enable
$00000002 constant DAC_CR_TEN1                                      \ DAC channel1 trigger enable
$00000004 constant DAC_CR_TSEL10                                    \ TSEL10
$00000008 constant DAC_CR_TSEL11                                    \ TSEL11
$00000010 constant DAC_CR_TSEL12                                    \ TSEL12
$00000020 constant DAC_CR_TSEL13                                    \ DAC channel1 trigger selection
$000000c0 constant DAC_CR_WAVE1                                     \ DAC channel1 noise/triangle wave generation enable
$00000f00 constant DAC_CR_MAMP1                                     \ DAC channel1 mask/amplitude selector
$00001000 constant DAC_CR_DMAEN1                                    \ DAC channel1 DMA enable
$00002000 constant DAC_CR_DMAUDRIE1                                 \ DAC channel1 DMA Underrun Interrupt enable
$00004000 constant DAC_CR_CEN1                                      \ DAC Channel 1 calibration enable


\
\ @brief software trigger register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DAC_SWTRGR_SWTRIG1                               \ DAC channel1 software trigger


\
\ @brief channel1 12-bit right-aligned data holding register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000fff constant DAC_DHR12R1_DACC1DHR                             \ DAC channel1 12-bit right-aligned data


\
\ @brief channel1 12-bit left aligned data holding register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DHR12L1_DACC1DHR                             \ DAC channel1 12-bit left-aligned data


\
\ @brief channel1 8-bit right aligned data holding register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DAC_DHR8R1_DACC1DHR                              \ DAC channel1 8-bit right-aligned data


\
\ @brief Dual DAC 12-bit right-aligned data holding register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant DAC_DHR12RD_DACC1DHR                             \ DAC channel1 12-bit right-aligned data


\
\ @brief Dual DAC 12-bit left aligned data holding register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DHR12LD_DACC1DHR                             \ DAC channel1 12-bit left-aligned data


\
\ @brief Dual DAC 8-bit right aligned data holding register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DAC_DHR8RD_DACC1DHR                              \ DAC channel1 8-bit right-aligned data


\
\ @brief DAC channel1 data output register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant DAC_DOR1_DACC1DOR                                \ DACC1DOR


\
\ @brief status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00002000 constant DAC_SR_DMAUDR1                                   \ DAC channel1 DMA underrun flag
$00004000 constant DAC_SR_CAL_FLAG1                                 \ DAC Channel 1 calibration offset status
$00008000 constant DAC_SR_BWST1                                     \ DAC Channel 1 busy writing sample time flag


\
\ @brief calibration control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant DAC_CCR_OTRIM1                                   \ DAC Channel 1 offset trimming value


\
\ @brief mode control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000007 constant DAC_MCR_MODE1                                    \ DAC Channel 1 mode


\
\ @brief Sample and Hold sample time register 1
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000003ff constant DAC_SHSR1_TSAMPLE1                               \ DAC Channel 1 sample Time (only valid in Sample and Hold mode)


\
\ @brief Sample and Hold hold time register
\ Address offset: 0x48
\ Reset value: 0x00010001
\

$000003ff constant DAC_SHHR_THOLD1                                  \ DAC Channel 1 hold Time (only valid in Sample and Hold mode)


\
\ @brief Sample and Hold refresh time register
\ Address offset: 0x4C
\ Reset value: 0x00010001
\

$000000ff constant DAC_SHRR_TREFRESH1                               \ DAC Channel 1 refresh Time (only valid in Sample and Hold mode)


\
\ @brief Digital-to-analog converter
\
$40007400 constant DAC_CR         \ offset: 0x00 : control register
$40007404 constant DAC_SWTRGR     \ offset: 0x04 : software trigger register
$40007408 constant DAC_DHR12R1    \ offset: 0x08 : channel1 12-bit right-aligned data holding register
$4000740c constant DAC_DHR12L1    \ offset: 0x0C : channel1 12-bit left aligned data holding register
$40007410 constant DAC_DHR8R1     \ offset: 0x10 : channel1 8-bit right aligned data holding register
$40007420 constant DAC_DHR12RD    \ offset: 0x20 : Dual DAC 12-bit right-aligned data holding register
$40007424 constant DAC_DHR12LD    \ offset: 0x24 : Dual DAC 12-bit left aligned data holding register
$40007428 constant DAC_DHR8RD     \ offset: 0x28 : Dual DAC 8-bit right aligned data holding register
$4000742c constant DAC_DOR1       \ offset: 0x2C : DAC channel1 data output register
$40007434 constant DAC_SR         \ offset: 0x34 : status register
$40007438 constant DAC_CCR        \ offset: 0x38 : calibration control register
$4000743c constant DAC_MCR        \ offset: 0x3C : mode control register
$40007440 constant DAC_SHSR1      \ offset: 0x40 : Sample and Hold sample time register 1
$40007448 constant DAC_SHHR       \ offset: 0x48 : Sample and Hold hold time register
$4000744c constant DAC_SHRR       \ offset: 0x4C : Sample and Hold refresh time register

