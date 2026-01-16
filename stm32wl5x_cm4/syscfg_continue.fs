\
\ @file syscfg_continue.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief IMR1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CONTINUE_IMR1_RTCSTAMPTAMPLSECSSIM        \ RTCSTAMPTAMPLSECSSIM
$00000004 constant SYSCFG_CONTINUE_IMR1_RTCSSRUIM                   \ RTCSSRUIM
$00200000 constant SYSCFG_CONTINUE_IMR1_EXTI5IM                     \ Peripheral EXTI5 interrupt mask to CPU1
$00400000 constant SYSCFG_CONTINUE_IMR1_EXTI6IM                     \ Peripheral EXTI6 interrupt mask to CPU1
$00800000 constant SYSCFG_CONTINUE_IMR1_EXTI7IM                     \ Peripheral EXTI7 interrupt mask to CPU1
$01000000 constant SYSCFG_CONTINUE_IMR1_EXTI8IM                     \ Peripheral EXTI8 interrupt mask to CPU1
$02000000 constant SYSCFG_CONTINUE_IMR1_EXTI9IM                     \ Peripheral EXTI9 interrupt mask to CPU1
$04000000 constant SYSCFG_CONTINUE_IMR1_EXTI10IM                    \ Peripheral EXTI10 interrupt mask to CPU1
$08000000 constant SYSCFG_CONTINUE_IMR1_EXTI11IM                    \ Peripheral EXTI11 interrupt mask to CPU1
$10000000 constant SYSCFG_CONTINUE_IMR1_EXTI12IM                    \ Peripheral EXTI12 interrupt mask to CPU1
$20000000 constant SYSCFG_CONTINUE_IMR1_EXTI13IM                    \ Peripheral EXTI13 interrupt mask to CPU1
$40000000 constant SYSCFG_CONTINUE_IMR1_EXTI14IM                    \ Peripheral EXTI14 interrupt mask to CPU1
$80000000 constant SYSCFG_CONTINUE_IMR1_EXTI15IM                    \ Peripheral EXTI15 interrupt mask to CPU1


\
\ @brief IMR2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00040000 constant SYSCFG_CONTINUE_IMR2_PVM3IM                      \ Peripheral xxx interrupt mask to CPU1
$00100000 constant SYSCFG_CONTINUE_IMR2_PVDIM                       \ Peripheral xxx interrupt mask to CPU1


\
\ @brief C2IMR1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CONTINUE_C2IMR1_RTCSTAMPTAMPLSECSSIM      \ Peripheral RTCSTAMPTAMPLSECSS interrupt mask to CPU2
$00000002 constant SYSCFG_CONTINUE_C2IMR1_RTCALARMIM                \ Peripheral RTCALARM interrupt mask to CPU2
$00000004 constant SYSCFG_CONTINUE_C2IMR1_RTCSSRUIM                 \ RTCSSRUIM
$00000008 constant SYSCFG_CONTINUE_C2IMR1_RTCWKUPIM                 \ Peripheral RTCWKUP interrupt mask to CPU2
$00000020 constant SYSCFG_CONTINUE_C2IMR1_RCCIM                     \ Peripheral RCC interrupt mask to CPU2
$00000040 constant SYSCFG_CONTINUE_C2IMR1_FLASHIM                   \ Peripheral FLASH interrupt mask to CPU2
$00000100 constant SYSCFG_CONTINUE_C2IMR1_PKAIM                     \ PKAIM
$00000400 constant SYSCFG_CONTINUE_C2IMR1_AES1IM                    \ AES1IM
$00000800 constant SYSCFG_CONTINUE_C2IMR1_COMPIM                    \ Peripheral COMP interrupt mask to CPU2
$00001000 constant SYSCFG_CONTINUE_C2IMR1_ADCIM                     \ Peripheral ADC interrupt mask to CPU2
$00002000 constant SYSCFG_CONTINUE_C2IMR1_DAC1IM                    \ Peripheral DAC1 interrupt mask to CPU2
$00010000 constant SYSCFG_CONTINUE_C2IMR1_EXTI0IM                   \ Peripheral EXTI0 interrupt mask to CPU2
$00020000 constant SYSCFG_CONTINUE_C2IMR1_EXTI1IM                   \ Peripheral EXTI1 interrupt mask to CPU2
$00040000 constant SYSCFG_CONTINUE_C2IMR1_EXTI2IM                   \ Peripheral EXTI2 interrupt mask to CPU2
$00080000 constant SYSCFG_CONTINUE_C2IMR1_EXTI3IM                   \ Peripheral EXTI3 interrupt mask to CPU2
$00100000 constant SYSCFG_CONTINUE_C2IMR1_EXTI4IM                   \ Peripheral EXTI4 interrupt mask to CPU2
$00200000 constant SYSCFG_CONTINUE_C2IMR1_EXTI5IM                   \ Peripheral EXTI5 interrupt mask to CPU2
$00400000 constant SYSCFG_CONTINUE_C2IMR1_EXTI6IM                   \ Peripheral EXTI6 interrupt mask to CPU2
$00800000 constant SYSCFG_CONTINUE_C2IMR1_EXTI7IM                   \ Peripheral EXTI7 interrupt mask to CPU2
$01000000 constant SYSCFG_CONTINUE_C2IMR1_EXTI8IM                   \ Peripheral EXTI8 interrupt mask to CPU2
$02000000 constant SYSCFG_CONTINUE_C2IMR1_EXTI9IM                   \ Peripheral EXTI9 interrupt mask to CPU2
$04000000 constant SYSCFG_CONTINUE_C2IMR1_EXTI10IM                  \ Peripheral EXTI10 interrupt mask to CPU2
$08000000 constant SYSCFG_CONTINUE_C2IMR1_EXTI11IM                  \ Peripheral EXTI11 interrupt mask to CPU2
$10000000 constant SYSCFG_CONTINUE_C2IMR1_EXTI12IM                  \ Peripheral EXTI12 interrupt mask to CPU2
$20000000 constant SYSCFG_CONTINUE_C2IMR1_EXTI13IM                  \ Peripheral EXTI13 interrupt mask to CPU2
$40000000 constant SYSCFG_CONTINUE_C2IMR1_EXTI14IM                  \ Peripheral EXTI14 interrupt mask to CPU2
$80000000 constant SYSCFG_CONTINUE_C2IMR1_EXTI15IM                  \ Peripheral EXTI15 interrupt mask to CPU2


\
\ @brief C2IMR2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CONTINUE_C2IMR2_DMA1CH1IM                 \ Peripheral DMA1CH1 interrupt mask to CPU2
$00000002 constant SYSCFG_CONTINUE_C2IMR2_DMA1CH2IM                 \ Peripheral DMA1CH2 interrupt mask to CPU2
$00000004 constant SYSCFG_CONTINUE_C2IMR2_DMA1CH3IM                 \ Peripheral DMA1CH3 interrupt mask to CPU2
$00000008 constant SYSCFG_CONTINUE_C2IMR2_DMA1CH4IM                 \ Peripheral DMA1CH4 interrupt mask to CPU2
$00000010 constant SYSCFG_CONTINUE_C2IMR2_DMA1CH5IM                 \ Peripheral DMA1CH5 interrupt mask to CPU2
$00000020 constant SYSCFG_CONTINUE_C2IMR2_DMA1CH6IM                 \ Peripheral DMA1CH6 interrupt mask to CPU2
$00000040 constant SYSCFG_CONTINUE_C2IMR2_DMA1CH7IM                 \ Peripheral DMA1CH7 interrupt mask to CPU2
$00000100 constant SYSCFG_CONTINUE_C2IMR2_DMA2CH1IM                 \ Peripheral DMA2CH1 interrupt mask to CPU2
$00000200 constant SYSCFG_CONTINUE_C2IMR2_DMA2CH2IM                 \ Peripheral DMA2CH2 interrupt mask to CPU2
$00000400 constant SYSCFG_CONTINUE_C2IMR2_DMA2CH3IM                 \ Peripheral DMA2CH3 interrupt mask to CPU2
$00000800 constant SYSCFG_CONTINUE_C2IMR2_DMA2CH4IM                 \ Peripheral DMA2CH4 interrupt mask to CPU2
$00001000 constant SYSCFG_CONTINUE_C2IMR2_DMA2CH5IM                 \ Peripheral DMA2CH5 interrupt mask to CPU2
$00002000 constant SYSCFG_CONTINUE_C2IMR2_DMA2CH6IM                 \ Peripheral DMA2CH6 interrupt mask to CPU2
$00004000 constant SYSCFG_CONTINUE_C2IMR2_DMA2CH7IM                 \ Peripheral DMA2CH7 interrupt mask to CPU2
$00008000 constant SYSCFG_CONTINUE_C2IMR2_DMAMUX1IM                 \ Peripheral DMAMUX1 interrupt mask to CPU2
$00040000 constant SYSCFG_CONTINUE_C2IMR2_PVM3IM                    \ Peripheral PVM3 interrupt mask to CPU2
$00100000 constant SYSCFG_CONTINUE_C2IMR2_PVDIM                     \ Peripheral PVD interrupt mask to CPU2


\
\ @brief System configuration controller
\
$40010100 constant SYSCFG_CONTINUE_IMR1  \ offset: 0x00 : IMR1
$40010104 constant SYSCFG_CONTINUE_IMR2  \ offset: 0x04 : IMR2
$40010108 constant SYSCFG_CONTINUE_C2IMR1  \ offset: 0x08 : C2IMR1
$4001010c constant SYSCFG_CONTINUE_C2IMR2  \ offset: 0x0C : C2IMR2

