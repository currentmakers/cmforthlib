\
\ @file tim9.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM9_DEF

  [ifdef] TIM9_TIM9_CR1_DEF
    \
    \ @brief TIM9 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CEN                       \ [0x00] Counter enable CEN is cleared automatically in one-pulse mode, when an update event occurs. Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
    $01 constant TIM9_UDIS                      \ [0x01] Update disable This bit is set and cleared by software to enable/disable update event (UEV) generation. Counter overflow Setting the UG bit Buffered registers are then loaded with their preload values.
    $02 constant TIM9_URS                       \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM9_OPM                       \ [0x03] One-pulse mode
    $07 constant TIM9_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM9_CKD                       \ [0x08 : 2] Clock division This bit-field indicates the division ratio between the timer clock (tim_ker_ck) frequency and sampling clock used by the digital filters (tim_tix),
    $0b constant TIM9_UIFREMAP                  \ [0x0b] UIF status bit remapping
    $0c constant TIM9_DITHEN                    \ [0x0c] Dithering enable Note: The DITHEN bit can only be modified when CEN bit is reset.
  [then]


  [ifdef] TIM9_TIM9_CR2_DEF
    \
    \ @brief TIM12 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM9_MMS                       \ [0x04 : 3] Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (tim_trgo). The combination is as follows:
    $07 constant TIM9_TI1S                      \ [0x07] tim_ti1 selection
  [then]


  [ifdef] TIM9_TIM9_SMCR_DEF
    \
    \ @brief TIM9 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_SMS                       \ [0x00 : 3] SMS[0]: Slave mode selection When external signals are selected the active edge of the trigger signal (tim_trgi) is linked to the polarity selected on the external input (see Input Control register and Control Register description. Other codes: reserved. Note: The gated mode (including gated + reset mode) must not be used if tim_ti1f_ed is selected as the trigger input (TS=00100). Indeed, tim_ti1f_ed outputs 1 pulse for each transition on tim_ti1f, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC,...) receiving the tim_trgo signals must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
    $04 constant TIM9_TS                        \ [0x04 : 3] TS[0]: Trigger selection This TS[4:0] bitfield selects the trigger input to be used to synchronize the counter. Others: Reserved See Table 658: TIMx internal trigger connection for more details on the meaning of tim_itrx for each timer. Note: These bits must be changed only when they are not used (for example when SMS=000) to avoid wrong edge detections at the transition.
    $07 constant TIM9_MSM                       \ [0x07] Master/Slave mode
    $10 constant TIM9_SMS_1                     \ [0x10] SMS[3]
    $14 constant TIM9_TS_1                      \ [0x14 : 2] TS[4:3]
  [then]


  [ifdef] TIM9_TIM9_DIER_DEF
    \
    \ @brief TIM9 Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM9_CC1IE                     \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM9_CC2IE                     \ [0x02] Capture/Compare 2 interrupt enable
    $06 constant TIM9_TIE                       \ [0x06] Trigger interrupt enable
  [then]


  [ifdef] TIM9_TIM9_SR_DEF
    \
    \ @brief TIM9 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_UIF                       \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow and if UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer toSection 67.7.3: TIMx slave mode control register (TIMx_SMCR)(x = 9, 12) ), if URS=0 and UDIS=0 in the TIMx_CR1 register.
    $01 constant TIM9_CC1IF                     \ [0x01] Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when he content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on tim_ic1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $02 constant TIM9_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag refer to CC1IF description
    $06 constant TIM9_TIF                       \ [0x06] Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on tim_trgi input when the slave mode controller is enabled in all modes but gated mode. It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
    $09 constant TIM9_CC1OF                     \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to 0.
    $0a constant TIM9_CC2OF                     \ [0x0a] Capture/compare 2 overcapture flag refer to CC1OF description
  [then]


  [ifdef] TIM9_TIM9_EGR_DEF
    \
    \ @brief TIM9 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_UG                        \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM9_CC1G                      \ [0x01] Capture/compare 1 generation This bit is set by software to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: the CC1IF flag is set, the corresponding interrupt is sent if enabled. If channel CC1 is configured as input: The current counter value is captured in the TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $02 constant TIM9_CC2G                      \ [0x02] Capture/compare 2 generation refer to CC1G description
    $06 constant TIM9_TG                        \ [0x06] Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM9_TIM9_CCMR1_INPUT_DEF
    \
    \ @brief TIM9 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection This bitfield defines the direction of the channel (input/output) as well as the used input. Note: The CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM9_IC1PSC                    \ [0x02 : 2] Input capture 1 prescaler This bitfield defines the ratio of the prescaler acting on the CC1 input (tim_ic1). The prescaler is reset as soon as CC1E=0 (TIMx_CCER register).
    $04 constant TIM9_IC1F                      \ [0x04 : 4] Input capture 1 filter This bitfield defines the frequency used to sample the tim_ti1 input and the length of the digital filter applied to tim_ti1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $08 constant TIM9_CC2S                      \ [0x08 : 2] Capture/compare 2 selection This bitfield defines the direction of the channel (input/output) as well as the used input. Note: The CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM9_IC2PSC                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM9_IC2F                      \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM9_TIM9_CCMR1_OUTPUT_DEF
    \
    \ @brief TIM9 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection This bitfield defines the direction of the channel (input/output) as well as the used input. Note: The CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM9_OC1FE                     \ [0x02] Output compare 1 fast enable This bit is used to accelerate the effect of an event on the trigger in input on the CC output.
    $03 constant TIM9_OC1PE                     \ [0x03] Output compare 1 preload enable
    $04 constant TIM9_OC1M                      \ [0x04 : 3] OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3]) These bits define the behavior of the output reference signal tim_oc1ref from which tim_oc1 is derived. tim_oc1ref is active high whereas the active level of tim_oc1 depends on the CC1P. Note: In PWM mode 1 or 2, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from frozen mode to PWM mode.
    $08 constant TIM9_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection This bitfield defines the direction of the channel (input/output) as well as the used input. Note: The CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM9_OC2FE                     \ [0x0a] Output compare 2 fast enable
    $0b constant TIM9_OC2PE                     \ [0x0b] Output compare 2 preload enable
    $0c constant TIM9_OC2M                      \ [0x0c : 3] OC2M[2:0]: Output compare 2 mode Refer to OC1M[3:0] for bit description.
    $10 constant TIM9_OC1M_1                    \ [0x10] OC1M[3]
    $18 constant TIM9_OC2M_1                    \ [0x18] OC2M[3]
  [then]


  [ifdef] TIM9_TIM9_CCER_DEF
    \
    \ @brief TIM9 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CC1E                      \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM9_CC1P                      \ [0x01] Capture/Compare 1 output Polarity. When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of tim_ti1fp1 and tim_ti2fp1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to tim_tixfp1 rising edge (capture or trigger operations in reset, external clock or trigger mode), tim_tixfp1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to tim_tixfp1 falling edge (capture or trigger operations in reset, external clock or trigger mode), tim_tixfp1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both tim_tixfp1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), tim_tixfp1 is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: This configuration is reserved, it must not be used.
    $03 constant TIM9_CC1NP                     \ [0x03] Capture/Compare 1 complementary output Polarity CC1 channel configured as output: CC1NP must be kept cleared CC1 channel configured as input: CC1NP is used in conjunction with CC1P to define tim_ti1fp1/tim_ti2fp1 polarity (refer to CC1P description).
    $04 constant TIM9_CC2E                      \ [0x04] Capture/Compare 2 output enable Refer to CC1E description
    $05 constant TIM9_CC2P                      \ [0x05] Capture/Compare 2 output Polarity Refer to CC1P description
    $07 constant TIM9_CC2NP                     \ [0x07] Capture/Compare 2 output Polarity Refer to CC1NP description
  [then]


  [ifdef] TIM9_TIM9_CNT_DEF
    \
    \ @brief TIM9 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CNT                       \ [0x00 : 16] Counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register only holds the non-dithered part in CNT[15:0]. The fractional part is not available.
    $1f constant TIM9_UIFCPY                    \ [0x1f] UIF Copy This bit is a read-only copy of the UIF bit in the TIMx_ISR register.
  [then]


  [ifdef] TIM9_TIM9_PSC_DEF
    \
    \ @brief TIM9 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_PSC                       \ [0x00 : 16] Prescaler value The counter clock frequency tim_cnt_ck is equal to f<sub>tim_psc_ck</sub> / (PSC[15:0] + 1). PSC contains the value to be loaded into the active prescaler register at each update event. (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in reset mode).
  [then]


  [ifdef] TIM9_TIM9_ARR_DEF
    \
    \ @brief TIM9 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM9_ARR                       \ [0x00 : 20] Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the Section 67.4.3: Time-base unit on page 3951 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value in ARR[15:0]. The ARR[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[19:4]. The ARR[3:0] bitfield contains the dithered part.
  [then]


  [ifdef] TIM9_TIM9_CCR1_DEF
    \
    \ @brief TIM9 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CCR1                      \ [0x00 : 20] Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on tim_oc1 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR1[19:4]. The CCR1[3:0] bitfield contains the dithered part. If channel CC1 is configured as input: CR1 is the counter value transferred by the last input capture 1 event (tim_ic1). The TIMx_CCR1 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR1[15:0]. The CCR1[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR1[19:4]. The CCR1[3:0] bits are reset.
  [then]


  [ifdef] TIM9_TIM9_CCR2_DEF
    \
    \ @brief TIM9 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CCR2                      \ [0x00 : 20] Capture/compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on tim_oc2 output. Non-dithering mode (DITHEN = 0) The register holds the compare value in CCR2[15:0]. The CCR2[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the integer part in CCR2[19:4]. The CCR2[3:0] bitfield contains the dithered part. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 1 event (tim_ic2). The TIMx_CCR2 register is read-only and cannot be programmed. Non-dithering mode (DITHEN = 0) The register holds the capture value in CCR2[15:0]. The CCR2[19:16] bits are reset. Dithering mode (DITHEN = 1) The register holds the capture in CCR2[19:4]. The CCR2[3:0] bits are reset.
  [then]


  [ifdef] TIM9_TIM9_TISEL_DEF
    \
    \ @brief TIM9 timer input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_TI1SEL                    \ [0x00 : 4] selects tim_ti1_in[15:0] input ... Refer to Table 656: Interconnect to the tim_ti1 input multiplexer for interconnects list.
    $08 constant TIM9_TI2SEL                    \ [0x08 : 4] selects tim_ti2_in[15:0] input ... Refer to Table 657: Interconnect to the tim_ti2 input multiplexer for interconnects list.
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM9_TIM9_CR1            \ TIM9 control register 1
  $04 constant TIM9_TIM9_CR2            \ TIM12 control register 2
  $08 constant TIM9_TIM9_SMCR           \ TIM9 slave mode control register
  $0C constant TIM9_TIM9_DIER           \ TIM9 Interrupt enable register
  $10 constant TIM9_TIM9_SR             \ TIM9 status register
  $14 constant TIM9_TIM9_EGR            \ TIM9 event generation register
  $18 constant TIM9_TIM9_CCMR1_INPUT    \ TIM9 capture/compare mode register 1
  $18 constant TIM9_TIM9_CCMR1_OUTPUT   \ TIM9 capture/compare mode register 1
  $20 constant TIM9_TIM9_CCER           \ TIM9 capture/compare enable register
  $24 constant TIM9_TIM9_CNT            \ TIM9 counter
  $28 constant TIM9_TIM9_PSC            \ TIM9 prescaler
  $2C constant TIM9_TIM9_ARR            \ TIM9 auto-reload register
  $34 constant TIM9_TIM9_CCR1           \ TIM9 capture/compare register 1
  $38 constant TIM9_TIM9_CCR2           \ TIM9 capture/compare register 2
  $5C constant TIM9_TIM9_TISEL          \ TIM9 timer input selection register

: TIM9_DEF ; [then]
