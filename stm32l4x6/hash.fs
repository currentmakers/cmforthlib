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
$00040000 constant HASH_CR_ALGO1                                    \ ALGO


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
\ @brief digest registers
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HR0_H0                                      \ H0


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
\ Reset value: 0x00000000
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
\ @brief HASH digest register
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR0_H0                                 \ H0


\
\ @brief read-only
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR1_H1                                 \ H1


\
\ @brief read-only
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR2_H2                                 \ H2


\
\ @brief read-only
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR3_H3                                 \ H3


\
\ @brief read-only
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR4_H4                                 \ H4


\
\ @brief read-only
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR5_H5                                 \ H5


\
\ @brief read-only
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR6_H6                                 \ H6


\
\ @brief read-only
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR7_H7                                 \ H7


\
\ @brief Hash processor
\
$50060400 constant HASH_CR        \ offset: 0x00 : control register
$50060404 constant HASH_DIN       \ offset: 0x04 : data input register
$50060408 constant HASH_STR       \ offset: 0x08 : start register
$5006040c constant HASH_HR0       \ offset: 0x0C : digest registers
$50060420 constant HASH_IMR       \ offset: 0x20 : interrupt enable register
$50060424 constant HASH_SR        \ offset: 0x24 : status register
$500604f8 constant HASH_CSR0      \ offset: 0xF8 : context swap registers
$500604fc constant HASH_CSR1      \ offset: 0xFC : context swap registers
$50060500 constant HASH_CSR2      \ offset: 0x100 : context swap registers
$50060504 constant HASH_CSR3      \ offset: 0x104 : context swap registers
$50060508 constant HASH_CSR4      \ offset: 0x108 : context swap registers
$5006050c constant HASH_CSR5      \ offset: 0x10C : context swap registers
$50060510 constant HASH_CSR6      \ offset: 0x110 : context swap registers
$50060514 constant HASH_CSR7      \ offset: 0x114 : context swap registers
$50060518 constant HASH_CSR8      \ offset: 0x118 : context swap registers
$5006051c constant HASH_CSR9      \ offset: 0x11C : context swap registers
$50060520 constant HASH_CSR10     \ offset: 0x120 : context swap registers
$50060524 constant HASH_CSR11     \ offset: 0x124 : context swap registers
$50060528 constant HASH_CSR12     \ offset: 0x128 : context swap registers
$5006052c constant HASH_CSR13     \ offset: 0x12C : context swap registers
$50060530 constant HASH_CSR14     \ offset: 0x130 : context swap registers
$50060534 constant HASH_CSR15     \ offset: 0x134 : context swap registers
$50060538 constant HASH_CSR16     \ offset: 0x138 : context swap registers
$5006053c constant HASH_CSR17     \ offset: 0x13C : context swap registers
$50060540 constant HASH_CSR18     \ offset: 0x140 : context swap registers
$50060544 constant HASH_CSR19     \ offset: 0x144 : context swap registers
$50060548 constant HASH_CSR20     \ offset: 0x148 : context swap registers
$5006054c constant HASH_CSR21     \ offset: 0x14C : context swap registers
$50060550 constant HASH_CSR22     \ offset: 0x150 : context swap registers
$50060554 constant HASH_CSR23     \ offset: 0x154 : context swap registers
$50060558 constant HASH_CSR24     \ offset: 0x158 : context swap registers
$5006055c constant HASH_CSR25     \ offset: 0x15C : context swap registers
$50060560 constant HASH_CSR26     \ offset: 0x160 : context swap registers
$50060564 constant HASH_CSR27     \ offset: 0x164 : context swap registers
$50060568 constant HASH_CSR28     \ offset: 0x168 : context swap registers
$5006056c constant HASH_CSR29     \ offset: 0x16C : context swap registers
$50060570 constant HASH_CSR30     \ offset: 0x170 : context swap registers
$50060574 constant HASH_CSR31     \ offset: 0x174 : context swap registers
$50060578 constant HASH_CSR32     \ offset: 0x178 : context swap registers
$5006057c constant HASH_CSR33     \ offset: 0x17C : context swap registers
$50060580 constant HASH_CSR34     \ offset: 0x180 : context swap registers
$50060584 constant HASH_CSR35     \ offset: 0x184 : context swap registers
$50060588 constant HASH_CSR36     \ offset: 0x188 : context swap registers
$5006058c constant HASH_CSR37     \ offset: 0x18C : context swap registers
$50060590 constant HASH_CSR38     \ offset: 0x190 : context swap registers
$50060594 constant HASH_CSR39     \ offset: 0x194 : context swap registers
$50060598 constant HASH_CSR40     \ offset: 0x198 : context swap registers
$5006059c constant HASH_CSR41     \ offset: 0x19C : context swap registers
$500605a0 constant HASH_CSR42     \ offset: 0x1A0 : context swap registers
$500605a4 constant HASH_CSR43     \ offset: 0x1A4 : context swap registers
$500605a8 constant HASH_CSR44     \ offset: 0x1A8 : context swap registers
$500605ac constant HASH_CSR45     \ offset: 0x1AC : context swap registers
$500605b0 constant HASH_CSR46     \ offset: 0x1B0 : context swap registers
$500605b4 constant HASH_CSR47     \ offset: 0x1B4 : context swap registers
$500605b8 constant HASH_CSR48     \ offset: 0x1B8 : context swap registers
$500605bc constant HASH_CSR49     \ offset: 0x1BC : context swap registers
$500605c0 constant HASH_CSR50     \ offset: 0x1C0 : context swap registers
$500605c4 constant HASH_CSR51     \ offset: 0x1C4 : context swap registers
$500605c8 constant HASH_CSR52     \ offset: 0x1C8 : context swap registers
$500605cc constant HASH_CSR53     \ offset: 0x1CC : context swap registers
$50060710 constant HASH_HASH_HR0  \ offset: 0x310 : HASH digest register
$50060714 constant HASH_HASH_HR1  \ offset: 0x314 : read-only
$50060718 constant HASH_HASH_HR2  \ offset: 0x318 : read-only
$5006071c constant HASH_HASH_HR3  \ offset: 0x31C : read-only
$50060720 constant HASH_HASH_HR4  \ offset: 0x320 : read-only
$50060724 constant HASH_HASH_HR5  \ offset: 0x324 : read-only
$50060728 constant HASH_HASH_HR6  \ offset: 0x328 : read-only
$5006072c constant HASH_HASH_HR7  \ offset: 0x32C : read-only

