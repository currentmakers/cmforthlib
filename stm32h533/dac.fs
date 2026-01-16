\
\ @file dac.fs
\ @brief DAC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DAC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DAC_DAC_CR_EN1                                   \ DAC channel1 enable
$00000002 constant DAC_DAC_CR_TEN1                                  \ DAC channel1 trigger enable
$0000003c constant DAC_DAC_CR_TSEL1                                 \ DAC channel1 trigger selection
$000000c0 constant DAC_DAC_CR_WAVE1                                 \ DAC channel1 noise/triangle wave generation enable
$00000f00 constant DAC_DAC_CR_MAMP1                                 \ DAC channel1 mask/amplitude selector
$00001000 constant DAC_DAC_CR_DMAEN1                                \ DAC channel1 DMA enable
$00002000 constant DAC_DAC_CR_DMAUDRIE1                             \ DAC channel1 DMA Underrun Interrupt enable
$00004000 constant DAC_DAC_CR_CEN1                                  \ DAC channel1 calibration enable
$00010000 constant DAC_DAC_CR_EN2                                   \ DAC channel2 enable
$00020000 constant DAC_DAC_CR_TEN2                                  \ DAC channel2 trigger enable
$003c0000 constant DAC_DAC_CR_TSEL2                                 \ DAC channel2 trigger selection
$00c00000 constant DAC_DAC_CR_WAVE2                                 \ DAC channel2 noise/triangle wave generation enable
$0f000000 constant DAC_DAC_CR_MAMP2                                 \ DAC channel2 mask/amplitude selector
$10000000 constant DAC_DAC_CR_DMAEN2                                \ DAC channel2 DMA enable
$20000000 constant DAC_DAC_CR_DMAUDRIE2                             \ DAC channel2 DMA underrun interrupt enable
$40000000 constant DAC_DAC_CR_CEN2                                  \ DAC channel2 calibration enable


\
\ @brief DAC software trigger register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DAC_DAC_SWTRGR_SWTRIG1                           \ DAC channel1 software trigger
$00000002 constant DAC_DAC_SWTRGR_SWTRIG2                           \ DAC channel2 software trigger


\
\ @brief DAC channel1 12-bit right-aligned data holding register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DHR12R1_DACC1DHR                         \ DAC channel1 12-bit right-aligned data
$0fff0000 constant DAC_DAC_DHR12R1_DACC1DHRB                        \ DAC channel1 12-bit right-aligned data B


\
\ @brief DAC channel1 12-bit left aligned data holding register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DAC_DHR12L1_DACC1DHR                         \ DAC channel1 12-bit left-aligned data
$fff00000 constant DAC_DAC_DHR12L1_DACC1DHRB                        \ DAC channel1 12-bit left-aligned data B


\
\ @brief DAC channel1 8-bit right aligned data holding register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DAC_DAC_DHR8R1_DACC1DHR                          \ DAC channel1 8-bit right-aligned data
$0000ff00 constant DAC_DAC_DHR8R1_DACC1DHRB                         \ DAC channel1 8-bit right-aligned data


\
\ @brief DAC channel2 12-bit right aligned data holding register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DHR12R2_DACC2DHR                         \ DAC channel2 12-bit right-aligned data
$0fff0000 constant DAC_DAC_DHR12R2_DACC2DHRB                        \ DAC channel2 12-bit right-aligned data


\
\ @brief DAC channel2 12-bit left aligned data holding register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DAC_DHR12L2_DACC2DHR                         \ DAC channel2 12-bit left-aligned data
$fff00000 constant DAC_DAC_DHR12L2_DACC2DHRB                        \ DAC channel2 12-bit left-aligned data B


\
\ @brief DAC channel2 8-bit right-aligned data holding register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DAC_DAC_DHR8R2_DACC2DHR                          \ DAC channel2 8-bit right-aligned data
$0000ff00 constant DAC_DAC_DHR8R2_DACC2DHRB                         \ DAC channel2 8-bit right-aligned data


\
\ @brief Dual DAC 12-bit right-aligned data holding register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DHR12RD_DACC1DHR                         \ DAC channel1 12-bit right-aligned data
$0fff0000 constant DAC_DAC_DHR12RD_DACC2DHR                         \ DAC channel2 12-bit right-aligned data


\
\ @brief Dual DAC 12-bit left aligned data holding register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DAC_DHR12LD_DACC1DHR                         \ DAC channel1 12-bit left-aligned data
$fff00000 constant DAC_DAC_DHR12LD_DACC2DHR                         \ DAC channel2 12-bit left-aligned data


\
\ @brief Dual DAC 8-bit right aligned data holding register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DAC_DAC_DHR8RD_DACC1DHR                          \ DAC channel1 8-bit right-aligned data
$0000ff00 constant DAC_DAC_DHR8RD_DACC2DHR                          \ DAC channel2 8-bit right-aligned data


\
\ @brief DAC channel1 data output register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DOR1_DACC1DOR                            \ DAC channel1 data output
$0fff0000 constant DAC_DAC_DOR1_DACC1DORB                           \ DAC channel1 data output


\
\ @brief DAC channel2 data output register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000fff constant DAC_DAC_DOR2_DACC2DOR                            \ DAC channel2 data output
$0fff0000 constant DAC_DAC_DOR2_DACC2DORB                           \ DAC channel2 data output


\
\ @brief DAC status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000800 constant DAC_DAC_SR_DAC1RDY                               \ DAC channel1 ready status bit
$00001000 constant DAC_DAC_SR_DORSTAT1                              \ DAC channel1 output register status bit
$00002000 constant DAC_DAC_SR_DMAUDR1                               \ DAC channel1 DMA underrun flag
$00004000 constant DAC_DAC_SR_CAL_FLAG1                             \ DAC channel1 calibration offset status
$00008000 constant DAC_DAC_SR_BWST1                                 \ DAC channel1 busy writing sample time flag
$08000000 constant DAC_DAC_SR_DAC2RDY                               \ DAC channel2 ready status bit
$10000000 constant DAC_DAC_SR_DORSTAT2                              \ DAC channel2 output register status bit
$20000000 constant DAC_DAC_SR_DMAUDR2                               \ DAC channel2 DMA underrun flag
$40000000 constant DAC_DAC_SR_CAL_FLAG2                             \ DAC channel2 calibration offset status
$80000000 constant DAC_DAC_SR_BWST2                                 \ DAC channel2 busy writing sample time flag


\
\ @brief DAC calibration control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant DAC_DAC_CCR_OTRIM1                               \ DAC channel1 offset trimming value
$001f0000 constant DAC_DAC_CCR_OTRIM2                               \ DAC channel2 offset trimming value


\
\ @brief DAC mode control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000007 constant DAC_DAC_MCR_MODE1                                \ DAC channel1 mode
$00000100 constant DAC_DAC_MCR_DMADOUBLE1                           \ DAC channel1 DMA double data mode
$00000200 constant DAC_DAC_MCR_SINFORMAT1                           \ Enable signed format for DAC channel1
$0000c000 constant DAC_DAC_MCR_HFSEL                                \ High frequency interface mode selection
$00070000 constant DAC_DAC_MCR_MODE2                                \ DAC channel2 mode
$01000000 constant DAC_DAC_MCR_DMADOUBLE2                           \ DAC channel2 DMA double data mode
$02000000 constant DAC_DAC_MCR_SINFORMAT2                           \ Enable signed format for DAC channel2


\
\ @brief DAC channel1 sample and hold sample time register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000003ff constant DAC_DAC_SHSR1_TSAMPLE1                           \ DAC channel1 sample time (only valid in Sample and hold mode)


\
\ @brief DAC channel2 sample and hold sample time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000003ff constant DAC_DAC_SHSR2_TSAMPLE2                           \ DAC channel2 sample time (only valid in Sample and hold mode)


\
\ @brief DAC sample and hold time register
\ Address offset: 0x48
\ Reset value: 0x00010001
\

$000003ff constant DAC_DAC_SHHR_THOLD1                              \ DAC channel1 hold time (only valid in Sample and hold mode)
$03ff0000 constant DAC_DAC_SHHR_THOLD2                              \ DAC channel2 hold time (only valid in Sample and hold mode).


\
\ @brief DAC sample and hold refresh time register
\ Address offset: 0x4C
\ Reset value: 0x00010001
\

$000000ff constant DAC_DAC_SHRR_TREFRESH1                           \ DAC channel1 refresh time (only valid in Sample and hold mode)
$00ff0000 constant DAC_DAC_SHRR_TREFRESH2                           \ DAC channel2 refresh time (only valid in Sample and hold mode)


\
\ @brief DAC address block description
\
$42028400 constant DAC_DAC_CR     \ offset: 0x00 : DAC control register
$42028404 constant DAC_DAC_SWTRGR  \ offset: 0x04 : DAC software trigger register
$42028408 constant DAC_DAC_DHR12R1  \ offset: 0x08 : DAC channel1 12-bit right-aligned data holding register
$4202840c constant DAC_DAC_DHR12L1  \ offset: 0x0C : DAC channel1 12-bit left aligned data holding register
$42028410 constant DAC_DAC_DHR8R1  \ offset: 0x10 : DAC channel1 8-bit right aligned data holding register
$42028414 constant DAC_DAC_DHR12R2  \ offset: 0x14 : DAC channel2 12-bit right aligned data holding register
$42028418 constant DAC_DAC_DHR12L2  \ offset: 0x18 : DAC channel2 12-bit left aligned data holding register
$4202841c constant DAC_DAC_DHR8R2  \ offset: 0x1C : DAC channel2 8-bit right-aligned data holding register
$42028420 constant DAC_DAC_DHR12RD  \ offset: 0x20 : Dual DAC 12-bit right-aligned data holding register
$42028424 constant DAC_DAC_DHR12LD  \ offset: 0x24 : Dual DAC 12-bit left aligned data holding register
$42028428 constant DAC_DAC_DHR8RD  \ offset: 0x28 : Dual DAC 8-bit right aligned data holding register
$4202842c constant DAC_DAC_DOR1   \ offset: 0x2C : DAC channel1 data output register
$42028430 constant DAC_DAC_DOR2   \ offset: 0x30 : DAC channel2 data output register
$42028434 constant DAC_DAC_SR     \ offset: 0x34 : DAC status register
$42028438 constant DAC_DAC_CCR    \ offset: 0x38 : DAC calibration control register
$4202843c constant DAC_DAC_MCR    \ offset: 0x3C : DAC mode control register
$42028440 constant DAC_DAC_SHSR1  \ offset: 0x40 : DAC channel1 sample and hold sample time register
$42028444 constant DAC_DAC_SHSR2  \ offset: 0x44 : DAC channel2 sample and hold sample time register
$42028448 constant DAC_DAC_SHHR   \ offset: 0x48 : DAC sample and hold time register
$4202844c constant DAC_DAC_SHRR   \ offset: 0x4C : DAC sample and hold refresh time register

