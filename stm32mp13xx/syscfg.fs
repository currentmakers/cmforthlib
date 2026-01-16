\
\ @file syscfg.fs
\ @brief SYSCFG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SYSCFG boot pins control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_BOOTR_BOOT0                        \ BOOT0 pin value
$00000002 constant SYSCFG_SYSCFG_BOOTR_BOOT1                        \ BOOT1 pin value
$00000004 constant SYSCFG_SYSCFG_BOOTR_BOOT2                        \ BOOT2 pin value


\
\ @brief SYSCFG peripheral mode configuration set register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_PMCSETR_I2C1_FMP                   \ Fast Mode Plus (FM+) Enable Set by software.
$00000002 constant SYSCFG_SYSCFG_PMCSETR_I2C2_FMP                   \ Fast Mode Plus (FM+) Enable Set by software.
$00000004 constant SYSCFG_SYSCFG_PMCSETR_I2C3_FMP                   \ Fast Mode Plus (FM+) Enable Set by software. This bit is secure if I2C3 is set to secure in the ETZPC.
$00000008 constant SYSCFG_SYSCFG_PMCSETR_I2C4_FMP                   \ Fast Mode Plus (FM+) Enable Set by software. This bit is secure if I2C4 is set to secure in the ETZPC.
$00000010 constant SYSCFG_SYSCFG_PMCSETR_I2C5_FMP                   \ Fast mode plus (FM+) enable Set by software. This bit is secure if I2C5 is set to secure in the ETZPC.
$00000100 constant SYSCFG_SYSCFG_PMCSETR_EN_BOOSTER                 \ GPIO analog switch supply voltage booster enable. Set by software. Used to reduce the total harmonic distortion of the I/O analog switches when VDDA and VDD supplies are below 2.7Â V. Activating the booster guarantees the AC performance on I/O analog switches. When activated the performance of the analog switch is the same over the full voltage range. This bit is always secure.
$00000200 constant SYSCFG_SYSCFG_PMCSETR_ANASWVDD                   \ GPIO analog switch supply voltage selection Cleared by software. This bit is always secure.
$00010000 constant SYSCFG_SYSCFG_PMCSETR_ETH1_CLK_SEL               \ Gigabit Ethernet 125Â MHz clock selection. Only useful with RGMII PHY. Set by software. This bit is secure if ETH1 is set to secure in the ETZPC.
$00020000 constant SYSCFG_SYSCFG_PMCSETR_ETH1_REF_CLK_SEL           \ Ethernet reference clock selection. Set by software. This bit is secure if ETH1 is set to secure in the ETZPC.
$00e00000 constant SYSCFG_SYSCFG_PMCSETR_ETH1_SEL                   \ Ethernet PHY interface selection. Set by software. Writing '0' has no effect. Set individual bits by writing '1â. Reading means: Note: Configuration must be done while the ETH is under reset and before enabling the ETH clocks This bit field is secure if ETH1 is set to secure in the ETZPC.
$01000000 constant SYSCFG_SYSCFG_PMCSETR_ETH2_CLK_SEL               \ Gigabit Ethernet 125Â MHz clock selection. Only useful with RGMII PHY. Set by software. This bit is secure if ETH2 is set to secure in the ETZPC.
$02000000 constant SYSCFG_SYSCFG_PMCSETR_ETH2_REF_CLK_SEL           \ Ethernet reference clock selection. Set by software. This bit is secure if ETH2 is set to secure in the ETZPC.
$e0000000 constant SYSCFG_SYSCFG_PMCSETR_ETH2_SEL                   \ Ethernet PHY interface selection. Set by software. Writing '0' has no effect. Set individual bits by writing '1â. Reading means: Note: Configuration must be done while the ETH is under reset and before enabling the ETH clocks This bit field is secure if ETH2 is set to secure in the ETZPC.


\
\ @brief SYSCFG peripheral mode configuration clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_PMCCLRR_I2C1_FMP                   \ Fast Mode Plus (FM+) Enable Cleared by software.
$00000002 constant SYSCFG_SYSCFG_PMCCLRR_I2C2_FMP                   \ Fast Mode Plus (FM+) Enable Cleared by software.
$00000004 constant SYSCFG_SYSCFG_PMCCLRR_I2C3_FMP                   \ Fast Mode Plus (FM+) Enable Cleared by software. This bit is secure if I2C3 is set to secure in the ETZPC.
$00000008 constant SYSCFG_SYSCFG_PMCCLRR_I2C4_FMP                   \ Fast Mode Plus (FM+) Enable Cleared by software. This bit is secure if I2C4 is set to secure in the ETZPC.
$00000010 constant SYSCFG_SYSCFG_PMCCLRR_I2C5_FMP                   \ Fast Mode Plus (FM+) Enable Cleared by software. This bit is secure if I2C5 is set to secure in the ETZPC.
$00000100 constant SYSCFG_SYSCFG_PMCCLRR_EN_BOOSTER                 \ GPIO analog switch supply voltage booster enable. Cleared by software. Used to reduce the Total harmonic distortion of the I/O analog switches when VDDA and VDD supplies are below 2.7Â V. Activating the booster guarantees the AC performance on I/O analog switches. When activated the performance of the analog switch is the same over the full voltage range. This bit is always secure.
$00000200 constant SYSCFG_SYSCFG_PMCCLRR_ANASWVDD                   \ GPIO analog switch supply voltage selection Cleared by software. (if present and EN_BOOSTER=0) or by the booster output (EN_BOOSTER=1) This bit is always secure.
$00010000 constant SYSCFG_SYSCFG_PMCCLRR_ETH1_CLK_SEL               \ Gigabit Ethernet 125Â MHz clock selection. Only useful with RGMII PHY. Set by software. This bit is secure if ETH1 is set to secure in the ETZPC
$00020000 constant SYSCFG_SYSCFG_PMCCLRR_ETH1_REF_CLK_SEL           \ Ethernet reference clock selection. Set by software. This bit is secure if ETH1 is set to secure in the ETZPC
$00e00000 constant SYSCFG_SYSCFG_PMCCLRR_ETH1_SEL                   \ Ethernet PHY interface selection. Set by software. Writing '0' has no effect. Clear individual bits by writing '1â. Reading means: Note: Configuration must be done while the ETH is under reset and before enabling the ETH clocks This bit field is secure if ETH1 is set to secure in the ETZPC.
$01000000 constant SYSCFG_SYSCFG_PMCCLRR_ETH2_CLK_SEL               \ Gigabit Ethernet 125Â MHz clock selection. Only useful with RGMII PHY. Set by software. This bit is secure if ETH2 is set to secure in the ETZPC.
$02000000 constant SYSCFG_SYSCFG_PMCCLRR_ETH2_REF_CLK_SEL           \ Ethernet reference clock selection. Set by software. This bit is secure if ETH2 is set to secure in the ETZPC.
$e0000000 constant SYSCFG_SYSCFG_PMCCLRR_ETH2_SEL                   \ Ethernet PHY interface selection. Set by software. Writing '0' has no effect. Clear individual bits by writing '1â. Reading means: Note: Configuration must be done while the ETH is under reset and before enabling the ETH clocks This bit field is secure if ETH2 is set to secure in the ETZPC.


\
\ @brief SYSCFG boot control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_BOOTCR_BMEN                        \ Boot mode enable This bit is writable only by secure privileged code. It should be used only during secure boot time, to ensure the timely execution of the firmware in charge of tamper management. When this bit is cleared from 1 to 0 while a potential tamper event is active, accesses to SRAM3 are automatically blocked (as defined above) and PKA, SAES, HASH and CRYP peripherals are reset. When a confirmed (not potential) tamper is raised by TAMP peripheral, SRAM3 is erased (as defined in TAMP) and PKA, SAES, HASH and CRYP peripherals are reset regardless of BMEN value.


\
\ @brief SYSCFG SRAM3 erase register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_SRAM3ERASER_SRAM3ER                \ SRAM3 erase request This bit is set by software and automatically reset by hardware at the end of the erase operation. It can only be set if the correct unlock sequence has previously been written to the SYSCFG_SRAM3KR.KEY[7:0] register field. This bit is secure if SRAM3 is set to secure in the ETZPC.
$00000002 constant SYSCFG_SYSCFG_SRAM3ERASER_SRAM3EO                \ SRAM3 erase ongoing This bit indicates whether an erase of SRAM3 is being carried out, whatever the trigger (tamper or software).


\
\ @brief SYSCFG SRAM3 erase key register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant SYSCFG_SYSCFG_SRAM3KR_KEY                        \ SRAM3 software erase key Writing the following sequence to KEY[7:0] unlocks the SRAM3 software erase feature: 0xCA 0x53 Writing any other value locks the feature.


\
\ @brief SYSCFG main compensation cell control register
\ Address offset: 0x20
\ Reset value: 0x00870000
\

$00000002 constant SYSCFG_SYSCFG_CMPCR_SW_CTRL                      \ Compensation software control Note: SW_CTRL = 0 is not taken into account until READY = 1. This means that whatever SW_CTRL value, the RANSRC[3:0] and RAPSRC[3:0] are used for I/O compensation when the compensation cell is in power down (EN = 0, which is the case after a reset).
$00000100 constant SYSCFG_SYSCFG_CMPCR_READY                        \ Compensation cell ready flag
$000f0000 constant SYSCFG_SYSCFG_CMPCR_RANSRC                       \ NMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation
$00f00000 constant SYSCFG_SYSCFG_CMPCR_RAPSRC                       \ PMOS I/O Compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation
$0f000000 constant SYSCFG_SYSCFG_CMPCR_ANSRC                        \ NMOS I/O compensation value provided by compensation cell Value sent to I/Os when SW_CTRL = 0 and READY = 1.
$f0000000 constant SYSCFG_SYSCFG_CMPCR_APSRC                        \ PMOS I/O compensation value provided by compensation cell Value sent to I/O compensation when SW_CTRL = 0 and READY = 1.


\
\ @brief SYSCFG main compensation cell enable set register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CMPENSETR_EN                       \ Compensation cell enable Set by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0.


\
\ @brief SYSCFG main compensation cell enable set register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CMPENCLRR_EN                       \ Compensation cell enable Cleared by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0.


\
\ @brief SYSCFG control timer break register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000004 constant SYSCFG_SYSCFG_CBR_PVDL                           \ PVD lock enable bit This bit is set by software and cleared only by a system reset. It can be used to enable and lock the PVD connection to TIM1/8/15/16/17 Break input, as well as the PVDE and PLS[2:0] in the PWR_CR1 register.


\
\ @brief SYSCFG VDDSD1 compensation cell control register
\ Address offset: 0x30
\ Reset value: 0x00870000
\

$00000002 constant SYSCFG_SYSCFG_CMPSD1CR_SW_CTRL                   \ Compensation software control Note: SW_CTRL = 0 is not taken into account until READY = 1. This means that whatever SW_CTRL value, the RANSRC[3:0] and RAPSRC[3:0] are used for I/O compensation when the compensation cell is in power down (EN = 0, which is the case after a reset). This bit is secure if SDMMC1 is set to secure in the ETZPC.
$00000100 constant SYSCFG_SYSCFG_CMPSD1CR_READY                     \ Compensation cell ready flag
$000f0000 constant SYSCFG_SYSCFG_CMPSD1CR_RANSRC                    \ NMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation This bit field is secure if SDMMC1 is set to secure in the ETZPC.
$00f00000 constant SYSCFG_SYSCFG_CMPSD1CR_RAPSRC                    \ PMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation This bit field is secure if SDMMC1 is set to secure in the ETZPC.
$0f000000 constant SYSCFG_SYSCFG_CMPSD1CR_ANSRC                     \ NMOS I/O Compensation value provided by compensation cell Value sent to I/Os when SW_CTRL = 0 and READY = 1.
$f0000000 constant SYSCFG_SYSCFG_CMPSD1CR_APSRC                     \ PMOS I/O Compensation value provided by compensation cell Value sent to I/Os compensation when SW_CTRL = 0 and READY = 1.


\
\ @brief SYSCFG VDDSD1 compensation cell enable set register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CMPSD1ENSETR_EN                    \ Compensation cell enable Set by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if MPU_EN is set to 0. This bit is secure if SDMMC1 is set to secure in the ETZPC.


\
\ @brief SYSCFG VDDSD1 compensation cell enable clear register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CMPSD1ENCLRR_EN                    \ Compensation cell enable Cleared by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0. This bit is secure if SDMMC1 is set to secure in the ETZPC.


\
\ @brief SYSCFG VDDSD2 compensation cell control register
\ Address offset: 0x40
\ Reset value: 0x00870000
\

$00000002 constant SYSCFG_SYSCFG_CMPSD2CR_SW_CTRL                   \ Compensation Software Control Note: SW_CTRL = 0 is not taken into account until READY = 1. This means that whatever SW_CTRL value, the RANSRC[3:0] and RAPSRC[3:0] are used for I/O compensation when the compensation cell is in power down (EN = 0, which is the case after a reset). This bit is secure if SDMMC2 is set to secure in the ETZPC
$00000100 constant SYSCFG_SYSCFG_CMPSD2CR_READY                     \ Compensation cell ready flag
$000f0000 constant SYSCFG_SYSCFG_CMPSD2CR_RANSRC                    \ NMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation This bit field is secure if SDMMC2 is set to secure in the ETZPC.
$00f00000 constant SYSCFG_SYSCFG_CMPSD2CR_RAPSRC                    \ PMOS I/O compensation value sent to I/Os when SW_CTRL = 1 .... .... Note: If compensation is needed, it is recommended to use automatic compensation This bit field is secure if SDMMC2 is set to secure in the ETZPC.
$0f000000 constant SYSCFG_SYSCFG_CMPSD2CR_ANSRC                     \ NMOS I/O Compensation value provided by compensation cell Value sent to I/Os when SW_CTRL = 0 and READY = 1
$f0000000 constant SYSCFG_SYSCFG_CMPSD2CR_APSRC                     \ PMOS I/O Compensation value provided by compensation cell Value sent to I/Os compensation when SW_CTRL = 0 and READY = 1


\
\ @brief SYSCFG VDDSD2 compensation cell enable set register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CMPSD2ENSETR_EN                    \ Compensation cell enable Set by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0. This bit is secure if SDMMC2 is set to secure in the ETZPC.


\
\ @brief SYSCFG VDDSD2 compensation cell enable clear register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CMPSD2ENCLRR_EN                    \ Compensation cell enable Cleared by software. Note: The CSI oscillator must be enabled and ready (controlled in RCC) before EN can be set to 1. Similarly, the CSI oscillator can be disabled only if EN is set to 0. This bit is secure if SDMMC2 is set to secure in the ETZPC.


\
\ @brief SYSCFG high-speed low-voltage enable register 0
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN0R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 1
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN1R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 2
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN2R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 3
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN3R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 4
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN4R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 5
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN5R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 6
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN6R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 7
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN7R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 8
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN8R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 9
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN9R_HSLVEN                    \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 10
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN10R_HSLVEN                   \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG high-speed low-voltage enable register 11
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_SYSCFG_HSLVEN11R_HSLVEN                   \ High-speed low-voltage I/O mode enable. Controls the speed of _h and _vh type I/Os associated with an interface when that interface is selected in the AFMUX When writing: Others: disables high speed mode When reading:


\
\ @brief SYSCFG identity code register
\ Address offset: 0x380
\ Reset value: 0x10006501
\

$00000fff constant SYSCFG_SYSCFG_IDC_DEV_ID                         \ device ID
$ffff0000 constant SYSCFG_SYSCFG_IDC_REV_ID                         \ device revision 0x1000 = Rev. 1


\
\ @brief SYSCFG version register
\ Address offset: 0x3F4
\ Reset value: 0x00000030
\

$0000000f constant SYSCFG_SYSCFG_VERR_MINREV                        \ Minor revision These bits return the SYSCFG minor revision. Minor revision is 0.
$000000f0 constant SYSCFG_SYSCFG_VERR_MAJREV                        \ Major revision These bits return the SYSCFG major revision. Major revision is 3.


\
\ @brief SYSCFG identification register
\ Address offset: 0x3F8
\ Reset value: 0x00030001
\

$00000000 constant SYSCFG_SYSCFG_IPIDR_ID                           \ SYSCFG identifier These bits return the SYSCFG identifier value.


\
\ @brief SYSCFG size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant SYSCFG_SYSCFG_SIDR_SID                           \ Size identification These bits return the size of the memory region allocated to SYSCFG registers.


\
\ @brief SYSCFG
\
$50020000 constant SYSCFG_SYSCFG_BOOTR  \ offset: 0x00 : SYSCFG boot pins control register
$50020004 constant SYSCFG_SYSCFG_PMCSETR  \ offset: 0x04 : SYSCFG peripheral mode configuration set register
$50020008 constant SYSCFG_SYSCFG_PMCCLRR  \ offset: 0x08 : SYSCFG peripheral mode configuration clear register
$5002000c constant SYSCFG_SYSCFG_BOOTCR  \ offset: 0x0C : SYSCFG boot control register
$50020010 constant SYSCFG_SYSCFG_SRAM3ERASER  \ offset: 0x10 : SYSCFG SRAM3 erase register
$50020014 constant SYSCFG_SYSCFG_SRAM3KR  \ offset: 0x14 : SYSCFG SRAM3 erase key register
$50020020 constant SYSCFG_SYSCFG_CMPCR  \ offset: 0x20 : SYSCFG main compensation cell control register
$50020024 constant SYSCFG_SYSCFG_CMPENSETR  \ offset: 0x24 : SYSCFG main compensation cell enable set register
$50020028 constant SYSCFG_SYSCFG_CMPENCLRR  \ offset: 0x28 : SYSCFG main compensation cell enable set register
$5002002c constant SYSCFG_SYSCFG_CBR  \ offset: 0x2C : SYSCFG control timer break register
$50020030 constant SYSCFG_SYSCFG_CMPSD1CR  \ offset: 0x30 : SYSCFG VDDSD1 compensation cell control register
$50020034 constant SYSCFG_SYSCFG_CMPSD1ENSETR  \ offset: 0x34 : SYSCFG VDDSD1 compensation cell enable set register
$50020038 constant SYSCFG_SYSCFG_CMPSD1ENCLRR  \ offset: 0x38 : SYSCFG VDDSD1 compensation cell enable clear register
$50020040 constant SYSCFG_SYSCFG_CMPSD2CR  \ offset: 0x40 : SYSCFG VDDSD2 compensation cell control register
$50020044 constant SYSCFG_SYSCFG_CMPSD2ENSETR  \ offset: 0x44 : SYSCFG VDDSD2 compensation cell enable set register
$50020048 constant SYSCFG_SYSCFG_CMPSD2ENCLRR  \ offset: 0x48 : SYSCFG VDDSD2 compensation cell enable clear register
$50020050 constant SYSCFG_SYSCFG_HSLVEN0R  \ offset: 0x50 : SYSCFG high-speed low-voltage enable register 0
$50020054 constant SYSCFG_SYSCFG_HSLVEN1R  \ offset: 0x54 : SYSCFG high-speed low-voltage enable register 1
$50020058 constant SYSCFG_SYSCFG_HSLVEN2R  \ offset: 0x58 : SYSCFG high-speed low-voltage enable register 2
$5002005c constant SYSCFG_SYSCFG_HSLVEN3R  \ offset: 0x5C : SYSCFG high-speed low-voltage enable register 3
$50020060 constant SYSCFG_SYSCFG_HSLVEN4R  \ offset: 0x60 : SYSCFG high-speed low-voltage enable register 4
$50020064 constant SYSCFG_SYSCFG_HSLVEN5R  \ offset: 0x64 : SYSCFG high-speed low-voltage enable register 5
$50020068 constant SYSCFG_SYSCFG_HSLVEN6R  \ offset: 0x68 : SYSCFG high-speed low-voltage enable register 6
$5002006c constant SYSCFG_SYSCFG_HSLVEN7R  \ offset: 0x6C : SYSCFG high-speed low-voltage enable register 7
$50020070 constant SYSCFG_SYSCFG_HSLVEN8R  \ offset: 0x70 : SYSCFG high-speed low-voltage enable register 8
$50020074 constant SYSCFG_SYSCFG_HSLVEN9R  \ offset: 0x74 : SYSCFG high-speed low-voltage enable register 9
$50020078 constant SYSCFG_SYSCFG_HSLVEN10R  \ offset: 0x78 : SYSCFG high-speed low-voltage enable register 10
$5002007c constant SYSCFG_SYSCFG_HSLVEN11R  \ offset: 0x7C : SYSCFG high-speed low-voltage enable register 11
$50020380 constant SYSCFG_SYSCFG_IDC  \ offset: 0x380 : SYSCFG identity code register
$500203f4 constant SYSCFG_SYSCFG_VERR  \ offset: 0x3F4 : SYSCFG version register
$500203f8 constant SYSCFG_SYSCFG_IPIDR  \ offset: 0x3F8 : SYSCFG identification register
$500203fc constant SYSCFG_SYSCFG_SIDR  \ offset: 0x3FC : SYSCFG size identification register

