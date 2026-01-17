\
\ @file flash.fs
\ @brief Flash
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FLASH_DEF

  [ifdef] FLASH_FLASH_ACR_DEF
    \
    \ @brief FLASH access control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 4] Latency These bits represent the ratio between the HCLK (AHB clock) period and the Flash memory access time. ...
    $08 constant FLASH_PRFTEN                   \ [0x08] Prefetch enable This bit enables the prefetch buffer in the embedded Flash memory.
    $0b constant FLASH_LPM                      \ [0x0b] Low-power read mode This bit puts the Flash memory in low-power read mode.
    $0c constant FLASH_PDREQ1                   \ [0x0c] Bank 1 power-down mode request This bit is write-protected with FLASH_PDKEY1R. This bit requests bank 1 to enter power-down mode. When bank 1 enters power-down mode, this bit is cleared by hardware and the PDKEY1R is locked.
    $0d constant FLASH_PDREQ2                   \ [0x0d] Bank 2 power-down mode request This bit is write-protected with FLASH_PDKEY2R. This bit requests bank 2 to enter power-down mode. When bank 2 enters power-down mode, this bit is cleared by hardware and the PDKEY2R is locked.
    $0e constant FLASH_SLEEP_PD                 \ [0x0e] Flash memory power-down mode during Sleep mode This bit determines whether the Flash memory is in power-down mode or Idle mode when the device is in Sleep mode. The Flash must not be put in power-down while a program or an erase operation is on-going.
  [then]


  [ifdef] FLASH_FLASH_NSKEYR_DEF
    \
    \ @brief FLASH non-secure key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSKEY                    \ [0x00 : 32] Flash memory non-secure key The following values must be written consecutively to unlock the FLASH_NSCR register, allowing the Flash memory non-secure programming/erasing operations: KEY1: 0x4567 0123 KEY2: 0xCDEF 89AB
  [then]


  [ifdef] FLASH_FLASH_SECKEYR_DEF
    \
    \ @brief FLASH secure key register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECKEY                   \ [0x00 : 32] Flash memory secure key The following values must be written consecutively to unlock the FLASH_SECCR register, allowing the Flash memory secure programming/erasing operations: KEY1: 0x4567 0123 KEY2: 0xCDEF 89AB
  [then]


  [ifdef] FLASH_FLASH_OPTKEYR_DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEY                   \ [0x00 : 32] Option byte key The following values must be written consecutively to unlock the FLASH_OPTR register allowing option byte programming/erasing operations: KEY1: 0x0819 2A3B KEY2: 0x4C5D 6E7F
  [then]


  [ifdef] FLASH_FLASH_PDKEY1R_DEF
    \
    \ @brief FLASH bank 1 power-down key register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PDKEY1                   \ [0x00 : 32] Bank 1 power-down key The following values must be written consecutively to unlock the PDREQ1 bit in FLASH_ACR: PDKEY1_1: 0x0415 2637 PDKEY1_2: 0xFAFB FCFD
  [then]


  [ifdef] FLASH_FLASH_PDKEY2R_DEF
    \
    \ @brief FLASH bank 2 power-down key register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PDKEY2                   \ [0x00 : 32] Bank 2 power-down key The following values must be written consecutively to unlock the PDREQ2 bit in FLASH_ACR: PDKEY2_1: 0x4051 6273 PDKEY2_2: 0xAFBF CFDF
  [then]


  [ifdef] FLASH_FLASH_NSSR_DEF
    \
    \ @brief FLASH non-secure status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EOP                      \ [0x00] Non-secure end of operation This bit is set by hardware when one or more Flash memory non-secure operation (program/erase) has been completed successfully. This bit is set only if the non-secure end of operation interrupts are enabled (EOPIE = 1 in FLASH_NSCR). This bit is cleared by writing 1.
    $01 constant FLASH_OPERR                    \ [0x01] Non-secure operation error This bit is set by hardware when a Flash memory non-secure operation (program/erase) completes unsuccessfully. This bit is set only if non-secure error interrupts are enabled (NSERRIE = 1). This bit is cleared by writing 1.
    $03 constant FLASH_PROGERR                  \ [0x03] Non-secure programming error This bit is set by hardware when a non-secure quad-word address to be programmed contains a value different from all 1 before programming, except if the data to write is all 0. This bit is cleared by writing 1.
    $04 constant FLASH_WRPERR                   \ [0x04] Non-secure write protection error This bit is set by hardware when an non-secure address to be erased/programmed belongs to a write-protected part (by WRP, PCROP, HDP or RDP level 1) of the Flash memory. This bit is cleared by writing 1. Refer to for full conditions of error flag setting.
    $05 constant FLASH_PGAERR                   \ [0x05] Non-secure programming alignment error This bit is set by hardware when the first word to be programmed is not aligned with a quad-word address, or the second, third or forth word does not belong to the same quad-word address. This bit is cleared by writing 1.
    $06 constant FLASH_SIZERR                   \ [0x06] Non-secure size error This bit is set by hardware when the size of the access is a byte or half-word during a non-secure program sequence. Only quad-word programming is allowed by means of successive word accesses. This bit is cleared by writing 1.
    $07 constant FLASH_PGSERR                   \ [0x07] Non-secure programming sequence error This bit is set by hardware when programming sequence is not correct. It is cleared by writing 1. Refer to for full conditions of error flag setting.
    $0d constant FLASH_OPTWERR                  \ [0x0d] Option write error This bit is set by hardware when the options bytes are written with an invalid configuration. It is cleared by writing 1. Refer to for full conditions of error flag setting.
    $10 constant FLASH_BSY                      \ [0x10] Non-secure busy This indicates that a Flash memory secure or non-secure operation is in progress. This bit is set at the beginning of a Flash operation and reset when the operation finishes or when an error occurs.
    $11 constant FLASH_WDW                      \ [0x11] Non-secure wait data to write This bit indicates that the Flash memory write buffer has been written by a secure or non-secure operation. It is set when the first data is stored in the buffer and cleared when the write is performed in the Flash memory.
    $12 constant FLASH_OEM1LOCK                 \ [0x12] OEM1 lock This bit indicates that the OEM1 RDP key read during the OBL is not virgin. When set, the OEM1 RDP lock mechanism is active.
    $13 constant FLASH_OEM2LOCK                 \ [0x13] OEM2 lock This bit indicates that the OEM2 RDP key read during the OBL is not virgin. When set, the OEM2 RDP lock mechanism is active.
    $14 constant FLASH_PD1                      \ [0x14] Bank 1 in power-down mode This bit indicates that the Flash memory bank 1 is in power-down state. It is reset when bank 1 is in normal mode or being awaken.
    $15 constant FLASH_PD2                      \ [0x15] Bank 2 in power-down mode This bit indicates that the Flash memory bank 2 is in power-down state. It is reset when bank 2 is in normal mode or being awaken.
  [then]


  [ifdef] FLASH_FLASH_SECSR_DEF
    \
    \ @brief FLASH secure status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EOP                      \ [0x00] Secure end of operation This bit is set by hardware when one or more Flash memory secure operation (program/erase) has been completed successfully. This bit is set only if the secure end of operation interrupts are enabled (EOPIE = 1 in FLASH_SECCR). This bit is cleared by writing 1.
    $01 constant FLASH_OPERR                    \ [0x01] Secure operation error This bit is set by hardware when a Flash memory secure operation (program/erase) completes unsuccessfully. This bit is set only if secure error interrupts are enabled (SECERRIE = 1). This bit is cleared by writing 1.
    $03 constant FLASH_PROGERR                  \ [0x03] Secure programming error This bit is set by hardware when a secure quad-word address to be programmed contains a value different from all 1 before programming, except if the data to write is all 0. This bit is cleared by writing 1.
    $04 constant FLASH_WRPERR                   \ [0x04] Secure write protection error This bit is set by hardware when an secure address to be erased/programmed belongs to a write-protected part (by WRP, PCROP, HDP or RDP level 1) of the Flash memory.This bit is cleared by writing 1. Refer to for full conditions of error flag setting.
    $05 constant FLASH_PGAERR                   \ [0x05] Secure programming alignment error This bit is set by hardware when the first word to be programmed is not aligned with a quad-word address, or the second, third or forth word does not belong to the same quad-word address.This bit is cleared by writing 1.
    $06 constant FLASH_SIZERR                   \ [0x06] Secure size error This bit is set by hardware when the size of the access is a byte or half-word during a secure program sequence. Only quad-word programming is allowed by means of successive word accesses.This bit is cleared by writing 1.
    $07 constant FLASH_PGSERR                   \ [0x07] Secure programming sequence error This bit is set by hardware when programming sequence is not correct. It is cleared by writing 1. Refer to for full conditions of error flag setting.
    $0e constant FLASH_RDERR                    \ [0x0e] Secure readout protection error This bit is set by hardware when a read access is performed to a secure PCROP area and when a cacheable fetch access is performed to a secure PCROP area. An interrupt is generated if RDERRIE is set in FLASH_SECCR register. This bit is cleared by writing 1.
    $10 constant FLASH_BSY                      \ [0x10] Secure busy This bit indicates that a Flash memory secure or non-secure operation is in progress. This is set on the beginning of a Flash operation and reset when the operation finishes or when an error occurs.
    $11 constant FLASH_WDW                      \ [0x11] Secure wait data to write This bit indicates that the Flash memory write buffer has been written by a secure or non-secure operation. It is set when the first data is stored in the buffer and cleared when the write is performed in the Flash memory.
  [then]


  [ifdef] FLASH_FLASH_NSCR_DEF
    \
    \ @brief FLASH non-secure control register
    \ Address offset: 0x28
    \ Reset value: 0xC0000000
    \
    $00 constant FLASH_PG                       \ [0x00] Non-secure programming
    $01 constant FLASH_PER                      \ [0x01] Non-secure page erase
    $02 constant FLASH_MER1                     \ [0x02] Non-secure bank 1 mass erase This bit triggers the bank 1 non-secure mass erase (all bank 1 user pages) when set.
    $03 constant FLASH_PNB                      \ [0x03 : 8] Non-secure page number selection These bits select the page to erase. ... ...
    $0b constant FLASH_BKER                     \ [0x0b] Non-secure bank selection for page erase
    $0e constant FLASH_BWR                      \ [0x0e] Non-secure burst write programming mode When set, this bit selects the burst write programming mode.
    $0f constant FLASH_MER2                     \ [0x0f] Non-secure bank 2 mass erase This bit triggers the bank 2 non-secure mass erase (all bank 2 user pages) when set.
    $10 constant FLASH_STRT                     \ [0x10] Non-secure start This bit triggers a non-secure erase operation when set. If MER1, MER2 and PER bits are reset and the STRT bit is set, the PGSERR bit in FLASH_NSSR is set (this condition is forbidden). This bit is set only by software and is cleared when the BSY bit is cleared in FLASH_NSSR.
    $11 constant FLASH_OPTSTRT                  \ [0x11] Options modification start This bit triggers an options operation when set. It can not be written if OPTLOCK bit is set. This bit is set only by software, and is cleared when the BSY bit is cleared in FLASH_NSSR.
    $18 constant FLASH_EOPIE                    \ [0x18] Non-secure end of operation interrupt enable This bit enables the interrupt generation when the EOP bit in the FLASH_NSSR is set to 1.
    $19 constant FLASH_ERRIE                    \ [0x19] Non-secure error interrupt enable This bit enables the interrupt generation when the OPERR bit in the FLASH_NSSR is set to 1.
    $1b constant FLASH_OBL_LAUNCH               \ [0x1b] Force the option byte loading When set to 1, this bit forces the option byte reloading. This bit is cleared only when the option byte loading is complete. It cannot be written if OPTLOCK is set.
    $1e constant FLASH_OPTLOCK                  \ [0x1e] Option lock This bit is set only. When set, all bits concerning user options in FLASH_NSCR register are locked. This bit is cleared by hardware after detecting the unlock sequence. The LOCK bit in the FLASH_NSCR must be cleared before doing the unlock sequence for OPTLOCK bit. In case of an unsuccessful unlock operation, this bit remains set until the next reset.
    $1f constant FLASH_LOCK                     \ [0x1f] Non-secure lock This bit is set only. When set, the FLASH_NSCR register is locked. It is cleared by hardware after detecting the unlock sequence in FLASH_NSKEYR register. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.
  [then]


  [ifdef] FLASH_FLASH_SECCR_DEF
    \
    \ @brief FLASH secure control register
    \ Address offset: 0x2C
    \ Reset value: 0x80000000
    \
    $00 constant FLASH_PG                       \ [0x00] Secure programming
    $01 constant FLASH_PER                      \ [0x01] Secure page erase
    $02 constant FLASH_MER1                     \ [0x02] Secure bank 1 mass erase This bit triggers the bank 1 secure mass erase (all bank 1 user pages) when set.
    $03 constant FLASH_PNB                      \ [0x03 : 8] Secure page number selection These bits select the page to erase. ... ...
    $0b constant FLASH_BKER                     \ [0x0b] Secure bank selection for page erase
    $0e constant FLASH_BWR                      \ [0x0e] Secure burst write programming mode When set, this bit selects the burst write programming mode.
    $0f constant FLASH_MER2                     \ [0x0f] Secure bank 2 mass erase This bit triggers the bank 2 secure mass erase (all bank 2 user pages) when set.
    $10 constant FLASH_STRT                     \ [0x10] Secure start This bit triggers a secure erase operation when set. If MER1, MER2 and PER bits are reset and the STRT bit is set, the PGSERR in the FLASH_SECSR is set (this condition is forbidden). This bit is set only by software and is cleared when the BSY bit is cleared in FLASH_SECSR.
    $18 constant FLASH_EOPIE                    \ [0x18] Secure End of operation interrupt enable This bit enables the interrupt generation when the EOP bit in the FLASH_SECSR is set to 1.
    $19 constant FLASH_ERRIE                    \ [0x19] Secure error interrupt enable This bit enables the interrupt generation when the OPERR bit in the FLASH_SECSR is set to 1.
    $1a constant FLASH_RDERRIE                  \ [0x1a] Secure PCROP read error interrupt enable This bit enables the interrupt generation when the RDERR bit in the FLASH_SECSR is set to 1.
    $1d constant FLASH_INV                      \ [0x1d] Flash memory security state invert This bit inverts the Flash memory security state.
    $1f constant FLASH_LOCK                     \ [0x1f] Secure lock This bit is set only. When set, the FLASH_SECCR register is locked. It is cleared by hardware after detecting the unlock sequence in FLASH_SECKEYR register. In case of an unsuccessful unlock operation, this bit remains set until the next system reset.
  [then]


  [ifdef] FLASH_FLASH_ECCR_DEF
    \
    \ @brief FLASH ECC register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 21] ECC fail address This field indicates which address is concerned by the ECC error correction or by the double ECC error detection. The address is given by bank from address 0x0 0000 to 0x1F FFF0.
    $15 constant FLASH_BK_ECC                   \ [0x15] ECC fail bank This bit indicates which bank is concerned by the ECC error correction or by the double ECC error detection.
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
    $00 constant FLASH_ADDR_OP                  \ [0x00 : 21] Interrupted operation address This field indicates which address in the Flash memory was accessed when reset occurred. The address is given by bank from address 0x0 0000 to 0x1F FFF0.
    $15 constant FLASH_BK_OP                    \ [0x15] Interrupted operation bank This bit indicates which Flash memory bank was accessed when reset occurred
    $16 constant FLASH_SYSF_OP                  \ [0x16] Operation in system Flash memory interrupted This bit indicates that the reset occurred during an operation in the system Flash memory.
    $1d constant FLASH_CODE_OP                  \ [0x1d : 3] Flash memory operation code This field indicates which Flash memory operation has been interrupted by a system reset:
  [then]


  [ifdef] FLASH_FLASH_OPTR_DEF
    \
    \ @brief FLASH option register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_RDP                      \ [0x00 : 8] Readout protection level Others: Level 1 (memories readout protection active) Note: Refer to for more details.
    $08 constant FLASH_BOR_LEV                  \ [0x08 : 3] BOR reset level These bits contain the VDD supply level threshold that activates/releases the reset.
    $0c constant FLASH_nRST_STOP                \ [0x0c] Reset generation in Stop mode
    $0d constant FLASH_nRST_STDBY               \ [0x0d] Reset generation in Standby mode
    $0e constant FLASH_nRST_SHDW                \ [0x0e] Reset generation in Shutdown mode
    $0f constant FLASH_SRAM1345_RST             \ [0x0f] SRAM1,SRAM4 and SRAM5 erase upon system reset
    $10 constant FLASH_IWDG_SW                  \ [0x10] Independent watchdog selection
    $11 constant FLASH_IWDG_STOP                \ [0x11] Independent watchdog counter freeze in Stop mode
    $12 constant FLASH_IWDG_STDBY               \ [0x12] Independent watchdog counter freeze in Standby mode
    $13 constant FLASH_WWDG_SW                  \ [0x13] Window watchdog selection
    $14 constant FLASH_SWAP_BANK                \ [0x14] Swap banks
    $15 constant FLASH_DUALBANK                 \ [0x15] Dual-bank on 1-Mbyte and 512-Kbyte Flash memory devices
    $16 constant FLASH_BKPRAM_ECC               \ [0x16] Backup RAM ECC detection and correction enable
    $18 constant FLASH_SRAM2_ECC                \ [0x18] SRAM2 ECC detection and correction enable
    $19 constant FLASH_SRAM2_RST                \ [0x19] SRAM2 erase when system reset
    $1a constant FLASH_nSWBOOT0                 \ [0x1a] Software BOOT0
    $1b constant FLASH_nBOOT0                   \ [0x1b] nBOOT0 option bit
    $1c constant FLASH_PA15_PUPEN               \ [0x1c] PA15 pull-up enable
    $1d constant FLASH_IO_VDD_HSLV              \ [0x1d] High-speed IO at low VDD voltage configuration bit This bit can be set only with VDD below 2.5V
    $1e constant FLASH_IO_VDDIO2_HSLV           \ [0x1e] High-speed IO at low VDDIO2 voltage configuration bit This bit can be set only with VDDIO2 below 2.5 V.
    $1f constant FLASH_TZEN                     \ [0x1f] Global TrustZone security enable
  [then]


  [ifdef] FLASH_FLASH_NSBOOTADD0R_DEF
    \
    \ @brief FLASH non-secure boot address 0 register
    \ Address offset: 0x44
    \ Reset value: 0x0000000F
    \
    $07 constant FLASH_NSBOOTADD0               \ [0x07 : 25] Non-secure boot base address 0 The non-secure boot memory address can be programmed to any address in the valid address range with a granularity of 128 bytes. These bits correspond to address [31:7]. The NSBOOTADD0 option bytes are selected following the BOOT0 pin or nSWBOOT0 state. Examples: NSBOOTADD0[24:0] = 0x0100000: Boot from non-secure Flash memory (0x0800 0000) NSBOOTADD0[24:0] = 0x017F200: Boot from system memory bootloader (0x0BF9 0000) NSBOOTADD0[24:0] = 0x0400000: Boot from non-secure SRAM1 on S-Bus (0x2000 0000)
  [then]


  [ifdef] FLASH_FLASH_NSBOOTADD1R_DEF
    \
    \ @brief FLASH non-secure boot address 1 register
    \ Address offset: 0x48
    \ Reset value: 0x0000000F
    \
    $07 constant FLASH_NSBOOTADD1               \ [0x07 : 25] Non-secure boot address 1 The non-secure boot memory address can be programmed to any address in the valid address range with a granularity of 128 bytes. These bits correspond to address [31:7]. The NSBOOTADD0 option bytes are selected following the BOOT0 pin or nSWBOOT0 state. Examples: NSBOOTADD1[24:0] = 0x0100000: Boot from non-secure Flash memory (0x0800 0000) NSBOOTADD1[24:0] = 0x017F200: Boot from system memory bootloader (0x0BF9 0000) NSBOOTADD1[24:0] = 0x0400000: Boot from non-secure SRAM1 on S-Bus (0x2000 0000)
  [then]


  [ifdef] FLASH_FLASH_SECBOOTADD0R_DEF
    \
    \ @brief FLASH secure boot address 0 register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_LOCK                \ [0x00] Boot lock When set, the boot is always forced to base address value programmed in SECBOOTADD0[24:0] option bytes whatever the boot selection option. When set, this bit can only be cleared by an RDP at level 0.
    $07 constant FLASH_SECBOOTADD0              \ [0x07 : 25] Secure boot base address 0 The secure boot memory address can be programmed to any address in the valid address range with a granularity of 128 bytes. This bits correspond to address [31:7] The SECBOOTADD0 option bytes are selected following the BOOT0 pin or nSWBOOT0 state. Examples: SECBOOTADD0[24:0] = 0x018 0000: Boot from secure Flash memory (0x0C00 0000) SECBOOTADD0[24:0] = 0x01F F000: Boot from RSS (0x0FF8 0000) SECBOOTADD0[24:0] = 0x060 0000: Boot from secure SRAM1 on S-Bus (0x3000 0000)
  [then]


  [ifdef] FLASH_FLASH_SECWM1R1_DEF
    \
    \ @brief FLASH secure watermark1 register 1
    \ Address offset: 0x50
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_SECWM1_PSTRT             \ [0x00 : 8] Start page of first secure area This field contains the first page of the secure area in bank 1.
    $10 constant FLASH_SECWM1_PEND              \ [0x10 : 8] End page of first secure area This field contains the last page of the secure area in bank 1.
  [then]


  [ifdef] FLASH_FLASH_SECWM1R2_DEF
    \
    \ @brief FLASH secure watermark1 register 2
    \ Address offset: 0x54
    \ Reset value: 0x0F000F00
    \
    $00 constant FLASH_PCROP1_PSTRT             \ [0x00 : 8] Start page of first PCROP area This field contains the first page of the PCROP area in bank 1.
    $0f constant FLASH_PCROP1EN                 \ [0x0f] PCROP1 area enable
    $10 constant FLASH_HDP1_PEND                \ [0x10 : 8] End page of first hide protection area This field contains the last page of the HDP area in bank 1.
    $1f constant FLASH_HDP1EN                   \ [0x1f] Hide protection first area enable
  [then]


  [ifdef] FLASH_FLASH_WRP1AR_DEF
    \
    \ @brief FLASH WRP1 area A address register
    \ Address offset: 0x58
    \ Reset value: 0x0F00FF00
    \
    $00 constant FLASH_WRP1A_PSTRT              \ [0x00 : 8] bank 1 WPR first area A start page This field contains the first page of the first WPR area for bank 1.
    $10 constant FLASH_WRP1A_PEND               \ [0x10 : 8] Bank 1 WPR first area A end page This field contains the last page of the first WPR area in bank 1.
    $1f constant FLASH_UNLOCK                   \ [0x1f] Bank 1 WPR first area A unlock
  [then]


  [ifdef] FLASH_FLASH_WRP1BR_DEF
    \
    \ @brief FLASH WRP1 area B address register
    \ Address offset: 0x5C
    \ Reset value: 0x0F00FF00
    \
    $00 constant FLASH_WRP1B_PSTRT              \ [0x00 : 8] Bank 1 WRP second area B start page This field contains the first page of the second WRP area for bank 1.
    $10 constant FLASH_WRP1B_PEND               \ [0x10 : 8] Bank 1 WRP second area B end page This field contains the last page of the second WRP area in bank 1.
    $1f constant FLASH_UNLOCK                   \ [0x1f] Bank 1 WPR second area B unlock
  [then]


  [ifdef] FLASH_FLASH_SECWM2R1_DEF
    \
    \ @brief FLASH secure watermark2 register 1
    \ Address offset: 0x60
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_SECWM2_PSTRT             \ [0x00 : 8] Start page of second secure area This field contains the first page of the secure area in bank 2.
    $10 constant FLASH_SECWM2_PEND              \ [0x10 : 8] End page of second secure area This field contains the last page of the secure area in bank 2.
  [then]


  [ifdef] FLASH_FLASH_SECWM2R2_DEF
    \
    \ @brief FLASH secure watermark2 register 2
    \ Address offset: 0x64
    \ Reset value: 0x0F000F00
    \
    $00 constant FLASH_PCROP2_PSTRT             \ [0x00 : 8] Start page of PCROP2 area PRCROP2_PSTRT contains the first page of the PCROP area in bank 2.
    $0f constant FLASH_PCROP2EN                 \ [0x0f] PCROP2 area enable
    $10 constant FLASH_HDP2_PEND                \ [0x10 : 8] End page of hide protection second area HDP2_PEND contains the last page of the HDP area in bank 2.
    $1f constant FLASH_HDP2EN                   \ [0x1f] Hide protection second area enable
  [then]


  [ifdef] FLASH_FLASH_WRP2AR_DEF
    \
    \ @brief FLASH WPR2 area A address register
    \ Address offset: 0x68
    \ Reset value: 0x0F00FF00
    \
    $00 constant FLASH_WRP2A_PSTRT              \ [0x00 : 8] Bank 2 WPR first area A start page This field contains the first page of the first WRP area for bank 2.
    $10 constant FLASH_WRP2A_PEND               \ [0x10 : 8] Bank 2 WPR first area A end page This field contains the last page of the first WRP area in bank 2.
    $1f constant FLASH_UNLOCK                   \ [0x1f] Bank 2 WPR first area A unlock
  [then]


  [ifdef] FLASH_FLASH_WRP2BR_DEF
    \
    \ @brief FLASH WPR2 area B address register
    \ Address offset: 0x6C
    \ Reset value: 0x0F00FF00
    \
    $00 constant FLASH_WRP2B_PSTRT              \ [0x00 : 8] Bank 2 WPR second area B start page This field contains the first page of the second WRP area for bank 2.
    $10 constant FLASH_WRP2B_PEND               \ [0x10 : 8] Bank 2 WPR second area B end page This field contains the last page of the second WRP area in bank 2.
    $1f constant FLASH_UNLOCK                   \ [0x1f] Bank 2 WPR second area B unlock
  [then]


  [ifdef] FLASH_FLASH_OEM1KEYR1_DEF
    \
    \ @brief FLASH OEM1 key register 1
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OEM1KEY                  \ [0x00 : 32] OEM1 least significant bytes key
  [then]


  [ifdef] FLASH_FLASH_OEM1KEYR2_DEF
    \
    \ @brief FLASH OEM1 key register 2
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OEM1KEY                  \ [0x00 : 32] OEM1 most significant bytes key
  [then]


  [ifdef] FLASH_FLASH_OEM2KEYR1_DEF
    \
    \ @brief FLASH OEM2 key register 1
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OEM2KEY                  \ [0x00 : 32] OEM2 least significant bytes key
  [then]


  [ifdef] FLASH_FLASH_OEM2KEYR2_DEF
    \
    \ @brief FLASH OEM2 key register 2
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OEM2KEY                  \ [0x00 : 32] OEM2 most significant bytes key
  [then]


  [ifdef] FLASH_FLASH_SEC1BBR1_DEF
    \
    \ @brief FLASH secure block based bank 1 register 1
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC1BB0                  \ [0x00] SEC1BB0
    $01 constant FLASH_SEC1BB1                  \ [0x01] SEC1BB1
    $02 constant FLASH_SEC1BB2                  \ [0x02] SEC1BB2
    $03 constant FLASH_SEC1BB3                  \ [0x03] SEC1BB3
    $04 constant FLASH_SEC1BB4                  \ [0x04] SEC1BB4
    $05 constant FLASH_SEC1BB5                  \ [0x05] SEC1BB5
    $06 constant FLASH_SEC1BB6                  \ [0x06] SEC1BB6
    $07 constant FLASH_SEC1BB7                  \ [0x07] SEC1BB7
    $08 constant FLASH_SEC1BB8                  \ [0x08] SEC1BB8
    $09 constant FLASH_SEC1BB9                  \ [0x09] SEC1BB9
    $0a constant FLASH_SEC1BB10                 \ [0x0a] SEC1BB10
    $0b constant FLASH_SEC1BB11                 \ [0x0b] SEC1BB11
    $0c constant FLASH_SEC1BB12                 \ [0x0c] SEC1BB12
    $0d constant FLASH_SEC1BB13                 \ [0x0d] SEC1BB13
    $0e constant FLASH_SEC1BB14                 \ [0x0e] SEC1BB14
    $0f constant FLASH_SEC1BB15                 \ [0x0f] SEC1BB15
    $10 constant FLASH_SEC1BB16                 \ [0x10] SEC1BB16
    $11 constant FLASH_SEC1BB17                 \ [0x11] SEC1BB17
    $12 constant FLASH_SEC1BB18                 \ [0x12] SEC1BB18
    $13 constant FLASH_SEC1BB19                 \ [0x13] SEC1BB19
    $14 constant FLASH_SEC1BB20                 \ [0x14] SEC1BB20
    $15 constant FLASH_SEC1BB21                 \ [0x15] SEC1BB21
    $16 constant FLASH_SEC1BB22                 \ [0x16] SEC1BB22
    $17 constant FLASH_SEC1BB23                 \ [0x17] SEC1BB23
    $18 constant FLASH_SEC1BB24                 \ [0x18] SEC1BB24
    $19 constant FLASH_SEC1BB25                 \ [0x19] SEC1BB25
    $1a constant FLASH_SEC1BB26                 \ [0x1a] SEC1BB26
    $1b constant FLASH_SEC1BB27                 \ [0x1b] SEC1BB27
    $1c constant FLASH_SEC1BB28                 \ [0x1c] SEC1BB28
    $1d constant FLASH_SEC1BB29                 \ [0x1d] SEC1BB29
    $1e constant FLASH_SEC1BB30                 \ [0x1e] SEC1BB30
    $1f constant FLASH_SEC1BB31                 \ [0x1f] SEC1BB31
  [then]


  [ifdef] FLASH_FLASH_SEC1BBR2_DEF
    \
    \ @brief FLASH secure block based bank 1 register 2
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC1BB0                  \ [0x00] SEC1BB0
    $01 constant FLASH_SEC1BB1                  \ [0x01] SEC1BB1
    $02 constant FLASH_SEC1BB2                  \ [0x02] SEC1BB2
    $03 constant FLASH_SEC1BB3                  \ [0x03] SEC1BB3
    $04 constant FLASH_SEC1BB4                  \ [0x04] SEC1BB4
    $05 constant FLASH_SEC1BB5                  \ [0x05] SEC1BB5
    $06 constant FLASH_SEC1BB6                  \ [0x06] SEC1BB6
    $07 constant FLASH_SEC1BB7                  \ [0x07] SEC1BB7
    $08 constant FLASH_SEC1BB8                  \ [0x08] SEC1BB8
    $09 constant FLASH_SEC1BB9                  \ [0x09] SEC1BB9
    $0a constant FLASH_SEC1BB10                 \ [0x0a] SEC1BB10
    $0b constant FLASH_SEC1BB11                 \ [0x0b] SEC1BB11
    $0c constant FLASH_SEC1BB12                 \ [0x0c] SEC1BB12
    $0d constant FLASH_SEC1BB13                 \ [0x0d] SEC1BB13
    $0e constant FLASH_SEC1BB14                 \ [0x0e] SEC1BB14
    $0f constant FLASH_SEC1BB15                 \ [0x0f] SEC1BB15
    $10 constant FLASH_SEC1BB16                 \ [0x10] SEC1BB16
    $11 constant FLASH_SEC1BB17                 \ [0x11] SEC1BB17
    $12 constant FLASH_SEC1BB18                 \ [0x12] SEC1BB18
    $13 constant FLASH_SEC1BB19                 \ [0x13] SEC1BB19
    $14 constant FLASH_SEC1BB20                 \ [0x14] SEC1BB20
    $15 constant FLASH_SEC1BB21                 \ [0x15] SEC1BB21
    $16 constant FLASH_SEC1BB22                 \ [0x16] SEC1BB22
    $17 constant FLASH_SEC1BB23                 \ [0x17] SEC1BB23
    $18 constant FLASH_SEC1BB24                 \ [0x18] SEC1BB24
    $19 constant FLASH_SEC1BB25                 \ [0x19] SEC1BB25
    $1a constant FLASH_SEC1BB26                 \ [0x1a] SEC1BB26
    $1b constant FLASH_SEC1BB27                 \ [0x1b] SEC1BB27
    $1c constant FLASH_SEC1BB28                 \ [0x1c] SEC1BB28
    $1d constant FLASH_SEC1BB29                 \ [0x1d] SEC1BB29
    $1e constant FLASH_SEC1BB30                 \ [0x1e] SEC1BB30
    $1f constant FLASH_SEC1BB31                 \ [0x1f] SEC1BB31
  [then]


  [ifdef] FLASH_FLASH_SEC1BBR3_DEF
    \
    \ @brief FLASH secure block based bank 1 register 3
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC1BB0                  \ [0x00] SEC1BB0
    $01 constant FLASH_SEC1BB1                  \ [0x01] SEC1BB1
    $02 constant FLASH_SEC1BB2                  \ [0x02] SEC1BB2
    $03 constant FLASH_SEC1BB3                  \ [0x03] SEC1BB3
    $04 constant FLASH_SEC1BB4                  \ [0x04] SEC1BB4
    $05 constant FLASH_SEC1BB5                  \ [0x05] SEC1BB5
    $06 constant FLASH_SEC1BB6                  \ [0x06] SEC1BB6
    $07 constant FLASH_SEC1BB7                  \ [0x07] SEC1BB7
    $08 constant FLASH_SEC1BB8                  \ [0x08] SEC1BB8
    $09 constant FLASH_SEC1BB9                  \ [0x09] SEC1BB9
    $0a constant FLASH_SEC1BB10                 \ [0x0a] SEC1BB10
    $0b constant FLASH_SEC1BB11                 \ [0x0b] SEC1BB11
    $0c constant FLASH_SEC1BB12                 \ [0x0c] SEC1BB12
    $0d constant FLASH_SEC1BB13                 \ [0x0d] SEC1BB13
    $0e constant FLASH_SEC1BB14                 \ [0x0e] SEC1BB14
    $0f constant FLASH_SEC1BB15                 \ [0x0f] SEC1BB15
    $10 constant FLASH_SEC1BB16                 \ [0x10] SEC1BB16
    $11 constant FLASH_SEC1BB17                 \ [0x11] SEC1BB17
    $12 constant FLASH_SEC1BB18                 \ [0x12] SEC1BB18
    $13 constant FLASH_SEC1BB19                 \ [0x13] SEC1BB19
    $14 constant FLASH_SEC1BB20                 \ [0x14] SEC1BB20
    $15 constant FLASH_SEC1BB21                 \ [0x15] SEC1BB21
    $16 constant FLASH_SEC1BB22                 \ [0x16] SEC1BB22
    $17 constant FLASH_SEC1BB23                 \ [0x17] SEC1BB23
    $18 constant FLASH_SEC1BB24                 \ [0x18] SEC1BB24
    $19 constant FLASH_SEC1BB25                 \ [0x19] SEC1BB25
    $1a constant FLASH_SEC1BB26                 \ [0x1a] SEC1BB26
    $1b constant FLASH_SEC1BB27                 \ [0x1b] SEC1BB27
    $1c constant FLASH_SEC1BB28                 \ [0x1c] SEC1BB28
    $1d constant FLASH_SEC1BB29                 \ [0x1d] SEC1BB29
    $1e constant FLASH_SEC1BB30                 \ [0x1e] SEC1BB30
    $1f constant FLASH_SEC1BB31                 \ [0x1f] SEC1BB31
  [then]


  [ifdef] FLASH_FLASH_SEC1BBR4_DEF
    \
    \ @brief FLASH secure block based bank 1 register 4
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC1BB0                  \ [0x00] SEC1BB0
    $01 constant FLASH_SEC1BB1                  \ [0x01] SEC1BB1
    $02 constant FLASH_SEC1BB2                  \ [0x02] SEC1BB2
    $03 constant FLASH_SEC1BB3                  \ [0x03] SEC1BB3
    $04 constant FLASH_SEC1BB4                  \ [0x04] SEC1BB4
    $05 constant FLASH_SEC1BB5                  \ [0x05] SEC1BB5
    $06 constant FLASH_SEC1BB6                  \ [0x06] SEC1BB6
    $07 constant FLASH_SEC1BB7                  \ [0x07] SEC1BB7
    $08 constant FLASH_SEC1BB8                  \ [0x08] SEC1BB8
    $09 constant FLASH_SEC1BB9                  \ [0x09] SEC1BB9
    $0a constant FLASH_SEC1BB10                 \ [0x0a] SEC1BB10
    $0b constant FLASH_SEC1BB11                 \ [0x0b] SEC1BB11
    $0c constant FLASH_SEC1BB12                 \ [0x0c] SEC1BB12
    $0d constant FLASH_SEC1BB13                 \ [0x0d] SEC1BB13
    $0e constant FLASH_SEC1BB14                 \ [0x0e] SEC1BB14
    $0f constant FLASH_SEC1BB15                 \ [0x0f] SEC1BB15
    $10 constant FLASH_SEC1BB16                 \ [0x10] SEC1BB16
    $11 constant FLASH_SEC1BB17                 \ [0x11] SEC1BB17
    $12 constant FLASH_SEC1BB18                 \ [0x12] SEC1BB18
    $13 constant FLASH_SEC1BB19                 \ [0x13] SEC1BB19
    $14 constant FLASH_SEC1BB20                 \ [0x14] SEC1BB20
    $15 constant FLASH_SEC1BB21                 \ [0x15] SEC1BB21
    $16 constant FLASH_SEC1BB22                 \ [0x16] SEC1BB22
    $17 constant FLASH_SEC1BB23                 \ [0x17] SEC1BB23
    $18 constant FLASH_SEC1BB24                 \ [0x18] SEC1BB24
    $19 constant FLASH_SEC1BB25                 \ [0x19] SEC1BB25
    $1a constant FLASH_SEC1BB26                 \ [0x1a] SEC1BB26
    $1b constant FLASH_SEC1BB27                 \ [0x1b] SEC1BB27
    $1c constant FLASH_SEC1BB28                 \ [0x1c] SEC1BB28
    $1d constant FLASH_SEC1BB29                 \ [0x1d] SEC1BB29
    $1e constant FLASH_SEC1BB30                 \ [0x1e] SEC1BB30
    $1f constant FLASH_SEC1BB31                 \ [0x1f] SEC1BB31
  [then]


  [ifdef] FLASH_FLASH_SEC1BBR5_DEF
    \
    \ @brief FLASH secure block based bank 1 register 5
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC1BB0                  \ [0x00] SEC1BB0
    $01 constant FLASH_SEC1BB1                  \ [0x01] SEC1BB1
    $02 constant FLASH_SEC1BB2                  \ [0x02] SEC1BB2
    $03 constant FLASH_SEC1BB3                  \ [0x03] SEC1BB3
    $04 constant FLASH_SEC1BB4                  \ [0x04] SEC1BB4
    $05 constant FLASH_SEC1BB5                  \ [0x05] SEC1BB5
    $06 constant FLASH_SEC1BB6                  \ [0x06] SEC1BB6
    $07 constant FLASH_SEC1BB7                  \ [0x07] SEC1BB7
    $08 constant FLASH_SEC1BB8                  \ [0x08] SEC1BB8
    $09 constant FLASH_SEC1BB9                  \ [0x09] SEC1BB9
    $0a constant FLASH_SEC1BB10                 \ [0x0a] SEC1BB10
    $0b constant FLASH_SEC1BB11                 \ [0x0b] SEC1BB11
    $0c constant FLASH_SEC1BB12                 \ [0x0c] SEC1BB12
    $0d constant FLASH_SEC1BB13                 \ [0x0d] SEC1BB13
    $0e constant FLASH_SEC1BB14                 \ [0x0e] SEC1BB14
    $0f constant FLASH_SEC1BB15                 \ [0x0f] SEC1BB15
    $10 constant FLASH_SEC1BB16                 \ [0x10] SEC1BB16
    $11 constant FLASH_SEC1BB17                 \ [0x11] SEC1BB17
    $12 constant FLASH_SEC1BB18                 \ [0x12] SEC1BB18
    $13 constant FLASH_SEC1BB19                 \ [0x13] SEC1BB19
    $14 constant FLASH_SEC1BB20                 \ [0x14] SEC1BB20
    $15 constant FLASH_SEC1BB21                 \ [0x15] SEC1BB21
    $16 constant FLASH_SEC1BB22                 \ [0x16] SEC1BB22
    $17 constant FLASH_SEC1BB23                 \ [0x17] SEC1BB23
    $18 constant FLASH_SEC1BB24                 \ [0x18] SEC1BB24
    $19 constant FLASH_SEC1BB25                 \ [0x19] SEC1BB25
    $1a constant FLASH_SEC1BB26                 \ [0x1a] SEC1BB26
    $1b constant FLASH_SEC1BB27                 \ [0x1b] SEC1BB27
    $1c constant FLASH_SEC1BB28                 \ [0x1c] SEC1BB28
    $1d constant FLASH_SEC1BB29                 \ [0x1d] SEC1BB29
    $1e constant FLASH_SEC1BB30                 \ [0x1e] SEC1BB30
    $1f constant FLASH_SEC1BB31                 \ [0x1f] SEC1BB31
  [then]


  [ifdef] FLASH_FLASH_SEC1BBR6_DEF
    \
    \ @brief FLASH secure block based bank 1 register 6
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC1BB0                  \ [0x00] SEC1BB0
    $01 constant FLASH_SEC1BB1                  \ [0x01] SEC1BB1
    $02 constant FLASH_SEC1BB2                  \ [0x02] SEC1BB2
    $03 constant FLASH_SEC1BB3                  \ [0x03] SEC1BB3
    $04 constant FLASH_SEC1BB4                  \ [0x04] SEC1BB4
    $05 constant FLASH_SEC1BB5                  \ [0x05] SEC1BB5
    $06 constant FLASH_SEC1BB6                  \ [0x06] SEC1BB6
    $07 constant FLASH_SEC1BB7                  \ [0x07] SEC1BB7
    $08 constant FLASH_SEC1BB8                  \ [0x08] SEC1BB8
    $09 constant FLASH_SEC1BB9                  \ [0x09] SEC1BB9
    $0a constant FLASH_SEC1BB10                 \ [0x0a] SEC1BB10
    $0b constant FLASH_SEC1BB11                 \ [0x0b] SEC1BB11
    $0c constant FLASH_SEC1BB12                 \ [0x0c] SEC1BB12
    $0d constant FLASH_SEC1BB13                 \ [0x0d] SEC1BB13
    $0e constant FLASH_SEC1BB14                 \ [0x0e] SEC1BB14
    $0f constant FLASH_SEC1BB15                 \ [0x0f] SEC1BB15
    $10 constant FLASH_SEC1BB16                 \ [0x10] SEC1BB16
    $11 constant FLASH_SEC1BB17                 \ [0x11] SEC1BB17
    $12 constant FLASH_SEC1BB18                 \ [0x12] SEC1BB18
    $13 constant FLASH_SEC1BB19                 \ [0x13] SEC1BB19
    $14 constant FLASH_SEC1BB20                 \ [0x14] SEC1BB20
    $15 constant FLASH_SEC1BB21                 \ [0x15] SEC1BB21
    $16 constant FLASH_SEC1BB22                 \ [0x16] SEC1BB22
    $17 constant FLASH_SEC1BB23                 \ [0x17] SEC1BB23
    $18 constant FLASH_SEC1BB24                 \ [0x18] SEC1BB24
    $19 constant FLASH_SEC1BB25                 \ [0x19] SEC1BB25
    $1a constant FLASH_SEC1BB26                 \ [0x1a] SEC1BB26
    $1b constant FLASH_SEC1BB27                 \ [0x1b] SEC1BB27
    $1c constant FLASH_SEC1BB28                 \ [0x1c] SEC1BB28
    $1d constant FLASH_SEC1BB29                 \ [0x1d] SEC1BB29
    $1e constant FLASH_SEC1BB30                 \ [0x1e] SEC1BB30
    $1f constant FLASH_SEC1BB31                 \ [0x1f] SEC1BB31
  [then]


  [ifdef] FLASH_FLASH_SEC1BBR7_DEF
    \
    \ @brief FLASH secure block based bank 1 register 7
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC1BB0                  \ [0x00] SEC1BB0
    $01 constant FLASH_SEC1BB1                  \ [0x01] SEC1BB1
    $02 constant FLASH_SEC1BB2                  \ [0x02] SEC1BB2
    $03 constant FLASH_SEC1BB3                  \ [0x03] SEC1BB3
    $04 constant FLASH_SEC1BB4                  \ [0x04] SEC1BB4
    $05 constant FLASH_SEC1BB5                  \ [0x05] SEC1BB5
    $06 constant FLASH_SEC1BB6                  \ [0x06] SEC1BB6
    $07 constant FLASH_SEC1BB7                  \ [0x07] SEC1BB7
    $08 constant FLASH_SEC1BB8                  \ [0x08] SEC1BB8
    $09 constant FLASH_SEC1BB9                  \ [0x09] SEC1BB9
    $0a constant FLASH_SEC1BB10                 \ [0x0a] SEC1BB10
    $0b constant FLASH_SEC1BB11                 \ [0x0b] SEC1BB11
    $0c constant FLASH_SEC1BB12                 \ [0x0c] SEC1BB12
    $0d constant FLASH_SEC1BB13                 \ [0x0d] SEC1BB13
    $0e constant FLASH_SEC1BB14                 \ [0x0e] SEC1BB14
    $0f constant FLASH_SEC1BB15                 \ [0x0f] SEC1BB15
    $10 constant FLASH_SEC1BB16                 \ [0x10] SEC1BB16
    $11 constant FLASH_SEC1BB17                 \ [0x11] SEC1BB17
    $12 constant FLASH_SEC1BB18                 \ [0x12] SEC1BB18
    $13 constant FLASH_SEC1BB19                 \ [0x13] SEC1BB19
    $14 constant FLASH_SEC1BB20                 \ [0x14] SEC1BB20
    $15 constant FLASH_SEC1BB21                 \ [0x15] SEC1BB21
    $16 constant FLASH_SEC1BB22                 \ [0x16] SEC1BB22
    $17 constant FLASH_SEC1BB23                 \ [0x17] SEC1BB23
    $18 constant FLASH_SEC1BB24                 \ [0x18] SEC1BB24
    $19 constant FLASH_SEC1BB25                 \ [0x19] SEC1BB25
    $1a constant FLASH_SEC1BB26                 \ [0x1a] SEC1BB26
    $1b constant FLASH_SEC1BB27                 \ [0x1b] SEC1BB27
    $1c constant FLASH_SEC1BB28                 \ [0x1c] SEC1BB28
    $1d constant FLASH_SEC1BB29                 \ [0x1d] SEC1BB29
    $1e constant FLASH_SEC1BB30                 \ [0x1e] SEC1BB30
    $1f constant FLASH_SEC1BB31                 \ [0x1f] SEC1BB31
  [then]


  [ifdef] FLASH_FLASH_SEC1BBR8_DEF
    \
    \ @brief FLASH secure block based bank 1 register 8
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC1BB0                  \ [0x00] SEC1BB0
    $01 constant FLASH_SEC1BB1                  \ [0x01] SEC1BB1
    $02 constant FLASH_SEC1BB2                  \ [0x02] SEC1BB2
    $03 constant FLASH_SEC1BB3                  \ [0x03] SEC1BB3
    $04 constant FLASH_SEC1BB4                  \ [0x04] SEC1BB4
    $05 constant FLASH_SEC1BB5                  \ [0x05] SEC1BB5
    $06 constant FLASH_SEC1BB6                  \ [0x06] SEC1BB6
    $07 constant FLASH_SEC1BB7                  \ [0x07] SEC1BB7
    $08 constant FLASH_SEC1BB8                  \ [0x08] SEC1BB8
    $09 constant FLASH_SEC1BB9                  \ [0x09] SEC1BB9
    $0a constant FLASH_SEC1BB10                 \ [0x0a] SEC1BB10
    $0b constant FLASH_SEC1BB11                 \ [0x0b] SEC1BB11
    $0c constant FLASH_SEC1BB12                 \ [0x0c] SEC1BB12
    $0d constant FLASH_SEC1BB13                 \ [0x0d] SEC1BB13
    $0e constant FLASH_SEC1BB14                 \ [0x0e] SEC1BB14
    $0f constant FLASH_SEC1BB15                 \ [0x0f] SEC1BB15
    $10 constant FLASH_SEC1BB16                 \ [0x10] SEC1BB16
    $11 constant FLASH_SEC1BB17                 \ [0x11] SEC1BB17
    $12 constant FLASH_SEC1BB18                 \ [0x12] SEC1BB18
    $13 constant FLASH_SEC1BB19                 \ [0x13] SEC1BB19
    $14 constant FLASH_SEC1BB20                 \ [0x14] SEC1BB20
    $15 constant FLASH_SEC1BB21                 \ [0x15] SEC1BB21
    $16 constant FLASH_SEC1BB22                 \ [0x16] SEC1BB22
    $17 constant FLASH_SEC1BB23                 \ [0x17] SEC1BB23
    $18 constant FLASH_SEC1BB24                 \ [0x18] SEC1BB24
    $19 constant FLASH_SEC1BB25                 \ [0x19] SEC1BB25
    $1a constant FLASH_SEC1BB26                 \ [0x1a] SEC1BB26
    $1b constant FLASH_SEC1BB27                 \ [0x1b] SEC1BB27
    $1c constant FLASH_SEC1BB28                 \ [0x1c] SEC1BB28
    $1d constant FLASH_SEC1BB29                 \ [0x1d] SEC1BB29
    $1e constant FLASH_SEC1BB30                 \ [0x1e] SEC1BB30
    $1f constant FLASH_SEC1BB31                 \ [0x1f] SEC1BB31
  [then]


  [ifdef] FLASH_FLASH_SEC2BBR1_DEF
    \
    \ @brief FLASH secure block based bank 2 register 1
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC2BB0                  \ [0x00] SEC2BB0
    $01 constant FLASH_SEC2BB1                  \ [0x01] SEC2BB1
    $02 constant FLASH_SEC2BB2                  \ [0x02] SEC2BB2
    $03 constant FLASH_SEC2BB3                  \ [0x03] SEC2BB3
    $04 constant FLASH_SEC2BB4                  \ [0x04] SEC2BB4
    $05 constant FLASH_SEC2BB5                  \ [0x05] SEC2BB5
    $06 constant FLASH_SEC2BB6                  \ [0x06] SEC2BB6
    $07 constant FLASH_SEC2BB7                  \ [0x07] SEC2BB7
    $08 constant FLASH_SEC2BB8                  \ [0x08] SEC2BB8
    $09 constant FLASH_SEC2BB9                  \ [0x09] SEC2BB9
    $0a constant FLASH_SEC2BB10                 \ [0x0a] SEC2BB10
    $0b constant FLASH_SEC2BB11                 \ [0x0b] SEC2BB11
    $0c constant FLASH_SEC2BB12                 \ [0x0c] SEC2BB12
    $0d constant FLASH_SEC2BB13                 \ [0x0d] SEC2BB13
    $0e constant FLASH_SEC2BB14                 \ [0x0e] SEC2BB14
    $0f constant FLASH_SEC2BB15                 \ [0x0f] SEC2BB15
    $10 constant FLASH_SEC2BB16                 \ [0x10] SEC2BB16
    $11 constant FLASH_SEC2BB17                 \ [0x11] SEC2BB17
    $12 constant FLASH_SEC2BB18                 \ [0x12] SEC2BB18
    $13 constant FLASH_SEC2BB19                 \ [0x13] SEC2BB19
    $14 constant FLASH_SEC2BB20                 \ [0x14] SEC2BB20
    $15 constant FLASH_SEC2BB21                 \ [0x15] SEC2BB21
    $16 constant FLASH_SEC2BB22                 \ [0x16] SEC2BB22
    $17 constant FLASH_SEC2BB23                 \ [0x17] SEC2BB23
    $18 constant FLASH_SEC2BB24                 \ [0x18] SEC2BB24
    $19 constant FLASH_SEC2BB25                 \ [0x19] SEC2BB25
    $1a constant FLASH_SEC2BB26                 \ [0x1a] SEC2BB26
    $1b constant FLASH_SEC2BB27                 \ [0x1b] SEC2BB27
    $1c constant FLASH_SEC2BB28                 \ [0x1c] SEC2BB28
    $1d constant FLASH_SEC2BB29                 \ [0x1d] SEC2BB29
    $1e constant FLASH_SEC2BB30                 \ [0x1e] SEC2BB30
    $1f constant FLASH_SEC2BB31                 \ [0x1f] SEC2BB31
  [then]


  [ifdef] FLASH_FLASH_SEC2BBR2_DEF
    \
    \ @brief FLASH secure block based bank 2 register 2
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC2BB0                  \ [0x00] SEC2BB0
    $01 constant FLASH_SEC2BB1                  \ [0x01] SEC2BB1
    $02 constant FLASH_SEC2BB2                  \ [0x02] SEC2BB2
    $03 constant FLASH_SEC2BB3                  \ [0x03] SEC2BB3
    $04 constant FLASH_SEC2BB4                  \ [0x04] SEC2BB4
    $05 constant FLASH_SEC2BB5                  \ [0x05] SEC2BB5
    $06 constant FLASH_SEC2BB6                  \ [0x06] SEC2BB6
    $07 constant FLASH_SEC2BB7                  \ [0x07] SEC2BB7
    $08 constant FLASH_SEC2BB8                  \ [0x08] SEC2BB8
    $09 constant FLASH_SEC2BB9                  \ [0x09] SEC2BB9
    $0a constant FLASH_SEC2BB10                 \ [0x0a] SEC2BB10
    $0b constant FLASH_SEC2BB11                 \ [0x0b] SEC2BB11
    $0c constant FLASH_SEC2BB12                 \ [0x0c] SEC2BB12
    $0d constant FLASH_SEC2BB13                 \ [0x0d] SEC2BB13
    $0e constant FLASH_SEC2BB14                 \ [0x0e] SEC2BB14
    $0f constant FLASH_SEC2BB15                 \ [0x0f] SEC2BB15
    $10 constant FLASH_SEC2BB16                 \ [0x10] SEC2BB16
    $11 constant FLASH_SEC2BB17                 \ [0x11] SEC2BB17
    $12 constant FLASH_SEC2BB18                 \ [0x12] SEC2BB18
    $13 constant FLASH_SEC2BB19                 \ [0x13] SEC2BB19
    $14 constant FLASH_SEC2BB20                 \ [0x14] SEC2BB20
    $15 constant FLASH_SEC2BB21                 \ [0x15] SEC2BB21
    $16 constant FLASH_SEC2BB22                 \ [0x16] SEC2BB22
    $17 constant FLASH_SEC2BB23                 \ [0x17] SEC2BB23
    $18 constant FLASH_SEC2BB24                 \ [0x18] SEC2BB24
    $19 constant FLASH_SEC2BB25                 \ [0x19] SEC2BB25
    $1a constant FLASH_SEC2BB26                 \ [0x1a] SEC2BB26
    $1b constant FLASH_SEC2BB27                 \ [0x1b] SEC2BB27
    $1c constant FLASH_SEC2BB28                 \ [0x1c] SEC2BB28
    $1d constant FLASH_SEC2BB29                 \ [0x1d] SEC2BB29
    $1e constant FLASH_SEC2BB30                 \ [0x1e] SEC2BB30
    $1f constant FLASH_SEC2BB31                 \ [0x1f] SEC2BB31
  [then]


  [ifdef] FLASH_FLASH_SEC2BBR3_DEF
    \
    \ @brief FLASH secure block based bank 2 register 3
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC2BB0                  \ [0x00] SEC2BB0
    $01 constant FLASH_SEC2BB1                  \ [0x01] SEC2BB1
    $02 constant FLASH_SEC2BB2                  \ [0x02] SEC2BB2
    $03 constant FLASH_SEC2BB3                  \ [0x03] SEC2BB3
    $04 constant FLASH_SEC2BB4                  \ [0x04] SEC2BB4
    $05 constant FLASH_SEC2BB5                  \ [0x05] SEC2BB5
    $06 constant FLASH_SEC2BB6                  \ [0x06] SEC2BB6
    $07 constant FLASH_SEC2BB7                  \ [0x07] SEC2BB7
    $08 constant FLASH_SEC2BB8                  \ [0x08] SEC2BB8
    $09 constant FLASH_SEC2BB9                  \ [0x09] SEC2BB9
    $0a constant FLASH_SEC2BB10                 \ [0x0a] SEC2BB10
    $0b constant FLASH_SEC2BB11                 \ [0x0b] SEC2BB11
    $0c constant FLASH_SEC2BB12                 \ [0x0c] SEC2BB12
    $0d constant FLASH_SEC2BB13                 \ [0x0d] SEC2BB13
    $0e constant FLASH_SEC2BB14                 \ [0x0e] SEC2BB14
    $0f constant FLASH_SEC2BB15                 \ [0x0f] SEC2BB15
    $10 constant FLASH_SEC2BB16                 \ [0x10] SEC2BB16
    $11 constant FLASH_SEC2BB17                 \ [0x11] SEC2BB17
    $12 constant FLASH_SEC2BB18                 \ [0x12] SEC2BB18
    $13 constant FLASH_SEC2BB19                 \ [0x13] SEC2BB19
    $14 constant FLASH_SEC2BB20                 \ [0x14] SEC2BB20
    $15 constant FLASH_SEC2BB21                 \ [0x15] SEC2BB21
    $16 constant FLASH_SEC2BB22                 \ [0x16] SEC2BB22
    $17 constant FLASH_SEC2BB23                 \ [0x17] SEC2BB23
    $18 constant FLASH_SEC2BB24                 \ [0x18] SEC2BB24
    $19 constant FLASH_SEC2BB25                 \ [0x19] SEC2BB25
    $1a constant FLASH_SEC2BB26                 \ [0x1a] SEC2BB26
    $1b constant FLASH_SEC2BB27                 \ [0x1b] SEC2BB27
    $1c constant FLASH_SEC2BB28                 \ [0x1c] SEC2BB28
    $1d constant FLASH_SEC2BB29                 \ [0x1d] SEC2BB29
    $1e constant FLASH_SEC2BB30                 \ [0x1e] SEC2BB30
    $1f constant FLASH_SEC2BB31                 \ [0x1f] SEC2BB31
  [then]


  [ifdef] FLASH_FLASH_SEC2BBR4_DEF
    \
    \ @brief FLASH secure block based bank 2 register 4
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC2BB0                  \ [0x00] SEC2BB0
    $01 constant FLASH_SEC2BB1                  \ [0x01] SEC2BB1
    $02 constant FLASH_SEC2BB2                  \ [0x02] SEC2BB2
    $03 constant FLASH_SEC2BB3                  \ [0x03] SEC2BB3
    $04 constant FLASH_SEC2BB4                  \ [0x04] SEC2BB4
    $05 constant FLASH_SEC2BB5                  \ [0x05] SEC2BB5
    $06 constant FLASH_SEC2BB6                  \ [0x06] SEC2BB6
    $07 constant FLASH_SEC2BB7                  \ [0x07] SEC2BB7
    $08 constant FLASH_SEC2BB8                  \ [0x08] SEC2BB8
    $09 constant FLASH_SEC2BB9                  \ [0x09] SEC2BB9
    $0a constant FLASH_SEC2BB10                 \ [0x0a] SEC2BB10
    $0b constant FLASH_SEC2BB11                 \ [0x0b] SEC2BB11
    $0c constant FLASH_SEC2BB12                 \ [0x0c] SEC2BB12
    $0d constant FLASH_SEC2BB13                 \ [0x0d] SEC2BB13
    $0e constant FLASH_SEC2BB14                 \ [0x0e] SEC2BB14
    $0f constant FLASH_SEC2BB15                 \ [0x0f] SEC2BB15
    $10 constant FLASH_SEC2BB16                 \ [0x10] SEC2BB16
    $11 constant FLASH_SEC2BB17                 \ [0x11] SEC2BB17
    $12 constant FLASH_SEC2BB18                 \ [0x12] SEC2BB18
    $13 constant FLASH_SEC2BB19                 \ [0x13] SEC2BB19
    $14 constant FLASH_SEC2BB20                 \ [0x14] SEC2BB20
    $15 constant FLASH_SEC2BB21                 \ [0x15] SEC2BB21
    $16 constant FLASH_SEC2BB22                 \ [0x16] SEC2BB22
    $17 constant FLASH_SEC2BB23                 \ [0x17] SEC2BB23
    $18 constant FLASH_SEC2BB24                 \ [0x18] SEC2BB24
    $19 constant FLASH_SEC2BB25                 \ [0x19] SEC2BB25
    $1a constant FLASH_SEC2BB26                 \ [0x1a] SEC2BB26
    $1b constant FLASH_SEC2BB27                 \ [0x1b] SEC2BB27
    $1c constant FLASH_SEC2BB28                 \ [0x1c] SEC2BB28
    $1d constant FLASH_SEC2BB29                 \ [0x1d] SEC2BB29
    $1e constant FLASH_SEC2BB30                 \ [0x1e] SEC2BB30
    $1f constant FLASH_SEC2BB31                 \ [0x1f] SEC2BB31
  [then]


  [ifdef] FLASH_FLASH_SEC2BBR5_DEF
    \
    \ @brief FLASH secure block based bank 2 register 5
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC2BB0                  \ [0x00] SEC2BB0
    $01 constant FLASH_SEC2BB1                  \ [0x01] SEC2BB1
    $02 constant FLASH_SEC2BB2                  \ [0x02] SEC2BB2
    $03 constant FLASH_SEC2BB3                  \ [0x03] SEC2BB3
    $04 constant FLASH_SEC2BB4                  \ [0x04] SEC2BB4
    $05 constant FLASH_SEC2BB5                  \ [0x05] SEC2BB5
    $06 constant FLASH_SEC2BB6                  \ [0x06] SEC2BB6
    $07 constant FLASH_SEC2BB7                  \ [0x07] SEC2BB7
    $08 constant FLASH_SEC2BB8                  \ [0x08] SEC2BB8
    $09 constant FLASH_SEC2BB9                  \ [0x09] SEC2BB9
    $0a constant FLASH_SEC2BB10                 \ [0x0a] SEC2BB10
    $0b constant FLASH_SEC2BB11                 \ [0x0b] SEC2BB11
    $0c constant FLASH_SEC2BB12                 \ [0x0c] SEC2BB12
    $0d constant FLASH_SEC2BB13                 \ [0x0d] SEC2BB13
    $0e constant FLASH_SEC2BB14                 \ [0x0e] SEC2BB14
    $0f constant FLASH_SEC2BB15                 \ [0x0f] SEC2BB15
    $10 constant FLASH_SEC2BB16                 \ [0x10] SEC2BB16
    $11 constant FLASH_SEC2BB17                 \ [0x11] SEC2BB17
    $12 constant FLASH_SEC2BB18                 \ [0x12] SEC2BB18
    $13 constant FLASH_SEC2BB19                 \ [0x13] SEC2BB19
    $14 constant FLASH_SEC2BB20                 \ [0x14] SEC2BB20
    $15 constant FLASH_SEC2BB21                 \ [0x15] SEC2BB21
    $16 constant FLASH_SEC2BB22                 \ [0x16] SEC2BB22
    $17 constant FLASH_SEC2BB23                 \ [0x17] SEC2BB23
    $18 constant FLASH_SEC2BB24                 \ [0x18] SEC2BB24
    $19 constant FLASH_SEC2BB25                 \ [0x19] SEC2BB25
    $1a constant FLASH_SEC2BB26                 \ [0x1a] SEC2BB26
    $1b constant FLASH_SEC2BB27                 \ [0x1b] SEC2BB27
    $1c constant FLASH_SEC2BB28                 \ [0x1c] SEC2BB28
    $1d constant FLASH_SEC2BB29                 \ [0x1d] SEC2BB29
    $1e constant FLASH_SEC2BB30                 \ [0x1e] SEC2BB30
    $1f constant FLASH_SEC2BB31                 \ [0x1f] SEC2BB31
  [then]


  [ifdef] FLASH_FLASH_SEC2BBR6_DEF
    \
    \ @brief FLASH secure block based bank 2 register 6
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC2BB0                  \ [0x00] SEC2BB0
    $01 constant FLASH_SEC2BB1                  \ [0x01] SEC2BB1
    $02 constant FLASH_SEC2BB2                  \ [0x02] SEC2BB2
    $03 constant FLASH_SEC2BB3                  \ [0x03] SEC2BB3
    $04 constant FLASH_SEC2BB4                  \ [0x04] SEC2BB4
    $05 constant FLASH_SEC2BB5                  \ [0x05] SEC2BB5
    $06 constant FLASH_SEC2BB6                  \ [0x06] SEC2BB6
    $07 constant FLASH_SEC2BB7                  \ [0x07] SEC2BB7
    $08 constant FLASH_SEC2BB8                  \ [0x08] SEC2BB8
    $09 constant FLASH_SEC2BB9                  \ [0x09] SEC2BB9
    $0a constant FLASH_SEC2BB10                 \ [0x0a] SEC2BB10
    $0b constant FLASH_SEC2BB11                 \ [0x0b] SEC2BB11
    $0c constant FLASH_SEC2BB12                 \ [0x0c] SEC2BB12
    $0d constant FLASH_SEC2BB13                 \ [0x0d] SEC2BB13
    $0e constant FLASH_SEC2BB14                 \ [0x0e] SEC2BB14
    $0f constant FLASH_SEC2BB15                 \ [0x0f] SEC2BB15
    $10 constant FLASH_SEC2BB16                 \ [0x10] SEC2BB16
    $11 constant FLASH_SEC2BB17                 \ [0x11] SEC2BB17
    $12 constant FLASH_SEC2BB18                 \ [0x12] SEC2BB18
    $13 constant FLASH_SEC2BB19                 \ [0x13] SEC2BB19
    $14 constant FLASH_SEC2BB20                 \ [0x14] SEC2BB20
    $15 constant FLASH_SEC2BB21                 \ [0x15] SEC2BB21
    $16 constant FLASH_SEC2BB22                 \ [0x16] SEC2BB22
    $17 constant FLASH_SEC2BB23                 \ [0x17] SEC2BB23
    $18 constant FLASH_SEC2BB24                 \ [0x18] SEC2BB24
    $19 constant FLASH_SEC2BB25                 \ [0x19] SEC2BB25
    $1a constant FLASH_SEC2BB26                 \ [0x1a] SEC2BB26
    $1b constant FLASH_SEC2BB27                 \ [0x1b] SEC2BB27
    $1c constant FLASH_SEC2BB28                 \ [0x1c] SEC2BB28
    $1d constant FLASH_SEC2BB29                 \ [0x1d] SEC2BB29
    $1e constant FLASH_SEC2BB30                 \ [0x1e] SEC2BB30
    $1f constant FLASH_SEC2BB31                 \ [0x1f] SEC2BB31
  [then]


  [ifdef] FLASH_FLASH_SEC2BBR7_DEF
    \
    \ @brief FLASH secure block based bank 2 register 7
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC2BB0                  \ [0x00] SEC2BB0
    $01 constant FLASH_SEC2BB1                  \ [0x01] SEC2BB1
    $02 constant FLASH_SEC2BB2                  \ [0x02] SEC2BB2
    $03 constant FLASH_SEC2BB3                  \ [0x03] SEC2BB3
    $04 constant FLASH_SEC2BB4                  \ [0x04] SEC2BB4
    $05 constant FLASH_SEC2BB5                  \ [0x05] SEC2BB5
    $06 constant FLASH_SEC2BB6                  \ [0x06] SEC2BB6
    $07 constant FLASH_SEC2BB7                  \ [0x07] SEC2BB7
    $08 constant FLASH_SEC2BB8                  \ [0x08] SEC2BB8
    $09 constant FLASH_SEC2BB9                  \ [0x09] SEC2BB9
    $0a constant FLASH_SEC2BB10                 \ [0x0a] SEC2BB10
    $0b constant FLASH_SEC2BB11                 \ [0x0b] SEC2BB11
    $0c constant FLASH_SEC2BB12                 \ [0x0c] SEC2BB12
    $0d constant FLASH_SEC2BB13                 \ [0x0d] SEC2BB13
    $0e constant FLASH_SEC2BB14                 \ [0x0e] SEC2BB14
    $0f constant FLASH_SEC2BB15                 \ [0x0f] SEC2BB15
    $10 constant FLASH_SEC2BB16                 \ [0x10] SEC2BB16
    $11 constant FLASH_SEC2BB17                 \ [0x11] SEC2BB17
    $12 constant FLASH_SEC2BB18                 \ [0x12] SEC2BB18
    $13 constant FLASH_SEC2BB19                 \ [0x13] SEC2BB19
    $14 constant FLASH_SEC2BB20                 \ [0x14] SEC2BB20
    $15 constant FLASH_SEC2BB21                 \ [0x15] SEC2BB21
    $16 constant FLASH_SEC2BB22                 \ [0x16] SEC2BB22
    $17 constant FLASH_SEC2BB23                 \ [0x17] SEC2BB23
    $18 constant FLASH_SEC2BB24                 \ [0x18] SEC2BB24
    $19 constant FLASH_SEC2BB25                 \ [0x19] SEC2BB25
    $1a constant FLASH_SEC2BB26                 \ [0x1a] SEC2BB26
    $1b constant FLASH_SEC2BB27                 \ [0x1b] SEC2BB27
    $1c constant FLASH_SEC2BB28                 \ [0x1c] SEC2BB28
    $1d constant FLASH_SEC2BB29                 \ [0x1d] SEC2BB29
    $1e constant FLASH_SEC2BB30                 \ [0x1e] SEC2BB30
    $1f constant FLASH_SEC2BB31                 \ [0x1f] SEC2BB31
  [then]


  [ifdef] FLASH_FLASH_SEC2BBR8_DEF
    \
    \ @brief FLASH secure block based bank 2 register 8
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC2BB0                  \ [0x00] SEC2BB0
    $01 constant FLASH_SEC2BB1                  \ [0x01] SEC2BB1
    $02 constant FLASH_SEC2BB2                  \ [0x02] SEC2BB2
    $03 constant FLASH_SEC2BB3                  \ [0x03] SEC2BB3
    $04 constant FLASH_SEC2BB4                  \ [0x04] SEC2BB4
    $05 constant FLASH_SEC2BB5                  \ [0x05] SEC2BB5
    $06 constant FLASH_SEC2BB6                  \ [0x06] SEC2BB6
    $07 constant FLASH_SEC2BB7                  \ [0x07] SEC2BB7
    $08 constant FLASH_SEC2BB8                  \ [0x08] SEC2BB8
    $09 constant FLASH_SEC2BB9                  \ [0x09] SEC2BB9
    $0a constant FLASH_SEC2BB10                 \ [0x0a] SEC2BB10
    $0b constant FLASH_SEC2BB11                 \ [0x0b] SEC2BB11
    $0c constant FLASH_SEC2BB12                 \ [0x0c] SEC2BB12
    $0d constant FLASH_SEC2BB13                 \ [0x0d] SEC2BB13
    $0e constant FLASH_SEC2BB14                 \ [0x0e] SEC2BB14
    $0f constant FLASH_SEC2BB15                 \ [0x0f] SEC2BB15
    $10 constant FLASH_SEC2BB16                 \ [0x10] SEC2BB16
    $11 constant FLASH_SEC2BB17                 \ [0x11] SEC2BB17
    $12 constant FLASH_SEC2BB18                 \ [0x12] SEC2BB18
    $13 constant FLASH_SEC2BB19                 \ [0x13] SEC2BB19
    $14 constant FLASH_SEC2BB20                 \ [0x14] SEC2BB20
    $15 constant FLASH_SEC2BB21                 \ [0x15] SEC2BB21
    $16 constant FLASH_SEC2BB22                 \ [0x16] SEC2BB22
    $17 constant FLASH_SEC2BB23                 \ [0x17] SEC2BB23
    $18 constant FLASH_SEC2BB24                 \ [0x18] SEC2BB24
    $19 constant FLASH_SEC2BB25                 \ [0x19] SEC2BB25
    $1a constant FLASH_SEC2BB26                 \ [0x1a] SEC2BB26
    $1b constant FLASH_SEC2BB27                 \ [0x1b] SEC2BB27
    $1c constant FLASH_SEC2BB28                 \ [0x1c] SEC2BB28
    $1d constant FLASH_SEC2BB29                 \ [0x1d] SEC2BB29
    $1e constant FLASH_SEC2BB30                 \ [0x1e] SEC2BB30
    $1f constant FLASH_SEC2BB31                 \ [0x1f] SEC2BB31
  [then]


  [ifdef] FLASH_FLASH_SECHDPCR_DEF
    \
    \ @brief FLASH secure HDP control register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP1_ACCDIS              \ [0x00] HDP1 area access disable When set, this bit is only cleared by a system reset.
    $01 constant FLASH_HDP2_ACCDIS              \ [0x01] HDP2 area access disable When set, this bit is only cleared by a system reset.
  [then]


  [ifdef] FLASH_FLASH_PRIVCFGR_DEF
    \
    \ @brief FLASH privilege configuration register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SPRIV                    \ [0x00] Privileged protection for secure registers
    $01 constant FLASH_NSPRIV                   \ [0x01] Privileged protection for non-secure registers
  [then]


  [ifdef] FLASH_FLASH_PRIV1BBR1_DEF
    \
    \ @brief FLASH privilege block based bank 1 register 1
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV1BB0                 \ [0x00] PRIV1BB0
    $01 constant FLASH_PRIV1BB1                 \ [0x01] PRIV1BB1
    $02 constant FLASH_PRIV1BB2                 \ [0x02] PRIV1BB2
    $03 constant FLASH_PRIV1BB3                 \ [0x03] PRIV1BB3
    $04 constant FLASH_PRIV1BB4                 \ [0x04] PRIV1BB4
    $05 constant FLASH_PRIV1BB5                 \ [0x05] PRIV1BB5
    $06 constant FLASH_PRIV1BB6                 \ [0x06] PRIV1BB6
    $07 constant FLASH_PRIV1BB7                 \ [0x07] PRIV1BB7
    $08 constant FLASH_PRIV1BB8                 \ [0x08] PRIV1BB8
    $09 constant FLASH_PRIV1BB9                 \ [0x09] PRIV1BB9
    $0a constant FLASH_PRIV1BB10                \ [0x0a] PRIV1BB10
    $0b constant FLASH_PRIV1BB11                \ [0x0b] PRIV1BB11
    $0c constant FLASH_PRIV1BB12                \ [0x0c] PRIV1BB12
    $0d constant FLASH_PRIV1BB13                \ [0x0d] PRIV1BB13
    $0e constant FLASH_PRIV1BB14                \ [0x0e] PRIV1BB14
    $0f constant FLASH_PRIV1BB15                \ [0x0f] PRIV1BB15
    $10 constant FLASH_PRIV1BB16                \ [0x10] PRIV1BB16
    $11 constant FLASH_PRIV1BB17                \ [0x11] PRIV1BB17
    $12 constant FLASH_PRIV1BB18                \ [0x12] PRIV1BB18
    $13 constant FLASH_PRIV1BB19                \ [0x13] PRIV1BB19
    $14 constant FLASH_PRIV1BB20                \ [0x14] PRIV1BB20
    $15 constant FLASH_PRIV1BB21                \ [0x15] PRIV1BB21
    $16 constant FLASH_PRIV1BB22                \ [0x16] PRIV1BB22
    $17 constant FLASH_PRIV1BB23                \ [0x17] PRIV1BB23
    $18 constant FLASH_PRIV1BB24                \ [0x18] PRIV1BB24
    $19 constant FLASH_PRIV1BB25                \ [0x19] PRIV1BB25
    $1a constant FLASH_PRIV1BB26                \ [0x1a] PRIV1BB26
    $1b constant FLASH_PRIV1BB27                \ [0x1b] PRIV1BB27
    $1c constant FLASH_PRIV1BB28                \ [0x1c] PRIV1BB28
    $1d constant FLASH_PRIV1BB29                \ [0x1d] PRIV1BB29
    $1e constant FLASH_PRIV1BB30                \ [0x1e] PRIV1BB30
    $1f constant FLASH_PRIV1BB31                \ [0x1f] PRIV1BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV1BBR2_DEF
    \
    \ @brief FLASH privilege block based bank 1 register 2
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV1BB0                 \ [0x00] PRIV1BB0
    $01 constant FLASH_PRIV1BB1                 \ [0x01] PRIV1BB1
    $02 constant FLASH_PRIV1BB2                 \ [0x02] PRIV1BB2
    $03 constant FLASH_PRIV1BB3                 \ [0x03] PRIV1BB3
    $04 constant FLASH_PRIV1BB4                 \ [0x04] PRIV1BB4
    $05 constant FLASH_PRIV1BB5                 \ [0x05] PRIV1BB5
    $06 constant FLASH_PRIV1BB6                 \ [0x06] PRIV1BB6
    $07 constant FLASH_PRIV1BB7                 \ [0x07] PRIV1BB7
    $08 constant FLASH_PRIV1BB8                 \ [0x08] PRIV1BB8
    $09 constant FLASH_PRIV1BB9                 \ [0x09] PRIV1BB9
    $0a constant FLASH_PRIV1BB10                \ [0x0a] PRIV1BB10
    $0b constant FLASH_PRIV1BB11                \ [0x0b] PRIV1BB11
    $0c constant FLASH_PRIV1BB12                \ [0x0c] PRIV1BB12
    $0d constant FLASH_PRIV1BB13                \ [0x0d] PRIV1BB13
    $0e constant FLASH_PRIV1BB14                \ [0x0e] PRIV1BB14
    $0f constant FLASH_PRIV1BB15                \ [0x0f] PRIV1BB15
    $10 constant FLASH_PRIV1BB16                \ [0x10] PRIV1BB16
    $11 constant FLASH_PRIV1BB17                \ [0x11] PRIV1BB17
    $12 constant FLASH_PRIV1BB18                \ [0x12] PRIV1BB18
    $13 constant FLASH_PRIV1BB19                \ [0x13] PRIV1BB19
    $14 constant FLASH_PRIV1BB20                \ [0x14] PRIV1BB20
    $15 constant FLASH_PRIV1BB21                \ [0x15] PRIV1BB21
    $16 constant FLASH_PRIV1BB22                \ [0x16] PRIV1BB22
    $17 constant FLASH_PRIV1BB23                \ [0x17] PRIV1BB23
    $18 constant FLASH_PRIV1BB24                \ [0x18] PRIV1BB24
    $19 constant FLASH_PRIV1BB25                \ [0x19] PRIV1BB25
    $1a constant FLASH_PRIV1BB26                \ [0x1a] PRIV1BB26
    $1b constant FLASH_PRIV1BB27                \ [0x1b] PRIV1BB27
    $1c constant FLASH_PRIV1BB28                \ [0x1c] PRIV1BB28
    $1d constant FLASH_PRIV1BB29                \ [0x1d] PRIV1BB29
    $1e constant FLASH_PRIV1BB30                \ [0x1e] PRIV1BB30
    $1f constant FLASH_PRIV1BB31                \ [0x1f] PRIV1BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV1BBR3_DEF
    \
    \ @brief FLASH privilege block based bank 1 register 3
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV1BB0                 \ [0x00] PRIV1BB0
    $01 constant FLASH_PRIV1BB1                 \ [0x01] PRIV1BB1
    $02 constant FLASH_PRIV1BB2                 \ [0x02] PRIV1BB2
    $03 constant FLASH_PRIV1BB3                 \ [0x03] PRIV1BB3
    $04 constant FLASH_PRIV1BB4                 \ [0x04] PRIV1BB4
    $05 constant FLASH_PRIV1BB5                 \ [0x05] PRIV1BB5
    $06 constant FLASH_PRIV1BB6                 \ [0x06] PRIV1BB6
    $07 constant FLASH_PRIV1BB7                 \ [0x07] PRIV1BB7
    $08 constant FLASH_PRIV1BB8                 \ [0x08] PRIV1BB8
    $09 constant FLASH_PRIV1BB9                 \ [0x09] PRIV1BB9
    $0a constant FLASH_PRIV1BB10                \ [0x0a] PRIV1BB10
    $0b constant FLASH_PRIV1BB11                \ [0x0b] PRIV1BB11
    $0c constant FLASH_PRIV1BB12                \ [0x0c] PRIV1BB12
    $0d constant FLASH_PRIV1BB13                \ [0x0d] PRIV1BB13
    $0e constant FLASH_PRIV1BB14                \ [0x0e] PRIV1BB14
    $0f constant FLASH_PRIV1BB15                \ [0x0f] PRIV1BB15
    $10 constant FLASH_PRIV1BB16                \ [0x10] PRIV1BB16
    $11 constant FLASH_PRIV1BB17                \ [0x11] PRIV1BB17
    $12 constant FLASH_PRIV1BB18                \ [0x12] PRIV1BB18
    $13 constant FLASH_PRIV1BB19                \ [0x13] PRIV1BB19
    $14 constant FLASH_PRIV1BB20                \ [0x14] PRIV1BB20
    $15 constant FLASH_PRIV1BB21                \ [0x15] PRIV1BB21
    $16 constant FLASH_PRIV1BB22                \ [0x16] PRIV1BB22
    $17 constant FLASH_PRIV1BB23                \ [0x17] PRIV1BB23
    $18 constant FLASH_PRIV1BB24                \ [0x18] PRIV1BB24
    $19 constant FLASH_PRIV1BB25                \ [0x19] PRIV1BB25
    $1a constant FLASH_PRIV1BB26                \ [0x1a] PRIV1BB26
    $1b constant FLASH_PRIV1BB27                \ [0x1b] PRIV1BB27
    $1c constant FLASH_PRIV1BB28                \ [0x1c] PRIV1BB28
    $1d constant FLASH_PRIV1BB29                \ [0x1d] PRIV1BB29
    $1e constant FLASH_PRIV1BB30                \ [0x1e] PRIV1BB30
    $1f constant FLASH_PRIV1BB31                \ [0x1f] PRIV1BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV1BBR4_DEF
    \
    \ @brief FLASH privilege block based bank 1 register 4
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV1BB0                 \ [0x00] PRIV1BB0
    $01 constant FLASH_PRIV1BB1                 \ [0x01] PRIV1BB1
    $02 constant FLASH_PRIV1BB2                 \ [0x02] PRIV1BB2
    $03 constant FLASH_PRIV1BB3                 \ [0x03] PRIV1BB3
    $04 constant FLASH_PRIV1BB4                 \ [0x04] PRIV1BB4
    $05 constant FLASH_PRIV1BB5                 \ [0x05] PRIV1BB5
    $06 constant FLASH_PRIV1BB6                 \ [0x06] PRIV1BB6
    $07 constant FLASH_PRIV1BB7                 \ [0x07] PRIV1BB7
    $08 constant FLASH_PRIV1BB8                 \ [0x08] PRIV1BB8
    $09 constant FLASH_PRIV1BB9                 \ [0x09] PRIV1BB9
    $0a constant FLASH_PRIV1BB10                \ [0x0a] PRIV1BB10
    $0b constant FLASH_PRIV1BB11                \ [0x0b] PRIV1BB11
    $0c constant FLASH_PRIV1BB12                \ [0x0c] PRIV1BB12
    $0d constant FLASH_PRIV1BB13                \ [0x0d] PRIV1BB13
    $0e constant FLASH_PRIV1BB14                \ [0x0e] PRIV1BB14
    $0f constant FLASH_PRIV1BB15                \ [0x0f] PRIV1BB15
    $10 constant FLASH_PRIV1BB16                \ [0x10] PRIV1BB16
    $11 constant FLASH_PRIV1BB17                \ [0x11] PRIV1BB17
    $12 constant FLASH_PRIV1BB18                \ [0x12] PRIV1BB18
    $13 constant FLASH_PRIV1BB19                \ [0x13] PRIV1BB19
    $14 constant FLASH_PRIV1BB20                \ [0x14] PRIV1BB20
    $15 constant FLASH_PRIV1BB21                \ [0x15] PRIV1BB21
    $16 constant FLASH_PRIV1BB22                \ [0x16] PRIV1BB22
    $17 constant FLASH_PRIV1BB23                \ [0x17] PRIV1BB23
    $18 constant FLASH_PRIV1BB24                \ [0x18] PRIV1BB24
    $19 constant FLASH_PRIV1BB25                \ [0x19] PRIV1BB25
    $1a constant FLASH_PRIV1BB26                \ [0x1a] PRIV1BB26
    $1b constant FLASH_PRIV1BB27                \ [0x1b] PRIV1BB27
    $1c constant FLASH_PRIV1BB28                \ [0x1c] PRIV1BB28
    $1d constant FLASH_PRIV1BB29                \ [0x1d] PRIV1BB29
    $1e constant FLASH_PRIV1BB30                \ [0x1e] PRIV1BB30
    $1f constant FLASH_PRIV1BB31                \ [0x1f] PRIV1BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV1BBR5_DEF
    \
    \ @brief FLASH privilege block based bank 1 register 5
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV1BB0                 \ [0x00] PRIV1BB0
    $01 constant FLASH_PRIV1BB1                 \ [0x01] PRIV1BB1
    $02 constant FLASH_PRIV1BB2                 \ [0x02] PRIV1BB2
    $03 constant FLASH_PRIV1BB3                 \ [0x03] PRIV1BB3
    $04 constant FLASH_PRIV1BB4                 \ [0x04] PRIV1BB4
    $05 constant FLASH_PRIV1BB5                 \ [0x05] PRIV1BB5
    $06 constant FLASH_PRIV1BB6                 \ [0x06] PRIV1BB6
    $07 constant FLASH_PRIV1BB7                 \ [0x07] PRIV1BB7
    $08 constant FLASH_PRIV1BB8                 \ [0x08] PRIV1BB8
    $09 constant FLASH_PRIV1BB9                 \ [0x09] PRIV1BB9
    $0a constant FLASH_PRIV1BB10                \ [0x0a] PRIV1BB10
    $0b constant FLASH_PRIV1BB11                \ [0x0b] PRIV1BB11
    $0c constant FLASH_PRIV1BB12                \ [0x0c] PRIV1BB12
    $0d constant FLASH_PRIV1BB13                \ [0x0d] PRIV1BB13
    $0e constant FLASH_PRIV1BB14                \ [0x0e] PRIV1BB14
    $0f constant FLASH_PRIV1BB15                \ [0x0f] PRIV1BB15
    $10 constant FLASH_PRIV1BB16                \ [0x10] PRIV1BB16
    $11 constant FLASH_PRIV1BB17                \ [0x11] PRIV1BB17
    $12 constant FLASH_PRIV1BB18                \ [0x12] PRIV1BB18
    $13 constant FLASH_PRIV1BB19                \ [0x13] PRIV1BB19
    $14 constant FLASH_PRIV1BB20                \ [0x14] PRIV1BB20
    $15 constant FLASH_PRIV1BB21                \ [0x15] PRIV1BB21
    $16 constant FLASH_PRIV1BB22                \ [0x16] PRIV1BB22
    $17 constant FLASH_PRIV1BB23                \ [0x17] PRIV1BB23
    $18 constant FLASH_PRIV1BB24                \ [0x18] PRIV1BB24
    $19 constant FLASH_PRIV1BB25                \ [0x19] PRIV1BB25
    $1a constant FLASH_PRIV1BB26                \ [0x1a] PRIV1BB26
    $1b constant FLASH_PRIV1BB27                \ [0x1b] PRIV1BB27
    $1c constant FLASH_PRIV1BB28                \ [0x1c] PRIV1BB28
    $1d constant FLASH_PRIV1BB29                \ [0x1d] PRIV1BB29
    $1e constant FLASH_PRIV1BB30                \ [0x1e] PRIV1BB30
    $1f constant FLASH_PRIV1BB31                \ [0x1f] PRIV1BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV1BBR6_DEF
    \
    \ @brief FLASH privilege block based bank 1 register 6
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV1BB0                 \ [0x00] PRIV1BB0
    $01 constant FLASH_PRIV1BB1                 \ [0x01] PRIV1BB1
    $02 constant FLASH_PRIV1BB2                 \ [0x02] PRIV1BB2
    $03 constant FLASH_PRIV1BB3                 \ [0x03] PRIV1BB3
    $04 constant FLASH_PRIV1BB4                 \ [0x04] PRIV1BB4
    $05 constant FLASH_PRIV1BB5                 \ [0x05] PRIV1BB5
    $06 constant FLASH_PRIV1BB6                 \ [0x06] PRIV1BB6
    $07 constant FLASH_PRIV1BB7                 \ [0x07] PRIV1BB7
    $08 constant FLASH_PRIV1BB8                 \ [0x08] PRIV1BB8
    $09 constant FLASH_PRIV1BB9                 \ [0x09] PRIV1BB9
    $0a constant FLASH_PRIV1BB10                \ [0x0a] PRIV1BB10
    $0b constant FLASH_PRIV1BB11                \ [0x0b] PRIV1BB11
    $0c constant FLASH_PRIV1BB12                \ [0x0c] PRIV1BB12
    $0d constant FLASH_PRIV1BB13                \ [0x0d] PRIV1BB13
    $0e constant FLASH_PRIV1BB14                \ [0x0e] PRIV1BB14
    $0f constant FLASH_PRIV1BB15                \ [0x0f] PRIV1BB15
    $10 constant FLASH_PRIV1BB16                \ [0x10] PRIV1BB16
    $11 constant FLASH_PRIV1BB17                \ [0x11] PRIV1BB17
    $12 constant FLASH_PRIV1BB18                \ [0x12] PRIV1BB18
    $13 constant FLASH_PRIV1BB19                \ [0x13] PRIV1BB19
    $14 constant FLASH_PRIV1BB20                \ [0x14] PRIV1BB20
    $15 constant FLASH_PRIV1BB21                \ [0x15] PRIV1BB21
    $16 constant FLASH_PRIV1BB22                \ [0x16] PRIV1BB22
    $17 constant FLASH_PRIV1BB23                \ [0x17] PRIV1BB23
    $18 constant FLASH_PRIV1BB24                \ [0x18] PRIV1BB24
    $19 constant FLASH_PRIV1BB25                \ [0x19] PRIV1BB25
    $1a constant FLASH_PRIV1BB26                \ [0x1a] PRIV1BB26
    $1b constant FLASH_PRIV1BB27                \ [0x1b] PRIV1BB27
    $1c constant FLASH_PRIV1BB28                \ [0x1c] PRIV1BB28
    $1d constant FLASH_PRIV1BB29                \ [0x1d] PRIV1BB29
    $1e constant FLASH_PRIV1BB30                \ [0x1e] PRIV1BB30
    $1f constant FLASH_PRIV1BB31                \ [0x1f] PRIV1BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV1BBR7_DEF
    \
    \ @brief FLASH privilege block based bank 1 register 7
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV1BB0                 \ [0x00] PRIV1BB0
    $01 constant FLASH_PRIV1BB1                 \ [0x01] PRIV1BB1
    $02 constant FLASH_PRIV1BB2                 \ [0x02] PRIV1BB2
    $03 constant FLASH_PRIV1BB3                 \ [0x03] PRIV1BB3
    $04 constant FLASH_PRIV1BB4                 \ [0x04] PRIV1BB4
    $05 constant FLASH_PRIV1BB5                 \ [0x05] PRIV1BB5
    $06 constant FLASH_PRIV1BB6                 \ [0x06] PRIV1BB6
    $07 constant FLASH_PRIV1BB7                 \ [0x07] PRIV1BB7
    $08 constant FLASH_PRIV1BB8                 \ [0x08] PRIV1BB8
    $09 constant FLASH_PRIV1BB9                 \ [0x09] PRIV1BB9
    $0a constant FLASH_PRIV1BB10                \ [0x0a] PRIV1BB10
    $0b constant FLASH_PRIV1BB11                \ [0x0b] PRIV1BB11
    $0c constant FLASH_PRIV1BB12                \ [0x0c] PRIV1BB12
    $0d constant FLASH_PRIV1BB13                \ [0x0d] PRIV1BB13
    $0e constant FLASH_PRIV1BB14                \ [0x0e] PRIV1BB14
    $0f constant FLASH_PRIV1BB15                \ [0x0f] PRIV1BB15
    $10 constant FLASH_PRIV1BB16                \ [0x10] PRIV1BB16
    $11 constant FLASH_PRIV1BB17                \ [0x11] PRIV1BB17
    $12 constant FLASH_PRIV1BB18                \ [0x12] PRIV1BB18
    $13 constant FLASH_PRIV1BB19                \ [0x13] PRIV1BB19
    $14 constant FLASH_PRIV1BB20                \ [0x14] PRIV1BB20
    $15 constant FLASH_PRIV1BB21                \ [0x15] PRIV1BB21
    $16 constant FLASH_PRIV1BB22                \ [0x16] PRIV1BB22
    $17 constant FLASH_PRIV1BB23                \ [0x17] PRIV1BB23
    $18 constant FLASH_PRIV1BB24                \ [0x18] PRIV1BB24
    $19 constant FLASH_PRIV1BB25                \ [0x19] PRIV1BB25
    $1a constant FLASH_PRIV1BB26                \ [0x1a] PRIV1BB26
    $1b constant FLASH_PRIV1BB27                \ [0x1b] PRIV1BB27
    $1c constant FLASH_PRIV1BB28                \ [0x1c] PRIV1BB28
    $1d constant FLASH_PRIV1BB29                \ [0x1d] PRIV1BB29
    $1e constant FLASH_PRIV1BB30                \ [0x1e] PRIV1BB30
    $1f constant FLASH_PRIV1BB31                \ [0x1f] PRIV1BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV1BBR8_DEF
    \
    \ @brief FLASH privilege block based bank 1 register 8
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV1BB0                 \ [0x00] PRIV1BB0
    $01 constant FLASH_PRIV1BB1                 \ [0x01] PRIV1BB1
    $02 constant FLASH_PRIV1BB2                 \ [0x02] PRIV1BB2
    $03 constant FLASH_PRIV1BB3                 \ [0x03] PRIV1BB3
    $04 constant FLASH_PRIV1BB4                 \ [0x04] PRIV1BB4
    $05 constant FLASH_PRIV1BB5                 \ [0x05] PRIV1BB5
    $06 constant FLASH_PRIV1BB6                 \ [0x06] PRIV1BB6
    $07 constant FLASH_PRIV1BB7                 \ [0x07] PRIV1BB7
    $08 constant FLASH_PRIV1BB8                 \ [0x08] PRIV1BB8
    $09 constant FLASH_PRIV1BB9                 \ [0x09] PRIV1BB9
    $0a constant FLASH_PRIV1BB10                \ [0x0a] PRIV1BB10
    $0b constant FLASH_PRIV1BB11                \ [0x0b] PRIV1BB11
    $0c constant FLASH_PRIV1BB12                \ [0x0c] PRIV1BB12
    $0d constant FLASH_PRIV1BB13                \ [0x0d] PRIV1BB13
    $0e constant FLASH_PRIV1BB14                \ [0x0e] PRIV1BB14
    $0f constant FLASH_PRIV1BB15                \ [0x0f] PRIV1BB15
    $10 constant FLASH_PRIV1BB16                \ [0x10] PRIV1BB16
    $11 constant FLASH_PRIV1BB17                \ [0x11] PRIV1BB17
    $12 constant FLASH_PRIV1BB18                \ [0x12] PRIV1BB18
    $13 constant FLASH_PRIV1BB19                \ [0x13] PRIV1BB19
    $14 constant FLASH_PRIV1BB20                \ [0x14] PRIV1BB20
    $15 constant FLASH_PRIV1BB21                \ [0x15] PRIV1BB21
    $16 constant FLASH_PRIV1BB22                \ [0x16] PRIV1BB22
    $17 constant FLASH_PRIV1BB23                \ [0x17] PRIV1BB23
    $18 constant FLASH_PRIV1BB24                \ [0x18] PRIV1BB24
    $19 constant FLASH_PRIV1BB25                \ [0x19] PRIV1BB25
    $1a constant FLASH_PRIV1BB26                \ [0x1a] PRIV1BB26
    $1b constant FLASH_PRIV1BB27                \ [0x1b] PRIV1BB27
    $1c constant FLASH_PRIV1BB28                \ [0x1c] PRIV1BB28
    $1d constant FLASH_PRIV1BB29                \ [0x1d] PRIV1BB29
    $1e constant FLASH_PRIV1BB30                \ [0x1e] PRIV1BB30
    $1f constant FLASH_PRIV1BB31                \ [0x1f] PRIV1BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV2BBR1_DEF
    \
    \ @brief FLASH privilege block based bank 2 register 1
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV2BB0                 \ [0x00] PRIV2BB0
    $01 constant FLASH_PRIV2BB1                 \ [0x01] PRIV2BB1
    $02 constant FLASH_PRIV2BB2                 \ [0x02] PRIV2BB2
    $03 constant FLASH_PRIV2BB3                 \ [0x03] PRIV2BB3
    $04 constant FLASH_PRIV2BB4                 \ [0x04] PRIV2BB4
    $05 constant FLASH_PRIV2BB5                 \ [0x05] PRIV2BB5
    $06 constant FLASH_PRIV2BB6                 \ [0x06] PRIV2BB6
    $07 constant FLASH_PRIV2BB7                 \ [0x07] PRIV2BB7
    $08 constant FLASH_PRIV2BB8                 \ [0x08] PRIV2BB8
    $09 constant FLASH_PRIV2BB9                 \ [0x09] PRIV2BB9
    $0a constant FLASH_PRIV2BB10                \ [0x0a] PRIV2BB10
    $0b constant FLASH_PRIV2BB11                \ [0x0b] PRIV2BB11
    $0c constant FLASH_PRIV2BB12                \ [0x0c] PRIV2BB12
    $0d constant FLASH_PRIV2BB13                \ [0x0d] PRIV2BB13
    $0e constant FLASH_PRIV2BB14                \ [0x0e] PRIV2BB14
    $0f constant FLASH_PRIV2BB15                \ [0x0f] PRIV2BB15
    $10 constant FLASH_PRIV2BB16                \ [0x10] PRIV2BB16
    $11 constant FLASH_PRIV2BB17                \ [0x11] PRIV2BB17
    $12 constant FLASH_PRIV2BB18                \ [0x12] PRIV2BB18
    $13 constant FLASH_PRIV2BB19                \ [0x13] PRIV2BB19
    $14 constant FLASH_PRIV2BB20                \ [0x14] PRIV2BB20
    $15 constant FLASH_PRIV2BB21                \ [0x15] PRIV2BB21
    $16 constant FLASH_PRIV2BB22                \ [0x16] PRIV2BB22
    $17 constant FLASH_PRIV2BB23                \ [0x17] PRIV2BB23
    $18 constant FLASH_PRIV2BB24                \ [0x18] PRIV2BB24
    $19 constant FLASH_PRIV2BB25                \ [0x19] PRIV2BB25
    $1a constant FLASH_PRIV2BB26                \ [0x1a] PRIV2BB26
    $1b constant FLASH_PRIV2BB27                \ [0x1b] PRIV2BB27
    $1c constant FLASH_PRIV2BB28                \ [0x1c] PRIV2BB28
    $1d constant FLASH_PRIV2BB29                \ [0x1d] PRIV2BB29
    $1e constant FLASH_PRIV2BB30                \ [0x1e] PRIV2BB30
    $1f constant FLASH_PRIV2BB31                \ [0x1f] PRIV2BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV2BBR2_DEF
    \
    \ @brief FLASH privilege block based bank 2 register 2
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV2BB0                 \ [0x00] PRIV2BB0
    $01 constant FLASH_PRIV2BB1                 \ [0x01] PRIV2BB1
    $02 constant FLASH_PRIV2BB2                 \ [0x02] PRIV2BB2
    $03 constant FLASH_PRIV2BB3                 \ [0x03] PRIV2BB3
    $04 constant FLASH_PRIV2BB4                 \ [0x04] PRIV2BB4
    $05 constant FLASH_PRIV2BB5                 \ [0x05] PRIV2BB5
    $06 constant FLASH_PRIV2BB6                 \ [0x06] PRIV2BB6
    $07 constant FLASH_PRIV2BB7                 \ [0x07] PRIV2BB7
    $08 constant FLASH_PRIV2BB8                 \ [0x08] PRIV2BB8
    $09 constant FLASH_PRIV2BB9                 \ [0x09] PRIV2BB9
    $0a constant FLASH_PRIV2BB10                \ [0x0a] PRIV2BB10
    $0b constant FLASH_PRIV2BB11                \ [0x0b] PRIV2BB11
    $0c constant FLASH_PRIV2BB12                \ [0x0c] PRIV2BB12
    $0d constant FLASH_PRIV2BB13                \ [0x0d] PRIV2BB13
    $0e constant FLASH_PRIV2BB14                \ [0x0e] PRIV2BB14
    $0f constant FLASH_PRIV2BB15                \ [0x0f] PRIV2BB15
    $10 constant FLASH_PRIV2BB16                \ [0x10] PRIV2BB16
    $11 constant FLASH_PRIV2BB17                \ [0x11] PRIV2BB17
    $12 constant FLASH_PRIV2BB18                \ [0x12] PRIV2BB18
    $13 constant FLASH_PRIV2BB19                \ [0x13] PRIV2BB19
    $14 constant FLASH_PRIV2BB20                \ [0x14] PRIV2BB20
    $15 constant FLASH_PRIV2BB21                \ [0x15] PRIV2BB21
    $16 constant FLASH_PRIV2BB22                \ [0x16] PRIV2BB22
    $17 constant FLASH_PRIV2BB23                \ [0x17] PRIV2BB23
    $18 constant FLASH_PRIV2BB24                \ [0x18] PRIV2BB24
    $19 constant FLASH_PRIV2BB25                \ [0x19] PRIV2BB25
    $1a constant FLASH_PRIV2BB26                \ [0x1a] PRIV2BB26
    $1b constant FLASH_PRIV2BB27                \ [0x1b] PRIV2BB27
    $1c constant FLASH_PRIV2BB28                \ [0x1c] PRIV2BB28
    $1d constant FLASH_PRIV2BB29                \ [0x1d] PRIV2BB29
    $1e constant FLASH_PRIV2BB30                \ [0x1e] PRIV2BB30
    $1f constant FLASH_PRIV2BB31                \ [0x1f] PRIV2BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV2BBR3_DEF
    \
    \ @brief FLASH privilege block based bank 2 register 3
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV2BB0                 \ [0x00] PRIV2BB0
    $01 constant FLASH_PRIV2BB1                 \ [0x01] PRIV2BB1
    $02 constant FLASH_PRIV2BB2                 \ [0x02] PRIV2BB2
    $03 constant FLASH_PRIV2BB3                 \ [0x03] PRIV2BB3
    $04 constant FLASH_PRIV2BB4                 \ [0x04] PRIV2BB4
    $05 constant FLASH_PRIV2BB5                 \ [0x05] PRIV2BB5
    $06 constant FLASH_PRIV2BB6                 \ [0x06] PRIV2BB6
    $07 constant FLASH_PRIV2BB7                 \ [0x07] PRIV2BB7
    $08 constant FLASH_PRIV2BB8                 \ [0x08] PRIV2BB8
    $09 constant FLASH_PRIV2BB9                 \ [0x09] PRIV2BB9
    $0a constant FLASH_PRIV2BB10                \ [0x0a] PRIV2BB10
    $0b constant FLASH_PRIV2BB11                \ [0x0b] PRIV2BB11
    $0c constant FLASH_PRIV2BB12                \ [0x0c] PRIV2BB12
    $0d constant FLASH_PRIV2BB13                \ [0x0d] PRIV2BB13
    $0e constant FLASH_PRIV2BB14                \ [0x0e] PRIV2BB14
    $0f constant FLASH_PRIV2BB15                \ [0x0f] PRIV2BB15
    $10 constant FLASH_PRIV2BB16                \ [0x10] PRIV2BB16
    $11 constant FLASH_PRIV2BB17                \ [0x11] PRIV2BB17
    $12 constant FLASH_PRIV2BB18                \ [0x12] PRIV2BB18
    $13 constant FLASH_PRIV2BB19                \ [0x13] PRIV2BB19
    $14 constant FLASH_PRIV2BB20                \ [0x14] PRIV2BB20
    $15 constant FLASH_PRIV2BB21                \ [0x15] PRIV2BB21
    $16 constant FLASH_PRIV2BB22                \ [0x16] PRIV2BB22
    $17 constant FLASH_PRIV2BB23                \ [0x17] PRIV2BB23
    $18 constant FLASH_PRIV2BB24                \ [0x18] PRIV2BB24
    $19 constant FLASH_PRIV2BB25                \ [0x19] PRIV2BB25
    $1a constant FLASH_PRIV2BB26                \ [0x1a] PRIV2BB26
    $1b constant FLASH_PRIV2BB27                \ [0x1b] PRIV2BB27
    $1c constant FLASH_PRIV2BB28                \ [0x1c] PRIV2BB28
    $1d constant FLASH_PRIV2BB29                \ [0x1d] PRIV2BB29
    $1e constant FLASH_PRIV2BB30                \ [0x1e] PRIV2BB30
    $1f constant FLASH_PRIV2BB31                \ [0x1f] PRIV2BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV2BBR4_DEF
    \
    \ @brief FLASH privilege block based bank 2 register 4
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV2BB0                 \ [0x00] PRIV2BB0
    $01 constant FLASH_PRIV2BB1                 \ [0x01] PRIV2BB1
    $02 constant FLASH_PRIV2BB2                 \ [0x02] PRIV2BB2
    $03 constant FLASH_PRIV2BB3                 \ [0x03] PRIV2BB3
    $04 constant FLASH_PRIV2BB4                 \ [0x04] PRIV2BB4
    $05 constant FLASH_PRIV2BB5                 \ [0x05] PRIV2BB5
    $06 constant FLASH_PRIV2BB6                 \ [0x06] PRIV2BB6
    $07 constant FLASH_PRIV2BB7                 \ [0x07] PRIV2BB7
    $08 constant FLASH_PRIV2BB8                 \ [0x08] PRIV2BB8
    $09 constant FLASH_PRIV2BB9                 \ [0x09] PRIV2BB9
    $0a constant FLASH_PRIV2BB10                \ [0x0a] PRIV2BB10
    $0b constant FLASH_PRIV2BB11                \ [0x0b] PRIV2BB11
    $0c constant FLASH_PRIV2BB12                \ [0x0c] PRIV2BB12
    $0d constant FLASH_PRIV2BB13                \ [0x0d] PRIV2BB13
    $0e constant FLASH_PRIV2BB14                \ [0x0e] PRIV2BB14
    $0f constant FLASH_PRIV2BB15                \ [0x0f] PRIV2BB15
    $10 constant FLASH_PRIV2BB16                \ [0x10] PRIV2BB16
    $11 constant FLASH_PRIV2BB17                \ [0x11] PRIV2BB17
    $12 constant FLASH_PRIV2BB18                \ [0x12] PRIV2BB18
    $13 constant FLASH_PRIV2BB19                \ [0x13] PRIV2BB19
    $14 constant FLASH_PRIV2BB20                \ [0x14] PRIV2BB20
    $15 constant FLASH_PRIV2BB21                \ [0x15] PRIV2BB21
    $16 constant FLASH_PRIV2BB22                \ [0x16] PRIV2BB22
    $17 constant FLASH_PRIV2BB23                \ [0x17] PRIV2BB23
    $18 constant FLASH_PRIV2BB24                \ [0x18] PRIV2BB24
    $19 constant FLASH_PRIV2BB25                \ [0x19] PRIV2BB25
    $1a constant FLASH_PRIV2BB26                \ [0x1a] PRIV2BB26
    $1b constant FLASH_PRIV2BB27                \ [0x1b] PRIV2BB27
    $1c constant FLASH_PRIV2BB28                \ [0x1c] PRIV2BB28
    $1d constant FLASH_PRIV2BB29                \ [0x1d] PRIV2BB29
    $1e constant FLASH_PRIV2BB30                \ [0x1e] PRIV2BB30
    $1f constant FLASH_PRIV2BB31                \ [0x1f] PRIV2BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV2BBR5_DEF
    \
    \ @brief FLASH privilege block based bank 2 register 5
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV2BB0                 \ [0x00] PRIV2BB0
    $01 constant FLASH_PRIV2BB1                 \ [0x01] PRIV2BB1
    $02 constant FLASH_PRIV2BB2                 \ [0x02] PRIV2BB2
    $03 constant FLASH_PRIV2BB3                 \ [0x03] PRIV2BB3
    $04 constant FLASH_PRIV2BB4                 \ [0x04] PRIV2BB4
    $05 constant FLASH_PRIV2BB5                 \ [0x05] PRIV2BB5
    $06 constant FLASH_PRIV2BB6                 \ [0x06] PRIV2BB6
    $07 constant FLASH_PRIV2BB7                 \ [0x07] PRIV2BB7
    $08 constant FLASH_PRIV2BB8                 \ [0x08] PRIV2BB8
    $09 constant FLASH_PRIV2BB9                 \ [0x09] PRIV2BB9
    $0a constant FLASH_PRIV2BB10                \ [0x0a] PRIV2BB10
    $0b constant FLASH_PRIV2BB11                \ [0x0b] PRIV2BB11
    $0c constant FLASH_PRIV2BB12                \ [0x0c] PRIV2BB12
    $0d constant FLASH_PRIV2BB13                \ [0x0d] PRIV2BB13
    $0e constant FLASH_PRIV2BB14                \ [0x0e] PRIV2BB14
    $0f constant FLASH_PRIV2BB15                \ [0x0f] PRIV2BB15
    $10 constant FLASH_PRIV2BB16                \ [0x10] PRIV2BB16
    $11 constant FLASH_PRIV2BB17                \ [0x11] PRIV2BB17
    $12 constant FLASH_PRIV2BB18                \ [0x12] PRIV2BB18
    $13 constant FLASH_PRIV2BB19                \ [0x13] PRIV2BB19
    $14 constant FLASH_PRIV2BB20                \ [0x14] PRIV2BB20
    $15 constant FLASH_PRIV2BB21                \ [0x15] PRIV2BB21
    $16 constant FLASH_PRIV2BB22                \ [0x16] PRIV2BB22
    $17 constant FLASH_PRIV2BB23                \ [0x17] PRIV2BB23
    $18 constant FLASH_PRIV2BB24                \ [0x18] PRIV2BB24
    $19 constant FLASH_PRIV2BB25                \ [0x19] PRIV2BB25
    $1a constant FLASH_PRIV2BB26                \ [0x1a] PRIV2BB26
    $1b constant FLASH_PRIV2BB27                \ [0x1b] PRIV2BB27
    $1c constant FLASH_PRIV2BB28                \ [0x1c] PRIV2BB28
    $1d constant FLASH_PRIV2BB29                \ [0x1d] PRIV2BB29
    $1e constant FLASH_PRIV2BB30                \ [0x1e] PRIV2BB30
    $1f constant FLASH_PRIV2BB31                \ [0x1f] PRIV2BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV2BBR6_DEF
    \
    \ @brief FLASH privilege block based bank 2 register 6
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV2BB0                 \ [0x00] PRIV2BB0
    $01 constant FLASH_PRIV2BB1                 \ [0x01] PRIV2BB1
    $02 constant FLASH_PRIV2BB2                 \ [0x02] PRIV2BB2
    $03 constant FLASH_PRIV2BB3                 \ [0x03] PRIV2BB3
    $04 constant FLASH_PRIV2BB4                 \ [0x04] PRIV2BB4
    $05 constant FLASH_PRIV2BB5                 \ [0x05] PRIV2BB5
    $06 constant FLASH_PRIV2BB6                 \ [0x06] PRIV2BB6
    $07 constant FLASH_PRIV2BB7                 \ [0x07] PRIV2BB7
    $08 constant FLASH_PRIV2BB8                 \ [0x08] PRIV2BB8
    $09 constant FLASH_PRIV2BB9                 \ [0x09] PRIV2BB9
    $0a constant FLASH_PRIV2BB10                \ [0x0a] PRIV2BB10
    $0b constant FLASH_PRIV2BB11                \ [0x0b] PRIV2BB11
    $0c constant FLASH_PRIV2BB12                \ [0x0c] PRIV2BB12
    $0d constant FLASH_PRIV2BB13                \ [0x0d] PRIV2BB13
    $0e constant FLASH_PRIV2BB14                \ [0x0e] PRIV2BB14
    $0f constant FLASH_PRIV2BB15                \ [0x0f] PRIV2BB15
    $10 constant FLASH_PRIV2BB16                \ [0x10] PRIV2BB16
    $11 constant FLASH_PRIV2BB17                \ [0x11] PRIV2BB17
    $12 constant FLASH_PRIV2BB18                \ [0x12] PRIV2BB18
    $13 constant FLASH_PRIV2BB19                \ [0x13] PRIV2BB19
    $14 constant FLASH_PRIV2BB20                \ [0x14] PRIV2BB20
    $15 constant FLASH_PRIV2BB21                \ [0x15] PRIV2BB21
    $16 constant FLASH_PRIV2BB22                \ [0x16] PRIV2BB22
    $17 constant FLASH_PRIV2BB23                \ [0x17] PRIV2BB23
    $18 constant FLASH_PRIV2BB24                \ [0x18] PRIV2BB24
    $19 constant FLASH_PRIV2BB25                \ [0x19] PRIV2BB25
    $1a constant FLASH_PRIV2BB26                \ [0x1a] PRIV2BB26
    $1b constant FLASH_PRIV2BB27                \ [0x1b] PRIV2BB27
    $1c constant FLASH_PRIV2BB28                \ [0x1c] PRIV2BB28
    $1d constant FLASH_PRIV2BB29                \ [0x1d] PRIV2BB29
    $1e constant FLASH_PRIV2BB30                \ [0x1e] PRIV2BB30
    $1f constant FLASH_PRIV2BB31                \ [0x1f] PRIV2BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV2BBR7_DEF
    \
    \ @brief FLASH privilege block based bank 2 register 7
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV2BB0                 \ [0x00] PRIV2BB0
    $01 constant FLASH_PRIV2BB1                 \ [0x01] PRIV2BB1
    $02 constant FLASH_PRIV2BB2                 \ [0x02] PRIV2BB2
    $03 constant FLASH_PRIV2BB3                 \ [0x03] PRIV2BB3
    $04 constant FLASH_PRIV2BB4                 \ [0x04] PRIV2BB4
    $05 constant FLASH_PRIV2BB5                 \ [0x05] PRIV2BB5
    $06 constant FLASH_PRIV2BB6                 \ [0x06] PRIV2BB6
    $07 constant FLASH_PRIV2BB7                 \ [0x07] PRIV2BB7
    $08 constant FLASH_PRIV2BB8                 \ [0x08] PRIV2BB8
    $09 constant FLASH_PRIV2BB9                 \ [0x09] PRIV2BB9
    $0a constant FLASH_PRIV2BB10                \ [0x0a] PRIV2BB10
    $0b constant FLASH_PRIV2BB11                \ [0x0b] PRIV2BB11
    $0c constant FLASH_PRIV2BB12                \ [0x0c] PRIV2BB12
    $0d constant FLASH_PRIV2BB13                \ [0x0d] PRIV2BB13
    $0e constant FLASH_PRIV2BB14                \ [0x0e] PRIV2BB14
    $0f constant FLASH_PRIV2BB15                \ [0x0f] PRIV2BB15
    $10 constant FLASH_PRIV2BB16                \ [0x10] PRIV2BB16
    $11 constant FLASH_PRIV2BB17                \ [0x11] PRIV2BB17
    $12 constant FLASH_PRIV2BB18                \ [0x12] PRIV2BB18
    $13 constant FLASH_PRIV2BB19                \ [0x13] PRIV2BB19
    $14 constant FLASH_PRIV2BB20                \ [0x14] PRIV2BB20
    $15 constant FLASH_PRIV2BB21                \ [0x15] PRIV2BB21
    $16 constant FLASH_PRIV2BB22                \ [0x16] PRIV2BB22
    $17 constant FLASH_PRIV2BB23                \ [0x17] PRIV2BB23
    $18 constant FLASH_PRIV2BB24                \ [0x18] PRIV2BB24
    $19 constant FLASH_PRIV2BB25                \ [0x19] PRIV2BB25
    $1a constant FLASH_PRIV2BB26                \ [0x1a] PRIV2BB26
    $1b constant FLASH_PRIV2BB27                \ [0x1b] PRIV2BB27
    $1c constant FLASH_PRIV2BB28                \ [0x1c] PRIV2BB28
    $1d constant FLASH_PRIV2BB29                \ [0x1d] PRIV2BB29
    $1e constant FLASH_PRIV2BB30                \ [0x1e] PRIV2BB30
    $1f constant FLASH_PRIV2BB31                \ [0x1f] PRIV2BB31
  [then]


  [ifdef] FLASH_FLASH_PRIV2BBR8_DEF
    \
    \ @brief FLASH privilege block based bank 2 register 8
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV2BB0                 \ [0x00] PRIV2BB0
    $01 constant FLASH_PRIV2BB1                 \ [0x01] PRIV2BB1
    $02 constant FLASH_PRIV2BB2                 \ [0x02] PRIV2BB2
    $03 constant FLASH_PRIV2BB3                 \ [0x03] PRIV2BB3
    $04 constant FLASH_PRIV2BB4                 \ [0x04] PRIV2BB4
    $05 constant FLASH_PRIV2BB5                 \ [0x05] PRIV2BB5
    $06 constant FLASH_PRIV2BB6                 \ [0x06] PRIV2BB6
    $07 constant FLASH_PRIV2BB7                 \ [0x07] PRIV2BB7
    $08 constant FLASH_PRIV2BB8                 \ [0x08] PRIV2BB8
    $09 constant FLASH_PRIV2BB9                 \ [0x09] PRIV2BB9
    $0a constant FLASH_PRIV2BB10                \ [0x0a] PRIV2BB10
    $0b constant FLASH_PRIV2BB11                \ [0x0b] PRIV2BB11
    $0c constant FLASH_PRIV2BB12                \ [0x0c] PRIV2BB12
    $0d constant FLASH_PRIV2BB13                \ [0x0d] PRIV2BB13
    $0e constant FLASH_PRIV2BB14                \ [0x0e] PRIV2BB14
    $0f constant FLASH_PRIV2BB15                \ [0x0f] PRIV2BB15
    $10 constant FLASH_PRIV2BB16                \ [0x10] PRIV2BB16
    $11 constant FLASH_PRIV2BB17                \ [0x11] PRIV2BB17
    $12 constant FLASH_PRIV2BB18                \ [0x12] PRIV2BB18
    $13 constant FLASH_PRIV2BB19                \ [0x13] PRIV2BB19
    $14 constant FLASH_PRIV2BB20                \ [0x14] PRIV2BB20
    $15 constant FLASH_PRIV2BB21                \ [0x15] PRIV2BB21
    $16 constant FLASH_PRIV2BB22                \ [0x16] PRIV2BB22
    $17 constant FLASH_PRIV2BB23                \ [0x17] PRIV2BB23
    $18 constant FLASH_PRIV2BB24                \ [0x18] PRIV2BB24
    $19 constant FLASH_PRIV2BB25                \ [0x19] PRIV2BB25
    $1a constant FLASH_PRIV2BB26                \ [0x1a] PRIV2BB26
    $1b constant FLASH_PRIV2BB27                \ [0x1b] PRIV2BB27
    $1c constant FLASH_PRIV2BB28                \ [0x1c] PRIV2BB28
    $1d constant FLASH_PRIV2BB29                \ [0x1d] PRIV2BB29
    $1e constant FLASH_PRIV2BB30                \ [0x1e] PRIV2BB30
    $1f constant FLASH_PRIV2BB31                \ [0x1f] PRIV2BB31
  [then]

  \
  \ @brief Flash
  \
  $00 constant FLASH_FLASH_ACR          \ FLASH access control register
  $08 constant FLASH_FLASH_NSKEYR       \ FLASH non-secure key register
  $0C constant FLASH_FLASH_SECKEYR      \ FLASH secure key register
  $10 constant FLASH_FLASH_OPTKEYR      \ FLASH option key register
  $18 constant FLASH_FLASH_PDKEY1R      \ FLASH bank 1 power-down key register
  $1C constant FLASH_FLASH_PDKEY2R      \ FLASH bank 2 power-down key register
  $20 constant FLASH_FLASH_NSSR         \ FLASH non-secure status register
  $24 constant FLASH_FLASH_SECSR        \ FLASH secure status register
  $28 constant FLASH_FLASH_NSCR         \ FLASH non-secure control register
  $2C constant FLASH_FLASH_SECCR        \ FLASH secure control register
  $30 constant FLASH_FLASH_ECCR         \ FLASH ECC register
  $34 constant FLASH_FLASH_OPSR         \ FLASH operation status register
  $40 constant FLASH_FLASH_OPTR         \ FLASH option register
  $44 constant FLASH_FLASH_NSBOOTADD0R  \ FLASH non-secure boot address 0 register
  $48 constant FLASH_FLASH_NSBOOTADD1R  \ FLASH non-secure boot address 1 register
  $4C constant FLASH_FLASH_SECBOOTADD0R \ FLASH secure boot address 0 register
  $50 constant FLASH_FLASH_SECWM1R1     \ FLASH secure watermark1 register 1
  $54 constant FLASH_FLASH_SECWM1R2     \ FLASH secure watermark1 register 2
  $58 constant FLASH_FLASH_WRP1AR       \ FLASH WRP1 area A address register
  $5C constant FLASH_FLASH_WRP1BR       \ FLASH WRP1 area B address register
  $60 constant FLASH_FLASH_SECWM2R1     \ FLASH secure watermark2 register 1
  $64 constant FLASH_FLASH_SECWM2R2     \ FLASH secure watermark2 register 2
  $68 constant FLASH_FLASH_WRP2AR       \ FLASH WPR2 area A address register
  $6C constant FLASH_FLASH_WRP2BR       \ FLASH WPR2 area B address register
  $70 constant FLASH_FLASH_OEM1KEYR1    \ FLASH OEM1 key register 1
  $74 constant FLASH_FLASH_OEM1KEYR2    \ FLASH OEM1 key register 2
  $78 constant FLASH_FLASH_OEM2KEYR1    \ FLASH OEM2 key register 1
  $7C constant FLASH_FLASH_OEM2KEYR2    \ FLASH OEM2 key register 2
  $80 constant FLASH_FLASH_SEC1BBR1     \ FLASH secure block based bank 1 register 1
  $84 constant FLASH_FLASH_SEC1BBR2     \ FLASH secure block based bank 1 register 2
  $88 constant FLASH_FLASH_SEC1BBR3     \ FLASH secure block based bank 1 register 3
  $8C constant FLASH_FLASH_SEC1BBR4     \ FLASH secure block based bank 1 register 4
  $90 constant FLASH_FLASH_SEC1BBR5     \ FLASH secure block based bank 1 register 5
  $94 constant FLASH_FLASH_SEC1BBR6     \ FLASH secure block based bank 1 register 6
  $98 constant FLASH_FLASH_SEC1BBR7     \ FLASH secure block based bank 1 register 7
  $9C constant FLASH_FLASH_SEC1BBR8     \ FLASH secure block based bank 1 register 8
  $A0 constant FLASH_FLASH_SEC2BBR1     \ FLASH secure block based bank 2 register 1
  $A4 constant FLASH_FLASH_SEC2BBR2     \ FLASH secure block based bank 2 register 2
  $A8 constant FLASH_FLASH_SEC2BBR3     \ FLASH secure block based bank 2 register 3
  $AC constant FLASH_FLASH_SEC2BBR4     \ FLASH secure block based bank 2 register 4
  $B0 constant FLASH_FLASH_SEC2BBR5     \ FLASH secure block based bank 2 register 5
  $B4 constant FLASH_FLASH_SEC2BBR6     \ FLASH secure block based bank 2 register 6
  $B8 constant FLASH_FLASH_SEC2BBR7     \ FLASH secure block based bank 2 register 7
  $BC constant FLASH_FLASH_SEC2BBR8     \ FLASH secure block based bank 2 register 8
  $C0 constant FLASH_FLASH_SECHDPCR     \ FLASH secure HDP control register
  $C4 constant FLASH_FLASH_PRIVCFGR     \ FLASH privilege configuration register
  $D0 constant FLASH_FLASH_PRIV1BBR1    \ FLASH privilege block based bank 1 register 1
  $D4 constant FLASH_FLASH_PRIV1BBR2    \ FLASH privilege block based bank 1 register 2
  $D8 constant FLASH_FLASH_PRIV1BBR3    \ FLASH privilege block based bank 1 register 3
  $DC constant FLASH_FLASH_PRIV1BBR4    \ FLASH privilege block based bank 1 register 4
  $E0 constant FLASH_FLASH_PRIV1BBR5    \ FLASH privilege block based bank 1 register 5
  $E4 constant FLASH_FLASH_PRIV1BBR6    \ FLASH privilege block based bank 1 register 6
  $E8 constant FLASH_FLASH_PRIV1BBR7    \ FLASH privilege block based bank 1 register 7
  $EC constant FLASH_FLASH_PRIV1BBR8    \ FLASH privilege block based bank 1 register 8
  $F0 constant FLASH_FLASH_PRIV2BBR1    \ FLASH privilege block based bank 2 register 1
  $F4 constant FLASH_FLASH_PRIV2BBR2    \ FLASH privilege block based bank 2 register 2
  $F8 constant FLASH_FLASH_PRIV2BBR3    \ FLASH privilege block based bank 2 register 3
  $FC constant FLASH_FLASH_PRIV2BBR4    \ FLASH privilege block based bank 2 register 4
  $100 constant FLASH_FLASH_PRIV2BBR5   \ FLASH privilege block based bank 2 register 5
  $104 constant FLASH_FLASH_PRIV2BBR6   \ FLASH privilege block based bank 2 register 6
  $108 constant FLASH_FLASH_PRIV2BBR7   \ FLASH privilege block based bank 2 register 7
  $10C constant FLASH_FLASH_PRIV2BBR8   \ FLASH privilege block based bank 2 register 8

: FLASH_DEF ; [then]
