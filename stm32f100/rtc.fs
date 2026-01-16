\
\ @file rtc.fs
\ @brief Real time clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RTC Control Register High
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant RTC_CRH_SECIE                                    \ Second interrupt Enable
$00000002 constant RTC_CRH_ALRIE                                    \ Alarm interrupt Enable
$00000004 constant RTC_CRH_OWIE                                     \ Overflow interrupt Enable


\
\ @brief RTC Control Register Low
\ Address offset: 0x04
\ Reset value: 0x00000020
\

$00000001 constant RTC_CRL_SECF                                     \ Second Flag
$00000002 constant RTC_CRL_ALRF                                     \ Alarm Flag
$00000004 constant RTC_CRL_OWF                                      \ Overflow Flag
$00000008 constant RTC_CRL_RSF                                      \ Registers Synchronized Flag
$00000010 constant RTC_CRL_CNF                                      \ Configuration Flag
$00000020 constant RTC_CRL_RTOFF                                    \ RTC operation OFF


\
\ @brief RTC Prescaler Load Register High
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant RTC_PRLH_PRLH                                    \ RTC Prescaler Load Register High


\
\ @brief RTC Prescaler Load Register Low
\ Address offset: 0x0C
\ Reset value: 0x00008000
\

$0000ffff constant RTC_PRLL_PRLL                                    \ RTC Prescaler Divider Register Low


\
\ @brief RTC Prescaler Divider Register High
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant RTC_DIVH_DIVH                                    \ RTC prescaler divider register high


\
\ @brief RTC Prescaler Divider Register Low
\ Address offset: 0x14
\ Reset value: 0x00008000
\

$0000ffff constant RTC_DIVL_DIVL                                    \ RTC prescaler divider register Low


\
\ @brief RTC Counter Register High
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant RTC_CNTH_CNTH                                    \ RTC counter register high


\
\ @brief RTC Counter Register Low
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant RTC_CNTL_CNTL                                    \ RTC counter register Low


\
\ @brief RTC Alarm Register High
\ Address offset: 0x20
\ Reset value: 0x0000FFFF
\

$0000ffff constant RTC_ALRH_ALRH                                    \ RTC alarm register high


\
\ @brief RTC Alarm Register Low
\ Address offset: 0x24
\ Reset value: 0x0000FFFF
\

$0000ffff constant RTC_ALRL_ALRL                                    \ RTC alarm register low


\
\ @brief Real time clock
\
$40002800 constant RTC_CRH        \ offset: 0x00 : RTC Control Register High
$40002804 constant RTC_CRL        \ offset: 0x04 : RTC Control Register Low
$40002808 constant RTC_PRLH       \ offset: 0x08 : RTC Prescaler Load Register High
$4000280c constant RTC_PRLL       \ offset: 0x0C : RTC Prescaler Load Register Low
$40002810 constant RTC_DIVH       \ offset: 0x10 : RTC Prescaler Divider Register High
$40002814 constant RTC_DIVL       \ offset: 0x14 : RTC Prescaler Divider Register Low
$40002818 constant RTC_CNTH       \ offset: 0x18 : RTC Counter Register High
$4000281c constant RTC_CNTL       \ offset: 0x1C : RTC Counter Register Low
$40002820 constant RTC_ALRH       \ offset: 0x20 : RTC Alarm Register High
$40002824 constant RTC_ALRL       \ offset: 0x24 : RTC Alarm Register Low

