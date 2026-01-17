\
\ @file adc_common.fs
\ @brief Analog-to-Digital Converter
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
    $00 constant ADC_COMMON_AWD1                \ [0x00] AWD1
    $01 constant ADC_COMMON_EOC1                \ [0x01] EOC1
    $02 constant ADC_COMMON_JEOC1               \ [0x02] JEOC1
    $03 constant ADC_COMMON_JSTRT1              \ [0x03] JSTRT1
    $04 constant ADC_COMMON_STRT1               \ [0x04] STRT1
    $05 constant ADC_COMMON_OVR1                \ [0x05] OVR1
    $08 constant ADC_COMMON_AWD2                \ [0x08] AWD2
    $09 constant ADC_COMMON_EOC2                \ [0x09] EOC2
    $0a constant ADC_COMMON_JEOC2               \ [0x0a] JEOC2
    $0b constant ADC_COMMON_JSTRT2              \ [0x0b] JSTRT2
    $0c constant ADC_COMMON_STRT2               \ [0x0c] STRT2
    $0d constant ADC_COMMON_OVR2                \ [0x0d] OVR2
    $10 constant ADC_COMMON_AWD3                \ [0x10] AWD3
    $11 constant ADC_COMMON_EOC3                \ [0x11] EOC3
    $12 constant ADC_COMMON_JEOC3               \ [0x12] JEOC3
    $13 constant ADC_COMMON_JSTRT3              \ [0x13] JSTRT3
    $14 constant ADC_COMMON_STRT3               \ [0x14] STRT3
    $15 constant ADC_COMMON_OVR3                \ [0x15] OVR3
  [then]


  [ifdef] ADC_COMMON_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_MULTI               \ [0x00 : 5] MULTI
    $08 constant ADC_COMMON_DELAY               \ [0x08 : 4] DELAY
    $0d constant ADC_COMMON_DDS                 \ [0x0d] DDS
    $0e constant ADC_COMMON_DMA                 \ [0x0e : 2] DMA
    $10 constant ADC_COMMON_ADCPRE              \ [0x10 : 2] ADCPRE
    $16 constant ADC_COMMON_VBATE               \ [0x16] VBATE
    $17 constant ADC_COMMON_TSVREFE             \ [0x17] TSVREFE
  [then]


  [ifdef] ADC_COMMON_CDR_DEF
    \
    \ @brief ADC common regular data register for dual and triple modes
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_DATA1               \ [0x00 : 16] DATA1
    $10 constant ADC_COMMON_DATA2               \ [0x10 : 16] DATA2
  [then]

  \
  \ @brief Analog-to-Digital Converter
  \
  $00 constant ADC_COMMON_CSR           \ ADC Common status register
  $04 constant ADC_COMMON_CCR           \ ADC common control register
  $08 constant ADC_COMMON_CDR           \ ADC common regular data register for dual and triple modes

: ADC_COMMON_DEF ; [then]
