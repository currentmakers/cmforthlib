\
\ @file lptimer1.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIMER1_DEF

  [ifdef] LPTIMER1_ISR_DEF
    \
    \ @brief Interrupt and Status Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIMER1_CMPM                  \ [0x00] Compare match
    $01 constant LPTIMER1_ARRM                  \ [0x01] Autoreload match
    $02 constant LPTIMER1_EXTTRIG               \ [0x02] External trigger edge event
    $03 constant LPTIMER1_CMPOK                 \ [0x03] Compare register update OK
    $04 constant LPTIMER1_ARROK                 \ [0x04] Autoreload register update OK
    $05 constant LPTIMER1_UP                    \ [0x05] Counter direction change down to up
    $06 constant LPTIMER1_DOWN                  \ [0x06] Counter direction change up to down
  [then]


  [ifdef] LPTIMER1_ICR_DEF
    \
    \ @brief Interrupt Clear Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIMER1_CMPMCF                \ [0x00] compare match Clear Flag
    $01 constant LPTIMER1_ARRMCF                \ [0x01] Autoreload match Clear Flag
    $02 constant LPTIMER1_EXTTRIGCF             \ [0x02] External trigger valid edge Clear Flag
    $03 constant LPTIMER1_CMPOKCF               \ [0x03] Compare register update OK Clear Flag
    $04 constant LPTIMER1_ARROKCF               \ [0x04] Autoreload register update OK Clear Flag
    $05 constant LPTIMER1_UPCF                  \ [0x05] Direction change to UP Clear Flag
    $06 constant LPTIMER1_DOWNCF                \ [0x06] Direction change to down Clear Flag
  [then]


  [ifdef] LPTIMER1_IER_DEF
    \
    \ @brief Interrupt Enable Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIMER1_CMPMIE                \ [0x00] Compare match Interrupt Enable
    $01 constant LPTIMER1_ARRMIE                \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIMER1_EXTTRIGIE             \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIMER1_CMPOKIE               \ [0x03] Compare register update OK Interrupt Enable
    $04 constant LPTIMER1_ARROKIE               \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIMER1_UPIE                  \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIMER1_DOWNIE                \ [0x06] Direction change to down Interrupt Enable
  [then]


  [ifdef] LPTIMER1_CFGR_DEF
    \
    \ @brief Configuration Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIMER1_CKSEL                 \ [0x00] Clock selector
    $01 constant LPTIMER1_CKPOL                 \ [0x01 : 2] Clock Polarity
    $03 constant LPTIMER1_CKFLT                 \ [0x03 : 2] Configurable digital filter for external clock
    $06 constant LPTIMER1_TRGFLT                \ [0x06 : 2] Configurable digital filter for trigger
    $09 constant LPTIMER1_PRESC                 \ [0x09 : 3] Clock prescaler
    $0d constant LPTIMER1_TRIGSEL               \ [0x0d : 4] Trigger selector
    $11 constant LPTIMER1_TRIGEN                \ [0x11 : 2] Trigger enable and polarity
    $13 constant LPTIMER1_TIMOUT                \ [0x13] Timeout enable
    $14 constant LPTIMER1_WAVE                  \ [0x14] Waveform shape
    $15 constant LPTIMER1_WAVPOL                \ [0x15] Waveform shape polarity
    $16 constant LPTIMER1_PRELOAD               \ [0x16] Registers update mode
    $17 constant LPTIMER1_COUNTMODE             \ [0x17] counter mode enabled
    $18 constant LPTIMER1_ENC                   \ [0x18] Encoder mode enable
  [then]


  [ifdef] LPTIMER1_CR_DEF
    \
    \ @brief Control Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIMER1_ENABLE                \ [0x00] LPTIM Enable
    $01 constant LPTIMER1_SNGSTRT               \ [0x01] LPTIM start in single mode
    $02 constant LPTIMER1_CNTSTRT               \ [0x02] Timer start in continuous mode
    $03 constant LPTIMER1_COUNTRST              \ [0x03] COUNTRST
    $04 constant LPTIMER1_RSTARE                \ [0x04] RSTARE
  [then]


  [ifdef] LPTIMER1_CMP_DEF
    \
    \ @brief Compare Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIMER1_CMP                   \ [0x00 : 16] Compare value
  [then]


  [ifdef] LPTIMER1_ARR_DEF
    \
    \ @brief Autoreload Register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIMER1_ARR                   \ [0x00 : 16] Auto reload value
  [then]


  [ifdef] LPTIMER1_CNT_DEF
    \
    \ @brief Counter Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIMER1_CNT                   \ [0x00 : 16] Counter value
  [then]


  [ifdef] LPTIMER1_OR_DEF
    \
    \ @brief option register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPTIMER1_IN1                   \ [0x00] IN1
    $01 constant LPTIMER1_IN2                   \ [0x01] IN2
    $02 constant LPTIMER1_IN1_2_1               \ [0x02 : 2] IN1_2_1
    $04 constant LPTIMER1_IN2_2_1               \ [0x04 : 2] IN2_2_1
  [then]

  \
  \ @brief Low power timer
  \
  $00 constant LPTIMER1_ISR             \ Interrupt and Status Register
  $04 constant LPTIMER1_ICR             \ Interrupt Clear Register
  $08 constant LPTIMER1_IER             \ Interrupt Enable Register
  $0C constant LPTIMER1_CFGR            \ Configuration Register
  $10 constant LPTIMER1_CR              \ Control Register
  $14 constant LPTIMER1_CMP             \ Compare Register
  $18 constant LPTIMER1_ARR             \ Autoreload Register
  $1C constant LPTIMER1_CNT             \ Counter Register
  $20 constant LPTIMER1_OR              \ option register

: LPTIMER1_DEF ; [then]
