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

$0000ffff constant DBGMCU_IDCODE_DEV_ID                             \ Device Identifier
$ffff0000 constant DBGMCU_IDCODE_REV_ID                             \ Revision Identifier


\
\ @brief Debug MCU Configuration Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_CR_DBG_SLEEP                              \ Debug Sleep Mode
$00000002 constant DBGMCU_CR_DBG_STOP                               \ Debug Stop Mode
$00000004 constant DBGMCU_CR_DBG_STANDBY                            \ Debug Standby Mode
$00000020 constant DBGMCU_CR_TRACE_IOEN                             \ Trace pin assignment control
$000000c0 constant DBGMCU_CR_TRACE_MODE                             \ Trace pin assignment control


\
\ @brief APB Low Freeze Register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1L_FZ_DBG_TIMER2_STOP                  \ Debug Timer 2 stopped when Core is halted
$00000002 constant DBGMCU_APB1L_FZ_DBG_TIM3_STOP                    \ TIM3 counter stopped when core is halted
$00000004 constant DBGMCU_APB1L_FZ_DBG_TIM4_STOP                    \ TIM4 counter stopped when core is halted
$00000008 constant DBGMCU_APB1L_FZ_DBG_TIM5_STOP                    \ TIM5 counter stopped when core is halted
$00000010 constant DBGMCU_APB1L_FZ_DBG_TIMER6_STOP                  \ Debug Timer 6 stopped when Core is halted
$00000020 constant DBGMCU_APB1L_FZ_DBG_TIM7_STOP                    \ TIM7 counter stopped when core is halted
$00000400 constant DBGMCU_APB1L_FZ_DBG_RTC_STOP                     \ Debug RTC stopped when Core is halted
$00000800 constant DBGMCU_APB1L_FZ_DBG_WWDG_STOP                    \ Debug Window Wachdog stopped when Core is halted
$00001000 constant DBGMCU_APB1L_FZ_DBG_IWDG_STOP                    \ Debug Independent Wachdog stopped when Core is halted
$00200000 constant DBGMCU_APB1L_FZ_DBG_I2C1_STOP                    \ I2C1 SMBUS timeout mode stopped when core is halted
$00400000 constant DBGMCU_APB1L_FZ_DBG_I2C2_STOP                    \ I2C2 SMBUS timeout mode stopped when core is halted
$40000000 constant DBGMCU_APB1L_FZ_DBG_I2C3_STOP                    \ I2C3 SMBUS timeout mode stopped when core is halted
$80000000 constant DBGMCU_APB1L_FZ_DBG_LPTIMER_STOP                 \ LPTIM1 counter stopped when core is halted


\
\ @brief APB Low Freeze Register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant DBGMCU_APB1H_FZ_DBG_I2C4_STOP                    \ DBG_I2C4_STOP


\
\ @brief APB High Freeze Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_APB2_FZ_DBG_TIM1_STOP                     \ TIM1 counter stopped when core is halted
$00002000 constant DBGMCU_APB2_FZ_DBG_TIM8_STOP                     \ TIM8 counter stopped when core is halted
$00010000 constant DBGMCU_APB2_FZ_DBG_TIM15_STOP                    \ TIM15 counter stopped when core is halted
$00020000 constant DBGMCU_APB2_FZ_DBG_TIM16_STOP                    \ TIM16 counter stopped when core is halted
$00040000 constant DBGMCU_APB2_FZ_DBG_TIM17_STOP                    \ TIM17 counter stopped when core is halted
$00100000 constant DBGMCU_APB2_FZ_DBG_TIM20_STOP                    \ TIM20counter stopped when core is halted
$04000000 constant DBGMCU_APB2_FZ_DBG_HRTIM0_STOP                   \ DBG_HRTIM0_STOP
$08000000 constant DBGMCU_APB2_FZ_DBG_HRTIM1_STOP                   \ DBG_HRTIM0_STOP
$10000000 constant DBGMCU_APB2_FZ_DBG_HRTIM2_STOP                   \ DBG_HRTIM0_STOP
$20000000 constant DBGMCU_APB2_FZ_DBG_HRTIM3_STOP                   \ DBG_HRTIM0_STOP


\
\ @brief Debug support
\
$e0042000 constant DBGMCU_IDCODE  \ offset: 0x00 : MCU Device ID Code Register
$e0042004 constant DBGMCU_CR      \ offset: 0x04 : Debug MCU Configuration Register
$e0042008 constant DBGMCU_APB1L_FZ  \ offset: 0x08 : APB Low Freeze Register 1
$e004200c constant DBGMCU_APB1H_FZ  \ offset: 0x0C : APB Low Freeze Register 2
$e0042010 constant DBGMCU_APB2_FZ  \ offset: 0x10 : APB High Freeze Register

