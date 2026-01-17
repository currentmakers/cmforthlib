\
\ @file lptim.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM_DEF

  [ifdef] LPTIM_ISR_DEF
    \
    \ @brief Interrupt and Status Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMPM                     \ [0x00] Compare match
    $01 constant LPTIM_ARRM                     \ [0x01] Autoreload match
    $02 constant LPTIM_EXTTRIG                  \ [0x02] External trigger edge event
    $03 constant LPTIM_CMPOK                    \ [0x03] Compare register update OK
    $04 constant LPTIM_ARROK                    \ [0x04] Autoreload register update OK
    $05 constant LPTIM_UP                       \ [0x05] Counter direction change down to up
    $06 constant LPTIM_DOWN                     \ [0x06] Counter direction change up to down
    $07 constant LPTIM_UE                       \ [0x07] UE
    $08 constant LPTIM_REPOK                    \ [0x08] REPOK
  [then]


  [ifdef] LPTIM_ICR_DEF
    \
    \ @brief Interrupt Clear Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMPMCF                   \ [0x00] compare match Clear Flag
    $01 constant LPTIM_ARRMCF                   \ [0x01] Autoreload match Clear Flag
    $02 constant LPTIM_EXTTRIGCF                \ [0x02] External trigger valid edge Clear Flag
    $03 constant LPTIM_CMPOKCF                  \ [0x03] Compare register update OK Clear Flag
    $04 constant LPTIM_ARROKCF                  \ [0x04] Autoreload register update OK Clear Flag
    $05 constant LPTIM_UPCF                     \ [0x05] Direction change to UP Clear Flag
    $06 constant LPTIM_DOWNCF                   \ [0x06] Direction change to down Clear Flag
    $07 constant LPTIM_UECF                     \ [0x07] UECF
    $08 constant LPTIM_REPOKCF                  \ [0x08] REPOKCF
  [then]


  [ifdef] LPTIM_IER_DEF
    \
    \ @brief Interrupt Enable Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMPMIE                   \ [0x00] Compare match Interrupt Enable
    $01 constant LPTIM_ARRMIE                   \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM_EXTTRIGIE                \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM_CMPOKIE                  \ [0x03] Compare register update OK Interrupt Enable
    $04 constant LPTIM_ARROKIE                  \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM_UPIE                     \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIM_DOWNIE                   \ [0x06] Direction change to down Interrupt Enable
    $07 constant LPTIM_UEIE                     \ [0x07] UEIE
    $08 constant LPTIM_REPOKIE                  \ [0x08] REPOKIE
  [then]


  [ifdef] LPTIM_CFGR_DEF
    \
    \ @brief Configuration Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CKSEL                    \ [0x00] Clock selector
    $01 constant LPTIM_CKPOL                    \ [0x01 : 2] Clock Polarity
    $03 constant LPTIM_CKFLT                    \ [0x03 : 2] Configurable digital filter for external clock
    $06 constant LPTIM_TRGFLT                   \ [0x06 : 2] Configurable digital filter for trigger
    $09 constant LPTIM_PRESC                    \ [0x09 : 3] Clock prescaler
    $0d constant LPTIM_TRIGSEL                  \ [0x0d : 3] Trigger selector
    $11 constant LPTIM_TRIGEN                   \ [0x11 : 2] Trigger enable and polarity
    $13 constant LPTIM_TIMOUT                   \ [0x13] Timeout enable
    $14 constant LPTIM_WAVE                     \ [0x14] Waveform shape
    $15 constant LPTIM_WAVPOL                   \ [0x15] Waveform shape polarity
    $16 constant LPTIM_PRELOAD                  \ [0x16] Registers update mode
    $17 constant LPTIM_COUNTMODE                \ [0x17] counter mode enabled
    $18 constant LPTIM_ENC                      \ [0x18] Encoder mode enable
  [then]


  [ifdef] LPTIM_CR_DEF
    \
    \ @brief Control Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_ENABLE                   \ [0x00] LPTIM Enable
    $01 constant LPTIM_SNGSTRT                  \ [0x01] LPTIM start in single mode
    $02 constant LPTIM_CNTSTRT                  \ [0x02] Timer start in continuous mode
    $03 constant LPTIM_COUNTRST                 \ [0x03] COUNTRST
    $04 constant LPTIM_RSTARE                   \ [0x04] RSTARE
  [then]


  [ifdef] LPTIM_CMP_DEF
    \
    \ @brief Compare Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMP                      \ [0x00 : 16] Compare value
  [then]


  [ifdef] LPTIM_ARR_DEF
    \
    \ @brief Autoreload Register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM_ARR                      \ [0x00 : 16] Auto reload value
  [then]


  [ifdef] LPTIM_CNT_DEF
    \
    \ @brief Counter Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CNT                      \ [0x00 : 16] Counter value
  [then]


  [ifdef] LPTIM_OR_DEF
    \
    \ @brief option register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_OR_0                     \ [0x00] Option register bit 0
    $01 constant LPTIM_OR_1                     \ [0x01] Option register bit 1
  [then]


  [ifdef] LPTIM_CFGR2_DEF
    \
    \ @brief configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_IN1SEL                   \ [0x00 : 2] LPTIM input 1 selection
    $04 constant LPTIM_IN2SEL                   \ [0x04 : 2] LPTIM input 2 selection
  [then]


  [ifdef] LPTIM_RCR_DEF
    \
    \ @brief repetition register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_REP                      \ [0x00 : 8] Repetition register value
  [then]

  \
  \ @brief Low power timer
  \
  $00 constant LPTIM_ISR                \ Interrupt and Status Register
  $04 constant LPTIM_ICR                \ Interrupt Clear Register
  $08 constant LPTIM_IER                \ Interrupt Enable Register
  $0C constant LPTIM_CFGR               \ Configuration Register
  $10 constant LPTIM_CR                 \ Control Register
  $14 constant LPTIM_CMP                \ Compare Register
  $18 constant LPTIM_ARR                \ Autoreload Register
  $1C constant LPTIM_CNT                \ Counter Register
  $20 constant LPTIM_OR                 \ option register
  $24 constant LPTIM_CFGR2              \ configuration register 2
  $28 constant LPTIM_RCR                \ repetition register

: LPTIM_DEF ; [then]
