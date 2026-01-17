\
\ @file tim8.fs
\ @brief Advanced-timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM8_DEF

  [ifdef] TIM8_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CEN                       \ [0x00] Counter enable
    $01 constant TIM8_UDIS                      \ [0x01] Update disable
    $02 constant TIM8_URS                       \ [0x02] Update request source
    $03 constant TIM8_OPM                       \ [0x03] One-pulse mode
    $04 constant TIM8_DIR                       \ [0x04] Direction
    $05 constant TIM8_CMS                       \ [0x05 : 2] Center-aligned mode selection
    $07 constant TIM8_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM8_CKD                       \ [0x08 : 2] Clock division
  [then]


  [ifdef] TIM8_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCPC                      \ [0x00] Capture/compare preloaded control
    $02 constant TIM8_CCUS                      \ [0x02] Capture/compare control update selection
    $03 constant TIM8_CCDS                      \ [0x03] Capture/compare DMA selection
    $04 constant TIM8_MMS                       \ [0x04 : 3] Master mode selection
    $07 constant TIM8_TI1S                      \ [0x07] TI1 selection
    $08 constant TIM8_OIS1                      \ [0x08] Output Idle state 1
    $09 constant TIM8_OIS1N                     \ [0x09] Output Idle state 1
    $0a constant TIM8_OIS2                      \ [0x0a] Output Idle state 2
    $0b constant TIM8_OIS2N                     \ [0x0b] Output Idle state 2
    $0c constant TIM8_OIS3                      \ [0x0c] Output Idle state 3
    $0d constant TIM8_OIS3N                     \ [0x0d] Output Idle state 3
    $0e constant TIM8_OIS4                      \ [0x0e] Output Idle state 4
  [then]


  [ifdef] TIM8_SMCR_DEF
    \
    \ @brief slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_SMS                       \ [0x00 : 3] Slave mode selection
    $04 constant TIM8_TS                        \ [0x04 : 3] Trigger selection
    $07 constant TIM8_MSM                       \ [0x07] Master/Slave mode
    $08 constant TIM8_ETF                       \ [0x08 : 4] External trigger filter
    $0c constant TIM8_ETPS                      \ [0x0c : 2] External trigger prescaler
    $0e constant TIM8_ECE                       \ [0x0e] External clock enable
    $0f constant TIM8_ETP                       \ [0x0f] External trigger polarity
  [then]


  [ifdef] TIM8_DIER_DEF
    \
    \ @brief DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM8_CC1IE                     \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM8_CC2IE                     \ [0x02] Capture/Compare 2 interrupt enable
    $03 constant TIM8_CC3IE                     \ [0x03] Capture/Compare 3 interrupt enable
    $04 constant TIM8_CC4IE                     \ [0x04] Capture/Compare 4 interrupt enable
    $05 constant TIM8_COMIE                     \ [0x05] COM interrupt enable
    $06 constant TIM8_TIE                       \ [0x06] Trigger interrupt enable
    $07 constant TIM8_BIE                       \ [0x07] Break interrupt enable
    $08 constant TIM8_UDE                       \ [0x08] Update DMA request enable
    $09 constant TIM8_CC1DE                     \ [0x09] Capture/Compare 1 DMA request enable
    $0a constant TIM8_CC2DE                     \ [0x0a] Capture/Compare 2 DMA request enable
    $0b constant TIM8_CC3DE                     \ [0x0b] Capture/Compare 3 DMA request enable
    $0c constant TIM8_CC4DE                     \ [0x0c] Capture/Compare 4 DMA request enable
    $0d constant TIM8_COMDE                     \ [0x0d] COM DMA request enable
    $0e constant TIM8_TDE                       \ [0x0e] Trigger DMA request enable
  [then]


  [ifdef] TIM8_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_UIF                       \ [0x00] Update interrupt flag
    $01 constant TIM8_CC1IF                     \ [0x01] Capture/compare 1 interrupt flag
    $02 constant TIM8_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag
    $03 constant TIM8_CC3IF                     \ [0x03] Capture/Compare 3 interrupt flag
    $04 constant TIM8_CC4IF                     \ [0x04] Capture/Compare 4 interrupt flag
    $05 constant TIM8_COMIF                     \ [0x05] COM interrupt flag
    $06 constant TIM8_TIF                       \ [0x06] Trigger interrupt flag
    $07 constant TIM8_BIF                       \ [0x07] Break interrupt flag
    $09 constant TIM8_CC1OF                     \ [0x09] Capture/Compare 1 overcapture flag
    $0a constant TIM8_CC2OF                     \ [0x0a] Capture/compare 2 overcapture flag
    $0b constant TIM8_CC3OF                     \ [0x0b] Capture/Compare 3 overcapture flag
    $0c constant TIM8_CC4OF                     \ [0x0c] Capture/Compare 4 overcapture flag
  [then]


  [ifdef] TIM8_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_UG                        \ [0x00] Update generation
    $01 constant TIM8_CC1G                      \ [0x01] Capture/compare 1 generation
    $02 constant TIM8_CC2G                      \ [0x02] Capture/compare 2 generation
    $03 constant TIM8_CC3G                      \ [0x03] Capture/compare 3 generation
    $04 constant TIM8_CC4G                      \ [0x04] Capture/compare 4 generation
    $05 constant TIM8_COMG                      \ [0x05] Capture/Compare control update generation
    $06 constant TIM8_TG                        \ [0x06] Trigger generation
    $07 constant TIM8_BG                        \ [0x07] Break generation
  [then]


  [ifdef] TIM8_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register 1 (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM8_OC1FE                     \ [0x02] Output Compare 1 fast enable
    $03 constant TIM8_OC1PE                     \ [0x03] Output Compare 1 preload enable
    $04 constant TIM8_OC1M                      \ [0x04 : 3] Output Compare 1 mode
    $07 constant TIM8_OC1CE                     \ [0x07] Output Compare 1 clear enable
    $08 constant TIM8_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM8_OC2FE                     \ [0x0a] Output Compare 2 fast enable
    $0b constant TIM8_OC2PE                     \ [0x0b] Output Compare 2 preload enable
    $0c constant TIM8_OC2M                      \ [0x0c : 3] Output Compare 2 mode
    $0f constant TIM8_OC2CE                     \ [0x0f] Output Compare 2 clear enable
  [then]


  [ifdef] TIM8_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM8_ICPCS                     \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM8_IC1F                      \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM8_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM8_IC2PCS                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM8_IC2F                      \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM8_CCMR2_Output_DEF
    \
    \ @brief capture/compare mode register 2 (output mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection
    $02 constant TIM8_OC3FE                     \ [0x02] Output compare 3 fast enable
    $03 constant TIM8_OC3PE                     \ [0x03] Output compare 3 preload enable
    $04 constant TIM8_OC3M                      \ [0x04 : 3] Output compare 3 mode
    $07 constant TIM8_OC3CE                     \ [0x07] Output compare 3 clear enable
    $08 constant TIM8_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection
    $0a constant TIM8_OC4FE                     \ [0x0a] Output compare 4 fast enable
    $0b constant TIM8_OC4PE                     \ [0x0b] Output compare 4 preload enable
    $0c constant TIM8_OC4M                      \ [0x0c : 3] Output compare 4 mode
    $0f constant TIM8_OC4CE                     \ [0x0f] Output compare 4 clear enable
  [then]


  [ifdef] TIM8_CCMR2_Input_DEF
    \
    \ @brief capture/compare mode register 2 (input mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC3S                      \ [0x00 : 2] Capture/compare 3 selection
    $02 constant TIM8_IC3PSC                    \ [0x02 : 2] Input capture 3 prescaler
    $04 constant TIM8_IC3F                      \ [0x04 : 4] Input capture 3 filter
    $08 constant TIM8_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection
    $0a constant TIM8_IC4PSC                    \ [0x0a : 2] Input capture 4 prescaler
    $0c constant TIM8_IC4F                      \ [0x0c : 4] Input capture 4 filter
  [then]


  [ifdef] TIM8_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC1E                      \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM8_CC1P                      \ [0x01] Capture/Compare 1 output Polarity
    $02 constant TIM8_CC1NE                     \ [0x02] Capture/Compare 1 complementary output enable
    $03 constant TIM8_CC1NP                     \ [0x03] Capture/Compare 1 output Polarity
    $04 constant TIM8_CC2E                      \ [0x04] Capture/Compare 2 output enable
    $05 constant TIM8_CC2P                      \ [0x05] Capture/Compare 2 output Polarity
    $06 constant TIM8_CC2NE                     \ [0x06] Capture/Compare 2 complementary output enable
    $07 constant TIM8_CC2NP                     \ [0x07] Capture/Compare 2 output Polarity
    $08 constant TIM8_CC3E                      \ [0x08] Capture/Compare 3 output enable
    $09 constant TIM8_CC3P                      \ [0x09] Capture/Compare 3 output Polarity
    $0a constant TIM8_CC3NE                     \ [0x0a] Capture/Compare 3 complementary output enable
    $0b constant TIM8_CC3NP                     \ [0x0b] Capture/Compare 3 output Polarity
    $0c constant TIM8_CC4E                      \ [0x0c] Capture/Compare 4 output enable
    $0d constant TIM8_CC4P                      \ [0x0d] Capture/Compare 3 output Polarity
  [then]


  [ifdef] TIM8_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CNT                       \ [0x00 : 16] counter value
  [then]


  [ifdef] TIM8_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_PSC                       \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM8_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_ARR                       \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM8_RCR_DEF
    \
    \ @brief repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_REP                       \ [0x00 : 8] Repetition counter value
  [then]


  [ifdef] TIM8_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR1                      \ [0x00 : 16] Capture/Compare 1 value
  [then]


  [ifdef] TIM8_CCR2_DEF
    \
    \ @brief capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR2                      \ [0x00 : 16] Capture/Compare 2 value
  [then]


  [ifdef] TIM8_CCR3_DEF
    \
    \ @brief capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR3                      \ [0x00 : 16] Capture/Compare value
  [then]


  [ifdef] TIM8_CCR4_DEF
    \
    \ @brief capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR4                      \ [0x00 : 16] Capture/Compare value
  [then]


  [ifdef] TIM8_BDTR_DEF
    \
    \ @brief break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DTG                       \ [0x00 : 8] Dead-time generator setup
    $08 constant TIM8_LOCK                      \ [0x08 : 2] Lock configuration
    $0a constant TIM8_OSSI                      \ [0x0a] Off-state selection for Idle mode
    $0b constant TIM8_OSSR                      \ [0x0b] Off-state selection for Run mode
    $0c constant TIM8_BKE                       \ [0x0c] Break enable
    $0d constant TIM8_BKP                       \ [0x0d] Break polarity
    $0e constant TIM8_AOE                       \ [0x0e] Automatic output enable
    $0f constant TIM8_MOE                       \ [0x0f] Main output enable
  [then]


  [ifdef] TIM8_DCR_DEF
    \
    \ @brief DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DBA                       \ [0x00 : 5] DMA base address
    $08 constant TIM8_DBL                       \ [0x08 : 5] DMA burst length
  [then]


  [ifdef] TIM8_DMAR_DEF
    \
    \ @brief DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DMAB                      \ [0x00 : 16] DMA register for burst accesses
  [then]


  [ifdef] TIM8_OR1_DEF
    \
    \ @brief DMA address for full transfer
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_ETR_ADC2_RMP              \ [0x00 : 2] External trigger remap on ADC2 analog watchdog
    $02 constant TIM8_ETR_ADC3_RMP              \ [0x02 : 2] External trigger remap on ADC3 analog watchdog
    $04 constant TIM8_TI1_RMP                   \ [0x04] Input Capture 1 remap
  [then]


  [ifdef] TIM8_CCMR3_Output_DEF
    \
    \ @brief capture/compare mode register 2 (output mode)
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant TIM8_OC5FE                     \ [0x02] Output compare 5 fast enable
    $03 constant TIM8_OC5PE                     \ [0x03] Output compare 5 preload enable
    $04 constant TIM8_OC5M                      \ [0x04 : 3] Output compare 5 mode
    $07 constant TIM8_OC5CE                     \ [0x07] Output compare 5 clear enable
    $0a constant TIM8_OC6FE                     \ [0x0a] Output compare 6 fast enable
    $0b constant TIM8_OC6PE                     \ [0x0b] Output compare 6 preload enable
    $0c constant TIM8_OC6M                      \ [0x0c : 3] Output compare 6 mode
    $0f constant TIM8_OC6CE                     \ [0x0f] Output compare 6 clear enable
    $10 constant TIM8_OC5M_bit3                 \ [0x10 : 3] Output Compare 5 mode bit 3
    $18 constant TIM8_OC6M_bit3                 \ [0x18] Output Compare 6 mode bit 3
  [then]


  [ifdef] TIM8_CCR5_DEF
    \
    \ @brief capture/compare register 4
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR5                      \ [0x00 : 16] Capture/Compare value
    $1d constant TIM8_GC5C1                     \ [0x1d] Group Channel 5 and Channel 1
    $1e constant TIM8_GC5C2                     \ [0x1e] Group Channel 5 and Channel 2
    $1f constant TIM8_GC5C3                     \ [0x1f] Group Channel 5 and Channel 3
  [then]


  [ifdef] TIM8_CCR6_DEF
    \
    \ @brief capture/compare register 4
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR6                      \ [0x00 : 16] Capture/Compare value
  [then]


  [ifdef] TIM8_OR2_DEF
    \
    \ @brief DMA address for full transfer
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM8_BKINE                     \ [0x00] BRK BKIN input enable
    $01 constant TIM8_BKCMP1E                   \ [0x01] BRK COMP1 enable
    $02 constant TIM8_BKCMP2E                   \ [0x02] BRK COMP2 enable
    $08 constant TIM8_BKDFBK2E                  \ [0x08] BRK DFSDM_BREAK2 enable
    $09 constant TIM8_BKINP                     \ [0x09] BRK BKIN input polarity
    $0a constant TIM8_BKCMP1P                   \ [0x0a] BRK COMP1 input polarity
    $0b constant TIM8_BKCMP2P                   \ [0x0b] BRK COMP2 input polarity
    $0e constant TIM8_ETRSEL                    \ [0x0e : 3] ETR source selection
  [then]


  [ifdef] TIM8_OR3_DEF
    \
    \ @brief DMA address for full transfer
    \ Address offset: 0x64
    \ Reset value: 0x00000001
    \
    $00 constant TIM8_BK2INE                    \ [0x00] BRK2 BKIN input enable
    $01 constant TIM8_BK2CMP1E                  \ [0x01] BRK2 COMP1 enable
    $02 constant TIM8_BK2CMP2E                  \ [0x02] BRK2 COMP2 enable
    $08 constant TIM8_BK2DFBK3E                 \ [0x08] BRK2 DFSDM_BREAK3 enable
    $09 constant TIM8_BK2INP                    \ [0x09] BRK2 BKIN input polarity
    $0a constant TIM8_BK2CMP1P                  \ [0x0a] BRK2 COMP1 input polarity
    $0b constant TIM8_BK2CMP2P                  \ [0x0b] BRK2 COMP2 input polarity
  [then]

  \
  \ @brief Advanced-timers
  \
  $00 constant TIM8_CR1                 \ control register 1
  $04 constant TIM8_CR2                 \ control register 2
  $08 constant TIM8_SMCR                \ slave mode control register
  $0C constant TIM8_DIER                \ DMA/Interrupt enable register
  $10 constant TIM8_SR                  \ status register
  $14 constant TIM8_EGR                 \ event generation register
  $18 constant TIM8_CCMR1_OUTPUT        \ capture/compare mode register 1 (output mode)
  $18 constant TIM8_CCMR1_INPUT         \ capture/compare mode register 1 (input mode)
  $1C constant TIM8_CCMR2_OUTPUT        \ capture/compare mode register 2 (output mode)
  $1C constant TIM8_CCMR2_INPUT         \ capture/compare mode register 2 (input mode)
  $20 constant TIM8_CCER                \ capture/compare enable register
  $24 constant TIM8_CNT                 \ counter
  $28 constant TIM8_PSC                 \ prescaler
  $2C constant TIM8_ARR                 \ auto-reload register
  $30 constant TIM8_RCR                 \ repetition counter register
  $34 constant TIM8_CCR1                \ capture/compare register 1
  $38 constant TIM8_CCR2                \ capture/compare register 2
  $3C constant TIM8_CCR3                \ capture/compare register 3
  $40 constant TIM8_CCR4                \ capture/compare register 4
  $44 constant TIM8_BDTR                \ break and dead-time register
  $48 constant TIM8_DCR                 \ DMA control register
  $4C constant TIM8_DMAR                \ DMA address for full transfer
  $50 constant TIM8_OR1                 \ DMA address for full transfer
  $54 constant TIM8_CCMR3_OUTPUT        \ capture/compare mode register 2 (output mode)
  $58 constant TIM8_CCR5                \ capture/compare register 4
  $5C constant TIM8_CCR6                \ capture/compare register 4
  $60 constant TIM8_OR2                 \ DMA address for full transfer
  $64 constant TIM8_OR3                 \ DMA address for full transfer

: TIM8_DEF ; [then]
