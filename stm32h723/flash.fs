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
    \ Reset value: 0x00000037
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 4] Read latency
    $04 constant FLASH_WRHIGHFREQ               \ [0x04 : 2] Flash signal delay
  [then]


  [ifdef] FLASH_KEYR_DEF
    \
    \ @brief FLASH key register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_KEYKEYRR                 \ [0x00 : 32] access configuration unlock key
  [then]


  [ifdef] FLASH_OPTKEYR_DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEYR                  \ [0x00 : 32] Unlock key option bytes
  [then]


  [ifdef] FLASH_CR_DEF
    \
    \ @brief FLASH control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LOCK                     \ [0x00] configuration lock bit
    $01 constant FLASH_PG                       \ [0x01] program enable bit
    $02 constant FLASH_SER                      \ [0x02] sector erase request
    $03 constant FLASH_BER                      \ [0x03] erase request
    $04 constant FLASH_PSIZE                    \ [0x04 : 2] program size
    $06 constant FLASH_FW                       \ [0x06] write forcing control bit
    $07 constant FLASH_START                    \ [0x07] bank or sector erase start control bit
    $08 constant FLASH_SNB                      \ [0x08 : 3] sector erase selection number
    $0f constant FLASH_CRC_EN                   \ [0x0f] CRC control bit
    $10 constant FLASH_EOPIE                    \ [0x10] end-of-program interrupt control bit
    $11 constant FLASH_WRPERRIE                 \ [0x11] write protection error interrupt enable bit
    $12 constant FLASH_PGSERRIE                 \ [0x12] programming sequence error interrupt enable bit
    $13 constant FLASH_STRBERRIE                \ [0x13] strobe error interrupt enable bit
    $15 constant FLASH_INCERRIE                 \ [0x15] inconsistency error interrupt enable bit
    $16 constant FLASH_OPERRIE                  \ [0x16] write/erase error interrupt enable bit
    $17 constant FLASH_RDPERRIE                 \ [0x17] read protection error interrupt enable bit
    $18 constant FLASH_RDSERRIE                 \ [0x18] secure error interrupt enable bit
    $19 constant FLASH_SNECCERRIE               \ [0x19] ECC single correction error interrupt enable bit
    $1a constant FLASH_DBECCERRIE               \ [0x1a] ECC double detection error interrupt enable bit
    $1b constant FLASH_CRCENDIE                 \ [0x1b] end of CRC calculation interrupt enable bit
    $1c constant FLASH_CRCRDERRIE               \ [0x1c] CRC read error interrupt enable bit When CRCRDERRIE1 bit is set to 1, an interrupt is generated when a protected area (PCROP or secure-only) has been detected during the last CRC computation on bank 1. CRCRDERRIE1 can be programmed only when LOCK1 is cleared to 0.
  [then]


  [ifdef] FLASH_SR_DEF
    \
    \ @brief FLASH status register for bank 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY                      \ [0x00] ongoing program flag
    $01 constant FLASH_WBNE                     \ [0x01] write buffer not empty flag
    $02 constant FLASH_QW                       \ [0x02] wait queue flag
    $03 constant FLASH_CRC_BUSY                 \ [0x03] CRC busy flag
    $10 constant FLASH_EOP                      \ [0x10] end-of-program flag
    $11 constant FLASH_WRPERR                   \ [0x11] write protection error flag
    $12 constant FLASH_PGSERR                   \ [0x12] programming sequence error flag
    $13 constant FLASH_STRBERR                  \ [0x13] strobe error flag
    $15 constant FLASH_INCERR                   \ [0x15] inconsistency error flag
    $16 constant FLASH_OPERR                    \ [0x16] write/erase error flag
    $17 constant FLASH_RDPERR                   \ [0x17] read protection error flag
    $18 constant FLASH_RDSERR                   \ [0x18] secure error flag
    $19 constant FLASH_SNECCERR                 \ [0x19] single correction error flag
    $1a constant FLASH_DBECCERR                 \ [0x1a] ECC double detection error flag
    $1b constant FLASH_CRCEND                   \ [0x1b] CRC-complete flag
    $1c constant FLASH_CRCRDERR                 \ [0x1c] CRC read error flag CRCRDERR1 flag is raised when a word is found read protected during a CRC operation on bank 1. An interrupt is generated if CRCRDIE1 and CRCEND1 are set to 1. Writing 1 to CLR_CRCRDERR1 bit in FLASH_CCR1 register clears CRCRDERR1. Note: This flag is valid only when CRCEND1 bit is set to 1
  [then]


  [ifdef] FLASH_CCR_DEF
    \
    \ @brief FLASH clear control register for bank 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $10 constant FLASH_CLR_EOP                  \ [0x10] EOP1 flag clear bit
    $11 constant FLASH_CLR_WRPERR               \ [0x11] WRPERR1 flag clear bit
    $12 constant FLASH_CLR_PGSERR               \ [0x12] PGSERR flag clear bi
    $13 constant FLASH_CLR_STRBERR              \ [0x13] STRBERR flag clear bit
    $15 constant FLASH_CLR_INCERR               \ [0x15] INCERR flag clear bit
    $16 constant FLASH_CLR_OPERR                \ [0x16] OPERR flag clear bit
    $17 constant FLASH_CLR_RDPERR               \ [0x17] RDPERR flag clear bit
    $18 constant FLASH_CLR_RDSERR               \ [0x18] RDSERR flag clear bit
    $19 constant FLASH_CLR_SNECCERR             \ [0x19] SNECCERR flag clear bit
    $1a constant FLASH_CLR_DBECCERR             \ [0x1a] DBECCERR flag clear bit
    $1b constant FLASH_CLR_CRCEND               \ [0x1b] CRCEND flag clear bit
    $1c constant FLASH_CLR_CRCRDERR             \ [0x1c] CRCRDERR1 flag clear bit Setting this bit to 1 resets to 0 CRCRDERR1 flag in FLASH_SR1 register.
  [then]


  [ifdef] FLASH_OPTCR_DEF
    \
    \ @brief FLASH option control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTLOCK                  \ [0x00] FLASH_OPTCR lock option configuration bit
    $01 constant FLASH_OPTSTART                 \ [0x01] Option byte start change option configuration bit
    $1e constant FLASH_OPTCHANGEERRIE           \ [0x1e] Option byte change error interrupt enable bit
  [then]


  [ifdef] FLASH_OPTSR_CUR_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPT_BUSY                 \ [0x00] Option byte change ongoing flag
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] Brownout level option status bit
    $04 constant FLASH_IWDG1_SW                 \ [0x04] IWDG1 control option status bit
    $06 constant FLASH_NRST_STOP_D1             \ [0x06] D1 DStop entry reset option status bit
    $07 constant FLASH_NRST_STBY_D1             \ [0x07] D1 DStandby entry reset option status bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option status byte
    $11 constant FLASH_IWDG_FZ_STOP             \ [0x11] IWDG Stop mode freeze option status bit
    $12 constant FLASH_IWDG_FZ_SDBY             \ [0x12] IWDG Standby mode freeze option status bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM RAM size option status
    $15 constant FLASH_SECURITY                 \ [0x15] Security enable option status bit
    $1d constant FLASH_IO_HSLV                  \ [0x1d] I/O high-speed at low-voltage status bit (PRODUCT_BELOW_25V)
    $1e constant FLASH_OPTCHANGEERR             \ [0x1e] Option byte change error flag
  [then]


  [ifdef] FLASH_OPTSR_PRG_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] BOR reset level option configuration bits
    $04 constant FLASH_IWDG1_SW                 \ [0x04] IWDG1 option configuration bit
    $06 constant FLASH_NRST_STOP_D1             \ [0x06] Option byte erase after D1 DStop option configuration bit
    $07 constant FLASH_NRST_STBY_D1             \ [0x07] Option byte erase after D1 DStandby option configuration bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option configuration byte
    $11 constant FLASH_IWDG_FZ_STOP             \ [0x11] IWDG Stop mode freeze option configuration bit
    $12 constant FLASH_IWDG_FZ_SDBY             \ [0x12] IWDG Standby mode freeze option configuration bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM size select option configuration bits
    $15 constant FLASH_SECURITY                 \ [0x15] Security option configuration bit
    $1d constant FLASH_IO_HSLV                  \ [0x1d] I/O high-speed at low-voltage (PRODUCT_BELOW_25V)
  [then]


  [ifdef] FLASH_OPTCCR_DEF
    \
    \ @brief FLASH option clear control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $1e constant FLASH_CLR_OPTCHANGEERR         \ [0x1e] OPTCHANGEERR reset bit
  [then]


  [ifdef] FLASH_PRAR_CUR_DEF
    \
    \ @brief FLASH protection address for bank 1
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START          \ [0x00 : 12] lowest PCROP protected address
    $10 constant FLASH_PROT_AREA_END            \ [0x10 : 12] highest PCROP protected address
    $1f constant FLASH_DMEP                     \ [0x1f] PCROP protected erase enable option status bit
  [then]


  [ifdef] FLASH_PRAR_PRG_DEF
    \
    \ @brief FLASH protection address for bank 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START          \ [0x00 : 12] lowest PCROP protected address configuration
    $10 constant FLASH_PROT_AREA_END            \ [0x10 : 12] highest PCROP protected address configuration
    $1f constant FLASH_DMEP                     \ [0x1f] PCROP protected erase enable option configuration bit
  [then]


  [ifdef] FLASH_SCAR_CUR_DEF
    \
    \ @brief FLASH secure address for bank 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START           \ [0x00 : 12] lowest secure protected address
    $10 constant FLASH_SEC_AREA_END             \ [0x10 : 12] highest secure protected address
    $1f constant FLASH_DMES                     \ [0x1f] secure protected erase enable option status bit
  [then]


  [ifdef] FLASH_SCAR_PRG_DEF
    \
    \ @brief FLASH secure address for bank 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START           \ [0x00 : 12] lowest secure protected address configuration
    $10 constant FLASH_SEC_AREA_END             \ [0x10 : 12] highest secure protected address configuration
    $1f constant FLASH_DMES                     \ [0x1f] secure protected erase enable option configuration bit
  [then]


  [ifdef] FLASH_WPSN_CUR_DEF
    \
    \ @brief FLASH write sector protection for bank 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSn                    \ [0x00 : 8] sector write protection option status byte
  [then]


  [ifdef] FLASH_WPSN_PRG_DEF
    \
    \ @brief FLASH write sector protection for bank 1
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSn                    \ [0x00 : 8] sector write protection configuration byte
  [then]


  [ifdef] FLASH_BOOT_CUR_DEF
    \
    \ @brief FLASH register with boot address
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_CM_ADD0             \ [0x00 : 16] Boot address 0
    $10 constant FLASH_BOOT_CM_ADD1             \ [0x10 : 16] Boot address 1
  [then]


  [ifdef] FLASH_BOOT_PRG_DEF
    \
    \ @brief FLASH register with boot address
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_CM_ADD0             \ [0x00 : 16] Boot address 0
    $10 constant FLASH_BOOT_CM_ADD1             \ [0x10 : 16] Boot address 1
  [then]


  [ifdef] FLASH_CRCCR_DEF
    \
    \ @brief FLASH CRC control register for bank 1
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_SECT                 \ [0x00 : 3] CRC sector number
    $08 constant FLASH_CRC_BY_SECT              \ [0x08] CRC sector mode select bit
    $09 constant FLASH_ADD_SECT                 \ [0x09] CRC sector select bit
    $0a constant FLASH_CLEAN_SECT               \ [0x0a] CRC sector list clear bit
    $10 constant FLASH_START_CRC                \ [0x10] CRC start bit
    $11 constant FLASH_CLEAN_CRC                \ [0x11] CRC clear bit
    $14 constant FLASH_CRC_BURST                \ [0x14 : 2] CRC burst size
    $16 constant FLASH_ALL_BANK                 \ [0x16] Bank 1 CRC select bit
  [then]


  [ifdef] FLASH_CRCSADDR_DEF
    \
    \ @brief FLASH CRC start address register for bank 1
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_CRC_START_ADDR           \ [0x02 : 18] CRC start address on bank 1
  [then]


  [ifdef] FLASH_CRCEADDR_DEF
    \
    \ @brief FLASH CRC end address register for bank 1
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_CRC_END_ADDR             \ [0x02 : 18] CRC end address on bank 1
  [then]


  [ifdef] FLASH_CRCDATAR_DEF
    \
    \ @brief FLASH CRC data register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_DATA                 \ [0x00 : 32] CRC result
  [then]


  [ifdef] FLASH_ECC_FAR_DEF
    \
    \ @brief FLASH ECC fail address for bank 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_FAIL_ECC_ADDR            \ [0x00 : 15] ECC error address
  [then]


  [ifdef] FLASH_OPTSR2_CUR_DEF
    \
    \ @brief FLASH ECC fail address for bank 1
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_TCM_AXI_SHARED           \ [0x00 : 2] TCM RAM sharing status bit
    $02 constant FLASH_CPUFREQ_BOOST            \ [0x02] CPU frequency boost status bit
  [then]


  [ifdef] FLASH_OPTSR2_PRG_DEF
    \
    \ @brief FLASH ECC fail address for bank 1
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_TCM_AXI_SHARED           \ [0x00 : 2] TCM RAM sharing status bit
    $02 constant FLASH_CPUFREQ_BOOST            \ [0x02] CPU frequency boost status bit
  [then]

  \
  \ @brief Flash
  \
  $00 constant FLASH_ACR                \ Access control register
  $04 constant FLASH_KEYR               \ FLASH key register
  $08 constant FLASH_OPTKEYR            \ FLASH option key register
  $0C constant FLASH_CR                 \ FLASH control register
  $10 constant FLASH_SR                 \ FLASH status register for bank 1
  $14 constant FLASH_CCR                \ FLASH clear control register for bank 1
  $18 constant FLASH_OPTCR              \ FLASH option control register
  $1C constant FLASH_OPTSR_CUR          \ FLASH option status register
  $20 constant FLASH_OPTSR_PRG          \ FLASH option status register
  $24 constant FLASH_OPTCCR             \ FLASH option clear control register
  $28 constant FLASH_PRAR_CUR           \ FLASH protection address for bank 1
  $2C constant FLASH_PRAR_PRG           \ FLASH protection address for bank 1
  $30 constant FLASH_SCAR_CUR           \ FLASH secure address for bank 1
  $34 constant FLASH_SCAR_PRG           \ FLASH secure address for bank 1
  $38 constant FLASH_WPSN_CUR           \ FLASH write sector protection for bank 1
  $3C constant FLASH_WPSN_PRG           \ FLASH write sector protection for bank 1
  $40 constant FLASH_BOOT_CUR           \ FLASH register with boot address
  $44 constant FLASH_BOOT_PRG           \ FLASH register with boot address
  $50 constant FLASH_CRCCR              \ FLASH CRC control register for bank 1
  $54 constant FLASH_CRCSADDR           \ FLASH CRC start address register for bank 1
  $58 constant FLASH_CRCEADDR           \ FLASH CRC end address register for bank 1
  $5C constant FLASH_CRCDATAR           \ FLASH CRC data register
  $60 constant FLASH_ECC_FAR            \ FLASH ECC fail address for bank 1
  $70 constant FLASH_OPTSR2_CUR         \ FLASH ECC fail address for bank 1
  $74 constant FLASH_OPTSR2_PRG         \ FLASH ECC fail address for bank 1

: FLASH_DEF ; [then]
