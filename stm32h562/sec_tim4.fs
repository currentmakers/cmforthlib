\
\ @file sec_tim4.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM4 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM4_TIM4_CR1_CEN                            \ Counter enable Note: External clock, gated mode and encoder mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware. CEN is cleared automatically in one-pulse mode, when an update event occurs.
$00000002 constant SEC_TIM4_TIM4_CR1_UDIS                           \ Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
$00000004 constant SEC_TIM4_TIM4_CR1_URS                            \ Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
$00000008 constant SEC_TIM4_TIM4_CR1_OPM                            \ One-pulse mode
$00000010 constant SEC_TIM4_TIM4_CR1_DIR                            \ Direction Note: This bit is read only when the timer is configured in Center-aligned mode or Encoder mode.
$00000060 constant SEC_TIM4_TIM4_CR1_CMS                            \ Center-aligned mode selection Note: It is not allowed to switch from edge-aligned mode to center-aligned mode as long as the counter is enabled (CEN=1)
$00000080 constant SEC_TIM4_TIM4_CR1_ARPE                           \ Auto-reload preload enable
$00000300 constant SEC_TIM4_TIM4_CR1_CKD                            \ Clock division This bit-field indicates the division ratio between the timer clock (tim_ker_ck) frequency and sampling clock used by the digital filters (tim_etr_in, tim_tix),
$00000800 constant SEC_TIM4_TIM4_CR1_UIFREMAP                       \ UIF status bit remapping
$00001000 constant SEC_TIM4_TIM4_CR1_DITHEN                         \ Dithering Enable Note: The DITHEN bit can only be modified when CEN bit is reset.


\
\ @brief TIM4 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000008 constant SEC_TIM4_TIM4_CR2_CCDS                           \ Capture/compare DMA selection
$00000070 constant SEC_TIM4_TIM4_CR2_MMS1                           \ Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (tim_trgo). The combination is as follows: tim_trgo, except if the master/slave mode is selected (see the MSM bit description in TIMx_SMCR register). Others: Reserved Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
$00000080 constant SEC_TIM4_TIM4_CR2_TI1S                           \ tim_ti1 selection
$02000000 constant SEC_TIM4_TIM4_CR2_MMS2                           \ Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (tim_trgo). The combination is as follows: tim_trgo, except if the master/slave mode is selected (see the MSM bit description in TIMx_SMCR register). Others: Reserved Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.


\
\ @brief TIM4 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant SEC_TIM4_TIM4_SMCR_SMS                           \ Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
$00000008 constant SEC_TIM4_TIM4_SMCR_OCCS                          \ OCREF clear selection This bit is used to select the OCREF clear source Note: If the OCREF clear selection feature is not supported, this bit is reserved and forced by hardware to '0'. .
$00000070 constant SEC_TIM4_TIM4_SMCR_TS                            \ Trigger selection (see bits 21:20 for TS[4:3]) This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for product specific implementation details. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
$00000080 constant SEC_TIM4_TIM4_SMCR_MSM                           \ Master/Slave mode
$00000f00 constant SEC_TIM4_TIM4_SMCR_ETF                           \ External trigger filter This bit-field then defines the frequency used to sample tim_etrp signal and the length of the digital filter applied to tim_etrp. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
$00003000 constant SEC_TIM4_TIM4_SMCR_ETPS                          \ External trigger prescaler External trigger signal tim_etrp frequency must be at most 1/4 of tim_ker_ck frequency. A prescaler can be enabled to reduce tim_etrp frequency. It is useful when inputting fast external clocks on tim_etr_in.
$00004000 constant SEC_TIM4_TIM4_SMCR_ECE                           \ External clock enable This bit enables External clock mode 2. Note: Setting the ECE bit has the same effect as selecting external clock mode 1 with tim_trgi connected to tim_etrf (SMS=111 and TS=00111). It is possible to simultaneously use external clock mode 2 with the following slave modes: reset mode, gated mode and trigger mode. Nevertheless, tim_trgi must not be connected to tim_etrf in this case (TS bits must not be 00111). If external clock mode 1 and external clock mode 2 are enabled at the same time, the external clock input is tim_etrf.
$00008000 constant SEC_TIM4_TIM4_SMCR_ETP                           \ External trigger polarity This bit selects whether tim_etr_in or tim_etr_in is used for trigger operations
$00010000 constant SEC_TIM4_TIM4_SMCR_SMS_2                         \ Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Note: The gated mode must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the tim_trgo signal must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
$00300000 constant SEC_TIM4_TIM4_SMCR_TS_2                          \ Trigger selection (see bits 21:20 for TS[4:3]) This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See for product specific implementation details. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
$01000000 constant SEC_TIM4_TIM4_SMCR_SMSPE                         \ SMS preload enable This bit selects whether the SMS[3:0] bitfield is preloaded
$02000000 constant SEC_TIM4_TIM4_SMCR_SMSPS                         \ SMS preload source This bit selects whether the events that triggers the SMS[3:0] bitfield transfer from preload to active


\
\ @brief TIM4 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM4_TIM4_DIER_UIE                           \ Update interrupt enable
$00000002 constant SEC_TIM4_TIM4_DIER_CC1IE                         \ Capture/Compare 1 interrupt enable
$00000004 constant SEC_TIM4_TIM4_DIER_CC2IE                         \ Capture/Compare 2 interrupt enable
$00000008 constant SEC_TIM4_TIM4_DIER_CC3IE                         \ Capture/Compare 3 interrupt enable
$00000010 constant SEC_TIM4_TIM4_DIER_CC4IE                         \ Capture/Compare 4 interrupt enable
$00000040 constant SEC_TIM4_TIM4_DIER_TIE                           \ Trigger interrupt enable
$00000100 constant SEC_TIM4_TIM4_DIER_UDE                           \ Update DMA request enable
$00000200 constant SEC_TIM4_TIM4_DIER_CC1DE                         \ Capture/Compare 1 DMA request enable
$00000400 constant SEC_TIM4_TIM4_DIER_CC2DE                         \ Capture/Compare 2 DMA request enable
$00000800 constant SEC_TIM4_TIM4_DIER_CC3DE                         \ Capture/Compare 3 DMA request enable
$00001000 constant SEC_TIM4_TIM4_DIER_CC4DE                         \ Capture/Compare 4 DMA request enable
$00004000 constant SEC_TIM4_TIM4_DIER_TDE                           \ Trigger DMA request enable
$00100000 constant SEC_TIM4_TIM4_DIER_IDXIE                         \ Index interrupt enable
$00200000 constant SEC_TIM4_TIM4_DIER_DIRIE                         \ Direction change interrupt enable
$00400000 constant SEC_TIM4_TIM4_DIER_IERRIE                        \ Index error interrupt enable
$00800000 constant SEC_TIM4_TIM4_DIER_TERRIE                        \ Transition error interrupt enable


\
\ @brief TIM4 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM4_TIM4_SR_UIF                             \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow and if UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to the synchro control register description), if URS=0 and UDIS=0 in the TIMx_CR1 register.
$00000002 constant SEC_TIM4_TIM4_SR_CC1IF                           \ Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in downcounting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
$00000004 constant SEC_TIM4_TIM4_SR_CC2IF                           \ Capture/Compare 2 interrupt flag Refer to CC1IF description
$00000008 constant SEC_TIM4_TIM4_SR_CC3IF                           \ Capture/Compare 3 interrupt flag Refer to CC1IF description
$00000010 constant SEC_TIM4_TIM4_SR_CC4IF                           \ Capture/Compare 4 interrupt flag Refer to CC1IF description
$00000040 constant SEC_TIM4_TIM4_SR_TIF                             \ Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on tim_trgi input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
$00000200 constant SEC_TIM4_TIM4_SR_CC1OF                           \ Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0'.
$00000400 constant SEC_TIM4_TIM4_SR_CC2OF                           \ Capture/compare 2 overcapture flag refer to CC1OF description
$00000800 constant SEC_TIM4_TIM4_SR_CC3OF                           \ Capture/Compare 3 overcapture flag refer to CC1OF description
$00001000 constant SEC_TIM4_TIM4_SR_CC4OF                           \ Capture/Compare 4 overcapture flag refer to CC1OF description
$00100000 constant SEC_TIM4_TIM4_SR_IDXF                            \ Index interrupt flag This flag is set by hardware when an index event is detected. It is cleared by software by writing it to '0'.
$00200000 constant SEC_TIM4_TIM4_SR_DIRF                            \ Direction change interrupt flag This flag is set by hardware when the direction changes in encoder mode (DIR bit value in TIMx_CR is changing). It is cleared by software by writing it to '0'.
$00400000 constant SEC_TIM4_TIM4_SR_IERRF                           \ Index error interrupt flag This flag is set by hardware when an index error is detected. It is cleared by software by writing it to '0'.
$00800000 constant SEC_TIM4_TIM4_SR_TERRF                           \ Transition error interrupt flag This flag is set by hardware when a transition error is detected in encoder mode. It is cleared by software by writing it to '0'.


\
\ @brief TIM4 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM4_TIM4_EGR_UG                             \ Update generation This bit can be set by software, it is automatically cleared by hardware.
$00000002 constant SEC_TIM4_TIM4_EGR_CC1G                           \ Capture/compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
$00000004 constant SEC_TIM4_TIM4_EGR_CC2G                           \ Capture/compare 2 generation Refer to CC1G description
$00000008 constant SEC_TIM4_TIM4_EGR_CC3G                           \ Capture/compare 3 generation Refer to CC1G description
$00000010 constant SEC_TIM4_TIM4_EGR_CC4G                           \ Capture/compare 4 generation Refer to CC1G description
$00000040 constant SEC_TIM4_TIM4_EGR_TG                             \ Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.


\
\ @brief TIM4 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant SEC_TIM4_TIM4_CCMR1_INPUT_CC1S                   \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
$0000000c constant SEC_TIM4_TIM4_CCMR1_INPUT_IC1PSC                 \ Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (tim_ic1). The prescaler is reset as soon as CC1E=0 (TIMx_CCER register).
$000000f0 constant SEC_TIM4_TIM4_CCMR1_INPUT_IC1F                   \ Input capture 1 filter This bit-field defines the frequency used to sample tim_ti1 input and the length of the digital filter applied to tim_ti1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
$00000300 constant SEC_TIM4_TIM4_CCMR1_INPUT_CC2S                   \ Capture/compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
$00000c00 constant SEC_TIM4_TIM4_CCMR1_INPUT_IC2PSC                 \ Input capture 2 prescaler
$0000f000 constant SEC_TIM4_TIM4_CCMR1_INPUT_IC2F                   \ Input capture 2 filter


\
\ @brief TIM4 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_CC1S                  \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
$00000004 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC1FE                 \ Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
$00000008 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC1PE                 \ Output compare 1 preload enable Note: The PWM mode can be used without validating the preload register only in one-pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
$00000070 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC1M1                 \ Output compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 is derived. tim_oc1ref is active high whereas tim_oc1 active level depends on CC1P bit. Note: In PWM mode, the tim_ocref_clr level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode.
$00000080 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC1CE                 \ Output compare 1 clear enable
$00000300 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_CC2S                  \ Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
$00000400 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC2FE                 \ Output compare 2 fast enable
$00000800 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC2PE                 \ Output compare 2 preload enable
$00007000 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC2M1                 \ Output compare 2 mode refer to OC1M description on bits 6:4
$00008000 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC2CE                 \ Output compare 2 clear enable
$00010000 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC1M2                 \ Output compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 is derived. tim_oc1ref is active high whereas tim_oc1 active level depends on CC1P bit. Note: In PWM mode, the tim_ocref_clr level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode.
$01000000 constant SEC_TIM4_TIM4_CCMR1_OUTPUT_OC2M2                 \ Output compare 2 mode refer to OC1M description on bits 6:4


\
\ @brief TIM4 capture/compare mode register 2 [alternate]
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant SEC_TIM4_TIM4_CCMR2_INPUT_CC3S                   \ Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
$0000000c constant SEC_TIM4_TIM4_CCMR2_INPUT_IC3PSC                 \ Input capture 3 prescaler
$000000f0 constant SEC_TIM4_TIM4_CCMR2_INPUT_IC3F                   \ Input capture 3 filter
$00000300 constant SEC_TIM4_TIM4_CCMR2_INPUT_CC4S                   \ Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
$00000c00 constant SEC_TIM4_TIM4_CCMR2_INPUT_IC4PSC                 \ Input capture 4 prescaler
$0000f000 constant SEC_TIM4_TIM4_CCMR2_INPUT_IC4F                   \ Input capture 4 filter


\
\ @brief TIM4 capture/compare mode register 2 [alternate]
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_CC3S                  \ Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
$00000004 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC3FE                 \ Output compare 3 fast enable
$00000008 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC3PE                 \ Output compare 3 preload enable
$00000070 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC3M1                 \ Output compare 3 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
$00000080 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC3CE                 \ Output compare 3 clear enable
$00000300 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_CC4S                  \ Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
$00000400 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC4FE                 \ Output compare 4 fast enable
$00000800 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC4PE                 \ Output compare 4 preload enable
$00007000 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC4M1                 \ Output compare 4 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
$00008000 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC4CE                 \ Output compare 4 clear enable
$00010000 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC3M2                 \ Output compare 3 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
$01000000 constant SEC_TIM4_TIM4_CCMR2_OUTPUT_OC4M2                 \ Output compare 4 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)


\
\ @brief TIM4 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM4_TIM4_CCER_CC1E                          \ Capture/Compare 1 output enable.
$00000002 constant SEC_TIM4_TIM4_CCER_CC1P                          \ Capture/Compare 1 output Polarity. When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges. The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used.
$00000008 constant SEC_TIM4_TIM4_CCER_CC1NP                         \ Capture/Compare 1 output Polarity. CC1 channel configured as output: CC1NP must be kept cleared in this case. CC1 channel configured as input: This bit is used in conjunction with CC1P to define tim_ti1fp1/tim_ti2fp1 polarity. refer to CC1P description.
$00000010 constant SEC_TIM4_TIM4_CCER_CC2E                          \ Capture/Compare 2 output enable. Refer to CC1E description
$00000020 constant SEC_TIM4_TIM4_CCER_CC2P                          \ Capture/Compare 2 output Polarity. refer to CC1P description
$00000080 constant SEC_TIM4_TIM4_CCER_CC2NP                         \ Capture/Compare 2 output Polarity. Refer to CC1NP description
$00000100 constant SEC_TIM4_TIM4_CCER_CC3E                          \ Capture/Compare 3 output enable. Refer to CC1E description
$00000200 constant SEC_TIM4_TIM4_CCER_CC3P                          \ Capture/Compare 3 output Polarity. Refer to CC1P description
$00000800 constant SEC_TIM4_TIM4_CCER_CC3NP                         \ Capture/Compare 3 output Polarity. Refer to CC1NP description
$00001000 constant SEC_TIM4_TIM4_CCER_CC4E                          \ Capture/Compare 4 output enable. refer to CC1E description
$00002000 constant SEC_TIM4_TIM4_CCER_CC4P                          \ Capture/Compare 4 output Polarity. Refer to CC1P description
$00008000 constant SEC_TIM4_TIM4_CCER_CC4NP                         \ Capture/Compare 4 output Polarity. Refer to CC1NP description


\
\ @brief TIM4 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM4_TIM4_CNT_CNT                            \ Counter value' Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register holds the non-dithered part in CNT[15:0]. The fractional part is not available.
$80000000 constant SEC_TIM4_TIM4_CNT_UIFCPY                         \ Value depends on IUFREMAP in TIMx_CR1. If UIFREMAP = 0 Reserved If UIFREMAP = 1 UIFCPY: UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register


\
\ @brief TIM4 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM4_TIM4_PSC_PSC                            \ Prescaler value The counter clock frequency tim_cnt_ck is equal to ftim_psc_ck / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in 'reset mode').


\
\ @brief TIM4 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0xFFFFFFFF
\

$000fffff constant SEC_TIM4_TIM4_ARR_ARR                            \ Low Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[19:4]. The ARR[3:0] bitfield contains the dithered part.


\
\ @brief TIM4 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant SEC_TIM4_TIM4_CCR1_CCR1                          \ Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc1 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR1[19:4]. The CCR1[3:0] bitfield contains the dithered part. If channel CC1 is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (tim_ic1). The TIMx_CCR1 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The CCR1[15:0] bits hold the capture value. The CCR1[19:16] bits are reserved. Dithering mode (DITHEN = 1) The register holds the capture in CCR1[19:0]. The CCR1[3:0] bits are reset.


\
\ @brief TIM4 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant SEC_TIM4_TIM4_CCR2_CCR2                          \ Capture/compare 1 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc2 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR2[15:0]. The CCR2[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR2[19:4]. The CCR2[3:0] bitfield contains the dithered part. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 2 event (tim_ic2). The TIMx_CCR2 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The CCR2[15:0] bits hold the capture value. The CCR2[19:16] bits are reserved. Dithering mode (DITHEN = 1) The register holds the capture in CCR2[19:0]. The CCR2[3:0] bits are reset.


\
\ @brief TIM4 capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000fffff constant SEC_TIM4_TIM4_CCR3_CCR3                          \ Capture/compare 3 value If channel CC3 is configured as output: CCR3 is the value to be loaded in the actual capture/compare 3 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR3 register (bit OC3PE). Else the preload value is copied in the active capture/compare 3 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc3 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR3[15:0]. The CCR3[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR3[19:4]. The CCR3[3:0] bitfield contains the dithered part. If channel CC3 is configured as input: CCR3 is the counter value transferred by the last input capture 3 event (tim_ic3). The TIMx_CCR3 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The CCR3[15:0] bits hold the capture value. The CCR3[19:16] bits are reserved. Dithering mode (DITHEN = 1) The register holds the capture in CCR3[19:0]. The CCR3[3:0] bits are reset.


\
\ @brief TIM4 capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000fffff constant SEC_TIM4_TIM4_CCR4_CCR4                          \ Capture/compare 4 value If channel CC4 is configured as output: CCR4 is the value to be loaded in the actual capture/compare 4 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR4 register (bit OC4PE). Else the preload value is copied in the active capture/compare 4 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc4 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR4[15:0]. The CCR4[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR4[19:4]. The CCR4[3:0] bitfield contains the dithered part. If channel CC4 is configured as input: CCR4 is the counter value transferred by the last input capture 4 event (tim_ic4). The TIMx_CCR4 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The CCR4[15:0] bits hold the capture value. The CCR4[19:16] bits are reserved. Dithering mode (DITHEN = 1) The register holds the capture in CCR4[19:0]. The CCR4[3:0] bits are reset.


\
\ @brief TIM4 timer encoder control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM4_TIM4_ECR_IE                             \ Index enable This bit indicates if the Index event resets the counter.
$00000006 constant SEC_TIM4_TIM4_ECR_IDIR                           \ Index direction This bit indicates in which direction the Index event resets the counter. Note: The IDR[1:0] bitfield must be written when IE bit is reset (index disabled).
$00000018 constant SEC_TIM4_TIM4_ECR_IBLK                           \ Index blanking This bit indicates if the Index event is conditioned by the tim_ti3 input
$00000020 constant SEC_TIM4_TIM4_ECR_FIDX                           \ First index This bit indicates if the first index only is taken into account
$000000c0 constant SEC_TIM4_TIM4_ECR_IPOS                           \ Index positioning In quadrature encoder mode (SMS[3:0] = 0001, 0010, 0011, 1110, 1111), this bit indicates in which AB input configuration the Index event resets the counter. In directional clock mode or clock plus direction mode (SMS[3:0] = 1010, 1011, 1100, 1101), these bits indicates on which level the Index event resets the counter. In bidirectional clock mode, this applies for both clock inputs. x0: Index resets the counter when clock is 0 x1: Index resets the counter when clock is 1 Note: IPOS[1] bit is not significant
$00ff0000 constant SEC_TIM4_TIM4_ECR_PW                             \ Pulse width This bitfield defines the pulse duration, as following: tPW = PW[7:0] x tPWG
$07000000 constant SEC_TIM4_TIM4_ECR_PWPRSC                         \ Pulse width prescaler This bitfield sets the clock prescaler for the pulse generator, as following: tPWG = (2(PWPRSC[2:0])) x ttim_ker_ck


\
\ @brief TIM4 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant SEC_TIM4_TIM4_TISEL_TI1SEL                       \ Selects tim_ti1[0..15] input ... Refer to for product specific implementation.
$00000f00 constant SEC_TIM4_TIM4_TISEL_TI2SEL                       \ Selects tim_ti2[0..15] input ... Refer to for product specific implementation.
$000f0000 constant SEC_TIM4_TIM4_TISEL_TI3SEL                       \ Selects tim_ti3[0..15] input ... Refer to for product specific implementation.
$0f000000 constant SEC_TIM4_TIM4_TISEL_TI4SEL                       \ Selects tim_ti4[0..15] input ... Refer to for product specific implementation.


\
\ @brief TIM4 alternate function register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0003c000 constant SEC_TIM4_TIM4_AF1_ETRSEL                         \ etr_in source selection These bits select the etr_in input source. ... Refer to for product specific implementation.


\
\ @brief TIM4 alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00070000 constant SEC_TIM4_TIM4_AF2_OCRSEL                         \ ocref_clr source selection These bits select the ocref_clr input source. ... Refer to for product specific implementation.


\
\ @brief TIM4 DMA control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant SEC_TIM4_TIM4_DCR_DBA                            \ DMA base address This 5-bits vector defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ...
$00001f00 constant SEC_TIM4_TIM4_DCR_DBL                            \ DMA burst length This 5-bit vector defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address), i.e. the number of transfers. Transfers can be in half-words or in bytes (see example below). ... Example: Let us consider the following transfer: DBL = 7 bytes & DBA = TIM2_CR1. If DBL = 7 bytes and DBA = TIM2_CR1 represents the address of the byte to be transferred, the address of the transfer should be given by the following equation: (TIMx_CR1 address) + DBA + (DMA index), where DMA index = DBL In this example, 7 bytes are added to (TIMx_CR1 address) + DBA, which gives us the address from/to which the data are copied. In this case, the transfer is done to 7 registers starting from the following address: (TIMx_CR1 address) + DBA According to the configuration of the DMA Data Size, several cases may occur: If the DMA Data Size is configured in half-words, 16-bit data are transferred to each of the 7 registers. If the DMA Data Size is configured in bytes, the data are also transferred to 7 registers: the first register contains the first MSB byte, the second register, the first LSB byte and so on. So with the transfer Timer, one also has to specify the size of data transferred by DMA.
$000f0000 constant SEC_TIM4_TIM4_DCR_DBSS                           \ DMA burst source selection This bitfield defines the interrupt source that triggers the DMA burst transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). Others: reserved


\
\ @brief TIM4 DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant SEC_TIM4_TIM4_DMAR_DMAB                          \ DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).


\
\ @brief General-purpose timers
\
$50000800 constant SEC_TIM4_TIM4_CR1  \ offset: 0x00 : TIM4 control register 1
$50000804 constant SEC_TIM4_TIM4_CR2  \ offset: 0x04 : TIM4 control register 2
$50000808 constant SEC_TIM4_TIM4_SMCR  \ offset: 0x08 : TIM4 slave mode control register
$5000080c constant SEC_TIM4_TIM4_DIER  \ offset: 0x0C : TIM4 DMA/Interrupt enable register
$50000810 constant SEC_TIM4_TIM4_SR  \ offset: 0x10 : TIM4 status register
$50000814 constant SEC_TIM4_TIM4_EGR  \ offset: 0x14 : TIM4 event generation register
$50000818 constant SEC_TIM4_TIM4_CCMR1_INPUT  \ offset: 0x18 : TIM4 capture/compare mode register 1 [alternate]
$50000818 constant SEC_TIM4_TIM4_CCMR1_OUTPUT  \ offset: 0x18 : TIM4 capture/compare mode register 1 [alternate]
$5000081c constant SEC_TIM4_TIM4_CCMR2_INPUT  \ offset: 0x1C : TIM4 capture/compare mode register 2 [alternate]
$5000081c constant SEC_TIM4_TIM4_CCMR2_OUTPUT  \ offset: 0x1C : TIM4 capture/compare mode register 2 [alternate]
$50000820 constant SEC_TIM4_TIM4_CCER  \ offset: 0x20 : TIM4 capture/compare enable register
$50000824 constant SEC_TIM4_TIM4_CNT  \ offset: 0x24 : TIM4 counter
$50000828 constant SEC_TIM4_TIM4_PSC  \ offset: 0x28 : TIM4 prescaler
$5000082c constant SEC_TIM4_TIM4_ARR  \ offset: 0x2C : TIM4 auto-reload register
$50000834 constant SEC_TIM4_TIM4_CCR1  \ offset: 0x34 : TIM4 capture/compare register 1
$50000838 constant SEC_TIM4_TIM4_CCR2  \ offset: 0x38 : TIM4 capture/compare register 2
$5000083c constant SEC_TIM4_TIM4_CCR3  \ offset: 0x3C : TIM4 capture/compare register 3
$50000840 constant SEC_TIM4_TIM4_CCR4  \ offset: 0x40 : TIM4 capture/compare register 4
$50000858 constant SEC_TIM4_TIM4_ECR  \ offset: 0x58 : TIM4 timer encoder control register
$5000085c constant SEC_TIM4_TIM4_TISEL  \ offset: 0x5C : TIM4 timer input selection register
$50000860 constant SEC_TIM4_TIM4_AF1  \ offset: 0x60 : TIM4 alternate function register 1
$50000864 constant SEC_TIM4_TIM4_AF2  \ offset: 0x64 : TIM4 alternate function register 2
$50000bdc constant SEC_TIM4_TIM4_DCR  \ offset: 0x3DC : TIM4 DMA control register
$50000be0 constant SEC_TIM4_TIM4_DMAR  \ offset: 0x3E0 : TIM4 DMA address for full transfer

