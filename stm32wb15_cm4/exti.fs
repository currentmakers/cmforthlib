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
    $00 constant EXTI_RT                        \ [0x00 : 21] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_FTSR1_DEF
    \
    \ @brief falling trigger selection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT                        \ [0x00 : 21] Falling trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_SWIER1_DEF
    \
    \ @brief software interrupt event register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI                       \ [0x00 : 21] Software interrupt on event
  [then]


  [ifdef] EXTI_PR1_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PIF                       \ [0x00 : 21] Configurable event inputs Pending bit
  [then]


  [ifdef] EXTI_RTSR2_DEF
    \
    \ @brief rising trigger selection register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_RT33                      \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_RT40                      \ [0x08] Rising trigger event configuration bit of Configurable Event input 40
    $09 constant EXTI_RT41                      \ [0x09] Rising trigger event configuration bit of Configurable Event input 41
  [then]


  [ifdef] EXTI_FTSR2_DEF
    \
    \ @brief falling trigger selection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_FT33                      \ [0x01] Falling trigger event configuration bit of Configurable Event input
    $08 constant EXTI_FT40                      \ [0x08] Falling trigger event configuration bit of configurable event input 40
    $09 constant EXTI_FT41                      \ [0x09] Falling trigger event configuration bit of configurable event input 41
  [then]


  [ifdef] EXTI_SWIER2_DEF
    \
    \ @brief software interrupt event register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_SWI33                     \ [0x01] Software interrupt on event
    $08 constant EXTI_SWI40                     \ [0x08] Software interrupt on event
    $09 constant EXTI_SWI41                     \ [0x09] Software interrupt on event
  [then]


  [ifdef] EXTI_PR2_DEF
    \
    \ @brief pending register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_PIF33                     \ [0x01] Configurable event inputs x+32 Pending bit.
    $08 constant EXTI_PIF40                     \ [0x08] Configurable event inputs x+32 Pending bit.
    $09 constant EXTI_PIF41                     \ [0x09] Configurable event inputs x+32 Pending bit.
  [then]


  [ifdef] EXTI_IMR1_DEF
    \
    \ @brief CPUm wakeup with interrupt mask register
    \ Address offset: 0x80
    \ Reset value: 0x7FC00000
    \
    $00 constant EXTI_IM                        \ [0x00 : 32] CPU(m) wakeup with interrupt Mask on Event input
  [then]


  [ifdef] EXTI_EMR1_DEF
    \
    \ @brief CPUm wakeup with event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0_15                    \ [0x00 : 16] CPU(m) Wakeup with event generation Mask on Event input
    $11 constant EXTI_EM17_20                   \ [0x11 : 4] CPU(m) Wakeup with event generation Mask on Event input
  [then]


  [ifdef] EXTI_IMR2_DEF
    \
    \ @brief CPUm wakeup with interrupt mask register
    \ Address offset: 0x90
    \ Reset value: 0x0001FCFD
    \
    $01 constant EXTI_IM                        \ [0x01 : 17] CPUm Wakeup with interrupt Mask on Event input
  [then]


  [ifdef] EXTI_EMR2_DEF
    \
    \ @brief CPUm wakeup with event mask register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $08 constant EXTI_EM                        \ [0x08 : 2] CPU(m) Wakeup with event generation Mask on Event input
  [then]


  [ifdef] EXTI_C2IMR1_DEF
    \
    \ @brief CPUm wakeup with interrupt mask register
    \ Address offset: 0xC0
    \ Reset value: 0x7FC00000
    \
    $00 constant EXTI_IM                        \ [0x00 : 32] CPU(m) wakeup with interrupt Mask on Event input
  [then]


  [ifdef] EXTI_C2EMR1_DEF
    \
    \ @brief CPUm wakeup with event mask register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0_15                    \ [0x00 : 16] CPU(m) Wakeup with event generation Mask on Event input
    $11 constant EXTI_EM17_20                   \ [0x11 : 4] CPU(m) Wakeup with event generation Mask on Event input
  [then]


  [ifdef] EXTI_C2IMR2_DEF
    \
    \ @brief CPUm wakeup with interrupt mask register
    \ Address offset: 0xD0
    \ Reset value: 0x0001FCFD
    \
    $01 constant EXTI_IM                        \ [0x01 : 17] CPUm Wakeup with interrupt Mask on Event input
  [then]


  [ifdef] EXTI_C2EMR2_DEF
    \
    \ @brief CPUm wakeup with event mask register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $08 constant EXTI_EM                        \ [0x08 : 2] CPU(m) Wakeup with event generation Mask on Event input
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
  $80 constant EXTI_IMR1                \ CPUm wakeup with interrupt mask register
  $84 constant EXTI_EMR1                \ CPUm wakeup with event mask register
  $90 constant EXTI_IMR2                \ CPUm wakeup with interrupt mask register
  $94 constant EXTI_EMR2                \ CPUm wakeup with event mask register
  $C0 constant EXTI_C2IMR1              \ CPUm wakeup with interrupt mask register
  $C4 constant EXTI_C2EMR1              \ CPUm wakeup with event mask register
  $D0 constant EXTI_C2IMR2              \ CPUm wakeup with interrupt mask register
  $D4 constant EXTI_C2EMR2              \ CPUm wakeup with event mask register

: EXTI_DEF ; [then]
