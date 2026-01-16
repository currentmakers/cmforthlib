\
\ @file nvic.fs
\ @brief Nested Vectored Interrupt       Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Interrupt Set-Enable Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISER0_SETENA                                \ SETENA


\
\ @brief Interrupt Set-Enable Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISER1_SETENA                                \ SETENA


\
\ @brief Interrupt Set-Enable Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISER2_SETENA                                \ SETENA


\
\ @brief Interrupt Clear-Enable Register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICER0_CLRENA                                \ CLRENA


\
\ @brief Interrupt Clear-Enable Register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICER1_CLRENA                                \ CLRENA


\
\ @brief Interrupt Clear-Enable Register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICER2_CLRENA                                \ CLRENA


\
\ @brief Interrupt Set-Pending Register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISPR0_SETPEND                               \ SETPEND


\
\ @brief Interrupt Set-Pending Register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISPR1_SETPEND                               \ SETPEND


\
\ @brief Interrupt Set-Pending Register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISPR2_SETPEND                               \ SETPEND


\
\ @brief Interrupt Clear-Pending Register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICPR0_CLRPEND                               \ CLRPEND


\
\ @brief Interrupt Clear-Pending Register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICPR1_CLRPEND                               \ CLRPEND


\
\ @brief Interrupt Clear-Pending Register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICPR2_CLRPEND                               \ CLRPEND


\
\ @brief Interrupt Active Bit Register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000000 constant NVIC_IABR0_ACTIVE                                \ ACTIVE


\
\ @brief Interrupt Active Bit Register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000000 constant NVIC_IABR1_ACTIVE                                \ ACTIVE


\
\ @brief Interrupt Active Bit Register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant NVIC_IABR2_ACTIVE                                \ ACTIVE


\
\ @brief Interrupt Priority Register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR0_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR0_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR0_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR0_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR1_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR1_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR1_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR1_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR2_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR2_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR2_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR2_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR3_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR3_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR3_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR3_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR4_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR4_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR4_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR4_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR5_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR5_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR5_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR5_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR6_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR6_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR6_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR6_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR7_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR7_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR7_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR7_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR8_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR8_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR8_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR8_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR9_IPR_N0                                 \ IPR_N0
$0000ff00 constant NVIC_IPR9_IPR_N1                                 \ IPR_N1
$00ff0000 constant NVIC_IPR9_IPR_N2                                 \ IPR_N2
$ff000000 constant NVIC_IPR9_IPR_N3                                 \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR10_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR10_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR10_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR10_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR11_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR11_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR11_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR11_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR12_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR12_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR12_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR12_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR13_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR13_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR13_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR13_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR14_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR14_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR14_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR14_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x33C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR15_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR15_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR15_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR15_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR16_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR16_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR16_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR16_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR17_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR17_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR17_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR17_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR18_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR18_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR18_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR18_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR19_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR19_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR19_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR19_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR20_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR20_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR20_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR20_IPR_N3                                \ IPR_N3


\
\ @brief Nested Vectored Interrupt Controller
\
$e000e100 constant NVIC_ISER0     \ offset: 0x00 : Interrupt Set-Enable Register
$e000e104 constant NVIC_ISER1     \ offset: 0x04 : Interrupt Set-Enable Register
$e000e108 constant NVIC_ISER2     \ offset: 0x08 : Interrupt Set-Enable Register
$e000e180 constant NVIC_ICER0     \ offset: 0x80 : Interrupt Clear-Enable Register
$e000e184 constant NVIC_ICER1     \ offset: 0x84 : Interrupt Clear-Enable Register
$e000e188 constant NVIC_ICER2     \ offset: 0x88 : Interrupt Clear-Enable Register
$e000e200 constant NVIC_ISPR0     \ offset: 0x100 : Interrupt Set-Pending Register
$e000e204 constant NVIC_ISPR1     \ offset: 0x104 : Interrupt Set-Pending Register
$e000e208 constant NVIC_ISPR2     \ offset: 0x108 : Interrupt Set-Pending Register
$e000e280 constant NVIC_ICPR0     \ offset: 0x180 : Interrupt Clear-Pending Register
$e000e284 constant NVIC_ICPR1     \ offset: 0x184 : Interrupt Clear-Pending Register
$e000e288 constant NVIC_ICPR2     \ offset: 0x188 : Interrupt Clear-Pending Register
$e000e300 constant NVIC_IABR0     \ offset: 0x200 : Interrupt Active Bit Register
$e000e304 constant NVIC_IABR1     \ offset: 0x204 : Interrupt Active Bit Register
$e000e308 constant NVIC_IABR2     \ offset: 0x208 : Interrupt Active Bit Register
$e000e400 constant NVIC_IPR0      \ offset: 0x300 : Interrupt Priority Register
$e000e404 constant NVIC_IPR1      \ offset: 0x304 : Interrupt Priority Register
$e000e408 constant NVIC_IPR2      \ offset: 0x308 : Interrupt Priority Register
$e000e40c constant NVIC_IPR3      \ offset: 0x30C : Interrupt Priority Register
$e000e410 constant NVIC_IPR4      \ offset: 0x310 : Interrupt Priority Register
$e000e414 constant NVIC_IPR5      \ offset: 0x314 : Interrupt Priority Register
$e000e418 constant NVIC_IPR6      \ offset: 0x318 : Interrupt Priority Register
$e000e41c constant NVIC_IPR7      \ offset: 0x31C : Interrupt Priority Register
$e000e420 constant NVIC_IPR8      \ offset: 0x320 : Interrupt Priority Register
$e000e424 constant NVIC_IPR9      \ offset: 0x324 : Interrupt Priority Register
$e000e428 constant NVIC_IPR10     \ offset: 0x328 : Interrupt Priority Register
$e000e42c constant NVIC_IPR11     \ offset: 0x32C : Interrupt Priority Register
$e000e430 constant NVIC_IPR12     \ offset: 0x330 : Interrupt Priority Register
$e000e434 constant NVIC_IPR13     \ offset: 0x334 : Interrupt Priority Register
$e000e438 constant NVIC_IPR14     \ offset: 0x338 : Interrupt Priority Register
$e000e43c constant NVIC_IPR15     \ offset: 0x33C : Interrupt Priority Register
$e000e440 constant NVIC_IPR16     \ offset: 0x340 : Interrupt Priority Register
$e000e444 constant NVIC_IPR17     \ offset: 0x344 : Interrupt Priority Register
$e000e448 constant NVIC_IPR18     \ offset: 0x348 : Interrupt Priority Register
$e000e44c constant NVIC_IPR19     \ offset: 0x34C : Interrupt Priority Register
$e000e450 constant NVIC_IPR20     \ offset: 0x350 : Interrupt Priority Register

