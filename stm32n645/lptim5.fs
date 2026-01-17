\
\ @file lptim5.fs
\ @brief Low-power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM5_DEF

  [ifdef] LPTIM5_LPTIM5_ISR_DEF
    \
    \ @brief LPTIM5 interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_CC1IF                   \ [0x00] Compare 1 interrupt flag
    $01 constant LPTIM5_ARRM                    \ [0x01] Autoreload match
    $02 constant LPTIM5_EXTTRIG                 \ [0x02] External trigger edge event
    $03 constant LPTIM5_CMP1OK                  \ [0x03] Compare register 1 update OK
    $04 constant LPTIM5_ARROK                   \ [0x04] Autoreload register update OK
    $05 constant LPTIM5_UP                      \ [0x05] Counter direction change down to up
    $06 constant LPTIM5_DOWN                    \ [0x06] Counter direction change up to down
    $07 constant LPTIM5_UE                      \ [0x07] LPTIM update event occurred
    $08 constant LPTIM5_REPOK                   \ [0x08] Repetition register update OK
    $18 constant LPTIM5_DIEROK                  \ [0x18] Interrupt enable register update OK
  [then]


  [ifdef] LPTIM5_LPTIM5_ICR_DEF
    \
    \ @brief LPTIM5 interrupt clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_CC1CF                   \ [0x00] Capture/compare 1 clear flag
    $01 constant LPTIM5_ARRMCF                  \ [0x01] Autoreload match clear flag
    $02 constant LPTIM5_EXTTRIGCF               \ [0x02] External trigger valid edge clear flag
    $03 constant LPTIM5_CMP1OKCF                \ [0x03] Compare register 1 update OK clear flag
    $04 constant LPTIM5_ARROKCF                 \ [0x04] Autoreload register update OK clear flag
    $05 constant LPTIM5_UPCF                    \ [0x05] Direction change to UP clear flag
    $06 constant LPTIM5_DOWNCF                  \ [0x06] Direction change to down clear flag
    $07 constant LPTIM5_UECF                    \ [0x07] Update event clear flag
    $08 constant LPTIM5_REPOKCF                 \ [0x08] Repetition register update OK clear flag
    $18 constant LPTIM5_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag
  [then]


  [ifdef] LPTIM5_LPTIM5_DIER_DEF
    \
    \ @brief LPTIM5 interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_CC1IE                   \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM5_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM5_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM5_CMP1OKIE                \ [0x03] Compare register 1 update OK interrupt enable
    $04 constant LPTIM5_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM5_UPIE                    \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIM5_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable
    $07 constant LPTIM5_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM5_REPOKIE                 \ [0x08] Repetition register update OK interrupt Enable
  [then]


  [ifdef] LPTIM5_LPTIM5_CFGR_DEF
    \
    \ @brief LPTIM5 configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_CKSEL                   \ [0x00] Clock selector
    $01 constant LPTIM5_CKPOL                   \ [0x01 : 2] Clock Polarity
    $03 constant LPTIM5_CKFLT                   \ [0x03 : 2] Configurable digital filter for external clock
    $06 constant LPTIM5_TRGFLT                  \ [0x06 : 2] Configurable digital filter for trigger
    $09 constant LPTIM5_PRESC                   \ [0x09 : 3] Clock prescaler
    $0d constant LPTIM5_TRIGSEL                 \ [0x0d : 3] Trigger selector
    $11 constant LPTIM5_TRIGEN                  \ [0x11 : 2] Trigger enable and polarity
    $13 constant LPTIM5_TIMOUT                  \ [0x13] Timeout enable
    $14 constant LPTIM5_WAVE                    \ [0x14] Waveform shape
    $15 constant LPTIM5_WAVPOL                  \ [0x15] Waveform shape polarity
    $16 constant LPTIM5_PRELOAD                 \ [0x16] Registers update mode
    $17 constant LPTIM5_COUNTMODE               \ [0x17] counter mode enabled
    $18 constant LPTIM5_ENC                     \ [0x18] Encoder mode enable
  [then]


  [ifdef] LPTIM5_LPTIM5_CR_DEF
    \
    \ @brief LPTIM5 control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_ENABLE                  \ [0x00] LPTIM enable
    $01 constant LPTIM5_SNGSTRT                 \ [0x01] LPTIM start in Single mode
    $02 constant LPTIM5_CNTSTRT                 \ [0x02] Timer start in Continuous mode
    $03 constant LPTIM5_COUNTRST                \ [0x03] Counter reset
    $04 constant LPTIM5_RSTARE                  \ [0x04] Reset after read enable
  [then]


  [ifdef] LPTIM5_LPTIM5_CCR1_DEF
    \
    \ @brief LPTIM5 compare register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_CCR1                    \ [0x00 : 16] Capture/compare 1 value
  [then]


  [ifdef] LPTIM5_LPTIM5_ARR_DEF
    \
    \ @brief LPTIM5 autoreload register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM5_ARR                     \ [0x00 : 16] Auto reload value
  [then]


  [ifdef] LPTIM5_LPTIM5_CNT_DEF
    \
    \ @brief LPTIM5 counter register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_CNT                     \ [0x00 : 16] Counter value
  [then]


  [ifdef] LPTIM5_LPTIM5_CFGR2_DEF
    \
    \ @brief LPTIM5 configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_IN1SEL                  \ [0x00 : 2] LPTIM input 1 selection
    $04 constant LPTIM5_IN2SEL                  \ [0x04 : 2] LPTIM input 2 selection
    $10 constant LPTIM5_IC1SEL                  \ [0x10 : 2] LPTIM input capture 1 selection
    $14 constant LPTIM5_IC2SEL                  \ [0x14 : 2] LPTIM input capture 2 selection
  [then]


  [ifdef] LPTIM5_LPTIM5_RCR_DEF
    \
    \ @brief LPTIM5 repetition register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_REP                     \ [0x00 : 8] Repetition register value
  [then]


  [ifdef] LPTIM5_LPTIM5_CCMR1_DEF
    \
    \ @brief LPTIM5 capture/compare mode register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_CC1SEL                  \ [0x00] Capture/compare 1 selection
    $01 constant LPTIM5_CC1E                    \ [0x01] Capture/compare 1 output enable.
    $02 constant LPTIM5_CC1P                    \ [0x02 : 2] Capture/compare 1 output polarity.
    $08 constant LPTIM5_IC1PSC                  \ [0x08 : 2] Input capture 1 prescaler
    $0c constant LPTIM5_IC1F                    \ [0x0c : 2] Input capture 1 filter
    $10 constant LPTIM5_CC2SEL                  \ [0x10] Capture/compare 2 selection
    $11 constant LPTIM5_CC2E                    \ [0x11] Capture/compare 2 output enable.
    $12 constant LPTIM5_CC2P                    \ [0x12 : 2] Capture/compare 2 output polarity.
    $18 constant LPTIM5_IC2PSC                  \ [0x18 : 2] Input capture 2 prescaler
    $1c constant LPTIM5_IC2F                    \ [0x1c : 2] Input capture 2 filter
  [then]


  [ifdef] LPTIM5_LPTIM5_CCR2_DEF
    \
    \ @brief LPTIM5 compare register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM5_CCR2                    \ [0x00 : 16] Capture/compare 2 value
  [then]

  \
  \ @brief Low-power timer
  \
  $00 constant LPTIM5_LPTIM5_ISR        \ LPTIM5 interrupt and status register
  $04 constant LPTIM5_LPTIM5_ICR        \ LPTIM5 interrupt clear register
  $08 constant LPTIM5_LPTIM5_DIER       \ LPTIM5 interrupt enable register
  $0C constant LPTIM5_LPTIM5_CFGR       \ LPTIM5 configuration register
  $10 constant LPTIM5_LPTIM5_CR         \ LPTIM5 control register
  $14 constant LPTIM5_LPTIM5_CCR1       \ LPTIM5 compare register 1
  $18 constant LPTIM5_LPTIM5_ARR        \ LPTIM5 autoreload register
  $1C constant LPTIM5_LPTIM5_CNT        \ LPTIM5 counter register
  $24 constant LPTIM5_LPTIM5_CFGR2      \ LPTIM5 configuration register 2
  $28 constant LPTIM5_LPTIM5_RCR        \ LPTIM5 repetition register
  $2C constant LPTIM5_LPTIM5_CCMR1      \ LPTIM5 capture/compare mode register 1
  $34 constant LPTIM5_LPTIM5_CCR2       \ LPTIM5 compare register 2

: LPTIM5_DEF ; [then]
