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
    $05 constant ADC_JEOC                       \ [0x05] ADC group injected end of unitary conversion flag
    $06 constant ADC_JEOS                       \ [0x06] ADC group injected end of sequence conversions flag
    $07 constant ADC_AWD1                       \ [0x07] ADC analog watchdog 1 flag
    $08 constant ADC_AWD2                       \ [0x08] ADC analog watchdog 2 flag
    $09 constant ADC_AWD3                       \ [0x09] ADC analog watchdog 3 flag
    $0a constant ADC_JQOVF                      \ [0x0a] ADC group injected contexts queue overflow flag
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
    $05 constant ADC_JEOCIE                     \ [0x05] ADC group injected end of unitary conversion interrupt
    $06 constant ADC_JEOSIE                     \ [0x06] ADC group injected end of sequence conversions interrupt
    $07 constant ADC_AWD1IE                     \ [0x07] ADC analog watchdog 1 interrupt
    $08 constant ADC_AWD2IE                     \ [0x08] ADC analog watchdog 2 interrupt
    $09 constant ADC_AWD3IE                     \ [0x09] ADC analog watchdog 3 interrupt
    $0a constant ADC_JQOVFIE                    \ [0x0a] ADC group injected contexts queue overflow interrupt
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
    $03 constant ADC_JADSTART                   \ [0x03] ADC group injected conversion start
    $04 constant ADC_ADSTP                      \ [0x04] ADC group regular conversion stop
    $05 constant ADC_JADSTP                     \ [0x05] ADC group injected conversion stop
    $1c constant ADC_ADVREGEN                   \ [0x1c] ADC voltage regulator enable
    $1d constant ADC_DEEPPWD                    \ [0x1d] ADC deep power down enable
    $1e constant ADC_ADCALDIF                   \ [0x1e] ADC differential mode for calibration
    $1f constant ADC_ADCAL                      \ [0x1f] ADC calibration
  [then]


  [ifdef] ADC_CFGR_DEF
    \
    \ @brief ADC configuration register 1
    \ Address offset: 0x0C
    \ Reset value: 0x80000000
    \
    $00 constant ADC_DMAEN                      \ [0x00] ADC DMA transfer enable
    $01 constant ADC_DMACFG                     \ [0x01] ADC DMA transfer configuration
    $03 constant ADC_RES                        \ [0x03 : 2] ADC data resolution
    $05 constant ADC_ALIGN                      \ [0x05] ADC data alignement
    $06 constant ADC_EXTSEL                     \ [0x06 : 4] ADC group regular external trigger source
    $0a constant ADC_EXTEN                      \ [0x0a : 2] ADC group regular external trigger polarity
    $0c constant ADC_OVRMOD                     \ [0x0c] ADC group regular overrun configuration
    $0d constant ADC_CONT                       \ [0x0d] ADC group regular continuous conversion mode
    $0e constant ADC_AUTDLY                     \ [0x0e] ADC low power auto wait
    $10 constant ADC_DISCEN                     \ [0x10] ADC group regular sequencer discontinuous mode
    $11 constant ADC_DISCNUM                    \ [0x11 : 3] ADC group regular sequencer discontinuous number of ranks
    $14 constant ADC_JDISCEN                    \ [0x14] ADC group injected sequencer discontinuous mode
    $15 constant ADC_JQM                        \ [0x15] ADC group injected contexts queue mode
    $16 constant ADC_AWD1SGL                    \ [0x16] ADC analog watchdog 1 monitoring a single channel or all channels
    $17 constant ADC_AWD1EN                     \ [0x17] ADC analog watchdog 1 enable on scope ADC group regular
    $18 constant ADC_JAWD1EN                    \ [0x18] ADC analog watchdog 1 enable on scope ADC group injected
    $19 constant ADC_JAUTO                      \ [0x19] ADC group injected automatic trigger mode
    $1a constant ADC_AWDCH1CH                   \ [0x1a : 5] ADC analog watchdog 1 monitored channel selection
    $1f constant ADC_JQDIS                      \ [0x1f] ADC group injected contexts queue disable
  [then]


  [ifdef] ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ROVSE                      \ [0x00] ADC oversampler enable on scope ADC group regular
    $01 constant ADC_JOVSE                      \ [0x01] ADC oversampler enable on scope ADC group injected
    $02 constant ADC_OVSR                       \ [0x02 : 3] ADC oversampling ratio
    $05 constant ADC_OVSS                       \ [0x05 : 4] ADC oversampling shift
    $09 constant ADC_TOVS                       \ [0x09] ADC oversampling discontinuous mode (triggered mode) for ADC group regular
    $0a constant ADC_ROVSM                      \ [0x0a] ADC oversampling mode managing interlaced conversions of ADC group regular and group injected
  [then]


  [ifdef] ADC_SMPR1_DEF
    \
    \ @brief ADC sampling time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP0                       \ [0x00 : 3] ADC channel 0 sampling time selection
    $03 constant ADC_SMP1                       \ [0x03 : 3] ADC channel 1 sampling time selection
    $06 constant ADC_SMP2                       \ [0x06 : 3] ADC channel 2 sampling time selection
    $09 constant ADC_SMP3                       \ [0x09 : 3] ADC channel 3 sampling time selection
    $0c constant ADC_SMP4                       \ [0x0c : 3] ADC channel 4 sampling time selection
    $0f constant ADC_SMP5                       \ [0x0f : 3] ADC channel 5 sampling time selection
    $12 constant ADC_SMP6                       \ [0x12 : 3] ADC channel 6 sampling time selection
    $15 constant ADC_SMP7                       \ [0x15 : 3] ADC channel 7 sampling time selection
    $18 constant ADC_SMP8                       \ [0x18 : 3] ADC channel 8 sampling time selection
    $1b constant ADC_SMP9                       \ [0x1b : 3] ADC channel 9 sampling time selection
  [then]


  [ifdef] ADC_SMPR2_DEF
    \
    \ @brief ADC sampling time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP10                      \ [0x00 : 3] ADC channel 10 sampling time selection
    $03 constant ADC_SMP11                      \ [0x03 : 3] ADC channel 11 sampling time selection
    $06 constant ADC_SMP12                      \ [0x06 : 3] ADC channel 12 sampling time selection
    $09 constant ADC_SMP13                      \ [0x09 : 3] ADC channel 13 sampling time selection
    $0c constant ADC_SMP14                      \ [0x0c : 3] ADC channel 14 sampling time selection
    $0f constant ADC_SMP15                      \ [0x0f : 3] ADC channel 15 sampling time selection
    $12 constant ADC_SMP16                      \ [0x12 : 3] ADC channel 16 sampling time selection
    $15 constant ADC_SMP17                      \ [0x15 : 3] ADC channel 17 sampling time selection
    $18 constant ADC_SMP18                      \ [0x18 : 3] ADC channel 18 sampling time selection
  [then]


  [ifdef] ADC_TR1_DEF
    \
    \ @brief ADC analog watchdog 1 threshold register
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT1                        \ [0x00 : 12] ADC analog watchdog 1 threshold low
    $10 constant ADC_HT1                        \ [0x10 : 12] ADC analog watchdog 1 threshold high
  [then]


  [ifdef] ADC_TR2_DEF
    \
    \ @brief ADC analog watchdog 2 threshold register
    \ Address offset: 0x24
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT2                        \ [0x00 : 8] ADC analog watchdog 2 threshold low
    $10 constant ADC_HT2                        \ [0x10 : 8] ADC analog watchdog 2 threshold high
  [then]


  [ifdef] ADC_TR3_DEF
    \
    \ @brief ADC analog watchdog 3 threshold register
    \ Address offset: 0x28
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT3                        \ [0x00 : 8] ADC analog watchdog 3 threshold low
    $10 constant ADC_HT3                        \ [0x10 : 8] ADC analog watchdog 3 threshold high
  [then]


  [ifdef] ADC_SQR1_DEF
    \
    \ @brief ADC group regular sequencer ranks register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC_L3                         \ [0x00 : 4] L3
    $06 constant ADC_SQ1                        \ [0x06 : 5] ADC group regular sequencer rank 1
    $0c constant ADC_SQ2                        \ [0x0c : 5] ADC group regular sequencer rank 2
    $12 constant ADC_SQ3                        \ [0x12 : 5] ADC group regular sequencer rank 3
    $18 constant ADC_SQ4                        \ [0x18 : 5] ADC group regular sequencer rank 4
  [then]


  [ifdef] ADC_SQR2_DEF
    \
    \ @brief ADC group regular sequencer ranks register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ5                        \ [0x00 : 5] ADC group regular sequencer rank 5
    $06 constant ADC_SQ6                        \ [0x06 : 5] ADC group regular sequencer rank 6
    $0c constant ADC_SQ7                        \ [0x0c : 5] ADC group regular sequencer rank 7
    $12 constant ADC_SQ8                        \ [0x12 : 5] ADC group regular sequencer rank 8
    $18 constant ADC_SQ9                        \ [0x18 : 5] ADC group regular sequencer rank 9
  [then]


  [ifdef] ADC_SQR3_DEF
    \
    \ @brief ADC group regular sequencer ranks register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ10                       \ [0x00 : 5] ADC group regular sequencer rank 10
    $06 constant ADC_SQ11                       \ [0x06 : 5] ADC group regular sequencer rank 11
    $0c constant ADC_SQ12                       \ [0x0c : 5] ADC group regular sequencer rank 12
    $12 constant ADC_SQ13                       \ [0x12 : 5] ADC group regular sequencer rank 13
    $18 constant ADC_SQ14                       \ [0x18 : 5] ADC group regular sequencer rank 14
  [then]


  [ifdef] ADC_SQR4_DEF
    \
    \ @brief ADC group regular sequencer ranks register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ15                       \ [0x00 : 5] ADC group regular sequencer rank 15
    $06 constant ADC_SQ16                       \ [0x06 : 5] ADC group regular sequencer rank 16
  [then]


  [ifdef] ADC_DR_DEF
    \
    \ @brief ADC group regular conversion data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_RDATA_0_6                  \ [0x00 : 6] Regular Data converted 0_6
    $07 constant ADC_RDATA_7_15                 \ [0x07 : 9] 15
  [then]


  [ifdef] ADC_JSQR_DEF
    \
    \ @brief ADC group injected sequencer register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JL                         \ [0x00 : 2] ADC group injected sequencer scan length
    $02 constant ADC_JEXTSEL                    \ [0x02 : 4] ADC group injected external trigger source
    $06 constant ADC_JEXTEN                     \ [0x06 : 2] ADC group injected external trigger polarity
    $08 constant ADC_JSQ1                       \ [0x08 : 5] ADC group injected sequencer rank 1
    $0e constant ADC_JSQ2                       \ [0x0e : 5] ADC group injected sequencer rank 2
    $14 constant ADC_JSQ3                       \ [0x14 : 5] ADC group injected sequencer rank 3
    $1a constant ADC_JSQ4                       \ [0x1a : 5] ADC group injected sequencer rank 4
  [then]


  [ifdef] ADC_OFR1_DEF
    \
    \ @brief ADC offset number 1 register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET1                    \ [0x00 : 12] ADC offset number 1 offset level
    $1a constant ADC_OFFSET1_CH                 \ [0x1a : 5] ADC offset number 1 channel selection
    $1f constant ADC_OFFSET1_EN                 \ [0x1f] ADC offset number 1 enable
  [then]


  [ifdef] ADC_OFR2_DEF
    \
    \ @brief ADC offset number 2 register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET2                    \ [0x00 : 12] ADC offset number 2 offset level
    $1a constant ADC_OFFSET2_CH                 \ [0x1a : 5] ADC offset number 2 channel selection
    $1f constant ADC_OFFSET2_EN                 \ [0x1f] ADC offset number 2 enable
  [then]


  [ifdef] ADC_OFR3_DEF
    \
    \ @brief ADC offset number 3 register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET3                    \ [0x00 : 12] ADC offset number 3 offset level
    $1a constant ADC_OFFSET3_CH                 \ [0x1a : 5] ADC offset number 3 channel selection
    $1f constant ADC_OFFSET3_EN                 \ [0x1f] ADC offset number 3 enable
  [then]


  [ifdef] ADC_OFR4_DEF
    \
    \ @brief ADC offset number 4 register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET4                    \ [0x00 : 12] ADC offset number 4 offset level
    $1a constant ADC_OFFSET4_CH                 \ [0x1a : 5] ADC offset number 4 channel selection
    $1f constant ADC_OFFSET4_EN                 \ [0x1f] ADC offset number 4 enable
  [then]


  [ifdef] ADC_JDR1_DEF
    \
    \ @brief ADC group injected sequencer rank 1 register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA1                     \ [0x00 : 16] ADC group injected sequencer rank 1 conversion data
  [then]


  [ifdef] ADC_JDR2_DEF
    \
    \ @brief ADC group injected sequencer rank 2 register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA2                     \ [0x00 : 16] ADC group injected sequencer rank 2 conversion data
  [then]


  [ifdef] ADC_JDR3_DEF
    \
    \ @brief ADC group injected sequencer rank 3 register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA3                     \ [0x00 : 16] ADC group injected sequencer rank 3 conversion data
  [then]


  [ifdef] ADC_JDR4_DEF
    \
    \ @brief ADC group injected sequencer rank 4 register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA4                     \ [0x00 : 16] ADC group injected sequencer rank 4 conversion data
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


  [ifdef] ADC_DIFSEL_DEF
    \
    \ @brief ADC channel differential or single-ended mode selection register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DIFSEL_0                   \ [0x00] ADC channel differential or single-ended mode for channel 0
    $01 constant ADC_DIFSEL_1_15                \ [0x01 : 15] ADC channel differential or single-ended mode for channels 1 to 15
    $10 constant ADC_DIFSEL_16_18               \ [0x10 : 3] ADC channel differential or single-ended mode for channels 18 to 16
  [then]


  [ifdef] ADC_CALFACT_DEF
    \
    \ @brief ADC calibration factors register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT_S                  \ [0x00 : 7] ADC calibration factor in single-ended mode
    $10 constant ADC_CALFACT_D                  \ [0x10 : 7] ADC calibration factor in differential mode
  [then]


  [ifdef] ADC_CCR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $10 constant ADC_CKMODE                     \ [0x10 : 2] ADC clock mode
    $12 constant ADC_PRESC                      \ [0x12 : 4] ADC prescaler
    $16 constant ADC_VREFEN                     \ [0x16] VREFEN
    $17 constant ADC_TSEN                       \ [0x17] Temperature sensor enable
    $18 constant ADC_VBATEN                     \ [0x18] VBAT enable
  [then]

  \
  \ @brief Analog to Digital Converter instance 1
  \
  $00 constant ADC_ISR                  \ ADC interrupt and status register
  $04 constant ADC_IER                  \ ADC interrupt enable register
  $08 constant ADC_CR                   \ ADC control register
  $0C constant ADC_CFGR                 \ ADC configuration register 1
  $10 constant ADC_CFGR2                \ ADC configuration register 2
  $14 constant ADC_SMPR1                \ ADC sampling time register 1
  $18 constant ADC_SMPR2                \ ADC sampling time register 2
  $20 constant ADC_TR1                  \ ADC analog watchdog 1 threshold register
  $24 constant ADC_TR2                  \ ADC analog watchdog 2 threshold register
  $28 constant ADC_TR3                  \ ADC analog watchdog 3 threshold register
  $30 constant ADC_SQR1                 \ ADC group regular sequencer ranks register 1
  $34 constant ADC_SQR2                 \ ADC group regular sequencer ranks register 2
  $38 constant ADC_SQR3                 \ ADC group regular sequencer ranks register 3
  $3C constant ADC_SQR4                 \ ADC group regular sequencer ranks register 4
  $40 constant ADC_DR                   \ ADC group regular conversion data register
  $4C constant ADC_JSQR                 \ ADC group injected sequencer register
  $60 constant ADC_OFR1                 \ ADC offset number 1 register
  $64 constant ADC_OFR2                 \ ADC offset number 2 register
  $68 constant ADC_OFR3                 \ ADC offset number 3 register
  $6C constant ADC_OFR4                 \ ADC offset number 4 register
  $80 constant ADC_JDR1                 \ ADC group injected sequencer rank 1 register
  $84 constant ADC_JDR2                 \ ADC group injected sequencer rank 2 register
  $88 constant ADC_JDR3                 \ ADC group injected sequencer rank 3 register
  $8C constant ADC_JDR4                 \ ADC group injected sequencer rank 4 register
  $A0 constant ADC_AWD2CR               \ ADC analog watchdog 2 configuration register
  $A4 constant ADC_AWD3CR               \ ADC analog watchdog 3 configuration register
  $B0 constant ADC_DIFSEL               \ ADC channel differential or single-ended mode selection register
  $B4 constant ADC_CALFACT              \ ADC calibration factors register
  $308 constant ADC_CCR                 \ ADC common control register

: ADC_DEF ; [then]
