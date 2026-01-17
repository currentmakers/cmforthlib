\
\ @file otfdec1.fs
\ @brief On-The-Fly Decryption engine
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTFDEC1_DEF

  [ifdef] OTFDEC1_OTFDEC_CR_DEF
    \
    \ @brief OTFDEC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_ENC                    \ [0x00] Encryption mode bit When this bit is set, OTFDEC is used in encryption mode, during which application can write clear text data then read back encrypted data. When this bit is cleared (default), OTFDEC is used in decryption mode, during which application only read back decrypted data. For both modes, cryptographic context (keys, nonces, firmware versions) must be properly initialized. When this bit is set, only data accesses are allowed (zeros are returned otherwise, and XONEIF is set). When MODE = 11, enhanced encryption mode is automatically selected. Note: When ENC bit is set, no access to OCTOSPI must be done (registers and Memory mapped region).
  [then]


  [ifdef] OTFDEC1_OTFDEC_PRIVCFGR_DEF
    \
    \ @brief OTFDEC_PRIVCFGR
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_PRIV                   \ [0x00] Privileged access protection. Unprivileged read accesses to registers return zeros Unprivileged write accesses to registers are ignored. Note: This bit can only be written in privileged mode. There is no limitations on reads.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R1CFGR_DEF
    \
    \ @brief OTFDEC region 1 configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG_EN                 \ [0x00] region on-the-fly decryption enable Note: Garbage is decrypted if region context (version, key, nonce) is not valid when this bit is set.
    $01 constant OTFDEC1_CONFIGLOCK             \ [0x01] region config lock Note: This bit is set once. If this bit is set, it can only be reset to 0 if OTFDEC is reset. Setting this bit forces KEYLOCK bit to 1.
    $02 constant OTFDEC1_KEYLOCK                \ [0x02] region key lock Note: This bit is set once: if this bit is set, it can only be reset to 0 if the OTFDEC is reset.
    $04 constant OTFDEC1_MODE                   \ [0x04 : 2] operating mode This bitfield selects the OTFDEC operating mode for this region: Others: Reserved When MODE different 11, the standard AES encryption mode is activated. When either of the MODE bits are changed, the region key and associated CRC are zeroed.
    $08 constant OTFDEC1_KEYCRC                 \ [0x08 : 8] region key 8-bit CRC When KEYLOCK = 0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK = 1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in . This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
    $10 constant OTFDEC1_REGx_VERSION           \ [0x10 : 16] region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in OTFDEC_RxCFGR.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R1STARTADDR_DEF
    \
    \ @brief OTFDEC region 1 start address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_START_ADDR        \ [0x00 : 32] Region AHB start address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set. Writing to this register is discarded if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR register is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits and the 12 lsb bits return zeros .
  [then]


  [ifdef] OTFDEC1_OTFDEC_R1ENDADDR_DEF
    \
    \ @brief OTFDEC region 1 end address register
    \ Address offset: 0x28
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC1_REGx_END_ADDR          \ [0x00 : 32] Region AHB end address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set, and OTFDEC_RxENDADDR must be strictly greater than OTFDEC_RxSTARTADDR to be valid. Writing to this register is discarded if performed while the region CONFIGLOCK bit in OTFDEC_RxCFGR is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits return zeros and the 12 lsb bits return ones.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R1NONCER0_DEF
    \
    \ @brief OTFDEC region 1 nonce register 0
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_NONCE             \ [0x00 : 32] Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Writing is discarded in this register if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR is set.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R1NONCER1_DEF
    \
    \ @brief OTFDEC region 1 nonce register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_NONCE             \ [0x00 : 32] Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R1KEYR0_DEF
    \
    \ @brief OTFDEC region 1 key register 0
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Reading this register returns a zero value. Writing to this register is discarded if performed while the region CONFIGLOCK or KEYLOCK bit is set in the OTFDEC_RxCFGR. Note: When application successfully changes MODE bits in OTFDEC_RxCFGR and OTFDEC_RxKEYR, and associated KEYCRC are erased.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R1KEYR1_DEF
    \
    \ @brief OTFDEC region 1 key register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R1KEYR2_DEF
    \
    \ @brief OTFDEC region 1 key register 2
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R1KEYR3_DEF
    \
    \ @brief OTFDEC region 1 key register 3
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R2CFGR_DEF
    \
    \ @brief OTFDEC region 2 configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG_EN                 \ [0x00] region on-the-fly decryption enable Note: Garbage is decrypted if region context (version, key, nonce) is not valid when this bit is set.
    $01 constant OTFDEC1_CONFIGLOCK             \ [0x01] region config lock Note: This bit is set once. If this bit is set, it can only be reset to 0 if OTFDEC is reset. Setting this bit forces KEYLOCK bit to 1.
    $02 constant OTFDEC1_KEYLOCK                \ [0x02] region key lock Note: This bit is set once: if this bit is set, it can only be reset to 0 if the OTFDEC is reset.
    $04 constant OTFDEC1_MODE                   \ [0x04 : 2] operating mode This bitfield selects the OTFDEC operating mode for this region: Others: Reserved When MODE different 11, the standard AES encryption mode is activated. When either of the MODE bits are changed, the region key and associated CRC are zeroed.
    $08 constant OTFDEC1_KEYCRC                 \ [0x08 : 8] region key 8-bit CRC When KEYLOCK = 0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK = 1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in . This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
    $10 constant OTFDEC1_REGx_VERSION           \ [0x10 : 16] region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in OTFDEC_RxCFGR.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R2STARTADDR_DEF
    \
    \ @brief OTFDEC region 2 start address register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_START_ADDR        \ [0x00 : 32] Region AHB start address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set. Writing to this register is discarded if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR register is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits and the 12 lsb bits return zeros .
  [then]


  [ifdef] OTFDEC1_OTFDEC_R2ENDADDR_DEF
    \
    \ @brief OTFDEC region 2 end address register
    \ Address offset: 0x58
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC1_REGx_END_ADDR          \ [0x00 : 32] Region AHB end address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set, and OTFDEC_RxENDADDR must be strictly greater than OTFDEC_RxSTARTADDR to be valid. Writing to this register is discarded if performed while the region CONFIGLOCK bit in OTFDEC_RxCFGR is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits return zeros and the 12 lsb bits return ones.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R2NONCER0_DEF
    \
    \ @brief OTFDEC region 2 nonce register 0
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_NONCE             \ [0x00 : 32] Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Writing is discarded in this register if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR is set.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R2NONCER1_DEF
    \
    \ @brief OTFDEC region 2 nonce register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_NONCE             \ [0x00 : 32] Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R2KEYR0_DEF
    \
    \ @brief OTFDEC region 2 key register 0
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Reading this register returns a zero value. Writing to this register is discarded if performed while the region CONFIGLOCK or KEYLOCK bit is set in the OTFDEC_RxCFGR. Note: When application successfully changes MODE bits in OTFDEC_RxCFGR and OTFDEC_RxKEYR, and associated KEYCRC are erased.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R2KEYR1_DEF
    \
    \ @brief OTFDEC region 2 key register 1
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R2KEYR2_DEF
    \
    \ @brief OTFDEC region 2 key register 2
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R2KEYR3_DEF
    \
    \ @brief OTFDEC region 2 key register 3
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R3CFGR_DEF
    \
    \ @brief OTFDEC region 3 configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG_EN                 \ [0x00] region on-the-fly decryption enable Note: Garbage is decrypted if region context (version, key, nonce) is not valid when this bit is set.
    $01 constant OTFDEC1_CONFIGLOCK             \ [0x01] region config lock Note: This bit is set once. If this bit is set, it can only be reset to 0 if OTFDEC is reset. Setting this bit forces KEYLOCK bit to 1.
    $02 constant OTFDEC1_KEYLOCK                \ [0x02] region key lock Note: This bit is set once: if this bit is set, it can only be reset to 0 if the OTFDEC is reset.
    $04 constant OTFDEC1_MODE                   \ [0x04 : 2] operating mode This bitfield selects the OTFDEC operating mode for this region: Others: Reserved When MODE different 11, the standard AES encryption mode is activated. When either of the MODE bits are changed, the region key and associated CRC are zeroed.
    $08 constant OTFDEC1_KEYCRC                 \ [0x08 : 8] region key 8-bit CRC When KEYLOCK = 0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK = 1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in . This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
    $10 constant OTFDEC1_REGx_VERSION           \ [0x10 : 16] region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in OTFDEC_RxCFGR.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R3STARTADDR_DEF
    \
    \ @brief OTFDEC region 3 start address register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_START_ADDR        \ [0x00 : 32] Region AHB start address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set. Writing to this register is discarded if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR register is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits and the 12 lsb bits return zeros .
  [then]


  [ifdef] OTFDEC1_OTFDEC_R3ENDADDR_DEF
    \
    \ @brief OTFDEC region 3 end address register
    \ Address offset: 0x88
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC1_REGx_END_ADDR          \ [0x00 : 32] Region AHB end address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set, and OTFDEC_RxENDADDR must be strictly greater than OTFDEC_RxSTARTADDR to be valid. Writing to this register is discarded if performed while the region CONFIGLOCK bit in OTFDEC_RxCFGR is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits return zeros and the 12 lsb bits return ones.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R3NONCER0_DEF
    \
    \ @brief OTFDEC region 3 nonce register 0
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_NONCE             \ [0x00 : 32] Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Writing is discarded in this register if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR is set.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R3NONCER1_DEF
    \
    \ @brief OTFDEC region 3 nonce register 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_NONCE             \ [0x00 : 32] Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R3KEYR0_DEF
    \
    \ @brief OTFDEC region 3 key register 0
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Reading this register returns a zero value. Writing to this register is discarded if performed while the region CONFIGLOCK or KEYLOCK bit is set in the OTFDEC_RxCFGR. Note: When application successfully changes MODE bits in OTFDEC_RxCFGR and OTFDEC_RxKEYR, and associated KEYCRC are erased.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R3KEYR1_DEF
    \
    \ @brief OTFDEC region 3 key register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R3KEYR2_DEF
    \
    \ @brief OTFDEC region 3 key register 2
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R3KEYR3_DEF
    \
    \ @brief OTFDEC region 3 key register 3
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R4CFGR_DEF
    \
    \ @brief OTFDEC region 4 configuration register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG_EN                 \ [0x00] region on-the-fly decryption enable Note: Garbage is decrypted if region context (version, key, nonce) is not valid when this bit is set.
    $01 constant OTFDEC1_CONFIGLOCK             \ [0x01] region config lock Note: This bit is set once. If this bit is set, it can only be reset to 0 if OTFDEC is reset. Setting this bit forces KEYLOCK bit to 1.
    $02 constant OTFDEC1_KEYLOCK                \ [0x02] region key lock Note: This bit is set once: if this bit is set, it can only be reset to 0 if the OTFDEC is reset.
    $04 constant OTFDEC1_MODE                   \ [0x04 : 2] operating mode This bitfield selects the OTFDEC operating mode for this region: Others: Reserved When MODE different 11, the standard AES encryption mode is activated. When either of the MODE bits are changed, the region key and associated CRC are zeroed.
    $08 constant OTFDEC1_KEYCRC                 \ [0x08 : 8] region key 8-bit CRC When KEYLOCK = 0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK = 1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in . This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
    $10 constant OTFDEC1_REGx_VERSION           \ [0x10 : 16] region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in OTFDEC_RxCFGR.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R4STARTADDR_DEF
    \
    \ @brief OTFDEC region 4 start address register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_START_ADDR        \ [0x00 : 32] Region AHB start address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set. Writing to this register is discarded if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR register is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits and the 12 lsb bits return zeros .
  [then]


  [ifdef] OTFDEC1_OTFDEC_R4ENDADDR_DEF
    \
    \ @brief OTFDEC region 4 end address register
    \ Address offset: 0xB8
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC1_REGx_END_ADDR          \ [0x00 : 32] Region AHB end address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set, and OTFDEC_RxENDADDR must be strictly greater than OTFDEC_RxSTARTADDR to be valid. Writing to this register is discarded if performed while the region CONFIGLOCK bit in OTFDEC_RxCFGR is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits return zeros and the 12 lsb bits return ones.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R4NONCER0_DEF
    \
    \ @brief OTFDEC region 4 nonce register 0
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_NONCE             \ [0x00 : 32] Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Writing is discarded in this register if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR is set.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R4NONCER1_DEF
    \
    \ @brief OTFDEC region 4 nonce register 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_NONCE             \ [0x00 : 32] Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R4KEYR0_DEF
    \
    \ @brief OTFDEC region 4 key register 0
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Reading this register returns a zero value. Writing to this register is discarded if performed while the region CONFIGLOCK or KEYLOCK bit is set in the OTFDEC_RxCFGR. Note: When application successfully changes MODE bits in OTFDEC_RxCFGR and OTFDEC_RxKEYR, and associated KEYCRC are erased.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R4KEYR1_DEF
    \
    \ @brief OTFDEC region 4 key register 1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R4KEYR2_DEF
    \
    \ @brief OTFDEC region 4 key register 2
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_R4KEYR3_DEF
    \
    \ @brief OTFDEC region 4 key register 3
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REGx_KEY               \ [0x00 : 32] Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC1_OTFDEC_ISR_DEF
    \
    \ @brief OTFDEC interrupt status register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_SEIF                   \ [0x00] Security error interrupt flag status This bit is set by hardware and read only by application. This bit is set when at least one security error has been detected. This bit is cleared when application sets in OTFDEC_ICR the corresponding bit to 1.
    $01 constant OTFDEC1_XONEIF                 \ [0x01] Execute-only execute-never error interrupt flag status This bit is set by hardware and read only by application. This bit is set when a read access and not an instruction fetch is detected on any encrypted region with MODE bits set to 11. Lastly, XONEIF is also set when an execute access is detected while encryption mode is enabled. This bit is cleared when application sets in OTFDEC_ICR the corresponding bit to 1.
    $02 constant OTFDEC1_KEIF                   \ [0x02] Key error interrupt flag status This bit is set by hardware and read only by application. The bit is set when a read access occurs on an encrypted region, while its key registers is null or not properly initialized (KEYCRC = 0x0). This bit is cleared when the application sets in OTFDEC_ICR the corresponding bit to 1. After KEIF is set any subsequent read to the region with bad key registers returns a zeroed value. This state remains until those key registers are properly initialized (KEYCRC not zero).
  [then]


  [ifdef] OTFDEC1_OTFDEC_ICR_DEF
    \
    \ @brief OTFDEC interrupt clear register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_SEIF                   \ [0x00] Security error interrupt flag clear This bit is written by application, and always read as 0.
    $01 constant OTFDEC1_XONEIF                 \ [0x01] Execute-only execute-never error interrupt flag clear This bit is written by application, and always read as 0.
    $02 constant OTFDEC1_KEIF                   \ [0x02] Key error interrupt flag clear This bit is written by application, and always read as 0. Note: Clearing KEIF does not solve the source of the problem (bad key registers). To be able to access again any encrypted region, OTFDEC key registers must be properly initialized again.
  [then]


  [ifdef] OTFDEC1_OTFDEC_IER_DEF
    \
    \ @brief OTFDEC interrupt enable register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_SEIE                   \ [0x00] Security error interrupt enable This bit is read and written by application. It controls the OTFDEC interrupt generation when SEIF flag status is set.
    $01 constant OTFDEC1_XONEIE                 \ [0x01] Execute-only execute-never error interrupt enable This bit is read and written by application. It controls the OTFDEC interrupt generation when XONEIF flag status is set.
    $02 constant OTFDEC1_KEIE                   \ [0x02] Key error interrupt enable This bit is read and written by application. It controls the OTFDEC interrupt generation when KEIF flag status is set.
  [then]

  \
  \ @brief On-The-Fly Decryption engine
  \
  $00 constant OTFDEC1_OTFDEC_CR        \ OTFDEC control register
  $10 constant OTFDEC1_OTFDEC_PRIVCFGR  \ OTFDEC_PRIVCFGR
  $20 constant OTFDEC1_OTFDEC_R1CFGR    \ OTFDEC region 1 configuration register
  $24 constant OTFDEC1_OTFDEC_R1STARTADDR    \ OTFDEC region 1 start address register
  $28 constant OTFDEC1_OTFDEC_R1ENDADDR \ OTFDEC region 1 end address register
  $2C constant OTFDEC1_OTFDEC_R1NONCER0 \ OTFDEC region 1 nonce register 0
  $30 constant OTFDEC1_OTFDEC_R1NONCER1 \ OTFDEC region 1 nonce register 1
  $34 constant OTFDEC1_OTFDEC_R1KEYR0   \ OTFDEC region 1 key register 0
  $38 constant OTFDEC1_OTFDEC_R1KEYR1   \ OTFDEC region 1 key register 1
  $3C constant OTFDEC1_OTFDEC_R1KEYR2   \ OTFDEC region 1 key register 2
  $40 constant OTFDEC1_OTFDEC_R1KEYR3   \ OTFDEC region 1 key register 3
  $50 constant OTFDEC1_OTFDEC_R2CFGR    \ OTFDEC region 2 configuration register
  $54 constant OTFDEC1_OTFDEC_R2STARTADDR    \ OTFDEC region 2 start address register
  $58 constant OTFDEC1_OTFDEC_R2ENDADDR \ OTFDEC region 2 end address register
  $5C constant OTFDEC1_OTFDEC_R2NONCER0 \ OTFDEC region 2 nonce register 0
  $60 constant OTFDEC1_OTFDEC_R2NONCER1 \ OTFDEC region 2 nonce register 1
  $64 constant OTFDEC1_OTFDEC_R2KEYR0   \ OTFDEC region 2 key register 0
  $68 constant OTFDEC1_OTFDEC_R2KEYR1   \ OTFDEC region 2 key register 1
  $6C constant OTFDEC1_OTFDEC_R2KEYR2   \ OTFDEC region 2 key register 2
  $70 constant OTFDEC1_OTFDEC_R2KEYR3   \ OTFDEC region 2 key register 3
  $80 constant OTFDEC1_OTFDEC_R3CFGR    \ OTFDEC region 3 configuration register
  $84 constant OTFDEC1_OTFDEC_R3STARTADDR    \ OTFDEC region 3 start address register
  $88 constant OTFDEC1_OTFDEC_R3ENDADDR \ OTFDEC region 3 end address register
  $8C constant OTFDEC1_OTFDEC_R3NONCER0 \ OTFDEC region 3 nonce register 0
  $90 constant OTFDEC1_OTFDEC_R3NONCER1 \ OTFDEC region 3 nonce register 1
  $94 constant OTFDEC1_OTFDEC_R3KEYR0   \ OTFDEC region 3 key register 0
  $98 constant OTFDEC1_OTFDEC_R3KEYR1   \ OTFDEC region 3 key register 1
  $9C constant OTFDEC1_OTFDEC_R3KEYR2   \ OTFDEC region 3 key register 2
  $A0 constant OTFDEC1_OTFDEC_R3KEYR3   \ OTFDEC region 3 key register 3
  $B0 constant OTFDEC1_OTFDEC_R4CFGR    \ OTFDEC region 4 configuration register
  $B4 constant OTFDEC1_OTFDEC_R4STARTADDR    \ OTFDEC region 4 start address register
  $B8 constant OTFDEC1_OTFDEC_R4ENDADDR \ OTFDEC region 4 end address register
  $BC constant OTFDEC1_OTFDEC_R4NONCER0 \ OTFDEC region 4 nonce register 0
  $C0 constant OTFDEC1_OTFDEC_R4NONCER1 \ OTFDEC region 4 nonce register 1
  $C4 constant OTFDEC1_OTFDEC_R4KEYR0   \ OTFDEC region 4 key register 0
  $C8 constant OTFDEC1_OTFDEC_R4KEYR1   \ OTFDEC region 4 key register 1
  $CC constant OTFDEC1_OTFDEC_R4KEYR2   \ OTFDEC region 4 key register 2
  $D0 constant OTFDEC1_OTFDEC_R4KEYR3   \ OTFDEC region 4 key register 3
  $300 constant OTFDEC1_OTFDEC_ISR      \ OTFDEC interrupt status register
  $304 constant OTFDEC1_OTFDEC_ICR      \ OTFDEC interrupt clear register
  $308 constant OTFDEC1_OTFDEC_IER      \ OTFDEC interrupt enable register

: OTFDEC1_DEF ; [then]
