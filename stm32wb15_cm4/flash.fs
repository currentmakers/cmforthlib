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
    $0f constant FLASH_PES                      \ [0x0f] CPU1 CortexM4 program erase suspend request
    $10 constant FLASH_EMPTY                    \ [0x10] Flash User area empty
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
    $0d constant FLASH_OPTNV                    \ [0x0d] User Option OPTVAL indication
    $0e constant FLASH_RDERR                    \ [0x0e] PCROP read error
    $0f constant FLASH_OPTVERR                  \ [0x0f] Option validity error
    $10 constant FLASH_BSY                      \ [0x10] Busy
    $12 constant FLASH_CFGBSY                   \ [0x12] Programming or erase configuration busy
    $13 constant FLASH_PESD                     \ [0x13] Programming or erase operation suspended
  [then]


  [ifdef] FLASH_CR_DEF
    \
    \ @brief Flash control register
    \ Address offset: 0x14
    \ Reset value: 0xC0000000
    \
    $00 constant FLASH_PG                       \ [0x00] Programming
    $01 constant FLASH_PER                      \ [0x01] Page erase
    $02 constant FLASH_MER                      \ [0x02] This bit triggers the mass erase (all user pages) when set
    $03 constant FLASH_PNB                      \ [0x03 : 8] Page number selection
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
    \ Reset value: 0x10708000
    \
    $00 constant FLASH_RDP                      \ [0x00 : 8] Read protection level
    $08 constant FLASH_ESE                      \ [0x08] Security enabled
    $09 constant FLASH_BOR_LEV                  \ [0x09 : 3] BOR reset Level
    $0c constant FLASH_nRST_STOP                \ [0x0c] nRST_STOP
    $0d constant FLASH_nRST_STDBY               \ [0x0d] nRST_STDBY
    $0e constant FLASH_nRST_SHDW                \ [0x0e] nRST_SHDW
    $10 constant FLASH_IDWG_SW                  \ [0x10] Independent watchdog selection
    $11 constant FLASH_IWDG_STOP                \ [0x11] Independent watchdog counter freeze in Stop mode
    $12 constant FLASH_IWDG_STDBY               \ [0x12] Independent watchdog counter freeze in Standby mode
    $13 constant FLASH_WWDG_SW                  \ [0x13] Window watchdog selection
    $17 constant FLASH_nBOOT1                   \ [0x17] Boot configuration
    $18 constant FLASH_SRAM2_PE                 \ [0x18] SRAM2 parity check enable
    $19 constant FLASH_SRAM2_RST                \ [0x19] SRAM2 Erase when system reset
    $1a constant FLASH_nSWBOOT0                 \ [0x1a] Software Boot0
    $1b constant FLASH_nBOOT0                   \ [0x1b] nBoot0 option bit
    $1d constant FLASH_AGC_TRIM                 \ [0x1d : 3] Radio Automatic Gain Control Trimming
  [then]


  [ifdef] FLASH_PCROP1ASR_DEF
    \
    \ @brief Flash Bank 1 PCROP Start address zone A register
    \ Address offset: 0x24
    \ Reset value: 0xFFFFFE00
    \
    $00 constant FLASH_PCROP1A_STRT             \ [0x00 : 9] Bank 1 PCROPQ area start offset
  [then]


  [ifdef] FLASH_PCROP1AER_DEF
    \
    \ @brief Flash Bank 1 PCROP End address zone A register
    \ Address offset: 0x28
    \ Reset value: 0x7FFFFE00
    \
    $00 constant FLASH_PCROP1A_END              \ [0x00 : 9] Bank 1 PCROP area end offset
    $1f constant FLASH_PCROP_RDP                \ [0x1f] PCROP area preserved when RDP level decreased
  [then]


  [ifdef] FLASH_WRP1AR_DEF
    \
    \ @brief Flash Bank 1 WRP area A address register
    \ Address offset: 0x2C
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP1A_STRT               \ [0x00 : 8] Bank 1 WRP first area A start offset
    $10 constant FLASH_WRP1A_END                \ [0x10 : 8] Bank 1 WRP first area A end offset
  [then]


  [ifdef] FLASH_WRP1BR_DEF
    \
    \ @brief Flash Bank 1 WRP area B address register
    \ Address offset: 0x30
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP1B_END                \ [0x00 : 8] Bank 1 WRP second area B start offset
    $10 constant FLASH_WRP1B_STRT               \ [0x10 : 8] Bank 1 WRP second area B end offset
  [then]


  [ifdef] FLASH_PCROP1BSR_DEF
    \
    \ @brief Flash Bank 1 PCROP Start address area B register
    \ Address offset: 0x34
    \ Reset value: 0xFFFFFE00
    \
    $00 constant FLASH_PCROP1B_STRT             \ [0x00 : 9] Bank 1 PCROP area B start offset
  [then]


  [ifdef] FLASH_PCROP1BER_DEF
    \
    \ @brief Flash Bank 1 PCROP End address area B register
    \ Address offset: 0x38
    \ Reset value: 0xFFFFFE00
    \
    $00 constant FLASH_PCROP1B_END              \ [0x00 : 9] Bank 1 PCROP area end area B offset
  [then]


  [ifdef] FLASH_IPCCBR_DEF
    \
    \ @brief IPCC mailbox data buffer address register
    \ Address offset: 0x3C
    \ Reset value: 0xFFFFC000
    \
    $00 constant FLASH_IPCCDBA                  \ [0x00 : 14] PCC mailbox data buffer base address
  [then]


  [ifdef] FLASH_C2ACR_DEF
    \
    \ @brief CPU2 cortex M0 access control register
    \ Address offset: 0x5C
    \ Reset value: 0x00000600
    \
    $08 constant FLASH_PRFTEN                   \ [0x08] CPU2 cortex M0 prefetch enable
    $09 constant FLASH_ICEN                     \ [0x09] CPU2 cortex M0 instruction cache enable
    $0b constant FLASH_ICRST                    \ [0x0b] CPU2 cortex M0 instruction cache reset
    $0f constant FLASH_PES                      \ [0x0f] CPU2 cortex M0 program erase suspend request
  [then]


  [ifdef] FLASH_C2SR_DEF
    \
    \ @brief CPU2 cortex M0 status register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EOP                      \ [0x00] End of operation
    $01 constant FLASH_OPERR                    \ [0x01] Operation error
    $03 constant FLASH_PROGERR                  \ [0x03] Programming error
    $04 constant FLASH_WRPERR                   \ [0x04] write protection error
    $05 constant FLASH_PGAERR                   \ [0x05] Programming alignment error
    $06 constant FLASH_SIZERR                   \ [0x06] Size error
    $07 constant FLASH_PGSERR                   \ [0x07] Programming sequence error
    $08 constant FLASH_MISSERR                  \ [0x08] Fast programming data miss error
    $09 constant FLASH_FASTERR                  \ [0x09] Fast programming error
    $0e constant FLASH_RDERR                    \ [0x0e] PCROP read error
    $10 constant FLASH_BSY                      \ [0x10] Busy
    $12 constant FLASH_CFGBSY                   \ [0x12] Programming or erase configuration busy
    $13 constant FLASH_PESD                     \ [0x13] Programming or erase operation suspended
  [then]


  [ifdef] FLASH_C2CR_DEF
    \
    \ @brief CPU2 cortex M0 control register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PG                       \ [0x00] Programming
    $01 constant FLASH_PER                      \ [0x01] Page erase
    $02 constant FLASH_MER                      \ [0x02] Masse erase
    $03 constant FLASH_PNB                      \ [0x03 : 8] Page Number selection
    $10 constant FLASH_STRT                     \ [0x10] Start
    $12 constant FLASH_FSTPG                    \ [0x12] Fast programming
    $18 constant FLASH_EOPIE                    \ [0x18] End of operation interrupt enable
    $19 constant FLASH_ERRIE                    \ [0x19] Error interrupt enable
    $1a constant FLASH_RDERRIE                  \ [0x1a] PCROP read error interrupt enable
  [then]


  [ifdef] FLASH_SFR_DEF
    \
    \ @brief Secure flash start address register
    \ Address offset: 0x80
    \ Reset value: 0xFFFFEE00
    \
    $00 constant FLASH_SFSA                     \ [0x00 : 8] Secure flash start address
    $08 constant FLASH_FSD                      \ [0x08] Flash security disable
    $0c constant FLASH_DDS                      \ [0x0c] Disable Cortex M0 debug access
  [then]


  [ifdef] FLASH_SRRVR_DEF
    \
    \ @brief Secure SRAM2 start address and cortex M0 reset vector register
    \ Address offset: 0x84
    \ Reset value: 0x01000000
    \
    $00 constant FLASH_SBRV                     \ [0x00 : 17] cortex M0 access control register
    $12 constant FLASH_SBRSA                    \ [0x12 : 5] Secure backup SRAM2a start address
    $17 constant FLASH_BRSD                     \ [0x17] backup SRAM2a security disable
    $19 constant FLASH_SNBRSA                   \ [0x19 : 5] Secure non backup SRAM2a start address
    $1e constant FLASH_NBRSD                    \ [0x1e] non-backup SRAM2b security disable
    $1f constant FLASH_C2OPT                    \ [0x1f] CPU2 cortex M0 boot reset vector memory selection
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
  $20 constant FLASH_OPTR               \ Flash option register
  $24 constant FLASH_PCROP1ASR          \ Flash Bank 1 PCROP Start address zone A register
  $28 constant FLASH_PCROP1AER          \ Flash Bank 1 PCROP End address zone A register
  $2C constant FLASH_WRP1AR             \ Flash Bank 1 WRP area A address register
  $30 constant FLASH_WRP1BR             \ Flash Bank 1 WRP area B address register
  $34 constant FLASH_PCROP1BSR          \ Flash Bank 1 PCROP Start address area B register
  $38 constant FLASH_PCROP1BER          \ Flash Bank 1 PCROP End address area B register
  $3C constant FLASH_IPCCBR             \ IPCC mailbox data buffer address register
  $5C constant FLASH_C2ACR              \ CPU2 cortex M0 access control register
  $60 constant FLASH_C2SR               \ CPU2 cortex M0 status register
  $64 constant FLASH_C2CR               \ CPU2 cortex M0 control register
  $80 constant FLASH_SFR                \ Secure flash start address register
  $84 constant FLASH_SRRVR              \ Secure SRAM2 start address and cortex M0 reset vector register

: FLASH_DEF ; [then]
