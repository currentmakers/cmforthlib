\
\ @file tim17.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM17_DEF

  [ifdef] TIM17_TIM17_CR1_DEF
    \
    \ @brief TIM17 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CEN                      \ [0x00] Counter enable Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
    $01 constant TIM17_UDIS                     \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM17_URS                      \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM17_OPM                      \ [0x03] One pulse mode
    $07 constant TIM17_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM17_CKD                      \ [0x08 : 2] Clock division This bit-field indicates the division ratio between the timer clock (CK_INT) frequency and the dead-time and sampling clock (tDTS)used by the dead-time generators and the digital filters (TIx),
    $0b constant TIM17_UIFREMAP                 \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM17_TIM17_CR2_DEF
    \
    \ @brief TIM17 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CCPC                     \ [0x00] Capture/compare preloaded control Note: This bit acts only on channels that have a complementary output.
    $02 constant TIM17_CCUS                     \ [0x02] Capture/compare control update selection Note: This bit acts only on channels that have a complementary output.
    $03 constant TIM17_CCDS                     \ [0x03] Capture/compare DMA selection
    $08 constant TIM17_OIS1                     \ [0x08] Output Idle state 1 (OC1 output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
    $09 constant TIM17_OIS1N                    \ [0x09] Output Idle state 1 (OC1N output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM17_TIM17_DIER_DEF
    \
    \ @brief TIM17 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM17_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $05 constant TIM17_COMIE                    \ [0x05] COM interrupt enable
    $07 constant TIM17_BIE                      \ [0x07] Break interrupt enable
    $08 constant TIM17_UDE                      \ [0x08] Update DMA request enable
    $09 constant TIM17_CC1DE                    \ [0x09] Capture/Compare 1 DMA request enable
  [then]


  [ifdef] TIM17_TIM17_SR_DEF
    \
    \ @brief TIM17 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_UIF                      \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register.
    $01 constant TIM17_CC1IF                    \ [0x01] Capture/Compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $05 constant TIM17_COMIF                    \ [0x05] COM interrupt flag
    $07 constant TIM17_BIF                      \ [0x07] Break interrupt flag This flag is set by hardware as soon as the break input goes active. It can be cleared by software if the break input is not active.
    $09 constant TIM17_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to 0.
  [then]


  [ifdef] TIM17_TIM17_EGR_DEF
    \
    \ @brief TIM17 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_UG                       \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM17_CC1G                     \ [0x01] Capture/Compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $05 constant TIM17_COMG                     \ [0x05] Capture/Compare control update generation This bit can be set by software, it is automatically cleared by hardware. Note: This bit acts only on channels that have a complementary output.
    $07 constant TIM17_BG                       \ [0x07] Break generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM17_TIM17_CCMR1_input_DEF
    \
    \ @brief TIM17 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CC1S                     \ [0x00 : 2] Capture/Compare 1 Selection This bit-field defines the direction of the channel (input/output) as well as the used input. Others: Reserved Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM17_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (IC1). The prescaler is reset as soon as CC1E=0 (TIMx_CCER register).
    $04 constant TIM17_IC1F                     \ [0x04 : 4] Input capture 1 filter This bit-field defines the frequency used to sample TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
  [then]


  [ifdef] TIM17_TIM17_CCMR1_output_DEF
    \
    \ @brief TIM17 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Others: Reserved Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM17_OC1FE                    \ [0x02] Output Compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM17_OC1PE                    \ [0x03] Output Compare 1 preload enable Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S=00 (the channel is configured in output). The PWM mode can be used without validating the preload register only in one pulse mode (OPM bit set in TIMx_CR1 register). Else the behavior is not guaranteed.
    $04 constant TIM17_OC1M1                    \ [0x04 : 3] Output Compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. All other values: Reserved Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S=00 (the channel is configured in output). In PWM mode 1 or 2, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from frozen mode to PWM mode. The OC1M[3] bit is not contiguous, located in bit 16.
    $10 constant TIM17_OC1M2                    \ [0x10] Output Compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. All other values: Reserved Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S=00 (the channel is configured in output). In PWM mode 1 or 2, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from frozen mode to PWM mode. The OC1M[3] bit is not contiguous, located in bit 16.
  [then]


  [ifdef] TIM17_TIM17_CCER_DEF
    \
    \ @brief TIM17 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CC1E                     \ [0x00] Capture/Compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to for details.
    $01 constant TIM17_CC1P                     \ [0x01] Capture/Compare 1 output polarity When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register). On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
    $02 constant TIM17_CC1NE                    \ [0x02] Capture/Compare 1 complementary output enable
    $03 constant TIM17_CC1NP                    \ [0x03] Capture/Compare 1 complementary output polarity CC1 channel configured as output: CC1 channel configured as input: This bit is used in conjunction with CC1P to define the polarity of TI1FP1 and TI2FP1. Refer to the description of CC1P. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S=00 (the channel is configured in output). On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1NP active bit takes the new value from the preloaded bit only when a commutation event is generated.
  [then]


  [ifdef] TIM17_TIM17_CNT_DEF
    \
    \ @brief TIM17 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CNT                      \ [0x00 : 16] Counter value
    $1f constant TIM17_UIFCPY                   \ [0x1f] UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in TIMx_CR1 is reset, bit 31 is reserved and read as 0.
  [then]


  [ifdef] TIM17_TIM17_PSC_DEF
    \
    \ @brief TIM17 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_PSC                      \ [0x00 : 16] Prescaler value The counter clock frequency (CK_CNT) is equal to fCK_PSC / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in reset mode).
  [then]


  [ifdef] TIM17_TIM17_ARR_DEF
    \
    \ @brief TIM17 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM17_ARR                      \ [0x00 : 16] Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.
  [then]


  [ifdef] TIM17_TIM17_RCR_DEF
    \
    \ @brief TIM17 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_REP                      \ [0x00 : 8] Repetition counter value These bits allow the user to set-up the update rate of the compare registers (i.e. periodic transfers from preload to active registers) when preload registers are enable, as well as the update interrupt generation rate, if this interrupt is enable. Each time the REP_CNT related downcounter reaches zero, an update event is generated and it restarts counting from REP value. As REP_CNT is reloaded with REP value only at the repetition update event U_RC, any write to the TIMx_RCR register is not taken in account until the next repetition update event. It means in PWM mode (REP+1) corresponds to the number of PWM periods in edge-aligned mode.
  [then]


  [ifdef] TIM17_TIM17_CCR1_DEF
    \
    \ @brief TIM17 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CCR1                     \ [0x00 : 16] Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC1 output. If channel CC1 is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (IC1).
  [then]


  [ifdef] TIM17_TIM17_BDTR_DEF
    \
    \ @brief TIM17 break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_DTG                      \ [0x00 : 8] Dead-time generator setup
    $08 constant TIM17_LOCK                     \ [0x08 : 2] Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIMx_BDTR register has been written, their content is frozen until the next reset.
    $0a constant TIM17_OSSI                     \ [0x0a] Off-state selection for Idle mode This bit is used when MOE=0 on channels configured as outputs. See OC/OCN enable description for more details (enable register (TIM16_CCER)(TIMx_CCER)(x = 16 to 17) on page 1793). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
    $0b constant TIM17_OSSR                     \ [0x0b] Off-state selection for Run mode This bit is used when MOE=1 on channels that have a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See OC/OCN enable description for more details (enable register (TIM16_CCER)(TIMx_CCER)(x = 16 to 17) on page 1793). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
    $0c constant TIM17_BKE                      \ [0x0c] Break enable 1; Break inputs (BRK and CCS clock failure event) enabled Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0d constant TIM17_BKP                      \ [0x0d] Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0e constant TIM17_AOE                      \ [0x0e] Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0f constant TIM17_MOE                      \ [0x0f] Main output enable This bit is cleared asynchronously by hardware as soon as the break input is active. It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. enable register (TIM16_CCER)(TIMx_CCER)(x = 16 to 17) on page 1793).
    $10 constant TIM17_BKF                      \ [0x10 : 4] Break filter This bit-field defines the frequency used to sample BRK input and the length of the digital filter applied to BRK. The digital filter is made of an event counter in which N events are needed to validate a transition on the output: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $1a constant TIM17_BKDSRM                   \ [0x1a] Break Disarm This bit is cleared by hardware when no break source is active. The BKDSRM bit must be set by software to release the bidirectional output control (open-drain output in Hi-Z state) and then be polled it until it is reset by hardware, indicating that the fault condition has disappeared. Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $1c constant TIM17_BKBID                    \ [0x1c] Break Bidirectional In the bidirectional mode (BKBID bit set to 1), the break input is configured both in input mode and in open drain output mode. Any active break event asserts a low logic level on the Break input to indicate an internal break event to external devices. Note: This bit cannot be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
  [then]


  [ifdef] TIM17_TIM17_DCR_DEF
    \
    \ @brief TIM17 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_DBA                      \ [0x00 : 5] DMA base address This 5-bit field defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ... Example: Let us consider the following transfer: DBL = 7 transfers and DBA = TIMx_CR1. In this case the transfer is done to/from 7 registers starting from the TIMx_CR1 address.
    $08 constant TIM17_DBL                      \ [0x08 : 5] DMA burst length This 5-bit field defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address), i.e. the number of transfers. Transfers can be in half-words or in bytes (see example below). ...
  [then]


  [ifdef] TIM17_TIM17_DMAR_DEF
    \
    \ @brief TIM17 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_DMAB                     \ [0x00 : 16] DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).
  [then]


  [ifdef] TIM17_TIM17_AF1_DEF
    \
    \ @brief TIM17 alternate function register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM17_BKINE                    \ [0x00] BRK BKIN input enable This bit enables the BKIN alternate function input for the timers BRK input. BKIN input is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $09 constant TIM17_BKINP                    \ [0x09] BRK BKIN input polarity This bit selects the BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM17_TIM17_TISEL_DEF
    \
    \ @brief TIM17 input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_TI1SEL                   \ [0x00 : 4] selects TI1[0] to TI1[15] input Others: Reserved
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM17_TIM17_CR1          \ TIM17 control register 1
  $04 constant TIM17_TIM17_CR2          \ TIM17 control register 2
  $0C constant TIM17_TIM17_DIER         \ TIM17 DMA/interrupt enable register
  $10 constant TIM17_TIM17_SR           \ TIM17 status register
  $14 constant TIM17_TIM17_EGR          \ TIM17 event generation register
  $18 constant TIM17_TIM17_CCMR1_INPUT  \ TIM17 capture/compare mode register 1 [alternate]
  $18 constant TIM17_TIM17_CCMR1_OUTPUT \ TIM17 capture/compare mode register 1 [alternate]
  $20 constant TIM17_TIM17_CCER         \ TIM17 capture/compare enable register
  $24 constant TIM17_TIM17_CNT          \ TIM17 counter
  $28 constant TIM17_TIM17_PSC          \ TIM17 prescaler
  $2C constant TIM17_TIM17_ARR          \ TIM17 auto-reload register
  $30 constant TIM17_TIM17_RCR          \ TIM17 repetition counter register
  $34 constant TIM17_TIM17_CCR1         \ TIM17 capture/compare register 1
  $44 constant TIM17_TIM17_BDTR         \ TIM17 break and dead-time register
  $48 constant TIM17_TIM17_DCR          \ TIM17 DMA control register
  $4C constant TIM17_TIM17_DMAR         \ TIM17 DMA address for full transfer
  $60 constant TIM17_TIM17_AF1          \ TIM17 alternate function register 1
  $68 constant TIM17_TIM17_TISEL        \ TIM17 input selection register

: TIM17_DEF ; [then]
