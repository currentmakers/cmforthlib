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
$00010000 constant HASH_HASH_CR_LKEY                                \ Long key selection The application must set this bit if the HMAC key is greater than the block size corresponding to the hash algorithm (see Table 280: Information on supported hash algorithms for details). For example the block size is 64 bytes for SHA2-256. This selection is only taken into account when the INIT and MODE bits are set (HMAC mode selected). Changing this bit during a computation has no effect.
$001e0000 constant HASH_HASH_CR_ALGO                                \ Algorithm selection These bits select the hash algorithm: This selection is only taken into account when the INIT bit is set. Changing this bitfield during a computation has no effect. When the ALGO bitfield is updated and INIT bit is set, NBWE in HASH_SR is automatically updated to 0x11.


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

$00000000 constant HASH_HASH_HRA0_H0                                \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA1_H1                                \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA2_H2                                \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA3_H3                                \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH aliased digest register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA4_H4                                \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


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

$00000000 constant HASH_HASH_CSR0_CS0                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 1
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR1_CS1                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 2
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR2_CS2                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 3
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR3_CS3                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 4
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR4_CS4                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 5
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR5_CS5                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 6
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR6_CS6                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 7
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR7_CS7                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 8
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR8_CS8                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 9
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR9_CS9                               \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 10
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR10_CS10                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 11
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR11_CS11                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 12
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR12_CS12                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 13
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR13_CS13                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 14
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR14_CS14                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 15
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR15_CS15                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 16
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR16_CS16                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 17
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR17_CS17                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 18
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR18_CS18                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 19
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR19_CS19                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 20
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR20_CS20                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 21
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR21_CS21                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 22
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR22_CS22                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 23
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR23_CS23                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 24
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR24_CS24                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 25
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR25_CS25                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 26
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR26_CS26                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 27
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR27_CS27                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 28
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR28_CS28                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 29
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR29_CS29                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 30
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR30_CS30                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 31
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR31_CS31                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 32
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR32_CS32                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 33
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR33_CS33                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 34
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR34_CS34                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 35
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR35_CS35                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 36
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR36_CS36                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 37
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR37_CS37                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 38
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR38_CS38                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 39
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR39_CS39                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 40
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR40_CS40                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 41
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR41_CS41                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 42
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR42_CS42                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 43
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR43_CS43                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 44
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR44_CS44                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 45
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR45_CS45                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 46
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR46_CS46                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 47
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR47_CS47                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 48
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR48_CS48                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 49
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR49_CS49                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 50
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR50_CS50                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 51
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR51_CS51                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 52
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR52_CS52                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 53
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR53_CS53                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 54
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR54_CS54                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 55
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR55_CS55                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 56
\ Address offset: 0x1D8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR56_CS56                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 57
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR57_CS57                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 58
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR58_CS58                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 59
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR59_CS59                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 60
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR60_CS60                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 61
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR61_CS61                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 62
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR62_CS62                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 63
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR63_CS63                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 64
\ Address offset: 0x1F8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR64_CS64                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 65
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR65_CS65                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 66
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR66_CS66                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 67
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR67_CS67                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 68
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR68_CS68                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 69
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR69_CS69                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 70
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR70_CS70                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 71
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR71_CS71                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 72
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR72_CS72                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 73
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR73_CS73                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 74
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR74_CS74                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 75
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR75_CS75                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 76
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR76_CS76                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 77
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR77_CS77                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 78
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR78_CS78                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 79
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR79_CS79                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 80
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR80_CS80                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 81
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR81_CS81                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 82
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR82_CS82                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 83
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR83_CS83                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 84
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR84_CS84                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 85
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR85_CS85                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 86
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR86_CS86                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 87
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR87_CS87                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 88
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR88_CS88                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 89
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR89_CS89                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 90
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR90_CS90                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 91
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR91_CS91                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 92
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR92_CS92                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 93
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR93_CS93                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 94
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR94_CS94                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 95
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR95_CS95                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 96
\ Address offset: 0x278
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR96_CS96                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 97
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR97_CS97                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 98
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR98_CS98                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 99
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR99_CS99                             \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 100
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR100_CS100                           \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 101
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR101_CS101                           \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH context swap register 102
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_CSR102_CS102                           \ Context swap x Refer to Section 34.7.7: HASH context swap registers introduction.


\
\ @brief HASH digest register 0
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR0_H0                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 1
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR1_H1                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 2
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR2_H2                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 3
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR3_H3                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH digest register 4
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR4_H4                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 5
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR5_H5                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 6
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR6_H6                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 7
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR7_H7                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 8
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR8_H8                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 9
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR9_H9                                 \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 10
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR10_H10                               \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 11
\ Address offset: 0x33C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR11_H11                               \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 12
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR12_H12                               \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 13
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR13_H13                               \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 14
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR14_H14                               \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief HASH supplementary digest register 15
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR15_H15                               \ Hash data x Refer to Section 34.7.4: HASH digest registers introduction.


\
\ @brief Hash processor
\
$48020400 constant HASH_HASH_CR   \ offset: 0x00 : HASH control register
$48020404 constant HASH_HASH_DIN  \ offset: 0x04 : HASH data input register
$48020408 constant HASH_HASH_STR  \ offset: 0x08 : HASH start register
$4802040c constant HASH_HASH_HRA0  \ offset: 0x0C : HASH aliased digest register 0
$48020410 constant HASH_HASH_HRA1  \ offset: 0x10 : HASH aliased digest register 1
$48020414 constant HASH_HASH_HRA2  \ offset: 0x14 : HASH aliased digest register 2
$48020418 constant HASH_HASH_HRA3  \ offset: 0x18 : HASH aliased digest register 3
$4802041c constant HASH_HASH_HRA4  \ offset: 0x1C : HASH aliased digest register 4
$48020420 constant HASH_HASH_IMR  \ offset: 0x20 : HASH interrupt enable register
$48020424 constant HASH_HASH_SR   \ offset: 0x24 : HASH status register
$480204f8 constant HASH_HASH_CSR0  \ offset: 0xF8 : HASH context swap register 0
$480204fc constant HASH_HASH_CSR1  \ offset: 0xFC : HASH context swap register 1
$48020500 constant HASH_HASH_CSR2  \ offset: 0x100 : HASH context swap register 2
$48020504 constant HASH_HASH_CSR3  \ offset: 0x104 : HASH context swap register 3
$48020508 constant HASH_HASH_CSR4  \ offset: 0x108 : HASH context swap register 4
$4802050c constant HASH_HASH_CSR5  \ offset: 0x10C : HASH context swap register 5
$48020510 constant HASH_HASH_CSR6  \ offset: 0x110 : HASH context swap register 6
$48020514 constant HASH_HASH_CSR7  \ offset: 0x114 : HASH context swap register 7
$48020518 constant HASH_HASH_CSR8  \ offset: 0x118 : HASH context swap register 8
$4802051c constant HASH_HASH_CSR9  \ offset: 0x11C : HASH context swap register 9
$48020520 constant HASH_HASH_CSR10  \ offset: 0x120 : HASH context swap register 10
$48020524 constant HASH_HASH_CSR11  \ offset: 0x124 : HASH context swap register 11
$48020528 constant HASH_HASH_CSR12  \ offset: 0x128 : HASH context swap register 12
$4802052c constant HASH_HASH_CSR13  \ offset: 0x12C : HASH context swap register 13
$48020530 constant HASH_HASH_CSR14  \ offset: 0x130 : HASH context swap register 14
$48020534 constant HASH_HASH_CSR15  \ offset: 0x134 : HASH context swap register 15
$48020538 constant HASH_HASH_CSR16  \ offset: 0x138 : HASH context swap register 16
$4802053c constant HASH_HASH_CSR17  \ offset: 0x13C : HASH context swap register 17
$48020540 constant HASH_HASH_CSR18  \ offset: 0x140 : HASH context swap register 18
$48020544 constant HASH_HASH_CSR19  \ offset: 0x144 : HASH context swap register 19
$48020548 constant HASH_HASH_CSR20  \ offset: 0x148 : HASH context swap register 20
$4802054c constant HASH_HASH_CSR21  \ offset: 0x14C : HASH context swap register 21
$48020550 constant HASH_HASH_CSR22  \ offset: 0x150 : HASH context swap register 22
$48020554 constant HASH_HASH_CSR23  \ offset: 0x154 : HASH context swap register 23
$48020558 constant HASH_HASH_CSR24  \ offset: 0x158 : HASH context swap register 24
$4802055c constant HASH_HASH_CSR25  \ offset: 0x15C : HASH context swap register 25
$48020560 constant HASH_HASH_CSR26  \ offset: 0x160 : HASH context swap register 26
$48020564 constant HASH_HASH_CSR27  \ offset: 0x164 : HASH context swap register 27
$48020568 constant HASH_HASH_CSR28  \ offset: 0x168 : HASH context swap register 28
$4802056c constant HASH_HASH_CSR29  \ offset: 0x16C : HASH context swap register 29
$48020570 constant HASH_HASH_CSR30  \ offset: 0x170 : HASH context swap register 30
$48020574 constant HASH_HASH_CSR31  \ offset: 0x174 : HASH context swap register 31
$48020578 constant HASH_HASH_CSR32  \ offset: 0x178 : HASH context swap register 32
$4802057c constant HASH_HASH_CSR33  \ offset: 0x17C : HASH context swap register 33
$48020580 constant HASH_HASH_CSR34  \ offset: 0x180 : HASH context swap register 34
$48020584 constant HASH_HASH_CSR35  \ offset: 0x184 : HASH context swap register 35
$48020588 constant HASH_HASH_CSR36  \ offset: 0x188 : HASH context swap register 36
$4802058c constant HASH_HASH_CSR37  \ offset: 0x18C : HASH context swap register 37
$48020590 constant HASH_HASH_CSR38  \ offset: 0x190 : HASH context swap register 38
$48020594 constant HASH_HASH_CSR39  \ offset: 0x194 : HASH context swap register 39
$48020598 constant HASH_HASH_CSR40  \ offset: 0x198 : HASH context swap register 40
$4802059c constant HASH_HASH_CSR41  \ offset: 0x19C : HASH context swap register 41
$480205a0 constant HASH_HASH_CSR42  \ offset: 0x1A0 : HASH context swap register 42
$480205a4 constant HASH_HASH_CSR43  \ offset: 0x1A4 : HASH context swap register 43
$480205a8 constant HASH_HASH_CSR44  \ offset: 0x1A8 : HASH context swap register 44
$480205ac constant HASH_HASH_CSR45  \ offset: 0x1AC : HASH context swap register 45
$480205b0 constant HASH_HASH_CSR46  \ offset: 0x1B0 : HASH context swap register 46
$480205b4 constant HASH_HASH_CSR47  \ offset: 0x1B4 : HASH context swap register 47
$480205b8 constant HASH_HASH_CSR48  \ offset: 0x1B8 : HASH context swap register 48
$480205bc constant HASH_HASH_CSR49  \ offset: 0x1BC : HASH context swap register 49
$480205c0 constant HASH_HASH_CSR50  \ offset: 0x1C0 : HASH context swap register 50
$480205c4 constant HASH_HASH_CSR51  \ offset: 0x1C4 : HASH context swap register 51
$480205c8 constant HASH_HASH_CSR52  \ offset: 0x1C8 : HASH context swap register 52
$480205cc constant HASH_HASH_CSR53  \ offset: 0x1CC : HASH context swap register 53
$480205d0 constant HASH_HASH_CSR54  \ offset: 0x1D0 : HASH context swap register 54
$480205d4 constant HASH_HASH_CSR55  \ offset: 0x1D4 : HASH context swap register 55
$480205d8 constant HASH_HASH_CSR56  \ offset: 0x1D8 : HASH context swap register 56
$480205dc constant HASH_HASH_CSR57  \ offset: 0x1DC : HASH context swap register 57
$480205e0 constant HASH_HASH_CSR58  \ offset: 0x1E0 : HASH context swap register 58
$480205e4 constant HASH_HASH_CSR59  \ offset: 0x1E4 : HASH context swap register 59
$480205e8 constant HASH_HASH_CSR60  \ offset: 0x1E8 : HASH context swap register 60
$480205ec constant HASH_HASH_CSR61  \ offset: 0x1EC : HASH context swap register 61
$480205f0 constant HASH_HASH_CSR62  \ offset: 0x1F0 : HASH context swap register 62
$480205f4 constant HASH_HASH_CSR63  \ offset: 0x1F4 : HASH context swap register 63
$480205f8 constant HASH_HASH_CSR64  \ offset: 0x1F8 : HASH context swap register 64
$480205fc constant HASH_HASH_CSR65  \ offset: 0x1FC : HASH context swap register 65
$48020600 constant HASH_HASH_CSR66  \ offset: 0x200 : HASH context swap register 66
$48020604 constant HASH_HASH_CSR67  \ offset: 0x204 : HASH context swap register 67
$48020608 constant HASH_HASH_CSR68  \ offset: 0x208 : HASH context swap register 68
$4802060c constant HASH_HASH_CSR69  \ offset: 0x20C : HASH context swap register 69
$48020610 constant HASH_HASH_CSR70  \ offset: 0x210 : HASH context swap register 70
$48020614 constant HASH_HASH_CSR71  \ offset: 0x214 : HASH context swap register 71
$48020618 constant HASH_HASH_CSR72  \ offset: 0x218 : HASH context swap register 72
$4802061c constant HASH_HASH_CSR73  \ offset: 0x21C : HASH context swap register 73
$48020620 constant HASH_HASH_CSR74  \ offset: 0x220 : HASH context swap register 74
$48020624 constant HASH_HASH_CSR75  \ offset: 0x224 : HASH context swap register 75
$48020628 constant HASH_HASH_CSR76  \ offset: 0x228 : HASH context swap register 76
$4802062c constant HASH_HASH_CSR77  \ offset: 0x22C : HASH context swap register 77
$48020630 constant HASH_HASH_CSR78  \ offset: 0x230 : HASH context swap register 78
$48020634 constant HASH_HASH_CSR79  \ offset: 0x234 : HASH context swap register 79
$48020638 constant HASH_HASH_CSR80  \ offset: 0x238 : HASH context swap register 80
$4802063c constant HASH_HASH_CSR81  \ offset: 0x23C : HASH context swap register 81
$48020640 constant HASH_HASH_CSR82  \ offset: 0x240 : HASH context swap register 82
$48020644 constant HASH_HASH_CSR83  \ offset: 0x244 : HASH context swap register 83
$48020648 constant HASH_HASH_CSR84  \ offset: 0x248 : HASH context swap register 84
$4802064c constant HASH_HASH_CSR85  \ offset: 0x24C : HASH context swap register 85
$48020650 constant HASH_HASH_CSR86  \ offset: 0x250 : HASH context swap register 86
$48020654 constant HASH_HASH_CSR87  \ offset: 0x254 : HASH context swap register 87
$48020658 constant HASH_HASH_CSR88  \ offset: 0x258 : HASH context swap register 88
$4802065c constant HASH_HASH_CSR89  \ offset: 0x25C : HASH context swap register 89
$48020660 constant HASH_HASH_CSR90  \ offset: 0x260 : HASH context swap register 90
$48020664 constant HASH_HASH_CSR91  \ offset: 0x264 : HASH context swap register 91
$48020668 constant HASH_HASH_CSR92  \ offset: 0x268 : HASH context swap register 92
$4802066c constant HASH_HASH_CSR93  \ offset: 0x26C : HASH context swap register 93
$48020670 constant HASH_HASH_CSR94  \ offset: 0x270 : HASH context swap register 94
$48020674 constant HASH_HASH_CSR95  \ offset: 0x274 : HASH context swap register 95
$48020678 constant HASH_HASH_CSR96  \ offset: 0x278 : HASH context swap register 96
$4802067c constant HASH_HASH_CSR97  \ offset: 0x27C : HASH context swap register 97
$48020680 constant HASH_HASH_CSR98  \ offset: 0x280 : HASH context swap register 98
$48020684 constant HASH_HASH_CSR99  \ offset: 0x284 : HASH context swap register 99
$48020688 constant HASH_HASH_CSR100  \ offset: 0x288 : HASH context swap register 100
$4802068c constant HASH_HASH_CSR101  \ offset: 0x28C : HASH context swap register 101
$48020690 constant HASH_HASH_CSR102  \ offset: 0x290 : HASH context swap register 102
$48020710 constant HASH_HASH_HR0  \ offset: 0x310 : HASH digest register 0
$48020714 constant HASH_HASH_HR1  \ offset: 0x314 : HASH digest register 1
$48020718 constant HASH_HASH_HR2  \ offset: 0x318 : HASH digest register 2
$4802071c constant HASH_HASH_HR3  \ offset: 0x31C : HASH digest register 3
$48020720 constant HASH_HASH_HR4  \ offset: 0x320 : HASH digest register 4
$48020724 constant HASH_HASH_HR5  \ offset: 0x324 : HASH supplementary digest register 5
$48020728 constant HASH_HASH_HR6  \ offset: 0x328 : HASH supplementary digest register 6
$4802072c constant HASH_HASH_HR7  \ offset: 0x32C : HASH supplementary digest register 7
$48020730 constant HASH_HASH_HR8  \ offset: 0x330 : HASH supplementary digest register 8
$48020734 constant HASH_HASH_HR9  \ offset: 0x334 : HASH supplementary digest register 9
$48020738 constant HASH_HASH_HR10  \ offset: 0x338 : HASH supplementary digest register 10
$4802073c constant HASH_HASH_HR11  \ offset: 0x33C : HASH supplementary digest register 11
$48020740 constant HASH_HASH_HR12  \ offset: 0x340 : HASH supplementary digest register 12
$48020744 constant HASH_HASH_HR13  \ offset: 0x344 : HASH supplementary digest register 13
$48020748 constant HASH_HASH_HR14  \ offset: 0x348 : HASH supplementary digest register 14
$4802074c constant HASH_HASH_HR15  \ offset: 0x34C : HASH supplementary digest register 15

