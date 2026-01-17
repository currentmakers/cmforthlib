\
\ @file exti.fs
\ @brief Extended interrupts and event controller
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
    $14 constant EXTI_RT20                      \ [0x14] Rising trigger event configuration bit of configurable event input x
    $15 constant EXTI_RT21                      \ [0x15] Rising trigger event configuration bit of configurable event input x
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
    $14 constant EXTI_FT20                      \ [0x14] Falling trigger event configuration bit of configurable event input x
    $15 constant EXTI_FT21                      \ [0x15] Falling trigger event configuration bit of configurable event input x
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
    $14 constant EXTI_SWI20                     \ [0x14] Software interrupt on event x
    $15 constant EXTI_SWI21                     \ [0x15] Software interrupt on event x
  [then]


  [ifdef] EXTI_EXTI_RPR1_DEF
    \
    \ @brief EXTI rising edge pending register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RPIF0                     \ [0x00] Configurable event input x rising edge pending bit
    $01 constant EXTI_RPIF1                     \ [0x01] Configurable event input x rising edge pending bit
    $02 constant EXTI_RPIF2                     \ [0x02] Configurable event input x rising edge pending bit
    $03 constant EXTI_RPIF3                     \ [0x03] Configurable event input x rising edge pending bit
    $04 constant EXTI_RPIF4                     \ [0x04] Configurable event input x rising edge pending bit
    $05 constant EXTI_RPIF5                     \ [0x05] Configurable event input x rising edge pending bit
    $06 constant EXTI_RPIF6                     \ [0x06] Configurable event input x rising edge pending bit
    $07 constant EXTI_RPIF7                     \ [0x07] Configurable event input x rising edge pending bit
    $08 constant EXTI_RPIF8                     \ [0x08] Configurable event input x rising edge pending bit
    $09 constant EXTI_RPIF9                     \ [0x09] Configurable event input x rising edge pending bit
    $0a constant EXTI_RPIF10                    \ [0x0a] Configurable event input x rising edge pending bit
    $0b constant EXTI_RPIF11                    \ [0x0b] Configurable event input x rising edge pending bit
    $0c constant EXTI_RPIF12                    \ [0x0c] Configurable event input x rising edge pending bit
    $0d constant EXTI_RPIF13                    \ [0x0d] Configurable event input x rising edge pending bit
    $0e constant EXTI_RPIF14                    \ [0x0e] Configurable event input x rising edge pending bit
    $0f constant EXTI_RPIF15                    \ [0x0f] Configurable event input x rising edge pending bit
    $14 constant EXTI_RPIF20                    \ [0x14] Configurable event input x rising edge pending bit
    $15 constant EXTI_RPIF21                    \ [0x15] Configurable event input x rising edge pending bit
  [then]


  [ifdef] EXTI_EXTI_FPR1_DEF
    \
    \ @brief EXTI falling edge pending register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FPIF0                     \ [0x00] Configurable event input x rising edge pending bit
    $01 constant EXTI_FPIF1                     \ [0x01] Configurable event input x rising edge pending bit
    $02 constant EXTI_FPIF2                     \ [0x02] Configurable event input x rising edge pending bit
    $03 constant EXTI_FPIF3                     \ [0x03] Configurable event input x rising edge pending bit
    $04 constant EXTI_FPIF4                     \ [0x04] Configurable event input x rising edge pending bit
    $05 constant EXTI_FPIF5                     \ [0x05] Configurable event input x rising edge pending bit
    $06 constant EXTI_FPIF6                     \ [0x06] Configurable event input x rising edge pending bit
    $07 constant EXTI_FPIF7                     \ [0x07] Configurable event input x rising edge pending bit
    $08 constant EXTI_FPIF8                     \ [0x08] Configurable event input x rising edge pending bit
    $09 constant EXTI_FPIF9                     \ [0x09] Configurable event input x rising edge pending bit
    $0a constant EXTI_FPIF10                    \ [0x0a] Configurable event input x rising edge pending bit
    $0b constant EXTI_FPIF11                    \ [0x0b] Configurable event input x rising edge pending bit
    $0c constant EXTI_FPIF12                    \ [0x0c] Configurable event input x rising edge pending bit
    $0d constant EXTI_FPIF13                    \ [0x0d] Configurable event input x rising edge pending bit
    $0e constant EXTI_FPIF14                    \ [0x0e] Configurable event input x rising edge pending bit
    $0f constant EXTI_FPIF15                    \ [0x0f] Configurable event input x rising edge pending bit
    $14 constant EXTI_FPIF20                    \ [0x14] configurable event input x falling edge pending bit
    $15 constant EXTI_FPIF21                    \ [0x15] configurable event input x falling edge pending bit
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
    $00 constant EXTI_PRIV0                     \ [0x00] Privilege enable on event input x
    $01 constant EXTI_PRIV1                     \ [0x01] Privilege enable on event input x
    $02 constant EXTI_PRIV2                     \ [0x02] Privilege enable on event input x
    $03 constant EXTI_PRIV3                     \ [0x03] Privilege enable on event input x
    $04 constant EXTI_PRIV4                     \ [0x04] Privilege enable on event input x
    $05 constant EXTI_PRIV5                     \ [0x05] Privilege enable on event input x
    $06 constant EXTI_PRIV6                     \ [0x06] Privilege enable on event input x
    $07 constant EXTI_PRIV7                     \ [0x07] Privilege enable on event input x
    $08 constant EXTI_PRIV8                     \ [0x08] Privilege enable on event input x
    $09 constant EXTI_PRIV9                     \ [0x09] Privilege enable on event input x
    $0a constant EXTI_PRIV10                    \ [0x0a] Privilege enable on event input x
    $0b constant EXTI_PRIV11                    \ [0x0b] Privilege enable on event input x
    $0c constant EXTI_PRIV12                    \ [0x0c] Privilege enable on event input x
    $0d constant EXTI_PRIV13                    \ [0x0d] Privilege enable on event input x
    $0e constant EXTI_PRIV14                    \ [0x0e] Privilege enable on event input x
    $0f constant EXTI_PRIV15                    \ [0x0f] Privilege enable on event input x
    $11 constant EXTI_PRIV17                    \ [0x11] Privilege enable on event input x
    $12 constant EXTI_PRIV18                    \ [0x12] Privilege enable on event input x
    $13 constant EXTI_PRIV19                    \ [0x13] Privilege enable on event input x
    $14 constant EXTI_PRIV20                    \ [0x14] Privilege enable on event input x
    $15 constant EXTI_PRIV21                    \ [0x15] Privilege enable on event input x
    $16 constant EXTI_PRIV22                    \ [0x16] Privilege enable on event input x
    $17 constant EXTI_PRIV23                    \ [0x17] Privilege enable on event input x
    $18 constant EXTI_PRIV24                    \ [0x18] Privilege enable on event input x
    $19 constant EXTI_PRIV25                    \ [0x19] Privilege enable on event input x
    $1a constant EXTI_PRIV26                    \ [0x1a] Privilege enable on event input x
    $1b constant EXTI_PRIV27                    \ [0x1b] Privilege enable on event input x
    $1c constant EXTI_PRIV28                    \ [0x1c] Privilege enable on event input x
    $1d constant EXTI_PRIV29                    \ [0x1d] Privilege enable on event input x
    $1e constant EXTI_PRIV30                    \ [0x1e] Privilege enable on event input x
    $1f constant EXTI_PRIV31                    \ [0x1f] Privilege enable on event input x
  [then]


  [ifdef] EXTI_EXTI_RTSR2_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $07 constant EXTI_RT39                      \ [0x07] Rising trigger event configuration bit of configurable event input x
    $08 constant EXTI_RT40                      \ [0x08] Rising trigger event configuration bit of configurable event input x
    $13 constant EXTI_RT51                      \ [0x13] Rising trigger event configuration bit of configurable event input 51
    $16 constant EXTI_RT54                      \ [0x16] Rising trigger event configuration bit of configurable event input 54
    $18 constant EXTI_RT56                      \ [0x18] Rising trigger event configuration bit of configurable event input 56
  [then]


  [ifdef] EXTI_EXTI_FTSR2_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $07 constant EXTI_FT39                      \ [0x07] Falling trigger event configuration bit of configurable event input x
    $08 constant EXTI_FT40                      \ [0x08] Falling trigger event configuration bit of configurable event input x
    $13 constant EXTI_FT51                      \ [0x13] Falling trigger event configuration bit of configurable event input 51
    $16 constant EXTI_FT54                      \ [0x16] Falling trigger event configuration bit of configurable event input 54
    $18 constant EXTI_FT56                      \ [0x18] Falling trigger event configuration bit of configurable event input 56
  [then]


  [ifdef] EXTI_EXTI_SWIER2_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $07 constant EXTI_SWI39                     \ [0x07] Software interrupt on event x
    $08 constant EXTI_SWI40                     \ [0x08] Software interrupt on event x
    $13 constant EXTI_SWI51                     \ [0x13] Software interrupt on event 51
    $16 constant EXTI_SWI54                     \ [0x16] Software interrupt on event 54
    $18 constant EXTI_SWI56                     \ [0x18] Software interrupt on event 56
  [then]


  [ifdef] EXTI_EXTI_RPR2_DEF
    \
    \ @brief EXTI rising edge pending register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $07 constant EXTI_RPIF39                    \ [0x07] Configurable event input x rising edge pending bit
    $08 constant EXTI_RPIF40                    \ [0x08] Configurable event input x rising edge pending bit
    $13 constant EXTI_RPIF51                    \ [0x13] Configurable event input 51 rising edge pending bit
    $16 constant EXTI_RPIF54                    \ [0x16] Configurable event input 54 rising edge pending bit
    $18 constant EXTI_RPIF56                    \ [0x18] Configurable event input 56 rising edge pending bit
  [then]


  [ifdef] EXTI_EXTI_FPR2_DEF
    \
    \ @brief EXTI falling edge pending register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $07 constant EXTI_FPIF39                    \ [0x07] Configurable event input x falling edge pending bit
    $08 constant EXTI_FPIF40                    \ [0x08] Configurable event input x falling edge pending bit
    $13 constant EXTI_FPIF51                    \ [0x13] Configurable event input 51 falling edge pending bit
    $16 constant EXTI_FPIF54                    \ [0x16] Configurable event input 54 falling edge pending bit
    $18 constant EXTI_FPIF56                    \ [0x18] Configurable event input 56 falling edge pending bit
  [then]


  [ifdef] EXTI_EXTI_SECCFGR2_DEF
    \
    \ @brief EXTI security enable register
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
    $1a constant EXTI_SEC58                     \ [0x1a] Security enable on event input x
    $1c constant EXTI_SEC60                     \ [0x1c] Security enable on event input x
    $1d constant EXTI_SEC61                     \ [0x1d] Security enable on event input x
    $1e constant EXTI_SEC62                     \ [0x1e] Security enable on event input x
    $1f constant EXTI_SEC63                     \ [0x1f] Security enable on event input x
  [then]


  [ifdef] EXTI_EXTI_PRIVCFGR2_DEF
    \
    \ @brief EXTI privilege enable register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PRIV32                    \ [0x00] Privilege enable on event input x
    $01 constant EXTI_PRIV33                    \ [0x01] Privilege enable on event input x
    $02 constant EXTI_PRIV34                    \ [0x02] Privilege enable on event input x
    $03 constant EXTI_PRIV35                    \ [0x03] Privilege enable on event input x
    $04 constant EXTI_PRIV36                    \ [0x04] Privilege enable on event input x
    $05 constant EXTI_PRIV37                    \ [0x05] Privilege enable on event input x
    $06 constant EXTI_PRIV38                    \ [0x06] Privilege enable on event input x
    $07 constant EXTI_PRIV39                    \ [0x07] Privilege enable on event input x
    $08 constant EXTI_PRIV40                    \ [0x08] Privilege enable on event input x
    $09 constant EXTI_PRIV41                    \ [0x09] Privilege enable on event input x
    $0a constant EXTI_PRIV42                    \ [0x0a] Privilege enable on event input x
    $0b constant EXTI_PRIV43                    \ [0x0b] Privilege enable on event input x
    $0c constant EXTI_PRIV44                    \ [0x0c] Privilege enable on event input x
    $0d constant EXTI_PRIV45                    \ [0x0d] Privilege enable on event input x
    $0e constant EXTI_PRIV46                    \ [0x0e] Privilege enable on event input x
    $0f constant EXTI_PRIV47                    \ [0x0f] Privilege enable on event input x
    $10 constant EXTI_PRIV48                    \ [0x10] Privilege enable on event input x
    $11 constant EXTI_PRIV49                    \ [0x11] Privilege enable on event input x
    $12 constant EXTI_PRIV50                    \ [0x12] Privilege enable on event input x
    $13 constant EXTI_PRIV51                    \ [0x13] Privilege enable on event input x
    $14 constant EXTI_PRIV52                    \ [0x14] Privilege enable on event input x
    $15 constant EXTI_PRIV53                    \ [0x15] Privilege enable on event input x
    $16 constant EXTI_PRIV54                    \ [0x16] Privilege enable on event input x
    $17 constant EXTI_PRIV55                    \ [0x17] Privilege enable on event input x
    $18 constant EXTI_PRIV56                    \ [0x18] Privilege enable on event input x
    $19 constant EXTI_PRIV57                    \ [0x19] Privilege enable on event input x
    $1a constant EXTI_PRIV58                    \ [0x1a] Privilege enable on event input x
    $1c constant EXTI_PRIV60                    \ [0x1c] Privilege enable on event input x
    $1d constant EXTI_PRIV61                    \ [0x1d] Privilege enable on event input x
    $1e constant EXTI_PRIV62                    \ [0x1e] Privilege enable on event input x
    $1f constant EXTI_PRIV63                    \ [0x1f] Privilege enable on event input x
  [then]


  [ifdef] EXTI_EXTI_RTSR3_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_RT66                      \ [0x02] Rising trigger event configuration bit of configurable event input 66
    $04 constant EXTI_RT68                      \ [0x04] Rising trigger event configuration bit of configurable event input x
    $05 constant EXTI_RT69                      \ [0x05] Rising trigger event configuration bit of configurable event input x
    $06 constant EXTI_RT70                      \ [0x06] Rising trigger event configuration bit of configurable event input x
    $07 constant EXTI_RT71                      \ [0x07] Rising trigger event configuration bit of configurable event input x
    $08 constant EXTI_RT72                      \ [0x08] Rising trigger event configuration bit of configurable event input x
    $09 constant EXTI_RT73                      \ [0x09] Rising trigger event configuration bit of configurable event input x
    $0a constant EXTI_RT74                      \ [0x0a] Rising trigger event configuration bit of configurable event input x
  [then]


  [ifdef] EXTI_EXTI_FTSR3_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_FT66                      \ [0x02] Falling trigger event configuration bit of configurable event input 66
    $04 constant EXTI_FT68                      \ [0x04] Falling trigger event configuration bit of configurable event input x
    $05 constant EXTI_FT69                      \ [0x05] Falling trigger event configuration bit of configurable event input x
    $06 constant EXTI_FT70                      \ [0x06] Falling trigger event configuration bit of configurable event input x
    $07 constant EXTI_FT71                      \ [0x07] Falling trigger event configuration bit of configurable event input x
    $08 constant EXTI_FT72                      \ [0x08] Falling trigger event configuration bit of configurable event input x
    $09 constant EXTI_FT73                      \ [0x09] Falling trigger event configuration bit of configurable event input x
    $0a constant EXTI_FT74                      \ [0x0a] Falling trigger event configuration bit of configurable event input x
  [then]


  [ifdef] EXTI_EXTI_SWIER3_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_SWI66                     \ [0x02] Software interrupt on event 66
    $04 constant EXTI_SWI68                     \ [0x04] Software interrupt on event x
    $05 constant EXTI_SWI69                     \ [0x05] Software interrupt on event x
    $06 constant EXTI_SWI70                     \ [0x06] Software interrupt on event x
    $07 constant EXTI_SWI71                     \ [0x07] Software interrupt on event x
    $08 constant EXTI_SWI72                     \ [0x08] Software interrupt on event x
    $09 constant EXTI_SWI73                     \ [0x09] Software interrupt on event x
    $0a constant EXTI_SWI74                     \ [0x0a] Software interrupt on event x
  [then]


  [ifdef] EXTI_EXTI_RPR3_DEF
    \
    \ @brief EXTI rising edge pending register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_RPIF66                    \ [0x02] configurable event input 66rising edge pending bit
    $04 constant EXTI_RPIF68                    \ [0x04] configurable event input x rising edge pending bit
    $05 constant EXTI_RPIF69                    \ [0x05] configurable event input x rising edge pending bit
    $06 constant EXTI_RPIF70                    \ [0x06] configurable event input x rising edge pending bit
    $07 constant EXTI_RPIF71                    \ [0x07] configurable event input x rising edge pending bit
    $08 constant EXTI_RPIF72                    \ [0x08] configurable event input x rising edge pending bit
    $09 constant EXTI_RPIF73                    \ [0x09] configurable event input x rising edge pending bit
    $0a constant EXTI_RPIF74                    \ [0x0a] configurable event input x rising edge pending bit
  [then]


  [ifdef] EXTI_EXTI_FPR3_DEF
    \
    \ @brief EXTI falling edge pending register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_FPIF66                    \ [0x02] configurable event input 66 falling edge pending bit
    $04 constant EXTI_FPIF68                    \ [0x04] configurable event input x falling edge pending bit
    $05 constant EXTI_FPIF69                    \ [0x05] configurable event input x falling edge pending bit
    $06 constant EXTI_FPIF70                    \ [0x06] configurable event input x falling edge pending bit
    $07 constant EXTI_FPIF71                    \ [0x07] configurable event input x falling edge pending bit
    $08 constant EXTI_FPIF72                    \ [0x08] configurable event input x falling edge pending bit
    $09 constant EXTI_FPIF73                    \ [0x09] configurable event input x falling edge pending bit
    $0a constant EXTI_FPIF74                    \ [0x0a] configurable event input x falling edge pending bit
  [then]


  [ifdef] EXTI_EXTI_SECCFGR3_DEF
    \
    \ @brief EXTI security enable register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SEC64                     \ [0x00] Security enable on event input x
    $01 constant EXTI_SEC65                     \ [0x01] Security enable on event input x
    $02 constant EXTI_SEC66                     \ [0x02] Security enable on event input x
    $04 constant EXTI_SEC68                     \ [0x04] Security enable on event input x
    $05 constant EXTI_SEC69                     \ [0x05] Security enable on event input x
    $06 constant EXTI_SEC70                     \ [0x06] Security enable on event input x
    $07 constant EXTI_SEC71                     \ [0x07] Security enable on event input x
    $08 constant EXTI_SEC72                     \ [0x08] Security enable on event input x
    $09 constant EXTI_SEC73                     \ [0x09] Security enable on event input x
    $0a constant EXTI_SEC74                     \ [0x0a] Security enable on event input x
    $0d constant EXTI_SEC77                     \ [0x0d] Security enable on event input 77
  [then]


  [ifdef] EXTI_EXTI_PRIVCFGR3_DEF
    \
    \ @brief EXTI privilege enable register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PRIV64                    \ [0x00] Privilege enable on event input x
    $01 constant EXTI_PRIV65                    \ [0x01] Privilege enable on event input x
    $02 constant EXTI_PRIV66                    \ [0x02] Privilege enable on event input x
    $04 constant EXTI_PRIV68                    \ [0x04] Privilege enable on event input x
    $05 constant EXTI_PRIV69                    \ [0x05] Privilege enable on event input x
    $06 constant EXTI_PRIV70                    \ [0x06] Privilege enable on event input x
    $07 constant EXTI_PRIV71                    \ [0x07] Privilege enable on event input x
    $08 constant EXTI_PRIV72                    \ [0x08] Privilege enable on event input x
    $09 constant EXTI_PRIV73                    \ [0x09] Privilege enable on event input x
    $0a constant EXTI_PRIV74                    \ [0x0a] Privilege enable on event input x
    $0d constant EXTI_PRIV77                    \ [0x0d] Privilege enable on event input 77
  [then]


  [ifdef] EXTI_EXTI_EXTICR1_DEF
    \
    \ @brief EXTI external interrupt selection register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0                     \ [0x00 : 8] EXTI0 GPIO port selection.
    $08 constant EXTI_EXTI1                     \ [0x08 : 8] EXTI1 GPIO port selection
    $10 constant EXTI_EXTI2                     \ [0x10 : 8] EXTI2 GPIO port selection
    $18 constant EXTI_EXTI3                     \ [0x18 : 8] EXTI3 GPIO port selection
  [then]


  [ifdef] EXTI_EXTI_EXTICR2_DEF
    \
    \ @brief EXTI external interrupt selection register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI4                     \ [0x00 : 8] EXTI4 GPIO port selection.
    $08 constant EXTI_EXTI5                     \ [0x08 : 8] EXTI5 GPIO port selection.
    $10 constant EXTI_EXTI6                     \ [0x10 : 8] EXTI6 GPIO port selection.
    $18 constant EXTI_EXTI7                     \ [0x18 : 8] EXTI7 GPIO port selection.
  [then]


  [ifdef] EXTI_EXTI_EXTICR3_DEF
    \
    \ @brief EXTI external interrupt selection register 3
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI8                     \ [0x00 : 8] EXTI8 GPIO port selection.
    $08 constant EXTI_EXTI9                     \ [0x08 : 8] EXTI9 GPIO port selection.
    $10 constant EXTI_EXTI10                    \ [0x10 : 8] EXTI10 GPIO port selection.
    $18 constant EXTI_EXTI11                    \ [0x18 : 8] EXTI11 GPIO port selection.
  [then]


  [ifdef] EXTI_EXTI_EXTICR4_DEF
    \
    \ @brief EXTI external interrupt selection register 4
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI12                    \ [0x00 : 8] EXTI12 GPIO port selection.
    $08 constant EXTI_EXTI13                    \ [0x08 : 8] EXTI13 GPIO port selection.
    $10 constant EXTI_EXTI14                    \ [0x10 : 8] EXTI14 GPIO port selection.
    $18 constant EXTI_EXTI15                    \ [0x18 : 8] EXTI15 GPIO port selection.
  [then]


  [ifdef] EXTI_EXTI_LOCKR_DEF
    \
    \ @brief EXTI lock register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_GLOCK                     \ [0x00] Global security privilege EXTI_SECCFGRx/PRIVCFGRx
  [then]


  [ifdef] EXTI_EXTI_IMR1_DEF
    \
    \ @brief EXTI CPU wake-up with interrupt mask register 1
    \ Address offset: 0x80
    \ Reset value: 0x00000000
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
    \ @brief EXTI CPU wake-up with event mask register 1
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] CPU wake-up with interrupt mask on event input x
    $01 constant EXTI_EM1                       \ [0x01] CPU wake-up with interrupt mask on event input x
    $02 constant EXTI_EM2                       \ [0x02] CPU wake-up with interrupt mask on event input x
    $03 constant EXTI_EM3                       \ [0x03] CPU wake-up with interrupt mask on event input x
    $04 constant EXTI_EM4                       \ [0x04] CPU wake-up with interrupt mask on event input x
    $05 constant EXTI_EM5                       \ [0x05] CPU wake-up with interrupt mask on event input x
    $06 constant EXTI_EM6                       \ [0x06] CPU wake-up with interrupt mask on event input x
    $07 constant EXTI_EM7                       \ [0x07] CPU wake-up with interrupt mask on event input x
    $08 constant EXTI_EM8                       \ [0x08] CPU wake-up with interrupt mask on event input x
    $09 constant EXTI_EM9                       \ [0x09] CPU wake-up with interrupt mask on event input x
    $0a constant EXTI_EM10                      \ [0x0a] CPU wake-up with interrupt mask on event input x
    $0b constant EXTI_EM11                      \ [0x0b] CPU wake-up with interrupt mask on event input x
    $0c constant EXTI_EM12                      \ [0x0c] CPU wake-up with interrupt mask on event input x
    $0d constant EXTI_EM13                      \ [0x0d] CPU wake-up with interrupt mask on event input x
    $0e constant EXTI_EM14                      \ [0x0e] CPU wake-up with interrupt mask on event input x
    $0f constant EXTI_EM15                      \ [0x0f] CPU wake-up with interrupt mask on event input x
    $11 constant EXTI_EM17                      \ [0x11] CPU wake-up with event on event input x
    $12 constant EXTI_EM18                      \ [0x12] CPU wake-up with event on event input x
    $13 constant EXTI_EM19                      \ [0x13] CPU wake-up with event on event input x
    $14 constant EXTI_EM20                      \ [0x14] CPU wake-up with event on event input x
    $15 constant EXTI_EM21                      \ [0x15] CPU wake-up with event on event input x
    $16 constant EXTI_EM22                      \ [0x16] CPU wake-up with event on event input x
    $17 constant EXTI_EM23                      \ [0x17] CPU wake-up with event on event input x
    $18 constant EXTI_EM24                      \ [0x18] CPU wake-up with event on event input x
    $19 constant EXTI_EM25                      \ [0x19] CPU wake-up with event on event input x
    $1a constant EXTI_EM26                      \ [0x1a] CPU wake-up with event on event input x
    $1b constant EXTI_EM27                      \ [0x1b] CPU wake-up with event on event input x
    $1c constant EXTI_EM28                      \ [0x1c] CPU wake-up with event on event input x
    $1d constant EXTI_EM29                      \ [0x1d] CPU wake-up with event on event input x
    $1e constant EXTI_EM30                      \ [0x1e] CPU wake-up with event on event input x
    $1f constant EXTI_EM31                      \ [0x1f] CPU wake-up with event on event input x
  [then]


  [ifdef] EXTI_EXTI_IMR2_DEF
    \
    \ @brief EXTI CPU wake-up with interrupt mask register 2
    \ Address offset: 0x90
    \ Reset value: 0x00000000
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
    $1c constant EXTI_IM60                      \ [0x1c] CPU wake-up with interrupt mask on event input x
    $1d constant EXTI_IM61                      \ [0x1d] CPU wake-up with interrupt mask on event input x
    $1e constant EXTI_IM62                      \ [0x1e] CPU wake-up with interrupt mask on event input x
    $1f constant EXTI_IM63                      \ [0x1f] CPU wake-up with interrupt mask on event input x
  [then]


  [ifdef] EXTI_EXTI_EMR2_DEF
    \
    \ @brief EXTI CPU wake-up with event mask register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM32                      \ [0x00] CPU wake-up with interrupt mask on event input x
    $01 constant EXTI_EM33                      \ [0x01] CPU wake-up with interrupt mask on event input x
    $02 constant EXTI_EM34                      \ [0x02] CPU wake-up with interrupt mask on event input x
    $03 constant EXTI_EM35                      \ [0x03] CPU wake-up with interrupt mask on event input x
    $04 constant EXTI_EM36                      \ [0x04] CPU wake-up with interrupt mask on event input x
    $05 constant EXTI_EM37                      \ [0x05] CPU wake-up with interrupt mask on event input x
    $06 constant EXTI_EM38                      \ [0x06] CPU wake-up with interrupt mask on event input x
    $07 constant EXTI_EM39                      \ [0x07] CPU wake-up with interrupt mask on event input x
    $08 constant EXTI_EM40                      \ [0x08] CPU wake-up with interrupt mask on event input x
    $09 constant EXTI_EM41                      \ [0x09] CPU wake-up with interrupt mask on event input x
    $0a constant EXTI_EM42                      \ [0x0a] CPU wake-up with interrupt mask on event input x
    $0b constant EXTI_EM43                      \ [0x0b] CPU wake-up with interrupt mask on event input x
    $0c constant EXTI_EM44                      \ [0x0c] CPU wake-up with interrupt mask on event input x
    $0d constant EXTI_EM45                      \ [0x0d] CPU wake-up with interrupt mask on event input x
    $0e constant EXTI_EM46                      \ [0x0e] CPU wake-up with interrupt mask on event input x
    $0f constant EXTI_EM47                      \ [0x0f] CPU wake-up with interrupt mask on event input x
    $10 constant EXTI_EM48                      \ [0x10] CPU wake-up with interrupt mask on event input x
    $11 constant EXTI_EM49                      \ [0x11] CPU wake-up with interrupt mask on event input x
    $12 constant EXTI_EM50                      \ [0x12] CPU wake-up with interrupt mask on event input x
    $13 constant EXTI_EM51                      \ [0x13] CPU wake-up with interrupt mask on event input x
    $14 constant EXTI_EM52                      \ [0x14] CPU wake-up with interrupt mask on event input x
    $15 constant EXTI_EM53                      \ [0x15] CPU wake-up with interrupt mask on event input x
    $16 constant EXTI_EM54                      \ [0x16] CPU wake-up with interrupt mask on event input x
    $17 constant EXTI_EM55                      \ [0x17] CPU wake-up with interrupt mask on event input x
    $18 constant EXTI_EM56                      \ [0x18] CPU wake-up with interrupt mask on event input x
    $19 constant EXTI_EM57                      \ [0x19] CPU wake-up with interrupt mask on event input x
    $1a constant EXTI_EM58                      \ [0x1a] CPU wake-up with interrupt mask on event input x
    $1c constant EXTI_EM60                      \ [0x1c] CPU wake-up with event on event input x
    $1d constant EXTI_EM61                      \ [0x1d] CPU wake-up with event on event input x
    $1e constant EXTI_EM62                      \ [0x1e] CPU wake-up with event on event input x
    $1f constant EXTI_EM63                      \ [0x1f] CPU wake-up with event on event input x
  [then]


  [ifdef] EXTI_EXTI_IMR3_DEF
    \
    \ @brief EXTI CPU wake-up with interrupt mask register 3
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_IM64                      \ [0x00] CPU wake-up with interrupt mask on event input x
    $01 constant EXTI_IM65                      \ [0x01] CPU wake-up with interrupt mask on event input x
    $02 constant EXTI_IM66                      \ [0x02] CPU wake-up with interrupt mask on event input x
    $04 constant EXTI_IM68                      \ [0x04] CPU wake-up with interrupt mask on event input x
    $05 constant EXTI_IM69                      \ [0x05] CPU wake-up with interrupt mask on event input x
    $06 constant EXTI_IM70                      \ [0x06] CPU wake-up with interrupt mask on event input x
    $07 constant EXTI_IM71                      \ [0x07] CPU wake-up with interrupt mask on event input x
    $08 constant EXTI_IM72                      \ [0x08] CPU wake-up with interrupt mask on event input x
    $09 constant EXTI_IM73                      \ [0x09] CPU wake-up with interrupt mask on event input x
    $0a constant EXTI_IM74                      \ [0x0a] CPU wake-up with interrupt mask on event input x
    $0d constant EXTI_IM77                      \ [0x0d] CPU wake-up with interrupt mask on event input 77
  [then]


  [ifdef] EXTI_EXTI_EMR3_DEF
    \
    \ @brief EXTI CPU wake-up with event mask register 3
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM64                      \ [0x00] CPU wake-up with interrupt mask on event input x
    $01 constant EXTI_EM65                      \ [0x01] CPU wake-up with interrupt mask on event input x
    $02 constant EXTI_EM66                      \ [0x02] CPU wake-up with interrupt mask on event input x
    $04 constant EXTI_EM68                      \ [0x04] CPU wake-up with interrupt mask on event input x
    $05 constant EXTI_EM69                      \ [0x05] CPU wake-up with interrupt mask on event input x
    $06 constant EXTI_EM70                      \ [0x06] CPU wake-up with interrupt mask on event input x
    $07 constant EXTI_EM71                      \ [0x07] CPU wake-up with interrupt mask on event input x
    $08 constant EXTI_EM72                      \ [0x08] CPU wake-up with interrupt mask on event input x
    $09 constant EXTI_EM73                      \ [0x09] CPU wake-up with interrupt mask on event input x
    $0a constant EXTI_EM74                      \ [0x0a] CPU wake-up with interrupt mask on event input x
    $0d constant EXTI_EM77                      \ [0x0d] CPU wake-up with event on event input 77
  [then]

  \
  \ @brief Extended interrupts and event controller
  \
  $00 constant EXTI_EXTI_RTSR1          \ EXTI rising trigger selection register
  $04 constant EXTI_EXTI_FTSR1          \ EXTI falling trigger selection register
  $08 constant EXTI_EXTI_SWIER1         \ EXTI software interrupt event register
  $0C constant EXTI_EXTI_RPR1           \ EXTI rising edge pending register
  $10 constant EXTI_EXTI_FPR1           \ EXTI falling edge pending register
  $14 constant EXTI_EXTI_SECCFGR1       \ EXTI security configuration register
  $18 constant EXTI_EXTI_PRIVCFGR1      \ EXTI privilege configuration register
  $20 constant EXTI_EXTI_RTSR2          \ EXTI rising trigger selection register
  $24 constant EXTI_EXTI_FTSR2          \ EXTI falling trigger selection register
  $28 constant EXTI_EXTI_SWIER2         \ EXTI software interrupt event register
  $2C constant EXTI_EXTI_RPR2           \ EXTI rising edge pending register
  $30 constant EXTI_EXTI_FPR2           \ EXTI falling edge pending register
  $34 constant EXTI_EXTI_SECCFGR2       \ EXTI security enable register
  $38 constant EXTI_EXTI_PRIVCFGR2      \ EXTI privilege enable register
  $40 constant EXTI_EXTI_RTSR3          \ EXTI rising trigger selection register
  $44 constant EXTI_EXTI_FTSR3          \ EXTI falling trigger selection register
  $48 constant EXTI_EXTI_SWIER3         \ EXTI software interrupt event register
  $4C constant EXTI_EXTI_RPR3           \ EXTI rising edge pending register
  $50 constant EXTI_EXTI_FPR3           \ EXTI falling edge pending register
  $54 constant EXTI_EXTI_SECCFGR3       \ EXTI security enable register
  $58 constant EXTI_EXTI_PRIVCFGR3      \ EXTI privilege enable register
  $60 constant EXTI_EXTI_EXTICR1        \ EXTI external interrupt selection register 1
  $64 constant EXTI_EXTI_EXTICR2        \ EXTI external interrupt selection register 2
  $68 constant EXTI_EXTI_EXTICR3        \ EXTI external interrupt selection register 3
  $6C constant EXTI_EXTI_EXTICR4        \ EXTI external interrupt selection register 4
  $70 constant EXTI_EXTI_LOCKR          \ EXTI lock register
  $80 constant EXTI_EXTI_IMR1           \ EXTI CPU wake-up with interrupt mask register 1
  $84 constant EXTI_EXTI_EMR1           \ EXTI CPU wake-up with event mask register 1
  $90 constant EXTI_EXTI_IMR2           \ EXTI CPU wake-up with interrupt mask register 2
  $94 constant EXTI_EXTI_EMR2           \ EXTI CPU wake-up with event mask register 2
  $A0 constant EXTI_EXTI_IMR3           \ EXTI CPU wake-up with interrupt mask register 3
  $A4 constant EXTI_EXTI_EMR3           \ EXTI CPU wake-up with event mask register 3

: EXTI_DEF ; [then]
