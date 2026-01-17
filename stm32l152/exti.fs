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
    \ @brief IMR
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR                        \ [0x00 : 23] Interrupt mask on line x
  [then]


  [ifdef] EXTI_EMR_DEF
    \
    \ @brief EMR
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR                        \ [0x00 : 23] Event mask on line x
  [then]


  [ifdef] EXTI_RTSR_DEF
    \
    \ @brief RTSR
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TR                        \ [0x00 : 23] Rising edge trigger event configuration bit of line x
  [then]


  [ifdef] EXTI_FTSR_DEF
    \
    \ @brief FTSR
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TR                        \ [0x00 : 23] Falling edge trigger event configuration bit of line x
  [then]


  [ifdef] EXTI_SWIER_DEF
    \
    \ @brief SWIER
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWIER                     \ [0x00 : 23] Software interrupt on line x
  [then]


  [ifdef] EXTI_PR_DEF
    \
    \ @brief PR
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PR                        \ [0x00 : 23] Pending bit
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_IMR                 \ IMR
  $04 constant EXTI_EMR                 \ EMR
  $08 constant EXTI_RTSR                \ RTSR
  $0C constant EXTI_FTSR                \ FTSR
  $10 constant EXTI_SWIER               \ SWIER
  $14 constant EXTI_PR                  \ PR

: EXTI_DEF ; [then]
