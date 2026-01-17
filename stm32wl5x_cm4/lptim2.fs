\
\ @file lptim2.fs
\ @brief Low-power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM2_DEF

  [ifdef] LPTIM2_ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CMPM                    \ [0x00] Compare match
    $01 constant LPTIM2_ARRM                    \ [0x01] Autoreload match
    $02 constant LPTIM2_EXTTRIG                 \ [0x02] External trigger edge event
    $03 constant LPTIM2_CMPOK                   \ [0x03] Compare register update OK
    $04 constant LPTIM2_ARROK                   \ [0x04] Autoreload register update OK
    $05 constant LPTIM2_UP                      \ [0x05] Counter direction change down to up
    $06 constant LPTIM2_DOWN                    \ [0x06] Counter direction change up to down
    $07 constant LPTIM2_UE                      \ [0x07] LPTIM update event occurred
    $08 constant LPTIM2_REPOK                   \ [0x08] Repetition register update Ok
  [then]


  [ifdef] LPTIM2_ICR_DEF
    \
    \ @brief interrupt clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CMPMCF                  \ [0x00] compare match Clear Flag
    $01 constant LPTIM2_ARRMCF                  \ [0x01] Autoreload match Clear Flag
    $02 constant LPTIM2_EXTTRIGCF               \ [0x02] External trigger valid edge Clear Flag
    $03 constant LPTIM2_CMPOKCF                 \ [0x03] Compare register update OK Clear Flag
    $04 constant LPTIM2_ARROKCF                 \ [0x04] Autoreload register update OK Clear Flag
    $05 constant LPTIM2_UPCF                    \ [0x05] Direction change to UP Clear Flag
    $06 constant LPTIM2_DOWNCF                  \ [0x06] Direction change to down Clear Flag
    $07 constant LPTIM2_UECF                    \ [0x07] Update event clear flag
    $08 constant LPTIM2_REPOKCF                 \ [0x08] Repetition register update OK clear flag
  [then]


  [ifdef] LPTIM2_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CMPMIE                  \ [0x00] Compare match Interrupt Enable
    $01 constant LPTIM2_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM2_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM2_CMPOKIE                 \ [0x03] Compare register update OK Interrupt Enable
    $04 constant LPTIM2_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM2_UPIE                    \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIM2_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable
    $07 constant LPTIM2_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM2_REPOKIE                 \ [0x08] Repetition register update OK interrupt Enable
  [then]


  [ifdef] LPTIM2_CFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CKSEL                   \ [0x00] CKSEL
    $01 constant LPTIM2_CKPOL                   \ [0x01 : 2] CKPOL
    $03 constant LPTIM2_CKFLT                   \ [0x03 : 2] CKFLT
    $06 constant LPTIM2_TRGFLT                  \ [0x06 : 2] TRGFLT
    $09 constant LPTIM2_PRESC                   \ [0x09 : 3] PRESC
    $0d constant LPTIM2_TRIGSEL                 \ [0x0d : 3] TRIGSEL
    $11 constant LPTIM2_TRIGEN                  \ [0x11 : 2] TRIGEN
    $13 constant LPTIM2_TIMOUT                  \ [0x13] TIMOUT
    $14 constant LPTIM2_WAVE                    \ [0x14] WAVE
    $15 constant LPTIM2_WAVPOL                  \ [0x15] WAVPOL
    $16 constant LPTIM2_PRELOAD                 \ [0x16] PRELOAD
    $17 constant LPTIM2_COUNTMODE               \ [0x17] COUNTMODE
    $18 constant LPTIM2_ENC                     \ [0x18] ENC
  [then]


  [ifdef] LPTIM2_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_ENABLE                  \ [0x00] ENABLE
    $01 constant LPTIM2_SNGSTRT                 \ [0x01] SNGSTRT
    $02 constant LPTIM2_CNTSTRT                 \ [0x02] CNTSTRT
    $03 constant LPTIM2_COUNTRST                \ [0x03] COUNTRST
    $04 constant LPTIM2_RSTARE                  \ [0x04] RSTARE
  [then]


  [ifdef] LPTIM2_CMP_DEF
    \
    \ @brief compare register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CMP                     \ [0x00 : 16] CMP
  [then]


  [ifdef] LPTIM2_ARR_DEF
    \
    \ @brief autoreload register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM2_ARR                     \ [0x00 : 16] Auto reload value
  [then]


  [ifdef] LPTIM2_CNT_DEF
    \
    \ @brief counter register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CNT                     \ [0x00 : 16] Counter value
  [then]


  [ifdef] LPTIM2_LPTIM2_OR_DEF
    \
    \ @brief option register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_OR_0                    \ [0x00] Option register bit 0
    $01 constant LPTIM2_OR_1                    \ [0x01] Option register bit 1
  [then]


  [ifdef] LPTIM2_RCR_DEF
    \
    \ @brief repetition register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_REP                     \ [0x00 : 8] Repetition register value
  [then]

  \
  \ @brief Low-power timer
  \
  $00 constant LPTIM2_ISR               \ interrupt and status register
  $04 constant LPTIM2_ICR               \ interrupt clear register
  $08 constant LPTIM2_IER               \ interrupt enable register
  $0C constant LPTIM2_CFGR              \ configuration register
  $10 constant LPTIM2_CR                \ control register
  $14 constant LPTIM2_CMP               \ compare register
  $18 constant LPTIM2_ARR               \ autoreload register
  $1C constant LPTIM2_CNT               \ counter register
  $20 constant LPTIM2_LPTIM2_OR         \ option register
  $28 constant LPTIM2_RCR               \ repetition register

: LPTIM2_DEF ; [then]
