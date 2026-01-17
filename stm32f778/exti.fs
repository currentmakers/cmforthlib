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
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR0                       \ [0x00] Interrupt Mask on line 0
    $01 constant EXTI_MR1                       \ [0x01] Interrupt Mask on line 1
    $02 constant EXTI_MR2                       \ [0x02] Interrupt Mask on line 2
    $03 constant EXTI_MR3                       \ [0x03] Interrupt Mask on line 3
    $04 constant EXTI_MR4                       \ [0x04] Interrupt Mask on line 4
    $05 constant EXTI_MR5                       \ [0x05] Interrupt Mask on line 5
    $06 constant EXTI_MR6                       \ [0x06] Interrupt Mask on line 6
    $07 constant EXTI_MR7                       \ [0x07] Interrupt Mask on line 7
    $08 constant EXTI_MR8                       \ [0x08] Interrupt Mask on line 8
    $09 constant EXTI_MR9                       \ [0x09] Interrupt Mask on line 9
    $0a constant EXTI_MR10                      \ [0x0a] Interrupt Mask on line 10
    $0b constant EXTI_MR11                      \ [0x0b] Interrupt Mask on line 11
    $0c constant EXTI_MR12                      \ [0x0c] Interrupt Mask on line 12
    $0d constant EXTI_MR13                      \ [0x0d] Interrupt Mask on line 13
    $0e constant EXTI_MR14                      \ [0x0e] Interrupt Mask on line 14
    $0f constant EXTI_MR15                      \ [0x0f] Interrupt Mask on line 15
    $10 constant EXTI_MR16                      \ [0x10] Interrupt Mask on line 16
    $11 constant EXTI_MR17                      \ [0x11] Interrupt Mask on line 17
    $12 constant EXTI_MR18                      \ [0x12] Interrupt Mask on line 18
    $13 constant EXTI_MR19                      \ [0x13] Interrupt Mask on line 19
    $14 constant EXTI_MR20                      \ [0x14] Interrupt Mask on line 20
    $15 constant EXTI_MR21                      \ [0x15] Interrupt Mask on line 21
    $16 constant EXTI_MR22                      \ [0x16] Interrupt Mask on line 22
  [then]


  [ifdef] EXTI_EMR_DEF
    \
    \ @brief Event mask register (EXTI_EMR)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR0                       \ [0x00] Event Mask on line 0
    $01 constant EXTI_MR1                       \ [0x01] Event Mask on line 1
    $02 constant EXTI_MR2                       \ [0x02] Event Mask on line 2
    $03 constant EXTI_MR3                       \ [0x03] Event Mask on line 3
    $04 constant EXTI_MR4                       \ [0x04] Event Mask on line 4
    $05 constant EXTI_MR5                       \ [0x05] Event Mask on line 5
    $06 constant EXTI_MR6                       \ [0x06] Event Mask on line 6
    $07 constant EXTI_MR7                       \ [0x07] Event Mask on line 7
    $08 constant EXTI_MR8                       \ [0x08] Event Mask on line 8
    $09 constant EXTI_MR9                       \ [0x09] Event Mask on line 9
    $0a constant EXTI_MR10                      \ [0x0a] Event Mask on line 10
    $0b constant EXTI_MR11                      \ [0x0b] Event Mask on line 11
    $0c constant EXTI_MR12                      \ [0x0c] Event Mask on line 12
    $0d constant EXTI_MR13                      \ [0x0d] Event Mask on line 13
    $0e constant EXTI_MR14                      \ [0x0e] Event Mask on line 14
    $0f constant EXTI_MR15                      \ [0x0f] Event Mask on line 15
    $10 constant EXTI_MR16                      \ [0x10] Event Mask on line 16
    $11 constant EXTI_MR17                      \ [0x11] Event Mask on line 17
    $12 constant EXTI_MR18                      \ [0x12] Event Mask on line 18
    $13 constant EXTI_MR19                      \ [0x13] Event Mask on line 19
    $14 constant EXTI_MR20                      \ [0x14] Event Mask on line 20
    $15 constant EXTI_MR21                      \ [0x15] Event Mask on line 21
    $16 constant EXTI_MR22                      \ [0x16] Event Mask on line 22
  [then]


  [ifdef] EXTI_RTSR_DEF
    \
    \ @brief Rising Trigger selection register (EXTI_RTSR)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TR0                       \ [0x00] Rising trigger event configuration of line 0
    $01 constant EXTI_TR1                       \ [0x01] Rising trigger event configuration of line 1
    $02 constant EXTI_TR2                       \ [0x02] Rising trigger event configuration of line 2
    $03 constant EXTI_TR3                       \ [0x03] Rising trigger event configuration of line 3
    $04 constant EXTI_TR4                       \ [0x04] Rising trigger event configuration of line 4
    $05 constant EXTI_TR5                       \ [0x05] Rising trigger event configuration of line 5
    $06 constant EXTI_TR6                       \ [0x06] Rising trigger event configuration of line 6
    $07 constant EXTI_TR7                       \ [0x07] Rising trigger event configuration of line 7
    $08 constant EXTI_TR8                       \ [0x08] Rising trigger event configuration of line 8
    $09 constant EXTI_TR9                       \ [0x09] Rising trigger event configuration of line 9
    $0a constant EXTI_TR10                      \ [0x0a] Rising trigger event configuration of line 10
    $0b constant EXTI_TR11                      \ [0x0b] Rising trigger event configuration of line 11
    $0c constant EXTI_TR12                      \ [0x0c] Rising trigger event configuration of line 12
    $0d constant EXTI_TR13                      \ [0x0d] Rising trigger event configuration of line 13
    $0e constant EXTI_TR14                      \ [0x0e] Rising trigger event configuration of line 14
    $0f constant EXTI_TR15                      \ [0x0f] Rising trigger event configuration of line 15
    $10 constant EXTI_TR16                      \ [0x10] Rising trigger event configuration of line 16
    $11 constant EXTI_TR17                      \ [0x11] Rising trigger event configuration of line 17
    $12 constant EXTI_TR18                      \ [0x12] Rising trigger event configuration of line 18
    $13 constant EXTI_TR19                      \ [0x13] Rising trigger event configuration of line 19
    $14 constant EXTI_TR20                      \ [0x14] Rising trigger event configuration of line 20
    $15 constant EXTI_TR21                      \ [0x15] Rising trigger event configuration of line 21
    $16 constant EXTI_TR22                      \ [0x16] Rising trigger event configuration of line 22
  [then]


  [ifdef] EXTI_FTSR_DEF
    \
    \ @brief Falling Trigger selection register (EXTI_FTSR)
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TR0                       \ [0x00] Falling trigger event configuration of line 0
    $01 constant EXTI_TR1                       \ [0x01] Falling trigger event configuration of line 1
    $02 constant EXTI_TR2                       \ [0x02] Falling trigger event configuration of line 2
    $03 constant EXTI_TR3                       \ [0x03] Falling trigger event configuration of line 3
    $04 constant EXTI_TR4                       \ [0x04] Falling trigger event configuration of line 4
    $05 constant EXTI_TR5                       \ [0x05] Falling trigger event configuration of line 5
    $06 constant EXTI_TR6                       \ [0x06] Falling trigger event configuration of line 6
    $07 constant EXTI_TR7                       \ [0x07] Falling trigger event configuration of line 7
    $08 constant EXTI_TR8                       \ [0x08] Falling trigger event configuration of line 8
    $09 constant EXTI_TR9                       \ [0x09] Falling trigger event configuration of line 9
    $0a constant EXTI_TR10                      \ [0x0a] Falling trigger event configuration of line 10
    $0b constant EXTI_TR11                      \ [0x0b] Falling trigger event configuration of line 11
    $0c constant EXTI_TR12                      \ [0x0c] Falling trigger event configuration of line 12
    $0d constant EXTI_TR13                      \ [0x0d] Falling trigger event configuration of line 13
    $0e constant EXTI_TR14                      \ [0x0e] Falling trigger event configuration of line 14
    $0f constant EXTI_TR15                      \ [0x0f] Falling trigger event configuration of line 15
    $10 constant EXTI_TR16                      \ [0x10] Falling trigger event configuration of line 16
    $11 constant EXTI_TR17                      \ [0x11] Falling trigger event configuration of line 17
    $12 constant EXTI_TR18                      \ [0x12] Falling trigger event configuration of line 18
    $13 constant EXTI_TR19                      \ [0x13] Falling trigger event configuration of line 19
    $14 constant EXTI_TR20                      \ [0x14] Falling trigger event configuration of line 20
    $15 constant EXTI_TR21                      \ [0x15] Falling trigger event configuration of line 21
    $16 constant EXTI_TR22                      \ [0x16] Falling trigger event configuration of line 22
  [then]


  [ifdef] EXTI_SWIER_DEF
    \
    \ @brief Software interrupt event register (EXTI_SWIER)
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWIER0                    \ [0x00] Software Interrupt on line 0
    $01 constant EXTI_SWIER1                    \ [0x01] Software Interrupt on line 1
    $02 constant EXTI_SWIER2                    \ [0x02] Software Interrupt on line 2
    $03 constant EXTI_SWIER3                    \ [0x03] Software Interrupt on line 3
    $04 constant EXTI_SWIER4                    \ [0x04] Software Interrupt on line 4
    $05 constant EXTI_SWIER5                    \ [0x05] Software Interrupt on line 5
    $06 constant EXTI_SWIER6                    \ [0x06] Software Interrupt on line 6
    $07 constant EXTI_SWIER7                    \ [0x07] Software Interrupt on line 7
    $08 constant EXTI_SWIER8                    \ [0x08] Software Interrupt on line 8
    $09 constant EXTI_SWIER9                    \ [0x09] Software Interrupt on line 9
    $0a constant EXTI_SWIER10                   \ [0x0a] Software Interrupt on line 10
    $0b constant EXTI_SWIER11                   \ [0x0b] Software Interrupt on line 11
    $0c constant EXTI_SWIER12                   \ [0x0c] Software Interrupt on line 12
    $0d constant EXTI_SWIER13                   \ [0x0d] Software Interrupt on line 13
    $0e constant EXTI_SWIER14                   \ [0x0e] Software Interrupt on line 14
    $0f constant EXTI_SWIER15                   \ [0x0f] Software Interrupt on line 15
    $10 constant EXTI_SWIER16                   \ [0x10] Software Interrupt on line 16
    $11 constant EXTI_SWIER17                   \ [0x11] Software Interrupt on line 17
    $12 constant EXTI_SWIER18                   \ [0x12] Software Interrupt on line 18
    $13 constant EXTI_SWIER19                   \ [0x13] Software Interrupt on line 19
    $14 constant EXTI_SWIER20                   \ [0x14] Software Interrupt on line 20
    $15 constant EXTI_SWIER21                   \ [0x15] Software Interrupt on line 21
    $16 constant EXTI_SWIER22                   \ [0x16] Software Interrupt on line 22
  [then]


  [ifdef] EXTI_PR_DEF
    \
    \ @brief Pending register (EXTI_PR)
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PR0                       \ [0x00] Pending bit 0
    $01 constant EXTI_PR1                       \ [0x01] Pending bit 1
    $02 constant EXTI_PR2                       \ [0x02] Pending bit 2
    $03 constant EXTI_PR3                       \ [0x03] Pending bit 3
    $04 constant EXTI_PR4                       \ [0x04] Pending bit 4
    $05 constant EXTI_PR5                       \ [0x05] Pending bit 5
    $06 constant EXTI_PR6                       \ [0x06] Pending bit 6
    $07 constant EXTI_PR7                       \ [0x07] Pending bit 7
    $08 constant EXTI_PR8                       \ [0x08] Pending bit 8
    $09 constant EXTI_PR9                       \ [0x09] Pending bit 9
    $0a constant EXTI_PR10                      \ [0x0a] Pending bit 10
    $0b constant EXTI_PR11                      \ [0x0b] Pending bit 11
    $0c constant EXTI_PR12                      \ [0x0c] Pending bit 12
    $0d constant EXTI_PR13                      \ [0x0d] Pending bit 13
    $0e constant EXTI_PR14                      \ [0x0e] Pending bit 14
    $0f constant EXTI_PR15                      \ [0x0f] Pending bit 15
    $10 constant EXTI_PR16                      \ [0x10] Pending bit 16
    $11 constant EXTI_PR17                      \ [0x11] Pending bit 17
    $12 constant EXTI_PR18                      \ [0x12] Pending bit 18
    $13 constant EXTI_PR19                      \ [0x13] Pending bit 19
    $14 constant EXTI_PR20                      \ [0x14] Pending bit 20
    $15 constant EXTI_PR21                      \ [0x15] Pending bit 21
    $16 constant EXTI_PR22                      \ [0x16] Pending bit 22
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
