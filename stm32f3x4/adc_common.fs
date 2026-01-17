\
\ @file adc_common.fs
\ @brief ADC common registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC_COMMON_DEF

  [ifdef] ADC_COMMON_ADC1_CSR_DEF
    \
    \ @brief ADC Common status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_ADRDY_MST           \ [0x00] Master ADC ready
    $01 constant ADC_COMMON_EOSMP_MST           \ [0x01] End of Sampling phase flag of the master ADC
    $02 constant ADC_COMMON_EOC_MST             \ [0x02] End of regular conversion of the master ADC
    $03 constant ADC_COMMON_EOS_MST             \ [0x03] End of regular sequence flag of the master ADC
    $04 constant ADC_COMMON_OVR_MST             \ [0x04] Overrun flag of the master ADC
    $05 constant ADC_COMMON_JEOC_MST            \ [0x05] End of injected conversion flag of the master ADC
    $06 constant ADC_COMMON_JEOS_MST            \ [0x06] End of injected sequence flag of the master ADC
    $07 constant ADC_COMMON_AWD1_MST            \ [0x07] Analog watchdog 1 flag of the master ADC
    $08 constant ADC_COMMON_AWD2_MST            \ [0x08] Analog watchdog 2 flag of the master ADC
    $09 constant ADC_COMMON_AWD3_MST            \ [0x09] Analog watchdog 3 flag of the master ADC
    $0a constant ADC_COMMON_JQOVF_MST           \ [0x0a] Injected Context Queue Overflow flag of the master ADC
    $10 constant ADC_COMMON_ADRDY_SLV           \ [0x10] Slave ADC ready
    $11 constant ADC_COMMON_EOSMP_SLV           \ [0x11] End of Sampling phase flag of the slave ADC
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


  [ifdef] ADC_COMMON_ADC1_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_DUAL                \ [0x00 : 5] Dual ADC mode selection
    $08 constant ADC_COMMON_DELAY               \ [0x08 : 4] Delay between 2 sampling phases
    $0d constant ADC_COMMON_DMACFG              \ [0x0d] DMA configuration (for dual ADC mode)
    $0e constant ADC_COMMON_MDMA                \ [0x0e : 2] Direct memory access mode for dual ADC mode
    $10 constant ADC_COMMON_CKMODE              \ [0x10 : 2] ADC clock mode
    $16 constant ADC_COMMON_VREFEN              \ [0x16] VREFINT enable
    $17 constant ADC_COMMON_TSEN                \ [0x17] Temperature sensor enable
    $18 constant ADC_COMMON_VBATEN              \ [0x18] VBAT enable
  [then]


  [ifdef] ADC_COMMON_ADC1_CDR_DEF
    \
    \ @brief ADC common regular data register for dual mode
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_COMMON_RDATA_MST           \ [0x00 : 16] Regular data of the master ADC
    $10 constant ADC_COMMON_RDATA_SLV           \ [0x10 : 16] Regular data of the slave ADC
  [then]

  \
  \ @brief ADC common registers
  \
  $00 constant ADC_COMMON_ADC1_CSR      \ ADC Common status register
  $08 constant ADC_COMMON_ADC1_CCR      \ ADC common control register
  $0C constant ADC_COMMON_ADC1_CDR      \ ADC common regular data register for dual mode

: ADC_COMMON_DEF ; [then]
