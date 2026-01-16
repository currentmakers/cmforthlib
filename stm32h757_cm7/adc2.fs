\
\ @file adc2.fs
\ @brief Analog to Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ADC interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ADC2_ISR_ADRDY                                   \ ADC ready flag
$00000002 constant ADC2_ISR_EOSMP                                   \ ADC group regular end of sampling flag
$00000004 constant ADC2_ISR_EOC                                     \ ADC group regular end of unitary conversion flag
$00000008 constant ADC2_ISR_EOS                                     \ ADC group regular end of sequence conversions flag
$00000010 constant ADC2_ISR_OVR                                     \ ADC group regular overrun flag
$00000020 constant ADC2_ISR_JEOC                                    \ ADC group injected end of unitary conversion flag
$00000040 constant ADC2_ISR_JEOS                                    \ ADC group injected end of sequence conversions flag
$00000080 constant ADC2_ISR_AWD1                                    \ ADC analog watchdog 1 flag
$00000100 constant ADC2_ISR_AWD2                                    \ ADC analog watchdog 2 flag
$00000200 constant ADC2_ISR_AWD3                                    \ ADC analog watchdog 3 flag
$00000400 constant ADC2_ISR_JQOVF                                   \ ADC group injected contexts queue overflow flag


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC2_IER_ADRDYIE                                 \ ADC ready interrupt
$00000002 constant ADC2_IER_EOSMPIE                                 \ ADC group regular end of sampling interrupt
$00000004 constant ADC2_IER_EOCIE                                   \ ADC group regular end of unitary conversion interrupt
$00000008 constant ADC2_IER_EOSIE                                   \ ADC group regular end of sequence conversions interrupt
$00000010 constant ADC2_IER_OVRIE                                   \ ADC group regular overrun interrupt
$00000020 constant ADC2_IER_JEOCIE                                  \ ADC group injected end of unitary conversion interrupt
$00000040 constant ADC2_IER_JEOSIE                                  \ ADC group injected end of sequence conversions interrupt
$00000080 constant ADC2_IER_AWD1IE                                  \ ADC analog watchdog 1 interrupt
$00000100 constant ADC2_IER_AWD2IE                                  \ ADC analog watchdog 2 interrupt
$00000200 constant ADC2_IER_AWD3IE                                  \ ADC analog watchdog 3 interrupt
$00000400 constant ADC2_IER_JQOVFIE                                 \ ADC group injected contexts queue overflow interrupt


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ADC2_CR_ADEN                                     \ ADC enable
$00000002 constant ADC2_CR_ADDIS                                    \ ADC disable
$00000004 constant ADC2_CR_ADSTART                                  \ ADC group regular conversion start
$00000008 constant ADC2_CR_JADSTART                                 \ ADC group injected conversion start
$00000010 constant ADC2_CR_ADSTP                                    \ ADC group regular conversion stop
$00000020 constant ADC2_CR_JADSTP                                   \ ADC group injected conversion stop
$00000300 constant ADC2_CR_BOOST                                    \ Boost mode control
$00010000 constant ADC2_CR_ADCALLIN                                 \ Linearity calibration
$00400000 constant ADC2_CR_LINCALRDYW1                              \ Linearity calibration ready Word 1
$00800000 constant ADC2_CR_LINCALRDYW2                              \ Linearity calibration ready Word 2
$01000000 constant ADC2_CR_LINCALRDYW3                              \ Linearity calibration ready Word 3
$02000000 constant ADC2_CR_LINCALRDYW4                              \ Linearity calibration ready Word 4
$04000000 constant ADC2_CR_LINCALRDYW5                              \ Linearity calibration ready Word 5
$08000000 constant ADC2_CR_LINCALRDYW6                              \ Linearity calibration ready Word 6
$10000000 constant ADC2_CR_ADVREGEN                                 \ ADC voltage regulator enable
$20000000 constant ADC2_CR_DEEPPWD                                  \ ADC deep power down enable
$40000000 constant ADC2_CR_ADCALDIF                                 \ ADC differential mode for calibration
$80000000 constant ADC2_CR_ADCAL                                    \ ADC calibration


\
\ @brief ADC configuration register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant ADC2_CFGR_DMNGT                                  \ ADC DMA transfer enable
$0000001c constant ADC2_CFGR_RES                                    \ ADC data resolution
$000003e0 constant ADC2_CFGR_EXTSEL                                 \ ADC group regular external trigger source
$00000c00 constant ADC2_CFGR_EXTEN                                  \ ADC group regular external trigger polarity
$00001000 constant ADC2_CFGR_OVRMOD                                 \ ADC group regular overrun configuration
$00002000 constant ADC2_CFGR_CONT                                   \ ADC group regular continuous conversion mode
$00004000 constant ADC2_CFGR_AUTDLY                                 \ ADC low power auto wait
$00010000 constant ADC2_CFGR_DISCEN                                 \ ADC group regular sequencer discontinuous mode
$000e0000 constant ADC2_CFGR_DISCNUM                                \ ADC group regular sequencer discontinuous number of ranks
$00100000 constant ADC2_CFGR_JDISCEN                                \ ADC group injected sequencer discontinuous mode
$00200000 constant ADC2_CFGR_JQM                                    \ ADC group injected contexts queue mode
$00400000 constant ADC2_CFGR_AWD1SGL                                \ ADC analog watchdog 1 monitoring a single channel or all channels
$00800000 constant ADC2_CFGR_AWD1EN                                 \ ADC analog watchdog 1 enable on scope ADC group regular
$01000000 constant ADC2_CFGR_JAWD1EN                                \ ADC analog watchdog 1 enable on scope ADC group injected
$02000000 constant ADC2_CFGR_JAUTO                                  \ ADC group injected automatic trigger mode
$7c000000 constant ADC2_CFGR_AWDCH1CH                               \ ADC analog watchdog 1 monitored channel selection
$80000000 constant ADC2_CFGR_JQDIS                                  \ ADC group injected contexts queue disable


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC2_CFGR2_ROVSE                                 \ ADC oversampler enable on scope ADC group regular
$00000002 constant ADC2_CFGR2_JOVSE                                 \ ADC oversampler enable on scope ADC group injected
$000001e0 constant ADC2_CFGR2_OVSS                                  \ ADC oversampling shift
$00000200 constant ADC2_CFGR2_TROVS                                 \ ADC oversampling discontinuous mode (triggered mode) for ADC group regular
$00000400 constant ADC2_CFGR2_ROVSM                                 \ Regular Oversampling mode
$00000800 constant ADC2_CFGR2_RSHIFT1                               \ Right-shift data after Offset 1 correction
$00001000 constant ADC2_CFGR2_RSHIFT2                               \ Right-shift data after Offset 2 correction
$00002000 constant ADC2_CFGR2_RSHIFT3                               \ Right-shift data after Offset 3 correction
$00004000 constant ADC2_CFGR2_RSHIFT4                               \ Right-shift data after Offset 4 correction
$03ff0000 constant ADC2_CFGR2_OSR                                   \ Oversampling ratio
$f0000000 constant ADC2_CFGR2_LSHIFT                                \ Left shift factor


\
\ @brief ADC sampling time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000038 constant ADC2_SMPR1_SMP1                                  \ ADC channel 1 sampling time selection
$000001c0 constant ADC2_SMPR1_SMP2                                  \ ADC channel 2 sampling time selection
$00000e00 constant ADC2_SMPR1_SMP3                                  \ ADC channel 3 sampling time selection
$00007000 constant ADC2_SMPR1_SMP4                                  \ ADC channel 4 sampling time selection
$00038000 constant ADC2_SMPR1_SMP5                                  \ ADC channel 5 sampling time selection
$001c0000 constant ADC2_SMPR1_SMP6                                  \ ADC channel 6 sampling time selection
$00e00000 constant ADC2_SMPR1_SMP7                                  \ ADC channel 7 sampling time selection
$07000000 constant ADC2_SMPR1_SMP8                                  \ ADC channel 8 sampling time selection
$38000000 constant ADC2_SMPR1_SMP9                                  \ ADC channel 9 sampling time selection


\
\ @brief ADC sampling time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC2_SMPR2_SMP10                                 \ ADC channel 10 sampling time selection
$00000038 constant ADC2_SMPR2_SMP11                                 \ ADC channel 11 sampling time selection
$000001c0 constant ADC2_SMPR2_SMP12                                 \ ADC channel 12 sampling time selection
$00000e00 constant ADC2_SMPR2_SMP13                                 \ ADC channel 13 sampling time selection
$00007000 constant ADC2_SMPR2_SMP14                                 \ ADC channel 14 sampling time selection
$00038000 constant ADC2_SMPR2_SMP15                                 \ ADC channel 15 sampling time selection
$001c0000 constant ADC2_SMPR2_SMP16                                 \ ADC channel 16 sampling time selection
$00e00000 constant ADC2_SMPR2_SMP17                                 \ ADC channel 17 sampling time selection
$07000000 constant ADC2_SMPR2_SMP18                                 \ ADC channel 18 sampling time selection
$38000000 constant ADC2_SMPR2_SMP19                                 \ ADC channel 18 sampling time selection


\
\ @brief ADC pre channel selection register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000fffff constant ADC2_PCSEL_PCSEL                                 \ Channel x (VINP[i]) pre selection


\
\ @brief ADC analog watchdog 1 threshold register
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$03ffffff constant ADC2_LTR1_LTR1                                   \ ADC analog watchdog 1 threshold low


\
\ @brief ADC analog watchdog 2 threshold register
\ Address offset: 0x24
\ Reset value: 0x0FFF0000
\

$03ffffff constant ADC2_LHTR1_LHTR1                                 \ ADC analog watchdog 2 threshold low


\
\ @brief ADC group regular sequencer ranks register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC2_SQR1_L3                                     \ L3
$000007c0 constant ADC2_SQR1_SQ1                                    \ ADC group regular sequencer rank 1
$0001f000 constant ADC2_SQR1_SQ2                                    \ ADC group regular sequencer rank 2
$007c0000 constant ADC2_SQR1_SQ3                                    \ ADC group regular sequencer rank 3
$1f000000 constant ADC2_SQR1_SQ4                                    \ ADC group regular sequencer rank 4


\
\ @brief ADC group regular sequencer ranks register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC2_SQR2_SQ5                                    \ ADC group regular sequencer rank 5
$000007c0 constant ADC2_SQR2_SQ6                                    \ ADC group regular sequencer rank 6
$0001f000 constant ADC2_SQR2_SQ7                                    \ ADC group regular sequencer rank 7
$007c0000 constant ADC2_SQR2_SQ8                                    \ ADC group regular sequencer rank 8
$1f000000 constant ADC2_SQR2_SQ9                                    \ ADC group regular sequencer rank 9


\
\ @brief ADC group regular sequencer ranks register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC2_SQR3_SQ10                                   \ ADC group regular sequencer rank 10
$000007c0 constant ADC2_SQR3_SQ11                                   \ ADC group regular sequencer rank 11
$0001f000 constant ADC2_SQR3_SQ12                                   \ ADC group regular sequencer rank 12
$007c0000 constant ADC2_SQR3_SQ13                                   \ ADC group regular sequencer rank 13
$1f000000 constant ADC2_SQR3_SQ14                                   \ ADC group regular sequencer rank 14


\
\ @brief ADC group regular sequencer ranks register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC2_SQR4_SQ15                                   \ ADC group regular sequencer rank 15
$000007c0 constant ADC2_SQR4_SQ16                                   \ ADC group regular sequencer rank 16


\
\ @brief ADC group regular conversion data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC2_DR_RDATA                                    \ ADC group regular conversion data


\
\ @brief ADC group injected sequencer register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC2_JSQR_JL                                     \ ADC group injected sequencer scan length
$0000007c constant ADC2_JSQR_JEXTSEL                                \ ADC group injected external trigger source
$00000180 constant ADC2_JSQR_JEXTEN                                 \ ADC group injected external trigger polarity
$00003e00 constant ADC2_JSQR_JSQ1                                   \ ADC group injected sequencer rank 1
$000f8000 constant ADC2_JSQR_JSQ2                                   \ ADC group injected sequencer rank 2
$03e00000 constant ADC2_JSQR_JSQ3                                   \ ADC group injected sequencer rank 3
$f8000000 constant ADC2_JSQR_JSQ4                                   \ ADC group injected sequencer rank 4


\
\ @brief ADC offset number 1 register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$03ffffff constant ADC2_OFR1_OFFSET1                                \ ADC offset number 1 offset level
$7c000000 constant ADC2_OFR1_OFFSET1_CH                             \ ADC offset number 1 channel selection
$80000000 constant ADC2_OFR1_SSATE                                  \ ADC offset number 1 enable


\
\ @brief ADC offset number 2 register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$03ffffff constant ADC2_OFR2_OFFSET1                                \ ADC offset number 1 offset level
$7c000000 constant ADC2_OFR2_OFFSET1_CH                             \ ADC offset number 1 channel selection
$80000000 constant ADC2_OFR2_SSATE                                  \ ADC offset number 1 enable


\
\ @brief ADC offset number 3 register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$03ffffff constant ADC2_OFR3_OFFSET1                                \ ADC offset number 1 offset level
$7c000000 constant ADC2_OFR3_OFFSET1_CH                             \ ADC offset number 1 channel selection
$80000000 constant ADC2_OFR3_SSATE                                  \ ADC offset number 1 enable


\
\ @brief ADC offset number 4 register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$03ffffff constant ADC2_OFR4_OFFSET1                                \ ADC offset number 1 offset level
$7c000000 constant ADC2_OFR4_OFFSET1_CH                             \ ADC offset number 1 channel selection
$80000000 constant ADC2_OFR4_SSATE                                  \ ADC offset number 1 enable


\
\ @brief ADC group injected sequencer rank 1 register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant ADC2_JDR1_JDATA1                                 \ ADC group injected sequencer rank 1 conversion data


\
\ @brief ADC group injected sequencer rank 2 register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant ADC2_JDR2_JDATA2                                 \ ADC group injected sequencer rank 2 conversion data


\
\ @brief ADC group injected sequencer rank 3 register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant ADC2_JDR3_JDATA3                                 \ ADC group injected sequencer rank 3 conversion data


\
\ @brief ADC group injected sequencer rank 4 register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant ADC2_JDR4_JDATA4                                 \ ADC group injected sequencer rank 4 conversion data


\
\ @brief ADC analog watchdog 2 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000fffff constant ADC2_AWD2CR_AWD2CH                               \ ADC analog watchdog 2 monitored channel selection


\
\ @brief ADC analog watchdog 3 configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$001ffffe constant ADC2_AWD3CR_AWD3CH                               \ ADC analog watchdog 3 monitored channel selection


\
\ @brief ADC watchdog lower threshold register 2
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$03ffffff constant ADC2_LTR2_LTR2                                   \ Analog watchdog 2 lower threshold


\
\ @brief ADC watchdog higher threshold register 2
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$03ffffff constant ADC2_HTR2_HTR2                                   \ Analog watchdog 2 higher threshold


\
\ @brief ADC watchdog lower threshold register 3
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$03ffffff constant ADC2_LTR3_LTR3                                   \ Analog watchdog 3 lower threshold


\
\ @brief ADC watchdog higher threshold register 3
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$03ffffff constant ADC2_HTR3_HTR3                                   \ Analog watchdog 3 higher threshold


\
\ @brief ADC channel differential or single-ended mode selection register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$000fffff constant ADC2_DIFSEL_DIFSEL                               \ ADC channel differential or single-ended mode for channel


\
\ @brief ADC calibration factors register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000007ff constant ADC2_CALFACT_CALFACT_S                           \ ADC calibration factor in single-ended mode
$07ff0000 constant ADC2_CALFACT_CALFACT_D                           \ ADC calibration factor in differential mode


\
\ @brief ADC Calibration Factor register 2
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$3fffffff constant ADC2_CALFACT2_LINCALFACT                         \ Linearity Calibration Factor


\
\ @brief Analog to Digital Converter
\
$40022100 constant ADC2_ISR       \ offset: 0x00 : ADC interrupt and status register
$40022104 constant ADC2_IER       \ offset: 0x04 : ADC interrupt enable register
$40022108 constant ADC2_CR        \ offset: 0x08 : ADC control register
$4002210c constant ADC2_CFGR      \ offset: 0x0C : ADC configuration register 1
$40022110 constant ADC2_CFGR2     \ offset: 0x10 : ADC configuration register 2
$40022114 constant ADC2_SMPR1     \ offset: 0x14 : ADC sampling time register 1
$40022118 constant ADC2_SMPR2     \ offset: 0x18 : ADC sampling time register 2
$4002211c constant ADC2_PCSEL     \ offset: 0x1C : ADC pre channel selection register
$40022120 constant ADC2_LTR1      \ offset: 0x20 : ADC analog watchdog 1 threshold register
$40022124 constant ADC2_LHTR1     \ offset: 0x24 : ADC analog watchdog 2 threshold register
$40022130 constant ADC2_SQR1      \ offset: 0x30 : ADC group regular sequencer ranks register 1
$40022134 constant ADC2_SQR2      \ offset: 0x34 : ADC group regular sequencer ranks register 2
$40022138 constant ADC2_SQR3      \ offset: 0x38 : ADC group regular sequencer ranks register 3
$4002213c constant ADC2_SQR4      \ offset: 0x3C : ADC group regular sequencer ranks register 4
$40022140 constant ADC2_DR        \ offset: 0x40 : ADC group regular conversion data register
$4002214c constant ADC2_JSQR      \ offset: 0x4C : ADC group injected sequencer register
$40022160 constant ADC2_OFR1      \ offset: 0x60 : ADC offset number 1 register
$40022164 constant ADC2_OFR2      \ offset: 0x64 : ADC offset number 2 register
$40022168 constant ADC2_OFR3      \ offset: 0x68 : ADC offset number 3 register
$4002216c constant ADC2_OFR4      \ offset: 0x6C : ADC offset number 4 register
$40022180 constant ADC2_JDR1      \ offset: 0x80 : ADC group injected sequencer rank 1 register
$40022184 constant ADC2_JDR2      \ offset: 0x84 : ADC group injected sequencer rank 2 register
$40022188 constant ADC2_JDR3      \ offset: 0x88 : ADC group injected sequencer rank 3 register
$4002218c constant ADC2_JDR4      \ offset: 0x8C : ADC group injected sequencer rank 4 register
$400221a0 constant ADC2_AWD2CR    \ offset: 0xA0 : ADC analog watchdog 2 configuration register
$400221a4 constant ADC2_AWD3CR    \ offset: 0xA4 : ADC analog watchdog 3 configuration register
$400221b0 constant ADC2_LTR2      \ offset: 0xB0 : ADC watchdog lower threshold register 2
$400221b4 constant ADC2_HTR2      \ offset: 0xB4 : ADC watchdog higher threshold register 2
$400221b8 constant ADC2_LTR3      \ offset: 0xB8 : ADC watchdog lower threshold register 3
$400221bc constant ADC2_HTR3      \ offset: 0xBC : ADC watchdog higher threshold register 3
$400221c0 constant ADC2_DIFSEL    \ offset: 0xC0 : ADC channel differential or single-ended mode selection register
$400221c4 constant ADC2_CALFACT   \ offset: 0xC4 : ADC calibration factors register
$400221c8 constant ADC2_CALFACT2  \ offset: 0xC8 : ADC Calibration Factor register 2

