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
    $00 constant EXTI_RT0                       \ [0x00] Rising trigger event configuration bit of Configurable Event line
    $01 constant EXTI_RT1                       \ [0x01] Rising trigger event configuration bit of Configurable Event line
    $02 constant EXTI_RT2                       \ [0x02] Rising trigger event configuration bit of Configurable Event line
    $03 constant EXTI_RT3                       \ [0x03] Rising trigger event configuration bit of Configurable Event line
    $04 constant EXTI_RT4                       \ [0x04] Rising trigger event configuration bit of Configurable Event line
    $05 constant EXTI_RT5                       \ [0x05] Rising trigger event configuration bit of Configurable Event line
    $06 constant EXTI_RT6                       \ [0x06] Rising trigger event configuration bit of Configurable Event line
    $07 constant EXTI_RT7                       \ [0x07] Rising trigger event configuration bit of Configurable Event line
    $08 constant EXTI_RT8                       \ [0x08] Rising trigger event configuration bit of Configurable Event line
    $09 constant EXTI_RT9                       \ [0x09] Rising trigger event configuration bit of Configurable Event line
    $0a constant EXTI_RT10                      \ [0x0a] Rising trigger event configuration bit of Configurable Event line
    $0b constant EXTI_RT11                      \ [0x0b] Rising trigger event configuration bit of Configurable Event line
    $0c constant EXTI_RT12                      \ [0x0c] Rising trigger event configuration bit of Configurable Event line
    $0d constant EXTI_RT13                      \ [0x0d] Rising trigger event configuration bit of Configurable Event line
    $0e constant EXTI_RT14                      \ [0x0e] Rising trigger event configuration bit of Configurable Event line
    $0f constant EXTI_RT15                      \ [0x0f] Rising trigger event configuration bit of Configurable Event line
    $10 constant EXTI_RT16                      \ [0x10] Rising trigger event configuration bit of Configurable Event line
    $11 constant EXTI_RT17                      \ [0x11] Rising trigger event configuration bit of Configurable Event line
    $12 constant EXTI_RT18                      \ [0x12] Rising trigger event configuration bit of Configurable Event line
    $14 constant EXTI_RT20                      \ [0x14] Rising trigger event configuration bit of Configurable Event line
  [then]


  [ifdef] EXTI_FTSR1_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT0                       \ [0x00] Falling trigger event configuration bit of configurable line
    $01 constant EXTI_FT1                       \ [0x01] Falling trigger event configuration bit of configurable line
    $02 constant EXTI_FT2                       \ [0x02] Falling trigger event configuration bit of configurable line
    $03 constant EXTI_FT3                       \ [0x03] Falling trigger event configuration bit of configurable line
    $04 constant EXTI_FT4                       \ [0x04] Falling trigger event configuration bit of configurable line
    $05 constant EXTI_FT5                       \ [0x05] Falling trigger event configuration bit of configurable line
    $06 constant EXTI_FT6                       \ [0x06] Falling trigger event configuration bit of configurable line
    $07 constant EXTI_FT7                       \ [0x07] Falling trigger event configuration bit of configurable line
    $08 constant EXTI_FT8                       \ [0x08] Falling trigger event configuration bit of configurable line
    $09 constant EXTI_FT9                       \ [0x09] Falling trigger event configuration bit of configurable line
    $0a constant EXTI_FT10                      \ [0x0a] Falling trigger event configuration bit of configurable line
    $0b constant EXTI_FT11                      \ [0x0b] Falling trigger event configuration bit of configurable line
    $0c constant EXTI_FT12                      \ [0x0c] Falling trigger event configuration bit of configurable line
    $0d constant EXTI_FT13                      \ [0x0d] Falling trigger event configuration bit of configurable line
    $0e constant EXTI_FT14                      \ [0x0e] Falling trigger event configuration bit of configurable line
    $0f constant EXTI_FT15                      \ [0x0f] Falling trigger event configuration bit of configurable line
    $10 constant EXTI_FT16                      \ [0x10] Falling trigger event configuration bit of configurable line
    $11 constant EXTI_FT17                      \ [0x11] Falling trigger event configuration bit of configurable line
    $12 constant EXTI_FT18                      \ [0x12] Falling trigger event configuration bit of configurable line
    $14 constant EXTI_FT20                      \ [0x14] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_SWIER1_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI0                      \ [0x00] Software rising edge event trigger on line
    $01 constant EXTI_SWI1                      \ [0x01] Software rising edge event trigger on line
    $02 constant EXTI_SWI2                      \ [0x02] Software rising edge event trigger on line
    $03 constant EXTI_SWI3                      \ [0x03] Software rising edge event trigger on line
    $04 constant EXTI_SWI4                      \ [0x04] Software rising edge event trigger on line
    $05 constant EXTI_SWI5                      \ [0x05] Software rising edge event trigger on line
    $06 constant EXTI_SWI6                      \ [0x06] Software rising edge event trigger on line
    $07 constant EXTI_SWI7                      \ [0x07] Software rising edge event trigger on line
    $08 constant EXTI_SWI8                      \ [0x08] Software rising edge event trigger on line
    $09 constant EXTI_SWI9                      \ [0x09] Software rising edge event trigger on line
    $0a constant EXTI_SWI10                     \ [0x0a] Software rising edge event trigger on line
    $0b constant EXTI_SWI11                     \ [0x0b] Software rising edge event trigger on line
    $0c constant EXTI_SWI12                     \ [0x0c] Software rising edge event trigger on line
    $0d constant EXTI_SWI13                     \ [0x0d] Software rising edge event trigger on line
    $0e constant EXTI_SWI14                     \ [0x0e] Software rising edge event trigger on line
    $0f constant EXTI_SWI15                     \ [0x0f] Software rising edge event trigger on line
    $10 constant EXTI_SWI16                     \ [0x10] Software rising edge event trigger on line
    $11 constant EXTI_SWI17                     \ [0x11] Software rising edge event trigger on line
    $12 constant EXTI_SWI18                     \ [0x12] Software rising edge event trigger on line
    $14 constant EXTI_SWI20                     \ [0x14] Software rising edge event trigger on line
  [then]


  [ifdef] EXTI_RPR1_DEF
    \
    \ @brief EXTI rising edge pending register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RPIF0                     \ [0x00] Rising edge event pending for configurable line
    $01 constant EXTI_RPIF1                     \ [0x01] Rising edge event pending for configurable line
    $02 constant EXTI_RPIF2                     \ [0x02] Rising edge event pending for configurable line
    $03 constant EXTI_RPIF3                     \ [0x03] Rising edge event pending for configurable line
    $04 constant EXTI_RPIF4                     \ [0x04] Rising edge event pending for configurable line
    $05 constant EXTI_RPIF5                     \ [0x05] configurable event inputs x rising edge Pending bit
    $06 constant EXTI_RPIF6                     \ [0x06] Rising edge event pending for configurable line
    $07 constant EXTI_RPIF7                     \ [0x07] Rising edge event pending for configurable line
    $08 constant EXTI_RPIF8                     \ [0x08] Rising edge event pending for configurable line
    $09 constant EXTI_RPIF9                     \ [0x09] Rising edge event pending for configurable line
    $0a constant EXTI_RPIF10                    \ [0x0a] Rising edge event pending for configurable line
    $0b constant EXTI_RPIF11                    \ [0x0b] Rising edge event pending for configurable line
    $0c constant EXTI_RPIF12                    \ [0x0c] Rising edge event pending for configurable line
    $0d constant EXTI_RPIF13                    \ [0x0d] Rising edge event pending for configurable line
    $0e constant EXTI_RPIF14                    \ [0x0e] Rising edge event pending for configurable line
    $0f constant EXTI_RPIF15                    \ [0x0f] Rising edge event pending for configurable line
    $10 constant EXTI_RPIF16                    \ [0x10] Rising edge event pending for configurable line
    $11 constant EXTI_RPIF17                    \ [0x11] Rising edge event pending for configurable line
    $12 constant EXTI_RPIF18                    \ [0x12] Rising edge event pending for configurable line
    $14 constant EXTI_RPIF20                    \ [0x14] Rising edge event pending for configurable line
  [then]


  [ifdef] EXTI_FPR1_DEF
    \
    \ @brief EXTI falling edge pending register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FPIF0                     \ [0x00] Falling edge event pending for configurable line
    $01 constant EXTI_FPIF1                     \ [0x01] Falling edge event pending for configurable line
    $02 constant EXTI_FPIF2                     \ [0x02] Falling edge event pending for configurable line
    $03 constant EXTI_FPIF3                     \ [0x03] Falling edge event pending for configurable line
    $04 constant EXTI_FPIF4                     \ [0x04] Falling edge event pending for configurable line
    $05 constant EXTI_FPIF5                     \ [0x05] Falling edge event pending for configurable line
    $06 constant EXTI_FPIF6                     \ [0x06] Falling edge event pending for configurable line
    $07 constant EXTI_FPIF7                     \ [0x07] Falling edge event pending for configurable line
    $08 constant EXTI_FPIF8                     \ [0x08] Falling edge event pending for configurable line
    $09 constant EXTI_FPIF9                     \ [0x09] Falling edge event pending for configurable line
    $0a constant EXTI_FPIF10                    \ [0x0a] Falling edge event pending for configurable line
    $0b constant EXTI_FPIF11                    \ [0x0b] Falling edge event pending for configurable line
    $0c constant EXTI_FPIF12                    \ [0x0c] Falling edge event pending for configurable line
    $0d constant EXTI_FPIF13                    \ [0x0d] Falling edge event pending for configurable line
    $0e constant EXTI_FPIF14                    \ [0x0e] Falling edge event pending for configurable line
    $0f constant EXTI_FPIF15                    \ [0x0f] Falling edge event pending for configurable line
    $10 constant EXTI_FPIF16                    \ [0x10] Falling edge event pending for configurable line
    $11 constant EXTI_FPIF17                    \ [0x11] Falling edge event pending for configurable line
    $12 constant EXTI_FPIF18                    \ [0x12] Falling edge event pending for configurable line
    $14 constant EXTI_FPIF20                    \ [0x14] Falling edge event pending for configurable line
  [then]


  [ifdef] EXTI_RTSR2_DEF
    \
    \ @brief EXTI rising trigger selection register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_RT2                       \ [0x02] Rising trigger event configuration bit of configurable line 34
  [then]


  [ifdef] EXTI_FTSR2_DEF
    \
    \ @brief EXTI falling trigger selection register 2
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_FT2                       \ [0x02] Falling trigger event configuration bit of configurable line 34
  [then]


  [ifdef] EXTI_SWIER2_DEF
    \
    \ @brief EXTI software interrupt event register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_SWI2                      \ [0x02] Software rising edge event trigger on line 34
  [then]


  [ifdef] EXTI_RPR2_DEF
    \
    \ @brief EXTI rising edge pending register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_RPIF2                     \ [0x02] Rising edge event pending for configurable line 34
  [then]


  [ifdef] EXTI_FPR2_DEF
    \
    \ @brief EXTI falling edge pending register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_FPIF2                     \ [0x02] Falling edge event pending for configurable line 34
  [then]


  [ifdef] EXTI_EXTICR1_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0_7                   \ [0x00 : 8] GPIO port selection
    $08 constant EXTI_EXTI8_15                  \ [0x08 : 8] GPIO port selection
    $10 constant EXTI_EXTI16_23                 \ [0x10 : 8] GPIO port selection
    $18 constant EXTI_EXTI24_31                 \ [0x18 : 8] GPIO port selection
  [then]


  [ifdef] EXTI_EXTICR2_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0_7                   \ [0x00 : 8] GPIO port selection
    $08 constant EXTI_EXTI8_15                  \ [0x08 : 8] GPIO port selection
    $10 constant EXTI_EXTI16_23                 \ [0x10 : 8] GPIO port selection
    $18 constant EXTI_EXTI24_31                 \ [0x18 : 8] GPIO port selection
  [then]


  [ifdef] EXTI_EXTICR3_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0_7                   \ [0x00 : 8] GPIO port selection
    $08 constant EXTI_EXTI8_15                  \ [0x08 : 8] GPIO port selection
    $10 constant EXTI_EXTI16_23                 \ [0x10 : 8] GPIO port selection
    $18 constant EXTI_EXTI24_31                 \ [0x18 : 8] GPIO port selection
  [then]


  [ifdef] EXTI_EXTICR4_DEF
    \
    \ @brief EXTI external interrupt selection register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EXTI0_7                   \ [0x00 : 8] GPIO port selection
    $08 constant EXTI_EXTI8_15                  \ [0x08 : 8] GPIO port selection
    $10 constant EXTI_EXTI16_23                 \ [0x10 : 8] GPIO port selection
    $18 constant EXTI_EXTI24_31                 \ [0x18 : 8] GPIO port selection
  [then]


  [ifdef] EXTI_IMR1_DEF
    \
    \ @brief EXTI CPU wakeup with interrupt mask register
    \ Address offset: 0x80
    \ Reset value: 0xFFF80000
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
    $00 constant EXTI_EM0                       \ [0x00] CPU wakeup with event mask on event input
    $01 constant EXTI_EM1                       \ [0x01] CPU wakeup with event mask on event input
    $02 constant EXTI_EM2                       \ [0x02] CPU wakeup with event mask on event input
    $03 constant EXTI_EM3                       \ [0x03] CPU wakeup with event mask on event input
    $04 constant EXTI_EM4                       \ [0x04] CPU wakeup with event mask on event input
    $05 constant EXTI_EM5                       \ [0x05] CPU wakeup with event mask on event input
    $06 constant EXTI_EM6                       \ [0x06] CPU wakeup with event mask on event input
    $07 constant EXTI_EM7                       \ [0x07] CPU wakeup with event mask on event input
    $08 constant EXTI_EM8                       \ [0x08] CPU wakeup with event mask on event input
    $09 constant EXTI_EM9                       \ [0x09] CPU wakeup with event mask on event input
    $0a constant EXTI_EM10                      \ [0x0a] CPU wakeup with event mask on event input
    $0b constant EXTI_EM11                      \ [0x0b] CPU wakeup with event mask on event input
    $0c constant EXTI_EM12                      \ [0x0c] CPU wakeup with event mask on event input
    $0d constant EXTI_EM13                      \ [0x0d] CPU wakeup with event mask on event input
    $0e constant EXTI_EM14                      \ [0x0e] CPU wakeup with event mask on event input
    $0f constant EXTI_EM15                      \ [0x0f] CPU wakeup with event mask on event input
    $10 constant EXTI_EM16                      \ [0x10] CPU wakeup with event mask on event input
    $11 constant EXTI_EM17                      \ [0x11] CPU wakeup with event mask on event input
    $12 constant EXTI_EM18                      \ [0x12] CPU wakeup with event mask on event input
    $13 constant EXTI_EM19                      \ [0x13] CPU wakeup with event mask on event input
    $15 constant EXTI_EM21                      \ [0x15] CPU wakeup with event mask on event input
    $17 constant EXTI_EM23                      \ [0x17] CPU wakeup with event mask on event input
    $19 constant EXTI_EM25                      \ [0x19] CPU wakeup with event mask on event input
    $1a constant EXTI_EM26                      \ [0x1a] CPU wakeup with event mask on event input
    $1b constant EXTI_EM27                      \ [0x1b] CPU wakeup with event mask on event input
    $1c constant EXTI_EM28                      \ [0x1c] CPU wakeup with event mask on event input
    $1d constant EXTI_EM29                      \ [0x1d] CPU wakeup with event mask on event input
    $1e constant EXTI_EM30                      \ [0x1e] CPU wakeup with event mask on event input
    $1f constant EXTI_EM31                      \ [0x1f] CPU wakeup with event mask on event input
  [then]


  [ifdef] EXTI_IMR2_DEF
    \
    \ @brief EXTI CPU wakeup with interrupt mask register
    \ Address offset: 0x90
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant EXTI_IM32                      \ [0x00] CPU wakeup with interrupt mask on event input
    $01 constant EXTI_IM33                      \ [0x01] CPU wakeup with interrupt mask on event input
    $02 constant EXTI_IM34                      \ [0x02] CPU wakeup with interrupt mask on event input
    $03 constant EXTI_IM35                      \ [0x03] CPU wakeup with interrupt mask on event input
  [then]


  [ifdef] EXTI_EMR2_DEF
    \
    \ @brief EXTI CPU wakeup with event mask register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM32                      \ [0x00] CPU wakeup with event mask on event input
    $01 constant EXTI_EM33                      \ [0x01] CPU wakeup with event mask on event input
    $02 constant EXTI_EM34                      \ [0x02] CPU wakeup with event mask on event input
    $03 constant EXTI_EM35                      \ [0x03] CPU wakeup with event mask on event input
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_RTSR1               \ EXTI rising trigger selection register
  $04 constant EXTI_FTSR1               \ EXTI falling trigger selection register
  $08 constant EXTI_SWIER1              \ EXTI software interrupt event register
  $0C constant EXTI_RPR1                \ EXTI rising edge pending register
  $10 constant EXTI_FPR1                \ EXTI falling edge pending register
  $28 constant EXTI_RTSR2               \ EXTI rising trigger selection register 2
  $2C constant EXTI_FTSR2               \ EXTI falling trigger selection register 2
  $30 constant EXTI_SWIER2              \ EXTI software interrupt event register 2
  $34 constant EXTI_RPR2                \ EXTI rising edge pending register 2
  $38 constant EXTI_FPR2                \ EXTI falling edge pending register 2
  $60 constant EXTI_EXTICR1             \ EXTI external interrupt selection register
  $64 constant EXTI_EXTICR2             \ EXTI external interrupt selection register
  $68 constant EXTI_EXTICR3             \ EXTI external interrupt selection register
  $6C constant EXTI_EXTICR4             \ EXTI external interrupt selection register
  $80 constant EXTI_IMR1                \ EXTI CPU wakeup with interrupt mask register
  $84 constant EXTI_EMR1                \ EXTI CPU wakeup with event mask register
  $90 constant EXTI_IMR2                \ EXTI CPU wakeup with interrupt mask register
  $94 constant EXTI_EMR2                \ EXTI CPU wakeup with event mask register

: EXTI_DEF ; [then]
