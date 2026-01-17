\
\ @file rtc.fs
\ @brief Real-time clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RTC_DEF

  [ifdef] RTC_TR_DEF
    \
    \ @brief TR
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format
    $16 constant RTC_PM                         \ [0x16] AM/PM notation
  [then]


  [ifdef] RTC_DR_DEF
    \
    \ @brief DR
    \ Address offset: 0x04
    \ Reset value: 0x00002101
    \
    $00 constant RTC_DU                         \ [0x00 : 4] Date units in BCD format
    $04 constant RTC_DT                         \ [0x04 : 2] Date tens in BCD format
    $08 constant RTC_MU                         \ [0x08 : 4] Month units in BCD format
    $0c constant RTC_MT                         \ [0x0c] Month tens in BCD format
    $0d constant RTC_WDU                        \ [0x0d : 3] Week day units
    $10 constant RTC_YU                         \ [0x10 : 4] Year units in BCD format
    $14 constant RTC_YT                         \ [0x14 : 4] Year tens in BCD format
  [then]


  [ifdef] RTC_SSR_DEF
    \
    \ @brief SSR
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Synchronous binary counter
  [then]


  [ifdef] RTC_ICSR_DEF
    \
    \ @brief ICSR
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $02 constant RTC_WUTWF                      \ [0x02] Wakeup timer write flag
    $03 constant RTC_SHPF                       \ [0x03] Shift operation pending
    $04 constant RTC_INITS                      \ [0x04] Initialization status flag
    $05 constant RTC_RSF                        \ [0x05] Registers synchronization flag
    $06 constant RTC_INITF                      \ [0x06] Initialization flag
    $07 constant RTC_INIT                       \ [0x07] Initialization mode
    $08 constant RTC_BIN                        \ [0x08 : 2] Binary mode
    $0a constant RTC_BCDU                       \ [0x0a : 3] BCD update
    $10 constant RTC_RECALPF                    \ [0x10] Recalibration pending Flag
  [then]


  [ifdef] RTC_PRER_DEF
    \
    \ @brief PRER
    \ Address offset: 0x10
    \ Reset value: 0x007F00FF
    \
    $00 constant RTC_PREDIV_S                   \ [0x00 : 15] Synchronous prescaler factor
    $10 constant RTC_PREDIV_A                   \ [0x10 : 7] Asynchronous prescaler factor
  [then]


  [ifdef] RTC_WUTR_DEF
    \
    \ @brief WUTR
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant RTC_WUT                        \ [0x00 : 16] Wakeup auto-reload value bits
    $10 constant RTC_WUTOCLR                    \ [0x10 : 16] Wakeup auto-reload output clear value
  [then]


  [ifdef] RTC_CR_DEF
    \
    \ @brief CR
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RTC_WUCKSEL                    \ [0x00 : 3] Wakeup clock selection
    $03 constant RTC_TSEDGE                     \ [0x03] Timestamp event active edge
    $04 constant RTC_REFCKON                    \ [0x04] RTC_REFIN reference clock detection enable (50 or 60 Hz)
    $05 constant RTC_BYPSHAD                    \ [0x05] Bypass the shadow registers
    $06 constant RTC_FMT                        \ [0x06] Hour format
    $07 constant RTC_SSRUIE                     \ [0x07] SSR underflow interrupt enable
    $08 constant RTC_ALRAE                      \ [0x08] Alarm A enable
    $09 constant RTC_ALRBE                      \ [0x09] Alarm B enable
    $0a constant RTC_WUTE                       \ [0x0a] Wakeup timer enable
    $0b constant RTC_TSE                        \ [0x0b] timestamp enable
    $0c constant RTC_ALRAIE                     \ [0x0c] Alarm A interrupt enable
    $0d constant RTC_ALRBIE                     \ [0x0d] Alarm B interrupt enable
    $0e constant RTC_WUTIE                      \ [0x0e] Wakeup timer interrupt enable
    $0f constant RTC_TSIE                       \ [0x0f] Timestamp interrupt enable
    $10 constant RTC_ADD1H                      \ [0x10] Add 1 hour (summer time change)
    $11 constant RTC_SUB1H                      \ [0x11] Subtract 1 hour (winter time change)
    $12 constant RTC_BKP                        \ [0x12] Backup
    $13 constant RTC_COSEL                      \ [0x13] Calibration output selection
    $14 constant RTC_POL                        \ [0x14] Output polarity
    $15 constant RTC_OSEL                       \ [0x15 : 2] Output selection
    $17 constant RTC_COE                        \ [0x17] Calibration output enable
    $18 constant RTC_ITSE                       \ [0x18] timestamp on internal event enable
    $19 constant RTC_TAMPTS                     \ [0x19] Activate timestamp on tamper detection event
    $1a constant RTC_TAMPOE                     \ [0x1a] Tamper detection output enable on TAMPALRM
    $1d constant RTC_TAMPALRM_PU                \ [0x1d] TAMPALRM pull-up enable
    $1e constant RTC_TAMPALRM_TYPE              \ [0x1e] TAMPALRM output type
    $1f constant RTC_OUT2EN                     \ [0x1f] RTC_OUT2 output enable
  [then]


  [ifdef] RTC_WPR_DEF
    \
    \ @brief write protection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RTC_KEY                        \ [0x00 : 8] Write protection key
  [then]


  [ifdef] RTC_CALR_DEF
    \
    \ @brief CALR
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALM                       \ [0x00 : 9] Calibration minus
    $0c constant RTC_LPCAL                      \ [0x0c] Calibration low-power mode
    $0d constant RTC_CALW16                     \ [0x0d] CALW16
    $0e constant RTC_CALW8                      \ [0x0e] Use a 16-second calibration cycle period
    $0f constant RTC_CALP                       \ [0x0f] Use an 8-second calibration cycle period
  [then]


  [ifdef] RTC_SHIFTR_DEF
    \
    \ @brief SHIFTR
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SUBFS                      \ [0x00 : 15] Subtract a fraction of a second
    $1f constant RTC_ADD1S                      \ [0x1f] Add one second
  [then]


  [ifdef] RTC_TSTR_DEF
    \
    \ @brief TSTR
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format.
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format.
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format.
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format.
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format.
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format.
    $16 constant RTC_PM                         \ [0x16] AM/PM notation
  [then]


  [ifdef] RTC_TSDR_DEF
    \
    \ @brief TSDR
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RTC_DU                         \ [0x00 : 4] Date units in BCD format
    $04 constant RTC_DT                         \ [0x04 : 2] Date tens in BCD format
    $08 constant RTC_MU                         \ [0x08 : 4] Month units in BCD format
    $0c constant RTC_MT                         \ [0x0c] Month tens in BCD format
    $0d constant RTC_WDU                        \ [0x0d : 3] Week day units
  [then]


  [ifdef] RTC_TSSSR_DEF
    \
    \ @brief TSSSR
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Sub second value
  [then]


  [ifdef] RTC_ALRMAR_DEF
    \
    \ @brief ALRMAR
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format.
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format.
    $07 constant RTC_MSK1                       \ [0x07] Alarm A seconds mask
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format
    $0f constant RTC_MSK2                       \ [0x0f] Alarm A minutes mask
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format
    $16 constant RTC_PM                         \ [0x16] AM/PM notation
    $17 constant RTC_MSK3                       \ [0x17] Alarm A hours mask
    $18 constant RTC_DU                         \ [0x18 : 4] Date units or day in BCD format
    $1c constant RTC_DT                         \ [0x1c : 2] Date tens in BCD format
    $1e constant RTC_WDSEL                      \ [0x1e] Week day selection
    $1f constant RTC_MSK4                       \ [0x1f] Alarm A date mask
  [then]


  [ifdef] RTC_ALRMASSR_DEF
    \
    \ @brief ALRMASSR
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value
    $18 constant RTC_MASKSS                     \ [0x18 : 6] Mask the most-significant bits starting at this bit
    $1f constant RTC_SSCLR                      \ [0x1f] Clear synchronous counter on alarm (Binary mode only)
  [then]


  [ifdef] RTC_ALRMBR_DEF
    \
    \ @brief ALRMBR
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format
    $07 constant RTC_MSK1                       \ [0x07] Alarm B seconds mask
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format
    $0f constant RTC_MSK2                       \ [0x0f] Alarm B minutes mask
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format
    $16 constant RTC_PM                         \ [0x16] AM/PM notation
    $17 constant RTC_MSK3                       \ [0x17] Alarm B hours mask
    $18 constant RTC_DU                         \ [0x18 : 4] Date units or day in BCD format
    $1c constant RTC_DT                         \ [0x1c : 2] Date tens in BCD format
    $1e constant RTC_WDSEL                      \ [0x1e] Week day selection
    $1f constant RTC_MSK4                       \ [0x1f] Alarm B date mask
  [then]


  [ifdef] RTC_ALRMBSSR_DEF
    \
    \ @brief ALRMBSSR
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value
    $18 constant RTC_MASKSS                     \ [0x18 : 6] Mask the most-significant bits starting at this bit
    $1f constant RTC_SSCLR                      \ [0x1f] Clear synchronous counter on alarm (Binary mode only)
  [then]


  [ifdef] RTC_SR_DEF
    \
    \ @brief SR
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAF                      \ [0x00] Alarm A flag
    $01 constant RTC_ALRBF                      \ [0x01] Alarm B flag
    $02 constant RTC_WUTF                       \ [0x02] Wakeup timer flag
    $03 constant RTC_TSF                        \ [0x03] Timestamp flag
    $04 constant RTC_TSOVF                      \ [0x04] Timestamp overflow flag
    $05 constant RTC_ITSF                       \ [0x05] Internal timestamp flag
    $06 constant RTC_SSRUF                      \ [0x06] SSR underflow flag
  [then]


  [ifdef] RTC_MISR_DEF
    \
    \ @brief MISR
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAMF                     \ [0x00] Alarm A masked flag
    $01 constant RTC_ALRBMF                     \ [0x01] Alarm B masked flag
    $02 constant RTC_WUTMF                      \ [0x02] Wakeup timer masked flag
    $03 constant RTC_TSMF                       \ [0x03] Timestamp masked flag
    $04 constant RTC_TSOVMF                     \ [0x04] Timestamp overflow masked flag
    $05 constant RTC_ITSMF                      \ [0x05] Internal timestamp masked flag
    $06 constant RTC_SSRUMF                     \ [0x06] SSR underflow masked flag
  [then]


  [ifdef] RTC_SCR_DEF
    \
    \ @brief SCR
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALRAF                     \ [0x00] Clear alarm A flag
    $01 constant RTC_CALRBF                     \ [0x01] Clear alarm B flag
    $02 constant RTC_CWUTF                      \ [0x02] Clear wakeup timer flag
    $03 constant RTC_CTSF                       \ [0x03] Clear timestamp flag
    $04 constant RTC_CTSOVF                     \ [0x04] Clear timestamp overflow flag
    $05 constant RTC_CITSF                      \ [0x05] Clear internal timestamp flag
    $06 constant RTC_CSSRUF                     \ [0x06] Clear SSR underflow flag
  [then]


  [ifdef] RTC_ALRABINR_DEF
    \
    \ @brief RTC alarm A binary mode register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Synchronous counter alarm value in Binary mode
  [then]


  [ifdef] RTC_ALRBBINR_DEF
    \
    \ @brief RTC alarm B binary mode register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Synchronous counter alarm value in Binary mode
  [then]

  \
  \ @brief Real-time clock
  \
  $00 constant RTC_TR                   \ TR
  $04 constant RTC_DR                   \ DR
  $08 constant RTC_SSR                  \ SSR
  $0C constant RTC_ICSR                 \ ICSR
  $10 constant RTC_PRER                 \ PRER
  $14 constant RTC_WUTR                 \ WUTR
  $18 constant RTC_CR                   \ CR
  $24 constant RTC_WPR                  \ write protection register
  $28 constant RTC_CALR                 \ CALR
  $2C constant RTC_SHIFTR               \ SHIFTR
  $30 constant RTC_TSTR                 \ TSTR
  $34 constant RTC_TSDR                 \ TSDR
  $38 constant RTC_TSSSR                \ TSSSR
  $40 constant RTC_ALRMAR               \ ALRMAR
  $44 constant RTC_ALRMASSR             \ ALRMASSR
  $48 constant RTC_ALRMBR               \ ALRMBR
  $4C constant RTC_ALRMBSSR             \ ALRMBSSR
  $50 constant RTC_SR                   \ SR
  $54 constant RTC_MISR                 \ MISR
  $5C constant RTC_SCR                  \ SCR
  $70 constant RTC_ALRABINR             \ RTC alarm A binary mode register
  $74 constant RTC_ALRBBINR             \ RTC alarm B binary mode register

: RTC_DEF ; [then]
