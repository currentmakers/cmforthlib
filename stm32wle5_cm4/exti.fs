\
\ @file exti.fs
\ @brief External interrupt/event controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] EXTI_DEF

  [ifdef] EXTI_RTSR1_DEF
    \
    \ @brief rising trigger selection register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RT                        \ [0x00 : 17] Rising trigger event configuration bit of Configurable Event input
    $15 constant EXTI_RT21                      \ [0x15 : 2] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_FTSR1_DEF
    \
    \ @brief falling trigger selection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT                        \ [0x00 : 17] Falling trigger event configuration bit of Configurable Event input
    $15 constant EXTI_FT21                      \ [0x15 : 2] Falling trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_SWIER1_DEF
    \
    \ @brief software interrupt event register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI                       \ [0x00 : 17] Software interrupt on event
    $15 constant EXTI_SWI21                     \ [0x15 : 2] Software interrupt on event
  [then]


  [ifdef] EXTI_PR1_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PIF                       \ [0x00 : 17] Configurable event inputs Pending bit
    $15 constant EXTI_PIF21                     \ [0x15 : 2] Configurable event inputs Pending bit
  [then]


  [ifdef] EXTI_RTSR2_DEF
    \
    \ @brief rising trigger selection register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_RT34                      \ [0x02] Rising trigger event configuration bit of Configurable Event input
    $0d constant EXTI_RT45                      \ [0x0d] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_FTSR2_DEF
    \
    \ @brief falling trigger selection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_FT34                      \ [0x02] Falling trigger event configuration bit of Configurable Event input
    $0d constant EXTI_FT45                      \ [0x0d] Falling trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_SWIER2_DEF
    \
    \ @brief software interrupt event register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_SWI34                     \ [0x02] Software interrupt on event
    $0d constant EXTI_SWI45                     \ [0x0d] Software interrupt on event 45
  [then]


  [ifdef] EXTI_PR2_DEF
    \
    \ @brief pending register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_PIF34                     \ [0x02] Configurable event inputs 33 Pending bit.
    $0d constant EXTI_PIF45                     \ [0x0d] Configurable event inputs 45 Pending bit.
  [then]


  [ifdef] EXTI_IMR1_DEF
    \
    \ @brief interrupt mask register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_IM                        \ [0x00 : 32] wakeup with interrupt Mask on event input
  [then]


  [ifdef] EXTI_EMR1_DEF
    \
    \ @brief event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] Wakeup with event generation Mask on Event input
    $01 constant EXTI_EM1                       \ [0x01] Wakeup with event generation Mask on Event input
    $02 constant EXTI_EM2                       \ [0x02] Wakeup with event generation Mask on Event input
    $03 constant EXTI_EM3                       \ [0x03] Wakeup with event generation Mask on Event input
    $04 constant EXTI_EM4                       \ [0x04] Wakeup with event generation Mask on Event input
    $05 constant EXTI_EM5                       \ [0x05] Wakeup with event generation Mask on Event input
    $06 constant EXTI_EM6                       \ [0x06] Wakeup with event generation Mask on Event input
    $07 constant EXTI_EM7                       \ [0x07] Wakeup with event generation Mask on Event input
    $08 constant EXTI_EM8                       \ [0x08] Wakeup with event generation Mask on Event input
    $09 constant EXTI_EM9                       \ [0x09] Wakeup with event generation Mask on Event input
    $0a constant EXTI_EM10                      \ [0x0a] Wakeup with event generation Mask on Event input
    $0b constant EXTI_EM11                      \ [0x0b] Wakeup with event generation Mask on Event input
    $0c constant EXTI_EM12                      \ [0x0c] Wakeup with event generation Mask on Event input
    $0d constant EXTI_EM13                      \ [0x0d] Wakeup with event generation Mask on Event input
    $0e constant EXTI_EM14                      \ [0x0e] Wakeup with event generation Mask on Event input
    $0f constant EXTI_EM15                      \ [0x0f] Wakeup with event generation Mask on Event input
    $11 constant EXTI_EM17                      \ [0x11] Wakeup with event generation Mask on Event input
    $12 constant EXTI_EM18                      \ [0x12] Wakeup with event generation Mask on Event input
    $13 constant EXTI_EM19                      \ [0x13] Wakeup with event generation Mask on Event input
    $14 constant EXTI_EM20                      \ [0x14] Wakeup with event generation Mask on Event input
    $15 constant EXTI_EM21                      \ [0x15] Wakeup with event generation Mask on Event input
    $16 constant EXTI_EM22                      \ [0x16] Wakeup with event generation Mask on Event input
  [then]


  [ifdef] EXTI_IMR2_DEF
    \
    \ @brief interrupt mask register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_IM34                      \ [0x02] CPUm Wakeup with interrupt Mask on Event input
    $06 constant EXTI_IM38                      \ [0x06] CPUm Wakeup with interrupt Mask on Event input
    $0a constant EXTI_IM42                      \ [0x0a : 5] CPUm Wakeup with interrupt Mask on Event input
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_RTSR1               \ rising trigger selection register
  $04 constant EXTI_FTSR1               \ falling trigger selection register
  $08 constant EXTI_SWIER1              \ software interrupt event register
  $0C constant EXTI_PR1                 \ EXTI pending register
  $20 constant EXTI_RTSR2               \ rising trigger selection register
  $24 constant EXTI_FTSR2               \ falling trigger selection register
  $28 constant EXTI_SWIER2              \ software interrupt event register
  $2C constant EXTI_PR2                 \ pending register
  $80 constant EXTI_IMR1                \ interrupt mask register
  $84 constant EXTI_EMR1                \ event mask register
  $90 constant EXTI_IMR2                \ interrupt mask register

: EXTI_DEF ; [then]
