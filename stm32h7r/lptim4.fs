\
\ @file lptim4.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPTIM4 interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM4_LPTIM4_ISR_CC1IF                          \ Compare 1 interrupt flag The CC1IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. The CC1IF flag can be cleared by writing 1 to the CC1CF bit in the LPTIM_ICR register.
$00000002 constant LPTIM4_LPTIM4_ISR_ARRM                           \ Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT registers value reached the LPTIM_ARR registers value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
$00000004 constant LPTIM4_LPTIM4_ISR_EXTTRIG                        \ External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
$00000008 constant LPTIM4_LPTIM4_ISR_CMP1OK                         \ Compare register 1 update OK CMP1OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR1 register has been successfully completed. CMP1OK flag can be cleared by writing 1 to the CMP1OKCF bit in the LPTIM_ICR register.
$00000010 constant LPTIM4_LPTIM4_ISR_ARROK                          \ Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
$00000020 constant LPTIM4_LPTIM4_ISR_UP                             \ Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3: LPTIM implementation.
$00000040 constant LPTIM4_LPTIM4_ISR_DOWN                           \ Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3: LPTIM implementation.
$00000080 constant LPTIM4_LPTIM4_ISR_UE                             \ LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register.
$00000100 constant LPTIM4_LPTIM4_ISR_REPOK                          \ Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
$01000000 constant LPTIM4_LPTIM4_ISR_DIEROK                         \ Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.


\
\ @brief LPTIM4 interrupt clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM4_LPTIM4_ICR_CC1CF                          \ Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
$00000002 constant LPTIM4_LPTIM4_ICR_ARRMCF                         \ Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
$00000004 constant LPTIM4_LPTIM4_ICR_EXTTRIGCF                      \ External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
$00000008 constant LPTIM4_LPTIM4_ICR_CMP1OKCF                       \ Compare register 1 update OK clear flag Writing 1 to this bit clears the CMP1OK flag in the LPTIM_ISR register.
$00000010 constant LPTIM4_LPTIM4_ICR_ARROKCF                        \ Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
$00000020 constant LPTIM4_LPTIM4_ICR_UPCF                           \ Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
$00000040 constant LPTIM4_LPTIM4_ICR_DOWNCF                         \ Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
$00000080 constant LPTIM4_LPTIM4_ICR_UECF                           \ Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
$00000100 constant LPTIM4_LPTIM4_ICR_REPOKCF                        \ Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
$01000000 constant LPTIM4_LPTIM4_ICR_DIEROKCF                       \ Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.


\
\ @brief LPTIM4 interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM4_LPTIM4_DIER_CC1IE                         \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM4_LPTIM4_DIER_ARRMIE                        \ Autoreload match Interrupt Enable
$00000004 constant LPTIM4_LPTIM4_DIER_EXTTRIGIE                     \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM4_LPTIM4_DIER_CMP1OKIE                      \ Compare register 1 update OK interrupt enable
$00000010 constant LPTIM4_LPTIM4_DIER_ARROKIE                       \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM4_LPTIM4_DIER_UPIE                          \ Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
$00000040 constant LPTIM4_LPTIM4_DIER_DOWNIE                        \ Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section 26.3.
$00000080 constant LPTIM4_LPTIM4_DIER_UEIE                          \ Update event interrupt enable
$00000100 constant LPTIM4_LPTIM4_DIER_REPOKIE                       \ Repetition register update OK interrupt Enable


\
\ @brief Low power timer
\
$58002c00 constant LPTIM4_LPTIM4_ISR  \ offset: 0x00 : LPTIM4 interrupt and status register
$58002c04 constant LPTIM4_LPTIM4_ICR  \ offset: 0x04 : LPTIM4 interrupt clear register
$58002c08 constant LPTIM4_LPTIM4_DIER  \ offset: 0x08 : LPTIM4 interrupt enable register

