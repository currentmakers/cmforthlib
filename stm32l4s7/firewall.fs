\
\ @file firewall.fs
\ @brief Firewall
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FIREWALL_DEF

  [ifdef] FIREWALL_CSSA_DEF
    \
    \ @brief Code segment start address
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $08 constant FIREWALL_ADD                   \ [0x08 : 16] code segment start address
  [then]


  [ifdef] FIREWALL_CSL_DEF
    \
    \ @brief Code segment length
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $08 constant FIREWALL_LENG                  \ [0x08 : 14] code segment length
  [then]


  [ifdef] FIREWALL_NVDSSA_DEF
    \
    \ @brief Non-volatile data segment start address
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $08 constant FIREWALL_ADD                   \ [0x08 : 16] Non-volatile data segment start address
  [then]


  [ifdef] FIREWALL_NVDSL_DEF
    \
    \ @brief Non-volatile data segment length
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $08 constant FIREWALL_LENG                  \ [0x08 : 14] Non-volatile data segment length
  [then]


  [ifdef] FIREWALL_VDSSA_DEF
    \
    \ @brief Volatile data segment start address
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $06 constant FIREWALL_ADD                   \ [0x06 : 10] Volatile data segment start address
  [then]


  [ifdef] FIREWALL_VDSL_DEF
    \
    \ @brief Volatile data segment length
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $06 constant FIREWALL_LENG                  \ [0x06 : 10] Non-volatile data segment length
  [then]


  [ifdef] FIREWALL_CR_DEF
    \
    \ @brief Configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FIREWALL_FPA                   \ [0x00] Firewall pre alarm
    $01 constant FIREWALL_VDS                   \ [0x01] Volatile data shared
    $02 constant FIREWALL_VDE                   \ [0x02] Volatile data execution
  [then]

  \
  \ @brief Firewall
  \
  $00 constant FIREWALL_CSSA            \ Code segment start address
  $04 constant FIREWALL_CSL             \ Code segment length
  $08 constant FIREWALL_NVDSSA          \ Non-volatile data segment start address
  $0C constant FIREWALL_NVDSL           \ Non-volatile data segment length
  $10 constant FIREWALL_VDSSA           \ Volatile data segment start address
  $14 constant FIREWALL_VDSL            \ Volatile data segment length
  $20 constant FIREWALL_CR              \ Configuration register

: FIREWALL_DEF ; [then]
