\
\ @file tim2.fs
\ @brief TIM2
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM2 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM2_TIM2_CR1_CEN                                \ CEN
$00000002 constant TIM2_TIM2_CR1_UDIS                               \ UDIS
$00000004 constant TIM2_TIM2_CR1_URS                                \ URS
$00000008 constant TIM2_TIM2_CR1_OPM                                \ OPM
$00000010 constant TIM2_TIM2_CR1_DIR                                \ DIR
$00000060 constant TIM2_TIM2_CR1_CMS                                \ CMS
$00000080 constant TIM2_TIM2_CR1_ARPE                               \ ARPE
$00000300 constant TIM2_TIM2_CR1_CKD                                \ CKD
$00000800 constant TIM2_TIM2_CR1_UIFREMAP                           \ UIFREMAP


\
\ @brief TIM2 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM2_TIM2_CR2_CCPC                               \ CCPC
$00000004 constant TIM2_TIM2_CR2_CCUS                               \ CCUS
$00000008 constant TIM2_TIM2_CR2_CCDS                               \ CCDS
$00000070 constant TIM2_TIM2_CR2_MMS                                \ MMS
$00000080 constant TIM2_TIM2_CR2_TI1S                               \ TI1S
$00000100 constant TIM2_TIM2_CR2_OIS1                               \ OIS1
$00000200 constant TIM2_TIM2_CR2_OIS1N                              \ OIS1N
$00000400 constant TIM2_TIM2_CR2_OIS2                               \ OIS2
$00000800 constant TIM2_TIM2_CR2_OIS2N                              \ OIS2N
$00001000 constant TIM2_TIM2_CR2_OIS3                               \ OIS3
$00002000 constant TIM2_TIM2_CR2_OIS3N                              \ OIS3N
$00004000 constant TIM2_TIM2_CR2_OIS4                               \ OIS4
$00010000 constant TIM2_TIM2_CR2_OIS5                               \ OIS5
$00040000 constant TIM2_TIM2_CR2_OIS6                               \ OIS6
$00f00000 constant TIM2_TIM2_CR2_MMS2                               \ MMS2


\
\ @brief TIM2 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM2_TIM2_SMCR_SMS                               \ SMS
$00000070 constant TIM2_TIM2_SMCR_TS                                \ TS
$00000080 constant TIM2_TIM2_SMCR_MSM                               \ MSM
$00000f00 constant TIM2_TIM2_SMCR_ETF                               \ ETF
$00003000 constant TIM2_TIM2_SMCR_ETPS                              \ ETPS
$00004000 constant TIM2_TIM2_SMCR_ECE                               \ ECE
$00008000 constant TIM2_TIM2_SMCR_ETP                               \ ETP
$00010000 constant TIM2_TIM2_SMCR_SMS3                              \ SMS3
$00100000 constant TIM2_TIM2_SMCR_TS3                               \ TS3
$00200000 constant TIM2_TIM2_SMCR_TS4                               \ TS4


\
\ @brief TIM2 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM2_TIM2_DIER_UIE                               \ UIE
$00000002 constant TIM2_TIM2_DIER_CC1IE                             \ CC1IE
$00000004 constant TIM2_TIM2_DIER_CC2IE                             \ CC2IE
$00000008 constant TIM2_TIM2_DIER_CC3IE                             \ CC3IE
$00000010 constant TIM2_TIM2_DIER_CC4IE                             \ CC4IE
$00000020 constant TIM2_TIM2_DIER_COMIE                             \ COMIE
$00000040 constant TIM2_TIM2_DIER_TIE                               \ TIE
$00000080 constant TIM2_TIM2_DIER_BIE                               \ BIE
$00000100 constant TIM2_TIM2_DIER_UDE                               \ UDE
$00000200 constant TIM2_TIM2_DIER_CC1DE                             \ CC1DE
$00000400 constant TIM2_TIM2_DIER_CC2DE                             \ CC2DE
$00000800 constant TIM2_TIM2_DIER_CC3DE                             \ CC3DE
$00001000 constant TIM2_TIM2_DIER_CC4DE                             \ CC4DE
$00002000 constant TIM2_TIM2_DIER_COMDE                             \ COMDE
$00004000 constant TIM2_TIM2_DIER_TDE                               \ TDE


\
\ @brief TIM2 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM2_TIM2_SR_UIF                                 \ UIF
$00000002 constant TIM2_TIM2_SR_CC1IF                               \ CC1IF
$00000004 constant TIM2_TIM2_SR_CC2IF                               \ CC2IF
$00000008 constant TIM2_TIM2_SR_CC3IF                               \ CC3IF
$00000010 constant TIM2_TIM2_SR_CC4IF                               \ CC4IF
$00000020 constant TIM2_TIM2_SR_COMIF                               \ COMIF
$00000040 constant TIM2_TIM2_SR_TIF                                 \ TIF
$00000080 constant TIM2_TIM2_SR_BIF                                 \ BIF
$00000100 constant TIM2_TIM2_SR_B2IF                                \ B2IF
$00000200 constant TIM2_TIM2_SR_CC1OF                               \ CC1OF
$00000400 constant TIM2_TIM2_SR_CC2OF                               \ CC2OF
$00000800 constant TIM2_TIM2_SR_CC3OF                               \ CC3OF
$00001000 constant TIM2_TIM2_SR_CC4OF                               \ CC4OF
$00002000 constant TIM2_TIM2_SR_SBIF                                \ SBIF
$00010000 constant TIM2_TIM2_SR_CC5IF                               \ CC5IF
$00020000 constant TIM2_TIM2_SR_CC6IF                               \ CC6IF


\
\ @brief TIM2 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM2_TIM2_EGR_UG                                 \ UG
$00000002 constant TIM2_TIM2_EGR_CC1G                               \ CC1G
$00000004 constant TIM2_TIM2_EGR_CC2G                               \ CC2G
$00000008 constant TIM2_TIM2_EGR_CC3G                               \ CC3G
$00000010 constant TIM2_TIM2_EGR_CC4G                               \ CC4G
$00000020 constant TIM2_TIM2_EGR_COMG                               \ COMG
$00000040 constant TIM2_TIM2_EGR_TG                                 \ TG
$00000080 constant TIM2_TIM2_EGR_BG                                 \ BG
$00000100 constant TIM2_TIM2_EGR_B2G                                \ B2G


\
\ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM2_TIM2_CCMR1_OUTPUT_CC1S                      \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
$00000004 constant TIM2_TIM2_CCMR1_OUTPUT_OC1FE                     \ Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
$00000008 constant TIM2_TIM2_CCMR1_OUTPUT_OC1PE                     \ Output compare 1 preload enable Note: The PWM mode can be used without validating the preload register only in one-pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
$00000070 constant TIM2_TIM2_CCMR1_OUTPUT_OC1M1                     \ Output compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from âfrozenâ mode to âPWMâ mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
$00000080 constant TIM2_TIM2_CCMR1_OUTPUT_OC1CE                     \ Output compare 1 clear enable
$00000300 constant TIM2_TIM2_CCMR1_OUTPUT_CC2S                      \ Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
$00000400 constant TIM2_TIM2_CCMR1_OUTPUT_OC2FE                     \ Output compare 2 fast enable
$00000800 constant TIM2_TIM2_CCMR1_OUTPUT_OC2PE                     \ Output compare 2 preload enable
$00007000 constant TIM2_TIM2_CCMR1_OUTPUT_OC2M1                     \ Output compare 2 mode refer to OC1M description on bits 6:4
$00008000 constant TIM2_TIM2_CCMR1_OUTPUT_OC2CE                     \ Output compare 2 clear enable
$00010000 constant TIM2_TIM2_CCMR1_OUTPUT_OC1M2                     \ Output compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from âfrozenâ mode to âPWMâ mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
$01000000 constant TIM2_TIM2_CCMR1_OUTPUT_OC2M2                     \ Output compare 2 mode refer to OC1M description on bits 6:4


\
\ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM2_TIM2_CCMR1_INPUT_CC1S                       \ CC1S
$0000000c constant TIM2_TIM2_CCMR1_INPUT_IC1PSC                     \ IC1PSC
$000000f0 constant TIM2_TIM2_CCMR1_INPUT_IC1F                       \ IC1F
$00000300 constant TIM2_TIM2_CCMR1_INPUT_CC2S                       \ CC2S
$00000c00 constant TIM2_TIM2_CCMR1_INPUT_IC2PSC                     \ IC2PSC
$0000f000 constant TIM2_TIM2_CCMR1_INPUT_IC2F                       \ IC2F


\
\ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM2_TIM2_CCMR2_OUTPUT_CC3S                      \ Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
$00000004 constant TIM2_TIM2_CCMR2_OUTPUT_OC3FE                     \ Output compare 3 fast enable
$00000008 constant TIM2_TIM2_CCMR2_OUTPUT_OC3PE                     \ Output compare 3 preload enable
$00000070 constant TIM2_TIM2_CCMR2_OUTPUT_OC3M1                     \ Output compare 3 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
$00000080 constant TIM2_TIM2_CCMR2_OUTPUT_OC3CE                     \ Output compare 3 clear enable
$00000300 constant TIM2_TIM2_CCMR2_OUTPUT_CC4S                      \ Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
$00000400 constant TIM2_TIM2_CCMR2_OUTPUT_OC4FE                     \ Output compare 4 fast enable
$00000800 constant TIM2_TIM2_CCMR2_OUTPUT_OC4PE                     \ Output compare 4 preload enable
$00007000 constant TIM2_TIM2_CCMR2_OUTPUT_OC4M1                     \ Output compare 4 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
$00008000 constant TIM2_TIM2_CCMR2_OUTPUT_OC4CE                     \ Output compare 4 clear enable
$00010000 constant TIM2_TIM2_CCMR2_OUTPUT_OC3M2                     \ Output compare 3 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
$01000000 constant TIM2_TIM2_CCMR2_OUTPUT_OC4M2                     \ Output compare 4 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)


\
\ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM2_TIM2_CCMR2_INTPUT_CC3S                      \ CC3S
$0000000c constant TIM2_TIM2_CCMR2_INTPUT_IC3PSC                    \ IC3PSC
$000000f0 constant TIM2_TIM2_CCMR2_INTPUT_IC3F                      \ IC3F
$00000300 constant TIM2_TIM2_CCMR2_INTPUT_CC4S                      \ CC4S
$00000c00 constant TIM2_TIM2_CCMR2_INTPUT_IC4PSC                    \ IC4PSC
$0000f000 constant TIM2_TIM2_CCMR2_INTPUT_IC4F                      \ IC4F


\
\ @brief TIM2 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM2_TIM2_CCER_CC1E                              \ CC1E
$00000002 constant TIM2_TIM2_CCER_CC1P                              \ CC1P
$00000004 constant TIM2_TIM2_CCER_CC1NE                             \ CC1NE
$00000008 constant TIM2_TIM2_CCER_CC1NP                             \ CC1NP
$00000010 constant TIM2_TIM2_CCER_CC2E                              \ CC2E
$00000020 constant TIM2_TIM2_CCER_CC2P                              \ CC2P
$00000040 constant TIM2_TIM2_CCER_CC2NE                             \ CC2NE
$00000080 constant TIM2_TIM2_CCER_CC2NP                             \ CC2NP
$00000100 constant TIM2_TIM2_CCER_CC3E                              \ CC3E
$00000200 constant TIM2_TIM2_CCER_CC3P                              \ CC3P
$00000400 constant TIM2_TIM2_CCER_CC3NE                             \ CC3NE
$00000800 constant TIM2_TIM2_CCER_CC3NP                             \ CC3NP
$00001000 constant TIM2_TIM2_CCER_CC4E                              \ CC4E
$00002000 constant TIM2_TIM2_CCER_CC4P                              \ CC4P
$00008000 constant TIM2_TIM2_CCER_CC4NP                             \ CC4NP
$00010000 constant TIM2_TIM2_CCER_CC5E                              \ CC5E
$00020000 constant TIM2_TIM2_CCER_CC5P                              \ CC5P
$00100000 constant TIM2_TIM2_CCER_CC6E                              \ CC6E
$00200000 constant TIM2_TIM2_CCER_CC6P                              \ CC6P


\
\ @brief TIM2 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM2_TIM2_CNT_CNT                                \ CNT
$80000000 constant TIM2_TIM2_CNT_UIFCPY                             \ UIFCPY


\
\ @brief TIM2 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM2_TIM2_PSC_PSC                                \ PSC


\
\ @brief TIM2 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM2_TIM2_ARR_ARR                                \ ARR


\
\ @brief TIM2 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM2_TIM2_CCR1_CCR1                              \ CCR1


\
\ @brief TIM2 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM2_TIM2_CCR2_CCR2                              \ CCR2


\
\ @brief TIM2 capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant TIM2_TIM2_CCR3_CCR3                              \ CCR3


\
\ @brief TIM2 capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant TIM2_TIM2_CCR4_CCR4                              \ CCR4


\
\ @brief TIM2 DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM2_TIM2_DCR_DBA                                \ DBA
$00001f00 constant TIM2_TIM2_DCR_DBL                                \ DBL


\
\ @brief TIM2 DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant TIM2_TIM2_DMAR_DMAB                              \ DMAB


\
\ @brief ETR source selection These bits select the ETR input source. Others: Reserved Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$0003c000 constant TIM2_TIM2_AF1_ETRSEL                             \ ETR source selection These bits select the ETR input source. Others: Reserved Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief selects TI1[0] to TI1[15] input Others: Reserved
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM2_TIM8_TISEL_TI1SEL                           \ selects TI1[0] to TI1[15] input Others: Reserved
$00000f00 constant TIM2_TIM8_TISEL_TI2SEL                           \ selects TI2[0] to TI2[15] input Others: Reserved
$000f0000 constant TIM2_TIM8_TISEL_TI3SEL                           \ selects TI3[0] to TI3[15] input Others: Reserved
$0f000000 constant TIM2_TIM8_TISEL_TI4SEL                           \ selects TI4[0] to TI4[15] input Others: Reserved


\
\ @brief TIM2
\
$40000000 constant TIM2_TIM2_CR1  \ offset: 0x00 : TIM2 control register 1
$40000004 constant TIM2_TIM2_CR2  \ offset: 0x04 : TIM2 control register 2
$40000008 constant TIM2_TIM2_SMCR  \ offset: 0x08 : TIM2 slave mode control register
$4000000c constant TIM2_TIM2_DIER  \ offset: 0x0C : TIM2 DMA/interrupt enable register
$40000010 constant TIM2_TIM2_SR   \ offset: 0x10 : TIM2 status register
$40000014 constant TIM2_TIM2_EGR  \ offset: 0x14 : TIM2 event generation register
$40000018 constant TIM2_TIM2_CCMR1_OUTPUT  \ offset: 0x18 : The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
$40000018 constant TIM2_TIM2_CCMR1_INPUT  \ offset: 0x18 : The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
$4000001c constant TIM2_TIM2_CCMR2_OUTPUT  \ offset: 0x1C : The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
$4000001c constant TIM2_TIM2_CCMR2_INTPUT  \ offset: 0x1C : The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
$40000020 constant TIM2_TIM2_CCER  \ offset: 0x20 : TIM2 capture/compare enable register
$40000024 constant TIM2_TIM2_CNT  \ offset: 0x24 : TIM2 counter
$40000028 constant TIM2_TIM2_PSC  \ offset: 0x28 : TIM2 prescaler
$4000002c constant TIM2_TIM2_ARR  \ offset: 0x2C : TIM2 auto-reload register
$40000034 constant TIM2_TIM2_CCR1  \ offset: 0x34 : TIM2 capture/compare register 1
$40000038 constant TIM2_TIM2_CCR2  \ offset: 0x38 : TIM2 capture/compare register 2
$4000003c constant TIM2_TIM2_CCR3  \ offset: 0x3C : TIM2 capture/compare register 3
$40000040 constant TIM2_TIM2_CCR4  \ offset: 0x40 : TIM2 capture/compare register 4
$40000048 constant TIM2_TIM2_DCR  \ offset: 0x48 : TIM2 DMA control register
$4000004c constant TIM2_TIM2_DMAR  \ offset: 0x4C : TIM2 DMA address for full transfer
$40000060 constant TIM2_TIM2_AF1  \ offset: 0x60 : ETR source selection These bits select the ETR input source. Others: Reserved Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$40000068 constant TIM2_TIM8_TISEL  \ offset: 0x68 : selects TI1[0] to TI1[15] input Others: Reserved

