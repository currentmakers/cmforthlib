\
\ @file dbgmcu.fs
\ @brief DBGMCU register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DBGMCU device ID code register
\ Address offset: 0x00
\ Reset value: 0x00006000
\

$00000fff constant DBGMCU_DBGMCU_IDCODE_DEV_ID                      \ Device identifier This field indicates the device ID.
$ffff0000 constant DBGMCU_DBGMCU_IDCODE_REV_ID                      \ Revision identifier This field indicates the revision of the device.


\
\ @brief DBGMCU configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant DBGMCU_DBGMCU_CR_DBG_STOP                        \ Debug Stop mode Debug options in Stop mode.
$00000004 constant DBGMCU_DBGMCU_CR_DBG_STANDBY                     \ Debug Standby and Shutdown modes Debug options in Standby or Shutdown mode.


\
\ @brief DBGMCU APB1 freeze register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_APB1FZR_DBG_TIM2_STOP              \ TIM2 stop in debug
$00000002 constant DBGMCU_DBGMCU_APB1FZR_DBG_TIM3_STOP              \ TIM3 stop in debug
$00000004 constant DBGMCU_DBGMCU_APB1FZR_DBG_TIM4_STOP              \ TIM4 stop in debug
$00000010 constant DBGMCU_DBGMCU_APB1FZR_DBG_TIM6_STOP              \ TIM6 stop in debug
$00000020 constant DBGMCU_DBGMCU_APB1FZR_DBG_TIM7_STOP              \ TIM7 stop in debug
$00000400 constant DBGMCU_DBGMCU_APB1FZR_DBG_RTC_STOP               \ RTC stop in debug
$00000800 constant DBGMCU_DBGMCU_APB1FZR_DBG_WWDG_STOP              \ WWDG stop in debug
$00001000 constant DBGMCU_DBGMCU_APB1FZR_DBG_IWDG_STOP              \ IWDG stop in debug
$00200000 constant DBGMCU_DBGMCU_APB1FZR_DBG_I2C3_STOP              \ I2C3 SMBUS timeout stop in debug
$00400000 constant DBGMCU_DBGMCU_APB1FZR_DBG_I2C1_STOP              \ I2C1 SMBUS timeout stop in debug
$40000000 constant DBGMCU_DBGMCU_APB1FZR_DBG_LPTIM2_STOP            \ LPTIM2 stop in debug
$80000000 constant DBGMCU_DBGMCU_APB1FZR_DBG_LPTIM1_STOP            \ LPTIM1 stop in debug


\
\ @brief DBG APB2 freeze register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM1_STOP              \ TIM1 stop in debug
$00008000 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM14_STOP             \ TIM14 stop in debug
$00010000 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM15_STOP             \ TIM15 stop in debug
$00020000 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM16_STOP             \ TIM16 stop in debug


\
\ @brief DBGMCU status register
\ Address offset: 0xFC
\ Reset value: 0x00010003
\

$00000001 constant DBGMCU_DBGMCU_SR_AP1_PRESENT                     \ Identifies whether access port AP1 is present in device
$00000002 constant DBGMCU_DBGMCU_SR_AP0_PRESENT                     \ Identifies whether access port AP0 is present in device
$00010000 constant DBGMCU_DBGMCU_SR_AP1_ENABLED                     \ Identifies whether access port AP0 is open (can be accessed via the debug port) or locked (debug access to the AP is blocked)
$00020000 constant DBGMCU_DBGMCU_SR_AP0_ENABLED                     \ Identifies whether access port AP0 is open (can be accessed via the debug port) or locked (debug access to the AP is blocked)


\
\ @brief DBGMCU debug authentication mailbox host register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_DBG_AUTH_HOST_MESSAGE              \ Debug host to device mailbox message. During debug authentication the debug host communicates with the device via this register.


\
\ @brief DBGMCU debug authentication mailbox device register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE_MESSAGE            \ Device to debug host mailbox message. During debug authentication the device communicates with the debug host via this register.


\
\ @brief DBGMCU CoreSight peripheral identity register 4
\ Address offset: 0xFD0
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR4_JEP106CON                    \ JEP106 continuation code
$000000f0 constant DBGMCU_DBGMCU_PIDR4_SIZE                         \ register file size


\
\ @brief DBGMCU CoreSight peripheral identity register 0
\ Address offset: 0xFE0
\ Reset value: 0x00000000
\

$000000ff constant DBGMCU_DBGMCU_PIDR0_PARTNUM                      \ part number bits [7:0]


\
\ @brief DBGMCU CoreSight peripheral identity register 1
\ Address offset: 0xFE4
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR1_PARTNUM                      \ part number bits [11:8]
$000000f0 constant DBGMCU_DBGMCU_PIDR1_JEP106ID                     \ JEP106 identity code bits [3:0]


\
\ @brief DBGMCU CoreSight peripheral identity register 2
\ Address offset: 0xFE8
\ Reset value: 0x0000000A
\

$00000007 constant DBGMCU_DBGMCU_PIDR2_JEP106ID                     \ JEP106 identity code bits [6:4]
$00000008 constant DBGMCU_DBGMCU_PIDR2_JEDEC                        \ JEDEC assigned value
$000000f0 constant DBGMCU_DBGMCU_PIDR2_REVISION                     \ component revision number


\
\ @brief DBGMCU CoreSight peripheral identity register 3
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR3_CMOD                         \ customer modified
$000000f0 constant DBGMCU_DBGMCU_PIDR3_REVAND                       \ metal fix version


\
\ @brief DBGMCU CoreSight component identity register 0
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant DBGMCU_DBGMCU_CIDR0_PREAMBLE                     \ component identification bits [7:0]


\
\ @brief DBGMCU CoreSight component identity register 1
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant DBGMCU_DBGMCU_CIDR1_PREAMBLE                     \ component identification bits [11:8]
$000000f0 constant DBGMCU_DBGMCU_CIDR1_CLASS                        \ component identification bits [15:12] - component class


\
\ @brief DBGMCU CoreSight component identity register 2
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$000000ff constant DBGMCU_DBGMCU_CIDR2_PREAMBLE                     \ component identification bits [23:16]


\
\ @brief DBGMCU CoreSight component identity register 3
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant DBGMCU_DBGMCU_CIDR3_PREAMBLE                     \ component identification bits [31:24]


\
\ @brief DBGMCU register block
\
$40015800 constant DBGMCU_DBGMCU_IDCODE  \ offset: 0x00 : DBGMCU device ID code register
$40015804 constant DBGMCU_DBGMCU_CR  \ offset: 0x04 : DBGMCU configuration register
$40015808 constant DBGMCU_DBGMCU_APB1FZR  \ offset: 0x08 : DBGMCU APB1 freeze register
$4001580c constant DBGMCU_DBGMCU_APB2FZR  \ offset: 0x0C : DBG APB2 freeze register
$400158fc constant DBGMCU_DBGMCU_SR  \ offset: 0xFC : DBGMCU status register
$40015900 constant DBGMCU_DBGMCU_DBG_AUTH_HOST  \ offset: 0x100 : DBGMCU debug authentication mailbox host register
$40015904 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE  \ offset: 0x104 : DBGMCU debug authentication mailbox device register
$400167d0 constant DBGMCU_DBGMCU_PIDR4  \ offset: 0xFD0 : DBGMCU CoreSight peripheral identity register 4
$400167e0 constant DBGMCU_DBGMCU_PIDR0  \ offset: 0xFE0 : DBGMCU CoreSight peripheral identity register 0
$400167e4 constant DBGMCU_DBGMCU_PIDR1  \ offset: 0xFE4 : DBGMCU CoreSight peripheral identity register 1
$400167e8 constant DBGMCU_DBGMCU_PIDR2  \ offset: 0xFE8 : DBGMCU CoreSight peripheral identity register 2
$400167ec constant DBGMCU_DBGMCU_PIDR3  \ offset: 0xFEC : DBGMCU CoreSight peripheral identity register 3
$400167f0 constant DBGMCU_DBGMCU_CIDR0  \ offset: 0xFF0 : DBGMCU CoreSight component identity register 0
$400167f4 constant DBGMCU_DBGMCU_CIDR1  \ offset: 0xFF4 : DBGMCU CoreSight component identity register 1
$400167f8 constant DBGMCU_DBGMCU_CIDR2  \ offset: 0xFF8 : DBGMCU CoreSight component identity register 2
$400167fc constant DBGMCU_DBGMCU_CIDR3  \ offset: 0xFFC : DBGMCU CoreSight component identity register 3

