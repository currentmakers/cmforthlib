\
\ @file sec_flash.fs
\ @brief Embedded Flash memory
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FLASH access control register
\ Address offset: 0x00
\ Reset value: 0x00000001
\

$0000000f constant SEC_FLASH_FLASH_ACR_LATENCY                      \ Latency These bits represent the ratio between the AHB hclk1 clock period and the Flash memory access time. Access to the bit can be secured by RCC SYSCLKSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with FLASH SPRIV or when non-secure with FLASH NSPRIV. ... Note: Before entering Stop 1 mode software must set FLASH wait state latency to at least 1.
$00000100 constant SEC_FLASH_FLASH_ACR_PRFTEN                       \ Prefetch enable This bit enables the prefetch buffer in the embedded Flash memory. This bit can be protected against unprivileged access by FLASH NSPRIV.
$00000800 constant SEC_FLASH_FLASH_ACR_LPM                          \ Low-power read mode This bit puts the Flash memory in low-power read mode. Access to the bit can be secured by PWR LPMSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with FLASH SPRIV or when non-secure with FLASH NSPRIV. This bit can't be written when a Flash program or erase operation is busy (BSY = 1) or when the write buffer is not empty (WDW = 1). Changing this bit while a Flash program or erase operation is busy (BSY = 1) is rejected.
$00001000 constant SEC_FLASH_FLASH_ACR_PDREQ                        \ Flash power-down mode request This bit requests Flash to enter power-down mode. When Flash enters power-down mode, this bit is cleared by hardware and the PDKEYR is locked. This bit is write-protected with FLASH_PDKEYR. Access to the bit can be secured by PWR LPMSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with FLASH SPRIV or when non-secure with FLASH NSPRIV.
$00004000 constant SEC_FLASH_FLASH_ACR_SLEEP_PD                     \ Flash memory power-down mode during Sleep mode This bit determines whether the Flash memory is in power-down mode or Idle mode when the device is in Sleep mode. Access to the bit can be secured by PWR LPMSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with FLASH SPRIV or when non-secure with FLASH NSPRIV. The Flash must not be put in power-down while a program or an erase operation is ongoing.


\
\ @brief FLASH key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_FLASH_NSKEYR_NSKEY                     \ Flash memory non-secure key The following values must be written consecutively to unlock the FLASH_NSCR1 register, allowing the Flash memory non-secure programming/erasing operations: KEY1: 0x45670123 KEY2: 0xCDEF89AB


\
\ @brief FLASH secure key register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_FLASH_SECKEYR_SECKEY                   \ Flash memory secure key The following values must be written consecutively to unlock the FLASH_SECCR1 register, allowing the Flash memory secure programming/erasing operations: KEY1: 0x45670123 KEY2: 0xCDEF89AB


\
\ @brief FLASH option key register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_FLASH_OPTKEYR_OPTKEY                   \ Option byte key The LOCK bit in the FLASH_NSCR1 must be cleared before doing the unlock sequence for OPTLOCK bit. The following values must be written consecutively to unlock the FLASH_NSCR1.OPTSTRT and OBL_LAUNCH register bits concerning user option operations: KEY1: 0x08192A3B KEY2: 0x4C5D6E7F


\
\ @brief FLASH power-down key register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_FLASH_PDKEYR_PDKEY1                    \ Flash power-down key The following values must be written consecutively to unlock the PDREQ bit in FLASH_ACR: PDKEY_1: 0x04152637 PDKEY_2: 0xFAFBFCFD


\
\ @brief FLASH status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_NSSR_EOP                         \ Non-secure end of operation This bit is set by hardware when one or more Flash memory non-secure operation (program/erase) has been completed successfully. This bit is set only if the non-secure end of operation interrupts are enabled (EOPIE = 1 in FLASH_NSCR1). This bit is cleared by writing1.
$00000002 constant SEC_FLASH_FLASH_NSSR_OPERR                       \ Non-secure operation error This bit is set by hardware when a Flash memory non-secure operation (program/erase) completes unsuccessfully. This bit is set only if non-secure error interrupts are enabled (NSERRIE = 1). This bit is cleared by writing 1.
$00000008 constant SEC_FLASH_FLASH_NSSR_PROGERR                     \ Non-secure programming error This bit is set by hardware when a non-secure quad-word address to be programmed contains a value different from all 1 before programming, except if the data to write is all 0. This bit is cleared by writing 1.
$00000010 constant SEC_FLASH_FLASH_NSSR_WRPERR                      \ Non-secure write protection error This bit is set by hardware when a non-secure address to be erased/programmed belongs to a write-protected part (by WRP or HDP) of the Flash memory. This bit is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
$00000020 constant SEC_FLASH_FLASH_NSSR_PGAERR                      \ Non-secure programming alignment error This bit is set by hardware when the first word to be programmed is not aligned with a quad-word address, or the second, third or forth word does not belong to the same quad-word address. This bit is cleared by writing 1.
$00000040 constant SEC_FLASH_FLASH_NSSR_SIZERR                      \ Non-secure size error This bit is set by hardware when the size of the access is a byte or half-word during a non-secure program sequence. Only quad-word programming is allowed by means of successive word accesses. This bit is cleared by writing 1.
$00000080 constant SEC_FLASH_FLASH_NSSR_PGSERR                      \ Non-secure programming sequence error This bit is set by hardware when programming sequence is not correct. It is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
$00002000 constant SEC_FLASH_FLASH_NSSR_OPTWERR                     \ Option write error This bit is set by hardware when the options bytes are written with an invalid configuration or when modifying options in RDP level 2.. It is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
$00010000 constant SEC_FLASH_FLASH_NSSR_BSY                         \ Non-secure busy This indicates that a Flash memory secure or non-secure operation is in progress. This bit is set at the beginning of a Flash operation and reset when the operation finishes or when an error occurs.
$00020000 constant SEC_FLASH_FLASH_NSSR_WDW                         \ Non-secure wait data to write This bit indicates that the Flash memory write buffer has been written by a secure or non-secure operation. It is set when the first data is stored in the buffer and cleared when the write is performed in the Flash memory.
$00040000 constant SEC_FLASH_FLASH_NSSR_OEM1LOCK                    \ OEM1 key RDP lock This bit indicates that the OEM1 key read during the OBL is not virgin. When set, the OEM1 key RDP lock mechanism is active.
$00080000 constant SEC_FLASH_FLASH_NSSR_OEM2LOCK                    \ OEM2 key RDP lock This bit indicates that the OEM2 key read during the OBL is not virgin. When set, the OEM2 key RDP lock mechanism is active.
$00100000 constant SEC_FLASH_FLASH_NSSR_PD                          \ Flash in power-down mode This bit indicates that the Flash memory is in power-down state. It is reset when Flash is in normal mode or being awaken.


\
\ @brief FLASH secure status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_SECSR_EOP                        \ Secure end of operation This bit is set by hardware when one or more Flash memory secure operation (program/erase) has been completed successfully. This bit is set only if the secure end of operation interrupts are enabled (EOPIE = 1 in FLASH_SECCR1). This bit is cleared by writing1.
$00000002 constant SEC_FLASH_FLASH_SECSR_OPERR                      \ Secure operation error This bit is set by hardware when a Flash memory secure operation (program/erase) completes unsuccessfully. This bit is set only if secure error interrupts are enabled (SECERRIE = 1). This bit is cleared by writing 1.
$00000008 constant SEC_FLASH_FLASH_SECSR_PROGERR                    \ Secure programming error This bit is set by hardware when a secure quad-word address to be programmed contains a value different from all 1 before programming, except if the data to write is all 0. This bit is cleared by writing 1.
$00000010 constant SEC_FLASH_FLASH_SECSR_WRPERR                     \ Secure write protection error This bit is set by hardware when an secure address to be erased/programmed belongs to a write-protected part (by WRP or HDP) of the Flash memory. This bit is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
$00000020 constant SEC_FLASH_FLASH_SECSR_PGAERR                     \ Secure programming alignment error This bit is set by hardware when the first word to be programmed is not aligned with a quad-word address, or the second, third or forth word does not belong to the same quad-word address.This bit is cleared by writing 1.
$00000040 constant SEC_FLASH_FLASH_SECSR_SIZERR                     \ Secure size error This bit is set by hardware when the size of the access is a byte or half-word during a secure program sequence. Only quad-word programming is allowed by means of successive word accesses.This bit is cleared by writing 1.
$00000080 constant SEC_FLASH_FLASH_SECSR_PGSERR                     \ Secure programming sequence error This bit is set by hardware when programming sequence is not correct. It is cleared by writing 1. Refer to Section7.3.10: Flash memory errors flags for full conditions of error flag setting.
$00010000 constant SEC_FLASH_FLASH_SECSR_BSY                        \ Secure busy This bit indicates that a Flash memory secure or non-secure operation is in progress. This is set on the beginning of a Flash operation and reset when the operation finishes or when an error occurs.
$00020000 constant SEC_FLASH_FLASH_SECSR_WDW                        \ Secure wait data to write This bit indicates that the Flash memory write buffer has been written by a secure or non-secure operation. It is set when the first data is stored in the buffer and cleared when the write is performed in the Flash memory.


\
\ @brief FLASH control register
\ Address offset: 0x28
\ Reset value: 0xC0000000
\

$00000001 constant SEC_FLASH_FLASH_NSCR1_PG                         \ Non-secure programming
$00000002 constant SEC_FLASH_FLASH_NSCR1_PER                        \ Non-secure page erase
$00000004 constant SEC_FLASH_FLASH_NSCR1_MER                        \ Non-secure Flash mass erase This bit triggers the Flash non-secure mass erase (all Flash user pages) when set.
$000003f8 constant SEC_FLASH_FLASH_NSCR1_PNB                        \ Non-secure page number selection These bits select the page to erase. ... Note that bit 9 is reserved on STM32WBA5xEx devices.
$00004000 constant SEC_FLASH_FLASH_NSCR1_BWR                        \ Non-secure burst write programming mode When set, this bit selects the burst write programming mode.
$00010000 constant SEC_FLASH_FLASH_NSCR1_STRT                       \ Non-secure operation start This bit triggers a non-secure erase operation when set. If MER and PER bits are reset and the STRT bit is set, the PGSERR bit in FLASH_NSSR is set (this condition is forbidden). This bit is set only by software and is cleared when the BSY bit is cleared in FLASH_NSSR.
$00020000 constant SEC_FLASH_FLASH_NSCR1_OPTSTRT                    \ Options modification start This bit triggers an option bytes erase and program operation when set. This bit is write-protected with OPTLOCK.. This bit is set only by software, and is cleared when the BSY bit is cleared in FLASH_NSSR.
$01000000 constant SEC_FLASH_FLASH_NSCR1_EOPIE                      \ Non-secure end of operation interrupt enable This bit enables the interrupt generation when the EOP bit in the FLASH_NSSR is set to 1.
$02000000 constant SEC_FLASH_FLASH_NSCR1_ERRIE                      \ Non-secure error interrupt enable This bit enables the interrupt generation when the OPERR bit in the FLASH_NSSR is set to 1.
$08000000 constant SEC_FLASH_FLASH_NSCR1_OBL_LAUNCH                 \ Force the option byte loading When set to 1, this bit forces the option byte reloading. This bit is cleared only when the option byte loading is complete. This bit is write-protected with OPTLOCK. Note: The LSE oscillator must be disabled, LSEON = 0 and LSERDY = 0, before starting OBL_LAUNCH.
$40000000 constant SEC_FLASH_FLASH_NSCR1_OPTLOCK                    \ Option lock This bit is set only. When set, the FLASH_NSCR1.OPTSRT and OBL_LAUNCH bits concerning user options write access is locked. This bit is cleared by hardware after detecting the unlock sequence in FLASH_OPTKEYR. The FLASH_NSCR1.LOCK bit must be cleared before doing the FLASH_OPTKEYR unlock sequence. In case of an unsuccessful unlock operation, this bit remains set until the next reset.
$80000000 constant SEC_FLASH_FLASH_NSCR1_LOCK                       \ Non-secure lock This bit is set only. When set, the FLASH_NSCR1 register write access is locked. This bit is cleared by hardware after detecting the unlock sequence in FLASH_NSKEYR. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.


\
\ @brief FLASH secure control register
\ Address offset: 0x2C
\ Reset value: 0x80000000
\

$00000001 constant SEC_FLASH_FLASH_SECCR1_PG                        \ Secure programming
$00000002 constant SEC_FLASH_FLASH_SECCR1_PER                       \ Secure page erase
$00000004 constant SEC_FLASH_FLASH_SECCR1_MER                       \ Secure Flash mass erase This bit triggers the Flash secure mass erase (all Flash user pages) when set.
$000003f8 constant SEC_FLASH_FLASH_SECCR1_PNB                       \ Secure page number selection These bits select the page to erase: ... Note that bit 9 is reserved on STM32WBA5xEx devices.
$00004000 constant SEC_FLASH_FLASH_SECCR1_BWR                       \ Secure burst write programming mode When set, this bit selects the burst write programming mode.
$00010000 constant SEC_FLASH_FLASH_SECCR1_STRT                      \ Secure start This bit triggers a secure erase operation when set. If MER and PER bits are reset and the STRT bit is set, the PGSERR in the FLASH_SECSR is set (this condition is forbidden). This bit is set only by software and is cleared when the BSY bit is cleared in FLASH_SECSR.
$01000000 constant SEC_FLASH_FLASH_SECCR1_EOPIE                     \ Secure End of operation interrupt enable This bit enables the interrupt generation when the EOP bit in FLASH_SECSR is set to 1.
$02000000 constant SEC_FLASH_FLASH_SECCR1_ERRIE                     \ Secure error interrupt enable This bit enables the interrupt generation when the OPERR bit in FLASH_SECSR is set to 1.
$20000000 constant SEC_FLASH_FLASH_SECCR1_INV                       \ Flash memory security state invert This bit inverts the Flash memory security state.
$80000000 constant SEC_FLASH_FLASH_SECCR1_LOCK                      \ Secure lock This bit is set only. When set, the FLASH_SECCR1 register is locked. It is cleared by hardware after detecting the unlock sequence in FLASH_SECKEYR register. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.


\
\ @brief FLASH ECC register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000fffff constant SEC_FLASH_FLASH_ECCR_ADDR_ECC                    \ ECC fail address This field indicates which address is concerned by the ECC error correction or by the double ECC error detection. The address is given relative to Flash base address, from offset 0x00000 to 0xFFFF0. Note that bit 19 is reserved on STM32WBAxEx devices.
$00400000 constant SEC_FLASH_FLASH_ECCR_SYSF_ECC                    \ System Flash memory ECC fail This bit indicates that the ECC error correction or double ECC error detection is located in the system Flash memory.
$01000000 constant SEC_FLASH_FLASH_ECCR_ECCIE                       \ ECC correction interrupt enable This bit enables the interrupt generation when the ECCC bit in the FLASH_ECCR register is set.
$40000000 constant SEC_FLASH_FLASH_ECCR_ECCC                        \ ECC correction This bit is set by hardware when one ECC error has been detected and corrected (only if ECCC and ECCD were previously cleared). An interrupt is generated if ECCIE is set. This bit is cleared by writing 1.
$80000000 constant SEC_FLASH_FLASH_ECCR_ECCD                        \ ECC detection This bit is set by hardware when two ECC errors have been detected (only if ECCC and ECCD were previously cleared). When this bit is set, a NMI is generated. This bit is cleared by writing 1.


\
\ @brief FLASH operation status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant SEC_FLASH_FLASH_OPSR_ADDR_OP                     \ Interrupted operation address This field indicates which address in the Flash memory was accessed when reset occurred. The address is given relative to the Flash base address, from offset 0x00000 to 0xFFFF0. Note that bit 19 is reserved on STM32WBAxEx devices.
$00400000 constant SEC_FLASH_FLASH_OPSR_SYSF_OP                     \ Operation in system Flash memory interrupted This bit indicates that the reset occurred during an operation in the system Flash memory.
$e0000000 constant SEC_FLASH_FLASH_OPSR_CODE_OP                     \ Flash memory operation code This field indicates which Flash memory operation has been interrupted by a system reset:


\
\ @brief FLASH control 2 register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_NSCR2_PS                         \ Program suspend request
$00000002 constant SEC_FLASH_FLASH_NSCR2_ES                         \ Erase suspend request


\
\ @brief FLASH secure control 2 register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_SECCR2_PS                        \ Program suspend request
$00000002 constant SEC_FLASH_FLASH_SECCR2_ES                        \ Erase suspend request


\
\ @brief FLASH option register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant SEC_FLASH_FLASH_OPTR_RDP                         \ Readout protection level Others: Level 1 (memories readout protection active) Note: Refer to Section7.6.2: Readout protection (RDP) for more details.
$00000700 constant SEC_FLASH_FLASH_OPTR_BOR_LEV                     \ BOR reset level These bits contain the VsubDD/sub supply level threshold that activates/releases the reset.
$00001000 constant SEC_FLASH_FLASH_OPTR_NRST_STOP                   \ Reset generation in Stop mode
$00002000 constant SEC_FLASH_FLASH_OPTR_NRST_STDBY                  \ Reset generation in Standby mode
$00008000 constant SEC_FLASH_FLASH_OPTR_SRAM1_RST                   \ SRAM1 erase upon system reset
$00010000 constant SEC_FLASH_FLASH_OPTR_IWDG_SW                     \ Independent watchdog enable selection
$00020000 constant SEC_FLASH_FLASH_OPTR_IWDG_STOP                   \ Independent watchdog counter freeze in Stop mode
$00040000 constant SEC_FLASH_FLASH_OPTR_IWDG_STDBY                  \ Independent watchdog counter freeze in Standby mode
$00080000 constant SEC_FLASH_FLASH_OPTR_WWDG_SW                     \ Window watchdog selection
$01000000 constant SEC_FLASH_FLASH_OPTR_SRAM2_PE                    \ SRAM2 parity check enable
$02000000 constant SEC_FLASH_FLASH_OPTR_SRAM2_RST                   \ SRAM2 erase when system reset
$04000000 constant SEC_FLASH_FLASH_OPTR_NSWBOOT0                    \ Software BOOT0
$08000000 constant SEC_FLASH_FLASH_OPTR_NBOOT0                      \ NBOOT0 option bit
$80000000 constant SEC_FLASH_FLASH_OPTR_TZEN                        \ Global TrustZone security enable


\
\ @brief FLASH boot address 0 register
\ Address offset: 0x44
\ Reset value: 0x0000000F
\

$ffffff80 constant SEC_FLASH_FLASH_NSBOOTADD0R_NSBOOTADD0           \ Non-secure boot base address 0 This address is only used when TZEN = 0. The non-secure boot memory address can be programmed to any address in the valid address range (see Table 28: Boot space versus RDP protection) with a granularity of 128 bytes. These bits correspond to address [31:7]. The NSBOOTADD0 option bytes are selected following the BOOT0 pin or NSWBOOT0 state. Examples: NSBOOTADD0[24:0] = 0x0100000: Boot from Flash memory (0x0800 0000) NSBOOTADD0[24:0] = 0x017F100: Boot from system memory bootloader (0x0BF8 8000) NSBOOTADD0[24:0] = 0x0400200: Boot from SRAM2 on S-Bus (0x2001 0000)


\
\ @brief FLASH boot address 1 register
\ Address offset: 0x48
\ Reset value: 0x0000000F
\

$ffffff80 constant SEC_FLASH_FLASH_NSBOOTADD1R_NSBOOTADD1           \ Non-secure boot address 1 This address is only used when TZEN = 0. The non-secure boot memory address can be programmed to any address in the valid address range (see Table 28: Boot space versus RDP protection) with a granularity of 128 bytes. These bits correspond to address [31:7]. The NSBOOTADD0 option bytes are selected following the BOOT0 pin or NSWBOOT0 state. Examples: NSBOOTADD1[24:0] = 0x0100000: Boot from Flash memory (0x0800 0000) NSBOOTADD1[24:0] = 0x017F100: Boot from system memory bootloader (0x0BF8 8000) NSBOOTADD1[24:0] = 0x0400200: Boot from SRAM2 (0x2001 0000)


\
\ @brief FLASH secure boot address 0 register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_SECBOOTADD0R_BOOT_LOCK           \ Boot lock This lock is only used when TZEN = 0. When set, the boot is always forced to base address value programmed in SECBOOTADD0[24:0] option bytes whatever the boot selection option. When set, this bit can only be cleared by an RDP regression level 1 to level 0.
$ffffff80 constant SEC_FLASH_FLASH_SECBOOTADD0R_SECBOOTADD0         \ Secure boot base address 0 This address is only used when TZEN = 1. The secure boot memory address can be programmed to any address in the valid address range (see Table28: Boot space versus RDP protection) with a granularity of 128 bytes. This bits correspond to address [31:7] The SECBOOTADD0 option bytes are selected following the BOOT0 pin or NSWBOOT0 state. Examples: SECBOOTADD0[24:0] = 0x018 0000: Boot from secure user Flash memory (0x0C00 0000) SECBOOTADD0[24:0] = 0x01F F000: Boot from RSS system Flash memory (0x0FF8 0000) SECBOOTADD0[24:0] = 0x060 0000: Boot from secure SRAM1 on S-Bus (0x3000 0000)


\
\ @brief FLASH secure watermark register 1
\ Address offset: 0x50
\ Reset value: 0xFF00FF00
\

$0000007f constant SEC_FLASH_FLASH_SECWMR1_SECWM_PSTRT              \ Start page of secure area This field contains the first page of the secure area.
$007f0000 constant SEC_FLASH_FLASH_SECWMR1_SECWM_PEND               \ End page of secure area This field contains the last page of the secure area.


\
\ @brief FLASH secure watermark register 2
\ Address offset: 0x54
\ Reset value: 0x0F000F00
\

$007f0000 constant SEC_FLASH_FLASH_SECWMR2_HDP_PEND                 \ End page of secure hide protection area This field contains the last page of the secure HDP area.
$80000000 constant SEC_FLASH_FLASH_SECWMR2_HDPEN                    \ Secure Hide protection area enable


\
\ @brief FLASH WRP area A address register
\ Address offset: 0x58
\ Reset value: 0x0F00FF00
\

$0000007f constant SEC_FLASH_FLASH_WRPAR_WRPA_PSTRT                 \ WPR area A start page This field contains the first page of the WPR area A. Note that bit 6 is reserved on STM32WBAxEx devices.
$007f0000 constant SEC_FLASH_FLASH_WRPAR_WRPA_PEND                  \ WPR area A end page This field contains the last page of the WPR area A. Note that bit 22 is reserved on STM32WBAxEx devices.
$80000000 constant SEC_FLASH_FLASH_WRPAR_UNLOCK                     \ WPR area A unlock


\
\ @brief FLASH WRP area B address register
\ Address offset: 0x5C
\ Reset value: 0x0F00FF00
\

$0000007f constant SEC_FLASH_FLASH_WRPBR_WRPB_PSTRT                 \ WRP area B start page This field contains the first page of the WRP area B. Note that bit 6 is reserved on STM32WBAxEx devices.
$007f0000 constant SEC_FLASH_FLASH_WRPBR_WRPB_PEND                  \ WRP area B end page This field contains the last page of the WRP area B. Note that bit 22 is reserved on STM32WBAxEx devices.
$80000000 constant SEC_FLASH_FLASH_WRPBR_UNLOCK                     \ WPR area B unlock


\
\ @brief FLASH OEM1 key register 1
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_FLASH_OEM1KEYR1_OEM1KEY                \ OEM1 key least significant bytes


\
\ @brief FLASH OEM1 key register 2
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_FLASH_OEM1KEYR2_OEM1KEY                \ OEM1 key most significant bytes


\
\ @brief FLASH OEM2 key register 1
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_FLASH_OEM2KEYR1_OEM2KEY                \ OEM2 key least significant bytes


\
\ @brief FLASH OEM2 key register 2
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_FLASH_OEM2KEYR2_OEM2KEY                \ OEM2 key most significant bytes


\
\ @brief FLASH secure block based register 1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_SECBBR1_SECBB0                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000002 constant SEC_FLASH_FLASH_SECBBR1_SECBB1                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000004 constant SEC_FLASH_FLASH_SECBBR1_SECBB2                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000008 constant SEC_FLASH_FLASH_SECBBR1_SECBB3                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000010 constant SEC_FLASH_FLASH_SECBBR1_SECBB4                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000020 constant SEC_FLASH_FLASH_SECBBR1_SECBB5                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000040 constant SEC_FLASH_FLASH_SECBBR1_SECBB6                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000080 constant SEC_FLASH_FLASH_SECBBR1_SECBB7                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000100 constant SEC_FLASH_FLASH_SECBBR1_SECBB8                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000200 constant SEC_FLASH_FLASH_SECBBR1_SECBB9                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000400 constant SEC_FLASH_FLASH_SECBBR1_SECBB10                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000800 constant SEC_FLASH_FLASH_SECBBR1_SECBB11                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00001000 constant SEC_FLASH_FLASH_SECBBR1_SECBB12                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00002000 constant SEC_FLASH_FLASH_SECBBR1_SECBB13                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00004000 constant SEC_FLASH_FLASH_SECBBR1_SECBB14                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00008000 constant SEC_FLASH_FLASH_SECBBR1_SECBB15                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00010000 constant SEC_FLASH_FLASH_SECBBR1_SECBB16                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00020000 constant SEC_FLASH_FLASH_SECBBR1_SECBB17                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00040000 constant SEC_FLASH_FLASH_SECBBR1_SECBB18                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00080000 constant SEC_FLASH_FLASH_SECBBR1_SECBB19                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00100000 constant SEC_FLASH_FLASH_SECBBR1_SECBB20                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00200000 constant SEC_FLASH_FLASH_SECBBR1_SECBB21                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00400000 constant SEC_FLASH_FLASH_SECBBR1_SECBB22                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00800000 constant SEC_FLASH_FLASH_SECBBR1_SECBB23                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$01000000 constant SEC_FLASH_FLASH_SECBBR1_SECBB24                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$02000000 constant SEC_FLASH_FLASH_SECBBR1_SECBB25                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$04000000 constant SEC_FLASH_FLASH_SECBBR1_SECBB26                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$08000000 constant SEC_FLASH_FLASH_SECBBR1_SECBB27                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$10000000 constant SEC_FLASH_FLASH_SECBBR1_SECBB28                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$20000000 constant SEC_FLASH_FLASH_SECBBR1_SECBB29                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$40000000 constant SEC_FLASH_FLASH_SECBBR1_SECBB30                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$80000000 constant SEC_FLASH_FLASH_SECBBR1_SECBB31                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.


\
\ @brief FLASH secure block based register 2
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_SECBBR2_SECBB0                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000002 constant SEC_FLASH_FLASH_SECBBR2_SECBB1                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000004 constant SEC_FLASH_FLASH_SECBBR2_SECBB2                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000008 constant SEC_FLASH_FLASH_SECBBR2_SECBB3                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000010 constant SEC_FLASH_FLASH_SECBBR2_SECBB4                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000020 constant SEC_FLASH_FLASH_SECBBR2_SECBB5                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000040 constant SEC_FLASH_FLASH_SECBBR2_SECBB6                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000080 constant SEC_FLASH_FLASH_SECBBR2_SECBB7                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000100 constant SEC_FLASH_FLASH_SECBBR2_SECBB8                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000200 constant SEC_FLASH_FLASH_SECBBR2_SECBB9                   \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000400 constant SEC_FLASH_FLASH_SECBBR2_SECBB10                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00000800 constant SEC_FLASH_FLASH_SECBBR2_SECBB11                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00001000 constant SEC_FLASH_FLASH_SECBBR2_SECBB12                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00002000 constant SEC_FLASH_FLASH_SECBBR2_SECBB13                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00004000 constant SEC_FLASH_FLASH_SECBBR2_SECBB14                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00008000 constant SEC_FLASH_FLASH_SECBBR2_SECBB15                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00010000 constant SEC_FLASH_FLASH_SECBBR2_SECBB16                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00020000 constant SEC_FLASH_FLASH_SECBBR2_SECBB17                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00040000 constant SEC_FLASH_FLASH_SECBBR2_SECBB18                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00080000 constant SEC_FLASH_FLASH_SECBBR2_SECBB19                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00100000 constant SEC_FLASH_FLASH_SECBBR2_SECBB20                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00200000 constant SEC_FLASH_FLASH_SECBBR2_SECBB21                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00400000 constant SEC_FLASH_FLASH_SECBBR2_SECBB22                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$00800000 constant SEC_FLASH_FLASH_SECBBR2_SECBB23                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$01000000 constant SEC_FLASH_FLASH_SECBBR2_SECBB24                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$02000000 constant SEC_FLASH_FLASH_SECBBR2_SECBB25                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$04000000 constant SEC_FLASH_FLASH_SECBBR2_SECBB26                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$08000000 constant SEC_FLASH_FLASH_SECBBR2_SECBB27                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$10000000 constant SEC_FLASH_FLASH_SECBBR2_SECBB28                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$20000000 constant SEC_FLASH_FLASH_SECBBR2_SECBB29                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$40000000 constant SEC_FLASH_FLASH_SECBBR2_SECBB30                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.
$80000000 constant SEC_FLASH_FLASH_SECBBR2_SECBB31                  \ page secure/non-secure attribution Each bit is used to set one page security attribution.


\
\ @brief FLASH secure HDP control register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_SECHDPCR_HDP_ACCDIS              \ Secure HDP area access disable When set, this bit is only cleared by a system reset.


\
\ @brief FLASH privilege configuration register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_PRIFCFGR_SPRIV                   \ Privileged protection for secure registers This bit is secure write protected. It can only be written by a secure privileged access when TrustZone is enabled (TZEN=1).
$00000002 constant SEC_FLASH_FLASH_PRIFCFGR_NSPRIV                  \ Privileged protection for non-secure registers


\
\ @brief FLASH privilege block based register 1
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB0                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000002 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB1                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000004 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB2                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000008 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB3                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000010 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB4                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000020 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB5                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000040 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB6                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000080 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB7                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000100 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB8                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000200 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB9                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000400 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB10                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000800 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB11                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00001000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB12                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00002000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB13                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00004000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB14                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00008000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB15                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00010000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB16                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00020000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB17                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00040000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB18                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00080000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB19                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00100000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB20                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00200000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB21                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00400000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB22                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00800000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB23                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$01000000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB24                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$02000000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB25                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$04000000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB26                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$08000000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB27                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$10000000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB28                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$20000000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB29                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$40000000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB30                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$80000000 constant SEC_FLASH_FLASH_PRIVBBR1_PRIVBB31                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.


\
\ @brief FLASH privilege block based register 2
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB0                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000002 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB1                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000004 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB2                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000008 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB3                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000010 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB4                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000020 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB5                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000040 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB6                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000080 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB7                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000100 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB8                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000200 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB9                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000400 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB10                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000800 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB11                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00001000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB12                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00002000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB13                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00004000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB14                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00008000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB15                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00010000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB16                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00020000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB17                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00040000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB18                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00080000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB19                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00100000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB20                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00200000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB21                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00400000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB22                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00800000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB23                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$01000000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB24                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$02000000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB25                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$04000000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB26                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$08000000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB27                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$10000000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB28                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$20000000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB29                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$40000000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB30                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$80000000 constant SEC_FLASH_FLASH_PRIVBBR2_PRIVBB31                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.


\
\ @brief FLASH privilege block based register 3
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB0                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000002 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB1                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000004 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB2                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000008 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB3                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000010 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB4                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000020 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB5                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000040 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB6                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000080 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB7                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000100 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB8                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000200 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB9                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000400 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB10                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000800 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB11                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00001000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB12                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00002000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB13                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00004000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB14                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00008000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB15                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00010000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB16                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00020000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB17                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00040000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB18                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00080000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB19                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00100000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB20                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00200000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB21                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00400000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB22                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00800000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB23                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$01000000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB24                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$02000000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB25                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$04000000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB26                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$08000000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB27                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$10000000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB28                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$20000000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB29                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$40000000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB30                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$80000000 constant SEC_FLASH_FLASH_PRIVBBR3_PRIVBB31                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.


\
\ @brief FLASH privilege block based register 4
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB0                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000002 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB1                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000004 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB2                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000008 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB3                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000010 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB4                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000020 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB5                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000040 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB6                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000080 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB7                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000100 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB8                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000200 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB9                 \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000400 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB10                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00000800 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB11                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00001000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB12                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00002000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB13                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00004000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB14                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00008000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB15                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00010000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB16                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00020000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB17                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00040000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB18                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00080000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB19                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00100000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB20                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00200000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB21                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00400000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB22                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$00800000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB23                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$01000000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB24                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$02000000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB25                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$04000000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB26                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$08000000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB27                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$10000000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB28                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$20000000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB29                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$40000000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB30                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.
$80000000 constant SEC_FLASH_FLASH_PRIVBBR4_PRIVBB31                \ page privileged/unprivileged attribution Each bit is used to set one page privilege attribution in Flash.


\
\ @brief Embedded Flash memory
\
$50022000 constant SEC_FLASH_FLASH_ACR  \ offset: 0x00 : FLASH access control register
$50022008 constant SEC_FLASH_FLASH_NSKEYR  \ offset: 0x08 : FLASH key register
$5002200c constant SEC_FLASH_FLASH_SECKEYR  \ offset: 0x0C : FLASH secure key register
$50022010 constant SEC_FLASH_FLASH_OPTKEYR  \ offset: 0x10 : FLASH option key register
$50022018 constant SEC_FLASH_FLASH_PDKEYR  \ offset: 0x18 : FLASH power-down key register
$50022020 constant SEC_FLASH_FLASH_NSSR  \ offset: 0x20 : FLASH status register
$50022024 constant SEC_FLASH_FLASH_SECSR  \ offset: 0x24 : FLASH secure status register
$50022028 constant SEC_FLASH_FLASH_NSCR1  \ offset: 0x28 : FLASH control register
$5002202c constant SEC_FLASH_FLASH_SECCR1  \ offset: 0x2C : FLASH secure control register
$50022030 constant SEC_FLASH_FLASH_ECCR  \ offset: 0x30 : FLASH ECC register
$50022034 constant SEC_FLASH_FLASH_OPSR  \ offset: 0x34 : FLASH operation status register
$50022038 constant SEC_FLASH_FLASH_NSCR2  \ offset: 0x38 : FLASH control 2 register
$5002203c constant SEC_FLASH_FLASH_SECCR2  \ offset: 0x3C : FLASH secure control 2 register
$50022040 constant SEC_FLASH_FLASH_OPTR  \ offset: 0x40 : FLASH option register
$50022044 constant SEC_FLASH_FLASH_NSBOOTADD0R  \ offset: 0x44 : FLASH boot address 0 register
$50022048 constant SEC_FLASH_FLASH_NSBOOTADD1R  \ offset: 0x48 : FLASH boot address 1 register
$5002204c constant SEC_FLASH_FLASH_SECBOOTADD0R  \ offset: 0x4C : FLASH secure boot address 0 register
$50022050 constant SEC_FLASH_FLASH_SECWMR1  \ offset: 0x50 : FLASH secure watermark register 1
$50022054 constant SEC_FLASH_FLASH_SECWMR2  \ offset: 0x54 : FLASH secure watermark register 2
$50022058 constant SEC_FLASH_FLASH_WRPAR  \ offset: 0x58 : FLASH WRP area A address register
$5002205c constant SEC_FLASH_FLASH_WRPBR  \ offset: 0x5C : FLASH WRP area B address register
$50022070 constant SEC_FLASH_FLASH_OEM1KEYR1  \ offset: 0x70 : FLASH OEM1 key register 1
$50022074 constant SEC_FLASH_FLASH_OEM1KEYR2  \ offset: 0x74 : FLASH OEM1 key register 2
$50022078 constant SEC_FLASH_FLASH_OEM2KEYR1  \ offset: 0x78 : FLASH OEM2 key register 1
$5002207c constant SEC_FLASH_FLASH_OEM2KEYR2  \ offset: 0x7C : FLASH OEM2 key register 2
$50022080 constant SEC_FLASH_FLASH_SECBBR1  \ offset: 0x80 : FLASH secure block based register 1
$50022084 constant SEC_FLASH_FLASH_SECBBR2  \ offset: 0x84 : FLASH secure block based register 2
$500220c0 constant SEC_FLASH_FLASH_SECHDPCR  \ offset: 0xC0 : FLASH secure HDP control register
$500220c4 constant SEC_FLASH_FLASH_PRIFCFGR  \ offset: 0xC4 : FLASH privilege configuration register
$500220d0 constant SEC_FLASH_FLASH_PRIVBBR1  \ offset: 0xD0 : FLASH privilege block based register 1
$500220d4 constant SEC_FLASH_FLASH_PRIVBBR2  \ offset: 0xD4 : FLASH privilege block based register 2
$500220d8 constant SEC_FLASH_FLASH_PRIVBBR3  \ offset: 0xD8 : FLASH privilege block based register 3
$500220dc constant SEC_FLASH_FLASH_PRIVBBR4  \ offset: 0xDC : FLASH privilege block based register 4

