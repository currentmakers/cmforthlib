\
\ @file hash.fs
\ @brief Hash processor
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

$00000004 constant HASH_HASH_CR_INIT                                \ Initialize message digest calculation Writing this bit to 1 resets the hash processor core, so that the HASH is ready to compute the message digest of a new message. Writing this bit to 0 has no effect. Reading this bit always returns 0.
$00000008 constant HASH_HASH_CR_DMAE                                \ DMA enable After this bit is set, it is cleared by hardware while the last data of the message is written into the hash processor. Setting this bit to 0 while a DMA transfer is ongoing does not abort the current transfer. Instead, the DMA interface of the HASH remains internally enabled until the transfer is completed or INIT is written to 1. Setting INIT bit to 1 does not clear DMAE bit.
$00000030 constant HASH_HASH_CR_DATATYPE                            \ Data type selection This bitfield defines the format of the data entered into the HASH_DIN register:
$00000040 constant HASH_HASH_CR_MODE                                \ Mode selection This bit selects the normal or the keyed HMAC mode for the selected algorithm: This selection is only taken into account when the INIT bit is set. Changing this bit during a computation has no effect.
$00000f00 constant HASH_HASH_CR_NBW                                 \ Number of words already pushed Refer to NBWP[3:0] bitfield of HASH_SR for a description of NBW[3:0] bitfield. This bit is read-only.
$00001000 constant HASH_HASH_CR_DINNE                               \ DIN not empty Refer to DINNE bit of HASH_SR for a description of DINNE bit. This bit is read-only.
$00002000 constant HASH_HASH_CR_MDMAT                               \ Multiple DMA transfers This bit is set when hashing large files when multiple DMA transfers are needed.
$00010000 constant HASH_HASH_CR_LKEY                                \ Long key selection The application must set this bit if the HMAC key is greater than the block size (64 bytes) This selection is only taken into account when the INIT and MODE bits are set (HMAC mode selected). Changing this bit during a computation has no effect.
$00060000 constant HASH_HASH_CR_ALGO                                \ Algorithm selection These bits select the hash algorithm: This selection is only taken into account when the INIT bit is set. Changing this bitfield during a computation has no effect. When the ALGO bitfield is updated and INIT bit is set, NBWE in HASH_SR is automatically updated to 0x11.


\
\ @brief HASH data input register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_DIN_DATAIN                             \ Data input Writing this register pushes the current register content into the FIFO, and the register takes the new value presented on the AHB bus. Reading this register returns zeros.


\
\ @brief HASH start register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant HASH_HASH_STR_NBLW                               \ Number of valid bits in the last word When the last word of the message bit string is written to HASH_DIN register, the hash processor takes only the valid bits, specified as below, after internal data swapping: ... The above mechanism is valid only if DCAL = 0. If NBLW bits are written while DCAL is set to 1, the NBLW bitfield remains unchanged. In other words it is not possible to configure NBLW and set DCAL at the same time. Reading NBLW bits returns the last value written to NBLW.
$00000100 constant HASH_HASH_STR_DCAL                               \ Digest calculation Writing this bit to 1 starts the message padding using the previously written value of NBLW, and starts the calculation of the final message digest with all the data words written to the input FIFO since the INIT bit was last written to 1. Reading this bit returns 0.


\
\ @brief HASH aliased digest register 0
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA0_H0                                \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA1_H1                                \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA2_H2                                \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA3_H3                                \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA4_H4                                \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH interrupt enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant HASH_HASH_IMR_DINIE                              \ Data input interrupt enable
$00000002 constant HASH_HASH_IMR_DCIE                               \ Digest calculation completion interrupt enable


\
\ @brief HASH status register
\ Address offset: 0x24
\ Reset value: 0x00110001
\

$00000001 constant HASH_HASH_SR_DINIS                               \ Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINIS = 0, HASH_CSRx registers reads as zero.
$00000002 constant HASH_HASH_SR_DCIS                                \ Digest calculation completion interrupt status This bit is set by hardware when a digest becomes ready (the whole message has been processed). It is cleared by writing it to 0 or by writing the INIT bit to 1 in the HASH_CR register.
$00000004 constant HASH_HASH_SR_DMAS                                \ DMA Status This bit provides information on the DMA interface activity. It is set with DMAE and cleared when DMAE = 0 and no DMA transfer is ongoing. No interrupt is associated with this bit.
$00000008 constant HASH_HASH_SR_BUSY                                \ Busy bit
$00003e00 constant HASH_HASH_SR_NBWP                                \ Number of words already pushed This bitfield is the exact number of words in the message that have already been pushed into the FIFO. NBWP is incremented by 1 when a write access is performed to the HASH_DIN register. When a digest calculation starts, NBWP is updated to NBWP- block size (in words), and NBWP goes to zero when the INIT bit is written to 1.
$00008000 constant HASH_HASH_SR_DINNE                               \ DIN not empty This bit is set when the HASH_DIN register holds valid data (that is after being written at least once). It is cleared when either the INIT bit (initialization) or the DCAL bit (completion of the previous message processing) is written to 1.
$001f0000 constant HASH_HASH_SR_NBWE                                \ Number of words expected This bitfield reflects the number of words in the message that must be pushed into the FIFO to trigger a partial computation. NBWE is decremented by 1 when a write access is performed to the HASH_DIN register. NBWE is set to the expected block size +1 in words (0x11) when INIT bit is set in HASH_CR. It is set to the expected block size (0x10) when the partial digest calculation ends.


\
\ @brief HASH context swap register 0
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR0_CS0                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 1
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR1_CS1                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 2
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR2_CS2                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 3
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR3_CS3                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 4
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR4_CS4                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 5
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR5_CS5                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 6
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR6_CS6                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 7
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR7_CS7                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 8
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR8_CS8                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 9
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR9_CS9                               \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 10
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR10_CS10                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 11
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR11_CS11                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 12
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR12_CS12                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 13
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR13_CS13                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 14
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR14_CS14                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 15
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR15_CS15                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 16
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR16_CS16                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 17
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR17_CS17                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 18
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR18_CS18                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 19
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR19_CS19                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 20
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR20_CS20                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 21
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR21_CS21                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 22
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR22_CS22                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 23
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR23_CS23                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 24
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR24_CS24                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 25
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR25_CS25                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 26
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR26_CS26                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 27
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR27_CS27                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 28
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR28_CS28                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 29
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR29_CS29                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 30
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR30_CS30                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 31
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR31_CS31                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 32
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR32_CS32                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 33
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR33_CS33                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 34
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR34_CS34                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 35
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR35_CS35                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 36
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR36_CS36                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 37
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR37_CS37                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 38
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR38_CS38                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 39
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR39_CS39                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 40
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR40_CS40                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 41
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR41_CS41                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 42
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR42_CS42                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 43
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR43_CS43                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 44
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR44_CS44                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 45
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR45_CS45                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 46
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR46_CS46                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 47
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR47_CS47                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 48
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR48_CS48                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 49
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR49_CS49                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 50
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR50_CS50                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 51
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR51_CS51                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 52
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR52_CS52                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 53
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR53_CS53                             \ Context swap x Refer to Section 24.7.7: HASH context swap registers introduction.


\
\ @brief HASH digest register 0
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR0_H0                                 \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 1
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR1_H1                                 \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 2
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR2_H2                                 \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 3
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR3_H3                                 \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 4
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR4_H4                                 \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 5
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR5_H5                                 \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 6
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR6_H6                                 \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 7
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR7_H7                                 \ Hash data x Refer to Section 24.7.4: HASH digest registers introduction.


\
\ @brief Hash processor
\
$420c0400 constant HASH_HASH_CR   \ offset: 0x00 : HASH control register
$420c0404 constant HASH_HASH_DIN  \ offset: 0x04 : HASH data input register
$420c0408 constant HASH_HASH_STR  \ offset: 0x08 : HASH start register
$420c040c constant HASH_HASH_HRA0  \ offset: 0x0C : HASH aliased digest register 0
$420c0410 constant HASH_HASH_HRA1  \ offset: 0x10 : HASH aliased digest register 1
$420c0414 constant HASH_HASH_HRA2  \ offset: 0x14 : HASH aliased digest register 2
$420c0418 constant HASH_HASH_HRA3  \ offset: 0x18 : HASH aliased digest register 3
$420c041c constant HASH_HASH_HRA4  \ offset: 0x1C : HASH aliased digest register 4
$420c0420 constant HASH_HASH_IMR  \ offset: 0x20 : HASH interrupt enable register
$420c0424 constant HASH_HASH_SR   \ offset: 0x24 : HASH status register
$420c04f8 constant HASH_HASH_CSR0  \ offset: 0xF8 : HASH context swap register 0
$420c04fc constant HASH_HASH_CSR1  \ offset: 0xFC : HASH context swap register 1
$420c0500 constant HASH_HASH_CSR2  \ offset: 0x100 : HASH context swap register 2
$420c0504 constant HASH_HASH_CSR3  \ offset: 0x104 : HASH context swap register 3
$420c0508 constant HASH_HASH_CSR4  \ offset: 0x108 : HASH context swap register 4
$420c050c constant HASH_HASH_CSR5  \ offset: 0x10C : HASH context swap register 5
$420c0510 constant HASH_HASH_CSR6  \ offset: 0x110 : HASH context swap register 6
$420c0514 constant HASH_HASH_CSR7  \ offset: 0x114 : HASH context swap register 7
$420c0518 constant HASH_HASH_CSR8  \ offset: 0x118 : HASH context swap register 8
$420c051c constant HASH_HASH_CSR9  \ offset: 0x11C : HASH context swap register 9
$420c0520 constant HASH_HASH_CSR10  \ offset: 0x120 : HASH context swap register 10
$420c0524 constant HASH_HASH_CSR11  \ offset: 0x124 : HASH context swap register 11
$420c0528 constant HASH_HASH_CSR12  \ offset: 0x128 : HASH context swap register 12
$420c052c constant HASH_HASH_CSR13  \ offset: 0x12C : HASH context swap register 13
$420c0530 constant HASH_HASH_CSR14  \ offset: 0x130 : HASH context swap register 14
$420c0534 constant HASH_HASH_CSR15  \ offset: 0x134 : HASH context swap register 15
$420c0538 constant HASH_HASH_CSR16  \ offset: 0x138 : HASH context swap register 16
$420c053c constant HASH_HASH_CSR17  \ offset: 0x13C : HASH context swap register 17
$420c0540 constant HASH_HASH_CSR18  \ offset: 0x140 : HASH context swap register 18
$420c0544 constant HASH_HASH_CSR19  \ offset: 0x144 : HASH context swap register 19
$420c0548 constant HASH_HASH_CSR20  \ offset: 0x148 : HASH context swap register 20
$420c054c constant HASH_HASH_CSR21  \ offset: 0x14C : HASH context swap register 21
$420c0550 constant HASH_HASH_CSR22  \ offset: 0x150 : HASH context swap register 22
$420c0554 constant HASH_HASH_CSR23  \ offset: 0x154 : HASH context swap register 23
$420c0558 constant HASH_HASH_CSR24  \ offset: 0x158 : HASH context swap register 24
$420c055c constant HASH_HASH_CSR25  \ offset: 0x15C : HASH context swap register 25
$420c0560 constant HASH_HASH_CSR26  \ offset: 0x160 : HASH context swap register 26
$420c0564 constant HASH_HASH_CSR27  \ offset: 0x164 : HASH context swap register 27
$420c0568 constant HASH_HASH_CSR28  \ offset: 0x168 : HASH context swap register 28
$420c056c constant HASH_HASH_CSR29  \ offset: 0x16C : HASH context swap register 29
$420c0570 constant HASH_HASH_CSR30  \ offset: 0x170 : HASH context swap register 30
$420c0574 constant HASH_HASH_CSR31  \ offset: 0x174 : HASH context swap register 31
$420c0578 constant HASH_HASH_CSR32  \ offset: 0x178 : HASH context swap register 32
$420c057c constant HASH_HASH_CSR33  \ offset: 0x17C : HASH context swap register 33
$420c0580 constant HASH_HASH_CSR34  \ offset: 0x180 : HASH context swap register 34
$420c0584 constant HASH_HASH_CSR35  \ offset: 0x184 : HASH context swap register 35
$420c0588 constant HASH_HASH_CSR36  \ offset: 0x188 : HASH context swap register 36
$420c058c constant HASH_HASH_CSR37  \ offset: 0x18C : HASH context swap register 37
$420c0590 constant HASH_HASH_CSR38  \ offset: 0x190 : HASH context swap register 38
$420c0594 constant HASH_HASH_CSR39  \ offset: 0x194 : HASH context swap register 39
$420c0598 constant HASH_HASH_CSR40  \ offset: 0x198 : HASH context swap register 40
$420c059c constant HASH_HASH_CSR41  \ offset: 0x19C : HASH context swap register 41
$420c05a0 constant HASH_HASH_CSR42  \ offset: 0x1A0 : HASH context swap register 42
$420c05a4 constant HASH_HASH_CSR43  \ offset: 0x1A4 : HASH context swap register 43
$420c05a8 constant HASH_HASH_CSR44  \ offset: 0x1A8 : HASH context swap register 44
$420c05ac constant HASH_HASH_CSR45  \ offset: 0x1AC : HASH context swap register 45
$420c05b0 constant HASH_HASH_CSR46  \ offset: 0x1B0 : HASH context swap register 46
$420c05b4 constant HASH_HASH_CSR47  \ offset: 0x1B4 : HASH context swap register 47
$420c05b8 constant HASH_HASH_CSR48  \ offset: 0x1B8 : HASH context swap register 48
$420c05bc constant HASH_HASH_CSR49  \ offset: 0x1BC : HASH context swap register 49
$420c05c0 constant HASH_HASH_CSR50  \ offset: 0x1C0 : HASH context swap register 50
$420c05c4 constant HASH_HASH_CSR51  \ offset: 0x1C4 : HASH context swap register 51
$420c05c8 constant HASH_HASH_CSR52  \ offset: 0x1C8 : HASH context swap register 52
$420c05cc constant HASH_HASH_CSR53  \ offset: 0x1CC : HASH context swap register 53
$420c0710 constant HASH_HASH_HR0  \ offset: 0x310 : HASH digest register 0
$420c0714 constant HASH_HASH_HR1  \ offset: 0x314 : HASH digest register 1
$420c0718 constant HASH_HASH_HR2  \ offset: 0x318 : HASH digest register 2
$420c071c constant HASH_HASH_HR3  \ offset: 0x31C : HASH digest register 3
$420c0720 constant HASH_HASH_HR4  \ offset: 0x320 : HASH digest register 4
$420c0724 constant HASH_HASH_HR5  \ offset: 0x324 : HASH supplementary digest register 5
$420c0728 constant HASH_HASH_HR6  \ offset: 0x328 : HASH supplementary digest register 6
$420c072c constant HASH_HASH_HR7  \ offset: 0x32C : HASH supplementary digest register 7

