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
$ffff0000 constant DBGMCU_IDCODE_REV_ID                             \ Revision Identifier


\
\ @brief Debug MCU Configuration Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_CR_DBG_SLEEP                              \ Debug Sleep Mode
$00000002 constant DBGMCU_CR_DBG_STOP                               \ Debug Stop Mode
$00000004 constant DBGMCU_CR_DBG_STANDBY                            \ Debug Standby Mode
$00000020 constant DBGMCU_CR_TRACE_IOEN                             \ Trace port and clock enable
$10000000 constant DBGMCU_CR_TRGOEN                                 \ External trigger output enable


\
\ @brief APB1 Low Freeze Register CPU1
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1FZR1_DBG_TIMER2_STOP                  \ Debug Timer 2 stopped when Core is halted
$00000400 constant DBGMCU_APB1FZR1_DBG_RTC_STOP                     \ RTC counter stopped when core is halted
$00000800 constant DBGMCU_APB1FZR1_DBG_WWDG_STOP                    \ WWDG counter stopped when core is halted
$00001000 constant DBGMCU_APB1FZR1_DBG_IWDG_STOP                    \ IWDG counter stopped when core is halted
$00200000 constant DBGMCU_APB1FZR1_DBG_I2C1_STOP                    \ Debug I2C1 SMBUS timeout stopped when Core is halted
$00800000 constant DBGMCU_APB1FZR1_DBG_I2C3_STOP                    \ Debug I2C3 SMBUS timeout stopped when core is halted
$80000000 constant DBGMCU_APB1FZR1_DBG_LPTIM1_STOP                  \ Debug LPTIM1 stopped when Core is halted


\
\ @brief APB1 Low Freeze Register CPU2
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_C2AP_B1FZR1_DBG_LPTIM2_STOP               \ LPTIM2 counter stopped when core is halted
$00000400 constant DBGMCU_C2AP_B1FZR1_DBG_RTC_STOP                  \ RTC counter stopped when core is halted
$00001000 constant DBGMCU_C2AP_B1FZR1_DBG_IWDG_STOP                 \ IWDG stopped when core is halted
$00200000 constant DBGMCU_C2AP_B1FZR1_DBG_I2C1_STOP                 \ I2C1 SMBUS timeout stopped when core is halted
$00800000 constant DBGMCU_C2AP_B1FZR1_DBG_I2C3_STOP                 \ I2C3 SMBUS timeout stopped when core is halted
$80000000 constant DBGMCU_C2AP_B1FZR1_DBG_LPTIM1_STOP               \ LPTIM1 counter stopped when core is halted


\
\ @brief APB1 High Freeze Register CPU1
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000020 constant DBGMCU_APB1FZR2_DBG_LPTIM2_STOP                  \ LPTIM2 counter stopped when core is halted


\
\ @brief APB1 High Freeze Register CPU2
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000020 constant DBGMCU_C2APB1FZR2_DBG_LPTIM2_STOP                \ LPTIM2 counter stopped when core is halted


\
\ @brief APB2 Freeze Register CPU2
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_C2APB2FZR_DBG_TIM1_STOP                   \ TIM1 counter stopped when core is halted
$00020000 constant DBGMCU_C2APB2FZR_DBG_TIM16_STOP                  \ TIM16 counter stopped when core is halted
$00040000 constant DBGMCU_C2APB2FZR_DBG_TIM17_STOP                  \ TIM17 counter stopped when core is halted


\
\ @brief APB2 Freeze Register CPU1
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_APB2FZR_DBG_TIM1_STOP                     \ TIM1 counter stopped when core is halted
$00020000 constant DBGMCU_APB2FZR_DBG_TIM16_STOP                    \ TIM16 counter stopped when core is halted
$00040000 constant DBGMCU_APB2FZR_DBG_TIM17_STOP                    \ TIM17 counter stopped when core is halted


\
\ @brief Debug support
\
$e0042000 constant DBGMCU_IDCODE  \ offset: 0x00 : MCU Device ID Code Register
$e0042004 constant DBGMCU_CR      \ offset: 0x04 : Debug MCU Configuration Register
$e004203c constant DBGMCU_APB1FZR1  \ offset: 0x3C : APB1 Low Freeze Register CPU1
$e0042040 constant DBGMCU_C2AP_B1FZR1  \ offset: 0x40 : APB1 Low Freeze Register CPU2
$e0042044 constant DBGMCU_APB1FZR2  \ offset: 0x44 : APB1 High Freeze Register CPU1
$e0042048 constant DBGMCU_C2APB1FZR2  \ offset: 0x48 : APB1 High Freeze Register CPU2
$e0042048 constant DBGMCU_C2APB2FZR  \ offset: 0x48 : APB2 Freeze Register CPU2
$e004204c constant DBGMCU_APB2FZR  \ offset: 0x4C : APB2 Freeze Register CPU1

