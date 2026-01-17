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
    $00 constant ADC_COMMON_ADDRDY_MST          \ [0x00] ADDRDY_MST
    $01 constant ADC_COMMON_EOSMP_MST           \ [0x01] EOSMP_MST
    $02 constant ADC_COMMON_EOC_MST             \ [0x02] EOC_MST
    $03 constant ADC_COMMON_EOS_MST             \ [0x03] EOS_MST
    $04 constant ADC_COMMON_OVR_MST             \ [0x04] OVR_MST
    $05 constant ADC_COMMON_JEOC_MST            \ [0x05] JEOC_MST
    $06 constant ADC_COMMON_JEOS_MST            \ [0x06] JEOS_MST
    $07 constant ADC_COMMON_AWD1_MST            \ [0x07] AWD1_MST
    $08 constant ADC_COMMON_AWD2_MST            \ [0x08] AWD2_MST
    $09 constant ADC_COMMON_AWD3_MST            \ [0x09] AWD3_MST
    $0a constant ADC_COMMON_JQOVF_MST           \ [0x0a] JQOVF_MST
    $10 constant ADC_COMMON_ADRDY_SLV           \ [0x10] ADRDY_SLV
    $11 constant ADC_COMMON_EOSMP_SLV           \ [0x11] EOSMP_SLV
    $12 constant ADC_COMMON_EOC_SLV             \ [0x12] EOC_SLV
    $13 constant ADC_COMMON_EOS_SLV             \ [0x13] EOS_SLV
    $14 constant ADC_COMMON_OVR_SLV             \ [0x14] OVR_SLV
    $15 constant ADC_COMMON_JEOC_SLV            \ [0x15] JEOC_SLV
    $16 constant ADC_COMMON_JEOS_SLV            \ [0x16] JEOS_SLV
    $17 constant ADC_COMMON_AWD1_SLV            \ [0x17] AWD1_SLV
    $18 constant ADC_COMMON_AWD2_SLV            \ [0x18] AWD2_SLV
    $19 constant ADC_COMMON_AWD3_SLV            \ [0x19] AWD3_SLV
    $1a constant ADC_COMMON_JQOVF_SLV           \ [0x1a] JQOVF_SLV
  [then]


  [ifdef] ADC_COMMON_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_DUAL                \ [0x00 : 5] DUAL
    $08 constant ADC_COMMON_DELAY               \ [0x08 : 3] DELAY
    $0d constant ADC_COMMON_DMACFG              \ [0x0d] DMACFG
    $0e constant ADC_COMMON_MDMA                \ [0x0e : 2] MDMA
    $10 constant ADC_COMMON_CKMODE              \ [0x10 : 2] ADC clock mode
    $12 constant ADC_COMMON_PRESC               \ [0x12 : 4] ADC prescaler
    $16 constant ADC_COMMON_VREFEN              \ [0x16] VREFINT enable
    $17 constant ADC_COMMON_CH17SEL             \ [0x17] CH17SEL
    $18 constant ADC_COMMON_CH18SEL             \ [0x18] CH18SEL
  [then]


  [ifdef] ADC_COMMON_CDR_DEF
    \
    \ @brief Common regular data register for dual mode
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_RDATA_MST           \ [0x00 : 16] RDATA_MST
    $10 constant ADC_COMMON_RDATA_SLV           \ [0x10 : 16] RDATA_SLV
  [then]

  \
  \ @brief Analog-to-Digital Converter
  \
  $00 constant ADC_COMMON_CSR           \ ADC Common status register
  $08 constant ADC_COMMON_CCR           \ ADC common control register
  $0C constant ADC_COMMON_CDR           \ Common regular data register for dual mode

: ADC_COMMON_DEF ; [then]
