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
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 4] Latency
    $08 constant FLASH_PRFTEN                   \ [0x08] Prefetch enable
    $09 constant FLASH_ARTEN                    \ [0x09] ART Accelerator Enable
    $0b constant FLASH_ARTRST                   \ [0x0b] ART Accelerator reset
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
    $00 constant FLASH_EOP                      \ [0x00] End of operation
    $01 constant FLASH_OPERR                    \ [0x01] Operation error
    $04 constant FLASH_WRPERR                   \ [0x04] Write protection error
    $05 constant FLASH_PGAERR                   \ [0x05] Programming alignment error
    $06 constant FLASH_PGPERR                   \ [0x06] Programming parallelism error
    $07 constant FLASH_PGSERR                   \ [0x07] Programming sequence error
    $10 constant FLASH_BSY                      \ [0x10] Busy
  [then]


  [ifdef] FLASH_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x10
    \ Reset value: 0x80000000
    \
    $00 constant FLASH_PG                       \ [0x00] Programming
    $01 constant FLASH_SER                      \ [0x01] Sector Erase
    $02 constant FLASH_MER                      \ [0x02] Mass Erase of sectors 0 to 11
    $03 constant FLASH_SNB                      \ [0x03 : 5] Sector number
    $08 constant FLASH_PSIZE                    \ [0x08 : 2] Program size
    $0f constant FLASH_MER1                     \ [0x0f] Mass Erase of sectors 12 to 23
    $10 constant FLASH_STRT                     \ [0x10] Start
    $18 constant FLASH_EOPIE                    \ [0x18] End of operation interrupt enable
    $19 constant FLASH_ERRIE                    \ [0x19] Error interrupt enable
    $1f constant FLASH_LOCK                     \ [0x1f] Lock
  [then]


  [ifdef] FLASH_OPTCR_DEF
    \
    \ @brief Flash option control register
    \ Address offset: 0x14
    \ Reset value: 0x0FFFAAED
    \
    $00 constant FLASH_OPTLOCK                  \ [0x00] Option lock
    $01 constant FLASH_OPTSTRT                  \ [0x01] Option start
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] BOR reset Level
    $04 constant FLASH_WWDG_SW                  \ [0x04] User option bytes
    $05 constant FLASH_IWDG_SW                  \ [0x05] User option bytes
    $06 constant FLASH_nRST_STOP                \ [0x06] User option bytes
    $07 constant FLASH_nRST_STDBY               \ [0x07] User option bytes
    $08 constant FLASH_RDP                      \ [0x08 : 8] Read protect
    $10 constant FLASH_nWRP                     \ [0x10 : 8] Not write protect
    $1e constant FLASH_IWDG_STDBY               \ [0x1e] Independent watchdog counter freeze in standby mode
    $1f constant FLASH_IWDG_STOP                \ [0x1f] Independent watchdog counter freeze in Stop mode
  [then]


  [ifdef] FLASH_OPTCR1_DEF
    \
    \ @brief Flash option control register 1
    \ Address offset: 0x18
    \ Reset value: 0x0FFF0000
    \
    $00 constant FLASH_BOOT_ADD0                \ [0x00 : 16] Boot base address when Boot pin =0
    $10 constant FLASH_BOOT_ADD1                \ [0x10 : 16] Boot base address when Boot pin =1
  [then]

  \
  \ @brief FLASH
  \
  $00 constant FLASH_ACR                \ Flash access control register
  $04 constant FLASH_KEYR               \ Flash key register
  $08 constant FLASH_OPTKEYR            \ Flash option key register
  $0C constant FLASH_SR                 \ Status register
  $10 constant FLASH_CR                 \ Control register
  $14 constant FLASH_OPTCR              \ Flash option control register
  $18 constant FLASH_OPTCR1             \ Flash option control register 1

: FLASH_DEF ; [then]
