\
\ @file flash.fs
\ @brief FLASH
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Flash access control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant FLASH_ACR_LATENCY                                \ Latency
$00000100 constant FLASH_ACR_PRFTEN                                 \ Prefetch enable
$00000200 constant FLASH_ACR_ARTEN                                  \ ART Accelerator Enable
$00000800 constant FLASH_ACR_ARTRST                                 \ ART Accelerator reset


\
\ @brief Flash key register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant FLASH_KEYR_KEY                                   \ FPEC key


\
\ @brief Flash option key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_OPTKEYR_OPTKEY                             \ Option byte key


\
\ @brief Status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_SR_EOP                                     \ End of operation
$00000002 constant FLASH_SR_OPERR                                   \ Operation error
$00000010 constant FLASH_SR_WRPERR                                  \ Write protection error
$00000020 constant FLASH_SR_PGAERR                                  \ Programming alignment error
$00000040 constant FLASH_SR_PGPERR                                  \ Programming parallelism error
$00000080 constant FLASH_SR_PGSERR                                  \ Programming sequence error
$00010000 constant FLASH_SR_BSY                                     \ Busy


\
\ @brief Control register
\ Address offset: 0x10
\ Reset value: 0x80000000
\

$00000001 constant FLASH_CR_PG                                      \ Programming
$00000002 constant FLASH_CR_SER                                     \ Sector Erase
$00000004 constant FLASH_CR_MER                                     \ Mass Erase of sectors 0 to 11
$000000f8 constant FLASH_CR_SNB                                     \ Sector number
$00000300 constant FLASH_CR_PSIZE                                   \ Program size
$00008000 constant FLASH_CR_MER1                                    \ Mass Erase of sectors 12 to 23
$00010000 constant FLASH_CR_STRT                                    \ Start
$01000000 constant FLASH_CR_EOPIE                                   \ End of operation interrupt enable
$02000000 constant FLASH_CR_ERRIE                                   \ Error interrupt enable
$80000000 constant FLASH_CR_LOCK                                    \ Lock


\
\ @brief Flash option control register
\ Address offset: 0x14
\ Reset value: 0x0FFFAAED
\

$00000001 constant FLASH_OPTCR_OPTLOCK                              \ Option lock
$00000002 constant FLASH_OPTCR_OPTSTRT                              \ Option start
$0000000c constant FLASH_OPTCR_BOR_LEV                              \ BOR reset Level
$00000010 constant FLASH_OPTCR_WWDG_SW                              \ User option bytes
$00000020 constant FLASH_OPTCR_IWDG_SW                              \ User option bytes
$00000040 constant FLASH_OPTCR_NRST_STOP                            \ User option bytes
$00000080 constant FLASH_OPTCR_NRST_STDBY                           \ User option bytes
$0000ff00 constant FLASH_OPTCR_RDP                                  \ Read protect
$0fff0000 constant FLASH_OPTCR_NWRP                                 \ Not write protect
$10000000 constant FLASH_OPTCR_NDBOOT                               \ Dual Boot mode (valid only when nDBANK=0)
$20000000 constant FLASH_OPTCR_NDBANK                               \ Not dual bank mode
$40000000 constant FLASH_OPTCR_IWDG_STDBY                           \ Independent watchdog counter freeze in standby mode
$80000000 constant FLASH_OPTCR_IWDG_STOP                            \ Independent watchdog counter freeze in Stop mode


\
\ @brief Flash option control register 1
\ Address offset: 0x18
\ Reset value: 0x0FFF0000
\

$0000ffff constant FLASH_OPTCR1_BOOT_ADD0                           \ Boot base address when Boot pin =0
$ffff0000 constant FLASH_OPTCR1_BOOT_ADD1                           \ Boot base address when Boot pin =1


\
\ @brief FLASH
\
$40023c00 constant FLASH_ACR      \ offset: 0x00 : Flash access control register
$40023c04 constant FLASH_KEYR     \ offset: 0x04 : Flash key register
$40023c08 constant FLASH_OPTKEYR  \ offset: 0x08 : Flash option key register
$40023c0c constant FLASH_SR       \ offset: 0x0C : Status register
$40023c10 constant FLASH_CR       \ offset: 0x10 : Control register
$40023c14 constant FLASH_OPTCR    \ offset: 0x14 : Flash option control register
$40023c18 constant FLASH_OPTCR1   \ offset: 0x18 : Flash option control register 1

