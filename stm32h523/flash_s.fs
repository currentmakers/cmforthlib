\
\ @file flash_s.fs
\ @brief Flash secure global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FLASH access control register
\ Address offset: 0x00
\ Reset value: 0x00000013
\

$0000000f constant FLASH_S_FLASH_ACR_LATENCY                        \ Read latency
$00000030 constant FLASH_S_FLASH_ACR_WRHIGHFREQ                     \ Flash signal delay
$00000100 constant FLASH_S_FLASH_ACR_PRFTEN                         \ Prefetch enable.


\
\ @brief FLASH non-secure key register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_NSKEYR_NSKEY                       \ Non-volatile memory non-secure configuration access unlock key


\
\ @brief FLASH secure key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECKEYR_SECKEY                     \ Non-volatile memory secure configuration access unlock key


\
\ @brief FLASH option key register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_OPTKEYR_OPTKEY                     \ FLASH option bytes control access unlock key


\
\ @brief FLASH non-secure OBK key register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_NSOBKKEYR_NSOBKKEY                 \ FLASH non-secure option bytes keys control access unlock key


\
\ @brief FLASH secure OBK key register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECOBKKEYR_SECOBKKEY               \ FLASH secure option bytes keys control access unlock key


\
\ @brief FLASH operation status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000fffff constant FLASH_S_FLASH_OPSR_ADDR_OP                       \ Interrupted operation address
$00200000 constant FLASH_S_FLASH_OPSR_DATA_OP                       \ Flash high-cycle data area operation interrupted
$00400000 constant FLASH_S_FLASH_OPSR_BK_OP                         \ Interrupted operation bank
$00800000 constant FLASH_S_FLASH_OPSR_SYSF_OP                       \ Operation in system flash memory interrupted
$01000000 constant FLASH_S_FLASH_OPSR_OTP_OP                        \ OTP operation interrupted
$e0000000 constant FLASH_S_FLASH_OPSR_CODE_OP                       \ Flash memory operation code


\
\ @brief FLASH option control register
\ Address offset: 0x1C
\ Reset value: 0x00000001
\

$00000001 constant FLASH_S_FLASH_OPTCR_OPTLOCK                      \ FLASH_OPTCR lock option configuration bit
$00000002 constant FLASH_S_FLASH_OPTCR_OPTSTRT                      \ Option byte start change option configuration bit
$80000000 constant FLASH_S_FLASH_OPTCR_SWAP_BANK                    \ Bank swapping option configuration bit


\
\ @brief FLASH non-secure status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant FLASH_S_FLASH_NSSR_BSY                           \ busy flag
$00000002 constant FLASH_S_FLASH_NSSR_WBNE                          \ write buffer not empty flag
$00000008 constant FLASH_S_FLASH_NSSR_DBNE                          \ data buffer not empty flag
$00010000 constant FLASH_S_FLASH_NSSR_EOP                           \ end of operation flag
$00020000 constant FLASH_S_FLASH_NSSR_WRPERR                        \ write protection error flag
$00040000 constant FLASH_S_FLASH_NSSR_PGSERR                        \ programming sequence error flag
$00080000 constant FLASH_S_FLASH_NSSR_STRBERR                       \ strobe error flag
$00100000 constant FLASH_S_FLASH_NSSR_INCERR                        \ inconsistency error flag
$00200000 constant FLASH_S_FLASH_NSSR_OBKERR                        \ OBK general error flag
$00400000 constant FLASH_S_FLASH_NSSR_OBKWERR                       \ OBK write error flag
$00800000 constant FLASH_S_FLASH_NSSR_OPTCHANGEERR                  \ Option byte change error flag


\
\ @brief FLASH secure status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant FLASH_S_FLASH_SECSR_BSY                          \ busy flag
$00000002 constant FLASH_S_FLASH_SECSR_WBNE                         \ write buffer not empty flag
$00000008 constant FLASH_S_FLASH_SECSR_DBNE                         \ data buffer not empty flag
$00010000 constant FLASH_S_FLASH_SECSR_EOP                          \ end of operation flag
$00020000 constant FLASH_S_FLASH_SECSR_WRPERR                       \ write protection error flag
$00040000 constant FLASH_S_FLASH_SECSR_PGSERR                       \ programming sequence error flag
$00080000 constant FLASH_S_FLASH_SECSR_STRBERR                      \ strobe error flag
$00100000 constant FLASH_S_FLASH_SECSR_INCERR                       \ inconsistency error flag
$00200000 constant FLASH_S_FLASH_SECSR_OBKERR                       \ OBK general error flag
$00400000 constant FLASH_S_FLASH_SECSR_OBKWERR                      \ OBK write error flag


\
\ @brief FLASH non-secure control register
\ Address offset: 0x28
\ Reset value: 0x00000001
\

$00000001 constant FLASH_S_FLASH_NSCR_LOCK                          \ configuration lock bit
$00000002 constant FLASH_S_FLASH_NSCR_PG                            \ programming control bit
$00000004 constant FLASH_S_FLASH_NSCR_SER                           \ sector erase request
$00000008 constant FLASH_S_FLASH_NSCR_BER                           \ erase request
$00000010 constant FLASH_S_FLASH_NSCR_FW                            \ write forcing control bit
$00000020 constant FLASH_S_FLASH_NSCR_STRT                          \ erase start control bit
$00001fc0 constant FLASH_S_FLASH_NSCR_SNB                           \ sector erase selection number
$00008000 constant FLASH_S_FLASH_NSCR_MER                           \ mass erase request
$00010000 constant FLASH_S_FLASH_NSCR_EOPIE                         \ end of operation interrupt control bit
$00020000 constant FLASH_S_FLASH_NSCR_WRPERRIE                      \ write protection error interrupt enable bit
$00040000 constant FLASH_S_FLASH_NSCR_PGSERRIE                      \ programming sequence error interrupt enable bit
$00080000 constant FLASH_S_FLASH_NSCR_STRBERRIE                     \ strobe error interrupt enable bit
$00100000 constant FLASH_S_FLASH_NSCR_INCERRIE                      \ inconsistency error interrupt enable bit
$00200000 constant FLASH_S_FLASH_NSCR_OBKERRIE                      \ OBK general error interrupt enable bit
$00400000 constant FLASH_S_FLASH_NSCR_OBKWERRIE                     \ OBK write error interrupt enable bit
$00800000 constant FLASH_S_FLASH_NSCR_OPTCHANGEERRIE                \ Option byte change error interrupt enable bit
$80000000 constant FLASH_S_FLASH_NSCR_BKSEL                         \ Bank selector bit


\
\ @brief FLASH secure control register
\ Address offset: 0x2C
\ Reset value: 0x00000001
\

$00000001 constant FLASH_S_FLASH_SECCR_LOCK                         \ configuration lock bit
$00000002 constant FLASH_S_FLASH_SECCR_PG                           \ programming control bit
$00000004 constant FLASH_S_FLASH_SECCR_SER                          \ sector erase request
$00000008 constant FLASH_S_FLASH_SECCR_BER                          \ erase request
$00000010 constant FLASH_S_FLASH_SECCR_FW                           \ write forcing control bit
$00000020 constant FLASH_S_FLASH_SECCR_STRT                         \ erase start control bit
$00001fc0 constant FLASH_S_FLASH_SECCR_SNB                          \ sector erase selection number
$00008000 constant FLASH_S_FLASH_SECCR_MER                          \ mass erase request
$00010000 constant FLASH_S_FLASH_SECCR_EOPIE                        \ end of operation interrupt control bit
$00020000 constant FLASH_S_FLASH_SECCR_WRPERRIE                     \ write protection error interrupt enable bit
$00040000 constant FLASH_S_FLASH_SECCR_PGSERRIE                     \ programming sequence error interrupt enable bit
$00080000 constant FLASH_S_FLASH_SECCR_STRBERRIE                    \ strobe error interrupt enable bit
$00100000 constant FLASH_S_FLASH_SECCR_INCERRIE                     \ inconsistency error interrupt enable bit
$00200000 constant FLASH_S_FLASH_SECCR_OBKERRIE                     \ OBK general error interrupt enable bit
$00400000 constant FLASH_S_FLASH_SECCR_OBKWERRIE                    \ OBK write error interrupt enable bit
$20000000 constant FLASH_S_FLASH_SECCR_INV                          \ Flash memory security state invert.
$80000000 constant FLASH_S_FLASH_SECCR_BKSEL                        \ Bank selector bit


\
\ @brief FLASH non-secure clear control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00010000 constant FLASH_S_FLASH_NSCCR_CLR_EOP                      \ EOP flag clear bit
$00020000 constant FLASH_S_FLASH_NSCCR_CLR_WRPERR                   \ WRPERR flag clear bit
$00040000 constant FLASH_S_FLASH_NSCCR_CLR_PGSERR                   \ PGSERR flag clear bit
$00080000 constant FLASH_S_FLASH_NSCCR_CLR_STRBERR                  \ STRBERR flag clear bit
$00100000 constant FLASH_S_FLASH_NSCCR_CLR_INCERR                   \ INCERR flag clear bit
$00200000 constant FLASH_S_FLASH_NSCCR_CLR_OBKERR                   \ OBKERR flag clear bit.
$00400000 constant FLASH_S_FLASH_NSCCR_CLR_OBKWERR                  \ OBKWERR flag clear bit.
$00800000 constant FLASH_S_FLASH_NSCCR_CLR_OPTCHANGEERR             \ Clear the flag corresponding flag in FLASH_NSSR by writing this bit.


\
\ @brief FLASH secure clear control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00010000 constant FLASH_S_FLASH_SECCCR_CLR_EOP                     \ EOP flag clear bit
$00020000 constant FLASH_S_FLASH_SECCCR_CLR_WRPERR                  \ WRPERR flag clear bit
$00040000 constant FLASH_S_FLASH_SECCCR_CLR_PGSERR                  \ PGSERR flag clear bit
$00080000 constant FLASH_S_FLASH_SECCCR_CLR_STRBERR                 \ STRBERR flag clear bit
$00100000 constant FLASH_S_FLASH_SECCCR_CLR_INCERR                  \ INCERR flag clear bit
$00200000 constant FLASH_S_FLASH_SECCCR_CLR_OBKERR                  \ OBKWERR flag clear bit
$00400000 constant FLASH_S_FLASH_SECCCR_CLR_OBKWERR                 \ OBKWERR flag clear bit


\
\ @brief FLASH privilege configuration register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_S_FLASH_PRIVCFGR_SPRIV                     \ privilege attribute for secure registers
$00000002 constant FLASH_S_FLASH_PRIVCFGR_NSPRIV                    \ privilege attribute for non secure registers


\
\ @brief FLASH non-secure OBK configuration register
\ Address offset: 0x40
\ Reset value: 0x01FF0000
\

$00000001 constant FLASH_S_FLASH_NSOBKCFGR_LOCK                     \ OBKCFGR lock option configuration bit
$00000002 constant FLASH_S_FLASH_NSOBKCFGR_SWAP_SECT_REQ            \ OBK swap sector request bit
$00000004 constant FLASH_S_FLASH_NSOBKCFGR_ALT_SECT                 \ alternate sector bit
$00000008 constant FLASH_S_FLASH_NSOBKCFGR_ALT_SECT_ERASE           \ alternate sector erase bit
$01ff0000 constant FLASH_S_FLASH_NSOBKCFGR_SWAP_OFFSET              \ Key index (offset /16 bits) pointing for next swap.


\
\ @brief FLASH secure OBK configuration register
\ Address offset: 0x44
\ Reset value: 0x01FF0000
\

$00000001 constant FLASH_S_FLASH_SECOBKCFGR_LOCK                    \ OBKCFGR lock option configuration bit
$00000002 constant FLASH_S_FLASH_SECOBKCFGR_SWAP_SECT_REQ           \ OBK swap sector request bit
$00000004 constant FLASH_S_FLASH_SECOBKCFGR_ALT_SECT                \ alternate sector bit
$00000008 constant FLASH_S_FLASH_SECOBKCFGR_ALT_SECT_ERASE          \ alternate sector erase bit
$01ff0000 constant FLASH_S_FLASH_SECOBKCFGR_SWAP_OFFSET             \ key index (offset /16 bits) pointing for next swap.


\
\ @brief FLASH HDP extension register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant FLASH_S_FLASH_HDPEXTR_HDP1_EXT                   \ HDP area extension in 8 Kbytes sectors in Bank1.
$007f0000 constant FLASH_S_FLASH_HDPEXTR_HDP2_EXT                   \ HDP area extension in 8 Kbytes sectors in Bank2.


\
\ @brief FLASH option status register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant FLASH_S_FLASH_OPTSR_CUR_BOR_LEV                  \ Brownout level option status bit
$00000004 constant FLASH_S_FLASH_OPTSR_CUR_BORH_EN                  \ Brownout high enable
$00000008 constant FLASH_S_FLASH_OPTSR_CUR_IWDG_SW                  \ IWDG control mode option status bit
$00000010 constant FLASH_S_FLASH_OPTSR_CUR_WWDG_SW                  \ WWDG control mode option status bit
$00000040 constant FLASH_S_FLASH_OPTSR_CUR_NRST_STOP                \ Core domain Stop entry reset option status bit
$00000080 constant FLASH_S_FLASH_OPTSR_CUR_NRST_STDBY               \ Core domain Standby entry reset option status bit
$0000ff00 constant FLASH_S_FLASH_OPTSR_CUR_PRODUCT_STATE            \ Life state code (based on Hamming 8,4).
$00010000 constant FLASH_S_FLASH_OPTSR_CUR_IO_VDD_HSLV              \ High-speed IO at low Vless thansub>DDless than/sub> voltage configuration bit.
$00020000 constant FLASH_S_FLASH_OPTSR_CUR_IO_VDDIO2_HSLV           \ High-speed IO at low Vless thansub>DDIO2less than/sub> voltage configuration bit.
$00100000 constant FLASH_S_FLASH_OPTSR_CUR_IWDG_STOP                \ IWDG Stop mode freeze option status bit
$00200000 constant FLASH_S_FLASH_OPTSR_CUR_IWDG_STDBY               \ IWDG Standby mode freeze option status bit
$3fc00000 constant FLASH_S_FLASH_OPTSR_CUR_BOOT_UBE                 \ Available only on cryptography enabled devices.
$80000000 constant FLASH_S_FLASH_OPTSR_CUR_SWAP_BANK                \ Bank swapping option status bit


\
\ @brief FLASH option status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000003 constant FLASH_S_FLASH_OPTSR_PRG_BOR_LEV                  \ Brownout level option configuration bit
$00000004 constant FLASH_S_FLASH_OPTSR_PRG_BORH_EN                  \ Brownout high enable configuration bit
$00000008 constant FLASH_S_FLASH_OPTSR_PRG_IWDG_SW                  \ IWDG control mode option configuration bit
$00000010 constant FLASH_S_FLASH_OPTSR_PRG_WWDG_SW                  \ WWDG control mode option configuration bit
$00000040 constant FLASH_S_FLASH_OPTSR_PRG_NRST_STOP                \ Core domain Stop entry reset option configuration bit
$00000080 constant FLASH_S_FLASH_OPTSR_PRG_NRST_STDBY               \ Core domain Standby entry reset option configuration bit
$0000ff00 constant FLASH_S_FLASH_OPTSR_PRG_PRODUCT_STATE            \ Life state code (based on Hamming 8,4).
$00010000 constant FLASH_S_FLASH_OPTSR_PRG_IO_VDD_HSLV              \ High-speed IO at low VDD voltage configuration bit.
$00020000 constant FLASH_S_FLASH_OPTSR_PRG_IO_VDDIO2_HSLV           \ High-speed IO at low Vless thansub>DDIO2less than/sub> voltage configuration bit.
$00100000 constant FLASH_S_FLASH_OPTSR_PRG_IWDG_STOP                \ IWDG Stop mode freeze option status bit
$00200000 constant FLASH_S_FLASH_OPTSR_PRG_IWDG_STDBY               \ IWDG Standby mode freeze option status bit
$3fc00000 constant FLASH_S_FLASH_OPTSR_PRG_BOOT_UBE                 \ Available only on cryptography enabled devices.
$80000000 constant FLASH_S_FLASH_OPTSR_PRG_SWAP_BANK                \ Bank swapping option configuration bit


\
\ @brief FLASH non-secure EPOCH register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00ffffff constant FLASH_S_FLASH_NSEPOCHR_CUR_NS_EPOCH              \ Non-volatile non-secure EPOCH counter


\
\ @brief FLASH secure EPOCH register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00ffffff constant FLASH_S_FLASH_SECEPOCHR_CUR_SEC_EPOCH            \ Non-volatile secure EPOCH counter


\
\ @brief FLASH option status register 2
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000004 constant FLASH_S_FLASH_OPTSR2_CUR_SRAM13_RST              \ SRAM1 and SRAM3 erase upon system reset
$00000008 constant FLASH_S_FLASH_OPTSR2_CUR_SRAM2_RST               \ SRAM2 erase when system reset
$00000010 constant FLASH_S_FLASH_OPTSR2_CUR_BKPRAM_ECC              \ Backup RAM ECC detection and correction disable
$00000020 constant FLASH_S_FLASH_OPTSR2_CUR_SRAM3_ECC               \ SRAM3 ECC detection and correction disable
$00000040 constant FLASH_S_FLASH_OPTSR2_CUR_SRAM2_ECC               \ SRAM2 ECC detection and correction disable
$00000100 constant FLASH_S_FLASH_OPTSR2_CUR_USBPD_DIS               \ USB power delivery configuration option bit
$ff000000 constant FLASH_S_FLASH_OPTSR2_CUR_TZEN                    \ TrustZone enable configuration bits


\
\ @brief FLASH option status register 2
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000004 constant FLASH_S_FLASH_OPTSR2_PRG_SRAM1_3_RST             \ SRAM1 and SRAM3 erase upon system reset
$00000008 constant FLASH_S_FLASH_OPTSR2_PRG_SRAM2_RST               \ SRAM2 erase when system reset
$00000010 constant FLASH_S_FLASH_OPTSR2_PRG_BKPRAM_ECC              \ Backup RAM ECC detection and correction disable
$00000020 constant FLASH_S_FLASH_OPTSR2_PRG_SRAM3_ECC               \ SRAM3 ECC detection and correction disable
$00000040 constant FLASH_S_FLASH_OPTSR2_PRG_SRAM2_ECC               \ SRAM2 ECC detection and correction disable
$00000100 constant FLASH_S_FLASH_OPTSR2_PRG_USBPD_DIS               \ USB power delivery configuration option bit
$ff000000 constant FLASH_S_FLASH_OPTSR2_PRG_TZEN                    \ TrustZone enable configuration bits


\
\ @brief FLASH non-secure boot register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$000000ff constant FLASH_S_FLASH_NSBOOTR_CUR_NSBOOT_LOCK            \ Field locking the values of SWAP_BANK, and NSBOOTADD settings.
$ffffff00 constant FLASH_S_FLASH_NSBOOTR_CUR_NSBOOTADD              \ Non secure unique boot entry address


\
\ @brief FLASH non-secure boot register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000ff constant FLASH_S_FLASH_NSBOOTR_PRG_NSBOOT_LOCK            \ Field locking the values of SWAP_ BANK, and NSBOOTADD settings.
$ffffff00 constant FLASH_S_FLASH_NSBOOTR_PRG_NSBOOTADD              \ Non secure unique boot entry address


\
\ @brief FLASH secure boot register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant FLASH_S_FLASH_SECBOOTR_CUR_SECBOOT_LOCK          \ Field locking the values of UBE, SWAP_BANK, and SECBOOTADD settings.
$ffffff00 constant FLASH_S_FLASH_SECBOOTR_CUR_SECBOOTADD            \ Unique boot entry secure address


\
\ @brief FLASH secure boot register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$000000ff constant FLASH_S_FLASH_BOOTR_PRG_SECBOOT_LOCK             \ Field locking the values of UBE, SWAP_ BANK, and SECBOOTADD setting.
$ffffff00 constant FLASH_S_FLASH_BOOTR_PRG_SECBOOTADD               \ Secure unique boot entry address.


\
\ @brief FLASH non-secure OTP block lock
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_OTPBLR_CUR_LOCKBL                  \ OTP block lock


\
\ @brief FLASH non-secure OTP block lock
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_OTPBLR_PRG_LOCKBL                  \ OTP block lock


\
\ @brief FLASH secure block based register for Bank1
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECBB1R1_SECBB1                    \ Secure/non-secure 8 Kbytes flash Bank1 sector attributes


\
\ @brief FLASH secure block based register for Bank1
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECBB1R2_SECBB1                    \ Secure/non-secure 8 Kbytes flash Bank1 sector attributes


\
\ @brief FLASH secure block based register for Bank1
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECBB1R3_SECBB1                    \ Secure/non-secure 8 Kbytes flash Bank1 sector attributes


\
\ @brief FLASH secure block based register for Bank1
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECBB1R4_SECBB1                    \ Secure/non-secure 8 Kbytes flash Bank1 sector attributes


\
\ @brief FLASH privilege block based register for Bank1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_PRIVBB1R1_PRIVBB1                  \ Privileged/unprivileged 8-Kbyte flash Bank1 sector attribute


\
\ @brief FLASH privilege block based register for Bank1
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_PRIVBB1R2_PRIVBB1                  \ Privileged/unprivileged 8-Kbyte flash Bank1 sector attribute


\
\ @brief FLASH privilege block based register for Bank1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_PRIVBB1R3_PRIVBB1                  \ Privileged/unprivileged 8-Kbyte flash Bank1 sector attribute


\
\ @brief FLASH privilege block based register for Bank1
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_PRIVBB1R4_PRIVBB1                  \ Privileged/unprivileged 8-Kbyte flash Bank1 sector attribute


\
\ @brief FLASH security watermark for Bank1
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$0000007f constant FLASH_S_FLASH_SECWM1R_CUR_SECWM1_STRT            \ Bank1 security WM area 1 start sector
$007f0000 constant FLASH_S_FLASH_SECWM1R_CUR_SECWM1_END             \ Bank1 security WM area 1 end sector


\
\ @brief FLASH security watermark for Bank1
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$0000007f constant FLASH_S_FLASH_SECWM1R_PRG_SECWM1_STRT            \ Bank1 security WM area 1 start sector
$007f0000 constant FLASH_S_FLASH_SECWM1R_PRG_SECWM1_END             \ Bank1 security WM area 1 end sector


\
\ @brief FLASH write sector group protection for Bank1
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_WRP1R_CUR_WRPSG1                   \ Bank1 sector group protection option status byte


\
\ @brief FLASH write sector group protection for Bank1
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_WRP1R_PRG_WRPSG1                   \ Bank1 sector group protection option status byte


\
\ @brief FLASH data sector configuration Bank1
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000007 constant FLASH_S_FLASH_EDATA1R_CUR_EDATA1_STRT            \ EDATA1_STRT contains the start sectors of the flash high-cycle data area in Bank1 There is no hardware effect to those bits.
$00008000 constant FLASH_S_FLASH_EDATA1R_CUR_EDATA1_EN              \ Bank1 flash high-cycle data enable


\
\ @brief FLASH data sector configuration Bank1
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000007 constant FLASH_S_FLASH_EDATA1R_PRG_EDATA1_STRT            \ EDATA1_STRT contains the start sectors of the flash high-cycle data area in Bank1 There is no hardware effect to those bits.
$00008000 constant FLASH_S_FLASH_EDATA1R_PRG_EDATA1_EN              \ Bank1 flash high-cycle data enable


\
\ @brief FLASH HDP Bank1 configuration
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$0000007f constant FLASH_S_FLASH_HDP1R_CUR_HDP1_STRT                \ HDPL barrier start set in number of 8-Kbyte sectors
$007f0000 constant FLASH_S_FLASH_HDP1R_CUR_HDP1_END                 \ HDPL barrier end set in number of 8-Kbyte sectors


\
\ @brief FLASH HDP Bank1 configuration
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$0000007f constant FLASH_S_FLASH_HDP1R_PRG_HDP1_STRT                \ HDPL barrier start set in number of 8-Kbyte sectors
$007f0000 constant FLASH_S_FLASH_HDP1R_PRG_HDP1_END                 \ HDPL barrier end set in number of 8-Kbyte sectors


\
\ @brief FLASH ECC correction register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_S_FLASH_ECCCORR_ADDR_ECC                   \ ECC error address
$00100000 constant FLASH_S_FLASH_ECCCORR_OBK_ECC                    \ Single ECC error corrected in flash OB Keys storage area.
$00200000 constant FLASH_S_FLASH_ECCCORR_EDATA_ECC                  \ ECC fail for corrected ECC error in flash high-cycle data area
$00400000 constant FLASH_S_FLASH_ECCCORR_BK_ECC                     \ ECC fail bank for corrected ECC error
$00800000 constant FLASH_S_FLASH_ECCCORR_SYSF_ECC                   \ ECC fail for corrected ECC error in system flash memory
$01000000 constant FLASH_S_FLASH_ECCCORR_OTP_ECC                    \ OTP ECC error bit
$02000000 constant FLASH_S_FLASH_ECCCORR_ECCCIE                     \ ECC single correction error interrupt enable bit
$40000000 constant FLASH_S_FLASH_ECCCORR_ECCC                       \ ECC correction set by hardware when single ECC error has been detected and corrected.


\
\ @brief FLASH ECC detection register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_S_FLASH_ECCDETR_ADDR_ECC                   \ ECC error address
$00100000 constant FLASH_S_FLASH_ECCDETR_OBK_ECC                    \ ECC fail double ECC error in flash OB Keys storage area.
$00200000 constant FLASH_S_FLASH_ECCDETR_EDATA_ECC                  \ ECC fail double ECC error in flash high-cycle data area
$00400000 constant FLASH_S_FLASH_ECCDETR_BK_ECC                     \ ECC fail bank for double ECC error
$00800000 constant FLASH_S_FLASH_ECCDETR_SYSF_ECC                   \ ECC fail for double ECC error in system flash memory
$01000000 constant FLASH_S_FLASH_ECCDETR_OTP_ECC                    \ OTP ECC error bit
$80000000 constant FLASH_S_FLASH_ECCDETR_ECCD                       \ ECC detection


\
\ @brief FLASH ECC data
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_S_FLASH_ECCDR_DATA_ECC                     \ ECC error data


\
\ @brief FLASH secure block-based register for Bank2
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECBB2R1_SECBB2                    \ Secure/non-secure flash Bank2 sector attribute


\
\ @brief FLASH secure block-based register for Bank2
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECBB2R2_SECBB2                    \ Secure/non-secure flash Bank2 sector attribute


\
\ @brief FLASH secure block-based register for Bank2
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECBB2R3_SECBB2                    \ Secure/non-secure flash Bank2 sector attribute


\
\ @brief FLASH secure block-based register for Bank2
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_SECBB2R4_SECBB2                    \ Secure/non-secure flash Bank2 sector attribute


\
\ @brief FLASH privilege block-based register for Bank2
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_PRIVBB2R1_PRIVBB2                  \ Privileged / non-privileged 8-Kbyte flash Bank2 sector attribute


\
\ @brief FLASH privilege block-based register for Bank2
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_PRIVBB2R2_PRIVBB2                  \ Privileged / non-privileged 8-Kbyte flash Bank2 sector attribute


\
\ @brief FLASH privilege block-based register for Bank2
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_PRIVBB2R3_PRIVBB2                  \ Privileged / non-privileged 8-Kbyte flash Bank2 sector attribute


\
\ @brief FLASH privilege block-based register for Bank2
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_PRIVBB2R4_PRIVBB2                  \ Privileged / non-privileged 8-Kbyte flash Bank2 sector attribute


\
\ @brief FLASH security watermark for Bank2
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$0000007f constant FLASH_S_FLASH_SECWM2R_CUR_SECWM2_STRT            \ Bank2 security WM area start sector
$007f0000 constant FLASH_S_FLASH_SECWM2R_CUR_SECWM2_END             \ Bank2 security WM end sector


\
\ @brief FLASH security watermark for Bank2
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$0000007f constant FLASH_S_FLASH_SECWM2R_PRG_SECWM2_STRT            \ Bank2 security WM area start sector
$007f0000 constant FLASH_S_FLASH_SECWM2R_PRG_SECWM2_END             \ Bank2 security WM area end sector


\
\ @brief FLASH write sector group protection for Bank2
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_WRP2R_CUR_WRPSG2                   \ Bank2 sector group protection option status byte


\
\ @brief FLASH write sector group protection for Bank2
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_S_FLASH_WRP2R_PRG_WRPSG2                   \ Bank2 sector group protection option status byte


\
\ @brief FLASH data sectors configuration Bank2
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$00000007 constant FLASH_S_FLASH_EDATA2R_CUR_EDATA2_STRT            \ EDATA2_STRT contains the start sectors of the flash high-cycle data area in Bank2 There is no hardware effect to those bits.
$00008000 constant FLASH_S_FLASH_EDATA2R_CUR_EDATA2_EN              \ Bank2 flash high-cycle data enable


\
\ @brief FLASH data sector configuration Bank2
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$00000007 constant FLASH_S_FLASH_EDATA2R_PRG_EDATA2_STRT            \ EDATA2_STRT contains the start sectors of the flash high-cycle data area in Bank2 There is no hardware effect to those bits.
$00008000 constant FLASH_S_FLASH_EDATA2R_PRG_EDATA2_EN              \ Bank2 flash high-cycle data enable


\
\ @brief FLASH HDP Bank2 configuration
\ Address offset: 0x1F8
\ Reset value: 0x00000000
\

$0000007f constant FLASH_S_FLASH_HDP2R_CUR_HDP2_STRT                \ HDPL barrier start set in number of 8-Kbyte sectors
$007f0000 constant FLASH_S_FLASH_HDP2R_CUR_HDP2_END                 \ HDPL barrier end set in number of 8-Kbyte sectors


\
\ @brief FLASH HDP Bank2 configuration
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$0000007f constant FLASH_S_FLASH_HDP2R_PRG_HDP2_STRT                \ HDPL barrier start set in number of 8-Kbyte sectors
$007f0000 constant FLASH_S_FLASH_HDP2R_PRG_HDP2_END                 \ HDPL barrier end set in number of 8-Kbyte sectors


\
\ @brief Flash secure global interrupt
\
$50022000 constant FLASH_S_FLASH_ACR  \ offset: 0x00 : FLASH access control register
$50022004 constant FLASH_S_FLASH_NSKEYR  \ offset: 0x04 : FLASH non-secure key register
$50022008 constant FLASH_S_FLASH_SECKEYR  \ offset: 0x08 : FLASH secure key register
$5002200c constant FLASH_S_FLASH_OPTKEYR  \ offset: 0x0C : FLASH option key register
$50022010 constant FLASH_S_FLASH_NSOBKKEYR  \ offset: 0x10 : FLASH non-secure OBK key register
$50022014 constant FLASH_S_FLASH_SECOBKKEYR  \ offset: 0x14 : FLASH secure OBK key register
$50022018 constant FLASH_S_FLASH_OPSR  \ offset: 0x18 : FLASH operation status register
$5002201c constant FLASH_S_FLASH_OPTCR  \ offset: 0x1C : FLASH option control register
$50022020 constant FLASH_S_FLASH_NSSR  \ offset: 0x20 : FLASH non-secure status register
$50022024 constant FLASH_S_FLASH_SECSR  \ offset: 0x24 : FLASH secure status register
$50022028 constant FLASH_S_FLASH_NSCR  \ offset: 0x28 : FLASH non-secure control register
$5002202c constant FLASH_S_FLASH_SECCR  \ offset: 0x2C : FLASH secure control register
$50022030 constant FLASH_S_FLASH_NSCCR  \ offset: 0x30 : FLASH non-secure clear control register
$50022034 constant FLASH_S_FLASH_SECCCR  \ offset: 0x34 : FLASH secure clear control register
$5002203c constant FLASH_S_FLASH_PRIVCFGR  \ offset: 0x3C : FLASH privilege configuration register
$50022040 constant FLASH_S_FLASH_NSOBKCFGR  \ offset: 0x40 : FLASH non-secure OBK configuration register
$50022044 constant FLASH_S_FLASH_SECOBKCFGR  \ offset: 0x44 : FLASH secure OBK configuration register
$50022048 constant FLASH_S_FLASH_HDPEXTR  \ offset: 0x48 : FLASH HDP extension register
$50022050 constant FLASH_S_FLASH_OPTSR_CUR  \ offset: 0x50 : FLASH option status register
$50022054 constant FLASH_S_FLASH_OPTSR_PRG  \ offset: 0x54 : FLASH option status register
$50022060 constant FLASH_S_FLASH_NSEPOCHR_CUR  \ offset: 0x60 : FLASH non-secure EPOCH register
$50022068 constant FLASH_S_FLASH_SECEPOCHR_CUR  \ offset: 0x68 : FLASH secure EPOCH register
$50022070 constant FLASH_S_FLASH_OPTSR2_CUR  \ offset: 0x70 : FLASH option status register 2
$50022074 constant FLASH_S_FLASH_OPTSR2_PRG  \ offset: 0x74 : FLASH option status register 2
$50022080 constant FLASH_S_FLASH_NSBOOTR_CUR  \ offset: 0x80 : FLASH non-secure boot register
$50022084 constant FLASH_S_FLASH_NSBOOTR_PRG  \ offset: 0x84 : FLASH non-secure boot register
$50022088 constant FLASH_S_FLASH_SECBOOTR_CUR  \ offset: 0x88 : FLASH secure boot register
$5002208c constant FLASH_S_FLASH_BOOTR_PRG  \ offset: 0x8C : FLASH secure boot register
$50022090 constant FLASH_S_FLASH_OTPBLR_CUR  \ offset: 0x90 : FLASH non-secure OTP block lock
$50022094 constant FLASH_S_FLASH_OTPBLR_PRG  \ offset: 0x94 : FLASH non-secure OTP block lock
$500220a0 constant FLASH_S_FLASH_SECBB1R1  \ offset: 0xA0 : FLASH secure block based register for Bank1
$500220a4 constant FLASH_S_FLASH_SECBB1R2  \ offset: 0xA4 : FLASH secure block based register for Bank1
$500220a8 constant FLASH_S_FLASH_SECBB1R3  \ offset: 0xA8 : FLASH secure block based register for Bank1
$500220ac constant FLASH_S_FLASH_SECBB1R4  \ offset: 0xAC : FLASH secure block based register for Bank1
$500220c0 constant FLASH_S_FLASH_PRIVBB1R1  \ offset: 0xC0 : FLASH privilege block based register for Bank1
$500220c4 constant FLASH_S_FLASH_PRIVBB1R2  \ offset: 0xC4 : FLASH privilege block based register for Bank1
$500220c8 constant FLASH_S_FLASH_PRIVBB1R3  \ offset: 0xC8 : FLASH privilege block based register for Bank1
$500220cc constant FLASH_S_FLASH_PRIVBB1R4  \ offset: 0xCC : FLASH privilege block based register for Bank1
$500220e0 constant FLASH_S_FLASH_SECWM1R_CUR  \ offset: 0xE0 : FLASH security watermark for Bank1
$500220e4 constant FLASH_S_FLASH_SECWM1R_PRG  \ offset: 0xE4 : FLASH security watermark for Bank1
$500220e8 constant FLASH_S_FLASH_WRP1R_CUR  \ offset: 0xE8 : FLASH write sector group protection for Bank1
$500220ec constant FLASH_S_FLASH_WRP1R_PRG  \ offset: 0xEC : FLASH write sector group protection for Bank1
$500220f0 constant FLASH_S_FLASH_EDATA1R_CUR  \ offset: 0xF0 : FLASH data sector configuration Bank1
$500220f4 constant FLASH_S_FLASH_EDATA1R_PRG  \ offset: 0xF4 : FLASH data sector configuration Bank1
$500220f8 constant FLASH_S_FLASH_HDP1R_CUR  \ offset: 0xF8 : FLASH HDP Bank1 configuration
$500220fc constant FLASH_S_FLASH_HDP1R_PRG  \ offset: 0xFC : FLASH HDP Bank1 configuration
$50022100 constant FLASH_S_FLASH_ECCCORR  \ offset: 0x100 : FLASH ECC correction register
$50022104 constant FLASH_S_FLASH_ECCDETR  \ offset: 0x104 : FLASH ECC detection register
$50022108 constant FLASH_S_FLASH_ECCDR  \ offset: 0x108 : FLASH ECC data
$500221a0 constant FLASH_S_FLASH_SECBB2R1  \ offset: 0x1A0 : FLASH secure block-based register for Bank2
$500221a4 constant FLASH_S_FLASH_SECBB2R2  \ offset: 0x1A4 : FLASH secure block-based register for Bank2
$500221a8 constant FLASH_S_FLASH_SECBB2R3  \ offset: 0x1A8 : FLASH secure block-based register for Bank2
$500221ac constant FLASH_S_FLASH_SECBB2R4  \ offset: 0x1AC : FLASH secure block-based register for Bank2
$500221c0 constant FLASH_S_FLASH_PRIVBB2R1  \ offset: 0x1C0 : FLASH privilege block-based register for Bank2
$500221c4 constant FLASH_S_FLASH_PRIVBB2R2  \ offset: 0x1C4 : FLASH privilege block-based register for Bank2
$500221c8 constant FLASH_S_FLASH_PRIVBB2R3  \ offset: 0x1C8 : FLASH privilege block-based register for Bank2
$500221cc constant FLASH_S_FLASH_PRIVBB2R4  \ offset: 0x1CC : FLASH privilege block-based register for Bank2
$500221e0 constant FLASH_S_FLASH_SECWM2R_CUR  \ offset: 0x1E0 : FLASH security watermark for Bank2
$500221e4 constant FLASH_S_FLASH_SECWM2R_PRG  \ offset: 0x1E4 : FLASH security watermark for Bank2
$500221e8 constant FLASH_S_FLASH_WRP2R_CUR  \ offset: 0x1E8 : FLASH write sector group protection for Bank2
$500221ec constant FLASH_S_FLASH_WRP2R_PRG  \ offset: 0x1EC : FLASH write sector group protection for Bank2
$500221f0 constant FLASH_S_FLASH_EDATA2R_CUR  \ offset: 0x1F0 : FLASH data sectors configuration Bank2
$500221f4 constant FLASH_S_FLASH_EDATA2R_PRG  \ offset: 0x1F4 : FLASH data sector configuration Bank2
$500221f8 constant FLASH_S_FLASH_HDP2R_CUR  \ offset: 0x1F8 : FLASH HDP Bank2 configuration
$500221fc constant FLASH_S_FLASH_HDP2R_PRG  \ offset: 0x1FC : FLASH HDP Bank2 configuration

