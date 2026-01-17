\
\ @file tim2.fs
\ @brief TIM2
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM2_DEF

  [ifdef] TIM2_TIM2_CR1_DEF
    \
    \ @brief TIM2 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CEN                       \ [0x00] CEN
    $01 constant TIM2_UDIS                      \ [0x01] UDIS
    $02 constant TIM2_URS                       \ [0x02] URS
    $03 constant TIM2_OPM                       \ [0x03] OPM
    $04 constant TIM2_DIR                       \ [0x04] DIR
    $05 constant TIM2_CMS                       \ [0x05 : 2] CMS
    $07 constant TIM2_ARPE                      \ [0x07] ARPE
    $08 constant TIM2_CKD                       \ [0x08 : 2] CKD
    $0b constant TIM2_UIFREMAP                  \ [0x0b] UIFREMAP
  [then]


  [ifdef] TIM2_TIM2_CR2_DEF
    \
    \ @brief TIM2 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCPC                      \ [0x00] CCPC
    $02 constant TIM2_CCUS                      \ [0x02] CCUS
    $03 constant TIM2_CCDS                      \ [0x03] CCDS
    $04 constant TIM2_MMS                       \ [0x04 : 3] MMS
    $07 constant TIM2_TI1S                      \ [0x07] TI1S
    $08 constant TIM2_OIS1                      \ [0x08] OIS1
    $09 constant TIM2_OIS1N                     \ [0x09] OIS1N
    $0a constant TIM2_OIS2                      \ [0x0a] OIS2
    $0b constant TIM2_OIS2N                     \ [0x0b] OIS2N
    $0c constant TIM2_OIS3                      \ [0x0c] OIS3
    $0d constant TIM2_OIS3N                     \ [0x0d] OIS3N
    $0e constant TIM2_OIS4                      \ [0x0e] OIS4
    $10 constant TIM2_OIS5                      \ [0x10] OIS5
    $12 constant TIM2_OIS6                      \ [0x12] OIS6
    $14 constant TIM2_MMS2                      \ [0x14 : 4] MMS2
  [then]


  [ifdef] TIM2_TIM2_SMCR_DEF
    \
    \ @brief TIM2 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_SMS                       \ [0x00 : 3] SMS
    $04 constant TIM2_TS                        \ [0x04 : 3] TS
    $07 constant TIM2_MSM                       \ [0x07] MSM
    $08 constant TIM2_ETF                       \ [0x08 : 4] ETF
    $0c constant TIM2_ETPS                      \ [0x0c : 2] ETPS
    $0e constant TIM2_ECE                       \ [0x0e] ECE
    $0f constant TIM2_ETP                       \ [0x0f] ETP
    $10 constant TIM2_SMS3                      \ [0x10] SMS3
    $14 constant TIM2_TS3                       \ [0x14] TS3
    $15 constant TIM2_TS4                       \ [0x15] TS4
  [then]


  [ifdef] TIM2_TIM2_DIER_DEF
    \
    \ @brief TIM2 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_UIE                       \ [0x00] UIE
    $01 constant TIM2_CC1IE                     \ [0x01] CC1IE
    $02 constant TIM2_CC2IE                     \ [0x02] CC2IE
    $03 constant TIM2_CC3IE                     \ [0x03] CC3IE
    $04 constant TIM2_CC4IE                     \ [0x04] CC4IE
    $05 constant TIM2_COMIE                     \ [0x05] COMIE
    $06 constant TIM2_TIE                       \ [0x06] TIE
    $07 constant TIM2_BIE                       \ [0x07] BIE
    $08 constant TIM2_UDE                       \ [0x08] UDE
    $09 constant TIM2_CC1DE                     \ [0x09] CC1DE
    $0a constant TIM2_CC2DE                     \ [0x0a] CC2DE
    $0b constant TIM2_CC3DE                     \ [0x0b] CC3DE
    $0c constant TIM2_CC4DE                     \ [0x0c] CC4DE
    $0d constant TIM2_COMDE                     \ [0x0d] COMDE
    $0e constant TIM2_TDE                       \ [0x0e] TDE
  [then]


  [ifdef] TIM2_TIM2_SR_DEF
    \
    \ @brief TIM2 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_UIF                       \ [0x00] UIF
    $01 constant TIM2_CC1IF                     \ [0x01] CC1IF
    $02 constant TIM2_CC2IF                     \ [0x02] CC2IF
    $03 constant TIM2_CC3IF                     \ [0x03] CC3IF
    $04 constant TIM2_CC4IF                     \ [0x04] CC4IF
    $05 constant TIM2_COMIF                     \ [0x05] COMIF
    $06 constant TIM2_TIF                       \ [0x06] TIF
    $07 constant TIM2_BIF                       \ [0x07] BIF
    $08 constant TIM2_B2IF                      \ [0x08] B2IF
    $09 constant TIM2_CC1OF                     \ [0x09] CC1OF
    $0a constant TIM2_CC2OF                     \ [0x0a] CC2OF
    $0b constant TIM2_CC3OF                     \ [0x0b] CC3OF
    $0c constant TIM2_CC4OF                     \ [0x0c] CC4OF
    $0d constant TIM2_SBIF                      \ [0x0d] SBIF
    $10 constant TIM2_CC5IF                     \ [0x10] CC5IF
    $11 constant TIM2_CC6IF                     \ [0x11] CC6IF
  [then]


  [ifdef] TIM2_TIM2_EGR_DEF
    \
    \ @brief TIM2 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_UG                        \ [0x00] UG
    $01 constant TIM2_CC1G                      \ [0x01] CC1G
    $02 constant TIM2_CC2G                      \ [0x02] CC2G
    $03 constant TIM2_CC3G                      \ [0x03] CC3G
    $04 constant TIM2_CC4G                      \ [0x04] CC4G
    $05 constant TIM2_COMG                      \ [0x05] COMG
    $06 constant TIM2_TG                        \ [0x06] TG
    $07 constant TIM2_BG                        \ [0x07] BG
    $08 constant TIM2_B2G                       \ [0x08] B2G
  [then]


  [ifdef] TIM2_TIM2_CCMR1ALTERNATE2_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC1S                      \ [0x00 : 2] CC1S
    $02 constant TIM2_IC1PSC                    \ [0x02 : 2] IC1PSC
    $04 constant TIM2_IC1F                      \ [0x04 : 4] IC1F
    $08 constant TIM2_CC2S                      \ [0x08 : 2] CC2S
    $0a constant TIM2_IC2PSC                    \ [0x0a : 2] IC2PSC
    $0c constant TIM2_IC2F                      \ [0x0c : 4] IC2F
  [then]


  [ifdef] TIM2_TIM2_CCMR2ALTERNATE18_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC3S                      \ [0x00 : 2] CC3S
    $02 constant TIM2_IC3PSC                    \ [0x02 : 2] IC3PSC
    $04 constant TIM2_IC3F                      \ [0x04 : 4] IC3F
    $08 constant TIM2_CC4S                      \ [0x08 : 2] CC4S
    $0a constant TIM2_IC4PSC                    \ [0x0a : 2] IC4PSC
    $0c constant TIM2_IC4F                      \ [0x0c : 4] IC4F
  [then]


  [ifdef] TIM2_TIM2_CCER_DEF
    \
    \ @brief TIM2 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC1E                      \ [0x00] CC1E
    $01 constant TIM2_CC1P                      \ [0x01] CC1P
    $02 constant TIM2_CC1NE                     \ [0x02] CC1NE
    $03 constant TIM2_CC1NP                     \ [0x03] CC1NP
    $04 constant TIM2_CC2E                      \ [0x04] CC2E
    $05 constant TIM2_CC2P                      \ [0x05] CC2P
    $06 constant TIM2_CC2NE                     \ [0x06] CC2NE
    $07 constant TIM2_CC2NP                     \ [0x07] CC2NP
    $08 constant TIM2_CC3E                      \ [0x08] CC3E
    $09 constant TIM2_CC3P                      \ [0x09] CC3P
    $0a constant TIM2_CC3NE                     \ [0x0a] CC3NE
    $0b constant TIM2_CC3NP                     \ [0x0b] CC3NP
    $0c constant TIM2_CC4E                      \ [0x0c] CC4E
    $0d constant TIM2_CC4P                      \ [0x0d] CC4P
    $0f constant TIM2_CC4NP                     \ [0x0f] CC4NP
    $10 constant TIM2_CC5E                      \ [0x10] CC5E
    $11 constant TIM2_CC5P                      \ [0x11] CC5P
    $14 constant TIM2_CC6E                      \ [0x14] CC6E
    $15 constant TIM2_CC6P                      \ [0x15] CC6P
  [then]


  [ifdef] TIM2_TIM2_CNT_DEF
    \
    \ @brief TIM2 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CNT                       \ [0x00 : 16] CNT
    $1f constant TIM2_UIFCPY                    \ [0x1f] UIFCPY
  [then]


  [ifdef] TIM2_TIM2_PSC_DEF
    \
    \ @brief TIM2 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_PSC                       \ [0x00 : 16] PSC
  [then]


  [ifdef] TIM2_TIM2_ARR_DEF
    \
    \ @brief TIM2 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM2_ARR                       \ [0x00 : 16] ARR
  [then]


  [ifdef] TIM2_TIM2_RCR_DEF
    \
    \ @brief TIM2 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_REP                       \ [0x00 : 16] REP
  [then]


  [ifdef] TIM2_TIM2_CCR1_DEF
    \
    \ @brief TIM2 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR1                      \ [0x00 : 16] CCR1
  [then]


  [ifdef] TIM2_TIM2_CCR2_DEF
    \
    \ @brief TIM2 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR2                      \ [0x00 : 16] CCR2
  [then]


  [ifdef] TIM2_TIM2_CCR3_DEF
    \
    \ @brief TIM2 capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR3                      \ [0x00 : 16] CCR3
  [then]


  [ifdef] TIM2_TIM2_CCR4_DEF
    \
    \ @brief TIM2 capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR4                      \ [0x00 : 16] CCR4
  [then]


  [ifdef] TIM2_TIM2_BDTR_DEF
    \
    \ @brief As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_DTG                       \ [0x00 : 8] DTG
    $08 constant TIM2_LOCK                      \ [0x08 : 2] LOCK
    $0a constant TIM2_OSSI                      \ [0x0a] OSSI
    $0b constant TIM2_OSSR                      \ [0x0b] OSSR
    $0c constant TIM2_BKE                       \ [0x0c] BKE
    $0d constant TIM2_BKP                       \ [0x0d] BKP
    $0e constant TIM2_AOE                       \ [0x0e] AOE
    $0f constant TIM2_MOE                       \ [0x0f] MOE
    $10 constant TIM2_BKF                       \ [0x10 : 4] BKF
    $14 constant TIM2_BK2F                      \ [0x14 : 4] BK2F
    $18 constant TIM2_BK2E                      \ [0x18] BK2E
    $19 constant TIM2_BK2P                      \ [0x19] BK2P
    $1a constant TIM2_BKDSRM                    \ [0x1a] BKDSRM
    $1b constant TIM2_BK2DSRM                   \ [0x1b] BK2DSRM
    $1c constant TIM2_BKBID                     \ [0x1c] BKBID
    $1d constant TIM2_BK2BID                    \ [0x1d] BK2BID
  [then]


  [ifdef] TIM2_TIM2_DCR_DEF
    \
    \ @brief TIM2 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_DBA                       \ [0x00 : 5] DBA
    $08 constant TIM2_DBL                       \ [0x08 : 5] DBL
  [then]


  [ifdef] TIM2_TIM2_DMAR_DEF
    \
    \ @brief TIM2 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_DMAB                      \ [0x00 : 32] DMAB
  [then]


  [ifdef] TIM2_TIM2_CCMR3_DEF
    \
    \ @brief The channels 5 and 6 can only be configured in output. Output compare mode:
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant TIM2_OC5FE                     \ [0x02] OC5FE
    $03 constant TIM2_OC5PE                     \ [0x03] OC5PE
    $04 constant TIM2_OC5M                      \ [0x04 : 3] OC5M
    $07 constant TIM2_OC5CE                     \ [0x07] OC5CE
    $0a constant TIM2_OC6FE                     \ [0x0a] OC6FE
    $0b constant TIM2_OC6PE                     \ [0x0b] OC6PE
    $0c constant TIM2_OC6M                      \ [0x0c : 3] OC6M
    $0f constant TIM2_OC6CE                     \ [0x0f] OC6CE
    $10 constant TIM2_OC5M3                     \ [0x10] OC5M3
    $18 constant TIM2_OC6M3                     \ [0x18] OC6M3
  [then]


  [ifdef] TIM2_TIM2_CCR5_DEF
    \
    \ @brief TIM2 capture/compare register 5
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR5                      \ [0x00 : 16] CCR5
    $1d constant TIM2_GC5C1                     \ [0x1d] GC5C1
    $1e constant TIM2_GC5C2                     \ [0x1e] GC5C2
    $1f constant TIM2_GC5C3                     \ [0x1f] GC5C3
  [then]


  [ifdef] TIM2_TIM2_CCR6_DEF
    \
    \ @brief TIM2 capture/compare register 6
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR6                      \ [0x00 : 16] CCR6
  [then]

  \
  \ @brief TIM2
  \
  $00 constant TIM2_TIM2_CR1            \ TIM2 control register 1
  $04 constant TIM2_TIM2_CR2            \ TIM2 control register 2
  $08 constant TIM2_TIM2_SMCR           \ TIM2 slave mode control register
  $0C constant TIM2_TIM2_DIER           \ TIM2 DMA/interrupt enable register
  $10 constant TIM2_TIM2_SR             \ TIM2 status register
  $14 constant TIM2_TIM2_EGR            \ TIM2 event generation register
  $18 constant TIM2_TIM2_CCMR1ALTERNATE2    \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $1C constant TIM2_TIM2_CCMR2ALTERNATE18    \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $20 constant TIM2_TIM2_CCER           \ TIM2 capture/compare enable register
  $24 constant TIM2_TIM2_CNT            \ TIM2 counter
  $28 constant TIM2_TIM2_PSC            \ TIM2 prescaler
  $2C constant TIM2_TIM2_ARR            \ TIM2 auto-reload register
  $30 constant TIM2_TIM2_RCR            \ TIM2 repetition counter register
  $34 constant TIM2_TIM2_CCR1           \ TIM2 capture/compare register 1
  $38 constant TIM2_TIM2_CCR2           \ TIM2 capture/compare register 2
  $3C constant TIM2_TIM2_CCR3           \ TIM2 capture/compare register 3
  $40 constant TIM2_TIM2_CCR4           \ TIM2 capture/compare register 4
  $44 constant TIM2_TIM2_BDTR           \ As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
  $48 constant TIM2_TIM2_DCR            \ TIM2 DMA control register
  $4C constant TIM2_TIM2_DMAR           \ TIM2 DMA address for full transfer
  $54 constant TIM2_TIM2_CCMR3          \ The channels 5 and 6 can only be configured in output. Output compare mode:
  $58 constant TIM2_TIM2_CCR5           \ TIM2 capture/compare register 5
  $5C constant TIM2_TIM2_CCR6           \ TIM2 capture/compare register 6

: TIM2_DEF ; [then]
