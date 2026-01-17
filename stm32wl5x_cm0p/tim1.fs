\
\ @file tim1.fs
\ @brief Advanced-control timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM1_DEF

  [ifdef] TIM1_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CEN                       \ [0x00] Counter enable
    $01 constant TIM1_UDIS                      \ [0x01] Update disable
    $02 constant TIM1_URS                       \ [0x02] Update request source
    $03 constant TIM1_OPM                       \ [0x03] One pulse mode
    $04 constant TIM1_DIR                       \ [0x04] Direction
    $05 constant TIM1_CMS                       \ [0x05 : 2] Center-aligned mode selection
    $07 constant TIM1_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM1_CKD                       \ [0x08 : 2] Clock division
    $0b constant TIM1_UIFREMAP                  \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM1_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCPC                      \ [0x00] Capture/compare preloaded control
    $02 constant TIM1_CCUS                      \ [0x02] Capture/compare control update selection
    $03 constant TIM1_CCDS                      \ [0x03] Capture/compare DMA selection
    $04 constant TIM1_MMS                       \ [0x04 : 3] Master mode selection
    $07 constant TIM1_TI1S                      \ [0x07] TI1 selection
    $08 constant TIM1_OIS1                      \ [0x08] Output Idle state 1 (OC1 output)
    $09 constant TIM1_OIS1N                     \ [0x09] Output Idle state 1 (OC1N output)
    $0a constant TIM1_OIS2                      \ [0x0a] Output Idle state 2 (OC2 output)
    $0b constant TIM1_OIS2N                     \ [0x0b] Output Idle state 2 (OC2N output)
    $0c constant TIM1_OIS3                      \ [0x0c] Output Idle state 3 (OC3 output)
    $0d constant TIM1_OIS3N                     \ [0x0d] Output Idle state 3 (OC3N output)
    $0e constant TIM1_OIS4                      \ [0x0e] Output Idle state 4 (OC4 output)
    $10 constant TIM1_OIS5                      \ [0x10] Output Idle state 5 (OC5 output)
    $12 constant TIM1_OIS6                      \ [0x12] Output Idle state 6 (OC6 output)
    $14 constant TIM1_MMS2                      \ [0x14 : 4] Master mode selection 2
  [then]


  [ifdef] TIM1_SMCR_DEF
    \
    \ @brief slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_SMS                       \ [0x00 : 3] Slave mode selection
    $03 constant TIM1_OCCS                      \ [0x03] OCREF clear selection
    $04 constant TIM1_TS                        \ [0x04 : 3] Trigger selection
    $07 constant TIM1_MSM                       \ [0x07] Master/slave mode
    $08 constant TIM1_ETF                       \ [0x08 : 4] External trigger filter
    $0c constant TIM1_ETPS                      \ [0x0c : 2] External trigger prescaler
    $0e constant TIM1_ECE                       \ [0x0e] External clock enable
    $0f constant TIM1_ETP                       \ [0x0f] External trigger polarity
    $10 constant TIM1_SMS_3                     \ [0x10] Slave mode selection
    $14 constant TIM1_TS3_4                     \ [0x14 : 2] Trigger selection
  [then]


  [ifdef] TIM1_DIER_DEF
    \
    \ @brief DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM1_CC1IE                     \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM1_CC2IE                     \ [0x02] Capture/Compare 2 interrupt enable
    $03 constant TIM1_CC3IE                     \ [0x03] Capture/Compare 3 interrupt enable
    $04 constant TIM1_CC4IE                     \ [0x04] Capture/Compare 4 interrupt enable
    $05 constant TIM1_COMIE                     \ [0x05] COM interrupt enable
    $06 constant TIM1_TIE                       \ [0x06] Trigger interrupt enable
    $07 constant TIM1_BIE                       \ [0x07] Break interrupt enable
    $08 constant TIM1_UDE                       \ [0x08] Update DMA request enable
    $09 constant TIM1_CC1DE                     \ [0x09] Capture/Compare 1 DMA request enable
    $0a constant TIM1_CC2DE                     \ [0x0a] Capture/Compare 2 DMA request enable
    $0b constant TIM1_CC3DE                     \ [0x0b] Capture/Compare 3 DMA request enable
    $0c constant TIM1_CC4DE                     \ [0x0c] Capture/Compare 4 DMA request enable
    $0d constant TIM1_COMDE                     \ [0x0d] COM DMA request enable
    $0e constant TIM1_TDE                       \ [0x0e] Trigger DMA request enable
  [then]


  [ifdef] TIM1_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_UIF                       \ [0x00] Update interrupt flag
    $01 constant TIM1_CC1IF                     \ [0x01] Capture/Compare 1 interrupt flag
    $02 constant TIM1_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag
    $03 constant TIM1_CC3IF                     \ [0x03] Capture/Compare 3 interrupt flag
    $04 constant TIM1_CC4IF                     \ [0x04] Capture/Compare 4 interrupt flag
    $05 constant TIM1_COMIF                     \ [0x05] COM interrupt flag
    $06 constant TIM1_TIF                       \ [0x06] Trigger interrupt flag
    $07 constant TIM1_BIF                       \ [0x07] Break interrupt flag
    $08 constant TIM1_B2IF                      \ [0x08] Break 2 interrupt flag
    $09 constant TIM1_CC1OF                     \ [0x09] Capture/Compare 1 overcapture flag
    $0a constant TIM1_CC2OF                     \ [0x0a] Capture/Compare 2 overcapture flag
    $0b constant TIM1_CC3OF                     \ [0x0b] Capture/Compare 3 overcapture flag
    $0c constant TIM1_CC4OF                     \ [0x0c] Capture/Compare 4 overcapture flag
    $0d constant TIM1_SBIF                      \ [0x0d] System Break interrupt flag
    $10 constant TIM1_CC5IF                     \ [0x10] Compare 5 interrupt flag
    $11 constant TIM1_CC6IF                     \ [0x11] Compare 6 interrupt flag
  [then]


  [ifdef] TIM1_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_UG                        \ [0x00] Update generation
    $01 constant TIM1_CC1G                      \ [0x01] Capture/Compare 1 generation
    $02 constant TIM1_CC2G                      \ [0x02] Capture/Compare 2 generation
    $03 constant TIM1_CC3G                      \ [0x03] Capture/Compare 3 generation
    $04 constant TIM1_CC4G                      \ [0x04] Capture/Compare 4 generation
    $05 constant TIM1_COM                       \ [0x05] Capture/Compare control update generation
    $06 constant TIM1_TG                        \ [0x06] Trigger generation
    $07 constant TIM1_BG                        \ [0x07] Break generation
    $08 constant TIM1_B2G                       \ [0x08] Break 2 generation
  [then]


  [ifdef] TIM1_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register 1 (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM1_OC1FE                     \ [0x02] Output compare 1 fast enable
    $03 constant TIM1_OC1PE                     \ [0x03] Output compare 1 preload enable
    $04 constant TIM1_OC1M                      \ [0x04 : 3] Output compare 1 mode
    $07 constant TIM1_OC1CE                     \ [0x07] Output compare 1 clear enable
    $08 constant TIM1_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM1_OC2FE                     \ [0x0a] Output compare 2 fast enable
    $0b constant TIM1_OC2PE                     \ [0x0b] Output compare 2 preload enable
    $0c constant TIM1_OC2M                      \ [0x0c : 3] Output compare 2 mode
    $0f constant TIM1_OC2CE                     \ [0x0f] Output compare 2 clear enable
    $10 constant TIM1_OC1M_3                    \ [0x10] Output Compare 1 mode - bit 3
    $18 constant TIM1_OC2M_3                    \ [0x18] Output Compare 2 mode - bit 3
  [then]


  [ifdef] TIM1_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM1_IC1PSC                    \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM1_IC1F                      \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM1_CC2S                      \ [0x08 : 2] Capture/compare 2 selection
    $0a constant TIM1_IC2PSC                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM1_IC2F                      \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM1_CCMR2_Output_DEF
    \
    \ @brief capture/compare mode register 2 (output mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection
    $02 constant TIM1_OC3FE                     \ [0x02] Output compare 3 fast enable
    $03 constant TIM1_OC3PE                     \ [0x03] Output compare 3 preload enable
    $04 constant TIM1_OC3M                      \ [0x04 : 3] Output compare 3 mode
    $07 constant TIM1_OC3CE                     \ [0x07] Output compare 3 clear enable
    $08 constant TIM1_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection
    $0a constant TIM1_OC4FE                     \ [0x0a] Output compare 4 fast enable
    $0b constant TIM1_OC4PE                     \ [0x0b] Output compare 4 preload enable
    $0c constant TIM1_OC4M                      \ [0x0c : 3] Output compare 4 mode
    $0f constant TIM1_OC4CE                     \ [0x0f] Output compare 4 clear enable
    $10 constant TIM1_OC3M_3                    \ [0x10] Output Compare 3 mode - bit 3
    $18 constant TIM1_OC4M_3                    \ [0x18] Output Compare 4 mode - bit 3
  [then]


  [ifdef] TIM1_CCMR2_Input_DEF
    \
    \ @brief capture/compare mode register 2 (input mode)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection
    $02 constant TIM1_IC3PSC                    \ [0x02 : 2] Input capture 3 prescaler
    $04 constant TIM1_IC3F                      \ [0x04 : 4] Input capture 3 filter
    $08 constant TIM1_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection
    $0a constant TIM1_IC4PSC                    \ [0x0a : 2] Input capture 4 prescaler
    $0c constant TIM1_IC4F                      \ [0x0c : 4] Input capture 4 filter
  [then]


  [ifdef] TIM1_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC1E                      \ [0x00] CC1E
    $01 constant TIM1_CC1P                      \ [0x01] CC1P
    $02 constant TIM1_CC1NE                     \ [0x02] CC1NE
    $03 constant TIM1_CC1NP                     \ [0x03] CC1NP
    $04 constant TIM1_CC2E                      \ [0x04] CC2E
    $05 constant TIM1_CC2P                      \ [0x05] CC2P
    $06 constant TIM1_CC2NE                     \ [0x06] CC2NE
    $07 constant TIM1_CC2NP                     \ [0x07] CC2NP
    $08 constant TIM1_CC3E                      \ [0x08] CC3E
    $09 constant TIM1_CC3P                      \ [0x09] CC3P
    $0a constant TIM1_CC3NE                     \ [0x0a] CC3NE
    $0b constant TIM1_CC3NP                     \ [0x0b] CC3NP
    $0c constant TIM1_CC4E                      \ [0x0c] CC4E
    $0d constant TIM1_CC4P                      \ [0x0d] CC4P
    $10 constant TIM1_CC5E                      \ [0x10] CC5E
    $11 constant TIM1_CC5P                      \ [0x11] CC5P
    $14 constant TIM1_CC6E                      \ [0x14] CC6E
    $15 constant TIM1_CC6P                      \ [0x15] CC6P
  [then]


  [ifdef] TIM1_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CNT                       \ [0x00 : 16] CNT
    $1f constant TIM1_UIFCPY                    \ [0x1f] UIF copy
  [then]


  [ifdef] TIM1_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_PSC                       \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM1_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM1_ARR                       \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM1_RCR_DEF
    \
    \ @brief repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_REP                       \ [0x00 : 16] Repetition counter value
  [then]


  [ifdef] TIM1_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR1                      \ [0x00 : 16] Capture/Compare 1 value
  [then]


  [ifdef] TIM1_CCR2_DEF
    \
    \ @brief capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR2                      \ [0x00 : 16] Capture/Compare 2 value
  [then]


  [ifdef] TIM1_CCR3_DEF
    \
    \ @brief capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR3                      \ [0x00 : 16] Capture/Compare value
  [then]


  [ifdef] TIM1_CCR4_DEF
    \
    \ @brief capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR4                      \ [0x00 : 16] Capture/Compare value
  [then]


  [ifdef] TIM1_BDTR_DEF
    \
    \ @brief break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_DT                        \ [0x00 : 8] Dead-time generator setup
    $08 constant TIM1_LOCK                      \ [0x08 : 2] Lock configuration
    $0a constant TIM1_OSSI                      \ [0x0a] Off-state selection for Idle mode
    $0b constant TIM1_OSSR                      \ [0x0b] Off-state selection for Run mode
    $0c constant TIM1_BKE                       \ [0x0c] Break enable
    $0d constant TIM1_BKP                       \ [0x0d] Break polarity
    $0e constant TIM1_AOE                       \ [0x0e] Automatic output enable
    $0f constant TIM1_MOE                       \ [0x0f] Main output enable
    $10 constant TIM1_BKF                       \ [0x10 : 4] Break filter
    $14 constant TIM1_BK2F                      \ [0x14 : 4] Break 2 filter
    $18 constant TIM1_BK2E                      \ [0x18] Break 2 enable
    $19 constant TIM1_BK2P                      \ [0x19] Break 2 polarity
    $1a constant TIM1_BKDSRM                    \ [0x1a] BKDSRM
    $1b constant TIM1_BK2DSRM                   \ [0x1b] Break2 Disarm
    $1c constant TIM1_BKBID                     \ [0x1c] BKBID
    $1d constant TIM1_BK2BID                    \ [0x1d] Break2 bidirectional
  [then]


  [ifdef] TIM1_DCR_DEF
    \
    \ @brief DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_DBA                       \ [0x00 : 5] DMA base address
    $08 constant TIM1_DBL                       \ [0x08 : 5] DMA burst length
  [then]


  [ifdef] TIM1_DMAR_DEF
    \
    \ @brief DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_DMAB                      \ [0x00 : 16] DMA register for burst accesses
  [then]


  [ifdef] TIM1_OR1_DEF
    \
    \ @brief option register 1
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_TIM1_ETR_ADC1_RMP         \ [0x00 : 2] TIM1_ETR_ADC1 remapping capability
    $04 constant TIM1_TI1_RMP                   \ [0x04] Input Capture 1 remap
  [then]


  [ifdef] TIM1_CCMR3OutputComparemode_DEF
    \
    \ @brief capture/compare mode register 3
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant TIM1_OC5FE                     \ [0x02] OC5FE
    $03 constant TIM1_OC5PE                     \ [0x03] OC5PE
    $04 constant TIM1_OC5M                      \ [0x04 : 3] OC5M
    $07 constant TIM1_OC5CE                     \ [0x07] OC5CE
    $0a constant TIM1_OC6FE                     \ [0x0a] OC6FE
    $0b constant TIM1_OC6PE                     \ [0x0b] OC6PE
    $0c constant TIM1_OC6M                      \ [0x0c : 3] OC6M
    $0f constant TIM1_OC6CE                     \ [0x0f] OC6CE
    $10 constant TIM1_OC5M_3                    \ [0x10] OC5M
    $18 constant TIM1_OC6M_3                    \ [0x18] OC6M
  [then]


  [ifdef] TIM1_CCR5_DEF
    \
    \ @brief capture/compare register 5
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR5                      \ [0x00 : 16] Capture/Compare 5 value
    $1d constant TIM1_GC5C1                     \ [0x1d] Group Channel 5 and Channel 1
    $1e constant TIM1_GC5C2                     \ [0x1e] Group Channel 5 and Channel 2
    $1f constant TIM1_GC5C3                     \ [0x1f] Group Channel 5 and Channel 3
  [then]


  [ifdef] TIM1_CCR6_DEF
    \
    \ @brief capture/compare register 6
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR6                      \ [0x00 : 16] Capture/Compare 6 value
  [then]


  [ifdef] TIM1_AF1_DEF
    \
    \ @brief alternate function option register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM1_BKINE                     \ [0x00] BRK BKIN input enable
    $01 constant TIM1_BKCMP1E                   \ [0x01] BRK COMP1 enable
    $02 constant TIM1_BKCMP2E                   \ [0x02] BRK COMP2 enable
    $09 constant TIM1_BKINP                     \ [0x09] BRK BKIN input polarity
    $0a constant TIM1_BKCMP1P                   \ [0x0a] BRK COMP1 input polarity
    $0b constant TIM1_BKCMP2P                   \ [0x0b] BRK COMP2 input polarity
    $0e constant TIM1_ResETRSEL                 \ [0x0e : 4] ETR source selection
  [then]


  [ifdef] TIM1_AF2_DEF
    \
    \ @brief Alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000001
    \
    $00 constant TIM1_BK2INE                    \ [0x00] BRK2 BKIN input enable
    $01 constant TIM1_BK2CMP1E                  \ [0x01] BRK2 COMP1 enable
    $02 constant TIM1_BK2CMP2E                  \ [0x02] BRK2 COMP2 enable
    $09 constant TIM1_BK2INP                    \ [0x09] BRK2 BKIN2 input polarity
    $0a constant TIM1_BK2CMP1P                  \ [0x0a] BRK2 COMP1 input polarity
    $0b constant TIM1_BK2CMP2P                  \ [0x0b] BRK2 COMP2 input polarity
  [then]


  [ifdef] TIM1_TISEL_DEF
    \
    \ @brief timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_TI1SEL                    \ [0x00 : 4] selects TI1[0] to TI1[15] input
    $08 constant TIM1_TI2SEL                    \ [0x08 : 4] selects TI2[0] to TI2[15] input
    $10 constant TIM1_TI3SEL                    \ [0x10 : 4] selects TI3[0] to TI3[15] input
    $18 constant TIM1_TI4SEL                    \ [0x18 : 4] selects TI4[0] to TI4[15] input
  [then]

  \
  \ @brief Advanced-control timers
  \
  $00 constant TIM1_CR1                 \ control register 1
  $04 constant TIM1_CR2                 \ control register 2
  $08 constant TIM1_SMCR                \ slave mode control register
  $0C constant TIM1_DIER                \ DMA/interrupt enable register
  $10 constant TIM1_SR                  \ status register
  $14 constant TIM1_EGR                 \ event generation register
  $18 constant TIM1_CCMR1_OUTPUT        \ capture/compare mode register 1 (output mode)
  $18 constant TIM1_CCMR1_INPUT         \ capture/compare mode register 1 (input mode)
  $1C constant TIM1_CCMR2_OUTPUT        \ capture/compare mode register 2 (output mode)
  $1C constant TIM1_CCMR2_INPUT         \ capture/compare mode register 2 (input mode)
  $20 constant TIM1_CCER                \ capture/compare enable register
  $24 constant TIM1_CNT                 \ counter
  $28 constant TIM1_PSC                 \ prescaler
  $2C constant TIM1_ARR                 \ auto-reload register
  $30 constant TIM1_RCR                 \ repetition counter register
  $34 constant TIM1_CCR1                \ capture/compare register 1
  $38 constant TIM1_CCR2                \ capture/compare register 2
  $3C constant TIM1_CCR3                \ capture/compare register 3
  $40 constant TIM1_CCR4                \ capture/compare register 4
  $44 constant TIM1_BDTR                \ break and dead-time register
  $48 constant TIM1_DCR                 \ DMA control register
  $4C constant TIM1_DMAR                \ DMA address for full transfer
  $50 constant TIM1_OR1                 \ option register 1
  $54 constant TIM1_CCMR3OUTPUTCOMPAREMODE    \ capture/compare mode register 3
  $58 constant TIM1_CCR5                \ capture/compare register 5
  $5C constant TIM1_CCR6                \ capture/compare register 6
  $60 constant TIM1_AF1                 \ alternate function option register 1
  $64 constant TIM1_AF2                 \ Alternate function register 2
  $68 constant TIM1_TISEL               \ timer input selection register

: TIM1_DEF ; [then]
