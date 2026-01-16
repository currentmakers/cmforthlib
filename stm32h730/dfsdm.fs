\
\ @file dfsdm.fs
\ @brief Digital filter for sigma delta       modulators
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief channel configuration y register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CH0CFGR1_SITP                              \ SITP
$0000000c constant DFSDM_CH0CFGR1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CH0CFGR1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CH0CFGR1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CH0CFGR1_CHEN                              \ CHEN
$00000100 constant DFSDM_CH0CFGR1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CH0CFGR1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CH0CFGR1_DATPACK                           \ DATPACK
$00ff0000 constant DFSDM_CH0CFGR1_CKOUTDIV                          \ CKOUTDIV
$40000000 constant DFSDM_CH0CFGR1_CKOUTSRC                          \ CKOUTSRC
$80000000 constant DFSDM_CH0CFGR1_DFSDMEN                           \ DFSDMEN


\
\ @brief channel configuration y register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CH0CFGR2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CH0CFGR2_OFFSET                            \ OFFSET


\
\ @brief analog watchdog and short-circuit detector register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_CH0AWSCDR_SCDT                             \ SCDT
$0000f000 constant DFSDM_CH0AWSCDR_BKSCD                            \ BKSCD
$001f0000 constant DFSDM_CH0AWSCDR_AWFOSR                           \ AWFOSR
$00c00000 constant DFSDM_CH0AWSCDR_AWFORD                           \ AWFORD


\
\ @brief channel watchdog filter data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH0WDATR_WDATA                             \ WDATA


\
\ @brief channel data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH0DATINR_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CH0DATINR_INDAT1                           \ INDAT1


\
\ @brief channel y delay register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_CH0DLYR_PLSSKP                             \ PLSSKP


\
\ @brief CH1CFGR1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CH1CFGR1_SITP                              \ SITP
$0000000c constant DFSDM_CH1CFGR1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CH1CFGR1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CH1CFGR1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CH1CFGR1_CHEN                              \ CHEN
$00000100 constant DFSDM_CH1CFGR1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CH1CFGR1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CH1CFGR1_DATPACK                           \ DATPACK


\
\ @brief CH1CFGR2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CH1CFGR2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CH1CFGR2_OFFSET                            \ OFFSET


\
\ @brief CH1AWSCDR
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_CH1AWSCDR_SCDT                             \ SCDT
$0000f000 constant DFSDM_CH1AWSCDR_BKSCD                            \ BKSCD
$001f0000 constant DFSDM_CH1AWSCDR_AWFOSR                           \ AWFOSR
$00c00000 constant DFSDM_CH1AWSCDR_AWFORD                           \ AWFORD


\
\ @brief CH1WDATR
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH1WDATR_WDATA                             \ WDATA


\
\ @brief CH1DATINR
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH1DATINR_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CH1DATINR_INDAT1                           \ INDAT1


\
\ @brief channel y delay register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_CH1DLYR_PLSSKP                             \ PLSSKP


\
\ @brief CH2CFGR1
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CH2CFGR1_SITP                              \ SITP
$0000000c constant DFSDM_CH2CFGR1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CH2CFGR1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CH2CFGR1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CH2CFGR1_CHEN                              \ CHEN
$00000100 constant DFSDM_CH2CFGR1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CH2CFGR1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CH2CFGR1_DATPACK                           \ DATPACK


\
\ @brief CH2CFGR2
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CH2CFGR2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CH2CFGR2_OFFSET                            \ OFFSET


\
\ @brief CH2AWSCDR
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_CH2AWSCDR_SCDT                             \ SCDT
$0000f000 constant DFSDM_CH2AWSCDR_BKSCD                            \ BKSCD
$001f0000 constant DFSDM_CH2AWSCDR_AWFOSR                           \ AWFOSR
$00c00000 constant DFSDM_CH2AWSCDR_AWFORD                           \ AWFORD


\
\ @brief CH2WDATR
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH2WDATR_WDATA                             \ WDATA


\
\ @brief CH2DATINR
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH2DATINR_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CH2DATINR_INDAT1                           \ INDAT1


\
\ @brief channel y delay register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_CH2DLYR_PLSSKP                             \ PLSSKP


\
\ @brief CH3CFGR1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CH3CFGR1_SITP                              \ SITP
$0000000c constant DFSDM_CH3CFGR1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CH3CFGR1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CH3CFGR1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CH3CFGR1_CHEN                              \ CHEN
$00000100 constant DFSDM_CH3CFGR1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CH3CFGR1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CH3CFGR1_DATPACK                           \ DATPACK


\
\ @brief CH3CFGR2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CH3CFGR2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CH3CFGR2_OFFSET                            \ OFFSET


\
\ @brief CH3AWSCDR
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_CH3AWSCDR_SCDT                             \ SCDT
$0000f000 constant DFSDM_CH3AWSCDR_BKSCD                            \ BKSCD
$001f0000 constant DFSDM_CH3AWSCDR_AWFOSR                           \ AWFOSR
$00c00000 constant DFSDM_CH3AWSCDR_AWFORD                           \ AWFORD


\
\ @brief CH3WDATR
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH3WDATR_WDATA                             \ WDATA


\
\ @brief CH3DATINR
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH3DATINR_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CH3DATINR_INDAT1                           \ INDAT1


\
\ @brief channel y delay register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_CH3DLYR_PLSSKP                             \ PLSSKP


\
\ @brief CH4CFGR1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CH4CFGR1_SITP                              \ SITP
$0000000c constant DFSDM_CH4CFGR1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CH4CFGR1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CH4CFGR1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CH4CFGR1_CHEN                              \ CHEN
$00000100 constant DFSDM_CH4CFGR1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CH4CFGR1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CH4CFGR1_DATPACK                           \ DATPACK


\
\ @brief CH4CFGR2
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CH4CFGR2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CH4CFGR2_OFFSET                            \ OFFSET


\
\ @brief CH4AWSCDR
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_CH4AWSCDR_SCDT                             \ SCDT
$0000f000 constant DFSDM_CH4AWSCDR_BKSCD                            \ BKSCD
$001f0000 constant DFSDM_CH4AWSCDR_AWFOSR                           \ AWFOSR
$00c00000 constant DFSDM_CH4AWSCDR_AWFORD                           \ AWFORD


\
\ @brief CH4WDATR
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH4WDATR_WDATA                             \ WDATA


\
\ @brief CH4DATINR
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH4DATINR_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CH4DATINR_INDAT1                           \ INDAT1


\
\ @brief channel y delay register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_CH4DLYR_PLSSKP                             \ PLSSKP


\
\ @brief CH5CFGR1
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CH5CFGR1_SITP                              \ SITP
$0000000c constant DFSDM_CH5CFGR1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CH5CFGR1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CH5CFGR1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CH5CFGR1_CHEN                              \ CHEN
$00000100 constant DFSDM_CH5CFGR1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CH5CFGR1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CH5CFGR1_DATPACK                           \ DATPACK


\
\ @brief CH5CFGR2
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CH5CFGR2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CH5CFGR2_OFFSET                            \ OFFSET


\
\ @brief CH5AWSCDR
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_CH5AWSCDR_SCDT                             \ SCDT
$0000f000 constant DFSDM_CH5AWSCDR_BKSCD                            \ BKSCD
$001f0000 constant DFSDM_CH5AWSCDR_AWFOSR                           \ AWFOSR
$00c00000 constant DFSDM_CH5AWSCDR_AWFORD                           \ AWFORD


\
\ @brief CH5WDATR
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH5WDATR_WDATA                             \ WDATA


\
\ @brief CH5DATINR
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH5DATINR_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CH5DATINR_INDAT1                           \ INDAT1


\
\ @brief channel y delay register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_CH5DLYR_PLSSKP                             \ PLSSKP


\
\ @brief CH6CFGR1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CH6CFGR1_SITP                              \ SITP
$0000000c constant DFSDM_CH6CFGR1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CH6CFGR1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CH6CFGR1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CH6CFGR1_CHEN                              \ CHEN
$00000100 constant DFSDM_CH6CFGR1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CH6CFGR1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CH6CFGR1_DATPACK                           \ DATPACK


\
\ @brief CH6CFGR2
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CH6CFGR2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CH6CFGR2_OFFSET                            \ OFFSET


\
\ @brief CH6AWSCDR
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_CH6AWSCDR_SCDT                             \ SCDT
$0000f000 constant DFSDM_CH6AWSCDR_BKSCD                            \ BKSCD
$001f0000 constant DFSDM_CH6AWSCDR_AWFOSR                           \ AWFOSR
$00c00000 constant DFSDM_CH6AWSCDR_AWFORD                           \ AWFORD


\
\ @brief CH6WDATR
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH6WDATR_WDATA                             \ WDATA


\
\ @brief CH6DATINR
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH6DATINR_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CH6DATINR_INDAT1                           \ INDAT1


\
\ @brief channel y delay register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_CH6DLYR_PLSSKP                             \ PLSSKP


\
\ @brief CH7CFGR1
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CH7CFGR1_SITP                              \ SITP
$0000000c constant DFSDM_CH7CFGR1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CH7CFGR1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CH7CFGR1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CH7CFGR1_CHEN                              \ CHEN
$00000100 constant DFSDM_CH7CFGR1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CH7CFGR1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CH7CFGR1_DATPACK                           \ DATPACK


\
\ @brief CH7CFGR2
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CH7CFGR2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CH7CFGR2_OFFSET                            \ OFFSET


\
\ @brief CH7AWSCDR
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_CH7AWSCDR_SCDT                             \ SCDT
$0000f000 constant DFSDM_CH7AWSCDR_BKSCD                            \ BKSCD
$001f0000 constant DFSDM_CH7AWSCDR_AWFOSR                           \ AWFOSR
$00c00000 constant DFSDM_CH7AWSCDR_AWFORD                           \ AWFORD


\
\ @brief CH7WDATR
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH7WDATR_WDATA                             \ WDATA


\
\ @brief CH7DATINR
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CH7DATINR_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CH7DATINR_INDAT1                           \ INDAT1


\
\ @brief channel y delay register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM_CH7DLYR_PLSSKP                             \ PLSSKP


\
\ @brief control register 1
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT0CR1_DFEN                         \ DFSDM enable
$00000002 constant DFSDM_DFSDM_FLT0CR1_JSWSTART                     \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM_FLT0CR1_JSYNC                        \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM_FLT0CR1_JSCAN                        \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM_FLT0CR1_JDMAEN                       \ DMA channel enabled to read data for the injected channel group
$00000700 constant DFSDM_DFSDM_FLT0CR1_JEXTSEL                      \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM_FLT0CR1_JEXTEN                       \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM_FLT0CR1_RSWSTART                     \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM_FLT0CR1_RCONT                        \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM_FLT0CR1_RSYNC                        \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM_FLT0CR1_RDMAEN                       \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM_FLT0CR1_RCH                          \ Regular channel selection
$20000000 constant DFSDM_DFSDM_FLT0CR1_FAST                         \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM_FLT0CR1_AWFSEL                       \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT0CR2_JEOCIE                       \ Injected end of conversion interrupt enable
$00000002 constant DFSDM_DFSDM_FLT0CR2_REOCIE                       \ Regular end of conversion interrupt enable
$00000004 constant DFSDM_DFSDM_FLT0CR2_JOVRIE                       \ Injected data overrun interrupt enable
$00000008 constant DFSDM_DFSDM_FLT0CR2_ROVRIE                       \ Regular data overrun interrupt enable
$00000010 constant DFSDM_DFSDM_FLT0CR2_AWDIE                        \ Analog watchdog interrupt enable
$00000020 constant DFSDM_DFSDM_FLT0CR2_SCDIE                        \ Short-circuit detector interrupt enable
$00000040 constant DFSDM_DFSDM_FLT0CR2_CKABIE                       \ Clock absence interrupt enable
$0000ff00 constant DFSDM_DFSDM_FLT0CR2_EXCH                         \ Extremes detector channel selection
$00ff0000 constant DFSDM_DFSDM_FLT0CR2_AWDCH                        \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x108
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM_FLT0ISR_JEOCF                        \ End of injected conversion flag
$00000002 constant DFSDM_DFSDM_FLT0ISR_REOCF                        \ End of regular conversion flag
$00000004 constant DFSDM_DFSDM_FLT0ISR_JOVRF                        \ Injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT0ISR_ROVRF                        \ Regular conversion overrun flag
$00000010 constant DFSDM_DFSDM_FLT0ISR_AWDF                         \ Analog watchdog
$00002000 constant DFSDM_DFSDM_FLT0ISR_JCIP                         \ Injected conversion in progress status
$00004000 constant DFSDM_DFSDM_FLT0ISR_RCIP                         \ Regular conversion in progress status
$00ff0000 constant DFSDM_DFSDM_FLT0ISR_CKABF                        \ Clock absence flag
$ff000000 constant DFSDM_DFSDM_FLT0ISR_SCDF                         \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM_FLT0ICR_CLRJOVRF                     \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT0ICR_CLRROVRF                     \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM_FLT0ICR_CLRCKABF                     \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM_FLT0ICR_CLRSCDF                      \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x110
\ Reset value: 0x00000001
\

$000000ff constant DFSDM_DFSDM_FLT0JCHGR_JCHG                       \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT0FCR_IOSR                         \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM_FLT0FCR_FOSR                         \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM_FLT0FCR_FORD                         \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM_FLT0JDATAR_JDATACH                   \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM_FLT0JDATAR_JDATA                     \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM_FLT0RDATAR_RDATACH                   \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM_FLT0RDATAR_RPEND                     \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM_FLT0RDATAR_RDATA                     \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT0AWHTR_BKAWH                      \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM_FLT0AWHTR_AWHT                       \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT0AWLTR_BKAWL                      \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM_FLT0AWLTR_AWLT                       \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT0AWSR_AWLTF                       \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM_FLT0AWSR_AWHTF                       \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT0AWCFR_CLRAWLTF                   \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM_FLT0AWCFR_CLRAWHTF                   \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x130
\ Reset value: 0x80000000
\

$00000007 constant DFSDM_DFSDM_FLT0EXMAX_EXMAXCH                    \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM_FLT0EXMAX_EXMAX                      \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x134
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM_DFSDM_FLT0EXMIN_EXMINCH                    \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM_FLT0EXMIN_EXMIN                      \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM_FLT0CNVTIMR_CNVCNT                   \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief control register 1
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT1CR1_DFEN                         \ DFSDM enable
$00000002 constant DFSDM_DFSDM_FLT1CR1_JSWSTART                     \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM_FLT1CR1_JSYNC                        \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM_FLT1CR1_JSCAN                        \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM_FLT1CR1_JDMAEN                       \ DMA channel enabled to read data for the injected channel group
$00000700 constant DFSDM_DFSDM_FLT1CR1_JEXTSEL                      \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM_FLT1CR1_JEXTEN                       \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM_FLT1CR1_RSWSTART                     \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM_FLT1CR1_RCONT                        \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM_FLT1CR1_RSYNC                        \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM_FLT1CR1_RDMAEN                       \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM_FLT1CR1_RCH                          \ Regular channel selection
$20000000 constant DFSDM_DFSDM_FLT1CR1_FAST                         \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM_FLT1CR1_AWFSEL                       \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT1CR2_JEOCIE                       \ Injected end of conversion interrupt enable
$00000002 constant DFSDM_DFSDM_FLT1CR2_REOCIE                       \ Regular end of conversion interrupt enable
$00000004 constant DFSDM_DFSDM_FLT1CR2_JOVRIE                       \ Injected data overrun interrupt enable
$00000008 constant DFSDM_DFSDM_FLT1CR2_ROVRIE                       \ Regular data overrun interrupt enable
$00000010 constant DFSDM_DFSDM_FLT1CR2_AWDIE                        \ Analog watchdog interrupt enable
$00000020 constant DFSDM_DFSDM_FLT1CR2_SCDIE                        \ Short-circuit detector interrupt enable
$00000040 constant DFSDM_DFSDM_FLT1CR2_CKABIE                       \ Clock absence interrupt enable
$0000ff00 constant DFSDM_DFSDM_FLT1CR2_EXCH                         \ Extremes detector channel selection
$00ff0000 constant DFSDM_DFSDM_FLT1CR2_AWDCH                        \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x188
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM_FLT1ISR_JEOCF                        \ End of injected conversion flag
$00000002 constant DFSDM_DFSDM_FLT1ISR_REOCF                        \ End of regular conversion flag
$00000004 constant DFSDM_DFSDM_FLT1ISR_JOVRF                        \ Injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT1ISR_ROVRF                        \ Regular conversion overrun flag
$00000010 constant DFSDM_DFSDM_FLT1ISR_AWDF                         \ Analog watchdog
$00002000 constant DFSDM_DFSDM_FLT1ISR_JCIP                         \ Injected conversion in progress status
$00004000 constant DFSDM_DFSDM_FLT1ISR_RCIP                         \ Regular conversion in progress status
$00ff0000 constant DFSDM_DFSDM_FLT1ISR_CKABF                        \ Clock absence flag
$ff000000 constant DFSDM_DFSDM_FLT1ISR_SCDF                         \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM_FLT1ICR_CLRJOVRF                     \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT1ICR_CLRROVRF                     \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM_FLT1ICR_CLRCKABF                     \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM_FLT1ICR_CLRSCDF                      \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x190
\ Reset value: 0x00000001
\

$000000ff constant DFSDM_DFSDM_FLT1CHGR_JCHG                        \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT1FCR_IOSR                         \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM_FLT1FCR_FOSR                         \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM_FLT1FCR_FORD                         \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM_FLT1JDATAR_JDATACH                   \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM_FLT1JDATAR_JDATA                     \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM_FLT1RDATAR_RDATACH                   \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM_FLT1RDATAR_RPEND                     \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM_FLT1RDATAR_RDATA                     \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT1AWHTR_BKAWH                      \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM_FLT1AWHTR_AWHT                       \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT1AWLTR_BKAWL                      \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM_FLT1AWLTR_AWLT                       \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT1AWSR_AWLTF                       \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM_FLT1AWSR_AWHTF                       \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT1AWCFR_CLRAWLTF                   \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM_FLT1AWCFR_CLRAWHTF                   \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x1B0
\ Reset value: 0x80000000
\

$00000007 constant DFSDM_DFSDM_FLT1EXMAX_EXMAXCH                    \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM_FLT1EXMAX_EXMAX                      \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x1B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM_DFSDM_FLT1EXMIN_EXMINCH                    \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM_FLT1EXMIN_EXMIN                      \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM_FLT1CNVTIMR_CNVCNT                   \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief control register 1
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT2CR1_DFEN                         \ DFSDM enable
$00000002 constant DFSDM_DFSDM_FLT2CR1_JSWSTART                     \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM_FLT2CR1_JSYNC                        \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM_FLT2CR1_JSCAN                        \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM_FLT2CR1_JDMAEN                       \ DMA channel enabled to read data for the injected channel group
$00000700 constant DFSDM_DFSDM_FLT2CR1_JEXTSEL                      \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM_FLT2CR1_JEXTEN                       \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM_FLT2CR1_RSWSTART                     \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM_FLT2CR1_RCONT                        \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM_FLT2CR1_RSYNC                        \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM_FLT2CR1_RDMAEN                       \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM_FLT2CR1_RCH                          \ Regular channel selection
$20000000 constant DFSDM_DFSDM_FLT2CR1_FAST                         \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM_FLT2CR1_AWFSEL                       \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT2CR2_JEOCIE                       \ Injected end of conversion interrupt enable
$00000002 constant DFSDM_DFSDM_FLT2CR2_REOCIE                       \ Regular end of conversion interrupt enable
$00000004 constant DFSDM_DFSDM_FLT2CR2_JOVRIE                       \ Injected data overrun interrupt enable
$00000008 constant DFSDM_DFSDM_FLT2CR2_ROVRIE                       \ Regular data overrun interrupt enable
$00000010 constant DFSDM_DFSDM_FLT2CR2_AWDIE                        \ Analog watchdog interrupt enable
$00000020 constant DFSDM_DFSDM_FLT2CR2_SCDIE                        \ Short-circuit detector interrupt enable
$00000040 constant DFSDM_DFSDM_FLT2CR2_CKABIE                       \ Clock absence interrupt enable
$0000ff00 constant DFSDM_DFSDM_FLT2CR2_EXCH                         \ Extremes detector channel selection
$00ff0000 constant DFSDM_DFSDM_FLT2CR2_AWDCH                        \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x208
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM_FLT2ISR_JEOCF                        \ End of injected conversion flag
$00000002 constant DFSDM_DFSDM_FLT2ISR_REOCF                        \ End of regular conversion flag
$00000004 constant DFSDM_DFSDM_FLT2ISR_JOVRF                        \ Injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT2ISR_ROVRF                        \ Regular conversion overrun flag
$00000010 constant DFSDM_DFSDM_FLT2ISR_AWDF                         \ Analog watchdog
$00002000 constant DFSDM_DFSDM_FLT2ISR_JCIP                         \ Injected conversion in progress status
$00004000 constant DFSDM_DFSDM_FLT2ISR_RCIP                         \ Regular conversion in progress status
$00ff0000 constant DFSDM_DFSDM_FLT2ISR_CKABF                        \ Clock absence flag
$ff000000 constant DFSDM_DFSDM_FLT2ISR_SCDF                         \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM_FLT2ICR_CLRJOVRF                     \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT2ICR_CLRROVRF                     \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM_FLT2ICR_CLRCKABF                     \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM_FLT2ICR_CLRSCDF                      \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x210
\ Reset value: 0x00000001
\

$000000ff constant DFSDM_DFSDM_FLT2JCHGR_JCHG                       \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT2FCR_IOSR                         \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM_FLT2FCR_FOSR                         \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM_FLT2FCR_FORD                         \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM_FLT2JDATAR_JDATACH                   \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM_FLT2JDATAR_JDATA                     \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM_FLT2RDATAR_RDATACH                   \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM_FLT2RDATAR_RPEND                     \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM_FLT2RDATAR_RDATA                     \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT2AWHTR_BKAWH                      \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM_FLT2AWHTR_AWHT                       \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT2AWLTR_BKAWL                      \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM_FLT2AWLTR_AWLT                       \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT2AWSR_AWLTF                       \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM_FLT2AWSR_AWHTF                       \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT2AWCFR_CLRAWLTF                   \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM_FLT2AWCFR_CLRAWHTF                   \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x230
\ Reset value: 0x80000000
\

$00000007 constant DFSDM_DFSDM_FLT2EXMAX_EXMAXCH                    \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM_FLT2EXMAX_EXMAX                      \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x234
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM_DFSDM_FLT2EXMIN_EXMINCH                    \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM_FLT2EXMIN_EXMIN                      \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM_FLT2CNVTIMR_CNVCNT                   \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief control register 1
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT3CR1_DFEN                         \ DFSDM enable
$00000002 constant DFSDM_DFSDM_FLT3CR1_JSWSTART                     \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM_FLT3CR1_JSYNC                        \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM_FLT3CR1_JSCAN                        \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM_FLT3CR1_JDMAEN                       \ DMA channel enabled to read data for the injected channel group
$00000700 constant DFSDM_DFSDM_FLT3CR1_JEXTSEL                      \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM_FLT3CR1_JEXTEN                       \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM_FLT3CR1_RSWSTART                     \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM_FLT3CR1_RCONT                        \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM_FLT3CR1_RSYNC                        \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM_FLT3CR1_RDMAEN                       \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM_FLT3CR1_RCH                          \ Regular channel selection
$20000000 constant DFSDM_DFSDM_FLT3CR1_FAST                         \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM_FLT3CR1_AWFSEL                       \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM_FLT3CR2_JEOCIE                       \ Injected end of conversion interrupt enable
$00000002 constant DFSDM_DFSDM_FLT3CR2_REOCIE                       \ Regular end of conversion interrupt enable
$00000004 constant DFSDM_DFSDM_FLT3CR2_JOVRIE                       \ Injected data overrun interrupt enable
$00000008 constant DFSDM_DFSDM_FLT3CR2_ROVRIE                       \ Regular data overrun interrupt enable
$00000010 constant DFSDM_DFSDM_FLT3CR2_AWDIE                        \ Analog watchdog interrupt enable
$00000020 constant DFSDM_DFSDM_FLT3CR2_SCDIE                        \ Short-circuit detector interrupt enable
$00000040 constant DFSDM_DFSDM_FLT3CR2_CKABIE                       \ Clock absence interrupt enable
$0000ff00 constant DFSDM_DFSDM_FLT3CR2_EXCH                         \ Extremes detector channel selection
$00ff0000 constant DFSDM_DFSDM_FLT3CR2_AWDCH                        \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x288
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM_FLT3ISR_JEOCF                        \ End of injected conversion flag
$00000002 constant DFSDM_DFSDM_FLT3ISR_REOCF                        \ End of regular conversion flag
$00000004 constant DFSDM_DFSDM_FLT3ISR_JOVRF                        \ Injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT3ISR_ROVRF                        \ Regular conversion overrun flag
$00000010 constant DFSDM_DFSDM_FLT3ISR_AWDF                         \ Analog watchdog
$00002000 constant DFSDM_DFSDM_FLT3ISR_JCIP                         \ Injected conversion in progress status
$00004000 constant DFSDM_DFSDM_FLT3ISR_RCIP                         \ Regular conversion in progress status
$00ff0000 constant DFSDM_DFSDM_FLT3ISR_CKABF                        \ Clock absence flag
$ff000000 constant DFSDM_DFSDM_FLT3ISR_SCDF                         \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM_FLT3ICR_CLRJOVRF                     \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM_FLT3ICR_CLRROVRF                     \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM_FLT3ICR_CLRCKABF                     \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM_FLT3ICR_CLRSCDF                      \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x290
\ Reset value: 0x00000001
\

$000000ff constant DFSDM_DFSDM_FLT3JCHGR_JCHG                       \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT3FCR_IOSR                         \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM_FLT3FCR_FOSR                         \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM_FLT3FCR_FORD                         \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM_FLT3JDATAR_JDATACH                   \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM_FLT3JDATAR_JDATA                     \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM_FLT3RDATAR_RDATACH                   \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM_FLT3RDATAR_RPEND                     \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM_FLT3RDATAR_RDATA                     \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT3AWHTR_BKAWH                      \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM_FLT3AWHTR_AWHT                       \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM_FLT3AWLTR_BKAWL                      \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM_FLT3AWLTR_AWLT                       \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT3AWSR_AWLTF                       \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM_FLT3AWSR_AWHTF                       \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_FLT3AWCFR_CLRAWLTF                   \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM_FLT3AWCFR_CLRAWHTF                   \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x2B0
\ Reset value: 0x80000000
\

$00000007 constant DFSDM_DFSDM_FLT3EXMAX_EXMAXCH                    \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM_FLT3EXMAX_EXMAX                      \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x2B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM_DFSDM_FLT3EXMIN_EXMINCH                    \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM_FLT3EXMIN_EXMIN                      \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x2B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM_FLT3CNVTIMR_CNVCNT                   \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief Digital filter for sigma delta modulators
\
$40017800 constant DFSDM_CH0CFGR1  \ offset: 0x00 : channel configuration y register
$40017804 constant DFSDM_CH0CFGR2  \ offset: 0x04 : channel configuration y register
$40017808 constant DFSDM_CH0AWSCDR  \ offset: 0x08 : analog watchdog and short-circuit detector register
$4001780c constant DFSDM_CH0WDATR  \ offset: 0x0C : channel watchdog filter data register
$40017810 constant DFSDM_CH0DATINR  \ offset: 0x10 : channel data input register
$40017814 constant DFSDM_CH0DLYR  \ offset: 0x14 : channel y delay register
$40017820 constant DFSDM_CH1CFGR1  \ offset: 0x20 : CH1CFGR1
$40017824 constant DFSDM_CH1CFGR2  \ offset: 0x24 : CH1CFGR2
$40017828 constant DFSDM_CH1AWSCDR  \ offset: 0x28 : CH1AWSCDR
$4001782c constant DFSDM_CH1WDATR  \ offset: 0x2C : CH1WDATR
$40017830 constant DFSDM_CH1DATINR  \ offset: 0x30 : CH1DATINR
$40017834 constant DFSDM_CH1DLYR  \ offset: 0x34 : channel y delay register
$40017840 constant DFSDM_CH2CFGR1  \ offset: 0x40 : CH2CFGR1
$40017844 constant DFSDM_CH2CFGR2  \ offset: 0x44 : CH2CFGR2
$40017848 constant DFSDM_CH2AWSCDR  \ offset: 0x48 : CH2AWSCDR
$4001784c constant DFSDM_CH2WDATR  \ offset: 0x4C : CH2WDATR
$40017850 constant DFSDM_CH2DATINR  \ offset: 0x50 : CH2DATINR
$40017854 constant DFSDM_CH2DLYR  \ offset: 0x54 : channel y delay register
$40017860 constant DFSDM_CH3CFGR1  \ offset: 0x60 : CH3CFGR1
$40017864 constant DFSDM_CH3CFGR2  \ offset: 0x64 : CH3CFGR2
$40017868 constant DFSDM_CH3AWSCDR  \ offset: 0x68 : CH3AWSCDR
$4001786c constant DFSDM_CH3WDATR  \ offset: 0x6C : CH3WDATR
$40017870 constant DFSDM_CH3DATINR  \ offset: 0x70 : CH3DATINR
$40017874 constant DFSDM_CH3DLYR  \ offset: 0x74 : channel y delay register
$40017880 constant DFSDM_CH4CFGR1  \ offset: 0x80 : CH4CFGR1
$40017884 constant DFSDM_CH4CFGR2  \ offset: 0x84 : CH4CFGR2
$40017888 constant DFSDM_CH4AWSCDR  \ offset: 0x88 : CH4AWSCDR
$4001788c constant DFSDM_CH4WDATR  \ offset: 0x8C : CH4WDATR
$40017890 constant DFSDM_CH4DATINR  \ offset: 0x90 : CH4DATINR
$40017894 constant DFSDM_CH4DLYR  \ offset: 0x94 : channel y delay register
$400178a0 constant DFSDM_CH5CFGR1  \ offset: 0xA0 : CH5CFGR1
$400178a4 constant DFSDM_CH5CFGR2  \ offset: 0xA4 : CH5CFGR2
$400178a8 constant DFSDM_CH5AWSCDR  \ offset: 0xA8 : CH5AWSCDR
$400178ac constant DFSDM_CH5WDATR  \ offset: 0xAC : CH5WDATR
$400178b0 constant DFSDM_CH5DATINR  \ offset: 0xB0 : CH5DATINR
$400178b4 constant DFSDM_CH5DLYR  \ offset: 0xB4 : channel y delay register
$400178c0 constant DFSDM_CH6CFGR1  \ offset: 0xC0 : CH6CFGR1
$400178c4 constant DFSDM_CH6CFGR2  \ offset: 0xC4 : CH6CFGR2
$400178c8 constant DFSDM_CH6AWSCDR  \ offset: 0xC8 : CH6AWSCDR
$400178cc constant DFSDM_CH6WDATR  \ offset: 0xCC : CH6WDATR
$400178d0 constant DFSDM_CH6DATINR  \ offset: 0xD0 : CH6DATINR
$400178d4 constant DFSDM_CH6DLYR  \ offset: 0xD4 : channel y delay register
$400178e0 constant DFSDM_CH7CFGR1  \ offset: 0xE0 : CH7CFGR1
$400178e4 constant DFSDM_CH7CFGR2  \ offset: 0xE4 : CH7CFGR2
$400178e8 constant DFSDM_CH7AWSCDR  \ offset: 0xE8 : CH7AWSCDR
$400178ec constant DFSDM_CH7WDATR  \ offset: 0xEC : CH7WDATR
$400178f0 constant DFSDM_CH7DATINR  \ offset: 0xF0 : CH7DATINR
$400178f4 constant DFSDM_CH7DLYR  \ offset: 0xF4 : channel y delay register
$40017900 constant DFSDM_DFSDM_FLT0CR1  \ offset: 0x100 : control register 1
$40017904 constant DFSDM_DFSDM_FLT0CR2  \ offset: 0x104 : control register 2
$40017908 constant DFSDM_DFSDM_FLT0ISR  \ offset: 0x108 : interrupt and status register
$4001790c constant DFSDM_DFSDM_FLT0ICR  \ offset: 0x10C : interrupt flag clear register
$40017910 constant DFSDM_DFSDM_FLT0JCHGR  \ offset: 0x110 : injected channel group selection register
$40017914 constant DFSDM_DFSDM_FLT0FCR  \ offset: 0x114 : filter control register
$40017918 constant DFSDM_DFSDM_FLT0JDATAR  \ offset: 0x118 : data register for injected group
$4001791c constant DFSDM_DFSDM_FLT0RDATAR  \ offset: 0x11C : data register for the regular channel
$40017920 constant DFSDM_DFSDM_FLT0AWHTR  \ offset: 0x120 : analog watchdog high threshold register
$40017924 constant DFSDM_DFSDM_FLT0AWLTR  \ offset: 0x124 : analog watchdog low threshold register
$40017928 constant DFSDM_DFSDM_FLT0AWSR  \ offset: 0x128 : analog watchdog status register
$4001792c constant DFSDM_DFSDM_FLT0AWCFR  \ offset: 0x12C : analog watchdog clear flag register
$40017930 constant DFSDM_DFSDM_FLT0EXMAX  \ offset: 0x130 : Extremes detector maximum register
$40017934 constant DFSDM_DFSDM_FLT0EXMIN  \ offset: 0x134 : Extremes detector minimum register
$40017938 constant DFSDM_DFSDM_FLT0CNVTIMR  \ offset: 0x138 : conversion timer register
$40017980 constant DFSDM_DFSDM_FLT1CR1  \ offset: 0x180 : control register 1
$40017984 constant DFSDM_DFSDM_FLT1CR2  \ offset: 0x184 : control register 2
$40017988 constant DFSDM_DFSDM_FLT1ISR  \ offset: 0x188 : interrupt and status register
$4001798c constant DFSDM_DFSDM_FLT1ICR  \ offset: 0x18C : interrupt flag clear register
$40017990 constant DFSDM_DFSDM_FLT1CHGR  \ offset: 0x190 : injected channel group selection register
$40017994 constant DFSDM_DFSDM_FLT1FCR  \ offset: 0x194 : filter control register
$40017998 constant DFSDM_DFSDM_FLT1JDATAR  \ offset: 0x198 : data register for injected group
$4001799c constant DFSDM_DFSDM_FLT1RDATAR  \ offset: 0x19C : data register for the regular channel
$400179a0 constant DFSDM_DFSDM_FLT1AWHTR  \ offset: 0x1A0 : analog watchdog high threshold register
$400179a4 constant DFSDM_DFSDM_FLT1AWLTR  \ offset: 0x1A4 : analog watchdog low threshold register
$400179a8 constant DFSDM_DFSDM_FLT1AWSR  \ offset: 0x1A8 : analog watchdog status register
$400179ac constant DFSDM_DFSDM_FLT1AWCFR  \ offset: 0x1AC : analog watchdog clear flag register
$400179b0 constant DFSDM_DFSDM_FLT1EXMAX  \ offset: 0x1B0 : Extremes detector maximum register
$400179b4 constant DFSDM_DFSDM_FLT1EXMIN  \ offset: 0x1B4 : Extremes detector minimum register
$400179b8 constant DFSDM_DFSDM_FLT1CNVTIMR  \ offset: 0x1B8 : conversion timer register
$40017a00 constant DFSDM_DFSDM_FLT2CR1  \ offset: 0x200 : control register 1
$40017a04 constant DFSDM_DFSDM_FLT2CR2  \ offset: 0x204 : control register 2
$40017a08 constant DFSDM_DFSDM_FLT2ISR  \ offset: 0x208 : interrupt and status register
$40017a0c constant DFSDM_DFSDM_FLT2ICR  \ offset: 0x20C : interrupt flag clear register
$40017a10 constant DFSDM_DFSDM_FLT2JCHGR  \ offset: 0x210 : injected channel group selection register
$40017a14 constant DFSDM_DFSDM_FLT2FCR  \ offset: 0x214 : filter control register
$40017a18 constant DFSDM_DFSDM_FLT2JDATAR  \ offset: 0x218 : data register for injected group
$40017a1c constant DFSDM_DFSDM_FLT2RDATAR  \ offset: 0x21C : data register for the regular channel
$40017a20 constant DFSDM_DFSDM_FLT2AWHTR  \ offset: 0x220 : analog watchdog high threshold register
$40017a24 constant DFSDM_DFSDM_FLT2AWLTR  \ offset: 0x224 : analog watchdog low threshold register
$40017a28 constant DFSDM_DFSDM_FLT2AWSR  \ offset: 0x228 : analog watchdog status register
$40017a2c constant DFSDM_DFSDM_FLT2AWCFR  \ offset: 0x22C : analog watchdog clear flag register
$40017a30 constant DFSDM_DFSDM_FLT2EXMAX  \ offset: 0x230 : Extremes detector maximum register
$40017a34 constant DFSDM_DFSDM_FLT2EXMIN  \ offset: 0x234 : Extremes detector minimum register
$40017a38 constant DFSDM_DFSDM_FLT2CNVTIMR  \ offset: 0x238 : conversion timer register
$40017a80 constant DFSDM_DFSDM_FLT3CR1  \ offset: 0x280 : control register 1
$40017a84 constant DFSDM_DFSDM_FLT3CR2  \ offset: 0x284 : control register 2
$40017a88 constant DFSDM_DFSDM_FLT3ISR  \ offset: 0x288 : interrupt and status register
$40017a8c constant DFSDM_DFSDM_FLT3ICR  \ offset: 0x28C : interrupt flag clear register
$40017a90 constant DFSDM_DFSDM_FLT3JCHGR  \ offset: 0x290 : injected channel group selection register
$40017a94 constant DFSDM_DFSDM_FLT3FCR  \ offset: 0x294 : filter control register
$40017a98 constant DFSDM_DFSDM_FLT3JDATAR  \ offset: 0x298 : data register for injected group
$40017a9c constant DFSDM_DFSDM_FLT3RDATAR  \ offset: 0x29C : data register for the regular channel
$40017aa0 constant DFSDM_DFSDM_FLT3AWHTR  \ offset: 0x2A0 : analog watchdog high threshold register
$40017aa4 constant DFSDM_DFSDM_FLT3AWLTR  \ offset: 0x2A4 : analog watchdog low threshold register
$40017aa8 constant DFSDM_DFSDM_FLT3AWSR  \ offset: 0x2A8 : analog watchdog status register
$40017aac constant DFSDM_DFSDM_FLT3AWCFR  \ offset: 0x2AC : analog watchdog clear flag register
$40017ab0 constant DFSDM_DFSDM_FLT3EXMAX  \ offset: 0x2B0 : Extremes detector maximum register
$40017ab4 constant DFSDM_DFSDM_FLT3EXMIN  \ offset: 0x2B4 : Extremes detector minimum register
$40017ab8 constant DFSDM_DFSDM_FLT3CNVTIMR  \ offset: 0x2B8 : conversion timer register

