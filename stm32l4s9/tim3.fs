\
\ @file tim3.fs
\ @brief General-purpose-timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM3 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_CR1_CEN                                \ Counter enable Note: External clock, gated mode and encoder mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware. CEN is cleared automatically in one-pulse mode, when an update event occurs.
$00000002 constant TIM3_TIM3_CR1_UDIS                               \ Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
$00000004 constant TIM3_TIM3_CR1_URS                                \ Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
$00000008 constant TIM3_TIM3_CR1_OPM                                \ One-pulse mode
$00000010 constant TIM3_TIM3_CR1_DIR                                \ Direction Note: This bit is read only when the timer is configured in Center-aligned mode or Encoder mode.
$00000060 constant TIM3_TIM3_CR1_CMS                                \ Center-aligned mode selection Note: It is not allowed to switch from edge-aligned mode to center-aligned mode as long as the counter is enabled (CEN=1)
$00000080 constant TIM3_TIM3_CR1_ARPE                               \ Auto-reload preload enable
$00000300 constant TIM3_TIM3_CR1_CKD                                \ Clock division This bit-field indicates the division ratio between the timer clock (CK_INT) frequency and sampling clock used by the digital filters (ETR, TIx),
$00000800 constant TIM3_TIM3_CR1_UIFREMAP                           \ UIF status bit remapping


\
\ @brief TIM3 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000008 constant TIM3_TIM3_CR2_CCDS                               \ Capture/compare DMA selection
$00000070 constant TIM3_TIM3_CR2_MMS                                \ Master mode selection These bits permit to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows: When the Counter Enable signal is controlled by the trigger input, there is a delay on TRGO, except if the master/slave mode is selected (see the MSM bit description in TIMx_SMCR register). Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
$00000080 constant TIM3_TIM3_CR2_TI1S                               \ TI1 selection


\
\ @brief TIM3 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM3_TIM3_SMCR_SMS                               \ SMS[0]: Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control Register description. reinitializes the counter, generates an update of the registers and starts the counter. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS=00100). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the TRGO or the TRGO2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
$00000070 constant TIM3_TIM3_SMCR_TS                                \ TS[0]: Trigger selection This bit-field selects the trigger input to be used to synchronize the counter. Others: Reserved See Table 179: TIMx internal trigger connection on page 846 for more details on ITRx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
$00000080 constant TIM3_TIM3_SMCR_MSM                               \ Master/Slave mode
$00000f00 constant TIM3_TIM3_SMCR_ETF                               \ External trigger filter This bit-field then defines the frequency used to sample ETRP signal and the length of the digital filter applied to ETRP. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
$00003000 constant TIM3_TIM3_SMCR_ETPS                              \ External trigger prescaler External trigger signal ETRP frequency must be at most 1/4 of CK_INT frequency. A prescaler can be enabled to reduce ETRP frequency. It is useful when inputting fast external clocks.
$00004000 constant TIM3_TIM3_SMCR_ECE                               \ External clock enable This bit enables External clock mode 2. Note: Setting the ECE bit has the same effect as selecting external clock mode 1 with TRGI connected to ETRF (SMS=111 and TS=00111). Note: It is possible to simultaneously use external clock mode 2 with the following slave modes: reset mode, gated mode and trigger mode. Nevertheless, TRGI must not be connected to ETRF in this case (TS bits must not be 00111). Note: If external clock mode 1 and external clock mode 2 are enabled at the same time, the external clock input is ETRF.
$00008000 constant TIM3_TIM3_SMCR_ETP                               \ External trigger polarity This bit selects whether ETR or ETR is used for trigger operations
$00010000 constant TIM3_TIM3_SMCR_SMS_1                             \ SMS[3]
$00300000 constant TIM3_TIM3_SMCR_TS_1                              \ TS[4:3]


\
\ @brief TIM3 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_DIER_UIE                               \ Update interrupt enable
$00000002 constant TIM3_TIM3_DIER_CC1IE                             \ Capture/Compare 1 interrupt enable
$00000004 constant TIM3_TIM3_DIER_CC2IE                             \ Capture/Compare 2 interrupt enable
$00000008 constant TIM3_TIM3_DIER_CC3IE                             \ Capture/Compare 3 interrupt enable
$00000010 constant TIM3_TIM3_DIER_CC4IE                             \ Capture/Compare 4 interrupt enable
$00000040 constant TIM3_TIM3_DIER_TIE                               \ Trigger interrupt enable
$00000100 constant TIM3_TIM3_DIER_UDE                               \ Update DMA request enable
$00000200 constant TIM3_TIM3_DIER_CC1DE                             \ Capture/Compare 1 DMA request enable
$00000400 constant TIM3_TIM3_DIER_CC2DE                             \ Capture/Compare 2 DMA request enable
$00000800 constant TIM3_TIM3_DIER_CC3DE                             \ Capture/Compare 3 DMA request enable
$00001000 constant TIM3_TIM3_DIER_CC4DE                             \ Capture/Compare 4 DMA request enable
$00004000 constant TIM3_TIM3_DIER_TDE                               \ Trigger DMA request enable


\
\ @brief TIM3 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_SR_UIF                                 \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow (for TIM2 to TIM4) and if UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to the synchro control register description), if URS=0 and UDIS=0 in the TIMx_CR1 register.
$00000002 constant TIM3_TIM3_SR_CC1IF                               \ Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
$00000004 constant TIM3_TIM3_SR_CC2IF                               \ Capture/Compare 2 interrupt flag Refer to CC1IF description
$00000008 constant TIM3_TIM3_SR_CC3IF                               \ Capture/Compare 3 interrupt flag Refer to CC1IF description
$00000010 constant TIM3_TIM3_SR_CC4IF                               \ Capture/Compare 4 interrupt flag Refer to CC1IF description
$00000040 constant TIM3_TIM3_SR_TIF                                 \ Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on TRGI input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
$00000200 constant TIM3_TIM3_SR_CC1OF                               \ Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to 0 .
$00000400 constant TIM3_TIM3_SR_CC2OF                               \ Capture/compare 2 overcapture flag refer to CC1OF description
$00000800 constant TIM3_TIM3_SR_CC3OF                               \ Capture/Compare 3 overcapture flag refer to CC1OF description
$00001000 constant TIM3_TIM3_SR_CC4OF                               \ Capture/Compare 4 overcapture flag refer to CC1OF description


\
\ @brief TIM3 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_EGR_UG                                 \ Update generation This bit can be set by software, it is automatically cleared by hardware.
$00000002 constant TIM3_TIM3_EGR_CC1G                               \ Capture/compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
$00000004 constant TIM3_TIM3_EGR_CC2G                               \ Capture/compare 2 generation Refer to CC1G description
$00000008 constant TIM3_TIM3_EGR_CC3G                               \ Capture/compare 3 generation Refer to CC1G description
$00000010 constant TIM3_TIM3_EGR_CC4G                               \ Capture/compare 4 generation Refer to CC1G description
$00000040 constant TIM3_TIM3_EGR_TG                                 \ Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.


\
\ @brief TIM3 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM3_TIM3_CCMR1_CC1S                             \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
$0000000c constant TIM3_TIM3_CCMR1_IC1PSC                           \ Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (IC1). The prescaler is reset as soon as CC1E=0 (TIMx_CCER register).
$000000f0 constant TIM3_TIM3_CCMR1_IC1F                             \ Input capture 1 filter This bit-field defines the frequency used to sample TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
$00000300 constant TIM3_TIM3_CCMR1_CC2S                             \ Capture/compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
$00000c00 constant TIM3_TIM3_CCMR1_IC2PSC                           \ Input capture 2 prescaler
$0000f000 constant TIM3_TIM3_CCMR1_IC2F                             \ Input capture 2 filter


\
\ @brief TIM3 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM3_TIM3_CCMR1_ALTERNATE_CC1S                   \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
$00000004 constant TIM3_TIM3_CCMR1_ALTERNATE_OC1FE                  \ Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
$00000008 constant TIM3_TIM3_CCMR1_ALTERNATE_OC1PE                  \ Output compare 1 preload enable
$00000070 constant TIM3_TIM3_CCMR1_ALTERNATE_OC1M                   \ OC1M[2:0]: Output compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from frozen mode to PWM mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
$00000080 constant TIM3_TIM3_CCMR1_ALTERNATE_OC1CE                  \ Output compare 1 clear enable
$00000300 constant TIM3_TIM3_CCMR1_ALTERNATE_CC2S                   \ Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
$00000400 constant TIM3_TIM3_CCMR1_ALTERNATE_OC2FE                  \ Output compare 2 fast enable
$00000800 constant TIM3_TIM3_CCMR1_ALTERNATE_OC2PE                  \ Output compare 2 preload enable
$00007000 constant TIM3_TIM3_CCMR1_ALTERNATE_OC2M                   \ OC2M[2:0]: Output compare 2 mode refer to OC1M description on bits 6:4
$00008000 constant TIM3_TIM3_CCMR1_ALTERNATE_OC2CE                  \ Output compare 2 clear enable
$00010000 constant TIM3_TIM3_CCMR1_ALTERNATE_OC1M_1                 \ OC1M[3]
$01000000 constant TIM3_TIM3_CCMR1_ALTERNATE_OC2M_1                 \ OC2M[3]


\
\ @brief TIM3 capture/compare mode register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM3_TIM3_CCMR2_CC3S                             \ Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
$0000000c constant TIM3_TIM3_CCMR2_IC3PSC                           \ Input capture 3 prescaler
$000000f0 constant TIM3_TIM3_CCMR2_IC3F                             \ Input capture 3 filter
$00000300 constant TIM3_TIM3_CCMR2_CC4S                             \ Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
$00000c00 constant TIM3_TIM3_CCMR2_IC4PSC                           \ Input capture 4 prescaler
$0000f000 constant TIM3_TIM3_CCMR2_IC4F                             \ Input capture 4 filter


\
\ @brief TIM3 capture/compare mode register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM3_TIM3_CCMR2_ALTERNATE_CC3S                   \ Capture/Compare 3 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC3S bits are writable only when the channel is OFF (CC3E = 0 in TIMx_CCER).
$00000004 constant TIM3_TIM3_CCMR2_ALTERNATE_OC3FE                  \ Output compare 3 fast enable
$00000008 constant TIM3_TIM3_CCMR2_ALTERNATE_OC3PE                  \ Output compare 3 preload enable
$00000070 constant TIM3_TIM3_CCMR2_ALTERNATE_OC3M                   \ OC3M[2:0]: Output compare 3 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
$00000080 constant TIM3_TIM3_CCMR2_ALTERNATE_OC3CE                  \ Output compare 3 clear enable
$00000300 constant TIM3_TIM3_CCMR2_ALTERNATE_CC4S                   \ Capture/Compare 4 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC4S bits are writable only when the channel is OFF (CC4E = 0 in TIMx_CCER).
$00000400 constant TIM3_TIM3_CCMR2_ALTERNATE_OC4FE                  \ Output compare 4 fast enable
$00000800 constant TIM3_TIM3_CCMR2_ALTERNATE_OC4PE                  \ Output compare 4 preload enable
$00007000 constant TIM3_TIM3_CCMR2_ALTERNATE_OC4M                   \ OC4M[2:0]: Output compare 4 mode Refer to OC1M description (bits 6:4 in TIMx_CCMR1 register)
$00008000 constant TIM3_TIM3_CCMR2_ALTERNATE_OC4CE                  \ Output compare 4 clear enable
$00010000 constant TIM3_TIM3_CCMR2_ALTERNATE_OC3M_1                 \ OC3M[3]
$01000000 constant TIM3_TIM3_CCMR2_ALTERNATE_OC4M_1                 \ OC4M[3]


\
\ @brief TIM3 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_CCER_CC1E                              \ Capture/Compare 1 output enable.
$00000002 constant TIM3_TIM3_CCER_CC1P                              \ Capture/Compare 1 output Polarity. When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges. The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: This configuration is reserved, it must not be used.
$00000008 constant TIM3_TIM3_CCER_CC1NP                             \ Capture/Compare 1 output Polarity. CC1 channel configured as output: CC1NP must be kept cleared in this case. CC1 channel configured as input: This bit is used in conjunction with CC1P to define TI1FP1/TI2FP1 polarity. refer to CC1P description.
$00000010 constant TIM3_TIM3_CCER_CC2E                              \ Capture/Compare 2 output enable. Refer to CC1E description
$00000020 constant TIM3_TIM3_CCER_CC2P                              \ Capture/Compare 2 output Polarity. refer to CC1P description
$00000080 constant TIM3_TIM3_CCER_CC2NP                             \ Capture/Compare 2 output Polarity. Refer to CC1NP description
$00000100 constant TIM3_TIM3_CCER_CC3E                              \ Capture/Compare 3 output enable. Refer to CC1E description
$00000200 constant TIM3_TIM3_CCER_CC3P                              \ Capture/Compare 3 output Polarity. Refer to CC1P description
$00000800 constant TIM3_TIM3_CCER_CC3NP                             \ Capture/Compare 3 output Polarity. Refer to CC1NP description
$00001000 constant TIM3_TIM3_CCER_CC4E                              \ Capture/Compare 4 output enable. refer to CC1E description
$00002000 constant TIM3_TIM3_CCER_CC4P                              \ Capture/Compare 4 output Polarity. Refer to CC1P description
$00008000 constant TIM3_TIM3_CCER_CC4NP                             \ Capture/Compare 4 output Polarity. Refer to CC1NP description


\
\ @brief TIM3 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CNT_CNT                                \ Least significant part of counter value


\
\ @brief TIM3 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$7fffffff constant TIM3_TIM3_CNT_ALTERNATE_CNT                      \ Least significant part of counter value
$80000000 constant TIM3_TIM3_CNT_ALTERNATE_UIFCPY                   \ UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register


\
\ @brief TIM3 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM3_TIM3_PSC_PSC                                \ Prescaler value


\
\ @brief TIM3 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant TIM3_TIM3_ARR_ARR                                \ Low Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the Section 25.3.1: Time-base unit on page 786 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.


\
\ @brief TIM3 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CCR1_CCR1                              \ Low Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC1 output. If channel CC1is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (IC1). The TIMx_CCR1 register is read-only and cannot be programmed.


\
\ @brief TIM3 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CCR2_CCR2                              \ Low Capture/Compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on OC2 output. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 2 event (IC2). The TIMx_CCR2 register is read-only and cannot be programmed.


\
\ @brief TIM3 capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CCR3_CCR3                              \ Low Capture/Compare value If channel CC3 is configured as output: CCR3 is the value to be loaded in the actual capture/compare 3 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC3PE). Else the preload value is copied in the active capture/compare 3 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on OC3 output. If channel CC3is configured as input: CCR3 is the counter value transferred by the last input capture 3 event (IC3). The TIMx_CCR3 register is read-only and cannot be programmed.


\
\ @brief TIM3 capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CCR4_CCR4                              \ Low Capture/Compare value if CC4 channel is configured as output (CC4S bits): CCR4 is the value to be loaded in the actual capture/compare 4 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC4PE). Else the preload value is copied in the active capture/compare 4 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on OC4 output. if CC4 channel is configured as input (CC4S bits in TIMx_CCMR4 register): CCR4 is the counter value transferred by the last input capture 4 event (IC4). The TIMx_CCR4 register is read-only and cannot be programmed.


\
\ @brief TIM3 DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM3_TIM3_DCR_DBA                                \ DMA base address This 5-bit vector defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ... Example: Let us consider the following transfer: DBL = 7 transfers & DBA = TIMx_CR1. In this case the transfer is done to/from 7 registers starting from the TIMx_CR1 address.
$00001f00 constant TIM3_TIM3_DCR_DBL                                \ DMA burst length This 5-bit vector defines the number of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). ...


\
\ @brief TIM3 DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM3_TIM3_DMAR_DMAB                              \ DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).


\
\ @brief TIM3 alternate function option register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0003c000 constant TIM3_TIM3_AF1_ETRSEL                             \ ETR source selection These bits select the ETR input source. Others: Reserved


\
\ @brief TIM3 timer input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM3_TIM3_TISEL_TI1SEL                           \ TI1[0] to TI1[15] input selection These bits select the TI1[0] to TI1[15] input source. Others: Reserved
$00000f00 constant TIM3_TIM3_TISEL_TI2SEL                           \ TI2[0] to TI2[15] input selection These bits select the TI2[0] to TI2[15] input source. Others: Reserved
$000f0000 constant TIM3_TIM3_TISEL_TI3SEL                           \ TI3[0] to TI3[15] input selection These bits select the TI3[0] to TI3[15] input source. Others: Reserved
$0f000000 constant TIM3_TIM3_TISEL_TI4SEL                           \ TI4[0] to TI4[15] input selection These bits select the TI4[0] to TI4[15] input source. Others: Reserved


\
\ @brief General-purpose-timers
\
$40000400 constant TIM3_TIM3_CR1  \ offset: 0x00 : TIM3 control register 1
$40000404 constant TIM3_TIM3_CR2  \ offset: 0x04 : TIM3 control register 2
$40000408 constant TIM3_TIM3_SMCR  \ offset: 0x08 : TIM3 slave mode control register
$4000040c constant TIM3_TIM3_DIER  \ offset: 0x0C : TIM3 DMA/Interrupt enable register
$40000410 constant TIM3_TIM3_SR   \ offset: 0x10 : TIM3 status register
$40000414 constant TIM3_TIM3_EGR  \ offset: 0x14 : TIM3 event generation register
$40000418 constant TIM3_TIM3_CCMR1  \ offset: 0x18 : TIM3 capture/compare mode register 1
$40000418 constant TIM3_TIM3_CCMR1_ALTERNATE  \ offset: 0x18 : TIM3 capture/compare mode register 1
$4000041c constant TIM3_TIM3_CCMR2  \ offset: 0x1C : TIM3 capture/compare mode register 2
$4000041c constant TIM3_TIM3_CCMR2_ALTERNATE  \ offset: 0x1C : TIM3 capture/compare mode register 2
$40000420 constant TIM3_TIM3_CCER  \ offset: 0x20 : TIM3 capture/compare enable register
$40000424 constant TIM3_TIM3_CNT  \ offset: 0x24 : TIM3 counter
$40000424 constant TIM3_TIM3_CNT_ALTERNATE  \ offset: 0x24 : TIM3 counter
$40000428 constant TIM3_TIM3_PSC  \ offset: 0x28 : TIM3 prescaler
$4000042c constant TIM3_TIM3_ARR  \ offset: 0x2C : TIM3 auto-reload register
$40000434 constant TIM3_TIM3_CCR1  \ offset: 0x34 : TIM3 capture/compare register 1
$40000438 constant TIM3_TIM3_CCR2  \ offset: 0x38 : TIM3 capture/compare register 2
$4000043c constant TIM3_TIM3_CCR3  \ offset: 0x3C : TIM3 capture/compare register 3
$40000440 constant TIM3_TIM3_CCR4  \ offset: 0x40 : TIM3 capture/compare register 4
$40000448 constant TIM3_TIM3_DCR  \ offset: 0x48 : TIM3 DMA control register
$4000044c constant TIM3_TIM3_DMAR  \ offset: 0x4C : TIM3 DMA address for full transfer
$40000460 constant TIM3_TIM3_AF1  \ offset: 0x60 : TIM3 alternate function option register 1
$40000468 constant TIM3_TIM3_TISEL  \ offset: 0x68 : TIM3 timer input selection register

