\
\ @file adc1.fs
\ @brief Analog to digital converter
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

$00000001 constant ADC1_ADC_ISR_ADRDY                               \ ADC ready
$00000002 constant ADC1_ADC_ISR_EOSMP                               \ End of sampling flag
$00000004 constant ADC1_ADC_ISR_EOC                                 \ End of conversion flag
$00000008 constant ADC1_ADC_ISR_EOS                                 \ End of regular sequence flag
$00000010 constant ADC1_ADC_ISR_OVR                                 \ ADC overrun
$00000020 constant ADC1_ADC_ISR_JEOC                                \ Injected channel end of conversion flag
$00000040 constant ADC1_ADC_ISR_JEOS                                \ Injected channel end of sequence flag
$00000080 constant ADC1_ADC_ISR_AWD1                                \ Analog watchdog 1 flag
$00000100 constant ADC1_ADC_ISR_AWD2                                \ Analog watchdog 2 flag
$00000200 constant ADC1_ADC_ISR_AWD3                                \ Analog watchdog 3 flag
$00000400 constant ADC1_ADC_ISR_JQOVF                               \ Injected context queue overflow


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_IER_ADRDYIE                             \ ADC ready interrupt enable
$00000002 constant ADC1_ADC_IER_EOSMPIE                             \ End of sampling flag interrupt enable for regular conversions
$00000004 constant ADC1_ADC_IER_EOCIE                               \ End of regular conversion interrupt enable
$00000008 constant ADC1_ADC_IER_EOSIE                               \ End of regular sequence of conversions interrupt enable
$00000010 constant ADC1_ADC_IER_OVRIE                               \ Overrun interrupt enable
$00000020 constant ADC1_ADC_IER_JEOCIE                              \ End of injected conversion interrupt enable
$00000040 constant ADC1_ADC_IER_JEOSIE                              \ End of injected sequence of conversions interrupt enable
$00000080 constant ADC1_ADC_IER_AWD1IE                              \ Analog watchdog 1 interrupt enable
$00000100 constant ADC1_ADC_IER_AWD2IE                              \ Analog watchdog 2 interrupt enable
$00000200 constant ADC1_ADC_IER_AWD3IE                              \ Analog watchdog 3 interrupt enable
$00000400 constant ADC1_ADC_IER_JQOVFIE                             \ Injected context queue overflow interrupt enable


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x20000000
\

$00000001 constant ADC1_ADC_CR_ADEN                                 \ ADC enable control
$00000002 constant ADC1_ADC_CR_ADDIS                                \ ADC disable command
$00000004 constant ADC1_ADC_CR_ADSTART                              \ ADC start of regular conversion
$00000008 constant ADC1_ADC_CR_JADSTART                             \ ADC start of injected conversion
$00000010 constant ADC1_ADC_CR_ADSTP                                \ ADC stop of regular conversion command
$00000020 constant ADC1_ADC_CR_JADSTP                               \ ADC stop of injected conversion command
$10000000 constant ADC1_ADC_CR_ADVREGEN                             \ ADC voltage regulator enable
$20000000 constant ADC1_ADC_CR_DEEPPWD                              \ Deep-power-down enable
$40000000 constant ADC1_ADC_CR_ADCALDIF                             \ Differential mode for calibration
$80000000 constant ADC1_ADC_CR_ADCAL                                \ ADC calibration


\
\ @brief ADC configuration register
\ Address offset: 0x0C
\ Reset value: 0x80000000
\

$00000001 constant ADC1_ADC_CFGR_DMAEN                              \ Direct memory access enable
$00000002 constant ADC1_ADC_CFGR_DMACFG                             \ Direct memory access configuration
$00000018 constant ADC1_ADC_CFGR_RES                                \ Data resolution
$000003e0 constant ADC1_ADC_CFGR_EXTSEL                             \ External trigger selection for regular group These bits select the external event used to trigger the start of conversion of a regular group: ... Note: The software is allowed to write these bits only when ADSTART = 0 (which ensures that no regular conversion is ongoing).
$00000c00 constant ADC1_ADC_CFGR_EXTEN                              \ External trigger enable and polarity selection for regular channels
$00001000 constant ADC1_ADC_CFGR_OVRMOD                             \ Overrun mode
$00002000 constant ADC1_ADC_CFGR_CONT                               \ Single / continuous conversion mode for regular conversions
$00004000 constant ADC1_ADC_CFGR_AUTDLY                             \ Delayed conversion mode
$00008000 constant ADC1_ADC_CFGR_ALIGN                              \ Data alignment
$00010000 constant ADC1_ADC_CFGR_DISCEN                             \ Discontinuous mode for regular channels
$000e0000 constant ADC1_ADC_CFGR_DISCNUM                            \ Discontinuous mode channel count
$00100000 constant ADC1_ADC_CFGR_JDISCEN                            \ Discontinuous mode on injected channels
$00200000 constant ADC1_ADC_CFGR_JQM                                \ JSQR queue mode
$00400000 constant ADC1_ADC_CFGR_AWD1SGL                            \ Enable the watchdog 1 on a single channel or on all channels
$00800000 constant ADC1_ADC_CFGR_AWD1EN                             \ Analog watchdog 1 enable on regular channels
$01000000 constant ADC1_ADC_CFGR_JAWD1EN                            \ Analog watchdog 1 enable on injected channels
$02000000 constant ADC1_ADC_CFGR_JAUTO                              \ Automatic injected group conversion
$7c000000 constant ADC1_ADC_CFGR_AWD1CH                             \ Analog watchdog 1 channel selection
$80000000 constant ADC1_ADC_CFGR_JQDIS                              \ Injected queue disable


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_CFGR2_ROVSE                             \ Regular oversampling Enable
$00000002 constant ADC1_ADC_CFGR2_JOVSE                             \ Injected oversampling Enable
$0000001c constant ADC1_ADC_CFGR2_OVSR                              \ Oversampling ratio
$000001e0 constant ADC1_ADC_CFGR2_OVSS                              \ Oversampling shift
$00000200 constant ADC1_ADC_CFGR2_TROVS                             \ Triggered Regular oversampling
$00000400 constant ADC1_ADC_CFGR2_ROVSM                             \ Regular oversampling mode
$02000000 constant ADC1_ADC_CFGR2_SWTRIG                            \ Software trigger bit for sampling time control trigger mode
$04000000 constant ADC1_ADC_CFGR2_BULB                              \ Bulb sampling mode
$08000000 constant ADC1_ADC_CFGR2_SMPTRIG                           \ Sampling time control trigger mode


\
\ @brief ADC sample time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC1_ADC_SMPR1_SMP0                              \ Channel x sampling time selection (x=9 to 0)
$00000038 constant ADC1_ADC_SMPR1_SMP1                              \ Channel x sampling time selection (x=9 to 0)
$000001c0 constant ADC1_ADC_SMPR1_SMP2                              \ Channel x sampling time selection (x=9 to 0)
$00000e00 constant ADC1_ADC_SMPR1_SMP3                              \ Channel x sampling time selection (x=9 to 0)
$00007000 constant ADC1_ADC_SMPR1_SMP4                              \ Channel x sampling time selection (x=9 to 0)
$00038000 constant ADC1_ADC_SMPR1_SMP5                              \ Channel x sampling time selection (x=9 to 0)
$001c0000 constant ADC1_ADC_SMPR1_SMP6                              \ Channel x sampling time selection (x=9 to 0)
$00e00000 constant ADC1_ADC_SMPR1_SMP7                              \ Channel x sampling time selection (x=9 to 0)
$07000000 constant ADC1_ADC_SMPR1_SMP8                              \ Channel x sampling time selection (x=9 to 0)
$38000000 constant ADC1_ADC_SMPR1_SMP9                              \ Channel x sampling time selection (x=9 to 0)
$80000000 constant ADC1_ADC_SMPR1_SMPPLUS                           \ Addition of one clock cycle to the sampling time.


\
\ @brief ADC sample time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC1_ADC_SMPR2_SMP10                             \ Channel x sampling time selection (x=19 to 10)
$00000038 constant ADC1_ADC_SMPR2_SMP11                             \ Channel x sampling time selection (x=19 to 10)
$000001c0 constant ADC1_ADC_SMPR2_SMP12                             \ Channel x sampling time selection (x=19 to 10)
$00000e00 constant ADC1_ADC_SMPR2_SMP13                             \ Channel x sampling time selection (x=19 to 10)
$00007000 constant ADC1_ADC_SMPR2_SMP14                             \ Channel x sampling time selection (x=19 to 10)
$00038000 constant ADC1_ADC_SMPR2_SMP15                             \ Channel x sampling time selection (x=19 to 10)
$001c0000 constant ADC1_ADC_SMPR2_SMP16                             \ Channel x sampling time selection (x=19 to 10)
$00e00000 constant ADC1_ADC_SMPR2_SMP17                             \ Channel x sampling time selection (x=19 to 10)
$07000000 constant ADC1_ADC_SMPR2_SMP18                             \ Channel x sampling time selection (x=19 to 10)
$38000000 constant ADC1_ADC_SMPR2_SMP19                             \ Channel x sampling time selection (x=19 to 10)


\
\ @brief ADC watchdog threshold register 1
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC1_ADC_TR1_LT1                                 \ Analog watchdog 1 lower threshold
$00007000 constant ADC1_ADC_TR1_AWDFILT                             \ Analog watchdog filtering parameter
$0fff0000 constant ADC1_ADC_TR1_HT1                                 \ Analog watchdog 1 higher threshold


\
\ @brief ADC watchdog threshold register 2
\ Address offset: 0x24
\ Reset value: 0x00FF0000
\

$000000ff constant ADC1_ADC_TR2_LT2                                 \ Analog watchdog 2 lower threshold
$00ff0000 constant ADC1_ADC_TR2_HT2                                 \ Analog watchdog 2 higher threshold


\
\ @brief ADC watchdog threshold register 3
\ Address offset: 0x28
\ Reset value: 0x00FF0000
\

$000000ff constant ADC1_ADC_TR3_LT3                                 \ Analog watchdog 3 lower threshold
$00ff0000 constant ADC1_ADC_TR3_HT3                                 \ Analog watchdog 3 higher threshold


\
\ @brief ADC regular sequence register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC1_ADC_SQR1_L                                  \ Regular channel sequence length
$000007c0 constant ADC1_ADC_SQR1_SQ1                                \ 1st conversion in regular sequence
$0001f000 constant ADC1_ADC_SQR1_SQ2                                \ 2nd conversion in regular sequence
$007c0000 constant ADC1_ADC_SQR1_SQ3                                \ 3rd conversion in regular sequence
$1f000000 constant ADC1_ADC_SQR1_SQ4                                \ 4th conversion in regular sequence


\
\ @brief ADC regular sequence register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC1_ADC_SQR2_SQ5                                \ 5th conversion in regular sequence
$000007c0 constant ADC1_ADC_SQR2_SQ6                                \ 6th conversion in regular sequence
$0001f000 constant ADC1_ADC_SQR2_SQ7                                \ 7th conversion in regular sequence
$007c0000 constant ADC1_ADC_SQR2_SQ8                                \ 8th conversion in regular sequence
$1f000000 constant ADC1_ADC_SQR2_SQ9                                \ 9th conversion in regular sequence


\
\ @brief ADC regular sequence register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC1_ADC_SQR3_SQ10                               \ 10th conversion in regular sequence
$000007c0 constant ADC1_ADC_SQR3_SQ11                               \ 11th conversion in regular sequence
$0001f000 constant ADC1_ADC_SQR3_SQ12                               \ 12th conversion in regular sequence
$007c0000 constant ADC1_ADC_SQR3_SQ13                               \ 13th conversion in regular sequence
$1f000000 constant ADC1_ADC_SQR3_SQ14                               \ 14th conversion in regular sequence


\
\ @brief ADC regular sequence register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC1_ADC_SQR4_SQ15                               \ 15th conversion in regular sequence
$000007c0 constant ADC1_ADC_SQR4_SQ16                               \ 16th conversion in regular sequence


\
\ @brief ADC regular data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC1_ADC_DR_RDATA                                \ Regular data converted


\
\ @brief ADC injected sequence register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC1_ADC_JSQR_JL                                 \ Injected channel sequence length
$0000007c constant ADC1_ADC_JSQR_JEXTSEL                            \ External Trigger Selection for injected group
$00000180 constant ADC1_ADC_JSQR_JEXTEN                             \ External trigger enable and polarity selection for injected channels
$00003e00 constant ADC1_ADC_JSQR_JSQ1                               \ 1st conversion in the injected sequence
$000f8000 constant ADC1_ADC_JSQR_JSQ2                               \ 2nd conversion in the injected sequence
$03e00000 constant ADC1_ADC_JSQR_JSQ3                               \ 3rd conversion in the injected sequence
$f8000000 constant ADC1_ADC_JSQR_JSQ4                               \ 4th conversion in the injected sequence


\
\ @brief ADC offset 1 register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000fff constant ADC1_ADC_OFR1_OFFSET                             \ Data offset y for the channel programmed into bits OFFSET_CH[4:0]
$01000000 constant ADC1_ADC_OFR1_OFFSETPOS                          \ Positive offset
$02000000 constant ADC1_ADC_OFR1_SATEN                              \ Saturation enable
$7c000000 constant ADC1_ADC_OFR1_OFFSET_CH                          \ Channel selection for the data offset y
$80000000 constant ADC1_ADC_OFR1_OFFSET_EN                          \ Offset y enable


\
\ @brief ADC offset 2 register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000fff constant ADC1_ADC_OFR2_OFFSET                             \ Data offset y for the channel programmed into bits OFFSET_CH[4:0]
$01000000 constant ADC1_ADC_OFR2_OFFSETPOS                          \ Positive offset
$02000000 constant ADC1_ADC_OFR2_SATEN                              \ Saturation enable
$7c000000 constant ADC1_ADC_OFR2_OFFSET_CH                          \ Channel selection for the data offset y
$80000000 constant ADC1_ADC_OFR2_OFFSET_EN                          \ Offset y enable


\
\ @brief ADC offset 3 register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000fff constant ADC1_ADC_OFR3_OFFSET                             \ Data offset y for the channel programmed into bits OFFSET_CH[4:0]
$01000000 constant ADC1_ADC_OFR3_OFFSETPOS                          \ Positive offset
$02000000 constant ADC1_ADC_OFR3_SATEN                              \ Saturation enable
$7c000000 constant ADC1_ADC_OFR3_OFFSET_CH                          \ Channel selection for the data offset y
$80000000 constant ADC1_ADC_OFR3_OFFSET_EN                          \ Offset y enable


\
\ @brief ADC offset 4 register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000fff constant ADC1_ADC_OFR4_OFFSET                             \ Data offset y for the channel programmed into bits OFFSET_CH[4:0]
$01000000 constant ADC1_ADC_OFR4_OFFSETPOS                          \ Positive offset
$02000000 constant ADC1_ADC_OFR4_SATEN                              \ Saturation enable
$7c000000 constant ADC1_ADC_OFR4_OFFSET_CH                          \ Channel selection for the data offset y
$80000000 constant ADC1_ADC_OFR4_OFFSET_EN                          \ Offset y enable


\
\ @brief ADC injected channel 1 data register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant ADC1_ADC_JDR1_JDATA                              \ Injected data


\
\ @brief ADC injected channel 2 data register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant ADC1_ADC_JDR2_JDATA                              \ Injected data


\
\ @brief ADC injected channel 3 data register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant ADC1_ADC_JDR3_JDATA                              \ Injected data


\
\ @brief ADC injected channel 4 data register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant ADC1_ADC_JDR4_JDATA                              \ Injected data


\
\ @brief ADC analog watchdog 2 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000fffff constant ADC1_ADC_AWD2CR_AWD2CH                           \ Analog watchdog 2 channel selection


\
\ @brief ADC analog watchdog 3 configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000fffff constant ADC1_ADC_AWD3CR_AWD3CH                           \ Analog watchdog 3 channel selection


\
\ @brief ADC Differential mode selection register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$000fffff constant ADC1_ADC_DIFSEL_DIFSEL                           \ Differential mode for channels 19 to 0.


\
\ @brief ADC calibration factors
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant ADC1_ADC_CALFACT_CALFACT_S                       \ Calibration Factors In single-ended mode
$007f0000 constant ADC1_ADC_CALFACT_CALFACT_D                       \ Calibration Factors in differential mode


\
\ @brief ADC option register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000001 constant ADC1_ADC_OR_OP0                                  \ Option bit 0


\
\ @brief Analog to digital converter
\
$42028000 constant ADC1_ADC_ISR   \ offset: 0x00 : ADC interrupt and status register
$42028004 constant ADC1_ADC_IER   \ offset: 0x04 : ADC interrupt enable register
$42028008 constant ADC1_ADC_CR    \ offset: 0x08 : ADC control register
$4202800c constant ADC1_ADC_CFGR  \ offset: 0x0C : ADC configuration register
$42028010 constant ADC1_ADC_CFGR2  \ offset: 0x10 : ADC configuration register 2
$42028014 constant ADC1_ADC_SMPR1  \ offset: 0x14 : ADC sample time register 1
$42028018 constant ADC1_ADC_SMPR2  \ offset: 0x18 : ADC sample time register 2
$42028020 constant ADC1_ADC_TR1   \ offset: 0x20 : ADC watchdog threshold register 1
$42028024 constant ADC1_ADC_TR2   \ offset: 0x24 : ADC watchdog threshold register 2
$42028028 constant ADC1_ADC_TR3   \ offset: 0x28 : ADC watchdog threshold register 3
$42028030 constant ADC1_ADC_SQR1  \ offset: 0x30 : ADC regular sequence register 1
$42028034 constant ADC1_ADC_SQR2  \ offset: 0x34 : ADC regular sequence register 2
$42028038 constant ADC1_ADC_SQR3  \ offset: 0x38 : ADC regular sequence register 3
$4202803c constant ADC1_ADC_SQR4  \ offset: 0x3C : ADC regular sequence register 4
$42028040 constant ADC1_ADC_DR    \ offset: 0x40 : ADC regular data register
$4202804c constant ADC1_ADC_JSQR  \ offset: 0x4C : ADC injected sequence register
$42028060 constant ADC1_ADC_OFR1  \ offset: 0x60 : ADC offset 1 register
$42028064 constant ADC1_ADC_OFR2  \ offset: 0x64 : ADC offset 2 register
$42028068 constant ADC1_ADC_OFR3  \ offset: 0x68 : ADC offset 3 register
$4202806c constant ADC1_ADC_OFR4  \ offset: 0x6C : ADC offset 4 register
$42028080 constant ADC1_ADC_JDR1  \ offset: 0x80 : ADC injected channel 1 data register
$42028084 constant ADC1_ADC_JDR2  \ offset: 0x84 : ADC injected channel 2 data register
$42028088 constant ADC1_ADC_JDR3  \ offset: 0x88 : ADC injected channel 3 data register
$4202808c constant ADC1_ADC_JDR4  \ offset: 0x8C : ADC injected channel 4 data register
$420280a0 constant ADC1_ADC_AWD2CR  \ offset: 0xA0 : ADC analog watchdog 2 configuration register
$420280a4 constant ADC1_ADC_AWD3CR  \ offset: 0xA4 : ADC analog watchdog 3 configuration register
$420280b0 constant ADC1_ADC_DIFSEL  \ offset: 0xB0 : ADC Differential mode selection register
$420280b4 constant ADC1_ADC_CALFACT  \ offset: 0xB4 : ADC calibration factors
$420280c8 constant ADC1_ADC_OR    \ offset: 0xC8 : ADC option register

