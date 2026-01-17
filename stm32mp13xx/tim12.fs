\
\ @file tim12.fs
\ @brief TIM register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM12_DEF

  [ifdef] TIM12_TIM12_CR1_DEF
    \
    \ @brief TIM12 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CEN                      \ [0x00] Counter enable CEN is cleared automatically in one-pulse mode, when an update event occurs. Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
    $01 constant TIM12_UDIS                     \ [0x01] Update disable This bit is set and cleared by software to enable/disable update event (UEV) generation. Counter overflow Setting the UG bit Buffered registers are then loaded with their preload values.
    $02 constant TIM12_URS                      \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM12_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM12_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM12_CKD                      \ [0x08 : 2] Clock division This bit-field indicates the division ratio between the timer clock (CK_INT) frequency and sampling clock used by the digital filters (TIx),
    $0b constant TIM12_UIFREMAP                 \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM12_TIM12_CR2_DEF
    \
    \ @brief TIM12 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM12_MMS                      \ [0x04 : 3] Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows:
    $07 constant TIM12_TI1S                     \ [0x07] TI1 selection
  [then]


  [ifdef] TIM12_TIM12_SMCR_DEF
    \
    \ @brief TIM12 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_SMS1                     \ [0x00 : 3] Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Other codes: reserved. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS=â00100â). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave timer must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
    $04 constant TIM12_TS1                      \ [0x04 : 3] Trigger selection This TS[4:0] bitfield selects the trigger input to be used to synchronize the counter. Others: Reserved See for more details on the meaning of ITRx for each timer. Note: These bits must be changed only when they are not used (e.g. when SMS=â000â) to avoid wrong edge detections at the transition.
    $07 constant TIM12_MSM                      \ [0x07] Master/Slave mode
    $10 constant TIM12_SMS2                     \ [0x10] Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Other codes: reserved. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS=â00100â). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave timer must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
    $14 constant TIM12_TS2                      \ [0x14 : 2] Trigger selection This TS[4:0] bitfield selects the trigger input to be used to synchronize the counter. Others: Reserved See for more details on the meaning of ITRx for each timer. Note: These bits must be changed only when they are not used (e.g. when SMS=â000â) to avoid wrong edge detections at the transition.
  [then]


  [ifdef] TIM12_TIM12_DIER_DEF
    \
    \ @brief TIM12 Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM12_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM12_CC2IE                    \ [0x02] Capture/Compare 2 interrupt enable
    $06 constant TIM12_TIE                      \ [0x06] Trigger interrupt enable
  [then]


  [ifdef] TIM12_TIM12_SR_DEF
    \
    \ @brief TIM12 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UIF                      \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow and if UDIS=â0â in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=â0â and UDIS=â0â in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to the synchro control register description), if URS=â0â and UDIS=â0â in the TIMx_CR1 register.
    $01 constant TIM12_CC1IF                    \ [0x01] Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when he content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $02 constant TIM12_CC2IF                    \ [0x02] Capture/Compare 2 interrupt flag refer to CC1IF description
    $06 constant TIM12_TIF                      \ [0x06] Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on TRGI input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
    $09 constant TIM12_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0â.
    $0a constant TIM12_CC2OF                    \ [0x0a] Capture/compare 2 overcapture flag refer to CC1OF description
  [then]


  [ifdef] TIM12_TIM12_EGR_DEF
    \
    \ @brief TIM12 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UG                       \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM12_CC1G                     \ [0x01] Capture/compare 1 generation This bit is set by software to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: the CC1IF flag is set, the corresponding interrupt is sent if enabled. If channel CC1 is configured as input: The current counter value is captured in the TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $02 constant TIM12_CC2G                     \ [0x02] Capture/compare 2 generation refer to CC1G description
    $06 constant TIM12_TG                       \ [0x06] Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM12_TIM12_CCMR1_Output_DEF
    \
    \ @brief TIM12 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bitfield defines the direction of the channel (input/output) as well as the used input. Note: The CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM12_OC1FE                    \ [0x02] Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM12_OC1PE                    \ [0x03] Output compare 1 preload enable Note: The PWM mode can be used without validating the preload register only in one-pulse mode (OPM bit set in the TIMx_CR1 register). Else the behavior is not guaranteed.
    $04 constant TIM12_OC1M1                    \ [0x04 : 3] Output compare 1 mode (refer to bit 16 for OC1M[3]) These bits define the behavior of the output reference signal OC1REF from which OC1 is derived. OC1REF is active high whereas the active level of OC1 depends on the CC1P. Note: In PWM mode 1 or 2, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from âfrozenâ mode to âPWMâ mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
    $08 constant TIM12_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection This bitfield defines the direction of the channel (input/output) as well as the used input. Note: The CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM12_OC2FE                    \ [0x0a] Output compare 2 fast enable
    $0b constant TIM12_OC2PE                    \ [0x0b] Output compare 2 preload enable
    $0c constant TIM12_OC2M1                    \ [0x0c : 3] Output compare 2 mode Refer to OC1M[3:0] for bit description.
    $10 constant TIM12_OC1M2                    \ [0x10] Output compare 1 mode (refer to bit 16 for OC1M[3]) These bits define the behavior of the output reference signal OC1REF from which OC1 is derived. OC1REF is active high whereas the active level of OC1 depends on the CC1P. Note: In PWM mode 1 or 2, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from âfrozenâ mode to âPWMâ mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
    $18 constant TIM12_OC2M2                    \ [0x18] Output compare 2 mode Refer to OC1M[3:0] for bit description.
  [then]


  [ifdef] TIM12_TIM12_CCMR1_Input_DEF
    \
    \ @brief TIM12 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bitfield defines the direction of the channel (input/output) as well as the used input. Note: The CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM12_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler This bitfield defines the ratio of the prescaler acting on the CC1 input (IC1). The prescaler is reset as soon as CC1E=â0â (TIMx_CCER register).
    $04 constant TIM12_IC1F                     \ [0x04 : 4] Input capture 1 filter This bitfield defines the frequency used to sample the TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $08 constant TIM12_CC2S                     \ [0x08 : 2] Capture/compare 2 selection This bitfield defines the direction of the channel (input/output) as well as the used input. Note: The CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM12_IC2PSC                   \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM12_IC2F                     \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM12_TIM12_CCER_DEF
    \
    \ @brief TIM12 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1E                     \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM12_CC1P                     \ [0x01] Capture/Compare 1 output Polarity. When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: This configuration is reserved, it must not be used.
    $03 constant TIM12_CC1NP                    \ [0x03] Capture/Compare 1 complementary output Polarity CC1 channel configured as output: CC1NP must be kept cleared CC1 channel configured as input: CC1NP is used in conjunction with CC1P to define TI1FP1/TI2FP1 polarity (refer to CC1P description).
    $04 constant TIM12_CC2E                     \ [0x04] Capture/Compare 2 output enable Refer to CC1E description
    $05 constant TIM12_CC2P                     \ [0x05] Capture/Compare 2 output Polarity Refer to CC1P description
    $07 constant TIM12_CC2NP                    \ [0x07] Capture/Compare 2 output Polarity Refer to CC1NP description
  [then]


  [ifdef] TIM12_TIM12_CNT_DEF
    \
    \ @brief TIM12 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CNT                      \ [0x00 : 16] Counter value
    $1f constant TIM12_UIFCPY                   \ [0x1f] UIF Copy This bit is a read-only copy of the UIF bit in the TIMx_ISR register.
  [then]


  [ifdef] TIM12_TIM12_PSC_DEF
    \
    \ @brief TIM12 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_PSC                      \ [0x00 : 16] Prescaler value The counter clock frequency CK_CNT is equal to fCK_PSC / (PSC[15:0] + 1). PSC contains the value to be loaded into the active prescaler register at each update event. (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in âreset modeâ).
  [then]


  [ifdef] TIM12_TIM12_ARR_DEF
    \
    \ @brief TIM12 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM12_ARR                      \ [0x00 : 16] Auto-reload value ARR is the value to be loaded into the actual auto-reload register. Refer to the for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.
  [then]


  [ifdef] TIM12_TIM12_CCR1_DEF
    \
    \ @brief TIM12 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR1                     \ [0x00 : 16] Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded into the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (OC1PE bit). Else the preload value is copied into the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the TIMx_CNT counter and signaled on the OC1 output. If channel CC1is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (IC1).
  [then]


  [ifdef] TIM12_TIM12_CCR2_DEF
    \
    \ @brief TIM12 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR2                     \ [0x00 : 16] Capture/Compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded into the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (OC2PE bit). Else the preload value is copied into the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the TIMx_CNT counter and signalled on the OC2 output. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 2 event (IC2).
  [then]


  [ifdef] TIM12_TIM12_TISEL_DEF
    \
    \ @brief TIM12 timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_TI1SEL                   \ [0x00 : 4] selects TI1[0] to TI1[15] input Other: Reserved
    $08 constant TIM12_TI2SEL                   \ [0x08 : 4] selects TI2[0] to TI2[15] input Other: Reserved
  [then]

  \
  \ @brief TIM register block
  \
  $00 constant TIM12_TIM12_CR1          \ TIM12 control register 1
  $04 constant TIM12_TIM12_CR2          \ TIM12 control register 2
  $08 constant TIM12_TIM12_SMCR         \ TIM12 slave mode control register
  $0C constant TIM12_TIM12_DIER         \ TIM12 Interrupt enable register
  $10 constant TIM12_TIM12_SR           \ TIM12 status register
  $14 constant TIM12_TIM12_EGR          \ TIM12 event generation register
  $18 constant TIM12_TIM12_CCMR1_OUTPUT \ TIM12 capture/compare mode register 1 [alternate]
  $18 constant TIM12_TIM12_CCMR1_INPUT  \ TIM12 capture/compare mode register 1 [alternate]
  $20 constant TIM12_TIM12_CCER         \ TIM12 capture/compare enable register
  $24 constant TIM12_TIM12_CNT          \ TIM12 counter
  $28 constant TIM12_TIM12_PSC          \ TIM12 prescaler
  $2C constant TIM12_TIM12_ARR          \ TIM12 auto-reload register
  $34 constant TIM12_TIM12_CCR1         \ TIM12 capture/compare register 1
  $38 constant TIM12_TIM12_CCR2         \ TIM12 capture/compare register 2
  $68 constant TIM12_TIM12_TISEL        \ TIM12 timer input selection register

: TIM12_DEF ; [then]
