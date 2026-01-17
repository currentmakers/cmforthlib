\
\ @file cryp.fs
\ @brief Cryptographic processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRYP_DEF

  [ifdef] CRYP_CRYP_CR_DEF
    \
    \ @brief CRYP control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant CRYP_ALGODIR                   \ [0x02] Algorithm direction This bit selects the algorithm direction. Attempts to write the bitfield are ignored when BUSY is set.
    $03 constant CRYP_ALGOMODE                  \ [0x03 : 3] ALGOMODE[2:0]: Algorithm mode This bitfield selects the AES algorithm/chaining mode. Others: Reserved Attempts to write the bitfield are ignored when BUSY is set.
    $06 constant CRYP_DATATYPE                  \ [0x06 : 2] Data type This bitfield defines the format of data written in the CRYP_DINR register or read from the CRYP_DOUTR register, through selecting the mode of data swapping. This swapping is defined in Section 60.4.15: CRYP data registers and data swapping. Attempts to write the bitfield are ignored when BUSY is set.
    $08 constant CRYP_KEYSIZE                   \ [0x08 : 2] Key size selection This bitfield defines the key length in bits of the key used by CRYP. When KEYSIZE is changed, KEYVALID bit is cleared. Attempts to write the bitfield are ignored when BUSY is set.
    $0e constant CRYP_FFLUSH                    \ [0x0e] FIFO flush This bit enables/disables the flushing of CRYP input and output FIFOs. Reading this bit always returns 0. When CRYPEN is cleared, writing this bit to 1 flushes both input and output FIFOs (that is read and write pointers of the FIFOs are reset). FFLUSH bit must be set when BUSY is cleared, otherwise the FIFO is flushed, but the block being processed may be pushed into the output FIFO just after the flush operation, resulting in a non-empty FIFO condition. Attempts to write FFLUSH are ignored when CRYPEN is set.
    $0f constant CRYP_CRYPEN                    \ [0x0f] CRYP enable This bit enables/disables the CRYP peripheral. This bit is automatically cleared by hardware upon the completion of the key preparation (ALGOMODE[3:0] at 0x7) and upon the completion of GCM/GMAC/CCM initialization phase. The bit cannot be set as long as KEYVALID is cleared.
    $10 constant CRYP_GCM_CCMPH                 \ [0x10 : 2] GCM or CCM phase selection This bitfield selects the phase, applicable only with GCM, GMAC or CCM chaining modes. Attempts to write the bitfield are ignored when BUSY is set.
    $13 constant CRYP_ALGOMODE_1                \ [0x13] ALGOMODE[3]
    $14 constant CRYP_NPBLB                     \ [0x14 : 4] Number of padding bytes in last block This padding information must be filled by software before processing the last block of GCM payload encryption or CCM payload decryption, otherwise authentication tag computation is incorrect. ... Attempts to write the bitfield are ignored when BUSY is set.
    $18 constant CRYP_KMOD                      \ [0x18 : 2] Key mode selection This bitfield defines how the CRYP key can be used by the application. KEYSIZE must be correctly initialized when setting KMOD[1:0] different from zero. Others: Reserved Attempts to write the bitfield are ignored when BUSY is set.
    $1f constant CRYP_IPRST                     \ [0x1f] CRYP peripheral software reset Setting the bit resets the CRYP peripheral, putting all registers to their default values, except the IPRST bit itself. This bit must be kept cleared while writing any configuration registers.
  [then]


  [ifdef] CRYP_CRYP_SR_DEF
    \
    \ @brief CRYP status register
    \ Address offset: 0x04
    \ Reset value: 0x00000003
    \
    $00 constant CRYP_IFEM                      \ [0x00] Input FIFO empty flag
    $01 constant CRYP_IFNF                      \ [0x01] Input FIFO not full flag
    $02 constant CRYP_OFNE                      \ [0x02] Output FIFO not empty flag
    $03 constant CRYP_OFFU                      \ [0x03] Output FIFO full flag
    $04 constant CRYP_BUSY                      \ [0x04] Busy bit This flag indicates whether CRYP is idle or busy. CRYP is flagged as idle when disabled (CRYPEN = 0) or when the AES core is not processing any data. It happens when the last processing has completed, or CRYP is waiting for enough data in the input FIFO or enough free space in the output FIFO (that is in each case at least 4 words). CRYP is flagged as busy when processing a block data, preparing a key (ECB or CBC decryption only), or transferring a shared key from SAES peripheral.
    $06 constant CRYP_KERF                      \ [0x06] Key error flag This read-only bit is set by hardware when key information failed to load into key registers. KERF is triggered upon any of the following errors: CRYP_KxR/LR register write does not respect the correct order (refer to Section 60.4.16: CRYP key registers for details). CRYP fails to load the key shared by SAES peripheral (KMOD = 0x2). KERF must be cleared by the application software, otherwise KEYVALID cannot be set. It can be done through IPRST bit of CRYP_CR, or when a correct key writing sequence starts.
    $07 constant CRYP_KEYVALID                  \ [0x07] Key valid flag This read-only bit is set by hardware when the key of size defined by KEYSIZE is loaded in CRYP_KxR/LR key registers. The CRYPEN bit can only be set when KEYVALID is set. In normal mode when KMOD[1:0] is at zero, the key must be written in the key registers in the correct sequence, otherwise the KERF flag is set and KEYVALID remains cleared. When KMOD[1:0] is different from zero, the BUSY flag is automatically set by CRYP. When the key is loaded successfully, BUSY is cleared and KEYVALID set. Upon an error, KERF is set, BUSY cleared and KEYVALID remains cleared. If set, KERF must be cleared, otherwise KEYVALID cannot be set. For further information on key loading, refer to Section 60.4.16: CRYP key registers.
  [then]


  [ifdef] CRYP_CRYP_DINR_DEF
    \
    \ @brief CRYP data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DIN                       \ [0x00 : 32] Data input A four-fold sequential write to this bitfield during the Input phase results in pushing a complete 16-byte block into the CRYP input FIFO. From the first to the fourth write, the corresponding data weights are [127:96], [95:64], [63:32], and [31:0]. Input FIFO can receive up to two 16-byte blocks of plaintext (when encrypting) or ciphertext (when decrypting). If EN bit is set in CRYP_CR register, when at least four 32-bit words have been pushed into the input FIFO, and when at least four 32-bit words are free in the output FIFO, the CRYP automatically starts an encryption or decryption process, setting the BUSY bit. Reading this register pops data off the input FIFO (oldest value is returned). The data present in the input FIFO are returned only if CRYPEN is cleared (undefined value is returned otherwise). Following one or more reads the FIFO must be flushed (setting the FFLUSH bit) prior to processing new data.
  [then]


  [ifdef] CRYP_CRYP_DOUTR_DEF
    \
    \ @brief CRYP data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DOUT                      \ [0x00 : 32] Data output A four-fold sequential read to this bitfield during the output phase results in retrieving a complete 16-byte block from the CRYP output FIFO. From the first to the fourth read, the corresponding data weights are [127:96], [95:64], [63:32], and [31:0]. Output FIFO can store up to two 16-byte blocks of plaintext (when decrypting) or ciphertext (when encrypting). When the output FIFO is empty a read returns an undefined value. Writes are ignored.
  [then]


  [ifdef] CRYP_CRYP_DMACR_DEF
    \
    \ @brief CRYP DMA control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DIEN                      \ [0x00] DMA input enable When this bit is set, DMA requests are automatically generated by the peripheral during the input data phase.
    $01 constant CRYP_DOEN                      \ [0x01] DMA output enable When this bit is set, DMA requests are automatically generated by the peripheral during the output data phase.
  [then]


  [ifdef] CRYP_CRYP_IMSCR_DEF
    \
    \ @brief CRYP interrupt mask set/clear register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INIM                      \ [0x00] Input FIFO service interrupt mask This bit enables or disables (masks) the CRYP input FIFO service interrupt generation when INRIS is set.
    $01 constant CRYP_OUTIM                     \ [0x01] Output FIFO service interrupt mask This bit enables or disables (masks) the CRYP output FIFO service interrupt generation when OUTRIS is set.
  [then]


  [ifdef] CRYP_CRYP_RISR_DEF
    \
    \ @brief CRYP raw interrupt status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant CRYP_INRIS                     \ [0x00] Input FIFO service raw interrupt status This read-only bit is set by hardware when an input FIFO flag (IFNF or IFEM) is set in CRYP_SR register, regardless of the INIM mask bit value in CRYP_IMSCR register.
    $01 constant CRYP_OUTRIS                    \ [0x01] Output FIFO service raw interrupt status This read-only bit is set by hardware when an output FIFO flag (OFFU or OFNE) is set in CRYP_SR register, regardless of the OUTIM mask bit value in CRYP_IMSCR register.
  [then]


  [ifdef] CRYP_CRYP_MISR_DEF
    \
    \ @brief CRYP masked interrupt status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INMIS                     \ [0x00] Input FIFO service masked interrupt status This read-only bit is set by hardware when an input FIFO flag (IFNF or IFEM) is set in CRYP_SR register. If the INIM mask bit is cleared in CRYP_IMSCR register, the INMIS bit stays cleared (masked). The INMIS bit is cleared by writing data to the input FIFO until IFEM flag is cleared (there is at least one word in input FIFO), or by clearing CRYPEN, When CRYP is disabled, INMIS bit stays low even if the input FIFO is empty.
    $01 constant CRYP_OUTMIS                    \ [0x01] Output FIFO service masked interrupt status This read-only bit is set by hardware when an output FIFO flag (OFFU or OFNE) is set in CRYP_SR register. If the OUTIM mask bit is cleared in CRYP_IMSCR register, the OUTMIS bit stays cleared (masked). The OUTMIS bit is cleared by reading data from the output FIFO until OFNE flag is cleared (output FIFO empty). It is not cleared by disabling CRYP with CRYPEN bit.
  [then]


  [ifdef] CRYP_CRYP_K0LR_DEF
    \
    \ @brief CRYP key register 0L
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x This write-only bitfield contains the bits [255:224] of the AES encryption or decryption key, depending on the operating mode. Write to CRYP_KxR/LR registers is ignored when CRYP is busy (BUSY bit set). When key is coming from the SAES peripheral (KMOD[1:0] = 0x2), write is also ignored. With KMOD[1:0] at 0x0, a special writing sequence is required. In this sequence, any valid write to CRYP_KxR/LR register clears the KEYVALID flag except for the sequence-completing write that sets it. Also refer to the description of the KEYVALID flag in the CRYP_SR register.
  [then]


  [ifdef] CRYP_CRYP_K0RR_DEF
    \
    \ @brief CRYP key register 0R
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x This write-only bitfield contains the bits [223:192] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.
  [then]


  [ifdef] CRYP_CRYP_K1LR_DEF
    \
    \ @brief CRYP key register 1L
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x This write-only bitfield contains the bits [191:160] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.
  [then]


  [ifdef] CRYP_CRYP_K1RR_DEF
    \
    \ @brief CRYP key register 1R
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x This write-only bitfield contains the bits [159:128] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.
  [then]


  [ifdef] CRYP_CRYP_K2LR_DEF
    \
    \ @brief CRYP key register 2L
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x This write-only bitfield contains the bits [127:96] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.
  [then]


  [ifdef] CRYP_CRYP_K2RR_DEF
    \
    \ @brief CRYP key register 2R
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x This write-only bitfield contains the bits [95:64] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.
  [then]


  [ifdef] CRYP_CRYP_K3LR_DEF
    \
    \ @brief CRYP key register 3L
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x This write-only bitfield contains the bits [63:32] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.
  [then]


  [ifdef] CRYP_CRYP_K3RR_DEF
    \
    \ @brief CRYP key register 3R
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x This write-only bitfield contains the bits [31:0] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.
  [then]


  [ifdef] CRYP_CRYP_IV0LR_DEF
    \
    \ @brief CRYP initialization vector register 0L
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVI                       \ [0x00 : 32] Initialization vector bit x This bitfield stores the initialization vector bits [127:96] for AES chaining modes other than ECB. The value stored in CRYP_IVxR/LR registers is updated by hardware after each computation round (when applicable). Write to this register is ignored when CRYP is busy (BUSY bit set).
  [then]


  [ifdef] CRYP_CRYP_IV0RR_DEF
    \
    \ @brief CRYP initialization vector register 0R
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVI                       \ [0x00 : 32] Initialization vector bit x This bitfield stores the initialization vector bits [95:64] for AES chaining modes other than ECB. The value stored in CRYP_IVxR/LR registers is updated by hardware after each computation round (when applicable). Write to this register is ignored when CRYP is busy (BUSY bit set).
  [then]


  [ifdef] CRYP_CRYP_IV1LR_DEF
    \
    \ @brief CRYP initialization vector register 1L
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVI                       \ [0x00 : 32] Initialization vector bit x This bitfield stores the initialization vector bits [63:32] for AES chaining modes other than ECB. The value stored in CRYP_IVxR/LR registers is updated by hardware after each computation round (when applicable). Write to this register is ignored when CRYP is busy (BUSY bit set).
  [then]


  [ifdef] CRYP_CRYP_IV1RR_DEF
    \
    \ @brief CRYP initialization vector register 1R
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVI                       \ [0x00 : 32] Initialization vector bit x This bitfield stores the initialization vector bits [31:0] for AES chaining modes other than ECB. The value stored in CRYP_IVxR/LR registers is updated by hardware after each computation round (when applicable). Write to this register is ignored when CRYP is busy (BUSY bit set).
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM0R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM1R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM2R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM3R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM4R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM5R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM6R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM7R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] CRYP_CRYP_CSGCM0R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.
  [then]


  [ifdef] CRYP_CRYP_CSGCM1R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.
  [then]


  [ifdef] CRYP_CRYP_CSGCM2R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.
  [then]


  [ifdef] CRYP_CRYP_CSGCM3R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.
  [then]


  [ifdef] CRYP_CRYP_CSGCM4R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.
  [then]


  [ifdef] CRYP_CRYP_CSGCM5R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.
  [then]


  [ifdef] CRYP_CRYP_CSGCM6R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.
  [then]


  [ifdef] CRYP_CRYP_CSGCM7R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.
  [then]

  \
  \ @brief Cryptographic processor
  \
  $00 constant CRYP_CRYP_CR             \ CRYP control register
  $04 constant CRYP_CRYP_SR             \ CRYP status register
  $08 constant CRYP_CRYP_DINR           \ CRYP data input register
  $0C constant CRYP_CRYP_DOUTR          \ CRYP data output register
  $10 constant CRYP_CRYP_DMACR          \ CRYP DMA control register
  $14 constant CRYP_CRYP_IMSCR          \ CRYP interrupt mask set/clear register
  $18 constant CRYP_CRYP_RISR           \ CRYP raw interrupt status register
  $1C constant CRYP_CRYP_MISR           \ CRYP masked interrupt status register
  $20 constant CRYP_CRYP_K0LR           \ CRYP key register 0L
  $24 constant CRYP_CRYP_K0RR           \ CRYP key register 0R
  $28 constant CRYP_CRYP_K1LR           \ CRYP key register 1L
  $2C constant CRYP_CRYP_K1RR           \ CRYP key register 1R
  $30 constant CRYP_CRYP_K2LR           \ CRYP key register 2L
  $34 constant CRYP_CRYP_K2RR           \ CRYP key register 2R
  $38 constant CRYP_CRYP_K3LR           \ CRYP key register 3L
  $3C constant CRYP_CRYP_K3RR           \ CRYP key register 3R
  $40 constant CRYP_CRYP_IV0LR          \ CRYP initialization vector register 0L
  $44 constant CRYP_CRYP_IV0RR          \ CRYP initialization vector register 0R
  $48 constant CRYP_CRYP_IV1LR          \ CRYP initialization vector register 1L
  $4C constant CRYP_CRYP_IV1RR          \ CRYP initialization vector register 1R
  $50 constant CRYP_CRYP_CSGCMCCM0R     \ CRYP context swap GCM-CCM registers
  $54 constant CRYP_CRYP_CSGCMCCM1R     \ CRYP context swap GCM-CCM registers
  $58 constant CRYP_CRYP_CSGCMCCM2R     \ CRYP context swap GCM-CCM registers
  $5C constant CRYP_CRYP_CSGCMCCM3R     \ CRYP context swap GCM-CCM registers
  $60 constant CRYP_CRYP_CSGCMCCM4R     \ CRYP context swap GCM-CCM registers
  $64 constant CRYP_CRYP_CSGCMCCM5R     \ CRYP context swap GCM-CCM registers
  $68 constant CRYP_CRYP_CSGCMCCM6R     \ CRYP context swap GCM-CCM registers
  $6C constant CRYP_CRYP_CSGCMCCM7R     \ CRYP context swap GCM-CCM registers
  $70 constant CRYP_CRYP_CSGCM0R        \ CRYP context swap GCM registers
  $74 constant CRYP_CRYP_CSGCM1R        \ CRYP context swap GCM registers
  $78 constant CRYP_CRYP_CSGCM2R        \ CRYP context swap GCM registers
  $7C constant CRYP_CRYP_CSGCM3R        \ CRYP context swap GCM registers
  $80 constant CRYP_CRYP_CSGCM4R        \ CRYP context swap GCM registers
  $84 constant CRYP_CRYP_CSGCM5R        \ CRYP context swap GCM registers
  $88 constant CRYP_CRYP_CSGCM6R        \ CRYP context swap GCM registers
  $8C constant CRYP_CRYP_CSGCM7R        \ CRYP context swap GCM registers

: CRYP_DEF ; [then]
