\
\ @file lptim2.fs
\ @brief Low-power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM2_DEF

  [ifdef] LPTIM2_LPTIM2_ISR_OUTPUT_DEF
    \
    \ @brief LPTIM2 interrupt and status register [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IF                   \ [0x00] Compare 1 interrupt flag
    $01 constant LPTIM2_ARRM                    \ [0x01] Autoreload match
    $02 constant LPTIM2_EXTTRIG                 \ [0x02] External trigger edge event
    $03 constant LPTIM2_CMP1OK                  \ [0x03] Compare register 1 update OK
    $04 constant LPTIM2_ARROK                   \ [0x04] Autoreload register update OK
    $05 constant LPTIM2_UP                      \ [0x05] Counter direction change down to up
    $06 constant LPTIM2_DOWN                    \ [0x06] Counter direction change up to down
    $07 constant LPTIM2_UE                      \ [0x07] LPTIM update event occurred
    $08 constant LPTIM2_REPOK                   \ [0x08] Repetition register update OK
    $09 constant LPTIM2_CC2IF                   \ [0x09] Compare 2 interrupt flag
    $13 constant LPTIM2_CMP2OK                  \ [0x13] Compare register 2 update OK
    $18 constant LPTIM2_DIEROK                  \ [0x18] Interrupt enable register update OK
  [then]


  [ifdef] LPTIM2_LPTIM2_ISR_INPUT_DEF
    \
    \ @brief LPTIM2 interrupt and status register [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IF                   \ [0x00] capture 1 interrupt flag
    $01 constant LPTIM2_ARRM                    \ [0x01] Autoreload match
    $02 constant LPTIM2_EXTTRIG                 \ [0x02] External trigger edge event
    $04 constant LPTIM2_ARROK                   \ [0x04] Autoreload register update OK
    $05 constant LPTIM2_UP                      \ [0x05] Counter direction change down to up
    $06 constant LPTIM2_DOWN                    \ [0x06] Counter direction change up to down
    $07 constant LPTIM2_UE                      \ [0x07] LPTIM update event occurred
    $08 constant LPTIM2_REPOK                   \ [0x08] Repetition register update OK
    $09 constant LPTIM2_CC2IF                   \ [0x09] Capture 2 interrupt flag
    $0c constant LPTIM2_CC1OF                   \ [0x0c] Capture 1 over-capture flag
    $0d constant LPTIM2_CC2OF                   \ [0x0d] Capture 2 over-capture flag
    $18 constant LPTIM2_DIEROK                  \ [0x18] Interrupt enable register update OK
  [then]


  [ifdef] LPTIM2_LPTIM2_ICR_OUTPUT_DEF
    \
    \ @brief LPTIM2 interrupt clear register [alternate]
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1CF                   \ [0x00] Capture/compare 1 clear flag
    $01 constant LPTIM2_ARRMCF                  \ [0x01] Autoreload match clear flag
    $02 constant LPTIM2_EXTTRIGCF               \ [0x02] External trigger valid edge clear flag
    $03 constant LPTIM2_CMP1OKCF                \ [0x03] Compare register 1 update OK clear flag
    $04 constant LPTIM2_ARROKCF                 \ [0x04] Autoreload register update OK clear flag
    $05 constant LPTIM2_UPCF                    \ [0x05] Direction change to UP clear flag
    $06 constant LPTIM2_DOWNCF                  \ [0x06] Direction change to down clear flag
    $07 constant LPTIM2_UECF                    \ [0x07] Update event clear flag
    $08 constant LPTIM2_REPOKCF                 \ [0x08] Repetition register update OK clear flag
    $09 constant LPTIM2_CC2CF                   \ [0x09] Capture/compare 2 clear flag
    $13 constant LPTIM2_CMP2OKCF                \ [0x13] Compare register 2 update OK clear flag
    $18 constant LPTIM2_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag
  [then]


  [ifdef] LPTIM2_LPTIM2_ICR_INPUT_DEF
    \
    \ @brief LPTIM2 interrupt clear register [alternate]
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1CF                   \ [0x00] Capture/compare 1 clear flag
    $01 constant LPTIM2_ARRMCF                  \ [0x01] Autoreload match clear flag
    $02 constant LPTIM2_EXTTRIGCF               \ [0x02] External trigger valid edge clear flag
    $04 constant LPTIM2_ARROKCF                 \ [0x04] Autoreload register update OK clear flag
    $05 constant LPTIM2_UPCF                    \ [0x05] Direction change to UP clear flag
    $06 constant LPTIM2_DOWNCF                  \ [0x06] Direction change to down clear flag
    $07 constant LPTIM2_UECF                    \ [0x07] Update event clear flag
    $08 constant LPTIM2_REPOKCF                 \ [0x08] Repetition register update OK clear flag
    $09 constant LPTIM2_CC2CF                   \ [0x09] Capture/compare 2 clear flag
    $0c constant LPTIM2_CC1OCF                  \ [0x0c] Capture/compare 1 over-capture clear flag
    $0d constant LPTIM2_CC2OCF                  \ [0x0d] Capture/compare 2 over-capture clear flag
    $18 constant LPTIM2_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag
  [then]


  [ifdef] LPTIM2_LPTIM2_DIER_OUTPUT_DEF
    \
    \ @brief LPTIM2 interrupt enable register [alternate]
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IE                   \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM2_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM2_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM2_CMP1OKIE                \ [0x03] Compare register 1 update OK interrupt enable
    $04 constant LPTIM2_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM2_UPIE                    \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIM2_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable
    $07 constant LPTIM2_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM2_REPOKIE                 \ [0x08] Repetition register update OK interrupt Enable
    $09 constant LPTIM2_CC2IE                   \ [0x09] Capture/compare 2 interrupt enable
    $13 constant LPTIM2_CMP2OKIE                \ [0x13] Compare register 2 update OK interrupt enable
    $17 constant LPTIM2_UEDE                    \ [0x17] Update event DMA request enable
  [then]


  [ifdef] LPTIM2_LPTIM2_DIER_INPUT_DEF
    \
    \ @brief LPTIM1 interrupt enable register [alternate]
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IE                   \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM2_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM2_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $04 constant LPTIM2_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM2_UPIE                    \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIM2_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable
    $07 constant LPTIM2_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM2_REPOKIE                 \ [0x08] Repetition register update OK interrupt Enable
    $09 constant LPTIM2_CC2IE                   \ [0x09] Capture/compare 2 interrupt enable
    $0c constant LPTIM2_CC1OIE                  \ [0x0c] Capture/compare 1 over-capture interrupt enable
    $0d constant LPTIM2_CC2OIE                  \ [0x0d] Capture/compare 2 over-capture interrupt enable
    $10 constant LPTIM2_CC1DE                   \ [0x10] Capture/compare 1 DMA request enable
    $17 constant LPTIM2_UEDE                    \ [0x17] Update event DMA request enable
    $19 constant LPTIM2_CC2DE                   \ [0x19] Capture/compare 2 DMA request enable
  [then]


  [ifdef] LPTIM2_LPTIM2_CFGR_DEF
    \
    \ @brief LPTIM2 configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CKSEL                   \ [0x00] Clock selector
    $01 constant LPTIM2_CKPOL                   \ [0x01 : 2] Clock Polarity
    $03 constant LPTIM2_CKFLT                   \ [0x03 : 2] Configurable digital filter for external clock
    $06 constant LPTIM2_TRGFLT                  \ [0x06 : 2] Configurable digital filter for trigger
    $09 constant LPTIM2_PRESC                   \ [0x09 : 3] Clock prescaler
    $0d constant LPTIM2_TRIGSEL                 \ [0x0d : 3] Trigger selector
    $11 constant LPTIM2_TRIGEN                  \ [0x11 : 2] Trigger enable and polarity
    $13 constant LPTIM2_TIMOUT                  \ [0x13] Timeout enable
    $14 constant LPTIM2_WAVE                    \ [0x14] Waveform shape
    $15 constant LPTIM2_WAVPOL                  \ [0x15] Waveform shape polarity
    $16 constant LPTIM2_PRELOAD                 \ [0x16] Registers update mode
    $17 constant LPTIM2_COUNTMODE               \ [0x17] counter mode enabled
    $18 constant LPTIM2_ENC                     \ [0x18] Encoder mode enable
  [then]


  [ifdef] LPTIM2_LPTIM2_CR_DEF
    \
    \ @brief LPTIM2 control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_ENABLE                  \ [0x00] LPTIM enable
    $01 constant LPTIM2_SNGSTRT                 \ [0x01] LPTIM start in Single mode
    $02 constant LPTIM2_CNTSTRT                 \ [0x02] Timer start in Continuous mode
    $03 constant LPTIM2_COUNTRST                \ [0x03] Counter reset
    $04 constant LPTIM2_RSTARE                  \ [0x04] Reset after read enable
  [then]


  [ifdef] LPTIM2_LPTIM2_CCR1_DEF
    \
    \ @brief LPTIM2 compare register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CCR1                    \ [0x00 : 16] Capture/compare 1 value
  [then]


  [ifdef] LPTIM2_LPTIM2_ARR_DEF
    \
    \ @brief LPTIM2 autoreload register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM2_ARR                     \ [0x00 : 16] Auto reload value
  [then]


  [ifdef] LPTIM2_LPTIM2_CNT_DEF
    \
    \ @brief LPTIM2 counter register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CNT                     \ [0x00 : 16] Counter value
  [then]


  [ifdef] LPTIM2_LPTIM2_CFGR2_DEF
    \
    \ @brief LPTIM2 configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_IN1SEL                  \ [0x00 : 2] LPTIM input 1 selection
    $04 constant LPTIM2_IN2SEL                  \ [0x04 : 2] LPTIM input 2 selection
    $10 constant LPTIM2_IC1SEL                  \ [0x10 : 2] LPTIM input capture 1 selection
    $14 constant LPTIM2_IC2SEL                  \ [0x14 : 2] LPTIM input capture 2 selection
  [then]


  [ifdef] LPTIM2_LPTIM2_RCR_DEF
    \
    \ @brief LPTIM2 repetition register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_REP                     \ [0x00 : 8] Repetition register value
  [then]


  [ifdef] LPTIM2_LPTIM2_CCMR1_DEF
    \
    \ @brief LPTIM2 capture/compare mode register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1SEL                  \ [0x00] Capture/compare 1 selection
    $01 constant LPTIM2_CC1E                    \ [0x01] Capture/compare 1 output enable.
    $02 constant LPTIM2_CC1P                    \ [0x02 : 2] Capture/compare 1 output polarity.
    $08 constant LPTIM2_IC1PSC                  \ [0x08 : 2] Input capture 1 prescaler
    $0c constant LPTIM2_IC1F                    \ [0x0c : 2] Input capture 1 filter
    $10 constant LPTIM2_CC2SEL                  \ [0x10] Capture/compare 2 selection
    $11 constant LPTIM2_CC2E                    \ [0x11] Capture/compare 2 output enable.
    $12 constant LPTIM2_CC2P                    \ [0x12 : 2] Capture/compare 2 output polarity.
    $18 constant LPTIM2_IC2PSC                  \ [0x18 : 2] Input capture 2 prescaler
    $1c constant LPTIM2_IC2F                    \ [0x1c : 2] Input capture 2 filter
  [then]


  [ifdef] LPTIM2_LPTIM2_CCR2_DEF
    \
    \ @brief LPTIM2 compare register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CCR2                    \ [0x00 : 16] Capture/compare 2 value
  [then]

  \
  \ @brief Low-power timer
  \
  $00 constant LPTIM2_LPTIM2_ISR_OUTPUT \ LPTIM2 interrupt and status register [alternate]
  $00 constant LPTIM2_LPTIM2_ISR_INPUT  \ LPTIM2 interrupt and status register [alternate]
  $04 constant LPTIM2_LPTIM2_ICR_OUTPUT \ LPTIM2 interrupt clear register [alternate]
  $04 constant LPTIM2_LPTIM2_ICR_INPUT  \ LPTIM2 interrupt clear register [alternate]
  $08 constant LPTIM2_LPTIM2_DIER_OUTPUT    \ LPTIM2 interrupt enable register [alternate]
  $08 constant LPTIM2_LPTIM2_DIER_INPUT \ LPTIM1 interrupt enable register [alternate]
  $0C constant LPTIM2_LPTIM2_CFGR       \ LPTIM2 configuration register
  $10 constant LPTIM2_LPTIM2_CR         \ LPTIM2 control register
  $14 constant LPTIM2_LPTIM2_CCR1       \ LPTIM2 compare register 1
  $18 constant LPTIM2_LPTIM2_ARR        \ LPTIM2 autoreload register
  $1C constant LPTIM2_LPTIM2_CNT        \ LPTIM2 counter register
  $24 constant LPTIM2_LPTIM2_CFGR2      \ LPTIM2 configuration register 2
  $28 constant LPTIM2_LPTIM2_RCR        \ LPTIM2 repetition register
  $2C constant LPTIM2_LPTIM2_CCMR1      \ LPTIM2 capture/compare mode register 1
  $34 constant LPTIM2_LPTIM2_CCR2       \ LPTIM2 compare register 2

: LPTIM2_DEF ; [then]
