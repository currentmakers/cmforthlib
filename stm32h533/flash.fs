\
\ @file flash.fs
\ @brief Mustang_FLASH register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FLASH_DEF

  [ifdef] FLASH_FLASH_ACR_DEF
    \
    \ @brief FLASH access control register
    \ Address offset: 0x00
    \ Reset value: 0x00000013
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 4] Read latency
    $04 constant FLASH_WRHIGHFREQ               \ [0x04 : 2] Flash signal delay
    $08 constant FLASH_PRFTEN                   \ [0x08] Prefetch enable.
  [then]


  [ifdef] FLASH_FLASH_NSKEYR_DEF
    \
    \ @brief FLASH non-secure key register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSKEY                    \ [0x00 : 32] Non-volatile memory non-secure configuration access unlock key
  [then]


  [ifdef] FLASH_FLASH_SECKEYR_DEF
    \
    \ @brief FLASH secure key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECKEY                   \ [0x00 : 32] Non-volatile memory secure configuration access unlock key
  [then]


  [ifdef] FLASH_FLASH_OPTKEYR_DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEY                   \ [0x00 : 32] FLASH option bytes control access unlock key
  [then]


  [ifdef] FLASH_FLASH_NSOBKKEYR_DEF
    \
    \ @brief FLASH non-secure OBK key register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSOBKKEY                 \ [0x00 : 32] FLASH non-secure option bytes keys control access unlock key
  [then]


  [ifdef] FLASH_FLASH_SECOBKKEYR_DEF
    \
    \ @brief FLASH secure OBK key register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECOBKKEY                \ [0x00 : 32] FLASH secure option bytes keys control access unlock key
  [then]


  [ifdef] FLASH_FLASH_OPSR_DEF
    \
    \ @brief FLASH operation status register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_OP                  \ [0x00 : 20] Interrupted operation address
    $15 constant FLASH_DATA_OP                  \ [0x15] Flash high-cycle data area operation interrupted
    $16 constant FLASH_BK_OP                    \ [0x16] Interrupted operation bank
    $17 constant FLASH_SYSF_OP                  \ [0x17] Operation in system flash memory interrupted
    $18 constant FLASH_OTP_OP                   \ [0x18] OTP operation interrupted
    $1d constant FLASH_CODE_OP                  \ [0x1d : 3] Flash memory operation code
  [then]


  [ifdef] FLASH_FLASH_OPTCR_DEF
    \
    \ @brief FLASH option control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_OPTLOCK                  \ [0x00] FLASH_OPTCR lock option configuration bit
    $01 constant FLASH_OPTSTRT                  \ [0x01] Option byte start change option configuration bit
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping option configuration bit
  [then]


  [ifdef] FLASH_FLASH_NSSR_DEF
    \
    \ @brief FLASH non-secure status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY                      \ [0x00] busy flag
    $01 constant FLASH_WBNE                     \ [0x01] write buffer not empty flag
    $03 constant FLASH_DBNE                     \ [0x03] data buffer not empty flag
    $10 constant FLASH_EOP                      \ [0x10] end of operation flag
    $11 constant FLASH_WRPERR                   \ [0x11] write protection error flag
    $12 constant FLASH_PGSERR                   \ [0x12] programming sequence error flag
    $13 constant FLASH_STRBERR                  \ [0x13] strobe error flag
    $14 constant FLASH_INCERR                   \ [0x14] inconsistency error flag
    $15 constant FLASH_OBKERR                   \ [0x15] OBK general error flag
    $16 constant FLASH_OBKWERR                  \ [0x16] OBK write error flag
    $17 constant FLASH_OPTCHANGEERR             \ [0x17] Option byte change error flag
  [then]


  [ifdef] FLASH_FLASH_SECSR_DEF
    \
    \ @brief FLASH secure status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY                      \ [0x00] busy flag
    $01 constant FLASH_WBNE                     \ [0x01] write buffer not empty flag
    $03 constant FLASH_DBNE                     \ [0x03] data buffer not empty flag
    $10 constant FLASH_EOP                      \ [0x10] end of operation flag
    $11 constant FLASH_WRPERR                   \ [0x11] write protection error flag
    $12 constant FLASH_PGSERR                   \ [0x12] programming sequence error flag
    $13 constant FLASH_STRBERR                  \ [0x13] strobe error flag
    $14 constant FLASH_INCERR                   \ [0x14] inconsistency error flag
    $15 constant FLASH_OBKERR                   \ [0x15] OBK general error flag
    $16 constant FLASH_OBKWERR                  \ [0x16] OBK write error flag
  [then]


  [ifdef] FLASH_FLASH_NSCR_DEF
    \
    \ @brief FLASH non-secure control register
    \ Address offset: 0x28
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_LOCK                     \ [0x00] configuration lock bit
    $01 constant FLASH_PG                       \ [0x01] programming control bit
    $02 constant FLASH_SER                      \ [0x02] sector erase request
    $03 constant FLASH_BER                      \ [0x03] erase request
    $04 constant FLASH_FW                       \ [0x04] write forcing control bit
    $05 constant FLASH_STRT                     \ [0x05] erase start control bit
    $06 constant FLASH_SNB                      \ [0x06 : 7] sector erase selection number
    $0f constant FLASH_MER                      \ [0x0f] mass erase request
    $10 constant FLASH_EOPIE                    \ [0x10] end of operation interrupt control bit
    $11 constant FLASH_WRPERRIE                 \ [0x11] write protection error interrupt enable bit
    $12 constant FLASH_PGSERRIE                 \ [0x12] programming sequence error interrupt enable bit
    $13 constant FLASH_STRBERRIE                \ [0x13] strobe error interrupt enable bit
    $14 constant FLASH_INCERRIE                 \ [0x14] inconsistency error interrupt enable bit
    $15 constant FLASH_OBKERRIE                 \ [0x15] OBK general error interrupt enable bit
    $16 constant FLASH_OBKWERRIE                \ [0x16] OBK write error interrupt enable bit
    $17 constant FLASH_OPTCHANGEERRIE           \ [0x17] Option byte change error interrupt enable bit
    $1f constant FLASH_BKSEL                    \ [0x1f] Bank selector bit
  [then]


  [ifdef] FLASH_FLASH_SECCR_DEF
    \
    \ @brief FLASH secure control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_LOCK                     \ [0x00] configuration lock bit
    $01 constant FLASH_PG                       \ [0x01] programming control bit
    $02 constant FLASH_SER                      \ [0x02] sector erase request
    $03 constant FLASH_BER                      \ [0x03] erase request
    $04 constant FLASH_FW                       \ [0x04] write forcing control bit
    $05 constant FLASH_STRT                     \ [0x05] erase start control bit
    $06 constant FLASH_SNB                      \ [0x06 : 7] sector erase selection number
    $0f constant FLASH_MER                      \ [0x0f] mass erase request
    $10 constant FLASH_EOPIE                    \ [0x10] end of operation interrupt control bit
    $11 constant FLASH_WRPERRIE                 \ [0x11] write protection error interrupt enable bit
    $12 constant FLASH_PGSERRIE                 \ [0x12] programming sequence error interrupt enable bit
    $13 constant FLASH_STRBERRIE                \ [0x13] strobe error interrupt enable bit
    $14 constant FLASH_INCERRIE                 \ [0x14] inconsistency error interrupt enable bit
    $15 constant FLASH_OBKERRIE                 \ [0x15] OBK general error interrupt enable bit
    $16 constant FLASH_OBKWERRIE                \ [0x16] OBK write error interrupt enable bit
    $1d constant FLASH_INV                      \ [0x1d] Flash memory security state invert.
    $1f constant FLASH_BKSEL                    \ [0x1f] Bank selector bit
  [then]


  [ifdef] FLASH_FLASH_NSCCR_DEF
    \
    \ @brief FLASH non-secure clear control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $10 constant FLASH_CLR_EOP                  \ [0x10] EOP flag clear bit
    $11 constant FLASH_CLR_WRPERR               \ [0x11] WRPERR flag clear bit
    $12 constant FLASH_CLR_PGSERR               \ [0x12] PGSERR flag clear bit
    $13 constant FLASH_CLR_STRBERR              \ [0x13] STRBERR flag clear bit
    $14 constant FLASH_CLR_INCERR               \ [0x14] INCERR flag clear bit
    $15 constant FLASH_CLR_OBKERR               \ [0x15] OBKERR flag clear bit.
    $16 constant FLASH_CLR_OBKWERR              \ [0x16] OBKWERR flag clear bit.
    $17 constant FLASH_CLR_OPTCHANGEERR         \ [0x17] Clear the flag corresponding flag in FLASH_NSSR by writing this bit.
  [then]


  [ifdef] FLASH_FLASH_SECCCR_DEF
    \
    \ @brief FLASH secure clear control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $10 constant FLASH_CLR_EOP                  \ [0x10] EOP flag clear bit
    $11 constant FLASH_CLR_WRPERR               \ [0x11] WRPERR flag clear bit
    $12 constant FLASH_CLR_PGSERR               \ [0x12] PGSERR flag clear bit
    $13 constant FLASH_CLR_STRBERR              \ [0x13] STRBERR flag clear bit
    $14 constant FLASH_CLR_INCERR               \ [0x14] INCERR flag clear bit
    $15 constant FLASH_CLR_OBKERR               \ [0x15] OBKWERR flag clear bit
    $16 constant FLASH_CLR_OBKWERR              \ [0x16] OBKWERR flag clear bit
  [then]


  [ifdef] FLASH_FLASH_PRIVCFGR_DEF
    \
    \ @brief FLASH privilege configuration register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SPRIV                    \ [0x00] privilege attribute for secure registers
    $01 constant FLASH_NSPRIV                   \ [0x01] privilege attribute for non secure registers
  [then]


  [ifdef] FLASH_FLASH_NSOBKCFGR_DEF
    \
    \ @brief FLASH non-secure OBK configuration register
    \ Address offset: 0x40
    \ Reset value: 0x01FF0000
    \
    $00 constant FLASH_LOCK                     \ [0x00] OBKCFGR lock option configuration bit
    $01 constant FLASH_SWAP_SECT_REQ            \ [0x01] OBK swap sector request bit
    $02 constant FLASH_ALT_SECT                 \ [0x02] alternate sector bit
    $03 constant FLASH_ALT_SECT_ERASE           \ [0x03] alternate sector erase bit
    $10 constant FLASH_SWAP_OFFSET              \ [0x10 : 9] Key index (offset /16 bits) pointing for next swap.
  [then]


  [ifdef] FLASH_FLASH_SECOBKCFGR_DEF
    \
    \ @brief FLASH secure OBK configuration register
    \ Address offset: 0x44
    \ Reset value: 0x01FF0000
    \
    $00 constant FLASH_LOCK                     \ [0x00] OBKCFGR lock option configuration bit
    $01 constant FLASH_SWAP_SECT_REQ            \ [0x01] OBK swap sector request bit
    $02 constant FLASH_ALT_SECT                 \ [0x02] alternate sector bit
    $03 constant FLASH_ALT_SECT_ERASE           \ [0x03] alternate sector erase bit
    $10 constant FLASH_SWAP_OFFSET              \ [0x10 : 9] key index (offset /16 bits) pointing for next swap.
  [then]


  [ifdef] FLASH_FLASH_HDPEXTR_DEF
    \
    \ @brief FLASH HDP extension register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP1_EXT                 \ [0x00 : 7] HDP area extension in 8 Kbytes sectors in Bank1.
    $10 constant FLASH_HDP2_EXT                 \ [0x10 : 7] HDP area extension in 8 Kbytes sectors in Bank2.
  [then]


  [ifdef] FLASH_FLASH_OPTSR_CUR_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOR_LEV                  \ [0x00 : 2] Brownout level option status bit
    $02 constant FLASH_BORH_EN                  \ [0x02] Brownout high enable
    $03 constant FLASH_IWDG_SW                  \ [0x03] IWDG control mode option status bit
    $04 constant FLASH_WWDG_SW                  \ [0x04] WWDG control mode option status bit
    $06 constant FLASH_NRST_STOP                \ [0x06] Core domain Stop entry reset option status bit
    $07 constant FLASH_NRST_STDBY               \ [0x07] Core domain Standby entry reset option status bit
    $08 constant FLASH_PRODUCT_STATE            \ [0x08 : 8] Life state code (based on Hamming 8,4).
    $10 constant FLASH_IO_VDD_HSLV              \ [0x10] High-speed IO at low Vless thansub>DDless than/sub> voltage configuration bit.
    $11 constant FLASH_IO_VDDIO2_HSLV           \ [0x11] High-speed IO at low Vless thansub>DDIO2less than/sub> voltage configuration bit.
    $14 constant FLASH_IWDG_STOP                \ [0x14] IWDG Stop mode freeze option status bit
    $15 constant FLASH_IWDG_STDBY               \ [0x15] IWDG Standby mode freeze option status bit
    $16 constant FLASH_BOOT_UBE                 \ [0x16 : 8] Available only on cryptography enabled devices.
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping option status bit
  [then]


  [ifdef] FLASH_FLASH_OPTSR_PRG_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOR_LEV                  \ [0x00 : 2] Brownout level option configuration bit
    $02 constant FLASH_BORH_EN                  \ [0x02] Brownout high enable configuration bit
    $03 constant FLASH_IWDG_SW                  \ [0x03] IWDG control mode option configuration bit
    $04 constant FLASH_WWDG_SW                  \ [0x04] WWDG control mode option configuration bit
    $06 constant FLASH_NRST_STOP                \ [0x06] Core domain Stop entry reset option configuration bit
    $07 constant FLASH_NRST_STDBY               \ [0x07] Core domain Standby entry reset option configuration bit
    $08 constant FLASH_PRODUCT_STATE            \ [0x08 : 8] Life state code (based on Hamming 8,4).
    $10 constant FLASH_IO_VDD_HSLV              \ [0x10] High-speed IO at low VDD voltage configuration bit.
    $11 constant FLASH_IO_VDDIO2_HSLV           \ [0x11] High-speed IO at low Vless thansub>DDIO2less than/sub> voltage configuration bit.
    $14 constant FLASH_IWDG_STOP                \ [0x14] IWDG Stop mode freeze option status bit
    $15 constant FLASH_IWDG_STDBY               \ [0x15] IWDG Standby mode freeze option status bit
    $16 constant FLASH_BOOT_UBE                 \ [0x16 : 8] Available only on cryptography enabled devices.
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping option configuration bit
  [then]


  [ifdef] FLASH_FLASH_NSEPOCHR_CUR_DEF
    \
    \ @brief FLASH non-secure EPOCH register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NS_EPOCH                 \ [0x00 : 24] Non-volatile non-secure EPOCH counter
  [then]


  [ifdef] FLASH_FLASH_SECEPOCHR_CUR_DEF
    \
    \ @brief FLASH secure EPOCH register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_EPOCH                \ [0x00 : 24] Non-volatile secure EPOCH counter
  [then]


  [ifdef] FLASH_FLASH_OPTSR2_CUR_DEF
    \
    \ @brief FLASH option status register 2
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_SRAM13_RST               \ [0x02] SRAM1 and SRAM3 erase upon system reset
    $03 constant FLASH_SRAM2_RST                \ [0x03] SRAM2 erase when system reset
    $04 constant FLASH_BKPRAM_ECC               \ [0x04] Backup RAM ECC detection and correction disable
    $05 constant FLASH_SRAM3_ECC                \ [0x05] SRAM3 ECC detection and correction disable
    $06 constant FLASH_SRAM2_ECC                \ [0x06] SRAM2 ECC detection and correction disable
    $08 constant FLASH_USBPD_DIS                \ [0x08] USB power delivery configuration option bit
    $18 constant FLASH_TZEN                     \ [0x18 : 8] TrustZone enable configuration bits
  [then]


  [ifdef] FLASH_FLASH_OPTSR2_PRG_DEF
    \
    \ @brief FLASH option status register 2
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_SRAM1_3_RST              \ [0x02] SRAM1 and SRAM3 erase upon system reset
    $03 constant FLASH_SRAM2_RST                \ [0x03] SRAM2 erase when system reset
    $04 constant FLASH_BKPRAM_ECC               \ [0x04] Backup RAM ECC detection and correction disable
    $05 constant FLASH_SRAM3_ECC                \ [0x05] SRAM3 ECC detection and correction disable
    $06 constant FLASH_SRAM2_ECC                \ [0x06] SRAM2 ECC detection and correction disable
    $08 constant FLASH_USBPD_DIS                \ [0x08] USB power delivery configuration option bit
    $18 constant FLASH_TZEN                     \ [0x18 : 8] TrustZone enable configuration bits
  [then]


  [ifdef] FLASH_FLASH_NSBOOTR_CUR_DEF
    \
    \ @brief FLASH non-secure boot register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSBOOT_LOCK              \ [0x00 : 8] Field locking the values of SWAP_BANK, and NSBOOTADD settings.
    $08 constant FLASH_NSBOOTADD                \ [0x08 : 24] Non secure unique boot entry address
  [then]


  [ifdef] FLASH_FLASH_NSBOOTR_PRG_DEF
    \
    \ @brief FLASH non-secure boot register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSBOOT_LOCK              \ [0x00 : 8] Field locking the values of SWAP_ BANK, and NSBOOTADD settings.
    $08 constant FLASH_NSBOOTADD                \ [0x08 : 24] Non secure unique boot entry address
  [then]


  [ifdef] FLASH_FLASH_SECBOOTR_CUR_DEF
    \
    \ @brief FLASH secure boot register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBOOT_LOCK             \ [0x00 : 8] Field locking the values of UBE, SWAP_BANK, and SECBOOTADD settings.
    $08 constant FLASH_SECBOOTADD               \ [0x08 : 24] Unique boot entry secure address
  [then]


  [ifdef] FLASH_FLASH_BOOTR_PRG_DEF
    \
    \ @brief FLASH secure boot register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBOOT_LOCK             \ [0x00 : 8] Field locking the values of UBE, SWAP_ BANK, and SECBOOTADD setting.
    $08 constant FLASH_SECBOOTADD               \ [0x08 : 24] Secure unique boot entry address.
  [then]


  [ifdef] FLASH_FLASH_OTPBLR_CUR_DEF
    \
    \ @brief FLASH non-secure OTP block lock
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LOCKBL                   \ [0x00 : 32] OTP block lock
  [then]


  [ifdef] FLASH_FLASH_OTPBLR_PRG_DEF
    \
    \ @brief FLASH non-secure OTP block lock
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LOCKBL                   \ [0x00 : 32] OTP block lock
  [then]


  [ifdef] FLASH_FLASH_SECBB1R1_DEF
    \
    \ @brief FLASH secure block based register for Bank1
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] Secure/non-secure 8 Kbytes flash Bank1 sector attributes
  [then]


  [ifdef] FLASH_FLASH_SECBB1R2_DEF
    \
    \ @brief FLASH secure block based register for Bank1
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] Secure/non-secure 8 Kbytes flash Bank1 sector attributes
  [then]


  [ifdef] FLASH_FLASH_SECBB1R3_DEF
    \
    \ @brief FLASH secure block based register for Bank1
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] Secure/non-secure 8 Kbytes flash Bank1 sector attributes
  [then]


  [ifdef] FLASH_FLASH_SECBB1R4_DEF
    \
    \ @brief FLASH secure block based register for Bank1
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] Secure/non-secure 8 Kbytes flash Bank1 sector attributes
  [then]


  [ifdef] FLASH_FLASH_PRIVBB1R1_DEF
    \
    \ @brief FLASH privilege block based register for Bank1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB1                  \ [0x00 : 32] Privileged/unprivileged 8-Kbyte flash Bank1 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB1R2_DEF
    \
    \ @brief FLASH privilege block based register for Bank1
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB1                  \ [0x00 : 32] Privileged/unprivileged 8-Kbyte flash Bank1 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB1R3_DEF
    \
    \ @brief FLASH privilege block based register for Bank1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB1                  \ [0x00 : 32] Privileged/unprivileged 8-Kbyte flash Bank1 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB1R4_DEF
    \
    \ @brief FLASH privilege block based register for Bank1
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB1                  \ [0x00 : 32] Privileged/unprivileged 8-Kbyte flash Bank1 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECWM1R_CUR_DEF
    \
    \ @brief FLASH security watermark for Bank1
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECWM1_STRT              \ [0x00 : 7] Bank1 security WM area 1 start sector
    $10 constant FLASH_SECWM1_END               \ [0x10 : 7] Bank1 security WM area 1 end sector
  [then]


  [ifdef] FLASH_FLASH_SECWM1R_PRG_DEF
    \
    \ @brief FLASH security watermark for Bank1
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECWM1_STRT              \ [0x00 : 7] Bank1 security WM area 1 start sector
    $10 constant FLASH_SECWM1_END               \ [0x10 : 7] Bank1 security WM area 1 end sector
  [then]


  [ifdef] FLASH_FLASH_WRP1R_CUR_DEF
    \
    \ @brief FLASH write sector group protection for Bank1
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSG1                   \ [0x00 : 32] Bank1 sector group protection option status byte
  [then]


  [ifdef] FLASH_FLASH_WRP1R_PRG_DEF
    \
    \ @brief FLASH write sector group protection for Bank1
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSG1                   \ [0x00 : 32] Bank1 sector group protection option status byte
  [then]


  [ifdef] FLASH_FLASH_EDATA1R_CUR_DEF
    \
    \ @brief FLASH data sector configuration Bank1
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EDATA1_STRT              \ [0x00 : 3] EDATA1_STRT contains the start sectors of the flash high-cycle data area in Bank1 There is no hardware effect to those bits.
    $0f constant FLASH_EDATA1_EN                \ [0x0f] Bank1 flash high-cycle data enable
  [then]


  [ifdef] FLASH_FLASH_EDATA1R_PRG_DEF
    \
    \ @brief FLASH data sector configuration Bank1
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EDATA1_STRT              \ [0x00 : 3] EDATA1_STRT contains the start sectors of the flash high-cycle data area in Bank1 There is no hardware effect to those bits.
    $0f constant FLASH_EDATA1_EN                \ [0x0f] Bank1 flash high-cycle data enable
  [then]


  [ifdef] FLASH_FLASH_HDP1R_CUR_DEF
    \
    \ @brief FLASH HDP Bank1 configuration
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP1_STRT                \ [0x00 : 7] HDPL barrier start set in number of 8-Kbyte sectors
    $10 constant FLASH_HDP1_END                 \ [0x10 : 7] HDPL barrier end set in number of 8-Kbyte sectors
  [then]


  [ifdef] FLASH_FLASH_HDP1R_PRG_DEF
    \
    \ @brief FLASH HDP Bank1 configuration
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP1_STRT                \ [0x00 : 7] HDPL barrier start set in number of 8-Kbyte sectors
    $10 constant FLASH_HDP1_END                 \ [0x10 : 7] HDPL barrier end set in number of 8-Kbyte sectors
  [then]


  [ifdef] FLASH_FLASH_ECCCORR_DEF
    \
    \ @brief FLASH ECC correction register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 16] ECC error address
    $14 constant FLASH_OBK_ECC                  \ [0x14] Single ECC error corrected in flash OB Keys storage area.
    $15 constant FLASH_EDATA_ECC                \ [0x15] ECC fail for corrected ECC error in flash high-cycle data area
    $16 constant FLASH_BK_ECC                   \ [0x16] ECC fail bank for corrected ECC error
    $17 constant FLASH_SYSF_ECC                 \ [0x17] ECC fail for corrected ECC error in system flash memory
    $18 constant FLASH_OTP_ECC                  \ [0x18] OTP ECC error bit
    $19 constant FLASH_ECCCIE                   \ [0x19] ECC single correction error interrupt enable bit
    $1e constant FLASH_ECCC                     \ [0x1e] ECC correction set by hardware when single ECC error has been detected and corrected.
  [then]


  [ifdef] FLASH_FLASH_ECCDETR_DEF
    \
    \ @brief FLASH ECC detection register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 16] ECC error address
    $14 constant FLASH_OBK_ECC                  \ [0x14] ECC fail double ECC error in flash OB Keys storage area.
    $15 constant FLASH_EDATA_ECC                \ [0x15] ECC fail double ECC error in flash high-cycle data area
    $16 constant FLASH_BK_ECC                   \ [0x16] ECC fail bank for double ECC error
    $17 constant FLASH_SYSF_ECC                 \ [0x17] ECC fail for double ECC error in system flash memory
    $18 constant FLASH_OTP_ECC                  \ [0x18] OTP ECC error bit
    $1f constant FLASH_ECCD                     \ [0x1f] ECC detection
  [then]


  [ifdef] FLASH_FLASH_ECCDR_DEF
    \
    \ @brief FLASH ECC data
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_DATA_ECC                 \ [0x00 : 16] ECC error data
  [then]


  [ifdef] FLASH_FLASH_SECBB2R1_DEF
    \
    \ @brief FLASH secure block-based register for Bank2
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] Secure/non-secure flash Bank2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECBB2R2_DEF
    \
    \ @brief FLASH secure block-based register for Bank2
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] Secure/non-secure flash Bank2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECBB2R3_DEF
    \
    \ @brief FLASH secure block-based register for Bank2
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] Secure/non-secure flash Bank2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECBB2R4_DEF
    \
    \ @brief FLASH secure block-based register for Bank2
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] Secure/non-secure flash Bank2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB2R1_DEF
    \
    \ @brief FLASH privilege block-based register for Bank2
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB2                  \ [0x00 : 32] Privileged / non-privileged 8-Kbyte flash Bank2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB2R2_DEF
    \
    \ @brief FLASH privilege block-based register for Bank2
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB2                  \ [0x00 : 32] Privileged / non-privileged 8-Kbyte flash Bank2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB2R3_DEF
    \
    \ @brief FLASH privilege block-based register for Bank2
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB2                  \ [0x00 : 32] Privileged / non-privileged 8-Kbyte flash Bank2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB2R4_DEF
    \
    \ @brief FLASH privilege block-based register for Bank2
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB2                  \ [0x00 : 32] Privileged / non-privileged 8-Kbyte flash Bank2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECWM2R_CUR_DEF
    \
    \ @brief FLASH security watermark for Bank2
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECWM2_STRT              \ [0x00 : 7] Bank2 security WM area start sector
    $10 constant FLASH_SECWM2_END               \ [0x10 : 7] Bank2 security WM end sector
  [then]


  [ifdef] FLASH_FLASH_SECWM2R_PRG_DEF
    \
    \ @brief FLASH security watermark for Bank2
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECWM2_STRT              \ [0x00 : 7] Bank2 security WM area start sector
    $10 constant FLASH_SECWM2_END               \ [0x10 : 7] Bank2 security WM area end sector
  [then]


  [ifdef] FLASH_FLASH_WRP2R_CUR_DEF
    \
    \ @brief FLASH write sector group protection for Bank2
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSG2                   \ [0x00 : 32] Bank2 sector group protection option status byte
  [then]


  [ifdef] FLASH_FLASH_WRP2R_PRG_DEF
    \
    \ @brief FLASH write sector group protection for Bank2
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSG2                   \ [0x00 : 32] Bank2 sector group protection option status byte
  [then]


  [ifdef] FLASH_FLASH_EDATA2R_CUR_DEF
    \
    \ @brief FLASH data sectors configuration Bank2
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EDATA2_STRT              \ [0x00 : 3] EDATA2_STRT contains the start sectors of the flash high-cycle data area in Bank2 There is no hardware effect to those bits.
    $0f constant FLASH_EDATA2_EN                \ [0x0f] Bank2 flash high-cycle data enable
  [then]


  [ifdef] FLASH_FLASH_EDATA2R_PRG_DEF
    \
    \ @brief FLASH data sector configuration Bank2
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EDATA2_STRT              \ [0x00 : 3] EDATA2_STRT contains the start sectors of the flash high-cycle data area in Bank2 There is no hardware effect to those bits.
    $0f constant FLASH_EDATA2_EN                \ [0x0f] Bank2 flash high-cycle data enable
  [then]


  [ifdef] FLASH_FLASH_HDP2R_CUR_DEF
    \
    \ @brief FLASH HDP Bank2 configuration
    \ Address offset: 0x1F8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP2_STRT                \ [0x00 : 7] HDPL barrier start set in number of 8-Kbyte sectors
    $10 constant FLASH_HDP2_END                 \ [0x10 : 7] HDPL barrier end set in number of 8-Kbyte sectors
  [then]


  [ifdef] FLASH_FLASH_HDP2R_PRG_DEF
    \
    \ @brief FLASH HDP Bank2 configuration
    \ Address offset: 0x1FC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP2_STRT                \ [0x00 : 7] HDPL barrier start set in number of 8-Kbyte sectors
    $10 constant FLASH_HDP2_END                 \ [0x10 : 7] HDPL barrier end set in number of 8-Kbyte sectors
  [then]

  \
  \ @brief Mustang_FLASH register block
  \
  $00 constant FLASH_FLASH_ACR          \ FLASH access control register
  $04 constant FLASH_FLASH_NSKEYR       \ FLASH non-secure key register
  $08 constant FLASH_FLASH_SECKEYR      \ FLASH secure key register
  $0C constant FLASH_FLASH_OPTKEYR      \ FLASH option key register
  $10 constant FLASH_FLASH_NSOBKKEYR    \ FLASH non-secure OBK key register
  $14 constant FLASH_FLASH_SECOBKKEYR   \ FLASH secure OBK key register
  $18 constant FLASH_FLASH_OPSR         \ FLASH operation status register
  $1C constant FLASH_FLASH_OPTCR        \ FLASH option control register
  $20 constant FLASH_FLASH_NSSR         \ FLASH non-secure status register
  $24 constant FLASH_FLASH_SECSR        \ FLASH secure status register
  $28 constant FLASH_FLASH_NSCR         \ FLASH non-secure control register
  $2C constant FLASH_FLASH_SECCR        \ FLASH secure control register
  $30 constant FLASH_FLASH_NSCCR        \ FLASH non-secure clear control register
  $34 constant FLASH_FLASH_SECCCR       \ FLASH secure clear control register
  $3C constant FLASH_FLASH_PRIVCFGR     \ FLASH privilege configuration register
  $40 constant FLASH_FLASH_NSOBKCFGR    \ FLASH non-secure OBK configuration register
  $44 constant FLASH_FLASH_SECOBKCFGR   \ FLASH secure OBK configuration register
  $48 constant FLASH_FLASH_HDPEXTR      \ FLASH HDP extension register
  $50 constant FLASH_FLASH_OPTSR_CUR    \ FLASH option status register
  $54 constant FLASH_FLASH_OPTSR_PRG    \ FLASH option status register
  $60 constant FLASH_FLASH_NSEPOCHR_CUR \ FLASH non-secure EPOCH register
  $68 constant FLASH_FLASH_SECEPOCHR_CUR    \ FLASH secure EPOCH register
  $70 constant FLASH_FLASH_OPTSR2_CUR   \ FLASH option status register 2
  $74 constant FLASH_FLASH_OPTSR2_PRG   \ FLASH option status register 2
  $80 constant FLASH_FLASH_NSBOOTR_CUR  \ FLASH non-secure boot register
  $84 constant FLASH_FLASH_NSBOOTR_PRG  \ FLASH non-secure boot register
  $88 constant FLASH_FLASH_SECBOOTR_CUR \ FLASH secure boot register
  $8C constant FLASH_FLASH_BOOTR_PRG    \ FLASH secure boot register
  $90 constant FLASH_FLASH_OTPBLR_CUR   \ FLASH non-secure OTP block lock
  $94 constant FLASH_FLASH_OTPBLR_PRG   \ FLASH non-secure OTP block lock
  $A0 constant FLASH_FLASH_SECBB1R1     \ FLASH secure block based register for Bank1
  $A4 constant FLASH_FLASH_SECBB1R2     \ FLASH secure block based register for Bank1
  $A8 constant FLASH_FLASH_SECBB1R3     \ FLASH secure block based register for Bank1
  $AC constant FLASH_FLASH_SECBB1R4     \ FLASH secure block based register for Bank1
  $C0 constant FLASH_FLASH_PRIVBB1R1    \ FLASH privilege block based register for Bank1
  $C4 constant FLASH_FLASH_PRIVBB1R2    \ FLASH privilege block based register for Bank1
  $C8 constant FLASH_FLASH_PRIVBB1R3    \ FLASH privilege block based register for Bank1
  $CC constant FLASH_FLASH_PRIVBB1R4    \ FLASH privilege block based register for Bank1
  $E0 constant FLASH_FLASH_SECWM1R_CUR  \ FLASH security watermark for Bank1
  $E4 constant FLASH_FLASH_SECWM1R_PRG  \ FLASH security watermark for Bank1
  $E8 constant FLASH_FLASH_WRP1R_CUR    \ FLASH write sector group protection for Bank1
  $EC constant FLASH_FLASH_WRP1R_PRG    \ FLASH write sector group protection for Bank1
  $F0 constant FLASH_FLASH_EDATA1R_CUR  \ FLASH data sector configuration Bank1
  $F4 constant FLASH_FLASH_EDATA1R_PRG  \ FLASH data sector configuration Bank1
  $F8 constant FLASH_FLASH_HDP1R_CUR    \ FLASH HDP Bank1 configuration
  $FC constant FLASH_FLASH_HDP1R_PRG    \ FLASH HDP Bank1 configuration
  $100 constant FLASH_FLASH_ECCCORR     \ FLASH ECC correction register
  $104 constant FLASH_FLASH_ECCDETR     \ FLASH ECC detection register
  $108 constant FLASH_FLASH_ECCDR       \ FLASH ECC data
  $1A0 constant FLASH_FLASH_SECBB2R1    \ FLASH secure block-based register for Bank2
  $1A4 constant FLASH_FLASH_SECBB2R2    \ FLASH secure block-based register for Bank2
  $1A8 constant FLASH_FLASH_SECBB2R3    \ FLASH secure block-based register for Bank2
  $1AC constant FLASH_FLASH_SECBB2R4    \ FLASH secure block-based register for Bank2
  $1C0 constant FLASH_FLASH_PRIVBB2R1   \ FLASH privilege block-based register for Bank2
  $1C4 constant FLASH_FLASH_PRIVBB2R2   \ FLASH privilege block-based register for Bank2
  $1C8 constant FLASH_FLASH_PRIVBB2R3   \ FLASH privilege block-based register for Bank2
  $1CC constant FLASH_FLASH_PRIVBB2R4   \ FLASH privilege block-based register for Bank2
  $1E0 constant FLASH_FLASH_SECWM2R_CUR \ FLASH security watermark for Bank2
  $1E4 constant FLASH_FLASH_SECWM2R_PRG \ FLASH security watermark for Bank2
  $1E8 constant FLASH_FLASH_WRP2R_CUR   \ FLASH write sector group protection for Bank2
  $1EC constant FLASH_FLASH_WRP2R_PRG   \ FLASH write sector group protection for Bank2
  $1F0 constant FLASH_FLASH_EDATA2R_CUR \ FLASH data sectors configuration Bank2
  $1F4 constant FLASH_FLASH_EDATA2R_PRG \ FLASH data sector configuration Bank2
  $1F8 constant FLASH_FLASH_HDP2R_CUR   \ FLASH HDP Bank2 configuration
  $1FC constant FLASH_FLASH_HDP2R_PRG   \ FLASH HDP Bank2 configuration

: FLASH_DEF ; [then]
