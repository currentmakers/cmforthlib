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


  [ifdef] RTC_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_WCKSEL                     \ [0x00 : 3] Wakeup clock selection
    $03 constant RTC_TSEDGE                     \ [0x03] Time-stamp event active edge
    $04 constant RTC_REFCKON                    \ [0x04] Reference clock detection enable (50 or 60 Hz)
    $05 constant RTC_BYPSHAD                    \ [0x05] Bypass the shadow registers
    $06 constant RTC_FMT                        \ [0x06] Hour format
    $08 constant RTC_ALRAE                      \ [0x08] Alarm A enable
    $09 constant RTC_ALRBE                      \ [0x09] Alarm B enable
    $0a constant RTC_WUTE                       \ [0x0a] Wakeup timer enable
    $0b constant RTC_TSE                        \ [0x0b] Time stamp enable
    $0c constant RTC_ALRAIE                     \ [0x0c] Alarm A interrupt enable
    $0d constant RTC_ALRBIE                     \ [0x0d] Alarm B interrupt enable
    $0e constant RTC_WUTIE                      \ [0x0e] Wakeup timer interrupt enable
    $0f constant RTC_TSIE                       \ [0x0f] Time-stamp interrupt enable
    $10 constant RTC_ADD1H                      \ [0x10] Add 1 hour (summer time change)
    $11 constant RTC_SUB1H                      \ [0x11] Subtract 1 hour (winter time change)
    $12 constant RTC_BKP                        \ [0x12] Backup
    $13 constant RTC_COSEL                      \ [0x13] Calibration output selection
    $14 constant RTC_POL                        \ [0x14] Output polarity
    $15 constant RTC_OSEL                       \ [0x15 : 2] Output selection
    $17 constant RTC_COE                        \ [0x17] Calibration output enable
    $18 constant RTC_ITSE                       \ [0x18] timestamp on internal event enable
  [then]


  [ifdef] RTC_ISR_DEF
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
    $08 constant RTC_ALRAF                      \ [0x08] Alarm A flag
    $09 constant RTC_ALRBF                      \ [0x09] Alarm B flag
    $0a constant RTC_WUTF                       \ [0x0a] Wakeup timer flag
    $0b constant RTC_TSF                        \ [0x0b] Time-stamp flag
    $0c constant RTC_TSOVF                      \ [0x0c] Time-stamp overflow flag
    $0d constant RTC_TAMP1F                     \ [0x0d] Tamper detection flag
    $0e constant RTC_TAMP2F                     \ [0x0e] RTC_TAMP2 detection flag
    $0f constant RTC_TAMP3F                     \ [0x0f] RTC_TAMP3 detection flag
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


  [ifdef] RTC_ALRMAR_DEF
    \
    \ @brief alarm A register
    \ Address offset: 0x1C
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


  [ifdef] RTC_ALRMBR_DEF
    \
    \ @brief alarm B register
    \ Address offset: 0x20
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


  [ifdef] RTC_WPR_DEF
    \
    \ @brief write protection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RTC_KEY                        \ [0x00 : 8] Write protection key
  [then]


  [ifdef] RTC_SSR_DEF
    \
    \ @brief sub second register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] Sub second value
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


  [ifdef] RTC_CALR_DEF
    \
    \ @brief calibration register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALM                       \ [0x00 : 9] Calibration minus
    $0d constant RTC_CALW16                     \ [0x0d] Use a 16-second calibration cycle period
    $0e constant RTC_CALW8                      \ [0x0e] Use an 8-second calibration cycle period
    $0f constant RTC_CALP                       \ [0x0f] Increase frequency of RTC by 488.5 ppm
  [then]


  [ifdef] RTC_TAMPCR_DEF
    \
    \ @brief tamper configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RTC_TAMP1E                     \ [0x00] Tamper 1 detection enable
    $01 constant RTC_TAMP1TRG                   \ [0x01] Active level for tamper 1
    $02 constant RTC_TAMPIE                     \ [0x02] Tamper interrupt enable
    $03 constant RTC_TAMP2E                     \ [0x03] Tamper 2 detection enable
    $04 constant RTC_TAMP2TRG                   \ [0x04] Active level for tamper 2
    $05 constant RTC_TAMP3E                     \ [0x05] Tamper 3 detection enable
    $06 constant RTC_TAMP3TRG                   \ [0x06] Active level for tamper 3
    $07 constant RTC_TAMPTS                     \ [0x07] Activate timestamp on tamper detection event
    $08 constant RTC_TAMPFREQ                   \ [0x08 : 3] Tamper sampling frequency
    $0b constant RTC_TAMPFLT                    \ [0x0b : 2] Tamper filter count
    $0d constant RTC_TAMPPRCH                   \ [0x0d : 2] Tamper precharge duration
    $0f constant RTC_TAMPPUDIS                  \ [0x0f] TAMPER pull-up disable
    $10 constant RTC_TAMP1IE                    \ [0x10] Tamper 1 interrupt enable
    $11 constant RTC_TAMP1NOERASE               \ [0x11] Tamper 1 no erase
    $12 constant RTC_TAMP1MF                    \ [0x12] Tamper 1 mask flag
    $13 constant RTC_TAMP2IE                    \ [0x13] Tamper 2 interrupt enable
    $14 constant RTC_TAMP2NOERASE               \ [0x14] Tamper 2 no erase
    $15 constant RTC_TAMP2MF                    \ [0x15] Tamper 2 mask flag
    $16 constant RTC_TAMP3IE                    \ [0x16] Tamper 3 interrupt enable
    $17 constant RTC_TAMP3NOERASE               \ [0x17] Tamper 3 no erase
    $18 constant RTC_TAMP3MF                    \ [0x18] Tamper 3 mask flag
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


  [ifdef] RTC_ALRMBSSR_DEF
    \
    \ @brief alarm B sub second register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value
    $18 constant RTC_MASKSS                     \ [0x18 : 4] Mask the most-significant bits starting at this bit
  [then]


  [ifdef] RTC_OR_DEF
    \
    \ @brief option register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_RTC_ALARM_TYPE             \ [0x00] RTC_ALARM on PC13 output type
    $01 constant RTC_RTC_OUT_RMP                \ [0x01] RTC_OUT remap
  [then]


  [ifdef] RTC_BKP0R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP1R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP2R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP3R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP4R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP5R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP6R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP7R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP8R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP9R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP10R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP11R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP12R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP13R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP14R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP15R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP16R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP17R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP18R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP19R_DEF
    \
    \ @brief backup register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP20R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP21R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP22R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP23R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP24R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP25R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP26R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP27R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP28R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP29R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP30R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]


  [ifdef] RTC_BKP31R_DEF
    \
    \ @brief backup register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] BKP
  [then]

  \
  \ @brief Real-time clock
  \
  $00 constant RTC_TR                   \ time register
  $04 constant RTC_DR                   \ date register
  $08 constant RTC_CR                   \ control register
  $0C constant RTC_ISR                  \ initialization and status register
  $10 constant RTC_PRER                 \ prescaler register
  $14 constant RTC_WUTR                 \ wakeup timer register
  $1C constant RTC_ALRMAR               \ alarm A register
  $20 constant RTC_ALRMBR               \ alarm B register
  $24 constant RTC_WPR                  \ write protection register
  $28 constant RTC_SSR                  \ sub second register
  $2C constant RTC_SHIFTR               \ shift control register
  $30 constant RTC_TSTR                 \ time stamp time register
  $34 constant RTC_TSDR                 \ time stamp date register
  $38 constant RTC_TSSSR                \ timestamp sub second register
  $3C constant RTC_CALR                 \ calibration register
  $40 constant RTC_TAMPCR               \ tamper configuration register
  $44 constant RTC_ALRMASSR             \ alarm A sub second register
  $48 constant RTC_ALRMBSSR             \ alarm B sub second register
  $4C constant RTC_OR                   \ option register
  $50 constant RTC_BKP0R                \ backup register
  $54 constant RTC_BKP1R                \ backup register
  $58 constant RTC_BKP2R                \ backup register
  $5C constant RTC_BKP3R                \ backup register
  $60 constant RTC_BKP4R                \ backup register
  $64 constant RTC_BKP5R                \ backup register
  $68 constant RTC_BKP6R                \ backup register
  $6C constant RTC_BKP7R                \ backup register
  $70 constant RTC_BKP8R                \ backup register
  $74 constant RTC_BKP9R                \ backup register
  $78 constant RTC_BKP10R               \ backup register
  $7C constant RTC_BKP11R               \ backup register
  $80 constant RTC_BKP12R               \ backup register
  $84 constant RTC_BKP13R               \ backup register
  $88 constant RTC_BKP14R               \ backup register
  $8C constant RTC_BKP15R               \ backup register
  $90 constant RTC_BKP16R               \ backup register
  $94 constant RTC_BKP17R               \ backup register
  $98 constant RTC_BKP18R               \ backup register
  $9C constant RTC_BKP19R               \ backup register
  $A0 constant RTC_BKP20R               \ backup register
  $A4 constant RTC_BKP21R               \ backup register
  $A8 constant RTC_BKP22R               \ backup register
  $AC constant RTC_BKP23R               \ backup register
  $B0 constant RTC_BKP24R               \ backup register
  $B4 constant RTC_BKP25R               \ backup register
  $B8 constant RTC_BKP26R               \ backup register
  $BC constant RTC_BKP27R               \ backup register
  $C0 constant RTC_BKP28R               \ backup register
  $C4 constant RTC_BKP29R               \ backup register
  $C8 constant RTC_BKP30R               \ backup register
  $CC constant RTC_BKP31R               \ backup register

: RTC_DEF ; [then]
