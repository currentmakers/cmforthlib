\
\ @file flash.fs
\ @brief Mamba FLASH register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FLASH access control register
\ Address offset: 0x00
\ Reset value: 0x00040600
\

$00000007 constant FLASH_FLASH_ACR_LATENCY                          \ Flash memory access latency The value in this bitfield represents the number of CPU wait states when accessing the flash memory. Other: Reserved A new write into the bitfield becomes effective when it returns the same value upon read.
$00000100 constant FLASH_FLASH_ACR_PRFTEN                           \ CPU Prefetch enable
$00000200 constant FLASH_FLASH_ACR_ICEN                             \ CPU Instruction cache enable
$00000800 constant FLASH_FLASH_ACR_ICRST                            \ CPU Instruction cache reset This bit can be written only when the instruction cache is disabled.
$00010000 constant FLASH_FLASH_ACR_EMPTY                            \ Main flash memory area empty This bit indicates whether the first location of the main flash memory area is erased or has a programmed value. The bit can be set and reset by software.
$00040000 constant FLASH_FLASH_ACR_DBG_SWEN                         \ Debug access software enable Software may use this bit to enable/disable the debugger read access.


\
\ @brief FLASH key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_KEYR_KEY                             \ FLASH key The following values must be written consecutively to unlock the FLASH control register (FLASH_CR), thus enabling programming/erasing operations: KEY1: 0x4567 0123 KEY2: 0xCDEF 89AB


\
\ @brief FLASH option key register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OPTKEYR_OPTKEY                       \ Option byte key The following values must be written consecutively to unlock the flash memory option registers, enabling option byte programming/erasing operations: KEY1: 0x0819 2A3B KEY2: 0x4C5D 6E7F


\
\ @brief FLASH status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SR_EOP                               \ End of operation Set by hardware when one or more flash memory operation (programming / erase) has been completed successfully. This bit is set only if the end of operation interrupts are enabled (EOPIE=1). Cleared by writing 1.
$00000002 constant FLASH_FLASH_SR_OPERR                             \ Operation error Set by hardware when a flash memory operation (program / erase) completes unsuccessfully. This bit is set only if error interrupts are enabled (ERRIE=1). Cleared by writing 1.
$00000008 constant FLASH_FLASH_SR_PROGERR                           \ Programming error Set by hardware when a double-word address to be programmed contains a value different from '0xFFFF FFFF' before programming, except if the data to write is '0x0000 0000'. Cleared by writing 1.
$00000010 constant FLASH_FLASH_SR_WRPERR                            \ Write protection error Set by hardware when an address to be erased/programmed belongs to a write-protected part (by WRP, PCROP or RDP Level 1) of the flash memory. Cleared by writing 1.
$00000020 constant FLASH_FLASH_SR_PGAERR                            \ Programming alignment error Set by hardware when the data to program cannot be contained in the same double word (64-bit) flash memory in case of standard programming, or if there is a change of page during fast programming. Cleared by writing 1.
$00000040 constant FLASH_FLASH_SR_SIZERR                            \ Size error Set by hardware when the size of the access is a byte or half-word during a program or a fast program sequence. Only double word programming is allowed (consequently: word access). Cleared by writing 1.
$00000080 constant FLASH_FLASH_SR_PGSERR                            \ Programming sequence error Set by hardware when a write access to the flash memory is performed by the code while PG or FSTPG have not been set previously. Set also by hardware when PROGERR, SIZERR, PGAERR, WRPERR, MISSERR or FASTERR is set due to a previous programming error. Cleared by writing 1.
$00000100 constant FLASH_FLASH_SR_MISSERR                           \ Fast programming data miss error In Fast programming mode, 16 double words (128 bytes) must be sent to flash memory successively, and the new data must be sent to the logic control before the current data is fully programmed. MISSERR is set by hardware when the new data is not present in time. Cleared by writing 1.
$00000200 constant FLASH_FLASH_SR_FASTERR                           \ Fast programming error Set by hardware when a fast programming sequence (activated by FSTPG) is interrupted due to an error (alignment, size, write protection or data miss). The corresponding status bit (PGAERR, SIZERR, WRPERR or MISSERR) is set at the same time. Cleared by writing 1.
$00004000 constant FLASH_FLASH_SR_RDERR                             \ PCROP read error Set by hardware when an address to be read belongs to a read protected area of the flash memory (PCROP protection). An interrupt is generated if RDERRIE is set in FLASH_CR. Cleared by writing 1.
$00008000 constant FLASH_FLASH_SR_OPTVERR                           \ Option and Engineering bits loading validity error
$00010000 constant FLASH_FLASH_SR_BSY1                              \ Busy This flag indicates that a flash memory operation requested by FLASH control register (FLASH_CR) is in progress. This bit is set at the beginning of the flash memory operation, and cleared when the operation finishes or when an error occurs.
$00040000 constant FLASH_FLASH_SR_CFGBSY                            \ Programming or erase configuration busy. This flag is set and cleared by hardware. It is set when the first word is sent for program or when setting the STRT bit of FLASH control register (FLASH_CR) for erase. It is cleared when the flash memory program or erase operation completes or ends with an error. When set, launching any other operation through the FLASH control register (FLASH_CR) is impossible, and must be postponed (a programming or erase operation is ongoing). When cleared, the program and erase settings in the FLASH control register (FLASH_CR) can be modified.


\
\ @brief FLASH control register
\ Address offset: 0x14
\ Reset value: 0xC0000000
\

$00000001 constant FLASH_FLASH_CR_PG                                \ Flash memory programming enable
$00000002 constant FLASH_FLASH_CR_PER                               \ Page erase enable
$00000004 constant FLASH_FLASH_CR_MER1                              \ Mass erase When set, this bit triggers the mass erase, that is, all user pages.
$000003f8 constant FLASH_FLASH_CR_PNB                               \ Page number selection These bits select the page to erase: ... Note: Values corresponding to addresses outside the main memory are not allowed.
$00010000 constant FLASH_FLASH_CR_STRT                              \ Start erase operation This bit triggers an erase operation when set. This bit is possible to set only by software and to clear only by hardware. The hardware clears it when one of BSY1 and BSY2 flags in the FLASH_SR register transits to zero.
$00020000 constant FLASH_FLASH_CR_OPTSTRT                           \ Start of modification of option bytes This bit triggers an options operation when set. This bit is set only by software, and is cleared when the BSY1 bit is cleared in FLASH_SR.
$00040000 constant FLASH_FLASH_CR_FSTPG                             \ Fast programming enable
$01000000 constant FLASH_FLASH_CR_EOPIE                             \ End-of-operation interrupt enable This bit enables the interrupt generation upon setting the EOP flag in the FLASH_SR register.
$02000000 constant FLASH_FLASH_CR_ERRIE                             \ Error interrupt enable This bit enables the interrupt generation upon setting the OPERR flag in the FLASH_SR register.
$04000000 constant FLASH_FLASH_CR_RDERRIE                           \ PCROP read error interrupt enable This bit enables the interrupt generation upon setting the RDERR flag in the FLASH_SR register.
$08000000 constant FLASH_FLASH_CR_OBL_LAUNCH                        \ Option byte load launch When set, this bit triggers the load of option bytes into option registers. It is automatically cleared upon the completion of the load. The high state of the bit indicates pending option byte load. The bit cannot be cleared by software. It cannot be written as long as OPTLOCK is set.
$10000000 constant FLASH_FLASH_CR_SEC_PROT                          \ Securable memory area protection enable This bit enables the protection on securable area, provided that a non-null securable memory area size (SEC_SIZE[4:0]) is defined in option bytes. This bit is possible to set only by software and to clear only through a system reset.
$40000000 constant FLASH_FLASH_CR_OPTLOCK                           \ Options Lock This bit is set only. When set, all bits concerning user option in FLASH_CR register and so option page are locked. This bit is cleared by hardware after detecting the unlock sequence. The LOCK bit must be cleared before doing the unlock sequence for OPTLOCK bit. In case of an unsuccessful unlock operation, this bit remains set until the next reset.
$80000000 constant FLASH_FLASH_CR_LOCK                              \ FLASH_CR Lock This bit is set only. When set, the FLASH_CR register is locked. It is cleared by hardware after detecting the unlock sequence. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.


\
\ @brief FLASH ECC register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00003fff constant FLASH_FLASH_ECCR_ADDR_ECC                        \ ECC fail double-word address offset In case of ECC error or ECC correction detected, this bitfield contains double-word offset (multiple of 64 bits) to main Flash memory.
$00100000 constant FLASH_FLASH_ECCR_SYSF_ECC                        \ System Flash memory ECC fail This bit indicates that the ECC error correction or double ECC error detection is located in the system Flash memory.
$01000000 constant FLASH_FLASH_ECCR_ECCCIE                          \ ECC correction interrupt enable
$40000000 constant FLASH_FLASH_ECCR_ECCC                            \ ECC correction Set by hardware when one ECC error has been detected and corrected. An interrupt is generated if ECCIE is set. Cleared by writing 1.
$80000000 constant FLASH_FLASH_ECCR_ECCD                            \ ECC detection Set by hardware when two ECC errors have been detected. When this bit is set, a NMI is generated. Cleared by writing 1.


\
\ @brief FLASH option register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_OPTR_RDP                             \ Read protection level Other: Level 1, memories read protection active
$00000700 constant FLASH_FLASH_OPTR_BORR_LEV                        \ BOR reset level
$00002000 constant FLASH_FLASH_OPTR_NRST_STOP                       \ Reset generated when entering Stop mode
$00004000 constant FLASH_FLASH_OPTR_NRST_STDBY                      \ Reset generated when entering Standby mode
$00008000 constant FLASH_FLASH_OPTR_NRST_SHDW                       \ Reset generated when entering Shutdown mode
$00010000 constant FLASH_FLASH_OPTR_IWDG_SW                         \ Independent watchdog selection
$00020000 constant FLASH_FLASH_OPTR_IWDG_STOP                       \ Independent watchdog counter freeze in Stop mode
$00040000 constant FLASH_FLASH_OPTR_IWDG_STDBY                      \ Independent watchdog counter freeze in Standby mode
$00080000 constant FLASH_FLASH_OPTR_WWDG_SW                         \ Window watchdog selection
$00200000 constant FLASH_FLASH_OPTR_BDRST                           \ Backup domain reset
$00400000 constant FLASH_FLASH_OPTR_RAM_PARITY_CHECK                \ SRAM parity check control enable/disable
$00800000 constant FLASH_FLASH_OPTR_BKPSRAM_HW_ERASE_DISABLE        \ Backup SRAM erase prevention
$01000000 constant FLASH_FLASH_OPTR_NBOOT_SEL                       \ BOOT0 signal source selection This option bit defines the source of the BOOT0 signal.
$02000000 constant FLASH_FLASH_OPTR_NBOOT1                          \ Boot configuration Together with the BOOT0 pin or option bit NBOOT0 (depending on NBOOT_SEL option bit configuration), this bit selects boot mode from the main flash memory, SRAM or the system memory. Refer to Section12.5: Boot configuration.
$04000000 constant FLASH_FLASH_OPTR_NBOOT0                          \ NBOOT0 option bit
$18000000 constant FLASH_FLASH_OPTR_NRST_MODE                       \ NRST pin configuration
$20000000 constant FLASH_FLASH_OPTR_IRHEN                           \ Internal reset holder enable bit


\
\ @brief FLASH WRP area A address register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_WRP1AR_WRP1A_STRT                    \ WRP area A start offset This bitfield contains the offset of the first page of the WRP area A. Note: The number of effective bits depends on the size of the flash memory in the device.
$007f0000 constant FLASH_FLASH_WRP1AR_WRP1A_END                     \ WRP area A end offset This bitfield contains the offset of the last page of the WRP area A. Note: The number of effective bits depends on the size of the flash memory in the device.


\
\ @brief FLASH WRP area B address register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_WRP1BR_WRP1B_STRT                    \ WRP area B start offset This bitfield contains the offset of the first page of the WRP area B. Note: The number of effective bits depends on the size of the flash memory in the device.
$007f0000 constant FLASH_FLASH_WRP1BR_WRP1B_END                     \ WRP area B end offset This bitfield contains the offset of the last page of the WRP area B. Note: The number of effective bits depends on the size of the flash memory in the device.


\
\ @brief FLASH security register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_SECR_HDP1_PEND                       \ Last page of the first hide protection area
$00010000 constant FLASH_FLASH_SECR_BOOT_LOCK                       \ used to force boot from user area If the bit is set in association with RDP level 1, the debug capabilities are disabled, except in the case of a bad OBL (mismatch).
$ff000000 constant FLASH_FLASH_SECR_HDP1EN                          \ Hide protection area enable


\
\ @brief Mamba FLASH register block
\
$40022000 constant FLASH_FLASH_ACR  \ offset: 0x00 : FLASH access control register
$40022008 constant FLASH_FLASH_KEYR  \ offset: 0x08 : FLASH key register
$4002200c constant FLASH_FLASH_OPTKEYR  \ offset: 0x0C : FLASH option key register
$40022010 constant FLASH_FLASH_SR  \ offset: 0x10 : FLASH status register
$40022014 constant FLASH_FLASH_CR  \ offset: 0x14 : FLASH control register
$40022018 constant FLASH_FLASH_ECCR  \ offset: 0x18 : FLASH ECC register
$40022020 constant FLASH_FLASH_OPTR  \ offset: 0x20 : FLASH option register
$4002202c constant FLASH_FLASH_WRP1AR  \ offset: 0x2C : FLASH WRP area A address register
$40022030 constant FLASH_FLASH_WRP1BR  \ offset: 0x30 : FLASH WRP area B address register
$40022080 constant FLASH_FLASH_SECR  \ offset: 0x80 : FLASH security register

