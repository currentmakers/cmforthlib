\
\ @file rtc.fs
\ @brief Real time clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RTC_DEF

  [ifdef] RTC_CRH_DEF
    \
    \ @brief RTC Control Register High
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SECIE                      \ [0x00] Second interrupt Enable
    $01 constant RTC_ALRIE                      \ [0x01] Alarm interrupt Enable
    $02 constant RTC_OWIE                       \ [0x02] Overflow interrupt Enable
  [then]


  [ifdef] RTC_CRL_DEF
    \
    \ @brief RTC Control Register Low
    \ Address offset: 0x04
    \ Reset value: 0x00000020
    \
    $00 constant RTC_SECF                       \ [0x00] Second Flag
    $01 constant RTC_ALRF                       \ [0x01] Alarm Flag
    $02 constant RTC_OWF                        \ [0x02] Overflow Flag
    $03 constant RTC_RSF                        \ [0x03] Registers Synchronized Flag
    $04 constant RTC_CNF                        \ [0x04] Configuration Flag
    $05 constant RTC_RTOFF                      \ [0x05] RTC operation OFF
  [then]


  [ifdef] RTC_PRLH_DEF
    \
    \ @brief RTC Prescaler Load Register High
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_PRLH                       \ [0x00 : 4] RTC Prescaler Load Register High
  [then]


  [ifdef] RTC_PRLL_DEF
    \
    \ @brief RTC Prescaler Load Register Low
    \ Address offset: 0x0C
    \ Reset value: 0x00008000
    \
    $00 constant RTC_PRLL                       \ [0x00 : 16] RTC Prescaler Divider Register Low
  [then]


  [ifdef] RTC_DIVH_DEF
    \
    \ @brief RTC Prescaler Divider Register High
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RTC_DIVH                       \ [0x00 : 4] RTC prescaler divider register high
  [then]


  [ifdef] RTC_DIVL_DEF
    \
    \ @brief RTC Prescaler Divider Register Low
    \ Address offset: 0x14
    \ Reset value: 0x00008000
    \
    $00 constant RTC_DIVL                       \ [0x00 : 16] RTC prescaler divider register Low
  [then]


  [ifdef] RTC_CNTH_DEF
    \
    \ @brief RTC Counter Register High
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CNTH                       \ [0x00 : 16] RTC counter register high
  [then]


  [ifdef] RTC_CNTL_DEF
    \
    \ @brief RTC Counter Register Low
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CNTL                       \ [0x00 : 16] RTC counter register Low
  [then]


  [ifdef] RTC_ALRH_DEF
    \
    \ @brief RTC Alarm Register High
    \ Address offset: 0x20
    \ Reset value: 0x0000FFFF
    \
    $00 constant RTC_ALRH                       \ [0x00 : 16] RTC alarm register high
  [then]


  [ifdef] RTC_ALRL_DEF
    \
    \ @brief RTC Alarm Register Low
    \ Address offset: 0x24
    \ Reset value: 0x0000FFFF
    \
    $00 constant RTC_ALRL                       \ [0x00 : 16] RTC alarm register low
  [then]

  \
  \ @brief Real time clock
  \
  $00 constant RTC_CRH                  \ RTC Control Register High
  $04 constant RTC_CRL                  \ RTC Control Register Low
  $08 constant RTC_PRLH                 \ RTC Prescaler Load Register High
  $0C constant RTC_PRLL                 \ RTC Prescaler Load Register Low
  $10 constant RTC_DIVH                 \ RTC Prescaler Divider Register High
  $14 constant RTC_DIVL                 \ RTC Prescaler Divider Register Low
  $18 constant RTC_CNTH                 \ RTC Counter Register High
  $1C constant RTC_CNTL                 \ RTC Counter Register Low
  $20 constant RTC_ALRH                 \ RTC Alarm Register High
  $24 constant RTC_ALRL                 \ RTC Alarm Register Low

: RTC_DEF ; [then]
