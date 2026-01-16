\
\ @file sec_hash.fs
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

$00000004 constant SEC_HASH_HASH_CR_INIT                            \ Initialize message digest calculation Writing this bit to 1 resets the hash processor core, so that the HASH is ready to compute the message digest of a new message. Writing this bit to 0 has no effect. Reading this bit always returns 0.
$00000008 constant SEC_HASH_HASH_CR_DMAE                            \ DMA enable After this bit is set, it is cleared by hardware while the last data of the message is written into the hash processor. Setting this bit to 0 while a DMA transfer is ongoing does not abort the current transfer. Instead, the DMA interface of the HASH remains internally enabled until the transfer is completed or INIT is written to 1. Setting INIT bit to 1 does not clear DMAE bit.
$00000030 constant SEC_HASH_HASH_CR_DATATYPE                        \ Data type selection This bitfield defines the format of the data entered into the HASH_DIN register:
$00000040 constant SEC_HASH_HASH_CR_MODE                            \ Mode selection This bit selects the normal or the keyed HMAC mode for the selected algorithm: This selection is only taken into account when the INIT bit is set. Changing this bit during a computation has no effect.
$00000f00 constant SEC_HASH_HASH_CR_NBW                             \ Number of words already pushed Refer to NBWP[3:0] bitfield of HASH_SR for a description of NBW[3:0] bitfield. This bit is read-only.
$00001000 constant SEC_HASH_HASH_CR_DINNE                           \ DIN not empty Refer to DINNE bit of HASH_SR for a description of DINNE bit. This bit is read-only.
$00002000 constant SEC_HASH_HASH_CR_MDMAT                           \ Multiple DMA transfers This bit is set when hashing large files when multiple DMA transfers are needed.
$00010000 constant SEC_HASH_HASH_CR_LKEY                            \ Long key selection The application must set this bit if the HMAC key is greater than the block size corresponding to the hash algorithm (see algorithms for details). For example the block size is 64 bytes for SHA2-256. This selection is only taken into account when the INIT and MODE bits are set (HMAC mode selected). Changing this bit during a computation has no effect.
$001e0000 constant SEC_HASH_HASH_CR_ALGO                            \ Algorithm selection These bits select the hash algorithm: This selection is only taken into account when the INIT bit is set. Changing this bitfield during a computation has no effect. When the ALGO bitfield is updated and INIT bit is set, NBWE in HASH_SR is automatically updated to 0x11.


\
\ @brief HASH data input register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_DIN_DATAIN                         \ Data input Writing this register pushes the current register content into the FIFO, and the register takes the new value presented on the AHB bus. Reading this register returns zeros.


\
\ @brief HASH start register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant SEC_HASH_HASH_STR_NBLW                           \ Number of valid bits in the last word When the last word of the message bit string is written to HASH_DIN register, the hash processor takes only the valid bits, specified as below, after internal data swapping: ... The above mechanism is valid only if DCAL = 0. If NBLW bits are written while DCAL is set to 1, the NBLW bitfield remains unchanged. In other words it is not possible to configure NBLW and set DCAL at the same time. Reading NBLW bits returns the last value written to NBLW.
$00000100 constant SEC_HASH_HASH_STR_DCAL                           \ Digest calculation Writing this bit to 1 starts the message padding using the previously written value of NBLW, and starts the calculation of the final message digest with all the data words written to the input FIFO since the INIT bit was last written to 1. Reading this bit returns 0.


\
\ @brief HASH aliased digest register 0
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA0_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH aliased digest register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA1_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH aliased digest register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA2_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH aliased digest register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA3_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH aliased digest register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HRA4_HX                            \ Hash data x Refer to introduction.


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
\ Reset value: 0x00110001
\

$00000001 constant SEC_HASH_HASH_SR_DINIS                           \ Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINIS = 0, HASH_CSRx registers reads as zero.
$00000002 constant SEC_HASH_HASH_SR_DCIS                            \ Digest calculation completion interrupt status This bit is set by hardware when a digest becomes ready (the whole message has been processed). It is cleared by writing it to 0 or by writing the INIT bit to 1 in the HASH_CR register.
$00000004 constant SEC_HASH_HASH_SR_DMAS                            \ DMA Status This bit provides information on the DMA interface activity. It is set with DMAE and cleared when DMAE = 0 and no DMA transfer is ongoing. No interrupt is associated with this bit.
$00000008 constant SEC_HASH_HASH_SR_BUSY                            \ Busy bit
$00003e00 constant SEC_HASH_HASH_SR_NBWP                            \ Number of words already pushed This bitfield is the exact number of words in the message that have already been pushed into the FIFO. NBWP is incremented by 1 when a write access is performed to the HASH_DIN register. When a digest calculation starts, NBWP is updated to NBWP- block size (in words), and NBWP goes to zero when the INIT bit is written to 1.
$00008000 constant SEC_HASH_HASH_SR_DINNE                           \ DIN not empty This bit is set when the HASH_DIN register holds valid data (that is after being written at least once). It is cleared when either the INIT bit (initialization) or the DCAL bit (completion of the previous message processing) is written to 1.
$001f0000 constant SEC_HASH_HASH_SR_NBWE                            \ Number of words expected This bitfield reflects the number of words in the message that must be pushed into the FIFO to trigger a partial computation. NBWE is decremented by 1 when a write access is performed to the HASH_DIN register. NBWE is set to the expected block size +1 in words (0x11) when INIT bit is set in HASH_CR. It is set to the expected block size (0x10) when the partial digest calculation ends.


\
\ @brief HASH context swap register 0
\ Address offset: 0xF8
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR0_CSX                           \ Context swap 0 Refer to introduction.


\
\ @brief HASH context swap register 1
\ Address offset: 0xFC
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR1_CSX                           \ Context swap 1 Refer to introduction.


\
\ @brief HASH context swap register 2
\ Address offset: 0x100
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR2_CSX                           \ Context swap 2 Refer to introduction.


\
\ @brief HASH context swap register 3
\ Address offset: 0x104
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR3_CSX                           \ Context swap 3 Refer to introduction.


\
\ @brief HASH context swap register 4
\ Address offset: 0x108
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR4_CSX                           \ Context swap 4 Refer to introduction.


\
\ @brief HASH context swap register 5
\ Address offset: 0x10C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR5_CSX                           \ Context swap 5 Refer to introduction.


\
\ @brief HASH context swap register 6
\ Address offset: 0x110
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR6_CSX                           \ Context swap 6 Refer to introduction.


\
\ @brief HASH context swap register 7
\ Address offset: 0x114
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR7_CSX                           \ Context swap 7 Refer to introduction.


\
\ @brief HASH context swap register 8
\ Address offset: 0x118
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR8_CSX                           \ Context swap 8 Refer to introduction.


\
\ @brief HASH context swap register 9
\ Address offset: 0x11C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR9_CSX                           \ Context swap 9 Refer to introduction.


\
\ @brief HASH context swap register 10
\ Address offset: 0x120
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR10_CSX                          \ Context swap 10 Refer to introduction.


\
\ @brief HASH context swap register 11
\ Address offset: 0x124
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR11_CSX                          \ Context swap 11 Refer to introduction.


\
\ @brief HASH context swap register 12
\ Address offset: 0x128
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR12_CSX                          \ Context swap 12 Refer to introduction.


\
\ @brief HASH context swap register 13
\ Address offset: 0x12C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR13_CSX                          \ Context swap 13 Refer to introduction.


\
\ @brief HASH context swap register 14
\ Address offset: 0x130
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR14_CSX                          \ Context swap 14 Refer to introduction.


\
\ @brief HASH context swap register 15
\ Address offset: 0x134
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR15_CSX                          \ Context swap 15 Refer to introduction.


\
\ @brief HASH context swap register 16
\ Address offset: 0x138
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR16_CSX                          \ Context swap 16 Refer to introduction.


\
\ @brief HASH context swap register 17
\ Address offset: 0x13C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR17_CSX                          \ Context swap 17 Refer to introduction.


\
\ @brief HASH context swap register 18
\ Address offset: 0x140
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR18_CSX                          \ Context swap 18 Refer to introduction.


\
\ @brief HASH context swap register 19
\ Address offset: 0x144
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR19_CSX                          \ Context swap 19 Refer to introduction.


\
\ @brief HASH context swap register 20
\ Address offset: 0x148
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR20_CSX                          \ Context swap 20 Refer to introduction.


\
\ @brief HASH context swap register 21
\ Address offset: 0x14C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR21_CSX                          \ Context swap 21 Refer to introduction.


\
\ @brief HASH context swap register 22
\ Address offset: 0x150
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR22_CSX                          \ Context swap 22 Refer to introduction.


\
\ @brief HASH context swap register 23
\ Address offset: 0x154
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR23_CSX                          \ Context swap 23 Refer to introduction.


\
\ @brief HASH context swap register 24
\ Address offset: 0x158
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR24_CSX                          \ Context swap 24 Refer to introduction.


\
\ @brief HASH context swap register 25
\ Address offset: 0x15C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR25_CSX                          \ Context swap 25 Refer to introduction.


\
\ @brief HASH context swap register 26
\ Address offset: 0x160
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR26_CSX                          \ Context swap 26 Refer to introduction.


\
\ @brief HASH context swap register 27
\ Address offset: 0x164
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR27_CSX                          \ Context swap 27 Refer to introduction.


\
\ @brief HASH context swap register 28
\ Address offset: 0x168
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR28_CSX                          \ Context swap 28 Refer to introduction.


\
\ @brief HASH context swap register 29
\ Address offset: 0x16C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR29_CSX                          \ Context swap 29 Refer to introduction.


\
\ @brief HASH context swap register 30
\ Address offset: 0x170
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR30_CSX                          \ Context swap 30 Refer to introduction.


\
\ @brief HASH context swap register 31
\ Address offset: 0x174
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR31_CSX                          \ Context swap 31 Refer to introduction.


\
\ @brief HASH context swap register 32
\ Address offset: 0x178
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR32_CSX                          \ Context swap 32 Refer to introduction.


\
\ @brief HASH context swap register 33
\ Address offset: 0x17C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR33_CSX                          \ Context swap 33 Refer to introduction.


\
\ @brief HASH context swap register 34
\ Address offset: 0x180
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR34_CSX                          \ Context swap 34 Refer to introduction.


\
\ @brief HASH context swap register 35
\ Address offset: 0x184
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR35_CSX                          \ Context swap 35 Refer to introduction.


\
\ @brief HASH context swap register 36
\ Address offset: 0x188
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR36_CSX                          \ Context swap 36 Refer to introduction.


\
\ @brief HASH context swap register 37
\ Address offset: 0x18C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR37_CSX                          \ Context swap 37 Refer to introduction.


\
\ @brief HASH context swap register 38
\ Address offset: 0x190
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR38_CSX                          \ Context swap 38 Refer to introduction.


\
\ @brief HASH context swap register 39
\ Address offset: 0x194
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR39_CSX                          \ Context swap 39 Refer to introduction.


\
\ @brief HASH context swap register 40
\ Address offset: 0x198
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR40_CSX                          \ Context swap 40 Refer to introduction.


\
\ @brief HASH context swap register 41
\ Address offset: 0x19C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR41_CSX                          \ Context swap 41 Refer to introduction.


\
\ @brief HASH context swap register 42
\ Address offset: 0x1A0
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR42_CSX                          \ Context swap 42 Refer to introduction.


\
\ @brief HASH context swap register 43
\ Address offset: 0x1A4
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR43_CSX                          \ Context swap 43 Refer to introduction.


\
\ @brief HASH context swap register 44
\ Address offset: 0x1A8
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR44_CSX                          \ Context swap 44 Refer to introduction.


\
\ @brief HASH context swap register 45
\ Address offset: 0x1AC
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR45_CSX                          \ Context swap 45 Refer to introduction.


\
\ @brief HASH context swap register 46
\ Address offset: 0x1B0
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR46_CSX                          \ Context swap 46 Refer to introduction.


\
\ @brief HASH context swap register 47
\ Address offset: 0x1B4
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR47_CSX                          \ Context swap 47 Refer to introduction.


\
\ @brief HASH context swap register 48
\ Address offset: 0x1B8
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR48_CSX                          \ Context swap 48 Refer to introduction.


\
\ @brief HASH context swap register 49
\ Address offset: 0x1BC
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR49_CSX                          \ Context swap 49 Refer to introduction.


\
\ @brief HASH context swap register 50
\ Address offset: 0x1C0
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR50_CSX                          \ Context swap 50 Refer to introduction.


\
\ @brief HASH context swap register 51
\ Address offset: 0x1C4
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR51_CSX                          \ Context swap 51 Refer to introduction.


\
\ @brief HASH context swap register 52
\ Address offset: 0x1C8
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR52_CSX                          \ Context swap 52 Refer to introduction.


\
\ @brief HASH context swap register 53
\ Address offset: 0x1CC
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR53_CSX                          \ Context swap 53 Refer to introduction.


\
\ @brief HASH context swap register 54
\ Address offset: 0x1D0
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR54_CSX                          \ Context swap 54 Refer to introduction.


\
\ @brief HASH context swap register 55
\ Address offset: 0x1D4
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR55_CSX                          \ Context swap 55 Refer to introduction.


\
\ @brief HASH context swap register 56
\ Address offset: 0x1D8
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR56_CSX                          \ Context swap 56 Refer to introduction.


\
\ @brief HASH context swap register 57
\ Address offset: 0x1DC
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR57_CSX                          \ Context swap 57 Refer to introduction.


\
\ @brief HASH context swap register 58
\ Address offset: 0x1E0
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR58_CSX                          \ Context swap 58 Refer to introduction.


\
\ @brief HASH context swap register 59
\ Address offset: 0x1E4
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR59_CSX                          \ Context swap 59 Refer to introduction.


\
\ @brief HASH context swap register 60
\ Address offset: 0x1E8
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR60_CSX                          \ Context swap 60 Refer to introduction.


\
\ @brief HASH context swap register 61
\ Address offset: 0x1EC
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR61_CSX                          \ Context swap 61 Refer to introduction.


\
\ @brief HASH context swap register 62
\ Address offset: 0x1F0
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR62_CSX                          \ Context swap 62 Refer to introduction.


\
\ @brief HASH context swap register 63
\ Address offset: 0x1F4
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR63_CSX                          \ Context swap 63 Refer to introduction.


\
\ @brief HASH context swap register 64
\ Address offset: 0x1F8
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR64_CSX                          \ Context swap 64 Refer to introduction.


\
\ @brief HASH context swap register 65
\ Address offset: 0x1FC
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR65_CSX                          \ Context swap 65 Refer to introduction.


\
\ @brief HASH context swap register 66
\ Address offset: 0x200
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR66_CSX                          \ Context swap 66 Refer to introduction.


\
\ @brief HASH context swap register 67
\ Address offset: 0x204
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR67_CSX                          \ Context swap 67 Refer to introduction.


\
\ @brief HASH context swap register 68
\ Address offset: 0x208
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR68_CSX                          \ Context swap 68 Refer to introduction.


\
\ @brief HASH context swap register 69
\ Address offset: 0x20C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR69_CSX                          \ Context swap 69 Refer to introduction.


\
\ @brief HASH context swap register 70
\ Address offset: 0x210
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR70_CSX                          \ Context swap 70 Refer to introduction.


\
\ @brief HASH context swap register 71
\ Address offset: 0x214
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR71_CSX                          \ Context swap 71 Refer to introduction.


\
\ @brief HASH context swap register 72
\ Address offset: 0x218
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR72_CSX                          \ Context swap 72 Refer to introduction.


\
\ @brief HASH context swap register 73
\ Address offset: 0x21C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR73_CSX                          \ Context swap 73 Refer to introduction.


\
\ @brief HASH context swap register 74
\ Address offset: 0x220
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR74_CSX                          \ Context swap 74 Refer to introduction.


\
\ @brief HASH context swap register 75
\ Address offset: 0x224
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR75_CSX                          \ Context swap 75 Refer to introduction.


\
\ @brief HASH context swap register 76
\ Address offset: 0x228
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR76_CSX                          \ Context swap 76 Refer to introduction.


\
\ @brief HASH context swap register 77
\ Address offset: 0x22C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR77_CSX                          \ Context swap 77 Refer to introduction.


\
\ @brief HASH context swap register 78
\ Address offset: 0x230
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR78_CSX                          \ Context swap 78 Refer to introduction.


\
\ @brief HASH context swap register 79
\ Address offset: 0x234
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR79_CSX                          \ Context swap 79 Refer to introduction.


\
\ @brief HASH context swap register 80
\ Address offset: 0x238
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR80_CSX                          \ Context swap 80 Refer to introduction.


\
\ @brief HASH context swap register 81
\ Address offset: 0x23C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR81_CSX                          \ Context swap 81 Refer to introduction.


\
\ @brief HASH context swap register 82
\ Address offset: 0x240
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR82_CSX                          \ Context swap 82 Refer to introduction.


\
\ @brief HASH context swap register 83
\ Address offset: 0x244
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR83_CSX                          \ Context swap 83 Refer to introduction.


\
\ @brief HASH context swap register 84
\ Address offset: 0x248
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR84_CSX                          \ Context swap 84 Refer to introduction.


\
\ @brief HASH context swap register 85
\ Address offset: 0x24C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR85_CSX                          \ Context swap 85 Refer to introduction.


\
\ @brief HASH context swap register 86
\ Address offset: 0x250
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR86_CSX                          \ Context swap 86 Refer to introduction.


\
\ @brief HASH context swap register 87
\ Address offset: 0x254
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR87_CSX                          \ Context swap 87 Refer to introduction.


\
\ @brief HASH context swap register 88
\ Address offset: 0x258
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR88_CSX                          \ Context swap 88 Refer to introduction.


\
\ @brief HASH context swap register 89
\ Address offset: 0x25C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR89_CSX                          \ Context swap 89 Refer to introduction.


\
\ @brief HASH context swap register 90
\ Address offset: 0x260
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR90_CSX                          \ Context swap 90 Refer to introduction.


\
\ @brief HASH context swap register 91
\ Address offset: 0x264
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR91_CSX                          \ Context swap 91 Refer to introduction.


\
\ @brief HASH context swap register 92
\ Address offset: 0x268
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR92_CSX                          \ Context swap 92 Refer to introduction.


\
\ @brief HASH context swap register 93
\ Address offset: 0x26C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR93_CSX                          \ Context swap 93 Refer to introduction.


\
\ @brief HASH context swap register 94
\ Address offset: 0x270
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR94_CSX                          \ Context swap 94 Refer to introduction.


\
\ @brief HASH context swap register 95
\ Address offset: 0x274
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR95_CSX                          \ Context swap 95 Refer to introduction.


\
\ @brief HASH context swap register 96
\ Address offset: 0x278
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR96_CSX                          \ Context swap 96 Refer to introduction.


\
\ @brief HASH context swap register 97
\ Address offset: 0x27C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR97_CSX                          \ Context swap 97 Refer to introduction.


\
\ @brief HASH context swap register 98
\ Address offset: 0x280
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR98_CSX                          \ Context swap 98 Refer to introduction.


\
\ @brief HASH context swap register 99
\ Address offset: 0x284
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR99_CSX                          \ Context swap 99 Refer to introduction.


\
\ @brief HASH context swap register 100
\ Address offset: 0x288
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR100_CSX                         \ Context swap 100 Refer to introduction.


\
\ @brief HASH context swap register 101
\ Address offset: 0x28C
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR101_CSX                         \ Context swap 101 Refer to introduction.


\
\ @brief HASH context swap register 102
\ Address offset: 0x290
\ Reset value: 0x00220002
\

$00000000 constant SEC_HASH_HASH_CSR102_CSX                         \ Context swap 102 Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR0_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR1_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR2_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR3_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR4_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR5_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR6_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR7_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR8_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR9_HX                             \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR10_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x33C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR11_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR12_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR13_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR14_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH digest register
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$00000000 constant SEC_HASH_HASH_HR15_HX                            \ Hash data x Refer to introduction.


\
\ @brief HASH register bank
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
$520c05d0 constant SEC_HASH_HASH_CSR54  \ offset: 0x1D0 : HASH context swap register 54
$520c05d4 constant SEC_HASH_HASH_CSR55  \ offset: 0x1D4 : HASH context swap register 55
$520c05d8 constant SEC_HASH_HASH_CSR56  \ offset: 0x1D8 : HASH context swap register 56
$520c05dc constant SEC_HASH_HASH_CSR57  \ offset: 0x1DC : HASH context swap register 57
$520c05e0 constant SEC_HASH_HASH_CSR58  \ offset: 0x1E0 : HASH context swap register 58
$520c05e4 constant SEC_HASH_HASH_CSR59  \ offset: 0x1E4 : HASH context swap register 59
$520c05e8 constant SEC_HASH_HASH_CSR60  \ offset: 0x1E8 : HASH context swap register 60
$520c05ec constant SEC_HASH_HASH_CSR61  \ offset: 0x1EC : HASH context swap register 61
$520c05f0 constant SEC_HASH_HASH_CSR62  \ offset: 0x1F0 : HASH context swap register 62
$520c05f4 constant SEC_HASH_HASH_CSR63  \ offset: 0x1F4 : HASH context swap register 63
$520c05f8 constant SEC_HASH_HASH_CSR64  \ offset: 0x1F8 : HASH context swap register 64
$520c05fc constant SEC_HASH_HASH_CSR65  \ offset: 0x1FC : HASH context swap register 65
$520c0600 constant SEC_HASH_HASH_CSR66  \ offset: 0x200 : HASH context swap register 66
$520c0604 constant SEC_HASH_HASH_CSR67  \ offset: 0x204 : HASH context swap register 67
$520c0608 constant SEC_HASH_HASH_CSR68  \ offset: 0x208 : HASH context swap register 68
$520c060c constant SEC_HASH_HASH_CSR69  \ offset: 0x20C : HASH context swap register 69
$520c0610 constant SEC_HASH_HASH_CSR70  \ offset: 0x210 : HASH context swap register 70
$520c0614 constant SEC_HASH_HASH_CSR71  \ offset: 0x214 : HASH context swap register 71
$520c0618 constant SEC_HASH_HASH_CSR72  \ offset: 0x218 : HASH context swap register 72
$520c061c constant SEC_HASH_HASH_CSR73  \ offset: 0x21C : HASH context swap register 73
$520c0620 constant SEC_HASH_HASH_CSR74  \ offset: 0x220 : HASH context swap register 74
$520c0624 constant SEC_HASH_HASH_CSR75  \ offset: 0x224 : HASH context swap register 75
$520c0628 constant SEC_HASH_HASH_CSR76  \ offset: 0x228 : HASH context swap register 76
$520c062c constant SEC_HASH_HASH_CSR77  \ offset: 0x22C : HASH context swap register 77
$520c0630 constant SEC_HASH_HASH_CSR78  \ offset: 0x230 : HASH context swap register 78
$520c0634 constant SEC_HASH_HASH_CSR79  \ offset: 0x234 : HASH context swap register 79
$520c0638 constant SEC_HASH_HASH_CSR80  \ offset: 0x238 : HASH context swap register 80
$520c063c constant SEC_HASH_HASH_CSR81  \ offset: 0x23C : HASH context swap register 81
$520c0640 constant SEC_HASH_HASH_CSR82  \ offset: 0x240 : HASH context swap register 82
$520c0644 constant SEC_HASH_HASH_CSR83  \ offset: 0x244 : HASH context swap register 83
$520c0648 constant SEC_HASH_HASH_CSR84  \ offset: 0x248 : HASH context swap register 84
$520c064c constant SEC_HASH_HASH_CSR85  \ offset: 0x24C : HASH context swap register 85
$520c0650 constant SEC_HASH_HASH_CSR86  \ offset: 0x250 : HASH context swap register 86
$520c0654 constant SEC_HASH_HASH_CSR87  \ offset: 0x254 : HASH context swap register 87
$520c0658 constant SEC_HASH_HASH_CSR88  \ offset: 0x258 : HASH context swap register 88
$520c065c constant SEC_HASH_HASH_CSR89  \ offset: 0x25C : HASH context swap register 89
$520c0660 constant SEC_HASH_HASH_CSR90  \ offset: 0x260 : HASH context swap register 90
$520c0664 constant SEC_HASH_HASH_CSR91  \ offset: 0x264 : HASH context swap register 91
$520c0668 constant SEC_HASH_HASH_CSR92  \ offset: 0x268 : HASH context swap register 92
$520c066c constant SEC_HASH_HASH_CSR93  \ offset: 0x26C : HASH context swap register 93
$520c0670 constant SEC_HASH_HASH_CSR94  \ offset: 0x270 : HASH context swap register 94
$520c0674 constant SEC_HASH_HASH_CSR95  \ offset: 0x274 : HASH context swap register 95
$520c0678 constant SEC_HASH_HASH_CSR96  \ offset: 0x278 : HASH context swap register 96
$520c067c constant SEC_HASH_HASH_CSR97  \ offset: 0x27C : HASH context swap register 97
$520c0680 constant SEC_HASH_HASH_CSR98  \ offset: 0x280 : HASH context swap register 98
$520c0684 constant SEC_HASH_HASH_CSR99  \ offset: 0x284 : HASH context swap register 99
$520c0688 constant SEC_HASH_HASH_CSR100  \ offset: 0x288 : HASH context swap register 100
$520c068c constant SEC_HASH_HASH_CSR101  \ offset: 0x28C : HASH context swap register 101
$520c0690 constant SEC_HASH_HASH_CSR102  \ offset: 0x290 : HASH context swap register 102
$520c0710 constant SEC_HASH_HASH_HR0  \ offset: 0x310 : HASH digest register
$520c0714 constant SEC_HASH_HASH_HR1  \ offset: 0x314 : HASH digest register
$520c0718 constant SEC_HASH_HASH_HR2  \ offset: 0x318 : HASH digest register
$520c071c constant SEC_HASH_HASH_HR3  \ offset: 0x31C : HASH digest register
$520c0720 constant SEC_HASH_HASH_HR4  \ offset: 0x320 : HASH digest register
$520c0724 constant SEC_HASH_HASH_HR5  \ offset: 0x324 : HASH digest register
$520c0728 constant SEC_HASH_HASH_HR6  \ offset: 0x328 : HASH digest register
$520c072c constant SEC_HASH_HASH_HR7  \ offset: 0x32C : HASH digest register
$520c0730 constant SEC_HASH_HASH_HR8  \ offset: 0x330 : HASH digest register
$520c0734 constant SEC_HASH_HASH_HR9  \ offset: 0x334 : HASH digest register
$520c0738 constant SEC_HASH_HASH_HR10  \ offset: 0x338 : HASH digest register
$520c073c constant SEC_HASH_HASH_HR11  \ offset: 0x33C : HASH digest register
$520c0740 constant SEC_HASH_HASH_HR12  \ offset: 0x340 : HASH digest register
$520c0744 constant SEC_HASH_HASH_HR13  \ offset: 0x344 : HASH digest register
$520c0748 constant SEC_HASH_HASH_HR14  \ offset: 0x348 : HASH digest register
$520c074c constant SEC_HASH_HASH_HR15  \ offset: 0x34C : HASH digest register

