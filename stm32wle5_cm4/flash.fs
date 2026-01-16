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
$00008000 constant FLASH_ACR_PES                                    \ CPU1 programm erase suspend request
$00010000 constant FLASH_ACR_EMPTY                                  \ Flash User area empty


\
\ @brief Flash key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_KEYR_KEY                                   \ KEY


\
\ @brief Option byte key register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_OPTKEYR_OPTKEY                             \ Option byte key


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
$00002000 constant FLASH_SR_OPTVN                                   \ User Option OPTIVAL indication
$00004000 constant FLASH_SR_RDERR                                   \ PCROP read error
$00008000 constant FLASH_SR_OPTVERR                                 \ Option validity error
$00010000 constant FLASH_SR_BSY                                     \ Busy
$00040000 constant FLASH_SR_CFGBSY                                  \ Programming or erase configuration busy
$00080000 constant FLASH_SR_PESD                                    \ Programming / erase operation suspended


\
\ @brief Flash control register
\ Address offset: 0x14
\ Reset value: 0xC0000000
\

$00000001 constant FLASH_CR_PG                                      \ Programming
$00000002 constant FLASH_CR_PER                                     \ Page erase
$00000004 constant FLASH_CR_MER                                     \ Mass erase
$000003f8 constant FLASH_CR_PNB                                     \ Page number
$00010000 constant FLASH_CR_STRT                                    \ Start
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

$0001ffff constant FLASH_ECCR_ADDR_ECC                              \ ECC fail address
$00100000 constant FLASH_ECCR_SYSF_ECC                              \ System Flash ECC fail
$01000000 constant FLASH_ECCR_ECCCIE                                \ ECC correction interrupt enable
$40000000 constant FLASH_ECCR_ECCC                                  \ ECC correction
$80000000 constant FLASH_ECCR_ECCD                                  \ ECC detection


\
\ @brief Flash option register
\ Address offset: 0x20
\ Reset value: 0x3FFFF0AA
\

$000000ff constant FLASH_OPTR_RDP                                   \ Read protection level
$00000100 constant FLASH_OPTR_ESE                                   \ System security enabled flag
$00000e00 constant FLASH_OPTR_BOR_LEV                               \ BOR reset Level
$00001000 constant FLASH_OPTR_NRST_STOP                             \ nRST_STOP
$00002000 constant FLASH_OPTR_NRST_STDBY                            \ nRST_STDBY
$00004000 constant FLASH_OPTR_NRST_SHDW                             \ nRSTSHDW
$00010000 constant FLASH_OPTR_IWDG_SW                               \ Independent watchdog selection
$00020000 constant FLASH_OPTR_IWDG_STOP                             \ Independent watchdog counter freeze in Stop mode
$00040000 constant FLASH_OPTR_IWDG_STDBY                            \ Independent watchdog counter freeze in Standby mode
$00080000 constant FLASH_OPTR_WWDG_SW                               \ Window watchdog selection
$00800000 constant FLASH_OPTR_NBOOT1                                \ Boot configuration
$01000000 constant FLASH_OPTR_SRAM2_PE                              \ SRAM2 parity check enable
$02000000 constant FLASH_OPTR_SRAM2_RST                             \ SRAM2 Erase when system reset
$04000000 constant FLASH_OPTR_NSWBOOT0                              \ Software BOOT0 selection
$08000000 constant FLASH_OPTR_NBOOT0                                \ nBOOT0 option bit
$40000000 constant FLASH_OPTR_BOOT_LOCK                             \ CPU1 CM4 Unique Boot entry enable option bit


\
\ @brief Flash PCROP zone A Start address register
\ Address offset: 0x24
\ Reset value: 0xFFFFFFFF
\

$000000ff constant FLASH_PCROP1ASR_PCROP1A_STRT                     \ PCROP1A area start offset


\
\ @brief Flash PCROP zone A End address register
\ Address offset: 0x28
\ Reset value: 0xFFFFFF00
\

$000000ff constant FLASH_PCROP1AER_PCROP1A_END                      \ PCROP area end offset
$80000000 constant FLASH_PCROP1AER_PCROP_RDP                        \ PCROP area preserved when RDP level decreased


\
\ @brief Flash WRP area A address register
\ Address offset: 0x2C
\ Reset value: 0xFF80FFFF
\

$0000007f constant FLASH_WRP1AR_WRP1A_STRT                          \ Bank 1 WRP first area start offset
$007f0000 constant FLASH_WRP1AR_WRP1A_END                           \ Bank 1 WRP first area A end offset


\
\ @brief Flash WRP area B address register
\ Address offset: 0x30
\ Reset value: 0xFF80FFFF
\

$0000007f constant FLASH_WRP1BR_WRP1B_STRT                          \ Bank 1 WRP second area B end offset
$007f0000 constant FLASH_WRP1BR_WRP1B_END                           \ Bank 1 WRP second area B start offset


\
\ @brief Flash PCROP zone B Start address register
\ Address offset: 0x34
\ Reset value: 0xFFFFFFFF
\

$000000ff constant FLASH_PCROP1BSR_PCROP1B_STRT                     \ Bank 1 WRP second area B end offset


\
\ @brief Flash PCROP zone B End address register
\ Address offset: 0x38
\ Reset value: 0xFFFFFF00
\

$000000ff constant FLASH_PCROP1BER_PCROP1B_END                      \ PCROP1B area end offset


\
\ @brief Flash
\
$58004000 constant FLASH_ACR      \ offset: 0x00 : Access control register
$58004008 constant FLASH_KEYR     \ offset: 0x08 : Flash key register
$5800400c constant FLASH_OPTKEYR  \ offset: 0x0C : Option byte key register
$58004010 constant FLASH_SR       \ offset: 0x10 : Status register
$58004014 constant FLASH_CR       \ offset: 0x14 : Flash control register
$58004018 constant FLASH_ECCR     \ offset: 0x18 : Flash ECC register
$58004020 constant FLASH_OPTR     \ offset: 0x20 : Flash option register
$58004024 constant FLASH_PCROP1ASR  \ offset: 0x24 : Flash PCROP zone A Start address register
$58004028 constant FLASH_PCROP1AER  \ offset: 0x28 : Flash PCROP zone A End address register
$5800402c constant FLASH_WRP1AR   \ offset: 0x2C : Flash WRP area A address register
$58004030 constant FLASH_WRP1BR   \ offset: 0x30 : Flash WRP area B address register
$58004034 constant FLASH_PCROP1BSR  \ offset: 0x34 : Flash PCROP zone B Start address register
$58004038 constant FLASH_PCROP1BER  \ offset: 0x38 : Flash PCROP zone B End address register

