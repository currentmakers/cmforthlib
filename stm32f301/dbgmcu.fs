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

$00000001 constant DBGMCU_CR_DBG_SLEEP                              \ Debug Sleep mode
$00000002 constant DBGMCU_CR_DBG_STOP                               \ Debug Stop Mode
$00000004 constant DBGMCU_CR_DBG_STANDBY                            \ Debug Standby Mode
$00000020 constant DBGMCU_CR_TRACE_IOEN                             \ Trace pin assignment control
$000000c0 constant DBGMCU_CR_TRACE_MODE                             \ Trace pin assignment control


\
\ @brief APB Low Freeze Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1FZ_DBG_TIM2_STOP                      \ Debug Timer 2 stopped when Core is halted
$00000002 constant DBGMCU_APB1FZ_DBG_TIM3_STOP                      \ Debug Timer 3 stopped when Core is halted
$00000004 constant DBGMCU_APB1FZ_DBG_TIM4_STOP                      \ Debug Timer 4 stopped when Core is halted
$00000008 constant DBGMCU_APB1FZ_DBG_TIM5_STOP                      \ Debug Timer 5 stopped when Core is halted
$00000010 constant DBGMCU_APB1FZ_DBG_TIM6_STOP                      \ Debug Timer 6 stopped when Core is halted
$00000020 constant DBGMCU_APB1FZ_DBG_TIM7_STOP                      \ Debug Timer 7 stopped when Core is halted
$00000040 constant DBGMCU_APB1FZ_DBG_TIM12_STOP                     \ Debug Timer 12 stopped when Core is halted
$00000080 constant DBGMCU_APB1FZ_DBG_TIM13_STOP                     \ Debug Timer 13 stopped when Core is halted
$00000100 constant DBGMCU_APB1FZ_DBG_TIMER14_STOP                   \ Debug Timer 14 stopped when Core is halted
$00000200 constant DBGMCU_APB1FZ_DBG_TIM18_STOP                     \ Debug Timer 18 stopped when Core is halted
$00000400 constant DBGMCU_APB1FZ_DBG_RTC_STOP                       \ Debug RTC stopped when Core is halted
$00000800 constant DBGMCU_APB1FZ_DBG_WWDG_STOP                      \ Debug Window Wachdog stopped when Core is halted
$00001000 constant DBGMCU_APB1FZ_DBG_IWDG_STOP                      \ Debug Independent Wachdog stopped when Core is halted
$00200000 constant DBGMCU_APB1FZ_I2C1_SMBUS_TIMEOUT                 \ SMBUS timeout mode stopped when Core is halted
$00400000 constant DBGMCU_APB1FZ_I2C2_SMBUS_TIMEOUT                 \ SMBUS timeout mode stopped when Core is halted
$02000000 constant DBGMCU_APB1FZ_DBG_CAN_STOP                       \ Debug CAN stopped when core is halted


\
\ @brief APB High Freeze Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000004 constant DBGMCU_APB2FZ_DBG_TIM15_STOP                     \ Debug Timer 15 stopped when Core is halted
$00000008 constant DBGMCU_APB2FZ_DBG_TIM16_STOP                     \ Debug Timer 16 stopped when Core is halted
$00000010 constant DBGMCU_APB2FZ_DBG_TIM17_STO                      \ Debug Timer 17 stopped when Core is halted
$00000020 constant DBGMCU_APB2FZ_DBG_TIM19_STOP                     \ Debug Timer 19 stopped when Core is halted


\
\ @brief Debug support
\
$e0042000 constant DBGMCU_IDCODE  \ offset: 0x00 : MCU Device ID Code Register
$e0042004 constant DBGMCU_CR      \ offset: 0x04 : Debug MCU Configuration Register
$e0042008 constant DBGMCU_APB1FZ  \ offset: 0x08 : APB Low Freeze Register
$e004200c constant DBGMCU_APB2FZ  \ offset: 0x0C : APB High Freeze Register

