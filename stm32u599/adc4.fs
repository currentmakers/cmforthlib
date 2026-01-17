\
\ @file adc4.fs
\ @brief ADC4
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC4_DEF

  [ifdef] ADC4_ADC_ISR_DEF
    \
    \ @brief ADC interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_ADRDY                     \ [0x00] ADRDY
    $01 constant ADC4_EOSMP                     \ [0x01] EOSMP
    $02 constant ADC4_EOC                       \ [0x02] EOC
    $03 constant ADC4_EOS                       \ [0x03] EOS
    $04 constant ADC4_OVR                       \ [0x04] OVR
    $07 constant ADC4_AWD1                      \ [0x07] AWD1
    $08 constant ADC4_AWD2                      \ [0x08] AWD2
    $09 constant ADC4_AWD3                      \ [0x09] AWD3
    $0b constant ADC4_EOCAL                     \ [0x0b] EOCAL
    $0c constant ADC4_LDORDY                    \ [0x0c] LDORDY
  [then]


  [ifdef] ADC4_ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_ADRDYIE                   \ [0x00] ADRDYIE
    $01 constant ADC4_EOSMPIE                   \ [0x01] EOSMPIE
    $02 constant ADC4_EOCIE                     \ [0x02] EOCIE
    $03 constant ADC4_EOSIE                     \ [0x03] EOSIE
    $04 constant ADC4_OVRIE                     \ [0x04] OVRIE
    $07 constant ADC4_AWD1IE                    \ [0x07] AWD1IE
    $08 constant ADC4_AWD2IE                    \ [0x08] AWD2IE
    $09 constant ADC4_AWD3IE                    \ [0x09] AWD3IE
    $0b constant ADC4_EOCALIE                   \ [0x0b] EOCALIE
    $0c constant ADC4_LDORDYIE                  \ [0x0c] LDORDYIE
  [then]


  [ifdef] ADC4_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_ADEN                      \ [0x00] ADEN
    $01 constant ADC4_ADDIS                     \ [0x01] ADDIS
    $02 constant ADC4_ADSTART                   \ [0x02] ADSTART
    $04 constant ADC4_ADSTP                     \ [0x04] ADSTP
    $1c constant ADC4_ADVREGEN                  \ [0x1c] ADVREGEN
    $1f constant ADC4_ADCAL                     \ [0x1f] ADCAL
  [then]


  [ifdef] ADC4_ADC_CFGR1_DEF
    \
    \ @brief ADC configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_DMAEN                     \ [0x00] DMAEN
    $01 constant ADC4_DMACFG                    \ [0x01] DMACFG
    $02 constant ADC4_RES                       \ [0x02 : 2] RES
    $04 constant ADC4_SCANDIR                   \ [0x04] SCANDIR
    $05 constant ADC4_ALIGN                     \ [0x05] ALIGN
    $06 constant ADC4_EXTSEL                    \ [0x06 : 3] EXTSEL
    $0a constant ADC4_EXTEN                     \ [0x0a : 2] EXTEN
    $0c constant ADC4_OVRMOD                    \ [0x0c] OVRMOD
    $0d constant ADC4_CONT                      \ [0x0d] CONT
    $0e constant ADC4_WAIT                      \ [0x0e] WAIT
    $10 constant ADC4_DISCEN                    \ [0x10] DISCEN
    $15 constant ADC4_CHSELRMOD                 \ [0x15] CHSELRMOD
    $16 constant ADC4_AWD1SGL                   \ [0x16] AWD1SGL
    $17 constant ADC4_AWD1EN                    \ [0x17] AWD1EN
    $1a constant ADC4_AWD1CH                    \ [0x1a : 5] AWD1CH
  [then]


  [ifdef] ADC4_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_OVSE                      \ [0x00] OVSE
    $02 constant ADC4_OVSR                      \ [0x02 : 3] OVSR
    $05 constant ADC4_OVSS                      \ [0x05 : 4] OVSS
    $09 constant ADC4_TOVS                      \ [0x09] TOVS
    $1d constant ADC4_LFTRIG                    \ [0x1d] LFTRIG
  [then]


  [ifdef] ADC4_ADC_SMPR_DEF
    \
    \ @brief ADC sample time register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_SMP1                      \ [0x00 : 3] SMP1
    $04 constant ADC4_SMP2                      \ [0x04 : 3] SMP2
    $08 constant ADC4_SMPSEL0                   \ [0x08] SMPSEL0
    $09 constant ADC4_SMPSEL1                   \ [0x09] SMPSEL1
    $0a constant ADC4_SMPSEL2                   \ [0x0a] SMPSEL2
    $0b constant ADC4_SMPSEL3                   \ [0x0b] SMPSEL3
    $0c constant ADC4_SMPSEL4                   \ [0x0c] SMPSEL4
    $0d constant ADC4_SMPSEL5                   \ [0x0d] SMPSEL5
    $0e constant ADC4_SMPSEL6                   \ [0x0e] SMPSEL6
    $0f constant ADC4_SMPSEL7                   \ [0x0f] SMPSEL7
    $10 constant ADC4_SMPSEL8                   \ [0x10] SMPSEL8
    $11 constant ADC4_SMPSEL9                   \ [0x11] SMPSEL9
    $12 constant ADC4_SMPSEL10                  \ [0x12] SMPSEL10
    $13 constant ADC4_SMPSEL11                  \ [0x13] SMPSEL11
    $14 constant ADC4_SMPSEL12                  \ [0x14] SMPSEL12
    $15 constant ADC4_SMPSEL13                  \ [0x15] SMPSEL13
    $16 constant ADC4_SMPSEL14                  \ [0x16] SMPSEL14
    $17 constant ADC4_SMPSEL15                  \ [0x17] SMPSEL15
    $18 constant ADC4_SMPSEL16                  \ [0x18] SMPSEL16
    $19 constant ADC4_SMPSEL17                  \ [0x19] SMPSEL17
    $1a constant ADC4_SMPSEL18                  \ [0x1a] SMPSEL18
    $1b constant ADC4_SMPSEL19                  \ [0x1b] SMPSEL19
    $1c constant ADC4_SMPSEL20                  \ [0x1c] SMPSEL20
    $1d constant ADC4_SMPSEL21                  \ [0x1d] SMPSEL21
    $1e constant ADC4_SMPSEL22                  \ [0x1e] SMPSEL22
    $1f constant ADC4_SMPSEL23                  \ [0x1f] SMPSEL23
  [then]


  [ifdef] ADC4_ADC_AWD1TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC4_LT1                       \ [0x00 : 12] LT1
    $10 constant ADC4_HT1                       \ [0x10 : 12] HT1
  [then]


  [ifdef] ADC4_ADC_AWD2TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x24
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC4_LT2                       \ [0x00 : 12] LT2
    $10 constant ADC4_HT2                       \ [0x10 : 12] HT2
  [then]


  [ifdef] ADC4_ADC_CHSELRMOD0_DEF
    \
    \ @brief ADC channel selection register [alternate]
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_CHSEL                     \ [0x00 : 24] CHSEL
  [then]


  [ifdef] ADC4_ADC_CHSELRMOD1_DEF
    \
    \ @brief ADC channel selection register [alternate]
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_SQ1                       \ [0x00 : 4] SQ1
    $04 constant ADC4_SQ2                       \ [0x04 : 4] SQ2
    $08 constant ADC4_SQ3                       \ [0x08 : 4] SQ3
    $0c constant ADC4_SQ4                       \ [0x0c : 4] SQ4
    $10 constant ADC4_SQ5                       \ [0x10 : 4] SQ5
    $14 constant ADC4_SQ6                       \ [0x14 : 4] SQ6
    $18 constant ADC4_SQ7                       \ [0x18 : 4] SQ7
    $1c constant ADC4_SQ8                       \ [0x1c : 4] SQ8
  [then]


  [ifdef] ADC4_ADC_AWD3TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x2C
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC4_LT3                       \ [0x00 : 12] LT3
    $10 constant ADC4_HT3                       \ [0x10 : 12] HT3
  [then]


  [ifdef] ADC4_ADC_DR_DEF
    \
    \ @brief ADC data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_DATA                      \ [0x00 : 16] DATA
  [then]


  [ifdef] ADC4_ADC_PWR_DEF
    \
    \ @brief ADC data register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_AUTOFF                    \ [0x00] AUTOFF
    $01 constant ADC4_DPD                       \ [0x01] DPD
    $02 constant ADC4_VREFPROT                  \ [0x02] VREFPROT
    $03 constant ADC4_VREFSECSMP                \ [0x03] VREFSECSMP
  [then]


  [ifdef] ADC4_ADC_AWD2CR_DEF
    \
    \ @brief ADC Analog Watchdog 2 Configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_AWD2CH0                   \ [0x00] AWD2CH0
    $01 constant ADC4_AWD2CH1                   \ [0x01] AWD2CH1
    $02 constant ADC4_AWD2CH2                   \ [0x02] AWD2CH2
    $03 constant ADC4_AWD2CH3                   \ [0x03] AWD2CH3
    $04 constant ADC4_AWD2CH4                   \ [0x04] AWD2CH4
    $05 constant ADC4_AWD2CH5                   \ [0x05] AWD2CH5
    $06 constant ADC4_AWD2CH6                   \ [0x06] AWD2CH6
    $07 constant ADC4_AWD2CH7                   \ [0x07] AWD2CH7
    $08 constant ADC4_AWD2CH8                   \ [0x08] AWD2CH8
    $09 constant ADC4_AWD2CH9                   \ [0x09] AWD2CH9
    $0a constant ADC4_AWD2CH10                  \ [0x0a] AWD2CH10
    $0b constant ADC4_AWD2CH11                  \ [0x0b] AWD2CH11
    $0c constant ADC4_AWD2CH12                  \ [0x0c] AWD2CH12
    $0d constant ADC4_AWD2CH13                  \ [0x0d] AWD2CH13
    $0e constant ADC4_AWD2CH14                  \ [0x0e] AWD2CH14
    $0f constant ADC4_AWD2CH15                  \ [0x0f] AWD2CH15
    $10 constant ADC4_AWD2CH16                  \ [0x10] AWD2CH16
    $11 constant ADC4_AWD2CH17                  \ [0x11] AWD2CH17
    $12 constant ADC4_AWD2CH18                  \ [0x12] AWD2CH18
    $13 constant ADC4_AWD2CH19                  \ [0x13] AWD2CH19
    $14 constant ADC4_AWD2CH20                  \ [0x14] AWD2CH20
    $15 constant ADC4_AWD2CH21                  \ [0x15] AWD2CH21
    $16 constant ADC4_AWD2CH22                  \ [0x16] AWD2CH22
    $17 constant ADC4_AWD2CH23                  \ [0x17] AWD2CH23
  [then]


  [ifdef] ADC4_ADC_AWD3CR_DEF
    \
    \ @brief ADC Analog Watchdog 3 Configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_AWD3CH0                   \ [0x00] AWD3CH0
    $01 constant ADC4_AWD3CH1                   \ [0x01] AWD3CH1
    $02 constant ADC4_AWD3CH2                   \ [0x02] AWD3CH2
    $03 constant ADC4_AWD3CH3                   \ [0x03] AWD3CH3
    $04 constant ADC4_AWD3CH4                   \ [0x04] AWD3CH4
    $05 constant ADC4_AWD3CH5                   \ [0x05] AWD3CH5
    $06 constant ADC4_AWD3CH6                   \ [0x06] AWD3CH6
    $07 constant ADC4_AWD3CH7                   \ [0x07] AWD3CH7
    $08 constant ADC4_AWD3CH8                   \ [0x08] AWD3CH8
    $09 constant ADC4_AWD3CH9                   \ [0x09] AWD3CH9
    $0a constant ADC4_AWD3CH10                  \ [0x0a] AWD3CH10
    $0b constant ADC4_AWD3CH11                  \ [0x0b] AWD3CH11
    $0c constant ADC4_AWD3CH12                  \ [0x0c] AWD3CH12
    $0d constant ADC4_AWD3CH13                  \ [0x0d] AWD3CH13
    $0e constant ADC4_AWD3CH14                  \ [0x0e] AWD3CH14
    $0f constant ADC4_AWD3CH15                  \ [0x0f] AWD3CH15
    $10 constant ADC4_AWD3CH16                  \ [0x10] AWD3CH16
    $11 constant ADC4_AWD3CH17                  \ [0x11] AWD3CH17
    $12 constant ADC4_AWD3CH18                  \ [0x12] AWD3CH18
    $13 constant ADC4_AWD3CH19                  \ [0x13] AWD3CH19
    $14 constant ADC4_AWD3CH20                  \ [0x14] AWD3CH20
    $15 constant ADC4_AWD3CH21                  \ [0x15] AWD3CH21
    $16 constant ADC4_AWD3CH22                  \ [0x16] AWD3CH22
    $17 constant ADC4_AWD3CH23                  \ [0x17] AWD3CH23
  [then]


  [ifdef] ADC4_ADC_CALFACT_DEF
    \
    \ @brief ADC Calibration factor
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_CALFACT                   \ [0x00 : 7] CALFACT
  [then]


  [ifdef] ADC4_ADC_OR_DEF
    \
    \ @brief ADC option register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant ADC4_CHN21SEL                  \ [0x00] CHN21SEL
  [then]


  [ifdef] ADC4_ADC_CCR_DEF
    \
    \ @brief ADC common configuration register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $12 constant ADC4_PRESC                     \ [0x12 : 4] PRESC
    $16 constant ADC4_VREFEN                    \ [0x16] VREFEN
    $17 constant ADC4_TSEN                      \ [0x17] TSEN
    $18 constant ADC4_VBATEN                    \ [0x18] VBATEN
  [then]

  \
  \ @brief ADC4
  \
  $00 constant ADC4_ADC_ISR             \ ADC interrupt and status register
  $04 constant ADC4_ADC_IER             \ ADC interrupt enable register
  $08 constant ADC4_ADC_CR              \ ADC control register
  $0C constant ADC4_ADC_CFGR1           \ ADC configuration register
  $10 constant ADC4_ADC_CFGR2           \ ADC configuration register 2
  $14 constant ADC4_ADC_SMPR            \ ADC sample time register
  $20 constant ADC4_ADC_AWD1TR          \ ADC watchdog threshold register
  $24 constant ADC4_ADC_AWD2TR          \ ADC watchdog threshold register
  $28 constant ADC4_ADC_CHSELRMOD0      \ ADC channel selection register [alternate]
  $28 constant ADC4_ADC_CHSELRMOD1      \ ADC channel selection register [alternate]
  $2C constant ADC4_ADC_AWD3TR          \ ADC watchdog threshold register
  $40 constant ADC4_ADC_DR              \ ADC data register
  $44 constant ADC4_ADC_PWR             \ ADC data register
  $A0 constant ADC4_ADC_AWD2CR          \ ADC Analog Watchdog 2 Configuration register
  $A4 constant ADC4_ADC_AWD3CR          \ ADC Analog Watchdog 3 Configuration register
  $B4 constant ADC4_ADC_CALFACT         \ ADC Calibration factor
  $D0 constant ADC4_ADC_OR              \ ADC option register
  $308 constant ADC4_ADC_CCR            \ ADC common configuration register

: ADC4_DEF ; [then]
