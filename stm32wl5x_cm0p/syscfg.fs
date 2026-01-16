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
$00200000 constant SYSCFG_CFGR1_I2C2_FMP                            \ I2C2 Fast-mode Plus driving capability activation
$00400000 constant SYSCFG_CFGR1_I2C3_FMP                            \ I2C3 Fast-mode Plus driving capability activation


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

$00000001 constant SYSCFG_SCSR_SRAM2ER                              \ SRAM2 erase
$00000002 constant SYSCFG_SCSR_SRAMBSY                              \ SRAM1, SRAM2 and PKA SRAM busy by erase operation
$00000100 constant SYSCFG_SCSR_PKASRAMBSY                           \ PKA SRAM busy by erase operation


\
\ @brief CFGR2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CFGR2_CLL                                 \ CPU1 LOCKUP (Hardfault) output enable bit
$00000002 constant SYSCFG_CFGR2_SPL                                 \ SRAM2 parity lock bit
$00000004 constant SYSCFG_CFGR2_PVDL                                \ PVD lock enable bit
$00000008 constant SYSCFG_CFGR2_ECCL                                \ ECC Lock
$00000100 constant SYSCFG_CFGR2_SPF                                 \ SRAM2 parity error flag


\
\ @brief SWPR
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SWPR_P0WP                                 \ SRAM2 1Kbyte page 0 write protection
$00000002 constant SYSCFG_SWPR_P1WP                                 \ SRAM2 1Kbyte page 1 write protection
$00000004 constant SYSCFG_SWPR_P2WP                                 \ SRAM2 1Kbyte page 2 write protection
$00000008 constant SYSCFG_SWPR_P3WP                                 \ SRAM2 1Kbyte page 3 write protection
$00000010 constant SYSCFG_SWPR_P4WP                                 \ SRAM2 1Kbyte page 4 write protection
$00000020 constant SYSCFG_SWPR_P5WP                                 \ SRAM2 1Kbyte page 5 write protection
$00000040 constant SYSCFG_SWPR_P6WP                                 \ SRAM2 1Kbyte page 6 write protection
$00000080 constant SYSCFG_SWPR_P7WP                                 \ SRAM2 1Kbyte page 7 write protection
$00000100 constant SYSCFG_SWPR_P8WP                                 \ SRAM2 1Kbyte page 8 write protection
$00000200 constant SYSCFG_SWPR_P9WP                                 \ SRAM2 1Kbyte page 9 write protection
$00000400 constant SYSCFG_SWPR_P10WP                                \ SRAM2 1Kbyte page 10 write protection
$00000800 constant SYSCFG_SWPR_P11WP                                \ SRAM2 1Kbyte page 11 write protection
$00001000 constant SYSCFG_SWPR_P12WP                                \ SRAM2 1Kbyte page 12 write protection
$00002000 constant SYSCFG_SWPR_P13WP                                \ SRAM2 1Kbyte page 13 write protection
$00004000 constant SYSCFG_SWPR_P14WP                                \ SRAM2 1Kbyte page 14 write protection
$00008000 constant SYSCFG_SWPR_P15WP                                \ SRAM2 1Kbyte page 15 write protection
$00010000 constant SYSCFG_SWPR_P16WP                                \ SRAM2 1Kbyte page 16 write protection
$00020000 constant SYSCFG_SWPR_P17WP                                \ SRAM2 1Kbyte page 17 write protection
$00040000 constant SYSCFG_SWPR_P18WP                                \ SRAM2 1Kbyte page 18 write protection
$00080000 constant SYSCFG_SWPR_P19WP                                \ SRAM2 1Kbyte page 19 write protection
$00100000 constant SYSCFG_SWPR_P20WP                                \ SRAM2 1Kbyte page 20 write protection
$00200000 constant SYSCFG_SWPR_P21WP                                \ SRAM2 1Kbyte page 21 write protection
$00400000 constant SYSCFG_SWPR_P22WP                                \ SRAM2 1Kbyte page 22 write protection
$00800000 constant SYSCFG_SWPR_P23WP                                \ SRAM2 1Kbyte page 23 write protection
$01000000 constant SYSCFG_SWPR_P24WP                                \ SRAM2 1Kbyte page 24 write protection
$02000000 constant SYSCFG_SWPR_P25WP                                \ SRAM2 1Kbyte page 25 write protection
$04000000 constant SYSCFG_SWPR_P26WP                                \ SRAM2 1Kbyte page 26 write protection
$08000000 constant SYSCFG_SWPR_P27WP                                \ SRAM2 1Kbyte page 27 write protection
$10000000 constant SYSCFG_SWPR_P28WP                                \ SRAM2 1Kbyte page 28 write protection
$20000000 constant SYSCFG_SWPR_P29WP                                \ SRAM2 1Kbyte page 29 write protection
$40000000 constant SYSCFG_SWPR_P30WP                                \ SRAM2 1Kbyte page 30 write protection
$80000000 constant SYSCFG_SWPR_P31WP                                \ SRAM2 1Kbyte page 31 write protection


\
\ @brief SKR
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant SYSCFG_SKR_KEY                                   \ SRAM2 write protection key for software erase


\
\ @brief SYSCFG CPU1 interrupt mask register 1
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_IMR1_RTCSTAMPTAMPLSECSSIM                 \ RTCSTAMPTAMPLSECSSIM
$00000004 constant SYSCFG_IMR1_RTCSSRUIM                            \ RTCSSRUIM
$00200000 constant SYSCFG_IMR1_EXTI5IM                              \ EXTI5IM
$00400000 constant SYSCFG_IMR1_EXTI6IM                              \ EXTI6IM
$00800000 constant SYSCFG_IMR1_EXTI7IM                              \ EXTI7IM
$01000000 constant SYSCFG_IMR1_EXTI8IM                              \ EXTI8IM
$02000000 constant SYSCFG_IMR1_EXTI9IM                              \ EXTI9IM
$04000000 constant SYSCFG_IMR1_EXTI10IM                             \ EXTI10IM
$08000000 constant SYSCFG_IMR1_EXTI11IM                             \ EXTI11IM
$10000000 constant SYSCFG_IMR1_EXTI12IM                             \ EXTI12IM
$20000000 constant SYSCFG_IMR1_EXTI13IM                             \ EXTI13IM
$40000000 constant SYSCFG_IMR1_EXTI14IM                             \ EXTI14IM
$80000000 constant SYSCFG_IMR1_EXTI15IM                             \ EXTI15IM


\
\ @brief SYSCFG CPU1 interrupt mask register 2
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00040000 constant SYSCFG_IMR2_PVM3IM                               \ PVM3IM
$00100000 constant SYSCFG_IMR2_PVDIM                                \ PVDIM


\
\ @brief SYSCFG CPU2 interrupt mask register 1
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_C2IMR1_RTCSTAMPTAMPLSECSSIM               \ RTCSTAMPTAMPLSECSSIM
$00000002 constant SYSCFG_C2IMR1_RTCALARMIM                         \ RTCALARMIM
$00000004 constant SYSCFG_C2IMR1_RTCSSRUIM                          \ RTCSSRUIM
$00000008 constant SYSCFG_C2IMR1_RTCWKUPIM                          \ RTCWKUPIM
$00000020 constant SYSCFG_C2IMR1_RCCIM                              \ RCCIM
$00000040 constant SYSCFG_C2IMR1_FLASHIM                            \ FLASHIM
$00000100 constant SYSCFG_C2IMR1_PKAIM                              \ PKAIM
$00000400 constant SYSCFG_C2IMR1_AESIM                              \ AESIM
$00000800 constant SYSCFG_C2IMR1_COMPIM                             \ COMPIM
$00001000 constant SYSCFG_C2IMR1_ADCIM                              \ ADCIM
$00002000 constant SYSCFG_C2IMR1_DACIM                              \ DACIM
$00010000 constant SYSCFG_C2IMR1_EXTI0IM                            \ EXTI0IM
$00020000 constant SYSCFG_C2IMR1_EXTI1IM                            \ EXTI1IM
$00040000 constant SYSCFG_C2IMR1_EXTI2IM                            \ EXTI2IM
$00080000 constant SYSCFG_C2IMR1_EXTI3IM                            \ EXTI3IM
$00100000 constant SYSCFG_C2IMR1_EXTI4IM                            \ EXTI4IM
$00200000 constant SYSCFG_C2IMR1_EXTI5IM                            \ EXTI5IM
$00400000 constant SYSCFG_C2IMR1_EXTI6IM                            \ EXTI6IM
$00800000 constant SYSCFG_C2IMR1_EXTI7IM                            \ EXTI7IM
$01000000 constant SYSCFG_C2IMR1_EXTI8IM                            \ EXTI8IM
$02000000 constant SYSCFG_C2IMR1_EXTI9IM                            \ EXTI9IM
$04000000 constant SYSCFG_C2IMR1_EXTI10IM                           \ EXTI10IM
$08000000 constant SYSCFG_C2IMR1_EXTI11IM                           \ EXTI11IM
$10000000 constant SYSCFG_C2IMR1_EXTI12IM                           \ EXTI12IM
$20000000 constant SYSCFG_C2IMR1_EXTI13IM                           \ EXTI13IM
$40000000 constant SYSCFG_C2IMR1_EXTI14IM                           \ EXTI14IM
$80000000 constant SYSCFG_C2IMR1_EXTI15IM                           \ EXTI15IM


\
\ @brief SYSCFG CPU2 interrupt mask register 2
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_C2IMR2_DMA1CH1IM                          \ DMA1CH1IM
$00000002 constant SYSCFG_C2IMR2_DMA1CH2IM                          \ DMA1CH2IM
$00000004 constant SYSCFG_C2IMR2_DMA1CH3IM                          \ DMA1CH3IM
$00000008 constant SYSCFG_C2IMR2_DMA1CH4IM                          \ DMA1CH4IM
$00000010 constant SYSCFG_C2IMR2_DMA1CH5IM                          \ DMA1CH5IM
$00000020 constant SYSCFG_C2IMR2_DMA1CH6IM                          \ DMA1CH6IM
$00000040 constant SYSCFG_C2IMR2_DMA1CH7IM                          \ DMA1CH7IM
$00000100 constant SYSCFG_C2IMR2_DMA2CH1IM                          \ DMA2CH1IM
$00000200 constant SYSCFG_C2IMR2_DMA2CH2IM                          \ DMA2CH2IM
$00000400 constant SYSCFG_C2IMR2_DMA2CH3IM                          \ DMA2CH3IM
$00000800 constant SYSCFG_C2IMR2_DMA2CH4IM                          \ DMA2CH4IM
$00001000 constant SYSCFG_C2IMR2_DMA2CH5IM                          \ DMA2CH5IM
$00002000 constant SYSCFG_C2IMR2_DMA2CH6IM                          \ DMA2CH6IM
$00004000 constant SYSCFG_C2IMR2_DMA2CH7IM                          \ DMA2CH7IM
$00008000 constant SYSCFG_C2IMR2_DMAMUX1IM                          \ DMAMUX1IM
$00040000 constant SYSCFG_C2IMR2_PVM3IM                             \ PVM3IM
$00100000 constant SYSCFG_C2IMR2_PVDIM                              \ PVDIM


\
\ @brief radio debug control register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_RFDCR_RFTBSEL                             \ radio debug test bus selection


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
$40010020 constant SYSCFG_SWPR    \ offset: 0x20 : SWPR
$40010024 constant SYSCFG_SKR     \ offset: 0x24 : SKR
$40010100 constant SYSCFG_IMR1    \ offset: 0x100 : SYSCFG CPU1 interrupt mask register 1
$40010104 constant SYSCFG_IMR2    \ offset: 0x104 : SYSCFG CPU1 interrupt mask register 2
$40010108 constant SYSCFG_C2IMR1  \ offset: 0x108 : SYSCFG CPU2 interrupt mask register 1
$4001010c constant SYSCFG_C2IMR2  \ offset: 0x10C : SYSCFG CPU2 interrupt mask register 2
$40010208 constant SYSCFG_RFDCR   \ offset: 0x208 : radio debug control register

