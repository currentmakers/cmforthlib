\
\ @file tim8.fs
\ @brief TIM8 Break Interrupt
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

$00000001 constant TIM8_TIM1_CR1_CEN                                \ Counter enable Note: External clock, gated mode and encoder mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
$00000002 constant TIM8_TIM1_CR1_UDIS                               \ Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
$00000004 constant TIM8_TIM1_CR1_URS                                \ Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
$00000008 constant TIM8_TIM1_CR1_OPM                                \ One pulse mode
$00000010 constant TIM8_TIM1_CR1_DIR                                \ Direction Note: This bit is read only when the timer is configured in Center-aligned mode or Encoder mode.
$00000060 constant TIM8_TIM1_CR1_CMS                                \ Center-aligned mode selection Note: It is not allowed to switch from edge-aligned mode to center-aligned mode as long as the counter is enabled (CEN=1)
$00000080 constant TIM8_TIM1_CR1_ARPE                               \ Auto-reload preload enable
$00000300 constant TIM8_TIM1_CR1_CKD                                \ Clock division This bit-field indicates the division ratio between the timer clock (tim_ker_ck) frequency and the dead-time and sampling clock (tDTS)used by the dead-time generators and the digital filters (tim_etr_in, tim_tix),
$00000800 constant TIM8_TIM1_CR1_UIFREMAP                           \ UIF status bit remapping
$00001000 constant TIM8_TIM1_CR1_DITHEN                             \ Dithering enable Note: The DITHEN bit can only be modified when CEN bit is reset.


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM1_CR2_CCPC                               \ Capture/compare preloaded control
$00000004 constant TIM8_TIM1_CR2_CCUS                               \ Capture/compare control update selection
$00000008 constant TIM8_TIM1_CR2_CCDS                               \ Capture/compare DMA selection
$00000070 constant TIM8_TIM1_CR2_MMS0_2                             \ Master mode selection
$00000080 constant TIM8_TIM1_CR2_TI1S                               \ TI1 selection
$00000100 constant TIM8_TIM1_CR2_OIS1                               \ Output Idle state 1
$00000200 constant TIM8_TIM1_CR2_OIS1N                              \ Output Idle state 1
$00000400 constant TIM8_TIM1_CR2_OIS2                               \ Output Idle state 2
$00000800 constant TIM8_TIM1_CR2_OIS2N                              \ Output Idle state 2
$00001000 constant TIM8_TIM1_CR2_OIS3                               \ Output Idle state 3
$00002000 constant TIM8_TIM1_CR2_OIS3N                              \ Output Idle state 3
$00004000 constant TIM8_TIM1_CR2_OIS4                               \ Output Idle state 4
$00008000 constant TIM8_TIM1_CR2_OIS4N                              \ Output Idle state 4 (OC5 output)
$00010000 constant TIM8_TIM1_CR2_OIS5                               \ Output Idle state 5
$00040000 constant TIM8_TIM1_CR2_OIS6                               \ Output Idle state 6
$00f00000 constant TIM8_TIM1_CR2_MMS2                               \ Master mode selection 2
$02000000 constant TIM8_TIM1_CR2_MMS_3                              \ Master mode selection 2


\
\ @brief TIM1 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM8_TIM1_SMCR_SMS1                              \ Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo or the tim_trgo2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
$00000008 constant TIM8_TIM1_SMCR_OCCS                              \ OCREF clear selection This bit is used to select the OCREF clear source.
$00000070 constant TIM8_TIM1_SMCR_TS1                               \ Trigger selection - bit 4:3 Refer to TS[2:0] description - bits 6:4 null Trigger selection This bitfield is combined with TS[4:3] bits. This bit-field selects the trigger input to be used to synchronize the counter. others: Reserved See for more details on tim_itrx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
$00000080 constant TIM8_TIM1_SMCR_MSM                               \ Master/slave mode
$00000f00 constant TIM8_TIM1_SMCR_ETF                               \ External trigger filter This bit-field then defines the frequency used to sample tim_etrp signal and the length of the digital filter applied to tim_etrp. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
$00003000 constant TIM8_TIM1_SMCR_ETPS                              \ External trigger prescaler External trigger signal tim_etrp frequency must be at most 1/4 of TIMxCLK frequency. A prescaler can be enabled to reduce tim_etrp frequency. It is useful when inputting fast external clocks on tim_etr_in.
$00004000 constant TIM8_TIM1_SMCR_ECE                               \ External clock enable This bit enables External clock mode 2. Note: Setting the ECE bit has the same effect as selecting external clock mode 1 with tim_trgi connected to tim_etrf (SMS=111 and TS=00111). It is possible to simultaneously use external clock mode 2 with the following slave modes: reset mode, gated mode and trigger mode. Nevertheless, tim_trgi must not be connected to tim_etrf in this case (TS bits must not be 00111). If external clock mode 1 and external clock mode 2 are enabled at the same time, the external clock input is tim_etrf.
$00008000 constant TIM8_TIM1_SMCR_ETP                               \ External trigger polarity This bit selects whether tim_etr_in or tim_etr_in is used for trigger operations
$00010000 constant TIM8_TIM1_SMCR_SMS2                              \ Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo or the tim_trgo2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
$00300000 constant TIM8_TIM1_SMCR_TS2                               \ Trigger selection - bit 4:3 Refer to TS[2:0] description - bits 6:4 null Trigger selection This bitfield is combined with TS[4:3] bits. This bit-field selects the trigger input to be used to synchronize the counter. others: Reserved See for more details on tim_itrx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
$01000000 constant TIM8_TIM1_SMCR_SMSPE                             \ SMS preload enable This bit selects whether the SMS[3:0] bitfield is preloaded
$02000000 constant TIM8_TIM1_SMCR_SMSPS                             \ SMS preload source This bit selects whether the events that triggers the SMS[3:0] bitfield transfer from preload to active


\
\ @brief TIM1 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM1_DIER_UIE                               \ Update interrupt enable
$00000002 constant TIM8_TIM1_DIER_CC1IE                             \ Capture/compare 1 interrupt enable
$00000004 constant TIM8_TIM1_DIER_CC2IE                             \ Capture/compare 2 interrupt enable
$00000008 constant TIM8_TIM1_DIER_CC3IE                             \ Capture/compare 3 interrupt enable
$00000010 constant TIM8_TIM1_DIER_CC4IE                             \ Capture/compare 4 interrupt enable
$00000020 constant TIM8_TIM1_DIER_COMIE                             \ COM interrupt enable
$00000040 constant TIM8_TIM1_DIER_TIE                               \ Trigger interrupt enable
$00000080 constant TIM8_TIM1_DIER_BIE                               \ Break interrupt enable
$00000100 constant TIM8_TIM1_DIER_UDE                               \ Update DMA request enable
$00000200 constant TIM8_TIM1_DIER_CC1DE                             \ Capture/compare 1 DMA request enable
$00000400 constant TIM8_TIM1_DIER_CC2DE                             \ Capture/compare 2 DMA request enable
$00000800 constant TIM8_TIM1_DIER_CC3DE                             \ Capture/compare 3 DMA request enable
$00001000 constant TIM8_TIM1_DIER_CC4DE                             \ Capture/compare 4 DMA request enable
$00002000 constant TIM8_TIM1_DIER_COMDE                             \ COM DMA request enable
$00004000 constant TIM8_TIM1_DIER_TDE                               \ Trigger DMA request enable
$00100000 constant TIM8_TIM1_DIER_IDXIE                             \ Index interrupt enable
$00200000 constant TIM8_TIM1_DIER_DIRIE                             \ Direction change interrupt enable
$00400000 constant TIM8_TIM1_DIER_IERRIE                            \ Index error interrupt enable
$00800000 constant TIM8_TIM1_DIER_TERRIE                            \ Transition error interrupt enable


\
\ @brief TIM1 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM1_SR_UIF                                 \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to control register (TIMx_SMCR)(x = 1, 8)), if URS=0 and UDIS=0 in the TIMx_CR1 register.
$00000002 constant TIM8_TIM1_SR_CC1IF                               \ Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in downcounting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
$00000004 constant TIM8_TIM1_SR_CC2IF                               \ Capture/compare 2 interrupt flag Refer to CC1IF description
$00000008 constant TIM8_TIM1_SR_CC3IF                               \ Capture/compare 3 interrupt flag Refer to CC1IF description
$00000010 constant TIM8_TIM1_SR_CC4IF                               \ Capture/compare 4 interrupt flag Refer to CC1IF description
$00000020 constant TIM8_TIM1_SR_COMIF                               \ COM interrupt flag This flag is set by hardware on COM event (when capture/compare Control bits - CCxE, CCxNE, OCxM - have been updated). It is cleared by software.
$00000040 constant TIM8_TIM1_SR_TIF                                 \ Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on tim_trgi input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
$00000080 constant TIM8_TIM1_SR_BIF                                 \ Break interrupt flag This flag is set by hardware as soon as the break input goes active. It can be cleared by software if the break input is not active.
$00000100 constant TIM8_TIM1_SR_B2IF                                \ Break 2 interrupt flag This flag is set by hardware as soon as the break 2 input goes active. It can be cleared by software if the break 2 input is not active.
$00000200 constant TIM8_TIM1_SR_CC1OF                               \ Capture/compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0â.
$00000400 constant TIM8_TIM1_SR_CC2OF                               \ Capture/compare 2 overcapture flag Refer to CC1OF description
$00000800 constant TIM8_TIM1_SR_CC3OF                               \ Capture/compare 3 overcapture flag Refer to CC1OF description
$00001000 constant TIM8_TIM1_SR_CC4OF                               \ Capture/compare 4 overcapture flag Refer to CC1OF description
$00002000 constant TIM8_TIM1_SR_SBIF                                \ System break interrupt flag This flag is set by hardware as soon as the system break input goes active. It can be cleared by software if the system break input is not active. This flag must be reset to re-start PWM operation.
$00010000 constant TIM8_TIM1_SR_CC5IF                               \ Compare 5 interrupt flag Refer to CC1IF description Note: Channel 5 can only be configured as output.
$00020000 constant TIM8_TIM1_SR_CC6IF                               \ Compare 6 interrupt flag Refer to CC1IF description Note: Channel 6 can only be configured as output.
$00100000 constant TIM8_TIM1_SR_IDXF                                \ Index interrupt flag This flag is set by hardware when an index event is detected. It is cleared by software by writing it to '0â.
$00200000 constant TIM8_TIM1_SR_DIRF                                \ Direction change interrupt flag This flag is set by hardware when the direction changes in encoder mode (DIR bit value in TIMx_CR is changing). It is cleared by software by writing it to '0â.
$00400000 constant TIM8_TIM1_SR_IERRF                               \ Index error interrupt flag This flag is set by hardware when an index error is detected. It is cleared by software by writing it to '0â.
$00800000 constant TIM8_TIM1_SR_TERRF                               \ Transition error interrupt flag This flag is set by hardware when a transition error is detected in encoder mode. It is cleared by software by writing it to '0â.


\
\ @brief TIM1 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM1_EGR_UG                                 \ Update generation This bit can be set by software, it is automatically cleared by hardware.
$00000002 constant TIM8_TIM1_EGR_CC1G                               \ Capture/compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
$00000004 constant TIM8_TIM1_EGR_CC2G                               \ Capture/compare 2 generation Refer to CC1G description
$00000008 constant TIM8_TIM1_EGR_CC3G                               \ Capture/compare 3 generation Refer to CC1G description
$00000010 constant TIM8_TIM1_EGR_CC4G                               \ Capture/compare 4 generation Refer to CC1G description
$00000020 constant TIM8_TIM1_EGR_COMG                               \ Capture/compare control update generation This bit can be set by software, it is automatically cleared by hardware Note: This bit acts only on channels having a complementary output.
$00000040 constant TIM8_TIM1_EGR_TG                                 \ Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
$00000080 constant TIM8_TIM1_EGR_BG                                 \ Break generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
$00000100 constant TIM8_TIM1_EGR_B2G                                \ Break 2 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM8_TIM1_CCMR1_OUTPUT_CC1S                      \ Capture/Compare 1 selection
$00000004 constant TIM8_TIM1_CCMR1_OUTPUT_OC1FE                     \ Output Compare 1 fast enable
$00000008 constant TIM8_TIM1_CCMR1_OUTPUT_OC1PE                     \ Output Compare 1 preload enable
$00000070 constant TIM8_TIM1_CCMR1_OUTPUT_OC1M                      \ Output Compare 1 mode
$00000080 constant TIM8_TIM1_CCMR1_OUTPUT_OC1CE                     \ Output Compare 1 clear enable
$00000300 constant TIM8_TIM1_CCMR1_OUTPUT_CC2S                      \ Capture/Compare 2 selection
$00000400 constant TIM8_TIM1_CCMR1_OUTPUT_OC2FE                     \ Output Compare 2 fast enable
$00000800 constant TIM8_TIM1_CCMR1_OUTPUT_OC2PE                     \ Output Compare 2 preload enable
$00007000 constant TIM8_TIM1_CCMR1_OUTPUT_OC2M                      \ Output Compare 2 mode
$00008000 constant TIM8_TIM1_CCMR1_OUTPUT_OC2CE                     \ Output Compare 2 clear enable
$00010000 constant TIM8_TIM1_CCMR1_OUTPUT_OC1M_BIT3                 \ Output Compare 1 mode - bit 3
$01000000 constant TIM8_TIM1_CCMR1_OUTPUT_OC2M_BIT3                 \ Output Compare 2 mode - bit 3


\
\ @brief TIM1 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM8_TIM1_CCMR1_INPUT_CC1S                       \ Capture/compare 1 Selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = '0â in TIMx_CCER).
$0000000c constant TIM8_TIM1_CCMR1_INPUT_IC1PSC                     \ Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (tim_ic1). The prescaler is reset as soon as CC1E=â0â (TIMx_CCER register).
$000000f0 constant TIM8_TIM1_CCMR1_INPUT_IC1F                       \ Input capture 1 filter This bit-field defines the frequency used to sample tim_ti1 input and the length of the digital filter applied to tim_ti1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
$00000300 constant TIM8_TIM1_CCMR1_INPUT_CC2S                       \ Capture/compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = '0â in TIMx_CCER).
$00000c00 constant TIM8_TIM1_CCMR1_INPUT_IC2PSC                     \ Input capture 2 prescaler
$0000f000 constant TIM8_TIM1_CCMR1_INPUT_IC2F                       \ Input capture 2 filter


\
\ @brief capture/compare mode register 2 (output mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM8_TIM1_CCMR2_OUTPUT_CC3S_1_0                  \ Capture/Compare 3 selection
$00000004 constant TIM8_TIM1_CCMR2_OUTPUT_OC3FE                     \ Output compare 3 fast enable
$00000008 constant TIM8_TIM1_CCMR2_OUTPUT_OC3PE                     \ Output compare 3 preload enable
$00000070 constant TIM8_TIM1_CCMR2_OUTPUT_OC3M_2_0                  \ Output compare 3 mode
$00000080 constant TIM8_TIM1_CCMR2_OUTPUT_OC3CE                     \ Output compare 3 clear enable
$00000300 constant TIM8_TIM1_CCMR2_OUTPUT_CC4S_1_0                  \ Capture/Compare 4 selection
$00000400 constant TIM8_TIM1_CCMR2_OUTPUT_OC4FE                     \ Output compare 4 fast enable
$00000800 constant TIM8_TIM1_CCMR2_OUTPUT_OC4PE                     \ Output compare 4 preload enable
$00007000 constant TIM8_TIM1_CCMR2_OUTPUT_OC4M_3_0                  \ Output compare 4 mode
$00008000 constant TIM8_TIM1_CCMR2_OUTPUT_OC4CE                     \ Output compare 4 clear enable
$00010000 constant TIM8_TIM1_CCMR2_OUTPUT_OC3M_3                    \ Output compare 3 mode
$01000000 constant TIM8_TIM1_CCMR2_OUTPUT_OC4M_BIT3                 \ Output Compare 4 mode - bit 3


\
\ @brief TIM1 capture/compare mode register 2 [alternate]
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM8_TIM1_CCMR2_INPUT_CC3S                       \ Capture/compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = '0â in TIMx_CCER).
$0000000c constant TIM8_TIM1_CCMR2_INPUT_IC3PSC                     \ Input capture 3 prescaler
$000000f0 constant TIM8_TIM1_CCMR2_INPUT_IC3F                       \ Input capture 3 filter
$00000300 constant TIM8_TIM1_CCMR2_INPUT_CC4S                       \ Capture/compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = '0â in TIMx_CCER).
$00000c00 constant TIM8_TIM1_CCMR2_INPUT_IC4PSC                     \ Input capture 4 prescaler
$0000f000 constant TIM8_TIM1_CCMR2_INPUT_IC4F                       \ Input capture 4 filter


\
\ @brief TIM1 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM1_CCER_CC1E                              \ Capture/compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to for details. Note: On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1E active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000002 constant TIM8_TIM1_CCER_CC1P                              \ Capture/compare 1 output polarity When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: the configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register). Note: On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000004 constant TIM8_TIM1_CCER_CC1NE                             \ Capture/compare 1 complementary output enable Note: On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NE active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000008 constant TIM8_TIM1_CCER_CC1NP                             \ Capture/compare 1 complementary output polarity CC1 channel configured as output: CC1 channel configured as input: This bit is used in conjunction with CC1P to define the polarity of tim_ti1fp1 and tim_ti2fp1. Refer to CC1P description. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S=â00â (channel configured as output). Note: On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NP active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000010 constant TIM8_TIM1_CCER_CC2E                              \ Capture/compare 2 output enable Refer to CC1E description
$00000020 constant TIM8_TIM1_CCER_CC2P                              \ Capture/compare 2 output polarity Refer to CC1P description
$00000040 constant TIM8_TIM1_CCER_CC2NE                             \ Capture/compare 2 complementary output enable Refer to CC1NE description
$00000080 constant TIM8_TIM1_CCER_CC2NP                             \ Capture/compare 2 complementary output polarity Refer to CC1NP description
$00000100 constant TIM8_TIM1_CCER_CC3E                              \ Capture/compare 3 output enable Refer to CC1E description
$00000200 constant TIM8_TIM1_CCER_CC3P                              \ Capture/compare 3 output polarity Refer to CC1P description
$00000400 constant TIM8_TIM1_CCER_CC3NE                             \ Capture/compare 3 complementary output enable Refer to CC1NE description
$00000800 constant TIM8_TIM1_CCER_CC3NP                             \ Capture/compare 3 complementary output polarity Refer to CC1NP description
$00001000 constant TIM8_TIM1_CCER_CC4E                              \ Capture/compare 4 output enable Refer to CC1E description
$00002000 constant TIM8_TIM1_CCER_CC4P                              \ Capture/compare 4 output polarity Refer to CC1P description
$00004000 constant TIM8_TIM1_CCER_CC4NE                             \ Capture/compare 4 complementary output enable Refer to CC1NE description
$00008000 constant TIM8_TIM1_CCER_CC4NP                             \ Capture/compare 4 complementary output polarity Refer to CC1NP description
$00010000 constant TIM8_TIM1_CCER_CC5E                              \ Capture/compare 5 output enable Refer to CC1E description
$00020000 constant TIM8_TIM1_CCER_CC5P                              \ Capture/compare 5 output polarity Refer to CC1P description
$00100000 constant TIM8_TIM1_CCER_CC6E                              \ Capture/compare 6 output enable Refer to CC1E description
$00200000 constant TIM8_TIM1_CCER_CC6P                              \ Capture/compare 6 output polarity Refer to CC1P description


\
\ @brief TIM1 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM8_TIM1_CNT_CNT                                \ Counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register only holds the non-dithered part in CNT[15:0]. The fractional part is not available.
$80000000 constant TIM8_TIM1_CNT_UIFCPY                             \ UIF copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in the TIMxCR1 is reset, bit 31 is reserved and read at 0.


\
\ @brief TIM1 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM8_TIM1_PSC_PSC                                \ Prescaler value The counter clock frequency (ftim_cnt_ck) is equal to ftim_psc_ck / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in âreset modeâ).


\
\ @brief TIM1 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM8_TIM1_ARR_ARR                                \ Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[19:4]. The ARR[3:0] bitfield contains the dithered part.


\
\ @brief TIM1 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant TIM8_TIM1_RCR_REP                                \ Repetition counter reload value This bitfield defines the update rate of the compare registers (i.e. periodic transfers from preload to active registers) when preload registers are enable. It also defines the update interrupt generation rate, if this interrupt is enable. When the repetition down-counter reaches zero, an update event is generated and it restarts counting from REP value. As the repetition counter is reloaded with REP value only at the repetition update event UEV, any write to the TIMx_RCR register is not taken in account until the next repetition update event. It means in PWM mode (REP+1) corresponds to: the number of PWM periods in edge-aligned mode the number of half PWM period in center-aligned mode.


\
\ @brief TIM1 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM1_CCR1_CCR1                              \ Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc1 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR1[19:4]. The CCR1[3:0] bitfield contains the dithered part. If channel CC1 is configured as input: CR1 is the counter value transferred by the last input capture 1 event (tim_ic1). The TIMx_CCR1 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR1[19:4]. The CCR1[3:0] bits are reset.


\
\ @brief TIM1 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM1_CCR2_CCR2                              \ Capture/compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc2 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR2[15:0]. The CCR2[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR2[19:4]. The CCR2[3:0] bitfield contains the dithered part. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 2 event (tim_ic2). The TIMx_CCR2 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR2[15:0]. The CCR2[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR2[19:4]. The CCR2[3:0] bits are reset.


\
\ @brief TIM1 capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM1_CCR3_CCR3                              \ Capture/compare value If channel CC3 is configured as output: CCR3 is the value to be loaded in the actual capture/compare 3 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC3PE). Else the preload value is copied in the active capture/compare 3 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc3 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR3[15:0]. The CCR3[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR3[19:4]. The CCR3[3:0] bitfield contains the dithered part. If channel CC3 is configured as input: CCR3 is the counter value transferred by the last input capture 3 event (tim_ic3). The TIMx_CCR3 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR3[15:0]. The CCR3[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR3[19:4]. The CCR3[3:0] bits are reset.


\
\ @brief TIM1 capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM1_CCR4_CCR4                              \ Capture/compare value If channel CC4 is configured as output: CCR4 is the value to be loaded in the actual capture/compare 4 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC4PE). Else the preload value is copied in the active capture/compare 4 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on tim_oc4 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR4[15:0]. The CCR4[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR4[19:4]. The CCR4[3:0] bitfield contains the dithered part. If channel CC4 is configured as input: CCR4 is the counter value transferred by the last input capture 4 event (tim_ic4). The TIMx_CCR4 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR4[15:0]. The CCR4[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR4[19:4]. The CCR4[3:0] bits are reset.


\
\ @brief TIM1 break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM8_TIM1_BDTR_DTG                               \ Dead-time generator setup This bit-field defines the duration of the dead-time inserted between the complementary outputs. DT correspond to this duration. DTG[7:5]=0xx => DT=DTG[7:0]x tdtg with tdtg=tDTS. DTG[7:5]=10x => DT=(64+DTG[5:0])xtdtg with Tdtg=2xtDTS. DTG[7:5]=110 => DT=(32+DTG[4:0])xtdtg with Tdtg=8xtDTS. DTG[7:5]=111 => DT=(32+DTG[4:0])xtdtg with Tdtg=16xtDTS. Example if TDTS=125ns (8MHz), dead-time possible values are: 0 to 15875 ns by 125 ns steps, 16 us to 31750 ns by 250 ns steps, 32 us to 63us by 1 us steps, 64 us to 126 us by 2 us steps Note: This bit-field can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
$00000300 constant TIM8_TIM1_BDTR_LOCK                              \ Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIMx_BDTR register has been written, their content is frozen until the next reset.
$00000400 constant TIM8_TIM1_BDTR_OSSI                              \ Off-state selection for idle mode This bit is used when MOE=0 due to a break event or by a software write, on channels configured as outputs. See OC/OCN enable description for more details (enable register (TIMx_CCER)(x = 1, 8)). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00000800 constant TIM8_TIM1_BDTR_OSSR                              \ Off-state selection for Run mode This bit is used when MOE=1 on channels having a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See OC/OCN enable description for more details (enable register (TIMx_CCER)(x = 1, 8)). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00001000 constant TIM8_TIM1_BDTR_BKE                               \ Break enable This bit enables the complete break protection (including all sources connected to bk_acth and BKIN sources, as per ). Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00002000 constant TIM8_TIM1_BDTR_BKP                               \ Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00004000 constant TIM8_TIM1_BDTR_AOE                               \ Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00008000 constant TIM8_TIM1_BDTR_MOE                               \ Main output enable This bit is cleared asynchronously by hardware as soon as one of the break inputs is active (tim_brk or tim_brk2). It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. In response to a break event or if MOE is written to 0: OC and OCN outputs are disabled or forced to idle state depending on the OSSI bit. enable register (TIMx_CCER)(x = 1, 8)).
$000f0000 constant TIM8_TIM1_BDTR_BKF                               \ Break filter This bit-field defines the frequency used to sample tim_brk input and the length of the digital filter applied to tim_brk. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output: Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00f00000 constant TIM8_TIM1_BDTR_BK2F                              \ Break 2 filter This bit-field defines the frequency used to sample tim_brk2 input and the length of the digital filter applied to tim_brk2. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output: Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$01000000 constant TIM8_TIM1_BDTR_BK2E                              \ Break 2 enable This bit enables the complete break 2 protection (including all sources connected to bk_acth and BKIN sources, as per ). Note: The BRKIN2 must only be used with OSSR = OSSI = 1. Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$02000000 constant TIM8_TIM1_BDTR_BK2P                              \ Break 2 polarity Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$04000000 constant TIM8_TIM1_BDTR_BKDSRM                            \ Break disarm This bit is cleared by hardware when no break source is active. The BKDSRM bit must be set by software to release the bidirectional output control (open-drain output in Hi-Z state) and then be polled it until it is reset by hardware, indicating that the fault condition has disappeared. Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$08000000 constant TIM8_TIM1_BDTR_BK2DSRM                           \ Break2 disarm Refer to BKDSRM description
$10000000 constant TIM8_TIM1_BDTR_BKBID                             \ Break bidirectional In the bidirectional mode (BKBID bit set to 1), the break input is configured both in input mode and in open drain output mode. Any active break event asserts a low logic level on the Break input to indicate an internal break event to external devices. Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$20000000 constant TIM8_TIM1_BDTR_BK2BID                            \ Break2 bidirectional Refer to BKBID description


\
\ @brief TIM1 capture/compare register 5
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM1_CCR5_CCR5                              \ Capture/compare 5 value CCR5 is the value to be loaded in the actual capture/compare 5 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR3 register (bit OC5PE). Else the preload value is copied in the active capture/compare 5 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc5 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR5[15:0]. The CCR5[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR5[19:4]. The CCR5[3:0] bitfield contains the dithered part.
$20000000 constant TIM8_TIM1_CCR5_GC5C1                             \ Group channel 5 and channel 1 Distortion on channel 1 output: This bit can either have immediate effect or be preloaded and taken into account after an update event (if preload feature is selected in TIMxCCMR1). Note: it is also possible to apply this distortion on combined PWM signals.
$40000000 constant TIM8_TIM1_CCR5_GC5C2                             \ Group channel 5 and channel 2 Distortion on channel 2 output: This bit can either have immediate effect or be preloaded and taken into account after an update event (if preload feature is selected in TIMxCCMR1). Note: it is also possible to apply this distortion on combined PWM signals.
$80000000 constant TIM8_TIM1_CCR5_GC5C3                             \ Group channel 5 and channel 3 Distortion on channel 3 output: This bit can either have immediate effect or be preloaded and taken into account after an update event (if preload feature is selected in TIMxCCMR2). Note: it is also possible to apply this distortion on combined PWM signals.


\
\ @brief TIM1 capture/compare register 6
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM1_CCR6_CCR6                              \ Capture/compare 6 value CCR6 is the value to be loaded in the actual capture/compare 6 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR3 register (bit OC6PE). Else the preload value is copied in the active capture/compare 6 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc6 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR6[15:0]. The CCR6[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR6[19:4]. The CCR6[3:0] bitfield contains the dithered part.


\
\ @brief TIM1 capture/compare mode register 3
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000004 constant TIM8_TIM1_CCMR3_OC5FE                            \ Output compare 5 fast enable
$00000008 constant TIM8_TIM1_CCMR3_OC5PE                            \ Output compare 5 preload enable
$00000070 constant TIM8_TIM1_CCMR3_OC5M1                            \ Output compare 5 mode
$00000080 constant TIM8_TIM1_CCMR3_OC5CE                            \ Output compare 5 clear enable
$00000400 constant TIM8_TIM1_CCMR3_OC6FE                            \ Output compare 6 fast enable
$00000800 constant TIM8_TIM1_CCMR3_OC6PE                            \ Output compare 6 preload enable
$00007000 constant TIM8_TIM1_CCMR3_OC6M1                            \ Output compare 6 mode
$00008000 constant TIM8_TIM1_CCMR3_OC6CE                            \ Output compare 6 clear enable
$00010000 constant TIM8_TIM1_CCMR3_OC5M2                            \ Output compare 5 mode
$01000000 constant TIM8_TIM1_CCMR3_OC6M2                            \ Output compare 6 mode


\
\ @brief TIM1 timer deadtime register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000000ff constant TIM8_TIM1_DTR2_DTGF                              \ Dead-time falling edge generator setup This bit-field defines the duration of the dead-time inserted between the complementary outputs, on the falling edge. DTGF[7:5]=0xx => DTF=DTGF[7:0]x tdtg with tdtg=tDTS. DTGF[7:5]=10x => DTF=(64+DTGF[5:0])xtdtg with Tdtg=2xtDTS. DTGF[7:5]=110 => DTF=(32+DTGF[4:0])xtdtg with Tdtg=8xtDTS. DTGF[7:5]=111 => DTF=(32+DTGF[4:0])xtdtg with Tdtg=16xtDTS. Example if TDTS=125ns (8MHz), dead-time possible values are: 0 to 15875 ns by 125 ns steps, 16 us to 31750 ns by 250 ns steps, 32 us to 63us by 1 us steps, 64 us to 126 us by 2 us steps Note: This bit-field can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
$00010000 constant TIM8_TIM1_DTR2_DTAE                              \ Deadtime asymmetric enable Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
$00020000 constant TIM8_TIM1_DTR2_DTPE                              \ Deadtime preload enable Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM1 timer encoder control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM1_ECR_IE                                 \ Index enable This bit indicates if the Index event resets the counter.
$00000006 constant TIM8_TIM1_ECR_IDIR                               \ Index direction This bit indicates in which direction the Index event resets the counter. Note: The IDR[1:0] bitfield must be written when IE bit is reset (index disabled).
$00000018 constant TIM8_TIM1_ECR_IBLK                               \ Index blanking This bit indicates if the Index event is conditioned by the tim_ti3 input
$00000020 constant TIM8_TIM1_ECR_FIDX                               \ First index This bit indicates if the first index only is taken into account
$000000c0 constant TIM8_TIM1_ECR_IPOS                               \ Index positioning In quadrature encoder mode (SMS[3:0] = 0001, 0010, 0011, 1110, 1111), this bit indicates in which AB input configuration the Index event resets the counter. In directional clock mode or clock plus direction mode (SMS[3:0] = 1010, 1011, 1100, 1101), these bits indicates on which level the Index event resets the counter. In bidirectional clock mode, this applies for both clock inputs. x0: Index resets the counter when clock is 0 x1: Index resets the counter when clock is 1 Note: IPOS[1]âbit is not significant
$00ff0000 constant TIM8_TIM1_ECR_PW                                 \ Pulse width This bitfield defines the pulse duration, as following: tPW = PW[7:0] x tPWG
$07000000 constant TIM8_TIM1_ECR_PWPRSC                             \ Pulse width prescaler This bitfield sets the clock prescaler for the pulse generator, as following: tPWG = (2(PWPRSC[2:0])) x ttim_ker_ck


\
\ @brief TIM1 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM8_TIM1_TISEL_TI1SEL                           \ Selects tim_ti1[0..15] input ... Refer to for interconnects list.
$00000f00 constant TIM8_TIM1_TISEL_TI2SEL                           \ Selects tim_ti2[0..15] input ... Refer to for interconnects list.
$000f0000 constant TIM8_TIM1_TISEL_TI3SEL                           \ Selects tim_ti3[0..15] input ... Refer to for interconnects list.
$0f000000 constant TIM8_TIM1_TISEL_TI4SEL                           \ Selects tim_ti4[0..15] input ... Refer to for interconnects list.


\
\ @brief TIM1 alternate function option register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM8_TIM1_AF1_BKINE                              \ TIMx_BKIN input enable This bit enables the TIMx_BKIN alternate function input for the timerâs tim_brk input. TIMx_BKIN input is 'ORedâ with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000002 constant TIM8_TIM1_AF1_BKCMP1E                            \ tim_brk_cmp1 enable This bit enables the tim_brk_cmp1 for the timerâs tim_brk input. tim_brk_cmp1 output is 'ORedâ with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000004 constant TIM8_TIM1_AF1_BKCMP2E                            \ tim_brk_cmp2 enable This bit enables the tim_brk_cmp2 for the timerâs tim_brk input. tim_brk_cmp2 output is 'ORedâ with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000008 constant TIM8_TIM1_AF1_BKCMP3E                            \ tim_brk_cmp3 enable This bit enables the tim_brk_cmp3 for the timerâs tim_brk input. tim_brk_cmp3 output is 'ORedâ with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000010 constant TIM8_TIM1_AF1_BKCMP4E                            \ tim_brk_cmp4 enable This bit enables the tim_brk_cmp4 for the timerâs tim_brk input. tim_brk_cmp4 output is 'ORedâ with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000020 constant TIM8_TIM1_AF1_BKCMP5E                            \ tim_brk_cmp5 enable This bit enables the tim_brk_cmp5 for the timerâs tim_brk input. tim_brk_cmp5 output is 'ORedâ with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000040 constant TIM8_TIM1_AF1_BKCMP6E                            \ tim_brk_cmp6 enable This bit enables the tim_brk_cmp6 for the timerâs tim_brk input. tim_brk_cmp6 output is 'ORedâ with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000080 constant TIM8_TIM1_AF1_BKCMP7E                            \ tim_brk_cmp7 enable This bit enables the tim_brk_cmp7 for the timerâs tim_brk input. tim_brk_cmp7 output is 'ORedâ with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000100 constant TIM8_TIM1_AF1_BKCMP8E                            \ tim_brk_cmp8 enable This bit enables the tim_brk_cmp8 for the timerâs tim_brk input. tim_brk_cmp8 output is 'ORedâ with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000200 constant TIM8_TIM1_AF1_BKINP                              \ TIMx_BKIN input polarity This bit selects the TIMx_BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000400 constant TIM8_TIM1_AF1_BKCMP1P                            \ tim_brk_cmp1 input polarity This bit selects the tim_brk_cmp1 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000800 constant TIM8_TIM1_AF1_BKCMP2P                            \ tim_brk_cmp2 input polarity This bit selects the tim_brk_cmp2 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00001000 constant TIM8_TIM1_AF1_BKCMP3P                            \ tim_brk_cmp3 input polarity This bit selects the tim_brk_cmp3 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00002000 constant TIM8_TIM1_AF1_BKCMP4P                            \ tim_brk_cmp4 input polarity This bit selects the tim_brk_cmp4 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$0003c000 constant TIM8_TIM1_AF1_ETRSEL                             \ etr_in source selection These bits select the etr_in input source. ... Refer to for product specific implementation. Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM1 alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000001
\

$00000001 constant TIM8_TIM1_AF2_BK2INE                             \ TIMx_BKIN2 input enable This bit enables the TIMx_BKIN2 alternate function input for the timerâs tim_brk2 input. TIMx_BKIN2 input is 'ORedâ with the other tim_brk2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000002 constant TIM8_TIM1_AF2_BK2CMP1E                           \ tim_brk2_cmp1 enable This bit enables the tim_brk2_cmp1 for the timerâs tim_brk2 input. tim_brk2_cmp1 output is 'ORedâ with the other tim_brk2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000004 constant TIM8_TIM1_AF2_BK2CMP2E                           \ tim_brk2_cmp2 enable This bit enables the tim_brk2_cmp2 for the timerâs tim_brk2 input. tim_brk2_cmp2 output is 'ORedâ with the other tim_brk2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000008 constant TIM8_TIM1_AF2_BK2CMP3E                           \ tim_brk2_cmp3 enable This bit enables the tim_brk2_cmp3 for the timerâs tim_brk2 input. tim_brk2_cmp3 output is 'ORedâ with the other tim_brk2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000010 constant TIM8_TIM1_AF2_BK2CMP4E                           \ tim_brk2_cmp4 enable This bit enables the tim_brk2_cmp4 for the timerâs tim_brk2 input. tim_brk2_cmp4 output is 'ORedâ with the other tim_brk2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000020 constant TIM8_TIM1_AF2_BK2CMP5E                           \ tim_brk2_cmp5 enable This bit enables the tim_brk2_cmp5 for the timerâs tim_brk2 input. tim_brk2_cmp5 output is 'ORedâ with the other tim_brk2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000040 constant TIM8_TIM1_AF2_BK2CMP6E                           \ tim_brk2_cmp6 enable This bit enables the tim_brk2_cmp6 for the timerâs tim_brk2 input. tim_brk2_cmp6 output is 'ORedâ with the other tim_brk2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000080 constant TIM8_TIM1_AF2_BK2CMP7E                           \ tim_brk2_cmp7 enable This bit enables the tim_brk2_cmp7 for the timerâs tim_brk2 input. tim_brk2_cmp7 output is 'ORedâ with the other tim_brk2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000100 constant TIM8_TIM1_AF2_BK2CMP8E                           \ tim_brk2_cmp8 enable This bit enables the tim_brk2_cmp8 for the timerâs tim_brk2 input. tim_brk2_cmp8 output is 'ORedâ with the other tim_brk2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000200 constant TIM8_TIM1_AF2_BK2INP                             \ TIMx_BKIN2 input polarity This bit selects the TIMx_BKIN2 alternate function input sensitivity. It must be programmed together with the BK2P polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000400 constant TIM8_TIM1_AF2_BK2CMP1P                           \ tim_brk2_cmp1 input polarity This bit selects the tim_brk2_cmp1 input sensitivity. It must be programmed together with the BK2P polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000800 constant TIM8_TIM1_AF2_BK2CMP2P                           \ tim_brk2_cmp2 input polarity This bit selects the tim_brk2_cmp2 input sensitivity. It must be programmed together with the BK2P polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00001000 constant TIM8_TIM1_AF2_BK2CMP3P                           \ tim_brk2_cmp3 input polarity This bit selects the tim_brk2_cmp3 input sensitivity. It must be programmed together with the BK2P polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00002000 constant TIM8_TIM1_AF2_BK2CMP4P                           \ tim_brk2_cmp4 input polarity This bit selects the tim_brk2_cmp4 input sensitivity. It must be programmed together with the BK2P polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00070000 constant TIM8_TIM1_AF2_OCRSEL                             \ ocref_clr source selection These bits select the ocref_clr input source. ... Refer to for product specific information. Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM1 DMA control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant TIM8_TIM1_DCR_DBA                                \ DMA base address This 5-bits vector defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ...
$00001f00 constant TIM8_TIM1_DCR_DBL                                \ DMA burst length This 5-bit vector defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address), i.e. the number of transfers. Transfers can be in half-words or in bytes (see example below). ... Example: Let us consider the following transfer: DBL = 7 bytes & DBA = TIM2_CR1. If DBL = 7 bytes and DBA = TIM2_CR1 represents the address of the byte to be transferred, the address of the transfer should be given by the following equation: (TIMx_CR1 address) + DBA + (DMA index), where DMA index = DBL In this example, 7 bytes are added to (TIMx_CR1 address) + DBA, which gives us the address from/to which the data are copied. In this case, the transfer is done to 7 registers starting from the following address: (TIMx_CR1 address) + DBA According to the configuration of the DMA Data Size, several cases may occur: If the DMA Data Size is configured in half-words, 16-bit data are transferred to each of the 7 registers. If the DMA Data Size is configured in bytes, the data are also transferred to 7 registers: the first register contains the first MSB byte, the second register, the first LSB byte and so on. So with the transfer Timer, one also has to specify the size of data transferred by DMA.
$000f0000 constant TIM8_TIM1_DCR_DBSS                               \ DMA burst source selection This bitfield defines the interrupt source that triggers the DMA burst transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). Others: reserved


\
\ @brief TIM1 DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant TIM8_TIM1_DMAR_DMAB                              \ DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).


\
\ @brief TIM8 Break Interrupt
\
$40013400 constant TIM8_TIM1_CR1  \ offset: 0x00 : TIM1 control register 1
$40013404 constant TIM8_TIM1_CR2  \ offset: 0x04 : control register 2
$40013408 constant TIM8_TIM1_SMCR  \ offset: 0x08 : TIM1 slave mode control register
$4001340c constant TIM8_TIM1_DIER  \ offset: 0x0C : TIM1 DMA/interrupt enable register
$40013410 constant TIM8_TIM1_SR   \ offset: 0x10 : TIM1 status register
$40013414 constant TIM8_TIM1_EGR  \ offset: 0x14 : TIM1 event generation register
$40013418 constant TIM8_TIM1_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$40013418 constant TIM8_TIM1_CCMR1_INPUT  \ offset: 0x18 : TIM1 capture/compare mode register 1 [alternate]
$4001341c constant TIM8_TIM1_CCMR2_OUTPUT  \ offset: 0x1C : capture/compare mode register 2 (output mode)
$4001341c constant TIM8_TIM1_CCMR2_INPUT  \ offset: 0x1C : TIM1 capture/compare mode register 2 [alternate]
$40013420 constant TIM8_TIM1_CCER  \ offset: 0x20 : TIM1 capture/compare enable register
$40013424 constant TIM8_TIM1_CNT  \ offset: 0x24 : TIM1 counter
$40013428 constant TIM8_TIM1_PSC  \ offset: 0x28 : TIM1 prescaler
$4001342c constant TIM8_TIM1_ARR  \ offset: 0x2C : TIM1 auto-reload register
$40013430 constant TIM8_TIM1_RCR  \ offset: 0x30 : TIM1 repetition counter register
$40013434 constant TIM8_TIM1_CCR1  \ offset: 0x34 : TIM1 capture/compare register 1
$40013438 constant TIM8_TIM1_CCR2  \ offset: 0x38 : TIM1 capture/compare register 2
$4001343c constant TIM8_TIM1_CCR3  \ offset: 0x3C : TIM1 capture/compare register 3
$40013440 constant TIM8_TIM1_CCR4  \ offset: 0x40 : TIM1 capture/compare register 4
$40013444 constant TIM8_TIM1_BDTR  \ offset: 0x44 : TIM1 break and dead-time register
$40013448 constant TIM8_TIM1_CCR5  \ offset: 0x48 : TIM1 capture/compare register 5
$4001344c constant TIM8_TIM1_CCR6  \ offset: 0x4C : TIM1 capture/compare register 6
$40013450 constant TIM8_TIM1_CCMR3  \ offset: 0x50 : TIM1 capture/compare mode register 3
$40013454 constant TIM8_TIM1_DTR2  \ offset: 0x54 : TIM1 timer deadtime register 2
$40013458 constant TIM8_TIM1_ECR  \ offset: 0x58 : TIM1 timer encoder control register
$4001345c constant TIM8_TIM1_TISEL  \ offset: 0x5C : TIM1 timer input selection register
$40013460 constant TIM8_TIM1_AF1  \ offset: 0x60 : TIM1 alternate function option register 1
$40013464 constant TIM8_TIM1_AF2  \ offset: 0x64 : TIM1 alternate function register 2
$400137dc constant TIM8_TIM1_DCR  \ offset: 0x3DC : TIM1 DMA control register
$400137e0 constant TIM8_TIM1_DMAR  \ offset: 0x3E0 : TIM1 DMA address for full transfer

