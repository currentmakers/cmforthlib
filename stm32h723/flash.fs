\
\ @file flash.fs
\ @brief Flash
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Access control register
\ Address offset: 0x00
\ Reset value: 0x00000037
\

$0000000f constant FLASH_ACR_LATENCY                                \ Read latency
$00000030 constant FLASH_ACR_WRHIGHFREQ                             \ Flash signal delay


\
\ @brief FLASH key register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant FLASH_KEYR_KEYKEYRR                              \ access configuration unlock key


\
\ @brief FLASH option key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_OPTKEYR_OPTKEYR                            \ Unlock key option bytes


\
\ @brief FLASH control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_CR_LOCK                                    \ configuration lock bit
$00000002 constant FLASH_CR_PG                                      \ program enable bit
$00000004 constant FLASH_CR_SER                                     \ sector erase request
$00000008 constant FLASH_CR_BER                                     \ erase request
$00000030 constant FLASH_CR_PSIZE                                   \ program size
$00000040 constant FLASH_CR_FW                                      \ write forcing control bit
$00000080 constant FLASH_CR_START                                   \ bank or sector erase start control bit
$00000700 constant FLASH_CR_SNB                                     \ sector erase selection number
$00008000 constant FLASH_CR_CRC_EN                                  \ CRC control bit
$00010000 constant FLASH_CR_EOPIE                                   \ end-of-program interrupt control bit
$00020000 constant FLASH_CR_WRPERRIE                                \ write protection error interrupt enable bit
$00040000 constant FLASH_CR_PGSERRIE                                \ programming sequence error interrupt enable bit
$00080000 constant FLASH_CR_STRBERRIE                               \ strobe error interrupt enable bit
$00200000 constant FLASH_CR_INCERRIE                                \ inconsistency error interrupt enable bit
$00400000 constant FLASH_CR_OPERRIE                                 \ write/erase error interrupt enable bit
$00800000 constant FLASH_CR_RDPERRIE                                \ read protection error interrupt enable bit
$01000000 constant FLASH_CR_RDSERRIE                                \ secure error interrupt enable bit
$02000000 constant FLASH_CR_SNECCERRIE                              \ ECC single correction error interrupt enable bit
$04000000 constant FLASH_CR_DBECCERRIE                              \ ECC double detection error interrupt enable bit
$08000000 constant FLASH_CR_CRCENDIE                                \ end of CRC calculation interrupt enable bit
$10000000 constant FLASH_CR_CRCRDERRIE                              \ CRC read error interrupt enable bit When CRCRDERRIE1 bit is set to 1, an interrupt is generated when a protected area (PCROP or secure-only) has been detected during the last CRC computation on bank 1. CRCRDERRIE1 can be programmed only when LOCK1 is cleared to 0.


\
\ @brief FLASH status register for bank 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant FLASH_SR_BSY                                     \ ongoing program flag
$00000002 constant FLASH_SR_WBNE                                    \ write buffer not empty flag
$00000004 constant FLASH_SR_QW                                      \ wait queue flag
$00000008 constant FLASH_SR_CRC_BUSY                                \ CRC busy flag
$00010000 constant FLASH_SR_EOP                                     \ end-of-program flag
$00020000 constant FLASH_SR_WRPERR                                  \ write protection error flag
$00040000 constant FLASH_SR_PGSERR                                  \ programming sequence error flag
$00080000 constant FLASH_SR_STRBERR                                 \ strobe error flag
$00200000 constant FLASH_SR_INCERR                                  \ inconsistency error flag
$00400000 constant FLASH_SR_OPERR                                   \ write/erase error flag
$00800000 constant FLASH_SR_RDPERR                                  \ read protection error flag
$01000000 constant FLASH_SR_RDSERR                                  \ secure error flag
$02000000 constant FLASH_SR_SNECCERR                                \ single correction error flag
$04000000 constant FLASH_SR_DBECCERR                                \ ECC double detection error flag
$08000000 constant FLASH_SR_CRCEND                                  \ CRC-complete flag
$10000000 constant FLASH_SR_CRCRDERR                                \ CRC read error flag CRCRDERR1 flag is raised when a word is found read protected during a CRC operation on bank 1. An interrupt is generated if CRCRDIE1 and CRCEND1 are set to 1. Writing 1 to CLR_CRCRDERR1 bit in FLASH_CCR1 register clears CRCRDERR1. Note: This flag is valid only when CRCEND1 bit is set to 1


\
\ @brief FLASH clear control register for bank 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00010000 constant FLASH_CCR_CLR_EOP                                \ EOP1 flag clear bit
$00020000 constant FLASH_CCR_CLR_WRPERR                             \ WRPERR1 flag clear bit
$00040000 constant FLASH_CCR_CLR_PGSERR                             \ PGSERR flag clear bi
$00080000 constant FLASH_CCR_CLR_STRBERR                            \ STRBERR flag clear bit
$00200000 constant FLASH_CCR_CLR_INCERR                             \ INCERR flag clear bit
$00400000 constant FLASH_CCR_CLR_OPERR                              \ OPERR flag clear bit
$00800000 constant FLASH_CCR_CLR_RDPERR                             \ RDPERR flag clear bit
$01000000 constant FLASH_CCR_CLR_RDSERR                             \ RDSERR flag clear bit
$02000000 constant FLASH_CCR_CLR_SNECCERR                           \ SNECCERR flag clear bit
$04000000 constant FLASH_CCR_CLR_DBECCERR                           \ DBECCERR flag clear bit
$08000000 constant FLASH_CCR_CLR_CRCEND                             \ CRCEND flag clear bit
$10000000 constant FLASH_CCR_CLR_CRCRDERR                           \ CRCRDERR1 flag clear bit Setting this bit to 1 resets to 0 CRCRDERR1 flag in FLASH_SR1 register.


\
\ @brief FLASH option control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant FLASH_OPTCR_OPTLOCK                              \ FLASH_OPTCR lock option configuration bit
$00000002 constant FLASH_OPTCR_OPTSTART                             \ Option byte start change option configuration bit
$40000000 constant FLASH_OPTCR_OPTCHANGEERRIE                       \ Option byte change error interrupt enable bit


\
\ @brief FLASH option status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_OPTSR_CUR_OPT_BUSY                         \ Option byte change ongoing flag
$0000000c constant FLASH_OPTSR_CUR_BOR_LEV                          \ Brownout level option status bit
$00000010 constant FLASH_OPTSR_CUR_IWDG1_SW                         \ IWDG1 control option status bit
$00000040 constant FLASH_OPTSR_CUR_NRST_STOP_D1                     \ D1 DStop entry reset option status bit
$00000080 constant FLASH_OPTSR_CUR_NRST_STBY_D1                     \ D1 DStandby entry reset option status bit
$0000ff00 constant FLASH_OPTSR_CUR_RDP                              \ Readout protection level option status byte
$00020000 constant FLASH_OPTSR_CUR_IWDG_FZ_STOP                     \ IWDG Stop mode freeze option status bit
$00040000 constant FLASH_OPTSR_CUR_IWDG_FZ_SDBY                     \ IWDG Standby mode freeze option status bit
$00180000 constant FLASH_OPTSR_CUR_ST_RAM_SIZE                      \ DTCM RAM size option status
$00200000 constant FLASH_OPTSR_CUR_SECURITY                         \ Security enable option status bit
$20000000 constant FLASH_OPTSR_CUR_IO_HSLV                          \ I/O high-speed at low-voltage status bit (PRODUCT_BELOW_25V)
$40000000 constant FLASH_OPTSR_CUR_OPTCHANGEERR                     \ Option byte change error flag


\
\ @brief FLASH option status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000c constant FLASH_OPTSR_PRG_BOR_LEV                          \ BOR reset level option configuration bits
$00000010 constant FLASH_OPTSR_PRG_IWDG1_SW                         \ IWDG1 option configuration bit
$00000040 constant FLASH_OPTSR_PRG_NRST_STOP_D1                     \ Option byte erase after D1 DStop option configuration bit
$00000080 constant FLASH_OPTSR_PRG_NRST_STBY_D1                     \ Option byte erase after D1 DStandby option configuration bit
$0000ff00 constant FLASH_OPTSR_PRG_RDP                              \ Readout protection level option configuration byte
$00020000 constant FLASH_OPTSR_PRG_IWDG_FZ_STOP                     \ IWDG Stop mode freeze option configuration bit
$00040000 constant FLASH_OPTSR_PRG_IWDG_FZ_SDBY                     \ IWDG Standby mode freeze option configuration bit
$00180000 constant FLASH_OPTSR_PRG_ST_RAM_SIZE                      \ DTCM size select option configuration bits
$00200000 constant FLASH_OPTSR_PRG_SECURITY                         \ Security option configuration bit
$20000000 constant FLASH_OPTSR_PRG_IO_HSLV                          \ I/O high-speed at low-voltage (PRODUCT_BELOW_25V)


\
\ @brief FLASH option clear control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$40000000 constant FLASH_OPTCCR_CLR_OPTCHANGEERR                    \ OPTCHANGEERR reset bit


\
\ @brief FLASH protection address for bank 1
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000fff constant FLASH_PRAR_CUR_PROT_AREA_START                   \ lowest PCROP protected address
$0fff0000 constant FLASH_PRAR_CUR_PROT_AREA_END                     \ highest PCROP protected address
$80000000 constant FLASH_PRAR_CUR_DMEP                              \ PCROP protected erase enable option status bit


\
\ @brief FLASH protection address for bank 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant FLASH_PRAR_PRG_PROT_AREA_START                   \ lowest PCROP protected address configuration
$0fff0000 constant FLASH_PRAR_PRG_PROT_AREA_END                     \ highest PCROP protected address configuration
$80000000 constant FLASH_PRAR_PRG_DMEP                              \ PCROP protected erase enable option configuration bit


\
\ @brief FLASH secure address for bank 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000fff constant FLASH_SCAR_CUR_SEC_AREA_START                    \ lowest secure protected address
$0fff0000 constant FLASH_SCAR_CUR_SEC_AREA_END                      \ highest secure protected address
$80000000 constant FLASH_SCAR_CUR_DMES                              \ secure protected erase enable option status bit


\
\ @brief FLASH secure address for bank 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000fff constant FLASH_SCAR_PRG_SEC_AREA_START                    \ lowest secure protected address configuration
$0fff0000 constant FLASH_SCAR_PRG_SEC_AREA_END                      \ highest secure protected address configuration
$80000000 constant FLASH_SCAR_PRG_DMES                              \ secure protected erase enable option configuration bit


\
\ @brief FLASH write sector protection for bank 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000ff constant FLASH_WPSN_CUR_WRPSN                             \ sector write protection option status byte


\
\ @brief FLASH write sector protection for bank 1
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000000ff constant FLASH_WPSN_PRG_WRPSN                             \ sector write protection configuration byte


\
\ @brief FLASH register with boot address
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_BOOT_CUR_BOOT_CM_ADD0                      \ Boot address 0
$ffff0000 constant FLASH_BOOT_CUR_BOOT_CM_ADD1                      \ Boot address 1


\
\ @brief FLASH register with boot address
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_BOOT_PRG_BOOT_CM_ADD0                      \ Boot address 0
$ffff0000 constant FLASH_BOOT_PRG_BOOT_CM_ADD1                      \ Boot address 1


\
\ @brief FLASH CRC control register for bank 1
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000007 constant FLASH_CRCCR_CRC_SECT                             \ CRC sector number
$00000100 constant FLASH_CRCCR_CRC_BY_SECT                          \ CRC sector mode select bit
$00000200 constant FLASH_CRCCR_ADD_SECT                             \ CRC sector select bit
$00000400 constant FLASH_CRCCR_CLEAN_SECT                           \ CRC sector list clear bit
$00010000 constant FLASH_CRCCR_START_CRC                            \ CRC start bit
$00020000 constant FLASH_CRCCR_CLEAN_CRC                            \ CRC clear bit
$00300000 constant FLASH_CRCCR_CRC_BURST                            \ CRC burst size
$00400000 constant FLASH_CRCCR_ALL_BANK                             \ Bank 1 CRC select bit


\
\ @brief FLASH CRC start address register for bank 1
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000ffffc constant FLASH_CRCSADDR_CRC_START_ADDR                    \ CRC start address on bank 1


\
\ @brief FLASH CRC end address register for bank 1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$000ffffc constant FLASH_CRCEADDR_CRC_END_ADDR                      \ CRC end address on bank 1


\
\ @brief FLASH CRC data register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant FLASH_CRCDATAR_CRC_DATA                          \ CRC result


\
\ @brief FLASH ECC fail address for bank 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00007fff constant FLASH_ECC_FAR_FAIL_ECC_ADDR                      \ ECC error address


\
\ @brief FLASH ECC fail address for bank 1
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000003 constant FLASH_OPTSR2_CUR_TCM_AXI_SHARED                  \ TCM RAM sharing status bit
$00000004 constant FLASH_OPTSR2_CUR_CPUFREQ_BOOST                   \ CPU frequency boost status bit


\
\ @brief FLASH ECC fail address for bank 1
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000003 constant FLASH_OPTSR2_PRG_TCM_AXI_SHARED                  \ TCM RAM sharing status bit
$00000004 constant FLASH_OPTSR2_PRG_CPUFREQ_BOOST                   \ CPU frequency boost status bit


\
\ @brief Flash
\
$52002000 constant FLASH_ACR      \ offset: 0x00 : Access control register
$52002004 constant FLASH_KEYR     \ offset: 0x04 : FLASH key register
$52002008 constant FLASH_OPTKEYR  \ offset: 0x08 : FLASH option key register
$5200200c constant FLASH_CR       \ offset: 0x0C : FLASH control register
$52002010 constant FLASH_SR       \ offset: 0x10 : FLASH status register for bank 1
$52002014 constant FLASH_CCR      \ offset: 0x14 : FLASH clear control register for bank 1
$52002018 constant FLASH_OPTCR    \ offset: 0x18 : FLASH option control register
$5200201c constant FLASH_OPTSR_CUR  \ offset: 0x1C : FLASH option status register
$52002020 constant FLASH_OPTSR_PRG  \ offset: 0x20 : FLASH option status register
$52002024 constant FLASH_OPTCCR   \ offset: 0x24 : FLASH option clear control register
$52002028 constant FLASH_PRAR_CUR  \ offset: 0x28 : FLASH protection address for bank 1
$5200202c constant FLASH_PRAR_PRG  \ offset: 0x2C : FLASH protection address for bank 1
$52002030 constant FLASH_SCAR_CUR  \ offset: 0x30 : FLASH secure address for bank 1
$52002034 constant FLASH_SCAR_PRG  \ offset: 0x34 : FLASH secure address for bank 1
$52002038 constant FLASH_WPSN_CUR  \ offset: 0x38 : FLASH write sector protection for bank 1
$5200203c constant FLASH_WPSN_PRG  \ offset: 0x3C : FLASH write sector protection for bank 1
$52002040 constant FLASH_BOOT_CUR  \ offset: 0x40 : FLASH register with boot address
$52002044 constant FLASH_BOOT_PRG  \ offset: 0x44 : FLASH register with boot address
$52002050 constant FLASH_CRCCR    \ offset: 0x50 : FLASH CRC control register for bank 1
$52002054 constant FLASH_CRCSADDR  \ offset: 0x54 : FLASH CRC start address register for bank 1
$52002058 constant FLASH_CRCEADDR  \ offset: 0x58 : FLASH CRC end address register for bank 1
$5200205c constant FLASH_CRCDATAR  \ offset: 0x5C : FLASH CRC data register
$52002060 constant FLASH_ECC_FAR  \ offset: 0x60 : FLASH ECC fail address for bank 1
$52002070 constant FLASH_OPTSR2_CUR  \ offset: 0x70 : FLASH ECC fail address for bank 1
$52002074 constant FLASH_OPTSR2_PRG  \ offset: 0x74 : FLASH ECC fail address for bank 1

