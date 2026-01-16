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
\ @brief sub second register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant RTC_SSR_SS                                       \ Sub second value


\
\ @brief initialization and status register
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$00000001 constant RTC_ICSR_ALRAWF                                  \ Alarm A write flag
$00000002 constant RTC_ICSR_ALRBWF                                  \ Alarm B write flag
$00000004 constant RTC_ICSR_WUTWF                                   \ Wakeup timer write flag
$00000008 constant RTC_ICSR_SHPF                                    \ Shift operation pending
$00000010 constant RTC_ICSR_INITS                                   \ Initialization status flag
$00000020 constant RTC_ICSR_RSF                                     \ Registers synchronization flag
$00000040 constant RTC_ICSR_INITF                                   \ Initialization flag
$00000080 constant RTC_ICSR_INIT                                    \ Initialization mode
$00010000 constant RTC_ICSR_RECALPF                                 \ Recalibration pending Flag


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
\ @brief control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant RTC_CR_WUCKSEL                                   \ WUCKSEL
$00000008 constant RTC_CR_TSEDGE                                    \ TSEDGE
$00000010 constant RTC_CR_REFCKON                                   \ REFCKON
$00000020 constant RTC_CR_BYPSHAD                                   \ BYPSHAD
$00000040 constant RTC_CR_FMT                                       \ FMT
$00000100 constant RTC_CR_ALRAE                                     \ ALRAE
$00000200 constant RTC_CR_ALRBE                                     \ ALRBE
$00000400 constant RTC_CR_WUTE                                      \ WUTE
$00000800 constant RTC_CR_TSE                                       \ TSE
$00001000 constant RTC_CR_ALRAIE                                    \ ALRAIE
$00002000 constant RTC_CR_ALRBIE                                    \ ALRBIE
$00004000 constant RTC_CR_WUTIE                                     \ WUTIE
$00008000 constant RTC_CR_TSIE                                      \ TSIE
$00010000 constant RTC_CR_ADD1H                                     \ ADD1H
$00020000 constant RTC_CR_SUB1H                                     \ SUB1H
$00040000 constant RTC_CR_BKP                                       \ BKP
$00080000 constant RTC_CR_COSEL                                     \ COSEL
$00100000 constant RTC_CR_POL                                       \ POL
$00600000 constant RTC_CR_OSEL                                      \ OSEL
$00800000 constant RTC_CR_COE                                       \ COE
$01000000 constant RTC_CR_ITSE                                      \ ITSE
$02000000 constant RTC_CR_TAMPTS                                    \ TAMPTS
$04000000 constant RTC_CR_TAMPOE                                    \ TAMPOE
$20000000 constant RTC_CR_TAMPALRM_PU                               \ TAMPALRM_PU
$40000000 constant RTC_CR_TAMPALRM_TYPE                             \ TAMPALRM_TYPE
$80000000 constant RTC_CR_OUT2EN                                    \ OUT2EN


\
\ @brief write protection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant RTC_WPR_KEY                                      \ Write protection key


\
\ @brief calibration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant RTC_CALR_CALM                                    \ Calibration minus
$00002000 constant RTC_CALR_CALW16                                  \ Use a 16-second calibration cycle period
$00004000 constant RTC_CALR_CALW8                                   \ Use an 8-second calibration cycle period
$00008000 constant RTC_CALR_CALP                                    \ Increase frequency of RTC by 488.5 ppm


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
\ @brief alarm A register
\ Address offset: 0x40
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
\ @brief alarm A sub second register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant RTC_ALRMASSR_SS                                  \ Sub seconds value
$0f000000 constant RTC_ALRMASSR_MASKSS                              \ Mask the most-significant bits starting at this bit


\
\ @brief alarm B register
\ Address offset: 0x48
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
\ @brief alarm B sub second register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00007fff constant RTC_ALRMBSSR_SS                                  \ Sub seconds value
$0f000000 constant RTC_ALRMBSSR_MASKSS                              \ Mask the most-significant bits starting at this bit


\
\ @brief status register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RTC_SR_ALRAF                                     \ ALRAF
$00000002 constant RTC_SR_ALRBF                                     \ ALRBF
$00000004 constant RTC_SR_WUTF                                      \ WUTF
$00000008 constant RTC_SR_TSF                                       \ TSF
$00000010 constant RTC_SR_TSOVF                                     \ TSOVF
$00000020 constant RTC_SR_ITSF                                      \ ITSF


\
\ @brief masked interrupt status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RTC_MISR_ALRAMF                                  \ ALRAMF
$00000002 constant RTC_MISR_ALRBMF                                  \ ALRBMF
$00000004 constant RTC_MISR_WUTMF                                   \ WUTMF
$00000008 constant RTC_MISR_TSMF                                    \ TSMF
$00000010 constant RTC_MISR_TSOVMF                                  \ TSOVMF
$00000020 constant RTC_MISR_ITSMF                                   \ ITSMF


\
\ @brief status clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RTC_SCR_CALRAF                                   \ CALRAF
$00000002 constant RTC_SCR_CALRBF                                   \ CALRBF
$00000004 constant RTC_SCR_CWUTF                                    \ CWUTF
$00000008 constant RTC_SCR_CTSF                                     \ CTSF
$00000010 constant RTC_SCR_CTSOVF                                   \ CTSOVF
$00000020 constant RTC_SCR_CITSF                                    \ CITSF


\
\ @brief Real-time clock
\
$40002800 constant RTC_TR         \ offset: 0x00 : time register
$40002804 constant RTC_DR         \ offset: 0x04 : date register
$40002808 constant RTC_SSR        \ offset: 0x08 : sub second register
$4000280c constant RTC_ICSR       \ offset: 0x0C : initialization and status register
$40002810 constant RTC_PRER       \ offset: 0x10 : prescaler register
$40002814 constant RTC_WUTR       \ offset: 0x14 : wakeup timer register
$40002818 constant RTC_CR         \ offset: 0x18 : control register
$40002824 constant RTC_WPR        \ offset: 0x24 : write protection register
$40002828 constant RTC_CALR       \ offset: 0x28 : calibration register
$4000282c constant RTC_SHIFTR     \ offset: 0x2C : shift control register
$40002830 constant RTC_TSTR       \ offset: 0x30 : time stamp time register
$40002834 constant RTC_TSDR       \ offset: 0x34 : time stamp date register
$40002838 constant RTC_TSSSR      \ offset: 0x38 : timestamp sub second register
$40002840 constant RTC_ALRMAR     \ offset: 0x40 : alarm A register
$40002844 constant RTC_ALRMASSR   \ offset: 0x44 : alarm A sub second register
$40002848 constant RTC_ALRMBR     \ offset: 0x48 : alarm B register
$4000284c constant RTC_ALRMBSSR   \ offset: 0x4C : alarm B sub second register
$40002850 constant RTC_SR         \ offset: 0x50 : status register
$40002854 constant RTC_MISR       \ offset: 0x54 : masked interrupt status register
$4000285c constant RTC_SCR        \ offset: 0x5C : status clear register

