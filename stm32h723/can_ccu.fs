\
\ @file can_ccu.fs
\ @brief CCU registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Clock Calibration Unit Core Release Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000000ff constant CAN_CCU_CREL_DAY                                 \ Time Stamp Day
$0000ff00 constant CAN_CCU_CREL_MON                                 \ Time Stamp Month
$000f0000 constant CAN_CCU_CREL_YEAR                                \ Time Stamp Year
$00f00000 constant CAN_CCU_CREL_SUBSTEP                             \ Sub-step of Core Release
$0f000000 constant CAN_CCU_CREL_STEP                                \ Step of Core Release
$f0000000 constant CAN_CCU_CREL_REL                                 \ Core Release


\
\ @brief Calibration Configuration Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant CAN_CCU_CCFG_TQBT                                \ Time Quanta per Bit Time
$00000040 constant CAN_CCU_CCFG_BCC                                 \ Bypass Clock Calibration
$00000080 constant CAN_CCU_CCFG_CFL                                 \ Calibration Field Length
$0000ff00 constant CAN_CCU_CCFG_OCPM                                \ Oscillator Clock Periods Minimum
$000f0000 constant CAN_CCU_CCFG_CDIV                                \ Clock Divider
$80000000 constant CAN_CCU_CCFG_SWR                                 \ Software Reset


\
\ @brief Calibration Status Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0003ffff constant CAN_CCU_CSTAT_OCPC                               \ Oscillator Clock Period Counter
$1ffc0000 constant CAN_CCU_CSTAT_TQC                                \ Time Quanta Counter
$c0000000 constant CAN_CCU_CSTAT_CALS                               \ Calibration State


\
\ @brief Calibration Watchdog Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant CAN_CCU_CWD_WDC                                  \ WDC
$ffff0000 constant CAN_CCU_CWD_WDV                                  \ WDV


\
\ @brief Clock Calibration Unit Interrupt Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CAN_CCU_IR_CWE                                   \ Calibration Watchdog Event
$00000002 constant CAN_CCU_IR_CSC                                   \ Calibration State Changed


\
\ @brief Clock Calibration Unit Interrupt Enable Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CAN_CCU_IE_CWEE                                  \ Calibration Watchdog Event Enable
$00000002 constant CAN_CCU_IE_CSCE                                  \ Calibration State Changed Enable


\
\ @brief CCU registers
\
$4000a800 constant CAN_CCU_CREL   \ offset: 0x00 : Clock Calibration Unit Core Release Register
$4000a804 constant CAN_CCU_CCFG   \ offset: 0x04 : Calibration Configuration Register
$4000a808 constant CAN_CCU_CSTAT  \ offset: 0x08 : Calibration Status Register
$4000a80c constant CAN_CCU_CWD    \ offset: 0x0C : Calibration Watchdog Register
$4000a810 constant CAN_CCU_IR     \ offset: 0x10 : Clock Calibration Unit Interrupt Register
$4000a814 constant CAN_CCU_IE     \ offset: 0x14 : Clock Calibration Unit Interrupt Enable Register

