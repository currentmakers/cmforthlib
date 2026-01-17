\
\ @file adc.fs
\ @brief Analog to digital converter
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


  [ifdef] ADC_IER_DEF
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


  [ifdef] ADC_CR_DEF
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
    $05 constant ADC_JADST                      \ [0x05] ADC stop of injected conversion command
    $1c constant ADC_ADVREGEN                   \ [0x1c : 2] ADC voltage regulator enable
    $1e constant ADC_ADCALDIF                   \ [0x1e] Differential mode for calibration
    $1f constant ADC_ADCAL                      \ [0x1f] ADC calibration
  [then]


  [ifdef] ADC_CFGR_DEF
    \
    \ @brief ADC configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DMAEN                      \ [0x00] Direct memory access enable
    $01 constant ADC_DMACFG                     \ [0x01] Direct memory access configuration
    $03 constant ADC_RES                        \ [0x03 : 2] Data resolution
    $05 constant ADC_ALIGN                      \ [0x05] Data alignment
    $06 constant ADC_EXTSEL                     \ [0x06 : 4] External trigger selection for regular group
    $0a constant ADC_EXTEN                      \ [0x0a : 2] External trigger enable and polarity selection for regular channels
    $0c constant ADC_OVRMOD                     \ [0x0c] Overrun Mode
    $0d constant ADC_CONT                       \ [0x0d] Single / continuous conversion mode for regular conversions
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
  [then]


  [ifdef] ADC_SMPR1_DEF
    \
    \ @brief ADC sample time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $03 constant ADC_SMP1                       \ [0x03 : 3] Channel 1 sampling time selection
    $06 constant ADC_SMP2                       \ [0x06 : 3] Channel 2 sampling time selection
    $09 constant ADC_SMP3                       \ [0x09 : 3] Channel 3 sampling time selection
    $0c constant ADC_SMP4                       \ [0x0c : 3] Channel 4 sampling time selection
    $0f constant ADC_SMP5                       \ [0x0f : 3] Channel 5 sampling time selection
    $12 constant ADC_SMP6                       \ [0x12 : 3] Channel 6 sampling time selection
    $15 constant ADC_SMP7                       \ [0x15 : 3] Channel 7 sampling time selection
    $18 constant ADC_SMP8                       \ [0x18 : 3] Channel 8 sampling time selection
    $1b constant ADC_SMP9                       \ [0x1b : 3] Channel 9 sampling time selection
  [then]


  [ifdef] ADC_SMPR2_DEF
    \
    \ @brief ADC sample time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP10                      \ [0x00 : 3] Channel 10 sampling time selection
    $03 constant ADC_SMP11                      \ [0x03 : 3] Channel 11 sampling time selection
    $06 constant ADC_SMP12                      \ [0x06 : 3] Channel 12 sampling time selection
    $09 constant ADC_SMP13                      \ [0x09 : 3] Channel 13 sampling time selection
    $0c constant ADC_SMP14                      \ [0x0c : 3] Channel 14 sampling time selection
    $0f constant ADC_SMP15                      \ [0x0f : 3] Channel 15 sampling time selection
    $12 constant ADC_SMP16                      \ [0x12 : 3] Channel 16 sampling time selection
    $15 constant ADC_SMP17                      \ [0x15 : 3] Channel 17 sampling time selection
    $18 constant ADC_SMP18                      \ [0x18 : 3] Channel 18 sampling time selection
  [then]


  [ifdef] ADC_TR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT1                        \ [0x00 : 12] Analog watchdog 1 lower threshold
    $10 constant ADC_HT1                        \ [0x10 : 12] Analog watchdog 1 higher threshold
  [then]


  [ifdef] ADC_TR2_DEF
    \
    \ @brief ADC watchdog threshold register 2
    \ Address offset: 0x24
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT2                        \ [0x00 : 8] Analog watchdog 2 lower threshold
    $10 constant ADC_HT2                        \ [0x10 : 8] Analog watchdog 2 higher threshold
  [then]


  [ifdef] ADC_TR3_DEF
    \
    \ @brief read-write
    \ Address offset: 0x28
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT3                        \ [0x00 : 8] Analog watchdog 3 lower threshold
    $10 constant ADC_HT3                        \ [0x10 : 8] Analog watchdog 3 higher threshold
  [then]


  [ifdef] ADC_SQR1_DEF
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


  [ifdef] ADC_SQR2_DEF
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


  [ifdef] ADC_SQR3_DEF
    \
    \ @brief ADC regular sequence register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ10                       \ [0x00 : 5] 10th conversion in regular sequence
    $06 constant ADC_SQ11                       \ [0x06 : 5] 11th conversion in regular sequence
    $0c constant ADC_SQ12                       \ [0x0c : 5] 13th conversion in regular sequence
    $12 constant ADC_SQ13                       \ [0x12 : 5] 13th conversion in regular sequence
    $18 constant ADC_SQ14                       \ [0x18 : 5] 14th conversion in regular sequence
  [then]


  [ifdef] ADC_SQR4_DEF
    \
    \ @brief ADC regular sequence register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ15                       \ [0x00 : 5] 15th conversion in regular sequence
    $06 constant ADC_SQ16                       \ [0x06 : 5] 16th conversion in regular sequence
  [then]


  [ifdef] ADC_DR_DEF
    \
    \ @brief ADC regular Data Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_RDATA                      \ [0x00 : 16] Regular Data converted
  [then]


  [ifdef] ADC_JSQR_DEF
    \
    \ @brief ADC injected sequence register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JL                         \ [0x00 : 2] Injected channel sequence length
    $02 constant ADC_JEXTSEL                    \ [0x02 : 4] External Trigger Selection for injected group
    $06 constant ADC_JEXTEN                     \ [0x06 : 2] External Trigger Enable and Polarity Selection for injected channels
    $08 constant ADC_JSQ1                       \ [0x08 : 5] 1st conversion in the injected sequence
    $0e constant ADC_JSQ2                       \ [0x0e : 5] 2nd conversion in the injected sequence
    $14 constant ADC_JSQ3                       \ [0x14 : 5] 3rd conversion in the injected sequence
    $1a constant ADC_JSQ4                       \ [0x1a : 5] 4th conversion in the injected sequence
  [then]


  [ifdef] ADC_OFR1_DEF
    \
    \ @brief ADC offset register1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET1                    \ [0x00 : 12] Data offset 1 for the channel programmed into bits OFFSET1_CH
    $1a constant ADC_OFFSET1_CH                 \ [0x1a : 5] Channel selection for the Data offset 1
    $1f constant ADC_OFFSET1_EN                 \ [0x1f] Offset1 Enable
  [then]


  [ifdef] ADC_OFR2_DEF
    \
    \ @brief ADC offset register2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET2                    \ [0x00 : 12] Data offset 2 for the channel programmed into bits OFFSET2_CH
    $1a constant ADC_OFFSET2_CH                 \ [0x1a : 5] Channel selection for the Data offset 2
    $1f constant ADC_OFFSET2_EN                 \ [0x1f] Offset 2 Enable
  [then]


  [ifdef] ADC_OFR3_DEF
    \
    \ @brief ADC offset register3
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET3                    \ [0x00 : 12] Data offset 3 for the channel programmed into bits OFFSET3_CH
    $1a constant ADC_OFFSET3_CH                 \ [0x1a : 5] Channel selection for the Data offset 3
    $1f constant ADC_OFFSET3_EN                 \ [0x1f] Offset y Enable
  [then]


  [ifdef] ADC_OFR4_DEF
    \
    \ @brief ADC offset register4
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET4                    \ [0x00 : 12] Data offset 4 for the channel programmed into bits OFFSET4_CH
    $1a constant ADC_OFFSET4_CH                 \ [0x1a : 5] Channel selection for the Data offset 4
    $1f constant ADC_OFFSET4_EN                 \ [0x1f] Offset 4 Enable
  [then]


  [ifdef] ADC_JDR1_DEF
    \
    \ @brief ADC offset register1
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC_JDR2_DEF
    \
    \ @brief ADC offset register2
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC_JDR3_DEF
    \
    \ @brief ADC offset register3
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC_JDR4_DEF
    \
    \ @brief ADC offset register4
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC_AWD2CR_DEF
    \
    \ @brief ADC Analog Watchdog 2 Configuration Register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $01 constant ADC_AWD2CH                     \ [0x01 : 18] Analog watchdog 2 channel selection
  [then]


  [ifdef] ADC_AWD3CR_DEF
    \
    \ @brief ADC Analog Watchdog 3 Configuration Register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $01 constant ADC_AWD3CH                     \ [0x01 : 18] Analog watchdog 3 channel selection
  [then]


  [ifdef] ADC_DIFSEL_DEF
    \
    \ @brief ADC Differential Mode Selection Register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $01 constant ADC_DIFSEL                     \ [0x01 : 18] Differential mode for channels 15 to 1
  [then]


  [ifdef] ADC_CALFACT_DEF
    \
    \ @brief ADC Calibration Factors
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT_S                  \ [0x00 : 7] Calibration Factors In Single-Ended mode
    $10 constant ADC_CALFACT_D                  \ [0x10 : 7] Calibration Factors in differential mode
  [then]


  [ifdef] ADC_CSR_DEF
    \
    \ @brief ADC Common status register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDY_MST                  \ [0x00] Master ADC ready
    $01 constant ADC_EOSMP_MST                  \ [0x01] End of Sampling phase flag of the master ADC
    $02 constant ADC_EOC_MST                    \ [0x02] End of regular conversion of the master ADC
    $03 constant ADC_EOS_MST                    \ [0x03] End of regular sequence flag of the master ADC
    $04 constant ADC_OVR_MST                    \ [0x04] Overrun flag of the master ADC
    $05 constant ADC_JEOC_MST                   \ [0x05] End of injected conversion flag of the master ADC
    $06 constant ADC_JEOS_MST                   \ [0x06] End of injected sequence flag of the master ADC
    $07 constant ADC_AWD1_MST                   \ [0x07] Analog watchdog 1 flag of the master ADC
    $08 constant ADC_AWD2_MST                   \ [0x08] Analog watchdog 2 flag of the master ADC
    $09 constant ADC_AWD3_MST                   \ [0x09] Analog watchdog 3 flag of the master ADC
    $0a constant ADC_JQOVF_MST                  \ [0x0a] Injected Context Queue Overflow flag of the master ADC
    $10 constant ADC_ADRDY_SLV                  \ [0x10] Slave ADC ready
    $11 constant ADC_EOSMP_SLV                  \ [0x11] End of Sampling phase flag of the slave ADC
    $12 constant ADC_EOC_SLV                    \ [0x12] End of regular conversion of the slave ADC
    $13 constant ADC_EOS_SLV                    \ [0x13] End of regular sequence flag of the slave ADC
    $14 constant ADC_OVR_SLV                    \ [0x14] Overrun flag of the slave ADC
    $15 constant ADC_JEOC_SLV                   \ [0x15] End of injected conversion flag of the slave ADC
    $16 constant ADC_JEOS_SLV                   \ [0x16] End of injected sequence flag of the slave ADC
    $17 constant ADC_AWD1_SLV                   \ [0x17] Analog watchdog 1 flag of the slave ADC
    $18 constant ADC_AWD2_SLV                   \ [0x18] Analog watchdog 2 flag of the slave ADC
    $19 constant ADC_AWD3_SLV                   \ [0x19] Analog watchdog 3 flag of the slave ADC
    $1a constant ADC_JQOVF_SLV                  \ [0x1a] Injected Context Queue Overflow flag of the slave ADC
  [then]


  [ifdef] ADC_CRR_DEF
    \
    \ @brief ADC common control register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $10 constant ADC_CKMODE                     \ [0x10 : 2] ADC clock mode
    $16 constant ADC_VREFEN                     \ [0x16] VREFINT enable
    $17 constant ADC_TSEN                       \ [0x17] Temperature sensor enable
    $18 constant ADC_VBATEN                     \ [0x18] VBATEN
  [then]

  \
  \ @brief Analog to digital converter
  \
  $00 constant ADC_ISR                  \ ADC interrupt and status register
  $04 constant ADC_IER                  \ ADC interrupt enable register
  $08 constant ADC_CR                   \ ADC control register
  $0C constant ADC_CFGR                 \ ADC configuration register
  $14 constant ADC_SMPR1                \ ADC sample time register 1
  $18 constant ADC_SMPR2                \ ADC sample time register 2
  $20 constant ADC_TR1                  \ ADC watchdog threshold register 1
  $24 constant ADC_TR2                  \ ADC watchdog threshold register 2
  $28 constant ADC_TR3                  \ read-write
  $30 constant ADC_SQR1                 \ ADC regular sequence register 1
  $34 constant ADC_SQR2                 \ ADC regular sequence register 2
  $38 constant ADC_SQR3                 \ ADC regular sequence register 3
  $3C constant ADC_SQR4                 \ ADC regular sequence register 4
  $40 constant ADC_DR                   \ ADC regular Data Register
  $4C constant ADC_JSQR                 \ ADC injected sequence register
  $60 constant ADC_OFR1                 \ ADC offset register1
  $64 constant ADC_OFR2                 \ ADC offset register2
  $68 constant ADC_OFR3                 \ ADC offset register3
  $6C constant ADC_OFR4                 \ ADC offset register4
  $80 constant ADC_JDR1                 \ ADC offset register1
  $84 constant ADC_JDR2                 \ ADC offset register2
  $88 constant ADC_JDR3                 \ ADC offset register3
  $8C constant ADC_JDR4                 \ ADC offset register4
  $A0 constant ADC_AWD2CR               \ ADC Analog Watchdog 2 Configuration Register
  $A4 constant ADC_AWD3CR               \ ADC Analog Watchdog 3 Configuration Register
  $B0 constant ADC_DIFSEL               \ ADC Differential Mode Selection Register
  $B4 constant ADC_CALFACT              \ ADC Calibration Factors
  $300 constant ADC_CSR                 \ ADC Common status register
  $308 constant ADC_CRR                 \ ADC common control register

: ADC_DEF ; [then]
