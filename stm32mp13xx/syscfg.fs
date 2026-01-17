\
\ @file syscfg.fs
\ @brief SYSCFG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_SYSCFG_BOOTR_DEF
    \
    \ @brief SYSCFG boot pins control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_BOOT0                   \ [0x00] BOOT0 pin value
    $01 constant SYSCFG_BOOT1                   \ [0x01] BOOT1 pin value
    $02 constant SYSCFG_BOOT2                   \ [0x02] BOOT2 pin value
  [then]


  [ifdef] SYSCFG_SYSCFG_PMCSETR_DEF
    \
    \ @brief SYSCFG peripheral mode configuration set register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C1_FMP                \ [0x00] Fast Mode Plus (FM+) Enable Set by software.
    $01 constant SYSCFG_I2C2_FMP                \ [0x01] Fast Mode Plus (FM+) Enable Set by software.
    $02 constant SYSCFG_I2C3_FMP                \ [0x02] Fast Mode Plus (FM+) Enable Set by software. This bit is secure if I2C3 is set to secure in the ETZPC.
    $03 constant SYSCFG_I2C4_FMP                \ [0x03] Fast Mode Plus (FM+) Enable Set by software. This bit is secure if I2C4 is set to secure in the ETZPC.
    $04 constant SYSCFG_I2C5_FMP                \ [0x04] Fast mode plus (FM+) enable Set by software. This bit is secure if I2C5 is set to secure in the ETZPC.
    $08 constant SYSCFG_EN_BOOSTER              \ [0x08] GPIO analog switch supply voltage booster enable. Set by software. Used to reduce the total harmonic distortion of the I/O analog switches when VDDA and VDD supplies are below 2.7Â V. Activating the booster guarantees the AC performance on I/O analog switches. When activated the performance of the analog switch is the same over the full voltage range. This bit is always secure.
    $09 constant SYSCFG_ANASWVDD                \ [0x09] GPIO analog switch supply voltage selection Cleared by software. This bit is always secure.
    $10 constant SYSCFG_ETH1_CLK_SEL            \ [0x10] Gigabit Ethernet 125Â MHz clock selection. Only useful with RGMII PHY. Set by software. This bit is secure if ETH1 is set to secure in the ETZPC.
    $11 constant SYSCFG_ETH1_REF_CLK_SEL        \ [0x11] Ethernet reference clock selection. Set by software. This bit is secure if ETH1 is set to secure in the ETZPC.
    $15 constant SYSCFG_ETH1_SEL                \ [0x15 : 3] Ethernet PHY interface selection. Set by software. Writing '0' has no effect. Set individual bits by writing '1â. Reading means: Note: Configuration must be done while the ETH is under reset and before enabling the ETH clocks This bit field is secure if ETH1 is set to secure in the ETZPC.
    $18 constant SYSCFG_ETH2_CLK_SEL            \ [0x18] Gigabit Ethernet 125Â MHz clock selection. Only useful with RGMII PHY. Set by software. This bit is secure if ETH2 is set to secure in the ETZPC.
    $19 constant SYSCFG_ETH2_REF_CLK_SEL        \ [0x19] Ethernet reference clock selection. Set by software. This bit is secure if ETH2 is set to secure in the ETZPC.
    $1d constant SYSCFG_ETH2_SEL                \ [0x1d : 3] Ethernet PHY interface selection. Set by software. Writing '0' has no effect. Set individual bits by writing '1â. Reading means: Note: Configuration must be done while the ETH is under reset and before enabling the ETH clocks This bit field is secure if ETH2 is set to secure in the ETZPC.
  [then]


  [ifdef] SYSCFG_SYSCFG_PMCCLRR_DEF
    \
    \ @brief SYSCFG peripheral mode configuration clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C1_FMP                \ [0x00] Fast Mode Plus (FM+) Enable Cleared by software.
    $01 constant SYSCFG_I2C2_FMP                \ [0x01] Fast Mode Plus (FM+) Enable Cleared by software.
    $02 constant SYSCFG_I2C3_FMP                \ [0x02] Fast Mode Plus (FM+) Enable Cleared by software. This bit is secure if I2C3 is set to secure in the ETZPC.
    $03 constant SYSCFG_I2C4_FMP                \ [0x03] Fast Mode Plus (FM+) Enable Cleared by software. This bit is secure if I2C4 is set to secure in the ETZPC.
    $04 constant SYSCFG_I2C5_FMP                \ [0x04] Fast Mode Plus (FM+) Enable Cleared by software. This bit is secure if I2C5 is set to secure in the ETZPC.
    $08 constant SYSCFG_EN_BOOSTER              \ [0x08] GPIO analog switch supply voltage booster enable. Cleared by software. Used to reduce the Total harmonic distortion of the I/O analog switches when VDDA and VDD supplies are below 2.7Â V. Activating the booster guarantees the AC performance on I/O analog switches. When activated the performance of the analog switch is the same over the full voltage range. This bit is always secure.
    $09 constant SYSCFG_ANASWVDD                \ [0x09] GPIO analog switch supply voltage selection Cleared by software. (if present and EN_BOOSTER=0) or by the booster output (EN_BOOSTER=1) This bit is always secure.
    $10 constant SYSCFG_ETH1_CLK_SEL            \ [0x10] Gigabit Ethernet 125Â MHz clock selection. Only useful with RGMII PHY. Set by software. This bit is secure if ETH1 is set to secure in the ETZPC
    $11 constant SYSCFG_ETH1_REF_CLK_SEL        \ [0x11] Ethernet reference clock selection. Set by software. This bit is secure if ETH1 is set to secure in the ETZPC
    $15 constant SYSCFG_ETH1_SEL                \ [0x15 : 3] Ethernet PHY interface selection. Set by software. Writing '0' has no effect. Clear individual bits by writing '1â. Reading means: Note: Configuration must be done while the ETH is under reset and before enabling the ETH clocks This bit field is secure if ETH1 is set to secure in the ETZPC.
    $18 constant SYSCFG_ETH2_CLK_SEL            \ [0x18] Gigabit Ethernet 125Â MHz clock selection. Only useful with RGMII PHY. Set by software. This bit is secure if ETH2 is set to secure in the ETZPC.
    $19 constant SYSCFG_ETH2_REF_CLK_SEL        \ [0x19] Ethernet reference clock selection. Set by software. This bit is secure if ETH2 is set to secure in the ETZPC.
    $1d constant SYSCFG_ETH2_SEL                \ [0x1d : 3] Ethernet PHY interface selection. Set by software. Writing '0' has no effect. Clear individual bits by writing '1â. Reading means: Note: Configuration must be done while the ETH is under reset and before enabling the ETH clocks This bit field is secure if ETH2 is set to secure in the ETZPC.
  [then]


  [ifdef] SYSCFG_SYSCFG_BOOTCR_DEF
    \
    \ @brief SYSCFG boot control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_BMEN                    \ [0x00] Boot mode enable This bit is writable only by secure privileged code. It should be used only during secure boot time, to ensure the timely execution of the firmware in charge of tamper management. When this bit is cleared from 1 to 0 while a potential tamper event is active, accesses to SRAM3 are automatically blocked (as defined above) and PKA, SAES, HASH and CRYP peripherals are reset. When a confirmed (not potential) tamper is raised by TAMP peripheral, SRAM3 is erased (as defined in TAMP) and PKA, SAES, HASH and CRYP peripherals are reset regardless of BMEN value.
  [then]


  [ifdef] SYSCFG_SYSCFG_SRAM3ERASER_DEF
    \
    \ @brief SYSCFG SRAM3 erase register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SRAM3ER                 \ [0x00] SRAM3 erase request This bit is set by software and automatically reset by hardware at the end of the erase operation. It can only be set if the correct unlock sequence has previously been written to the SYSCFG_SRAM3KR.KEY[7:0] register field. This bit is secure if SRAM3 is set to secure in the ETZPC.
    $01 constant SYSCFG_SRAM3EO                 \ [0x01] SRAM3 erase ongoing This bit indicates whether an erase of SRAM3 is being carried out, whatever the trigger (tamper or software).
  [then]


  [ifdef] SYSCFG_SYSCFG_SRAM3KR_DEF
    \
    \ @brief SYSCFG SRAM3 erase key register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_KEY                     \ [0x00 : 8] SRAM3 software erase key Writing the following sequence to KEY[7:0] unlocks the SRAM3 software erase feature: 0xCA 0x53 Writing any other value locks the feature.
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPCR_DEF
    \
    \ @brief SYSCFG main compensation cell control register
    \ Address offset: 0x20
    \ Reset value: 0x00870000
    \
    $01 constant SYSCFG_SW_CTRL                 \ [0x01] Compensation software control Note: SW_CTRL = 0 is not taken into account until READY = 1. This means that whatever SW_CTRL value, the RANSRC[3:0] and RAPSRC[3:0] are used for I/O compensation when the compensation cell is in power down (EN = 0, which is the case after a reset).
    $08 constant SYSCFG_READY                   \ [0x08] Compensation cell ready flag
    $10 constant SYSCFG_RANSRC                  \ [0x10 : 4] NMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation
    $14 constant SYSCFG_RAPSRC                  \ [0x14 : 4] PMOS I/O Compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation
    $18 constant SYSCFG_ANSRC                   \ [0x18 : 4] NMOS I/O compensation value provided by compensation cell Value sent to I/Os when SW_CTRL = 0 and READY = 1.
    $1c constant SYSCFG_APSRC                   \ [0x1c : 4] PMOS I/O compensation value provided by compensation cell Value sent to I/O compensation when SW_CTRL = 0 and READY = 1.
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPENSETR_DEF
    \
    \ @brief SYSCFG main compensation cell enable set register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EN                      \ [0x00] Compensation cell enable Set by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0.
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPENCLRR_DEF
    \
    \ @brief SYSCFG main compensation cell enable set register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EN                      \ [0x00] Compensation cell enable Cleared by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0.
  [then]


  [ifdef] SYSCFG_SYSCFG_CBR_DEF
    \
    \ @brief SYSCFG control timer break register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $02 constant SYSCFG_PVDL                    \ [0x02] PVD lock enable bit This bit is set by software and cleared only by a system reset. It can be used to enable and lock the PVD connection to TIM1/8/15/16/17 Break input, as well as the PVDE and PLS[2:0] in the PWR_CR1 register.
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPSD1CR_DEF
    \
    \ @brief SYSCFG VDDSD1 compensation cell control register
    \ Address offset: 0x30
    \ Reset value: 0x00870000
    \
    $01 constant SYSCFG_SW_CTRL                 \ [0x01] Compensation software control Note: SW_CTRL = 0 is not taken into account until READY = 1. This means that whatever SW_CTRL value, the RANSRC[3:0] and RAPSRC[3:0] are used for I/O compensation when the compensation cell is in power down (EN = 0, which is the case after a reset). This bit is secure if SDMMC1 is set to secure in the ETZPC.
    $08 constant SYSCFG_READY                   \ [0x08] Compensation cell ready flag
    $10 constant SYSCFG_RANSRC                  \ [0x10 : 4] NMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation This bit field is secure if SDMMC1 is set to secure in the ETZPC.
    $14 constant SYSCFG_RAPSRC                  \ [0x14 : 4] PMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation This bit field is secure if SDMMC1 is set to secure in the ETZPC.
    $18 constant SYSCFG_ANSRC                   \ [0x18 : 4] NMOS I/O Compensation value provided by compensation cell Value sent to I/Os when SW_CTRL = 0 and READY = 1.
    $1c constant SYSCFG_APSRC                   \ [0x1c : 4] PMOS I/O Compensation value provided by compensation cell Value sent to I/Os compensation when SW_CTRL = 0 and READY = 1.
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPSD1ENSETR_DEF
    \
    \ @brief SYSCFG VDDSD1 compensation cell enable set register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EN                      \ [0x00] Compensation cell enable Set by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if MPU_EN is set to 0. This bit is secure if SDMMC1 is set to secure in the ETZPC.
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPSD1ENCLRR_DEF
    \
    \ @brief SYSCFG VDDSD1 compensation cell enable clear register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EN                      \ [0x00] Compensation cell enable Cleared by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0. This bit is secure if SDMMC1 is set to secure in the ETZPC.
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPSD2CR_DEF
    \
    \ @brief SYSCFG VDDSD2 compensation cell control register
    \ Address offset: 0x40
    \ Reset value: 0x00870000
    \
    $01 constant SYSCFG_SW_CTRL                 \ [0x01] Compensation Software Control Note: SW_CTRL = 0 is not taken into account until READY = 1. This means that whatever SW_CTRL value, the RANSRC[3:0] and RAPSRC[3:0] are used for I/O compensation when the compensation cell is in power down (EN = 0, which is the case after a reset). This bit is secure if SDMMC2 is set to secure in the ETZPC
    $08 constant SYSCFG_READY                   \ [0x08] Compensation cell ready flag
    $10 constant SYSCFG_RANSRC                  \ [0x10 : 4] NMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation This bit field is secure if SDMMC2 is set to secure in the ETZPC.
    $14 constant SYSCFG_RAPSRC                  \ [0x14 : 4] PMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation This bit field is secure if SDMMC2 is set to secure in the ETZPC.
    $18 constant SYSCFG_ANSRC                   \ [0x18 : 4] NMOS I/O Compensation value provided by compensation cell Value sent to I/Os when SW_CTRL = 0 and READY = 1
    $1c constant SYSCFG_APSRC                   \ [0x1c : 4] PMOS I/O Compensation value provided by compensation cell Value sent to I/Os compensation when SW_CTRL = 0 and READY = 1
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPSD2ENSETR_DEF
    \
    \ @brief SYSCFG VDDSD2 compensation cell enable set register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EN                      \ [0x00] Compensation cell enable Set by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0. This bit is secure if SDMMC2 is set to secure in the ETZPC.
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPSD2ENCLRR_DEF
    \
    \ @brief SYSCFG VDDSD2 compensation cell enable clear register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EN                      \ [0x00] Compensation cell enable Cleared by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0. This bit is secure if SDMMC2 is set to secure in the ETZPC.
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN0R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 0
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN1R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 1
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN2R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 2
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN3R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 3
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN4R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 4
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN5R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 5
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN6R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 6
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN7R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 7
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN8R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 8
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN9R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 9
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN10R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 10
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_HSLVEN11R_DEF
    \
    \ @brief SYSCFG high-speed low-voltage enable register 11
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN                  \ [0x00 : 16] High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:
  [then]


  [ifdef] SYSCFG_SYSCFG_IDC_DEF
    \
    \ @brief SYSCFG identity code register
    \ Address offset: 0x380
    \ Reset value: 0x10006501
    \
    $00 constant SYSCFG_DEV_ID                  \ [0x00 : 12] device ID
    $10 constant SYSCFG_REV_ID                  \ [0x10 : 16] device revision 0x1000 = Rev. 1
  [then]


  [ifdef] SYSCFG_SYSCFG_VERR_DEF
    \
    \ @brief SYSCFG version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000030
    \
    $00 constant SYSCFG_MINREV                  \ [0x00 : 4] Minor revision These bits return the SYSCFG minor revision. Minor revision is 0.
    $04 constant SYSCFG_MAJREV                  \ [0x04 : 4] Major revision These bits return the SYSCFG major revision. Major revision is 3.
  [then]


  [ifdef] SYSCFG_SYSCFG_IPIDR_DEF
    \
    \ @brief SYSCFG identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00030001
    \
    $00 constant SYSCFG_ID                      \ [0x00 : 32] SYSCFG identifier These bits return the SYSCFG identifier value.
  [then]


  [ifdef] SYSCFG_SYSCFG_SIDR_DEF
    \
    \ @brief SYSCFG size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant SYSCFG_SID                     \ [0x00 : 32] Size identification These bits return the size of the memory region allocated to SYSCFG registers.
  [then]

  \
  \ @brief SYSCFG
  \
  $00 constant SYSCFG_SYSCFG_BOOTR      \ SYSCFG boot pins control register
  $04 constant SYSCFG_SYSCFG_PMCSETR    \ SYSCFG peripheral mode configuration set register
  $08 constant SYSCFG_SYSCFG_PMCCLRR    \ SYSCFG peripheral mode configuration clear register
  $0C constant SYSCFG_SYSCFG_BOOTCR     \ SYSCFG boot control register
  $10 constant SYSCFG_SYSCFG_SRAM3ERASER    \ SYSCFG SRAM3 erase register
  $14 constant SYSCFG_SYSCFG_SRAM3KR    \ SYSCFG SRAM3 erase key register
  $20 constant SYSCFG_SYSCFG_CMPCR      \ SYSCFG main compensation cell control register
  $24 constant SYSCFG_SYSCFG_CMPENSETR  \ SYSCFG main compensation cell enable set register
  $28 constant SYSCFG_SYSCFG_CMPENCLRR  \ SYSCFG main compensation cell enable set register
  $2C constant SYSCFG_SYSCFG_CBR        \ SYSCFG control timer break register
  $30 constant SYSCFG_SYSCFG_CMPSD1CR   \ SYSCFG VDDSD1 compensation cell control register
  $34 constant SYSCFG_SYSCFG_CMPSD1ENSETR    \ SYSCFG VDDSD1 compensation cell enable set register
  $38 constant SYSCFG_SYSCFG_CMPSD1ENCLRR    \ SYSCFG VDDSD1 compensation cell enable clear register
  $40 constant SYSCFG_SYSCFG_CMPSD2CR   \ SYSCFG VDDSD2 compensation cell control register
  $44 constant SYSCFG_SYSCFG_CMPSD2ENSETR    \ SYSCFG VDDSD2 compensation cell enable set register
  $48 constant SYSCFG_SYSCFG_CMPSD2ENCLRR    \ SYSCFG VDDSD2 compensation cell enable clear register
  $50 constant SYSCFG_SYSCFG_HSLVEN0R   \ SYSCFG high-speed low-voltage enable register 0
  $54 constant SYSCFG_SYSCFG_HSLVEN1R   \ SYSCFG high-speed low-voltage enable register 1
  $58 constant SYSCFG_SYSCFG_HSLVEN2R   \ SYSCFG high-speed low-voltage enable register 2
  $5C constant SYSCFG_SYSCFG_HSLVEN3R   \ SYSCFG high-speed low-voltage enable register 3
  $60 constant SYSCFG_SYSCFG_HSLVEN4R   \ SYSCFG high-speed low-voltage enable register 4
  $64 constant SYSCFG_SYSCFG_HSLVEN5R   \ SYSCFG high-speed low-voltage enable register 5
  $68 constant SYSCFG_SYSCFG_HSLVEN6R   \ SYSCFG high-speed low-voltage enable register 6
  $6C constant SYSCFG_SYSCFG_HSLVEN7R   \ SYSCFG high-speed low-voltage enable register 7
  $70 constant SYSCFG_SYSCFG_HSLVEN8R   \ SYSCFG high-speed low-voltage enable register 8
  $74 constant SYSCFG_SYSCFG_HSLVEN9R   \ SYSCFG high-speed low-voltage enable register 9
  $78 constant SYSCFG_SYSCFG_HSLVEN10R  \ SYSCFG high-speed low-voltage enable register 10
  $7C constant SYSCFG_SYSCFG_HSLVEN11R  \ SYSCFG high-speed low-voltage enable register 11
  $380 constant SYSCFG_SYSCFG_IDC       \ SYSCFG identity code register
  $3F4 constant SYSCFG_SYSCFG_VERR      \ SYSCFG version register
  $3F8 constant SYSCFG_SYSCFG_IPIDR     \ SYSCFG identification register
  $3FC constant SYSCFG_SYSCFG_SIDR      \ SYSCFG size identification register

: SYSCFG_DEF ; [then]
