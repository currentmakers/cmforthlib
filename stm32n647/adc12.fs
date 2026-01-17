\
\ @file adc12.fs
\ @brief ADC common registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC12_DEF

  [ifdef] ADC12_ADC12_CSR_DEF
    \
    \ @brief ADC12 common status register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_ADRDY_MST                \ [0x00] Master ADC ready
    $01 constant ADC12_EOSMP_MST                \ [0x01] End of Sampling phase flag of the master ADC
    $02 constant ADC12_EOC_MST                  \ [0x02] End of regular conversion of the master ADC
    $03 constant ADC12_EOS_MST                  \ [0x03] End of regular sequence flag of the master ADC
    $04 constant ADC12_OVR_MST                  \ [0x04] Overrun flag of the master ADC
    $05 constant ADC12_JEOC_MST                 \ [0x05] End of injected conversion flag of the master ADC
    $06 constant ADC12_JEOS_MST                 \ [0x06] End of injected sequence flag of the master ADC
    $07 constant ADC12_AWD1_MST                 \ [0x07] Analog watchdog 1 flag of the master ADC
    $08 constant ADC12_AWD2_MST                 \ [0x08] Analog watchdog 2 flag of the master ADC
    $09 constant ADC12_AWD3_MST                 \ [0x09] Analog watchdog 3 flag of the master ADC
    $10 constant ADC12_ADRDY_SLV                \ [0x10] Slave ADC ready
    $11 constant ADC12_EOSMP_SLV                \ [0x11] End of Sampling phase flag of the slave ADC
    $12 constant ADC12_EOC_SLV                  \ [0x12] End of regular conversion of the slave ADC
    $13 constant ADC12_EOS_SLV                  \ [0x13] End of regular sequence flag of the slave ADC. This bit is a copy of the EOS bit in the corresponding ADC_ISR register.
    $14 constant ADC12_OVR_SLV                  \ [0x14] Overrun flag of the slave ADC
    $15 constant ADC12_JEOC_SLV                 \ [0x15] End of injected conversion flag of the slave ADC
    $16 constant ADC12_JEOS_SLV                 \ [0x16] End of injected sequence flag of the slave ADC
    $17 constant ADC12_AWD1_SLV                 \ [0x17] Analog watchdog 1 flag of the slave ADC
    $18 constant ADC12_AWD2_SLV                 \ [0x18] Analog watchdog 2 flag of the slave ADC
    $19 constant ADC12_AWD3_SLV                 \ [0x19] Analog watchdog 3 flag of the slave ADC
  [then]


  [ifdef] ADC12_ADC12_CCR_DEF
    \
    \ @brief ADC12 common control register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_DUAL                     \ [0x00 : 5] Dual ADC mode selection
    $08 constant ADC12_DELAY                    \ [0x08 : 4] Delay between two sampling phases
    $0e constant ADC12_DAMDF                    \ [0x0e : 2] Dual ADC mode data format
    $16 constant ADC12_VREFEN                   \ [0x16] Vless thansub>REFINTless than/sub> enable
    $18 constant ADC12_VBATEN                   \ [0x18] VBAT enable
  [then]


  [ifdef] ADC12_ADC12_CDR_DEF
    \
    \ @brief ADC12 common regular data register for Dual mode
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_RDATA_MST                \ [0x00 : 16] Regular data of the master ADC.
    $10 constant ADC12_RDATA_SLV                \ [0x10 : 16] Regular data of the slave ADC
  [then]


  [ifdef] ADC12_ADC12_CDR2_DEF
    \
    \ @brief ADC12 common regular data register for Dual mode
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant ADC12_RDATA_ALT                \ [0x00 : 32] Regular data of the master/slave alternated ADCs.
  [then]

  \
  \ @brief ADC common registers
  \
  $300 constant ADC12_ADC12_CSR         \ ADC12 common status register
  $308 constant ADC12_ADC12_CCR         \ ADC12 common control register
  $30C constant ADC12_ADC12_CDR         \ ADC12 common regular data register for Dual mode
  $310 constant ADC12_ADC12_CDR2        \ ADC12 common regular data register for Dual mode

: ADC12_DEF ; [then]
