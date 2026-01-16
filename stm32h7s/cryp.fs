\
\ @file cryp.fs
\ @brief Cryptographic processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CRYP control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant CRYP_CRYP_CR_ALGODIR                             \ Algorithm direction This bit selects the algorithm direction. Attempts to write the bitfield are ignored when BUSY is set.
$00000038 constant CRYP_CRYP_CR_ALGOMODE                            \ ALGOMODE[2:0]: Algorithm mode This bitfield selects the AES algorithm/chaining mode. Others: Reserved Attempts to write the bitfield are ignored when BUSY is set.
$000000c0 constant CRYP_CRYP_CR_DATATYPE                            \ Data type This bitfield defines the format of data written in the CRYP_DINR register or read from the CRYP_DOUTR register, through selecting the mode of data swapping. This swapping is defined in Section 60.4.15: CRYP data registers and data swapping. Attempts to write the bitfield are ignored when BUSY is set.
$00000300 constant CRYP_CRYP_CR_KEYSIZE                             \ Key size selection This bitfield defines the key length in bits of the key used by CRYP. When KEYSIZE is changed, KEYVALID bit is cleared. Attempts to write the bitfield are ignored when BUSY is set.
$00004000 constant CRYP_CRYP_CR_FFLUSH                              \ FIFO flush This bit enables/disables the flushing of CRYP input and output FIFOs. Reading this bit always returns 0. When CRYPEN is cleared, writing this bit to 1 flushes both input and output FIFOs (that is read and write pointers of the FIFOs are reset). FFLUSH bit must be set when BUSY is cleared, otherwise the FIFO is flushed, but the block being processed may be pushed into the output FIFO just after the flush operation, resulting in a non-empty FIFO condition. Attempts to write FFLUSH are ignored when CRYPEN is set.
$00008000 constant CRYP_CRYP_CR_CRYPEN                              \ CRYP enable This bit enables/disables the CRYP peripheral. This bit is automatically cleared by hardware upon the completion of the key preparation (ALGOMODE[3:0] at 0x7) and upon the completion of GCM/GMAC/CCM initialization phase. The bit cannot be set as long as KEYVALID is cleared.
$00030000 constant CRYP_CRYP_CR_GCM_CCMPH                           \ GCM or CCM phase selection This bitfield selects the phase, applicable only with GCM, GMAC or CCM chaining modes. Attempts to write the bitfield are ignored when BUSY is set.
$00080000 constant CRYP_CRYP_CR_ALGOMODE_1                          \ ALGOMODE[3]
$00f00000 constant CRYP_CRYP_CR_NPBLB                               \ Number of padding bytes in last block This padding information must be filled by software before processing the last block of GCM payload encryption or CCM payload decryption, otherwise authentication tag computation is incorrect. ... Attempts to write the bitfield are ignored when BUSY is set.
$03000000 constant CRYP_CRYP_CR_KMOD                                \ Key mode selection This bitfield defines how the CRYP key can be used by the application. KEYSIZE must be correctly initialized when setting KMOD[1:0] different from zero. Others: Reserved Attempts to write the bitfield are ignored when BUSY is set.
$80000000 constant CRYP_CRYP_CR_IPRST                               \ CRYP peripheral software reset Setting the bit resets the CRYP peripheral, putting all registers to their default values, except the IPRST bit itself. This bit must be kept cleared while writing any configuration registers.


\
\ @brief CRYP status register
\ Address offset: 0x04
\ Reset value: 0x00000003
\

$00000001 constant CRYP_CRYP_SR_IFEM                                \ Input FIFO empty flag
$00000002 constant CRYP_CRYP_SR_IFNF                                \ Input FIFO not full flag
$00000004 constant CRYP_CRYP_SR_OFNE                                \ Output FIFO not empty flag
$00000008 constant CRYP_CRYP_SR_OFFU                                \ Output FIFO full flag
$00000010 constant CRYP_CRYP_SR_BUSY                                \ Busy bit This flag indicates whether CRYP is idle or busy. CRYP is flagged as idle when disabled (CRYPEN = 0) or when the AES core is not processing any data. It happens when the last processing has completed, or CRYP is waiting for enough data in the input FIFO or enough free space in the output FIFO (that is in each case at least 4 words). CRYP is flagged as busy when processing a block data, preparing a key (ECB or CBC decryption only), or transferring a shared key from SAES peripheral.
$00000040 constant CRYP_CRYP_SR_KERF                                \ Key error flag This read-only bit is set by hardware when key information failed to load into key registers. KERF is triggered upon any of the following errors: CRYP_KxR/LR register write does not respect the correct order (refer to Section 60.4.16: CRYP key registers for details). CRYP fails to load the key shared by SAES peripheral (KMOD = 0x2). KERF must be cleared by the application software, otherwise KEYVALID cannot be set. It can be done through IPRST bit of CRYP_CR, or when a correct key writing sequence starts.
$00000080 constant CRYP_CRYP_SR_KEYVALID                            \ Key valid flag This read-only bit is set by hardware when the key of size defined by KEYSIZE is loaded in CRYP_KxR/LR key registers. The CRYPEN bit can only be set when KEYVALID is set. In normal mode when KMOD[1:0] is at zero, the key must be written in the key registers in the correct sequence, otherwise the KERF flag is set and KEYVALID remains cleared. When KMOD[1:0] is different from zero, the BUSY flag is automatically set by CRYP. When the key is loaded successfully, BUSY is cleared and KEYVALID set. Upon an error, KERF is set, BUSY cleared and KEYVALID remains cleared. If set, KERF must be cleared, otherwise KEYVALID cannot be set. For further information on key loading, refer to Section 60.4.16: CRYP key registers.


\
\ @brief CRYP data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_DINR_DIN                               \ Data input A four-fold sequential write to this bitfield during the Input phase results in pushing a complete 16-byte block into the CRYP input FIFO. From the first to the fourth write, the corresponding data weights are [127:96], [95:64], [63:32], and [31:0]. Input FIFO can receive up to two 16-byte blocks of plaintext (when encrypting) or ciphertext (when decrypting). If EN bit is set in CRYP_CR register, when at least four 32-bit words have been pushed into the input FIFO, and when at least four 32-bit words are free in the output FIFO, the CRYP automatically starts an encryption or decryption process, setting the BUSY bit. Reading this register pops data off the input FIFO (oldest value is returned). The data present in the input FIFO are returned only if CRYPEN is cleared (undefined value is returned otherwise). Following one or more reads the FIFO must be flushed (setting the FFLUSH bit) prior to processing new data.


\
\ @brief CRYP data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_DOUTR_DOUT                             \ Data output A four-fold sequential read to this bitfield during the output phase results in retrieving a complete 16-byte block from the CRYP output FIFO. From the first to the fourth read, the corresponding data weights are [127:96], [95:64], [63:32], and [31:0]. Output FIFO can store up to two 16-byte blocks of plaintext (when decrypting) or ciphertext (when encrypting). When the output FIFO is empty a read returns an undefined value. Writes are ignored.


\
\ @brief CRYP DMA control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CRYP_CRYP_DMACR_DIEN                             \ DMA input enable When this bit is set, DMA requests are automatically generated by the peripheral during the input data phase.
$00000002 constant CRYP_CRYP_DMACR_DOEN                             \ DMA output enable When this bit is set, DMA requests are automatically generated by the peripheral during the output data phase.


\
\ @brief CRYP interrupt mask set/clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CRYP_CRYP_IMSCR_INIM                             \ Input FIFO service interrupt mask This bit enables or disables (masks) the CRYP input FIFO service interrupt generation when INRIS is set.
$00000002 constant CRYP_CRYP_IMSCR_OUTIM                            \ Output FIFO service interrupt mask This bit enables or disables (masks) the CRYP output FIFO service interrupt generation when OUTRIS is set.


\
\ @brief CRYP raw interrupt status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant CRYP_CRYP_RISR_INRIS                             \ Input FIFO service raw interrupt status This read-only bit is set by hardware when an input FIFO flag (IFNF or IFEM) is set in CRYP_SR register, regardless of the INIM mask bit value in CRYP_IMSCR register.
$00000002 constant CRYP_CRYP_RISR_OUTRIS                            \ Output FIFO service raw interrupt status This read-only bit is set by hardware when an output FIFO flag (OFFU or OFNE) is set in CRYP_SR register, regardless of the OUTIM mask bit value in CRYP_IMSCR register.


\
\ @brief CRYP masked interrupt status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant CRYP_CRYP_MISR_INMIS                             \ Input FIFO service masked interrupt status This read-only bit is set by hardware when an input FIFO flag (IFNF or IFEM) is set in CRYP_SR register. If the INIM mask bit is cleared in CRYP_IMSCR register, the INMIS bit stays cleared (masked). The INMIS bit is cleared by writing data to the input FIFO until IFEM flag is cleared (there is at least one word in input FIFO), or by clearing CRYPEN, When CRYP is disabled, INMIS bit stays low even if the input FIFO is empty.
$00000002 constant CRYP_CRYP_MISR_OUTMIS                            \ Output FIFO service masked interrupt status This read-only bit is set by hardware when an output FIFO flag (OFFU or OFNE) is set in CRYP_SR register. If the OUTIM mask bit is cleared in CRYP_IMSCR register, the OUTMIS bit stays cleared (masked). The OUTMIS bit is cleared by reading data from the output FIFO until OFNE flag is cleared (output FIFO empty). It is not cleared by disabling CRYP with CRYPEN bit.


\
\ @brief CRYP key register 0L
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K0LR_K                                 \ Key bit x This write-only bitfield contains the bits [255:224] of the AES encryption or decryption key, depending on the operating mode. Write to CRYP_KxR/LR registers is ignored when CRYP is busy (BUSY bit set). When key is coming from the SAES peripheral (KMOD[1:0] = 0x2), write is also ignored. With KMOD[1:0] at 0x0, a special writing sequence is required. In this sequence, any valid write to CRYP_KxR/LR register clears the KEYVALID flag except for the sequence-completing write that sets it. Also refer to the description of the KEYVALID flag in the CRYP_SR register.


\
\ @brief CRYP key register 0R
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K0RR_K                                 \ Key bit x This write-only bitfield contains the bits [223:192] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.


\
\ @brief CRYP key register 1L
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K1LR_K                                 \ Key bit x This write-only bitfield contains the bits [191:160] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.


\
\ @brief CRYP key register 1R
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K1RR_K                                 \ Key bit x This write-only bitfield contains the bits [159:128] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.


\
\ @brief CRYP key register 2L
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K2LR_K                                 \ Key bit x This write-only bitfield contains the bits [127:96] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.


\
\ @brief CRYP key register 2R
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K2RR_K                                 \ Key bit x This write-only bitfield contains the bits [95:64] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.


\
\ @brief CRYP key register 3L
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K3LR_K                                 \ Key bit x This write-only bitfield contains the bits [63:32] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.


\
\ @brief CRYP key register 3R
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_K3RR_K                                 \ Key bit x This write-only bitfield contains the bits [31:0] of the AES encryption or decryption key, depending on the operating mode. Refer to the CRYP_K0LR register for information relative to writing CRYP_KxR/LR registers.


\
\ @brief CRYP initialization vector register 0L
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_IV0LR_IVI                              \ Initialization vector bit x This bitfield stores the initialization vector bits [127:96] for AES chaining modes other than ECB. The value stored in CRYP_IVxR/LR registers is updated by hardware after each computation round (when applicable). Write to this register is ignored when CRYP is busy (BUSY bit set).


\
\ @brief CRYP initialization vector register 0R
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_IV0RR_IVI                              \ Initialization vector bit x This bitfield stores the initialization vector bits [95:64] for AES chaining modes other than ECB. The value stored in CRYP_IVxR/LR registers is updated by hardware after each computation round (when applicable). Write to this register is ignored when CRYP is busy (BUSY bit set).


\
\ @brief CRYP initialization vector register 1L
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_IV1LR_IVI                              \ Initialization vector bit x This bitfield stores the initialization vector bits [63:32] for AES chaining modes other than ECB. The value stored in CRYP_IVxR/LR registers is updated by hardware after each computation round (when applicable). Write to this register is ignored when CRYP is busy (BUSY bit set).


\
\ @brief CRYP initialization vector register 1R
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_IV1RR_IVI                              \ Initialization vector bit x This bitfield stores the initialization vector bits [31:0] for AES chaining modes other than ECB. The value stored in CRYP_IVxR/LR registers is updated by hardware after each computation round (when applicable). Write to this register is ignored when CRYP is busy (BUSY bit set).


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM0R_CSGCMCCM                    \ Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM1R_CSGCMCCM                    \ Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM2R_CSGCMCCM                    \ Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM3R_CSGCMCCM                    \ Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM4R_CSGCMCCM                    \ Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM5R_CSGCMCCM                    \ Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM6R_CSGCMCCM                    \ Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCMCCM7R_CSGCMCCM                    \ Context swap for GCM/GMAC and CCM modes CRYP_CSGCMCCMxR registers contain the complete internal register states of the CRYP when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMCCMxR registers are not used in other chaining modes than GCM, GMAC or CCM.


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM0R_CSGCM                          \ Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM1R_CSGCM                          \ Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM2R_CSGCM                          \ Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM3R_CSGCM                          \ Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM4R_CSGCM                          \ Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM5R_CSGCM                          \ Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM6R_CSGCM                          \ Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CRYP_CSGCM7R_CSGCM                          \ Context swap for GCM/GMAC modes CRYP_CSGCMxR registers contain the complete internal register states of the CRYP when the GCM or GMAC processing of the current task is suspended to process a higher-priority task. Refer to Section 60.4.8: CRYP suspend and resume operations for more details. CRYP_CSGCMxR registers are not used in other chaining modes than GCM or GMAC.


\
\ @brief Cryptographic processor
\
$48020800 constant CRYP_CRYP_CR   \ offset: 0x00 : CRYP control register
$48020804 constant CRYP_CRYP_SR   \ offset: 0x04 : CRYP status register
$48020808 constant CRYP_CRYP_DINR  \ offset: 0x08 : CRYP data input register
$4802080c constant CRYP_CRYP_DOUTR  \ offset: 0x0C : CRYP data output register
$48020810 constant CRYP_CRYP_DMACR  \ offset: 0x10 : CRYP DMA control register
$48020814 constant CRYP_CRYP_IMSCR  \ offset: 0x14 : CRYP interrupt mask set/clear register
$48020818 constant CRYP_CRYP_RISR  \ offset: 0x18 : CRYP raw interrupt status register
$4802081c constant CRYP_CRYP_MISR  \ offset: 0x1C : CRYP masked interrupt status register
$48020820 constant CRYP_CRYP_K0LR  \ offset: 0x20 : CRYP key register 0L
$48020824 constant CRYP_CRYP_K0RR  \ offset: 0x24 : CRYP key register 0R
$48020828 constant CRYP_CRYP_K1LR  \ offset: 0x28 : CRYP key register 1L
$4802082c constant CRYP_CRYP_K1RR  \ offset: 0x2C : CRYP key register 1R
$48020830 constant CRYP_CRYP_K2LR  \ offset: 0x30 : CRYP key register 2L
$48020834 constant CRYP_CRYP_K2RR  \ offset: 0x34 : CRYP key register 2R
$48020838 constant CRYP_CRYP_K3LR  \ offset: 0x38 : CRYP key register 3L
$4802083c constant CRYP_CRYP_K3RR  \ offset: 0x3C : CRYP key register 3R
$48020840 constant CRYP_CRYP_IV0LR  \ offset: 0x40 : CRYP initialization vector register 0L
$48020844 constant CRYP_CRYP_IV0RR  \ offset: 0x44 : CRYP initialization vector register 0R
$48020848 constant CRYP_CRYP_IV1LR  \ offset: 0x48 : CRYP initialization vector register 1L
$4802084c constant CRYP_CRYP_IV1RR  \ offset: 0x4C : CRYP initialization vector register 1R
$48020850 constant CRYP_CRYP_CSGCMCCM0R  \ offset: 0x50 : CRYP context swap GCM-CCM registers
$48020854 constant CRYP_CRYP_CSGCMCCM1R  \ offset: 0x54 : CRYP context swap GCM-CCM registers
$48020858 constant CRYP_CRYP_CSGCMCCM2R  \ offset: 0x58 : CRYP context swap GCM-CCM registers
$4802085c constant CRYP_CRYP_CSGCMCCM3R  \ offset: 0x5C : CRYP context swap GCM-CCM registers
$48020860 constant CRYP_CRYP_CSGCMCCM4R  \ offset: 0x60 : CRYP context swap GCM-CCM registers
$48020864 constant CRYP_CRYP_CSGCMCCM5R  \ offset: 0x64 : CRYP context swap GCM-CCM registers
$48020868 constant CRYP_CRYP_CSGCMCCM6R  \ offset: 0x68 : CRYP context swap GCM-CCM registers
$4802086c constant CRYP_CRYP_CSGCMCCM7R  \ offset: 0x6C : CRYP context swap GCM-CCM registers
$48020870 constant CRYP_CRYP_CSGCM0R  \ offset: 0x70 : CRYP context swap GCM registers
$48020874 constant CRYP_CRYP_CSGCM1R  \ offset: 0x74 : CRYP context swap GCM registers
$48020878 constant CRYP_CRYP_CSGCM2R  \ offset: 0x78 : CRYP context swap GCM registers
$4802087c constant CRYP_CRYP_CSGCM3R  \ offset: 0x7C : CRYP context swap GCM registers
$48020880 constant CRYP_CRYP_CSGCM4R  \ offset: 0x80 : CRYP context swap GCM registers
$48020884 constant CRYP_CRYP_CSGCM5R  \ offset: 0x84 : CRYP context swap GCM registers
$48020888 constant CRYP_CRYP_CSGCM6R  \ offset: 0x88 : CRYP context swap GCM registers
$4802088c constant CRYP_CRYP_CSGCM7R  \ offset: 0x8C : CRYP context swap GCM registers

