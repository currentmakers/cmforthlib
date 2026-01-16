\
\ @file rtc.fs
\ @brief Real-time clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief time register
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
\ @brief date register
\ Address offset: 0x04
\ Reset value: 0x00002101
\

$0000000f constant RTC_DR_DU                                        \ Date units in BCD format
$00000030 constant RTC_DR_DT                                        \ Date tens in BCD format
$00000f00 constant RTC_DR_MU                                        \ Month units in BCD format
$00001000 constant RTC_DR_MT                                        \ Month tens in BCD format
$0000e000 constant RTC_DR_WDU                                       \ Week day units
$000f0000 constant RTC_DR_YU                                        \ Year units in BCD format
$00f00000 constant RTC_DR_YT                                        \ Year tens in BCD format


\
\ @brief control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant RTC_CR_WCKSEL                                    \ Wakeup clock selection
$00000008 constant RTC_CR_TSEDGE                                    \ Time-stamp event active edge
$00000010 constant RTC_CR_REFCKON                                   \ Reference clock detection enable (50 or 60 Hz)
$00000020 constant RTC_CR_BYPSHAD                                   \ Bypass the shadow registers
$00000040 constant RTC_CR_FMT                                       \ Hour format
$00000080 constant RTC_CR_DCE                                       \ Coarse digital calibration enable
$00000100 constant RTC_CR_ALRAE                                     \ Alarm A enable
$00000200 constant RTC_CR_ALRBE                                     \ Alarm B enable
$00000400 constant RTC_CR_WUTE                                      \ Wakeup timer enable
$00000800 constant RTC_CR_TSE                                       \ Time stamp enable
$00001000 constant RTC_CR_ALRAIE                                    \ Alarm A interrupt enable
$00002000 constant RTC_CR_ALRBIE                                    \ Alarm B interrupt enable
$00004000 constant RTC_CR_WUTIE                                     \ Wakeup timer interrupt enable
$00008000 constant RTC_CR_TSIE                                      \ Time-stamp interrupt enable
$00010000 constant RTC_CR_ADD1H                                     \ Add 1 hour (summer time change)
$00020000 constant RTC_CR_SUB1H                                     \ Subtract 1 hour (winter time change)
$00040000 constant RTC_CR_BKP                                       \ Backup
$00080000 constant RTC_CR_COSEL                                     \ Calibration Output selection
$00100000 constant RTC_CR_POL                                       \ Output polarity
$00600000 constant RTC_CR_OSEL                                      \ Output selection
$00800000 constant RTC_CR_COE                                       \ Calibration output enable


\
\ @brief initialization and status register
\ Address offset: 0x0C
\ Reset value: 0x00000007
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
$00002000 constant RTC_ISR_TAMP1F                                   \ Tamper detection flag
$00004000 constant RTC_ISR_TAMP2F                                   \ TAMPER2 detection flag
$00010000 constant RTC_ISR_RECALPF                                  \ Recalibration pending Flag


\
\ @brief prescaler register
\ Address offset: 0x10
\ Reset value: 0x007F00FF
\

$00007fff constant RTC_PRER_PREDIV_S                                \ Synchronous prescaler factor
$007f0000 constant RTC_PRER_PREDIV_A                                \ Asynchronous prescaler factor


\
\ @brief wakeup timer register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant RTC_WUTR_WUT                                     \ Wakeup auto-reload value bits


\
\ @brief calibration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000001f constant RTC_CALIBR_DC                                    \ Digital calibration
$00000080 constant RTC_CALIBR_DCS                                   \ Digital calibration sign


\
\ @brief alarm A register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant RTC_ALRMAR_SU                                    \ Second units in BCD format
$00000070 constant RTC_ALRMAR_ST                                    \ Second tens in BCD format
$00000080 constant RTC_ALRMAR_MSK1                                  \ Alarm A seconds mask
$00000f00 constant RTC_ALRMAR_MNU                                   \ Minute units in BCD format
$00007000 constant RTC_ALRMAR_MNT                                   \ Minute tens in BCD format
$00008000 constant RTC_ALRMAR_MSK2                                  \ Alarm A minutes mask
$000f0000 constant RTC_ALRMAR_HU                                    \ Hour units in BCD format
$00300000 constant RTC_ALRMAR_HT                                    \ Hour tens in BCD format
$00400000 constant RTC_ALRMAR_PM                                    \ AM/PM notation
$00800000 constant RTC_ALRMAR_MSK3                                  \ Alarm A hours mask
$0f000000 constant RTC_ALRMAR_DU                                    \ Date units or day in BCD format
$30000000 constant RTC_ALRMAR_DT                                    \ Date tens in BCD format
$40000000 constant RTC_ALRMAR_WDSEL                                 \ Week day selection
$80000000 constant RTC_ALRMAR_MSK4                                  \ Alarm A date mask


\
\ @brief alarm B register
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
\ @brief sub second register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant RTC_SSR_SS                                       \ Sub second value


\
\ @brief shift control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00007fff constant RTC_SHIFTR_SUBFS                                 \ Subtract a fraction of a second
$80000000 constant RTC_SHIFTR_ADD1S                                 \ Add one second


\
\ @brief time stamp time register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant RTC_TSTR_SU                                      \ Second units in BCD format
$00000070 constant RTC_TSTR_ST                                      \ Second tens in BCD format
$00000f00 constant RTC_TSTR_MNU                                     \ Minute units in BCD format
$00007000 constant RTC_TSTR_MNT                                     \ Minute tens in BCD format
$000f0000 constant RTC_TSTR_HU                                      \ Hour units in BCD format
$00300000 constant RTC_TSTR_HT                                      \ Hour tens in BCD format
$00400000 constant RTC_TSTR_PM                                      \ AM/PM notation


\
\ @brief time stamp date register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant RTC_TSDR_DU                                      \ Date units in BCD format
$00000030 constant RTC_TSDR_DT                                      \ Date tens in BCD format
$00000f00 constant RTC_TSDR_MU                                      \ Month units in BCD format
$00001000 constant RTC_TSDR_MT                                      \ Month tens in BCD format
$0000e000 constant RTC_TSDR_WDU                                     \ Week day units


\
\ @brief timestamp sub second register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant RTC_TSSSR_SS                                     \ Sub second value


\
\ @brief calibration register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000001ff constant RTC_CALR_CALM                                    \ Calibration minus
$00002000 constant RTC_CALR_CALW16                                  \ Use a 16-second calibration cycle period
$00004000 constant RTC_CALR_CALW8                                   \ Use an 8-second calibration cycle period
$00008000 constant RTC_CALR_CALP                                    \ Increase frequency of RTC by 488.5 ppm


\
\ @brief tamper and alternate function configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RTC_TAFCR_TAMP1E                                 \ Tamper 1 detection enable
$00000002 constant RTC_TAFCR_TAMP1TRG                               \ Active level for tamper 1
$00000004 constant RTC_TAFCR_TAMPIE                                 \ Tamper interrupt enable
$00000008 constant RTC_TAFCR_TAMP2E                                 \ Tamper 2 detection enable
$00000010 constant RTC_TAFCR_TAMP2TRG                               \ Active level for tamper 2
$00000080 constant RTC_TAFCR_TAMPTS                                 \ Activate timestamp on tamper detection event
$00000700 constant RTC_TAFCR_TAMPFREQ                               \ Tamper sampling frequency
$00001800 constant RTC_TAFCR_TAMPFLT                                \ Tamper filter count
$00006000 constant RTC_TAFCR_TAMPPRCH                               \ Tamper precharge duration
$00008000 constant RTC_TAFCR_TAMPPUDIS                              \ TAMPER pull-up disable
$00010000 constant RTC_TAFCR_TAMP1INSEL                             \ TAMPER1 mapping
$00020000 constant RTC_TAFCR_TSINSEL                                \ TIMESTAMP mapping
$00040000 constant RTC_TAFCR_ALARMOUTTYPE                           \ AFO_ALARM output type


\
\ @brief alarm A sub second register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant RTC_ALRMASSR_SS                                  \ Sub seconds value
$0f000000 constant RTC_ALRMASSR_MASKSS                              \ Mask the most-significant bits starting at this bit


\
\ @brief alarm B sub second register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00007fff constant RTC_ALRMBSSR_SS                                  \ Sub seconds value
$0f000000 constant RTC_ALRMBSSR_MASKSS                              \ Mask the most-significant bits starting at this bit


\
\ @brief backup register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP0R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP1R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP2R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP3R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP4R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP5R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP6R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP7R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP8R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP9R_BKP                                    \ BKP


\
\ @brief backup register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP10R_BKP                                   \ BKP


\
\ @brief backup register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP11R_BKP                                   \ BKP


\
\ @brief backup register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP12R_BKP                                   \ BKP


\
\ @brief backup register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP13R_BKP                                   \ BKP


\
\ @brief backup register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP14R_BKP                                   \ BKP


\
\ @brief backup register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP15R_BKP                                   \ BKP


\
\ @brief backup register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP16R_BKP                                   \ BKP


\
\ @brief backup register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP17R_BKP                                   \ BKP


\
\ @brief backup register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP18R_BKP                                   \ BKP


\
\ @brief backup register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant RTC_BKP19R_BKP                                   \ BKP


\
\ @brief Real-time clock
\
$40002800 constant RTC_TR         \ offset: 0x00 : time register
$40002804 constant RTC_DR         \ offset: 0x04 : date register
$40002808 constant RTC_CR         \ offset: 0x08 : control register
$4000280c constant RTC_ISR        \ offset: 0x0C : initialization and status register
$40002810 constant RTC_PRER       \ offset: 0x10 : prescaler register
$40002814 constant RTC_WUTR       \ offset: 0x14 : wakeup timer register
$40002818 constant RTC_CALIBR     \ offset: 0x18 : calibration register
$4000281c constant RTC_ALRMAR     \ offset: 0x1C : alarm A register
$40002820 constant RTC_ALRMBR     \ offset: 0x20 : alarm B register
$40002824 constant RTC_WPR        \ offset: 0x24 : write protection register
$40002828 constant RTC_SSR        \ offset: 0x28 : sub second register
$4000282c constant RTC_SHIFTR     \ offset: 0x2C : shift control register
$40002830 constant RTC_TSTR       \ offset: 0x30 : time stamp time register
$40002834 constant RTC_TSDR       \ offset: 0x34 : time stamp date register
$40002838 constant RTC_TSSSR      \ offset: 0x38 : timestamp sub second register
$4000283c constant RTC_CALR       \ offset: 0x3C : calibration register
$40002840 constant RTC_TAFCR      \ offset: 0x40 : tamper and alternate function configuration register
$40002844 constant RTC_ALRMASSR   \ offset: 0x44 : alarm A sub second register
$40002848 constant RTC_ALRMBSSR   \ offset: 0x48 : alarm B sub second register
$40002850 constant RTC_BKP0R      \ offset: 0x50 : backup register
$40002854 constant RTC_BKP1R      \ offset: 0x54 : backup register
$40002858 constant RTC_BKP2R      \ offset: 0x58 : backup register
$4000285c constant RTC_BKP3R      \ offset: 0x5C : backup register
$40002860 constant RTC_BKP4R      \ offset: 0x60 : backup register
$40002864 constant RTC_BKP5R      \ offset: 0x64 : backup register
$40002868 constant RTC_BKP6R      \ offset: 0x68 : backup register
$4000286c constant RTC_BKP7R      \ offset: 0x6C : backup register
$40002870 constant RTC_BKP8R      \ offset: 0x70 : backup register
$40002874 constant RTC_BKP9R      \ offset: 0x74 : backup register
$40002878 constant RTC_BKP10R     \ offset: 0x78 : backup register
$4000287c constant RTC_BKP11R     \ offset: 0x7C : backup register
$40002880 constant RTC_BKP12R     \ offset: 0x80 : backup register
$40002884 constant RTC_BKP13R     \ offset: 0x84 : backup register
$40002888 constant RTC_BKP14R     \ offset: 0x88 : backup register
$4000288c constant RTC_BKP15R     \ offset: 0x8C : backup register
$40002890 constant RTC_BKP16R     \ offset: 0x90 : backup register
$40002894 constant RTC_BKP17R     \ offset: 0x94 : backup register
$40002898 constant RTC_BKP18R     \ offset: 0x98 : backup register
$4000289c constant RTC_BKP19R     \ offset: 0x9C : backup register

