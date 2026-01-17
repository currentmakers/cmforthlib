\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_CR1_DEF
    \
    \ @brief PWR control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PWR_LPMS                       \ [0x00 : 3] Low-power mode selection These bits select the low-power mode entered when the CPU enters the Deepsleep mode. 10x: Standby mode (Standby mode also entered if LPMS = 11X in PWR_CR1 with BREN = 1 in PWR_BDCR1) 11x: Shutdown mode if BREN = 0 in PWR_BDCR1
    $05 constant PWR_RRSB1                      \ [0x05] SRAM2 page 1 retention in Stop 3 and Standby modes This bit is used to keep the SRAM2 page 1 content in Stop 3 and Standby modes. The SRAM2 page 1 corresponds to the first 8 Kbytes of the SRAM2 (from SRAM2 base address to SRAM2 base address + 0x1FFF). Note: This bit has no effect in Shutdown mode.
    $06 constant PWR_RRSB2                      \ [0x06] SRAM2 page 2 retention in Stop 3 and Standby modes This bit is used to keep the SRAM2 page 2 content in Stop 3 and Standby modes. The SRAM2 page 2 corresponds to the last 56 Kbytes of the SRAM2 (from SRAM2 base address + 0x2000 to SRAM2 base address + 0xFFFF). Note: This bit has no effect in Shutdown mode.
    $07 constant PWR_ULPMEN                     \ [0x07] BOR ultra-low power mode This bit is used to reduce the consumption by configuring the BOR in discontinuous mode. This bit must be set to reach the lowest power consumption in the low-power modes.
    $08 constant PWR_SRAM1PD                    \ [0x08] SRAM1 power down This bit is used to reduce the consumption by powering off the SRAM1.
    $09 constant PWR_SRAM2PD                    \ [0x09] SRAM2 power down This bit is used to reduce the consumption by powering off the SRAM2.
    $0a constant PWR_SRAM3PD                    \ [0x0a] SRAM3 power down This bit is used to reduce the consumption by powering off the SRAM3.
    $0b constant PWR_SRAM4PD                    \ [0x0b] SRAM4 power down This bit is used to reduce the consumption by powering off the SRAM4.
    $0c constant PWR_SRAM5PD                    \ [0x0c] SRAM5 power down This bit is used to reduce the consumption by powering off the SRAM5. Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.
  [then]


  [ifdef] PWR_PWR_CR2_DEF
    \
    \ @brief PWR control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWR_SRAM1PDS1                  \ [0x00] SRAM1 page 1 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $01 constant PWR_SRAM1PDS2                  \ [0x01] SRAM1 page 2 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $02 constant PWR_SRAM1PDS3                  \ [0x02] SRAM1 page 3 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $04 constant PWR_SRAM2PDS1                  \ [0x04] SRAM2 page 1 (8 Kbytes) power-down in Stop modes (Stop 0, 1, 2) Note: The SRAM2 page 1 retention in Stop 3 is controlled by RRSB1 bit in PWR_CR1.
    $05 constant PWR_SRAM2PDS2                  \ [0x05] SRAM2 page 2 (56 Kbytes) power-down in Stop modes (Stop 0, 1, 2) Note: The SRAM2 page 2 retention in Stop 3 is controlled by RRSB2 bit in PWR_CR1.
    $06 constant PWR_SRAM4PDS                   \ [0x06] SRAM4 power-down in Stop modes (Stop 0, 1, 2, 3)
    $07 constant PWR_DC2RAMPDS                  \ [0x07] DCACHE2 SRAM power-down in Stop modes (Stop 0, 1, 2, 3) Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.
    $08 constant PWR_ICRAMPDS                   \ [0x08] ICACHE SRAM power-down in Stop modes (Stop 0, 1, 2, 3)
    $09 constant PWR_DC1RAMPDS                  \ [0x09] DCACHE1 SRAM power-down in Stop modes (Stop 0, 1, 2, 3)
    $0a constant PWR_DMA2DRAMPDS                \ [0x0a] DMA2D SRAM power-down in Stop modes (Stop 0, 1, 2, 3)
    $0b constant PWR_PRAMPDS                    \ [0x0b] FMAC, FDCAN and USB peripherals SRAM power-down in Stop modes (Stop 0, 1, 2, 3)
    $0d constant PWR_SRAM4FWU                   \ [0x0d] SRAM4 fast wakeup from Stop 0, Stop 1 and Stop 2 modes This bit is used to obtain the best trade-off between low-power consumption and wakeup time. SRAM4 wakeup time increases the wakeup time when exiting Stop 0, 1 and 2 modes, and also increases the LPDMA access time to SRAM4 during Stop modes.
    $0e constant PWR_FLASHFWU                   \ [0x0e] Flash memory fast wakeup from Stop 0 and Stop 1 modes This bit is used to obtain the best trade-off between low-power consumption and wakeup time when exiting the Stop 0 or Stop 1 modes. When this bit is set, the Flash memory remains in normal mode in Stop 0 and Stop 1 modes, which offers a faster startup time with higher consumption.
    $10 constant PWR_SRAM3PDS1                  \ [0x10] SRAM3 page 1 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $11 constant PWR_SRAM3PDS2                  \ [0x11] SRAM3 page 2 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $12 constant PWR_SRAM3PDS3                  \ [0x12] SRAM3 page 3 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $13 constant PWR_SRAM3PDS4                  \ [0x13] SRAM3 page 4 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $14 constant PWR_SRAM3PDS5                  \ [0x14] SRAM3 page 5 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $15 constant PWR_SRAM3PDS6                  \ [0x15] SRAM3 page 6 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $16 constant PWR_SRAM3PDS7                  \ [0x16] SRAM3 page 7 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $17 constant PWR_SRAM3PDS8                  \ [0x17] SRAM3 page 8 (64 Kbytes) power-down in Stop modes (Stop 0, 1, 2, 3)
    $18 constant PWR_GPRAMPDS                   \ [0x18] Graphic peripherals (LTDC, GFXMMU) SRAM power-down in Stop modes (Stop 0, 1, 2, 3) Note: LTDC SRAM content is always lost in Stop 2 and Stop 3 modes. It can be retained only in Stop 0 and Stop 1 modes. This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.
    $19 constant PWR_DSIRAMPDS                  \ [0x19] DSI SRAM power-down in Stop modes (Stop 0, 1) DSI SRAM content is always lost in Stop 2 and Stop 3 modes. Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.
    $1f constant PWR_SRDRUN                     \ [0x1f] SmartRun domain in Run mode
  [then]


  [ifdef] PWR_PWR_CR3_DEF
    \
    \ @brief PWR control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant PWR_REGSEL                     \ [0x01] Regulator selection Note: REGSEL is reserved and must be kept at reset value in packages without SMPS.
    $02 constant PWR_FSTEN                      \ [0x02] Fast soft start
  [then]


  [ifdef] PWR_PWR_VOSR_DEF
    \
    \ @brief PWR voltage scaling register
    \ Address offset: 0x0C
    \ Reset value: 0x00008000
    \
    $0d constant PWR_USBBOOSTRDY                \ [0x0d] USB EPOD booster ready This bit is set to 1 by hardware when the power booster startup time is reached. The USB clock can be provided only after this bit is set. Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.
    $0e constant PWR_BOOSTRDY                   \ [0x0e] EPOD booster ready This bit is set to 1 by hardware when the power booster startup time is reached. The system clock frequency can be switched higher than 50 MHz only after this bit is set.
    $0f constant PWR_VOSRDY                     \ [0x0f] Ready bit for VCORE voltage scaling output selection
    $10 constant PWR_VOS                        \ [0x10 : 2] Voltage scaling range selection This field is protected against non-secure access when SYSCLKSEC = 1 in RCC_SECCFGR. It is protected against unprivileged access when SYSCLKSEC = 1 in RCC_SECCFGR and SPRIV = 1 in PWR_PRIVCFGR, or when SYSCLKSEC = 0 and NSPRIV = 1.
    $12 constant PWR_BOOSTEN                    \ [0x12] EPOD booster enable This bit is protected against non-secure access when SYSCLKSEC = 1 in RCC_SECCFGR. It is protected against unprivileged access when SYSCLKSEC = 1 in RCC_SECCFGR and SPRIV = 1 in PWR_PRIVCFGR, or when SYSCLKSEC = 0 and NSPRIV = 1. This bit must be set in range 1 and range 2 before increasing the system clock frequency above 50 MHz. This bit is reset when going into Stop modes (0, 1, 2, 3).
    $13 constant PWR_USBPWREN                   \ [0x13] USB power enable This bit is protected against non-secure access when SYSCLKSEC = 1 in RCC_SECCFGR. It is protected against unprivileged access when SYSCLKSEC = 1 in RCC_SECCFGR and SPRIV = 1 in PWR_PRIVCFGR, or when SYSCLKSEC = 0 and NSPRIV = 1. Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.
    $14 constant PWR_USBBOOSTEN                 \ [0x14] USB EPOD booster enable This bit is protected against non-secure access when SYSCLKSEC = 1 in RCC_SECCFGR. It is protected against unprivileged access when SYSCLKSEC = 1 in RCC_SECCFGR and SPRIV = 1 in PWR_PRIVCFGR, or when SYSCLKSEC = 0 and NSPRIV = 1. This bit must be set in range 1 and range 2 before enabling the USB peripheral. This bit is reset when going into Stop modes (0, 1, 2, 3). Note: This bit is only available in STM32U59x/5Ax. It is reserved in STM32U575/585.
  [then]


  [ifdef] PWR_PWR_SVMCR_DEF
    \
    \ @brief PWR supply voltage monitoring control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant PWR_PVDE                       \ [0x04] Power voltage detector enable
    $05 constant PWR_PVDLS                      \ [0x05 : 3] Power voltage detector level selection These bits select the voltage threshold detected by the power voltage detector:
    $18 constant PWR_UVMEN                      \ [0x18] VDDUSB independent USB voltage monitor enable
    $19 constant PWR_IO2VMEN                    \ [0x19] VDDIO2 independent I/Os voltage monitor enable
    $1a constant PWR_AVM1EN                     \ [0x1a] VDDA independent analog supply voltage monitor 1 enable (1.6 V threshold)
    $1b constant PWR_AVM2EN                     \ [0x1b] VDDA independent analog supply voltage monitor 2 enable (1.8 V threshold)
    $1c constant PWR_USV                        \ [0x1c] VDDUSB independent USB supply valid This bit is used to validate the VDDUSB supply for electrical and logical isolation purpose. Setting this bit is mandatory to use the USB OTG peripheral. If VDDUSB is not always present in the application, the VDDUSB voltage monitor can be used to determine whether this supply is ready or not.
    $1d constant PWR_IO2SV                      \ [0x1d] VDDIO2 independent I/Os supply valid This bit is used to validate the VDDIO2 supply for electrical and logical isolation purpose. Setting this bit is mandatory to use PG[15:2]. If VDDIO2 is not always present in the application, the VDDIO2 voltage monitor can be used to determine whether this supply is ready or not.
    $1e constant PWR_ASV                        \ [0x1e] VDDA independent analog supply valid This bit is used to validate the VDDA supply for electrical and logical isolation purpose. Setting this bit is mandatory to use the analog peripherals. If VDDA is not always present in the application, the VDDA voltage monitor can be used to determine whether this supply is ready or not.
  [then]


  [ifdef] PWR_PWR_WUCR1_DEF
    \
    \ @brief PWR wakeup control register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUPEN1                     \ [0x00] Wakeup pin WKUP1 enable
    $01 constant PWR_WUPEN2                     \ [0x01] Wakeup pin WKUP2 enable
    $02 constant PWR_WUPEN3                     \ [0x02] Wakeup pin WKUP3 enable
    $03 constant PWR_WUPEN4                     \ [0x03] Wakeup pin WKUP4 enable
    $04 constant PWR_WUPEN5                     \ [0x04] Wakeup pin WKUP5 enable
    $05 constant PWR_WUPEN6                     \ [0x05] Wakeup pin WKUP6 enable
    $06 constant PWR_WUPEN7                     \ [0x06] Wakeup pin WKUP7 enable
    $07 constant PWR_WUPEN8                     \ [0x07] Wakeup pin WKUP8 enable
  [then]


  [ifdef] PWR_PWR_WUCR2_DEF
    \
    \ @brief PWR wakeup control register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUPP1                      \ [0x00] Wakeup pin WKUP1 polarity. This bit must be configured when WUPEN1 = 0.
    $01 constant PWR_WUPP2                      \ [0x01] Wakeup pin WKUP2 polarity This bit must be configured when WUPEN2 = 0.
    $02 constant PWR_WUPP3                      \ [0x02] Wakeup pin WKUP3 polarity This bit must be configured when WUPEN3 = 0.
    $03 constant PWR_WUPP4                      \ [0x03] Wakeup pin WKUP4 polarity This bit must be configured when WUPEN4 = 0.
    $04 constant PWR_WUPP5                      \ [0x04] Wakeup pin WKUP5 polarity This bit must be configured when WUPEN5 = 0.
    $05 constant PWR_WUPP6                      \ [0x05] Wakeup pin WKUP6 polarity This bit must be configured when WUPEN6 = 0.
    $06 constant PWR_WUPP7                      \ [0x06] Wakeup pin WKUP7 polarity This bit must be configured when WUPEN7 = 0.
    $07 constant PWR_WUPP8                      \ [0x07] Wakeup pin WKUP8 polarity This bit must be configured when WUPEN8 = 0.
  [then]


  [ifdef] PWR_PWR_WUCR3_DEF
    \
    \ @brief PWR wakeup control register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUSEL1                     \ [0x00 : 2] Wakeup pin WKUP1 selection This field must be configured when WUPEN1 = 0.
    $02 constant PWR_WUSEL2                     \ [0x02 : 2] Wakeup pin WKUP2 selection This field must be configured when WUPEN2 = 0.
    $04 constant PWR_WUSEL3                     \ [0x04 : 2] Wakeup pin WKUP3 selection This field must be configured when WUPEN3 = 0.
    $06 constant PWR_WUSEL4                     \ [0x06 : 2] Wakeup pin WKUP4 selection This field must be configured when WUPEN4 = 0.
    $08 constant PWR_WUSEL5                     \ [0x08 : 2] Wakeup pin WKUP5 selection This field must be configured when WUPEN5 = 0.
    $0a constant PWR_WUSEL6                     \ [0x0a : 2] Wakeup pin WKUP6 selection This field must be configured when WUPEN6 = 0.
    $0c constant PWR_WUSEL7                     \ [0x0c : 2] Wakeup pin WKUP7 selection This field must be configured when WUPEN7 = 0.
    $0e constant PWR_WUSEL8                     \ [0x0e : 2] Wakeup pin WKUP8 selection This field must be configured when WUPEN8 = 0.
  [then]


  [ifdef] PWR_PWR_BDCR1_DEF
    \
    \ @brief PWR Backup domain control register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BREN                       \ [0x00] Backup RAM retention in Standby and VBAT modes When this bit is set, the backup RAM content is kept in Standby and VBAT modes. If BREN is reset, the backup RAM can still be used in Run, Sleep and Stop modes. However, its content is lost in Standby, Shutdown and VBAT modes. This bit can be written only when the regulator is LDO, which must be configured before switching to SMPS. Note: Backup RAM cannot be preserved in Shutdown mode.
    $04 constant PWR_MONEN                      \ [0x04] Backup domain voltage and temperature monitoring enable
  [then]


  [ifdef] PWR_PWR_BDCR2_DEF
    \
    \ @brief PWR Backup domain control register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_VBE                        \ [0x00] VBAT charging enable
    $01 constant PWR_VBRS                       \ [0x01] VBAT charging resistor selection
  [then]


  [ifdef] PWR_PWR_DBPR_DEF
    \
    \ @brief PWR disable Backup domain register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_DBP                        \ [0x00] Disable Backup domain write protection In reset state, all registers and SRAM in Backup domain are protected against parasitic write access. This bit must be set to enable the write access to these registers.
  [then]


  [ifdef] PWR_PWR_UCPDR_DEF
    \
    \ @brief PWR USB Type-C™ and Power Delivery register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_UCPD_DBDIS                 \ [0x00] UCPD dead battery disable After exiting reset, the USB Type-C “dead battery” behavior is enabled, which may have a pull-down effect on CC1 and CC2 pins. It is recommended to disable it in all cases, either to stop this pull-down or to handover control to the UCPD (the UCPD must be initialized before doing the disable).
    $01 constant PWR_UCPD_STBY                  \ [0x01] UCPD Standby mode When set, this bit is used to memorize the UCPD configuration in Standby mode. This bit must be written to 1 just before entering Standby mode when using UCPD. It must be written to 0 after exiting the Standby mode and before writing any UCPD registers.
  [then]


  [ifdef] PWR_PWR_SECCFGR_DEF
    \
    \ @brief PWR security configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUP1SEC                    \ [0x00] WUP1 secure protection
    $01 constant PWR_WUP2SEC                    \ [0x01] WUP2 secure protection
    $02 constant PWR_WUP3SEC                    \ [0x02] WUP3 secure protection
    $03 constant PWR_WUP4SEC                    \ [0x03] WUP4 secure protection
    $04 constant PWR_WUP5SEC                    \ [0x04] WUP5 secure protection
    $05 constant PWR_WUP6SEC                    \ [0x05] WUP6 secure protection
    $06 constant PWR_WUP7SEC                    \ [0x06] WUP7 secure protection
    $07 constant PWR_WUP8SEC                    \ [0x07] WUP8 secure protection
    $0c constant PWR_LPMSEC                     \ [0x0c] Low-power modes secure protection
    $0d constant PWR_VDMSEC                     \ [0x0d] Voltage detection and monitoring secure protection
    $0e constant PWR_VBSEC                      \ [0x0e] Backup domain secure protection
    $0f constant PWR_APCSEC                     \ [0x0f] Pull-up/pull-down secure protection
  [then]


  [ifdef] PWR_PWR_PRIVCFGR_DEF
    \
    \ @brief PWR privilege control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWR_SPRIV                      \ [0x00] PWR secure functions privilege configuration This bit is set and reset by software. It can be written only by a secure privileged access.
    $01 constant PWR_NSPRIV                     \ [0x01] PWR non-secure functions privilege configuration This bit is set and reset by software. It can be written only by privileged access, secure or non-secure.
  [then]


  [ifdef] PWR_PWR_SR_DEF
    \
    \ @brief PWR status register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CSSF                       \ [0x00] Clear Stop and Standby flags This bit is protected against non-secure access when LPMSEC = 1 in PWR_SECCFGR. This bit is protected against unprivileged access when LPMSEC = 1 and SPRIV = 1 in PWR_PRIVCFGR, or when LPMSEC = 0 and NSPRIV = 1. Writing 1 to this bit clears the STOPF and SBF flags.
    $01 constant PWR_STOPF                      \ [0x01] Stop flag This bit is set by hardware when the device enters a Stop mode, and is cleared by software by writing 1 to the CSSF bit.
    $02 constant PWR_SBF                        \ [0x02] Standby flag This bit is set by hardware when the device enters the Standby mode, and is cleared by writing 1 to the CSSF bit, or by a power-on reset. It is not cleared by the system reset.
  [then]


  [ifdef] PWR_PWR_SVMSR_DEF
    \
    \ @brief PWR supply voltage monitoring status register
    \ Address offset: 0x3C
    \ Reset value: 0x00008000
    \
    $01 constant PWR_REGS                       \ [0x01] Regulator selection
    $04 constant PWR_PVDO                       \ [0x04] VDD voltage detector output
    $0f constant PWR_ACTVOSRDY                  \ [0x0f] Voltage level ready for currently used VOS
    $10 constant PWR_ACTVOS                     \ [0x10 : 2] VOS currently applied to VCORE This field provides the last VOS value.
    $18 constant PWR_VDDUSBRDY                  \ [0x18] VDDUSB ready
    $19 constant PWR_VDDIO2RDY                  \ [0x19] VDDIO2 ready
    $1a constant PWR_VDDA1RDY                   \ [0x1a] VDDA ready versus 1.6V voltage monitor
    $1b constant PWR_VDDA2RDY                   \ [0x1b] VDDA ready versus 1.8 V voltage monitor
  [then]


  [ifdef] PWR_PWR_BDSR_DEF
    \
    \ @brief PWR Backup domain status register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $01 constant PWR_VBATH                      \ [0x01] Backup domain voltage level monitoring versus high threshold
    $02 constant PWR_TEMPL                      \ [0x02] Temperature level monitoring versus low threshold
    $03 constant PWR_TEMPH                      \ [0x03] Temperature level monitoring versus high threshold
  [then]


  [ifdef] PWR_PWR_WUSR_DEF
    \
    \ @brief PWR wakeup status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUF1                       \ [0x00] Wakeup flag 1 This bit is set when a wakeup event is detected on WKUP1 pin. This bit is cleared by writing 1 in the CWUF1 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN1 = 0.
    $01 constant PWR_WUF2                       \ [0x01] Wakeup flag 2 This bit is set when a wakeup event is detected on WKUP2 pin. This bit is cleared by writing 1 in the CWUF2 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN2 = 0.
    $02 constant PWR_WUF3                       \ [0x02] Wakeup flag 3 This bit is set when a wakeup event is detected on WKUP3 pin. This bit is cleared by writing 1 in the CWUF3 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN3 = 0.
    $03 constant PWR_WUF4                       \ [0x03] Wakeup flag 4 This bit is set when a wakeup event is detected on WKUP4 pin. This bit is cleared by writing 1 in the CWUF4 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN4 = 0.
    $04 constant PWR_WUF5                       \ [0x04] Wakeup flag 5 This bit is set when a wakeup event is detected on WKUP5 pin. This bit is cleared by writing 1 in the CWUF5 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN5 = 0.
    $05 constant PWR_WUF6                       \ [0x05] Wakeup flag 6 This bit is set when a wakeup event is detected on WKUP6 pin. This bit is cleared by writing 1 in the CWUF6 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN6 = 0. If WUSEL = 11, this bit is cleared by hardware when all internal wakeup source are cleared.
    $06 constant PWR_WUF7                       \ [0x06] Wakeup flag 7 This bit is set when a wakeup event is detected on WKUP7 pin. This bit is cleared by writing 1 in the CWUF7 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN7 = 0. If WUSEL = 11, this bit is cleared by hardware when all internal wakeup source are cleared.
    $07 constant PWR_WUF8                       \ [0x07] Wakeup flag 8 This bit is set when a wakeup event is detected on WKUP8 pin. This bit is cleared by writing 1 in the CWUF8 bit of PWR_WUSCR when WUSEL ≠ 11, or by hardware when WUPEN8 = 0. If WUSEL = 11, this bit is cleared by hardware when all internal wakeup source are cleared.
  [then]


  [ifdef] PWR_PWR_WUSCR_DEF
    \
    \ @brief PWR wakeup status clear register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CWUF1                      \ [0x00] Wakeup flag 1 Writing 1 to this bit clears the WUF1 flag in PWR_WUSR.
    $01 constant PWR_CWUF2                      \ [0x01] Wakeup flag 2 Writing 1 to this bit clears the WUF2 flag in PWR_WUSR.
    $02 constant PWR_CWUF3                      \ [0x02] Wakeup flag 3 Writing 1 to this bit clears the WUF3 flag in PWR_WUSR.
    $03 constant PWR_CWUF4                      \ [0x03] Wakeup flag 4 Writing 1 to this bit clears the WUF4 flag in PWR_WUSR.
    $04 constant PWR_CWUF5                      \ [0x04] Wakeup flag 5 Writing 1 to this bit clears the WUF5 flag in PWR_WUSR.
    $05 constant PWR_CWUF6                      \ [0x05] Wakeup flag 6 Writing 1 to this bit clears the WUF6 flag in PWR_WUSR.
    $06 constant PWR_CWUF7                      \ [0x06] Wakeup flag 7 Writing 1 to this bit clears the WUF7 flag in PWR_WUSR.
    $07 constant PWR_CWUF8                      \ [0x07] Wakeup flag 8 Writing 1 to this bit clears the WUF8 flag in PWR_WUSR.
  [then]


  [ifdef] PWR_PWR_APCR_DEF
    \
    \ @brief PWR apply pull configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_APC                        \ [0x00] Apply pull-up and pull-down configuration When this bit is set, the I/O pull-up and pull-down configurations defined in PWR_PUCRx and PWR_PDCRx are applied. When this bit is cleared, PWR_PUCRx and PWR_PDCRx are not applied to the I/Os.
  [then]


  [ifdef] PWR_PWR_PUCRA_DEF
    \
    \ @brief PWR port A pull-up control register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0f constant PWR_PU15                       \ [0x0f] Port A pull-up bit 15 When set, this bit activates the pull-up on PA15 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding PD15 bit is also set.
  [then]


  [ifdef] PWR_PWR_PDCRA_DEF
    \
    \ @brief PWR port A pull-down control register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0e constant PWR_PD14                       \ [0x0e] Port A pull-down bit 14 When set, this bit activates the pull-down on PA14 when the APC bit is set in PWR_APCR.
  [then]


  [ifdef] PWR_PWR_PUCRB_DEF
    \
    \ @brief PWR port B pull-up control register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] PU15
  [then]


  [ifdef] PWR_PWR_PDCRB_DEF
    \
    \ @brief PWR port B pull-down control register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] PD15
  [then]


  [ifdef] PWR_PWR_PUCRC_DEF
    \
    \ @brief Power port C pull up control register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] PU15
  [then]


  [ifdef] PWR_PWR_PDCRC_DEF
    \
    \ @brief PWR port C pull-down control register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] PD15
  [then]


  [ifdef] PWR_PWR_PUCRD_DEF
    \
    \ @brief PWR port D pull-up control register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] PU15
  [then]


  [ifdef] PWR_PWR_PDCRD_DEF
    \
    \ @brief PWR port D pull-down control register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] PD15
  [then]


  [ifdef] PWR_PWR_PUCRE_DEF
    \
    \ @brief PWR port E pull-up control register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] PU15
  [then]


  [ifdef] PWR_PWR_PDCRE_DEF
    \
    \ @brief PWR port E pull-down control register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] PD15
  [then]


  [ifdef] PWR_PWR_PUCRF_DEF
    \
    \ @brief PWR port F pull-up control register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] PU15
  [then]


  [ifdef] PWR_PWR_PDCRF_DEF
    \
    \ @brief PWR port F pull-down control register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] PD15
  [then]


  [ifdef] PWR_PWR_PUCRG_DEF
    \
    \ @brief PWR port G pull-up control register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] PU15
  [then]


  [ifdef] PWR_PWR_PDCRG_DEF
    \
    \ @brief PWR port G pull-down control register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] PD15
  [then]


  [ifdef] PWR_PWR_PUCRH_DEF
    \
    \ @brief PWR port H pull-up control register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] PU15
  [then]


  [ifdef] PWR_PWR_PDCRH_DEF
    \
    \ @brief PWR port H pull-down control register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] PD15
  [then]


  [ifdef] PWR_PWR_PUCRI_DEF
    \
    \ @brief PWR port I pull-up control register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] PU15
  [then]


  [ifdef] PWR_PWR_PDCRI_DEF
    \
    \ @brief PWR port I pull-down control register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] PD15
  [then]


  [ifdef] PWR_PWR_PUCRJ_DEF
    \
    \ @brief PWR port J pull-up control register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
  [then]


  [ifdef] PWR_PWR_PDCRJ_DEF
    \
    \ @brief PWR port J pull-down control register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
  [then]


  [ifdef] PWR_PWR_CR4_DEF
    \
    \ @brief PWR control register 4
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant PWR_SRAM1PDS4                  \ [0x00] SRAM1PDS4
    $01 constant PWR_SRAM1PDS5                  \ [0x01] SRAM1PDS5
    $02 constant PWR_SRAM1PDS6                  \ [0x02] SRAM1PDS6
    $03 constant PWR_SRAM1PDS7                  \ [0x03] SRAM1PDS7
    $04 constant PWR_SRAM1PDS8                  \ [0x04] SRAM1PDS8
    $05 constant PWR_SRAM1PDS9                  \ [0x05] SRAM1PDS9
    $06 constant PWR_SRAM1PDS10                 \ [0x06] SRAM1PDS10
    $07 constant PWR_SRAM1PDS11                 \ [0x07] SRAM1PDS11
    $08 constant PWR_SRAM1PDS12                 \ [0x08] SRAM1PDS12
    $0a constant PWR_SRAM3PDS9                  \ [0x0a] SRAM3PDS9
    $0b constant PWR_SRAM3PDS10                 \ [0x0b] SRAM3PDS10
    $0c constant PWR_SRAM3PDS11                 \ [0x0c] SRAM3PDS11
    $0d constant PWR_SRAM3PDS12                 \ [0x0d] SRAM3PDS12
    $0e constant PWR_SRAM3PDS13                 \ [0x0e] SRAM3PDS13
    $10 constant PWR_SRAM5PDS1                  \ [0x10] SRAM5PDS1
    $11 constant PWR_SRAM5PDS2                  \ [0x11] SRAM5PDS2
    $12 constant PWR_SRAM5PDS3                  \ [0x12] SRAM5PDS3
    $13 constant PWR_SRAM5PDS4                  \ [0x13] SRAM5PDS4
    $14 constant PWR_SRAM5PDS5                  \ [0x14] SRAM5PDS5
    $15 constant PWR_SRAM5PDS6                  \ [0x15] SRAM5PDS6
    $16 constant PWR_SRAM5PDS7                  \ [0x16] SRAM5PDS7
    $17 constant PWR_SRAM5PDS8                  \ [0x17] SRAM5PDS8
    $18 constant PWR_SRAM5PDS9                  \ [0x18] SRAM5PDS9
    $19 constant PWR_SRAM5PDS10                 \ [0x19] SRAM5PDS10
    $1a constant PWR_SRAM5PDS11                 \ [0x1a] SRAM5PDS11
    $1b constant PWR_SRAM5PDS12                 \ [0x1b] SRAM5PDS12
    $1c constant PWR_SRAM5PDS13                 \ [0x1c] SRAM5PDS13
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_PWR_CR1              \ PWR control register 1
  $04 constant PWR_PWR_CR2              \ PWR control register 2
  $08 constant PWR_PWR_CR3              \ PWR control register 3
  $0C constant PWR_PWR_VOSR             \ PWR voltage scaling register
  $10 constant PWR_PWR_SVMCR            \ PWR supply voltage monitoring control register
  $14 constant PWR_PWR_WUCR1            \ PWR wakeup control register 1
  $18 constant PWR_PWR_WUCR2            \ PWR wakeup control register 2
  $1C constant PWR_PWR_WUCR3            \ PWR wakeup control register 3
  $20 constant PWR_PWR_BDCR1            \ PWR Backup domain control register 1
  $24 constant PWR_PWR_BDCR2            \ PWR Backup domain control register 2
  $28 constant PWR_PWR_DBPR             \ PWR disable Backup domain register
  $2C constant PWR_PWR_UCPDR            \ PWR USB Type-C™ and Power Delivery register
  $30 constant PWR_PWR_SECCFGR          \ PWR security configuration register
  $34 constant PWR_PWR_PRIVCFGR         \ PWR privilege control register
  $38 constant PWR_PWR_SR               \ PWR status register
  $3C constant PWR_PWR_SVMSR            \ PWR supply voltage monitoring status register
  $40 constant PWR_PWR_BDSR             \ PWR Backup domain status register
  $44 constant PWR_PWR_WUSR             \ PWR wakeup status register
  $48 constant PWR_PWR_WUSCR            \ PWR wakeup status clear register
  $4C constant PWR_PWR_APCR             \ PWR apply pull configuration register
  $50 constant PWR_PWR_PUCRA            \ PWR port A pull-up control register
  $54 constant PWR_PWR_PDCRA            \ PWR port A pull-down control register
  $58 constant PWR_PWR_PUCRB            \ PWR port B pull-up control register
  $5C constant PWR_PWR_PDCRB            \ PWR port B pull-down control register
  $60 constant PWR_PWR_PUCRC            \ Power port C pull up control register
  $64 constant PWR_PWR_PDCRC            \ PWR port C pull-down control register
  $68 constant PWR_PWR_PUCRD            \ PWR port D pull-up control register
  $6C constant PWR_PWR_PDCRD            \ PWR port D pull-down control register
  $70 constant PWR_PWR_PUCRE            \ PWR port E pull-up control register
  $74 constant PWR_PWR_PDCRE            \ PWR port E pull-down control register
  $78 constant PWR_PWR_PUCRF            \ PWR port F pull-up control register
  $7C constant PWR_PWR_PDCRF            \ PWR port F pull-down control register
  $80 constant PWR_PWR_PUCRG            \ PWR port G pull-up control register
  $84 constant PWR_PWR_PDCRG            \ PWR port G pull-down control register
  $88 constant PWR_PWR_PUCRH            \ PWR port H pull-up control register
  $8C constant PWR_PWR_PDCRH            \ PWR port H pull-down control register
  $90 constant PWR_PWR_PUCRI            \ PWR port I pull-up control register
  $94 constant PWR_PWR_PDCRI            \ PWR port I pull-down control register
  $98 constant PWR_PWR_PUCRJ            \ PWR port J pull-up control register
  $9C constant PWR_PWR_PDCRJ            \ PWR port J pull-down control register
  $A8 constant PWR_PWR_CR4              \ PWR control register 4

: PWR_DEF ; [then]
