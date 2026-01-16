\
\ @file pwr.fs
\ @brief PWR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Reset on any system reset. This register provides write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR1_LPDS                                 \ LPDS
$00000002 constant PWR_PWR_CR1_LPCFG                                \ LPCFG
$00000004 constant PWR_PWR_CR1_LVDS                                 \ LVDS
$00000010 constant PWR_PWR_CR1_PVDEN                                \ PVDEN
$000000e0 constant PWR_PWR_CR1_PLS                                  \ PLS
$00000100 constant PWR_PWR_CR1_DBP                                  \ DBP
$00010000 constant PWR_PWR_CR1_AVDEN                                \ AVDEN
$00060000 constant PWR_PWR_CR1_ALS                                  \ ALS


\
\ @brief Reset on any system reset.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000010 constant PWR_PWR_CSR1_PVDO                                \ PVDO
$00010000 constant PWR_PWR_CSR1_AVDO                                \ AVDO


\
\ @brief Not reset by wakeup from Standby mode, Application reset (NRST, IWDG, ...) and VDD POR, but reset only by VSW POR and VSWRST. Access 6 wait states when writing this register. After reset the register is write-protected and the DBP bit in the PWR control register 1 (PWR_CR1) has to be set before it can be written. When DBP is cleared, there is no bus errors generated when writing this register. This register shall not be accessed when the RCC VSWRST register bit in Section10.7.89: RCC Backup Domain Control Register (RCC_BDCR) resets the VSW domain. This register provides Write access security when enabled by TZEN register bit in Section10.7.2: RCC TrustZone Control Register (RCC_TZCR). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR2_BREN                                 \ BREN
$00000002 constant PWR_PWR_CR2_RREN                                 \ RREN
$00000010 constant PWR_PWR_CR2_MONEN                                \ MONEN
$00010000 constant PWR_PWR_CR2_BRRDY                                \ BRRDY
$00020000 constant PWR_PWR_CR2_RRRDY                                \ RRRDY
$00100000 constant PWR_PWR_CR2_VBATL                                \ VBATL
$00200000 constant PWR_PWR_CR2_VBATH                                \ VBATH
$00400000 constant PWR_PWR_CR2_TEMPL                                \ TEMPL
$00800000 constant PWR_PWR_CR2_TEMPH                                \ TEMPH


\
\ @brief Not reset by wakeup from Standby mode and Application reset (such as NRST, IWDG) but only reset by VDD POR. Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
\ Address offset: 0x0C
\ Reset value: 0x50000000
\

$00000100 constant PWR_PWR_CR3_VBE                                  \ VBE
$00000200 constant PWR_PWR_CR3_VBRS                                 \ VBRS
$00000400 constant PWR_PWR_CR3_DDRSREN                              \ DDRSREN
$00000800 constant PWR_PWR_CR3_DDRSRDIS                             \ DDRSRDIS
$00001000 constant PWR_PWR_CR3_DDRRETEN                             \ DDRRETEN
$003e0000 constant PWR_PWR_CR3_POPL                                 \ POPL
$01000000 constant PWR_PWR_CR3_USB33DEN                             \ USB33DEN
$04000000 constant PWR_PWR_CR3_USB33RDY                             \ USB33RDY
$10000000 constant PWR_PWR_CR3_REG18EN                              \ REG18EN
$20000000 constant PWR_PWR_CR3_REG18RDY                             \ REG18RDY
$40000000 constant PWR_PWR_CR3_REG11EN                              \ REG11EN
$80000000 constant PWR_PWR_CR3_REG11RDY                             \ REG11RDY


\
\ @brief See individual bits for reset condition. Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_MPUCR_PDDS                               \ PDDS
$00000008 constant PWR_PWR_MPUCR_CSTBYDIS                           \ CSTBYDIS
$00000020 constant PWR_PWR_MPUCR_STOPF                              \ STOPF
$00000040 constant PWR_PWR_MPUCR_SBF                                \ SBF
$00000080 constant PWR_PWR_MPUCR_SBFMPU                             \ SBFMPU
$00000200 constant PWR_PWR_MPUCR_CSSF                               \ CSSF
$00008000 constant PWR_PWR_MPUCR_STANDBYWFIL2                       \ STANDBYWFIL2


\
\ @brief See individual bits for reset condition. Access 6 wait states when writing this register. This register is always non-secure. When a system reset occurs during the register write cycle the written data is not guaranteed.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_MCUCR_PDDS                               \ PDDS
$00000020 constant PWR_PWR_MCUCR_STOPF                              \ STOPF
$00000040 constant PWR_PWR_MCUCR_SBF                                \ SBF
$00000200 constant PWR_PWR_MCUCR_CSSF                               \ CSSF
$00008000 constant PWR_PWR_MCUCR_DEEPSLEEP                          \ DEEPSLEEP


\
\ @brief Not reset by wakeup from Standby mode, but by any application reset (such as NRST, IWDG). Access 6 wait states when writing this register (when clearing a WKUPF, the AHB write access completes after the WKUPF has cleared). This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access on individual WKUPC[6:1], WKUPP[6:1] bits and WKUPPUPD[6:1] bit pairs are discarded when the corresponding WKUPEN[6:1] bit in PWR MPU wakeup enable register (PWR_MPUWKUPENR) is set. No bus error is generated. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPCR_WKUPC1                            \ WKUPC1
$00000002 constant PWR_PWR_WKUPCR_WKUPC2                            \ WKUPC2
$00000004 constant PWR_PWR_WKUPCR_WKUPC3                            \ WKUPC3
$00000008 constant PWR_PWR_WKUPCR_WKUPC4                            \ WKUPC4
$00000010 constant PWR_PWR_WKUPCR_WKUPC5                            \ WKUPC5
$00000020 constant PWR_PWR_WKUPCR_WKUPC6                            \ WKUPC6
$00000100 constant PWR_PWR_WKUPCR_WKUPP1                            \ WKUPP1
$00000200 constant PWR_PWR_WKUPCR_WKUPP2                            \ WKUPP2
$00000400 constant PWR_PWR_WKUPCR_WKUPP3                            \ WKUPP3
$00000800 constant PWR_PWR_WKUPCR_WKUPP4                            \ WKUPP4
$00001000 constant PWR_PWR_WKUPCR_WKUPP5                            \ WKUPP5
$00002000 constant PWR_PWR_WKUPCR_WKUPP6                            \ WKUPP6
$00030000 constant PWR_PWR_WKUPCR_WKUPPUPD1                         \ WKUPPUPD1
$000c0000 constant PWR_PWR_WKUPCR_WKUPPUPD2                         \ WKUPPUPD2
$00300000 constant PWR_PWR_WKUPCR_WKUPPUPD3                         \ WKUPPUPD3
$00c00000 constant PWR_PWR_WKUPCR_WKUPPUPD4                         \ WKUPPUPD4
$03000000 constant PWR_PWR_WKUPCR_WKUPPUPD5                         \ WKUPPUPD5
$0c000000 constant PWR_PWR_WKUPCR_WKUPPUPD6                         \ WKUPPUPD6


\
\ @brief Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...)
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPFR_WKUPF1                            \ WKUPF1
$00000002 constant PWR_PWR_WKUPFR_WKUPF2                            \ WKUPF2
$00000004 constant PWR_PWR_WKUPFR_WKUPF3                            \ WKUPF3
$00000008 constant PWR_PWR_WKUPFR_WKUPF4                            \ WKUPF4
$00000010 constant PWR_PWR_WKUPFR_WKUPF5                            \ WKUPF5
$00000020 constant PWR_PWR_WKUPFR_WKUPF6                            \ WKUPF6


\
\ @brief Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...). Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access is discarded and a bus error is generated. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_MPUWKUPENR_WKUPEN1                       \ WKUPEN1
$00000002 constant PWR_PWR_MPUWKUPENR_WKUPEN2                       \ WKUPEN2
$00000004 constant PWR_PWR_MPUWKUPENR_WKUPEN3                       \ WKUPEN3
$00000008 constant PWR_PWR_MPUWKUPENR_WKUPEN4                       \ WKUPEN4
$00000010 constant PWR_PWR_MPUWKUPENR_WKUPEN5                       \ WKUPEN5
$00000020 constant PWR_PWR_MPUWKUPENR_WKUPEN6                       \ WKUPEN6


\
\ @brief Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...) Access 6 wait states when writing this register. When a system reset occurs during the register write cycle the written data is not guaranteed.
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_MCUWKUPENR_WKUPEN1                       \ WKUPEN1
$00000002 constant PWR_PWR_MCUWKUPENR_WKUPEN2                       \ WKUPEN2
$00000004 constant PWR_PWR_MCUWKUPENR_WKUPEN3                       \ WKUPEN3
$00000008 constant PWR_PWR_MCUWKUPENR_WKUPEN4                       \ WKUPEN4
$00000010 constant PWR_PWR_MCUWKUPENR_WKUPEN5                       \ WKUPEN5
$00000020 constant PWR_PWR_MCUWKUPENR_WKUPEN6                       \ WKUPEN6


\
\ @brief PWR IP version register
\ Address offset: 0x3F4
\ Reset value: 0x00000011
\

$0000000f constant PWR_PWR_VER_MINREV                               \ MINREV
$000000f0 constant PWR_PWR_VER_MAJREV                               \ MAJREV


\
\ @brief PWR IP identification register
\ Address offset: 0x3F8
\ Reset value: 0x00010001
\

$00000000 constant PWR_PWR_ID_IPID                                  \ IPID


\
\ @brief PWR size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant PWR_PWR_SID_SID                                  \ SID


\
\ @brief PWR
\
$50001000 constant PWR_PWR_CR1    \ offset: 0x00 : Reset on any system reset. This register provides write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value.
$50001004 constant PWR_PWR_CSR1   \ offset: 0x04 : Reset on any system reset.
$50001008 constant PWR_PWR_CR2    \ offset: 0x08 : Not reset by wakeup from Standby mode, Application reset (NRST, IWDG, ...) and VDD POR, but reset only by VSW POR and VSWRST. Access 6 wait states when writing this register. After reset the register is write-protected and the DBP bit in the PWR control register 1 (PWR_CR1) has to be set before it can be written. When DBP is cleared, there is no bus errors generated when writing this register. This register shall not be accessed when the RCC VSWRST register bit in Section10.7.89: RCC Backup Domain Control Register (RCC_BDCR) resets the VSW domain. This register provides Write access security when enabled by TZEN register bit in Section10.7.2: RCC TrustZone Control Register (RCC_TZCR). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
$5000100c constant PWR_PWR_CR3    \ offset: 0x0C : Not reset by wakeup from Standby mode and Application reset (such as NRST, IWDG) but only reset by VDD POR. Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
$50001010 constant PWR_PWR_MPUCR  \ offset: 0x10 : See individual bits for reset condition. Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
$50001014 constant PWR_PWR_MCUCR  \ offset: 0x14 : See individual bits for reset condition. Access 6 wait states when writing this register. This register is always non-secure. When a system reset occurs during the register write cycle the written data is not guaranteed.
$50001020 constant PWR_PWR_WKUPCR  \ offset: 0x20 : Not reset by wakeup from Standby mode, but by any application reset (such as NRST, IWDG). Access 6 wait states when writing this register (when clearing a WKUPF, the AHB write access completes after the WKUPF has cleared). This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access on individual WKUPC[6:1], WKUPP[6:1] bits and WKUPPUPD[6:1] bit pairs are discarded when the corresponding WKUPEN[6:1] bit in PWR MPU wakeup enable register (PWR_MPUWKUPENR) is set. No bus error is generated. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
$50001024 constant PWR_PWR_WKUPFR  \ offset: 0x24 : Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...)
$50001028 constant PWR_PWR_MPUWKUPENR  \ offset: 0x28 : Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...). Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access is discarded and a bus error is generated. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
$5000102c constant PWR_PWR_MCUWKUPENR  \ offset: 0x2C : Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...) Access 6 wait states when writing this register. When a system reset occurs during the register write cycle the written data is not guaranteed.
$500013f4 constant PWR_PWR_VER    \ offset: 0x3F4 : PWR IP version register
$500013f8 constant PWR_PWR_ID     \ offset: 0x3F8 : PWR IP identification register
$500013fc constant PWR_PWR_SID    \ offset: 0x3FC : PWR size ID register

