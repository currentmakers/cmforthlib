\
\ @file hash1.fs
\ @brief HASH register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief HASH control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant HASH1_HASH_CR_INIT                               \ INIT
$00000008 constant HASH1_HASH_CR_DMAE                               \ DMAE
$00000030 constant HASH1_HASH_CR_DATATYPE                           \ DATATYPE
$00000040 constant HASH1_HASH_CR_MODE                               \ MODE
$00000080 constant HASH1_HASH_CR_ALGO0                              \ ALGO0
$00000f00 constant HASH1_HASH_CR_NBW                                \ NBW
$00001000 constant HASH1_HASH_CR_DINNE                              \ DINNE
$00002000 constant HASH1_HASH_CR_MDMAT                              \ MDMAT
$00004000 constant HASH1_HASH_CR_DMAA                               \ DMAA
$00010000 constant HASH1_HASH_CR_LKEY                               \ LKEY
$00040000 constant HASH1_HASH_CR_ALGO1                              \ ALGO1


\
\ @brief HASH_DIN is the data input register.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_DIN_DATAIN                            \ DATAIN


\
\ @brief The HASH_STR register has two functions: It is used to define the number of valid bits in the last word of the message entered in the hash processor (that is the number of valid least significant bits in the last data written to the HASH_DIN register) It is used to start the processing of the last block in the message by writing the DCAL bit to 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant HASH1_HASH_STR_NBLW                              \ NBLW
$00000100 constant HASH1_HASH_STR_DCAL                              \ DCAL


\
\ @brief HASH digest register 0
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_HR0_H0                                \ H0


\
\ @brief HASH digest register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_HR1_H1                                \ H1


\
\ @brief HASH digest register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_HR2_H2                                \ H2


\
\ @brief HASH digest register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_HR3_H3                                \ H3


\
\ @brief HASH digest register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_HR4_H4                                \ H4


\
\ @brief HASH interrupt enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant HASH1_HASH_IMR_DINIE                             \ DINIE
$00000002 constant HASH1_HASH_IMR_DCIE                              \ DCIE


\
\ @brief HASH status register
\ Address offset: 0x24
\ Reset value: 0x00000001
\

$00000001 constant HASH1_HASH_SR_DINIS                              \ DINIS
$00000002 constant HASH1_HASH_SR_DCIS                               \ DCIS
$00000004 constant HASH1_HASH_SR_DMAS                               \ DMAS
$00000008 constant HASH1_HASH_SR_BUSY                               \ BUSY


\
\ @brief These registers contain the complete internal register states of the hash processor. They are useful when a context swap has to be done because a high-priority task needs to use the hash processor while it is already used by another task. When such an event occurs, the HASH_CSRx registers have to be read and the read values have to be saved in the system memory space. Then the hash processor can be used by the preemptive task, and when the hash computation is complete, the saved context can be read from memory and written back into the HASH_CSRx registers.
\ Address offset: 0xF8
\ Reset value: 0x00000002
\

$00000000 constant HASH1_HASH_CSR0_CS0                              \ CS0


\
\ @brief HASH context swap registers
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR1_CS1                              \ CS1


\
\ @brief HASH context swap registers
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR2_CS2                              \ CS2


\
\ @brief HASH context swap registers
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR3_CS3                              \ CS3


\
\ @brief HASH context swap registers
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR4_CS4                              \ CS4


\
\ @brief HASH context swap registers
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR5_CS5                              \ CS5


\
\ @brief HASH context swap registers
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR6_CS6                              \ CS6


\
\ @brief HASH context swap registers
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR7_CS7                              \ CS7


\
\ @brief HASH context swap registers
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR8_CS8                              \ CS8


\
\ @brief HASH context swap registers
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR9_CS9                              \ CS9


\
\ @brief HASH context swap registers
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR10_CS10                            \ CS10


\
\ @brief HASH context swap registers
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR11_CS11                            \ CS11


\
\ @brief HASH context swap registers
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR12_CS12                            \ CS12


\
\ @brief HASH context swap registers
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR13_CS13                            \ CS13


\
\ @brief HASH context swap registers
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR14_CS14                            \ CS14


\
\ @brief HASH context swap registers
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR15_CS15                            \ CS15


\
\ @brief HASH context swap registers
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR16_CS16                            \ CS16


\
\ @brief HASH context swap registers
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR17_CS17                            \ CS17


\
\ @brief HASH context swap registers
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR18_CS18                            \ CS18


\
\ @brief HASH context swap registers
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR19_CS19                            \ CS19


\
\ @brief HASH context swap registers
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR20_CS20                            \ CS20


\
\ @brief HASH context swap registers
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR21_CS21                            \ CS21


\
\ @brief HASH context swap registers
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR22_CS22                            \ CS22


\
\ @brief HASH context swap registers
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR23_CS23                            \ CS23


\
\ @brief HASH context swap registers
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR24_CS24                            \ CS24


\
\ @brief HASH context swap registers
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR25_CS25                            \ CS25


\
\ @brief HASH context swap registers
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR26_CS26                            \ CS26


\
\ @brief HASH context swap registers
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR27_CS27                            \ CS27


\
\ @brief HASH context swap registers
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR28_CS28                            \ CS28


\
\ @brief HASH context swap registers
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR29_CS29                            \ CS29


\
\ @brief HASH context swap registers
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR30_CS30                            \ CS30


\
\ @brief HASH context swap registers
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR31_CS31                            \ CS31


\
\ @brief HASH context swap registers
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR32_CS32                            \ CS32


\
\ @brief HASH context swap registers
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR33_CS33                            \ CS33


\
\ @brief HASH context swap registers
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR34_CS34                            \ CS34


\
\ @brief HASH context swap registers
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR35_CS35                            \ CS35


\
\ @brief HASH context swap registers
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR36_CS36                            \ CS36


\
\ @brief HASH context swap registers
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR37_CS37                            \ CS37


\
\ @brief HASH context swap registers
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR38_CS38                            \ CS38


\
\ @brief HASH context swap registers
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR39_CS39                            \ CS39


\
\ @brief HASH context swap registers
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR40_CS40                            \ CS40


\
\ @brief HASH context swap registers
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR41_CS41                            \ CS41


\
\ @brief HASH context swap registers
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR42_CS42                            \ CS42


\
\ @brief HASH context swap registers
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR43_CS43                            \ CS43


\
\ @brief HASH context swap registers
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR44_CS44                            \ CS44


\
\ @brief HASH context swap registers
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR45_CS45                            \ CS45


\
\ @brief HASH context swap registers
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR46_CS46                            \ CS46


\
\ @brief HASH context swap registers
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR47_CS47                            \ CS47


\
\ @brief HASH context swap registers
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR48_CS48                            \ CS48


\
\ @brief HASH context swap registers
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR49_CS49                            \ CS49


\
\ @brief HASH context swap registers
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR50_CS50                            \ CS50


\
\ @brief HASH context swap registers
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR51_CS51                            \ CS51


\
\ @brief HASH context swap registers
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR52_CS52                            \ CS52


\
\ @brief HASH context swap registers
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_CSR53_CS53                            \ CS53


\
\ @brief HASH digest register 5
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_HR5_H5                                \ H5


\
\ @brief HASH digest register 6
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_HR6_H6                                \ H6


\
\ @brief HASH digest register 7
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant HASH1_HASH_HR7_H7                                \ H7


\
\ @brief HASH Hardware Configuration Register
\ Address offset: 0x3F0
\ Reset value: 0x00000001
\

$0000000f constant HASH1_HASH_HWCFGR_CFG1                           \ CFG1


\
\ @brief HASH Version Register
\ Address offset: 0x3F4
\ Reset value: 0x00000023
\

$000000ff constant HASH1_HASH_VERR_VER                              \ VER


\
\ @brief HASH Identification
\ Address offset: 0x3F8
\ Reset value: 0x00170031
\

$00000000 constant HASH1_HASH_IPIDR_ID                              \ ID


\
\ @brief HASH Hardware Magic ID
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant HASH1_HASH_MID_MID                               \ MID


\
\ @brief HASH register block
\
$54002000 constant HASH1_HASH_CR  \ offset: 0x00 : HASH control register
$54002004 constant HASH1_HASH_DIN  \ offset: 0x04 : HASH_DIN is the data input register.
$54002008 constant HASH1_HASH_STR  \ offset: 0x08 : The HASH_STR register has two functions: It is used to define the number of valid bits in the last word of the message entered in the hash processor (that is the number of valid least significant bits in the last data written to the HASH_DIN register) It is used to start the processing of the last block in the message by writing the DCAL bit to 1
$5400200c constant HASH1_HASH_HR0  \ offset: 0x0C : HASH digest register 0
$54002010 constant HASH1_HASH_HR1  \ offset: 0x10 : HASH digest register 1
$54002014 constant HASH1_HASH_HR2  \ offset: 0x14 : HASH digest register 2
$54002018 constant HASH1_HASH_HR3  \ offset: 0x18 : HASH digest register 3
$5400201c constant HASH1_HASH_HR4  \ offset: 0x1C : HASH digest register 4
$54002020 constant HASH1_HASH_IMR  \ offset: 0x20 : HASH interrupt enable register
$54002024 constant HASH1_HASH_SR  \ offset: 0x24 : HASH status register
$540020f8 constant HASH1_HASH_CSR0  \ offset: 0xF8 : These registers contain the complete internal register states of the hash processor. They are useful when a context swap has to be done because a high-priority task needs to use the hash processor while it is already used by another task. When such an event occurs, the HASH_CSRx registers have to be read and the read values have to be saved in the system memory space. Then the hash processor can be used by the preemptive task, and when the hash computation is complete, the saved context can be read from memory and written back into the HASH_CSRx registers.
$540020fc constant HASH1_HASH_CSR1  \ offset: 0xFC : HASH context swap registers
$54002100 constant HASH1_HASH_CSR2  \ offset: 0x100 : HASH context swap registers
$54002104 constant HASH1_HASH_CSR3  \ offset: 0x104 : HASH context swap registers
$54002108 constant HASH1_HASH_CSR4  \ offset: 0x108 : HASH context swap registers
$5400210c constant HASH1_HASH_CSR5  \ offset: 0x10C : HASH context swap registers
$54002110 constant HASH1_HASH_CSR6  \ offset: 0x110 : HASH context swap registers
$54002114 constant HASH1_HASH_CSR7  \ offset: 0x114 : HASH context swap registers
$54002118 constant HASH1_HASH_CSR8  \ offset: 0x118 : HASH context swap registers
$5400211c constant HASH1_HASH_CSR9  \ offset: 0x11C : HASH context swap registers
$54002120 constant HASH1_HASH_CSR10  \ offset: 0x120 : HASH context swap registers
$54002124 constant HASH1_HASH_CSR11  \ offset: 0x124 : HASH context swap registers
$54002128 constant HASH1_HASH_CSR12  \ offset: 0x128 : HASH context swap registers
$5400212c constant HASH1_HASH_CSR13  \ offset: 0x12C : HASH context swap registers
$54002130 constant HASH1_HASH_CSR14  \ offset: 0x130 : HASH context swap registers
$54002134 constant HASH1_HASH_CSR15  \ offset: 0x134 : HASH context swap registers
$54002138 constant HASH1_HASH_CSR16  \ offset: 0x138 : HASH context swap registers
$5400213c constant HASH1_HASH_CSR17  \ offset: 0x13C : HASH context swap registers
$54002140 constant HASH1_HASH_CSR18  \ offset: 0x140 : HASH context swap registers
$54002144 constant HASH1_HASH_CSR19  \ offset: 0x144 : HASH context swap registers
$54002148 constant HASH1_HASH_CSR20  \ offset: 0x148 : HASH context swap registers
$5400214c constant HASH1_HASH_CSR21  \ offset: 0x14C : HASH context swap registers
$54002150 constant HASH1_HASH_CSR22  \ offset: 0x150 : HASH context swap registers
$54002154 constant HASH1_HASH_CSR23  \ offset: 0x154 : HASH context swap registers
$54002158 constant HASH1_HASH_CSR24  \ offset: 0x158 : HASH context swap registers
$5400215c constant HASH1_HASH_CSR25  \ offset: 0x15C : HASH context swap registers
$54002160 constant HASH1_HASH_CSR26  \ offset: 0x160 : HASH context swap registers
$54002164 constant HASH1_HASH_CSR27  \ offset: 0x164 : HASH context swap registers
$54002168 constant HASH1_HASH_CSR28  \ offset: 0x168 : HASH context swap registers
$5400216c constant HASH1_HASH_CSR29  \ offset: 0x16C : HASH context swap registers
$54002170 constant HASH1_HASH_CSR30  \ offset: 0x170 : HASH context swap registers
$54002174 constant HASH1_HASH_CSR31  \ offset: 0x174 : HASH context swap registers
$54002178 constant HASH1_HASH_CSR32  \ offset: 0x178 : HASH context swap registers
$5400217c constant HASH1_HASH_CSR33  \ offset: 0x17C : HASH context swap registers
$54002180 constant HASH1_HASH_CSR34  \ offset: 0x180 : HASH context swap registers
$54002184 constant HASH1_HASH_CSR35  \ offset: 0x184 : HASH context swap registers
$54002188 constant HASH1_HASH_CSR36  \ offset: 0x188 : HASH context swap registers
$5400218c constant HASH1_HASH_CSR37  \ offset: 0x18C : HASH context swap registers
$54002190 constant HASH1_HASH_CSR38  \ offset: 0x190 : HASH context swap registers
$54002194 constant HASH1_HASH_CSR39  \ offset: 0x194 : HASH context swap registers
$54002198 constant HASH1_HASH_CSR40  \ offset: 0x198 : HASH context swap registers
$5400219c constant HASH1_HASH_CSR41  \ offset: 0x19C : HASH context swap registers
$540021a0 constant HASH1_HASH_CSR42  \ offset: 0x1A0 : HASH context swap registers
$540021a4 constant HASH1_HASH_CSR43  \ offset: 0x1A4 : HASH context swap registers
$540021a8 constant HASH1_HASH_CSR44  \ offset: 0x1A8 : HASH context swap registers
$540021ac constant HASH1_HASH_CSR45  \ offset: 0x1AC : HASH context swap registers
$540021b0 constant HASH1_HASH_CSR46  \ offset: 0x1B0 : HASH context swap registers
$540021b4 constant HASH1_HASH_CSR47  \ offset: 0x1B4 : HASH context swap registers
$540021b8 constant HASH1_HASH_CSR48  \ offset: 0x1B8 : HASH context swap registers
$540021bc constant HASH1_HASH_CSR49  \ offset: 0x1BC : HASH context swap registers
$540021c0 constant HASH1_HASH_CSR50  \ offset: 0x1C0 : HASH context swap registers
$540021c4 constant HASH1_HASH_CSR51  \ offset: 0x1C4 : HASH context swap registers
$540021c8 constant HASH1_HASH_CSR52  \ offset: 0x1C8 : HASH context swap registers
$540021cc constant HASH1_HASH_CSR53  \ offset: 0x1CC : HASH context swap registers
$54002324 constant HASH1_HASH_HR5  \ offset: 0x324 : HASH digest register 5
$54002328 constant HASH1_HASH_HR6  \ offset: 0x328 : HASH digest register 6
$5400232c constant HASH1_HASH_HR7  \ offset: 0x32C : HASH digest register 7
$540023f0 constant HASH1_HASH_HWCFGR  \ offset: 0x3F0 : HASH Hardware Configuration Register
$540023f4 constant HASH1_HASH_VERR  \ offset: 0x3F4 : HASH Version Register
$540023f8 constant HASH1_HASH_IPIDR  \ offset: 0x3F8 : HASH Identification
$540023fc constant HASH1_HASH_MID  \ offset: 0x3FC : HASH Hardware Magic ID

