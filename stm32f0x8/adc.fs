\
\ @file adc.fs
\ @brief Analog-to-digital converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC_DEF

  [ifdef] ADC_ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDY                      \ [0x00] ADC ready
    $01 constant ADC_EOSMP                      \ [0x01] End of sampling flag
    $02 constant ADC_EOC                        \ [0x02] End of conversion flag
    $03 constant ADC_EOS                        \ [0x03] End of sequence flag
    $04 constant ADC_OVR                        \ [0x04] ADC overrun
    $07 constant ADC_AWD                        \ [0x07] Analog watchdog flag
  [then]


  [ifdef] ADC_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDYIE                    \ [0x00] ADC ready interrupt enable
    $01 constant ADC_EOSMPIE                    \ [0x01] End of sampling flag interrupt enable
    $02 constant ADC_EOCIE                      \ [0x02] End of conversion interrupt enable
    $03 constant ADC_EOSIE                      \ [0x03] End of conversion sequence interrupt enable
    $04 constant ADC_OVRIE                      \ [0x04] Overrun interrupt enable
    $07 constant ADC_AWDIE                      \ [0x07] Analog watchdog interrupt enable
  [then]


  [ifdef] ADC_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADEN                       \ [0x00] ADC enable command
    $01 constant ADC_ADDIS                      \ [0x01] ADC disable command
    $02 constant ADC_ADSTART                    \ [0x02] ADC start conversion command
    $04 constant ADC_ADSTP                      \ [0x04] ADC stop conversion command
    $1f constant ADC_ADCAL                      \ [0x1f] ADC calibration
  [then]


  [ifdef] ADC_CFGR1_DEF
    \
    \ @brief configuration register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DMAEN                      \ [0x00] Direct memory access enable
    $01 constant ADC_DMACFG                     \ [0x01] Direct memery access configuration
    $02 constant ADC_SCANDIR                    \ [0x02] Scan sequence direction
    $03 constant ADC_RES                        \ [0x03 : 2] Data resolution
    $05 constant ADC_ALIGN                      \ [0x05] Data alignment
    $06 constant ADC_EXTSEL                     \ [0x06 : 3] External trigger selection
    $0a constant ADC_EXTEN                      \ [0x0a : 2] External trigger enable and polarity selection
    $0c constant ADC_OVRMOD                     \ [0x0c] Overrun management mode
    $0d constant ADC_CONT                       \ [0x0d] Single / continuous conversion mode
    $0e constant ADC_AUTDLY                     \ [0x0e] Auto-delayed conversion mode
    $0f constant ADC_AUTOFF                     \ [0x0f] Auto-off mode
    $10 constant ADC_DISCEN                     \ [0x10] Discontinuous mode
    $16 constant ADC_AWDSGL                     \ [0x16] Enable the watchdog on a single channel or on all channels
    $17 constant ADC_AWDEN                      \ [0x17] Analog watchdog enable
    $1a constant ADC_AWDCH                      \ [0x1a : 5] Analog watchdog channel selection
  [then]


  [ifdef] ADC_CFGR2_DEF
    \
    \ @brief configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00008000
    \
    $1e constant ADC_JITOFF_D2                  \ [0x1e] JITOFF_D2
    $1f constant ADC_JITOFF_D4                  \ [0x1f] JITOFF_D4
  [then]


  [ifdef] ADC_SMPR_DEF
    \
    \ @brief sampling time register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMPR                       \ [0x00 : 3] Sampling time selection
  [then]


  [ifdef] ADC_TR_DEF
    \
    \ @brief watchdog threshold register
    \ Address offset: 0x20
    \ Reset value: 0x00000FFF
    \
    $00 constant ADC_LT                         \ [0x00 : 12] Analog watchdog lower threshold
    $10 constant ADC_HT                         \ [0x10 : 12] Analog watchdog higher threshold
  [then]


  [ifdef] ADC_CHSELR_DEF
    \
    \ @brief channel selection register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CHSEL0                     \ [0x00] Channel-x selection
    $01 constant ADC_CHSEL1                     \ [0x01] Channel-x selection
    $02 constant ADC_CHSEL2                     \ [0x02] Channel-x selection
    $03 constant ADC_CHSEL3                     \ [0x03] Channel-x selection
    $04 constant ADC_CHSEL4                     \ [0x04] Channel-x selection
    $05 constant ADC_CHSEL5                     \ [0x05] Channel-x selection
    $06 constant ADC_CHSEL6                     \ [0x06] Channel-x selection
    $07 constant ADC_CHSEL7                     \ [0x07] Channel-x selection
    $08 constant ADC_CHSEL8                     \ [0x08] Channel-x selection
    $09 constant ADC_CHSEL9                     \ [0x09] Channel-x selection
    $0a constant ADC_CHSEL10                    \ [0x0a] Channel-x selection
    $0b constant ADC_CHSEL11                    \ [0x0b] Channel-x selection
    $0c constant ADC_CHSEL12                    \ [0x0c] Channel-x selection
    $0d constant ADC_CHSEL13                    \ [0x0d] Channel-x selection
    $0e constant ADC_CHSEL14                    \ [0x0e] Channel-x selection
    $0f constant ADC_CHSEL15                    \ [0x0f] Channel-x selection
    $10 constant ADC_CHSEL16                    \ [0x10] Channel-x selection
    $11 constant ADC_CHSEL17                    \ [0x11] Channel-x selection
    $12 constant ADC_CHSEL18                    \ [0x12] Channel-x selection
  [then]


  [ifdef] ADC_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DATA                       \ [0x00 : 16] Converted data
  [then]


  [ifdef] ADC_CCR_DEF
    \
    \ @brief common configuration register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $16 constant ADC_VREFEN                     \ [0x16] Temperature sensor and VREFINT enable
    $17 constant ADC_TSEN                       \ [0x17] Temperature sensor enable
    $18 constant ADC_VBATEN                     \ [0x18] VBAT enable
  [then]

  \
  \ @brief Analog-to-digital converter
  \
  $00 constant ADC_ISR                  \ interrupt and status register
  $04 constant ADC_IER                  \ interrupt enable register
  $08 constant ADC_CR                   \ control register
  $0C constant ADC_CFGR1                \ configuration register 1
  $10 constant ADC_CFGR2                \ configuration register 2
  $14 constant ADC_SMPR                 \ sampling time register
  $20 constant ADC_TR                   \ watchdog threshold register
  $28 constant ADC_CHSELR               \ channel selection register
  $40 constant ADC_DR                   \ data register
  $308 constant ADC_CCR                 \ common configuration register

: ADC_DEF ; [then]
