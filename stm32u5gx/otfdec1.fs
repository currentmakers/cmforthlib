\
\ @file otfdec1.fs
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

$00000001 constant OTFDEC1_CR_ENC                                   \ Encryption mode bit


\
\ @brief OTFDEC privileged access control configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC1_PRIVCFGR_PRIV                            \ Encryption mode bit


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC1_R1CFGR_REG_EN                            \ region on-the-fly decryption enable
$00000002 constant OTFDEC1_R1CFGR_CONFIGLOCK                        \ region config lock
$00000004 constant OTFDEC1_R1CFGR_KEYLOCK                           \ region key lock
$00000030 constant OTFDEC1_R1CFGR_MODE                              \ operating mode
$0000ff00 constant OTFDEC1_R1CFGR_KEYCRC                            \ region key 8-bit CRC
$ffff0000 constant OTFDEC1_R1CFGR_REG1_VERSION                      \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R1STARTADDR_REG1_START_ADDR              \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x28
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC1_R1ENDADDR_REG1_END_ADDR                  \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R1NONCER0_REG1_NONCE                     \ REG1_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R1NONCER1_REG1_NONCE                     \ Region nonce


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R1KEYR0_REG1_KEY                         \ REG1_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R1KEYR1_REG1_KEY                         \ REG1_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R1KEYR2_REG1_KEY                         \ REG1_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R1KEYR3_REG1_KEY                         \ REG1_KEY


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC1_R2CFGR_REG_EN                            \ region on-the-fly decryption enable
$00000002 constant OTFDEC1_R2CFGR_CONFIGLOCK                        \ region config lock
$00000004 constant OTFDEC1_R2CFGR_KEYLOCK                           \ region key lock
$00000030 constant OTFDEC1_R2CFGR_MODE                              \ operating mode
$0000ff00 constant OTFDEC1_R2CFGR_KEYCRC                            \ region key 8-bit CRC
$ffff0000 constant OTFDEC1_R2CFGR_REG2_VERSION                      \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R2STARTADDR_REG2_START_ADDR              \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x58
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC1_R2ENDADDR_REG2_END_ADDR                  \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R2NONCER0_REG2_NONCE                     \ REG2_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R2NONCER1_REG2_NONCE                     \ Region nonce, bits [63:32]REGx_NONCE[63:32]


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R2KEYR0_REG2_KEY                         \ REG2_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R2KEYR1_REG2_KEY                         \ REG2_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R2KEYR2_REG2_KEY_                        \ REG2_KEY_


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R2KEYR3_REG2_KEY                         \ REG2_KEY


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC1_R3CFGR_REG_EN                            \ region on-the-fly decryption enable
$00000002 constant OTFDEC1_R3CFGR_CONFIGLOCK                        \ region config lock
$00000004 constant OTFDEC1_R3CFGR_KEYLOCK                           \ region key lock
$00000030 constant OTFDEC1_R3CFGR_MODE                              \ operating mode
$0000ff00 constant OTFDEC1_R3CFGR_KEYCRC                            \ region key 8-bit CRC
$ffff0000 constant OTFDEC1_R3CFGR_REG3_VERSION                      \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R3STARTADDR_REG3_START_ADDR              \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x88
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC1_R3ENDADDR_REG3_END_ADDR                  \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R3NONCER0_REG3_NONCE                     \ REG3_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R3NONCER1_REG3_NONCE                     \ REG3_NONCE


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R3KEYR0_REG3_KEY                         \ REG3_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R3KEYR1_REG3_KEY                         \ REG3_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R3KEYR2_REG3_KEY                         \ REG3_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R3KEYR3_REG3_KEY                         \ REG3_KEY


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC1_R4CFGR_REG_EN                            \ region on-the-fly decryption enable
$00000002 constant OTFDEC1_R4CFGR_CONFIGLOCK                        \ region config lock
$00000004 constant OTFDEC1_R4CFGR_KEYLOCK                           \ region key lock
$00000030 constant OTFDEC1_R4CFGR_MODE                              \ operating mode
$0000ff00 constant OTFDEC1_R4CFGR_KEYCRC                            \ region key 8-bit CRC
$ffff0000 constant OTFDEC1_R4CFGR_REG4_VERSION                      \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R4STARTADDR_REG4_START_ADDR              \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0xB8
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC1_R4ENDADDR_REG4_END_ADDR                  \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R4NONCER0_REG4_NONCE                     \ REG4_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R4NONCER1_REG4_NONCE                     \ REG4_NONCE


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R4KEYR0_REG4_KEY                         \ REG4_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R4KEYR1_REG4_KEY                         \ REG4_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R4KEYR2_REG4_KEY                         \ REG4_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC1_R4KEYR3_REG4_KEY                         \ REG4_KEY


\
\ @brief OTFDEC interrupt status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC1_ISR_SEIF                                 \ Security Error Interrupt Flag status
$00000002 constant OTFDEC1_ISR_XONEIF                               \ Execute-only execute-Never Error Interrupt Flag status
$00000004 constant OTFDEC1_ISR_KEIF                                 \ Key Error Interrupt Flag status


\
\ @brief OTFDEC interrupt clear register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC1_ICR_SEIF                                 \ SEIF
$00000002 constant OTFDEC1_ICR_XONEIF                               \ Execute-only execute-Never Error Interrupt Flag clear
$00000004 constant OTFDEC1_ICR_KEIF                                 \ KEIF


\
\ @brief OTFDEC interrupt enable register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC1_IER_SEIE                                 \ Security Error Interrupt Enable
$00000002 constant OTFDEC1_IER_XONEIE                               \ XONEIE
$00000004 constant OTFDEC1_IER_KEIE                                 \ KEIE


\
\ @brief On-The-Fly Decryption engine
\
$420c5000 constant OTFDEC1_CR     \ offset: 0x00 : OTFDEC control register
$420c5010 constant OTFDEC1_PRIVCFGR  \ offset: 0x10 : OTFDEC privileged access control configuration register
$420c5020 constant OTFDEC1_R1CFGR  \ offset: 0x20 : OTFDEC region x configuration register
$420c5024 constant OTFDEC1_R1STARTADDR  \ offset: 0x24 : OTFDEC region x start address register
$420c5028 constant OTFDEC1_R1ENDADDR  \ offset: 0x28 : OTFDEC region x end address register
$420c502c constant OTFDEC1_R1NONCER0  \ offset: 0x2C : OTFDEC region x nonce register 0
$420c5030 constant OTFDEC1_R1NONCER1  \ offset: 0x30 : OTFDEC region x nonce register 1
$420c5034 constant OTFDEC1_R1KEYR0  \ offset: 0x34 : OTFDEC region x key register 0
$420c5038 constant OTFDEC1_R1KEYR1  \ offset: 0x38 : OTFDEC region x key register 1
$420c503c constant OTFDEC1_R1KEYR2  \ offset: 0x3C : OTFDEC region x key register 2
$420c5040 constant OTFDEC1_R1KEYR3  \ offset: 0x40 : OTFDEC region x key register 3
$420c5050 constant OTFDEC1_R2CFGR  \ offset: 0x50 : OTFDEC region x configuration register
$420c5054 constant OTFDEC1_R2STARTADDR  \ offset: 0x54 : OTFDEC region x start address register
$420c5058 constant OTFDEC1_R2ENDADDR  \ offset: 0x58 : OTFDEC region x end address register
$420c505c constant OTFDEC1_R2NONCER0  \ offset: 0x5C : OTFDEC region x nonce register 0
$420c5060 constant OTFDEC1_R2NONCER1  \ offset: 0x60 : OTFDEC region x nonce register 1
$420c5064 constant OTFDEC1_R2KEYR0  \ offset: 0x64 : OTFDEC region x key register 0
$420c5068 constant OTFDEC1_R2KEYR1  \ offset: 0x68 : OTFDEC region x key register 1
$420c506c constant OTFDEC1_R2KEYR2  \ offset: 0x6C : OTFDEC region x key register 2
$420c5070 constant OTFDEC1_R2KEYR3  \ offset: 0x70 : OTFDEC region x key register 3
$420c5080 constant OTFDEC1_R3CFGR  \ offset: 0x80 : OTFDEC region x configuration register
$420c5084 constant OTFDEC1_R3STARTADDR  \ offset: 0x84 : OTFDEC region x start address register
$420c5088 constant OTFDEC1_R3ENDADDR  \ offset: 0x88 : OTFDEC region x end address register
$420c508c constant OTFDEC1_R3NONCER0  \ offset: 0x8C : OTFDEC region x nonce register 0
$420c5090 constant OTFDEC1_R3NONCER1  \ offset: 0x90 : OTFDEC region x nonce register 1
$420c5094 constant OTFDEC1_R3KEYR0  \ offset: 0x94 : OTFDEC region x key register 0
$420c5098 constant OTFDEC1_R3KEYR1  \ offset: 0x98 : OTFDEC region x key register 1
$420c509c constant OTFDEC1_R3KEYR2  \ offset: 0x9C : OTFDEC region x key register 2
$420c50a0 constant OTFDEC1_R3KEYR3  \ offset: 0xA0 : OTFDEC region x key register 3
$420c50b0 constant OTFDEC1_R4CFGR  \ offset: 0xB0 : OTFDEC region x configuration register
$420c50b4 constant OTFDEC1_R4STARTADDR  \ offset: 0xB4 : OTFDEC region x start address register
$420c50b8 constant OTFDEC1_R4ENDADDR  \ offset: 0xB8 : OTFDEC region x end address register
$420c50bc constant OTFDEC1_R4NONCER0  \ offset: 0xBC : OTFDEC region x nonce register 0
$420c50c0 constant OTFDEC1_R4NONCER1  \ offset: 0xC0 : OTFDEC region x nonce register 1
$420c50c4 constant OTFDEC1_R4KEYR0  \ offset: 0xC4 : OTFDEC region x key register 0
$420c50c8 constant OTFDEC1_R4KEYR1  \ offset: 0xC8 : OTFDEC region x key register 1
$420c50cc constant OTFDEC1_R4KEYR2  \ offset: 0xCC : OTFDEC region x key register 2
$420c50d0 constant OTFDEC1_R4KEYR3  \ offset: 0xD0 : OTFDEC region x key register 3
$420c5300 constant OTFDEC1_ISR    \ offset: 0x300 : OTFDEC interrupt status register
$420c5304 constant OTFDEC1_ICR    \ offset: 0x304 : OTFDEC interrupt clear register
$420c5308 constant OTFDEC1_IER    \ offset: 0x308 : OTFDEC interrupt enable register

