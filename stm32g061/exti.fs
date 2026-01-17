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
    $00 constant EXTI_TR0                       \ [0x00] Rising trigger event configuration bit of Configurable Event input
    $01 constant EXTI_TR1                       \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $02 constant EXTI_TR2                       \ [0x02] Rising trigger event configuration bit of Configurable Event input
    $03 constant EXTI_TR3                       \ [0x03] Rising trigger event configuration bit of Configurable Event input
    $04 constant EXTI_TR4                       \ [0x04] Rising trigger event configuration bit of Configurable Event input
    $05 constant EXTI_TR5                       \ [0x05] Rising trigger event configuration bit of Configurable Event input
    $06 constant EXTI_TR6                       \ [0x06] Rising trigger event configuration bit of Configurable Event input
    $07 constant EXTI_TR7                       \ [0x07] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_TR8                       \ [0x08] Rising trigger event configuration bit of Configurable Event input
    $09 constant EXTI_TR9                       \ [0x09] Rising trigger event configuration bit of Configurable Event input
    $0a constant EXTI_TR10                      \ [0x0a] Rising trigger event configuration bit of Configurable Event input
    $0b constant EXTI_TR11                      \ [0x0b] Rising trigger event configuration bit of Configurable Event input
    $0c constant EXTI_TR12                      \ [0x0c] Rising trigger event configuration bit of Configurable Event input
    $0d constant EXTI_TR13                      \ [0x0d] Rising trigger event configuration bit of Configurable Event input
    $0e constant EXTI_TR14                      \ [0x0e] Rising trigger event configuration bit of Configurable Event input
    $0f constant EXTI_TR15                      \ [0x0f] Rising trigger event configuration bit of Configurable Event input
    $10 constant EXTI_TR16                      \ [0x10] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_FTSR1_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TR0                       \ [0x00] Rising trigger event configuration bit of Configurable Event input
    $01 constant EXTI_TR1                       \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $02 constant EXTI_TR2                       \ [0x02] Rising trigger event configuration bit of Configurable Event input
    $03 constant EXTI_TR3                       \ [0x03] Rising trigger event configuration bit of Configurable Event input
    $04 constant EXTI_TR4                       \ [0x04] Rising trigger event configuration bit of Configurable Event input
    $05 constant EXTI_TR5                       \ [0x05] Rising trigger event configuration bit of Configurable Event input
    $06 constant EXTI_TR6                       \ [0x06] Rising trigger event configuration bit of Configurable Event input
    $07 constant EXTI_TR7                       \ [0x07] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_TR8                       \ [0x08] Rising trigger event configuration bit of Configurable Event input
    $09 constant EXTI_TR9                       \ [0x09] Rising trigger event configuration bit of Configurable Event input
    $0a constant EXTI_TR10                      \ [0x0a] Rising trigger event configuration bit of Configurable Event input
    $0b constant EXTI_TR11                      \ [0x0b] Rising trigger event configuration bit of Configurable Event input
    $0c constant EXTI_TR12                      \ [0x0c] Rising trigger event configuration bit of Configurable Event input
    $0d constant EXTI_TR13                      \ [0x0d] Rising trigger event configuration bit of Configurable Event input
    $0e constant EXTI_TR14                      \ [0x0e] Rising trigger event configuration bit of Configurable Event input
    $0f constant EXTI_TR15                      \ [0x0f] Rising trigger event configuration bit of Configurable Event input
    $10 constant EXTI_TR16                      \ [0x10] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_SWIER1_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWIER0                    \ [0x00] Rising trigger event configuration bit of Configurable Event input
    $01 constant EXTI_SWIER1                    \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $02 constant EXTI_SWIER2                    \ [0x02] Rising trigger event configuration bit of Configurable Event input
    $03 constant EXTI_SWIER3                    \ [0x03] Rising trigger event configuration bit of Configurable Event input
    $04 constant EXTI_SWIER4                    \ [0x04] Rising trigger event configuration bit of Configurable Event input
    $05 constant EXTI_SWIER5                    \ [0x05] Rising trigger event configuration bit of Configurable Event input
    $06 constant EXTI_SWIER6                    \ [0x06] Rising trigger event configuration bit of Configurable Event input
    $07 constant EXTI_SWIER7                    \ [0x07] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_SWIER8                    \ [0x08] Rising trigger event configuration bit of Configurable Event input
    $09 constant EXTI_SWIER9                    \ [0x09] Rising trigger event configuration bit of Configurable Event input
    $0a constant EXTI_SWIER10                   \ [0x0a] Rising trigger event configuration bit of Configurable Event input
    $0b constant EXTI_SWIER11                   \ [0x0b] Rising trigger event configuration bit of Configurable Event input
    $0c constant EXTI_SWIER12                   \ [0x0c] Rising trigger event configuration bit of Configurable Event input
    $0d constant EXTI_SWIER13                   \ [0x0d] Rising trigger event configuration bit of Configurable Event input
    $0e constant EXTI_SWIER14                   \ [0x0e] Rising trigger event configuration bit of Configurable Event input
    $0f constant EXTI_SWIER15                   \ [0x0f] Rising trigger event configuration bit of Configurable Event input
    $10 constant EXTI_SWIER16                   \ [0x10] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_RPR1_DEF
    \
    \ @brief EXTI rising edge pending register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RPIF0                     \ [0x00] configurable event inputs x rising edge Pending bit.
    $01 constant EXTI_RPIF1                     \ [0x01] configurable event inputs x rising edge Pending bit.
    $02 constant EXTI_RPIF2                     \ [0x02] configurable event inputs x rising edge Pending bit.
    $03 constant EXTI_RPIF3                     \ [0x03] configurable event inputs x rising edge Pending bit.
    $04 constant EXTI_RPIF4                     \ [0x04] configurable event inputs x rising edge Pending bit.
    $05 constant EXTI_RPIF5                     \ [0x05] configurable event inputs x rising edge Pending bit
    $06 constant EXTI_RPIF6                     \ [0x06] configurable event inputs x rising edge Pending bit.
    $07 constant EXTI_RPIF7                     \ [0x07] configurable event inputs x rising edge Pending bit.
    $08 constant EXTI_RPIF8                     \ [0x08] configurable event inputs x rising edge Pending bit.
    $09 constant EXTI_RPIF9                     \ [0x09] configurable event inputs x rising edge Pending bit.
    $0a constant EXTI_RPIF10                    \ [0x0a] configurable event inputs x rising edge Pending bit.
    $0b constant EXTI_RPIF11                    \ [0x0b] configurable event inputs x rising edge Pending bit.
    $0c constant EXTI_RPIF12                    \ [0x0c] configurable event inputs x rising edge Pending bit.
    $0d constant EXTI_RPIF13                    \ [0x0d] configurable event inputs x rising edge Pending bit.
    $0e constant EXTI_RPIF14                    \ [0x0e] configurable event inputs x rising edge Pending bit.
    $0f constant EXTI_RPIF15                    \ [0x0f] configurable event inputs x rising edge Pending bit.
    $10 constant EXTI_RPIF16                    \ [0x10] configurable event inputs x rising edge Pending bit.
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
    $13 constant EXTI_IM19                      \ [0x13] CPU wakeup with interrupt mask on event input
    $14 constant EXTI_IM20                      \ [0x14] CPU wakeup with interrupt mask on event input
    $15 constant EXTI_IM21                      \ [0x15] CPU wakeup with interrupt mask on event input
    $16 constant EXTI_IM22                      \ [0x16] CPU wakeup with interrupt mask on event input
    $17 constant EXTI_IM23                      \ [0x17] CPU wakeup with interrupt mask on event input
    $18 constant EXTI_IM24                      \ [0x18] CPU wakeup with interrupt mask on event input
    $19 constant EXTI_IM25                      \ [0x19] CPU wakeup with interrupt mask on event input
    $1a constant EXTI_IM26                      \ [0x1a] CPU wakeup with interrupt mask on event input
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
    $13 constant EXTI_EM19                      \ [0x13] CPU wakeup with event mask on event input
    $15 constant EXTI_EM21                      \ [0x15] CPU wakeup with event mask on event input
    $17 constant EXTI_EM23                      \ [0x17] CPU wakeup with event mask on event input
    $19 constant EXTI_EM25                      \ [0x19] CPU wakeup with event mask on event input
    $1a constant EXTI_EM26                      \ [0x1a] CPU wakeup with event mask on event input
    $1c constant EXTI_EM28                      \ [0x1c] CPU wakeup with event mask on event input
    $1d constant EXTI_EM29                      \ [0x1d] CPU wakeup with event mask on event input
    $1e constant EXTI_EM30                      \ [0x1e] CPU wakeup with event mask on event input
    $1f constant EXTI_EM31                      \ [0x1f] CPU wakeup with event mask on event input
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_RTSR1               \ EXTI rising trigger selection register
  $04 constant EXTI_FTSR1               \ EXTI falling trigger selection register
  $08 constant EXTI_SWIER1              \ EXTI software interrupt event register
  $0C constant EXTI_RPR1                \ EXTI rising edge pending register
  $10 constant EXTI_FPR1                \ EXTI falling edge pending register
  $60 constant EXTI_EXTICR1             \ EXTI external interrupt selection register
  $64 constant EXTI_EXTICR2             \ EXTI external interrupt selection register
  $68 constant EXTI_EXTICR3             \ EXTI external interrupt selection register
  $6C constant EXTI_EXTICR4             \ EXTI external interrupt selection register
  $80 constant EXTI_IMR1                \ EXTI CPU wakeup with interrupt mask register
  $84 constant EXTI_EMR1                \ EXTI CPU wakeup with event mask register

: EXTI_DEF ; [then]
