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
    \ Reset value: 0x00000600
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 3] Latency
    $08 constant FLASH_PRFTEN                   \ [0x08] Prefetch enable
    $09 constant FLASH_ICEN                     \ [0x09] Instruction cache enable
    $0a constant FLASH_DCEN                     \ [0x0a] Data cache enable
    $0b constant FLASH_ICRST                    \ [0x0b] Instruction cache reset
    $0c constant FLASH_DCRST                    \ [0x0c] Data cache reset
    $0d constant FLASH_RUN_PD                   \ [0x0d] Flash Power-down mode during Low-power run mode
    $0e constant FLASH_SLEEP_PD                 \ [0x0e] Flash Power-down mode during Low-power sleep mode
  [then]


  [ifdef] FLASH_PDKEYR_DEF
    \
    \ @brief Power down key register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PDKEYR                   \ [0x00 : 32] RUN_PD in FLASH_ACR key
  [then]


  [ifdef] FLASH_KEYR_DEF
    \
    \ @brief Flash key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_KEYR                     \ [0x00 : 32] KEYR
  [then]


  [ifdef] FLASH_OPTKEYR_DEF
    \
    \ @brief Option byte key register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEYR                  \ [0x00 : 32] Option byte key
  [then]


  [ifdef] FLASH_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EOP                      \ [0x00] End of operation
    $01 constant FLASH_OPERR                    \ [0x01] Operation error
    $03 constant FLASH_PROGERR                  \ [0x03] Programming error
    $04 constant FLASH_WRPERR                   \ [0x04] Write protected error
    $05 constant FLASH_PGAERR                   \ [0x05] Programming alignment error
    $06 constant FLASH_SIZERR                   \ [0x06] Size error
    $07 constant FLASH_PGSERR                   \ [0x07] Programming sequence error
    $08 constant FLASH_MISERR                   \ [0x08] Fast programming data miss error
    $09 constant FLASH_FASTERR                  \ [0x09] Fast programming error
    $0e constant FLASH_RDERR                    \ [0x0e] PCROP read error
    $0f constant FLASH_OPTVERR                  \ [0x0f] Option validity error
    $10 constant FLASH_BSY                      \ [0x10] Busy
  [then]


  [ifdef] FLASH_CR_DEF
    \
    \ @brief Flash control register
    \ Address offset: 0x14
    \ Reset value: 0xC0000000
    \
    $00 constant FLASH_PG                       \ [0x00] Programming
    $01 constant FLASH_PER                      \ [0x01] Page erase
    $02 constant FLASH_MER1                     \ [0x02] Bank 1 Mass erase
    $03 constant FLASH_PNB                      \ [0x03 : 8] Page number
    $0b constant FLASH_BKER                     \ [0x0b] Bank erase
    $0f constant FLASH_MER2                     \ [0x0f] Bank 2 Mass erase
    $10 constant FLASH_START                    \ [0x10] Start
    $11 constant FLASH_OPTSTRT                  \ [0x11] Options modification start
    $12 constant FLASH_FSTPG                    \ [0x12] Fast programming
    $18 constant FLASH_EOPIE                    \ [0x18] End of operation interrupt enable
    $19 constant FLASH_ERRIE                    \ [0x19] Error interrupt enable
    $1a constant FLASH_RDERRIE                  \ [0x1a] PCROP read error interrupt enable
    $1b constant FLASH_OBL_LAUNCH               \ [0x1b] Force the option byte loading
    $1e constant FLASH_OPTLOCK                  \ [0x1e] Options Lock
    $1f constant FLASH_LOCK                     \ [0x1f] FLASH_CR Lock
  [then]


  [ifdef] FLASH_ECCR_DEF
    \
    \ @brief Flash ECC register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 19] ECC fail address
    $13 constant FLASH_BK_ECC                   \ [0x13] ECC fail bank
    $14 constant FLASH_SYSF_ECC                 \ [0x14] System Flash ECC fail
    $18 constant FLASH_ECCIE                    \ [0x18] ECC correction interrupt enable
    $1e constant FLASH_ECCC                     \ [0x1e] ECC correction
    $1f constant FLASH_ECCD                     \ [0x1f] ECC detection
  [then]


  [ifdef] FLASH_OPTR_DEF
    \
    \ @brief Flash option register
    \ Address offset: 0x20
    \ Reset value: 0xF0000000
    \
    $00 constant FLASH_RDP                      \ [0x00 : 8] Read protection level
    $08 constant FLASH_BOR_LEV                  \ [0x08 : 3] BOR reset Level
    $0c constant FLASH_nRST_STOP                \ [0x0c] nRST_STOP
    $0d constant FLASH_nRST_STDBY               \ [0x0d] nRST_STDBY
    $0e constant FLASH_nRST_SHDW                \ [0x0e] nRST_SHDW
    $10 constant FLASH_IDWG_SW                  \ [0x10] Independent watchdog selection
    $11 constant FLASH_IWDG_STOP                \ [0x11] Independent watchdog counter freeze in Stop mode
    $12 constant FLASH_IWDG_STDBY               \ [0x12] Independent watchdog counter freeze in Standby mode
    $13 constant FLASH_WWDG_SW                  \ [0x13] Window watchdog selection
    $14 constant FLASH_BFB2                     \ [0x14] Dual-bank boot
    $15 constant FLASH_DUALBANK                 \ [0x15] Dual-Bank on 512 KB or 256 KB Flash memory devices
    $17 constant FLASH_nBOOT1                   \ [0x17] Boot configuration
    $18 constant FLASH_SRAM2_PE                 \ [0x18] SRAM2 parity check enable
    $19 constant FLASH_SRAM2_RST                \ [0x19] SRAM2 Erase when system reset
    $1a constant FLASH_nSWBOOT0                 \ [0x1a] Software BOOT0
    $1b constant FLASH_nBOOT0                   \ [0x1b] nBOOT0 option bit
  [then]


  [ifdef] FLASH_PCROP1SR_DEF
    \
    \ @brief Flash Bank 1 PCROP Start address register
    \ Address offset: 0x24
    \ Reset value: 0xFFFF0000
    \
    $00 constant FLASH_PCROP1_STRT              \ [0x00 : 16] Bank 1 PCROP area start offset
  [then]


  [ifdef] FLASH_PCROP1ER_DEF
    \
    \ @brief Flash Bank 1 PCROP End address register
    \ Address offset: 0x28
    \ Reset value: 0x0FFF0000
    \
    $00 constant FLASH_PCROP1_END               \ [0x00 : 16] Bank 1 PCROP area end offset
    $1f constant FLASH_PCROP_RDP                \ [0x1f] PCROP area preserved when RDP level decreased
  [then]


  [ifdef] FLASH_WRP1AR_DEF
    \
    \ @brief Flash Bank 1 WRP area A address register
    \ Address offset: 0x2C
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP1A_STRT               \ [0x00 : 8] Bank 1 WRP first area start offset
    $10 constant FLASH_WRP1A_END                \ [0x10 : 8] Bank 1 WRP first area A end offset
  [then]


  [ifdef] FLASH_WRP1BR_DEF
    \
    \ @brief Flash Bank 1 WRP area B address register
    \ Address offset: 0x30
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP1B_STRT               \ [0x00 : 8] Bank 1 WRP second area B start offset
    $10 constant FLASH_WRP1B_END                \ [0x10 : 8] Bank 1 WRP second area B end offset
  [then]


  [ifdef] FLASH_PCROP2SR_DEF
    \
    \ @brief Flash Bank 2 PCROP Start address register
    \ Address offset: 0x44
    \ Reset value: 0xFFFF0000
    \
    $00 constant FLASH_PCROP2_STRT              \ [0x00 : 16] Bank 2 PCROP area start offset
  [then]


  [ifdef] FLASH_PCROP2ER_DEF
    \
    \ @brief Flash Bank 2 PCROP End address register
    \ Address offset: 0x48
    \ Reset value: 0xFFFF0000
    \
    $00 constant FLASH_PCROP2_END               \ [0x00 : 16] Bank 2 PCROP area end offset
  [then]


  [ifdef] FLASH_WRP2AR_DEF
    \
    \ @brief Flash Bank 2 WRP area A address register
    \ Address offset: 0x4C
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP2A_STRT               \ [0x00 : 8] Bank 2 WRP first area A start offset
    $10 constant FLASH_WRP2A_END                \ [0x10 : 8] Bank 2 WRP first area A end offset
  [then]


  [ifdef] FLASH_WRP2BR_DEF
    \
    \ @brief Flash Bank 2 WRP area B address register
    \ Address offset: 0x50
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP2B_STRT               \ [0x00 : 8] Bank 2 WRP second area B start offset
    $10 constant FLASH_WRP2B_END                \ [0x10 : 8] Bank 2 WRP second area B end offset
  [then]

  \
  \ @brief Flash
  \
  $00 constant FLASH_ACR                \ Access control register
  $04 constant FLASH_PDKEYR             \ Power down key register
  $08 constant FLASH_KEYR               \ Flash key register
  $0C constant FLASH_OPTKEYR            \ Option byte key register
  $10 constant FLASH_SR                 \ Status register
  $14 constant FLASH_CR                 \ Flash control register
  $18 constant FLASH_ECCR               \ Flash ECC register
  $20 constant FLASH_OPTR               \ Flash option register
  $24 constant FLASH_PCROP1SR           \ Flash Bank 1 PCROP Start address register
  $28 constant FLASH_PCROP1ER           \ Flash Bank 1 PCROP End address register
  $2C constant FLASH_WRP1AR             \ Flash Bank 1 WRP area A address register
  $30 constant FLASH_WRP1BR             \ Flash Bank 1 WRP area B address register
  $44 constant FLASH_PCROP2SR           \ Flash Bank 2 PCROP Start address register
  $48 constant FLASH_PCROP2ER           \ Flash Bank 2 PCROP End address register
  $4C constant FLASH_WRP2AR             \ Flash Bank 2 WRP area A address register
  $50 constant FLASH_WRP2BR             \ Flash Bank 2 WRP area B address register

: FLASH_DEF ; [then]
