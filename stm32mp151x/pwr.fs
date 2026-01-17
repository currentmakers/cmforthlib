\
\ @file pwr.fs
\ @brief PWR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_CR1_DEF
    \
    \ @brief Reset on any system reset. This register provides write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PWR_LPDS                       \ [0x00] LPDS
    $01 constant PWR_LPCFG                      \ [0x01] LPCFG
    $02 constant PWR_LVDS                       \ [0x02] LVDS
    $04 constant PWR_PVDEN                      \ [0x04] PVDEN
    $05 constant PWR_PLS                        \ [0x05 : 3] PLS
    $08 constant PWR_DBP                        \ [0x08] DBP
    $10 constant PWR_AVDEN                      \ [0x10] AVDEN
    $11 constant PWR_ALS                        \ [0x11 : 2] ALS
  [then]


  [ifdef] PWR_PWR_CSR1_DEF
    \
    \ @brief Reset on any system reset.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant PWR_PVDO                       \ [0x04] PVDO
    $10 constant PWR_AVDO                       \ [0x10] AVDO
  [then]


  [ifdef] PWR_PWR_CR2_DEF
    \
    \ @brief Not reset by wakeup from Standby mode, Application reset (NRST, IWDG, ...) and VDD POR, but reset only by VSW POR and VSWRST. Access 6 wait states when writing this register. After reset the register is write-protected and the DBP bit in the PWR control register 1 (PWR_CR1) has to be set before it can be written. When DBP is cleared, there is no bus errors generated when writing this register. This register shall not be accessed when the RCC VSWRST register bit in Section10.7.89: RCC Backup Domain Control Register (RCC_BDCR) resets the VSW domain. This register provides Write access security when enabled by TZEN register bit in Section10.7.2: RCC TrustZone Control Register (RCC_TZCR). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BREN                       \ [0x00] BREN
    $01 constant PWR_RREN                       \ [0x01] RREN
    $04 constant PWR_MONEN                      \ [0x04] MONEN
    $10 constant PWR_BRRDY                      \ [0x10] BRRDY
    $11 constant PWR_RRRDY                      \ [0x11] RRRDY
    $14 constant PWR_VBATL                      \ [0x14] VBATL
    $15 constant PWR_VBATH                      \ [0x15] VBATH
    $16 constant PWR_TEMPL                      \ [0x16] TEMPL
    $17 constant PWR_TEMPH                      \ [0x17] TEMPH
  [then]


  [ifdef] PWR_PWR_CR3_DEF
    \
    \ @brief Not reset by wakeup from Standby mode and Application reset (such as NRST, IWDG) but only reset by VDD POR. Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
    \ Address offset: 0x0C
    \ Reset value: 0x50000000
    \
    $08 constant PWR_VBE                        \ [0x08] VBE
    $09 constant PWR_VBRS                       \ [0x09] VBRS
    $0a constant PWR_DDRSREN                    \ [0x0a] DDRSREN
    $0b constant PWR_DDRSRDIS                   \ [0x0b] DDRSRDIS
    $0c constant PWR_DDRRETEN                   \ [0x0c] DDRRETEN
    $11 constant PWR_POPL                       \ [0x11 : 5] POPL
    $18 constant PWR_USB33DEN                   \ [0x18] USB33DEN
    $1a constant PWR_USB33RDY                   \ [0x1a] USB33RDY
    $1c constant PWR_REG18EN                    \ [0x1c] REG18EN
    $1d constant PWR_REG18RDY                   \ [0x1d] REG18RDY
    $1e constant PWR_REG11EN                    \ [0x1e] REG11EN
    $1f constant PWR_REG11RDY                   \ [0x1f] REG11RDY
  [then]


  [ifdef] PWR_PWR_MPUCR_DEF
    \
    \ @brief See individual bits for reset condition. Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PDDS                       \ [0x00] PDDS
    $03 constant PWR_CSTBYDIS                   \ [0x03] CSTBYDIS
    $05 constant PWR_STOPF                      \ [0x05] STOPF
    $06 constant PWR_SBF                        \ [0x06] SBF
    $07 constant PWR_SBFMPU                     \ [0x07] SBFMPU
    $09 constant PWR_CSSF                       \ [0x09] CSSF
    $0f constant PWR_STANDBYWFIL2               \ [0x0f] STANDBYWFIL2
  [then]


  [ifdef] PWR_PWR_MCUCR_DEF
    \
    \ @brief See individual bits for reset condition. Access 6 wait states when writing this register. This register is always non-secure. When a system reset occurs during the register write cycle the written data is not guaranteed.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PDDS                       \ [0x00] PDDS
    $05 constant PWR_STOPF                      \ [0x05] STOPF
    $06 constant PWR_SBF                        \ [0x06] SBF
    $09 constant PWR_CSSF                       \ [0x09] CSSF
    $0f constant PWR_DEEPSLEEP                  \ [0x0f] DEEPSLEEP
  [then]


  [ifdef] PWR_PWR_WKUPCR_DEF
    \
    \ @brief Not reset by wakeup from Standby mode, but by any application reset (such as NRST, IWDG). Access 6 wait states when writing this register (when clearing a WKUPF, the AHB write access completes after the WKUPF has cleared). This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access on individual WKUPC[6:1], WKUPP[6:1] bits and WKUPPUPD[6:1] bit pairs are discarded when the corresponding WKUPEN[6:1] bit in PWR MPU wakeup enable register (PWR_MPUWKUPENR) is set. No bus error is generated. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPC1                     \ [0x00] WKUPC1
    $01 constant PWR_WKUPC2                     \ [0x01] WKUPC2
    $02 constant PWR_WKUPC3                     \ [0x02] WKUPC3
    $03 constant PWR_WKUPC4                     \ [0x03] WKUPC4
    $04 constant PWR_WKUPC5                     \ [0x04] WKUPC5
    $05 constant PWR_WKUPC6                     \ [0x05] WKUPC6
    $08 constant PWR_WKUPP1                     \ [0x08] WKUPP1
    $09 constant PWR_WKUPP2                     \ [0x09] WKUPP2
    $0a constant PWR_WKUPP3                     \ [0x0a] WKUPP3
    $0b constant PWR_WKUPP4                     \ [0x0b] WKUPP4
    $0c constant PWR_WKUPP5                     \ [0x0c] WKUPP5
    $0d constant PWR_WKUPP6                     \ [0x0d] WKUPP6
    $10 constant PWR_WKUPPUPD1                  \ [0x10 : 2] WKUPPUPD1
    $12 constant PWR_WKUPPUPD2                  \ [0x12 : 2] WKUPPUPD2
    $14 constant PWR_WKUPPUPD3                  \ [0x14 : 2] WKUPPUPD3
    $16 constant PWR_WKUPPUPD4                  \ [0x16 : 2] WKUPPUPD4
    $18 constant PWR_WKUPPUPD5                  \ [0x18 : 2] WKUPPUPD5
    $1a constant PWR_WKUPPUPD6                  \ [0x1a : 2] WKUPPUPD6
  [then]


  [ifdef] PWR_PWR_WKUPFR_DEF
    \
    \ @brief Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...)
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPF1                     \ [0x00] WKUPF1
    $01 constant PWR_WKUPF2                     \ [0x01] WKUPF2
    $02 constant PWR_WKUPF3                     \ [0x02] WKUPF3
    $03 constant PWR_WKUPF4                     \ [0x03] WKUPF4
    $04 constant PWR_WKUPF5                     \ [0x04] WKUPF5
    $05 constant PWR_WKUPF6                     \ [0x05] WKUPF6
  [then]


  [ifdef] PWR_PWR_MPUWKUPENR_DEF
    \
    \ @brief Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...). Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access is discarded and a bus error is generated. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPEN1                    \ [0x00] WKUPEN1
    $01 constant PWR_WKUPEN2                    \ [0x01] WKUPEN2
    $02 constant PWR_WKUPEN3                    \ [0x02] WKUPEN3
    $03 constant PWR_WKUPEN4                    \ [0x03] WKUPEN4
    $04 constant PWR_WKUPEN5                    \ [0x04] WKUPEN5
    $05 constant PWR_WKUPEN6                    \ [0x05] WKUPEN6
  [then]


  [ifdef] PWR_PWR_MCUWKUPENR_DEF
    \
    \ @brief Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...) Access 6 wait states when writing this register. When a system reset occurs during the register write cycle the written data is not guaranteed.
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPEN1                    \ [0x00] WKUPEN1
    $01 constant PWR_WKUPEN2                    \ [0x01] WKUPEN2
    $02 constant PWR_WKUPEN3                    \ [0x02] WKUPEN3
    $03 constant PWR_WKUPEN4                    \ [0x03] WKUPEN4
    $04 constant PWR_WKUPEN5                    \ [0x04] WKUPEN5
    $05 constant PWR_WKUPEN6                    \ [0x05] WKUPEN6
  [then]


  [ifdef] PWR_PWR_VER_DEF
    \
    \ @brief PWR IP version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000011
    \
    $00 constant PWR_MINREV                     \ [0x00 : 4] MINREV
    $04 constant PWR_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] PWR_PWR_ID_DEF
    \
    \ @brief PWR IP identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00010001
    \
    $00 constant PWR_IPID                       \ [0x00 : 32] IPID
  [then]


  [ifdef] PWR_PWR_SID_DEF
    \
    \ @brief PWR size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant PWR_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief PWR
  \
  $00 constant PWR_PWR_CR1              \ Reset on any system reset. This register provides write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value.
  $04 constant PWR_PWR_CSR1             \ Reset on any system reset.
  $08 constant PWR_PWR_CR2              \ Not reset by wakeup from Standby mode, Application reset (NRST, IWDG, ...) and VDD POR, but reset only by VSW POR and VSWRST. Access 6 wait states when writing this register. After reset the register is write-protected and the DBP bit in the PWR control register 1 (PWR_CR1) has to be set before it can be written. When DBP is cleared, there is no bus errors generated when writing this register. This register shall not be accessed when the RCC VSWRST register bit in Section10.7.89: RCC Backup Domain Control Register (RCC_BDCR) resets the VSW domain. This register provides Write access security when enabled by TZEN register bit in Section10.7.2: RCC TrustZone Control Register (RCC_TZCR). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
  $0C constant PWR_PWR_CR3              \ Not reset by wakeup from Standby mode and Application reset (such as NRST, IWDG) but only reset by VDD POR. Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
  $10 constant PWR_PWR_MPUCR            \ See individual bits for reset condition. Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access generates a bus error. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
  $14 constant PWR_PWR_MCUCR            \ See individual bits for reset condition. Access 6 wait states when writing this register. This register is always non-secure. When a system reset occurs during the register write cycle the written data is not guaranteed.
  $20 constant PWR_PWR_WKUPCR           \ Not reset by wakeup from Standby mode, but by any application reset (such as NRST, IWDG). Access 6 wait states when writing this register (when clearing a WKUPF, the AHB write access completes after the WKUPF has cleared). This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access on individual WKUPC[6:1], WKUPP[6:1] bits and WKUPPUPD[6:1] bit pairs are discarded when the corresponding WKUPEN[6:1] bit in PWR MPU wakeup enable register (PWR_MPUWKUPENR) is set. No bus error is generated. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
  $24 constant PWR_PWR_WKUPFR           \ Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...)
  $28 constant PWR_PWR_MPUWKUPENR       \ Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...). Access 6 wait states when writing this register. This register provides Write access security when enabled by TZEN register bit in Section10: Reset and clock control (RCC). When security is enabled a non-secure write access is discarded and a bus error is generated. Secure and non-secure read accesses are granted and return the register value. When a system reset occurs during the register write cycle the written data is not guaranteed.
  $2C constant PWR_PWR_MCUWKUPENR       \ Not reset by wakeup from Standby mode but by any Application reset (NRST, IWDG, ...) Access 6 wait states when writing this register. When a system reset occurs during the register write cycle the written data is not guaranteed.
  $3F4 constant PWR_PWR_VER             \ PWR IP version register
  $3F8 constant PWR_PWR_ID              \ PWR IP identification register
  $3FC constant PWR_PWR_SID             \ PWR size ID register

: PWR_DEF ; [then]
