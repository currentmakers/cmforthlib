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

$00000001 constant SEC_OTFDEC1_CR_ENC                               \ Encryption mode bit


\
\ @brief OTFDEC privileged access control configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_PRIVCFGR_PRIV                        \ Encryption mode bit


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_R1CFGR_REG_EN                        \ region on-the-fly decryption enable
$00000002 constant SEC_OTFDEC1_R1CFGR_CONFIGLOCK                    \ region config lock
$00000004 constant SEC_OTFDEC1_R1CFGR_KEYLOCK                       \ region key lock
$00000030 constant SEC_OTFDEC1_R1CFGR_MODE                          \ operating mode
$0000ff00 constant SEC_OTFDEC1_R1CFGR_KEYCRC                        \ region key 8-bit CRC
$ffff0000 constant SEC_OTFDEC1_R1CFGR_REGX_VERSION                  \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R1STARTADDR_REGX_START_ADDR          \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x28
\ Reset value: 0x00000FFF
\

$00000000 constant SEC_OTFDEC1_R1ENDADDR_REGX_END_ADDR              \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R1NONCER0_REGX_NONCE                 \ REGx_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R1NONCER1_REGX_NONCE                 \ Region nonce


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R1KEYR0_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R1KEYR1_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R1KEYR2_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R1KEYR3_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_R2CFGR_REG_EN                        \ region on-the-fly decryption enable
$00000002 constant SEC_OTFDEC1_R2CFGR_CONFIGLOCK                    \ region config lock
$00000004 constant SEC_OTFDEC1_R2CFGR_KEYLOCK                       \ region key lock
$00000030 constant SEC_OTFDEC1_R2CFGR_MODE                          \ operating mode
$0000ff00 constant SEC_OTFDEC1_R2CFGR_KEYCRC                        \ region key 8-bit CRC
$ffff0000 constant SEC_OTFDEC1_R2CFGR_REGX_VERSION                  \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R2STARTADDR_REGX_START_ADDR          \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x58
\ Reset value: 0x00000FFF
\

$00000000 constant SEC_OTFDEC1_R2ENDADDR_REGX_END_ADDR              \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R2NONCER0_REGX_NONCE                 \ REGx_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R2NONCER1_REGX_NONCE                 \ Region nonce, bits [63:32]REGx_NONCE[63:32]


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R2KEYR0_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R2KEYR1_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R2KEYR2_REGX_KEY_                    \ REGx_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R2KEYR3_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_R3CFGR_REG_EN                        \ region on-the-fly decryption enable
$00000002 constant SEC_OTFDEC1_R3CFGR_CONFIGLOCK                    \ region config lock
$00000004 constant SEC_OTFDEC1_R3CFGR_KEYLOCK                       \ region key lock
$00000030 constant SEC_OTFDEC1_R3CFGR_MODE                          \ operating mode
$0000ff00 constant SEC_OTFDEC1_R3CFGR_KEYCRC                        \ region key 8-bit CRC
$ffff0000 constant SEC_OTFDEC1_R3CFGR_REGX_VERSION                  \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R3STARTADDR_REGX_START_ADDR          \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x88
\ Reset value: 0x00000FFF
\

$00000000 constant SEC_OTFDEC1_R3ENDADDR_REGX_END_ADDR              \ Region AXI end address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x8C
\ Reset value: 0x00000FFF
\

$00000000 constant SEC_OTFDEC1_R4ENDADDR_REGX_END_ADDR              \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R3NONCER0_REGX_NONCE                 \ REGx_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R3NONCER1_REGX_NONCE                 \ REGx_NONCE


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R3KEYR0_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R3KEYR1_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R3KEYR2_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R3KEYR3_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_R4CFGR_REG_EN                        \ region on-the-fly decryption enable
$00000002 constant SEC_OTFDEC1_R4CFGR_CONFIGLOCK                    \ region config lock
$00000004 constant SEC_OTFDEC1_R4CFGR_KEYLOCK                       \ region key lock
$00000030 constant SEC_OTFDEC1_R4CFGR_MODE                          \ operating mode
$0000ff00 constant SEC_OTFDEC1_R4CFGR_KEYCRC                        \ region key 8-bit CRC
$ffff0000 constant SEC_OTFDEC1_R4CFGR_REGX_VERSION                  \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R4STARTADDR_REGX_START_ADDR          \ Region AXI start address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R4NONCER0_REGX_NONCE                 \ REGx_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R4NONCER1_REGX_NONCE                 \ REGx_NONCE


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R4KEYR0_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R4KEYR1_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R4KEYR2_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant SEC_OTFDEC1_R4KEYR3_REGX_KEY                     \ REGx_KEY


\
\ @brief OTFDEC interrupt status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_ISR_SEIF                             \ Security Error Interrupt Flag status
$00000002 constant SEC_OTFDEC1_ISR_XONEIF                           \ Execute-only execute-Never Error Interrupt Flag status
$00000004 constant SEC_OTFDEC1_ISR_KEIF                             \ Key Error Interrupt Flag status


\
\ @brief OTFDEC interrupt clear register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_ICR_SEIF                             \ SEIF
$00000002 constant SEC_OTFDEC1_ICR_XONEIF                           \ Execute-only execute-Never Error Interrupt Flag clear
$00000004 constant SEC_OTFDEC1_ICR_KEIF                             \ KEIF


\
\ @brief OTFDEC interrupt enable register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant SEC_OTFDEC1_IER_SEIE                             \ Security Error Interrupt Enable
$00000002 constant SEC_OTFDEC1_IER_XONEIE                           \ XONEIE
$00000004 constant SEC_OTFDEC1_IER_KEIE                             \ KEIE


\
\ @brief On-The-Fly Decryption engine
\
$520c5000 constant SEC_OTFDEC1_CR  \ offset: 0x00 : OTFDEC control register
$520c5010 constant SEC_OTFDEC1_PRIVCFGR  \ offset: 0x10 : OTFDEC privileged access control configuration register
$520c5020 constant SEC_OTFDEC1_R1CFGR  \ offset: 0x20 : OTFDEC region x configuration register
$520c5024 constant SEC_OTFDEC1_R1STARTADDR  \ offset: 0x24 : OTFDEC region x start address register
$520c5028 constant SEC_OTFDEC1_R1ENDADDR  \ offset: 0x28 : OTFDEC region x end address register
$520c502c constant SEC_OTFDEC1_R1NONCER0  \ offset: 0x2C : OTFDEC region x nonce register 0
$520c5030 constant SEC_OTFDEC1_R1NONCER1  \ offset: 0x30 : OTFDEC region x nonce register 1
$520c5034 constant SEC_OTFDEC1_R1KEYR0  \ offset: 0x34 : OTFDEC region x key register 0
$520c5038 constant SEC_OTFDEC1_R1KEYR1  \ offset: 0x38 : OTFDEC region x key register 1
$520c503c constant SEC_OTFDEC1_R1KEYR2  \ offset: 0x3C : OTFDEC region x key register 2
$520c5040 constant SEC_OTFDEC1_R1KEYR3  \ offset: 0x40 : OTFDEC region x key register 3
$520c5050 constant SEC_OTFDEC1_R2CFGR  \ offset: 0x50 : OTFDEC region x configuration register
$520c5054 constant SEC_OTFDEC1_R2STARTADDR  \ offset: 0x54 : OTFDEC region x start address register
$520c5058 constant SEC_OTFDEC1_R2ENDADDR  \ offset: 0x58 : OTFDEC region x end address register
$520c505c constant SEC_OTFDEC1_R2NONCER0  \ offset: 0x5C : OTFDEC region x nonce register 0
$520c5060 constant SEC_OTFDEC1_R2NONCER1  \ offset: 0x60 : OTFDEC region x nonce register 1
$520c5064 constant SEC_OTFDEC1_R2KEYR0  \ offset: 0x64 : OTFDEC region x key register 0
$520c5068 constant SEC_OTFDEC1_R2KEYR1  \ offset: 0x68 : OTFDEC region x key register 1
$520c506c constant SEC_OTFDEC1_R2KEYR2  \ offset: 0x6C : OTFDEC region x key register 2
$520c5070 constant SEC_OTFDEC1_R2KEYR3  \ offset: 0x70 : OTFDEC region x key register 3
$520c5080 constant SEC_OTFDEC1_R3CFGR  \ offset: 0x80 : OTFDEC region x configuration register
$520c5084 constant SEC_OTFDEC1_R3STARTADDR  \ offset: 0x84 : OTFDEC region x start address register
$520c5088 constant SEC_OTFDEC1_R3ENDADDR  \ offset: 0x88 : OTFDEC region x end address register
$520c508c constant SEC_OTFDEC1_R4ENDADDR  \ offset: 0x8C : OTFDEC region x end address register
$520c508c constant SEC_OTFDEC1_R3NONCER0  \ offset: 0x8C : OTFDEC region x nonce register 0
$520c5090 constant SEC_OTFDEC1_R3NONCER1  \ offset: 0x90 : OTFDEC region x nonce register 1
$520c5094 constant SEC_OTFDEC1_R3KEYR0  \ offset: 0x94 : OTFDEC region x key register 0
$520c5098 constant SEC_OTFDEC1_R3KEYR1  \ offset: 0x98 : OTFDEC region x key register 1
$520c509c constant SEC_OTFDEC1_R3KEYR2  \ offset: 0x9C : OTFDEC region x key register 2
$520c50a0 constant SEC_OTFDEC1_R3KEYR3  \ offset: 0xA0 : OTFDEC region x key register 3
$520c50b0 constant SEC_OTFDEC1_R4CFGR  \ offset: 0xB0 : OTFDEC region x configuration register
$520c50b4 constant SEC_OTFDEC1_R4STARTADDR  \ offset: 0xB4 : OTFDEC region x start address register
$520c50bc constant SEC_OTFDEC1_R4NONCER0  \ offset: 0xBC : OTFDEC region x nonce register 0
$520c50c0 constant SEC_OTFDEC1_R4NONCER1  \ offset: 0xC0 : OTFDEC region x nonce register 1
$520c50c4 constant SEC_OTFDEC1_R4KEYR0  \ offset: 0xC4 : OTFDEC region x key register 0
$520c50c8 constant SEC_OTFDEC1_R4KEYR1  \ offset: 0xC8 : OTFDEC region x key register 1
$520c50cc constant SEC_OTFDEC1_R4KEYR2  \ offset: 0xCC : OTFDEC region x key register 2
$520c50d0 constant SEC_OTFDEC1_R4KEYR3  \ offset: 0xD0 : OTFDEC region x key register 3
$520c5300 constant SEC_OTFDEC1_ISR  \ offset: 0x300 : OTFDEC interrupt status register
$520c5304 constant SEC_OTFDEC1_ICR  \ offset: 0x304 : OTFDEC interrupt clear register
$520c5308 constant SEC_OTFDEC1_IER  \ offset: 0x308 : OTFDEC interrupt enable register

