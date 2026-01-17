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
    \ @brief time register
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
    \ @brief date register
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
    \ @brief sub second register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] Sub second value
  [then]


  [ifdef] RTC_ICSR_DEF
    \
    \ @brief initialization and status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $00 constant RTC_ALRAWF                     \ [0x00] Alarm A write flag
    $01 constant RTC_ALRBWF                     \ [0x01] Alarm B write flag
    $02 constant RTC_WUTWF                      \ [0x02] Wakeup timer write flag
    $03 constant RTC_SHPF                       \ [0x03] Shift operation pending
    $04 constant RTC_INITS                      \ [0x04] Initialization status flag
    $05 constant RTC_RSF                        \ [0x05] Registers synchronization flag
    $06 constant RTC_INITF                      \ [0x06] Initialization flag
    $07 constant RTC_INIT                       \ [0x07] Initialization mode
    $10 constant RTC_RECALPF                    \ [0x10] Recalibration pending Flag
  [then]


  [ifdef] RTC_PRER_DEF
    \
    \ @brief prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x007F00FF
    \
    $00 constant RTC_PREDIV_S                   \ [0x00 : 15] Synchronous prescaler factor
    $10 constant RTC_PREDIV_A                   \ [0x10 : 7] Asynchronous prescaler factor
  [then]


  [ifdef] RTC_WUTR_DEF
    \
    \ @brief wakeup timer register
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant RTC_WUT                        \ [0x00 : 16] Wakeup auto-reload value bits
  [then]


  [ifdef] RTC_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RTC_WUCKSEL                    \ [0x00 : 3] WUCKSEL
    $03 constant RTC_TSEDGE                     \ [0x03] TSEDGE
    $04 constant RTC_REFCKON                    \ [0x04] REFCKON
    $05 constant RTC_BYPSHAD                    \ [0x05] BYPSHAD
    $06 constant RTC_FMT                        \ [0x06] FMT
    $08 constant RTC_ALRAE                      \ [0x08] ALRAE
    $09 constant RTC_ALRBE                      \ [0x09] ALRBE
    $0a constant RTC_WUTE                       \ [0x0a] WUTE
    $0b constant RTC_TSE                        \ [0x0b] TSE
    $0c constant RTC_ALRAIE                     \ [0x0c] ALRAIE
    $0d constant RTC_ALRBIE                     \ [0x0d] ALRBIE
    $0e constant RTC_WUTIE                      \ [0x0e] WUTIE
    $0f constant RTC_TSIE                       \ [0x0f] TSIE
    $10 constant RTC_ADD1H                      \ [0x10] ADD1H
    $11 constant RTC_SUB1H                      \ [0x11] SUB1H
    $12 constant RTC_BKP                        \ [0x12] BKP
    $13 constant RTC_COSEL                      \ [0x13] COSEL
    $14 constant RTC_POL                        \ [0x14] POL
    $15 constant RTC_OSEL                       \ [0x15 : 2] OSEL
    $17 constant RTC_COE                        \ [0x17] COE
    $18 constant RTC_ITSE                       \ [0x18] ITSE
    $19 constant RTC_TAMPTS                     \ [0x19] TAMPTS
    $1a constant RTC_TAMPOE                     \ [0x1a] TAMPOE
    $1d constant RTC_TAMPALRM_PU                \ [0x1d] TAMPALRM_PU
    $1e constant RTC_TAMPALRM_TYPE              \ [0x1e] TAMPALRM_TYPE
    $1f constant RTC_OUT2EN                     \ [0x1f] OUT2EN
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
    \ @brief calibration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALM                       \ [0x00 : 9] Calibration minus
    $0d constant RTC_CALW16                     \ [0x0d] Use a 16-second calibration cycle period
    $0e constant RTC_CALW8                      \ [0x0e] Use an 8-second calibration cycle period
    $0f constant RTC_CALP                       \ [0x0f] Increase frequency of RTC by 488.5 ppm
  [then]


  [ifdef] RTC_SHIFTR_DEF
    \
    \ @brief shift control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SUBFS                      \ [0x00 : 15] Subtract a fraction of a second
    $1f constant RTC_ADD1S                      \ [0x1f] Add one second
  [then]


  [ifdef] RTC_TSTR_DEF
    \
    \ @brief time stamp time register
    \ Address offset: 0x30
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


  [ifdef] RTC_TSDR_DEF
    \
    \ @brief time stamp date register
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
    \ @brief timestamp sub second register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] Sub second value
  [then]


  [ifdef] RTC_ALRMAR_DEF
    \
    \ @brief alarm A register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format
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
    \ @brief alarm A sub second register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value
    $18 constant RTC_MASKSS                     \ [0x18 : 4] Mask the most-significant bits starting at this bit
  [then]


  [ifdef] RTC_ALRMBR_DEF
    \
    \ @brief alarm B register
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
    \ @brief alarm B sub second register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value
    $18 constant RTC_MASKSS                     \ [0x18 : 4] Mask the most-significant bits starting at this bit
  [then]


  [ifdef] RTC_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAF                      \ [0x00] ALRAF
    $01 constant RTC_ALRBF                      \ [0x01] ALRBF
    $02 constant RTC_WUTF                       \ [0x02] WUTF
    $03 constant RTC_TSF                        \ [0x03] TSF
    $04 constant RTC_TSOVF                      \ [0x04] TSOVF
    $05 constant RTC_ITSF                       \ [0x05] ITSF
  [then]


  [ifdef] RTC_MISR_DEF
    \
    \ @brief masked interrupt status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAMF                     \ [0x00] ALRAMF
    $01 constant RTC_ALRBMF                     \ [0x01] ALRBMF
    $02 constant RTC_WUTMF                      \ [0x02] WUTMF
    $03 constant RTC_TSMF                       \ [0x03] TSMF
    $04 constant RTC_TSOVMF                     \ [0x04] TSOVMF
    $05 constant RTC_ITSMF                      \ [0x05] ITSMF
  [then]


  [ifdef] RTC_SCR_DEF
    \
    \ @brief status clear register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALRAF                     \ [0x00] CALRAF
    $01 constant RTC_CALRBF                     \ [0x01] CALRBF
    $02 constant RTC_CWUTF                      \ [0x02] CWUTF
    $03 constant RTC_CTSF                       \ [0x03] CTSF
    $04 constant RTC_CTSOVF                     \ [0x04] CTSOVF
    $05 constant RTC_CITSF                      \ [0x05] CITSF
  [then]


  [ifdef] RTC_HWCFGR_DEF
    \
    \ @brief hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALARMB                     \ [0x00 : 4] ALARMB
    $04 constant RTC_WAKEUP                     \ [0x04 : 4] WAKEUP
    $08 constant RTC_SMOOTH_CALIB               \ [0x08 : 4] SMOOTH_CALIB
    $0c constant RTC_TIMESTAMP                  \ [0x0c : 4] TIMESTAMP
    $10 constant RTC_OPTIONREG_OUT              \ [0x10 : 8] OPTIONREG_OUT
    $18 constant RTC_TRUST_ZONE                 \ [0x18 : 4] TRUST_ZONE
  [then]


  [ifdef] RTC_VERR_DEF
    \
    \ @brief EXTI IP Version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant RTC_MINREV                     \ [0x00 : 4] Minor Revision number
    $04 constant RTC_MAJREV                     \ [0x04 : 4] Major Revision number
  [then]


  [ifdef] RTC_IPIDR_DEF
    \
    \ @brief EXTI Identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00120033
    \
    $00 constant RTC_IPID                       \ [0x00 : 32] IP Identification
  [then]


  [ifdef] RTC_SIDR_DEF
    \
    \ @brief EXTI Size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant RTC_SID                        \ [0x00 : 32] Size Identification
  [then]

  \
  \ @brief Real-time clock
  \
  $00 constant RTC_TR                   \ time register
  $04 constant RTC_DR                   \ date register
  $08 constant RTC_SSR                  \ sub second register
  $0C constant RTC_ICSR                 \ initialization and status register
  $10 constant RTC_PRER                 \ prescaler register
  $14 constant RTC_WUTR                 \ wakeup timer register
  $18 constant RTC_CR                   \ control register
  $24 constant RTC_WPR                  \ write protection register
  $28 constant RTC_CALR                 \ calibration register
  $2C constant RTC_SHIFTR               \ shift control register
  $30 constant RTC_TSTR                 \ time stamp time register
  $34 constant RTC_TSDR                 \ time stamp date register
  $38 constant RTC_TSSSR                \ timestamp sub second register
  $40 constant RTC_ALRMAR               \ alarm A register
  $44 constant RTC_ALRMASSR             \ alarm A sub second register
  $48 constant RTC_ALRMBR               \ alarm B register
  $4C constant RTC_ALRMBSSR             \ alarm B sub second register
  $50 constant RTC_SR                   \ status register
  $54 constant RTC_MISR                 \ masked interrupt status register
  $5C constant RTC_SCR                  \ status clear register
  $3F0 constant RTC_HWCFGR              \ hardware configuration register
  $3F4 constant RTC_VERR                \ EXTI IP Version register
  $3F8 constant RTC_IPIDR               \ EXTI Identification register
  $3FC constant RTC_SIDR                \ EXTI Size ID register

: RTC_DEF ; [then]
