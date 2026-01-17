\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_CR1_DEF
    \
    \ @brief Power control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000400
    \
    $00 constant PWR_LPMS                       \ [0x00 : 3] Low-power mode selection
    $08 constant PWR_DBP                        \ [0x08] Disable backup domain write protection
    $09 constant PWR_VOS                        \ [0x09 : 2] Voltage scaling range selection
    $0e constant PWR_LPR                        \ [0x0e] Low-power run
  [then]


  [ifdef] PWR_CR2_DEF
    \
    \ @brief Power control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PVDE                       \ [0x00] Power voltage detector enable
    $01 constant PWR_PLS                        \ [0x01 : 3] Power voltage detector level selection
    $04 constant PWR_PVME1                      \ [0x04] Peripheral voltage monitoring 1 enable: VDDUSB vs. 1.2V
    $05 constant PWR_PVME2                      \ [0x05] Peripheral voltage monitoring 2 enable: VDDIO2 vs. 0.9V
    $06 constant PWR_PVME3                      \ [0x06] Peripheral voltage monitoring 3 enable: VDDA vs. 1.62V
    $07 constant PWR_PVME4                      \ [0x07] Peripheral voltage monitoring 4 enable: VDDA vs. 2.2V
    $09 constant PWR_IOSV                       \ [0x09] VDDIO2 Independent I/Os supply valid
    $0a constant PWR_USV                        \ [0x0a] VDDUSB USB supply valid
  [then]


  [ifdef] PWR_CR3_DEF
    \
    \ @brief Power control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PWR_EWUP1                      \ [0x00] Enable Wakeup pin WKUP1
    $01 constant PWR_EWUP2                      \ [0x01] Enable Wakeup pin WKUP2
    $02 constant PWR_EWUP3                      \ [0x02] Enable Wakeup pin WKUP3
    $03 constant PWR_EWUP4                      \ [0x03] Enable Wakeup pin WKUP4
    $04 constant PWR_EWUP5                      \ [0x04] Enable Wakeup pin WKUP5
    $08 constant PWR_RRS                        \ [0x08 : 2] SRAM2 retention in Standby mode
    $0a constant PWR_APC                        \ [0x0a] Apply pull-up and pull-down configuration
    $0b constant PWR_ULPMEN                     \ [0x0b] ULPMEN
    $0d constant PWR_UCPD_STDBY                 \ [0x0d] UCPD_STDBY
    $0e constant PWR_UCPD_DBDIS                 \ [0x0e] UCPD_DBDIS
  [then]


  [ifdef] PWR_CR4_DEF
    \
    \ @brief Power control register 4
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUPP1                      \ [0x00] Wakeup pin WKUP1 polarity
    $01 constant PWR_WUPP2                      \ [0x01] Wakeup pin WKUP2 polarity
    $02 constant PWR_WUPP3                      \ [0x02] Wakeup pin WKUP3 polarity
    $03 constant PWR_WUPP4                      \ [0x03] Wakeup pin WKUP4 polarity
    $04 constant PWR_WUPP5                      \ [0x04] Wakeup pin WKUP5 polarity
    $08 constant PWR_VBE                        \ [0x08] VBAT battery charging enable
    $09 constant PWR_VBRS                       \ [0x09] VBAT battery charging resistor selection
    $0c constant PWR_SMPSBYP                    \ [0x0c] SMPSBYP
    $0d constant PWR_EXTSMPSEN                  \ [0x0d] EXTSMPSEN
    $0e constant PWR_SMPSFSTEN                  \ [0x0e] SMPSFSTEN
    $0f constant PWR_SMPSLPEN                   \ [0x0f] SMPSLPEN
  [then]


  [ifdef] PWR_SR1_DEF
    \
    \ @brief Power status register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUF1                       \ [0x00] Wakeup flag 1
    $01 constant PWR_WUF2                       \ [0x01] Wakeup flag 2
    $02 constant PWR_WUF3                       \ [0x02] Wakeup flag 3
    $03 constant PWR_WUF4                       \ [0x03] Wakeup flag 4
    $04 constant PWR_WUF5                       \ [0x04] Wakeup flag 5
    $08 constant PWR_SBF                        \ [0x08] Standby flag
    $0c constant PWR_SMPSBYPRDY                 \ [0x0c] SMPSBYPRDY
    $0d constant PWR_EXTSMPSRDY                 \ [0x0d] EXTSMPSRDY
    $0f constant PWR_SMPSHPRDY                  \ [0x0f] SMPSHPRDY
  [then]


  [ifdef] PWR_SR2_DEF
    \
    \ @brief Power status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $08 constant PWR_REGLPS                     \ [0x08] Low-power regulator started
    $09 constant PWR_REGLPF                     \ [0x09] Low-power regulator flag
    $0a constant PWR_VOSF                       \ [0x0a] Voltage scaling flag
    $0b constant PWR_PVDO                       \ [0x0b] Power voltage detector output
    $0c constant PWR_PVMO1                      \ [0x0c] Peripheral voltage monitoring output: VDDUSB vs. 1.2 V
    $0d constant PWR_PVMO2                      \ [0x0d] Peripheral voltage monitoring output: VDDIO2 vs. 0.9 V
    $0e constant PWR_PVMO3                      \ [0x0e] Peripheral voltage monitoring output: VDDA vs. 1.62 V
    $0f constant PWR_PVMO4                      \ [0x0f] Peripheral voltage monitoring output: VDDA vs. 2.2 V
  [then]


  [ifdef] PWR_SCR_DEF
    \
    \ @brief Power status clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CWUF1                      \ [0x00] Clear wakeup flag 1
    $01 constant PWR_CWUF2                      \ [0x01] Clear wakeup flag 2
    $02 constant PWR_CWUF3                      \ [0x02] Clear wakeup flag 3
    $03 constant PWR_CWUF4                      \ [0x03] Clear wakeup flag 4
    $04 constant PWR_CWUF5                      \ [0x04] Clear wakeup flag 5
    $08 constant PWR_CSBF                       \ [0x08] Clear standby flag
  [then]


  [ifdef] PWR_PUCRA_DEF
    \
    \ @brief Power Port A pull-up control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port A pull-up bit y (y=0..15)
    $01 constant PWR_PU1                        \ [0x01] Port A pull-up bit y (y=0..15)
    $02 constant PWR_PU2                        \ [0x02] Port A pull-up bit y (y=0..15)
    $03 constant PWR_PU3                        \ [0x03] Port A pull-up bit y (y=0..15)
    $04 constant PWR_PU4                        \ [0x04] Port A pull-up bit y (y=0..15)
    $05 constant PWR_PU5                        \ [0x05] Port A pull-up bit y (y=0..15)
    $06 constant PWR_PU6                        \ [0x06] Port A pull-up bit y (y=0..15)
    $07 constant PWR_PU7                        \ [0x07] Port A pull-up bit y (y=0..15)
    $08 constant PWR_PU8                        \ [0x08] Port A pull-up bit y (y=0..15)
    $09 constant PWR_PU9                        \ [0x09] Port A pull-up bit y (y=0..15)
    $0a constant PWR_PU10                       \ [0x0a] Port A pull-up bit y (y=0..15)
    $0b constant PWR_PU11                       \ [0x0b] Port A pull-up bit y (y=0..15)
    $0c constant PWR_PU12                       \ [0x0c] Port A pull-up bit y (y=0..15)
    $0d constant PWR_PU13                       \ [0x0d] Port A pull-up bit y (y=0..15)
    $0e constant PWR_PU14                       \ [0x0e] Port A pull-up bit y (y=0..15)
    $0f constant PWR_PU15                       \ [0x0f] Port A pull-up bit y (y=0..15)
  [then]


  [ifdef] PWR_PDCRA_DEF
    \
    \ @brief Power Port A pull-down control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port A pull-down bit y (y=0..15)
    $01 constant PWR_PD1                        \ [0x01] Port A pull-down bit y (y=0..15)
    $02 constant PWR_PD2                        \ [0x02] Port A pull-down bit y (y=0..15)
    $03 constant PWR_PD3                        \ [0x03] Port A pull-down bit y (y=0..15)
    $04 constant PWR_PD4                        \ [0x04] Port A pull-down bit y (y=0..15)
    $05 constant PWR_PD5                        \ [0x05] Port A pull-down bit y (y=0..15)
    $06 constant PWR_PD6                        \ [0x06] Port A pull-down bit y (y=0..15)
    $07 constant PWR_PD7                        \ [0x07] Port A pull-down bit y (y=0..15)
    $08 constant PWR_PD8                        \ [0x08] Port A pull-down bit y (y=0..15)
    $09 constant PWR_PD9                        \ [0x09] Port A pull-down bit y (y=0..15)
    $0a constant PWR_PD10                       \ [0x0a] Port A pull-down bit y (y=0..15)
    $0b constant PWR_PD11                       \ [0x0b] Port A pull-down bit y (y=0..15)
    $0c constant PWR_PD12                       \ [0x0c] Port A pull-down bit y (y=0..15)
    $0d constant PWR_PD13                       \ [0x0d] Port A pull-down bit y (y=0..15)
    $0e constant PWR_PD14                       \ [0x0e] Port A pull-down bit y (y=0..15)
    $0f constant PWR_PD15                       \ [0x0f] Port A pull-down bit y (y=0..15)
  [then]


  [ifdef] PWR_PUCRB_DEF
    \
    \ @brief Power Port B pull-up control register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port B pull-up bit y (y=0..15)
    $01 constant PWR_PU1                        \ [0x01] Port B pull-up bit y (y=0..15)
    $02 constant PWR_PU2                        \ [0x02] Port B pull-up bit y (y=0..15)
    $03 constant PWR_PU3                        \ [0x03] Port B pull-up bit y (y=0..15)
    $04 constant PWR_PU4                        \ [0x04] Port B pull-up bit y (y=0..15)
    $05 constant PWR_PU5                        \ [0x05] Port B pull-up bit y (y=0..15)
    $06 constant PWR_PU6                        \ [0x06] Port B pull-up bit y (y=0..15)
    $07 constant PWR_PU7                        \ [0x07] Port B pull-up bit y (y=0..15)
    $08 constant PWR_PU8                        \ [0x08] Port B pull-up bit y (y=0..15)
    $09 constant PWR_PU9                        \ [0x09] Port B pull-up bit y (y=0..15)
    $0a constant PWR_PU10                       \ [0x0a] Port B pull-up bit y (y=0..15)
    $0b constant PWR_PU11                       \ [0x0b] Port B pull-up bit y (y=0..15)
    $0c constant PWR_PU12                       \ [0x0c] Port B pull-up bit y (y=0..15)
    $0d constant PWR_PU13                       \ [0x0d] Port B pull-up bit y (y=0..15)
    $0e constant PWR_PU14                       \ [0x0e] Port B pull-up bit y (y=0..15)
    $0f constant PWR_PU15                       \ [0x0f] Port B pull-up bit y (y=0..15)
  [then]


  [ifdef] PWR_PDCRB_DEF
    \
    \ @brief Power Port B pull-down control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port B pull-down bit y (y=0..15)
    $01 constant PWR_PD1                        \ [0x01] Port B pull-down bit y (y=0..15)
    $02 constant PWR_PD2                        \ [0x02] Port B pull-down bit y (y=0..15)
    $03 constant PWR_PD3                        \ [0x03] Port B pull-down bit y (y=0..15)
    $04 constant PWR_PD4                        \ [0x04] Port B pull-down bit y (y=0..15)
    $05 constant PWR_PD5                        \ [0x05] Port B pull-down bit y (y=0..15)
    $06 constant PWR_PD6                        \ [0x06] Port B pull-down bit y (y=0..15)
    $07 constant PWR_PD7                        \ [0x07] Port B pull-down bit y (y=0..15)
    $08 constant PWR_PD8                        \ [0x08] Port B pull-down bit y (y=0..15)
    $09 constant PWR_PD9                        \ [0x09] Port B pull-down bit y (y=0..15)
    $0a constant PWR_PD10                       \ [0x0a] Port B pull-down bit y (y=0..15)
    $0b constant PWR_PD11                       \ [0x0b] Port B pull-down bit y (y=0..15)
    $0c constant PWR_PD12                       \ [0x0c] Port B pull-down bit y (y=0..15)
    $0d constant PWR_PD13                       \ [0x0d] Port B pull-down bit y (y=0..15)
    $0e constant PWR_PD14                       \ [0x0e] Port B pull-down bit y (y=0..15)
    $0f constant PWR_PD15                       \ [0x0f] Port B pull-down bit y (y=0..15)
  [then]


  [ifdef] PWR_PUCRC_DEF
    \
    \ @brief Power Port C pull-up control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port C pull-up bit y (y=0..15)
    $01 constant PWR_PU1                        \ [0x01] Port C pull-up bit y (y=0..15)
    $02 constant PWR_PU2                        \ [0x02] Port C pull-up bit y (y=0..15)
    $03 constant PWR_PU3                        \ [0x03] Port C pull-up bit y (y=0..15)
    $04 constant PWR_PU4                        \ [0x04] Port C pull-up bit y (y=0..15)
    $05 constant PWR_PU5                        \ [0x05] Port C pull-up bit y (y=0..15)
    $06 constant PWR_PU6                        \ [0x06] Port C pull-up bit y (y=0..15)
    $07 constant PWR_PU7                        \ [0x07] Port C pull-up bit y (y=0..15)
    $08 constant PWR_PU8                        \ [0x08] Port C pull-up bit y (y=0..15)
    $09 constant PWR_PU9                        \ [0x09] Port C pull-up bit y (y=0..15)
    $0a constant PWR_PU10                       \ [0x0a] Port C pull-up bit y (y=0..15)
    $0b constant PWR_PU11                       \ [0x0b] Port C pull-up bit y (y=0..15)
    $0c constant PWR_PU12                       \ [0x0c] Port C pull-up bit y (y=0..15)
    $0d constant PWR_PU13                       \ [0x0d] Port C pull-up bit y (y=0..15)
    $0e constant PWR_PU14                       \ [0x0e] Port C pull-up bit y (y=0..15)
    $0f constant PWR_PU15                       \ [0x0f] Port C pull-up bit y (y=0..15)
  [then]


  [ifdef] PWR_PDCRC_DEF
    \
    \ @brief Power Port C pull-down control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port C pull-down bit y (y=0..15)
    $01 constant PWR_PD1                        \ [0x01] Port C pull-down bit y (y=0..15)
    $02 constant PWR_PD2                        \ [0x02] Port C pull-down bit y (y=0..15)
    $03 constant PWR_PD3                        \ [0x03] Port C pull-down bit y (y=0..15)
    $04 constant PWR_PD4                        \ [0x04] Port C pull-down bit y (y=0..15)
    $05 constant PWR_PD5                        \ [0x05] Port C pull-down bit y (y=0..15)
    $06 constant PWR_PD6                        \ [0x06] Port C pull-down bit y (y=0..15)
    $07 constant PWR_PD7                        \ [0x07] Port C pull-down bit y (y=0..15)
    $08 constant PWR_PD8                        \ [0x08] Port C pull-down bit y (y=0..15)
    $09 constant PWR_PD9                        \ [0x09] Port C pull-down bit y (y=0..15)
    $0a constant PWR_PD10                       \ [0x0a] Port C pull-down bit y (y=0..15)
    $0b constant PWR_PD11                       \ [0x0b] Port C pull-down bit y (y=0..15)
    $0c constant PWR_PD12                       \ [0x0c] Port C pull-down bit y (y=0..15)
    $0d constant PWR_PD13                       \ [0x0d] Port C pull-down bit y (y=0..15)
    $0e constant PWR_PD14                       \ [0x0e] Port C pull-down bit y (y=0..15)
    $0f constant PWR_PD15                       \ [0x0f] Port C pull-down bit y (y=0..15)
  [then]


  [ifdef] PWR_PUCRD_DEF
    \
    \ @brief Power Port D pull-up control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port D pull-up bit y (y=0..15)
    $01 constant PWR_PU1                        \ [0x01] Port D pull-up bit y (y=0..15)
    $02 constant PWR_PU2                        \ [0x02] Port D pull-up bit y (y=0..15)
    $03 constant PWR_PU3                        \ [0x03] Port D pull-up bit y (y=0..15)
    $04 constant PWR_PU4                        \ [0x04] Port D pull-up bit y (y=0..15)
    $05 constant PWR_PU5                        \ [0x05] Port D pull-up bit y (y=0..15)
    $06 constant PWR_PU6                        \ [0x06] Port D pull-up bit y (y=0..15)
    $07 constant PWR_PU7                        \ [0x07] Port D pull-up bit y (y=0..15)
    $08 constant PWR_PU8                        \ [0x08] Port D pull-up bit y (y=0..15)
    $09 constant PWR_PU9                        \ [0x09] Port D pull-up bit y (y=0..15)
    $0a constant PWR_PU10                       \ [0x0a] Port D pull-up bit y (y=0..15)
    $0b constant PWR_PU11                       \ [0x0b] Port D pull-up bit y (y=0..15)
    $0c constant PWR_PU12                       \ [0x0c] Port D pull-up bit y (y=0..15)
    $0d constant PWR_PU13                       \ [0x0d] Port D pull-up bit y (y=0..15)
    $0e constant PWR_PU14                       \ [0x0e] Port D pull-up bit y (y=0..15)
    $0f constant PWR_PU15                       \ [0x0f] Port D pull-up bit y (y=0..15)
  [then]


  [ifdef] PWR_PDCRD_DEF
    \
    \ @brief Power Port D pull-down control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port D pull-down bit y (y=0..15)
    $01 constant PWR_PD1                        \ [0x01] Port D pull-down bit y (y=0..15)
    $02 constant PWR_PD2                        \ [0x02] Port D pull-down bit y (y=0..15)
    $03 constant PWR_PD3                        \ [0x03] Port D pull-down bit y (y=0..15)
    $04 constant PWR_PD4                        \ [0x04] Port D pull-down bit y (y=0..15)
    $05 constant PWR_PD5                        \ [0x05] Port D pull-down bit y (y=0..15)
    $06 constant PWR_PD6                        \ [0x06] Port D pull-down bit y (y=0..15)
    $07 constant PWR_PD7                        \ [0x07] Port D pull-down bit y (y=0..15)
    $08 constant PWR_PD8                        \ [0x08] Port D pull-down bit y (y=0..15)
    $09 constant PWR_PD9                        \ [0x09] Port D pull-down bit y (y=0..15)
    $0a constant PWR_PD10                       \ [0x0a] Port D pull-down bit y (y=0..15)
    $0b constant PWR_PD11                       \ [0x0b] Port D pull-down bit y (y=0..15)
    $0c constant PWR_PD12                       \ [0x0c] Port D pull-down bit y (y=0..15)
    $0d constant PWR_PD13                       \ [0x0d] Port D pull-down bit y (y=0..15)
    $0e constant PWR_PD14                       \ [0x0e] Port D pull-down bit y (y=0..15)
    $0f constant PWR_PD15                       \ [0x0f] Port D pull-down bit y (y=0..15)
  [then]


  [ifdef] PWR_PUCRE_DEF
    \
    \ @brief Power Port E pull-up control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port E pull-up bit y (y=0..15)
    $01 constant PWR_PU1                        \ [0x01] Port E pull-up bit y (y=0..15)
    $02 constant PWR_PU2                        \ [0x02] Port E pull-up bit y (y=0..15)
    $03 constant PWR_PU3                        \ [0x03] Port E pull-up bit y (y=0..15)
    $04 constant PWR_PU4                        \ [0x04] Port E pull-up bit y (y=0..15)
    $05 constant PWR_PU5                        \ [0x05] Port E pull-up bit y (y=0..15)
    $06 constant PWR_PU6                        \ [0x06] Port E pull-up bit y (y=0..15)
    $07 constant PWR_PU7                        \ [0x07] Port E pull-up bit y (y=0..15)
    $08 constant PWR_PU8                        \ [0x08] Port E pull-up bit y (y=0..15)
    $09 constant PWR_PU9                        \ [0x09] Port E pull-up bit y (y=0..15)
    $0a constant PWR_PU10                       \ [0x0a] Port E pull-up bit y (y=0..15)
    $0b constant PWR_PU11                       \ [0x0b] Port E pull-up bit y (y=0..15)
    $0c constant PWR_PU12                       \ [0x0c] Port E pull-up bit y (y=0..15)
    $0d constant PWR_PU13                       \ [0x0d] Port E pull-up bit y (y=0..15)
    $0e constant PWR_PU14                       \ [0x0e] Port E pull-up bit y (y=0..15)
    $0f constant PWR_PU15                       \ [0x0f] Port E pull-up bit y (y=0..15)
  [then]


  [ifdef] PWR_PDCRE_DEF
    \
    \ @brief Power Port E pull-down control register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port E pull-down bit y (y=0..15)
    $01 constant PWR_PD1                        \ [0x01] Port E pull-down bit y (y=0..15)
    $02 constant PWR_PD2                        \ [0x02] Port E pull-down bit y (y=0..15)
    $03 constant PWR_PD3                        \ [0x03] Port E pull-down bit y (y=0..15)
    $04 constant PWR_PD4                        \ [0x04] Port E pull-down bit y (y=0..15)
    $05 constant PWR_PD5                        \ [0x05] Port E pull-down bit y (y=0..15)
    $06 constant PWR_PD6                        \ [0x06] Port E pull-down bit y (y=0..15)
    $07 constant PWR_PD7                        \ [0x07] Port E pull-down bit y (y=0..15)
    $08 constant PWR_PD8                        \ [0x08] Port E pull-down bit y (y=0..15)
    $09 constant PWR_PD9                        \ [0x09] Port E pull-down bit y (y=0..15)
    $0a constant PWR_PD10                       \ [0x0a] Port E pull-down bit y (y=0..15)
    $0b constant PWR_PD11                       \ [0x0b] Port E pull-down bit y (y=0..15)
    $0c constant PWR_PD12                       \ [0x0c] Port E pull-down bit y (y=0..15)
    $0d constant PWR_PD13                       \ [0x0d] Port E pull-down bit y (y=0..15)
    $0e constant PWR_PD14                       \ [0x0e] Port E pull-down bit y (y=0..15)
    $0f constant PWR_PD15                       \ [0x0f] Port E pull-down bit y (y=0..15)
  [then]


  [ifdef] PWR_PUCRF_DEF
    \
    \ @brief Power Port F pull-up control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port F pull-up bit y (y=0..15)
    $01 constant PWR_PU1                        \ [0x01] Port F pull-up bit y (y=0..15)
    $02 constant PWR_PU2                        \ [0x02] Port F pull-up bit y (y=0..15)
    $03 constant PWR_PU3                        \ [0x03] Port F pull-up bit y (y=0..15)
    $04 constant PWR_PU4                        \ [0x04] Port F pull-up bit y (y=0..15)
    $05 constant PWR_PU5                        \ [0x05] Port F pull-up bit y (y=0..15)
    $06 constant PWR_PU6                        \ [0x06] Port F pull-up bit y (y=0..15)
    $07 constant PWR_PU7                        \ [0x07] Port F pull-up bit y (y=0..15)
    $08 constant PWR_PU8                        \ [0x08] Port F pull-up bit y (y=0..15)
    $09 constant PWR_PU9                        \ [0x09] Port F pull-up bit y (y=0..15)
    $0a constant PWR_PU10                       \ [0x0a] Port F pull-up bit y (y=0..15)
    $0b constant PWR_PU11                       \ [0x0b] Port F pull-up bit y (y=0..15)
    $0c constant PWR_PU12                       \ [0x0c] Port F pull-up bit y (y=0..15)
    $0d constant PWR_PU13                       \ [0x0d] Port F pull-up bit y (y=0..15)
    $0e constant PWR_PU14                       \ [0x0e] Port F pull-up bit y (y=0..15)
    $0f constant PWR_PU15                       \ [0x0f] Port F pull-up bit y (y=0..15)
  [then]


  [ifdef] PWR_PDCRF_DEF
    \
    \ @brief Power Port F pull-down control register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port F pull-down bit y (y=0..15)
    $01 constant PWR_PD1                        \ [0x01] Port F pull-down bit y (y=0..15)
    $02 constant PWR_PD2                        \ [0x02] Port F pull-down bit y (y=0..15)
    $03 constant PWR_PD3                        \ [0x03] Port F pull-down bit y (y=0..15)
    $04 constant PWR_PD4                        \ [0x04] Port F pull-down bit y (y=0..15)
    $05 constant PWR_PD5                        \ [0x05] Port F pull-down bit y (y=0..15)
    $06 constant PWR_PD6                        \ [0x06] Port F pull-down bit y (y=0..15)
    $07 constant PWR_PD7                        \ [0x07] Port F pull-down bit y (y=0..15)
    $08 constant PWR_PD8                        \ [0x08] Port F pull-down bit y (y=0..15)
    $09 constant PWR_PD9                        \ [0x09] Port F pull-down bit y (y=0..15)
    $0a constant PWR_PD10                       \ [0x0a] Port F pull-down bit y (y=0..15)
    $0b constant PWR_PD11                       \ [0x0b] Port F pull-down bit y (y=0..15)
    $0c constant PWR_PD12                       \ [0x0c] Port F pull-down bit y (y=0..15)
    $0d constant PWR_PD13                       \ [0x0d] Port F pull-down bit y (y=0..15)
    $0e constant PWR_PD14                       \ [0x0e] Port F pull-down bit y (y=0..15)
    $0f constant PWR_PD15                       \ [0x0f] Port F pull-down bit y (y=0..15)
  [then]


  [ifdef] PWR_PUCRG_DEF
    \
    \ @brief Power Port G pull-up control register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port G pull-up bit y (y=0..15)
    $01 constant PWR_PU1                        \ [0x01] Port G pull-up bit y (y=0..15)
    $02 constant PWR_PU2                        \ [0x02] Port G pull-up bit y (y=0..15)
    $03 constant PWR_PU3                        \ [0x03] Port G pull-up bit y (y=0..15)
    $04 constant PWR_PU4                        \ [0x04] Port G pull-up bit y (y=0..15)
    $05 constant PWR_PU5                        \ [0x05] Port G pull-up bit y (y=0..15)
    $06 constant PWR_PU6                        \ [0x06] Port G pull-up bit y (y=0..15)
    $07 constant PWR_PU7                        \ [0x07] Port G pull-up bit y (y=0..15)
    $08 constant PWR_PU8                        \ [0x08] Port G pull-up bit y (y=0..15)
    $09 constant PWR_PU9                        \ [0x09] Port G pull-up bit y (y=0..15)
    $0a constant PWR_PU10                       \ [0x0a] Port G pull-up bit y (y=0..15)
    $0b constant PWR_PU11                       \ [0x0b] Port G pull-up bit y (y=0..15)
    $0c constant PWR_PU12                       \ [0x0c] Port G pull-up bit y (y=0..15)
    $0d constant PWR_PU13                       \ [0x0d] Port G pull-up bit y (y=0..15)
    $0e constant PWR_PU14                       \ [0x0e] Port G pull-up bit y (y=0..15)
    $0f constant PWR_PU15                       \ [0x0f] Port G pull-up bit y (y=0..15)
  [then]


  [ifdef] PWR_PDCRG_DEF
    \
    \ @brief Power Port G pull-down control register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port G pull-down bit y (y=0..15)
    $01 constant PWR_PD1                        \ [0x01] Port G pull-down bit y (y=0..15)
    $02 constant PWR_PD2                        \ [0x02] Port G pull-down bit y (y=0..15)
    $03 constant PWR_PD3                        \ [0x03] Port G pull-down bit y (y=0..15)
    $04 constant PWR_PD4                        \ [0x04] Port G pull-down bit y (y=0..15)
    $05 constant PWR_PD5                        \ [0x05] Port G pull-down bit y (y=0..15)
    $06 constant PWR_PD6                        \ [0x06] Port G pull-down bit y (y=0..15)
    $07 constant PWR_PD7                        \ [0x07] Port G pull-down bit y (y=0..15)
    $08 constant PWR_PD8                        \ [0x08] Port G pull-down bit y (y=0..15)
    $09 constant PWR_PD9                        \ [0x09] Port G pull-down bit y (y=0..15)
    $0a constant PWR_PD10                       \ [0x0a] Port G pull-down bit y (y=0..15)
    $0b constant PWR_PD11                       \ [0x0b] Port G pull-down bit y (y=0..15)
    $0c constant PWR_PD12                       \ [0x0c] Port G pull-down bit y (y=0..15)
    $0d constant PWR_PD13                       \ [0x0d] Port G pull-down bit y (y=0..15)
    $0e constant PWR_PD14                       \ [0x0e] Port G pull-down bit y (y=0..15)
    $0f constant PWR_PD15                       \ [0x0f] Port G pull-down bit y (y=0..15)
  [then]


  [ifdef] PWR_PUCRH_DEF
    \
    \ @brief Power Port H pull-up control register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port G pull-up bit y (y=0..15)
    $01 constant PWR_PU1                        \ [0x01] Port G pull-up bit y (y=0..15)
    $02 constant PWR_PU2                        \ [0x02] Port G pull-up bit y (y=0..15)
    $03 constant PWR_PU3                        \ [0x03] Port G pull-up bit y (y=0..15)
    $04 constant PWR_PU4                        \ [0x04] Port G pull-up bit y (y=0..15)
    $05 constant PWR_PU5                        \ [0x05] Port G pull-up bit y (y=0..15)
    $06 constant PWR_PU6                        \ [0x06] Port G pull-up bit y (y=0..15)
    $07 constant PWR_PU7                        \ [0x07] Port G pull-up bit y (y=0..15)
    $08 constant PWR_PU8                        \ [0x08] Port G pull-up bit y (y=0..15)
    $09 constant PWR_PU9                        \ [0x09] Port G pull-up bit y (y=0..15)
    $0a constant PWR_PU10                       \ [0x0a] Port G pull-up bit y (y=0..15)
    $0b constant PWR_PU11                       \ [0x0b] Port G pull-up bit y (y=0..15)
    $0c constant PWR_PU12                       \ [0x0c] Port G pull-up bit y (y=0..15)
    $0d constant PWR_PU13                       \ [0x0d] Port G pull-up bit y (y=0..15)
    $0e constant PWR_PU14                       \ [0x0e] Port G pull-up bit y (y=0..15)
    $0f constant PWR_PU15                       \ [0x0f] Port G pull-up bit y (y=0..15)
  [then]


  [ifdef] PWR_PDCRH_DEF
    \
    \ @brief Power Port H pull-down control register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port G pull-down bit y (y=0..15)
    $01 constant PWR_PD1                        \ [0x01] Port G pull-down bit y (y=0..15)
    $02 constant PWR_PD2                        \ [0x02] Port G pull-down bit y (y=0..15)
    $03 constant PWR_PD3                        \ [0x03] Port G pull-down bit y (y=0..15)
    $04 constant PWR_PD4                        \ [0x04] Port G pull-down bit y (y=0..15)
    $05 constant PWR_PD5                        \ [0x05] Port G pull-down bit y (y=0..15)
    $06 constant PWR_PD6                        \ [0x06] Port G pull-down bit y (y=0..15)
    $07 constant PWR_PD7                        \ [0x07] Port G pull-down bit y (y=0..15)
    $08 constant PWR_PD8                        \ [0x08] Port G pull-down bit y (y=0..15)
    $09 constant PWR_PD9                        \ [0x09] Port G pull-down bit y (y=0..15)
    $0a constant PWR_PD10                       \ [0x0a] Port G pull-down bit y (y=0..15)
    $0b constant PWR_PD11                       \ [0x0b] Port G pull-down bit y (y=0..15)
    $0c constant PWR_PD12                       \ [0x0c] Port G pull-down bit y (y=0..15)
    $0d constant PWR_PD13                       \ [0x0d] Port G pull-down bit y (y=0..15)
    $0e constant PWR_PD14                       \ [0x0e] Port G pull-down bit y (y=0..15)
    $0f constant PWR_PD15                       \ [0x0f] Port G pull-down bit y (y=0..15)
  [then]


  [ifdef] PWR_SECCFGR_DEF
    \
    \ @brief Power secure configuration register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUP1SEC                    \ [0x00] WKUP1 pin security
    $01 constant PWR_WUP2SEC                    \ [0x01] WKUP2 pin security
    $02 constant PWR_WUP3SEC                    \ [0x02] WKUP3 pin security
    $03 constant PWR_WUP4SEC                    \ [0x03] WKUP4 pin security
    $04 constant PWR_WUP5SEC                    \ [0x04] WKUP5 pin security
    $08 constant PWR_LPMSEC                     \ [0x08] LPMSEC
    $09 constant PWR_VDMSEC                     \ [0x09] VDMSEC
    $0a constant PWR_VBSEC                      \ [0x0a] VBSEC
    $0b constant PWR_APCSEC                     \ [0x0b] APCSEC
  [then]


  [ifdef] PWR_PRIVCFGR_DEF
    \
    \ @brief Power privilege configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PRIV                       \ [0x00] PRIV
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_CR1                  \ Power control register 1
  $04 constant PWR_CR2                  \ Power control register 2
  $08 constant PWR_CR3                  \ Power control register 3
  $0C constant PWR_CR4                  \ Power control register 4
  $10 constant PWR_SR1                  \ Power status register 1
  $14 constant PWR_SR2                  \ Power status register 2
  $18 constant PWR_SCR                  \ Power status clear register
  $20 constant PWR_PUCRA                \ Power Port A pull-up control register
  $24 constant PWR_PDCRA                \ Power Port A pull-down control register
  $28 constant PWR_PUCRB                \ Power Port B pull-up control register
  $2C constant PWR_PDCRB                \ Power Port B pull-down control register
  $30 constant PWR_PUCRC                \ Power Port C pull-up control register
  $34 constant PWR_PDCRC                \ Power Port C pull-down control register
  $38 constant PWR_PUCRD                \ Power Port D pull-up control register
  $3C constant PWR_PDCRD                \ Power Port D pull-down control register
  $40 constant PWR_PUCRE                \ Power Port E pull-up control register
  $44 constant PWR_PDCRE                \ Power Port E pull-down control register
  $48 constant PWR_PUCRF                \ Power Port F pull-up control register
  $4C constant PWR_PDCRF                \ Power Port F pull-down control register
  $50 constant PWR_PUCRG                \ Power Port G pull-up control register
  $54 constant PWR_PDCRG                \ Power Port G pull-down control register
  $58 constant PWR_PUCRH                \ Power Port H pull-up control register
  $5C constant PWR_PDCRH                \ Power Port H pull-down control register
  $78 constant PWR_SECCFGR              \ Power secure configuration register
  $80 constant PWR_PRIVCFGR             \ Power privilege configuration register

: PWR_DEF ; [then]
