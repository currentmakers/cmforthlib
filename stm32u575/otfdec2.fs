\
\ @file otfdec2.fs
\ @brief OTFDEC2 interrupt
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

$00000001 constant OTFDEC2_CR_ENC                                   \ Encryption mode bit


\
\ @brief OTFDEC privileged access control configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC2_PRIVCFGR_PRIV                            \ Encryption mode bit


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC2_R1CFGR_REG_EN                            \ region on-the-fly decryption enable
$00000002 constant OTFDEC2_R1CFGR_CONFIGLOCK                        \ region config lock
$00000004 constant OTFDEC2_R1CFGR_KEYLOCK                           \ region key lock
$00000030 constant OTFDEC2_R1CFGR_MODE                              \ operating mode
$0000ff00 constant OTFDEC2_R1CFGR_KEYCRC                            \ region key 8-bit CRC
$ffff0000 constant OTFDEC2_R1CFGR_REGX_VERSION                      \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R1STARTADDR_REGX_START_ADDR              \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x28
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC2_R1ENDADDR_REGX_END_ADDR                  \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R1NONCER0_REGX_NONCE                     \ REGx_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R1NONCER1_REGX_NONCE                     \ Region nonce


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R1KEYR0_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R1KEYR1_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R1KEYR2_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R1KEYR3_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC2_R2CFGR_REG_EN                            \ region on-the-fly decryption enable
$00000002 constant OTFDEC2_R2CFGR_CONFIGLOCK                        \ region config lock
$00000004 constant OTFDEC2_R2CFGR_KEYLOCK                           \ region key lock
$00000030 constant OTFDEC2_R2CFGR_MODE                              \ operating mode
$0000ff00 constant OTFDEC2_R2CFGR_KEYCRC                            \ region key 8-bit CRC
$ffff0000 constant OTFDEC2_R2CFGR_REGX_VERSION                      \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R2STARTADDR_REGX_START_ADDR              \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x58
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC2_R2ENDADDR_REGX_END_ADDR                  \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R2NONCER0_REGX_NONCE                     \ REGx_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R2NONCER1_REGX_NONCE                     \ Region nonce, bits [63:32]REGx_NONCE[63:32]


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R2KEYR0_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R2KEYR1_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R2KEYR2_REGX_KEY_                        \ REGx_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R2KEYR3_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC2_R3CFGR_REG_EN                            \ region on-the-fly decryption enable
$00000002 constant OTFDEC2_R3CFGR_CONFIGLOCK                        \ region config lock
$00000004 constant OTFDEC2_R3CFGR_KEYLOCK                           \ region key lock
$00000030 constant OTFDEC2_R3CFGR_MODE                              \ operating mode
$0000ff00 constant OTFDEC2_R3CFGR_KEYCRC                            \ region key 8-bit CRC
$ffff0000 constant OTFDEC2_R3CFGR_REGX_VERSION                      \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R3STARTADDR_REGX_START_ADDR              \ Region AXI start address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x88
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC2_R3ENDADDR_REGX_END_ADDR                  \ Region AXI end address


\
\ @brief OTFDEC region x end address register
\ Address offset: 0x8C
\ Reset value: 0x00000FFF
\

$00000000 constant OTFDEC2_R4ENDADDR_REGX_END_ADDR                  \ Region AXI end address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R3NONCER0_REGX_NONCE                     \ REGx_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R3NONCER1_REGX_NONCE                     \ REGx_NONCE


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R3KEYR0_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R3KEYR1_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R3KEYR2_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R3KEYR3_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x configuration register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC2_R4CFGR_REG_EN                            \ region on-the-fly decryption enable
$00000002 constant OTFDEC2_R4CFGR_CONFIGLOCK                        \ region config lock
$00000004 constant OTFDEC2_R4CFGR_KEYLOCK                           \ region key lock
$00000030 constant OTFDEC2_R4CFGR_MODE                              \ operating mode
$0000ff00 constant OTFDEC2_R4CFGR_KEYCRC                            \ region key 8-bit CRC
$ffff0000 constant OTFDEC2_R4CFGR_REGX_VERSION                      \ region firmware version


\
\ @brief OTFDEC region x start address register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R4STARTADDR_REGX_START_ADDR              \ Region AXI start address


\
\ @brief OTFDEC region x nonce register 0
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R4NONCER0_REGX_NONCE                     \ REGx_NONCE


\
\ @brief OTFDEC region x nonce register 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R4NONCER1_REGX_NONCE                     \ REGx_NONCE


\
\ @brief OTFDEC region x key register 0
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R4KEYR0_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R4KEYR1_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 2
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R4KEYR2_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC region x key register 3
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant OTFDEC2_R4KEYR3_REGX_KEY                         \ REGx_KEY


\
\ @brief OTFDEC interrupt status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC2_ISR_SEIF                                 \ Security Error Interrupt Flag status
$00000002 constant OTFDEC2_ISR_XONEIF                               \ Execute-only execute-Never Error Interrupt Flag status
$00000004 constant OTFDEC2_ISR_KEIF                                 \ Key Error Interrupt Flag status


\
\ @brief OTFDEC interrupt clear register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC2_ICR_SEIF                                 \ SEIF
$00000002 constant OTFDEC2_ICR_XONEIF                               \ Execute-only execute-Never Error Interrupt Flag clear
$00000004 constant OTFDEC2_ICR_KEIF                                 \ KEIF


\
\ @brief OTFDEC interrupt enable register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant OTFDEC2_IER_SEIE                                 \ Security Error Interrupt Enable
$00000002 constant OTFDEC2_IER_XONEIE                               \ XONEIE
$00000004 constant OTFDEC2_IER_KEIE                                 \ KEIE


\
\ @brief OTFDEC2 interrupt
\
$420c5400 constant OTFDEC2_CR     \ offset: 0x00 : OTFDEC control register
$420c5410 constant OTFDEC2_PRIVCFGR  \ offset: 0x10 : OTFDEC privileged access control configuration register
$420c5420 constant OTFDEC2_R1CFGR  \ offset: 0x20 : OTFDEC region x configuration register
$420c5424 constant OTFDEC2_R1STARTADDR  \ offset: 0x24 : OTFDEC region x start address register
$420c5428 constant OTFDEC2_R1ENDADDR  \ offset: 0x28 : OTFDEC region x end address register
$420c542c constant OTFDEC2_R1NONCER0  \ offset: 0x2C : OTFDEC region x nonce register 0
$420c5430 constant OTFDEC2_R1NONCER1  \ offset: 0x30 : OTFDEC region x nonce register 1
$420c5434 constant OTFDEC2_R1KEYR0  \ offset: 0x34 : OTFDEC region x key register 0
$420c5438 constant OTFDEC2_R1KEYR1  \ offset: 0x38 : OTFDEC region x key register 1
$420c543c constant OTFDEC2_R1KEYR2  \ offset: 0x3C : OTFDEC region x key register 2
$420c5440 constant OTFDEC2_R1KEYR3  \ offset: 0x40 : OTFDEC region x key register 3
$420c5450 constant OTFDEC2_R2CFGR  \ offset: 0x50 : OTFDEC region x configuration register
$420c5454 constant OTFDEC2_R2STARTADDR  \ offset: 0x54 : OTFDEC region x start address register
$420c5458 constant OTFDEC2_R2ENDADDR  \ offset: 0x58 : OTFDEC region x end address register
$420c545c constant OTFDEC2_R2NONCER0  \ offset: 0x5C : OTFDEC region x nonce register 0
$420c5460 constant OTFDEC2_R2NONCER1  \ offset: 0x60 : OTFDEC region x nonce register 1
$420c5464 constant OTFDEC2_R2KEYR0  \ offset: 0x64 : OTFDEC region x key register 0
$420c5468 constant OTFDEC2_R2KEYR1  \ offset: 0x68 : OTFDEC region x key register 1
$420c546c constant OTFDEC2_R2KEYR2  \ offset: 0x6C : OTFDEC region x key register 2
$420c5470 constant OTFDEC2_R2KEYR3  \ offset: 0x70 : OTFDEC region x key register 3
$420c5480 constant OTFDEC2_R3CFGR  \ offset: 0x80 : OTFDEC region x configuration register
$420c5484 constant OTFDEC2_R3STARTADDR  \ offset: 0x84 : OTFDEC region x start address register
$420c5488 constant OTFDEC2_R3ENDADDR  \ offset: 0x88 : OTFDEC region x end address register
$420c548c constant OTFDEC2_R4ENDADDR  \ offset: 0x8C : OTFDEC region x end address register
$420c548c constant OTFDEC2_R3NONCER0  \ offset: 0x8C : OTFDEC region x nonce register 0
$420c5490 constant OTFDEC2_R3NONCER1  \ offset: 0x90 : OTFDEC region x nonce register 1
$420c5494 constant OTFDEC2_R3KEYR0  \ offset: 0x94 : OTFDEC region x key register 0
$420c5498 constant OTFDEC2_R3KEYR1  \ offset: 0x98 : OTFDEC region x key register 1
$420c549c constant OTFDEC2_R3KEYR2  \ offset: 0x9C : OTFDEC region x key register 2
$420c54a0 constant OTFDEC2_R3KEYR3  \ offset: 0xA0 : OTFDEC region x key register 3
$420c54b0 constant OTFDEC2_R4CFGR  \ offset: 0xB0 : OTFDEC region x configuration register
$420c54b4 constant OTFDEC2_R4STARTADDR  \ offset: 0xB4 : OTFDEC region x start address register
$420c54bc constant OTFDEC2_R4NONCER0  \ offset: 0xBC : OTFDEC region x nonce register 0
$420c54c0 constant OTFDEC2_R4NONCER1  \ offset: 0xC0 : OTFDEC region x nonce register 1
$420c54c4 constant OTFDEC2_R4KEYR0  \ offset: 0xC4 : OTFDEC region x key register 0
$420c54c8 constant OTFDEC2_R4KEYR1  \ offset: 0xC8 : OTFDEC region x key register 1
$420c54cc constant OTFDEC2_R4KEYR2  \ offset: 0xCC : OTFDEC region x key register 2
$420c54d0 constant OTFDEC2_R4KEYR3  \ offset: 0xD0 : OTFDEC region x key register 3
$420c5700 constant OTFDEC2_ISR    \ offset: 0x300 : OTFDEC interrupt status register
$420c5704 constant OTFDEC2_ICR    \ offset: 0x304 : OTFDEC interrupt clear register
$420c5708 constant OTFDEC2_IER    \ offset: 0x308 : OTFDEC interrupt enable register

