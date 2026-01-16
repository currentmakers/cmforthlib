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

$00000001 constant DBGMCU_APB1FZR1_DBG_TIM2_STOP                    \ TIM2 counter stopped when core is halted
$00000010 constant DBGMCU_APB1FZR1_DBG_TIM6_STOP                    \ TIM6 counter stopped when core is halted
$00000020 constant DBGMCU_APB1FZR1_DBG_TIM7_STOP                    \ TIM7 counter stopped when core is halted
$00000400 constant DBGMCU_APB1FZR1_DBG_RTC_STOP                     \ RTC counter stopped when core is halted
$00000800 constant DBGMCU_APB1FZR1_DBG_WWDG_STOP                    \ Window watchdog counter stopped when core is halted
$00001000 constant DBGMCU_APB1FZR1_DBG_IWDG_STOP                    \ Independent watchdog counter stopped when core is halted
$00200000 constant DBGMCU_APB1FZR1_DBG_I2C1_STOP                    \ I2C1 SMBUS timeout counter stopped when core is halted
$00400000 constant DBGMCU_APB1FZR1_DBG_I2C2_STOP                    \ I2C2 SMBUS timeout counter stopped when core is halted
$00800000 constant DBGMCU_APB1FZR1_DBG_I2C3_STOP                    \ I2C3 SMBUS timeout counter stopped when core is halted
$02000000 constant DBGMCU_APB1FZR1_DBG_CAN_STOP                     \ bxCAN stopped when core is halted
$80000000 constant DBGMCU_APB1FZR1_DBG_LPTIM1_STOP                  \ LPTIM1 counter stopped when core is halted


\
\ @brief Debug MCU APB1 freeze register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000020 constant DBGMCU_APB1FZR2_DBG_LPTIM2_STOP                  \ LPTIM2 counter stopped when core is halted


\
\ @brief Debug MCU APB2 freeze register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_APB2FZR_DBG_TIM1_STOP                     \ TIM1 counter stopped when core is halted
$00010000 constant DBGMCU_APB2FZR_DBG_TIM15_STOP                    \ TIM15 counter stopped when core is halted
$00020000 constant DBGMCU_APB2FZR_DBG_TIM16_STOP                    \ TIM16 counter stopped when core is halted


\
\ @brief MCU debug component
\
$e0042000 constant DBGMCU_IDCODE  \ offset: 0x00 : DBGMCU_IDCODE
$e0042004 constant DBGMCU_CR      \ offset: 0x04 : Debug MCU configuration register
$e0042008 constant DBGMCU_APB1FZR1  \ offset: 0x08 : Debug MCU APB1 freeze register1
$e004200c constant DBGMCU_APB1FZR2  \ offset: 0x0C : Debug MCU APB1 freeze register 2
$e0042010 constant DBGMCU_APB2FZR  \ offset: 0x10 : Debug MCU APB2 freeze register

