\
\ @file lptim.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM_DEF

  [ifdef] LPTIM_LPTIM_ISR_output_DEF
    \
    \ @brief LPTIM1 interrupt and status register [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CC1IF                    \ [0x00] Compare 1 interrupt flag If channel CC1 is configured as output: The CC1IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC1IF flag can be cleared by writing 1 to the CC1CF bit in the LPTIM_ICR register.
    $01 constant LPTIM_ARRM                     \ [0x01] Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT register's value reached the LPTIM_ARR register's value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
    $02 constant LPTIM_EXTTRIG                  \ [0x02] External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
    $03 constant LPTIM_CMP1OK                   \ [0x03] Compare register 1 update OK CMP1OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR1 register has been successfully completed. CMP1OK flag can be cleared by writing 1 to the CMP1OKCF bit in the LPTIM_ICR register.
    $04 constant LPTIM_ARROK                    \ [0x04] Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
    $05 constant LPTIM_UP                       \ [0x05] Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $06 constant LPTIM_DOWN                     \ [0x06] Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $07 constant LPTIM_UE                       \ [0x07] LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. The corresponding interrupt or DMA request is generated if enabled. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register. The UE flag is automatically cleared by hardware once the LPTIM_ARR register is written by any bus master like CPU or DMA.
    $08 constant LPTIM_REPOK                    \ [0x08] Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
    $09 constant LPTIM_CC2IF                    \ [0x09] Compare 2 interrupt flag If channel CC2 is configured as output: The CC2IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC2IF flag can be cleared by writing 1 to the CC2CF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $13 constant LPTIM_CMP2OK                   \ [0x13] Compare register 2 update OK CMP2OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR2 register has been successfully completed. CMP2OK flag can be cleared by writing 1 to the CMP2OKCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $18 constant LPTIM_DIEROK                   \ [0x18] Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.
  [then]


  [ifdef] LPTIM_LPTIM_ISR_intput_DEF
    \
    \ @brief LPTIM1 interrupt and status register [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CC1IF                    \ [0x00] capture 1 interrupt flag If channel CC1 is configured as input: CC1IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR1 register. The corresponding interrupt or DMA request is generated if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $01 constant LPTIM_ARRM                     \ [0x01] Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT register's value reached the LPTIM_ARR register's value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
    $02 constant LPTIM_EXTTRIG                  \ [0x02] External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
    $04 constant LPTIM_ARROK                    \ [0x04] Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
    $05 constant LPTIM_UP                       \ [0x05] Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $06 constant LPTIM_DOWN                     \ [0x06] Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $07 constant LPTIM_UE                       \ [0x07] LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register.
    $08 constant LPTIM_REPOK                    \ [0x08] Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
    $09 constant LPTIM_CC2IF                    \ [0x09] Capture 2 interrupt flag If channel CC2 is configured as input: CC2IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR2 register. The corresponding interrupt or DMA request is generated if enabled. The CC2OF flag is set if the CC2IF flag was already high. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $0c constant LPTIM_CC1OF                    \ [0x0c] Capture 1 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC1OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
    $0d constant LPTIM_CC2OF                    \ [0x0d] Capture 2 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC2OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $18 constant LPTIM_DIEROK                   \ [0x18] Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.
  [then]


  [ifdef] LPTIM_LPTIM_ICR_output_DEF
    \
    \ @brief LPTIM1 interrupt clear register [alternate]
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CC1CF                    \ [0x00] Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
    $01 constant LPTIM_ARRMCF                   \ [0x01] Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
    $02 constant LPTIM_EXTTRIGCF                \ [0x02] External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
    $03 constant LPTIM_CMP1OKCF                 \ [0x03] Compare register 1 update OK clear flag Writing 1 to this bit clears the CMP1OK flag in the LPTIM_ISR register.
    $04 constant LPTIM_ARROKCF                  \ [0x04] Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
    $05 constant LPTIM_UPCF                     \ [0x05] Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $06 constant LPTIM_DOWNCF                   \ [0x06] Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $07 constant LPTIM_UECF                     \ [0x07] Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
    $08 constant LPTIM_REPOKCF                  \ [0x08] Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
    $09 constant LPTIM_CC2CF                    \ [0x09] Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $13 constant LPTIM_CMP2OKCF                 \ [0x13] Compare register 2 update OK clear flag Writing 1 to this bit clears the CMP2OK flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $18 constant LPTIM_DIEROKCF                 \ [0x18] Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.
  [then]


  [ifdef] LPTIM_LPTIM_ICR_intput_DEF
    \
    \ @brief LPTIM interrupt clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CC1CF                    \ [0x00] Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
    $01 constant LPTIM_ARRMCF                   \ [0x01] Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
    $02 constant LPTIM_EXTTRIGCF                \ [0x02] External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
    $04 constant LPTIM_ARROKCF                  \ [0x04] Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
    $05 constant LPTIM_UPCF                     \ [0x05] Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $06 constant LPTIM_DOWNCF                   \ [0x06] Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $07 constant LPTIM_UECF                     \ [0x07] Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
    $08 constant LPTIM_REPOKCF                  \ [0x08] Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
    $09 constant LPTIM_CC2CF                    \ [0x09] Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $0c constant LPTIM_CC1OCF                   \ [0x0c] Capture/compare 1 over-capture clear flag Writing 1 to this bit clears the CC1OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
    $0d constant LPTIM_CC2OCF                   \ [0x0d] Capture/compare 2 over-capture clear flag Writing 1 to this bit clears the CC2OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $18 constant LPTIM_DIEROKCF                 \ [0x18] Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.
  [then]


  [ifdef] LPTIM_LPTIM_DIER_output_DEF
    \
    \ @brief LPTIM1 interrupt enable register [alternate]
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CC1IE                    \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM_ARRMIE                   \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM_EXTTRIGIE                \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM_CMP1OKIE                 \ [0x03] Compare register 1 update OK interrupt enable
    $04 constant LPTIM_ARROKIE                  \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM_UPIE                     \ [0x05] Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $06 constant LPTIM_DOWNIE                   \ [0x06] Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $07 constant LPTIM_UEIE                     \ [0x07] Update event interrupt enable
    $08 constant LPTIM_REPOKIE                  \ [0x08] Repetition register update OK interrupt Enable
    $09 constant LPTIM_CC2IE                    \ [0x09] Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $13 constant LPTIM_CMP2OKIE                 \ [0x13] Compare register 2 update OK interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $17 constant LPTIM_UEDE                     \ [0x17] Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
  [then]


  [ifdef] LPTIM_LPTIM_DIER_intput_DEF
    \
    \ @brief LPTIM interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CC1IE                    \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM_ARRMIE                   \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM_EXTTRIGIE                \ [0x02] External trigger valid edge Interrupt Enable
    $04 constant LPTIM_ARROKIE                  \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM_UPIE                     \ [0x05] Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $06 constant LPTIM_DOWNIE                   \ [0x06] Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $07 constant LPTIM_UEIE                     \ [0x07] Update event interrupt enable
    $08 constant LPTIM_REPOKIE                  \ [0x08] Repetition register update OK interrupt Enable
    $09 constant LPTIM_CC2IE                    \ [0x09] Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $0c constant LPTIM_CC1OIE                   \ [0x0c] Capture/compare 1 over-capture interrupt enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
    $0d constant LPTIM_CC2OIE                   \ [0x0d] Capture/compare 2 over-capture interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
    $10 constant LPTIM_CC1DE                    \ [0x10] Capture/compare 1 DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
    $17 constant LPTIM_UEDE                     \ [0x17] Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Please refer to .
    $19 constant LPTIM_CC2DE                    \ [0x19] Capture/compare 2 DMA request enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Please refer to .
  [then]


  [ifdef] LPTIM_LPTIM_CFGR_DEF
    \
    \ @brief LPTIM configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CKSEL                    \ [0x00] Clock selector The CKSEL bit selects which clock source the LPTIM uses:
    $01 constant LPTIM_CKPOL                    \ [0x01 : 2] Clock Polarity When the LPTIM is clocked by an external clock source, CKPOL bits is used to configure the active edge or edges used by the counter: If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 1 is active. If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 2 is active. Refer to for more details about Encoder mode sub-modes.
    $03 constant LPTIM_CKFLT                    \ [0x03 : 2] Configurable digital filter for external clock The CKFLT value sets the number of consecutive equal samples that should be detected when a level change occurs on an external clock signal before it is considered as a valid level transition. An internal clock source must be present to use this feature
    $06 constant LPTIM_TRGFLT                   \ [0x06 : 2] Configurable digital filter for trigger The TRGFLT value sets the number of consecutive equal samples that should be detected when a level change occurs on an internal trigger before it is considered as a valid level transition. An internal clock source must be present to use this feature
    $09 constant LPTIM_PRESC                    \ [0x09 : 3] Clock prescaler The PRESC bits configure the prescaler division factor. It can be one among the following division factors:
    $0d constant LPTIM_TRIGSEL                  \ [0x0d : 3] Trigger selector The TRIGSEL bits select the trigger source that serves as a trigger event for the LPTIM among the below 8 available sources: See for details.
    $11 constant LPTIM_TRIGEN                   \ [0x11 : 2] Trigger enable and polarity The TRIGEN bits controls whether the LPTIM counter is started by an external trigger or not. If the external trigger option is selected, three configurations are possible for the trigger active edge:
    $13 constant LPTIM_TIMOUT                   \ [0x13] Timeout enable The TIMOUT bit controls the Timeout feature
    $14 constant LPTIM_WAVE                     \ [0x14] Waveform shape The WAVE bit controls the output shape
    $15 constant LPTIM_WAVPOL                   \ [0x15] Waveform shape polarity The WAVPOL bit controls the output polarity Note: If the LPTIM implements at least one capture/compare channel, this bit is reserved. Please refer to .
    $16 constant LPTIM_PRELOAD                  \ [0x16] Registers update mode The PRELOAD bit controls the LPTIM_ARR, LPTIM_RCR and the LPTIM_CCRx registers update modality
    $17 constant LPTIM_COUNTMODE                \ [0x17] counter mode enabled The COUNTMODE bit selects which clock source is used by the LPTIM to clock the counter:
    $18 constant LPTIM_ENC                      \ [0x18] Encoder mode enable The ENC bit controls the Encoder mode Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
  [then]


  [ifdef] LPTIM_LPTIM_CR_DEF
    \
    \ @brief LPTIM control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_ENABLE                   \ [0x00] LPTIM enable The ENABLE bit is set and cleared by software.
    $01 constant LPTIM_SNGSTRT                  \ [0x01] LPTIM start in Single mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = '00'), setting this bit starts the LPTIM in single pulse mode. If the software start is disabled (TRIGEN[1:0] different than '00'), setting this bit starts the LPTIM in single pulse mode as soon as an external trigger is detected. If this bit is set when the LPTIM is in continuous counting mode, then the LPTIM stops at the following match between LPTIM_ARR and LPTIM_CNT registers. This bit can only be set when the LPTIM is enabled. It is automatically reset by hardware.
    $02 constant LPTIM_CNTSTRT                  \ [0x02] Timer start in Continuous mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = '00'), setting this bit starts the LPTIM in Continuous mode. If the software start is disabled (TRIGEN[1:0] different than '00'), setting this bit starts the timer in Continuous mode as soon as an external trigger is detected. If this bit is set when a single pulse mode counting is ongoing, then the timer does not stop at the next match between the LPTIM_ARR and LPTIM_CNT registers and the LPTIM counter keeps counting in Continuous mode. This bit can be set only when the LPTIM is enabled. It is automatically reset by hardware.
    $03 constant LPTIM_COUNTRST                 \ [0x03] Counter reset This bit is set by software and cleared by hardware. When set to '1' this bit triggers a synchronous reset of the LPTIM_CNT counter register. Due to the synchronous nature of this reset, it only takes place after a synchronization delay of 3 LPTimer core clock cycles (LPTimer core clock may be different from APB clock). This bit can be set only when the LPTIM is enabled. It is automatically reset by hardware. COUNTRST must never be set to '1' by software before it is already cleared to '0' by hardware. Software should consequently check that COUNTRST bit is already cleared to '0' before attempting to set it to '1'.
    $04 constant LPTIM_RSTARE                   \ [0x04] Reset after read enable This bit is set and cleared by software. When RSTARE is set to '1', any read access to LPTIM_CNT register asynchronously resets LPTIM_CNT register content. This bit can be set only when the LPTIM is enabled.
  [then]


  [ifdef] LPTIM_LPTIM_CCR1_DEF
    \
    \ @brief LPTIM compare register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CCR1                     \ [0x00 : 16] Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the capture/compare 1 register. Depending on the PRELOAD option, the CCR1 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 1 contains the value to be compared to the counter LPTIM_CNT and signaled on OC1 output. If channel CC1 is configured as input: CCR1 becomes read-only, it contains the counter value transferred by the last input capture 1 event. The LPTIM_CCR1 register is read-only and cannot be programmed.
  [then]


  [ifdef] LPTIM_LPTIM_ARR_DEF
    \
    \ @brief LPTIM autoreload register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM_ARR                      \ [0x00 : 16] Auto reload value ARR is the autoreload value for the LPTIM. This value must be strictly greater than the CCRx[15:0] value.
  [then]


  [ifdef] LPTIM_LPTIM_CNT_DEF
    \
    \ @brief LPTIM counter register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CNT                      \ [0x00 : 16] Counter value When the LPTIM is running with an asynchronous clock, reading the LPTIM_CNT register may return unreliable values. So in this case it is necessary to perform two consecutive read accesses and verify that the two returned values are identical.
  [then]


  [ifdef] LPTIM_LPTIM_RCR_DEF
    \
    \ @brief LPTIM repetition register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_REP                      \ [0x00 : 8] Repetition register value REP is the repetition value for the LPTIM.
  [then]


  [ifdef] LPTIM_LPTIM_CCMR1_DEF
    \
    \ @brief LPTIM capture/compare mode register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CC1SEL                   \ [0x00] Capture/compare 1 selection This bitfield defines the direction of the channel input (capture) or output mode.
    $01 constant LPTIM_CC1E                     \ [0x01] Capture/compare 1 output enable. This bit determines if a capture of the counter value can actually be done into the input capture/compare register 1 (LPTIM_CCR1) or not.
    $02 constant LPTIM_CC1P                     \ [0x02 : 2] Capture/compare 1 output polarity. Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. This field is used to select the IC1 polarity for capture operations.
    $08 constant LPTIM_IC1PSC                   \ [0x08 : 2] Input capture 1 prescaler This bitfield defines the ratio of the prescaler acting on the CC1 input (IC1).
    $0c constant LPTIM_IC1F                     \ [0x0c : 2] Input capture 1 filter This bitfield defines the number of consecutive equal samples that should be detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.
    $10 constant LPTIM_CC2SEL                   \ [0x10] Capture/compare 2 selection This bitfield defines the direction of the channel, input (capture) or output mode.
    $11 constant LPTIM_CC2E                     \ [0x11] Capture/compare 2 output enable. This bit determines if a capture of the counter value can actually be done into the input capture/compare register 2 (LPTIM_CCR2) or not.
    $12 constant LPTIM_CC2P                     \ [0x12 : 2] Capture/compare 2 output polarity. Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. This field is used to select the IC2 polarity for capture operations.
    $18 constant LPTIM_IC2PSC                   \ [0x18 : 2] Input capture 2 prescaler This bitfield defines the ratio of the prescaler acting on the CC2 input (IC2).
    $1c constant LPTIM_IC2F                     \ [0x1c : 2] Input capture 2 filter This bitfield defines the number of consecutive equal samples that should be detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.
  [then]


  [ifdef] LPTIM_LPTIM_CCR2_DEF
    \
    \ @brief LPTIM compare register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CCR2                     \ [0x00 : 16] Capture/compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the capture/compare 2 register. Depending on the PRELOAD option, the CCR2 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 2 contains the value to be compared to the counter LPTIM_CNT and signaled on OC2 output. If channel CC2 is configured as input: CCR2 becomes read-only, it contains the counter value transferred by the last input capture 2 event. The LPTIM_CCR2 register is read-only and cannot be programmed.
  [then]

  \
  \ @brief Low power timer
  \
  $00 constant LPTIM_LPTIM_ISR_OUTPUT   \ LPTIM1 interrupt and status register [alternate]
  $00 constant LPTIM_LPTIM_ISR_INTPUT   \ LPTIM1 interrupt and status register [alternate]
  $04 constant LPTIM_LPTIM_ICR_OUTPUT   \ LPTIM1 interrupt clear register [alternate]
  $04 constant LPTIM_LPTIM_ICR_INTPUT   \ LPTIM interrupt clear register
  $08 constant LPTIM_LPTIM_DIER_OUTPUT  \ LPTIM1 interrupt enable register [alternate]
  $08 constant LPTIM_LPTIM_DIER_INTPUT  \ LPTIM interrupt enable register
  $0C constant LPTIM_LPTIM_CFGR         \ LPTIM configuration register
  $10 constant LPTIM_LPTIM_CR           \ LPTIM control register
  $14 constant LPTIM_LPTIM_CCR1         \ LPTIM compare register 1
  $18 constant LPTIM_LPTIM_ARR          \ LPTIM autoreload register
  $1C constant LPTIM_LPTIM_CNT          \ LPTIM counter register
  $28 constant LPTIM_LPTIM_RCR          \ LPTIM repetition register
  $2C constant LPTIM_LPTIM_CCMR1        \ LPTIM capture/compare mode register 1
  $34 constant LPTIM_LPTIM_CCR2         \ LPTIM compare register 2

: LPTIM_DEF ; [then]
