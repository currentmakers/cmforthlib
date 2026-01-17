\
\ @file cryp.fs
\ @brief CRYP
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRYP_DEF

  [ifdef] CRYP_CRYP_CR_DEF
    \
    \ @brief Algorithm Direction Writing ALGODIR bit while BUSYÂ =Â 1 has no effect.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant CRYP_ALGODIR                   \ [0x02] Algorithm Direction Writing ALGODIR bit while BUSYÂ =Â 1 has no effect.
    $03 constant CRYP_ALGOMODE                  \ [0x03 : 3] Algorithm mode Below definition includes the bit 19: Writing ALGOMODE bits while BUSYÂ =Â 1 has no effect. Others: Reserved, must no be used Changing ALGOMODE from AES algorithm to DES or TDES (or the reverse) clears KEYVALID. KEYVALID is not cleared when the algorithm type is kept between two ALGOMODE, that is between TDES-ECB and TDES-CBC or between AES-ECB and AES_CTR.
    $06 constant CRYP_DATATYPE                  \ [0x06 : 2] Data Type selection This bitfield defines the format of data written in CRYP_DIN or read from CRYP_DOUT registers. For more details refer to registers and data swapping). Writing DATATYPE bits while BUSYÂ =Â 1 has no effect.
    $08 constant CRYP_KEYSIZE                   \ [0x08 : 2] Key size selection (AES mode only) This bitfield defines the bit-length of the key used for the AES cryptographic core. This bitfield is 'donât careâ in the DES or TDES modes. Writing KEYSIZE bits while BUSYÂ =Â 1 has no effect. When KEYSIZE is changed KEYVALID is cleared.
    $0e constant CRYP_FFLUSH                    \ [0x0e] CRYP FIFO Flush When CRYPEN = 0, writing this bit to 1 flushes the IN and OUT FIFOs (that is read and write pointers of the FIFOs are reset). Writing this bit to 0 has no effect. When CRYPEN = 1, writing this bit to 0 or 1 has no effect. Reading this bit always returns 0. FFLUSH bit has to be set only when BUSYÂ =Â 0. If not, the FIFO is flushed, but the block being processed may be pushed into the output FIFO just after the flush operation, resulting in a non-empty FIFO condition.
    $0f constant CRYP_CRYPEN                    \ [0x0f] CRYP processor Enable This bit is automatically cleared by hardware when the key preparation process ends (ALGOMODEÂ =Â 0111) or after GCM/GMAC or CCM Initialization phase.
    $10 constant CRYP_GCM_CCMPH                 \ [0x10 : 2] GCM or CCM Phase selection This bitfield has no effect if GCM, GMAC or CCM algorithm is not selected in ALGOMODE field. Writing to GCM_CCMPH bits while BUSYÂ =Â 1 has no effect.
    $13 constant CRYP_ALGOMODE3                 \ [0x13] Algorithm mode Below definition includes the bit 19: Writing ALGOMODE bits while BUSYÂ =Â 1 has no effect. Others: Reserved, must no be used Changing ALGOMODE from AES algorithm to DES or TDES (or the reverse) clears KEYVALID. KEYVALID is not cleared when the algorithm type is kept between two ALGOMODE, that is between TDES-ECB and TDES-CBC or between AES-ECB and AES_CTR.
    $14 constant CRYP_NPBLB                     \ [0x14 : 4] Number of Padding Bytes in Last Block of payload. This padding information must be filled by software before processing the last block of GCM payload encryption or CCM payload decryption, otherwise authentication tag computation is incorrect. ... Writing NPBLB bits while BUSYÂ =Â 1 has no effect.
    $18 constant CRYP_KMOD0                     \ [0x18] Key mode selection This bitfield defines how the CRYP key is used by the application: Others: Reserved, must not be used. When KMOD[1:0]Â =Â 10 the selected key value is available in the key registers when KEYVALID is set in SAES_SR register. Otherwise the key error flag KERF is set in CRYP_SR register. KMOD[1:0] must be set to 10 only when KEYSIZE is correct and a shared key decryption sequence has been successfully completed by the SAES co-processor. Otherwise the key error flag KERF is set in CRYP_SR. Writing to KMOD bits while BUSYÂ =Â 1 has no effect.
    $19 constant CRYP_KMOD1                     \ [0x19] Key mode selection This bitfield defines how the CRYP key is used by the application: Others: Reserved, must not be used. When KMOD[1:0]Â =Â 10 the selected key value is available in the key registers when KEYVALID is set in SAES_SR register. Otherwise the key error flag KERF is set in CRYP_SR register. KMOD[1:0] must be set to 10 only when KEYSIZE is correct and a shared key decryption sequence has been successfully completed by the SAES co-processor. Otherwise the key error flag KERF is set in CRYP_SR. Writing to KMOD bits while BUSYÂ =Â 1 has no effect.
    $1f constant CRYP_IPRST                     \ [0x1f] CRYP software reset Setting the bit resets the CRYP processor, resetting all registers to their default values except the IPRST bit itself. This bit must be kept cleared while writing any configuration registers.
  [then]


  [ifdef] CRYP_CRYP_SR_DEF
    \
    \ @brief Input FIFO empty flag
    \ Address offset: 0x04
    \ Reset value: 0x00000003
    \
    $00 constant CRYP_IFEM                      \ [0x00] Input FIFO empty flag
    $01 constant CRYP_IFNF                      \ [0x01] Input FIFO not full flag
    $02 constant CRYP_OFNE                      \ [0x02] Output FIFO not empty flag
    $03 constant CRYP_OFFU                      \ [0x03] Output FIFO full flag
    $04 constant CRYP_BUSY                      \ [0x04] Busy bit either that the CRYP core is disabled (CRYPENÂ =Â 0 in the CRYP_CR register) and the last processing has completed, or the CRYP core is waiting for enough data in the input FIFO or enough free space in the output FIFO (that is in each case at least 2 words in the DES, 4 words in the AES).
    $06 constant CRYP_KERF                      \ [0x06] Key error flag KERF is a read-only bit. It is set by hardware when key information failed to load into key registers. KERF is set if one of the below errors occurred: The user application did not write the key registers in the correct sequence (refer to for details). The CRYP failed to load the AES key shared by SAES peripheral (KMODÂ =Â 10). KMODÂ =Â 10 with ALGOMODE selecting either DES or TDES algorithm. KERF must be cleared by the application, for example through IPRST bit of CRYP_CR, otherwise KEYVALID cannot be set.
    $07 constant CRYP_KEYVALID                  \ [0x07] Key valid KEYVALID is a read-only bit. It is set by hardware when the expected amount of key information has been loaded in CRYP_KEYx key registers. It is valid for both AES and DES/TDES algorithms. When KMODÂ =Â 00, the use application must write the key registers in the correct sequence, otherwise KERF flag is set and KEYVALID remains at zero. When KMODÂ =Â 10 (AES Shared key mode), the shared key is loaded successfully from SAES to CRYP when KEYVALID is set. When an error occurs KERF flag is set in CRYP_SR and KEYVALID remains at zero.
  [then]


  [ifdef] CRYP_CRYP_DIN_DEF
    \
    \ @brief CRYP data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DATAIN                    \ [0x00 : 32] Data Input On read FIFO is popped (last written value is returned), and its value is returned if CRYPENÂ =Â 0. If CRYPENÂ =Â 1 DATAIN register returns an undefined value. On write current register content is pushed inside the FIFO.
  [then]


  [ifdef] CRYP_CRYP_DOUT_DEF
    \
    \ @brief CRYP data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DATAOUT                   \ [0x00 : 32] Data Output On read returns output FIFO content (pointed to by read pointer), else returns an undefined value. On write, no effect.
  [then]


  [ifdef] CRYP_CRYP_DMACR_DEF
    \
    \ @brief DMA Input Enable When this bit is set, DMA requests are automatically generated by the peripheral during the input data phase.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DIEN                      \ [0x00] DMA Input Enable When this bit is set, DMA requests are automatically generated by the peripheral during the input data phase.
    $01 constant CRYP_DOEN                      \ [0x01] DMA Output Enable When this bit is set, DMA requests are automatically generated by the peripheral during the output data phase.
  [then]


  [ifdef] CRYP_CRYP_IMSCR_DEF
    \
    \ @brief CRYP interrupt mask set/clear register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INIM                      \ [0x00] Input FIFO service interrupt mask
    $01 constant CRYP_OUTIM                     \ [0x01] Output FIFO service interrupt mask
  [then]


  [ifdef] CRYP_CRYP_RISR_DEF
    \
    \ @brief CRYP raw interrupt status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant CRYP_INRIS                     \ [0x00] Input FIFO service raw interrupt status This bit gives the input FIFO interrupt information without taking CRYP_IMSCR corresponding mask into account.
    $01 constant CRYP_OUTRIS                    \ [0x01] Output FIFO service raw interrupt status This bit gives the output FIFO interrupt information without taking CRYP_IMSCR corresponding mask into account.
  [then]


  [ifdef] CRYP_CRYP_MISR_DEF
    \
    \ @brief CRYP masked interrupt status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INMIS                     \ [0x00] Input FIFO service masked interrupt status This bit gives the input FIFO interrupt information without taking into account the corresponding CRYP_IMSCR mask.
    $01 constant CRYP_OUTMIS                    \ [0x01] Output FIFO service masked interrupt status This bit gives the output FIFO interrupt information without taking into account the corresponding CRYP_IMSCR mask.
  [then]


  [ifdef] CRYP_CRYP_K0LR_DEF
    \
    \ @brief CRYP key register 0L
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x (xÂ =Â  255 to 224) This write-only bitfield contains the bits [255:224] of the AES encryption or decryption key, depending on the operating mode. This register is not used in DES/TDES mode.
  [then]


  [ifdef] CRYP_CRYP_K0RR_DEF
    \
    \ @brief CRYP key register 0R
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x (xÂ =Â  223 to 192) This write-only bitfield contains the bits [223:192] of the AES encryption or decryption key, depending on the operating mode. This register is not used in DES/TDES mode.
  [then]


  [ifdef] CRYP_CRYP_K1LR_DEF
    \
    \ @brief CRYP key register 1L
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x (xÂ =Â  191 to 160) This write-only bitfield contains the bits [191:160] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [64:33] of the key K1, with parity bits unused.
  [then]


  [ifdef] CRYP_CRYP_K1RR_DEF
    \
    \ @brief CRYP key register 1R
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x (xÂ =Â  159 to 128) This write-only bitfield contains the bits [159:128] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [32:1] of the key K1, with parity bits unused.
  [then]


  [ifdef] CRYP_CRYP_K2LR_DEF
    \
    \ @brief CRYP key register 2L
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x (xÂ =Â  127 to 96) This write-only bitfield contains the bits [127:96] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [64:33] of the key K2, with parity bits unused.
  [then]


  [ifdef] CRYP_CRYP_K2RR_DEF
    \
    \ @brief CRYP key register 2R
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x (xÂ =Â  95 to 64) This write-only bitfield contains the bits [95:64] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [32:1] of the key K2, with parity bits unused.
  [then]


  [ifdef] CRYP_CRYP_K3LR_DEF
    \
    \ @brief CRYP key register 3L
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x (xÂ =Â  63 to 32) This write-only bitfield contains the bits [63:32] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [64:33] of the key K3, with parity bits unused.
  [then]


  [ifdef] CRYP_CRYP_K3RR_DEF
    \
    \ @brief CRYP key register 3R
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x (xÂ =Â  31 to 0) This write-only bitfield contains the bits [31:0] of the AES encryption or decryption key, depending on the operating mode. In DES/TDES mode this bitfield contains the bits [32:1] of the key K3, with parity bits unused.
  [then]


  [ifdef] CRYP_CRYP_IV0LR_DEF
    \
    \ @brief CRYP initialization vector register 0L
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV                        \ [0x00 : 32] Initialization vector bit x (xÂ =Â  127 to 96) This bitfield stores the initialization vector bits [127:96] for AES chaining modes other than ECB. In DES/TDES mode it corresponds to IV bits [63:32]. IV registers are updated by the core after each computation round of the DES/TDES or AES core.
  [then]


  [ifdef] CRYP_CRYP_IV0RR_DEF
    \
    \ @brief CRYP initialization vector register 0R
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV                        \ [0x00 : 32] Initialization vector bit x (xÂ =Â  95 to 64) This bitfield stores the initialization vector bits [95:64] for AES chaining modes other than ECB. In DES/TDES mode it corresponds to IV bits [31:0]. IV registers are updated by the core after each computation round of the DES/TDES or AES core.
  [then]


  [ifdef] CRYP_CRYP_IV1LR_DEF
    \
    \ @brief CRYP initialization vector register 1L
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV                        \ [0x00 : 32] Initialization vector bit x (xÂ =Â  63 to 32) This bitfield stores the initialization vector bits [63:32] for AES chaining modes other than ECB. This register is not used in DES mode. IV registers are updated by the core after each computation round of the AES core.
  [then]


  [ifdef] CRYP_CRYP_IV1RR_DEF
    \
    \ @brief CRYP initialization vector register 1R
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV                        \ [0x00 : 32] Initialization vector bit x (xÂ =Â  31 to 16) This bitfield stores the initialization vector bits [31:0] for AES chaining modes other than ECB. This register is not used in DES mode. IV registers are updated by the core after each computation round of the AES core.
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM0R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM0                 \ [0x00 : 32] CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM1R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM1                 \ [0x00 : 32] CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM2R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM2                 \ [0x00 : 32] CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM3R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM3                 \ [0x00 : 32] CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM4R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM4                 \ [0x00 : 32] CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM5R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM5                 \ [0x00 : 32] CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM6R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM6                 \ [0x00 : 32] CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM7R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM7                 \ [0x00 : 32] CRYP processor internal register states for GCM, GMAC and CCM modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCM0R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM0                    \ [0x00 : 32] CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCM1R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM1                    \ [0x00 : 32] CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCM2R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM2                    \ [0x00 : 32] CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCM3R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM3                    \ [0x00 : 32] CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCM4R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM4                    \ [0x00 : 32] CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCM5R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM5                    \ [0x00 : 32] CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCM6R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM6                    \ [0x00 : 32] CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_CSGCM7R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM7                    \ [0x00 : 32] CRYP processor internal register states for GCM and GMAC modes. Note: This register is not used in DES/TDES or other AES modes than the ones indicated
  [then]


  [ifdef] CRYP_CRYP_HWCFGR_DEF
    \
    \ @brief HW Generic 1 This field returns the tdes_impl generic value (0x1).
    \ Address offset: 0x3F0
    \ Reset value: 0x00000131
    \
    $00 constant CRYP_CFG1                      \ [0x00 : 4] HW Generic 1 This field returns the tdes_impl generic value (0x1).
    $04 constant CRYP_CFG2                      \ [0x04 : 4] HW Generic 2 This field returns the aes_impl generic value (0x3).
    $08 constant CRYP_CFG3                      \ [0x08 : 4] HW Generic 3 This field returns the dma_version generic value (0x1).
    $0c constant CRYP_CFG4                      \ [0x0c : 4] HW Generic 4 Reserved, must be kept at reset value.
  [then]


  [ifdef] CRYP_CRYP_VERR_DEF
    \
    \ @brief CRYP processor minor version This field returns the CRYP processor minor version.
    \ Address offset: 0x3F4
    \ Reset value: 0x00000023
    \
    $00 constant CRYP_MINVER                    \ [0x00 : 4] CRYP processor minor version This field returns the CRYP processor minor version.
    $04 constant CRYP_MAJVER                    \ [0x04 : 4] CRYP processor major version This field returns the CRYP processor major version.
  [then]


  [ifdef] CRYP_CRYP_IPIDR_DEF
    \
    \ @brief Identification Code This field returns the identification code of the CRYP processor.
    \ Address offset: 0x3F8
    \ Reset value: 0x00170011
    \
    $00 constant CRYP_ID                        \ [0x00 : 32] Identification Code This field returns the identification code of the CRYP processor.
  [then]


  [ifdef] CRYP_CRYP_SIDR_DEF
    \
    \ @brief Size identification code This field returns the size identification code of the CRYP processor as defined below: SID[31:8]Â =Â 0xA3C5DD (fixed code) SID[7:0]Â =Â 0x01 (1-Kbyte address decoding)
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant CRYP_SID                       \ [0x00 : 32] Size identification code This field returns the size identification code of the CRYP processor as defined below: SID[31:8]Â =Â 0xA3C5DD (fixed code) SID[7:0]Â =Â 0x01 (1-Kbyte address decoding)
  [then]

  \
  \ @brief CRYP
  \
  $00 constant CRYP_CRYP_CR             \ Algorithm Direction Writing ALGODIR bit while BUSYÂ =Â 1 has no effect.
  $04 constant CRYP_CRYP_SR             \ Input FIFO empty flag
  $08 constant CRYP_CRYP_DIN            \ CRYP data input register
  $0C constant CRYP_CRYP_DOUT           \ CRYP data output register
  $10 constant CRYP_CRYP_DMACR          \ DMA Input Enable When this bit is set, DMA requests are automatically generated by the peripheral during the input data phase.
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
  $3F0 constant CRYP_CRYP_HWCFGR        \ HW Generic 1 This field returns the tdes_impl generic value (0x1).
  $3F4 constant CRYP_CRYP_VERR          \ CRYP processor minor version This field returns the CRYP processor minor version.
  $3F8 constant CRYP_CRYP_IPIDR         \ Identification Code This field returns the identification code of the CRYP processor.
  $3FC constant CRYP_CRYP_SIDR          \ Size identification code This field returns the size identification code of the CRYP processor as defined below: SID[31:8]Â =Â 0xA3C5DD (fixed code) SID[7:0]Â =Â 0x01 (1-Kbyte address decoding)

: CRYP_DEF ; [then]
