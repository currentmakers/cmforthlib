\
\ @file flash.fs
\ @brief Flash
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
    $00 constant FLASH_LATENCY                  \ [0x00 : 3] LATENCY
    $04 constant FLASH_PRFTBE                   \ [0x04] PRFTBE
    $05 constant FLASH_PRFTBS                   \ [0x05] PRFTBS
  [then]


  [ifdef] FLASH_KEYR_DEF
    \
    \ @brief Flash key register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_FKEYR                    \ [0x00 : 32] Flash Key
  [then]


  [ifdef] FLASH_OPTKEYR_DEF
    \
    \ @brief Flash option key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEYR                  \ [0x00 : 32] Option byte key
  [then]


  [ifdef] FLASH_SR_DEF
    \
    \ @brief Flash status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY                      \ [0x00] Busy
    $02 constant FLASH_PGERR                    \ [0x02] Programming error
    $04 constant FLASH_WRPRT                    \ [0x04] Write protection error
    $05 constant FLASH_EOP                      \ [0x05] End of operation
  [then]


  [ifdef] FLASH_CR_DEF
    \
    \ @brief Flash control register
    \ Address offset: 0x10
    \ Reset value: 0x00000080
    \
    $00 constant FLASH_PG                       \ [0x00] Programming
    $01 constant FLASH_PER                      \ [0x01] Page erase
    $02 constant FLASH_MER                      \ [0x02] Mass erase
    $04 constant FLASH_OPTPG                    \ [0x04] Option byte programming
    $05 constant FLASH_OPTER                    \ [0x05] Option byte erase
    $06 constant FLASH_STRT                     \ [0x06] Start
    $07 constant FLASH_LOCK                     \ [0x07] Lock
    $09 constant FLASH_OPTWRE                   \ [0x09] Option bytes write enable
    $0a constant FLASH_ERRIE                    \ [0x0a] Error interrupt enable
    $0c constant FLASH_EOPIE                    \ [0x0c] End of operation interrupt enable
    $0d constant FLASH_FORCE_OPTLOAD            \ [0x0d] Force option byte loading
  [then]


  [ifdef] FLASH_AR_DEF
    \
    \ @brief Flash address register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_FAR                      \ [0x00 : 32] Flash address
  [then]


  [ifdef] FLASH_OBR_DEF
    \
    \ @brief Option byte register
    \ Address offset: 0x1C
    \ Reset value: 0x03FFFFF2
    \
    $00 constant FLASH_OPTERR                   \ [0x00] Option byte error
    $01 constant FLASH_RDPRT                    \ [0x01 : 2] Read protection level status
    $08 constant FLASH_WDG_SW                   \ [0x08] WDG_SW
    $09 constant FLASH_nRST_STOP                \ [0x09] nRST_STOP
    $0a constant FLASH_nRST_STDBY               \ [0x0a] nRST_STDBY
    $0c constant FLASH_nBOOT1                   \ [0x0c] BOOT1
    $0d constant FLASH_VDDA_MONITOR             \ [0x0d] VDDA_MONITOR
    $0e constant FLASH_RAM_PARITY_CHECK_        \ [0x0e] RAM_PARITY_CHECK
    $10 constant FLASH_Data0                    \ [0x10 : 8] Data0
    $18 constant FLASH_Data1                    \ [0x18 : 8] Data1
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
  \ @brief Flash
  \
  $00 constant FLASH_ACR                \ Flash access control register
  $04 constant FLASH_KEYR               \ Flash key register
  $08 constant FLASH_OPTKEYR            \ Flash option key register
  $0C constant FLASH_SR                 \ Flash status register
  $10 constant FLASH_CR                 \ Flash control register
  $14 constant FLASH_AR                 \ Flash address register
  $1C constant FLASH_OBR                \ Option byte register
  $20 constant FLASH_WRPR               \ Write protection register

: FLASH_DEF ; [then]
