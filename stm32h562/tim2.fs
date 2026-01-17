\
\ @file tim2.fs
\ @brief General-purpose timers
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
    $00 constant TIM2_CEN                       \ [0x00] Counter enable Note: External clock, gated mode and encoder mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware. CEN is cleared automatically in one-pulse mode, when an update event occurs.
    $01 constant TIM2_UDIS                      \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM2_URS                       \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM2_OPM                       \ [0x03] One-pulse mode
    $04 constant TIM2_DIR                       \ [0x04] Direction Note: This bit is read only when the timer is configured in Center-aligned mode or Encoder mode.
    $05 constant TIM2_CMS                       \ [0x05 : 2] Center-aligned mode selection Note: It is not allowed to switch from edge-aligned mode to center-aligned mode as long as the counter is enabled (CEN=1)
    $07 constant TIM2_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM2_CKD                       \ [0x08 : 2] Clock division This bit-field indicates the division ratio between the timer clock (tim_ker_ck) frequency and sampling clock used by the digital filters (tim_etr_in, tim_tix),
    $0b constant TIM2_UIFREMAP                  \ [0x0b] UIF status bit remapping
    $0c constant TIM2_DITHEN                    \ [0x0c] Dithering Enable Note: The DITHEN bit can only be modified when CEN bit is reset.
  [then]


  [ifdef] TIM2_TIM2_CR2_DEF
    \
    \ @brief TIM2 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant TIM2_CCDS                      \ [0x03] Capture/compare DMA selection
    $04 constant TIM2_MMS1                      \ [0x04 : 3] Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (tim_trgo). The combination is as follows: tim_trgo, except if the master/slave mode is selected (see the MSM bit description in TIMx_SMCR register). Others: Reserved Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
    $07 constant TIM2_TI1S                      \ [0x07] tim_ti1 selection
    $19 constant TIM2_MMS2                      \ [0x19] Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (tim_trgo). The combination is as follows: tim_trgo, except if the master/slave mode is selected (see the MSM bit description in TIMx_SMCR register). Others: Reserved Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
  [then]


  [ifdef] TIM2_TIM2_SMCR_DEF
    \
    \ @brief TIM2 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_SMS                       \ [0x00 : 3] Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $03 constant TIM2_OCCS                      \ [0x03] OCREF clear selection This bit is used to select the OCREF clear source Note: If the OCREF clear selection feature is not supported, this bit is reserved and forced by hardware to '0'. .
    $04 constant TIM2_TS                        \ [0x04 : 3] Trigger selection (see bits 21:20 for TS[4:3]) This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for product specific implementation details. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
    $07 constant TIM2_MSM                       \ [0x07] Master/Slave mode
    $08 constant TIM2_ETF                       \ [0x08 : 4] External trigger filter This bit-field then defines the frequency used to sample tim_etrp signal and the length of the digital filter applied to tim_etrp. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $0c constant TIM2_ETPS                      \ [0x0c : 2] External trigger prescaler External trigger signal tim_etrp frequency must be at most 1/4 of tim_ker_ck frequency. A prescaler can be enabled to reduce tim_etrp frequency. It is useful when inputting fast external clocks on tim_etr_in.
    $0e constant TIM2_ECE                       \ [0x0e] External clock enable This bit enables External clock mode 2. Note: Setting the ECE bit has the same effect as selecting external clock mode 1 with tim_trgi connected to tim_etrf (SMS=111 and TS=00111). It is possible to simultaneously use external clock mode 2 with the following slave modes: reset mode, gated mode and trigger mode. Nevertheless, tim_trgi must not be connected to tim_etrf in this case (TS bits must not be 00111). If external clock mode 1 and external clock mode 2 are enabled at the same time, the external clock input is tim_etrf.
    $0f constant TIM2_ETP                       \ [0x0f] External trigger polarity This bit selects whether tim_etr_in or tim_etr_in is used for trigger operations
    $10 constant TIM2_SMS_2                     \ [0x10] Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $14 constant TIM2_TS_2                      \ [0x14 : 2] Trigger selection (see bits 21:20 for TS[4:3]) This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for product specific implementation details. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
    $18 constant TIM2_SMSPE                     \ [0x18] SMS preload enable This bit selects whether the SMS[3:0] bitfield is preloaded
    $19 constant TIM2_SMSPS                     \ [0x19] SMS preload source This bit selects whether the events that triggers the SMS[3:0] bitfield transfer from preload to active
  [then]


  [ifdef] TIM2_TIM2_DIER_DEF
    \
    \ @brief TIM2 DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM2_CC1IE                     \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM2_CC2IE                     \ [0x02] Capture/Compare 2 interrupt enable
    $03 constant TIM2_CC3IE                     \ [0x03] Capture/Compare 3 interrupt enable
    $04 constant TIM2_CC4IE                     \ [0x04] Capture/Compare 4 interrupt enable
    $06 constant TIM2_TIE                       \ [0x06] Trigger interrupt enable
    $08 constant TIM2_UDE                       \ [0x08] Update DMA request enable
    $09 constant TIM2_CC1DE                     \ [0x09] Capture/Compare 1 DMA request enable
    $0a constant TIM2_CC2DE                     \ [0x0a] Capture/Compare 2 DMA request enable
    $0b constant TIM2_CC3DE                     \ [0x0b] Capture/Compare 3 DMA request enable
    $0c constant TIM2_CC4DE                     \ [0x0c] Capture/Compare 4 DMA request enable
    $0e constant TIM2_TDE                       \ [0x0e] Trigger DMA request enable
    $14 constant TIM2_IDXIE                     \ [0x14] Index interrupt enable
    $15 constant TIM2_DIRIE                     \ [0x15] Direction change interrupt enable
    $16 constant TIM2_IERRIE                    \ [0x16] Index error interrupt enable
    $17 constant TIM2_TERRIE                    \ [0x17] Transition error interrupt enable
  [then]


  [ifdef] TIM2_TIM2_SR_DEF
    \
    \ @brief TIM2 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_UIF                       \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow and if UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to the synchro control register description), if URS=0 and UDIS=0 in the TIMx_CR1 register.
    $01 constant TIM2_CC1IF                     \ [0x01] Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in downcounting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $02 constant TIM2_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag Refer to CC1IF description
    $03 constant TIM2_CC3IF                     \ [0x03] Capture/Compare 3 interrupt flag Refer to CC1IF description
    $04 constant TIM2_CC4IF                     \ [0x04] Capture/Compare 4 interrupt flag Refer to CC1IF description
    $06 constant TIM2_TIF                       \ [0x06] Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on tim_trgi input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
    $09 constant TIM2_CC1OF                     \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0'.
    $0a constant TIM2_CC2OF                     \ [0x0a] Capture/compare 2 overcapture flag refer to CC1OF description
    $0b constant TIM2_CC3OF                     \ [0x0b] Capture/Compare 3 overcapture flag refer to CC1OF description
    $0c constant TIM2_CC4OF                     \ [0x0c] Capture/Compare 4 overcapture flag refer to CC1OF description
    $14 constant TIM2_IDXF                      \ [0x14] Index interrupt flag This flag is set by hardware when an index event is detected. It is cleared by software by writing it to '0'.
    $15 constant TIM2_DIRF                      \ [0x15] Direction change interrupt flag This flag is set by hardware when the direction changes in encoder mode (DIR bit value in TIMx_CR is changing). It is cleared by software by writing it to '0'.
    $16 constant TIM2_IERRF                     \ [0x16] Index error interrupt flag This flag is set by hardware when an index error is detected. It is cleared by software by writing it to '0'.
    $17 constant TIM2_TERRF                     \ [0x17] Transition error interrupt flag This flag is set by hardware when a transition error is detected in encoder mode. It is cleared by software by writing it to '0'.
  [then]


  [ifdef] TIM2_TIM2_EGR_DEF
    \
    \ @brief TIM2 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_UG                        \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM2_CC1G                      \ [0x01] Capture/compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $02 constant TIM2_CC2G                      \ [0x02] Capture/compare 2 generation Refer to CC1G description
    $03 constant TIM2_CC3G                      \ [0x03] Capture/compare 3 generation Refer to CC1G description
    $04 constant TIM2_CC4G                      \ [0x04] Capture/compare 4 generation Refer to CC1G description
    $06 constant TIM2_TG                        \ [0x06] Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM2_TIM2_CCMR1_Input_DEF
    \
    \ @brief TIM2 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM2_IC1PSC                    \ [0x02 : 2] Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (tim_ic1). The prescaler is reset as soon as CC1E=0 (TIMx_CCER register).
    $04 constant TIM2_IC1F                      \ [0x04 : 4] Input capture 1 filter This bit-field defines the frequency used to sample tim_ti1 input and the length of the digital filter applied to tim_ti1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $08 constant TIM2_CC2S                      \ [0x08 : 2] Capture/compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM2_IC2PSC                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM2_IC2F                      \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM2_TIM2_CCMR1_Output_DEF
    \
    \ @brief TIM2 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM2_OC1FE                     \ [0x02] Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM2_OC1PE                     \ [0x03] Output compare 1 preload enable Note: The PWM mode can be used without validating the preload register only in one-pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
    $04 constant TIM2_OC1M1                     \ [0x04 : 3] Output compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 is derived. tim_oc1ref is active high whereas tim_oc1 active level depends on CC1P bit. Note: In PWM mode, the tim_ocref_clr level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode.
    $07 constant TIM2_OC1CE                     \ [0x07] Output compare 1 clear enable
    $08 constant TIM2_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM2_OC2FE                     \ [0x0a] Output compare 2 fast enable
    $0b constant TIM2_OC2PE                     \ [0x0b] Output compare 2 preload enable
    $0c constant TIM2_OC2M1                     \ [0x0c : 3] Output compare 2 mode refer to OC1M description on bits 6:4
    $0f constant TIM2_OC2CE                     \ [0x0f] Output compare 2 clear enable
    $10 constant TIM2_OC1M2                     \ [0x10] Output compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 is derived. tim_oc1ref is active high whereas tim_oc1 active level depends on CC1P bit. Note: In PWM mode, the tim_ocref_clr level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode.
    $18 constant TIM2_OC2M2                     \ [0x18] Output compare 2 mode refer to OC1M description on bits 6:4
  [then]


  [ifdef] TIM2_TIM2_CCMR2_Input_DEF
    \
    \ @brief TIM2 capture/compare mode register 2 [alternate]
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
    $02 constant TIM2_IC3PSC                    \ [0x02 : 2] Input capture 3 prescaler
    $04 constant TIM2_IC3F                      \ [0x04 : 4] Input capture 3 filter
    $08 constant TIM2_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
    $0a constant TIM2_IC4PSC                    \ [0x0a : 2] Input capture 4 prescaler
    $0c constant TIM2_IC4F                      \ [0x0c : 4] Input capture 4 filter
  [then]


  [ifdef] TIM2_TIM2_CCMR2_Output_DEF
    \
    \ @brief TIM2 capture/compare mode register 2 [alternate]
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


  [ifdef] TIM2_TIM2_CCER_DEF
    \
    \ @brief TIM2 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CC1E                      \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM2_CC1P                      \ [0x01] Capture/Compare 1 output Polarity. When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges. The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used.
    $03 constant TIM2_CC1NP                     \ [0x03] Capture/Compare 1 output Polarity. CC1 channel configured as output: CC1NP must be kept cleared in this case. CC1 channel configured as input: This bit is used in conjunction with CC1P to define tim_ti1fp1/tim_ti2fp1 polarity. refer to CC1P description.
    $04 constant TIM2_CC2E                      \ [0x04] Capture/Compare 2 output enable. Refer to CC1E description
    $05 constant TIM2_CC2P                      \ [0x05] Capture/Compare 2 output Polarity. refer to CC1P description
    $07 constant TIM2_CC2NP                     \ [0x07] Capture/Compare 2 output Polarity. Refer to CC1NP description
    $08 constant TIM2_CC3E                      \ [0x08] Capture/Compare 3 output enable. Refer to CC1E description
    $09 constant TIM2_CC3P                      \ [0x09] Capture/Compare 3 output Polarity. Refer to CC1P description
    $0b constant TIM2_CC3NP                     \ [0x0b] Capture/Compare 3 output Polarity. Refer to CC1NP description
    $0c constant TIM2_CC4E                      \ [0x0c] Capture/Compare 4 output enable. refer to CC1E description
    $0d constant TIM2_CC4P                      \ [0x0d] Capture/Compare 4 output Polarity. Refer to CC1P description
    $0f constant TIM2_CC4NP                     \ [0x0f] Capture/Compare 4 output Polarity. Refer to CC1NP description
  [then]


  [ifdef] TIM2_TIM2_CNT_DEF
    \
    \ @brief TIM2 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CNT                       \ [0x00 : 32] or UIFCPY: Value depends on IUFREMAP in TIMx_CR1. If UIFREMAP = 0 nullMost significant bit of counter value If UIFREMAP = 1 UIFCPY: UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register nullLeast significant part of counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register holds the non-dithered part in CNT[30:0]. The fractional part is not available.
  [then]


  [ifdef] TIM2_TIM2_PSC_DEF
    \
    \ @brief TIM2 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_PSC                       \ [0x00 : 16] Prescaler value The counter clock frequency tim_cnt_ck is equal to ftim_psc_ck / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in 'reset mode').
  [then]


  [ifdef] TIM2_TIM2_ARR_DEF
    \
    \ @brief TIM2 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TIM2_ARR                       \ [0x00 : 32] Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[31:4]. The ARR[3:0] bitfield contains the dithered part.
  [then]


  [ifdef] TIM2_TIM2_CCR1_DEF
    \
    \ @brief TIM2 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR1                      \ [0x00 : 32] Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc1 output. Non-dithering mode (DITHEN = 0) The register holds the compare value. Dithering mode (DITHEN = 1) The register holds the integer part in CCR1[31:4]. The CCR1[3:0] bitfield contains the dithered part. If channel CC1 is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (tim_ic1). The TIMx_CCR1 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value. Dithering mode (DITHEN = 1) The register holds the capture in CCR1[31:0]. The CCR1[3:0] bits are reset.
  [then]


  [ifdef] TIM2_TIM2_CCR2_DEF
    \
    \ @brief TIM2 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR2                      \ [0x00 : 32] Capture/compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc2 output. Non-dithering mode (DITHEN = 0) The register holds the compare value. Dithering mode (DITHEN = 1) The register holds the integer part in CCR2[31:4]. The CCR2[3:0] bitfield contains the dithered part. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 2 event (tim_ic2). The TIMx_CCR2 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value. Dithering mode (DITHEN = 1) The register holds the capture in CCR2[31:0]. The CCR2[3:0] bits are reset.
  [then]


  [ifdef] TIM2_TIM2_CCR3_DEF
    \
    \ @brief TIM2 capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR3                      \ [0x00 : 32] Capture/compare 3 value If channel CC3 is configured as output: CCR3 is the value to be loaded in the actual capture/compare 3 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR3 register (bit OC3PE). Else the preload value is copied in the active capture/compare 3 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc3 output. Non-dithering mode (DITHEN = 0) The register holds the compare value. Dithering mode (DITHEN = 1) The register holds the integer part in CCR3[31:4]. The CCR3[3:0] bitfield contains the dithered part. If channel CC3 is configured as input: CCR3 is the counter value transferred by the last input capture 3 event (tim_ic3). The TIMx_CCR3 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value. Dithering mode (DITHEN = 1) The register holds the capture in CCR3[31:0]. The CCR3[3:0] bits are reset.
  [then]


  [ifdef] TIM2_TIM2_CCR4_DEF
    \
    \ @brief TIM2 capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_CCR4                      \ [0x00 : 32] Capture/compare 4 value If channel CC4 is configured as output: CCR4 is the value to be loaded in the actual capture/compare 4 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR4 register (bit OC4PE). Else the preload value is copied in the active capture/compare 4 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc4 output. Non-dithering mode (DITHEN = 0) The register holds the compare value. Dithering mode (DITHEN = 1) The register holds the integer part in CCR4[31:4]. The CCR4[3:0] bitfield contains the dithered part. If channel CC4 is configured as input: CCR4 is the counter value transferred by the last input capture 4 event (tim_ic4). The TIMx_CCR4 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value. Dithering mode (DITHEN = 1) The register holds the capture in CCR4[31:0]. The CCR4[3:0] bits are reset.
  [then]


  [ifdef] TIM2_TIM2_ECR_DEF
    \
    \ @brief TIM2 timer encoder control register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_IE                        \ [0x00] Index enable This bit indicates if the Index event resets the counter.
    $01 constant TIM2_IDIR                      \ [0x01 : 2] Index direction This bit indicates in which direction the Index event resets the counter. Note: The IDR[1:0] bitfield must be written when IE bit is reset (index disabled).
    $03 constant TIM2_IBLK                      \ [0x03 : 2] Index blanking This bit indicates if the Index event is conditioned by the tim_ti3 input
    $05 constant TIM2_FIDX                      \ [0x05] First index This bit indicates if the first index only is taken into account
    $06 constant TIM2_IPOS                      \ [0x06 : 2] Index positioning In quadrature encoder mode (SMS[3:0] = 0001, 0010, 0011, 1110, 1111), this bit indicates in which AB input configuration the Index event resets the counter. In directional clock mode or clock plus direction mode (SMS[3:0] = 1010, 1011, 1100, 1101), these bits indicates on which level the Index event resets the counter. In bidirectional clock mode, this applies for both clock inputs. x0: Index resets the counter when clock is 0 x1: Index resets the counter when clock is 1 Note: IPOS[1] bit is not significant
    $10 constant TIM2_PW                        \ [0x10 : 8] Pulse width This bitfield defines the pulse duration, as following: tPW = PW[7:0] x tPWG
    $18 constant TIM2_PWPRSC                    \ [0x18 : 3] Pulse width prescaler This bitfield sets the clock prescaler for the pulse generator, as following: tPWG = (2(PWPRSC[2:0])) x ttim_ker_ck
  [then]


  [ifdef] TIM2_TIM2_TISEL_DEF
    \
    \ @brief TIM2 timer input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_TI1SEL                    \ [0x00 : 4] Selects tim_ti1[0..15] input ... Refer to for product specific implementation.
    $08 constant TIM2_TI2SEL                    \ [0x08 : 4] Selects tim_ti2[0..15] input ... Refer to for product specific implementation.
    $10 constant TIM2_TI3SEL                    \ [0x10 : 4] Selects tim_ti3[0..15] input ... Refer to for product specific implementation.
    $18 constant TIM2_TI4SEL                    \ [0x18 : 4] Selects tim_ti4[0..15] input ... Refer to for product specific implementation.
  [then]


  [ifdef] TIM2_TIM2_AF1_DEF
    \
    \ @brief TIM2 alternate function register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $0e constant TIM2_ETRSEL                    \ [0x0e : 4] etr_in source selection These bits select the etr_in input source. ... Refer to for product specific implementation.
  [then]


  [ifdef] TIM2_TIM2_AF2_DEF
    \
    \ @brief TIM2 alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $10 constant TIM2_OCRSEL                    \ [0x10 : 3] ocref_clr source selection These bits select the ocref_clr input source. ... Refer to for product specific implementation.
  [then]


  [ifdef] TIM2_TIM2_DCR_DEF
    \
    \ @brief TIM2 DMA control register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_DBA                       \ [0x00 : 5] DMA base address This 5-bits vector defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ...
    $08 constant TIM2_DBL                       \ [0x08 : 5] DMA burst length This 5-bit vector defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address), i.e. the number of transfers. Transfers can be in half-words or in bytes (see example below). ... Example: Let us consider the following transfer: DBL = 7 bytes & DBA = TIM2_CR1. If DBL = 7 bytes and DBA = TIM2_CR1 represents the address of the byte to be transferred, the address of the transfer should be given by the following equation: (TIMx_CR1 address) + DBA + (DMA index), where DMA index = DBL In this example, 7 bytes are added to (TIMx_CR1 address) + DBA, which gives us the address from/to which the data are copied. In this case, the transfer is done to 7 registers starting from the following address: (TIMx_CR1 address) + DBA According to the configuration of the DMA Data Size, several cases may occur: If the DMA Data Size is configured in half-words, 16-bit data are transferred to each of the 7 registers. If the DMA Data Size is configured in bytes, the data are also transferred to 7 registers: the first register contains the first MSB byte, the second register, the first LSB byte and so on. So with the transfer Timer, one also has to specify the size of data transferred by DMA.
    $10 constant TIM2_DBSS                      \ [0x10 : 4] DMA burst source selection This bitfield defines the interrupt source that triggers the DMA burst transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). Others: reserved
  [then]


  [ifdef] TIM2_TIM2_DMAR_DEF
    \
    \ @brief TIM2 DMA address for full transfer
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant TIM2_DMAB                      \ [0x00 : 32] DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM2_TIM2_CR1            \ TIM2 control register 1
  $04 constant TIM2_TIM2_CR2            \ TIM2 control register 2
  $08 constant TIM2_TIM2_SMCR           \ TIM2 slave mode control register
  $0C constant TIM2_TIM2_DIER           \ TIM2 DMA/Interrupt enable register
  $10 constant TIM2_TIM2_SR             \ TIM2 status register
  $14 constant TIM2_TIM2_EGR            \ TIM2 event generation register
  $18 constant TIM2_TIM2_CCMR1_INPUT    \ TIM2 capture/compare mode register 1 [alternate]
  $18 constant TIM2_TIM2_CCMR1_OUTPUT   \ TIM2 capture/compare mode register 1 [alternate]
  $1C constant TIM2_TIM2_CCMR2_INPUT    \ TIM2 capture/compare mode register 2 [alternate]
  $1C constant TIM2_TIM2_CCMR2_OUTPUT   \ TIM2 capture/compare mode register 2 [alternate]
  $20 constant TIM2_TIM2_CCER           \ TIM2 capture/compare enable register
  $24 constant TIM2_TIM2_CNT            \ TIM2 counter
  $28 constant TIM2_TIM2_PSC            \ TIM2 prescaler
  $2C constant TIM2_TIM2_ARR            \ TIM2 auto-reload register
  $34 constant TIM2_TIM2_CCR1           \ TIM2 capture/compare register 1
  $38 constant TIM2_TIM2_CCR2           \ TIM2 capture/compare register 2
  $3C constant TIM2_TIM2_CCR3           \ TIM2 capture/compare register 3
  $40 constant TIM2_TIM2_CCR4           \ TIM2 capture/compare register 4
  $58 constant TIM2_TIM2_ECR            \ TIM2 timer encoder control register
  $5C constant TIM2_TIM2_TISEL          \ TIM2 timer input selection register
  $60 constant TIM2_TIM2_AF1            \ TIM2 alternate function register 1
  $64 constant TIM2_TIM2_AF2            \ TIM2 alternate function register 2
  $3DC constant TIM2_TIM2_DCR           \ TIM2 DMA control register
  $3E0 constant TIM2_TIM2_DMAR          \ TIM2 DMA address for full transfer

: TIM2_DEF ; [then]
