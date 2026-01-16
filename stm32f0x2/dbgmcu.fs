\
\ @file dbgmcu.fs
\ @brief Debug support
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MCU Device ID Code Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000fff constant DBGMCU_IDCODE_DEV_ID                             \ Device Identifier
$0000f000 constant DBGMCU_IDCODE_DIV_ID                             \ Division Identifier
$ffff0000 constant DBGMCU_IDCODE_REV_ID                             \ Revision Identifier


\
\ @brief Debug MCU Configuration Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant DBGMCU_CR_DBG_STOP                               \ Debug Stop Mode
$00000004 constant DBGMCU_CR_DBG_STANDBY                            \ Debug Standby Mode


\
\ @brief Debug MCU APB1 freeze register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1_FZ_DBG_TIM2_STOP                     \ TIM2 counter stopped when core is halted
$00000002 constant DBGMCU_APB1_FZ_DBG_TIM3_STOP                     \ TIM3 counter stopped when core is halted
$00000010 constant DBGMCU_APB1_FZ_DBG_TIM6_STOP                     \ TIM6 counter stopped when core is halted
$00000020 constant DBGMCU_APB1_FZ_DBG_TIM7_STOP                     \ TIM7 counter stopped when core is halted
$00000100 constant DBGMCU_APB1_FZ_DBG_TIM14_STOP                    \ TIM14 counter stopped when core is halted
$00000400 constant DBGMCU_APB1_FZ_DBG_RTC_STOP                      \ Debug RTC stopped when core is halted
$00000800 constant DBGMCU_APB1_FZ_DBG_WWDG_STOP                     \ Debug window watchdog stopped when core is halted
$00001000 constant DBGMCU_APB1_FZ_DBG_IWDG_STOP                     \ Debug independent watchdog stopped when core is halted
$00200000 constant DBGMCU_APB1_FZ_DBG_I2C1_SMBUS_TIMEOUT            \ SMBUS timeout mode stopped when core is halted
$02000000 constant DBGMCU_APB1_FZ_DBG_CAN_STOP                      \ CAN stopped when core is halted


\
\ @brief Debug MCU APB2 freeze register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_APB2_FZ_DBG_TIM1_STOP                     \ TIM1 counter stopped when core is halted
$00010000 constant DBGMCU_APB2_FZ_DBG_TIM15_STOP                    \ TIM15 counter stopped when core is halted
$00020000 constant DBGMCU_APB2_FZ_DBG_TIM16_STOP                    \ TIM16 counter stopped when core is halted
$00040000 constant DBGMCU_APB2_FZ_DBG_TIM17_STOP                    \ TIM17 counter stopped when core is halted


\
\ @brief Debug support
\
$40015800 constant DBGMCU_IDCODE  \ offset: 0x00 : MCU Device ID Code Register
$40015804 constant DBGMCU_CR      \ offset: 0x04 : Debug MCU Configuration Register
$40015808 constant DBGMCU_APB1_FZ  \ offset: 0x08 : Debug MCU APB1 freeze register
$4001580c constant DBGMCU_APB2_FZ  \ offset: 0x0C : Debug MCU APB2 freeze register

