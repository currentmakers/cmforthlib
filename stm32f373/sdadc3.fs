\
\ @file sdadc3.fs
\ @brief ADC sigma delta 3 (SDADC3) global         interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SDADC3_CR1_EOCALIE                               \ End of calibration interrupt enable
$00000002 constant SDADC3_CR1_JEOCIE                                \ Injected end of conversion interrupt enable
$00000004 constant SDADC3_CR1_JOVRIE                                \ Injected data overrun interrupt enable
$00000008 constant SDADC3_CR1_REOCIE                                \ Regular end of conversion interrupt enable
$00000010 constant SDADC3_CR1_ROVRIE                                \ Regular data overrun interrupt enable
$00000300 constant SDADC3_CR1_REFV                                  \ Reference voltage selection
$00000400 constant SDADC3_CR1_SLOWCK                                \ Slow clock mode enable
$00000800 constant SDADC3_CR1_SBI                                   \ Enter Standby mode when idle
$00001000 constant SDADC3_CR1_PDI                                   \ Enter power down mode when idle
$00004000 constant SDADC3_CR1_JSYNC                                 \ Launch a injected conversion synchronously with SDADC1
$00008000 constant SDADC3_CR1_RSYNC                                 \ Launch regular conversion synchronously with SDADC1
$00010000 constant SDADC3_CR1_JDMAEN                                \ DMA channel enabled to read data for the injected channel group
$00020000 constant SDADC3_CR1_RDMAEN                                \ DMA channel enabled to read data for the regular channel
$80000000 constant SDADC3_CR1_INIT                                  \ Initialization mode request


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SDADC3_CR2_ADON                                  \ SDADC enable
$00000006 constant SDADC3_CR2_CALIBCNT                              \ Number of calibration sequences to be performed (number of valid configurations)
$00000010 constant SDADC3_CR2_STARTCALIB                            \ Start calibration
$00000020 constant SDADC3_CR2_JCONT                                 \ Continuous mode selection for injected conversions
$00000040 constant SDADC3_CR2_JDS                                   \ Delay start of injected conversions.
$00000f00 constant SDADC3_CR2_JEXTSEL                               \ Trigger signal selection for launching injected conversions
$00006000 constant SDADC3_CR2_JEXTEN                                \ Trigger enable and trigger edge selection for injected conversions
$00008000 constant SDADC3_CR2_JSWSTART                              \ Start a conversion of the injected group of channels
$000f0000 constant SDADC3_CR2_RCH                                   \ Regular channel selection
$00400000 constant SDADC3_CR2_RCONT                                 \ Continuous mode selection for regular conversions
$00800000 constant SDADC3_CR2_RSWSTART                              \ Software start of a conversion on the regular channel
$01000000 constant SDADC3_CR2_FAST                                  \ Fast conversion mode selection


\
\ @brief interrupt and status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SDADC3_ISR_EOCALF                                \ End of calibration flag
$00000002 constant SDADC3_ISR_JEOCF                                 \ End of injected conversion flag
$00000004 constant SDADC3_ISR_JOVRF                                 \ Injected conversion overrun flag
$00000008 constant SDADC3_ISR_REOCF                                 \ End of regular conversion flag
$00000010 constant SDADC3_ISR_ROVRF                                 \ Regular conversion overrun flag
$00001000 constant SDADC3_ISR_CALIBIP                               \ Calibration in progress status
$00002000 constant SDADC3_ISR_JCIP                                  \ Injected conversion in progress status
$00004000 constant SDADC3_ISR_RCIP                                  \ Regular conversion in progress status
$00008000 constant SDADC3_ISR_STABIP                                \ Stabilization in progress status
$80000000 constant SDADC3_ISR_INITRDY                               \ Initialization mode is ready


\
\ @brief interrupt and status clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SDADC3_CLRISR_CLREOCALF                          \ Clear the end of calibration flag
$00000004 constant SDADC3_CLRISR_CLRJOVRF                           \ Clear the injected conversion overrun flag
$00000010 constant SDADC3_CLRISR_CLRROVRF                           \ Clear the regular conversion overrun flag


\
\ @brief injected channel group selection register
\ Address offset: 0x14
\ Reset value: 0x00000001
\

$000001ff constant SDADC3_JCHGR_JCHG                                \ Injected channel group selection


\
\ @brief configuration 0 register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant SDADC3_CONF0R_OFFSET0                            \ Twelve-bit calibration offset for configuration 0
$00700000 constant SDADC3_CONF0R_GAIN0                              \ Gain setting for configuration 0
$0c000000 constant SDADC3_CONF0R_SE0                                \ Single-ended mode for configuration 0
$c0000000 constant SDADC3_CONF0R_COMMON0                            \ Common mode for configuration 0


\
\ @brief configuration 1 register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000fff constant SDADC3_CONF1R_OFFSET1                            \ Twelve-bit calibration offset for configuration 1
$00700000 constant SDADC3_CONF1R_GAIN1                              \ Gain setting for configuration 1
$0c000000 constant SDADC3_CONF1R_SE1                                \ Single-ended mode for configuration 1
$c0000000 constant SDADC3_CONF1R_COMMON1                            \ Common mode for configuration 1


\
\ @brief configuration 2 register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000fff constant SDADC3_CONF2R_OFFSET2                            \ Twelve-bit calibration offset for configuration 2
$00700000 constant SDADC3_CONF2R_GAIN2                              \ Gain setting for configuration 2
$0c000000 constant SDADC3_CONF2R_SE2                                \ Single-ended mode for configuration 2
$c0000000 constant SDADC3_CONF2R_COMMON2                            \ Common mode for configuration 2


\
\ @brief channel configuration register 1
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000003 constant SDADC3_CONFCHR1_CONFCH0                          \ CONFCH0
$00000030 constant SDADC3_CONFCHR1_CONFCH1                          \ CONFCH1
$00000300 constant SDADC3_CONFCHR1_CONFCH2                          \ CONFCH2
$00003000 constant SDADC3_CONFCHR1_CONFCH3                          \ CONFCH3
$00030000 constant SDADC3_CONFCHR1_CONFCH4                          \ CONFCH4
$00300000 constant SDADC3_CONFCHR1_CONFCH5                          \ CONFCH5
$03000000 constant SDADC3_CONFCHR1_CONFCH6                          \ CONFCH6
$30000000 constant SDADC3_CONFCHR1_CONFCH7                          \ CONFCH7


\
\ @brief channel configuration register 2
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000003 constant SDADC3_CONFCHR2_CONFCH8                          \ Channel 8 configuration


\
\ @brief data register for injected group
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant SDADC3_JDATAR_JDATA                              \ Injected group conversion data
$1e000000 constant SDADC3_JDATAR_JDATACH                            \ Injected channel most recently converted


\
\ @brief data register for the regular channel
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant SDADC3_RDATAR_RDATA                              \ Regular channel conversion data


\
\ @brief SDADC1 and SDADC2 injected data register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant SDADC3_JDATA12R_JDATA1                           \ Injected group conversion data for SDADC1
$ffff0000 constant SDADC3_JDATA12R_JDATA2                           \ Injected group conversion data for SDADC2


\
\ @brief SDADC1 and SDADC2 regular data register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000ffff constant SDADC3_RDATA12R_RDATA1                           \ Regular conversion data for SDADC1
$ffff0000 constant SDADC3_RDATA12R_RDATA2                           \ Regular conversion data for SDADC2


\
\ @brief SDADC1 and SDADC3 injected data register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000ffff constant SDADC3_JDATA13R_JDATA1                           \ Injected group conversion data for SDADC1
$ffff0000 constant SDADC3_JDATA13R_JDATA3                           \ Injected group conversion data for SDADC3


\
\ @brief SDADC1 and SDADC3 regular data register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000ffff constant SDADC3_RDATA13R_RDATA1                           \ Regular conversion data for SDADC1
$ffff0000 constant SDADC3_RDATA13R_RDATA3                           \ Regular conversion data for SDADC3


\
\ @brief ADC sigma delta 3 (SDADC3) global interrupt
\
$40016800 constant SDADC3_CR1     \ offset: 0x00 : control register 1
$40016804 constant SDADC3_CR2     \ offset: 0x04 : control register 2
$40016808 constant SDADC3_ISR     \ offset: 0x08 : interrupt and status register
$4001680c constant SDADC3_CLRISR  \ offset: 0x0C : interrupt and status clear register
$40016814 constant SDADC3_JCHGR   \ offset: 0x14 : injected channel group selection register
$40016820 constant SDADC3_CONF0R  \ offset: 0x20 : configuration 0 register
$40016824 constant SDADC3_CONF1R  \ offset: 0x24 : configuration 1 register
$40016828 constant SDADC3_CONF2R  \ offset: 0x28 : configuration 2 register
$40016840 constant SDADC3_CONFCHR1  \ offset: 0x40 : channel configuration register 1
$40016844 constant SDADC3_CONFCHR2  \ offset: 0x44 : channel configuration register 2
$40016860 constant SDADC3_JDATAR  \ offset: 0x60 : data register for injected group
$40016864 constant SDADC3_RDATAR  \ offset: 0x64 : data register for the regular channel
$40016870 constant SDADC3_JDATA12R  \ offset: 0x70 : SDADC1 and SDADC2 injected data register
$40016874 constant SDADC3_RDATA12R  \ offset: 0x74 : SDADC1 and SDADC2 regular data register
$40016878 constant SDADC3_JDATA13R  \ offset: 0x78 : SDADC1 and SDADC3 injected data register
$4001687c constant SDADC3_RDATA13R  \ offset: 0x7C : SDADC1 and SDADC3 regular data register

