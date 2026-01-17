\
\ @file can_ccu.fs
\ @brief CCU registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CAN_CCU_DEF

  [ifdef] CAN_CCU_CREL_DEF
    \
    \ @brief Clock Calibration Unit Core Release Register
    \ Address offset: 0x00
    \ Reset value: 0x11141218
    \
    $00 constant CAN_CCU_DAY                    \ [0x00 : 8] Time Stamp Day
    $08 constant CAN_CCU_MON                    \ [0x08 : 8] Time Stamp Month
    $10 constant CAN_CCU_YEAR                   \ [0x10 : 4] Time Stamp Year
    $14 constant CAN_CCU_SUBSTEP                \ [0x14 : 4] Sub-step of Core Release
    $18 constant CAN_CCU_STEP                   \ [0x18 : 4] Step of Core Release
    $1c constant CAN_CCU_REL                    \ [0x1c : 4] Core Release
  [then]


  [ifdef] CAN_CCU_CCFG_DEF
    \
    \ @brief Calibration Configuration Register
    \ Address offset: 0x04
    \ Reset value: 0x00000004
    \
    $00 constant CAN_CCU_TQBT                   \ [0x00 : 5] Time Quanta per Bit Time
    $06 constant CAN_CCU_BCC                    \ [0x06] Bypass Clock Calibration
    $07 constant CAN_CCU_CFL                    \ [0x07] Calibration Field Length
    $08 constant CAN_CCU_OCPM                   \ [0x08 : 8] Oscillator Clock Periods Minimum
    $10 constant CAN_CCU_CDIV                   \ [0x10 : 4] Clock Divider
    $1f constant CAN_CCU_SWR                    \ [0x1f] Software Reset
  [then]


  [ifdef] CAN_CCU_CSTAT_DEF
    \
    \ @brief Calibration Status Register
    \ Address offset: 0x08
    \ Reset value: 0x0203FFFF
    \
    $00 constant CAN_CCU_OCPC                   \ [0x00 : 18] Oscillator Clock Period Counter
    $12 constant CAN_CCU_TQC                    \ [0x12 : 11] Time Quanta Counter
    $1e constant CAN_CCU_CALS                   \ [0x1e : 2] Calibration State
  [then]


  [ifdef] CAN_CCU_CWD_DEF
    \
    \ @brief Calibration Watchdog Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CAN_CCU_WDC                    \ [0x00 : 16] WDC
    $10 constant CAN_CCU_WDV                    \ [0x10 : 16] WDV
  [then]


  [ifdef] CAN_CCU_IR_DEF
    \
    \ @brief Clock Calibration Unit Interrupt Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CAN_CCU_CWE                    \ [0x00] Calibration Watchdog Event
    $01 constant CAN_CCU_CSC                    \ [0x01] Calibration State Changed
  [then]


  [ifdef] CAN_CCU_IE_DEF
    \
    \ @brief Clock Calibration Unit Interrupt Enable Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CAN_CCU_CWEE                   \ [0x00] Calibration Watchdog Event Enable
    $01 constant CAN_CCU_CSCE                   \ [0x01] Calibration State Changed Enable
  [then]

  \
  \ @brief CCU registers
  \
  $00 constant CAN_CCU_CREL             \ Clock Calibration Unit Core Release Register
  $04 constant CAN_CCU_CCFG             \ Calibration Configuration Register
  $08 constant CAN_CCU_CSTAT            \ Calibration Status Register
  $0C constant CAN_CCU_CWD              \ Calibration Watchdog Register
  $10 constant CAN_CCU_IR               \ Clock Calibration Unit Interrupt Register
  $14 constant CAN_CCU_IE               \ Clock Calibration Unit Interrupt Enable Register

: CAN_CCU_DEF ; [then]
