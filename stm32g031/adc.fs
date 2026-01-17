\
\ @file adc.fs
\ @brief Analog to Digital Converter instance 1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC_DEF

  [ifdef] ADC_ISR_DEF
    \
    \ @brief ADC interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDY                      \ [0x00] ADC ready flag
    $01 constant ADC_EOSMP                      \ [0x01] ADC group regular end of sampling flag
    $02 constant ADC_EOC                        \ [0x02] ADC group regular end of unitary conversion flag
    $03 constant ADC_EOS                        \ [0x03] ADC group regular end of sequence conversions flag
    $04 constant ADC_OVR                        \ [0x04] ADC group regular overrun flag
    $07 constant ADC_AWD1                       \ [0x07] ADC analog watchdog 1 flag
    $08 constant ADC_AWD2                       \ [0x08] ADC analog watchdog 2 flag
    $09 constant ADC_AWD3                       \ [0x09] ADC analog watchdog 3 flag
    $0b constant ADC_EOCAL                      \ [0x0b] End Of Calibration flag
    $0d constant ADC_CCRDY                      \ [0x0d] Channel Configuration Ready flag
  [then]


  [ifdef] ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDYIE                    \ [0x00] ADC ready interrupt
    $01 constant ADC_EOSMPIE                    \ [0x01] ADC group regular end of sampling interrupt
    $02 constant ADC_EOCIE                      \ [0x02] ADC group regular end of unitary conversion interrupt
    $03 constant ADC_EOSIE                      \ [0x03] ADC group regular end of sequence conversions interrupt
    $04 constant ADC_OVRIE                      \ [0x04] ADC group regular overrun interrupt
    $07 constant ADC_AWD1IE                     \ [0x07] ADC analog watchdog 1 interrupt
    $08 constant ADC_AWD2IE                     \ [0x08] ADC analog watchdog 2 interrupt
    $09 constant ADC_AWD3IE                     \ [0x09] ADC analog watchdog 3 interrupt
    $0b constant ADC_EOCALIE                    \ [0x0b] End of calibration interrupt enable
    $0d constant ADC_CCRDYIE                    \ [0x0d] Channel Configuration Ready Interrupt enable
  [then]


  [ifdef] ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADEN                       \ [0x00] ADC enable
    $01 constant ADC_ADDIS                      \ [0x01] ADC disable
    $02 constant ADC_ADSTART                    \ [0x02] ADC group regular conversion start
    $04 constant ADC_ADSTP                      \ [0x04] ADC group regular conversion stop
    $1c constant ADC_ADVREGEN                   \ [0x1c] ADC voltage regulator enable
    $1f constant ADC_ADCAL                      \ [0x1f] ADC calibration
  [then]


  [ifdef] ADC_ADC_CFGR1_DEF
    \
    \ @brief ADC configuration register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DMAEN                      \ [0x00] ADC DMA transfer enable
    $01 constant ADC_DMACFG                     \ [0x01] ADC DMA transfer configuration
    $02 constant ADC_SCANDIR                    \ [0x02] Scan sequence direction
    $03 constant ADC_RES                        \ [0x03 : 2] ADC data resolution
    $05 constant ADC_ALIGN                      \ [0x05] ADC data alignement
    $06 constant ADC_EXTSEL                     \ [0x06 : 3] ADC group regular external trigger source
    $0a constant ADC_EXTEN                      \ [0x0a : 2] ADC group regular external trigger polarity
    $0c constant ADC_OVRMOD                     \ [0x0c] ADC group regular overrun configuration
    $0d constant ADC_CONT                       \ [0x0d] ADC group regular continuous conversion mode
    $0e constant ADC_WAIT                       \ [0x0e] Wait conversion mode
    $0f constant ADC_AUTOFF                     \ [0x0f] Auto-off mode
    $10 constant ADC_DISCEN                     \ [0x10] ADC group regular sequencer discontinuous mode
    $15 constant ADC_CHSELRMOD                  \ [0x15] Mode selection of the ADC_CHSELR register
    $16 constant ADC_AWD1SGL                    \ [0x16] ADC analog watchdog 1 monitoring a single channel or all channels
    $17 constant ADC_AWD1EN                     \ [0x17] ADC analog watchdog 1 enable on scope ADC group regular
    $1a constant ADC_AWDCH1CH                   \ [0x1a : 5] ADC analog watchdog 1 monitored channel selection
  [then]


  [ifdef] ADC_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OVSE                       \ [0x00] ADC oversampler enable on scope ADC group regular
    $02 constant ADC_OVSR                       \ [0x02 : 3] ADC oversampling ratio
    $05 constant ADC_OVSS                       \ [0x05 : 4] ADC oversampling shift
    $09 constant ADC_TOVS                       \ [0x09] ADC oversampling discontinuous mode (triggered mode) for ADC group regular
    $1d constant ADC_LFTRIG                     \ [0x1d] Low frequency trigger mode enable
    $1e constant ADC_CKMODE                     \ [0x1e : 2] ADC clock mode
  [then]


  [ifdef] ADC_SMPR_DEF
    \
    \ @brief ADC sampling time register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP1                       \ [0x00 : 3] Sampling time selection
    $04 constant ADC_SMP2                       \ [0x04 : 3] Sampling time selection
    $08 constant ADC_SMPSEL                     \ [0x08 : 19] Channel sampling time selection
  [then]


  [ifdef] ADC_AWD1TR_DEF
    \
    \ @brief watchdog threshold register
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT1                        \ [0x00 : 12] ADC analog watchdog 1 threshold low
    $10 constant ADC_HT1                        \ [0x10 : 12] ADC analog watchdog 1 threshold high
  [then]


  [ifdef] ADC_AWD2TR_DEF
    \
    \ @brief watchdog threshold register
    \ Address offset: 0x24
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT2                        \ [0x00 : 12] ADC analog watchdog 2 threshold low
    $10 constant ADC_HT2                        \ [0x10 : 12] ADC analog watchdog 2 threshold high
  [then]


  [ifdef] ADC_CHSELR_DEF
    \
    \ @brief channel selection register
    \ Address offset: 0x28
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_CHSEL                      \ [0x00 : 19] Channel-x selection
  [then]


  [ifdef] ADC_CHSELR_1_DEF
    \
    \ @brief channel selection register CHSELRMOD = 1 in ADC_CFGR1
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ1                        \ [0x00 : 4] conversion of the sequence
    $04 constant ADC_SQ2                        \ [0x04 : 4] conversion of the sequence
    $08 constant ADC_SQ3                        \ [0x08 : 4] conversion of the sequence
    $0c constant ADC_SQ4                        \ [0x0c : 4] conversion of the sequence
    $10 constant ADC_SQ5                        \ [0x10 : 4] conversion of the sequence
    $14 constant ADC_SQ6                        \ [0x14 : 4] conversion of the sequence
    $18 constant ADC_SQ7                        \ [0x18 : 4] conversion of the sequence
    $1c constant ADC_SQ8                        \ [0x1c : 4] conversion of the sequence
  [then]


  [ifdef] ADC_AWD3TR_DEF
    \
    \ @brief watchdog threshold register
    \ Address offset: 0x2C
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT3                        \ [0x00 : 12] ADC analog watchdog 3 threshold high
    $10 constant ADC_HT3                        \ [0x10 : 12] ADC analog watchdog 3 threshold high
  [then]


  [ifdef] ADC_DR_DEF
    \
    \ @brief ADC group regular conversion data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_regularDATA                \ [0x00 : 16] ADC group regular conversion data
  [then]


  [ifdef] ADC_AWD2CR_DEF
    \
    \ @brief ADC analog watchdog 2 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD2CH                     \ [0x00 : 19] ADC analog watchdog 2 monitored channel selection
  [then]


  [ifdef] ADC_AWD3CR_DEF
    \
    \ @brief ADC analog watchdog 3 configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD3CH                     \ [0x00 : 19] ADC analog watchdog 3 monitored channel selection
  [then]


  [ifdef] ADC_CALFACT_DEF
    \
    \ @brief ADC calibration factors register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT                    \ [0x00 : 7] ADC calibration factor in single-ended mode
  [then]


  [ifdef] ADC_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $12 constant ADC_PRESC                      \ [0x12 : 4] ADC prescaler
    $16 constant ADC_VREFEN                     \ [0x16] VREFINT enable
    $17 constant ADC_TSEN                       \ [0x17] Temperature sensor enable
    $18 constant ADC_VBATEN                     \ [0x18] VBAT enable
  [then]

  \
  \ @brief Analog to Digital Converter instance 1
  \
  $00 constant ADC_ISR                  \ ADC interrupt and status register
  $04 constant ADC_IER                  \ ADC interrupt enable register
  $08 constant ADC_CR                   \ ADC control register
  $0C constant ADC_ADC_CFGR1            \ ADC configuration register 1
  $10 constant ADC_ADC_CFGR2            \ ADC configuration register 2
  $14 constant ADC_SMPR                 \ ADC sampling time register
  $20 constant ADC_AWD1TR               \ watchdog threshold register
  $24 constant ADC_AWD2TR               \ watchdog threshold register
  $28 constant ADC_CHSELR               \ channel selection register
  $28 constant ADC_CHSELR_1             \ channel selection register CHSELRMOD = 1 in ADC_CFGR1
  $2C constant ADC_AWD3TR               \ watchdog threshold register
  $40 constant ADC_DR                   \ ADC group regular conversion data register
  $A0 constant ADC_AWD2CR               \ ADC analog watchdog 2 configuration register
  $A4 constant ADC_AWD3CR               \ ADC analog watchdog 3 configuration register
  $B4 constant ADC_CALFACT              \ ADC calibration factors register
  $308 constant ADC_CCR                 \ ADC common control register

: ADC_DEF ; [then]
