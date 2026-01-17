\
\ @file exti.fs
\ @brief External interrupt/event controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] EXTI_DEF

  [ifdef] EXTI_IMR_DEF
    \
    \ @brief Interrupt mask register (EXTI_IMR)
    \ Address offset: 0x00
    \ Reset value: 0xFF840000
    \
    $00 constant EXTI_IM0                       \ [0x00] Interrupt Mask on line 0
    $01 constant EXTI_IM1                       \ [0x01] Interrupt Mask on line 1
    $02 constant EXTI_IM2                       \ [0x02] Interrupt Mask on line 2
    $03 constant EXTI_IM3                       \ [0x03] Interrupt Mask on line 3
    $04 constant EXTI_IM4                       \ [0x04] Interrupt Mask on line 4
    $05 constant EXTI_IM5                       \ [0x05] Interrupt Mask on line 5
    $06 constant EXTI_IM6                       \ [0x06] Interrupt Mask on line 6
    $07 constant EXTI_IM7                       \ [0x07] Interrupt Mask on line 7
    $08 constant EXTI_IM8                       \ [0x08] Interrupt Mask on line 8
    $09 constant EXTI_IM9                       \ [0x09] Interrupt Mask on line 9
    $0a constant EXTI_IM10                      \ [0x0a] Interrupt Mask on line 10
    $0b constant EXTI_IM11                      \ [0x0b] Interrupt Mask on line 11
    $0c constant EXTI_IM12                      \ [0x0c] Interrupt Mask on line 12
    $0d constant EXTI_IM13                      \ [0x0d] Interrupt Mask on line 13
    $0e constant EXTI_IM14                      \ [0x0e] Interrupt Mask on line 14
    $0f constant EXTI_IM15                      \ [0x0f] Interrupt Mask on line 15
    $10 constant EXTI_IM16                      \ [0x10] Interrupt Mask on line 16
    $11 constant EXTI_IM17                      \ [0x11] Interrupt Mask on line 17
    $12 constant EXTI_IM18                      \ [0x12] Interrupt Mask on line 18
    $13 constant EXTI_IM19                      \ [0x13] Interrupt Mask on line 19
    $14 constant EXTI_IM20                      \ [0x14] Interrupt Mask on line 20
    $15 constant EXTI_IM21                      \ [0x15] Interrupt Mask on line 21
    $16 constant EXTI_IM22                      \ [0x16] Interrupt Mask on line 22
    $17 constant EXTI_IM23                      \ [0x17] Interrupt Mask on line 23
    $18 constant EXTI_IM24                      \ [0x18] Interrupt Mask on line 24
    $19 constant EXTI_IM25                      \ [0x19] Interrupt Mask on line 25
    $1a constant EXTI_IM26                      \ [0x1a] Interrupt Mask on line 27
    $1c constant EXTI_IM28                      \ [0x1c] Interrupt Mask on line 27
    $1d constant EXTI_IM29                      \ [0x1d] Interrupt Mask on line 27
  [then]


  [ifdef] EXTI_EMR_DEF
    \
    \ @brief Event mask register (EXTI_EMR)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] Event Mask on line 0
    $01 constant EXTI_EM1                       \ [0x01] Event Mask on line 1
    $02 constant EXTI_EM2                       \ [0x02] Event Mask on line 2
    $03 constant EXTI_EM3                       \ [0x03] Event Mask on line 3
    $04 constant EXTI_EM4                       \ [0x04] Event Mask on line 4
    $05 constant EXTI_EM5                       \ [0x05] Event Mask on line 5
    $06 constant EXTI_EM6                       \ [0x06] Event Mask on line 6
    $07 constant EXTI_EM7                       \ [0x07] Event Mask on line 7
    $08 constant EXTI_EM8                       \ [0x08] Event Mask on line 8
    $09 constant EXTI_EM9                       \ [0x09] Event Mask on line 9
    $0a constant EXTI_EM10                      \ [0x0a] Event Mask on line 10
    $0b constant EXTI_EM11                      \ [0x0b] Event Mask on line 11
    $0c constant EXTI_EM12                      \ [0x0c] Event Mask on line 12
    $0d constant EXTI_EM13                      \ [0x0d] Event Mask on line 13
    $0e constant EXTI_EM14                      \ [0x0e] Event Mask on line 14
    $0f constant EXTI_EM15                      \ [0x0f] Event Mask on line 15
    $10 constant EXTI_EM16                      \ [0x10] Event Mask on line 16
    $11 constant EXTI_EM17                      \ [0x11] Event Mask on line 17
    $12 constant EXTI_EM18                      \ [0x12] Event Mask on line 18
    $13 constant EXTI_EM19                      \ [0x13] Event Mask on line 19
    $14 constant EXTI_EM20                      \ [0x14] Event Mask on line 20
    $15 constant EXTI_EM21                      \ [0x15] Event Mask on line 21
    $16 constant EXTI_EM22                      \ [0x16] Event Mask on line 22
    $17 constant EXTI_EM23                      \ [0x17] Event Mask on line 23
    $18 constant EXTI_EM24                      \ [0x18] Event Mask on line 24
    $19 constant EXTI_EM25                      \ [0x19] Event Mask on line 25
    $1a constant EXTI_EM26                      \ [0x1a] Event Mask on line 26
    $1c constant EXTI_EM28                      \ [0x1c] Event Mask on line 28
    $1d constant EXTI_EM29                      \ [0x1d] Event Mask on line 29
  [then]


  [ifdef] EXTI_RTSR_DEF
    \
    \ @brief Rising Trigger selection register (EXTI_RTSR)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RT0                       \ [0x00] Rising trigger event configuration of line 0
    $01 constant EXTI_RT1                       \ [0x01] Rising trigger event configuration of line 1
    $02 constant EXTI_RT2                       \ [0x02] Rising trigger event configuration of line 2
    $03 constant EXTI_RT3                       \ [0x03] Rising trigger event configuration of line 3
    $04 constant EXTI_RT4                       \ [0x04] Rising trigger event configuration of line 4
    $05 constant EXTI_RT5                       \ [0x05] Rising trigger event configuration of line 5
    $06 constant EXTI_RT6                       \ [0x06] Rising trigger event configuration of line 6
    $07 constant EXTI_RT7                       \ [0x07] Rising trigger event configuration of line 7
    $08 constant EXTI_RT8                       \ [0x08] Rising trigger event configuration of line 8
    $09 constant EXTI_RT9                       \ [0x09] Rising trigger event configuration of line 9
    $0a constant EXTI_RT10                      \ [0x0a] Rising trigger event configuration of line 10
    $0b constant EXTI_RT11                      \ [0x0b] Rising trigger event configuration of line 11
    $0c constant EXTI_RT12                      \ [0x0c] Rising trigger event configuration of line 12
    $0d constant EXTI_RT13                      \ [0x0d] Rising trigger event configuration of line 13
    $0e constant EXTI_RT14                      \ [0x0e] Rising trigger event configuration of line 14
    $0f constant EXTI_RT15                      \ [0x0f] Rising trigger event configuration of line 15
    $10 constant EXTI_RT16                      \ [0x10] Rising trigger event configuration of line 16
    $11 constant EXTI_RT17                      \ [0x11] Rising trigger event configuration of line 17
    $13 constant EXTI_RT19                      \ [0x13] Rising trigger event configuration of line 19
    $14 constant EXTI_RT20                      \ [0x14] Rising trigger event configuration of line 20
    $15 constant EXTI_RT21                      \ [0x15] Rising trigger event configuration of line 21
    $16 constant EXTI_RT22                      \ [0x16] Rising trigger event configuration of line 22
  [then]


  [ifdef] EXTI_FTSR_DEF
    \
    \ @brief Falling Trigger selection register (EXTI_FTSR)
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT0                       \ [0x00] Falling trigger event configuration of line 0
    $01 constant EXTI_FT1                       \ [0x01] Falling trigger event configuration of line 1
    $02 constant EXTI_FT2                       \ [0x02] Falling trigger event configuration of line 2
    $03 constant EXTI_FT3                       \ [0x03] Falling trigger event configuration of line 3
    $04 constant EXTI_FT4                       \ [0x04] Falling trigger event configuration of line 4
    $05 constant EXTI_FT5                       \ [0x05] Falling trigger event configuration of line 5
    $06 constant EXTI_FT6                       \ [0x06] Falling trigger event configuration of line 6
    $07 constant EXTI_FT7                       \ [0x07] Falling trigger event configuration of line 7
    $08 constant EXTI_FT8                       \ [0x08] Falling trigger event configuration of line 8
    $09 constant EXTI_FT9                       \ [0x09] Falling trigger event configuration of line 9
    $0a constant EXTI_FT10                      \ [0x0a] Falling trigger event configuration of line 10
    $0b constant EXTI_FT11                      \ [0x0b] Falling trigger event configuration of line 11
    $0c constant EXTI_FT12                      \ [0x0c] Falling trigger event configuration of line 12
    $0d constant EXTI_FT13                      \ [0x0d] Falling trigger event configuration of line 13
    $0e constant EXTI_FT14                      \ [0x0e] Falling trigger event configuration of line 14
    $0f constant EXTI_FT15                      \ [0x0f] Falling trigger event configuration of line 15
    $10 constant EXTI_FT16                      \ [0x10] Falling trigger event configuration of line 16
    $11 constant EXTI_FT17                      \ [0x11] Falling trigger event configuration of line 17
    $13 constant EXTI_FT19                      \ [0x13] Falling trigger event configuration of line 19
    $14 constant EXTI_FT20                      \ [0x14] Falling trigger event configuration of line 20
    $15 constant EXTI_FT21                      \ [0x15] Falling trigger event configuration of line 21
    $16 constant EXTI_FT22                      \ [0x16] Falling trigger event configuration of line 22
  [then]


  [ifdef] EXTI_SWIER_DEF
    \
    \ @brief Software interrupt event register (EXTI_SWIER)
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI0                      \ [0x00] Software Interrupt on line 0
    $01 constant EXTI_SWI1                      \ [0x01] Software Interrupt on line 1
    $02 constant EXTI_SWI2                      \ [0x02] Software Interrupt on line 2
    $03 constant EXTI_SWI3                      \ [0x03] Software Interrupt on line 3
    $04 constant EXTI_SWI4                      \ [0x04] Software Interrupt on line 4
    $05 constant EXTI_SWI5                      \ [0x05] Software Interrupt on line 5
    $06 constant EXTI_SWI6                      \ [0x06] Software Interrupt on line 6
    $07 constant EXTI_SWI7                      \ [0x07] Software Interrupt on line 7
    $08 constant EXTI_SWI8                      \ [0x08] Software Interrupt on line 8
    $09 constant EXTI_SWI9                      \ [0x09] Software Interrupt on line 9
    $0a constant EXTI_SWI10                     \ [0x0a] Software Interrupt on line 10
    $0b constant EXTI_SWI11                     \ [0x0b] Software Interrupt on line 11
    $0c constant EXTI_SWI12                     \ [0x0c] Software Interrupt on line 12
    $0d constant EXTI_SWI13                     \ [0x0d] Software Interrupt on line 13
    $0e constant EXTI_SWI14                     \ [0x0e] Software Interrupt on line 14
    $0f constant EXTI_SWI15                     \ [0x0f] Software Interrupt on line 15
    $10 constant EXTI_SWI16                     \ [0x10] Software Interrupt on line 16
    $11 constant EXTI_SWI17                     \ [0x11] Software Interrupt on line 17
    $13 constant EXTI_SWI19                     \ [0x13] Software Interrupt on line 19
    $14 constant EXTI_SWI20                     \ [0x14] Software Interrupt on line 20
    $15 constant EXTI_SWI21                     \ [0x15] Software Interrupt on line 21
    $16 constant EXTI_SWI22                     \ [0x16] Software Interrupt on line 22
  [then]


  [ifdef] EXTI_PR_DEF
    \
    \ @brief Pending register (EXTI_PR)
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PIF0                      \ [0x00] Pending bit 0
    $01 constant EXTI_PIF1                      \ [0x01] Pending bit 1
    $02 constant EXTI_PIF2                      \ [0x02] Pending bit 2
    $03 constant EXTI_PIF3                      \ [0x03] Pending bit 3
    $04 constant EXTI_PIF4                      \ [0x04] Pending bit 4
    $05 constant EXTI_PIF5                      \ [0x05] Pending bit 5
    $06 constant EXTI_PIF6                      \ [0x06] Pending bit 6
    $07 constant EXTI_PIF7                      \ [0x07] Pending bit 7
    $08 constant EXTI_PIF8                      \ [0x08] Pending bit 8
    $09 constant EXTI_PIF9                      \ [0x09] Pending bit 9
    $0a constant EXTI_PIF10                     \ [0x0a] Pending bit 10
    $0b constant EXTI_PIF11                     \ [0x0b] Pending bit 11
    $0c constant EXTI_PIF12                     \ [0x0c] Pending bit 12
    $0d constant EXTI_PIF13                     \ [0x0d] Pending bit 13
    $0e constant EXTI_PIF14                     \ [0x0e] Pending bit 14
    $0f constant EXTI_PIF15                     \ [0x0f] Pending bit 15
    $10 constant EXTI_PIF16                     \ [0x10] Pending bit 16
    $11 constant EXTI_PIF17                     \ [0x11] Pending bit 17
    $13 constant EXTI_PIF19                     \ [0x13] Pending bit 19
    $14 constant EXTI_PIF20                     \ [0x14] Pending bit 20
    $15 constant EXTI_PIF21                     \ [0x15] Pending bit 21
    $16 constant EXTI_PIF22                     \ [0x16] Pending bit 22
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_IMR                 \ Interrupt mask register (EXTI_IMR)
  $04 constant EXTI_EMR                 \ Event mask register (EXTI_EMR)
  $08 constant EXTI_RTSR                \ Rising Trigger selection register (EXTI_RTSR)
  $0C constant EXTI_FTSR                \ Falling Trigger selection register (EXTI_FTSR)
  $10 constant EXTI_SWIER               \ Software interrupt event register (EXTI_SWIER)
  $14 constant EXTI_PR                  \ Pending register (EXTI_PR)

: EXTI_DEF ; [then]
