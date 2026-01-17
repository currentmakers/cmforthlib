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
    \ @brief Access control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LATENCY                  \ [0x00] Latency
    $01 constant FLASH_PRFTEN                   \ [0x01] Prefetch enable
    $03 constant FLASH_SLEEP_PD                 \ [0x03] Flash mode during Sleep
    $04 constant FLASH_RUN_PD                   \ [0x04] Flash mode during Run
    $05 constant FLASH_DISAB_BUF                \ [0x05] Disable Buffer
    $06 constant FLASH_PRE_READ                 \ [0x06] Pre-read data address
  [then]


  [ifdef] FLASH_PECR_DEF
    \
    \ @brief Program/erase control register
    \ Address offset: 0x04
    \ Reset value: 0x00000007
    \
    $00 constant FLASH_PELOCK                   \ [0x00] FLASH_PECR and data EEPROM lock
    $01 constant FLASH_PRGLOCK                  \ [0x01] Program memory lock
    $02 constant FLASH_OPTLOCK                  \ [0x02] Option bytes block lock
    $03 constant FLASH_PROG                     \ [0x03] Program memory selection
    $04 constant FLASH_DATA                     \ [0x04] Data EEPROM selection
    $08 constant FLASH_FIX                      \ [0x08] Fixed time data write for Byte, Half Word and Word programming
    $09 constant FLASH_ERASE                    \ [0x09] Page or Double Word erase mode
    $0a constant FLASH_FPRG                     \ [0x0a] Half Page/Double Word programming mode
    $0f constant FLASH_PARALLELBANK             \ [0x0f] Parallel bank mode
    $10 constant FLASH_EOPIE                    \ [0x10] End of programming interrupt enable
    $11 constant FLASH_ERRIE                    \ [0x11] Error interrupt enable
    $12 constant FLASH_OBL_LAUNCH               \ [0x12] Launch the option byte loading
    $17 constant FLASH_NZDISABLE                \ [0x17] Non-Zero check notification disable
  [then]


  [ifdef] FLASH_PDKEYR_DEF
    \
    \ @brief Power down key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PDKEYR                   \ [0x00 : 32] RUN_PD in FLASH_ACR key
  [then]


  [ifdef] FLASH_PEKEYR_DEF
    \
    \ @brief Program/erase key register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PEKEYR                   \ [0x00 : 32] FLASH_PEC and data EEPROM key
  [then]


  [ifdef] FLASH_PRGKEYR_DEF
    \
    \ @brief Program memory key register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRGKEYR                  \ [0x00 : 32] Program memory key
  [then]


  [ifdef] FLASH_OPTKEYR_DEF
    \
    \ @brief Option byte key register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEYR                  \ [0x00 : 32] Option byte key
  [then]


  [ifdef] FLASH_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x18
    \ Reset value: 0x00000004
    \
    $00 constant FLASH_BSY                      \ [0x00] Write/erase operations in progress
    $01 constant FLASH_EOP                      \ [0x01] End of operation
    $02 constant FLASH_ENDHV                    \ [0x02] End of high voltage
    $03 constant FLASH_READY                    \ [0x03] Flash memory module ready after low power mode
    $08 constant FLASH_WRPERR                   \ [0x08] Write protected error
    $09 constant FLASH_PGAERR                   \ [0x09] Programming alignment error
    $0a constant FLASH_SIZERR                   \ [0x0a] Size error
    $0b constant FLASH_OPTVERR                  \ [0x0b] Option validity error
    $0d constant FLASH_RDERR                    \ [0x0d] RDERR
    $10 constant FLASH_NOTZEROERR               \ [0x10] NOTZEROERR
    $11 constant FLASH_FWWERR                   \ [0x11] FWWERR
  [then]


  [ifdef] FLASH_OPTR_DEF
    \
    \ @brief Option byte register
    \ Address offset: 0x1C
    \ Reset value: 0x00F80000
    \
    $00 constant FLASH_RDPROT                   \ [0x00 : 8] Read protection
    $08 constant FLASH_WPRMOD                   \ [0x08] WPRMOD
    $10 constant FLASH_BOR_LEV                  \ [0x10 : 4] BOR_LEV
    $14 constant FLASH_WDG_SW                   \ [0x14] WDG_SW
    $15 constant FLASH_nRST_STOP                \ [0x15] nRST_STOP
    $16 constant FLASH_nRST_STDBY               \ [0x16] nRST_STDBY
    $17 constant FLASH_BFB2                     \ [0x17] BFB2
    $1f constant FLASH_nBOOT1                   \ [0x1f] nBOOT1
  [then]


  [ifdef] FLASH_WRPROT1_DEF
    \
    \ @brief Write protection register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPROT1                  \ [0x00 : 32] Write protection
  [then]


  [ifdef] FLASH_WRPROT2_DEF
    \
    \ @brief Write protection register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPROT2                  \ [0x00 : 16] Write protection
  [then]

  \
  \ @brief Flash
  \
  $00 constant FLASH_ACR                \ Access control register
  $04 constant FLASH_PECR               \ Program/erase control register
  $08 constant FLASH_PDKEYR             \ Power down key register
  $0C constant FLASH_PEKEYR             \ Program/erase key register
  $10 constant FLASH_PRGKEYR            \ Program memory key register
  $14 constant FLASH_OPTKEYR            \ Option byte key register
  $18 constant FLASH_SR                 \ Status register
  $1C constant FLASH_OPTR               \ Option byte register
  $20 constant FLASH_WRPROT1            \ Write protection register
  $80 constant FLASH_WRPROT2            \ Write protection register

: FLASH_DEF ; [then]
