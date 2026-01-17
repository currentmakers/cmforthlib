\
\ @file adc3.fs
\ @brief Analog to Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC3_DEF

  [ifdef] ADC3_ISR_DEF
    \
    \ @brief ADC interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_ADRDY                     \ [0x00] ADC ready flag
    $01 constant ADC3_EOSMP                     \ [0x01] ADC group regular end of sampling flag
    $02 constant ADC3_EOC                       \ [0x02] ADC group regular end of unitary conversion flag
    $03 constant ADC3_EOS                       \ [0x03] ADC group regular end of sequence conversions flag
    $04 constant ADC3_OVR                       \ [0x04] ADC group regular overrun flag
    $05 constant ADC3_JEOC                      \ [0x05] ADC group injected end of unitary conversion flag
    $06 constant ADC3_JEOS                      \ [0x06] ADC group injected end of sequence conversions flag
    $07 constant ADC3_AWD1                      \ [0x07] ADC analog watchdog 1 flag
    $08 constant ADC3_AWD2                      \ [0x08] ADC analog watchdog 2 flag
    $09 constant ADC3_AWD3                      \ [0x09] ADC analog watchdog 3 flag
    $0a constant ADC3_JQOVF                     \ [0x0a] ADC group injected contexts queue overflow flag
  [then]


  [ifdef] ADC3_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_ADRDYIE                   \ [0x00] ADC ready interrupt
    $01 constant ADC3_EOSMPIE                   \ [0x01] ADC group regular end of sampling interrupt
    $02 constant ADC3_EOCIE                     \ [0x02] ADC group regular end of unitary conversion interrupt
    $03 constant ADC3_EOSIE                     \ [0x03] ADC group regular end of sequence conversions interrupt
    $04 constant ADC3_OVRIE                     \ [0x04] ADC group regular overrun interrupt
    $05 constant ADC3_JEOCIE                    \ [0x05] ADC group injected end of unitary conversion interrupt
    $06 constant ADC3_JEOSIE                    \ [0x06] ADC group injected end of sequence conversions interrupt
    $07 constant ADC3_AWD1IE                    \ [0x07] ADC analog watchdog 1 interrupt
    $08 constant ADC3_AWD2IE                    \ [0x08] ADC analog watchdog 2 interrupt
    $09 constant ADC3_AWD3IE                    \ [0x09] ADC analog watchdog 3 interrupt
    $0a constant ADC3_JQOVFIE                   \ [0x0a] ADC group injected contexts queue overflow interrupt
  [then]


  [ifdef] ADC3_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_ADEN                      \ [0x00] ADC enable
    $01 constant ADC3_ADDIS                     \ [0x01] ADC disable
    $02 constant ADC3_ADSTART                   \ [0x02] ADC group regular conversion start
    $03 constant ADC3_JADSTART                  \ [0x03] ADC group injected conversion start
    $04 constant ADC3_ADSTP                     \ [0x04] ADC group regular conversion stop
    $05 constant ADC3_JADSTP                    \ [0x05] ADC group injected conversion stop
    $08 constant ADC3_BOOST                     \ [0x08] Boost mode control
    $10 constant ADC3_ADCALLIN                  \ [0x10] Linearity calibration
    $16 constant ADC3_LINCALRDYW1               \ [0x16] Linearity calibration ready Word 1
    $17 constant ADC3_LINCALRDYW2               \ [0x17] Linearity calibration ready Word 2
    $18 constant ADC3_LINCALRDYW3               \ [0x18] Linearity calibration ready Word 3
    $19 constant ADC3_LINCALRDYW4               \ [0x19] Linearity calibration ready Word 4
    $1a constant ADC3_LINCALRDYW5               \ [0x1a] Linearity calibration ready Word 5
    $1b constant ADC3_LINCALRDYW6               \ [0x1b] Linearity calibration ready Word 6
    $1c constant ADC3_ADVREGEN                  \ [0x1c] ADC voltage regulator enable
    $1d constant ADC3_DEEPPWD                   \ [0x1d] ADC deep power down enable
    $1e constant ADC3_ADCALDIF                  \ [0x1e] ADC differential mode for calibration
    $1f constant ADC3_ADCAL                     \ [0x1f] ADC calibration
  [then]


  [ifdef] ADC3_CFGR_DEF
    \
    \ @brief ADC configuration register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_DMNGT                     \ [0x00 : 2] ADC DMA transfer enable
    $02 constant ADC3_RES                       \ [0x02 : 3] ADC data resolution
    $05 constant ADC3_EXTSEL                    \ [0x05 : 5] ADC group regular external trigger source
    $0a constant ADC3_EXTEN                     \ [0x0a : 2] ADC group regular external trigger polarity
    $0c constant ADC3_OVRMOD                    \ [0x0c] ADC group regular overrun configuration
    $0d constant ADC3_CONT                      \ [0x0d] ADC group regular continuous conversion mode
    $0e constant ADC3_AUTDLY                    \ [0x0e] ADC low power auto wait
    $10 constant ADC3_DISCEN                    \ [0x10] ADC group regular sequencer discontinuous mode
    $11 constant ADC3_DISCNUM                   \ [0x11 : 3] ADC group regular sequencer discontinuous number of ranks
    $14 constant ADC3_JDISCEN                   \ [0x14] ADC group injected sequencer discontinuous mode
    $15 constant ADC3_JQM                       \ [0x15] ADC group injected contexts queue mode
    $16 constant ADC3_AWD1SGL                   \ [0x16] ADC analog watchdog 1 monitoring a single channel or all channels
    $17 constant ADC3_AWD1EN                    \ [0x17] ADC analog watchdog 1 enable on scope ADC group regular
    $18 constant ADC3_JAWD1EN                   \ [0x18] ADC analog watchdog 1 enable on scope ADC group injected
    $19 constant ADC3_JAUTO                     \ [0x19] ADC group injected automatic trigger mode
    $1a constant ADC3_AWDCH1CH                  \ [0x1a : 5] ADC analog watchdog 1 monitored channel selection
    $1f constant ADC3_JQDIS                     \ [0x1f] ADC group injected contexts queue disable
  [then]


  [ifdef] ADC3_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_ROVSE                     \ [0x00] ADC oversampler enable on scope ADC group regular
    $01 constant ADC3_JOVSE                     \ [0x01] ADC oversampler enable on scope ADC group injected
    $05 constant ADC3_OVSS                      \ [0x05 : 4] ADC oversampling shift
    $09 constant ADC3_TROVS                     \ [0x09] ADC oversampling discontinuous mode (triggered mode) for ADC group regular
    $0a constant ADC3_ROVSM                     \ [0x0a] Regular Oversampling mode
    $0b constant ADC3_RSHIFT1                   \ [0x0b] Right-shift data after Offset 1 correction
    $0c constant ADC3_RSHIFT2                   \ [0x0c] Right-shift data after Offset 2 correction
    $0d constant ADC3_RSHIFT3                   \ [0x0d] Right-shift data after Offset 3 correction
    $0e constant ADC3_RSHIFT4                   \ [0x0e] Right-shift data after Offset 4 correction
    $10 constant ADC3_OSR                       \ [0x10 : 10] Oversampling ratio
    $1c constant ADC3_LSHIFT                    \ [0x1c : 4] Left shift factor
  [then]


  [ifdef] ADC3_SMPR1_DEF
    \
    \ @brief ADC sampling time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $03 constant ADC3_SMP1                      \ [0x03 : 3] ADC channel 1 sampling time selection
    $06 constant ADC3_SMP2                      \ [0x06 : 3] ADC channel 2 sampling time selection
    $09 constant ADC3_SMP3                      \ [0x09 : 3] ADC channel 3 sampling time selection
    $0c constant ADC3_SMP4                      \ [0x0c : 3] ADC channel 4 sampling time selection
    $0f constant ADC3_SMP5                      \ [0x0f : 3] ADC channel 5 sampling time selection
    $12 constant ADC3_SMP6                      \ [0x12 : 3] ADC channel 6 sampling time selection
    $15 constant ADC3_SMP7                      \ [0x15 : 3] ADC channel 7 sampling time selection
    $18 constant ADC3_SMP8                      \ [0x18 : 3] ADC channel 8 sampling time selection
    $1b constant ADC3_SMP9                      \ [0x1b : 3] ADC channel 9 sampling time selection
  [then]


  [ifdef] ADC3_SMPR2_DEF
    \
    \ @brief ADC sampling time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SMP10                     \ [0x00 : 3] ADC channel 10 sampling time selection
    $03 constant ADC3_SMP11                     \ [0x03 : 3] ADC channel 11 sampling time selection
    $06 constant ADC3_SMP12                     \ [0x06 : 3] ADC channel 12 sampling time selection
    $09 constant ADC3_SMP13                     \ [0x09 : 3] ADC channel 13 sampling time selection
    $0c constant ADC3_SMP14                     \ [0x0c : 3] ADC channel 14 sampling time selection
    $0f constant ADC3_SMP15                     \ [0x0f : 3] ADC channel 15 sampling time selection
    $12 constant ADC3_SMP16                     \ [0x12 : 3] ADC channel 16 sampling time selection
    $15 constant ADC3_SMP17                     \ [0x15 : 3] ADC channel 17 sampling time selection
    $18 constant ADC3_SMP18                     \ [0x18 : 3] ADC channel 18 sampling time selection
    $1b constant ADC3_SMP19                     \ [0x1b : 3] ADC channel 18 sampling time selection
  [then]


  [ifdef] ADC3_PCSEL_DEF
    \
    \ @brief ADC pre channel selection register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_PCSEL                     \ [0x00 : 20] Channel x (VINP[i]) pre selection
  [then]


  [ifdef] ADC3_LTR1_DEF
    \
    \ @brief ADC analog watchdog 1 threshold register
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC3_LTR1                      \ [0x00 : 26] ADC analog watchdog 1 threshold low
  [then]


  [ifdef] ADC3_LHTR1_DEF
    \
    \ @brief ADC analog watchdog 2 threshold register
    \ Address offset: 0x24
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC3_LHTR1                     \ [0x00 : 26] ADC analog watchdog 2 threshold low
  [then]


  [ifdef] ADC3_SQR1_DEF
    \
    \ @brief ADC group regular sequencer ranks register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_L3                        \ [0x00 : 4] L3
    $06 constant ADC3_SQ1                       \ [0x06 : 5] ADC group regular sequencer rank 1
    $0c constant ADC3_SQ2                       \ [0x0c : 5] ADC group regular sequencer rank 2
    $12 constant ADC3_SQ3                       \ [0x12 : 5] ADC group regular sequencer rank 3
    $18 constant ADC3_SQ4                       \ [0x18 : 5] ADC group regular sequencer rank 4
  [then]


  [ifdef] ADC3_SQR2_DEF
    \
    \ @brief ADC group regular sequencer ranks register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SQ5                       \ [0x00 : 5] ADC group regular sequencer rank 5
    $06 constant ADC3_SQ6                       \ [0x06 : 5] ADC group regular sequencer rank 6
    $0c constant ADC3_SQ7                       \ [0x0c : 5] ADC group regular sequencer rank 7
    $12 constant ADC3_SQ8                       \ [0x12 : 5] ADC group regular sequencer rank 8
    $18 constant ADC3_SQ9                       \ [0x18 : 5] ADC group regular sequencer rank 9
  [then]


  [ifdef] ADC3_SQR3_DEF
    \
    \ @brief ADC group regular sequencer ranks register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SQ10                      \ [0x00 : 5] ADC group regular sequencer rank 10
    $06 constant ADC3_SQ11                      \ [0x06 : 5] ADC group regular sequencer rank 11
    $0c constant ADC3_SQ12                      \ [0x0c : 5] ADC group regular sequencer rank 12
    $12 constant ADC3_SQ13                      \ [0x12 : 5] ADC group regular sequencer rank 13
    $18 constant ADC3_SQ14                      \ [0x18 : 5] ADC group regular sequencer rank 14
  [then]


  [ifdef] ADC3_SQR4_DEF
    \
    \ @brief ADC group regular sequencer ranks register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SQ15                      \ [0x00 : 5] ADC group regular sequencer rank 15
    $06 constant ADC3_SQ16                      \ [0x06 : 5] ADC group regular sequencer rank 16
  [then]


  [ifdef] ADC3_DR_DEF
    \
    \ @brief ADC group regular conversion data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_RDATA                     \ [0x00 : 16] ADC group regular conversion data
  [then]


  [ifdef] ADC3_JSQR_DEF
    \
    \ @brief ADC group injected sequencer register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JL                        \ [0x00 : 2] ADC group injected sequencer scan length
    $02 constant ADC3_JEXTSEL                   \ [0x02 : 5] ADC group injected external trigger source
    $07 constant ADC3_JEXTEN                    \ [0x07 : 2] ADC group injected external trigger polarity
    $09 constant ADC3_JSQ1                      \ [0x09 : 5] ADC group injected sequencer rank 1
    $0f constant ADC3_JSQ2                      \ [0x0f : 5] ADC group injected sequencer rank 2
    $15 constant ADC3_JSQ3                      \ [0x15 : 5] ADC group injected sequencer rank 3
    $1b constant ADC3_JSQ4                      \ [0x1b : 5] ADC group injected sequencer rank 4
  [then]


  [ifdef] ADC3_OFR1_DEF
    \
    \ @brief ADC offset number 1 register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_OFFSET1                   \ [0x00 : 26] ADC offset number 1 offset level
    $1a constant ADC3_OFFSET1_CH                \ [0x1a : 5] ADC offset number 1 channel selection
    $1f constant ADC3_SSATE                     \ [0x1f] ADC offset number 1 enable
  [then]


  [ifdef] ADC3_OFR2_DEF
    \
    \ @brief ADC offset number 2 register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_OFFSET1                   \ [0x00 : 26] ADC offset number 1 offset level
    $1a constant ADC3_OFFSET1_CH                \ [0x1a : 5] ADC offset number 1 channel selection
    $1f constant ADC3_SSATE                     \ [0x1f] ADC offset number 1 enable
  [then]


  [ifdef] ADC3_OFR3_DEF
    \
    \ @brief ADC offset number 3 register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_OFFSET1                   \ [0x00 : 26] ADC offset number 1 offset level
    $1a constant ADC3_OFFSET1_CH                \ [0x1a : 5] ADC offset number 1 channel selection
    $1f constant ADC3_SSATE                     \ [0x1f] ADC offset number 1 enable
  [then]


  [ifdef] ADC3_OFR4_DEF
    \
    \ @brief ADC offset number 4 register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_OFFSET1                   \ [0x00 : 26] ADC offset number 1 offset level
    $1a constant ADC3_OFFSET1_CH                \ [0x1a : 5] ADC offset number 1 channel selection
    $1f constant ADC3_SSATE                     \ [0x1f] ADC offset number 1 enable
  [then]


  [ifdef] ADC3_JDR1_DEF
    \
    \ @brief ADC group injected sequencer rank 1 register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA1                    \ [0x00 : 32] ADC group injected sequencer rank 1 conversion data
  [then]


  [ifdef] ADC3_JDR2_DEF
    \
    \ @brief ADC group injected sequencer rank 2 register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA2                    \ [0x00 : 32] ADC group injected sequencer rank 2 conversion data
  [then]


  [ifdef] ADC3_JDR3_DEF
    \
    \ @brief ADC group injected sequencer rank 3 register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA3                    \ [0x00 : 32] ADC group injected sequencer rank 3 conversion data
  [then]


  [ifdef] ADC3_JDR4_DEF
    \
    \ @brief ADC group injected sequencer rank 4 register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA4                    \ [0x00 : 32] ADC group injected sequencer rank 4 conversion data
  [then]


  [ifdef] ADC3_AWD2CR_DEF
    \
    \ @brief ADC analog watchdog 2 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_AWD2CH                    \ [0x00 : 20] ADC analog watchdog 2 monitored channel selection
  [then]


  [ifdef] ADC3_AWD3CR_DEF
    \
    \ @brief ADC analog watchdog 3 configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $01 constant ADC3_AWD3CH                    \ [0x01 : 20] ADC analog watchdog 3 monitored channel selection
  [then]


  [ifdef] ADC3_LTR2_DEF
    \
    \ @brief ADC watchdog lower threshold register 2
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_LTR2                      \ [0x00 : 26] Analog watchdog 2 lower threshold
  [then]


  [ifdef] ADC3_HTR2_DEF
    \
    \ @brief ADC watchdog higher threshold register 2
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_HTR2                      \ [0x00 : 26] Analog watchdog 2 higher threshold
  [then]


  [ifdef] ADC3_LTR3_DEF
    \
    \ @brief ADC watchdog lower threshold register 3
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_LTR3                      \ [0x00 : 26] Analog watchdog 3 lower threshold
  [then]


  [ifdef] ADC3_HTR3_DEF
    \
    \ @brief ADC watchdog higher threshold register 3
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_HTR3                      \ [0x00 : 26] Analog watchdog 3 higher threshold
  [then]


  [ifdef] ADC3_DIFSEL_DEF
    \
    \ @brief ADC channel differential or single-ended mode selection register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_DIFSEL                    \ [0x00 : 20] ADC channel differential or single-ended mode for channel
  [then]


  [ifdef] ADC3_CALFACT_DEF
    \
    \ @brief ADC calibration factors register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_CALFACT_S                 \ [0x00 : 11] ADC calibration factor in single-ended mode
    $10 constant ADC3_CALFACT_D                 \ [0x10 : 11] ADC calibration factor in differential mode
  [then]


  [ifdef] ADC3_CALFACT2_DEF
    \
    \ @brief ADC Calibration Factor register 2
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_LINCALFACT                \ [0x00 : 30] Linearity Calibration Factor
  [then]

  \
  \ @brief Analog to Digital Converter
  \
  $00 constant ADC3_ISR                 \ ADC interrupt and status register
  $04 constant ADC3_IER                 \ ADC interrupt enable register
  $08 constant ADC3_CR                  \ ADC control register
  $0C constant ADC3_CFGR                \ ADC configuration register 1
  $10 constant ADC3_CFGR2               \ ADC configuration register 2
  $14 constant ADC3_SMPR1               \ ADC sampling time register 1
  $18 constant ADC3_SMPR2               \ ADC sampling time register 2
  $1C constant ADC3_PCSEL               \ ADC pre channel selection register
  $20 constant ADC3_LTR1                \ ADC analog watchdog 1 threshold register
  $24 constant ADC3_LHTR1               \ ADC analog watchdog 2 threshold register
  $30 constant ADC3_SQR1                \ ADC group regular sequencer ranks register 1
  $34 constant ADC3_SQR2                \ ADC group regular sequencer ranks register 2
  $38 constant ADC3_SQR3                \ ADC group regular sequencer ranks register 3
  $3C constant ADC3_SQR4                \ ADC group regular sequencer ranks register 4
  $40 constant ADC3_DR                  \ ADC group regular conversion data register
  $4C constant ADC3_JSQR                \ ADC group injected sequencer register
  $60 constant ADC3_OFR1                \ ADC offset number 1 register
  $64 constant ADC3_OFR2                \ ADC offset number 2 register
  $68 constant ADC3_OFR3                \ ADC offset number 3 register
  $6C constant ADC3_OFR4                \ ADC offset number 4 register
  $80 constant ADC3_JDR1                \ ADC group injected sequencer rank 1 register
  $84 constant ADC3_JDR2                \ ADC group injected sequencer rank 2 register
  $88 constant ADC3_JDR3                \ ADC group injected sequencer rank 3 register
  $8C constant ADC3_JDR4                \ ADC group injected sequencer rank 4 register
  $A0 constant ADC3_AWD2CR              \ ADC analog watchdog 2 configuration register
  $A4 constant ADC3_AWD3CR              \ ADC analog watchdog 3 configuration register
  $B0 constant ADC3_LTR2                \ ADC watchdog lower threshold register 2
  $B4 constant ADC3_HTR2                \ ADC watchdog higher threshold register 2
  $B8 constant ADC3_LTR3                \ ADC watchdog lower threshold register 3
  $BC constant ADC3_HTR3                \ ADC watchdog higher threshold register 3
  $C0 constant ADC3_DIFSEL              \ ADC channel differential or single-ended mode selection register
  $C4 constant ADC3_CALFACT             \ ADC calibration factors register
  $C8 constant ADC3_CALFACT2            \ ADC Calibration Factor register 2

: ADC3_DEF ; [then]
