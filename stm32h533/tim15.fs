\
\ @file tim15.fs
\ @brief TIM15 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM15_DEF

  [ifdef] TIM15_TIM15_CR1_DEF
    \
    \ @brief TIM15 control register 1
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
    $0c constant TIM15_DITHEN                   \ [0x0c] Dithering enable
  [then]


  [ifdef] TIM15_TIM15_CR2_DEF
    \
    \ @brief TIM15 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCPC                     \ [0x00] Capture/compare preloaded control
    $02 constant TIM15_CCUS                     \ [0x02] Capture/compare control update selection
    $03 constant TIM15_CCDS                     \ [0x03] Capture/compare DMA selection
    $04 constant TIM15_MMS                      \ [0x04 : 3] Master mode selection
    $07 constant TIM15_TI1S                     \ [0x07] tim_ti1 selection
    $08 constant TIM15_OIS1                     \ [0x08] Output Idle state 1 (tim_oc1 output)
    $09 constant TIM15_OIS1N                    \ [0x09] Output Idle state 1 (tim_oc1n output)
    $0a constant TIM15_OIS2                     \ [0x0a] Output idle state 2 (tim_oc2 output)
  [then]


  [ifdef] TIM15_TIM15_SMCR_DEF
    \
    \ @brief TIM15 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_SMS                      \ [0x00 : 3] SMS[2:0]: Slave mode selection
    $04 constant TIM15_TS                       \ [0x04 : 3] TS[2:0]: Trigger selection
    $07 constant TIM15_MSM                      \ [0x07] Master/slave mode
    $10 constant TIM15_SMS_1                    \ [0x10] Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $14 constant TIM15_TS_1                     \ [0x14 : 2] Trigger selection This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for product specific implementation details. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
    $18 constant TIM15_SMSPE                    \ [0x18] SMS preload enable
  [then]


  [ifdef] TIM15_TIM15_DIER_DEF
    \
    \ @brief TIM15 DMA/interrupt enable register
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
    $0d constant TIM15_COMDE                    \ [0x0d] COM DMA request enable
    $0e constant TIM15_TDE                      \ [0x0e] Trigger DMA request enable
  [then]


  [ifdef] TIM15_TIM15_SR_DEF
    \
    \ @brief TIM15 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM15_CC1IF                    \ [0x01] Capture/Compare 1 interrupt flag
    $02 constant TIM15_CC2IF                    \ [0x02] Capture/Compare 2 interrupt flag
    $05 constant TIM15_COMIF                    \ [0x05] COM interrupt flag
    $06 constant TIM15_TIF                      \ [0x06] Trigger interrupt flag
    $07 constant TIM15_BIF                      \ [0x07] Break interrupt flag
    $09 constant TIM15_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag
    $0a constant TIM15_CC2OF                    \ [0x0a] Capture/Compare 2 overcapture flag
  [then]


  [ifdef] TIM15_TIM15_EGR_DEF
    \
    \ @brief TIM15 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UG                       \ [0x00] Update generation
    $01 constant TIM15_CC1G                     \ [0x01] Capture/Compare 1 generation
    $02 constant TIM15_CC2G                     \ [0x02] Capture/Compare 2 generation
    $05 constant TIM15_COMG                     \ [0x05] Capture/Compare control update generation
    $06 constant TIM15_TG                       \ [0x06] Trigger generation
    $07 constant TIM15_BG                       \ [0x07] Break generation
  [then]


  [ifdef] TIM15_TIM15_CCMR1_DEF
    \
    \ @brief TIM15 capture/compare mode register 1
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


  [ifdef] TIM15_TIM15_CCMR1_ALTERNATE1_DEF
    \
    \ @brief TIM15 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM15_OC1FE                    \ [0x02] Output Compare 1 fast enable
    $03 constant TIM15_OC1PE                    \ [0x03] Output Compare 1 preload enable
    $04 constant TIM15_OC1M                     \ [0x04 : 3] OC1M[2:0]: Output compare 1 mode
    $07 constant TIM15_OC1CE                    \ [0x07] Output compare 1 clear enable
    $08 constant TIM15_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM15_OC2FE                    \ [0x0a] Output compare 2 fast enable
    $0b constant TIM15_OC2PE                    \ [0x0b] Output compare 2 preload enable
    $0c constant TIM15_OC2M                     \ [0x0c : 3] OC2M[2:0]: Output compare 2 mode
    $0f constant TIM15_OC2CE                    \ [0x0f] Output compare 2 clear enable
    $10 constant TIM15_OC1M_1                   \ [0x10] OC1M[3]
    $18 constant TIM15_OC2M_1                   \ [0x18] OC2M[3]
  [then]


  [ifdef] TIM15_TIM15_CCER_DEF
    \
    \ @brief TIM15 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1E                     \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM15_CC1P                     \ [0x01] Capture/Compare 1 output polarity
    $02 constant TIM15_CC1NE                    \ [0x02] Capture/Compare 1 complementary output enable
    $03 constant TIM15_CC1NP                    \ [0x03] Capture/Compare 1 complementary output polarity
    $04 constant TIM15_CC2E                     \ [0x04] Capture/Compare 2 output enable
    $05 constant TIM15_CC2P                     \ [0x05] Capture/Compare 2 output polarity
    $07 constant TIM15_CC2NP                    \ [0x07] Capture/Compare 2 complementary output polarity
  [then]


  [ifdef] TIM15_TIM15_CNT_DEF
    \
    \ @brief TIM15 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CNT                      \ [0x00 : 16] Counter value
    $1f constant TIM15_UIFCPY                   \ [0x1f] UIF Copy
  [then]


  [ifdef] TIM15_TIM15_PSC_DEF
    \
    \ @brief TIM15 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM15_TIM15_ARR_DEF
    \
    \ @brief TIM15 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM15_ARR                      \ [0x00 : 20] Auto-reload value
  [then]


  [ifdef] TIM15_TIM15_RCR_DEF
    \
    \ @brief TIM15 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_REP                      \ [0x00 : 8] Repetition counter reload value
  [then]


  [ifdef] TIM15_TIM15_CCR1_DEF
    \
    \ @brief TIM15 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR1                     \ [0x00 : 20] Capture/compare 1 value
  [then]


  [ifdef] TIM15_TIM15_CCR2_DEF
    \
    \ @brief TIM15 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR2                     \ [0x00 : 20] Capture/compare 2 value
  [then]


  [ifdef] TIM15_TIM15_BDTR_DEF
    \
    \ @brief TIM15 break and dead-time register
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
    $10 constant TIM15_BKF                      \ [0x10 : 4] Break filter
    $1a constant TIM15_BKDSRM                   \ [0x1a] Break disarm
    $1c constant TIM15_BKBID                    \ [0x1c] Break bidirectional
  [then]


  [ifdef] TIM15_TIM15_DTR2_DEF
    \
    \ @brief TIM15 timer deadtime register 2
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DTGF                     \ [0x00 : 8] Dead-time falling edge generator setup
    $10 constant TIM15_DTAE                     \ [0x10] Deadtime asymmetric enable
    $11 constant TIM15_DTPE                     \ [0x11] Deadtime preload enable
  [then]


  [ifdef] TIM15_TIM15_TISEL_DEF
    \
    \ @brief TIM15 input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_TI1SEL                   \ [0x00 : 4] selects tim_ti1_in[15:0] input
    $08 constant TIM15_TI2SEL                   \ [0x08 : 4] selects tim_ti2_in[15:0] input
  [then]


  [ifdef] TIM15_TIM15_AF1_DEF
    \
    \ @brief TIM15 alternate function register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM15_BKINE                    \ [0x00] TIMx_BKIN input enable
    $01 constant TIM15_BKCMP1E                  \ [0x01] tim_brk_cmp1 enable
    $02 constant TIM15_BKCMP2E                  \ [0x02] tim_brk_cmp2 enable
    $03 constant TIM15_BKCMP3E                  \ [0x03] tim_brk_cmp3 enable
    $04 constant TIM15_BKCMP4E                  \ [0x04] tim_brk_cmp4 enable
    $05 constant TIM15_BKCMP5E                  \ [0x05] tim_brk_cmp5 enable
    $06 constant TIM15_BKCMP6E                  \ [0x06] tim_brk_cmp6 enable
    $07 constant TIM15_BKCMP7E                  \ [0x07] tim_brk_cmp7 enable
    $08 constant TIM15_BKCMP8E                  \ [0x08] tim_brk_cmp8 enable
    $09 constant TIM15_BKINP                    \ [0x09] TIMx_BKIN input polarity
    $0a constant TIM15_BKCMP1P                  \ [0x0a] tim_brk_cmp1 input polarity
    $0b constant TIM15_BKCMP2P                  \ [0x0b] tim_brk_cmp2 input polarity
    $0c constant TIM15_BKCMP3P                  \ [0x0c] tim_brk_cmp3 input polarity
    $0d constant TIM15_BKCMP4P                  \ [0x0d] tim_brk_cmp4 input polarity
  [then]


  [ifdef] TIM15_TIM15_AF2_DEF
    \
    \ @brief TIM15 alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $10 constant TIM15_OCRSEL                   \ [0x10 : 3] ocref_clr source selection
  [then]


  [ifdef] TIM15_TIM15_DCR_DEF
    \
    \ @brief TIM15 DMA control register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DBA                      \ [0x00 : 5] DMA base address
    $08 constant TIM15_DBL                      \ [0x08 : 5] DMA burst length
    $10 constant TIM15_DBSS                     \ [0x10 : 4] DMA burst source selection
  [then]


  [ifdef] TIM15_TIM15_DMAR_DEF
    \
    \ @brief TIM15 DMA address for full transfer
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DMAB                     \ [0x00 : 32] DMA register for burst accesses
  [then]

  \
  \ @brief TIM15 address block description
  \
  $00 constant TIM15_TIM15_CR1          \ TIM15 control register 1
  $04 constant TIM15_TIM15_CR2          \ TIM15 control register 2
  $08 constant TIM15_TIM15_SMCR         \ TIM15 slave mode control register
  $0C constant TIM15_TIM15_DIER         \ TIM15 DMA/interrupt enable register
  $10 constant TIM15_TIM15_SR           \ TIM15 status register
  $14 constant TIM15_TIM15_EGR          \ TIM15 event generation register
  $18 constant TIM15_TIM15_CCMR1        \ TIM15 capture/compare mode register 1
  $18 constant TIM15_TIM15_CCMR1_ALTERNATE1    \ TIM15 capture/compare mode register 1
  $20 constant TIM15_TIM15_CCER         \ TIM15 capture/compare enable register
  $24 constant TIM15_TIM15_CNT          \ TIM15 counter
  $28 constant TIM15_TIM15_PSC          \ TIM15 prescaler
  $2C constant TIM15_TIM15_ARR          \ TIM15 auto-reload register
  $30 constant TIM15_TIM15_RCR          \ TIM15 repetition counter register
  $34 constant TIM15_TIM15_CCR1         \ TIM15 capture/compare register 1
  $38 constant TIM15_TIM15_CCR2         \ TIM15 capture/compare register 2
  $44 constant TIM15_TIM15_BDTR         \ TIM15 break and dead-time register
  $54 constant TIM15_TIM15_DTR2         \ TIM15 timer deadtime register 2
  $5C constant TIM15_TIM15_TISEL        \ TIM15 input selection register
  $60 constant TIM15_TIM15_AF1          \ TIM15 alternate function register 1
  $64 constant TIM15_TIM15_AF2          \ TIM15 alternate function register 2
  $3DC constant TIM15_TIM15_DCR         \ TIM15 DMA control register
  $3E0 constant TIM15_TIM15_DMAR        \ TIM15 DMA address for full transfer

: TIM15_DEF ; [then]
