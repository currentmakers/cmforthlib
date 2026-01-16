\
\ @file tim16.fs
\ @brief General purpose timers
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
$00000300 constant TIM16_TIM16_CR1_CKD                              \ Clock division This bit-field indicates the division ratio between the timer clock (CK_INT) frequency and the dead-time and sampling clock (t<sub>DTS</sub>)used by the dead-time generators and the digital filters (TIx),
$00000800 constant TIM16_TIM16_CR1_UIFREMAP                         \ UIF status bit remapping


\
\ @brief TIM16 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM16_TIM16_CR2_CCPC                             \ Capture/compare preloaded control Note: This bit acts only on channels that have a complementary output.
$00000004 constant TIM16_TIM16_CR2_CCUS                             \ Capture/compare control update selection Note: This bit acts only on channels that have a complementary output.
$00000008 constant TIM16_TIM16_CR2_CCDS                             \ Capture/compare DMA selection
$00000100 constant TIM16_TIM16_CR2_OIS1                             \ Output Idle state 1 (OC1 output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).
$00000200 constant TIM16_TIM16_CR2_OIS1N                            \ Output Idle state 1 (OC1N output) Note: This bit can not be modified as long as LOCK level 1, 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register).


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


\
\ @brief TIM16 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM16_TIM16_SR_UIF                               \ Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow regarding the repetition counter value (update if repetition counter = 0) and if the UDIS=0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register.
$00000002 constant TIM16_TIM16_SR_CC1IF                             \ Capture/Compare 1 interrupt flag This flag is set by hardware. It is cleared by software (input capture or output compare mode) or by reading the TIMx_CCR1 register (input capture mode only). If channel CC1 is configured as output: this flag is set when the content of the counter TIMx_CNT matches the content of the TIMx_CCR1 register. When the content of TIMx_CCR1 is greater than the content of TIMx_ARR, the CC1IF bit goes high on the counter overflow (in up-counting and up/down-counting modes) or underflow (in down-counting mode). There are 3 possible options for flag setting in center-aligned mode, refer to the CMS bits in the TIMx_CR1 register for the full description. If channel CC1 is configured as input: this bit is set when counter value has been captured in TIMx_CCR1 register (an edge has been detected on IC1, as per the edge sensitivity defined with the CC1P and CC1NP bits setting, in TIMx_CCER).
$00000020 constant TIM16_TIM16_SR_COMIF                             \ COM interrupt flag
$00000080 constant TIM16_TIM16_SR_BIF                               \ Break interrupt flag This flag is set by hardware as soon as the break input goes active. It can be cleared by software if the break input is not active.
$00000200 constant TIM16_TIM16_SR_CC1OF                             \ Capture/Compare 1 overcapture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing it to 0 .


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
\ @brief TIM16 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM16_TIM16_CCMR1_CC1S                           \ Capture/Compare 1 Selection This bit-field defines the direction of the channel (input/output) as well as the used input. Others: Reserved Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
$0000000c constant TIM16_TIM16_CCMR1_IC1PSC                         \ Input capture 1 prescaler This bit-field defines the ratio of the prescaler acting on CC1 input (IC1). The prescaler is reset as soon as CC1E= 0 (TIMx_CCER register).
$000000f0 constant TIM16_TIM16_CCMR1_IC1F                           \ Input capture 1 filter This bit-field defines the frequency used to sample TI1 input and the length of the digital filter applied to TI1. The digital filter is made of an event counter in which N consecutive events are needed to validate a transition on the output:


\
\ @brief TIM16 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM16_TIM16_CCMR1_ALTERNATE_CC1S                 \ Capture/Compare 1 selection This bit-field defines the direction of the channel (input/output) as well as the used input. Others: Reserved Note: CC1S bits are writable only when the channel is OFF (CC1E = 0 in TIMx_CCER).
$00000004 constant TIM16_TIM16_CCMR1_ALTERNATE_OC1FE                \ Output Compare 1 fast enable This bit decreases the latency between a trigger event and a transition on the timer output. It must be used in one-pulse mode (OPM bit set in TIMx_CR1 register), to have the output pulse starting as soon as possible after the starting trigger.
$00000008 constant TIM16_TIM16_CCMR1_ALTERNATE_OC1PE                \ Output Compare 1 preload enable Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S= 00 (the channel is configured in output).
$00000070 constant TIM16_TIM16_CCMR1_ALTERNATE_OC1M                 \ OC1M[2:0]: Output Compare 1 mode These bits define the behavior of the output reference signal OC1REF from which OC1 and OC1N are derived. OC1REF is active high whereas OC1 and OC1N active level depends on CC1P and CC1NP bits. All other values: Reserved Note: These bits can not be modified as long as LOCK level 3 has been programmed (LOCK bits in TIMx_BDTR register) and CC1S= 00 (the channel is configured in output). Note: In PWM mode 1 or 2, the OCREF level changes only when the result of the comparison changes or when the output compare mode switches from frozen mode to PWM mode. Note: The OC1M[3] bit is not contiguous, located in bit 16.
$00010000 constant TIM16_TIM16_CCMR1_ALTERNATE_OC1M_1               \ OC1M[3]


\
\ @brief TIM16 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM16_TIM16_CCER_CC1E                            \ Capture/Compare 1 output enable When CC1 channel is configured as output, the OC1 level depends on MOE, OSSI, OSSR, OIS1, OIS1N and CC1NE bits, regardless of the CC1E bits state. Refer to Table 186 for details.
$00000002 constant TIM16_TIM16_CCER_CC1P                            \ Capture/Compare 1 output polarity When CC1 channel is configured as input, both CC1NP/CC1P bits select the active polarity of TI1FP1 and TI2FP1 for trigger or capture operations. CC1NP=0, CC1P=0: non-inverted/rising edge. The circuit is sensitive to TIxFP1 rising edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is not inverted (trigger operation in gated mode or encoder mode). CC1NP=0, CC1P=1: inverted/falling edge. The circuit is sensitive to TIxFP1 falling edge (capture or trigger operations in reset, external clock or trigger mode), TIxFP1 is inverted (trigger operation in gated mode or encoder mode). CC1NP=1, CC1P=1: non-inverted/both edges/ The circuit is sensitive to both TIxFP1 rising and falling edges (capture or trigger operations in reset, external clock or trigger mode), TIxFP1is not inverted (trigger operation in gated mode). This configuration must not be used in encoder mode. CC1NP=1, CC1P=0: this configuration is reserved, it must not be used. Note: This bit is not writable as soon as LOCK level 2 or 3 has been programmed (LOCK bits in TIMx_BDTR register). Note: On channels that have a complementary output, this bit is preloaded. If the CCPC bit is set in the TIMx_CR2 register then the CC1P active bit takes the new value from the preloaded bit only when a Commutation event is generated.
$00000004 constant TIM16_TIM16_CCER_CC1NE                           \ Capture/Compare 1 complementary output enable
$00000008 constant TIM16_TIM16_CCER_CC1NP                           \ Capture/Compare 1 complementary output polarity


\
\ @brief TIM16 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM16_TIM16_CNT_CNT                              \ Counter value
$80000000 constant TIM16_TIM16_CNT_UIFCPY                           \ UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in TIMx_CR1 is reset, bit 31 is reserved and read as 0.


\
\ @brief TIM16 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM16_TIM16_PSC_PSC                              \ Prescaler value The counter clock frequency (CK_CNT) is equal to f<sub>CK_PSC</sub> / (PSC[15:0] + 1). PSC contains the value to be loaded in the active prescaler register at each update event (including when the counter is cleared through UG bit of TIMx_EGR register or through trigger controller when configured in reset mode ).


\
\ @brief TIM16 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM16_TIM16_ARR_ARR                              \ Auto-reload value ARR is the value to be loaded in the actual auto-reload register. Refer to the Section 26.5.1: Time-base unit on page 862 for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null.


\
\ @brief TIM16 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM16_TIM16_RCR_REP                              \ Repetition counter value These bits allow the user to set-up the update rate of the compare registers (i.e. periodic transfers from preload to active registers) when preload registers are enable, as well as the update interrupt generation rate, if this interrupt is enable. Each time the REP_CNT related downcounter reaches zero, an update event is generated and it restarts counting from REP value. As REP_CNT is reloaded with REP value only at the repetition update event U_RC, any write to the TIMx_RCR register is not taken in account until the next repetition update event. It means in PWM mode (REP+1) corresponds to the number of PWM periods in edge-aligned mode.


\
\ @brief TIM16 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM16_TIM16_CCR1_CCR1                            \ Capture/Compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the actual capture/compare 1 register (preload value). It is loaded permanently if the preload feature is not selected in the TIMx_CCMR1 register (bit OC1PE). Else the preload value is copied in the active capture/compare 1 register when an update event occurs. The active capture/compare register contains the value to be compared to the counter TIMx_CNT and signaled on OC1 output. If channel CC1 is configured as input: CCR1 is the counter value transferred by the last input capture 1 event (IC1).


\
\ @brief TIM16 break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM16_TIM16_BDTR_DTG                             \ Dead-time generator setup
$00000300 constant TIM16_TIM16_BDTR_LOCK                            \ Lock configuration These bits offer a write protection against software errors. Note: The LOCK bits can be written only once after the reset. Once the TIMx_BDTR register has been written, their content is frozen until the next reset.
$00000400 constant TIM16_TIM16_BDTR_OSSI                            \ Off-state selection for Idle mode This bit is used when MOE=0 on channels configured as outputs. See OC/OCN enable description for more details (Section 26.7.8: TIMx capture/compare enable register (TIM16_CCER)(TIMx_CCER)(x = 16 to 17) on page 946). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00000800 constant TIM16_TIM16_BDTR_OSSR                            \ Off-state selection for Run mode This bit is used when MOE=1 on channels that have a complementary output which are configured as outputs. OSSR is not implemented if no complementary output is implemented in the timer. See OC/OCN enable description for more details (Section 26.7.8: TIMx capture/compare enable register (TIM16_CCER)(TIMx_CCER)(x = 16 to 17) on page 946). Note: This bit can not be modified as soon as the LOCK level 2 has been programmed (LOCK bits in TIMx_BDTR register).
$00001000 constant TIM16_TIM16_BDTR_BKE                             \ Break enable 1; Break inputs (BRK and CCS clock failure event) enabled Note: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00002000 constant TIM16_TIM16_BDTR_BKP                             \ Break polarity Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register). Note: Any write operation to this bit takes a delay of 1 APB clock cycle to become effective.
$00004000 constant TIM16_TIM16_BDTR_AOE                             \ Automatic output enable Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00008000 constant TIM16_TIM16_BDTR_MOE                             \ Main output enable This bit is cleared asynchronously by hardware as soon as the break input is active. It is set by software or automatically depending on the AOE bit. It is acting only on the channels which are configured in output. See OC/OCN enable description for more details (Section 26.7.8: TIMx capture/compare enable register (TIM16_CCER)(TIMx_CCER)(x = 16 to 17) on page 946).
$000f0000 constant TIM16_TIM16_BDTR_BKF                             \ Break filter This bit-field defines the frequency used to sample BRK input and the length of the digital filter applied to BRK. The digital filter is made of an event counter in which N events are needed to validate a transition on the output: This bit cannot be modified when LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM16 DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM16_TIM16_DCR_DBA                              \ DMA base address This 5-bit field defines the base-address for DMA transfers (when read/write access are done through the TIMx_DMAR address). DBA is defined as an offset starting from the address of the TIMx_CR1 register. Example: ... Example: Let us consider the following transfer: DBL = 7 transfers and DBA = TIMx_CR1. In this case the transfer is done to/from 7 registers starting from the TIMx_CR1 address.
$00001f00 constant TIM16_TIM16_DCR_DBL                              \ DMA burst length This 5-bit field defines the length of DMA transfers (the timer recognizes a burst transfer when a read or a write access is done to the TIMx_DMAR address), i.e. the number of transfers. Transfers can be in half-words or in bytes (see example below). ...


\
\ @brief TIM16 DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM16_TIM16_DMAR_DMAB                            \ DMA register for burst accesses A read or write operation to the DMAR register accesses the register located at the address (TIMx_CR1 address) + (DBA + DMA index) x 4 where TIMx_CR1 address is the address of the control register 1, DBA is the DMA base address configured in TIMx_DCR register, DMA index is automatically controlled by the DMA transfer, and ranges from 0 to DBL (DBL configured in TIMx_DCR).


\
\ @brief TIM16 alternate function register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM16_TIM16_AF1_BKINE                            \ BRK BKIN input enable This bit enables the BKIN alternate function input for the timer s BRK input. BKIN input is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000002 constant TIM16_TIM16_AF1_BKCMP1E                          \ BRK COMP1 enable This bit enables the COMP1 for the timer s BRK input. COMP1 output is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000004 constant TIM16_TIM16_AF1_BKCMP2E                          \ BRK COMP2 enable This bit enables the COMP2 for the timer s BRK input. COMP2 output is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000100 constant TIM16_TIM16_AF1_BKDF1BK1E                        \ BRK dfsdm1_break[1] enable This bit enables the dfsdm1_break[1] for the timer s BRK input. dfsdm1_break[1] output is ORed with the other BRK sources. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000200 constant TIM16_TIM16_AF1_BKINP                            \ BRK BKIN input polarity This bit selects the BKIN alternate function input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000400 constant TIM16_TIM16_AF1_BKCMP1P                          \ BRK COMP1 input polarity This bit selects the COMP1 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).
$00000800 constant TIM16_TIM16_AF1_BKCMP2P                          \ BRK COMP2 input polarity This bit selects the COMP2 input sensitivity. It must be programmed together with the BKP polarity bit. Note: This bit can not be modified as long as LOCK level 1 has been programmed (LOCK bits in TIMx_BDTR register).


\
\ @brief TIM16 input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM16_TIM16_TISEL_TI1SEL                         \ selects TI1[0] to TI1[15] input Other: Reserved


\
\ @brief General purpose timers
\
$40014400 constant TIM16_TIM16_CR1  \ offset: 0x00 : TIM16 control register 1
$40014404 constant TIM16_TIM16_CR2  \ offset: 0x04 : TIM16 control register 2
$4001440c constant TIM16_TIM16_DIER  \ offset: 0x0C : TIM16 DMA/interrupt enable register
$40014410 constant TIM16_TIM16_SR  \ offset: 0x10 : TIM16 status register
$40014414 constant TIM16_TIM16_EGR  \ offset: 0x14 : TIM16 event generation register
$40014418 constant TIM16_TIM16_CCMR1  \ offset: 0x18 : TIM16 capture/compare mode register 1
$40014418 constant TIM16_TIM16_CCMR1_ALTERNATE  \ offset: 0x18 : TIM16 capture/compare mode register 1
$40014420 constant TIM16_TIM16_CCER  \ offset: 0x20 : TIM16 capture/compare enable register
$40014424 constant TIM16_TIM16_CNT  \ offset: 0x24 : TIM16 counter
$40014428 constant TIM16_TIM16_PSC  \ offset: 0x28 : TIM16 prescaler
$4001442c constant TIM16_TIM16_ARR  \ offset: 0x2C : TIM16 auto-reload register
$40014430 constant TIM16_TIM16_RCR  \ offset: 0x30 : TIM16 repetition counter register
$40014434 constant TIM16_TIM16_CCR1  \ offset: 0x34 : TIM16 capture/compare register 1
$40014444 constant TIM16_TIM16_BDTR  \ offset: 0x44 : TIM16 break and dead-time register
$40014448 constant TIM16_TIM16_DCR  \ offset: 0x48 : TIM16 DMA control register
$4001444c constant TIM16_TIM16_DMAR  \ offset: 0x4C : TIM16 DMA address for full transfer
$40014460 constant TIM16_TIM16_AF1  \ offset: 0x60 : TIM16 alternate function register 1
$40014468 constant TIM16_TIM16_TISEL  \ offset: 0x68 : TIM16 input selection register

