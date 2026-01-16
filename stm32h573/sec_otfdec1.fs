\
\ @file sec_otfdec1.fs
\ @brief On-The-Fly Decryption engine
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTFDEC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_OTFDEC_CR_ENC                        \ Encryption mode bit When this bit is set, OTFDEC is used in encryption mode, during which application can write clear text data then read back encrypted data. When this bit is cleared (default), OTFDEC is used in decryption mode, during which application only read back decrypted data. For both modes, cryptographic context (keys, nonces, firmware versions) must be properly initialized. When this bit is set, only data accesses are allowed (zeros are returned otherwise, and XONEIF is set). When MODE = 11, enhanced encryption mode is automatically selected. Note: When ENC bit is set, no access to OCTOSPI must be done (registers and Memory mapped region).


\
\ @brief OTFDEC_PRIVCFGR
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_OTFDEC_PRIVCFGR_PRIV                 \ Privileged access protection. Unprivileged read accesses to registers return zeros Unprivileged write accesses to registers are ignored. Note: This bit can only be written in privileged mode. There is no limitations on reads.


\
\ @brief OTFDEC region 1 configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_OTFDEC_R1CFGR_REG_EN                 \ region on-the-fly decryption enable Note: Garbage is decrypted if region context (version, key, nonce) is not valid when this bit is set.
$00000002 constant SEC_OTFDEC1_OTFDEC_R1CFGR_CONFIGLOCK             \ region config lock Note: This bit is set once. If this bit is set, it can only be reset to 0 if OTFDEC is reset. Setting this bit forces KEYLOCK bit to 1.
$00000004 constant SEC_OTFDEC1_OTFDEC_R1CFGR_KEYLOCK                \ region key lock Note: This bit is set once: if this bit is set, it can only be reset to 0 if the OTFDEC is reset.
$00000030 constant SEC_OTFDEC1_OTFDEC_R1CFGR_MODE                   \ operating mode This bitfield selects the OTFDEC operating mode for this region: Others: Reserved When MODE different 11, the standard AES encryption mode is activated. When either of the MODE bits are changed, the region key and associated CRC are zeroed.
$0000ff00 constant SEC_OTFDEC1_OTFDEC_R1CFGR_KEYCRC                 \ region key 8-bit CRC When KEYLOCK = 0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK = 1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in . This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
$ffff0000 constant SEC_OTFDEC1_OTFDEC_R1CFGR_REGX_VERSION           \ region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in OTFDEC_RxCFGR.


\
\ @brief OTFDEC region 1 start address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R1STARTADDR_REGX_START_ADDR    \ Region AHB start address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set. Writing to this register is discarded if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR register is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits and the 12 lsb bits return zeros .


\
\ @brief OTFDEC region 1 end address register
\ Address offset: 0x28
\ Reset value: 0x00000FFF
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R1ENDADDR_REGX_END_ADDR       \ Region AHB end address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set, and OTFDEC_RxENDADDR must be strictly greater than OTFDEC_RxSTARTADDR to be valid. Writing to this register is discarded if performed while the region CONFIGLOCK bit in OTFDEC_RxCFGR is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits return zeros and the 12 lsb bits return ones.


\
\ @brief OTFDEC region 1 nonce register 0
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R1NONCER0_REGX_NONCE          \ Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Writing is discarded in this register if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR is set.


\
\ @brief OTFDEC region 1 nonce register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R1NONCER1_REGX_NONCE          \ Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.


\
\ @brief OTFDEC region 1 key register 0
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R1KEYR0_REGX_KEY              \ Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Reading this register returns a zero value. Writing to this register is discarded if performed while the region CONFIGLOCK or KEYLOCK bit is set in the OTFDEC_RxCFGR. Note: When application successfully changes MODE bits in OTFDEC_RxCFGR and OTFDEC_RxKEYR, and associated KEYCRC are erased.


\
\ @brief OTFDEC region 1 key register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R1KEYR1_REGX_KEY              \ Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 1 key register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R1KEYR2_REGX_KEY              \ Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 1 key register 3
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R1KEYR3_REGX_KEY              \ Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 2 configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_OTFDEC_R2CFGR_REG_EN                 \ region on-the-fly decryption enable Note: Garbage is decrypted if region context (version, key, nonce) is not valid when this bit is set.
$00000002 constant SEC_OTFDEC1_OTFDEC_R2CFGR_CONFIGLOCK             \ region config lock Note: This bit is set once. If this bit is set, it can only be reset to 0 if OTFDEC is reset. Setting this bit forces KEYLOCK bit to 1.
$00000004 constant SEC_OTFDEC1_OTFDEC_R2CFGR_KEYLOCK                \ region key lock Note: This bit is set once: if this bit is set, it can only be reset to 0 if the OTFDEC is reset.
$00000030 constant SEC_OTFDEC1_OTFDEC_R2CFGR_MODE                   \ operating mode This bitfield selects the OTFDEC operating mode for this region: Others: Reserved When MODE different 11, the standard AES encryption mode is activated. When either of the MODE bits are changed, the region key and associated CRC are zeroed.
$0000ff00 constant SEC_OTFDEC1_OTFDEC_R2CFGR_KEYCRC                 \ region key 8-bit CRC When KEYLOCK = 0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK = 1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in . This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
$ffff0000 constant SEC_OTFDEC1_OTFDEC_R2CFGR_REGX_VERSION           \ region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in OTFDEC_RxCFGR.


\
\ @brief OTFDEC region 2 start address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R2STARTADDR_REGX_START_ADDR    \ Region AHB start address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set. Writing to this register is discarded if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR register is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits and the 12 lsb bits return zeros .


\
\ @brief OTFDEC region 2 end address register
\ Address offset: 0x58
\ Reset value: 0x00000FFF
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R2ENDADDR_REGX_END_ADDR       \ Region AHB end address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set, and OTFDEC_RxENDADDR must be strictly greater than OTFDEC_RxSTARTADDR to be valid. Writing to this register is discarded if performed while the region CONFIGLOCK bit in OTFDEC_RxCFGR is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits return zeros and the 12 lsb bits return ones.


\
\ @brief OTFDEC region 2 nonce register 0
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R2NONCER0_REGX_NONCE          \ Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Writing is discarded in this register if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR is set.


\
\ @brief OTFDEC region 2 nonce register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R2NONCER1_REGX_NONCE          \ Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.


\
\ @brief OTFDEC region 2 key register 0
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R2KEYR0_REGX_KEY              \ Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Reading this register returns a zero value. Writing to this register is discarded if performed while the region CONFIGLOCK or KEYLOCK bit is set in the OTFDEC_RxCFGR. Note: When application successfully changes MODE bits in OTFDEC_RxCFGR and OTFDEC_RxKEYR, and associated KEYCRC are erased.


\
\ @brief OTFDEC region 2 key register 1
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R2KEYR1_REGX_KEY              \ Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 2 key register 2
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R2KEYR2_REGX_KEY              \ Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 2 key register 3
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R2KEYR3_REGX_KEY              \ Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 3 configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_OTFDEC_R3CFGR_REG_EN                 \ region on-the-fly decryption enable Note: Garbage is decrypted if region context (version, key, nonce) is not valid when this bit is set.
$00000002 constant SEC_OTFDEC1_OTFDEC_R3CFGR_CONFIGLOCK             \ region config lock Note: This bit is set once. If this bit is set, it can only be reset to 0 if OTFDEC is reset. Setting this bit forces KEYLOCK bit to 1.
$00000004 constant SEC_OTFDEC1_OTFDEC_R3CFGR_KEYLOCK                \ region key lock Note: This bit is set once: if this bit is set, it can only be reset to 0 if the OTFDEC is reset.
$00000030 constant SEC_OTFDEC1_OTFDEC_R3CFGR_MODE                   \ operating mode This bitfield selects the OTFDEC operating mode for this region: Others: Reserved When MODE different 11, the standard AES encryption mode is activated. When either of the MODE bits are changed, the region key and associated CRC are zeroed.
$0000ff00 constant SEC_OTFDEC1_OTFDEC_R3CFGR_KEYCRC                 \ region key 8-bit CRC When KEYLOCK = 0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK = 1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in . This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
$ffff0000 constant SEC_OTFDEC1_OTFDEC_R3CFGR_REGX_VERSION           \ region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in OTFDEC_RxCFGR.


\
\ @brief OTFDEC region 3 start address register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R3STARTADDR_REGX_START_ADDR    \ Region AHB start address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set. Writing to this register is discarded if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR register is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits and the 12 lsb bits return zeros .


\
\ @brief OTFDEC region 3 end address register
\ Address offset: 0x88
\ Reset value: 0x00000FFF
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R3ENDADDR_REGX_END_ADDR       \ Region AHB end address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set, and OTFDEC_RxENDADDR must be strictly greater than OTFDEC_RxSTARTADDR to be valid. Writing to this register is discarded if performed while the region CONFIGLOCK bit in OTFDEC_RxCFGR is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits return zeros and the 12 lsb bits return ones.


\
\ @brief OTFDEC region 3 nonce register 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R3NONCER0_REGX_NONCE          \ Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Writing is discarded in this register if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR is set.


\
\ @brief OTFDEC region 3 nonce register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R3NONCER1_REGX_NONCE          \ Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.


\
\ @brief OTFDEC region 3 key register 0
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R3KEYR0_REGX_KEY              \ Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Reading this register returns a zero value. Writing to this register is discarded if performed while the region CONFIGLOCK or KEYLOCK bit is set in the OTFDEC_RxCFGR. Note: When application successfully changes MODE bits in OTFDEC_RxCFGR and OTFDEC_RxKEYR, and associated KEYCRC are erased.


\
\ @brief OTFDEC region 3 key register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R3KEYR1_REGX_KEY              \ Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 3 key register 2
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R3KEYR2_REGX_KEY              \ Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 3 key register 3
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R3KEYR3_REGX_KEY              \ Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 4 configuration register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_OTFDEC_R4CFGR_REG_EN                 \ region on-the-fly decryption enable Note: Garbage is decrypted if region context (version, key, nonce) is not valid when this bit is set.
$00000002 constant SEC_OTFDEC1_OTFDEC_R4CFGR_CONFIGLOCK             \ region config lock Note: This bit is set once. If this bit is set, it can only be reset to 0 if OTFDEC is reset. Setting this bit forces KEYLOCK bit to 1.
$00000004 constant SEC_OTFDEC1_OTFDEC_R4CFGR_KEYLOCK                \ region key lock Note: This bit is set once: if this bit is set, it can only be reset to 0 if the OTFDEC is reset.
$00000030 constant SEC_OTFDEC1_OTFDEC_R4CFGR_MODE                   \ operating mode This bitfield selects the OTFDEC operating mode for this region: Others: Reserved When MODE different 11, the standard AES encryption mode is activated. When either of the MODE bits are changed, the region key and associated CRC are zeroed.
$0000ff00 constant SEC_OTFDEC1_OTFDEC_R4CFGR_KEYCRC                 \ region key 8-bit CRC When KEYLOCK = 0, KEYCRC bitfield is automatically computed by hardware while loading the key of this region in this exact sequence: KEYR0 then KEYR1 then KEYR2 then finally KEYR3 (all written once). A new computation starts as soon as a new valid sequence is initiated, and KEYCRC is read as zero until a valid sequence is completed. When KEYLOCK = 1, KEYCRC remains unchanged until the next reset. CRC computation is an 8-bit checksum using the standard CRC-8-CCITT algorithm X8 + X2 + X + 1 (according the convention). Source code is available in . This field is read only. Note: CRC information is updated only after the last bit of the key has been written.
$ffff0000 constant SEC_OTFDEC1_OTFDEC_R4CFGR_REGX_VERSION           \ region firmware version This 16-bit bitfield must be correctly initialized before the region corresponding REG_EN bit is set in OTFDEC_RxCFGR.


\
\ @brief OTFDEC region 4 start address register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R4STARTADDR_REGX_START_ADDR    \ Region AHB start address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set. Writing to this register is discarded if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR register is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits and the 12 lsb bits return zeros .


\
\ @brief OTFDEC region 4 end address register
\ Address offset: 0xB8
\ Reset value: 0x00000FFF
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R4ENDADDR_REGX_END_ADDR       \ Region AHB end address This register must be written before the region corresponding REG_EN bit in the OTFDEC_RxCFGR register is set, and OTFDEC_RxENDADDR must be strictly greater than OTFDEC_RxSTARTADDR to be valid. Writing to this register is discarded if performed while the region CONFIGLOCK bit in OTFDEC_RxCFGR is set. Note: When determining the region the first 12 bits (lsb) and the last 4 bits (msb) are ignored. When this register is accessed in read the 4 msb bits return zeros and the 12 lsb bits return ones.


\
\ @brief OTFDEC region 4 nonce register 0
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R4NONCER0_REGX_NONCE          \ Region nonce, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Writing is discarded in this register if performed while the region CONFIGLOCK bit in the OTFDEC_RxCFGR is set.


\
\ @brief OTFDEC region 4 nonce register 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R4NONCER1_REGX_NONCE          \ Region nonce, bits [63:32] Refer to the OTFDEC_RxNONCER0 register for description of the NONCE[63:0] bitfield.


\
\ @brief OTFDEC region 4 key register 0
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R4KEYR0_REGX_KEY              \ Region key, bits [31:0] This register must be written before the region corresponding REG_EN bit in OTFDEC_RxCFGR is set. Reading this register returns a zero value. Writing to this register is discarded if performed while the region CONFIGLOCK or KEYLOCK bit is set in the OTFDEC_RxCFGR. Note: When application successfully changes MODE bits in OTFDEC_RxCFGR and OTFDEC_RxKEYR, and associated KEYCRC are erased.


\
\ @brief OTFDEC region 4 key register 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R4KEYR1_REGX_KEY              \ Region key, bits [63:32] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 4 key register 2
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R4KEYR2_REGX_KEY              \ Region key, bits [95:64] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC region 4 key register 3
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_OTFDEC_R4KEYR3_REGX_KEY              \ Region key, bits [127:96] Refer to the OTFDEC_RxKEYR0 register for description of the KEY[127:0] bitfield.


\
\ @brief OTFDEC interrupt status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_OTFDEC_ISR_SEIF                      \ Security error interrupt flag status This bit is set by hardware and read only by application. This bit is set when at least one security error has been detected. This bit is cleared when application sets in OTFDEC_ICR the corresponding bit to 1.
$00000002 constant SEC_OTFDEC1_OTFDEC_ISR_XONEIF                    \ Execute-only execute-never error interrupt flag status This bit is set by hardware and read only by application. This bit is set when a read access and not an instruction fetch is detected on any encrypted region with MODE bits set to 11. Lastly, XONEIF is also set when an execute access is detected while encryption mode is enabled. This bit is cleared when application sets in OTFDEC_ICR the corresponding bit to 1.
$00000004 constant SEC_OTFDEC1_OTFDEC_ISR_KEIF                      \ Key error interrupt flag status This bit is set by hardware and read only by application. The bit is set when a read access occurs on an encrypted region, while its key registers is null or not properly initialized (KEYCRC = 0x0). This bit is cleared when the application sets in OTFDEC_ICR the corresponding bit to 1. After KEIF is set any subsequent read to the region with bad key registers returns a zeroed value. This state remains until those key registers are properly initialized (KEYCRC not zero).


\
\ @brief OTFDEC interrupt clear register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_OTFDEC_ICR_SEIF                      \ Security error interrupt flag clear This bit is written by application, and always read as 0.
$00000002 constant SEC_OTFDEC1_OTFDEC_ICR_XONEIF                    \ Execute-only execute-never error interrupt flag clear This bit is written by application, and always read as 0.
$00000004 constant SEC_OTFDEC1_OTFDEC_ICR_KEIF                      \ Key error interrupt flag clear This bit is written by application, and always read as 0. Note: Clearing KEIF does not solve the source of the problem (bad key registers). To be able to access again any encrypted region, OTFDEC key registers must be properly initialized again.


\
\ @brief OTFDEC interrupt enable register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_OTFDEC_IER_SEIE                      \ Security error interrupt enable This bit is read and written by application. It controls the OTFDEC interrupt generation when SEIF flag status is set.
$00000002 constant SEC_OTFDEC1_OTFDEC_IER_XONEIE                    \ Execute-only execute-never error interrupt enable This bit is read and written by application. It controls the OTFDEC interrupt generation when XONEIF flag status is set.
$00000004 constant SEC_OTFDEC1_OTFDEC_IER_KEIE                      \ Key error interrupt enable This bit is read and written by application. It controls the OTFDEC interrupt generation when KEIF flag status is set.


\
\ @brief On-The-Fly Decryption engine
\
$56005000 constant SEC_OTFDEC1_OTFDEC_CR  \ offset: 0x00 : OTFDEC control register
$56005010 constant SEC_OTFDEC1_OTFDEC_PRIVCFGR  \ offset: 0x10 : OTFDEC_PRIVCFGR
$56005020 constant SEC_OTFDEC1_OTFDEC_R1CFGR  \ offset: 0x20 : OTFDEC region 1 configuration register
$56005024 constant SEC_OTFDEC1_OTFDEC_R1STARTADDR  \ offset: 0x24 : OTFDEC region 1 start address register
$56005028 constant SEC_OTFDEC1_OTFDEC_R1ENDADDR  \ offset: 0x28 : OTFDEC region 1 end address register
$5600502c constant SEC_OTFDEC1_OTFDEC_R1NONCER0  \ offset: 0x2C : OTFDEC region 1 nonce register 0
$56005030 constant SEC_OTFDEC1_OTFDEC_R1NONCER1  \ offset: 0x30 : OTFDEC region 1 nonce register 1
$56005034 constant SEC_OTFDEC1_OTFDEC_R1KEYR0  \ offset: 0x34 : OTFDEC region 1 key register 0
$56005038 constant SEC_OTFDEC1_OTFDEC_R1KEYR1  \ offset: 0x38 : OTFDEC region 1 key register 1
$5600503c constant SEC_OTFDEC1_OTFDEC_R1KEYR2  \ offset: 0x3C : OTFDEC region 1 key register 2
$56005040 constant SEC_OTFDEC1_OTFDEC_R1KEYR3  \ offset: 0x40 : OTFDEC region 1 key register 3
$56005050 constant SEC_OTFDEC1_OTFDEC_R2CFGR  \ offset: 0x50 : OTFDEC region 2 configuration register
$56005054 constant SEC_OTFDEC1_OTFDEC_R2STARTADDR  \ offset: 0x54 : OTFDEC region 2 start address register
$56005058 constant SEC_OTFDEC1_OTFDEC_R2ENDADDR  \ offset: 0x58 : OTFDEC region 2 end address register
$5600505c constant SEC_OTFDEC1_OTFDEC_R2NONCER0  \ offset: 0x5C : OTFDEC region 2 nonce register 0
$56005060 constant SEC_OTFDEC1_OTFDEC_R2NONCER1  \ offset: 0x60 : OTFDEC region 2 nonce register 1
$56005064 constant SEC_OTFDEC1_OTFDEC_R2KEYR0  \ offset: 0x64 : OTFDEC region 2 key register 0
$56005068 constant SEC_OTFDEC1_OTFDEC_R2KEYR1  \ offset: 0x68 : OTFDEC region 2 key register 1
$5600506c constant SEC_OTFDEC1_OTFDEC_R2KEYR2  \ offset: 0x6C : OTFDEC region 2 key register 2
$56005070 constant SEC_OTFDEC1_OTFDEC_R2KEYR3  \ offset: 0x70 : OTFDEC region 2 key register 3
$56005080 constant SEC_OTFDEC1_OTFDEC_R3CFGR  \ offset: 0x80 : OTFDEC region 3 configuration register
$56005084 constant SEC_OTFDEC1_OTFDEC_R3STARTADDR  \ offset: 0x84 : OTFDEC region 3 start address register
$56005088 constant SEC_OTFDEC1_OTFDEC_R3ENDADDR  \ offset: 0x88 : OTFDEC region 3 end address register
$5600508c constant SEC_OTFDEC1_OTFDEC_R3NONCER0  \ offset: 0x8C : OTFDEC region 3 nonce register 0
$56005090 constant SEC_OTFDEC1_OTFDEC_R3NONCER1  \ offset: 0x90 : OTFDEC region 3 nonce register 1
$56005094 constant SEC_OTFDEC1_OTFDEC_R3KEYR0  \ offset: 0x94 : OTFDEC region 3 key register 0
$56005098 constant SEC_OTFDEC1_OTFDEC_R3KEYR1  \ offset: 0x98 : OTFDEC region 3 key register 1
$5600509c constant SEC_OTFDEC1_OTFDEC_R3KEYR2  \ offset: 0x9C : OTFDEC region 3 key register 2
$560050a0 constant SEC_OTFDEC1_OTFDEC_R3KEYR3  \ offset: 0xA0 : OTFDEC region 3 key register 3
$560050b0 constant SEC_OTFDEC1_OTFDEC_R4CFGR  \ offset: 0xB0 : OTFDEC region 4 configuration register
$560050b4 constant SEC_OTFDEC1_OTFDEC_R4STARTADDR  \ offset: 0xB4 : OTFDEC region 4 start address register
$560050b8 constant SEC_OTFDEC1_OTFDEC_R4ENDADDR  \ offset: 0xB8 : OTFDEC region 4 end address register
$560050bc constant SEC_OTFDEC1_OTFDEC_R4NONCER0  \ offset: 0xBC : OTFDEC region 4 nonce register 0
$560050c0 constant SEC_OTFDEC1_OTFDEC_R4NONCER1  \ offset: 0xC0 : OTFDEC region 4 nonce register 1
$560050c4 constant SEC_OTFDEC1_OTFDEC_R4KEYR0  \ offset: 0xC4 : OTFDEC region 4 key register 0
$560050c8 constant SEC_OTFDEC1_OTFDEC_R4KEYR1  \ offset: 0xC8 : OTFDEC region 4 key register 1
$560050cc constant SEC_OTFDEC1_OTFDEC_R4KEYR2  \ offset: 0xCC : OTFDEC region 4 key register 2
$560050d0 constant SEC_OTFDEC1_OTFDEC_R4KEYR3  \ offset: 0xD0 : OTFDEC region 4 key register 3
$56005300 constant SEC_OTFDEC1_OTFDEC_ISR  \ offset: 0x300 : OTFDEC interrupt status register
$56005304 constant SEC_OTFDEC1_OTFDEC_ICR  \ offset: 0x304 : OTFDEC interrupt clear register
$56005308 constant SEC_OTFDEC1_OTFDEC_IER  \ offset: 0x308 : OTFDEC interrupt enable register

