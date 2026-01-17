\
\ @file tim2.fs
\ @brief General purpose timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM2_DEF

  [ifdef] TIM2_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CEN                       \ [0x00] Counter enable
    $01 constant TIM2_UDIS                      \ [0x01] Update disable
    $02 constant TIM2_URS                       \ [0x02] Update request source
    $03 constant TIM2_OPM                       \ [0x03] One-pulse mode
    $04 constant TIM2_DIR                       \ [0x04] Direction
    $05 constant TIM2_CMS                       \ [0x05 : 2] Center-aligned mode selection
    $07 constant TIM2_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM2_CKD                       \ [0x08 : 2] Clock division
  [then]


  [ifdef] TIM2_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant TIM2_CCDS                      \ [0x03] Capture/compare DMA selection
    $04 constant TIM2_MMS                       \ [0x04 : 3] Master mode selection
    $07 constant TIM2_TI1S                      \ [0x07] TI1 selection
  [then]


  [ifdef] TIM2_SMCR_DEF
    \
    \ @brief slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_SMS                       \ [0x00 : 3] Slave mode selection
    $04 constant TIM2_TS                        \ [0x04 : 3] Trigger selection
    $07 constant TIM2_MSM                       \ [0x07] Master/Slave mode
    $08 constant TIM2_ETF                       \ [0x08 : 4] External trigger filter
    $0c constant TIM2_ETPS                      \ [0x0c : 2] External trigger prescaler
    $0e constant TIM2_ECE                       \ [0x0e] External clock enable
    $0f constant TIM2_ETP                       \ [0x0f] External trigger polarity
  [then]


  [ifdef] TIM2_DIER_DEF
    \
    \ @brief DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM2_CC1IE                     \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM2_CC2IE                     \ [0x02] Capture/Compare 2 interrupt enable
    $03 constant TIM2_CC3IE                     \ [0x03] Capture/Compare 3 interrupt enable
    $04 constant TIM2_CC4IE                     \ [0x04] Capture/Compare 4 interrupt enable
    $06 constant TIM2_TIE                       \ [0x06] Trigger interrupt enable
    $08 constant TIM2_UDE                       \ [0x08] Update DMA request enable
    $09 constant TIM2_CC1DE                     \ [0x09] Capture/Compare 1 DMA request enable
    $0a constant TIM2_CC2DE                     \ [0x0a] Capture/Compare 2 DMA request enable
    $0b constant TIM2_CC3DE                     \ [0x0b] Capture/Compare 3 DMA request enable
    $0c constant TIM2_CC4DE                     \ [0x0c] Capture/Compare 4 DMA request enable
    $0e constant TIM2_TDE                       \ [0x0e] Trigger DMA request enable
  [then]


  [ifdef] TIM2_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_UIF                       \ [0x00] Update interrupt flag
    $01 constant TIM2_CC1IF                     \ [0x01] Capture/compare 1 interrupt flag
    $02 constant TIM2_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag
    $03 constant TIM2_CC3IF                     \ [0x03] Capture/Compare 3 interrupt flag
    $04 constant TIM2_CC4IF                     \ [0x04] Capture/Compare 4 interrupt flag
    $06 constant TIM2_TIF                       \ [0x06] Trigger interrupt flag
    $09 constant TIM2_CC1OF                     \ [0x09] Capture/Compare 1 overcapture flag
    $0a constant TIM2_CC2OF                     \ [0x0a] Capture/compare 2 overcapture flag
    $0b constant TIM2_CC3OF                     \ [0x0b] Capture/Compare 3 overcapture flag
    $0c constant TIM2_CC4OF                     \ [0x0c] Capture/Compare 4 overcapture flag
  [then]


  [ifdef] TIM2_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_UG                        \ [0x00] Update generation
    $01 constant TIM2_CC1G                      \ [0x01] Capture/compare 1 generation
    $02 constant TIM2_CC2G                      \ [0x02] Capture/compare 2 generation
    $03 constant TIM2_CC3G                      \ [0x03] Capture/compare 3 generation
    $04 constant TIM2_CC4G                      \ [0x04] Capture/compare 4 generation
    $06 constant TIM2_TG                        \ [0x06] Trigger generation
  [then]


  [ifdef] TIM2_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register 1 (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM2_OC1FE                     \ [0x02] Output compare 1 fast enable
    $03 constant TIM2_OC1PE                     \ [0x03] Output compare 1 preload enable
    $04 constant TIM2_OC1M                      \ [0x04 : 3] Output compare 1 mode
    $07 constant TIM2_OC1CE                     \ [0x07] Output compare 1 clear enable
    $08 constant TIM2_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM2_OC2FE                     \ [0x0a] Output compare 2 fast enable
    $0b constant TIM2_OC2PE                     \ [0x0b] Output compare 2 preload enable
    $0c constant TIM2_OC2M                      \ [0x0c : 3] Output compare 2 mode
    $0f constant TIM2_OC2CE                     \ [0x0f] Output compare 2 clear enable
  [then]


  [ifdef] TIM2_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM2_IC1PSC                    \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM2_IC1F                      \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM2_CC2S                      \ [0x08 : 2] Capture/compare 2 selection
    $0a constant TIM2_IC2PSC                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM2_IC2F                      \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM2_CCMR2_Output_DEF
    \
    \ @brief capture/compare mode register 2 (output mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection
    $02 constant TIM2_OC3FE                     \ [0x02] Output compare 3 fast enable
    $03 constant TIM2_OC3PE                     \ [0x03] Output compare 3 preload enable
    $04 constant TIM2_OC3M                      \ [0x04 : 3] Output compare 3 mode
    $07 constant TIM2_OC3CE                     \ [0x07] Output compare 3 clear enable
    $08 constant TIM2_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection
    $0a constant TIM2_OC4FE                     \ [0x0a] Output compare 4 fast enable
    $0b constant TIM2_OC4PE                     \ [0x0b] Output compare 4 preload enable
    $0c constant TIM2_OC4M                      \ [0x0c : 3] Output compare 4 mode
    $0f constant TIM2_OC4CE                     \ [0x0f] Output compare 4 clear enable
  [then]


  [ifdef] TIM2_CCMR2_Input_DEF
    \
    \ @brief capture/compare mode register 2 (input mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection
    $02 constant TIM2_IC3PSC                    \ [0x02 : 2] Input capture 3 prescaler
    $04 constant TIM2_IC3F                      \ [0x04 : 4] Input capture 3 filter
    $08 constant TIM2_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection
    $0a constant TIM2_IC4PSC                    \ [0x0a : 2] Input capture 4 prescaler
    $0c constant TIM2_IC4F                      \ [0x0c : 4] Input capture 4 filter
  [then]


  [ifdef] TIM2_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC1E                      \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM2_CC1P                      \ [0x01] Capture/Compare 1 output Polarity
    $04 constant TIM2_CC2E                      \ [0x04] Capture/Compare 2 output enable
    $05 constant TIM2_CC2P                      \ [0x05] Capture/Compare 2 output Polarity
    $08 constant TIM2_CC3E                      \ [0x08] Capture/Compare 3 output enable
    $09 constant TIM2_CC3P                      \ [0x09] Capture/Compare 3 output Polarity
    $0c constant TIM2_CC4E                      \ [0x0c] Capture/Compare 4 output enable
    $0d constant TIM2_CC4P                      \ [0x0d] Capture/Compare 3 output Polarity
  [then]


  [ifdef] TIM2_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CNT                       \ [0x00 : 16] counter value
  [then]


  [ifdef] TIM2_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_PSC                       \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM2_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_ARR                       \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM2_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR1                      \ [0x00 : 16] Capture/Compare 1 value
  [then]


  [ifdef] TIM2_CCR2_DEF
    \
    \ @brief capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR2                      \ [0x00 : 16] Capture/Compare 2 value
  [then]


  [ifdef] TIM2_CCR3_DEF
    \
    \ @brief capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR3                      \ [0x00 : 16] Capture/Compare value
  [then]


  [ifdef] TIM2_CCR4_DEF
    \
    \ @brief capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR4                      \ [0x00 : 16] Capture/Compare value
  [then]


  [ifdef] TIM2_DCR_DEF
    \
    \ @brief DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_DBA                       \ [0x00 : 5] DMA base address
    $08 constant TIM2_DBL                       \ [0x08 : 5] DMA burst length
  [then]


  [ifdef] TIM2_DMAR_DEF
    \
    \ @brief DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_DMAB                      \ [0x00 : 16] DMA register for burst accesses
  [then]

  \
  \ @brief General purpose timer
  \
  $00 constant TIM2_CR1                 \ control register 1
  $04 constant TIM2_CR2                 \ control register 2
  $08 constant TIM2_SMCR                \ slave mode control register
  $0C constant TIM2_DIER                \ DMA/Interrupt enable register
  $10 constant TIM2_SR                  \ status register
  $14 constant TIM2_EGR                 \ event generation register
  $18 constant TIM2_CCMR1_OUTPUT        \ capture/compare mode register 1 (output mode)
  $18 constant TIM2_CCMR1_INPUT         \ capture/compare mode register 1 (input mode)
  $1C constant TIM2_CCMR2_OUTPUT        \ capture/compare mode register 2 (output mode)
  $1C constant TIM2_CCMR2_INPUT         \ capture/compare mode register 2 (input mode)
  $20 constant TIM2_CCER                \ capture/compare enable register
  $24 constant TIM2_CNT                 \ counter
  $28 constant TIM2_PSC                 \ prescaler
  $2C constant TIM2_ARR                 \ auto-reload register
  $34 constant TIM2_CCR1                \ capture/compare register 1
  $38 constant TIM2_CCR2                \ capture/compare register 2
  $3C constant TIM2_CCR3                \ capture/compare register 3
  $40 constant TIM2_CCR4                \ capture/compare register 4
  $48 constant TIM2_DCR                 \ DMA control register
  $4C constant TIM2_DMAR                \ DMA address for full transfer

: TIM2_DEF ; [then]
