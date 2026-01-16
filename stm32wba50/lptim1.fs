\
\ @file lptim1.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPTIM1 interrupt and status register [alternate]
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_ISR_OUTPUT_CC1IF                   \ Compare 1 interrupt flag If channel CC1 is configured as output: The CC1IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC1IF flag can be cleared by writing 1 to the CC1CF bit in the LPTIM_ICR register.
$00000002 constant LPTIM1_LPTIM1_ISR_OUTPUT_ARRM                    \ Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT register's value reached the LPTIM_ARR register's value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
$00000004 constant LPTIM1_LPTIM1_ISR_OUTPUT_EXTTRIG                 \ External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
$00000008 constant LPTIM1_LPTIM1_ISR_OUTPUT_CMP1OK                  \ Compare register 1 update OK CMP1OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR1 register has been successfully completed. CMP1OK flag can be cleared by writing 1 to the CMP1OKCF bit in the LPTIM_ICR register.
$00000010 constant LPTIM1_LPTIM1_ISR_OUTPUT_ARROK                   \ Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
$00000020 constant LPTIM1_LPTIM1_ISR_OUTPUT_UP                      \ Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000040 constant LPTIM1_LPTIM1_ISR_OUTPUT_DOWN                    \ Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000080 constant LPTIM1_LPTIM1_ISR_OUTPUT_UE                      \ LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. The corresponding interrupt or DMA request is generated if enabled. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register. The UE flag is automatically cleared by hardware once the LPTIM_ARR register is written by any bus master like CPU or DMA.
$00000100 constant LPTIM1_LPTIM1_ISR_OUTPUT_REPOK                   \ Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
$00000200 constant LPTIM1_LPTIM1_ISR_OUTPUT_CC2IF                   \ Compare 2 interrupt flag If channel CC2 is configured as output: The CC2IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC2IF flag can be cleared by writing 1 to the CC2CF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$00080000 constant LPTIM1_LPTIM1_ISR_OUTPUT_CMP2OK                  \ Compare register 2 update OK CMP2OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR2 register has been successfully completed. CMP2OK flag can be cleared by writing 1 to the CMP2OKCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$01000000 constant LPTIM1_LPTIM1_ISR_OUTPUT_DIEROK                  \ Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.


\
\ @brief Interrupt and Status Register (intput mode)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_ISR_INTPUT_CC1IF                   \ capture 1 interrupt flag If channel CC1 is configured as input: CC1IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR1 register. The corresponding interrupt or DMA request is generated if enabled. The CC1OF flag is set if the CC1IF flag was already high.
$00000002 constant LPTIM1_LPTIM1_ISR_INTPUT_ARRM                    \ Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT register's value reached the LPTIM_ARR register's value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
$00000004 constant LPTIM1_LPTIM1_ISR_INTPUT_EXTTRIG                 \ External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
$00000010 constant LPTIM1_LPTIM1_ISR_INTPUT_ARROK                   \ Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
$00000020 constant LPTIM1_LPTIM1_ISR_INTPUT_UP                      \ Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000040 constant LPTIM1_LPTIM1_ISR_INTPUT_DOWN                    \ Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000080 constant LPTIM1_LPTIM1_ISR_INTPUT_UE                      \ LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register.
$00000100 constant LPTIM1_LPTIM1_ISR_INTPUT_REPOK                   \ Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
$00000200 constant LPTIM1_LPTIM1_ISR_INTPUT_CC2IF                   \ Capture 2 interrupt flag If channel CC2 is configured as input: CC2IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR2 register. The corresponding interrupt or DMA request is generated if enabled. The CC2OF flag is set if the CC2IF flag was already high. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$00001000 constant LPTIM1_LPTIM1_ISR_INTPUT_CC1OF                   \ Capture 1 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC1OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section69.3.
$00002000 constant LPTIM1_LPTIM1_ISR_INTPUT_CC2OF                   \ Capture 2 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC2OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$01000000 constant LPTIM1_LPTIM1_ISR_INTPUT_DIEROK                  \ Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.


\
\ @brief LPTIM1 interrupt clear register [alternate]
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_ICR_OUTPUT_CC1CF                   \ Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
$00000002 constant LPTIM1_LPTIM1_ICR_OUTPUT_ARRMCF                  \ Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
$00000004 constant LPTIM1_LPTIM1_ICR_OUTPUT_EXTTRIGCF               \ External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
$00000008 constant LPTIM1_LPTIM1_ICR_OUTPUT_CMP1OKCF                \ Compare register 1 update OK clear flag Writing 1 to this bit clears the CMP1OK flag in the LPTIM_ISR register.
$00000010 constant LPTIM1_LPTIM1_ICR_OUTPUT_ARROKCF                 \ Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
$00000020 constant LPTIM1_LPTIM1_ICR_OUTPUT_UPCF                    \ Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000040 constant LPTIM1_LPTIM1_ICR_OUTPUT_DOWNCF                  \ Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000080 constant LPTIM1_LPTIM1_ICR_OUTPUT_UECF                    \ Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
$00000100 constant LPTIM1_LPTIM1_ICR_OUTPUT_REPOKCF                 \ Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
$00000200 constant LPTIM1_LPTIM1_ICR_OUTPUT_CC2CF                   \ Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$00080000 constant LPTIM1_LPTIM1_ICR_OUTPUT_CMP2OKCF                \ Compare register 2 update OK clear flag Writing 1 to this bit clears the CMP2OK flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$01000000 constant LPTIM1_LPTIM1_ICR_OUTPUT_DIEROKCF                \ Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.


\
\ @brief Interrupt Clear Register (intput mode)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_ICR_INTPUT_CC1CF                   \ Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
$00000002 constant LPTIM1_LPTIM1_ICR_INTPUT_ARRMCF                  \ Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
$00000004 constant LPTIM1_LPTIM1_ICR_INTPUT_EXTTRIGCF               \ External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
$00000010 constant LPTIM1_LPTIM1_ICR_INTPUT_ARROKCF                 \ Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
$00000020 constant LPTIM1_LPTIM1_ICR_INTPUT_UPCF                    \ Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000040 constant LPTIM1_LPTIM1_ICR_INTPUT_DOWNCF                  \ Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000080 constant LPTIM1_LPTIM1_ICR_INTPUT_UECF                    \ Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
$00000100 constant LPTIM1_LPTIM1_ICR_INTPUT_REPOKCF                 \ Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
$00000200 constant LPTIM1_LPTIM1_ICR_INTPUT_CC2CF                   \ Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$00001000 constant LPTIM1_LPTIM1_ICR_INTPUT_CC1OCF                  \ Capture/compare 1 over-capture clear flag Writing 1 to this bit clears the CC1OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section69.3.
$00002000 constant LPTIM1_LPTIM1_ICR_INTPUT_CC2OCF                  \ Capture/compare 2 over-capture clear flag Writing 1 to this bit clears the CC2OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$01000000 constant LPTIM1_LPTIM1_ICR_INTPUT_DIEROKCF                \ Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.


\
\ @brief LPTIM1 interrupt enable register [alternate]
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_DIER_OUTPUT_CC1IE                  \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM1_LPTIM1_DIER_OUTPUT_ARRMIE                 \ Autoreload match Interrupt Enable
$00000004 constant LPTIM1_LPTIM1_DIER_OUTPUT_EXTTRIGIE              \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM1_LPTIM1_DIER_OUTPUT_CMP1OKIE               \ Compare register 1 update OK interrupt enable
$00000010 constant LPTIM1_LPTIM1_DIER_OUTPUT_ARROKIE                \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM1_LPTIM1_DIER_OUTPUT_UPIE                   \ Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000040 constant LPTIM1_LPTIM1_DIER_OUTPUT_DOWNIE                 \ Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000080 constant LPTIM1_LPTIM1_DIER_OUTPUT_UEIE                   \ Update event interrupt enable
$00000100 constant LPTIM1_LPTIM1_DIER_OUTPUT_REPOKIE                \ Repetition register update OK interrupt Enable
$00000200 constant LPTIM1_LPTIM1_DIER_OUTPUT_CC2IE                  \ Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$00080000 constant LPTIM1_LPTIM1_DIER_OUTPUT_CMP2OKIE               \ Compare register 2 update OK interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$00800000 constant LPTIM1_LPTIM1_DIER_OUTPUT_UEDE                   \ Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section69.3.


\
\ @brief LPTIM interrupt Enable Register (intput mode)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_DIER_INTPUT_CC1IE                  \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM1_LPTIM1_DIER_INTPUT_ARRMIE                 \ Autoreload match Interrupt Enable
$00000004 constant LPTIM1_LPTIM1_DIER_INTPUT_EXTTRIGIE              \ External trigger valid edge Interrupt Enable
$00000010 constant LPTIM1_LPTIM1_DIER_INTPUT_ARROKIE                \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM1_LPTIM1_DIER_INTPUT_UPIE                   \ Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000040 constant LPTIM1_LPTIM1_DIER_INTPUT_DOWNIE                 \ Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section69.3.
$00000080 constant LPTIM1_LPTIM1_DIER_INTPUT_UEIE                   \ Update event interrupt enable
$00000100 constant LPTIM1_LPTIM1_DIER_INTPUT_REPOKIE                \ Repetition register update OK interrupt Enable
$00000200 constant LPTIM1_LPTIM1_DIER_INTPUT_CC2IE                  \ Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$00001000 constant LPTIM1_LPTIM1_DIER_INTPUT_CC1OIE                 \ Capture/compare 1 over-capture interrupt enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section69.3.
$00002000 constant LPTIM1_LPTIM1_DIER_INTPUT_CC2OIE                 \ Capture/compare 2 over-capture interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.
$00010000 constant LPTIM1_LPTIM1_DIER_INTPUT_CC1DE                  \ Capture/compare 1 DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section69.3.
$00800000 constant LPTIM1_LPTIM1_DIER_INTPUT_UEDE                   \ Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section69.3.
$02000000 constant LPTIM1_LPTIM1_DIER_INTPUT_CC2DE                  \ Capture/compare 2 DMA request enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section69.3.


\
\ @brief Low power timer
\
$46004400 constant LPTIM1_LPTIM1_ISR_OUTPUT  \ offset: 0x00 : LPTIM1 interrupt and status register [alternate]
$46004400 constant LPTIM1_LPTIM1_ISR_INTPUT  \ offset: 0x00 : Interrupt and Status Register (intput mode)
$46004404 constant LPTIM1_LPTIM1_ICR_OUTPUT  \ offset: 0x04 : LPTIM1 interrupt clear register [alternate]
$46004404 constant LPTIM1_LPTIM1_ICR_INTPUT  \ offset: 0x04 : Interrupt Clear Register (intput mode)
$46004408 constant LPTIM1_LPTIM1_DIER_OUTPUT  \ offset: 0x08 : LPTIM1 interrupt enable register [alternate]
$46004408 constant LPTIM1_LPTIM1_DIER_INTPUT  \ offset: 0x08 : LPTIM interrupt Enable Register (intput mode)

