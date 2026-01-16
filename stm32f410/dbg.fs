\
\ @file dbg.fs
\ @brief Debug support
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief IDCODE
\ Address offset: 0x00
\ Reset value: 0x10006411
\

$00000fff constant DBG_DBGMCU_IDCODE_DEV_ID                         \ DEV_ID
$ffff0000 constant DBG_DBGMCU_IDCODE_REV_ID                         \ REV_ID


\
\ @brief Control Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBG_DBGMCU_CR_DBG_SLEEP                          \ DBG_SLEEP
$00000002 constant DBG_DBGMCU_CR_DBG_STOP                           \ DBG_STOP
$00000004 constant DBG_DBGMCU_CR_DBG_STANDBY                        \ DBG_STANDBY
$00000020 constant DBG_DBGMCU_CR_TRACE_IOEN                         \ TRACE_IOEN
$000000c0 constant DBG_DBGMCU_CR_TRACE_MODE                         \ TRACE_MODE


\
\ @brief Debug MCU APB1 Freeze registe
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBG_DBGMCU_APB1_FZ_DBG_TIM2_STOP                 \ DBG_TIM2_STOP
$00000002 constant DBG_DBGMCU_APB1_FZ_DBG_TIM3_STOP                 \ DBG_TIM3 _STOP
$00000004 constant DBG_DBGMCU_APB1_FZ_DBG_TIM4_STOP                 \ DBG_TIM4_STOP
$00000008 constant DBG_DBGMCU_APB1_FZ_DBG_TIM5_STOP                 \ DBG_TIM5_STOP
$00000400 constant DBG_DBGMCU_APB1_FZ_DBG_RTC_STOP                  \ RTC stopped when Core is halted
$00000800 constant DBG_DBGMCU_APB1_FZ_DBG_WWDG_STOP                 \ DBG_WWDG_STOP
$00001000 constant DBG_DBGMCU_APB1_FZ_DBG_IWDEG_STOP                \ DBG_IWDEG_STOP
$00200000 constant DBG_DBGMCU_APB1_FZ_DBG_I2C1_SMBUS_TIMEOUT        \ DBG_J2C1_SMBUS_TIMEOUT
$00400000 constant DBG_DBGMCU_APB1_FZ_DBG_I2C2_SMBUS_TIMEOUT        \ DBG_J2C2_SMBUS_TIMEOUT
$00800000 constant DBG_DBGMCU_APB1_FZ_DBG_I2C3SMBUS_TIMEOUT         \ DBG_J2C3SMBUS_TIMEOUT


\
\ @brief Debug MCU APB2 Freeze registe
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DBG_DBGMCU_APB2_FZ_DBG_TIM1_STOP                 \ TIM1 counter stopped when core is halted
$00010000 constant DBG_DBGMCU_APB2_FZ_DBG_TIM9_STOP                 \ TIM9 counter stopped when core is halted
$00020000 constant DBG_DBGMCU_APB2_FZ_DBG_TIM10_STOP                \ TIM10 counter stopped when core is halted
$00040000 constant DBG_DBGMCU_APB2_FZ_DBG_TIM11_STOP                \ TIM11 counter stopped when core is halted


\
\ @brief Debug support
\
$e0042000 constant DBG_DBGMCU_IDCODE  \ offset: 0x00 : IDCODE
$e0042004 constant DBG_DBGMCU_CR  \ offset: 0x04 : Control Register
$e0042008 constant DBG_DBGMCU_APB1_FZ  \ offset: 0x08 : Debug MCU APB1 Freeze registe
$e004200c constant DBG_DBGMCU_APB2_FZ  \ offset: 0x0C : Debug MCU APB2 Freeze registe

