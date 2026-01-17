\
\ @file tim15.fs
\ @brief TIM15 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM15_DEF

  [ifdef] TIM15_TIM15_CR1_DEF
    \
    \ @brief TIM15 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CEN                      \ [0x00] Counter enable Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
    $01 constant TIM15_UDIS                     \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM15_URS                      \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM15_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM15_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM15_CKD                      \ [0x08 : 2] Clock division This bitfield indicates the division ratio between the timer clock (tim_ker_ck) frequency and the dead-time and sampling clock (tDTS) used by the dead-time generators and the digital filters (tim_tix)
    $0b constant TIM15_UIFREMAP                 \ [0x0b] UIF status bit remapping
    $0c constant TIM15_DITHEN                   \ [0x0c] Dithering enable Note: The DITHEN bit can only be modified when CEN bit is reset.
  [then]


  [ifdef] TIM15_TIM15_CR2_DEF
    \
    \ @brief TIM15 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCPC                     \ [0x00] Capture/compare preloaded control Note: This bit acts only on channels that have a complementary output.
    $02 constant TIM15_CCUS                     \ [0x02] Capture/compare control update selection Note: This bit acts only on channels that have a complementary output.
    $03 constant TIM15_CCDS                     \ [0x03] Capture/compare DMA selection
    $04 constant TIM15_MMS                      \ [0x04 : 3] Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (tim_trgo). The combination is as follows:
    $07 constant TIM15_TI1S                     \ [0x07] tim_ti1 selection
    $08 constant TIM15_OIS1                     \ [0x08] Output Idle state 1 (tim_oc1 output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BKR register).
    $09 constant TIM15_OIS1N                    \ [0x09] Output Idle state 1 (tim_oc1n output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BKR register).
    $0a constant TIM15_OIS2                     \ [0x0a] Output idle state 2 (tim_oc2 output) Note: This bit cannot be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in the TIM15_BKR register).
  [then]


  [ifdef] TIM15_TIM15_SMCR_DEF
    \
    \ @brief TIM15 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_SMS                      \ [0x00 : 3] Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Others: Reserved. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS='00100'). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $04 constant TIM15_TS                       \ [0x04 : 3] Trigger selection This bit field selects the trigger input to be used to synchronize the counter. Others: Reserved See for more details on tim_itrx meaning for each timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
    $07 constant TIM15_MSM                      \ [0x07] Master/slave mode
    $10 constant TIM15_SMS_2                    \ [0x10] Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Others: Reserved. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS='00100'). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $14 constant TIM15_TS_2                     \ [0x14 : 2] Trigger selection This bit field selects the trigger input to be used to synchronize the counter. Others: Reserved See for more details on tim_itrx meaning for each timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
  [then]


  [ifdef] TIM15_TIM15_DIER_DEF
    \
    \ @brief TIM15 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM15_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM15_CC2IE                    \ [0x02] Capture/Compare 2 interrupt enable
    $05 constant TIM15_COMIE                    \ [0x05] COM interrupt enable
    $06 constant TIM15_TIE                      \ [0x06] Trigger interrupt enable
    $07 constant TIM15_BIE                      \ [0x07] Break interrupt enable
    $08 constant TIM15_UDE                      \ [0x08] Update DMA request enable
    $09 constant TIM15_CC1DE                    \ [0x09] Capture/Compare 1 DMA request enable
    $0d constant TIM15_COMDE                    \ [0x0d] COM DMA request enable
    $0e constant TIM15_TDE                      \ [0x0e] Trigger DMA request enable
  [then]


  [ifdef] TIM15_TIM15_SR_DEF
    \
    \ @brief TIM15 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UIF                      \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIM15_CR1 register. When CNT is reinitialized by software using the UG bit in TIM15_EGR register, if URS=0 and UDIS=0 in the TIM15_CR1 register. When CNT is reinitialized by a trigger event (refer to control register (TIM15_SMCR)), if URS=0 and UDIS=0 in the TIM15_CR1 register.
    $01 constant TIM15_CC1IF                    \ [0x01] Capture/Compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in downcounting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $02 constant TIM15_CC2IF                    \ [0x02] Capture/Compare 2 interrupt flag refer to CC1IF description
    $05 constant TIM15_COMIF                    \ [0x05] COM interrupt flag This flag is set by hardware on a COM event (once the capture/compare control bits CCxE, CCxNE, OCxMhave been updated). It is cleared by software.
    $06 constant TIM15_TIF                      \ [0x06] Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on tim_trgi input when the slave mode controller is enabled in all modes but gated mode, both edges in case gated mode is selected). It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
    $07 constant TIM15_BIF                      \ [0x07] Break interrupt flag This flag is set by hardware as soon as the break input goes active. It can be cleared by software if the break input is not active.
    $09 constant TIM15_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0'.
    $0a constant TIM15_CC2OF                    \ [0x0a] Capture/Compare 2 overcapture flag Refer to CC1OF description
  [then]


  [ifdef] TIM15_TIM15_EGR_DEF
    \
    \ @brief TIM15 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UG                       \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM15_CC1G                     \ [0x01] Capture/Compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. 1 A capture/compare event is generated on channel 1: If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIM15_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $02 constant TIM15_CC2G                     \ [0x02] Capture/Compare 2 generation Refer to CC1G description
    $05 constant TIM15_COMG                     \ [0x05] Capture/Compare control update generation This bit can be set by software, it is automatically cleared by hardware. Note: This bit acts only on channels that have a complementary output.
    $06 constant TIM15_TG                       \ [0x06] Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
    $07 constant TIM15_BG                       \ [0x07] Break generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM15_TIM15_CCMR1_Input_DEF
    \
    \ @brief TIM15 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIM15_CCER).
    $02 constant TIM15_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (tim_ic1). The prescaler is reset as soon as CC1E='0' (TIM15_CCER register).
    $04 constant TIM15_IC1F                     \ [0x04 : 4] Input capture 1 filter This bit-field defines the frequency used to sample tim_ti1 input and the length of the digital filter applied to tim_ti1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $08 constant TIM15_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = '0' in TIM15_CCER).
    $0a constant TIM15_IC2PSC                   \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM15_IC2F                     \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM15_TIM15_CCMR1_Output_DEF
    \
    \ @brief TIM15 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIM15_CCER).
    $02 constant TIM15_OC1FE                    \ [0x02] Output Compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM15_OC1PE                    \ [0x03] Output Compare 1 preload enable Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIM15_BDTR register) and CC1S='00' (the channel is configured in output). The PWM mode can be used without validating the preload register only in one pulse mode (OPM bit set in TIM15_CR1 register). Else the behavior is not guaranteed.
    $04 constant TIM15_OC1M1                    \ [0x04 : 3] Output compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 and tim_oc1n are derived. tim_oc1ref is active high whereas tim_oc1 and tim_oc1n active level depends on CC1P and CC1NP bits. Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIM15_BDTR register) and CC1S='00' (the channel is configured in output). In PWM mode, the tim_ocxref level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode. On channels that have a complementary output, this bit field is preloaded. If the CCPC bit is set in the TIM15_CR2 register then the OC1M active bits take the new value from the preloaded bits only when a COM event is generated.
    $07 constant TIM15_OC1CE                    \ [0x07] Output compare 1 clear enable
    $08 constant TIM15_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = '0' in TIM15_CCER).
    $0a constant TIM15_OC2FE                    \ [0x0a] Output compare 2 fast enable
    $0b constant TIM15_OC2PE                    \ [0x0b] Output compare 2 preload enable
    $0c constant TIM15_OC2M1                    \ [0x0c : 3] Output compare 2 mode
    $0f constant TIM15_OC2CE                    \ [0x0f] Output compare 2 clear enable
    $10 constant TIM15_OC1M2                    \ [0x10] Output compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 and tim_oc1n are derived. tim_oc1ref is active high whereas tim_oc1 and tim_oc1n active level depends on CC1P and CC1NP bits. Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIM15_BDTR register) and CC1S='00' (the channel is configured in output). In PWM mode, the tim_ocxref level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode. On channels that have a complementary output, this bit field is preloaded. If the CCPC bit is set in the TIM15_CR2 register then the OC1M active bits take the new value from the preloaded bits only when a COM event is generated.
    $18 constant TIM15_OC2M2                    \ [0x18] Output compare 2 mode
  [then]


  [ifdef] TIM15_TIM15_CCER_DEF
    \
    \ @brief TIM15 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1E                     \ [0x00] Capture/Compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to for details.
    $01 constant TIM15_CC1P                     \ [0x01] Capture/Compare 1 output polarity CC1 channel configured as output: When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register). On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIM15_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
    $02 constant TIM15_CC1NE                    \ [0x02] Capture/Compare 1 complementary output enable
    $03 constant TIM15_CC1NP                    \ [0x03] Capture/Compare 1 complementary output polarity CC1 channel configured as output: CC1 channel configured as input: This bit is used in conjunction with CC1P to define the polarity of tim_ti1fp1 and tim_ti2fp1. Refer to CC1P description. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register) and CC1S='00' (the channel is configured in output). On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIM15_CR2 register then the CC1NP active bit takes the new value from the preloaded bit only when a Commutation event is generated.
    $04 constant TIM15_CC2E                     \ [0x04] Capture/Compare 2 output enable Refer to CC1E description
    $05 constant TIM15_CC2P                     \ [0x05] Capture/Compare 2 output polarity Refer to CC1P description
    $07 constant TIM15_CC2NP                    \ [0x07] Capture/Compare 2 complementary output polarity Refer to CC1NP description
  [then]


  [ifdef] TIM15_TIM15_CNT_DEF
    \
    \ @brief TIM15 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CNT                      \ [0x00 : 16] Counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register only holds the non-dithered part in CNT[15:0]. The fractional part is not available.
    $1f constant TIM15_UIFCPY                   \ [0x1f] UIF Copy This bit is a read-only copy of the UIF bit in the TIM15_ISR register.
  [then]


  [ifdef] TIM15_TIM15_PSC_DEF
    \
    \ @brief TIM15 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_PSC                      \ [0x00 : 16] Prescaler value The counter clock frequency (ftim_cnt_ck) is equal to ftim_psc_ck / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIM15_EGR register or through trigger controller when configured in 'reset mode').
  [then]


  [ifdef] TIM15_TIM15_ARR_DEF
    \
    \ @brief TIM15 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM15_ARR                      \ [0x00 : 20] Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value in ARR[15:0]. The ARR[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[19:4]. The ARR[3:0] bitfield contains the dithered part.
  [then]


  [ifdef] TIM15_TIM15_RCR_DEF
    \
    \ @brief TIM15 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_REP                      \ [0x00 : 8] Repetition counter reload value This bitfield defines the update rate of the compare registers (i.e. periodic transfers from preload to active registers) when preload registers are enable. It also defines the update interrupt generation rate, if this interrupt is enable. When the repetition down-counter reaches zero, an update event is generated and it restarts counting from REP value. As the reptition counter is reloaded with REP value only at the repetition update event UEV, any write to the TIM15_RCR register is not taken in account until the next repetition update event. It means in PWM mode (REP+1) corresponds to the number of PWM periods in edge-aligned mode: the number of PWM periods in edge-aligned mode the number of half PWM period in center-aligned mode
  [then]


  [ifdef] TIM15_TIM15_CCR1_DEF
    \
    \ @brief TIM15 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR1                     \ [0x00 : 20] Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIM15_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIM15_CNT and signaled on tim_oc1 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR1[19:4]. The CCR1[3:0] bitfield contains the dithered part. If channel CC1 is configured as input: CR1 is the counter value transferred by the last input capture 1 event (tim_ic1). The TIMx_CCR1 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR1[19:4]. The CCR1[3:0] bits are reset.
  [then]


  [ifdef] TIM15_TIM15_CCR2_DEF
    \
    \ @brief TIM15 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR2                     \ [0x00 : 20] Capture/compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIM15_CCMR2 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIM15_CNT and signalled on tim_oc2 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR2[15:0]. The CCR2[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR2[19:4]. The CCR2[3:0] bitfield contains the dithered part. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 1 event (tim_ic2). The TIMx_CCR2 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR2[15:0]. The CCR2[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR2[19:4]. The CCR2[3:0] bits are reset.
  [then]


  [ifdef] TIM15_TIM15_BDTR_DEF
    \
    \ @brief TIM15 break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DTG                      \ [0x00 : 8] Dead-time generator setup This bit-field defines the duration of the dead-time inserted between the complementary outputs. DT correspond to this duration. DTG[7:5]=0xx = DT=DTG[7:0]x tdtg with tdtg=tDTS DTG[7:5]=10x = DT=(64+DTG[5:0])xtdtg with Tdtg=2xtDTS DTG[7:5]=110 = DT=(32+DTG[4:0])xtdtg with Tdtg=8xtDTS DTG[7:5]=111 = DT=(32+DTG[4:0])xtdtg with Tdtg=16xtDTS Example if TDTS=125ns (8MHz), dead-time possible values are: 0 to 15875 ns by 125 ns steps, 16 s to 31750 ns by 250 ns steps, 32 s to 63 s by 1 s steps, 64 s to 126 s by 2 s steps Note: This bit-field can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register).
    $08 constant TIM15_LOCK                     \ [0x08 : 2] Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIM15_BDTR register has been written, their content is frozen until the next reset.
    $0a constant TIM15_OSSI                     \ [0x0a] Off-state selection for Idle mode This bit is used when MOE=0 on channels configured as outputs. See tim_ocx/tim_ocxn enable description for more details (capture/compare enable register (TIM15_CCER) on page 1985). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIM15_BDTR register).
    $0b constant TIM15_OSSR                     \ [0x0b] Off-state selection for Run mode This bit is used when MOE=1 on channels that have a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See tim_ocx/tim_ocxn enable description for more details (capture/compare enable register (TIM15_CCER) on page 1985). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIM15_BDTR register).
    $0c constant TIM15_BKE                      \ [0x0c] Break enable 1; Break inputs (tim_brk and tim_sys_brk clock failure event) enabled This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0d constant TIM15_BKP                      \ [0x0d] Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register). Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0e constant TIM15_AOE                      \ [0x0e] Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $0f constant TIM15_MOE                      \ [0x0f] Main output enable This bit is cleared asynchronously by hardware as soon as the tim_brk input is active. It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. See tim_ocx/tim_ocxn enable description for more details (capture/compare enable register (TIM15_CCER) on page 1985).
    $10 constant TIM15_BKF                      \ [0x10 : 4] Break filter This bit-field defines the frequency used to sample the tim_brk input signal and the length of the digital filter applied to tim_brk. The digital filter is made of an event counter in which N events are needed to validate a transition on the output: Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $1a constant TIM15_BKDSRM                   \ [0x1a] Break disarm This bit is cleared by hardware when no break source is active. The BKDSRM bit must be set by software to release the bidirectional output control (open-drain output in Hi-Z state) and then be polled until it is reset by hardware, indicating that the fault condition has disappeared. Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $1c constant TIM15_BKBID                    \ [0x1c] Break bidirectional In the bidirectional mode (BKBID bit set to 1), the break input is configured both in input mode and in open drain output mode. Any active break event asserts a low logic level on the Break input to indicate an internal break event to external devices. Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
  [then]


  [ifdef] TIM15_TIM15_DTR2_DEF
    \
    \ @brief TIM15 timer deadtime register 2
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DTGF                     \ [0x00 : 8] Dead-time falling edge generator setup This bit-field defines the duration of the dead-time inserted between the complementary outputs, on the falling edge. DTGF[7:5]=0xx = DTF=DTGF[7:0]x tdtg with tdtg=tDTS. DTGF[7:5]=10x = DTF=(64+DTGF[5:0])xtdtg with Tdtg=2xtDTS. DTGF[7:5]=110 = DTF=(32+DTGF[4:0])xtdtg with Tdtg=8xtDTS. DTGF[7:5]=111 = DTF=(32+DTGF[4:0])xtdtg with Tdtg=16xtDTS. Example if TDTS=125ns (8MHz), dead-time possible values are: 0 to 15875 ns by 125 ns steps, 16 us to 31750 ns by 250 ns steps, 32 us to 63us by 1 us steps, 64 us to 126 us by 2 us steps Note: This bit-field can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register).
    $10 constant TIM15_DTAE                     \ [0x10] Deadtime asymmetric enable Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register).
    $11 constant TIM15_DTPE                     \ [0x11] Deadtime preload enable Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register).
  [then]


  [ifdef] TIM15_TIM15_TISEL_DEF
    \
    \ @brief TIM15 input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_TI1SEL                   \ [0x00 : 4] selects tim_ti1_in[0..15] input ... Refer to for interconnects list.
    $08 constant TIM15_TI2SEL                   \ [0x08 : 4] selects tim_ti2_in[0..15] input ... Refer to for interconnects list.
  [then]


  [ifdef] TIM15_TIM15_AF1_DEF
    \
    \ @brief TIM15 alternate function register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM15_BKINE                    \ [0x00] TIMx_BKIN input enable This bit enables the TIMx_BKIN alternate function input for the timer's tim_brk input. TIMx_BKIN input is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $01 constant TIM15_BKCMP1E                  \ [0x01] tim_brk_cmp1 enable This bit enables the tim_brk_cmp1 for the timer's tim_brk input. tim_brk_cmp1 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $02 constant TIM15_BKCMP2E                  \ [0x02] tim_brk_cmp2 enable This bit enables the tim_brk_cmp2 for the timer's tim_brk input. tim_brk_cmp2 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $03 constant TIM15_BKCMP3E                  \ [0x03] tim_brk_cmp3 enable This bit enables the tim_brk_cmp3 for the timer's tim_brk input. tim_brk_cmp3 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $04 constant TIM15_BKCMP4E                  \ [0x04] tim_brk_cmp4 enable This bit enables the tim_brk_cmp4 for the timer's tim_brk input. tim_brk_cmp4 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $05 constant TIM15_BKCMP5E                  \ [0x05] tim_brk_cmp5 enable This bit enables the tim_brk_cmp5 for the timer's tim_brk input. tim_brk_cmp5 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $06 constant TIM15_BKCMP6E                  \ [0x06] tim_brk_cmp6 enable This bit enables the tim_brk_cmp6 for the timer's tim_brk input. tim_brk_cmp6 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $07 constant TIM15_BKCMP7E                  \ [0x07] tim_brk_cmp7 enable This bit enables the tim_brk_cmp7 for the timer's tim_brk input. COMP7 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $08 constant TIM15_BKCMP8E                  \ [0x08] tim_brk_cmp8 enable This bit enables the tim_brk_cmp8 for the timer's tim_brk input. mdf_brkx output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $09 constant TIM15_BKINP                    \ [0x09] TIMx_BKIN input polarity This bit selects the TIMx_BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $0a constant TIM15_BKCMP1P                  \ [0x0a] tim_brk_cmp1 input polarity This bit selects the tim_brk_cmp1 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $0b constant TIM15_BKCMP2P                  \ [0x0b] tim_brk_cmp2 input polarity This bit selects the tim_brk_cmp2 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $0c constant TIM15_BKCMP3P                  \ [0x0c] tim_brk_cmp3 input polarity This bit selects the tim_brk_cmp3 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
    $0d constant TIM15_BKCMP4P                  \ [0x0d] tim_brk_cmp4 input polarity This bit selects the tim_brk_cmp4 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
  [then]


  [ifdef] TIM15_TIM15_AF2_DEF
    \
    \ @brief TIM15 alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $10 constant TIM15_OCRSEL                   \ [0x10 : 3] ocref_clr source selection These bits select the ocref_clr input source. Refer to for product specific implementation. Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIM15_BDTR register).
  [then]


  [ifdef] TIM15_TIM15_DCR_DEF
    \
    \ @brief TIM15 DMA control register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DBA                      \ [0x00 : 5] DMA base address This 5-bit field defines the base-address for DMA transfers (when read/write access are done through the TIM15_DMAR address). DBA is defined as an offset starting from the address of the TIM15_CR1 register. Example: ...
    $08 constant TIM15_DBL                      \ [0x08 : 5] DMA burst length This 5-bit field defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIM15_DMAR address). ...
    $10 constant TIM15_DBSS                     \ [0x10 : 4] DMA burst source selection This bitfield defines the interrupt source that triggers the DMA burst transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). Other: reserved
  [then]


  [ifdef] TIM15_TIM15_DMAR_DEF
    \
    \ @brief TIM15 DMA address for full transfer
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DMAB                     \ [0x00 : 32] DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIM15_CR1 address) + (DBA + DMA index) x 4 where TIM15_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIM15_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIM15_DCR).
  [then]

  \
  \ @brief TIM15 address block description
  \
  $00 constant TIM15_TIM15_CR1          \ TIM15 control register 1
  $04 constant TIM15_TIM15_CR2          \ TIM15 control register 2
  $08 constant TIM15_TIM15_SMCR         \ TIM15 slave mode control register
  $0C constant TIM15_TIM15_DIER         \ TIM15 DMA/interrupt enable register
  $10 constant TIM15_TIM15_SR           \ TIM15 status register
  $14 constant TIM15_TIM15_EGR          \ TIM15 event generation register
  $18 constant TIM15_TIM15_CCMR1_INPUT  \ TIM15 capture/compare mode register 1 [alternate]
  $18 constant TIM15_TIM15_CCMR1_OUTPUT \ TIM15 capture/compare mode register 1 [alternate]
  $20 constant TIM15_TIM15_CCER         \ TIM15 capture/compare enable register
  $24 constant TIM15_TIM15_CNT          \ TIM15 counter
  $28 constant TIM15_TIM15_PSC          \ TIM15 prescaler
  $2C constant TIM15_TIM15_ARR          \ TIM15 auto-reload register
  $30 constant TIM15_TIM15_RCR          \ TIM15 repetition counter register
  $34 constant TIM15_TIM15_CCR1         \ TIM15 capture/compare register 1
  $38 constant TIM15_TIM15_CCR2         \ TIM15 capture/compare register 2
  $44 constant TIM15_TIM15_BDTR         \ TIM15 break and dead-time register
  $54 constant TIM15_TIM15_DTR2         \ TIM15 timer deadtime register 2
  $5C constant TIM15_TIM15_TISEL        \ TIM15 input selection register
  $60 constant TIM15_TIM15_AF1          \ TIM15 alternate function register 1
  $64 constant TIM15_TIM15_AF2          \ TIM15 alternate function register 2
  $3DC constant TIM15_TIM15_DCR         \ TIM15 DMA control register
  $3E0 constant TIM15_TIM15_DMAR        \ TIM15 DMA address for full transfer

: TIM15_DEF ; [then]
