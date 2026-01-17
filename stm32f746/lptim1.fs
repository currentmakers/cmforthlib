\
\ @file lptim1.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM1_DEF

  [ifdef] LPTIM1_ISR_DEF
    \
    \ @brief Interrupt and Status Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CMPM                    \ [0x00] Compare match
    $01 constant LPTIM1_ARRM                    \ [0x01] Autoreload match
    $02 constant LPTIM1_EXTTRIG                 \ [0x02] External trigger edge event
    $03 constant LPTIM1_CMPOK                   \ [0x03] Compare register update OK
    $04 constant LPTIM1_ARROK                   \ [0x04] Autoreload register update OK
    $05 constant LPTIM1_UP                      \ [0x05] Counter direction change down to up
    $06 constant LPTIM1_DOWN                    \ [0x06] Counter direction change up to down
  [then]


  [ifdef] LPTIM1_ICR_DEF
    \
    \ @brief Interrupt Clear Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CMPMCF                  \ [0x00] compare match Clear Flag
    $01 constant LPTIM1_ARRMCF                  \ [0x01] Autoreload match Clear Flag
    $02 constant LPTIM1_EXTTRIGCF               \ [0x02] External trigger valid edge Clear Flag
    $03 constant LPTIM1_CMPOKCF                 \ [0x03] Compare register update OK Clear Flag
    $04 constant LPTIM1_ARROKCF                 \ [0x04] Autoreload register update OK Clear Flag
    $05 constant LPTIM1_UPCF                    \ [0x05] Direction change to UP Clear Flag
    $06 constant LPTIM1_DOWNCF                  \ [0x06] Direction change to down Clear Flag
  [then]


  [ifdef] LPTIM1_IER_DEF
    \
    \ @brief Interrupt Enable Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CMPMIE                  \ [0x00] Compare match Interrupt Enable
    $01 constant LPTIM1_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM1_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM1_CMPOKIE                 \ [0x03] Compare register update OK Interrupt Enable
    $04 constant LPTIM1_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM1_UPIE                    \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIM1_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable
  [then]


  [ifdef] LPTIM1_CFGR_DEF
    \
    \ @brief Configuration Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CKSEL                   \ [0x00] Clock selector
    $01 constant LPTIM1_CKPOL                   \ [0x01 : 2] Clock Polarity
    $03 constant LPTIM1_CKFLT                   \ [0x03 : 2] Configurable digital filter for external clock
    $06 constant LPTIM1_TRGFLT                  \ [0x06 : 2] Configurable digital filter for trigger
    $09 constant LPTIM1_PRESC                   \ [0x09 : 3] Clock prescaler
    $0d constant LPTIM1_TRIGSEL                 \ [0x0d : 3] Trigger selector
    $11 constant LPTIM1_TRIGEN                  \ [0x11 : 2] Trigger enable and polarity
    $13 constant LPTIM1_TIMOUT                  \ [0x13] Timeout enable
    $14 constant LPTIM1_WAVE                    \ [0x14] Waveform shape
    $15 constant LPTIM1_WAVPOL                  \ [0x15] Waveform shape polarity
    $16 constant LPTIM1_PRELOAD                 \ [0x16] Registers update mode
    $17 constant LPTIM1_COUNTMODE               \ [0x17] counter mode enabled
    $18 constant LPTIM1_ENC                     \ [0x18] Encoder mode enable
  [then]


  [ifdef] LPTIM1_CR_DEF
    \
    \ @brief Control Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_ENABLE                  \ [0x00] LPTIM Enable
    $01 constant LPTIM1_SNGSTRT                 \ [0x01] LPTIM start in single mode
    $02 constant LPTIM1_CNTSTRT                 \ [0x02] Timer start in continuous mode
  [then]


  [ifdef] LPTIM1_CMP_DEF
    \
    \ @brief Compare Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CMP                     \ [0x00 : 16] Compare value
  [then]


  [ifdef] LPTIM1_ARR_DEF
    \
    \ @brief Autoreload Register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM1_ARR                     \ [0x00 : 16] Auto reload value
  [then]


  [ifdef] LPTIM1_CNT_DEF
    \
    \ @brief Counter Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CNT                     \ [0x00 : 16] Counter value
  [then]

  \
  \ @brief Low power timer
  \
  $00 constant LPTIM1_ISR               \ Interrupt and Status Register
  $04 constant LPTIM1_ICR               \ Interrupt Clear Register
  $08 constant LPTIM1_IER               \ Interrupt Enable Register
  $0C constant LPTIM1_CFGR              \ Configuration Register
  $10 constant LPTIM1_CR                \ Control Register
  $14 constant LPTIM1_CMP               \ Compare Register
  $18 constant LPTIM1_ARR               \ Autoreload Register
  $1C constant LPTIM1_CNT               \ Counter Register

: LPTIM1_DEF ; [then]
