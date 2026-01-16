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
\ Reset value: 0x00000000
\

$00000fff constant DBGMCU_IDCODE_DEV_ID                             \ Device identifier
$ffff0000 constant DBGMCU_IDCODE_REV_ID                             \ Revision identifie


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
\ @brief Debug MCU APB1 freeze register1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1LFZR_DBG_TIM2_STOP                    \ TIM2 counter stopped when core is halted
$00000002 constant DBGMCU_APB1LFZR_DBG_TIM3_STOP                    \ TIM3 stop in debug
$00000004 constant DBGMCU_APB1LFZR_DBG_TIM4_STOP                    \ TIM4 stop in debug
$00000008 constant DBGMCU_APB1LFZR_DBG_TIM5_STOP                    \ TIM5 stop in debug
$00000010 constant DBGMCU_APB1LFZR_DBG_TIM6_STOP                    \ TIM6 counter stopped when core is halted
$00000020 constant DBGMCU_APB1LFZR_DBG_TIM7_STOP                    \ TIM7 counter stopped when core is halted
$00000400 constant DBGMCU_APB1LFZR_DBG_RTC_STOP                     \ RTC counter stopped when core is halted
$00000800 constant DBGMCU_APB1LFZR_DBG_WWDG_STOP                    \ Window watchdog counter stopped when core is halted
$00001000 constant DBGMCU_APB1LFZR_DBG_IWDG_STOP                    \ Independent watchdog counter stopped when core is halted
$00200000 constant DBGMCU_APB1LFZR_DBG_I2C1_STOP                    \ I2C1 SMBUS timeout counter stopped when core is halted
$00400000 constant DBGMCU_APB1LFZR_DBG_I2C2_STOP                    \ I2C2 SMBUS timeout counter stopped when core is halted
$00800000 constant DBGMCU_APB1LFZR_DBG_I2C3_STOP                    \ I2C3 SMBUS timeout counter stopped when core is halted
$80000000 constant DBGMCU_APB1LFZR_DBG_LPTIM1_STOP                  \ LPTIM1 counter stopped when core is halted


\
\ @brief Debug MCU APB1 freeze register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant DBGMCU_APB1HFZR_DBG_I2C4_STOP                    \ I2C4 stop in debug
$00000020 constant DBGMCU_APB1HFZR_DBG_LPTIM2_STOP                  \ LPTIM2 counter stopped when core is halted
$00000040 constant DBGMCU_APB1HFZR_DBG_LPTIM3_STOP                  \ LPTIM3 stop in debug


\
\ @brief Debug MCU APB2 freeze register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_APB2FZR_DBG_TIM1_STOP                     \ TIM1 counter stopped when core is halted
$00002000 constant DBGMCU_APB2FZR_DBG_TIM8_STOP                     \ TIM8 stop in debug
$00010000 constant DBGMCU_APB2FZR_DBG_TIM15_STOP                    \ TIM15 counter stopped when core is halted
$00020000 constant DBGMCU_APB2FZR_DBG_TIM16_STOP                    \ TIM16 counter stopped when core is halted
$00040000 constant DBGMCU_APB2FZR_DBG_TIM17_STOP                    \ DBG_TIM17_STOP


\
\ @brief MCU debug component
\
$e0044000 constant DBGMCU_IDCODE  \ offset: 0x00 : DBGMCU_IDCODE
$e0044004 constant DBGMCU_CR      \ offset: 0x04 : Debug MCU configuration register
$e0044008 constant DBGMCU_APB1LFZR  \ offset: 0x08 : Debug MCU APB1 freeze register1
$e004400c constant DBGMCU_APB1HFZR  \ offset: 0x0C : Debug MCU APB1 freeze register 2
$e0044010 constant DBGMCU_APB2FZR  \ offset: 0x10 : Debug MCU APB2 freeze register

