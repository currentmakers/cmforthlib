\
\ @file adc_common.fs
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

$00000001 constant ADC_COMMON_CSR_AWD1                              \ AWD1
$00000002 constant ADC_COMMON_CSR_EOC1                              \ EOC1
$00000004 constant ADC_COMMON_CSR_JEOC1                             \ JEOC1
$00000008 constant ADC_COMMON_CSR_JSTRT1                            \ JSTRT1
$00000010 constant ADC_COMMON_CSR_STRT1                             \ STRT1
$00000020 constant ADC_COMMON_CSR_OVR1                              \ OVR1
$00000100 constant ADC_COMMON_CSR_AWD2                              \ AWD2
$00000200 constant ADC_COMMON_CSR_EOC2                              \ EOC2
$00000400 constant ADC_COMMON_CSR_JEOC2                             \ JEOC2
$00000800 constant ADC_COMMON_CSR_JSTRT2                            \ JSTRT2
$00001000 constant ADC_COMMON_CSR_STRT2                             \ STRT2
$00002000 constant ADC_COMMON_CSR_OVR2                              \ OVR2
$00010000 constant ADC_COMMON_CSR_AWD3                              \ AWD3
$00020000 constant ADC_COMMON_CSR_EOC3                              \ EOC3
$00040000 constant ADC_COMMON_CSR_JEOC3                             \ JEOC3
$00080000 constant ADC_COMMON_CSR_JSTRT3                            \ JSTRT3
$00100000 constant ADC_COMMON_CSR_STRT3                             \ STRT3
$00200000 constant ADC_COMMON_CSR_OVR3                              \ OVR3


\
\ @brief ADC common control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant ADC_COMMON_CCR_MULTI                             \ MULTI
$00000f00 constant ADC_COMMON_CCR_DELAY                             \ DELAY
$00002000 constant ADC_COMMON_CCR_DDS                               \ DDS
$0000c000 constant ADC_COMMON_CCR_DMA                               \ DMA
$00030000 constant ADC_COMMON_CCR_ADCPRE                            \ ADCPRE
$00400000 constant ADC_COMMON_CCR_VBATE                             \ VBATE
$00800000 constant ADC_COMMON_CCR_TSVREFE                           \ TSVREFE


\
\ @brief ADC common regular data register for dual and triple modes
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant ADC_COMMON_CDR_DATA1                             \ DATA1
$ffff0000 constant ADC_COMMON_CDR_DATA2                             \ DATA2


\
\ @brief Common ADC registers
\
$40012300 constant ADC_COMMON_CSR  \ offset: 0x00 : ADC Common status register
$40012304 constant ADC_COMMON_CCR  \ offset: 0x04 : ADC common control register
$40012308 constant ADC_COMMON_CDR  \ offset: 0x08 : ADC common regular data register for dual and triple modes

