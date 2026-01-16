\
\ @file rtc.fs
\ @brief Real-time clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RTC time register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant RTC_TR_SU                                        \ Second units in BCD format
$00000070 constant RTC_TR_ST                                        \ Second tens in BCD format
$00000f00 constant RTC_TR_MNU                                       \ Minute units in BCD format
$00007000 constant RTC_TR_MNT                                       \ Minute tens in BCD format
$000f0000 constant RTC_TR_HU                                        \ Hour units in BCD format
$00300000 constant RTC_TR_HT                                        \ Hour tens in BCD format
$00400000 constant RTC_TR_PM                                        \ AM/PM notation


\
\ @brief RTC date register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant RTC_DR_DU                                        \ Date units in BCD format
$00000030 constant RTC_DR_DT                                        \ Date tens in BCD format
$00000f00 constant RTC_DR_MU                                        \ Month units in BCD format
$00001000 constant RTC_DR_MT                                        \ Month tens in BCD format
$0000e000 constant RTC_DR_WDU                                       \ Week day units
$000f0000 constant RTC_DR_YU                                        \ Year units in BCD format
$00f00000 constant RTC_DR_YT                                        \ Year tens in BCD format


\
\ @brief RTC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant RTC_CR_WUCKSEL                                   \ Wakeup clock selection
$00000008 constant RTC_CR_TSEDGE                                    \ Time-stamp event active edge
$00000010 constant RTC_CR_REFCKON                                   \ RTC_REFIN reference clock detection enable (50 or 60 Hz)
$00000020 constant RTC_CR_BYPSHAD                                   \ Bypass the shadow registers
$00000040 constant RTC_CR_FMT                                       \ Hour format
$00000100 constant RTC_CR_ALRAE                                     \ Alarm A enable
$00000200 constant RTC_CR_ALRBE                                     \ Alarm B enable
$00000400 constant RTC_CR_WUTE                                      \ Wakeup timer enable
$00000800 constant RTC_CR_TSE                                       \ timestamp enable
$00001000 constant RTC_CR_ALRAIE                                    \ Alarm A interrupt enable
$00002000 constant RTC_CR_ALRBIE                                    \ Alarm B interrupt enable
$00004000 constant RTC_CR_WUTIE                                     \ Wakeup timer interrupt enable
$00008000 constant RTC_CR_TSIE                                      \ Time-stamp interrupt enable
$00010000 constant RTC_CR_ADD1H                                     \ Add 1 hour (summer time change)
$00020000 constant RTC_CR_SUB1H                                     \ Subtract 1 hour (winter time change)
$00040000 constant RTC_CR_BKP                                       \ Backup
$00080000 constant RTC_CR_COSEL                                     \ Calibration output selection
$00100000 constant RTC_CR_POL                                       \ Output polarity
$00600000 constant RTC_CR_OSEL                                      \ Output selection
$00800000 constant RTC_CR_COE                                       \ Calibration output enable


\
\ @brief RTC initialization and status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant RTC_ISR_ALRAWF                                   \ Alarm A write flag
$00000002 constant RTC_ISR_ALRBWF                                   \ Alarm B write flag
$00000004 constant RTC_ISR_WUTWF                                    \ Wakeup timer write flag
$00000008 constant RTC_ISR_SHPF                                     \ Shift operation pending
$00000010 constant RTC_ISR_INITS                                    \ Initialization status flag
$00000020 constant RTC_ISR_RSF                                      \ Registers synchronization flag
$00000040 constant RTC_ISR_INITF                                    \ Initialization flag
$00000080 constant RTC_ISR_INIT                                     \ Initialization mode
$00000100 constant RTC_ISR_ALRAF                                    \ Alarm A flag
$00000200 constant RTC_ISR_ALRBF                                    \ Alarm B flag
$00000400 constant RTC_ISR_WUTF                                     \ Wakeup timer flag
$00000800 constant RTC_ISR_TSF                                      \ Time-stamp flag
$00001000 constant RTC_ISR_TSOVF                                    \ Time-stamp overflow flag
$00002000 constant RTC_ISR_TAMP1F                                   \ RTC_TAMP1 detection flag
$00004000 constant RTC_ISR_TAMP2F                                   \ RTC_TAMP2 detection flag


\
\ @brief RTC prescaler register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant RTC_PRER_PREDIV_S                                \ Synchronous prescaler factor
$007f0000 constant RTC_PRER_PREDIV_A                                \ Asynchronous prescaler factor


\
\ @brief RTC wakeup timer register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant RTC_WUTR_WUT                                     \ Wakeup auto-reload value bits


\
\ @brief RTC alarm A register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant RTC_ALRMAR_SU                                    \ Second units in BCD format.
$00000070 constant RTC_ALRMAR_ST                                    \ Second tens in BCD format.
$00000080 constant RTC_ALRMAR_MSK1                                  \ Alarm A seconds mask
$00000f00 constant RTC_ALRMAR_MNU                                   \ Minute units in BCD format.
$00007000 constant RTC_ALRMAR_MNT                                   \ Minute tens in BCD format.
$00008000 constant RTC_ALRMAR_MSK2                                  \ Alarm A minutes mask
$000f0000 constant RTC_ALRMAR_HU                                    \ Hour units in BCD format.
$00300000 constant RTC_ALRMAR_HT                                    \ Hour tens in BCD format.
$00400000 constant RTC_ALRMAR_PM                                    \ AM/PM notation
$00800000 constant RTC_ALRMAR_MSK3                                  \ Alarm A hours mask
$0f000000 constant RTC_ALRMAR_DU                                    \ Date units or day in BCD format.
$30000000 constant RTC_ALRMAR_DT                                    \ Date tens in BCD format.
$40000000 constant RTC_ALRMAR_WDSEL                                 \ Week day selection
$80000000 constant RTC_ALRMAR_MSK4                                  \ Alarm A date mask


\
\ @brief RTC alarm B register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant RTC_ALRMBR_SU                                    \ Second units in BCD format
$00000070 constant RTC_ALRMBR_ST                                    \ Second tens in BCD format
$00000080 constant RTC_ALRMBR_MSK1                                  \ Alarm B seconds mask
$00000f00 constant RTC_ALRMBR_MNU                                   \ Minute units in BCD format
$00007000 constant RTC_ALRMBR_MNT                                   \ Minute tens in BCD format
$00008000 constant RTC_ALRMBR_MSK2                                  \ Alarm B minutes mask
$000f0000 constant RTC_ALRMBR_HU                                    \ Hour units in BCD format
$00300000 constant RTC_ALRMBR_HT                                    \ Hour tens in BCD format
$00400000 constant RTC_ALRMBR_PM                                    \ AM/PM notation
$00800000 constant RTC_ALRMBR_MSK3                                  \ Alarm B hours mask
$0f000000 constant RTC_ALRMBR_DU                                    \ Date units or day in BCD format
$30000000 constant RTC_ALRMBR_DT                                    \ Date tens in BCD format
$40000000 constant RTC_ALRMBR_WDSEL                                 \ Week day selection
$80000000 constant RTC_ALRMBR_MSK4                                  \ Alarm B date mask


\
\ @brief write protection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant RTC_WPR_KEY                                      \ Write protection key


\
\ @brief RTC sub second register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant RTC_SSR_SS                                       \ Sub second value


\
\ @brief RTC shift control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00007fff constant RTC_SHIFTR_SUBFS                                 \ Subtract a fraction of a second
$80000000 constant RTC_SHIFTR_ADD1S                                 \ Add one second


\
\ @brief RTC timestamp time register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant RTC_TSTR_SU                                      \ Second units in BCD format.
$00000070 constant RTC_TSTR_ST                                      \ Second tens in BCD format.
$00000f00 constant RTC_TSTR_MNU                                     \ Minute units in BCD format.
$00007000 constant RTC_TSTR_MNT                                     \ Minute tens in BCD format.
$000f0000 constant RTC_TSTR_HU                                      \ Hour units in BCD format.
$00300000 constant RTC_TSTR_HT                                      \ Hour tens in BCD format.
$00400000 constant RTC_TSTR_PM                                      \ AM/PM notation


\
\ @brief RTC timestamp date register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant RTC_TSDR_DU                                      \ Date units in BCD format
$00000030 constant RTC_TSDR_DT                                      \ Date tens in BCD format
$00000f00 constant RTC_TSDR_MU                                      \ Month units in BCD format
$00001000 constant RTC_TSDR_MT                                      \ Month tens in BCD format
$0000e000 constant RTC_TSDR_WDU                                     \ Week day units


\
\ @brief RTC time-stamp sub second register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant RTC_TSSSR_SS                                     \ Sub second value


\
\ @brief RTC calibration register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000001ff constant RTC_CALR_CALM                                    \ Calibration minus
$00002000 constant RTC_CALR_CALW16                                  \ Use a 16-second calibration cycle period
$00004000 constant RTC_CALR_CALW8                                   \ Use a 8-second calibration cycle period
$00008000 constant RTC_CALR_CALP                                    \ Increase frequency of RTC by 488.5 ppm


\
\ @brief RTC tamper configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RTC_TAMPCR_TAMP1E                                \ RTC_TAMP1 input detection enable
$00000002 constant RTC_TAMPCR_TAMP1TRG                              \ Active level for RTC_TAMP1 input
$00000004 constant RTC_TAMPCR_TAMPIE                                \ Tamper interrupt enable
$00000008 constant RTC_TAMPCR_TAMP2E                                \ RTC_TAMP2 input detection enable
$00000010 constant RTC_TAMPCR_TAMP2_TRG                             \ Active level for RTC_TAMP2 input
$00000080 constant RTC_TAMPCR_TAMPTS                                \ Activate timestamp on tamper detection event
$00000700 constant RTC_TAMPCR_TAMPFREQ                              \ Tamper sampling frequency
$00001800 constant RTC_TAMPCR_TAMPFLT                               \ RTC_TAMPx filter count
$00006000 constant RTC_TAMPCR_TAMPPRCH                              \ RTC_TAMPx precharge duration
$00008000 constant RTC_TAMPCR_TAMPPUDIS                             \ RTC_TAMPx pull-up disable
$00010000 constant RTC_TAMPCR_TAMP1IE                               \ Tamper 1 interrupt enable
$00020000 constant RTC_TAMPCR_TAMP1NOERASE                          \ Tamper 1 no erase
$00040000 constant RTC_TAMPCR_TAMP1MF                               \ Tamper 1 mask flag
$00080000 constant RTC_TAMPCR_TAMP2IE                               \ Tamper 2 interrupt enable
$00100000 constant RTC_TAMPCR_TAMP2NOERASE                          \ Tamper 2 no erase
$00200000 constant RTC_TAMPCR_TAMP2MF                               \ Tamper 2 mask flag


\
\ @brief RTC alarm A sub second register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant RTC_ALRMASSR_SS                                  \ Sub seconds value
$0f000000 constant RTC_ALRMASSR_MASKSS                              \ Mask the most-significant bits starting at this bit


\
\ @brief RTC alarm B sub second register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00007fff constant RTC_ALRMBSSR_SS                                  \ Sub seconds value
$0f000000 constant RTC_ALRMBSSR_MASKSS                              \ Mask the most-significant bits starting at this bit


\
\ @brief option register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RTC_OR_RTC_ALARM_TYPE                            \ RTC_ALARM on PC13 output type
$00000002 constant RTC_OR_RTC_OUT_RMP                               \ RTC_ALARM on PC13 output type


\
\ @brief RTC backup registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP0R_BKP                                    \ BKP


\
\ @brief RTC backup registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP1R_BKP                                    \ BKP


\
\ @brief RTC backup registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP2R_BKP                                    \ BKP


\
\ @brief RTC backup registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP3R_BKP                                    \ BKP


\
\ @brief RTC backup registers
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP4R_BKP                                    \ BKP


\
\ @brief Real-time clock
\
$40002800 constant RTC_TR         \ offset: 0x00 : RTC time register
$40002804 constant RTC_DR         \ offset: 0x04 : RTC date register
$40002808 constant RTC_CR         \ offset: 0x08 : RTC control register
$4000280c constant RTC_ISR        \ offset: 0x0C : RTC initialization and status register
$40002810 constant RTC_PRER       \ offset: 0x10 : RTC prescaler register
$40002814 constant RTC_WUTR       \ offset: 0x14 : RTC wakeup timer register
$4000281c constant RTC_ALRMAR     \ offset: 0x1C : RTC alarm A register
$40002820 constant RTC_ALRMBR     \ offset: 0x20 : RTC alarm B register
$40002824 constant RTC_WPR        \ offset: 0x24 : write protection register
$40002828 constant RTC_SSR        \ offset: 0x28 : RTC sub second register
$4000282c constant RTC_SHIFTR     \ offset: 0x2C : RTC shift control register
$40002830 constant RTC_TSTR       \ offset: 0x30 : RTC timestamp time register
$40002834 constant RTC_TSDR       \ offset: 0x34 : RTC timestamp date register
$40002838 constant RTC_TSSSR      \ offset: 0x38 : RTC time-stamp sub second register
$4000283c constant RTC_CALR       \ offset: 0x3C : RTC calibration register
$40002840 constant RTC_TAMPCR     \ offset: 0x40 : RTC tamper configuration register
$40002844 constant RTC_ALRMASSR   \ offset: 0x44 : RTC alarm A sub second register
$40002848 constant RTC_ALRMBSSR   \ offset: 0x48 : RTC alarm B sub second register
$4000284c constant RTC_OR         \ offset: 0x4C : option register
$40002850 constant RTC_BKP0R      \ offset: 0x50 : RTC backup registers
$40002854 constant RTC_BKP1R      \ offset: 0x54 : RTC backup registers
$40002858 constant RTC_BKP2R      \ offset: 0x58 : RTC backup registers
$4000285c constant RTC_BKP3R      \ offset: 0x5C : RTC backup registers
$40002860 constant RTC_BKP4R      \ offset: 0x60 : RTC backup registers

