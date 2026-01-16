\
\ @file dbg.fs
\ @brief DBG register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DBG device ID code register
\ Address offset: 0x00
\ Reset value: 0x10000453
\

$00000fff constant DBG_DBG_IDCODE_DEV_ID                            \ Device identifier This bitfield indicates the device ID.
$ffff0000 constant DBG_DBG_IDCODE_REV_ID                            \ Revision identifier This bitfield indicates the revision of the device.


\
\ @brief DBG configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant DBG_DBG_CR_DBG_STOP                              \ Debug Stop mode
$00000004 constant DBG_DBG_CR_DBG_STANDBY                           \ Debug Standby and Shutdown modes


\
\ @brief DBG APB freeze register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant DBG_DBG_APB_FZ1_DBG_TIM3_STOP                    \ Clocking of TIM3 counter when the core is halted This bit enables/disables the clock to the counter of TIM3 when the core is halted:
$00000400 constant DBG_DBG_APB_FZ1_DBG_RTC_STOP                     \ Clocking of RTC counter when the core is halted This bit enables/disables the clock to the counter of RTC when the core is halted:
$00000800 constant DBG_DBG_APB_FZ1_DBG_WWDG_STOP                    \ Clocking of WWDG counter when the core is halted This bit enables/disables the clock to the counter of WWDG when the core is halted:
$00001000 constant DBG_DBG_APB_FZ1_DBG_IWDG_STOP                    \ Clocking of IWDG counter when the core is halted This bit enables/disables the clock to the counter of IWDG when the core is halted:
$00200000 constant DBG_DBG_APB_FZ1_DBG_I2C1_SMBUS_TIMEOUT           \ SMBUS timeout when core is halted


\
\ @brief DBG APB freeze register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000800 constant DBG_DBG_APB_FZ2_DBG_TIM1_STOP                    \ Clocking of TIM1 counter when the core is halted This bit enables/disables the clock to the counter of TIM1 when the core is halted:
$00008000 constant DBG_DBG_APB_FZ2_DBG_TIM14_STOP                   \ Clocking of TIM14 counter when the core is halted This bit enables/disables the clock to the counter of TIM14 when the core is halted:
$00020000 constant DBG_DBG_APB_FZ2_DBG_TIM16_STOP                   \ Clocking of TIM16 counter when the core is halted This bit enables/disables the clock to the counter of TIM16 when the core is halted:
$00040000 constant DBG_DBG_APB_FZ2_DBG_TIM17_STOP                   \ Clocking of TIM17 counter when the core is halted This bit enables/disables the clock to the counter of TIM17 when the core is halted:


\
\ @brief DBG register block
\
$40015800 constant DBG_DBG_IDCODE  \ offset: 0x00 : DBG device ID code register
$40015804 constant DBG_DBG_CR     \ offset: 0x04 : DBG configuration register
$40015808 constant DBG_DBG_APB_FZ1  \ offset: 0x08 : DBG APB freeze register 1
$4001580c constant DBG_DBG_APB_FZ2  \ offset: 0x0C : DBG APB freeze register 2

