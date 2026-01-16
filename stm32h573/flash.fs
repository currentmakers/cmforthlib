\
\ @file flash.fs
\ @brief FLASH address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FLASH access control register
\ Address offset: 0x00
\ Reset value: 0x00000013
\

$0000000f constant FLASH_FLASH_ACR_LATENCY                          \ Read latency These bits are used to control the number of wait states used during read operations on both nonvolatile memory banks. The application software has to program them to the correct value depending on the embedded flash memory interface frequency and voltage conditions. ... Note: No check is performed by hardware to verify that the configuration is correct.
$00000030 constant FLASH_FLASH_ACR_WRHIGHFREQ                       \ Flash signal delay These bits are used to control the delay between nonvolatile memory signals during programming operations. Application software has to program them to the correct value depending on the embedded flash memory interface frequency. Please refer to Table44 for details. Note: No check is performed to verify that the configuration is correct. Note: Two WRHIGHFREQ values can be selected for some frequencies.
$00000100 constant FLASH_FLASH_ACR_PRFTEN                           \ Prefetch enable. When bit value is modified, user must read back ACR register to be sure PRFTEN has been taken into account. Bits used to control the prefetch.


\
\ @brief FLASH non-secure key register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_NSKEYR_NSKEY                         \ Non-volatile memory non-secure configuration access unlock key


\
\ @brief FLASH secure key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECKEYR_SECKEY                       \ Non-volatile memory secure configuration access unlock key


\
\ @brief FLASH option key register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OPTKEYR_OPTKEY                       \ FLASH option bytes control access unlock key


\
\ @brief FLASH non-secure OBK key register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_NSOBKKEYR_NSOBKKEY                   \ FLASH non-secure option bytes keys control access unlock key


\
\ @brief FLASH secure OBK key register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECOBKKEYR_SECOBKKEY                 \ FLASH secure option bytes keys control access unlock key


\
\ @brief FLASH operation status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000fffff constant FLASH_FLASH_OPSR_ADDR_OP                         \ Interrupted operation address
$00200000 constant FLASH_FLASH_OPSR_DATA_OP                         \ Flash high-cycle data area operation interrupted It indicates if flash high-cycle data area is concerned by operation.
$00400000 constant FLASH_FLASH_OPSR_BK_OP                           \ Interrupted operation bank It indicates which bank was concerned by operation.
$00800000 constant FLASH_FLASH_OPSR_SYSF_OP                         \ Operation in system flash memory interrupted Indicates that reset interrupted an ongoing operation in system flash.
$01000000 constant FLASH_FLASH_OPSR_OTP_OP                          \ OTP operation interrupted Indicates that reset interrupted an ongoing operation in OTP area (or OBKeys area).
$e0000000 constant FLASH_FLASH_OPSR_CODE_OP                         \ Flash memory operation code


\
\ @brief FLASH option control register
\ Address offset: 0x1C
\ Reset value: 0x00000001
\

$00000001 constant FLASH_FLASH_OPTCR_OPTLOCK                        \ FLASH_OPTCR lock option configuration bit The OPTLOCK bit locks the FLASH_OPTCR register as well as all _PRG registers. The correct write sequence to FLASH_OPTKEYR register unlocks this bit. If a wrong sequence is executed, or the unlock sequence to FLASH_OPTKEYR is performed twice, this bit remains locked until next system reset. It is possible to set OPTLOCK by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When OPTLOCK changes from 0 to 1, the others bits of FLASH_OPTCR register do not change.
$00000002 constant FLASH_FLASH_OPTCR_OPTSTRT                        \ Option byte start change option configuration bit OPTSTRT triggers an option byte change operation. The user can set OPTSTRT only when the OPTLOCK bit is cleared to 0. It is set only by Software and cleared when the option byte change is completed or an error occurs (PGSERR or OPTCHANGEERR). It is reseted at the same time as BSY bit. The user application cannot modify any FLASH_XXX_PRG flash interface register until the option change operation has been completed. Before setting this bit, the user has to write the required values in the FLASH_XXX_PRG registers. The FLASH_XXX_PRG registers are locked until the option byte change operation has been executed in nonvolatile memory.
$80000000 constant FLASH_FLASH_OPTCR_SWAP_BANK                      \ Bank swapping option configuration bit SWAP_BANK controls whether Bank1 and Bank2 are swapped or not. This bit is loaded with the SWAP_BANK bit of FLASH_OPTSR_CUR register only after reset or POR.


\
\ @brief FLASH non-secure status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_NSSR_BSY                             \ busy flag BSY flag indicates that a flash memory is busy by an operation (write, erase, option byte change, OBK operation). It is set at the beginning of a flash memory operation and cleared when the operation finishes, or an error occurs.
$00000002 constant FLASH_FLASH_NSSR_WBNE                            \ write buffer not empty flag WBNE flag is set when the flash interface is waiting for new data to complete the write buffer. In this state, the write buffer is not empty. WBNE is reset by hardware each time the write buffer is complete or the write buffer is emptied following one of the event below: the application software forces the write operation using FW bit in FLASH_NSCR the embedded flash memory detects an error that involves data loss This bit cannot be reset by software writing 0 directly. To reset it, clear the write buffer by performing any of the above listed actions, or send the missing data.
$00000008 constant FLASH_FLASH_NSSR_DBNE                            \ data buffer not empty flag DBNE flag is set when the flash interface is processing 6-bits ECC data in dedicated buffer. This bit cannot be set to 0 by software. The hardware resets it once the buffer is free.
$00010000 constant FLASH_FLASH_NSSR_EOP                             \ end of operation flag EOP flag is set when a operation (program/erase) completes. An interrupt is generated if the EOPIE is set to 1. It is not necessary to reset EOP before starting a new operation. EOP bit is cleared by writing 1 to CLR_EOP bit in FLASH_NSCCR register.
$00020000 constant FLASH_FLASH_NSSR_WRPERR                          \ write protection error flag WRPERR flag is raised when a protection error occurs during a program operation. An interrupt is also generated if the WRPERRIE is set to 1. Writing 1 to CLR_WRPERR bit in FLASH_NSCCR register clears WRPERR.
$00040000 constant FLASH_FLASH_NSSR_PGSERR                          \ programming sequence error flag PGSERR flag is raised when a sequence error occurs. An interrupt is generated if the PGSERRIE bit is set to 1. Writing 1 to CLR_PGSERR bit in FLASH_NSCCR register clears PGSERR.
$00080000 constant FLASH_FLASH_NSSR_STRBERR                         \ strobe error flag STRBERR flag is raised when a strobe error occurs (when the master attempts to write several times the same byte in the write buffer). An interrupt is generated if the STRBERRIE bit is set to 1. Writing 1 to CLR_STRBERR bit in FLASH_NSCCR register clears STRBERR.
$00100000 constant FLASH_FLASH_NSSR_INCERR                          \ inconsistency error flag NSINCERR flag is raised when a inconsistency error occurs. An interrupt is generated if INCERRIE is set to 1. Writing 1 to CLR_INCERR bit in the FLASH_NSCCR register clears NSINCERR.
$00200000 constant FLASH_FLASH_NSSR_OBKERR                          \ OBK general error flag OBKERR flag is raised when the OBK-HDPL signal from the SBS does not match the HDPL value associated with the key slot during access to the key location. Alternatively also when the ALT_SECT is unexpectedly changed while the write buffer is being filled.
$00400000 constant FLASH_FLASH_NSSR_OBKWERR                         \ OBK write error flag OBKWERR flag is raised when the address is not virgin on a write access to the OBK storage. Alternatively also when the OBK selector in the alternate sector is not virgin during a swap operation.
$00800000 constant FLASH_FLASH_NSSR_OPTCHANGEERR                    \ Option byte change error flag OPTCHANGEERR flag indicates that an error occurred during an option byte change operation. When OPTCHANGEERR is set to 1, the option byte change operation did not successfully complete. An interrupt is generated when this flag is raised if the OPTCHANGEERRIE bit of FLASH_NSCR register is set to 1. Writing 1 to CLR_OPTCHANGEERR of register FLASH_NSCCR clears OPTCHANGEERR. Note: The OPTSTRT bit in FLASH_OPTCR cannot be set while OPTCHANGEERR is set.


\
\ @brief FLASH secure status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SECSR_BSY                            \ busy flag BSY flag indicates that a FLASH memory is busy (write, erase, option byte change, OBK operations). It is set at the beginning of a flash memory operation and cleared when the operation finishes or an error occurs.
$00000002 constant FLASH_FLASH_SECSR_WBNE                           \ write buffer not empty flag WBNE flag is set when the flash interface is waiting for new data to complete the write buffer. In this state, the write buffer is not empty. WBNE is reset by hardware each time the write buffer is complete or the write buffer is emptied following one of the event below: the application software forces the write operation using FW bit in FLASH_SECCR the flash interface detects an error that involves data loss This bit cannot be reset by writing 0 directly by software. To reset it, clear the write buffer by performing any of the above listed actions, or send the missing data.
$00000008 constant FLASH_FLASH_SECSR_DBNE                           \ data buffer not empty flag DBNE flag is set when the embedded flash memory interface is processing 6-bits ECC data in dedicated buffer. This bit cannot be set to 0 by software. The hardware resets it once the buffer is free.
$00010000 constant FLASH_FLASH_SECSR_EOP                            \ end of operation flag EOP flag is set when a operation (program/erase) completes. An interrupt is generated if the EOPIE is set to. It is not necessary to reset EOP before starting a new operation. EOP bit is cleared by writing 1 to CLR_EOP bit in FLASH_SECCCR register.
$00020000 constant FLASH_FLASH_SECSR_WRPERR                         \ write protection error flag WRPERR flag is raised when a protection error occurs during a program operation. An interrupt is also generated if the WRPERRIE is set to 1. Writing 1 to CLR_WRPERR bit in FLASH_SECCCR register clears WRPERR.
$00040000 constant FLASH_FLASH_SECSR_PGSERR                         \ programming sequence error flag PGSERR flag is raised when a sequence error occurs. An interrupt is generated if the PGSERRIE bit is set to 1. Writing 1 to CLR_PGSERR bit in FLASH_SECCCR register clears PGSERR.
$00080000 constant FLASH_FLASH_SECSR_STRBERR                        \ strobe error flag STRBERR flag is raised when a strobe error occurs (when the master attempts to write several times the same byte in the write buffer). An interrupt is generated if the STRBERRIE bit is set to 1. Writing 1 to CLR_STRBERR bit in FLASH_SECCCR register clears STRBERR.
$00100000 constant FLASH_FLASH_SECSR_INCERR                         \ inconsistency error flag INCERR flag is raised when a inconsistency error occurs. An interrupt is generated if INCERRIE is set to 1. Writing 1 to CLR_INCERR bit in the FLASH_SECCCR register clears INCERR.
$00200000 constant FLASH_FLASH_SECSR_OBKERR                         \ OBK general error flag OBKERR flag is raised when the OBK-HDPL signal from the SBS does not match the HDPL value associated with the key slot during access to the key location. Alternatively also when the ALT_SECT is unexpectedly changed while the write buffer is being filled.
$00400000 constant FLASH_FLASH_SECSR_OBKWERR                        \ OBK write error flag OBKWERR flag is raised when the address is not virgin on a write access to the OBK storage. Alternatively also when the OBK selector in the alternate sector is not virgin during a swap operation.


\
\ @brief FLASH non-secure control register
\ Address offset: 0x28
\ Reset value: 0x00000001
\

$00000001 constant FLASH_FLASH_NSCR_LOCK                            \ configuration lock bit This bit locks the FLASH_NSCR register. The correct write sequence to FLASH_NSKEYR register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_NSKEYR is performed twice, this bit remains locked until the next system reset. LOCK can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK changes from 0 to 1, the other bits of FLASH_NSCR register do not change.
$00000002 constant FLASH_FLASH_NSCR_PG                              \ programming control bit PG can be programmed only when LOCK is cleared to 0. PG allows programming in Bank1 and Bank2.
$00000004 constant FLASH_FLASH_NSCR_SER                             \ sector erase request Setting SER bit to 1 requests a sector erase. SER can be programmed only when LOCK is cleared to 0. If MER and SER are also set, a PGSERR is raised.
$00000008 constant FLASH_FLASH_NSCR_BER                             \ erase request Setting BER bit to 1 requests a bank erase operation (user flash memory only). BER can be programmed only when LOCK is cleared to 0. If MER and SER are also set, a PGSERR is raised. Note: Write protection error is triggered when a bank erase is required and some sectors are protected.
$00000010 constant FLASH_FLASH_NSCR_FW                              \ write forcing control bit FW forces a write operation even if the write buffer is not full. In this case all bits not written are set to 1 by hardware. FW can be programmed only when LOCK is cleared to 0. The embedded flash memory resets FW when the corresponding operation has been acknowledged. Note: Using a force-write operation prevents the application from updating later the missing bits with something else than 1, because it is likely that it leads to permanent ECC error. Write forcing is effective only if the write buffer is not empty and was filled by non-secure access (in particular, FW does not start several write operations when the force-write operations are performed consecutively). Since there is just one write buffer, FW can force a write in bank1 or bank2.
$00000020 constant FLASH_FLASH_NSCR_STRT                            \ erase start control bit STRT bit is used to start a sector erase or a bank erase operation. STRT can be programmed only when LOCK is cleared to 0. STRT is reset at the end of the operation or when an error occurs. It cannot be reseted by software.
$00001fc0 constant FLASH_FLASH_NSCR_SNB                             \ sector erase selection number These bits are used to select the target sector for an erase operation (they are unused otherwise). SNB can be programmed only when LOCK is cleared to 0. ..
$00008000 constant FLASH_FLASH_NSCR_MER                             \ Mass erase request Setting MER bit to 1 requests a mass erase operation (user flash memory only). MER can be programmed only when LOCK is cleared to 0. If BER or SER are both set, a PGSERR is raised. Error is triggered when a mass erase is required and some sectors are protected.
$00010000 constant FLASH_FLASH_NSCR_EOPIE                           \ end of operation interrupt control bit Setting EOPIE bit to 1 enables the generation of an interrupt at the end of a program or erase operation. EOPIE can be programmed only when LOCK is cleared to 0.
$00020000 constant FLASH_FLASH_NSCR_WRPERRIE                        \ write protection error interrupt enable bit When this bit is set to 1, an interrupt is generated when a protection error occurs during a program operation. WRPERRIE can be programmed only when LOCK is cleared to 0.
$00040000 constant FLASH_FLASH_NSCR_PGSERRIE                        \ programming sequence error interrupt enable bit When this bit is set to 1, an interrupt is generated when a sequence error occurs during a program operation. PGSERRIE can be programmed only when LOCK is cleared to 0.
$00080000 constant FLASH_FLASH_NSCR_STRBERRIE                       \ strobe error interrupt enable bit When STRBERRIE bit is set to 1, an interrupt is generated when a strobe error occurs (the master programs several times the same byte in the write buffer) during a write operation. STRBERRIE can be programmed only when LOCK is cleared to 0.
$00100000 constant FLASH_FLASH_NSCR_INCERRIE                        \ inconsistency error interrupt enable bit When INCERRIE bit is set to 1, an interrupt is generated when an inconsistency error occurs during a write operation. INCERRIE can be programmed only when LOCK is cleared to 0.
$00200000 constant FLASH_FLASH_NSCR_OBKERRIE                        \ OBK general error interrupt enable bit OBKERRIE enables generating an interrupt in case of OBK specific access error. This bit can be programmed only when LOCK bit is cleared to 0.
$00400000 constant FLASH_FLASH_NSCR_OBKWERRIE                       \ OBK write error interrupt enable bit OBKWERRIE enables generation of interrupt in case of OBK specific write error. This bit can be programmed only when LOCK bit is cleared to 0.
$00800000 constant FLASH_FLASH_NSCR_OPTCHANGEERRIE                  \ Option byte change error interrupt enable bit This bit controls if an interrupt must be generated when an error occurs during an option byte change. It can be programmed only when LOCK bit is cleared to 0.
$80000000 constant FLASH_FLASH_NSCR_BKSEL                           \ Bank selector bit BKSEL can only be programmed when LOCK is cleared to 0. The bit selects physical bank, SWAP_BANK setting is ignored.


\
\ @brief FLASH secure control register
\ Address offset: 0x2C
\ Reset value: 0x00000001
\

$00000001 constant FLASH_FLASH_SECCR_LOCK                           \ configuration lock bit This bit locks the FLASH_SECCR register. The correct write sequence to FLASH_SECKEYR register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_NSKEYR is performed twice, this bit remains locked until the next system reset. LOCK can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK changes from 0 to 1, the other bits of FLASH_SECCR register do not change.
$00000002 constant FLASH_FLASH_SECCR_PG                             \ programming control bit PG can be programmed only when LOCK is cleared to 0. PG allows programming in Bank1 and Bank2.
$00000004 constant FLASH_FLASH_SECCR_SER                            \ sector erase request Setting SER bit to 1 requests a sector erase. SER can be programmed only when LOCK is cleared to 0. If BER and MER are also set, a PGSERR is raised.
$00000008 constant FLASH_FLASH_SECCR_BER                            \ erase request Setting BER bit to 1 requests a bank erase operation (user flash memory only). BER can be programmed only when LOCK is cleared to 0. If MER and SER are also set, a PGSERR is raised. Note: Write protection error is triggered when a bank erase is required and some sectors are protected.
$00000010 constant FLASH_FLASH_SECCR_FW                             \ write forcing control bit FW forces a write operation even if the write buffer is not full. In this case all bits not written are set to 1 by hardware. FW can be programmed only when LOCK is cleared to 0. The embedded flash memory resets FW when the corresponding operation has been acknowledged. Note: Using a force-write operation prevents the application from updating later the missing bits with something else than 1, because it is likely that it leads to permanent ECC error. Write forcing is effective only if the write buffer is not empty and was filled by secure access (in particular, FW does not start several write operations when the force-write operations are performed consecutively). Since there is just one write buffer, FW can force a write in bank1 or bank2.
$00000020 constant FLASH_FLASH_SECCR_STRT                           \ erase start control bit STRT bit is used to start a sector erase or a bank erase operation. STRT can be programmed only when LOCK is cleared to 0. STRT is reseted at the end of the operation or when an error occurs. It cannot be reset by software.
$00001fc0 constant FLASH_FLASH_SECCR_SNB                            \ sector erase selection number These bits are used to select the target sector for an erase operation (they are unused otherwise). SNB can be programmed only when LOCK is cleared to 0. ..
$00008000 constant FLASH_FLASH_SECCR_MER                            \ mass erase request Setting MER bit to 1 requests a mass erase operation (user flash memory only). MER can be programmed only when LOCK is cleared to 0. If BER or SER are also set, a PGSERR is raised. Error is triggered when a mass erase is required and some sectors are protected.
$00010000 constant FLASH_FLASH_SECCR_EOPIE                          \ end of operation interrupt control bit Setting EOPIE bit to 1 enables the generation of an interrupt at the end of a program/erase operation. EOPIE can be programmed only when LOCK is cleared to 0.
$00020000 constant FLASH_FLASH_SECCR_WRPERRIE                       \ write protection error interrupt enable bit When WRPERRIE bit is set to 1, an interrupt is generated when a protection error occurs during a program operation. WRPERRIE can be programmed only when LOCK is cleared to 0.
$00040000 constant FLASH_FLASH_SECCR_PGSERRIE                       \ programming sequence error interrupt enable bit When PGSERRIE bit is set to 1, an interrupt is generated when a sequence error occurs during a program operation. PGSERRIE can be programmed only when LOCK is cleared to 0.
$00080000 constant FLASH_FLASH_SECCR_STRBERRIE                      \ strobe error interrupt enable bit When STRBERRIE bit is set to 1, an interrupt is generated when a strobe error occurs (the master programs several times the same byte in the write buffer) during a write operation. STRBERRIE can be programmed only when LOCK is cleared to 0.
$00100000 constant FLASH_FLASH_SECCR_INCERRIE                       \ inconsistency error interrupt enable bit When INCERRIE bit is set to 1, an interrupt is generated when an inconsistency error occurs during a write operation. INCERRIE can be programmed only when LOCK is cleared to 0.
$00200000 constant FLASH_FLASH_SECCR_OBKERRIE                       \ OBK general error interrupt enable bit OBKERRIE enables generating an interrupt in case of OBK specific access error. OBKERRIE can be programmed only when LOCK is cleared to 0.
$00400000 constant FLASH_FLASH_SECCR_OBKWERRIE                      \ OBK write error interrupt enable bit OBKWERRIE enables generation of interrupt in case of OBK specific write error. OBKWERRIE can be programmed only when LOCK is cleared to 0.
$20000000 constant FLASH_FLASH_SECCR_INV                            \ Flash memory security state invert. This bit inverts the flash memory security state.
$80000000 constant FLASH_FLASH_SECCR_BKSEL                          \ bank selector bit BKSEL can only be programmed when LOCK is cleared to 0. The bit selects physical bank, SWAP_BANK setting is ignored.


\
\ @brief FLASH non-secure clear control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00010000 constant FLASH_FLASH_NSCCR_CLR_EOP                        \ EOP flag clear bit Setting this bit to 1 resets to 0 EOP flag in FLASH_NSSR register.
$00020000 constant FLASH_FLASH_NSCCR_CLR_WRPERR                     \ WRPERR flag clear bit Setting this bit to 1 resets to 0 WRPERR flag in FLASH_NSSR register.
$00040000 constant FLASH_FLASH_NSCCR_CLR_PGSERR                     \ PGSERR flag clear bit Setting this bit to 1 resets to 0 PGSERR flag in FLASH_NSSR register.
$00080000 constant FLASH_FLASH_NSCCR_CLR_STRBERR                    \ STRBERR flag clear bit Setting this bit to 1 resets to 0 STRBERR flag in FLASH_NSSR register.
$00100000 constant FLASH_FLASH_NSCCR_CLR_INCERR                     \ INCERR flag clear bit Setting this bit to 1 resets to 0 INCERR flag in FLASH_NSSR register.
$00200000 constant FLASH_FLASH_NSCCR_CLR_OBKERR                     \ OBKERR flag clear bit. Setting this bit to 1 resets to 0 OBKERR flag in FLASH_NSSR register.
$00400000 constant FLASH_FLASH_NSCCR_CLR_OBKWERR                    \ OBKWERR flag clear bit. Setting this bit to 1 resets to 0 OBKWERR flag in FLASH_NSSR register.
$00800000 constant FLASH_FLASH_NSCCR_CLR_OPTCHANGEERR               \ Clear the flag corresponding flag in FLASH_NSSR by writing this bit.


\
\ @brief FLASH secure clear control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00010000 constant FLASH_FLASH_SECCCR_CLR_EOP                       \ EOP flag clear bit Setting this bit to 1 resets to 0 EOP flag in FLASH_SECSR register.
$00020000 constant FLASH_FLASH_SECCCR_CLR_WRPERR                    \ WRPERR flag clear bit Setting this bit to 1 resets to 0 WRPERR flag in FLASH_SECSR register.
$00040000 constant FLASH_FLASH_SECCCR_CLR_PGSERR                    \ PGSERR flag clear bit Setting this bit to 1 resets to 0 PGSERR flag in FLASH_SECSR register.
$00080000 constant FLASH_FLASH_SECCCR_CLR_STRBERR                   \ STRBERR flag clear bit Setting this bit to 1 resets to 0 STRBERR flag in FLASH_SECSR register.
$00100000 constant FLASH_FLASH_SECCCR_CLR_INCERR                    \ INCERR flag clear bit Setting this bit to 1 resets to 0 INCERR flag in FLASH_SECSR register.
$00200000 constant FLASH_FLASH_SECCCR_CLR_OBKERR                    \ OBKWERR flag clear bit Setting this bit to 1 resets to 0 OBKWERR flag in FLASH_SECSR register.
$00400000 constant FLASH_FLASH_SECCCR_CLR_OBKWERR                   \ OBKWERR flag clear bit Setting this bit to 1 resets to 0 OBKWERR flag in FLASH_SECSR register.


\
\ @brief FLASH privilege configuration register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_PRIVCFGR_SPRIV                       \ privilege attribute for secure registers
$00000002 constant FLASH_FLASH_PRIVCFGR_NSPRIV                      \ privilege attribute for non secure registers


\
\ @brief FLASH non-secure OBK configuration register
\ Address offset: 0x40
\ Reset value: 0x01FF0000
\

$00000001 constant FLASH_FLASH_NSOBKCFGR_LOCK                       \ OBKCFGR lock option configuration bit This bit locks the FLASH_NSOBKCFGR register. The correct write sequence to FLASH_NSOBKKEYR register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_NSOBKKEYR is performed twice, this bit remains locked until the next system reset. LOCK can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK changes from 0 to 1, the other bits of FLASH_NSCR register do not change.
$00000002 constant FLASH_FLASH_NSOBKCFGR_SWAP_SECT_REQ              \ OBK swap sector request bit When set, all the OBKs which have not been updated in the alternate sector is copied from current sector to alternate one. The SWAP_OFFSET value must be a certain minimum value in order for the swap to be launched in OBK-HDPLdifferent 0. Minimum value is 16 for OBK-HDPL=1, 144 for OBK-HDPL=2 and192 for OBK-HDPL=3.
$00000004 constant FLASH_FLASH_NSOBKCFGR_ALT_SECT                   \ alternate sector bit This bit must not change while filling the write buffer, otherwise an error (OBKERR) is generated
$00000008 constant FLASH_FLASH_NSOBKCFGR_ALT_SECT_ERASE             \ alternate sector erase bit When ALT_SECT bit is set, use this bit to generate an erase command for the OBK alternate sector. It is set only by Software and cleared when the OBK swap operation is completed or an error occurs (PGSERR). It is reseted at the same time as BUSY bit.
$01ff0000 constant FLASH_FLASH_NSOBKCFGR_SWAP_OFFSET                \ Key index (offset /16 bits) pointing for next swap. 0x01 means that only the first OBK data (128 bits) is copied from current to alternate OBK sector 0x02 means that the two first OBK data is copied


\
\ @brief FLASH secure OBK configuration register
\ Address offset: 0x44
\ Reset value: 0x01FF0000
\

$00000001 constant FLASH_FLASH_SECOBKCFGR_LOCK                      \ OBKCFGR lock option configuration bit This bit locks the FLASH_OBKCFGR register. The correct write sequence to FLASH_SECOBKKEYR register unlocks this bit. If a wrong sequence is executed, or if the unlock sequence to FLASH_SECOBKKEYR is performed twice, this bit remains locked until the next system reset. LOCK can be set by programming it to 1. When set to 1, a new unlock sequence is mandatory to unlock it. When LOCK changes from 0 to 1, the other bits of FLASH_NSCR register do not change.
$00000002 constant FLASH_FLASH_SECOBKCFGR_SWAP_SECT_REQ             \ OBK swap sector request bit When set, all the OBKs which have not been updated in the alternate sector is copied from current sector to alternate one. The SWAP_OFFSET value must be a certain minimum value in order for the swap to be launched in OBK-HDPLdifferent 0. Minimum value is 16 for OBK-HDPL=1, 144 for OBK-HDPL=2 and 192 for OBK-HDPL=3.
$00000004 constant FLASH_FLASH_SECOBKCFGR_ALT_SECT                  \ alternate sector bit This bit must not change while filling the write buffer, otherwise an error is generated
$00000008 constant FLASH_FLASH_SECOBKCFGR_ALT_SECT_ERASE            \ alternate sector erase bit When ALT_SECT bit is set, use this bit to generate an erase command for the OBK alternate sector. It is set only by Software and cleared when the OBK swap operation is completed or an error occurs (PGSERR). It is reseted at the same time as the BUSY bit.
$01ff0000 constant FLASH_FLASH_SECOBKCFGR_SWAP_OFFSET               \ key index (offset /16 bits) pointing for next swap.


\
\ @brief FLASH HDP extension register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_HDPEXTR_HDP1_EXT                     \ HDP area extension in 8Kbytes sectors in Bank1. Extension is added after the HDP1_END sector (included).
$007f0000 constant FLASH_FLASH_HDPEXTR_HDP2_EXT                     \ HDP area extension in 8Kbytes sectors in bank 2. Extension is added after the HDP2_END sector (included).


\
\ @brief FLASH option status register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant FLASH_FLASH_OPTSR_CUR_BOR_LEV                    \ Brownout level option status bit These bits reflects the power level that generates a system reset. 00 or 11: BOR Level 1, the threshold level is low (around 2.1V)
$00000004 constant FLASH_FLASH_OPTSR_CUR_BORH_EN                    \ Brownout high enable
$00000008 constant FLASH_FLASH_OPTSR_CUR_IWDG_SW                    \ IWDG control mode option status bit
$00000010 constant FLASH_FLASH_OPTSR_CUR_WWDG_SW                    \ WWDG control mode option status bit
$00000040 constant FLASH_FLASH_OPTSR_CUR_NRST_STOP                  \ Core domain Stop entry reset option status bit
$00000080 constant FLASH_FLASH_OPTSR_CUR_NRST_STDBY                 \ Core domain Standby entry reset option status bit
$0000ff00 constant FLASH_FLASH_OPTSR_CUR_PRODUCT_STATE              \ Life state code (based on Hamming 8,4). More information in Section7.6.11: Product state transitions.
$00010000 constant FLASH_FLASH_OPTSR_CUR_IO_VDD_HSLV                \ High-speed IO at low V sub DD /sub voltage configuration bit. This bit can be set only with V sub DD /sub below 2.7V.
$00020000 constant FLASH_FLASH_OPTSR_CUR_IO_VDDIO2_HSLV             \ High-speed IO at low V sub DDIO2 /sub voltage configuration bit. This bit can be set only with V sub DDIO2 /sub below 2.7V.
$00100000 constant FLASH_FLASH_OPTSR_CUR_IWDG_STOP                  \ IWDG Stop mode freeze option status bit When set the independent watchdog IWDG is in system Stop mode.
$00200000 constant FLASH_FLASH_OPTSR_CUR_IWDG_STDBY                 \ IWDG Standby mode freeze option status bit When set the independent watchdog IWDG is frozen in system Standby mode.
$3fc00000 constant FLASH_FLASH_OPTSR_CUR_BOOT_UBE                   \ Available only on cryptography enabled devices. Unique boot entry control, selects either ST or OEM iRoT for secure boot.
$80000000 constant FLASH_FLASH_OPTSR_CUR_SWAP_BANK                  \ Bank swapping option status bit SWAP_BANK reflects whether Bank1 and Bank2 are swapped or not. SWAP_BANK is loaded to SWAP_BANK of FLASH_OPTCR after a reset.


\
\ @brief FLASH option status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000003 constant FLASH_FLASH_OPTSR_PRG_BOR_LEV                    \ Brownout level option configuration bit These bits reflects the power level that generates a system reset. 00 or 11: BOR Level 1, the threshold level is low (around 2.1 V)
$00000004 constant FLASH_FLASH_OPTSR_PRG_BORH_EN                    \ Brownout high enable configuration bit
$00000008 constant FLASH_FLASH_OPTSR_PRG_IWDG_SW                    \ IWDG control mode option configuration bit
$00000010 constant FLASH_FLASH_OPTSR_PRG_WWDG_SW                    \ WWDG control mode option configuration bit
$00000040 constant FLASH_FLASH_OPTSR_PRG_NRST_STOP                  \ Core domain Stop entry reset option configuration bit
$00000080 constant FLASH_FLASH_OPTSR_PRG_NRST_STDBY                 \ Core domain Standby entry reset option configuration bit
$0000ff00 constant FLASH_FLASH_OPTSR_PRG_PRODUCT_STATE              \ Life state code (based on Hamming 8,4). More information in Section7.6.11: Product state transitions.
$00010000 constant FLASH_FLASH_OPTSR_PRG_IO_VDD_HSLV                \ High-speed IO at low VDD voltage configuration bit. This bit can be set only with VDD below 2.7V.
$00020000 constant FLASH_FLASH_OPTSR_PRG_IO_VDDIO2_HSLV             \ High-speed IO at low VDDIO2 voltage configuration bit. This bit can be set only with VDDIO2 below 2.7V.
$00100000 constant FLASH_FLASH_OPTSR_PRG_IWDG_STOP                  \ IWDG Stop mode freeze option status bit When set the independent watchdog IWDG is in system Stop mode.
$00200000 constant FLASH_FLASH_OPTSR_PRG_IWDG_STDBY                 \ IWDG Standby mode freeze option status bit When set the independent watchdog IWDG is frozen in system Standby mode.
$3fc00000 constant FLASH_FLASH_OPTSR_PRG_BOOT_UBE                   \ Available only on cryptography enabled devices. Unique boot entry control, selects either ST or OEM iRoT for secure boot. In Open PRODUCT_STATE this value selects bootloader. Defaut value.
$80000000 constant FLASH_FLASH_OPTSR_PRG_SWAP_BANK                  \ Bank swapping option configuration bit SWAP_BANK option bit is used to configure whether the Bank1 and Bank2 are swapped or not. This bit is loaded with the SWAP_BANK bit of FLASH_OPTSR_CUR register after a reset.


\
\ @brief FLASH non-secure EPOCH register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00ffffff constant FLASH_FLASH_NSEPOCHR_CUR_NS_EPOCH                \ Non-volatile non-secure EPOCH counter


\
\ @brief FLASH secure EPOCH register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00ffffff constant FLASH_FLASH_SECEPOCHR_CUR_SEC_EPOCH              \ Non-volatile secure EPOCH counter


\
\ @brief FLASH option status register 2
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000004 constant FLASH_FLASH_OPTSR2_CUR_SRAM13_RST                \ SRAM1 and SRAM3 erase upon system reset
$00000008 constant FLASH_FLASH_OPTSR2_CUR_SRAM2_RST                 \ SRAM2 erase when system reset
$00000010 constant FLASH_FLASH_OPTSR2_CUR_BKPRAM_ECC                \ Backup RAM ECC detection and correction disable
$00000020 constant FLASH_FLASH_OPTSR2_CUR_SRAM3_ECC                 \ SRAM3 ECC detection and correction disable
$00000040 constant FLASH_FLASH_OPTSR2_CUR_SRAM2_ECC                 \ SRAM2 ECC detection and correction disable
$00000100 constant FLASH_FLASH_OPTSR2_CUR_USBPD_DIS                 \ USB power delivery configuration option bit
$ff000000 constant FLASH_FLASH_OPTSR2_CUR_TZEN                      \ TrustZone enable configuration bits This bit enables the device is in TrustZone mode during an option byte change.


\
\ @brief FLASH option status register 2
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000004 constant FLASH_FLASH_OPTSR2_PRG_SRAM1_3_RST               \ SRAM1 and SRAM3 erase upon system reset Note: SRAM erase is triggered by option byte change operation, when enabling this feature.
$00000008 constant FLASH_FLASH_OPTSR2_PRG_SRAM2_RST                 \ SRAM2 erase when system reset Note: SRAM erase is triggered by option byte change operation, when enabling this feature.
$00000010 constant FLASH_FLASH_OPTSR2_PRG_BKPRAM_ECC                \ Backup RAM ECC detection and correction disable
$00000020 constant FLASH_FLASH_OPTSR2_PRG_SRAM3_ECC                 \ SRAM3 ECC detection and correction disable
$00000040 constant FLASH_FLASH_OPTSR2_PRG_SRAM2_ECC                 \ SRAM2 ECC detection and correction disable
$00000100 constant FLASH_FLASH_OPTSR2_PRG_USBPD_DIS                 \ USB power delivery configuration option bit
$ff000000 constant FLASH_FLASH_OPTSR2_PRG_TZEN                      \ TrustZone enable configuration bits This bit enables the device is in TrustZone mode during an option byte change.


\
\ @brief FLASH non-secure boot register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_NSBOOTR_CUR_NSBOOT_LOCK              \ A field locking the values of SWAP_BANK, and NSBOOTADD settings.
$ffffff00 constant FLASH_FLASH_NSBOOTR_CUR_NSBOOTADD                \ Non secure unique boot entry address These bits reflect the Non secure UBE address


\
\ @brief FLASH non-secure boot register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_NSBOOTR_PRG_NSBOOT_LOCK              \ A field locking the values of SWAP_ BANK, and NSBOOTADD settings.
$ffffff00 constant FLASH_FLASH_NSBOOTR_PRG_NSBOOTADD                \ Non secure unique boot entry address These bits allow configuring the Non secure BOOT address


\
\ @brief FLASH secure boot register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_SECBOOTR_CUR_SECBOOT_LOCK            \ A field locking the values of UBE, SWAP_BANK, and SECBOOTADD settings.
$ffffff00 constant FLASH_FLASH_SECBOOTR_CUR_SECBOOTADD              \ Unique boot entry secure address These bits reflect the Secure UBE address


\
\ @brief FLASH secure boot register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_BOOTR_PRG_SECBOOT_LOCK               \ A field locking the values of UBE, SWAP_ BANK, and SECBOOTADD setting.
$ffffff00 constant FLASH_FLASH_BOOTR_PRG_SECBOOTADD                 \ Secure unique boot entry address. These bits allow configuring the secure UBE address.


\
\ @brief FLASH non-secure OTP block lock
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OTPBLR_CUR_LOCKBL                    \ OTP block lock Block n corresponds to OTP 16-bit word 32 x n to 32 x n + 31. LOCKBL[n] = 1 indicates that all OTP 16-bit words in OTP Block n are locked and attempt to program them results in WRPERR. LOCKBL[n] = 0 indicates that all OTP 16-bit words in OTP Block n are not locked. When one block is locked, it's not possible to remove the write protection. Also if not locked, it is not possible to erase OTP words.


\
\ @brief FLASH non-secure OTP block lock
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OTPBLR_PRG_LOCKBL                    \ OTP block lock Block n corresponds to OTP 16-bit word 32 x n to 32 x n + 31. LOCKBL[n] = 1 indicates that all OTP 16-bit words in OTP Block n are locked and attempt to program them results in WRPERR. LOCKBL[n] = 0 indicates that all OTP 16-bit words in OTP Block n are not locked. When one block is locked, it is not possible to remove the write protection. LOCKBL bits can be set if the corresponding bit in FLASH_OTPBLR_CUR is cleared.


\
\ @brief FLASH secure block based register for Bank 1
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECBB1R1_SECBB1                      \ Secure/non-secure 8Kbytes flash Bank 1 sector attributes


\
\ @brief FLASH secure block based register for Bank 1
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECBB1R2_SECBB1                      \ Secure/non-secure 8Kbytes flash Bank 1 sector attributes


\
\ @brief FLASH secure block based register for Bank 1
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECBB1R3_SECBB1                      \ Secure/non-secure 8Kbytes flash Bank 1 sector attributes


\
\ @brief FLASH secure block based register for Bank 1
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECBB1R4_SECBB1                      \ Secure/non-secure 8Kbytes flash Bank 1 sector attributes


\
\ @brief FLASH privilege block based register for Bank 1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PRIVBB1R1_PRIVBB1                    \ Privileged/unprivileged 8-Kbyte flash Bank 1 sector attribute


\
\ @brief FLASH privilege block based register for Bank 1
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PRIVBB1R2_PRIVBB1                    \ Privileged/unprivileged 8-Kbyte flash Bank 1 sector attribute


\
\ @brief FLASH privilege block based register for Bank 1
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PRIVBB1R3_PRIVBB1                    \ Privileged/unprivileged 8-Kbyte flash Bank 1 sector attribute


\
\ @brief FLASH privilege block based register for Bank 1
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PRIVBB1R4_PRIVBB1                    \ Privileged/unprivileged 8-Kbyte flash Bank 1 sector attribute


\
\ @brief FLASH security watermark for Bank 1
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_SECWM1R_CUR_SECWM1_STRT              \ Bank1 security WM area 1 start sector
$007f0000 constant FLASH_FLASH_SECWM1R_CUR_SECWM1_END               \ Bank1 security WM area 1 end sector


\
\ @brief FLASH security watermark for Bank 1
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_SECWM1R_PRG_SECWM1_STRT              \ Bank1 security WM area 1 start sector
$007f0000 constant FLASH_FLASH_SECWM1R_PRG_SECWM1_END               \ Bank1 security WM area 1 end sector


\
\ @brief FLASH write sector group protection for Bank 1
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_WRP1R_CUR_WRPSG1                     \ Bank 1 sector group protection option status byte Each FLASH_WRP1R_CUR bit reflects the write protection status of the corresponding group of four consecutive sectors in bank 1 (0: the group is write protected; 1: the group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127


\
\ @brief FLASH write sector group protection for Bank 1
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_WRP1R_PRG_WRPSG1                     \ Bank1 sector group protection option status byte Setting WRPSG1 bits to 0 write protects the corresponding group of four consecutive sectors in bank 1 (0: the group is write protected; 1: the group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127


\
\ @brief FLASH data sector configuration Bank 1
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000007 constant FLASH_FLASH_EDATA1R_CUR_EDATA1_STRT              \ EDATA1_STRT contains the start sectors of the flash high-cycle data area in Bank1 There is no hardware effect to those bits. They shall be managed by ST tools in Flasher. ...
$00008000 constant FLASH_FLASH_EDATA1R_CUR_EDATA1_EN                \ Bank1 flash high-cycle data enable


\
\ @brief FLASH data sector configuration Bank 1
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000007 constant FLASH_FLASH_EDATA1R_PRG_EDATA1_STRT              \ EDATA1_STRT contains the start sectors of the flash high-cycle data area in Bank 1 There is no hardware effect to those bits. They shall be managed by ST tools in Flasher. ... Note: 111: The eight last sectors of the Bank 1 are reserved for flash high-cycle data
$00008000 constant FLASH_FLASH_EDATA1R_PRG_EDATA1_EN                \ Bank 1 flash high-cycle data enable


\
\ @brief FLASH HDP Bank 1 configuration
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_HDP1R_CUR_HDP1_STRT                  \ HDPL barrier start set in number of 8-Kbyte sectors
$007f0000 constant FLASH_FLASH_HDP1R_CUR_HDP1_END                   \ HDPL barrier end set in number of 8-Kbyte sectors


\
\ @brief FLASH HDP Bank 1 configuration
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_HDP1R_PRG_HDP1_STRT                  \ HDPL barrier start set in number of 8-Kbyte sectors
$007f0000 constant FLASH_FLASH_HDP1R_PRG_HDP1_END                   \ HDPL barrier end set in number of 8-Kbyte sectors


\
\ @brief FLASH ECC correction register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_FLASH_ECCCORR_ADDR_ECC                     \ ECC error address When an ECC error occurs (for single correction) during a read operation, the ADDR_ECC contains the address that generated the error. ADDR_ECC is reset when the flag error is reset. The flash interface programs the address in this register only when no ECC error flags are set. This means that only the first address that generated an ECC error is saved. The address in ADDR_ECC is relative to the flash memory area where the error occurred (user flash memory, system flash memory, data area, read-only/OTP area).
$00100000 constant FLASH_FLASH_ECCCORR_OBK_ECC                      \ Single ECC error corrected in flash OB Keys storage area. It indicates the OBK storage concerned by ECC error.
$00200000 constant FLASH_FLASH_ECCCORR_EDATA_ECC                    \ ECC fail for corrected ECC error in flash high-cycle data area It indicates if flash high-cycle data area is concerned by ECC error.
$00400000 constant FLASH_FLASH_ECCCORR_BK_ECC                       \ ECC fail bank for corrected ECC error It indicates which bank is concerned by ECC error
$00800000 constant FLASH_FLASH_ECCCORR_SYSF_ECC                     \ ECC fail for corrected ECC error in system flash memory It indicates if system flash memory is concerned by ECC error.
$01000000 constant FLASH_FLASH_ECCCORR_OTP_ECC                      \ OTP ECC error bit This bit is set to 1 when one single ECC correction occurred during the last successful read operation from the read-only/ OTP area. The address of the ECC error is available in ADDR_ECC bitfield.
$02000000 constant FLASH_FLASH_ECCCORR_ECCCIE                       \ ECC single correction error interrupt enable bit When ECCCIE bit is set to 1, an interrupt is generated when an ECC single correction error occurs during a read operation.
$40000000 constant FLASH_FLASH_ECCCORR_ECCC                         \ ECC correction set by hardware when single ECC error has been detected and corrected. Cleared by writing 1.


\
\ @brief FLASH ECC detection register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_FLASH_ECCDETR_ADDR_ECC                     \ ECC error address When an ECC error occurs (double detection) during a read operation, the ADDR_ECC contains the address that generated the error. ADDR_ECC is reset when the flag error is reset. The flash interface programs the address in this register only when no ECC error flags are set. This means that only the first address that generated an double ECC error is saved. The address in ADDR_ECC is relative to the flash memory area where the error occurred (user flash memory, system flash memory, data area, read-only/OTP area).
$00100000 constant FLASH_FLASH_ECCDETR_OBK_ECC                      \ ECC fail double ECC error in flash OB Keys storage area. It indicates the OBK storage concerned by ECC error.
$00200000 constant FLASH_FLASH_ECCDETR_EDATA_ECC                    \ ECC fail double ECC error in flash high-cycle data area It indicates if flash high-cycle data area is concerned by ECC error.
$00400000 constant FLASH_FLASH_ECCDETR_BK_ECC                       \ ECC fail bank for double ECC error It indicates which bank is concerned by ECC error
$00800000 constant FLASH_FLASH_ECCDETR_SYSF_ECC                     \ ECC fail for double ECC error in system flash memory It indicates if system flash memory is concerned by ECC error.
$01000000 constant FLASH_FLASH_ECCDETR_OTP_ECC                      \ OTP ECC error bit This bit is set to 1 when double ECC detection occurred during the last read operation from the read-only/ OTP area. The address of the ECC error is available in ADDR_ECC bitfield.
$80000000 constant FLASH_FLASH_ECCDETR_ECCD                         \ ECC detection Set by hardware when two ECC error has been detected. When this bit is set, a NMI is generated. Cleared by writing 1. Needs to be cleared in order to detect subsequent double ECC errors.


\
\ @brief FLASH ECC data
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_FLASH_ECCDR_DATA_ECC                       \ ECC error data When an double detection ECC error occurs on special areas with 6-bit ECC on 16-bit data (data area, read-only/OTP area), the failing data is read to this register. By checking if it is possible to determine whether the failure was on a real data, or due to access to uninitialized memory.


\
\ @brief FLASH secure block-based register for Bank 2
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECBB2R1_SECBB2                      \ Secure/non-secure flash Bank 2 sector attribute


\
\ @brief FLASH secure block-based register for Bank 2
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECBB2R2_SECBB2                      \ Secure/non-secure flash Bank 2 sector attribute


\
\ @brief FLASH secure block-based register for Bank 2
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECBB2R3_SECBB2                      \ Secure/non-secure flash Bank 2 sector attribute


\
\ @brief FLASH secure block-based register for Bank 2
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_SECBB2R4_SECBB2                      \ Secure/non-secure flash Bank 2 sector attribute


\
\ @brief FLASH privilege block-based register for Bank 2
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PRIVBB2R1_PRIVBB2                    \ Privileged / non-privileged 8-Kbyte flash Bank 2 sector attribute


\
\ @brief FLASH privilege block-based register for Bank 2
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PRIVBB2R2_PRIVBB2                    \ Privileged / non-privileged 8-Kbyte flash Bank 2 sector attribute


\
\ @brief FLASH privilege block-based register for Bank 2
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PRIVBB2R3_PRIVBB2                    \ Privileged / non-privileged 8-Kbyte flash Bank 2 sector attribute


\
\ @brief FLASH privilege block-based register for Bank 2
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_PRIVBB2R4_PRIVBB2                    \ Privileged / non-privileged 8-Kbyte flash Bank 2 sector attribute


\
\ @brief FLASH security watermark for Bank 2
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_SECWM2R_CUR_SECWM_STRT2              \ Bank2 security WM area start sector
$007f0000 constant FLASH_FLASH_SECWM2R_CUR_SECWM_END2               \ Bank2 security WM end sector


\
\ @brief FLASH security watermark for Bank 2
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_SECWM2R_PRG_SECWM_STRT2              \ Bank 2 security WM area start sector
$007f0000 constant FLASH_FLASH_SECWM2R_PRG_SECWM_END2               \ Bank 2 security WM area end sector


\
\ @brief FLASH write sector group protection for Bank 2
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_WRP2R_CUR_WRPSG2                     \ Bank2 sector group protection option status byte Each FLASH_WRP2R_CUR bit reflects the write protection status of the corresponding group of 4 consecutive sectors in bank 2 (0: group is write protected; 1: group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127


\
\ @brief FLASH write sector group protection for Bank 2
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_WRP2R_PRG_WRPSG2                     \ Bank 2 sector group protection option status byte Setting WRPSGn2 bits to 0 write protects the corresponding group of four consecutive sectors in Bank 2 (0: group is write protected; 1: group is not write protected) Bit 0: Group embedding sectors 0 to 3 Bit 1: Group embedding sectors 4 to 7 Bit N: Group embedding sectors 4 x N to 4 x N + 3 Bit 31: Group embedding sectors 124 to 127


\
\ @brief FLASH data sectors configuration Bank 2
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$00000007 constant FLASH_FLASH_EDATA2R_CUR_EDATA2_STRT              \ EDATA2_STRT contains the start sectors of the flash high-cycle data area in Bank 2 There is no hardware effect to those bits. They shall be managed by ST tools in Flasher. ... Note: 111: The eight last sectors of the Bank 2 are reserved for flash high-cycle data
$00008000 constant FLASH_FLASH_EDATA2R_CUR_EDATA2_EN                \ Bank2 flash high-cycle data enable


\
\ @brief FLASH data sector configuration Bank 2
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$00000007 constant FLASH_FLASH_EDATA2R_PRG_EDATA2_STRT              \ EDATA2_STRT contains the start sectors of the flash high-cycle data area in Bank 2 There is no hardware effect to those bits. They shall be managed by ST tools in Flasher. ... Note: 111: The eight last sectors of the Bank 2 are reserved for flash high-cycle data.
$00008000 constant FLASH_FLASH_EDATA2R_PRG_EDATA2_EN                \ Bank 2 flash high-cycle data enable


\
\ @brief FLASH HDP Bank 2 configuration
\ Address offset: 0x1F8
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_HDP2R_CUR_HDP2_STRT                  \ HDPL barrier start set in number of 8-Kbyte sectors
$007f0000 constant FLASH_FLASH_HDP2R_CUR_HDP2_END                   \ HDPL barrier end set in number of 8-Kbyte sectors


\
\ @brief FLASH HDP Bank 2 configuration
\ Address offset: 0x1FC
\ Reset value: 0x00000000
\

$0000007f constant FLASH_FLASH_HDP2R_PRG_HDP2_STRT                  \ HDPL barrier start set in number of 8-Kbyte sectors
$007f0000 constant FLASH_FLASH_HDP2R_PRG_HDP2_END                   \ HDPL barrier end set in number of 8-Kbyte sectors


\
\ @brief FLASH address block description
\
$40022000 constant FLASH_FLASH_ACR  \ offset: 0x00 : FLASH access control register
$40022004 constant FLASH_FLASH_NSKEYR  \ offset: 0x04 : FLASH non-secure key register
$40022008 constant FLASH_FLASH_SECKEYR  \ offset: 0x08 : FLASH secure key register
$4002200c constant FLASH_FLASH_OPTKEYR  \ offset: 0x0C : FLASH option key register
$40022010 constant FLASH_FLASH_NSOBKKEYR  \ offset: 0x10 : FLASH non-secure OBK key register
$40022014 constant FLASH_FLASH_SECOBKKEYR  \ offset: 0x14 : FLASH secure OBK key register
$40022018 constant FLASH_FLASH_OPSR  \ offset: 0x18 : FLASH operation status register
$4002201c constant FLASH_FLASH_OPTCR  \ offset: 0x1C : FLASH option control register
$40022020 constant FLASH_FLASH_NSSR  \ offset: 0x20 : FLASH non-secure status register
$40022024 constant FLASH_FLASH_SECSR  \ offset: 0x24 : FLASH secure status register
$40022028 constant FLASH_FLASH_NSCR  \ offset: 0x28 : FLASH non-secure control register
$4002202c constant FLASH_FLASH_SECCR  \ offset: 0x2C : FLASH secure control register
$40022030 constant FLASH_FLASH_NSCCR  \ offset: 0x30 : FLASH non-secure clear control register
$40022034 constant FLASH_FLASH_SECCCR  \ offset: 0x34 : FLASH secure clear control register
$4002203c constant FLASH_FLASH_PRIVCFGR  \ offset: 0x3C : FLASH privilege configuration register
$40022040 constant FLASH_FLASH_NSOBKCFGR  \ offset: 0x40 : FLASH non-secure OBK configuration register
$40022044 constant FLASH_FLASH_SECOBKCFGR  \ offset: 0x44 : FLASH secure OBK configuration register
$40022048 constant FLASH_FLASH_HDPEXTR  \ offset: 0x48 : FLASH HDP extension register
$40022050 constant FLASH_FLASH_OPTSR_CUR  \ offset: 0x50 : FLASH option status register
$40022054 constant FLASH_FLASH_OPTSR_PRG  \ offset: 0x54 : FLASH option status register
$40022060 constant FLASH_FLASH_NSEPOCHR_CUR  \ offset: 0x60 : FLASH non-secure EPOCH register
$40022068 constant FLASH_FLASH_SECEPOCHR_CUR  \ offset: 0x68 : FLASH secure EPOCH register
$40022070 constant FLASH_FLASH_OPTSR2_CUR  \ offset: 0x70 : FLASH option status register 2
$40022074 constant FLASH_FLASH_OPTSR2_PRG  \ offset: 0x74 : FLASH option status register 2
$40022080 constant FLASH_FLASH_NSBOOTR_CUR  \ offset: 0x80 : FLASH non-secure boot register
$40022084 constant FLASH_FLASH_NSBOOTR_PRG  \ offset: 0x84 : FLASH non-secure boot register
$40022088 constant FLASH_FLASH_SECBOOTR_CUR  \ offset: 0x88 : FLASH secure boot register
$4002208c constant FLASH_FLASH_BOOTR_PRG  \ offset: 0x8C : FLASH secure boot register
$40022090 constant FLASH_FLASH_OTPBLR_CUR  \ offset: 0x90 : FLASH non-secure OTP block lock
$40022094 constant FLASH_FLASH_OTPBLR_PRG  \ offset: 0x94 : FLASH non-secure OTP block lock
$400220a0 constant FLASH_FLASH_SECBB1R1  \ offset: 0xA0 : FLASH secure block based register for Bank 1
$400220a4 constant FLASH_FLASH_SECBB1R2  \ offset: 0xA4 : FLASH secure block based register for Bank 1
$400220a8 constant FLASH_FLASH_SECBB1R3  \ offset: 0xA8 : FLASH secure block based register for Bank 1
$400220ac constant FLASH_FLASH_SECBB1R4  \ offset: 0xAC : FLASH secure block based register for Bank 1
$400220c0 constant FLASH_FLASH_PRIVBB1R1  \ offset: 0xC0 : FLASH privilege block based register for Bank 1
$400220c4 constant FLASH_FLASH_PRIVBB1R2  \ offset: 0xC4 : FLASH privilege block based register for Bank 1
$400220c8 constant FLASH_FLASH_PRIVBB1R3  \ offset: 0xC8 : FLASH privilege block based register for Bank 1
$400220cc constant FLASH_FLASH_PRIVBB1R4  \ offset: 0xCC : FLASH privilege block based register for Bank 1
$400220e0 constant FLASH_FLASH_SECWM1R_CUR  \ offset: 0xE0 : FLASH security watermark for Bank 1
$400220e4 constant FLASH_FLASH_SECWM1R_PRG  \ offset: 0xE4 : FLASH security watermark for Bank 1
$400220e8 constant FLASH_FLASH_WRP1R_CUR  \ offset: 0xE8 : FLASH write sector group protection for Bank 1
$400220ec constant FLASH_FLASH_WRP1R_PRG  \ offset: 0xEC : FLASH write sector group protection for Bank 1
$400220f0 constant FLASH_FLASH_EDATA1R_CUR  \ offset: 0xF0 : FLASH data sector configuration Bank 1
$400220f4 constant FLASH_FLASH_EDATA1R_PRG  \ offset: 0xF4 : FLASH data sector configuration Bank 1
$400220f8 constant FLASH_FLASH_HDP1R_CUR  \ offset: 0xF8 : FLASH HDP Bank 1 configuration
$400220fc constant FLASH_FLASH_HDP1R_PRG  \ offset: 0xFC : FLASH HDP Bank 1 configuration
$40022100 constant FLASH_FLASH_ECCCORR  \ offset: 0x100 : FLASH ECC correction register
$40022104 constant FLASH_FLASH_ECCDETR  \ offset: 0x104 : FLASH ECC detection register
$40022108 constant FLASH_FLASH_ECCDR  \ offset: 0x108 : FLASH ECC data
$400221a0 constant FLASH_FLASH_SECBB2R1  \ offset: 0x1A0 : FLASH secure block-based register for Bank 2
$400221a4 constant FLASH_FLASH_SECBB2R2  \ offset: 0x1A4 : FLASH secure block-based register for Bank 2
$400221a8 constant FLASH_FLASH_SECBB2R3  \ offset: 0x1A8 : FLASH secure block-based register for Bank 2
$400221ac constant FLASH_FLASH_SECBB2R4  \ offset: 0x1AC : FLASH secure block-based register for Bank 2
$400221c0 constant FLASH_FLASH_PRIVBB2R1  \ offset: 0x1C0 : FLASH privilege block-based register for Bank 2
$400221c4 constant FLASH_FLASH_PRIVBB2R2  \ offset: 0x1C4 : FLASH privilege block-based register for Bank 2
$400221c8 constant FLASH_FLASH_PRIVBB2R3  \ offset: 0x1C8 : FLASH privilege block-based register for Bank 2
$400221cc constant FLASH_FLASH_PRIVBB2R4  \ offset: 0x1CC : FLASH privilege block-based register for Bank 2
$400221e0 constant FLASH_FLASH_SECWM2R_CUR  \ offset: 0x1E0 : FLASH security watermark for Bank 2
$400221e4 constant FLASH_FLASH_SECWM2R_PRG  \ offset: 0x1E4 : FLASH security watermark for Bank 2
$400221e8 constant FLASH_FLASH_WRP2R_CUR  \ offset: 0x1E8 : FLASH write sector group protection for Bank 2
$400221ec constant FLASH_FLASH_WRP2R_PRG  \ offset: 0x1EC : FLASH write sector group protection for Bank 2
$400221f0 constant FLASH_FLASH_EDATA2R_CUR  \ offset: 0x1F0 : FLASH data sectors configuration Bank 2
$400221f4 constant FLASH_FLASH_EDATA2R_PRG  \ offset: 0x1F4 : FLASH data sector configuration Bank 2
$400221f8 constant FLASH_FLASH_HDP2R_CUR  \ offset: 0x1F8 : FLASH HDP Bank 2 configuration
$400221fc constant FLASH_FLASH_HDP2R_PRG  \ offset: 0x1FC : FLASH HDP Bank 2 configuration

