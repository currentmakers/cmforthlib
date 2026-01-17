\
\ @file c_adc.fs
\ @brief Common ADC registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] C_ADC_DEF

  [ifdef] C_ADC_CSR_DEF
    \
    \ @brief ADC Common status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant C_ADC_AWD1                     \ [0x00] Analog watchdog flag of ADC 1
    $01 constant C_ADC_EOC1                     \ [0x01] End of conversion of ADC 1
    $02 constant C_ADC_JEOC1                    \ [0x02] Injected channel end of conversion of ADC 1
    $03 constant C_ADC_JSTRT1                   \ [0x03] Injected channel Start flag of ADC 1
    $04 constant C_ADC_STRT1                    \ [0x04] Regular channel Start flag of ADC 1
    $05 constant C_ADC_OVR1                     \ [0x05] Overrun flag of ADC 1
    $08 constant C_ADC_AWD2                     \ [0x08] Analog watchdog flag of ADC 2
    $09 constant C_ADC_EOC2                     \ [0x09] End of conversion of ADC 2
    $0a constant C_ADC_JEOC2                    \ [0x0a] Injected channel end of conversion of ADC 2
    $0b constant C_ADC_JSTRT2                   \ [0x0b] Injected channel Start flag of ADC 2
    $0c constant C_ADC_STRT2                    \ [0x0c] Regular channel Start flag of ADC 2
    $0d constant C_ADC_OVR2                     \ [0x0d] Overrun flag of ADC 2
    $10 constant C_ADC_AWD3                     \ [0x10] Analog watchdog flag of ADC 3
    $11 constant C_ADC_EOC3                     \ [0x11] End of conversion of ADC 3
    $12 constant C_ADC_JEOC3                    \ [0x12] Injected channel end of conversion of ADC 3
    $13 constant C_ADC_JSTRT3                   \ [0x13] Injected channel Start flag of ADC 3
    $14 constant C_ADC_STRT3                    \ [0x14] Regular channel Start flag of ADC 3
    $15 constant C_ADC_OVR3                     \ [0x15] Overrun flag of ADC3
  [then]


  [ifdef] C_ADC_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant C_ADC_MULT                     \ [0x00 : 5] Multi ADC mode selection
    $08 constant C_ADC_DELAY                    \ [0x08 : 4] Delay between 2 sampling phases
    $0d constant C_ADC_DDS                      \ [0x0d] DMA disable selection for multi-ADC mode
    $0e constant C_ADC_DMA                      \ [0x0e : 2] Direct memory access mode for multi ADC mode
    $10 constant C_ADC_ADCPRE                   \ [0x10 : 2] ADC prescaler
    $16 constant C_ADC_VBATE                    \ [0x16] VBAT enable
    $17 constant C_ADC_TSVREFE                  \ [0x17] Temperature sensor and VREFINT enable
  [then]


  [ifdef] C_ADC_CDR_DEF
    \
    \ @brief ADC common regular data register for dual and triple modes
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant C_ADC_DATA1                    \ [0x00 : 16] 1st data item of a pair of regular conversions
    $10 constant C_ADC_DATA2                    \ [0x10 : 16] 2nd data item of a pair of regular conversions
  [then]

  \
  \ @brief Common ADC registers
  \
  $00 constant C_ADC_CSR                \ ADC Common status register
  $04 constant C_ADC_CCR                \ ADC common control register
  $08 constant C_ADC_CDR                \ ADC common regular data register for dual and triple modes

: C_ADC_DEF ; [then]
