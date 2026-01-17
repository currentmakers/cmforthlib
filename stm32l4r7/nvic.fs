\
\ @file nvic.fs
\ @brief Nested Vectored Interrupt Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] NVIC_DEF

  [ifdef] NVIC_ISER0_DEF
    \
    \ @brief Interrupt Set-Enable Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_SETENA                    \ [0x00 : 32] SETENA
  [then]


  [ifdef] NVIC_ISER1_DEF
    \
    \ @brief Interrupt Set-Enable Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_SETENA                    \ [0x00 : 32] SETENA
  [then]


  [ifdef] NVIC_ISER2_DEF
    \
    \ @brief Interrupt Set-Enable Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_SETENA                    \ [0x00 : 32] SETENA
  [then]


  [ifdef] NVIC_ICER0_DEF
    \
    \ @brief Interrupt Clear-Enable Register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_CLRENA                    \ [0x00 : 32] CLRENA
  [then]


  [ifdef] NVIC_ICER1_DEF
    \
    \ @brief Interrupt Clear-Enable Register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_CLRENA                    \ [0x00 : 32] CLRENA
  [then]


  [ifdef] NVIC_ICER2_DEF
    \
    \ @brief Interrupt Clear-Enable Register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_CLRENA                    \ [0x00 : 32] CLRENA
  [then]


  [ifdef] NVIC_ISPR0_DEF
    \
    \ @brief Interrupt Set-Pending Register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_SETPEND                   \ [0x00 : 32] SETPEND
  [then]


  [ifdef] NVIC_ISPR1_DEF
    \
    \ @brief Interrupt Set-Pending Register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_SETPEND                   \ [0x00 : 32] SETPEND
  [then]


  [ifdef] NVIC_ISPR2_DEF
    \
    \ @brief Interrupt Set-Pending Register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_SETPEND                   \ [0x00 : 32] SETPEND
  [then]


  [ifdef] NVIC_ICPR0_DEF
    \
    \ @brief Interrupt Clear-Pending Register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_CLRPEND                   \ [0x00 : 32] CLRPEND
  [then]


  [ifdef] NVIC_ICPR1_DEF
    \
    \ @brief Interrupt Clear-Pending Register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_CLRPEND                   \ [0x00 : 32] CLRPEND
  [then]


  [ifdef] NVIC_ICPR2_DEF
    \
    \ @brief Interrupt Clear-Pending Register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_CLRPEND                   \ [0x00 : 32] CLRPEND
  [then]


  [ifdef] NVIC_IABR0_DEF
    \
    \ @brief Interrupt Active Bit Register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_ACTIVE                    \ [0x00 : 32] ACTIVE
  [then]


  [ifdef] NVIC_IABR1_DEF
    \
    \ @brief Interrupt Active Bit Register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_ACTIVE                    \ [0x00 : 32] ACTIVE
  [then]


  [ifdef] NVIC_IABR2_DEF
    \
    \ @brief Interrupt Active Bit Register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_ACTIVE                    \ [0x00 : 32] ACTIVE
  [then]


  [ifdef] NVIC_IPR0_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR1_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR2_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR3_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR4_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR5_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR6_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR7_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR8_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR9_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR10_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR11_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR12_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR13_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR14_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x338
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR15_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x33C
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR16_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR17_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR18_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR19_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]


  [ifdef] NVIC_IPR20_DEF
    \
    \ @brief Interrupt Priority Register
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_IPR_N0                    \ [0x00 : 8] IPR_N0
    $08 constant NVIC_IPR_N1                    \ [0x08 : 8] IPR_N1
    $10 constant NVIC_IPR_N2                    \ [0x10 : 8] IPR_N2
    $18 constant NVIC_IPR_N3                    \ [0x18 : 8] IPR_N3
  [then]

  \
  \ @brief Nested Vectored Interrupt Controller
  \
  $00 constant NVIC_ISER0               \ Interrupt Set-Enable Register
  $04 constant NVIC_ISER1               \ Interrupt Set-Enable Register
  $08 constant NVIC_ISER2               \ Interrupt Set-Enable Register
  $80 constant NVIC_ICER0               \ Interrupt Clear-Enable Register
  $84 constant NVIC_ICER1               \ Interrupt Clear-Enable Register
  $88 constant NVIC_ICER2               \ Interrupt Clear-Enable Register
  $100 constant NVIC_ISPR0              \ Interrupt Set-Pending Register
  $104 constant NVIC_ISPR1              \ Interrupt Set-Pending Register
  $108 constant NVIC_ISPR2              \ Interrupt Set-Pending Register
  $180 constant NVIC_ICPR0              \ Interrupt Clear-Pending Register
  $184 constant NVIC_ICPR1              \ Interrupt Clear-Pending Register
  $188 constant NVIC_ICPR2              \ Interrupt Clear-Pending Register
  $200 constant NVIC_IABR0              \ Interrupt Active Bit Register
  $204 constant NVIC_IABR1              \ Interrupt Active Bit Register
  $208 constant NVIC_IABR2              \ Interrupt Active Bit Register
  $300 constant NVIC_IPR0               \ Interrupt Priority Register
  $304 constant NVIC_IPR1               \ Interrupt Priority Register
  $308 constant NVIC_IPR2               \ Interrupt Priority Register
  $30C constant NVIC_IPR3               \ Interrupt Priority Register
  $310 constant NVIC_IPR4               \ Interrupt Priority Register
  $314 constant NVIC_IPR5               \ Interrupt Priority Register
  $318 constant NVIC_IPR6               \ Interrupt Priority Register
  $31C constant NVIC_IPR7               \ Interrupt Priority Register
  $320 constant NVIC_IPR8               \ Interrupt Priority Register
  $324 constant NVIC_IPR9               \ Interrupt Priority Register
  $328 constant NVIC_IPR10              \ Interrupt Priority Register
  $32C constant NVIC_IPR11              \ Interrupt Priority Register
  $330 constant NVIC_IPR12              \ Interrupt Priority Register
  $334 constant NVIC_IPR13              \ Interrupt Priority Register
  $338 constant NVIC_IPR14              \ Interrupt Priority Register
  $33C constant NVIC_IPR15              \ Interrupt Priority Register
  $340 constant NVIC_IPR16              \ Interrupt Priority Register
  $344 constant NVIC_IPR17              \ Interrupt Priority Register
  $348 constant NVIC_IPR18              \ Interrupt Priority Register
  $34C constant NVIC_IPR19              \ Interrupt Priority Register
  $350 constant NVIC_IPR20              \ Interrupt Priority Register

: NVIC_DEF ; [then]
