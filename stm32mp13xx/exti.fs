\
\ @file exti.fs
\ @brief EXTI
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] EXTI_DEF

  [ifdef] EXTI_EXTI_RTSR1_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RT0                       \ [0x00] RT0
    $01 constant EXTI_RT1                       \ [0x01] RT1
    $02 constant EXTI_RT2                       \ [0x02] RT2
    $03 constant EXTI_RT3                       \ [0x03] RT3
    $04 constant EXTI_RT4                       \ [0x04] RT4
    $05 constant EXTI_RT5                       \ [0x05] RT5
    $06 constant EXTI_RT6                       \ [0x06] RT6
    $07 constant EXTI_RT7                       \ [0x07] RT7
    $08 constant EXTI_RT8                       \ [0x08] RT8
    $09 constant EXTI_RT9                       \ [0x09] RT9
    $0a constant EXTI_RT10                      \ [0x0a] RT10
    $0b constant EXTI_RT11                      \ [0x0b] RT11
    $0c constant EXTI_RT12                      \ [0x0c] RT12
    $0d constant EXTI_RT13                      \ [0x0d] RT13
    $0e constant EXTI_RT14                      \ [0x0e] RT14
    $0f constant EXTI_RT15                      \ [0x0f] RT15
    $10 constant EXTI_RT16                      \ [0x10] RT16
  [then]


  [ifdef] EXTI_EXTI_FTSR1_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT0                       \ [0x00] FT0
    $01 constant EXTI_FT1                       \ [0x01] FT1
    $02 constant EXTI_FT2                       \ [0x02] FT2
    $03 constant EXTI_FT3                       \ [0x03] FT3
    $04 constant EXTI_FT4                       \ [0x04] FT4
    $05 constant EXTI_FT5                       \ [0x05] FT5
    $06 constant EXTI_FT6                       \ [0x06] FT6
    $07 constant EXTI_FT7                       \ [0x07] FT7
    $08 constant EXTI_FT8                       \ [0x08] FT8
    $09 constant EXTI_FT9                       \ [0x09] FT9
    $0a constant EXTI_FT10                      \ [0x0a] FT10
    $0b constant EXTI_FT11                      \ [0x0b] FT11
    $0c constant EXTI_FT12                      \ [0x0c] FT12
    $0d constant EXTI_FT13                      \ [0x0d] FT13
    $0e constant EXTI_FT14                      \ [0x0e] FT14
    $0f constant EXTI_FT15                      \ [0x0f] FT15
    $10 constant EXTI_FT16                      \ [0x10] FT16
  [then]


  [ifdef] EXTI_EXTI_SWIER1_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI0                      \ [0x00] SWI0
    $01 constant EXTI_SWI1                      \ [0x01] SWI1
    $02 constant EXTI_SWI2                      \ [0x02] SWI2
    $03 constant EXTI_SWI3                      \ [0x03] SWI3
    $04 constant EXTI_SWI4                      \ [0x04] SWI4
    $05 constant EXTI_SWI5                      \ [0x05] SWI5
    $06 constant EXTI_SWI6                      \ [0x06] SWI6
    $07 constant EXTI_SWI7                      \ [0x07] SWI7
    $08 constant EXTI_SWI8                      \ [0x08] SWI8
    $09 constant EXTI_SWI9                      \ [0x09] SWI9
    $0a constant EXTI_SWI10                     \ [0x0a] SWI10
    $0b constant EXTI_SWI11                     \ [0x0b] SWI11
    $0c constant EXTI_SWI12                     \ [0x0c] SWI12
    $0d constant EXTI_SWI13                     \ [0x0d] SWI13
    $0e constant EXTI_SWI14                     \ [0x0e] SWI14
    $0f constant EXTI_SWI15                     \ [0x0f] SWI15
    $10 constant EXTI_SWI16                     \ [0x10] SWI16
  [then]


  [ifdef] EXTI_EXTI_RPR1_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RPIF0                     \ [0x00] RPIF0
    $01 constant EXTI_RPIF1                     \ [0x01] RPIF1
    $02 constant EXTI_RPIF2                     \ [0x02] RPIF2
    $03 constant EXTI_RPIF3                     \ [0x03] RPIF3
    $04 constant EXTI_RPIF4                     \ [0x04] RPIF4
    $05 constant EXTI_RPIF5                     \ [0x05] RPIF5
    $06 constant EXTI_RPIF6                     \ [0x06] RPIF6
    $07 constant EXTI_RPIF7                     \ [0x07] RPIF7
    $08 constant EXTI_RPIF8                     \ [0x08] RPIF8
    $09 constant EXTI_RPIF9                     \ [0x09] RPIF9
    $0a constant EXTI_RPIF10                    \ [0x0a] RPIF10
    $0b constant EXTI_RPIF11                    \ [0x0b] RPIF11
    $0c constant EXTI_RPIF12                    \ [0x0c] RPIF12
    $0d constant EXTI_RPIF13                    \ [0x0d] RPIF13
    $0e constant EXTI_RPIF14                    \ [0x0e] RPIF14
    $0f constant EXTI_RPIF15                    \ [0x0f] RPIF15
    $10 constant EXTI_RPIF16                    \ [0x10] RPIF16
  [then]


  [ifdef] EXTI_EXTI_FPR1_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FPIF0                     \ [0x00] FPIF0
    $01 constant EXTI_FPIF1                     \ [0x01] FPIF1
    $02 constant EXTI_FPIF2                     \ [0x02] FPIF2
    $03 constant EXTI_FPIF3                     \ [0x03] FPIF3
    $04 constant EXTI_FPIF4                     \ [0x04] FPIF4
    $05 constant EXTI_FPIF5                     \ [0x05] FPIF5
    $06 constant EXTI_FPIF6                     \ [0x06] FPIF6
    $07 constant EXTI_FPIF7                     \ [0x07] FPIF7
    $08 constant EXTI_FPIF8                     \ [0x08] FPIF8
    $09 constant EXTI_FPIF9                     \ [0x09] FPIF9
    $0a constant EXTI_FPIF10                    \ [0x0a] FPIF10
    $0b constant EXTI_FPIF11                    \ [0x0b] FPIF11
    $0c constant EXTI_FPIF12                    \ [0x0c] FPIF12
    $0d constant EXTI_FPIF13                    \ [0x0d] FPIF13
    $0e constant EXTI_FPIF14                    \ [0x0e] FPIF14
    $0f constant EXTI_FPIF15                    \ [0x0f] FPIF15
    $10 constant EXTI_FPIF16                    \ [0x10] FPIF16
  [then]


  [ifdef] EXTI_EXTI_TZENR1_DEF
    \
    \ @brief This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TZEN0                     \ [0x00] TZEN0
    $01 constant EXTI_TZEN1                     \ [0x01] TZEN1
    $02 constant EXTI_TZEN2                     \ [0x02] TZEN2
    $03 constant EXTI_TZEN3                     \ [0x03] TZEN3
    $04 constant EXTI_TZEN4                     \ [0x04] TZEN4
    $05 constant EXTI_TZEN5                     \ [0x05] TZEN5
    $06 constant EXTI_TZEN6                     \ [0x06] TZEN6
    $07 constant EXTI_TZEN7                     \ [0x07] TZEN7
    $08 constant EXTI_TZEN8                     \ [0x08] TZEN8
    $09 constant EXTI_TZEN9                     \ [0x09] TZEN9
    $0a constant EXTI_TZEN10                    \ [0x0a] TZEN10
    $0b constant EXTI_TZEN11                    \ [0x0b] TZEN11
    $0c constant EXTI_TZEN12                    \ [0x0c] TZEN12
    $0d constant EXTI_TZEN13                    \ [0x0d] TZEN13
    $0e constant EXTI_TZEN14                    \ [0x0e] TZEN14
    $0f constant EXTI_TZEN15                    \ [0x0f] TZEN15
    $11 constant EXTI_TZEN17                    \ [0x11] TZEN17
    $12 constant EXTI_TZEN18                    \ [0x12] TZEN18
    $13 constant EXTI_TZEN19                    \ [0x13] TZEN19
    $18 constant EXTI_TZEN24                    \ [0x18] TZEN24
    $1a constant EXTI_TZEN26                    \ [0x1a] TZEN26
  [then]


  [ifdef] EXTI_EXTI_RTSR2_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_FTSR2_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_SWIER2_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_RPR2_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_FPR2_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_TZENR2_DEF
    \
    \ @brief This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $09 constant EXTI_TZEN41                    \ [0x09] TZEN41
    $16 constant EXTI_TZEN54                    \ [0x16] TZEN54
    $17 constant EXTI_TZEN55                    \ [0x17] TZEN55
    $18 constant EXTI_TZEN56                    \ [0x18] TZEN56
    $19 constant EXTI_TZEN57                    \ [0x19] TZEN57
    $1a constant EXTI_TZEN58                    \ [0x1a] TZEN58
    $1b constant EXTI_TZEN59                    \ [0x1b] TZEN59
    $1c constant EXTI_TZEN60                    \ [0x1c] TZEN60
  [then]


  [ifdef] EXTI_EXTI_RTSR3_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_RT65                      \ [0x01] RT65
    $02 constant EXTI_RT66                      \ [0x02] RT66
    $04 constant EXTI_RT68                      \ [0x04] RT68
    $09 constant EXTI_RT73                      \ [0x09] RT73
    $0a constant EXTI_RT74                      \ [0x0a] RT74
  [then]


  [ifdef] EXTI_EXTI_FTSR3_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_FT65                      \ [0x01] FT65
    $02 constant EXTI_FT66                      \ [0x02] FT66
    $04 constant EXTI_FT68                      \ [0x04] FT68
    $09 constant EXTI_FT73                      \ [0x09] FT73
    $0a constant EXTI_FT74                      \ [0x0a] FT74
  [then]


  [ifdef] EXTI_EXTI_SWIER3_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_SWI65                     \ [0x01] SWI65
    $02 constant EXTI_SWI66                     \ [0x02] SWI66
    $04 constant EXTI_SWI68                     \ [0x04] SWI68
    $09 constant EXTI_SWI73                     \ [0x09] SWI73
    $0a constant EXTI_SWI74                     \ [0x0a] SWI74
  [then]


  [ifdef] EXTI_EXTI_RPR3_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_RPIF65                    \ [0x01] RPIF65
    $02 constant EXTI_RPIF66                    \ [0x02] RPIF66
    $04 constant EXTI_RPIF68                    \ [0x04] RPIF68
    $09 constant EXTI_RPIF73                    \ [0x09] RPIF73
    $0a constant EXTI_RPIF74                    \ [0x0a] RPIF74
  [then]


  [ifdef] EXTI_EXTI_FPR3_DEF
    \
    \ @brief Contains only register bits for configurable events.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_FPIF65                    \ [0x01] FPIF65
    $02 constant EXTI_FPIF66                    \ [0x02] FPIF66
    $04 constant EXTI_FPIF68                    \ [0x04] FPIF68
    $09 constant EXTI_FPIF73                    \ [0x09] FPIF73
    $0a constant EXTI_FPIF74                    \ [0x0a] FPIF74
  [then]


  [ifdef] EXTI_EXTI_TZENR3_DEF
    \
    \ @brief This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_EXTICR1_DEF
    \
    \ @brief EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0                     \ [0x00 : 8] EXTI0
    $08 constant EXTI_EXTI1                     \ [0x08 : 8] EXTI1
    $10 constant EXTI_EXTI2                     \ [0x10 : 8] EXTI2
    $18 constant EXTI_EXTI3                     \ [0x18 : 8] EXTI3
  [then]


  [ifdef] EXTI_EXTI_EXTICR2_DEF
    \
    \ @brief EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI4                     \ [0x00 : 8] EXTI4
    $08 constant EXTI_EXTI5                     \ [0x08 : 8] EXTI5
    $10 constant EXTI_EXTI6                     \ [0x10 : 8] EXTI6
    $18 constant EXTI_EXTI7                     \ [0x18 : 8] EXTI7
  [then]


  [ifdef] EXTI_EXTI_EXTICR3_DEF
    \
    \ @brief EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI8                     \ [0x00 : 8] EXTI8
    $08 constant EXTI_EXTI9                     \ [0x08 : 8] EXTI9
    $10 constant EXTI_EXTI10                    \ [0x10 : 8] EXTI10
    $18 constant EXTI_EXTI11                    \ [0x18 : 8] EXTI11
  [then]


  [ifdef] EXTI_EXTI_EXTICR4_DEF
    \
    \ @brief EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI12                    \ [0x00 : 8] EXTI12
    $08 constant EXTI_EXTI13                    \ [0x08 : 8] EXTI13
    $10 constant EXTI_EXTI14                    \ [0x10 : 8] EXTI14
    $18 constant EXTI_EXTI15                    \ [0x18 : 8] EXTI15
  [then]


  [ifdef] EXTI_EXTI_IMR1_DEF
    \
    \ @brief Contains register bits for configurable events and Direct events.
    \ Address offset: 0x80
    \ Reset value: 0xFFFE0000
    \
    $00 constant EXTI_IM0                       \ [0x00] IM0
    $01 constant EXTI_IM1                       \ [0x01] IM1
    $02 constant EXTI_IM2                       \ [0x02] IM2
    $03 constant EXTI_IM3                       \ [0x03] IM3
    $04 constant EXTI_IM4                       \ [0x04] IM4
    $05 constant EXTI_IM5                       \ [0x05] IM5
    $06 constant EXTI_IM6                       \ [0x06] IM6
    $07 constant EXTI_IM7                       \ [0x07] IM7
    $08 constant EXTI_IM8                       \ [0x08] IM8
    $09 constant EXTI_IM9                       \ [0x09] IM9
    $0a constant EXTI_IM10                      \ [0x0a] IM10
    $0b constant EXTI_IM11                      \ [0x0b] IM11
    $0c constant EXTI_IM12                      \ [0x0c] IM12
    $0d constant EXTI_IM13                      \ [0x0d] IM13
    $0e constant EXTI_IM14                      \ [0x0e] IM14
    $0f constant EXTI_IM15                      \ [0x0f] IM15
    $10 constant EXTI_IM16                      \ [0x10] IM16
    $11 constant EXTI_IM17                      \ [0x11] IM17
    $12 constant EXTI_IM18                      \ [0x12] IM18
    $13 constant EXTI_IM19                      \ [0x13] IM19
    $14 constant EXTI_IM20                      \ [0x14] IM20
    $15 constant EXTI_IM21                      \ [0x15] IM21
    $16 constant EXTI_IM22                      \ [0x16] IM22
    $17 constant EXTI_IM23                      \ [0x17] IM23
    $18 constant EXTI_IM24                      \ [0x18] IM24
    $19 constant EXTI_IM25                      \ [0x19] IM25
    $1a constant EXTI_IM26                      \ [0x1a] IM26
    $1b constant EXTI_IM27                      \ [0x1b] IM27
    $1c constant EXTI_IM28                      \ [0x1c] IM28
    $1d constant EXTI_IM29                      \ [0x1d] IM29
    $1e constant EXTI_IM30                      \ [0x1e] IM30
    $1f constant EXTI_IM31                      \ [0x1f] IM31
  [then]


  [ifdef] EXTI_EXTI_EMR1_DEF
    \
    \ @brief EXTI CPU wakeup with event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] EM0
    $01 constant EXTI_EM1                       \ [0x01] EM1
    $02 constant EXTI_EM2                       \ [0x02] EM2
    $03 constant EXTI_EM3                       \ [0x03] EM3
    $04 constant EXTI_EM4                       \ [0x04] EM4
    $05 constant EXTI_EM5                       \ [0x05] EM5
    $06 constant EXTI_EM6                       \ [0x06] EM6
    $07 constant EXTI_EM7                       \ [0x07] EM7
    $08 constant EXTI_EM8                       \ [0x08] EM8
    $09 constant EXTI_EM9                       \ [0x09] EM9
    $0a constant EXTI_EM10                      \ [0x0a] EM10
    $0b constant EXTI_EM11                      \ [0x0b] EM11
    $0c constant EXTI_EM12                      \ [0x0c] EM12
    $0d constant EXTI_EM13                      \ [0x0d] EM13
    $0e constant EXTI_EM14                      \ [0x0e] EM14
    $0f constant EXTI_EM15                      \ [0x0f] EM15
    $11 constant EXTI_EM17                      \ [0x11] EM17
    $12 constant EXTI_EM18                      \ [0x12] EM18
    $13 constant EXTI_EM19                      \ [0x13] EM19
  [then]


  [ifdef] EXTI_EXTI_IMR2_DEF
    \
    \ @brief Contains register bits for configurable events and direct events.
    \ Address offset: 0x90
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant EXTI_IM32                      \ [0x00] IM32
    $01 constant EXTI_IM33                      \ [0x01] IM33
    $02 constant EXTI_IM34                      \ [0x02] IM34
    $03 constant EXTI_IM35                      \ [0x03] IM35
    $04 constant EXTI_IM36                      \ [0x04] IM36
    $05 constant EXTI_IM37                      \ [0x05] IM37
    $06 constant EXTI_IM38                      \ [0x06] IM38
    $07 constant EXTI_IM39                      \ [0x07] IM39
    $08 constant EXTI_IM40                      \ [0x08] IM40
    $09 constant EXTI_IM41                      \ [0x09] IM41
    $0a constant EXTI_IM42                      \ [0x0a] IM42
    $0b constant EXTI_IM43                      \ [0x0b] IM43
    $0c constant EXTI_IM44                      \ [0x0c] IM44
    $0d constant EXTI_IM45                      \ [0x0d] IM45
    $0e constant EXTI_IM46                      \ [0x0e] IM46
    $0f constant EXTI_IM47                      \ [0x0f] IM47
    $10 constant EXTI_IM48                      \ [0x10] IM48
    $11 constant EXTI_IM49                      \ [0x11] IM49
    $12 constant EXTI_IM50                      \ [0x12] IM50
    $13 constant EXTI_IM51                      \ [0x13] IM51
    $14 constant EXTI_IM52                      \ [0x14] IM52
    $15 constant EXTI_IM53                      \ [0x15] IM53
    $16 constant EXTI_IM54                      \ [0x16] IM54
    $17 constant EXTI_IM55                      \ [0x17] IM55
    $18 constant EXTI_IM56                      \ [0x18] IM56
    $19 constant EXTI_IM57                      \ [0x19] IM57
    $1a constant EXTI_IM58                      \ [0x1a] IM58
    $1b constant EXTI_IM59                      \ [0x1b] IM59
    $1c constant EXTI_IM60                      \ [0x1c] IM60
    $1d constant EXTI_IM61                      \ [0x1d] IM61
    $1e constant EXTI_IM62                      \ [0x1e] IM62
    $1f constant EXTI_IM63                      \ [0x1f] IM63
  [then]


  [ifdef] EXTI_EXTI_EMR2_DEF
    \
    \ @brief EXTI CPU wakeup with event mask register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_IMR3_DEF
    \
    \ @brief Contains register bits for configurable events and direct events.
    \ Address offset: 0xA0
    \ Reset value: 0x00000DE9
    \
    $00 constant EXTI_IM64                      \ [0x00] IM64
    $01 constant EXTI_IM65                      \ [0x01] IM65
    $02 constant EXTI_IM66                      \ [0x02] IM66
    $03 constant EXTI_IM67                      \ [0x03] IM67
    $04 constant EXTI_IM68                      \ [0x04] IM68
    $05 constant EXTI_IM69                      \ [0x05] IM69
    $06 constant EXTI_IM70                      \ [0x06] IM70
    $07 constant EXTI_IM71                      \ [0x07] IM71
    $08 constant EXTI_IM72                      \ [0x08] IM72
    $09 constant EXTI_IM73                      \ [0x09] IM73
    $0a constant EXTI_IM74                      \ [0x0a] IM74
    $0b constant EXTI_IM75                      \ [0x0b] IM75
  [then]


  [ifdef] EXTI_EXTI_EMR3_DEF
    \
    \ @brief EXTI CPU wakeup with event mask register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_EM66                      \ [0x02] EM66
  [then]


  [ifdef] EXTI_EXTI_C2IMR1_DEF
    \
    \ @brief Contains register bits for configurable events and Direct events.
    \ Address offset: 0xC0
    \ Reset value: 0xFFFE0000
    \
    $00 constant EXTI_IM0                       \ [0x00] IM0
    $01 constant EXTI_IM1                       \ [0x01] IM1
    $02 constant EXTI_IM2                       \ [0x02] IM2
    $03 constant EXTI_IM3                       \ [0x03] IM3
    $04 constant EXTI_IM4                       \ [0x04] IM4
    $05 constant EXTI_IM5                       \ [0x05] IM5
    $06 constant EXTI_IM6                       \ [0x06] IM6
    $07 constant EXTI_IM7                       \ [0x07] IM7
    $08 constant EXTI_IM8                       \ [0x08] IM8
    $09 constant EXTI_IM9                       \ [0x09] IM9
    $0a constant EXTI_IM10                      \ [0x0a] IM10
    $0b constant EXTI_IM11                      \ [0x0b] IM11
    $0c constant EXTI_IM12                      \ [0x0c] IM12
    $0d constant EXTI_IM13                      \ [0x0d] IM13
    $0e constant EXTI_IM14                      \ [0x0e] IM14
    $0f constant EXTI_IM15                      \ [0x0f] IM15
    $10 constant EXTI_IM16                      \ [0x10] IM16
    $11 constant EXTI_IM17                      \ [0x11] IM17
    $12 constant EXTI_IM18                      \ [0x12] IM18
    $13 constant EXTI_IM19                      \ [0x13] IM19
    $14 constant EXTI_IM20                      \ [0x14] IM20
    $15 constant EXTI_IM21                      \ [0x15] IM21
    $16 constant EXTI_IM22                      \ [0x16] IM22
    $17 constant EXTI_IM23                      \ [0x17] IM23
    $18 constant EXTI_IM24                      \ [0x18] IM24
    $19 constant EXTI_IM25                      \ [0x19] IM25
    $1a constant EXTI_IM26                      \ [0x1a] IM26
    $1b constant EXTI_IM27                      \ [0x1b] IM27
    $1c constant EXTI_IM28                      \ [0x1c] IM28
    $1d constant EXTI_IM29                      \ [0x1d] IM29
    $1e constant EXTI_IM30                      \ [0x1e] IM30
    $1f constant EXTI_IM31                      \ [0x1f] IM31
  [then]


  [ifdef] EXTI_EXTI_C2EMR1_DEF
    \
    \ @brief EXTI CPU2 wakeup with event mask register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] EM0
    $01 constant EXTI_EM1                       \ [0x01] EM1
    $02 constant EXTI_EM2                       \ [0x02] EM2
    $03 constant EXTI_EM3                       \ [0x03] EM3
    $04 constant EXTI_EM4                       \ [0x04] EM4
    $05 constant EXTI_EM5                       \ [0x05] EM5
    $06 constant EXTI_EM6                       \ [0x06] EM6
    $07 constant EXTI_EM7                       \ [0x07] EM7
    $08 constant EXTI_EM8                       \ [0x08] EM8
    $09 constant EXTI_EM9                       \ [0x09] EM9
    $0a constant EXTI_EM10                      \ [0x0a] EM10
    $0b constant EXTI_EM11                      \ [0x0b] EM11
    $0c constant EXTI_EM12                      \ [0x0c] EM12
    $0d constant EXTI_EM13                      \ [0x0d] EM13
    $0e constant EXTI_EM14                      \ [0x0e] EM14
    $0f constant EXTI_EM15                      \ [0x0f] EM15
    $11 constant EXTI_EM17                      \ [0x11] EM17
    $12 constant EXTI_EM18                      \ [0x12] EM18
    $13 constant EXTI_EM19                      \ [0x13] EM19
  [then]


  [ifdef] EXTI_EXTI_C2IMR2_DEF
    \
    \ @brief Contains register bits for configurable events and direct events.
    \ Address offset: 0xD0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant EXTI_IM32                      \ [0x00] IM32
    $01 constant EXTI_IM33                      \ [0x01] IM33
    $02 constant EXTI_IM34                      \ [0x02] IM34
    $03 constant EXTI_IM35                      \ [0x03] IM35
    $04 constant EXTI_IM36                      \ [0x04] IM36
    $05 constant EXTI_IM37                      \ [0x05] IM37
    $06 constant EXTI_IM38                      \ [0x06] IM38
    $07 constant EXTI_IM39                      \ [0x07] IM39
    $08 constant EXTI_IM40                      \ [0x08] IM40
    $09 constant EXTI_IM41                      \ [0x09] IM41
    $0a constant EXTI_IM42                      \ [0x0a] IM42
    $0b constant EXTI_IM43                      \ [0x0b] IM43
    $0c constant EXTI_IM44                      \ [0x0c] IM44
    $0d constant EXTI_IM45                      \ [0x0d] IM45
    $0e constant EXTI_IM46                      \ [0x0e] IM46
    $0f constant EXTI_IM47                      \ [0x0f] IM47
    $10 constant EXTI_IM48                      \ [0x10] IM48
    $11 constant EXTI_IM49                      \ [0x11] IM49
    $12 constant EXTI_IM50                      \ [0x12] IM50
    $13 constant EXTI_IM51                      \ [0x13] IM51
    $14 constant EXTI_IM52                      \ [0x14] IM52
    $15 constant EXTI_IM53                      \ [0x15] IM53
    $16 constant EXTI_IM54                      \ [0x16] IM54
    $17 constant EXTI_IM55                      \ [0x17] IM55
    $18 constant EXTI_IM56                      \ [0x18] IM56
    $19 constant EXTI_IM57                      \ [0x19] IM57
    $1a constant EXTI_IM58                      \ [0x1a] IM58
    $1b constant EXTI_IM59                      \ [0x1b] IM59
    $1c constant EXTI_IM60                      \ [0x1c] IM60
    $1d constant EXTI_IM61                      \ [0x1d] IM61
    $1e constant EXTI_IM62                      \ [0x1e] IM62
    $1f constant EXTI_IM63                      \ [0x1f] IM63
  [then]


  [ifdef] EXTI_EXTI_C2EMR2_DEF
    \
    \ @brief EXTI CPU2 wakeup with event mask register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_C2IMR3_DEF
    \
    \ @brief Contains register bits for configurable events and direct events.
    \ Address offset: 0xE0
    \ Reset value: 0x00000DE9
    \
    $00 constant EXTI_IM64                      \ [0x00] IM64
    $01 constant EXTI_IM65                      \ [0x01] IM65
    $02 constant EXTI_IM66                      \ [0x02] IM66
    $03 constant EXTI_IM67                      \ [0x03] IM67
    $04 constant EXTI_IM68                      \ [0x04] IM68
    $05 constant EXTI_IM69                      \ [0x05] IM69
    $06 constant EXTI_IM70                      \ [0x06] IM70
    $07 constant EXTI_IM71                      \ [0x07] IM71
    $08 constant EXTI_IM72                      \ [0x08] IM72
    $09 constant EXTI_IM73                      \ [0x09] IM73
    $0a constant EXTI_IM74                      \ [0x0a] IM74
    $0b constant EXTI_IM75                      \ [0x0b] IM75
  [then]


  [ifdef] EXTI_EXTI_C2EMR3_DEF
    \
    \ @brief EXTI CPU2 wakeup with event mask register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_EM66                      \ [0x02] EM66
  [then]


  [ifdef] EXTI_EXTI_HWCFGR13_DEF
    \
    \ @brief EXTI hardware configuration register 13
    \ Address offset: 0x3C0
    \ Reset value: 0x050EFFFF
    \
    $00 constant EXTI_TZ                        \ [0x00 : 32] TZ
  [then]


  [ifdef] EXTI_EXTI_HWCFGR12_DEF
    \
    \ @brief EXTI hardware configuration register 12
    \ Address offset: 0x3C4
    \ Reset value: 0x050EFFFF
    \
    $00 constant EXTI_TZ                        \ [0x00 : 32] TZ
  [then]


  [ifdef] EXTI_EXTI_HWCFGR11_DEF
    \
    \ @brief EXTI hardware configuration register 11
    \ Address offset: 0x3C8
    \ Reset value: 0x050EFFFF
    \
    $00 constant EXTI_TZ                        \ [0x00 : 32] TZ
  [then]


  [ifdef] EXTI_EXTI_HWCFGR10_DEF
    \
    \ @brief EXTI hardware configuration register 10
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_HWCFGR9_DEF
    \
    \ @brief EXTI hardware configuration register 9
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_HWCFGR8_DEF
    \
    \ @brief EXTI hardware configuration register 8
    \ Address offset: 0x3D4
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] EXTI_EXTI_HWCFGR7_DEF
    \
    \ @brief EXTI hardware configuration register 7
    \ Address offset: 0x3D8
    \ Reset value: 0x000EFFFF
    \
    $00 constant EXTI_CPUEVENT                  \ [0x00 : 32] CPUEVENT
  [then]


  [ifdef] EXTI_EXTI_HWCFGR6_DEF
    \
    \ @brief EXTI hardware configuration register 6
    \ Address offset: 0x3DC
    \ Reset value: 0x000EFFFF
    \
    $00 constant EXTI_CPUEVENT                  \ [0x00 : 32] CPUEVENT
  [then]


  [ifdef] EXTI_EXTI_HWCFGR5_DEF
    \
    \ @brief EXTI hardware configuration register 5
    \ Address offset: 0x3E0
    \ Reset value: 0x000EFFFF
    \
    $00 constant EXTI_CPUEVENT                  \ [0x00 : 32] CPUEVENT
  [then]


  [ifdef] EXTI_EXTI_HWCFGR4_DEF
    \
    \ @brief EXTI hardware configuration register 4
    \ Address offset: 0x3E4
    \ Reset value: 0x0001FFFF
    \
    $00 constant EXTI_EVENT_TRG                 \ [0x00 : 32] EVENT_TRG
  [then]


  [ifdef] EXTI_EXTI_HWCFGR3_DEF
    \
    \ @brief EXTI hardware configuration register 3
    \ Address offset: 0x3E8
    \ Reset value: 0x0001FFFF
    \
    $00 constant EXTI_EVENT_TRG                 \ [0x00 : 32] EVENT_TRG
  [then]


  [ifdef] EXTI_EXTI_HWCFGR2_DEF
    \
    \ @brief EXTI hardware configuration register 2
    \ Address offset: 0x3EC
    \ Reset value: 0x0001FFFF
    \
    $00 constant EXTI_EVENT_TRG                 \ [0x00 : 32] EVENT_TRG
  [then]


  [ifdef] EXTI_EXTI_HWCFGR1_DEF
    \
    \ @brief EXTI hardware configuration register 1
    \ Address offset: 0x3F0
    \ Reset value: 0x000B214B
    \
    $00 constant EXTI_NBEVENTS                  \ [0x00 : 8] NBEVENTS
    $08 constant EXTI_NBCPUS                    \ [0x08 : 4] NBCPUS
    $0c constant EXTI_CPUEVTEN                  \ [0x0c : 4] CPUEVTEN
    $10 constant EXTI_NBIOPORT                  \ [0x10 : 8] NBIOPORT
  [then]


  [ifdef] EXTI_EXTI_VERR_DEF
    \
    \ @brief EXTI IP version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000030
    \
    $00 constant EXTI_MINREV                    \ [0x00 : 4] MINREV
    $04 constant EXTI_MAJREV                    \ [0x04 : 4] MAJREV
  [then]


  [ifdef] EXTI_EXTI_IPIDR_DEF
    \
    \ @brief EXTI identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000E0001
    \
    $00 constant EXTI_IPID                      \ [0x00 : 32] IPID
  [then]


  [ifdef] EXTI_EXTI_SIDR_DEF
    \
    \ @brief EXTI size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant EXTI_SID                       \ [0x00 : 32] SID
  [then]

  \
  \ @brief EXTI
  \
  $00 constant EXTI_EXTI_RTSR1          \ Contains only register bits for configurable events.
  $04 constant EXTI_EXTI_FTSR1          \ Contains only register bits for configurable events.
  $08 constant EXTI_EXTI_SWIER1         \ Contains only register bits for configurable events.
  $0C constant EXTI_EXTI_RPR1           \ Contains only register bits for configurable events.
  $10 constant EXTI_EXTI_FPR1           \ Contains only register bits for configurable events.
  $14 constant EXTI_EXTI_TZENR1         \ This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
  $20 constant EXTI_EXTI_RTSR2          \ Contains only register bits for configurable events.
  $24 constant EXTI_EXTI_FTSR2          \ Contains only register bits for configurable events.
  $28 constant EXTI_EXTI_SWIER2         \ Contains only register bits for configurable events.
  $2C constant EXTI_EXTI_RPR2           \ Contains only register bits for configurable events.
  $30 constant EXTI_EXTI_FPR2           \ Contains only register bits for configurable events.
  $34 constant EXTI_EXTI_TZENR2         \ This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
  $40 constant EXTI_EXTI_RTSR3          \ Contains only register bits for configurable events.
  $44 constant EXTI_EXTI_FTSR3          \ Contains only register bits for configurable events.
  $48 constant EXTI_EXTI_SWIER3         \ Contains only register bits for configurable events.
  $4C constant EXTI_EXTI_RPR3           \ Contains only register bits for configurable events.
  $50 constant EXTI_EXTI_FPR3           \ Contains only register bits for configurable events.
  $54 constant EXTI_EXTI_TZENR3         \ This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
  $60 constant EXTI_EXTI_EXTICR1        \ EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
  $64 constant EXTI_EXTI_EXTICR2        \ EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
  $68 constant EXTI_EXTI_EXTICR3        \ EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
  $6C constant EXTI_EXTI_EXTICR4        \ EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
  $80 constant EXTI_EXTI_IMR1           \ Contains register bits for configurable events and Direct events.
  $84 constant EXTI_EXTI_EMR1           \ EXTI CPU wakeup with event mask register
  $90 constant EXTI_EXTI_IMR2           \ Contains register bits for configurable events and direct events.
  $94 constant EXTI_EXTI_EMR2           \ EXTI CPU wakeup with event mask register
  $A0 constant EXTI_EXTI_IMR3           \ Contains register bits for configurable events and direct events.
  $A4 constant EXTI_EXTI_EMR3           \ EXTI CPU wakeup with event mask register
  $C0 constant EXTI_EXTI_C2IMR1         \ Contains register bits for configurable events and Direct events.
  $C4 constant EXTI_EXTI_C2EMR1         \ EXTI CPU2 wakeup with event mask register
  $D0 constant EXTI_EXTI_C2IMR2         \ Contains register bits for configurable events and direct events.
  $D4 constant EXTI_EXTI_C2EMR2         \ EXTI CPU2 wakeup with event mask register
  $E0 constant EXTI_EXTI_C2IMR3         \ Contains register bits for configurable events and direct events.
  $E4 constant EXTI_EXTI_C2EMR3         \ EXTI CPU2 wakeup with event mask register
  $3C0 constant EXTI_EXTI_HWCFGR13      \ EXTI hardware configuration register 13
  $3C4 constant EXTI_EXTI_HWCFGR12      \ EXTI hardware configuration register 12
  $3C8 constant EXTI_EXTI_HWCFGR11      \ EXTI hardware configuration register 11
  $3CC constant EXTI_EXTI_HWCFGR10      \ EXTI hardware configuration register 10
  $3D0 constant EXTI_EXTI_HWCFGR9       \ EXTI hardware configuration register 9
  $3D4 constant EXTI_EXTI_HWCFGR8       \ EXTI hardware configuration register 8
  $3D8 constant EXTI_EXTI_HWCFGR7       \ EXTI hardware configuration register 7
  $3DC constant EXTI_EXTI_HWCFGR6       \ EXTI hardware configuration register 6
  $3E0 constant EXTI_EXTI_HWCFGR5       \ EXTI hardware configuration register 5
  $3E4 constant EXTI_EXTI_HWCFGR4       \ EXTI hardware configuration register 4
  $3E8 constant EXTI_EXTI_HWCFGR3       \ EXTI hardware configuration register 3
  $3EC constant EXTI_EXTI_HWCFGR2       \ EXTI hardware configuration register 2
  $3F0 constant EXTI_EXTI_HWCFGR1       \ EXTI hardware configuration register 1
  $3F4 constant EXTI_EXTI_VERR          \ EXTI IP version register
  $3F8 constant EXTI_EXTI_IPIDR         \ EXTI identification register
  $3FC constant EXTI_EXTI_SIDR          \ EXTI size ID register

: EXTI_DEF ; [then]
