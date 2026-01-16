\
\ @file hash.fs
\ @brief HASH register bank
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
$00004000 constant HASH_HASH_CR_DMAA                                \ DMA Abort This bit is used to abort the usage of DMA to compute a digest. When DMAA is set, DMA requests are no more issued towards the DMA, with DMAE in HASH_CR register and DMAS in HASH_SR register both cleared. If DMAA is read, DMAA always returns 0. Writing 0 to this bit has no effect.
$00010000 constant HASH_HASH_CR_LKEY                                \ Long key selection The application must set this bit if the HMAC key is greater than the block size corresponding to the hash algorithm (see algorithms for details). For example the block size is 64 bytes for SHA2-256. This selection is only taken into account when the INIT and MODE bits are set (HMAC mode selected). Changing this bit during a computation has no effect.
$001e0000 constant HASH_HASH_CR_ALGO                                \ Algorithm selection These bits select the hash algorithm: 11xx: reserved This selection is only taken into account when the INIT bit is set. Changing this bitfield during a computation has no effect. When the ALGO bitfield is updated and INIT bit is set, NBWE in HASH_SR is automatically updated to 0x11 when ALGOÂ =Â 0x00XX.


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

$0000001f constant HASH_HASH_STR_NBLW                               \ Number of valid bits in the last word When the last word of the message bit string is written to HASH_DIN register, the hash processor takes only the valid bits, specified as below, after internal data swapping: ... Note: When SHA-3 is selected, bits 0 to 2 are kept at zero (byte oriented input). The above mechanism is valid only if DCALÂ =Â 0. If NBLW bits are written while DCAL is set to 1, the NBLW bitfield remains unchanged. In other words it is not possible to configure NBLW and set DCAL at the same time. Reading NBLW bits returns the last value written to NBLW.
$00000100 constant HASH_HASH_STR_DCAL                               \ Digest calculation Writing this bit to 1 starts the message padding using the previously written value of NBLW, and starts the calculation of the final message digest with all the data words written to the input FIFO since the INIT bit was last written to 1. Reading this bit returns 0.


\
\ @brief HASH aliased digest register 0
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA0_H                                 \ Hash data Refer to introduction.


\
\ @brief HASH aliased digest register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA1_H                                 \ Hash data Refer to introduction.


\
\ @brief HASH aliased digest register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA2_H                                 \ Hash data Refer to introduction.


\
\ @brief HASH aliased digest register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA3_H                                 \ Hash data Refer to introduction.


\
\ @brief HASH aliased digest register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HRA4_H                                 \ Hash data Refer to introduction.


\
\ @brief Data input interrupt enable
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant HASH_HASH_IMR_DINIE                              \ Data input interrupt enable
$00000002 constant HASH_HASH_IMR_DCIE                               \ Digest calculation completion interrupt enable


\
\ @brief Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINISÂ =Â 0, HASH_CSRx registers reads as zero.
\ Address offset: 0x24
\ Reset value: 0x00110001
\

$00000001 constant HASH_HASH_SR_DINIS                               \ Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINISÂ =Â 0, HASH_CSRx registers reads as zero.
$00000002 constant HASH_HASH_SR_DCIS                                \ Digest calculation completion interrupt status This bit is set by hardware when a digest becomes ready (the whole message has been processed). It is cleared by writing it to 0 or by writing the INIT bit to 1 in the HASH_CR register.
$00000004 constant HASH_HASH_SR_DMAS                                \ DMA Status This bit provides information on the DMA interface activity. It is set with DMAE and cleared when DMAEÂ =Â 0 and no DMA transfer is ongoing. No interrupt is associated with this bit.
$00000008 constant HASH_HASH_SR_BUSY                                \ Busy bit
$00007e00 constant HASH_HASH_SR_NBWP                                \ Number of words already pushed This bitfield is the exact number of words in the message that have already been pushed into the FIFO. NBWP is incremented by 1 when a write access is performed to the HASH_DIN register. When a digest calculation starts, NBWP is updated to NBWP- block size (in words), and NBWP goes to zero when the INIT bit is written to 1.
$00008000 constant HASH_HASH_SR_DINNE                               \ DIN not empty This bit is set when the HASH_DIN register holds valid data (that is after being written at least once). It is cleared when either the INIT bit (initialization) or the DCAL bit (completion of the previous message processing) is written to 1.
$003f0000 constant HASH_HASH_SR_NBWE                                \ Number of words expected This bitfield reflects the number of words in the message that must be pushed into the FIFO to trigger a partial computation. NBWE is decremented by 1 when a write access is performed to the HASH_DIN register. NBWE is set to the expected block size +1 in words when INIT bit is set in HASH_CR. It is set to the expected block size when the partial digest calculation ends.


\
\ @brief HASH context swap register 0
\ Address offset: 0xF8
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR0_CS0                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 1
\ Address offset: 0xFC
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR1_CS1                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 2
\ Address offset: 0x100
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR2_CS2                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 3
\ Address offset: 0x104
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR3_CS3                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 4
\ Address offset: 0x108
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR4_CS4                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 5
\ Address offset: 0x10C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR5_CS5                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 6
\ Address offset: 0x110
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR6_CS6                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 7
\ Address offset: 0x114
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR7_CS7                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 8
\ Address offset: 0x118
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR8_CS8                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 9
\ Address offset: 0x11C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR9_CS9                               \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 10
\ Address offset: 0x120
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR10_CS10                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 11
\ Address offset: 0x124
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR11_CS11                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 12
\ Address offset: 0x128
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR12_CS12                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 13
\ Address offset: 0x12C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR13_CS13                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 14
\ Address offset: 0x130
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR14_CS14                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 15
\ Address offset: 0x134
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR15_CS15                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 16
\ Address offset: 0x138
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR16_CS16                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 17
\ Address offset: 0x13C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR17_CS17                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 18
\ Address offset: 0x140
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR18_CS18                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 19
\ Address offset: 0x144
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR19_CS19                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 20
\ Address offset: 0x148
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR20_CS20                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 21
\ Address offset: 0x14C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR21_CS21                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 22
\ Address offset: 0x150
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR22_CS22                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 23
\ Address offset: 0x154
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR23_CS23                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 24
\ Address offset: 0x158
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR24_CS24                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 25
\ Address offset: 0x15C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR25_CS25                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 26
\ Address offset: 0x160
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR26_CS26                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 27
\ Address offset: 0x164
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR27_CS27                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 28
\ Address offset: 0x168
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR28_CS28                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 29
\ Address offset: 0x16C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR29_CS29                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 30
\ Address offset: 0x170
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR30_CS30                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 31
\ Address offset: 0x174
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR31_CS31                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 32
\ Address offset: 0x178
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR32_CS32                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 33
\ Address offset: 0x17C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR33_CS33                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 34
\ Address offset: 0x180
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR34_CS34                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 35
\ Address offset: 0x184
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR35_CS35                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 36
\ Address offset: 0x188
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR36_CS36                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 37
\ Address offset: 0x18C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR37_CS37                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 38
\ Address offset: 0x190
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR38_CS38                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 39
\ Address offset: 0x194
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR39_CS39                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 40
\ Address offset: 0x198
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR40_CS40                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 41
\ Address offset: 0x19C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR41_CS41                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 42
\ Address offset: 0x1A0
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR42_CS42                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 43
\ Address offset: 0x1A4
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR43_CS43                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 44
\ Address offset: 0x1A8
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR44_CS44                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 45
\ Address offset: 0x1AC
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR45_CS45                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 46
\ Address offset: 0x1B0
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR46_CS46                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 47
\ Address offset: 0x1B4
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR47_CS47                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 48
\ Address offset: 0x1B8
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR48_CS48                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 49
\ Address offset: 0x1BC
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR49_CS49                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 50
\ Address offset: 0x1C0
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR50_CS50                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 51
\ Address offset: 0x1C4
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR51_CS51                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 52
\ Address offset: 0x1C8
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR52_CS52                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 53
\ Address offset: 0x1CC
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR53_CS53                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 54
\ Address offset: 0x1D0
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR54_CS54                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 55
\ Address offset: 0x1D4
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR55_CS55                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 56
\ Address offset: 0x1D8
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR56_CS56                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 57
\ Address offset: 0x1DC
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR57_CS57                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 58
\ Address offset: 0x1E0
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR58_CS58                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 59
\ Address offset: 0x1E4
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR59_CS59                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 60
\ Address offset: 0x1E8
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR60_CS60                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 61
\ Address offset: 0x1EC
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR61_CS61                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 62
\ Address offset: 0x1F0
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR62_CS62                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 63
\ Address offset: 0x1F4
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR63_CS63                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 64
\ Address offset: 0x1F8
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR64_CS64                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 65
\ Address offset: 0x1FC
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR65_CS65                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 66
\ Address offset: 0x200
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR66_CS66                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 67
\ Address offset: 0x204
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR67_CS67                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 68
\ Address offset: 0x208
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR68_CS68                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 69
\ Address offset: 0x20C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR69_CS69                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 70
\ Address offset: 0x210
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR70_CS70                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 71
\ Address offset: 0x214
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR71_CS71                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 72
\ Address offset: 0x218
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR72_CS72                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 73
\ Address offset: 0x21C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR73_CS73                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 74
\ Address offset: 0x220
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR74_CS74                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 75
\ Address offset: 0x224
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR75_CS75                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 76
\ Address offset: 0x228
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR76_CS76                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 77
\ Address offset: 0x22C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR77_CS77                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 78
\ Address offset: 0x230
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR78_CS78                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 79
\ Address offset: 0x234
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR79_CS79                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 80
\ Address offset: 0x238
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR80_CS80                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 81
\ Address offset: 0x23C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR81_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 82
\ Address offset: 0x240
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR82_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 83
\ Address offset: 0x244
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR83_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 84
\ Address offset: 0x248
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR84_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 85
\ Address offset: 0x24C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR85_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 86
\ Address offset: 0x250
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR86_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 87
\ Address offset: 0x254
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR87_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 88
\ Address offset: 0x258
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR88_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 89
\ Address offset: 0x25C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR89_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 90
\ Address offset: 0x260
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR90_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 91
\ Address offset: 0x264
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR91_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 92
\ Address offset: 0x268
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR92_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 93
\ Address offset: 0x26C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR93_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 94
\ Address offset: 0x270
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR94_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 95
\ Address offset: 0x274
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR95_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 96
\ Address offset: 0x278
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR96_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 97
\ Address offset: 0x27C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR97_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 98
\ Address offset: 0x280
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR98_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 99
\ Address offset: 0x284
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR99_CSX                              \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 100
\ Address offset: 0x288
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR100_CSX                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 101
\ Address offset: 0x28C
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR101_CSX                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief HASH context swap register 102
\ Address offset: 0x290
\ Reset value: 0x00220002
\

$00000000 constant HASH_HASH_CSR102_CSX                             \ Context swap x (xÂ =Â 0 to 102) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR0_HX                                 \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR1_HX                                 \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR2_HX                                 \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR3_HX                                 \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR4_HX                                 \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR5_HX                                 \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR6_HX                                 \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR7_HX                                 \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR8_HX                                 \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR9_HX                                 \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR10_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x33C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR11_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR12_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR13_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR14_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR15_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR16_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR17_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x358
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR18_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR19_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR20_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR21_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x368
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR22_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x36C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR23_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR24_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x374
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR25_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x378
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR26_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x37C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR27_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR28_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR29_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR30_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR31_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR32_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR33_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR34_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR35_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR36_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR37_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR38_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3AC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR39_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3B0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR40_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3B4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR41_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3B8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR42_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3BC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR43_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3C0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR44_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3C4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR45_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3C8
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR46_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR47_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR48_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
\ Address offset: 0x3D4
\ Reset value: 0x00000000
\

$00000000 constant HASH_HASH_HR49_HX                                \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.


\
\ @brief HW generic 1 this bitfield reflects the DMA type connected to this HASH peripheral.
\ Address offset: 0x3F0
\ Reset value: 0x00010111
\

$0000000f constant HASH_HASH_HWCFGR_CFG1                            \ HW generic 1 this bitfield reflects the DMA type connected to this HASH peripheral.
$000000f0 constant HASH_HASH_HWCFGR_CFG2                            \ HW generic 2 This bitfield reflects that the HMAC is supported.
$00000f00 constant HASH_HASH_HWCFGR_CFG3                            \ HW generic 3 This bitfield reflects that the SHA3 algorithm is supported.
$0000f000 constant HASH_HASH_HWCFGR_CFG4                            \ HW generic 4 This bitfield is read as zero.
$000f0000 constant HASH_HASH_HWCFGR_CFG5                            \ HW generic 5 This bitfield reflects that the SHA384 and SHA512 algorithms are supported.


\
\ @brief Minor revision These bits return the HASH minor revision
\ Address offset: 0x3F4
\ Reset value: 0x00000040
\

$0000000f constant HASH_HASH_VERR_MINREV                            \ Minor revision These bits return the HASH minor revision
$000000f0 constant HASH_HASH_VERR_MAJREV                            \ Major revision These bits return the HASH major revision


\
\ @brief [31: 0]: Identifier These bits return the unique identifier of the HASH peripheral.
\ Address offset: 0x3F8
\ Reset value: 0x00170031
\

$00000000 constant HASH_HASH_IPIDR_ID                               \ [31: 0]: Identifier These bits return the unique identifier of the HASH peripheral.


\
\ @brief Size identification code This bitfield returns the size identification code of the HASH peripheral as defined below: Bits[31:8] = 0xA3C5DD (fixed code) Bits[7:0] = 0x01 (1-Kbyte address decoding)
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant HASH_HASH_SIDR_SID                               \ Size identification code This bitfield returns the size identification code of the HASH peripheral as defined below: Bits[31:8] = 0xA3C5DD (fixed code) Bits[7:0] = 0x01 (1-Kbyte address decoding)


\
\ @brief HASH register bank
\
$54003000 constant HASH_HASH_CR   \ offset: 0x00 : HASH control register
$54003004 constant HASH_HASH_DIN  \ offset: 0x04 : HASH data input register
$54003008 constant HASH_HASH_STR  \ offset: 0x08 : HASH start register
$5400300c constant HASH_HASH_HRA0  \ offset: 0x0C : HASH aliased digest register 0
$54003010 constant HASH_HASH_HRA1  \ offset: 0x10 : HASH aliased digest register 1
$54003014 constant HASH_HASH_HRA2  \ offset: 0x14 : HASH aliased digest register 2
$54003018 constant HASH_HASH_HRA3  \ offset: 0x18 : HASH aliased digest register 3
$5400301c constant HASH_HASH_HRA4  \ offset: 0x1C : HASH aliased digest register 4
$54003020 constant HASH_HASH_IMR  \ offset: 0x20 : Data input interrupt enable
$54003024 constant HASH_HASH_SR   \ offset: 0x24 : Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINISÂ =Â 0, HASH_CSRx registers reads as zero.
$540030f8 constant HASH_HASH_CSR0  \ offset: 0xF8 : HASH context swap register 0
$540030fc constant HASH_HASH_CSR1  \ offset: 0xFC : HASH context swap register 1
$54003100 constant HASH_HASH_CSR2  \ offset: 0x100 : HASH context swap register 2
$54003104 constant HASH_HASH_CSR3  \ offset: 0x104 : HASH context swap register 3
$54003108 constant HASH_HASH_CSR4  \ offset: 0x108 : HASH context swap register 4
$5400310c constant HASH_HASH_CSR5  \ offset: 0x10C : HASH context swap register 5
$54003110 constant HASH_HASH_CSR6  \ offset: 0x110 : HASH context swap register 6
$54003114 constant HASH_HASH_CSR7  \ offset: 0x114 : HASH context swap register 7
$54003118 constant HASH_HASH_CSR8  \ offset: 0x118 : HASH context swap register 8
$5400311c constant HASH_HASH_CSR9  \ offset: 0x11C : HASH context swap register 9
$54003120 constant HASH_HASH_CSR10  \ offset: 0x120 : HASH context swap register 10
$54003124 constant HASH_HASH_CSR11  \ offset: 0x124 : HASH context swap register 11
$54003128 constant HASH_HASH_CSR12  \ offset: 0x128 : HASH context swap register 12
$5400312c constant HASH_HASH_CSR13  \ offset: 0x12C : HASH context swap register 13
$54003130 constant HASH_HASH_CSR14  \ offset: 0x130 : HASH context swap register 14
$54003134 constant HASH_HASH_CSR15  \ offset: 0x134 : HASH context swap register 15
$54003138 constant HASH_HASH_CSR16  \ offset: 0x138 : HASH context swap register 16
$5400313c constant HASH_HASH_CSR17  \ offset: 0x13C : HASH context swap register 17
$54003140 constant HASH_HASH_CSR18  \ offset: 0x140 : HASH context swap register 18
$54003144 constant HASH_HASH_CSR19  \ offset: 0x144 : HASH context swap register 19
$54003148 constant HASH_HASH_CSR20  \ offset: 0x148 : HASH context swap register 20
$5400314c constant HASH_HASH_CSR21  \ offset: 0x14C : HASH context swap register 21
$54003150 constant HASH_HASH_CSR22  \ offset: 0x150 : HASH context swap register 22
$54003154 constant HASH_HASH_CSR23  \ offset: 0x154 : HASH context swap register 23
$54003158 constant HASH_HASH_CSR24  \ offset: 0x158 : HASH context swap register 24
$5400315c constant HASH_HASH_CSR25  \ offset: 0x15C : HASH context swap register 25
$54003160 constant HASH_HASH_CSR26  \ offset: 0x160 : HASH context swap register 26
$54003164 constant HASH_HASH_CSR27  \ offset: 0x164 : HASH context swap register 27
$54003168 constant HASH_HASH_CSR28  \ offset: 0x168 : HASH context swap register 28
$5400316c constant HASH_HASH_CSR29  \ offset: 0x16C : HASH context swap register 29
$54003170 constant HASH_HASH_CSR30  \ offset: 0x170 : HASH context swap register 30
$54003174 constant HASH_HASH_CSR31  \ offset: 0x174 : HASH context swap register 31
$54003178 constant HASH_HASH_CSR32  \ offset: 0x178 : HASH context swap register 32
$5400317c constant HASH_HASH_CSR33  \ offset: 0x17C : HASH context swap register 33
$54003180 constant HASH_HASH_CSR34  \ offset: 0x180 : HASH context swap register 34
$54003184 constant HASH_HASH_CSR35  \ offset: 0x184 : HASH context swap register 35
$54003188 constant HASH_HASH_CSR36  \ offset: 0x188 : HASH context swap register 36
$5400318c constant HASH_HASH_CSR37  \ offset: 0x18C : HASH context swap register 37
$54003190 constant HASH_HASH_CSR38  \ offset: 0x190 : HASH context swap register 38
$54003194 constant HASH_HASH_CSR39  \ offset: 0x194 : HASH context swap register 39
$54003198 constant HASH_HASH_CSR40  \ offset: 0x198 : HASH context swap register 40
$5400319c constant HASH_HASH_CSR41  \ offset: 0x19C : HASH context swap register 41
$540031a0 constant HASH_HASH_CSR42  \ offset: 0x1A0 : HASH context swap register 42
$540031a4 constant HASH_HASH_CSR43  \ offset: 0x1A4 : HASH context swap register 43
$540031a8 constant HASH_HASH_CSR44  \ offset: 0x1A8 : HASH context swap register 44
$540031ac constant HASH_HASH_CSR45  \ offset: 0x1AC : HASH context swap register 45
$540031b0 constant HASH_HASH_CSR46  \ offset: 0x1B0 : HASH context swap register 46
$540031b4 constant HASH_HASH_CSR47  \ offset: 0x1B4 : HASH context swap register 47
$540031b8 constant HASH_HASH_CSR48  \ offset: 0x1B8 : HASH context swap register 48
$540031bc constant HASH_HASH_CSR49  \ offset: 0x1BC : HASH context swap register 49
$540031c0 constant HASH_HASH_CSR50  \ offset: 0x1C0 : HASH context swap register 50
$540031c4 constant HASH_HASH_CSR51  \ offset: 0x1C4 : HASH context swap register 51
$540031c8 constant HASH_HASH_CSR52  \ offset: 0x1C8 : HASH context swap register 52
$540031cc constant HASH_HASH_CSR53  \ offset: 0x1CC : HASH context swap register 53
$540031d0 constant HASH_HASH_CSR54  \ offset: 0x1D0 : HASH context swap register 54
$540031d4 constant HASH_HASH_CSR55  \ offset: 0x1D4 : HASH context swap register 55
$540031d8 constant HASH_HASH_CSR56  \ offset: 0x1D8 : HASH context swap register 56
$540031dc constant HASH_HASH_CSR57  \ offset: 0x1DC : HASH context swap register 57
$540031e0 constant HASH_HASH_CSR58  \ offset: 0x1E0 : HASH context swap register 58
$540031e4 constant HASH_HASH_CSR59  \ offset: 0x1E4 : HASH context swap register 59
$540031e8 constant HASH_HASH_CSR60  \ offset: 0x1E8 : HASH context swap register 60
$540031ec constant HASH_HASH_CSR61  \ offset: 0x1EC : HASH context swap register 61
$540031f0 constant HASH_HASH_CSR62  \ offset: 0x1F0 : HASH context swap register 62
$540031f4 constant HASH_HASH_CSR63  \ offset: 0x1F4 : HASH context swap register 63
$540031f8 constant HASH_HASH_CSR64  \ offset: 0x1F8 : HASH context swap register 64
$540031fc constant HASH_HASH_CSR65  \ offset: 0x1FC : HASH context swap register 65
$54003200 constant HASH_HASH_CSR66  \ offset: 0x200 : HASH context swap register 66
$54003204 constant HASH_HASH_CSR67  \ offset: 0x204 : HASH context swap register 67
$54003208 constant HASH_HASH_CSR68  \ offset: 0x208 : HASH context swap register 68
$5400320c constant HASH_HASH_CSR69  \ offset: 0x20C : HASH context swap register 69
$54003210 constant HASH_HASH_CSR70  \ offset: 0x210 : HASH context swap register 70
$54003214 constant HASH_HASH_CSR71  \ offset: 0x214 : HASH context swap register 71
$54003218 constant HASH_HASH_CSR72  \ offset: 0x218 : HASH context swap register 72
$5400321c constant HASH_HASH_CSR73  \ offset: 0x21C : HASH context swap register 73
$54003220 constant HASH_HASH_CSR74  \ offset: 0x220 : HASH context swap register 74
$54003224 constant HASH_HASH_CSR75  \ offset: 0x224 : HASH context swap register 75
$54003228 constant HASH_HASH_CSR76  \ offset: 0x228 : HASH context swap register 76
$5400322c constant HASH_HASH_CSR77  \ offset: 0x22C : HASH context swap register 77
$54003230 constant HASH_HASH_CSR78  \ offset: 0x230 : HASH context swap register 78
$54003234 constant HASH_HASH_CSR79  \ offset: 0x234 : HASH context swap register 79
$54003238 constant HASH_HASH_CSR80  \ offset: 0x238 : HASH context swap register 80
$5400323c constant HASH_HASH_CSR81  \ offset: 0x23C : HASH context swap register 81
$54003240 constant HASH_HASH_CSR82  \ offset: 0x240 : HASH context swap register 82
$54003244 constant HASH_HASH_CSR83  \ offset: 0x244 : HASH context swap register 83
$54003248 constant HASH_HASH_CSR84  \ offset: 0x248 : HASH context swap register 84
$5400324c constant HASH_HASH_CSR85  \ offset: 0x24C : HASH context swap register 85
$54003250 constant HASH_HASH_CSR86  \ offset: 0x250 : HASH context swap register 86
$54003254 constant HASH_HASH_CSR87  \ offset: 0x254 : HASH context swap register 87
$54003258 constant HASH_HASH_CSR88  \ offset: 0x258 : HASH context swap register 88
$5400325c constant HASH_HASH_CSR89  \ offset: 0x25C : HASH context swap register 89
$54003260 constant HASH_HASH_CSR90  \ offset: 0x260 : HASH context swap register 90
$54003264 constant HASH_HASH_CSR91  \ offset: 0x264 : HASH context swap register 91
$54003268 constant HASH_HASH_CSR92  \ offset: 0x268 : HASH context swap register 92
$5400326c constant HASH_HASH_CSR93  \ offset: 0x26C : HASH context swap register 93
$54003270 constant HASH_HASH_CSR94  \ offset: 0x270 : HASH context swap register 94
$54003274 constant HASH_HASH_CSR95  \ offset: 0x274 : HASH context swap register 95
$54003278 constant HASH_HASH_CSR96  \ offset: 0x278 : HASH context swap register 96
$5400327c constant HASH_HASH_CSR97  \ offset: 0x27C : HASH context swap register 97
$54003280 constant HASH_HASH_CSR98  \ offset: 0x280 : HASH context swap register 98
$54003284 constant HASH_HASH_CSR99  \ offset: 0x284 : HASH context swap register 99
$54003288 constant HASH_HASH_CSR100  \ offset: 0x288 : HASH context swap register 100
$5400328c constant HASH_HASH_CSR101  \ offset: 0x28C : HASH context swap register 101
$54003290 constant HASH_HASH_CSR102  \ offset: 0x290 : HASH context swap register 102
$54003310 constant HASH_HASH_HR0  \ offset: 0x310 : Hash data x (xÂ =Â 0 to 4) Refer to introduction.
$54003314 constant HASH_HASH_HR1  \ offset: 0x314 : Hash data x (xÂ =Â 0 to 4) Refer to introduction.
$54003318 constant HASH_HASH_HR2  \ offset: 0x318 : Hash data x (xÂ =Â 0 to 4) Refer to introduction.
$5400331c constant HASH_HASH_HR3  \ offset: 0x31C : Hash data x (xÂ =Â 0 to 4) Refer to introduction.
$54003320 constant HASH_HASH_HR4  \ offset: 0x320 : Hash data x (xÂ =Â 0 to 4) Refer to introduction.
$54003324 constant HASH_HASH_HR5  \ offset: 0x324 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003328 constant HASH_HASH_HR6  \ offset: 0x328 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$5400332c constant HASH_HASH_HR7  \ offset: 0x32C : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003330 constant HASH_HASH_HR8  \ offset: 0x330 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003334 constant HASH_HASH_HR9  \ offset: 0x334 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003338 constant HASH_HASH_HR10  \ offset: 0x338 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$5400333c constant HASH_HASH_HR11  \ offset: 0x33C : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003340 constant HASH_HASH_HR12  \ offset: 0x340 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003344 constant HASH_HASH_HR13  \ offset: 0x344 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003348 constant HASH_HASH_HR14  \ offset: 0x348 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$5400334c constant HASH_HASH_HR15  \ offset: 0x34C : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003350 constant HASH_HASH_HR16  \ offset: 0x350 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003354 constant HASH_HASH_HR17  \ offset: 0x354 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003358 constant HASH_HASH_HR18  \ offset: 0x358 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$5400335c constant HASH_HASH_HR19  \ offset: 0x35C : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003360 constant HASH_HASH_HR20  \ offset: 0x360 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003364 constant HASH_HASH_HR21  \ offset: 0x364 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003368 constant HASH_HASH_HR22  \ offset: 0x368 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$5400336c constant HASH_HASH_HR23  \ offset: 0x36C : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003370 constant HASH_HASH_HR24  \ offset: 0x370 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003374 constant HASH_HASH_HR25  \ offset: 0x374 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003378 constant HASH_HASH_HR26  \ offset: 0x378 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$5400337c constant HASH_HASH_HR27  \ offset: 0x37C : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003380 constant HASH_HASH_HR28  \ offset: 0x380 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003384 constant HASH_HASH_HR29  \ offset: 0x384 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003388 constant HASH_HASH_HR30  \ offset: 0x388 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$5400338c constant HASH_HASH_HR31  \ offset: 0x38C : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003390 constant HASH_HASH_HR32  \ offset: 0x390 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003394 constant HASH_HASH_HR33  \ offset: 0x394 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$54003398 constant HASH_HASH_HR34  \ offset: 0x398 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$5400339c constant HASH_HASH_HR35  \ offset: 0x39C : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033a0 constant HASH_HASH_HR36  \ offset: 0x3A0 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033a4 constant HASH_HASH_HR37  \ offset: 0x3A4 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033a8 constant HASH_HASH_HR38  \ offset: 0x3A8 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033ac constant HASH_HASH_HR39  \ offset: 0x3AC : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033b0 constant HASH_HASH_HR40  \ offset: 0x3B0 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033b4 constant HASH_HASH_HR41  \ offset: 0x3B4 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033b8 constant HASH_HASH_HR42  \ offset: 0x3B8 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033bc constant HASH_HASH_HR43  \ offset: 0x3BC : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033c0 constant HASH_HASH_HR44  \ offset: 0x3C0 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033c4 constant HASH_HASH_HR45  \ offset: 0x3C4 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033c8 constant HASH_HASH_HR46  \ offset: 0x3C8 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033cc constant HASH_HASH_HR47  \ offset: 0x3CC : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033d0 constant HASH_HASH_HR48  \ offset: 0x3D0 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033d4 constant HASH_HASH_HR49  \ offset: 0x3D4 : Hash data x (xÂ =Â 5 to 49) Refer to introduction.
$540033f0 constant HASH_HASH_HWCFGR  \ offset: 0x3F0 : HW generic 1 this bitfield reflects the DMA type connected to this HASH peripheral.
$540033f4 constant HASH_HASH_VERR  \ offset: 0x3F4 : Minor revision These bits return the HASH minor revision
$540033f8 constant HASH_HASH_IPIDR  \ offset: 0x3F8 : [31: 0]: Identifier These bits return the unique identifier of the HASH peripheral.
$540033fc constant HASH_HASH_SIDR  \ offset: 0x3FC : Size identification code This bitfield returns the size identification code of the HASH peripheral as defined below: Bits[31:8] = 0xA3C5DD (fixed code) Bits[7:0] = 0x01 (1-Kbyte address decoding)

