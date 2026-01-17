\
\ @file stk.fs
\ @brief SysTick timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] STK_DEF

  [ifdef] STK_CTRL_DEF
    \
    \ @brief SysTick control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant STK_ENABLE                     \ [0x00] Counter enable
    $01 constant STK_TICKINT                    \ [0x01] SysTick exception request enable
    $02 constant STK_CLKSOURCE                  \ [0x02] Clock source selection
    $10 constant STK_COUNTFLAG                  \ [0x10] COUNTFLAG
  [then]


  [ifdef] STK_LOAD_DEF
    \
    \ @brief SysTick reload value register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant STK_RELOAD                     \ [0x00 : 24] RELOAD value
  [then]


  [ifdef] STK_VAL_DEF
    \
    \ @brief SysTick current value register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant STK_CURRENT                    \ [0x00 : 24] Current counter value
  [then]


  [ifdef] STK_CALIB_DEF
    \
    \ @brief SysTick calibration value register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant STK_TENMS                      \ [0x00 : 24] Calibration value
    $1e constant STK_SKEW                       \ [0x1e] SKEW flag: Indicates whether the TENMS value is exact
    $1f constant STK_NOREF                      \ [0x1f] NOREF flag. Reads as zero
  [then]

  \
  \ @brief SysTick timer
  \
  $00 constant STK_CTRL                 \ SysTick control and status register
  $04 constant STK_LOAD                 \ SysTick reload value register
  $08 constant STK_VAL                  \ SysTick current value register
  $0C constant STK_CALIB                \ SysTick calibration value register

: STK_DEF ; [then]
