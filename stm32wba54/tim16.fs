\
\ @file tim16.fs
\ @brief TIM16 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM16_DEF

  [ifdef] TIM16_TIM_CR1_DEF
    \
    \ @brief TIM control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CEN                      \ [0x00] Counter enable Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
    $01 constant TIM16_UDIS                     \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM16_URS                      \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM16_OPM                      \ [0x03] One pulse mode
    $07 constant TIM16_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM16_CKD                      \ [0x08 : 2] Clock division This bit-field indicates the division ratio between the timer clock (tim_ker_ck) frequency and the dead-time and sampling clock (tsubDTS/sub)used by the dead-time generators and the digital filters (tim_tix),
    $0b constant TIM16_UIFREMAP                 \ [0x0b] UIF status bit remapping
    $0c constant TIM16_DITHEN                   \ [0x0c] Dithering enable Note: The DITHEN bit can only be modified when CEN bit is reset.
  [then]


  [ifdef] TIM16_TIM_CR2_DEF
    \
    \ @brief TIM control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CCPC                     \ [0x00] Capture/compare preloaded control Note: This bit acts only on channels that have a complementary output.
    $02 constant TIM16_CCUS                     \ [0x02] Capture/compare control update selection Note: This bit acts only on channels that have a complementary output.
    $03 constant TIM16_CCDS                     \ [0x03] Capture/compare DMA selection
    $08 constant TIM16_OIS1                     \ [0x08] Output Idle state 1 (tim_oc1 output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BKR register).
    $09 constant TIM16_OIS1N                    \ [0x09] Output Idle state 1 (tim_oc1n output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BKR register).
  [then]


  [ifdef] TIM16_TIM_DIER_DEF
    \
    \ @brief TIM DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM16_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $05 constant TIM16_COMIE                    \ [0x05] COM interrupt enable
    $07 constant TIM16_BIE                      \ [0x07] Break interrupt enable
    $08 constant TIM16_UDE                      \ [0x08] Update DMA request enable
    $09 constant TIM16_CC1DE                    \ [0x09] Capture/Compare 1 DMA request enable
  [then]


  [ifdef] TIM16_TIM_SR_DEF
    \
    \ @brief TIM status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_UIF                      \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register.
    $01 constant TIM16_CC1IF                    \ [0x01] Capture/Compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $05 constant TIM16_COMIF                    \ [0x05] COM interrupt flag This flag is set by hardware on a COM event (once the capture compare control bits CCxE, CCxNE, OCxM have been updated). It is cleared by software.
    $07 constant TIM16_BIF                      \ [0x07] Break interrupt flag This flag is set by hardware as soon as the tim_brk input goes active. It can be cleared by software if the break input is not active.
    $09 constant TIM16_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to '0'.
  [then]


  [ifdef] TIM16_TIM_EGR_DEF
    \
    \ @brief TIM event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_UG                       \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM16_CC1G                     \ [0x01] Capture/Compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $05 constant TIM16_COMG                     \ [0x05] Capture/Compare control update generation This bit can be set by software, it is automatically cleared by hardware. Note: This bit acts only on channels that have a complementary output.
    $07 constant TIM16_BG                       \ [0x07] Break generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM16_TIM_CCMR1_DEF
    \
    \ @brief TIM capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Others: Reserved Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIMx_CCER).
    $02 constant TIM16_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (tim_ic1). The prescaler is reset as soon as CC1E='0' (TIMx_CCER register).
    $04 constant TIM16_IC1F                     \ [0x04 : 4] Input capture 1 filter This bit-field defines the frequency used to sample tim_ti1 input and the length of the digital filter applied to tim_ti1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
  [then]


  [ifdef] TIM16_TIM_CCMR1_ALTERNATE1_DEF
    \
    \ @brief TIM capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Others: Reserved Note: CC1S bits are writable only when the channel is OFF (CC1E = '0' in TIMx_CCER).
    $02 constant TIM16_OC1FE                    \ [0x02] Output Compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM16_OC1PE                    \ [0x03] Output Compare 1 preload enable Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output).
    $04 constant TIM16_OC1M                     \ [0x04 : 3] OC1M[2:0]: Output Compare 1 mode These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 and tim_oc1n are derived. tim_oc1ref is active high whereas tim_oc1 and tim_oc1n active level depends on CC1P and CC1NP bits. Others: Reserved Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). Note: In PWM mode 1 or 2, the tim_oc1ref level changes only when the result of the comparison changes or when the output compare mode switches from 'frozen' mode to 'PWM' mode.
    $07 constant TIM16_OC1CE                    \ [0x07] Output Compare 1 clear enable
    $10 constant TIM16_OC1M_1                   \ [0x10] OC1M[3]
  [then]


  [ifdef] TIM16_TIM_CCER_DEF
    \
    \ @brief TIM capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CC1E                     \ [0x00] Capture/Compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to Table 305 for details.
    $01 constant TIM16_CC1P                     \ [0x01] Capture/Compare 1 output polarity When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register). Note: On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
    $02 constant TIM16_CC1NE                    \ [0x02] Capture/Compare 1 complementary output enable
    $03 constant TIM16_CC1NP                    \ [0x03] Capture/Compare 1 complementary output polarity CC1 channel configured as output: CC1 channel configured as input: This bit is used in conjunction with CC1P to define the polarity of tim_ti1fp1. Refer to the description of CC1P. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S='00' (the channel is configured in output). Note: On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NP active bit takes the new value from the preloaded bit only when a commutation event is generated.
  [then]


  [ifdef] TIM16_TIM_CNT_DEF
    \
    \ @brief TIM counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CNT                      \ [0x00 : 16] Counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register only holds the non-dithered part in CNT[15:0]. The fractional part is not available.
    $1f constant TIM16_UIFCPY                   \ [0x1f] UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in TIMx_CR1 is reset, bit 31 is reserved.
  [then]


  [ifdef] TIM16_TIM_PSC_DEF
    \
    \ @brief TIM prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_PSC                      \ [0x00 : 16] Prescaler value The counter clock frequency (tim_cnt_ck) is equal to fsubtim_psc_ck/sub / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in 'reset mode').
  [then]


  [ifdef] TIM16_TIM_ARR_DEF
    \
    \ @brief TIM auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM16_ARR                      \ [0x00 : 20] Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the Section 30.3.3: Time-base unit on page 1362 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value in ARR[15:0]. The ARR[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[19:4]. The ARR[3:0] bitfield contains the dithered part.
  [then]


  [ifdef] TIM16_TIM_RCR_DEF
    \
    \ @brief TIM repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_REP                      \ [0x00 : 8] Repetition counter reload value This bitfield defines the update rate of the compare registers (i.e. periodic transfers from preload to active registers) when preload registers are enable. It also defines the update interrupt generation rate, if this interrupt is enable. When the repetition down-counter reaches zero, an update event is generated and it restarts counting from REP value. As the repetition counter is reloaded with REP value only at the repetition update event UEV, any write to the TIMx_RCR register is not taken in account until the next repetition update event. It means in PWM mode (REP+1) corresponds to the number of PWM periods in edge-aligned mode: the number of PWM periods in edge-aligned mode the number of half PWM period in center-aligned mode
  [then]


  [ifdef] TIM16_TIM_CCR1_DEF
    \
    \ @brief TIM capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CCR1                     \ [0x00 : 20] Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc1 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR1[19:4]. The CCR1[3:0] bitfield contains the dithered part. If channel CC1 is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (tim_ic1). Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR1[19:4]. The CCR1[3:0] bits are reset.
  [then]


  [ifdef] TIM16_TIM_BDTR_DEF
    \
    \ @brief TIM break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_DTG                      \ [0x00 : 8] Dead-time generator setup This bit-field defines the duration of the dead-time inserted between the complementary outputs. DT correspond to this duration. DTG[7:5]=0xx = DT=DTG[7:0]x tsubdtg/sub with tsubdtg/sub=tsubDTS/sub DTG[7:5]=10x = DT=(64+DTG[5:0])xtsubdtg/sub with Tsubdtg/sub=2xtsubDTS/sub DTG[7:5]=110 = DT=(32+DTG[4:0])xtsubdtg/sub with Tsubdtg/sub=8xtsubDTS/sub DTG[7:5]=111 = DT=(32+DTG[4:0])xtsubdtg/sub with Tsubdtg/sub=16xtsubDTS/sub Example if TsubDTS/sub=125ns (8MHz), dead-time possible values are: 0 to 15875 ns by 125 ns steps, 16 s to 31750 ns by 250 ns steps, 32 s to 63 s by 1 s steps, 64 s to 126 s by 2 s steps Note: This bit-field can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
    $08 constant TIM16_LOCK                     \ [0x08 : 2] Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIMx_BDTR register has been written, their content is frozen until the next reset.
    $0a constant TIM16_OSSI                     \ [0x0a] Off-state selection for Idle mode This bit is used when MOE=0 on channels configured as outputs. See tim_oc1/tim_oc1n enable description for more details (Section 30.6.8: TIMx capture/compare enable register (TIMx_CCER)(x = 16 to 17) on page 1404). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
    $0b constant TIM16_OSSR                     \ [0x0b] Off-state selection for Run mode This bit is used when MOE=1 on channels that have a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See tim_oc1/tim_oc1n enable description for more details (Section 30.6.8: TIMx capture/compare enable register (TIMx_CCER)(x = 16 to 17) on page 1404). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
    $0c constant TIM16_BKE                      \ [0x0c] Break enable 1; Break inputs (tim_brk and tim_sys_brk event) enabled Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0d constant TIM16_BKP                      \ [0x0d] Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0e constant TIM16_AOE                      \ [0x0e] Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0f constant TIM16_MOE                      \ [0x0f] Main output enable This bit is cleared asynchronously by hardware as soon as the tim_brk input is active. It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. See tim_oc1/tim_oc1n enable description for more details (Section 30.6.8: TIMx capture/compare enable register (TIMx_CCER)(x = 16 to 17) on page 1404).
    $10 constant TIM16_BKF                      \ [0x10 : 4] Break filter This bit-field defines the frequency used to sample tim_brk input and the length of the digital filter applied to tim_brk. The digital filter is made of an event counter in which N events are needed to validate a transition on the output: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $1a constant TIM16_BKDSRM                   \ [0x1a] Break Disarm This bit is cleared by hardware when no break source is active. The BKDSRM bit must be set by software to release the bidirectional output control (open-drain output in Hi-Z state) and then be polled it until it is reset by hardware, indicating that the fault condition has disappeared. Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $1c constant TIM16_BKBID                    \ [0x1c] Break Bidirectional In the bidirectional mode (BKBID bit set to 1), the break input is configured both in input mode and in open drain output mode. Any active break event asserts a low logic level on the Break input to indicate an internal break event to external devices. Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
  [then]


  [ifdef] TIM16_TIM_DTR2_DEF
    \
    \ @brief TIM timer deadtime register 2
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_DTGF                     \ [0x00 : 8] Dead-time falling edge generator setup This bit-field defines the duration of the dead-time inserted between the complementary outputs, on the falling edge. DTGF[7:5]=0xx = DTF=DTGF[7:0]x tsubdtg/sub with tsubdtg/sub=tsubDTS/sub. DTGF[7:5]=10x = DTF=(64+DTGF[5:0])xtsubdtg/sub with Tsubdtg/sub=2xtsubDTS/sub. DTGF[7:5]=110 = DTF=(32+DTGF[4:0])xtsubdtg/sub with Tsubdtg/sub=8xtsubDTS/sub. DTGF[7:5]=111 = DTF=(32+DTGF[4:0])xtsubdtg/sub with Tsubdtg/sub=16xtsubDTS/sub. Example if TsubDTS/sub=125ns (8MHz), dead-time possible values are: 0 to 15875 ns by 125 ns steps, 16 us to 31750 ns by 250 ns steps, 32 us to 63us by 1 us steps, 64 us to 126 us by 2 us steps Note: This bit-field can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
    $10 constant TIM16_DTAE                     \ [0x10] Deadtime asymmetric enable Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
    $11 constant TIM16_DTPE                     \ [0x11] Deadtime preload enable Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM16_TIM_TISEL_DEF
    \
    \ @brief TIM input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_TI1SEL                   \ [0x00 : 4] selects tim_ti1_in[15:0] input ... Refer to Section 30.3.2: TIM16/TIM17 pins and internal signals for interconnects list.
  [then]


  [ifdef] TIM16_TIM_AF1_DEF
    \
    \ @brief TIM alternate function register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM16_BKINE                    \ [0x00] TIMx_BKIN input enable This bit enables the TIMx_BKIN alternate function input for the timer's tim_brk input. TIMx_BKIN input is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $01 constant TIM16_BKCMP1E                  \ [0x01] tim_brk_cmp1 enable This bit enables the tim_brk_cmp1 for the timer's tim_brk input. tim_brk_cmp1 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $02 constant TIM16_BKCMP2E                  \ [0x02] tim_brk_cmp2 enable This bit enables the tim_brk_cmp2 for the timer's tim_brk input. tim_brk_cmp2 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $03 constant TIM16_BKCMP3E                  \ [0x03] tim_brk_cmp3 enable This bit enables the tim_brk_cmp3 for the timer's tim_brk input. tim_brk_cmp3 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $04 constant TIM16_BKCMP4E                  \ [0x04] tim_brk_cmp4 enable This bit enables the tim_brk_cmp4 for the timer's tim_brk input. tim_brk_cmp4 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $05 constant TIM16_BKCMP5E                  \ [0x05] tim_brk_cmp5 enable This bit enables the tim_brk_cmp5 for the timer's tim_brk input. tim_brk_cmp5 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $06 constant TIM16_BKCMP6E                  \ [0x06] tim_brk_cmp6 enable This bit enables the tim_brk_cmp6 for the timer's tim_brk input. tim_brk_cmp6 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $07 constant TIM16_BKCMP7E                  \ [0x07] tim_brk_cmp7 enable This bit enables the tim_brk_cmp7 for the timer's tim_brk input. tim_brk_cmp7 output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $08 constant TIM16_BKCMP8E                  \ [0x08] tim_brk_cmp8 enable This bit enables the tim_brk_cmp8 for the timer's tim_brk input. mdf_brkx output is 'ORed' with the other tim_brk sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $09 constant TIM16_BKINP                    \ [0x09] TIMx_BKIN input polarity This bit selects the TIMx_BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0a constant TIM16_BKCMP1P                  \ [0x0a] tim_brk_cmp1 input polarity This bit selects the tim_brk_cmp1 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0b constant TIM16_BKCMP2P                  \ [0x0b] tim_brk_cmp2 input polarity This bit selects the tim_brk_cmp2 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0c constant TIM16_BKCMP3P                  \ [0x0c] tim_brk_cmp3 input polarity This bit selects the tim_brk_cmp3 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0d constant TIM16_BKCMP4P                  \ [0x0d] tim_brk_cmp4 input polarity This bit selects the tim_brk_cmp4 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM16_TIM_AF2_DEF
    \
    \ @brief TIM alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $10 constant TIM16_OCRSEL                   \ [0x10 : 3] tim_ocref_clr source selection These bits select the tim_ocref_clr input source. Refer to Section 30.3.2: TIM16/TIM17 pins and internal signals for product specific implementation. Note: These bits can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM16_TIM_OR1_DEF
    \
    \ @brief TIM option register 1
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $01 constant TIM16_HSE32EN                  \ [0x01] HSE Divided by 32 enable This bit enables the HSE divider by 32 for the tim_ti1_in3. See Table 296: Interconnect to the tim_ti1 input multiplexer for details.
  [then]


  [ifdef] TIM16_TIM_DCR_DEF
    \
    \ @brief TIM DMA control register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_DBA                      \ [0x00 : 5] DMA base address This 5-bit field defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ... Example: Let us consider the following transfer: DBL = 7 transfers and DBA = TIMx_CR1. In this case the transfer is done to/from 7 registers starting from the TIMx_CR1 address.
    $08 constant TIM16_DBL                      \ [0x08 : 5] DMA burst length This 5-bit field defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address), i.e. the number of transfers. Transfers can be in half-words or in bytes (see example below). ...
    $10 constant TIM16_DBSS                     \ [0x10 : 4] DMA burst source selection This bitfield defines the interrupt source that triggers the DMA burst transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). Other: reserved
  [then]


  [ifdef] TIM16_TIM_DMAR_DEF
    \
    \ @brief TIM16/TIM17 DMA address for full transfer
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_DMAB                     \ [0x00 : 32] DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).
  [then]

  \
  \ @brief TIM16 address block description
  \
  $00 constant TIM16_TIM_CR1            \ TIM control register 1
  $04 constant TIM16_TIM_CR2            \ TIM control register 2
  $0C constant TIM16_TIM_DIER           \ TIM DMA/interrupt enable register
  $10 constant TIM16_TIM_SR             \ TIM status register
  $14 constant TIM16_TIM_EGR            \ TIM event generation register
  $18 constant TIM16_TIM_CCMR1          \ TIM capture/compare mode register 1 [alternate]
  $18 constant TIM16_TIM_CCMR1_ALTERNATE1    \ TIM capture/compare mode register 1 [alternate]
  $20 constant TIM16_TIM_CCER           \ TIM capture/compare enable register
  $24 constant TIM16_TIM_CNT            \ TIM counter
  $28 constant TIM16_TIM_PSC            \ TIM prescaler
  $2C constant TIM16_TIM_ARR            \ TIM auto-reload register
  $30 constant TIM16_TIM_RCR            \ TIM repetition counter register
  $34 constant TIM16_TIM_CCR1           \ TIM capture/compare register 1
  $44 constant TIM16_TIM_BDTR           \ TIM break and dead-time register
  $54 constant TIM16_TIM_DTR2           \ TIM timer deadtime register 2
  $5C constant TIM16_TIM_TISEL          \ TIM input selection register
  $60 constant TIM16_TIM_AF1            \ TIM alternate function register 1
  $64 constant TIM16_TIM_AF2            \ TIM alternate function register 2
  $68 constant TIM16_TIM_OR1            \ TIM option register 1
  $3DC constant TIM16_TIM_DCR           \ TIM DMA control register
  $3E0 constant TIM16_TIM_DMAR          \ TIM16/TIM17 DMA address for full transfer

: TIM16_DEF ; [then]
