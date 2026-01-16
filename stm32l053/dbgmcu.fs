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


\
\ @brief APB Low Freeze Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1_FZ_DBG_TIMER2_STOP                   \ Debug Timer 2 stopped when Core is halted
$00000010 constant DBGMCU_APB1_FZ_DBG_TIMER6_STOP                   \ Debug Timer 6 stopped when Core is halted
$00000400 constant DBGMCU_APB1_FZ_DBG_RTC_STOP                      \ Debug RTC stopped when Core is halted
$00000800 constant DBGMCU_APB1_FZ_DBG_WWDG_STOP                     \ Debug Window Wachdog stopped when Core is halted
$00001000 constant DBGMCU_APB1_FZ_DBG_IWDG_STOP                     \ Debug Independent Wachdog stopped when Core is halted
$00200000 constant DBGMCU_APB1_FZ_DBG_I2C1_STOP                     \ I2C1 SMBUS timeout mode stopped when core is halted
$00400000 constant DBGMCU_APB1_FZ_DBG_I2C2_STOP                     \ I2C2 SMBUS timeout mode stopped when core is halted
$80000000 constant DBGMCU_APB1_FZ_DBG_LPTIMER_STOP                  \ LPTIM1 counter stopped when core is halted


\
\ @brief APB High Freeze Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000004 constant DBGMCU_APB2_FZ_DBG_TIMER21_STOP                  \ Debug Timer 21 stopped when Core is halted
$00000040 constant DBGMCU_APB2_FZ_DBG_TIMER22_STO                   \ Debug Timer 22 stopped when Core is halted


\
\ @brief Debug support
\
$40015800 constant DBGMCU_IDCODE  \ offset: 0x00 : MCU Device ID Code Register
$40015804 constant DBGMCU_CR      \ offset: 0x04 : Debug MCU Configuration Register
$40015808 constant DBGMCU_APB1_FZ  \ offset: 0x08 : APB Low Freeze Register
$4001580c constant DBGMCU_APB2_FZ  \ offset: 0x0C : APB High Freeze Register

