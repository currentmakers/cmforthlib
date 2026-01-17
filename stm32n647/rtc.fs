\
\ @file rtc.fs
\ @brief Real-time clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RTC_DEF

  [ifdef] RTC_RTC_TR_DEF
    \
    \ @brief RTC time register
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


  [ifdef] RTC_RTC_DR_DEF
    \
    \ @brief RTC date register
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


  [ifdef] RTC_RTC_SSR_DEF
    \
    \ @brief RTC subsecond register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Synchronous binary counter
  [then]


  [ifdef] RTC_RTC_ICSR_DEF
    \
    \ @brief RTC initialization control and status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $02 constant RTC_WUTWF                      \ [0x02] Wake-up timer write flag
    $03 constant RTC_SHPF                       \ [0x03] Shift operation pending
    $04 constant RTC_INITS                      \ [0x04] Initialization status flag
    $05 constant RTC_RSF                        \ [0x05] Registers synchronization flag
    $06 constant RTC_INITF                      \ [0x06] Initialization flag
    $07 constant RTC_INIT                       \ [0x07] Initialization mode
    $08 constant RTC_BIN                        \ [0x08 : 2] Binary mode
    $0a constant RTC_BCDU                       \ [0x0a : 3] BCD update (BIN = 10 or 11)
    $10 constant RTC_RECALPF                    \ [0x10] Recalibration pending Flag
  [then]


  [ifdef] RTC_RTC_PRER_DEF
    \
    \ @brief RTC prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x007F00FF
    \
    $00 constant RTC_PREDIV_S                   \ [0x00 : 15] Synchronous prescaler factor
    $10 constant RTC_PREDIV_A                   \ [0x10 : 7] Asynchronous prescaler factor
  [then]


  [ifdef] RTC_RTC_WUTR_DEF
    \
    \ @brief RTC wake-up timer register
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant RTC_WUT                        \ [0x00 : 16] Wake-up auto-reload value bits
    $10 constant RTC_WUTOCLR                    \ [0x10 : 16] Wake-up auto-reload output clear value
  [then]


  [ifdef] RTC_RTC_CR_DEF
    \
    \ @brief RTC control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RTC_WUCKSEL                    \ [0x00 : 3] ck_wut wake-up clock selection
    $03 constant RTC_TSEDGE                     \ [0x03] Timestamp event active edge
    $04 constant RTC_REFCKON                    \ [0x04] RTC_REFIN reference clock detection enable (50 or 60 Hz)
    $05 constant RTC_BYPSHAD                    \ [0x05] Bypass the shadow registers
    $06 constant RTC_FMT                        \ [0x06] Hour format
    $07 constant RTC_SSRUIE                     \ [0x07] SSR underflow interrupt enable
    $08 constant RTC_ALRAE                      \ [0x08] Alarm A enable
    $09 constant RTC_ALRBE                      \ [0x09] Alarm B enable
    $0a constant RTC_WUTE                       \ [0x0a] Wake-up timer enable
    $0b constant RTC_TSE                        \ [0x0b] timestamp enable
    $0c constant RTC_ALRAIE                     \ [0x0c] Alarm A interrupt enable
    $0d constant RTC_ALRBIE                     \ [0x0d] Alarm B interrupt enable
    $0e constant RTC_WUTIE                      \ [0x0e] Wake-up timer interrupt enable
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
    $1b constant RTC_ALRAFCLR                   \ [0x1b] Alarm A flag automatic clear
    $1c constant RTC_ALRBFCLR                   \ [0x1c] Alarm B flag automatic clear
    $1d constant RTC_TAMPALRM_PU                \ [0x1d] TAMPALRM pull-up enable
    $1e constant RTC_TAMPALRM_TYPE              \ [0x1e] TAMPALRM output type
    $1f constant RTC_OUT2EN                     \ [0x1f] RTC_OUT2 output enable
  [then]


  [ifdef] RTC_RTC_PRIVCFGR_DEF
    \
    \ @brief RTC privilege mode control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAPRIV                   \ [0x00] Alarm A and SSR underflow privilege protection
    $01 constant RTC_ALRBPRIV                   \ [0x01] Alarm B privilege protection
    $02 constant RTC_WUTPRIV                    \ [0x02] Wake-up timer privilege protection
    $03 constant RTC_TSPRIV                     \ [0x03] Timestamp privilege protection
    $0d constant RTC_CALPRIV                    \ [0x0d] Shift register, Delight saving, calibration and reference clock privilege protection
    $0e constant RTC_INITPRIV                   \ [0x0e] Initialization privilege protection
    $0f constant RTC_PRIV                       \ [0x0f] RTC privilege protection
  [then]


  [ifdef] RTC_RTC_SECCFGR_DEF
    \
    \ @brief RTC secure configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRASEC                    \ [0x00] Alarm A and SSR underflow protection
    $01 constant RTC_ALRBSEC                    \ [0x01] Alarm B protection
    $02 constant RTC_WUTSEC                     \ [0x02] Wake-up timer protection
    $03 constant RTC_TSSEC                      \ [0x03] Timestamp protection
    $0d constant RTC_CALSEC                     \ [0x0d] Shift register, daylight saving, calibration and reference clock protection
    $0e constant RTC_INITSEC                    \ [0x0e] Initialization protection
    $0f constant RTC_SEC                        \ [0x0f] RTC global protection
  [then]


  [ifdef] RTC_RTC_WPR_DEF
    \
    \ @brief RTC write protection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RTC_KEY                        \ [0x00 : 8] Write protection key
  [then]


  [ifdef] RTC_RTC_CALR_DEF
    \
    \ @brief RTC calibration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALM                       \ [0x00 : 9] Calibration minus
    $0c constant RTC_LPCAL                      \ [0x0c] RTC low-power mode
    $0d constant RTC_CALW16                     \ [0x0d] Use a 16-second calibration cycle period
    $0e constant RTC_CALW8                      \ [0x0e] Use an 8-second calibration cycle period
    $0f constant RTC_CALP                       \ [0x0f] Increase frequency of RTC by 488.5 ppm
  [then]


  [ifdef] RTC_RTC_SHIFTR_DEF
    \
    \ @brief RTC shift control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SUBFS                      \ [0x00 : 15] Subtract a fraction of a second
    $1f constant RTC_ADD1S                      \ [0x1f] Add one second
  [then]


  [ifdef] RTC_RTC_TSTR_DEF
    \
    \ @brief RTC timestamp time register
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


  [ifdef] RTC_RTC_TSDR_DEF
    \
    \ @brief RTC timestamp date register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RTC_DU                         \ [0x00 : 4] Date units in BCD format
    $04 constant RTC_DT                         \ [0x04 : 2] Date tens in BCD format
    $08 constant RTC_MU                         \ [0x08 : 4] Month units in BCD format
    $0c constant RTC_MT                         \ [0x0c] Month tens in BCD format
    $0d constant RTC_WDU                        \ [0x0d : 3] Week day units
  [then]


  [ifdef] RTC_RTC_TSSSR_DEF
    \
    \ @brief RTC timestamp subsecond register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Subsecond value/synchronous binary counter values
  [then]


  [ifdef] RTC_RTC_ALRMAR_DEF
    \
    \ @brief RTC alarm A register
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


  [ifdef] RTC_RTC_ALRMASSR_DEF
    \
    \ @brief RTC alarm A subsecond register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Subseconds value
    $18 constant RTC_MASKSS                     \ [0x18 : 6] Mask the most-significant bits starting at this bit
    $1f constant RTC_SSCLR                      \ [0x1f] Clear synchronous counter on alarm (Binary mode only)
  [then]


  [ifdef] RTC_RTC_ALRMBR_DEF
    \
    \ @brief RTC alarm B register
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


  [ifdef] RTC_RTC_ALRMBSSR_DEF
    \
    \ @brief RTC alarm B subsecond register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Subseconds value
    $18 constant RTC_MASKSS                     \ [0x18 : 6] Mask the most-significant bits starting at this bit
    $1f constant RTC_SSCLR                      \ [0x1f] Clear synchronous counter on alarm (Binary mode only)
  [then]


  [ifdef] RTC_RTC_SR_DEF
    \
    \ @brief RTC status register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAF                      \ [0x00] Alarm A flag
    $01 constant RTC_ALRBF                      \ [0x01] Alarm B flag
    $02 constant RTC_WUTF                       \ [0x02] Wake-up timer flag
    $03 constant RTC_TSF                        \ [0x03] Timestamp flag
    $04 constant RTC_TSOVF                      \ [0x04] Timestamp overflow flag
    $05 constant RTC_ITSF                       \ [0x05] Internal timestamp flag
    $06 constant RTC_SSRUF                      \ [0x06] SSR underflow flag
  [then]


  [ifdef] RTC_RTC_MISR_DEF
    \
    \ @brief RTC non-secure masked interrupt status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAMF                     \ [0x00] Alarm A masked flag
    $01 constant RTC_ALRBMF                     \ [0x01] Alarm B non-secure masked flag
    $02 constant RTC_WUTMF                      \ [0x02] Wake-up timer non-secure masked flag
    $03 constant RTC_TSMF                       \ [0x03] Timestamp non-secure masked flag
    $04 constant RTC_TSOVMF                     \ [0x04] Timestamp overflow non-secure masked flag
    $05 constant RTC_ITSMF                      \ [0x05] Internal timestamp non-secure masked flag
    $06 constant RTC_SSRUMF                     \ [0x06] SSR underflow non-secure masked flag
  [then]


  [ifdef] RTC_RTC_SMISR_DEF
    \
    \ @brief RTC secure masked interrupt status register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAMF                     \ [0x00] Alarm A interrupt secure masked flag
    $01 constant RTC_ALRBMF                     \ [0x01] Alarm B interrupt secure masked flag
    $02 constant RTC_WUTMF                      \ [0x02] Wake-up timer interrupt secure masked flag
    $03 constant RTC_TSMF                       \ [0x03] Timestamp interrupt secure masked flag
    $04 constant RTC_TSOVMF                     \ [0x04] Timestamp overflow interrupt secure masked flag
    $05 constant RTC_ITSMF                      \ [0x05] Internal timestamp interrupt secure masked flag
    $06 constant RTC_SSRUMF                     \ [0x06] SSR underflow secure masked flag
  [then]


  [ifdef] RTC_RTC_SCR_DEF
    \
    \ @brief RTC status clear register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALRAF                     \ [0x00] Clear alarm A flag
    $01 constant RTC_CALRBF                     \ [0x01] Clear alarm B flag
    $02 constant RTC_CWUTF                      \ [0x02] Clear wake-up timer flag
    $03 constant RTC_CTSF                       \ [0x03] Clear timestamp flag
    $04 constant RTC_CTSOVF                     \ [0x04] Clear timestamp overflow flag
    $05 constant RTC_CITSF                      \ [0x05] Clear internal timestamp flag
    $06 constant RTC_CSSRUF                     \ [0x06] Clear SSR underflow flag
  [then]


  [ifdef] RTC_RTC_ALRABINR_DEF
    \
    \ @brief RTC alarm A binary mode register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Synchronous counter alarm value in Binary mode
  [then]


  [ifdef] RTC_RTC_ALRBBINR_DEF
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
  $00 constant RTC_RTC_TR               \ RTC time register
  $04 constant RTC_RTC_DR               \ RTC date register
  $08 constant RTC_RTC_SSR              \ RTC subsecond register
  $0C constant RTC_RTC_ICSR             \ RTC initialization control and status register
  $10 constant RTC_RTC_PRER             \ RTC prescaler register
  $14 constant RTC_RTC_WUTR             \ RTC wake-up timer register
  $18 constant RTC_RTC_CR               \ RTC control register
  $1C constant RTC_RTC_PRIVCFGR         \ RTC privilege mode control register
  $20 constant RTC_RTC_SECCFGR          \ RTC secure configuration register
  $24 constant RTC_RTC_WPR              \ RTC write protection register
  $28 constant RTC_RTC_CALR             \ RTC calibration register
  $2C constant RTC_RTC_SHIFTR           \ RTC shift control register
  $30 constant RTC_RTC_TSTR             \ RTC timestamp time register
  $34 constant RTC_RTC_TSDR             \ RTC timestamp date register
  $38 constant RTC_RTC_TSSSR            \ RTC timestamp subsecond register
  $40 constant RTC_RTC_ALRMAR           \ RTC alarm A register
  $44 constant RTC_RTC_ALRMASSR         \ RTC alarm A subsecond register
  $48 constant RTC_RTC_ALRMBR           \ RTC alarm B register
  $4C constant RTC_RTC_ALRMBSSR         \ RTC alarm B subsecond register
  $50 constant RTC_RTC_SR               \ RTC status register
  $54 constant RTC_RTC_MISR             \ RTC non-secure masked interrupt status register
  $58 constant RTC_RTC_SMISR            \ RTC secure masked interrupt status register
  $5C constant RTC_RTC_SCR              \ RTC status clear register
  $70 constant RTC_RTC_ALRABINR         \ RTC alarm A binary mode register
  $74 constant RTC_RTC_ALRBBINR         \ RTC alarm B binary mode register

: RTC_DEF ; [then]
