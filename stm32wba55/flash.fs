\
\ @file flash.fs
\ @brief Embedded Flash memory
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FLASH_DEF

  [ifdef] FLASH_FLASH_ACR_DEF
    \
    \ @brief FLASH access control register
    \ Address offset: 0x00
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 4] Latency These bits represent the ratio between the AHB hclk1 clock period and the Flash memory access time. Access to the bit can be secured by RCC SYSCLKSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with FLASH SPRIV or when non-secure with FLASH NSPRIV. ... Note: Before entering Stop 1 mode software must set FLASH wait state latency to at least 1.
    $08 constant FLASH_PRFTEN                   \ [0x08] Prefetch enable This bit enables the prefetch buffer in the embedded Flash memory. This bit can be protected against unprivileged access by FLASH NSPRIV.
    $0b constant FLASH_LPM                      \ [0x0b] Low-power read mode This bit puts the Flash memory in low-power read mode. Access to the bit can be secured by PWR LPMSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with FLASH SPRIV or when non-secure with FLASH NSPRIV. This bit can't be written when a Flash program or erase operation is busy (BSY = 1) or when the write buffer is not empty (WDW = 1). Changing this bit while a Flash program or erase operation is busy (BSY = 1) is rejected.
    $0c constant FLASH_PDREQ                    \ [0x0c] Flash power-down mode request This bit requests Flash to enter power-down mode. When Flash enters power-down mode, this bit is cleared by hardware and the PDKEYR is locked. This bit is write-protected with FLASH_PDKEYR. Access to the bit can be secured by PWR LPMSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with FLASH SPRIV or when non-secure with FLASH NSPRIV.
    $0e constant FLASH_SLEEP_PD                 \ [0x0e] Flash memory power-down mode during Sleep mode This bit determines whether the Flash memory is in power-down mode or Idle mode when the device is in Sleep mode. Access to the bit can be secured by PWR LPMSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with FLASH SPRIV or when non-secure with FLASH NSPRIV. The Flash must not be put in power-down while a program or an erase operation is ongoing.
  [then]


  [ifdef] FLASH_FLASH_NSKEYR_DEF
    \
    \ @brief FLASH key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSKEY                    \ [0x00 : 32] Flash memory non-secure key The following values must be written consecutively to unlock the FLASH_NSCR1 register, allowing the Flash memory non-secure programming/erasing operations: KEY1: 0x45670123 KEY2: 0xCDEF89AB
  [then]


  [ifdef] FLASH_FLASH_SECKEYR_DEF
    \
    \ @brief FLASH secure key register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECKEY                   \ [0x00 : 32] Flash memory secure key The following values must be written consecutively to unlock the FLASH_SECCR1 register, allowing the Flash memory secure programming/erasing operations: KEY1: 0x45670123 KEY2: 0xCDEF89AB
  [then]


  [ifdef] FLASH_FLASH_OPTKEYR_DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEY                   \ [0x00 : 32] Option byte key The LOCK bit in the FLASH_NSCR1 must be cleared before doing the unlock sequence for OPTLOCK bit. The following values must be written consecutively to unlock the FLASH_NSCR1.OPTSTRT and OBL_LAUNCH register bits concerning user option operations: KEY1: 0x08192A3B KEY2: 0x4C5D6E7F
  [then]


  [ifdef] FLASH_FLASH_PDKEYR_DEF
    \
    \ @brief FLASH power-down key register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PDKEY1                   \ [0x00 : 32] Flash power-down key The following values must be written consecutively to unlock the PDREQ bit in FLASH_ACR: PDKEY_1: 0x04152637 PDKEY_2: 0xFAFBFCFD
  [then]


  [ifdef] FLASH_FLASH_NSSR_DEF
    \
    \ @brief FLASH status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EOP                      \ [0x00] Non-secure end of operation This bit is set by hardware when one or more Flash memory non-secure operation (program/erase) has been completed successfully. This bit is set only if the non-secure end of operation interrupts are enabled (EOPIE = 1 in FLASH_NSCR1). This bit is cleared by writing1.
    $01 constant FLASH_OPERR                    \ [0x01] Non-secure operation error This bit is set by hardware when a Flash memory non-secure operation (program/erase) completes unsuccessfully. This bit is set only if non-secure error interrupts are enabled (NSERRIE = 1). This bit is cleared by writing 1.
    $03 constant FLASH_PROGERR                  \ [0x03] Non-secure programming error This bit is set by hardware when a non-secure quad-word address to be programmed contains a value different from all 1 before programming, except if the data to write is all 0. This bit is cleared by writing 1.
    $04 constant FLASH_WRPERR                   \ [0x04] Non-secure write protection error This bit is set by hardware when a non-secure address to be erased/programmed belongs to a write-protected part (by WRP or HDP) of the Flash memory. This bit is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
    $05 constant FLASH_PGAERR                   \ [0x05] Non-secure programming alignment error This bit is set by hardware when the first word to be programmed is not aligned with a quad-word address, or the second, third or forth word does not belong to the same quad-word address. This bit is cleared by writing 1.
    $06 constant FLASH_SIZERR                   \ [0x06] Non-secure size error This bit is set by hardware when the size of the access is a byte or half-word during a non-secure program sequence. Only quad-word programming is allowed by means of successive word accesses. This bit is cleared by writing 1.
    $07 constant FLASH_PGSERR                   \ [0x07] Non-secure programming sequence error This bit is set by hardware when programming sequence is not correct. It is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
    $0d constant FLASH_OPTWERR                  \ [0x0d] Option write error This bit is set by hardware when the options bytes are written with an invalid configuration or when modifying options in RDP level 2.. It is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
    $10 constant FLASH_BSY                      \ [0x10] Non-secure busy This indicates that a Flash memory secure or non-secure operation is in progress. This bit is set at the beginning of a Flash operation and reset when the operation finishes or when an error occurs.
    $11 constant FLASH_WDW                      \ [0x11] Non-secure wait data to write This bit indicates that the Flash memory write buffer has been written by a secure or non-secure operation. It is set when the first data is stored in the buffer and cleared when the write is performed in the Flash memory.
    $12 constant FLASH_OEM1LOCK                 \ [0x12] OEM1 key RDP lock This bit indicates that the OEM1 key read during the OBL is not virgin. When set, the OEM1 key RDP lock mechanism is active.
    $13 constant FLASH_OEM2LOCK                 \ [0x13] OEM2 key RDP lock This bit indicates that the OEM2 key read during the OBL is not virgin. When set, the OEM2 key RDP lock mechanism is active.
    $14 constant FLASH_PD                       \ [0x14] Flash in power-down mode This bit indicates that the Flash memory is in power-down state. It is reset when Flash is in normal mode or being awaken.
  [then]


  [ifdef] FLASH_FLASH_SECSR_DEF
    \
    \ @brief FLASH secure status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EOP                      \ [0x00] Secure end of operation This bit is set by hardware when one or more Flash memory secure operation (program/erase) has been completed successfully. This bit is set only if the secure end of operation interrupts are enabled (EOPIE = 1 in FLASH_SECCR1). This bit is cleared by writing1.
    $01 constant FLASH_OPERR                    \ [0x01] Secure operation error This bit is set by hardware when a Flash memory secure operation (program/erase) completes unsuccessfully. This bit is set only if secure error interrupts are enabled (SECERRIE = 1). This bit is cleared by writing 1.
    $03 constant FLASH_PROGERR                  \ [0x03] Secure programming error This bit is set by hardware when a secure quad-word address to be programmed contains a value different from all 1 before programming, except if the data to write is all 0. This bit is cleared by writing 1.
    $04 constant FLASH_WRPERR                   \ [0x04] Secure write protection error This bit is set by hardware when an secure address to be erased/programmed belongs to a write-protected part (by WRP or HDP) of the Flash memory. This bit is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
    $05 constant FLASH_PGAERR                   \ [0x05] Secure programming alignment error This bit is set by hardware when the first word to be programmed is not aligned with a quad-word address, or the second, third or forth word does not belong to the same quad-word address.This bit is cleared by writing 1.
    $06 constant FLASH_SIZERR                   \ [0x06] Secure size error This bit is set by hardware when the size of the access is a byte or half-word during a secure program sequence. Only quad-word programming is allowed by means of successive word accesses.This bit is cleared by writing 1.
    $07 constant FLASH_PGSERR                   \ [0x07] Secure programming sequence error This bit is set by hardware when programming sequence is not correct. It is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
    $10 constant FLASH_BSY                      \ [0x10] Secure busy This bit indicates that a Flash memory secure or non-secure operation is in progress. This is set on the beginning of a Flash operation and reset when the operation finishes or when an error occurs.
    $11 constant FLASH_WDW                      \ [0x11] Secure wait data to write This bit indicates that the Flash memory write buffer has been written by a secure or non-secure operation. It is set when the first data is stored in the buffer and cleared when the write is performed in the Flash memory.
  [then]


  [ifdef] FLASH_FLASH_NSCR1_DEF
    \
    \ @brief FLASH control register
    \ Address offset: 0x28
    \ Reset value: 0xC0000000
    \
    $00 constant FLASH_PG                       \ [0x00] Non-secure programming
    $01 constant FLASH_PER                      \ [0x01] Non-secure page erase
    $02 constant FLASH_MER                      \ [0x02] Non-secure Flash mass erase This bit triggers the Flash non-secure mass erase (all Flash user pages) when set.
    $03 constant FLASH_PNB                      \ [0x03 : 7] Non-secure page number selection These bits select the page to erase. ... Note that bit 9 is reserved on STM32WBA5xEx devices.
    $0e constant FLASH_BWR                      \ [0x0e] Non-secure burst write programming mode When set, this bit selects the burst write programming mode.
    $10 constant FLASH_STRT                     \ [0x10] Non-secure operation start This bit triggers a non-secure erase operation when set. If MER and PER bits are reset and the STRT bit is set, the PGSERR bit in FLASH_NSSR is set (this condition is forbidden). This bit is set only by software and is cleared when the BSY bit is cleared in FLASH_NSSR.
    $11 constant FLASH_OPTSTRT                  \ [0x11] Options modification start This bit triggers an option bytes erase and program operation when set. This bit is write-protected with OPTLOCK.. This bit is set only by software, and is cleared when the BSY bit is cleared in FLASH_NSSR.
    $18 constant FLASH_EOPIE                    \ [0x18] Non-secure end of operation interrupt enable This bit enables the interrupt generation when the EOP bit in the FLASH_NSSR is set to 1.
    $19 constant FLASH_ERRIE                    \ [0x19] Non-secure error interrupt enable This bit enables the interrupt generation when the OPERR bit in the FLASH_NSSR is set to 1.
    $1b constant FLASH_OBL_LAUNCH               \ [0x1b] Force the option byte loading When set to 1, this bit forces the option byte reloading. This bit is cleared only when the option byte loading is complete. This bit is write-protected with OPTLOCK. Note: The LSE oscillator must be disabled, LSEON = 0 and LSERDY = 0, before starting OBL_LAUNCH.
    $1e constant FLASH_OPTLOCK                  \ [0x1e] Option lock This bit is set only. When set, the FLASH_NSCR1.OPTSRT and OBL_LAUNCH bits concerning user options write access is locked. This bit is cleared by hardware after detecting the unlock sequence in FLASH_OPTKEYR. The FLASH_NSCR1.LOCK bit must be cleared before doing the FLASH_OPTKEYR unlock sequence. In case of an unsuccessful unlock operation, this bit remains set until the next reset.
    $1f constant FLASH_LOCK                     \ [0x1f] Non-secure lock This bit is set only. When set, the FLASH_NSCR1 register write access is locked. This bit is cleared by hardware after detecting the unlock sequence in FLASH_NSKEYR. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.
  [then]


  [ifdef] FLASH_FLASH_SECCR1_DEF
    \
    \ @brief FLASH secure control register
    \ Address offset: 0x2C
    \ Reset value: 0x80000000
    \
    $00 constant FLASH_PG                       \ [0x00] Secure programming
    $01 constant FLASH_PER                      \ [0x01] Secure page erase
    $02 constant FLASH_MER                      \ [0x02] Secure Flash mass erase This bit triggers the Flash secure mass erase (all Flash user pages) when set.
    $03 constant FLASH_PNB                      \ [0x03 : 7] Secure page number selection These bits select the page to erase: ... Note that bit 9 is reserved on STM32WBA5xEx devices.
    $0e constant FLASH_BWR                      \ [0x0e] Secure burst write programming mode When set, this bit selects the burst write programming mode.
    $10 constant FLASH_STRT                     \ [0x10] Secure start This bit triggers a secure erase operation when set. If MER and PER bits are reset and the STRT bit is set, the PGSERR in the FLASH_SECSR is set (this condition is forbidden). This bit is set only by software and is cleared when the BSY bit is cleared in FLASH_SECSR.
    $18 constant FLASH_EOPIE                    \ [0x18] Secure End of operation interrupt enable This bit enables the interrupt generation when the EOP bit in FLASH_SECSR is set to 1.
    $19 constant FLASH_ERRIE                    \ [0x19] Secure error interrupt enable This bit enables the interrupt generation when the OPERR bit in FLASH_SECSR is set to 1.
    $1d constant FLASH_INV                      \ [0x1d] Flash memory security state invert This bit inverts the Flash memory security state.
    $1f constant FLASH_LOCK                     \ [0x1f] Secure lock This bit is set only. When set, the FLASH_SECCR1 register is locked. It is cleared by hardware after detecting the unlock sequence in FLASH_SECKEYR register. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.
  [then]


  [ifdef] FLASH_FLASH_ECCR_DEF
    \
    \ @brief FLASH ECC register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 20] ECC fail address This field indicates which address is concerned by the ECC error correction or by the double ECC error detection. The address is given relative to Flash base address, from offset 0x00000 to 0xFFFF0. Note that bit 19 is reserved on STM32WBAxEx devices.
    $16 constant FLASH_SYSF_ECC                 \ [0x16] System Flash memory ECC fail This bit indicates that the ECC error correction or double ECC error detection is located in the system Flash memory.
    $18 constant FLASH_ECCIE                    \ [0x18] ECC correction interrupt enable This bit enables the interrupt generation when the ECCC bit in the FLASH_ECCR register is set.
    $1e constant FLASH_ECCC                     \ [0x1e] ECC correction This bit is set by hardware when one ECC error has been detected and corrected (only if ECCC and ECCD were previously cleared). An interrupt is generated if ECCIE is set. This bit is cleared by writing 1.
    $1f constant FLASH_ECCD                     \ [0x1f] ECC detection This bit is set by hardware when two ECC errors have been detected (only if ECCC and ECCD were previously cleared). When this bit is set, a NMI is generated. This bit is cleared by writing 1.
  [then]


  [ifdef] FLASH_FLASH_OPSR_DEF
    \
    \ @brief FLASH operation status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_OP                  \ [0x00 : 20] Interrupted operation address This field indicates which address in the Flash memory was accessed when reset occurred. The address is given relative to the Flash base address, from offset 0x00000 to 0xFFFF0. Note that bit 19 is reserved on STM32WBAxEx devices.
    $16 constant FLASH_SYSF_OP                  \ [0x16] Operation in system Flash memory interrupted This bit indicates that the reset occurred during an operation in the system Flash memory.
    $1d constant FLASH_CODE_OP                  \ [0x1d : 3] Flash memory operation code This field indicates which Flash memory operation has been interrupted by a system reset:
  [then]


  [ifdef] FLASH_FLASH_NSCR2_DEF
    \
    \ @brief FLASH control 2 register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PS                       \ [0x00] Program suspend request
    $01 constant FLASH_ES                       \ [0x01] Erase suspend request
  [then]


  [ifdef] FLASH_FLASH_SECCR2_DEF
    \
    \ @brief FLASH secure control 2 register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PS                       \ [0x00] Program suspend request
    $01 constant FLASH_ES                       \ [0x01] Erase suspend request
  [then]


  [ifdef] FLASH_FLASH_OPTR_DEF
    \
    \ @brief FLASH option register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_RDP                      \ [0x00 : 8] Readout protection level Others: Level 1 (memories readout protection active) Note: Refer to Section7.6.2: Readout protection (RDP) for more details.
    $08 constant FLASH_BOR_LEV                  \ [0x08 : 3] BOR reset level These bits contain the VsubDD/sub supply level threshold that activates/releases the reset.
    $0c constant FLASH_NRST_STOP                \ [0x0c] Reset generation in Stop mode
    $0d constant FLASH_NRST_STDBY               \ [0x0d] Reset generation in Standby mode
    $0f constant FLASH_SRAM1_RST                \ [0x0f] SRAM1 erase upon system reset
    $10 constant FLASH_IWDG_SW                  \ [0x10] Independent watchdog enable selection
    $11 constant FLASH_IWDG_STOP                \ [0x11] Independent watchdog counter freeze in Stop mode
    $12 constant FLASH_IWDG_STDBY               \ [0x12] Independent watchdog counter freeze in Standby mode
    $13 constant FLASH_WWDG_SW                  \ [0x13] Window watchdog selection
    $18 constant FLASH_SRAM2_PE                 \ [0x18] SRAM2 parity check enable
    $19 constant FLASH_SRAM2_RST                \ [0x19] SRAM2 erase when system reset
    $1a constant FLASH_NSWBOOT0                 \ [0x1a] Software BOOT0
    $1b constant FLASH_NBOOT0                   \ [0x1b] NBOOT0 option bit
    $1f constant FLASH_TZEN                     \ [0x1f] Global TrustZone security enable
  [then]


  [ifdef] FLASH_FLASH_NSBOOTADD0R_DEF
    \
    \ @brief FLASH boot address 0 register
    \ Address offset: 0x44
    \ Reset value: 0x0000000F
    \
    $07 constant FLASH_NSBOOTADD0               \ [0x07 : 25] Non-secure boot base address 0 This address is only used when TZEN = 0. The non-secure boot memory address can be programmed to any address in the valid address range (see Table 28: Boot space versus RDP protection) with a granularity of 128 bytes. These bits correspond to address [31:7]. The NSBOOTADD0 option bytes are selected following the BOOT0 pin or NSWBOOT0 state. Examples: NSBOOTADD0[24:0] = 0x0100000: Boot from Flash memory (0x0800 0000) NSBOOTADD0[24:0] = 0x017F100: Boot from system memory bootloader (0x0BF8 8000) NSBOOTADD0[24:0] = 0x0400200: Boot from SRAM2 on S-Bus (0x2001 0000)
  [then]


  [ifdef] FLASH_FLASH_NSBOOTADD1R_DEF
    \
    \ @brief FLASH boot address 1 register
    \ Address offset: 0x48
    \ Reset value: 0x0000000F
    \
    $07 constant FLASH_NSBOOTADD1               \ [0x07 : 25] Non-secure boot address 1 This address is only used when TZEN = 0. The non-secure boot memory address can be programmed to any address in the valid address range (see Table 28: Boot space versus RDP protection) with a granularity of 128 bytes. These bits correspond to address [31:7]. The NSBOOTADD0 option bytes are selected following the BOOT0 pin or NSWBOOT0 state. Examples: NSBOOTADD1[24:0] = 0x0100000: Boot from Flash memory (0x0800 0000) NSBOOTADD1[24:0] = 0x017F100: Boot from system memory bootloader (0x0BF8 8000) NSBOOTADD1[24:0] = 0x0400200: Boot from SRAM2 (0x2001 0000)
  [then]


  [ifdef] FLASH_FLASH_SECBOOTADD0R_DEF
    \
    \ @brief FLASH secure boot address 0 register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_LOCK                \ [0x00] Boot lock This lock is only used when TZEN = 0. When set, the boot is always forced to base address value programmed in SECBOOTADD0[24:0] option bytes whatever the boot selection option. When set, this bit can only be cleared by an RDP regression level 1 to level 0.
    $07 constant FLASH_SECBOOTADD0              \ [0x07 : 25] Secure boot base address 0 This address is only used when TZEN = 1. The secure boot memory address can be programmed to any address in the valid address range (see Table28: Boot space versus RDP protection) with a granularity of 128 bytes. This bits correspond to address [31:7] The SECBOOTADD0 option bytes are selected following the BOOT0 pin or NSWBOOT0 state. Examples: SECBOOTADD0[24:0] = 0x018 0000: Boot from secure user Flash memory (0x0C00 0000) SECBOOTADD0[24:0] = 0x01F F000: Boot from RSS system Flash memory (0x0FF8 0000) SECBOOTADD0[24:0] = 0x060 0000: Boot from secure SRAM1 on S-Bus (0x3000 0000)
  [then]


  [ifdef] FLASH_FLASH_SECWMR1_DEF
    \
    \ @brief FLASH secure watermark register 1
    \ Address offset: 0x50
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_SECWM_PSTRT              \ [0x00 : 7] Start page of secure area This field contains the first page of the secure area.
    $10 constant FLASH_SECWM_PEND               \ [0x10 : 7] End page of secure area This field contains the last page of the secure area.
  [then]


  [ifdef] FLASH_FLASH_SECWMR2_DEF
    \
    \ @brief FLASH secure watermark register 2
    \ Address offset: 0x54
    \ Reset value: 0x0F000F00
    \
    $10 constant FLASH_HDP_PEND                 \ [0x10 : 7] End page of secure hide protection area This field contains the last page of the secure HDP area.
    $1f constant FLASH_HDPEN                    \ [0x1f] Secure Hide protection area enable
  [then]


  [ifdef] FLASH_FLASH_WRPAR_DEF
    \
    \ @brief FLASH WRP area A address register
    \ Address offset: 0x58
    \ Reset value: 0x0F00FF00
    \
    $00 constant FLASH_WRPA_PSTRT               \ [0x00 : 7] WPR area A start page This field contains the first page of the WPR area A. Note that bit 6 is reserved on STM32WBAxEx devices.
    $10 constant FLASH_WRPA_PEND                \ [0x10 : 7] WPR area A end page This field contains the last page of the WPR area A. Note that bit 22 is reserved on STM32WBAxEx devices.
    $1f constant FLASH_UNLOCK                   \ [0x1f] WPR area A unlock
  [then]


  [ifdef] FLASH_FLASH_WRPBR_DEF
    \
    \ @brief FLASH WRP area B address register
    \ Address offset: 0x5C
    \ Reset value: 0x0F00FF00
    \
    $00 constant FLASH_WRPB_PSTRT               \ [0x00 : 7] WRP area B start page This field contains the first page of the WRP area B. Note that bit 6 is reserved on STM32WBAxEx devices.
    $10 constant FLASH_WRPB_PEND                \ [0x10 : 7] WRP area B end page This field contains the last page of the WRP area B. Note that bit 22 is reserved on STM32WBAxEx devices.
    $1f constant FLASH_UNLOCK                   \ [0x1f] WPR area B unlock
  [then]


  [ifdef] FLASH_FLASH_OEM1KEYR1_DEF
    \
    \ @brief FLASH OEM1 key register 1
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OEM1KEY                  \ [0x00 : 32] OEM1 key least significant bytes
  [then]


  [ifdef] FLASH_FLASH_OEM1KEYR2_DEF
    \
    \ @brief FLASH OEM1 key register 2
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OEM1KEY                  \ [0x00 : 32] OEM1 key most significant bytes
  [then]


  [ifdef] FLASH_FLASH_OEM2KEYR1_DEF
    \
    \ @brief FLASH OEM2 key register 1
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OEM2KEY                  \ [0x00 : 32] OEM2 key least significant bytes
  [then]


  [ifdef] FLASH_FLASH_OEM2KEYR2_DEF
    \
    \ @brief FLASH OEM2 key register 2
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OEM2KEY                  \ [0x00 : 32] OEM2 key most significant bytes
  [then]


  [ifdef] FLASH_FLASH_SECBBR1_DEF
    \
    \ @brief FLASH secure block based register 1
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB0                   \ [0x00] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $01 constant FLASH_SECBB1                   \ [0x01] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $02 constant FLASH_SECBB2                   \ [0x02] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $03 constant FLASH_SECBB3                   \ [0x03] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $04 constant FLASH_SECBB4                   \ [0x04] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $05 constant FLASH_SECBB5                   \ [0x05] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $06 constant FLASH_SECBB6                   \ [0x06] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $07 constant FLASH_SECBB7                   \ [0x07] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $08 constant FLASH_SECBB8                   \ [0x08] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $09 constant FLASH_SECBB9                   \ [0x09] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0a constant FLASH_SECBB10                  \ [0x0a] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0b constant FLASH_SECBB11                  \ [0x0b] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0c constant FLASH_SECBB12                  \ [0x0c] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0d constant FLASH_SECBB13                  \ [0x0d] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0e constant FLASH_SECBB14                  \ [0x0e] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0f constant FLASH_SECBB15                  \ [0x0f] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $10 constant FLASH_SECBB16                  \ [0x10] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $11 constant FLASH_SECBB17                  \ [0x11] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $12 constant FLASH_SECBB18                  \ [0x12] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $13 constant FLASH_SECBB19                  \ [0x13] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $14 constant FLASH_SECBB20                  \ [0x14] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $15 constant FLASH_SECBB21                  \ [0x15] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $16 constant FLASH_SECBB22                  \ [0x16] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $17 constant FLASH_SECBB23                  \ [0x17] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $18 constant FLASH_SECBB24                  \ [0x18] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $19 constant FLASH_SECBB25                  \ [0x19] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1a constant FLASH_SECBB26                  \ [0x1a] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1b constant FLASH_SECBB27                  \ [0x1b] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1c constant FLASH_SECBB28                  \ [0x1c] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1d constant FLASH_SECBB29                  \ [0x1d] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1e constant FLASH_SECBB30                  \ [0x1e] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1f constant FLASH_SECBB31                  \ [0x1f] page secure/non-secure attribution Each bit is used to set one page security attribution.
  [then]


  [ifdef] FLASH_FLASH_SECBBR2_DEF
    \
    \ @brief FLASH secure block based register 2
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB0                   \ [0x00] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $01 constant FLASH_SECBB1                   \ [0x01] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $02 constant FLASH_SECBB2                   \ [0x02] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $03 constant FLASH_SECBB3                   \ [0x03] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $04 constant FLASH_SECBB4                   \ [0x04] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $05 constant FLASH_SECBB5                   \ [0x05] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $06 constant FLASH_SECBB6                   \ [0x06] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $07 constant FLASH_SECBB7                   \ [0x07] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $08 constant FLASH_SECBB8                   \ [0x08] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $09 constant FLASH_SECBB9                   \ [0x09] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0a constant FLASH_SECBB10                  \ [0x0a] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0b constant FLASH_SECBB11                  \ [0x0b] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0c constant FLASH_SECBB12                  \ [0x0c] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0d constant FLASH_SECBB13                  \ [0x0d] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0e constant FLASH_SECBB14                  \ [0x0e] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $0f constant FLASH_SECBB15                  \ [0x0f] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $10 constant FLASH_SECBB16                  \ [0x10] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $11 constant FLASH_SECBB17                  \ [0x11] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $12 constant FLASH_SECBB18                  \ [0x12] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $13 constant FLASH_SECBB19                  \ [0x13] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $14 constant FLASH_SECBB20                  \ [0x14] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $15 constant FLASH_SECBB21                  \ [0x15] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $16 constant FLASH_SECBB22                  \ [0x16] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $17 constant FLASH_SECBB23                  \ [0x17] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $18 constant FLASH_SECBB24                  \ [0x18] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $19 constant FLASH_SECBB25                  \ [0x19] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1a constant FLASH_SECBB26                  \ [0x1a] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1b constant FLASH_SECBB27                  \ [0x1b] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1c constant FLASH_SECBB28                  \ [0x1c] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1d constant FLASH_SECBB29                  \ [0x1d] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1e constant FLASH_SECBB30                  \ [0x1e] page secure/non-secure attribution Each bit is used to set one page security attribution.
    $1f constant FLASH_SECBB31                  \ [0x1f] page secure/non-secure attribution Each bit is used to set one page security attribution.
  [then]


  [ifdef] FLASH_FLASH_SECHDPCR_DEF
    \
    \ @brief FLASH secure HDP control register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP_ACCDIS               \ [0x00] Secure HDP area access disable When set, this bit is only cleared by a system reset.
  [then]


  [ifdef] FLASH_FLASH_PRIFCFGR_DEF
    \
    \ @brief FLASH privilege configuration register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SPRIV                    \ [0x00] Privileged protection for secure registers This bit is secure write protected. It can only be written by a secure privileged access when TrustZone is enabled (TZEN=1).
    $01 constant FLASH_NSPRIV                   \ [0x01] Privileged protection for non-secure registers
  [then]


  [ifdef] FLASH_FLASH_PRIVBBR1_DEF
    \
    \ @brief FLASH privilege block based register 1
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB0                  \ [0x00] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $01 constant FLASH_PRIVBB1                  \ [0x01] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $02 constant FLASH_PRIVBB2                  \ [0x02] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $03 constant FLASH_PRIVBB3                  \ [0x03] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $04 constant FLASH_PRIVBB4                  \ [0x04] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $05 constant FLASH_PRIVBB5                  \ [0x05] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $06 constant FLASH_PRIVBB6                  \ [0x06] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $07 constant FLASH_PRIVBB7                  \ [0x07] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $08 constant FLASH_PRIVBB8                  \ [0x08] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $09 constant FLASH_PRIVBB9                  \ [0x09] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0a constant FLASH_PRIVBB10                 \ [0x0a] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0b constant FLASH_PRIVBB11                 \ [0x0b] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0c constant FLASH_PRIVBB12                 \ [0x0c] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0d constant FLASH_PRIVBB13                 \ [0x0d] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0e constant FLASH_PRIVBB14                 \ [0x0e] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0f constant FLASH_PRIVBB15                 \ [0x0f] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $10 constant FLASH_PRIVBB16                 \ [0x10] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $11 constant FLASH_PRIVBB17                 \ [0x11] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $12 constant FLASH_PRIVBB18                 \ [0x12] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $13 constant FLASH_PRIVBB19                 \ [0x13] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $14 constant FLASH_PRIVBB20                 \ [0x14] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $15 constant FLASH_PRIVBB21                 \ [0x15] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $16 constant FLASH_PRIVBB22                 \ [0x16] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $17 constant FLASH_PRIVBB23                 \ [0x17] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $18 constant FLASH_PRIVBB24                 \ [0x18] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $19 constant FLASH_PRIVBB25                 \ [0x19] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1a constant FLASH_PRIVBB26                 \ [0x1a] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1b constant FLASH_PRIVBB27                 \ [0x1b] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1c constant FLASH_PRIVBB28                 \ [0x1c] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1d constant FLASH_PRIVBB29                 \ [0x1d] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1e constant FLASH_PRIVBB30                 \ [0x1e] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1f constant FLASH_PRIVBB31                 \ [0x1f] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
  [then]


  [ifdef] FLASH_FLASH_PRIVBBR2_DEF
    \
    \ @brief FLASH privilege block based register 2
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB0                  \ [0x00] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $01 constant FLASH_PRIVBB1                  \ [0x01] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $02 constant FLASH_PRIVBB2                  \ [0x02] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $03 constant FLASH_PRIVBB3                  \ [0x03] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $04 constant FLASH_PRIVBB4                  \ [0x04] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $05 constant FLASH_PRIVBB5                  \ [0x05] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $06 constant FLASH_PRIVBB6                  \ [0x06] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $07 constant FLASH_PRIVBB7                  \ [0x07] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $08 constant FLASH_PRIVBB8                  \ [0x08] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $09 constant FLASH_PRIVBB9                  \ [0x09] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0a constant FLASH_PRIVBB10                 \ [0x0a] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0b constant FLASH_PRIVBB11                 \ [0x0b] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0c constant FLASH_PRIVBB12                 \ [0x0c] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0d constant FLASH_PRIVBB13                 \ [0x0d] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0e constant FLASH_PRIVBB14                 \ [0x0e] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0f constant FLASH_PRIVBB15                 \ [0x0f] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $10 constant FLASH_PRIVBB16                 \ [0x10] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $11 constant FLASH_PRIVBB17                 \ [0x11] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $12 constant FLASH_PRIVBB18                 \ [0x12] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $13 constant FLASH_PRIVBB19                 \ [0x13] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $14 constant FLASH_PRIVBB20                 \ [0x14] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $15 constant FLASH_PRIVBB21                 \ [0x15] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $16 constant FLASH_PRIVBB22                 \ [0x16] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $17 constant FLASH_PRIVBB23                 \ [0x17] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $18 constant FLASH_PRIVBB24                 \ [0x18] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $19 constant FLASH_PRIVBB25                 \ [0x19] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1a constant FLASH_PRIVBB26                 \ [0x1a] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1b constant FLASH_PRIVBB27                 \ [0x1b] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1c constant FLASH_PRIVBB28                 \ [0x1c] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1d constant FLASH_PRIVBB29                 \ [0x1d] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1e constant FLASH_PRIVBB30                 \ [0x1e] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1f constant FLASH_PRIVBB31                 \ [0x1f] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
  [then]


  [ifdef] FLASH_FLASH_PRIVBBR3_DEF
    \
    \ @brief FLASH privilege block based register 3
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB0                  \ [0x00] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $01 constant FLASH_PRIVBB1                  \ [0x01] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $02 constant FLASH_PRIVBB2                  \ [0x02] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $03 constant FLASH_PRIVBB3                  \ [0x03] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $04 constant FLASH_PRIVBB4                  \ [0x04] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $05 constant FLASH_PRIVBB5                  \ [0x05] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $06 constant FLASH_PRIVBB6                  \ [0x06] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $07 constant FLASH_PRIVBB7                  \ [0x07] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $08 constant FLASH_PRIVBB8                  \ [0x08] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $09 constant FLASH_PRIVBB9                  \ [0x09] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0a constant FLASH_PRIVBB10                 \ [0x0a] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0b constant FLASH_PRIVBB11                 \ [0x0b] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0c constant FLASH_PRIVBB12                 \ [0x0c] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0d constant FLASH_PRIVBB13                 \ [0x0d] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0e constant FLASH_PRIVBB14                 \ [0x0e] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0f constant FLASH_PRIVBB15                 \ [0x0f] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $10 constant FLASH_PRIVBB16                 \ [0x10] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $11 constant FLASH_PRIVBB17                 \ [0x11] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $12 constant FLASH_PRIVBB18                 \ [0x12] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $13 constant FLASH_PRIVBB19                 \ [0x13] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $14 constant FLASH_PRIVBB20                 \ [0x14] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $15 constant FLASH_PRIVBB21                 \ [0x15] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $16 constant FLASH_PRIVBB22                 \ [0x16] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $17 constant FLASH_PRIVBB23                 \ [0x17] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $18 constant FLASH_PRIVBB24                 \ [0x18] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $19 constant FLASH_PRIVBB25                 \ [0x19] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1a constant FLASH_PRIVBB26                 \ [0x1a] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1b constant FLASH_PRIVBB27                 \ [0x1b] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1c constant FLASH_PRIVBB28                 \ [0x1c] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1d constant FLASH_PRIVBB29                 \ [0x1d] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1e constant FLASH_PRIVBB30                 \ [0x1e] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1f constant FLASH_PRIVBB31                 \ [0x1f] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
  [then]


  [ifdef] FLASH_FLASH_PRIVBBR4_DEF
    \
    \ @brief FLASH privilege block based register 4
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB0                  \ [0x00] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $01 constant FLASH_PRIVBB1                  \ [0x01] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $02 constant FLASH_PRIVBB2                  \ [0x02] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $03 constant FLASH_PRIVBB3                  \ [0x03] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $04 constant FLASH_PRIVBB4                  \ [0x04] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $05 constant FLASH_PRIVBB5                  \ [0x05] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $06 constant FLASH_PRIVBB6                  \ [0x06] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $07 constant FLASH_PRIVBB7                  \ [0x07] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $08 constant FLASH_PRIVBB8                  \ [0x08] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $09 constant FLASH_PRIVBB9                  \ [0x09] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0a constant FLASH_PRIVBB10                 \ [0x0a] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0b constant FLASH_PRIVBB11                 \ [0x0b] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0c constant FLASH_PRIVBB12                 \ [0x0c] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0d constant FLASH_PRIVBB13                 \ [0x0d] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0e constant FLASH_PRIVBB14                 \ [0x0e] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $0f constant FLASH_PRIVBB15                 \ [0x0f] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $10 constant FLASH_PRIVBB16                 \ [0x10] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $11 constant FLASH_PRIVBB17                 \ [0x11] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $12 constant FLASH_PRIVBB18                 \ [0x12] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $13 constant FLASH_PRIVBB19                 \ [0x13] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $14 constant FLASH_PRIVBB20                 \ [0x14] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $15 constant FLASH_PRIVBB21                 \ [0x15] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $16 constant FLASH_PRIVBB22                 \ [0x16] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $17 constant FLASH_PRIVBB23                 \ [0x17] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $18 constant FLASH_PRIVBB24                 \ [0x18] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $19 constant FLASH_PRIVBB25                 \ [0x19] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1a constant FLASH_PRIVBB26                 \ [0x1a] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1b constant FLASH_PRIVBB27                 \ [0x1b] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1c constant FLASH_PRIVBB28                 \ [0x1c] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1d constant FLASH_PRIVBB29                 \ [0x1d] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1e constant FLASH_PRIVBB30                 \ [0x1e] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
    $1f constant FLASH_PRIVBB31                 \ [0x1f] page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
  [then]

  \
  \ @brief Embedded Flash memory
  \
  $00 constant FLASH_FLASH_ACR          \ FLASH access control register
  $08 constant FLASH_FLASH_NSKEYR       \ FLASH key register
  $0C constant FLASH_FLASH_SECKEYR      \ FLASH secure key register
  $10 constant FLASH_FLASH_OPTKEYR      \ FLASH option key register
  $18 constant FLASH_FLASH_PDKEYR       \ FLASH power-down key register
  $20 constant FLASH_FLASH_NSSR         \ FLASH status register
  $24 constant FLASH_FLASH_SECSR        \ FLASH secure status register
  $28 constant FLASH_FLASH_NSCR1        \ FLASH control register
  $2C constant FLASH_FLASH_SECCR1       \ FLASH secure control register
  $30 constant FLASH_FLASH_ECCR         \ FLASH ECC register
  $34 constant FLASH_FLASH_OPSR         \ FLASH operation status register
  $38 constant FLASH_FLASH_NSCR2        \ FLASH control 2 register
  $3C constant FLASH_FLASH_SECCR2       \ FLASH secure control 2 register
  $40 constant FLASH_FLASH_OPTR         \ FLASH option register
  $44 constant FLASH_FLASH_NSBOOTADD0R  \ FLASH boot address 0 register
  $48 constant FLASH_FLASH_NSBOOTADD1R  \ FLASH boot address 1 register
  $4C constant FLASH_FLASH_SECBOOTADD0R \ FLASH secure boot address 0 register
  $50 constant FLASH_FLASH_SECWMR1      \ FLASH secure watermark register 1
  $54 constant FLASH_FLASH_SECWMR2      \ FLASH secure watermark register 2
  $58 constant FLASH_FLASH_WRPAR        \ FLASH WRP area A address register
  $5C constant FLASH_FLASH_WRPBR        \ FLASH WRP area B address register
  $70 constant FLASH_FLASH_OEM1KEYR1    \ FLASH OEM1 key register 1
  $74 constant FLASH_FLASH_OEM1KEYR2    \ FLASH OEM1 key register 2
  $78 constant FLASH_FLASH_OEM2KEYR1    \ FLASH OEM2 key register 1
  $7C constant FLASH_FLASH_OEM2KEYR2    \ FLASH OEM2 key register 2
  $80 constant FLASH_FLASH_SECBBR1      \ FLASH secure block based register 1
  $84 constant FLASH_FLASH_SECBBR2      \ FLASH secure block based register 2
  $C0 constant FLASH_FLASH_SECHDPCR     \ FLASH secure HDP control register
  $C4 constant FLASH_FLASH_PRIFCFGR     \ FLASH privilege configuration register
  $D0 constant FLASH_FLASH_PRIVBBR1     \ FLASH privilege block based register 1
  $D4 constant FLASH_FLASH_PRIVBBR2     \ FLASH privilege block based register 2
  $D8 constant FLASH_FLASH_PRIVBBR3     \ FLASH privilege block based register 3
  $DC constant FLASH_FLASH_PRIVBBR4     \ FLASH privilege block based register 4

: FLASH_DEF ; [then]
