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
    \ @brief Access control register
    \ Address offset: 0x00
    \ Reset value: 0x00000013
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 4] Read latency
    $04 constant FLASH_WRHIGHFREQ               \ [0x04 : 2] Flash signal delay
  [then]


  [ifdef] FLASH_FLASH_KEYR1_DEF
    \
    \ @brief FLASH key register for bank 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_KEY1R                    \ [0x00 : 32] Non-volatile memory bank 1 configuration access unlock key
  [then]


  [ifdef] FLASH_FLASH_OPTKEYR_DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEYR                  \ [0x00 : 32] Unlock key option bytes
  [then]


  [ifdef] FLASH_FLASH_CR1_DEF
    \
    \ @brief Bank 1 configuration lock bit This bit locks the FLASH_CR1 register. The correct write sequence to FLASH_KEYR1 register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_KEYR1 is performed twice, this bit remains locked until the next system reset. LOCK1 can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK1 changes from 0 to 1, the other bits of FLASH_CR1 register do not change.
    \ Address offset: 0x0C
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_LOCK1                    \ [0x00] Bank 1 configuration lock bit This bit locks the FLASH_CR1 register. The correct write sequence to FLASH_KEYR1 register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_KEYR1 is performed twice, this bit remains locked until the next system reset. LOCK1 can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK1 changes from 0 to 1, the other bits of FLASH_CR1 register do not change.
    $01 constant FLASH_PG1                      \ [0x01] Bank 1 internal buffer control bit Setting PG1 bit to 1 enables internal buffer for write operations to bank 1. This allows preparing program operations even if a sector or bank erase is ongoing. PG1 can be programmed only when LOCK1 is cleared to 0. When PG1 is reset, the internal buffer is disabled for write operations to bank 1, and all the data stored in the buffer but not sent to the operation queue are lost.
    $02 constant FLASH_SER1                     \ [0x02] Bank 1 sector erase request Setting SER1 bit to 1 requests a sector erase on bank 1. SER1 can be programmed only when LOCK1 is cleared to 0. BER1 has a higher priority than SER1: if both bits are set, the embedded Flash memory executes a bank erase. Note: Write protection error is triggered when a sector erase is required on a protected sector.
    $03 constant FLASH_BER1                     \ [0x03] Bank 1 erase request Setting BER1 bit to 1 requests a bank erase operation on bank 1 (user Flash memory only). BER1 can be programmed only when LOCK1 is cleared to 0. BER1 has a higher priority than SER1: if both are set, the embedded Flash memory executes a bank erase. Note: Write protection error is triggered when a bank erase is required and some sectors are protected.
    $04 constant FLASH_FW1                      \ [0x04] Bank 1 write forcing control bit FW1 forces a write operation even if the write buffer is not full. In this case all bits not written are set to 1 by hardware. FW1 can be programmed only when LOCK1 is cleared to 0. The embedded Flash memory resets FW1 when the corresponding operation has been acknowledged. Note: Using a force-write operation prevents the application from updating later the missing bits with something else than 1, because it is likely that it will lead to permanent ECC error. Write forcing is effective only if the write buffer is not empty (in particular, FW1 does not start several write operations when the force-write operations are performed consecutively).
    $05 constant FLASH_START1                   \ [0x05] Bank 1 erase start control bit START1 bit is used to start a sector erase or a bank erase operation. START1 can be programmed only when LOCK1 is cleared to 0. The embedded Flash memory resets START1 when the corresponding operation has been acknowledged. The user application cannot access any embedded Flash memory register until the operation is acknowledged.
    $06 constant FLASH_SSN1                     \ [0x06 : 7] Bank 1 sector erase selection number These bits are used to select the target sector for an erase operation (they are unused otherwise). SSN1 can be programmed only when LOCK1 is cleared to 0. .. ... ... Note: Bank 1 is limited to 16 and 64 sectors on STM32H7B0 and STM32H7A3xG devices, respectively.
    $0f constant FLASH_CRC_EN                   \ [0x0f] Bank 1 CRC control bit Setting CRC_EN bit to 1 enables the CRC calculation on bank 1. CRC_EN does not start CRC calculation but enables CRC configuration through FLASH_CRCCR1 register. When CRC calculation is performed on bank 1, it can only be disabled by setting CRC_EN bit to 0. Resetting CRC_EN clears CRC configuration and resets the content of FLASH_CRCDATAR register. Clearing CRC_EN to 0 sets CRCDATA to 0x0. CRC_EN can be programmed only when LOCK1 is cleared to 0.
    $10 constant FLASH_EOPIE1                   \ [0x10] Bank 1 end-of-program interrupt control bit Setting EOPIE1 bit to 1 enables the generation of an interrupt at the end of a program operation to bank 1. EOPIE1 can be programmed only when LOCK1 is cleared to 0.
    $11 constant FLASH_WRPERRIE1                \ [0x11] Bank 1 write protection error interrupt enable bit When WRPERRIE1 bit is set to 1, an interrupt is generated when a protection error occurs during a program operation to bank 1. WRPERRIE1 can be programmed only when LOCK1 is cleared to 0.
    $12 constant FLASH_PGSERRIE1                \ [0x12] Bank 1 programming sequence error interrupt enable bit When PGSERRIE1 bit is set to 1, an interrupt is generated when a sequence error occurs during a program operation to bank 1. PGSERRIE1 can be programmed only when LOCK1 is cleared to 0.
    $13 constant FLASH_STRBERRIE1               \ [0x13] Bank 1 strobe error interrupt enable bit When STRBERRIE1 bit is set to 1, an interrupt is generated when a strobe error occurs (the master programs several times the same byte in the write buffer) during a write operation to bank 1. STRBERRIE1 can be programmed only when LOCK1 is cleared to 0.
    $15 constant FLASH_INCERRIE1                \ [0x15] Bank 1 inconsistency error interrupt enable bit When INCERRIE1 bit is set to 1, an interrupt is generated when an inconsistency error occurs during a write operation to bank 1. INCERRIE1 can be programmed only when LOCK1 is cleared to 0.
    $17 constant FLASH_RDPERRIE1                \ [0x17] Bank 1 read protection error interrupt enable bit When RDPERRIE1 bit is set to 1, an interrupt is generated when a read protection error occurs (access to an address protected by PCROP or by RDP level 1) during a read operation from bank 1. RDPERRIE1 can be programmed only when LOCK1 is cleared to 0.
    $18 constant FLASH_RDSERRIE1                \ [0x18] Bank 1 secure error interrupt enable bit When RDSERRIE1 bit is set to 1, an interrupt is generated when a secure error (access to a secure-only protected address) occurs during a read operation from bank 1. RDSERRIE1 can be programmed only when LOCK1 is cleared to 0.
    $19 constant FLASH_SNECCERRIE1              \ [0x19] Bank 1 ECC single correction error interrupt enable bit When SNECCERRIE1 bit is set to 1, an interrupt is generated when an ECC single correction error occurs during a read operation from bank 1. SNECCERRIE1 can be programmed only when LOCK1 is cleared to 0.
    $1a constant FLASH_DBECCERRIE1              \ [0x1a] Bank 1 ECC double detection error interrupt enable bit When DBECCERRIE1 bit is set to 1, an interrupt is generated when an ECC double detection error occurs during a read operation from bank 1. DBECCERRIE1 can be programmed only when LOCK1 is cleared to 0.
    $1b constant FLASH_CRCENDIE1                \ [0x1b] Bank 1 CRC end of calculation interrupt enable bit When CRCENDIE1 bit is set to 1, an interrupt is generated when the CRC computation has completed on bank 1. CRCENDIE1 can be programmed only when LOCK1 is cleared to 0.
    $1c constant FLASH_CRCRDERRIE1              \ [0x1c] Bank 1 CRC read error interrupt enable bit When CRCRDERRIE1 bit is set to 1, an interrupt is generated when a protected area (PCROP or secure-only) has been detected during the last CRC computation on bank 1. CRCRDERRIE1 can be programmed only when LOCK1 is cleared to 0.
  [then]


  [ifdef] FLASH_FLASH_SR1_DEF
    \
    \ @brief Bank 1 busy flag BSY1 flag is set when an effective write, erase or option byte change operation is ongoing on bank 1. It is not possible to know what type of operation is being executed. BSY1 cannot be forced to 0. It is automatically reset by hardware every time a step in a write, erase or option byte change operation completes.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY1                     \ [0x00] Bank 1 busy flag BSY1 flag is set when an effective write, erase or option byte change operation is ongoing on bank 1. It is not possible to know what type of operation is being executed. BSY1 cannot be forced to 0. It is automatically reset by hardware every time a step in a write, erase or option byte change operation completes.
    $01 constant FLASH_WBNE1                    \ [0x01] Bank 1 write buffer not empty flag WBNE1 flag is set when the embedded Flash memory is waiting for new data to complete the write buffer. In this state, the write buffer is not empty. WBNE1 is reset by hardware each time the write buffer is complete or the write buffer is emptied following one of the event below: the application software forces the write operation using FW1 bit in FLASH_CR1 the embedded Flash memory detects an error that involves data loss the application software has disabled write operations in this bank This bit cannot be forced to 0. To reset it, clear the write buffer by performing any of the above listed actions, or send the missing data.
    $02 constant FLASH_QW1                      \ [0x02] Bank 1 wait queue flag QW1 flag is set when a write, erase or option byte change operation is pending in the command queue buffer of bank 1. It is not possible to know what type of programming operation is present in the queue. This flag is reset by hardware when all write, erase or option byte change operations have been executed and thus removed from the waiting queue(s). This bit cannot be forced to 0. It is reset after a deterministic time if no other operations are requested.
    $03 constant FLASH_CRC_BUSY1                \ [0x03] Bank 1 CRC busy flag CRC_BUSY1 flag is set when a CRC calculation is ongoing on bank 1. This bit cannot be forced to 0. The user must wait until the CRC calculation has completed or disable CRC computation on bank 1.
    $10 constant FLASH_EOP1                     \ [0x10] Bank 1 end-of-program flag EOP1 flag is set when a programming operation to bank 1 completes. An interrupt is generated if the EOPIE1 is set to 1. It is not necessary to reset EOP1 before starting a new operation. EOP1 bit is cleared by writing 1 to CLR_EOP1 bit in FLASH_CCR1 register.
    $11 constant FLASH_WRPERR1                  \ [0x11] Bank 1 write protection error flag WRPERR1 flag is raised when a protection error occurs during a program operation to bank 1. An interrupt is also generated if the WRPERRIE1 is set to 1. Writing 1 to CLR_WRPERR1 bit in FLASH_CCR1 register clears WRPERR1.
    $12 constant FLASH_PGSERR1                  \ [0x12] Bank 1 programming sequence error flag PGSERR1 flag is raised when a sequence error occurs on bank 1. An interrupt is generated if the PGSERRIE1 bit is set to 1. Writing 1 to CLR_PGSERR1 bit in FLASH_CCR1 register clears PGSERR1.
    $13 constant FLASH_STRBERR1                 \ [0x13] Bank 1 strobe error flag STRBERR1 flag is raised when a strobe error occurs on bank 1 (when the master attempts to write several times the same byte in the write buffer). An interrupt is generated if the STRBERRIE1 bit is set to 1. Writing 1 to CLR_STRBERR1 bit in FLASH_CCR1 register clears STRBERR1.
    $15 constant FLASH_INCERR1                  \ [0x15] Bank 1 inconsistency error flag INCERR1 flag is raised when a inconsistency error occurs on bank 1. An interrupt is generated if INCERRIE1 is set to 1. Writing 1 to CLR_INCERR1 bit in the FLASH_CCR1 register clears INCERR1.
    $17 constant FLASH_RDPERR1                  \ [0x17] Bank 1 read protection error flag RDPERR1 flag is raised when an read protection error (read access to a PCROP-protected or a RDP-protected area) occurs on bank 1. An interrupt is generated if RDPERRIE1 is set to 1. Writing 1 to CLR_RDPERR1 bit in FLASH_CCR1 register clears RDPERR1.
    $18 constant FLASH_RDSERR1                  \ [0x18] Bank 1 secure error flag RDSERR1 flag is raised when a read secure error (read access to a secure-only protected word) occurs on bank 1. An interrupt is generated if RDSERRIE1 is set to 1. Writing 1 to CLR_RDSERR1 bit in FLASH_CCR1 register clears RDSERR1.
    $19 constant FLASH_SNECCERR1                \ [0x19] Bank 1 single correction error flag SNECCERR1 flag is raised when an ECC single correction error occurs during a read operation from bank 1. An interrupt is generated if SNECCERRIE1 is set to 1. Writing 1 to CLR_SNECCERR1 bit in FLASH_CCR1 register clears SNECCERR1.
    $1a constant FLASH_DBECCERR1                \ [0x1a] Bank 1 ECC double detection error flag DBECCERR1 flag is raised when an ECC double detection error occurs during a read operation from bank 1. An interrupt is generated if DBECCERRIE1 is set to 1. Writing 1 to CLR_DBECCERR1 bit in FLASH_CCR1 register clears DBECCERR1.
    $1b constant FLASH_CRCEND1                  \ [0x1b] Bank 1 CRC end of calculation flag CRCEND1 bit is raised when the CRC computation has completed on bank 1. An interrupt is generated if CRCENDIE1 is set to 1. It is not necessary to reset CRCEND1 before restarting CRC computation. Writing 1 to CLR_CRCEND1 bit in FLASH_CCR1 register clears CRCEND1.
    $1c constant FLASH_CRCRDERR1                \ [0x1c] Bank 1 CRC read error flag CRCRDERR1 flag is raised when a word is found read protected during a CRC operation on bank 1. An interrupt is generated if CRCRDIE1 and CRCEND1 are set to 1. Writing 1 to CLR_CRCRDERR1 bit in FLASH_CCR1 register clears CRCRDERR1. Note: This flag is valid only when CRCEND1 bit is set to 1
  [then]


  [ifdef] FLASH_FLASH_CCR1_DEF
    \
    \ @brief Bank 1 EOP1 flag clear bit Setting this bit to 1 resets to 0 EOP1 flag in FLASH_SR1 register.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $10 constant FLASH_CLR_EOP1                 \ [0x10] Bank 1 EOP1 flag clear bit Setting this bit to 1 resets to 0 EOP1 flag in FLASH_SR1 register.
    $11 constant FLASH_CLR_WRPERR1              \ [0x11] Bank 1 WRPERR1 flag clear bit Setting this bit to 1 resets to 0 WRPERR1 flag in FLASH_SR1 register.
    $12 constant FLASH_CLR_PGSERR1              \ [0x12] Bank 1 PGSERR1 flag clear bit Setting this bit to 1 resets to 0 PGSERR1 flag in FLASH_SR1 register.
    $13 constant FLASH_CLR_STRBERR1             \ [0x13] Bank 1 STRBERR1 flag clear bit Setting this bit to 1 resets to 0 STRBERR1 flag in FLASH_SR1 register.
    $15 constant FLASH_CLR_INCERR1              \ [0x15] Bank 1 INCERR1 flag clear bit Setting this bit to 1 resets to 0 INCERR1 flag in FLASH_SR1 register.
    $17 constant FLASH_CLR_RDPERR1              \ [0x17] Bank 1 RDPERR1 flag clear bit Setting this bit to 1 resets to 0 RDPERR1 flag in FLASH_SR1 register.
    $18 constant FLASH_CLR_RDSERR1              \ [0x18] Bank 1 RDSERR1 flag clear bit Setting this bit to 1 resets to 0 RDSERR1 flag in FLASH_SR1 register.
    $19 constant FLASH_CLR_SNECCERR1            \ [0x19] Bank 1 SNECCERR1 flag clear bit Setting this bit to 1 resets to 0 SNECCERR1 flag in FLASH_SR1 register. If the DBECCERR1 flag of FLASH_SR1 register is cleared to 0, FLASH_ECC_FA1R register is reset to 0 as well.
    $1a constant FLASH_CLR_DBECCERR1            \ [0x1a] Bank 1 DBECCERR1 flag clear bit Setting this bit to 1 resets to 0 DBECCERR1 flag in FLASH_SR1 register. If the SNECCERR1 flag of FLASH_SR1 register is cleared to 0, FLASH_ECC_FA1R register is reset to 0 as well.
    $1b constant FLASH_CLR_CRCEND1              \ [0x1b] Bank 1 CRCEND1 flag clear bit Setting this bit to 1 resets to 0 CRCEND1 flag in FLASH_SR1 register.
    $1c constant FLASH_CLR_CRCRDERR1            \ [0x1c] Bank 1 CRCRDERR1 flag clear bit Setting this bit to 1 resets to 0 CRCRDERR1 flag in FLASH_SR1 register.
  [then]


  [ifdef] FLASH_FLASH_OPTCR_DEF
    \
    \ @brief FLASH option control register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_OPTLOCK                  \ [0x00] FLASH_OPTCR lock option configuration bit
    $01 constant FLASH_OPTSTART                 \ [0x01] Option byte start change option configuration bit
    $04 constant FLASH_MER                      \ [0x04] Flash mass erase enable bit
    $05 constant FLASH_PG_OTP                   \ [0x05] OTP program control bit
    $1e constant FLASH_OPTCHANGEERRIE           \ [0x1e] Option byte change error interrupt enable bit
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping configuration bit
  [then]


  [ifdef] FLASH_FLASH_OPTSR_CUR_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPT_BUSY                 \ [0x00] Option byte change ongoing flag
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] Brownout level option status bit
    $04 constant FLASH_IWDG_SW                  \ [0x04] IWDG1 control option status bit
    $06 constant FLASH_NRST_STOP                \ [0x06] D1 DStop entry reset option status bit
    $07 constant FLASH_NRST_STDY                \ [0x07] D1 DStandby entry reset option status bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option status byte
    $10 constant FLASH_VDDMMC_HSLV              \ [0x10] IWDG Stop mode freeze option status bit
    $11 constant FLASH_WDG_FZ_STOP              \ [0x11] IWDG Stop mode freeze option status bit
    $12 constant FLASH_IWDG_FZ_SDBY             \ [0x12] IWDG Standby mode freeze option status bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM RAM size option status
    $15 constant FLASH_SECURITY                 \ [0x15] Security enable option status bit
    $1d constant FLASH_VDDIO_HSLV               \ [0x1d] I/O high-speed at low-voltage status bit (PRODUCT_BELOW_25V)
    $1e constant FLASH_OPTCHANGEERR             \ [0x1e] Option byte change error flag
    $1f constant FLASH_SWAP_BANK_OPT            \ [0x1f] Bank swapping option status bit
  [then]


  [ifdef] FLASH_FLASH_OPTSR_PRG_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] BOR reset level option configuration bits
    $04 constant FLASH_IWDG_SW                  \ [0x04] IWDG1 option configuration bit
    $06 constant FLASH_NRST_STOP                \ [0x06] Option byte erase after D1 DStop option configuration bit
    $07 constant FLASH_NRST_STDY                \ [0x07] Option byte erase after D1 DStandby option configuration bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option configuration byte
    $10 constant FLASH_VDDMMC_HSLV              \ [0x10] VDDMMC_HSLV
    $11 constant FLASH_WDG_FZ_STOP              \ [0x11] IWDG Stop mode freeze option configuration bit
    $12 constant FLASH_IWDG_FZ_SDBY             \ [0x12] IWDG Standby mode freeze option configuration bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM size select option configuration bits
    $15 constant FLASH_SECURITY                 \ [0x15] Security option configuration bit
    $1d constant FLASH_VDDIO_HSLV               \ [0x1d] VDDIO_HSLV
    $1f constant FLASH_SWAP_BANK_OPT            \ [0x1f] Bank swapping option configuration bit
  [then]


  [ifdef] FLASH_FLASH_OPTCCR_DEF
    \
    \ @brief FLASH option clear control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $1e constant FLASH_CLR_OPTCHANGEERR         \ [0x1e] OPTCHANGEERR reset bit
  [then]


  [ifdef] FLASH_FLASH_PRAR_CUR1_DEF
    \
    \ @brief FLASH protection address for bank 1
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START1         \ [0x00 : 12] Bank 1 PCROP area start status bits These bits contain the first 256-byte block of the PCROP area in bank 1. If this address is equal to PROT_AREA_END1, the whole bank 1 is PCROP protected. If this address is higher than PROT_AREA_END1, no protection is set on bank 1.
    $10 constant FLASH_PROT_AREA_END1           \ [0x10 : 12] Bank 1 PCROP area end status bits These bits contain the last 256-byte block of the PCROP area in bank 1. If this address is equal to PROT_AREA_START1, the whole bank 1 is PCROP protected. If this address is lower than PROT_AREA_START1, no protection is set on bank 1.
    $1f constant FLASH_DMEP1                    \ [0x1f] Bank 1 PCROP protected erase enable option status bit If DMEP1 is set to 1, the PCROP protected area in bank 1 is erased when a protection level regression (change from level 1 to 0) or a bank erase with protection removal occurs.
  [then]


  [ifdef] FLASH_FLASH_PRAR_PRG1_DEF
    \
    \ @brief FLASH protection address for bank 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START1         \ [0x00 : 12] Bank 1 PCROP area start configuration bits These bits contain the first 256-byte block of the PCROP area in bank 1. If this address is equal to PROT_AREA_END1, the whole bank 1 is PCROP protected. If this address is higher than PROT_AREA_END1, no protection is set on bank 1.
    $10 constant FLASH_PROT_AREA_END1           \ [0x10 : 12] Bank 1 PCROP area end configuration bits These bits contain the last 256-byte block of the PCROP area in bank 1. If this address is equal to PROT_AREA_START1, the whole bank 1 is PCROP protected. If this address is lower than PROT_AREA_START1, no protection is set on bank 1.
    $1f constant FLASH_DMEP1                    \ [0x1f] Bank 1 PCROP protected erase enable option configuration bit If DMEP1 is set to 1, the PCROP protected area in bank 1 is erased when a protection level regression (change from level 1 to 0) or a bank erase with protection removal occurs.
  [then]


  [ifdef] FLASH_FLASH_SCAR_CUR1_DEF
    \
    \ @brief FLASH secure address for bank 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START1          \ [0x00 : 12] Bank 1 secure-only area start status bits These bits contain the first 256 bytes of block of the secure-only area in bank 1. If this address is equal to SEC_AREA_END1, the whole bank 1 is secure access only. If this address is higher than SEC_AREA_END1, no protection is set on bank 1.
    $10 constant FLASH_SEC_AREA_END1            \ [0x10 : 12] Bank 1 secure-only area end status bits These bits contain the last 256-byte block of the secure-only area in bank 1. If this address is equal to SEC_AREA_START1, the whole bank 1 is secure access only. If this address is lower than SEC_AREA_START1, no protection is set on bank 1.
    $1f constant FLASH_DMES1                    \ [0x1f] Bank 1 secure access protected erase enable option status bit If DMES1 is set to 1, the secure access only area in bank 1 is erased when a protection level regression (change from level 1 to 0) or a bank erase with protection removal occurs.
  [then]


  [ifdef] FLASH_FLASH_SCAR_PRG1_DEF
    \
    \ @brief FLASH secure address for bank 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START1          \ [0x00 : 12] Bank 1 secure-only area start configuration bits These bits contain the first block of 256 bytes of the secure-only area in bank 1. If this address is equal to SEC_AREA_END1, the whole bank 1 is secure access only. If this address is higher than SEC_AREA_END1, no protection is set on bank 1.
    $10 constant FLASH_SEC_AREA_END1            \ [0x10 : 12] Bank 1 secure-only area end configuration bits These bits contain the last block of 256 bytes of the secure-only area in bank 1. If this address is equal to SEC_AREA_START1, the whole bank 1 is secure access only. If this address is lower than SEC_AREA_START1, no protection is set on bank 1.
    $1f constant FLASH_DMES1                    \ [0x1f] Bank 1 secure access protected erase enable option configuration bit If DMES1 is set to 1, the secure access only area in bank 1 is erased when a protection level regression (change from level 1 to 0) or a bank erase with protection removal occurs.
  [then]


  [ifdef] FLASH_FLASH_WPSGN_CUR1R_DEF
    \
    \ @brief FLASH write sector group protection for bank 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSGn1                  \ [0x00 : 32] Bank 1 sector group protection option status byte Each FLASH_WPSGN_CUR1R bit reflects the write protection status of the corresponding group of four consecutive sectors in bank 1 (0: the group is write protected; 1: the group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127 Note: Bank 1 is limited to 16 and 64 sectors on STM32H7B0 and STM32H7A3xG devices, respectively.
  [then]


  [ifdef] FLASH_FLASH_WPSGN_PRG1R_DEF
    \
    \ @brief FLASH write sector group protection for bank 1
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSGn1                  \ [0x00 : 32] Bank 1 sector group protection option status byte Setting WRPSGn1 bits to 0 write protects the corresponding group of four consecutive sectors in bank 1 (0: the group is write protected; 1: the group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127 Note: Bank 1 is limited to 16 and 64 sectors on STM32H7B0 and STM32H7A3xG devices, respectively.
  [then]


  [ifdef] FLASH_FLASH_BOOT_CURR_DEF
    \
    \ @brief FLASH register with boot address
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_ADD0                \ [0x00 : 16] Boot address 0
    $10 constant FLASH_BOOT_ADD1                \ [0x10 : 16] Boot address 1
  [then]


  [ifdef] FLASH_FLASH_BOOT_PRGR_DEF
    \
    \ @brief FLASH register with boot address
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_ADD0                \ [0x00 : 16] Boot address 0
    $10 constant FLASH_BOOT_ADD1                \ [0x10 : 16] Boot address 1
  [then]


  [ifdef] FLASH_FLASH_CRCCR1_DEF
    \
    \ @brief FLASH CRC control register for bank 1
    \ Address offset: 0x50
    \ Reset value: 0x001C0000
    \
    $00 constant FLASH_CRC_SECT                 \ [0x00 : 7] Bank 1 CRC sector number CRC_SECT is used to select one user Flash sectors to be added to the list of sectors on which the CRC is calculated. The CRC can be computed either between two addresses (using registers FLASH_CRCSADD1R and FLASH_CRCEADD1R) or on a list of sectors using this register. If this latter option is selected, it is possible to add a sector to the list of sectors by programming the sector number in CRC_SECT and then setting to 1 ADD_SECT. The list of sectors can be erased either by setting CLEAN_SECT bit or by disabling the CRC computation. CRC_SECT can be set only when CRC_EN of FLASH_CR register is set to 1. ... ... ... Note: Bank 1 is limited to 16 and 64 sectors on STM32H7B0 and STM32H7AxG devices, respectively.
    $08 constant FLASH_CRC_BY_SECT              \ [0x08] Bank 1 CRC sector mode select bit When CRC_BY_SECT is set to 1, the CRC calculation is performed at sector level, on the sectors present in the list of sectors. To add a sector to this list, use ADD_SECT and CRC_SECT bits. To clean the list, use CLEAN_SECT bit. When CRC_BY_SECT is reset to 0, the CRC calculation is performed on all addresses between CRC_START_ADDR and CRC_END_ADDR.
    $09 constant FLASH_ADD_SECT                 \ [0x09] Bank 1 CRC sector select bit Setting ADD_SECT to 1 adds the sector whose number is CRC_SECT to the list of sectors on which the CRC is calculated.
    $0a constant FLASH_CLEAN_SECT               \ [0x0a] Bank 1 CRC sector list clear bit Setting CLEAN_SECT to 1 clears the list of sectors on which the CRC is calculated.
    $10 constant FLASH_START_CRC                \ [0x10] Bank 1 CRC start bit START_CRC bit triggers a CRC calculation on bank 1 using the current configuration. No CRC calculation can launched when an option byte change operation is ongoing because all write accesses to embedded Flash memory registers are put on hold until the option byte change operation has completed.
    $11 constant FLASH_CLEAN_CRC                \ [0x11] Bank 1 CRC clear bit Setting CLEAN_CRC to 1 clears the current CRC result stored in the FLASH_CRCDATAR register.
    $14 constant FLASH_CRC_BURST                \ [0x14 : 2] Bank 1 CRC burst size CRC_BURST bits set the size of the bursts that are generated by the CRC calculation unit.
    $16 constant FLASH_ALL_BANK                 \ [0x16] Bank 1 CRC select bit When ALL_BANK is set to 1, all bank 1 user sectors are added to list of sectors on which the CRC is calculated.
  [then]


  [ifdef] FLASH_FLASH_CRCSADD1R_DEF
    \
    \ @brief CRC start address on bank 1 CRC_START_ADDR is used when CRC_BY_SECT is cleared to 0. It must be programmed to the start address of the bank 1 memory area on which the CRC calculation is performed.
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_CRC_START_ADDR           \ [0x02 : 18] CRC start address on bank 1 CRC_START_ADDR is used when CRC_BY_SECT is cleared to 0. It must be programmed to the start address of the bank 1 memory area on which the CRC calculation is performed.
  [then]


  [ifdef] FLASH_FLASH_CRCEADD1R_DEF
    \
    \ @brief CRC end address on bank 1 CRC_END_ADDR is used when CRC_BY_SECT is cleared to 0. It must be programmed to the end address of the bank 1 memory area on which the CRC calculation is performed
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_CRC_END_ADDR             \ [0x02 : 18] CRC end address on bank 1 CRC_END_ADDR is used when CRC_BY_SECT is cleared to 0. It must be programmed to the end address of the bank 1 memory area on which the CRC calculation is performed
  [then]


  [ifdef] FLASH_FLASH_CRCDATAR_DEF
    \
    \ @brief FLASH CRC data register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CRC_DATA                 \ [0x00 : 32] CRC result
  [then]


  [ifdef] FLASH_FLASH_ECC_FA1R_DEF
    \
    \ @brief Bank 1 ECC error address When an ECC error occurs (both for single correction or double detection) during a read operation from bank 1, the FAIL_ECC_ADDR1 bitfield contains the address that generated the error. FAIL_ECC_ADDR1 is reset when the flag error in the FLASH_SR1 register (CLR_SNECCERR1 or CLR_DBECCERR1) is reset. The embedded Flash memory programs the address in this register only when no ECC error flags are set. This means that only the first address that generated an ECC error is saved. The address in FAIL_ECC_ADDR1 is relative to the Flash memory area where the error occurred (user Flash memory, system Flash memory, read-only/OTP area).
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_FAIL_ECC_ADDR1           \ [0x00 : 16] Bank 1 ECC error address When an ECC error occurs (both for single correction or double detection) during a read operation from bank 1, the FAIL_ECC_ADDR1 bitfield contains the address that generated the error. FAIL_ECC_ADDR1 is reset when the flag error in the FLASH_SR1 register (CLR_SNECCERR1 or CLR_DBECCERR1) is reset. The embedded Flash memory programs the address in this register only when no ECC error flags are set. This means that only the first address that generated an ECC error is saved. The address in FAIL_ECC_ADDR1 is relative to the Flash memory area where the error occurred (user Flash memory, system Flash memory, read-only/OTP area).
    $1f constant FLASH_OTP_FAIL_ECC             \ [0x1f] OTP ECC error bit This bit is set to 1 when one single ECC correction or double ECC detection occurred during the last successful read operation from the read-only/ OTP area. The address of the ECC error is available in FAIL_ECC_ADDR1 bitfield.
  [then]


  [ifdef] FLASH_FLASH_OTPBL_CUR_DEF
    \
    \ @brief FLASH OTP block lock
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LOCKBL                   \ [0x00 : 16] OTP Block Lock Block n corresponds to OTP 16-bit word 32 x n to 32 x n + 31. LOCKBL[n] = 1 indicates that all OTP 16-bit words in OTP Block n are locked and can no longer be programmed. LOCKBL[n] = 0 indicates that all OTP 16-bit words in OTP Block n are not locked and can still be modified.
  [then]


  [ifdef] FLASH_FLASH_OTPBL_PRG_DEF
    \
    \ @brief FLASH OTP block lock
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LOCKBL                   \ [0x00 : 16] OTP Block Lock Block n corresponds to OTP 16-bit word 32 x n to 32 x n + 31. LOCKBL[n] = 1 indicates that all OTP 16-bit words in OTP Block n are locked and can no longer be programmed. LOCKBL[n] = 0 indicates that all OTP 16-bit words in OTP Block n are not locked and can still be modified. LOCKBL bits can be set if the corresponding bit in FLASH_OTPBL_CUR is cleared.
  [then]


  [ifdef] FLASH_FLASH_ACR__DEF
    \
    \ @brief Access control register
    \ Address offset: 0x100
    \ Reset value: 0x00000013
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 4] Read latency
    $04 constant FLASH_WRHIGHFREQ               \ [0x04 : 2] Flash signal delay
  [then]


  [ifdef] FLASH_FLASH_KEYR2_DEF
    \
    \ @brief FLASH key register for bank 2
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_KEY2R                    \ [0x00 : 32] Bank 2 access configuration unlock key
  [then]


  [ifdef] FLASH_FLASH_OPTKEYR__DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEYR                  \ [0x00 : 32] Unlock key option bytes
  [then]


  [ifdef] FLASH_FLASH_CR2_DEF
    \
    \ @brief FLASH control register for bank 2
    \ Address offset: 0x10C
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_LOCK2                    \ [0x00] Bank 2 configuration lock bit This bit locks the FLASH_CR2 register. The correct write sequence to FLASH_KEYR2 register unlocks this bit. If a wrong sequence is executed, or the unlock sequence to FLASH_KEYR2 is performed twice, this bit remains locked until next system reset. LOCK2 can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK2 changes from 0 to 1, the other bits of FLASH_CR2 register do not change.
    $01 constant FLASH_PG2                      \ [0x01] Bank 2 internal buffer control bit Setting PG2 bit to 1 enables internal buffer for write operations to bank 2. This allows the preparation of program operations even if a sector or bank erase is ongoing. PG2 can be programmed only when LOCK2 is cleared to 0. When PG2 is reset, the internal buffer is disabled for write operations to bank 2 and all the data stored in the buffer but not sent to the operation queue are lost.
    $02 constant FLASH_SER2                     \ [0x02] Bank 2 sector erase request Setting SER2 bit to 1 requests a sector erase on bank 2. SER2 can be programmed only when LOCK2 is cleared to 0. BER2 has a higher priority than SER2: if both are set, the embedded Flash memory executes a bank erase. Note: Write protection error is triggered when a sector erase is required on protected sector(s).
    $03 constant FLASH_BER2                     \ [0x03] Bank 2 erase request Setting BER2 bit to 1 requests a bank erase operation on bank 2 (user Flash memory only). BER2 can be programmed only when LOCK2 is cleared to 0. BER2 has a higher priority than SER2: if both are set, the embedded Flash memory executes a bank erase. Note: Write protection error is triggered when a bank erase is required and some sectors are protected.
    $04 constant FLASH_FW2                      \ [0x04] Bank 2 write forcing control bit FW2 forces a write operation even if the write buffer is not full. FW2 can be programmed only when LOCK2 is cleared to 0. The embedded Flash memory resets FW2 when the corresponding operation has been acknowledged. Write forcing is effective only if the write buffer is not empty. In particular, FW2 does not start several write operations when the write operations are performed consecutively.
    $05 constant FLASH_START2                   \ [0x05] Bank 2 erase start control bit START2 bit is used to start a sector erase or a bank erase operation. START2 can be programmed only when LOCK2 is cleared to 0. The embedded Flash memory resets START2 when the corresponding operation has been acknowledged. The user application cannot access any embedded Flash memory register until the operation is acknowledged.
    $06 constant FLASH_SSN2                     \ [0x06 : 7] Bank 2 sector erase selection number These bits are used to select the target sector for an erase operation (they are unused otherwise). SSN2 can be programmed only when LOCK2 is cleared to 0. ... ... Note: Bank 2 is limited to 64 sectors on STM32H7A3xG devices.
    $0f constant FLASH_CRC_EN                   \ [0x0f] Bank 2 CRC control bit Setting CRC_EN bit to 1 enables the CRC calculation on bank 2. CRC_EN does not start CRC calculation but enables CRC configuration through FLASH_CRCCR2 register. When CRC calculation is performed on bank 2, it can only be disabled by setting CRC_EN bit to 0. Resetting CRC_EN clears CRC configuration and resets the content of FLASH_CRCDATAR register. CRC_EN can be programmed only when LOCK2 is cleared to 0.
    $10 constant FLASH_EOPIE2                   \ [0x10] Bank 2 end-of-program interrupt control bit Setting EOPIE2 bit to 1 enables the generation of an interrupt at the end of a program operation to bank 2. EOPIE2 can be programmed only when LOCK2 is cleared to 0.
    $11 constant FLASH_WRPERRIE2                \ [0x11] Bank 2 write protection error interrupt enable bit When WRPERRIE2 bit is set to 1, an interrupt is generated when a protection error occurs during a program operation to bank 2. WRPERRIE2 can be programmed only when LOCK2 is cleared to 0.
    $12 constant FLASH_PGSERRIE2                \ [0x12] Bank 2 programming sequence error interrupt enable bit When PGSERRIE2 bit is set to 1, an interrupt is generated when a sequence error occurs during a program operation to bank 2. PGSERRIE2 can be programmed only when LOCK2 is cleared to 0.
    $13 constant FLASH_STRBERRIE2               \ [0x13] Bank 2 strobe error interrupt enable bit When STRBERRIE2 bit is set to 1, an interrupt is generated when a strobe error occurs (the master programs several times the same byte in the write buffer) during a write operation to bank 2. STRBERRIE2 can be programmed only when LOCK2 is cleared to 0.
    $15 constant FLASH_INCERRIE2                \ [0x15] Bank 2 inconsistency error interrupt enable bit When INCERRIE2 bit is set to 1, an interrupt is generated when an inconsistency error occurs during a write operation to bank 2. INCERRIE2 can be programmed only when LOCK2 is cleared to 0.
    $17 constant FLASH_RDPERRIE2                \ [0x17] Bank 2 read protection error interrupt enable bit When RDPERRIE2 bit is set to 1, an interrupt is generated when a read protection error occurs (access to an address protected by PCROP or by RDP level 1) during a read operation from bank 2. RDPERRIE2 can be programmed only when LOCK2 is cleared to 0.
    $18 constant FLASH_RDSERRIE2                \ [0x18] Bank 2 secure error interrupt enable bit When RDSERRIE2 bit is set to 1, an interrupt is generated when a secure error (access to a secure-only protected address) occurs during a read operation from bank 2. RDSERRIE2 can be programmed only when LOCK2 is cleared to 0.
    $19 constant FLASH_SNECCERRIE2              \ [0x19] Bank 2 ECC single correction error interrupt enable bit When SNECCERRIE2 bit is set to 1, an interrupt is generated when an ECC single correction error occurs during a read operation from bank 2. SNECCERRIE2 can be programmed only when LOCK2 is cleared to 0.
    $1a constant FLASH_DBECCERRIE2              \ [0x1a] Bank 2 ECC double detection error interrupt enable bit When DBECCERRIE2 bit is set to 1, an interrupt is generated when an ECC double detection error occurs during a read operation from bank 2. DBECCERRIE2 can be programmed only when LOCK2 is cleared to 0.
    $1b constant FLASH_CRCENDIE2                \ [0x1b] Bank 2 CRC end of calculation interrupt enable bit When CRCENDIE2 bit is set to 1, an interrupt is generated when the CRC computation has completed on bank 2. CRCENDIE2 can be programmed only when LOCK2 is cleared to 0.
    $1c constant FLASH_CRCRDERRIE2              \ [0x1c] Bank 2 CRC read error interrupt enable bit When CRCRDERRIE2 bit is set to 1, an interrupt is generated when a protected area (PCROP or secure-only) has been detected during the last CRC computation on bank 2. CRCRDERRIE2 can be programmed only when LOCK2 is cleared to 0.
  [then]


  [ifdef] FLASH_FLASH_SR2_DEF
    \
    \ @brief FLASH status register for bank 2
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY2                     \ [0x00] Bank 2 busy flag BSY2 flag is set when an effective write or erase operation is ongoing to bank 2. It is not possible to know what type of operation is being executed. BSY2 cannot be forced to 0. It is automatically reset by hardware every time a step in a write, or erase operation completes.
    $01 constant FLASH_WBNE2                    \ [0x01] Bank 2 write buffer not empty flag WBNE2 flag is set when embedded Flash memory is waiting for new data to complete the write buffer. In this state the write buffer is not empty. WBNE2 is reset by hardware each time the write buffer is complete or the write buffer is emptied following one of the event below: the application software forces the write operation using FW2 bit in FLASH_CR2 the embedded Flash memory detects an error that involves data loss the application software has disabled write operations in this bank This bit cannot be forced to 0. To reset it, clear the write buffer by performing any of the above listed actions or send the missing data.
    $02 constant FLASH_QW2                      \ [0x02] Bank 2 wait queue flag QW2 flag is set when a write or erase operation is pending in the command queue buffer of bank 2. It is not possible to know what type of operation is present in the queue. This flag is reset by hardware when all write/erase operations have been executed and thus removed from the waiting queue(s). This bit cannot be forced to 0. It is reset after a deterministic time if no other operations are requested.
    $03 constant FLASH_CRC_BUSY2                \ [0x03] Bank 2 CRC busy flag CRC_BUSY2 flag is set when a CRC calculation is ongoing on bank 2. This bit cannot be forced to 0. The user must wait until the CRC calculation has completed or disable CRC computation on bank 2.
    $10 constant FLASH_EOP2                     \ [0x10] Bank 2 end-of-program flag EOP2 flag is set when a programming operation to bank 2 completes. An interrupt is generated if the EOPIE2 is set to 1. It is not necessary to reset EOP2 before starting a new operation. EOP2 bit is cleared by writing 1 to CLR_EOP2 bit in FLASH_CCR2 register.
    $11 constant FLASH_WRPERR2                  \ [0x11] Bank 2 write protection error flag WRPERR2 flag is raised when a protection error occurs during a program operation to bank 2. An interrupt is also generated if the WRPERRIE2 is set to 1. Writing 1 to CLR_WRPERR2 bit in FLASH_CCR2 register clears WRPERR2.
    $12 constant FLASH_PGSERR2                  \ [0x12] Bank 2 programming sequence error flag PGSERR2 flag is raised when a sequence error occurs on bank 2. An interrupt is generated if the PGSERRIE2 bit is set to 1. Writing 1 to CLR_PGSERR2 bit in FLASH_CCR2 register clears PGSERR2.
    $13 constant FLASH_STRBERR2                 \ [0x13] Bank 2 strobe error flag STRBERR2 flag is raised when a strobe error occurs on bank 2 (when the master attempts to write several times the same byte in the write buffer). An interrupt is generated if the STRBERRIE2 bit is set to 1. Writing 1 to CLR_STRBERR2 bit in FLASH_CCR2 register clears STRBERR2.
    $15 constant FLASH_INCERR2                  \ [0x15] Bank 2 inconsistency error flag INCERR2 flag is raised when a inconsistency error occurs on bank 2. An interrupt is generated if INCERRIE2 is set to 1. Writing 1 to CLR_INCERR2 bit in the FLASH_CCR2 register clears INCERR2.
    $17 constant FLASH_RDPERR2                  \ [0x17] Bank 2 read protection error flag RDPERR2 flag is raised when a read protection error (read access to a PCROP-protected word or a RDP-protected area) occurs on bank 2. An interrupt is generated if RDPERRIE2 is set to 1. Writing 1 to CLR_RDPERR2 bit in FLASH_CCR2 register clears RDPERR2.
    $18 constant FLASH_RDSERR2                  \ [0x18] Bank 2 secure error flag RDSERR2 flag is raised when a read secure error (read access to a secure-only protected word) occurs on bank 2. An interrupt is generated if RDSERRIE2 is set to 1. Writing 1 to CLR_RDSERR2 bit in FLASH_CCR2 register clears RDSERR2.
    $19 constant FLASH_SNECCERR2                \ [0x19] Bank 2 single correction error flag SNECCERR2 flag is raised when an ECC single correction error occurs during a read operation from bank 2. An interrupt is generated if SNECCERRIE2 is set to 1. Writing 1 to CLR_SNECCERR2 bit in FLASH_CCR2 register clears SNECCERR2.
    $1a constant FLASH_DBECCERR2                \ [0x1a] Bank 2 ECC double detection error flag DBECCERR2 flag is raised when an ECC double detection error occurs during a read operation from bank 2. An interrupt is generated if DBECCERRIE2 is set to 1. Writing 1 to CLR_DBECCERR2 bit in FLASH_CCR2 register clears DBECCERR2.
    $1b constant FLASH_CRCEND2                  \ [0x1b] Bank 2 CRC end of calculation flag CRCEND2 bit is raised when the CRC computation has completed on bank 2. An interrupt is generated if CRCENDIE2 is set to 1. It is not necessary to reset CRCEND2 before restarting CRC computation. Writing 1 to CLR_CRCEND2 bit in FLASH_CCR2 register clears CRCEND2.
    $1c constant FLASH_CRCRDERR2                \ [0x1c] Bank 2 CRC read error flag CRCRDERR2 flag is raised when a word is found read protected during a CRC operation on bank 2. An interrupt is generated if CRCRDIE2 and CRCEND2 are set to 1. Writing 1 to CLR_CRCRDERR2 bit in FLASH_CCR2 register clears CRCRDERR2. Note: This flag is valid only when CRCEND2 bit is set to 1.
  [then]


  [ifdef] FLASH_FLASH_CCR2_DEF
    \
    \ @brief FLASH clear control register for bank 2
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $10 constant FLASH_CLR_EOP2                 \ [0x10] Bank 2 EOP2 flag clear bit Setting this bit to 1 resets to 0 EOP2 flag in FLASH_SR2 register.
    $11 constant FLASH_CLR_WRPERR2              \ [0x11] Bank 2 WRPERR2 flag clear bit Setting this bit to 1 resets to 0 WRPERR2 flag in FLASH_SR2 register.
    $12 constant FLASH_CLR_PGSERR2              \ [0x12] Bank 2 PGSERR2 flag clear bit Setting this bit to 1 resets to 0 PGSERR2 flag in FLASH_SR2 register.
    $13 constant FLASH_CLR_STRBERR2             \ [0x13] Bank 2 STRBERR2 flag clear bit Setting this bit to 1 resets to 0 STRBERR2 flag in FLASH_SR2 register.
    $15 constant FLASH_CLR_INCERR2              \ [0x15] Bank 2 INCERR2 flag clear bit Setting this bit to 1 resets to 0 INCERR2 flag in FLASH_SR2 register.
    $17 constant FLASH_CLR_RDPERR2              \ [0x17] Bank 2 RDPERR2 flag clear bit Setting this bit to 1 resets to 0 RDPERR2 flag in FLASH_SR2 register.
    $18 constant FLASH_CLR_RDSERR2              \ [0x18] Bank 2 RDSERR2 flag clear bit Setting this bit to 1 resets to 0 RDSERR2 flag in FLASH_SR2 register.
    $19 constant FLASH_CLR_SNECCERR2            \ [0x19] Bank 2 SNECCERR2 flag clear bit Setting this bit to 1 resets to 0 SNECCERR2 flag in FLASH_SR2 register. If the DBECCERR2 flag of FLASH_SR2 register is cleared to 0, FLASH_ECC_FA2R register is reset to 0 as well.
    $1a constant FLASH_CLR_DBECCERR2            \ [0x1a] Bank 2 DBECCERR2 flag clear bit Setting this bit to 1 resets to 0 DBECCERR2 flag in FLASH_SR2 register. If the SNECCERR2 flag of FLASH_SR2 register is cleared to 0, FLASH_ECC_FA2R register is reset to 0 as well.
    $1b constant FLASH_CLR_CRCEND2              \ [0x1b] Bank 2 CRCEND2 flag clear bit Setting this bit to 1 resets to 0 CRCEND2 flag in FLASH_SR2 register.
    $1c constant FLASH_CLR_CRCRDERR2            \ [0x1c] Bank 2 CRCRDERR2 flag clear bit Setting this bit to 1 resets to 0 CRCRDERR2 flag in FLASH_SR2 register.
  [then]


  [ifdef] FLASH_FLASH_OPTCR__DEF
    \
    \ @brief FLASH option control register
    \ Address offset: 0x118
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_OPTLOCK                  \ [0x00] FLASH_OPTCR lock option configuration bit
    $01 constant FLASH_OPTSTART                 \ [0x01] Option byte start change option configuration bit
    $04 constant FLASH_MER                      \ [0x04] Flash mass erase enable bit
    $05 constant FLASH_PG_OTP                   \ [0x05] OTP program control bit
    $1e constant FLASH_OPTCHANGEERRIE           \ [0x1e] Option byte change error interrupt enable bit
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping configuration bit
  [then]


  [ifdef] FLASH_FLASH_OPTSR_CUR__DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPT_BUSY                 \ [0x00] Option byte change ongoing flag
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] Brownout level option status bit
    $04 constant FLASH_IWDG_SW                  \ [0x04] IWDG1 control option status bit
    $06 constant FLASH_NRST_STOP                \ [0x06] D1 DStop entry reset option status bit
    $07 constant FLASH_NRST_STDY                \ [0x07] D1 DStandby entry reset option status bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option status byte
    $10 constant FLASH_VDDMMC_HSLV              \ [0x10] IWDG Stop mode freeze option status bit
    $11 constant FLASH_WDG_FZ_STOP              \ [0x11] IWDG Stop mode freeze option status bit
    $12 constant FLASH_IWDG_FZ_SDBY             \ [0x12] IWDG Standby mode freeze option status bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM RAM size option status
    $15 constant FLASH_SECURITY                 \ [0x15] Security enable option status bit
    $1d constant FLASH_VDDIO_HSLV               \ [0x1d] I/O high-speed at low-voltage status bit (PRODUCT_BELOW_25V)
    $1e constant FLASH_OPTCHANGEERR             \ [0x1e] Option byte change error flag
    $1f constant FLASH_SWAP_BANK_OPT            \ [0x1f] Bank swapping option status bit
  [then]


  [ifdef] FLASH_FLASH_OPTSR_PRG__DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_BOR_LEV                  \ [0x02 : 2] BOR reset level option configuration bits
    $04 constant FLASH_IWDG_SW                  \ [0x04] IWDG1 option configuration bit
    $06 constant FLASH_NRST_STOP                \ [0x06] Option byte erase after D1 DStop option configuration bit
    $07 constant FLASH_NRST_STDY                \ [0x07] Option byte erase after D1 DStandby option configuration bit
    $08 constant FLASH_RDP                      \ [0x08 : 8] Readout protection level option configuration byte
    $10 constant FLASH_VDDMMC_HSLV              \ [0x10] VDDMMC_HSLV
    $11 constant FLASH_WDG_FZ_STOP              \ [0x11] IWDG Stop mode freeze option configuration bit
    $12 constant FLASH_IWDG_FZ_SDBY             \ [0x12] IWDG Standby mode freeze option configuration bit
    $13 constant FLASH_ST_RAM_SIZE              \ [0x13 : 2] DTCM size select option configuration bits
    $15 constant FLASH_SECURITY                 \ [0x15] Security option configuration bit
    $1d constant FLASH_VDDIO_HSLV               \ [0x1d] VDDIO_HSLV
    $1f constant FLASH_SWAP_BANK_OPT            \ [0x1f] Bank swapping option configuration bit
  [then]


  [ifdef] FLASH_FLASH_OPTCCR__DEF
    \
    \ @brief FLASH option clear control register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $1e constant FLASH_CLR_OPTCHANGEERR         \ [0x1e] OPTCHANGEERR reset bit
  [then]


  [ifdef] FLASH_FLASH_PRAR_CUR2_DEF
    \
    \ @brief FLASH protection address for bank 2
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START2         \ [0x00 : 12] Bank 2 PCROP area start status bits These bits contain the first 256-byte block of the PCROP area in bank 2. If this address is equal to PROT_AREA_END2, the whole bank 2 is PCROP protected. If this address is higher than PROT_AREA_END2, no protection is set on bank 2.
    $10 constant FLASH_PROT_AREA_END2           \ [0x10 : 12] Bank 2 PCROP area end status bits These bits contain the last 256-byte block of the PCROP area in bank 2. If this address is equal to PROT_AREA_START2, the whole bank 2 is PCROP protected. If this address is lower than PROT_AREA_START2, no protection is set on bank 2.
    $1f constant FLASH_DMEP2                    \ [0x1f] Bank 2 PCROP protected erase enable option status bit If DMEP2 is set to 1, the PCROP protected area in bank 2 is erased when a protection level regression (change from level 1 to 0) or a bank erase with protection removal occurs.
  [then]


  [ifdef] FLASH_FLASH_PRAR_PRG2_DEF
    \
    \ @brief FLASH protection address for bank 2
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PROT_AREA_START2         \ [0x00 : 12] Bank 2 PCROP area start configuration bits These bits contain the first 256-byte block of the PCROP area in bank 2. If this address is equal to PROT_AREA_END2, the whole bank 2 is PCROP protected. If this address is higher than PROT_AREA_END2, no protection is set on bank 2.
    $10 constant FLASH_PROT_AREA_END2           \ [0x10 : 12] Bank 2 PCROP area end configuration bits These bits contain the last 256-byte block of the PCROP area in bank 2. If this address is equal to PROT_AREA_START2, the whole bank 2 is PCROP protected. If this address is lower than PROT_AREA_START2, no protection is set on bank 2.
    $1f constant FLASH_DMEP2                    \ [0x1f] Bank 2 PCROP protected erase enable option configuration bit If DMEP2 is set to 1, the PCROP protected area in bank 2 is erased when a protection level regression (change from level 1 to 0) or a bank erase with protection removal occurs.
  [then]


  [ifdef] FLASH_FLASH_SCAR_CUR2_DEF
    \
    \ @brief FLASH secure address for bank 2
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START2          \ [0x00 : 12] Bank 2 secure-only area start status bits These bits contain the first 256-byte block of the secure-only area in bank 2. If this address is equal to SEC_AREA_END2, the whole bank 2 is secure protected. If this address is higher than SEC_AREA_END2, no protection is set on bank 2.
    $10 constant FLASH_SEC_AREA_END2            \ [0x10 : 12] Bank 2 secure-only area end status bits These bits contain the last 256-byte block of the secure-only area in bank 2. If this address is equal to SEC_AREA_START2, the whole bank 2 is secure protected. If this address is lower than SEC_AREA_START2, no protection is set on bank 2.
    $1f constant FLASH_DMES2                    \ [0x1f] Bank 2 secure protected erase enable option status bit If DMES2 is set to 1, the secure protected area in bank 2 is erased when a protection level regression (change from level 1 to 0) or a bank erase with protection removal occurs.
  [then]


  [ifdef] FLASH_FLASH_SCAR_PRG2_DEF
    \
    \ @brief FLASH secure address for bank 2
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_AREA_START2          \ [0x00 : 12] Bank 2 secure-only area start configuration bits These bits contain the first of 256 bytes block of the secure-only area in bank 2. If this address is equal to SEC_AREA_END2, the whole bank 2 is secure access only. If this address is higher than SEC_AREA_END2, no protection is set on bank 2.
    $10 constant FLASH_SEC_AREA_END2            \ [0x10 : 12] Bank 2 secure-only area end configuration bits These bits contain the last of 256 bytes block of the secure-only area in bank 2. If this address is equal to SEC_AREA_START2, the whole bank 2 is secure access only. If this address is lower than SEC_AREA_START2, no protection is set on bank 2.
    $1f constant FLASH_DMES2                    \ [0x1f] Bank 2 secure access protected erase enable option configuration bit If DMES2 is set to 1, the secure access only area in bank 2 is erased when a protection level regression (change from level 1 to 0) or a bank erase with protection removal occurs.
  [then]


  [ifdef] FLASH_FLASH_WPSGN_CUR2R_DEF
    \
    \ @brief FLASH write sector group protection for bank 2
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSGn2                  \ [0x00 : 32] Bank 2 sector group protection option status byte Each FLASH_WPSGN_CUR2R bit reflects the write protection status of the corresponding group of 4 consecutive sectors in bank 2 (0: group is write protected; 1: group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127 Note: Bank 2 is limited to 64 sectors on STM32H7A3xG devices.
  [then]


  [ifdef] FLASH_FLASH_WPSGN_PRG2R_DEF
    \
    \ @brief FLASH write sector group protection for bank 2
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSGn2                  \ [0x00 : 32] Bank 2 sector group protection option status byte Setting WRPSGn2 bits to 0 write protects the corresponding group of 4 consecutive sectors in bank 2 (0: group is write protected; 1: group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127 Note: Bank 2 is limited to 64 sectors on STM32H7A3xG devices.
  [then]


  [ifdef] FLASH_FLASH_BOOT_CURR__DEF
    \
    \ @brief FLASH register with boot address
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_ADD0                \ [0x00 : 16] Boot address 0
    $10 constant FLASH_BOOT_ADD1                \ [0x10 : 16] Boot address 1
  [then]


  [ifdef] FLASH_FLASH_BOOT_PRGR__DEF
    \
    \ @brief FLASH register with boot address
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_ADD0                \ [0x00 : 16] Boot address 0
    $10 constant FLASH_BOOT_ADD1                \ [0x10 : 16] Boot address 1
  [then]


  [ifdef] FLASH_FLASH_CRCCR2_DEF
    \
    \ @brief FLASH CRC control register for bank 2
    \ Address offset: 0x150
    \ Reset value: 0x001C0000
    \
    $00 constant FLASH_CRC_SECT                 \ [0x00 : 7] Bank 2 CRC sector number CRC_SECT is used to select one or more user Flash sectors to be added to CRC calculation. The CRC can be computed either between two addresses (using registers FLASH_CRCSADD2R and FLASH_CRCEADD2R) or on a list of sectors using this register. If this latter option is selected, it is possible to add a sector to the list of sectors by programming the sector number in CRC_SECT and then setting ADD_SECT to 1. The list of sectors can be erased either by setting CLEAN_SECT bit or by disabling the CRC computation. CRC_SECT can be set only when CRC_EN of FLASH_CR register is set to 1. ... ... Note: Bank 2 is limited to 64 sectors on STM32H7AxG devices.
    $08 constant FLASH_CRC_BY_SECT              \ [0x08] Bank 2 CRC sector mode select bit When CRC_BY_SECT is set to 1, the CRC calculation is performed at sector level, on the sectors selected by CRC_SECT. When CRC_BY_SECT is reset to 0, the CRC calculation is performed on all addresses between CRC_START_ADDR and CRC_END_ADDR.
    $09 constant FLASH_ADD_SECT                 \ [0x09] Bank 2 CRC sector select bit Setting ADD_SECT to 1 adds the sector whose number is CRC_SECT to the list of sectors on which the CRC is calculated.
    $0a constant FLASH_CLEAN_SECT               \ [0x0a] Bank 2 CRC sector list clear bit Setting CLEAN_SECT to 1 clears the list of sectors on which the CRC is calculated.
    $10 constant FLASH_START_CRC                \ [0x10] Bank 2 CRC start bit START_CRC bit triggers a CRC calculation on bank 2 using the current configuration. It is not possible to start a CRC calculation when an option byte change operation is ongoing because all write accesses to embedded Flash memory registers are put on hold until the option byte change operation has completed.
    $11 constant FLASH_CLEAN_CRC                \ [0x11] Bank 2 CRC clear bit Setting CLEAN_CRC to 1 clears the current CRC result stored in the FLASH_CRCDATAR register.
    $14 constant FLASH_CRC_BURST                \ [0x14 : 2] Bank 2 CRC burst size CRC_BURST bits set the size of the bursts that are generated by the CRC calculation unit.
    $16 constant FLASH_ALL_BANK                 \ [0x16] Bank 2 CRC select bit When ALL_BANK is set to 1, all bank 2 user sectors are added to the list of sectors on which the CRC is calculated.
  [then]


  [ifdef] FLASH_FLASH_CRCSADD2R_DEF
    \
    \ @brief FLASH CRC start address register for bank 2
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_CRC_START_ADDR           \ [0x02 : 18] CRC start address on bank 2 CRC_START_ADDR is used when CRC_BY_SECT is cleared to 0. It must be programmed to the start address of the bank 2 memory area on which the CRC calculation is performed.
  [then]


  [ifdef] FLASH_FLASH_CRCEADD2R_DEF
    \
    \ @brief FLASH CRC end address register for bank 2
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_CRC_END_ADDR             \ [0x02 : 18] CRC end address on bank 2 CRC_END_ADDR is used when CRC_BY_SECT is cleared to 0. It must be programmed to the end address of the bank 2 memory area on which the CRC calculation is performed.
  [then]


  [ifdef] FLASH_FLASH_ECC_FA2R_DEF
    \
    \ @brief FLASH ECC fail address for bank 2
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_FAIL_ECC_ADDR2           \ [0x00 : 16] Bank 2 ECC error address When an ECC error occurs (both for single error correction or double detection) during a read operation from bank 2, the FAIL_ECC_ADDR2 bitfield contains the address that generated the error. FAIL_ECC_ADDR2 is reset when the flag error in the FLASH_SR2 register (CLR_SNECCERR2 or CLR_DBECCERR2) is reset. The embedded Flash memory programs the address in this register only when no ECC error flags are set. This means that only the first address that generated an ECC error is saved.
  [then]

  \
  \ @brief Embedded Flash memory
  \
  $00 constant FLASH_FLASH_ACR          \ Access control register
  $04 constant FLASH_FLASH_KEYR1        \ FLASH key register for bank 1
  $08 constant FLASH_FLASH_OPTKEYR      \ FLASH option key register
  $0C constant FLASH_FLASH_CR1          \ Bank 1 configuration lock bit This bit locks the FLASH_CR1 register. The correct write sequence to FLASH_KEYR1 register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_KEYR1 is performed twice, this bit remains locked until the next system reset. LOCK1 can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK1 changes from 0 to 1, the other bits of FLASH_CR1 register do not change.
  $10 constant FLASH_FLASH_SR1          \ Bank 1 busy flag BSY1 flag is set when an effective write, erase or option byte change operation is ongoing on bank 1. It is not possible to know what type of operation is being executed. BSY1 cannot be forced to 0. It is automatically reset by hardware every time a step in a write, erase or option byte change operation completes.
  $14 constant FLASH_FLASH_CCR1         \ Bank 1 EOP1 flag clear bit Setting this bit to 1 resets to 0 EOP1 flag in FLASH_SR1 register.
  $18 constant FLASH_FLASH_OPTCR        \ FLASH option control register
  $1C constant FLASH_FLASH_OPTSR_CUR    \ FLASH option status register
  $20 constant FLASH_FLASH_OPTSR_PRG    \ FLASH option status register
  $24 constant FLASH_FLASH_OPTCCR       \ FLASH option clear control register
  $28 constant FLASH_FLASH_PRAR_CUR1    \ FLASH protection address for bank 1
  $2C constant FLASH_FLASH_PRAR_PRG1    \ FLASH protection address for bank 1
  $30 constant FLASH_FLASH_SCAR_CUR1    \ FLASH secure address for bank 1
  $34 constant FLASH_FLASH_SCAR_PRG1    \ FLASH secure address for bank 1
  $38 constant FLASH_FLASH_WPSGN_CUR1R  \ FLASH write sector group protection for bank 1
  $3C constant FLASH_FLASH_WPSGN_PRG1R  \ FLASH write sector group protection for bank 1
  $40 constant FLASH_FLASH_BOOT_CURR    \ FLASH register with boot address
  $44 constant FLASH_FLASH_BOOT_PRGR    \ FLASH register with boot address
  $50 constant FLASH_FLASH_CRCCR1       \ FLASH CRC control register for bank 1
  $54 constant FLASH_FLASH_CRCSADD1R    \ CRC start address on bank 1 CRC_START_ADDR is used when CRC_BY_SECT is cleared to 0. It must be programmed to the start address of the bank 1 memory area on which the CRC calculation is performed.
  $58 constant FLASH_FLASH_CRCEADD1R    \ CRC end address on bank 1 CRC_END_ADDR is used when CRC_BY_SECT is cleared to 0. It must be programmed to the end address of the bank 1 memory area on which the CRC calculation is performed
  $5C constant FLASH_FLASH_CRCDATAR     \ FLASH CRC data register
  $60 constant FLASH_FLASH_ECC_FA1R     \ Bank 1 ECC error address When an ECC error occurs (both for single correction or double detection) during a read operation from bank 1, the FAIL_ECC_ADDR1 bitfield contains the address that generated the error. FAIL_ECC_ADDR1 is reset when the flag error in the FLASH_SR1 register (CLR_SNECCERR1 or CLR_DBECCERR1) is reset. The embedded Flash memory programs the address in this register only when no ECC error flags are set. This means that only the first address that generated an ECC error is saved. The address in FAIL_ECC_ADDR1 is relative to the Flash memory area where the error occurred (user Flash memory, system Flash memory, read-only/OTP area).
  $68 constant FLASH_FLASH_OTPBL_CUR    \ FLASH OTP block lock
  $6C constant FLASH_FLASH_OTPBL_PRG    \ FLASH OTP block lock
  $100 constant FLASH_FLASH_ACR_        \ Access control register
  $104 constant FLASH_FLASH_KEYR2       \ FLASH key register for bank 2
  $108 constant FLASH_FLASH_OPTKEYR_    \ FLASH option key register
  $10C constant FLASH_FLASH_CR2         \ FLASH control register for bank 2
  $110 constant FLASH_FLASH_SR2         \ FLASH status register for bank 2
  $114 constant FLASH_FLASH_CCR2        \ FLASH clear control register for bank 2
  $118 constant FLASH_FLASH_OPTCR_      \ FLASH option control register
  $11C constant FLASH_FLASH_OPTSR_CUR_  \ FLASH option status register
  $120 constant FLASH_FLASH_OPTSR_PRG_  \ FLASH option status register
  $124 constant FLASH_FLASH_OPTCCR_     \ FLASH option clear control register
  $128 constant FLASH_FLASH_PRAR_CUR2   \ FLASH protection address for bank 2
  $12C constant FLASH_FLASH_PRAR_PRG2   \ FLASH protection address for bank 2
  $130 constant FLASH_FLASH_SCAR_CUR2   \ FLASH secure address for bank 2
  $134 constant FLASH_FLASH_SCAR_PRG2   \ FLASH secure address for bank 2
  $138 constant FLASH_FLASH_WPSGN_CUR2R \ FLASH write sector group protection for bank 2
  $13C constant FLASH_FLASH_WPSGN_PRG2R \ FLASH write sector group protection for bank 2
  $140 constant FLASH_FLASH_BOOT_CURR_  \ FLASH register with boot address
  $144 constant FLASH_FLASH_BOOT_PRGR_  \ FLASH register with boot address
  $150 constant FLASH_FLASH_CRCCR2      \ FLASH CRC control register for bank 2
  $154 constant FLASH_FLASH_CRCSADD2R   \ FLASH CRC start address register for bank 2
  $158 constant FLASH_FLASH_CRCEADD2R   \ FLASH CRC end address register for bank 2
  $160 constant FLASH_FLASH_ECC_FA2R    \ FLASH ECC fail address for bank 2

: FLASH_DEF ; [then]
