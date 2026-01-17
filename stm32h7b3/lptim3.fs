\
\ @file lptim3.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM3_DEF

  [ifdef] LPTIM3_ISR_DEF
    \
    \ @brief Interrupt and Status Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM3_CMPM                    \ [0x00] Compare match
    $01 constant LPTIM3_ARRM                    \ [0x01] Autoreload match
    $02 constant LPTIM3_EXTTRIG                 \ [0x02] External trigger edge event
    $03 constant LPTIM3_CMPOK                   \ [0x03] Compare register update OK
    $04 constant LPTIM3_ARROK                   \ [0x04] Autoreload register update OK
    $05 constant LPTIM3_UP                      \ [0x05] Counter direction change down to up
    $06 constant LPTIM3_DOWN                    \ [0x06] Counter direction change up to down
  [then]


  [ifdef] LPTIM3_ICR_DEF
    \
    \ @brief Interrupt Clear Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM3_CMPMCF                  \ [0x00] compare match Clear Flag
    $01 constant LPTIM3_ARRMCF                  \ [0x01] Autoreload match Clear Flag
    $02 constant LPTIM3_EXTTRIGCF               \ [0x02] External trigger valid edge Clear Flag
    $03 constant LPTIM3_CMPOKCF                 \ [0x03] Compare register update OK Clear Flag
    $04 constant LPTIM3_ARROKCF                 \ [0x04] Autoreload register update OK Clear Flag
    $05 constant LPTIM3_UPCF                    \ [0x05] Direction change to UP Clear Flag
    $06 constant LPTIM3_DOWNCF                  \ [0x06] Direction change to down Clear Flag
  [then]


  [ifdef] LPTIM3_IER_DEF
    \
    \ @brief Interrupt Enable Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM3_CMPMIE                  \ [0x00] Compare match Interrupt Enable
    $01 constant LPTIM3_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM3_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM3_CMPOKIE                 \ [0x03] Compare register update OK Interrupt Enable
    $04 constant LPTIM3_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM3_UPIE                    \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIM3_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable
  [then]


  [ifdef] LPTIM3_CFGR_DEF
    \
    \ @brief Configuration Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM3_CKSEL                   \ [0x00] Clock selector
    $01 constant LPTIM3_CKPOL                   \ [0x01 : 2] Clock Polarity
    $03 constant LPTIM3_CKFLT                   \ [0x03 : 2] Configurable digital filter for external clock
    $06 constant LPTIM3_TRGFLT                  \ [0x06 : 2] Configurable digital filter for trigger
    $09 constant LPTIM3_PRESC                   \ [0x09 : 3] Clock prescaler
    $0d constant LPTIM3_TRIGSEL                 \ [0x0d : 3] Trigger selector
    $11 constant LPTIM3_TRIGEN                  \ [0x11 : 2] Trigger enable and polarity
    $13 constant LPTIM3_TIMOUT                  \ [0x13] Timeout enable
    $14 constant LPTIM3_WAVE                    \ [0x14] Waveform shape
    $15 constant LPTIM3_WAVPOL                  \ [0x15] Waveform shape polarity
    $16 constant LPTIM3_PRELOAD                 \ [0x16] Registers update mode
    $17 constant LPTIM3_COUNTMODE               \ [0x17] counter mode enabled
    $18 constant LPTIM3_ENC                     \ [0x18] Encoder mode enable
  [then]


  [ifdef] LPTIM3_CR_DEF
    \
    \ @brief Control Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM3_ENABLE                  \ [0x00] LPTIM Enable
    $01 constant LPTIM3_SNGSTRT                 \ [0x01] LPTIM start in single mode
    $02 constant LPTIM3_CNTSTRT                 \ [0x02] Timer start in continuous mode
    $03 constant LPTIM3_COUNTRST                \ [0x03] Counter reset
    $04 constant LPTIM3_RSTARE                  \ [0x04] Reset after read enable
  [then]


  [ifdef] LPTIM3_CMP_DEF
    \
    \ @brief Compare Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM3_CMP                     \ [0x00 : 16] Compare value
  [then]


  [ifdef] LPTIM3_ARR_DEF
    \
    \ @brief Autoreload Register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM3_ARR                     \ [0x00 : 16] Auto reload value
  [then]


  [ifdef] LPTIM3_CNT_DEF
    \
    \ @brief Counter Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM3_CNT                     \ [0x00 : 16] Counter value
  [then]


  [ifdef] LPTIM3_LPTIM_CFGR2_DEF
    \
    \ @brief LPTIM configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM3_IN1SEL                  \ [0x00 : 2] LPTIM Input 1 selection
  [then]

  \
  \ @brief Low power timer
  \
  $00 constant LPTIM3_ISR               \ Interrupt and Status Register
  $04 constant LPTIM3_ICR               \ Interrupt Clear Register
  $08 constant LPTIM3_IER               \ Interrupt Enable Register
  $0C constant LPTIM3_CFGR              \ Configuration Register
  $10 constant LPTIM3_CR                \ Control Register
  $14 constant LPTIM3_CMP               \ Compare Register
  $18 constant LPTIM3_ARR               \ Autoreload Register
  $1C constant LPTIM3_CNT               \ Counter Register
  $24 constant LPTIM3_LPTIM_CFGR2       \ LPTIM configuration register 2

: LPTIM3_DEF ; [then]
