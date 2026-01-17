\
\ @file tim5.fs
\ @brief General purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM5_DEF

  [ifdef] TIM5_TIM5_CR1_DEF
    \
    \ @brief TIM5 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CEN                       \ [0x00] Counter enable
    $01 constant TIM5_UDIS                      \ [0x01] Update disable
    $02 constant TIM5_URS                       \ [0x02] Update request source
    $03 constant TIM5_OPM                       \ [0x03] One-pulse mode
    $04 constant TIM5_DIR                       \ [0x04] Direction
    $05 constant TIM5_CMS                       \ [0x05 : 2] Center-aligned mode selection
    $07 constant TIM5_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM5_CKD                       \ [0x08 : 2] Clock division
    $0b constant TIM5_UIFREMAP                  \ [0x0b] UIF status bit remapping
    $0c constant TIM5_DITHEN                    \ [0x0c] Dithering Enable
  [then]


  [ifdef] TIM5_TIM5_CR2_DEF
    \
    \ @brief TIM5 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant TIM5_CCDS                      \ [0x03] Capture/compare DMA selection
    $04 constant TIM5_MMS                       \ [0x04 : 3] MMS[0]: Master mode selection
    $07 constant TIM5_TI1S                      \ [0x07] tim_ti1 selection
    $19 constant TIM5_MMS_1                     \ [0x19] MMS[3]
    $1c constant TIM5_ADSYNC                    \ [0x1c] ADC synchronization
  [then]


  [ifdef] TIM5_TIM5_SMCR_DEF
    \
    \ @brief TIM5 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_SMS                       \ [0x00 : 3] SMS[0]: Slave mode selection
    $03 constant TIM5_OCCS                      \ [0x03] OCREF clear selection
    $04 constant TIM5_TS                        \ [0x04 : 3] TS[0]: Trigger selection
    $07 constant TIM5_MSM                       \ [0x07] Master/Slave mode
    $08 constant TIM5_ETF                       \ [0x08 : 4] External trigger filter
    $0c constant TIM5_ETPS                      \ [0x0c : 2] External trigger prescaler
    $0e constant TIM5_ECE                       \ [0x0e] External clock enable
    $0f constant TIM5_ETP                       \ [0x0f] External trigger polarity
    $10 constant TIM5_SMS_1                     \ [0x10] SMS[3]
    $14 constant TIM5_TS_1                      \ [0x14 : 2] TS[4:3]
    $18 constant TIM5_SMSPE                     \ [0x18] SMS preload enable
    $19 constant TIM5_SMSPS                     \ [0x19] SMS preload source
  [then]


  [ifdef] TIM5_TIM5_DIER_DEF
    \
    \ @brief TIM5 DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM5_CC1IE                     \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM5_CC2IE                     \ [0x02] Capture/Compare 2 interrupt enable
    $03 constant TIM5_CC3IE                     \ [0x03] Capture/Compare 3 interrupt enable
    $04 constant TIM5_CC4IE                     \ [0x04] Capture/Compare 4 interrupt enable
    $06 constant TIM5_TIE                       \ [0x06] Trigger interrupt enable
    $08 constant TIM5_UDE                       \ [0x08] Update DMA request enable
    $09 constant TIM5_CC1DE                     \ [0x09] Capture/Compare 1 DMA request enable
    $0a constant TIM5_CC2DE                     \ [0x0a] Capture/Compare 2 DMA request enable
    $0b constant TIM5_CC3DE                     \ [0x0b] Capture/Compare 3 DMA request enable
    $0c constant TIM5_CC4DE                     \ [0x0c] Capture/Compare 4 DMA request enable
    $0e constant TIM5_TDE                       \ [0x0e] Trigger DMA request enable
    $14 constant TIM5_IDXIE                     \ [0x14] Index interrupt enable
    $15 constant TIM5_DIRIE                     \ [0x15] Direction change interrupt enable
    $16 constant TIM5_IERRIE                    \ [0x16] Index error interrupt enable
    $17 constant TIM5_TERRIE                    \ [0x17] Transition error interrupt enable
  [then]


  [ifdef] TIM5_TIM5_SR_DEF
    \
    \ @brief TIM5 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_UIF                       \ [0x00] Update interrupt flag
    $01 constant TIM5_CC1IF                     \ [0x01] Capture/compare 1 interrupt flag
    $02 constant TIM5_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag
    $03 constant TIM5_CC3IF                     \ [0x03] Capture/Compare 3 interrupt flag
    $04 constant TIM5_CC4IF                     \ [0x04] Capture/Compare 4 interrupt flag
    $06 constant TIM5_TIF                       \ [0x06] Trigger interrupt flag
    $09 constant TIM5_CC1OF                     \ [0x09] Capture/Compare 1 overcapture flag
    $0a constant TIM5_CC2OF                     \ [0x0a] Capture/compare 2 overcapture flag
    $0b constant TIM5_CC3OF                     \ [0x0b] Capture/Compare 3 overcapture flag
    $0c constant TIM5_CC4OF                     \ [0x0c] Capture/Compare 4 overcapture flag
    $14 constant TIM5_IDXF                      \ [0x14] Index interrupt flag
    $15 constant TIM5_DIRF                      \ [0x15] Direction change interrupt flag
    $16 constant TIM5_IERRF                     \ [0x16] Index error interrupt flag
    $17 constant TIM5_TERRF                     \ [0x17] Transition error interrupt flag
  [then]


  [ifdef] TIM5_TIM5_EGR_DEF
    \
    \ @brief TIM5 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_UG                        \ [0x00] Update generation
    $01 constant TIM5_CC1G                      \ [0x01] Capture/compare 1 generation
    $02 constant TIM5_CC2G                      \ [0x02] Capture/compare 2 generation
    $03 constant TIM5_CC3G                      \ [0x03] Capture/compare 3 generation
    $04 constant TIM5_CC4G                      \ [0x04] Capture/compare 4 generation
    $06 constant TIM5_TG                        \ [0x06] Trigger generation
  [then]


  [ifdef] TIM5_TIM5_CCMR1_INPUT_DEF
    \
    \ @brief TIM5 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM5_IC1PSC                    \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM5_IC1F                      \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM5_CC2S                      \ [0x08 : 2] Capture/compare 2 selection
    $0a constant TIM5_IC2PSC                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM5_IC2F                      \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM5_TIM5_CCMR1_OUTPUT_DEF
    \
    \ @brief TIM5 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM5_OC1FE                     \ [0x02] Output compare 1 fast enable
    $03 constant TIM5_OC1PE                     \ [0x03] Output compare 1 preload enable
    $04 constant TIM5_OC1M                      \ [0x04 : 3] OC1M[2:0]: Output compare 1 mode
    $07 constant TIM5_OC1CE                     \ [0x07] Output compare 1 clear enable
    $08 constant TIM5_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM5_OC2FE                     \ [0x0a] Output compare 2 fast enable
    $0b constant TIM5_OC2PE                     \ [0x0b] Output compare 2 preload enable
    $0c constant TIM5_OC2M                      \ [0x0c : 3] OC2M[2:0]: Output compare 2 mode
    $0f constant TIM5_OC2CE                     \ [0x0f] Output compare 2 clear enable
    $10 constant TIM5_OC1M_1                    \ [0x10] OC1M[3]
    $18 constant TIM5_OC2M_1                    \ [0x18] OC2M[3]
  [then]


  [ifdef] TIM5_TIM5_CCMR2_INPUT_DEF
    \
    \ @brief TIM5 capture/compare mode register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection
    $02 constant TIM5_IC3PSC                    \ [0x02 : 2] Input capture 3 prescaler
    $04 constant TIM5_IC3F                      \ [0x04 : 4] Input capture 3 filter
    $08 constant TIM5_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection
    $0a constant TIM5_IC4PSC                    \ [0x0a : 2] Input capture 4 prescaler
    $0c constant TIM5_IC4F                      \ [0x0c : 4] Input capture 4 filter
  [then]


  [ifdef] TIM5_TIM5_CCMR2_OUTPUT_DEF
    \
    \ @brief TIM5 capture/compare mode register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection
    $02 constant TIM5_OC3FE                     \ [0x02] Output compare 3 fast enable
    $03 constant TIM5_OC3PE                     \ [0x03] Output compare 3 preload enable
    $04 constant TIM5_OC3M                      \ [0x04 : 3] OC3M[2:0]: Output compare 3 mode
    $07 constant TIM5_OC3CE                     \ [0x07] Output compare 3 clear enable
    $08 constant TIM5_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection
    $0a constant TIM5_OC4FE                     \ [0x0a] Output compare 4 fast enable
    $0b constant TIM5_OC4PE                     \ [0x0b] Output compare 4 preload enable
    $0c constant TIM5_OC4M                      \ [0x0c : 3] OC4M[2:0]: Output compare 4 mode
    $0f constant TIM5_OC4CE                     \ [0x0f] Output compare 4 clear enable
    $10 constant TIM5_OC3M_1                    \ [0x10] OC3M[3]
    $18 constant TIM5_OC4M_1                    \ [0x18] OC4M[3]
  [then]


  [ifdef] TIM5_TIM5_CCER_DEF
    \
    \ @brief TIM5 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CC1E                      \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM5_CC1P                      \ [0x01] Capture/Compare 1 output Polarity.
    $03 constant TIM5_CC1NP                     \ [0x03] Capture/Compare 1 output Polarity.
    $04 constant TIM5_CC2E                      \ [0x04] Capture/Compare 2 output enable.
    $05 constant TIM5_CC2P                      \ [0x05] Capture/Compare 2 output Polarity.
    $07 constant TIM5_CC2NP                     \ [0x07] Capture/Compare 2 output Polarity.
    $08 constant TIM5_CC3E                      \ [0x08] Capture/Compare 3 output enable.
    $09 constant TIM5_CC3P                      \ [0x09] Capture/Compare 3 output Polarity.
    $0b constant TIM5_CC3NP                     \ [0x0b] Capture/Compare 3 output Polarity.
    $0c constant TIM5_CC4E                      \ [0x0c] Capture/Compare 4 output enable.
    $0d constant TIM5_CC4P                      \ [0x0d] Capture/Compare 4 output Polarity.
    $0f constant TIM5_CC4NP                     \ [0x0f] Capture/Compare 4 output Polarity.
  [then]


  [ifdef] TIM5_TIM5_CNT_DEF
    \
    \ @brief TIM5 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CNT                       \ [0x00 : 31] Least significant part of counter value
    $1f constant TIM5_UIFCPY_CNT                \ [0x1f] Value depends on IUFREMAP in TIMx_CR1.
  [then]


  [ifdef] TIM5_TIM5_PSC_DEF
    \
    \ @brief TIM5 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_PSC                       \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM5_TIM5_ARR_DEF
    \
    \ @brief TIM5 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TIM5_ARR                       \ [0x00 : 32] Auto-reload value
  [then]


  [ifdef] TIM5_TIM5_CCR1_DEF
    \
    \ @brief TIM5 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CCR1                      \ [0x00 : 32] Capture/compare 1 value
  [then]


  [ifdef] TIM5_TIM5_CCR2_DEF
    \
    \ @brief TIM5 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CCR2                      \ [0x00 : 32] Capture/compare 2 value
  [then]


  [ifdef] TIM5_TIM5_CCR3_DEF
    \
    \ @brief TIM5 capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CCR3                      \ [0x00 : 32] Capture/compare 3 value
  [then]


  [ifdef] TIM5_TIM5_CCR4_DEF
    \
    \ @brief TIM5 capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_CCR4                      \ [0x00 : 32] Capture/compare 4 value
  [then]


  [ifdef] TIM5_TIM5_ECR_DEF
    \
    \ @brief TIM5 timer encoder control register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_IE                        \ [0x00] Index enable
    $01 constant TIM5_IDIR                      \ [0x01 : 2] Index direction
    $03 constant TIM5_IBLK                      \ [0x03 : 2] Index blanking
    $05 constant TIM5_FIDX                      \ [0x05] First index
    $06 constant TIM5_IPOS                      \ [0x06 : 2] Index positioning
    $10 constant TIM5_PW                        \ [0x10 : 8] Pulse width
    $18 constant TIM5_PWPRSC                    \ [0x18 : 3] Pulse width prescaler
  [then]


  [ifdef] TIM5_TIM5_TISEL_DEF
    \
    \ @brief TIM5 timer input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_TI1SEL                    \ [0x00 : 4] Selects tim_ti1[15:0] input
    $08 constant TIM5_TI2SEL                    \ [0x08 : 4] Selects tim_ti2[15:0] input
    $10 constant TIM5_TI3SEL                    \ [0x10 : 4] Selects tim_ti3[15:0] input
    $18 constant TIM5_TI4SEL                    \ [0x18 : 4] Selects tim_ti4[15:0] input
  [then]


  [ifdef] TIM5_TIM5_AF1_DEF
    \
    \ @brief TIM5 alternate function register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $0e constant TIM5_ETRSEL                    \ [0x0e : 4] etr_in source selection
  [then]


  [ifdef] TIM5_TIM5_AF2_DEF
    \
    \ @brief TIM5 alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $10 constant TIM5_OCRSEL                    \ [0x10 : 3] ocref_clr source selection
  [then]


  [ifdef] TIM5_TIM5_DCR_DEF
    \
    \ @brief TIM5 DMA control register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_DBA                       \ [0x00 : 5] DMA base address
    $08 constant TIM5_DBL                       \ [0x08 : 5] DMA burst length
    $10 constant TIM5_DBSS                      \ [0x10 : 4] DMA burst source selection
  [then]


  [ifdef] TIM5_TIM5_DMAR_DEF
    \
    \ @brief TIM5 DMA address for full transfer
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant TIM5_DMAB                      \ [0x00 : 32] DMA register for burst accesses
  [then]

  \
  \ @brief General purpose timers
  \
  $00 constant TIM5_TIM5_CR1            \ TIM5 control register 1
  $04 constant TIM5_TIM5_CR2            \ TIM5 control register 2
  $08 constant TIM5_TIM5_SMCR           \ TIM5 slave mode control register
  $0C constant TIM5_TIM5_DIER           \ TIM5 DMA/Interrupt enable register
  $10 constant TIM5_TIM5_SR             \ TIM5 status register
  $14 constant TIM5_TIM5_EGR            \ TIM5 event generation register
  $18 constant TIM5_TIM5_CCMR1_INPUT    \ TIM5 capture/compare mode register 1
  $18 constant TIM5_TIM5_CCMR1_OUTPUT   \ TIM5 capture/compare mode register 1
  $1C constant TIM5_TIM5_CCMR2_INPUT    \ TIM5 capture/compare mode register 2
  $1C constant TIM5_TIM5_CCMR2_OUTPUT   \ TIM5 capture/compare mode register 2
  $20 constant TIM5_TIM5_CCER           \ TIM5 capture/compare enable register
  $24 constant TIM5_TIM5_CNT            \ TIM5 counter
  $28 constant TIM5_TIM5_PSC            \ TIM5 prescaler
  $2C constant TIM5_TIM5_ARR            \ TIM5 auto-reload register
  $34 constant TIM5_TIM5_CCR1           \ TIM5 capture/compare register 1
  $38 constant TIM5_TIM5_CCR2           \ TIM5 capture/compare register 2
  $3C constant TIM5_TIM5_CCR3           \ TIM5 capture/compare register 3
  $40 constant TIM5_TIM5_CCR4           \ TIM5 capture/compare register 4
  $58 constant TIM5_TIM5_ECR            \ TIM5 timer encoder control register
  $5C constant TIM5_TIM5_TISEL          \ TIM5 timer input selection register
  $60 constant TIM5_TIM5_AF1            \ TIM5 alternate function register 1
  $64 constant TIM5_TIM5_AF2            \ TIM5 alternate function register 2
  $3DC constant TIM5_TIM5_DCR           \ TIM5 DMA control register
  $3E0 constant TIM5_TIM5_DMAR          \ TIM5 DMA address for full transfer

: TIM5_DEF ; [then]
