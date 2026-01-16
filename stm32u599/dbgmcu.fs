\
\ @file dbgmcu.fs
\ @brief MCU debug component
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DBGMCU_IDCODE
\ Address offset: 0x00
\ Reset value: 0x30016481
\

$00000fff constant DBGMCU_IDCODE_DEV_ID                             \ Device dentification
$ffff0000 constant DBGMCU_IDCODE_REV_ID                             \ Revision


\
\ @brief Debug MCU configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant DBGMCU_CR_DBG_STOP                               \ Debug Stop mode
$00000004 constant DBGMCU_CR_DBG_STANDBY                            \ Debug Standby mode
$00000010 constant DBGMCU_CR_TRACE_IOEN                             \ Trace pin assignment control
$00000020 constant DBGMCU_CR_TRACE_EN                               \ trace port and clock enable
$000000c0 constant DBGMCU_CR_TRACE_MODE                             \ Trace pin assignment control


\
\ @brief Debug MCU APB1L peripheral freeze register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1LFZR_DBG_TIM2_STOP                    \ TIM2 stop in debug
$00000002 constant DBGMCU_APB1LFZR_DBG_TIM3_STOP                    \ TIM3 stop in debug
$00000004 constant DBGMCU_APB1LFZR_DBG_TIM4_STOP                    \ TIM4 stop in debug
$00000008 constant DBGMCU_APB1LFZR_DBG_TIM5_STOP                    \ TIM5 stop in debug
$00000010 constant DBGMCU_APB1LFZR_DBG_TIM6_STOP                    \ TIM6 stop in debug
$00000020 constant DBGMCU_APB1LFZR_DBG_TIM7_STOP                    \ TIM7 stop in debug
$00000800 constant DBGMCU_APB1LFZR_DBG_WWDG_STOP                    \ Window watchdog counter stop in debug
$00001000 constant DBGMCU_APB1LFZR_DBG_IWDG_STOP                    \ Independent watchdog counter stop in debug
$00200000 constant DBGMCU_APB1LFZR_DBG_I2C1_STOP                    \ I2C1 SMBUS timeout stop in debug
$00400000 constant DBGMCU_APB1LFZR_DBG_I2C2_STOP                    \ I2C2 SMBUS timeout stop in debug


\
\ @brief Debug MCU APB1H peripheral freeze register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant DBGMCU_APB1HFZR_DBG_I2C4_STOP                    \ I2C4 stop in debug
$00000020 constant DBGMCU_APB1HFZR_DBG_LPTIM2_STOP                  \ LPTIM2 stop in debug


\
\ @brief Debug MCU APB2 peripheral freeze register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_APB2FZR_DBG_TIM1_STOP                     \ TIM1 counter stopped when core is halted
$00002000 constant DBGMCU_APB2FZR_DBG_TIM8_STOP                     \ TIM8 stop in debug
$00010000 constant DBGMCU_APB2FZR_DBG_TIM15_STOP                    \ TIM15 counter stopped when core is halted
$00020000 constant DBGMCU_APB2FZR_DBG_TIM16_STOP                    \ TIM16 counter stopped when core is halted
$00040000 constant DBGMCU_APB2FZR_DBG_TIM17_STOP                    \ DBG_TIM17_STOP


\
\ @brief Debug MCU APB3 peripheral freeze register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000400 constant DBGMCU_APB3FZR_DBG_I2C3_STOP                     \ I2C3 stop in debug
$00020000 constant DBGMCU_APB3FZR_DBG_LPTIM1_STOP                   \ LPTIM1 stop in debug
$00040000 constant DBGMCU_APB3FZR_DBG_LPTIM3_STOP                   \ LPTIM3 stop in debug
$00080000 constant DBGMCU_APB3FZR_DBG_LPTIM4_STOP                   \ LPTIM4 stop in debug
$40000000 constant DBGMCU_APB3FZR_DBG_RTC_STOP                      \ RTC stop in debug


\
\ @brief Debug MCU AHB1 peripheral freeze register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_AHB1FZR_DBG_GPDMA0_STOP                   \ GPDMA channel 0 stop in debug
$00000002 constant DBGMCU_AHB1FZR_DBG_GPDMA1_STOP                   \ GPDMA channel 1 stop in debug
$00000004 constant DBGMCU_AHB1FZR_DBG_GPDMA2_STOP                   \ GPDMA channel 2 stop in debug
$00000008 constant DBGMCU_AHB1FZR_DBG_GPDMA3_STOP                   \ GPDMA channel 3 stop in debug
$00000010 constant DBGMCU_AHB1FZR_DBG_GPDMA4_STOP                   \ GPDMA channel 4 stop in debug
$00000020 constant DBGMCU_AHB1FZR_DBG_GPDMA5_STOP                   \ GPDMA channel 5 stop in debug
$00000040 constant DBGMCU_AHB1FZR_DBG_GPDMA6_STOP                   \ GPDMA channel 6 stop in debug
$00000080 constant DBGMCU_AHB1FZR_DBG_GPDMA7_STOP                   \ GPDMA channel 7 stop in debug
$00000100 constant DBGMCU_AHB1FZR_DBG_GPDMA8_STOP                   \ GPDMA channel 8 stop in debug
$00000200 constant DBGMCU_AHB1FZR_DBG_GPDMA9_STOP                   \ GPDMA channel 9 stop in debug
$00000400 constant DBGMCU_AHB1FZR_DBG_GPDMA10_STOP                  \ GPDMA channel 10 stop in debug
$00000800 constant DBGMCU_AHB1FZR_DBG_GPDMA11_STOP                  \ GPDMA channel 11 stop in debug
$00001000 constant DBGMCU_AHB1FZR_DBG_GPDMA12_STOP                  \ GPDMA channel 12 stop in debug
$00002000 constant DBGMCU_AHB1FZR_DBG_GPDMA13_STOP                  \ GPDMA channel 13 stop in debug
$00004000 constant DBGMCU_AHB1FZR_DBG_GPDMA14_STOP                  \ GPDMA channel 14 stop in debug
$00008000 constant DBGMCU_AHB1FZR_DBG_GPDMA15_STOP                  \ GPDMA channel 15 stop in debug


\
\ @brief Debug MCU AHB3 peripheral freeze register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_AHB3FZR_DBG_LPDMA0_STOP                   \ LPDMA channel 0 stop in debug
$00000002 constant DBGMCU_AHB3FZR_DBG_LPDMA1_STOP                   \ LPDMA channel 1 stop in debug
$00000004 constant DBGMCU_AHB3FZR_DBG_LPDMA2_STOP                   \ LPDMA channel 2 stop in debug
$00000008 constant DBGMCU_AHB3FZR_DBG_LPDMA3_STOP                   \ LPDMA channel 3 stop in debug


\
\ @brief DBGMCU status register
\ Address offset: 0xFC
\ Reset value: 0x00000001
\

$000000ff constant DBGMCU_SR_AP_PRESENT                             \ AP_PRESENT
$0000ff00 constant DBGMCU_SR_AP_LOCKED                              \ AP_LOCKED


\
\ @brief DBGMCU debug host authentication register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_DBG_AUTH_HOST_AUTH_KEY             \ AUTH_KEY


\
\ @brief DBGMCU debug device authentication register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000ffff constant DBGMCU_DBG_AUTH_DEVICE_AUTH_ID                   \ AUTH_ID


\
\ @brief Debug MCU CoreSight peripheral identity register 4
\ Address offset: 0xFD0
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_PIDR4_JEP106CON                           \ JEP106 continuation code
$000000f0 constant DBGMCU_PIDR4_KCOUNT_4                            \ register file size


\
\ @brief Debug MCU CoreSight peripheral identity register 0
\ Address offset: 0xFE0
\ Reset value: 0x00000000
\

$000000ff constant DBGMCU_PIDR0_PARTNUM                             \ part number bits [7:0]


\
\ @brief Debug MCU CoreSight peripheral identity register 1
\ Address offset: 0xFE4
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_PIDR1_PARTNUM                             \ part number bits [11:8]
$000000f0 constant DBGMCU_PIDR1_JEP106ID                            \ JEP106 identity code bits [3:0]


\
\ @brief Debug MCU CoreSight peripheral identity register 2
\ Address offset: 0xFE8
\ Reset value: 0x0000000A
\

$00000007 constant DBGMCU_PIDR2_JEP106ID                            \ JEP106 identity code bits [6:4]
$00000008 constant DBGMCU_PIDR2_JEDEC                               \ JEDEC assigned value
$000000f0 constant DBGMCU_PIDR2_REVISION                            \ component revision number


\
\ @brief Debug MCU CoreSight peripheral identity register 3
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_PIDR3_CMOD                                \ customer modified
$000000f0 constant DBGMCU_PIDR3_REVAND                              \ metal fix version


\
\ @brief Debug MCU CoreSight component identity register 0
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant DBGMCU_CIDR0_PREAMBLE                            \ component identification bits [7:0]


\
\ @brief Debug MCU CoreSight component identity register 1
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant DBGMCU_CIDR1_PREAMBLE                            \ component identification bits [11:8]
$000000f0 constant DBGMCU_CIDR1_CLASS                               \ component identification bits [15:12] - component class


\
\ @brief Debug MCU CoreSight component identity register 2
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$000000ff constant DBGMCU_CIDR2_PREAMBLE                            \ component identification bits [23:16]


\
\ @brief Debug MCU CoreSight component identity register 3
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant DBGMCU_CIDR3_PREAMBLE                            \ component identification bits [31:24]


\
\ @brief MCU debug component
\
$e0044000 constant DBGMCU_IDCODE  \ offset: 0x00 : DBGMCU_IDCODE
$e0044004 constant DBGMCU_CR      \ offset: 0x04 : Debug MCU configuration register
$e0044008 constant DBGMCU_APB1LFZR  \ offset: 0x08 : Debug MCU APB1L peripheral freeze register
$e004400c constant DBGMCU_APB1HFZR  \ offset: 0x0C : Debug MCU APB1H peripheral freeze register
$e0044010 constant DBGMCU_APB2FZR  \ offset: 0x10 : Debug MCU APB2 peripheral freeze register
$e0044014 constant DBGMCU_APB3FZR  \ offset: 0x14 : Debug MCU APB3 peripheral freeze register
$e0044020 constant DBGMCU_AHB1FZR  \ offset: 0x20 : Debug MCU AHB1 peripheral freeze register
$e0044028 constant DBGMCU_AHB3FZR  \ offset: 0x28 : Debug MCU AHB3 peripheral freeze register
$e00440fc constant DBGMCU_SR      \ offset: 0xFC : DBGMCU status register
$e0044100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST  \ offset: 0x100 : DBGMCU debug host authentication register
$e0044104 constant DBGMCU_DBG_AUTH_DEVICE  \ offset: 0x104 : DBGMCU debug device authentication register
$e0044fd0 constant DBGMCU_PIDR4   \ offset: 0xFD0 : Debug MCU CoreSight peripheral identity register 4
$e0044fe0 constant DBGMCU_PIDR0   \ offset: 0xFE0 : Debug MCU CoreSight peripheral identity register 0
$e0044fe4 constant DBGMCU_PIDR1   \ offset: 0xFE4 : Debug MCU CoreSight peripheral identity register 1
$e0044fe8 constant DBGMCU_PIDR2   \ offset: 0xFE8 : Debug MCU CoreSight peripheral identity register 2
$e0044fec constant DBGMCU_PIDR3   \ offset: 0xFEC : Debug MCU CoreSight peripheral identity register 3
$e0044ff0 constant DBGMCU_CIDR0   \ offset: 0xFF0 : Debug MCU CoreSight component identity register 0
$e0044ff4 constant DBGMCU_CIDR1   \ offset: 0xFF4 : Debug MCU CoreSight component identity register 1
$e0044ff8 constant DBGMCU_CIDR2   \ offset: 0xFF8 : Debug MCU CoreSight component identity register 2
$e0044ffc constant DBGMCU_CIDR3   \ offset: 0xFFC : Debug MCU CoreSight component identity register 3

