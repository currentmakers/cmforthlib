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

$000000c0 constant NVIC_IPR0_PRI_00                                 \ PRI_00
$0000c000 constant NVIC_IPR0_PRI_01                                 \ PRI_01
$00c00000 constant NVIC_IPR0_PRI_02                                 \ PRI_02
$c0000000 constant NVIC_IPR0_PRI_03                                 \ PRI_03


\
\ @brief Interrupt Priority Register 1
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$000000c0 constant NVIC_IPR1_PRI_40                                 \ PRI_40
$0000c000 constant NVIC_IPR1_PRI_41                                 \ PRI_41
$00c00000 constant NVIC_IPR1_PRI_42                                 \ PRI_42
$c0000000 constant NVIC_IPR1_PRI_43                                 \ PRI_43


\
\ @brief Interrupt Priority Register 2
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$000000c0 constant NVIC_IPR2_PRI_80                                 \ PRI_80
$0000c000 constant NVIC_IPR2_PRI_81                                 \ PRI_81
$00c00000 constant NVIC_IPR2_PRI_82                                 \ PRI_82
$c0000000 constant NVIC_IPR2_PRI_83                                 \ PRI_83


\
\ @brief Interrupt Priority Register 3
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$000000c0 constant NVIC_IPR3_PRI_120                                \ PRI_120
$0000c000 constant NVIC_IPR3_PRI_121                                \ PRI_121
$00c00000 constant NVIC_IPR3_PRI_122                                \ PRI_122
$c0000000 constant NVIC_IPR3_PRI_123                                \ PRI_123


\
\ @brief Interrupt Priority Register 4
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$000000c0 constant NVIC_IPR4_PRI_160                                \ PRI_160
$0000c000 constant NVIC_IPR4_PRI_161                                \ PRI_161
$00c00000 constant NVIC_IPR4_PRI_162                                \ PRI_162
$c0000000 constant NVIC_IPR4_PRI_163                                \ PRI_163


\
\ @brief Interrupt Priority Register 5
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000c0 constant NVIC_IPR5_PRI_200                                \ PRI_200
$0000c000 constant NVIC_IPR5_PRI_201                                \ PRI_201
$00c00000 constant NVIC_IPR5_PRI_202                                \ PRI_202
$c0000000 constant NVIC_IPR5_PRI_203                                \ PRI_203


\
\ @brief Interrupt Priority Register 6
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$000000c0 constant NVIC_IPR6_PRI_240                                \ PRI_240
$0000c000 constant NVIC_IPR6_PRI_241                                \ PRI_241
$00c00000 constant NVIC_IPR6_PRI_242                                \ PRI_242
$c0000000 constant NVIC_IPR6_PRI_243                                \ PRI_243


\
\ @brief Interrupt Priority Register 7
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$000000c0 constant NVIC_IPR7_PRI_280                                \ PRI_280
$0000c000 constant NVIC_IPR7_PRI_281                                \ PRI_281
$00c00000 constant NVIC_IPR7_PRI_282                                \ PRI_282
$c0000000 constant NVIC_IPR7_PRI_283                                \ PRI_283


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

