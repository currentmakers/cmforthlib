\
\ @file dbgmcu.fs
\ @brief CR register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_CR_DEF
    \
    \ @brief CR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_SLEEP               \ [0x00] Allow debug of the CPU in SLEEP mode - 0: Normal operation. All clocks will be disabled automatically in SLEEP mode - 1: Automatic clock stop disabled. All active CPU clocks and oscillators will continue to run during SLEEP mode, allowing full CPU debug capability. On exit from SLEEP mode, the clock settings will be set to the SLEEP mode exit state.
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Allow debug of the CPU in DEEPSTOP mode - 0: Normal operation. All clocks will be disabled automatically in STOP mode - 1: Automatic clock stop disabled. All active CPU clocks and oscillators will continue to run during STOP mode, allowing full CPU debug capability. On exit from STOP mode, the clock settings will be set to the STOP mode exit state.
  [then]


  [ifdef] DBGMCU_DBG_APB0_FZ_DEF
    \
    \ @brief DBG_APB0_FZ register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 stop in the CPU debug - 0: Normal operation. TIM2 continues to operate while the CPU is in debug mode - 1: Stop in debug. TIM2 is frozen while the CPU is in debug mode.
    $01 constant DBGMCU_DBG_TIM16_STOP          \ [0x01] TIM16 stop in the CPU debug - 0: Normal operation. TIM16 continues to operate while the CPU is in debug mode - 1: Stop in debug. TIM16 is frozen while the CPU is in debug mode.
    $0c constant DBGMCU_DBG_RTC_STOP            \ [0x0c] RTC stop in CPU debug - 0: Normal operation. RTC continues to operate while the CPU is in debug mode - 1: Stop in debug. RTC is frozen while the CPU is in debug mode.
    $0e constant DBGMCU_DBG_IWDG_STOP           \ [0x0e] IWDG stop in the CPU debug - 0: Normal operation. IWDG continues to operate while the CPU is in debug mode - 1: Stop in debug. IWDG is frozen while the CPU is in debug mode.
  [then]


  [ifdef] DBGMCU_DBG_APB1_FZ_DEF
    \
    \ @brief DBG_APB1_FZ register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout stop in CPU debug - 0: Normal operation. I2C1 SMBUS timeout continues to operate while the CPU is in debug mode - 1: Stop in debug. I2C1 SMBUS timeou is frozen while the CPU is in debug mode.
    $17 constant DBGMCU_DBG_I2C2_STOP           \ [0x17] I2C2 SMBUS timeout stop in CPU debug - 0: Normal operation. I2C2 SMBUS timeout continues to operate while the CPU is in debug mode - 1: Stop in debug. I2C2 SMBUS timeou is frozen while the CPU is in debug mode.
  [then]

  \
  \ @brief CR register
  \
  $00 constant DBGMCU_CR                \ CR register
  $04 constant DBGMCU_DBG_APB0_FZ       \ DBG_APB0_FZ register
  $08 constant DBGMCU_DBG_APB1_FZ       \ DBG_APB1_FZ register

: DBGMCU_DEF ; [then]
