\
\ @file tim15.fs
\ @brief General purpose timers
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

$00000001 constant TIM15_CR1_CEN                                    \ Counter enable Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
$00000002 constant TIM15_CR1_UDIS                                   \ Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
$00000004 constant TIM15_CR1_URS                                    \ Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
$00000008 constant TIM15_CR1_OPM                                    \ One-pulse mode
$00000080 constant TIM15_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM15_CR1_CKD                                    \ Clock division This bitfield indicates the division ratio between the timer clock (CK_INT) frequency and the dead-time and sampling clock (tDTS) used by the dead-time generators and the digital filters (TIx)
$00000800 constant TIM15_CR1_UIFREMAP                               \ UIF status bit remapping


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM15_CR2_CCPC                                   \ Capture/compare preloaded control Note: This bit acts only on channels that have a complementary output.
$00000004 constant TIM15_CR2_CCUS                                   \ Capture/compare control update selection Note: This bit acts only on channels that have a complementary output.
$00000008 constant TIM15_CR2_CCDS                                   \ Capture/compare DMA selection
$00000070 constant TIM15_CR2_MMS                                    \ Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows:
$00000080 constant TIM15_CR2_TI1S                                   \ TI1 selection
$00000100 constant TIM15_CR2_OIS1                                   \ Output Idle state 1 (OC1 output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register).
$00000200 constant TIM15_CR2_OIS1N                                  \ Output Idle state 1 (OC1N output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register).
$00000400 constant TIM15_CR2_OIS2                                   \ Output idle state 2 (OC2 output) Note: This bit cannot be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in the TIM15_BDTR register).


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM15_SMCR_SMS1                                  \ Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Other codes: reserved. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS='00100'). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the TRGO or the TRGO2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
$00000070 constant TIM15_SMCR_TS1                                   \ Trigger selection This bit field selects the trigger input to be used to synchronize the counter. Other: Reserved See for more details on ITRx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
$00000080 constant TIM15_SMCR_MSM                                   \ Master/slave mode
$00010000 constant TIM15_SMCR_SMS2                                  \ Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Other codes: reserved. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS='00100'). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the TRGO or the TRGO2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
$00300000 constant TIM15_SMCR_TS2                                   \ Trigger selection This bit field selects the trigger input to be used to synchronize the counter. Other: Reserved See for more details on ITRx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM15_DIER_UIE                                   \ Update interrupt enable
$00000002 constant TIM15_DIER_CC1IE                                 \ Capture/Compare 1 interrupt enable
$00000004 constant TIM15_DIER_CC2IE                                 \ Capture/Compare 2 interrupt enable
$00000020 constant TIM15_DIER_COMIE                                 \ COM interrupt enable
$00000040 constant TIM15_DIER_TIE                                   \ Trigger interrupt enable
$00000080 constant TIM15_DIER_BIE                                   \ Break interrupt enable
$00000100 constant TIM15_DIER_UDE                                   \ Update DMA request enable
$00000200 constant TIM15_DIER_CC1DE                                 \ Capture/Compare 1 DMA request enable
$00000400 constant TIM15_DIER_CC2DE                                 \ Capture/Compare 2 DMA request enable
$00002000 constant TIM15_DIER_COMDE                                 \ COM DMA request enable
$00004000 constant TIM15_DIER_TDE                                   \ Trigger DMA request enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM15_SR_UIF                                     \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to control register (TIM15_SMCR)), if URS=0 and UDIS=0 in the TIMx_CR1 register.
$00000002 constant TIM15_SR_CC1IF                                   \ Capture/Compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
$00000004 constant TIM15_SR_CC2IF                                   \ Capture/Compare 2 interrupt flag refer to CC1IF description
$00000020 constant TIM15_SR_COMIF                                   \ COM interrupt flag
$00000040 constant TIM15_SR_TIF                                     \ Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on TRGI input when the slave mode controller is enabled in all modes but gated mode, both edges in case gated mode is selected). It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
$00000080 constant TIM15_SR_BIF                                     \ Break interrupt flag This flag is set by hardware as soon as the break input goes active. It can be cleared by software if the break input is not active.
$00000200 constant TIM15_SR_CC1OF                                   \ Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0'.
$00000400 constant TIM15_SR_CC2OF                                   \ Capture/Compare 2 overcapture flag Refer to CC1OF description


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM15_EGR_UG                                     \ Update generation This bit can be set by software, it is automatically cleared by hardware.
$00000002 constant TIM15_EGR_CC1G                                   \ Capture/Compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
$00000004 constant TIM15_EGR_CC2G                                   \ Capture/Compare 2 generation Refer to CC1G description
$00000020 constant TIM15_EGR_COMG                                   \ Capture/Compare control update generation This bit can be set by software, it is automatically cleared by hardware. Note: This bit acts only on channels that have a complementary output.
$00000040 constant TIM15_EGR_TG                                     \ Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
$00000080 constant TIM15_EGR_BG                                     \ Break generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.


\
\ @brief capture/compare mode register (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_CCMR1_OUTPUT_CC1S                          \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIMx_CCER).
$00000004 constant TIM15_CCMR1_OUTPUT_OC1FE                         \ Output Compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
$00000008 constant TIM15_CCMR1_OUTPUT_OC1PE                         \ Output Compare 1 preload enable Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). The PWM mode can be used without validating the preload register only in one pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
$00000070 constant TIM15_CCMR1_OUTPUT_OC1M1                         \ Output Compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode. On channels that have a complementary output, this bit field is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the OC1M active bits take the new value from the preloaded bits only when a COM event is generated. The OC1M[3] bit is not contiguous, located in bit 16.
$00000300 constant TIM15_CCMR1_OUTPUT_CC2S                          \ Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = '0' in TIMx_CCER).
$00000400 constant TIM15_CCMR1_OUTPUT_OC2FE                         \ Output Compare 2 fast enable
$00000800 constant TIM15_CCMR1_OUTPUT_OC2PE                         \ Output Compare 2 preload enable
$00007000 constant TIM15_CCMR1_OUTPUT_OC2M1                         \ Output Compare 2 mode
$00010000 constant TIM15_CCMR1_OUTPUT_OC1M2                         \ Output Compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode. On channels that have a complementary output, this bit field is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the OC1M active bits take the new value from the preloaded bits only when a COM event is generated. The OC1M[3] bit is not contiguous, located in bit 16.
$01000000 constant TIM15_CCMR1_OUTPUT_OC2M2                         \ Output Compare 2 mode


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 Selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIMx_CCER).
$0000000c constant TIM15_CCMR1_INPUT_IC1PSC                         \ Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (IC1). The prescaler is reset as soon as CC1E='0' (TIMx_CCER register).
$000000f0 constant TIM15_CCMR1_INPUT_IC1F                           \ Input capture 1 filter This bit-field defines the frequency used to sample TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
$00000300 constant TIM15_CCMR1_INPUT_CC2S                           \ Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = '0' in TIMx_CCER).
$00000c00 constant TIM15_CCMR1_INPUT_IC2PSC                         \ Input capture 2 prescaler
$0000f000 constant TIM15_CCMR1_INPUT_IC2F                           \ Input capture 2 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM15_CCER_CC1E                                  \ Capture/Compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to for details.
$00000002 constant TIM15_CCER_CC1P                                  \ Capture/Compare 1 output polarity When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register). On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000004 constant TIM15_CCER_CC1NE                                 \ Capture/Compare 1 complementary output enable
$00000008 constant TIM15_CCER_CC1NP                                 \ Capture/Compare 1 complementary output polarity CC1 channel configured as output: CC1 channel configured as input: This bit is used in conjunction with CC1P to define the polarity of TI1FP1 and TI2FP1. Refer to CC1P description. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NP active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000010 constant TIM15_CCER_CC2E                                  \ Capture/Compare 2 output enable Refer to CC1E description
$00000020 constant TIM15_CCER_CC2P                                  \ Capture/Compare 2 output polarity Refer to CC1P description
$00000080 constant TIM15_CCER_CC2NP                                 \ Capture/Compare 2 complementary output polarity Refer to CC1NP description


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_CNT_CNT                                    \ counter value
$80000000 constant TIM15_CNT_UIFCPY                                 \ UIF Copy


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_PSC_PSC                                    \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM15_ARR_ARR                                    \ Auto-reload value


\
\ @brief repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM15_RCR_REP                                    \ Repetition counter value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_CCR1_CCR1                                  \ Capture/Compare 1 value


\
\ @brief capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_CCR2_CCR2                                  \ Capture/Compare 2 value


\
\ @brief break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM15_BDTR_DTG                                   \ Dead-time generator setup
$00000300 constant TIM15_BDTR_LOCK                                  \ Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIMx_BDTR register has been written, their content is frozen until the next reset.
$00000400 constant TIM15_BDTR_OSSI                                  \ Off-state selection for Idle mode This bit is used when MOE=0 on channels configured as outputs. See OC/OCN enable description for more details (enable register (TIM15_CCER) on page818). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00000800 constant TIM15_BDTR_OSSR                                  \ Off-state selection for Run mode This bit is used when MOE=1 on channels that have a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See OC/OCN enable description for more details (enable register (TIM15_CCER) on page818). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00001000 constant TIM15_BDTR_BKE                                   \ Break enable 1; Break inputs (BRK and CCS clock failure event) enabled This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00002000 constant TIM15_BDTR_BKP                                   \ Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00004000 constant TIM15_BDTR_AOE                                   \ Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00008000 constant TIM15_BDTR_MOE                                   \ Main output enable This bit is cleared asynchronously by hardware as soon as the break input is active. It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. See OC/OCN enable description for more details (enable register (TIM15_CCER) on page818).
$000f0000 constant TIM15_BDTR_BKF                                   \ Break filter This bit-field defines the frequency used to sample the BRK input signal and the length of the digital filter applied to BRK. The digital filter is made of an event counter in which N events are needed to validate a transition on the output: Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$04000000 constant TIM15_BDTR_BKDSRM                                \ Break Disarm This bit is cleared by hardware when no break source is active. The BKDSRM bit must be set by software to release the bidirectional output control (open-drain output in Hi-Z state) and then be polled it until it is reset by hardware, indicating that the fault condition has disappeared. Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$10000000 constant TIM15_BDTR_BKBID                                 \ Break Bidirectional In the bidirectional mode (BKBID bit set to 1), the break input is configured both in input mode and in open drain output mode. Any active break event asserts a low logic level on the Break input to indicate an internal break event to external devices. Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.


\
\ @brief DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM15_DCR_DBA                                    \ DMA base address This 5-bit field defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ...
$00001f00 constant TIM15_DCR_DBL                                    \ DMA burst length This 5-bit field defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). ...


\
\ @brief DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_DMAR_DMAB                                  \ DMA register for burst accesses


\
\ @brief TIM15 alternate register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM15_AF1_BKINE                                  \ BRK BKIN input enable This bit enables the BKIN alternate function input for the timer's BRK input. BKIN input is 'ORed' with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000200 constant TIM15_AF1_BKINP                                  \ BRK BKIN input polarity This bit selects the BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM15_TISEL_TI1SEL                               \ selects TI1[0] to TI1[15] input Others: Reserved
$00000f00 constant TIM15_TISEL_TI2SEL                               \ selects TI2[0] to TI2[15] input Others: Reserved


\
\ @brief General purpose timers
\
$40014000 constant TIM15_CR1      \ offset: 0x00 : control register 1
$40014004 constant TIM15_CR2      \ offset: 0x04 : control register 2
$40014008 constant TIM15_SMCR     \ offset: 0x08 : slave mode control register
$4001400c constant TIM15_DIER     \ offset: 0x0C : DMA/Interrupt enable register
$40014010 constant TIM15_SR       \ offset: 0x10 : status register
$40014014 constant TIM15_EGR      \ offset: 0x14 : event generation register
$40014018 constant TIM15_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register (output mode)
$40014018 constant TIM15_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40014020 constant TIM15_CCER     \ offset: 0x20 : capture/compare enable register
$40014024 constant TIM15_CNT      \ offset: 0x24 : counter
$40014028 constant TIM15_PSC      \ offset: 0x28 : prescaler
$4001402c constant TIM15_ARR      \ offset: 0x2C : auto-reload register
$40014030 constant TIM15_RCR      \ offset: 0x30 : repetition counter register
$40014034 constant TIM15_CCR1     \ offset: 0x34 : capture/compare register 1
$40014038 constant TIM15_CCR2     \ offset: 0x38 : capture/compare register 2
$40014044 constant TIM15_BDTR     \ offset: 0x44 : break and dead-time register
$40014048 constant TIM15_DCR      \ offset: 0x48 : DMA control register
$4001404c constant TIM15_DMAR     \ offset: 0x4C : DMA address for full transfer
$40014060 constant TIM15_AF1      \ offset: 0x60 : TIM15 alternate register 1
$40014068 constant TIM15_TISEL    \ offset: 0x68 : input selection register

