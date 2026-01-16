\
\ @file tim1.fs
\ @brief Advanced-timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_CR1_CEN                                \ Counter enable Note: External clock, gated mode and encoder mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
$00000002 constant TIM1_TIM1_CR1_UDIS                               \ Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
$00000004 constant TIM1_TIM1_CR1_URS                                \ Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
$00000008 constant TIM1_TIM1_CR1_OPM                                \ One pulse mode
$00000010 constant TIM1_TIM1_CR1_DIR                                \ Direction Note: This bit is read only when the timer is configured in Center-aligned mode or Encoder mode.
$00000060 constant TIM1_TIM1_CR1_CMS                                \ Center-aligned mode selection Note: Switch from edge-aligned mode to center-aligned mode as long as the counter is enabled (CEN=1) is not allowed
$00000080 constant TIM1_TIM1_CR1_ARPE                               \ Auto-reload preload enable
$00000300 constant TIM1_TIM1_CR1_CKD                                \ Clock division This bit-field indicates the division ratio between the timer clock (CK_INT) frequency and the dead-time and sampling clock (tDTS)used by the dead-time generators and the digital filters (ETR, TIx): Note: tDTS = 1/fDTS, tCK_INT = 1/fCK_INT.
$00000800 constant TIM1_TIM1_CR1_UIFREMAP                           \ UIF status bit remapping


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_CR2_CCPC                               \ Capture/compare preloaded control Note: This bit acts only on channels that have a complementary output.
$00000004 constant TIM1_TIM1_CR2_CCUS                               \ Capture/compare control update selection Note: This bit acts only on channels that have a complementary output.
$00000008 constant TIM1_TIM1_CR2_CCDS                               \ Capture/compare DMA selection
$00000070 constant TIM1_TIM1_CR2_MMS                                \ Master mode selection These bits allow selected information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows: Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
$00000080 constant TIM1_TIM1_CR2_TI1S                               \ TI1 selection
$00000100 constant TIM1_TIM1_CR2_OIS1                               \ Output Idle state 1 (OC1 output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
$00000200 constant TIM1_TIM1_CR2_OIS1N                              \ Output Idle state 1 (OC1N output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
$00000400 constant TIM1_TIM1_CR2_OIS2                               \ Output Idle state 2 (OC2 output) Refer to OIS1 bit
$00000800 constant TIM1_TIM1_CR2_OIS2N                              \ Output Idle state 2 (OC2N output) Refer to OIS1N bit
$00001000 constant TIM1_TIM1_CR2_OIS3                               \ Output Idle state 3 (OC3 output) Refer to OIS1 bit
$00002000 constant TIM1_TIM1_CR2_OIS3N                              \ Output Idle state 3 (OC3N output) Refer to OIS1N bit
$00004000 constant TIM1_TIM1_CR2_OIS4                               \ Output Idle state 4 (OC4 output) Refer to OIS1 bit
$00010000 constant TIM1_TIM1_CR2_OIS5                               \ Output Idle state 5 (OC5 output) Refer to OIS1 bit
$00040000 constant TIM1_TIM1_CR2_OIS6                               \ Output Idle state 6 (OC6 output) Refer to OIS1 bit
$00f00000 constant TIM1_TIM1_CR2_MMS2                               \ Master mode selection 2 These bits allow the information to be sent to ADC for synchronization (TRGO2) to be selected. The combination is as follows: Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM1_TIM1_SMCR_SMS1                              \ Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS=00100). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the TRGO or the TRGO2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
$00000008 constant TIM1_TIM1_SMCR_OCCS                              \ OCREF clear selection This bit is used to select the OCREF clear source.
$00000070 constant TIM1_TIM1_SMCR_TS1                               \ Trigger selection This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for more details on ITRx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
$00000080 constant TIM1_TIM1_SMCR_MSM                               \ Master/slave mode
$00000f00 constant TIM1_TIM1_SMCR_ETF                               \ External trigger filter This bit-field then defines the frequency used to sample ETRP signal and the length of the digital filter applied to ETRP. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
$00003000 constant TIM1_TIM1_SMCR_ETPS                              \ External trigger prescaler External trigger signal ETRP frequency must be at most 1/4 of fCK_INT frequency. A prescaler can be enabled to reduce ETRP frequency. It is useful when inputting fast external clocks.
$00004000 constant TIM1_TIM1_SMCR_ECE                               \ External clock enable This bit enables External clock mode 2. Note: Setting the ECE bit has the same effect as selecting external clock mode 1 with TRGI connected to ETRF (SMS=111 and TS=00111). It is possible to simultaneously use external clock mode 2 with the following slave modes: reset mode, gated mode and trigger mode. Nevertheless, TRGI must not be connected to ETRF in this case (TS bits must not be 00111). If external clock mode 1 and external clock mode 2 are enabled at the same time, the external clock input is ETRF.
$00008000 constant TIM1_TIM1_SMCR_ETP                               \ External trigger polarity This bit selects whether ETR or ETR is used for trigger operations
$00010000 constant TIM1_TIM1_SMCR_SMS2                              \ Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS=00100). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the TRGO or the TRGO2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
$00300000 constant TIM1_TIM1_SMCR_TS2                               \ Trigger selection This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for more details on ITRx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_DIER_UIE                               \ Update interrupt enable
$00000002 constant TIM1_TIM1_DIER_CC1IE                             \ Capture/Compare 1 interrupt enable
$00000004 constant TIM1_TIM1_DIER_CC2IE                             \ Capture/Compare 2 interrupt enable
$00000008 constant TIM1_TIM1_DIER_CC3IE                             \ Capture/Compare 3 interrupt enable
$00000010 constant TIM1_TIM1_DIER_CC4IE                             \ Capture/Compare 4 interrupt enable
$00000020 constant TIM1_TIM1_DIER_COMIE                             \ COM interrupt enable
$00000040 constant TIM1_TIM1_DIER_TIE                               \ Trigger interrupt enable
$00000080 constant TIM1_TIM1_DIER_BIE                               \ Break interrupt enable
$00000100 constant TIM1_TIM1_DIER_UDE                               \ Update DMA request enable
$00000200 constant TIM1_TIM1_DIER_CC1DE                             \ Capture/Compare 1 DMA request enable
$00000400 constant TIM1_TIM1_DIER_CC2DE                             \ Capture/Compare 2 DMA request enable
$00000800 constant TIM1_TIM1_DIER_CC3DE                             \ Capture/Compare 3 DMA request enable
$00001000 constant TIM1_TIM1_DIER_CC4DE                             \ Capture/Compare 4 DMA request enable
$00002000 constant TIM1_TIM1_DIER_COMDE                             \ COM DMA request enable
$00004000 constant TIM1_TIM1_DIER_TDE                               \ Trigger DMA request enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_SR_UIF                                 \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to control register (TIM1_SMCRTIMx_SMCR)N/A), if URS=0 and UDIS=0 in the TIMx_CR1 register.
$00000002 constant TIM1_TIM1_SR_CC1IF                               \ Capture/Compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when he content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
$00000004 constant TIM1_TIM1_SR_CC2IF                               \ Capture/Compare 2 interrupt flag Refer to CC1IF description
$00000008 constant TIM1_TIM1_SR_CC3IF                               \ Capture/Compare 3 interrupt flag Refer to CC1IF description
$00000010 constant TIM1_TIM1_SR_CC4IF                               \ Capture/Compare 4 interrupt flag Refer to CC1IF description
$00000020 constant TIM1_TIM1_SR_COMIF                               \ COM interrupt flag
$00000040 constant TIM1_TIM1_SR_TIF                                 \ Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on TRGI input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
$00000080 constant TIM1_TIM1_SR_BIF                                 \ Break interrupt flag This flag is set by hardware as soon as the break input goes active. It can be cleared by software if the break input is not active.
$00000100 constant TIM1_TIM1_SR_B2IF                                \ Break 2 interrupt flag This flag is set by hardware as soon as the break 2 input goes active. It can be cleared by software if the break 2 input is not active.
$00000200 constant TIM1_TIM1_SR_CC1OF                               \ Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0'.
$00000400 constant TIM1_TIM1_SR_CC2OF                               \ Capture/Compare 2 overcapture flag Refer to CC1OF description
$00000800 constant TIM1_TIM1_SR_CC3OF                               \ Capture/Compare 3 overcapture flag Refer to CC1OF description
$00001000 constant TIM1_TIM1_SR_CC4OF                               \ Capture/Compare 4 overcapture flag Refer to CC1OF description
$00002000 constant TIM1_TIM1_SR_SBIF                                \ System Break interrupt flag This flag is set by hardware as soon as the system break input goes active. It can be cleared by software if the system break input is not active. This flag must be reset to re-start PWM operation.
$00010000 constant TIM1_TIM1_SR_CC5IF                               \ Compare 5 interrupt flag Refer to CC1IF description (Note: Channel 5 can only be configured as output)
$00020000 constant TIM1_TIM1_SR_CC6IF                               \ Compare 6 interrupt flag Refer to CC1IF description (Note: Channel 6 can only be configured as output)


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_EGR_UG                                 \ Update generation This bit can be set by software, it is automatically cleared by hardware.
$00000002 constant TIM1_TIM1_EGR_CC1G                               \ Capture/Compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
$00000004 constant TIM1_TIM1_EGR_CC2G                               \ Capture/Compare 2 generation Refer to CC1G description
$00000008 constant TIM1_TIM1_EGR_CC3G                               \ Capture/Compare 3 generation Refer to CC1G description
$00000010 constant TIM1_TIM1_EGR_CC4G                               \ Capture/Compare 4 generation Refer to CC1G description
$00000020 constant TIM1_TIM1_EGR_COMG                               \ Capture/Compare control update generation This bit can be set by software, it is automatically cleared by hardware Note: This bit acts only on channels having a complementary output.
$00000040 constant TIM1_TIM1_EGR_TG                                 \ Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
$00000080 constant TIM1_TIM1_EGR_BG                                 \ Break generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
$00000100 constant TIM1_TIM1_EGR_B2G                                \ Break 2 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM1_CCMR1_OUTPUT_CC1S                           \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIMx_CCER).
$00000004 constant TIM1_CCMR1_OUTPUT_OC1FE                          \ Output Compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
$00000008 constant TIM1_CCMR1_OUTPUT_OC1PE                          \ Output Compare 1 preload enable Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). The PWM mode can be used without validating the preload register only in one pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
$00000070 constant TIM1_CCMR1_OUTPUT_OC1M1                          \ Output Compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode. Note: On channels having a complementary output, this bit field is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the OC1M active bits take the new value from the preloaded bits only when a COM event is generated. Note: The OC1M[3] bit is not contiguous, located in bit 16.
$00000080 constant TIM1_CCMR1_OUTPUT_OC1CE                          \ Output Compare 1 clear enable
$00000300 constant TIM1_CCMR1_OUTPUT_CC2S                           \ Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = '0' in TIMx_CCER).
$00000400 constant TIM1_CCMR1_OUTPUT_OC2FE                          \ Output Compare 2 fast enable Refer to OC1FE description.
$00000800 constant TIM1_CCMR1_OUTPUT_OC2PE                          \ Output Compare 2 preload enable Refer to OC1PE description.
$00007000 constant TIM1_CCMR1_OUTPUT_OC2M1                          \ Output Compare 2 mode Refer to OC1M[3:0] description.
$00008000 constant TIM1_CCMR1_OUTPUT_OC2CE                          \ Output Compare 2 clear enable Refer to OC1CE description.
$00010000 constant TIM1_CCMR1_OUTPUT_OC1M2                          \ Output Compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode. Note: On channels having a complementary output, this bit field is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the OC1M active bits take the new value from the preloaded bits only when a COM event is generated. Note: The OC1M[3] bit is not contiguous, located in bit 16.
$01000000 constant TIM1_CCMR1_OUTPUT_OC2M2                          \ Output Compare 2 mode Refer to OC1M[3:0] description.


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM1_CCMR1_INPUT_CC1S                            \ Capture/Compare 1 Selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIMx_CCER).
$0000000c constant TIM1_CCMR1_INPUT_IC1PSC                          \ Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (IC1). The prescaler is reset as soon as CC1E='0' (TIMx_CCER register).
$000000f0 constant TIM1_CCMR1_INPUT_IC1F                            \ Input capture 1 filter This bit-field defines the frequency used to sample TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
$00000300 constant TIM1_CCMR1_INPUT_CC2S                            \ Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = '0' in TIMx_CCER).
$00000c00 constant TIM1_CCMR1_INPUT_IC2PSC                          \ Input capture 2 prescaler Refer to IC1PSC[1:0] description.
$0000f000 constant TIM1_CCMR1_INPUT_IC2F                            \ Input capture 2 filter Refer to IC1F[3:0] description.


\
\ @brief capture/compare mode register 2 (output mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM1_CCMR2_OUTPUT_CC3S                           \ Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = '0' in TIMx_CCER).
$00000004 constant TIM1_CCMR2_OUTPUT_OC3FE                          \ Output compare 3 fast enable Refer to OC1FE description.
$00000008 constant TIM1_CCMR2_OUTPUT_OC3PE                          \ Output compare 3 preload enable Refer to OC1PE description.
$00000070 constant TIM1_CCMR2_OUTPUT_OC3M1                          \ Output compare 3 mode Refer to OC1M[3:0] description.
$00000080 constant TIM1_CCMR2_OUTPUT_OC3CE                          \ Output compare 3 clear enable Refer to OC1CE description.
$00000300 constant TIM1_CCMR2_OUTPUT_CC4S                           \ Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = '0' in TIMx_CCER).
$00000400 constant TIM1_CCMR2_OUTPUT_OC4FE                          \ Output compare 4 fast enable Refer to OC1FE description.
$00000800 constant TIM1_CCMR2_OUTPUT_OC4PE                          \ Output compare 4 preload enable Refer to OC1PE description.
$00007000 constant TIM1_CCMR2_OUTPUT_OC4M1                          \ Output compare 4 mode Refer to OC3M[3:0] description.
$00008000 constant TIM1_CCMR2_OUTPUT_OC4CE                          \ Output compare 4 clear enable Refer to OC1CE description.
$00010000 constant TIM1_CCMR2_OUTPUT_OC3M2                          \ Output compare 3 mode Refer to OC1M[3:0] description.
$01000000 constant TIM1_CCMR2_OUTPUT_OC4M2                          \ Output compare 4 mode Refer to OC3M[3:0] description.


\
\ @brief capture/compare mode register 2 (output mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM1_CCMR2_INPUT_CC3S                            \ Capture/compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = '0' in TIMx_CCER).
$0000000c constant TIM1_CCMR2_INPUT_IC3PSC                          \ Input capture 3 prescaler Refer to IC1PSC[1:0] description.
$000000f0 constant TIM1_CCMR2_INPUT_IC3F                            \ Input capture 3 filter Refer to IC1F[3:0] description.
$00000300 constant TIM1_CCMR2_INPUT_CC4S                            \ Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = '0' in TIMx_CCER).
$00000c00 constant TIM1_CCMR2_INPUT_IC4PSC                          \ Input capture 4 prescaler Refer to IC1PSC[1:0] description.
$0000f000 constant TIM1_CCMR2_INPUT_IC4F                            \ Input capture 4 filter Refer to IC1F[3:0] description.


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_CCER_CC1E                              \ Capture/Compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to for details. Note: On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1E active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000002 constant TIM1_TIM1_CCER_CC1P                              \ Capture/Compare 1 output polarity When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: The configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register). On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000004 constant TIM1_TIM1_CCER_CC1NE                             \ Capture/Compare 1 complementary output enable On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NE active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000008 constant TIM1_TIM1_CCER_CC1NP                             \ Capture/Compare 1 complementary output polarity CC1 channel configured as output: CC1 channel configured as input: This bit is used in conjunction with CC1P to define the polarity of TI1FP1 and TI2FP1. Refer to CC1P description. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (channel configured as output). On channels having a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NP active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000010 constant TIM1_TIM1_CCER_CC2E                              \ Capture/Compare 2 output enable Refer to CC1E description
$00000020 constant TIM1_TIM1_CCER_CC2P                              \ Capture/Compare 2 output polarity Refer to CC1P description
$00000040 constant TIM1_TIM1_CCER_CC2NE                             \ Capture/Compare 2 complementary output enable Refer to CC1NE description
$00000080 constant TIM1_TIM1_CCER_CC2NP                             \ Capture/Compare 2 complementary output polarity Refer to CC1NP description
$00000100 constant TIM1_TIM1_CCER_CC3E                              \ Capture/Compare 3 output enable Refer to CC1E description
$00000200 constant TIM1_TIM1_CCER_CC3P                              \ Capture/Compare 3 output polarity Refer to CC1P description
$00000400 constant TIM1_TIM1_CCER_CC3NE                             \ Capture/Compare 3 complementary output enable Refer to CC1NE description
$00000800 constant TIM1_TIM1_CCER_CC3NP                             \ Capture/Compare 3 complementary output polarity Refer to CC1NP description
$00001000 constant TIM1_TIM1_CCER_CC4E                              \ Capture/Compare 4 output enable Refer to CC1E description
$00002000 constant TIM1_TIM1_CCER_CC4P                              \ Capture/Compare 4 output polarity Refer to CC1P description
$00008000 constant TIM1_TIM1_CCER_CC4NP                             \ Capture/Compare 4 complementary output polarity Refer to CC1NP description
$00010000 constant TIM1_TIM1_CCER_CC5E                              \ Capture/Compare 5 output enable Refer to CC1E description
$00020000 constant TIM1_TIM1_CCER_CC5P                              \ Capture/Compare 5 output polarity Refer to CC1P description
$00100000 constant TIM1_TIM1_CCER_CC6E                              \ Capture/Compare 6 output enable Refer to CC1E description
$00200000 constant TIM1_TIM1_CCER_CC6P                              \ Capture/Compare 6 output polarity Refer to CC1P description


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CNT_CNT                                \ Counter value
$80000000 constant TIM1_TIM1_CNT_UIFCPY                             \ UIF copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in the TIMxCR1 is reset, bit 31 is reserved and read at 0.


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_PSC_PSC                                \ Prescaler value The counter clock frequency (CK_CNT) is equal to fCK_PSC / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in 'reset mode').


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM1_TIM1_ARR_ARR                                \ Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.


\
\ @brief repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_RCR_REP                                \ Repetition counter value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR1_CCR1                              \ Capture/Compare 1 value


\
\ @brief capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR2_CCR2                              \ Capture/Compare 2 value


\
\ @brief capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR3_CCR3                              \ Capture/Compare value


\
\ @brief capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR4_CCR4                              \ Capture/Compare value


\
\ @brief break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM1_TIM1_BDTR_DTG                               \ Dead-time generator setup
$00000300 constant TIM1_TIM1_BDTR_LOCK                              \ Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIMx_BDTR register has been written, their content is frozen until the next reset.
$00000400 constant TIM1_TIM1_BDTR_OSSI                              \ Off-state selection for Idle mode This bit is used when MOE=0 due to a break event or by a software write, on channels configured as outputs. See OC/OCN enable description for more details (enable register (TIM1_CCERTIMx_CCER)N/A). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00000800 constant TIM1_TIM1_BDTR_OSSR                              \ Off-state selection for Run mode This bit is used when MOE=1 on channels having a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See OC/OCN enable description for more details (enable register (TIM1_CCERTIMx_CCER)N/A). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00001000 constant TIM1_TIM1_BDTR_BKE                               \ Break enable This bit enables the complete break protection (including all sources connected to bk_acth and BKIN sources, as per ). Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00002000 constant TIM1_TIM1_BDTR_BKP                               \ Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00004000 constant TIM1_TIM1_BDTR_AOE                               \ Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00008000 constant TIM1_TIM1_BDTR_MOE                               \ Main output enable This bit is cleared asynchronously by hardware as soon as one of the break inputs is active (BRK or BRK2). It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. In response to a break event or if MOE is written to 0: OC and OCN outputs are disabled or forced to idle state depending on the OSSI bit. See OC/OCN enable description for more details (enable register (TIM1_CCERTIMx_CCER)N/A).
$000f0000 constant TIM1_TIM1_BDTR_BKF                               \ Break filter This bit-field defines the frequency used to sample BRK input and the length of the digital filter applied to BRK. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output: Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00f00000 constant TIM1_TIM1_BDTR_BK2F                              \ Break 2 filter This bit-field defines the frequency used to sample BRK2 input and the length of the digital filter applied to BRK2. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output: Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$01000000 constant TIM1_TIM1_BDTR_BK2E                              \ Break 2 enable Note: The BRK2 must only be used with OSSR = OSSI = 1. Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$02000000 constant TIM1_TIM1_BDTR_BK2P                              \ Break 2 polarity Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$04000000 constant TIM1_TIM1_BDTR_BKDSRM                            \ Break Disarm This bit is cleared by hardware when no break source is active. The BKDSRM bit must be set by software to release the bidirectional output control (open-drain output in Hi-Z state) and then be polled it until it is reset by hardware, indicating that the fault condition has disappeared. Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$08000000 constant TIM1_TIM1_BDTR_BK2DSRM                           \ Break2 Disarm Refer to BKDSRM description
$10000000 constant TIM1_TIM1_BDTR_BKBID                             \ Break Bidirectional In the bidirectional mode (BKBID bit set to 1), the break input is configured both in input mode and in open drain output mode. Any active break event asserts a low logic level on the Break input to indicate an internal break event to external devices. Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$20000000 constant TIM1_TIM1_BDTR_BK2BID                            \ Break2 bidirectional Refer to BKBID description


\
\ @brief DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM1_TIM1_DCR_DBA                                \ DMA base address This 5-bits vector defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ...
$00001f00 constant TIM1_TIM1_DCR_DBL                                \ DMA burst length This 5-bit vector defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address), i.e. the number of transfers. Transfers can be in half-words or in bytes (see example below). ... Example: Let us consider the following transfer: DBL = 7 bytes & DBA = TIMx_CR1. If DBL = 7 bytes and DBA = TIMx_CR1 represents the address of the byte to be transferred, the address of the transfer should be given by the following equation: (TIMx_CR1 address) + DBA + (DMA index), where DMA index = DBL In this example, 7 bytes are added to (TIMx_CR1 address) + DBA, which gives us the address from/to which the data is copied. In this case, the transfer is done to 7 registers starting from the following address: (TIMx_CR1 address) + DBA According to the configuration of the DMA Data Size, several cases may occur: If the DMA Data Size is configured in half-words, 16-bit data is transferred to each of the 7 registers. If the DMA Data Size is configured in bytes, the data is also transferred to 7 registers: the first register contains the first MSB byte, the second register, the first LSB byte and so on. So with the transfer Timer, one also has to specify the size of data transferred by DMA.


\
\ @brief DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant TIM1_TIM1_DMAR_DMAB                              \ DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).


\
\ @brief capture/compare mode register 2 (output mode)
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000004 constant TIM1_CCMR3_OUTPUT_OC5FE                          \ Output compare 5 fast enable
$00000008 constant TIM1_CCMR3_OUTPUT_OC5PE                          \ Output compare 5 preload enable
$00000070 constant TIM1_CCMR3_OUTPUT_OC5M                           \ Output compare 5 mode
$00000080 constant TIM1_CCMR3_OUTPUT_OC5CE                          \ Output compare 5 clear enable
$00000400 constant TIM1_CCMR3_OUTPUT_OC6FE                          \ Output compare 6 fast enable
$00000800 constant TIM1_CCMR3_OUTPUT_OC6PE                          \ Output compare 6 preload enable
$00007000 constant TIM1_CCMR3_OUTPUT_OC6M                           \ Output compare 6 mode
$00008000 constant TIM1_CCMR3_OUTPUT_OC6CE                          \ Output compare 6 clear enable
$00010000 constant TIM1_CCMR3_OUTPUT_OC5M_BIT3                      \ Output Compare 5 mode bit 3
$01000000 constant TIM1_CCMR3_OUTPUT_OC6M_BIT3                      \ Output Compare 6 mode bit 3


\
\ @brief capture/compare register 4
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR5_CCR5                              \ Capture/Compare 5 value CCR5 is the value to be loaded in the actual capture/compare 5 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR3 register (bit OC5PE). Else the preload value is copied in the active capture/compare 5 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC5 output.
$20000000 constant TIM1_TIM1_CCR5_GC5C1                             \ Group Channel 5 and Channel 1 Distortion on Channel 1 output: This bit can either have immediate effect or be preloaded and taken into account after an update event (if preload feature is selected in TIMxCCMR1). Note: it is also possible to apply this distortion on combined PWM signals.
$40000000 constant TIM1_TIM1_CCR5_GC5C2                             \ Group Channel 5 and Channel 2 Distortion on Channel 2 output: This bit can either have immediate effect or be preloaded and taken into account after an update event (if preload feature is selected in TIMxCCMR1). Note: it is also possible to apply this distortion on combined PWM signals.
$80000000 constant TIM1_TIM1_CCR5_GC5C3                             \ Group Channel 5 and Channel 3 Distortion on Channel 3 output: This bit can either have immediate effect or be preloaded and taken into account after an update event (if preload feature is selected in TIMxCCMR2). Note: it is also possible to apply this distortion on combined PWM signals.


\
\ @brief capture/compare register 6
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CCR6_CCR6                              \ Capture/Compare value


\
\ @brief TIM1 alternate function option register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM1_TIM1_AF1_BKINE                              \ BRK BKIN input enable This bit enables the BKIN alternate function input for the timer's BRK input. BKIN input is 'ORed' with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000200 constant TIM1_TIM1_AF1_BKINP                              \ BRK BKIN input polarity This bit selects the BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$0003c000 constant TIM1_TIM1_AF1_ETRSEL                             \ ETR source selection These bits select the ETR input source. Others: Reserved Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM1 alternate function option register 2
\ Address offset: 0x64
\ Reset value: 0x00000001
\

$00000001 constant TIM1_TIM1_AF2_BK2INE                             \ BRK2 BKIN input enable This bit enables the BKIN2 alternate function input for the timer's BRK2 input. BKIN2 input is 'ORed' with the other BRK2 sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000200 constant TIM1_TIM1_AF2_BK2INP                             \ BRK2 BKIN2 input polarity This bit selects the BKIN2 alternate function input sensitivity. It must be programmed together with the BK2P polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM1 timer input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM1_TIM1_TISEL_TI1SEL                           \ selects TI1[0] to TI1[15] input Others: Reserved
$00000f00 constant TIM1_TIM1_TISEL_TI2SEL                           \ selects TI2[0] to TI2[15] input Others: Reserved
$000f0000 constant TIM1_TIM1_TISEL_TI3SEL                           \ selects TI3[0] to TI3[15] input Others: Reserved
$0f000000 constant TIM1_TIM1_TISEL_TI4SEL                           \ selects TI4[0] to TI4[15] input Others: Reserved


\
\ @brief Advanced-timers
\
$40012c00 constant TIM1_TIM1_CR1  \ offset: 0x00 : control register 1
$40012c04 constant TIM1_TIM1_CR2  \ offset: 0x04 : control register 2
$40012c08 constant TIM1_TIM1_SMCR  \ offset: 0x08 : slave mode control register
$40012c0c constant TIM1_TIM1_DIER  \ offset: 0x0C : DMA/Interrupt enable register
$40012c10 constant TIM1_TIM1_SR   \ offset: 0x10 : status register
$40012c14 constant TIM1_TIM1_EGR  \ offset: 0x14 : event generation register
$40012c18 constant TIM1_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$40012c18 constant TIM1_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$40012c1c constant TIM1_CCMR2_OUTPUT  \ offset: 0x1C : capture/compare mode register 2 (output mode)
$40012c1c constant TIM1_CCMR2_INPUT  \ offset: 0x1C : capture/compare mode register 2 (output mode)
$40012c20 constant TIM1_TIM1_CCER  \ offset: 0x20 : capture/compare enable register
$40012c24 constant TIM1_TIM1_CNT  \ offset: 0x24 : counter
$40012c28 constant TIM1_TIM1_PSC  \ offset: 0x28 : prescaler
$40012c2c constant TIM1_TIM1_ARR  \ offset: 0x2C : auto-reload register
$40012c30 constant TIM1_TIM1_RCR  \ offset: 0x30 : repetition counter register
$40012c34 constant TIM1_TIM1_CCR1  \ offset: 0x34 : capture/compare register 1
$40012c38 constant TIM1_TIM1_CCR2  \ offset: 0x38 : capture/compare register 2
$40012c3c constant TIM1_TIM1_CCR3  \ offset: 0x3C : capture/compare register 3
$40012c40 constant TIM1_TIM1_CCR4  \ offset: 0x40 : capture/compare register 4
$40012c44 constant TIM1_TIM1_BDTR  \ offset: 0x44 : break and dead-time register
$40012c48 constant TIM1_TIM1_DCR  \ offset: 0x48 : DMA control register
$40012c4c constant TIM1_TIM1_DMAR  \ offset: 0x4C : DMA address for full transfer
$40012c54 constant TIM1_CCMR3_OUTPUT  \ offset: 0x54 : capture/compare mode register 2 (output mode)
$40012c58 constant TIM1_TIM1_CCR5  \ offset: 0x58 : capture/compare register 4
$40012c5c constant TIM1_TIM1_CCR6  \ offset: 0x5C : capture/compare register 6
$40012c60 constant TIM1_TIM1_AF1  \ offset: 0x60 : TIM1 alternate function option register 1
$40012c64 constant TIM1_TIM1_AF2  \ offset: 0x64 : TIM1 alternate function option register 2
$40012c68 constant TIM1_TIM1_TISEL  \ offset: 0x68 : TIM1 timer input selection register

