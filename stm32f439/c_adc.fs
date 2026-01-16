\
\ @file c_adc.fs
\ @brief Common ADC registers
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

$00000001 constant C_ADC_CSR_AWD1                                   \ Analog watchdog flag of ADC 1
$00000002 constant C_ADC_CSR_EOC1                                   \ End of conversion of ADC 1
$00000004 constant C_ADC_CSR_JEOC1                                  \ Injected channel end of conversion of ADC 1
$00000008 constant C_ADC_CSR_JSTRT1                                 \ Injected channel Start flag of ADC 1
$00000010 constant C_ADC_CSR_STRT1                                  \ Regular channel Start flag of ADC 1
$00000020 constant C_ADC_CSR_OVR1                                   \ Overrun flag of ADC 1
$00000100 constant C_ADC_CSR_AWD2                                   \ Analog watchdog flag of ADC 2
$00000200 constant C_ADC_CSR_EOC2                                   \ End of conversion of ADC 2
$00000400 constant C_ADC_CSR_JEOC2                                  \ Injected channel end of conversion of ADC 2
$00000800 constant C_ADC_CSR_JSTRT2                                 \ Injected channel Start flag of ADC 2
$00001000 constant C_ADC_CSR_STRT2                                  \ Regular channel Start flag of ADC 2
$00002000 constant C_ADC_CSR_OVR2                                   \ Overrun flag of ADC 2
$00010000 constant C_ADC_CSR_AWD3                                   \ Analog watchdog flag of ADC 3
$00020000 constant C_ADC_CSR_EOC3                                   \ End of conversion of ADC 3
$00040000 constant C_ADC_CSR_JEOC3                                  \ Injected channel end of conversion of ADC 3
$00080000 constant C_ADC_CSR_JSTRT3                                 \ Injected channel Start flag of ADC 3
$00100000 constant C_ADC_CSR_STRT3                                  \ Regular channel Start flag of ADC 3
$00200000 constant C_ADC_CSR_OVR3                                   \ Overrun flag of ADC3


\
\ @brief ADC common control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant C_ADC_CCR_MULT                                   \ Multi ADC mode selection
$00000f00 constant C_ADC_CCR_DELAY                                  \ Delay between 2 sampling phases
$00002000 constant C_ADC_CCR_DDS                                    \ DMA disable selection for multi-ADC mode
$0000c000 constant C_ADC_CCR_DMA                                    \ Direct memory access mode for multi ADC mode
$00030000 constant C_ADC_CCR_ADCPRE                                 \ ADC prescaler
$00400000 constant C_ADC_CCR_VBATE                                  \ VBAT enable
$00800000 constant C_ADC_CCR_TSVREFE                                \ Temperature sensor and VREFINT enable


\
\ @brief ADC common regular data register for dual and triple modes
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant C_ADC_CDR_DATA1                                  \ 1st data item of a pair of regular conversions
$ffff0000 constant C_ADC_CDR_DATA2                                  \ 2nd data item of a pair of regular conversions


\
\ @brief Common ADC registers
\
$40012300 constant C_ADC_CSR      \ offset: 0x00 : ADC Common status register
$40012304 constant C_ADC_CCR      \ offset: 0x04 : ADC common control register
$40012308 constant C_ADC_CDR      \ offset: 0x08 : ADC common regular data register for dual and triple modes

