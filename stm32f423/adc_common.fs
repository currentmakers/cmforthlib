\
\ @file adc_common.fs
\ @brief ADC common registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC_COMMON_DEF

  [ifdef] ADC_COMMON_CSR_DEF
    \
    \ @brief ADC Common status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_AWD1                \ [0x00] Analog watchdog flag of ADC 1
    $01 constant ADC_COMMON_EOC1                \ [0x01] End of conversion of ADC 1
    $02 constant ADC_COMMON_JEOC1               \ [0x02] Injected channel end of conversion of ADC 1
    $03 constant ADC_COMMON_JSTRT1              \ [0x03] Injected channel Start flag of ADC 1
    $04 constant ADC_COMMON_STRT1               \ [0x04] Regular channel Start flag of ADC 1
    $05 constant ADC_COMMON_OVR1                \ [0x05] Overrun flag of ADC 1
    $08 constant ADC_COMMON_AWD2                \ [0x08] Analog watchdog flag of ADC 2
    $09 constant ADC_COMMON_EOC2                \ [0x09] End of conversion of ADC 2
    $0a constant ADC_COMMON_JEOC2               \ [0x0a] Injected channel end of conversion of ADC 2
    $0b constant ADC_COMMON_JSTRT2              \ [0x0b] Injected channel Start flag of ADC 2
    $0c constant ADC_COMMON_STRT2               \ [0x0c] Regular channel Start flag of ADC 2
    $0d constant ADC_COMMON_OVR2                \ [0x0d] Overrun flag of ADC 2
    $10 constant ADC_COMMON_AWD3                \ [0x10] Analog watchdog flag of ADC 3
    $11 constant ADC_COMMON_EOC3                \ [0x11] End of conversion of ADC 3
    $12 constant ADC_COMMON_JEOC3               \ [0x12] Injected channel end of conversion of ADC 3
    $13 constant ADC_COMMON_JSTRT3              \ [0x13] Injected channel Start flag of ADC 3
    $14 constant ADC_COMMON_STRT3               \ [0x14] Regular channel Start flag of ADC 3
    $15 constant ADC_COMMON_OVR3                \ [0x15] Overrun flag of ADC3
  [then]


  [ifdef] ADC_COMMON_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $08 constant ADC_COMMON_DELAY               \ [0x08 : 4] Delay between 2 sampling phases
    $0d constant ADC_COMMON_DDS                 \ [0x0d] DMA disable selection for multi-ADC mode
    $0e constant ADC_COMMON_DMA                 \ [0x0e : 2] Direct memory access mode for multi ADC mode
    $10 constant ADC_COMMON_ADCPRE              \ [0x10 : 2] ADC prescaler
    $16 constant ADC_COMMON_VBATE               \ [0x16] VBAT enable
    $17 constant ADC_COMMON_TSVREFE             \ [0x17] Temperature sensor and VREFINT enable
  [then]

  \
  \ @brief ADC common registers
  \
  $00 constant ADC_COMMON_CSR           \ ADC Common status register
  $04 constant ADC_COMMON_CCR           \ ADC common control register

: ADC_COMMON_DEF ; [then]
