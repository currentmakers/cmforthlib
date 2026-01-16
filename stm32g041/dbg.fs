\
\ @file dbg.fs
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

$00000fff constant DBG_IDCODE_DEV_ID                                \ Device identifier
$ffff0000 constant DBG_IDCODE_REV_ID                                \ Revision identifie


\
\ @brief Debug MCU configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant DBG_CR_DBG_STOP                                  \ Debug Stop mode
$00000004 constant DBG_CR_DBG_STANDBY                               \ Debug Standby mode


\
\ @brief Debug MCU APB1 freeze register1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBG_APB_FZ1_DBG_TIM2_STOP                        \ TIM2 counter stopped when core is halted
$00000002 constant DBG_APB_FZ1_DBG_TIM3_STOP                        \ TIM3 counter stopped when core is halted
$00000400 constant DBG_APB_FZ1_DBG_RTC_STOP                         \ RTC counter stopped when core is halted
$00000800 constant DBG_APB_FZ1_DBG_WWDG_STOP                        \ Window watchdog counter stopped when core is halted
$00001000 constant DBG_APB_FZ1_DBG_IWDG_STOP                        \ Independent watchdog counter stopped when core is halted
$00200000 constant DBG_APB_FZ1_DBG_I2C1_STOP                        \ I2C1 SMBUS timeout counter stopped when core is halted
$40000000 constant DBG_APB_FZ1_DBG_LPTIM2_STOP                      \ LPTIM2 counter stopped when core is halted
$80000000 constant DBG_APB_FZ1_DBG_LPTIM1_STOP                      \ LPTIM1 counter stopped when core is halted


\
\ @brief Debug MCU APB1 freeze register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000800 constant DBG_APB_FZ2_DBG_TIM1_STOP                        \ TIM1 counter stopped when core is halted
$00008000 constant DBG_APB_FZ2_DBG_TIM14_STOP                       \ DBG_TIM14_STOP
$00020000 constant DBG_APB_FZ2_DBG_TIM16_STOP                       \ DBG_TIM16_STOP
$00040000 constant DBG_APB_FZ2_DBG_TIM17_STOP                       \ DBG_TIM17_STOP


\
\ @brief MCU debug component
\
$40015800 constant DBG_IDCODE     \ offset: 0x00 : DBGMCU_IDCODE
$40015804 constant DBG_CR         \ offset: 0x04 : Debug MCU configuration register
$40015808 constant DBG_APB_FZ1    \ offset: 0x08 : Debug MCU APB1 freeze register1
$4001580c constant DBG_APB_FZ2    \ offset: 0x0C : Debug MCU APB1 freeze register 2

