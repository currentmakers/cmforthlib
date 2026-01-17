\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_CR1_DEF
    \
    \ @brief PWR control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000024
    \
    $02 constant PWR_SDEN                       \ [0x02] SMPS step-down converter enable
    $04 constant PWR_MODE_PDN                   \ [0x04] Enables the pull down on output voltage during power-down mode
    $05 constant PWR_LPDS08V                    \ [0x05] SMPS low-power mode enable (SVOS high only)
    $10 constant PWR_POPL                       \ [0x10 : 5] pwr_on pulse low configuration.
  [then]


  [ifdef] PWR_PWR_CR2_DEF
    \
    \ @brief PWR control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PVDEN                      \ [0x00] Programmable voltage detector enable
    $08 constant PWR_PVDO                       \ [0x08] Programmable voltage detect output
  [then]


  [ifdef] PWR_PWR_CR3_DEF
    \
    \ @brief PWR control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PWR_VCOREMONEN                 \ [0x00] V less than sub>DDCORE less than /sub> monitoring enable
    $04 constant PWR_VCORELLS                   \ [0x04] V less than sub>DDCORE less than /sub> voltage detector low-level selection
    $08 constant PWR_VCOREL                     \ [0x08] Monitored V less than sub>DDCORE less than /sub> level above low threshold
    $09 constant PWR_VCOREH                     \ [0x09] Monitored V less than sub>DDCORE less than /sub> level above high threshold
  [then]


  [ifdef] PWR_PWR_CR4_DEF
    \
    \ @brief PWR control register 4
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_TCMRBSEN                   \ [0x00] I-TCM and D-TCM RAMs backup supply enable (used to maintain TCM RAMs content in Standby mode)
    $04 constant PWR_TCMFLXRBSEN                \ [0x04] I-TCM FLEXMEM backup supply enable (used to maintain I-TCM FLEX MEM content in Standby mode)
  [then]


  [ifdef] PWR_PWR_VOSCR_DEF
    \
    \ @brief PWR voltage scaling control register
    \ Address offset: 0x20
    \ Reset value: 0x00020002
    \
    $00 constant PWR_VOS                        \ [0x00] Voltage scaling selection according to performance
    $01 constant PWR_VOSRDY                     \ [0x01] VOS ready bit for V less than sub>CORE less than /sub> voltage scaling output selection
    $10 constant PWR_ACTVOS                     \ [0x10] VOS currently applied for V less than sub>CORE less than /sub> voltage scaling selection
    $11 constant PWR_ACTVOSRDY                  \ [0x11] Voltage level ready bit for currently used ACTVOS
  [then]


  [ifdef] PWR_PWR_BDCR1_DEF
    \
    \ @brief PWR backup domain control register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_MONEN                      \ [0x00] V less than sub>BAT less than /sub> and temperature monitoring enable
    $10 constant PWR_VBATL                      \ [0x10] V less than sub>BAT less than /sub> level monitoring versus low threshold
    $11 constant PWR_VBATH                      \ [0x11] V less than sub>BAT less than /sub> level monitoring versus high threshold
    $12 constant PWR_TEMPL                      \ [0x12] Temperature level monitoring versus low threshold
    $13 constant PWR_TEMPH                      \ [0x13] Temperature level monitoring versus high threshold
  [then]


  [ifdef] PWR_PWR_BDCR2_DEF
    \
    \ @brief PWR backup domain control register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BKPRBSEN                   \ [0x00] Backup RAM backup supply enable (used to maintain BKPRAM content in Standby and V less than sub>BAT less than /sub> modes).
  [then]


  [ifdef] PWR_PWR_DBPCR_DEF
    \
    \ @brief PWR disable backup protection control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_DBP                        \ [0x00] Disable backup domain write protection
  [then]


  [ifdef] PWR_PWR_CPUCR_DEF
    \
    \ @brief PWR CPU control register
    \ Address offset: 0x30
    \ Reset value: 0x00010000
    \
    $00 constant PWR_PDDS                       \ [0x00] Power-down deepsleep selection
    $01 constant PWR_CSSF                       \ [0x01] Clear Standby and Stop flags (always read as 0)
    $08 constant PWR_STOPF                      \ [0x08] Stop flag
    $09 constant PWR_SBF                        \ [0x09] Standby flag
    $10 constant PWR_SVOS                       \ [0x10] System Stop mode voltage scaling selection
  [then]


  [ifdef] PWR_PWR_SVMCR1_DEF
    \
    \ @brief PWR supply voltage monitoring control register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWR_VDDIO4VMEN                 \ [0x00] V less than sub>DDIO4 less than /sub>independent I/O voltage monitor enable
    $08 constant PWR_VDDIO4SV                   \ [0x08] V less than sub>DDIO4 less than /sub>independent I/O supply valid.
    $10 constant PWR_VDDIO4RDY                  \ [0x10] V less than sub>DDIO4 less than /sub>ready
    $18 constant PWR_VDDIO4VRSEL                \ [0x18] V less than sub>DDIO4 less than /sub> I/O voltage range selection
    $19 constant PWR_VDDIO4VRSTBY               \ [0x19] V less than sub>DDIO4 less than /sub> I/O voltage range Standby mode
  [then]


  [ifdef] PWR_PWR_SVMCR2_DEF
    \
    \ @brief PWR supply voltage monitoring control register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant PWR_VDDIO5VMEN                 \ [0x00] V less than sub>DDIO5 less than /sub>independent voltage monitor enable
    $08 constant PWR_VDDIO5SV                   \ [0x08] V less than sub>DDIO5 less than /sub>independent supply valid
    $10 constant PWR_VDDIO5RDY                  \ [0x10] V less than sub>DDIO5 less than /sub>ready
    $18 constant PWR_VDDIO5VRSEL                \ [0x18] V less than sub>DDIO5 less than /sub> I/O voltage range selection
    $19 constant PWR_VDDIO5VRSTBY               \ [0x19] V less than sub>DDIO5 less than /sub> I/O voltage range Standby mode
  [then]


  [ifdef] PWR_PWR_SVMCR3_DEF
    \
    \ @brief PWR supply voltage monitoring control register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_VDDIO2VMEN                 \ [0x00] V less than sub>DDIO2 less than /sub>independent voltage monitor enable
    $01 constant PWR_VDDIO3VMEN                 \ [0x01] V less than sub>DDIO3 less than /sub>independent voltage monitor enable
    $02 constant PWR_USB33VMEN                  \ [0x02] V less than sub>DD33USB less than /sub>independent USB 33 voltage monitor enable.
    $04 constant PWR_AVMEN                      \ [0x04] V less than sub>DDA18ADC less than /sub>independent ADC voltage monitor enable
    $08 constant PWR_VDDIO2SV                   \ [0x08] V less than sub>DDIO2 less than /sub>independent supply valid.
    $09 constant PWR_VDDIO3SV                   \ [0x09] V less than sub>DDIO3 less than /sub>independent supply valid
    $0a constant PWR_USB33SV                    \ [0x0a] V less than sub>DD33USB less than /sub>independent supply valid
    $0c constant PWR_ASV                        \ [0x0c] V less than sub>DDA18ADC less than /sub>independent supply valid
    $10 constant PWR_VDDIO2RDY                  \ [0x10] V less than sub>DDIO2 less than /sub>ready
    $11 constant PWR_VDDIO3RDY                  \ [0x11] V less than sub>DDIO3 less than /sub>ready
    $12 constant PWR_USB33RDY                   \ [0x12] V less than sub>DD33USB less than /sub>ready
    $14 constant PWR_ARDY                       \ [0x14] V less than sub>DDA18ADC less than /sub>ready
    $18 constant PWR_VDDIOVRSEL                 \ [0x18] V less than sub>DD less than /sub> I/O voltage range selection
    $19 constant PWR_VDDIO2VRSEL                \ [0x19] V less than sub>DDIO2 less than /sub> I/O voltage range selection
    $1a constant PWR_VDDIO3VRSEL                \ [0x1a] V less than sub>DDIO3 less than /sub> I/O voltage range selection
  [then]


  [ifdef] PWR_PWR_WKUPCR_DEF
    \
    \ @brief PWR wake-up clear register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPC1                     \ [0x00] Clear wake-up flag for WKUP1 pin
    $01 constant PWR_WKUPC2                     \ [0x01] Clear wake-up flag for WKUP2 pin
    $02 constant PWR_WKUPC3                     \ [0x02] Clear wake-up flag for WKUP3 pin
    $03 constant PWR_WKUPC4                     \ [0x03] Clear wake-up flag for WKUP4 pin
  [then]


  [ifdef] PWR_PWR_WKUPSR_DEF
    \
    \ @brief PWR wake-up status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPF1                     \ [0x00] Wake-up flag for WKUP1 pin before enable
    $01 constant PWR_WKUPF2                     \ [0x01] Wake-up flag for WKUP2 pin before enable
    $02 constant PWR_WKUPF3                     \ [0x02] Wake-up flag for WKUP3 pin before enable
    $03 constant PWR_WKUPF4                     \ [0x03] Wake-up flag for WKUP4 pin before enable
  [then]


  [ifdef] PWR_PWR_WKUPEPR_DEF
    \
    \ @brief PWR wake-up enable and polarity register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPEN1                    \ [0x00] Enable WKUP1 pin
    $01 constant PWR_WKUPEN2                    \ [0x01] Enable WKUP2 pin
    $02 constant PWR_WKUPEN3                    \ [0x02] Enable WKUP3 pin
    $03 constant PWR_WKUPEN4                    \ [0x03] Enable WKUP4 pin
    $08 constant PWR_WKUPP1                     \ [0x08] Wake-up polarity bit for WKUP1 pin
    $09 constant PWR_WKUPP2                     \ [0x09] Wake-up polarity bit for WKUP2 pin
    $0a constant PWR_WKUPP3                     \ [0x0a] Wake-up polarity bit for WKUP3 pin
    $0b constant PWR_WKUPP4                     \ [0x0b] Wake-up polarity bit for WKUP4 pin
    $10 constant PWR_WKUPPUPD1                  \ [0x10 : 2] Wake-up pull configuration for WKUP1 pin
    $12 constant PWR_WKUPPUPD2                  \ [0x12 : 2] Wake-up pull configuration for WKUP2 pin
    $14 constant PWR_WKUPPUPD3                  \ [0x14 : 2] Wake-up pull configuration for WKUP3 pin
    $16 constant PWR_WKUPPUPD4                  \ [0x16 : 2] Wake-up pull configuration for WKUP4 pin
  [then]


  [ifdef] PWR_PWR_SECCFGR_DEF
    \
    \ @brief PWR security configuration register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant PWR_SEC0                       \ [0x00] System supply configuration secure protection
    $01 constant PWR_SEC1                       \ [0x01] Programmable voltage detector secure protection
    $02 constant PWR_SEC2                       \ [0x02] V less than sub>DDCORE less than /sub> monitor secure protection
    $03 constant PWR_SEC3                       \ [0x03] I-TCM, D-TCM, and I-TCM FLEXMEM low power control secure protection
    $04 constant PWR_SEC4                       \ [0x04] Voltage scaling selection secure protection
    $05 constant PWR_SEC5                       \ [0x05] Backup domain secure protection
    $06 constant PWR_SEC6                       \ [0x06] CPU power control secure protection
    $07 constant PWR_SEC7                       \ [0x07] Peripheral voltage monitor secure protection
    $10 constant PWR_WKUPSEC1                   \ [0x10] WKUP1 pin secure protection
    $11 constant PWR_WKUPSEC2                   \ [0x11] WKUP2 pin secure protection
    $12 constant PWR_WKUPSEC3                   \ [0x12] WKUP3 pin secure protection
    $13 constant PWR_WKUPSEC4                   \ [0x13] WKUP4 pin secure protection
  [then]


  [ifdef] PWR_PWR_PRIVCFGR_DEF
    \
    \ @brief PWR privilege configuration register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PRIV0                      \ [0x00] System supply configuration privileged protection
    $01 constant PWR_PRIV1                      \ [0x01] Programmable voltage detector privileged protection
    $02 constant PWR_PRIV2                      \ [0x02] V less than sub>DDCORE less than /sub> monitor privileged protection
    $03 constant PWR_PRIV3                      \ [0x03] I-TCM, D-TCM, and I-TCM FLEX MEM low power control privileged protection
    $04 constant PWR_PRIV4                      \ [0x04] Voltage scaling selection privileged protection
    $05 constant PWR_PRIV5                      \ [0x05] Backup domain privileged protection
    $06 constant PWR_PRIV6                      \ [0x06] CPU power control privileged protection
    $07 constant PWR_PRIV7                      \ [0x07] Peripheral voltage monitor privileged protection
    $10 constant PWR_WKUPPRIV1                  \ [0x10] WKUP1 pin privileged protection
    $11 constant PWR_WKUPPRIV2                  \ [0x11] WKUP2 pin privileged protection
    $12 constant PWR_WKUPPRIV3                  \ [0x12] WKUP3 pin privileged protection
    $13 constant PWR_WKUPPRIV4                  \ [0x13] WKUP4 pin privileged protection
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_PWR_CR1              \ PWR control register 1
  $04 constant PWR_PWR_CR2              \ PWR control register 2
  $08 constant PWR_PWR_CR3              \ PWR control register 3
  $0C constant PWR_PWR_CR4              \ PWR control register 4
  $20 constant PWR_PWR_VOSCR            \ PWR voltage scaling control register
  $24 constant PWR_PWR_BDCR1            \ PWR backup domain control register 1
  $28 constant PWR_PWR_BDCR2            \ PWR backup domain control register 2
  $2C constant PWR_PWR_DBPCR            \ PWR disable backup protection control register
  $30 constant PWR_PWR_CPUCR            \ PWR CPU control register
  $34 constant PWR_PWR_SVMCR1           \ PWR supply voltage monitoring control register 1
  $38 constant PWR_PWR_SVMCR2           \ PWR supply voltage monitoring control register 2
  $3C constant PWR_PWR_SVMCR3           \ PWR supply voltage monitoring control register 3
  $50 constant PWR_PWR_WKUPCR           \ PWR wake-up clear register
  $54 constant PWR_PWR_WKUPSR           \ PWR wake-up status register
  $58 constant PWR_PWR_WKUPEPR          \ PWR wake-up enable and polarity register
  $70 constant PWR_PWR_SECCFGR          \ PWR security configuration register
  $74 constant PWR_PWR_PRIVCFGR         \ PWR privilege configuration register

: PWR_DEF ; [then]
