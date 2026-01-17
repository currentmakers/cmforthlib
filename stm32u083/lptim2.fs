\
\ @file lptim2.fs
\ @brief LPTIM2 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM2_DEF

  [ifdef] LPTIM2_LPTIM2_ISR_OUTPUT_DEF
    \
    \ @brief LPTIM2 interrupt and status register [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IF                   \ [0x00] Compare 1 interrupt flag If channel CC1 is configured as output: The CC1IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC1IF flag can be cleared by writing 1 to the CC1CF bit in the LPTIM_ICR register.
    $01 constant LPTIM2_ARRM                    \ [0x01] Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT registers value reached the LPTIM_ARR registers value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
    $02 constant LPTIM2_EXTTRIG                 \ [0x02] External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
    $03 constant LPTIM2_CMP1OK                  \ [0x03] Compare register 1 update OK CMP1OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR1 register has been successfully completed. CMP1OK flag can be cleared by writing 1 to the CMP1OKCF bit in the LPTIM_ICR register.
    $04 constant LPTIM2_ARROK                   \ [0x04] Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
    $05 constant LPTIM2_UP                      \ [0x05] Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $06 constant LPTIM2_DOWN                    \ [0x06] Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $07 constant LPTIM2_UE                      \ [0x07] LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. The corresponding interrupt or DMA request is generated if enabled. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register. The UE flag is automatically cleared by hardware once the LPTIM_ARR register is written by any bus master like CPU or DMA.
    $08 constant LPTIM2_REPOK                   \ [0x08] Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
    $09 constant LPTIM2_CC2IF                   \ [0x09] Compare 2 interrupt flag If channel CC2 is configured as output: The CC2IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC2IF flag can be cleared by writing 1 to the CC2CF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $0a constant LPTIM2_CC3IF                   \ [0x0a] Compare 3 interrupt flag If channel CC3 is configured as output: The CC3IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC3IF flag can be cleared by writing 1 to the CC3CF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $0b constant LPTIM2_CC4IF                   \ [0x0b] Compare 4 interrupt flag If channel CC4 is configured as output: The CC4IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC4IF flag can be cleared by writing 1 to the CC4CF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $13 constant LPTIM2_CMP2OK                  \ [0x13] Compare register 2 update OK CMP2OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR2 register has been successfully completed. CMP2OK flag can be cleared by writing 1 to the CMP2OKCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $14 constant LPTIM2_CMP3OK                  \ [0x14] Compare register 3 update OK CMP3OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR3 register has been successfully completed. CMP3OK flag can be cleared by writing 1 to the CMP3OKCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $15 constant LPTIM2_CMP4OK                  \ [0x15] Compare register 4 update OK CMP4OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR4 register has been successfully completed. CMP4OK flag can be cleared by writing 1 to the CMP4OKCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $18 constant LPTIM2_DIEROK                  \ [0x18] Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.
  [then]


  [ifdef] LPTIM2_LPTIM2_ISR_INPUT_DEF
    \
    \ @brief LPTIM2 interrupt and status register [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IF                   \ [0x00] capture 1 interrupt flag If channel CC1 is configured as input: CC1IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR1 register. The corresponding interrupt or DMA request is generated if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $01 constant LPTIM2_ARRM                    \ [0x01] Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT registers value reached the LPTIM_ARR registers value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
    $02 constant LPTIM2_EXTTRIG                 \ [0x02] External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
    $04 constant LPTIM2_ARROK                   \ [0x04] Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
    $05 constant LPTIM2_UP                      \ [0x05] Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $06 constant LPTIM2_DOWN                    \ [0x06] Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $07 constant LPTIM2_UE                      \ [0x07] LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register.
    $08 constant LPTIM2_REPOK                   \ [0x08] Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
    $09 constant LPTIM2_CC2IF                   \ [0x09] Capture 2 interrupt flag If channel CC2 is configured as input: CC2IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR2 register. The corresponding interrupt or DMA request is generated if enabled. The CC2OF flag is set if the CC2IF flag was already high. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $0a constant LPTIM2_CC3IF                   \ [0x0a] Capture 3 interrupt flag If channel CC3 is configured as input: CC3IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR3 register. The corresponding interrupt or DMA request is generated if enabled. The CC3OF flag is set if the CC3IF flag was already high. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $0b constant LPTIM2_CC4IF                   \ [0x0b] Capture 4 interrupt flag If channel CC4 is configured as input: CC4IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR4 register. The corresponding interrupt or DMA request is generated if enabled. The CC4OF flag is set if the CC4IF flag was already high. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $0c constant LPTIM2_CC1OF                   \ [0x0c] Capture 1 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC1OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
    $0d constant LPTIM2_CC2OF                   \ [0x0d] Capture 2 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC2OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $0e constant LPTIM2_CC3OF                   \ [0x0e] Capture 3 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC3OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $0f constant LPTIM2_CC4OF                   \ [0x0f] Capture 4 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC4OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $18 constant LPTIM2_DIEROK                  \ [0x18] Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.
  [then]


  [ifdef] LPTIM2_LPTIM2_ICR_OUTPUT_DEF
    \
    \ @brief LPTIM2 interrupt clear register [alternate]
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1CF                   \ [0x00] Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
    $01 constant LPTIM2_ARRMCF                  \ [0x01] Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
    $02 constant LPTIM2_EXTTRIGCF               \ [0x02] External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
    $03 constant LPTIM2_CMP1OKCF                \ [0x03] Compare register 1 update OK clear flag Writing 1 to this bit clears the CMP1OK flag in the LPTIM_ISR register.
    $04 constant LPTIM2_ARROKCF                 \ [0x04] Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
    $05 constant LPTIM2_UPCF                    \ [0x05] Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $06 constant LPTIM2_DOWNCF                  \ [0x06] Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $07 constant LPTIM2_UECF                    \ [0x07] Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
    $08 constant LPTIM2_REPOKCF                 \ [0x08] Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
    $09 constant LPTIM2_CC2CF                   \ [0x09] Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $0a constant LPTIM2_CC3CF                   \ [0x0a] Capture/compare 3 clear flag Writing 1 to this bit clears the CC3IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $0b constant LPTIM2_CC4CF                   \ [0x0b] Capture/compare 4 clear flag Writing 1 to this bit clears the CC4IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $13 constant LPTIM2_CMP2OKCF                \ [0x13] Compare register 2 update OK clear flag Writing 1 to this bit clears the CMP2OK flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $14 constant LPTIM2_CMP3OKCF                \ [0x14] Compare register 3 update OK clear flag Writing 1 to this bit clears the CMP3OK flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $15 constant LPTIM2_CMP4OKCF                \ [0x15] Compare register 4 update OK clear flag Writing 1 to this bit clears the CMP4OK flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $18 constant LPTIM2_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.
  [then]


  [ifdef] LPTIM2_LPTIM2_ICR_INPUT_DEF
    \
    \ @brief LPTIM2 interrupt clear register [alternate]
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1CF                   \ [0x00] Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
    $01 constant LPTIM2_ARRMCF                  \ [0x01] Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
    $02 constant LPTIM2_EXTTRIGCF               \ [0x02] External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
    $04 constant LPTIM2_ARROKCF                 \ [0x04] Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
    $05 constant LPTIM2_UPCF                    \ [0x05] Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $06 constant LPTIM2_DOWNCF                  \ [0x06] Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $07 constant LPTIM2_UECF                    \ [0x07] Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
    $08 constant LPTIM2_REPOKCF                 \ [0x08] Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
    $09 constant LPTIM2_CC2CF                   \ [0x09] Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $0a constant LPTIM2_CC3CF                   \ [0x0a] Capture/compare 3 clear flag Writing 1 to this bit clears the CC3IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $0b constant LPTIM2_CC4CF                   \ [0x0b] Capture/compare 4 clear flag Writing 1 to this bit clears the CC4IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $0c constant LPTIM2_CC1OCF                  \ [0x0c] Capture/compare 1 over-capture clear flag Writing 1 to this bit clears the CC1OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
    $0d constant LPTIM2_CC2OCF                  \ [0x0d] Capture/compare 2 over-capture clear flag Writing 1 to this bit clears the CC2OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $0e constant LPTIM2_CC3OCF                  \ [0x0e] Capture/compare 3 over-capture clear flag Writing 1 to this bit clears the CC3OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $0f constant LPTIM2_CC4OCF                  \ [0x0f] Capture/compare 4 over-capture clear flag Writing 1 to this bit clears the CC4OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $18 constant LPTIM2_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.
  [then]


  [ifdef] LPTIM2_LPTIM2_DIER_OUTPUT_DEF
    \
    \ @brief LPTIM2 interrupt enable register [alternate]
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IE                   \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM2_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM2_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM2_CMP1OKIE                \ [0x03] Compare register 1 update OK interrupt enable
    $04 constant LPTIM2_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM2_UPIE                    \ [0x05] Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $06 constant LPTIM2_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $07 constant LPTIM2_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM2_REPOKIE                 \ [0x08] Repetition register update OK interrupt Enable
    $09 constant LPTIM2_CC2IE                   \ [0x09] Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $0a constant LPTIM2_CC3IE                   \ [0x0a] Capture/compare 3 interrupt enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $0b constant LPTIM2_CC4IE                   \ [0x0b] Capture/compare 4 interrupt enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $13 constant LPTIM2_CMP2OKIE                \ [0x13] Compare register 2 update OK interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $14 constant LPTIM2_CMP3OKIE                \ [0x14] Compare register 3 update OK interrupt enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $15 constant LPTIM2_CMP4OKIE                \ [0x15] Compare register 4 update OK interrupt enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $17 constant LPTIM2_UEDE                    \ [0x17] Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
  [then]


  [ifdef] LPTIM2_LPTIM2_DIER_INPUT_DEF
    \
    \ @brief LPTIM2 interrupt enable register [alternate]
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IE                   \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM2_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM2_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $04 constant LPTIM2_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM2_UPIE                    \ [0x05] Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $06 constant LPTIM2_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
    $07 constant LPTIM2_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM2_REPOKIE                 \ [0x08] Repetition register update OK interrupt Enable
    $09 constant LPTIM2_CC2IE                   \ [0x09] Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $0a constant LPTIM2_CC3IE                   \ [0x0a] Capture/compare 3 interrupt enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $0b constant LPTIM2_CC4IE                   \ [0x0b] Capture/compare 4 interrupt enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $0c constant LPTIM2_CC1OIE                  \ [0x0c] Capture/compare 1 over-capture interrupt enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
    $0d constant LPTIM2_CC2OIE                  \ [0x0d] Capture/compare 2 over-capture interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $0e constant LPTIM2_CC3OIE                  \ [0x0e] Capture/compare 3 over-capture interrupt enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $0f constant LPTIM2_CC4OIE                  \ [0x0f] Capture/compare 4 over-capture interrupt enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
    $10 constant LPTIM2_CC1DE                   \ [0x10] Capture/compare 1 DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
    $17 constant LPTIM2_UEDE                    \ [0x17] Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
    $19 constant LPTIM2_CC2DE                   \ [0x19] Capture/compare 2 DMA request enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
    $1a constant LPTIM2_CC3DE                   \ [0x1a] Capture/compare 3 DMA request enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
    $1b constant LPTIM2_CC4DE                   \ [0x1b] Capture/compare 4 DMA request enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
  [then]


  [ifdef] LPTIM2_LPTIM2_CFGR_DEF
    \
    \ @brief LPTIM configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CKSEL                   \ [0x00] Clock selector The CKSEL bit selects which clock source the LPTIM uses:
    $01 constant LPTIM2_CKPOL                   \ [0x01 : 2] Clock Polarity When the LPTIM is clocked by an external clock source, CKPOL bits is used to configure the active edge or edges used by the counter: If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 1 is active. If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 2 is active. If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 3 is active. Refer to Section125.4.15: Encoder mode for more details about Encoder mode sub-modes.
    $03 constant LPTIM2_CKFLT                   \ [0x03 : 2] Configurable digital filter for external clock The CKFLT value sets the number of consecutive equal samples that are detected when a level change occurs on an external clock signal before it is considered as a valid level transition. An internal clock source must be present to use this feature
    $06 constant LPTIM2_TRGFLT                  \ [0x06 : 2] Configurable digital filter for trigger The TRGFLT value sets the number of consecutive equal samples that are detected when a level change occurs on an internal trigger before it is considered as a valid level transition. An internal clock source must be present to use this feature
    $09 constant LPTIM2_PRESC                   \ [0x09 : 3] Clock prescaler The PRESC bits configure the prescaler division factor. It can be one among the following division factors:
    $0d constant LPTIM2_TRIGSEL                 \ [0x0d : 3] Trigger selector The TRIGSEL bits select the trigger source that serves as a trigger event for the LPTIM among the below 8 available sources: See Section125.4.3: LPTIM input and trigger mapping for details.
    $11 constant LPTIM2_TRIGEN                  \ [0x11 : 2] Trigger enable and polarity The TRIGEN bits controls whether the LPTIM counter is started by an external trigger or not. If the external trigger option is selected, three configurations are possible for the trigger active edge:
    $13 constant LPTIM2_TIMOUT                  \ [0x13] Timeout enable The TIMOUT bit controls the Timeout feature
    $14 constant LPTIM2_WAVE                    \ [0x14] Waveform shape The WAVE bit controls the output shape
    $16 constant LPTIM2_PRELOAD                 \ [0x16] Registers update mode The PRELOAD bit controls the LPTIM2_ARR, LPTIM2_RCR and the LPTIM2_CCRx registers update modality
    $17 constant LPTIM2_COUNTMODE               \ [0x17] counter mode enabled The COUNTMODE bit selects which clock source is used by the LPTIM to clock the counter:
    $18 constant LPTIM2_ENC                     \ [0x18] Encoder mode enable The ENC bit controls the Encoder mode Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
  [then]


  [ifdef] LPTIM2_LPTIM2_CR_DEF
    \
    \ @brief LPTIM control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_ENABLE                  \ [0x00] LPTIM enable The ENABLE bit is set and cleared by software.
    $01 constant LPTIM2_SNGSTRT                 \ [0x01] LPTIM start in Single mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = 00), setting this bit starts the LPTIM in single pulse mode. If the software start is disabled (TRIGEN[1:0] different than 00), setting this bit starts the LPTIM in single pulse mode as soon as an external trigger is detected. If this bit is set when the LPTIM is in continuous counting mode, then the LPTIM stops at the following match between LPTIM2_ARR and LPTIM2_CNT registers. This bit can only be set when the LPTIM is enabled. It is automatically reset by hardware.
    $02 constant LPTIM2_CNTSTRT                 \ [0x02] Timer start in Continuous mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = 00), setting this bit starts the LPTIM in Continuous mode. If the software start is disabled (TRIGEN[1:0] different than 00), setting this bit starts the timer in Continuous mode as soon as an external trigger is detected. If this bit is set when a single pulse mode counting is ongoing, then the timer does not stop at the next match between the LPTIM2_ARR and LPTIM2_CNT registers and the LPTIM counter keeps counting in Continuous mode. This bit can be set only when the LPTIM is enabled. It is automatically reset by hardware.
    $03 constant LPTIM2_COUNTRST                \ [0x03] Counter reset This bit is set by software and cleared by hardware. When set to '1' this bit triggers a synchronous reset of the LPTIM2_CNT counter register. Due to the synchronous nature of this reset, it only takes place after a synchronization delay of 3 LPTimer core clock cycles (LPTimer core clock may be different from APB clock). This bit can be set only when the LPTIM is enabled. It is automatically reset by hardware. COUNTRST must never be set to '1' by software before it is already cleared to '0' by hardware. Software must consequently check that COUNTRST bit is already cleared to '0' before attempting to set it to '1'.
    $04 constant LPTIM2_RSTARE                  \ [0x04] Reset after read enable This bit is set and cleared by software. When RSTARE is set to '1', any read access to LPTIM2_CNT register asynchronously resets LPTIM2_CNT register content. This bit can be set only when the LPTIM is enabled.
  [then]


  [ifdef] LPTIM2_LPTIM2_CCR1_DEF
    \
    \ @brief LPTIM compare register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CCR1                    \ [0x00 : 16] Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the capture/compare 1 register. Depending on the PRELOAD option, the CCR1 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 1 contains the value to be compared to the counter LPTIM2_CNT and signaled on OC1 output. If channel CC1 is configured as input: CCR1 becomes read-only, it contains the counter value transferred by the last input capture 1 event. The LPTIM2_CCR1 register is read-only and cannot be programmed.
  [then]


  [ifdef] LPTIM2_LPTIM2_ARR_DEF
    \
    \ @brief LPTIM autoreload register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM2_ARR                     \ [0x00 : 16] Auto reload value ARR is the autoreload value for the LPTIM. This value must be strictly greater than the CCRx[15:0] value.
  [then]


  [ifdef] LPTIM2_LPTIM2_CNT_DEF
    \
    \ @brief LPTIM counter register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CNT                     \ [0x00 : 16] Counter value When the LPTIM is running with an asynchronous clock, reading the LPTIM2_CNT register may return unreliable values. So in this case it is necessary to perform two consecutive read accesses and verify that the two returned values are identical.
  [then]


  [ifdef] LPTIM2_LPTIM2_CFGR2_DEF
    \
    \ @brief LPTIM configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_IN1SEL                  \ [0x00 : 2] LPTIM input 1 selection The IN1SEL bits control the LPTIM input 1 multiplexer, which connects LPTIM input 1 to one of the available inputs. For connection details refer to Section125.4.3: LPTIM input and trigger mapping.
    $04 constant LPTIM2_IN2SEL                  \ [0x04 : 2] LPTIM input 2 selection The IN2SEL bits control the LPTIM input 2 multiplexer, which connects LPTIM input 2 to one of the available inputs. For connection details refer to Section125.4.3: LPTIM input and trigger mapping.
    $10 constant LPTIM2_IC1SEL                  \ [0x10 : 2] LPTIM input capture 1 selection The IC1SEL bits control the LPTIM Input capture 1 multiplexer, which connects LPTIM Input capture 1 to one of the available inputs. For connection details refer to Section125.4.3: LPTIM input and trigger mapping.
    $14 constant LPTIM2_IC2SEL                  \ [0x14 : 2] LPTIM input capture 2 selection The IC2SEL bits control the LPTIM Input capture 2 multiplexer, which connects LPTIM Input capture 2 to one of the available inputs. For connection details refer to Section125.4.3: LPTIM input and trigger mapping.
  [then]


  [ifdef] LPTIM2_LPTIM2_RCR_DEF
    \
    \ @brief LPTIM repetition register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_REP                     \ [0x00 : 8] Repetition register value REP is the repetition value for the LPTIM.
  [then]


  [ifdef] LPTIM2_LPTIM2_CCMR1_DEF
    \
    \ @brief LPTIM capture/compare mode register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1SEL                  \ [0x00] Capture/compare 1 selection This bitfield defines the direction of the channel input (capture) or output mode.
    $01 constant LPTIM2_CC1E                    \ [0x01] Capture/compare 1 output enable. This bit determines if a capture of the counter value can actually be done into the input capture/compare register 1 (LPTIM2_CCR1) or not.
    $02 constant LPTIM2_CC1P                    \ [0x02 : 2] Capture/compare 1 output polarity. Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. This field is used to select the IC1 polarity for capture operations.
    $08 constant LPTIM2_IC1PSC                  \ [0x08 : 2] Input capture 1 prescaler This bitfield defines the ratio of the prescaler acting on the CC1 input (IC1).
    $0c constant LPTIM2_IC1F                    \ [0x0c : 2] Input capture 1 filter This bitfield defines the number of consecutive equal samples that are detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.
    $10 constant LPTIM2_CC2SEL                  \ [0x10] Capture/compare 2 selection This bitfield defines the direction of the channel, input (capture) or output mode.
    $11 constant LPTIM2_CC2E                    \ [0x11] Capture/compare 2 output enable. This bit determines if a capture of the counter value can actually be done into the input capture/compare register 2 (LPTIM2_CCR2) or not.
    $12 constant LPTIM2_CC2P                    \ [0x12 : 2] Capture/compare 2 output polarity. Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. This field is used to select the IC2 polarity for capture operations.
    $18 constant LPTIM2_IC2PSC                  \ [0x18 : 2] Input capture 2 prescaler This bitfield defines the ratio of the prescaler acting on the CC2 input (IC2).
    $1c constant LPTIM2_IC2F                    \ [0x1c : 2] Input capture 2 filter This bitfield defines the number of consecutive equal samples that are detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.
  [then]


  [ifdef] LPTIM2_LPTIM2_CCMR2_DEF
    \
    \ @brief LPTIM capture/compare mode register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC3SEL                  \ [0x00] Capture/compare 3 selection This bitfield defines the direction of the channel input (capture) or output mode.
    $01 constant LPTIM2_CC3E                    \ [0x01] Capture/compare 3 output enable. Condition: CC3 as output: Condition: CC3 as input: This bit determines if a capture of the counter value can actually be done into the input capture/compare register 3 (LPTIM2_CCR3) or not.
    $02 constant LPTIM2_CC3P                    \ [0x02 : 2] Capture/compare 3 output polarity. Condition: CC3 as output: Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. Condition: CC3 as input: This field is used to select the IC3 polarity for capture operations.
    $08 constant LPTIM2_IC3PSC                  \ [0x08 : 2] Input capture 3 prescaler This bitfield defines the ratio of the prescaler acting on the CC3 input (IC3).
    $0c constant LPTIM2_IC3F                    \ [0x0c : 2] Input capture 3 filter This bitfield defines the number of consecutive equal samples that should be detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.
    $10 constant LPTIM2_CC4SEL                  \ [0x10] Capture/compare 4 selection This bitfield defines the direction of the channel, input (capture) or output mode.
    $11 constant LPTIM2_CC4E                    \ [0x11] Capture/compare 4 output enable. Condition: CC4 as output: Condition: CC4 as input: This bit determines if a capture of the counter value can actually be done into the input capture/compare register 4 (LPTIM2_CCR4) or not.
    $12 constant LPTIM2_CC4P                    \ [0x12 : 2] Capture/compare 4 output polarity. Condition: CC4 as output: Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. Condition: CC4 as input: This field is used to select the IC4 polarity for capture operations.
    $18 constant LPTIM2_IC4PSC                  \ [0x18 : 2] Input capture 4 prescaler This bitfield defines the ratio of the prescaler acting on the CC4 input (IC4).
    $1c constant LPTIM2_IC4F                    \ [0x1c : 2] Input capture 4 filter This bitfield defines the number of consecutive equal samples that should be detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.
  [then]


  [ifdef] LPTIM2_LPTIM2_CCR2_DEF
    \
    \ @brief LPTIM compare register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CCR2                    \ [0x00 : 16] Capture/compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the capture/compare 2 register. Depending on the PRELOAD option, the CCR2 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 2 contains the value to be compared to the counter LPTIM2_CNT and signaled on OC2 output. If channel CC2 is configured as input: CCR2 becomes read-only, it contains the counter value transferred by the last input capture 2 event. The LPTIM2_CCR2 register is read-only and cannot be programmed.
  [then]


  [ifdef] LPTIM2_LPTIM2_CCR3_DEF
    \
    \ @brief LPTIM compare register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CCR3                    \ [0x00 : 16] Capture/compare 3 value If channel CC3 is configured as output: CCR3 is the value to be loaded in the capture/compare 3 register. Depending on the PRELOAD option, the CCR3 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 3 contains the value to be compared to the counter LPTIM2_CNT and signaled on OC3 output. If channel CC3 is configured as input: CCR3 becomes read-only, it contains the counter value transferred by the last input capture 3 event. The LPTIM2_CCR3 register is read-only and cannot be programmed.
  [then]


  [ifdef] LPTIM2_LPTIM2_CCR4_DEF
    \
    \ @brief LPTIM compare register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CCR4                    \ [0x00 : 16] Capture/compare 4 value If channel CC4 is configured as output: CCR4 is the value to be loaded in the capture/compare 4 register. Depending on the PRELOAD option, the CCR4 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 4 contains the value to be compared to the counter LPTIM2_CNT and signaled on OC4 output. If channel CC4 is configured as input: CCR4 becomes read-only, it contains the counter value transferred by the last input capture 4 event. The LPTIM2_CCR4 register is read-only and cannot be programmed.
  [then]

  \
  \ @brief LPTIM2 address block description
  \
  $00 constant LPTIM2_LPTIM2_ISR_OUTPUT \ LPTIM2 interrupt and status register [alternate]
  $00 constant LPTIM2_LPTIM2_ISR_INPUT  \ LPTIM2 interrupt and status register [alternate]
  $04 constant LPTIM2_LPTIM2_ICR_OUTPUT \ LPTIM2 interrupt clear register [alternate]
  $04 constant LPTIM2_LPTIM2_ICR_INPUT  \ LPTIM2 interrupt clear register [alternate]
  $08 constant LPTIM2_LPTIM2_DIER_OUTPUT    \ LPTIM2 interrupt enable register [alternate]
  $08 constant LPTIM2_LPTIM2_DIER_INPUT \ LPTIM2 interrupt enable register [alternate]
  $0C constant LPTIM2_LPTIM2_CFGR       \ LPTIM configuration register
  $10 constant LPTIM2_LPTIM2_CR         \ LPTIM control register
  $14 constant LPTIM2_LPTIM2_CCR1       \ LPTIM compare register 1
  $18 constant LPTIM2_LPTIM2_ARR        \ LPTIM autoreload register
  $1C constant LPTIM2_LPTIM2_CNT        \ LPTIM counter register
  $24 constant LPTIM2_LPTIM2_CFGR2      \ LPTIM configuration register 2
  $28 constant LPTIM2_LPTIM2_RCR        \ LPTIM repetition register
  $2C constant LPTIM2_LPTIM2_CCMR1      \ LPTIM capture/compare mode register 1
  $30 constant LPTIM2_LPTIM2_CCMR2      \ LPTIM capture/compare mode register 2
  $34 constant LPTIM2_LPTIM2_CCR2       \ LPTIM compare register 2
  $38 constant LPTIM2_LPTIM2_CCR3       \ LPTIM compare register 3
  $3C constant LPTIM2_LPTIM2_CCR4       \ LPTIM compare register 4

: LPTIM2_DEF ; [then]
