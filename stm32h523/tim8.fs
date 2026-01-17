\
\ @file tim8.fs
\ @brief TIM8 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM8_DEF

  [ifdef] TIM8_TIM8_CR1_DEF
    \
    \ @brief TIM8 control register 1
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
    $0b constant TIM8_UIFREMAP                  \ [0x0b] UIF status bit remapping
    $0c constant TIM8_DITHEN                    \ [0x0c] Dithering enable
  [then]


  [ifdef] TIM8_TIM8_CR2_DEF
    \
    \ @brief TIM8 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCPC                      \ [0x00] Capture/compare preloaded control
    $02 constant TIM8_CCUS                      \ [0x02] Capture/compare control update selection
    $03 constant TIM8_CCDS                      \ [0x03] Capture/compare DMA selection
    $04 constant TIM8_MMS                       \ [0x04 : 3] MMS[2:0]: Master mode selection
    $07 constant TIM8_TI1S                      \ [0x07] tim_ti1 selection
    $08 constant TIM8_OIS1                      \ [0x08] Output idle state 1 (tim_oc1 output)
    $09 constant TIM8_OIS1N                     \ [0x09] Output idle state 1 (tim_oc1n output)
    $0a constant TIM8_OIS2                      \ [0x0a] Output idle state 2 (tim_oc2 output)
    $0b constant TIM8_OIS2N                     \ [0x0b] Output idle state 2 (tim_oc2n output)
    $0c constant TIM8_OIS3                      \ [0x0c] Output idle state 3 (tim_oc3n output)
    $0d constant TIM8_OIS3N                     \ [0x0d] Output idle state 3 (tim_oc3n output)
    $0e constant TIM8_OIS4                      \ [0x0e] Output idle state 4 (tim_oc4 output)
    $0f constant TIM8_OIS4N                     \ [0x0f] Output idle state 4 (tim_oc4n output)
    $10 constant TIM8_OIS5                      \ [0x10] Output idle state 5 (tim_oc5 output)
    $12 constant TIM8_OIS6                      \ [0x12] Output idle state 6 (tim_oc6 output)
    $14 constant TIM8_MMS2                      \ [0x14 : 4] Master mode selection 2
    $19 constant TIM8_MMS_1                     \ [0x19] MMS[3]
  [then]


  [ifdef] TIM8_TIM8_SMCR_DEF
    \
    \ @brief TIM8 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_SMS                       \ [0x00 : 3] SMS[2:0]: Slave mode selection
    $03 constant TIM8_OCCS                      \ [0x03] OCREF clear selection
    $04 constant TIM8_TS                        \ [0x04 : 3] TS[2:0]: Trigger selection
    $07 constant TIM8_MSM                       \ [0x07] Master/slave mode
    $08 constant TIM8_ETF                       \ [0x08 : 4] External trigger filter
    $0c constant TIM8_ETPS                      \ [0x0c : 2] External trigger prescaler
    $0e constant TIM8_ECE                       \ [0x0e] External clock enable
    $0f constant TIM8_ETP                       \ [0x0f] External trigger polarity
    $10 constant TIM8_SMS_1                     \ [0x10] Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $14 constant TIM8_TS_1                      \ [0x14 : 2] Trigger selection This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for product specific implementation details. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
    $18 constant TIM8_SMSPE                     \ [0x18] SMS preload enable
    $19 constant TIM8_SMSPS                     \ [0x19] SMS preload source
  [then]


  [ifdef] TIM8_TIM8_DIER_DEF
    \
    \ @brief TIM8 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM8_CC1IE                     \ [0x01] Capture/compare 1 interrupt enable
    $02 constant TIM8_CC2IE                     \ [0x02] Capture/compare 2 interrupt enable
    $03 constant TIM8_CC3IE                     \ [0x03] Capture/compare 3 interrupt enable
    $04 constant TIM8_CC4IE                     \ [0x04] Capture/compare 4 interrupt enable
    $05 constant TIM8_COMIE                     \ [0x05] COM interrupt enable
    $06 constant TIM8_TIE                       \ [0x06] Trigger interrupt enable
    $07 constant TIM8_BIE                       \ [0x07] Break interrupt enable
    $08 constant TIM8_UDE                       \ [0x08] Update DMA request enable
    $09 constant TIM8_CC1DE                     \ [0x09] Capture/compare 1 DMA request enable
    $0a constant TIM8_CC2DE                     \ [0x0a] Capture/compare 2 DMA request enable
    $0b constant TIM8_CC3DE                     \ [0x0b] Capture/compare 3 DMA request enable
    $0c constant TIM8_CC4DE                     \ [0x0c] Capture/compare 4 DMA request enable
    $0d constant TIM8_COMDE                     \ [0x0d] COM DMA request enable
    $0e constant TIM8_TDE                       \ [0x0e] Trigger DMA request enable
    $14 constant TIM8_IDXIE                     \ [0x14] Index interrupt enable
    $15 constant TIM8_DIRIE                     \ [0x15] Direction change interrupt enable
    $16 constant TIM8_IERRIE                    \ [0x16] Index error interrupt enable
    $17 constant TIM8_TERRIE                    \ [0x17] Transition error interrupt enable
  [then]


  [ifdef] TIM8_TIM8_SR_DEF
    \
    \ @brief TIM8 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_UIF                       \ [0x00] Update interrupt flag
    $01 constant TIM8_CC1IF                     \ [0x01] Capture/compare 1 interrupt flag
    $02 constant TIM8_CC2IF                     \ [0x02] Capture/compare 2 interrupt flag
    $03 constant TIM8_CC3IF                     \ [0x03] Capture/compare 3 interrupt flag
    $04 constant TIM8_CC4IF                     \ [0x04] Capture/compare 4 interrupt flag
    $05 constant TIM8_COMIF                     \ [0x05] COM interrupt flag
    $06 constant TIM8_TIF                       \ [0x06] Trigger interrupt flag
    $07 constant TIM8_BIF                       \ [0x07] Break interrupt flag
    $08 constant TIM8_B2IF                      \ [0x08] Break 2 interrupt flag
    $09 constant TIM8_CC1OF                     \ [0x09] Capture/compare 1 overcapture flag
    $0a constant TIM8_CC2OF                     \ [0x0a] Capture/compare 2 overcapture flag
    $0b constant TIM8_CC3OF                     \ [0x0b] Capture/compare 3 overcapture flag
    $0c constant TIM8_CC4OF                     \ [0x0c] Capture/compare 4 overcapture flag
    $0d constant TIM8_SBIF                      \ [0x0d] System break interrupt flag
    $10 constant TIM8_CC5IF                     \ [0x10] Compare 5 interrupt flag
    $11 constant TIM8_CC6IF                     \ [0x11] Compare 6 interrupt flag
    $14 constant TIM8_IDXF                      \ [0x14] Index interrupt flag
    $15 constant TIM8_DIRF                      \ [0x15] Direction change interrupt flag
    $16 constant TIM8_IERRF                     \ [0x16] Index error interrupt flag
    $17 constant TIM8_TERRF                     \ [0x17] Transition error interrupt flag
  [then]


  [ifdef] TIM8_TIM8_EGR_DEF
    \
    \ @brief TIM8 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_UG                        \ [0x00] Update generation
    $01 constant TIM8_CC1G                      \ [0x01] Capture/compare 1 generation
    $02 constant TIM8_CC2G                      \ [0x02] Capture/compare 2 generation
    $03 constant TIM8_CC3G                      \ [0x03] Capture/compare 3 generation
    $04 constant TIM8_CC4G                      \ [0x04] Capture/compare 4 generation
    $05 constant TIM8_COMG                      \ [0x05] Capture/compare control update generation
    $06 constant TIM8_TG                        \ [0x06] Trigger generation
    $07 constant TIM8_BG                        \ [0x07] Break generation
    $08 constant TIM8_B2G                       \ [0x08] Break 2 generation
  [then]


  [ifdef] TIM8_TIM8_CCMR1_DEF
    \
    \ @brief TIM8 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC1S                      \ [0x00 : 2] Capture/compare 1 Selection
    $02 constant TIM8_IC1PSC                    \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM8_IC1F                      \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM8_CC2S                      \ [0x08 : 2] Capture/compare 2 selection
    $0a constant TIM8_IC2PSC                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM8_IC2F                      \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM8_TIM8_CCMR1_ALTERNATE1_DEF
    \
    \ @brief TIM8 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC1S                      \ [0x00 : 2] Capture/compare 1 selection
    $02 constant TIM8_OC1FE                     \ [0x02] Output compare 1 fast enable
    $03 constant TIM8_OC1PE                     \ [0x03] Output compare 1 preload enable
    $04 constant TIM8_OC1M                      \ [0x04 : 3] OC1M[2:0]: Output compare 1 mode
    $07 constant TIM8_OC1CE                     \ [0x07] Output compare 1 clear enable
    $08 constant TIM8_CC2S                      \ [0x08 : 2] Capture/compare 2 selection
    $0a constant TIM8_OC2FE                     \ [0x0a] Output compare 2 fast enable
    $0b constant TIM8_OC2PE                     \ [0x0b] Output compare 2 preload enable
    $0c constant TIM8_OC2M                      \ [0x0c : 3] OC2M[2:0]: Output compare 2 mode
    $0f constant TIM8_OC2CE                     \ [0x0f] Output compare 2 clear enable
    $10 constant TIM8_OC1M_1                    \ [0x10] OC1M[3]
    $18 constant TIM8_OC2M_1                    \ [0x18] OC2M[3]
  [then]


  [ifdef] TIM8_TIM8_CCMR2_DEF
    \
    \ @brief TIM8 capture/compare mode register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC3S                      \ [0x00 : 2] Capture/compare 3 selection
    $02 constant TIM8_IC3PSC                    \ [0x02 : 2] Input capture 3 prescaler
    $04 constant TIM8_IC3F                      \ [0x04 : 4] Input capture 3 filter
    $08 constant TIM8_CC4S                      \ [0x08 : 2] Capture/compare 4 selection
    $0a constant TIM8_IC4PSC                    \ [0x0a : 2] Input capture 4 prescaler
    $0c constant TIM8_IC4F                      \ [0x0c : 4] Input capture 4 filter
  [then]


  [ifdef] TIM8_TIM8_CCMR2_ALTERNATE1_DEF
    \
    \ @brief TIM8 capture/compare mode register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC3S                      \ [0x00 : 2] Capture/compare 3 selection
    $02 constant TIM8_OC3FE                     \ [0x02] Output compare 3 fast enable
    $03 constant TIM8_OC3PE                     \ [0x03] Output compare 3 preload enable
    $04 constant TIM8_OC3M                      \ [0x04 : 3] OC3M[2:0]: Output compare 3 mode
    $07 constant TIM8_OC3CE                     \ [0x07] Output compare 3 clear enable
    $08 constant TIM8_CC4S                      \ [0x08 : 2] Capture/compare 4 selection
    $0a constant TIM8_OC4FE                     \ [0x0a] Output compare 4 fast enable
    $0b constant TIM8_OC4PE                     \ [0x0b] Output compare 4 preload enable
    $0c constant TIM8_OC4M                      \ [0x0c : 3] OC4M[2:0]: Output compare 4 mode
    $0f constant TIM8_OC4CE                     \ [0x0f] Output compare 4 clear enable
    $10 constant TIM8_OC3M_1                    \ [0x10] OC3M[3]
    $18 constant TIM8_OC4M_1                    \ [0x18] OC4M[3]
  [then]


  [ifdef] TIM8_TIM8_CCER_DEF
    \
    \ @brief TIM8 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC1E                      \ [0x00] Capture/compare 1 output enable
    $01 constant TIM8_CC1P                      \ [0x01] Capture/compare 1 output polarity
    $02 constant TIM8_CC1NE                     \ [0x02] Capture/compare 1 complementary output enable
    $03 constant TIM8_CC1NP                     \ [0x03] Capture/compare 1 complementary output polarity
    $04 constant TIM8_CC2E                      \ [0x04] Capture/compare 2 output enable
    $05 constant TIM8_CC2P                      \ [0x05] Capture/compare 2 output polarity
    $06 constant TIM8_CC2NE                     \ [0x06] Capture/compare 2 complementary output enable
    $07 constant TIM8_CC2NP                     \ [0x07] Capture/compare 2 complementary output polarity
    $08 constant TIM8_CC3E                      \ [0x08] Capture/compare 3 output enable
    $09 constant TIM8_CC3P                      \ [0x09] Capture/compare 3 output polarity
    $0a constant TIM8_CC3NE                     \ [0x0a] Capture/compare 3 complementary output enable
    $0b constant TIM8_CC3NP                     \ [0x0b] Capture/compare 3 complementary output polarity
    $0c constant TIM8_CC4E                      \ [0x0c] Capture/compare 4 output enable
    $0d constant TIM8_CC4P                      \ [0x0d] Capture/compare 4 output polarity
    $0e constant TIM8_CC4NE                     \ [0x0e] Capture/compare 4 complementary output enable
    $0f constant TIM8_CC4NP                     \ [0x0f] Capture/compare 4 complementary output polarity
    $10 constant TIM8_CC5E                      \ [0x10] Capture/compare 5 output enable
    $11 constant TIM8_CC5P                      \ [0x11] Capture/compare 5 output polarity
    $14 constant TIM8_CC6E                      \ [0x14] Capture/compare 6 output enable
    $15 constant TIM8_CC6P                      \ [0x15] Capture/compare 6 output polarity
  [then]


  [ifdef] TIM8_TIM8_CNT_DEF
    \
    \ @brief TIM8 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CNT                       \ [0x00 : 16] Counter value
    $1f constant TIM8_UIFCPY                    \ [0x1f] UIF copy
  [then]


  [ifdef] TIM8_TIM8_PSC_DEF
    \
    \ @brief TIM8 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_PSC                       \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM8_TIM8_ARR_DEF
    \
    \ @brief TIM8 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM8_ARR                       \ [0x00 : 20] Auto-reload value
  [then]


  [ifdef] TIM8_TIM8_RCR_DEF
    \
    \ @brief TIM8 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_REP                       \ [0x00 : 16] Repetition counter reload value
  [then]


  [ifdef] TIM8_TIM8_CCR1_DEF
    \
    \ @brief TIM8 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR1                      \ [0x00 : 20] Capture/compare 1 value
  [then]


  [ifdef] TIM8_TIM8_CCR2_DEF
    \
    \ @brief TIM8 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR2                      \ [0x00 : 20] Capture/compare 2 value
  [then]


  [ifdef] TIM8_TIM8_CCR3_DEF
    \
    \ @brief TIM8 capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR3                      \ [0x00 : 20] Capture/compare value
  [then]


  [ifdef] TIM8_TIM8_CCR4_DEF
    \
    \ @brief TIM8 capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR4                      \ [0x00 : 20] Capture/compare value
  [then]


  [ifdef] TIM8_TIM8_BDTR_DEF
    \
    \ @brief TIM8 break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DTG                       \ [0x00 : 8] Dead-time generator setup
    $08 constant TIM8_LOCK                      \ [0x08 : 2] Lock configuration
    $0a constant TIM8_OSSI                      \ [0x0a] Off-state selection for idle mode
    $0b constant TIM8_OSSR                      \ [0x0b] Off-state selection for Run mode
    $0c constant TIM8_BKE                       \ [0x0c] Break enable
    $0d constant TIM8_BKP                       \ [0x0d] Break polarity
    $0e constant TIM8_AOE                       \ [0x0e] Automatic output enable
    $0f constant TIM8_MOE                       \ [0x0f] Main output enable
    $10 constant TIM8_BKF                       \ [0x10 : 4] Break filter
    $14 constant TIM8_BK2F                      \ [0x14 : 4] Break 2 filter
    $18 constant TIM8_BK2E                      \ [0x18] Break 2 enable
    $19 constant TIM8_BK2P                      \ [0x19] Break 2 polarity
    $1a constant TIM8_BKDSRM                    \ [0x1a] Break disarm
    $1b constant TIM8_BK2DSRM                   \ [0x1b] Break2 disarm
    $1c constant TIM8_BKBID                     \ [0x1c] Break bidirectional
    $1d constant TIM8_BK2BID                    \ [0x1d] Break2 bidirectional
  [then]


  [ifdef] TIM8_TIM8_CCR5_DEF
    \
    \ @brief TIM8 capture/compare register 5
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR5                      \ [0x00 : 20] Capture/compare 5 value
    $1d constant TIM8_GC5C1                     \ [0x1d] Group channel 5 and channel 1
    $1e constant TIM8_GC5C2                     \ [0x1e] Group channel 5 and channel 2
    $1f constant TIM8_GC5C3                     \ [0x1f] Group channel 5 and channel 3
  [then]


  [ifdef] TIM8_TIM8_CCR6_DEF
    \
    \ @brief TIM8 capture/compare register 6
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR6                      \ [0x00 : 20] Capture/compare 6 value
  [then]


  [ifdef] TIM8_TIM8_CCMR3_DEF
    \
    \ @brief TIM8 capture/compare mode register 3
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $02 constant TIM8_OC5FE                     \ [0x02] Output compare 5 fast enable
    $03 constant TIM8_OC5PE                     \ [0x03] Output compare 5 preload enable
    $04 constant TIM8_OC5M                      \ [0x04 : 3] OC5M[2:0]: Output compare 5 mode
    $07 constant TIM8_OC5CE                     \ [0x07] Output compare 5 clear enable
    $0a constant TIM8_OC6FE                     \ [0x0a] Output compare 6 fast enable
    $0b constant TIM8_OC6PE                     \ [0x0b] Output compare 6 preload enable
    $0c constant TIM8_OC6M                      \ [0x0c : 3] OC6M[2:0]: Output compare 6 mode
    $0f constant TIM8_OC6CE                     \ [0x0f] Output compare 6 clear enable
    $10 constant TIM8_OC5M_1                    \ [0x10] OC5M[3]
    $18 constant TIM8_OC6M_1                    \ [0x18] OC6M[3]
  [then]


  [ifdef] TIM8_TIM8_DTR2_DEF
    \
    \ @brief TIM8 timer deadtime register 2
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DTGF                      \ [0x00 : 8] Dead-time falling edge generator setup
    $10 constant TIM8_DTAE                      \ [0x10] Deadtime asymmetric enable
    $11 constant TIM8_DTPE                      \ [0x11] Deadtime preload enable
  [then]


  [ifdef] TIM8_TIM8_ECR_DEF
    \
    \ @brief TIM8 timer encoder control register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_IE                        \ [0x00] Index enable
    $01 constant TIM8_IDIR                      \ [0x01 : 2] Index direction
    $03 constant TIM8_IBLK                      \ [0x03 : 2] Index blanking
    $05 constant TIM8_FIDX                      \ [0x05] First index
    $06 constant TIM8_IPOS                      \ [0x06 : 2] Index positioning
    $10 constant TIM8_PW                        \ [0x10 : 8] Pulse width
    $18 constant TIM8_PWPRSC                    \ [0x18 : 3] Pulse width prescaler
  [then]


  [ifdef] TIM8_TIM8_TISEL_DEF
    \
    \ @brief TIM8 timer input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_TI1SEL                    \ [0x00 : 4] Selects tim_ti1[15:0] input
    $08 constant TIM8_TI2SEL                    \ [0x08 : 4] Selects tim_ti2[15:0] input
    $10 constant TIM8_TI3SEL                    \ [0x10 : 4] Selects tim_ti3[15:0] input
    $18 constant TIM8_TI4SEL                    \ [0x18 : 4] Selects tim_ti4[15:0] input
  [then]


  [ifdef] TIM8_TIM8_AF1_DEF
    \
    \ @brief TIM8 alternate function option register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM8_BKINE                     \ [0x00] TIMx_BKIN input enable
    $01 constant TIM8_BKCMP1E                   \ [0x01] tim_brk_cmp1 enable
    $02 constant TIM8_BKCMP2E                   \ [0x02] tim_brk_cmp2 enable
    $03 constant TIM8_BKCMP3E                   \ [0x03] tim_brk_cmp3 enable
    $04 constant TIM8_BKCMP4E                   \ [0x04] tim_brk_cmp4 enable
    $05 constant TIM8_BKCMP5E                   \ [0x05] tim_brk_cmp5 enable
    $06 constant TIM8_BKCMP6E                   \ [0x06] tim_brk_cmp6 enable
    $07 constant TIM8_BKCMP7E                   \ [0x07] tim_brk_cmp7 enable
    $08 constant TIM8_BKCMP8E                   \ [0x08] tim_brk_cmp8 enable
    $09 constant TIM8_BKINP                     \ [0x09] TIMx_BKIN input polarity
    $0a constant TIM8_BKCMP1P                   \ [0x0a] tim_brk_cmp1 input polarity
    $0b constant TIM8_BKCMP2P                   \ [0x0b] tim_brk_cmp2 input polarity
    $0c constant TIM8_BKCMP3P                   \ [0x0c] tim_brk_cmp3 input polarity
    $0d constant TIM8_BKCMP4P                   \ [0x0d] tim_brk_cmp4 input polarity
    $0e constant TIM8_ETRSEL                    \ [0x0e : 4] etr_in source selection
  [then]


  [ifdef] TIM8_TIM8_AF2_DEF
    \
    \ @brief TIM8 alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000001
    \
    $00 constant TIM8_BK2INE                    \ [0x00] TIMx_BKIN2 input enable
    $01 constant TIM8_BK2CMP1E                  \ [0x01] tim_brk2_cmp1 enable
    $02 constant TIM8_BK2CMP2E                  \ [0x02] tim_brk2_cmp2 enable
    $03 constant TIM8_BK2CMP3E                  \ [0x03] tim_brk2_cmp3 enable
    $04 constant TIM8_BK2CMP4E                  \ [0x04] tim_brk2_cmp4 enable
    $05 constant TIM8_BK2CMP5E                  \ [0x05] tim_brk2_cmp5 enable
    $06 constant TIM8_BK2CMP6E                  \ [0x06] tim_brk2_cmp6 enable
    $07 constant TIM8_BK2CMP7E                  \ [0x07] tim_brk2_cmp7 enable
    $08 constant TIM8_BK2CMP8E                  \ [0x08] tim_brk2_cmp8 enable
    $09 constant TIM8_BK2INP                    \ [0x09] TIMx_BKIN2 input polarity
    $0a constant TIM8_BK2CMP1P                  \ [0x0a] tim_brk2_cmp1 input polarity
    $0b constant TIM8_BK2CMP2P                  \ [0x0b] tim_brk2_cmp2 input polarity
    $0c constant TIM8_BK2CMP3P                  \ [0x0c] tim_brk2_cmp3 input polarity
    $0d constant TIM8_BK2CMP4P                  \ [0x0d] tim_brk2_cmp4 input polarity
    $10 constant TIM8_OCRSEL                    \ [0x10 : 3] ocref_clr source selection
  [then]


  [ifdef] TIM8_TIM8_DCR_DEF
    \
    \ @brief TIM8 DMA control register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DBA                       \ [0x00 : 5] DMA base address
    $08 constant TIM8_DBL                       \ [0x08 : 5] DMA burst length
    $10 constant TIM8_DBSS                      \ [0x10 : 4] DMA burst source selection
  [then]


  [ifdef] TIM8_TIM8_DMAR_DEF
    \
    \ @brief TIM8 DMA address for full transfer
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DMAB                      \ [0x00 : 32] DMA register for burst accesses
  [then]

  \
  \ @brief TIM8 address block description
  \
  $00 constant TIM8_TIM8_CR1            \ TIM8 control register 1
  $04 constant TIM8_TIM8_CR2            \ TIM8 control register 2
  $08 constant TIM8_TIM8_SMCR           \ TIM8 slave mode control register
  $0C constant TIM8_TIM8_DIER           \ TIM8 DMA/interrupt enable register
  $10 constant TIM8_TIM8_SR             \ TIM8 status register
  $14 constant TIM8_TIM8_EGR            \ TIM8 event generation register
  $18 constant TIM8_TIM8_CCMR1          \ TIM8 capture/compare mode register 1
  $18 constant TIM8_TIM8_CCMR1_ALTERNATE1    \ TIM8 capture/compare mode register 1
  $1C constant TIM8_TIM8_CCMR2          \ TIM8 capture/compare mode register 2
  $1C constant TIM8_TIM8_CCMR2_ALTERNATE1    \ TIM8 capture/compare mode register 2
  $20 constant TIM8_TIM8_CCER           \ TIM8 capture/compare enable register
  $24 constant TIM8_TIM8_CNT            \ TIM8 counter
  $28 constant TIM8_TIM8_PSC            \ TIM8 prescaler
  $2C constant TIM8_TIM8_ARR            \ TIM8 auto-reload register
  $30 constant TIM8_TIM8_RCR            \ TIM8 repetition counter register
  $34 constant TIM8_TIM8_CCR1           \ TIM8 capture/compare register 1
  $38 constant TIM8_TIM8_CCR2           \ TIM8 capture/compare register 2
  $3C constant TIM8_TIM8_CCR3           \ TIM8 capture/compare register 3
  $40 constant TIM8_TIM8_CCR4           \ TIM8 capture/compare register 4
  $44 constant TIM8_TIM8_BDTR           \ TIM8 break and dead-time register
  $48 constant TIM8_TIM8_CCR5           \ TIM8 capture/compare register 5
  $4C constant TIM8_TIM8_CCR6           \ TIM8 capture/compare register 6
  $50 constant TIM8_TIM8_CCMR3          \ TIM8 capture/compare mode register 3
  $54 constant TIM8_TIM8_DTR2           \ TIM8 timer deadtime register 2
  $58 constant TIM8_TIM8_ECR            \ TIM8 timer encoder control register
  $5C constant TIM8_TIM8_TISEL          \ TIM8 timer input selection register
  $60 constant TIM8_TIM8_AF1            \ TIM8 alternate function option register 1
  $64 constant TIM8_TIM8_AF2            \ TIM8 alternate function register 2
  $3DC constant TIM8_TIM8_DCR           \ TIM8 DMA control register
  $3E0 constant TIM8_TIM8_DMAR          \ TIM8 DMA address for full transfer

: TIM8_DEF ; [then]
