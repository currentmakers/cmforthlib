\
\ @file tim8.fs
\ @brief TIM8
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
    $00 constant TIM8_CEN                       \ [0x00] CEN
    $01 constant TIM8_UDIS                      \ [0x01] UDIS
    $02 constant TIM8_URS                       \ [0x02] URS
    $03 constant TIM8_OPM                       \ [0x03] OPM
    $04 constant TIM8_DIR                       \ [0x04] DIR
    $05 constant TIM8_CMS                       \ [0x05 : 2] CMS
    $07 constant TIM8_ARPE                      \ [0x07] ARPE
    $08 constant TIM8_CKD                       \ [0x08 : 2] CKD
    $0b constant TIM8_UIFREMAP                  \ [0x0b] UIFREMAP
  [then]


  [ifdef] TIM8_TIM8_CR2_DEF
    \
    \ @brief TIM8 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCPC                      \ [0x00] CCPC
    $02 constant TIM8_CCUS                      \ [0x02] CCUS
    $03 constant TIM8_CCDS                      \ [0x03] CCDS
    $04 constant TIM8_MMS                       \ [0x04 : 3] MMS
    $07 constant TIM8_TI1S                      \ [0x07] TI1S
    $08 constant TIM8_OIS1                      \ [0x08] OIS1
    $09 constant TIM8_OIS1N                     \ [0x09] OIS1N
    $0a constant TIM8_OIS2                      \ [0x0a] OIS2
    $0b constant TIM8_OIS2N                     \ [0x0b] OIS2N
    $0c constant TIM8_OIS3                      \ [0x0c] OIS3
    $0d constant TIM8_OIS3N                     \ [0x0d] OIS3N
    $0e constant TIM8_OIS4                      \ [0x0e] OIS4
    $10 constant TIM8_OIS5                      \ [0x10] OIS5
    $12 constant TIM8_OIS6                      \ [0x12] OIS6
    $14 constant TIM8_MMS2                      \ [0x14 : 4] MMS2
  [then]


  [ifdef] TIM8_TIM8_SMCR_DEF
    \
    \ @brief TIM8 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_SMS                       \ [0x00 : 3] SMS
    $04 constant TIM8_TS                        \ [0x04 : 3] TS
    $07 constant TIM8_MSM                       \ [0x07] MSM
    $08 constant TIM8_ETF                       \ [0x08 : 4] ETF
    $0c constant TIM8_ETPS                      \ [0x0c : 2] ETPS
    $0e constant TIM8_ECE                       \ [0x0e] ECE
    $0f constant TIM8_ETP                       \ [0x0f] ETP
    $10 constant TIM8_SMS3                      \ [0x10] SMS3
    $14 constant TIM8_TS3                       \ [0x14] TS3
    $15 constant TIM8_TS4                       \ [0x15] TS4
  [then]


  [ifdef] TIM8_TIM8_DIER_DEF
    \
    \ @brief TIM8 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_UIE                       \ [0x00] UIE
    $01 constant TIM8_CC1IE                     \ [0x01] CC1IE
    $02 constant TIM8_CC2IE                     \ [0x02] CC2IE
    $03 constant TIM8_CC3IE                     \ [0x03] CC3IE
    $04 constant TIM8_CC4IE                     \ [0x04] CC4IE
    $05 constant TIM8_COMIE                     \ [0x05] COMIE
    $06 constant TIM8_TIE                       \ [0x06] TIE
    $07 constant TIM8_BIE                       \ [0x07] BIE
    $08 constant TIM8_UDE                       \ [0x08] UDE
    $09 constant TIM8_CC1DE                     \ [0x09] CC1DE
    $0a constant TIM8_CC2DE                     \ [0x0a] CC2DE
    $0b constant TIM8_CC3DE                     \ [0x0b] CC3DE
    $0c constant TIM8_CC4DE                     \ [0x0c] CC4DE
    $0d constant TIM8_COMDE                     \ [0x0d] COMDE
    $0e constant TIM8_TDE                       \ [0x0e] TDE
  [then]


  [ifdef] TIM8_TIM8_SR_DEF
    \
    \ @brief TIM8 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_UIF                       \ [0x00] UIF
    $01 constant TIM8_CC1IF                     \ [0x01] CC1IF
    $02 constant TIM8_CC2IF                     \ [0x02] CC2IF
    $03 constant TIM8_CC3IF                     \ [0x03] CC3IF
    $04 constant TIM8_CC4IF                     \ [0x04] CC4IF
    $05 constant TIM8_COMIF                     \ [0x05] COMIF
    $06 constant TIM8_TIF                       \ [0x06] TIF
    $07 constant TIM8_BIF                       \ [0x07] BIF
    $08 constant TIM8_B2IF                      \ [0x08] B2IF
    $09 constant TIM8_CC1OF                     \ [0x09] CC1OF
    $0a constant TIM8_CC2OF                     \ [0x0a] CC2OF
    $0b constant TIM8_CC3OF                     \ [0x0b] CC3OF
    $0c constant TIM8_CC4OF                     \ [0x0c] CC4OF
    $0d constant TIM8_SBIF                      \ [0x0d] SBIF
    $10 constant TIM8_CC5IF                     \ [0x10] CC5IF
    $11 constant TIM8_CC6IF                     \ [0x11] CC6IF
  [then]


  [ifdef] TIM8_TIM8_EGR_DEF
    \
    \ @brief TIM8 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_UG                        \ [0x00] UG
    $01 constant TIM8_CC1G                      \ [0x01] CC1G
    $02 constant TIM8_CC2G                      \ [0x02] CC2G
    $03 constant TIM8_CC3G                      \ [0x03] CC3G
    $04 constant TIM8_CC4G                      \ [0x04] CC4G
    $05 constant TIM8_COMG                      \ [0x05] COMG
    $06 constant TIM8_TG                        \ [0x06] TG
    $07 constant TIM8_BG                        \ [0x07] BG
    $08 constant TIM8_B2G                       \ [0x08] B2G
  [then]


  [ifdef] TIM8_TIM8_CCMR1ALTERNATE8_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC1S                      \ [0x00 : 2] CC1S
    $02 constant TIM8_IC1PSC                    \ [0x02 : 2] IC1PSC
    $04 constant TIM8_IC1F                      \ [0x04 : 4] IC1F
    $08 constant TIM8_CC2S                      \ [0x08 : 2] CC2S
    $0a constant TIM8_IC2PSC                    \ [0x0a : 2] IC2PSC
    $0c constant TIM8_IC2F                      \ [0x0c : 4] IC2F
  [then]


  [ifdef] TIM8_TIM8_CCMR2ALTERNATE24_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC3S                      \ [0x00 : 2] CC3S
    $02 constant TIM8_IC3PSC                    \ [0x02 : 2] IC3PSC
    $04 constant TIM8_IC3F                      \ [0x04 : 4] IC3F
    $08 constant TIM8_CC4S                      \ [0x08 : 2] CC4S
    $0a constant TIM8_IC4PSC                    \ [0x0a : 2] IC4PSC
    $0c constant TIM8_IC4F                      \ [0x0c : 4] IC4F
  [then]


  [ifdef] TIM8_TIM8_CCER_DEF
    \
    \ @brief TIM8 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CC1E                      \ [0x00] CC1E
    $01 constant TIM8_CC1P                      \ [0x01] CC1P
    $02 constant TIM8_CC1NE                     \ [0x02] CC1NE
    $03 constant TIM8_CC1NP                     \ [0x03] CC1NP
    $04 constant TIM8_CC2E                      \ [0x04] CC2E
    $05 constant TIM8_CC2P                      \ [0x05] CC2P
    $06 constant TIM8_CC2NE                     \ [0x06] CC2NE
    $07 constant TIM8_CC2NP                     \ [0x07] CC2NP
    $08 constant TIM8_CC3E                      \ [0x08] CC3E
    $09 constant TIM8_CC3P                      \ [0x09] CC3P
    $0a constant TIM8_CC3NE                     \ [0x0a] CC3NE
    $0b constant TIM8_CC3NP                     \ [0x0b] CC3NP
    $0c constant TIM8_CC4E                      \ [0x0c] CC4E
    $0d constant TIM8_CC4P                      \ [0x0d] CC4P
    $0f constant TIM8_CC4NP                     \ [0x0f] CC4NP
    $10 constant TIM8_CC5E                      \ [0x10] CC5E
    $11 constant TIM8_CC5P                      \ [0x11] CC5P
    $14 constant TIM8_CC6E                      \ [0x14] CC6E
    $15 constant TIM8_CC6P                      \ [0x15] CC6P
  [then]


  [ifdef] TIM8_TIM8_CNT_DEF
    \
    \ @brief TIM8 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CNT                       \ [0x00 : 16] CNT
    $1f constant TIM8_UIFCPY                    \ [0x1f] UIFCPY
  [then]


  [ifdef] TIM8_TIM8_PSC_DEF
    \
    \ @brief TIM8 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_PSC                       \ [0x00 : 16] PSC
  [then]


  [ifdef] TIM8_TIM8_ARR_DEF
    \
    \ @brief TIM8 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM8_ARR                       \ [0x00 : 16] ARR
  [then]


  [ifdef] TIM8_TIM8_RCR_DEF
    \
    \ @brief TIM8 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_REP                       \ [0x00 : 16] REP
  [then]


  [ifdef] TIM8_TIM8_CCR1_DEF
    \
    \ @brief TIM8 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR1                      \ [0x00 : 16] CCR1
  [then]


  [ifdef] TIM8_TIM8_CCR2_DEF
    \
    \ @brief TIM8 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR2                      \ [0x00 : 16] CCR2
  [then]


  [ifdef] TIM8_TIM8_CCR3_DEF
    \
    \ @brief TIM8 capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR3                      \ [0x00 : 16] CCR3
  [then]


  [ifdef] TIM8_TIM8_CCR4_DEF
    \
    \ @brief TIM8 capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR4                      \ [0x00 : 16] CCR4
  [then]


  [ifdef] TIM8_TIM8_BDTR_DEF
    \
    \ @brief As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DTG                       \ [0x00 : 8] DTG
    $08 constant TIM8_LOCK                      \ [0x08 : 2] LOCK
    $0a constant TIM8_OSSI                      \ [0x0a] OSSI
    $0b constant TIM8_OSSR                      \ [0x0b] OSSR
    $0c constant TIM8_BKE                       \ [0x0c] BKE
    $0d constant TIM8_BKP                       \ [0x0d] BKP
    $0e constant TIM8_AOE                       \ [0x0e] AOE
    $0f constant TIM8_MOE                       \ [0x0f] MOE
    $10 constant TIM8_BKF                       \ [0x10 : 4] BKF
    $14 constant TIM8_BK2F                      \ [0x14 : 4] BK2F
    $18 constant TIM8_BK2E                      \ [0x18] BK2E
    $19 constant TIM8_BK2P                      \ [0x19] BK2P
    $1a constant TIM8_BKDSRM                    \ [0x1a] BKDSRM
    $1b constant TIM8_BK2DSRM                   \ [0x1b] BK2DSRM
    $1c constant TIM8_BKBID                     \ [0x1c] BKBID
    $1d constant TIM8_BK2BID                    \ [0x1d] BK2BID
  [then]


  [ifdef] TIM8_TIM8_DCR_DEF
    \
    \ @brief TIM8 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DBA                       \ [0x00 : 5] DBA
    $08 constant TIM8_DBL                       \ [0x08 : 5] DBL
  [then]


  [ifdef] TIM8_TIM8_DMAR_DEF
    \
    \ @brief TIM8 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_DMAB                      \ [0x00 : 32] DMAB
  [then]


  [ifdef] TIM8_TIM8_CCMR3_DEF
    \
    \ @brief The channels 5 and 6 can only be configured in output. Output compare mode:
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant TIM8_OC5FE                     \ [0x02] OC5FE
    $03 constant TIM8_OC5PE                     \ [0x03] OC5PE
    $04 constant TIM8_OC5M                      \ [0x04 : 3] OC5M
    $07 constant TIM8_OC5CE                     \ [0x07] OC5CE
    $0a constant TIM8_OC6FE                     \ [0x0a] OC6FE
    $0b constant TIM8_OC6PE                     \ [0x0b] OC6PE
    $0c constant TIM8_OC6M                      \ [0x0c : 3] OC6M
    $0f constant TIM8_OC6CE                     \ [0x0f] OC6CE
    $10 constant TIM8_OC5M3                     \ [0x10] OC5M3
    $18 constant TIM8_OC6M3                     \ [0x18] OC6M3
  [then]


  [ifdef] TIM8_TIM8_CCR5_DEF
    \
    \ @brief TIM8 capture/compare register 5
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR5                      \ [0x00 : 16] CCR5
    $1d constant TIM8_GC5C1                     \ [0x1d] GC5C1
    $1e constant TIM8_GC5C2                     \ [0x1e] GC5C2
    $1f constant TIM8_GC5C3                     \ [0x1f] GC5C3
  [then]


  [ifdef] TIM8_TIM8_CCR6_DEF
    \
    \ @brief TIM8 capture/compare register 6
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_CCR6                      \ [0x00 : 16] CCR6
  [then]


  [ifdef] TIM8_TIM8_AF1_DEF
    \
    \ @brief TIM8 Alternate function option register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM8_BKINE                     \ [0x00] BKINE
    $08 constant TIM8_BKDF1BK2E                 \ [0x08] BKDF1BK2E
    $09 constant TIM8_BKINP                     \ [0x09] BKINP
    $0e constant TIM8_ETRSEL                    \ [0x0e : 4] ETRSEL
  [then]


  [ifdef] TIM8_TIM8_AF2_DEF
    \
    \ @brief TIM8 Alternate function option register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000001
    \
    $00 constant TIM8_BK2INE                    \ [0x00] BK2INE
    $08 constant TIM8_BK2DF1BK3E                \ [0x08] BK2DF1BK3E
    $09 constant TIM8_BK2INP                    \ [0x09] BK2INP
  [then]


  [ifdef] TIM8_TIM8_TISEL_DEF
    \
    \ @brief TIM8 timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM8_TI1SEL                    \ [0x00 : 4] TI1SEL
    $08 constant TIM8_TI2SEL                    \ [0x08 : 4] TI2SEL
    $10 constant TIM8_TI3SEL                    \ [0x10 : 4] TI3SEL
    $18 constant TIM8_TI4SEL                    \ [0x18 : 4] TI4SEL
  [then]

  \
  \ @brief TIM8
  \
  $00 constant TIM8_TIM8_CR1            \ TIM8 control register 1
  $04 constant TIM8_TIM8_CR2            \ TIM8 control register 2
  $08 constant TIM8_TIM8_SMCR           \ TIM8 slave mode control register
  $0C constant TIM8_TIM8_DIER           \ TIM8 DMA/interrupt enable register
  $10 constant TIM8_TIM8_SR             \ TIM8 status register
  $14 constant TIM8_TIM8_EGR            \ TIM8 event generation register
  $18 constant TIM8_TIM8_CCMR1ALTERNATE8    \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $1C constant TIM8_TIM8_CCMR2ALTERNATE24    \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $20 constant TIM8_TIM8_CCER           \ TIM8 capture/compare enable register
  $24 constant TIM8_TIM8_CNT            \ TIM8 counter
  $28 constant TIM8_TIM8_PSC            \ TIM8 prescaler
  $2C constant TIM8_TIM8_ARR            \ TIM8 auto-reload register
  $30 constant TIM8_TIM8_RCR            \ TIM8 repetition counter register
  $34 constant TIM8_TIM8_CCR1           \ TIM8 capture/compare register 1
  $38 constant TIM8_TIM8_CCR2           \ TIM8 capture/compare register 2
  $3C constant TIM8_TIM8_CCR3           \ TIM8 capture/compare register 3
  $40 constant TIM8_TIM8_CCR4           \ TIM8 capture/compare register 4
  $44 constant TIM8_TIM8_BDTR           \ As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
  $48 constant TIM8_TIM8_DCR            \ TIM8 DMA control register
  $4C constant TIM8_TIM8_DMAR           \ TIM8 DMA address for full transfer
  $54 constant TIM8_TIM8_CCMR3          \ The channels 5 and 6 can only be configured in output. Output compare mode:
  $58 constant TIM8_TIM8_CCR5           \ TIM8 capture/compare register 5
  $5C constant TIM8_TIM8_CCR6           \ TIM8 capture/compare register 6
  $60 constant TIM8_TIM8_AF1            \ TIM8 Alternate function option register 1
  $64 constant TIM8_TIM8_AF2            \ TIM8 Alternate function option register 2
  $68 constant TIM8_TIM8_TISEL          \ TIM8 timer input selection register

: TIM8_DEF ; [then]
