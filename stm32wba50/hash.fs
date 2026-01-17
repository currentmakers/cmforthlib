\
\ @file hash.fs
\ @brief HASH register block
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
    $02 constant HASH_INIT                      \ [0x02] Initialize message digest calculation Writing this bit to 1 resets the hash processor core, so that the HASH is ready to compute the message digest of a new message. Writing this bit to 0 has no effect. Reading this bit always return 0.
    $03 constant HASH_DMAE                      \ [0x03] DMA enable After this bit is set it is cleared by hardware while the last data of the message is written into the hash processor. Setting this bit to 0 while a DMA transfer is ongoing is not aborting this current transfer. Instead, the DMA interface of the IP remains internally enabled until the transfer is completed or INIT is written to 1. Setting INIT bit to 1 does not clear DMAE bit.
    $04 constant HASH_DATATYPE                  \ [0x04 : 2] Data type selection Defines the format of the data entered into the HASH_DIN register:
    $06 constant HASH_MODE                      \ [0x06] Mode selection This bit selects the HASH or HMAC mode for the selected algorithm: This selection is only taken into account when the INIT bit is set. Changing this bit during a computation has no effect.
    $08 constant HASH_NBW                       \ [0x08 : 4] Number of words already pushed Refer to NBWP[3:0] bitfield of HASH_SR for the description. This bitfield is read-only.
    $0c constant HASH_DINNE                     \ [0x0c] DIN not empty Refer to DINNE bit of HASH_SR for the description. This bit is read-only.
    $0d constant HASH_MDMAT                     \ [0x0d] Multiple DMA transfers This bit is set when hashing large files when multiple DMA transfers are needed.
    $10 constant HASH_LKEY                      \ [0x10] Long key selection This bit selects between short key (less than or equal 64 bytes) or long key ( 64 bytes) in HMAC mode. This selection is only taken into account when the INIT and MODE bits are both set. Changing this bit during a computation has no effect.
    $11 constant HASH_ALGO                      \ [0x11 : 2] Algorithm selection These bits select the hash algorithm. This selection is only taken into account when the INIT bit is set. Changing this bitfield during a computation has no effect. When ALGO bitfield is updated and INIT bit is set, NBWE in HASH_SR is automatically updated to 0x11.
  [then]


  [ifdef] HASH_HASH_DIN_DEF
    \
    \ @brief HASH data input register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HASH_DATAIN                    \ [0x00 : 32] Data input Writing this register pushes the current register content into the IN FIFO, and the register takes the new value presented on the AHB databus. Reading this register returns zeros.
  [then]


  [ifdef] HASH_HASH_STR_DEF
    \
    \ @brief HASH start register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HASH_NBLW                      \ [0x00 : 5] Number of valid bits in the last word When the last word of the message bit string is written in HASH_DIN register, the hash processor takes only the valid bits specified as below, after internal data swapping: ... The above mechanism is valid only if DCAL = 0. If NBLW[4:0] bitfield is written while DCAL is set to 1, the NBLW[4:0] bitfield remains unchanged. In other words it is not possible to configure NBLW[4:0] and set DCAL at the same time. Reading NBLW[4:0] bitfield returns the last value written to NBLW[4:0].
    $08 constant HASH_DCAL                      \ [0x08] Digest calculation Writing this bit to 1 starts the message padding, using the previously written value of NBLW[4:0], and starts the calculation of the final message digest with all data words written to the input FIFO since the INIT bit was last written to 1. Reading this bit returns 0.
  [then]


  [ifdef] HASH_HASH_HRA0_DEF
    \
    \ @brief HASH aliased digest register 0
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H0                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HRA1_DEF
    \
    \ @brief HASH aliased digest register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H1                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HRA2_DEF
    \
    \ @brief HASH aliased digest register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H2                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HRA3_DEF
    \
    \ @brief HASH aliased digest register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H3                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HRA4_DEF
    \
    \ @brief HASH aliased digest register 4
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H4                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_IMR_DEF
    \
    \ @brief HASH interrupt enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant HASH_DINIE                     \ [0x00] Data input interrupt enable
    $01 constant HASH_DCIE                      \ [0x01] Digest calculation completion interrupt enable
  [then]


  [ifdef] HASH_HASH_SR_DEF
    \
    \ @brief HASH status register
    \ Address offset: 0x24
    \ Reset value: 0x00000001
    \
    $00 constant HASH_DINIS                     \ [0x00] Data input interrupt status This bit is set by hardware when the FIFO is ready to get a new block (16 locations are free). It is cleared by writing it to 0 or by writing the HASH_DIN register. When DINIS=0, HASH_CSRx registers reads as zero.
    $01 constant HASH_DCIS                      \ [0x01] Digest calculation completion interrupt status This bit is set by hardware when a digest becomes ready (the whole message has been processed). It is cleared by writing it to 0 or by writing the INIT bit to 1 in the HASH_CR register.
    $02 constant HASH_DMAS                      \ [0x02] DMA Status This bit provides information on the DMA interface activity. It is set with DMAE and cleared when DMAE = 0 and no DMA transfer is ongoing. No interrupt is associated with this bit.
    $03 constant HASH_BUSY                      \ [0x03] Busy bit
    $09 constant HASH_NBWP                      \ [0x09 : 5] Number of words already pushed This bitfield is the exact number of words in the message that have already been pushed into the FIFO. NBWP is incremented by one when a write access is performed to the HASH_DIN register. When a digest calculation starts, NBWP is updated to NBWP- block size (in words), and NBWP goes to zero when the INIT bit is written to 1.
    $0f constant HASH_DINNE                     \ [0x0f] DIN not empty This bit is set when the HASH_DIN register holds valid data (that is after being written at least once). It is cleared when either the INIT bit (initialization) or the DCAL bit (completion of the previous message processing) is written to 1.
    $10 constant HASH_NBWE                      \ [0x10 : 5] Number of words expected This bitfield reflects the number of words in the message that must be pushed into the FIFO to trigger a partial computation. NBWE is decremented by 1 when a write access is performed to the HASH_DIN register. NBWE is set to the expected block size +1 in words (0x11) when INIT bit is set in HASH_CR, and it is set to the expected block size when partial digest calculation ends.
  [then]


  [ifdef] HASH_HASH_CSR0_DEF
    \
    \ @brief HASH context swap register 0
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS0                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR1_DEF
    \
    \ @brief HASH context swap register 1
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS1                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR2_DEF
    \
    \ @brief HASH context swap register 2
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS2                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR3_DEF
    \
    \ @brief HASH context swap register 3
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS3                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR4_DEF
    \
    \ @brief HASH context swap register 4
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS4                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR5_DEF
    \
    \ @brief HASH context swap register 5
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS5                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR6_DEF
    \
    \ @brief HASH context swap register 6
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS6                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR7_DEF
    \
    \ @brief HASH context swap register 7
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS7                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR8_DEF
    \
    \ @brief HASH context swap register 8
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS8                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR9_DEF
    \
    \ @brief HASH context swap register 9
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS9                       \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR10_DEF
    \
    \ @brief HASH context swap register 10
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS10                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR11_DEF
    \
    \ @brief HASH context swap register 11
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS11                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR12_DEF
    \
    \ @brief HASH context swap register 12
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS12                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR13_DEF
    \
    \ @brief HASH context swap register 13
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS13                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR14_DEF
    \
    \ @brief HASH context swap register 14
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS14                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR15_DEF
    \
    \ @brief HASH context swap register 15
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS15                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR16_DEF
    \
    \ @brief HASH context swap register 16
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS16                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR17_DEF
    \
    \ @brief HASH context swap register 17
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS17                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR18_DEF
    \
    \ @brief HASH context swap register 18
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS18                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR19_DEF
    \
    \ @brief HASH context swap register 19
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS19                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR20_DEF
    \
    \ @brief HASH context swap register 20
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS20                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR21_DEF
    \
    \ @brief HASH context swap register 21
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS21                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR22_DEF
    \
    \ @brief HASH context swap register 22
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS22                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR23_DEF
    \
    \ @brief HASH context swap register 23
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS23                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR24_DEF
    \
    \ @brief HASH context swap register 24
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS24                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR25_DEF
    \
    \ @brief HASH context swap register 25
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS25                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR26_DEF
    \
    \ @brief HASH context swap register 26
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS26                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR27_DEF
    \
    \ @brief HASH context swap register 27
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS27                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR28_DEF
    \
    \ @brief HASH context swap register 28
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS28                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR29_DEF
    \
    \ @brief HASH context swap register 29
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS29                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR30_DEF
    \
    \ @brief HASH context swap register 30
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS30                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR31_DEF
    \
    \ @brief HASH context swap register 31
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS31                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR32_DEF
    \
    \ @brief HASH context swap register 32
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS32                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR33_DEF
    \
    \ @brief HASH context swap register 33
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS33                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR34_DEF
    \
    \ @brief HASH context swap register 34
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS34                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR35_DEF
    \
    \ @brief HASH context swap register 35
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS35                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR36_DEF
    \
    \ @brief HASH context swap register 36
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS36                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR37_DEF
    \
    \ @brief HASH context swap register 37
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS37                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR38_DEF
    \
    \ @brief HASH context swap register 38
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS38                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR39_DEF
    \
    \ @brief HASH context swap register 39
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS39                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR40_DEF
    \
    \ @brief HASH context swap register 40
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS40                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR41_DEF
    \
    \ @brief HASH context swap register 41
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS41                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR42_DEF
    \
    \ @brief HASH context swap register 42
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS42                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR43_DEF
    \
    \ @brief HASH context swap register 43
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS43                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR44_DEF
    \
    \ @brief HASH context swap register 44
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS44                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR45_DEF
    \
    \ @brief HASH context swap register 45
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS45                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR46_DEF
    \
    \ @brief HASH context swap register 46
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS46                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR47_DEF
    \
    \ @brief HASH context swap register 47
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS47                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR48_DEF
    \
    \ @brief HASH context swap register 48
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS48                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR49_DEF
    \
    \ @brief HASH context swap register 49
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS49                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR50_DEF
    \
    \ @brief HASH context swap register 50
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS50                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR51_DEF
    \
    \ @brief HASH context swap register 51
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS51                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR52_DEF
    \
    \ @brief HASH context swap register 52
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS52                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_CSR53_DEF
    \
    \ @brief HASH context swap register 53
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS53                      \ [0x00 : 32] Context swap x Refer to Section 25.7.7: HASH context swap registers introduction.
  [then]


  [ifdef] HASH_HASH_HR0_DEF
    \
    \ @brief HASH digest register 0
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H0                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HR1_DEF
    \
    \ @brief HASH digest register 1
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H1                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HR2_DEF
    \
    \ @brief HASH digest register 2
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H2                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HR3_DEF
    \
    \ @brief HASH digest register 3
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H3                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HR4_DEF
    \
    \ @brief HASH digest register 4
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H4                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HR5_DEF
    \
    \ @brief HASH supplementary digest register 5
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H5                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HR6_DEF
    \
    \ @brief HASH supplementary digest register 6
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H6                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]


  [ifdef] HASH_HASH_HR7_DEF
    \
    \ @brief HASH supplementary digest register 7
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H7                        \ [0x00 : 32] Hash data x Refer to Section 25.7.4: HASH digest registers introduction.
  [then]

  \
  \ @brief HASH register block
  \
  $00 constant HASH_HASH_CR             \ HASH control register
  $04 constant HASH_HASH_DIN            \ HASH data input register
  $08 constant HASH_HASH_STR            \ HASH start register
  $0C constant HASH_HASH_HRA0           \ HASH aliased digest register 0
  $10 constant HASH_HASH_HRA1           \ HASH aliased digest register 1
  $14 constant HASH_HASH_HRA2           \ HASH aliased digest register 2
  $18 constant HASH_HASH_HRA3           \ HASH aliased digest register 3
  $1C constant HASH_HASH_HRA4           \ HASH aliased digest register 4
  $20 constant HASH_HASH_IMR            \ HASH interrupt enable register
  $24 constant HASH_HASH_SR             \ HASH status register
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
  $310 constant HASH_HASH_HR0           \ HASH digest register 0
  $314 constant HASH_HASH_HR1           \ HASH digest register 1
  $318 constant HASH_HASH_HR2           \ HASH digest register 2
  $31C constant HASH_HASH_HR3           \ HASH digest register 3
  $320 constant HASH_HASH_HR4           \ HASH digest register 4
  $324 constant HASH_HASH_HR5           \ HASH supplementary digest register 5
  $328 constant HASH_HASH_HR6           \ HASH supplementary digest register 6
  $32C constant HASH_HASH_HR7           \ HASH supplementary digest register 7

: HASH_DEF ; [then]
