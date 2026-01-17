\
\ @file flash.fs
\ @brief FLASH address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FLASH_DEF

  [ifdef] FLASH_FLASH_ACR_DEF
    \
    \ @brief FLASH access control register
    \ Address offset: 0x00
    \ Reset value: 0x00000013
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 4] Read latency These bits are used to control the number of wait states used during read operations on both nonvolatile memory banks. The application software has to program them to the correct value depending on the embedded flash memory interface frequency and voltage conditions. ... Note: No check is performed by hardware to verify that the configuration is correct.
    $04 constant FLASH_WRHIGHFREQ               \ [0x04 : 2] Flash signal delay These bits are used to control the delay between nonvolatile memory signals during programming operations. Application software has to program them to the correct value depending on the embedded flash memory interface frequency. Please refer to Table44 for details. Note: No check is performed to verify that the configuration is correct. Note: Two WRHIGHFREQ values can be selected for some frequencies.
    $08 constant FLASH_PRFTEN                   \ [0x08] Prefetch enable. When bit value is modified, user must read back ACR register to be sure PRFTEN has been taken into account. Bits used to control the prefetch.
  [then]


  [ifdef] FLASH_FLASH_NSKEYR_DEF
    \
    \ @brief FLASH non-secure key register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSKEY                    \ [0x00 : 32] Non-volatile memory non-secure configuration access unlock key
  [then]


  [ifdef] FLASH_FLASH_SECKEYR_DEF
    \
    \ @brief FLASH secure key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECKEY                   \ [0x00 : 32] Non-volatile memory secure configuration access unlock key
  [then]


  [ifdef] FLASH_FLASH_OPTKEYR_DEF
    \
    \ @brief FLASH option key register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEY                   \ [0x00 : 32] FLASH option bytes control access unlock key
  [then]


  [ifdef] FLASH_FLASH_NSOBKKEYR_DEF
    \
    \ @brief FLASH non-secure OBK key register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSOBKKEY                 \ [0x00 : 32] FLASH non-secure option bytes keys control access unlock key
  [then]


  [ifdef] FLASH_FLASH_SECOBKKEYR_DEF
    \
    \ @brief FLASH secure OBK key register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECOBKKEY                \ [0x00 : 32] FLASH secure option bytes keys control access unlock key
  [then]


  [ifdef] FLASH_FLASH_OPSR_DEF
    \
    \ @brief FLASH operation status register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_OP                  \ [0x00 : 20] Interrupted operation address
    $15 constant FLASH_DATA_OP                  \ [0x15] Flash high-cycle data area operation interrupted It indicates if flash high-cycle data area is concerned by operation.
    $16 constant FLASH_BK_OP                    \ [0x16] Interrupted operation bank It indicates which bank was concerned by operation.
    $17 constant FLASH_SYSF_OP                  \ [0x17] Operation in system flash memory interrupted Indicates that reset interrupted an ongoing operation in system flash.
    $18 constant FLASH_OTP_OP                   \ [0x18] OTP operation interrupted Indicates that reset interrupted an ongoing operation in OTP area (or OBKeys area).
    $1d constant FLASH_CODE_OP                  \ [0x1d : 3] Flash memory operation code
  [then]


  [ifdef] FLASH_FLASH_OPTCR_DEF
    \
    \ @brief FLASH option control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_OPTLOCK                  \ [0x00] FLASH_OPTCR lock option configuration bit The OPTLOCK bit locks the FLASH_OPTCR register as well as all _PRG registers. The correct write sequence to FLASH_OPTKEYR register unlocks this bit. If a wrong sequence is executed, or the unlock sequence to FLASH_OPTKEYR is performed twice, this bit remains locked until next system reset. It is possible to set OPTLOCK by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When OPTLOCK changes from 0 to 1, the others bits of FLASH_OPTCR register do not change.
    $01 constant FLASH_OPTSTRT                  \ [0x01] Option byte start change option configuration bit OPTSTRT triggers an option byte change operation. The user can set OPTSTRT only when the OPTLOCK bit is cleared to 0. It is set only by Software and cleared when the option byte change is completed or an error occurs (PGSERR or OPTCHANGEERR). It is reseted at the same time as BSY bit. The user application cannot modify any FLASH_XXX_PRG flash interface register until the option change operation has been completed. Before setting this bit, the user has to write the required values in the FLASH_XXX_PRG registers. The FLASH_XXX_PRG registers are locked until the option byte change operation has been executed in nonvolatile memory.
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping option configuration bit SWAP_BANK controls whether Bank1 and Bank2 are swapped or not. This bit is loaded with the SWAP_BANK bit of FLASH_OPTSR_CUR register only after reset or POR.
  [then]


  [ifdef] FLASH_FLASH_NSSR_DEF
    \
    \ @brief FLASH non-secure status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY                      \ [0x00] busy flag BSY flag indicates that a flash memory is busy by an operation (write, erase, option byte change, OBK operation). It is set at the beginning of a flash memory operation and cleared when the operation finishes, or an error occurs.
    $01 constant FLASH_WBNE                     \ [0x01] write buffer not empty flag WBNE flag is set when the flash interface is waiting for new data to complete the write buffer. In this state, the write buffer is not empty. WBNE is reset by hardware each time the write buffer is complete or the write buffer is emptied following one of the event below: the application software forces the write operation using FW bit in FLASH_NSCR the embedded flash memory detects an error that involves data loss This bit cannot be reset by software writing 0 directly. To reset it, clear the write buffer by performing any of the above listed actions, or send the missing data.
    $03 constant FLASH_DBNE                     \ [0x03] data buffer not empty flag DBNE flag is set when the flash interface is processing 6-bits ECC data in dedicated buffer. This bit cannot be set to 0 by software. The hardware resets it once the buffer is free.
    $10 constant FLASH_EOP                      \ [0x10] end of operation flag EOP flag is set when a operation (program/erase) completes. An interrupt is generated if the EOPIE is set to 1. It is not necessary to reset EOP before starting a new operation. EOP bit is cleared by writing 1 to CLR_EOP bit in FLASH_NSCCR register.
    $11 constant FLASH_WRPERR                   \ [0x11] write protection error flag WRPERR flag is raised when a protection error occurs during a program operation. An interrupt is also generated if the WRPERRIE is set to 1. Writing 1 to CLR_WRPERR bit in FLASH_NSCCR register clears WRPERR.
    $12 constant FLASH_PGSERR                   \ [0x12] programming sequence error flag PGSERR flag is raised when a sequence error occurs. An interrupt is generated if the PGSERRIE bit is set to 1. Writing 1 to CLR_PGSERR bit in FLASH_NSCCR register clears PGSERR.
    $13 constant FLASH_STRBERR                  \ [0x13] strobe error flag STRBERR flag is raised when a strobe error occurs (when the master attempts to write several times the same byte in the write buffer). An interrupt is generated if the STRBERRIE bit is set to 1. Writing 1 to CLR_STRBERR bit in FLASH_NSCCR register clears STRBERR.
    $14 constant FLASH_INCERR                   \ [0x14] inconsistency error flag NSINCERR flag is raised when a inconsistency error occurs. An interrupt is generated if INCERRIE is set to 1. Writing 1 to CLR_INCERR bit in the FLASH_NSCCR register clears NSINCERR.
    $15 constant FLASH_OBKERR                   \ [0x15] OBK general error flag OBKERR flag is raised when the OBK-HDPL signal from the SBS does not match the HDPL value associated with the key slot during access to the key location. Alternatively also when the ALT_SECT is unexpectedly changed while the write buffer is being filled.
    $16 constant FLASH_OBKWERR                  \ [0x16] OBK write error flag OBKWERR flag is raised when the address is not virgin on a write access to the OBK storage. Alternatively also when the OBK selector in the alternate sector is not virgin during a swap operation.
    $17 constant FLASH_OPTCHANGEERR             \ [0x17] Option byte change error flag OPTCHANGEERR flag indicates that an error occurred during an option byte change operation. When OPTCHANGEERR is set to 1, the option byte change operation did not successfully complete. An interrupt is generated when this flag is raised if the OPTCHANGEERRIE bit of FLASH_NSCR register is set to 1. Writing 1 to CLR_OPTCHANGEERR of register FLASH_NSCCR clears OPTCHANGEERR. Note: The OPTSTRT bit in FLASH_OPTCR cannot be set while OPTCHANGEERR is set.
  [then]


  [ifdef] FLASH_FLASH_SECSR_DEF
    \
    \ @brief FLASH secure status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BSY                      \ [0x00] busy flag BSY flag indicates that a FLASH memory is busy (write, erase, option byte change, OBK operations). It is set at the beginning of a flash memory operation and cleared when the operation finishes or an error occurs.
    $01 constant FLASH_WBNE                     \ [0x01] write buffer not empty flag WBNE flag is set when the flash interface is waiting for new data to complete the write buffer. In this state, the write buffer is not empty. WBNE is reset by hardware each time the write buffer is complete or the write buffer is emptied following one of the event below: the application software forces the write operation using FW bit in FLASH_SECCR the flash interface detects an error that involves data loss This bit cannot be reset by writing 0 directly by software. To reset it, clear the write buffer by performing any of the above listed actions, or send the missing data.
    $03 constant FLASH_DBNE                     \ [0x03] data buffer not empty flag DBNE flag is set when the embedded flash memory interface is processing 6-bits ECC data in dedicated buffer. This bit cannot be set to 0 by software. The hardware resets it once the buffer is free.
    $10 constant FLASH_EOP                      \ [0x10] end of operation flag EOP flag is set when a operation (program/erase) completes. An interrupt is generated if the EOPIE is set to. It is not necessary to reset EOP before starting a new operation. EOP bit is cleared by writing 1 to CLR_EOP bit in FLASH_SECCCR register.
    $11 constant FLASH_WRPERR                   \ [0x11] write protection error flag WRPERR flag is raised when a protection error occurs during a program operation. An interrupt is also generated if the WRPERRIE is set to 1. Writing 1 to CLR_WRPERR bit in FLASH_SECCCR register clears WRPERR.
    $12 constant FLASH_PGSERR                   \ [0x12] programming sequence error flag PGSERR flag is raised when a sequence error occurs. An interrupt is generated if the PGSERRIE bit is set to 1. Writing 1 to CLR_PGSERR bit in FLASH_SECCCR register clears PGSERR.
    $13 constant FLASH_STRBERR                  \ [0x13] strobe error flag STRBERR flag is raised when a strobe error occurs (when the master attempts to write several times the same byte in the write buffer). An interrupt is generated if the STRBERRIE bit is set to 1. Writing 1 to CLR_STRBERR bit in FLASH_SECCCR register clears STRBERR.
    $14 constant FLASH_INCERR                   \ [0x14] inconsistency error flag INCERR flag is raised when a inconsistency error occurs. An interrupt is generated if INCERRIE is set to 1. Writing 1 to CLR_INCERR bit in the FLASH_SECCCR register clears INCERR.
    $15 constant FLASH_OBKERR                   \ [0x15] OBK general error flag OBKERR flag is raised when the OBK-HDPL signal from the SBS does not match the HDPL value associated with the key slot during access to the key location. Alternatively also when the ALT_SECT is unexpectedly changed while the write buffer is being filled.
    $16 constant FLASH_OBKWERR                  \ [0x16] OBK write error flag OBKWERR flag is raised when the address is not virgin on a write access to the OBK storage. Alternatively also when the OBK selector in the alternate sector is not virgin during a swap operation.
  [then]


  [ifdef] FLASH_FLASH_NSCR_DEF
    \
    \ @brief FLASH non-secure control register
    \ Address offset: 0x28
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_LOCK                     \ [0x00] configuration lock bit This bit locks the FLASH_NSCR register. The correct write sequence to FLASH_NSKEYR register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_NSKEYR is performed twice, this bit remains locked until the next system reset. LOCK can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK changes from 0 to 1, the other bits of FLASH_NSCR register do not change.
    $01 constant FLASH_PG                       \ [0x01] programming control bit PG can be programmed only when LOCK is cleared to 0. PG allows programming in Bank1 and Bank2.
    $02 constant FLASH_SER                      \ [0x02] sector erase request Setting SER bit to 1 requests a sector erase. SER can be programmed only when LOCK is cleared to 0. If MER and SER are also set, a PGSERR is raised.
    $03 constant FLASH_BER                      \ [0x03] erase request Setting BER bit to 1 requests a bank erase operation (user flash memory only). BER can be programmed only when LOCK is cleared to 0. If MER and SER are also set, a PGSERR is raised. Note: Write protection error is triggered when a bank erase is required and some sectors are protected.
    $04 constant FLASH_FW                       \ [0x04] write forcing control bit FW forces a write operation even if the write buffer is not full. In this case all bits not written are set to 1 by hardware. FW can be programmed only when LOCK is cleared to 0. The embedded flash memory resets FW when the corresponding operation has been acknowledged. Note: Using a force-write operation prevents the application from updating later the missing bits with something else than 1, because it is likely that it leads to permanent ECC error. Write forcing is effective only if the write buffer is not empty and was filled by non-secure access (in particular, FW does not start several write operations when the force-write operations are performed consecutively). Since there is just one write buffer, FW can force a write in bank1 or bank2.
    $05 constant FLASH_STRT                     \ [0x05] erase start control bit STRT bit is used to start a sector erase or a bank erase operation. STRT can be programmed only when LOCK is cleared to 0. STRT is reset at the end of the operation or when an error occurs. It cannot be reseted by software.
    $06 constant FLASH_SNB                      \ [0x06 : 7] sector erase selection number These bits are used to select the target sector for an erase operation (they are unused otherwise). SNB can be programmed only when LOCK is cleared to 0. ..
    $0f constant FLASH_MER                      \ [0x0f] Mass erase request Setting MER bit to 1 requests a mass erase operation (user flash memory only). MER can be programmed only when LOCK is cleared to 0. If BER or SER are both set, a PGSERR is raised. Error is triggered when a mass erase is required and some sectors are protected.
    $10 constant FLASH_EOPIE                    \ [0x10] end of operation interrupt control bit Setting EOPIE bit to 1 enables the generation of an interrupt at the end of a program or erase operation. EOPIE can be programmed only when LOCK is cleared to 0.
    $11 constant FLASH_WRPERRIE                 \ [0x11] write protection error interrupt enable bit When this bit is set to 1, an interrupt is generated when a protection error occurs during a program operation. WRPERRIE can be programmed only when LOCK is cleared to 0.
    $12 constant FLASH_PGSERRIE                 \ [0x12] programming sequence error interrupt enable bit When this bit is set to 1, an interrupt is generated when a sequence error occurs during a program operation. PGSERRIE can be programmed only when LOCK is cleared to 0.
    $13 constant FLASH_STRBERRIE                \ [0x13] strobe error interrupt enable bit When STRBERRIE bit is set to 1, an interrupt is generated when a strobe error occurs (the master programs several times the same byte in the write buffer) during a write operation. STRBERRIE can be programmed only when LOCK is cleared to 0.
    $14 constant FLASH_INCERRIE                 \ [0x14] inconsistency error interrupt enable bit When INCERRIE bit is set to 1, an interrupt is generated when an inconsistency error occurs during a write operation. INCERRIE can be programmed only when LOCK is cleared to 0.
    $15 constant FLASH_OBKERRIE                 \ [0x15] OBK general error interrupt enable bit OBKERRIE enables generating an interrupt in case of OBK specific access error. This bit can be programmed only when LOCK bit is cleared to 0.
    $16 constant FLASH_OBKWERRIE                \ [0x16] OBK write error interrupt enable bit OBKWERRIE enables generation of interrupt in case of OBK specific write error. This bit can be programmed only when LOCK bit is cleared to 0.
    $17 constant FLASH_OPTCHANGEERRIE           \ [0x17] Option byte change error interrupt enable bit This bit controls if an interrupt must be generated when an error occurs during an option byte change. It can be programmed only when LOCK bit is cleared to 0.
    $1f constant FLASH_BKSEL                    \ [0x1f] Bank selector bit BKSEL can only be programmed when LOCK is cleared to 0. The bit selects physical bank, SWAP_BANK setting is ignored.
  [then]


  [ifdef] FLASH_FLASH_SECCR_DEF
    \
    \ @brief FLASH secure control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_LOCK                     \ [0x00] configuration lock bit This bit locks the FLASH_SECCR register. The correct write sequence to FLASH_SECKEYR register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_NSKEYR is performed twice, this bit remains locked until the next system reset. LOCK can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK changes from 0 to 1, the other bits of FLASH_SECCR register do not change.
    $01 constant FLASH_PG                       \ [0x01] programming control bit PG can be programmed only when LOCK is cleared to 0. PG allows programming in Bank1 and Bank2.
    $02 constant FLASH_SER                      \ [0x02] sector erase request Setting SER bit to 1 requests a sector erase. SER can be programmed only when LOCK is cleared to 0. If BER and MER are also set, a PGSERR is raised.
    $03 constant FLASH_BER                      \ [0x03] erase request Setting BER bit to 1 requests a bank erase operation (user flash memory only). BER can be programmed only when LOCK is cleared to 0. If MER and SER are also set, a PGSERR is raised. Note: Write protection error is triggered when a bank erase is required and some sectors are protected.
    $04 constant FLASH_FW                       \ [0x04] write forcing control bit FW forces a write operation even if the write buffer is not full. In this case all bits not written are set to 1 by hardware. FW can be programmed only when LOCK is cleared to 0. The embedded flash memory resets FW when the corresponding operation has been acknowledged. Note: Using a force-write operation prevents the application from updating later the missing bits with something else than 1, because it is likely that it leads to permanent ECC error. Write forcing is effective only if the write buffer is not empty and was filled by secure access (in particular, FW does not start several write operations when the force-write operations are performed consecutively). Since there is just one write buffer, FW can force a write in bank1 or bank2.
    $05 constant FLASH_STRT                     \ [0x05] erase start control bit STRT bit is used to start a sector erase or a bank erase operation. STRT can be programmed only when LOCK is cleared to 0. STRT is reseted at the end of the operation or when an error occurs. It cannot be reset by software.
    $06 constant FLASH_SNB                      \ [0x06 : 7] sector erase selection number These bits are used to select the target sector for an erase operation (they are unused otherwise). SNB can be programmed only when LOCK is cleared to 0. ..
    $0f constant FLASH_MER                      \ [0x0f] mass erase request Setting MER bit to 1 requests a mass erase operation (user flash memory only). MER can be programmed only when LOCK is cleared to 0. If BER or SER are also set, a PGSERR is raised. Error is triggered when a mass erase is required and some sectors are protected.
    $10 constant FLASH_EOPIE                    \ [0x10] end of operation interrupt control bit Setting EOPIE bit to 1 enables the generation of an interrupt at the end of a program/erase operation. EOPIE can be programmed only when LOCK is cleared to 0.
    $11 constant FLASH_WRPERRIE                 \ [0x11] write protection error interrupt enable bit When WRPERRIE bit is set to 1, an interrupt is generated when a protection error occurs during a program operation. WRPERRIE can be programmed only when LOCK is cleared to 0.
    $12 constant FLASH_PGSERRIE                 \ [0x12] programming sequence error interrupt enable bit When PGSERRIE bit is set to 1, an interrupt is generated when a sequence error occurs during a program operation. PGSERRIE can be programmed only when LOCK is cleared to 0.
    $13 constant FLASH_STRBERRIE                \ [0x13] strobe error interrupt enable bit When STRBERRIE bit is set to 1, an interrupt is generated when a strobe error occurs (the master programs several times the same byte in the write buffer) during a write operation. STRBERRIE can be programmed only when LOCK is cleared to 0.
    $14 constant FLASH_INCERRIE                 \ [0x14] inconsistency error interrupt enable bit When INCERRIE bit is set to 1, an interrupt is generated when an inconsistency error occurs during a write operation. INCERRIE can be programmed only when LOCK is cleared to 0.
    $15 constant FLASH_OBKERRIE                 \ [0x15] OBK general error interrupt enable bit OBKERRIE enables generating an interrupt in case of OBK specific access error. OBKERRIE can be programmed only when LOCK is cleared to 0.
    $16 constant FLASH_OBKWERRIE                \ [0x16] OBK write error interrupt enable bit OBKWERRIE enables generation of interrupt in case of OBK specific write error. OBKWERRIE can be programmed only when LOCK is cleared to 0.
    $1d constant FLASH_INV                      \ [0x1d] Flash memory security state invert. This bit inverts the flash memory security state.
    $1f constant FLASH_BKSEL                    \ [0x1f] bank selector bit BKSEL can only be programmed when LOCK is cleared to 0. The bit selects physical bank, SWAP_BANK setting is ignored.
  [then]


  [ifdef] FLASH_FLASH_NSCCR_DEF
    \
    \ @brief FLASH non-secure clear control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $10 constant FLASH_CLR_EOP                  \ [0x10] EOP flag clear bit Setting this bit to 1 resets to 0 EOP flag in FLASH_NSSR register.
    $11 constant FLASH_CLR_WRPERR               \ [0x11] WRPERR flag clear bit Setting this bit to 1 resets to 0 WRPERR flag in FLASH_NSSR register.
    $12 constant FLASH_CLR_PGSERR               \ [0x12] PGSERR flag clear bit Setting this bit to 1 resets to 0 PGSERR flag in FLASH_NSSR register.
    $13 constant FLASH_CLR_STRBERR              \ [0x13] STRBERR flag clear bit Setting this bit to 1 resets to 0 STRBERR flag in FLASH_NSSR register.
    $14 constant FLASH_CLR_INCERR               \ [0x14] INCERR flag clear bit Setting this bit to 1 resets to 0 INCERR flag in FLASH_NSSR register.
    $15 constant FLASH_CLR_OBKERR               \ [0x15] OBKERR flag clear bit. Setting this bit to 1 resets to 0 OBKERR flag in FLASH_NSSR register.
    $16 constant FLASH_CLR_OBKWERR              \ [0x16] OBKWERR flag clear bit. Setting this bit to 1 resets to 0 OBKWERR flag in FLASH_NSSR register.
    $17 constant FLASH_CLR_OPTCHANGEERR         \ [0x17] Clear the flag corresponding flag in FLASH_NSSR by writing this bit.
  [then]


  [ifdef] FLASH_FLASH_SECCCR_DEF
    \
    \ @brief FLASH secure clear control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $10 constant FLASH_CLR_EOP                  \ [0x10] EOP flag clear bit Setting this bit to 1 resets to 0 EOP flag in FLASH_SECSR register.
    $11 constant FLASH_CLR_WRPERR               \ [0x11] WRPERR flag clear bit Setting this bit to 1 resets to 0 WRPERR flag in FLASH_SECSR register.
    $12 constant FLASH_CLR_PGSERR               \ [0x12] PGSERR flag clear bit Setting this bit to 1 resets to 0 PGSERR flag in FLASH_SECSR register.
    $13 constant FLASH_CLR_STRBERR              \ [0x13] STRBERR flag clear bit Setting this bit to 1 resets to 0 STRBERR flag in FLASH_SECSR register.
    $14 constant FLASH_CLR_INCERR               \ [0x14] INCERR flag clear bit Setting this bit to 1 resets to 0 INCERR flag in FLASH_SECSR register.
    $15 constant FLASH_CLR_OBKERR               \ [0x15] OBKWERR flag clear bit Setting this bit to 1 resets to 0 OBKWERR flag in FLASH_SECSR register.
    $16 constant FLASH_CLR_OBKWERR              \ [0x16] OBKWERR flag clear bit Setting this bit to 1 resets to 0 OBKWERR flag in FLASH_SECSR register.
  [then]


  [ifdef] FLASH_FLASH_PRIVCFGR_DEF
    \
    \ @brief FLASH privilege configuration register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SPRIV                    \ [0x00] privilege attribute for secure registers
    $01 constant FLASH_NSPRIV                   \ [0x01] privilege attribute for non secure registers
  [then]


  [ifdef] FLASH_FLASH_NSOBKCFGR_DEF
    \
    \ @brief FLASH non-secure OBK configuration register
    \ Address offset: 0x40
    \ Reset value: 0x01FF0000
    \
    $00 constant FLASH_LOCK                     \ [0x00] OBKCFGR lock option configuration bit This bit locks the FLASH_NSOBKCFGR register. The correct write sequence to FLASH_NSOBKKEYR register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_NSOBKKEYR is performed twice, this bit remains locked until the next system reset. LOCK can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK changes from 0 to 1, the other bits of FLASH_NSCR register do not change.
    $01 constant FLASH_SWAP_SECT_REQ            \ [0x01] OBK swap sector request bit When set, all the OBKs which have not been updated in the alternate sector is copied from current sector to alternate one. The SWAP_OFFSET value must be a certain minimum value in order for the swap to be launched in OBK-HDPLdifferent 0. Minimum value is 16 for OBK-HDPL=1, 144 for OBK-HDPL=2 and192 for OBK-HDPL=3.
    $02 constant FLASH_ALT_SECT                 \ [0x02] alternate sector bit This bit must not change while filling the write buffer, otherwise an error (OBKERR) is generated
    $03 constant FLASH_ALT_SECT_ERASE           \ [0x03] alternate sector erase bit When ALT_SECT bit is set, use this bit to generate an erase command for the OBK alternate sector. It is set only by Software and cleared when the OBK swap operation is completed or an error occurs (PGSERR). It is reseted at the same time as BUSY bit.
    $10 constant FLASH_SWAP_OFFSET              \ [0x10 : 9] Key index (offset /16 bits) pointing for next swap. 0x01 means that only the first OBK data (128 bits) is copied from current to alternate OBK sector 0x02 means that the two first OBK data is copied
  [then]


  [ifdef] FLASH_FLASH_SECOBKCFGR_DEF
    \
    \ @brief FLASH secure OBK configuration register
    \ Address offset: 0x44
    \ Reset value: 0x01FF0000
    \
    $00 constant FLASH_LOCK                     \ [0x00] OBKCFGR lock option configuration bit This bit locks the FLASH_OBKCFGR register. The correct write sequence to FLASH_SECOBKKEYR register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_SECOBKKEYR is performed twice, this bit remains locked until the next system reset. LOCK can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK changes from 0 to 1, the other bits of FLASH_NSCR register do not change.
    $01 constant FLASH_SWAP_SECT_REQ            \ [0x01] OBK swap sector request bit When set, all the OBKs which have not been updated in the alternate sector is copied from current sector to alternate one. The SWAP_OFFSET value must be a certain minimum value in order for the swap to be launched in OBK-HDPLdifferent 0. Minimum value is 16 for OBK-HDPL=1, 144 for OBK-HDPL=2 and 192 for OBK-HDPL=3.
    $02 constant FLASH_ALT_SECT                 \ [0x02] alternate sector bit This bit must not change while filling the write buffer, otherwise an error is generated
    $03 constant FLASH_ALT_SECT_ERASE           \ [0x03] alternate sector erase bit When ALT_SECT bit is set, use this bit to generate an erase command for the OBK alternate sector. It is set only by Software and cleared when the OBK swap operation is completed or an error occurs (PGSERR). It is reseted at the same time as the BUSY bit.
    $10 constant FLASH_SWAP_OFFSET              \ [0x10 : 9] key index (offset /16 bits) pointing for next swap.
  [then]


  [ifdef] FLASH_FLASH_HDPEXTR_DEF
    \
    \ @brief FLASH HDP extension register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP1_EXT                 \ [0x00 : 7] HDP area extension in 8Kbytes sectors in Bank1. Extension is added after the HDP1_END sector (included).
    $10 constant FLASH_HDP2_EXT                 \ [0x10 : 7] HDP area extension in 8Kbytes sectors in bank 2. Extension is added after the HDP2_END sector (included).
  [then]


  [ifdef] FLASH_FLASH_OPTSR_CUR_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOR_LEV                  \ [0x00 : 2] Brownout level option status bit These bits reflects the power level that generates a system reset. 00 or 11: BOR Level 1, the threshold level is low (around 2.1V)
    $02 constant FLASH_BORH_EN                  \ [0x02] Brownout high enable
    $03 constant FLASH_IWDG_SW                  \ [0x03] IWDG control mode option status bit
    $04 constant FLASH_WWDG_SW                  \ [0x04] WWDG control mode option status bit
    $06 constant FLASH_NRST_STOP                \ [0x06] Core domain Stop entry reset option status bit
    $07 constant FLASH_NRST_STDBY               \ [0x07] Core domain Standby entry reset option status bit
    $08 constant FLASH_PRODUCT_STATE            \ [0x08 : 8] Life state code (based on Hamming 8,4). More information in Section7.6.11: Product state transitions.
    $10 constant FLASH_IO_VDD_HSLV              \ [0x10] High-speed IO at low Vsub DD/sub voltage configuration bit. This bit can be set only with Vsub DD/sub below 2.7V.
    $11 constant FLASH_IO_VDDIO2_HSLV           \ [0x11] High-speed IO at low Vsub DDIO2/sub voltage configuration bit. This bit can be set only with Vsub DDIO2/sub below 2.7V.
    $14 constant FLASH_IWDG_STOP                \ [0x14] IWDG Stop mode freeze option status bit When set the independent watchdog IWDG is in system Stop mode.
    $15 constant FLASH_IWDG_STDBY               \ [0x15] IWDG Standby mode freeze option status bit When set the independent watchdog IWDG is frozen in system Standby mode.
    $16 constant FLASH_BOOT_UBE                 \ [0x16 : 8] Available only on cryptography enabled devices. Unique boot entry control, selects either ST or OEM iRoT for secure boot.
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping option status bit SWAP_BANK reflects whether Bank1 and Bank2 are swapped or not. SWAP_BANK is loaded to SWAP_BANK of FLASH_OPTCR after a reset.
  [then]


  [ifdef] FLASH_FLASH_OPTSR_PRG_DEF
    \
    \ @brief FLASH option status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOR_LEV                  \ [0x00 : 2] Brownout level option configuration bit These bits reflects the power level that generates a system reset. 00 or 11: BOR Level 1, the threshold level is low (around 2.1 V)
    $02 constant FLASH_BORH_EN                  \ [0x02] Brownout high enable configuration bit
    $03 constant FLASH_IWDG_SW                  \ [0x03] IWDG control mode option configuration bit
    $04 constant FLASH_WWDG_SW                  \ [0x04] WWDG control mode option configuration bit
    $06 constant FLASH_NRST_STOP                \ [0x06] Core domain Stop entry reset option configuration bit
    $07 constant FLASH_NRST_STDBY               \ [0x07] Core domain Standby entry reset option configuration bit
    $08 constant FLASH_PRODUCT_STATE            \ [0x08 : 8] Life state code (based on Hamming 8,4). More information in Section7.6.11: Product state transitions.
    $10 constant FLASH_IO_VDD_HSLV              \ [0x10] High-speed IO at low VDD voltage configuration bit. This bit can be set only with VDD below 2.7V.
    $11 constant FLASH_IO_VDDIO2_HSLV           \ [0x11] High-speed IO at low VDDIO2 voltage configuration bit. This bit can be set only with VDDIO2 below 2.7V.
    $14 constant FLASH_IWDG_STOP                \ [0x14] IWDG Stop mode freeze option status bit When set the independent watchdog IWDG is in system Stop mode.
    $15 constant FLASH_IWDG_STDBY               \ [0x15] IWDG Standby mode freeze option status bit When set the independent watchdog IWDG is frozen in system Standby mode.
    $16 constant FLASH_BOOT_UBE                 \ [0x16 : 8] Available only on cryptography enabled devices. Unique boot entry control, selects either ST or OEM iRoT for secure boot. In Open PRODUCT_STATE this value selects bootloader. Defaut value.
    $1f constant FLASH_SWAP_BANK                \ [0x1f] Bank swapping option configuration bit SWAP_BANK option bit is used to configure whether the Bank1 and Bank2 are swapped or not. This bit is loaded with the SWAP_BANK bit of FLASH_OPTSR_CUR register after a reset.
  [then]


  [ifdef] FLASH_FLASH_NSEPOCHR_CUR_DEF
    \
    \ @brief FLASH non-secure EPOCH register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NS_EPOCH                 \ [0x00 : 24] Non-volatile non-secure EPOCH counter
  [then]


  [ifdef] FLASH_FLASH_SECEPOCHR_CUR_DEF
    \
    \ @brief FLASH secure EPOCH register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SEC_EPOCH                \ [0x00 : 24] Non-volatile secure EPOCH counter
  [then]


  [ifdef] FLASH_FLASH_OPTSR2_CUR_DEF
    \
    \ @brief FLASH option status register 2
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_SRAM13_RST               \ [0x02] SRAM1 and SRAM3 erase upon system reset
    $03 constant FLASH_SRAM2_RST                \ [0x03] SRAM2 erase when system reset
    $04 constant FLASH_BKPRAM_ECC               \ [0x04] Backup RAM ECC detection and correction disable
    $05 constant FLASH_SRAM3_ECC                \ [0x05] SRAM3 ECC detection and correction disable
    $06 constant FLASH_SRAM2_ECC                \ [0x06] SRAM2 ECC detection and correction disable
    $08 constant FLASH_USBPD_DIS                \ [0x08] USB power delivery configuration option bit
    $18 constant FLASH_TZEN                     \ [0x18 : 8] TrustZone enable configuration bits This bit enables the device is in TrustZone mode during an option byte change.
  [then]


  [ifdef] FLASH_FLASH_OPTSR2_PRG_DEF
    \
    \ @brief FLASH option status register 2
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $02 constant FLASH_SRAM1_3_RST              \ [0x02] SRAM1 and SRAM3 erase upon system reset Note: SRAM erase is triggered by option byte change operation, when enabling this feature.
    $03 constant FLASH_SRAM2_RST                \ [0x03] SRAM2 erase when system reset Note: SRAM erase is triggered by option byte change operation, when enabling this feature.
    $04 constant FLASH_BKPRAM_ECC               \ [0x04] Backup RAM ECC detection and correction disable
    $05 constant FLASH_SRAM3_ECC                \ [0x05] SRAM3 ECC detection and correction disable
    $06 constant FLASH_SRAM2_ECC                \ [0x06] SRAM2 ECC detection and correction disable
    $08 constant FLASH_USBPD_DIS                \ [0x08] USB power delivery configuration option bit
    $18 constant FLASH_TZEN                     \ [0x18 : 8] TrustZone enable configuration bits This bit enables the device is in TrustZone mode during an option byte change.
  [then]


  [ifdef] FLASH_FLASH_NSBOOTR_CUR_DEF
    \
    \ @brief FLASH non-secure boot register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSBOOT_LOCK              \ [0x00 : 8] A field locking the values of SWAP_BANK, and NSBOOTADD settings.
    $08 constant FLASH_NSBOOTADD                \ [0x08 : 24] Non secure unique boot entry address These bits reflect the Non secure UBE address
  [then]


  [ifdef] FLASH_FLASH_NSBOOTR_PRG_DEF
    \
    \ @brief FLASH non-secure boot register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSBOOT_LOCK              \ [0x00 : 8] A field locking the values of SWAP_ BANK, and NSBOOTADD settings.
    $08 constant FLASH_NSBOOTADD                \ [0x08 : 24] Non secure unique boot entry address These bits allow configuring the Non secure BOOT address
  [then]


  [ifdef] FLASH_FLASH_SECBOOTR_CUR_DEF
    \
    \ @brief FLASH secure boot register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBOOT_LOCK             \ [0x00 : 8] A field locking the values of UBE, SWAP_BANK, and SECBOOTADD settings.
    $08 constant FLASH_SECBOOTADD               \ [0x08 : 24] Unique boot entry secure address These bits reflect the Secure UBE address
  [then]


  [ifdef] FLASH_FLASH_BOOTR_PRG_DEF
    \
    \ @brief FLASH secure boot register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBOOT_LOCK             \ [0x00 : 8] A field locking the values of UBE, SWAP_ BANK, and SECBOOTADD setting.
    $08 constant FLASH_SECBOOTADD               \ [0x08 : 24] Secure unique boot entry address. These bits allow configuring the secure UBE address.
  [then]


  [ifdef] FLASH_FLASH_OTPBLR_CUR_DEF
    \
    \ @brief FLASH non-secure OTP block lock
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LOCKBL                   \ [0x00 : 32] OTP block lock Block n corresponds to OTP 16-bit word 32 x n to 32 x n + 31. LOCKBL[n] = 1 indicates that all OTP 16-bit words in OTP Block n are locked and attempt to program them results in WRPERR. LOCKBL[n] = 0 indicates that all OTP 16-bit words in OTP Block n are not locked. When one block is locked, it's not possible to remove the write protection. Also if not locked, it is not possible to erase OTP words.
  [then]


  [ifdef] FLASH_FLASH_OTPBLR_PRG_DEF
    \
    \ @brief FLASH non-secure OTP block lock
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LOCKBL                   \ [0x00 : 32] OTP block lock Block n corresponds to OTP 16-bit word 32 x n to 32 x n + 31. LOCKBL[n] = 1 indicates that all OTP 16-bit words in OTP Block n are locked and attempt to program them results in WRPERR. LOCKBL[n] = 0 indicates that all OTP 16-bit words in OTP Block n are not locked. When one block is locked, it is not possible to remove the write protection. LOCKBL bits can be set if the corresponding bit in FLASH_OTPBLR_CUR is cleared.
  [then]


  [ifdef] FLASH_FLASH_SECBB1R1_DEF
    \
    \ @brief FLASH secure block based register for Bank 1
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] Secure/non-secure 8Kbytes flash Bank 1 sector attributes
  [then]


  [ifdef] FLASH_FLASH_SECBB1R2_DEF
    \
    \ @brief FLASH secure block based register for Bank 1
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] Secure/non-secure 8Kbytes flash Bank 1 sector attributes
  [then]


  [ifdef] FLASH_FLASH_SECBB1R3_DEF
    \
    \ @brief FLASH secure block based register for Bank 1
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] Secure/non-secure 8Kbytes flash Bank 1 sector attributes
  [then]


  [ifdef] FLASH_FLASH_SECBB1R4_DEF
    \
    \ @brief FLASH secure block based register for Bank 1
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] Secure/non-secure 8Kbytes flash Bank 1 sector attributes
  [then]


  [ifdef] FLASH_FLASH_PRIVBB1R1_DEF
    \
    \ @brief FLASH privilege block based register for Bank 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB1                  \ [0x00 : 32] Privileged/unprivileged 8-Kbyte flash Bank 1 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB1R2_DEF
    \
    \ @brief FLASH privilege block based register for Bank 1
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB1                  \ [0x00 : 32] Privileged/unprivileged 8-Kbyte flash Bank 1 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB1R3_DEF
    \
    \ @brief FLASH privilege block based register for Bank 1
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB1                  \ [0x00 : 32] Privileged/unprivileged 8-Kbyte flash Bank 1 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB1R4_DEF
    \
    \ @brief FLASH privilege block based register for Bank 1
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB1                  \ [0x00 : 32] Privileged/unprivileged 8-Kbyte flash Bank 1 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECWM1R_CUR_DEF
    \
    \ @brief FLASH security watermark for Bank 1
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECWM1_STRT              \ [0x00 : 7] Bank1 security WM area 1 start sector
    $10 constant FLASH_SECWM1_END               \ [0x10 : 7] Bank1 security WM area 1 end sector
  [then]


  [ifdef] FLASH_FLASH_SECWM1R_PRG_DEF
    \
    \ @brief FLASH security watermark for Bank 1
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECWM1_STRT              \ [0x00 : 7] Bank1 security WM area 1 start sector
    $10 constant FLASH_SECWM1_END               \ [0x10 : 7] Bank1 security WM area 1 end sector
  [then]


  [ifdef] FLASH_FLASH_WRP1R_CUR_DEF
    \
    \ @brief FLASH write sector group protection for Bank 1
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSG1                   \ [0x00 : 32] Bank 1 sector group protection option status byte Each FLASH_WRP1R_CUR bit reflects the write protection status of the corresponding group of four consecutive sectors in bank 1 (0: the group is write protected; 1: the group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127
  [then]


  [ifdef] FLASH_FLASH_WRP1R_PRG_DEF
    \
    \ @brief FLASH write sector group protection for Bank 1
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSG1                   \ [0x00 : 32] Bank1 sector group protection option status byte Setting WRPSG1 bits to 0 write protects the corresponding group of four consecutive sectors in bank 1 (0: the group is write protected; 1: the group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127
  [then]


  [ifdef] FLASH_FLASH_EDATA1R_CUR_DEF
    \
    \ @brief FLASH data sector configuration Bank 1
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EDATA1_STRT              \ [0x00 : 3] EDATA1_STRT contains the start sectors of the flash high-cycle data area in Bank1 There is no hardware effect to those bits. They shall be managed by ST tools in Flasher. ...
    $0f constant FLASH_EDATA1_EN                \ [0x0f] Bank1 flash high-cycle data enable
  [then]


  [ifdef] FLASH_FLASH_EDATA1R_PRG_DEF
    \
    \ @brief FLASH data sector configuration Bank 1
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EDATA1_STRT              \ [0x00 : 3] EDATA1_STRT contains the start sectors of the flash high-cycle data area in Bank 1 There is no hardware effect to those bits. They shall be managed by ST tools in Flasher. ... Note: 111: The eight last sectors of the Bank 1 are reserved for flash high-cycle data
    $0f constant FLASH_EDATA1_EN                \ [0x0f] Bank 1 flash high-cycle data enable
  [then]


  [ifdef] FLASH_FLASH_HDP1R_CUR_DEF
    \
    \ @brief FLASH HDP Bank 1 configuration
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP1_STRT                \ [0x00 : 7] HDPL barrier start set in number of 8-Kbyte sectors
    $10 constant FLASH_HDP1_END                 \ [0x10 : 7] HDPL barrier end set in number of 8-Kbyte sectors
  [then]


  [ifdef] FLASH_FLASH_HDP1R_PRG_DEF
    \
    \ @brief FLASH HDP Bank 1 configuration
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP1_STRT                \ [0x00 : 7] HDPL barrier start set in number of 8-Kbyte sectors
    $10 constant FLASH_HDP1_END                 \ [0x10 : 7] HDPL barrier end set in number of 8-Kbyte sectors
  [then]


  [ifdef] FLASH_FLASH_ECCCORR_DEF
    \
    \ @brief FLASH ECC correction register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 16] ECC error address When an ECC error occurs (for single correction) during a read operation, the ADDR_ECC contains the address that generated the error. ADDR_ECC is reset when the flag error is reset. The flash interface programs the address in this register only when no ECC error flags are set. This means that only the first address that generated an ECC error is saved. The address in ADDR_ECC is relative to the flash memory area where the error occurred (user flash memory, system flash memory, data area, read-only/OTP area).
    $14 constant FLASH_OBK_ECC                  \ [0x14] Single ECC error corrected in flash OB Keys storage area. It indicates the OBK storage concerned by ECC error.
    $15 constant FLASH_EDATA_ECC                \ [0x15] ECC fail for corrected ECC error in flash high-cycle data area It indicates if flash high-cycle data area is concerned by ECC error.
    $16 constant FLASH_BK_ECC                   \ [0x16] ECC fail bank for corrected ECC error It indicates which bank is concerned by ECC error
    $17 constant FLASH_SYSF_ECC                 \ [0x17] ECC fail for corrected ECC error in system flash memory It indicates if system flash memory is concerned by ECC error.
    $18 constant FLASH_OTP_ECC                  \ [0x18] OTP ECC error bit This bit is set to 1 when one single ECC correction occurred during the last successful read operation from the read-only/ OTP area. The address of the ECC error is available in ADDR_ECC bitfield.
    $19 constant FLASH_ECCCIE                   \ [0x19] ECC single correction error interrupt enable bit When ECCCIE bit is set to 1, an interrupt is generated when an ECC single correction error occurs during a read operation.
    $1e constant FLASH_ECCC                     \ [0x1e] ECC correction set by hardware when single ECC error has been detected and corrected. Cleared by writing 1.
  [then]


  [ifdef] FLASH_FLASH_ECCDETR_DEF
    \
    \ @brief FLASH ECC detection register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 16] ECC error address When an ECC error occurs (double detection) during a read operation, the ADDR_ECC contains the address that generated the error. ADDR_ECC is reset when the flag error is reset. The flash interface programs the address in this register only when no ECC error flags are set. This means that only the first address that generated an double ECC error is saved. The address in ADDR_ECC is relative to the flash memory area where the error occurred (user flash memory, system flash memory, data area, read-only/OTP area).
    $14 constant FLASH_OBK_ECC                  \ [0x14] ECC fail double ECC error in flash OB Keys storage area. It indicates the OBK storage concerned by ECC error.
    $15 constant FLASH_EDATA_ECC                \ [0x15] ECC fail double ECC error in flash high-cycle data area It indicates if flash high-cycle data area is concerned by ECC error.
    $16 constant FLASH_BK_ECC                   \ [0x16] ECC fail bank for double ECC error It indicates which bank is concerned by ECC error
    $17 constant FLASH_SYSF_ECC                 \ [0x17] ECC fail for double ECC error in system flash memory It indicates if system flash memory is concerned by ECC error.
    $18 constant FLASH_OTP_ECC                  \ [0x18] OTP ECC error bit This bit is set to 1 when double ECC detection occurred during the last read operation from the read-only/ OTP area. The address of the ECC error is available in ADDR_ECC bitfield.
    $1f constant FLASH_ECCD                     \ [0x1f] ECC detection Set by hardware when two ECC error has been detected. When this bit is set, a NMI is generated. Cleared by writing 1. Needs to be cleared in order to detect subsequent double ECC errors.
  [then]


  [ifdef] FLASH_FLASH_ECCDR_DEF
    \
    \ @brief FLASH ECC data
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_DATA_ECC                 \ [0x00 : 16] ECC error data When an double detection ECC error occurs on special areas with 6-bit ECC on 16-bit data (data area, read-only/OTP area), the failing data is read to this register. By checking if it is possible to determine whether the failure was on a real data, or due to access to uninitialized memory.
  [then]


  [ifdef] FLASH_FLASH_SECBB2R1_DEF
    \
    \ @brief FLASH secure block-based register for Bank 2
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] Secure/non-secure flash Bank 2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECBB2R2_DEF
    \
    \ @brief FLASH secure block-based register for Bank 2
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] Secure/non-secure flash Bank 2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECBB2R3_DEF
    \
    \ @brief FLASH secure block-based register for Bank 2
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] Secure/non-secure flash Bank 2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECBB2R4_DEF
    \
    \ @brief FLASH secure block-based register for Bank 2
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] Secure/non-secure flash Bank 2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB2R1_DEF
    \
    \ @brief FLASH privilege block-based register for Bank 2
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB2                  \ [0x00 : 32] Privileged / non-privileged 8-Kbyte flash Bank 2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB2R2_DEF
    \
    \ @brief FLASH privilege block-based register for Bank 2
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB2                  \ [0x00 : 32] Privileged / non-privileged 8-Kbyte flash Bank 2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB2R3_DEF
    \
    \ @brief FLASH privilege block-based register for Bank 2
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB2                  \ [0x00 : 32] Privileged / non-privileged 8-Kbyte flash Bank 2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_PRIVBB2R4_DEF
    \
    \ @brief FLASH privilege block-based register for Bank 2
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIVBB2                  \ [0x00 : 32] Privileged / non-privileged 8-Kbyte flash Bank 2 sector attribute
  [then]


  [ifdef] FLASH_FLASH_SECWM2R_CUR_DEF
    \
    \ @brief FLASH security watermark for Bank 2
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECWM_STRT2              \ [0x00 : 7] Bank2 security WM area start sector
    $10 constant FLASH_SECWM_END2               \ [0x10 : 7] Bank2 security WM end sector
  [then]


  [ifdef] FLASH_FLASH_SECWM2R_PRG_DEF
    \
    \ @brief FLASH security watermark for Bank 2
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECWM_STRT2              \ [0x00 : 7] Bank 2 security WM area start sector
    $10 constant FLASH_SECWM_END2               \ [0x10 : 7] Bank 2 security WM area end sector
  [then]


  [ifdef] FLASH_FLASH_WRP2R_CUR_DEF
    \
    \ @brief FLASH write sector group protection for Bank 2
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSG2                   \ [0x00 : 32] Bank2 sector group protection option status byte Each FLASH_WRP2R_CUR bit reflects the write protection status of the corresponding group of 4 consecutive sectors in bank 2 (0: group is write protected; 1: group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127
  [then]


  [ifdef] FLASH_FLASH_WRP2R_PRG_DEF
    \
    \ @brief FLASH write sector group protection for Bank 2
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_WRPSG2                   \ [0x00 : 32] Bank 2 sector group protection option status byte Setting WRPSGn2 bits to 0 write protects the corresponding group of four consecutive sectors in Bank 2 (0: group is write protected; 1: group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127
  [then]


  [ifdef] FLASH_FLASH_EDATA2R_CUR_DEF
    \
    \ @brief FLASH data sectors configuration Bank 2
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EDATA2_STRT              \ [0x00 : 3] EDATA2_STRT contains the start sectors of the flash high-cycle data area in Bank 2 There is no hardware effect to those bits. They shall be managed by ST tools in Flasher. ... Note: 111: The eight last sectors of the Bank 2 are reserved for flash high-cycle data
    $0f constant FLASH_EDATA2_EN                \ [0x0f] Bank2 flash high-cycle data enable
  [then]


  [ifdef] FLASH_FLASH_EDATA2R_PRG_DEF
    \
    \ @brief FLASH data sector configuration Bank 2
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_EDATA2_STRT              \ [0x00 : 3] EDATA2_STRT contains the start sectors of the flash high-cycle data area in Bank 2 There is no hardware effect to those bits. They shall be managed by ST tools in Flasher. ... Note: 111: The eight last sectors of the Bank 2 are reserved for flash high-cycle data.
    $0f constant FLASH_EDATA2_EN                \ [0x0f] Bank 2 flash high-cycle data enable
  [then]


  [ifdef] FLASH_FLASH_HDP2R_CUR_DEF
    \
    \ @brief FLASH HDP Bank 2 configuration
    \ Address offset: 0x1F8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP2_STRT                \ [0x00 : 7] HDPL barrier start set in number of 8-Kbyte sectors
    $10 constant FLASH_HDP2_END                 \ [0x10 : 7] HDPL barrier end set in number of 8-Kbyte sectors
  [then]


  [ifdef] FLASH_FLASH_HDP2R_PRG_DEF
    \
    \ @brief FLASH HDP Bank 2 configuration
    \ Address offset: 0x1FC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP2_STRT                \ [0x00 : 7] HDPL barrier start set in number of 8-Kbyte sectors
    $10 constant FLASH_HDP2_END                 \ [0x10 : 7] HDPL barrier end set in number of 8-Kbyte sectors
  [then]

  \
  \ @brief FLASH address block description
  \
  $00 constant FLASH_FLASH_ACR          \ FLASH access control register
  $04 constant FLASH_FLASH_NSKEYR       \ FLASH non-secure key register
  $08 constant FLASH_FLASH_SECKEYR      \ FLASH secure key register
  $0C constant FLASH_FLASH_OPTKEYR      \ FLASH option key register
  $10 constant FLASH_FLASH_NSOBKKEYR    \ FLASH non-secure OBK key register
  $14 constant FLASH_FLASH_SECOBKKEYR   \ FLASH secure OBK key register
  $18 constant FLASH_FLASH_OPSR         \ FLASH operation status register
  $1C constant FLASH_FLASH_OPTCR        \ FLASH option control register
  $20 constant FLASH_FLASH_NSSR         \ FLASH non-secure status register
  $24 constant FLASH_FLASH_SECSR        \ FLASH secure status register
  $28 constant FLASH_FLASH_NSCR         \ FLASH non-secure control register
  $2C constant FLASH_FLASH_SECCR        \ FLASH secure control register
  $30 constant FLASH_FLASH_NSCCR        \ FLASH non-secure clear control register
  $34 constant FLASH_FLASH_SECCCR       \ FLASH secure clear control register
  $3C constant FLASH_FLASH_PRIVCFGR     \ FLASH privilege configuration register
  $40 constant FLASH_FLASH_NSOBKCFGR    \ FLASH non-secure OBK configuration register
  $44 constant FLASH_FLASH_SECOBKCFGR   \ FLASH secure OBK configuration register
  $48 constant FLASH_FLASH_HDPEXTR      \ FLASH HDP extension register
  $50 constant FLASH_FLASH_OPTSR_CUR    \ FLASH option status register
  $54 constant FLASH_FLASH_OPTSR_PRG    \ FLASH option status register
  $60 constant FLASH_FLASH_NSEPOCHR_CUR \ FLASH non-secure EPOCH register
  $68 constant FLASH_FLASH_SECEPOCHR_CUR    \ FLASH secure EPOCH register
  $70 constant FLASH_FLASH_OPTSR2_CUR   \ FLASH option status register 2
  $74 constant FLASH_FLASH_OPTSR2_PRG   \ FLASH option status register 2
  $80 constant FLASH_FLASH_NSBOOTR_CUR  \ FLASH non-secure boot register
  $84 constant FLASH_FLASH_NSBOOTR_PRG  \ FLASH non-secure boot register
  $88 constant FLASH_FLASH_SECBOOTR_CUR \ FLASH secure boot register
  $8C constant FLASH_FLASH_BOOTR_PRG    \ FLASH secure boot register
  $90 constant FLASH_FLASH_OTPBLR_CUR   \ FLASH non-secure OTP block lock
  $94 constant FLASH_FLASH_OTPBLR_PRG   \ FLASH non-secure OTP block lock
  $A0 constant FLASH_FLASH_SECBB1R1     \ FLASH secure block based register for Bank 1
  $A4 constant FLASH_FLASH_SECBB1R2     \ FLASH secure block based register for Bank 1
  $A8 constant FLASH_FLASH_SECBB1R3     \ FLASH secure block based register for Bank 1
  $AC constant FLASH_FLASH_SECBB1R4     \ FLASH secure block based register for Bank 1
  $C0 constant FLASH_FLASH_PRIVBB1R1    \ FLASH privilege block based register for Bank 1
  $C4 constant FLASH_FLASH_PRIVBB1R2    \ FLASH privilege block based register for Bank 1
  $C8 constant FLASH_FLASH_PRIVBB1R3    \ FLASH privilege block based register for Bank 1
  $CC constant FLASH_FLASH_PRIVBB1R4    \ FLASH privilege block based register for Bank 1
  $E0 constant FLASH_FLASH_SECWM1R_CUR  \ FLASH security watermark for Bank 1
  $E4 constant FLASH_FLASH_SECWM1R_PRG  \ FLASH security watermark for Bank 1
  $E8 constant FLASH_FLASH_WRP1R_CUR    \ FLASH write sector group protection for Bank 1
  $EC constant FLASH_FLASH_WRP1R_PRG    \ FLASH write sector group protection for Bank 1
  $F0 constant FLASH_FLASH_EDATA1R_CUR  \ FLASH data sector configuration Bank 1
  $F4 constant FLASH_FLASH_EDATA1R_PRG  \ FLASH data sector configuration Bank 1
  $F8 constant FLASH_FLASH_HDP1R_CUR    \ FLASH HDP Bank 1 configuration
  $FC constant FLASH_FLASH_HDP1R_PRG    \ FLASH HDP Bank 1 configuration
  $100 constant FLASH_FLASH_ECCCORR     \ FLASH ECC correction register
  $104 constant FLASH_FLASH_ECCDETR     \ FLASH ECC detection register
  $108 constant FLASH_FLASH_ECCDR       \ FLASH ECC data
  $1A0 constant FLASH_FLASH_SECBB2R1    \ FLASH secure block-based register for Bank 2
  $1A4 constant FLASH_FLASH_SECBB2R2    \ FLASH secure block-based register for Bank 2
  $1A8 constant FLASH_FLASH_SECBB2R3    \ FLASH secure block-based register for Bank 2
  $1AC constant FLASH_FLASH_SECBB2R4    \ FLASH secure block-based register for Bank 2
  $1C0 constant FLASH_FLASH_PRIVBB2R1   \ FLASH privilege block-based register for Bank 2
  $1C4 constant FLASH_FLASH_PRIVBB2R2   \ FLASH privilege block-based register for Bank 2
  $1C8 constant FLASH_FLASH_PRIVBB2R3   \ FLASH privilege block-based register for Bank 2
  $1CC constant FLASH_FLASH_PRIVBB2R4   \ FLASH privilege block-based register for Bank 2
  $1E0 constant FLASH_FLASH_SECWM2R_CUR \ FLASH security watermark for Bank 2
  $1E4 constant FLASH_FLASH_SECWM2R_PRG \ FLASH security watermark for Bank 2
  $1E8 constant FLASH_FLASH_WRP2R_CUR   \ FLASH write sector group protection for Bank 2
  $1EC constant FLASH_FLASH_WRP2R_PRG   \ FLASH write sector group protection for Bank 2
  $1F0 constant FLASH_FLASH_EDATA2R_CUR \ FLASH data sectors configuration Bank 2
  $1F4 constant FLASH_FLASH_EDATA2R_PRG \ FLASH data sector configuration Bank 2
  $1F8 constant FLASH_FLASH_HDP2R_CUR   \ FLASH HDP Bank 2 configuration
  $1FC constant FLASH_FLASH_HDP2R_PRG   \ FLASH HDP Bank 2 configuration

: FLASH_DEF ; [then]
