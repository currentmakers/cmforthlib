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

$00000001 constant SYSCFG_MEMRMP_MEM_BOOT                           \ Memory boot mapping
$00000c00 constant SYSCFG_MEMRMP_SWP_FMC                            \ FMC memory mapping swap


\
\ @brief peripheral mode configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_PMC_I2C1_FMP                              \ I2C1_FMP I2C1 Fast Mode + Enable
$00000002 constant SYSCFG_PMC_I2C2_FMP                              \ I2C2_FMP I2C2 Fast Mode + Enable
$00000004 constant SYSCFG_PMC_I2C3_FMP                              \ I2C3_FMP I2C3 Fast Mode + Enable
$00000010 constant SYSCFG_PMC_PB6_FMP                               \ PB6_FMP Fast Mode
$00000020 constant SYSCFG_PMC_PB7_FMP                               \ PB7_FMP Fast Mode + Enable
$00000040 constant SYSCFG_PMC_PB8_FMP                               \ PB8_FMP Fast Mode + Enable
$00000080 constant SYSCFG_PMC_PB9_FMP                               \ Fast Mode + Enable
$00070000 constant SYSCFG_PMC_ADCDC2                                \ ADC3DC2


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
$40013800 constant SYSCFG_MEMRMP  \ offset: 0x00 : memory remap register
$40013804 constant SYSCFG_PMC     \ offset: 0x04 : peripheral mode configuration register
$40013808 constant SYSCFG_EXTICR1  \ offset: 0x08 : external interrupt configuration register 1
$4001380c constant SYSCFG_EXTICR2  \ offset: 0x0C : external interrupt configuration register 2
$40013810 constant SYSCFG_EXTICR3  \ offset: 0x10 : external interrupt configuration register 3
$40013814 constant SYSCFG_EXTICR4  \ offset: 0x14 : external interrupt configuration register 4
$40013820 constant SYSCFG_CMPCR   \ offset: 0x20 : Compensation cell control register

