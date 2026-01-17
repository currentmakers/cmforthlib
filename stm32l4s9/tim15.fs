\
\ @file tim15.fs
\ @brief General purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM15_DEF

  [ifdef] TIM15_TIM15_CR1_DEF
    \
    \ @brief TIM15 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CEN                      \ [0x00] Counter enable Note: External clock and gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware.
    $01 constant TIM15_UDIS                     \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM15_URS                      \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM15_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM15_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM15_CKD                      \ [0x08 : 2] Clock division This bitfield indicates the division ratio between the timer clock (CK_INT) frequency and the dead-time and sampling clock (t<sub>DTS</sub>) used by the dead-time generators and the digital filters (TIx)
    $0b constant TIM15_UIFREMAP                 \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM15_TIM15_CR2_DEF
    \
    \ @brief TIM15 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCPC                     \ [0x00] Capture/compare preloaded control Note: This bit acts only on channels that have a complementary output.
    $02 constant TIM15_CCUS                     \ [0x02] Capture/compare control update selection Note: This bit acts only on channels that have a complementary output.
    $03 constant TIM15_CCDS                     \ [0x03] Capture/compare DMA selection
    $04 constant TIM15_MMS                      \ [0x04 : 3] Master mode selection These bits allow to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows:
    $07 constant TIM15_TI1S                     \ [0x07] TI1 selection
    $08 constant TIM15_OIS1                     \ [0x08] Output Idle state 1 (OC1 output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register).
    $09 constant TIM15_OIS1N                    \ [0x09] Output Idle state 1 (OC1N output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIM15_BDTR register).
    $0a constant TIM15_OIS2                     \ [0x0a] Output idle state 2 (OC2 output) Note: This bit cannot be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in the TIM15_BDTR register).
  [then]


  [ifdef] TIM15_TIM15_SMCR_DEF
    \
    \ @brief TIM15 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_SMS                      \ [0x00 : 3] SMS[0]: Slave mode selection When external signals are selected the active edge of the trigger signal (TRGI) is linked to the polarity selected on the external input (see Input Control register and Control register description. Other codes: reserved. Note: The gated mode must not be used if TI1F_ED is selected as the trigger input (TS= 00100 ). Indeed, TI1F_ED outputs 1 pulse for each transition on TI1F, whereas the gated mode checks the level of the trigger signal. Note: The clock of the slave peripherals (timer, ADC, ...) receiving the TRGO or the TRGO2 signals must be enabled prior to receive events from the master timer, and the clock frequency (prescaler) must not be changed on-the-fly while triggers are received from the master timer.
    $04 constant TIM15_TS                       \ [0x04 : 3] TS[0]: Trigger selection This bit field selects the trigger input to be used to synchronize the counter. Other: Reserved See Table 181: TIMx Internal trigger connection on page 910 for more details on ITRx meaning for each Timer. Note: These bits must be changed only when they are not used (e.g. when SMS=000) to avoid wrong edge detections at the transition.
    $07 constant TIM15_MSM                      \ [0x07] Master/slave mode
    $10 constant TIM15_SMS_1                    \ [0x10] SMS[3]
    $14 constant TIM15_TS_1                     \ [0x14 : 2] TS[4:3]
  [then]


  [ifdef] TIM15_TIM15_DIER_DEF
    \
    \ @brief TIM15 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM15_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM15_CC2IE                    \ [0x02] Capture/Compare 2 interrupt enable
    $05 constant TIM15_COMIE                    \ [0x05] COM interrupt enable
    $06 constant TIM15_TIE                      \ [0x06] Trigger interrupt enable
    $07 constant TIM15_BIE                      \ [0x07] Break interrupt enable
    $08 constant TIM15_UDE                      \ [0x08] Update DMA request enable
    $09 constant TIM15_CC1DE                    \ [0x09] Capture/Compare 1 DMA request enable
    $0d constant TIM15_COMDE                    \ [0x0d] COM DMA request enable
    $0e constant TIM15_TDE                      \ [0x0e] Trigger DMA request enable
  [then]


  [ifdef] TIM15_TIM15_SR_DEF
    \
    \ @brief TIM15 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UIF                      \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by a trigger event (refer to Section 26.6.3: TIM15 slave mode control register (TIM15_SMCR)), if URS=0 and UDIS=0 in the TIMx_CR1 register.
    $01 constant TIM15_CC1IF                    \ [0x01] Capture/Compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
    $02 constant TIM15_CC2IF                    \ [0x02] Capture/Compare 2 interrupt flag refer to CC1IF description
    $05 constant TIM15_COMIF                    \ [0x05] COM interrupt flag
    $06 constant TIM15_TIF                      \ [0x06] Trigger interrupt flag This flag is set by hardware on the TRG trigger event (active edge detected on TRGI input when the slave mode controller is enabled in all modes but gated mode, both edges in case gated mode is selected). It is set when the counter starts or stops when gated mode is selected. It is cleared by software.
    $07 constant TIM15_BIF                      \ [0x07] Break interrupt flag This flag is set by hardware as soon as the break input goes active. It can be cleared by software if the break input is not active.
    $09 constant TIM15_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to 0 .
    $0a constant TIM15_CC2OF                    \ [0x0a] Capture/Compare 2 overcapture flag Refer to CC1OF description
  [then]


  [ifdef] TIM15_TIM15_EGR_DEF
    \
    \ @brief TIM15 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_UG                       \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
    $01 constant TIM15_CC1G                     \ [0x01] Capture/Compare 1 generation This bit is set by software in order to generate an event, it is automatically cleared by hardware. If channel CC1 is configured as output: CC1IF flag is set, Corresponding interrupt or DMA request is sent if enabled. If channel CC1 is configured as input: The current value of the counter is captured in TIMx_CCR1 register. The CC1IF flag is set, the corresponding interrupt or DMA request is sent if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $02 constant TIM15_CC2G                     \ [0x02] Capture/Compare 2 generation Refer to CC1G description
    $05 constant TIM15_COMG                     \ [0x05] Capture/Compare control update generation This bit can be set by software, it is automatically cleared by hardware. Note: This bit acts only on channels that have a complementary output.
    $06 constant TIM15_TG                       \ [0x06] Trigger generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
    $07 constant TIM15_BG                       \ [0x07] Break generation This bit is set by software in order to generate an event, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM15_TIM15_CCMR1_DEF
    \
    \ @brief TIM15 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1S                     \ [0x00 : 2] Capture/Compare 1 Selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM15_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (IC1). The prescaler is reset as soon as CC1E= 0 (TIMx_CCER register).
    $04 constant TIM15_IC1F                     \ [0x04 : 4] Input capture 1 filter This bit-field defines the frequency used to sample TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:
    $08 constant TIM15_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM15_IC2PSC                   \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM15_IC2F                     \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM15_TIM15_CCMR1_ALTERNATE_DEF
    \
    \ @brief TIM15 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
    $02 constant TIM15_OC1FE                    \ [0x02] Output Compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
    $03 constant TIM15_OC1PE                    \ [0x03] Output Compare 1 preload enable Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S= 00 (the channel is configured in output).
    $04 constant TIM15_OC1M                     \ [0x04 : 3] OC1M[2:0]: Output Compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S= 00 (the channel is configured in output). Note: In PWM mode, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from frozen mode to PWM mode. Note: On channels that have a complementary output, this bit field is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the OC1M active bits take the new value from the preloaded bits only when a COM event is generated. Note: The OC1M[3] bit is not contiguous, located in bit 16.
    $08 constant TIM15_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Note: CC2S bits are writable only when the channel is OFF (CC2E = 0 in TIMx_CCER).
    $0a constant TIM15_OC2FE                    \ [0x0a] Output Compare 2 fast enable
    $0b constant TIM15_OC2PE                    \ [0x0b] Output Compare 2 preload enable
    $0c constant TIM15_OC2M                     \ [0x0c : 3] OC2M[2:0]: Output Compare 2 mode
    $10 constant TIM15_OC1M_1                   \ [0x10] OC1M[3]
    $18 constant TIM15_OC2M_1                   \ [0x18] OC2M[3]
  [then]


  [ifdef] TIM15_TIM15_CCER_DEF
    \
    \ @brief TIM15 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CC1E                     \ [0x00] Capture/Compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to Table 184 for details.
    $01 constant TIM15_CC1P                     \ [0x01] Capture/Compare 1 output polarity When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register). Note: On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
    $02 constant TIM15_CC1NE                    \ [0x02] Capture/Compare 1 complementary output enable
    $03 constant TIM15_CC1NP                    \ [0x03] Capture/Compare 1 complementary output polarity
    $04 constant TIM15_CC2E                     \ [0x04] Capture/Compare 2 output enable Refer to CC1E description
    $05 constant TIM15_CC2P                     \ [0x05] Capture/Compare 2 output polarity Refer to CC1P description
    $07 constant TIM15_CC2NP                    \ [0x07] Capture/Compare 2 complementary output polarity Refer to CC1NP description
  [then]


  [ifdef] TIM15_TIM15_CNT_DEF
    \
    \ @brief TIM15 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CNT                      \ [0x00 : 16] Counter value
    $1f constant TIM15_UIFCPY                   \ [0x1f] UIF Copy This bit is a read-only copy of the UIF bit in the TIMx_ISR register.
  [then]


  [ifdef] TIM15_TIM15_PSC_DEF
    \
    \ @brief TIM15 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM15_TIM15_ARR_DEF
    \
    \ @brief TIM15 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM15_ARR                      \ [0x00 : 16] Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the Section 26.5.1: Time-base unit on page 862 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.
  [then]


  [ifdef] TIM15_TIM15_RCR_DEF
    \
    \ @brief TIM15 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_REP                      \ [0x00 : 8] Repetition counter value These bits allow the user to set-up the update rate of the compare registers (i.e. periodic transfers from preload to active registers) when preload registers are enable, as well as the update interrupt generation rate, if this interrupt is enable. Each time the REP_CNT related downcounter reaches zero, an update event is generated and it restarts counting from REP value. As REP_CNT is reloaded with REP value only at the repetition update event U_RC, any write to the TIMx_RCR register is not taken in account until the next repetition update event. It means in PWM mode (REP+1) corresponds to the number of PWM periods in edge-aligned mode.
  [then]


  [ifdef] TIM15_TIM15_CCR1_DEF
    \
    \ @brief TIM15 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR1                     \ [0x00 : 16] Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC1 output. If channel CC1 is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (IC1).
  [then]


  [ifdef] TIM15_TIM15_CCR2_DEF
    \
    \ @brief TIM15 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_CCR2                     \ [0x00 : 16] Capture/Compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the actual capture/compare 2 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR2 register (bit OC2PE). Else the preload value is copied in the active capture/compare 2 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signalled on OC2 output. If channel CC2 is configured as input: CCR2 is the counter value transferred by the last input capture 2 event (IC2).
  [then]


  [ifdef] TIM15_TIM15_BDTR_DEF
    \
    \ @brief TIM15 break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DTG                      \ [0x00 : 8] Dead-time generator setup
    $08 constant TIM15_LOCK                     \ [0x08 : 2] Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIMx_BDTR register has been written, their content is frozen until the next reset.
    $0a constant TIM15_OSSI                     \ [0x0a] Off-state selection for Idle mode This bit is used when MOE=0 on channels configured as outputs. See OC/OCN enable description for more details (Section 26.6.9: TIM15 capture/compare enable register (TIM15_CCER) on page 918). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
    $0b constant TIM15_OSSR                     \ [0x0b] Off-state selection for Run mode This bit is used when MOE=1 on channels that have a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See OC/OCN enable description for more details (Section 26.6.9: TIM15 capture/compare enable register (TIM15_CCER) on page 918). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
    $0c constant TIM15_BKE                      \ [0x0c] Break enable 1; Break inputs (BRK and CCS clock failure event) enabled This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0d constant TIM15_BKP                      \ [0x0d] Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
    $0e constant TIM15_AOE                      \ [0x0e] Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0f constant TIM15_MOE                      \ [0x0f] Main output enable This bit is cleared asynchronously by hardware as soon as the break input is active. It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. See OC/OCN enable description for more details (Section 26.6.9: TIM15 capture/compare enable register (TIM15_CCER) on page 918).
    $10 constant TIM15_BKF                      \ [0x10 : 4] Break filter This bit-field defines the frequency used to sample the BRK input signal and the length of the digital filter applied to BRK. The digital filter is made of an event counter in which N events are needed to validate a transition on the output: Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM15_TIM15_DCR_DEF
    \
    \ @brief TIM15 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DBA                      \ [0x00 : 5] DMA base address This 5-bit field defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ...
    $08 constant TIM15_DBL                      \ [0x08 : 5] DMA burst length This 5-bit field defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address). ...
  [then]


  [ifdef] TIM15_TIM15_DMAR_DEF
    \
    \ @brief TIM15 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_DMAB                     \ [0x00 : 16] DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).
  [then]


  [ifdef] TIM15_TIM15_AF1_DEF
    \
    \ @brief TIM15 alternate register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM15_BKINE                    \ [0x00] BRK BKIN input enable This bit enables the BKIN alternate function input for the timer s BRK input. BKIN input is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $01 constant TIM15_BKCMP1E                  \ [0x01] BRK COMP1 enable This bit enables the COMP1 for the timer s BRK input. COMP1 output is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $02 constant TIM15_BKCMP2E                  \ [0x02] BRK COMP2 enable This bit enables the COMP2 for the timer s BRK input. COMP2 output is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $08 constant TIM15_BKDF1BK0E                \ [0x08] BRK dfsdm1_break[0] enable This bit enables the dfsdm1_break[0] for the timer s BRK input. dfsdm1_break[0] output is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $09 constant TIM15_BKINP                    \ [0x09] BRK BKIN input polarity This bit selects the BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0a constant TIM15_BKCMP1P                  \ [0x0a] BRK COMP1 input polarity This bit selects the COMP1 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
    $0b constant TIM15_BKCMP2P                  \ [0x0b] BRK COMP2 input polarity This bit selects the COMP2 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
  [then]


  [ifdef] TIM15_TIM15_TISEL_DEF
    \
    \ @brief TIM15 input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM15_TI1SEL                   \ [0x00 : 4] selects TI1[0] to TI1[15] input Other: Reserved
    $08 constant TIM15_TI2SEL                   \ [0x08 : 4] selects TI2[0] to TI2[15] input Others: Reserved
  [then]

  \
  \ @brief General purpose timers
  \
  $00 constant TIM15_TIM15_CR1          \ TIM15 control register 1
  $04 constant TIM15_TIM15_CR2          \ TIM15 control register 2
  $08 constant TIM15_TIM15_SMCR         \ TIM15 slave mode control register
  $0C constant TIM15_TIM15_DIER         \ TIM15 DMA/interrupt enable register
  $10 constant TIM15_TIM15_SR           \ TIM15 status register
  $14 constant TIM15_TIM15_EGR          \ TIM15 event generation register
  $18 constant TIM15_TIM15_CCMR1        \ TIM15 capture/compare mode register 1
  $18 constant TIM15_TIM15_CCMR1_ALTERNATE    \ TIM15 capture/compare mode register 1
  $20 constant TIM15_TIM15_CCER         \ TIM15 capture/compare enable register
  $24 constant TIM15_TIM15_CNT          \ TIM15 counter
  $28 constant TIM15_TIM15_PSC          \ TIM15 prescaler
  $2C constant TIM15_TIM15_ARR          \ TIM15 auto-reload register
  $30 constant TIM15_TIM15_RCR          \ TIM15 repetition counter register
  $34 constant TIM15_TIM15_CCR1         \ TIM15 capture/compare register 1
  $38 constant TIM15_TIM15_CCR2         \ TIM15 capture/compare register 2
  $44 constant TIM15_TIM15_BDTR         \ TIM15 break and dead-time register
  $48 constant TIM15_TIM15_DCR          \ TIM15 DMA control register
  $4C constant TIM15_TIM15_DMAR         \ TIM15 DMA address for full transfer
  $60 constant TIM15_TIM15_AF1          \ TIM15 alternate register 1
  $68 constant TIM15_TIM15_TISEL        \ TIM15 input selection register

: TIM15_DEF ; [then]
