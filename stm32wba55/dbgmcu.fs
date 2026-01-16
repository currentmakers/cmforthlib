\
\ @file dbgmcu.fs
\ @brief DBGMCU address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DBGMCU identity code register
\ Address offset: 0x00
\ Reset value: 0x00006492
\

$00000fff constant DBGMCU_DBGMCU_IDCODER_DEV_ID                     \ Device ID
$ffff0000 constant DBGMCU_DBGMCU_IDCODER_REV_ID                     \ Revision ID


\
\ @brief DBGMCU status and configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant DBGMCU_DBGMCU_SCR_DBG_STOP                       \ Allows debug in Stop mode Write access can be protected by PWR_SECCFGR.LPMSEC. The CPU debug and DBGMCU clocks remain active and the HSI16 oscillators is used as system clock during Stop debug mode, allowing CPU debug capability. On exit from Stop mode, the clock settings are set to the Stop mode exit state.
$00000004 constant DBGMCU_DBGMCU_SCR_DBG_STANDBY                    \ Allows debug in Standby mode Write access can be protected by PWR_SECCFGR.LPMSEC. The CPU debug and DBGMCU clocks remain active and the HSI16 oscillator is used as system clock, the supply and SRAM memory content is maintained during Standby debug mode, allowing CPU debug capability. On exit from Standby mode, a standby reset is performed.
$00070000 constant DBGMCU_DBGMCU_SCR_LPMS                           \ Device low power mode selected 10x: Standby mode others reserved
$00080000 constant DBGMCU_DBGMCU_SCR_STOPF                          \ Device Stop flag
$00100000 constant DBGMCU_DBGMCU_SCR_SBF                            \ Device Standby flag
$01000000 constant DBGMCU_DBGMCU_SCR_CS                             \ CPU Sleep
$02000000 constant DBGMCU_DBGMCU_SCR_CDS                            \ CPU DeepSleep


\
\ @brief DBGMCU APB1L peripheral freeze register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM2_STOP             \ TIM2 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM2SEC.
$00000002 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM3_STOP             \ TIM3 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM3SEC.
$00000800 constant DBGMCU_DBGMCU_APB1LFZR_DBG_WWDG_STOP             \ WWDG stop in CPU debug Write access can be protected by GTZC_TZSC.WWDGSEC
$00001000 constant DBGMCU_DBGMCU_APB1LFZR_DBG_IWDG_STOP             \ IWDG stop in CPU debug Write access can be protected by GTZC_TZSC.IWDGSEC.
$00200000 constant DBGMCU_DBGMCU_APB1LFZR_DBG_I2C1_STOP             \ I2C1 SMBUS timeout stop in CPU debug Write access can be protected by GTZC_TZSC.I2C1SEC.


\
\ @brief DBGMCU APB1H peripheral freeze register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000020 constant DBGMCU_DBGMCU_APB1HFZR_DBG_LPTIM2_STOP           \ LPTIM2 stop in CPU debug Write access can be protected by GTZC_TZSC.LPTIM2SEC.


\
\ @brief DBGMCU APB2 peripheral freeze register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM1_STOP              \ TIM1 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM1SEC.
$00020000 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM16_STOP             \ TIM16 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM16SEC.
$00040000 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM17_STOP             \ TIM17 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM17SEC.


\
\ @brief DBGMCU APB7 peripheral freeze register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000400 constant DBGMCU_DBGMCU_APB7FZR_DBG_I2C3_STOP              \ I2C3 stop in CPU debug Access can be protected by GTZC_TZSC.I2C3SEC.
$00020000 constant DBGMCU_DBGMCU_APB7FZR_DBG_LPTIM1_STOP            \ LPTIM1 stop in CPU debug Access can be protected by GTZC_TZSC.LPTIM1SEC.
$40000000 constant DBGMCU_DBGMCU_APB7FZR_DBG_RTC_STOP               \ RTC stop in CPU debug Access can be protected by GTZC_TZSC.TIM17SEC. Can only be accessed secure when one or more features in the RTC or TAMP is/are secure.


\
\ @brief DBGMCU AHB1 peripheral freeze register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_CH0_STOP        \ GPDMA 1 channel 0 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC0.
$00000002 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_CH1_STOP        \ GPDMA 1 channel 1 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC1.
$00000004 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_CH2_STOP        \ GPDMA 1 channel 2 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC2.
$00000008 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_CH3_STOP        \ GPDMA 1 channel 3 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC3.
$00000010 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_CH4_STOP        \ GPDMA 1 channel 4 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC4.
$00000020 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_CH5_STOP        \ GPDMA 1 channel 5 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC5.
$00000040 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_CH6_STOP        \ GPDMA 1 channel 6 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC6.
$00000080 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_CH7_STOP        \ GPDMA 1 channel 7 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC7.


\
\ @brief DBGMCU status register
\ Address offset: 0xFC
\ Reset value: 0x00000003
\

$0000ffff constant DBGMCU_DBGMCU_SR_AP_PRESENT                      \ Bit n identifies whether access port APn is present in device Bit n = 0: APn absent Bit n = 1: APn present
$ffff0000 constant DBGMCU_DBGMCU_SR_AP_ENABLED                      \ Bit n identifies whether access port APn is open (can be accessed via the debug port) or locked (debug access to the APn is blocked, except for DBGMCU access) Bit n = 0: APn locked (except for access to DBGMCU) Bit n = 1: APn enabled


\
\ @brief DBGMCU debug host authentication register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_DBG_AUTH_HOST_AUTH_KEY             \ Device authentication key The device specific 64-bit authentication key (OEMn key) must be written to this register (in two successive 32-bit writes, least significant word first) to permit RDP regression. Writing a wrong key locks access to the device and prevent code execution from the Flash memory.


\
\ @brief DBGMCU debug device authentication register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE_AUTH_ID            \ Device specific ID Device specific ID used for RDP regression.


\
\ @brief DBGMCU part number codification register
\ Address offset: 0x7DC
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_PNCR_CODIFICATION                  \ Part number codification


\
\ @brief DBGMCU CoreSight peripheral identity register 4
\ Address offset: 0xFD0
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR4_JEP106CON                    \ JEP106 continuation code
$000000f0 constant DBGMCU_DBGMCU_PIDR4_F4KCOUNT                     \ Register file size


\
\ @brief DBGMCU CoreSight peripheral identity register 0
\ Address offset: 0xFE0
\ Reset value: 0x00000000
\

$000000ff constant DBGMCU_DBGMCU_PIDR0_PARTNUM                      \ Part number bits [7:0]


\
\ @brief DBGMCU CoreSight peripheral identity register 1
\ Address offset: 0xFE4
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR1_PARTNUM                      \ Part number bits [11:8]
$000000f0 constant DBGMCU_DBGMCU_PIDR1_JEP106ID                     \ JEP106 identity code bits [3:0]


\
\ @brief DBGMCU CoreSight peripheral identity register 2
\ Address offset: 0xFE8
\ Reset value: 0x0000000A
\

$00000007 constant DBGMCU_DBGMCU_PIDR2_JEP106ID                     \ JEP106 identity code bits [6:4]
$00000008 constant DBGMCU_DBGMCU_PIDR2_JEDEC                        \ JEDEC assigned value
$000000f0 constant DBGMCU_DBGMCU_PIDR2_REVISION                     \ Component revision number


\
\ @brief DBGMCU CoreSight peripheral identity register 3
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR3_CMOD                         \ Customer modified
$000000f0 constant DBGMCU_DBGMCU_PIDR3_REVAND                       \ Metal fix version


\
\ @brief DBGMCU CoreSight component identity register 0
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant DBGMCU_DBGMCU_CIDR0_PREAMBLE                     \ Component ID bits [7:0]


\
\ @brief DBGMCU CoreSight peripheral identity register 1
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant DBGMCU_DBGMCU_CIDR1_PREAMBLE                     \ Component ID bits [11:8]
$000000f0 constant DBGMCU_DBGMCU_CIDR1_CLASS                        \ Component ID bits [15:12] - component class


\
\ @brief DBGMCU CoreSight component identity register 2
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$000000ff constant DBGMCU_DBGMCU_CIDR2_PREAMBLE                     \ Component ID bits [23:16]


\
\ @brief DBGMCU CoreSight component identity register 3
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant DBGMCU_DBGMCU_CIDR3_PREAMBLE                     \ Component ID bits [31:24]


\
\ @brief DBGMCU address block description
\
$e0044000 constant DBGMCU_DBGMCU_IDCODER  \ offset: 0x00 : DBGMCU identity code register
$e0044004 constant DBGMCU_DBGMCU_SCR  \ offset: 0x04 : DBGMCU status and configuration register
$e0044008 constant DBGMCU_DBGMCU_APB1LFZR  \ offset: 0x08 : DBGMCU APB1L peripheral freeze register
$e004400c constant DBGMCU_DBGMCU_APB1HFZR  \ offset: 0x0C : DBGMCU APB1H peripheral freeze register
$e0044010 constant DBGMCU_DBGMCU_APB2FZR  \ offset: 0x10 : DBGMCU APB2 peripheral freeze register
$e0044024 constant DBGMCU_DBGMCU_APB7FZR  \ offset: 0x24 : DBGMCU APB7 peripheral freeze register
$e0044028 constant DBGMCU_DBGMCU_AHB1FZR  \ offset: 0x28 : DBGMCU AHB1 peripheral freeze register
$e00440fc constant DBGMCU_DBGMCU_SR  \ offset: 0xFC : DBGMCU status register
$e0044100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST  \ offset: 0x100 : DBGMCU debug host authentication register
$e0044104 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE  \ offset: 0x104 : DBGMCU debug device authentication register
$e00447dc constant DBGMCU_DBGMCU_PNCR  \ offset: 0x7DC : DBGMCU part number codification register
$e0044fd0 constant DBGMCU_DBGMCU_PIDR4  \ offset: 0xFD0 : DBGMCU CoreSight peripheral identity register 4
$e0044fe0 constant DBGMCU_DBGMCU_PIDR0  \ offset: 0xFE0 : DBGMCU CoreSight peripheral identity register 0
$e0044fe4 constant DBGMCU_DBGMCU_PIDR1  \ offset: 0xFE4 : DBGMCU CoreSight peripheral identity register 1
$e0044fe8 constant DBGMCU_DBGMCU_PIDR2  \ offset: 0xFE8 : DBGMCU CoreSight peripheral identity register 2
$e0044fec constant DBGMCU_DBGMCU_PIDR3  \ offset: 0xFEC : DBGMCU CoreSight peripheral identity register 3
$e0044ff0 constant DBGMCU_DBGMCU_CIDR0  \ offset: 0xFF0 : DBGMCU CoreSight component identity register 0
$e0044ff4 constant DBGMCU_DBGMCU_CIDR1  \ offset: 0xFF4 : DBGMCU CoreSight peripheral identity register 1
$e0044ff8 constant DBGMCU_DBGMCU_CIDR2  \ offset: 0xFF8 : DBGMCU CoreSight component identity register 2
$e0044ffc constant DBGMCU_DBGMCU_CIDR3  \ offset: 0xFFC : DBGMCU CoreSight component identity register 3

