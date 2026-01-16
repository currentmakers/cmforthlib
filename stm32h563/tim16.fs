\
\ @file tim16.fs
\ @brief TIM16 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM16 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM16_TIM16_CR1_CEN                              \ Counter enable Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
$00000002 constant TIM16_TIM16_CR1_UDIS                             \ Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
$00000004 constant TIM16_TIM16_CR1_URS                              \ Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
$00000008 constant TIM16_TIM16_CR1_OPM                              \ One pulse mode
$00000080 constant TIM16_TIM16_CR1_ARPE                             \ Auto-reload preload enable
$00000300 constant TIM16_TIM16_CR1_CKD                              \ Clock division This bit-field indicates the division ratio between the timer clock (tim_ker_ck) frequency and the dead-time and sampling clock (tDTS)used by the dead-time generators and the digital filters (tim_tix),
$00000800 constant TIM16_TIM16_CR1_UIFREMAP                         \ UIF status bit remapping
$00001000 constant TIM16_TIM16_CR1_DITHEN                           \ Dithering enable Note: The DITHEN bit can only be modified when CEN bit is reset.


\
\ @brief TIM16 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM16_TIM16_CR2_CCPC                             \ Capture/compare preloaded control Note: This bit acts only on channels that have a complementary output.
$00000004 constant TIM16_TIM16_CR2_CCUS                             \ Capture/compare control update selection Note: This bit acts only on channels that have a complementary output.
$00000008 constant TIM16_TIM16_CR2_CCDS                             \ Capture/compare DMA selection
$00000100 constant TIM16_TIM16_CR2_OIS1                             \ Output Idle state 1 (tim_oc1 output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BKR register).
$00000200 constant TIM16_TIM16_CR2_OIS1N                            \ Output Idle state 1 (tim_oc1n output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BKR register).


\
\ @brief TIM16 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM16_TIM16_DIER_UIE                             \ Update interrupt enable
$00000002 constant TIM16_TIM16_DIER_CC1IE                           \ Capture/Compare 1 interrupt enable
$00000020 constant TIM16_TIM16_DIER_COMIE                           \ COM interrupt enable
$00000080 constant TIM16_TIM16_DIER_BIE                             \ Break interrupt enable
$00000100 constant TIM16_TIM16_DIER_UDE                             \ Update DMA request enable
$00000200 constant TIM16_TIM16_DIER_CC1DE                           \ Capture/Compare 1 DMA request enable
$00002000 constant TIM16_TIM16_DIER_COMDE                           \ COM DMA request enable


\
\ @brief TIM16 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM16_TIM16_SR_UIF                               \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register.
$00000002 constant TIM16_TIM16_SR_CC1IF                             \ Capture/Compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
$00000020 constant TIM16_TIM16_SR_COMIF                             \ COM interrupt flag This flag is set by hardware on a COM event (once the capture/compare control bits CCxE, CCxNE, OCxM have been updated). It is cleared by software.
$00000080 constant TIM16_TIM16_SR_BIF                               \ Break interrupt flag This flag is set by hardware as soon as the tim_brk input goes active. It can be cleared by software if the break input is not active.
$00000200 constant TIM16_TIM16_SR_CC1OF                             \ Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0'.


\
\ @brief TIM16 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM16_TIM16_EGR_UG                               \ Update generation This bit can be set by software, it is automatically cleared by hardware.
$00000002 constant TIM16_TIM16_EGR_CC1G                             \ Capture/Compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
$00000020 constant TIM16_TIM16_EGR_COMG                             \ Capture/Compare control update generation This bit can be set by software, it is automatically cleared by hardware. Note: This bit acts only on channels that have a complementary output.
$00000080 constant TIM16_TIM16_EGR_BG                               \ Break generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.


\
\ @brief TIM16 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM16_TIM16_CCMR1_INPUT_CC1S                     \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Others: Reserved Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIMx_CCER).
$0000000c constant TIM16_TIM16_CCMR1_INPUT_IC1PSC                   \ Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (tim_ic1). The prescaler is reset as soon as CC1E='0' (TIMx_CCER register).
$000000f0 constant TIM16_TIM16_CCMR1_INPUT_IC1F                     \ Input capture 1 filter This bit-field defines the frequency used to sample tim_ti1 input and the length of the digital filter applied to tim_ti1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:


\
\ @brief TIM16 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM16_TIM16_CCMR1_OUTPUT_CC1S                    \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Others: Reserved Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIMx_CCER).
$00000004 constant TIM16_TIM16_CCMR1_OUTPUT_OC1FE                   \ Output Compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
$00000008 constant TIM16_TIM16_CCMR1_OUTPUT_OC1PE                   \ Output Compare 1 preload enable Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). The PWM mode can be used without validating the preload register only in one pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
$00000070 constant TIM16_TIM16_CCMR1_OUTPUT_OC1M1                   \ Output Compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 and tim_oc1n are derived. tim_oc1ref is active high whereas tim_oc1 and tim_oc1n active level depends on CC1P and CC1NP bits. Others: Reserved Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). In PWM mode 1 or 2, the tim_oc1ref level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode.
$00000080 constant TIM16_TIM16_CCMR1_OUTPUT_OC1CE                   \ Output Compare 1 clear enable
$00010000 constant TIM16_TIM16_CCMR1_OUTPUT_OC1M2                   \ Output Compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 and tim_oc1n are derived. tim_oc1ref is active high whereas tim_oc1 and tim_oc1n active level depends on CC1P and CC1NP bits. Others: Reserved Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). In PWM mode 1 or 2, the tim_oc1ref level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode.


\
\ @brief TIM16 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM16_TIM16_CCER_CC1E                            \ Capture/Compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to for details.
$00000002 constant TIM16_TIM16_CCER_CC1P                            \ Capture/Compare 1 output polarity When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register). On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000004 constant TIM16_TIM16_CCER_CC1NE                           \ Capture/Compare 1 complementary output enable
$00000008 constant TIM16_TIM16_CCER_CC1NP                           \ Capture/Compare 1 complementary output polarity CC1 channel configured as output: CC1 channel configured as input: This bit is used in conjunction with CC1P to define the polarity of tim_ti1fp1. Refer to the description of CC1P. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NP active bit takes the new value from the preloaded bit only when a commutation event is generated.


\
\ @brief TIM16 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM16_TIM16_CNT_CNT                              \ Counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register only holds the non-dithered part in CNT[15:0]. The fractional part is not available.
$80000000 constant TIM16_TIM16_CNT_UIFCPY                           \ UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in TIMx_CR1 is reset, bit 31 is reserved.


\
\ @brief TIM16 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM16_TIM16_PSC_PSC                              \ Prescaler value The counter clock frequency (tim_cnt_ck) is equal to ftim_psc_ck / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in 'reset mode').


\
\ @brief TIM16 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM16_TIM16_ARR_ARR                              \ Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value in ARR[15:0]. The ARR[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[19:4]. The ARR[3:0] bitfield contains the dithered part.


\
\ @brief TIM16 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM16_TIM16_RCR_REP                              \ Repetition counter reload value This bitfield defines the update rate of the compare registers (i.e. periodic transfers from preload to active registers) when preload registers are enable. It also defines the update interrupt generation rate, if this interrupt is enable. When the repetition down-counter reaches zero, an update event is generated and it restarts counting from REP value. As the repetition counter is reloaded with REP value only at the repetition update event UEV, any write to the TIMx_RCR register is not taken in account until the next repetition update event. It means in PWM mode (REP+1) corresponds to the number of PWM periods in edge-aligned mode: the number of PWM periods in edge-aligned mode the number of half PWM period in center-aligned mode


\
\ @brief TIM16 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM16_TIM16_CCR1_CCR1                            \ Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc1 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR1[19:4]. The CCR1[3:0] bitfield contains the dithered part. If channel CC1 is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (tim_ic1). Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR1[19:4]. The CCR1[3:0] bits are reset.


\
\ @brief TIM16 break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM16_TIM16_BDTR_DTG                             \ Dead-time generator setup This bit-field defines the duration of the dead-time inserted between the complementary outputs. DT correspond to this duration. DTG[7:5]=0xx = DT=DTG[7:0]x tdtg with tdtg=tDTS DTG[7:5]=10x = DT=(64+DTG[5:0])xtdtg with Tdtg=2xtDTS DTG[7:5]=110 = DT=(32+DTG[4:0])xtdtg with Tdtg=8xtDTS DTG[7:5]=111 = DT=(32+DTG[4:0])xtdtg with Tdtg=16xtDTS Example if TDTS=125ns (8MHz), dead-time possible values are: 0 to 15875 ns by 125 ns steps, 16 s to 31750 ns by 250 ns steps, 32 s to 63 s by 1 s steps, 64 s to 126 s by 2 s steps Note: This bit-field can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
$00000300 constant TIM16_TIM16_BDTR_LOCK                            \ Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIMx_BDTR register has been written, their content is frozen until the next reset.
$00000400 constant TIM16_TIM16_BDTR_OSSI                            \ Off-state selection for Idle mode This bit is used when MOE=0 on channels configured as outputs. See tim_oc1/tim_oc1n enable description for more details (capture/compare enable register (TIMx_CCER)(x = 16 to 17) on page 2011). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00000800 constant TIM16_TIM16_BDTR_OSSR                            \ Off-state selection for Run mode This bit is used when MOE=1 on channels that have a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See tim_oc1/tim_oc1n enable description for more details (capture/compare enable register (TIMx_CCER)(x = 16 to 17) on page 2011). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00001000 constant TIM16_TIM16_BDTR_BKE                             \ Break enable 1; Break inputs (tim_brk and tim_sys_brk event) enabled Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00002000 constant TIM16_TIM16_BDTR_BKP                             \ Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00004000 constant TIM16_TIM16_BDTR_AOE                             \ Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00008000 constant TIM16_TIM16_BDTR_MOE                             \ Main output enable This bit is cleared asynchronously by hardware as soon as the tim_brk input is active. It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. See tim_oc1/tim_oc1n enable description for more details (capture/compare enable register (TIMx_CCER)(x = 16 to 17) on page 2011).
$000f0000 constant TIM16_TIM16_BDTR_BKF                             \ Break filter This bit-field defines the frequency used to sample tim_brk input and the length of the digital filter applied to tim_brk. The digital filter is made of an event counter in which N events are needed to validate a transition on the output: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$04000000 constant TIM16_TIM16_BDTR_BKDSRM                          \ Break Disarm This bit is cleared by hardware when no break source is active. The BKDSRM bit must be set by software to release the bidirectional output control (open-drain output in Hi-Z state) and then be polled it until it is reset by hardware, indicating that the fault condition has disappeared. Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$10000000 constant TIM16_TIM16_BDTR_BKBID                           \ Break Bidirectional In the bidirectional mode (BKBID bit set to 1), the break input is configured both in input mode and in open drain output mode. Any active break event asserts a low logic level on the Break input to indicate an internal break event to external devices. Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.


\
\ @brief TIM16 timer deadtime register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000000ff constant TIM16_TIM16_DTR2_DTGF                            \ Dead-time falling edge generator setup This bit-field defines the duration of the dead-time inserted between the complementary outputs, on the falling edge. DTGF[7:5]=0xx = DTF=DTGF[7:0]x tdtg with tdtg=tDTS. DTGF[7:5]=10x = DTF=(64+DTGF[5:0])xtdtg with Tdtg=2xtDTS. DTGF[7:5]=110 = DTF=(32+DTGF[4:0])xtdtg with Tdtg=8xtDTS. DTGF[7:5]=111 = DTF=(32+DTGF[4:0])xtdtg with Tdtg=16xtDTS. Example if TDTS=125ns (8MHz), dead-time possible values are: 0 to 15875 ns by 125 ns steps, 16 us to 31750 ns by 250 ns steps, 32 us to 63us by 1 us steps, 64 us to 126 us by 2 us steps Note: This bit-field can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
$00010000 constant TIM16_TIM16_DTR2_DTAE                            \ Deadtime asymmetric enable Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
$00020000 constant TIM16_TIM16_DTR2_DTPE                            \ Deadtime preload enable Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM16 input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM16_TIM16_TISEL_TI1SEL                         \ selects tim_ti1_in[0..15] input ... Refer to for interconnects list.


\
\ @brief TIM16 alternate function register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM16_TIM16_AF1_BKINE                            \ TIMx_BKIN input enable This bit enables the TIMx_BKIN alternate function input for the timer's tim_brk input. TIMx_BKIN input is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000002 constant TIM16_TIM16_AF1_BKCMP1E                          \ tim_brk_cmp1 enable This bit enables the tim_brk_cmp1 for the timer's tim_brk input. tim_brk_cmp1 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000004 constant TIM16_TIM16_AF1_BKCMP2E                          \ tim_brk_cmp2 enable This bit enables the tim_brk_cmp2 for the timer's tim_brk input. tim_brk_cmp2 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000008 constant TIM16_TIM16_AF1_BKCMP3E                          \ tim_brk_cmp3 enable This bit enables the tim_brk_cmp3 for the timer's tim_brk input. tim_brk_cmp3 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000010 constant TIM16_TIM16_AF1_BKCMP4E                          \ tim_brk_cmp4 enable This bit enables the tim_brk_cmp4 for the timer's tim_brk input. tim_brk_cmp4 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000020 constant TIM16_TIM16_AF1_BKCMP5E                          \ tim_brk_cmp5 enable This bit enables the tim_brk_cmp5 for the timer's tim_brk input. tim_brk_cmp5 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000040 constant TIM16_TIM16_AF1_BKCMP6E                          \ tim_brk_cmp6 enable This bit enables the tim_brk_cmp6 for the timer's tim_brk input. tim_brk_cmp6 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000080 constant TIM16_TIM16_AF1_BKCMP7E                          \ tim_brk_cmp7 enable This bit enables the tim_brk_cmp7 for the timer's tim_brk input. tim_brk_cmp7 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000100 constant TIM16_TIM16_AF1_BKCMP8E                          \ tim_brk_cmp8 enable This bit enables the tim_brk_cmp8 for the timer's tim_brk input. mdf_brkx output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000200 constant TIM16_TIM16_AF1_BKINP                            \ TIMx_BKIN input polarity This bit selects the TIMx_BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000400 constant TIM16_TIM16_AF1_BKCMP1P                          \ tim_brk_cmp1 input polarity This bit selects the tim_brk_cmp1 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000800 constant TIM16_TIM16_AF1_BKCMP2P                          \ tim_brk_cmp2 input polarity This bit selects the tim_brk_cmp2 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00001000 constant TIM16_TIM16_AF1_BKCMP3P                          \ tim_brk_cmp3 input polarity This bit selects the tim_brk_cmp3 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00002000 constant TIM16_TIM16_AF1_BKCMP4P                          \ tim_brk_cmp4 input polarity This bit selects the tim_brk_cmp4 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM16 alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00070000 constant TIM16_TIM16_AF2_OCRSEL                           \ tim_ocref_clr source selection These bits select the tim_ocref_clr input source. Refer to for product specific implementation. Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM16 DMA control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant TIM16_TIM16_DCR_DBA                              \ DMA base address This 5-bit field defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ... Example: Let us consider the following transfer: DBL = 7 transfers and DBA = TIMx_CR1. In this case the transfer is done to/from 7 registers starting from the TIMx_CR1 address.
$00001f00 constant TIM16_TIM16_DCR_DBL                              \ DMA burst length This 5-bit field defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address), i.e. the number of transfers. Transfers can be in half-words or in bytes (see example below). ...
$000f0000 constant TIM16_TIM16_DCR_DBSS                             \ DMA burst source selection This bitfield defines the interrupt source that triggers the DMA burst transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). Other: reserved


\
\ @brief TIM16/TIM17 DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant TIM16_TIM16_DMAR_DMAB                            \ DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).


\
\ @brief TIM16 address block description
\
$40014400 constant TIM16_TIM16_CR1  \ offset: 0x00 : TIM16 control register 1
$40014404 constant TIM16_TIM16_CR2  \ offset: 0x04 : TIM16 control register 2
$4001440c constant TIM16_TIM16_DIER  \ offset: 0x0C : TIM16 DMA/interrupt enable register
$40014410 constant TIM16_TIM16_SR  \ offset: 0x10 : TIM16 status register
$40014414 constant TIM16_TIM16_EGR  \ offset: 0x14 : TIM16 event generation register
$40014418 constant TIM16_TIM16_CCMR1_INPUT  \ offset: 0x18 : TIM16 capture/compare mode register 1 [alternate]
$40014418 constant TIM16_TIM16_CCMR1_OUTPUT  \ offset: 0x18 : TIM16 capture/compare mode register 1 [alternate]
$40014420 constant TIM16_TIM16_CCER  \ offset: 0x20 : TIM16 capture/compare enable register
$40014424 constant TIM16_TIM16_CNT  \ offset: 0x24 : TIM16 counter
$40014428 constant TIM16_TIM16_PSC  \ offset: 0x28 : TIM16 prescaler
$4001442c constant TIM16_TIM16_ARR  \ offset: 0x2C : TIM16 auto-reload register
$40014430 constant TIM16_TIM16_RCR  \ offset: 0x30 : TIM16 repetition counter register
$40014434 constant TIM16_TIM16_CCR1  \ offset: 0x34 : TIM16 capture/compare register 1
$40014444 constant TIM16_TIM16_BDTR  \ offset: 0x44 : TIM16 break and dead-time register
$40014454 constant TIM16_TIM16_DTR2  \ offset: 0x54 : TIM16 timer deadtime register 2
$4001445c constant TIM16_TIM16_TISEL  \ offset: 0x5C : TIM16 input selection register
$40014460 constant TIM16_TIM16_AF1  \ offset: 0x60 : TIM16 alternate function register 1
$40014464 constant TIM16_TIM16_AF2  \ offset: 0x64 : TIM16 alternate function register 2
$400147dc constant TIM16_TIM16_DCR  \ offset: 0x3DC : TIM16 DMA control register
$400147e0 constant TIM16_TIM16_DMAR  \ offset: 0x3E0 : TIM16/TIM17 DMA address for full transfer

