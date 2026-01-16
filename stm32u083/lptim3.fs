\
\ @file lptim3.fs
\ @brief LPTIM3 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPTIM3 interrupt and status register [alternate]
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_ISR_OUTPUT_CC1IF                   \ Compare 1 interrupt flag If channel CC1 is configured as output: The CC1IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC1IF flag can be cleared by writing 1 to the CC1CF bit in the LPTIM_ICR register.
$00000002 constant LPTIM3_LPTIM3_ISR_OUTPUT_ARRM                    \ Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT registers value reached the LPTIM_ARR registers value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
$00000004 constant LPTIM3_LPTIM3_ISR_OUTPUT_EXTTRIG                 \ External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
$00000008 constant LPTIM3_LPTIM3_ISR_OUTPUT_CMP1OK                  \ Compare register 1 update OK CMP1OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR1 register has been successfully completed. CMP1OK flag can be cleared by writing 1 to the CMP1OKCF bit in the LPTIM_ICR register.
$00000010 constant LPTIM3_LPTIM3_ISR_OUTPUT_ARROK                   \ Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
$00000020 constant LPTIM3_LPTIM3_ISR_OUTPUT_UP                      \ Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000040 constant LPTIM3_LPTIM3_ISR_OUTPUT_DOWN                    \ Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000080 constant LPTIM3_LPTIM3_ISR_OUTPUT_UE                      \ LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. The corresponding interrupt or DMA request is generated if enabled. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register. The UE flag is automatically cleared by hardware once the LPTIM_ARR register is written by any bus master like CPU or DMA.
$00000100 constant LPTIM3_LPTIM3_ISR_OUTPUT_REPOK                   \ Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
$00000200 constant LPTIM3_LPTIM3_ISR_OUTPUT_CC2IF                   \ Compare 2 interrupt flag If channel CC2 is configured as output: The CC2IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC2IF flag can be cleared by writing 1 to the CC2CF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00000400 constant LPTIM3_LPTIM3_ISR_OUTPUT_CC3IF                   \ Compare 3 interrupt flag If channel CC3 is configured as output: The CC3IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC3IF flag can be cleared by writing 1 to the CC3CF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00000800 constant LPTIM3_LPTIM3_ISR_OUTPUT_CC4IF                   \ Compare 4 interrupt flag If channel CC4 is configured as output: The CC4IF flag is set by hardware to inform application that LPTIM_CNT register value matches the compare register's value. CC4IF flag can be cleared by writing 1 to the CC4CF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$00080000 constant LPTIM3_LPTIM3_ISR_OUTPUT_CMP2OK                  \ Compare register 2 update OK CMP2OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR2 register has been successfully completed. CMP2OK flag can be cleared by writing 1 to the CMP2OKCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00100000 constant LPTIM3_LPTIM3_ISR_OUTPUT_CMP3OK                  \ Compare register 3 update OK CMP3OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR3 register has been successfully completed. CMP3OK flag can be cleared by writing 1 to the CMP3OKCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00200000 constant LPTIM3_LPTIM3_ISR_OUTPUT_CMP4OK                  \ Compare register 4 update OK CMP4OK is set by hardware to inform application that the APB bus write operation to the LPTIM_CCR4 register has been successfully completed. CMP4OK flag can be cleared by writing 1 to the CMP4OKCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$01000000 constant LPTIM3_LPTIM3_ISR_OUTPUT_DIEROK                  \ Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.


\
\ @brief LPTIM3 interrupt and status register [alternate]
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_ISR_INPUT_CC1IF                    \ capture 1 interrupt flag If channel CC1 is configured as input: CC1IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR1 register. The corresponding interrupt or DMA request is generated if enabled. The CC1OF flag is set if the CC1IF flag was already high.
$00000002 constant LPTIM3_LPTIM3_ISR_INPUT_ARRM                     \ Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT registers value reached the LPTIM_ARR registers value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
$00000004 constant LPTIM3_LPTIM3_ISR_INPUT_EXTTRIG                  \ External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
$00000010 constant LPTIM3_LPTIM3_ISR_INPUT_ARROK                    \ Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
$00000020 constant LPTIM3_LPTIM3_ISR_INPUT_UP                       \ Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000040 constant LPTIM3_LPTIM3_ISR_INPUT_DOWN                     \ Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000080 constant LPTIM3_LPTIM3_ISR_INPUT_UE                       \ LPTIM update event occurred UE is set by hardware to inform application that an update event was generated. UE flag can be cleared by writing 1 to the UECF bit in the LPTIM_ICR register.
$00000100 constant LPTIM3_LPTIM3_ISR_INPUT_REPOK                    \ Repetition register update OK REPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_RCR register has been successfully completed. REPOK flag can be cleared by writing 1 to the REPOKCF bit in the LPTIM_ICR register.
$00000200 constant LPTIM3_LPTIM3_ISR_INPUT_CC2IF                    \ Capture 2 interrupt flag If channel CC2 is configured as input: CC2IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR2 register. The corresponding interrupt or DMA request is generated if enabled. The CC2OF flag is set if the CC2IF flag was already high. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00000400 constant LPTIM3_LPTIM3_ISR_INPUT_CC3IF                    \ Capture 3 interrupt flag If channel CC3 is configured as input: CC3IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR3 register. The corresponding interrupt or DMA request is generated if enabled. The CC3OF flag is set if the CC3IF flag was already high. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00000800 constant LPTIM3_LPTIM3_ISR_INPUT_CC4IF                    \ Capture 4 interrupt flag If channel CC4 is configured as input: CC4IF is set by hardware to inform application that the current value of the counter is captured in LPTIM_CCR4 register. The corresponding interrupt or DMA request is generated if enabled. The CC4OF flag is set if the CC4IF flag was already high. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$00001000 constant LPTIM3_LPTIM3_ISR_INPUT_CC1OF                    \ Capture 1 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC1OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
$00002000 constant LPTIM3_LPTIM3_ISR_INPUT_CC2OF                    \ Capture 2 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC2OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00004000 constant LPTIM3_LPTIM3_ISR_INPUT_CC3OF                    \ Capture 3 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC3OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00008000 constant LPTIM3_LPTIM3_ISR_INPUT_CC4OF                    \ Capture 4 over-capture flag This flag is set by hardware only when the corresponding channel is configured in input capture mode. It is cleared by software by writing 1 to the CC4OCF bit in the LPTIM_ICR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$01000000 constant LPTIM3_LPTIM3_ISR_INPUT_DIEROK                   \ Interrupt enable register update OK DIEROK is set by hardware to inform application that the APB bus write operation to the LPTIM_DIER register has been successfully completed. DIEROK flag can be cleared by writing 1 to the DIEROKCF bit in the LPTIM_ICR register.


\
\ @brief LPTIM3 interrupt clear register [alternate]
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_ICR_OUTPUT_CC1CF                   \ Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
$00000002 constant LPTIM3_LPTIM3_ICR_OUTPUT_ARRMCF                  \ Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
$00000004 constant LPTIM3_LPTIM3_ICR_OUTPUT_EXTTRIGCF               \ External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
$00000008 constant LPTIM3_LPTIM3_ICR_OUTPUT_CMP1OKCF                \ Compare register 1 update OK clear flag Writing 1 to this bit clears the CMP1OK flag in the LPTIM_ISR register.
$00000010 constant LPTIM3_LPTIM3_ICR_OUTPUT_ARROKCF                 \ Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
$00000020 constant LPTIM3_LPTIM3_ICR_OUTPUT_UPCF                    \ Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000040 constant LPTIM3_LPTIM3_ICR_OUTPUT_DOWNCF                  \ Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000080 constant LPTIM3_LPTIM3_ICR_OUTPUT_UECF                    \ Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
$00000100 constant LPTIM3_LPTIM3_ICR_OUTPUT_REPOKCF                 \ Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
$00000200 constant LPTIM3_LPTIM3_ICR_OUTPUT_CC2CF                   \ Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00000400 constant LPTIM3_LPTIM3_ICR_OUTPUT_CC3CF                   \ Capture/compare 3 clear flag Writing 1 to this bit clears the CC3IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00000800 constant LPTIM3_LPTIM3_ICR_OUTPUT_CC4CF                   \ Capture/compare 4 clear flag Writing 1 to this bit clears the CC4IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$00080000 constant LPTIM3_LPTIM3_ICR_OUTPUT_CMP2OKCF                \ Compare register 2 update OK clear flag Writing 1 to this bit clears the CMP2OK flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00100000 constant LPTIM3_LPTIM3_ICR_OUTPUT_CMP3OKCF                \ Compare register 3 update OK clear flag Writing 1 to this bit clears the CMP3OK flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00200000 constant LPTIM3_LPTIM3_ICR_OUTPUT_CMP4OKCF                \ Compare register 4 update OK clear flag Writing 1 to this bit clears the CMP4OK flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$01000000 constant LPTIM3_LPTIM3_ICR_OUTPUT_DIEROKCF                \ Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.


\
\ @brief LPTIM3 interrupt clear register [alternate]
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_ICR_INPUT_CC1CF                    \ Capture/compare 1 clear flag Writing 1 to this bit clears the CC1IF flag in the LPTIM_ISR register.
$00000002 constant LPTIM3_LPTIM3_ICR_INPUT_ARRMCF                   \ Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
$00000004 constant LPTIM3_LPTIM3_ICR_INPUT_EXTTRIGCF                \ External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
$00000010 constant LPTIM3_LPTIM3_ICR_INPUT_ARROKCF                  \ Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
$00000020 constant LPTIM3_LPTIM3_ICR_INPUT_UPCF                     \ Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000040 constant LPTIM3_LPTIM3_ICR_INPUT_DOWNCF                   \ Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000080 constant LPTIM3_LPTIM3_ICR_INPUT_UECF                     \ Update event clear flag Writing 1 to this bit clear the UE flag in the LPTIM_ISR register.
$00000100 constant LPTIM3_LPTIM3_ICR_INPUT_REPOKCF                  \ Repetition register update OK clear flag Writing 1 to this bit clears the REPOK flag in the LPTIM_ISR register.
$00000200 constant LPTIM3_LPTIM3_ICR_INPUT_CC2CF                    \ Capture/compare 2 clear flag Writing 1 to this bit clears the CC2IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00000400 constant LPTIM3_LPTIM3_ICR_INPUT_CC3CF                    \ Capture/compare 3 clear flag Writing 1 to this bit clears the CC3IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00000800 constant LPTIM3_LPTIM3_ICR_INPUT_CC4CF                    \ Capture/compare 4 clear flag Writing 1 to this bit clears the CC4IF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$00001000 constant LPTIM3_LPTIM3_ICR_INPUT_CC1OCF                   \ Capture/compare 1 over-capture clear flag Writing 1 to this bit clears the CC1OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
$00002000 constant LPTIM3_LPTIM3_ICR_INPUT_CC2OCF                   \ Capture/compare 2 over-capture clear flag Writing 1 to this bit clears the CC2OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00004000 constant LPTIM3_LPTIM3_ICR_INPUT_CC3OCF                   \ Capture/compare 3 over-capture clear flag Writing 1 to this bit clears the CC3OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00008000 constant LPTIM3_LPTIM3_ICR_INPUT_CC4OCF                   \ Capture/compare 4 over-capture clear flag Writing 1 to this bit clears the CC4OF flag in the LPTIM_ISR register. Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$01000000 constant LPTIM3_LPTIM3_ICR_INPUT_DIEROKCF                 \ Interrupt enable register update OK clear flag Writing 1 to this bit clears the DIEROK flag in the LPTIM_ISR register.


\
\ @brief LPTIM3 interrupt enable register [alternate]
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_DIER_OUTPUT_CC1IE                  \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM3_LPTIM3_DIER_OUTPUT_ARRMIE                 \ Autoreload match Interrupt Enable
$00000004 constant LPTIM3_LPTIM3_DIER_OUTPUT_EXTTRIGIE              \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM3_LPTIM3_DIER_OUTPUT_CMP1OKIE               \ Compare register 1 update OK interrupt enable
$00000010 constant LPTIM3_LPTIM3_DIER_OUTPUT_ARROKIE                \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM3_LPTIM3_DIER_OUTPUT_UPIE                   \ Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000040 constant LPTIM3_LPTIM3_DIER_OUTPUT_DOWNIE                 \ Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000080 constant LPTIM3_LPTIM3_DIER_OUTPUT_UEIE                   \ Update event interrupt enable
$00000100 constant LPTIM3_LPTIM3_DIER_OUTPUT_REPOKIE                \ Repetition register update OK interrupt Enable
$00000200 constant LPTIM3_LPTIM3_DIER_OUTPUT_CC2IE                  \ Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00000400 constant LPTIM3_LPTIM3_DIER_OUTPUT_CC3IE                  \ Capture/compare 3 interrupt enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00000800 constant LPTIM3_LPTIM3_DIER_OUTPUT_CC4IE                  \ Capture/compare 4 interrupt enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$00080000 constant LPTIM3_LPTIM3_DIER_OUTPUT_CMP2OKIE               \ Compare register 2 update OK interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00100000 constant LPTIM3_LPTIM3_DIER_OUTPUT_CMP3OKIE               \ Compare register 3 update OK interrupt enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00200000 constant LPTIM3_LPTIM3_DIER_OUTPUT_CMP4OKIE               \ Compare register 4 update OK interrupt enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$00800000 constant LPTIM3_LPTIM3_DIER_OUTPUT_UEDE                   \ Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.


\
\ @brief LPTIM3 interrupt enable register [alternate]
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_DIER_INPUT_CC1IE                   \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM3_LPTIM3_DIER_INPUT_ARRMIE                  \ Autoreload match Interrupt Enable
$00000004 constant LPTIM3_LPTIM3_DIER_INPUT_EXTTRIGIE               \ External trigger valid edge Interrupt Enable
$00000010 constant LPTIM3_LPTIM3_DIER_INPUT_ARROKIE                 \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM3_LPTIM3_DIER_INPUT_UPIE                    \ Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000040 constant LPTIM3_LPTIM3_DIER_INPUT_DOWNIE                  \ Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.
$00000080 constant LPTIM3_LPTIM3_DIER_INPUT_UEIE                    \ Update event interrupt enable
$00000100 constant LPTIM3_LPTIM3_DIER_INPUT_REPOKIE                 \ Repetition register update OK interrupt Enable
$00000200 constant LPTIM3_LPTIM3_DIER_INPUT_CC2IE                   \ Capture/compare 2 interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00000400 constant LPTIM3_LPTIM3_DIER_INPUT_CC3IE                   \ Capture/compare 3 interrupt enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00000800 constant LPTIM3_LPTIM3_DIER_INPUT_CC4IE                   \ Capture/compare 4 interrupt enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$00001000 constant LPTIM3_LPTIM3_DIER_INPUT_CC1OIE                  \ Capture/compare 1 over-capture interrupt enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
$00002000 constant LPTIM3_LPTIM3_DIER_INPUT_CC2OIE                  \ Capture/compare 2 over-capture interrupt enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$00004000 constant LPTIM3_LPTIM3_DIER_INPUT_CC3OIE                  \ Capture/compare 3 over-capture interrupt enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$00008000 constant LPTIM3_LPTIM3_DIER_INPUT_CC4OIE                  \ Capture/compare 4 over-capture interrupt enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.
$00010000 constant LPTIM3_LPTIM3_DIER_INPUT_CC1DE                   \ Capture/compare 1 DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
$00800000 constant LPTIM3_LPTIM3_DIER_INPUT_UEDE                    \ Update event DMA request enable Note: If LPTIM does not implement at least 1 channel this bit is reserved. Refer to Section125.3.
$02000000 constant LPTIM3_LPTIM3_DIER_INPUT_CC2DE                   \ Capture/compare 2 DMA request enable Note: If LPTIM does not implement at least 2 channels this bit is reserved. Refer to Section125.3.
$04000000 constant LPTIM3_LPTIM3_DIER_INPUT_CC3DE                   \ Capture/compare 3 DMA request enable Note: If LPTIM does not implement at least 3 channels this bit is reserved. Refer to Section125.3.
$08000000 constant LPTIM3_LPTIM3_DIER_INPUT_CC4DE                   \ Capture/compare 4 DMA request enable Note: If LPTIM does not implement at least 4 channels this bit is reserved. Refer to Section125.3.


\
\ @brief LPTIM configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_CFGR_CKSEL                         \ Clock selector The CKSEL bit selects which clock source the LPTIM uses:
$00000006 constant LPTIM3_LPTIM3_CFGR_CKPOL                         \ Clock Polarity When the LPTIM is clocked by an external clock source, CKPOL bits is used to configure the active edge or edges used by the counter: If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 1 is active. If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 2 is active. If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 3 is active. Refer to Section125.4.15: Encoder mode for more details about Encoder mode sub-modes.
$00000018 constant LPTIM3_LPTIM3_CFGR_CKFLT                         \ Configurable digital filter for external clock The CKFLT value sets the number of consecutive equal samples that are detected when a level change occurs on an external clock signal before it is considered as a valid level transition. An internal clock source must be present to use this feature
$000000c0 constant LPTIM3_LPTIM3_CFGR_TRGFLT                        \ Configurable digital filter for trigger The TRGFLT value sets the number of consecutive equal samples that are detected when a level change occurs on an internal trigger before it is considered as a valid level transition. An internal clock source must be present to use this feature
$00000e00 constant LPTIM3_LPTIM3_CFGR_PRESC                         \ Clock prescaler The PRESC bits configure the prescaler division factor. It can be one among the following division factors:
$0000e000 constant LPTIM3_LPTIM3_CFGR_TRIGSEL                       \ Trigger selector The TRIGSEL bits select the trigger source that serves as a trigger event for the LPTIM among the below 8 available sources: See Section125.4.3: LPTIM input and trigger mapping for details.
$00060000 constant LPTIM3_LPTIM3_CFGR_TRIGEN                        \ Trigger enable and polarity The TRIGEN bits controls whether the LPTIM counter is started by an external trigger or not. If the external trigger option is selected, three configurations are possible for the trigger active edge:
$00080000 constant LPTIM3_LPTIM3_CFGR_TIMOUT                        \ Timeout enable The TIMOUT bit controls the Timeout feature
$00100000 constant LPTIM3_LPTIM3_CFGR_WAVE                          \ Waveform shape The WAVE bit controls the output shape
$00400000 constant LPTIM3_LPTIM3_CFGR_PRELOAD                       \ Registers update mode The PRELOAD bit controls the LPTIM3_ARR, LPTIM3_RCR and the LPTIM3_CCRx registers update modality
$00800000 constant LPTIM3_LPTIM3_CFGR_COUNTMODE                     \ counter mode enabled The COUNTMODE bit selects which clock source is used by the LPTIM to clock the counter:
$01000000 constant LPTIM3_LPTIM3_CFGR_ENC                           \ Encoder mode enable The ENC bit controls the Encoder mode Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Refer to Section125.3.


\
\ @brief LPTIM control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_CR_ENABLE                          \ LPTIM enable The ENABLE bit is set and cleared by software.
$00000002 constant LPTIM3_LPTIM3_CR_SNGSTRT                         \ LPTIM start in Single mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = 00), setting this bit starts the LPTIM in single pulse mode. If the software start is disabled (TRIGEN[1:0] different than 00), setting this bit starts the LPTIM in single pulse mode as soon as an external trigger is detected. If this bit is set when the LPTIM is in continuous counting mode, then the LPTIM stops at the following match between LPTIM3_ARR and LPTIM3_CNT registers. This bit can only be set when the LPTIM is enabled. It is automatically reset by hardware.
$00000004 constant LPTIM3_LPTIM3_CR_CNTSTRT                         \ Timer start in Continuous mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = 00), setting this bit starts the LPTIM in Continuous mode. If the software start is disabled (TRIGEN[1:0] different than 00), setting this bit starts the timer in Continuous mode as soon as an external trigger is detected. If this bit is set when a single pulse mode counting is ongoing, then the timer does not stop at the next match between the LPTIM3_ARR and LPTIM3_CNT registers and the LPTIM counter keeps counting in Continuous mode. This bit can be set only when the LPTIM is enabled. It is automatically reset by hardware.
$00000008 constant LPTIM3_LPTIM3_CR_COUNTRST                        \ Counter reset This bit is set by software and cleared by hardware. When set to '1' this bit triggers a synchronous reset of the LPTIM3_CNT counter register. Due to the synchronous nature of this reset, it only takes place after a synchronization delay of 3 LPTimer core clock cycles (LPTimer core clock may be different from APB clock). This bit can be set only when the LPTIM is enabled. It is automatically reset by hardware. COUNTRST must never be set to '1' by software before it is already cleared to '0' by hardware. Software must consequently check that COUNTRST bit is already cleared to '0' before attempting to set it to '1'.
$00000010 constant LPTIM3_LPTIM3_CR_RSTARE                          \ Reset after read enable This bit is set and cleared by software. When RSTARE is set to '1', any read access to LPTIM3_CNT register asynchronously resets LPTIM3_CNT register content. This bit can be set only when the LPTIM is enabled.


\
\ @brief LPTIM compare register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM3_LPTIM3_CCR1_CCR1                          \ Capture/compare 1 value If channel CC1 is configured as output: CCR1 is the value to be loaded in the capture/compare 1 register. Depending on the PRELOAD option, the CCR1 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 1 contains the value to be compared to the counter LPTIM3_CNT and signaled on OC1 output. If channel CC1 is configured as input: CCR1 becomes read-only, it contains the counter value transferred by the last input capture 1 event. The LPTIM3_CCR1 register is read-only and cannot be programmed.


\
\ @brief LPTIM autoreload register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIM3_LPTIM3_ARR_ARR                            \ Auto reload value ARR is the autoreload value for the LPTIM. This value must be strictly greater than the CCRx[15:0] value.


\
\ @brief LPTIM counter register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM3_LPTIM3_CNT_CNT                            \ Counter value When the LPTIM is running with an asynchronous clock, reading the LPTIM3_CNT register may return unreliable values. So in this case it is necessary to perform two consecutive read accesses and verify that the two returned values are identical.


\
\ @brief LPTIM configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant LPTIM3_LPTIM3_CFGR2_IN1SEL                       \ LPTIM input 1 selection The IN1SEL bits control the LPTIM input 1 multiplexer, which connects LPTIM input 1 to one of the available inputs. For connection details refer to Section125.4.3: LPTIM input and trigger mapping.
$00000030 constant LPTIM3_LPTIM3_CFGR2_IN2SEL                       \ LPTIM input 2 selection The IN2SEL bits control the LPTIM input 2 multiplexer, which connects LPTIM input 2 to one of the available inputs. For connection details refer to Section125.4.3: LPTIM input and trigger mapping.
$00030000 constant LPTIM3_LPTIM3_CFGR2_IC1SEL                       \ LPTIM input capture 1 selection The IC1SEL bits control the LPTIM Input capture 1 multiplexer, which connects LPTIM Input capture 1 to one of the available inputs. For connection details refer to Section125.4.3: LPTIM input and trigger mapping.
$00300000 constant LPTIM3_LPTIM3_CFGR2_IC2SEL                       \ LPTIM input capture 2 selection The IC2SEL bits control the LPTIM Input capture 2 multiplexer, which connects LPTIM Input capture 2 to one of the available inputs. For connection details refer to Section125.4.3: LPTIM input and trigger mapping.


\
\ @brief LPTIM repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant LPTIM3_LPTIM3_RCR_REP                            \ Repetition register value REP is the repetition value for the LPTIM.


\
\ @brief LPTIM capture/compare mode register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_CCMR1_CC1SEL                       \ Capture/compare 1 selection This bitfield defines the direction of the channel input (capture) or output mode.
$00000002 constant LPTIM3_LPTIM3_CCMR1_CC1E                         \ Capture/compare 1 output enable. This bit determines if a capture of the counter value can actually be done into the input capture/compare register 1 (LPTIM3_CCR1) or not.
$0000000c constant LPTIM3_LPTIM3_CCMR1_CC1P                         \ Capture/compare 1 output polarity. Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. This field is used to select the IC1 polarity for capture operations.
$00000300 constant LPTIM3_LPTIM3_CCMR1_IC1PSC                       \ Input capture 1 prescaler This bitfield defines the ratio of the prescaler acting on the CC1 input (IC1).
$00003000 constant LPTIM3_LPTIM3_CCMR1_IC1F                         \ Input capture 1 filter This bitfield defines the number of consecutive equal samples that are detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.
$00010000 constant LPTIM3_LPTIM3_CCMR1_CC2SEL                       \ Capture/compare 2 selection This bitfield defines the direction of the channel, input (capture) or output mode.
$00020000 constant LPTIM3_LPTIM3_CCMR1_CC2E                         \ Capture/compare 2 output enable. This bit determines if a capture of the counter value can actually be done into the input capture/compare register 2 (LPTIM3_CCR2) or not.
$000c0000 constant LPTIM3_LPTIM3_CCMR1_CC2P                         \ Capture/compare 2 output polarity. Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. This field is used to select the IC2 polarity for capture operations.
$03000000 constant LPTIM3_LPTIM3_CCMR1_IC2PSC                       \ Input capture 2 prescaler This bitfield defines the ratio of the prescaler acting on the CC2 input (IC2).
$30000000 constant LPTIM3_LPTIM3_CCMR1_IC2F                         \ Input capture 2 filter This bitfield defines the number of consecutive equal samples that are detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.


\
\ @brief LPTIM capture/compare mode register 2
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_CCMR2_CC3SEL                       \ Capture/compare 3 selection This bitfield defines the direction of the channel input (capture) or output mode.
$00000002 constant LPTIM3_LPTIM3_CCMR2_CC3E                         \ Capture/compare 3 output enable. Condition: CC3 as output: Condition: CC3 as input: This bit determines if a capture of the counter value can actually be done into the input capture/compare register 3 (LPTIM3_CCR3) or not.
$0000000c constant LPTIM3_LPTIM3_CCMR2_CC3P                         \ Capture/compare 3 output polarity. Condition: CC3 as output: Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. Condition: CC3 as input: This field is used to select the IC3 polarity for capture operations.
$00000300 constant LPTIM3_LPTIM3_CCMR2_IC3PSC                       \ Input capture 3 prescaler This bitfield defines the ratio of the prescaler acting on the CC3 input (IC3).
$00003000 constant LPTIM3_LPTIM3_CCMR2_IC3F                         \ Input capture 3 filter This bitfield defines the number of consecutive equal samples that should be detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.
$00010000 constant LPTIM3_LPTIM3_CCMR2_CC4SEL                       \ Capture/compare 4 selection This bitfield defines the direction of the channel, input (capture) or output mode.
$00020000 constant LPTIM3_LPTIM3_CCMR2_CC4E                         \ Capture/compare 4 output enable. Condition: CC4 as output: Condition: CC4 as input: This bit determines if a capture of the counter value can actually be done into the input capture/compare register 4 (LPTIM3_CCR4) or not.
$000c0000 constant LPTIM3_LPTIM3_CCMR2_CC4P                         \ Capture/compare 4 output polarity. Condition: CC4 as output: Only bit2 is used to set polarity when output mode is enabled, bit3 is don't care. Condition: CC4 as input: This field is used to select the IC4 polarity for capture operations.
$03000000 constant LPTIM3_LPTIM3_CCMR2_IC4PSC                       \ Input capture 4 prescaler This bitfield defines the ratio of the prescaler acting on the CC4 input (IC4).
$30000000 constant LPTIM3_LPTIM3_CCMR2_IC4F                         \ Input capture 4 filter This bitfield defines the number of consecutive equal samples that should be detected when a level change occurs on an external input capture signal before it is considered as a valid level transition. An internal clock source must be present to use this feature.


\
\ @brief LPTIM compare register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM3_LPTIM3_CCR2_CCR2                          \ Capture/compare 2 value If channel CC2 is configured as output: CCR2 is the value to be loaded in the capture/compare 2 register. Depending on the PRELOAD option, the CCR2 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 2 contains the value to be compared to the counter LPTIM3_CNT and signaled on OC2 output. If channel CC2 is configured as input: CCR2 becomes read-only, it contains the counter value transferred by the last input capture 2 event. The LPTIM3_CCR2 register is read-only and cannot be programmed.


\
\ @brief LPTIM compare register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM3_LPTIM3_CCR3_CCR3                          \ Capture/compare 3 value If channel CC3 is configured as output: CCR3 is the value to be loaded in the capture/compare 3 register. Depending on the PRELOAD option, the CCR3 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 3 contains the value to be compared to the counter LPTIM3_CNT and signaled on OC3 output. If channel CC3 is configured as input: CCR3 becomes read-only, it contains the counter value transferred by the last input capture 3 event. The LPTIM3_CCR3 register is read-only and cannot be programmed.


\
\ @brief LPTIM compare register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM3_LPTIM3_CCR4_CCR4                          \ Capture/compare 4 value If channel CC4 is configured as output: CCR4 is the value to be loaded in the capture/compare 4 register. Depending on the PRELOAD option, the CCR4 register is immediately updated if the PRELOAD bit is reset and updated at next LPTIM update event if PREOAD bit is reset. The capture/compare register 4 contains the value to be compared to the counter LPTIM3_CNT and signaled on OC4 output. If channel CC4 is configured as input: CCR4 becomes read-only, it contains the counter value transferred by the last input capture 4 event. The LPTIM3_CCR4 register is read-only and cannot be programmed.


\
\ @brief LPTIM3 address block description
\
$40009000 constant LPTIM3_LPTIM3_ISR_OUTPUT  \ offset: 0x00 : LPTIM3 interrupt and status register [alternate]
$40009000 constant LPTIM3_LPTIM3_ISR_INPUT  \ offset: 0x00 : LPTIM3 interrupt and status register [alternate]
$40009004 constant LPTIM3_LPTIM3_ICR_OUTPUT  \ offset: 0x04 : LPTIM3 interrupt clear register [alternate]
$40009004 constant LPTIM3_LPTIM3_ICR_INPUT  \ offset: 0x04 : LPTIM3 interrupt clear register [alternate]
$40009008 constant LPTIM3_LPTIM3_DIER_OUTPUT  \ offset: 0x08 : LPTIM3 interrupt enable register [alternate]
$40009008 constant LPTIM3_LPTIM3_DIER_INPUT  \ offset: 0x08 : LPTIM3 interrupt enable register [alternate]
$4000900c constant LPTIM3_LPTIM3_CFGR  \ offset: 0x0C : LPTIM configuration register
$40009010 constant LPTIM3_LPTIM3_CR  \ offset: 0x10 : LPTIM control register
$40009014 constant LPTIM3_LPTIM3_CCR1  \ offset: 0x14 : LPTIM compare register 1
$40009018 constant LPTIM3_LPTIM3_ARR  \ offset: 0x18 : LPTIM autoreload register
$4000901c constant LPTIM3_LPTIM3_CNT  \ offset: 0x1C : LPTIM counter register
$40009024 constant LPTIM3_LPTIM3_CFGR2  \ offset: 0x24 : LPTIM configuration register 2
$40009028 constant LPTIM3_LPTIM3_RCR  \ offset: 0x28 : LPTIM repetition register
$4000902c constant LPTIM3_LPTIM3_CCMR1  \ offset: 0x2C : LPTIM capture/compare mode register 1
$40009030 constant LPTIM3_LPTIM3_CCMR2  \ offset: 0x30 : LPTIM capture/compare mode register 2
$40009034 constant LPTIM3_LPTIM3_CCR2  \ offset: 0x34 : LPTIM compare register 2
$40009038 constant LPTIM3_LPTIM3_CCR3  \ offset: 0x38 : LPTIM compare register 3
$4000903c constant LPTIM3_LPTIM3_CCR4  \ offset: 0x3C : LPTIM compare register 4

