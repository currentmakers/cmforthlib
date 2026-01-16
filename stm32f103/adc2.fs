\
\ @file adc2.fs
\ @brief Analog to digital converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ADC2_SR_AWD                                      \ Analog watchdog flag
$00000002 constant ADC2_SR_EOC                                      \ Regular channel end of conversion
$00000004 constant ADC2_SR_JEOC                                     \ Injected channel end of conversion
$00000008 constant ADC2_SR_JSTRT                                    \ Injected channel start flag
$00000010 constant ADC2_SR_STRT                                     \ Regular channel start flag


\
\ @brief control register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant ADC2_CR1_AWDCH                                   \ Analog watchdog channel select bits
$00000020 constant ADC2_CR1_EOCIE                                   \ Interrupt enable for EOC
$00000040 constant ADC2_CR1_AWDIE                                   \ Analog watchdog interrupt enable
$00000080 constant ADC2_CR1_JEOCIE                                  \ Interrupt enable for injected channels
$00000100 constant ADC2_CR1_SCAN                                    \ Scan mode
$00000200 constant ADC2_CR1_AWDSGL                                  \ Enable the watchdog on a single channel in scan mode
$00000400 constant ADC2_CR1_JAUTO                                   \ Automatic injected group conversion
$00000800 constant ADC2_CR1_DISCEN                                  \ Discontinuous mode on regular channels
$00001000 constant ADC2_CR1_JDISCEN                                 \ Discontinuous mode on injected channels
$0000e000 constant ADC2_CR1_DISCNUM                                 \ Discontinuous mode channel count
$00400000 constant ADC2_CR1_JAWDEN                                  \ Analog watchdog enable on injected channels
$00800000 constant ADC2_CR1_AWDEN                                   \ Analog watchdog enable on regular channels


\
\ @brief control register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ADC2_CR2_ADON                                    \ A/D converter ON / OFF
$00000002 constant ADC2_CR2_CONT                                    \ Continuous conversion
$00000004 constant ADC2_CR2_CAL                                     \ A/D calibration
$00000008 constant ADC2_CR2_RSTCAL                                  \ Reset calibration
$00000100 constant ADC2_CR2_DMA                                     \ Direct memory access mode
$00000800 constant ADC2_CR2_ALIGN                                   \ Data alignment
$00007000 constant ADC2_CR2_JEXTSEL                                 \ External event select for injected group
$00008000 constant ADC2_CR2_JEXTTRIG                                \ External trigger conversion mode for injected channels
$000e0000 constant ADC2_CR2_EXTSEL                                  \ External event select for regular group
$00100000 constant ADC2_CR2_EXTTRIG                                 \ External trigger conversion mode for regular channels
$00200000 constant ADC2_CR2_JSWSTART                                \ Start conversion of injected channels
$00400000 constant ADC2_CR2_SWSTART                                 \ Start conversion of regular channels
$00800000 constant ADC2_CR2_TSVREFE                                 \ Temperature sensor and VREFINT enable


\
\ @brief sample time register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000007 constant ADC2_SMPR1_SMP10                                 \ Channel 10 sample time selection
$00000038 constant ADC2_SMPR1_SMP11                                 \ Channel 11 sample time selection
$000001c0 constant ADC2_SMPR1_SMP12                                 \ Channel 12 sample time selection
$00000e00 constant ADC2_SMPR1_SMP13                                 \ Channel 13 sample time selection
$00007000 constant ADC2_SMPR1_SMP14                                 \ Channel 14 sample time selection
$00038000 constant ADC2_SMPR1_SMP15                                 \ Channel 15 sample time selection
$001c0000 constant ADC2_SMPR1_SMP16                                 \ Channel 16 sample time selection
$00e00000 constant ADC2_SMPR1_SMP17                                 \ Channel 17 sample time selection


\
\ @brief sample time register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000007 constant ADC2_SMPR2_SMP0                                  \ Channel 0 sample time selection
$00000038 constant ADC2_SMPR2_SMP1                                  \ Channel 1 sample time selection
$000001c0 constant ADC2_SMPR2_SMP2                                  \ Channel 2 sample time selection
$00000e00 constant ADC2_SMPR2_SMP3                                  \ Channel 3 sample time selection
$00007000 constant ADC2_SMPR2_SMP4                                  \ Channel 4 sample time selection
$00038000 constant ADC2_SMPR2_SMP5                                  \ Channel 5 sample time selection
$001c0000 constant ADC2_SMPR2_SMP6                                  \ Channel 6 sample time selection
$00e00000 constant ADC2_SMPR2_SMP7                                  \ Channel 7 sample time selection
$07000000 constant ADC2_SMPR2_SMP8                                  \ Channel 8 sample time selection
$38000000 constant ADC2_SMPR2_SMP9                                  \ Channel 9 sample time selection


\
\ @brief injected channel data offset register x
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant ADC2_JOFR1_JOFFSET1                              \ Data offset for injected channel x


\
\ @brief injected channel data offset register x
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000fff constant ADC2_JOFR2_JOFFSET2                              \ Data offset for injected channel x


\
\ @brief injected channel data offset register x
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000fff constant ADC2_JOFR3_JOFFSET3                              \ Data offset for injected channel x


\
\ @brief injected channel data offset register x
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant ADC2_JOFR4_JOFFSET4                              \ Data offset for injected channel x


\
\ @brief watchdog higher threshold register
\ Address offset: 0x24
\ Reset value: 0x00000FFF
\

$00000fff constant ADC2_HTR_HT                                      \ Analog watchdog higher threshold


\
\ @brief watchdog lower threshold register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000fff constant ADC2_LTR_LT                                      \ Analog watchdog lower threshold


\
\ @brief regular sequence register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000001f constant ADC2_SQR1_SQ13                                   \ 13th conversion in regular sequence
$000003e0 constant ADC2_SQR1_SQ14                                   \ 14th conversion in regular sequence
$00007c00 constant ADC2_SQR1_SQ15                                   \ 15th conversion in regular sequence
$000f8000 constant ADC2_SQR1_SQ16                                   \ 16th conversion in regular sequence
$00f00000 constant ADC2_SQR1_L                                      \ Regular channel sequence length


\
\ @brief regular sequence register 2
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000001f constant ADC2_SQR2_SQ7                                    \ 7th conversion in regular sequence
$000003e0 constant ADC2_SQR2_SQ8                                    \ 8th conversion in regular sequence
$00007c00 constant ADC2_SQR2_SQ9                                    \ 9th conversion in regular sequence
$000f8000 constant ADC2_SQR2_SQ10                                   \ 10th conversion in regular sequence
$01f00000 constant ADC2_SQR2_SQ11                                   \ 11th conversion in regular sequence
$3e000000 constant ADC2_SQR2_SQ12                                   \ 12th conversion in regular sequence


\
\ @brief regular sequence register 3
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC2_SQR3_SQ1                                    \ 1st conversion in regular sequence
$000003e0 constant ADC2_SQR3_SQ2                                    \ 2nd conversion in regular sequence
$00007c00 constant ADC2_SQR3_SQ3                                    \ 3rd conversion in regular sequence
$000f8000 constant ADC2_SQR3_SQ4                                    \ 4th conversion in regular sequence
$01f00000 constant ADC2_SQR3_SQ5                                    \ 5th conversion in regular sequence
$3e000000 constant ADC2_SQR3_SQ6                                    \ 6th conversion in regular sequence


\
\ @brief injected sequence register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC2_JSQR_JSQ1                                   \ 1st conversion in injected sequence
$000003e0 constant ADC2_JSQR_JSQ2                                   \ 2nd conversion in injected sequence
$00007c00 constant ADC2_JSQR_JSQ3                                   \ 3rd conversion in injected sequence
$000f8000 constant ADC2_JSQR_JSQ4                                   \ 4th conversion in injected sequence
$00300000 constant ADC2_JSQR_JL                                     \ Injected sequence length


\
\ @brief injected data register x
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant ADC2_JDR1_JDATA                                  \ Injected data


\
\ @brief injected data register x
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC2_JDR2_JDATA                                  \ Injected data


\
\ @brief injected data register x
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant ADC2_JDR3_JDATA                                  \ Injected data


\
\ @brief injected data register x
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant ADC2_JDR4_JDATA                                  \ Injected data


\
\ @brief regular data register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant ADC2_DR_DATA                                     \ Regular data


\
\ @brief Analog to digital converter
\
$40012800 constant ADC2_SR        \ offset: 0x00 : status register
$40012804 constant ADC2_CR1       \ offset: 0x04 : control register 1
$40012808 constant ADC2_CR2       \ offset: 0x08 : control register 2
$4001280c constant ADC2_SMPR1     \ offset: 0x0C : sample time register 1
$40012810 constant ADC2_SMPR2     \ offset: 0x10 : sample time register 2
$40012814 constant ADC2_JOFR1     \ offset: 0x14 : injected channel data offset register x
$40012818 constant ADC2_JOFR2     \ offset: 0x18 : injected channel data offset register x
$4001281c constant ADC2_JOFR3     \ offset: 0x1C : injected channel data offset register x
$40012820 constant ADC2_JOFR4     \ offset: 0x20 : injected channel data offset register x
$40012824 constant ADC2_HTR       \ offset: 0x24 : watchdog higher threshold register
$40012828 constant ADC2_LTR       \ offset: 0x28 : watchdog lower threshold register
$4001282c constant ADC2_SQR1      \ offset: 0x2C : regular sequence register 1
$40012830 constant ADC2_SQR2      \ offset: 0x30 : regular sequence register 2
$40012834 constant ADC2_SQR3      \ offset: 0x34 : regular sequence register 3
$40012838 constant ADC2_JSQR      \ offset: 0x38 : injected sequence register
$4001283c constant ADC2_JDR1      \ offset: 0x3C : injected data register x
$40012840 constant ADC2_JDR2      \ offset: 0x40 : injected data register x
$40012844 constant ADC2_JDR3      \ offset: 0x44 : injected data register x
$40012848 constant ADC2_JDR4      \ offset: 0x48 : injected data register x
$4001284c constant ADC2_DR        \ offset: 0x4C : regular data register

