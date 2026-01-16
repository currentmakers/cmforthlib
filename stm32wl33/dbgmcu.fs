\
\ @file dbgmcu.fs
\ @brief CR register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_CR_DBG_SLEEP                              \ Allow debug of the CPU in SLEEP mode - 0: Normal operation. All clocks will be disabled automatically in SLEEP mode - 1: Automatic clock stop disabled. All active CPU clocks and oscillators will continue to run during SLEEP mode, allowing full CPU debug capability. On exit from SLEEP mode, the clock settings will be set to the SLEEP mode exit state.
$00000002 constant DBGMCU_CR_DBG_STOP                               \ Allow debug of the CPU in DEEPSTOP mode - 0: Normal operation. All clocks will be disabled automatically in STOP mode - 1: Automatic clock stop disabled. All active CPU clocks and oscillators will continue to run during STOP mode, allowing full CPU debug capability. On exit from STOP mode, the clock settings will be set to the STOP mode exit state.


\
\ @brief DBG_APB0_FZ register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBG_APB0_FZ_DBG_TIM2_STOP                 \ TIM2 stop in the CPU debug - 0: Normal operation. TIM2 continues to operate while the CPU is in debug mode - 1: Stop in debug. TIM2 is frozen while the CPU is in debug mode.
$00000002 constant DBGMCU_DBG_APB0_FZ_DBG_TIM16_STOP                \ TIM16 stop in the CPU debug - 0: Normal operation. TIM16 continues to operate while the CPU is in debug mode - 1: Stop in debug. TIM16 is frozen while the CPU is in debug mode.
$00001000 constant DBGMCU_DBG_APB0_FZ_DBG_RTC_STOP                  \ RTC stop in CPU debug - 0: Normal operation. RTC continues to operate while the CPU is in debug mode - 1: Stop in debug. RTC is frozen while the CPU is in debug mode.
$00004000 constant DBGMCU_DBG_APB0_FZ_DBG_IWDG_STOP                 \ IWDG stop in the CPU debug - 0: Normal operation. IWDG continues to operate while the CPU is in debug mode - 1: Stop in debug. IWDG is frozen while the CPU is in debug mode.


\
\ @brief DBG_APB1_FZ register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00200000 constant DBGMCU_DBG_APB1_FZ_DBG_I2C1_STOP                 \ I2C1 SMBUS timeout stop in CPU debug - 0: Normal operation. I2C1 SMBUS timeout continues to operate while the CPU is in debug mode - 1: Stop in debug. I2C1 SMBUS timeou is frozen while the CPU is in debug mode.
$00800000 constant DBGMCU_DBG_APB1_FZ_DBG_I2C2_STOP                 \ I2C2 SMBUS timeout stop in CPU debug - 0: Normal operation. I2C2 SMBUS timeout continues to operate while the CPU is in debug mode - 1: Stop in debug. I2C2 SMBUS timeou is frozen while the CPU is in debug mode.


\
\ @brief CR register
\
$40008000 constant DBGMCU_CR      \ offset: 0x00 : CR register
$40008004 constant DBGMCU_DBG_APB0_FZ  \ offset: 0x04 : DBG_APB0_FZ register
$40008008 constant DBGMCU_DBG_APB1_FZ  \ offset: 0x08 : DBG_APB1_FZ register

