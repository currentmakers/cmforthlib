\
\ @file tim12.fs
\ @brief General-purpose timers
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
    $00 constant TIM12_CEN                      \ [0x00] Counter enable Note: External clock, gated mode and encoder mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware. CEN is cleared automatically in one-pulse mode, when an update event occurs.
    $01 constant TIM12_UDIS                     \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM12_URS                      \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM12_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM12_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM12_CKD                      \ [0x08 : 2] Clock division This bit-field indicates the division ratio between the timer clock (tim_ker_ck) frequency and sampling clock used by the digital filters (tim_etr_in, tim_tix),
    $0b constant TIM12_UIFREMAP                 \ [0x0b] UIF status bit remapping
    $0c constant TIM12_DITHEN                   \ [0x0c] Dithering Enable Note: The DITHEN bit can only be modified when CEN bit is reset.
  [then]


  [ifdef] TIM12_TIM12_CR2_DEF
    \
    \ @brief TIM12 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM12_MMS1                     \ [0x04 : 3] Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (tim_trgo). The combination is as follows: tim_trgo, except if the master/slave mode is selected (see the MSM bit description in TIMx_SMCR register). Others: Reserved Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
    $07 constant TIM12_TI1S                     \ [0x07] tim_ti1 selection
  [then]


  [ifdef] TIM12_TIM12_SMCR_DEF
    \
    \ @brief TIM12 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_SMS                      \ [0x00 : 3] Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $04 constant TIM12_TS                       \ [0x04 : 3] Trigger selection (see bits 21:20 for TS[4:3]) This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for product specific implementation details. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
    $07 constant TIM12_MSM                      \ [0x07] Master/Slave mode
    $10 constant TIM12_SMS_2                    \ [0x10] Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $14 constant TIM12_TS_2                     \ [0x14 : 2] Trigger selection (see bits 21:20 for TS[4:3]) This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for product specific implementation details. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
  [then]


  [ifdef] TIM12_TIM12_DIER_DEF
    \
    \ @brief TIM12 DMA/Interrupt enable register
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
    $00 constant TIM12_UIF                      \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow and if UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to the synchro control register description), if URS=0 and UDIS=0 in the TIMx_CR1 register.
    $01 constant TIM12_CC1IF                    \ [0x01] Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in downcounting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $02 constant TIM12_CC2IF                    \ [0x02] Capture/Compare 2 interrupt flag Refer to CC1IF description
    $06 constant TIM12_TIF                      \ [0x06] Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on tim_trgi input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
    $09 constant TIM12_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0'.
    $0a constant TIM12_CC2OF                    \ [0x0a] Capture/compare 2 overcapture flag refer to CC1OF description
  [then]


  [ifdef] TIM12_TIM12_EGR_DEF
    \
    \ @brief TIM12 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UG                       \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM12_CC1G                     \ [0x01] Capture/compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $02 constant TIM12_CC2G                     \ [0x02] Capture/compare 2 generation Refer to CC1G description
    $06 constant TIM12_TG                       \ [0x06] Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM12_TIM12_CCMR1_Input_DEF
    \
    \ @brief TIM12 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM12_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (tim_ic1). The prescaler is reset as soon as CC1E=0 (TIMx_CCER register).
    $04 constant TIM12_IC1F                     \ [0x04 : 4] Input capture 1 filter This bit-field defines the frequency used to sample tim_ti1 input and the length of the digital filter applied to tim_ti1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $08 constant TIM12_CC2S                     \ [0x08 : 2] Capture/compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM12_IC2PSC                   \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM12_IC2F                     \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM12_TIM12_CCMR1_Output_DEF
    \
    \ @brief TIM12 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM12_OC1FE                    \ [0x02] Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM12_OC1PE                    \ [0x03] Output compare 1 preload enable Note: The PWM mode can be used without validating the preload register only in one-pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
    $04 constant TIM12_OC1M1                    \ [0x04 : 3] Output compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 is derived. tim_oc1ref is active high whereas tim_oc1 active level depends on CC1P bit. Note: In PWM mode, the tim_ocref_clr level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode.
    $08 constant TIM12_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM12_OC2FE                    \ [0x0a] Output compare 2 fast enable
    $0b constant TIM12_OC2PE                    \ [0x0b] Output compare 2 preload enable
    $0c constant TIM12_OC2M1                    \ [0x0c : 3] Output compare 2 mode refer to OC1M description on bits 6:4
    $10 constant TIM12_OC1M2                    \ [0x10] Output compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 is derived. tim_oc1ref is active high whereas tim_oc1 active level depends on CC1P bit. Note: In PWM mode, the tim_ocref_clr level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode.
    $18 constant TIM12_OC2M2                    \ [0x18] Output compare 2 mode refer to OC1M description on bits 6:4
  [then]


  [ifdef] TIM12_TIM12_CCER_DEF
    \
    \ @brief TIM12 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1E                     \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM12_CC1P                     \ [0x01] Capture/Compare 1 output Polarity. When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges. The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used.
    $03 constant TIM12_CC1NP                    \ [0x03] Capture/Compare 1 output Polarity. CC1 channel configured as output: CC1NP must be kept cleared in this case. CC1 channel configured as input: This bit is used in conjunction with CC1P to define tim_ti1fp1/tim_ti2fp1 polarity. refer to CC1P description.
    $04 constant TIM12_CC2E                     \ [0x04] Capture/Compare 2 output enable. Refer to CC1E description
    $05 constant TIM12_CC2P                     \ [0x05] Capture/Compare 2 output Polarity. refer to CC1P description
    $07 constant TIM12_CC2NP                    \ [0x07] Capture/Compare 2 output Polarity. Refer to CC1NP description
  [then]


  [ifdef] TIM12_TIM12_CNT_DEF
    \
    \ @brief TIM12 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CNT                      \ [0x00 : 16] or UIFCPY: Value depends on IUFREMAP in TIMx_CR1. If UIFREMAP = 0 nullMost significant bit of counter value If UIFREMAP = 1 UIFCPY: UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register nullLeast significant part of counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register holds the non-dithered part in CNT[30:0]. The fractional part is not available.
    $1f constant TIM12_UIFCPY                   \ [0x1f] UIF Copy
  [then]


  [ifdef] TIM12_TIM12_PSC_DEF
    \
    \ @brief TIM12 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_PSC                      \ [0x00 : 16] Prescaler value The counter clock frequency tim_cnt_ck is equal to ftim_psc_ck / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in 'reset mode').
  [then]


  [ifdef] TIM12_TIM12_ARR_DEF
    \
    \ @brief TIM12 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TIM12_ARR                      \ [0x00 : 20] Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[31:4]. The ARR[3:0] bitfield contains the dithered part.
  [then]


  [ifdef] TIM12_TIM12_CCR1_DEF
    \
    \ @brief TIM12 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR1                     \ [0x00 : 20] Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc1 output. Non-dithering mode (DITHEN = 0) The register holds the compare value. Dithering mode (DITHEN = 1) The register holds the integer part in CCR1[31:4]. The CCR1[3:0] bitfield contains the dithered part. If channel CC1 is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (tim_ic1). The TIMx_CCR1 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value. Dithering mode (DITHEN = 1) The register holds the capture in CCR1[31:0]. The CCR1[3:0] bits are reset.
  [then]


  [ifdef] TIM12_TIM12_CCR2_DEF
    \
    \ @brief TIM12 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR2                     \ [0x00 : 20] Capture/compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc2 output. Non-dithering mode (DITHEN = 0) The register holds the compare value. Dithering mode (DITHEN = 1) The register holds the integer part in CCR2[31:4]. The CCR2[3:0] bitfield contains the dithered part. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 2 event (tim_ic2). The TIMx_CCR2 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value. Dithering mode (DITHEN = 1) The register holds the capture in CCR2[31:0]. The CCR2[3:0] bits are reset.
  [then]


  [ifdef] TIM12_TIM12_TISEL_DEF
    \
    \ @brief TIM12 timer input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_TI1SEL                   \ [0x00 : 4] Selects tim_ti1[0..15] input ... Refer to for product specific implementation.
    $08 constant TIM12_TI2SEL                   \ [0x08 : 4] Selects tim_ti2[0..15] input ... Refer to for product specific implementation.
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM12_TIM12_CR1          \ TIM12 control register 1
  $04 constant TIM12_TIM12_CR2          \ TIM12 control register 2
  $08 constant TIM12_TIM12_SMCR         \ TIM12 slave mode control register
  $0C constant TIM12_TIM12_DIER         \ TIM12 DMA/Interrupt enable register
  $10 constant TIM12_TIM12_SR           \ TIM12 status register
  $14 constant TIM12_TIM12_EGR          \ TIM12 event generation register
  $18 constant TIM12_TIM12_CCMR1_INPUT  \ TIM12 capture/compare mode register 1 [alternate]
  $18 constant TIM12_TIM12_CCMR1_OUTPUT \ TIM12 capture/compare mode register 1 [alternate]
  $20 constant TIM12_TIM12_CCER         \ TIM12 capture/compare enable register
  $24 constant TIM12_TIM12_CNT          \ TIM12 counter
  $28 constant TIM12_TIM12_PSC          \ TIM12 prescaler
  $2C constant TIM12_TIM12_ARR          \ TIM12 auto-reload register
  $34 constant TIM12_TIM12_CCR1         \ TIM12 capture/compare register 1
  $38 constant TIM12_TIM12_CCR2         \ TIM12 capture/compare register 2
  $5C constant TIM12_TIM12_TISEL        \ TIM12 timer input selection register

: TIM12_DEF ; [then]
