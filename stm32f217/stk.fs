\
\ @file stk.fs
\ @brief SysTick timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SysTick control and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant STK_CTRL_ENABLE                                  \ Counter enable
$00000002 constant STK_CTRL_TICKINT                                 \ SysTick exception request enable
$00000004 constant STK_CTRL_CLKSOURCE                               \ Clock source selection
$00010000 constant STK_CTRL_COUNTFLAG                               \ COUNTFLAG


\
\ @brief SysTick reload value register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00ffffff constant STK_LOAD__RELOAD                                 \ RELOAD value


\
\ @brief SysTick current value register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00ffffff constant STK_VAL_CURRENT                                  \ Current counter value


\
\ @brief SysTick calibration value register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00ffffff constant STK_CALIB_TENMS                                  \ Calibration value


\
\ @brief SysTick timer
\
$e000e010 constant STK_CTRL       \ offset: 0x00 : SysTick control and status register
$e000e014 constant STK_LOAD_      \ offset: 0x04 : SysTick reload value register
$e000e018 constant STK_VAL        \ offset: 0x08 : SysTick current value register
$e000e01c constant STK_CALIB      \ offset: 0x0C : SysTick calibration value register

