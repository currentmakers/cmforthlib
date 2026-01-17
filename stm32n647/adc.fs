\
\ @file adc.fs
\ @brief Analog-to-digital converters
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC_DEF

  [ifdef] ADC_ADC_ISR_DEF
    \
    \ @brief ADC interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDY                      \ [0x00] ADC ready
    $01 constant ADC_EOSMP                      \ [0x01] End of sampling flag
    $02 constant ADC_EOC                        \ [0x02] End of conversion flag
    $03 constant ADC_EOS                        \ [0x03] End of regular sequence flag
    $04 constant ADC_OVR                        \ [0x04] ADC overrun
    $05 constant ADC_JEOC                       \ [0x05] Injected channel end of conversion flag
    $06 constant ADC_JEOS                       \ [0x06] Injected channel end of sequence flag
    $07 constant ADC_AWD1                       \ [0x07] Analog watchdog 1 flag
    $08 constant ADC_AWD2                       \ [0x08] Analog watchdog 2 flag
    $09 constant ADC_AWD3                       \ [0x09] Analog watchdog 3 flag
    $0a constant ADC_JQOVF                      \ [0x0a] Injected context queue overflow
  [then]


  [ifdef] ADC_ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDYIE                    \ [0x00] ADC ready interrupt enable
    $01 constant ADC_EOSMPIE                    \ [0x01] End of sampling flag interrupt enable for regular conversions
    $02 constant ADC_EOCIE                      \ [0x02] End of regular conversion interrupt enable
    $03 constant ADC_EOSIE                      \ [0x03] End of regular sequence of conversions interrupt enable
    $04 constant ADC_OVRIE                      \ [0x04] Overrun interrupt enable
    $05 constant ADC_JEOCIE                     \ [0x05] End of injected conversion interrupt enable
    $06 constant ADC_JEOSIE                     \ [0x06] End of injected sequence of conversions interrupt enable
    $07 constant ADC_AWD1IE                     \ [0x07] Analog watchdog 1 interrupt enable
    $08 constant ADC_AWD2IE                     \ [0x08] Analog watchdog 2 interrupt enable
    $09 constant ADC_AWD3IE                     \ [0x09] Analog watchdog 3 interrupt enable
    $0a constant ADC_JQOVFIE                    \ [0x0a] Injected context queue overflow interrupt enable
  [then]


  [ifdef] ADC_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x20000000
    \
    $00 constant ADC_ADEN                       \ [0x00] ADC enable control
    $01 constant ADC_ADDIS                      \ [0x01] ADC disable command
    $02 constant ADC_ADSTART                    \ [0x02] ADC start of regular conversion
    $03 constant ADC_JADSTART                   \ [0x03] ADC start of injected conversion
    $04 constant ADC_ADSTP                      \ [0x04] ADC stop of regular conversion command
    $05 constant ADC_JADSTP                     \ [0x05] ADC stop of injected conversion command
    $1d constant ADC_DEEPPWD                    \ [0x1d] Deep-power-down enable
    $1e constant ADC_ADCALDIF                   \ [0x1e] Differential mode for calibration
    $1f constant ADC_ADCAL                      \ [0x1f] ADC calibration
  [then]


  [ifdef] ADC_ADC_CFGR1_DEF
    \
    \ @brief ADC configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DMNGT                      \ [0x00 : 2] Data management configuration
    $02 constant ADC_RES                        \ [0x02 : 2] Data resolution
    $05 constant ADC_EXTSEL                     \ [0x05 : 5] External trigger selection for regular group
    $0a constant ADC_EXTEN                      \ [0x0a : 2] External trigger enable and polarity selection for regular channels
    $0c constant ADC_OVRMOD                     \ [0x0c] Overrun mode
    $0d constant ADC_CONT                       \ [0x0d] Single / Continuous conversion mode for regular conversions
    $0e constant ADC_AUTDLY                     \ [0x0e] Delayed conversion mode
    $10 constant ADC_DISCEN                     \ [0x10] Discontinuous mode for regular channels
    $11 constant ADC_DISCNUM                    \ [0x11 : 3] Discontinuous mode channel count
    $14 constant ADC_JDISCEN                    \ [0x14] Discontinuous mode on injected channels
    $15 constant ADC_JQM                        \ [0x15] JSQR queue mode
    $16 constant ADC_AWD1SGL                    \ [0x16] Enable the watchdog 1 on a single channel or on all channels
    $17 constant ADC_AWD1EN                     \ [0x17] Analog watchdog 1 enable on regular channels
    $18 constant ADC_JAWD1EN                    \ [0x18] Analog watchdog 1 enable on injected channels
    $19 constant ADC_JAUTO                      \ [0x19] Automatic injected group conversion
    $1a constant ADC_AWD1CH                     \ [0x1a : 5] Analog watchdog 1 channel selection
    $1f constant ADC_JQDIS                      \ [0x1f] Injected queue disable
  [then]


  [ifdef] ADC_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ROVSE                      \ [0x00] Regular oversampling enable
    $01 constant ADC_JOVSE                      \ [0x01] Injected oversampling enable
    $05 constant ADC_OVSS                       \ [0x05 : 4] Oversampling shift
    $09 constant ADC_TROVS                      \ [0x09] Triggered regular oversampling
    $0a constant ADC_ROVSM                      \ [0x0a] Regular oversampling mode
    $0d constant ADC_BULB                       \ [0x0d] Bulb sampling mode
    $0e constant ADC_SWTRIG                     \ [0x0e] Software trigger bit for sampling time control trigger mode
    $0f constant ADC_SMPTRIG                    \ [0x0f] Sampling time control trigger mode
    $10 constant ADC_OSR                        \ [0x10 : 10] Oversampling ratio
    $1c constant ADC_LSHIFT                     \ [0x1c : 4] Left shift factor
  [then]


  [ifdef] ADC_ADC_SMPR1_DEF
    \
    \ @brief ADC sample time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP0                       \ [0x00 : 3] Channel x sampling time selection
    $03 constant ADC_SMP1                       \ [0x03 : 3] Channel x sampling time selection
    $06 constant ADC_SMP2                       \ [0x06 : 3] Channel x sampling time selection
    $09 constant ADC_SMP3                       \ [0x09 : 3] Channel x sampling time selection
    $0c constant ADC_SMP4                       \ [0x0c : 3] Channel x sampling time selection
    $0f constant ADC_SMP5                       \ [0x0f : 3] Channel x sampling time selection
    $12 constant ADC_SMP6                       \ [0x12 : 3] Channel x sampling time selection
    $15 constant ADC_SMP7                       \ [0x15 : 3] Channel x sampling time selection
    $18 constant ADC_SMP8                       \ [0x18 : 3] Channel x sampling time selection
    $1b constant ADC_SMP9                       \ [0x1b : 3] Channel x sampling time selection
  [then]


  [ifdef] ADC_ADC_SMPR2_DEF
    \
    \ @brief ADC sample time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP10                      \ [0x00 : 3] Channel x sampling time selection
    $03 constant ADC_SMP11                      \ [0x03 : 3] Channel x sampling time selection
    $06 constant ADC_SMP12                      \ [0x06 : 3] Channel x sampling time selection
    $09 constant ADC_SMP13                      \ [0x09 : 3] Channel x sampling time selection
    $0c constant ADC_SMP14                      \ [0x0c : 3] Channel x sampling time selection
    $0f constant ADC_SMP15                      \ [0x0f : 3] Channel x sampling time selection
    $12 constant ADC_SMP16                      \ [0x12 : 3] Channel x sampling time selection
    $15 constant ADC_SMP17                      \ [0x15 : 3] Channel x sampling time selection
    $18 constant ADC_SMP18                      \ [0x18 : 3] Channel x sampling time selection
    $1b constant ADC_SMP19                      \ [0x1b : 3] Channel x sampling time selection
  [then]


  [ifdef] ADC_ADC_PCSEL_DEF
    \
    \ @brief ADC channel preselection register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_PCSEL                      \ [0x00 : 20] Channel i (Vless thansub>INPless than/sub>[i]) preselection
  [then]


  [ifdef] ADC_ADC_SQR1_DEF
    \
    \ @brief ADC regular sequence register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC_L                          \ [0x00 : 4] Regular channel sequence length
    $06 constant ADC_SQ1                        \ [0x06 : 5] 1st conversion in regular sequence
    $0c constant ADC_SQ2                        \ [0x0c : 5] 2nd conversion in regular sequence
    $12 constant ADC_SQ3                        \ [0x12 : 5] 3rd conversion in regular sequence
    $18 constant ADC_SQ4                        \ [0x18 : 5] 4th conversion in regular sequence
  [then]


  [ifdef] ADC_ADC_SQR2_DEF
    \
    \ @brief ADC regular sequence register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ5                        \ [0x00 : 5] 5th conversion in regular sequence
    $06 constant ADC_SQ6                        \ [0x06 : 5] 6th conversion in regular sequence
    $0c constant ADC_SQ7                        \ [0x0c : 5] 7th conversion in regular sequence
    $12 constant ADC_SQ8                        \ [0x12 : 5] 8th conversion in regular sequence
    $18 constant ADC_SQ9                        \ [0x18 : 5] 9th conversion in regular sequence
  [then]


  [ifdef] ADC_ADC_SQR3_DEF
    \
    \ @brief ADC regular sequence register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ10                       \ [0x00 : 5] 10th conversion in regular sequence
    $06 constant ADC_SQ11                       \ [0x06 : 5] 11th conversion in regular sequence
    $0c constant ADC_SQ12                       \ [0x0c : 5] 12th conversion in regular sequence
    $12 constant ADC_SQ13                       \ [0x12 : 5] 13th conversion in regular sequence
    $18 constant ADC_SQ14                       \ [0x18 : 5] 14th conversion in regular sequence
  [then]


  [ifdef] ADC_ADC_SQR4_DEF
    \
    \ @brief ADC regular sequence register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ15                       \ [0x00 : 5] 15th conversion in regular sequence
    $06 constant ADC_SQ16                       \ [0x06 : 5] 16th conversion in regular sequence
  [then]


  [ifdef] ADC_ADC_DR_DEF
    \
    \ @brief ADC regular data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_RDATA                      \ [0x00 : 32] Regular data converted
  [then]


  [ifdef] ADC_ADC_JSQR_DEF
    \
    \ @brief ADC injected sequence register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JL                         \ [0x00 : 2] Injected channel sequence length
    $02 constant ADC_JEXTSEL                    \ [0x02 : 5] External trigger selection for injected group
    $07 constant ADC_JEXTEN                     \ [0x07 : 2] External trigger enable and polarity selection for injected channels
    $09 constant ADC_JSQ1                       \ [0x09 : 5] 1st conversion in the injected sequence
    $0f constant ADC_JSQ2                       \ [0x0f : 5] 2nd conversion in the injected sequence
    $15 constant ADC_JSQ3                       \ [0x15 : 5] 3rd conversion in the injected sequence
    $1b constant ADC_JSQ4                       \ [0x1b : 5] 4th conversion in the injected sequence
  [then]


  [ifdef] ADC_ADC_OFCFGR1_DEF
    \
    \ @brief ADC offset 1 configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $18 constant ADC_POSOFF                     \ [0x18] Positive offset enable
    $19 constant ADC_USAT                       \ [0x19] Unsigned saturation enable
    $1a constant ADC_SSAT                       \ [0x1a] Signed saturation enable
    $1b constant ADC_OFFSET_CH                  \ [0x1b : 5] Channel selection for the data offset y
  [then]


  [ifdef] ADC_ADC_OFCFGR2_DEF
    \
    \ @brief ADC offset 2 configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $18 constant ADC_POSOFF                     \ [0x18] Positive offset enable
    $19 constant ADC_USAT                       \ [0x19] Unsigned saturation enable
    $1a constant ADC_SSAT                       \ [0x1a] Signed saturation enable
    $1b constant ADC_OFFSET_CH                  \ [0x1b : 5] Channel selection for the data offset y
  [then]


  [ifdef] ADC_ADC_OFCFGR3_DEF
    \
    \ @brief ADC offset 3 configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $18 constant ADC_POSOFF                     \ [0x18] Positive offset enable
    $19 constant ADC_USAT                       \ [0x19] Unsigned saturation enable
    $1a constant ADC_SSAT                       \ [0x1a] Signed saturation enable
    $1b constant ADC_OFFSET_CH                  \ [0x1b : 5] Channel selection for the data offset y
  [then]


  [ifdef] ADC_ADC_OFCFGR4_DEF
    \
    \ @brief ADC offset 4 configuration register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $18 constant ADC_POSOFF                     \ [0x18] Positive offset enable
    $19 constant ADC_USAT                       \ [0x19] Unsigned saturation enable
    $1a constant ADC_SSAT                       \ [0x1a] Signed saturation enable
    $1b constant ADC_OFFSET_CH                  \ [0x1b : 5] Channel selection for the data offset y
  [then]


  [ifdef] ADC_ADC_OFR1_DEF
    \
    \ @brief ADC offset 1 register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET                     \ [0x00 : 22] Data offset y for the channel programmed into OFFSETy_CH[4:0] bits
  [then]


  [ifdef] ADC_ADC_OFR2_DEF
    \
    \ @brief ADC offset 2 register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET                     \ [0x00 : 22] Data offset y for the channel programmed into OFFSETy_CH[4:0] bits
  [then]


  [ifdef] ADC_ADC_OFR3_DEF
    \
    \ @brief ADC offset 3 register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET                     \ [0x00 : 22] Data offset y for the channel programmed into OFFSETy_CH[4:0] bits
  [then]


  [ifdef] ADC_ADC_OFR4_DEF
    \
    \ @brief ADC offset 4 register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET                     \ [0x00 : 22] Data offset y for the channel programmed into OFFSETy_CH[4:0] bits
  [then]


  [ifdef] ADC_ADC_GCOMP_DEF
    \
    \ @brief ADC gain compensation register
    \ Address offset: 0x70
    \ Reset value: 0x00001000
    \
    $00 constant ADC_GCOMPCOEFF                 \ [0x00 : 14] Gain compensation coefficient
    $1f constant ADC_GCOMP                      \ [0x1f] Gain compensation mode
  [then]


  [ifdef] ADC_ADC_JDR1_DEF
    \
    \ @brief ADC injected channel 1 data register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] Injected data
  [then]


  [ifdef] ADC_ADC_JDR2_DEF
    \
    \ @brief ADC injected channel 2 data register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] Injected data
  [then]


  [ifdef] ADC_ADC_JDR3_DEF
    \
    \ @brief ADC injected channel 3 data register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] Injected data
  [then]


  [ifdef] ADC_ADC_JDR4_DEF
    \
    \ @brief ADC injected channel 4 data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] Injected data
  [then]


  [ifdef] ADC_ADC_AWD2CR_DEF
    \
    \ @brief ADC Analog Watchdog 2 Configuration Register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD2CH                     \ [0x00 : 20] Analog watchdog 2 channel selection
  [then]


  [ifdef] ADC_ADC_AWD3CR_DEF
    \
    \ @brief ADC Analog Watchdog 3 Configuration Register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD3CH                     \ [0x00 : 20] Analog watchdog 3 channel selection
  [then]


  [ifdef] ADC_ADC_AWD1LTR_DEF
    \
    \ @brief ADC analog watchdog 1 lower threshold register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LTR                        \ [0x00 : 23] Analog watchdog 1 lower threshold
  [then]


  [ifdef] ADC_ADC_AWD1HTR_DEF
    \
    \ @brief ADC analog watchdog 1 higher threshold register
    \ Address offset: 0xAC
    \ Reset value: 0x003FFFFF
    \
    $00 constant ADC_HTR                        \ [0x00 : 23] Analog watchdog 1 higher threshold
    $1d constant ADC_AWDFILT                    \ [0x1d : 3] Analog watchdog filtering parameter
  [then]


  [ifdef] ADC_ADC_AWD2LTR_DEF
    \
    \ @brief ADC analog watchdog 2 lower threshold register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LTR                        \ [0x00 : 23] Analog watchdog 2 lower threshold
  [then]


  [ifdef] ADC_ADC_AWD2HTR_DEF
    \
    \ @brief ADC analog watchdog 2 higher threshold register
    \ Address offset: 0xB4
    \ Reset value: 0x003FFFFF
    \
    $00 constant ADC_HTR                        \ [0x00 : 23] Analog watchdog 2 higher threshold
  [then]


  [ifdef] ADC_ADC_AWD3LTR_DEF
    \
    \ @brief ADC analog watchdog 3 lower threshold register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LTR                        \ [0x00 : 23] Analog watchdog 3 lower threshold
  [then]


  [ifdef] ADC_ADC_AWD3HTR_DEF
    \
    \ @brief ADC analog watchdog 3 higher threshold register
    \ Address offset: 0xBC
    \ Reset value: 0x003FFFFF
    \
    $00 constant ADC_HTR                        \ [0x00 : 23] Analog watchdog 3 higher threshold
  [then]


  [ifdef] ADC_ADC_DIFSEL_DEF
    \
    \ @brief ADC Differential mode selection register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DIFSEL                     \ [0x00 : 20] Differential mode for channels 19 to 0.
  [then]


  [ifdef] ADC_ADC_CALFACT_DEF
    \
    \ @brief ADC calibration factors
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT_S                  \ [0x00 : 9] Calibration factors In Single-ended mode
    $10 constant ADC_CALFACT_D                  \ [0x10 : 9] Calibration factors in Differential mode
    $1f constant ADC_CALADDOS                   \ [0x1f] Calibration additional offset
  [then]


  [ifdef] ADC_ADC_OR_DEF
    \
    \ @brief ADC option register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SELREF                     \ [0x00] Internal reference voltage selection
    $01 constant ADC_SELBG                      \ [0x01] Bandgap selection
    $02 constant ADC_VDDCOREEN                  \ [0x02] VDDCORE enable
  [then]

  \
  \ @brief Analog-to-digital converters
  \
  $00 constant ADC_ADC_ISR              \ ADC interrupt and status register
  $04 constant ADC_ADC_IER              \ ADC interrupt enable register
  $08 constant ADC_ADC_CR               \ ADC control register
  $0C constant ADC_ADC_CFGR1            \ ADC configuration register
  $10 constant ADC_ADC_CFGR2            \ ADC configuration register 2
  $14 constant ADC_ADC_SMPR1            \ ADC sample time register 1
  $18 constant ADC_ADC_SMPR2            \ ADC sample time register 2
  $1C constant ADC_ADC_PCSEL            \ ADC channel preselection register
  $30 constant ADC_ADC_SQR1             \ ADC regular sequence register 1
  $34 constant ADC_ADC_SQR2             \ ADC regular sequence register 2
  $38 constant ADC_ADC_SQR3             \ ADC regular sequence register 3
  $3C constant ADC_ADC_SQR4             \ ADC regular sequence register 4
  $40 constant ADC_ADC_DR               \ ADC regular data register
  $4C constant ADC_ADC_JSQR             \ ADC injected sequence register
  $50 constant ADC_ADC_OFCFGR1          \ ADC offset 1 configuration register
  $54 constant ADC_ADC_OFCFGR2          \ ADC offset 2 configuration register
  $58 constant ADC_ADC_OFCFGR3          \ ADC offset 3 configuration register
  $5C constant ADC_ADC_OFCFGR4          \ ADC offset 4 configuration register
  $60 constant ADC_ADC_OFR1             \ ADC offset 1 register
  $64 constant ADC_ADC_OFR2             \ ADC offset 2 register
  $68 constant ADC_ADC_OFR3             \ ADC offset 3 register
  $6C constant ADC_ADC_OFR4             \ ADC offset 4 register
  $70 constant ADC_ADC_GCOMP            \ ADC gain compensation register
  $80 constant ADC_ADC_JDR1             \ ADC injected channel 1 data register
  $84 constant ADC_ADC_JDR2             \ ADC injected channel 2 data register
  $88 constant ADC_ADC_JDR3             \ ADC injected channel 3 data register
  $8C constant ADC_ADC_JDR4             \ ADC injected channel 4 data register
  $A0 constant ADC_ADC_AWD2CR           \ ADC Analog Watchdog 2 Configuration Register
  $A4 constant ADC_ADC_AWD3CR           \ ADC Analog Watchdog 3 Configuration Register
  $A8 constant ADC_ADC_AWD1LTR          \ ADC analog watchdog 1 lower threshold register
  $AC constant ADC_ADC_AWD1HTR          \ ADC analog watchdog 1 higher threshold register
  $B0 constant ADC_ADC_AWD2LTR          \ ADC analog watchdog 2 lower threshold register
  $B4 constant ADC_ADC_AWD2HTR          \ ADC analog watchdog 2 higher threshold register
  $B8 constant ADC_ADC_AWD3LTR          \ ADC analog watchdog 3 lower threshold register
  $BC constant ADC_ADC_AWD3HTR          \ ADC analog watchdog 3 higher threshold register
  $C0 constant ADC_ADC_DIFSEL           \ ADC Differential mode selection register
  $C4 constant ADC_ADC_CALFACT          \ ADC calibration factors
  $D0 constant ADC_ADC_OR               \ ADC option register

: ADC_DEF ; [then]
