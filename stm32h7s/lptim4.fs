\
\ @file lptim4.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM4_DEF

  [ifdef] LPTIM4_LPTIM4_ISR_DEF
    \
    \ @brief LPTIM4 interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM4_CC1IF                   \ [0x00] Compare 1 interrupt flag The CC1IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. The CC1IF flag can be cleared by writing 1 to the CC1CF bit in the LPTIM_ICR register.
    $01 constant LPTIM4_ARRM                    \ [0x01] Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT registers value reached the LPTIM_ARR registers value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
    $02 constant LPTIM4_EXTTRIG                 \ [0x02] External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
    $03 constant LPTIM4_CMP1OK                  \ [0x03] Compare register 1 update OK CMP1OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR1 register has been successfully completed. CMP1OK flag can be cleared by writing 1 to the CMP1OKCF bit in the LPTIM_ICR register.
    $04 constant LPTIM4_ARROK                   \ [0x04] Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
    $05 constant LPTIM4_UP                      \ [0x05] Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3: LPTIM implementation.
    $06 constant LPTIM4_DOWN                    \ [0x06] Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3: LPTIM implementation.
    $07 constant LPTIM4_UE                      \ [0x07] LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register.
    $08 constant LPTIM4_REPOK                   \ [0x08] Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
    $18 constant LPTIM4_DIEROK                  \ [0x18] Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.
  [then]


  [ifdef] LPTIM4_LPTIM4_ICR_DEF
    \
    \ @brief LPTIM4 interrupt clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM4_CC1CF                   \ [0x00] Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
    $01 constant LPTIM4_ARRMCF                  \ [0x01] Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
    $02 constant LPTIM4_EXTTRIGCF               \ [0x02] External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
    $03 constant LPTIM4_CMP1OKCF                \ [0x03] Compare register 1 update OK clear flag Writing 1 to this bit clears the CMP1OK flag in the LPTIM_ISR register.
    $04 constant LPTIM4_ARROKCF                 \ [0x04] Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
    $05 constant LPTIM4_UPCF                    \ [0x05] Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $06 constant LPTIM4_DOWNCF                  \ [0x06] Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $07 constant LPTIM4_UECF                    \ [0x07] Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
    $08 constant LPTIM4_REPOKCF                 \ [0x08] Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
    $18 constant LPTIM4_DIEROKCF                \ [0x18] Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.
  [then]


  [ifdef] LPTIM4_LPTIM4_DIER_DEF
    \
    \ @brief LPTIM4 interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM4_CC1IE                   \ [0x00] Capture/compare 1 interrupt enable
    $01 constant LPTIM4_ARRMIE                  \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM4_EXTTRIGIE               \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM4_CMP1OKIE                \ [0x03] Compare register 1 update OK interrupt enable
    $04 constant LPTIM4_ARROKIE                 \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM4_UPIE                    \ [0x05] Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $06 constant LPTIM4_DOWNIE                  \ [0x06] Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
    $07 constant LPTIM4_UEIE                    \ [0x07] Update event interrupt enable
    $08 constant LPTIM4_REPOKIE                 \ [0x08] Repetition register update OK interrupt Enable
  [then]

  \
  \ @brief Low power timer
  \
  $00 constant LPTIM4_LPTIM4_ISR        \ LPTIM4 interrupt and status register
  $04 constant LPTIM4_LPTIM4_ICR        \ LPTIM4 interrupt clear register
  $08 constant LPTIM4_LPTIM4_DIER       \ LPTIM4 interrupt enable register

: LPTIM4_DEF ; [then]
