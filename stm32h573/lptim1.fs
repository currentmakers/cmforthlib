\
\ @file lptim1.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPTIM interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_ISR_OUTPUT_CC1IF                    \ Compare 1 interrupt flag The CC1IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. The CC1IF flag can be cleared by writing 1 to the CC1CF bit in the LPTIM_ICR register.
$00000002 constant LPTIM1_LPTIM_ISR_OUTPUT_ARRM                     \ Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT register's value reached the LPTIM_ARR register's value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
$00000004 constant LPTIM1_LPTIM_ISR_OUTPUT_EXTTRIG                  \ External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
$00000008 constant LPTIM1_LPTIM_ISR_OUTPUT_CMP1OK                   \ Compare register 1 update OK CMP1OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR1 register has been successfully completed. CMP1OK flag can be cleared by writing 1 to the CMP1OKCF bit in the LPTIM_ICR register.
$00000010 constant LPTIM1_LPTIM_ISR_OUTPUT_ARROK                    \ Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
$00000020 constant LPTIM1_LPTIM_ISR_OUTPUT_UP                       \ Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000040 constant LPTIM1_LPTIM_ISR_OUTPUT_DOWN                     \ Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000080 constant LPTIM1_LPTIM_ISR_OUTPUT_UE                       \ LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register.
$00000100 constant LPTIM1_LPTIM_ISR_OUTPUT_REPOK                    \ Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
$01000000 constant LPTIM1_LPTIM_ISR_OUTPUT_DIEROK                   \ Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.


\
\ @brief LPTIM interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_ISR_INTPUT_CC1IF                    \ capture 1 interrupt flag If channel CC1 is configured as input: CC1IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR1 register. The corresponding interrupt or DMA request is generated if enabled. The CC1OF flag is set if the CC1IF flag was already high.
$00000002 constant LPTIM1_LPTIM_ISR_INTPUT_ARRM                     \ Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT register's value reached the LPTIM_ARR register's value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
$00000004 constant LPTIM1_LPTIM_ISR_INTPUT_EXTTRIG                  \ External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
$00000010 constant LPTIM1_LPTIM_ISR_INTPUT_ARROK                    \ Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
$00000020 constant LPTIM1_LPTIM_ISR_INTPUT_UP                       \ Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000040 constant LPTIM1_LPTIM_ISR_INTPUT_DOWN                     \ Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000080 constant LPTIM1_LPTIM_ISR_INTPUT_UE                       \ LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register.
$00000100 constant LPTIM1_LPTIM_ISR_INTPUT_REPOK                    \ Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
$00000200 constant LPTIM1_LPTIM_ISR_INTPUT_CC2IF                    \ Capture 2 interrupt flag If channel CC2 is configured as input: CC2IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR2 register. The corresponding interrupt or DMA request is generated if enabled. The CC2OF flag is set if the CC2IF flag was already high. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
$00001000 constant LPTIM1_LPTIM_ISR_INTPUT_CC1OF                    \ Capture 1 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC1OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
$00002000 constant LPTIM1_LPTIM_ISR_INTPUT_CC2OF                    \ Capture 2 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC2OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
$01000000 constant LPTIM1_LPTIM_ISR_INTPUT_DIEROK                   \ Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.


\
\ @brief LPTIM interrupt clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_ICR_OUTPUT_CC1CF                    \ Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
$00000002 constant LPTIM1_LPTIM_ICR_OUTPUT_ARRMCF                   \ Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
$00000004 constant LPTIM1_LPTIM_ICR_OUTPUT_EXTTRIGCF                \ External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
$00000008 constant LPTIM1_LPTIM_ICR_OUTPUT_CMP1OKCF                 \ Compare register 1 update OK clear flag Writing 1 to this bit clears the CMP1OK flag in the LPTIM_ISR register.
$00000010 constant LPTIM1_LPTIM_ICR_OUTPUT_ARROKCF                  \ Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
$00000020 constant LPTIM1_LPTIM_ICR_OUTPUT_UPCF                     \ Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000040 constant LPTIM1_LPTIM_ICR_OUTPUT_DOWNCF                   \ Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000080 constant LPTIM1_LPTIM_ICR_OUTPUT_UECF                     \ Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
$00000100 constant LPTIM1_LPTIM_ICR_OUTPUT_REPOKCF                  \ Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
$01000000 constant LPTIM1_LPTIM_ICR_OUTPUT_DIEROKCF                 \ Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.


\
\ @brief LPTIM interrupt clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_ICR_INTPUT_CC1CF                    \ Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
$00000002 constant LPTIM1_LPTIM_ICR_INTPUT_ARRMCF                   \ Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
$00000004 constant LPTIM1_LPTIM_ICR_INTPUT_EXTTRIGCF                \ External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
$00000010 constant LPTIM1_LPTIM_ICR_INTPUT_ARROKCF                  \ Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
$00000020 constant LPTIM1_LPTIM_ICR_INTPUT_UPCF                     \ Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000040 constant LPTIM1_LPTIM_ICR_INTPUT_DOWNCF                   \ Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000080 constant LPTIM1_LPTIM_ICR_INTPUT_UECF                     \ Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
$00000100 constant LPTIM1_LPTIM_ICR_INTPUT_REPOKCF                  \ Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
$00000200 constant LPTIM1_LPTIM_ICR_INTPUT_CC2CF                    \ Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
$00001000 constant LPTIM1_LPTIM_ICR_INTPUT_CC1OCF                   \ Capture/compare 1 over-capture clear flag Writing 1 to this bit clears the CC1OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
$00002000 constant LPTIM1_LPTIM_ICR_INTPUT_CC2OCF                   \ Capture/compare 2 over-capture clear flag Writing 1 to this bit clears the CC2OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
$01000000 constant LPTIM1_LPTIM_ICR_INTPUT_DIEROKCF                 \ Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.


\
\ @brief LPTIM interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_DIER_OUTPUT_CC1IE                   \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM1_LPTIM_DIER_OUTPUT_ARRMIE                  \ Autoreload match Interrupt Enable
$00000004 constant LPTIM1_LPTIM_DIER_OUTPUT_EXTTRIGIE               \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM1_LPTIM_DIER_OUTPUT_CMP1OKIE                \ Compare register 1 update OK interrupt enable
$00000010 constant LPTIM1_LPTIM_DIER_OUTPUT_ARROKIE                 \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM1_LPTIM_DIER_OUTPUT_UPIE                    \ Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000040 constant LPTIM1_LPTIM_DIER_OUTPUT_DOWNIE                  \ Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000080 constant LPTIM1_LPTIM_DIER_OUTPUT_UEIE                    \ Update event interrupt enable
$00000100 constant LPTIM1_LPTIM_DIER_OUTPUT_REPOKIE                 \ Repetition register update OK interrupt Enable


\
\ @brief LPTIM interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_DIER_INTPUT_CC1IE                   \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM1_LPTIM_DIER_INTPUT_ARRMIE                  \ Autoreload match Interrupt Enable
$00000004 constant LPTIM1_LPTIM_DIER_INTPUT_EXTTRIGIE               \ External trigger valid edge Interrupt Enable
$00000010 constant LPTIM1_LPTIM_DIER_INTPUT_ARROKIE                 \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM1_LPTIM_DIER_INTPUT_UPIE                    \ Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000040 constant LPTIM1_LPTIM_DIER_INTPUT_DOWNIE                  \ Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
$00000080 constant LPTIM1_LPTIM_DIER_INTPUT_UEIE                    \ Update event interrupt enable
$00000100 constant LPTIM1_LPTIM_DIER_INTPUT_REPOKIE                 \ Repetition register update OK interrupt Enable
$00000200 constant LPTIM1_LPTIM_DIER_INTPUT_CC2IE                   \ Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
$00001000 constant LPTIM1_LPTIM_DIER_INTPUT_CC1OIE                  \ Capture/compare 1 over-capture interrupt enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
$00002000 constant LPTIM1_LPTIM_DIER_INTPUT_CC2OIE                  \ Capture/compare 2 over-capture interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
$00010000 constant LPTIM1_LPTIM_DIER_INTPUT_CC1DE                   \ Capture/compare 1 DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
$00800000 constant LPTIM1_LPTIM_DIER_INTPUT_UEDE                    \ Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
$02000000 constant LPTIM1_LPTIM_DIER_INTPUT_CC2DE                   \ Capture/compare 2 DMA request enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .


\
\ @brief LPTIM configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_CFGR_CKSEL                          \ Clock selector The CKSEL bit selects which clock source the LPTIM uses:
$00000006 constant LPTIM1_LPTIM_CFGR_CKPOL                          \ Clock Polarity When the LPTIM is clocked by an external clock source, CKPOL bits is used to configure the active edge or edges used by the counter: If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 1 is active. If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 2 is active. Refer to for more details about Encoder mode sub-modes.
$00000018 constant LPTIM1_LPTIM_CFGR_CKFLT                          \ Configurable digital filter for external clock The CKFLT value sets the number of consecutive equal samples that should be detected when a level change occurs on an external clock signal before it is considered as a valid level transition. An internal clock source must be present to use this feature
$000000c0 constant LPTIM1_LPTIM_CFGR_TRGFLT                         \ Configurable digital filter for trigger The TRGFLT value sets the number of consecutive equal samples that should be detected when a level change occurs on an internal trigger before it is considered as a valid level transition. An internal clock source must be present to use this feature
$00000e00 constant LPTIM1_LPTIM_CFGR_PRESC                          \ Clock prescaler The PRESC bits configure the prescaler division factor. It can be one among the following division factors:
$0000e000 constant LPTIM1_LPTIM_CFGR_TRIGSEL                        \ Trigger selector The TRIGSEL bits select the trigger source that serves as a trigger event for the LPTIM among the below 8 available sources: See for details.
$00060000 constant LPTIM1_LPTIM_CFGR_TRIGEN                         \ Trigger enable and polarity The TRIGEN bits controls whether the LPTIM counter is started by an external trigger or not. If the external trigger option is selected, three configurations are possible for the trigger active edge:
$00080000 constant LPTIM1_LPTIM_CFGR_TIMOUT                         \ Timeout enable The TIMOUT bit controls the Timeout feature
$00100000 constant LPTIM1_LPTIM_CFGR_WAVE                           \ Waveform shape The WAVE bit controls the output shape
$00200000 constant LPTIM1_LPTIM_CFGR_WAVPOL                         \ Waveform shape polarity The WAVEPOL bit controls the output polarity Note: If the LPTIM implements at least one capture/compare channel, this bit is reserved. Please refer to .
$00400000 constant LPTIM1_LPTIM_CFGR_PRELOAD                        \ Registers update mode The PRELOAD bit controls the LPTIM_ARR, LPTIM_RCR and the LPTIM_CCRx registers update modality
$00800000 constant LPTIM1_LPTIM_CFGR_COUNTMODE                      \ counter mode enabled The COUNTMODE bit selects which clock source is used by the LPTIM to clock the counter:
$01000000 constant LPTIM1_LPTIM_CFGR_ENC                            \ Encoder mode enable The ENC bit controls the Encoder mode Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .


\
\ @brief LPTIM control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_CR_ENABLE                           \ LPTIM enable The ENABLE bit is set and cleared by software.
$00000002 constant LPTIM1_LPTIM_CR_SNGSTRT                          \ LPTIM start in Single mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = '00'), setting this bit starts the LPTIM in single pulse mode. If the software start is disabled (TRIGEN[1:0] different than '00'), setting this bit starts the LPTIM in single pulse mode as soon as an external trigger is detected. If this bit is set when the LPTIM is in continuous counting mode, then the LPTIM stops at the following match between LPTIM_ARR and LPTIM_CNT registers. This bit can only be set when the LPTIM is enabled. It is automatically reset by hardware.
$00000004 constant LPTIM1_LPTIM_CR_CNTSTRT                          \ Timer start in Continuous mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = '00'), setting this bit starts the LPTIM in Continuous mode. If the software start is disabled (TRIGEN[1:0] different than '00'), setting this bit starts the timer in Continuous mode as soon as an external trigger is detected. If this bit is set when a single pulse mode counting is ongoing, then the timer does not stop at the next match between the LPTIM_ARR and LPTIM_CNT registers and the LPTIM counter keeps counting in Continuous mode. This bit can be set only when the LPTIM is enabled. It is automatically reset by hardware.
$00000008 constant LPTIM1_LPTIM_CR_COUNTRST                         \ Counter reset This bit is set by software and cleared by hardware. When set to '1' this bit triggers a synchronous reset of the LPTIM_CNT counter register. Due to the synchronous nature of this reset, it only takes place after a synchronization delay of 3 LPTimer core clock cycles (LPTimer core clock may be different from APB clock). This bit can be set only when the LPTIM is enabled. It is automatically reset by hardware. COUNTRST must never be set to '1' by software before it is already cleared to '0' by hardware. Software should consequently check that COUNTRST bit is already cleared to '0' before attempting to set it to '1'.
$00000010 constant LPTIM1_LPTIM_CR_RSTARE                           \ Reset after read enable This bit is set and cleared by software. When RSTARE is set to '1', any read access to LPTIM_CNT register asynchronously resets LPTIM_CNT register content. This bit can be set only when the LPTIM is enabled.


\
\ @brief LPTIM compare register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM1_LPTIM_CCR1_CCR1                           \ Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the capture/compare 1 register. Depending on the PRELOAD option, the CCR1 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 1 contains the value to be compared to the counter LPTIM_CNT and signaled on OC1 output. If channel CC1 is configured as input: CCR1 contains the counter value transferred by the last input capture 1 event. The LPTIM_CCR1 register is read-only and cannot be programmed. If LPTIM does not implement any channel: The compare register 1 contains the value to be compared to the counter LPTIM_CNT and signaled on LPTIM output.


\
\ @brief LPTIM autoreload register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIM1_LPTIM_ARR_ARR                             \ Auto reload value ARR is the autoreload value for the LPTIM. This value must be strictly greater than the CCRx[15:0] value.


\
\ @brief LPTIM counter register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM1_LPTIM_CNT_CNT                             \ Counter value When the LPTIM is running with an asynchronous clock, reading the LPTIM_CNT register may return unreliable values. So in this case it is necessary to perform two consecutive read accesses and verify that the two returned values are identical.


\
\ @brief LPTIM configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant LPTIM1_LPTIM_CFGR2_IN1SEL                        \ LPTIM input 1 selection The IN1SEL bits control the LPTIM input 1 multiplexer, which connects LPTIM input 1 to one of the available inputs. For connection details refer to .
$00000030 constant LPTIM1_LPTIM_CFGR2_IN2SEL                        \ LPTIM input 2 selection The IN2SEL bits control the LPTIM input 2 multiplexer, which connects LPTIM input 2 to one of the available inputs. For connection details refer to .
$00030000 constant LPTIM1_LPTIM_CFGR2_IC1SEL                        \ LPTIM input capture 1 selection The IC1SEL bits control the LPTIM Input capture 1 multiplexer, which connects LPTIM Input capture 1 to one of the available inputs. For connection details refer to .
$00300000 constant LPTIM1_LPTIM_CFGR2_IC2SEL                        \ LPTIM input capture 2 selection The IC2SEL bits control the LPTIM Input capture 2 multiplexer, which connects LPTIM Input capture 2 to one of the available inputs. For connection details refer to .


\
\ @brief LPTIM repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant LPTIM1_LPTIM_RCR_REP                             \ Repetition register value REP is the repetition value for the LPTIM.


\
\ @brief LPTIM capture/compare mode register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_CCMR1_CC1SEL                        \ Capture/compare 1 selection This bitfield defines the direction of the channel input (capture) or output mode.
$00000002 constant LPTIM1_LPTIM_CCMR1_CC1E                          \ Capture/compare 1 output enable. This bit determines if a capture of the counter value can actually be done into the input capture/compare register 1 (LPTIM_CCR1) or not.
$0000000c constant LPTIM1_LPTIM_CCMR1_CC1P                          \ Capture/compare 1 output polarity. Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. This field is used to select the IC1 polarity for capture operations.
$00000300 constant LPTIM1_LPTIM_CCMR1_IC1PSC                        \ Input capture 1 prescaler This bitfield defines the ratio of the prescaler acting on the CC1 input (IC1).
$00003000 constant LPTIM1_LPTIM_CCMR1_IC1F                          \ Input capture 1 filter This bitfield defines the number of consecutive equal samples that should be detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.
$00010000 constant LPTIM1_LPTIM_CCMR1_CC2SEL                        \ Capture/compare 2 selection This bitfield defines the direction of the channel, input (capture) or output mode.
$00020000 constant LPTIM1_LPTIM_CCMR1_CC2E                          \ Capture/compare 2 output enable. This bit determines if a capture of the counter value can actually be done into the input capture/compare register 2 (LPTIM_CCR2) or not.
$000c0000 constant LPTIM1_LPTIM_CCMR1_CC2P                          \ Capture/compare 2 output polarity. Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. This field is used to select the IC2 polarity for capture operations.
$03000000 constant LPTIM1_LPTIM_CCMR1_IC2PSC                        \ Input capture 2 prescaler This bitfield defines the ratio of the prescaler acting on the CC2 input (IC2).
$30000000 constant LPTIM1_LPTIM_CCMR1_IC2F                          \ Input capture 2 filter This bitfield defines the number of consecutive equal samples that should be detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.


\
\ @brief LPTIM compare register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM1_LPTIM_CCR2_CCR2                           \ Capture/compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the capture/compare 2 register. Depending on the PRELOAD option, the CCR2 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 2 contains the value to be compared to the counter LPTIM_CNT and signaled on OC2 output. If channel CC2 is configured as input: CCR2 contains the counter value transferred by the last input capture 2 event. The LPTIM_CCR2 register is read-only and cannot be programmed.


\
\ @brief Low power timer
\
$44004400 constant LPTIM1_LPTIM_ISR_OUTPUT  \ offset: 0x00 : LPTIM interrupt and status register
$44004400 constant LPTIM1_LPTIM_ISR_INTPUT  \ offset: 0x00 : LPTIM interrupt and status register
$44004404 constant LPTIM1_LPTIM_ICR_OUTPUT  \ offset: 0x04 : LPTIM interrupt clear register
$44004404 constant LPTIM1_LPTIM_ICR_INTPUT  \ offset: 0x04 : LPTIM interrupt clear register
$44004408 constant LPTIM1_LPTIM_DIER_OUTPUT  \ offset: 0x08 : LPTIM interrupt enable register
$44004408 constant LPTIM1_LPTIM_DIER_INTPUT  \ offset: 0x08 : LPTIM interrupt enable register
$4400440c constant LPTIM1_LPTIM_CFGR  \ offset: 0x0C : LPTIM configuration register
$44004410 constant LPTIM1_LPTIM_CR  \ offset: 0x10 : LPTIM control register
$44004414 constant LPTIM1_LPTIM_CCR1  \ offset: 0x14 : LPTIM compare register 1
$44004418 constant LPTIM1_LPTIM_ARR  \ offset: 0x18 : LPTIM autoreload register
$4400441c constant LPTIM1_LPTIM_CNT  \ offset: 0x1C : LPTIM counter register
$44004424 constant LPTIM1_LPTIM_CFGR2  \ offset: 0x24 : LPTIM configuration register 2
$44004428 constant LPTIM1_LPTIM_RCR  \ offset: 0x28 : LPTIM repetition register
$4400442c constant LPTIM1_LPTIM_CCMR1  \ offset: 0x2C : LPTIM capture/compare mode register 1
$44004434 constant LPTIM1_LPTIM_CCR2  \ offset: 0x34 : LPTIM compare register 2

