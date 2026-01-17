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
    $15 constant EXTI_RT21                      \ [0x15] Rising trigger event configuration bit of configurable event input x
    $16 constant EXTI_RT22                      \ [0x16] Rising trigger event configuration bit of configurable event input x
  [then]


  [ifdef] EXTI_FTSR1_DEF
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
    $15 constant EXTI_FT21                      \ [0x15] Falling trigger event configuration bit of configurable event input x
    $16 constant EXTI_FT22                      \ [0x16] Falling trigger event configuration bit of configurable event input x
  [then]


  [ifdef] EXTI_SWIER1_DEF
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
    $15 constant EXTI_SWI21                     \ [0x15] Software interrupt on event x
    $16 constant EXTI_SWI22                     \ [0x16] Software interrupt on event x
  [then]


  [ifdef] EXTI_RPR1_DEF
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
    $15 constant EXTI_RPIF21                    \ [0x15] configurable event inputs x rising edge pending bit
    $16 constant EXTI_RPIF22                    \ [0x16] configurable event inputs x rising edge pending bit
  [then]


  [ifdef] EXTI_FPR1_DEF
    \
    \ @brief EXTI falling edge pending register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FPIF0                     \ [0x00] configurable event inputs x falling edge pending bit.
    $01 constant EXTI_FPIF1                     \ [0x01] configurable event inputs x falling edge pending bit.
    $02 constant EXTI_FPIF2                     \ [0x02] configurable event inputs x falling edge pending bit.
    $03 constant EXTI_FPIF3                     \ [0x03] configurable event inputs x falling edge pending bit.
    $04 constant EXTI_FPIF4                     \ [0x04] configurable event inputs x falling edge pending bit.
    $05 constant EXTI_FPIF5                     \ [0x05] configurable event inputs x falling edge pending bit.
    $06 constant EXTI_FPIF6                     \ [0x06] configurable event inputs x falling edge pending bit.
    $07 constant EXTI_FPIF7                     \ [0x07] configurable event inputs x falling edge pending bit.
    $08 constant EXTI_FPIF8                     \ [0x08] configurable event inputs x falling edge pending bit.
    $09 constant EXTI_FPIF9                     \ [0x09] configurable event inputs x falling edge pending bit.
    $0a constant EXTI_FPIF10                    \ [0x0a] configurable event inputs x falling edge pending bit.
    $0b constant EXTI_FPIF11                    \ [0x0b] configurable event inputs x falling edge pending bit.
    $0c constant EXTI_FPIF12                    \ [0x0c] configurable event inputs x falling edge pending bit.
    $0d constant EXTI_FPIF13                    \ [0x0d] configurable event inputs x falling edge pending bit.
    $0e constant EXTI_FPIF14                    \ [0x0e] configurable event inputs x falling edge pending bit.
    $0f constant EXTI_FPIF15                    \ [0x0f] configurable event inputs x falling edge pending bit.
    $10 constant EXTI_FPIF16                    \ [0x10] configurable event inputs x falling edge pending bit.
    $15 constant EXTI_FPIF21                    \ [0x15] configurable event inputs x falling edge pending bit.
    $16 constant EXTI_FPIF22                    \ [0x16] configurable event inputs x falling edge pending bit.
  [then]


  [ifdef] EXTI_SECCFGR1_DEF
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


  [ifdef] EXTI_PRIVCFGR1_DEF
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


  [ifdef] EXTI_RTSR2_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $03 constant EXTI_RT35                      \ [0x03] Rising trigger event configuration bit of configurable event input x
    $04 constant EXTI_RT36                      \ [0x04] Rising trigger event configuration bit of configurable event input x
    $05 constant EXTI_RT37                      \ [0x05] Rising trigger event configuration bit of configurable event input x
    $06 constant EXTI_RT38                      \ [0x06] Rising trigger event configuration bit of configurable event input x
  [then]


  [ifdef] EXTI_FTSR2_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $03 constant EXTI_FT35                      \ [0x03] FT35
    $04 constant EXTI_FT36                      \ [0x04] FT36
    $05 constant EXTI_FT37                      \ [0x05] FT37
    $06 constant EXTI_FT38                      \ [0x06] FT38
  [then]


  [ifdef] EXTI_SWIER2_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $03 constant EXTI_SWI35                     \ [0x03] SWI35
    $04 constant EXTI_SWI36                     \ [0x04] SWI36
    $05 constant EXTI_SWI37                     \ [0x05] SWI37
    $06 constant EXTI_SWI38                     \ [0x06] SWI38
  [then]


  [ifdef] EXTI_RPR2_DEF
    \
    \ @brief EXTI rising edge pending register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $03 constant EXTI_RPIF35                    \ [0x03] RPIF35
    $04 constant EXTI_RPIF36                    \ [0x04] RPIF36
    $05 constant EXTI_RPIF37                    \ [0x05] RPIF37
    $06 constant EXTI_RPIF38                    \ [0x06] RPIF38
  [then]


  [ifdef] EXTI_FPR2_DEF
    \
    \ @brief EXTI falling edge pending register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $03 constant EXTI_FPIF35                    \ [0x03] FPIF35
    $04 constant EXTI_FPIF36                    \ [0x04] FPIF36
    $05 constant EXTI_FPIF37                    \ [0x05] FPIF37
    $06 constant EXTI_FPIF38                    \ [0x06] FPIF38
  [then]


  [ifdef] EXTI_PRIVCFGR2_DEF
    \
    \ @brief EXTI security enable register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PRIV32                    \ [0x00] PRIV32
    $01 constant EXTI_PRIV33                    \ [0x01] PRIV33
    $02 constant EXTI_PRIV34                    \ [0x02] PRIV34
    $03 constant EXTI_PRIV35                    \ [0x03] PRIV35
    $04 constant EXTI_PRIV36                    \ [0x04] PRIV36
    $05 constant EXTI_PRIV37                    \ [0x05] PRIV37
    $06 constant EXTI_PRIV38                    \ [0x06] PRIV38
    $07 constant EXTI_PRIV39                    \ [0x07] PRIV39
    $08 constant EXTI_PRIV40                    \ [0x08] PRIV40
    $09 constant EXTI_PRIV41                    \ [0x09] PRIV41
    $0a constant EXTI_PRIV42                    \ [0x0a] PRIV42
  [then]


  [ifdef] EXTI_SECCFGR2_DEF
    \
    \ @brief EXTI security enable register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SEC32                     \ [0x00] SEC32
    $01 constant EXTI_SEC33                     \ [0x01] SEC33
    $02 constant EXTI_SEC34                     \ [0x02] SEC34
    $03 constant EXTI_SEC35                     \ [0x03] SEC35
    $04 constant EXTI_SEC36                     \ [0x04] SEC36
    $05 constant EXTI_SEC37                     \ [0x05] SEC37
    $06 constant EXTI_SEC38                     \ [0x06] SEC38
    $07 constant EXTI_SEC39                     \ [0x07] SEC39
    $08 constant EXTI_SEC40                     \ [0x08] SEC40
    $09 constant EXTI_SEC41                     \ [0x09] SEC41
    $0a constant EXTI_SEC42                     \ [0x0a] SEC42
  [then]


  [ifdef] EXTI_EXTICR1_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0_7                   \ [0x00 : 8] EXTIm GPIO port selection
    $08 constant EXTI_EXTI8_15                  \ [0x08 : 8] EXTIm+1 GPIO port selection
    $10 constant EXTI_EXTI16_23                 \ [0x10 : 8] EXTIm+2 GPIO port selection
    $18 constant EXTI_EXTI24_31                 \ [0x18 : 8] EXTIm+3 GPIO port selection
  [then]


  [ifdef] EXTI_EXTICR2_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0_7                   \ [0x00 : 8] EXTIm GPIO port selection
    $08 constant EXTI_EXTI8_15                  \ [0x08 : 8] EXTIm+1 GPIO port selection
    $10 constant EXTI_EXTI16_23                 \ [0x10 : 8] EXTIm+2 GPIO port selection
    $18 constant EXTI_EXTI24_31                 \ [0x18 : 8] EXTIm+3 GPIO port selection
  [then]


  [ifdef] EXTI_EXTICR3_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0_7                   \ [0x00 : 8] EXTIm GPIO port selection
    $08 constant EXTI_EXTI8_15                  \ [0x08 : 8] EXTIm+1 GPIO port selection
    $10 constant EXTI_EXTI16_23                 \ [0x10 : 8] EXTIm+2 GPIO port selection
    $18 constant EXTI_EXTI24_31                 \ [0x18 : 8] EXTIm+3 GPIO port selection
  [then]


  [ifdef] EXTI_EXTICR4_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0_7                   \ [0x00 : 8] EXTIm GPIO port selection
    $08 constant EXTI_EXTI8_15                  \ [0x08 : 8] EXTIm+1 GPIO port selection
    $10 constant EXTI_EXTI16_23                 \ [0x10 : 8] EXTIm+2 GPIO port selection
    $18 constant EXTI_EXTI24_31                 \ [0x18 : 8] EXTIm+3 GPIO port selection
  [then]


  [ifdef] EXTI_LOCKRG_DEF
    \
    \ @brief EXTI lock register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_LOCK                      \ [0x00] LOCK
  [then]


  [ifdef] EXTI_IMR1_DEF
    \
    \ @brief EXTI CPU wakeup with interrupt mask register
    \ Address offset: 0x80
    \ Reset value: 0xFF9E0000
    \
    $00 constant EXTI_IM0                       \ [0x00] CPU wakeup with interrupt mask on event input
    $01 constant EXTI_IM1                       \ [0x01] CPU wakeup with interrupt mask on event input
    $02 constant EXTI_IM2                       \ [0x02] CPU wakeup with interrupt mask on event input
    $03 constant EXTI_IM3                       \ [0x03] CPU wakeup with interrupt mask on event input
    $04 constant EXTI_IM4                       \ [0x04] CPU wakeup with interrupt mask on event input
    $05 constant EXTI_IM5                       \ [0x05] CPU wakeup with interrupt mask on event input
    $06 constant EXTI_IM6                       \ [0x06] CPU wakeup with interrupt mask on event input
    $07 constant EXTI_IM7                       \ [0x07] CPU wakeup with interrupt mask on event input
    $08 constant EXTI_IM8                       \ [0x08] CPU wakeup with interrupt mask on event input
    $09 constant EXTI_IM9                       \ [0x09] CPU wakeup with interrupt mask on event input
    $0a constant EXTI_IM10                      \ [0x0a] CPU wakeup with interrupt mask on event input
    $0b constant EXTI_IM11                      \ [0x0b] CPU wakeup with interrupt mask on event input
    $0c constant EXTI_IM12                      \ [0x0c] CPU wakeup with interrupt mask on event input
    $0d constant EXTI_IM13                      \ [0x0d] CPU wakeup with interrupt mask on event input
    $0e constant EXTI_IM14                      \ [0x0e] CPU wakeup with interrupt mask on event input
    $0f constant EXTI_IM15                      \ [0x0f] CPU wakeup with interrupt mask on event input
    $10 constant EXTI_IM16                      \ [0x10] CPU wakeup with interrupt mask on event input
    $11 constant EXTI_IM17                      \ [0x11] CPU wakeup with interrupt mask on event input
    $12 constant EXTI_IM18                      \ [0x12] CPU wakeup with interrupt mask on event input
    $13 constant EXTI_IM19                      \ [0x13] CPU wakeup with interrupt mask on event input
    $14 constant EXTI_IM20                      \ [0x14] CPU wakeup with interrupt mask on event input
    $15 constant EXTI_IM21                      \ [0x15] CPU wakeup with interrupt mask on event input
    $16 constant EXTI_IM22                      \ [0x16] CPU wakeup with interrupt mask on event input
    $17 constant EXTI_IM23                      \ [0x17] CPU wakeup with interrupt mask on event input
    $18 constant EXTI_IM24                      \ [0x18] CPU wakeup with interrupt mask on event input
    $19 constant EXTI_IM25                      \ [0x19] CPU wakeup with interrupt mask on event input
    $1a constant EXTI_IM26                      \ [0x1a] CPU wakeup with interrupt mask on event input
    $1b constant EXTI_IM27                      \ [0x1b] CPU wakeup with interrupt mask on event input
    $1c constant EXTI_IM28                      \ [0x1c] CPU wakeup with interrupt mask on event input
    $1d constant EXTI_IM29                      \ [0x1d] CPU wakeup with interrupt mask on event input
    $1e constant EXTI_IM30                      \ [0x1e] CPU wakeup with interrupt mask on event input
    $1f constant EXTI_IM31                      \ [0x1f] CPU wakeup with interrupt mask on event input
  [then]


  [ifdef] EXTI_EMR1_DEF
    \
    \ @brief EXTI CPU wakeup with event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] CPU wakeup with interrupt mask on event input
    $01 constant EXTI_EM1                       \ [0x01] CPU wakeup with interrupt mask on event input
    $02 constant EXTI_EM2                       \ [0x02] CPU wakeup with interrupt mask on event input
    $03 constant EXTI_EM3                       \ [0x03] CPU wakeup with interrupt mask on event input
    $04 constant EXTI_EM4                       \ [0x04] CPU wakeup with interrupt mask on event input
    $05 constant EXTI_EM5                       \ [0x05] CPU wakeup with interrupt mask on event input
    $06 constant EXTI_EM6                       \ [0x06] CPU wakeup with interrupt mask on event input
    $07 constant EXTI_EM7                       \ [0x07] CPU wakeup with interrupt mask on event input
    $08 constant EXTI_EM8                       \ [0x08] CPU wakeup with interrupt mask on event input
    $09 constant EXTI_EM9                       \ [0x09] CPU wakeup with interrupt mask on event input
    $0a constant EXTI_EM10                      \ [0x0a] CPU wakeup with interrupt mask on event input
    $0b constant EXTI_EM11                      \ [0x0b] CPU wakeup with interrupt mask on event input
    $0c constant EXTI_EM12                      \ [0x0c] CPU wakeup with interrupt mask on event input
    $0d constant EXTI_EM13                      \ [0x0d] CPU wakeup with interrupt mask on event input
    $0e constant EXTI_EM14                      \ [0x0e] CPU wakeup with interrupt mask on event input
    $0f constant EXTI_EM15                      \ [0x0f] CPU wakeup with interrupt mask on event input
    $10 constant EXTI_EM16                      \ [0x10] CPU wakeup with interrupt mask on event input
    $11 constant EXTI_EM17                      \ [0x11] CPU wakeup with interrupt mask on event input
    $12 constant EXTI_EM18                      \ [0x12] CPU wakeup with interrupt mask on event input
    $13 constant EXTI_EM19                      \ [0x13] CPU wakeup with interrupt mask on event input
    $14 constant EXTI_EM20                      \ [0x14] CPU wakeup with interrupt mask on event input
    $15 constant EXTI_EM21                      \ [0x15] CPU wakeup with interrupt mask on event input
    $16 constant EXTI_EM22                      \ [0x16] CPU wakeup with interrupt mask on event input
    $17 constant EXTI_EM23                      \ [0x17] CPU wakeup with interrupt mask on event input
    $18 constant EXTI_EM24                      \ [0x18] CPU wakeup with interrupt mask on event input
    $19 constant EXTI_EM25                      \ [0x19] CPU wakeup with interrupt mask on event input
    $1a constant EXTI_EM26                      \ [0x1a] CPU wakeup with interrupt mask on event input
    $1b constant EXTI_EM27                      \ [0x1b] CPU wakeup with interrupt mask on event input
    $1c constant EXTI_EM28                      \ [0x1c] CPU wakeup with interrupt mask on event input
    $1d constant EXTI_EM29                      \ [0x1d] CPU wakeup with interrupt mask on event input
    $1e constant EXTI_EM30                      \ [0x1e] CPU wakeup with interrupt mask on event input
    $1f constant EXTI_EM31                      \ [0x1f] CPU wakeup with interrupt mask on event input
  [then]


  [ifdef] EXTI_IMR2_DEF
    \
    \ @brief EXTI CPUm wakeup with interrupt mask register
    \ Address offset: 0x90
    \ Reset value: 0x00000787
    \
    $00 constant EXTI_IM32                      \ [0x00] CPU wakeup with interrupt mask on event input
    $01 constant EXTI_IM33                      \ [0x01] CPU wakeup with interrupt mask on event input
    $02 constant EXTI_IM34                      \ [0x02] CPU wakeup with interrupt mask on event input
    $03 constant EXTI_IM35                      \ [0x03] CPU wakeup with interrupt mask on event input
    $04 constant EXTI_IM36                      \ [0x04] CPU wakeup with interrupt mask on event input
    $05 constant EXTI_IM37                      \ [0x05] CPU wakeup with interrupt mask on event input
    $06 constant EXTI_IM38                      \ [0x06] CPU wakeup with interrupt mask on event input
    $08 constant EXTI_IM40                      \ [0x08] CPU wakeup with interrupt mask on event input
    $09 constant EXTI_IM41                      \ [0x09] CPU wakeup with interrupt mask on event input
    $0a constant EXTI_IM42                      \ [0x0a] CPU wakeup with interrupt mask on event input
  [then]


  [ifdef] EXTI_EMR2_DEF
    \
    \ @brief EXTI CPU wakeup with event mask register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM32                      \ [0x00] CPU wakeup with interrupt mask on event input
    $01 constant EXTI_EM33                      \ [0x01] CPU wakeup with interrupt mask on event input
    $02 constant EXTI_EM34                      \ [0x02] CPU wakeup with interrupt mask on event input
    $03 constant EXTI_EM35                      \ [0x03] CPU wakeup with interrupt mask on event input
    $04 constant EXTI_EM36                      \ [0x04] CPU wakeup with interrupt mask on event input
    $05 constant EXTI_EM37                      \ [0x05] CPU wakeup with interrupt mask on event input
    $06 constant EXTI_EM38                      \ [0x06] CPU wakeup with interrupt mask on event input
    $08 constant EXTI_EM40                      \ [0x08] CPU wakeup with interrupt mask on event input
    $09 constant EXTI_EM41                      \ [0x09] CPU wakeup with interrupt mask on event input
    $0a constant EXTI_EM42                      \ [0x0a] CPU wakeup with interrupt mask on event input
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_RTSR1               \ EXTI rising trigger selection register
  $04 constant EXTI_FTSR1               \ EXTI falling trigger selection register
  $08 constant EXTI_SWIER1              \ EXTI software interrupt event register
  $0C constant EXTI_RPR1                \ EXTI rising edge pending register
  $10 constant EXTI_FPR1                \ EXTI falling edge pending register
  $14 constant EXTI_SECCFGR1            \ EXTI security configuration register
  $18 constant EXTI_PRIVCFGR1           \ EXTI privilege configuration register
  $20 constant EXTI_RTSR2               \ EXTI rising trigger selection register
  $24 constant EXTI_FTSR2               \ EXTI falling trigger selection register
  $28 constant EXTI_SWIER2              \ EXTI software interrupt event register
  $2C constant EXTI_RPR2                \ EXTI rising edge pending register
  $30 constant EXTI_FPR2                \ EXTI falling edge pending register
  $34 constant EXTI_PRIVCFGR2           \ EXTI security enable register
  $38 constant EXTI_SECCFGR2            \ EXTI security enable register
  $60 constant EXTI_EXTICR1             \ EXTI external interrupt selection register
  $64 constant EXTI_EXTICR2             \ EXTI external interrupt selection register
  $68 constant EXTI_EXTICR3             \ EXTI external interrupt selection register
  $6C constant EXTI_EXTICR4             \ EXTI external interrupt selection register
  $70 constant EXTI_LOCKRG              \ EXTI lock register
  $80 constant EXTI_IMR1                \ EXTI CPU wakeup with interrupt mask register
  $84 constant EXTI_EMR1                \ EXTI CPU wakeup with event mask register
  $90 constant EXTI_IMR2                \ EXTI CPUm wakeup with interrupt mask register
  $94 constant EXTI_EMR2                \ EXTI CPU wakeup with event mask register

: EXTI_DEF ; [then]
