\
\ @file flash.fs
\ @brief FLASH
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FLASH_DEF

  [ifdef] FLASH_ACR_DEF
    \
    \ @brief Flash access control register
    \ Address offset: 0x00
    \ Reset value: 0x00000030
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 3] Latency
    $03 constant FLASH_HLFCYA                   \ [0x03] Flash half cycle access enable
    $04 constant FLASH_PRFTBE                   \ [0x04] Prefetch buffer enable
    $05 constant FLASH_PRFTBS                   \ [0x05] Prefetch buffer status
  [then]


  [ifdef] FLASH_KEYR_DEF
    \
    \ @brief Flash key register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_KEY                      \ [0x00 : 32] FPEC key
  [then]


  [ifdef] FLASH_OPTKEYR_DEF
    \
    \ @brief Flash option key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEY                   \ [0x00 : 32] Option byte key
  [then]


  [ifdef] FLASH_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY                      \ [0x00] Busy
    $02 constant FLASH_PGERR                    \ [0x02] Programming error
    $04 constant FLASH_WRPRTERR                 \ [0x04] Write protection error
    $05 constant FLASH_EOP                      \ [0x05] End of operation
  [then]


  [ifdef] FLASH_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x10
    \ Reset value: 0x00000080
    \
    $00 constant FLASH_PG                       \ [0x00] Programming
    $01 constant FLASH_PER                      \ [0x01] Page Erase
    $02 constant FLASH_MER                      \ [0x02] Mass Erase
    $04 constant FLASH_OPTPG                    \ [0x04] Option byte programming
    $05 constant FLASH_OPTER                    \ [0x05] Option byte erase
    $06 constant FLASH_STRT                     \ [0x06] Start
    $07 constant FLASH_LOCK                     \ [0x07] Lock
    $09 constant FLASH_OPTWRE                   \ [0x09] Option bytes write enable
    $0a constant FLASH_ERRIE                    \ [0x0a] Error interrupt enable
    $0c constant FLASH_EOPIE                    \ [0x0c] End of operation interrupt enable
  [then]


  [ifdef] FLASH_AR_DEF
    \
    \ @brief Flash address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_FAR                      \ [0x00 : 32] Flash Address
  [then]


  [ifdef] FLASH_OBR_DEF
    \
    \ @brief Option byte register
    \ Address offset: 0x1C
    \ Reset value: 0x03FFFFFC
    \
    $00 constant FLASH_OPTERR                   \ [0x00] Option byte error
    $01 constant FLASH_RDPRT                    \ [0x01] Read protection
    $02 constant FLASH_WDG_SW                   \ [0x02] WDG_SW
    $03 constant FLASH_nRST_STOP                \ [0x03] nRST_STOP
    $04 constant FLASH_nRST_STDBY               \ [0x04] nRST_STDBY
    $0a constant FLASH_Data0                    \ [0x0a : 8] Data0
    $12 constant FLASH_Data1                    \ [0x12 : 8] Data1
  [then]


  [ifdef] FLASH_WRPR_DEF
    \
    \ @brief Write protection register
    \ Address offset: 0x20
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FLASH_WRP                      \ [0x00 : 32] Write protect
  [then]

  \
  \ @brief FLASH
  \
  $00 constant FLASH_ACR                \ Flash access control register
  $04 constant FLASH_KEYR               \ Flash key register
  $08 constant FLASH_OPTKEYR            \ Flash option key register
  $0C constant FLASH_SR                 \ Status register
  $10 constant FLASH_CR                 \ Control register
  $14 constant FLASH_AR                 \ Flash address register
  $1C constant FLASH_OBR                \ Option byte register
  $20 constant FLASH_WRPR               \ Write protection register

: FLASH_DEF ; [then]
