\
\ @file adcc.fs
\ @brief ADC common registers block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADCC_DEF

  [ifdef] ADCC_ADC_CSR_DEF
    \
    \ @brief ADC common status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADCC_ADRDY_MST                 \ [0x00] Master ADC ready
    $01 constant ADCC_EOSMP_MST                 \ [0x01] End of Sampling phase flag of the master ADC
    $02 constant ADCC_EOC_MST                   \ [0x02] End of regular conversion of the master ADC
    $03 constant ADCC_EOS_MST                   \ [0x03] End of regular sequence flag of the master ADC
    $04 constant ADCC_OVR_MST                   \ [0x04] Overrun flag of the master ADC
    $05 constant ADCC_JEOC_MST                  \ [0x05] End of injected conversion flag of the master ADC
    $06 constant ADCC_JEOS_MST                  \ [0x06] End of injected sequence flag of the master ADC
    $07 constant ADCC_AWD1_MST                  \ [0x07] Analog watchdog 1 flag of the master ADC
    $08 constant ADCC_AWD2_MST                  \ [0x08] Analog watchdog 2 flag of the master ADC
    $09 constant ADCC_AWD3_MST                  \ [0x09] Analog watchdog 3 flag of the master ADC
    $0a constant ADCC_JQOVF_MST                 \ [0x0a] Injected Context Queue Overflow flag of the master ADC
    $10 constant ADCC_ADRDY_SLV                 \ [0x10] Slave ADC ready
    $11 constant ADCC_EOSMP_SLV                 \ [0x11] End of Sampling phase flag of the slave ADC
    $12 constant ADCC_EOC_SLV                   \ [0x12] End of regular conversion of the slave ADC
    $13 constant ADCC_EOS_SLV                   \ [0x13] End of regular sequence flag of the slave ADC.
    $14 constant ADCC_OVR_SLV                   \ [0x14] Overrun flag of the slave ADC
    $15 constant ADCC_JEOC_SLV                  \ [0x15] End of injected conversion flag of the slave ADC
    $16 constant ADCC_JEOS_SLV                  \ [0x16] End of injected sequence flag of the slave ADC
    $17 constant ADCC_AWD1_SLV                  \ [0x17] Analog watchdog 1 flag of the slave ADC
    $18 constant ADCC_AWD2_SLV                  \ [0x18] Analog watchdog 2 flag of the slave ADC
    $19 constant ADCC_AWD3_SLV                  \ [0x19] Analog watchdog 3 flag of the slave ADC
    $1a constant ADCC_JQOVF_SLV                 \ [0x1a] Injected Context Queue Overflow flag of the slave ADC
  [then]


  [ifdef] ADCC_ADC_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADCC_DUAL                      \ [0x00 : 5] Dual ADC mode selection
    $08 constant ADCC_DELAY                     \ [0x08 : 4] Delay between 2 sampling phases
    $0d constant ADCC_DMACFG                    \ [0x0d] DMA configuration (for dual ADC mode)
    $0e constant ADCC_MDMA                      \ [0x0e : 2] Direct memory access mode for dual ADC mode
    $10 constant ADCC_CKMODE                    \ [0x10 : 2] ADC clock mode
    $12 constant ADCC_PRESC                     \ [0x12 : 4] ADC prescaler
    $16 constant ADCC_VREFEN                    \ [0x16] Vless thansub>REFINTless than/sub> enable
    $17 constant ADCC_TSEN                      \ [0x17] Vless thansub>SENSEless than/sub> enable
    $18 constant ADCC_VBATEN                    \ [0x18] VBAT enable
  [then]


  [ifdef] ADCC_ADC_CDR_DEF
    \
    \ @brief ADC common regular data register for dual mode
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADCC_RDATA_MST                 \ [0x00 : 16] Regular data of the master ADC.
    $10 constant ADCC_RDATA_SLV                 \ [0x10 : 16] Regular data of the slave ADC
  [then]


  [ifdef] ADCC_ADC_HWCFGR0_DEF
    \
    \ @brief ADC hardware configuration register
    \ Address offset: 0xF0
    \ Reset value: 0x00001212
    \
    $00 constant ADCC_ADCNUM                    \ [0x00 : 4] Number of ADCs implemented
    $04 constant ADCC_MULPIPE                   \ [0x04 : 4] Number of pipeline stages
    $08 constant ADCC_OPBITS                    \ [0x08 : 4] Number of option bits
    $0c constant ADCC_IDLEVALUE                 \ [0x0c : 4] Idle value for non-selected channels
  [then]


  [ifdef] ADCC_ADC_VERR_DEF
    \
    \ @brief ADC version register
    \ Address offset: 0xF4
    \ Reset value: 0x00000012
    \
    $00 constant ADCC_MINREV                    \ [0x00 : 4] Minor revision
    $04 constant ADCC_MAJREV                    \ [0x04 : 4] Major revision
  [then]


  [ifdef] ADCC_ADC_IPDR_DEF
    \
    \ @brief ADC identification register
    \ Address offset: 0xF8
    \ Reset value: 0x00110006
    \
    $00 constant ADCC_ID                        \ [0x00 : 32] Peripheral identifier
  [then]


  [ifdef] ADCC_ADC_SIDR_DEF
    \
    \ @brief ADC size identification register
    \ Address offset: 0xFC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant ADCC_SID                       \ [0x00 : 32] Size Identification
  [then]

  \
  \ @brief ADC common registers block
  \
  $00 constant ADCC_ADC_CSR             \ ADC common status register
  $08 constant ADCC_ADC_CCR             \ ADC common control register
  $0C constant ADCC_ADC_CDR             \ ADC common regular data register for dual mode
  $F0 constant ADCC_ADC_HWCFGR0         \ ADC hardware configuration register
  $F4 constant ADCC_ADC_VERR            \ ADC version register
  $F8 constant ADCC_ADC_IPDR            \ ADC identification register
  $FC constant ADCC_ADC_SIDR            \ ADC size identification register

: ADCC_DEF ; [then]
