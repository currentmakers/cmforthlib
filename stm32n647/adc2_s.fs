\
\ @file adc2_s.fs
\ @brief Analog-to-digital converters
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

$00000001 constant ADC2_S_ADC_ISR_ADRDY                             \ ADC ready
$00000002 constant ADC2_S_ADC_ISR_EOSMP                             \ End of sampling flag
$00000004 constant ADC2_S_ADC_ISR_EOC                               \ End of conversion flag
$00000008 constant ADC2_S_ADC_ISR_EOS                               \ End of regular sequence flag
$00000010 constant ADC2_S_ADC_ISR_OVR                               \ ADC overrun
$00000020 constant ADC2_S_ADC_ISR_JEOC                              \ Injected channel end of conversion flag
$00000040 constant ADC2_S_ADC_ISR_JEOS                              \ Injected channel end of sequence flag
$00000080 constant ADC2_S_ADC_ISR_AWD1                              \ Analog watchdog 1 flag
$00000100 constant ADC2_S_ADC_ISR_AWD2                              \ Analog watchdog 2 flag
$00000200 constant ADC2_S_ADC_ISR_AWD3                              \ Analog watchdog 3 flag
$00000400 constant ADC2_S_ADC_ISR_JQOVF                             \ Injected context queue overflow


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC2_S_ADC_IER_ADRDYIE                           \ ADC ready interrupt enable
$00000002 constant ADC2_S_ADC_IER_EOSMPIE                           \ End of sampling flag interrupt enable for regular conversions
$00000004 constant ADC2_S_ADC_IER_EOCIE                             \ End of regular conversion interrupt enable
$00000008 constant ADC2_S_ADC_IER_EOSIE                             \ End of regular sequence of conversions interrupt enable
$00000010 constant ADC2_S_ADC_IER_OVRIE                             \ Overrun interrupt enable
$00000020 constant ADC2_S_ADC_IER_JEOCIE                            \ End of injected conversion interrupt enable
$00000040 constant ADC2_S_ADC_IER_JEOSIE                            \ End of injected sequence of conversions interrupt enable
$00000080 constant ADC2_S_ADC_IER_AWD1IE                            \ Analog watchdog 1 interrupt enable
$00000100 constant ADC2_S_ADC_IER_AWD2IE                            \ Analog watchdog 2 interrupt enable
$00000200 constant ADC2_S_ADC_IER_AWD3IE                            \ Analog watchdog 3 interrupt enable
$00000400 constant ADC2_S_ADC_IER_JQOVFIE                           \ Injected context queue overflow interrupt enable


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x20000000
\

$00000001 constant ADC2_S_ADC_CR_ADEN                               \ ADC enable control
$00000002 constant ADC2_S_ADC_CR_ADDIS                              \ ADC disable command
$00000004 constant ADC2_S_ADC_CR_ADSTART                            \ ADC start of regular conversion
$00000008 constant ADC2_S_ADC_CR_JADSTART                           \ ADC start of injected conversion
$00000010 constant ADC2_S_ADC_CR_ADSTP                              \ ADC stop of regular conversion command
$00000020 constant ADC2_S_ADC_CR_JADSTP                             \ ADC stop of injected conversion command
$20000000 constant ADC2_S_ADC_CR_DEEPPWD                            \ Deep-power-down enable
$40000000 constant ADC2_S_ADC_CR_ADCALDIF                           \ Differential mode for calibration
$80000000 constant ADC2_S_ADC_CR_ADCAL                              \ ADC calibration


\
\ @brief ADC configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant ADC2_S_ADC_CFGR1_DMNGT                           \ Data management configuration
$0000000c constant ADC2_S_ADC_CFGR1_RES                             \ Data resolution
$000003e0 constant ADC2_S_ADC_CFGR1_EXTSEL                          \ External trigger selection for regular group
$00000c00 constant ADC2_S_ADC_CFGR1_EXTEN                           \ External trigger enable and polarity selection for regular channels
$00001000 constant ADC2_S_ADC_CFGR1_OVRMOD                          \ Overrun mode
$00002000 constant ADC2_S_ADC_CFGR1_CONT                            \ Single / Continuous conversion mode for regular conversions
$00004000 constant ADC2_S_ADC_CFGR1_AUTDLY                          \ Delayed conversion mode
$00010000 constant ADC2_S_ADC_CFGR1_DISCEN                          \ Discontinuous mode for regular channels
$000e0000 constant ADC2_S_ADC_CFGR1_DISCNUM                         \ Discontinuous mode channel count
$00100000 constant ADC2_S_ADC_CFGR1_JDISCEN                         \ Discontinuous mode on injected channels
$00200000 constant ADC2_S_ADC_CFGR1_JQM                             \ JSQR queue mode
$00400000 constant ADC2_S_ADC_CFGR1_AWD1SGL                         \ Enable the watchdog 1 on a single channel or on all channels
$00800000 constant ADC2_S_ADC_CFGR1_AWD1EN                          \ Analog watchdog 1 enable on regular channels
$01000000 constant ADC2_S_ADC_CFGR1_JAWD1EN                         \ Analog watchdog 1 enable on injected channels
$02000000 constant ADC2_S_ADC_CFGR1_JAUTO                           \ Automatic injected group conversion
$7c000000 constant ADC2_S_ADC_CFGR1_AWD1CH                          \ Analog watchdog 1 channel selection
$80000000 constant ADC2_S_ADC_CFGR1_JQDIS                           \ Injected queue disable


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC2_S_ADC_CFGR2_ROVSE                           \ Regular oversampling enable
$00000002 constant ADC2_S_ADC_CFGR2_JOVSE                           \ Injected oversampling enable
$000001e0 constant ADC2_S_ADC_CFGR2_OVSS                            \ Oversampling shift
$00000200 constant ADC2_S_ADC_CFGR2_TROVS                           \ Triggered regular oversampling
$00000400 constant ADC2_S_ADC_CFGR2_ROVSM                           \ Regular oversampling mode
$00002000 constant ADC2_S_ADC_CFGR2_BULB                            \ Bulb sampling mode
$00004000 constant ADC2_S_ADC_CFGR2_SWTRIG                          \ Software trigger bit for sampling time control trigger mode
$00008000 constant ADC2_S_ADC_CFGR2_SMPTRIG                         \ Sampling time control trigger mode
$03ff0000 constant ADC2_S_ADC_CFGR2_OSR                             \ Oversampling ratio
$f0000000 constant ADC2_S_ADC_CFGR2_LSHIFT                          \ Left shift factor


\
\ @brief ADC sample time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC2_S_ADC_SMPR1_SMP0                            \ Channel x sampling time selection
$00000038 constant ADC2_S_ADC_SMPR1_SMP1                            \ Channel x sampling time selection
$000001c0 constant ADC2_S_ADC_SMPR1_SMP2                            \ Channel x sampling time selection
$00000e00 constant ADC2_S_ADC_SMPR1_SMP3                            \ Channel x sampling time selection
$00007000 constant ADC2_S_ADC_SMPR1_SMP4                            \ Channel x sampling time selection
$00038000 constant ADC2_S_ADC_SMPR1_SMP5                            \ Channel x sampling time selection
$001c0000 constant ADC2_S_ADC_SMPR1_SMP6                            \ Channel x sampling time selection
$00e00000 constant ADC2_S_ADC_SMPR1_SMP7                            \ Channel x sampling time selection
$07000000 constant ADC2_S_ADC_SMPR1_SMP8                            \ Channel x sampling time selection
$38000000 constant ADC2_S_ADC_SMPR1_SMP9                            \ Channel x sampling time selection


\
\ @brief ADC sample time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC2_S_ADC_SMPR2_SMP10                           \ Channel x sampling time selection
$00000038 constant ADC2_S_ADC_SMPR2_SMP11                           \ Channel x sampling time selection
$000001c0 constant ADC2_S_ADC_SMPR2_SMP12                           \ Channel x sampling time selection
$00000e00 constant ADC2_S_ADC_SMPR2_SMP13                           \ Channel x sampling time selection
$00007000 constant ADC2_S_ADC_SMPR2_SMP14                           \ Channel x sampling time selection
$00038000 constant ADC2_S_ADC_SMPR2_SMP15                           \ Channel x sampling time selection
$001c0000 constant ADC2_S_ADC_SMPR2_SMP16                           \ Channel x sampling time selection
$00e00000 constant ADC2_S_ADC_SMPR2_SMP17                           \ Channel x sampling time selection
$07000000 constant ADC2_S_ADC_SMPR2_SMP18                           \ Channel x sampling time selection
$38000000 constant ADC2_S_ADC_SMPR2_SMP19                           \ Channel x sampling time selection


\
\ @brief ADC channel preselection register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000fffff constant ADC2_S_ADC_PCSEL_PCSEL                           \ Channel i (Vless thansub>INPless than/sub>[i]) preselection


\
\ @brief ADC regular sequence register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC2_S_ADC_SQR1_L                                \ Regular channel sequence length
$000007c0 constant ADC2_S_ADC_SQR1_SQ1                              \ 1st conversion in regular sequence
$0001f000 constant ADC2_S_ADC_SQR1_SQ2                              \ 2nd conversion in regular sequence
$007c0000 constant ADC2_S_ADC_SQR1_SQ3                              \ 3rd conversion in regular sequence
$1f000000 constant ADC2_S_ADC_SQR1_SQ4                              \ 4th conversion in regular sequence


\
\ @brief ADC regular sequence register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC2_S_ADC_SQR2_SQ5                              \ 5th conversion in regular sequence
$000007c0 constant ADC2_S_ADC_SQR2_SQ6                              \ 6th conversion in regular sequence
$0001f000 constant ADC2_S_ADC_SQR2_SQ7                              \ 7th conversion in regular sequence
$007c0000 constant ADC2_S_ADC_SQR2_SQ8                              \ 8th conversion in regular sequence
$1f000000 constant ADC2_S_ADC_SQR2_SQ9                              \ 9th conversion in regular sequence


\
\ @brief ADC regular sequence register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC2_S_ADC_SQR3_SQ10                             \ 10th conversion in regular sequence
$000007c0 constant ADC2_S_ADC_SQR3_SQ11                             \ 11th conversion in regular sequence
$0001f000 constant ADC2_S_ADC_SQR3_SQ12                             \ 12th conversion in regular sequence
$007c0000 constant ADC2_S_ADC_SQR3_SQ13                             \ 13th conversion in regular sequence
$1f000000 constant ADC2_S_ADC_SQR3_SQ14                             \ 14th conversion in regular sequence


\
\ @brief ADC regular sequence register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC2_S_ADC_SQR4_SQ15                             \ 15th conversion in regular sequence
$000007c0 constant ADC2_S_ADC_SQR4_SQ16                             \ 16th conversion in regular sequence


\
\ @brief ADC regular data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant ADC2_S_ADC_DR_RDATA                              \ Regular data converted


\
\ @brief ADC injected sequence register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC2_S_ADC_JSQR_JL                               \ Injected channel sequence length
$0000007c constant ADC2_S_ADC_JSQR_JEXTSEL                          \ External trigger selection for injected group
$00000180 constant ADC2_S_ADC_JSQR_JEXTEN                           \ External trigger enable and polarity selection for injected channels
$00003e00 constant ADC2_S_ADC_JSQR_JSQ1                             \ 1st conversion in the injected sequence
$000f8000 constant ADC2_S_ADC_JSQR_JSQ2                             \ 2nd conversion in the injected sequence
$03e00000 constant ADC2_S_ADC_JSQR_JSQ3                             \ 3rd conversion in the injected sequence
$f8000000 constant ADC2_S_ADC_JSQR_JSQ4                             \ 4th conversion in the injected sequence


\
\ @brief ADC offset 1 configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$01000000 constant ADC2_S_ADC_OFCFGR1_POSOFF                        \ Positive offset enable
$02000000 constant ADC2_S_ADC_OFCFGR1_USAT                          \ Unsigned saturation enable
$04000000 constant ADC2_S_ADC_OFCFGR1_SSAT                          \ Signed saturation enable
$f8000000 constant ADC2_S_ADC_OFCFGR1_OFFSET_CH                     \ Channel selection for the data offset y


\
\ @brief ADC offset 2 configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$01000000 constant ADC2_S_ADC_OFCFGR2_POSOFF                        \ Positive offset enable
$02000000 constant ADC2_S_ADC_OFCFGR2_USAT                          \ Unsigned saturation enable
$04000000 constant ADC2_S_ADC_OFCFGR2_SSAT                          \ Signed saturation enable
$f8000000 constant ADC2_S_ADC_OFCFGR2_OFFSET_CH                     \ Channel selection for the data offset y


\
\ @brief ADC offset 3 configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$01000000 constant ADC2_S_ADC_OFCFGR3_POSOFF                        \ Positive offset enable
$02000000 constant ADC2_S_ADC_OFCFGR3_USAT                          \ Unsigned saturation enable
$04000000 constant ADC2_S_ADC_OFCFGR3_SSAT                          \ Signed saturation enable
$f8000000 constant ADC2_S_ADC_OFCFGR3_OFFSET_CH                     \ Channel selection for the data offset y


\
\ @brief ADC offset 4 configuration register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$01000000 constant ADC2_S_ADC_OFCFGR4_POSOFF                        \ Positive offset enable
$02000000 constant ADC2_S_ADC_OFCFGR4_USAT                          \ Unsigned saturation enable
$04000000 constant ADC2_S_ADC_OFCFGR4_SSAT                          \ Signed saturation enable
$f8000000 constant ADC2_S_ADC_OFCFGR4_OFFSET_CH                     \ Channel selection for the data offset y


\
\ @brief ADC offset 1 register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$003fffff constant ADC2_S_ADC_OFR1_OFFSET                           \ Data offset y for the channel programmed into OFFSETy_CH[4:0] bits


\
\ @brief ADC offset 2 register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$003fffff constant ADC2_S_ADC_OFR2_OFFSET                           \ Data offset y for the channel programmed into OFFSETy_CH[4:0] bits


\
\ @brief ADC offset 3 register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$003fffff constant ADC2_S_ADC_OFR3_OFFSET                           \ Data offset y for the channel programmed into OFFSETy_CH[4:0] bits


\
\ @brief ADC offset 4 register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$003fffff constant ADC2_S_ADC_OFR4_OFFSET                           \ Data offset y for the channel programmed into OFFSETy_CH[4:0] bits


\
\ @brief ADC gain compensation register
\ Address offset: 0x70
\ Reset value: 0x00001000
\

$00003fff constant ADC2_S_ADC_GCOMP_GCOMPCOEFF                      \ Gain compensation coefficient
$80000000 constant ADC2_S_ADC_GCOMP_GCOMP                           \ Gain compensation mode


\
\ @brief ADC injected channel 1 data register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant ADC2_S_ADC_JDR1_JDATA                            \ Injected data


\
\ @brief ADC injected channel 2 data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant ADC2_S_ADC_JDR2_JDATA                            \ Injected data


\
\ @brief ADC injected channel 3 data register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant ADC2_S_ADC_JDR3_JDATA                            \ Injected data


\
\ @brief ADC injected channel 4 data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant ADC2_S_ADC_JDR4_JDATA                            \ Injected data


\
\ @brief ADC Analog Watchdog 2 Configuration Register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000fffff constant ADC2_S_ADC_AWD2CR_AWD2CH                         \ Analog watchdog 2 channel selection


\
\ @brief ADC Analog Watchdog 3 Configuration Register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000fffff constant ADC2_S_ADC_AWD3CR_AWD3CH                         \ Analog watchdog 3 channel selection


\
\ @brief ADC analog watchdog 1 lower threshold register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$007fffff constant ADC2_S_ADC_AWD1LTR_LTR                           \ Analog watchdog 1 lower threshold


\
\ @brief ADC analog watchdog 1 higher threshold register
\ Address offset: 0xAC
\ Reset value: 0x003FFFFF
\

$007fffff constant ADC2_S_ADC_AWD1HTR_HTR                           \ Analog watchdog 1 higher threshold
$e0000000 constant ADC2_S_ADC_AWD1HTR_AWDFILT                       \ Analog watchdog filtering parameter


\
\ @brief ADC analog watchdog 2 lower threshold register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$007fffff constant ADC2_S_ADC_AWD2LTR_LTR                           \ Analog watchdog 2 lower threshold


\
\ @brief ADC analog watchdog 2 higher threshold register
\ Address offset: 0xB4
\ Reset value: 0x003FFFFF
\

$007fffff constant ADC2_S_ADC_AWD2HTR_HTR                           \ Analog watchdog 2 higher threshold


\
\ @brief ADC analog watchdog 3 lower threshold register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$007fffff constant ADC2_S_ADC_AWD3LTR_LTR                           \ Analog watchdog 3 lower threshold


\
\ @brief ADC analog watchdog 3 higher threshold register
\ Address offset: 0xBC
\ Reset value: 0x003FFFFF
\

$007fffff constant ADC2_S_ADC_AWD3HTR_HTR                           \ Analog watchdog 3 higher threshold


\
\ @brief ADC Differential mode selection register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$000fffff constant ADC2_S_ADC_DIFSEL_DIFSEL                         \ Differential mode for channels 19 to 0.


\
\ @brief ADC calibration factors
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000001ff constant ADC2_S_ADC_CALFACT_CALFACT_S                     \ Calibration factors In Single-ended mode
$01ff0000 constant ADC2_S_ADC_CALFACT_CALFACT_D                     \ Calibration factors in Differential mode
$80000000 constant ADC2_S_ADC_CALFACT_CALADDOS                      \ Calibration additional offset


\
\ @brief ADC option register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant ADC2_S_ADC_OR_SELREF                             \ Internal reference voltage selection
$00000002 constant ADC2_S_ADC_OR_SELBG                              \ Bandgap selection
$00000004 constant ADC2_S_ADC_OR_VDDCOREEN                          \ VDDCORE enable


\
\ @brief Analog-to-digital converters
\
$50022100 constant ADC2_S_ADC_ISR  \ offset: 0x00 : ADC interrupt and status register
$50022104 constant ADC2_S_ADC_IER  \ offset: 0x04 : ADC interrupt enable register
$50022108 constant ADC2_S_ADC_CR  \ offset: 0x08 : ADC control register
$5002210c constant ADC2_S_ADC_CFGR1  \ offset: 0x0C : ADC configuration register
$50022110 constant ADC2_S_ADC_CFGR2  \ offset: 0x10 : ADC configuration register 2
$50022114 constant ADC2_S_ADC_SMPR1  \ offset: 0x14 : ADC sample time register 1
$50022118 constant ADC2_S_ADC_SMPR2  \ offset: 0x18 : ADC sample time register 2
$5002211c constant ADC2_S_ADC_PCSEL  \ offset: 0x1C : ADC channel preselection register
$50022130 constant ADC2_S_ADC_SQR1  \ offset: 0x30 : ADC regular sequence register 1
$50022134 constant ADC2_S_ADC_SQR2  \ offset: 0x34 : ADC regular sequence register 2
$50022138 constant ADC2_S_ADC_SQR3  \ offset: 0x38 : ADC regular sequence register 3
$5002213c constant ADC2_S_ADC_SQR4  \ offset: 0x3C : ADC regular sequence register 4
$50022140 constant ADC2_S_ADC_DR  \ offset: 0x40 : ADC regular data register
$5002214c constant ADC2_S_ADC_JSQR  \ offset: 0x4C : ADC injected sequence register
$50022150 constant ADC2_S_ADC_OFCFGR1  \ offset: 0x50 : ADC offset 1 configuration register
$50022154 constant ADC2_S_ADC_OFCFGR2  \ offset: 0x54 : ADC offset 2 configuration register
$50022158 constant ADC2_S_ADC_OFCFGR3  \ offset: 0x58 : ADC offset 3 configuration register
$5002215c constant ADC2_S_ADC_OFCFGR4  \ offset: 0x5C : ADC offset 4 configuration register
$50022160 constant ADC2_S_ADC_OFR1  \ offset: 0x60 : ADC offset 1 register
$50022164 constant ADC2_S_ADC_OFR2  \ offset: 0x64 : ADC offset 2 register
$50022168 constant ADC2_S_ADC_OFR3  \ offset: 0x68 : ADC offset 3 register
$5002216c constant ADC2_S_ADC_OFR4  \ offset: 0x6C : ADC offset 4 register
$50022170 constant ADC2_S_ADC_GCOMP  \ offset: 0x70 : ADC gain compensation register
$50022180 constant ADC2_S_ADC_JDR1  \ offset: 0x80 : ADC injected channel 1 data register
$50022184 constant ADC2_S_ADC_JDR2  \ offset: 0x84 : ADC injected channel 2 data register
$50022188 constant ADC2_S_ADC_JDR3  \ offset: 0x88 : ADC injected channel 3 data register
$5002218c constant ADC2_S_ADC_JDR4  \ offset: 0x8C : ADC injected channel 4 data register
$500221a0 constant ADC2_S_ADC_AWD2CR  \ offset: 0xA0 : ADC Analog Watchdog 2 Configuration Register
$500221a4 constant ADC2_S_ADC_AWD3CR  \ offset: 0xA4 : ADC Analog Watchdog 3 Configuration Register
$500221a8 constant ADC2_S_ADC_AWD1LTR  \ offset: 0xA8 : ADC analog watchdog 1 lower threshold register
$500221ac constant ADC2_S_ADC_AWD1HTR  \ offset: 0xAC : ADC analog watchdog 1 higher threshold register
$500221b0 constant ADC2_S_ADC_AWD2LTR  \ offset: 0xB0 : ADC analog watchdog 2 lower threshold register
$500221b4 constant ADC2_S_ADC_AWD2HTR  \ offset: 0xB4 : ADC analog watchdog 2 higher threshold register
$500221b8 constant ADC2_S_ADC_AWD3LTR  \ offset: 0xB8 : ADC analog watchdog 3 lower threshold register
$500221bc constant ADC2_S_ADC_AWD3HTR  \ offset: 0xBC : ADC analog watchdog 3 higher threshold register
$500221c0 constant ADC2_S_ADC_DIFSEL  \ offset: 0xC0 : ADC Differential mode selection register
$500221c4 constant ADC2_S_ADC_CALFACT  \ offset: 0xC4 : ADC calibration factors
$500221d0 constant ADC2_S_ADC_OR  \ offset: 0xD0 : ADC option register

