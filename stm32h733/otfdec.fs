\
\ @file otfdec.fs
\ @brief OTFDEC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTFDEC_DEF

  [ifdef] OTFDEC_OTFDEC_R1CFGR_DEF
    \
    \ @brief OTFDEC region 1 configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REG_EN                  \ [0x00] region on-the-fly decryption enable Note: When this bit is set region context (version, key, nonce) must be valid or garbage will be decrypted.
    $01 constant OTFDEC_CONFIGLOCK              \ [0x01] region config lock This bit-field is set once, i.e. if this bit is set it can only be reset to “0” if OTFDEC is reset. Setting this bit forces KEYLOCK bit to “1”.
    $02 constant OTFDEC_KEYLOCK                 \ [0x02] region key lock This bitfield is set once, i.e. if this bit is set it can only be reset to “0” if the OTFDEC is reset.
    $04 constant OTFDEC_MODE                    \ [0x04 : 2] operating mode This bitfield selects the OTFDEC operating mode for this region: When MODE is not equal to 11 the standard AES encryption mode is activated. When either of the MODE bits are changed the region’s key and associated CRC are zeroed.
    $08 constant OTFDEC_KEYCRC                  \ [0x08 : 8] region key 8-bit CRC When KEYLOCK=0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK=1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in this manual. This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
    $10 constant OTFDEC_REGx_VERSION            \ [0x10 : 16] region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in the RxCFGR register.
  [then]


  [ifdef] OTFDEC_OTFDEC_R1STARTADDR_DEF
    \
    \ @brief OTFDEC region 1 start address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_START_ADDR         \ [0x00 : 32] Region AXI start address This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded. Note: When determining the region the first 12 bits (LSB) and the last 4 bits (MSB) are ignored. When this register is accessed in read the 4 MSB bits and the 12 LSB bits return zero.
  [then]


  [ifdef] OTFDEC_OTFDEC_R1ENDADDR_DEF
    \
    \ @brief OTFDEC region 1 end address register
    \ Address offset: 0x28
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC_REGx_END_ADDR           \ [0x00 : 32] Region AXI end address This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set, and RxENDADDR must be strictly greater than RxSTARTADDR to be valid. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded. Note: When determining the region the first 12 bits (LSB) and the last 4 bits (MSB) are ignored. When this register is accessed in read the 4 MSB bits returns zeros and the 12 LSB bits return ones.
  [then]


  [ifdef] OTFDEC_OTFDEC_R1NONCER0_DEF
    \
    \ @brief OTFDEC region 1 nonce register 0
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_NONCE              \ [0x00 : 32] Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded.
  [then]


  [ifdef] OTFDEC_OTFDEC_R1NONCER1_DEF
    \
    \ @brief OTFDEC region 1 nonce register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_NONCE              \ [0x00 : 32] Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R1KEYR0_DEF
    \
    \ @brief OTFDEC region 1 key register 0
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Reading this register returns a zero value. Writing this register while the region CONFIGLOCK or KEYLOCK bit is set in the RxCFGR register will be discarded. Note: When application successfully changes MODE bits in RxCFGR register RxKEYR registers and associated KEYCRC are erased.
  [then]


  [ifdef] OTFDEC_OTFDEC_R1KEYR1_DEF
    \
    \ @brief OTFDEC region 1 key register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R1KEYR2_DEF
    \
    \ @brief OTFDEC region 1 key register 2
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R1KEYR3_DEF
    \
    \ @brief OTFDEC region 1 key register 3
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R2CFGR_DEF
    \
    \ @brief OTFDEC region 2 configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REG_EN                  \ [0x00] region on-the-fly decryption enable Note: When this bit is set region context (version, key, nonce) must be valid or garbage will be decrypted.
    $01 constant OTFDEC_CONFIGLOCK              \ [0x01] region config lock This bit-field is set once, i.e. if this bit is set it can only be reset to “0” if OTFDEC is reset. Setting this bit forces KEYLOCK bit to “1”.
    $02 constant OTFDEC_KEYLOCK                 \ [0x02] region key lock This bitfield is set once, i.e. if this bit is set it can only be reset to “0” if the OTFDEC is reset.
    $04 constant OTFDEC_MODE                    \ [0x04 : 2] operating mode This bitfield selects the OTFDEC operating mode for this region: When MODE is not equal to 11 the standard AES encryption mode is activated. When either of the MODE bits are changed the region’s key and associated CRC are zeroed.
    $08 constant OTFDEC_KEYCRC                  \ [0x08 : 8] region key 8-bit CRC When KEYLOCK=0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK=1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in this manual. This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
    $10 constant OTFDEC_REGx_VERSION            \ [0x10 : 16] region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in the RxCFGR register.
  [then]


  [ifdef] OTFDEC_OTFDEC_R2STARTADDR_DEF
    \
    \ @brief OTFDEC region 2 start address register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_START_ADDR         \ [0x00 : 32] Region AXI start address This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded. Note: When determining the region the first 12 bits (LSB) and the last 4 bits (MSB) are ignored. When this register is accessed in read the 4 MSB bits and the 12 LSB bits return zero.
  [then]


  [ifdef] OTFDEC_OTFDEC_R2ENDADDR_DEF
    \
    \ @brief OTFDEC region 2 end address register
    \ Address offset: 0x58
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC_REGx_END_ADDR           \ [0x00 : 32] Region AXI end address This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set, and RxENDADDR must be strictly greater than RxSTARTADDR to be valid. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded. Note: When determining the region the first 12 bits (LSB) and the last 4 bits (MSB) are ignored. When this register is accessed in read the 4 MSB bits returns zeros and the 12 LSB bits return ones.
  [then]


  [ifdef] OTFDEC_OTFDEC_R2NONCER0_DEF
    \
    \ @brief OTFDEC region 2 nonce register 0
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_NONCE              \ [0x00 : 32] Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded.
  [then]


  [ifdef] OTFDEC_OTFDEC_R2NONCER1_DEF
    \
    \ @brief OTFDEC region 2 nonce register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_NONCE              \ [0x00 : 32] Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R2KEYR0_DEF
    \
    \ @brief OTFDEC region 2 key register 0
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Reading this register returns a zero value. Writing this register while the region CONFIGLOCK or KEYLOCK bit is set in the RxCFGR register will be discarded. Note: When application successfully changes MODE bits in RxCFGR register RxKEYR registers and associated KEYCRC are erased.
  [then]


  [ifdef] OTFDEC_OTFDEC_R2KEYR1_DEF
    \
    \ @brief OTFDEC region 2 key register 1
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R2KEYR2_DEF
    \
    \ @brief OTFDEC region 2 key register 2
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R2KEYR3_DEF
    \
    \ @brief OTFDEC region 2 key register 3
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R3CFGR_DEF
    \
    \ @brief OTFDEC region 3 configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REG_EN                  \ [0x00] region on-the-fly decryption enable Note: When this bit is set region context (version, key, nonce) must be valid or garbage will be decrypted.
    $01 constant OTFDEC_CONFIGLOCK              \ [0x01] region config lock This bit-field is set once, i.e. if this bit is set it can only be reset to “0” if OTFDEC is reset. Setting this bit forces KEYLOCK bit to “1”.
    $02 constant OTFDEC_KEYLOCK                 \ [0x02] region key lock This bitfield is set once, i.e. if this bit is set it can only be reset to “0” if the OTFDEC is reset.
    $04 constant OTFDEC_MODE                    \ [0x04 : 2] operating mode This bitfield selects the OTFDEC operating mode for this region: When MODE is not equal to 11 the standard AES encryption mode is activated. When either of the MODE bits are changed the region’s key and associated CRC are zeroed.
    $08 constant OTFDEC_KEYCRC                  \ [0x08 : 8] region key 8-bit CRC When KEYLOCK=0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK=1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in this manual. This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
    $10 constant OTFDEC_REGx_VERSION            \ [0x10 : 16] region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in the RxCFGR register.
  [then]


  [ifdef] OTFDEC_OTFDEC_R3STARTADDR_DEF
    \
    \ @brief OTFDEC region 3 start address register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_START_ADDR         \ [0x00 : 32] Region AXI start address This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded. Note: When determining the region the first 12 bits (LSB) and the last 4 bits (MSB) are ignored. When this register is accessed in read the 4 MSB bits and the 12 LSB bits return zero.
  [then]


  [ifdef] OTFDEC_OTFDEC_R3ENDADDR_DEF
    \
    \ @brief OTFDEC region 3 end address register
    \ Address offset: 0x88
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC_REGx_END_ADDR           \ [0x00 : 32] Region AXI end address This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set, and RxENDADDR must be strictly greater than RxSTARTADDR to be valid. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded. Note: When determining the region the first 12 bits (LSB) and the last 4 bits (MSB) are ignored. When this register is accessed in read the 4 MSB bits returns zeros and the 12 LSB bits return ones.
  [then]


  [ifdef] OTFDEC_OTFDEC_R3NONCER0_DEF
    \
    \ @brief OTFDEC region 3 nonce register 0
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_NONCE              \ [0x00 : 32] Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded.
  [then]


  [ifdef] OTFDEC_OTFDEC_R3NONCER1_DEF
    \
    \ @brief OTFDEC region 3 nonce register 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_NONCE              \ [0x00 : 32] Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R3KEYR0_DEF
    \
    \ @brief OTFDEC region 3 key register 0
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Reading this register returns a zero value. Writing this register while the region CONFIGLOCK or KEYLOCK bit is set in the RxCFGR register will be discarded. Note: When application successfully changes MODE bits in RxCFGR register RxKEYR registers and associated KEYCRC are erased.
  [then]


  [ifdef] OTFDEC_OTFDEC_R3KEYR1_DEF
    \
    \ @brief OTFDEC region 3 key register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R3KEYR2_DEF
    \
    \ @brief OTFDEC region 3 key register 2
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R3KEYR3_DEF
    \
    \ @brief OTFDEC region 3 key register 3
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R4CFGR_DEF
    \
    \ @brief OTFDEC region 4 configuration register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REG_EN                  \ [0x00] region on-the-fly decryption enable Note: When this bit is set region context (version, key, nonce) must be valid or garbage will be decrypted.
    $01 constant OTFDEC_CONFIGLOCK              \ [0x01] region config lock This bit-field is set once, i.e. if this bit is set it can only be reset to “0” if OTFDEC is reset. Setting this bit forces KEYLOCK bit to “1”.
    $02 constant OTFDEC_KEYLOCK                 \ [0x02] region key lock This bitfield is set once, i.e. if this bit is set it can only be reset to “0” if the OTFDEC is reset.
    $04 constant OTFDEC_MODE                    \ [0x04 : 2] operating mode This bitfield selects the OTFDEC operating mode for this region: When MODE is not equal to 11 the standard AES encryption mode is activated. When either of the MODE bits are changed the region’s key and associated CRC are zeroed.
    $08 constant OTFDEC_KEYCRC                  \ [0x08 : 8] region key 8-bit CRC When KEYLOCK=0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK=1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in this manual. This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
    $10 constant OTFDEC_REGx_VERSION            \ [0x10 : 16] region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in the RxCFGR register.
  [then]


  [ifdef] OTFDEC_OTFDEC_R4STARTADDR_DEF
    \
    \ @brief OTFDEC region 4 start address register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_START_ADDR         \ [0x00 : 32] Region AXI start address This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded. Note: When determining the region the first 12 bits (LSB) and the last 4 bits (MSB) are ignored. When this register is accessed in read the 4 MSB bits and the 12 LSB bits return zero.
  [then]


  [ifdef] OTFDEC_OTFDEC_R4ENDADDR_DEF
    \
    \ @brief OTFDEC region 4 end address register
    \ Address offset: 0xB8
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC_REGx_END_ADDR           \ [0x00 : 32] Region AXI end address This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set, and RxENDADDR must be strictly greater than RxSTARTADDR to be valid. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded. Note: When determining the region the first 12 bits (LSB) and the last 4 bits (MSB) are ignored. When this register is accessed in read the 4 MSB bits returns zeros and the 12 LSB bits return ones.
  [then]


  [ifdef] OTFDEC_OTFDEC_R4NONCER0_DEF
    \
    \ @brief OTFDEC region 4 nonce register 0
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_NONCE              \ [0x00 : 32] Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Writing this register while the region CONFIGLOCK bit in the RxCFGR register is set will be discarded.
  [then]


  [ifdef] OTFDEC_OTFDEC_R4NONCER1_DEF
    \
    \ @brief OTFDEC region 4 nonce register 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_NONCE              \ [0x00 : 32] Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R4KEYR0_DEF
    \
    \ @brief OTFDEC region 4 key register 0
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in the RxCFGR register is set. Reading this register returns a zero value. Writing this register while the region CONFIGLOCK or KEYLOCK bit is set in the RxCFGR register will be discarded. Note: When application successfully changes MODE bits in RxCFGR register RxKEYR registers and associated KEYCRC are erased.
  [then]


  [ifdef] OTFDEC_OTFDEC_R4KEYR1_DEF
    \
    \ @brief OTFDEC region 4 key register 1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R4KEYR2_DEF
    \
    \ @brief OTFDEC region 4 key register 2
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_R4KEYR3_DEF
    \
    \ @brief OTFDEC region 4 key register 3
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_REGx_KEY                \ [0x00 : 32] Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.
  [then]


  [ifdef] OTFDEC_OTFDEC_ISR_DEF
    \
    \ @brief OTFDEC interrupt status register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_SEIF                    \ [0x00] Security Error Interrupt Flag status This bit is set by hardware and read only by application. Bit is set when at least one security error has been detected (illegal access to keys, illegal write on locked configuration). Bit is cleared when application sets in OTFDEC_ICR the corresponding bit to “1”.
    $01 constant OTFDEC_XONEIF                  \ [0x01] Execute-only execute-Never Error Interrupt Flag status This bit is set by hardware and read only by application. Bit is set when a read access and not an instruction fetch is detected on any encrypted region with MODE bits set to 00 or 11. It is also set when an instruction fetch and not a read access is detected on any encrypted region with MODE bits set to 01. Bit is cleared when application sets in OTFDEC_ICR the corresponding bit to “1”.
    $02 constant OTFDEC_KEIF                    \ [0x02] Key Error Interrupt Flag status This bit is set by hardware and read only by application. Bit is set when a read access occurs on any encrypted region following the reset of the key registers by an abort event (tamper detection, unauthorized debugger connection, untrusted boot, RDP level regression). Bit is cleared when application sets in OTFDEC_ICR the corresponding bit to “1”. After KEIF is set any subsequent read to any enabled encrypted region returns a zeroed value. This state remains until OTFDEC keys are initialized again.
  [then]


  [ifdef] OTFDEC_OTFDEC_ICR_DEF
    \
    \ @brief OTFDEC interrupt clear register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_SEIF                    \ [0x00] Security Error Interrupt Flag clear This bit is written by application, and always reads as 0.
    $01 constant OTFDEC_XONEIF                  \ [0x01] Execute-only execute-Never Error Interrupt Flag clear This bit is written by application, and always reads as 0.
    $02 constant OTFDEC_KEIF                    \ [0x02] Key Error Interrupt Flag clear This bit is written by application, and always reads as 0. Note: Clearing KEIF does not solve the source of the problem (bad key registers). To be able to read or execute again any encrypted region, OTFDEC key registers must properly initialized, again.
  [then]


  [ifdef] OTFDEC_OTFDEC_IER_DEF
    \
    \ @brief OTFDEC interrupt enable register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC_SEIE                    \ [0x00] Security Error Interrupt Enable This bit is read and written by application. It controls the OTFDEC interrupt generation when SEIF flag status is set.
    $01 constant OTFDEC_XONEIE                  \ [0x01] Execute-only execute-Never Error Interrupt Enable This bit is read and written by application. It controls the OTFDEC interrupt generation when XONEIF flag status is set.
    $02 constant OTFDEC_KEIE                    \ [0x02] Key Error Interrupt Enable This bit is read and written by application. It controls the OTFDEC interrupt generation when KEIF flag status is set.
  [then]

  \
  \ @brief OTFDEC address block description
  \
  $20 constant OTFDEC_OTFDEC_R1CFGR     \ OTFDEC region 1 configuration register
  $24 constant OTFDEC_OTFDEC_R1STARTADDR    \ OTFDEC region 1 start address register
  $28 constant OTFDEC_OTFDEC_R1ENDADDR  \ OTFDEC region 1 end address register
  $2C constant OTFDEC_OTFDEC_R1NONCER0  \ OTFDEC region 1 nonce register 0
  $30 constant OTFDEC_OTFDEC_R1NONCER1  \ OTFDEC region 1 nonce register 1
  $34 constant OTFDEC_OTFDEC_R1KEYR0    \ OTFDEC region 1 key register 0
  $38 constant OTFDEC_OTFDEC_R1KEYR1    \ OTFDEC region 1 key register 1
  $3C constant OTFDEC_OTFDEC_R1KEYR2    \ OTFDEC region 1 key register 2
  $40 constant OTFDEC_OTFDEC_R1KEYR3    \ OTFDEC region 1 key register 3
  $50 constant OTFDEC_OTFDEC_R2CFGR     \ OTFDEC region 2 configuration register
  $54 constant OTFDEC_OTFDEC_R2STARTADDR    \ OTFDEC region 2 start address register
  $58 constant OTFDEC_OTFDEC_R2ENDADDR  \ OTFDEC region 2 end address register
  $5C constant OTFDEC_OTFDEC_R2NONCER0  \ OTFDEC region 2 nonce register 0
  $60 constant OTFDEC_OTFDEC_R2NONCER1  \ OTFDEC region 2 nonce register 1
  $64 constant OTFDEC_OTFDEC_R2KEYR0    \ OTFDEC region 2 key register 0
  $68 constant OTFDEC_OTFDEC_R2KEYR1    \ OTFDEC region 2 key register 1
  $6C constant OTFDEC_OTFDEC_R2KEYR2    \ OTFDEC region 2 key register 2
  $70 constant OTFDEC_OTFDEC_R2KEYR3    \ OTFDEC region 2 key register 3
  $80 constant OTFDEC_OTFDEC_R3CFGR     \ OTFDEC region 3 configuration register
  $84 constant OTFDEC_OTFDEC_R3STARTADDR    \ OTFDEC region 3 start address register
  $88 constant OTFDEC_OTFDEC_R3ENDADDR  \ OTFDEC region 3 end address register
  $8C constant OTFDEC_OTFDEC_R3NONCER0  \ OTFDEC region 3 nonce register 0
  $90 constant OTFDEC_OTFDEC_R3NONCER1  \ OTFDEC region 3 nonce register 1
  $94 constant OTFDEC_OTFDEC_R3KEYR0    \ OTFDEC region 3 key register 0
  $98 constant OTFDEC_OTFDEC_R3KEYR1    \ OTFDEC region 3 key register 1
  $9C constant OTFDEC_OTFDEC_R3KEYR2    \ OTFDEC region 3 key register 2
  $A0 constant OTFDEC_OTFDEC_R3KEYR3    \ OTFDEC region 3 key register 3
  $B0 constant OTFDEC_OTFDEC_R4CFGR     \ OTFDEC region 4 configuration register
  $B4 constant OTFDEC_OTFDEC_R4STARTADDR    \ OTFDEC region 4 start address register
  $B8 constant OTFDEC_OTFDEC_R4ENDADDR  \ OTFDEC region 4 end address register
  $BC constant OTFDEC_OTFDEC_R4NONCER0  \ OTFDEC region 4 nonce register 0
  $C0 constant OTFDEC_OTFDEC_R4NONCER1  \ OTFDEC region 4 nonce register 1
  $C4 constant OTFDEC_OTFDEC_R4KEYR0    \ OTFDEC region 4 key register 0
  $C8 constant OTFDEC_OTFDEC_R4KEYR1    \ OTFDEC region 4 key register 1
  $CC constant OTFDEC_OTFDEC_R4KEYR2    \ OTFDEC region 4 key register 2
  $D0 constant OTFDEC_OTFDEC_R4KEYR3    \ OTFDEC region 4 key register 3
  $300 constant OTFDEC_OTFDEC_ISR       \ OTFDEC interrupt status register
  $304 constant OTFDEC_OTFDEC_ICR       \ OTFDEC interrupt clear register
  $308 constant OTFDEC_OTFDEC_IER       \ OTFDEC interrupt enable register

: OTFDEC_DEF ; [then]
