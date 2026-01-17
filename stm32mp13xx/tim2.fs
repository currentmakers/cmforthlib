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


  [ifdef] TIM2_TIM2_CCMR1_output_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM2_OC1FE                     \ [0x02] Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM2_OC1PE                     \ [0x03] Output compare 1 preload enable Note: The PWM mode can be used without validating the preload register only in one-pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
    $04 constant TIM2_OC1M1                     \ [0x04 : 3] Output compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from âfrozenâ mode to âPWMâ mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
    $07 constant TIM2_OC1CE                     \ [0x07] Output compare 1 clear enable
    $08 constant TIM2_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM2_OC2FE                     \ [0x0a] Output compare 2 fast enable
    $0b constant TIM2_OC2PE                     \ [0x0b] Output compare 2 preload enable
    $0c constant TIM2_OC2M1                     \ [0x0c : 3] Output compare 2 mode refer to OC1M description on bits 6:4
    $0f constant TIM2_OC2CE                     \ [0x0f] Output compare 2 clear enable
    $10 constant TIM2_OC1M2                     \ [0x10] Output compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from âfrozenâ mode to âPWMâ mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
    $18 constant TIM2_OC2M2                     \ [0x18] Output compare 2 mode refer to OC1M description on bits 6:4
  [then]


  [ifdef] TIM2_TIM2_CCMR1_input_DEF
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


  [ifdef] TIM2_TIM2_CCMR2_output_DEF
    \
    \ @brief The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
    $02 constant TIM2_OC3FE                     \ [0x02] Output compare 3 fast enable
    $03 constant TIM2_OC3PE                     \ [0x03] Output compare 3 preload enable
    $04 constant TIM2_OC3M1                     \ [0x04 : 3] Output compare 3 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
    $07 constant TIM2_OC3CE                     \ [0x07] Output compare 3 clear enable
    $08 constant TIM2_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
    $0a constant TIM2_OC4FE                     \ [0x0a] Output compare 4 fast enable
    $0b constant TIM2_OC4PE                     \ [0x0b] Output compare 4 preload enable
    $0c constant TIM2_OC4M1                     \ [0x0c : 3] Output compare 4 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
    $0f constant TIM2_OC4CE                     \ [0x0f] Output compare 4 clear enable
    $10 constant TIM2_OC3M2                     \ [0x10] Output compare 3 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
    $18 constant TIM2_OC4M2                     \ [0x18] Output compare 4 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
  [then]


  [ifdef] TIM2_TIM2_CCMR2_intput_DEF
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


  [ifdef] TIM2_TIM2_AF1_DEF
    \
    \ @brief ETR source selection These bits select the ETR input source. Others: Reserved Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $0e constant TIM2_ETRSEL                    \ [0x0e : 4] ETR source selection These bits select the ETR input source. Others: Reserved Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM2_TIM8_TISEL_DEF
    \
    \ @brief selects TI1[0] to TI1[15] input Others: Reserved
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_TI1SEL                    \ [0x00 : 4] selects TI1[0] to TI1[15] input Others: Reserved
    $08 constant TIM2_TI2SEL                    \ [0x08 : 4] selects TI2[0] to TI2[15] input Others: Reserved
    $10 constant TIM2_TI3SEL                    \ [0x10 : 4] selects TI3[0] to TI3[15] input Others: Reserved
    $18 constant TIM2_TI4SEL                    \ [0x18 : 4] selects TI4[0] to TI4[15] input Others: Reserved
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
  $18 constant TIM2_TIM2_CCMR1_OUTPUT   \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $18 constant TIM2_TIM2_CCMR1_INPUT    \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $1C constant TIM2_TIM2_CCMR2_OUTPUT   \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $1C constant TIM2_TIM2_CCMR2_INTPUT   \ The same register can be used for input capture mode (this section) or for output compare mode (next section). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function for input capture and for output compare modes. It is possible to combine both modes independently (e.g. channel 1 in input capture mode and channel 2 in output compare mode). Input capture mode:
  $20 constant TIM2_TIM2_CCER           \ TIM2 capture/compare enable register
  $24 constant TIM2_TIM2_CNT            \ TIM2 counter
  $28 constant TIM2_TIM2_PSC            \ TIM2 prescaler
  $2C constant TIM2_TIM2_ARR            \ TIM2 auto-reload register
  $34 constant TIM2_TIM2_CCR1           \ TIM2 capture/compare register 1
  $38 constant TIM2_TIM2_CCR2           \ TIM2 capture/compare register 2
  $3C constant TIM2_TIM2_CCR3           \ TIM2 capture/compare register 3
  $40 constant TIM2_TIM2_CCR4           \ TIM2 capture/compare register 4
  $48 constant TIM2_TIM2_DCR            \ TIM2 DMA control register
  $4C constant TIM2_TIM2_DMAR           \ TIM2 DMA address for full transfer
  $60 constant TIM2_TIM2_AF1            \ ETR source selection These bits select the ETR input source. Others: Reserved Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
  $68 constant TIM2_TIM8_TISEL          \ selects TI1[0] to TI1[15] input Others: Reserved

: TIM2_DEF ; [then]
