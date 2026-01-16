\
\ @file dbgmcu.fs
\ @brief Microcontroller Debug Unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DBGMCU Identity Code Register
\ Address offset: 0x00
\ Reset value: 0x10006497
\

$00000fff constant DBGMCU_IDCODER_DEV_ID                            \ Device ID
$ffff0000 constant DBGMCU_IDCODER_REV_ID                            \ Revision


\
\ @brief DBGMCU Configuration Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_CR_DBG_SLEEP                              \ Allow debug in SLEEP mode
$00000002 constant DBGMCU_CR_DBG_STOP                               \ Allow debug in STOP mode
$00000004 constant DBGMCU_CR_DBG_STANDBY                            \ Allow debug in STANDBY mode


\
\ @brief DBGMCU CPU1 APB1 Peripheral Freeze Register 1
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1FZR1_DBG_TIM2_STOP                    \ TIM2 stop in CPU1 debug
$00000400 constant DBGMCU_APB1FZR1_DBG_RTC_STOP                     \ RTC stop in CPU1 debug
$00000800 constant DBGMCU_APB1FZR1_DBG_WWDG_STOP                    \ WWDG stop in CPU1 debug
$00001000 constant DBGMCU_APB1FZR1_DBG_IWDG_STOP                    \ IWDG stop in CPU1 debug
$00200000 constant DBGMCU_APB1FZR1_DBG_I2C1_STOP                    \ I2C1 SMBUS timeout stop in CPU1 debug
$00400000 constant DBGMCU_APB1FZR1_DBG_I2C2_STOP                    \ I2C2 SMBUS timeout stop in CPU1 debug
$00800000 constant DBGMCU_APB1FZR1_DBG_I2C3_STOP                    \ I2C3 SMBUS timeout stop in CPU1 debug
$80000000 constant DBGMCU_APB1FZR1_DBG_LPTIM1_STOP                  \ LPTIM1 stop in CPU1 debug


\
\ @brief DBGMCU CPU2 APB1 Peripheral Freeze Register 1 [dual core device
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_C2APB1FZR1_DBG_TIM2_STOP                  \ DBG_TIM2_STOP
$00000400 constant DBGMCU_C2APB1FZR1_DBG_RTC_STOP                   \ DBG_RTC_STOP
$00001000 constant DBGMCU_C2APB1FZR1_DBG_IWDG_STOP                  \ DBG_IWDG_STOP
$00200000 constant DBGMCU_C2APB1FZR1_DBG_I2C1_STOP                  \ DBG_I2C1_STOP
$00400000 constant DBGMCU_C2APB1FZR1_DBG_I2C2_STOP                  \ DBG_I2C2_STOP
$00800000 constant DBGMCU_C2APB1FZR1_DBG_I2C3_STOP                  \ DBG_I2C3_STOP
$80000000 constant DBGMCU_C2APB1FZR1_DBG_LPTIM1_STOP                \ DBG_LPTIM1_STOP


\
\ @brief DBGMCU CPU1 APB1 Peripheral Freeze Register 2
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000020 constant DBGMCU_APB1FZR2_DBG_LPTIM2_STOP                  \ DBG_LPTIM2_STOP
$00000040 constant DBGMCU_APB1FZR2_DBG_LPTIM3_STOP                  \ DBG_LPTIM3_STOP


\
\ @brief DBGMCU CPU2 APB1 Peripheral Freeze Register 2 [dual core device
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000020 constant DBGMCU_C2APB1FZR2_DBG_LPTIM2_STOP                \ DBG_LPTIM2_STOP
$00000040 constant DBGMCU_C2APB1FZR2_DBG_LPTIM3_STOP                \ DBG_LPTIM3_STOP


\
\ @brief DBGMCU CPU1 APB2 Peripheral Freeze Register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_APB2FZR_DBG_TIM1_STOP                     \ DBG_TIM1_STOP
$00020000 constant DBGMCU_APB2FZR_DBG_TIM16_STOP                    \ DBG_TIM16_STOP
$00040000 constant DBGMCU_APB2FZR_DBG_TIM17_STOP                    \ DBG_TIM17_STOP


\
\ @brief DBGMCU CPU2 APB2 Peripheral Freeze Register [dual core device
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_C2APB2FZR_DBG_TIM1_STOP                   \ DBG_TIM1_STOP
$00020000 constant DBGMCU_C2APB2FZR_DBG_TIM16_STOP                  \ DBG_TIM16_STOP
$00040000 constant DBGMCU_C2APB2FZR_DBG_TIM17_STOP                  \ DBG_TIM17_STOP


\
\ @brief Microcontroller Debug Unit
\
$e0042000 constant DBGMCU_IDCODER  \ offset: 0x00 : DBGMCU Identity Code Register
$e0042004 constant DBGMCU_CR      \ offset: 0x04 : DBGMCU Configuration Register
$e004203c constant DBGMCU_APB1FZR1  \ offset: 0x3C : DBGMCU CPU1 APB1 Peripheral Freeze Register 1
$e0042040 constant DBGMCU_C2APB1FZR1  \ offset: 0x40 : DBGMCU CPU2 APB1 Peripheral Freeze Register 1 [dual core device
$e0042044 constant DBGMCU_APB1FZR2  \ offset: 0x44 : DBGMCU CPU1 APB1 Peripheral Freeze Register 2
$e0042048 constant DBGMCU_C2APB1FZR2  \ offset: 0x48 : DBGMCU CPU2 APB1 Peripheral Freeze Register 2 [dual core device
$e004204c constant DBGMCU_APB2FZR  \ offset: 0x4C : DBGMCU CPU1 APB2 Peripheral Freeze Register
$e0042050 constant DBGMCU_C2APB2FZR  \ offset: 0x50 : DBGMCU CPU2 APB2 Peripheral Freeze Register [dual core device

