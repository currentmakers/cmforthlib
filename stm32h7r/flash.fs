\
\ @file flash.fs
\ @brief Embedded Flash memory
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Access control register
\ Address offset: 0x00
\ Reset value: 0x00000013
\

$0000000f constant FLASH_FLASH_ACR_LATENCY                          \ Read latency These bits are used to control the number of wait states used during read operations on both non-volatile memory banks. The application software has to program them to the correct value depending on the embedded Flash memory interface frequency and voltage conditions. Please refer to Table 27 for details. ... Note: Embedded Flash does not verify that the configuration is correct.
$00000030 constant FLASH_FLASH_ACR_WRHIGHFREQ                       \ Flash signal delay These bits are used to control the delay between non-volatile memory signals during programming operations. Application software has to program them to the correct value depending on the embedded Flash memory interface frequency. Please refer to Table 27 for details. Note: Embedded Flash does not verify that the configuration is correct.


\
\ @brief FLASH control key register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_KEYR_CUKEY                           \ Control unlock key Following values must be written to FLASH_KEYR consecutively to unlock FLASH_CR register: 1st key = 0x4567 0123 2nd key = 0xCDEF 89AB Reads to this register returns zero. If above sequence is wrong or performed twice, the FLASH_CR register is locked until the next system reset, and access to it generates a bus error.


\
\ @brief FLASH control register
\ Address offset: 0x10
\ Reset value: 0x00000001
\

$00000001 constant FLASH_FLASH_CR_LOCK                              \ Configuration lock bit When this bit is set write to all other bits in this register, and to FLASH_IER register, are ignored. Clearing this bit requires the correct write sequence to FLASH_KEYR register (see this register for details). If a wrong sequence is executed, or if the unlock sequence is performed twice, this bit remains locked until the next system reset. During the write access to set LOCK bit from 0 to 1, it is possible to change the other bits of this register.
$00000002 constant FLASH_FLASH_CR_PG                                \ Internal buffer control bit Setting this bit enables internal buffer for write operations. This allows preparing program operations even if a sector or bank erase is ongoing. When PG is cleared, the internal buffer is disabled for write operations, and all the data stored in the buffer but not sent to the operation queue are lost.
$00000004 constant FLASH_FLASH_CR_SER                               \ Sector erase request Setting this bit requests a sector erase. Write protection error is triggered when a sector erase is required on at least one protected sector. BER has a higher priority than SER: if both bits are set, the embedded Flash memory executes a bank erase.
$00000008 constant FLASH_FLASH_CR_BER                               \ Bank erase request Setting this bit requests a bank erase operation (user Flash memory only). Write protection error is triggered when a bank erase is required and some sectors are protected. BER has a higher priority than SER: if both are set, the embedded Flash memory executes a bank erase.
$00000010 constant FLASH_FLASH_CR_FW                                \ Force write This bit forces a write operation even if the write buffer is not full. In this case all bits not written are set by hardware. The embedded Flash memory resets FW when the corresponding operation has been acknowledged. Note: Using a force-write operation prevents the application from updating later the missing bits with something else than 1, because it is likely that it will lead to permanent ECC error. Write forcing is effective only if the write buffer is not empty (in particular, FW does not start several write operations when the force-write operations are performed consecutively).
$00000020 constant FLASH_FLASH_CR_START                             \ Erase start control bit This bit is used to start a sector erase or a bank erase operation. The embedded Flash memory resets START when the corresponding operation has been acknowledged. The user application cannot access any embedded Flash memory register until the operation is acknowledged.
$000000c0 constant FLASH_FLASH_CR_SSN                               \ Sector erase selection number These bits are used to select the target sector for an erase operation (they are unused otherwise). ...
$00010000 constant FLASH_FLASH_CR_PG_OTP                            \ Program Enable for OTP Area Set this bit to enable write operations to OTP area.
$00020000 constant FLASH_FLASH_CR_CRC_EN                            \ CRC enable Setting this bit enables the CRC calculation. CRC_EN does not start CRC calculation but enables CRC configuration through FLASH_CRCCR register. When CRC calculation is performed it can be disabled by clearing CRC_EN bit. Doing so sets CRCDATA to 0x0, clears CRC configuration and resets the content of FLASH_CRCDATAR register.
$01000000 constant FLASH_FLASH_CR_ALL_BANKS                         \ All banks select bit When this bit is set the erase is done on all Flash Memory sectors. ALL_BANKS is used only if a bank erase is required (BER=1). In all others operations, this control bit is ignored.


\
\ @brief FLASH status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant FLASH_FLASH_SR_BUSY                              \ Busy flag This bit is set when an effective write, erase or option byte change operation is ongoing. It is possible to know what type of operation is being executed reading the flags IS_PROGRAM, IS_ERASE and IS_OPTCHANGE. BUSY cannot be cleared by application. It is automatically reset by hardware every time a step in a write, erase or option byte change operation completes. It is not recommended to do software polling on BUSY to know when one operation completed because, depending of operation, more pulses are possible for one only operation. For software polling it is therefore better to use QW flag or to check the EOPF flag.
$00000002 constant FLASH_FLASH_SR_WBNE                              \ Write buffer not empty flag This bit is set when the embedded Flash memory is waiting for new data to complete the write buffer. In this state, the write buffer is not empty. WBNE is reset by hardware each time the write buffer is complete or the write buffer is emptied following one of the event below: the application software forces the write operation using FW bit in FLASH_CR the embedded Flash memory detects an error that involves data loss the application software has disabled write operations This bit cannot be forced to 0. To reset it, clear the write buffer by performing any of the above listed actions, or send the missing data.
$00000004 constant FLASH_FLASH_SR_QW                                \ Wait queue flag This bit is set when a write, erase or option byte change operation is pending in the command queue buffer. It is not possible to know what type of programming operation is present in the queue. This flag is reset by hardware when all write, erase or option byte change operations have been executed and thus removed from the waiting queue(s). This bit cannot be forced to 0. It is reset after a deterministic time if no other operations are requested.
$00000008 constant FLASH_FLASH_SR_CRC_BUSY                          \ CRC busy flag This bit is set when a CRC calculation is ongoing. This bit cannot be forced to 0. The user must wait until the CRC calculation has completed or disable CRC computation using CRC_EN bit in FLASH_CR register.
$00000010 constant FLASH_FLASH_SR_IS_PROGRAM                        \ Is a program This bit is set together with BUSY when a program operation is ongoing. It is cleared when BUSY is cleared. This flag can also raise with IS_OPTCHANGE, because an program operation can happen during an option change.
$00000020 constant FLASH_FLASH_SR_IS_ERASE                          \ Is an erase This bit is set together with BUSY when an erase operation is ongoing. It is cleared when BUSY is cleared. This flag can also raise with IS_OPTCHANGE, because an erase operation can happen during an option change.
$00000040 constant FLASH_FLASH_SR_IS_OPTCHANGE                      \ Is an option change This bit is set together with BUSY when an option change operation is ongoing. It is cleared when BUSY is cleared. This flag can also raise with IS_PROGRAM or IS_ERASE, because a program or erase step is ongoing during option change.
$02000000 constant FLASH_FLASH_SR_RCHECKF                           \ Root code check flag This bit returns the status of the root code check performed following the first access to the Flash. This bit is cleared with RCHECKF bit in FLASH_FCR (optional).


\
\ @brief FLASH status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$02000000 constant FLASH_FLASH_FCR_RCHECKF                          \ Root code check flag clear Set this bit to clear RCHECKF bit in FLASH_SR.


\
\ @brief FLASH interrupt enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00010000 constant FLASH_FLASH_IER_EOPIE                            \ End-of-program interrupt control bit
$00020000 constant FLASH_FLASH_IER_WRPERRIE                         \ Write protection error interrupt enable bit
$00040000 constant FLASH_FLASH_IER_PGSERRIE                         \ Programming sequence error interrupt enable bit
$00080000 constant FLASH_FLASH_IER_STRBERRIE                        \ Strobe error interrupt enable bit
$00100000 constant FLASH_FLASH_IER_OBLERRIE                         \ Option byte loading error interrupt enable bit
$00200000 constant FLASH_FLASH_IER_INCERRIE                         \ Inconsistency error interrupt enable bit
$01000000 constant FLASH_FLASH_IER_RDSERRIE                         \ Read security error interrupt enable bit
$02000000 constant FLASH_FLASH_IER_SNECCERRIE                       \ ECC single correction error interrupt enable bit
$04000000 constant FLASH_FLASH_IER_DBECCERRIE                       \ ECC double detection error interrupt enable bit
$08000000 constant FLASH_FLASH_IER_CRCENDIE                         \ CRC end of calculation interrupt enable bit
$10000000 constant FLASH_FLASH_IER_CRCRDERRIE                       \ CRC read error interrupt enable bit


\
\ @brief FLASH interrupt status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00010000 constant FLASH_FLASH_ISR_EOPF                             \ End-of-program flag This bit is set when a programming operation completes. An interrupt is generated if the EOPIE is set. It is not necessary to reset EOPF before starting a new operation. Setting EOPF bit in FLASH_ICR register clears this bit.
$00020000 constant FLASH_FLASH_ISR_WRPERRF                          \ Write protection error flag This bit is set when a protection error occurs during a program operation. An interrupt is also generated if the WRPERRIE is set. Setting WRPERRF bit in FLASH_ICR register clears this bit.
$00040000 constant FLASH_FLASH_ISR_PGSERRF                          \ Programming sequence error flag This bit is set when a sequence error occurs. An interrupt is generated if the PGSERRIE bit is set. Setting PGSERRF bit in FLASH_ICR register clears this bit.
$00080000 constant FLASH_FLASH_ISR_STRBERRF                         \ Strobe error flag This bit is set when a strobe error occurs (when the master attempts to write several times the same byte in the write buffer). An interrupt is generated if the STRBERRIE bit is set. Setting STRBERRF bit in FLASH_ICR register clears this bit.
$00100000 constant FLASH_FLASH_ISR_OBLERRF                          \ Option byte loading error flag This bit is set when an error is found during the option byte loading sequence. An interrupt is generated if OBLERRIE is set. Setting OBLERRF bit in the FLASH_ICR register clears this bit.
$00200000 constant FLASH_FLASH_ISR_INCERRF                          \ Inconsistency error flag This bit is set when a inconsistency error occurs. An interrupt is generated if INCERRIE is set. Setting INCERRF bit in the FLASH_ICR register clears this bit.
$01000000 constant FLASH_FLASH_ISR_RDSERRF                          \ Read security error flag This bit is set when a read security error occurs (read access to hide protected area with incorrect hide protection level). An interrupt is generated if RDSERRIE is set. Setting RDSERRF bit in FLASH_ICR register clears this bit.
$02000000 constant FLASH_FLASH_ISR_SNECCERRF                        \ ECC single error flag This bit is set when an ECC single correction error occurs during a read operation. An interrupt is generated if SNECCERRIE is set. Setting SNECCERRF bit in FLASH_ICR register clears this bit.
$04000000 constant FLASH_FLASH_ISR_DBECCERRF                        \ ECC double error flag This bit is set when an ECC double detection error occurs during a read operation. An interrupt is generated if DBECCERRIE is set. Setting DBECCERRF bit in FLASH_ICR register clears this bit.
$08000000 constant FLASH_FLASH_ISR_CRCENDF                          \ CRC end flag This bit is set when the CRC computation has completed. An interrupt is generated if CRCENDIE is set. It is not necessary to reset CRCEND before restarting CRC computation. Setting CRCENDF bit in FLASH_ICR register clears this bit.
$10000000 constant FLASH_FLASH_ISR_CRCRDERRF                        \ CRC read error flag This bit is set when a word is found read protected during a CRC operation. An interrupt is generated if CRCRDIE is set. Setting CRCRDERRF bit in FLASH_ICR register clears this bit. This flag is valid only when CRCEND bit is set.


\
\ @brief FLASH interrupt clear register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00010000 constant FLASH_FLASH_ICR_EOPF                             \ End-of-program flag clear Setting this bit clears EOPF flag in FLASH_ISR register.
$00020000 constant FLASH_FLASH_ICR_WRPERRF                          \ Write protection error flag clear Setting this bit clears WRPERRF flag in FLASH_ISR register.
$00040000 constant FLASH_FLASH_ICR_PGSERRF                          \ Programming sequence error flag clear Setting this bit clears PGSERRF flag in FLASH_ISR register.
$00080000 constant FLASH_FLASH_ICR_STRBERRF                         \ Strobe error flag clear Setting this bit clears STRBERRF flag in FLASH_ISR register.
$00100000 constant FLASH_FLASH_ICR_OBLERRF                          \ Option byte loading error flag clear Setting this bit clears OBLERRF flag in FLASH_ISR register.
$00200000 constant FLASH_FLASH_ICR_INCERRF                          \ Inconsistency error flag clear Setting this bit clears INCERRF flag in FLASH_ISR register.
$01000000 constant FLASH_FLASH_ICR_RDSERRF                          \ Read security error flag clear Setting this bit clears RDSERRF flag in FLASH_ISR register.
$02000000 constant FLASH_FLASH_ICR_SNECCERRF                        \ ECC single error flag clear Setting this bit clears SNECCERRF flag in FLASH_ISR register. If the DBECCERRF flag of FLASH_ISR register is also cleared, FLASH_ECCFAR register is reset to zero as well.
$04000000 constant FLASH_FLASH_ICR_DBECCERRF                        \ ECC double error flag clear Setting this bit clears DBECCERRF flag in FLASH_ISR register. If the SNECCERRF flag of FLASH_ISR register is also cleared, FLASH_ECCFAR register is reset to zero as well.
$08000000 constant FLASH_FLASH_ICR_CRCENDF                          \ CRC end flag clear Setting this bit clears CRCENDF flag in FLASH_ISR register.
$10000000 constant FLASH_FLASH_ICR_CRCRDERRF                        \ CRC error flag clear Setting this bit clears CRCRDERRF flag in FLASH_ISR register.


\
\ @brief FLASH CRC control register
\ Address offset: 0x30
\ Reset value: 0x001C0000
\

$00000003 constant FLASH_FLASH_CRCCR_CRC_SECT                       \ CRC sector number CRC_SECT is used to select one user Flash sectors to be added to the list of sectors on which the CRC is calculated. The CRC can be computed either between two addresses (using registers FLASH_CRCSADDR and FLASH_CRCEADDR) or on a list of sectors using this register. If this latter option is selected, it is possible to add a sector to the list of sectors by programming the sector number in CRC_SECT and then setting ADD_SECT bit. The list of sectors can be erased either by setting CLEAN_SECT bit or by disabling the CRC computation. ...
$00000200 constant FLASH_FLASH_CRCCR_CRC_BY_SECT                    \ CRC sector mode select bit When this bit is set the CRC calculation is performed at sector level, on the sectors present in the list of sectors. To add a sector to this list, use ADD_SECT and CRC_SECT bits. To clean the list, use CLEAN_SECT bit. When CRC_BY_SECT is cleared the CRC calculation is performed on all addresses defined between start and end addresses defined in FLASH_CRCSADDR and FLASH_CRCEADDR registers.
$00000400 constant FLASH_FLASH_CRCCR_ADD_SECT                       \ CRC sector select bit When this bit is set the sector whose number is written in CRC_SECT is added to the list of sectors on which the CRC is calculated.
$00000800 constant FLASH_FLASH_CRCCR_CLEAN_SECT                     \ CRC sector list clear bit When this bit is set the list of sectors on which the CRC is calculated is cleared.
$00010000 constant FLASH_FLASH_CRCCR_START_CRC                      \ CRC start bit START_CRC bit triggers a CRC calculation using the current configuration. No CRC calculation can launched when an option byte change operation is ongoing because all read accesses to embedded Flash memory registers are put on hold until the option byte change operation has completed. This bit is cleared when CRC computation starts.
$00020000 constant FLASH_FLASH_CRCCR_CLEAN_CRC                      \ CRC clear bit Setting CLEAN_CRC to 1 clears the current CRC result stored in the FLASH_CRCDATAR register.
$00300000 constant FLASH_FLASH_CRCCR_CRC_BURST                      \ CRC burst size CRC_BURST bits set the size of the bursts that are generated by the CRC calculation unit. A Flash word is 128-bit.
$01000000 constant FLASH_FLASH_CRCCR_ALL_SECT                       \ All sectors selection When this bit is set all the sectors in user Flash are added to list of sectors on which the CRC shall be calculated. This bit is cleared when CRC computation starts.


\
\ @brief FLASH CRC start address register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0001ffc0 constant FLASH_FLASH_CRCSADDR_CRC_START_ADDR              \ CRC start address This register is used when CRC_BY_SECT is cleared. It must be programmed to the address of the first Flash word to use for the CRC calculation, done burst by burst. CRC computation starts at an address aligned to the burst size defined in CRC_BURST of FLASH_CRCCR register. Hence least significant bits [5:0] of the address are set by hardware to 0 (minimum burst size= 64 bytes). The address is relative to the Flash bank.


\
\ @brief FLASH CRC end address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0001ffc0 constant FLASH_FLASH_CRCEADDR_CRC_END_ADDR                \ CRC end address This register is used when CRC_BY_SECT is cleared. It must be programmed to the address of the Flash word starting the last burst of the CRC calculation. The burst size is defined in CRC_BURST of FLASH_CRCCR register. The least significant bits [5:0] of the address are set by hardware to 0 (minimum burst size= 64 bytes). The address is relative to the Flash bank.


\
\ @brief FLASH CRC data register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_CRCDATAR_CRC_DATA                    \ CRC result This bitfield contains the result of the last CRC calculation. The value is valid only when CRC calculation completed (CRCENDF is set in FLASH_ISR register). CRC_DATA is cleared when CRC_EN is cleared in FLASH_CR register (CRC disabled), or when CLEAN_CRC bit is set in FLASH_CRCCR register.


\
\ @brief FLASH ECC single error fail address
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_ECCSFADDR_SEC_FADD                   \ ECC single error correction fail address When a single ECC error correction occurs during a read operation, the SEC_FADD bitfield contains the system bus address that generated the error. This register is automatically cleared when SNECCERRF flag that generated the error is cleared. Note that only the first address that generated an ECC single error correction error is saved in this register.


\
\ @brief FLASH ECC double error fail address
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_ECCDFADDR_DED_FADD                   \ ECC double error detection fail address When a double ECC detection occurs during a read operation, the DED_FADD bitfield contains the system bus address that generated the error. This register is automatically cleared when the DBECCERRF flag that generated the error is cleared. Note that only the first address that generated an ECC double error detection error is saved in this register.


\
\ @brief FLASH options key register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OPTKEYR_OCUKEY                       \ Options configuration unlock key Following values must be written to FLASH_OPTKEYR consecutively to unlock FLASH_OPTCR register: 1st key = 0x0819 2A3B 2nd key = 0x4C5D 6E7F Reads to this register returns zero. If above sequence is performed twice locks up the corresponding register/bit until the next system reset, and generates a bus error.


\
\ @brief FLASH options control register
\ Address offset: 0x104
\ Reset value: 0x00000001
\

$00000001 constant FLASH_FLASH_OPTCR_OPTLOCK                        \ Options lock When this bit is set write to all other bits in this register, and write to OTP words, option bytes and option bytes keys control registers, are ignored. Clearing this bit requires the correct write sequence to FLASH_OPTKEYR register (see this register for details). If a wrong sequence is executed, or the unlock sequence is performed twice, this bit remains locked until next system reset. During the write access to set LOCK bit from 0 to 1, it is possible to change the other bits of this register.
$00000002 constant FLASH_FLASH_OPTCR_PG_OPT                         \ Program options
$08000000 constant FLASH_FLASH_OPTCR_KVEIE                          \ Key valid error interrupt enable bit This bit controls if an interrupt has to be generated when KVEF is set in FLASH_OPTISR.
$10000000 constant FLASH_FLASH_OPTCR_KTEIE                          \ Key transfer error interrupt enable bit This bit controls if an interrupt has to be generated when KTEF is set in FLASH_OPTISR.
$40000000 constant FLASH_FLASH_OPTCR_OPTERRIE                       \ Option byte change error interrupt enable bit This bit controls if an interrupt has to be generated when an error occurs during an option byte change.


\
\ @brief FLASH options interrupt status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$08000000 constant FLASH_FLASH_OPTISR_KVEF                          \ Key valid error flag This bit is set when loading an unknown or corrupted option byte key. More specifically: Embedded Flash did not find an option byte key that corresponds to the given OBKINDEX[4:0] and the requested HDPL (optionally modified by NEXTKL[1:0]). It can happen for example when requested key has not being provisioned. A double error detection was found when loading the requested option byte key. In this case, if this key is provisioned again the error should disappear. When KVEF is set write to START bit in FLASH_OBKCR is ignored. An interrupt is generated when this flag is raised if the KVEIE bit of FLASH_OPTCR register is set. Setting KVEF bit of register FLASH_OPTICR clears this bit.
$10000000 constant FLASH_FLASH_OPTISR_KTEF                          \ Key transfer error flag This bit is set when embedded Flash signals an error to the SAES peripheral. It happens when the key size (128-bit or 256-bit) is not matching between embedded Flash OBKSIZE[1:0] and KEYSIZE bit in SAES_CR register. It also happen when an ECC dual error detection occurred while embedded Flash loaded an option byte key for the SAES peripheral. When KTEF is set write to START bit in FLASH_OBKCR is ignored. An interrupt is generated when this flag is raised if the KTEIE bit of FLASH_OPTCR register is set. Setting KTEF bit of register FLASH_OPTICR clears this bit.
$40000000 constant FLASH_FLASH_OPTISR_OPTERRF                       \ Option byte change error flag When OPTERRF is set, the option byte change operation did not successfully complete. An interrupt is generated when this flag is raised if the OPTERRIE bit of FLASH_OPTCR register is set. Setting OPTERRF of register FLASH_OPTICR clears this bit.


\
\ @brief FLASH options interrupt clear register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$08000000 constant FLASH_FLASH_OPTICR_KVEF                          \ key valid error flag Set this bit to clear KVEF flag in FLASH_OPTISR register.
$10000000 constant FLASH_FLASH_OPTICR_KTEF                          \ key transfer error flag Set this bit to clear KTEF flag in FLASH_OPTISR register.
$40000000 constant FLASH_FLASH_OPTICR_OPTERRF                       \ Option byte change error flag Set this bit to clear OPTERRF flag in FLASH_OPTISR register.


\
\ @brief FLASH option byte key control register
\ Address offset: 0x110
\ Reset value: 0x00000C00
\

$0000001f constant FLASH_FLASH_OBKCR_OBKINDEX                       \ Option byte key index This bitfield represents the index of the option byte key in a given hide protection level. Reading keys with index lower that 8, the value is not be available in OBKDRx registers. It is instead sent directly to SAES peripheral. All others keys can be read using OBKDRx registers. Up to 32 keys can be provisioned per hide protection level (0, 1 or 2), provided there is enough space left in the Flash to store them.
$00000300 constant FLASH_FLASH_OBKCR_NEXTKL                         \ Next key level 10 or 11: reserved
$00000c00 constant FLASH_FLASH_OBKCR_OBKSIZE                        \ Option byte key size Application must use this bitfield to specify how many bits must be used for the new key. Embedded Flash ignores OBKSIZE during read of option keys because size is stored with the key.
$00004000 constant FLASH_FLASH_OBKCR_KEYPROG                        \ Key program This bit must be set to write option byte keys (keys are read otherwise).
$00008000 constant FLASH_FLASH_OBKCR_KEYSTART                       \ Key option start This bit is used to start the option byte key operation defined by the PROG bit. The embedded Flash memory resets START when the corresponding operation has been acknowledged.


\
\ @brief FLASH option bytes key data register 0
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OBKDR0_OBKDATA                       \ option byte key data, bits [31+x:0+x] Data register used in conjunction with FLASH_OBKCR register. Reading this register (read value once), or incrementing HDPL value in SBS peripheral automatically clears OBKDATA to 0x0. Writing this register prevents reading OBKDATA until option byte key programming sequence is completed.


\
\ @brief FLASH option bytes key data register 1
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OBKDR1_OBKDATA                       \ option byte key data, bits [31+x:0+x] Data register used in conjunction with FLASH_OBKCR register. Reading this register (read value once), or incrementing HDPL value in SBS peripheral automatically clears OBKDATA to 0x0. Writing this register prevents reading OBKDATA until option byte key programming sequence is completed.


\
\ @brief FLASH option bytes key data register 2
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OBKDR2_OBKDATA                       \ option byte key data, bits [31+x:0+x] Data register used in conjunction with FLASH_OBKCR register. Reading this register (read value once), or incrementing HDPL value in SBS peripheral automatically clears OBKDATA to 0x0. Writing this register prevents reading OBKDATA until option byte key programming sequence is completed.


\
\ @brief FLASH option bytes key data register 3
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OBKDR3_OBKDATA                       \ option byte key data, bits [31+x:0+x] Data register used in conjunction with FLASH_OBKCR register. Reading this register (read value once), or incrementing HDPL value in SBS peripheral automatically clears OBKDATA to 0x0. Writing this register prevents reading OBKDATA until option byte key programming sequence is completed.


\
\ @brief FLASH option bytes key data register 4
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OBKDR4_OBKDATA                       \ option byte key data, bits [31+x:0+x] Data register used in conjunction with FLASH_OBKCR register. Reading this register (read value once), or incrementing HDPL value in SBS peripheral automatically clears OBKDATA to 0x0. Writing this register prevents reading OBKDATA until option byte key programming sequence is completed.


\
\ @brief FLASH option bytes key data register 5
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OBKDR5_OBKDATA                       \ option byte key data, bits [31+x:0+x] Data register used in conjunction with FLASH_OBKCR register. Reading this register (read value once), or incrementing HDPL value in SBS peripheral automatically clears OBKDATA to 0x0. Writing this register prevents reading OBKDATA until option byte key programming sequence is completed.


\
\ @brief FLASH option bytes key data register 6
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OBKDR6_OBKDATA                       \ option byte key data, bits [31+x:0+x] Data register used in conjunction with FLASH_OBKCR register. Reading this register (read value once), or incrementing HDPL value in SBS peripheral automatically clears OBKDATA to 0x0. Writing this register prevents reading OBKDATA until option byte key programming sequence is completed.


\
\ @brief FLASH option bytes key data register 7
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant FLASH_FLASH_OBKDR7_OBKDATA                       \ option byte key data, bits [31+x:0+x] Data register used in conjunction with FLASH_OBKCR register. Reading this register (read value once), or incrementing HDPL value in SBS peripheral automatically clears OBKDATA to 0x0. Writing this register prevents reading OBKDATA until option byte key programming sequence is completed.


\
\ @brief FLASH non-volatile status register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_NVSR_NVSTATE                         \ Non-volatile state others: invalid configuration.


\
\ @brief FLASH security status register programming
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_NVSRP_NVSTATE                        \ Non-volatile state programming Write to change corresponding bits in FLASH_NVSR register: Actual option byte change from close to open is triggered only after memory clear hardware process is confirmed. When NVSTATE=0xB4 (resp. 0x51) writing any other value than 0x51 (resp. 0xB4) triggers an option byte change error (OPTERRF).


\
\ @brief FLASH RoT status register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_ROTSR_OEM_PROVD                      \ OEM provisioned device Any other value: device is not provisioned by the OEM.
$0000ff00 constant FLASH_FLASH_ROTSR_DBG_AUTH                       \ Debug authentication method Any other value: no authentication method selected (NotSet).
$ff000000 constant FLASH_FLASH_ROTSR_IROT_SELECT                    \ iRoT selection This option is ignored for STM32H7R devices (OEM iRoT is always selected). Any other value: OEM iRoT is selected at boot.


\
\ @brief FLASH RoT status register programming
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_ROTSRP_OEM_PROVD                     \ OEM provisioned device Write to change corresponding bits in FLASH_ROTSR register. Write are ignored if HDPL is greater than 1.
$0000ff00 constant FLASH_FLASH_ROTSRP_DBG_AUTH                      \ Debug authentication method programming Write to change corresponding bits in FLASH_ROTSR register. Write are ignored if HDPL is greater than 0.
$ff000000 constant FLASH_FLASH_ROTSRP_IROT_SELECT                   \ iRoT selection This option is ignored for STM32H7R devices. Write to change corresponding bits in FLASH_ROTSR register. Write are ignored if HDPL is greater than 1 and if NVSTATE is not 0xB4 (OPEN).


\
\ @brief FLASH OTP lock status register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_FLASH_OTPLSR_OTPL                          \ OTP lock n Block n corresponds to OTP 16-bit word 32 x n to 32 x n + 31. OTPL[n] = 1 indicates that all OTP 16-bit words in OTP Block n are locked and can no longer be programmed. OTPL[n] = 0 indicates that all OTP 16-bit words in OTP Block n are not locked and can still be modified.


\
\ @brief FLASH OTP lock status register programming
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_FLASH_OTPLSRP_OTPL                         \ OTP lock n programming Write to change corresponding option byte bit in FLASH_OTPLSR. OTPL bits can be only be set, not cleared.


\
\ @brief FLASH write protection status register
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_WRPSR_WRPS                           \ Write protection for sector n This bit reflects the write protection status of user Flash sector n


\
\ @brief FLASH write protection status register programming
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$000000ff constant FLASH_FLASH_WRPSRP_WRPS                          \ Write protection for sector n programming Write to change corresponding bit in FLASH_WRPSR


\
\ @brief FLASH hide protection status register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$000001ff constant FLASH_FLASH_HDPSR_HDP_AREA_START                 \ Hide protection user Flash area start This option sets the start address that contains the first 256-byte block of the hide protection (HDP) area in user Flash area. If HDP_AREA_END=HDP_AREA_START all the sectors are protected. If HDP_AREA_END<HDP_AREA_START no sectors are protected.
$01ff0000 constant FLASH_FLASH_HDPSR_HDP_AREA_END                   \ Hide protection user Flash area end This option sets the end address that contains the last 256-byte block of the hide protection (HDP) area in user Flash area. If HDP_AREA_END=HDP_AREA_START all the sectors are protected. If HDP_AREA_END<HDP_AREA_START no sectors are protected.


\
\ @brief FLASH hide protection status register programming
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$000001ff constant FLASH_FLASH_HDPSRP_HDP_AREA_START                \ Hide protection user Flash area start programming Write to change corresponding option byte bits in FLASH_HDPSR. If HDP_AREA_END=HDP_AREA_START all the sectors are protected. If HDP_AREA_END<HDP_AREA_START no sectors are protected.
$01ff0000 constant FLASH_FLASH_HDPSRP_HDP_AREA_END                  \ Hide protection user Flash area end programming Write to change corresponding option byte bits in FLASH_HDPSR. If HDP_AREA_END=HDP_AREA_START all the sectors are protected. If HDP_AREA_END<HDP_AREA_START no sectors are protected.


\
\ @brief FLASH epoch status register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00ffffff constant FLASH_FLASH_EPOCHSR_EPOCH                        \ Epoch This value is distributed by hardware to the SAES peripheral.


\
\ @brief FLASH RoT status register programming
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00ffffff constant FLASH_FLASH_EPOCHSRP_EPOCH                       \ Epoch programming Write to change corresponding bits in FLASH_EPOCHSR register.


\
\ @brief FLASH option byte word 1 status register
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$0000000c constant FLASH_FLASH_OBW1SR_BOR_LEV                       \ Brownout level These bits reflects the power level that generates a system reset.
$00000010 constant FLASH_FLASH_OBW1SR_IWDG_HW                       \ Independent watchdog HW Control
$00000040 constant FLASH_FLASH_OBW1SR_NRST_STOP                     \ Reset on stop mode
$00000080 constant FLASH_FLASH_OBW1SR_NRST_STBY                     \ Reset on standby mode
$00000100 constant FLASH_FLASH_OBW1SR_OCTO1_HSLV                    \ XSPIM_P1 High-Speed at Low-Voltage
$00000200 constant FLASH_FLASH_OBW1SR_OCTO2_HSLV                    \ XSPIM_P2 High-Speed at Low-Voltage
$00020000 constant FLASH_FLASH_OBW1SR_IWDG_FZ_STOP                  \ IWDG stop mode freeze When set the independent watchdog IWDG is frozen in system Stop mode.
$00040000 constant FLASH_FLASH_OBW1SR_IWDG_FZ_SDBY                  \ IWDG standby mode freeze When set the independent watchdog IWDG is frozen in system Standby mode.
$10000000 constant FLASH_FLASH_OBW1SR_PERSO_OK                      \ Personalization OK This bit is set on STMicroelectronics production line.
$20000000 constant FLASH_FLASH_OBW1SR_VDDIO_HSLV                    \ I/O High-Speed at Low-Voltage This bit indicates that the product operates below 2.5 V.


\
\ @brief FLASH option byte word 1 status register programming
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$0000000c constant FLASH_FLASH_OBW1SRP_BOR_LEV                      \ Brownout level Write to change corresponding bits in FLASH_OBW1SR register.
$00000010 constant FLASH_FLASH_OBW1SRP_IWDG_HW                      \ Independent watchdog HW Control Write to change corresponding bit in FLASH_OBW1SR register.
$00000040 constant FLASH_FLASH_OBW1SRP_NRST_STOP                    \ Reset on stop mode programming Write to change corresponding bit in FLASH_OBW1SR register.
$00000080 constant FLASH_FLASH_OBW1SRP_NRST_STBY                    \ Reset on standby mode programming Write to change corresponding bit in FLASH_OBW1SR register.
$00000100 constant FLASH_FLASH_OBW1SRP_OCTO1_HSLV                   \ XSPIM_P1 High-Speed at Low-Voltage Write to change corresponding bit in FLASH_OBW1SR register.
$00000200 constant FLASH_FLASH_OBW1SRP_OCTO2_HSLV                   \ XSPIM_P2 High-Speed at Low-Voltage programming Write to change corresponding bit in FLASH_OBW1SR register.
$00020000 constant FLASH_FLASH_OBW1SRP_IWDG_FZ_STOP                 \ IWDG stop mode freeze Write to change corresponding bit in FLASH_OBW1SR register.
$00040000 constant FLASH_FLASH_OBW1SRP_IWDG_FZ_SDBY                 \ IWDG standby mode freeze programming Write to change corresponding bit in FLASH_OBW1SR register.
$20000000 constant FLASH_FLASH_OBW1SRP_VDDIO_HSLV                   \ I/O High-Speed at Low-Voltage programming Write to change corresponding bit in FLASH_OBW1SR register.


\
\ @brief FLASH option byte word 2 status register
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000007 constant FLASH_FLASH_OBW2SR_ITCM_AXI_SHARE                \ ITCM SRAM configuration
$00000070 constant FLASH_FLASH_OBW2SR_DTCM_AXI_SHARE                \ DTCM SRAM configuration
$00000100 constant FLASH_FLASH_OBW2SR_ECC_ON_SRAM                   \ ECC on SRAM
$00000200 constant FLASH_FLASH_OBW2SR_I2C_NI3C                      \ I2C Not I3C


\
\ @brief FLASH option byte word 2 status register programming
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000007 constant FLASH_FLASH_OBW2SRP_ITCM_AXI_SHARE               \ ITCM AXI share programming Write to change corresponding bits in FLASH_OBW2SR register. Bit 2 should be kept to 0: ITCM_AXI_SHARE: = 000 or 011: ITCM 64 Kbytes ITCM_AXI_SHARE = 001: ITCM 128 Kbytes ITCM_AXI_SHARE = 010: ITCM 192 Kbytes
$00000070 constant FLASH_FLASH_OBW2SRP_DTCM_AXI_SHARE               \ DTCM AXI share programming Write to change corresponding bits in the FLASH_OBW2SR register. Bit 2 should be kept to 0: DTCM_AXI_SHARE = 000 or 011: DTCM 64 Kbytes DTCM_AXI_SHARE = 001: DTCM 128 Kbytes DTCM_AXI_SHARE = 010: DTCM 192 Kbytes
$00000100 constant FLASH_FLASH_OBW2SRP_ECC_ON_SRAM                  \ ECC on SRAM programming Write to change corresponding bit in FLASH_OBW2SR register.
$00000200 constant FLASH_FLASH_OBW2SRP_I2C_NI3C                     \ I2C Not I3C Write to change corresponding bit in FLASH_OBW2SR register.


\
\ @brief Embedded Flash memory
\
$52002000 constant FLASH_FLASH_ACR  \ offset: 0x00 : Access control register
$52002004 constant FLASH_FLASH_KEYR  \ offset: 0x04 : FLASH control key register
$52002010 constant FLASH_FLASH_CR  \ offset: 0x10 : FLASH control register
$52002014 constant FLASH_FLASH_SR  \ offset: 0x14 : FLASH status register
$52002018 constant FLASH_FLASH_FCR  \ offset: 0x18 : FLASH status register
$52002020 constant FLASH_FLASH_IER  \ offset: 0x20 : FLASH interrupt enable register
$52002024 constant FLASH_FLASH_ISR  \ offset: 0x24 : FLASH interrupt status register
$52002028 constant FLASH_FLASH_ICR  \ offset: 0x28 : FLASH interrupt clear register
$52002030 constant FLASH_FLASH_CRCCR  \ offset: 0x30 : FLASH CRC control register
$52002034 constant FLASH_FLASH_CRCSADDR  \ offset: 0x34 : FLASH CRC start address register
$52002038 constant FLASH_FLASH_CRCEADDR  \ offset: 0x38 : FLASH CRC end address register
$5200203c constant FLASH_FLASH_CRCDATAR  \ offset: 0x3C : FLASH CRC data register
$52002040 constant FLASH_FLASH_ECCSFADDR  \ offset: 0x40 : FLASH ECC single error fail address
$52002044 constant FLASH_FLASH_ECCDFADDR  \ offset: 0x44 : FLASH ECC double error fail address
$52002100 constant FLASH_FLASH_OPTKEYR  \ offset: 0x100 : FLASH options key register
$52002104 constant FLASH_FLASH_OPTCR  \ offset: 0x104 : FLASH options control register
$52002108 constant FLASH_FLASH_OPTISR  \ offset: 0x108 : FLASH options interrupt status register
$5200210c constant FLASH_FLASH_OPTICR  \ offset: 0x10C : FLASH options interrupt clear register
$52002110 constant FLASH_FLASH_OBKCR  \ offset: 0x110 : FLASH option byte key control register
$52002118 constant FLASH_FLASH_OBKDR0  \ offset: 0x118 : FLASH option bytes key data register 0
$5200211c constant FLASH_FLASH_OBKDR1  \ offset: 0x11C : FLASH option bytes key data register 1
$52002120 constant FLASH_FLASH_OBKDR2  \ offset: 0x120 : FLASH option bytes key data register 2
$52002124 constant FLASH_FLASH_OBKDR3  \ offset: 0x124 : FLASH option bytes key data register 3
$52002128 constant FLASH_FLASH_OBKDR4  \ offset: 0x128 : FLASH option bytes key data register 4
$5200212c constant FLASH_FLASH_OBKDR5  \ offset: 0x12C : FLASH option bytes key data register 5
$52002130 constant FLASH_FLASH_OBKDR6  \ offset: 0x130 : FLASH option bytes key data register 6
$52002134 constant FLASH_FLASH_OBKDR7  \ offset: 0x134 : FLASH option bytes key data register 7
$52002200 constant FLASH_FLASH_NVSR  \ offset: 0x200 : FLASH non-volatile status register
$52002204 constant FLASH_FLASH_NVSRP  \ offset: 0x204 : FLASH security status register programming
$52002208 constant FLASH_FLASH_ROTSR  \ offset: 0x208 : FLASH RoT status register
$5200220c constant FLASH_FLASH_ROTSRP  \ offset: 0x20C : FLASH RoT status register programming
$52002210 constant FLASH_FLASH_OTPLSR  \ offset: 0x210 : FLASH OTP lock status register
$52002214 constant FLASH_FLASH_OTPLSRP  \ offset: 0x214 : FLASH OTP lock status register programming
$52002218 constant FLASH_FLASH_WRPSR  \ offset: 0x218 : FLASH write protection status register
$5200221c constant FLASH_FLASH_WRPSRP  \ offset: 0x21C : FLASH write protection status register programming
$52002230 constant FLASH_FLASH_HDPSR  \ offset: 0x230 : FLASH hide protection status register
$52002234 constant FLASH_FLASH_HDPSRP  \ offset: 0x234 : FLASH hide protection status register programming
$52002250 constant FLASH_FLASH_EPOCHSR  \ offset: 0x250 : FLASH epoch status register
$52002254 constant FLASH_FLASH_EPOCHSRP  \ offset: 0x254 : FLASH RoT status register programming
$52002260 constant FLASH_FLASH_OBW1SR  \ offset: 0x260 : FLASH option byte word 1 status register
$52002264 constant FLASH_FLASH_OBW1SRP  \ offset: 0x264 : FLASH option byte word 1 status register programming
$52002268 constant FLASH_FLASH_OBW2SR  \ offset: 0x268 : FLASH option byte word 2 status register
$5200226c constant FLASH_FLASH_OBW2SRP  \ offset: 0x26C : FLASH option byte word 2 status register programming

