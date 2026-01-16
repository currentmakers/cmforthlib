\
\ @file dbgmcu.fs
\ @brief debug support
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DBGMCU_IDCODE
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000fff constant DBGMCU_IDCODE_DEV_ID                             \ Device identifier
$ffff0000 constant DBGMCU_IDCODE_REV_ID                             \ Revision identifie


\
\ @brief Debug MCU configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_CR_DBG_SLEEP                              \ Debug Sleep mode
$00000002 constant DBGMCU_CR_DBG_STOP                               \ Debug Stop mode
$00000004 constant DBGMCU_CR_DBG_STANDBY                            \ Debug Standby mode
$00000020 constant DBGMCU_CR_TRACE_IOEN                             \ Trace pin assignment control
$000000c0 constant DBGMCU_CR_TRACE_MODE                             \ Trace pin assignment control


\
\ @brief Debug MCU APB1 freeze register1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1_FZ_DBG_TIM2_STOP                     \ TIM2 counter stopped when core is halted
$00000002 constant DBGMCU_APB1_FZ_DBG_TIM3_STOP                     \ TIM3 counter stopped when core is halted
$00000004 constant DBGMCU_APB1_FZ_DBG_TIM4_STOP                     \ TIM4 counter stopped when core is halted
$00000008 constant DBGMCU_APB1_FZ_DBG_TIM5_STOP                     \ TIM5 counter stopped when core is halted
$00000010 constant DBGMCU_APB1_FZ_DBG_TIM6_STOP                     \ TIM6 counter stopped when core is halted
$00000020 constant DBGMCU_APB1_FZ_DBG_TIM7_STOP                     \ TIM7 counter stopped when core is halted
$00000400 constant DBGMCU_APB1_FZ_DBG_RTC_STOP                      \ Debug RTC stopped when core is halted
$00000800 constant DBGMCU_APB1_FZ_DBG_WWDG_STOP                     \ Debug window watchdog stopped when core is halted
$00001000 constant DBGMCU_APB1_FZ_DBG_IWDG_STOP                     \ Debug independent watchdog stopped when core is halted
$00200000 constant DBGMCU_APB1_FZ_DBG_I2C1_SMBUS_TIMEOUT            \ SMBUS timeout mode stopped when core is halted
$00400000 constant DBGMCU_APB1_FZ_DBG_I2C2_SMBUS_TIMEOUT            \ SMBUS timeout mode stopped when core is halted


\
\ @brief Debug MCU APB1 freeze register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000004 constant DBGMCU_APB2_FZ_DBG_TIM9_STOP                     \ TIM counter stopped when core is halted
$00000008 constant DBGMCU_APB2_FZ_DBG_TIM10_STOP                    \ TIM counter stopped when core is halted
$00000010 constant DBGMCU_APB2_FZ_DBG_TIM11_STOP                    \ TIM counter stopped when core is halted


\
\ @brief debug support
\
$e0042000 constant DBGMCU_IDCODE  \ offset: 0x00 : DBGMCU_IDCODE
$e0042004 constant DBGMCU_CR      \ offset: 0x04 : Debug MCU configuration register
$e0042008 constant DBGMCU_APB1_FZ  \ offset: 0x08 : Debug MCU APB1 freeze register1
$e004200c constant DBGMCU_APB2_FZ  \ offset: 0x0C : Debug MCU APB1 freeze register 2

