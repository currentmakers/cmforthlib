\
\ @file flash.fs
\ @brief Spider_FLASH register block
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
$00010000 constant FLASH_FLASH_ACR_EMPTY                            \ Main flash memory area empty This bit indicates whether the first location of the Main flash memory area was read as erased or as programmed during OBL. It is not affected by the system reset. Software may need to change this bit value after a flash memory program or erase operation. The bit can be set and reset by software.
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
$00000002 constant FLASH_FLASH_SR_OPERR                             \ Operation error Set by hardware when a flash memory operation (program / erase) completes unsuccessfully. This bit is set only if error interrupts are enabled (ERRIE=1). Cleared by writing 1 .
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
$00040000 constant FLASH_FLASH_SR_CFGBSY                            \ Programming or erase configuration busy. This flag is set and reset by hardware. For flash program operation, it is set when the first word is sent, and cleared after the second word is sent when the operation completes or ends with an error. For flash erase operation, it is set when setting the STRT bit of the FLASH_CR register and cleared when the operation completes or ends with an error. When set, a programming or erase operation is ongoing and the corresponding settings in the FLASH control register (FLASH_CR) are used (busy) and cannot be changed. Any other flash operation launch must be postponed. When cleared, the programming and erase settings in the FLASH control register (FLASH_CR) can be modified. Note: The CFGBSY bit is also set when attempting to write locked flash memory (with the first byte sent). When the CFGBSY bit is set, writing into the FLASH_CR register causes HardFault.To clear the CFGBSY bit, send a double word to the flash memory and wait until the access is finished (otherwise the CFGBSY bit remains set).


\
\ @brief FLASH control register
\ Address offset: 0x14
\ Reset value: 0xC0000000
\

$00000001 constant FLASH_FLASH_CR_PG                                \ Flash memory programming enable
$00000002 constant FLASH_FLASH_CR_PER                               \ Page erase enable
$00000004 constant FLASH_FLASH_CR_MER1                              \ Mass erase When set, this bit triggers the mass erase, that is, all user pages.
$000001f8 constant FLASH_FLASH_CR_PNB                               \ Page number selection These bits select the page to erase: ... Note: Values corresponding to addresses outside the Main memory are not allowed. See Table 6 and Table 7.
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
\ @brief FLASH option register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_OPTR_RDP                             \ Read protection level Other: Level 1, memories read protection active
$00000100 constant FLASH_FLASH_OPTR_BOR_EN                          \ Brown out reset enable
$00000600 constant FLASH_FLASH_OPTR_BORR_LEV                        \ BOR threshold at rising V<sub>DD</sub> supply Rising V<sub>DD</sub> crossings this threshold releases the reset signal.
$00001800 constant FLASH_FLASH_OPTR_BORF_LEV                        \ BOR threshold at falling V<sub>DD</sub> supply Falling V<sub>DD</sub> crossings this threshold activates the reset signal.
$00002000 constant FLASH_FLASH_OPTR_NRST_STOP                       \ None
$00004000 constant FLASH_FLASH_OPTR_NRST_STDBY                      \ None
$00008000 constant FLASH_FLASH_OPTR_NRST_SHDW                       \ None
$00010000 constant FLASH_FLASH_OPTR_IWDG_SW                         \ None
$00020000 constant FLASH_FLASH_OPTR_IWDG_STOP                       \ Independent watchdog counter freeze in Stop mode
$00040000 constant FLASH_FLASH_OPTR_IWGD_STDBY                      \ None
$00080000 constant FLASH_FLASH_OPTR_WWDG_SW                         \ Window watchdog selection
$00200000 constant FLASH_FLASH_OPTR_HSE_NOT_REMAPPED                \ HSE remapping enable/disable When cleared, the bit remaps the HSE clock source from PF0-OSC_IN/PF1-OSC_OUT pins to PC14-OSCX_IN/PC15-OSCX_OUT. Thus PC14-OSCX_IN/PC15-OSCX_OUT are shared by both LSE and HSE and the two clock sources cannot be use simultaneously. On packages with less than 48 pins, the remapping is always enabled (PF0-OSC_IN/PF1-OSC_OUT are not available), regardless of this bit. As all STM32C011xx packages have less than 48 pins, this bit is only applicable to STM32C031xx. Note: On 48 pins packages, when HSE_NOT_REMAPPED is reset, HSE cannot be used in bypass mode. Refer to product errata sheet for more details.
$00400000 constant FLASH_FLASH_OPTR_RAM_PARITY_CHECK                \ SRAM parity check control enable/disable
$00800000 constant FLASH_FLASH_OPTR_SECURE_MUXING_EN                \ Multiple-bonding security The bit allows enabling automatic I/O configuration to prevent conflicts on I/Os connected (bonded) onto the same pin. If the software sets one of the I/Os connected to the same pin as active by configuring the SYSCFG_CFGR3 register, enabling this bit automatically forces the other I/Os in digital input mode, regardless of their software configuration. When the bit is disabled, the SYSCFG_CFGR3 register setting is ignored, all GPIOs linked to a given pin are active and can be set in the mode specified by the corresponding GPIOx_MODER register. The user software must ensure that there is no conflict between GPIOs.
$01000000 constant FLASH_FLASH_OPTR_NBOOT_SEL                       \ BOOT0 signal source selection This option bit defines the source of the BOOT0 signal.
$02000000 constant FLASH_FLASH_OPTR_NBOOT1                          \ Boot configuration Together with the BOOT0 pin or option bit nBOOT0 (depending on nBOOT_SEL option bit configuration), this bit selects boot mode from the Main flash memory, SRAM or the System memory. Refer to Section 3: Boot configuration.
$04000000 constant FLASH_FLASH_OPTR_NBOOT0                          \ nBOOT0 option bit
$18000000 constant FLASH_FLASH_OPTR_NRST_MODE                       \ NRST pin configuration
$20000000 constant FLASH_FLASH_OPTR_IRHEN                           \ Internal reset holder enable bit


\
\ @brief FLASH PCROP area A start address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_PCROP1ASR_PCROP1A_STRT               \ PCROP1A area start offset Contains the offset of the first subpage of the PCROP1A area. Note: The number of effective bits depends on the size of the flash memory in the device.


\
\ @brief FLASH PCROP area A end address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_PCROP1AER_PCROP1A_END                \ PCROP1A area end offset Contains the offset of the last subpage of the PCROP1A area. Note: The number of effective bits depends on the size of the flash memory in the device.
$80000000 constant FLASH_FLASH_PCROP1AER_PCROP_RDP                  \ PCROP area erase upon RDP level regression This bit determines whether the PCROP area (and the totality of the PCROP area boundary pages) is erased by the mass erase triggered by the RDP level regression from Level 1 to Level 0: The software can only set this bit. It is automatically reset upon mass erase following the RDP regression from Level 1 to Level 0.


\
\ @brief FLASH WRP area A address register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000003f constant FLASH_FLASH_WRP1AR_WRP1A_STRT                    \ WRP area A start offset This bitfield contains the offset of the first page of the WRP area A. Note: The number of effective bits depends on the size of the flash memory in the device.
$003f0000 constant FLASH_FLASH_WRP1AR_WRP1A_END                     \ WRP area A end offset This bitfield contains the offset of the last page of the WRP area A. Note: The number of effective bits depends on the size of the flash memory in the device.


\
\ @brief FLASH WRP area B address register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000003f constant FLASH_FLASH_WRP1BR_WRP1B_STRT                    \ WRP area B start offset This bitfield contains the offset of the first page of the WRP area B. Note: The number of effective bits depends on the size of the flash memory in the device.
$003f0000 constant FLASH_FLASH_WRP1BR_WRP1B_END                     \ WRP area B end offset This bitfield contains the offset of the last page of the WRP area B. Note: The number of effective bits depends on the size of the flash memory in the device.


\
\ @brief FLASH PCROP area B start address register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_PCROP1BSR_PCROP1B_STRT               \ PCROP1B area start offset Contains the offset of the first subpage of the PCROP1B area. Note: The number of effective bits depends on the size of the flash memory in the device.


\
\ @brief FLASH PCROP area B end address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_PCROP1BER_PCROP1B_END                \ PCROP1B area end offset Contains the offset of the last subpage of the PCROP1B area. Note: The number of effective bits depends on the size of the flash memory in the device.


\
\ @brief FLASH security register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000003f constant FLASH_FLASH_SECR_SEC_SIZE                        \ Securable memory area size Contains the number of securable flash memory pages. Note: The number of effective bits depends on the size of the flash memory in the device.
$00010000 constant FLASH_FLASH_SECR_BOOT_LOCK                       \ used to force boot from user area If the bit is set in association with RDP level 1, the debug capabilities are disabled, except in the case of a bad OBL (mismatch).


\
\ @brief Spider_FLASH register block
\
$40022000 constant FLASH_FLASH_ACR  \ offset: 0x00 : FLASH access control register
$40022008 constant FLASH_FLASH_KEYR  \ offset: 0x08 : FLASH key register
$4002200c constant FLASH_FLASH_OPTKEYR  \ offset: 0x0C : FLASH option key register
$40022010 constant FLASH_FLASH_SR  \ offset: 0x10 : FLASH status register
$40022014 constant FLASH_FLASH_CR  \ offset: 0x14 : FLASH control register
$40022020 constant FLASH_FLASH_OPTR  \ offset: 0x20 : FLASH option register
$40022024 constant FLASH_FLASH_PCROP1ASR  \ offset: 0x24 : FLASH PCROP area A start address register
$40022028 constant FLASH_FLASH_PCROP1AER  \ offset: 0x28 : FLASH PCROP area A end address register
$4002202c constant FLASH_FLASH_WRP1AR  \ offset: 0x2C : FLASH WRP area A address register
$40022030 constant FLASH_FLASH_WRP1BR  \ offset: 0x30 : FLASH WRP area B address register
$40022034 constant FLASH_FLASH_PCROP1BSR  \ offset: 0x34 : FLASH PCROP area B start address register
$40022038 constant FLASH_FLASH_PCROP1BER  \ offset: 0x38 : FLASH PCROP area B end address register
$40022080 constant FLASH_FLASH_SECR  \ offset: 0x80 : FLASH security register

