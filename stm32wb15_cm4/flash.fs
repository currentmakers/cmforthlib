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
$00008000 constant FLASH_ACR_PES                                    \ CPU1 CortexM4 program erase suspend request
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
$00002000 constant FLASH_SR_OPTNV                                   \ User Option OPTVAL indication
$00004000 constant FLASH_SR_RDERR                                   \ PCROP read error
$00008000 constant FLASH_SR_OPTVERR                                 \ Option validity error
$00010000 constant FLASH_SR_BSY                                     \ Busy
$00040000 constant FLASH_SR_CFGBSY                                  \ Programming or erase configuration busy
$00080000 constant FLASH_SR_PESD                                    \ Programming or erase operation suspended


\
\ @brief Flash control register
\ Address offset: 0x14
\ Reset value: 0xC0000000
\

$00000001 constant FLASH_CR_PG                                      \ Programming
$00000002 constant FLASH_CR_PER                                     \ Page erase
$00000004 constant FLASH_CR_MER                                     \ This bit triggers the mass erase (all user pages) when set
$000007f8 constant FLASH_CR_PNB                                     \ Page number selection
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
$1c000000 constant FLASH_ECCR_CPUID                                 \ CPU identification
$40000000 constant FLASH_ECCR_ECCC                                  \ ECC correction
$80000000 constant FLASH_ECCR_ECCD                                  \ ECC detection


\
\ @brief Flash option register
\ Address offset: 0x20
\ Reset value: 0x10708000
\

$000000ff constant FLASH_OPTR_RDP                                   \ Read protection level
$00000100 constant FLASH_OPTR_ESE                                   \ Security enabled
$00000e00 constant FLASH_OPTR_BOR_LEV                               \ BOR reset Level
$00001000 constant FLASH_OPTR_NRST_STOP                             \ nRST_STOP
$00002000 constant FLASH_OPTR_NRST_STDBY                            \ nRST_STDBY
$00004000 constant FLASH_OPTR_NRST_SHDW                             \ nRST_SHDW
$00010000 constant FLASH_OPTR_IDWG_SW                               \ Independent watchdog selection
$00020000 constant FLASH_OPTR_IWDG_STOP                             \ Independent watchdog counter freeze in Stop mode
$00040000 constant FLASH_OPTR_IWDG_STDBY                            \ Independent watchdog counter freeze in Standby mode
$00080000 constant FLASH_OPTR_WWDG_SW                               \ Window watchdog selection
$00800000 constant FLASH_OPTR_NBOOT1                                \ Boot configuration
$01000000 constant FLASH_OPTR_SRAM2_PE                              \ SRAM2 parity check enable
$02000000 constant FLASH_OPTR_SRAM2_RST                             \ SRAM2 Erase when system reset
$04000000 constant FLASH_OPTR_NSWBOOT0                              \ Software Boot0
$08000000 constant FLASH_OPTR_NBOOT0                                \ nBoot0 option bit
$e0000000 constant FLASH_OPTR_AGC_TRIM                              \ Radio Automatic Gain Control Trimming


\
\ @brief Flash Bank 1 PCROP Start address zone A register
\ Address offset: 0x24
\ Reset value: 0xFFFFFE00
\

$000001ff constant FLASH_PCROP1ASR_PCROP1A_STRT                     \ Bank 1 PCROPQ area start offset


\
\ @brief Flash Bank 1 PCROP End address zone A register
\ Address offset: 0x28
\ Reset value: 0x7FFFFE00
\

$000001ff constant FLASH_PCROP1AER_PCROP1A_END                      \ Bank 1 PCROP area end offset
$80000000 constant FLASH_PCROP1AER_PCROP_RDP                        \ PCROP area preserved when RDP level decreased


\
\ @brief Flash Bank 1 WRP area A address register
\ Address offset: 0x2C
\ Reset value: 0xFF00FF00
\

$000000ff constant FLASH_WRP1AR_WRP1A_STRT                          \ Bank 1 WRP first area A start offset
$00ff0000 constant FLASH_WRP1AR_WRP1A_END                           \ Bank 1 WRP first area A end offset


\
\ @brief Flash Bank 1 WRP area B address register
\ Address offset: 0x30
\ Reset value: 0xFF00FF00
\

$000000ff constant FLASH_WRP1BR_WRP1B_END                           \ Bank 1 WRP second area B start offset
$00ff0000 constant FLASH_WRP1BR_WRP1B_STRT                          \ Bank 1 WRP second area B end offset


\
\ @brief Flash Bank 1 PCROP Start address area B register
\ Address offset: 0x34
\ Reset value: 0xFFFFFE00
\

$000001ff constant FLASH_PCROP1BSR_PCROP1B_STRT                     \ Bank 1 PCROP area B start offset


\
\ @brief Flash Bank 1 PCROP End address area B register
\ Address offset: 0x38
\ Reset value: 0xFFFFFE00
\

$000001ff constant FLASH_PCROP1BER_PCROP1B_END                      \ Bank 1 PCROP area end area B offset


\
\ @brief IPCC mailbox data buffer address register
\ Address offset: 0x3C
\ Reset value: 0xFFFFC000
\

$00003fff constant FLASH_IPCCBR_IPCCDBA                             \ PCC mailbox data buffer base address


\
\ @brief CPU2 cortex M0 access control register
\ Address offset: 0x5C
\ Reset value: 0x00000600
\

$00000100 constant FLASH_C2ACR_PRFTEN                               \ CPU2 cortex M0 prefetch enable
$00000200 constant FLASH_C2ACR_ICEN                                 \ CPU2 cortex M0 instruction cache enable
$00000800 constant FLASH_C2ACR_ICRST                                \ CPU2 cortex M0 instruction cache reset
$00008000 constant FLASH_C2ACR_PES                                  \ CPU2 cortex M0 program erase suspend request


\
\ @brief CPU2 cortex M0 status register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant FLASH_C2SR_EOP                                   \ End of operation
$00000002 constant FLASH_C2SR_OPERR                                 \ Operation error
$00000008 constant FLASH_C2SR_PROGERR                               \ Programming error
$00000010 constant FLASH_C2SR_WRPERR                                \ write protection error
$00000020 constant FLASH_C2SR_PGAERR                                \ Programming alignment error
$00000040 constant FLASH_C2SR_SIZERR                                \ Size error
$00000080 constant FLASH_C2SR_PGSERR                                \ Programming sequence error
$00000100 constant FLASH_C2SR_MISSERR                               \ Fast programming data miss error
$00000200 constant FLASH_C2SR_FASTERR                               \ Fast programming error
$00004000 constant FLASH_C2SR_RDERR                                 \ PCROP read error
$00010000 constant FLASH_C2SR_BSY                                   \ Busy
$00040000 constant FLASH_C2SR_CFGBSY                                \ Programming or erase configuration busy
$00080000 constant FLASH_C2SR_PESD                                  \ Programming or erase operation suspended


\
\ @brief CPU2 cortex M0 control register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant FLASH_C2CR_PG                                    \ Programming
$00000002 constant FLASH_C2CR_PER                                   \ Page erase
$00000004 constant FLASH_C2CR_MER                                   \ Masse erase
$000007f8 constant FLASH_C2CR_PNB                                   \ Page Number selection
$00010000 constant FLASH_C2CR_STRT                                  \ Start
$00040000 constant FLASH_C2CR_FSTPG                                 \ Fast programming
$01000000 constant FLASH_C2CR_EOPIE                                 \ End of operation interrupt enable
$02000000 constant FLASH_C2CR_ERRIE                                 \ Error interrupt enable
$04000000 constant FLASH_C2CR_RDERRIE                               \ PCROP read error interrupt enable


\
\ @brief Secure flash start address register
\ Address offset: 0x80
\ Reset value: 0xFFFFEE00
\

$000000ff constant FLASH_SFR_SFSA                                   \ Secure flash start address
$00000100 constant FLASH_SFR_FSD                                    \ Flash security disable
$00001000 constant FLASH_SFR_DDS                                    \ Disable Cortex M0 debug access


\
\ @brief Secure SRAM2 start address and cortex M0 reset vector register
\ Address offset: 0x84
\ Reset value: 0x01000000
\

$0001ffff constant FLASH_SRRVR_SBRV                                 \ cortex M0 access control register
$007c0000 constant FLASH_SRRVR_SBRSA                                \ Secure backup SRAM2a start address
$00800000 constant FLASH_SRRVR_BRSD                                 \ backup SRAM2a security disable
$3e000000 constant FLASH_SRRVR_SNBRSA                               \ Secure non backup SRAM2a start address
$40000000 constant FLASH_SRRVR_NBRSD                                \ non-backup SRAM2b security disable
$80000000 constant FLASH_SRRVR_C2OPT                                \ CPU2 cortex M0 boot reset vector memory selection


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
$58004024 constant FLASH_PCROP1ASR  \ offset: 0x24 : Flash Bank 1 PCROP Start address zone A register
$58004028 constant FLASH_PCROP1AER  \ offset: 0x28 : Flash Bank 1 PCROP End address zone A register
$5800402c constant FLASH_WRP1AR   \ offset: 0x2C : Flash Bank 1 WRP area A address register
$58004030 constant FLASH_WRP1BR   \ offset: 0x30 : Flash Bank 1 WRP area B address register
$58004034 constant FLASH_PCROP1BSR  \ offset: 0x34 : Flash Bank 1 PCROP Start address area B register
$58004038 constant FLASH_PCROP1BER  \ offset: 0x38 : Flash Bank 1 PCROP End address area B register
$5800403c constant FLASH_IPCCBR   \ offset: 0x3C : IPCC mailbox data buffer address register
$5800405c constant FLASH_C2ACR    \ offset: 0x5C : CPU2 cortex M0 access control register
$58004060 constant FLASH_C2SR     \ offset: 0x60 : CPU2 cortex M0 status register
$58004064 constant FLASH_C2CR     \ offset: 0x64 : CPU2 cortex M0 control register
$58004080 constant FLASH_SFR      \ offset: 0x80 : Secure flash start address register
$58004084 constant FLASH_SRRVR    \ offset: 0x84 : Secure SRAM2 start address and cortex M0 reset vector register

