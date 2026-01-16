\
\ @file tim1.fs
\ @brief TIM1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM1 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_CR1_CEN                                \ CEN
$00000002 constant TIM1_TIM1_CR1_UDIS                               \ UDIS
$00000004 constant TIM1_TIM1_CR1_URS                                \ URS
$00000008 constant TIM1_TIM1_CR1_OPM                                \ OPM
$00000010 constant TIM1_TIM1_CR1_DIR                                \ DIR
$00000060 constant TIM1_TIM1_CR1_CMS                                \ CMS
$00000080 constant TIM1_TIM1_CR1_ARPE                               \ ARPE
$00000300 constant TIM1_TIM1_CR1_CKD                                \ CKD
$00000800 constant TIM1_TIM1_CR1_UIFREMAP                           \ UIFREMAP


\
\ @brief TIM1 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_CR2_CCPC                               \ CCPC
$00000004 constant TIM1_TIM1_CR2_CCUS                               \ CCUS
$00000008 constant TIM1_TIM1_CR2_CCDS                               \ CCDS
$00000070 constant TIM1_TIM1_CR2_MMS                                \ MMS
$00000080 constant TIM1_TIM1_CR2_TI1S                               \ TI1S
$00000100 constant TIM1_TIM1_CR2_OIS1                               \ OIS1
$00000200 constant TIM1_TIM1_CR2_OIS1N                              \ OIS1N
$00000400 constant TIM1_TIM1_CR2_OIS2                               \ OIS2
$00000800 constant TIM1_TIM1_CR2_OIS2N                              \ OIS2N
$00001000 constant TIM1_TIM1_CR2_OIS3                               \ OIS3
$00002000 constant TIM1_TIM1_CR2_OIS3N                              \ OIS3N
$00004000 constant TIM1_TIM1_CR2_OIS4                               \ OIS4
$00010000 constant TIM1_TIM1_CR2_OIS5                               \ OIS5
$00040000 constant TIM1_TIM1_CR2_OIS6                               \ OIS6
$00f00000 constant TIM1_TIM1_CR2_MMS2                               \ MMS2


\
\ @brief TIM1 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM1_TIM1_SMCR_SMS                               \ SMS
$00000070 constant TIM1_TIM1_SMCR_TS                                \ TS
$00000080 constant TIM1_TIM1_SMCR_MSM                               \ MSM
$00000f00 constant TIM1_TIM1_SMCR_ETF                               \ ETF
$00003000 constant TIM1_TIM1_SMCR_ETPS                              \ ETPS
$00004000 constant TIM1_TIM1_SMCR_ECE                               \ ECE
$00008000 constant TIM1_TIM1_SMCR_ETP                               \ ETP
$00010000 constant TIM1_TIM1_SMCR_SMS3                              \ SMS3
$00100000 constant TIM1_TIM1_SMCR_TS3                               \ TS3
$00200000 constant TIM1_TIM1_SMCR_TS4                               \ TS4


\
\ @brief TIM1 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_DIER_UIE                               \ UIE
$00000002 constant TIM1_TIM1_DIER_CC1IE                             \ CC1IE
$00000004 constant TIM1_TIM1_DIER_CC2IE                             \ CC2IE
$00000008 constant TIM1_TIM1_DIER_CC3IE                             \ CC3IE
$00000010 constant TIM1_TIM1_DIER_CC4IE                             \ CC4IE
$00000020 constant TIM1_TIM1_DIER_COMIE                             \ COMIE
$00000040 constant TIM1_TIM1_DIER_TIE                               \ TIE
$00000080 constant TIM1_TIM1_DIER_BIE                               \ BIE
$00000100 constant TIM1_TIM1_DIER_UDE                               \ UDE
$00000200 constant TIM1_TIM1_DIER_CC1DE                             \ CC1DE
$00000400 constant TIM1_TIM1_DIER_CC2DE                             \ CC2DE
$00000800 constant TIM1_TIM1_DIER_CC3DE                             \ CC3DE
$00001000 constant TIM1_TIM1_DIER_CC4DE                             \ CC4DE
$00002000 constant TIM1_TIM1_DIER_COMDE                             \ COMDE
$00004000 constant TIM1_TIM1_DIER_TDE                               \ TDE


\
\ @brief TIM1 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_SR_UIF                                 \ UIF
$00000002 constant TIM1_TIM1_SR_CC1IF                               \ CC1IF
$00000004 constant TIM1_TIM1_SR_CC2IF                               \ CC2IF
$00000008 constant TIM1_TIM1_SR_CC3IF                               \ CC3IF
$00000010 constant TIM1_TIM1_SR_CC4IF                               \ CC4IF
$00000020 constant TIM1_TIM1_SR_COMIF                               \ COMIF
$00000040 constant TIM1_TIM1_SR_TIF                                 \ TIF
$00000080 constant TIM1_TIM1_SR_BIF                                 \ BIF
$00000100 constant TIM1_TIM1_SR_B2IF                                \ B2IF
$00000200 constant TIM1_TIM1_SR_CC1OF                               \ CC1OF
$00000400 constant TIM1_TIM1_SR_CC2OF                               \ CC2OF
$00000800 constant TIM1_TIM1_SR_CC3OF                               \ CC3OF
$00001000 constant TIM1_TIM1_SR_CC4OF                               \ CC4OF
$00002000 constant TIM1_TIM1_SR_SBIF                                \ SBIF
$00010000 constant TIM1_TIM1_SR_CC5IF                               \ CC5IF
$00020000 constant TIM1_TIM1_SR_CC6IF                               \ CC6IF


\
\ @brief TIM1 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_EGR_UG                                 \ UG
$00000002 constant TIM1_TIM1_EGR_CC1G                               \ CC1G
$00000004 constant TIM1_TIM1_EGR_CC2G                               \ CC2G
$00000008 constant TIM1_TIM1_EGR_CC3G                               \ CC3G
$00000010 constant TIM1_TIM1_EGR_CC4G                               \ CC4G
$00000020 constant TIM1_TIM1_EGR_COMG                               \ COMG
$00000040 constant TIM1_TIM1_EGR_TG                                 \ TG
$00000080 constant TIM1_TIM1_EGR_BG                                 \ BG
$00000100 constant TIM1_TIM1_EGR_B2G                                \ B2G


\
\ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM1_TIM1_CCMR1ALTERNATE1_CC1S                   \ CC1S
$0000000c constant TIM1_TIM1_CCMR1ALTERNATE1_IC1PSC                 \ IC1PSC
$000000f0 constant TIM1_TIM1_CCMR1ALTERNATE1_IC1F                   \ IC1F
$00000300 constant TIM1_TIM1_CCMR1ALTERNATE1_CC2S                   \ CC2S
$00000c00 constant TIM1_TIM1_CCMR1ALTERNATE1_IC2PSC                 \ IC2PSC
$0000f000 constant TIM1_TIM1_CCMR1ALTERNATE1_IC2F                   \ IC2F


\
\ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM1_TIM1_CCMR2ALTERNATE17_CC3S                  \ CC3S
$0000000c constant TIM1_TIM1_CCMR2ALTERNATE17_IC3PSC                \ IC3PSC
$000000f0 constant TIM1_TIM1_CCMR2ALTERNATE17_IC3F                  \ IC3F
$00000300 constant TIM1_TIM1_CCMR2ALTERNATE17_CC4S                  \ CC4S
$00000c00 constant TIM1_TIM1_CCMR2ALTERNATE17_IC4PSC                \ IC4PSC
$0000f000 constant TIM1_TIM1_CCMR2ALTERNATE17_IC4F                  \ IC4F


\
\ @brief TIM1 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_CCER_CC1E                              \ CC1E
$00000002 constant TIM1_TIM1_CCER_CC1P                              \ CC1P
$00000004 constant TIM1_TIM1_CCER_CC1NE                             \ CC1NE
$00000008 constant TIM1_TIM1_CCER_CC1NP                             \ CC1NP
$00000010 constant TIM1_TIM1_CCER_CC2E                              \ CC2E
$00000020 constant TIM1_TIM1_CCER_CC2P                              \ CC2P
$00000040 constant TIM1_TIM1_CCER_CC2NE                             \ CC2NE
$00000080 constant TIM1_TIM1_CCER_CC2NP                             \ CC2NP
$00000100 constant TIM1_TIM1_CCER_CC3E                              \ CC3E
$00000200 constant TIM1_TIM1_CCER_CC3P                              \ CC3P
$00000400 constant TIM1_TIM1_CCER_CC3NE                             \ CC3NE
$00000800 constant TIM1_TIM1_CCER_CC3NP                             \ CC3NP
$00001000 constant TIM1_TIM1_CCER_CC4E                              \ CC4E
$00002000 constant TIM1_TIM1_CCER_CC4P                              \ CC4P
$00008000 constant TIM1_TIM1_CCER_CC4NP                             \ CC4NP
$00010000 constant TIM1_TIM1_CCER_CC5E                              \ CC5E
$00020000 constant TIM1_TIM1_CCER_CC5P                              \ CC5P
$00100000 constant TIM1_TIM1_CCER_CC6E                              \ CC6E
$00200000 constant TIM1_TIM1_CCER_CC6P                              \ CC6P


\
\ @brief TIM1 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CNT_CNT                                \ CNT
$80000000 constant TIM1_TIM1_CNT_UIFCPY                             \ UIFCPY


\
\ @brief TIM1 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_PSC_PSC                                \ PSC


\
\ @brief TIM1 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM1_TIM1_ARR_ARR                                \ ARR


\
\ @brief TIM1 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_RCR_REP                                \ REP


\
\ @brief TIM1 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR1_CCR1                              \ CCR1


\
\ @brief TIM1 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR2_CCR2                              \ CCR2


\
\ @brief TIM1 capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR3_CCR3                              \ CCR3


\
\ @brief TIM1 capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR4_CCR4                              \ CCR4


\
\ @brief As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM1_TIM1_BDTR_DTG                               \ DTG
$00000300 constant TIM1_TIM1_BDTR_LOCK                              \ LOCK
$00000400 constant TIM1_TIM1_BDTR_OSSI                              \ OSSI
$00000800 constant TIM1_TIM1_BDTR_OSSR                              \ OSSR
$00001000 constant TIM1_TIM1_BDTR_BKE                               \ BKE
$00002000 constant TIM1_TIM1_BDTR_BKP                               \ BKP
$00004000 constant TIM1_TIM1_BDTR_AOE                               \ AOE
$00008000 constant TIM1_TIM1_BDTR_MOE                               \ MOE
$000f0000 constant TIM1_TIM1_BDTR_BKF                               \ BKF
$00f00000 constant TIM1_TIM1_BDTR_BK2F                              \ BK2F
$01000000 constant TIM1_TIM1_BDTR_BK2E                              \ BK2E
$02000000 constant TIM1_TIM1_BDTR_BK2P                              \ BK2P
$04000000 constant TIM1_TIM1_BDTR_BKDSRM                            \ BKDSRM
$08000000 constant TIM1_TIM1_BDTR_BK2DSRM                           \ BK2DSRM
$10000000 constant TIM1_TIM1_BDTR_BKBID                             \ BKBID
$20000000 constant TIM1_TIM1_BDTR_BK2BID                            \ BK2BID


\
\ @brief TIM1 DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM1_TIM1_DCR_DBA                                \ DBA
$00001f00 constant TIM1_TIM1_DCR_DBL                                \ DBL


\
\ @brief TIM1 DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant TIM1_TIM1_DMAR_DMAB                              \ DMAB


\
\ @brief The channels 5 and 6 can only be configured in output. Output compare mode:
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000004 constant TIM1_TIM1_CCMR3_OC5FE                            \ OC5FE
$00000008 constant TIM1_TIM1_CCMR3_OC5PE                            \ OC5PE
$00000070 constant TIM1_TIM1_CCMR3_OC5M                             \ OC5M
$00000080 constant TIM1_TIM1_CCMR3_OC5CE                            \ OC5CE
$00000400 constant TIM1_TIM1_CCMR3_OC6FE                            \ OC6FE
$00000800 constant TIM1_TIM1_CCMR3_OC6PE                            \ OC6PE
$00007000 constant TIM1_TIM1_CCMR3_OC6M                             \ OC6M
$00008000 constant TIM1_TIM1_CCMR3_OC6CE                            \ OC6CE
$00010000 constant TIM1_TIM1_CCMR3_OC5M3                            \ OC5M3
$01000000 constant TIM1_TIM1_CCMR3_OC6M3                            \ OC6M3


\
\ @brief TIM1 capture/compare register 5
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR5_CCR5                              \ CCR5
$20000000 constant TIM1_TIM1_CCR5_GC5C1                             \ GC5C1
$40000000 constant TIM1_TIM1_CCR5_GC5C2                             \ GC5C2
$80000000 constant TIM1_TIM1_CCR5_GC5C3                             \ GC5C3


\
\ @brief TIM1 capture/compare register 6
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR6_CCR6                              \ CCR6


\
\ @brief TIM1 alternate function option register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM1_TIM1_AF1_BKINE                              \ BKINE
$00000100 constant TIM1_TIM1_AF1_BKDF1BK0E                          \ BKDF1BK0E
$00000200 constant TIM1_TIM1_AF1_BKINP                              \ BKINP
$0003c000 constant TIM1_TIM1_AF1_ETRSEL                             \ ETRSEL


\
\ @brief TIM1 Alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000001
\

$00000001 constant TIM1_TIM1_AF2_BK2INE                             \ BK2INE
$00000100 constant TIM1_TIM1_AF2_BK2DF1BK1E                         \ BK2DF1BK1E
$00000200 constant TIM1_TIM1_AF2_BK2INP                             \ BK2INP


\
\ @brief TIM1 timer input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM1_TIM1_TISEL_TI1SEL                           \ TI1SEL
$00000f00 constant TIM1_TIM1_TISEL_TI2SEL                           \ TI2SEL
$000f0000 constant TIM1_TIM1_TISEL_TI3SEL                           \ TI3SEL
$0f000000 constant TIM1_TIM1_TISEL_TI4SEL                           \ TI4SEL


\
\ @brief TIM1
\
$44000000 constant TIM1_TIM1_CR1  \ offset: 0x00 : TIM1 control register 1
$44000004 constant TIM1_TIM1_CR2  \ offset: 0x04 : TIM1 control register 2
$44000008 constant TIM1_TIM1_SMCR  \ offset: 0x08 : TIM1 slave mode control register
$4400000c constant TIM1_TIM1_DIER  \ offset: 0x0C : TIM1 DMA/interrupt enable register
$44000010 constant TIM1_TIM1_SR   \ offset: 0x10 : TIM1 status register
$44000014 constant TIM1_TIM1_EGR  \ offset: 0x14 : TIM1 event generation register
$44000018 constant TIM1_TIM1_CCMR1ALTERNATE1  \ offset: 0x18 : The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
$4400001c constant TIM1_TIM1_CCMR2ALTERNATE17  \ offset: 0x1C : The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
$44000020 constant TIM1_TIM1_CCER  \ offset: 0x20 : TIM1 capture/compare enable register
$44000024 constant TIM1_TIM1_CNT  \ offset: 0x24 : TIM1 counter
$44000028 constant TIM1_TIM1_PSC  \ offset: 0x28 : TIM1 prescaler
$4400002c constant TIM1_TIM1_ARR  \ offset: 0x2C : TIM1 auto-reload register
$44000030 constant TIM1_TIM1_RCR  \ offset: 0x30 : TIM1 repetition counter register
$44000034 constant TIM1_TIM1_CCR1  \ offset: 0x34 : TIM1 capture/compare register 1
$44000038 constant TIM1_TIM1_CCR2  \ offset: 0x38 : TIM1 capture/compare register 2
$4400003c constant TIM1_TIM1_CCR3  \ offset: 0x3C : TIM1 capture/compare register 3
$44000040 constant TIM1_TIM1_CCR4  \ offset: 0x40 : TIM1 capture/compare register 4
$44000044 constant TIM1_TIM1_BDTR  \ offset: 0x44 : As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
$44000048 constant TIM1_TIM1_DCR  \ offset: 0x48 : TIM1 DMA control register
$4400004c constant TIM1_TIM1_DMAR  \ offset: 0x4C : TIM1 DMA address for full transfer
$44000054 constant TIM1_TIM1_CCMR3  \ offset: 0x54 : The channels 5 and 6 can only be configured in output. Output compare mode:
$44000058 constant TIM1_TIM1_CCR5  \ offset: 0x58 : TIM1 capture/compare register 5
$4400005c constant TIM1_TIM1_CCR6  \ offset: 0x5C : TIM1 capture/compare register 6
$44000060 constant TIM1_TIM1_AF1  \ offset: 0x60 : TIM1 alternate function option register 1
$44000064 constant TIM1_TIM1_AF2  \ offset: 0x64 : TIM1 Alternate function register 2
$44000068 constant TIM1_TIM1_TISEL  \ offset: 0x68 : TIM1 timer input selection register

