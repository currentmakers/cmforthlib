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
    $00 constant FLASH_LATENCY                  \ [0x00 : 3] Read latency
    $04 constant FLASH_WRHIGHFREQ               \ [0x04 : 2] Flash signal delay
  [then]


  [ifdef] FLASH_KEYR1_DEF
    \
    \ @brief FLASH key register for bank 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_KEYR1                    \ [0x00 : 32] Bank 1 access configuration unlock key
  [then]


  [ifdef] FLASH_OPTKEYR_DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEYR                  \ [0x00 : 32] Unlock key option bytes
  [then]


  [ifdef] FLASH_CR1_DEF
    \
    \ @brief FLASH control register for bank 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LOCK1                    \ [0x00] Bank 1 configuration lock bit
    $01 constant FLASH_PG1                      \ [0x01] Bank 1 program enable bit
    $02 constant FLASH_SER1                     \ [0x02] Bank 1 sector erase request
    $03 constant FLASH_BER1                     \ [0x03] Bank 1 erase request
    $04 constant FLASH_PSIZE1                   \ [0x04 : 2] Bank 1 program size
    $06 constant FLASH_FW1                      \ [0x06] Bank 1 write forcing control bit
    $07 constant FLASH_START1                   \ [0x07] Bank 1 bank or sector erase start control bit
    $08 constant FLASH_SNB1                     \ [0x08 : 3] Bank 1 sector erase selection number
    $0f constant FLASH_CRC_EN                   \ [0x0f] Bank 1 CRC control bit
    $10 constant FLASH_EOPIE1                   \ [0x10] Bank 1 end-of-program interrupt control bit
    $11 constant FLASH_WRPERRIE1                \ [0x11] Bank 1 write protection error interrupt enable bit
    $12 constant FLASH_PGSERRIE1                \ [0x12] Bank 1 programming sequence error interrupt enable bit
    $13 constant FLASH_STRBERRIE1               \ [0x13] Bank 1 strobe error interrupt enable bit
    $15 constant FLASH_INCERRIE1                \ [0x15] Bank 1 inconsistency error interrupt enable bit
    $16 constant FLASH_OPERRIE1                 \ [0x16] Bank 1 write/erase error interrupt enable bit
    $17 constant FLASH_RDPERRIE1                \ [0x17] Bank 1 read protection error interrupt enable bit
    $18 constant FLASH_RDSERRIE1                \ [0x18] Bank 1 secure error interrupt enable bit
    $19 constant FLASH_SNECCERRIE1              \ [0x19] Bank 1 ECC single correction error interrupt enable bit
    $1a constant FLASH_DBECCERRIE1              \ [0x1a] Bank 1 ECC double detection error interrupt enable bit
    $1b constant FLASH_CRCENDIE1                \ [0x1b] Bank 1 end of CRC calculation interrupt enable bit
  [then]


  [ifdef] FLASH_SR1_DEF
    \
    \ @brief FLASH status register for bank 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY1                     \ [0x00] Bank 1 ongoing program flag
    $01 constant FLASH_WBNE1                    \ [0x01] Bank 1 write buffer not empty flag
    $02 constant FLASH_QW1                      \ [0x02] Bank 1 wait queue flag
    $03 constant FLASH_CRC_BUSY1                \ [0x03] Bank 1 CRC busy flag
    $10 constant FLASH_EOP1                     \ [0x10] Bank 1 end-of-program flag
    $11 constant FLASH_WRPERR1                  \ [0x11] Bank 1 write protection error flag
    $12 constant FLASH_PGSERR1                  \ [0x12] Bank 1 programming sequence error flag
    $13 constant FLASH_STRBERR1                 \ [0x13] Bank 1 strobe error flag
    $15 constant FLASH_INCERR1                  \ [0x15] Bank 1 inconsistency error flag
    $16 constant FLASH_OPERR1                   \ [0x16] Bank 1 write/erase error flag
    $17 constant FLASH_RDPERR1                  \ [0x17] Bank 1 read protection error flag
    $18 constant FLASH_RDSERR1                  \ [0x18] Bank 1 secure error flag
    $19 constant FLASH_SNECCERR11               \ [0x19] Bank 1 single correction error flag
    $1a constant FLASH_DBECCERR1                \ [0x1a] Bank 1 ECC double detection error flag
    $1b constant FLASH_CRCEND1                  \ [0x1b] Bank 1 CRC-complete flag
  [then]


  [ifdef] FLASH_CCR1_DEF
    \
    \ @brief FLASH clear control register for bank 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $10 constant FLASH_CLR_EOP1                 \ [0x10] Bank 1 EOP1 flag clear bit
    $11 constant FLASH_CLR_WRPERR1              \ [0x11] Bank 1 WRPERR1 flag clear bit
    $12 constant FLASH_CLR_PGSERR1              \ [0x12] Bank 1 PGSERR1 flag clear bi
    $13 constant FLASH_CLR_STRBERR1             \ [0x13] Bank 1 STRBERR1 flag clear bit
    $15 constant FLASH_CLR_INCERR1              \ [0x15] Bank 1 INCERR1 flag clear bit
    $16 constant FLASH_CLR_OPERR1               \ [0x16] Bank 1 OPERR1 flag clear bit
    $17 constant FLASH_CLR_RDPERR1              \ [0x17] Bank 1 RDPERR1 flag clear bit
    $18 constant FLASH_CLR_RDSERR1              \ [0x18] Bank 1 RDSERR1 flag clear bit
    $19 constant FLASH_CLR_SNECCERR1            \ [0x19] Bank 1 SNECCERR1 flag clear bit
    $1a constant FLASH_CLR_DBECCERR1            \ [0x1a] Bank 1 DBECCERR1 flag clear bit
    $1b constant FLASH_CLR_CRCEND1              \ [0x1b] Bank 1 CRCEND1 flag clear bit
  [then]


  [ifdef] FLASH_OPTCR_DEF
    \
    \ @brief FLASH option control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTLOCK                  \ [0x00] FLASH_OPTCR lock option configuration bit
    $01 constant FLASH_OPTSTART                 \ [0x01] Option byte start change option configuration bit
    $04 constant FLASH_MER                      \ [0x04] Flash mass erase enable bit
    $1e constant FLASH_OPTCHANGEERRIE           \ [0x1e] Option byte change error interrupt enable bit
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping configuration bit
  [then]


  [ifdef] FLASH_OPTSR_CUR_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPT_BUSY                 \ [0x00] Option byte change ongoing flag
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] Brownout level option status bit
    $04 constant FLASH_IWDG1_HW                 \ [0x04] IWDG1 control option status bit
    $06 constant FLASH_nRST_STOP_D1             \ [0x06] D1 DStop entry reset option status bit
    $07 constant FLASH_nRST_STBY_D1             \ [0x07] D1 DStandby entry reset option status bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option status byte
    $11 constant FLASH_FZ_IWDG_STOP             \ [0x11] IWDG Stop mode freeze option status bit
    $12 constant FLASH_FZ_IWDG_SDBY             \ [0x12] IWDG Standby mode freeze option status bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM RAM size option status
    $15 constant FLASH_SECURITY                 \ [0x15] Security enable option status bit
    $1a constant FLASH_RSS1                     \ [0x1a] User option bit 1
    $1c constant FLASH_PERSO_OK                 \ [0x1c] Device personalization status bit
    $1d constant FLASH_IO_HSLV                  \ [0x1d] I/O high-speed at low-voltage status bit (PRODUCT_BELOW_25V)
    $1e constant FLASH_OPTCHANGEERR             \ [0x1e] Option byte change error flag
    $1f constant FLASH_SWAP_BANK_OPT            \ [0x1f] Bank swapping option status bit
  [then]


  [ifdef] FLASH_OPTSR_PRG_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] BOR reset level option configuration bits
    $04 constant FLASH_IWDG1_HW                 \ [0x04] IWDG1 option configuration bit
    $06 constant FLASH_nRST_STOP_D1             \ [0x06] Option byte erase after D1 DStop option configuration bit
    $07 constant FLASH_nRST_STBY_D1             \ [0x07] Option byte erase after D1 DStandby option configuration bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option configuration byte
    $11 constant FLASH_FZ_IWDG_STOP             \ [0x11] IWDG Stop mode freeze option configuration bit
    $12 constant FLASH_FZ_IWDG_SDBY             \ [0x12] IWDG Standby mode freeze option configuration bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM size select option configuration bits
    $15 constant FLASH_SECURITY                 \ [0x15] Security option configuration bit
    $1a constant FLASH_RSS1                     \ [0x1a] User option configuration bit 1
    $1b constant FLASH_RSS2                     \ [0x1b] User option configuration bit 2
    $1d constant FLASH_IO_HSLV                  \ [0x1d] I/O high-speed at low-voltage (PRODUCT_BELOW_25V)
    $1f constant FLASH_SWAP_BANK_OPT            \ [0x1f] Bank swapping option configuration bit
  [then]


  [ifdef] FLASH_OPTCCR_DEF
    \
    \ @brief FLASH option clear control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $1e constant FLASH_CLR_OPTCHANGEERR         \ [0x1e] OPTCHANGEERR reset bit
  [then]


  [ifdef] FLASH_PRAR_CUR1_DEF
    \
    \ @brief FLASH protection address for bank 1
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START1         \ [0x00 : 12] Bank 1 lowest PCROP protected address
    $10 constant FLASH_PROT_AREA_END1           \ [0x10 : 12] Bank 1 highest PCROP protected address
    $1f constant FLASH_DMEP1                    \ [0x1f] Bank 1 PCROP protected erase enable option status bit
  [then]


  [ifdef] FLASH_PRAR_PRG1_DEF
    \
    \ @brief FLASH protection address for bank 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START1         \ [0x00 : 12] Bank 1 lowest PCROP protected address configuration
    $10 constant FLASH_PROT_AREA_END1           \ [0x10 : 12] Bank 1 highest PCROP protected address configuration
    $1f constant FLASH_DMEP1                    \ [0x1f] Bank 1 PCROP protected erase enable option configuration bit
  [then]


  [ifdef] FLASH_PRAR_PRG2_DEF
    \
    \ @brief FLASH protection address for bank 2
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START2         \ [0x00 : 12] Bank 2 lowest PCROP protected address configuration
    $10 constant FLASH_PROT_AREA_END2           \ [0x10 : 12] Bank 2 highest PCROP protected address configuration
    $1f constant FLASH_DMEP2                    \ [0x1f] Bank 2 PCROP protected erase enable option configuration bit
  [then]


  [ifdef] FLASH_SCAR_CUR1_DEF
    \
    \ @brief FLASH secure address for bank 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START1          \ [0x00 : 12] Bank 1 lowest secure protected address
    $10 constant FLASH_SEC_AREA_END1            \ [0x10 : 12] Bank 1 highest secure protected address
    $1f constant FLASH_DMES1                    \ [0x1f] Bank 1 secure protected erase enable option status bit
  [then]


  [ifdef] FLASH_SCAR_PRG1_DEF
    \
    \ @brief FLASH secure address for bank 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START1          \ [0x00 : 12] Bank 1 lowest secure protected address configuration
    $10 constant FLASH_SEC_AREA_END1            \ [0x10 : 12] Bank 1 highest secure protected address configuration
    $1f constant FLASH_DMES1                    \ [0x1f] Bank 1 secure protected erase enable option configuration bit
  [then]


  [ifdef] FLASH_WPSN_CUR1R_DEF
    \
    \ @brief FLASH write sector protection for bank 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSn1                   \ [0x00 : 8] Bank 1 sector write protection option status byte
  [then]


  [ifdef] FLASH_WPSN_PRG1R_DEF
    \
    \ @brief FLASH write sector protection for bank 1
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSn1                   \ [0x00 : 8] Bank 1 sector write protection configuration byte
  [then]


  [ifdef] FLASH_BOOT_CURR_DEF
    \
    \ @brief FLASH register with boot address
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_ADD0                \ [0x00 : 16] Boot address 0
    $10 constant FLASH_BOOT_ADD1                \ [0x10 : 16] Boot address 1
  [then]


  [ifdef] FLASH_BOOT_PRGR_DEF
    \
    \ @brief FLASH register with boot address
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_ADD0                \ [0x00 : 16] Boot address 0
    $10 constant FLASH_BOOT_ADD1                \ [0x10 : 16] Boot address 1
  [then]


  [ifdef] FLASH_CRCCR1_DEF
    \
    \ @brief FLASH CRC control register for bank 1
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_SECT                 \ [0x00 : 3] Bank 1 CRC sector number
    $07 constant FLASH_ALL_BANK                 \ [0x07] Bank 1 CRC select bit
    $08 constant FLASH_CRC_BY_SECT              \ [0x08] Bank 1 CRC sector mode select bit
    $09 constant FLASH_ADD_SECT                 \ [0x09] Bank 1 CRC sector select bit
    $0a constant FLASH_CLEAN_SECT               \ [0x0a] Bank 1 CRC sector list clear bit
    $10 constant FLASH_START_CRC                \ [0x10] Bank 1 CRC start bit
    $11 constant FLASH_CLEAN_CRC                \ [0x11] Bank 1 CRC clear bit
    $14 constant FLASH_CRC_BURST                \ [0x14 : 2] Bank 1 CRC burst size
  [then]


  [ifdef] FLASH_CRCSADD1R_DEF
    \
    \ @brief FLASH CRC start address register for bank 1
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_START_ADDR           \ [0x00 : 32] CRC start address on bank 1
  [then]


  [ifdef] FLASH_CRCEADD1R_DEF
    \
    \ @brief FLASH CRC end address register for bank 1
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_END_ADDR             \ [0x00 : 32] CRC end address on bank 1
  [then]


  [ifdef] FLASH_CRCDATAR_DEF
    \
    \ @brief FLASH CRC data register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_DATA                 \ [0x00 : 32] CRC result
  [then]


  [ifdef] FLASH_ECC_FA1R_DEF
    \
    \ @brief FLASH ECC fail address for bank 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_FAIL_ECC_ADDR1           \ [0x00 : 15] Bank 1 ECC error address
  [then]


  [ifdef] FLASH_ACR__DEF
    \
    \ @brief Access control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 3] Read latency
    $04 constant FLASH_WRHIGHFREQ               \ [0x04 : 2] Flash signal delay
  [then]


  [ifdef] FLASH_KEYR2_DEF
    \
    \ @brief FLASH key register for bank 2
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_KEYR2                    \ [0x00 : 32] Bank 2 access configuration unlock key
  [then]


  [ifdef] FLASH_OPTKEYR__DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEYR                  \ [0x00 : 32] Unlock key option bytes
  [then]


  [ifdef] FLASH_CR2_DEF
    \
    \ @brief FLASH control register for bank 2
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LOCK2                    \ [0x00] Bank 2 configuration lock bit
    $01 constant FLASH_PG2                      \ [0x01] Bank 2 program enable bit
    $02 constant FLASH_SER2                     \ [0x02] Bank 2 sector erase request
    $03 constant FLASH_BER2                     \ [0x03] Bank 2 erase request
    $04 constant FLASH_PSIZE2                   \ [0x04 : 2] Bank 2 program size
    $06 constant FLASH_FW2                      \ [0x06] Bank 2 write forcing control bit
    $07 constant FLASH_START2                   \ [0x07] Bank 2 bank or sector erase start control bit
    $08 constant FLASH_SNB2                     \ [0x08 : 3] Bank 2 sector erase selection number
    $0f constant FLASH_CRC_EN                   \ [0x0f] Bank 2 CRC control bit
    $10 constant FLASH_EOPIE2                   \ [0x10] Bank 2 end-of-program interrupt control bit
    $11 constant FLASH_WRPERRIE2                \ [0x11] Bank 2 write protection error interrupt enable bit
    $12 constant FLASH_PGSERRIE2                \ [0x12] Bank 2 programming sequence error interrupt enable bit
    $13 constant FLASH_STRBERRIE2               \ [0x13] Bank 2 strobe error interrupt enable bit
    $15 constant FLASH_INCERRIE2                \ [0x15] Bank 2 inconsistency error interrupt enable bit
    $16 constant FLASH_OPERRIE2                 \ [0x16] Bank 2 write/erase error interrupt enable bit
    $17 constant FLASH_RDPERRIE2                \ [0x17] Bank 2 read protection error interrupt enable bit
    $18 constant FLASH_RDSERRIE2                \ [0x18] Bank 2 secure error interrupt enable bit
    $19 constant FLASH_SNECCERRIE2              \ [0x19] Bank 2 ECC single correction error interrupt enable bit
    $1a constant FLASH_DBECCERRIE2              \ [0x1a] Bank 2 ECC double detection error interrupt enable bit
    $1b constant FLASH_CRCENDIE2                \ [0x1b] Bank 2 end of CRC calculation interrupt enable bit
  [then]


  [ifdef] FLASH_SR2_DEF
    \
    \ @brief FLASH status register for bank 2
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY2                     \ [0x00] Bank 2 ongoing program flag
    $01 constant FLASH_WBNE2                    \ [0x01] Bank 2 write buffer not empty flag
    $02 constant FLASH_QW2                      \ [0x02] Bank 2 wait queue flag
    $03 constant FLASH_CRC_BUSY2                \ [0x03] Bank 2 CRC busy flag
    $10 constant FLASH_EOP2                     \ [0x10] Bank 2 end-of-program flag
    $11 constant FLASH_WRPERR2                  \ [0x11] Bank 2 write protection error flag
    $12 constant FLASH_PGSERR2                  \ [0x12] Bank 2 programming sequence error flag
    $13 constant FLASH_STRBERR2                 \ [0x13] Bank 2 strobe error flag
    $15 constant FLASH_INCERR2                  \ [0x15] Bank 2 inconsistency error flag
    $16 constant FLASH_OPERR2                   \ [0x16] Bank 2 write/erase error flag
    $17 constant FLASH_RDPERR2                  \ [0x17] Bank 2 read protection error flag
    $18 constant FLASH_RDSERR2                  \ [0x18] Bank 2 secure error flag
    $19 constant FLASH_SNECCERR2                \ [0x19] Bank 2 single correction error flag
    $1a constant FLASH_DBECCERR2                \ [0x1a] Bank 2 ECC double detection error flag
    $1b constant FLASH_CRCEND2                  \ [0x1b] Bank 2 CRC-complete flag
  [then]


  [ifdef] FLASH_CCR2_DEF
    \
    \ @brief FLASH clear control register for bank 2
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $10 constant FLASH_CLR_EOP2                 \ [0x10] Bank 1 EOP1 flag clear bit
    $11 constant FLASH_CLR_WRPERR2              \ [0x11] Bank 2 WRPERR1 flag clear bit
    $12 constant FLASH_CLR_PGSERR2              \ [0x12] Bank 2 PGSERR1 flag clear bi
    $13 constant FLASH_CLR_STRBERR2             \ [0x13] Bank 2 STRBERR1 flag clear bit
    $15 constant FLASH_CLR_INCERR2              \ [0x15] Bank 2 INCERR1 flag clear bit
    $16 constant FLASH_CLR_OPERR2               \ [0x16] Bank 2 OPERR1 flag clear bit
    $17 constant FLASH_CLR_RDPERR2              \ [0x17] Bank 2 RDPERR1 flag clear bit
    $18 constant FLASH_CLR_RDSERR1              \ [0x18] Bank 1 RDSERR1 flag clear bit
    $19 constant FLASH_CLR_SNECCERR2            \ [0x19] Bank 2 SNECCERR1 flag clear bit
    $1a constant FLASH_CLR_DBECCERR1            \ [0x1a] Bank 1 DBECCERR1 flag clear bit
    $1b constant FLASH_CLR_CRCEND2              \ [0x1b] Bank 2 CRCEND1 flag clear bit
  [then]


  [ifdef] FLASH_OPTCR__DEF
    \
    \ @brief FLASH option control register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTLOCK                  \ [0x00] FLASH_OPTCR lock option configuration bit
    $01 constant FLASH_OPTSTART                 \ [0x01] Option byte start change option configuration bit
    $04 constant FLASH_MER                      \ [0x04] Flash mass erase enable bit
    $1e constant FLASH_OPTCHANGEERRIE           \ [0x1e] Option byte change error interrupt enable bit
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping configuration bit
  [then]


  [ifdef] FLASH_OPTSR_CUR__DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPT_BUSY                 \ [0x00] Option byte change ongoing flag
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] Brownout level option status bit
    $04 constant FLASH_IWDG1_HW                 \ [0x04] IWDG1 control option status bit
    $06 constant FLASH_nRST_STOP_D1             \ [0x06] D1 DStop entry reset option status bit
    $07 constant FLASH_nRST_STBY_D1             \ [0x07] D1 DStandby entry reset option status bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option status byte
    $11 constant FLASH_FZ_IWDG_STOP             \ [0x11] IWDG Stop mode freeze option status bit
    $12 constant FLASH_FZ_IWDG_SDBY             \ [0x12] IWDG Standby mode freeze option status bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM RAM size option status
    $15 constant FLASH_SECURITY                 \ [0x15] Security enable option status bit
    $1a constant FLASH_RSS1                     \ [0x1a] User option bit 1
    $1c constant FLASH_PERSO_OK                 \ [0x1c] Device personalization status bit
    $1d constant FLASH_IO_HSLV                  \ [0x1d] I/O high-speed at low-voltage status bit (PRODUCT_BELOW_25V)
    $1e constant FLASH_OPTCHANGEERR             \ [0x1e] Option byte change error flag
    $1f constant FLASH_SWAP_BANK_OPT            \ [0x1f] Bank swapping option status bit
  [then]


  [ifdef] FLASH_OPTSR_PRG__DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] BOR reset level option configuration bits
    $04 constant FLASH_IWDG1_HW                 \ [0x04] IWDG1 option configuration bit
    $06 constant FLASH_nRST_STOP_D1             \ [0x06] Option byte erase after D1 DStop option configuration bit
    $07 constant FLASH_nRST_STBY_D1             \ [0x07] Option byte erase after D1 DStandby option configuration bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option configuration byte
    $11 constant FLASH_FZ_IWDG_STOP             \ [0x11] IWDG Stop mode freeze option configuration bit
    $12 constant FLASH_FZ_IWDG_SDBY             \ [0x12] IWDG Standby mode freeze option configuration bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM size select option configuration bits
    $15 constant FLASH_SECURITY                 \ [0x15] Security option configuration bit
    $1a constant FLASH_RSS1                     \ [0x1a] User option configuration bit 1
    $1b constant FLASH_RSS2                     \ [0x1b] User option configuration bit 2
    $1d constant FLASH_IO_HSLV                  \ [0x1d] I/O high-speed at low-voltage (PRODUCT_BELOW_25V)
    $1f constant FLASH_SWAP_BANK_OPT            \ [0x1f] Bank swapping option configuration bit
  [then]


  [ifdef] FLASH_OPTCCR__DEF
    \
    \ @brief FLASH option clear control register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $1e constant FLASH_CLR_OPTCHANGEERR         \ [0x1e] OPTCHANGEERR reset bit
  [then]


  [ifdef] FLASH_PRAR_CUR2_DEF
    \
    \ @brief FLASH protection address for bank 1
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START2         \ [0x00 : 12] Bank 2 lowest PCROP protected address
    $10 constant FLASH_PROT_AREA_END2           \ [0x10 : 12] Bank 2 highest PCROP protected address
    $1f constant FLASH_DMEP2                    \ [0x1f] Bank 2 PCROP protected erase enable option status bit
  [then]


  [ifdef] FLASH_SCAR_CUR2_DEF
    \
    \ @brief FLASH secure address for bank 2
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START2          \ [0x00 : 12] Bank 2 lowest secure protected address
    $10 constant FLASH_SEC_AREA_END2            \ [0x10 : 12] Bank 2 highest secure protected address
    $1f constant FLASH_DMES2                    \ [0x1f] Bank 2 secure protected erase enable option status bit
  [then]


  [ifdef] FLASH_SCAR_PRG2_DEF
    \
    \ @brief FLASH secure address for bank 2
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START2          \ [0x00 : 12] Bank 2 lowest secure protected address configuration
    $10 constant FLASH_SEC_AREA_END2            \ [0x10 : 12] Bank 2 highest secure protected address configuration
    $1f constant FLASH_DMES2                    \ [0x1f] Bank 2 secure protected erase enable option configuration bit
  [then]


  [ifdef] FLASH_WPSN_CUR2R_DEF
    \
    \ @brief FLASH write sector protection for bank 2
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSn2                   \ [0x00 : 8] Bank 2 sector write protection option status byte
  [then]


  [ifdef] FLASH_WPSN_PRG2R_DEF
    \
    \ @brief FLASH write sector protection for bank 2
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSn2                   \ [0x00 : 8] Bank 2 sector write protection configuration byte
  [then]


  [ifdef] FLASH_CRCCR2_DEF
    \
    \ @brief FLASH CRC control register for bank 1
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_SECT                 \ [0x00 : 3] Bank 2 CRC sector number
    $07 constant FLASH_ALL_BANK                 \ [0x07] Bank 2 CRC select bit
    $08 constant FLASH_CRC_BY_SECT              \ [0x08] Bank 2 CRC sector mode select bit
    $09 constant FLASH_ADD_SECT                 \ [0x09] Bank 2 CRC sector select bit
    $0a constant FLASH_CLEAN_SECT               \ [0x0a] Bank 2 CRC sector list clear bit
    $10 constant FLASH_START_CRC                \ [0x10] Bank 2 CRC start bit
    $11 constant FLASH_CLEAN_CRC                \ [0x11] Bank 2 CRC clear bit
    $14 constant FLASH_CRC_BURST                \ [0x14 : 2] Bank 2 CRC burst size
  [then]


  [ifdef] FLASH_CRCSADD2R_DEF
    \
    \ @brief FLASH CRC start address register for bank 2
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_START_ADDR           \ [0x00 : 32] CRC start address on bank 2
  [then]


  [ifdef] FLASH_CRCEADD2R_DEF
    \
    \ @brief FLASH CRC end address register for bank 2
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_END_ADDR             \ [0x00 : 32] CRC end address on bank 2
  [then]


  [ifdef] FLASH_ECC_FA2R_DEF
    \
    \ @brief FLASH ECC fail address for bank 2
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_FAIL_ECC_ADDR2           \ [0x00 : 15] Bank 2 ECC error address
  [then]

  \
  \ @brief Flash
  \
  $00 constant FLASH_ACR                \ Access control register
  $04 constant FLASH_KEYR1              \ FLASH key register for bank 1
  $08 constant FLASH_OPTKEYR            \ FLASH option key register
  $0C constant FLASH_CR1                \ FLASH control register for bank 1
  $10 constant FLASH_SR1                \ FLASH status register for bank 1
  $14 constant FLASH_CCR1               \ FLASH clear control register for bank 1
  $18 constant FLASH_OPTCR              \ FLASH option control register
  $1C constant FLASH_OPTSR_CUR          \ FLASH option status register
  $20 constant FLASH_OPTSR_PRG          \ FLASH option status register
  $24 constant FLASH_OPTCCR             \ FLASH option clear control register
  $28 constant FLASH_PRAR_CUR1          \ FLASH protection address for bank 1
  $2C constant FLASH_PRAR_PRG1          \ FLASH protection address for bank 1
  $2C constant FLASH_PRAR_PRG2          \ FLASH protection address for bank 2
  $30 constant FLASH_SCAR_CUR1          \ FLASH secure address for bank 1
  $34 constant FLASH_SCAR_PRG1          \ FLASH secure address for bank 1
  $38 constant FLASH_WPSN_CUR1R         \ FLASH write sector protection for bank 1
  $3C constant FLASH_WPSN_PRG1R         \ FLASH write sector protection for bank 1
  $40 constant FLASH_BOOT_CURR          \ FLASH register with boot address
  $44 constant FLASH_BOOT_PRGR          \ FLASH register with boot address
  $50 constant FLASH_CRCCR1             \ FLASH CRC control register for bank 1
  $54 constant FLASH_CRCSADD1R          \ FLASH CRC start address register for bank 1
  $58 constant FLASH_CRCEADD1R          \ FLASH CRC end address register for bank 1
  $5C constant FLASH_CRCDATAR           \ FLASH CRC data register
  $60 constant FLASH_ECC_FA1R           \ FLASH ECC fail address for bank 1
  $100 constant FLASH_ACR_              \ Access control register
  $104 constant FLASH_KEYR2             \ FLASH key register for bank 2
  $108 constant FLASH_OPTKEYR_          \ FLASH option key register
  $10C constant FLASH_CR2               \ FLASH control register for bank 2
  $110 constant FLASH_SR2               \ FLASH status register for bank 2
  $114 constant FLASH_CCR2              \ FLASH clear control register for bank 2
  $118 constant FLASH_OPTCR_            \ FLASH option control register
  $11C constant FLASH_OPTSR_CUR_        \ FLASH option status register
  $120 constant FLASH_OPTSR_PRG_        \ FLASH option status register
  $124 constant FLASH_OPTCCR_           \ FLASH option clear control register
  $128 constant FLASH_PRAR_CUR2         \ FLASH protection address for bank 1
  $130 constant FLASH_SCAR_CUR2         \ FLASH secure address for bank 2
  $134 constant FLASH_SCAR_PRG2         \ FLASH secure address for bank 2
  $138 constant FLASH_WPSN_CUR2R        \ FLASH write sector protection for bank 2
  $13C constant FLASH_WPSN_PRG2R        \ FLASH write sector protection for bank 2
  $150 constant FLASH_CRCCR2            \ FLASH CRC control register for bank 1
  $154 constant FLASH_CRCSADD2R         \ FLASH CRC start address register for bank 2
  $158 constant FLASH_CRCEADD2R         \ FLASH CRC end address register for bank 2
  $160 constant FLASH_ECC_FA2R          \ FLASH ECC fail address for bank 2

: FLASH_DEF ; [then]
