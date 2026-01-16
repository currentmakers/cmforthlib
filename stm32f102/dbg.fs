\
\ @file dbg.fs
\ @brief Debug support
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

$00000fff constant DBG_IDCODE_DEV_ID                                \ DEV_ID
$ffff0000 constant DBG_IDCODE_REV_ID                                \ REV_ID


\
\ @brief DBGMCU_CR
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBG_CR_DBG_SLEEP                                 \ DBG_SLEEP
$00000002 constant DBG_CR_DBG_STOP                                  \ DBG_STOP
$00000004 constant DBG_CR_DBG_STANDBY                               \ DBG_STANDBY
$00000020 constant DBG_CR_TRACE_IOEN                                \ TRACE_IOEN
$000000c0 constant DBG_CR_TRACE_MODE                                \ TRACE_MODE
$00000100 constant DBG_CR_DBG_IWDG_STOP                             \ DBG_IWDG_STOP
$00000200 constant DBG_CR_DBG_WWDG_STOP                             \ DBG_WWDG_STOP
$00000800 constant DBG_CR_DBG_TIM2_STOP                             \ DBG_TIM2_STOP
$00001000 constant DBG_CR_DBG_TIM3_STOP                             \ DBG_TIM3_STOP
$00008000 constant DBG_CR_DBG_I2C1_SMBUS_TIMEOUT                    \ DBG_I2C1_SMBUS_TIMEOUT


\
\ @brief Debug support
\
$e0042000 constant DBG_IDCODE     \ offset: 0x00 : DBGMCU_IDCODE
$e0042004 constant DBG_CR         \ offset: 0x04 : DBGMCU_CR

