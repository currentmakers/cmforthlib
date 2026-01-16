\
\ @file sec_hash.fs
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

$00000004 constant SEC_HASH_HASH_CR_INIT                            \ Initialize message digest calculation Writing this bit to 1 resets the hash processor core, so that the HASH is ready to compute the message digest of a new message. Writing this bit to 0 has no effect. Reading this bit always return 0.
$00000008 constant SEC_HASH_HASH_CR_DMAE                            \ DMA enable After this bit is set it is cleared by hardware while the last data of the message is written into the hash processor. Setting this bit to 0 while a DMA transfer is ongoing is not aborting this current transfer. Instead, the DMA interface of the IP remains internally enabled until the transfer is completed or INIT is written to 1. Setting INIT bit to 1 does not clear DMAE bit.
$00000030 constant SEC_HASH_HASH_CR_DATATYPE                        \ Data type selection Defines the format of the data entered into the HASH_DIN register:
$00000040 constant SEC_HASH_HASH_CR_MODE                            \ Mode selection This bit selects the HASH or HMAC mode for the selected algorithm: This selection is only taken into account when the INIT bit is set. Changing this bit during a computation has no effect.
$00000f00 constant SEC_HASH_HASH_CR_NBW                             \ Number of words already pushed Refer to NBWP[3:0] bitfield of HASH_SR for the description. This bitfield is read-only.
$00001000 constant SEC_HASH_HASH_CR_DINNE                           \ DIN not empty Refer to DINNE bit of HASH_SR for the description. This bit is read-only.
$00002000 constant SEC_HASH_HASH_CR_MDMAT                           \ Multiple DMA transfers This bit is set when hashing large files when multiple DMA transfers are needed.
$00010000 constant SEC_HASH_HASH_CR_LKEY                            \ Long key selection This bit selects between short key (less than or equal 64 bytes) or long key ( 64 bytes) in HMAC mode. This selection is only taken into account when the INIT and MODE bits are both set. Changing this bit during a computation has no effect.
$00060000 constant SEC_HASH_HASH_CR_ALGO                            \ Algorithm selection These bits select the hash algorithm. This selection is only taken into account when the INIT bit is set. Changing this bitfield during a computation has no effect. When ALGO bitfield is updated and INIT bit is set, NBWE in HASH_SR is automatically updated to 0x11.


\
\ @brief HASH data input register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_DIN_DATAIN                         \ Data input Writing this register pushes the current register content into the IN FIFO, and the register takes the new value presented on the AHB databus. Reading this register returns zeros.


\
\ @brief HASH start register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant SEC_HASH_HASH_STR_NBLW                           \ Number of valid bits in the last word When the last word of the message bit string is written in HASH_DIN register, the hash processor takes only the valid bits specified as below, after internal data swapping: ... The above mechanism is valid only if DCAL = 0. If NBLW[4:0] bitfield is written while DCAL is set to 1, the NBLW[4:0] bitfield remains unchanged. In other words it is not possible to configure NBLW[4:0] and set DCAL at the same time. Reading NBLW[4:0] bitfield returns the last value written to NBLW[4:0].
$00000100 constant SEC_HASH_HASH_STR_DCAL                           \ Digest calculation Writing this bit to 1 starts the message padding, using the previously written value of NBLW[4:0], and starts the calculation of the final message digest with all data words written to the input FIFO since the INIT bit was last written to 1. Reading this bit returns 0.


\
\ @brief HASH aliased digest register 0
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA0_H0                            \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA1_H1                            \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA2_H2                            \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA3_H3                            \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA4_H4                            \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH interrupt enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_HASH_HASH_IMR_DINIE                          \ Data input interrupt enable
$00000002 constant SEC_HASH_HASH_IMR_DCIE                           \ Digest calculation completion interrupt enable


\
\ @brief HASH status register
\ Address offset: 0x24
\ Reset value: 0x00000001
\

$00000001 constant SEC_HASH_HASH_SR_DINIS                           \ Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINIS=0, HASH_CSRx registers reads as zero.
$00000002 constant SEC_HASH_HASH_SR_DCIS                            \ Digest calculation completion interrupt status This bit is set by hardware when a digest becomes ready (the whole message has been processed). It is cleared by writing it to 0 or by writing the INIT bit to 1 in the HASH_CR register.
$00000004 constant SEC_HASH_HASH_SR_DMAS                            \ DMA Status This bit provides information on the DMA interface activity. It is set with DMAE and cleared when DMAE = 0 and no DMA transfer is ongoing. No interrupt is associated with this bit.
$00000008 constant SEC_HASH_HASH_SR_BUSY                            \ Busy bit
$00003e00 constant SEC_HASH_HASH_SR_NBWP                            \ Number of words already pushed This bitfield is the exact number of words in the message that have already been pushed into the FIFO. NBWP is incremented by one when a write access is performed to the HASH_DIN register. When a digest calculation starts, NBWP is updated to NBWP- block size (in words), and NBWP goes to zero when the INIT bit is written to 1.
$00008000 constant SEC_HASH_HASH_SR_DINNE                           \ DIN not empty This bit is set when the HASH_DIN register holds valid data (that is after being written at least once). It is cleared when either the INIT bit (initialization) or the DCAL bit (completion of the previous message processing) is written to 1.
$001f0000 constant SEC_HASH_HASH_SR_NBWE                            \ Number of words expected This bitfield reflects the number of words in the message that must be pushed into the FIFO to trigger a partial computation. NBWE is decremented by 1 when a write access is performed to the HASH_DIN register. NBWE is set to the expected block size +1 in words (0x11) when INIT bit is set in HASH_CR, and it is set to the expected block size when partial digest calculation ends.


\
\ @brief HASH context swap register 0
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR0_CS0                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 1
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR1_CS1                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 2
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR2_CS2                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 3
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR3_CS3                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 4
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR4_CS4                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 5
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR5_CS5                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 6
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR6_CS6                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 7
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR7_CS7                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 8
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR8_CS8                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 9
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR9_CS9                           \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 10
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR10_CS10                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 11
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR11_CS11                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 12
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR12_CS12                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 13
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR13_CS13                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 14
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR14_CS14                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 15
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR15_CS15                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 16
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR16_CS16                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 17
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR17_CS17                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 18
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR18_CS18                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 19
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR19_CS19                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 20
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR20_CS20                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 21
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR21_CS21                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 22
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR22_CS22                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 23
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR23_CS23                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 24
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR24_CS24                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 25
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR25_CS25                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 26
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR26_CS26                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 27
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR27_CS27                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 28
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR28_CS28                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 29
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR29_CS29                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 30
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR30_CS30                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 31
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR31_CS31                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 32
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR32_CS32                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 33
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR33_CS33                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 34
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR34_CS34                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 35
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR35_CS35                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 36
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR36_CS36                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 37
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR37_CS37                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 38
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR38_CS38                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 39
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR39_CS39                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 40
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR40_CS40                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 41
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR41_CS41                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 42
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR42_CS42                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 43
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR43_CS43                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 44
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR44_CS44                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 45
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR45_CS45                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 46
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR46_CS46                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 47
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR47_CS47                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 48
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR48_CS48                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 49
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR49_CS49                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 50
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR50_CS50                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 51
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR51_CS51                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 52
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR52_CS52                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 53
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_CSR53_CS53                         \ Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.


\
\ @brief HASH digest register 0
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR0_H0                             \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 1
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR1_H1                             \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 2
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR2_H2                             \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 3
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR3_H3                             \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 4
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR4_H4                             \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 5
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR5_H5                             \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 6
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR6_H6                             \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 7
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR7_H7                             \ Hash data x Refer to Section 25.7.4: HASH digest registers introduction.


\
\ @brief HASH register block
\
$520c0400 constant SEC_HASH_HASH_CR  \ offset: 0x00 : HASH control register
$520c0404 constant SEC_HASH_HASH_DIN  \ offset: 0x04 : HASH data input register
$520c0408 constant SEC_HASH_HASH_STR  \ offset: 0x08 : HASH start register
$520c040c constant SEC_HASH_HASH_HRA0  \ offset: 0x0C : HASH aliased digest register 0
$520c0410 constant SEC_HASH_HASH_HRA1  \ offset: 0x10 : HASH aliased digest register 1
$520c0414 constant SEC_HASH_HASH_HRA2  \ offset: 0x14 : HASH aliased digest register 2
$520c0418 constant SEC_HASH_HASH_HRA3  \ offset: 0x18 : HASH aliased digest register 3
$520c041c constant SEC_HASH_HASH_HRA4  \ offset: 0x1C : HASH aliased digest register 4
$520c0420 constant SEC_HASH_HASH_IMR  \ offset: 0x20 : HASH interrupt enable register
$520c0424 constant SEC_HASH_HASH_SR  \ offset: 0x24 : HASH status register
$520c04f8 constant SEC_HASH_HASH_CSR0  \ offset: 0xF8 : HASH context swap register 0
$520c04fc constant SEC_HASH_HASH_CSR1  \ offset: 0xFC : HASH context swap register 1
$520c0500 constant SEC_HASH_HASH_CSR2  \ offset: 0x100 : HASH context swap register 2
$520c0504 constant SEC_HASH_HASH_CSR3  \ offset: 0x104 : HASH context swap register 3
$520c0508 constant SEC_HASH_HASH_CSR4  \ offset: 0x108 : HASH context swap register 4
$520c050c constant SEC_HASH_HASH_CSR5  \ offset: 0x10C : HASH context swap register 5
$520c0510 constant SEC_HASH_HASH_CSR6  \ offset: 0x110 : HASH context swap register 6
$520c0514 constant SEC_HASH_HASH_CSR7  \ offset: 0x114 : HASH context swap register 7
$520c0518 constant SEC_HASH_HASH_CSR8  \ offset: 0x118 : HASH context swap register 8
$520c051c constant SEC_HASH_HASH_CSR9  \ offset: 0x11C : HASH context swap register 9
$520c0520 constant SEC_HASH_HASH_CSR10  \ offset: 0x120 : HASH context swap register 10
$520c0524 constant SEC_HASH_HASH_CSR11  \ offset: 0x124 : HASH context swap register 11
$520c0528 constant SEC_HASH_HASH_CSR12  \ offset: 0x128 : HASH context swap register 12
$520c052c constant SEC_HASH_HASH_CSR13  \ offset: 0x12C : HASH context swap register 13
$520c0530 constant SEC_HASH_HASH_CSR14  \ offset: 0x130 : HASH context swap register 14
$520c0534 constant SEC_HASH_HASH_CSR15  \ offset: 0x134 : HASH context swap register 15
$520c0538 constant SEC_HASH_HASH_CSR16  \ offset: 0x138 : HASH context swap register 16
$520c053c constant SEC_HASH_HASH_CSR17  \ offset: 0x13C : HASH context swap register 17
$520c0540 constant SEC_HASH_HASH_CSR18  \ offset: 0x140 : HASH context swap register 18
$520c0544 constant SEC_HASH_HASH_CSR19  \ offset: 0x144 : HASH context swap register 19
$520c0548 constant SEC_HASH_HASH_CSR20  \ offset: 0x148 : HASH context swap register 20
$520c054c constant SEC_HASH_HASH_CSR21  \ offset: 0x14C : HASH context swap register 21
$520c0550 constant SEC_HASH_HASH_CSR22  \ offset: 0x150 : HASH context swap register 22
$520c0554 constant SEC_HASH_HASH_CSR23  \ offset: 0x154 : HASH context swap register 23
$520c0558 constant SEC_HASH_HASH_CSR24  \ offset: 0x158 : HASH context swap register 24
$520c055c constant SEC_HASH_HASH_CSR25  \ offset: 0x15C : HASH context swap register 25
$520c0560 constant SEC_HASH_HASH_CSR26  \ offset: 0x160 : HASH context swap register 26
$520c0564 constant SEC_HASH_HASH_CSR27  \ offset: 0x164 : HASH context swap register 27
$520c0568 constant SEC_HASH_HASH_CSR28  \ offset: 0x168 : HASH context swap register 28
$520c056c constant SEC_HASH_HASH_CSR29  \ offset: 0x16C : HASH context swap register 29
$520c0570 constant SEC_HASH_HASH_CSR30  \ offset: 0x170 : HASH context swap register 30
$520c0574 constant SEC_HASH_HASH_CSR31  \ offset: 0x174 : HASH context swap register 31
$520c0578 constant SEC_HASH_HASH_CSR32  \ offset: 0x178 : HASH context swap register 32
$520c057c constant SEC_HASH_HASH_CSR33  \ offset: 0x17C : HASH context swap register 33
$520c0580 constant SEC_HASH_HASH_CSR34  \ offset: 0x180 : HASH context swap register 34
$520c0584 constant SEC_HASH_HASH_CSR35  \ offset: 0x184 : HASH context swap register 35
$520c0588 constant SEC_HASH_HASH_CSR36  \ offset: 0x188 : HASH context swap register 36
$520c058c constant SEC_HASH_HASH_CSR37  \ offset: 0x18C : HASH context swap register 37
$520c0590 constant SEC_HASH_HASH_CSR38  \ offset: 0x190 : HASH context swap register 38
$520c0594 constant SEC_HASH_HASH_CSR39  \ offset: 0x194 : HASH context swap register 39
$520c0598 constant SEC_HASH_HASH_CSR40  \ offset: 0x198 : HASH context swap register 40
$520c059c constant SEC_HASH_HASH_CSR41  \ offset: 0x19C : HASH context swap register 41
$520c05a0 constant SEC_HASH_HASH_CSR42  \ offset: 0x1A0 : HASH context swap register 42
$520c05a4 constant SEC_HASH_HASH_CSR43  \ offset: 0x1A4 : HASH context swap register 43
$520c05a8 constant SEC_HASH_HASH_CSR44  \ offset: 0x1A8 : HASH context swap register 44
$520c05ac constant SEC_HASH_HASH_CSR45  \ offset: 0x1AC : HASH context swap register 45
$520c05b0 constant SEC_HASH_HASH_CSR46  \ offset: 0x1B0 : HASH context swap register 46
$520c05b4 constant SEC_HASH_HASH_CSR47  \ offset: 0x1B4 : HASH context swap register 47
$520c05b8 constant SEC_HASH_HASH_CSR48  \ offset: 0x1B8 : HASH context swap register 48
$520c05bc constant SEC_HASH_HASH_CSR49  \ offset: 0x1BC : HASH context swap register 49
$520c05c0 constant SEC_HASH_HASH_CSR50  \ offset: 0x1C0 : HASH context swap register 50
$520c05c4 constant SEC_HASH_HASH_CSR51  \ offset: 0x1C4 : HASH context swap register 51
$520c05c8 constant SEC_HASH_HASH_CSR52  \ offset: 0x1C8 : HASH context swap register 52
$520c05cc constant SEC_HASH_HASH_CSR53  \ offset: 0x1CC : HASH context swap register 53
$520c0710 constant SEC_HASH_HASH_HR0  \ offset: 0x310 : HASH digest register 0
$520c0714 constant SEC_HASH_HASH_HR1  \ offset: 0x314 : HASH digest register 1
$520c0718 constant SEC_HASH_HASH_HR2  \ offset: 0x318 : HASH digest register 2
$520c071c constant SEC_HASH_HASH_HR3  \ offset: 0x31C : HASH digest register 3
$520c0720 constant SEC_HASH_HASH_HR4  \ offset: 0x320 : HASH digest register 4
$520c0724 constant SEC_HASH_HASH_HR5  \ offset: 0x324 : HASH supplementary digest register 5
$520c0728 constant SEC_HASH_HASH_HR6  \ offset: 0x328 : HASH supplementary digest register 6
$520c072c constant SEC_HASH_HASH_HR7  \ offset: 0x32C : HASH supplementary digest register 7

