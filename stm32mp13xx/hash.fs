\
\ @file hash.fs
\ @brief HASH register bank
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HASH_DEF

  [ifdef] HASH_HASH_CR_DEF
    \
    \ @brief HASH control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant HASH_INIT                      \ [0x02] Initialize message digest calculation Writing this bit to 1 resets the hash processor core, so that the HASH is ready to compute the message digest of a new message. Writing this bit to 0 has no effect. Reading this bit always returns 0.
    $03 constant HASH_DMAE                      \ [0x03] DMA enable After this bit is set, it is cleared by hardware while the last data of the message is written into the hash processor. Setting this bit to 0 while a DMA transfer is ongoing does not abort the current transfer. Instead, the DMA interface of the HASH remains internally enabled until the transfer is completed or INIT is written to 1. Setting INIT bit to 1 does not clear DMAE bit.
    $04 constant HASH_DATATYPE                  \ [0x04 : 2] Data type selection This bitfield defines the format of the data entered into the HASH_DIN register:
    $06 constant HASH_MODE                      \ [0x06] Mode selection This bit selects the normal or the keyed HMAC mode for the selected algorithm: This selection is only taken into account when the INIT bit is set. Changing this bit during a computation has no effect.
    $08 constant HASH_NBW                       \ [0x08 : 4] Number of words already pushed Refer to NBWP[3:0] bitfield of HASH_SR for a description of NBW[3:0] bitfield. This bit is read-only.
    $0c constant HASH_DINNE                     \ [0x0c] DIN not empty Refer to DINNE bit of HASH_SR for a description of DINNE bit. This bit is read-only.
    $0d constant HASH_MDMAT                     \ [0x0d] Multiple DMA transfers This bit is set when hashing large files when multiple DMA transfers are needed.
    $0e constant HASH_DMAA                      \ [0x0e] DMA Abort This bit is used to abort the usage of DMA to compute a digest. When DMAA is set, DMA requests are no more issued towards the DMA, with DMAE in HASH_CR register and DMAS in HASH_SR register both cleared. If DMAA is read, DMAA always returns 0. Writing 0 to this bit has no effect.
    $10 constant HASH_LKEY                      \ [0x10] Long key selection The application must set this bit if the HMAC key is greater than the block size corresponding to the hash algorithm (see algorithms for details). For example the block size is 64 bytes for SHA2-256. This selection is only taken into account when the INIT and MODE bits are set (HMAC mode selected). Changing this bit during a computation has no effect.
    $11 constant HASH_ALGO                      \ [0x11 : 4] Algorithm selection These bits select the hash algorithm: 11xx: reserved This selection is only taken into account when the INIT bit is set. Changing this bitfield during a computation has no effect. When the ALGO bitfield is updated and INIT bit is set, NBWE in HASH_SR is automatically updated to 0x11 when ALGOÂ =Â 0x00XX.
  [then]


  [ifdef] HASH_HASH_DIN_DEF
    \
    \ @brief HASH data input register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HASH_DATAIN                    \ [0x00 : 32] Data input Writing this register pushes the current register content into the FIFO, and the register takes the new value presented on the AHB bus. Reading this register returns zeros.
  [then]


  [ifdef] HASH_HASH_STR_DEF
    \
    \ @brief HASH start register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HASH_NBLW                      \ [0x00 : 5] Number of valid bits in the last word When the last word of the message bit string is written to HASH_DIN register, the hash processor takes only the valid bits, specified as below, after internal data swapping: ... Note: When SHA-3 is selected, bits 0 to 2 are kept at zero (byte oriented input). The above mechanism is valid only if DCALÂ =Â 0. If NBLW bits are written while DCAL is set to 1, the NBLW bitfield remains unchanged. In other words it is not possible to configure NBLW and set DCAL at the same time. Reading NBLW bits returns the last value written to NBLW.
    $08 constant HASH_DCAL                      \ [0x08] Digest calculation Writing this bit to 1 starts the message padding using the previously written value of NBLW, and starts the calculation of the final message digest with all the data words written to the input FIFO since the INIT bit was last written to 1. Reading this bit returns 0.
  [then]


  [ifdef] HASH_HASH_HRA0_DEF
    \
    \ @brief HASH aliased digest register 0
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H                         \ [0x00 : 32] Hash data Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HRA1_DEF
    \
    \ @brief HASH aliased digest register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H                         \ [0x00 : 32] Hash data Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HRA2_DEF
    \
    \ @brief HASH aliased digest register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H                         \ [0x00 : 32] Hash data Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HRA3_DEF
    \
    \ @brief HASH aliased digest register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H                         \ [0x00 : 32] Hash data Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HRA4_DEF
    \
    \ @brief HASH aliased digest register 4
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H                         \ [0x00 : 32] Hash data Refer to introduction.
  [then]


  [ifdef] HASH_HASH_IMR_DEF
    \
    \ @brief Data input interrupt enable
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant HASH_DINIE                     \ [0x00] Data input interrupt enable
    $01 constant HASH_DCIE                      \ [0x01] Digest calculation completion interrupt enable
  [then]


  [ifdef] HASH_HASH_SR_DEF
    \
    \ @brief Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINISÂ =Â 0, HASH_CSRx registers reads as zero.
    \ Address offset: 0x24
    \ Reset value: 0x00110001
    \
    $00 constant HASH_DINIS                     \ [0x00] Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINISÂ =Â 0, HASH_CSRx registers reads as zero.
    $01 constant HASH_DCIS                      \ [0x01] Digest calculation completion interrupt status This bit is set by hardware when a digest becomes ready (the whole message has been processed). It is cleared by writing it to 0 or by writing the INIT bit to 1 in the HASH_CR register.
    $02 constant HASH_DMAS                      \ [0x02] DMA Status This bit provides information on the DMA interface activity. It is set with DMAE and cleared when DMAEÂ =Â 0 and no DMA transfer is ongoing. No interrupt is associated with this bit.
    $03 constant HASH_BUSY                      \ [0x03] Busy bit
    $09 constant HASH_NBWP                      \ [0x09 : 6] Number of words already pushed This bitfield is the exact number of words in the message that have already been pushed into the FIFO. NBWP is incremented by 1 when a write access is performed to the HASH_DIN register. When a digest calculation starts, NBWP is updated to NBWP- block size (in words), and NBWP goes to zero when the INIT bit is written to 1.
    $0f constant HASH_DINNE                     \ [0x0f] DIN not empty This bit is set when the HASH_DIN register holds valid data (that is after being written at least once). It is cleared when either the INIT bit (initialization) or the DCAL bit (completion of the previous message processing) is written to 1.
    $10 constant HASH_NBWE                      \ [0x10 : 6] Number of words expected This bitfield reflects the number of words in the message that must be pushed into the FIFO to trigger a partial computation. NBWE is decremented by 1 when a write access is performed to the HASH_DIN register. NBWE is set to the expected block size +1 in words when INIT bit is set in HASH_CR. It is set to the expected block size when the partial digest calculation ends.
  [then]


  [ifdef] HASH_HASH_CSR0_DEF
    \
    \ @brief HASH context swap register 0
    \ Address offset: 0xF8
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS0                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR1_DEF
    \
    \ @brief HASH context swap register 1
    \ Address offset: 0xFC
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS1                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR2_DEF
    \
    \ @brief HASH context swap register 2
    \ Address offset: 0x100
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS2                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR3_DEF
    \
    \ @brief HASH context swap register 3
    \ Address offset: 0x104
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS3                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR4_DEF
    \
    \ @brief HASH context swap register 4
    \ Address offset: 0x108
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS4                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR5_DEF
    \
    \ @brief HASH context swap register 5
    \ Address offset: 0x10C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS5                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR6_DEF
    \
    \ @brief HASH context swap register 6
    \ Address offset: 0x110
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS6                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR7_DEF
    \
    \ @brief HASH context swap register 7
    \ Address offset: 0x114
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS7                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR8_DEF
    \
    \ @brief HASH context swap register 8
    \ Address offset: 0x118
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS8                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR9_DEF
    \
    \ @brief HASH context swap register 9
    \ Address offset: 0x11C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS9                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR10_DEF
    \
    \ @brief HASH context swap register 10
    \ Address offset: 0x120
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS10                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR11_DEF
    \
    \ @brief HASH context swap register 11
    \ Address offset: 0x124
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS11                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR12_DEF
    \
    \ @brief HASH context swap register 12
    \ Address offset: 0x128
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS12                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR13_DEF
    \
    \ @brief HASH context swap register 13
    \ Address offset: 0x12C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS13                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR14_DEF
    \
    \ @brief HASH context swap register 14
    \ Address offset: 0x130
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS14                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR15_DEF
    \
    \ @brief HASH context swap register 15
    \ Address offset: 0x134
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS15                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR16_DEF
    \
    \ @brief HASH context swap register 16
    \ Address offset: 0x138
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS16                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR17_DEF
    \
    \ @brief HASH context swap register 17
    \ Address offset: 0x13C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS17                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR18_DEF
    \
    \ @brief HASH context swap register 18
    \ Address offset: 0x140
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS18                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR19_DEF
    \
    \ @brief HASH context swap register 19
    \ Address offset: 0x144
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS19                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR20_DEF
    \
    \ @brief HASH context swap register 20
    \ Address offset: 0x148
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS20                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR21_DEF
    \
    \ @brief HASH context swap register 21
    \ Address offset: 0x14C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS21                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR22_DEF
    \
    \ @brief HASH context swap register 22
    \ Address offset: 0x150
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS22                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR23_DEF
    \
    \ @brief HASH context swap register 23
    \ Address offset: 0x154
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS23                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR24_DEF
    \
    \ @brief HASH context swap register 24
    \ Address offset: 0x158
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS24                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR25_DEF
    \
    \ @brief HASH context swap register 25
    \ Address offset: 0x15C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS25                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR26_DEF
    \
    \ @brief HASH context swap register 26
    \ Address offset: 0x160
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS26                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR27_DEF
    \
    \ @brief HASH context swap register 27
    \ Address offset: 0x164
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS27                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR28_DEF
    \
    \ @brief HASH context swap register 28
    \ Address offset: 0x168
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS28                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR29_DEF
    \
    \ @brief HASH context swap register 29
    \ Address offset: 0x16C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS29                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR30_DEF
    \
    \ @brief HASH context swap register 30
    \ Address offset: 0x170
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS30                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR31_DEF
    \
    \ @brief HASH context swap register 31
    \ Address offset: 0x174
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS31                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR32_DEF
    \
    \ @brief HASH context swap register 32
    \ Address offset: 0x178
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS32                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR33_DEF
    \
    \ @brief HASH context swap register 33
    \ Address offset: 0x17C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS33                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR34_DEF
    \
    \ @brief HASH context swap register 34
    \ Address offset: 0x180
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS34                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR35_DEF
    \
    \ @brief HASH context swap register 35
    \ Address offset: 0x184
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS35                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR36_DEF
    \
    \ @brief HASH context swap register 36
    \ Address offset: 0x188
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS36                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR37_DEF
    \
    \ @brief HASH context swap register 37
    \ Address offset: 0x18C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS37                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR38_DEF
    \
    \ @brief HASH context swap register 38
    \ Address offset: 0x190
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS38                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR39_DEF
    \
    \ @brief HASH context swap register 39
    \ Address offset: 0x194
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS39                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR40_DEF
    \
    \ @brief HASH context swap register 40
    \ Address offset: 0x198
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS40                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR41_DEF
    \
    \ @brief HASH context swap register 41
    \ Address offset: 0x19C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS41                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR42_DEF
    \
    \ @brief HASH context swap register 42
    \ Address offset: 0x1A0
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS42                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR43_DEF
    \
    \ @brief HASH context swap register 43
    \ Address offset: 0x1A4
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS43                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR44_DEF
    \
    \ @brief HASH context swap register 44
    \ Address offset: 0x1A8
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS44                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR45_DEF
    \
    \ @brief HASH context swap register 45
    \ Address offset: 0x1AC
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS45                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR46_DEF
    \
    \ @brief HASH context swap register 46
    \ Address offset: 0x1B0
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS46                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR47_DEF
    \
    \ @brief HASH context swap register 47
    \ Address offset: 0x1B4
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS47                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR48_DEF
    \
    \ @brief HASH context swap register 48
    \ Address offset: 0x1B8
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS48                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR49_DEF
    \
    \ @brief HASH context swap register 49
    \ Address offset: 0x1BC
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS49                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR50_DEF
    \
    \ @brief HASH context swap register 50
    \ Address offset: 0x1C0
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS50                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR51_DEF
    \
    \ @brief HASH context swap register 51
    \ Address offset: 0x1C4
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS51                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR52_DEF
    \
    \ @brief HASH context swap register 52
    \ Address offset: 0x1C8
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS52                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR53_DEF
    \
    \ @brief HASH context swap register 53
    \ Address offset: 0x1CC
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS53                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR54_DEF
    \
    \ @brief HASH context swap register 54
    \ Address offset: 0x1D0
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS54                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR55_DEF
    \
    \ @brief HASH context swap register 55
    \ Address offset: 0x1D4
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS55                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR56_DEF
    \
    \ @brief HASH context swap register 56
    \ Address offset: 0x1D8
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS56                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR57_DEF
    \
    \ @brief HASH context swap register 57
    \ Address offset: 0x1DC
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS57                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR58_DEF
    \
    \ @brief HASH context swap register 58
    \ Address offset: 0x1E0
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS58                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR59_DEF
    \
    \ @brief HASH context swap register 59
    \ Address offset: 0x1E4
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS59                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR60_DEF
    \
    \ @brief HASH context swap register 60
    \ Address offset: 0x1E8
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS60                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR61_DEF
    \
    \ @brief HASH context swap register 61
    \ Address offset: 0x1EC
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS61                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR62_DEF
    \
    \ @brief HASH context swap register 62
    \ Address offset: 0x1F0
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS62                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR63_DEF
    \
    \ @brief HASH context swap register 63
    \ Address offset: 0x1F4
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS63                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR64_DEF
    \
    \ @brief HASH context swap register 64
    \ Address offset: 0x1F8
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS64                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR65_DEF
    \
    \ @brief HASH context swap register 65
    \ Address offset: 0x1FC
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS65                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR66_DEF
    \
    \ @brief HASH context swap register 66
    \ Address offset: 0x200
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS66                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR67_DEF
    \
    \ @brief HASH context swap register 67
    \ Address offset: 0x204
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS67                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR68_DEF
    \
    \ @brief HASH context swap register 68
    \ Address offset: 0x208
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS68                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR69_DEF
    \
    \ @brief HASH context swap register 69
    \ Address offset: 0x20C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS69                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR70_DEF
    \
    \ @brief HASH context swap register 70
    \ Address offset: 0x210
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS70                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR71_DEF
    \
    \ @brief HASH context swap register 71
    \ Address offset: 0x214
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS71                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR72_DEF
    \
    \ @brief HASH context swap register 72
    \ Address offset: 0x218
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS72                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR73_DEF
    \
    \ @brief HASH context swap register 73
    \ Address offset: 0x21C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS73                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR74_DEF
    \
    \ @brief HASH context swap register 74
    \ Address offset: 0x220
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS74                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR75_DEF
    \
    \ @brief HASH context swap register 75
    \ Address offset: 0x224
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS75                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR76_DEF
    \
    \ @brief HASH context swap register 76
    \ Address offset: 0x228
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS76                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR77_DEF
    \
    \ @brief HASH context swap register 77
    \ Address offset: 0x22C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS77                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR78_DEF
    \
    \ @brief HASH context swap register 78
    \ Address offset: 0x230
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS78                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR79_DEF
    \
    \ @brief HASH context swap register 79
    \ Address offset: 0x234
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS79                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR80_DEF
    \
    \ @brief HASH context swap register 80
    \ Address offset: 0x238
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CS80                      \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR81_DEF
    \
    \ @brief HASH context swap register 81
    \ Address offset: 0x23C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR82_DEF
    \
    \ @brief HASH context swap register 82
    \ Address offset: 0x240
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR83_DEF
    \
    \ @brief HASH context swap register 83
    \ Address offset: 0x244
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR84_DEF
    \
    \ @brief HASH context swap register 84
    \ Address offset: 0x248
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR85_DEF
    \
    \ @brief HASH context swap register 85
    \ Address offset: 0x24C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR86_DEF
    \
    \ @brief HASH context swap register 86
    \ Address offset: 0x250
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR87_DEF
    \
    \ @brief HASH context swap register 87
    \ Address offset: 0x254
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR88_DEF
    \
    \ @brief HASH context swap register 88
    \ Address offset: 0x258
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR89_DEF
    \
    \ @brief HASH context swap register 89
    \ Address offset: 0x25C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR90_DEF
    \
    \ @brief HASH context swap register 90
    \ Address offset: 0x260
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR91_DEF
    \
    \ @brief HASH context swap register 91
    \ Address offset: 0x264
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR92_DEF
    \
    \ @brief HASH context swap register 92
    \ Address offset: 0x268
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR93_DEF
    \
    \ @brief HASH context swap register 93
    \ Address offset: 0x26C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR94_DEF
    \
    \ @brief HASH context swap register 94
    \ Address offset: 0x270
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR95_DEF
    \
    \ @brief HASH context swap register 95
    \ Address offset: 0x274
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR96_DEF
    \
    \ @brief HASH context swap register 96
    \ Address offset: 0x278
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR97_DEF
    \
    \ @brief HASH context swap register 97
    \ Address offset: 0x27C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR98_DEF
    \
    \ @brief HASH context swap register 98
    \ Address offset: 0x280
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR99_DEF
    \
    \ @brief HASH context swap register 99
    \ Address offset: 0x284
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR100_DEF
    \
    \ @brief HASH context swap register 100
    \ Address offset: 0x288
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR101_DEF
    \
    \ @brief HASH context swap register 101
    \ Address offset: 0x28C
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_CSR102_DEF
    \
    \ @brief HASH context swap register 102
    \ Address offset: 0x290
    \ Reset value: 0x00220002
    \
    $00 constant HASH_CSx                       \ [0x00 : 32] Context swap x (xÂ =Â 0 to 102) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR0_DEF
    \
    \ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR1_DEF
    \
    \ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR2_DEF
    \
    \ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR3_DEF
    \
    \ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR4_DEF
    \
    \ @brief Hash data x (xÂ =Â 0 to 4) Refer to introduction.
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR5_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR6_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR7_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR8_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR9_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR10_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x338
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR11_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x33C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR12_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR13_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR14_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR15_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR16_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR17_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR18_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x358
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR19_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR20_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR21_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR22_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x368
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR23_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x36C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR24_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR25_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x374
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR26_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x378
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR27_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x37C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR28_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR29_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR30_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR31_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR32_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR33_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR34_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR35_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR36_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR37_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR38_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR39_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3AC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR40_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3B0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR41_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3B4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR42_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3B8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR43_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3BC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR44_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3C0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR45_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3C4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR46_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3C8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR47_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR48_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HR49_DEF
    \
    \ @brief Hash data x (xÂ =Â 5 to 49) Refer to introduction.
    \ Address offset: 0x3D4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_Hx                        \ [0x00 : 32] Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  [then]


  [ifdef] HASH_HASH_HWCFGR_DEF
    \
    \ @brief HW generic 1 this bitfield reflects the DMA type connected to this HASH peripheral.
    \ Address offset: 0x3F0
    \ Reset value: 0x00010111
    \
    $00 constant HASH_CFG1                      \ [0x00 : 4] HW generic 1 this bitfield reflects the DMA type connected to this HASH peripheral.
    $04 constant HASH_CFG2                      \ [0x04 : 4] HW generic 2 This bitfield reflects that the HMAC is supported.
    $08 constant HASH_CFG3                      \ [0x08 : 4] HW generic 3 This bitfield reflects that the SHA3 algorithm is supported.
    $0c constant HASH_CFG4                      \ [0x0c : 4] HW generic 4 This bitfield is read as zero.
    $10 constant HASH_CFG5                      \ [0x10 : 4] HW generic 5 This bitfield reflects that the SHA384 and SHA512 algorithms are supported.
  [then]


  [ifdef] HASH_HASH_VERR_DEF
    \
    \ @brief Minor revision These bits return the HASH minor revision
    \ Address offset: 0x3F4
    \ Reset value: 0x00000040
    \
    $00 constant HASH_MINREV                    \ [0x00 : 4] Minor revision These bits return the HASH minor revision
    $04 constant HASH_MAJREV                    \ [0x04 : 4] Major revision These bits return the HASH major revision
  [then]


  [ifdef] HASH_HASH_IPIDR_DEF
    \
    \ @brief [31: 0]: Identifier These bits return the unique identifier of the HASH peripheral.
    \ Address offset: 0x3F8
    \ Reset value: 0x00170031
    \
    $00 constant HASH_ID                        \ [0x00 : 32] [31: 0]: Identifier These bits return the unique identifier of the HASH peripheral.
  [then]


  [ifdef] HASH_HASH_SIDR_DEF
    \
    \ @brief Size identification code This bitfield returns the size identification code of the HASH peripheral as defined below: Bits[31:8] = 0xA3C5DD (fixed code) Bits[7:0] = 0x01 (1-Kbyte address decoding)
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant HASH_SID                       \ [0x00 : 32] Size identification code This bitfield returns the size identification code of the HASH peripheral as defined below: Bits[31:8] = 0xA3C5DD (fixed code) Bits[7:0] = 0x01 (1-Kbyte address decoding)
  [then]

  \
  \ @brief HASH register bank
  \
  $00 constant HASH_HASH_CR             \ HASH control register
  $04 constant HASH_HASH_DIN            \ HASH data input register
  $08 constant HASH_HASH_STR            \ HASH start register
  $0C constant HASH_HASH_HRA0           \ HASH aliased digest register 0
  $10 constant HASH_HASH_HRA1           \ HASH aliased digest register 1
  $14 constant HASH_HASH_HRA2           \ HASH aliased digest register 2
  $18 constant HASH_HASH_HRA3           \ HASH aliased digest register 3
  $1C constant HASH_HASH_HRA4           \ HASH aliased digest register 4
  $20 constant HASH_HASH_IMR            \ Data input interrupt enable
  $24 constant HASH_HASH_SR             \ Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINISÂ =Â 0, HASH_CSRx registers reads as zero.
  $F8 constant HASH_HASH_CSR0           \ HASH context swap register 0
  $FC constant HASH_HASH_CSR1           \ HASH context swap register 1
  $100 constant HASH_HASH_CSR2          \ HASH context swap register 2
  $104 constant HASH_HASH_CSR3          \ HASH context swap register 3
  $108 constant HASH_HASH_CSR4          \ HASH context swap register 4
  $10C constant HASH_HASH_CSR5          \ HASH context swap register 5
  $110 constant HASH_HASH_CSR6          \ HASH context swap register 6
  $114 constant HASH_HASH_CSR7          \ HASH context swap register 7
  $118 constant HASH_HASH_CSR8          \ HASH context swap register 8
  $11C constant HASH_HASH_CSR9          \ HASH context swap register 9
  $120 constant HASH_HASH_CSR10         \ HASH context swap register 10
  $124 constant HASH_HASH_CSR11         \ HASH context swap register 11
  $128 constant HASH_HASH_CSR12         \ HASH context swap register 12
  $12C constant HASH_HASH_CSR13         \ HASH context swap register 13
  $130 constant HASH_HASH_CSR14         \ HASH context swap register 14
  $134 constant HASH_HASH_CSR15         \ HASH context swap register 15
  $138 constant HASH_HASH_CSR16         \ HASH context swap register 16
  $13C constant HASH_HASH_CSR17         \ HASH context swap register 17
  $140 constant HASH_HASH_CSR18         \ HASH context swap register 18
  $144 constant HASH_HASH_CSR19         \ HASH context swap register 19
  $148 constant HASH_HASH_CSR20         \ HASH context swap register 20
  $14C constant HASH_HASH_CSR21         \ HASH context swap register 21
  $150 constant HASH_HASH_CSR22         \ HASH context swap register 22
  $154 constant HASH_HASH_CSR23         \ HASH context swap register 23
  $158 constant HASH_HASH_CSR24         \ HASH context swap register 24
  $15C constant HASH_HASH_CSR25         \ HASH context swap register 25
  $160 constant HASH_HASH_CSR26         \ HASH context swap register 26
  $164 constant HASH_HASH_CSR27         \ HASH context swap register 27
  $168 constant HASH_HASH_CSR28         \ HASH context swap register 28
  $16C constant HASH_HASH_CSR29         \ HASH context swap register 29
  $170 constant HASH_HASH_CSR30         \ HASH context swap register 30
  $174 constant HASH_HASH_CSR31         \ HASH context swap register 31
  $178 constant HASH_HASH_CSR32         \ HASH context swap register 32
  $17C constant HASH_HASH_CSR33         \ HASH context swap register 33
  $180 constant HASH_HASH_CSR34         \ HASH context swap register 34
  $184 constant HASH_HASH_CSR35         \ HASH context swap register 35
  $188 constant HASH_HASH_CSR36         \ HASH context swap register 36
  $18C constant HASH_HASH_CSR37         \ HASH context swap register 37
  $190 constant HASH_HASH_CSR38         \ HASH context swap register 38
  $194 constant HASH_HASH_CSR39         \ HASH context swap register 39
  $198 constant HASH_HASH_CSR40         \ HASH context swap register 40
  $19C constant HASH_HASH_CSR41         \ HASH context swap register 41
  $1A0 constant HASH_HASH_CSR42         \ HASH context swap register 42
  $1A4 constant HASH_HASH_CSR43         \ HASH context swap register 43
  $1A8 constant HASH_HASH_CSR44         \ HASH context swap register 44
  $1AC constant HASH_HASH_CSR45         \ HASH context swap register 45
  $1B0 constant HASH_HASH_CSR46         \ HASH context swap register 46
  $1B4 constant HASH_HASH_CSR47         \ HASH context swap register 47
  $1B8 constant HASH_HASH_CSR48         \ HASH context swap register 48
  $1BC constant HASH_HASH_CSR49         \ HASH context swap register 49
  $1C0 constant HASH_HASH_CSR50         \ HASH context swap register 50
  $1C4 constant HASH_HASH_CSR51         \ HASH context swap register 51
  $1C8 constant HASH_HASH_CSR52         \ HASH context swap register 52
  $1CC constant HASH_HASH_CSR53         \ HASH context swap register 53
  $1D0 constant HASH_HASH_CSR54         \ HASH context swap register 54
  $1D4 constant HASH_HASH_CSR55         \ HASH context swap register 55
  $1D8 constant HASH_HASH_CSR56         \ HASH context swap register 56
  $1DC constant HASH_HASH_CSR57         \ HASH context swap register 57
  $1E0 constant HASH_HASH_CSR58         \ HASH context swap register 58
  $1E4 constant HASH_HASH_CSR59         \ HASH context swap register 59
  $1E8 constant HASH_HASH_CSR60         \ HASH context swap register 60
  $1EC constant HASH_HASH_CSR61         \ HASH context swap register 61
  $1F0 constant HASH_HASH_CSR62         \ HASH context swap register 62
  $1F4 constant HASH_HASH_CSR63         \ HASH context swap register 63
  $1F8 constant HASH_HASH_CSR64         \ HASH context swap register 64
  $1FC constant HASH_HASH_CSR65         \ HASH context swap register 65
  $200 constant HASH_HASH_CSR66         \ HASH context swap register 66
  $204 constant HASH_HASH_CSR67         \ HASH context swap register 67
  $208 constant HASH_HASH_CSR68         \ HASH context swap register 68
  $20C constant HASH_HASH_CSR69         \ HASH context swap register 69
  $210 constant HASH_HASH_CSR70         \ HASH context swap register 70
  $214 constant HASH_HASH_CSR71         \ HASH context swap register 71
  $218 constant HASH_HASH_CSR72         \ HASH context swap register 72
  $21C constant HASH_HASH_CSR73         \ HASH context swap register 73
  $220 constant HASH_HASH_CSR74         \ HASH context swap register 74
  $224 constant HASH_HASH_CSR75         \ HASH context swap register 75
  $228 constant HASH_HASH_CSR76         \ HASH context swap register 76
  $22C constant HASH_HASH_CSR77         \ HASH context swap register 77
  $230 constant HASH_HASH_CSR78         \ HASH context swap register 78
  $234 constant HASH_HASH_CSR79         \ HASH context swap register 79
  $238 constant HASH_HASH_CSR80         \ HASH context swap register 80
  $23C constant HASH_HASH_CSR81         \ HASH context swap register 81
  $240 constant HASH_HASH_CSR82         \ HASH context swap register 82
  $244 constant HASH_HASH_CSR83         \ HASH context swap register 83
  $248 constant HASH_HASH_CSR84         \ HASH context swap register 84
  $24C constant HASH_HASH_CSR85         \ HASH context swap register 85
  $250 constant HASH_HASH_CSR86         \ HASH context swap register 86
  $254 constant HASH_HASH_CSR87         \ HASH context swap register 87
  $258 constant HASH_HASH_CSR88         \ HASH context swap register 88
  $25C constant HASH_HASH_CSR89         \ HASH context swap register 89
  $260 constant HASH_HASH_CSR90         \ HASH context swap register 90
  $264 constant HASH_HASH_CSR91         \ HASH context swap register 91
  $268 constant HASH_HASH_CSR92         \ HASH context swap register 92
  $26C constant HASH_HASH_CSR93         \ HASH context swap register 93
  $270 constant HASH_HASH_CSR94         \ HASH context swap register 94
  $274 constant HASH_HASH_CSR95         \ HASH context swap register 95
  $278 constant HASH_HASH_CSR96         \ HASH context swap register 96
  $27C constant HASH_HASH_CSR97         \ HASH context swap register 97
  $280 constant HASH_HASH_CSR98         \ HASH context swap register 98
  $284 constant HASH_HASH_CSR99         \ HASH context swap register 99
  $288 constant HASH_HASH_CSR100        \ HASH context swap register 100
  $28C constant HASH_HASH_CSR101        \ HASH context swap register 101
  $290 constant HASH_HASH_CSR102        \ HASH context swap register 102
  $310 constant HASH_HASH_HR0           \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  $314 constant HASH_HASH_HR1           \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  $318 constant HASH_HASH_HR2           \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  $31C constant HASH_HASH_HR3           \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  $320 constant HASH_HASH_HR4           \ Hash data x (xÂ =Â 0 to 4) Refer to introduction.
  $324 constant HASH_HASH_HR5           \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $328 constant HASH_HASH_HR6           \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $32C constant HASH_HASH_HR7           \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $330 constant HASH_HASH_HR8           \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $334 constant HASH_HASH_HR9           \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $338 constant HASH_HASH_HR10          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $33C constant HASH_HASH_HR11          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $340 constant HASH_HASH_HR12          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $344 constant HASH_HASH_HR13          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $348 constant HASH_HASH_HR14          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $34C constant HASH_HASH_HR15          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $350 constant HASH_HASH_HR16          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $354 constant HASH_HASH_HR17          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $358 constant HASH_HASH_HR18          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $35C constant HASH_HASH_HR19          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $360 constant HASH_HASH_HR20          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $364 constant HASH_HASH_HR21          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $368 constant HASH_HASH_HR22          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $36C constant HASH_HASH_HR23          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $370 constant HASH_HASH_HR24          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $374 constant HASH_HASH_HR25          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $378 constant HASH_HASH_HR26          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $37C constant HASH_HASH_HR27          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $380 constant HASH_HASH_HR28          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $384 constant HASH_HASH_HR29          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $388 constant HASH_HASH_HR30          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $38C constant HASH_HASH_HR31          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $390 constant HASH_HASH_HR32          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $394 constant HASH_HASH_HR33          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $398 constant HASH_HASH_HR34          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $39C constant HASH_HASH_HR35          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3A0 constant HASH_HASH_HR36          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3A4 constant HASH_HASH_HR37          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3A8 constant HASH_HASH_HR38          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3AC constant HASH_HASH_HR39          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3B0 constant HASH_HASH_HR40          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3B4 constant HASH_HASH_HR41          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3B8 constant HASH_HASH_HR42          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3BC constant HASH_HASH_HR43          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3C0 constant HASH_HASH_HR44          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3C4 constant HASH_HASH_HR45          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3C8 constant HASH_HASH_HR46          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3CC constant HASH_HASH_HR47          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3D0 constant HASH_HASH_HR48          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3D4 constant HASH_HASH_HR49          \ Hash data x (xÂ =Â 5 to 49) Refer to introduction.
  $3F0 constant HASH_HASH_HWCFGR        \ HW generic 1 this bitfield reflects the DMA type connected to this HASH peripheral.
  $3F4 constant HASH_HASH_VERR          \ Minor revision These bits return the HASH minor revision
  $3F8 constant HASH_HASH_IPIDR         \ [31: 0]: Identifier These bits return the unique identifier of the HASH peripheral.
  $3FC constant HASH_HASH_SIDR          \ Size identification code This bitfield returns the size identification code of the HASH peripheral as defined below: Bits[31:8] = 0xA3C5DD (fixed code) Bits[7:0] = 0x01 (1-Kbyte address decoding)

: HASH_DEF ; [then]
