\
\ @file tim14.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM14 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_CR1_CEN                              \ Counter enable Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
$00000002 constant TIM14_TIM14_CR1_UDIS                             \ Update disable This bit is set and cleared by software to enable/disable update interrupt (UEV) event generation. Counter overflow Setting the UG bit. Buffered registers are then loaded with their preload values.
$00000004 constant TIM14_TIM14_CR1_URS                              \ Update request source This bit is set and cleared by software to select the update interrupt (UEV) sources. Counter overflow Setting the UG bit
$00000008 constant TIM14_TIM14_CR1_OPM                              \ One-pulse mode
$00000080 constant TIM14_TIM14_CR1_ARPE                             \ Auto-reload preload enable
$00000300 constant TIM14_TIM14_CR1_CKD                              \ Clock division This bit-field indicates the division ratio between the timer clock (tim_ker_ck) frequency and sampling clock used by the digital filters (tim_tix),
$00000800 constant TIM14_TIM14_CR1_UIFREMAP                         \ UIF status bit remapping
$00001000 constant TIM14_TIM14_CR1_DITHEN                           \ Dithering enable Note: The DITHEN bit can only be modified when CEN bit is reset.


\
\ @brief TIM14 Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_DIER_UIE                             \ Update interrupt enable
$00000002 constant TIM14_TIM14_DIER_CC1IE                           \ Capture/Compare 1 interrupt enable


\
\ @brief TIM14 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_SR_UIF                               \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow and if UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register.
$00000002 constant TIM14_TIM14_SR_CC1IF                             \ Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when he content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on tim_ic1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
$00000200 constant TIM14_TIM14_SR_CC1OF                             \ Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to 0.


\
\ @brief TIM14 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_EGR_UG                               \ Update generation This bit can be set by software, it is automatically cleared by hardware.
$00000002 constant TIM14_TIM14_EGR_CC1G                             \ Capture/compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.


\
\ @brief TIM14 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM14_TIM14_CCMR1_INPUT_CC1S                     \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
$0000000c constant TIM14_TIM14_CCMR1_INPUT_IC1PSC                   \ Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (tim_ic1). The prescaler is reset as soon as CC1E=0 (TIMx_CCER register).
$000000f0 constant TIM14_TIM14_CCMR1_INPUT_IC1F                     \ Input capture 1 filter This bit-field defines the frequency used to sample tim_ti1 input and the length of the digital filter applied to tim_ti1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:


\
\ @brief TIM14 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM14_TIM14_CCMR1_OUTPUT_CC1S                    \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
$00000004 constant TIM14_TIM14_CCMR1_OUTPUT_OC1FE                   \ Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
$00000008 constant TIM14_TIM14_CCMR1_OUTPUT_OC1PE                   \ Output compare 1 preload enable
$00000070 constant TIM14_TIM14_CCMR1_OUTPUT_OC1M                    \ OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3]) These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 is derived. tim_oc1ref is active high whereas tim_oc1 active level depends on CC1P bit. Others: Reserved Note: In PWM mode 1 or 2, the OCREF level changes when the result of the comparison changes or when the output compare mode switches from frozen to PWM mode.
$00010000 constant TIM14_TIM14_CCMR1_OUTPUT_OC1M_1                  \ OC1M[3]


\
\ @brief TIM14 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_CCER_CC1E                            \ Capture/Compare 1 output enable.
$00000002 constant TIM14_TIM14_CCER_CC1P                            \ Capture/Compare 1 output Polarity. When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of tim_ti1fp1 for capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to tim_ti1fp1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to tim_ti1fp1 falling edge (capture or trigger operations in reset, external clock or trigger mode), tim_ti1fp1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both tim_ti1fp1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), tim_ti1fp1 not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: This configuration is reserved, it must not be used.
$00000008 constant TIM14_TIM14_CCER_CC1NP                           \ Capture/Compare 1 complementary output Polarity. CC1 channel configured as output: CC1NP must be kept cleared. CC1 channel configured as input: CC1NP bit is used in conjunction with CC1P to define tim_ti1fp1 polarity (refer to CC1P description).


\
\ @brief TIM14 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_TIM14_CNT_CNT                              \ Counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register only holds the non-dithered part in CNT[15:0]. The fractional part is not available.
$80000000 constant TIM14_TIM14_CNT_UIFCPY                           \ UIF Copy This bit is a read-only copy of the UIF bit in the TIMx_ISR register.


\
\ @brief TIM14 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_TIM14_PSC_PSC                              \ Prescaler value The counter clock frequency tim_cnt_ck is equal to f<sub>tim_psc_ck</sub> / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event. (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in reset mode).


\
\ @brief TIM14 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM14_TIM14_ARR_ARR                              \ Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the Section 67.4.3: Time-base unit on page 3951 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value in ARR[15:0]. The ARR[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[19:4]. The ARR[3:0] bitfield contains the dithered part.


\
\ @brief TIM14 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM14_TIM14_CCR1_CCR1                            \ Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc1 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR1[19:4]. The CCR1[3:0] bitfield contains the dithered part. If channel CC1 is configured as input: CR1 is the counter value transferred by the last input capture 1 event (tim_ic1). The TIMx_CCR1 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR1[19:4]. The CCR1[3:0] bits are reset.


\
\ @brief TIM14 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM14_TIM14_TISEL_TI1SEL                         \ selects tim_ti1_in[15:0] input ... Refer to Table 656: Interconnect to the tim_ti1 input multiplexer for interconnects list.


\
\ @brief General-purpose timers
\
$40002000 constant TIM14_TIM14_CR1  \ offset: 0x00 : TIM14 control register 1
$4000200c constant TIM14_TIM14_DIER  \ offset: 0x0C : TIM14 Interrupt enable register
$40002010 constant TIM14_TIM14_SR  \ offset: 0x10 : TIM14 status register
$40002014 constant TIM14_TIM14_EGR  \ offset: 0x14 : TIM14 event generation register
$40002018 constant TIM14_TIM14_CCMR1_INPUT  \ offset: 0x18 : TIM14 capture/compare mode register 1
$40002018 constant TIM14_TIM14_CCMR1_OUTPUT  \ offset: 0x18 : TIM14 capture/compare mode register 1
$40002020 constant TIM14_TIM14_CCER  \ offset: 0x20 : TIM14 capture/compare enable register
$40002024 constant TIM14_TIM14_CNT  \ offset: 0x24 : TIM14 counter
$40002028 constant TIM14_TIM14_PSC  \ offset: 0x28 : TIM14 prescaler
$4000202c constant TIM14_TIM14_ARR  \ offset: 0x2C : TIM14 auto-reload register
$40002034 constant TIM14_TIM14_CCR1  \ offset: 0x34 : TIM14 capture/compare register 1
$4000205c constant TIM14_TIM14_TISEL  \ offset: 0x5C : TIM14 timer input selection register

