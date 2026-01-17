\
\ @file tim6.fs
\ @brief TIM6
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM6_DEF

  [ifdef] TIM6_TIM6_CR1_DEF
    \
    \ @brief TIM6 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CEN                       \ [0x00] CEN
    $01 constant TIM6_UDIS                      \ [0x01] UDIS
    $02 constant TIM6_URS                       \ [0x02] URS
    $03 constant TIM6_OPM                       \ [0x03] OPM
    $04 constant TIM6_DIR                       \ [0x04] DIR
    $05 constant TIM6_CMS                       \ [0x05 : 2] CMS
    $07 constant TIM6_ARPE                      \ [0x07] ARPE
    $08 constant TIM6_CKD                       \ [0x08 : 2] CKD
    $0b constant TIM6_UIFREMAP                  \ [0x0b] UIFREMAP
  [then]


  [ifdef] TIM6_TIM6_CR2_DEF
    \
    \ @brief TIM6 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CCPC                      \ [0x00] CCPC
    $02 constant TIM6_CCUS                      \ [0x02] CCUS
    $03 constant TIM6_CCDS                      \ [0x03] CCDS
    $04 constant TIM6_MMS                       \ [0x04 : 3] MMS
    $07 constant TIM6_TI1S                      \ [0x07] TI1S
    $08 constant TIM6_OIS1                      \ [0x08] OIS1
    $09 constant TIM6_OIS1N                     \ [0x09] OIS1N
    $0a constant TIM6_OIS2                      \ [0x0a] OIS2
    $0b constant TIM6_OIS2N                     \ [0x0b] OIS2N
    $0c constant TIM6_OIS3                      \ [0x0c] OIS3
    $0d constant TIM6_OIS3N                     \ [0x0d] OIS3N
    $0e constant TIM6_OIS4                      \ [0x0e] OIS4
    $10 constant TIM6_OIS5                      \ [0x10] OIS5
    $12 constant TIM6_OIS6                      \ [0x12] OIS6
    $14 constant TIM6_MMS2                      \ [0x14 : 4] MMS2
  [then]


  [ifdef] TIM6_TIM6_SMCR_DEF
    \
    \ @brief TIM6 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_SMS                       \ [0x00 : 3] SMS
    $04 constant TIM6_TS                        \ [0x04 : 3] TS
    $07 constant TIM6_MSM                       \ [0x07] MSM
    $08 constant TIM6_ETF                       \ [0x08 : 4] ETF
    $0c constant TIM6_ETPS                      \ [0x0c : 2] ETPS
    $0e constant TIM6_ECE                       \ [0x0e] ECE
    $0f constant TIM6_ETP                       \ [0x0f] ETP
    $10 constant TIM6_SMS3                      \ [0x10] SMS3
    $14 constant TIM6_TS3                       \ [0x14] TS3
    $15 constant TIM6_TS4                       \ [0x15] TS4
  [then]


  [ifdef] TIM6_TIM6_DIER_DEF
    \
    \ @brief TIM6 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UIE                       \ [0x00] UIE
    $01 constant TIM6_CC1IE                     \ [0x01] CC1IE
    $02 constant TIM6_CC2IE                     \ [0x02] CC2IE
    $03 constant TIM6_CC3IE                     \ [0x03] CC3IE
    $04 constant TIM6_CC4IE                     \ [0x04] CC4IE
    $05 constant TIM6_COMIE                     \ [0x05] COMIE
    $06 constant TIM6_TIE                       \ [0x06] TIE
    $07 constant TIM6_BIE                       \ [0x07] BIE
    $08 constant TIM6_UDE                       \ [0x08] UDE
    $09 constant TIM6_CC1DE                     \ [0x09] CC1DE
    $0a constant TIM6_CC2DE                     \ [0x0a] CC2DE
    $0b constant TIM6_CC3DE                     \ [0x0b] CC3DE
    $0c constant TIM6_CC4DE                     \ [0x0c] CC4DE
    $0d constant TIM6_COMDE                     \ [0x0d] COMDE
    $0e constant TIM6_TDE                       \ [0x0e] TDE
  [then]


  [ifdef] TIM6_TIM6_SR_DEF
    \
    \ @brief TIM6 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UIF                       \ [0x00] UIF
    $01 constant TIM6_CC1IF                     \ [0x01] CC1IF
    $02 constant TIM6_CC2IF                     \ [0x02] CC2IF
    $03 constant TIM6_CC3IF                     \ [0x03] CC3IF
    $04 constant TIM6_CC4IF                     \ [0x04] CC4IF
    $05 constant TIM6_COMIF                     \ [0x05] COMIF
    $06 constant TIM6_TIF                       \ [0x06] TIF
    $07 constant TIM6_BIF                       \ [0x07] BIF
    $08 constant TIM6_B2IF                      \ [0x08] B2IF
    $09 constant TIM6_CC1OF                     \ [0x09] CC1OF
    $0a constant TIM6_CC2OF                     \ [0x0a] CC2OF
    $0b constant TIM6_CC3OF                     \ [0x0b] CC3OF
    $0c constant TIM6_CC4OF                     \ [0x0c] CC4OF
    $0d constant TIM6_SBIF                      \ [0x0d] SBIF
    $10 constant TIM6_CC5IF                     \ [0x10] CC5IF
    $11 constant TIM6_CC6IF                     \ [0x11] CC6IF
  [then]


  [ifdef] TIM6_TIM6_EGR_DEF
    \
    \ @brief TIM6 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UG                        \ [0x00] UG
    $01 constant TIM6_CC1G                      \ [0x01] CC1G
    $02 constant TIM6_CC2G                      \ [0x02] CC2G
    $03 constant TIM6_CC3G                      \ [0x03] CC3G
    $04 constant TIM6_CC4G                      \ [0x04] CC4G
    $05 constant TIM6_COMG                      \ [0x05] COMG
    $06 constant TIM6_TG                        \ [0x06] TG
    $07 constant TIM6_BG                        \ [0x07] BG
    $08 constant TIM6_B2G                       \ [0x08] B2G
  [then]


  [ifdef] TIM6_TIM6_CCMR1ALTERNATE6_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CC1S                      \ [0x00 : 2] CC1S
    $02 constant TIM6_IC1PSC                    \ [0x02 : 2] IC1PSC
    $04 constant TIM6_IC1F                      \ [0x04 : 4] IC1F
    $08 constant TIM6_CC2S                      \ [0x08 : 2] CC2S
    $0a constant TIM6_IC2PSC                    \ [0x0a : 2] IC2PSC
    $0c constant TIM6_IC2F                      \ [0x0c : 4] IC2F
  [then]


  [ifdef] TIM6_TIM6_CCMR2ALTERNATE22_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CC3S                      \ [0x00 : 2] CC3S
    $02 constant TIM6_IC3PSC                    \ [0x02 : 2] IC3PSC
    $04 constant TIM6_IC3F                      \ [0x04 : 4] IC3F
    $08 constant TIM6_CC4S                      \ [0x08 : 2] CC4S
    $0a constant TIM6_IC4PSC                    \ [0x0a : 2] IC4PSC
    $0c constant TIM6_IC4F                      \ [0x0c : 4] IC4F
  [then]


  [ifdef] TIM6_TIM6_CCER_DEF
    \
    \ @brief TIM6 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CC1E                      \ [0x00] CC1E
    $01 constant TIM6_CC1P                      \ [0x01] CC1P
    $02 constant TIM6_CC1NE                     \ [0x02] CC1NE
    $03 constant TIM6_CC1NP                     \ [0x03] CC1NP
    $04 constant TIM6_CC2E                      \ [0x04] CC2E
    $05 constant TIM6_CC2P                      \ [0x05] CC2P
    $06 constant TIM6_CC2NE                     \ [0x06] CC2NE
    $07 constant TIM6_CC2NP                     \ [0x07] CC2NP
    $08 constant TIM6_CC3E                      \ [0x08] CC3E
    $09 constant TIM6_CC3P                      \ [0x09] CC3P
    $0a constant TIM6_CC3NE                     \ [0x0a] CC3NE
    $0b constant TIM6_CC3NP                     \ [0x0b] CC3NP
    $0c constant TIM6_CC4E                      \ [0x0c] CC4E
    $0d constant TIM6_CC4P                      \ [0x0d] CC4P
    $0f constant TIM6_CC4NP                     \ [0x0f] CC4NP
    $10 constant TIM6_CC5E                      \ [0x10] CC5E
    $11 constant TIM6_CC5P                      \ [0x11] CC5P
    $14 constant TIM6_CC6E                      \ [0x14] CC6E
    $15 constant TIM6_CC6P                      \ [0x15] CC6P
  [then]


  [ifdef] TIM6_TIM6_CNT_DEF
    \
    \ @brief TIM6 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CNT                       \ [0x00 : 16] CNT
    $1f constant TIM6_UIFCPY                    \ [0x1f] UIFCPY
  [then]


  [ifdef] TIM6_TIM6_PSC_DEF
    \
    \ @brief TIM6 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_PSC                       \ [0x00 : 16] PSC
  [then]


  [ifdef] TIM6_TIM6_ARR_DEF
    \
    \ @brief TIM6 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM6_ARR                       \ [0x00 : 16] ARR
  [then]


  [ifdef] TIM6_TIM6_RCR_DEF
    \
    \ @brief TIM6 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_REP                       \ [0x00 : 16] REP
  [then]


  [ifdef] TIM6_TIM6_CCR1_DEF
    \
    \ @brief TIM6 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CCR1                      \ [0x00 : 16] CCR1
  [then]


  [ifdef] TIM6_TIM6_CCR2_DEF
    \
    \ @brief TIM6 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CCR2                      \ [0x00 : 16] CCR2
  [then]


  [ifdef] TIM6_TIM6_CCR3_DEF
    \
    \ @brief TIM6 capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CCR3                      \ [0x00 : 16] CCR3
  [then]


  [ifdef] TIM6_TIM6_CCR4_DEF
    \
    \ @brief TIM6 capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CCR4                      \ [0x00 : 16] CCR4
  [then]


  [ifdef] TIM6_TIM6_BDTR_DEF
    \
    \ @brief As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_DTG                       \ [0x00 : 8] DTG
    $08 constant TIM6_LOCK                      \ [0x08 : 2] LOCK
    $0a constant TIM6_OSSI                      \ [0x0a] OSSI
    $0b constant TIM6_OSSR                      \ [0x0b] OSSR
    $0c constant TIM6_BKE                       \ [0x0c] BKE
    $0d constant TIM6_BKP                       \ [0x0d] BKP
    $0e constant TIM6_AOE                       \ [0x0e] AOE
    $0f constant TIM6_MOE                       \ [0x0f] MOE
    $10 constant TIM6_BKF                       \ [0x10 : 4] BKF
    $14 constant TIM6_BK2F                      \ [0x14 : 4] BK2F
    $18 constant TIM6_BK2E                      \ [0x18] BK2E
    $19 constant TIM6_BK2P                      \ [0x19] BK2P
    $1a constant TIM6_BKDSRM                    \ [0x1a] BKDSRM
    $1b constant TIM6_BK2DSRM                   \ [0x1b] BK2DSRM
    $1c constant TIM6_BKBID                     \ [0x1c] BKBID
    $1d constant TIM6_BK2BID                    \ [0x1d] BK2BID
  [then]


  [ifdef] TIM6_TIM6_DCR_DEF
    \
    \ @brief TIM6 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_DBA                       \ [0x00 : 5] DBA
    $08 constant TIM6_DBL                       \ [0x08 : 5] DBL
  [then]


  [ifdef] TIM6_TIM6_DMAR_DEF
    \
    \ @brief TIM6 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_DMAB                      \ [0x00 : 32] DMAB
  [then]


  [ifdef] TIM6_TIM6_CCMR3_DEF
    \
    \ @brief The channels 5 and 6 can only be configured in output. Output compare mode:
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant TIM6_OC5FE                     \ [0x02] OC5FE
    $03 constant TIM6_OC5PE                     \ [0x03] OC5PE
    $04 constant TIM6_OC5M                      \ [0x04 : 3] OC5M
    $07 constant TIM6_OC5CE                     \ [0x07] OC5CE
    $0a constant TIM6_OC6FE                     \ [0x0a] OC6FE
    $0b constant TIM6_OC6PE                     \ [0x0b] OC6PE
    $0c constant TIM6_OC6M                      \ [0x0c : 3] OC6M
    $0f constant TIM6_OC6CE                     \ [0x0f] OC6CE
    $10 constant TIM6_OC5M3                     \ [0x10] OC5M3
    $18 constant TIM6_OC6M3                     \ [0x18] OC6M3
  [then]


  [ifdef] TIM6_TIM6_CCR5_DEF
    \
    \ @brief TIM6 capture/compare register 5
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CCR5                      \ [0x00 : 16] CCR5
    $1d constant TIM6_GC5C1                     \ [0x1d] GC5C1
    $1e constant TIM6_GC5C2                     \ [0x1e] GC5C2
    $1f constant TIM6_GC5C3                     \ [0x1f] GC5C3
  [then]


  [ifdef] TIM6_TIM6_CCR6_DEF
    \
    \ @brief TIM6 capture/compare register 6
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CCR6                      \ [0x00 : 16] CCR6
  [then]

  \
  \ @brief TIM6
  \
  $00 constant TIM6_TIM6_CR1            \ TIM6 control register 1
  $04 constant TIM6_TIM6_CR2            \ TIM6 control register 2
  $08 constant TIM6_TIM6_SMCR           \ TIM6 slave mode control register
  $0C constant TIM6_TIM6_DIER           \ TIM6 DMA/interrupt enable register
  $10 constant TIM6_TIM6_SR             \ TIM6 status register
  $14 constant TIM6_TIM6_EGR            \ TIM6 event generation register
  $18 constant TIM6_TIM6_CCMR1ALTERNATE6    \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $1C constant TIM6_TIM6_CCMR2ALTERNATE22    \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $20 constant TIM6_TIM6_CCER           \ TIM6 capture/compare enable register
  $24 constant TIM6_TIM6_CNT            \ TIM6 counter
  $28 constant TIM6_TIM6_PSC            \ TIM6 prescaler
  $2C constant TIM6_TIM6_ARR            \ TIM6 auto-reload register
  $30 constant TIM6_TIM6_RCR            \ TIM6 repetition counter register
  $34 constant TIM6_TIM6_CCR1           \ TIM6 capture/compare register 1
  $38 constant TIM6_TIM6_CCR2           \ TIM6 capture/compare register 2
  $3C constant TIM6_TIM6_CCR3           \ TIM6 capture/compare register 3
  $40 constant TIM6_TIM6_CCR4           \ TIM6 capture/compare register 4
  $44 constant TIM6_TIM6_BDTR           \ As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
  $48 constant TIM6_TIM6_DCR            \ TIM6 DMA control register
  $4C constant TIM6_TIM6_DMAR           \ TIM6 DMA address for full transfer
  $54 constant TIM6_TIM6_CCMR3          \ The channels 5 and 6 can only be configured in output. Output compare mode:
  $58 constant TIM6_TIM6_CCR5           \ TIM6 capture/compare register 5
  $5C constant TIM6_TIM6_CCR6           \ TIM6 capture/compare register 6

: TIM6_DEF ; [then]
