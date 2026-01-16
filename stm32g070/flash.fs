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
$00000800 constant FLASH_ACR_ICRST                                  \ Instruction cache reset
$00010000 constant FLASH_ACR_EMPTY                                  \ Flash User area empty


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
$00008000 constant FLASH_SR_OPTVERR                                 \ Option and Engineering bits loading validity error
$00010000 constant FLASH_SR_BSY1                                    \ BSY1
$00020000 constant FLASH_SR_BSY2                                    \ BSY2
$00040000 constant FLASH_SR_CFGBSY                                  \ Programming or erase configuration busy.


\
\ @brief Flash control register
\ Address offset: 0x14
\ Reset value: 0xC0000000
\

$00000001 constant FLASH_CR_PG                                      \ Programming
$00000002 constant FLASH_CR_PER                                     \ Page erase
$00000004 constant FLASH_CR_MER1                                    \ Mass erase
$00001ff8 constant FLASH_CR_PNB                                     \ Page number
$00002000 constant FLASH_CR_BKER                                    \ BKER
$00008000 constant FLASH_CR_MER2                                    \ MER2
$00010000 constant FLASH_CR_STRT                                    \ Start
$00020000 constant FLASH_CR_OPTSTRT                                 \ Options modification start
$00040000 constant FLASH_CR_FSTPG                                   \ Fast programming
$01000000 constant FLASH_CR_EOPIE                                   \ End of operation interrupt enable
$02000000 constant FLASH_CR_ERRIE                                   \ Error interrupt enable
$08000000 constant FLASH_CR_OBL_LAUNCH                              \ Force the option byte loading
$40000000 constant FLASH_CR_OPTLOCK                                 \ Options Lock
$80000000 constant FLASH_CR_LOCK                                    \ FLASH_CR Lock


\
\ @brief Flash ECC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00003fff constant FLASH_ECCR_ADDR_ECC                              \ ECC fail address
$00100000 constant FLASH_ECCR_SYSF_ECC                              \ ECC fail for Corrected ECC Error or Double ECC Error in info block
$01000000 constant FLASH_ECCR_ECCIE                                 \ ECC correction interrupt enable
$40000000 constant FLASH_ECCR_ECCC                                  \ ECC correction
$80000000 constant FLASH_ECCR_ECCD                                  \ ECC detection


\
\ @brief Flash option register
\ Address offset: 0x20
\ Reset value: 0xF0000000
\

$000000ff constant FLASH_OPTR_RDP                                   \ Read protection level
$00002000 constant FLASH_OPTR_NRST_STOP                             \ nRST_STOP
$00004000 constant FLASH_OPTR_NRST_STDBY                            \ nRST_STDBY
$00010000 constant FLASH_OPTR_IDWG_SW                               \ Independent watchdog selection
$00020000 constant FLASH_OPTR_IWDG_STOP                             \ Independent watchdog counter freeze in Stop mode
$00040000 constant FLASH_OPTR_IWDG_STDBY                            \ Independent watchdog counter freeze in Standby mode
$00080000 constant FLASH_OPTR_WWDG_SW                               \ Window watchdog selection
$00100000 constant FLASH_OPTR_NSWAP_BANK                            \ nSWAP_BANK
$00200000 constant FLASH_OPTR_DUAL_BANK                             \ DUAL_BANK
$00400000 constant FLASH_OPTR_RAM_PARITY_CHECK                      \ SRAM parity check control
$01000000 constant FLASH_OPTR_NBOOT_SEL                             \ nBOOT_SEL
$02000000 constant FLASH_OPTR_NBOOT1                                \ Boot configuration
$04000000 constant FLASH_OPTR_NBOOT0                                \ nBOOT0 option bit


\
\ @brief Flash WRP area A address register
\ Address offset: 0x2C
\ Reset value: 0xF0000000
\

$0000007f constant FLASH_WRP1AR_WRP1A_STRT                          \ WRP area A start offset
$007f0000 constant FLASH_WRP1AR_WRP1A_END                           \ WRP area A end offset


\
\ @brief Flash WRP area B address register
\ Address offset: 0x30
\ Reset value: 0xF0000000
\

$0000007f constant FLASH_WRP1BR_WRP1B_STRT                          \ WRP area B start offset
$007f0000 constant FLASH_WRP1BR_WRP1B_END                           \ WRP area B end offset


\
\ @brief FLASH WRP2 area A address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000007f constant FLASH_WRP2AR_WRP2A_STRT                          \ WRP2A_STRT
$007f0000 constant FLASH_WRP2AR_WRP2A_END                           \ WRP2A_END


\
\ @brief FLASH WRP2 area B address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000007f constant FLASH_WRP2BR_WRP2B_STRT                          \ WRP2B_STRT
$007f0000 constant FLASH_WRP2BR_WRP2B_END                           \ WRP2B_END


\
\ @brief Flash
\
$40022000 constant FLASH_ACR      \ offset: 0x00 : Access control register
$40022008 constant FLASH_KEYR     \ offset: 0x08 : Flash key register
$4002200c constant FLASH_OPTKEYR  \ offset: 0x0C : Option byte key register
$40022010 constant FLASH_SR       \ offset: 0x10 : Status register
$40022014 constant FLASH_CR       \ offset: 0x14 : Flash control register
$40022018 constant FLASH_ECCR     \ offset: 0x18 : Flash ECC register
$40022020 constant FLASH_OPTR     \ offset: 0x20 : Flash option register
$4002202c constant FLASH_WRP1AR   \ offset: 0x2C : Flash WRP area A address register
$40022030 constant FLASH_WRP1BR   \ offset: 0x30 : Flash WRP area B address register
$4002204c constant FLASH_WRP2AR   \ offset: 0x4C : FLASH WRP2 area A address register
$40022050 constant FLASH_WRP2BR   \ offset: 0x50 : FLASH WRP2 area B address register

