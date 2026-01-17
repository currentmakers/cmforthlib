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
    $12 constant ADC_COMMON_EOC_SLV             \ [0x12] End of regular conversion of the slave ADC
    $13 constant ADC_COMMON_EOS_SLV             \ [0x13] End of regular sequence flag of the slave ADC
    $14 constant ADC_COMMON_OVR_SLV             \ [0x14] Overrun flag of the slave ADC
    $15 constant ADC_COMMON_JEOC_SLV            \ [0x15] End of injected conversion flag of the slave ADC
    $16 constant ADC_COMMON_JEOS_SLV            \ [0x16] End of injected sequence flag of the slave ADC
    $17 constant ADC_COMMON_AWD1_SLV            \ [0x17] Analog watchdog 1 flag of the slave ADC
    $18 constant ADC_COMMON_AWD2_SLV            \ [0x18] Analog watchdog 2 flag of the slave ADC
    $19 constant ADC_COMMON_AWD3_SLV            \ [0x19] Analog watchdog 3 flag of the slave ADC
    $1a constant ADC_COMMON_JQOVF_SLV           \ [0x1a] Injected Context Queue Overflow flag of the slave ADC
  [then]


  [ifdef] ADC_COMMON_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_DUAL                \ [0x00 : 5] Dual ADC mode selection
    $08 constant ADC_COMMON_DELAY               \ [0x08 : 4] Delay between 2 sampling phases
    $0d constant ADC_COMMON_DMACFG              \ [0x0d] DMA configuration (for multi-ADC mode)
    $0e constant ADC_COMMON_MDMA                \ [0x0e : 2] Direct memory access mode for multi ADC mode
    $10 constant ADC_COMMON_CKMODE              \ [0x10 : 2] ADC clock mode
    $12 constant ADC_COMMON_PRESC               \ [0x12 : 4] ADC prescaler
    $16 constant ADC_COMMON_VREFEN              \ [0x16] VREFINT enable
    $17 constant ADC_COMMON_CH17SEL             \ [0x17] CH17 selection
    $18 constant ADC_COMMON_CH18SEL             \ [0x18] CH18 selection
  [then]


  [ifdef] ADC_COMMON_CDR_DEF
    \
    \ @brief ADC common regular data register for dual and triple modes
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_RDATA_MST           \ [0x00 : 16] Regular data of the master ADC
    $10 constant ADC_COMMON_RDATA_SLV           \ [0x10 : 16] Regular data of the slave ADC
  [then]

  \
  \ @brief Analog-to-Digital Converter
  \
  $00 constant ADC_COMMON_CSR           \ ADC Common status register
  $08 constant ADC_COMMON_CCR           \ ADC common control register
  $0C constant ADC_COMMON_CDR           \ ADC common regular data register for dual and triple modes

: ADC_COMMON_DEF ; [then]
