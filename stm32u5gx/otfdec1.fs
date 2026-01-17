\
\ @file otfdec1.fs
\ @brief On-The-Fly Decryption engine
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTFDEC1_DEF

  [ifdef] OTFDEC1_CR_DEF
    \
    \ @brief OTFDEC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_ENC                    \ [0x00] Encryption mode bit
  [then]


  [ifdef] OTFDEC1_PRIVCFGR_DEF
    \
    \ @brief OTFDEC privileged access control configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_PRIV                   \ [0x00] Encryption mode bit
  [then]


  [ifdef] OTFDEC1_R1CFGR_DEF
    \
    \ @brief OTFDEC region x configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG_EN                 \ [0x00] region on-the-fly decryption enable
    $01 constant OTFDEC1_CONFIGLOCK             \ [0x01] region config lock
    $02 constant OTFDEC1_KEYLOCK                \ [0x02] region key lock
    $04 constant OTFDEC1_MODE                   \ [0x04 : 2] operating mode
    $08 constant OTFDEC1_KEYCRC                 \ [0x08 : 8] region key 8-bit CRC
    $10 constant OTFDEC1_REG1_VERSION           \ [0x10 : 16] region firmware version
  [then]


  [ifdef] OTFDEC1_R1STARTADDR_DEF
    \
    \ @brief OTFDEC region x start address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG1_START_ADDR        \ [0x00 : 32] Region AXI start address
  [then]


  [ifdef] OTFDEC1_R1ENDADDR_DEF
    \
    \ @brief OTFDEC region x end address register
    \ Address offset: 0x28
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC1_REG1_END_ADDR          \ [0x00 : 32] Region AXI end address
  [then]


  [ifdef] OTFDEC1_R1NONCER0_DEF
    \
    \ @brief OTFDEC region x nonce register 0
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG1_NONCE             \ [0x00 : 32] REG1_NONCE
  [then]


  [ifdef] OTFDEC1_R1NONCER1_DEF
    \
    \ @brief OTFDEC region x nonce register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG1_NONCE             \ [0x00 : 32] Region nonce
  [then]


  [ifdef] OTFDEC1_R1KEYR0_DEF
    \
    \ @brief OTFDEC region x key register 0
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG1_KEY               \ [0x00 : 32] REG1_KEY
  [then]


  [ifdef] OTFDEC1_R1KEYR1_DEF
    \
    \ @brief OTFDEC region x key register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG1_KEY               \ [0x00 : 32] REG1_KEY
  [then]


  [ifdef] OTFDEC1_R1KEYR2_DEF
    \
    \ @brief OTFDEC region x key register 2
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG1_KEY               \ [0x00 : 32] REG1_KEY
  [then]


  [ifdef] OTFDEC1_R1KEYR3_DEF
    \
    \ @brief OTFDEC region x key register 3
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG1_KEY               \ [0x00 : 32] REG1_KEY
  [then]


  [ifdef] OTFDEC1_R2CFGR_DEF
    \
    \ @brief OTFDEC region x configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG_EN                 \ [0x00] region on-the-fly decryption enable
    $01 constant OTFDEC1_CONFIGLOCK             \ [0x01] region config lock
    $02 constant OTFDEC1_KEYLOCK                \ [0x02] region key lock
    $04 constant OTFDEC1_MODE                   \ [0x04 : 2] operating mode
    $08 constant OTFDEC1_KEYCRC                 \ [0x08 : 8] region key 8-bit CRC
    $10 constant OTFDEC1_REG2_VERSION           \ [0x10 : 16] region firmware version
  [then]


  [ifdef] OTFDEC1_R2STARTADDR_DEF
    \
    \ @brief OTFDEC region x start address register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG2_START_ADDR        \ [0x00 : 32] Region AXI start address
  [then]


  [ifdef] OTFDEC1_R2ENDADDR_DEF
    \
    \ @brief OTFDEC region x end address register
    \ Address offset: 0x58
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC1_REG2_END_ADDR          \ [0x00 : 32] Region AXI end address
  [then]


  [ifdef] OTFDEC1_R2NONCER0_DEF
    \
    \ @brief OTFDEC region x nonce register 0
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG2_NONCE             \ [0x00 : 32] REG2_NONCE
  [then]


  [ifdef] OTFDEC1_R2NONCER1_DEF
    \
    \ @brief OTFDEC region x nonce register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG2_NONCE             \ [0x00 : 32] Region nonce, bits [63:32]REGx_NONCE[63:32]
  [then]


  [ifdef] OTFDEC1_R2KEYR0_DEF
    \
    \ @brief OTFDEC region x key register 0
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG2_KEY               \ [0x00 : 32] REG2_KEY
  [then]


  [ifdef] OTFDEC1_R2KEYR1_DEF
    \
    \ @brief OTFDEC region x key register 1
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG2_KEY               \ [0x00 : 32] REG2_KEY
  [then]


  [ifdef] OTFDEC1_R2KEYR2_DEF
    \
    \ @brief OTFDEC region x key register 2
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG2_KEY_              \ [0x00 : 32] REG2_KEY_
  [then]


  [ifdef] OTFDEC1_R2KEYR3_DEF
    \
    \ @brief OTFDEC region x key register 3
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG2_KEY               \ [0x00 : 32] REG2_KEY
  [then]


  [ifdef] OTFDEC1_R3CFGR_DEF
    \
    \ @brief OTFDEC region x configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG_EN                 \ [0x00] region on-the-fly decryption enable
    $01 constant OTFDEC1_CONFIGLOCK             \ [0x01] region config lock
    $02 constant OTFDEC1_KEYLOCK                \ [0x02] region key lock
    $04 constant OTFDEC1_MODE                   \ [0x04 : 2] operating mode
    $08 constant OTFDEC1_KEYCRC                 \ [0x08 : 8] region key 8-bit CRC
    $10 constant OTFDEC1_REG3_VERSION           \ [0x10 : 16] region firmware version
  [then]


  [ifdef] OTFDEC1_R3STARTADDR_DEF
    \
    \ @brief OTFDEC region x start address register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG3_START_ADDR        \ [0x00 : 32] Region AXI start address
  [then]


  [ifdef] OTFDEC1_R3ENDADDR_DEF
    \
    \ @brief OTFDEC region x end address register
    \ Address offset: 0x88
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC1_REG3_END_ADDR          \ [0x00 : 32] Region AXI end address
  [then]


  [ifdef] OTFDEC1_R3NONCER0_DEF
    \
    \ @brief OTFDEC region x nonce register 0
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG3_NONCE             \ [0x00 : 32] REG3_NONCE
  [then]


  [ifdef] OTFDEC1_R3NONCER1_DEF
    \
    \ @brief OTFDEC region x nonce register 1
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG3_NONCE             \ [0x00 : 32] REG3_NONCE
  [then]


  [ifdef] OTFDEC1_R3KEYR0_DEF
    \
    \ @brief OTFDEC region x key register 0
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG3_KEY               \ [0x00 : 32] REG3_KEY
  [then]


  [ifdef] OTFDEC1_R3KEYR1_DEF
    \
    \ @brief OTFDEC region x key register 1
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG3_KEY               \ [0x00 : 32] REG3_KEY
  [then]


  [ifdef] OTFDEC1_R3KEYR2_DEF
    \
    \ @brief OTFDEC region x key register 2
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG3_KEY               \ [0x00 : 32] REG3_KEY
  [then]


  [ifdef] OTFDEC1_R3KEYR3_DEF
    \
    \ @brief OTFDEC region x key register 3
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG3_KEY               \ [0x00 : 32] REG3_KEY
  [then]


  [ifdef] OTFDEC1_R4CFGR_DEF
    \
    \ @brief OTFDEC region x configuration register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG_EN                 \ [0x00] region on-the-fly decryption enable
    $01 constant OTFDEC1_CONFIGLOCK             \ [0x01] region config lock
    $02 constant OTFDEC1_KEYLOCK                \ [0x02] region key lock
    $04 constant OTFDEC1_MODE                   \ [0x04 : 2] operating mode
    $08 constant OTFDEC1_KEYCRC                 \ [0x08 : 8] region key 8-bit CRC
    $10 constant OTFDEC1_REG4_VERSION           \ [0x10 : 16] region firmware version
  [then]


  [ifdef] OTFDEC1_R4STARTADDR_DEF
    \
    \ @brief OTFDEC region x start address register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG4_START_ADDR        \ [0x00 : 32] Region AXI start address
  [then]


  [ifdef] OTFDEC1_R4ENDADDR_DEF
    \
    \ @brief OTFDEC region x end address register
    \ Address offset: 0xB8
    \ Reset value: 0x00000FFF
    \
    $00 constant OTFDEC1_REG4_END_ADDR          \ [0x00 : 32] Region AXI end address
  [then]


  [ifdef] OTFDEC1_R4NONCER0_DEF
    \
    \ @brief OTFDEC region x nonce register 0
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG4_NONCE             \ [0x00 : 32] REG4_NONCE
  [then]


  [ifdef] OTFDEC1_R4NONCER1_DEF
    \
    \ @brief OTFDEC region x nonce register 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG4_NONCE             \ [0x00 : 32] REG4_NONCE
  [then]


  [ifdef] OTFDEC1_R4KEYR0_DEF
    \
    \ @brief OTFDEC region x key register 0
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG4_KEY               \ [0x00 : 32] REG4_KEY
  [then]


  [ifdef] OTFDEC1_R4KEYR1_DEF
    \
    \ @brief OTFDEC region x key register 1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG4_KEY               \ [0x00 : 32] REG4_KEY
  [then]


  [ifdef] OTFDEC1_R4KEYR2_DEF
    \
    \ @brief OTFDEC region x key register 2
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG4_KEY               \ [0x00 : 32] REG4_KEY
  [then]


  [ifdef] OTFDEC1_R4KEYR3_DEF
    \
    \ @brief OTFDEC region x key register 3
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_REG4_KEY               \ [0x00 : 32] REG4_KEY
  [then]


  [ifdef] OTFDEC1_ISR_DEF
    \
    \ @brief OTFDEC interrupt status register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_SEIF                   \ [0x00] Security Error Interrupt Flag status
    $01 constant OTFDEC1_XONEIF                 \ [0x01] Execute-only execute-Never Error Interrupt Flag status
    $02 constant OTFDEC1_KEIF                   \ [0x02] Key Error Interrupt Flag status
  [then]


  [ifdef] OTFDEC1_ICR_DEF
    \
    \ @brief OTFDEC interrupt clear register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_SEIF                   \ [0x00] SEIF
    $01 constant OTFDEC1_XONEIF                 \ [0x01] Execute-only execute-Never Error Interrupt Flag clear
    $02 constant OTFDEC1_KEIF                   \ [0x02] KEIF
  [then]


  [ifdef] OTFDEC1_IER_DEF
    \
    \ @brief OTFDEC interrupt enable register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant OTFDEC1_SEIE                   \ [0x00] Security Error Interrupt Enable
    $01 constant OTFDEC1_XONEIE                 \ [0x01] XONEIE
    $02 constant OTFDEC1_KEIE                   \ [0x02] KEIE
  [then]

  \
  \ @brief On-The-Fly Decryption engine
  \
  $00 constant OTFDEC1_CR               \ OTFDEC control register
  $10 constant OTFDEC1_PRIVCFGR         \ OTFDEC privileged access control configuration register
  $20 constant OTFDEC1_R1CFGR           \ OTFDEC region x configuration register
  $24 constant OTFDEC1_R1STARTADDR      \ OTFDEC region x start address register
  $28 constant OTFDEC1_R1ENDADDR        \ OTFDEC region x end address register
  $2C constant OTFDEC1_R1NONCER0        \ OTFDEC region x nonce register 0
  $30 constant OTFDEC1_R1NONCER1        \ OTFDEC region x nonce register 1
  $34 constant OTFDEC1_R1KEYR0          \ OTFDEC region x key register 0
  $38 constant OTFDEC1_R1KEYR1          \ OTFDEC region x key register 1
  $3C constant OTFDEC1_R1KEYR2          \ OTFDEC region x key register 2
  $40 constant OTFDEC1_R1KEYR3          \ OTFDEC region x key register 3
  $50 constant OTFDEC1_R2CFGR           \ OTFDEC region x configuration register
  $54 constant OTFDEC1_R2STARTADDR      \ OTFDEC region x start address register
  $58 constant OTFDEC1_R2ENDADDR        \ OTFDEC region x end address register
  $5C constant OTFDEC1_R2NONCER0        \ OTFDEC region x nonce register 0
  $60 constant OTFDEC1_R2NONCER1        \ OTFDEC region x nonce register 1
  $64 constant OTFDEC1_R2KEYR0          \ OTFDEC region x key register 0
  $68 constant OTFDEC1_R2KEYR1          \ OTFDEC region x key register 1
  $6C constant OTFDEC1_R2KEYR2          \ OTFDEC region x key register 2
  $70 constant OTFDEC1_R2KEYR3          \ OTFDEC region x key register 3
  $80 constant OTFDEC1_R3CFGR           \ OTFDEC region x configuration register
  $84 constant OTFDEC1_R3STARTADDR      \ OTFDEC region x start address register
  $88 constant OTFDEC1_R3ENDADDR        \ OTFDEC region x end address register
  $8C constant OTFDEC1_R3NONCER0        \ OTFDEC region x nonce register 0
  $90 constant OTFDEC1_R3NONCER1        \ OTFDEC region x nonce register 1
  $94 constant OTFDEC1_R3KEYR0          \ OTFDEC region x key register 0
  $98 constant OTFDEC1_R3KEYR1          \ OTFDEC region x key register 1
  $9C constant OTFDEC1_R3KEYR2          \ OTFDEC region x key register 2
  $A0 constant OTFDEC1_R3KEYR3          \ OTFDEC region x key register 3
  $B0 constant OTFDEC1_R4CFGR           \ OTFDEC region x configuration register
  $B4 constant OTFDEC1_R4STARTADDR      \ OTFDEC region x start address register
  $B8 constant OTFDEC1_R4ENDADDR        \ OTFDEC region x end address register
  $BC constant OTFDEC1_R4NONCER0        \ OTFDEC region x nonce register 0
  $C0 constant OTFDEC1_R4NONCER1        \ OTFDEC region x nonce register 1
  $C4 constant OTFDEC1_R4KEYR0          \ OTFDEC region x key register 0
  $C8 constant OTFDEC1_R4KEYR1          \ OTFDEC region x key register 1
  $CC constant OTFDEC1_R4KEYR2          \ OTFDEC region x key register 2
  $D0 constant OTFDEC1_R4KEYR3          \ OTFDEC region x key register 3
  $300 constant OTFDEC1_ISR             \ OTFDEC interrupt status register
  $304 constant OTFDEC1_ICR             \ OTFDEC interrupt clear register
  $308 constant OTFDEC1_IER             \ OTFDEC interrupt enable register

: OTFDEC1_DEF ; [then]
