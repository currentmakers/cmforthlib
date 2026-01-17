\
\ @file tim15.fs
\ @brief General purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM15_DEF

  [ifdef] TIM15_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CEN                      \ [0x00] Counter enable
    $01 constant TIM15_UDIS                     \ [0x01] Update disable
    $02 constant TIM15_URS                      \ [0x02] Update request source
    $03 constant TIM15_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM15_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM15_CKD                      \ [0x08 : 2] Clock division
    $0b constant TIM15_UIFREMAP                 \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM15_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCPC                     \ [0x00] Capture/compare preloaded control
    $02 constant TIM15_CCUS                     \ [0x02] Capture/compare control update selection
    $03 constant TIM15_CCDS                     \ [0x03] Capture/compare DMA selection
    $04 constant TIM15_MMS                      \ [0x04 : 3] Master mode selection
    $07 constant TIM15_TI1S                     \ [0x07] TI1 selection
    $08 constant TIM15_OIS1                     \ [0x08] Output Idle state 1
    $09 constant TIM15_OIS1N                    \ [0x09] Output Idle state 1
    $0a constant TIM15_OIS2                     \ [0x0a] Output Idle state 2
  [then]


  [ifdef] TIM15_SMCR_DEF
    \
    \ @brief slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_SMS                      \ [0x00 : 3] Slave mode selection
    $04 constant TIM15_TS                       \ [0x04 : 3] Trigger selection
    $07 constant TIM15_MSM                      \ [0x07] Master/Slave mode
    $10 constant TIM15_SMS_3                    \ [0x10] Slave mode selection - bit 3
  [then]


  [ifdef] TIM15_DIER_DEF
    \
    \ @brief DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM15_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM15_CC2IE                    \ [0x02] Capture/Compare 2 interrupt enable
    $05 constant TIM15_COMIE                    \ [0x05] COM interrupt enable
    $06 constant TIM15_TIE                      \ [0x06] Trigger interrupt enable
    $07 constant TIM15_BIE                      \ [0x07] Break interrupt enable
    $08 constant TIM15_UDE                      \ [0x08] Update DMA request enable
    $09 constant TIM15_CC1DE                    \ [0x09] Capture/Compare 1 DMA request enable
    $0a constant TIM15_CC2DE                    \ [0x0a] Capture/Compare 2 DMA request enable
    $0e constant TIM15_TDE                      \ [0x0e] Trigger DMA request enable
  [then]


  [ifdef] TIM15_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM15_CC1IF                    \ [0x01] Capture/compare 1 interrupt flag
    $02 constant TIM15_CC2IF                    \ [0x02] Capture/Compare 2 interrupt flag
    $05 constant TIM15_COMIF                    \ [0x05] COM interrupt flag
    $06 constant TIM15_TIF                      \ [0x06] Trigger interrupt flag
    $07 constant TIM15_BIF                      \ [0x07] Break interrupt flag
    $09 constant TIM15_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag
    $0a constant TIM15_CC2OF                    \ [0x0a] Capture/compare 2 overcapture flag
  [then]


  [ifdef] TIM15_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UG                       \ [0x00] Update generation
    $01 constant TIM15_CC1G                     \ [0x01] Capture/compare 1 generation
    $02 constant TIM15_CC2G                     \ [0x02] Capture/compare 2 generation
    $05 constant TIM15_COMG                     \ [0x05] Capture/Compare control update generation
    $06 constant TIM15_TG                       \ [0x06] Trigger generation
    $07 constant TIM15_BG                       \ [0x07] Break generation
  [then]


  [ifdef] TIM15_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM15_OC1FE                    \ [0x02] Output Compare 1 fast enable
    $03 constant TIM15_OC1PE                    \ [0x03] Output Compare 1 preload enable
    $04 constant TIM15_OC1M                     \ [0x04 : 3] Output Compare 1 mode
    $07 constant TIM15_OC1CE                    \ [0x07] Output Compare 1 clear enable
    $08 constant TIM15_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM15_OC2FE                    \ [0x0a] Output Compare 2 fast enable
    $0b constant TIM15_OC2PE                    \ [0x0b] Output Compare 2 preload enable
    $0c constant TIM15_OC2M                     \ [0x0c : 3] Output Compare 2 mode
    $0f constant TIM15_OC2CE                    \ [0x0f] Output Compare 2 clear enable
    $10 constant TIM15_OC1M_3                   \ [0x10] Output Compare 1 mode -bit3
    $18 constant TIM15_OC2M_3                   \ [0x18] Output Compare 2 mode -bit3
  [then]


  [ifdef] TIM15_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM15_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM15_IC1F                     \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM15_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM15_IC2PSC                   \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM15_IC2F                     \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM15_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1E                     \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM15_CC1P                     \ [0x01] Capture/Compare 1 output Polarity
    $02 constant TIM15_CC1NE                    \ [0x02] Capture/Compare 1 complementary output enable
    $03 constant TIM15_CC1NP                    \ [0x03] Capture/Compare 1 output Polarity
    $04 constant TIM15_CC2E                     \ [0x04] Capture/Compare 2 output enable
    $05 constant TIM15_CC2P                     \ [0x05] Capture/Compare 2 output Polarity
    $07 constant TIM15_CC2NP                    \ [0x07] Capture/Compare 2 output Polarity
  [then]


  [ifdef] TIM15_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CNT                      \ [0x00 : 16] counter value
    $1f constant TIM15_UIFCPY                   \ [0x1f] UIF copy
  [then]


  [ifdef] TIM15_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM15_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_ARR                      \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM15_RCR_DEF
    \
    \ @brief repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_REP                      \ [0x00 : 8] Repetition counter value
  [then]


  [ifdef] TIM15_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR1                     \ [0x00 : 16] Capture/Compare 1 value
  [then]


  [ifdef] TIM15_CCR2_DEF
    \
    \ @brief capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR2                     \ [0x00 : 16] Capture/Compare 2 value
  [then]


  [ifdef] TIM15_BDTR_DEF
    \
    \ @brief break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DTG                      \ [0x00 : 8] Dead-time generator setup
    $08 constant TIM15_LOCK                     \ [0x08 : 2] Lock configuration
    $0a constant TIM15_OSSI                     \ [0x0a] Off-state selection for Idle mode
    $0b constant TIM15_OSSR                     \ [0x0b] Off-state selection for Run mode
    $0c constant TIM15_BKE                      \ [0x0c] Break enable
    $0d constant TIM15_BKP                      \ [0x0d] Break polarity
    $0e constant TIM15_AOE                      \ [0x0e] Automatic output enable
    $0f constant TIM15_MOE                      \ [0x0f] Main output enable
  [then]


  [ifdef] TIM15_DCR_DEF
    \
    \ @brief DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DBA                      \ [0x00 : 5] DMA base address
    $08 constant TIM15_DBL                      \ [0x08 : 5] DMA burst length
  [then]


  [ifdef] TIM15_DMAR_DEF
    \
    \ @brief DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DMAB                     \ [0x00 : 16] DMA register for burst accesses
  [then]

  \
  \ @brief General purpose timers
  \
  $00 constant TIM15_CR1                \ control register 1
  $04 constant TIM15_CR2                \ control register 2
  $08 constant TIM15_SMCR               \ slave mode control register
  $0C constant TIM15_DIER               \ DMA/Interrupt enable register
  $10 constant TIM15_SR                 \ status register
  $14 constant TIM15_EGR                \ event generation register
  $18 constant TIM15_CCMR1_OUTPUT       \ capture/compare mode register (output mode)
  $18 constant TIM15_CCMR1_INPUT        \ capture/compare mode register 1 (input mode)
  $20 constant TIM15_CCER               \ capture/compare enable register
  $24 constant TIM15_CNT                \ counter
  $28 constant TIM15_PSC                \ prescaler
  $2C constant TIM15_ARR                \ auto-reload register
  $30 constant TIM15_RCR                \ repetition counter register
  $34 constant TIM15_CCR1               \ capture/compare register 1
  $38 constant TIM15_CCR2               \ capture/compare register 2
  $44 constant TIM15_BDTR               \ break and dead-time register
  $48 constant TIM15_DCR                \ DMA control register
  $4C constant TIM15_DMAR               \ DMA address for full transfer

: TIM15_DEF ; [then]
