\
\ @file tim4.fs
\ @brief General-purpose-timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM4_DEF

  [ifdef] TIM4_TIM4_CR1_DEF
    \
    \ @brief TIM4 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CEN                       \ [0x00] Counter enable Note: External clock, gated mode and encoder mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware. CEN is cleared automatically in one-pulse mode, when an update event occurs.
    $01 constant TIM4_UDIS                      \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM4_URS                       \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM4_OPM                       \ [0x03] One-pulse mode
    $04 constant TIM4_DIR                       \ [0x04] Direction Note: This bit is read only when the timer is configured in Center-aligned mode or Encoder mode.
    $05 constant TIM4_CMS                       \ [0x05 : 2] Center-aligned mode selection Note: It is not allowed to switch from edge-aligned mode to center-aligned mode as long as the counter is enabled (CEN=1)
    $07 constant TIM4_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM4_CKD                       \ [0x08 : 2] Clock division This bit-field indicates the division ratio between the timer clock (CK_INT) frequency and sampling clock used by the digital filters (ETR, TIx),
    $0b constant TIM4_UIFREMAP                  \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM4_TIM4_CR2_DEF
    \
    \ @brief TIM4 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant TIM4_CCDS                      \ [0x03] Capture/compare DMA selection
    $04 constant TIM4_MMS                       \ [0x04 : 3] Master mode selection These bits permit to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows: When the Counter Enable signal is controlled by the trigger input, there is a delay on TRGO, except if the master/slave mode is selected (see the MSM bit description in TIMx_SMCR register). Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
    $07 constant TIM4_TI1S                      \ [0x07] TI1 selection
  [then]


  [ifdef] TIM4_TIM4_SMCR_DEF
    \
    \ @brief TIM4 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_SMS                       \ [0x00 : 3] SMS[0]: Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control Register description. reinitializes the counter, generates an update of the registers and starts the counter. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS=00100). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the TRGO or the TRGO2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $04 constant TIM4_TS                        \ [0x04 : 3] TS[0]: Trigger selection This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See Table 179: TIMx internal trigger connection on page 846 for more details on ITRx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
    $07 constant TIM4_MSM                       \ [0x07] Master/Slave mode
    $08 constant TIM4_ETF                       \ [0x08 : 4] External trigger filter This bit-field then defines the frequency used to sample ETRP signal and the length of the digital filter applied to ETRP. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $0c constant TIM4_ETPS                      \ [0x0c : 2] External trigger prescaler External trigger signal ETRP frequency must be at most 1/4 of CK_INT frequency. A prescaler can be enabled to reduce ETRP frequency. It is useful when inputting fast external clocks.
    $0e constant TIM4_ECE                       \ [0x0e] External clock enable This bit enables External clock mode 2. Note: Setting the ECE bit has the same effect as selecting external clock mode 1 with TRGI connected to ETRF (SMS=111 and TS=00111). Note: It is possible to simultaneously use external clock mode 2 with the following slave modes: reset mode, gated mode and trigger mode. Nevertheless, TRGI must not be connected to ETRF in this case (TS bits must not be 00111). Note: If external clock mode 1 and external clock mode 2 are enabled at the same time, the external clock input is ETRF.
    $0f constant TIM4_ETP                       \ [0x0f] External trigger polarity This bit selects whether ETR or ETR is used for trigger operations
    $10 constant TIM4_SMS_1                     \ [0x10] SMS[3]
    $14 constant TIM4_TS_1                      \ [0x14 : 2] TS[4:3]
  [then]


  [ifdef] TIM4_TIM4_DIER_DEF
    \
    \ @brief TIM4 DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM4_CC1IE                     \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM4_CC2IE                     \ [0x02] Capture/Compare 2 interrupt enable
    $03 constant TIM4_CC3IE                     \ [0x03] Capture/Compare 3 interrupt enable
    $04 constant TIM4_CC4IE                     \ [0x04] Capture/Compare 4 interrupt enable
    $06 constant TIM4_TIE                       \ [0x06] Trigger interrupt enable
    $08 constant TIM4_UDE                       \ [0x08] Update DMA request enable
    $09 constant TIM4_CC1DE                     \ [0x09] Capture/Compare 1 DMA request enable
    $0a constant TIM4_CC2DE                     \ [0x0a] Capture/Compare 2 DMA request enable
    $0b constant TIM4_CC3DE                     \ [0x0b] Capture/Compare 3 DMA request enable
    $0c constant TIM4_CC4DE                     \ [0x0c] Capture/Compare 4 DMA request enable
    $0e constant TIM4_TDE                       \ [0x0e] Trigger DMA request enable
  [then]


  [ifdef] TIM4_TIM4_SR_DEF
    \
    \ @brief TIM4 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_UIF                       \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow (for TIM2 to TIM4) and if UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to the synchro control register description), if URS=0 and UDIS=0 in the TIMx_CR1 register.
    $01 constant TIM4_CC1IF                     \ [0x01] Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $02 constant TIM4_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag Refer to CC1IF description
    $03 constant TIM4_CC3IF                     \ [0x03] Capture/Compare 3 interrupt flag Refer to CC1IF description
    $04 constant TIM4_CC4IF                     \ [0x04] Capture/Compare 4 interrupt flag Refer to CC1IF description
    $06 constant TIM4_TIF                       \ [0x06] Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on TRGI input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
    $09 constant TIM4_CC1OF                     \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to 0 .
    $0a constant TIM4_CC2OF                     \ [0x0a] Capture/compare 2 overcapture flag refer to CC1OF description
    $0b constant TIM4_CC3OF                     \ [0x0b] Capture/Compare 3 overcapture flag refer to CC1OF description
    $0c constant TIM4_CC4OF                     \ [0x0c] Capture/Compare 4 overcapture flag refer to CC1OF description
  [then]


  [ifdef] TIM4_TIM4_EGR_DEF
    \
    \ @brief TIM4 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_UG                        \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM4_CC1G                      \ [0x01] Capture/compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $02 constant TIM4_CC2G                      \ [0x02] Capture/compare 2 generation Refer to CC1G description
    $03 constant TIM4_CC3G                      \ [0x03] Capture/compare 3 generation Refer to CC1G description
    $04 constant TIM4_CC4G                      \ [0x04] Capture/compare 4 generation Refer to CC1G description
    $06 constant TIM4_TG                        \ [0x06] Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM4_TIM4_CCMR1_DEF
    \
    \ @brief TIM4 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM4_IC1PSC                    \ [0x02 : 2] Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (IC1). The prescaler is reset as soon as CC1E=0 (TIMx_CCER register).
    $04 constant TIM4_IC1F                      \ [0x04 : 4] Input capture 1 filter This bit-field defines the frequency used to sample TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $08 constant TIM4_CC2S                      \ [0x08 : 2] Capture/compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM4_IC2PSC                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM4_IC2F                      \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM4_TIM4_CCMR1_ALTERNATE_DEF
    \
    \ @brief TIM4 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM4_OC1FE                     \ [0x02] Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM4_OC1PE                     \ [0x03] Output compare 1 preload enable
    $04 constant TIM4_OC1M                      \ [0x04 : 3] OC1M[2:0]: Output compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from frozen mode to PWM mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
    $07 constant TIM4_OC1CE                     \ [0x07] Output compare 1 clear enable
    $08 constant TIM4_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM4_OC2FE                     \ [0x0a] Output compare 2 fast enable
    $0b constant TIM4_OC2PE                     \ [0x0b] Output compare 2 preload enable
    $0c constant TIM4_OC2M                      \ [0x0c : 3] OC2M[2:0]: Output compare 2 mode refer to OC1M description on bits 6:4
    $0f constant TIM4_OC2CE                     \ [0x0f] Output compare 2 clear enable
    $10 constant TIM4_OC1M_1                    \ [0x10] OC1M[3]
    $18 constant TIM4_OC2M_1                    \ [0x18] OC2M[3]
  [then]


  [ifdef] TIM4_TIM4_CCMR2_DEF
    \
    \ @brief TIM4 capture/compare mode register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
    $02 constant TIM4_IC3PSC                    \ [0x02 : 2] Input capture 3 prescaler
    $04 constant TIM4_IC3F                      \ [0x04 : 4] Input capture 3 filter
    $08 constant TIM4_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
    $0a constant TIM4_IC4PSC                    \ [0x0a : 2] Input capture 4 prescaler
    $0c constant TIM4_IC4F                      \ [0x0c : 4] Input capture 4 filter
  [then]


  [ifdef] TIM4_TIM4_CCMR2_ALTERNATE_DEF
    \
    \ @brief TIM4 capture/compare mode register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
    $02 constant TIM4_OC3FE                     \ [0x02] Output compare 3 fast enable
    $03 constant TIM4_OC3PE                     \ [0x03] Output compare 3 preload enable
    $04 constant TIM4_OC3M                      \ [0x04 : 3] OC3M[2:0]: Output compare 3 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
    $07 constant TIM4_OC3CE                     \ [0x07] Output compare 3 clear enable
    $08 constant TIM4_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
    $0a constant TIM4_OC4FE                     \ [0x0a] Output compare 4 fast enable
    $0b constant TIM4_OC4PE                     \ [0x0b] Output compare 4 preload enable
    $0c constant TIM4_OC4M                      \ [0x0c : 3] OC4M[2:0]: Output compare 4 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
    $0f constant TIM4_OC4CE                     \ [0x0f] Output compare 4 clear enable
    $10 constant TIM4_OC3M_1                    \ [0x10] OC3M[3]
    $18 constant TIM4_OC4M_1                    \ [0x18] OC4M[3]
  [then]


  [ifdef] TIM4_TIM4_CCER_DEF
    \
    \ @brief TIM4 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CC1E                      \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM4_CC1P                      \ [0x01] Capture/Compare 1 output Polarity. When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges. The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: This configuration is reserved, it must not be used.
    $03 constant TIM4_CC1NP                     \ [0x03] Capture/Compare 1 output Polarity. CC1 channel configured as output: CC1NP must be kept cleared in this case. CC1 channel configured as input: This bit is used in conjunction with CC1P to define TI1FP1/TI2FP1 polarity. refer to CC1P description.
    $04 constant TIM4_CC2E                      \ [0x04] Capture/Compare 2 output enable. Refer to CC1E description
    $05 constant TIM4_CC2P                      \ [0x05] Capture/Compare 2 output Polarity. refer to CC1P description
    $07 constant TIM4_CC2NP                     \ [0x07] Capture/Compare 2 output Polarity. Refer to CC1NP description
    $08 constant TIM4_CC3E                      \ [0x08] Capture/Compare 3 output enable. Refer to CC1E description
    $09 constant TIM4_CC3P                      \ [0x09] Capture/Compare 3 output Polarity. Refer to CC1P description
    $0b constant TIM4_CC3NP                     \ [0x0b] Capture/Compare 3 output Polarity. Refer to CC1NP description
    $0c constant TIM4_CC4E                      \ [0x0c] Capture/Compare 4 output enable. refer to CC1E description
    $0d constant TIM4_CC4P                      \ [0x0d] Capture/Compare 4 output Polarity. Refer to CC1P description
    $0f constant TIM4_CC4NP                     \ [0x0f] Capture/Compare 4 output Polarity. Refer to CC1NP description
  [then]


  [ifdef] TIM4_TIM4_CNT_DEF
    \
    \ @brief TIM4 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CNT                       \ [0x00 : 32] Least significant part of counter value
  [then]


  [ifdef] TIM4_TIM4_CNT_ALTERNATE_DEF
    \
    \ @brief TIM4 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CNT                       \ [0x00 : 31] Least significant part of counter value
    $1f constant TIM4_UIFCPY                    \ [0x1f] UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register
  [then]


  [ifdef] TIM4_TIM4_PSC_DEF
    \
    \ @brief TIM4 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_PSC                       \ [0x00 : 16] Prescaler value The counter clock frequency CK_CNT is equal to f<sub>CK_PSC</sub> / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in reset mode ).
  [then]


  [ifdef] TIM4_TIM4_ARR_DEF
    \
    \ @brief TIM4 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TIM4_ARR                       \ [0x00 : 32] Low Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the Section 25.3.1: Time-base unit on page 786 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.
  [then]


  [ifdef] TIM4_TIM4_CCR1_DEF
    \
    \ @brief TIM4 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CCR1                      \ [0x00 : 32] Low Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC1 output. If channel CC1is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (IC1). The TIMx_CCR1 register is read-only and cannot be programmed.
  [then]


  [ifdef] TIM4_TIM4_CCR2_DEF
    \
    \ @brief TIM4 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CCR2                      \ [0x00 : 32] Low Capture/Compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on OC2 output. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 2 event (IC2). The TIMx_CCR2 register is read-only and cannot be programmed.
  [then]


  [ifdef] TIM4_TIM4_CCR3_DEF
    \
    \ @brief TIM4 capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CCR3                      \ [0x00 : 32] Low Capture/Compare value If channel CC3 is configured as output: CCR3 is the value to be loaded in the actual capture/compare 3 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC3PE). Else the preload value is copied in the active capture/compare 3 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on OC3 output. If channel CC3is configured as input: CCR3 is the counter value transferred by the last input capture 3 event (IC3). The TIMx_CCR3 register is read-only and cannot be programmed.
  [then]


  [ifdef] TIM4_TIM4_CCR4_DEF
    \
    \ @brief TIM4 capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_CCR4                      \ [0x00 : 32] Low Capture/Compare value if CC4 channel is configured as output (CC4S bits): CCR4 is the value to be loaded in the actual capture/compare 4 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC4PE). Else the preload value is copied in the active capture/compare 4 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on OC4 output. if CC4 channel is configured as input (CC4S bits in TIMx_CCMR4 register): CCR4 is the counter value transferred by the last input capture 4 event (IC4). The TIMx_CCR4 register is read-only and cannot be programmed.
  [then]


  [ifdef] TIM4_TIM4_DCR_DEF
    \
    \ @brief TIM4 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_DBA                       \ [0x00 : 5] DMA base address This 5-bit vector defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ... Example: Let us consider the following transfer: DBL = 7 transfers & DBA = TIMx_CR1. In this case the transfer is done to/from 7 registers starting from the TIMx_CR1 address.
    $08 constant TIM4_DBL                       \ [0x08 : 5] DMA burst length This 5-bit vector defines the number of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). ...
  [then]


  [ifdef] TIM4_TIM4_DMAR_DEF
    \
    \ @brief TIM4 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_DMAB                      \ [0x00 : 16] DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).
  [then]


  [ifdef] TIM4_TIM4_AF1_DEF
    \
    \ @brief TIM4 alternate function option register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $0e constant TIM4_ETRSEL                    \ [0x0e : 4] ETR source selection These bits select the ETR input source. Others: Reserved
  [then]


  [ifdef] TIM4_TIM4_TISEL_DEF
    \
    \ @brief TIM4 timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM4_TI1SEL                    \ [0x00 : 4] TI1[0] to TI1[15] input selection These bits select the TI1[0] to TI1[15] input source. Others: Reserved
    $08 constant TIM4_TI2SEL                    \ [0x08 : 4] TI2[0] to TI2[15] input selection These bits select the TI2[0] to TI2[15] input source. Others: Reserved
    $10 constant TIM4_TI3SEL                    \ [0x10 : 4] TI3[0] to TI3[15] input selection These bits select the TI3[0] to TI3[15] input source. Others: Reserved
    $18 constant TIM4_TI4SEL                    \ [0x18 : 4] TI4[0] to TI4[15] input selection These bits select the TI4[0] to TI4[15] input source. Others: Reserved
  [then]

  \
  \ @brief General-purpose-timers
  \
  $00 constant TIM4_TIM4_CR1            \ TIM4 control register 1
  $04 constant TIM4_TIM4_CR2            \ TIM4 control register 2
  $08 constant TIM4_TIM4_SMCR           \ TIM4 slave mode control register
  $0C constant TIM4_TIM4_DIER           \ TIM4 DMA/Interrupt enable register
  $10 constant TIM4_TIM4_SR             \ TIM4 status register
  $14 constant TIM4_TIM4_EGR            \ TIM4 event generation register
  $18 constant TIM4_TIM4_CCMR1          \ TIM4 capture/compare mode register 1
  $18 constant TIM4_TIM4_CCMR1_ALTERNATE    \ TIM4 capture/compare mode register 1
  $1C constant TIM4_TIM4_CCMR2          \ TIM4 capture/compare mode register 2
  $1C constant TIM4_TIM4_CCMR2_ALTERNATE    \ TIM4 capture/compare mode register 2
  $20 constant TIM4_TIM4_CCER           \ TIM4 capture/compare enable register
  $24 constant TIM4_TIM4_CNT            \ TIM4 counter
  $24 constant TIM4_TIM4_CNT_ALTERNATE  \ TIM4 counter
  $28 constant TIM4_TIM4_PSC            \ TIM4 prescaler
  $2C constant TIM4_TIM4_ARR            \ TIM4 auto-reload register
  $34 constant TIM4_TIM4_CCR1           \ TIM4 capture/compare register 1
  $38 constant TIM4_TIM4_CCR2           \ TIM4 capture/compare register 2
  $3C constant TIM4_TIM4_CCR3           \ TIM4 capture/compare register 3
  $40 constant TIM4_TIM4_CCR4           \ TIM4 capture/compare register 4
  $48 constant TIM4_TIM4_DCR            \ TIM4 DMA control register
  $4C constant TIM4_TIM4_DMAR           \ TIM4 DMA address for full transfer
  $60 constant TIM4_TIM4_AF1            \ TIM4 alternate function option register 1
  $68 constant TIM4_TIM4_TISEL          \ TIM4 timer input selection register

: TIM4_DEF ; [then]
