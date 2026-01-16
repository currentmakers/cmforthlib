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

$00000008 constant RTC_CR_TSEDGE                                    \ Time-stamp event active edge
$00000010 constant RTC_CR_REFCKON                                   \ RTC_REFIN reference clock detection enable (50 or 60 Hz)
$00000020 constant RTC_CR_BYPSHAD                                   \ Bypass the shadow registers
$00000040 constant RTC_CR_FMT                                       \ Hour format
$00000100 constant RTC_CR_ALRAE                                     \ Alarm A enable
$00000800 constant RTC_CR_TSE                                       \ timestamp enable
$00001000 constant RTC_CR_ALRAIE                                    \ Alarm A interrupt enable
$00008000 constant RTC_CR_TSIE                                      \ Time-stamp interrupt enable
$00010000 constant RTC_CR_ADD1H                                     \ Add 1 hour (summer time change)
$00020000 constant RTC_CR_SUB1H                                     \ Subtract 1 hour (winter time change)
$00040000 constant RTC_CR_BKP                                       \ Backup
$00080000 constant RTC_CR_COSEL                                     \ Calibration output selection
$00100000 constant RTC_CR_POL                                       \ Output polarity
$00600000 constant RTC_CR_OSEL                                      \ Output selection
$00800000 constant RTC_CR_COE                                       \ Calibration output enable


\
\ @brief initialization and status register
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$00000001 constant RTC_ISR_ALRAWF                                   \ Alarm A write flag
$00000008 constant RTC_ISR_SHPF                                     \ Shift operation pending
$00000010 constant RTC_ISR_INITS                                    \ Initialization status flag
$00000020 constant RTC_ISR_RSF                                      \ Registers synchronization flag
$00000040 constant RTC_ISR_INITF                                    \ Initialization flag
$00000080 constant RTC_ISR_INIT                                     \ Initialization mode
$00000100 constant RTC_ISR_ALRAF                                    \ Alarm A flag
$00000800 constant RTC_ISR_TSF                                      \ Time-stamp flag
$00001000 constant RTC_ISR_TSOVF                                    \ Time-stamp overflow flag
$00002000 constant RTC_ISR_TAMP1F                                   \ RTC_TAMP1 detection flag
$00004000 constant RTC_ISR_TAMP2F                                   \ RTC_TAMP2 detection flag
$00010000 constant RTC_ISR_RECALPF                                  \ Recalibration pending Flag


\
\ @brief prescaler register
\ Address offset: 0x10
\ Reset value: 0x007F00FF
\

$00007fff constant RTC_PRER_PREDIV_S                                \ Synchronous prescaler factor
$007f0000 constant RTC_PRER_PREDIV_A                                \ Asynchronous prescaler factor


\
\ @brief alarm A register
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
\ @brief timestamp time register
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
\ @brief timestamp date register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant RTC_TSDR_DU                                      \ Date units in BCD format
$00000030 constant RTC_TSDR_DT                                      \ Date tens in BCD format
$00000f00 constant RTC_TSDR_MU                                      \ Month units in BCD format
$00001000 constant RTC_TSDR_MT                                      \ Month tens in BCD format
$0000e000 constant RTC_TSDR_WDU                                     \ Week day units


\
\ @brief time-stamp sub second register
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

$00000001 constant RTC_TAFCR_TAMP1E                                 \ RTC_TAMP1 input detection enable
$00000002 constant RTC_TAFCR_TAMP1TRG                               \ Active level for RTC_TAMP1 input
$00000004 constant RTC_TAFCR_TAMPIE                                 \ Tamper interrupt enable
$00000008 constant RTC_TAFCR_TAMP2E                                 \ RTC_TAMP2 input detection enable
$00000010 constant RTC_TAFCR_TAMP2_TRG                              \ Active level for RTC_TAMP2 input
$00000080 constant RTC_TAFCR_TAMPTS                                 \ Activate timestamp on tamper detection event
$00000700 constant RTC_TAFCR_TAMPFREQ                               \ Tamper sampling frequency
$00001800 constant RTC_TAFCR_TAMPFLT                                \ RTC_TAMPx filter count
$00006000 constant RTC_TAFCR_TAMP_PRCH                              \ RTC_TAMPx precharge duration
$00008000 constant RTC_TAFCR_TAMP_PUDIS                             \ RTC_TAMPx pull-up disable
$00040000 constant RTC_TAFCR_PC13VALUE                              \ RTC_ALARM output type/PC13 value
$00080000 constant RTC_TAFCR_PC13MODE                               \ PC13 mode
$00100000 constant RTC_TAFCR_PC14VALUE                              \ PC14 value
$00200000 constant RTC_TAFCR_PC14MODE                               \ PC14 mode
$00400000 constant RTC_TAFCR_PC15VALUE                              \ PC15 value
$00800000 constant RTC_TAFCR_PC15MODE                               \ PC15 mode


\
\ @brief alarm A sub second register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant RTC_ALRMASSR_SS                                  \ Sub seconds value
$0f000000 constant RTC_ALRMASSR_MASKSS                              \ Mask the most-significant bits starting at this bit


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
\ @brief Real-time clock
\
$40002800 constant RTC_TR         \ offset: 0x00 : time register
$40002804 constant RTC_DR         \ offset: 0x04 : date register
$40002808 constant RTC_CR         \ offset: 0x08 : control register
$4000280c constant RTC_ISR        \ offset: 0x0C : initialization and status register
$40002810 constant RTC_PRER       \ offset: 0x10 : prescaler register
$4000281c constant RTC_ALRMAR     \ offset: 0x1C : alarm A register
$40002824 constant RTC_WPR        \ offset: 0x24 : write protection register
$40002828 constant RTC_SSR        \ offset: 0x28 : sub second register
$4000282c constant RTC_SHIFTR     \ offset: 0x2C : shift control register
$40002830 constant RTC_TSTR       \ offset: 0x30 : timestamp time register
$40002834 constant RTC_TSDR       \ offset: 0x34 : timestamp date register
$40002838 constant RTC_TSSSR      \ offset: 0x38 : time-stamp sub second register
$4000283c constant RTC_CALR       \ offset: 0x3C : calibration register
$40002840 constant RTC_TAFCR      \ offset: 0x40 : tamper and alternate function configuration register
$40002844 constant RTC_ALRMASSR   \ offset: 0x44 : alarm A sub second register
$40002850 constant RTC_BKP0R      \ offset: 0x50 : backup register
$40002854 constant RTC_BKP1R      \ offset: 0x54 : backup register
$40002858 constant RTC_BKP2R      \ offset: 0x58 : backup register
$4000285c constant RTC_BKP3R      \ offset: 0x5C : backup register
$40002860 constant RTC_BKP4R      \ offset: 0x60 : backup register

