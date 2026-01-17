\
\ @file tim14.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM14_DEF

  [ifdef] TIM14_TIM14_CR1_DEF
    \
    \ @brief TIM14 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CEN                      \ [0x00] Counter enable Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
    $01 constant TIM14_UDIS                     \ [0x01] Update disable This bit is set and cleared by software to enable/disable update interrupt (UEV) event generation. Counter overflow Setting the UG bit. Buffered registers are then loaded with their preload values.
    $02 constant TIM14_URS                      \ [0x02] Update request source This bit is set and cleared by software to select the update interrupt (UEV) sources. Counter overflow Setting the UG bit
    $03 constant TIM14_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM14_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM14_CKD                      \ [0x08 : 2] Clock division This bit-field indicates the division ratio between the timer clock (CK_INT) frequency and sampling clock used by the digital filters (TIx),
    $0b constant TIM14_UIFREMAP                 \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM14_TIM14_DIER_DEF
    \
    \ @brief TIM14 Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM14_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
  [then]


  [ifdef] TIM14_TIM14_SR_DEF
    \
    \ @brief TIM14 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_UIF                      \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow and if UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register.
    $01 constant TIM14_CC1IF                    \ [0x01] Capture/compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when he content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $09 constant TIM14_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to 0.
  [then]


  [ifdef] TIM14_TIM14_EGR_DEF
    \
    \ @brief TIM14 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_UG                       \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM14_CC1G                     \ [0x01] Capture/compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
  [then]


  [ifdef] TIM14_TIM14_CCMR1_input_DEF
    \
    \ @brief TIM14 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM14_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (IC1). The prescaler is reset as soon as CC1E=0 (TIMx_CCER register).
    $04 constant TIM14_IC1F                     \ [0x04 : 4] Input capture 1 filter This bit-field defines the frequency used to sample TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
  [then]


  [ifdef] TIM14_TIM14_CCMR1_output_DEF
    \
    \ @brief TIM14 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM14_OC1FE                    \ [0x02] Output compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM14_OC1PE                    \ [0x03] Output compare 1 preload enable Note: The PWM mode can be used without validating the preload register only in one pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
    $04 constant TIM14_OC1M1                    \ [0x04 : 3] Output compare 1 mode (refer to bit 16 for OC1M[3]) These bits define the behavior of the output reference signal OC1REF from which OC1 is derived. OC1REF is active high whereas OC1 active level depends on CC1P bit. Others: Reserved Note: In PWM mode 1 or 2, the OCREF level changes when the result of the comparison changes or when the output compare mode switches from frozen to PWM mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
    $10 constant TIM14_OC1M2                    \ [0x10] Output compare 1 mode (refer to bit 16 for OC1M[3]) These bits define the behavior of the output reference signal OC1REF from which OC1 is derived. OC1REF is active high whereas OC1 active level depends on CC1P bit. Others: Reserved Note: In PWM mode 1 or 2, the OCREF level changes when the result of the comparison changes or when the output compare mode switches from frozen to PWM mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
  [then]


  [ifdef] TIM14_TIM14_CCER_DEF
    \
    \ @brief TIM14 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CC1E                     \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM14_CC1P                     \ [0x01] Capture/Compare 1 output Polarity. When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: This configuration is reserved, it must not be used.
    $03 constant TIM14_CC1NP                    \ [0x03] Capture/Compare 1 complementary output Polarity. CC1 channel configured as output: CC1NP must be kept cleared. CC1 channel configured as input: CC1NP bit is used in conjunction with CC1P to define TI1FP1 polarity (refer to CC1P description).
  [then]


  [ifdef] TIM14_TIM14_CNT_DEF
    \
    \ @brief TIM14 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CNT                      \ [0x00 : 16] Counter value
    $1f constant TIM14_UIFCPY                   \ [0x1f] UIF Copy This bit is a read-only copy of the UIF bit in the TIMx_ISR register.
  [then]


  [ifdef] TIM14_TIM14_PSC_DEF
    \
    \ @brief TIM14 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_PSC                      \ [0x00 : 16] Prescaler value The counter clock frequency CK_CNT is equal to fCK_PSC / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event. (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in reset mode).
  [then]


  [ifdef] TIM14_TIM14_ARR_DEF
    \
    \ @brief TIM14 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM14_ARR                      \ [0x00 : 16] Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.
  [then]


  [ifdef] TIM14_TIM14_CCR1_DEF
    \
    \ @brief TIM14 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CCR1                     \ [0x00 : 16] Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC1 output. If channel CC1is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (IC1).
  [then]


  [ifdef] TIM14_TIM14_TISEL_DEF
    \
    \ @brief TIM14 timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_TI1SEL                   \ [0x00 : 4] selects TI1[0] to TI1[15] input Others: Reserved
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM14_TIM14_CR1          \ TIM14 control register 1
  $0C constant TIM14_TIM14_DIER         \ TIM14 Interrupt enable register
  $10 constant TIM14_TIM14_SR           \ TIM14 status register
  $14 constant TIM14_TIM14_EGR          \ TIM14 event generation register
  $18 constant TIM14_TIM14_CCMR1_INPUT  \ TIM14 capture/compare mode register 1 [alternate]
  $18 constant TIM14_TIM14_CCMR1_OUTPUT \ TIM14 capture/compare mode register 1 [alternate]
  $20 constant TIM14_TIM14_CCER         \ TIM14 capture/compare enable register
  $24 constant TIM14_TIM14_CNT          \ TIM14 counter
  $28 constant TIM14_TIM14_PSC          \ TIM14 prescaler
  $2C constant TIM14_TIM14_ARR          \ TIM14 auto-reload register
  $34 constant TIM14_TIM14_CCR1         \ TIM14 capture/compare register 1
  $68 constant TIM14_TIM14_TISEL        \ TIM14 timer input selection register

: TIM14_DEF ; [then]
