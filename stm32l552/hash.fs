\
\ @file hash.fs
\ @brief Hash processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant HASH_CR_INIT                                     \ Initialize message digest calculation
$00000008 constant HASH_CR_DMAE                                     \ DMA enable
$00000030 constant HASH_CR_DATATYPE                                 \ Data type selection
$00000040 constant HASH_CR_MODE                                     \ Mode selection
$00000080 constant HASH_CR_ALGO0                                    \ Algorithm selection
$00000f00 constant HASH_CR_NBW                                      \ Number of words already pushed
$00001000 constant HASH_CR_DINNE                                    \ DIN not empty
$00002000 constant HASH_CR_MDMAT                                    \ Multiple DMA Transfers
$00010000 constant HASH_CR_LKEY                                     \ Long key selection
$00040000 constant HASH_CR_ALGO1                                    \ Algorithm selection


\
\ @brief data input register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant HASH_DIN_DATAIN                                  \ Data input


\
\ @brief start register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant HASH_STR_NBLW                                    \ Number of valid bits in the last word of the message
$00000100 constant HASH_STR_DCAL                                    \ Digest calculation


\
\ @brief HASH aliased digest register 0
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HRA0_H0                                     \ H0


\
\ @brief HASH aliased digest register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant HASH_HRA1_H1                                     \ H1


\
\ @brief HASH aliased digest register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant HASH_HRA2_H2                                     \ H2


\
\ @brief HASH aliased digest register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant HASH_HRA3_H3                                     \ H3


\
\ @brief HASH aliased digest register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HRA4_H4                                     \ H4


\
\ @brief interrupt enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant HASH_IMR_DINIE                                   \ Data input interrupt enable
$00000002 constant HASH_IMR_DCIE                                    \ Digest calculation completion interrupt enable


\
\ @brief status register
\ Address offset: 0x24
\ Reset value: 0x00000001
\

$00000001 constant HASH_SR_DINIS                                    \ Data input interrupt status
$00000002 constant HASH_SR_DCIS                                     \ Digest calculation completion interrupt status
$00000004 constant HASH_SR_DMAS                                     \ DMA Status
$00000008 constant HASH_SR_BUSY                                     \ Busy bit


\
\ @brief context swap registers
\ Address offset: 0xF8
\ Reset value: 0x00000002
\

$00000000 constant HASH_CSR0_CSR0                                   \ CSR0


\
\ @brief context swap registers
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR1_CSR1                                   \ CSR1


\
\ @brief context swap registers
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR2_CSR2                                   \ CSR2


\
\ @brief context swap registers
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR3_CSR3                                   \ CSR3


\
\ @brief context swap registers
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR4_CSR4                                   \ CSR4


\
\ @brief context swap registers
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR5_CSR5                                   \ CSR5


\
\ @brief context swap registers
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR6_CSR6                                   \ CSR6


\
\ @brief context swap registers
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR7_CSR7                                   \ CSR7


\
\ @brief context swap registers
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR8_CSR8                                   \ CSR8


\
\ @brief context swap registers
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR9_CSR9                                   \ CSR9


\
\ @brief context swap registers
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR10_CSR10                                 \ CSR10


\
\ @brief context swap registers
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR11_CSR11                                 \ CSR11


\
\ @brief context swap registers
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR12_CSR12                                 \ CSR12


\
\ @brief context swap registers
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR13_CSR13                                 \ CSR13


\
\ @brief context swap registers
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR14_CSR14                                 \ CSR14


\
\ @brief context swap registers
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR15_CSR15                                 \ CSR15


\
\ @brief context swap registers
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR16_CSR16                                 \ CSR16


\
\ @brief context swap registers
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR17_CSR17                                 \ CSR17


\
\ @brief context swap registers
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR18_CSR18                                 \ CSR18


\
\ @brief context swap registers
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR19_CSR19                                 \ CSR19


\
\ @brief context swap registers
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR20_CSR20                                 \ CSR20


\
\ @brief context swap registers
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR21_CSR21                                 \ CSR21


\
\ @brief context swap registers
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR22_CSR22                                 \ CSR22


\
\ @brief context swap registers
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR23_CSR23                                 \ CSR23


\
\ @brief context swap registers
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR24_CSR24                                 \ CSR24


\
\ @brief context swap registers
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR25_CSR25                                 \ CSR25


\
\ @brief context swap registers
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR26_CSR26                                 \ CSR26


\
\ @brief context swap registers
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR27_CSR27                                 \ CSR27


\
\ @brief context swap registers
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR28_CSR28                                 \ CSR28


\
\ @brief context swap registers
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR29_CSR29                                 \ CSR29


\
\ @brief context swap registers
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR30_CSR30                                 \ CSR30


\
\ @brief context swap registers
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR31_CSR31                                 \ CSR31


\
\ @brief context swap registers
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR32_CSR32                                 \ CSR32


\
\ @brief context swap registers
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR33_CSR33                                 \ CSR33


\
\ @brief context swap registers
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR34_CSR34                                 \ CSR34


\
\ @brief context swap registers
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR35_CSR35                                 \ CSR35


\
\ @brief context swap registers
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR36_CSR36                                 \ CSR36


\
\ @brief context swap registers
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR37_CSR37                                 \ CSR37


\
\ @brief context swap registers
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR38_CSR38                                 \ CSR38


\
\ @brief context swap registers
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR39_CSR39                                 \ CSR39


\
\ @brief context swap registers
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR40_CSR40                                 \ CSR40


\
\ @brief context swap registers
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR41_CSR41                                 \ CSR41


\
\ @brief context swap registers
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR42_CSR42                                 \ CSR42


\
\ @brief context swap registers
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR43_CSR43                                 \ CSR43


\
\ @brief context swap registers
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR44_CSR44                                 \ CSR44


\
\ @brief context swap registers
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR45_CSR45                                 \ CSR45


\
\ @brief context swap registers
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR46_CSR46                                 \ CSR46


\
\ @brief context swap registers
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR47_CSR47                                 \ CSR47


\
\ @brief context swap registers
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR48_CSR48                                 \ CSR48


\
\ @brief context swap registers
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR49_CSR49                                 \ CSR49


\
\ @brief context swap registers
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR50_CSR50                                 \ CSR50


\
\ @brief context swap registers
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR51_CSR51                                 \ CSR51


\
\ @brief context swap registers
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR52_CSR52                                 \ CSR52


\
\ @brief context swap registers
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000000 constant HASH_CSR53_CSR53                                 \ CSR53


\
\ @brief digest register 0
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant HASH_HR0_H0                                      \ H0


\
\ @brief digest register 1
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant HASH_HR1_H1                                      \ H1


\
\ @brief digest register 4
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant HASH_HR2_H2                                      \ H2


\
\ @brief digest register 3
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HR3_H3                                      \ H3


\
\ @brief digest register 4
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant HASH_HR4_H4                                      \ H4


\
\ @brief supplementary digest register 5
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant HASH_HR5_H5                                      \ H5


\
\ @brief supplementary digest register 6
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant HASH_HR6_H6                                      \ H6


\
\ @brief supplementary digest register 7
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HR7_H7                                      \ H7


\
\ @brief Hash processor
\
$420c0400 constant HASH_CR        \ offset: 0x00 : control register
$420c0404 constant HASH_DIN       \ offset: 0x04 : data input register
$420c0408 constant HASH_STR       \ offset: 0x08 : start register
$420c040c constant HASH_HRA0      \ offset: 0x0C : HASH aliased digest register 0
$420c0410 constant HASH_HRA1      \ offset: 0x10 : HASH aliased digest register 1
$420c0414 constant HASH_HRA2      \ offset: 0x14 : HASH aliased digest register 2
$420c0418 constant HASH_HRA3      \ offset: 0x18 : HASH aliased digest register 3
$420c041c constant HASH_HRA4      \ offset: 0x1C : HASH aliased digest register 4
$420c0420 constant HASH_IMR       \ offset: 0x20 : interrupt enable register
$420c0424 constant HASH_SR        \ offset: 0x24 : status register
$420c04f8 constant HASH_CSR0      \ offset: 0xF8 : context swap registers
$420c04fc constant HASH_CSR1      \ offset: 0xFC : context swap registers
$420c0500 constant HASH_CSR2      \ offset: 0x100 : context swap registers
$420c0504 constant HASH_CSR3      \ offset: 0x104 : context swap registers
$420c0508 constant HASH_CSR4      \ offset: 0x108 : context swap registers
$420c050c constant HASH_CSR5      \ offset: 0x10C : context swap registers
$420c0510 constant HASH_CSR6      \ offset: 0x110 : context swap registers
$420c0514 constant HASH_CSR7      \ offset: 0x114 : context swap registers
$420c0518 constant HASH_CSR8      \ offset: 0x118 : context swap registers
$420c051c constant HASH_CSR9      \ offset: 0x11C : context swap registers
$420c0520 constant HASH_CSR10     \ offset: 0x120 : context swap registers
$420c0524 constant HASH_CSR11     \ offset: 0x124 : context swap registers
$420c0528 constant HASH_CSR12     \ offset: 0x128 : context swap registers
$420c052c constant HASH_CSR13     \ offset: 0x12C : context swap registers
$420c0530 constant HASH_CSR14     \ offset: 0x130 : context swap registers
$420c0534 constant HASH_CSR15     \ offset: 0x134 : context swap registers
$420c0538 constant HASH_CSR16     \ offset: 0x138 : context swap registers
$420c053c constant HASH_CSR17     \ offset: 0x13C : context swap registers
$420c0540 constant HASH_CSR18     \ offset: 0x140 : context swap registers
$420c0544 constant HASH_CSR19     \ offset: 0x144 : context swap registers
$420c0548 constant HASH_CSR20     \ offset: 0x148 : context swap registers
$420c054c constant HASH_CSR21     \ offset: 0x14C : context swap registers
$420c0550 constant HASH_CSR22     \ offset: 0x150 : context swap registers
$420c0554 constant HASH_CSR23     \ offset: 0x154 : context swap registers
$420c0558 constant HASH_CSR24     \ offset: 0x158 : context swap registers
$420c055c constant HASH_CSR25     \ offset: 0x15C : context swap registers
$420c0560 constant HASH_CSR26     \ offset: 0x160 : context swap registers
$420c0564 constant HASH_CSR27     \ offset: 0x164 : context swap registers
$420c0568 constant HASH_CSR28     \ offset: 0x168 : context swap registers
$420c056c constant HASH_CSR29     \ offset: 0x16C : context swap registers
$420c0570 constant HASH_CSR30     \ offset: 0x170 : context swap registers
$420c0574 constant HASH_CSR31     \ offset: 0x174 : context swap registers
$420c0578 constant HASH_CSR32     \ offset: 0x178 : context swap registers
$420c057c constant HASH_CSR33     \ offset: 0x17C : context swap registers
$420c0580 constant HASH_CSR34     \ offset: 0x180 : context swap registers
$420c0584 constant HASH_CSR35     \ offset: 0x184 : context swap registers
$420c0588 constant HASH_CSR36     \ offset: 0x188 : context swap registers
$420c058c constant HASH_CSR37     \ offset: 0x18C : context swap registers
$420c0590 constant HASH_CSR38     \ offset: 0x190 : context swap registers
$420c0594 constant HASH_CSR39     \ offset: 0x194 : context swap registers
$420c0598 constant HASH_CSR40     \ offset: 0x198 : context swap registers
$420c059c constant HASH_CSR41     \ offset: 0x19C : context swap registers
$420c05a0 constant HASH_CSR42     \ offset: 0x1A0 : context swap registers
$420c05a4 constant HASH_CSR43     \ offset: 0x1A4 : context swap registers
$420c05a8 constant HASH_CSR44     \ offset: 0x1A8 : context swap registers
$420c05ac constant HASH_CSR45     \ offset: 0x1AC : context swap registers
$420c05b0 constant HASH_CSR46     \ offset: 0x1B0 : context swap registers
$420c05b4 constant HASH_CSR47     \ offset: 0x1B4 : context swap registers
$420c05b8 constant HASH_CSR48     \ offset: 0x1B8 : context swap registers
$420c05bc constant HASH_CSR49     \ offset: 0x1BC : context swap registers
$420c05c0 constant HASH_CSR50     \ offset: 0x1C0 : context swap registers
$420c05c4 constant HASH_CSR51     \ offset: 0x1C4 : context swap registers
$420c05c8 constant HASH_CSR52     \ offset: 0x1C8 : context swap registers
$420c05cc constant HASH_CSR53     \ offset: 0x1CC : context swap registers
$420c0710 constant HASH_HR0       \ offset: 0x310 : digest register 0
$420c0714 constant HASH_HR1       \ offset: 0x314 : digest register 1
$420c0718 constant HASH_HR2       \ offset: 0x318 : digest register 4
$420c071c constant HASH_HR3       \ offset: 0x31C : digest register 3
$420c0720 constant HASH_HR4       \ offset: 0x320 : digest register 4
$420c0724 constant HASH_HR5       \ offset: 0x324 : supplementary digest register 5
$420c0728 constant HASH_HR6       \ offset: 0x328 : supplementary digest register 6
$420c072c constant HASH_HR7       \ offset: 0x32C : supplementary digest register 7

