\
\ @file nvic.fs
\ @brief Nested Vectored Interrupt       Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Interrupt Set Enable Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISER_SETENA                                 \ SETENA


\
\ @brief Interrupt Clear Enable Register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICER_CLRENA                                 \ CLRENA


\
\ @brief Interrupt Set-Pending Register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISPR_SETPEND                                \ SETPEND


\
\ @brief Interrupt Clear-Pending Register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICPR_CLRPEND                                \ CLRPEND


\
\ @brief Interrupt Priority Register 0
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR0_PRI_0                                  \ priority for interrupt 0
$0000ff00 constant NVIC_IPR0_PRI_1                                  \ priority for interrupt 1
$00ff0000 constant NVIC_IPR0_PRI_2                                  \ priority for interrupt 2
$ff000000 constant NVIC_IPR0_PRI_3                                  \ priority for interrupt 3


\
\ @brief Interrupt Priority Register 1
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR1_PRI_4                                  \ priority for interrupt n
$0000ff00 constant NVIC_IPR1_PRI_5                                  \ priority for interrupt n
$00ff0000 constant NVIC_IPR1_PRI_6                                  \ priority for interrupt n
$ff000000 constant NVIC_IPR1_PRI_7                                  \ priority for interrupt n


\
\ @brief Interrupt Priority Register 2
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR2_PRI_8                                  \ priority for interrupt n
$0000ff00 constant NVIC_IPR2_PRI_9                                  \ priority for interrupt n
$00ff0000 constant NVIC_IPR2_PRI_10                                 \ priority for interrupt n
$ff000000 constant NVIC_IPR2_PRI_11                                 \ priority for interrupt n


\
\ @brief Interrupt Priority Register 3
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR3_PRI_12                                 \ priority for interrupt n
$0000ff00 constant NVIC_IPR3_PRI_13                                 \ priority for interrupt n
$00ff0000 constant NVIC_IPR3_PRI_14                                 \ priority for interrupt n
$ff000000 constant NVIC_IPR3_PRI_15                                 \ priority for interrupt n


\
\ @brief Interrupt Priority Register 4
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR4_PRI_16                                 \ priority for interrupt n
$0000ff00 constant NVIC_IPR4_PRI_17                                 \ priority for interrupt n
$00ff0000 constant NVIC_IPR4_PRI_18                                 \ priority for interrupt n
$ff000000 constant NVIC_IPR4_PRI_19                                 \ priority for interrupt n


\
\ @brief Interrupt Priority Register 5
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR5_PRI_20                                 \ priority for interrupt n
$0000ff00 constant NVIC_IPR5_PRI_21                                 \ priority for interrupt n
$00ff0000 constant NVIC_IPR5_PRI_22                                 \ priority for interrupt n
$ff000000 constant NVIC_IPR5_PRI_23                                 \ priority for interrupt n


\
\ @brief Interrupt Priority Register 6
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR6_PRI_24                                 \ priority for interrupt n
$0000ff00 constant NVIC_IPR6_PRI_25                                 \ priority for interrupt n
$00ff0000 constant NVIC_IPR6_PRI_26                                 \ priority for interrupt n
$ff000000 constant NVIC_IPR6_PRI_27                                 \ priority for interrupt n


\
\ @brief Interrupt Priority Register 7
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR7_PRI_28                                 \ priority for interrupt n
$0000ff00 constant NVIC_IPR7_PRI_29                                 \ priority for interrupt n
$00ff0000 constant NVIC_IPR7_PRI_30                                 \ priority for interrupt n
$ff000000 constant NVIC_IPR7_PRI_31                                 \ priority for interrupt n


\
\ @brief Nested Vectored Interrupt Controller
\
$e000e100 constant NVIC_ISER      \ offset: 0x00 : Interrupt Set Enable Register
$e000e180 constant NVIC_ICER      \ offset: 0x80 : Interrupt Clear Enable Register
$e000e200 constant NVIC_ISPR      \ offset: 0x100 : Interrupt Set-Pending Register
$e000e280 constant NVIC_ICPR      \ offset: 0x180 : Interrupt Clear-Pending Register
$e000e400 constant NVIC_IPR0      \ offset: 0x300 : Interrupt Priority Register 0
$e000e404 constant NVIC_IPR1      \ offset: 0x304 : Interrupt Priority Register 1
$e000e408 constant NVIC_IPR2      \ offset: 0x308 : Interrupt Priority Register 2
$e000e40c constant NVIC_IPR3      \ offset: 0x30C : Interrupt Priority Register 3
$e000e410 constant NVIC_IPR4      \ offset: 0x310 : Interrupt Priority Register 4
$e000e414 constant NVIC_IPR5      \ offset: 0x314 : Interrupt Priority Register 5
$e000e418 constant NVIC_IPR6      \ offset: 0x318 : Interrupt Priority Register 6
$e000e41c constant NVIC_IPR7      \ offset: 0x31C : Interrupt Priority Register 7

