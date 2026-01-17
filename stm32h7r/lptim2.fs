\
\ @file lptim2.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM2_DEF

  [ifdef] LPTIM2_LPTIM2_ISR_OUTPUT_DEF
    \
    \ @brief LPTIM2 interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IF                   \ [0x00] Compare 1 interrupt flag If channel CC1 is configured as output: The CC1IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC1IF flag can be cleared by writing 1 to the CC1CF bit in the LPTIM_ICR register.
    $01 constant LPTIM2_ARRM                    \ [0x01] Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT registers value reached the LPTIM_ARR registers value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
    $02 constant LPTIM2_EXTTRIG                 \ [0x02] External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
    $03 constant LPTIM2_CMP1OK                  \ [0x03] Compare register 1 update OK CMP1OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR1 register has been successfully completed. CMP1OK flag can be cleared by writing 1 to the CMP1OKCF bit in the LPTIM_ICR register.
    $04 constant LPTIM2_ARROK                   \ [0x04] Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
    $05 constant LPTIM2_UP                      \ [0x05] Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $06 constant LPTIM2_DOWN                    \ [0x06] Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $07 constant LPTIM2_UE                      \ [0x07] LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. The corresponding interrupt or DMA request is generated if enabled. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register. The UE flag is automatically cleared by hardware once the LPTIM_ARR register is written by any bus master like CPU or DMA.
    $08 constant LPTIM2_REPOK                   \ [0x08] Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
    $09 constant LPTIM2_CC2IF                   \ [0x09] Compare 2 interrupt flag If channel CC2 is configured as output: The CC2IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC2IF flag can be cleared by writing 1 to the CC2CF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $13 constant LPTIM2_CMP2OK                  \ [0x13] Compare register 2 update OK CMP2OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR2 register has been successfully completed. CMP2OK flag can be cleared by writing 1 to the CMP2OKCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $18 constant LPTIM2_DIEROK                  \ [0x18] Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.
  [then]


  [ifdef] LPTIM2_LPTIM2_ISR_INPUT_DEF
    \
    \ @brief LPTIM2 interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IF                   \ [0x00] capture 1 interrupt flag If channel CC1 is configured as input: CC1IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR1 register. The corresponding interrupt or DMA request is generated if enabled. The CC1OF flag is set if the CC1IF flag was already high.
    $01 constant LPTIM2_ARRM                    \ [0x01] Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT registers value reached the LPTIM_ARR registers value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
    $02 constant LPTIM2_EXTTRIG                 \ [0x02] External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
    $04 constant LPTIM2_ARROK                   \ [0x04] Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
    $05 constant LPTIM2_UP                      \ [0x05] Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $06 constant LPTIM2_DOWN                    \ [0x06] Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $07 constant LPTIM2_UE                      \ [0x07] LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register.
    $08 constant LPTIM2_REPOK                   \ [0x08] Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
    $09 constant LPTIM2_CC2IF                   \ [0x09] Capture 2 interrupt flag If channel CC2 is configured as input: CC2IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR2 register. The corresponding interrupt or DMA request is generated if enabled. The CC2OF flag is set if the CC2IF flag was already high. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $0c constant LPTIM2_CC1OF                   \ [0x0c] Capture 1 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC1OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section 26.3.
    $0d constant LPTIM2_CC2OF                   \ [0x0d] Capture 2 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC2OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $18 constant LPTIM2_DIEROK                  \ [0x18] Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.
  [then]


  [ifdef] LPTIM2_LPTIM2_ICR_OUTPUT_DEF
    \
    \ @brief LPTIM2 interrupt clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1CF                   \ [0x00] Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
    $01 constant LPTIM2_ARRMCF                  \ [0x01] Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
    $02 constant LPTIM2_EXTTRIGCF               \ [0x02] External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
    $03 constant LPTIM2_CMP1OKCF                \ [0x03] Compare register 1 update OK clear flag Writing 1 to this bit clears the CMP1OK flag in the LPTIM_ISR register.
    $04 constant LPTIM2_ARROKCF                 \ [0x04] Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
    $05 constant LPTIM2_UPCF                    \ [0x05] Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $06 constant LPTIM2_DOWNCF                  \ [0x06] Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $07 constant LPTIM2_UECF                    \ [0x07] Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
    $08 constant LPTIM2_REPOKCF                 \ [0x08] Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
    $09 constant LPTIM2_CC2CF                   \ [0x09] Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $13 constant LPTIM2_CMP2OKCF                \ [0x13] Compare register 2 update OK clear flag Writing 1 to this bit clears the CMP2OK flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $18 constant LPTIM2_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.
  [then]


  [ifdef] LPTIM2_LPTIM2_ICR_INPUT_DEF
    \
    \ @brief LPTIM2 interrupt clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1CF                   \ [0x00] Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
    $01 constant LPTIM2_ARRMCF                  \ [0x01] Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
    $02 constant LPTIM2_EXTTRIGCF               \ [0x02] External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
    $04 constant LPTIM2_ARROKCF                 \ [0x04] Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
    $05 constant LPTIM2_UPCF                    \ [0x05] Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $06 constant LPTIM2_DOWNCF                  \ [0x06] Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $07 constant LPTIM2_UECF                    \ [0x07] Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
    $08 constant LPTIM2_REPOKCF                 \ [0x08] Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
    $09 constant LPTIM2_CC2CF                   \ [0x09] Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $0c constant LPTIM2_CC1OCF                  \ [0x0c] Capture/compare 1 over-capture clear flag Writing 1 to this bit clears the CC1OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section 26.3.
    $0d constant LPTIM2_CC2OCF                  \ [0x0d] Capture/compare 2 over-capture clear flag Writing 1 to this bit clears the CC2OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $18 constant LPTIM2_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.
  [then]


  [ifdef] LPTIM2_LPTIM2_DIER_OUTPUT_DEF
    \
    \ @brief LPTIM2 interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IE                   \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM2_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM2_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM2_CMP1OKIE                \ [0x03] Compare register 1 update OK interrupt enable
    $04 constant LPTIM2_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM2_UPIE                    \ [0x05] Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $06 constant LPTIM2_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $07 constant LPTIM2_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM2_REPOKIE                 \ [0x08] Repetition register update OK interrupt Enable
    $09 constant LPTIM2_CC2IE                   \ [0x09] Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $13 constant LPTIM2_CMP2OKIE                \ [0x13] Compare register 2 update OK interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $17 constant LPTIM2_UEDE                    \ [0x17] Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section 26.3.
  [then]


  [ifdef] LPTIM2_LPTIM2_DIER_INPUT_DEF
    \
    \ @brief LPTIM2 interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM2_CC1IE                   \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM2_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM2_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $04 constant LPTIM2_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM2_UPIE                    \ [0x05] Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $06 constant LPTIM2_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $07 constant LPTIM2_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM2_REPOKIE                 \ [0x08] Repetition register update OK interrupt Enable
    $09 constant LPTIM2_CC2IE                   \ [0x09] Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $0c constant LPTIM2_CC1OIE                  \ [0x0c] Capture/compare 1 over-capture interrupt enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section 26.3.
    $0d constant LPTIM2_CC2OIE                  \ [0x0d] Capture/compare 2 over-capture interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
    $10 constant LPTIM2_CC1DE                   \ [0x10] Capture/compare 1 DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section 26.3.
    $17 constant LPTIM2_UEDE                    \ [0x17] Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section 26.3.
    $19 constant LPTIM2_CC2DE                   \ [0x19] Capture/compare 2 DMA request enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section 26.3.
  [then]

  \
  \ @brief Low power timer
  \
  $00 constant LPTIM2_LPTIM2_ISR_OUTPUT \ LPTIM2 interrupt and status register
  $00 constant LPTIM2_LPTIM2_ISR_INPUT  \ LPTIM2 interrupt and status register
  $04 constant LPTIM2_LPTIM2_ICR_OUTPUT \ LPTIM2 interrupt clear register
  $04 constant LPTIM2_LPTIM2_ICR_INPUT  \ LPTIM2 interrupt clear register
  $08 constant LPTIM2_LPTIM2_DIER_OUTPUT    \ LPTIM2 interrupt enable register
  $08 constant LPTIM2_LPTIM2_DIER_INPUT \ LPTIM2 interrupt enable register

: LPTIM2_DEF ; [then]
