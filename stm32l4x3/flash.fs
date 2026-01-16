\
\ @file flash.fs
\ @brief Flash
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Access control register
\ Address offset: 0x00
\ Reset value: 0x00000600
\

$00000007 constant FLASH_ACR_LATENCY                                \ Latency
$00000100 constant FLASH_ACR_PRFTEN                                 \ Prefetch enable
$00000200 constant FLASH_ACR_ICEN                                   \ Instruction cache enable
$00000400 constant FLASH_ACR_DCEN                                   \ Data cache enable
$00000800 constant FLASH_ACR_ICRST                                  \ Instruction cache reset
$00001000 constant FLASH_ACR_DCRST                                  \ Data cache reset
$00002000 constant FLASH_ACR_RUN_PD                                 \ Flash Power-down mode during Low-power run mode
$00004000 constant FLASH_ACR_SLEEP_PD                               \ Flash Power-down mode during Low-power sleep mode


\
\ @brief Power down key register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant FLASH_PDKEYR_PDKEYR                              \ RUN_PD in FLASH_ACR key


\
\ @brief Flash key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_KEYR_KEYR                                  \ KEYR


\
\ @brief Option byte key register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_OPTKEYR_OPTKEYR                            \ Option byte key


\
\ @brief Status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant FLASH_SR_EOP                                     \ End of operation
$00000002 constant FLASH_SR_OPERR                                   \ Operation error
$00000008 constant FLASH_SR_PROGERR                                 \ Programming error
$00000010 constant FLASH_SR_WRPERR                                  \ Write protected error
$00000020 constant FLASH_SR_PGAERR                                  \ Programming alignment error
$00000040 constant FLASH_SR_SIZERR                                  \ Size error
$00000080 constant FLASH_SR_PGSERR                                  \ Programming sequence error
$00000100 constant FLASH_SR_MISERR                                  \ Fast programming data miss error
$00000200 constant FLASH_SR_FASTERR                                 \ Fast programming error
$00004000 constant FLASH_SR_RDERR                                   \ PCROP read error
$00008000 constant FLASH_SR_OPTVERR                                 \ Option validity error
$00010000 constant FLASH_SR_BSY                                     \ Busy


\
\ @brief Flash control register
\ Address offset: 0x14
\ Reset value: 0xC0000000
\

$00000001 constant FLASH_CR_PG                                      \ Programming
$00000002 constant FLASH_CR_PER                                     \ Page erase
$00000004 constant FLASH_CR_MER1                                    \ Bank 1 Mass erase
$000007f8 constant FLASH_CR_PNB                                     \ Page number
$00000800 constant FLASH_CR_BKER                                    \ Bank erase
$00008000 constant FLASH_CR_MER2                                    \ Bank 2 Mass erase
$00010000 constant FLASH_CR_START                                   \ Start
$00020000 constant FLASH_CR_OPTSTRT                                 \ Options modification start
$00040000 constant FLASH_CR_FSTPG                                   \ Fast programming
$01000000 constant FLASH_CR_EOPIE                                   \ End of operation interrupt enable
$02000000 constant FLASH_CR_ERRIE                                   \ Error interrupt enable
$04000000 constant FLASH_CR_RDERRIE                                 \ PCROP read error interrupt enable
$08000000 constant FLASH_CR_OBL_LAUNCH                              \ Force the option byte loading
$40000000 constant FLASH_CR_OPTLOCK                                 \ Options Lock
$80000000 constant FLASH_CR_LOCK                                    \ FLASH_CR Lock


\
\ @brief Flash ECC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0007ffff constant FLASH_ECCR_ADDR_ECC                              \ ECC fail address
$00080000 constant FLASH_ECCR_BK_ECC                                \ ECC fail bank
$00100000 constant FLASH_ECCR_SYSF_ECC                              \ System Flash ECC fail
$01000000 constant FLASH_ECCR_ECCIE                                 \ ECC correction interrupt enable
$40000000 constant FLASH_ECCR_ECCC                                  \ ECC correction
$80000000 constant FLASH_ECCR_ECCD                                  \ ECC detection


\
\ @brief Flash option register
\ Address offset: 0x20
\ Reset value: 0xF0000000
\

$000000ff constant FLASH_OPTR_RDP                                   \ Read protection level
$00000700 constant FLASH_OPTR_BOR_LEV                               \ BOR reset Level
$00001000 constant FLASH_OPTR_NRST_STOP                             \ nRST_STOP
$00002000 constant FLASH_OPTR_NRST_STDBY                            \ nRST_STDBY
$00010000 constant FLASH_OPTR_IDWG_SW                               \ Independent watchdog selection
$00020000 constant FLASH_OPTR_IWDG_STOP                             \ Independent watchdog counter freeze in Stop mode
$00040000 constant FLASH_OPTR_IWDG_STDBY                            \ Independent watchdog counter freeze in Standby mode
$00080000 constant FLASH_OPTR_WWDG_SW                               \ Window watchdog selection
$00100000 constant FLASH_OPTR_BFB2                                  \ Dual-bank boot
$00200000 constant FLASH_OPTR_DUALBANK                              \ Dual-Bank on 512 KB or 256 KB Flash memory devices
$00800000 constant FLASH_OPTR_NBOOT1                                \ Boot configuration
$01000000 constant FLASH_OPTR_SRAM2_PE                              \ SRAM2 parity check enable
$02000000 constant FLASH_OPTR_SRAM2_RST                             \ SRAM2 Erase when system reset


\
\ @brief Flash Bank 1 PCROP Start address register
\ Address offset: 0x24
\ Reset value: 0xFFFF0000
\

$0000ffff constant FLASH_PCROP1SR_PCROP1_STRT                       \ Bank 1 PCROP area start offset


\
\ @brief Flash Bank 1 PCROP End address register
\ Address offset: 0x28
\ Reset value: 0x0FFF0000
\

$0000ffff constant FLASH_PCROP1ER_PCROP1_END                        \ Bank 1 PCROP area end offset
$80000000 constant FLASH_PCROP1ER_PCROP_RDP                         \ PCROP area preserved when RDP level decreased


\
\ @brief Flash Bank 1 WRP area A address register
\ Address offset: 0x2C
\ Reset value: 0xFF00FF00
\

$000000ff constant FLASH_WRP1AR_WRP1A_STRT                          \ Bank 1 WRP first area
$00ff0000 constant FLASH_WRP1AR_WRP1A_END                           \ Bank 1 WRP first area A end offset


\
\ @brief Flash Bank 1 WRP area B address register
\ Address offset: 0x30
\ Reset value: 0xFF00FF00
\

$000000ff constant FLASH_WRP1BR_WRP1B_STRT                          \ Bank 1 WRP second area B start offset
$00ff0000 constant FLASH_WRP1BR_WRP1B_END                           \ Bank 1 WRP second area B end offset


\
\ @brief Flash Bank 2 PCROP Start address register
\ Address offset: 0x44
\ Reset value: 0xFFFF0000
\

$0000ffff constant FLASH_PCROP2SR_PCROP2_STRT                       \ Bank 2 PCROP area start offset


\
\ @brief Flash Bank 2 PCROP End address register
\ Address offset: 0x48
\ Reset value: 0xFFFF0000
\

$0000ffff constant FLASH_PCROP2ER_PCROP2_END                        \ Bank 2 PCROP area end offset


\
\ @brief Flash Bank 2 WRP area A address register
\ Address offset: 0x4C
\ Reset value: 0xFF00FF00
\

$000000ff constant FLASH_WRP2AR_WRP2A_STRT                          \ Bank 2 WRP first area A start offset
$00ff0000 constant FLASH_WRP2AR_WRP2A_END                           \ Bank 2 WRP first area A end offset


\
\ @brief Flash Bank 2 WRP area B address register
\ Address offset: 0x50
\ Reset value: 0xFF00FF00
\

$000000ff constant FLASH_WRP2BR_WRP2B_STRT                          \ Bank 2 WRP second area B start offset
$00ff0000 constant FLASH_WRP2BR_WRP2B_END                           \ Bank 2 WRP second area B end offset


\
\ @brief Flash
\
$40022000 constant FLASH_ACR      \ offset: 0x00 : Access control register
$40022004 constant FLASH_PDKEYR   \ offset: 0x04 : Power down key register
$40022008 constant FLASH_KEYR     \ offset: 0x08 : Flash key register
$4002200c constant FLASH_OPTKEYR  \ offset: 0x0C : Option byte key register
$40022010 constant FLASH_SR       \ offset: 0x10 : Status register
$40022014 constant FLASH_CR       \ offset: 0x14 : Flash control register
$40022018 constant FLASH_ECCR     \ offset: 0x18 : Flash ECC register
$40022020 constant FLASH_OPTR     \ offset: 0x20 : Flash option register
$40022024 constant FLASH_PCROP1SR  \ offset: 0x24 : Flash Bank 1 PCROP Start address register
$40022028 constant FLASH_PCROP1ER  \ offset: 0x28 : Flash Bank 1 PCROP End address register
$4002202c constant FLASH_WRP1AR   \ offset: 0x2C : Flash Bank 1 WRP area A address register
$40022030 constant FLASH_WRP1BR   \ offset: 0x30 : Flash Bank 1 WRP area B address register
$40022044 constant FLASH_PCROP2SR  \ offset: 0x44 : Flash Bank 2 PCROP Start address register
$40022048 constant FLASH_PCROP2ER  \ offset: 0x48 : Flash Bank 2 PCROP End address register
$4002204c constant FLASH_WRP2AR   \ offset: 0x4C : Flash Bank 2 WRP area A address register
$40022050 constant FLASH_WRP2BR   \ offset: 0x50 : Flash Bank 2 WRP area B address register

