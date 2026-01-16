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

$00000003 constant SYSCFG_MEMRM_MEM_MODE                            \ MEM_MODE


\
\ @brief peripheral mode configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00010000 constant SYSCFG_PMC_ADC1DC2                               \ ADC1DC2


\
\ @brief external interrupt configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR1_EXTI0                             \ EXTI x configuration (x = 0 to 3)
$000000f0 constant SYSCFG_EXTICR1_EXTI1                             \ EXTI x configuration (x = 0 to 3)
$00000f00 constant SYSCFG_EXTICR1_EXTI2                             \ EXTI x configuration (x = 0 to 3)
$0000f000 constant SYSCFG_EXTICR1_EXTI3                             \ EXTI x configuration (x = 0 to 3)


\
\ @brief external interrupt configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR2_EXTI4                             \ EXTI x configuration (x = 4 to 7)
$000000f0 constant SYSCFG_EXTICR2_EXTI5                             \ EXTI x configuration (x = 4 to 7)
$00000f00 constant SYSCFG_EXTICR2_EXTI6                             \ EXTI x configuration (x = 4 to 7)
$0000f000 constant SYSCFG_EXTICR2_EXTI7                             \ EXTI x configuration (x = 4 to 7)


\
\ @brief external interrupt configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR3_EXTI8                             \ EXTI x configuration (x = 8 to 11)
$000000f0 constant SYSCFG_EXTICR3_EXTI9                             \ EXTI x configuration (x = 8 to 11)
$00000f00 constant SYSCFG_EXTICR3_EXTI10                            \ EXTI10
$0000f000 constant SYSCFG_EXTICR3_EXTI11                            \ EXTI x configuration (x = 8 to 11)


\
\ @brief external interrupt configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_EXTICR4_EXTI12                            \ EXTI x configuration (x = 12 to 15)
$000000f0 constant SYSCFG_EXTICR4_EXTI13                            \ EXTI x configuration (x = 12 to 15)
$00000f00 constant SYSCFG_EXTICR4_EXTI14                            \ EXTI x configuration (x = 12 to 15)
$0000f000 constant SYSCFG_EXTICR4_EXTI15                            \ EXTI x configuration (x = 12 to 15)


\
\ @brief Compensation cell control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CMPCR_CMP_PD                              \ Compensation cell power-down
$00000100 constant SYSCFG_CMPCR_READY                               \ READY


\
\ @brief System configuration controller
\
$40013800 constant SYSCFG_MEMRM   \ offset: 0x00 : memory remap register
$40013804 constant SYSCFG_PMC     \ offset: 0x04 : peripheral mode configuration register
$40013808 constant SYSCFG_EXTICR1  \ offset: 0x08 : external interrupt configuration register 1
$4001380c constant SYSCFG_EXTICR2  \ offset: 0x0C : external interrupt configuration register 2
$40013810 constant SYSCFG_EXTICR3  \ offset: 0x10 : external interrupt configuration register 3
$40013814 constant SYSCFG_EXTICR4  \ offset: 0x14 : external interrupt configuration register 4
$40013820 constant SYSCFG_CMPCR   \ offset: 0x20 : Compensation cell control register

