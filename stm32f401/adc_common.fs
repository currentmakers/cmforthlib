\
\ @file adc_common.fs
\ @brief ADC common registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ADC Common status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ADC_COMMON_CSR_AWD1                              \ Analog watchdog flag of ADC 1
$00000002 constant ADC_COMMON_CSR_EOC1                              \ End of conversion of ADC 1
$00000004 constant ADC_COMMON_CSR_JEOC1                             \ Injected channel end of conversion of ADC 1
$00000008 constant ADC_COMMON_CSR_JSTRT1                            \ Injected channel Start flag of ADC 1
$00000010 constant ADC_COMMON_CSR_STRT1                             \ Regular channel Start flag of ADC 1
$00000020 constant ADC_COMMON_CSR_OVR1                              \ Overrun flag of ADC 1
$00000100 constant ADC_COMMON_CSR_AWD2                              \ Analog watchdog flag of ADC 2
$00000200 constant ADC_COMMON_CSR_EOC2                              \ End of conversion of ADC 2
$00000400 constant ADC_COMMON_CSR_JEOC2                             \ Injected channel end of conversion of ADC 2
$00000800 constant ADC_COMMON_CSR_JSTRT2                            \ Injected channel Start flag of ADC 2
$00001000 constant ADC_COMMON_CSR_STRT2                             \ Regular channel Start flag of ADC 2
$00002000 constant ADC_COMMON_CSR_OVR2                              \ Overrun flag of ADC 2
$00010000 constant ADC_COMMON_CSR_AWD3                              \ Analog watchdog flag of ADC 3
$00020000 constant ADC_COMMON_CSR_EOC3                              \ End of conversion of ADC 3
$00040000 constant ADC_COMMON_CSR_JEOC3                             \ Injected channel end of conversion of ADC 3
$00080000 constant ADC_COMMON_CSR_JSTRT3                            \ Injected channel Start flag of ADC 3
$00100000 constant ADC_COMMON_CSR_STRT3                             \ Regular channel Start flag of ADC 3
$00200000 constant ADC_COMMON_CSR_OVR3                              \ Overrun flag of ADC3


\
\ @brief ADC common control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000f00 constant ADC_COMMON_CCR_DELAY                             \ Delay between 2 sampling phases
$00002000 constant ADC_COMMON_CCR_DDS                               \ DMA disable selection for multi-ADC mode
$0000c000 constant ADC_COMMON_CCR_DMA                               \ Direct memory access mode for multi ADC mode
$00030000 constant ADC_COMMON_CCR_ADCPRE                            \ ADC prescaler
$00400000 constant ADC_COMMON_CCR_VBATE                             \ VBAT enable
$00800000 constant ADC_COMMON_CCR_TSVREFE                           \ Temperature sensor and VREFINT enable


\
\ @brief ADC common registers
\
$40012300 constant ADC_COMMON_CSR  \ offset: 0x00 : ADC Common status register
$40012304 constant ADC_COMMON_CCR  \ offset: 0x04 : ADC common control register

