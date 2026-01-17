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
    $0f constant FLASH_PES                      \ [0x0f] CPU1 programm erase suspend request
    $10 constant FLASH_EMPTY                    \ [0x10] Flash User area empty
  [then]


  [ifdef] FLASH_ACR2_DEF
    \
    \ @brief Flash access control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVMODE                 \ [0x00] CFI privileged mode enable
    $01 constant FLASH_HDPADIS                  \ [0x01] Flash user hide protection area access disable
    $02 constant FLASH_C2SWDBGEN                \ [0x02] CPU2 Software debug enable
  [then]


  [ifdef] FLASH_KEYR_DEF
    \
    \ @brief Flash key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_KEY                      \ [0x00 : 32] KEY
  [then]


  [ifdef] FLASH_OPTKEYR_DEF
    \
    \ @brief Option byte key register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEY                   \ [0x00 : 32] Option byte key
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
    $0d constant FLASH_OPTVN                    \ [0x0d] User Option OPTIVAL indication
    $0e constant FLASH_RDERR                    \ [0x0e] PCROP read error
    $0f constant FLASH_OPTVERR                  \ [0x0f] Option validity error
    $10 constant FLASH_BSY                      \ [0x10] Busy
    $12 constant FLASH_CFGBSY                   \ [0x12] Programming or erase configuration busy
    $13 constant FLASH_PESD                     \ [0x13] Programming / erase operation suspended
  [then]


  [ifdef] FLASH_CR_DEF
    \
    \ @brief Flash control register
    \ Address offset: 0x14
    \ Reset value: 0xC0000000
    \
    $00 constant FLASH_PG                       \ [0x00] Programming
    $01 constant FLASH_PER                      \ [0x01] Page erase
    $02 constant FLASH_MER                      \ [0x02] Mass erase
    $03 constant FLASH_PNB                      \ [0x03 : 7] Page number
    $10 constant FLASH_STRT                     \ [0x10] Start
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
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 17] ECC fail address
    $14 constant FLASH_SYSF_ECC                 \ [0x14] System Flash ECC fail
    $18 constant FLASH_ECCCIE                   \ [0x18] ECC correction interrupt enable
    $1a constant FLASH_CPUID                    \ [0x1a : 3] CPU identification
    $1e constant FLASH_ECCC                     \ [0x1e] ECC correction
    $1f constant FLASH_ECCD                     \ [0x1f] ECC detection
  [then]


  [ifdef] FLASH_OPTR_DEF
    \
    \ @brief Flash option register
    \ Address offset: 0x20
    \ Reset value: 0x3FFFF0AA
    \
    $00 constant FLASH_RDP                      \ [0x00 : 8] Read protection level
    $08 constant FLASH_ESE                      \ [0x08] System security enabled flag
    $09 constant FLASH_BOR_LEV                  \ [0x09 : 3] BOR reset Level
    $0c constant FLASH_nRST_STOP                \ [0x0c] nRST_STOP
    $0d constant FLASH_nRST_STDBY               \ [0x0d] nRST_STDBY
    $0e constant FLASH_nRST_SHDW                \ [0x0e] nRSTSHDW
    $10 constant FLASH_IWDG_SW                  \ [0x10] Independent watchdog selection
    $11 constant FLASH_IWDG_STOP                \ [0x11] Independent watchdog counter freeze in Stop mode
    $12 constant FLASH_IWDG_STDBY               \ [0x12] Independent watchdog counter freeze in Standby mode
    $13 constant FLASH_WWDG_SW                  \ [0x13] Window watchdog selection
    $17 constant FLASH_nBOOT1                   \ [0x17] Boot configuration
    $18 constant FLASH_SRAM2_PE                 \ [0x18] SRAM2 parity check enable
    $19 constant FLASH_SRAM2_RST                \ [0x19] SRAM2 Erase when system reset
    $1a constant FLASH_nSWBOOT0                 \ [0x1a] Software BOOT0 selection
    $1b constant FLASH_nBOOT0                   \ [0x1b] nBOOT0 option bit
    $1e constant FLASH_BOOT_LOCK                \ [0x1e] CPU1 CM4 Unique Boot entry enable option bit
    $1f constant FLASH_C2BOOT_LOCK              \ [0x1f] CPU2 CM0+ Unique Boot entry enable option bit
  [then]


  [ifdef] FLASH_PCROP1ASR_DEF
    \
    \ @brief Flash PCROP zone A Start address register
    \ Address offset: 0x24
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FLASH_PCROP1A_STRT             \ [0x00 : 8] PCROP1A area start offset
  [then]


  [ifdef] FLASH_PCROP1AER_DEF
    \
    \ @brief Flash PCROP zone A End address register
    \ Address offset: 0x28
    \ Reset value: 0xFFFFFF00
    \
    $00 constant FLASH_PCROP1A_END              \ [0x00 : 8] PCROP area end offset
    $1f constant FLASH_PCROP_RDP                \ [0x1f] PCROP area preserved when RDP level decreased
  [then]


  [ifdef] FLASH_WRP1AR_DEF
    \
    \ @brief Flash WRP area A address register
    \ Address offset: 0x2C
    \ Reset value: 0xFF80FFFF
    \
    $00 constant FLASH_WRP1A_STRT               \ [0x00 : 7] Bank 1 WRP first area start offset
    $10 constant FLASH_WRP1A_END                \ [0x10 : 7] Bank 1 WRP first area A end offset
  [then]


  [ifdef] FLASH_WRP1BR_DEF
    \
    \ @brief Flash WRP area B address register
    \ Address offset: 0x30
    \ Reset value: 0xFF80FFFF
    \
    $00 constant FLASH_WRP1B_STRT               \ [0x00 : 7] Bank 1 WRP second area B end offset
    $10 constant FLASH_WRP1B_END                \ [0x10 : 7] Bank 1 WRP second area B start offset
  [then]


  [ifdef] FLASH_PCROP1BSR_DEF
    \
    \ @brief Flash PCROP zone B Start address register
    \ Address offset: 0x34
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FLASH_PCROP1B_STRT             \ [0x00 : 8] Bank 1 WRP second area B end offset
  [then]


  [ifdef] FLASH_PCROP1BER_DEF
    \
    \ @brief Flash PCROP zone B End address register
    \ Address offset: 0x38
    \ Reset value: 0xFFFFFF00
    \
    $00 constant FLASH_PCROP1B_END              \ [0x00 : 8] PCROP1B area end offset
  [then]


  [ifdef] FLASH_IPCCBR_DEF
    \
    \ @brief Flash IPCC data buffer address register
    \ Address offset: 0x3C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FLASH_IPCCDBA                  \ [0x00 : 14] IPCCDBA
  [then]


  [ifdef] FLASH_C2ACR_DEF
    \
    \ @brief Flash CPU2 access control register
    \ Address offset: 0x5C
    \ Reset value: 0x00000600
    \
    $08 constant FLASH_PRFTEN                   \ [0x08] CPU2 Prefetch enable
    $09 constant FLASH_ICEN                     \ [0x09] CPU2 Instruction cache enable
    $0b constant FLASH_ICRST                    \ [0x0b] CPU2 Instruction cache reset
    $0f constant FLASH_PES                      \ [0x0f] CPU2 program / erase suspend request
  [then]


  [ifdef] FLASH_C2SR_DEF
    \
    \ @brief Flash CPU2 status register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EOP                      \ [0x00] End of operation
    $01 constant FLASH_OPERR                    \ [0x01] Operation error
    $03 constant FLASH_PROGERR                  \ [0x03] Programming error
    $04 constant FLASH_WRPERR                   \ [0x04] WRPERR
    $05 constant FLASH_PGAERR                   \ [0x05] PGAERR
    $06 constant FLASH_SIZERR                   \ [0x06] Size error
    $07 constant FLASH_PGSERR                   \ [0x07] Programming sequence error
    $08 constant FLASH_MISERR                   \ [0x08] Fast programming data miss error
    $09 constant FLASH_FASTERR                  \ [0x09] Fast programming error
    $0e constant FLASH_RDERR                    \ [0x0e] PCROP read error
    $10 constant FLASH_BSY                      \ [0x10] BSY
    $12 constant FLASH_CFGBSY                   \ [0x12] CFGBSY
    $13 constant FLASH_PESD                     \ [0x13] PESD
  [then]


  [ifdef] FLASH_C2CR_DEF
    \
    \ @brief Flash CPU2 control register
    \ Address offset: 0x64
    \ Reset value: 0xC0000000
    \
    $00 constant FLASH_PG                       \ [0x00] Programming
    $01 constant FLASH_PER                      \ [0x01] Page erase
    $02 constant FLASH_MER                      \ [0x02] Mass erase
    $03 constant FLASH_PNB                      \ [0x03 : 7] Page number selection
    $10 constant FLASH_STRT                     \ [0x10] Start
    $12 constant FLASH_FSTPG                    \ [0x12] Fast programming
    $18 constant FLASH_EOPIE                    \ [0x18] End of operation interrupt enable
    $19 constant FLASH_ERRIE                    \ [0x19] Error interrupt enable
    $1a constant FLASH_RDERRIE                  \ [0x1a] RDERRIE
  [then]


  [ifdef] FLASH_SFR_DEF
    \
    \ @brief Flash secure Flash start address register
    \ Address offset: 0x80
    \ Reset value: 0xFFFFEFFF
    \
    $00 constant FLASH_SFSA                     \ [0x00 : 7] Secure Flash start address
    $07 constant FLASH_FSD                      \ [0x07] Flash security disabled
    $0c constant FLASH_DDS                      \ [0x0c] DDS
    $10 constant FLASH_HDPSA                    \ [0x10 : 7] User Flash hide protection area start address
    $17 constant FLASH_HDPAD                    \ [0x17] User Flash hide protection area disabled
    $1f constant FLASH_SUBGHSPISD               \ [0x1f] sub-GHz radio SPI security disable
  [then]


  [ifdef] FLASH_SRRVR_DEF
    \
    \ @brief Flash secure SRAM start address and CPU2 reset vector register
    \ Address offset: 0x84
    \ Reset value: 0xFFFF8000
    \
    $00 constant FLASH_SBRV                     \ [0x00 : 16] CPU2 boot reset vector
    $12 constant FLASH_SBRSA                    \ [0x12 : 5] Secure backup SRAM2 start address
    $17 constant FLASH_BRSD                     \ [0x17] backup SRAM2 security disable
    $19 constant FLASH_SNBRSA                   \ [0x19 : 5] Secure non-backup SRAM1 start address
    $1e constant FLASH_NBRSD                    \ [0x1e] NBRSD
    $1f constant FLASH_C2OPT                    \ [0x1f] C2OPT
  [then]

  \
  \ @brief Flash
  \
  $00 constant FLASH_ACR                \ Access control register
  $04 constant FLASH_ACR2               \ Flash access control register 2
  $08 constant FLASH_KEYR               \ Flash key register
  $0C constant FLASH_OPTKEYR            \ Option byte key register
  $10 constant FLASH_SR                 \ Status register
  $14 constant FLASH_CR                 \ Flash control register
  $18 constant FLASH_ECCR               \ Flash ECC register
  $20 constant FLASH_OPTR               \ Flash option register
  $24 constant FLASH_PCROP1ASR          \ Flash PCROP zone A Start address register
  $28 constant FLASH_PCROP1AER          \ Flash PCROP zone A End address register
  $2C constant FLASH_WRP1AR             \ Flash WRP area A address register
  $30 constant FLASH_WRP1BR             \ Flash WRP area B address register
  $34 constant FLASH_PCROP1BSR          \ Flash PCROP zone B Start address register
  $38 constant FLASH_PCROP1BER          \ Flash PCROP zone B End address register
  $3C constant FLASH_IPCCBR             \ Flash IPCC data buffer address register
  $5C constant FLASH_C2ACR              \ Flash CPU2 access control register
  $60 constant FLASH_C2SR               \ Flash CPU2 status register
  $64 constant FLASH_C2CR               \ Flash CPU2 control register
  $80 constant FLASH_SFR                \ Flash secure Flash start address register
  $84 constant FLASH_SRRVR              \ Flash secure SRAM start address and CPU2 reset vector register

: FLASH_DEF ; [then]
