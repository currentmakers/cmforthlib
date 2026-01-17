\
\ @file nvic.fs
\ @brief Nested Vectored Interrupt Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] NVIC_DEF

  [ifdef] NVIC_ISER_DEF
    \
    \ @brief Interrupt Set Enable Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_SETENA                    \ [0x00 : 32] SETENA
  [then]


  [ifdef] NVIC_ICER_DEF
    \
    \ @brief Interrupt Clear Enable Register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_CLRENA                    \ [0x00 : 32] CLRENA
  [then]


  [ifdef] NVIC_ISPR_DEF
    \
    \ @brief Interrupt Set-Pending Register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_SETPEND                   \ [0x00 : 32] SETPEND
  [then]


  [ifdef] NVIC_ICPR_DEF
    \
    \ @brief Interrupt Clear-Pending Register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_CLRPEND                   \ [0x00 : 32] CLRPEND
  [then]


  [ifdef] NVIC_IPR0_DEF
    \
    \ @brief Interrupt Priority Register 0
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_PRI_0                     \ [0x00 : 8] priority for interrupt 0
    $08 constant NVIC_PRI_1                     \ [0x08 : 8] priority for interrupt 1
    $10 constant NVIC_PRI_2                     \ [0x10 : 8] priority for interrupt 2
    $18 constant NVIC_PRI_3                     \ [0x18 : 8] priority for interrupt 3
  [then]


  [ifdef] NVIC_IPR1_DEF
    \
    \ @brief Interrupt Priority Register 1
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_PRI_4                     \ [0x00 : 8] priority for interrupt n
    $08 constant NVIC_PRI_5                     \ [0x08 : 8] priority for interrupt n
    $10 constant NVIC_PRI_6                     \ [0x10 : 8] priority for interrupt n
    $18 constant NVIC_PRI_7                     \ [0x18 : 8] priority for interrupt n
  [then]


  [ifdef] NVIC_IPR2_DEF
    \
    \ @brief Interrupt Priority Register 2
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_PRI_8                     \ [0x00 : 8] priority for interrupt n
    $08 constant NVIC_PRI_9                     \ [0x08 : 8] priority for interrupt n
    $10 constant NVIC_PRI_10                    \ [0x10 : 8] priority for interrupt n
    $18 constant NVIC_PRI_11                    \ [0x18 : 8] priority for interrupt n
  [then]


  [ifdef] NVIC_IPR3_DEF
    \
    \ @brief Interrupt Priority Register 3
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_PRI_12                    \ [0x00 : 8] priority for interrupt n
    $08 constant NVIC_PRI_13                    \ [0x08 : 8] priority for interrupt n
    $10 constant NVIC_PRI_14                    \ [0x10 : 8] priority for interrupt n
    $18 constant NVIC_PRI_15                    \ [0x18 : 8] priority for interrupt n
  [then]


  [ifdef] NVIC_IPR4_DEF
    \
    \ @brief Interrupt Priority Register 4
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_PRI_16                    \ [0x00 : 8] priority for interrupt n
    $08 constant NVIC_PRI_17                    \ [0x08 : 8] priority for interrupt n
    $10 constant NVIC_PRI_18                    \ [0x10 : 8] priority for interrupt n
    $18 constant NVIC_PRI_19                    \ [0x18 : 8] priority for interrupt n
  [then]


  [ifdef] NVIC_IPR5_DEF
    \
    \ @brief Interrupt Priority Register 5
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_PRI_20                    \ [0x00 : 8] priority for interrupt n
    $08 constant NVIC_PRI_21                    \ [0x08 : 8] priority for interrupt n
    $10 constant NVIC_PRI_22                    \ [0x10 : 8] priority for interrupt n
    $18 constant NVIC_PRI_23                    \ [0x18 : 8] priority for interrupt n
  [then]


  [ifdef] NVIC_IPR6_DEF
    \
    \ @brief Interrupt Priority Register 6
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_PRI_24                    \ [0x00 : 8] priority for interrupt n
    $08 constant NVIC_PRI_25                    \ [0x08 : 8] priority for interrupt n
    $10 constant NVIC_PRI_26                    \ [0x10 : 8] priority for interrupt n
    $18 constant NVIC_PRI_27                    \ [0x18 : 8] priority for interrupt n
  [then]


  [ifdef] NVIC_IPR7_DEF
    \
    \ @brief Interrupt Priority Register 7
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant NVIC_PRI_28                    \ [0x00 : 8] priority for interrupt n
    $08 constant NVIC_PRI_29                    \ [0x08 : 8] priority for interrupt n
    $10 constant NVIC_PRI_30                    \ [0x10 : 8] priority for interrupt n
    $18 constant NVIC_PRI_31                    \ [0x18 : 8] priority for interrupt n
  [then]


  [ifdef] NVIC_IPR8_DEF
    \
    \ @brief Interrupt Priority Register 8
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
  [then]

  \
  \ @brief Nested Vectored Interrupt Controller
  \
  $00 constant NVIC_ISER                \ Interrupt Set Enable Register
  $80 constant NVIC_ICER                \ Interrupt Clear Enable Register
  $100 constant NVIC_ISPR               \ Interrupt Set-Pending Register
  $180 constant NVIC_ICPR               \ Interrupt Clear-Pending Register
  $300 constant NVIC_IPR0               \ Interrupt Priority Register 0
  $304 constant NVIC_IPR1               \ Interrupt Priority Register 1
  $308 constant NVIC_IPR2               \ Interrupt Priority Register 2
  $30C constant NVIC_IPR3               \ Interrupt Priority Register 3
  $310 constant NVIC_IPR4               \ Interrupt Priority Register 4
  $314 constant NVIC_IPR5               \ Interrupt Priority Register 5
  $318 constant NVIC_IPR6               \ Interrupt Priority Register 6
  $31C constant NVIC_IPR7               \ Interrupt Priority Register 7
  $320 constant NVIC_IPR8               \ Interrupt Priority Register 8

: NVIC_DEF ; [then]
