\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief memory remap register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000007 constant SYSCFG_MEMRMP_MEM_MODE                           \ Memory mapping selection


\
\ @brief configuration register 1
\ Address offset: 0x04
\ Reset value: 0x7C000001
\

$00000100 constant SYSCFG_CFGR1_BOOSTEN                             \ I/O analog switch voltage booster enable
$00010000 constant SYSCFG_CFGR1_I2C_PB6_FMP                         \ Fast-mode Plus (Fm+) driving capability activation on PB6
$00020000 constant SYSCFG_CFGR1_I2C_PB7_FMP                         \ Fast-mode Plus (Fm+) driving capability activation on PB7
$00040000 constant SYSCFG_CFGR1_I2C_PB8_FMP                         \ Fast-mode Plus (Fm+) driving capability activation on PB8
$00080000 constant SYSCFG_CFGR1_I2C_PB9_FMP                         \ Fast-mode Plus (Fm+) driving capability activation on PB9
$00100000 constant SYSCFG_CFGR1_I2C1_FMP                            \ I2C1 Fast-mode Plus driving capability activation
$00400000 constant SYSCFG_CFGR1_I2C3_FMP                            \ I2C3 Fast-mode Plus driving capability activation
$fc000000 constant SYSCFG_CFGR1_FPU_IE                              \ Floating Point Unit interrupts enable bits


\
\ @brief external interrupt configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant SYSCFG_EXTICR1_EXTI0                             \ EXTI 0 configuration bits
$00000070 constant SYSCFG_EXTICR1_EXTI1                             \ EXTI 1 configuration bits
$00000700 constant SYSCFG_EXTICR1_EXTI2                             \ EXTI 2 configuration bits
$00007000 constant SYSCFG_EXTICR1_EXTI3                             \ EXTI 3 configuration bits


\
\ @brief external interrupt configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000007 constant SYSCFG_EXTICR2_EXTI4                             \ EXTI 4 configuration bits
$00000070 constant SYSCFG_EXTICR2_EXTI5                             \ EXTI 5 configuration bits
$00000700 constant SYSCFG_EXTICR2_EXTI6                             \ EXTI 6 configuration bits
$00007000 constant SYSCFG_EXTICR2_EXTI7                             \ EXTI 7 configuration bits


\
\ @brief external interrupt configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000007 constant SYSCFG_EXTICR3_EXTI8                             \ EXTI 8 configuration bits
$00000070 constant SYSCFG_EXTICR3_EXTI9                             \ EXTI 9 configuration bits
$00000700 constant SYSCFG_EXTICR3_EXTI10                            \ EXTI 10 configuration bits
$00007000 constant SYSCFG_EXTICR3_EXTI11                            \ EXTI 11 configuration bits


\
\ @brief external interrupt configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant SYSCFG_EXTICR4_EXTI12                            \ EXTI12 configuration bits
$00000070 constant SYSCFG_EXTICR4_EXTI13                            \ EXTI13 configuration bits
$00000700 constant SYSCFG_EXTICR4_EXTI14                            \ EXTI14 configuration bits
$00007000 constant SYSCFG_EXTICR4_EXTI15                            \ EXTI15 configuration bits


\
\ @brief SCSR
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SCSR_SRAM2ER                              \ SRAM2 Erase
$00000002 constant SYSCFG_SCSR_SRAM2BSY                             \ SRAM2 busy by erase operation
$80000000 constant SYSCFG_SCSR_C2RFD                                \ CPU2 SRAM fetch (execution) disable.


\
\ @brief CFGR2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CFGR2_CLL                                 \ Cortex-M4 LOCKUP (Hardfault) output enable bit
$00000002 constant SYSCFG_CFGR2_SPL                                 \ SRAM2 parity lock bit
$00000004 constant SYSCFG_CFGR2_PVDL                                \ PVD lock enable bit
$00000008 constant SYSCFG_CFGR2_ECCL                                \ ECC Lock
$00000100 constant SYSCFG_CFGR2_SPF                                 \ SRAM2 parity error flag


\
\ @brief SRAM2 write protection register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SWPR_P0WP                                 \ P0WP
$00000002 constant SYSCFG_SWPR_P1WP                                 \ P1WP
$00000004 constant SYSCFG_SWPR_P2WP                                 \ P2WP
$00000008 constant SYSCFG_SWPR_P3WP                                 \ P3WP
$00000010 constant SYSCFG_SWPR_P4WP                                 \ P4WP
$00000020 constant SYSCFG_SWPR_P5WP                                 \ P5WP
$00000040 constant SYSCFG_SWPR_P6WP                                 \ P6WP
$00000080 constant SYSCFG_SWPR_P7WP                                 \ P7WP
$00000100 constant SYSCFG_SWPR_P8WP                                 \ P8WP
$00000200 constant SYSCFG_SWPR_P9WP                                 \ P9WP
$00000400 constant SYSCFG_SWPR_P10WP                                \ P10WP
$00000800 constant SYSCFG_SWPR_P11WP                                \ P11WP
$00001000 constant SYSCFG_SWPR_P12WP                                \ P12WP
$00002000 constant SYSCFG_SWPR_P13WP                                \ P13WP
$00004000 constant SYSCFG_SWPR_P14WP                                \ P14WP
$00008000 constant SYSCFG_SWPR_P15WP                                \ P15WP
$00010000 constant SYSCFG_SWPR_P16WP                                \ P16WP
$00020000 constant SYSCFG_SWPR_P17WP                                \ P17WP
$00040000 constant SYSCFG_SWPR_P18WP                                \ P18WP
$00080000 constant SYSCFG_SWPR_P19WP                                \ P19WP
$00100000 constant SYSCFG_SWPR_P20WP                                \ P20WP
$00200000 constant SYSCFG_SWPR_P21WP                                \ P21WP
$00400000 constant SYSCFG_SWPR_P22WP                                \ P22WP
$00800000 constant SYSCFG_SWPR_P23WP                                \ P23WP
$01000000 constant SYSCFG_SWPR_P24WP                                \ P24WP
$02000000 constant SYSCFG_SWPR_P25WP                                \ P25WP
$04000000 constant SYSCFG_SWPR_P26WP                                \ P26WP
$08000000 constant SYSCFG_SWPR_P27WP                                \ P27WP
$10000000 constant SYSCFG_SWPR_P28WP                                \ P28WP
$20000000 constant SYSCFG_SWPR_P29WP                                \ P29WP
$40000000 constant SYSCFG_SWPR_P30WP                                \ P30WP
$80000000 constant SYSCFG_SWPR_P31WP                                \ SRAM2 page 31 write protection


\
\ @brief SKR
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant SYSCFG_SKR_KEY                                   \ SRAM2 write protection key for software erase


\
\ @brief SRAM2 write protection register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SWPR2_P32WP                               \ P32WP
$00000002 constant SYSCFG_SWPR2_P33WP                               \ P33WP
$00000004 constant SYSCFG_SWPR2_P34WP                               \ P34WP
$00000008 constant SYSCFG_SWPR2_P35WP                               \ P35WP
$00000010 constant SYSCFG_SWPR2_P36WP                               \ P36WP
$00000020 constant SYSCFG_SWPR2_P37WP                               \ P37WP
$00000040 constant SYSCFG_SWPR2_P38WP                               \ P38WP
$00000080 constant SYSCFG_SWPR2_P39WP                               \ P39WP
$00000100 constant SYSCFG_SWPR2_P40WP                               \ P40WP
$00000200 constant SYSCFG_SWPR2_P41WP                               \ P41WP
$00000400 constant SYSCFG_SWPR2_P42WP                               \ P42WP
$00000800 constant SYSCFG_SWPR2_P43WP                               \ P43WP
$00001000 constant SYSCFG_SWPR2_P44WP                               \ P44WP
$00002000 constant SYSCFG_SWPR2_P45WP                               \ P45WP
$00004000 constant SYSCFG_SWPR2_P46WP                               \ P46WP
$00008000 constant SYSCFG_SWPR2_P47WP                               \ P47WP
$00010000 constant SYSCFG_SWPR2_P48WP                               \ P48WP
$00020000 constant SYSCFG_SWPR2_P49WP                               \ P49WP
$00040000 constant SYSCFG_SWPR2_P50WP                               \ P50WP
$00080000 constant SYSCFG_SWPR2_P51WP                               \ P51WP
$00100000 constant SYSCFG_SWPR2_P52WP                               \ P52WP
$00200000 constant SYSCFG_SWPR2_P53WP                               \ P53WP
$00400000 constant SYSCFG_SWPR2_P54WP                               \ P54WP
$00800000 constant SYSCFG_SWPR2_P55WP                               \ P55WP
$01000000 constant SYSCFG_SWPR2_P56WP                               \ P56WP
$02000000 constant SYSCFG_SWPR2_P57WP                               \ P57WP
$04000000 constant SYSCFG_SWPR2_P58WP                               \ P58WP
$08000000 constant SYSCFG_SWPR2_P59WP                               \ P59WP
$10000000 constant SYSCFG_SWPR2_P60WP                               \ P60WP
$20000000 constant SYSCFG_SWPR2_P61WP                               \ P61WP
$40000000 constant SYSCFG_SWPR2_P62WP                               \ P62WP
$80000000 constant SYSCFG_SWPR2_P63WP                               \ SRAM2 page 63 write protection


\
\ @brief CPU1 interrupt mask register 1
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00002000 constant SYSCFG_IMR1_TIM1IM                               \ Peripheral TIM1 interrupt mask to CPU1
$00004000 constant SYSCFG_IMR1_TIM16IM                              \ Peripheral TIM16 interrupt mask to CPU1
$00008000 constant SYSCFG_IMR1_TIM17IM                              \ Peripheral TIM17 interrupt mask to CPU1
$00200000 constant SYSCFG_IMR1_EXIT5IM                              \ Peripheral EXIT5 interrupt mask to CPU1
$00400000 constant SYSCFG_IMR1_EXIT6IM                              \ Peripheral EXIT6 interrupt mask to CPU1
$00800000 constant SYSCFG_IMR1_EXIT7IM                              \ Peripheral EXIT7 interrupt mask to CPU1
$01000000 constant SYSCFG_IMR1_EXIT8IM                              \ Peripheral EXIT8 interrupt mask to CPU1
$02000000 constant SYSCFG_IMR1_EXIT9IM                              \ Peripheral EXIT9 interrupt mask to CPU1
$04000000 constant SYSCFG_IMR1_EXIT10IM                             \ Peripheral EXIT10 interrupt mask to CPU1
$08000000 constant SYSCFG_IMR1_EXIT11IM                             \ Peripheral EXIT11 interrupt mask to CPU1
$10000000 constant SYSCFG_IMR1_EXIT12IM                             \ Peripheral EXIT12 interrupt mask to CPU1
$20000000 constant SYSCFG_IMR1_EXIT13IM                             \ Peripheral EXIT13 interrupt mask to CPU1
$40000000 constant SYSCFG_IMR1_EXIT14IM                             \ Peripheral EXIT14 interrupt mask to CPU1
$80000000 constant SYSCFG_IMR1_EXIT15IM                             \ Peripheral EXIT15 interrupt mask to CPU1


\
\ @brief CPU1 interrupt mask register 2
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00010000 constant SYSCFG_IMR2_PVM1IM                               \ Peripheral PVM1 interrupt mask to CPU1
$00040000 constant SYSCFG_IMR2_PVM3IM                               \ Peripheral PVM3 interrupt mask to CPU1
$00100000 constant SYSCFG_IMR2_PVDIM                                \ Peripheral PVD interrupt mask to CPU1


\
\ @brief CPU2 interrupt mask register 1
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_C2IMR1_RTCSTAMP                           \ Peripheral RTCSTAMP interrupt mask to CPU2
$00000008 constant SYSCFG_C2IMR1_RTCWKUP                            \ Peripheral RTCWKUP interrupt mask to CPU2
$00000010 constant SYSCFG_C2IMR1_RTCALARM                           \ Peripheral RTCALARM interrupt mask to CPU2
$00000020 constant SYSCFG_C2IMR1_RCC                                \ Peripheral RCC interrupt mask to CPU2
$00000040 constant SYSCFG_C2IMR1_FLASH                              \ Peripheral FLASH interrupt mask to CPU2
$00000100 constant SYSCFG_C2IMR1_PKA                                \ Peripheral PKA interrupt mask to CPU2
$00000200 constant SYSCFG_C2IMR1_RNG                                \ Peripheral RNG interrupt mask to CPU2
$00000400 constant SYSCFG_C2IMR1_AES1                               \ Peripheral AES1 interrupt mask to CPU2
$00000800 constant SYSCFG_C2IMR1_COMP                               \ Peripheral COMP interrupt mask to CPU2
$00001000 constant SYSCFG_C2IMR1_ADC                                \ Peripheral ADC interrupt mask to CPU2


\
\ @brief CPU2 interrupt mask register 1
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_C2IMR2_DMA1_CH1_IM                        \ Peripheral DMA1 CH1 interrupt mask to CPU2
$00000002 constant SYSCFG_C2IMR2_DMA1_CH2_IM                        \ Peripheral DMA1 CH2 interrupt mask to CPU2
$00000004 constant SYSCFG_C2IMR2_DMA1_CH3_IM                        \ Peripheral DMA1 CH3 interrupt mask to CPU2
$00000008 constant SYSCFG_C2IMR2_DMA1_CH4_IM                        \ Peripheral DMA1 CH4 interrupt mask to CPU2
$00000010 constant SYSCFG_C2IMR2_DMA1_CH5_IM                        \ Peripheral DMA1 CH5 interrupt mask to CPU2
$00000020 constant SYSCFG_C2IMR2_DMA1_CH6_IM                        \ Peripheral DMA1 CH6 interrupt mask to CPU2
$00000040 constant SYSCFG_C2IMR2_DMA1_CH7_IM                        \ Peripheral DMA1 CH7 interrupt mask to CPU2
$00000100 constant SYSCFG_C2IMR2_DMA2_CH1_IM                        \ Peripheral DMA2 CH1 interrupt mask to CPU1
$00000200 constant SYSCFG_C2IMR2_DMA2_CH2_IM                        \ Peripheral DMA2 CH2 interrupt mask to CPU1
$00000400 constant SYSCFG_C2IMR2_DMA2_CH3_IM                        \ Peripheral DMA2 CH3 interrupt mask to CPU1
$00000800 constant SYSCFG_C2IMR2_DMA2_CH4_IM                        \ Peripheral DMA2 CH4 interrupt mask to CPU1
$00001000 constant SYSCFG_C2IMR2_DMA2_CH5_IM                        \ Peripheral DMA2 CH5 interrupt mask to CPU1
$00002000 constant SYSCFG_C2IMR2_DMA2_CH6_IM                        \ Peripheral DMA2 CH6 interrupt mask to CPU1
$00004000 constant SYSCFG_C2IMR2_DMA2_CH7_IM                        \ Peripheral DMA2 CH7 interrupt mask to CPU1
$00008000 constant SYSCFG_C2IMR2_DMAM_UX1_IM                        \ Peripheral DMAM UX1 interrupt mask to CPU1
$00010000 constant SYSCFG_C2IMR2_PVM1IM                             \ Peripheral PVM1IM interrupt mask to CPU1
$00040000 constant SYSCFG_C2IMR2_PVM3IM                             \ Peripheral PVM3IM interrupt mask to CPU1
$00100000 constant SYSCFG_C2IMR2_PVDIM                              \ Peripheral PVDIM interrupt mask to CPU1
$00200000 constant SYSCFG_C2IMR2_TSCIM                              \ Peripheral TSCIM interrupt mask to CPU1
$00400000 constant SYSCFG_C2IMR2_LCDIM                              \ Peripheral LCDIM interrupt mask to CPU1


\
\ @brief secure IP control register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SIPCR_SAES1                               \ Enable AES1 KEY[7:0] security.
$00000002 constant SYSCFG_SIPCR_SAES2                               \ Enable AES2 security.
$00000004 constant SYSCFG_SIPCR_SPKA                                \ Enable PKA security
$00000008 constant SYSCFG_SIPCR_SRNG                                \ Enable True RNG security


\
\ @brief System configuration controller
\
$40010000 constant SYSCFG_MEMRMP  \ offset: 0x00 : memory remap register
$40010004 constant SYSCFG_CFGR1   \ offset: 0x04 : configuration register 1
$40010008 constant SYSCFG_EXTICR1  \ offset: 0x08 : external interrupt configuration register 1
$4001000c constant SYSCFG_EXTICR2  \ offset: 0x0C : external interrupt configuration register 2
$40010010 constant SYSCFG_EXTICR3  \ offset: 0x10 : external interrupt configuration register 3
$40010014 constant SYSCFG_EXTICR4  \ offset: 0x14 : external interrupt configuration register 4
$40010018 constant SYSCFG_SCSR    \ offset: 0x18 : SCSR
$4001001c constant SYSCFG_CFGR2   \ offset: 0x1C : CFGR2
$40010020 constant SYSCFG_SWPR    \ offset: 0x20 : SRAM2 write protection register
$40010024 constant SYSCFG_SKR     \ offset: 0x24 : SKR
$40010028 constant SYSCFG_SWPR2   \ offset: 0x28 : SRAM2 write protection register 2
$40010100 constant SYSCFG_IMR1    \ offset: 0x100 : CPU1 interrupt mask register 1
$40010104 constant SYSCFG_IMR2    \ offset: 0x104 : CPU1 interrupt mask register 2
$40010108 constant SYSCFG_C2IMR1  \ offset: 0x108 : CPU2 interrupt mask register 1
$4001010c constant SYSCFG_C2IMR2  \ offset: 0x10C : CPU2 interrupt mask register 1
$40010110 constant SYSCFG_SIPCR   \ offset: 0x110 : secure IP control register

