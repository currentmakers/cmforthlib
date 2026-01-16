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
\ Reset value: 0x00000000
\

$00000001 constant FLASH_ACR_LATENCY                                \ Latency
$00000002 constant FLASH_ACR_PRFTEN                                 \ Prefetch enable
$00000008 constant FLASH_ACR_SLEEP_PD                               \ Flash mode during Sleep
$00000010 constant FLASH_ACR_RUN_PD                                 \ Flash mode during Run
$00000020 constant FLASH_ACR_DISAB_BUF                              \ Disable Buffer
$00000040 constant FLASH_ACR_PRE_READ                               \ Pre-read data address


\
\ @brief Program/erase control register
\ Address offset: 0x04
\ Reset value: 0x00000007
\

$00000001 constant FLASH_PECR_PELOCK                                \ FLASH_PECR and data EEPROM lock
$00000002 constant FLASH_PECR_PRGLOCK                               \ Program memory lock
$00000004 constant FLASH_PECR_OPTLOCK                               \ Option bytes block lock
$00000008 constant FLASH_PECR_PROG                                  \ Program memory selection
$00000010 constant FLASH_PECR_DATA                                  \ Data EEPROM selection
$00000100 constant FLASH_PECR_FIX                                   \ Fixed time data write for Byte, Half Word and Word programming
$00000200 constant FLASH_PECR_ERASE                                 \ Page or Double Word erase mode
$00000400 constant FLASH_PECR_FPRG                                  \ Half Page/Double Word programming mode
$00008000 constant FLASH_PECR_PARALLELBANK                          \ Parallel bank mode
$00010000 constant FLASH_PECR_EOPIE                                 \ End of programming interrupt enable
$00020000 constant FLASH_PECR_ERRIE                                 \ Error interrupt enable
$00040000 constant FLASH_PECR_OBL_LAUNCH                            \ Launch the option byte loading
$00800000 constant FLASH_PECR_NZDISABLE                             \ Non-Zero check notification disable


\
\ @brief Power down key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_PDKEYR_PDKEYR                              \ RUN_PD in FLASH_ACR key


\
\ @brief Program/erase key register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_PEKEYR_PEKEYR                              \ FLASH_PEC and data EEPROM key


\
\ @brief Program memory key register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant FLASH_PRGKEYR_PRGKEYR                            \ Program memory key


\
\ @brief Option byte key register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant FLASH_OPTKEYR_OPTKEYR                            \ Option byte key


\
\ @brief Status register
\ Address offset: 0x18
\ Reset value: 0x00000004
\

$00000001 constant FLASH_SR_BSY                                     \ Write/erase operations in progress
$00000002 constant FLASH_SR_EOP                                     \ End of operation
$00000004 constant FLASH_SR_ENDHV                                   \ End of high voltage
$00000008 constant FLASH_SR_READY                                   \ Flash memory module ready after low power mode
$00000100 constant FLASH_SR_WRPERR                                  \ Write protected error
$00000200 constant FLASH_SR_PGAERR                                  \ Programming alignment error
$00000400 constant FLASH_SR_SIZERR                                  \ Size error
$00000800 constant FLASH_SR_OPTVERR                                 \ Option validity error
$00002000 constant FLASH_SR_RDERR                                   \ RDERR
$00010000 constant FLASH_SR_NOTZEROERR                              \ NOTZEROERR
$00020000 constant FLASH_SR_FWWERR                                  \ FWWERR


\
\ @brief Option byte register
\ Address offset: 0x1C
\ Reset value: 0x00F80000
\

$000000ff constant FLASH_OPTR_RDPROT                                \ Read protection
$00000100 constant FLASH_OPTR_WPRMOD                                \ WPRMOD
$000f0000 constant FLASH_OPTR_BOR_LEV                               \ BOR_LEV
$00100000 constant FLASH_OPTR_WDG_SW                                \ WDG_SW
$00200000 constant FLASH_OPTR_NRST_STOP                             \ nRST_STOP
$00400000 constant FLASH_OPTR_NRST_STDBY                            \ nRST_STDBY
$00800000 constant FLASH_OPTR_BFB2                                  \ BFB2
$80000000 constant FLASH_OPTR_NBOOT1                                \ nBOOT1


\
\ @brief Write protection register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant FLASH_WRPROT1_WRPROT1                            \ Write protection


\
\ @brief Write protection register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_WRPROT2_WRPROT2                            \ Write protection


\
\ @brief Flash
\
$40022000 constant FLASH_ACR      \ offset: 0x00 : Access control register
$40022004 constant FLASH_PECR     \ offset: 0x04 : Program/erase control register
$40022008 constant FLASH_PDKEYR   \ offset: 0x08 : Power down key register
$4002200c constant FLASH_PEKEYR   \ offset: 0x0C : Program/erase key register
$40022010 constant FLASH_PRGKEYR  \ offset: 0x10 : Program memory key register
$40022014 constant FLASH_OPTKEYR  \ offset: 0x14 : Option byte key register
$40022018 constant FLASH_SR       \ offset: 0x18 : Status register
$4002201c constant FLASH_OPTR     \ offset: 0x1C : Option byte register
$40022020 constant FLASH_WRPROT1  \ offset: 0x20 : Write protection register
$40022080 constant FLASH_WRPROT2  \ offset: 0x80 : Write protection register

