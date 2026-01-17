\
\ @file tim1.fs
\ @brief TIM1 address block description
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
    $00 constant TIM1_CEN                       \ [0x00] Counter enable Note: External clock, gated mode and encoder mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
    $01 constant TIM1_UDIS                      \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM1_URS                       \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM1_OPM                       \ [0x03] One pulse mode
    $04 constant TIM1_DIR                       \ [0x04] Direction Note: This bit is read only when the timer is configured in Center-aligned mode or Encoder mode.
    $05 constant TIM1_CMS                       \ [0x05 : 2] Center-aligned mode selection Note: Switch from edge-aligned mode to center-aligned mode as long as the counter is enabled (CEN=1) is not allowed
    $07 constant TIM1_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM1_CKD                       \ [0x08 : 2] Clock division This bit-field indicates the division ratio between the timer clock (CK_INT) frequency and the dead-time and sampling clock (t<sub>DTS</sub>)used by the dead-time generators and the digital filters (ETR, TIx): Note: t<sub>DTS</sub> = 1/f<sub>DTS</sub>, t<sub>CK_INT</sub> = 1/f<sub>CK_INT</sub>.
    $0b constant TIM1_UIFREMAP                  \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM1_TIM1_CR2_DEF
    \
    \ @brief TIM1 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCPC                      \ [0x00] Capture/compare preloaded control Note: This bit acts only on channels that have a complementary output.
    $02 constant TIM1_CCUS                      \ [0x02] Capture/compare control update selection Note: This bit acts only on channels that have a complementary output.
    $03 constant TIM1_CCDS                      \ [0x03] Capture/compare DMA selection
    $04 constant TIM1_MMS                       \ [0x04 : 3] Master mode selection These bits allow selected information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows: Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
    $07 constant TIM1_TI1S                      \ [0x07] TI1 selection
    $08 constant TIM1_OIS1                      \ [0x08] Output Idle state 1 (OC1 output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
    $09 constant TIM1_OIS1N                     \ [0x09] Output Idle state 1 (OC1N output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
    $0a constant TIM1_OIS2                      \ [0x0a] Output Idle state 2 (OC2 output) Refer to OIS1 bit
    $0b constant TIM1_OIS2N                     \ [0x0b] Output Idle state 2 (OC2N output) Refer to OIS1N bit
    $0c constant TIM1_OIS3                      \ [0x0c] Output Idle state 3 (OC3 output) Refer to OIS1 bit
    $0d constant TIM1_OIS3N                     \ [0x0d] Output Idle state 3 (OC3N output) Refer to OIS1N bit
    $0e constant TIM1_OIS4                      \ [0x0e] Output Idle state 4 (OC4 output) Refer to OIS1 bit
    $10 constant TIM1_OIS5                      \ [0x10] Output Idle state 5 (OC5 output) Refer to OIS1 bit
    $12 constant TIM1_OIS6                      \ [0x12] Output Idle state 6 (OC6 output) Refer to OIS1 bit
    $14 constant TIM1_MMS2                      \ [0x14 : 4] Master mode selection 2 These bits allow the information to be sent to ADC for synchronization (TRGO2) to be selected. The combination is as follows: Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
  [then]


  [ifdef] TIM1_TIM1_SMCR_DEF
    \
    \ @brief TIM1 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_SMS                       \ [0x00 : 3] SMS[2:0]: Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Codes above 1000: Reserved. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS=00100). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the TRGO or the TRGO2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $03 constant TIM1_OCCS                      \ [0x03] OCREF clear selection This bit is used to select the OCREF clear source.
    $04 constant TIM1_TS                        \ [0x04 : 3] TS[2:0]: Trigger selection This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See Table 73: TIM1 internal trigger connection on page 395 for more details on ITRx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
    $07 constant TIM1_MSM                       \ [0x07] Master/slave mode
    $08 constant TIM1_ETF                       \ [0x08 : 4] External trigger filter This bit-field then defines the frequency used to sample ETRP signal and the length of the digital filter applied to ETRP. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $0c constant TIM1_ETPS                      \ [0x0c : 2] External trigger prescaler External trigger signal ETRP frequency must be at most 1/4 of f<sub>CK_INT</sub> frequency. A prescaler can be enabled to reduce ETRP frequency. It is useful when inputting fast external clocks.
    $0e constant TIM1_ECE                       \ [0x0e] External clock enable This bit enables External clock mode 2. Note: Setting the ECE bit has the same effect as selecting external clock mode 1 with TRGI connected to ETRF (SMS=111 and TS=00111). It is possible to simultaneously use external clock mode 2 with the following slave modes: reset mode, gated mode and trigger mode. Nevertheless, TRGI must not be connected to ETRF in this case (TS bits must not be 00111). Note: If external clock mode 1 and external clock mode 2 are enabled at the same time, the external clock input is ETRF.
    $0f constant TIM1_ETP                       \ [0x0f] External trigger polarity This bit selects whether ETR or ETR is used for trigger operations
    $10 constant TIM1_SMS_1                     \ [0x10] SMS[3]
    $14 constant TIM1_TS_1                      \ [0x14 : 2] TS[4:3]
  [then]


  [ifdef] TIM1_TIM1_DIER_DEF
    \
    \ @brief TIM1 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM1_CC1IE                     \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM1_CC2IE                     \ [0x02] Capture/Compare 2 interrupt enable
    $03 constant TIM1_CC3IE                     \ [0x03] Capture/Compare 3 interrupt enable
    $04 constant TIM1_CC4IE                     \ [0x04] Capture/Compare 4 interrupt enable
    $05 constant TIM1_COMIE                     \ [0x05] COM interrupt enable
    $06 constant TIM1_TIE                       \ [0x06] Trigger interrupt enable
    $07 constant TIM1_BIE                       \ [0x07] Break interrupt enable
    $08 constant TIM1_UDE                       \ [0x08] Update DMA request enable
    $09 constant TIM1_CC1DE                     \ [0x09] Capture/Compare 1 DMA request enable
    $0a constant TIM1_CC2DE                     \ [0x0a] Capture/Compare 2 DMA request enable
    $0b constant TIM1_CC3DE                     \ [0x0b] Capture/Compare 3 DMA request enable
    $0c constant TIM1_CC4DE                     \ [0x0c] Capture/Compare 4 DMA request enable
    $0d constant TIM1_COMDE                     \ [0x0d] COM DMA request enable
    $0e constant TIM1_TDE                       \ [0x0e] Trigger DMA request enable
  [then]


  [ifdef] TIM1_TIM1_SR_DEF
    \
    \ @brief TIM1 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_UIF                       \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to Section 17.4.3: TIM1 slave mode control register (TIM1_SMCR)), if URS=0 and UDIS=0 in the TIMx_CR1 register.
    $01 constant TIM1_CC1IF                     \ [0x01] Capture/Compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $02 constant TIM1_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag Refer to CC1IF description
    $03 constant TIM1_CC3IF                     \ [0x03] Capture/Compare 3 interrupt flag Refer to CC1IF description
    $04 constant TIM1_CC4IF                     \ [0x04] Capture/Compare 4 interrupt flag Refer to CC1IF description
    $05 constant TIM1_COMIF                     \ [0x05] COM interrupt flag This flag is set by hardware on COM event (when Capture/compare Control bits - CCxE, CCxNE, OCxM - have been updated). It is cleared by software.
    $06 constant TIM1_TIF                       \ [0x06] Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on TRGI input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
    $07 constant TIM1_BIF                       \ [0x07] Break interrupt flag This flag is set by hardware as soon as the break input goes active. It can be cleared by software if the break input is not active.
    $08 constant TIM1_B2IF                      \ [0x08] Break 2 interrupt flag This flag is set by hardware as soon as the break 2 input goes active. It can be cleared by software if the break 2 input is not active.
    $09 constant TIM1_CC1OF                     \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to 0 .
    $0a constant TIM1_CC2OF                     \ [0x0a] Capture/Compare 2 overcapture flag Refer to CC1OF description
    $0b constant TIM1_CC3OF                     \ [0x0b] Capture/Compare 3 overcapture flag Refer to CC1OF description
    $0c constant TIM1_CC4OF                     \ [0x0c] Capture/Compare 4 overcapture flag Refer to CC1OF description
    $0d constant TIM1_SBIF                      \ [0x0d] System Break interrupt flag This flag is set by hardware as soon as the system break input goes active. It can be cleared by software if the system break input is not active. This flag must be reset to re-start PWM operation.
    $10 constant TIM1_CC5IF                     \ [0x10] Compare 5 interrupt flag Refer to CC1IF description (Note: Channel 5 can only be configured as output)
    $11 constant TIM1_CC6IF                     \ [0x11] Compare 6 interrupt flag Refer to CC1IF description (Note: Channel 6 can only be configured as output)
  [then]


  [ifdef] TIM1_TIM1_EGR_DEF
    \
    \ @brief TIM1 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_UG                        \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM1_CC1G                      \ [0x01] Capture/Compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $02 constant TIM1_CC2G                      \ [0x02] Capture/Compare 2 generation Refer to CC1G description
    $03 constant TIM1_CC3G                      \ [0x03] Capture/Compare 3 generation Refer to CC1G description
    $04 constant TIM1_CC4G                      \ [0x04] Capture/Compare 4 generation Refer to CC1G description
    $05 constant TIM1_COMG                      \ [0x05] Capture/Compare control update generation This bit can be set by software, it is automatically cleared by hardware Note: This bit acts only on channels having a complementary output.
    $06 constant TIM1_TG                        \ [0x06] Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
    $07 constant TIM1_BG                        \ [0x07] Break generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
    $08 constant TIM1_B2G                       \ [0x08] Break 2 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM1_TIM1_CCMR1_DEF
    \
    \ @brief TIM1 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC1S                      \ [0x00 : 2] Capture/Compare 1 Selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM1_IC1PSC                    \ [0x02 : 2] Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (IC1). The prescaler is reset as soon as CC1E= 0 (TIMx_CCER register).
    $04 constant TIM1_IC1F                      \ [0x04 : 4] Input capture 1 filter This bit-field defines the frequency used to sample TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $08 constant TIM1_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM1_IC2PSC                    \ [0x0a : 2] Input capture 2 prescaler Refer to IC1PSC[1:0] description.
    $0c constant TIM1_IC2F                      \ [0x0c : 4] Input capture 2 filter Refer to IC1F[3:0] description.
  [then]


  [ifdef] TIM1_TIM1_CCMR1_ALTERNATE1_DEF
    \
    \ @brief TIM1 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM1_OC1FE                     \ [0x02] Output Compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM1_OC1PE                     \ [0x03] Output Compare 1 preload enable Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S= 00 (the channel is configured in output).
    $04 constant TIM1_OC1M                      \ [0x04 : 3] OC1M[2:0]: Output Compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S= 00 (the channel is configured in output). Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from frozen mode to PWM mode. Note: On channels having a complementary output, this bit field is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the OC1M active bits take the new value from the preloaded bits only when a COM event is generated. Note: The OC1M[3] bit is not contiguous, located in bit 16.
    $07 constant TIM1_OC1CE                     \ [0x07] Output Compare 1 clear enable
    $08 constant TIM1_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM1_OC2FE                     \ [0x0a] Output Compare 2 fast enable Refer to OC1FE description.
    $0b constant TIM1_OC2PE                     \ [0x0b] Output Compare 2 preload enable Refer to OC1PE description.
    $0c constant TIM1_OC2M                      \ [0x0c : 3] OC2M[2:0]: Output Compare 2 mode Refer to OC1M[3:0] description.
    $0f constant TIM1_OC2CE                     \ [0x0f] Output Compare 2 clear enable Refer to OC1CE description.
    $10 constant TIM1_OC1M_1                    \ [0x10] OC1M[3]
    $18 constant TIM1_OC2M_1                    \ [0x18] OC2M[3]
  [then]


  [ifdef] TIM1_TIM1_CCMR2_DEF
    \
    \ @brief TIM1 capture/compare mode register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC3S                      \ [0x00 : 2] Capture/compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
    $02 constant TIM1_IC3PSC                    \ [0x02 : 2] Input capture 3 prescaler Refer to IC1PSC[1:0] description.
    $04 constant TIM1_IC3F                      \ [0x04 : 4] Input capture 3 filter Refer to IC1F[3:0] description.
    $08 constant TIM1_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
    $0a constant TIM1_IC4PSC                    \ [0x0a : 2] Input capture 4 prescaler Refer to IC1PSC[1:0] description.
    $0c constant TIM1_IC4F                      \ [0x0c : 4] Input capture 4 filter Refer to IC1F[3:0] description.
  [then]


  [ifdef] TIM1_TIM1_CCMR2_ALTERNATE1_DEF
    \
    \ @brief TIM1 capture/compare mode register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC3S                      \ [0x00 : 2] Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
    $02 constant TIM1_OC3FE                     \ [0x02] Output compare 3 fast enable Refer to OC1FE description.
    $03 constant TIM1_OC3PE                     \ [0x03] Output compare 3 preload enable Refer to OC1PE description.
    $04 constant TIM1_OC3M                      \ [0x04 : 3] OC3M[2:0]: Output compare 3 mode Refer to OC1M[3:0] description.
    $07 constant TIM1_OC3CE                     \ [0x07] Output compare 3 clear enable Refer to OC1CE description.
    $08 constant TIM1_CC4S                      \ [0x08 : 2] Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
    $0a constant TIM1_OC4FE                     \ [0x0a] Output compare 4 fast enable Refer to OC1FE description.
    $0b constant TIM1_OC4PE                     \ [0x0b] Output compare 4 preload enable Refer to OC1PE description.
    $0c constant TIM1_OC4M                      \ [0x0c : 3] OC4M[2:0]: Output compare 4 mode Refer to OC3M[3:0] description.
    $0f constant TIM1_OC4CE                     \ [0x0f] Output compare 4 clear enable Refer to OC1CE description.
    $10 constant TIM1_OC3M_1                    \ [0x10] OC3M[3]
    $18 constant TIM1_OC4M_1                    \ [0x18] OC4M[3]
  [then]


  [ifdef] TIM1_TIM1_CCER_DEF
    \
    \ @brief TIM1 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CC1E                      \ [0x00] Capture/Compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to Table 74 for details. Note: On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1E active bit takes the new value from the preloaded bit only when a Commutation event is generated.
    $01 constant TIM1_CC1P                      \ [0x01] Capture/Compare 1 output polarity When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: The configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register). Note: On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
    $02 constant TIM1_CC1NE                     \ [0x02] Capture/Compare 1 complementary output enable On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NE active bit takes the new value from the preloaded bit only when a Commutation event is generated.
    $03 constant TIM1_CC1NP                     \ [0x03] Capture/Compare 1 complementary output polarity CC1 channel configured as output: CC1 channel configured as input: This bit is used in conjunction with CC1P to define the polarity of TI1FP1 and TI2FP1. Refer to CC1P description. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S= 00 (channel configured as output). On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NP active bit takes the new value from the preloaded bit only when a Commutation event is generated.
    $04 constant TIM1_CC2E                      \ [0x04] Capture/Compare 2 output enable Refer to CC1E description
    $05 constant TIM1_CC2P                      \ [0x05] Capture/Compare 2 output polarity Refer to CC1P description
    $06 constant TIM1_CC2NE                     \ [0x06] Capture/Compare 2 complementary output enable Refer to CC1NE description
    $07 constant TIM1_CC2NP                     \ [0x07] Capture/Compare 2 complementary output polarity Refer to CC1NP description
    $08 constant TIM1_CC3E                      \ [0x08] Capture/Compare 3 output enable Refer to CC1E description
    $09 constant TIM1_CC3P                      \ [0x09] Capture/Compare 3 output polarity Refer to CC1P description
    $0a constant TIM1_CC3NE                     \ [0x0a] Capture/Compare 3 complementary output enable Refer to CC1NE description
    $0b constant TIM1_CC3NP                     \ [0x0b] Capture/Compare 3 complementary output polarity Refer to CC1NP description
    $0c constant TIM1_CC4E                      \ [0x0c] Capture/Compare 4 output enable Refer to CC1E description
    $0d constant TIM1_CC4P                      \ [0x0d] Capture/Compare 4 output polarity Refer to CC1P description
    $0f constant TIM1_CC4NP                     \ [0x0f] Capture/Compare 4 complementary output polarity Refer to CC1NP description
    $10 constant TIM1_CC5E                      \ [0x10] Capture/Compare 5 output enable Refer to CC1E description
    $11 constant TIM1_CC5P                      \ [0x11] Capture/Compare 5 output polarity Refer to CC1P description
    $14 constant TIM1_CC6E                      \ [0x14] Capture/Compare 6 output enable Refer to CC1E description
    $15 constant TIM1_CC6P                      \ [0x15] Capture/Compare 6 output polarity Refer to CC1P description
  [then]


  [ifdef] TIM1_TIM1_CNT_DEF
    \
    \ @brief TIM1 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CNT                       \ [0x00 : 16] Counter value
    $1f constant TIM1_UIFCPY                    \ [0x1f] UIF copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in the TIMxCR1 is reset, bit 31 is reserved and read at 0.
  [then]


  [ifdef] TIM1_TIM1_PSC_DEF
    \
    \ @brief TIM1 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_PSC                       \ [0x00 : 16] Prescaler value The counter clock frequency (CK_CNT) is equal to f<sub>CK_PSC</sub> / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in reset mode ).
  [then]


  [ifdef] TIM1_TIM1_ARR_DEF
    \
    \ @brief TIM1 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM1_ARR                       \ [0x00 : 16] Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the Section 17.3.1: Time-base unit on page 331 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.
  [then]


  [ifdef] TIM1_TIM1_RCR_DEF
    \
    \ @brief TIM1 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_REP                       \ [0x00 : 16] Repetition counter value These bits allow the user to set-up the update rate of the compare registers (i.e. periodic transfers from preload to active registers) when preload registers are enable, as well as the update interrupt generation rate, if this interrupt is enable. Each time the REP_CNT related downcounter reaches zero, an update event is generated and it restarts counting from REP value. As REP_CNT is reloaded with REP value only at the repetition update event U_RC, any write to the TIMx_RCR register is not taken in account until the next repetition update event. It means in PWM mode (REP+1) corresponds to: the number of PWM periods in edge-aligned mode the number of half PWM period in center-aligned mode.
  [then]


  [ifdef] TIM1_TIM1_CCR1_DEF
    \
    \ @brief TIM1 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR1                      \ [0x00 : 16] Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC1 output. If channel CC1 is configured as input: CR1 is the counter value transferred by the last input capture 1 event (IC1). The TIMx_CCR1 register is read-only and cannot be programmed.
  [then]


  [ifdef] TIM1_TIM1_CCR2_DEF
    \
    \ @brief TIM1 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR2                      \ [0x00 : 16] Capture/Compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC2 output. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 2 event (IC2). The TIMx_CCR2 register is read-only and cannot be programmed.
  [then]


  [ifdef] TIM1_TIM1_CCR3_DEF
    \
    \ @brief TIM1 capture/compare register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR3                      \ [0x00 : 16] Capture/Compare value If channel CC3 is configured as output: CCR3 is the value to be loaded in the actual capture/compare 3 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC3PE). Else the preload value is copied in the active capture/compare 3 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on OC3 output. If channel CC3 is configured as input: CCR3 is the counter value transferred by the last input capture 3 event (IC3). The TIMx_CCR3 register is read-only and cannot be programmed.
  [then]


  [ifdef] TIM1_TIM1_CCR4_DEF
    \
    \ @brief TIM1 capture/compare register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR4                      \ [0x00 : 16] Capture/Compare value If channel CC4 is configured as output: CCR4 is the value to be loaded in the actual capture/compare 4 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC4PE). Else the preload value is copied in the active capture/compare 4 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on OC4 output. If channel CC4 is configured as input: CCR4 is the counter value transferred by the last input capture 4 event (IC4). The TIMx_CCR4 register is read-only and cannot be programmed.
  [then]


  [ifdef] TIM1_TIM1_BDTR_DEF
    \
    \ @brief TIM1 break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_DTG                       \ [0x00 : 8] Dead-time generator setup
    $08 constant TIM1_LOCK                      \ [0x08 : 2] Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIMx_BDTR register has been written, their content is frozen until the next reset.
    $0a constant TIM1_OSSI                      \ [0x0a] Off-state selection for Idle mode This bit is used when MOE=0 due to a break event or by a software write, on channels configured as outputs. See OC/OCN enable description for more details (Section 17.4.11: TIM1 capture/compare enable register (TIM1_CCER)). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
    $0b constant TIM1_OSSR                      \ [0x0b] Off-state selection for Run mode This bit is used when MOE=1 on channels having a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See OC/OCN enable description for more details (Section 17.4.11: TIM1 capture/compare enable register (TIM1_CCER)). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
    $0c constant TIM1_BKE                       \ [0x0c] Break enable This bit enables the complete break protection (including all sources connected to bk_acth and BRK sources, as per Figure 100: Break and Break2 circuitry overview). Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0d constant TIM1_BKP                       \ [0x0d] Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0e constant TIM1_AOE                       \ [0x0e] Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0f constant TIM1_MOE                       \ [0x0f] Main output enable This bit is cleared asynchronously by hardware as soon as one of the break inputs is active (BRK or BRK2). It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. In response to a break event or if MOE is written to 0: OC and OCN outputs are disabled or forced to idle state depending on the OSSI bit. See OC/OCN enable description for more details (Section 17.4.11: TIM1 capture/compare enable register (TIM1_CCER)).
    $10 constant TIM1_BKF                       \ [0x10 : 4] Break filter This bit-field defines the frequency used to sample BRK input and the length of the digital filter applied to BRK. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output: Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $14 constant TIM1_BK2F                      \ [0x14 : 4] Break 2 filter This bit-field defines the frequency used to sample BRK2 input and the length of the digital filter applied to BRK2. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output: Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $18 constant TIM1_BK2E                      \ [0x18] Break 2 enable Note: The BRK2 must only be used with OSSR = OSSI = 1. Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $19 constant TIM1_BK2P                      \ [0x19] Break 2 polarity Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $1a constant TIM1_BKDSRM                    \ [0x1a] Break Disarm This bit is cleared by hardware when no break source is active. The BKDSRM bit must be set by software to release the bidirectional output control (open-drain output in Hi-Z state) and then be polled it until it is reset by hardware, indicating that the fault condition has disappeared. Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $1b constant TIM1_BK2DSRM                   \ [0x1b] Break2 Disarm Refer to BKDSRM description
    $1c constant TIM1_BKBID                     \ [0x1c] Break Bidirectional In the bidirectional mode (BKBID bit set to 1), the break input is configured both in input mode and in open drain output mode. Any active break event asserts a low logic level on the Break input to indicate an internal break event to external devices. Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $1d constant TIM1_BK2BID                    \ [0x1d] Break2 bidirectional Refer to BKBID description
  [then]


  [ifdef] TIM1_TIM1_DCR_DEF
    \
    \ @brief TIM1 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_DBA                       \ [0x00 : 5] DMA base address This 5-bits vector defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ...
    $08 constant TIM1_DBL                       \ [0x08 : 5] DMA burst length This 5-bit vector defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address), i.e. the number of transfers. Transfers can be in half-words or in bytes (see example below). ... Example: Let us consider the following transfer: DBL = 7 bytes & DBA = TIMx_CR1. If DBL = 7 bytes and DBA = TIMx_CR1 represents the address of the byte to be transferred, the address of the transfer should be given by the following equation: (TIMx_CR1 address) + DBA + (DMA index), where DMA index = DBL In this example, 7 bytes are added to (TIMx_CR1 address) + DBA, which gives us the address from/to which the data is copied. In this case, the transfer is done to 7 registers starting from the following address: (TIMx_CR1 address) + DBA According to the configuration of the DMA Data Size, several cases may occur: If the DMA Data Size is configured in half-words, 16-bit data is transferred to each of the 7 registers. If the DMA Data Size is configured in bytes, the data is also transferred to 7 registers: the first register contains the first MSB byte, the second register, the first LSB byte and so on. So with the transfer Timer, one also has to specify the size of data transferred by DMA.
  [then]


  [ifdef] TIM1_TIM1_DMAR_DEF
    \
    \ @brief TIM1 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_DMAB                      \ [0x00 : 32] DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).
  [then]


  [ifdef] TIM1_TIM1_CCMR3_DEF
    \
    \ @brief TIM1 capture/compare mode register 3
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant TIM1_OC5FE                     \ [0x02] Output compare 5 fast enable Refer to OC1FE description.
    $03 constant TIM1_OC5PE                     \ [0x03] Output compare 5 preload enable Refer to OC1PE description.
    $04 constant TIM1_OC5M                      \ [0x04 : 3] OC5M[2:0]: Output compare 5 mode Refer to OC1M description.
    $07 constant TIM1_OC5CE                     \ [0x07] Output compare 5 clear enable Refer to OC1CE description.
    $0a constant TIM1_OC6FE                     \ [0x0a] Output compare 6 fast enable Refer to OC1FE description.
    $0b constant TIM1_OC6PE                     \ [0x0b] Output compare 6 preload enable Refer to OC1PE description.
    $0c constant TIM1_OC6M                      \ [0x0c : 3] OC6M[2:0]: Output compare 6 mode Refer to OC1M description.
    $0f constant TIM1_OC6CE                     \ [0x0f] Output compare 6 clear enable Refer to OC1CE description.
    $10 constant TIM1_OC5M_1                    \ [0x10] OC5M[3]
    $18 constant TIM1_OC6M_1                    \ [0x18] OC6M[3]
  [then]


  [ifdef] TIM1_TIM1_CCR5_DEF
    \
    \ @brief TIM1 capture/compare register 5
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR5                      \ [0x00 : 16] Capture/Compare 5 value CCR5 is the value to be loaded in the actual capture/compare 5 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR3 register (bit OC5PE). Else the preload value is copied in the active capture/compare 5 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC5 output.
    $1d constant TIM1_GC5C1                     \ [0x1d] Group Channel 5 and Channel 1 Distortion on Channel 1 output: This bit can either have immediate effect or be preloaded and taken into account after an update event (if preload feature is selected in TIMxCCMR1). Note: it is also possible to apply this distortion on combined PWM signals.
    $1e constant TIM1_GC5C2                     \ [0x1e] Group Channel 5 and Channel 2 Distortion on Channel 2 output: This bit can either have immediate effect or be preloaded and taken into account after an update event (if preload feature is selected in TIMxCCMR1). Note: it is also possible to apply this distortion on combined PWM signals.
    $1f constant TIM1_GC5C3                     \ [0x1f] Group Channel 5 and Channel 3 Distortion on Channel 3 output: This bit can either have immediate effect or be preloaded and taken into account after an update event (if preload feature is selected in TIMxCCMR2). Note: it is also possible to apply this distortion on combined PWM signals.
  [then]


  [ifdef] TIM1_TIM1_CCR6_DEF
    \
    \ @brief TIM1 capture/compare register 6
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_CCR6                      \ [0x00 : 16] Capture/Compare 6 value CCR6 is the value to be loaded in the actual capture/compare 6 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR3 register (bit OC6PE). Else the preload value is copied in the active capture/compare 6 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC6 output.
  [then]


  [ifdef] TIM1_TIM1_AF1_DEF
    \
    \ @brief TIM1 alternate function option register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM1_BKINE                     \ [0x00] BRK BKIN input enable This bit enables the BKIN alternate function input for the timer s BRK input. BKIN input is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $09 constant TIM1_BKINP                     \ [0x09] BRK BKIN input polarity This bit selects the BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0e constant TIM1_ETRSEL                    \ [0x0e : 4] ETR source selection These bits select the ETR input source. Others: Reserved Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM1_TIM1_AF2_DEF
    \
    \ @brief TIM1 Alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000001
    \
    $00 constant TIM1_BK2INE                    \ [0x00] BRK2 BKIN input enable This bit enables the BKIN2 alternate function input for the timer s BRK2 input. BKIN2 input is ORed with the other BRK2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $09 constant TIM1_BK2INP                    \ [0x09] BRK2 BKIN2 input polarity This bit selects the BKIN2 alternate function input sensitivity. It must be programmed together with the BK2P polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM1_TIM1_TISEL_DEF
    \
    \ @brief TIM1 timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM1_TI1SEL                    \ [0x00 : 4] selects TI1[0] to TI1[15] input Others: Reserved
    $08 constant TIM1_TI2SEL                    \ [0x08 : 4] selects TI2[0] to TI2[15] input Others: Reserved
    $10 constant TIM1_TI3SEL                    \ [0x10 : 4] selects TI3[0] to TI3[15] input Others: Reserved
    $18 constant TIM1_TI4SEL                    \ [0x18 : 4] selects TI4[0] to TI4[15] input Others: Reserved
  [then]

  \
  \ @brief TIM1 address block description
  \
  $00 constant TIM1_TIM1_CR1            \ TIM1 control register 1
  $04 constant TIM1_TIM1_CR2            \ TIM1 control register 2
  $08 constant TIM1_TIM1_SMCR           \ TIM1 slave mode control register
  $0C constant TIM1_TIM1_DIER           \ TIM1 DMA/interrupt enable register
  $10 constant TIM1_TIM1_SR             \ TIM1 status register
  $14 constant TIM1_TIM1_EGR            \ TIM1 event generation register
  $18 constant TIM1_TIM1_CCMR1          \ TIM1 capture/compare mode register 1
  $18 constant TIM1_TIM1_CCMR1_ALTERNATE1    \ TIM1 capture/compare mode register 1
  $1C constant TIM1_TIM1_CCMR2          \ TIM1 capture/compare mode register 2
  $1C constant TIM1_TIM1_CCMR2_ALTERNATE1    \ TIM1 capture/compare mode register 2
  $20 constant TIM1_TIM1_CCER           \ TIM1 capture/compare enable register
  $24 constant TIM1_TIM1_CNT            \ TIM1 counter
  $28 constant TIM1_TIM1_PSC            \ TIM1 prescaler
  $2C constant TIM1_TIM1_ARR            \ TIM1 auto-reload register
  $30 constant TIM1_TIM1_RCR            \ TIM1 repetition counter register
  $34 constant TIM1_TIM1_CCR1           \ TIM1 capture/compare register 1
  $38 constant TIM1_TIM1_CCR2           \ TIM1 capture/compare register 2
  $3C constant TIM1_TIM1_CCR3           \ TIM1 capture/compare register 3
  $40 constant TIM1_TIM1_CCR4           \ TIM1 capture/compare register 4
  $44 constant TIM1_TIM1_BDTR           \ TIM1 break and dead-time register
  $48 constant TIM1_TIM1_DCR            \ TIM1 DMA control register
  $4C constant TIM1_TIM1_DMAR           \ TIM1 DMA address for full transfer
  $54 constant TIM1_TIM1_CCMR3          \ TIM1 capture/compare mode register 3
  $58 constant TIM1_TIM1_CCR5           \ TIM1 capture/compare register 5
  $5C constant TIM1_TIM1_CCR6           \ TIM1 capture/compare register 6
  $60 constant TIM1_TIM1_AF1            \ TIM1 alternate function option register 1
  $64 constant TIM1_TIM1_AF2            \ TIM1 Alternate function register 2
  $68 constant TIM1_TIM1_TISEL          \ TIM1 timer input selection register

: TIM1_DEF ; [then]
