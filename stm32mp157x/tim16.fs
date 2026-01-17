\
\ @file tim16.fs
\ @brief TIM16
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM16_DEF

  [ifdef] TIM16_TIMx_CR1_DEF
    \
    \ @brief TIM16/TIM17 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CEN                      \ [0x00] CEN
    $01 constant TIM16_UDIS                     \ [0x01] UDIS
    $02 constant TIM16_URS                      \ [0x02] URS
    $03 constant TIM16_OPM                      \ [0x03] OPM
    $07 constant TIM16_ARPE                     \ [0x07] ARPE
    $08 constant TIM16_CKD                      \ [0x08 : 2] CKD
    $0b constant TIM16_UIFREMAP                 \ [0x0b] UIFREMAP
  [then]


  [ifdef] TIM16_TIMx_CR2_DEF
    \
    \ @brief TIM16/TIM17 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CCPC                     \ [0x00] CCPC
    $02 constant TIM16_CCUS                     \ [0x02] CCUS
    $03 constant TIM16_CCDS                     \ [0x03] CCDS
    $08 constant TIM16_OIS1                     \ [0x08] OIS1
    $09 constant TIM16_OIS1N                    \ [0x09] OIS1N
  [then]


  [ifdef] TIM16_TIMx_DIER_DEF
    \
    \ @brief TIM16/TIM17 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_UIE                      \ [0x00] UIE
    $01 constant TIM16_CC1IE                    \ [0x01] CC1IE
    $05 constant TIM16_COMIE                    \ [0x05] COMIE
    $07 constant TIM16_BIE                      \ [0x07] BIE
    $08 constant TIM16_UDE                      \ [0x08] UDE
    $09 constant TIM16_CC1DE                    \ [0x09] CC1DE
    $0d constant TIM16_COMDE                    \ [0x0d] COMDE
  [then]


  [ifdef] TIM16_TIMx_SR_DEF
    \
    \ @brief TIM16/TIM17 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_UIF                      \ [0x00] UIF
    $01 constant TIM16_CC1IF                    \ [0x01] CC1IF
    $05 constant TIM16_COMIF                    \ [0x05] COMIF
    $07 constant TIM16_BIF                      \ [0x07] BIF
    $09 constant TIM16_CC1OF                    \ [0x09] CC1OF
  [then]


  [ifdef] TIM16_TIMx_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_UG                       \ [0x00] Update generation
  [then]


  [ifdef] TIM16_TIMx_CCER_DEF
    \
    \ @brief TIM16/TIM17 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CC1E                     \ [0x00] CC1E
    $01 constant TIM16_CC1P                     \ [0x01] CC1P
    $02 constant TIM16_CC1NE                    \ [0x02] CC1NE
    $03 constant TIM16_CC1NP                    \ [0x03] CC1NP
  [then]


  [ifdef] TIM16_TIMx_CNT_DEF
    \
    \ @brief TIM16/TIM17 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CNT                      \ [0x00 : 16] CNT
    $1f constant TIM16_UIFCPY                   \ [0x1f] UIFCPY
  [then]


  [ifdef] TIM16_TIMx_PSC_DEF
    \
    \ @brief TIM16/TIM17 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_PSC                      \ [0x00 : 16] PSC
  [then]


  [ifdef] TIM16_TIMx_ARR_DEF
    \
    \ @brief TIM16/TIM17 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM16_ARR                      \ [0x00 : 16] ARR
  [then]


  [ifdef] TIM16_TIMx_RCR_DEF
    \
    \ @brief TIM16/TIM17 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_REP                      \ [0x00 : 8] REP
  [then]


  [ifdef] TIM16_TIMx_CCR1_DEF
    \
    \ @brief TIM16/TIM17 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CCR1                     \ [0x00 : 16] CCR1
  [then]


  [ifdef] TIM16_TIMx_BDTR_DEF
    \
    \ @brief As the BKBID, BKDSRM, BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] bits may be write-locked depending on the LOCK configuration, it may be necessary to configure all of them during the first write access to the TIMx_BDTR register.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_DTG                      \ [0x00 : 8] DTG
    $08 constant TIM16_LOCK                     \ [0x08 : 2] LOCK
    $0a constant TIM16_OSSI                     \ [0x0a] OSSI
    $0b constant TIM16_OSSR                     \ [0x0b] OSSR
    $0c constant TIM16_BKE                      \ [0x0c] BKE
    $0d constant TIM16_BKP                      \ [0x0d] BKP
    $0e constant TIM16_AOE                      \ [0x0e] AOE
    $0f constant TIM16_MOE                      \ [0x0f] MOE
    $10 constant TIM16_BKF                      \ [0x10 : 4] BKF
    $1a constant TIM16_BKDSRM                   \ [0x1a] BKDSRM
    $1c constant TIM16_BKBID                    \ [0x1c] BKBID
  [then]


  [ifdef] TIM16_TIMx_DCR_DEF
    \
    \ @brief TIM16/TIM17 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_DBA                      \ [0x00 : 5] DBA
    $08 constant TIM16_DBL                      \ [0x08 : 5] DBL
  [then]


  [ifdef] TIM16_TIMx_DMAR_DEF
    \
    \ @brief TIM16/TIM17 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_DMAB                     \ [0x00 : 16] DMAB
  [then]


  [ifdef] TIM16_TIMx_AF1_DEF
    \
    \ @brief TIM17 alternate function register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM16_BKINE                    \ [0x00] BKINE
    $08 constant TIM16_BKDF1BK2E                \ [0x08] BKDF1BK2E
    $09 constant TIM16_BKINP                    \ [0x09] BKINP
  [then]


  [ifdef] TIM16_TIMx_TISEL_DEF
    \
    \ @brief TIM17 input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_TI1SEL                   \ [0x00 : 4] TI1SEL
  [then]

  \
  \ @brief TIM16
  \
  $00 constant TIM16_TIMX_CR1           \ TIM16/TIM17 control register 1
  $04 constant TIM16_TIMX_CR2           \ TIM16/TIM17 control register 2
  $0C constant TIM16_TIMX_DIER          \ TIM16/TIM17 DMA/interrupt enable register
  $10 constant TIM16_TIMX_SR            \ TIM16/TIM17 status register
  $14 constant TIM16_TIMX_EGR           \ event generation register
  $20 constant TIM16_TIMX_CCER          \ TIM16/TIM17 capture/compare enable register
  $24 constant TIM16_TIMX_CNT           \ TIM16/TIM17 counter
  $28 constant TIM16_TIMX_PSC           \ TIM16/TIM17 prescaler
  $2C constant TIM16_TIMX_ARR           \ TIM16/TIM17 auto-reload register
  $30 constant TIM16_TIMX_RCR           \ TIM16/TIM17 repetition counter register
  $34 constant TIM16_TIMX_CCR1          \ TIM16/TIM17 capture/compare register 1
  $44 constant TIM16_TIMX_BDTR          \ As the BKBID, BKDSRM, BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] bits may be write-locked depending on the LOCK configuration, it may be necessary to configure all of them during the first write access to the TIMx_BDTR register.
  $48 constant TIM16_TIMX_DCR           \ TIM16/TIM17 DMA control register
  $4C constant TIM16_TIMX_DMAR          \ TIM16/TIM17 DMA address for full transfer
  $60 constant TIM16_TIMX_AF1           \ TIM17 alternate function register 1
  $68 constant TIM16_TIMX_TISEL         \ TIM17 input selection register

: TIM16_DEF ; [then]
