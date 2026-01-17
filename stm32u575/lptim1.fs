\
\ @file lptim1.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM1_DEF

  [ifdef] LPTIM1_ISR_output_DEF
    \
    \ @brief Interrupt and Status Register (output mode)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CC1IF                   \ [0x00] Compare 1 interrupt flag
    $01 constant LPTIM1_ARRM                    \ [0x01] Autoreload match
    $02 constant LPTIM1_EXTTRIG                 \ [0x02] External trigger edge event
    $03 constant LPTIM1_CMP1OK                  \ [0x03] Compare register 1 update OK
    $04 constant LPTIM1_ARROK                   \ [0x04] Autoreload register update OK
    $05 constant LPTIM1_UP                      \ [0x05] Counter direction change down to up
    $06 constant LPTIM1_DOWN                    \ [0x06] Counter direction change up to down
    $07 constant LPTIM1_UE                      \ [0x07] LPTIM update event occurred
    $08 constant LPTIM1_REPOK                   \ [0x08] Repetition register update Ok
    $09 constant LPTIM1_CC2IF                   \ [0x09] Compare 2 interrupt flag
    $13 constant LPTIM1_CMP2OK                  \ [0x13] Compare register 2 update OK
    $18 constant LPTIM1_DIEROK                  \ [0x18] Interrupt enable register update OK
  [then]


  [ifdef] LPTIM1_ISR_input_DEF
    \
    \ @brief Interrupt and Status Register (intput mode)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CC1IF                   \ [0x00] Compare 1 interrupt flag
    $01 constant LPTIM1_ARRM                    \ [0x01] Autoreload match
    $02 constant LPTIM1_EXTTRIG                 \ [0x02] External trigger edge event
    $04 constant LPTIM1_ARROK                   \ [0x04] Autoreload register update OK
    $05 constant LPTIM1_UP                      \ [0x05] Counter direction change down to up
    $06 constant LPTIM1_DOWN                    \ [0x06] Counter direction change up to down
    $07 constant LPTIM1_UE                      \ [0x07] LPTIM update event occurred
    $08 constant LPTIM1_REPOK                   \ [0x08] Repetition register update Ok
    $09 constant LPTIM1_CC2IF                   \ [0x09] Capture 2 interrupt flag
    $0c constant LPTIM1_CC1OF                   \ [0x0c] Capture 1 over-capture flag
    $0d constant LPTIM1_CC2OF                   \ [0x0d] Capture 2 over-capture flag
    $18 constant LPTIM1_DIEROK                  \ [0x18] Interrupt enable register update OK
  [then]


  [ifdef] LPTIM1_ICR_output_DEF
    \
    \ @brief Interrupt Clear Register (output mode)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CC1IF                   \ [0x00] Capture/compare 1 clear flag
    $01 constant LPTIM1_ARRMCF                  \ [0x01] Autoreload match Clear Flag
    $02 constant LPTIM1_EXTTRIGCF               \ [0x02] External trigger valid edge Clear Flag
    $03 constant LPTIM1_CMP1OKCF                \ [0x03] Compare register 1 update OK Clear Flag
    $04 constant LPTIM1_ARROKCF                 \ [0x04] Autoreload register update OK Clear Flag
    $05 constant LPTIM1_UPCF                    \ [0x05] Direction change to UP Clear Flag
    $06 constant LPTIM1_DOWNCF                  \ [0x06] Direction change to down Clear Flag
    $07 constant LPTIM1_UECF                    \ [0x07] Update event clear flag
    $08 constant LPTIM1_REPOKCF                 \ [0x08] Repetition register update OK clear flag
    $09 constant LPTIM1_CC2CF                   \ [0x09] Capture/compare 2 clear flag
    $13 constant LPTIM1_CMP2OKCF                \ [0x13] Compare register 2 update OK clear flag
    $18 constant LPTIM1_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag
  [then]


  [ifdef] LPTIM1_ICR_input_DEF
    \
    \ @brief Interrupt Clear Register (intput mode)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CC1IF                   \ [0x00] Capture/compare 1 clear flag
    $01 constant LPTIM1_ARRMCF                  \ [0x01] Autoreload match Clear Flag
    $02 constant LPTIM1_EXTTRIGCF               \ [0x02] External trigger valid edge Clear Flag
    $04 constant LPTIM1_ARROKCF                 \ [0x04] Autoreload register update OK Clear Flag
    $05 constant LPTIM1_UPCF                    \ [0x05] Direction change to UP Clear Flag
    $06 constant LPTIM1_DOWNCF                  \ [0x06] Direction change to down Clear Flag
    $07 constant LPTIM1_UECF                    \ [0x07] Update event clear flag
    $08 constant LPTIM1_REPOKCF                 \ [0x08] Repetition register update OK clear flag
    $09 constant LPTIM1_CC2CF                   \ [0x09] Capture/compare 2 clear flag
    $0c constant LPTIM1_CC1OCF                  \ [0x0c] Capture/compare 1 over-capture clear flag
    $0d constant LPTIM1_CC2OCF                  \ [0x0d] Capture/compare 2 over-capture clear flag
    $18 constant LPTIM1_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag
  [then]


  [ifdef] LPTIM1_DIER_output_DEF
    \
    \ @brief LPTIM interrupt Enable Register (output mode)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CC1IF                   \ [0x00] Capture/compare 1 clear flag
    $01 constant LPTIM1_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM1_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM1_CMP1OKIE                \ [0x03] Compare register 1 update OK Interrupt Enable
    $04 constant LPTIM1_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM1_UPIE                    \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIM1_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable
    $07 constant LPTIM1_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM1_REPOKIE                 \ [0x08] REPOKIE
    $09 constant LPTIM1_CC2IE                   \ [0x09] Capture/compare 2 interrupt enable
    $13 constant LPTIM1_CMP2OKIE                \ [0x13] Compare register 2 update OK interrupt enable
    $17 constant LPTIM1_UEDE                    \ [0x17] Update event DMA request enable
  [then]


  [ifdef] LPTIM1_DIER_input_DEF
    \
    \ @brief LPTIM interrupt Enable Register (intput mode)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CC1IF                   \ [0x00] Capture/compare 1 clear flag
    $01 constant LPTIM1_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM1_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $04 constant LPTIM1_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM1_UPIE                    \ [0x05] Direction change to UP Interrupt Enable
    $06 constant LPTIM1_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable
    $07 constant LPTIM1_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM1_REPOKIE                 \ [0x08] REPOKIE
    $09 constant LPTIM1_CC2IE                   \ [0x09] Capture/compare 2 interrupt enable
    $0c constant LPTIM1_CC1OIE                  \ [0x0c] Capture/compare 1 over-capture interrupt enable
    $0d constant LPTIM1_CC2OIE                  \ [0x0d] Capture/compare 2 over-capture interrupt enable
    $10 constant LPTIM1_CC1DE                   \ [0x10] Capture/compare 1 DMA request enable
    $19 constant LPTIM1_CC2DE                   \ [0x19] Capture/compare 2 DMA request enable
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
    $03 constant LPTIM1_COUNTRST                \ [0x03] Counter reset
    $04 constant LPTIM1_RSTARE                  \ [0x04] Reset after read enable
  [then]


  [ifdef] LPTIM1_CCR1_DEF
    \
    \ @brief Compare Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CCR1                    \ [0x00 : 16] Capture/compare 1 value
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


  [ifdef] LPTIM1_CFGR2_DEF
    \
    \ @brief LPTIM configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_IN1SEL                  \ [0x00 : 2] LPTIM input 1 selection
    $04 constant LPTIM1_IN2SEL                  \ [0x04 : 2] LPTIM input 2 selection
    $10 constant LPTIM1_IC1SEL                  \ [0x10 : 2] LPTIM input capture 1 selection
    $14 constant LPTIM1_IC2SEL                  \ [0x14 : 2] LPTIM input capture 2 selection
  [then]


  [ifdef] LPTIM1_RCR_DEF
    \
    \ @brief LPTIM repetition register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_REP                     \ [0x00 : 8] Repetition register value
  [then]


  [ifdef] LPTIM1_CCMR1_DEF
    \
    \ @brief LPTIM capture/compare mode register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CC1SEL                  \ [0x00] Capture/compare 1 selection
    $01 constant LPTIM1_CC1E                    \ [0x01] Capture/compare 1 output enable
    $02 constant LPTIM1_CC1P                    \ [0x02 : 2] Capture/compare 1 output polarity
    $08 constant LPTIM1_IC1PSC                  \ [0x08 : 2] Input capture 1 prescaler
    $0c constant LPTIM1_IC1F                    \ [0x0c : 2] Input capture 1 filter
    $10 constant LPTIM1_CC2SEL                  \ [0x10] Capture/compare 2 selection
    $11 constant LPTIM1_CC2E                    \ [0x11] Capture/compare 2 output enable
    $12 constant LPTIM1_CC2P                    \ [0x12 : 2] Capture/compare 2 output polarity
    $18 constant LPTIM1_IC2PSC                  \ [0x18 : 2] Input capture 2 prescaler
    $1c constant LPTIM1_IC2F                    \ [0x1c : 2] Input capture 2 filter
  [then]


  [ifdef] LPTIM1_CCR2_DEF
    \
    \ @brief LPTIM Compare Register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CCR2                    \ [0x00 : 16] Capture/compare 2 value
  [then]


  [ifdef] LPTIM1_HWCFGR2_DEF
    \
    \ @brief LPTIM peripheral hardware configuration register 2
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CFG1                    \ [0x00 : 4] peripheral hardware configuration 1
    $08 constant LPTIM1_CFG2                    \ [0x08 : 8] peripheral hardware configuration 2
    $10 constant LPTIM1_CFG3                    \ [0x10] peripheral hardware configuration 3
  [then]


  [ifdef] LPTIM1_HWCFGR1_DEF
    \
    \ @brief LPTIM peripheral hardware configuration register 1
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM1_CFG1                    \ [0x00 : 8] peripheral hardware configuration 1
    $08 constant LPTIM1_CFG2                    \ [0x08 : 8] peripheral hardware configuration 2
    $10 constant LPTIM1_CFG3                    \ [0x10 : 4] peripheral hardware configuration 3
    $18 constant LPTIM1_CFG4                    \ [0x18 : 8] peripheral hardware configuration 4
  [then]

  \
  \ @brief Low power timer
  \
  $00 constant LPTIM1_ISR_OUTPUT        \ Interrupt and Status Register (output mode)
  $00 constant LPTIM1_ISR_INPUT         \ Interrupt and Status Register (intput mode)
  $04 constant LPTIM1_ICR_OUTPUT        \ Interrupt Clear Register (output mode)
  $04 constant LPTIM1_ICR_INPUT         \ Interrupt Clear Register (intput mode)
  $08 constant LPTIM1_DIER_OUTPUT       \ LPTIM interrupt Enable Register (output mode)
  $08 constant LPTIM1_DIER_INPUT        \ LPTIM interrupt Enable Register (intput mode)
  $0C constant LPTIM1_CFGR              \ Configuration Register
  $10 constant LPTIM1_CR                \ Control Register
  $14 constant LPTIM1_CCR1              \ Compare Register
  $18 constant LPTIM1_ARR               \ Autoreload Register
  $1C constant LPTIM1_CNT               \ Counter Register
  $24 constant LPTIM1_CFGR2             \ LPTIM configuration register 2
  $28 constant LPTIM1_RCR               \ LPTIM repetition register
  $2C constant LPTIM1_CCMR1             \ LPTIM capture/compare mode register 1
  $34 constant LPTIM1_CCR2              \ LPTIM Compare Register 2
  $3EC constant LPTIM1_HWCFGR2          \ LPTIM peripheral hardware configuration register 2
  $3F0 constant LPTIM1_HWCFGR1          \ LPTIM peripheral hardware configuration register 1

: LPTIM1_DEF ; [then]
