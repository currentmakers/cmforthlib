\
\ @file dbgmcu.fs
\ @brief Debug support
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_IDCODE_DEF
    \
    \ @brief MCU Device ID Code Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device Identifier
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision Identifier
  [then]


  [ifdef] DBGMCU_CR_DEF
    \
    \ @brief Debug MCU Configuration Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_SLEEP               \ [0x00] Debug Sleep Mode
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Debug Stop Mode
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Debug Standby Mode
  [then]


  [ifdef] DBGMCU_APB1_FZ_DEF
    \
    \ @brief APB Low Freeze Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIMER2_STOP         \ [0x00] Debug Timer 2 stopped when Core is halted
    $04 constant DBGMCU_DBG_TIMER6_STOP         \ [0x04] Debug Timer 6 stopped when Core is halted
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] Debug RTC stopped when Core is halted
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] Debug Window Wachdog stopped when Core is halted
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] Debug Independent Wachdog stopped when Core is halted
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout mode stopped when core is halted
    $16 constant DBGMCU_DBG_I2C2_STOP           \ [0x16] I2C2 SMBUS timeout mode stopped when core is halted
    $1f constant DBGMCU_DBG_LPTIMER_STOP        \ [0x1f] LPTIM1 counter stopped when core is halted
  [then]


  [ifdef] DBGMCU_APB2_FZ_DEF
    \
    \ @brief APB High Freeze Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $02 constant DBGMCU_DBG_TIMER21_STOP        \ [0x02] Debug Timer 21 stopped when Core is halted
    $06 constant DBGMCU_DBG_TIMER22_STO         \ [0x06] Debug Timer 22 stopped when Core is halted
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBGMCU_IDCODE            \ MCU Device ID Code Register
  $04 constant DBGMCU_CR                \ Debug MCU Configuration Register
  $08 constant DBGMCU_APB1_FZ           \ APB Low Freeze Register
  $0C constant DBGMCU_APB2_FZ           \ APB High Freeze Register

: DBGMCU_DEF ; [then]
