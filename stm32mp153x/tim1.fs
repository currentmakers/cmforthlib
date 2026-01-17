\
\ @file tim1.fs
\ @brief TIM1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM1_DEF

  [ifdef] TIM1_TIM1_CR1_DEF
    \
    \ @brief TIM1 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CEN                       \ [0x00] CEN
    $01 constant TIM1_UDIS                      \ [0x01] UDIS
    $02 constant TIM1_URS                       \ [0x02] URS
    $03 constant TIM1_OPM                       \ [0x03] OPM
    $04 constant TIM1_DIR                       \ [0x04] DIR
    $05 constant TIM1_CMS                       \ [0x05 : 2] CMS
    $07 constant TIM1_ARPE                      \ [0x07] ARPE
    $08 constant TIM1_CKD                       \ [0x08 : 2] CKD
    $0b constant TIM1_UIFREMAP                  \ [0x0b] UIFREMAP
  [then]


  [ifdef] TIM1_TIM1_CR2_DEF
    \
    \ @brief TIM1 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCPC                      \ [0x00] CCPC
    $02 constant TIM1_CCUS                      \ [0x02] CCUS
    $03 constant TIM1_CCDS                      \ [0x03] CCDS
    $04 constant TIM1_MMS                       \ [0x04 : 3] MMS
    $07 constant TIM1_TI1S                      \ [0x07] TI1S
    $08 constant TIM1_OIS1                      \ [0x08] OIS1
    $09 constant TIM1_OIS1N                     \ [0x09] OIS1N
    $0a constant TIM1_OIS2                      \ [0x0a] OIS2
    $0b constant TIM1_OIS2N                     \ [0x0b] OIS2N
    $0c constant TIM1_OIS3                      \ [0x0c] OIS3
    $0d constant TIM1_OIS3N                     \ [0x0d] OIS3N
    $0e constant TIM1_OIS4                      \ [0x0e] OIS4
    $10 constant TIM1_OIS5                      \ [0x10] OIS5
    $12 constant TIM1_OIS6                      \ [0x12] OIS6
    $14 constant TIM1_MMS2                      \ [0x14 : 4] MMS2
  [then]


  [ifdef] TIM1_TIM1_SMCR_DEF
    \
    \ @brief TIM1 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_SMS                       \ [0x00 : 3] SMS
    $04 constant TIM1_TS                        \ [0x04 : 3] TS
    $07 constant TIM1_MSM                       \ [0x07] MSM
    $08 constant TIM1_ETF                       \ [0x08 : 4] ETF
    $0c constant TIM1_ETPS                      \ [0x0c : 2] ETPS
    $0e constant TIM1_ECE                       \ [0x0e] ECE
    $0f constant TIM1_ETP                       \ [0x0f] ETP
    $10 constant TIM1_SMS3                      \ [0x10] SMS3
    $14 constant TIM1_TS3                       \ [0x14] TS3
    $15 constant TIM1_TS4                       \ [0x15] TS4
  [then]


  [ifdef] TIM1_TIM1_DIER_DEF
    \
    \ @brief TIM1 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_UIE                       \ [0x00] UIE
    $01 constant TIM1_CC1IE                     \ [0x01] CC1IE
    $02 constant TIM1_CC2IE                     \ [0x02] CC2IE
    $03 constant TIM1_CC3IE                     \ [0x03] CC3IE
    $04 constant TIM1_CC4IE                     \ [0x04] CC4IE
    $05 constant TIM1_COMIE                     \ [0x05] COMIE
    $06 constant TIM1_TIE                       \ [0x06] TIE
    $07 constant TIM1_BIE                       \ [0x07] BIE
    $08 constant TIM1_UDE                       \ [0x08] UDE
    $09 constant TIM1_CC1DE                     \ [0x09] CC1DE
    $0a constant TIM1_CC2DE                     \ [0x0a] CC2DE
    $0b constant TIM1_CC3DE                     \ [0x0b] CC3DE
    $0c constant TIM1_CC4DE                     \ [0x0c] CC4DE
    $0d constant TIM1_COMDE                     \ [0x0d] COMDE
    $0e constant TIM1_TDE                       \ [0x0e] TDE
  [then]


  [ifdef] TIM1_TIM1_SR_DEF
    \
    \ @brief TIM1 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_UIF                       \ [0x00] UIF
    $01 constant TIM1_CC1IF                     \ [0x01] CC1IF
    $02 constant TIM1_CC2IF                     \ [0x02] CC2IF
    $03 constant TIM1_CC3IF                     \ [0x03] CC3IF
    $04 constant TIM1_CC4IF                     \ [0x04] CC4IF
    $05 constant TIM1_COMIF                     \ [0x05] COMIF
    $06 constant TIM1_TIF                       \ [0x06] TIF
    $07 constant TIM1_BIF                       \ [0x07] BIF
    $08 constant TIM1_B2IF                      \ [0x08] B2IF
    $09 constant TIM1_CC1OF                     \ [0x09] CC1OF
    $0a constant TIM1_CC2OF                     \ [0x0a] CC2OF
    $0b constant TIM1_CC3OF                     \ [0x0b] CC3OF
    $0c constant TIM1_CC4OF                     \ [0x0c] CC4OF
    $0d constant TIM1_SBIF                      \ [0x0d] SBIF
    $10 constant TIM1_CC5IF                     \ [0x10] CC5IF
    $11 constant TIM1_CC6IF                     \ [0x11] CC6IF
  [then]


  [ifdef] TIM1_TIM1_EGR_DEF
    \
    \ @brief TIM1 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_UG                        \ [0x00] UG
    $01 constant TIM1_CC1G                      \ [0x01] CC1G
    $02 constant TIM1_CC2G                      \ [0x02] CC2G
    $03 constant TIM1_CC3G                      \ [0x03] CC3G
    $04 constant TIM1_CC4G                      \ [0x04] CC4G
    $05 constant TIM1_COMG                      \ [0x05] COMG
    $06 constant TIM1_TG                        \ [0x06] TG
    $07 constant TIM1_BG                        \ [0x07] BG
    $08 constant TIM1_B2G                       \ [0x08] B2G
  [then]


  [ifdef] TIM1_TIM1_CCMR1ALTERNATE1_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC1S                      \ [0x00 : 2] CC1S
    $02 constant TIM1_IC1PSC                    \ [0x02 : 2] IC1PSC
    $04 constant TIM1_IC1F                      \ [0x04 : 4] IC1F
    $08 constant TIM1_CC2S                      \ [0x08 : 2] CC2S
    $0a constant TIM1_IC2PSC                    \ [0x0a : 2] IC2PSC
    $0c constant TIM1_IC2F                      \ [0x0c : 4] IC2F
  [then]


  [ifdef] TIM1_TIM1_CCMR2ALTERNATE17_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC3S                      \ [0x00 : 2] CC3S
    $02 constant TIM1_IC3PSC                    \ [0x02 : 2] IC3PSC
    $04 constant TIM1_IC3F                      \ [0x04 : 4] IC3F
    $08 constant TIM1_CC4S                      \ [0x08 : 2] CC4S
    $0a constant TIM1_IC4PSC                    \ [0x0a : 2] IC4PSC
    $0c constant TIM1_IC4F                      \ [0x0c : 4] IC4F
  [then]


  [ifdef] TIM1_TIM1_CCER_DEF
    \
    \ @brief TIM1 capture/compare enable register
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
    $0f constant TIM1_CC4NP                     \ [0x0f] CC4NP
    $10 constant TIM1_CC5E                      \ [0x10] CC5E
    $11 constant TIM1_CC5P                      \ [0x11] CC5P
    $14 constant TIM1_CC6E                      \ [0x14] CC6E
    $15 constant TIM1_CC6P                      \ [0x15] CC6P
  [then]


  [ifdef] TIM1_TIM1_CNT_DEF
    \
    \ @brief TIM1 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CNT                       \ [0x00 : 16] CNT
    $1f constant TIM1_UIFCPY                    \ [0x1f] UIFCPY
  [then]


  [ifdef] TIM1_TIM1_PSC_DEF
    \
    \ @brief TIM1 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_PSC                       \ [0x00 : 16] PSC
  [then]


  [ifdef] TIM1_TIM1_ARR_DEF
    \
    \ @brief TIM1 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM1_ARR                       \ [0x00 : 16] ARR
  [then]


  [ifdef] TIM1_TIM1_RCR_DEF
    \
    \ @brief TIM1 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_REP                       \ [0x00 : 16] REP
  [then]


  [ifdef] TIM1_TIM1_CCR1_DEF
    \
    \ @brief TIM1 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR1                      \ [0x00 : 16] CCR1
  [then]


  [ifdef] TIM1_TIM1_CCR2_DEF
    \
    \ @brief TIM1 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR2                      \ [0x00 : 16] CCR2
  [then]


  [ifdef] TIM1_TIM1_CCR3_DEF
    \
    \ @brief TIM1 capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR3                      \ [0x00 : 16] CCR3
  [then]


  [ifdef] TIM1_TIM1_CCR4_DEF
    \
    \ @brief TIM1 capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR4                      \ [0x00 : 16] CCR4
  [then]


  [ifdef] TIM1_TIM1_BDTR_DEF
    \
    \ @brief As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_DTG                       \ [0x00 : 8] DTG
    $08 constant TIM1_LOCK                      \ [0x08 : 2] LOCK
    $0a constant TIM1_OSSI                      \ [0x0a] OSSI
    $0b constant TIM1_OSSR                      \ [0x0b] OSSR
    $0c constant TIM1_BKE                       \ [0x0c] BKE
    $0d constant TIM1_BKP                       \ [0x0d] BKP
    $0e constant TIM1_AOE                       \ [0x0e] AOE
    $0f constant TIM1_MOE                       \ [0x0f] MOE
    $10 constant TIM1_BKF                       \ [0x10 : 4] BKF
    $14 constant TIM1_BK2F                      \ [0x14 : 4] BK2F
    $18 constant TIM1_BK2E                      \ [0x18] BK2E
    $19 constant TIM1_BK2P                      \ [0x19] BK2P
    $1a constant TIM1_BKDSRM                    \ [0x1a] BKDSRM
    $1b constant TIM1_BK2DSRM                   \ [0x1b] BK2DSRM
    $1c constant TIM1_BKBID                     \ [0x1c] BKBID
    $1d constant TIM1_BK2BID                    \ [0x1d] BK2BID
  [then]


  [ifdef] TIM1_TIM1_DCR_DEF
    \
    \ @brief TIM1 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_DBA                       \ [0x00 : 5] DBA
    $08 constant TIM1_DBL                       \ [0x08 : 5] DBL
  [then]


  [ifdef] TIM1_TIM1_DMAR_DEF
    \
    \ @brief TIM1 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_DMAB                      \ [0x00 : 32] DMAB
  [then]


  [ifdef] TIM1_TIM1_CCMR3_DEF
    \
    \ @brief The channels 5 and 6 can only be configured in output. Output compare mode:
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
    $10 constant TIM1_OC5M3                     \ [0x10] OC5M3
    $18 constant TIM1_OC6M3                     \ [0x18] OC6M3
  [then]


  [ifdef] TIM1_TIM1_CCR5_DEF
    \
    \ @brief TIM1 capture/compare register 5
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR5                      \ [0x00 : 16] CCR5
    $1d constant TIM1_GC5C1                     \ [0x1d] GC5C1
    $1e constant TIM1_GC5C2                     \ [0x1e] GC5C2
    $1f constant TIM1_GC5C3                     \ [0x1f] GC5C3
  [then]


  [ifdef] TIM1_TIM1_CCR6_DEF
    \
    \ @brief TIM1 capture/compare register 6
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR6                      \ [0x00 : 16] CCR6
  [then]


  [ifdef] TIM1_TIM1_AF1_DEF
    \
    \ @brief TIM1 alternate function option register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM1_BKINE                     \ [0x00] BKINE
    $08 constant TIM1_BKDF1BK0E                 \ [0x08] BKDF1BK0E
    $09 constant TIM1_BKINP                     \ [0x09] BKINP
    $0e constant TIM1_ETRSEL                    \ [0x0e : 4] ETRSEL
  [then]


  [ifdef] TIM1_TIM1_AF2_DEF
    \
    \ @brief TIM1 Alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000001
    \
    $00 constant TIM1_BK2INE                    \ [0x00] BK2INE
    $08 constant TIM1_BK2DF1BK1E                \ [0x08] BK2DF1BK1E
    $09 constant TIM1_BK2INP                    \ [0x09] BK2INP
  [then]


  [ifdef] TIM1_TIM1_TISEL_DEF
    \
    \ @brief TIM1 timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_TI1SEL                    \ [0x00 : 4] TI1SEL
    $08 constant TIM1_TI2SEL                    \ [0x08 : 4] TI2SEL
    $10 constant TIM1_TI3SEL                    \ [0x10 : 4] TI3SEL
    $18 constant TIM1_TI4SEL                    \ [0x18 : 4] TI4SEL
  [then]

  \
  \ @brief TIM1
  \
  $00 constant TIM1_TIM1_CR1            \ TIM1 control register 1
  $04 constant TIM1_TIM1_CR2            \ TIM1 control register 2
  $08 constant TIM1_TIM1_SMCR           \ TIM1 slave mode control register
  $0C constant TIM1_TIM1_DIER           \ TIM1 DMA/interrupt enable register
  $10 constant TIM1_TIM1_SR             \ TIM1 status register
  $14 constant TIM1_TIM1_EGR            \ TIM1 event generation register
  $18 constant TIM1_TIM1_CCMR1ALTERNATE1    \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $1C constant TIM1_TIM1_CCMR2ALTERNATE17    \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $20 constant TIM1_TIM1_CCER           \ TIM1 capture/compare enable register
  $24 constant TIM1_TIM1_CNT            \ TIM1 counter
  $28 constant TIM1_TIM1_PSC            \ TIM1 prescaler
  $2C constant TIM1_TIM1_ARR            \ TIM1 auto-reload register
  $30 constant TIM1_TIM1_RCR            \ TIM1 repetition counter register
  $34 constant TIM1_TIM1_CCR1           \ TIM1 capture/compare register 1
  $38 constant TIM1_TIM1_CCR2           \ TIM1 capture/compare register 2
  $3C constant TIM1_TIM1_CCR3           \ TIM1 capture/compare register 3
  $40 constant TIM1_TIM1_CCR4           \ TIM1 capture/compare register 4
  $44 constant TIM1_TIM1_BDTR           \ As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
  $48 constant TIM1_TIM1_DCR            \ TIM1 DMA control register
  $4C constant TIM1_TIM1_DMAR           \ TIM1 DMA address for full transfer
  $54 constant TIM1_TIM1_CCMR3          \ The channels 5 and 6 can only be configured in output. Output compare mode:
  $58 constant TIM1_TIM1_CCR5           \ TIM1 capture/compare register 5
  $5C constant TIM1_TIM1_CCR6           \ TIM1 capture/compare register 6
  $60 constant TIM1_TIM1_AF1            \ TIM1 alternate function option register 1
  $64 constant TIM1_TIM1_AF2            \ TIM1 Alternate function register 2
  $68 constant TIM1_TIM1_TISEL          \ TIM1 timer input selection register

: TIM1_DEF ; [then]
