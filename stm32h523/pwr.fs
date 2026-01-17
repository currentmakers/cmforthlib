\
\ @file pwr.fs
\ @brief PWR address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_PMCR_DEF
    \
    \ @brief PWR power mode control register
    \ Address offset: 0x00
    \ Reset value: 0x0000000C
    \
    $00 constant PWR_LPMS                       \ [0x00] low-power mode selection
    $02 constant PWR_SVOS                       \ [0x02 : 2] system Stop mode voltage scaling selection
    $07 constant PWR_CSSF                       \ [0x07] clear Standby and Stop flags (always read as 0)
    $09 constant PWR_FLPS                       \ [0x09] flash memory low-power mode in Stop mode
    $0c constant PWR_BOOSTE                     \ [0x0c] analog switch Vless thansub>BOOSTless than/sub> control
    $0d constant PWR_AVD_READY                  \ [0x0d] analog voltage ready
    $10 constant PWR_ETHERNETSO                 \ [0x10] ETHERNET RAM shut-off in Stop mode.
    $17 constant PWR_SRAM3SO                    \ [0x17] AHB SRAM3 shut-off in Stop mode.
    $18 constant PWR_SRAM2_16SO                 \ [0x18] AHB SRAM2 16-Kbyte shut-off in Stop mode.
    $19 constant PWR_SRAM2_48SO                 \ [0x19] AHB SRAM2 48-Kbyte shut-off in Stop mode.
    $1a constant PWR_SRAM1SO                    \ [0x1a] AHB SRAM1 shut-off in Stop mode
  [then]


  [ifdef] PWR_PWR_PMCR_ALTERNATE1_DEF
    \
    \ @brief PWR power mode control register
    \ Address offset: 0x00
    \ Reset value: 0x0000000C
    \
    $00 constant PWR_LPMS                       \ [0x00] low-power mode selection
    $02 constant PWR_SVOS                       \ [0x02 : 2] system Stop mode voltage scaling selection
    $07 constant PWR_CSSF                       \ [0x07] clear Standby and Stop flags (always read as 0)
    $09 constant PWR_FLPS                       \ [0x09] flash memory low-power mode in Stop mode
    $0c constant PWR_BOOSTE                     \ [0x0c] analog switch Vless thansub>BOOSTless than/sub> control
    $0d constant PWR_AVD_READY                  \ [0x0d] analog voltage ready
    $17 constant PWR_SRAM3SO                    \ [0x17] AHB SRAM3 shut-off in Stop mode.
    $18 constant PWR_SRAM2_16LSO                \ [0x18] AHB SRAM2 low 16-Kbyte shut-off in Stop mode.
    $19 constant PWR_SRAM2_16HSO                \ [0x19] AHB SRAM2 high 16-Kbyte shut-off in Stop mode.
    $1a constant PWR_SRAM2_48SO                 \ [0x1a] AHB SRAM2 48-Kbyte shut-off in Stop mode.
    $1b constant PWR_SRAM1SO                    \ [0x1b] AHB SRAM1 shut-off in Stop mode
  [then]


  [ifdef] PWR_PWR_PMSR_DEF
    \
    \ @brief PWR status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $05 constant PWR_STOPF                      \ [0x05] Stop flag
    $06 constant PWR_SBF                        \ [0x06] System standby flag
  [then]


  [ifdef] PWR_PWR_VOSCR_DEF
    \
    \ @brief PWR voltage scaling control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant PWR_VOS                        \ [0x04 : 2] voltage scaling selection according to performance
  [then]


  [ifdef] PWR_PWR_VOSSR_DEF
    \
    \ @brief PWR voltage scaling status register
    \ Address offset: 0x14
    \ Reset value: 0x00002008
    \
    $03 constant PWR_VOSRDY                     \ [0x03] Ready bit for Vless thansub>COREless than/sub> voltage scaling output selection.
    $0d constant PWR_ACTVOSRDY                  \ [0x0d] Voltage level ready for currently used VOS
    $0e constant PWR_ACTVOS                     \ [0x0e : 2] voltage output scaling currently applied to Vless thansub>COREless than/sub>
  [then]


  [ifdef] PWR_PWR_BDCR_DEF
    \
    \ @brief PWR Backup domain control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BREN                       \ [0x00] Backup RAM retention in Standby and Vless thansub>BATless than/sub> modes
    $01 constant PWR_MONEN                      \ [0x01] Backup domain voltage and temperature monitoring enable
    $08 constant PWR_VBE                        \ [0x08] Vless thansub>BATless than/sub> charging enable
    $09 constant PWR_VBRS                       \ [0x09] Vless thansub>BATless than/sub> charging resistor selection
  [then]


  [ifdef] PWR_PWR_DBPCR_DEF
    \
    \ @brief PWR Backup domain control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_DBP                        \ [0x00] Disable Backup domain write protection
  [then]


  [ifdef] PWR_PWR_BDSR_DEF
    \
    \ @brief PWR Backup domain status register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $10 constant PWR_BRRDY                      \ [0x10] backup regulator ready
    $14 constant PWR_VBATL                      \ [0x14] Vless thansub>BATless than/sub> level monitoring versus low threshold
    $15 constant PWR_VBATH                      \ [0x15] Vless thansub>BATless than/sub> level monitoring versus high threshold
    $16 constant PWR_TEMPL                      \ [0x16] temperature level monitoring versus low threshold
    $17 constant PWR_TEMPH                      \ [0x17] temperature level monitoring versus high threshold
  [then]


  [ifdef] PWR_PWR_UCPDR_DEF
    \
    \ @brief PWR USB Type-C power delivery register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_UCPD_DBDIS                 \ [0x00] USB Type-C and power delivery dead battery disable
    $01 constant PWR_UCPD_STBY                  \ [0x01] USB Type-c and Power delivery Standby mode
  [then]


  [ifdef] PWR_PWR_SCCR_DEF
    \
    \ @brief PWR supply configuration control register
    \ Address offset: 0x30
    \ Reset value: 0x00000100
    \
    $00 constant PWR_BYPASS                     \ [0x00] power management unit bypass
    $08 constant PWR_LDOEN                      \ [0x08] LDO enable
    $09 constant PWR_SMPSEN                     \ [0x09] SMPS enable
  [then]


  [ifdef] PWR_PWR_VMCR_DEF
    \
    \ @brief PWR voltage monitor control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PVDE                       \ [0x00] PVD enable
    $01 constant PWR_PLS                        \ [0x01 : 3] programmable voltage detector (PVD) level selection
    $08 constant PWR_AVDEN                      \ [0x08] peripheral voltage monitor on Vless thansub>DDAless than/sub> enable
    $09 constant PWR_ALS                        \ [0x09 : 2] analog voltage detector (AVD) level selection
  [then]


  [ifdef] PWR_PWR_USBSCR_DEF
    \
    \ @brief PWR USB supply control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $18 constant PWR_USB33DEN                   \ [0x18] Vless thansub>DDUSBless than/sub> voltage level detector enable
    $19 constant PWR_USB33SV                    \ [0x19] independent USB supply valid
  [then]


  [ifdef] PWR_PWR_VMSR_DEF
    \
    \ @brief PWR voltage monitor status register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $13 constant PWR_AVDO                       \ [0x13] analog voltage detector output on Vless thansub>DDAless than/sub>
    $14 constant PWR_VDDIO2RDY                  \ [0x14] voltage detector output on Vless thansub>DDIO2less than/sub>
    $16 constant PWR_PVDO                       \ [0x16] programmable voltage detect output
    $18 constant PWR_USB33RDY                   \ [0x18] Vless thansub>DDUSBless than/sub> ready
  [then]


  [ifdef] PWR_PWR_WUSCR_DEF
    \
    \ @brief PWR wake-up status clear register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CWUF1                      \ [0x00] clear wake-up pin flag for WUFx (x = 8 to 1)
    $01 constant PWR_CWUF2                      \ [0x01] clear wake-up pin flag for WUFx (x = 8 to 1)
    $02 constant PWR_CWUF3                      \ [0x02] clear wake-up pin flag for WUFx (x = 8 to 1)
    $03 constant PWR_CWUF4                      \ [0x03] clear wake-up pin flag for WUFx (x = 8 to 1)
    $04 constant PWR_CWUF5                      \ [0x04] clear wake-up pin flag for WUFx (x = 8 to 1)
    $05 constant PWR_CWUF6                      \ [0x05] clear wake-up pin flag for WUFx (x = 8 to 1)
    $06 constant PWR_CWUF7                      \ [0x06] clear wake-up pin flag for WUFx (x = 8 to 1)
    $07 constant PWR_CWUF8                      \ [0x07] clear wake-up pin flag for WUFx (x = 8 to 1)
  [then]


  [ifdef] PWR_PWR_WUSR_DEF
    \
    \ @brief PWR wake-up status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUF1                       \ [0x00] wake-up pin WUFx flag
    $01 constant PWR_WUF2                       \ [0x01] wake-up pin WUFx flag
    $02 constant PWR_WUF3                       \ [0x02] wake-up pin WUFx flag
    $03 constant PWR_WUF4                       \ [0x03] wake-up pin WUFx flag
    $04 constant PWR_WUF5                       \ [0x04] wake-up pin WUFx flag
    $05 constant PWR_WUF6                       \ [0x05] wake-up pin WUFx flag
    $06 constant PWR_WUF7                       \ [0x06] wake-up pin WUFx flag
    $07 constant PWR_WUF8                       \ [0x07] wake-up pin WUFx flag
  [then]


  [ifdef] PWR_PWR_WUCR_DEF
    \
    \ @brief PWR wake-up configuration register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUPEN1                     \ [0x00] enable wake-up pin WUPx (x = 8 to 1)
    $01 constant PWR_WUPEN2                     \ [0x01] enable wake-up pin WUPx (x = 8 to 1)
    $02 constant PWR_WUPEN3                     \ [0x02] enable wake-up pin WUPx (x = 8 to 1)
    $03 constant PWR_WUPEN4                     \ [0x03] enable wake-up pin WUPx (x = 8 to 1)
    $04 constant PWR_WUPEN5                     \ [0x04] enable wake-up pin WUPx (x = 8 to 1)
    $05 constant PWR_WUPEN6                     \ [0x05] enable wake-up pin WUPx (x = 8 to 1)
    $06 constant PWR_WUPEN7                     \ [0x06] enable wake-up pin WUPx (x = 8 to 1)
    $07 constant PWR_WUPEN8                     \ [0x07] enable wake-up pin WUPx (x = 8 to 1)
    $08 constant PWR_WUPP1                      \ [0x08] wake-up pin polarity bit for WUPx (x = 8 to 1)
    $09 constant PWR_WUPP2                      \ [0x09] wake-up pin polarity bit for WUPx (x = 8 to 1)
    $0a constant PWR_WUPP3                      \ [0x0a] wake-up pin polarity bit for WUPx (x = 8 to 1)
    $0b constant PWR_WUPP4                      \ [0x0b] wake-up pin polarity bit for WUPx (x = 8 to 1)
    $0c constant PWR_WUPP5                      \ [0x0c] wake-up pin polarity bit for WUPx (x = 8 to 1)
    $0d constant PWR_WUPP6                      \ [0x0d] wake-up pin polarity bit for WUPx (x = 8 to 1)
    $0e constant PWR_WUPP7                      \ [0x0e] wake-up pin polarity bit for WUPx (x = 8 to 1)
    $0f constant PWR_WUPP8                      \ [0x0f] wake-up pin polarity bit for WUPx (x = 8 to 1)
    $10 constant PWR_WUPPUPD1                   \ [0x10 : 2] wake-up pin pull configuration for WKUPx (x = 8 to 1)
    $12 constant PWR_WUPPUPD2                   \ [0x12 : 2] wake-up pin pull configuration for WKUPx (x = 8 to 1)
    $14 constant PWR_WUPPUPD3                   \ [0x14 : 2] wake-up pin pull configuration for WKUPx (x = 8 to 1)
    $16 constant PWR_WUPPUPD4                   \ [0x16 : 2] wake-up pin pull configuration for WKUPx (x = 8 to 1)
    $18 constant PWR_WUPPUPD5                   \ [0x18 : 2] wake-up pin pull configuration for WKUPx (x = 8 to 1)
    $1a constant PWR_WUPPUPD6                   \ [0x1a : 2] wake-up pin pull configuration for WKUPx (x = 8 to 1)
    $1c constant PWR_WUPPUPD7                   \ [0x1c : 2] wake-up pin pull configuration for WKUPx (x = 8 to 1)
    $1e constant PWR_WUPPUPD8                   \ [0x1e : 2] wake-up pin pull configuration for WKUPx (x = 8 to 1)
  [then]


  [ifdef] PWR_PWR_IORETR_DEF
    \
    \ @brief PWR I/O retention register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant PWR_IORETEN                    \ [0x00] IO retention enable
    $10 constant PWR_JTAGIORETEN                \ [0x10] IO retention enable for JTAG IOs
  [then]


  [ifdef] PWR_PWR_SECCFGR_DEF
    \
    \ @brief PWR security configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUP1SEC                    \ [0x00] WUPx secure protection (x = 8 to 1)
    $01 constant PWR_WUP2SEC                    \ [0x01] WUPx secure protection (x = 8 to 1)
    $02 constant PWR_WUP3SEC                    \ [0x02] WUPx secure protection (x = 8 to 1)
    $03 constant PWR_WUP4SEC                    \ [0x03] WUPx secure protection (x = 8 to 1)
    $04 constant PWR_WUP5SEC                    \ [0x04] WUPx secure protection (x = 8 to 1)
    $05 constant PWR_WUP6SEC                    \ [0x05] WUPx secure protection (x = 8 to 1)
    $06 constant PWR_WUP7SEC                    \ [0x06] WUPx secure protection (x = 8 to 1)
    $07 constant PWR_WUP8SEC                    \ [0x07] WUPx secure protection (x = 8 to 1)
    $0b constant PWR_RETSEC                     \ [0x0b] retention secure protection
    $0c constant PWR_LPMSEC                     \ [0x0c] low-power modes secure protection
    $0d constant PWR_SCMSEC                     \ [0x0d] supply configuration and monitoring secure protection.
    $0e constant PWR_VBSEC                      \ [0x0e] Backup domain secure protection
    $0f constant PWR_VUSBSEC                    \ [0x0f] voltage USB secure protection
  [then]


  [ifdef] PWR_PWR_PRIVCFGR_DEF
    \
    \ @brief PWR privilege configuration register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant PWR_SPRIV                      \ [0x00] PWR secure functions privilege configuration
    $01 constant PWR_NSPRIV                     \ [0x01] PWR non-secure functions privilege configuration
  [then]

  \
  \ @brief PWR address block description
  \
  $00 constant PWR_PWR_PMCR             \ PWR power mode control register
  $00 constant PWR_PWR_PMCR_ALTERNATE1  \ PWR power mode control register
  $04 constant PWR_PWR_PMSR             \ PWR status register
  $10 constant PWR_PWR_VOSCR            \ PWR voltage scaling control register
  $14 constant PWR_PWR_VOSSR            \ PWR voltage scaling status register
  $20 constant PWR_PWR_BDCR             \ PWR Backup domain control register
  $24 constant PWR_PWR_DBPCR            \ PWR Backup domain control register
  $28 constant PWR_PWR_BDSR             \ PWR Backup domain status register
  $2C constant PWR_PWR_UCPDR            \ PWR USB Type-C power delivery register
  $30 constant PWR_PWR_SCCR             \ PWR supply configuration control register
  $34 constant PWR_PWR_VMCR             \ PWR voltage monitor control register
  $38 constant PWR_PWR_USBSCR           \ PWR USB supply control register
  $3C constant PWR_PWR_VMSR             \ PWR voltage monitor status register
  $40 constant PWR_PWR_WUSCR            \ PWR wake-up status clear register
  $44 constant PWR_PWR_WUSR             \ PWR wake-up status register
  $48 constant PWR_PWR_WUCR             \ PWR wake-up configuration register
  $50 constant PWR_PWR_IORETR           \ PWR I/O retention register
  $100 constant PWR_PWR_SECCFGR         \ PWR security configuration register
  $104 constant PWR_PWR_PRIVCFGR        \ PWR privilege configuration register

: PWR_DEF ; [then]
