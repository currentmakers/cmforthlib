\
\ @file flash.fs
\ @brief Spider_FLASH register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FLASH_DEF

  [ifdef] FLASH_FLASH_ACR_DEF
    \
    \ @brief FLASH access control register
    \ Address offset: 0x00
    \ Reset value: 0x00040600
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 3] Flash memory access latency The value in this bitfield represents the number of CPU wait states when accessing the flash memory. Other: Reserved A new write into the bitfield becomes effective when it returns the same value upon read.
    $08 constant FLASH_PRFTEN                   \ [0x08] CPU Prefetch enable
    $09 constant FLASH_ICEN                     \ [0x09] CPU Instruction cache enable
    $0b constant FLASH_ICRST                    \ [0x0b] CPU Instruction cache reset This bit can be written only when the instruction cache is disabled.
    $10 constant FLASH_EMPTY                    \ [0x10] Main flash memory area empty This bit indicates whether the first location of the Main flash memory area was read as erased or as programmed during OBL. It is not affected by the system reset. Software may need to change this bit value after a flash memory program or erase operation. The bit can be set and reset by software.
    $12 constant FLASH_DBG_SWEN                 \ [0x12] Debug access software enable Software may use this bit to enable/disable the debugger read access.
  [then]


  [ifdef] FLASH_FLASH_KEYR_DEF
    \
    \ @brief FLASH key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_KEY                      \ [0x00 : 32] FLASH key The following values must be written consecutively to unlock the FLASH control register (FLASH_CR), thus enabling programming/erasing operations: KEY1: 0x4567 0123 KEY2: 0xCDEF 89AB
  [then]


  [ifdef] FLASH_FLASH_OPTKEYR_DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEY                   \ [0x00 : 32] Option byte key The following values must be written consecutively to unlock the flash memory option registers, enabling option byte programming/erasing operations: KEY1: 0x0819 2A3B KEY2: 0x4C5D 6E7F
  [then]


  [ifdef] FLASH_FLASH_SR_DEF
    \
    \ @brief FLASH status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EOP                      \ [0x00] End of operation Set by hardware when one or more flash memory operation (programming / erase) has been completed successfully. This bit is set only if the end of operation interrupts are enabled (EOPIE=1). Cleared by writing 1.
    $01 constant FLASH_OPERR                    \ [0x01] Operation error Set by hardware when a flash memory operation (program / erase) completes unsuccessfully. This bit is set only if error interrupts are enabled (ERRIE=1). Cleared by writing '1'.
    $03 constant FLASH_PROGERR                  \ [0x03] Programming error Set by hardware when a double-word address to be programmed contains a value different from '0xFFFF FFFF' before programming, except if the data to write is '0x0000 0000'. Cleared by writing 1.
    $04 constant FLASH_WRPERR                   \ [0x04] Write protection error Set by hardware when an address to be erased/programmed belongs to a write-protected part (by WRP, PCROP or RDP Level 1) of the flash memory. Cleared by writing 1.
    $05 constant FLASH_PGAERR                   \ [0x05] Programming alignment error Set by hardware when the data to program cannot be contained in the same double word (64-bit) flash memory in case of standard programming, or if there is a change of page during fast programming. Cleared by writing 1.
    $06 constant FLASH_SIZERR                   \ [0x06] Size error Set by hardware when the size of the access is a byte or half-word during a program or a fast program sequence. Only double word programming is allowed (consequently: word access). Cleared by writing 1.
    $07 constant FLASH_PGSERR                   \ [0x07] Programming sequence error Set by hardware when a write access to the flash memory is performed by the code while PG or FSTPG have not been set previously. Set also by hardware when PROGERR, SIZERR, PGAERR, WRPERR, MISSERR or FASTERR is set due to a previous programming error. Cleared by writing 1.
    $08 constant FLASH_MISSERR                  \ [0x08] Fast programming data miss error In Fast programming mode, 16 double words (128 bytes) must be sent to flash memory successively, and the new data must be sent to the logic control before the current data is fully programmed. MISSERR is set by hardware when the new data is not present in time. Cleared by writing 1.
    $09 constant FLASH_FASTERR                  \ [0x09] Fast programming error Set by hardware when a fast programming sequence (activated by FSTPG) is interrupted due to an error (alignment, size, write protection or data miss). The corresponding status bit (PGAERR, SIZERR, WRPERR or MISSERR) is set at the same time. Cleared by writing 1.
    $0e constant FLASH_RDERR                    \ [0x0e] PCROP read error Set by hardware when an address to be read belongs to a read protected area of the flash memory (PCROP protection). An interrupt is generated if RDERRIE is set in FLASH_CR. Cleared by writing 1.
    $0f constant FLASH_OPTVERR                  \ [0x0f] Option and Engineering bits loading validity error Set by hardware when the options and engineering bits read may not be the one configured by the user or production. If options and engineering bits haven't been properly loaded, OPTVERR is set again after each system reset. Option bytes that fail loading are forced to a safe value, see Section4.4.2: FLASH option byte programming. Cleared by writing 1.
    $10 constant FLASH_BSY1                     \ [0x10] Busy This flag indicates that a flash memory operation requested by FLASH control register (FLASH_CR) is in progress. This bit is set at the beginning of the flash memory operation, and cleared when the operation finishes or when an error occurs.
    $12 constant FLASH_CFGBSY                   \ [0x12] Programming or erase configuration busy. This flag is set and reset by hardware. For flash program operation, it is set when the first word is sent, and cleared after the second word is sent when the operation completes or ends with an error. For flash erase operation, it is set when setting the STRT bit of the FLASH_CR register and cleared when the operation completes or ends with an error. When set, a programming or erase operation is ongoing and the corresponding settings in the FLASH control register (FLASH_CR) are used (busy) and cannot be changed. Any other flash operation launch must be postponed. When cleared, the programming and erase settings in the FLASH control register (FLASH_CR) can be modified. Note: The CFGBSY bit is also set when attempting to write locked flash memory (with the first byte sent). When the CFGBSY bit is set, writing into the FLASH_CR register causes HardFault.To clear the CFGBSY bit, send a double word to the flash memory and wait until the access is finished (otherwise the CFGBSY bit remains set).
  [then]


  [ifdef] FLASH_FLASH_CR_DEF
    \
    \ @brief FLASH control register
    \ Address offset: 0x14
    \ Reset value: 0xC0000000
    \
    $00 constant FLASH_PG                       \ [0x00] Flash memory programming enable
    $01 constant FLASH_PER                      \ [0x01] Page erase enable
    $02 constant FLASH_MER1                     \ [0x02] Mass erase When set, this bit triggers the mass erase, that is, all user pages.
    $03 constant FLASH_PNB                      \ [0x03 : 6] Page number selection These bits select the page to erase: ... Note: Values corresponding to addresses outside the Main memory are not allowed. See Table6 and Table7.
    $10 constant FLASH_STRT                     \ [0x10] Start erase operation This bit triggers an erase operation when set. This bit is possible to set only by software and to clear only by hardware. The hardware clears it when one of BSY1 and BSY2 flags in the FLASH_SR register transits to zero.
    $11 constant FLASH_OPTSTRT                  \ [0x11] Start of modification of option bytes This bit triggers an options operation when set. This bit is set only by software, and is cleared when the BSY1 bit is cleared in FLASH_SR.
    $12 constant FLASH_FSTPG                    \ [0x12] Fast programming enable
    $18 constant FLASH_EOPIE                    \ [0x18] End-of-operation interrupt enable This bit enables the interrupt generation upon setting the EOP flag in the FLASH_SR register.
    $19 constant FLASH_ERRIE                    \ [0x19] Error interrupt enable This bit enables the interrupt generation upon setting the OPERR flag in the FLASH_SR register.
    $1a constant FLASH_RDERRIE                  \ [0x1a] PCROP read error interrupt enable This bit enables the interrupt generation upon setting the RDERR flag in the FLASH_SR register.
    $1b constant FLASH_OBL_LAUNCH               \ [0x1b] Option byte load launch When set, this bit triggers the load of option bytes into option registers. It is automatically cleared upon the completion of the load. The high state of the bit indicates pending option byte load. The bit cannot be cleared by software. It cannot be written as long as OPTLOCK is set.
    $1c constant FLASH_SEC_PROT                 \ [0x1c] Securable memory area protection enable This bit enables the protection on securable area, provided that a non-null securable memory area size (SEC_SIZE[4:0]) is defined in option bytes. This bit is possible to set only by software and to clear only through a system reset.
    $1e constant FLASH_OPTLOCK                  \ [0x1e] Options Lock This bit is set only. When set, all bits concerning user option in FLASH_CR register and so option page are locked. This bit is cleared by hardware after detecting the unlock sequence. The LOCK bit must be cleared before doing the unlock sequence for OPTLOCK bit. In case of an unsuccessful unlock operation, this bit remains set until the next reset.
    $1f constant FLASH_LOCK                     \ [0x1f] FLASH_CR Lock This bit is set only. When set, the FLASH_CR register is locked. It is cleared by hardware after detecting the unlock sequence. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.
  [then]


  [ifdef] FLASH_FLASH_OPTR_DEF
    \
    \ @brief FLASH option register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_RDP                      \ [0x00 : 8] Read protection level Other: Level 1, memories read protection active
    $08 constant FLASH_BOR_EN                   \ [0x08] Brown out reset enable
    $09 constant FLASH_BORR_LEV                 \ [0x09 : 2] BOR threshold at rising V<sub>DD</sub> supply Rising V<sub>DD</sub> crossings this threshold releases the reset signal.
    $0b constant FLASH_BORF_LEV                 \ [0x0b : 2] BOR threshold at falling V<sub>DD</sub> supply Falling V<sub>DD</sub> crossings this threshold activates the reset signal.
    $0d constant FLASH_NRST_STOP                \ [0x0d] None
    $0e constant FLASH_NRST_STDBY               \ [0x0e] None
    $0f constant FLASH_NRST_SHDW                \ [0x0f] None
    $10 constant FLASH_IWDG_SW                  \ [0x10] None
    $11 constant FLASH_IWDG_STOP                \ [0x11] Independent watchdog counter freeze in Stop mode
    $12 constant FLASH_IWGD_STDBY               \ [0x12] None
    $13 constant FLASH_WWDG_SW                  \ [0x13] Window watchdog selection
    $15 constant FLASH_HSE_NOT_REMAPPED         \ [0x15] HSE remapping enable/disable When cleared, the bit remaps the HSE clock source from PF0-OSC_IN/PF1-OSC_OUT pins to PC14-OSCX_IN/PC15-OSCX_OUT. Thus PC14-OSCX_IN/PC15-OSCX_OUT are shared by both LSE and HSE and the two clock sources cannot be use simultaneously. On packages with less than 48 pins, the remapping is always enabled (PF0-OSC_IN/PF1-OSC_OUT are not available), regardless of this bit. As all STM32C011xx packages have less than 48 pins, this bit is only applicable to STM32C031xx. Note: On 48 pins packages, when HSE_NOT_REMAPPED is reset, HSE cannot be used in bypass mode. Refer to product errata sheet for more details.
    $16 constant FLASH_RAM_PARITY_CHECK         \ [0x16] SRAM parity check control enable/disable
    $17 constant FLASH_SECURE_MUXING_EN         \ [0x17] Multiple-bonding security The bit allows enabling automatic I/O configuration to prevent conflicts on I/Os connected (bonded) onto the same pin. If the software sets one of the I/Os connected to the same pin as active by configuring the SYSCFG_CFGR3 register, enabling this bit automatically forces the other I/Os in digital input mode, regardless of their software configuration. When the bit is disabled, the SYSCFG_CFGR3 register setting is ignored, all GPIOs linked to a given pin are active and can be set in the mode specified by the corresponding GPIOx_MODER register. The user software must ensure that there is no conflict between GPIOs.
    $18 constant FLASH_NBOOT_SEL                \ [0x18] BOOT0 signal source selection This option bit defines the source of the BOOT0 signal.
    $19 constant FLASH_NBOOT1                   \ [0x19] Boot configuration Together with the BOOT0 pin or option bit nBOOT0 (depending on nBOOT_SEL option bit configuration), this bit selects boot mode from the Main flash memory, SRAM or the System memory. Refer to Section3: Boot configuration.
    $1a constant FLASH_NBOOT0                   \ [0x1a] nBOOT0 option bit
    $1b constant FLASH_NRST_MODE                \ [0x1b : 2] NRST pin configuration
    $1d constant FLASH_IRHEN                    \ [0x1d] Internal reset holder enable bit
  [then]


  [ifdef] FLASH_FLASH_PCROP1ASR_DEF
    \
    \ @brief FLASH PCROP area A start address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PCROP1A_STRT             \ [0x00 : 8] PCROP1A area start offset Contains the offset of the first subpage of the PCROP1A area. Note: The number of effective bits depends on the size of the flash memory in the device.
  [then]


  [ifdef] FLASH_FLASH_PCROP1AER_DEF
    \
    \ @brief FLASH PCROP area A end address register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PCROP1A_END              \ [0x00 : 8] PCROP1A area end offset Contains the offset of the last subpage of the PCROP1A area. Note: The number of effective bits depends on the size of the flash memory in the device.
    $1f constant FLASH_PCROP_RDP                \ [0x1f] PCROP area erase upon RDP level regression This bit determines whether the PCROP area (and the totality of the PCROP area boundary pages) is erased by the mass erase triggered by the RDP level regression from Level 1 to Level 0: The software can only set this bit. It is automatically reset upon mass erase following the RDP regression from Level 1 to Level 0.
  [then]


  [ifdef] FLASH_FLASH_WRP1AR_DEF
    \
    \ @brief FLASH WRP area A address register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRP1A_STRT               \ [0x00 : 6] WRP area A start offset This bitfield contains the offset of the first page of the WRP area A. Note: The number of effective bits depends on the size of the flash memory in the device.
    $10 constant FLASH_WRP1A_END                \ [0x10 : 6] WRP area A end offset This bitfield contains the offset of the last page of the WRP area A. Note: The number of effective bits depends on the size of the flash memory in the device.
  [then]


  [ifdef] FLASH_FLASH_WRP1BR_DEF
    \
    \ @brief FLASH WRP area B address register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRP1B_STRT               \ [0x00 : 6] WRP area B start offset This bitfield contains the offset of the first page of the WRP area B. Note: The number of effective bits depends on the size of the flash memory in the device.
    $10 constant FLASH_WRP1B_END                \ [0x10 : 6] WRP area B end offset This bitfield contains the offset of the last page of the WRP area B. Note: The number of effective bits depends on the size of the flash memory in the device.
  [then]


  [ifdef] FLASH_FLASH_PCROP1BSR_DEF
    \
    \ @brief FLASH PCROP area B start address register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PCROP1B_STRT             \ [0x00 : 8] PCROP1B area start offset Contains the offset of the first subpage of the PCROP1B area. Note: The number of effective bits depends on the size of the flash memory in the device.
  [then]


  [ifdef] FLASH_FLASH_PCROP1BER_DEF
    \
    \ @brief FLASH PCROP area B end address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PCROP1B_END              \ [0x00 : 8] PCROP1B area end offset Contains the offset of the last subpage of the PCROP1B area. Note: The number of effective bits depends on the size of the flash memory in the device.
  [then]


  [ifdef] FLASH_FLASH_SECR_DEF
    \
    \ @brief FLASH security register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_SIZE                 \ [0x00 : 8] Securable memory area size Contains the number of securable flash memory pages. Note: The number of effective bits depends on the size of the flash memory in the device.
    $10 constant FLASH_BOOT_LOCK                \ [0x10] used to force boot from user area If the bit is set in association with RDP level 1, the debug capabilities are disabled, except in the case of a bad OBL (mismatch).
  [then]

  \
  \ @brief Spider_FLASH register block
  \
  $00 constant FLASH_FLASH_ACR          \ FLASH access control register
  $08 constant FLASH_FLASH_KEYR         \ FLASH key register
  $0C constant FLASH_FLASH_OPTKEYR      \ FLASH option key register
  $10 constant FLASH_FLASH_SR           \ FLASH status register
  $14 constant FLASH_FLASH_CR           \ FLASH control register
  $20 constant FLASH_FLASH_OPTR         \ FLASH option register
  $24 constant FLASH_FLASH_PCROP1ASR    \ FLASH PCROP area A start address register
  $28 constant FLASH_FLASH_PCROP1AER    \ FLASH PCROP area A end address register
  $2C constant FLASH_FLASH_WRP1AR       \ FLASH WRP area A address register
  $30 constant FLASH_FLASH_WRP1BR       \ FLASH WRP area B address register
  $34 constant FLASH_FLASH_PCROP1BSR    \ FLASH PCROP area B start address register
  $38 constant FLASH_FLASH_PCROP1BER    \ FLASH PCROP area B end address register
  $80 constant FLASH_FLASH_SECR         \ FLASH security register

: FLASH_DEF ; [then]
