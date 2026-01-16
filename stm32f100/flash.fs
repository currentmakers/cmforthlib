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

$00000008 constant FLASH_ACR_HLFCYA                                 \ Flash half cycle access enable


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

$00000001 constant FLASH_SR_BSY                                     \ Busy
$00000004 constant FLASH_SR_PGERR                                   \ Programming error
$00000010 constant FLASH_SR_WRPRTERR                                \ Write protection error
$00000020 constant FLASH_SR_EOP                                     \ End of operation


\
\ @brief Control register
\ Address offset: 0x10
\ Reset value: 0x00000080
\

$00000001 constant FLASH_CR_PG                                      \ Programming
$00000002 constant FLASH_CR_PER                                     \ Page Erase
$00000004 constant FLASH_CR_MER                                     \ Mass Erase
$00000010 constant FLASH_CR_OPTPG                                   \ Option byte programming
$00000020 constant FLASH_CR_OPTER                                   \ Option byte erase
$00000040 constant FLASH_CR_STRT                                    \ Start
$00000080 constant FLASH_CR_LOCK                                    \ Lock
$00000200 constant FLASH_CR_OPTWRE                                  \ Option bytes write enable
$00000400 constant FLASH_CR_ERRIE                                   \ Error interrupt enable
$00001000 constant FLASH_CR_EOPIE                                   \ End of operation interrupt enable


\
\ @brief Flash address register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant FLASH_AR_FAR                                     \ Flash Address


\
\ @brief Option byte register
\ Address offset: 0x1C
\ Reset value: 0x03FFFFFC
\

$00000001 constant FLASH_OBR_OPTERR                                 \ Option byte error
$00000002 constant FLASH_OBR_RDPRT                                  \ Read protection
$00000004 constant FLASH_OBR_WDG_SW                                 \ WDG_SW
$00000008 constant FLASH_OBR_NRST_STOP                              \ nRST_STOP
$00000010 constant FLASH_OBR_NRST_STDBY                             \ nRST_STDBY
$0003fc00 constant FLASH_OBR_DATA0                                  \ Data0
$03fc0000 constant FLASH_OBR_DATA1                                  \ Data1


\
\ @brief Write protection register
\ Address offset: 0x20
\ Reset value: 0xFFFFFFFF
\

$00000000 constant FLASH_WRPR_WRP                                   \ Write protect


\
\ @brief FLASH
\
$40022000 constant FLASH_ACR      \ offset: 0x00 : Flash access control register
$40022004 constant FLASH_KEYR     \ offset: 0x04 : Flash key register
$40022008 constant FLASH_OPTKEYR  \ offset: 0x08 : Flash option key register
$4002200c constant FLASH_SR       \ offset: 0x0C : Status register
$40022010 constant FLASH_CR       \ offset: 0x10 : Control register
$40022014 constant FLASH_AR       \ offset: 0x14 : Flash address register
$4002201c constant FLASH_OBR      \ offset: 0x1C : Option byte register
$40022020 constant FLASH_WRPR     \ offset: 0x20 : Write protection register

