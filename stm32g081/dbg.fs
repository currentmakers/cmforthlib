\
\ @file dbg.fs
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

$0000ffff constant DBG_IDCODE_DEV_ID                                \ Device Identifier
$ffff0000 constant DBG_IDCODE_REV_ID                                \ Revision Identifier


\
\ @brief Debug MCU Configuration Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant DBG_CR_DBG_STOP                                  \ Debug Stop Mode
$00000004 constant DBG_CR_DBG_STANDBY                               \ Debug Standby Mode


\
\ @brief DBG APB freeze register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBG_APB_FZ1_DBG_TIMER2_STOP                      \ Debug Timer 2 stopped when Core is halted
$00000002 constant DBG_APB_FZ1_DBG_TIM3_STOP                        \ TIM3 counter stopped when core is halted
$00000010 constant DBG_APB_FZ1_DBG_TIMER6_STOP                      \ Debug Timer 6 stopped when Core is halted
$00000020 constant DBG_APB_FZ1_DBG_TIM7_STOP                        \ TIM7 counter stopped when core is halted
$00000400 constant DBG_APB_FZ1_DBG_RTC_STOP                         \ Debug RTC stopped when Core is halted
$00000800 constant DBG_APB_FZ1_DBG_WWDG_STOP                        \ Debug Window Wachdog stopped when Core is halted
$00001000 constant DBG_APB_FZ1_DBG_IWDG_STOP                        \ Debug Independent Wachdog stopped when Core is halted
$00200000 constant DBG_APB_FZ1_DBG_I2C1_STOP                        \ I2C1 SMBUS timeout mode stopped when core is halted
$40000000 constant DBG_APB_FZ1_DBG_LPTIM2_STOP                      \ Clocking of LPTIMER2 counter when the core is halted
$80000000 constant DBG_APB_FZ1_DBG_LPTIM1_STOP                      \ Clocking of LPTIMER1 counter when the core is halted


\
\ @brief DBG APB freeze register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000800 constant DBG_APB_FZ2_DBG_TIM1_STOP                        \ DBG_TIM1_STOP
$00008000 constant DBG_APB_FZ2_DBG_TIM14_STOP                       \ DBG_TIM14_STOP
$00010000 constant DBG_APB_FZ2_DBG_TIM15_STOP                       \ DBG_TIM15_STOP
$00020000 constant DBG_APB_FZ2_DBG_TIM16_STOP                       \ DBG_TIM16_STOP
$00040000 constant DBG_APB_FZ2_DBG_TIM17_STOP                       \ DBG_TIM17_STOP


\
\ @brief Debug support
\
$40015800 constant DBG_IDCODE     \ offset: 0x00 : MCU Device ID Code Register
$40015804 constant DBG_CR         \ offset: 0x04 : Debug MCU Configuration Register
$40015808 constant DBG_APB_FZ1    \ offset: 0x08 : DBG APB freeze register 1
$4001580c constant DBG_APB_FZ2    \ offset: 0x0C : DBG APB freeze register 2

