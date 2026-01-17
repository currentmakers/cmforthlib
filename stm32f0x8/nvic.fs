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
    $06 constant NVIC_PRI_00                    \ [0x06 : 2] PRI_00
    $0e constant NVIC_PRI_01                    \ [0x0e : 2] PRI_01
    $16 constant NVIC_PRI_02                    \ [0x16 : 2] PRI_02
    $1e constant NVIC_PRI_03                    \ [0x1e : 2] PRI_03
  [then]


  [ifdef] NVIC_IPR1_DEF
    \
    \ @brief Interrupt Priority Register 1
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $06 constant NVIC_PRI_40                    \ [0x06 : 2] PRI_40
    $0e constant NVIC_PRI_41                    \ [0x0e : 2] PRI_41
    $16 constant NVIC_PRI_42                    \ [0x16 : 2] PRI_42
    $1e constant NVIC_PRI_43                    \ [0x1e : 2] PRI_43
  [then]


  [ifdef] NVIC_IPR2_DEF
    \
    \ @brief Interrupt Priority Register 2
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $06 constant NVIC_PRI_80                    \ [0x06 : 2] PRI_80
    $0e constant NVIC_PRI_81                    \ [0x0e : 2] PRI_81
    $16 constant NVIC_PRI_82                    \ [0x16 : 2] PRI_82
    $1e constant NVIC_PRI_83                    \ [0x1e : 2] PRI_83
  [then]


  [ifdef] NVIC_IPR3_DEF
    \
    \ @brief Interrupt Priority Register 3
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $06 constant NVIC_PRI_120                   \ [0x06 : 2] PRI_120
    $0e constant NVIC_PRI_121                   \ [0x0e : 2] PRI_121
    $16 constant NVIC_PRI_122                   \ [0x16 : 2] PRI_122
    $1e constant NVIC_PRI_123                   \ [0x1e : 2] PRI_123
  [then]


  [ifdef] NVIC_IPR4_DEF
    \
    \ @brief Interrupt Priority Register 4
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $06 constant NVIC_PRI_160                   \ [0x06 : 2] PRI_160
    $0e constant NVIC_PRI_161                   \ [0x0e : 2] PRI_161
    $16 constant NVIC_PRI_162                   \ [0x16 : 2] PRI_162
    $1e constant NVIC_PRI_163                   \ [0x1e : 2] PRI_163
  [then]


  [ifdef] NVIC_IPR5_DEF
    \
    \ @brief Interrupt Priority Register 5
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $06 constant NVIC_PRI_200                   \ [0x06 : 2] PRI_200
    $0e constant NVIC_PRI_201                   \ [0x0e : 2] PRI_201
    $16 constant NVIC_PRI_202                   \ [0x16 : 2] PRI_202
    $1e constant NVIC_PRI_203                   \ [0x1e : 2] PRI_203
  [then]


  [ifdef] NVIC_IPR6_DEF
    \
    \ @brief Interrupt Priority Register 6
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $06 constant NVIC_PRI_240                   \ [0x06 : 2] PRI_240
    $0e constant NVIC_PRI_241                   \ [0x0e : 2] PRI_241
    $16 constant NVIC_PRI_242                   \ [0x16 : 2] PRI_242
    $1e constant NVIC_PRI_243                   \ [0x1e : 2] PRI_243
  [then]


  [ifdef] NVIC_IPR7_DEF
    \
    \ @brief Interrupt Priority Register 7
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $06 constant NVIC_PRI_280                   \ [0x06 : 2] PRI_280
    $0e constant NVIC_PRI_281                   \ [0x0e : 2] PRI_281
    $16 constant NVIC_PRI_282                   \ [0x16 : 2] PRI_282
    $1e constant NVIC_PRI_283                   \ [0x1e : 2] PRI_283
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

: NVIC_DEF ; [then]
