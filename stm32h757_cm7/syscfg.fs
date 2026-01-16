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
$00000200 constant SYSCFG_PMCR_BOOSTVDDSEL                          \ Analog switch supply voltage selection
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
\ @brief configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CFGR_CM4L                                 \ CM4L
$00000004 constant SYSCFG_CFGR_PVDL                                 \ PVDL
$00000008 constant SYSCFG_CFGR_FLASHL                               \ FLASHL
$00000040 constant SYSCFG_CFGR_CM7L                                 \ CM7L
$00000080 constant SYSCFG_CFGR_BKRAML                               \ BKRAML
$00000200 constant SYSCFG_CFGR_SRAM4L                               \ SRAM4L
$00000400 constant SYSCFG_CFGR_SRAM3L                               \ SRAM3L
$00000800 constant SYSCFG_CFGR_SRAM2L                               \ SRAM2L
$00001000 constant SYSCFG_CFGR_SRAM1L                               \ SRAM1L
$00002000 constant SYSCFG_CFGR_DTCML                                \ DTCML
$00004000 constant SYSCFG_CFGR_ITCML                                \ ITCML
$00008000 constant SYSCFG_CFGR_AXISRAML                             \ AXISRAML


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
\ @brief SYSCFG power control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_PWRCR_ODEN                                \ Overdrive enable


\
\ @brief SYSCFG package register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_PKGR_PKG                                  \ Package


\
\ @brief SYSCFG user register 0
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_UR0_BKS                                   \ Bank Swap
$00ff0000 constant SYSCFG_UR0_RDP                                   \ Readout protection


\
\ @brief SYSCFG user register 1
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_UR1_BCM4                                  \ Boot Cortex-M4
$00010000 constant SYSCFG_UR1_BCM7                                  \ Boot Cortex-M7


\
\ @brief SYSCFG user register 2
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000003 constant SYSCFG_UR2_BORH                                  \ BOR_LVL Brownout Reset Threshold Level
$ffff0000 constant SYSCFG_UR2_BCM7_ADD0                             \ Cortex-M7 Boot Address 0


\
\ @brief SYSCFG user register 3
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_UR3_BCM4_ADD1                             \ Cortex-M4 Boot Address 0
$ffff0000 constant SYSCFG_UR3_BCM7_ADD1                             \ Cortex-M7 Boot Address 1


\
\ @brief SYSCFG user register 4
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_UR4_BCM4_ADD1                             \ Mass Erase Protected Area Disabled for bank 1
$00010000 constant SYSCFG_UR4_MEPAD_1                               \ Boot Cortex-M4 Address 1


\
\ @brief SYSCFG user register 5
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_UR5_MESAD_1                               \ Mass erase secured area disabled for bank 1
$00ff0000 constant SYSCFG_UR5_WRPS_1                                \ Write protection for flash bank 1


\
\ @brief SYSCFG user register 6
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000fff constant SYSCFG_UR6_PA_BEG_1                              \ Protected area start address for bank 1
$0fff0000 constant SYSCFG_UR6_PA_END_1                              \ Protected area end address for bank 1


\
\ @brief SYSCFG user register 7
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000fff constant SYSCFG_UR7_SA_BEG_1                              \ Secured area start address for bank 1
$0fff0000 constant SYSCFG_UR7_SA_END_1                              \ Secured area end address for bank 1


\
\ @brief SYSCFG user register 8
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_UR8_MEPAD_2                               \ Mass erase protected area disabled for bank 2
$00010000 constant SYSCFG_UR8_MESAD_2                               \ Mass erase secured area disabled for bank 2


\
\ @brief SYSCFG user register 9
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$000000ff constant SYSCFG_UR9_WRPS_2                                \ Write protection for flash bank 2
$0fff0000 constant SYSCFG_UR9_PA_BEG_2                              \ Protected area start address for bank 2


\
\ @brief SYSCFG user register 10
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000fff constant SYSCFG_UR10_PA_END_2                             \ Protected area end address for bank 2
$0fff0000 constant SYSCFG_UR10_SA_BEG_2                             \ Secured area start address for bank 2


\
\ @brief SYSCFG user register 11
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000fff constant SYSCFG_UR11_SA_END_2                             \ Secured area end address for bank 2
$00010000 constant SYSCFG_UR11_IWDG1M                               \ Independent Watchdog 1 mode


\
\ @brief SYSCFG user register 12
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_UR12_IWDG2M                               \ Independent Watchdog 2 mode
$00010000 constant SYSCFG_UR12_SECURE                               \ Secure mode


\
\ @brief SYSCFG user register 13
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$00000003 constant SYSCFG_UR13_SDRS                                 \ Secured DTCM RAM Size
$00010000 constant SYSCFG_UR13_D1SBRST                              \ D1 Standby reset


\
\ @brief SYSCFG user register 14
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_UR14_D1STPRST                             \ D1 Stop Reset
$00010000 constant SYSCFG_UR14_D2SBRST                              \ D2 Standby Reset


\
\ @brief SYSCFG user register 15
\ Address offset: 0x33C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_UR15_D2STPRST                             \ D2 Stop Reset
$00010000 constant SYSCFG_UR15_FZIWDGSTB                            \ Freeze independent watchdog in Standby mode


\
\ @brief SYSCFG user register 16
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_UR16_FZIWDGSTP                            \ Freeze independent watchdog in Stop mode
$00010000 constant SYSCFG_UR16_PKP                                  \ Private key programmed


\
\ @brief SYSCFG user register 17
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_UR17_IO_HSLV                              \ I/O high speed / low voltage


\
\ @brief System configuration controller
\
$58000404 constant SYSCFG_PMCR    \ offset: 0x04 : peripheral mode configuration register
$58000408 constant SYSCFG_EXTICR1  \ offset: 0x08 : external interrupt configuration register 1
$5800040c constant SYSCFG_EXTICR2  \ offset: 0x0C : external interrupt configuration register 2
$58000410 constant SYSCFG_EXTICR3  \ offset: 0x10 : external interrupt configuration register 3
$58000414 constant SYSCFG_EXTICR4  \ offset: 0x14 : external interrupt configuration register 4
$58000418 constant SYSCFG_CFGR    \ offset: 0x18 : configuration register
$58000420 constant SYSCFG_CCCSR   \ offset: 0x20 : compensation cell control/status register
$58000424 constant SYSCFG_CCVR    \ offset: 0x24 : SYSCFG compensation cell value register
$58000428 constant SYSCFG_CCCR    \ offset: 0x28 : SYSCFG compensation cell code register
$5800042c constant SYSCFG_PWRCR   \ offset: 0x2C : SYSCFG power control register
$58000524 constant SYSCFG_PKGR    \ offset: 0x124 : SYSCFG package register
$58000700 constant SYSCFG_UR0     \ offset: 0x300 : SYSCFG user register 0
$58000704 constant SYSCFG_UR1     \ offset: 0x304 : SYSCFG user register 1
$58000708 constant SYSCFG_UR2     \ offset: 0x308 : SYSCFG user register 2
$5800070c constant SYSCFG_UR3     \ offset: 0x30C : SYSCFG user register 3
$58000710 constant SYSCFG_UR4     \ offset: 0x310 : SYSCFG user register 4
$58000714 constant SYSCFG_UR5     \ offset: 0x314 : SYSCFG user register 5
$58000718 constant SYSCFG_UR6     \ offset: 0x318 : SYSCFG user register 6
$5800071c constant SYSCFG_UR7     \ offset: 0x31C : SYSCFG user register 7
$58000720 constant SYSCFG_UR8     \ offset: 0x320 : SYSCFG user register 8
$58000724 constant SYSCFG_UR9     \ offset: 0x324 : SYSCFG user register 9
$58000728 constant SYSCFG_UR10    \ offset: 0x328 : SYSCFG user register 10
$5800072c constant SYSCFG_UR11    \ offset: 0x32C : SYSCFG user register 11
$58000730 constant SYSCFG_UR12    \ offset: 0x330 : SYSCFG user register 12
$58000734 constant SYSCFG_UR13    \ offset: 0x334 : SYSCFG user register 13
$58000738 constant SYSCFG_UR14    \ offset: 0x338 : SYSCFG user register 14
$5800073c constant SYSCFG_UR15    \ offset: 0x33C : SYSCFG user register 15
$58000740 constant SYSCFG_UR16    \ offset: 0x340 : SYSCFG user register 16
$58000744 constant SYSCFG_UR17    \ offset: 0x344 : SYSCFG user register 17

