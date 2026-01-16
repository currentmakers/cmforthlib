\
\ @file adc.fs
\ @brief ADC
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

$00000001 constant ADC_ADC_ISR_ADRDY                                \ ADRDY
$00000002 constant ADC_ADC_ISR_EOSMP                                \ EOSMP
$00000004 constant ADC_ADC_ISR_EOC                                  \ EOC
$00000008 constant ADC_ADC_ISR_EOS                                  \ EOS
$00000010 constant ADC_ADC_ISR_OVR                                  \ OVR
$00000020 constant ADC_ADC_ISR_JEOC                                 \ JEOC
$00000040 constant ADC_ADC_ISR_JEOS                                 \ JEOS
$00000080 constant ADC_ADC_ISR_AWD1                                 \ AWD1
$00000100 constant ADC_ADC_ISR_AWD2                                 \ AWD2
$00000200 constant ADC_ADC_ISR_AWD3                                 \ AWD3
$00000400 constant ADC_ADC_ISR_JQOVF                                \ JQOVF


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC_ADC_IER_ADRDYIE                              \ ADRDYIE
$00000002 constant ADC_ADC_IER_EOSMPIE                              \ EOSMPIE
$00000004 constant ADC_ADC_IER_EOCIE                                \ EOCIE
$00000008 constant ADC_ADC_IER_EOSIE                                \ EOSIE
$00000010 constant ADC_ADC_IER_OVRIE                                \ OVRIE
$00000020 constant ADC_ADC_IER_JEOCIE                               \ JEOCIE
$00000040 constant ADC_ADC_IER_JEOSIE                               \ JEOSIE
$00000080 constant ADC_ADC_IER_AWD1IE                               \ AWD1IE
$00000100 constant ADC_ADC_IER_AWD2IE                               \ AWD2IE
$00000200 constant ADC_ADC_IER_AWD3IE                               \ AWD3IE
$00000400 constant ADC_ADC_IER_JQOVFIE                              \ JQOVFIE


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x20000000
\

$00000001 constant ADC_ADC_CR_ADEN                                  \ ADEN
$00000002 constant ADC_ADC_CR_ADDIS                                 \ ADDIS
$00000004 constant ADC_ADC_CR_ADSTART                               \ ADSTART
$00000008 constant ADC_ADC_CR_JADSTART                              \ JADSTART
$00000010 constant ADC_ADC_CR_ADSTP                                 \ ADSTP
$00000020 constant ADC_ADC_CR_JADSTP                                \ JADSTP
$00000100 constant ADC_ADC_CR_BOOST                                 \ BOOST
$00010000 constant ADC_ADC_CR_ADCALLIN                              \ ADCALLIN
$00400000 constant ADC_ADC_CR_LINCALRDYW1                           \ LINCALRDYW1
$00800000 constant ADC_ADC_CR_LINCALRDYW2                           \ LINCALRDYW2
$01000000 constant ADC_ADC_CR_LINCALRDYW3                           \ LINCALRDYW3
$02000000 constant ADC_ADC_CR_LINCALRDYW4                           \ LINCALRDYW4
$04000000 constant ADC_ADC_CR_LINCALRDYW5                           \ LINCALRDYW5
$08000000 constant ADC_ADC_CR_LINCALRDYW6                           \ LINCALRDYW6
$10000000 constant ADC_ADC_CR_ADVREGEN                              \ ADVREGEN
$20000000 constant ADC_ADC_CR_DEEPPWD                               \ DEEPPWD
$40000000 constant ADC_ADC_CR_ADCALDIF                              \ ADCALDIF
$80000000 constant ADC_ADC_CR_ADCAL                                 \ ADCAL


\
\ @brief ADC configuration register
\ Address offset: 0x0C
\ Reset value: 0x80000000
\

$00000003 constant ADC_ADC_CFGR_DMNGT                               \ DMNGT
$0000001c constant ADC_ADC_CFGR_RES                                 \ RES
$000003e0 constant ADC_ADC_CFGR_EXTSEL                              \ EXTSEL
$00000c00 constant ADC_ADC_CFGR_EXTEN                               \ EXTEN
$00001000 constant ADC_ADC_CFGR_OVRMOD                              \ OVRMOD
$00002000 constant ADC_ADC_CFGR_CONT                                \ CONT
$00004000 constant ADC_ADC_CFGR_AUTDLY                              \ AUTDLY
$00010000 constant ADC_ADC_CFGR_DISCEN                              \ DISCEN
$000e0000 constant ADC_ADC_CFGR_DISCNUM                             \ DISCNUM
$00100000 constant ADC_ADC_CFGR_JDISCEN                             \ JDISCEN
$00200000 constant ADC_ADC_CFGR_JQM                                 \ JQM
$00400000 constant ADC_ADC_CFGR_AWD1SGL                             \ AWD1SGL
$00800000 constant ADC_ADC_CFGR_AWD1EN                              \ AWD1EN
$01000000 constant ADC_ADC_CFGR_JAWD1EN                             \ JAWD1EN
$02000000 constant ADC_ADC_CFGR_JAUTO                               \ JAUTO
$7c000000 constant ADC_ADC_CFGR_AWD1CH                              \ AWD1CH
$80000000 constant ADC_ADC_CFGR_JQDIS                               \ JQDIS


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC_ADC_CFGR2_ROVSE                              \ ROVSE
$00000002 constant ADC_ADC_CFGR2_JOVSE                              \ JOVSE
$000001e0 constant ADC_ADC_CFGR2_OVSS                               \ OVSS
$00000200 constant ADC_ADC_CFGR2_TROVS                              \ TROVS
$00000400 constant ADC_ADC_CFGR2_ROVSM                              \ ROVSM
$00000800 constant ADC_ADC_CFGR2_RSHIFT1                            \ RSHIFT1
$00001000 constant ADC_ADC_CFGR2_RSHIFT2                            \ RSHIFT2
$00002000 constant ADC_ADC_CFGR2_RSHIFT3                            \ RSHIFT3
$00004000 constant ADC_ADC_CFGR2_RSHIFT4                            \ RSHIFT4
$03ff0000 constant ADC_ADC_CFGR2_OSVR                               \ OSVR
$f0000000 constant ADC_ADC_CFGR2_LSHIFT                             \ LSHIFT


\
\ @brief ADC sample time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC_ADC_SMPR1_SMP0                               \ SMP0
$00000038 constant ADC_ADC_SMPR1_SMP1                               \ SMP1
$000001c0 constant ADC_ADC_SMPR1_SMP2                               \ SMP2
$00000e00 constant ADC_ADC_SMPR1_SMP3                               \ SMP3
$00007000 constant ADC_ADC_SMPR1_SMP4                               \ SMP4
$00038000 constant ADC_ADC_SMPR1_SMP5                               \ SMP5
$001c0000 constant ADC_ADC_SMPR1_SMP6                               \ SMP6
$00e00000 constant ADC_ADC_SMPR1_SMP7                               \ SMP7
$07000000 constant ADC_ADC_SMPR1_SMP8                               \ SMP8
$38000000 constant ADC_ADC_SMPR1_SMP9                               \ SMP9


\
\ @brief ADC sample time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC_ADC_SMPR2_SMP10                              \ SMP10
$00000038 constant ADC_ADC_SMPR2_SMP11                              \ SMP11
$000001c0 constant ADC_ADC_SMPR2_SMP12                              \ SMP12
$00000e00 constant ADC_ADC_SMPR2_SMP13                              \ SMP13
$00007000 constant ADC_ADC_SMPR2_SMP14                              \ SMP14
$00038000 constant ADC_ADC_SMPR2_SMP15                              \ SMP15
$001c0000 constant ADC_ADC_SMPR2_SMP16                              \ SMP16
$00e00000 constant ADC_ADC_SMPR2_SMP17                              \ SMP17
$07000000 constant ADC_ADC_SMPR2_SMP18                              \ SMP18
$38000000 constant ADC_ADC_SMPR2_SMP19                              \ SMP19


\
\ @brief ADC channel preselection register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant ADC_ADC_PCSEL_PCSEL0                             \ PCSEL0
$00000002 constant ADC_ADC_PCSEL_PCSEL1                             \ PCSEL1
$00000004 constant ADC_ADC_PCSEL_PCSEL2                             \ PCSEL2
$00000008 constant ADC_ADC_PCSEL_PCSEL3                             \ PCSEL3
$00000010 constant ADC_ADC_PCSEL_PCSEL4                             \ PCSEL4
$00000020 constant ADC_ADC_PCSEL_PCSEL5                             \ PCSEL5
$00000040 constant ADC_ADC_PCSEL_PCSEL6                             \ PCSEL6
$00000080 constant ADC_ADC_PCSEL_PCSEL7                             \ PCSEL7
$00000100 constant ADC_ADC_PCSEL_PCSEL8                             \ PCSEL8
$00000200 constant ADC_ADC_PCSEL_PCSEL9                             \ PCSEL9
$00000400 constant ADC_ADC_PCSEL_PCSEL10                            \ PCSEL10
$00000800 constant ADC_ADC_PCSEL_PCSEL11                            \ PCSEL11
$00001000 constant ADC_ADC_PCSEL_PCSEL12                            \ PCSEL12
$00002000 constant ADC_ADC_PCSEL_PCSEL13                            \ PCSEL13
$00004000 constant ADC_ADC_PCSEL_PCSEL14                            \ PCSEL14
$00008000 constant ADC_ADC_PCSEL_PCSEL15                            \ PCSEL15
$00010000 constant ADC_ADC_PCSEL_PCSEL16                            \ PCSEL16
$00020000 constant ADC_ADC_PCSEL_PCSEL17                            \ PCSEL17
$00040000 constant ADC_ADC_PCSEL_PCSEL18                            \ PCSEL18
$00080000 constant ADC_ADC_PCSEL_PCSEL19                            \ PCSEL19


\
\ @brief ADC watchdog threshold register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$03ffffff constant ADC_ADC_LTR1_LTR1                                \ LTR1


\
\ @brief ADC watchdog threshold register 1
\ Address offset: 0x24
\ Reset value: 0x03FFFFFF
\

$03ffffff constant ADC_ADC_HTR1_HTR1                                \ HTR1


\
\ @brief ADC regular sequence register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC_ADC_SQR1_L                                   \ L
$000007c0 constant ADC_ADC_SQR1_SQ1                                 \ SQ1
$0001f000 constant ADC_ADC_SQR1_SQ2                                 \ SQ2
$007c0000 constant ADC_ADC_SQR1_SQ3                                 \ SQ3
$1f000000 constant ADC_ADC_SQR1_SQ4                                 \ SQ4


\
\ @brief ADC regular sequence register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC_ADC_SQR2_SQ5                                 \ SQ5
$000007c0 constant ADC_ADC_SQR2_SQ6                                 \ SQ6
$0001f000 constant ADC_ADC_SQR2_SQ7                                 \ SQ7
$007c0000 constant ADC_ADC_SQR2_SQ8                                 \ SQ8
$1f000000 constant ADC_ADC_SQR2_SQ9                                 \ SQ9


\
\ @brief ADC regular sequence register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC_ADC_SQR3_SQ10                                \ SQ10
$000007c0 constant ADC_ADC_SQR3_SQ11                                \ SQ11
$0001f000 constant ADC_ADC_SQR3_SQ12                                \ SQ12
$007c0000 constant ADC_ADC_SQR3_SQ13                                \ SQ13
$1f000000 constant ADC_ADC_SQR3_SQ14                                \ SQ14


\
\ @brief ADC regular sequence register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC_ADC_SQR4_SQ15                                \ SQ15
$000007c0 constant ADC_ADC_SQR4_SQ16                                \ SQ16


\
\ @brief ADC regular Data Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant ADC_ADC_DR_RDATA                                 \ RDATA


\
\ @brief ADC injected sequence register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC_ADC_JSQR_JL                                  \ JL
$0000007c constant ADC_ADC_JSQR_JEXTSEL                             \ JEXTSEL
$00000180 constant ADC_ADC_JSQR_JEXTEN                              \ JEXTEN
$00003e00 constant ADC_ADC_JSQR_JSQ1                                \ JSQ1
$000f8000 constant ADC_ADC_JSQR_JSQ2                                \ JSQ2
$03e00000 constant ADC_ADC_JSQR_JSQ3                                \ JSQ3
$f8000000 constant ADC_ADC_JSQR_JSQ4                                \ JSQ4


\
\ @brief ADC offset register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$03ffffff constant ADC_ADC_OFR1_OFFSET1                             \ OFFSET1
$7c000000 constant ADC_ADC_OFR1_OFFSET1_CH                          \ OFFSET1_CH
$80000000 constant ADC_ADC_OFR1_SSATE                               \ SSATE


\
\ @brief ADC offset register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$03ffffff constant ADC_ADC_OFR2_OFFSET2                             \ OFFSET2
$7c000000 constant ADC_ADC_OFR2_OFFSET2_CH                          \ OFFSET2_CH
$80000000 constant ADC_ADC_OFR2_SSATE                               \ SSATE


\
\ @brief ADC offset register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$03ffffff constant ADC_ADC_OFR3_OFFSET3                             \ OFFSET3
$7c000000 constant ADC_ADC_OFR3_OFFSET3_CH                          \ OFFSET3_CH
$80000000 constant ADC_ADC_OFR3_SSATE                               \ SSATE


\
\ @brief ADC offset register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$03ffffff constant ADC_ADC_OFR4_OFFSET4                             \ OFFSET4
$7c000000 constant ADC_ADC_OFR4_OFFSET4_CH                          \ OFFSET4_CH
$80000000 constant ADC_ADC_OFR4_SSATE                               \ SSATE


\
\ @brief ADC injected data register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant ADC_ADC_JDR1_JDATA                               \ JDATA


\
\ @brief ADC injected data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant ADC_ADC_JDR2_JDATA                               \ JDATA


\
\ @brief ADC injected data register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant ADC_ADC_JDR3_JDATA                               \ JDATA


\
\ @brief ADC injected data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant ADC_ADC_JDR4_JDATA                               \ JDATA


\
\ @brief ADC analog watchdog 2 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000fffff constant ADC_ADC_AWD2CR_AWD2CH                            \ AWD2CH


\
\ @brief ADC analog watchdog 3 configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000fffff constant ADC_ADC_AWD3CR_AWD3CH                            \ AWD3CH


\
\ @brief ADC watchdog lower threshold register 2
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$03ffffff constant ADC_ADC_LTR2_LTR2                                \ LTR2


\
\ @brief ADC watchdog higher threshold register 2
\ Address offset: 0xB4
\ Reset value: 0x03FFFFFF
\

$03ffffff constant ADC_ADC_HTR2_HTR2                                \ HTR2


\
\ @brief ADC watchdog lower threshold register 3
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$03ffffff constant ADC_ADC_LTR3_LTR3                                \ LTR3


\
\ @brief ADC watchdog higher threshold register 3
\ Address offset: 0xBC
\ Reset value: 0x03FFFFFF
\

$03ffffff constant ADC_ADC_HTR3_HTR3                                \ HTR3


\
\ @brief ADC differential mode selection register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$000fffff constant ADC_ADC_DIFSEL_DIFSEL                            \ DIFSEL


\
\ @brief ADC calibration factors register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000007ff constant ADC_ADC_CALFACT_CALFACT_S                        \ CALFACT_S
$07ff0000 constant ADC_ADC_CALFACT_CALFACT_D                        \ CALFACT_D


\
\ @brief ADC calibration factor register 2
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$3fffffff constant ADC_ADC_CALFACT2_LINCALFACT                      \ LINCALFACT


\
\ @brief ADC
\
$48003000 constant ADC_ADC_ISR    \ offset: 0x00 : ADC interrupt and status register
$48003004 constant ADC_ADC_IER    \ offset: 0x04 : ADC interrupt enable register
$48003008 constant ADC_ADC_CR     \ offset: 0x08 : ADC control register
$4800300c constant ADC_ADC_CFGR   \ offset: 0x0C : ADC configuration register
$48003010 constant ADC_ADC_CFGR2  \ offset: 0x10 : ADC configuration register 2
$48003014 constant ADC_ADC_SMPR1  \ offset: 0x14 : ADC sample time register 1
$48003018 constant ADC_ADC_SMPR2  \ offset: 0x18 : ADC sample time register 2
$4800301c constant ADC_ADC_PCSEL  \ offset: 0x1C : ADC channel preselection register
$48003020 constant ADC_ADC_LTR1   \ offset: 0x20 : ADC watchdog threshold register 1
$48003024 constant ADC_ADC_HTR1   \ offset: 0x24 : ADC watchdog threshold register 1
$48003030 constant ADC_ADC_SQR1   \ offset: 0x30 : ADC regular sequence register 1
$48003034 constant ADC_ADC_SQR2   \ offset: 0x34 : ADC regular sequence register 2
$48003038 constant ADC_ADC_SQR3   \ offset: 0x38 : ADC regular sequence register 3
$4800303c constant ADC_ADC_SQR4   \ offset: 0x3C : ADC regular sequence register 4
$48003040 constant ADC_ADC_DR     \ offset: 0x40 : ADC regular Data Register
$4800304c constant ADC_ADC_JSQR   \ offset: 0x4C : ADC injected sequence register
$48003060 constant ADC_ADC_OFR1   \ offset: 0x60 : ADC offset register
$48003064 constant ADC_ADC_OFR2   \ offset: 0x64 : ADC offset register
$48003068 constant ADC_ADC_OFR3   \ offset: 0x68 : ADC offset register
$4800306c constant ADC_ADC_OFR4   \ offset: 0x6C : ADC offset register
$48003080 constant ADC_ADC_JDR1   \ offset: 0x80 : ADC injected data register
$48003084 constant ADC_ADC_JDR2   \ offset: 0x84 : ADC injected data register
$48003088 constant ADC_ADC_JDR3   \ offset: 0x88 : ADC injected data register
$4800308c constant ADC_ADC_JDR4   \ offset: 0x8C : ADC injected data register
$480030a0 constant ADC_ADC_AWD2CR  \ offset: 0xA0 : ADC analog watchdog 2 configuration register
$480030a4 constant ADC_ADC_AWD3CR  \ offset: 0xA4 : ADC analog watchdog 3 configuration register
$480030b0 constant ADC_ADC_LTR2   \ offset: 0xB0 : ADC watchdog lower threshold register 2
$480030b4 constant ADC_ADC_HTR2   \ offset: 0xB4 : ADC watchdog higher threshold register 2
$480030b8 constant ADC_ADC_LTR3   \ offset: 0xB8 : ADC watchdog lower threshold register 3
$480030bc constant ADC_ADC_HTR3   \ offset: 0xBC : ADC watchdog higher threshold register 3
$480030c0 constant ADC_ADC_DIFSEL  \ offset: 0xC0 : ADC differential mode selection register
$480030c4 constant ADC_ADC_CALFACT  \ offset: 0xC4 : ADC calibration factors register
$480030c8 constant ADC_ADC_CALFACT2  \ offset: 0xC8 : ADC calibration factor register 2

