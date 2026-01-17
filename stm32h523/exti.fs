\
\ @file exti.fs
\ @brief EXTI address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] EXTI_DEF

  [ifdef] EXTI_EXTI_RTSR1_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RT0                       \ [0x00] Rising trigger event configuration bit of configurable event input x
    $01 constant EXTI_RT1                       \ [0x01] Rising trigger event configuration bit of configurable event input x
    $02 constant EXTI_RT2                       \ [0x02] Rising trigger event configuration bit of configurable event input x
    $03 constant EXTI_RT3                       \ [0x03] Rising trigger event configuration bit of configurable event input x
    $04 constant EXTI_RT4                       \ [0x04] Rising trigger event configuration bit of configurable event input x
    $05 constant EXTI_RT5                       \ [0x05] Rising trigger event configuration bit of configurable event input x
    $06 constant EXTI_RT6                       \ [0x06] Rising trigger event configuration bit of configurable event input x
    $07 constant EXTI_RT7                       \ [0x07] Rising trigger event configuration bit of configurable event input x
    $08 constant EXTI_RT8                       \ [0x08] Rising trigger event configuration bit of configurable event input x
    $09 constant EXTI_RT9                       \ [0x09] Rising trigger event configuration bit of configurable event input x
    $0a constant EXTI_RT10                      \ [0x0a] Rising trigger event configuration bit of configurable event input x
    $0b constant EXTI_RT11                      \ [0x0b] Rising trigger event configuration bit of configurable event input x
    $0c constant EXTI_RT12                      \ [0x0c] Rising trigger event configuration bit of configurable event input x
    $0d constant EXTI_RT13                      \ [0x0d] Rising trigger event configuration bit of configurable event input x
    $0e constant EXTI_RT14                      \ [0x0e] Rising trigger event configuration bit of configurable event input x
    $0f constant EXTI_RT15                      \ [0x0f] Rising trigger event configuration bit of configurable event input x
    $10 constant EXTI_RT16                      \ [0x10] Rising trigger event configuration bit of configurable event input x
  [then]


  [ifdef] EXTI_EXTI_FTSR1_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT0                       \ [0x00] Falling trigger event configuration bit of configurable event input x
    $01 constant EXTI_FT1                       \ [0x01] Falling trigger event configuration bit of configurable event input x
    $02 constant EXTI_FT2                       \ [0x02] Falling trigger event configuration bit of configurable event input x
    $03 constant EXTI_FT3                       \ [0x03] Falling trigger event configuration bit of configurable event input x
    $04 constant EXTI_FT4                       \ [0x04] Falling trigger event configuration bit of configurable event input x
    $05 constant EXTI_FT5                       \ [0x05] Falling trigger event configuration bit of configurable event input x
    $06 constant EXTI_FT6                       \ [0x06] Falling trigger event configuration bit of configurable event input x
    $07 constant EXTI_FT7                       \ [0x07] Falling trigger event configuration bit of configurable event input x
    $08 constant EXTI_FT8                       \ [0x08] Falling trigger event configuration bit of configurable event input x
    $09 constant EXTI_FT9                       \ [0x09] Falling trigger event configuration bit of configurable event input x
    $0a constant EXTI_FT10                      \ [0x0a] Falling trigger event configuration bit of configurable event input x
    $0b constant EXTI_FT11                      \ [0x0b] Falling trigger event configuration bit of configurable event input x
    $0c constant EXTI_FT12                      \ [0x0c] Falling trigger event configuration bit of configurable event input x
    $0d constant EXTI_FT13                      \ [0x0d] Falling trigger event configuration bit of configurable event input x
    $0e constant EXTI_FT14                      \ [0x0e] Falling trigger event configuration bit of configurable event input x
    $0f constant EXTI_FT15                      \ [0x0f] Falling trigger event configuration bit of configurable event input x
    $10 constant EXTI_FT16                      \ [0x10] Falling trigger event configuration bit of configurable event input x
  [then]


  [ifdef] EXTI_EXTI_SWIER1_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI0                      \ [0x00] Software interrupt on event x
    $01 constant EXTI_SWI1                      \ [0x01] Software interrupt on event x
    $02 constant EXTI_SWI2                      \ [0x02] Software interrupt on event x
    $03 constant EXTI_SWI3                      \ [0x03] Software interrupt on event x
    $04 constant EXTI_SWI4                      \ [0x04] Software interrupt on event x
    $05 constant EXTI_SWI5                      \ [0x05] Software interrupt on event x
    $06 constant EXTI_SWI6                      \ [0x06] Software interrupt on event x
    $07 constant EXTI_SWI7                      \ [0x07] Software interrupt on event x
    $08 constant EXTI_SWI8                      \ [0x08] Software interrupt on event x
    $09 constant EXTI_SWI9                      \ [0x09] Software interrupt on event x
    $0a constant EXTI_SWI10                     \ [0x0a] Software interrupt on event x
    $0b constant EXTI_SWI11                     \ [0x0b] Software interrupt on event x
    $0c constant EXTI_SWI12                     \ [0x0c] Software interrupt on event x
    $0d constant EXTI_SWI13                     \ [0x0d] Software interrupt on event x
    $0e constant EXTI_SWI14                     \ [0x0e] Software interrupt on event x
    $0f constant EXTI_SWI15                     \ [0x0f] Software interrupt on event x
    $10 constant EXTI_SWI16                     \ [0x10] Software interrupt on event x
  [then]


  [ifdef] EXTI_EXTI_RPR1_DEF
    \
    \ @brief EXTI rising edge pending register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RPIF0                     \ [0x00] configurable event inputs x rising edge pending bit
    $01 constant EXTI_RPIF1                     \ [0x01] configurable event inputs x rising edge pending bit
    $02 constant EXTI_RPIF2                     \ [0x02] configurable event inputs x rising edge pending bit
    $03 constant EXTI_RPIF3                     \ [0x03] configurable event inputs x rising edge pending bit
    $04 constant EXTI_RPIF4                     \ [0x04] configurable event inputs x rising edge pending bit
    $05 constant EXTI_RPIF5                     \ [0x05] configurable event inputs x rising edge pending bit
    $06 constant EXTI_RPIF6                     \ [0x06] configurable event inputs x rising edge pending bit
    $07 constant EXTI_RPIF7                     \ [0x07] configurable event inputs x rising edge pending bit
    $08 constant EXTI_RPIF8                     \ [0x08] configurable event inputs x rising edge pending bit
    $09 constant EXTI_RPIF9                     \ [0x09] configurable event inputs x rising edge pending bit
    $0a constant EXTI_RPIF10                    \ [0x0a] configurable event inputs x rising edge pending bit
    $0b constant EXTI_RPIF11                    \ [0x0b] configurable event inputs x rising edge pending bit
    $0c constant EXTI_RPIF12                    \ [0x0c] configurable event inputs x rising edge pending bit
    $0d constant EXTI_RPIF13                    \ [0x0d] configurable event inputs x rising edge pending bit
    $0e constant EXTI_RPIF14                    \ [0x0e] configurable event inputs x rising edge pending bit
    $0f constant EXTI_RPIF15                    \ [0x0f] configurable event inputs x rising edge pending bit
    $10 constant EXTI_RPIF16                    \ [0x10] configurable event inputs x rising edge pending bit
  [then]


  [ifdef] EXTI_EXTI_FPR1_DEF
    \
    \ @brief EXTI falling edge pending register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FPIF0                     \ [0x00] configurable event inputs x falling edge pending bit
    $01 constant EXTI_FPIF1                     \ [0x01] configurable event inputs x falling edge pending bit
    $02 constant EXTI_FPIF2                     \ [0x02] configurable event inputs x falling edge pending bit
    $03 constant EXTI_FPIF3                     \ [0x03] configurable event inputs x falling edge pending bit
    $04 constant EXTI_FPIF4                     \ [0x04] configurable event inputs x falling edge pending bit
    $05 constant EXTI_FPIF5                     \ [0x05] configurable event inputs x falling edge pending bit
    $06 constant EXTI_FPIF6                     \ [0x06] configurable event inputs x falling edge pending bit
    $07 constant EXTI_FPIF7                     \ [0x07] configurable event inputs x falling edge pending bit
    $08 constant EXTI_FPIF8                     \ [0x08] configurable event inputs x falling edge pending bit
    $09 constant EXTI_FPIF9                     \ [0x09] configurable event inputs x falling edge pending bit
    $0a constant EXTI_FPIF10                    \ [0x0a] configurable event inputs x falling edge pending bit
    $0b constant EXTI_FPIF11                    \ [0x0b] configurable event inputs x falling edge pending bit
    $0c constant EXTI_FPIF12                    \ [0x0c] configurable event inputs x falling edge pending bit
    $0d constant EXTI_FPIF13                    \ [0x0d] configurable event inputs x falling edge pending bit
    $0e constant EXTI_FPIF14                    \ [0x0e] configurable event inputs x falling edge pending bit
    $0f constant EXTI_FPIF15                    \ [0x0f] configurable event inputs x falling edge pending bit
    $10 constant EXTI_FPIF16                    \ [0x10] configurable event inputs x falling edge pending bit
  [then]


  [ifdef] EXTI_EXTI_SECCFGR1_DEF
    \
    \ @brief EXTI security configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SEC0                      \ [0x00] Security enable on event input x
    $01 constant EXTI_SEC1                      \ [0x01] Security enable on event input x
    $02 constant EXTI_SEC2                      \ [0x02] Security enable on event input x
    $03 constant EXTI_SEC3                      \ [0x03] Security enable on event input x
    $04 constant EXTI_SEC4                      \ [0x04] Security enable on event input x
    $05 constant EXTI_SEC5                      \ [0x05] Security enable on event input x
    $06 constant EXTI_SEC6                      \ [0x06] Security enable on event input x
    $07 constant EXTI_SEC7                      \ [0x07] Security enable on event input x
    $08 constant EXTI_SEC8                      \ [0x08] Security enable on event input x
    $09 constant EXTI_SEC9                      \ [0x09] Security enable on event input x
    $0a constant EXTI_SEC10                     \ [0x0a] Security enable on event input x
    $0b constant EXTI_SEC11                     \ [0x0b] Security enable on event input x
    $0c constant EXTI_SEC12                     \ [0x0c] Security enable on event input x
    $0d constant EXTI_SEC13                     \ [0x0d] Security enable on event input x
    $0e constant EXTI_SEC14                     \ [0x0e] Security enable on event input x
    $0f constant EXTI_SEC15                     \ [0x0f] Security enable on event input x
    $10 constant EXTI_SEC16                     \ [0x10] Security enable on event input x
    $11 constant EXTI_SEC17                     \ [0x11] Security enable on event input x
    $12 constant EXTI_SEC18                     \ [0x12] Security enable on event input x
    $13 constant EXTI_SEC19                     \ [0x13] Security enable on event input x
    $14 constant EXTI_SEC20                     \ [0x14] Security enable on event input x
    $15 constant EXTI_SEC21                     \ [0x15] Security enable on event input x
    $16 constant EXTI_SEC22                     \ [0x16] Security enable on event input x
    $17 constant EXTI_SEC23                     \ [0x17] Security enable on event input x
    $18 constant EXTI_SEC24                     \ [0x18] Security enable on event input x
    $19 constant EXTI_SEC25                     \ [0x19] Security enable on event input x
    $1a constant EXTI_SEC26                     \ [0x1a] Security enable on event input x
    $1b constant EXTI_SEC27                     \ [0x1b] Security enable on event input x
    $1c constant EXTI_SEC28                     \ [0x1c] Security enable on event input x
    $1d constant EXTI_SEC29                     \ [0x1d] Security enable on event input x
    $1e constant EXTI_SEC30                     \ [0x1e] Security enable on event input x
    $1f constant EXTI_SEC31                     \ [0x1f] Security enable on event input x
  [then]


  [ifdef] EXTI_EXTI_PRIVCFGR1_DEF
    \
    \ @brief EXTI privilege configuration register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PRIV0                     \ [0x00] Security enable on event input x
    $01 constant EXTI_PRIV1                     \ [0x01] Security enable on event input x
    $02 constant EXTI_PRIV2                     \ [0x02] Security enable on event input x
    $03 constant EXTI_PRIV3                     \ [0x03] Security enable on event input x
    $04 constant EXTI_PRIV4                     \ [0x04] Security enable on event input x
    $05 constant EXTI_PRIV5                     \ [0x05] Security enable on event input x
    $06 constant EXTI_PRIV6                     \ [0x06] Security enable on event input x
    $07 constant EXTI_PRIV7                     \ [0x07] Security enable on event input x
    $08 constant EXTI_PRIV8                     \ [0x08] Security enable on event input x
    $09 constant EXTI_PRIV9                     \ [0x09] Security enable on event input x
    $0a constant EXTI_PRIV10                    \ [0x0a] Security enable on event input x
    $0b constant EXTI_PRIV11                    \ [0x0b] Security enable on event input x
    $0c constant EXTI_PRIV12                    \ [0x0c] Security enable on event input x
    $0d constant EXTI_PRIV13                    \ [0x0d] Security enable on event input x
    $0e constant EXTI_PRIV14                    \ [0x0e] Security enable on event input x
    $0f constant EXTI_PRIV15                    \ [0x0f] Security enable on event input x
    $10 constant EXTI_PRIV16                    \ [0x10] Security enable on event input x
    $11 constant EXTI_PRIV17                    \ [0x11] Security enable on event input x
    $12 constant EXTI_PRIV18                    \ [0x12] Security enable on event input x
    $13 constant EXTI_PRIV19                    \ [0x13] Security enable on event input x
    $14 constant EXTI_PRIV20                    \ [0x14] Security enable on event input x
    $15 constant EXTI_PRIV21                    \ [0x15] Security enable on event input x
    $16 constant EXTI_PRIV22                    \ [0x16] Security enable on event input x
    $17 constant EXTI_PRIV23                    \ [0x17] Security enable on event input x
    $18 constant EXTI_PRIV24                    \ [0x18] Security enable on event input x
    $19 constant EXTI_PRIV25                    \ [0x19] Security enable on event input x
    $1a constant EXTI_PRIV26                    \ [0x1a] Security enable on event input x
    $1b constant EXTI_PRIV27                    \ [0x1b] Security enable on event input x
    $1c constant EXTI_PRIV28                    \ [0x1c] Security enable on event input x
    $1d constant EXTI_PRIV29                    \ [0x1d] Security enable on event input x
    $1e constant EXTI_PRIV30                    \ [0x1e] Security enable on event input x
    $1f constant EXTI_PRIV31                    \ [0x1f] Security enable on event input x
  [then]


  [ifdef] EXTI_EXTI_RTSR2_DEF
    \
    \ @brief EXTI rising trigger selection register 2
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $0e constant EXTI_RT46                      \ [0x0e] Rising trigger event configuration bit of configurable event input xless thansup>(1)less than/sup>
    $12 constant EXTI_RT50                      \ [0x12] Rising trigger event configuration bit of configurable event input xless thansup>(1)less than/sup>
    $15 constant EXTI_RT53                      \ [0x15] Rising trigger event configuration bit of configurable event input x
  [then]


  [ifdef] EXTI_EXTI_FTSR2_DEF
    \
    \ @brief EXTI falling trigger selection register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $0e constant EXTI_FT46                      \ [0x0e] Falling trigger event configuration bit of configurable event input x less thansup>(1)less than/sup>
    $12 constant EXTI_FT50                      \ [0x12] Falling trigger event configuration bit of configurable event input x less thansup>(1)less than/sup>
    $15 constant EXTI_FT53                      \ [0x15] Falling trigger event configuration bit of configurable event input x
  [then]


  [ifdef] EXTI_EXTI_SWIER2_DEF
    \
    \ @brief EXTI software interrupt event register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $0e constant EXTI_SWI46                     \ [0x0e] Software interrupt on event x
    $12 constant EXTI_SWI50                     \ [0x12] Software interrupt on event x
    $15 constant EXTI_SWI53                     \ [0x15] Software interrupt on event x
  [then]


  [ifdef] EXTI_EXTI_RPR2_DEF
    \
    \ @brief EXTI rising edge pending register 2
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $0e constant EXTI_RPIF46                    \ [0x0e] configurable event inputs x rising edge pending bit
    $12 constant EXTI_RPIF50                    \ [0x12] configurable event inputs x rising edge pending bit
    $15 constant EXTI_RPIF53                    \ [0x15] configurable event inputs x rising edge pending bit
  [then]


  [ifdef] EXTI_EXTI_FPR2_DEF
    \
    \ @brief EXTI falling edge pending register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $0e constant EXTI_FPIF46                    \ [0x0e] configurable event inputs x falling edge pending bit
    $12 constant EXTI_FPIF50                    \ [0x12] configurable event inputs x falling edge pending bit
    $15 constant EXTI_FPIF53                    \ [0x15] configurable event inputs x falling edge pending bit
  [then]


  [ifdef] EXTI_EXTI_SECCFGR2_DEF
    \
    \ @brief EXTI security configuration register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SEC32                     \ [0x00] Security enable on event input x
    $01 constant EXTI_SEC33                     \ [0x01] Security enable on event input x
    $02 constant EXTI_SEC34                     \ [0x02] Security enable on event input x
    $03 constant EXTI_SEC35                     \ [0x03] Security enable on event input x
    $04 constant EXTI_SEC36                     \ [0x04] Security enable on event input x
    $05 constant EXTI_SEC37                     \ [0x05] Security enable on event input x
    $06 constant EXTI_SEC38                     \ [0x06] Security enable on event input x
    $07 constant EXTI_SEC39                     \ [0x07] Security enable on event input x
    $08 constant EXTI_SEC40                     \ [0x08] Security enable on event input x
    $09 constant EXTI_SEC41                     \ [0x09] Security enable on event input x
    $0a constant EXTI_SEC42                     \ [0x0a] Security enable on event input x
    $0b constant EXTI_SEC43                     \ [0x0b] Security enable on event input x
    $0c constant EXTI_SEC44                     \ [0x0c] Security enable on event input x
    $0d constant EXTI_SEC45                     \ [0x0d] Security enable on event input x
    $0e constant EXTI_SEC46                     \ [0x0e] Security enable on event input x
    $0f constant EXTI_SEC47                     \ [0x0f] Security enable on event input x
    $10 constant EXTI_SEC48                     \ [0x10] Security enable on event input x
    $11 constant EXTI_SEC49                     \ [0x11] Security enable on event input x
    $12 constant EXTI_SEC50                     \ [0x12] Security enable on event input x
    $13 constant EXTI_SEC51                     \ [0x13] Security enable on event input x
    $14 constant EXTI_SEC52                     \ [0x14] Security enable on event input x
    $15 constant EXTI_SEC53                     \ [0x15] Security enable on event input x
    $16 constant EXTI_SEC54                     \ [0x16] Security enable on event input x
    $17 constant EXTI_SEC55                     \ [0x17] Security enable on event input x
    $18 constant EXTI_SEC56                     \ [0x18] Security enable on event input x
    $19 constant EXTI_SEC57                     \ [0x19] Security enable on event input x
  [then]


  [ifdef] EXTI_EXTI_PRIVCFGR2_DEF
    \
    \ @brief EXTI privilege configuration register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PRIV32                    \ [0x00] Security enable on event input x
    $01 constant EXTI_PRIV33                    \ [0x01] Security enable on event input x
    $02 constant EXTI_PRIV34                    \ [0x02] Security enable on event input x
    $03 constant EXTI_PRIV35                    \ [0x03] Security enable on event input x
    $04 constant EXTI_PRIV36                    \ [0x04] Security enable on event input x
    $05 constant EXTI_PRIV37                    \ [0x05] Security enable on event input x
    $06 constant EXTI_PRIV38                    \ [0x06] Security enable on event input x
    $07 constant EXTI_PRIV39                    \ [0x07] Security enable on event input x
    $08 constant EXTI_PRIV40                    \ [0x08] Security enable on event input x
    $09 constant EXTI_PRIV41                    \ [0x09] Security enable on event input x
    $0a constant EXTI_PRIV42                    \ [0x0a] Security enable on event input x
    $0b constant EXTI_PRIV43                    \ [0x0b] Security enable on event input x
    $0c constant EXTI_PRIV44                    \ [0x0c] Security enable on event input x
    $0d constant EXTI_PRIV45                    \ [0x0d] Security enable on event input x
    $0e constant EXTI_PRIV46                    \ [0x0e] Security enable on event input x
    $0f constant EXTI_PRIV47                    \ [0x0f] Security enable on event input x
    $10 constant EXTI_PRIV48                    \ [0x10] Security enable on event input x
    $11 constant EXTI_PRIV49                    \ [0x11] Security enable on event input x
    $12 constant EXTI_PRIV50                    \ [0x12] Security enable on event input x
    $13 constant EXTI_PRIV51                    \ [0x13] Security enable on event input x
    $14 constant EXTI_PRIV52                    \ [0x14] Security enable on event input x
    $15 constant EXTI_PRIV53                    \ [0x15] Security enable on event input x
    $16 constant EXTI_PRIV54                    \ [0x16] Security enable on event input x
    $17 constant EXTI_PRIV55                    \ [0x17] Security enable on event input x
    $18 constant EXTI_PRIV56                    \ [0x18] Security enable on event input x
    $19 constant EXTI_PRIV57                    \ [0x19] Security enable on event input x
  [then]


  [ifdef] EXTI_EXTI_EXTICR1_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0                     \ [0x00 : 8] EXTI0 GPIO port selection
    $08 constant EXTI_EXTI1                     \ [0x08 : 8] EXTI1 GPIO port selection
    $10 constant EXTI_EXTI2                     \ [0x10 : 8] EXTI2 GPIO port selection
    $18 constant EXTI_EXTI3                     \ [0x18 : 8] EXTI3 GPIO port selection
  [then]


  [ifdef] EXTI_EXTI_EXTICR4_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI12                    \ [0x00 : 8] EXTI12 GPIO port selection
    $08 constant EXTI_EXTI13                    \ [0x08 : 8] EXTI13 GPIO port selection
    $10 constant EXTI_EXTI14                    \ [0x10 : 8] EXTI14 GPIO port selection
    $18 constant EXTI_EXTI15                    \ [0x18 : 8] EXTI15 GPIO port selection
  [then]


  [ifdef] EXTI_EXTI_EXTICR2_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI4                     \ [0x00 : 8] EXTI4 GPIO port selection
    $08 constant EXTI_EXTI5                     \ [0x08 : 8] EXTI5 GPIO port selection
    $10 constant EXTI_EXTI6                     \ [0x10 : 8] EXTI6 GPIO port selection
    $18 constant EXTI_EXTI7                     \ [0x18 : 8] EXTI7 GPIO port selection
  [then]


  [ifdef] EXTI_EXTI_EXTICR3_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI8                     \ [0x00 : 8] EXTI8 GPIO port selection
    $08 constant EXTI_EXTI9                     \ [0x08 : 8] EXTI9 GPIO port selection
    $10 constant EXTI_EXTI10                    \ [0x10 : 8] EXTI10 GPIO port selection
    $18 constant EXTI_EXTI11                    \ [0x18 : 8] EXTI11 GPIO port selection
  [then]


  [ifdef] EXTI_EXTI_LOCKR_DEF
    \
    \ @brief EXTI lock register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_LOCK                      \ [0x00] Global security and privilege configuration registers (EXTI_SECCFGR and EXTI_PRIVCFGR) lock
  [then]


  [ifdef] EXTI_EXTI_IMR1_DEF
    \
    \ @brief EXTI CPU wake-up with interrupt mask register
    \ Address offset: 0x80
    \ Reset value: 0xFFFE0000
    \
    $00 constant EXTI_IM0                       \ [0x00] CPU wake-up with interrupt mask on event input x
    $01 constant EXTI_IM1                       \ [0x01] CPU wake-up with interrupt mask on event input x
    $02 constant EXTI_IM2                       \ [0x02] CPU wake-up with interrupt mask on event input x
    $03 constant EXTI_IM3                       \ [0x03] CPU wake-up with interrupt mask on event input x
    $04 constant EXTI_IM4                       \ [0x04] CPU wake-up with interrupt mask on event input x
    $05 constant EXTI_IM5                       \ [0x05] CPU wake-up with interrupt mask on event input x
    $06 constant EXTI_IM6                       \ [0x06] CPU wake-up with interrupt mask on event input x
    $07 constant EXTI_IM7                       \ [0x07] CPU wake-up with interrupt mask on event input x
    $08 constant EXTI_IM8                       \ [0x08] CPU wake-up with interrupt mask on event input x
    $09 constant EXTI_IM9                       \ [0x09] CPU wake-up with interrupt mask on event input x
    $0a constant EXTI_IM10                      \ [0x0a] CPU wake-up with interrupt mask on event input x
    $0b constant EXTI_IM11                      \ [0x0b] CPU wake-up with interrupt mask on event input x
    $0c constant EXTI_IM12                      \ [0x0c] CPU wake-up with interrupt mask on event input x
    $0d constant EXTI_IM13                      \ [0x0d] CPU wake-up with interrupt mask on event input x
    $0e constant EXTI_IM14                      \ [0x0e] CPU wake-up with interrupt mask on event input x
    $0f constant EXTI_IM15                      \ [0x0f] CPU wake-up with interrupt mask on event input x
    $10 constant EXTI_IM16                      \ [0x10] CPU wake-up with interrupt mask on event input x
    $11 constant EXTI_IM17                      \ [0x11] CPU wake-up with interrupt mask on event input x
    $12 constant EXTI_IM18                      \ [0x12] CPU wake-up with interrupt mask on event input x
    $13 constant EXTI_IM19                      \ [0x13] CPU wake-up with interrupt mask on event input x
    $14 constant EXTI_IM20                      \ [0x14] CPU wake-up with interrupt mask on event input x
    $15 constant EXTI_IM21                      \ [0x15] CPU wake-up with interrupt mask on event input x
    $16 constant EXTI_IM22                      \ [0x16] CPU wake-up with interrupt mask on event input x
    $17 constant EXTI_IM23                      \ [0x17] CPU wake-up with interrupt mask on event input x
    $18 constant EXTI_IM24                      \ [0x18] CPU wake-up with interrupt mask on event input x
    $19 constant EXTI_IM25                      \ [0x19] CPU wake-up with interrupt mask on event input x
    $1a constant EXTI_IM26                      \ [0x1a] CPU wake-up with interrupt mask on event input x
    $1b constant EXTI_IM27                      \ [0x1b] CPU wake-up with interrupt mask on event input x
    $1c constant EXTI_IM28                      \ [0x1c] CPU wake-up with interrupt mask on event input x
    $1d constant EXTI_IM29                      \ [0x1d] CPU wake-up with interrupt mask on event input x
    $1e constant EXTI_IM30                      \ [0x1e] CPU wake-up with interrupt mask on event input x
    $1f constant EXTI_IM31                      \ [0x1f] CPU wake-up with interrupt mask on event input x
  [then]


  [ifdef] EXTI_EXTI_EMR1_DEF
    \
    \ @brief EXTI CPU wake-up with event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] CPU wake-up with event generation mask on event input x
    $01 constant EXTI_EM1                       \ [0x01] CPU wake-up with event generation mask on event input x
    $02 constant EXTI_EM2                       \ [0x02] CPU wake-up with event generation mask on event input x
    $03 constant EXTI_EM3                       \ [0x03] CPU wake-up with event generation mask on event input x
    $04 constant EXTI_EM4                       \ [0x04] CPU wake-up with event generation mask on event input x
    $05 constant EXTI_EM5                       \ [0x05] CPU wake-up with event generation mask on event input x
    $06 constant EXTI_EM6                       \ [0x06] CPU wake-up with event generation mask on event input x
    $07 constant EXTI_EM7                       \ [0x07] CPU wake-up with event generation mask on event input x
    $08 constant EXTI_EM8                       \ [0x08] CPU wake-up with event generation mask on event input x
    $09 constant EXTI_EM9                       \ [0x09] CPU wake-up with event generation mask on event input x
    $0a constant EXTI_EM10                      \ [0x0a] CPU wake-up with event generation mask on event input x
    $0b constant EXTI_EM11                      \ [0x0b] CPU wake-up with event generation mask on event input x
    $0c constant EXTI_EM12                      \ [0x0c] CPU wake-up with event generation mask on event input x
    $0d constant EXTI_EM13                      \ [0x0d] CPU wake-up with event generation mask on event input x
    $0e constant EXTI_EM14                      \ [0x0e] CPU wake-up with event generation mask on event input x
    $0f constant EXTI_EM15                      \ [0x0f] CPU wake-up with event generation mask on event input x
    $10 constant EXTI_EM16                      \ [0x10] CPU wake-up with event generation mask on event input x
    $11 constant EXTI_EM17                      \ [0x11] CPU wake-up with event generation mask on event input x
    $12 constant EXTI_EM18                      \ [0x12] CPU wake-up with event generation mask on event input x
    $13 constant EXTI_EM19                      \ [0x13] CPU wake-up with event generation mask on event input x
    $14 constant EXTI_EM20                      \ [0x14] CPU wake-up with event generation mask on event input x
    $15 constant EXTI_EM21                      \ [0x15] CPU wake-up with event generation mask on event input x
    $16 constant EXTI_EM22                      \ [0x16] CPU wake-up with event generation mask on event input x
    $17 constant EXTI_EM23                      \ [0x17] CPU wake-up with event generation mask on event input x
    $18 constant EXTI_EM24                      \ [0x18] CPU wake-up with event generation mask on event input x
    $19 constant EXTI_EM25                      \ [0x19] CPU wake-up with event generation mask on event input x
    $1a constant EXTI_EM26                      \ [0x1a] CPU wake-up with event generation mask on event input x
    $1b constant EXTI_EM27                      \ [0x1b] CPU wake-up with event generation mask on event input x
    $1c constant EXTI_EM28                      \ [0x1c] CPU wake-up with event generation mask on event input x
    $1d constant EXTI_EM29                      \ [0x1d] CPU wake-up with event generation mask on event input x
    $1e constant EXTI_EM30                      \ [0x1e] CPU wake-up with event generation mask on event input x
    $1f constant EXTI_EM31                      \ [0x1f] CPU wake-up with event generation mask on event input x
  [then]


  [ifdef] EXTI_EXTI_IMR2_DEF
    \
    \ @brief EXTI CPU wake-up with interrupt mask register 2
    \ Address offset: 0x90
    \ Reset value: 0x07DBBFFF
    \
    $00 constant EXTI_IM32                      \ [0x00] CPU wake-up with interrupt mask on event input x
    $01 constant EXTI_IM33                      \ [0x01] CPU wake-up with interrupt mask on event input x
    $02 constant EXTI_IM34                      \ [0x02] CPU wake-up with interrupt mask on event input x
    $03 constant EXTI_IM35                      \ [0x03] CPU wake-up with interrupt mask on event input x
    $04 constant EXTI_IM36                      \ [0x04] CPU wake-up with interrupt mask on event input x
    $05 constant EXTI_IM37                      \ [0x05] CPU wake-up with interrupt mask on event input x
    $06 constant EXTI_IM38                      \ [0x06] CPU wake-up with interrupt mask on event input x
    $07 constant EXTI_IM39                      \ [0x07] CPU wake-up with interrupt mask on event input x
    $08 constant EXTI_IM40                      \ [0x08] CPU wake-up with interrupt mask on event input x
    $09 constant EXTI_IM41                      \ [0x09] CPU wake-up with interrupt mask on event input x
    $0a constant EXTI_IM42                      \ [0x0a] CPU wake-up with interrupt mask on event input x
    $0b constant EXTI_IM43                      \ [0x0b] CPU wake-up with interrupt mask on event input x
    $0c constant EXTI_IM44                      \ [0x0c] CPU wake-up with interrupt mask on event input x
    $0d constant EXTI_IM45                      \ [0x0d] CPU wake-up with interrupt mask on event input x
    $0e constant EXTI_IM46                      \ [0x0e] CPU wake-up with interrupt mask on event input x
    $0f constant EXTI_IM47                      \ [0x0f] CPU wake-up with interrupt mask on event input x
    $10 constant EXTI_IM48                      \ [0x10] CPU wake-up with interrupt mask on event input x
    $11 constant EXTI_IM49                      \ [0x11] CPU wake-up with interrupt mask on event input x
    $12 constant EXTI_IM50                      \ [0x12] CPU wake-up with interrupt mask on event input x
    $13 constant EXTI_IM51                      \ [0x13] CPU wake-up with interrupt mask on event input x
    $14 constant EXTI_IM52                      \ [0x14] CPU wake-up with interrupt mask on event input x
    $15 constant EXTI_IM53                      \ [0x15] CPU wake-up with interrupt mask on event input x
    $16 constant EXTI_IM54                      \ [0x16] CPU wake-up with interrupt mask on event input x
    $17 constant EXTI_IM55                      \ [0x17] CPU wake-up with interrupt mask on event input x
    $18 constant EXTI_IM56                      \ [0x18] CPU wake-up with interrupt mask on event input x
    $19 constant EXTI_IM57                      \ [0x19] CPU wake-up with interrupt mask on event input x
    $1a constant EXTI_IM58                      \ [0x1a] CPU wake-up with interrupt mask on event input x
  [then]


  [ifdef] EXTI_EXTI_EMR2_DEF
    \
    \ @brief EXTI CPU wake-up with event mask register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM32                      \ [0x00] CPU wake-up with event generation mask on event input x
    $01 constant EXTI_EM33                      \ [0x01] CPU wake-up with event generation mask on event input x
    $02 constant EXTI_EM34                      \ [0x02] CPU wake-up with event generation mask on event input x
    $03 constant EXTI_EM35                      \ [0x03] CPU wake-up with event generation mask on event input x
    $04 constant EXTI_EM36                      \ [0x04] CPU wake-up with event generation mask on event input x
    $05 constant EXTI_EM37                      \ [0x05] CPU wake-up with event generation mask on event input x
    $06 constant EXTI_EM38                      \ [0x06] CPU wake-up with event generation mask on event input x
    $07 constant EXTI_EM39                      \ [0x07] CPU wake-up with event generation mask on event input x
    $08 constant EXTI_EM40                      \ [0x08] CPU wake-up with event generation mask on event input x
    $09 constant EXTI_EM41                      \ [0x09] CPU wake-up with event generation mask on event input x
    $0a constant EXTI_EM42                      \ [0x0a] CPU wake-up with event generation mask on event input x
    $0b constant EXTI_EM43                      \ [0x0b] CPU wake-up with event generation mask on event input x
    $0c constant EXTI_EM44                      \ [0x0c] CPU wake-up with event generation mask on event input x
    $0d constant EXTI_EM45                      \ [0x0d] CPU wake-up with event generation mask on event input x
    $0e constant EXTI_EM46                      \ [0x0e] CPU wake-up with event generation mask on event input x
    $0f constant EXTI_EM47                      \ [0x0f] CPU wake-up with event generation mask on event input x
    $10 constant EXTI_EM48                      \ [0x10] CPU wake-up with event generation mask on event input x
    $11 constant EXTI_EM49                      \ [0x11] CPU wake-up with event generation mask on event input x
    $12 constant EXTI_EM50                      \ [0x12] CPU wake-up with event generation mask on event input x
    $13 constant EXTI_EM51                      \ [0x13] CPU wake-up with event generation mask on event input x
    $14 constant EXTI_EM52                      \ [0x14] CPU wake-up with event generation mask on event input x
    $15 constant EXTI_EM53                      \ [0x15] CPU wake-up with event generation mask on event input x
    $16 constant EXTI_EM54                      \ [0x16] CPU wake-up with event generation mask on event input x
    $17 constant EXTI_EM55                      \ [0x17] CPU wake-up with event generation mask on event input x
    $18 constant EXTI_EM56                      \ [0x18] CPU wake-up with event generation mask on event input x
    $19 constant EXTI_EM57                      \ [0x19] CPU wake-up with event generation mask on event input x
    $1a constant EXTI_EM58                      \ [0x1a] CPU wake-up with event generation mask on event input x
  [then]

  \
  \ @brief EXTI address block description
  \
  $00 constant EXTI_EXTI_RTSR1          \ EXTI rising trigger selection register
  $04 constant EXTI_EXTI_FTSR1          \ EXTI falling trigger selection register
  $08 constant EXTI_EXTI_SWIER1         \ EXTI software interrupt event register
  $0C constant EXTI_EXTI_RPR1           \ EXTI rising edge pending register
  $10 constant EXTI_EXTI_FPR1           \ EXTI falling edge pending register
  $14 constant EXTI_EXTI_SECCFGR1       \ EXTI security configuration register
  $18 constant EXTI_EXTI_PRIVCFGR1      \ EXTI privilege configuration register
  $20 constant EXTI_EXTI_RTSR2          \ EXTI rising trigger selection register 2
  $24 constant EXTI_EXTI_FTSR2          \ EXTI falling trigger selection register 2
  $28 constant EXTI_EXTI_SWIER2         \ EXTI software interrupt event register 2
  $2C constant EXTI_EXTI_RPR2           \ EXTI rising edge pending register 2
  $30 constant EXTI_EXTI_FPR2           \ EXTI falling edge pending register 2
  $34 constant EXTI_EXTI_SECCFGR2       \ EXTI security configuration register 2
  $38 constant EXTI_EXTI_PRIVCFGR2      \ EXTI privilege configuration register 2
  $60 constant EXTI_EXTI_EXTICR1        \ EXTI external interrupt selection register
  $60 constant EXTI_EXTI_EXTICR4        \ EXTI external interrupt selection register
  $64 constant EXTI_EXTI_EXTICR2        \ EXTI external interrupt selection register
  $68 constant EXTI_EXTI_EXTICR3        \ EXTI external interrupt selection register
  $70 constant EXTI_EXTI_LOCKR          \ EXTI lock register
  $80 constant EXTI_EXTI_IMR1           \ EXTI CPU wake-up with interrupt mask register
  $84 constant EXTI_EXTI_EMR1           \ EXTI CPU wake-up with event mask register
  $90 constant EXTI_EXTI_IMR2           \ EXTI CPU wake-up with interrupt mask register 2
  $94 constant EXTI_EXTI_EMR2           \ EXTI CPU wake-up with event mask register 2

: EXTI_DEF ; [then]
