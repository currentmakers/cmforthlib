\
\ @file tim15.fs
\ @brief TIM15
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
    $00 constant TIM15_CEN                      \ [0x00] CEN
    $01 constant TIM15_UDIS                     \ [0x01] UDIS
    $02 constant TIM15_URS                      \ [0x02] URS
    $03 constant TIM15_OPM                      \ [0x03] OPM
    $07 constant TIM15_ARPE                     \ [0x07] ARPE
    $08 constant TIM15_CKD                      \ [0x08 : 2] CKD
    $0b constant TIM15_UIFREMAP                 \ [0x0b] UIFREMAP
  [then]


  [ifdef] TIM15_TIM15_CR2_DEF
    \
    \ @brief TIM15 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCPC                     \ [0x00] CCPC
    $02 constant TIM15_CCUS                     \ [0x02] CCUS
    $03 constant TIM15_CCDS                     \ [0x03] CCDS
    $04 constant TIM15_MMS                      \ [0x04 : 3] MMS
    $07 constant TIM15_TI1S                     \ [0x07] TI1S
    $08 constant TIM15_OIS1                     \ [0x08] OIS1
    $09 constant TIM15_OIS1N                    \ [0x09] OIS1N
    $0a constant TIM15_OIS2                     \ [0x0a] OIS2
  [then]


  [ifdef] TIM15_TIMx_SMCR_DEF
    \
    \ @brief slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_SMS                      \ [0x00 : 3] Slave mode selection
    $04 constant TIM15_TS                       \ [0x04 : 3] Trigger selection
    $07 constant TIM15_MSM                      \ [0x07] Master/Slave mode
    $10 constant TIM15_SMS_3                    \ [0x10] Slave mode selection - bit 3
    $14 constant TIM15_TS_4_3                   \ [0x14 : 2] Trigger selection
  [then]


  [ifdef] TIM15_TIM15_DIER_DEF
    \
    \ @brief TIM15 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UIE                      \ [0x00] UIE
    $01 constant TIM15_CC1IE                    \ [0x01] CC1IE
    $02 constant TIM15_CC2IE                    \ [0x02] CC2IE
    $05 constant TIM15_COMIE                    \ [0x05] COMIE
    $06 constant TIM15_TIE                      \ [0x06] TIE
    $07 constant TIM15_BIE                      \ [0x07] BIE
    $08 constant TIM15_UDE                      \ [0x08] UDE
    $09 constant TIM15_CC1DE                    \ [0x09] CC1DE
    $0a constant TIM15_CC2DE                    \ [0x0a] CC2DE
    $0d constant TIM15_COMDE                    \ [0x0d] COMDE
    $0e constant TIM15_TDE                      \ [0x0e] TDE
  [then]


  [ifdef] TIM15_TIM15_SR_DEF
    \
    \ @brief TIM15 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UIF                      \ [0x00] UIF
    $01 constant TIM15_CC1IF                    \ [0x01] CC1IF
    $02 constant TIM15_CC2IF                    \ [0x02] CC2IF
    $05 constant TIM15_COMIF                    \ [0x05] COMIF
    $06 constant TIM15_TIF                      \ [0x06] TIF
    $07 constant TIM15_BIF                      \ [0x07] BIF
    $09 constant TIM15_CC1OF                    \ [0x09] CC1OF
    $0a constant TIM15_CC2OF                    \ [0x0a] CC2OF
  [then]


  [ifdef] TIM15_TIMx_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UG                       \ [0x00] Update generation
    $01 constant TIM15_CC1G                     \ [0x01] Capture/compare 1 generation
    $02 constant TIM15_CC2G                     \ [0x02] Capture/compare 2 generation
    $05 constant TIM15_COMG                     \ [0x05] COMG
    $06 constant TIM15_TG                       \ [0x06] Trigger generation
    $07 constant TIM15_BG                       \ [0x07] BG
  [then]


  [ifdef] TIM15_TIMx_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register 1 (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM15_OC1FE                    \ [0x02] Output compare 1 fast enable
    $03 constant TIM15_OC1PE                    \ [0x03] Output compare 1 preload enable
    $04 constant TIM15_OC1M                     \ [0x04 : 3] Output compare 1 mode
    $07 constant TIM15_OC1CE                    \ [0x07] Output compare 1 clear enable
    $08 constant TIM15_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM15_OC2FE                    \ [0x0a] Output compare 2 fast enable
    $0b constant TIM15_OC2PE                    \ [0x0b] Output compare 2 preload enable
    $0c constant TIM15_OC2M                     \ [0x0c : 3] Output compare 2 mode
    $0f constant TIM15_OC2CE                    \ [0x0f] Output compare 2 clear enable
    $10 constant TIM15_OC1M_3                   \ [0x10] Output Compare 1 mode - bit 3
    $18 constant TIM15_OC2M_3                   \ [0x18] Output Compare 2 mode - bit 3
  [then]


  [ifdef] TIM15_TIMx_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM15_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM15_IC1F                     \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM15_CC2S                     \ [0x08 : 2] Capture/compare 2 selection
    $0a constant TIM15_IC2PSC                   \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM15_IC2F                     \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM15_TIM15_CCER_DEF
    \
    \ @brief TIM15 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1E                     \ [0x00] CC1E
    $01 constant TIM15_CC1P                     \ [0x01] CC1P
    $02 constant TIM15_CC1NE                    \ [0x02] CC1NE
    $03 constant TIM15_CC1NP                    \ [0x03] CC1NP
    $04 constant TIM15_CC2E                     \ [0x04] CC2E
    $05 constant TIM15_CC2P                     \ [0x05] CC2P
    $07 constant TIM15_CC2NP                    \ [0x07] CC2NP
  [then]


  [ifdef] TIM15_TIM15_CNT_DEF
    \
    \ @brief TIM15 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CNT                      \ [0x00 : 16] CNT
    $1f constant TIM15_UIFCPY                   \ [0x1f] UIFCPY
  [then]


  [ifdef] TIM15_TIM15_PSC_DEF
    \
    \ @brief TIM15 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_PSC                      \ [0x00 : 16] PSC
  [then]


  [ifdef] TIM15_TIM15_ARR_DEF
    \
    \ @brief TIM15 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM15_ARR                      \ [0x00 : 16] ARR
  [then]


  [ifdef] TIM15_TIM15_RCR_DEF
    \
    \ @brief TIM15 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_REP                      \ [0x00 : 8] REP
  [then]


  [ifdef] TIM15_TIM15_CCR1_DEF
    \
    \ @brief TIM15 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR1                     \ [0x00 : 16] CCR1
  [then]


  [ifdef] TIM15_TIM15_CCR2_DEF
    \
    \ @brief TIM15 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR2                     \ [0x00 : 16] CCR2
  [then]


  [ifdef] TIM15_TIMx_BDTR_DEF
    \
    \ @brief As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DTG                      \ [0x00 : 8] DTG
    $08 constant TIM15_LOCK                     \ [0x08 : 2] LOCK
    $0a constant TIM15_OSSI                     \ [0x0a] OSSI
    $0b constant TIM15_OSSR                     \ [0x0b] OSSR
    $0c constant TIM15_BKE                      \ [0x0c] BKE
    $0d constant TIM15_BKP                      \ [0x0d] BKP
    $0e constant TIM15_AOE                      \ [0x0e] AOE
    $0f constant TIM15_MOE                      \ [0x0f] MOE
    $10 constant TIM15_BKF                      \ [0x10 : 4] BKF
    $1a constant TIM15_BKDSRM                   \ [0x1a] BKDSRM
    $1c constant TIM15_BKBID                    \ [0x1c] BKBID
  [then]


  [ifdef] TIM15_TIM15_DCR_DEF
    \
    \ @brief TIM15 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DBA                      \ [0x00 : 5] DBA
    $08 constant TIM15_DBL                      \ [0x08 : 5] DBL
  [then]


  [ifdef] TIM15_TIM15_DMAR_DEF
    \
    \ @brief TIM15 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DMAB                     \ [0x00 : 16] DMAB
  [then]


  [ifdef] TIM15_TIM15_AF1_DEF
    \
    \ @brief TIM15 alternate register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM15_BKINE                    \ [0x00] BKINE
    $08 constant TIM15_BKDF1BK0E                \ [0x08] BKDF1BK0E
    $09 constant TIM15_BKINP                    \ [0x09] BKINP
  [then]


  [ifdef] TIM15_TIM15_TISEL_DEF
    \
    \ @brief TIM15 input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_TI1SEL                   \ [0x00 : 4] TI1SEL
    $08 constant TIM15_TI2SEL                   \ [0x08 : 4] TI2SEL
  [then]

  \
  \ @brief TIM15
  \
  $00 constant TIM15_TIM15_CR1          \ TIM15 control register 1
  $04 constant TIM15_TIM15_CR2          \ TIM15 control register 2
  $08 constant TIM15_TIMX_SMCR          \ slave mode control register
  $0C constant TIM15_TIM15_DIER         \ TIM15 DMA/interrupt enable register
  $10 constant TIM15_TIM15_SR           \ TIM15 status register
  $14 constant TIM15_TIMX_EGR           \ event generation register
  $18 constant TIM15_TIMX_CCMR1_OUTPUT  \ capture/compare mode register 1 (output mode)
  $18 constant TIM15_TIMX_CCMR1_INPUT   \ capture/compare mode register 1 (input mode)
  $20 constant TIM15_TIM15_CCER         \ TIM15 capture/compare enable register
  $24 constant TIM15_TIM15_CNT          \ TIM15 counter
  $28 constant TIM15_TIM15_PSC          \ TIM15 prescaler
  $2C constant TIM15_TIM15_ARR          \ TIM15 auto-reload register
  $30 constant TIM15_TIM15_RCR          \ TIM15 repetition counter register
  $34 constant TIM15_TIM15_CCR1         \ TIM15 capture/compare register 1
  $38 constant TIM15_TIM15_CCR2         \ TIM15 capture/compare register 2
  $44 constant TIM15_TIMX_BDTR          \ As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
  $48 constant TIM15_TIM15_DCR          \ TIM15 DMA control register
  $4C constant TIM15_TIM15_DMAR         \ TIM15 DMA address for full transfer
  $60 constant TIM15_TIM15_AF1          \ TIM15 alternate register 1
  $68 constant TIM15_TIM15_TISEL        \ TIM15 input selection register

: TIM15_DEF ; [then]
