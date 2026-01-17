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
    $0b constant FLASH_ICRST                    \ [0x0b] Instruction cache reset
    $10 constant FLASH_EMPTY                    \ [0x10] Flash User area empty
    $12 constant FLASH_DBG_SWEN                 \ [0x12] Debug access software enable
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
    $0f constant FLASH_OPTVERR                  \ [0x0f] Option and Engineering bits loading validity error
    $10 constant FLASH_BSY                      \ [0x10] Busy
    $12 constant FLASH_CFGBSY                   \ [0x12] Programming or erase configuration busy.
  [then]


  [ifdef] FLASH_CR_DEF
    \
    \ @brief Flash control register
    \ Address offset: 0x14
    \ Reset value: 0xC0000000
    \
    $00 constant FLASH_PG                       \ [0x00] Programming
    $01 constant FLASH_PER                      \ [0x01] Page erase
    $02 constant FLASH_MER1                     \ [0x02] Mass erase
    $03 constant FLASH_PNB                      \ [0x03 : 10] Page number
    $0d constant FLASH_BKER                     \ [0x0d] Bank selection for erase operation
    $0d constant FLASH_BKER                     \ [0x0d] Bank selection for erase operation
    $0f constant FLASH_MER2                     \ [0x0f] Mass erase, Bank 2
    $11 constant FLASH_OPTSTRT                  \ [0x11] Options modification start
    $12 constant FLASH_FSTPG                    \ [0x12] Fast programming
    $18 constant FLASH_EOPIE                    \ [0x18] End of operation interrupt enable
    $19 constant FLASH_ERRIE                    \ [0x19] Error interrupt enable
    $1a constant FLASH_RDERRIE                  \ [0x1a] PCROP read error interrupt enable
    $1b constant FLASH_OBL_LAUNCH               \ [0x1b] Force the option byte loading
    $1c constant FLASH_SEC_PROT                 \ [0x1c] Securable memory area protection enable
    $1d constant FLASH_SEC_PROT2                \ [0x1d] Securable memory area protection enable, Bank 2
    $1e constant FLASH_OPTLOCK                  \ [0x1e] Options Lock
    $1f constant FLASH_LOCK                     \ [0x1f] FLASH_CR Lock
  [then]


  [ifdef] FLASH_ECCR_DEF
    \
    \ @brief Flash ECC register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 15] ECC fail address
    $14 constant FLASH_SYSF_ECC                 \ [0x14] ECC fail for Corrected ECC Error or Double ECC Error in info block
    $18 constant FLASH_ECCIE                    \ [0x18] ECC correction interrupt enable
    $1e constant FLASH_ECCC                     \ [0x1e] ECC correction
    $1f constant FLASH_ECCD                     \ [0x1f] ECC detection
  [then]


  [ifdef] FLASH_ECCR2_DEF
    \
    \ @brief Flash ECC register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 15] ECC fail address
    $14 constant FLASH_SYSF_ECC                 \ [0x14] ECC fail for Corrected ECC Error or Double ECC Error in info block
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
    $08 constant FLASH_BOREN                    \ [0x08] BOR reset Level
    $09 constant FLASH_BORF_LEV                 \ [0x09 : 2] These bits contain the VDD supply level threshold that activates the reset
    $0b constant FLASH_BORR_LEV                 \ [0x0b : 2] These bits contain the VDD supply level threshold that releases the reset.
    $0d constant FLASH_nRST_STOP                \ [0x0d] nRST_STOP
    $0e constant FLASH_nRST_STDBY               \ [0x0e] nRST_STDBY
    $0f constant FLASH_nRSTS_HDW                \ [0x0f] nRSTS_HDW
    $10 constant FLASH_IDWG_SW                  \ [0x10] Independent watchdog selection
    $11 constant FLASH_IWDG_STOP                \ [0x11] Independent watchdog counter freeze in Stop mode
    $12 constant FLASH_IWDG_STDBY               \ [0x12] Independent watchdog counter freeze in Standby mode
    $13 constant FLASH_WWDG_SW                  \ [0x13] Window watchdog selection
    $16 constant FLASH_RAM_PARITY_CHECK         \ [0x16] SRAM parity check control
    $18 constant FLASH_nBOOT_SEL                \ [0x18] nBOOT_SEL
    $19 constant FLASH_nBOOT1                   \ [0x19] Boot configuration
    $1a constant FLASH_nBOOT0                   \ [0x1a] nBOOT0 option bit
    $1b constant FLASH_NRST_MODE                \ [0x1b : 2] NRST_MODE
    $1d constant FLASH_IRHEN                    \ [0x1d] Internal reset holder enable bit
  [then]


  [ifdef] FLASH_PCROP1ASR_DEF
    \
    \ @brief Flash PCROP zone A Start address register
    \ Address offset: 0x24
    \ Reset value: 0xF0000000
    \
    $00 constant FLASH_PCROP1A_STRT             \ [0x00 : 8] PCROP1A area start offset
  [then]


  [ifdef] FLASH_PCROP1AER_DEF
    \
    \ @brief Flash PCROP zone A End address register
    \ Address offset: 0x28
    \ Reset value: 0xF0000000
    \
    $00 constant FLASH_PCROP1A_END              \ [0x00 : 8] PCROP1A area end offset
    $1f constant FLASH_PCROP_RDP                \ [0x1f] PCROP area preserved when RDP level decreased
  [then]


  [ifdef] FLASH_WRP1AR_DEF
    \
    \ @brief Flash WRP area A address register
    \ Address offset: 0x2C
    \ Reset value: 0xF0000000
    \
    $00 constant FLASH_WRP1A_STRT               \ [0x00 : 6] WRP area A start offset
    $10 constant FLASH_WRP1A_END                \ [0x10 : 6] WRP area A end offset
  [then]


  [ifdef] FLASH_WRP1BR_DEF
    \
    \ @brief Flash WRP area B address register
    \ Address offset: 0x30
    \ Reset value: 0xF0000000
    \
    $00 constant FLASH_WRP1B_STRT               \ [0x00 : 6] WRP area B start offset
    $10 constant FLASH_WRP1B_END                \ [0x10 : 6] WRP area B end offset
  [then]


  [ifdef] FLASH_PCROP1BSR_DEF
    \
    \ @brief Flash PCROP zone B Start address register
    \ Address offset: 0x34
    \ Reset value: 0xF0000000
    \
    $00 constant FLASH_PCROP1B_STRT             \ [0x00 : 8] PCROP1B area start offset
  [then]


  [ifdef] FLASH_PCROP1BER_DEF
    \
    \ @brief Flash PCROP area B End address register
    \ Address offset: 0x38
    \ Reset value: 0xF0000000
    \
    $00 constant FLASH_PCROP1B_END              \ [0x00 : 9] PCROP1B area end offset
  [then]


  [ifdef] FLASH_PCROP2ASR_DEF
    \
    \ @brief Flash PCROP2 area A start address register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PCROP2A_STRT             \ [0x00 : 9] PCROP2A area start offset, bank2
  [then]


  [ifdef] FLASH_PCROP2AER_DEF
    \
    \ @brief Flash PCROP2 area A end address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PCROP2A_END              \ [0x00 : 9] PCROP2A area end offset, bank2
  [then]


  [ifdef] FLASH_WRP2AR_DEF
    \
    \ @brief Flash WRP2 area A address register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRP2A_STRT               \ [0x00 : 7] WRP area A start offset, Bank 2
    $10 constant FLASH_WRP2A_END                \ [0x10 : 7] WRP area A end offset, Bank 2
  [then]


  [ifdef] FLASH_WRP2BR_DEF
    \
    \ @brief Flash WRP2 area B address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRP2B_STRT               \ [0x00 : 7] WRP area B start offset, Bank 2
    $10 constant FLASH_WRP2B_END                \ [0x10 : 7] WRP area B end offset, Bank 2
  [then]


  [ifdef] FLASH_PCROP2BSR_DEF
    \
    \ @brief FLASH PCROP2 area B start address register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PCROP2B_STRT             \ [0x00 : 9] PCROP2B area start offset, Bank 2
  [then]


  [ifdef] FLASH_PCROP2BER_DEF
    \
    \ @brief FLASH PCROP2 area B end address register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PCROP2B_END              \ [0x00 : 9] PCROP2B area end offset, Bank 2
  [then]


  [ifdef] FLASH_SECR_DEF
    \
    \ @brief Flash Security register
    \ Address offset: 0x80
    \ Reset value: 0xF0000000
    \
    $00 constant FLASH_SEC_SIZE                 \ [0x00 : 8] Securable memory area size
    $10 constant FLASH_BOOT_LOCK                \ [0x10] used to force boot from user area
    $14 constant FLASH_SEC_SIZE2                \ [0x14 : 8] Securable memory area size
  [then]

  \
  \ @brief Flash
  \
  $00 constant FLASH_ACR                \ Access control register
  $08 constant FLASH_KEYR               \ Flash key register
  $0C constant FLASH_OPTKEYR            \ Option byte key register
  $10 constant FLASH_SR                 \ Status register
  $14 constant FLASH_CR                 \ Flash control register
  $18 constant FLASH_ECCR               \ Flash ECC register
  $1C constant FLASH_ECCR2              \ Flash ECC register 2
  $20 constant FLASH_OPTR               \ Flash option register
  $24 constant FLASH_PCROP1ASR          \ Flash PCROP zone A Start address register
  $28 constant FLASH_PCROP1AER          \ Flash PCROP zone A End address register
  $2C constant FLASH_WRP1AR             \ Flash WRP area A address register
  $30 constant FLASH_WRP1BR             \ Flash WRP area B address register
  $34 constant FLASH_PCROP1BSR          \ Flash PCROP zone B Start address register
  $38 constant FLASH_PCROP1BER          \ Flash PCROP area B End address register
  $44 constant FLASH_PCROP2ASR          \ Flash PCROP2 area A start address register
  $48 constant FLASH_PCROP2AER          \ Flash PCROP2 area A end address register
  $4C constant FLASH_WRP2AR             \ Flash WRP2 area A address register
  $50 constant FLASH_WRP2BR             \ Flash WRP2 area B address register
  $54 constant FLASH_PCROP2BSR          \ FLASH PCROP2 area B start address register
  $58 constant FLASH_PCROP2BER          \ FLASH PCROP2 area B end address register
  $80 constant FLASH_SECR               \ Flash Security register

: FLASH_DEF ; [then]
