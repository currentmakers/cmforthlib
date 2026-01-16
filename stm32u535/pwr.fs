\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PWR control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000007 constant PWR_PWR_CR1_LPMS                                 \ Low-power mode selection These bits select the low-power mode entered when the CPU enters the Deepsleep mode. 10x: Standby mode (Standby mode also entered if LPMS = 11X in PWR_CR1 with BREN = 1 in PWR_BDCR1) 11x: Shutdown mode if BREN = 0 in PWR_BDCR1
$00000020 constant PWR_PWR_CR1_RRSB1                                \ SRAM2 page 1 retention in Stop 3 and Standby modes This bit is used to keep the SRAM2 page 1 content in Stop 3 and Standby modes. The SRAM2 page 1 corresponds to the first 8 Kbytes of the SRAM2 (from SRAM2 base address to SRAM2 base address + 0x1FFF). Note: This bit has no effect in Shutdown mode.
$00000040 constant PWR_PWR_CR1_RRSB2                                \ SRAM2 page 2 retention in Stop 3 and Standby modes This bit is used to keep the SRAM2 page 2 content in Stop 3 and Standby modes. The SRAM2 page 2 corresponds to the last 56 Kbytes of the SRAM2 (from SRAM2 base address + 0x2000 to SRAM2 base address + 0xFFFF). Note: This bit has no effect in Shutdown mode.
$00000080 constant PWR_PWR_CR1_ULPMEN                               \ BOR ultra-low power mode This bit is used to reduce the consumption by configuring the BOR in discontinuous mode. This bit must be set to reach the lowest power consumption in the low-power modes.
$00000100 constant PWR_PWR_CR1_SRAM1PD                              \ SRAM1 power down This bit is used to reduce the consumption by powering off the SRAM1.
$00000200 constant PWR_PWR_CR1_SRAM2PD                              \ SRAM2 power down This bit is used to reduce the consumption by powering off the SRAM2.
$00000800 constant PWR_PWR_CR1_SRAM4PD                              \ SRAM4 power down This bit is used to reduce the consumption by powering off the SRAM4.
$00001000 constant PWR_PWR_CR1_SRAM5PD                              \ SRAM5 power down This bit is used to reduce the consumption by powering off the SRAM5. Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.


\
\ @brief PWR control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR2_SRAM1PDS1                            \ SRAM1 page 1 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
$00000002 constant PWR_PWR_CR2_SRAM1PDS2                            \ SRAM1 page 2 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
$00000004 constant PWR_PWR_CR2_SRAM1PDS3                            \ SRAM1 page 3 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
$00000010 constant PWR_PWR_CR2_SRAM2PDS1                            \ SRAM2 page 1 (8 Kbytes) power-down in Stop modes (Stop 0, 1, 2) Note: The SRAM2 page 1 retention in Stop 3 is controlled by RRSB1 bit in PWR_CR1.
$00000020 constant PWR_PWR_CR2_SRAM2PDS2                            \ SRAM2 page 2 (56 Kbytes) power-down in Stop modes (Stop 0, 1, 2) Note: The SRAM2 page 2 retention in Stop 3 is controlled by RRSB2 bit in PWR_CR1.
$00000040 constant PWR_PWR_CR2_SRAM4PDS                             \ SRAM4 power-down in Stop modes (Stop 0, 1, 2, 3)
$00000100 constant PWR_PWR_CR2_ICRAMPDS                             \ ICACHE SRAM power-down in Stop modes (Stop 0, 1, 2, 3)
$00000200 constant PWR_PWR_CR2_DC1RAMPDS                            \ DCACHE1 SRAM power-down in Stop modes (Stop 0, 1, 2, 3)
$00000800 constant PWR_PWR_CR2_PRAMPDS                              \ FMAC, FDCAN and USB peripherals SRAM power-down in Stop modes (Stop 0, 1, 2, 3)
$00002000 constant PWR_PWR_CR2_SRAM4FWU                             \ SRAM4 fast wakeup from Stop 0, Stop 1 and Stop 2 modes This bit is used to obtain the best trade-off between low-power consumption and wakeup time. SRAM4 wakeup time increases the wakeup time when exiting Stop 0, 1 and 2 modes, and also increases the LPDMA access time to SRAM4 during Stop modes.
$00004000 constant PWR_PWR_CR2_FLASHFWU                             \ Flash memory fast wakeup from Stop 0 and Stop 1 modes This bit is used to obtain the best trade-off between low-power consumption and wakeup time when exiting the Stop 0 or Stop 1 modes. When this bit is set, the Flash memory remains in normal mode in Stop 0 and Stop 1 modes, which offers a faster startup time with higher consumption.
$80000000 constant PWR_PWR_CR2_SRDRUN                               \ SmartRun domain in Run mode


\
\ @brief PWR control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant PWR_PWR_CR3_REGSEL                               \ Regulator selection Note: REGSEL is reserved and must be kept at reset value in packages without SMPS.
$00000004 constant PWR_PWR_CR3_FSTEN                                \ Fast soft start


\
\ @brief PWR voltage scaling register
\ Address offset: 0x0C
\ Reset value: 0x00008000
\

$00002000 constant PWR_PWR_VOSR_USBBOOSTRDY                         \ USB EPOD booster ready This bit is set to 1 by hardware when the power booster startup time is reached. The USB clock can be provided only after this bit is set. Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.
$00004000 constant PWR_PWR_VOSR_BOOSTRDY                            \ EPOD booster ready This bit is set to 1 by hardware when the power booster startup time is reached. The system clock frequency can be switched higher than 50 MHz only after this bit is set.
$00008000 constant PWR_PWR_VOSR_VOSRDY                              \ Ready bit for VCORE voltage scaling output selection
$00030000 constant PWR_PWR_VOSR_VOS                                 \ Voltage scaling range selection This field is protected against non-secure access when SYSCLKSEC = 1 in RCC_SECCFGR. It is protected against unprivileged access when SYSCLKSEC = 1 in RCC_SECCFGR and SPRIV = 1 in PWR_PRIVCFGR, or when SYSCLKSEC = 0 and NSPRIV = 1.
$00040000 constant PWR_PWR_VOSR_BOOSTEN                             \ EPOD booster enable This bit is protected against non-secure access when SYSCLKSEC = 1 in RCC_SECCFGR. It is protected against unprivileged access when SYSCLKSEC = 1 in RCC_SECCFGR and SPRIV = 1 in PWR_PRIVCFGR, or when SYSCLKSEC = 0 and NSPRIV = 1. This bit must be set in range 1 and range 2 before increasing the system clock frequency above 50 MHz. This bit is reset when going into Stop modes (0, 1, 2, 3).
$00080000 constant PWR_PWR_VOSR_USBPWREN                            \ USB power enable This bit is protected against non-secure access when SYSCLKSEC = 1 in RCC_SECCFGR. It is protected against unprivileged access when SYSCLKSEC = 1 in RCC_SECCFGR and SPRIV = 1 in PWR_PRIVCFGR, or when SYSCLKSEC = 0 and NSPRIV = 1. Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.
$00100000 constant PWR_PWR_VOSR_USBBOOSTEN                          \ USB EPOD booster enable This bit is protected against non-secure access when SYSCLKSEC = 1 in RCC_SECCFGR. It is protected against unprivileged access when SYSCLKSEC = 1 in RCC_SECCFGR and SPRIV = 1 in PWR_PRIVCFGR, or when SYSCLKSEC = 0 and NSPRIV = 1. This bit must be set in range 1 and range 2 before enabling the USB peripheral. This bit is reset when going into Stop modes (0, 1, 2, 3). Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.


\
\ @brief PWR supply voltage monitoring control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000010 constant PWR_PWR_SVMCR_PVDE                               \ Power voltage detector enable
$000000e0 constant PWR_PWR_SVMCR_PVDLS                              \ Power voltage detector level selection These bits select the voltage threshold detected by the power voltage detector:
$01000000 constant PWR_PWR_SVMCR_UVMEN                              \ VDDUSB independent USB voltage monitor enable
$02000000 constant PWR_PWR_SVMCR_IO2VMEN                            \ VDDIO2 independent I/Os voltage monitor enable
$04000000 constant PWR_PWR_SVMCR_AVM1EN                             \ VDDA independent analog supply voltage monitor 1 enable (1.6 V threshold)
$08000000 constant PWR_PWR_SVMCR_AVM2EN                             \ VDDA independent analog supply voltage monitor 2 enable (1.8 V threshold)
$10000000 constant PWR_PWR_SVMCR_USV                                \ VDDUSB independent USB supply valid This bit is used to validate the VDDUSB supply for electrical and logical isolation purpose. Setting this bit is mandatory to use the USB peripheral. If VDDUSB is not always present in the application, the VDDUSB voltage monitor can be used to determine whether this supply is ready or not.
$20000000 constant PWR_PWR_SVMCR_IO2SV                              \ VDDIO2 independent I/Os supply valid This bit is used to validate the VDDIO2 supply for electrical and logical isolation purpose. Setting this bit is mandatory to use PG[15:2]. If VDDIO2 is not always present in the application, the VDDIO2 voltage monitor can be used to determine whether this supply is ready or not.
$40000000 constant PWR_PWR_SVMCR_ASV                                \ VDDA independent analog supply valid This bit is used to validate the VDDA supply for electrical and logical isolation purpose. Setting this bit is mandatory to use the analog peripherals. If VDDA is not always present in the application, the VDDA voltage monitor can be used to determine whether this supply is ready or not.


\
\ @brief PWR wakeup control register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUCR1_WUPEN1                             \ Wakeup pin WKUP1 enable
$00000002 constant PWR_PWR_WUCR1_WUPEN2                             \ Wakeup pin WKUP2 enable
$00000004 constant PWR_PWR_WUCR1_WUPEN3                             \ Wakeup pin WKUP3 enable
$00000008 constant PWR_PWR_WUCR1_WUPEN4                             \ Wakeup pin WKUP4 enable
$00000010 constant PWR_PWR_WUCR1_WUPEN5                             \ Wakeup pin WKUP5 enable
$00000020 constant PWR_PWR_WUCR1_WUPEN6                             \ Wakeup pin WKUP6 enable
$00000040 constant PWR_PWR_WUCR1_WUPEN7                             \ Wakeup pin WKUP7 enable
$00000080 constant PWR_PWR_WUCR1_WUPEN8                             \ Wakeup pin WKUP8 enable


\
\ @brief PWR wakeup control register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUCR2_WUPP1                              \ Wakeup pin WKUP1 polarity. This bit must be configured when WUPEN1 = 0.
$00000002 constant PWR_PWR_WUCR2_WUPP2                              \ Wakeup pin WKUP2 polarity This bit must be configured when WUPEN2 = 0.
$00000004 constant PWR_PWR_WUCR2_WUPP3                              \ Wakeup pin WKUP3 polarity This bit must be configured when WUPEN3 = 0.
$00000008 constant PWR_PWR_WUCR2_WUPP4                              \ Wakeup pin WKUP4 polarity This bit must be configured when WUPEN4 = 0.
$00000010 constant PWR_PWR_WUCR2_WUPP5                              \ Wakeup pin WKUP5 polarity This bit must be configured when WUPEN5 = 0.
$00000020 constant PWR_PWR_WUCR2_WUPP6                              \ Wakeup pin WKUP6 polarity This bit must be configured when WUPEN6 = 0.
$00000040 constant PWR_PWR_WUCR2_WUPP7                              \ Wakeup pin WKUP7 polarity This bit must be configured when WUPEN7 = 0.
$00000080 constant PWR_PWR_WUCR2_WUPP8                              \ Wakeup pin WKUP8 polarity This bit must be configured when WUPEN8 = 0.


\
\ @brief PWR wakeup control register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant PWR_PWR_WUCR3_WUSEL1                             \ Wakeup pin WKUP1 selection This field must be configured when WUPEN1 = 0.
$0000000c constant PWR_PWR_WUCR3_WUSEL2                             \ Wakeup pin WKUP2 selection This field must be configured when WUPEN2 = 0.
$00000030 constant PWR_PWR_WUCR3_WUSEL3                             \ Wakeup pin WKUP3 selection This field must be configured when WUPEN3 = 0.
$000000c0 constant PWR_PWR_WUCR3_WUSEL4                             \ Wakeup pin WKUP4 selection This field must be configured when WUPEN4 = 0.
$00000300 constant PWR_PWR_WUCR3_WUSEL5                             \ Wakeup pin WKUP5 selection This field must be configured when WUPEN5 = 0.
$00000c00 constant PWR_PWR_WUCR3_WUSEL6                             \ Wakeup pin WKUP6 selection This field must be configured when WUPEN6 = 0.
$00003000 constant PWR_PWR_WUCR3_WUSEL7                             \ Wakeup pin WKUP7 selection This field must be configured when WUPEN7 = 0.
$0000c000 constant PWR_PWR_WUCR3_WUSEL8                             \ Wakeup pin WKUP8 selection This field must be configured when WUPEN8 = 0.


\
\ @brief PWR Backup domain control register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_BDCR1_BREN                               \ Backup RAM retention in Standby and VBAT modes When this bit is set, the backup RAM content is kept in Standby and VBAT modes. If BREN is reset, the backup RAM can still be used in Run, Sleep and Stop modes. However, its content is lost in Standby, Shutdown and VBAT modes. This bit can be written only when the regulator is LDO, which must be configured before switching to SMPS. Note: Backup RAM cannot be preserved in Shutdown mode.
$00000010 constant PWR_PWR_BDCR1_MONEN                              \ Backup domain voltage and temperature monitoring enable


\
\ @brief PWR Backup domain control register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_BDCR2_VBE                                \ VBAT charging enable
$00000002 constant PWR_PWR_BDCR2_VBRS                               \ VBAT charging resistor selection


\
\ @brief PWR disable Backup domain register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_DBPR_DBP                                 \ Disable Backup domain write protection In reset state, all registers and SRAM in Backup domain are protected against parasitic write access. This bit must be set to enable the write access to these registers.


\
\ @brief PWR USB Type-C™ and Power Delivery register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_UCPDR_UCPD_DBDIS                         \ UCPD dead battery disable After exiting reset, the USB Type-C “dead battery” behavior is enabled, which may have a pull-down effect on CC1 and CC2 pins. It is recommended to disable it in all cases, either to stop this pull-down or to handover control to the UCPD (the UCPD must be initialized before doing the disable).
$00000002 constant PWR_PWR_UCPDR_UCPD_STBY                          \ UCPD Standby mode When set, this bit is used to memorize the UCPD configuration in Standby mode. This bit must be written to 1 just before entering Standby mode when using UCPD. It must be written to 0 after exiting the Standby mode and before writing any UCPD registers.


\
\ @brief PWR security configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SECCFGR_WUP1SEC                          \ WUP1 secure protection
$00000002 constant PWR_PWR_SECCFGR_WUP2SEC                          \ WUP2 secure protection
$00000004 constant PWR_PWR_SECCFGR_WUP3SEC                          \ WUP3 secure protection
$00000008 constant PWR_PWR_SECCFGR_WUP4SEC                          \ WUP4 secure protection
$00000010 constant PWR_PWR_SECCFGR_WUP5SEC                          \ WUP5 secure protection
$00000020 constant PWR_PWR_SECCFGR_WUP6SEC                          \ WUP6 secure protection
$00000040 constant PWR_PWR_SECCFGR_WUP7SEC                          \ WUP7 secure protection
$00000080 constant PWR_PWR_SECCFGR_WUP8SEC                          \ WUP8 secure protection
$00001000 constant PWR_PWR_SECCFGR_LPMSEC                           \ Low-power modes secure protection
$00002000 constant PWR_PWR_SECCFGR_VDMSEC                           \ Voltage detection and monitoring secure protection
$00004000 constant PWR_PWR_SECCFGR_VBSEC                            \ Backup domain secure protection
$00008000 constant PWR_PWR_SECCFGR_APCSEC                           \ Pull-up/pull-down secure protection


\
\ @brief PWR privilege control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PRIVCFGR_SPRIV                           \ PWR secure functions privilege configuration This bit is set and reset by software. It can be written only by a secure privileged access.
$00000002 constant PWR_PWR_PRIVCFGR_NSPRIV                          \ PWR non-secure functions privilege configuration This bit is set and reset by software. It can be written only by privileged access, secure or non-secure.


\
\ @brief PWR status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SR_CSSF                                  \ Clear Stop and Standby flags This bit is protected against non-secure access when LPMSEC = 1 in PWR_SECCFGR. This bit is protected against unprivileged access when LPMSEC = 1 and SPRIV = 1 in PWR_PRIVCFGR, or when LPMSEC = 0 and NSPRIV = 1. Writing 1 to this bit clears the STOPF and SBF flags.
$00000002 constant PWR_PWR_SR_STOPF                                 \ Stop flag This bit is set by hardware when the device enters a Stop mode, and is cleared by software by writing 1 to the CSSF bit.
$00000004 constant PWR_PWR_SR_SBF                                   \ Standby flag This bit is set by hardware when the device enters the Standby mode, and is cleared by writing 1 to the CSSF bit, or by a power-on reset. It is not cleared by the system reset.


\
\ @brief PWR supply voltage monitoring status register
\ Address offset: 0x3C
\ Reset value: 0x00008000
\

$00000002 constant PWR_PWR_SVMSR_REGS                               \ Regulator selection
$00000010 constant PWR_PWR_SVMSR_PVDO                               \ VDD voltage detector output
$00008000 constant PWR_PWR_SVMSR_ACTVOSRDY                          \ Voltage level ready for currently used VOS
$00030000 constant PWR_PWR_SVMSR_ACTVOS                             \ VOS currently applied to VCORE This field provides the last VOS value.
$01000000 constant PWR_PWR_SVMSR_VDDUSBRDY                          \ VDDUSB ready
$02000000 constant PWR_PWR_SVMSR_VDDIO2RDY                          \ VDDIO2 ready
$04000000 constant PWR_PWR_SVMSR_VDDA1RDY                           \ VDDA ready versus 1.6V voltage monitor
$08000000 constant PWR_PWR_SVMSR_VDDA2RDY                           \ VDDA ready versus 1.8 V voltage monitor


\
\ @brief PWR Backup domain status register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000002 constant PWR_PWR_BDSR_VBATH                               \ Backup domain voltage level monitoring versus high threshold
$00000004 constant PWR_PWR_BDSR_TEMPL                               \ Temperature level monitoring versus low threshold
$00000008 constant PWR_PWR_BDSR_TEMPH                               \ Temperature level monitoring versus high threshold


\
\ @brief PWR wakeup status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUSR_WUF1                                \ Wakeup flag 1 This bit is set when a wakeup event is detected on WKUP1 pin. This bit is cleared by writing 1 in the CWUF1 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN1 = 0.
$00000002 constant PWR_PWR_WUSR_WUF2                                \ Wakeup flag 2 This bit is set when a wakeup event is detected on WKUP2 pin. This bit is cleared by writing 1 in the CWUF2 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN2 = 0.
$00000004 constant PWR_PWR_WUSR_WUF3                                \ Wakeup flag 3 This bit is set when a wakeup event is detected on WKUP3 pin. This bit is cleared by writing 1 in the CWUF3 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN3 = 0.
$00000008 constant PWR_PWR_WUSR_WUF4                                \ Wakeup flag 4 This bit is set when a wakeup event is detected on WKUP4 pin. This bit is cleared by writing 1 in the CWUF4 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN4 = 0.
$00000010 constant PWR_PWR_WUSR_WUF5                                \ Wakeup flag 5 This bit is set when a wakeup event is detected on WKUP5 pin. This bit is cleared by writing 1 in the CWUF5 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN5 = 0.
$00000020 constant PWR_PWR_WUSR_WUF6                                \ Wakeup flag 6 This bit is set when a wakeup event is detected on WKUP6 pin. This bit is cleared by writing 1 in the CWUF6 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN6 = 0. If WUSEL = 11, this bit is cleared by hardware when all internal wakeup source are cleared.
$00000040 constant PWR_PWR_WUSR_WUF7                                \ Wakeup flag 7 This bit is set when a wakeup event is detected on WKUP7 pin. This bit is cleared by writing 1 in the CWUF7 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN7 = 0. If WUSEL = 11, this bit is cleared by hardware when all internal wakeup source are cleared.
$00000080 constant PWR_PWR_WUSR_WUF8                                \ Wakeup flag 8 This bit is set when a wakeup event is detected on WKUP8 pin. This bit is cleared by writing 1 in the CWUF8 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN8 = 0. If WUSEL = 11, this bit is cleared by hardware when all internal wakeup source are cleared.


\
\ @brief PWR wakeup status clear register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUSCR_CWUF1                              \ Wakeup flag 1 Writing 1 to this bit clears the WUF1 flag in PWR_WUSR.
$00000002 constant PWR_PWR_WUSCR_CWUF2                              \ Wakeup flag 2 Writing 1 to this bit clears the WUF2 flag in PWR_WUSR.
$00000004 constant PWR_PWR_WUSCR_CWUF3                              \ Wakeup flag 3 Writing 1 to this bit clears the WUF3 flag in PWR_WUSR.
$00000008 constant PWR_PWR_WUSCR_CWUF4                              \ Wakeup flag 4 Writing 1 to this bit clears the WUF4 flag in PWR_WUSR.
$00000010 constant PWR_PWR_WUSCR_CWUF5                              \ Wakeup flag 5 Writing 1 to this bit clears the WUF5 flag in PWR_WUSR.
$00000020 constant PWR_PWR_WUSCR_CWUF6                              \ Wakeup flag 6 Writing 1 to this bit clears the WUF6 flag in PWR_WUSR.
$00000040 constant PWR_PWR_WUSCR_CWUF7                              \ Wakeup flag 7 Writing 1 to this bit clears the WUF7 flag in PWR_WUSR.
$00000080 constant PWR_PWR_WUSCR_CWUF8                              \ Wakeup flag 8 Writing 1 to this bit clears the WUF8 flag in PWR_WUSR.


\
\ @brief PWR apply pull configuration register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_APCR_APC                                 \ Apply pull-up and pull-down configuration When this bit is set, the I/O pull-up and pull-down configurations defined in PWR_PUCRx and PWR_PDCRx are applied. When this bit is cleared, PWR_PUCRx and PWR_PDCRx are not applied to the I/Os.


\
\ @brief PWR port A pull-up control register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRA_PU0                            
$00000002 constant PWR_PWR_PUCRA_PU1                            
$00000004 constant PWR_PWR_PUCRA_PU2                            
$00000008 constant PWR_PWR_PUCRA_PU3                            
$00000010 constant PWR_PWR_PUCRA_PU4                            
$00000020 constant PWR_PWR_PUCRA_PU5                            
$00000040 constant PWR_PWR_PUCRA_PU6                            
$00000080 constant PWR_PWR_PUCRA_PU7                            
$00000100 constant PWR_PWR_PUCRA_PU8                            
$00000200 constant PWR_PWR_PUCRA_PU9                            
$00000400 constant PWR_PWR_PUCRA_PU10                           
$00000800 constant PWR_PWR_PUCRA_PU11                           
$00001000 constant PWR_PWR_PUCRA_PU12                           
$00002000 constant PWR_PWR_PUCRA_PU13                           
$00008000 constant PWR_PWR_PUCRA_PU15                               \ Port A pull-up bit 15 When set, this bit activates the pull-up on PA15 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding PD15 bit is also set.


\
\ @brief PWR port A pull-down control register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRA_PD0                            
$00000002 constant PWR_PWR_PDCRA_PD1                            
$00000004 constant PWR_PWR_PDCRA_PD2                            
$00000008 constant PWR_PWR_PDCRA_PD3                            
$00000010 constant PWR_PWR_PDCRA_PD4                            
$00000020 constant PWR_PWR_PDCRA_PD5                            
$00000040 constant PWR_PWR_PDCRA_PD6                            
$00000080 constant PWR_PWR_PDCRA_PD7                            
$00000100 constant PWR_PWR_PDCRA_PD8                            
$00000200 constant PWR_PWR_PDCRA_PD9                            
$00000400 constant PWR_PWR_PDCRA_PD10                           
$00000800 constant PWR_PWR_PDCRA_PD11                           
$00001000 constant PWR_PWR_PDCRA_PD12                           
$00004000 constant PWR_PWR_PDCRA_PD14                               \ Port A pull-down bit 14 When set, this bit activates the pull-down on PA14 when the APC bit is set in PWR_APCR.


\
\ @brief PWR port B pull-up control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRB_PU0                            
$00000002 constant PWR_PWR_PUCRB_PU1                            
$00000004 constant PWR_PWR_PUCRB_PU2                            
$00000008 constant PWR_PWR_PUCRB_PU3                            
$00000010 constant PWR_PWR_PUCRB_PU4                            
$00000020 constant PWR_PWR_PUCRB_PU5                            
$00000040 constant PWR_PWR_PUCRB_PU6                            
$00000080 constant PWR_PWR_PUCRB_PU7                            
$00000100 constant PWR_PWR_PUCRB_PU8                            
$00000200 constant PWR_PWR_PUCRB_PU9                            
$00000400 constant PWR_PWR_PUCRB_PU10                           
$00000800 constant PWR_PWR_PUCRB_PU11                           
$00001000 constant PWR_PWR_PUCRB_PU12                           
$00002000 constant PWR_PWR_PUCRB_PU13                           
$00004000 constant PWR_PWR_PUCRB_PU14                           
$00008000 constant PWR_PWR_PUCRB_PU15                           


\
\ @brief PWR port B pull-down control register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRB_PD0                            
$00000002 constant PWR_PWR_PDCRB_PD1                            
$00000004 constant PWR_PWR_PDCRB_PD2                            
$00000008 constant PWR_PWR_PDCRB_PD3                            
$00000020 constant PWR_PWR_PDCRB_PD5                            
$00000040 constant PWR_PWR_PDCRB_PD6                            
$00000080 constant PWR_PWR_PDCRB_PD7                            
$00000100 constant PWR_PWR_PDCRB_PD8                            
$00000200 constant PWR_PWR_PDCRB_PD9                            
$00000400 constant PWR_PWR_PDCRB_PD10                           
$00000800 constant PWR_PWR_PDCRB_PD11                           
$00001000 constant PWR_PWR_PDCRB_PD12                           
$00002000 constant PWR_PWR_PDCRB_PD13                           
$00004000 constant PWR_PWR_PDCRB_PD14                           
$00008000 constant PWR_PWR_PDCRB_PD15                           


\
\ @brief Power port C pull up control register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRC_PU0                                \ PU0
$00000002 constant PWR_PWR_PUCRC_PU1                                \ PU1
$00000004 constant PWR_PWR_PUCRC_PU2                                \ PU2
$00000008 constant PWR_PWR_PUCRC_PU3                                \ PU3
$00000010 constant PWR_PWR_PUCRC_PU4                                \ PU4
$00000020 constant PWR_PWR_PUCRC_PU5                                \ PU5
$00000040 constant PWR_PWR_PUCRC_PU6                                \ PU6
$00000080 constant PWR_PWR_PUCRC_PU7                                \ PU7
$00000100 constant PWR_PWR_PUCRC_PU8                                \ PU8
$00000200 constant PWR_PWR_PUCRC_PU9                                \ PU9
$00000400 constant PWR_PWR_PUCRC_PU10                               \ PU10
$00000800 constant PWR_PWR_PUCRC_PU11                               \ PU11
$00001000 constant PWR_PWR_PUCRC_PU12                               \ PU12
$00002000 constant PWR_PWR_PUCRC_PU13                               \ PU13
$00004000 constant PWR_PWR_PUCRC_PU14                               \ PU14
$00008000 constant PWR_PWR_PUCRC_PU15                               \ PU15


\
\ @brief PWR port C pull-down control register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRC_PD0                            
$00000002 constant PWR_PWR_PDCRC_PD1                            
$00000004 constant PWR_PWR_PDCRC_PD2                            
$00000008 constant PWR_PWR_PDCRC_PD3                            
$00000010 constant PWR_PWR_PDCRC_PD4                            
$00000020 constant PWR_PWR_PDCRC_PD5                            
$00000040 constant PWR_PWR_PDCRC_PD6                            
$00000080 constant PWR_PWR_PDCRC_PD7                            
$00000100 constant PWR_PWR_PDCRC_PD8                            
$00000200 constant PWR_PWR_PDCRC_PD9                            
$00000400 constant PWR_PWR_PDCRC_PD10                           
$00000800 constant PWR_PWR_PDCRC_PD11                           
$00001000 constant PWR_PWR_PDCRC_PD12                           
$00002000 constant PWR_PWR_PDCRC_PD13                           
$00004000 constant PWR_PWR_PDCRC_PD14                           
$00008000 constant PWR_PWR_PDCRC_PD15                           


\
\ @brief PWR port D pull-up control register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRD_PU0                            
$00000002 constant PWR_PWR_PUCRD_PU1                            
$00000004 constant PWR_PWR_PUCRD_PU2                            
$00000008 constant PWR_PWR_PUCRD_PU3                            
$00000010 constant PWR_PWR_PUCRD_PU4                            
$00000020 constant PWR_PWR_PUCRD_PU5                            
$00000040 constant PWR_PWR_PUCRD_PU6                            
$00000080 constant PWR_PWR_PUCRD_PU7                            
$00000100 constant PWR_PWR_PUCRD_PU8                            
$00000200 constant PWR_PWR_PUCRD_PU9                            
$00000400 constant PWR_PWR_PUCRD_PU10                           
$00000800 constant PWR_PWR_PUCRD_PU11                           
$00001000 constant PWR_PWR_PUCRD_PU12                           
$00002000 constant PWR_PWR_PUCRD_PU13                           
$00004000 constant PWR_PWR_PUCRD_PU14                           
$00008000 constant PWR_PWR_PUCRD_PU15                           


\
\ @brief PWR port D pull-down control register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRD_PD0                            
$00000002 constant PWR_PWR_PDCRD_PD1                            
$00000004 constant PWR_PWR_PDCRD_PD2                            
$00000008 constant PWR_PWR_PDCRD_PD3                            
$00000010 constant PWR_PWR_PDCRD_PD4                            
$00000020 constant PWR_PWR_PDCRD_PD5                            
$00000040 constant PWR_PWR_PDCRD_PD6                            
$00000080 constant PWR_PWR_PDCRD_PD7                            
$00000100 constant PWR_PWR_PDCRD_PD8                            
$00000200 constant PWR_PWR_PDCRD_PD9                            
$00000400 constant PWR_PWR_PDCRD_PD10                           
$00000800 constant PWR_PWR_PDCRD_PD11                           
$00001000 constant PWR_PWR_PDCRD_PD12                           
$00002000 constant PWR_PWR_PDCRD_PD13                           
$00004000 constant PWR_PWR_PDCRD_PD14                           
$00008000 constant PWR_PWR_PDCRD_PD15                           


\
\ @brief PWR port E pull-up control register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRE_PU0                            
$00000002 constant PWR_PWR_PUCRE_PU1                            
$00000004 constant PWR_PWR_PUCRE_PU2                            
$00000008 constant PWR_PWR_PUCRE_PU3                            
$00000010 constant PWR_PWR_PUCRE_PU4                            
$00000020 constant PWR_PWR_PUCRE_PU5                            
$00000040 constant PWR_PWR_PUCRE_PU6                            
$00000080 constant PWR_PWR_PUCRE_PU7                            
$00000100 constant PWR_PWR_PUCRE_PU8                            
$00000200 constant PWR_PWR_PUCRE_PU9                            
$00000400 constant PWR_PWR_PUCRE_PU10                           
$00000800 constant PWR_PWR_PUCRE_PU11                           
$00001000 constant PWR_PWR_PUCRE_PU12                           
$00002000 constant PWR_PWR_PUCRE_PU13                           
$00004000 constant PWR_PWR_PUCRE_PU14                           
$00008000 constant PWR_PWR_PUCRE_PU15                           


\
\ @brief PWR port E pull-down control register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRE_PD0                            
$00000002 constant PWR_PWR_PDCRE_PD1                            
$00000004 constant PWR_PWR_PDCRE_PD2                            
$00000008 constant PWR_PWR_PDCRE_PD3                            
$00000010 constant PWR_PWR_PDCRE_PD4                            
$00000020 constant PWR_PWR_PDCRE_PD5                            
$00000040 constant PWR_PWR_PDCRE_PD6                            
$00000080 constant PWR_PWR_PDCRE_PD7                            
$00000100 constant PWR_PWR_PDCRE_PD8                            
$00000200 constant PWR_PWR_PDCRE_PD9                            
$00000400 constant PWR_PWR_PDCRE_PD10                           
$00000800 constant PWR_PWR_PDCRE_PD11                           
$00001000 constant PWR_PWR_PDCRE_PD12                           
$00002000 constant PWR_PWR_PDCRE_PD13                           
$00004000 constant PWR_PWR_PDCRE_PD14                           
$00008000 constant PWR_PWR_PDCRE_PD15                           


\
\ @brief PWR port F pull-up control register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRF_PU0                            
$00000002 constant PWR_PWR_PUCRF_PU1                            
$00000004 constant PWR_PWR_PUCRF_PU2                            
$00000008 constant PWR_PWR_PUCRF_PU3                            
$00000010 constant PWR_PWR_PUCRF_PU4                            
$00000020 constant PWR_PWR_PUCRF_PU5                            
$00000040 constant PWR_PWR_PUCRF_PU6                            
$00000080 constant PWR_PWR_PUCRF_PU7                            
$00000100 constant PWR_PWR_PUCRF_PU8                            
$00000200 constant PWR_PWR_PUCRF_PU9                            
$00000400 constant PWR_PWR_PUCRF_PU10                           
$00000800 constant PWR_PWR_PUCRF_PU11                           
$00001000 constant PWR_PWR_PUCRF_PU12                           
$00002000 constant PWR_PWR_PUCRF_PU13                           
$00004000 constant PWR_PWR_PUCRF_PU14                           
$00008000 constant PWR_PWR_PUCRF_PU15                           


\
\ @brief PWR port F pull-down control register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRF_PD0                            
$00000002 constant PWR_PWR_PDCRF_PD1                            
$00000004 constant PWR_PWR_PDCRF_PD2                            
$00000008 constant PWR_PWR_PDCRF_PD3                            
$00000010 constant PWR_PWR_PDCRF_PD4                            
$00000020 constant PWR_PWR_PDCRF_PD5                            
$00000040 constant PWR_PWR_PDCRF_PD6                            
$00000080 constant PWR_PWR_PDCRF_PD7                            
$00000100 constant PWR_PWR_PDCRF_PD8                            
$00000200 constant PWR_PWR_PDCRF_PD9                            
$00000400 constant PWR_PWR_PDCRF_PD10                           
$00000800 constant PWR_PWR_PDCRF_PD11                           
$00001000 constant PWR_PWR_PDCRF_PD12                           
$00002000 constant PWR_PWR_PDCRF_PD13                           
$00004000 constant PWR_PWR_PDCRF_PD14                           
$00008000 constant PWR_PWR_PDCRF_PD15                           


\
\ @brief PWR port G pull-up control register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRG_PU0                            
$00000002 constant PWR_PWR_PUCRG_PU1                            
$00000004 constant PWR_PWR_PUCRG_PU2                            
$00000008 constant PWR_PWR_PUCRG_PU3                            
$00000010 constant PWR_PWR_PUCRG_PU4                            
$00000020 constant PWR_PWR_PUCRG_PU5                            
$00000040 constant PWR_PWR_PUCRG_PU6                            
$00000080 constant PWR_PWR_PUCRG_PU7                            
$00000100 constant PWR_PWR_PUCRG_PU8                            
$00000200 constant PWR_PWR_PUCRG_PU9                            
$00000400 constant PWR_PWR_PUCRG_PU10                           
$00000800 constant PWR_PWR_PUCRG_PU11                           
$00001000 constant PWR_PWR_PUCRG_PU12                           
$00002000 constant PWR_PWR_PUCRG_PU13                           
$00004000 constant PWR_PWR_PUCRG_PU14                           
$00008000 constant PWR_PWR_PUCRG_PU15                           


\
\ @brief PWR port G pull-down control register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRG_PD0                            
$00000002 constant PWR_PWR_PDCRG_PD1                            
$00000004 constant PWR_PWR_PDCRG_PD2                            
$00000008 constant PWR_PWR_PDCRG_PD3                            
$00000010 constant PWR_PWR_PDCRG_PD4                            
$00000020 constant PWR_PWR_PDCRG_PD5                            
$00000040 constant PWR_PWR_PDCRG_PD6                            
$00000080 constant PWR_PWR_PDCRG_PD7                            
$00000100 constant PWR_PWR_PDCRG_PD8                            
$00000200 constant PWR_PWR_PDCRG_PD9                            
$00000400 constant PWR_PWR_PDCRG_PD10                           
$00000800 constant PWR_PWR_PDCRG_PD11                           
$00001000 constant PWR_PWR_PDCRG_PD12                           
$00002000 constant PWR_PWR_PDCRG_PD13                           
$00004000 constant PWR_PWR_PDCRG_PD14                           
$00008000 constant PWR_PWR_PDCRG_PD15                           


\
\ @brief PWR port H pull-up control register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRH_PU0                            
$00000002 constant PWR_PWR_PUCRH_PU1                            
$00000004 constant PWR_PWR_PUCRH_PU2                            
$00000008 constant PWR_PWR_PUCRH_PU3                            
$00000010 constant PWR_PWR_PUCRH_PU4                            
$00000020 constant PWR_PWR_PUCRH_PU5                            
$00000040 constant PWR_PWR_PUCRH_PU6                            
$00000080 constant PWR_PWR_PUCRH_PU7                            
$00000100 constant PWR_PWR_PUCRH_PU8                            
$00000200 constant PWR_PWR_PUCRH_PU9                            
$00000400 constant PWR_PWR_PUCRH_PU10                           
$00000800 constant PWR_PWR_PUCRH_PU11                           
$00001000 constant PWR_PWR_PUCRH_PU12                           
$00002000 constant PWR_PWR_PUCRH_PU13                           
$00004000 constant PWR_PWR_PUCRH_PU14                           
$00008000 constant PWR_PWR_PUCRH_PU15                           


\
\ @brief PWR port H pull-down control register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRH_PD0                            
$00000002 constant PWR_PWR_PDCRH_PD1                            
$00000004 constant PWR_PWR_PDCRH_PD2                            
$00000008 constant PWR_PWR_PDCRH_PD3                            
$00000010 constant PWR_PWR_PDCRH_PD4                            
$00000020 constant PWR_PWR_PDCRH_PD5                            
$00000040 constant PWR_PWR_PDCRH_PD6                            
$00000080 constant PWR_PWR_PDCRH_PD7                            
$00000100 constant PWR_PWR_PDCRH_PD8                            
$00000200 constant PWR_PWR_PDCRH_PD9                            
$00000400 constant PWR_PWR_PDCRH_PD10                           
$00000800 constant PWR_PWR_PDCRH_PD11                           
$00001000 constant PWR_PWR_PDCRH_PD12                           
$00002000 constant PWR_PWR_PDCRH_PD13                           
$00004000 constant PWR_PWR_PDCRH_PD14                           
$00008000 constant PWR_PWR_PDCRH_PD15                           


\
\ @brief PWR port I pull-up control register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRI_PU0                            
$00000002 constant PWR_PWR_PUCRI_PU1                            
$00000004 constant PWR_PWR_PUCRI_PU2                            
$00000008 constant PWR_PWR_PUCRI_PU3                            
$00000010 constant PWR_PWR_PUCRI_PU4                            
$00000020 constant PWR_PWR_PUCRI_PU5                            
$00000040 constant PWR_PWR_PUCRI_PU6                            
$00000080 constant PWR_PWR_PUCRI_PU7                            
$00000100 constant PWR_PWR_PUCRI_PU8                            
$00000200 constant PWR_PWR_PUCRI_PU9                            
$00000400 constant PWR_PWR_PUCRI_PU10                           
$00000800 constant PWR_PWR_PUCRI_PU11                           
$00001000 constant PWR_PWR_PUCRI_PU12                           
$00002000 constant PWR_PWR_PUCRI_PU13                           
$00004000 constant PWR_PWR_PUCRI_PU14                           
$00008000 constant PWR_PWR_PUCRI_PU15                           


\
\ @brief PWR port I pull-down control register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRI_PD0                            
$00000002 constant PWR_PWR_PDCRI_PD1                            
$00000004 constant PWR_PWR_PDCRI_PD2                            
$00000008 constant PWR_PWR_PDCRI_PD3                            
$00000010 constant PWR_PWR_PDCRI_PD4                            
$00000020 constant PWR_PWR_PDCRI_PD5                            
$00000040 constant PWR_PWR_PDCRI_PD6                            
$00000080 constant PWR_PWR_PDCRI_PD7                            
$00000100 constant PWR_PWR_PDCRI_PD8                            
$00000200 constant PWR_PWR_PDCRI_PD9                            
$00000400 constant PWR_PWR_PDCRI_PD10                           
$00000800 constant PWR_PWR_PDCRI_PD11                           
$00001000 constant PWR_PWR_PDCRI_PD12                           
$00002000 constant PWR_PWR_PDCRI_PD13                           
$00004000 constant PWR_PWR_PDCRI_PD14                           
$00008000 constant PWR_PWR_PDCRI_PD15                           


\
\ @brief PWR port J pull-up control register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRJ_PU0                            
$00000002 constant PWR_PWR_PUCRJ_PU1                            
$00000004 constant PWR_PWR_PUCRJ_PU2                            
$00000008 constant PWR_PWR_PUCRJ_PU3                            
$00000010 constant PWR_PWR_PUCRJ_PU4                            
$00000020 constant PWR_PWR_PUCRJ_PU5                            
$00000040 constant PWR_PWR_PUCRJ_PU6                            
$00000080 constant PWR_PWR_PUCRJ_PU7                            
$00000100 constant PWR_PWR_PUCRJ_PU8                            
$00000200 constant PWR_PWR_PUCRJ_PU9                            
$00000400 constant PWR_PWR_PUCRJ_PU10                           
$00000800 constant PWR_PWR_PUCRJ_PU11                           


\
\ @brief PWR port J pull-down control register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRJ_PD0                            
$00000002 constant PWR_PWR_PDCRJ_PD1                            
$00000004 constant PWR_PWR_PDCRJ_PD2                            
$00000008 constant PWR_PWR_PDCRJ_PD3                            
$00000010 constant PWR_PWR_PDCRJ_PD4                            
$00000020 constant PWR_PWR_PDCRJ_PD5                            
$00000040 constant PWR_PWR_PDCRJ_PD6                            
$00000080 constant PWR_PWR_PDCRJ_PD7                            
$00000100 constant PWR_PWR_PDCRJ_PD8                            
$00000200 constant PWR_PWR_PDCRJ_PD9                            
$00000400 constant PWR_PWR_PDCRJ_PD10                           
$00000800 constant PWR_PWR_PDCRJ_PD11                           


\
\ @brief PWR control register 4
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR4_SRAM1PDS4                        
$00000002 constant PWR_PWR_CR4_SRAM1PDS5                        
$00000004 constant PWR_PWR_CR4_SRAM1PDS6                        
$00000008 constant PWR_PWR_CR4_SRAM1PDS7                        
$00000010 constant PWR_PWR_CR4_SRAM1PDS8                        
$00000020 constant PWR_PWR_CR4_SRAM1PDS9                        
$00000040 constant PWR_PWR_CR4_SRAM1PDS10                       
$00000080 constant PWR_PWR_CR4_SRAM1PDS11                       
$00000100 constant PWR_PWR_CR4_SRAM1PDS12                       
$00010000 constant PWR_PWR_CR4_SRAM5PDS1                        
$00020000 constant PWR_PWR_CR4_SRAM5PDS2                        
$00040000 constant PWR_PWR_CR4_SRAM5PDS3                        
$00080000 constant PWR_PWR_CR4_SRAM5PDS4                        
$00100000 constant PWR_PWR_CR4_SRAM5PDS5                        
$00200000 constant PWR_PWR_CR4_SRAM5PDS6                        
$00400000 constant PWR_PWR_CR4_SRAM5PDS7                        
$00800000 constant PWR_PWR_CR4_SRAM5PDS8                        
$01000000 constant PWR_PWR_CR4_SRAM5PDS9                        
$02000000 constant PWR_PWR_CR4_SRAM5PDS10                       
$04000000 constant PWR_PWR_CR4_SRAM5PDS11                       
$08000000 constant PWR_PWR_CR4_SRAM5PDS12                       
$10000000 constant PWR_PWR_CR4_SRAM5PDS13                       


\
\ @brief Power control
\
$46020800 constant PWR_PWR_CR1    \ offset: 0x00 : PWR control register 1
$46020804 constant PWR_PWR_CR2    \ offset: 0x04 : PWR control register 2
$46020808 constant PWR_PWR_CR3    \ offset: 0x08 : PWR control register 3
$4602080c constant PWR_PWR_VOSR   \ offset: 0x0C : PWR voltage scaling register
$46020810 constant PWR_PWR_SVMCR  \ offset: 0x10 : PWR supply voltage monitoring control register
$46020814 constant PWR_PWR_WUCR1  \ offset: 0x14 : PWR wakeup control register 1
$46020818 constant PWR_PWR_WUCR2  \ offset: 0x18 : PWR wakeup control register 2
$4602081c constant PWR_PWR_WUCR3  \ offset: 0x1C : PWR wakeup control register 3
$46020820 constant PWR_PWR_BDCR1  \ offset: 0x20 : PWR Backup domain control register 1
$46020824 constant PWR_PWR_BDCR2  \ offset: 0x24 : PWR Backup domain control register 2
$46020828 constant PWR_PWR_DBPR   \ offset: 0x28 : PWR disable Backup domain register
$4602082c constant PWR_PWR_UCPDR  \ offset: 0x2C : PWR USB Type-C™ and Power Delivery register
$46020830 constant PWR_PWR_SECCFGR  \ offset: 0x30 : PWR security configuration register
$46020834 constant PWR_PWR_PRIVCFGR  \ offset: 0x34 : PWR privilege control register
$46020838 constant PWR_PWR_SR     \ offset: 0x38 : PWR status register
$4602083c constant PWR_PWR_SVMSR  \ offset: 0x3C : PWR supply voltage monitoring status register
$46020840 constant PWR_PWR_BDSR   \ offset: 0x40 : PWR Backup domain status register
$46020844 constant PWR_PWR_WUSR   \ offset: 0x44 : PWR wakeup status register
$46020848 constant PWR_PWR_WUSCR  \ offset: 0x48 : PWR wakeup status clear register
$4602084c constant PWR_PWR_APCR   \ offset: 0x4C : PWR apply pull configuration register
$46020850 constant PWR_PWR_PUCRA  \ offset: 0x50 : PWR port A pull-up control register
$46020854 constant PWR_PWR_PDCRA  \ offset: 0x54 : PWR port A pull-down control register
$46020858 constant PWR_PWR_PUCRB  \ offset: 0x58 : PWR port B pull-up control register
$4602085c constant PWR_PWR_PDCRB  \ offset: 0x5C : PWR port B pull-down control register
$46020860 constant PWR_PWR_PUCRC  \ offset: 0x60 : Power port C pull up control register
$46020864 constant PWR_PWR_PDCRC  \ offset: 0x64 : PWR port C pull-down control register
$46020868 constant PWR_PWR_PUCRD  \ offset: 0x68 : PWR port D pull-up control register
$4602086c constant PWR_PWR_PDCRD  \ offset: 0x6C : PWR port D pull-down control register
$46020870 constant PWR_PWR_PUCRE  \ offset: 0x70 : PWR port E pull-up control register
$46020874 constant PWR_PWR_PDCRE  \ offset: 0x74 : PWR port E pull-down control register
$46020878 constant PWR_PWR_PUCRF  \ offset: 0x78 : PWR port F pull-up control register
$4602087c constant PWR_PWR_PDCRF  \ offset: 0x7C : PWR port F pull-down control register
$46020880 constant PWR_PWR_PUCRG  \ offset: 0x80 : PWR port G pull-up control register
$46020884 constant PWR_PWR_PDCRG  \ offset: 0x84 : PWR port G pull-down control register
$46020888 constant PWR_PWR_PUCRH  \ offset: 0x88 : PWR port H pull-up control register
$4602088c constant PWR_PWR_PDCRH  \ offset: 0x8C : PWR port H pull-down control register
$46020890 constant PWR_PWR_PUCRI  \ offset: 0x90 : PWR port I pull-up control register
$46020894 constant PWR_PWR_PDCRI  \ offset: 0x94 : PWR port I pull-down control register
$46020898 constant PWR_PWR_PUCRJ  \ offset: 0x98 : PWR port J pull-up control register
$4602089c constant PWR_PWR_PDCRJ  \ offset: 0x9C : PWR port J pull-down control register
$460208a8 constant PWR_PWR_CR4    \ offset: 0xA8 : PWR control register 4

