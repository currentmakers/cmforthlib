\
\ @file dbgmcu.fs
\ @brief DBGMCU address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_DBGMCU_IDCODER_DEF
    \
    \ @brief DBGMCU identity code register
    \ Address offset: 0x00
    \ Reset value: 0x00006492
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device ID
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision ID
  [then]


  [ifdef] DBGMCU_DBGMCU_SCR_DEF
    \
    \ @brief DBGMCU status and configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Allows debug in Stop mode Write access can be protected by PWR_SECCFGR.LPMSEC. The CPU debug and DBGMCU clocks remain active and the HSI16 oscillators is used as system clock during Stop debug mode, allowing CPU debug capability. On exit from Stop mode, the clock settings are set to the Stop mode exit state.
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Allows debug in Standby mode Write access can be protected by PWR_SECCFGR.LPMSEC. The CPU debug and DBGMCU clocks remain active and the HSI16 oscillator is used as system clock, the supply and SRAM memory content is maintained during Standby debug mode, allowing CPU debug capability. On exit from Standby mode, a standby reset is performed.
    $10 constant DBGMCU_LPMS                    \ [0x10 : 3] Device low power mode selected 10x: Standby mode others reserved
    $13 constant DBGMCU_STOPF                   \ [0x13] Device Stop flag
    $14 constant DBGMCU_SBF                     \ [0x14] Device Standby flag
    $18 constant DBGMCU_CS                      \ [0x18] CPU Sleep
    $19 constant DBGMCU_CDS                     \ [0x19] CPU DeepSleep
  [then]


  [ifdef] DBGMCU_DBGMCU_APB1LFZR_DEF
    \
    \ @brief DBGMCU APB1L peripheral freeze register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM2SEC.
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] TIM3 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM3SEC.
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] WWDG stop in CPU debug Write access can be protected by GTZC_TZSC.WWDGSEC
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] IWDG stop in CPU debug Write access can be protected by GTZC_TZSC.IWDGSEC.
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout stop in CPU debug Write access can be protected by GTZC_TZSC.I2C1SEC.
  [then]


  [ifdef] DBGMCU_DBGMCU_APB1HFZR_DEF
    \
    \ @brief DBGMCU APB1H peripheral freeze register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $05 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x05] LPTIM2 stop in CPU debug Write access can be protected by GTZC_TZSC.LPTIM2SEC.
  [then]


  [ifdef] DBGMCU_DBGMCU_APB2FZR_DEF
    \
    \ @brief DBGMCU APB2 peripheral freeze register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] TIM1 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM1SEC.
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM16SEC.
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] TIM17 stop in CPU debug Write access can be protected by GTZC_TZSC.TIM17SEC.
  [then]


  [ifdef] DBGMCU_DBGMCU_APB7FZR_DEF
    \
    \ @brief DBGMCU APB7 peripheral freeze register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $0a constant DBGMCU_DBG_I2C3_STOP           \ [0x0a] I2C3 stop in CPU debug Access can be protected by GTZC_TZSC.I2C3SEC.
    $11 constant DBGMCU_DBG_LPTIM1_STOP         \ [0x11] LPTIM1 stop in CPU debug Access can be protected by GTZC_TZSC.LPTIM1SEC.
    $1e constant DBGMCU_DBG_RTC_STOP            \ [0x1e] RTC stop in CPU debug Access can be protected by GTZC_TZSC.TIM17SEC. Can only be accessed secure when one or more features in the RTC or TAMP is/are secure.
  [then]


  [ifdef] DBGMCU_DBGMCU_AHB1FZR_DEF
    \
    \ @brief DBGMCU AHB1 peripheral freeze register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_GPDMA1_CH0_STOP     \ [0x00] GPDMA 1 channel 0 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC0.
    $01 constant DBGMCU_DBG_GPDMA1_CH1_STOP     \ [0x01] GPDMA 1 channel 1 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC1.
    $02 constant DBGMCU_DBG_GPDMA1_CH2_STOP     \ [0x02] GPDMA 1 channel 2 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC2.
    $03 constant DBGMCU_DBG_GPDMA1_CH3_STOP     \ [0x03] GPDMA 1 channel 3 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC3.
    $04 constant DBGMCU_DBG_GPDMA1_CH4_STOP     \ [0x04] GPDMA 1 channel 4 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC4.
    $05 constant DBGMCU_DBG_GPDMA1_CH5_STOP     \ [0x05] GPDMA 1 channel 5 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC5.
    $06 constant DBGMCU_DBG_GPDMA1_CH6_STOP     \ [0x06] GPDMA 1 channel 6 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC6.
    $07 constant DBGMCU_DBG_GPDMA1_CH7_STOP     \ [0x07] GPDMA 1 channel 7 stop in CPU debug Write access can be protected by GPDMA_SECCFGR.SEC7.
  [then]


  [ifdef] DBGMCU_DBGMCU_SR_DEF
    \
    \ @brief DBGMCU status register
    \ Address offset: 0xFC
    \ Reset value: 0x00000003
    \
    $00 constant DBGMCU_AP_PRESENT              \ [0x00 : 16] Bit n identifies whether access port APn is present in device Bit n = 0: APn absent Bit n = 1: APn present
    $10 constant DBGMCU_AP_ENABLED              \ [0x10 : 16] Bit n identifies whether access port APn is open (can be accessed via the debug port) or locked (debug access to the APn is blocked, except for DBGMCU access) Bit n = 0: APn locked (except for access to DBGMCU) Bit n = 1: APn enabled
  [then]


  [ifdef] DBGMCU_DBGMCU_DBG_AUTH_HOST_DEF
    \
    \ @brief DBGMCU debug host authentication register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_AUTH_KEY                \ [0x00 : 32] Device authentication key The device specific 64-bit authentication key (OEMn key) must be written to this register (in two successive 32-bit writes, least significant word first) to permit RDP regression. Writing a wrong key locks access to the device and prevent code execution from the Flash memory.
  [then]


  [ifdef] DBGMCU_DBGMCU_DBG_AUTH_DEVICE_DEF
    \
    \ @brief DBGMCU debug device authentication register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_AUTH_ID                 \ [0x00 : 32] Device specific ID Device specific ID used for RDP regression.
  [then]


  [ifdef] DBGMCU_DBGMCU_PNCR_DEF
    \
    \ @brief DBGMCU part number codification register
    \ Address offset: 0x7DC
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_CODIFICATION            \ [0x00 : 32] Part number codification
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR4_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 4
    \ Address offset: 0xFD0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_JEP106CON               \ [0x00 : 4] JEP106 continuation code
    $04 constant DBGMCU_F4KCOUNT                \ [0x04 : 4] Register file size
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR0_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 0
    \ Address offset: 0xFE0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PARTNUM                 \ [0x00 : 8] Part number bits [7:0]
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR1_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 1
    \ Address offset: 0xFE4
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PARTNUM                 \ [0x00 : 4] Part number bits [11:8]
    $04 constant DBGMCU_JEP106ID                \ [0x04 : 4] JEP106 identity code bits [3:0]
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR2_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 2
    \ Address offset: 0xFE8
    \ Reset value: 0x0000000A
    \
    $00 constant DBGMCU_JEP106ID                \ [0x00 : 3] JEP106 identity code bits [6:4]
    $03 constant DBGMCU_JEDEC                   \ [0x03] JEDEC assigned value
    $04 constant DBGMCU_REVISION                \ [0x04 : 4] Component revision number
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR3_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 3
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_CMOD                    \ [0x00 : 4] Customer modified
    $04 constant DBGMCU_REVAND                  \ [0x04 : 4] Metal fix version
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR0_DEF
    \
    \ @brief DBGMCU CoreSight component identity register 0
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] Component ID bits [7:0]
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR1_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 1
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 4] Component ID bits [11:8]
    $04 constant DBGMCU_CLASS                   \ [0x04 : 4] Component ID bits [15:12] - component class
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR2_DEF
    \
    \ @brief DBGMCU CoreSight component identity register 2
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] Component ID bits [23:16]
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR3_DEF
    \
    \ @brief DBGMCU CoreSight component identity register 3
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] Component ID bits [31:24]
  [then]

  \
  \ @brief DBGMCU address block description
  \
  $00 constant DBGMCU_DBGMCU_IDCODER    \ DBGMCU identity code register
  $04 constant DBGMCU_DBGMCU_SCR        \ DBGMCU status and configuration register
  $08 constant DBGMCU_DBGMCU_APB1LFZR   \ DBGMCU APB1L peripheral freeze register
  $0C constant DBGMCU_DBGMCU_APB1HFZR   \ DBGMCU APB1H peripheral freeze register
  $10 constant DBGMCU_DBGMCU_APB2FZR    \ DBGMCU APB2 peripheral freeze register
  $24 constant DBGMCU_DBGMCU_APB7FZR    \ DBGMCU APB7 peripheral freeze register
  $28 constant DBGMCU_DBGMCU_AHB1FZR    \ DBGMCU AHB1 peripheral freeze register
  $FC constant DBGMCU_DBGMCU_SR         \ DBGMCU status register
  $100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST    \ DBGMCU debug host authentication register
  $104 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE    \ DBGMCU debug device authentication register
  $7DC constant DBGMCU_DBGMCU_PNCR      \ DBGMCU part number codification register
  $FD0 constant DBGMCU_DBGMCU_PIDR4     \ DBGMCU CoreSight peripheral identity register 4
  $FE0 constant DBGMCU_DBGMCU_PIDR0     \ DBGMCU CoreSight peripheral identity register 0
  $FE4 constant DBGMCU_DBGMCU_PIDR1     \ DBGMCU CoreSight peripheral identity register 1
  $FE8 constant DBGMCU_DBGMCU_PIDR2     \ DBGMCU CoreSight peripheral identity register 2
  $FEC constant DBGMCU_DBGMCU_PIDR3     \ DBGMCU CoreSight peripheral identity register 3
  $FF0 constant DBGMCU_DBGMCU_CIDR0     \ DBGMCU CoreSight component identity register 0
  $FF4 constant DBGMCU_DBGMCU_CIDR1     \ DBGMCU CoreSight peripheral identity register 1
  $FF8 constant DBGMCU_DBGMCU_CIDR2     \ DBGMCU CoreSight component identity register 2
  $FFC constant DBGMCU_DBGMCU_CIDR3     \ DBGMCU CoreSight component identity register 3

: DBGMCU_DEF ; [then]
