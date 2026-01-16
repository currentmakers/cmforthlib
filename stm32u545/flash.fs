\
\ @file flash.fs
\ @brief Flash
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FLASH access control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant FLASH_FLASH_ACR_LATENCY                          \ Latency These bits represent the ratio between the HCLK (AHB clock) period and the Flash memory access time. ...
$00000100 constant FLASH_FLASH_ACR_PRFTEN                           \ Prefetch enable This bit enables the prefetch buffer in the embedded Flash memory.
$00000800 constant FLASH_FLASH_ACR_LPM                              \ Low-power read mode This bit puts the Flash memory in low-power read mode.
$00001000 constant FLASH_FLASH_ACR_PDREQ1                           \ Bank 1 power-down mode request This bit is write-protected with FLASH_PDKEY1R. This bit requests bank 1 to enter power-down mode. When bank 1 enters power-down mode, this bit is cleared by hardware and the PDKEY1R is locked.
$00002000 constant FLASH_FLASH_ACR_PDREQ2                           \ Bank 2 power-down mode request This bit is write-protected with FLASH_PDKEY2R. This bit requests bank 2 to enter power-down mode. When bank 2 enters power-down mode, this bit is cleared by hardware and the PDKEY2R is locked.
$00004000 constant FLASH_FLASH_ACR_SLEEP_PD                         \ Flash memory power-down mode during Sleep mode This bit determines whether the Flash memory is in power-down mode or Idle mode when the device is in Sleep mode. The Flash must not be put in power-down while a program or an erase operation is on-going.


\
\ @brief FLASH non-secure key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_NSKEYR_NSKEY                         \ Flash memory non-secure key The following values must be written consecutively to unlock the FLASH_NSCR register, allowing the Flash memory non-secure programming/erasing operations: KEY1: 0x4567 0123 KEY2: 0xCDEF 89AB


\
\ @brief FLASH secure key register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECKEYR_SECKEY                       \ Flash memory secure key The following values must be written consecutively to unlock the FLASH_SECCR register, allowing the Flash memory secure programming/erasing operations: KEY1: 0x4567 0123 KEY2: 0xCDEF 89AB


\
\ @brief FLASH option key register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OPTKEYR_OPTKEY                       \ Option byte key The following values must be written consecutively to unlock the FLASH_OPTR register allowing option byte programming/erasing operations: KEY1: 0x0819 2A3B KEY2: 0x4C5D 6E7F


\
\ @brief FLASH bank 1 power-down key register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PDKEY1R_PDKEY1                       \ Bank 1 power-down key The following values must be written consecutively to unlock the PDREQ1 bit in FLASH_ACR: PDKEY1_1: 0x0415 2637 PDKEY1_2: 0xFAFB FCFD


\
\ @brief FLASH bank 2 power-down key register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PDKEY2R_PDKEY2                       \ Bank 2 power-down key The following values must be written consecutively to unlock the PDREQ2 bit in FLASH_ACR: PDKEY2_1: 0x4051 6273 PDKEY2_2: 0xAFBF CFDF


\
\ @brief FLASH non-secure status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_NSSR_EOP                             \ Non-secure end of operation This bit is set by hardware when one or more Flash memory non-secure operation (program/erase) has been completed successfully. This bit is set only if the non-secure end of operation interrupts are enabled (EOPIE = 1 in FLASH_NSCR). This bit is cleared by writing 1.
$00000002 constant FLASH_FLASH_NSSR_OPERR                           \ Non-secure operation error This bit is set by hardware when a Flash memory non-secure operation (program/erase) completes unsuccessfully. This bit is set only if non-secure error interrupts are enabled (NSERRIE = 1). This bit is cleared by writing 1.
$00000008 constant FLASH_FLASH_NSSR_PROGERR                         \ Non-secure programming error This bit is set by hardware when a non-secure quad-word address to be programmed contains a value different from all 1 before programming, except if the data to write is all 0. This bit is cleared by writing 1.
$00000010 constant FLASH_FLASH_NSSR_WRPERR                          \ Non-secure write protection error This bit is set by hardware when an non-secure address to be erased/programmed belongs to a write-protected part (by WRP, PCROP, HDP or RDP level 1) of the Flash memory. This bit is cleared by writing 1. Refer to for full conditions of error flag setting.
$00000020 constant FLASH_FLASH_NSSR_PGAERR                          \ Non-secure programming alignment error This bit is set by hardware when the first word to be programmed is not aligned with a quad-word address, or the second, third or forth word does not belong to the same quad-word address. This bit is cleared by writing 1.
$00000040 constant FLASH_FLASH_NSSR_SIZERR                          \ Non-secure size error This bit is set by hardware when the size of the access is a byte or half-word during a non-secure program sequence. Only quad-word programming is allowed by means of successive word accesses. This bit is cleared by writing 1.
$00000080 constant FLASH_FLASH_NSSR_PGSERR                          \ Non-secure programming sequence error This bit is set by hardware when programming sequence is not correct. It is cleared by writing 1. Refer to for full conditions of error flag setting.
$00002000 constant FLASH_FLASH_NSSR_OPTWERR                         \ Option write error This bit is set by hardware when the options bytes are written with an invalid configuration. It is cleared by writing 1. Refer to for full conditions of error flag setting.
$00010000 constant FLASH_FLASH_NSSR_BSY                             \ Non-secure busy This indicates that a Flash memory secure or non-secure operation is in progress. This bit is set at the beginning of a Flash operation and reset when the operation finishes or when an error occurs.
$00020000 constant FLASH_FLASH_NSSR_WDW                             \ Non-secure wait data to write This bit indicates that the Flash memory write buffer has been written by a secure or non-secure operation. It is set when the first data is stored in the buffer and cleared when the write is performed in the Flash memory.
$00040000 constant FLASH_FLASH_NSSR_OEM1LOCK                        \ OEM1 lock This bit indicates that the OEM1 RDP key read during the OBL is not virgin. When set, the OEM1 RDP lock mechanism is active.
$00080000 constant FLASH_FLASH_NSSR_OEM2LOCK                        \ OEM2 lock This bit indicates that the OEM2 RDP key read during the OBL is not virgin. When set, the OEM2 RDP lock mechanism is active.
$00100000 constant FLASH_FLASH_NSSR_PD1                             \ Bank 1 in power-down mode This bit indicates that the Flash memory bank 1 is in power-down state. It is reset when bank 1 is in normal mode or being awaken.
$00200000 constant FLASH_FLASH_NSSR_PD2                             \ Bank 2 in power-down mode This bit indicates that the Flash memory bank 2 is in power-down state. It is reset when bank 2 is in normal mode or being awaken.


\
\ @brief FLASH secure status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SECSR_EOP                            \ Secure end of operation This bit is set by hardware when one or more Flash memory secure operation (program/erase) has been completed successfully. This bit is set only if the secure end of operation interrupts are enabled (EOPIE = 1 in FLASH_SECCR). This bit is cleared by writing 1.
$00000002 constant FLASH_FLASH_SECSR_OPERR                          \ Secure operation error This bit is set by hardware when a Flash memory secure operation (program/erase) completes unsuccessfully. This bit is set only if secure error interrupts are enabled (SECERRIE = 1). This bit is cleared by writing 1.
$00000008 constant FLASH_FLASH_SECSR_PROGERR                        \ Secure programming error This bit is set by hardware when a secure quad-word address to be programmed contains a value different from all 1 before programming, except if the data to write is all 0. This bit is cleared by writing 1.
$00000010 constant FLASH_FLASH_SECSR_WRPERR                         \ Secure write protection error This bit is set by hardware when an secure address to be erased/programmed belongs to a write-protected part (by WRP, PCROP, HDP or RDP level 1) of the Flash memory.This bit is cleared by writing 1. Refer to for full conditions of error flag setting.
$00000020 constant FLASH_FLASH_SECSR_PGAERR                         \ Secure programming alignment error This bit is set by hardware when the first word to be programmed is not aligned with a quad-word address, or the second, third or forth word does not belong to the same quad-word address.This bit is cleared by writing 1.
$00000040 constant FLASH_FLASH_SECSR_SIZERR                         \ Secure size error This bit is set by hardware when the size of the access is a byte or half-word during a secure program sequence. Only quad-word programming is allowed by means of successive word accesses.This bit is cleared by writing 1.
$00000080 constant FLASH_FLASH_SECSR_PGSERR                         \ Secure programming sequence error This bit is set by hardware when programming sequence is not correct. It is cleared by writing 1. Refer to for full conditions of error flag setting.
$00004000 constant FLASH_FLASH_SECSR_RDERR                          \ Secure readout protection error This bit is set by hardware when a read access is performed to a secure PCROP area and when a cacheable fetch access is performed to a secure PCROP area. An interrupt is generated if RDERRIE is set in FLASH_SECCR register. This bit is cleared by writing 1.
$00010000 constant FLASH_FLASH_SECSR_BSY                            \ Secure busy This bit indicates that a Flash memory secure or non-secure operation is in progress. This is set on the beginning of a Flash operation and reset when the operation finishes or when an error occurs.
$00020000 constant FLASH_FLASH_SECSR_WDW                            \ Secure wait data to write This bit indicates that the Flash memory write buffer has been written by a secure or non-secure operation. It is set when the first data is stored in the buffer and cleared when the write is performed in the Flash memory.


\
\ @brief FLASH non-secure control register
\ Address offset: 0x28
\ Reset value: 0xC0000000
\

$00000001 constant FLASH_FLASH_NSCR_PG                              \ Non-secure programming
$00000002 constant FLASH_FLASH_NSCR_PER                             \ Non-secure page erase
$00000004 constant FLASH_FLASH_NSCR_MER1                            \ Non-secure bank 1 mass erase This bit triggers the bank 1 non-secure mass erase (all bank 1 user pages) when set.
$000007f8 constant FLASH_FLASH_NSCR_PNB                             \ Non-secure page number selection These bits select the page to erase. ... ...
$00000800 constant FLASH_FLASH_NSCR_BKER                            \ Non-secure bank selection for page erase
$00004000 constant FLASH_FLASH_NSCR_BWR                             \ Non-secure burst write programming mode When set, this bit selects the burst write programming mode.
$00008000 constant FLASH_FLASH_NSCR_MER2                            \ Non-secure bank 2 mass erase This bit triggers the bank 2 non-secure mass erase (all bank 2 user pages) when set.
$00010000 constant FLASH_FLASH_NSCR_STRT                            \ Non-secure start This bit triggers a non-secure erase operation when set. If MER1, MER2 and PER bits are reset and the STRT bit is set, the PGSERR bit in FLASH_NSSR is set (this condition is forbidden). This bit is set only by software and is cleared when the BSY bit is cleared in FLASH_NSSR.
$00020000 constant FLASH_FLASH_NSCR_OPTSTRT                         \ Options modification start This bit triggers an options operation when set. It can not be written if OPTLOCK bit is set. This bit is set only by software, and is cleared when the BSY bit is cleared in FLASH_NSSR.
$01000000 constant FLASH_FLASH_NSCR_EOPIE                           \ Non-secure end of operation interrupt enable This bit enables the interrupt generation when the EOP bit in the FLASH_NSSR is set to 1.
$02000000 constant FLASH_FLASH_NSCR_ERRIE                           \ Non-secure error interrupt enable This bit enables the interrupt generation when the OPERR bit in the FLASH_NSSR is set to 1.
$08000000 constant FLASH_FLASH_NSCR_OBL_LAUNCH                      \ Force the option byte loading When set to 1, this bit forces the option byte reloading. This bit is cleared only when the option byte loading is complete. It cannot be written if OPTLOCK is set.
$40000000 constant FLASH_FLASH_NSCR_OPTLOCK                         \ Option lock This bit is set only. When set, all bits concerning user options in FLASH_NSCR register are locked. This bit is cleared by hardware after detecting the unlock sequence. The LOCK bit in the FLASH_NSCR must be cleared before doing the unlock sequence for OPTLOCK bit. In case of an unsuccessful unlock operation, this bit remains set until the next reset.
$80000000 constant FLASH_FLASH_NSCR_LOCK                            \ Non-secure lock This bit is set only. When set, the FLASH_NSCR register is locked. It is cleared by hardware after detecting the unlock sequence in FLASH_NSKEYR register. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.


\
\ @brief FLASH secure control register
\ Address offset: 0x2C
\ Reset value: 0x80000000
\

$00000001 constant FLASH_FLASH_SECCR_PG                             \ Secure programming
$00000002 constant FLASH_FLASH_SECCR_PER                            \ Secure page erase
$00000004 constant FLASH_FLASH_SECCR_MER1                           \ Secure bank 1 mass erase This bit triggers the bank 1 secure mass erase (all bank 1 user pages) when set.
$000007f8 constant FLASH_FLASH_SECCR_PNB                            \ Secure page number selection These bits select the page to erase. ... ...
$00000800 constant FLASH_FLASH_SECCR_BKER                           \ Secure bank selection for page erase
$00004000 constant FLASH_FLASH_SECCR_BWR                            \ Secure burst write programming mode When set, this bit selects the burst write programming mode.
$00008000 constant FLASH_FLASH_SECCR_MER2                           \ Secure bank 2 mass erase This bit triggers the bank 2 secure mass erase (all bank 2 user pages) when set.
$00010000 constant FLASH_FLASH_SECCR_STRT                           \ Secure start This bit triggers a secure erase operation when set. If MER1, MER2 and PER bits are reset and the STRT bit is set, the PGSERR in the FLASH_SECSR is set (this condition is forbidden). This bit is set only by software and is cleared when the BSY bit is cleared in FLASH_SECSR.
$01000000 constant FLASH_FLASH_SECCR_EOPIE                          \ Secure End of operation interrupt enable This bit enables the interrupt generation when the EOP bit in the FLASH_SECSR is set to 1.
$02000000 constant FLASH_FLASH_SECCR_ERRIE                          \ Secure error interrupt enable This bit enables the interrupt generation when the OPERR bit in the FLASH_SECSR is set to 1.
$04000000 constant FLASH_FLASH_SECCR_RDERRIE                        \ Secure PCROP read error interrupt enable This bit enables the interrupt generation when the RDERR bit in the FLASH_SECSR is set to 1.
$20000000 constant FLASH_FLASH_SECCR_INV                            \ Flash memory security state invert This bit inverts the Flash memory security state.
$80000000 constant FLASH_FLASH_SECCR_LOCK                           \ Secure lock This bit is set only. When set, the FLASH_SECCR register is locked. It is cleared by hardware after detecting the unlock sequence in FLASH_SECKEYR register. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.


\
\ @brief FLASH ECC register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$001fffff constant FLASH_FLASH_ECCR_ADDR_ECC                        \ ECC fail address This field indicates which address is concerned by the ECC error correction or by the double ECC error detection. The address is given by bank from address 0x0 0000 to 0x1F FFF0.
$00200000 constant FLASH_FLASH_ECCR_BK_ECC                          \ ECC fail bank This bit indicates which bank is concerned by the ECC error correction or by the double ECC error detection.
$00400000 constant FLASH_FLASH_ECCR_SYSF_ECC                        \ System Flash memory ECC fail This bit indicates that the ECC error correction or double ECC error detection is located in the system Flash memory.
$01000000 constant FLASH_FLASH_ECCR_ECCIE                           \ ECC correction interrupt enable This bit enables the interrupt generation when the ECCC bit in the FLASH_ECCR register is set.
$40000000 constant FLASH_FLASH_ECCR_ECCC                            \ ECC correction This bit is set by hardware when one ECC error has been detected and corrected (only if ECCC and ECCD were previously cleared). An interrupt is generated if ECCIE is set. This bit is cleared by writing 1.
$80000000 constant FLASH_FLASH_ECCR_ECCD                            \ ECC detection This bit is set by hardware when two ECC errors have been detected (only if ECCC and ECCD were previously cleared). When this bit is set, a NMI is generated. This bit is cleared by writing 1.


\
\ @brief FLASH operation status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$001fffff constant FLASH_FLASH_OPSR_ADDR_OP                         \ Interrupted operation address This field indicates which address in the Flash memory was accessed when reset occurred. The address is given by bank from address 0x0 0000 to 0x1F FFF0.
$00200000 constant FLASH_FLASH_OPSR_BK_OP                           \ Interrupted operation bank This bit indicates which Flash memory bank was accessed when reset occurred
$00400000 constant FLASH_FLASH_OPSR_SYSF_OP                         \ Operation in system Flash memory interrupted This bit indicates that the reset occurred during an operation in the system Flash memory.
$e0000000 constant FLASH_FLASH_OPSR_CODE_OP                         \ Flash memory operation code This field indicates which Flash memory operation has been interrupted by a system reset:


\
\ @brief FLASH option register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_OPTR_RDP                             \ Readout protection level Others: Level 1 (memories readout protection active) Note: Refer to for more details.
$00000700 constant FLASH_FLASH_OPTR_BOR_LEV                         \ BOR reset level These bits contain the VDD supply level threshold that activates/releases the reset.
$00001000 constant FLASH_FLASH_OPTR_NRST_STOP                       \ Reset generation in Stop mode
$00002000 constant FLASH_FLASH_OPTR_NRST_STDBY                      \ Reset generation in Standby mode
$00004000 constant FLASH_FLASH_OPTR_NRST_SHDW                       \ Reset generation in Shutdown mode
$00008000 constant FLASH_FLASH_OPTR_SRAM1345_RST                    \ SRAM1,SRAM4 and SRAM5 erase upon system reset
$00010000 constant FLASH_FLASH_OPTR_IWDG_SW                         \ Independent watchdog selection
$00020000 constant FLASH_FLASH_OPTR_IWDG_STOP                       \ Independent watchdog counter freeze in Stop mode
$00040000 constant FLASH_FLASH_OPTR_IWDG_STDBY                      \ Independent watchdog counter freeze in Standby mode
$00080000 constant FLASH_FLASH_OPTR_WWDG_SW                         \ Window watchdog selection
$00100000 constant FLASH_FLASH_OPTR_SWAP_BANK                       \ Swap banks
$00200000 constant FLASH_FLASH_OPTR_DUALBANK                        \ Dual-bank on 1-Mbyte and 512-Kbyte Flash memory devices
$00400000 constant FLASH_FLASH_OPTR_BKPRAM_ECC                      \ Backup RAM ECC detection and correction enable
$01000000 constant FLASH_FLASH_OPTR_SRAM2_ECC                       \ SRAM2 ECC detection and correction enable
$02000000 constant FLASH_FLASH_OPTR_SRAM2_RST                       \ SRAM2 erase when system reset
$04000000 constant FLASH_FLASH_OPTR_NSWBOOT0                        \ Software BOOT0
$08000000 constant FLASH_FLASH_OPTR_NBOOT0                          \ nBOOT0 option bit
$10000000 constant FLASH_FLASH_OPTR_PA15_PUPEN                      \ PA15 pull-up enable
$20000000 constant FLASH_FLASH_OPTR_IO_VDD_HSLV                     \ High-speed IO at low VDD voltage configuration bit This bit can be set only with VDD below 2.5V
$40000000 constant FLASH_FLASH_OPTR_IO_VDDIO2_HSLV                  \ High-speed IO at low VDDIO2 voltage configuration bit This bit can be set only with VDDIO2 below 2.5 V.
$80000000 constant FLASH_FLASH_OPTR_TZEN                            \ Global TrustZone security enable


\
\ @brief FLASH non-secure boot address 0 register
\ Address offset: 0x44
\ Reset value: 0x0000000F
\

$ffffff80 constant FLASH_FLASH_NSBOOTADD0R_NSBOOTADD0               \ Non-secure boot base address 0 The non-secure boot memory address can be programmed to any address in the valid address range with a granularity of 128 bytes. These bits correspond to address [31:7]. The NSBOOTADD0 option bytes are selected following the BOOT0 pin or nSWBOOT0 state. Examples: NSBOOTADD0[24:0] = 0x0100000: Boot from non-secure Flash memory (0x0800 0000) NSBOOTADD0[24:0] = 0x017F200: Boot from system memory bootloader (0x0BF9 0000) NSBOOTADD0[24:0] = 0x0400000: Boot from non-secure SRAM1 on S-Bus (0x2000 0000)


\
\ @brief FLASH non-secure boot address 1 register
\ Address offset: 0x48
\ Reset value: 0x0000000F
\

$ffffff80 constant FLASH_FLASH_NSBOOTADD1R_NSBOOTADD1               \ Non-secure boot address 1 The non-secure boot memory address can be programmed to any address in the valid address range with a granularity of 128 bytes. These bits correspond to address [31:7]. The NSBOOTADD0 option bytes are selected following the BOOT0 pin or nSWBOOT0 state. Examples: NSBOOTADD1[24:0] = 0x0100000: Boot from non-secure Flash memory (0x0800 0000) NSBOOTADD1[24:0] = 0x017F200: Boot from system memory bootloader (0x0BF9 0000) NSBOOTADD1[24:0] = 0x0400000: Boot from non-secure SRAM1 on S-Bus (0x2000 0000)


\
\ @brief FLASH secure boot address 0 register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SECBOOTADD0R_BOOT_LOCK               \ Boot lock When set, the boot is always forced to base address value programmed in SECBOOTADD0[24:0] option bytes whatever the boot selection option. When set, this bit can only be cleared by an RDP at level 0.
$ffffff80 constant FLASH_FLASH_SECBOOTADD0R_SECBOOTADD0             \ Secure boot base address 0 The secure boot memory address can be programmed to any address in the valid address range with a granularity of 128 bytes. This bits correspond to address [31:7] The SECBOOTADD0 option bytes are selected following the BOOT0 pin or nSWBOOT0 state. Examples: SECBOOTADD0[24:0] = 0x018 0000: Boot from secure Flash memory (0x0C00 0000) SECBOOTADD0[24:0] = 0x01F F000: Boot from RSS (0x0FF8 0000) SECBOOTADD0[24:0] = 0x060 0000: Boot from secure SRAM1 on S-Bus (0x3000 0000)


\
\ @brief FLASH secure watermark1 register 1
\ Address offset: 0x50
\ Reset value: 0xFF00FF00
\

$000000ff constant FLASH_FLASH_SECWM1R1_SECWM1_PSTRT                \ Start page of first secure area This field contains the first page of the secure area in bank 1.
$00ff0000 constant FLASH_FLASH_SECWM1R1_SECWM1_PEND                 \ End page of first secure area This field contains the last page of the secure area in bank 1.


\
\ @brief FLASH secure watermark1 register 2
\ Address offset: 0x54
\ Reset value: 0x0F000F00
\

$000000ff constant FLASH_FLASH_SECWM1R2_PCROP1_PSTRT                \ Start page of first PCROP area This field contains the first page of the PCROP area in bank 1.
$00008000 constant FLASH_FLASH_SECWM1R2_PCROP1EN                    \ PCROP1 area enable
$00ff0000 constant FLASH_FLASH_SECWM1R2_HDP1_PEND                   \ End page of first hide protection area This field contains the last page of the HDP area in bank 1.
$80000000 constant FLASH_FLASH_SECWM1R2_HDP1EN                      \ Hide protection first area enable


\
\ @brief FLASH WRP1 area A address register
\ Address offset: 0x58
\ Reset value: 0x0F00FF00
\

$000000ff constant FLASH_FLASH_WRP1AR_WRP1A_PSTRT                   \ bank 1 WPR first area A start page This field contains the first page of the first WPR area for bank 1.
$00ff0000 constant FLASH_FLASH_WRP1AR_WRP1A_PEND                    \ Bank 1 WPR first area A end page This field contains the last page of the first WPR area in bank 1.
$80000000 constant FLASH_FLASH_WRP1AR_UNLOCK                        \ Bank 1 WPR first area A unlock


\
\ @brief FLASH WRP1 area B address register
\ Address offset: 0x5C
\ Reset value: 0x0F00FF00
\

$000000ff constant FLASH_FLASH_WRP1BR_WRP1B_PSTRT                   \ Bank 1 WRP second area B start page This field contains the first page of the second WRP area for bank 1.
$00ff0000 constant FLASH_FLASH_WRP1BR_WRP1B_PEND                    \ Bank 1 WRP second area B end page This field contains the last page of the second WRP area in bank 1.
$80000000 constant FLASH_FLASH_WRP1BR_UNLOCK                        \ Bank 1 WPR second area B unlock


\
\ @brief FLASH secure watermark2 register 1
\ Address offset: 0x60
\ Reset value: 0xFF00FF00
\

$000000ff constant FLASH_FLASH_SECWM2R1_SECWM2_PSTRT                \ Start page of second secure area This field contains the first page of the secure area in bank 2.
$00ff0000 constant FLASH_FLASH_SECWM2R1_SECWM2_PEND                 \ End page of second secure area This field contains the last page of the secure area in bank 2.


\
\ @brief FLASH secure watermark2 register 2
\ Address offset: 0x64
\ Reset value: 0x0F000F00
\

$000000ff constant FLASH_FLASH_SECWM2R2_PCROP2_PSTRT                \ Start page of PCROP2 area PRCROP2_PSTRT contains the first page of the PCROP area in bank 2.
$00008000 constant FLASH_FLASH_SECWM2R2_PCROP2EN                    \ PCROP2 area enable
$00ff0000 constant FLASH_FLASH_SECWM2R2_HDP2_PEND                   \ End page of hide protection second area HDP2_PEND contains the last page of the HDP area in bank 2.
$80000000 constant FLASH_FLASH_SECWM2R2_HDP2EN                      \ Hide protection second area enable


\
\ @brief FLASH WPR2 area A address register
\ Address offset: 0x68
\ Reset value: 0x0F00FF00
\

$000000ff constant FLASH_FLASH_WRP2AR_WRP2A_PSTRT                   \ Bank 2 WPR first area A start page This field contains the first page of the first WRP area for bank 2.
$00ff0000 constant FLASH_FLASH_WRP2AR_WRP2A_PEND                    \ Bank 2 WPR first area A end page This field contains the last page of the first WRP area in bank 2.
$80000000 constant FLASH_FLASH_WRP2AR_UNLOCK                        \ Bank 2 WPR first area A unlock


\
\ @brief FLASH WPR2 area B address register
\ Address offset: 0x6C
\ Reset value: 0x0F00FF00
\

$000000ff constant FLASH_FLASH_WRP2BR_WRP2B_PSTRT                   \ Bank 2 WPR second area B start page This field contains the first page of the second WRP area for bank 2.
$00ff0000 constant FLASH_FLASH_WRP2BR_WRP2B_PEND                    \ Bank 2 WPR second area B end page This field contains the last page of the second WRP area in bank 2.
$80000000 constant FLASH_FLASH_WRP2BR_UNLOCK                        \ Bank 2 WPR second area B unlock


\
\ @brief FLASH OEM1 key register 1
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OEM1KEYR1_OEM1KEY                    \ OEM1 least significant bytes key


\
\ @brief FLASH OEM1 key register 2
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OEM1KEYR2_OEM1KEY                    \ OEM1 most significant bytes key


\
\ @brief FLASH OEM2 key register 1
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OEM2KEYR1_OEM2KEY                    \ OEM2 least significant bytes key


\
\ @brief FLASH OEM2 key register 2
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OEM2KEYR2_OEM2KEY                    \ OEM2 most significant bytes key


\
\ @brief FLASH secure block based bank 1 register 1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC1BBR1_SEC1BB0                 
$00000002 constant FLASH_FLASH_SEC1BBR1_SEC1BB1                 
$00000004 constant FLASH_FLASH_SEC1BBR1_SEC1BB2                 
$00000008 constant FLASH_FLASH_SEC1BBR1_SEC1BB3                 
$00000010 constant FLASH_FLASH_SEC1BBR1_SEC1BB4                 
$00000020 constant FLASH_FLASH_SEC1BBR1_SEC1BB5                 
$00000040 constant FLASH_FLASH_SEC1BBR1_SEC1BB6                 
$00000080 constant FLASH_FLASH_SEC1BBR1_SEC1BB7                 
$00000100 constant FLASH_FLASH_SEC1BBR1_SEC1BB8                 
$00000200 constant FLASH_FLASH_SEC1BBR1_SEC1BB9                 
$00000400 constant FLASH_FLASH_SEC1BBR1_SEC1BB10                
$00000800 constant FLASH_FLASH_SEC1BBR1_SEC1BB11                
$00001000 constant FLASH_FLASH_SEC1BBR1_SEC1BB12                
$00002000 constant FLASH_FLASH_SEC1BBR1_SEC1BB13                
$00004000 constant FLASH_FLASH_SEC1BBR1_SEC1BB14                
$00008000 constant FLASH_FLASH_SEC1BBR1_SEC1BB15                
$00010000 constant FLASH_FLASH_SEC1BBR1_SEC1BB16                
$00020000 constant FLASH_FLASH_SEC1BBR1_SEC1BB17                
$00040000 constant FLASH_FLASH_SEC1BBR1_SEC1BB18                
$00080000 constant FLASH_FLASH_SEC1BBR1_SEC1BB19                
$00100000 constant FLASH_FLASH_SEC1BBR1_SEC1BB20                
$00200000 constant FLASH_FLASH_SEC1BBR1_SEC1BB21                
$00400000 constant FLASH_FLASH_SEC1BBR1_SEC1BB22                
$00800000 constant FLASH_FLASH_SEC1BBR1_SEC1BB23                
$01000000 constant FLASH_FLASH_SEC1BBR1_SEC1BB24                
$02000000 constant FLASH_FLASH_SEC1BBR1_SEC1BB25                
$04000000 constant FLASH_FLASH_SEC1BBR1_SEC1BB26                
$08000000 constant FLASH_FLASH_SEC1BBR1_SEC1BB27                
$10000000 constant FLASH_FLASH_SEC1BBR1_SEC1BB28                
$20000000 constant FLASH_FLASH_SEC1BBR1_SEC1BB29                
$40000000 constant FLASH_FLASH_SEC1BBR1_SEC1BB30                
$80000000 constant FLASH_FLASH_SEC1BBR1_SEC1BB31                


\
\ @brief FLASH secure block based bank 1 register 2
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC1BBR2_SEC1BB0                 
$00000002 constant FLASH_FLASH_SEC1BBR2_SEC1BB1                 
$00000004 constant FLASH_FLASH_SEC1BBR2_SEC1BB2                 
$00000008 constant FLASH_FLASH_SEC1BBR2_SEC1BB3                 
$00000010 constant FLASH_FLASH_SEC1BBR2_SEC1BB4                 
$00000020 constant FLASH_FLASH_SEC1BBR2_SEC1BB5                 
$00000040 constant FLASH_FLASH_SEC1BBR2_SEC1BB6                 
$00000080 constant FLASH_FLASH_SEC1BBR2_SEC1BB7                 
$00000100 constant FLASH_FLASH_SEC1BBR2_SEC1BB8                 
$00000200 constant FLASH_FLASH_SEC1BBR2_SEC1BB9                 
$00000400 constant FLASH_FLASH_SEC1BBR2_SEC1BB10                
$00000800 constant FLASH_FLASH_SEC1BBR2_SEC1BB11                
$00001000 constant FLASH_FLASH_SEC1BBR2_SEC1BB12                
$00002000 constant FLASH_FLASH_SEC1BBR2_SEC1BB13                
$00004000 constant FLASH_FLASH_SEC1BBR2_SEC1BB14                
$00008000 constant FLASH_FLASH_SEC1BBR2_SEC1BB15                
$00010000 constant FLASH_FLASH_SEC1BBR2_SEC1BB16                
$00020000 constant FLASH_FLASH_SEC1BBR2_SEC1BB17                
$00040000 constant FLASH_FLASH_SEC1BBR2_SEC1BB18                
$00080000 constant FLASH_FLASH_SEC1BBR2_SEC1BB19                
$00100000 constant FLASH_FLASH_SEC1BBR2_SEC1BB20                
$00200000 constant FLASH_FLASH_SEC1BBR2_SEC1BB21                
$00400000 constant FLASH_FLASH_SEC1BBR2_SEC1BB22                
$00800000 constant FLASH_FLASH_SEC1BBR2_SEC1BB23                
$01000000 constant FLASH_FLASH_SEC1BBR2_SEC1BB24                
$02000000 constant FLASH_FLASH_SEC1BBR2_SEC1BB25                
$04000000 constant FLASH_FLASH_SEC1BBR2_SEC1BB26                
$08000000 constant FLASH_FLASH_SEC1BBR2_SEC1BB27                
$10000000 constant FLASH_FLASH_SEC1BBR2_SEC1BB28                
$20000000 constant FLASH_FLASH_SEC1BBR2_SEC1BB29                
$40000000 constant FLASH_FLASH_SEC1BBR2_SEC1BB30                
$80000000 constant FLASH_FLASH_SEC1BBR2_SEC1BB31                


\
\ @brief FLASH secure block based bank 1 register 3
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC1BBR3_SEC1BB0                 
$00000002 constant FLASH_FLASH_SEC1BBR3_SEC1BB1                 
$00000004 constant FLASH_FLASH_SEC1BBR3_SEC1BB2                 
$00000008 constant FLASH_FLASH_SEC1BBR3_SEC1BB3                 
$00000010 constant FLASH_FLASH_SEC1BBR3_SEC1BB4                 
$00000020 constant FLASH_FLASH_SEC1BBR3_SEC1BB5                 
$00000040 constant FLASH_FLASH_SEC1BBR3_SEC1BB6                 
$00000080 constant FLASH_FLASH_SEC1BBR3_SEC1BB7                 
$00000100 constant FLASH_FLASH_SEC1BBR3_SEC1BB8                 
$00000200 constant FLASH_FLASH_SEC1BBR3_SEC1BB9                 
$00000400 constant FLASH_FLASH_SEC1BBR3_SEC1BB10                
$00000800 constant FLASH_FLASH_SEC1BBR3_SEC1BB11                
$00001000 constant FLASH_FLASH_SEC1BBR3_SEC1BB12                
$00002000 constant FLASH_FLASH_SEC1BBR3_SEC1BB13                
$00004000 constant FLASH_FLASH_SEC1BBR3_SEC1BB14                
$00008000 constant FLASH_FLASH_SEC1BBR3_SEC1BB15                
$00010000 constant FLASH_FLASH_SEC1BBR3_SEC1BB16                
$00020000 constant FLASH_FLASH_SEC1BBR3_SEC1BB17                
$00040000 constant FLASH_FLASH_SEC1BBR3_SEC1BB18                
$00080000 constant FLASH_FLASH_SEC1BBR3_SEC1BB19                
$00100000 constant FLASH_FLASH_SEC1BBR3_SEC1BB20                
$00200000 constant FLASH_FLASH_SEC1BBR3_SEC1BB21                
$00400000 constant FLASH_FLASH_SEC1BBR3_SEC1BB22                
$00800000 constant FLASH_FLASH_SEC1BBR3_SEC1BB23                
$01000000 constant FLASH_FLASH_SEC1BBR3_SEC1BB24                
$02000000 constant FLASH_FLASH_SEC1BBR3_SEC1BB25                
$04000000 constant FLASH_FLASH_SEC1BBR3_SEC1BB26                
$08000000 constant FLASH_FLASH_SEC1BBR3_SEC1BB27                
$10000000 constant FLASH_FLASH_SEC1BBR3_SEC1BB28                
$20000000 constant FLASH_FLASH_SEC1BBR3_SEC1BB29                
$40000000 constant FLASH_FLASH_SEC1BBR3_SEC1BB30                
$80000000 constant FLASH_FLASH_SEC1BBR3_SEC1BB31                


\
\ @brief FLASH secure block based bank 1 register 4
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC1BBR4_SEC1BB0                 
$00000002 constant FLASH_FLASH_SEC1BBR4_SEC1BB1                 
$00000004 constant FLASH_FLASH_SEC1BBR4_SEC1BB2                 
$00000008 constant FLASH_FLASH_SEC1BBR4_SEC1BB3                 
$00000010 constant FLASH_FLASH_SEC1BBR4_SEC1BB4                 
$00000020 constant FLASH_FLASH_SEC1BBR4_SEC1BB5                 
$00000040 constant FLASH_FLASH_SEC1BBR4_SEC1BB6                 
$00000080 constant FLASH_FLASH_SEC1BBR4_SEC1BB7                 
$00000100 constant FLASH_FLASH_SEC1BBR4_SEC1BB8                 
$00000200 constant FLASH_FLASH_SEC1BBR4_SEC1BB9                 
$00000400 constant FLASH_FLASH_SEC1BBR4_SEC1BB10                
$00000800 constant FLASH_FLASH_SEC1BBR4_SEC1BB11                
$00001000 constant FLASH_FLASH_SEC1BBR4_SEC1BB12                
$00002000 constant FLASH_FLASH_SEC1BBR4_SEC1BB13                
$00004000 constant FLASH_FLASH_SEC1BBR4_SEC1BB14                
$00008000 constant FLASH_FLASH_SEC1BBR4_SEC1BB15                
$00010000 constant FLASH_FLASH_SEC1BBR4_SEC1BB16                
$00020000 constant FLASH_FLASH_SEC1BBR4_SEC1BB17                
$00040000 constant FLASH_FLASH_SEC1BBR4_SEC1BB18                
$00080000 constant FLASH_FLASH_SEC1BBR4_SEC1BB19                
$00100000 constant FLASH_FLASH_SEC1BBR4_SEC1BB20                
$00200000 constant FLASH_FLASH_SEC1BBR4_SEC1BB21                
$00400000 constant FLASH_FLASH_SEC1BBR4_SEC1BB22                
$00800000 constant FLASH_FLASH_SEC1BBR4_SEC1BB23                
$01000000 constant FLASH_FLASH_SEC1BBR4_SEC1BB24                
$02000000 constant FLASH_FLASH_SEC1BBR4_SEC1BB25                
$04000000 constant FLASH_FLASH_SEC1BBR4_SEC1BB26                
$08000000 constant FLASH_FLASH_SEC1BBR4_SEC1BB27                
$10000000 constant FLASH_FLASH_SEC1BBR4_SEC1BB28                
$20000000 constant FLASH_FLASH_SEC1BBR4_SEC1BB29                
$40000000 constant FLASH_FLASH_SEC1BBR4_SEC1BB30                
$80000000 constant FLASH_FLASH_SEC1BBR4_SEC1BB31                


\
\ @brief FLASH secure block based bank 1 register 5
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC1BBR5_SEC1BB0                 
$00000002 constant FLASH_FLASH_SEC1BBR5_SEC1BB1                 
$00000004 constant FLASH_FLASH_SEC1BBR5_SEC1BB2                 
$00000008 constant FLASH_FLASH_SEC1BBR5_SEC1BB3                 
$00000010 constant FLASH_FLASH_SEC1BBR5_SEC1BB4                 
$00000020 constant FLASH_FLASH_SEC1BBR5_SEC1BB5                 
$00000040 constant FLASH_FLASH_SEC1BBR5_SEC1BB6                 
$00000080 constant FLASH_FLASH_SEC1BBR5_SEC1BB7                 
$00000100 constant FLASH_FLASH_SEC1BBR5_SEC1BB8                 
$00000200 constant FLASH_FLASH_SEC1BBR5_SEC1BB9                 
$00000400 constant FLASH_FLASH_SEC1BBR5_SEC1BB10                
$00000800 constant FLASH_FLASH_SEC1BBR5_SEC1BB11                
$00001000 constant FLASH_FLASH_SEC1BBR5_SEC1BB12                
$00002000 constant FLASH_FLASH_SEC1BBR5_SEC1BB13                
$00004000 constant FLASH_FLASH_SEC1BBR5_SEC1BB14                
$00008000 constant FLASH_FLASH_SEC1BBR5_SEC1BB15                
$00010000 constant FLASH_FLASH_SEC1BBR5_SEC1BB16                
$00020000 constant FLASH_FLASH_SEC1BBR5_SEC1BB17                
$00040000 constant FLASH_FLASH_SEC1BBR5_SEC1BB18                
$00080000 constant FLASH_FLASH_SEC1BBR5_SEC1BB19                
$00100000 constant FLASH_FLASH_SEC1BBR5_SEC1BB20                
$00200000 constant FLASH_FLASH_SEC1BBR5_SEC1BB21                
$00400000 constant FLASH_FLASH_SEC1BBR5_SEC1BB22                
$00800000 constant FLASH_FLASH_SEC1BBR5_SEC1BB23                
$01000000 constant FLASH_FLASH_SEC1BBR5_SEC1BB24                
$02000000 constant FLASH_FLASH_SEC1BBR5_SEC1BB25                
$04000000 constant FLASH_FLASH_SEC1BBR5_SEC1BB26                
$08000000 constant FLASH_FLASH_SEC1BBR5_SEC1BB27                
$10000000 constant FLASH_FLASH_SEC1BBR5_SEC1BB28                
$20000000 constant FLASH_FLASH_SEC1BBR5_SEC1BB29                
$40000000 constant FLASH_FLASH_SEC1BBR5_SEC1BB30                
$80000000 constant FLASH_FLASH_SEC1BBR5_SEC1BB31                


\
\ @brief FLASH secure block based bank 1 register 6
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC1BBR6_SEC1BB0                 
$00000002 constant FLASH_FLASH_SEC1BBR6_SEC1BB1                 
$00000004 constant FLASH_FLASH_SEC1BBR6_SEC1BB2                 
$00000008 constant FLASH_FLASH_SEC1BBR6_SEC1BB3                 
$00000010 constant FLASH_FLASH_SEC1BBR6_SEC1BB4                 
$00000020 constant FLASH_FLASH_SEC1BBR6_SEC1BB5                 
$00000040 constant FLASH_FLASH_SEC1BBR6_SEC1BB6                 
$00000080 constant FLASH_FLASH_SEC1BBR6_SEC1BB7                 
$00000100 constant FLASH_FLASH_SEC1BBR6_SEC1BB8                 
$00000200 constant FLASH_FLASH_SEC1BBR6_SEC1BB9                 
$00000400 constant FLASH_FLASH_SEC1BBR6_SEC1BB10                
$00000800 constant FLASH_FLASH_SEC1BBR6_SEC1BB11                
$00001000 constant FLASH_FLASH_SEC1BBR6_SEC1BB12                
$00002000 constant FLASH_FLASH_SEC1BBR6_SEC1BB13                
$00004000 constant FLASH_FLASH_SEC1BBR6_SEC1BB14                
$00008000 constant FLASH_FLASH_SEC1BBR6_SEC1BB15                
$00010000 constant FLASH_FLASH_SEC1BBR6_SEC1BB16                
$00020000 constant FLASH_FLASH_SEC1BBR6_SEC1BB17                
$00040000 constant FLASH_FLASH_SEC1BBR6_SEC1BB18                
$00080000 constant FLASH_FLASH_SEC1BBR6_SEC1BB19                
$00100000 constant FLASH_FLASH_SEC1BBR6_SEC1BB20                
$00200000 constant FLASH_FLASH_SEC1BBR6_SEC1BB21                
$00400000 constant FLASH_FLASH_SEC1BBR6_SEC1BB22                
$00800000 constant FLASH_FLASH_SEC1BBR6_SEC1BB23                
$01000000 constant FLASH_FLASH_SEC1BBR6_SEC1BB24                
$02000000 constant FLASH_FLASH_SEC1BBR6_SEC1BB25                
$04000000 constant FLASH_FLASH_SEC1BBR6_SEC1BB26                
$08000000 constant FLASH_FLASH_SEC1BBR6_SEC1BB27                
$10000000 constant FLASH_FLASH_SEC1BBR6_SEC1BB28                
$20000000 constant FLASH_FLASH_SEC1BBR6_SEC1BB29                
$40000000 constant FLASH_FLASH_SEC1BBR6_SEC1BB30                
$80000000 constant FLASH_FLASH_SEC1BBR6_SEC1BB31                


\
\ @brief FLASH secure block based bank 1 register 7
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC1BBR7_SEC1BB0                 
$00000002 constant FLASH_FLASH_SEC1BBR7_SEC1BB1                 
$00000004 constant FLASH_FLASH_SEC1BBR7_SEC1BB2                 
$00000008 constant FLASH_FLASH_SEC1BBR7_SEC1BB3                 
$00000010 constant FLASH_FLASH_SEC1BBR7_SEC1BB4                 
$00000020 constant FLASH_FLASH_SEC1BBR7_SEC1BB5                 
$00000040 constant FLASH_FLASH_SEC1BBR7_SEC1BB6                 
$00000080 constant FLASH_FLASH_SEC1BBR7_SEC1BB7                 
$00000100 constant FLASH_FLASH_SEC1BBR7_SEC1BB8                 
$00000200 constant FLASH_FLASH_SEC1BBR7_SEC1BB9                 
$00000400 constant FLASH_FLASH_SEC1BBR7_SEC1BB10                
$00000800 constant FLASH_FLASH_SEC1BBR7_SEC1BB11                
$00001000 constant FLASH_FLASH_SEC1BBR7_SEC1BB12                
$00002000 constant FLASH_FLASH_SEC1BBR7_SEC1BB13                
$00004000 constant FLASH_FLASH_SEC1BBR7_SEC1BB14                
$00008000 constant FLASH_FLASH_SEC1BBR7_SEC1BB15                
$00010000 constant FLASH_FLASH_SEC1BBR7_SEC1BB16                
$00020000 constant FLASH_FLASH_SEC1BBR7_SEC1BB17                
$00040000 constant FLASH_FLASH_SEC1BBR7_SEC1BB18                
$00080000 constant FLASH_FLASH_SEC1BBR7_SEC1BB19                
$00100000 constant FLASH_FLASH_SEC1BBR7_SEC1BB20                
$00200000 constant FLASH_FLASH_SEC1BBR7_SEC1BB21                
$00400000 constant FLASH_FLASH_SEC1BBR7_SEC1BB22                
$00800000 constant FLASH_FLASH_SEC1BBR7_SEC1BB23                
$01000000 constant FLASH_FLASH_SEC1BBR7_SEC1BB24                
$02000000 constant FLASH_FLASH_SEC1BBR7_SEC1BB25                
$04000000 constant FLASH_FLASH_SEC1BBR7_SEC1BB26                
$08000000 constant FLASH_FLASH_SEC1BBR7_SEC1BB27                
$10000000 constant FLASH_FLASH_SEC1BBR7_SEC1BB28                
$20000000 constant FLASH_FLASH_SEC1BBR7_SEC1BB29                
$40000000 constant FLASH_FLASH_SEC1BBR7_SEC1BB30                
$80000000 constant FLASH_FLASH_SEC1BBR7_SEC1BB31                


\
\ @brief FLASH secure block based bank 1 register 8
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC1BBR8_SEC1BB0                 
$00000002 constant FLASH_FLASH_SEC1BBR8_SEC1BB1                 
$00000004 constant FLASH_FLASH_SEC1BBR8_SEC1BB2                 
$00000008 constant FLASH_FLASH_SEC1BBR8_SEC1BB3                 
$00000010 constant FLASH_FLASH_SEC1BBR8_SEC1BB4                 
$00000020 constant FLASH_FLASH_SEC1BBR8_SEC1BB5                 
$00000040 constant FLASH_FLASH_SEC1BBR8_SEC1BB6                 
$00000080 constant FLASH_FLASH_SEC1BBR8_SEC1BB7                 
$00000100 constant FLASH_FLASH_SEC1BBR8_SEC1BB8                 
$00000200 constant FLASH_FLASH_SEC1BBR8_SEC1BB9                 
$00000400 constant FLASH_FLASH_SEC1BBR8_SEC1BB10                
$00000800 constant FLASH_FLASH_SEC1BBR8_SEC1BB11                
$00001000 constant FLASH_FLASH_SEC1BBR8_SEC1BB12                
$00002000 constant FLASH_FLASH_SEC1BBR8_SEC1BB13                
$00004000 constant FLASH_FLASH_SEC1BBR8_SEC1BB14                
$00008000 constant FLASH_FLASH_SEC1BBR8_SEC1BB15                
$00010000 constant FLASH_FLASH_SEC1BBR8_SEC1BB16                
$00020000 constant FLASH_FLASH_SEC1BBR8_SEC1BB17                
$00040000 constant FLASH_FLASH_SEC1BBR8_SEC1BB18                
$00080000 constant FLASH_FLASH_SEC1BBR8_SEC1BB19                
$00100000 constant FLASH_FLASH_SEC1BBR8_SEC1BB20                
$00200000 constant FLASH_FLASH_SEC1BBR8_SEC1BB21                
$00400000 constant FLASH_FLASH_SEC1BBR8_SEC1BB22                
$00800000 constant FLASH_FLASH_SEC1BBR8_SEC1BB23                
$01000000 constant FLASH_FLASH_SEC1BBR8_SEC1BB24                
$02000000 constant FLASH_FLASH_SEC1BBR8_SEC1BB25                
$04000000 constant FLASH_FLASH_SEC1BBR8_SEC1BB26                
$08000000 constant FLASH_FLASH_SEC1BBR8_SEC1BB27                
$10000000 constant FLASH_FLASH_SEC1BBR8_SEC1BB28                
$20000000 constant FLASH_FLASH_SEC1BBR8_SEC1BB29                
$40000000 constant FLASH_FLASH_SEC1BBR8_SEC1BB30                
$80000000 constant FLASH_FLASH_SEC1BBR8_SEC1BB31                


\
\ @brief FLASH secure block based bank 2 register 1
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC2BBR1_SEC2BB0                 
$00000002 constant FLASH_FLASH_SEC2BBR1_SEC2BB1                 
$00000004 constant FLASH_FLASH_SEC2BBR1_SEC2BB2                 
$00000008 constant FLASH_FLASH_SEC2BBR1_SEC2BB3                 
$00000010 constant FLASH_FLASH_SEC2BBR1_SEC2BB4                 
$00000020 constant FLASH_FLASH_SEC2BBR1_SEC2BB5                 
$00000040 constant FLASH_FLASH_SEC2BBR1_SEC2BB6                 
$00000080 constant FLASH_FLASH_SEC2BBR1_SEC2BB7                 
$00000100 constant FLASH_FLASH_SEC2BBR1_SEC2BB8                 
$00000200 constant FLASH_FLASH_SEC2BBR1_SEC2BB9                 
$00000400 constant FLASH_FLASH_SEC2BBR1_SEC2BB10                
$00000800 constant FLASH_FLASH_SEC2BBR1_SEC2BB11                
$00001000 constant FLASH_FLASH_SEC2BBR1_SEC2BB12                
$00002000 constant FLASH_FLASH_SEC2BBR1_SEC2BB13                
$00004000 constant FLASH_FLASH_SEC2BBR1_SEC2BB14                
$00008000 constant FLASH_FLASH_SEC2BBR1_SEC2BB15                
$00010000 constant FLASH_FLASH_SEC2BBR1_SEC2BB16                
$00020000 constant FLASH_FLASH_SEC2BBR1_SEC2BB17                
$00040000 constant FLASH_FLASH_SEC2BBR1_SEC2BB18                
$00080000 constant FLASH_FLASH_SEC2BBR1_SEC2BB19                
$00100000 constant FLASH_FLASH_SEC2BBR1_SEC2BB20                
$00200000 constant FLASH_FLASH_SEC2BBR1_SEC2BB21                
$00400000 constant FLASH_FLASH_SEC2BBR1_SEC2BB22                
$00800000 constant FLASH_FLASH_SEC2BBR1_SEC2BB23                
$01000000 constant FLASH_FLASH_SEC2BBR1_SEC2BB24                
$02000000 constant FLASH_FLASH_SEC2BBR1_SEC2BB25                
$04000000 constant FLASH_FLASH_SEC2BBR1_SEC2BB26                
$08000000 constant FLASH_FLASH_SEC2BBR1_SEC2BB27                
$10000000 constant FLASH_FLASH_SEC2BBR1_SEC2BB28                
$20000000 constant FLASH_FLASH_SEC2BBR1_SEC2BB29                
$40000000 constant FLASH_FLASH_SEC2BBR1_SEC2BB30                
$80000000 constant FLASH_FLASH_SEC2BBR1_SEC2BB31                


\
\ @brief FLASH secure block based bank 2 register 2
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC2BBR2_SEC2BB0                 
$00000002 constant FLASH_FLASH_SEC2BBR2_SEC2BB1                 
$00000004 constant FLASH_FLASH_SEC2BBR2_SEC2BB2                 
$00000008 constant FLASH_FLASH_SEC2BBR2_SEC2BB3                 
$00000010 constant FLASH_FLASH_SEC2BBR2_SEC2BB4                 
$00000020 constant FLASH_FLASH_SEC2BBR2_SEC2BB5                 
$00000040 constant FLASH_FLASH_SEC2BBR2_SEC2BB6                 
$00000080 constant FLASH_FLASH_SEC2BBR2_SEC2BB7                 
$00000100 constant FLASH_FLASH_SEC2BBR2_SEC2BB8                 
$00000200 constant FLASH_FLASH_SEC2BBR2_SEC2BB9                 
$00000400 constant FLASH_FLASH_SEC2BBR2_SEC2BB10                
$00000800 constant FLASH_FLASH_SEC2BBR2_SEC2BB11                
$00001000 constant FLASH_FLASH_SEC2BBR2_SEC2BB12                
$00002000 constant FLASH_FLASH_SEC2BBR2_SEC2BB13                
$00004000 constant FLASH_FLASH_SEC2BBR2_SEC2BB14                
$00008000 constant FLASH_FLASH_SEC2BBR2_SEC2BB15                
$00010000 constant FLASH_FLASH_SEC2BBR2_SEC2BB16                
$00020000 constant FLASH_FLASH_SEC2BBR2_SEC2BB17                
$00040000 constant FLASH_FLASH_SEC2BBR2_SEC2BB18                
$00080000 constant FLASH_FLASH_SEC2BBR2_SEC2BB19                
$00100000 constant FLASH_FLASH_SEC2BBR2_SEC2BB20                
$00200000 constant FLASH_FLASH_SEC2BBR2_SEC2BB21                
$00400000 constant FLASH_FLASH_SEC2BBR2_SEC2BB22                
$00800000 constant FLASH_FLASH_SEC2BBR2_SEC2BB23                
$01000000 constant FLASH_FLASH_SEC2BBR2_SEC2BB24                
$02000000 constant FLASH_FLASH_SEC2BBR2_SEC2BB25                
$04000000 constant FLASH_FLASH_SEC2BBR2_SEC2BB26                
$08000000 constant FLASH_FLASH_SEC2BBR2_SEC2BB27                
$10000000 constant FLASH_FLASH_SEC2BBR2_SEC2BB28                
$20000000 constant FLASH_FLASH_SEC2BBR2_SEC2BB29                
$40000000 constant FLASH_FLASH_SEC2BBR2_SEC2BB30                
$80000000 constant FLASH_FLASH_SEC2BBR2_SEC2BB31                


\
\ @brief FLASH secure block based bank 2 register 3
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC2BBR3_SEC2BB0                 
$00000002 constant FLASH_FLASH_SEC2BBR3_SEC2BB1                 
$00000004 constant FLASH_FLASH_SEC2BBR3_SEC2BB2                 
$00000008 constant FLASH_FLASH_SEC2BBR3_SEC2BB3                 
$00000010 constant FLASH_FLASH_SEC2BBR3_SEC2BB4                 
$00000020 constant FLASH_FLASH_SEC2BBR3_SEC2BB5                 
$00000040 constant FLASH_FLASH_SEC2BBR3_SEC2BB6                 
$00000080 constant FLASH_FLASH_SEC2BBR3_SEC2BB7                 
$00000100 constant FLASH_FLASH_SEC2BBR3_SEC2BB8                 
$00000200 constant FLASH_FLASH_SEC2BBR3_SEC2BB9                 
$00000400 constant FLASH_FLASH_SEC2BBR3_SEC2BB10                
$00000800 constant FLASH_FLASH_SEC2BBR3_SEC2BB11                
$00001000 constant FLASH_FLASH_SEC2BBR3_SEC2BB12                
$00002000 constant FLASH_FLASH_SEC2BBR3_SEC2BB13                
$00004000 constant FLASH_FLASH_SEC2BBR3_SEC2BB14                
$00008000 constant FLASH_FLASH_SEC2BBR3_SEC2BB15                
$00010000 constant FLASH_FLASH_SEC2BBR3_SEC2BB16                
$00020000 constant FLASH_FLASH_SEC2BBR3_SEC2BB17                
$00040000 constant FLASH_FLASH_SEC2BBR3_SEC2BB18                
$00080000 constant FLASH_FLASH_SEC2BBR3_SEC2BB19                
$00100000 constant FLASH_FLASH_SEC2BBR3_SEC2BB20                
$00200000 constant FLASH_FLASH_SEC2BBR3_SEC2BB21                
$00400000 constant FLASH_FLASH_SEC2BBR3_SEC2BB22                
$00800000 constant FLASH_FLASH_SEC2BBR3_SEC2BB23                
$01000000 constant FLASH_FLASH_SEC2BBR3_SEC2BB24                
$02000000 constant FLASH_FLASH_SEC2BBR3_SEC2BB25                
$04000000 constant FLASH_FLASH_SEC2BBR3_SEC2BB26                
$08000000 constant FLASH_FLASH_SEC2BBR3_SEC2BB27                
$10000000 constant FLASH_FLASH_SEC2BBR3_SEC2BB28                
$20000000 constant FLASH_FLASH_SEC2BBR3_SEC2BB29                
$40000000 constant FLASH_FLASH_SEC2BBR3_SEC2BB30                
$80000000 constant FLASH_FLASH_SEC2BBR3_SEC2BB31                


\
\ @brief FLASH secure block based bank 2 register 4
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC2BBR4_SEC2BB0                 
$00000002 constant FLASH_FLASH_SEC2BBR4_SEC2BB1                 
$00000004 constant FLASH_FLASH_SEC2BBR4_SEC2BB2                 
$00000008 constant FLASH_FLASH_SEC2BBR4_SEC2BB3                 
$00000010 constant FLASH_FLASH_SEC2BBR4_SEC2BB4                 
$00000020 constant FLASH_FLASH_SEC2BBR4_SEC2BB5                 
$00000040 constant FLASH_FLASH_SEC2BBR4_SEC2BB6                 
$00000080 constant FLASH_FLASH_SEC2BBR4_SEC2BB7                 
$00000100 constant FLASH_FLASH_SEC2BBR4_SEC2BB8                 
$00000200 constant FLASH_FLASH_SEC2BBR4_SEC2BB9                 
$00000400 constant FLASH_FLASH_SEC2BBR4_SEC2BB10                
$00000800 constant FLASH_FLASH_SEC2BBR4_SEC2BB11                
$00001000 constant FLASH_FLASH_SEC2BBR4_SEC2BB12                
$00002000 constant FLASH_FLASH_SEC2BBR4_SEC2BB13                
$00004000 constant FLASH_FLASH_SEC2BBR4_SEC2BB14                
$00008000 constant FLASH_FLASH_SEC2BBR4_SEC2BB15                
$00010000 constant FLASH_FLASH_SEC2BBR4_SEC2BB16                
$00020000 constant FLASH_FLASH_SEC2BBR4_SEC2BB17                
$00040000 constant FLASH_FLASH_SEC2BBR4_SEC2BB18                
$00080000 constant FLASH_FLASH_SEC2BBR4_SEC2BB19                
$00100000 constant FLASH_FLASH_SEC2BBR4_SEC2BB20                
$00200000 constant FLASH_FLASH_SEC2BBR4_SEC2BB21                
$00400000 constant FLASH_FLASH_SEC2BBR4_SEC2BB22                
$00800000 constant FLASH_FLASH_SEC2BBR4_SEC2BB23                
$01000000 constant FLASH_FLASH_SEC2BBR4_SEC2BB24                
$02000000 constant FLASH_FLASH_SEC2BBR4_SEC2BB25                
$04000000 constant FLASH_FLASH_SEC2BBR4_SEC2BB26                
$08000000 constant FLASH_FLASH_SEC2BBR4_SEC2BB27                
$10000000 constant FLASH_FLASH_SEC2BBR4_SEC2BB28                
$20000000 constant FLASH_FLASH_SEC2BBR4_SEC2BB29                
$40000000 constant FLASH_FLASH_SEC2BBR4_SEC2BB30                
$80000000 constant FLASH_FLASH_SEC2BBR4_SEC2BB31                


\
\ @brief FLASH secure block based bank 2 register 5
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC2BBR5_SEC2BB0                 
$00000002 constant FLASH_FLASH_SEC2BBR5_SEC2BB1                 
$00000004 constant FLASH_FLASH_SEC2BBR5_SEC2BB2                 
$00000008 constant FLASH_FLASH_SEC2BBR5_SEC2BB3                 
$00000010 constant FLASH_FLASH_SEC2BBR5_SEC2BB4                 
$00000020 constant FLASH_FLASH_SEC2BBR5_SEC2BB5                 
$00000040 constant FLASH_FLASH_SEC2BBR5_SEC2BB6                 
$00000080 constant FLASH_FLASH_SEC2BBR5_SEC2BB7                 
$00000100 constant FLASH_FLASH_SEC2BBR5_SEC2BB8                 
$00000200 constant FLASH_FLASH_SEC2BBR5_SEC2BB9                 
$00000400 constant FLASH_FLASH_SEC2BBR5_SEC2BB10                
$00000800 constant FLASH_FLASH_SEC2BBR5_SEC2BB11                
$00001000 constant FLASH_FLASH_SEC2BBR5_SEC2BB12                
$00002000 constant FLASH_FLASH_SEC2BBR5_SEC2BB13                
$00004000 constant FLASH_FLASH_SEC2BBR5_SEC2BB14                
$00008000 constant FLASH_FLASH_SEC2BBR5_SEC2BB15                
$00010000 constant FLASH_FLASH_SEC2BBR5_SEC2BB16                
$00020000 constant FLASH_FLASH_SEC2BBR5_SEC2BB17                
$00040000 constant FLASH_FLASH_SEC2BBR5_SEC2BB18                
$00080000 constant FLASH_FLASH_SEC2BBR5_SEC2BB19                
$00100000 constant FLASH_FLASH_SEC2BBR5_SEC2BB20                
$00200000 constant FLASH_FLASH_SEC2BBR5_SEC2BB21                
$00400000 constant FLASH_FLASH_SEC2BBR5_SEC2BB22                
$00800000 constant FLASH_FLASH_SEC2BBR5_SEC2BB23                
$01000000 constant FLASH_FLASH_SEC2BBR5_SEC2BB24                
$02000000 constant FLASH_FLASH_SEC2BBR5_SEC2BB25                
$04000000 constant FLASH_FLASH_SEC2BBR5_SEC2BB26                
$08000000 constant FLASH_FLASH_SEC2BBR5_SEC2BB27                
$10000000 constant FLASH_FLASH_SEC2BBR5_SEC2BB28                
$20000000 constant FLASH_FLASH_SEC2BBR5_SEC2BB29                
$40000000 constant FLASH_FLASH_SEC2BBR5_SEC2BB30                
$80000000 constant FLASH_FLASH_SEC2BBR5_SEC2BB31                


\
\ @brief FLASH secure block based bank 2 register 6
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC2BBR6_SEC2BB0                 
$00000002 constant FLASH_FLASH_SEC2BBR6_SEC2BB1                 
$00000004 constant FLASH_FLASH_SEC2BBR6_SEC2BB2                 
$00000008 constant FLASH_FLASH_SEC2BBR6_SEC2BB3                 
$00000010 constant FLASH_FLASH_SEC2BBR6_SEC2BB4                 
$00000020 constant FLASH_FLASH_SEC2BBR6_SEC2BB5                 
$00000040 constant FLASH_FLASH_SEC2BBR6_SEC2BB6                 
$00000080 constant FLASH_FLASH_SEC2BBR6_SEC2BB7                 
$00000100 constant FLASH_FLASH_SEC2BBR6_SEC2BB8                 
$00000200 constant FLASH_FLASH_SEC2BBR6_SEC2BB9                 
$00000400 constant FLASH_FLASH_SEC2BBR6_SEC2BB10                
$00000800 constant FLASH_FLASH_SEC2BBR6_SEC2BB11                
$00001000 constant FLASH_FLASH_SEC2BBR6_SEC2BB12                
$00002000 constant FLASH_FLASH_SEC2BBR6_SEC2BB13                
$00004000 constant FLASH_FLASH_SEC2BBR6_SEC2BB14                
$00008000 constant FLASH_FLASH_SEC2BBR6_SEC2BB15                
$00010000 constant FLASH_FLASH_SEC2BBR6_SEC2BB16                
$00020000 constant FLASH_FLASH_SEC2BBR6_SEC2BB17                
$00040000 constant FLASH_FLASH_SEC2BBR6_SEC2BB18                
$00080000 constant FLASH_FLASH_SEC2BBR6_SEC2BB19                
$00100000 constant FLASH_FLASH_SEC2BBR6_SEC2BB20                
$00200000 constant FLASH_FLASH_SEC2BBR6_SEC2BB21                
$00400000 constant FLASH_FLASH_SEC2BBR6_SEC2BB22                
$00800000 constant FLASH_FLASH_SEC2BBR6_SEC2BB23                
$01000000 constant FLASH_FLASH_SEC2BBR6_SEC2BB24                
$02000000 constant FLASH_FLASH_SEC2BBR6_SEC2BB25                
$04000000 constant FLASH_FLASH_SEC2BBR6_SEC2BB26                
$08000000 constant FLASH_FLASH_SEC2BBR6_SEC2BB27                
$10000000 constant FLASH_FLASH_SEC2BBR6_SEC2BB28                
$20000000 constant FLASH_FLASH_SEC2BBR6_SEC2BB29                
$40000000 constant FLASH_FLASH_SEC2BBR6_SEC2BB30                
$80000000 constant FLASH_FLASH_SEC2BBR6_SEC2BB31                


\
\ @brief FLASH secure block based bank 2 register 7
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC2BBR7_SEC2BB0                 
$00000002 constant FLASH_FLASH_SEC2BBR7_SEC2BB1                 
$00000004 constant FLASH_FLASH_SEC2BBR7_SEC2BB2                 
$00000008 constant FLASH_FLASH_SEC2BBR7_SEC2BB3                 
$00000010 constant FLASH_FLASH_SEC2BBR7_SEC2BB4                 
$00000020 constant FLASH_FLASH_SEC2BBR7_SEC2BB5                 
$00000040 constant FLASH_FLASH_SEC2BBR7_SEC2BB6                 
$00000080 constant FLASH_FLASH_SEC2BBR7_SEC2BB7                 
$00000100 constant FLASH_FLASH_SEC2BBR7_SEC2BB8                 
$00000200 constant FLASH_FLASH_SEC2BBR7_SEC2BB9                 
$00000400 constant FLASH_FLASH_SEC2BBR7_SEC2BB10                
$00000800 constant FLASH_FLASH_SEC2BBR7_SEC2BB11                
$00001000 constant FLASH_FLASH_SEC2BBR7_SEC2BB12                
$00002000 constant FLASH_FLASH_SEC2BBR7_SEC2BB13                
$00004000 constant FLASH_FLASH_SEC2BBR7_SEC2BB14                
$00008000 constant FLASH_FLASH_SEC2BBR7_SEC2BB15                
$00010000 constant FLASH_FLASH_SEC2BBR7_SEC2BB16                
$00020000 constant FLASH_FLASH_SEC2BBR7_SEC2BB17                
$00040000 constant FLASH_FLASH_SEC2BBR7_SEC2BB18                
$00080000 constant FLASH_FLASH_SEC2BBR7_SEC2BB19                
$00100000 constant FLASH_FLASH_SEC2BBR7_SEC2BB20                
$00200000 constant FLASH_FLASH_SEC2BBR7_SEC2BB21                
$00400000 constant FLASH_FLASH_SEC2BBR7_SEC2BB22                
$00800000 constant FLASH_FLASH_SEC2BBR7_SEC2BB23                
$01000000 constant FLASH_FLASH_SEC2BBR7_SEC2BB24                
$02000000 constant FLASH_FLASH_SEC2BBR7_SEC2BB25                
$04000000 constant FLASH_FLASH_SEC2BBR7_SEC2BB26                
$08000000 constant FLASH_FLASH_SEC2BBR7_SEC2BB27                
$10000000 constant FLASH_FLASH_SEC2BBR7_SEC2BB28                
$20000000 constant FLASH_FLASH_SEC2BBR7_SEC2BB29                
$40000000 constant FLASH_FLASH_SEC2BBR7_SEC2BB30                
$80000000 constant FLASH_FLASH_SEC2BBR7_SEC2BB31                


\
\ @brief FLASH secure block based bank 2 register 8
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SEC2BBR8_SEC2BB0                 
$00000002 constant FLASH_FLASH_SEC2BBR8_SEC2BB1                 
$00000004 constant FLASH_FLASH_SEC2BBR8_SEC2BB2                 
$00000008 constant FLASH_FLASH_SEC2BBR8_SEC2BB3                 
$00000010 constant FLASH_FLASH_SEC2BBR8_SEC2BB4                 
$00000020 constant FLASH_FLASH_SEC2BBR8_SEC2BB5                 
$00000040 constant FLASH_FLASH_SEC2BBR8_SEC2BB6                 
$00000080 constant FLASH_FLASH_SEC2BBR8_SEC2BB7                 
$00000100 constant FLASH_FLASH_SEC2BBR8_SEC2BB8                 
$00000200 constant FLASH_FLASH_SEC2BBR8_SEC2BB9                 
$00000400 constant FLASH_FLASH_SEC2BBR8_SEC2BB10                
$00000800 constant FLASH_FLASH_SEC2BBR8_SEC2BB11                
$00001000 constant FLASH_FLASH_SEC2BBR8_SEC2BB12                
$00002000 constant FLASH_FLASH_SEC2BBR8_SEC2BB13                
$00004000 constant FLASH_FLASH_SEC2BBR8_SEC2BB14                
$00008000 constant FLASH_FLASH_SEC2BBR8_SEC2BB15                
$00010000 constant FLASH_FLASH_SEC2BBR8_SEC2BB16                
$00020000 constant FLASH_FLASH_SEC2BBR8_SEC2BB17                
$00040000 constant FLASH_FLASH_SEC2BBR8_SEC2BB18                
$00080000 constant FLASH_FLASH_SEC2BBR8_SEC2BB19                
$00100000 constant FLASH_FLASH_SEC2BBR8_SEC2BB20                
$00200000 constant FLASH_FLASH_SEC2BBR8_SEC2BB21                
$00400000 constant FLASH_FLASH_SEC2BBR8_SEC2BB22                
$00800000 constant FLASH_FLASH_SEC2BBR8_SEC2BB23                
$01000000 constant FLASH_FLASH_SEC2BBR8_SEC2BB24                
$02000000 constant FLASH_FLASH_SEC2BBR8_SEC2BB25                
$04000000 constant FLASH_FLASH_SEC2BBR8_SEC2BB26                
$08000000 constant FLASH_FLASH_SEC2BBR8_SEC2BB27                
$10000000 constant FLASH_FLASH_SEC2BBR8_SEC2BB28                
$20000000 constant FLASH_FLASH_SEC2BBR8_SEC2BB29                
$40000000 constant FLASH_FLASH_SEC2BBR8_SEC2BB30                
$80000000 constant FLASH_FLASH_SEC2BBR8_SEC2BB31                


\
\ @brief FLASH secure HDP control register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SECHDPCR_HDP1_ACCDIS                 \ HDP1 area access disable When set, this bit is only cleared by a system reset.
$00000002 constant FLASH_FLASH_SECHDPCR_HDP2_ACCDIS                 \ HDP2 area access disable When set, this bit is only cleared by a system reset.


\
\ @brief FLASH privilege configuration register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIVCFGR_SPRIV                       \ Privileged protection for secure registers
$00000002 constant FLASH_FLASH_PRIVCFGR_NSPRIV                      \ Privileged protection for non-secure registers


\
\ @brief FLASH privilege block based bank 1 register 1
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB0               
$00000002 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB1               
$00000004 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB2               
$00000008 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB3               
$00000010 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB4               
$00000020 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB5               
$00000040 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB6               
$00000080 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB7               
$00000100 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB8               
$00000200 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB9               
$00000400 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB10              
$00000800 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB11              
$00001000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB12              
$00002000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB13              
$00004000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB14              
$00008000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB15              
$00010000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB16              
$00020000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB17              
$00040000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB18              
$00080000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB19              
$00100000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB20              
$00200000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB21              
$00400000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB22              
$00800000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB23              
$01000000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB24              
$02000000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB25              
$04000000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB26              
$08000000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB27              
$10000000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB28              
$20000000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB29              
$40000000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB30              
$80000000 constant FLASH_FLASH_PRIV1BBR1_PRIV1BB31              


\
\ @brief FLASH privilege block based bank 1 register 2
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB0               
$00000002 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB1               
$00000004 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB2               
$00000008 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB3               
$00000010 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB4               
$00000020 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB5               
$00000040 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB6               
$00000080 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB7               
$00000100 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB8               
$00000200 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB9               
$00000400 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB10              
$00000800 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB11              
$00001000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB12              
$00002000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB13              
$00004000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB14              
$00008000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB15              
$00010000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB16              
$00020000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB17              
$00040000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB18              
$00080000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB19              
$00100000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB20              
$00200000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB21              
$00400000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB22              
$00800000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB23              
$01000000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB24              
$02000000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB25              
$04000000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB26              
$08000000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB27              
$10000000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB28              
$20000000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB29              
$40000000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB30              
$80000000 constant FLASH_FLASH_PRIV1BBR2_PRIV1BB31              


\
\ @brief FLASH privilege block based bank 1 register 3
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB0               
$00000002 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB1               
$00000004 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB2               
$00000008 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB3               
$00000010 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB4               
$00000020 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB5               
$00000040 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB6               
$00000080 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB7               
$00000100 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB8               
$00000200 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB9               
$00000400 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB10              
$00000800 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB11              
$00001000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB12              
$00002000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB13              
$00004000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB14              
$00008000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB15              
$00010000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB16              
$00020000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB17              
$00040000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB18              
$00080000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB19              
$00100000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB20              
$00200000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB21              
$00400000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB22              
$00800000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB23              
$01000000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB24              
$02000000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB25              
$04000000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB26              
$08000000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB27              
$10000000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB28              
$20000000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB29              
$40000000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB30              
$80000000 constant FLASH_FLASH_PRIV1BBR3_PRIV1BB31              


\
\ @brief FLASH privilege block based bank 1 register 4
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB0               
$00000002 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB1               
$00000004 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB2               
$00000008 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB3               
$00000010 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB4               
$00000020 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB5               
$00000040 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB6               
$00000080 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB7               
$00000100 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB8               
$00000200 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB9               
$00000400 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB10              
$00000800 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB11              
$00001000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB12              
$00002000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB13              
$00004000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB14              
$00008000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB15              
$00010000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB16              
$00020000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB17              
$00040000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB18              
$00080000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB19              
$00100000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB20              
$00200000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB21              
$00400000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB22              
$00800000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB23              
$01000000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB24              
$02000000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB25              
$04000000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB26              
$08000000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB27              
$10000000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB28              
$20000000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB29              
$40000000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB30              
$80000000 constant FLASH_FLASH_PRIV1BBR4_PRIV1BB31              


\
\ @brief FLASH privilege block based bank 1 register 5
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB0               
$00000002 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB1               
$00000004 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB2               
$00000008 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB3               
$00000010 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB4               
$00000020 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB5               
$00000040 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB6               
$00000080 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB7               
$00000100 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB8               
$00000200 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB9               
$00000400 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB10              
$00000800 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB11              
$00001000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB12              
$00002000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB13              
$00004000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB14              
$00008000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB15              
$00010000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB16              
$00020000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB17              
$00040000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB18              
$00080000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB19              
$00100000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB20              
$00200000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB21              
$00400000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB22              
$00800000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB23              
$01000000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB24              
$02000000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB25              
$04000000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB26              
$08000000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB27              
$10000000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB28              
$20000000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB29              
$40000000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB30              
$80000000 constant FLASH_FLASH_PRIV1BBR5_PRIV1BB31              


\
\ @brief FLASH privilege block based bank 1 register 6
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB0               
$00000002 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB1               
$00000004 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB2               
$00000008 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB3               
$00000010 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB4               
$00000020 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB5               
$00000040 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB6               
$00000080 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB7               
$00000100 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB8               
$00000200 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB9               
$00000400 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB10              
$00000800 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB11              
$00001000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB12              
$00002000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB13              
$00004000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB14              
$00008000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB15              
$00010000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB16              
$00020000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB17              
$00040000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB18              
$00080000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB19              
$00100000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB20              
$00200000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB21              
$00400000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB22              
$00800000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB23              
$01000000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB24              
$02000000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB25              
$04000000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB26              
$08000000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB27              
$10000000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB28              
$20000000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB29              
$40000000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB30              
$80000000 constant FLASH_FLASH_PRIV1BBR6_PRIV1BB31              


\
\ @brief FLASH privilege block based bank 1 register 7
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB0               
$00000002 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB1               
$00000004 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB2               
$00000008 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB3               
$00000010 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB4               
$00000020 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB5               
$00000040 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB6               
$00000080 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB7               
$00000100 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB8               
$00000200 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB9               
$00000400 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB10              
$00000800 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB11              
$00001000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB12              
$00002000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB13              
$00004000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB14              
$00008000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB15              
$00010000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB16              
$00020000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB17              
$00040000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB18              
$00080000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB19              
$00100000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB20              
$00200000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB21              
$00400000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB22              
$00800000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB23              
$01000000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB24              
$02000000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB25              
$04000000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB26              
$08000000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB27              
$10000000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB28              
$20000000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB29              
$40000000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB30              
$80000000 constant FLASH_FLASH_PRIV1BBR7_PRIV1BB31              


\
\ @brief FLASH privilege block based bank 1 register 8
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB0               
$00000002 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB1               
$00000004 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB2               
$00000008 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB3               
$00000010 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB4               
$00000020 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB5               
$00000040 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB6               
$00000080 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB7               
$00000100 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB8               
$00000200 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB9               
$00000400 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB10              
$00000800 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB11              
$00001000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB12              
$00002000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB13              
$00004000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB14              
$00008000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB15              
$00010000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB16              
$00020000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB17              
$00040000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB18              
$00080000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB19              
$00100000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB20              
$00200000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB21              
$00400000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB22              
$00800000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB23              
$01000000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB24              
$02000000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB25              
$04000000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB26              
$08000000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB27              
$10000000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB28              
$20000000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB29              
$40000000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB30              
$80000000 constant FLASH_FLASH_PRIV1BBR8_PRIV1BB31              


\
\ @brief FLASH privilege block based bank 2 register 1
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB0               
$00000002 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB1               
$00000004 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB2               
$00000008 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB3               
$00000010 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB4               
$00000020 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB5               
$00000040 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB6               
$00000080 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB7               
$00000100 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB8               
$00000200 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB9               
$00000400 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB10              
$00000800 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB11              
$00001000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB12              
$00002000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB13              
$00004000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB14              
$00008000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB15              
$00010000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB16              
$00020000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB17              
$00040000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB18              
$00080000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB19              
$00100000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB20              
$00200000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB21              
$00400000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB22              
$00800000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB23              
$01000000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB24              
$02000000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB25              
$04000000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB26              
$08000000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB27              
$10000000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB28              
$20000000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB29              
$40000000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB30              
$80000000 constant FLASH_FLASH_PRIV2BBR1_PRIV2BB31              


\
\ @brief FLASH privilege block based bank 2 register 2
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB0               
$00000002 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB1               
$00000004 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB2               
$00000008 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB3               
$00000010 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB4               
$00000020 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB5               
$00000040 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB6               
$00000080 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB7               
$00000100 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB8               
$00000200 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB9               
$00000400 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB10              
$00000800 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB11              
$00001000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB12              
$00002000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB13              
$00004000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB14              
$00008000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB15              
$00010000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB16              
$00020000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB17              
$00040000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB18              
$00080000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB19              
$00100000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB20              
$00200000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB21              
$00400000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB22              
$00800000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB23              
$01000000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB24              
$02000000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB25              
$04000000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB26              
$08000000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB27              
$10000000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB28              
$20000000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB29              
$40000000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB30              
$80000000 constant FLASH_FLASH_PRIV2BBR2_PRIV2BB31              


\
\ @brief FLASH privilege block based bank 2 register 3
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB0               
$00000002 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB1               
$00000004 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB2               
$00000008 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB3               
$00000010 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB4               
$00000020 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB5               
$00000040 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB6               
$00000080 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB7               
$00000100 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB8               
$00000200 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB9               
$00000400 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB10              
$00000800 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB11              
$00001000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB12              
$00002000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB13              
$00004000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB14              
$00008000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB15              
$00010000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB16              
$00020000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB17              
$00040000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB18              
$00080000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB19              
$00100000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB20              
$00200000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB21              
$00400000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB22              
$00800000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB23              
$01000000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB24              
$02000000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB25              
$04000000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB26              
$08000000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB27              
$10000000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB28              
$20000000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB29              
$40000000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB30              
$80000000 constant FLASH_FLASH_PRIV2BBR3_PRIV2BB31              


\
\ @brief FLASH privilege block based bank 2 register 4
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB0               
$00000002 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB1               
$00000004 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB2               
$00000008 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB3               
$00000010 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB4               
$00000020 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB5               
$00000040 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB6               
$00000080 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB7               
$00000100 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB8               
$00000200 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB9               
$00000400 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB10              
$00000800 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB11              
$00001000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB12              
$00002000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB13              
$00004000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB14              
$00008000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB15              
$00010000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB16              
$00020000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB17              
$00040000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB18              
$00080000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB19              
$00100000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB20              
$00200000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB21              
$00400000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB22              
$00800000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB23              
$01000000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB24              
$02000000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB25              
$04000000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB26              
$08000000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB27              
$10000000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB28              
$20000000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB29              
$40000000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB30              
$80000000 constant FLASH_FLASH_PRIV2BBR4_PRIV2BB31              


\
\ @brief FLASH privilege block based bank 2 register 5
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB0               
$00000002 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB1               
$00000004 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB2               
$00000008 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB3               
$00000010 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB4               
$00000020 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB5               
$00000040 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB6               
$00000080 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB7               
$00000100 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB8               
$00000200 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB9               
$00000400 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB10              
$00000800 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB11              
$00001000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB12              
$00002000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB13              
$00004000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB14              
$00008000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB15              
$00010000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB16              
$00020000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB17              
$00040000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB18              
$00080000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB19              
$00100000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB20              
$00200000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB21              
$00400000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB22              
$00800000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB23              
$01000000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB24              
$02000000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB25              
$04000000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB26              
$08000000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB27              
$10000000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB28              
$20000000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB29              
$40000000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB30              
$80000000 constant FLASH_FLASH_PRIV2BBR5_PRIV2BB31              


\
\ @brief FLASH privilege block based bank 2 register 6
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB0               
$00000002 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB1               
$00000004 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB2               
$00000008 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB3               
$00000010 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB4               
$00000020 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB5               
$00000040 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB6               
$00000080 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB7               
$00000100 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB8               
$00000200 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB9               
$00000400 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB10              
$00000800 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB11              
$00001000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB12              
$00002000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB13              
$00004000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB14              
$00008000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB15              
$00010000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB16              
$00020000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB17              
$00040000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB18              
$00080000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB19              
$00100000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB20              
$00200000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB21              
$00400000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB22              
$00800000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB23              
$01000000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB24              
$02000000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB25              
$04000000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB26              
$08000000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB27              
$10000000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB28              
$20000000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB29              
$40000000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB30              
$80000000 constant FLASH_FLASH_PRIV2BBR6_PRIV2BB31              


\
\ @brief FLASH privilege block based bank 2 register 7
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB0               
$00000002 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB1               
$00000004 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB2               
$00000008 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB3               
$00000010 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB4               
$00000020 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB5               
$00000040 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB6               
$00000080 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB7               
$00000100 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB8               
$00000200 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB9               
$00000400 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB10              
$00000800 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB11              
$00001000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB12              
$00002000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB13              
$00004000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB14              
$00008000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB15              
$00010000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB16              
$00020000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB17              
$00040000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB18              
$00080000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB19              
$00100000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB20              
$00200000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB21              
$00400000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB22              
$00800000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB23              
$01000000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB24              
$02000000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB25              
$04000000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB26              
$08000000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB27              
$10000000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB28              
$20000000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB29              
$40000000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB30              
$80000000 constant FLASH_FLASH_PRIV2BBR7_PRIV2BB31              


\
\ @brief FLASH privilege block based bank 2 register 8
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB0               
$00000002 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB1               
$00000004 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB2               
$00000008 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB3               
$00000010 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB4               
$00000020 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB5               
$00000040 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB6               
$00000080 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB7               
$00000100 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB8               
$00000200 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB9               
$00000400 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB10              
$00000800 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB11              
$00001000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB12              
$00002000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB13              
$00004000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB14              
$00008000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB15              
$00010000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB16              
$00020000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB17              
$00040000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB18              
$00080000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB19              
$00100000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB20              
$00200000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB21              
$00400000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB22              
$00800000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB23              
$01000000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB24              
$02000000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB25              
$04000000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB26              
$08000000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB27              
$10000000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB28              
$20000000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB29              
$40000000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB30              
$80000000 constant FLASH_FLASH_PRIV2BBR8_PRIV2BB31              


\
\ @brief Flash
\
$40022000 constant FLASH_FLASH_ACR  \ offset: 0x00 : FLASH access control register
$40022008 constant FLASH_FLASH_NSKEYR  \ offset: 0x08 : FLASH non-secure key register
$4002200c constant FLASH_FLASH_SECKEYR  \ offset: 0x0C : FLASH secure key register
$40022010 constant FLASH_FLASH_OPTKEYR  \ offset: 0x10 : FLASH option key register
$40022018 constant FLASH_FLASH_PDKEY1R  \ offset: 0x18 : FLASH bank 1 power-down key register
$4002201c constant FLASH_FLASH_PDKEY2R  \ offset: 0x1C : FLASH bank 2 power-down key register
$40022020 constant FLASH_FLASH_NSSR  \ offset: 0x20 : FLASH non-secure status register
$40022024 constant FLASH_FLASH_SECSR  \ offset: 0x24 : FLASH secure status register
$40022028 constant FLASH_FLASH_NSCR  \ offset: 0x28 : FLASH non-secure control register
$4002202c constant FLASH_FLASH_SECCR  \ offset: 0x2C : FLASH secure control register
$40022030 constant FLASH_FLASH_ECCR  \ offset: 0x30 : FLASH ECC register
$40022034 constant FLASH_FLASH_OPSR  \ offset: 0x34 : FLASH operation status register
$40022040 constant FLASH_FLASH_OPTR  \ offset: 0x40 : FLASH option register
$40022044 constant FLASH_FLASH_NSBOOTADD0R  \ offset: 0x44 : FLASH non-secure boot address 0 register
$40022048 constant FLASH_FLASH_NSBOOTADD1R  \ offset: 0x48 : FLASH non-secure boot address 1 register
$4002204c constant FLASH_FLASH_SECBOOTADD0R  \ offset: 0x4C : FLASH secure boot address 0 register
$40022050 constant FLASH_FLASH_SECWM1R1  \ offset: 0x50 : FLASH secure watermark1 register 1
$40022054 constant FLASH_FLASH_SECWM1R2  \ offset: 0x54 : FLASH secure watermark1 register 2
$40022058 constant FLASH_FLASH_WRP1AR  \ offset: 0x58 : FLASH WRP1 area A address register
$4002205c constant FLASH_FLASH_WRP1BR  \ offset: 0x5C : FLASH WRP1 area B address register
$40022060 constant FLASH_FLASH_SECWM2R1  \ offset: 0x60 : FLASH secure watermark2 register 1
$40022064 constant FLASH_FLASH_SECWM2R2  \ offset: 0x64 : FLASH secure watermark2 register 2
$40022068 constant FLASH_FLASH_WRP2AR  \ offset: 0x68 : FLASH WPR2 area A address register
$4002206c constant FLASH_FLASH_WRP2BR  \ offset: 0x6C : FLASH WPR2 area B address register
$40022070 constant FLASH_FLASH_OEM1KEYR1  \ offset: 0x70 : FLASH OEM1 key register 1
$40022074 constant FLASH_FLASH_OEM1KEYR2  \ offset: 0x74 : FLASH OEM1 key register 2
$40022078 constant FLASH_FLASH_OEM2KEYR1  \ offset: 0x78 : FLASH OEM2 key register 1
$4002207c constant FLASH_FLASH_OEM2KEYR2  \ offset: 0x7C : FLASH OEM2 key register 2
$40022080 constant FLASH_FLASH_SEC1BBR1  \ offset: 0x80 : FLASH secure block based bank 1 register 1
$40022084 constant FLASH_FLASH_SEC1BBR2  \ offset: 0x84 : FLASH secure block based bank 1 register 2
$40022088 constant FLASH_FLASH_SEC1BBR3  \ offset: 0x88 : FLASH secure block based bank 1 register 3
$4002208c constant FLASH_FLASH_SEC1BBR4  \ offset: 0x8C : FLASH secure block based bank 1 register 4
$40022090 constant FLASH_FLASH_SEC1BBR5  \ offset: 0x90 : FLASH secure block based bank 1 register 5
$40022094 constant FLASH_FLASH_SEC1BBR6  \ offset: 0x94 : FLASH secure block based bank 1 register 6
$40022098 constant FLASH_FLASH_SEC1BBR7  \ offset: 0x98 : FLASH secure block based bank 1 register 7
$4002209c constant FLASH_FLASH_SEC1BBR8  \ offset: 0x9C : FLASH secure block based bank 1 register 8
$400220a0 constant FLASH_FLASH_SEC2BBR1  \ offset: 0xA0 : FLASH secure block based bank 2 register 1
$400220a4 constant FLASH_FLASH_SEC2BBR2  \ offset: 0xA4 : FLASH secure block based bank 2 register 2
$400220a8 constant FLASH_FLASH_SEC2BBR3  \ offset: 0xA8 : FLASH secure block based bank 2 register 3
$400220ac constant FLASH_FLASH_SEC2BBR4  \ offset: 0xAC : FLASH secure block based bank 2 register 4
$400220b0 constant FLASH_FLASH_SEC2BBR5  \ offset: 0xB0 : FLASH secure block based bank 2 register 5
$400220b4 constant FLASH_FLASH_SEC2BBR6  \ offset: 0xB4 : FLASH secure block based bank 2 register 6
$400220b8 constant FLASH_FLASH_SEC2BBR7  \ offset: 0xB8 : FLASH secure block based bank 2 register 7
$400220bc constant FLASH_FLASH_SEC2BBR8  \ offset: 0xBC : FLASH secure block based bank 2 register 8
$400220c0 constant FLASH_FLASH_SECHDPCR  \ offset: 0xC0 : FLASH secure HDP control register
$400220c4 constant FLASH_FLASH_PRIVCFGR  \ offset: 0xC4 : FLASH privilege configuration register
$400220d0 constant FLASH_FLASH_PRIV1BBR1  \ offset: 0xD0 : FLASH privilege block based bank 1 register 1
$400220d4 constant FLASH_FLASH_PRIV1BBR2  \ offset: 0xD4 : FLASH privilege block based bank 1 register 2
$400220d8 constant FLASH_FLASH_PRIV1BBR3  \ offset: 0xD8 : FLASH privilege block based bank 1 register 3
$400220dc constant FLASH_FLASH_PRIV1BBR4  \ offset: 0xDC : FLASH privilege block based bank 1 register 4
$400220e0 constant FLASH_FLASH_PRIV1BBR5  \ offset: 0xE0 : FLASH privilege block based bank 1 register 5
$400220e4 constant FLASH_FLASH_PRIV1BBR6  \ offset: 0xE4 : FLASH privilege block based bank 1 register 6
$400220e8 constant FLASH_FLASH_PRIV1BBR7  \ offset: 0xE8 : FLASH privilege block based bank 1 register 7
$400220ec constant FLASH_FLASH_PRIV1BBR8  \ offset: 0xEC : FLASH privilege block based bank 1 register 8
$400220f0 constant FLASH_FLASH_PRIV2BBR1  \ offset: 0xF0 : FLASH privilege block based bank 2 register 1
$400220f4 constant FLASH_FLASH_PRIV2BBR2  \ offset: 0xF4 : FLASH privilege block based bank 2 register 2
$400220f8 constant FLASH_FLASH_PRIV2BBR3  \ offset: 0xF8 : FLASH privilege block based bank 2 register 3
$400220fc constant FLASH_FLASH_PRIV2BBR4  \ offset: 0xFC : FLASH privilege block based bank 2 register 4
$40022100 constant FLASH_FLASH_PRIV2BBR5  \ offset: 0x100 : FLASH privilege block based bank 2 register 5
$40022104 constant FLASH_FLASH_PRIV2BBR6  \ offset: 0x104 : FLASH privilege block based bank 2 register 6
$40022108 constant FLASH_FLASH_PRIV2BBR7  \ offset: 0x108 : FLASH privilege block based bank 2 register 7
$4002210c constant FLASH_FLASH_PRIV2BBR8  \ offset: 0x10C : FLASH privilege block based bank 2 register 8

