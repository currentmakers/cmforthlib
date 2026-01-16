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
$00000008 constant SYSCFG_MEMRMP_QFS                                \ QUADSPI memory mapping swap
$00000100 constant SYSCFG_MEMRMP_FB_MODE                            \ Flash Bank mode selection


\
\ @brief configuration register 1
\ Address offset: 0x04
\ Reset value: 0x7C000001
\

$00000001 constant SYSCFG_CFGR1_FWDIS                               \ Firewall disable
$00000100 constant SYSCFG_CFGR1_BOOSTEN                             \ I/O analog switch voltage booster enable
$00010000 constant SYSCFG_CFGR1_I2C_PB6_FMP                         \ Fast-mode Plus (Fm+) driving capability activation on PB6
$00020000 constant SYSCFG_CFGR1_I2C_PB7_FMP                         \ Fast-mode Plus (Fm+) driving capability activation on PB7
$00040000 constant SYSCFG_CFGR1_I2C_PB8_FMP                         \ Fast-mode Plus (Fm+) driving capability activation on PB8
$00080000 constant SYSCFG_CFGR1_I2C_PB9_FMP                         \ Fast-mode Plus (Fm+) driving capability activation on PB9
$00100000 constant SYSCFG_CFGR1_I2C1_FMP                            \ I2C1 Fast-mode Plus driving capability activation
$00200000 constant SYSCFG_CFGR1_I2C2_FMP                            \ I2C2 Fast-mode Plus driving capability activation
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


\
\ @brief CFGR2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CFGR2_CLL                                 \ Cortex LOCKUP (Hardfault) output enable bit
$00000002 constant SYSCFG_CFGR2_SPL                                 \ SRAM2 parity lock bit
$00000004 constant SYSCFG_CFGR2_PVDL                                \ PVD lock enable bit
$00000008 constant SYSCFG_CFGR2_ECCL                                \ ECC Lock
$00000100 constant SYSCFG_CFGR2_SPF                                 \ SRAM2 parity error flag


\
\ @brief SWPR
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

