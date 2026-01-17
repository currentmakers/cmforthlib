\
\ @file aes.fs
\ @brief AES register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] AES_DEF

  [ifdef] AES_AES_CR_DEF
    \
    \ @brief AES control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant AES_EN                         \ [0x00] Enable This bit enables/disables the AES peripheral. At any moment, clearing then setting the bit re-initializes the AES peripheral. This bit is automatically cleared by hardware upon the completion of the key preparation (MODE[1:0] at 0x1) and upon the completion of GCM/GMAC/CCM initialization phase. The bit cannot be set as long as KEYVALID1is cleared
    $01 constant AES_DATATYPE                   \ [0x01 : 2] Data type This bitfield defines the format of data written in the AES_DINR register or read from the AES_DOUTR register, through selecting the mode of data swapping. This swapping is defined in Section121.4.14: AES data registers and data swapping. Attempts to write the bitfield are ignored when EN is set before the write access and it is not cleared by that write access.
    $03 constant AES_MODE                       \ [0x03 : 2] Operating mode This bitfield selects the AES operating mode: Attempts to write the bitfield are ignored when EN is set before the write access and it is not cleared by that write access.
    $05 constant AES_CHMOD                      \ [0x05 : 2] CHMOD[1:0]: Chaining mode This bitfield selects the AES chaining mode: others: Reserved Attempts to write the bitfield are ignored when EN is set before the write access and it is not cleared by that write access.
    $0b constant AES_DMAINEN                    \ [0x0b] DMA input enable This bit enables automatic generation of DMA requests during the data phase, for incoming data transfers to AES via DMA. Setting this bit is ignored when MODE[1:0] is at 0x1 (key derivation).
    $0c constant AES_DMAOUTEN                   \ [0x0c] DMA output enable This bit enables automatic generation of DMA requests during the data phase, for outgoing data transfers from AES via DMA. Setting this bit is ignored when MODE[1:0] is at 0x1 (key derivation).
    $0d constant AES_GCMPH                      \ [0x0d : 2] GCM or CCM phase selection This bitfield selects the phase, applicable only with GCM, GMAC or CCM chaining modes.
    $10 constant AES_CHMOD_1                    \ [0x10] CHMOD[2]
    $12 constant AES_KEYSIZE                    \ [0x12] Key size selection This bitfield defines the key length in bits of the key used by AES. Attempts to write the bit are ignored when the EN is set before the write access and it is not cleared by that write access.
    $14 constant AES_NPBLB                      \ [0x14 : 4] Number of padding bytes in last block This padding information must be filled by software before processing the last block of GCM payload encryption or CCM payload decryption, otherwise authentication tag computation is incorrect. ...
    $1f constant AES_IPRST                      \ [0x1f] AES peripheral software reset Setting the bit resets the AES peripheral, putting all registers to their default values, except the IPRST bit itself. Hence, any key-relative data are lost. For this reason, it is recommended to set the bit before handing over the AES to a less secure application. The bit must be kept low while writing any configuration registers.
  [then]


  [ifdef] AES_AES_SR_DEF
    \
    \ @brief AES status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant AES_RDERRF                     \ [0x01] Read error flag This bit is set when an unexpected read to the AES_DOUTR register occurred. When set RDERRF bit has no impact on the AES operations. The flag setting generates an interrupt if the RWEIE bit of the AES_IER register is set. The flag is cleared by setting the RWEIF bit of the AES_ICR register.
    $02 constant AES_WRERRF                     \ [0x02] Write error flag This bit is set when an unexpected write to the AES_DINR register occurred. When set WRERRF bit has no impact on the AES operations. The flag setting generates an interrupt if the RWEIE bit of the AES_IER register is set. The flag is cleared by setting the RWEIF bit of the AES_ICR register.
    $03 constant AES_BUSY                       \ [0x03] Busy This flag indicates whether AES is idle or busy. AES is flagged as idle when disabled (when EN is low) or when the last processing is completed. AES is flagged as busy when processing a block data, preparing a key (ECB or CBC decryption only). When GCM encryption is selected, this flag must be at zero before suspending current process to manage a higher-priority message.
    $07 constant AES_KEYVALID                   \ [0x07] Key valid flag This bit is set by hardware when the key of size defined by KEYSIZE is loaded in AES_KEYRx key registers. The EN bit can only be set when KEYVALID is set. The key must be written in the key registers in the correct sequence, otherwise the KEIF flag is set and KEYVALID remains cleared. If set, KEIF must be cleared through the AES_ICR register, otherwise KEYVALID cannot be set. See the KEIF flag description for more details. For further information on key loading, refer to Section121.4.15: AES key registers.
  [then]


  [ifdef] AES_AES_DINR_DEF
    \
    \ @brief AES data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant AES_DIN                        \ [0x00 : 32] Data input A four-fold sequential write to this bitfield during the Input phase results in writing a complete 16-bytes block of input data to the AES peripheral. From the first to the fourth write, the corresponding data weights are [127:96], [95:64], [63:32], and [31:0]. Upon each write, the data from the 32-bit input buffer are handled by the data swap block according to the DATATYPE[1:0] bitfield, then written into the AES core 16-bytes input buffer. Reads return zero.
  [then]


  [ifdef] AES_AES_DOUTR_DEF
    \
    \ @brief AES data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant AES_DOUT                       \ [0x00 : 32] Data output This read-only bitfield fetches a 32-bit output buffer. A four-fold sequential read of this bitfield, upon the computation completion (CCF flag set), virtually reads a complete 16-byte block of output data from the AES peripheral. Before reaching the output buffer, the data produced by the AES core are handled by the data swap block according to the DATATYPE[1:0] bitfield. Data weights from the first to the fourth read operation are: [127:96], [95:64], [63:32], and [31:0].
  [then]


  [ifdef] AES_AES_KEYR0_DEF
    \
    \ @brief AES key register 0
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [31:0] These are bits [31:0] of the write-only bitfield KEY[255:0] AES encryption or decryption key, depending on the MODE[1:0] bitfield of the AES_CR register. Writes to AES_KEYRx registers are ignored when AES is enabled (EN bit set). A special writing sequence is required. In this sequence, any valid write to AES_KEYRx register clears the KEYVALID flag except for the sequence-completing write that sets it. Also refer to the description of the KEYVALID flag in the AES_SR register.
  [then]


  [ifdef] AES_AES_KEYR1_DEF
    \
    \ @brief AES key register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [63:32] Refer to the AES_KEYR0 register for description of the KEY[255:0] bitfield and for information relative to writing AES_KEYRx registers.
  [then]


  [ifdef] AES_AES_KEYR2_DEF
    \
    \ @brief AES key register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [95:64] Refer to the AES_KEYR0 register for description of the KEY[255:0] bitfield and for information relative to writing AES_KEYRx registers.
  [then]


  [ifdef] AES_AES_KEYR3_DEF
    \
    \ @brief AES key register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [127:96] Refer to the AES_KEYR0 register for description of the KEY[255:0] bitfield and for information relative to writing AES_KEYRx registers.
  [then]


  [ifdef] AES_AES_IVR0_DEF
    \
    \ @brief AES initialization vector register 0
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [31:0] AES_IVRx registers store the 128-bit initialization vector or the nonce, depending on the chaining mode selected. This value is updated by hardware after each computation round (when applicable). Write to this register is ignored when EN bit is set in AES_SR register
  [then]


  [ifdef] AES_AES_IVR1_DEF
    \
    \ @brief AES initialization vector register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [63:32] Refer to the AES_IVR0 register for description of the IVI[128:0] bitfield.
  [then]


  [ifdef] AES_AES_IVR2_DEF
    \
    \ @brief AES initialization vector register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [95:64] Refer to the AES_IVR0 register for description of the IVI[128:0] bitfield.
  [then]


  [ifdef] AES_AES_IVR3_DEF
    \
    \ @brief AES initialization vector register 3
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [127:96] Refer to the AES_IVR0 register for description of the IVI[128:0] bitfield.
  [then]


  [ifdef] AES_AES_KEYR4_DEF
    \
    \ @brief AES key register 4
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [159:128] Refer to the AES_KEYR0 register for description of the KEY[255:0] bitfield and for information relative to writing AES_KEYRx registers.
  [then]


  [ifdef] AES_AES_KEYR5_DEF
    \
    \ @brief AES key register 5
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [191:160] Refer to the AES_KEYR0 register for description of the KEY[255:0] bitfield and for information relative to writing AES_KEYRx registers.
  [then]


  [ifdef] AES_AES_KEYR6_DEF
    \
    \ @brief AES key register 6
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [223:192] Refer to the AES_KEYR0 register for description of the KEY[255:0] bitfield and for information relative to writing AES_KEYRx registers.
  [then]


  [ifdef] AES_AES_KEYR7_DEF
    \
    \ @brief AES key register 7
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [255:224] Refer to the AES_KEYR0 register for description of the KEY[255:0] bitfield and for information relative to writing AES_KEYRx registers.
  [then]


  [ifdef] AES_AES_SUSPR0_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data AES_SUSPRx registers contain the complete internal register states of the AES when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section121.4.8: AES suspend and resume operations for more details. Read to this register returns zero when EN bit is cleared in AES_SR register. AES_SUSPRx registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] AES_AES_SUSPR1_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data AES_SUSPRx registers contain the complete internal register states of the AES when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section121.4.8: AES suspend and resume operations for more details. Read to this register returns zero when EN bit is cleared in AES_SR register. AES_SUSPRx registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] AES_AES_SUSPR2_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data AES_SUSPRx registers contain the complete internal register states of the AES when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section121.4.8: AES suspend and resume operations for more details. Read to this register returns zero when EN bit is cleared in AES_SR register. AES_SUSPRx registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] AES_AES_SUSPR3_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data AES_SUSPRx registers contain the complete internal register states of the AES when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section121.4.8: AES suspend and resume operations for more details. Read to this register returns zero when EN bit is cleared in AES_SR register. AES_SUSPRx registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] AES_AES_SUSPR4_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data AES_SUSPRx registers contain the complete internal register states of the AES when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section121.4.8: AES suspend and resume operations for more details. Read to this register returns zero when EN bit is cleared in AES_SR register. AES_SUSPRx registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] AES_AES_SUSPR5_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data AES_SUSPRx registers contain the complete internal register states of the AES when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section121.4.8: AES suspend and resume operations for more details. Read to this register returns zero when EN bit is cleared in AES_SR register. AES_SUSPRx registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] AES_AES_SUSPR6_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data AES_SUSPRx registers contain the complete internal register states of the AES when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section121.4.8: AES suspend and resume operations for more details. Read to this register returns zero when EN bit is cleared in AES_SR register. AES_SUSPRx registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] AES_AES_SUSPR7_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data AES_SUSPRx registers contain the complete internal register states of the AES when the GCM, GMAC or CCM processing of the current task is suspended to process a higher-priority task. Refer to Section121.4.8: AES suspend and resume operations for more details. Read to this register returns zero when EN bit is cleared in AES_SR register. AES_SUSPRx registers are not used in other chaining modes than GCM, GMAC or CCM.
  [then]


  [ifdef] AES_AES_IER_DEF
    \
    \ @brief AES interrupt enable register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCFIE                      \ [0x00] Computation complete flag interrupt enable This bit enables or disables (masks) the AES interrupt generation when CCF (computation complete flag) is set.
    $01 constant AES_RWEIE                      \ [0x01] Read or write error interrupt enable This bit enables or disables (masks) the AES interrupt generation when RWEIF (read and/or write error flag) is set.
    $02 constant AES_KEIE                       \ [0x02] Key error interrupt enable This bit enables or disables (masks) the AES interrupt generation when KEIF (key error flag) is set.
  [then]


  [ifdef] AES_AES_ISR_DEF
    \
    \ @brief AES interrupt status register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCF                        \ [0x00] Computation complete flag This flag indicates whether the computation is completed. It is significant only when the DMAOUTEN bit is cleared, and it may stay high when DMAOUTEN is set. The flag setting generates an interrupt if the CCFIE bit of the AES_IER register is set. The flag is cleared by setting the corresponding bit of the AES_ICR register.
    $01 constant AES_RWEIF                      \ [0x01] Read or write error interrupt flag This read-only bit is set by hardware when a RDERRF or a WRERRF error flag is set in the AES_SR register. The flag setting generates an interrupt if the RWEIE bit of the AES_IER register is set. The flag is cleared by setting the corresponding bit of the AES_ICR register. The flags has no meaning when key derivation mode is selected. See the AES_SR register for details.
    $02 constant AES_KEIF                       \ [0x02] Key error interrupt flag This read-only bit is set by hardware when the key information fails to load into key registers. The flag setting generates an interrupt if the KEIE bit of the AES_IER register is set. The flag is cleared by setting the corresponding bit of the AES_ICR register. KEIF is raised upon any of the following events: AES_KEYRx register write does not respect the correct order. (For KEYSIZE1cleared, AES_KEYR0 then AES_KEYR1 then AES_KEYR2 then AES_KEYR3 register, or reverse. For KEYSIZE set, AES_KEYR0 then AES_KEYR1 then AES_KEYR2 then AES_KEYR3 then AES_KEYR4 then AES_KEYR5 then AES_KEYR6 then AES_KEYR7, or reverse). KEIF must be cleared by the application software, otherwise KEYVALID cannot be set.
  [then]


  [ifdef] AES_AES_ICR_DEF
    \
    \ @brief AES interrupt clear register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCF                        \ [0x00] Computation complete flag clear Setting this bit clears the CCF status bit of the AES_ISR register.
    $01 constant AES_RWEIF                      \ [0x01] Read or write error interrupt flag clear Setting this bit clears the RWEIF status bit of the AES_ISR register, and clears both RDERRF and WRERRF flags in the AES_SR register.
    $02 constant AES_KEIF                       \ [0x02] Key error interrupt flag clear Setting this bit clears the KEIF status bit of the AES_ISR register.
  [then]

  \
  \ @brief AES register block
  \
  $00 constant AES_AES_CR               \ AES control register
  $04 constant AES_AES_SR               \ AES status register
  $08 constant AES_AES_DINR             \ AES data input register
  $0C constant AES_AES_DOUTR            \ AES data output register
  $10 constant AES_AES_KEYR0            \ AES key register 0
  $14 constant AES_AES_KEYR1            \ AES key register 1
  $18 constant AES_AES_KEYR2            \ AES key register 2
  $1C constant AES_AES_KEYR3            \ AES key register 3
  $20 constant AES_AES_IVR0             \ AES initialization vector register 0
  $24 constant AES_AES_IVR1             \ AES initialization vector register 1
  $28 constant AES_AES_IVR2             \ AES initialization vector register 2
  $2C constant AES_AES_IVR3             \ AES initialization vector register 3
  $30 constant AES_AES_KEYR4            \ AES key register 4
  $34 constant AES_AES_KEYR5            \ AES key register 5
  $38 constant AES_AES_KEYR6            \ AES key register 6
  $3C constant AES_AES_KEYR7            \ AES key register 7
  $40 constant AES_AES_SUSPR0           \ AES suspend registers
  $44 constant AES_AES_SUSPR1           \ AES suspend registers
  $48 constant AES_AES_SUSPR2           \ AES suspend registers
  $4C constant AES_AES_SUSPR3           \ AES suspend registers
  $50 constant AES_AES_SUSPR4           \ AES suspend registers
  $54 constant AES_AES_SUSPR5           \ AES suspend registers
  $58 constant AES_AES_SUSPR6           \ AES suspend registers
  $5C constant AES_AES_SUSPR7           \ AES suspend registers
  $300 constant AES_AES_IER             \ AES interrupt enable register
  $304 constant AES_AES_ISR             \ AES interrupt status register
  $308 constant AES_AES_ICR             \ AES interrupt clear register

: AES_DEF ; [then]
