\
\ @file adc.fs
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

$00000001 constant ADC_ISR_ADRDY                                    \ ADC ready
$00000002 constant ADC_ISR_EOSMP                                    \ End of sampling flag
$00000004 constant ADC_ISR_EOC                                      \ End of conversion flag
$00000008 constant ADC_ISR_EOS                                      \ End of regular sequence flag
$00000010 constant ADC_ISR_OVR                                      \ ADC overrun
$00000020 constant ADC_ISR_JEOC                                     \ Injected channel end of conversion flag
$00000040 constant ADC_ISR_JEOS                                     \ Injected channel end of sequence flag
$00000080 constant ADC_ISR_AWD1                                     \ Analog watchdog 1 flag
$00000100 constant ADC_ISR_AWD2                                     \ Analog watchdog 2 flag
$00000200 constant ADC_ISR_AWD3                                     \ Analog watchdog 3 flag
$00000400 constant ADC_ISR_JQOVF                                    \ Injected context queue overflow


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC_IER_ADRDYIE                                  \ ADC ready interrupt enable
$00000002 constant ADC_IER_EOSMPIE                                  \ End of sampling flag interrupt enable for regular conversions
$00000004 constant ADC_IER_EOCIE                                    \ End of regular conversion interrupt enable
$00000008 constant ADC_IER_EOSIE                                    \ End of regular sequence of conversions interrupt enable
$00000010 constant ADC_IER_OVRIE                                    \ Overrun interrupt enable
$00000020 constant ADC_IER_JEOCIE                                   \ End of injected conversion interrupt enable
$00000040 constant ADC_IER_JEOSIE                                   \ End of injected sequence of conversions interrupt enable
$00000080 constant ADC_IER_AWD1IE                                   \ Analog watchdog 1 interrupt enable
$00000100 constant ADC_IER_AWD2IE                                   \ Analog watchdog 2 interrupt enable
$00000200 constant ADC_IER_AWD3IE                                   \ Analog watchdog 3 interrupt enable
$00000400 constant ADC_IER_JQOVFIE                                  \ Injected context queue overflow interrupt enable


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x20000000
\

$00000001 constant ADC_CR_ADEN                                      \ ADC enable control
$00000002 constant ADC_CR_ADDIS                                     \ ADC disable command
$00000004 constant ADC_CR_ADSTART                                   \ ADC start of regular conversion
$00000008 constant ADC_CR_JADSTART                                  \ ADC start of injected conversion
$00000010 constant ADC_CR_ADSTP                                     \ ADC stop of regular conversion command
$00000020 constant ADC_CR_JADST                                     \ ADC stop of injected conversion command
$30000000 constant ADC_CR_ADVREGEN                                  \ ADC voltage regulator enable
$40000000 constant ADC_CR_ADCALDIF                                  \ Differential mode for calibration
$80000000 constant ADC_CR_ADCAL                                     \ ADC calibration


\
\ @brief ADC configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant ADC_CFGR_DMAEN                                   \ Direct memory access enable
$00000002 constant ADC_CFGR_DMACFG                                  \ Direct memory access configuration
$00000018 constant ADC_CFGR_RES                                     \ Data resolution
$00000020 constant ADC_CFGR_ALIGN                                   \ Data alignment
$000003c0 constant ADC_CFGR_EXTSEL                                  \ External trigger selection for regular group
$00000c00 constant ADC_CFGR_EXTEN                                   \ External trigger enable and polarity selection for regular channels
$00001000 constant ADC_CFGR_OVRMOD                                  \ Overrun Mode
$00002000 constant ADC_CFGR_CONT                                    \ Single / continuous conversion mode for regular conversions
$00004000 constant ADC_CFGR_AUTDLY                                  \ Delayed conversion mode
$00010000 constant ADC_CFGR_DISCEN                                  \ Discontinuous mode for regular channels
$000e0000 constant ADC_CFGR_DISCNUM                                 \ Discontinuous mode channel count
$00100000 constant ADC_CFGR_JDISCEN                                 \ Discontinuous mode on injected channels
$00200000 constant ADC_CFGR_JQM                                     \ JSQR queue mode
$00400000 constant ADC_CFGR_AWD1SGL                                 \ Enable the watchdog 1 on a single channel or on all channels
$00800000 constant ADC_CFGR_AWD1EN                                  \ Analog watchdog 1 enable on regular channels
$01000000 constant ADC_CFGR_JAWD1EN                                 \ Analog watchdog 1 enable on injected channels
$02000000 constant ADC_CFGR_JAUTO                                   \ Automatic injected group conversion
$7c000000 constant ADC_CFGR_AWD1CH                                  \ Analog watchdog 1 channel selection


\
\ @brief ADC sample time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000038 constant ADC_SMPR1_SMP1                                   \ Channel 1 sampling time selection
$000001c0 constant ADC_SMPR1_SMP2                                   \ Channel 2 sampling time selection
$00000e00 constant ADC_SMPR1_SMP3                                   \ Channel 3 sampling time selection
$00007000 constant ADC_SMPR1_SMP4                                   \ Channel 4 sampling time selection
$00038000 constant ADC_SMPR1_SMP5                                   \ Channel 5 sampling time selection
$001c0000 constant ADC_SMPR1_SMP6                                   \ Channel 6 sampling time selection
$00e00000 constant ADC_SMPR1_SMP7                                   \ Channel 7 sampling time selection
$07000000 constant ADC_SMPR1_SMP8                                   \ Channel 8 sampling time selection
$38000000 constant ADC_SMPR1_SMP9                                   \ Channel 9 sampling time selection


\
\ @brief ADC sample time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC_SMPR2_SMP10                                  \ Channel 10 sampling time selection
$00000038 constant ADC_SMPR2_SMP11                                  \ Channel 11 sampling time selection
$000001c0 constant ADC_SMPR2_SMP12                                  \ Channel 12 sampling time selection
$00000e00 constant ADC_SMPR2_SMP13                                  \ Channel 13 sampling time selection
$00007000 constant ADC_SMPR2_SMP14                                  \ Channel 14 sampling time selection
$00038000 constant ADC_SMPR2_SMP15                                  \ Channel 15 sampling time selection
$001c0000 constant ADC_SMPR2_SMP16                                  \ Channel 16 sampling time selection
$00e00000 constant ADC_SMPR2_SMP17                                  \ Channel 17 sampling time selection
$07000000 constant ADC_SMPR2_SMP18                                  \ Channel 18 sampling time selection


\
\ @brief ADC watchdog threshold register 1
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC_TR1_LT1                                      \ Analog watchdog 1 lower threshold
$0fff0000 constant ADC_TR1_HT1                                      \ Analog watchdog 1 higher threshold


\
\ @brief ADC watchdog threshold register 2
\ Address offset: 0x24
\ Reset value: 0x0FFF0000
\

$000000ff constant ADC_TR2_LT2                                      \ Analog watchdog 2 lower threshold
$00ff0000 constant ADC_TR2_HT2                                      \ Analog watchdog 2 higher threshold


\
\ @brief read-write
\ Address offset: 0x28
\ Reset value: 0x0FFF0000
\

$000000ff constant ADC_TR3_LT3                                      \ Analog watchdog 3 lower threshold
$00ff0000 constant ADC_TR3_HT3                                      \ Analog watchdog 3 higher threshold


\
\ @brief ADC regular sequence register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC_SQR1_L                                       \ Regular channel sequence length
$000007c0 constant ADC_SQR1_SQ1                                     \ 1st conversion in regular sequence
$0001f000 constant ADC_SQR1_SQ2                                     \ 2nd conversion in regular sequence
$007c0000 constant ADC_SQR1_SQ3                                     \ 3rd conversion in regular sequence
$1f000000 constant ADC_SQR1_SQ4                                     \ 4th conversion in regular sequence


\
\ @brief ADC regular sequence register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR2_SQ5                                     \ 5th conversion in regular sequence
$000007c0 constant ADC_SQR2_SQ6                                     \ 6th conversion in regular sequence
$0001f000 constant ADC_SQR2_SQ7                                     \ 7th conversion in regular sequence
$007c0000 constant ADC_SQR2_SQ8                                     \ 8th conversion in regular sequence
$1f000000 constant ADC_SQR2_SQ9                                     \ 9th conversion in regular sequence


\
\ @brief ADC regular sequence register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR3_SQ10                                    \ 10th conversion in regular sequence
$000007c0 constant ADC_SQR3_SQ11                                    \ 11th conversion in regular sequence
$0001f000 constant ADC_SQR3_SQ12                                    \ 13th conversion in regular sequence
$007c0000 constant ADC_SQR3_SQ13                                    \ 13th conversion in regular sequence
$1f000000 constant ADC_SQR3_SQ14                                    \ 14th conversion in regular sequence


\
\ @brief ADC regular sequence register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR4_SQ15                                    \ 15th conversion in regular sequence
$000007c0 constant ADC_SQR4_SQ16                                    \ 16th conversion in regular sequence


\
\ @brief ADC regular Data Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC_DR_RDATA                                     \ Regular Data converted


\
\ @brief ADC injected sequence register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC_JSQR_JL                                      \ Injected channel sequence length
$0000003c constant ADC_JSQR_JEXTSEL                                 \ External Trigger Selection for injected group
$000000c0 constant ADC_JSQR_JEXTEN                                  \ External Trigger Enable and Polarity Selection for injected channels
$00001f00 constant ADC_JSQR_JSQ1                                    \ 1st conversion in the injected sequence
$0007c000 constant ADC_JSQR_JSQ2                                    \ 2nd conversion in the injected sequence
$01f00000 constant ADC_JSQR_JSQ3                                    \ 3rd conversion in the injected sequence
$7c000000 constant ADC_JSQR_JSQ4                                    \ 4th conversion in the injected sequence


\
\ @brief ADC offset register1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000fff constant ADC_OFR1_OFFSET1                                 \ Data offset 1 for the channel programmed into bits OFFSET1_CH
$7c000000 constant ADC_OFR1_OFFSET1_CH                              \ Channel selection for the Data offset 1
$80000000 constant ADC_OFR1_OFFSET1_EN                              \ Offset1 Enable


\
\ @brief ADC offset register2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000fff constant ADC_OFR2_OFFSET2                                 \ Data offset 2 for the channel programmed into bits OFFSET2_CH
$7c000000 constant ADC_OFR2_OFFSET2_CH                              \ Channel selection for the Data offset 2
$80000000 constant ADC_OFR2_OFFSET2_EN                              \ Offset 2 Enable


\
\ @brief ADC offset register3
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000fff constant ADC_OFR3_OFFSET3                                 \ Data offset 3 for the channel programmed into bits OFFSET3_CH
$7c000000 constant ADC_OFR3_OFFSET3_CH                              \ Channel selection for the Data offset 3
$80000000 constant ADC_OFR3_OFFSET3_EN                              \ Offset y Enable


\
\ @brief ADC offset register4
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000fff constant ADC_OFR4_OFFSET4                                 \ Data offset 4 for the channel programmed into bits OFFSET4_CH
$7c000000 constant ADC_OFR4_OFFSET4_CH                              \ Channel selection for the Data offset 4
$80000000 constant ADC_OFR4_OFFSET4_EN                              \ Offset 4 Enable


\
\ @brief ADC offset register1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR1_JDATA                                   \ Injected data


\
\ @brief ADC offset register2
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR2_JDATA                                   \ Injected data


\
\ @brief ADC offset register3
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR3_JDATA                                   \ Injected data


\
\ @brief ADC offset register4
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR4_JDATA                                   \ Injected data


\
\ @brief ADC Analog Watchdog 2 Configuration Register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0007fffe constant ADC_AWD2CR_AWD2CH                                \ Analog watchdog 2 channel selection


\
\ @brief ADC Analog Watchdog 3 Configuration Register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0007fffe constant ADC_AWD3CR_AWD3CH                                \ Analog watchdog 3 channel selection


\
\ @brief ADC Differential Mode Selection Register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0007fffe constant ADC_DIFSEL_DIFSEL                                \ Differential mode for channels 15 to 1


\
\ @brief ADC Calibration Factors
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant ADC_CALFACT_CALFACT_S                            \ Calibration Factors In Single-Ended mode
$007f0000 constant ADC_CALFACT_CALFACT_D                            \ Calibration Factors in differential mode


\
\ @brief ADC Common status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant ADC_CSR_ADRDY_MST                                \ Master ADC ready
$00000002 constant ADC_CSR_EOSMP_MST                                \ End of Sampling phase flag of the master ADC
$00000004 constant ADC_CSR_EOC_MST                                  \ End of regular conversion of the master ADC
$00000008 constant ADC_CSR_EOS_MST                                  \ End of regular sequence flag of the master ADC
$00000010 constant ADC_CSR_OVR_MST                                  \ Overrun flag of the master ADC
$00000020 constant ADC_CSR_JEOC_MST                                 \ End of injected conversion flag of the master ADC
$00000040 constant ADC_CSR_JEOS_MST                                 \ End of injected sequence flag of the master ADC
$00000080 constant ADC_CSR_AWD1_MST                                 \ Analog watchdog 1 flag of the master ADC
$00000100 constant ADC_CSR_AWD2_MST                                 \ Analog watchdog 2 flag of the master ADC
$00000200 constant ADC_CSR_AWD3_MST                                 \ Analog watchdog 3 flag of the master ADC
$00000400 constant ADC_CSR_JQOVF_MST                                \ Injected Context Queue Overflow flag of the master ADC
$00010000 constant ADC_CSR_ADRDY_SLV                                \ Slave ADC ready
$00020000 constant ADC_CSR_EOSMP_SLV                                \ End of Sampling phase flag of the slave ADC
$00040000 constant ADC_CSR_EOC_SLV                                  \ End of regular conversion of the slave ADC
$00080000 constant ADC_CSR_EOS_SLV                                  \ End of regular sequence flag of the slave ADC
$00100000 constant ADC_CSR_OVR_SLV                                  \ Overrun flag of the slave ADC
$00200000 constant ADC_CSR_JEOC_SLV                                 \ End of injected conversion flag of the slave ADC
$00400000 constant ADC_CSR_JEOS_SLV                                 \ End of injected sequence flag of the slave ADC
$00800000 constant ADC_CSR_AWD1_SLV                                 \ Analog watchdog 1 flag of the slave ADC
$01000000 constant ADC_CSR_AWD2_SLV                                 \ Analog watchdog 2 flag of the slave ADC
$02000000 constant ADC_CSR_AWD3_SLV                                 \ Analog watchdog 3 flag of the slave ADC
$04000000 constant ADC_CSR_JQOVF_SLV                                \ Injected Context Queue Overflow flag of the slave ADC


\
\ @brief ADC common control register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00030000 constant ADC_CRR_CKMODE                                   \ ADC clock mode
$00400000 constant ADC_CRR_VREFEN                                   \ VREFINT enable
$00800000 constant ADC_CRR_TSEN                                     \ Temperature sensor enable
$01000000 constant ADC_CRR_VBATEN                                   \ VBATEN


\
\ @brief Analog to digital converter
\
$50000000 constant ADC_ISR        \ offset: 0x00 : ADC interrupt and status register
$50000004 constant ADC_IER        \ offset: 0x04 : ADC interrupt enable register
$50000008 constant ADC_CR         \ offset: 0x08 : ADC control register
$5000000c constant ADC_CFGR       \ offset: 0x0C : ADC configuration register
$50000014 constant ADC_SMPR1      \ offset: 0x14 : ADC sample time register 1
$50000018 constant ADC_SMPR2      \ offset: 0x18 : ADC sample time register 2
$50000020 constant ADC_TR1        \ offset: 0x20 : ADC watchdog threshold register 1
$50000024 constant ADC_TR2        \ offset: 0x24 : ADC watchdog threshold register 2
$50000028 constant ADC_TR3        \ offset: 0x28 : read-write
$50000030 constant ADC_SQR1       \ offset: 0x30 : ADC regular sequence register 1
$50000034 constant ADC_SQR2       \ offset: 0x34 : ADC regular sequence register 2
$50000038 constant ADC_SQR3       \ offset: 0x38 : ADC regular sequence register 3
$5000003c constant ADC_SQR4       \ offset: 0x3C : ADC regular sequence register 4
$50000040 constant ADC_DR         \ offset: 0x40 : ADC regular Data Register
$5000004c constant ADC_JSQR       \ offset: 0x4C : ADC injected sequence register
$50000060 constant ADC_OFR1       \ offset: 0x60 : ADC offset register1
$50000064 constant ADC_OFR2       \ offset: 0x64 : ADC offset register2
$50000068 constant ADC_OFR3       \ offset: 0x68 : ADC offset register3
$5000006c constant ADC_OFR4       \ offset: 0x6C : ADC offset register4
$50000080 constant ADC_JDR1       \ offset: 0x80 : ADC offset register1
$50000084 constant ADC_JDR2       \ offset: 0x84 : ADC offset register2
$50000088 constant ADC_JDR3       \ offset: 0x88 : ADC offset register3
$5000008c constant ADC_JDR4       \ offset: 0x8C : ADC offset register4
$500000a0 constant ADC_AWD2CR     \ offset: 0xA0 : ADC Analog Watchdog 2 Configuration Register
$500000a4 constant ADC_AWD3CR     \ offset: 0xA4 : ADC Analog Watchdog 3 Configuration Register
$500000b0 constant ADC_DIFSEL     \ offset: 0xB0 : ADC Differential Mode Selection Register
$500000b4 constant ADC_CALFACT    \ offset: 0xB4 : ADC Calibration Factors
$50000300 constant ADC_CSR        \ offset: 0x300 : ADC Common status register
$50000308 constant ADC_CRR        \ offset: 0x308 : ADC common control register

