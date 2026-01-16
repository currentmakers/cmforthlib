\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief peripheral mode configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_PMCR_I2C1FMP                              \ I2C1 Fm+
$00000002 constant SYSCFG_PMCR_I2C2FMP                              \ I2C2 Fm+
$00000004 constant SYSCFG_PMCR_I2C3FMP                              \ I2C3 Fm+
$00000008 constant SYSCFG_PMCR_I2C4FMP                              \ I2C4 Fm+
$00000010 constant SYSCFG_PMCR_PB6FMP                               \ PB(6) Fm+
$00000020 constant SYSCFG_PMCR_PB7FMP                               \ PB(7) Fast Mode Plus
$00000040 constant SYSCFG_PMCR_PB8FMP                               \ PB(8) Fast Mode Plus
$00000080 constant SYSCFG_PMCR_PB9FMP                               \ PB(9) Fm+
$00000100 constant SYSCFG_PMCR_BOOSTE                               \ Booster Enable
$00e00000 constant SYSCFG_PMCR_EPIS                                 \ Ethernet PHY Interface Selection
$01000000 constant SYSCFG_PMCR_PA0SO                                \ PA0 Switch Open
$02000000 constant SYSCFG_PMCR_PA1SO                                \ PA1 Switch Open
$04000000 constant SYSCFG_PMCR_PC2SO                                \ PC2 Switch Open
$08000000 constant SYSCFG_PMCR_PC3SO                                \ PC3 Switch Open


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
\ @brief compensation cell control/status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CCCSR_EN                                  \ enable
$00000002 constant SYSCFG_CCCSR_CS                                  \ Code selection
$00000100 constant SYSCFG_CCCSR_READY                               \ Compensation cell ready flag
$00010000 constant SYSCFG_CCCSR_HSLV                                \ High-speed at low-voltage


\
\ @brief SYSCFG compensation cell value register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_CCVR_NCV                                  \ NMOS compensation value
$000000f0 constant SYSCFG_CCVR_PCV                                  \ PMOS compensation value


\
\ @brief SYSCFG compensation cell code register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_CCCR_NCC                                  \ NMOS compensation code
$000000f0 constant SYSCFG_CCCR_PCC                                  \ PMOS compensation code


\
\ @brief SYSCFG timer break lockup register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000004 constant SYSCFG_SYSCFG_BRK_LOCKUPR_PVDL                   \ PVD lock enable bit.
$00000008 constant SYSCFG_SYSCFG_BRK_LOCKUPR_FLASHL                 \ Flash double ECC error lock bit
$00000040 constant SYSCFG_SYSCFG_BRK_LOCKUPR_CM7L                   \ CortexÃ‚Â®-M7 LOCKUP (HardFault) output enable bit
$00002000 constant SYSCFG_SYSCFG_BRK_LOCKUPR_DTCML                  \ D1TCM or D0TCM double ECC error signal lock
$00004000 constant SYSCFG_SYSCFG_BRK_LOCKUPR_ITCML                  \ ITCM double ECC error signal lock


\
\ @brief System configuration controller
\
$58000404 constant SYSCFG_PMCR    \ offset: 0x04 : peripheral mode configuration register
$58000408 constant SYSCFG_EXTICR1  \ offset: 0x08 : external interrupt configuration register 1
$5800040c constant SYSCFG_EXTICR2  \ offset: 0x0C : external interrupt configuration register 2
$58000410 constant SYSCFG_EXTICR3  \ offset: 0x10 : external interrupt configuration register 3
$58000414 constant SYSCFG_EXTICR4  \ offset: 0x14 : external interrupt configuration register 4
$58000420 constant SYSCFG_CCCSR   \ offset: 0x20 : compensation cell control/status register
$58000424 constant SYSCFG_CCVR    \ offset: 0x24 : SYSCFG compensation cell value register
$58000428 constant SYSCFG_CCCR    \ offset: 0x28 : SYSCFG compensation cell code register
$58000518 constant SYSCFG_SYSCFG_BRK_LOCKUPR  \ offset: 0x118 : SYSCFG timer break lockup register

