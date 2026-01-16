\
\ @file sec_adc4.fs
\ @brief ADC4
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

$00000001 constant SEC_ADC4_ADC_ISR_ADRDY                           \ ADRDY
$00000002 constant SEC_ADC4_ADC_ISR_EOSMP                           \ EOSMP
$00000004 constant SEC_ADC4_ADC_ISR_EOC                             \ EOC
$00000008 constant SEC_ADC4_ADC_ISR_EOS                             \ EOS
$00000010 constant SEC_ADC4_ADC_ISR_OVR                             \ OVR
$00000080 constant SEC_ADC4_ADC_ISR_AWD1                            \ AWD1
$00000100 constant SEC_ADC4_ADC_ISR_AWD2                            \ AWD2
$00000200 constant SEC_ADC4_ADC_ISR_AWD3                            \ AWD3
$00000800 constant SEC_ADC4_ADC_ISR_EOCAL                           \ EOCAL
$00001000 constant SEC_ADC4_ADC_ISR_LDORDY                          \ LDORDY


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_IER_ADRDYIE                         \ ADRDYIE
$00000002 constant SEC_ADC4_ADC_IER_EOSMPIE                         \ EOSMPIE
$00000004 constant SEC_ADC4_ADC_IER_EOCIE                           \ EOCIE
$00000008 constant SEC_ADC4_ADC_IER_EOSIE                           \ EOSIE
$00000010 constant SEC_ADC4_ADC_IER_OVRIE                           \ OVRIE
$00000080 constant SEC_ADC4_ADC_IER_AWD1IE                          \ AWD1IE
$00000100 constant SEC_ADC4_ADC_IER_AWD2IE                          \ AWD2IE
$00000200 constant SEC_ADC4_ADC_IER_AWD3IE                          \ AWD3IE
$00000800 constant SEC_ADC4_ADC_IER_EOCALIE                         \ EOCALIE
$00001000 constant SEC_ADC4_ADC_IER_LDORDYIE                        \ LDORDYIE


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_CR_ADEN                             \ ADEN
$00000002 constant SEC_ADC4_ADC_CR_ADDIS                            \ ADDIS
$00000004 constant SEC_ADC4_ADC_CR_ADSTART                          \ ADSTART
$00000010 constant SEC_ADC4_ADC_CR_ADSTP                            \ ADSTP
$10000000 constant SEC_ADC4_ADC_CR_ADVREGEN                         \ ADVREGEN
$80000000 constant SEC_ADC4_ADC_CR_ADCAL                            \ ADCAL


\
\ @brief ADC configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_CFGR1_DMAEN                         \ DMAEN
$00000002 constant SEC_ADC4_ADC_CFGR1_DMACFG                        \ DMACFG
$0000000c constant SEC_ADC4_ADC_CFGR1_RES                           \ RES
$00000010 constant SEC_ADC4_ADC_CFGR1_SCANDIR                       \ SCANDIR
$00000020 constant SEC_ADC4_ADC_CFGR1_ALIGN                         \ ALIGN
$000001c0 constant SEC_ADC4_ADC_CFGR1_EXTSEL                        \ EXTSEL
$00000c00 constant SEC_ADC4_ADC_CFGR1_EXTEN                         \ EXTEN
$00001000 constant SEC_ADC4_ADC_CFGR1_OVRMOD                        \ OVRMOD
$00002000 constant SEC_ADC4_ADC_CFGR1_CONT                          \ CONT
$00004000 constant SEC_ADC4_ADC_CFGR1_WAIT                          \ WAIT
$00010000 constant SEC_ADC4_ADC_CFGR1_DISCEN                        \ DISCEN
$00200000 constant SEC_ADC4_ADC_CFGR1_CHSELRMOD                     \ CHSELRMOD
$00400000 constant SEC_ADC4_ADC_CFGR1_AWD1SGL                       \ AWD1SGL
$00800000 constant SEC_ADC4_ADC_CFGR1_AWD1EN                        \ AWD1EN
$7c000000 constant SEC_ADC4_ADC_CFGR1_AWD1CH                        \ AWD1CH


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_CFGR2_OVSE                          \ OVSE
$0000001c constant SEC_ADC4_ADC_CFGR2_OVSR                          \ OVSR
$000001e0 constant SEC_ADC4_ADC_CFGR2_OVSS                          \ OVSS
$00000200 constant SEC_ADC4_ADC_CFGR2_TOVS                          \ TOVS
$20000000 constant SEC_ADC4_ADC_CFGR2_LFTRIG                        \ LFTRIG


\
\ @brief ADC sample time register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant SEC_ADC4_ADC_SMPR_SMP1                           \ SMP1
$00000070 constant SEC_ADC4_ADC_SMPR_SMP2                           \ SMP2
$00000100 constant SEC_ADC4_ADC_SMPR_SMPSEL0                        \ SMPSEL0
$00000200 constant SEC_ADC4_ADC_SMPR_SMPSEL1                        \ SMPSEL1
$00000400 constant SEC_ADC4_ADC_SMPR_SMPSEL2                        \ SMPSEL2
$00000800 constant SEC_ADC4_ADC_SMPR_SMPSEL3                        \ SMPSEL3
$00001000 constant SEC_ADC4_ADC_SMPR_SMPSEL4                        \ SMPSEL4
$00002000 constant SEC_ADC4_ADC_SMPR_SMPSEL5                        \ SMPSEL5
$00004000 constant SEC_ADC4_ADC_SMPR_SMPSEL6                        \ SMPSEL6
$00008000 constant SEC_ADC4_ADC_SMPR_SMPSEL7                        \ SMPSEL7
$00010000 constant SEC_ADC4_ADC_SMPR_SMPSEL8                        \ SMPSEL8
$00020000 constant SEC_ADC4_ADC_SMPR_SMPSEL9                        \ SMPSEL9
$00040000 constant SEC_ADC4_ADC_SMPR_SMPSEL10                       \ SMPSEL10
$00080000 constant SEC_ADC4_ADC_SMPR_SMPSEL11                       \ SMPSEL11
$00100000 constant SEC_ADC4_ADC_SMPR_SMPSEL12                       \ SMPSEL12
$00200000 constant SEC_ADC4_ADC_SMPR_SMPSEL13                       \ SMPSEL13
$00400000 constant SEC_ADC4_ADC_SMPR_SMPSEL14                       \ SMPSEL14
$00800000 constant SEC_ADC4_ADC_SMPR_SMPSEL15                       \ SMPSEL15
$01000000 constant SEC_ADC4_ADC_SMPR_SMPSEL16                       \ SMPSEL16
$02000000 constant SEC_ADC4_ADC_SMPR_SMPSEL17                       \ SMPSEL17
$04000000 constant SEC_ADC4_ADC_SMPR_SMPSEL18                       \ SMPSEL18
$08000000 constant SEC_ADC4_ADC_SMPR_SMPSEL19                       \ SMPSEL19
$10000000 constant SEC_ADC4_ADC_SMPR_SMPSEL20                       \ SMPSEL20
$20000000 constant SEC_ADC4_ADC_SMPR_SMPSEL21                       \ SMPSEL21
$40000000 constant SEC_ADC4_ADC_SMPR_SMPSEL22                       \ SMPSEL22
$80000000 constant SEC_ADC4_ADC_SMPR_SMPSEL23                       \ SMPSEL23


\
\ @brief ADC watchdog threshold register
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant SEC_ADC4_ADC_AWD1TR_LT1                          \ LT1
$0fff0000 constant SEC_ADC4_ADC_AWD1TR_HT1                          \ HT1


\
\ @brief ADC watchdog threshold register
\ Address offset: 0x24
\ Reset value: 0x0FFF0000
\

$00000fff constant SEC_ADC4_ADC_AWD2TR_LT2                          \ LT2
$0fff0000 constant SEC_ADC4_ADC_AWD2TR_HT2                          \ HT2


\
\ @brief ADC channel selection register [alternate]
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00ffffff constant SEC_ADC4_ADC_CHSELRMOD0_CHSEL                    \ CHSEL


\
\ @brief ADC channel selection register [alternate]
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000000f constant SEC_ADC4_ADC_CHSELRMOD1_SQ1                      \ SQ1
$000000f0 constant SEC_ADC4_ADC_CHSELRMOD1_SQ2                      \ SQ2
$00000f00 constant SEC_ADC4_ADC_CHSELRMOD1_SQ3                      \ SQ3
$0000f000 constant SEC_ADC4_ADC_CHSELRMOD1_SQ4                      \ SQ4
$000f0000 constant SEC_ADC4_ADC_CHSELRMOD1_SQ5                      \ SQ5
$00f00000 constant SEC_ADC4_ADC_CHSELRMOD1_SQ6                      \ SQ6
$0f000000 constant SEC_ADC4_ADC_CHSELRMOD1_SQ7                      \ SQ7
$f0000000 constant SEC_ADC4_ADC_CHSELRMOD1_SQ8                      \ SQ8


\
\ @brief ADC watchdog threshold register
\ Address offset: 0x2C
\ Reset value: 0x0FFF0000
\

$00000fff constant SEC_ADC4_ADC_AWD3TR_LT3                          \ LT3
$0fff0000 constant SEC_ADC4_ADC_AWD3TR_HT3                          \ HT3


\
\ @brief ADC data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant SEC_ADC4_ADC_DR_DATA                             \ DATA


\
\ @brief ADC data register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_PWR_AUTOFF                          \ AUTOFF
$00000002 constant SEC_ADC4_ADC_PWR_DPD                             \ DPD
$00000004 constant SEC_ADC4_ADC_PWR_VREFPROT                        \ VREFPROT
$00000008 constant SEC_ADC4_ADC_PWR_VREFSECSMP                      \ VREFSECSMP


\
\ @brief ADC Analog Watchdog 2 Configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_AWD2CR_AWD2CH0                      \ AWD2CH0
$00000002 constant SEC_ADC4_ADC_AWD2CR_AWD2CH1                      \ AWD2CH1
$00000004 constant SEC_ADC4_ADC_AWD2CR_AWD2CH2                      \ AWD2CH2
$00000008 constant SEC_ADC4_ADC_AWD2CR_AWD2CH3                      \ AWD2CH3
$00000010 constant SEC_ADC4_ADC_AWD2CR_AWD2CH4                      \ AWD2CH4
$00000020 constant SEC_ADC4_ADC_AWD2CR_AWD2CH5                      \ AWD2CH5
$00000040 constant SEC_ADC4_ADC_AWD2CR_AWD2CH6                      \ AWD2CH6
$00000080 constant SEC_ADC4_ADC_AWD2CR_AWD2CH7                      \ AWD2CH7
$00000100 constant SEC_ADC4_ADC_AWD2CR_AWD2CH8                      \ AWD2CH8
$00000200 constant SEC_ADC4_ADC_AWD2CR_AWD2CH9                      \ AWD2CH9
$00000400 constant SEC_ADC4_ADC_AWD2CR_AWD2CH10                     \ AWD2CH10
$00000800 constant SEC_ADC4_ADC_AWD2CR_AWD2CH11                     \ AWD2CH11
$00001000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH12                     \ AWD2CH12
$00002000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH13                     \ AWD2CH13
$00004000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH14                     \ AWD2CH14
$00008000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH15                     \ AWD2CH15
$00010000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH16                     \ AWD2CH16
$00020000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH17                     \ AWD2CH17
$00040000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH18                     \ AWD2CH18
$00080000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH19                     \ AWD2CH19
$00100000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH20                     \ AWD2CH20
$00200000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH21                     \ AWD2CH21
$00400000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH22                     \ AWD2CH22
$00800000 constant SEC_ADC4_ADC_AWD2CR_AWD2CH23                     \ AWD2CH23


\
\ @brief ADC Analog Watchdog 3 Configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_AWD3CR_AWD3CH0                      \ AWD3CH0
$00000002 constant SEC_ADC4_ADC_AWD3CR_AWD3CH1                      \ AWD3CH1
$00000004 constant SEC_ADC4_ADC_AWD3CR_AWD3CH2                      \ AWD3CH2
$00000008 constant SEC_ADC4_ADC_AWD3CR_AWD3CH3                      \ AWD3CH3
$00000010 constant SEC_ADC4_ADC_AWD3CR_AWD3CH4                      \ AWD3CH4
$00000020 constant SEC_ADC4_ADC_AWD3CR_AWD3CH5                      \ AWD3CH5
$00000040 constant SEC_ADC4_ADC_AWD3CR_AWD3CH6                      \ AWD3CH6
$00000080 constant SEC_ADC4_ADC_AWD3CR_AWD3CH7                      \ AWD3CH7
$00000100 constant SEC_ADC4_ADC_AWD3CR_AWD3CH8                      \ AWD3CH8
$00000200 constant SEC_ADC4_ADC_AWD3CR_AWD3CH9                      \ AWD3CH9
$00000400 constant SEC_ADC4_ADC_AWD3CR_AWD3CH10                     \ AWD3CH10
$00000800 constant SEC_ADC4_ADC_AWD3CR_AWD3CH11                     \ AWD3CH11
$00001000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH12                     \ AWD3CH12
$00002000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH13                     \ AWD3CH13
$00004000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH14                     \ AWD3CH14
$00008000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH15                     \ AWD3CH15
$00010000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH16                     \ AWD3CH16
$00020000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH17                     \ AWD3CH17
$00040000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH18                     \ AWD3CH18
$00080000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH19                     \ AWD3CH19
$00100000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH20                     \ AWD3CH20
$00200000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH21                     \ AWD3CH21
$00400000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH22                     \ AWD3CH22
$00800000 constant SEC_ADC4_ADC_AWD3CR_AWD3CH23                     \ AWD3CH23


\
\ @brief ADC Calibration factor
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant SEC_ADC4_ADC_CALFACT_CALFACT                     \ CALFACT


\
\ @brief ADC option register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant SEC_ADC4_ADC_OR_CHN21SEL                         \ CHN21SEL


\
\ @brief ADC common configuration register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$003c0000 constant SEC_ADC4_ADC_CCR_PRESC                           \ PRESC
$00400000 constant SEC_ADC4_ADC_CCR_VREFEN                          \ VREFEN
$00800000 constant SEC_ADC4_ADC_CCR_TSEN                            \ TSEN
$01000000 constant SEC_ADC4_ADC_CCR_VBATEN                          \ VBATEN


\
\ @brief ADC4
\
$56021000 constant SEC_ADC4_ADC_ISR  \ offset: 0x00 : ADC interrupt and status register
$56021004 constant SEC_ADC4_ADC_IER  \ offset: 0x04 : ADC interrupt enable register
$56021008 constant SEC_ADC4_ADC_CR  \ offset: 0x08 : ADC control register
$5602100c constant SEC_ADC4_ADC_CFGR1  \ offset: 0x0C : ADC configuration register
$56021010 constant SEC_ADC4_ADC_CFGR2  \ offset: 0x10 : ADC configuration register 2
$56021014 constant SEC_ADC4_ADC_SMPR  \ offset: 0x14 : ADC sample time register
$56021020 constant SEC_ADC4_ADC_AWD1TR  \ offset: 0x20 : ADC watchdog threshold register
$56021024 constant SEC_ADC4_ADC_AWD2TR  \ offset: 0x24 : ADC watchdog threshold register
$56021028 constant SEC_ADC4_ADC_CHSELRMOD0  \ offset: 0x28 : ADC channel selection register [alternate]
$56021028 constant SEC_ADC4_ADC_CHSELRMOD1  \ offset: 0x28 : ADC channel selection register [alternate]
$5602102c constant SEC_ADC4_ADC_AWD3TR  \ offset: 0x2C : ADC watchdog threshold register
$56021040 constant SEC_ADC4_ADC_DR  \ offset: 0x40 : ADC data register
$56021044 constant SEC_ADC4_ADC_PWR  \ offset: 0x44 : ADC data register
$560210a0 constant SEC_ADC4_ADC_AWD2CR  \ offset: 0xA0 : ADC Analog Watchdog 2 Configuration register
$560210a4 constant SEC_ADC4_ADC_AWD3CR  \ offset: 0xA4 : ADC Analog Watchdog 3 Configuration register
$560210b4 constant SEC_ADC4_ADC_CALFACT  \ offset: 0xB4 : ADC Calibration factor
$560210d0 constant SEC_ADC4_ADC_OR  \ offset: 0xD0 : ADC option register
$56021308 constant SEC_ADC4_ADC_CCR  \ offset: 0x308 : ADC common configuration register

