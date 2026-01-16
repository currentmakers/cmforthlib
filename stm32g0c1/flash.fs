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
$00040000 constant FLASH_ACR_DBG_SWEN                               \ Debug access software enable


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
$00008000 constant FLASH_SR_OPTVERR                                 \ Option and Engineering bits loading validity error
$00010000 constant FLASH_SR_BSY                                     \ Busy
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
$00002000 constant FLASH_CR_BKER                                    \ Bank selection for erase operation
$00002000 constant FLASH_CR_BKER                                    \ Bank selection for erase operation
$00008000 constant FLASH_CR_MER2                                    \ Mass erase, Bank 2
$00020000 constant FLASH_CR_OPTSTRT                                 \ Options modification start
$00040000 constant FLASH_CR_FSTPG                                   \ Fast programming
$01000000 constant FLASH_CR_EOPIE                                   \ End of operation interrupt enable
$02000000 constant FLASH_CR_ERRIE                                   \ Error interrupt enable
$04000000 constant FLASH_CR_RDERRIE                                 \ PCROP read error interrupt enable
$08000000 constant FLASH_CR_OBL_LAUNCH                              \ Force the option byte loading
$10000000 constant FLASH_CR_SEC_PROT                                \ Securable memory area protection enable
$20000000 constant FLASH_CR_SEC_PROT2                               \ Securable memory area protection enable, Bank 2
$40000000 constant FLASH_CR_OPTLOCK                                 \ Options Lock
$80000000 constant FLASH_CR_LOCK                                    \ FLASH_CR Lock


\
\ @brief Flash ECC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00007fff constant FLASH_ECCR_ADDR_ECC                              \ ECC fail address
$00100000 constant FLASH_ECCR_SYSF_ECC                              \ ECC fail for Corrected ECC Error or Double ECC Error in info block
$01000000 constant FLASH_ECCR_ECCIE                                 \ ECC correction interrupt enable
$40000000 constant FLASH_ECCR_ECCC                                  \ ECC correction
$80000000 constant FLASH_ECCR_ECCD                                  \ ECC detection


\
\ @brief Flash ECC register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00007fff constant FLASH_ECCR2_ADDR_ECC                             \ ECC fail address
$00100000 constant FLASH_ECCR2_SYSF_ECC                             \ ECC fail for Corrected ECC Error or Double ECC Error in info block
$01000000 constant FLASH_ECCR2_ECCIE                                \ ECC correction interrupt enable
$40000000 constant FLASH_ECCR2_ECCC                                 \ ECC correction
$80000000 constant FLASH_ECCR2_ECCD                                 \ ECC detection


\
\ @brief Flash option register
\ Address offset: 0x20
\ Reset value: 0xF0000000
\

$000000ff constant FLASH_OPTR_RDP                                   \ Read protection level
$00000100 constant FLASH_OPTR_BOREN                                 \ BOR reset Level
$00000600 constant FLASH_OPTR_BORF_LEV                              \ These bits contain the VDD supply level threshold that activates the reset
$00001800 constant FLASH_OPTR_BORR_LEV                              \ These bits contain the VDD supply level threshold that releases the reset.
$00002000 constant FLASH_OPTR_NRST_STOP                             \ nRST_STOP
$00004000 constant FLASH_OPTR_NRST_STDBY                            \ nRST_STDBY
$00008000 constant FLASH_OPTR_NRSTS_HDW                             \ nRSTS_HDW
$00010000 constant FLASH_OPTR_IDWG_SW                               \ Independent watchdog selection
$00020000 constant FLASH_OPTR_IWDG_STOP                             \ Independent watchdog counter freeze in Stop mode
$00040000 constant FLASH_OPTR_IWDG_STDBY                            \ Independent watchdog counter freeze in Standby mode
$00080000 constant FLASH_OPTR_WWDG_SW                               \ Window watchdog selection
$00400000 constant FLASH_OPTR_RAM_PARITY_CHECK                      \ SRAM parity check control
$01000000 constant FLASH_OPTR_NBOOT_SEL                             \ nBOOT_SEL
$02000000 constant FLASH_OPTR_NBOOT1                                \ Boot configuration
$04000000 constant FLASH_OPTR_NBOOT0                                \ nBOOT0 option bit
$18000000 constant FLASH_OPTR_NRST_MODE                             \ NRST_MODE
$20000000 constant FLASH_OPTR_IRHEN                                 \ Internal reset holder enable bit


\
\ @brief Flash PCROP zone A Start address register
\ Address offset: 0x24
\ Reset value: 0xF0000000
\

$000000ff constant FLASH_PCROP1ASR_PCROP1A_STRT                     \ PCROP1A area start offset


\
\ @brief Flash PCROP zone A End address register
\ Address offset: 0x28
\ Reset value: 0xF0000000
\

$000000ff constant FLASH_PCROP1AER_PCROP1A_END                      \ PCROP1A area end offset
$80000000 constant FLASH_PCROP1AER_PCROP_RDP                        \ PCROP area preserved when RDP level decreased


\
\ @brief Flash WRP area A address register
\ Address offset: 0x2C
\ Reset value: 0xF0000000
\

$0000003f constant FLASH_WRP1AR_WRP1A_STRT                          \ WRP area A start offset
$003f0000 constant FLASH_WRP1AR_WRP1A_END                           \ WRP area A end offset


\
\ @brief Flash WRP area B address register
\ Address offset: 0x30
\ Reset value: 0xF0000000
\

$0000003f constant FLASH_WRP1BR_WRP1B_STRT                          \ WRP area B start offset
$003f0000 constant FLASH_WRP1BR_WRP1B_END                           \ WRP area B end offset


\
\ @brief Flash PCROP zone B Start address register
\ Address offset: 0x34
\ Reset value: 0xF0000000
\

$000000ff constant FLASH_PCROP1BSR_PCROP1B_STRT                     \ PCROP1B area start offset


\
\ @brief Flash PCROP area B End address register
\ Address offset: 0x38
\ Reset value: 0xF0000000
\

$000001ff constant FLASH_PCROP1BER_PCROP1B_END                      \ PCROP1B area end offset


\
\ @brief Flash PCROP2 area A start address register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000001ff constant FLASH_PCROP2ASR_PCROP2A_STRT                     \ PCROP2A area start offset, bank2


\
\ @brief Flash PCROP2 area A end address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000001ff constant FLASH_PCROP2AER_PCROP2A_END                      \ PCROP2A area end offset, bank2


\
\ @brief Flash WRP2 area A address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000007f constant FLASH_WRP2AR_WRP2A_STRT                          \ WRP area A start offset, Bank 2
$007f0000 constant FLASH_WRP2AR_WRP2A_END                           \ WRP area A end offset, Bank 2


\
\ @brief Flash WRP2 area B address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000007f constant FLASH_WRP2BR_WRP2B_STRT                          \ WRP area B start offset, Bank 2
$007f0000 constant FLASH_WRP2BR_WRP2B_END                           \ WRP area B end offset, Bank 2


\
\ @brief FLASH PCROP2 area B start address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000001ff constant FLASH_PCROP2BSR_PCROP2B_STRT                     \ PCROP2B area start offset, Bank 2


\
\ @brief FLASH PCROP2 area B end address register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$000001ff constant FLASH_PCROP2BER_PCROP2B_END                      \ PCROP2B area end offset, Bank 2


\
\ @brief Flash Security register
\ Address offset: 0x80
\ Reset value: 0xF0000000
\

$000000ff constant FLASH_SECR_SEC_SIZE                              \ Securable memory area size
$00010000 constant FLASH_SECR_BOOT_LOCK                             \ used to force boot from user area
$0ff00000 constant FLASH_SECR_SEC_SIZE2                             \ Securable memory area size


\
\ @brief Flash
\
$40022000 constant FLASH_ACR      \ offset: 0x00 : Access control register
$40022008 constant FLASH_KEYR     \ offset: 0x08 : Flash key register
$4002200c constant FLASH_OPTKEYR  \ offset: 0x0C : Option byte key register
$40022010 constant FLASH_SR       \ offset: 0x10 : Status register
$40022014 constant FLASH_CR       \ offset: 0x14 : Flash control register
$40022018 constant FLASH_ECCR     \ offset: 0x18 : Flash ECC register
$4002201c constant FLASH_ECCR2    \ offset: 0x1C : Flash ECC register 2
$40022020 constant FLASH_OPTR     \ offset: 0x20 : Flash option register
$40022024 constant FLASH_PCROP1ASR  \ offset: 0x24 : Flash PCROP zone A Start address register
$40022028 constant FLASH_PCROP1AER  \ offset: 0x28 : Flash PCROP zone A End address register
$4002202c constant FLASH_WRP1AR   \ offset: 0x2C : Flash WRP area A address register
$40022030 constant FLASH_WRP1BR   \ offset: 0x30 : Flash WRP area B address register
$40022034 constant FLASH_PCROP1BSR  \ offset: 0x34 : Flash PCROP zone B Start address register
$40022038 constant FLASH_PCROP1BER  \ offset: 0x38 : Flash PCROP area B End address register
$40022044 constant FLASH_PCROP2ASR  \ offset: 0x44 : Flash PCROP2 area A start address register
$40022048 constant FLASH_PCROP2AER  \ offset: 0x48 : Flash PCROP2 area A end address register
$4002204c constant FLASH_WRP2AR   \ offset: 0x4C : Flash WRP2 area A address register
$40022050 constant FLASH_WRP2BR   \ offset: 0x50 : Flash WRP2 area B address register
$40022054 constant FLASH_PCROP2BSR  \ offset: 0x54 : FLASH PCROP2 area B start address register
$40022058 constant FLASH_PCROP2BER  \ offset: 0x58 : FLASH PCROP2 area B end address register
$40022080 constant FLASH_SECR     \ offset: 0x80 : Flash Security register

