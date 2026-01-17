\
\ @file exti.fs
\ @brief External interrupt/event controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] EXTI_DEF

  [ifdef] EXTI_IMR1_DEF
    \
    \ @brief Interrupt mask register
    \ Address offset: 0x00
    \ Reset value: 0xFF820000
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
    $17 constant EXTI_MR23                      \ [0x17] Interrupt Mask on line 23
    $18 constant EXTI_MR24                      \ [0x18] Interrupt Mask on line 24
    $19 constant EXTI_MR25                      \ [0x19] Interrupt Mask on line 25
    $1a constant EXTI_MR26                      \ [0x1a] Interrupt Mask on line 26
    $1b constant EXTI_MR27                      \ [0x1b] Interrupt Mask on line 27
    $1c constant EXTI_MR28                      \ [0x1c] Interrupt Mask on line 28
    $1d constant EXTI_MR29                      \ [0x1d] Interrupt Mask on line 29
    $1e constant EXTI_MR30                      \ [0x1e] Interrupt Mask on line 30
    $1f constant EXTI_MR31                      \ [0x1f] Interrupt Mask on line 31
  [then]


  [ifdef] EXTI_EMR1_DEF
    \
    \ @brief Event mask register
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
    $17 constant EXTI_MR23                      \ [0x17] Event Mask on line 23
    $18 constant EXTI_MR24                      \ [0x18] Event Mask on line 24
    $19 constant EXTI_MR25                      \ [0x19] Event Mask on line 25
    $1a constant EXTI_MR26                      \ [0x1a] Event Mask on line 26
    $1b constant EXTI_MR27                      \ [0x1b] Event Mask on line 27
    $1c constant EXTI_MR28                      \ [0x1c] Event Mask on line 28
    $1d constant EXTI_MR29                      \ [0x1d] Event Mask on line 29
    $1e constant EXTI_MR30                      \ [0x1e] Event Mask on line 30
    $1f constant EXTI_MR31                      \ [0x1f] Event Mask on line 31
  [then]


  [ifdef] EXTI_RTSR1_DEF
    \
    \ @brief Rising Trigger selection register
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
    $12 constant EXTI_TR18                      \ [0x12] Rising trigger event configuration of line 18
    $13 constant EXTI_TR19                      \ [0x13] Rising trigger event configuration of line 19
    $14 constant EXTI_TR20                      \ [0x14] Rising trigger event configuration of line 20
    $15 constant EXTI_TR21                      \ [0x15] Rising trigger event configuration of line 21
    $16 constant EXTI_TR22                      \ [0x16] Rising trigger event configuration of line 22
  [then]


  [ifdef] EXTI_FTSR1_DEF
    \
    \ @brief Falling Trigger selection register
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
    $12 constant EXTI_TR18                      \ [0x12] Falling trigger event configuration of line 18
    $13 constant EXTI_TR19                      \ [0x13] Falling trigger event configuration of line 19
    $14 constant EXTI_TR20                      \ [0x14] Falling trigger event configuration of line 20
    $15 constant EXTI_TR21                      \ [0x15] Falling trigger event configuration of line 21
    $16 constant EXTI_TR22                      \ [0x16] Falling trigger event configuration of line 22
  [then]


  [ifdef] EXTI_SWIER1_DEF
    \
    \ @brief Software interrupt event register
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
    $12 constant EXTI_SWIER18                   \ [0x12] Software Interrupt on line 18
    $13 constant EXTI_SWIER19                   \ [0x13] Software Interrupt on line 19
    $14 constant EXTI_SWIER20                   \ [0x14] Software Interrupt on line 20
    $15 constant EXTI_SWIER21                   \ [0x15] Software Interrupt on line 21
    $16 constant EXTI_SWIER22                   \ [0x16] Software Interrupt on line 22
  [then]


  [ifdef] EXTI_PR1_DEF
    \
    \ @brief Pending register
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
    $12 constant EXTI_PR18                      \ [0x12] Pending bit 18
    $13 constant EXTI_PR19                      \ [0x13] Pending bit 19
    $14 constant EXTI_PR20                      \ [0x14] Pending bit 20
    $15 constant EXTI_PR21                      \ [0x15] Pending bit 21
    $16 constant EXTI_PR22                      \ [0x16] Pending bit 22
  [then]


  [ifdef] EXTI_IMR2_DEF
    \
    \ @brief Interrupt mask register
    \ Address offset: 0x20
    \ Reset value: 0xFFFFFF87
    \
    $00 constant EXTI_MR32                      \ [0x00] Interrupt Mask on external/internal line 32
    $01 constant EXTI_MR33                      \ [0x01] Interrupt Mask on external/internal line 33
    $02 constant EXTI_MR34                      \ [0x02] Interrupt Mask on external/internal line 34
    $03 constant EXTI_MR35                      \ [0x03] Interrupt Mask on external/internal line 35
    $04 constant EXTI_MR36                      \ [0x04] Interrupt Mask on external/internal line 36
    $05 constant EXTI_MR37                      \ [0x05] Interrupt Mask on external/internal line 37
    $06 constant EXTI_MR38                      \ [0x06] Interrupt Mask on external/internal line 38
    $07 constant EXTI_MR39                      \ [0x07] Interrupt Mask on external/internal line 39
  [then]


  [ifdef] EXTI_EMR2_DEF
    \
    \ @brief Event mask register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR32                      \ [0x00] Event mask on external/internal line 32
    $01 constant EXTI_MR33                      \ [0x01] Event mask on external/internal line 33
    $02 constant EXTI_MR34                      \ [0x02] Event mask on external/internal line 34
    $03 constant EXTI_MR35                      \ [0x03] Event mask on external/internal line 35
    $04 constant EXTI_MR36                      \ [0x04] Event mask on external/internal line 36
    $05 constant EXTI_MR37                      \ [0x05] Event mask on external/internal line 37
    $06 constant EXTI_MR38                      \ [0x06] Event mask on external/internal line 38
    $07 constant EXTI_MR39                      \ [0x07] Event mask on external/internal line 39
  [then]


  [ifdef] EXTI_RTSR2_DEF
    \
    \ @brief Rising Trigger selection register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $03 constant EXTI_RT35                      \ [0x03] Rising trigger event configuration bit of line 35
    $04 constant EXTI_RT36                      \ [0x04] Rising trigger event configuration bit of line 36
    $05 constant EXTI_RT37                      \ [0x05] Rising trigger event configuration bit of line 37
    $06 constant EXTI_RT38                      \ [0x06] Rising trigger event configuration bit of line 38
  [then]


  [ifdef] EXTI_FTSR2_DEF
    \
    \ @brief Falling Trigger selection register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $03 constant EXTI_FT35                      \ [0x03] Falling trigger event configuration bit of line 35
    $04 constant EXTI_FT36                      \ [0x04] Falling trigger event configuration bit of line 36
    $05 constant EXTI_FT37                      \ [0x05] Falling trigger event configuration bit of line 37
    $06 constant EXTI_FT38                      \ [0x06] Falling trigger event configuration bit of line 38
  [then]


  [ifdef] EXTI_SWIER2_DEF
    \
    \ @brief Software interrupt event register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $03 constant EXTI_SWI35                     \ [0x03] Software interrupt on line 35
    $04 constant EXTI_SWI36                     \ [0x04] Software interrupt on line 36
    $05 constant EXTI_SWI37                     \ [0x05] Software interrupt on line 37
    $06 constant EXTI_SWI38                     \ [0x06] Software interrupt on line 38
  [then]


  [ifdef] EXTI_PR2_DEF
    \
    \ @brief Pending register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $03 constant EXTI_PIF35                     \ [0x03] Pending interrupt flag on line 35
    $04 constant EXTI_PIF36                     \ [0x04] Pending interrupt flag on line 36
    $05 constant EXTI_PIF37                     \ [0x05] Pending interrupt flag on line 37
    $06 constant EXTI_PIF38                     \ [0x06] Pending interrupt flag on line 38
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_IMR1                \ Interrupt mask register
  $04 constant EXTI_EMR1                \ Event mask register
  $08 constant EXTI_RTSR1               \ Rising Trigger selection register
  $0C constant EXTI_FTSR1               \ Falling Trigger selection register
  $10 constant EXTI_SWIER1              \ Software interrupt event register
  $14 constant EXTI_PR1                 \ Pending register
  $20 constant EXTI_IMR2                \ Interrupt mask register
  $24 constant EXTI_EMR2                \ Event mask register
  $28 constant EXTI_RTSR2               \ Rising Trigger selection register
  $2C constant EXTI_FTSR2               \ Falling Trigger selection register
  $30 constant EXTI_SWIER2              \ Software interrupt event register
  $34 constant EXTI_PR2                 \ Pending register

: EXTI_DEF ; [then]
