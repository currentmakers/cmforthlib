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
\ Reset value: 0x10006450
\

$00000fff constant DBGMCU_IDC_DEV_ID                                \ Device ID
$ffff0000 constant DBGMCU_IDC_REV_ID                                \ Revision


\
\ @brief DBGMCU Configuration Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_CR_DBGSLPD1                               \ Allow D1 domain debug in Sleep mode
$00000002 constant DBGMCU_CR_DBGSTPD1                               \ Allow D1 domain debug in Stop mode
$00000004 constant DBGMCU_CR_DBGSTBD1                               \ Allow D1 domain debug in Standby mode
$00000008 constant DBGMCU_CR_DBGSLPD2                               \ Allow D2 domain debug in Sleep mode
$00000010 constant DBGMCU_CR_DBGSTPD2                               \ Allow D2 domain debug in Stop mode
$00000020 constant DBGMCU_CR_DBGSTBD2                               \ Allow D2 domain debug in Standby mode
$00000080 constant DBGMCU_CR_DBGSTPD3                               \ Allow debug in D3 Stop mode
$00000100 constant DBGMCU_CR_DBGSTBD3                               \ Allow debug in D3 Standby mode
$00100000 constant DBGMCU_CR_TRACECLKEN                             \ Trace port clock enable
$00200000 constant DBGMCU_CR_D1DBGCKEN                              \ D1 debug clock enable
$00400000 constant DBGMCU_CR_D3DBGCKEN                              \ D3 debug clock enable
$10000000 constant DBGMCU_CR_TRGOEN                                 \ External trigger output enable


\
\ @brief DBGMCU APB3 peripheral freeze register CPU1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000040 constant DBGMCU_APB3FZ1_WWDG1                             \ WWDG1 stop in debug


\
\ @brief DBGMCU APB3 peripheral freeze register CPU2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000040 constant DBGMCU_APB3FZ2_WWDG1                             \ WWDG1 stop in debug


\
\ @brief DBGMCU APB1L peripheral freeze register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1LFZ1_DBG_TIM2                         \ TIM2 stop in debug
$00000002 constant DBGMCU_APB1LFZ1_DBG_TIM3                         \ TIM3 stop in debug
$00000004 constant DBGMCU_APB1LFZ1_DBG_TIM4                         \ TIM4 stop in debug
$00000008 constant DBGMCU_APB1LFZ1_DBG_TIM5                         \ TIM5 stop in debug
$00000010 constant DBGMCU_APB1LFZ1_DBG_TIM6                         \ TIM6 stop in debug
$00000020 constant DBGMCU_APB1LFZ1_DBG_TIM7                         \ TIM7 stop in debug
$00000040 constant DBGMCU_APB1LFZ1_DBG_TIM12                        \ TIM12 stop in debug
$00000080 constant DBGMCU_APB1LFZ1_DBG_TIM13                        \ TIM13 stop in debug
$00000100 constant DBGMCU_APB1LFZ1_DBG_TIM14                        \ TIM14 stop in debug
$00000200 constant DBGMCU_APB1LFZ1_DBG_LPTIM1                       \ LPTIM1 stop in debug
$00000800 constant DBGMCU_APB1LFZ1_DBG_WWDG2                        \ WWDG2 stop in debug
$00200000 constant DBGMCU_APB1LFZ1_DBG_I2C1                         \ I2C1 SMBUS timeout stop in debug
$00400000 constant DBGMCU_APB1LFZ1_DBG_I2C2                         \ I2C2 SMBUS timeout stop in debug
$00800000 constant DBGMCU_APB1LFZ1_DBG_I2C3                         \ I2C3 SMBUS timeout stop in debug


\
\ @brief DBGMCU APB1L peripheral freeze register CPU2
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB1LFZ2_DBG_TIM2                         \ TIM2 stop in debug
$00000002 constant DBGMCU_APB1LFZ2_DBG_TIM3                         \ TIM3 stop in debug
$00000004 constant DBGMCU_APB1LFZ2_DBG_TIM4                         \ TIM4 stop in debug
$00000008 constant DBGMCU_APB1LFZ2_DBG_TIM5                         \ TIM5 stop in debug
$00000010 constant DBGMCU_APB1LFZ2_DBG_TIM6                         \ TIM6 stop in debug
$00000020 constant DBGMCU_APB1LFZ2_DBG_TIM7                         \ TIM4 stop in debug
$00000040 constant DBGMCU_APB1LFZ2_DBG_TIM12                        \ TIM12 stop in debug
$00000080 constant DBGMCU_APB1LFZ2_DBG_TIM13                        \ TIM13 stop in debug
$00000100 constant DBGMCU_APB1LFZ2_DBG_TIM14                        \ TIM14 stop in debug
$00000200 constant DBGMCU_APB1LFZ2_DBG_LPTIM1                       \ LPTIM1 stop in debug
$00000800 constant DBGMCU_APB1LFZ2_DBG_WWDG2                        \ WWDG2 stop in debug
$00200000 constant DBGMCU_APB1LFZ2_DBG_I2C1                         \ I2C1 SMBUS timeout stop in debug
$00400000 constant DBGMCU_APB1LFZ2_DBG_I2C2                         \ I2C2 SMBUS timeout stop in debug
$00800000 constant DBGMCU_APB1LFZ2_DBG_I2C3                         \ I2C3 SMBUS timeout stop in debug


\
\ @brief DBGMCU APB2 peripheral freeze register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB2FZ1_DBG_TIM1                          \ TIM1 stop in debug
$00000002 constant DBGMCU_APB2FZ1_DBG_TIM8                          \ TIM8 stop in debug
$00010000 constant DBGMCU_APB2FZ1_DBG_TIM15                         \ TIM15 stop in debug
$00020000 constant DBGMCU_APB2FZ1_DBG_TIM16                         \ TIM16 stop in debug
$00040000 constant DBGMCU_APB2FZ1_DBG_TIM17                         \ TIM17 stop in debug
$20000000 constant DBGMCU_APB2FZ1_DBG_HRTIM                         \ HRTIM stop in debug


\
\ @brief DBGMCU APB2 peripheral freeze register CPU2
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_APB2FZ2_DBG_TIM1                          \ TIM1 stop in debug
$00000002 constant DBGMCU_APB2FZ2_DBG_TIM8                          \ TIM8 stop in debug
$00010000 constant DBGMCU_APB2FZ2_DBG_TIM15                         \ TIM15 stop in debug
$00020000 constant DBGMCU_APB2FZ2_DBG_TIM16                         \ TIM16 stop in debug
$00040000 constant DBGMCU_APB2FZ2_DBG_TIM17                         \ TIM17 stop in debug
$20000000 constant DBGMCU_APB2FZ2_DBG_HRTIM                         \ HRTIM stop in debug


\
\ @brief DBGMCU APB4 peripheral freeze register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000080 constant DBGMCU_APB4FZ1_DBG_I2C4                          \ I2C4 SMBUS timeout stop in debug
$00000200 constant DBGMCU_APB4FZ1_DBG_LPTIM2                        \ LPTIM2 stop in debug
$00000400 constant DBGMCU_APB4FZ1_DBG_LPTIM3                        \ LPTIM2 stop in debug
$00000800 constant DBGMCU_APB4FZ1_DBG_LPTIM4                        \ LPTIM4 stop in debug
$00001000 constant DBGMCU_APB4FZ1_DBG_LPTIM5                        \ LPTIM5 stop in debug
$00010000 constant DBGMCU_APB4FZ1_DBG_RTC                           \ RTC stop in debug
$00040000 constant DBGMCU_APB4FZ1_DBG_WDGLSD1                       \ Independent watchdog for D1 stop in debug
$00080000 constant DBGMCU_APB4FZ1_DBG_WDGLSD2                       \ Independent watchdog for D2 stop in debug


\
\ @brief DBGMCU APB4 peripheral freeze register CPU2
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000080 constant DBGMCU_APB4FZ2_DBG_I2C4                          \ I2C4 SMBUS timeout stop in debug
$00000200 constant DBGMCU_APB4FZ2_DBG_LPTIM2                        \ LPTIM2 stop in debug
$00000400 constant DBGMCU_APB4FZ2_DBG_LPTIM3                        \ LPTIM2 stop in debug
$00000800 constant DBGMCU_APB4FZ2_DBG_LPTIM4                        \ LPTIM4 stop in debug
$00001000 constant DBGMCU_APB4FZ2_DBG_LPTIM5                        \ LPTIM5 stop in debug
$00010000 constant DBGMCU_APB4FZ2_DBG_RTC                           \ RTC stop in debug
$00040000 constant DBGMCU_APB4FZ2_DBG_WDGLSD1                       \ LS watchdog for D1 stop in debug
$00080000 constant DBGMCU_APB4FZ2_DBG_WDGLSD2                       \ LS watchdog for D2 stop in debug


\
\ @brief Microcontroller Debug Unit
\
$5c001000 constant DBGMCU_IDC     \ offset: 0x00 : DBGMCU Identity Code Register
$5c001004 constant DBGMCU_CR      \ offset: 0x04 : DBGMCU Configuration Register
$5c001034 constant DBGMCU_APB3FZ1  \ offset: 0x34 : DBGMCU APB3 peripheral freeze register CPU1
$5c001038 constant DBGMCU_APB3FZ2  \ offset: 0x38 : DBGMCU APB3 peripheral freeze register CPU2
$5c00103c constant DBGMCU_APB1LFZ1  \ offset: 0x3C : DBGMCU APB1L peripheral freeze register
$5c001040 constant DBGMCU_APB1LFZ2  \ offset: 0x40 : DBGMCU APB1L peripheral freeze register CPU2
$5c00104c constant DBGMCU_APB2FZ1  \ offset: 0x4C : DBGMCU APB2 peripheral freeze register
$5c001050 constant DBGMCU_APB2FZ2  \ offset: 0x50 : DBGMCU APB2 peripheral freeze register CPU2
$5c001054 constant DBGMCU_APB4FZ1  \ offset: 0x54 : DBGMCU APB4 peripheral freeze register
$5c001058 constant DBGMCU_APB4FZ2  \ offset: 0x58 : DBGMCU APB4 peripheral freeze register CPU2

