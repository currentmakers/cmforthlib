\
\ @file otfdec_s.fs
\ @brief OTFDEC register bank
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

$00000001 constant OTFDEC_S_OTFDEC_CR_ENC                           \ Encryption mode bit


\
\ @brief OTFDEC privileged access control configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC_S_OTFDEC_PRIVCFGR_PRIV                    \ Privileged access protection.


\
\ @brief OTFDEC region 1 configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC_S_OTFDEC_R1CFGR_REG_EN                    \ region on-the-fly decryption enable
$00000002 constant OTFDEC_S_OTFDEC_R1CFGR_CONFIGLOCK                \ region config lock
$00000004 constant OTFDEC_S_OTFDEC_R1CFGR_KEYLOCK                   \ region key lock
$00000030 constant OTFDEC_S_OTFDEC_R1CFGR_MODE                      \ operating mode
$0000ff00 constant OTFDEC_S_OTFDEC_R1CFGR_KEYCRC                    \ region key 8-bit CRC
$ffff0000 constant OTFDEC_S_OTFDEC_R1CFGR_REG_VERSION               \ region firmware version


\
\ @brief OTFDEC region 1 start address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R1STARTADDR_REG_START_ADDR       \ Region AHB start address


\
\ @brief OTFDEC region 1 end address register
\ Address offset: 0x28
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC_S_OTFDEC_R1ENDADDR_REG_END_ADDR           \ Region AHB end address


\
\ @brief OTFDEC region 1 nonce register 0
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R1NONCER0_REG_NONCE              \ Region nonce, bits [31:0]


\
\ @brief OTFDEC region 1 nonce register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R1NONCER1_REG_NONCE              \ Region nonce, bits [63:32]


\
\ @brief OTFDEC region 1 key register 0
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R1KEYR0_REG_KEY                  \ Region key, bits [31:0]


\
\ @brief OTFDEC region 1 key register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R1KEYR1_REG_KEY                  \ Region key, bits [63:32]


\
\ @brief OTFDEC region 1 key register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R1KEYR2_REG_KEY                  \ Region key, bits [95:64]


\
\ @brief OTFDEC region 1 key register 3
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R1KEYR3_REG_KEY                  \ Region key, bits [127:96]


\
\ @brief OTFDEC region 2 configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC_S_OTFDEC_R2CFGR_REG_EN                    \ region on-the-fly decryption enable
$00000002 constant OTFDEC_S_OTFDEC_R2CFGR_CONFIGLOCK                \ region config lock
$00000004 constant OTFDEC_S_OTFDEC_R2CFGR_KEYLOCK                   \ region key lock
$00000030 constant OTFDEC_S_OTFDEC_R2CFGR_MODE                      \ operating mode
$0000ff00 constant OTFDEC_S_OTFDEC_R2CFGR_KEYCRC                    \ region key 8-bit CRC
$ffff0000 constant OTFDEC_S_OTFDEC_R2CFGR_REG_VERSION               \ region firmware version


\
\ @brief OTFDEC region 2 start address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R2STARTADDR_REG_START_ADDR       \ Region AHB start address


\
\ @brief OTFDEC region 2 end address register
\ Address offset: 0x58
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC_S_OTFDEC_R2ENDADDR_REG_END_ADDR           \ Region AHB end address


\
\ @brief OTFDEC region 2 nonce register 0
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R2NONCER0_REG_NONCE              \ Region nonce, bits [31:0]


\
\ @brief OTFDEC region 2 nonce register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R2NONCER1_REG_NONCE              \ Region nonce, bits [63:32]


\
\ @brief OTFDEC region 2 key register 0
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R2KEYR0_REG_KEY                  \ Region key, bits [31:0]


\
\ @brief OTFDEC region 2 key register 1
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R2KEYR1_REG_KEY                  \ Region key, bits [63:32]


\
\ @brief OTFDEC region 2 key register 2
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R2KEYR2_REG_KEY                  \ Region key, bits [95:64]


\
\ @brief OTFDEC region 2 key register 3
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R2KEYR3_REG_KEY                  \ Region key, bits [127:96]


\
\ @brief OTFDEC region 3 configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC_S_OTFDEC_R3CFGR_REG_EN                    \ region on-the-fly decryption enable
$00000002 constant OTFDEC_S_OTFDEC_R3CFGR_CONFIGLOCK                \ region config lock
$00000004 constant OTFDEC_S_OTFDEC_R3CFGR_KEYLOCK                   \ region key lock
$00000030 constant OTFDEC_S_OTFDEC_R3CFGR_MODE                      \ operating mode
$0000ff00 constant OTFDEC_S_OTFDEC_R3CFGR_KEYCRC                    \ region key 8-bit CRC
$ffff0000 constant OTFDEC_S_OTFDEC_R3CFGR_REG_VERSION               \ region firmware version


\
\ @brief OTFDEC region 3 start address register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R3STARTADDR_REG_START_ADDR       \ Region AHB start address


\
\ @brief OTFDEC region 3 end address register
\ Address offset: 0x88
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC_S_OTFDEC_R3ENDADDR_REG_END_ADDR           \ Region AHB end address


\
\ @brief OTFDEC region 3 nonce register 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R3NONCER0_REG_NONCE              \ Region nonce, bits [31:0]


\
\ @brief OTFDEC region 3 nonce register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R3NONCER1_REG_NONCE              \ Region nonce, bits [63:32]


\
\ @brief OTFDEC region 3 key register 0
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R3KEYR0_REG_KEY                  \ Region key, bits [31:0]


\
\ @brief OTFDEC region 3 key register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R3KEYR1_REG_KEY                  \ Region key, bits [63:32]


\
\ @brief OTFDEC region 3 key register 2
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R3KEYR2_REG_KEY                  \ Region key, bits [95:64]


\
\ @brief OTFDEC region 3 key register 3
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R3KEYR3_REG_KEY                  \ Region key, bits [127:96]


\
\ @brief OTFDEC region 4 configuration register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC_S_OTFDEC_R4CFGR_REG_EN                    \ region on-the-fly decryption enable
$00000002 constant OTFDEC_S_OTFDEC_R4CFGR_CONFIGLOCK                \ region config lock
$00000004 constant OTFDEC_S_OTFDEC_R4CFGR_KEYLOCK                   \ region key lock
$00000030 constant OTFDEC_S_OTFDEC_R4CFGR_MODE                      \ operating mode
$0000ff00 constant OTFDEC_S_OTFDEC_R4CFGR_KEYCRC                    \ region key 8-bit CRC
$ffff0000 constant OTFDEC_S_OTFDEC_R4CFGR_REG_VERSION               \ region firmware version


\
\ @brief OTFDEC region 4 start address register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R4STARTADDR_REG_START_ADDR       \ Region AHB start address


\
\ @brief OTFDEC region 4 end address register
\ Address offset: 0xB8
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC_S_OTFDEC_R4ENDADDR_REG_END_ADDR           \ Region AHB end address


\
\ @brief OTFDEC region 4 nonce register 0
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R4NONCER0_REG_NONCE              \ Region nonce, bits [31:0]


\
\ @brief OTFDEC region 4 nonce register 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R4NONCER1_REG_NONCE              \ Region nonce, bits [63:32]


\
\ @brief OTFDEC region 4 key register 0
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R4KEYR0_REG_KEY                  \ Region key, bits [31:0]


\
\ @brief OTFDEC region 4 key register 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R4KEYR1_REG_KEY                  \ Region key, bits [63:32]


\
\ @brief OTFDEC region 4 key register 2
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R4KEYR2_REG_KEY                  \ Region key, bits [95:64]


\
\ @brief OTFDEC region 4 key register 3
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC_S_OTFDEC_R4KEYR3_REG_KEY                  \ Region key, bits [127:96]


\
\ @brief OTFDEC interrupt status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC_S_OTFDEC_ISR_SEIF                         \ Security error interrupt flag status
$00000002 constant OTFDEC_S_OTFDEC_ISR_XONEIF                       \ Execute-only execute-never error interrupt flag status
$00000004 constant OTFDEC_S_OTFDEC_ISR_KEIF                         \ Key error interrupt flag status


\
\ @brief OTFDEC interrupt clear register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC_S_OTFDEC_ICR_SEIF                         \ Security error interrupt flag clear
$00000002 constant OTFDEC_S_OTFDEC_ICR_XONEIF                       \ Execute-only execute-never error interrupt flag clear
$00000004 constant OTFDEC_S_OTFDEC_ICR_KEIF                         \ Key error interrupt flag clear


\
\ @brief OTFDEC interrupt enable register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC_S_OTFDEC_IER_SEIE                         \ Security error interrupt enable
$00000002 constant OTFDEC_S_OTFDEC_IER_XONEIE                       \ Execute-only execute-never error interrupt enable
$00000004 constant OTFDEC_S_OTFDEC_IER_KEIE                         \ Key error interrupt enable


\
\ @brief OTFDEC register bank
\
$56005000 constant OTFDEC_S_OTFDEC_CR  \ offset: 0x00 : OTFDEC control register
$56005010 constant OTFDEC_S_OTFDEC_PRIVCFGR  \ offset: 0x10 : OTFDEC privileged access control configuration register
$56005020 constant OTFDEC_S_OTFDEC_R1CFGR  \ offset: 0x20 : OTFDEC region 1 configuration register
$56005024 constant OTFDEC_S_OTFDEC_R1STARTADDR  \ offset: 0x24 : OTFDEC region 1 start address register
$56005028 constant OTFDEC_S_OTFDEC_R1ENDADDR  \ offset: 0x28 : OTFDEC region 1 end address register
$5600502c constant OTFDEC_S_OTFDEC_R1NONCER0  \ offset: 0x2C : OTFDEC region 1 nonce register 0
$56005030 constant OTFDEC_S_OTFDEC_R1NONCER1  \ offset: 0x30 : OTFDEC region 1 nonce register 1
$56005034 constant OTFDEC_S_OTFDEC_R1KEYR0  \ offset: 0x34 : OTFDEC region 1 key register 0
$56005038 constant OTFDEC_S_OTFDEC_R1KEYR1  \ offset: 0x38 : OTFDEC region 1 key register 1
$5600503c constant OTFDEC_S_OTFDEC_R1KEYR2  \ offset: 0x3C : OTFDEC region 1 key register 2
$56005040 constant OTFDEC_S_OTFDEC_R1KEYR3  \ offset: 0x40 : OTFDEC region 1 key register 3
$56005050 constant OTFDEC_S_OTFDEC_R2CFGR  \ offset: 0x50 : OTFDEC region 2 configuration register
$56005054 constant OTFDEC_S_OTFDEC_R2STARTADDR  \ offset: 0x54 : OTFDEC region 2 start address register
$56005058 constant OTFDEC_S_OTFDEC_R2ENDADDR  \ offset: 0x58 : OTFDEC region 2 end address register
$5600505c constant OTFDEC_S_OTFDEC_R2NONCER0  \ offset: 0x5C : OTFDEC region 2 nonce register 0
$56005060 constant OTFDEC_S_OTFDEC_R2NONCER1  \ offset: 0x60 : OTFDEC region 2 nonce register 1
$56005064 constant OTFDEC_S_OTFDEC_R2KEYR0  \ offset: 0x64 : OTFDEC region 2 key register 0
$56005068 constant OTFDEC_S_OTFDEC_R2KEYR1  \ offset: 0x68 : OTFDEC region 2 key register 1
$5600506c constant OTFDEC_S_OTFDEC_R2KEYR2  \ offset: 0x6C : OTFDEC region 2 key register 2
$56005070 constant OTFDEC_S_OTFDEC_R2KEYR3  \ offset: 0x70 : OTFDEC region 2 key register 3
$56005080 constant OTFDEC_S_OTFDEC_R3CFGR  \ offset: 0x80 : OTFDEC region 3 configuration register
$56005084 constant OTFDEC_S_OTFDEC_R3STARTADDR  \ offset: 0x84 : OTFDEC region 3 start address register
$56005088 constant OTFDEC_S_OTFDEC_R3ENDADDR  \ offset: 0x88 : OTFDEC region 3 end address register
$5600508c constant OTFDEC_S_OTFDEC_R3NONCER0  \ offset: 0x8C : OTFDEC region 3 nonce register 0
$56005090 constant OTFDEC_S_OTFDEC_R3NONCER1  \ offset: 0x90 : OTFDEC region 3 nonce register 1
$56005094 constant OTFDEC_S_OTFDEC_R3KEYR0  \ offset: 0x94 : OTFDEC region 3 key register 0
$56005098 constant OTFDEC_S_OTFDEC_R3KEYR1  \ offset: 0x98 : OTFDEC region 3 key register 1
$5600509c constant OTFDEC_S_OTFDEC_R3KEYR2  \ offset: 0x9C : OTFDEC region 3 key register 2
$560050a0 constant OTFDEC_S_OTFDEC_R3KEYR3  \ offset: 0xA0 : OTFDEC region 3 key register 3
$560050b0 constant OTFDEC_S_OTFDEC_R4CFGR  \ offset: 0xB0 : OTFDEC region 4 configuration register
$560050b4 constant OTFDEC_S_OTFDEC_R4STARTADDR  \ offset: 0xB4 : OTFDEC region 4 start address register
$560050b8 constant OTFDEC_S_OTFDEC_R4ENDADDR  \ offset: 0xB8 : OTFDEC region 4 end address register
$560050bc constant OTFDEC_S_OTFDEC_R4NONCER0  \ offset: 0xBC : OTFDEC region 4 nonce register 0
$560050c0 constant OTFDEC_S_OTFDEC_R4NONCER1  \ offset: 0xC0 : OTFDEC region 4 nonce register 1
$560050c4 constant OTFDEC_S_OTFDEC_R4KEYR0  \ offset: 0xC4 : OTFDEC region 4 key register 0
$560050c8 constant OTFDEC_S_OTFDEC_R4KEYR1  \ offset: 0xC8 : OTFDEC region 4 key register 1
$560050cc constant OTFDEC_S_OTFDEC_R4KEYR2  \ offset: 0xCC : OTFDEC region 4 key register 2
$560050d0 constant OTFDEC_S_OTFDEC_R4KEYR3  \ offset: 0xD0 : OTFDEC region 4 key register 3
$56005300 constant OTFDEC_S_OTFDEC_ISR  \ offset: 0x300 : OTFDEC interrupt status register
$56005304 constant OTFDEC_S_OTFDEC_ICR  \ offset: 0x304 : OTFDEC interrupt clear register
$56005308 constant OTFDEC_S_OTFDEC_IER  \ offset: 0x308 : OTFDEC interrupt enable register

