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
\ Reset value: 0x10006480
\

$00000fff constant DBGMCU_IDC_DEV_ID                                \ Device ID
$ffff0000 constant DBGMCU_IDC_REV_ID                                \ Revision


\
\ @brief DBGMCU Configuration Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_CR_DBGSLEEP_CD                            \ Allow D1 domain debug in Sleep mode
$00000002 constant DBGMCU_CR_DBGSTOP_CD                             \ Allow D1 domain debug in Stop mode
$00000004 constant DBGMCU_CR_DBGSTBY_CD                             \ Allow D1 domain debug in Standby mode
$00000080 constant DBGMCU_CR_DBGSTOP_SRD                            \ debug in SmartRun domain Stop mode
$00000100 constant DBGMCU_CR_DBGSTBY_SRD                            \ debug in SmartRun domain Standby mode
$00100000 constant DBGMCU_CR_TRACECLKEN                             \ Trace port clock enable
$00200000 constant DBGMCU_CR_CDDBGCKEN                              \ CPU domain debug clock enable
$00400000 constant DBGMCU_CR_SRDDBGCKEN                             \ SmartRun domain debug clock enable
$10000000 constant DBGMCU_CR_TRGOEN                                 \ External trigger output enable


\
\ @brief DBGMCU APB3 peripheral freeze register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000040 constant DBGMCU_APB3FZ1_WWDG                              \ WWDG stop in debug


\
\ @brief DBGMCU APB1L peripheral freeze register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1LFZ1_TIM2                             \ TIM2 stop in debug
$00000002 constant DBGMCU_APB1LFZ1_TIM3                             \ TIM3 stop in debug
$00000004 constant DBGMCU_APB1LFZ1_TIM4                             \ TIM4 stop in debug
$00000008 constant DBGMCU_APB1LFZ1_TIM5                             \ TIM5 stop in debug
$00000010 constant DBGMCU_APB1LFZ1_TIM6                             \ TIM6 stop in debug
$00000020 constant DBGMCU_APB1LFZ1_TIM7                             \ TIM7 stop in debug
$00000040 constant DBGMCU_APB1LFZ1_TIM12                            \ TIM12 stop in debug
$00000080 constant DBGMCU_APB1LFZ1_TIM13                            \ TIM13 stop in debug
$00000100 constant DBGMCU_APB1LFZ1_TIM14                            \ TIM14 stop in debug
$00000200 constant DBGMCU_APB1LFZ1_LPTIM1                           \ LPTIM1 stop in debug
$00200000 constant DBGMCU_APB1LFZ1_I2C1                             \ I2C1 SMBUS timeout stop in debug
$00400000 constant DBGMCU_APB1LFZ1_I2C2                             \ I2C2 SMBUS timeout stop in debug
$00800000 constant DBGMCU_APB1LFZ1_I2C3                             \ I2C3 SMBUS timeout stop in debug


\
\ @brief DBGMCU APB2 peripheral freeze register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB2FZ1_TIM1                              \ TIM1 stop in debug
$00000002 constant DBGMCU_APB2FZ1_TIM8                              \ TIM8 stop in debug
$00010000 constant DBGMCU_APB2FZ1_TIM15                             \ TIM15 stop in debug
$00020000 constant DBGMCU_APB2FZ1_TIM16                             \ TIM16 stop in debug
$00040000 constant DBGMCU_APB2FZ1_TIM17                             \ TIM17 stop in debug


\
\ @brief DBGMCU APB4 peripheral freeze register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000080 constant DBGMCU_APB4FZ1_I2C4                              \ I2C4 SMBUS timeout stop in debug
$00000200 constant DBGMCU_APB4FZ1_LPTIM2                            \ LPTIM2 stop in debug
$00000400 constant DBGMCU_APB4FZ1_LPTIM3                            \ LPTIM3 stop in debug
$00010000 constant DBGMCU_APB4FZ1_RTC                               \ RTC stop in debug
$00040000 constant DBGMCU_APB4FZ1_WDGLSCD                           \ LS watchdog for CPU domain stop in debug


\
\ @brief Microcontroller Debug Unit
\
$5c001000 constant DBGMCU_IDC     \ offset: 0x00 : DBGMCU Identity Code Register
$5c001004 constant DBGMCU_CR      \ offset: 0x04 : DBGMCU Configuration Register
$5c001034 constant DBGMCU_APB3FZ1  \ offset: 0x34 : DBGMCU APB3 peripheral freeze register
$5c00103c constant DBGMCU_APB1LFZ1  \ offset: 0x3C : DBGMCU APB1L peripheral freeze register
$5c00104c constant DBGMCU_APB2FZ1  \ offset: 0x4C : DBGMCU APB2 peripheral freeze register
$5c001054 constant DBGMCU_APB4FZ1  \ offset: 0x54 : DBGMCU APB4 peripheral freeze register

