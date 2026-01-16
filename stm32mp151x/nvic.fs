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
\ @brief Interrupt Set-Enable Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISER3_SETENA                                \ SETENA


\
\ @brief Interrupt Set-Enable Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\


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
\ @brief Interrupt Clear-Enable Register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICER3_CLRENA                                \ CLRENA


\
\ @brief Interrupt Clear-Enable Register
\ Address offset: 0x90
\ Reset value: 0x00000000
\


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
\ @brief Interrupt Set-Pending Register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ISPR3_SETPEND                               \ SETPEND


\
\ @brief Interrupt Set-Pending Register
\ Address offset: 0x110
\ Reset value: 0x00000000
\


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
\ @brief Interrupt Clear-Pending Register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant NVIC_ICPR3_CLRPEND                               \ CLRPEND


\
\ @brief Interrupt Clear-Pending Register
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\


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
\ @brief Interrupt Active Bit Register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000000 constant NVIC_IABR3_ACTIVE                                \ ACTIVE


\
\ @brief Interrupt Active Bit Register
\ Address offset: 0x210
\ Reset value: 0x00000000
\


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
\ @brief Interrupt Priority Register
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR21_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR21_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR21_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR21_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x358
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR22_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR22_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR22_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR22_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR23_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR23_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR23_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR23_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR24_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR24_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR24_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR24_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR25_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR25_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR25_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR25_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x368
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR26_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR26_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR26_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR26_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x36C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR27_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR27_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR27_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR27_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR28_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR28_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR28_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR28_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x374
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR29_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR29_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR29_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR29_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x378
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR30_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR30_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR30_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR30_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x37C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR31_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR31_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR31_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR31_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR32_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR32_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR32_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR32_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR33_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR33_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR33_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR33_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR34_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR34_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR34_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR34_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR35_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR35_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR35_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR35_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR36_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR36_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR36_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR36_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR37_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR37_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR37_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR37_IPR_N3                                \ IPR_N3


\
\ @brief Interrupt Priority Register
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$000000ff constant NVIC_IPR38_IPR_N0                                \ IPR_N0
$0000ff00 constant NVIC_IPR38_IPR_N1                                \ IPR_N1
$00ff0000 constant NVIC_IPR38_IPR_N2                                \ IPR_N2
$ff000000 constant NVIC_IPR38_IPR_N3                                \ IPR_N3


\
\ @brief Nested Vectored Interrupt Controller
\
$e000e100 constant NVIC_ISER0     \ offset: 0x00 : Interrupt Set-Enable Register
$e000e104 constant NVIC_ISER1     \ offset: 0x04 : Interrupt Set-Enable Register
$e000e108 constant NVIC_ISER2     \ offset: 0x08 : Interrupt Set-Enable Register
$e000e10c constant NVIC_ISER3     \ offset: 0x0C : Interrupt Set-Enable Register
$e000e110 constant NVIC_ISER4     \ offset: 0x10 : Interrupt Set-Enable Register
$e000e180 constant NVIC_ICER0     \ offset: 0x80 : Interrupt Clear-Enable Register
$e000e184 constant NVIC_ICER1     \ offset: 0x84 : Interrupt Clear-Enable Register
$e000e188 constant NVIC_ICER2     \ offset: 0x88 : Interrupt Clear-Enable Register
$e000e18c constant NVIC_ICER3     \ offset: 0x8C : Interrupt Clear-Enable Register
$e000e190 constant NVIC_ICER4     \ offset: 0x90 : Interrupt Clear-Enable Register
$e000e200 constant NVIC_ISPR0     \ offset: 0x100 : Interrupt Set-Pending Register
$e000e204 constant NVIC_ISPR1     \ offset: 0x104 : Interrupt Set-Pending Register
$e000e208 constant NVIC_ISPR2     \ offset: 0x108 : Interrupt Set-Pending Register
$e000e20c constant NVIC_ISPR3     \ offset: 0x10C : Interrupt Set-Pending Register
$e000e210 constant NVIC_ISPR4     \ offset: 0x110 : Interrupt Set-Pending Register
$e000e280 constant NVIC_ICPR0     \ offset: 0x180 : Interrupt Clear-Pending Register
$e000e284 constant NVIC_ICPR1     \ offset: 0x184 : Interrupt Clear-Pending Register
$e000e288 constant NVIC_ICPR2     \ offset: 0x188 : Interrupt Clear-Pending Register
$e000e28c constant NVIC_ICPR3     \ offset: 0x18C : Interrupt Clear-Pending Register
$e000e2c4 constant NVIC_ICPR4     \ offset: 0x1C4 : Interrupt Clear-Pending Register
$e000e300 constant NVIC_IABR0     \ offset: 0x200 : Interrupt Active Bit Register
$e000e304 constant NVIC_IABR1     \ offset: 0x204 : Interrupt Active Bit Register
$e000e308 constant NVIC_IABR2     \ offset: 0x208 : Interrupt Active Bit Register
$e000e30c constant NVIC_IABR3     \ offset: 0x20C : Interrupt Active Bit Register
$e000e310 constant NVIC_IABR4     \ offset: 0x210 : Interrupt Active Bit Register
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
$e000e454 constant NVIC_IPR21     \ offset: 0x354 : Interrupt Priority Register
$e000e458 constant NVIC_IPR22     \ offset: 0x358 : Interrupt Priority Register
$e000e45c constant NVIC_IPR23     \ offset: 0x35C : Interrupt Priority Register
$e000e460 constant NVIC_IPR24     \ offset: 0x360 : Interrupt Priority Register
$e000e464 constant NVIC_IPR25     \ offset: 0x364 : Interrupt Priority Register
$e000e468 constant NVIC_IPR26     \ offset: 0x368 : Interrupt Priority Register
$e000e46c constant NVIC_IPR27     \ offset: 0x36C : Interrupt Priority Register
$e000e470 constant NVIC_IPR28     \ offset: 0x370 : Interrupt Priority Register
$e000e474 constant NVIC_IPR29     \ offset: 0x374 : Interrupt Priority Register
$e000e478 constant NVIC_IPR30     \ offset: 0x378 : Interrupt Priority Register
$e000e47c constant NVIC_IPR31     \ offset: 0x37C : Interrupt Priority Register
$e000e480 constant NVIC_IPR32     \ offset: 0x380 : Interrupt Priority Register
$e000e484 constant NVIC_IPR33     \ offset: 0x384 : Interrupt Priority Register
$e000e488 constant NVIC_IPR34     \ offset: 0x388 : Interrupt Priority Register
$e000e48c constant NVIC_IPR35     \ offset: 0x38C : Interrupt Priority Register
$e000e490 constant NVIC_IPR36     \ offset: 0x390 : Interrupt Priority Register
$e000e494 constant NVIC_IPR37     \ offset: 0x394 : Interrupt Priority Register
$e000e498 constant NVIC_IPR38     \ offset: 0x398 : Interrupt Priority Register

