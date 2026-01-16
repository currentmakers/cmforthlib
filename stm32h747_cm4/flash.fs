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
\ Reset value: 0x00000600
\

$00000007 constant FLASH_ACR_LATENCY                                \ Read latency
$00000030 constant FLASH_ACR_WRHIGHFREQ                             \ Flash signal delay


\
\ @brief FLASH key register for bank 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant FLASH_KEYR1_KEYR1                                \ Bank 1 access configuration unlock key


\
\ @brief FLASH option key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant FLASH_OPTKEYR_OPTKEYR                            \ Unlock key option bytes


\
\ @brief FLASH control register for bank 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_CR1_LOCK1                                  \ Bank 1 configuration lock bit
$00000002 constant FLASH_CR1_PG1                                    \ Bank 1 program enable bit
$00000004 constant FLASH_CR1_SER1                                   \ Bank 1 sector erase request
$00000008 constant FLASH_CR1_BER1                                   \ Bank 1 erase request
$00000030 constant FLASH_CR1_PSIZE1                                 \ Bank 1 program size
$00000040 constant FLASH_CR1_FW1                                    \ Bank 1 write forcing control bit
$00000080 constant FLASH_CR1_START1                                 \ Bank 1 bank or sector erase start control bit
$00000700 constant FLASH_CR1_SNB1                                   \ Bank 1 sector erase selection number
$00008000 constant FLASH_CR1_CRC_EN                                 \ Bank 1 CRC control bit
$00010000 constant FLASH_CR1_EOPIE1                                 \ Bank 1 end-of-program interrupt control bit
$00020000 constant FLASH_CR1_WRPERRIE1                              \ Bank 1 write protection error interrupt enable bit
$00040000 constant FLASH_CR1_PGSERRIE1                              \ Bank 1 programming sequence error interrupt enable bit
$00080000 constant FLASH_CR1_STRBERRIE1                             \ Bank 1 strobe error interrupt enable bit
$00200000 constant FLASH_CR1_INCERRIE1                              \ Bank 1 inconsistency error interrupt enable bit
$00400000 constant FLASH_CR1_OPERRIE1                               \ Bank 1 write/erase error interrupt enable bit
$00800000 constant FLASH_CR1_RDPERRIE1                              \ Bank 1 read protection error interrupt enable bit
$01000000 constant FLASH_CR1_RDSERRIE1                              \ Bank 1 secure error interrupt enable bit
$02000000 constant FLASH_CR1_SNECCERRIE1                            \ Bank 1 ECC single correction error interrupt enable bit
$04000000 constant FLASH_CR1_DBECCERRIE1                            \ Bank 1 ECC double detection error interrupt enable bit
$08000000 constant FLASH_CR1_CRCENDIE1                              \ Bank 1 end of CRC calculation interrupt enable bit


\
\ @brief FLASH status register for bank 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant FLASH_SR1_BSY1                                   \ Bank 1 ongoing program flag
$00000002 constant FLASH_SR1_WBNE1                                  \ Bank 1 write buffer not empty flag
$00000004 constant FLASH_SR1_QW1                                    \ Bank 1 wait queue flag
$00000008 constant FLASH_SR1_CRC_BUSY1                              \ Bank 1 CRC busy flag
$00010000 constant FLASH_SR1_EOP1                                   \ Bank 1 end-of-program flag
$00020000 constant FLASH_SR1_WRPERR1                                \ Bank 1 write protection error flag
$00040000 constant FLASH_SR1_PGSERR1                                \ Bank 1 programming sequence error flag
$00080000 constant FLASH_SR1_STRBERR1                               \ Bank 1 strobe error flag
$00200000 constant FLASH_SR1_INCERR1                                \ Bank 1 inconsistency error flag
$00400000 constant FLASH_SR1_OPERR1                                 \ Bank 1 write/erase error flag
$00800000 constant FLASH_SR1_RDPERR1                                \ Bank 1 read protection error flag
$01000000 constant FLASH_SR1_RDSERR1                                \ Bank 1 secure error flag
$02000000 constant FLASH_SR1_SNECCERR11                             \ Bank 1 single correction error flag
$04000000 constant FLASH_SR1_DBECCERR1                              \ Bank 1 ECC double detection error flag
$08000000 constant FLASH_SR1_CRCEND1                                \ Bank 1 CRC-complete flag


\
\ @brief FLASH clear control register for bank 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00010000 constant FLASH_CCR1_CLR_EOP1                              \ Bank 1 EOP1 flag clear bit
$00020000 constant FLASH_CCR1_CLR_WRPERR1                           \ Bank 1 WRPERR1 flag clear bit
$00040000 constant FLASH_CCR1_CLR_PGSERR1                           \ Bank 1 PGSERR1 flag clear bi
$00080000 constant FLASH_CCR1_CLR_STRBERR1                          \ Bank 1 STRBERR1 flag clear bit
$00200000 constant FLASH_CCR1_CLR_INCERR1                           \ Bank 1 INCERR1 flag clear bit
$00400000 constant FLASH_CCR1_CLR_OPERR1                            \ Bank 1 OPERR1 flag clear bit
$00800000 constant FLASH_CCR1_CLR_RDPERR1                           \ Bank 1 RDPERR1 flag clear bit
$01000000 constant FLASH_CCR1_CLR_RDSERR1                           \ Bank 1 RDSERR1 flag clear bit
$02000000 constant FLASH_CCR1_CLR_SNECCERR1                         \ Bank 1 SNECCERR1 flag clear bit
$04000000 constant FLASH_CCR1_CLR_DBECCERR1                         \ Bank 1 DBECCERR1 flag clear bit
$08000000 constant FLASH_CCR1_CLR_CRCEND1                           \ Bank 1 CRCEND1 flag clear bit


\
\ @brief FLASH option control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant FLASH_OPTCR_OPTLOCK                              \ FLASH_OPTCR lock option configuration bit
$00000002 constant FLASH_OPTCR_OPTSTART                             \ Option byte start change option configuration bit
$00000010 constant FLASH_OPTCR_MER                                  \ Flash mass erase enable bit
$40000000 constant FLASH_OPTCR_OPTCHANGEERRIE                       \ Option byte change error interrupt enable bit
$80000000 constant FLASH_OPTCR_SWAP_BANK                            \ Bank swapping configuration bit


\
\ @brief FLASH option status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_OPTSR_CUR_OPT_BUSY                         \ Option byte change ongoing flag
$0000000c constant FLASH_OPTSR_CUR_BOR_LEV                          \ Brownout level option status bit
$00000010 constant FLASH_OPTSR_CUR_IWDG1_HW                         \ IWDG1 control option status bit
$00000040 constant FLASH_OPTSR_CUR_NRST_STOP_D1                     \ D1 DStop entry reset option status bit
$00000080 constant FLASH_OPTSR_CUR_NRST_STBY_D1                     \ D1 DStandby entry reset option status bit
$0000ff00 constant FLASH_OPTSR_CUR_RDP                              \ Readout protection level option status byte
$00020000 constant FLASH_OPTSR_CUR_FZ_IWDG_STOP                     \ IWDG Stop mode freeze option status bit
$00040000 constant FLASH_OPTSR_CUR_FZ_IWDG_SDBY                     \ IWDG Standby mode freeze option status bit
$00180000 constant FLASH_OPTSR_CUR_ST_RAM_SIZE                      \ DTCM RAM size option status
$00200000 constant FLASH_OPTSR_CUR_SECURITY                         \ Security enable option status bit
$04000000 constant FLASH_OPTSR_CUR_RSS1                             \ User option bit 1
$10000000 constant FLASH_OPTSR_CUR_PERSO_OK                         \ Device personalization status bit
$20000000 constant FLASH_OPTSR_CUR_IO_HSLV                          \ I/O high-speed at low-voltage status bit (PRODUCT_BELOW_25V)
$40000000 constant FLASH_OPTSR_CUR_OPTCHANGEERR                     \ Option byte change error flag
$80000000 constant FLASH_OPTSR_CUR_SWAP_BANK_OPT                    \ Bank swapping option status bit


\
\ @brief FLASH option status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000c constant FLASH_OPTSR_PRG_BOR_LEV                          \ BOR reset level option configuration bits
$00000010 constant FLASH_OPTSR_PRG_IWDG1_HW                         \ IWDG1 option configuration bit
$00000040 constant FLASH_OPTSR_PRG_NRST_STOP_D1                     \ Option byte erase after D1 DStop option configuration bit
$00000080 constant FLASH_OPTSR_PRG_NRST_STBY_D1                     \ Option byte erase after D1 DStandby option configuration bit
$0000ff00 constant FLASH_OPTSR_PRG_RDP                              \ Readout protection level option configuration byte
$00020000 constant FLASH_OPTSR_PRG_FZ_IWDG_STOP                     \ IWDG Stop mode freeze option configuration bit
$00040000 constant FLASH_OPTSR_PRG_FZ_IWDG_SDBY                     \ IWDG Standby mode freeze option configuration bit
$00180000 constant FLASH_OPTSR_PRG_ST_RAM_SIZE                      \ DTCM size select option configuration bits
$00200000 constant FLASH_OPTSR_PRG_SECURITY                         \ Security option configuration bit
$04000000 constant FLASH_OPTSR_PRG_RSS1                             \ User option configuration bit 1
$08000000 constant FLASH_OPTSR_PRG_RSS2                             \ User option configuration bit 2
$20000000 constant FLASH_OPTSR_PRG_IO_HSLV                          \ I/O high-speed at low-voltage (PRODUCT_BELOW_25V)
$80000000 constant FLASH_OPTSR_PRG_SWAP_BANK_OPT                    \ Bank swapping option configuration bit


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

$00000fff constant FLASH_PRAR_CUR1_PROT_AREA_START1                 \ Bank 1 lowest PCROP protected address
$0fff0000 constant FLASH_PRAR_CUR1_PROT_AREA_END1                   \ Bank 1 highest PCROP protected address
$80000000 constant FLASH_PRAR_CUR1_DMEP1                            \ Bank 1 PCROP protected erase enable option status bit


\
\ @brief FLASH protection address for bank 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant FLASH_PRAR_PRG1_PROT_AREA_START1                 \ Bank 1 lowest PCROP protected address configuration
$0fff0000 constant FLASH_PRAR_PRG1_PROT_AREA_END1                   \ Bank 1 highest PCROP protected address configuration
$80000000 constant FLASH_PRAR_PRG1_DMEP1                            \ Bank 1 PCROP protected erase enable option configuration bit


\
\ @brief FLASH protection address for bank 2
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant FLASH_PRAR_PRG2_PROT_AREA_START2                 \ Bank 2 lowest PCROP protected address configuration
$0fff0000 constant FLASH_PRAR_PRG2_PROT_AREA_END2                   \ Bank 2 highest PCROP protected address configuration
$80000000 constant FLASH_PRAR_PRG2_DMEP2                            \ Bank 2 PCROP protected erase enable option configuration bit


\
\ @brief FLASH secure address for bank 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000fff constant FLASH_SCAR_CUR1_SEC_AREA_START1                  \ Bank 1 lowest secure protected address
$0fff0000 constant FLASH_SCAR_CUR1_SEC_AREA_END1                    \ Bank 1 highest secure protected address
$80000000 constant FLASH_SCAR_CUR1_DMES1                            \ Bank 1 secure protected erase enable option status bit


\
\ @brief FLASH secure address for bank 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000fff constant FLASH_SCAR_PRG1_SEC_AREA_START1                  \ Bank 1 lowest secure protected address configuration
$0fff0000 constant FLASH_SCAR_PRG1_SEC_AREA_END1                    \ Bank 1 highest secure protected address configuration
$80000000 constant FLASH_SCAR_PRG1_DMES1                            \ Bank 1 secure protected erase enable option configuration bit


\
\ @brief FLASH write sector protection for bank 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000ff constant FLASH_WPSN_CUR1R_WRPSN1                          \ Bank 1 sector write protection option status byte


\
\ @brief FLASH write sector protection for bank 1
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000000ff constant FLASH_WPSN_PRG1R_WRPSN1                          \ Bank 1 sector write protection configuration byte


\
\ @brief FLASH register with boot address
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_BOOT_CURR_BOOT_ADD0                        \ Boot address 0
$ffff0000 constant FLASH_BOOT_CURR_BOOT_ADD1                        \ Boot address 1


\
\ @brief FLASH register with boot address
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant FLASH_BOOT_PRGR_BOOT_ADD0                        \ Boot address 0
$ffff0000 constant FLASH_BOOT_PRGR_BOOT_ADD1                        \ Boot address 1


\
\ @brief FLASH CRC control register for bank 1
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000007 constant FLASH_CRCCR1_CRC_SECT                            \ Bank 1 CRC sector number
$00000080 constant FLASH_CRCCR1_ALL_BANK                            \ Bank 1 CRC select bit
$00000100 constant FLASH_CRCCR1_CRC_BY_SECT                         \ Bank 1 CRC sector mode select bit
$00000200 constant FLASH_CRCCR1_ADD_SECT                            \ Bank 1 CRC sector select bit
$00000400 constant FLASH_CRCCR1_CLEAN_SECT                          \ Bank 1 CRC sector list clear bit
$00010000 constant FLASH_CRCCR1_START_CRC                           \ Bank 1 CRC start bit
$00020000 constant FLASH_CRCCR1_CLEAN_CRC                           \ Bank 1 CRC clear bit
$00300000 constant FLASH_CRCCR1_CRC_BURST                           \ Bank 1 CRC burst size


\
\ @brief FLASH CRC start address register for bank 1
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant FLASH_CRCSADD1R_CRC_START_ADDR                   \ CRC start address on bank 1


\
\ @brief FLASH CRC end address register for bank 1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant FLASH_CRCEADD1R_CRC_END_ADDR                     \ CRC end address on bank 1


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

$00007fff constant FLASH_ECC_FA1R_FAIL_ECC_ADDR1                    \ Bank 1 ECC error address


\
\ @brief Access control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant FLASH_ACR__LATENCY                               \ Read latency
$00000030 constant FLASH_ACR__WRHIGHFREQ                            \ Flash signal delay


\
\ @brief FLASH key register for bank 2
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant FLASH_KEYR2_KEYR2                                \ Bank 2 access configuration unlock key


\
\ @brief FLASH option key register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant FLASH_OPTKEYR__OPTKEYR                           \ Unlock key option bytes


\
\ @brief FLASH control register for bank 2
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_CR2_LOCK2                                  \ Bank 2 configuration lock bit
$00000002 constant FLASH_CR2_PG2                                    \ Bank 2 program enable bit
$00000004 constant FLASH_CR2_SER2                                   \ Bank 2 sector erase request
$00000008 constant FLASH_CR2_BER2                                   \ Bank 2 erase request
$00000030 constant FLASH_CR2_PSIZE2                                 \ Bank 2 program size
$00000040 constant FLASH_CR2_FW2                                    \ Bank 2 write forcing control bit
$00000080 constant FLASH_CR2_START2                                 \ Bank 2 bank or sector erase start control bit
$00000700 constant FLASH_CR2_SNB2                                   \ Bank 2 sector erase selection number
$00008000 constant FLASH_CR2_CRC_EN                                 \ Bank 2 CRC control bit
$00010000 constant FLASH_CR2_EOPIE2                                 \ Bank 2 end-of-program interrupt control bit
$00020000 constant FLASH_CR2_WRPERRIE2                              \ Bank 2 write protection error interrupt enable bit
$00040000 constant FLASH_CR2_PGSERRIE2                              \ Bank 2 programming sequence error interrupt enable bit
$00080000 constant FLASH_CR2_STRBERRIE2                             \ Bank 2 strobe error interrupt enable bit
$00200000 constant FLASH_CR2_INCERRIE2                              \ Bank 2 inconsistency error interrupt enable bit
$00400000 constant FLASH_CR2_OPERRIE2                               \ Bank 2 write/erase error interrupt enable bit
$00800000 constant FLASH_CR2_RDPERRIE2                              \ Bank 2 read protection error interrupt enable bit
$01000000 constant FLASH_CR2_RDSERRIE2                              \ Bank 2 secure error interrupt enable bit
$02000000 constant FLASH_CR2_SNECCERRIE2                            \ Bank 2 ECC single correction error interrupt enable bit
$04000000 constant FLASH_CR2_DBECCERRIE2                            \ Bank 2 ECC double detection error interrupt enable bit
$08000000 constant FLASH_CR2_CRCENDIE2                              \ Bank 2 end of CRC calculation interrupt enable bit


\
\ @brief FLASH status register for bank 2
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant FLASH_SR2_BSY2                                   \ Bank 2 ongoing program flag
$00000002 constant FLASH_SR2_WBNE2                                  \ Bank 2 write buffer not empty flag
$00000004 constant FLASH_SR2_QW2                                    \ Bank 2 wait queue flag
$00000008 constant FLASH_SR2_CRC_BUSY2                              \ Bank 2 CRC busy flag
$00010000 constant FLASH_SR2_EOP2                                   \ Bank 2 end-of-program flag
$00020000 constant FLASH_SR2_WRPERR2                                \ Bank 2 write protection error flag
$00040000 constant FLASH_SR2_PGSERR2                                \ Bank 2 programming sequence error flag
$00080000 constant FLASH_SR2_STRBERR2                               \ Bank 2 strobe error flag
$00200000 constant FLASH_SR2_INCERR2                                \ Bank 2 inconsistency error flag
$00400000 constant FLASH_SR2_OPERR2                                 \ Bank 2 write/erase error flag
$00800000 constant FLASH_SR2_RDPERR2                                \ Bank 2 read protection error flag
$01000000 constant FLASH_SR2_RDSERR2                                \ Bank 2 secure error flag
$02000000 constant FLASH_SR2_SNECCERR2                              \ Bank 2 single correction error flag
$04000000 constant FLASH_SR2_DBECCERR2                              \ Bank 2 ECC double detection error flag
$08000000 constant FLASH_SR2_CRCEND2                                \ Bank 2 CRC-complete flag


\
\ @brief FLASH clear control register for bank 2
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00010000 constant FLASH_CCR2_CLR_EOP2                              \ Bank 1 EOP1 flag clear bit
$00020000 constant FLASH_CCR2_CLR_WRPERR2                           \ Bank 2 WRPERR1 flag clear bit
$00040000 constant FLASH_CCR2_CLR_PGSERR2                           \ Bank 2 PGSERR1 flag clear bi
$00080000 constant FLASH_CCR2_CLR_STRBERR2                          \ Bank 2 STRBERR1 flag clear bit
$00200000 constant FLASH_CCR2_CLR_INCERR2                           \ Bank 2 INCERR1 flag clear bit
$00400000 constant FLASH_CCR2_CLR_OPERR2                            \ Bank 2 OPERR1 flag clear bit
$00800000 constant FLASH_CCR2_CLR_RDPERR2                           \ Bank 2 RDPERR1 flag clear bit
$01000000 constant FLASH_CCR2_CLR_RDSERR1                           \ Bank 1 RDSERR1 flag clear bit
$02000000 constant FLASH_CCR2_CLR_SNECCERR2                         \ Bank 2 SNECCERR1 flag clear bit
$04000000 constant FLASH_CCR2_CLR_DBECCERR1                         \ Bank 1 DBECCERR1 flag clear bit
$08000000 constant FLASH_CCR2_CLR_CRCEND2                           \ Bank 2 CRCEND1 flag clear bit


\
\ @brief FLASH option control register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000001 constant FLASH_OPTCR__OPTLOCK                             \ FLASH_OPTCR lock option configuration bit
$00000002 constant FLASH_OPTCR__OPTSTART                            \ Option byte start change option configuration bit
$00000010 constant FLASH_OPTCR__MER                                 \ Flash mass erase enable bit
$40000000 constant FLASH_OPTCR__OPTCHANGEERRIE                      \ Option byte change error interrupt enable bit
$80000000 constant FLASH_OPTCR__SWAP_BANK                           \ Bank swapping configuration bit


\
\ @brief FLASH option status register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000001 constant FLASH_OPTSR_CUR__OPT_BUSY                        \ Option byte change ongoing flag
$0000000c constant FLASH_OPTSR_CUR__BOR_LEV                         \ Brownout level option status bit
$00000010 constant FLASH_OPTSR_CUR__IWDG1_HW                        \ IWDG1 control option status bit
$00000040 constant FLASH_OPTSR_CUR__NRST_STOP_D1                    \ D1 DStop entry reset option status bit
$00000080 constant FLASH_OPTSR_CUR__NRST_STBY_D1                    \ D1 DStandby entry reset option status bit
$0000ff00 constant FLASH_OPTSR_CUR__RDP                             \ Readout protection level option status byte
$00020000 constant FLASH_OPTSR_CUR__FZ_IWDG_STOP                    \ IWDG Stop mode freeze option status bit
$00040000 constant FLASH_OPTSR_CUR__FZ_IWDG_SDBY                    \ IWDG Standby mode freeze option status bit
$00180000 constant FLASH_OPTSR_CUR__ST_RAM_SIZE                     \ DTCM RAM size option status
$00200000 constant FLASH_OPTSR_CUR__SECURITY                        \ Security enable option status bit
$04000000 constant FLASH_OPTSR_CUR__RSS1                            \ User option bit 1
$10000000 constant FLASH_OPTSR_CUR__PERSO_OK                        \ Device personalization status bit
$20000000 constant FLASH_OPTSR_CUR__IO_HSLV                         \ I/O high-speed at low-voltage status bit (PRODUCT_BELOW_25V)
$40000000 constant FLASH_OPTSR_CUR__OPTCHANGEERR                    \ Option byte change error flag
$80000000 constant FLASH_OPTSR_CUR__SWAP_BANK_OPT                   \ Bank swapping option status bit


\
\ @brief FLASH option status register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000000c constant FLASH_OPTSR_PRG__BOR_LEV                         \ BOR reset level option configuration bits
$00000010 constant FLASH_OPTSR_PRG__IWDG1_HW                        \ IWDG1 option configuration bit
$00000040 constant FLASH_OPTSR_PRG__NRST_STOP_D1                    \ Option byte erase after D1 DStop option configuration bit
$00000080 constant FLASH_OPTSR_PRG__NRST_STBY_D1                    \ Option byte erase after D1 DStandby option configuration bit
$0000ff00 constant FLASH_OPTSR_PRG__RDP                             \ Readout protection level option configuration byte
$00020000 constant FLASH_OPTSR_PRG__FZ_IWDG_STOP                    \ IWDG Stop mode freeze option configuration bit
$00040000 constant FLASH_OPTSR_PRG__FZ_IWDG_SDBY                    \ IWDG Standby mode freeze option configuration bit
$00180000 constant FLASH_OPTSR_PRG__ST_RAM_SIZE                     \ DTCM size select option configuration bits
$00200000 constant FLASH_OPTSR_PRG__SECURITY                        \ Security option configuration bit
$04000000 constant FLASH_OPTSR_PRG__RSS1                            \ User option configuration bit 1
$08000000 constant FLASH_OPTSR_PRG__RSS2                            \ User option configuration bit 2
$20000000 constant FLASH_OPTSR_PRG__IO_HSLV                         \ I/O high-speed at low-voltage (PRODUCT_BELOW_25V)
$80000000 constant FLASH_OPTSR_PRG__SWAP_BANK_OPT                   \ Bank swapping option configuration bit


\
\ @brief FLASH option clear control register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$40000000 constant FLASH_OPTCCR__CLR_OPTCHANGEERR                   \ OPTCHANGEERR reset bit


\
\ @brief FLASH protection address for bank 1
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000fff constant FLASH_PRAR_CUR2_PROT_AREA_START2                 \ Bank 2 lowest PCROP protected address
$0fff0000 constant FLASH_PRAR_CUR2_PROT_AREA_END2                   \ Bank 2 highest PCROP protected address
$80000000 constant FLASH_PRAR_CUR2_DMEP2                            \ Bank 2 PCROP protected erase enable option status bit


\
\ @brief FLASH secure address for bank 2
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000fff constant FLASH_SCAR_CUR2_SEC_AREA_START2                  \ Bank 2 lowest secure protected address
$0fff0000 constant FLASH_SCAR_CUR2_SEC_AREA_END2                    \ Bank 2 highest secure protected address
$80000000 constant FLASH_SCAR_CUR2_DMES2                            \ Bank 2 secure protected erase enable option status bit


\
\ @brief FLASH secure address for bank 2
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000fff constant FLASH_SCAR_PRG2_SEC_AREA_START2                  \ Bank 2 lowest secure protected address configuration
$0fff0000 constant FLASH_SCAR_PRG2_SEC_AREA_END2                    \ Bank 2 highest secure protected address configuration
$80000000 constant FLASH_SCAR_PRG2_DMES2                            \ Bank 2 secure protected erase enable option configuration bit


\
\ @brief FLASH write sector protection for bank 2
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$000000ff constant FLASH_WPSN_CUR2R_WRPSN2                          \ Bank 2 sector write protection option status byte


\
\ @brief FLASH write sector protection for bank 2
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$000000ff constant FLASH_WPSN_PRG2R_WRPSN2                          \ Bank 2 sector write protection configuration byte


\
\ @brief FLASH CRC control register for bank 1
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000007 constant FLASH_CRCCR2_CRC_SECT                            \ Bank 2 CRC sector number
$00000080 constant FLASH_CRCCR2_ALL_BANK                            \ Bank 2 CRC select bit
$00000100 constant FLASH_CRCCR2_CRC_BY_SECT                         \ Bank 2 CRC sector mode select bit
$00000200 constant FLASH_CRCCR2_ADD_SECT                            \ Bank 2 CRC sector select bit
$00000400 constant FLASH_CRCCR2_CLEAN_SECT                          \ Bank 2 CRC sector list clear bit
$00010000 constant FLASH_CRCCR2_START_CRC                           \ Bank 2 CRC start bit
$00020000 constant FLASH_CRCCR2_CLEAN_CRC                           \ Bank 2 CRC clear bit
$00300000 constant FLASH_CRCCR2_CRC_BURST                           \ Bank 2 CRC burst size


\
\ @brief FLASH CRC start address register for bank 2
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant FLASH_CRCSADD2R_CRC_START_ADDR                   \ CRC start address on bank 2


\
\ @brief FLASH CRC end address register for bank 2
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant FLASH_CRCEADD2R_CRC_END_ADDR                     \ CRC end address on bank 2


\
\ @brief FLASH ECC fail address for bank 2
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00007fff constant FLASH_ECC_FA2R_FAIL_ECC_ADDR2                    \ Bank 2 ECC error address


\
\ @brief Flash
\
$52002000 constant FLASH_ACR      \ offset: 0x00 : Access control register
$52002004 constant FLASH_KEYR1    \ offset: 0x04 : FLASH key register for bank 1
$52002008 constant FLASH_OPTKEYR  \ offset: 0x08 : FLASH option key register
$5200200c constant FLASH_CR1      \ offset: 0x0C : FLASH control register for bank 1
$52002010 constant FLASH_SR1      \ offset: 0x10 : FLASH status register for bank 1
$52002014 constant FLASH_CCR1     \ offset: 0x14 : FLASH clear control register for bank 1
$52002018 constant FLASH_OPTCR    \ offset: 0x18 : FLASH option control register
$5200201c constant FLASH_OPTSR_CUR  \ offset: 0x1C : FLASH option status register
$52002020 constant FLASH_OPTSR_PRG  \ offset: 0x20 : FLASH option status register
$52002024 constant FLASH_OPTCCR   \ offset: 0x24 : FLASH option clear control register
$52002028 constant FLASH_PRAR_CUR1  \ offset: 0x28 : FLASH protection address for bank 1
$5200202c constant FLASH_PRAR_PRG1  \ offset: 0x2C : FLASH protection address for bank 1
$5200202c constant FLASH_PRAR_PRG2  \ offset: 0x2C : FLASH protection address for bank 2
$52002030 constant FLASH_SCAR_CUR1  \ offset: 0x30 : FLASH secure address for bank 1
$52002034 constant FLASH_SCAR_PRG1  \ offset: 0x34 : FLASH secure address for bank 1
$52002038 constant FLASH_WPSN_CUR1R  \ offset: 0x38 : FLASH write sector protection for bank 1
$5200203c constant FLASH_WPSN_PRG1R  \ offset: 0x3C : FLASH write sector protection for bank 1
$52002040 constant FLASH_BOOT_CURR  \ offset: 0x40 : FLASH register with boot address
$52002044 constant FLASH_BOOT_PRGR  \ offset: 0x44 : FLASH register with boot address
$52002050 constant FLASH_CRCCR1   \ offset: 0x50 : FLASH CRC control register for bank 1
$52002054 constant FLASH_CRCSADD1R  \ offset: 0x54 : FLASH CRC start address register for bank 1
$52002058 constant FLASH_CRCEADD1R  \ offset: 0x58 : FLASH CRC end address register for bank 1
$5200205c constant FLASH_CRCDATAR  \ offset: 0x5C : FLASH CRC data register
$52002060 constant FLASH_ECC_FA1R  \ offset: 0x60 : FLASH ECC fail address for bank 1
$52002100 constant FLASH_ACR_     \ offset: 0x100 : Access control register
$52002104 constant FLASH_KEYR2    \ offset: 0x104 : FLASH key register for bank 2
$52002108 constant FLASH_OPTKEYR_  \ offset: 0x108 : FLASH option key register
$5200210c constant FLASH_CR2      \ offset: 0x10C : FLASH control register for bank 2
$52002110 constant FLASH_SR2      \ offset: 0x110 : FLASH status register for bank 2
$52002114 constant FLASH_CCR2     \ offset: 0x114 : FLASH clear control register for bank 2
$52002118 constant FLASH_OPTCR_   \ offset: 0x118 : FLASH option control register
$5200211c constant FLASH_OPTSR_CUR_  \ offset: 0x11C : FLASH option status register
$52002120 constant FLASH_OPTSR_PRG_  \ offset: 0x120 : FLASH option status register
$52002124 constant FLASH_OPTCCR_  \ offset: 0x124 : FLASH option clear control register
$52002128 constant FLASH_PRAR_CUR2  \ offset: 0x128 : FLASH protection address for bank 1
$52002130 constant FLASH_SCAR_CUR2  \ offset: 0x130 : FLASH secure address for bank 2
$52002134 constant FLASH_SCAR_PRG2  \ offset: 0x134 : FLASH secure address for bank 2
$52002138 constant FLASH_WPSN_CUR2R  \ offset: 0x138 : FLASH write sector protection for bank 2
$5200213c constant FLASH_WPSN_PRG2R  \ offset: 0x13C : FLASH write sector protection for bank 2
$52002150 constant FLASH_CRCCR2   \ offset: 0x150 : FLASH CRC control register for bank 1
$52002154 constant FLASH_CRCSADD2R  \ offset: 0x154 : FLASH CRC start address register for bank 2
$52002158 constant FLASH_CRCEADD2R  \ offset: 0x158 : FLASH CRC end address register for bank 2
$52002160 constant FLASH_ECC_FA2R  \ offset: 0x160 : FLASH ECC fail address for bank 2

