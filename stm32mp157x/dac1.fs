\
\ @file dac1.fs
\ @brief DAC1
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

$00000001 constant DAC1_DAC_CR_EN1                                  \ EN1
$00000002 constant DAC1_DAC_CR_TEN1                                 \ TEN1
$00000004 constant DAC1_DAC_CR_TSEL10                               \ TSEL10
$00000008 constant DAC1_DAC_CR_TSEL11                               \ TSEL11
$00000010 constant DAC1_DAC_CR_TSEL12                               \ TSEL12
$00000020 constant DAC1_DAC_CR_TSEL13                               \ TSEL13
$000000c0 constant DAC1_DAC_CR_WAVE1                                \ WAVE1
$00000f00 constant DAC1_DAC_CR_MAMP1                                \ MAMP1
$00001000 constant DAC1_DAC_CR_DMAEN1                               \ DMAEN1
$00002000 constant DAC1_DAC_CR_DMAUDRIE1                            \ DMAUDRIE1
$00004000 constant DAC1_DAC_CR_CEN1                                 \ CEN1
$00008000 constant DAC1_DAC_CR_HFSEL                                \ HFSEL
$00010000 constant DAC1_DAC_CR_EN2                                  \ EN2
$00020000 constant DAC1_DAC_CR_TEN2                                 \ TEN2
$00040000 constant DAC1_DAC_CR_TSEL20                               \ TSEL20
$00080000 constant DAC1_DAC_CR_TSEL21                               \ TSEL21
$00100000 constant DAC1_DAC_CR_TSEL22                               \ TSEL22
$00200000 constant DAC1_DAC_CR_TSEL23                               \ TSEL23
$00c00000 constant DAC1_DAC_CR_WAVE2                                \ WAVE2
$0f000000 constant DAC1_DAC_CR_MAMP2                                \ MAMP2
$10000000 constant DAC1_DAC_CR_DMAEN2                               \ DMAEN2
$20000000 constant DAC1_DAC_CR_DMAUDRIE2                            \ DMAUDRIE2
$40000000 constant DAC1_DAC_CR_CEN2                                 \ CEN2


\
\ @brief DAC software trigger register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DAC1_DAC_SWTRGR_SWTRIG1                          \ SWTRIG1
$00000002 constant DAC1_DAC_SWTRGR_SWTRIG2                          \ SWTRIG2


\
\ @brief DAC channel1 12-bit right-aligned data holding register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000fff constant DAC1_DAC_DHR12R1_DACC1DHR                        \ DACC1DHR


\
\ @brief DAC channel1 12-bit left aligned data holding register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000fff0 constant DAC1_DAC_DHR12L1_DACC1DHR                        \ DACC1DHR


\
\ @brief DAC channel1 8-bit right aligned data holding register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DAC1_DAC_DHR8R1_DACC1DHR                         \ DACC1DHR


\
\ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant DAC1_DAC_DHR12R2_DACC2DHR                        \ DACC2DHR


\
\ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000fff0 constant DAC1_DAC_DHR12L2_DACC2DHR                        \ DACC2DHR


\
\ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DAC1_DAC_DHR8R2_DACC2DHR                         \ DACC2DHR


\
\ @brief Dual DAC 12-bit right-aligned data holding register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant DAC1_DAC_DHR12RD_DACC1DHR                        \ DACC1DHR
$0fff0000 constant DAC1_DAC_DHR12RD_DACC2DHR                        \ DACC2DHR


\
\ @brief Dual DAC 12-bit left aligned data holding register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000fff0 constant DAC1_DAC_DHR12LD_DACC1DHR                        \ DACC1DHR
$fff00000 constant DAC1_DAC_DHR12LD_DACC2DHR                        \ DACC2DHR


\
\ @brief Dual DAC 8-bit right aligned data holding register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DAC1_DAC_DHR8RD_DACC1DHR                         \ DACC1DHR
$0000ff00 constant DAC1_DAC_DHR8RD_DACC2DHR                         \ DACC2DHR


\
\ @brief DAC channel1 data output register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant DAC1_DAC_DOR1_DACC1DOR                           \ DACC1DOR


\
\ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000fff constant DAC1_DAC_DOR2_DACC2DOR                           \ DACC2DOR


\
\ @brief DAC status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00002000 constant DAC1_DAC_SR_DMAUDR1                              \ DMAUDR1
$00004000 constant DAC1_DAC_SR_CAL_FLAG1                            \ CAL_FLAG1
$00008000 constant DAC1_DAC_SR_BWST1                                \ BWST1
$20000000 constant DAC1_DAC_SR_DMAUDR2                              \ DMAUDR2
$40000000 constant DAC1_DAC_SR_CAL_FLAG2                            \ CAL_FLAG2
$80000000 constant DAC1_DAC_SR_BWST2                                \ BWST2


\
\ @brief DAC calibration control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant DAC1_DAC_CCR_OTRIM1                              \ OTRIM1
$001f0000 constant DAC1_DAC_CCR_OTRIM2                              \ OTRIM2


\
\ @brief DAC mode control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000007 constant DAC1_DAC_MCR_MODE1                               \ MODE1
$00070000 constant DAC1_DAC_MCR_MODE2                               \ MODE2


\
\ @brief DAC channel 1 sample and hold sample time register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000003ff constant DAC1_DAC_SHSR1_TSAMPLE1                          \ TSAMPLE1


\
\ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000003ff constant DAC1_DAC_SHSR2_TSAMPLE2                          \ TSAMPLE2


\
\ @brief DAC sample and hold time register
\ Address offset: 0x48
\ Reset value: 0x00010001
\

$000003ff constant DAC1_DAC_SHHR_THOLD1                             \ THOLD1
$03ff0000 constant DAC1_DAC_SHHR_THOLD2                             \ THOLD2


\
\ @brief DAC sample and hold refresh time register
\ Address offset: 0x4C
\ Reset value: 0x00010001
\

$000000ff constant DAC1_DAC_SHRR_TREFRESH1                          \ TREFRESH1
$00ff0000 constant DAC1_DAC_SHRR_TREFRESH2                          \ TREFRESH2


\
\ @brief DAC IP hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00001111
\

$0000000f constant DAC1_DAC_HWCFGR0_DUAL                            \ DUAL
$000000f0 constant DAC1_DAC_HWCFGR0_LFSR                            \ LFSR
$00000f00 constant DAC1_DAC_HWCFGR0_TRIANGLE                        \ TRIANGLE
$0000f000 constant DAC1_DAC_HWCFGR0_SAMPLE                          \ SAMPLE
$00ff0000 constant DAC1_DAC_HWCFGR0_OR_CFG                          \ OR_CFG


\
\ @brief No
\ Address offset: 0x3F4
\ Reset value: 0x00000031
\

$0000000f constant DAC1_DAC_VERR_MINREV                             \ MINREV
$000000f0 constant DAC1_DAC_VERR_MAJREV                             \ MAJREV


\
\ @brief No
\ Address offset: 0x3F8
\ Reset value: 0x00110011
\

$00000000 constant DAC1_DAC_IPIDR_ID                                \ ID


\
\ @brief No
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant DAC1_DAC_SIDR_SID                                \ SID


\
\ @brief DAC1
\
$40017000 constant DAC1_DAC_CR    \ offset: 0x00 : DAC control register
$40017004 constant DAC1_DAC_SWTRGR  \ offset: 0x04 : DAC software trigger register
$40017008 constant DAC1_DAC_DHR12R1  \ offset: 0x08 : DAC channel1 12-bit right-aligned data holding register
$4001700c constant DAC1_DAC_DHR12L1  \ offset: 0x0C : DAC channel1 12-bit left aligned data holding register
$40017010 constant DAC1_DAC_DHR8R1  \ offset: 0x10 : DAC channel1 8-bit right aligned data holding register
$40017014 constant DAC1_DAC_DHR12R2  \ offset: 0x14 : This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
$40017018 constant DAC1_DAC_DHR12L2  \ offset: 0x18 : This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
$4001701c constant DAC1_DAC_DHR8R2  \ offset: 0x1C : This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
$40017020 constant DAC1_DAC_DHR12RD  \ offset: 0x20 : Dual DAC 12-bit right-aligned data holding register
$40017024 constant DAC1_DAC_DHR12LD  \ offset: 0x24 : Dual DAC 12-bit left aligned data holding register
$40017028 constant DAC1_DAC_DHR8RD  \ offset: 0x28 : Dual DAC 8-bit right aligned data holding register
$4001702c constant DAC1_DAC_DOR1  \ offset: 0x2C : DAC channel1 data output register
$40017030 constant DAC1_DAC_DOR2  \ offset: 0x30 : This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
$40017034 constant DAC1_DAC_SR    \ offset: 0x34 : DAC status register
$40017038 constant DAC1_DAC_CCR   \ offset: 0x38 : DAC calibration control register
$4001703c constant DAC1_DAC_MCR   \ offset: 0x3C : DAC mode control register
$40017040 constant DAC1_DAC_SHSR1  \ offset: 0x40 : DAC channel 1 sample and hold sample time register
$40017044 constant DAC1_DAC_SHSR2  \ offset: 0x44 : This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
$40017048 constant DAC1_DAC_SHHR  \ offset: 0x48 : DAC sample and hold time register
$4001704c constant DAC1_DAC_SHRR  \ offset: 0x4C : DAC sample and hold refresh time register
$400173f0 constant DAC1_DAC_HWCFGR0  \ offset: 0x3F0 : DAC IP hardware configuration register
$400173f4 constant DAC1_DAC_VERR  \ offset: 0x3F4 : No
$400173f8 constant DAC1_DAC_IPIDR  \ offset: 0x3F8 : No
$400173fc constant DAC1_DAC_SIDR  \ offset: 0x3FC : No

