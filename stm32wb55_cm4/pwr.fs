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
    \ Reset value: 0x00000200
    \
    $00 constant PWR_LPMS                       \ [0x00 : 3] Low-power mode selection for CPU1
    $04 constant PWR_FPDR                       \ [0x04] Flash power down mode during LPRun for CPU1
    $05 constant PWR_FPDS                       \ [0x05] Flash power down mode during LPsSleep for CPU1
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
    $06 constant PWR_PVME3                      \ [0x06] Peripheral voltage monitoring 3 enable: VDDA vs. 1.62V
    $0a constant PWR_USV                        \ [0x0a] VDDUSB USB supply valid
  [then]


  [ifdef] PWR_CR3_DEF
    \
    \ @brief Power control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00008000
    \
    $00 constant PWR_EWUP1                      \ [0x00] Enable Wakeup pin WKUP1
    $01 constant PWR_EWUP2                      \ [0x01] Enable Wakeup pin WKUP2
    $02 constant PWR_EWUP3                      \ [0x02] Enable Wakeup pin WKUP3
    $03 constant PWR_EWUP4                      \ [0x03] Enable Wakeup pin WKUP4
    $04 constant PWR_EWUP5                      \ [0x04] Enable Wakeup pin WKUP5
    $08 constant PWR_EBORHSDFB                  \ [0x08] Enable BORH and Step Down counverter forced in Bypass interrups for CPU1
    $09 constant PWR_RRS                        \ [0x09] SRAM2a retention in Standby mode
    $0a constant PWR_APC                        \ [0x0a] Apply pull-up and pull-down configuration
    $0b constant PWR_EBLEA                      \ [0x0b] Enable BLE end of activity interrupt for CPU1
    $0c constant PWR_ECRPE                      \ [0x0c] Enable critical radio phase end of activity interrupt for CPU1
    $0d constant PWR_E802A                      \ [0x0d] Enable end of activity interrupt for CPU1
    $0e constant PWR_EC2H                       \ [0x0e] Enable CPU2 Hold interrupt for CPU1
    $0f constant PWR_EIWUL                      \ [0x0f] Enable internal wakeup line for CPU1
  [then]


  [ifdef] PWR_CR4_DEF
    \
    \ @brief Power control register 4
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WP1                        \ [0x00] Wakeup pin WKUP1 polarity
    $01 constant PWR_WP2                        \ [0x01] Wakeup pin WKUP2 polarity
    $02 constant PWR_WP3                        \ [0x02] Wakeup pin WKUP3 polarity
    $03 constant PWR_WP4                        \ [0x03] Wakeup pin WKUP4 polarity
    $04 constant PWR_WP5                        \ [0x04] Wakeup pin WKUP5 polarity
    $08 constant PWR_VBE                        \ [0x08] VBAT battery charging enable
    $09 constant PWR_VBRS                       \ [0x09] VBAT battery charging resistor selection
    $0f constant PWR_C2BOOT                     \ [0x0f] BOOT CPU2 after reset or wakeup from Stop or Standby modes
  [then]


  [ifdef] PWR_SR1_DEF
    \
    \ @brief Power status register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CWUF1                      \ [0x00] Wakeup flag 1
    $01 constant PWR_CWUF2                      \ [0x01] Wakeup flag 2
    $02 constant PWR_CWUF3                      \ [0x02] Wakeup flag 3
    $03 constant PWR_CWUF4                      \ [0x03] Wakeup flag 4
    $04 constant PWR_CWUF5                      \ [0x04] Wakeup flag 5
    $07 constant PWR_SDFBF                      \ [0x07] Step Down converter forced in Bypass interrupt flag
    $08 constant PWR_BORHF                      \ [0x08] BORH interrupt flag
    $09 constant PWR_BLEWUF                     \ [0x09] BLE wakeup interrupt flag
    $0a constant PWR_WUF802                     \ [0x0a] 802.15.4 wakeup interrupt flag
    $0b constant PWR_CRPEF                      \ [0x0b] Enable critical radio phase end of activity interrupt flag
    $0c constant PWR_BLEAF                      \ [0x0c] BLE end of activity interrupt flag
    $0d constant PWR_AF802                      \ [0x0d] 802.15.4 end of activity interrupt flag
    $0e constant PWR_C2HF                       \ [0x0e] CPU2 Hold interrupt flag
    $0f constant PWR_WUFI                       \ [0x0f] Internal Wakeup interrupt flag
  [then]


  [ifdef] PWR_SR2_DEF
    \
    \ @brief Power status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000002
    \
    $00 constant PWR_SDBF                       \ [0x00] Step Down converter Bypass mode flag
    $01 constant PWR_SDSMPSF                    \ [0x01] Step Down converter SMPS mode flag
    $08 constant PWR_REGLPS                     \ [0x08] Low-power regulator started
    $09 constant PWR_REGLPF                     \ [0x09] Low-power regulator flag
    $0a constant PWR_VOSF                       \ [0x0a] Voltage scaling flag
    $0b constant PWR_PVDO                       \ [0x0b] Power voltage detector output
    $0c constant PWR_PVMO1                      \ [0x0c] Peripheral voltage monitoring output: VDDUSB vs. 1.2 V
    $0e constant PWR_PVMO3                      \ [0x0e] Peripheral voltage monitoring output: VDDA vs. 1.62 V
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
    $07 constant PWR_CSMPSFBF                   \ [0x07] Clear SMPS Step Down converter forced in Bypass interrupt flag
    $08 constant PWR_CBORHF                     \ [0x08] Clear BORH interrupt flag
    $09 constant PWR_CBLEWUF                    \ [0x09] Clear BLE wakeup interrupt flag
    $0a constant PWR_C802WUF                    \ [0x0a] Clear 802.15.4 wakeup interrupt flag
    $0b constant PWR_CCRPEF                     \ [0x0b] Clear critical radio phase end of activity interrupt flag
    $0c constant PWR_CBLEAF                     \ [0x0c] Clear BLE end of activity interrupt flag
    $0d constant PWR_C802AF                     \ [0x0d] Clear 802.15.4 end of activity interrupt flag
    $0e constant PWR_CC2HF                      \ [0x0e] Clear CPU2 Hold interrupt flag
  [then]


  [ifdef] PWR_CR5_DEF
    \
    \ @brief Power control register 5
    \ Address offset: 0x1C
    \ Reset value: 0x00004270
    \
    $00 constant PWR_SMPSVOS                    \ [0x00 : 4] SMPS step-down converter voltage output scaling
    $04 constant PWR_SMPSSC                     \ [0x04 : 3] SMPS step-down converter supply startup current selection
    $08 constant PWR_BORHC                      \ [0x08] BORH configuration selection
    $0f constant PWR_SMPSEN                     \ [0x0f] Enable SMPS step-down converter SMPS mode enabled
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
    $0e constant PWR_PD14                       \ [0x0e] Port A pull-down bit y (y=0..15)
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
  [then]


  [ifdef] PWR_PUCRH_DEF
    \
    \ @brief Power Port H pull-up control register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port H pull-up bit y (y=0..1)
    $01 constant PWR_PU1                        \ [0x01] Port H pull-up bit y (y=0..1)
    $03 constant PWR_PU3                        \ [0x03] Port H pull-up bit y (y=0..1)
  [then]


  [ifdef] PWR_PDCRH_DEF
    \
    \ @brief Power Port H pull-down control register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port H pull-down bit y (y=0..1)
    $01 constant PWR_PD1                        \ [0x01] Port H pull-down bit y (y=0..1)
    $03 constant PWR_PD3                        \ [0x03] Port H pull-down bit y (y=0..1)
  [then]


  [ifdef] PWR_C2CR1_DEF
    \
    \ @brief CPU2 Power control register 1
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant PWR_LPMS                       \ [0x00 : 3] Low-power mode selection for CPU2
    $04 constant PWR_FPDR                       \ [0x04] Flash power down mode during LPRun for CPU2
    $05 constant PWR_FPDS                       \ [0x05] Flash power down mode during LPSleep for CPU2
    $0e constant PWR_BLEEWKUP                   \ [0x0e] BLE external wakeup signal
    $0f constant PWR_EWKUP802                   \ [0x0f] 802.15.4 external wakeup signal
  [then]


  [ifdef] PWR_C2CR3_DEF
    \
    \ @brief CPU2 Power control register 3
    \ Address offset: 0x84
    \ Reset value: 0x00008000
    \
    $00 constant PWR_EWUP1                      \ [0x00] Enable Wakeup pin WKUP1 for CPU2
    $01 constant PWR_EWUP2                      \ [0x01] Enable Wakeup pin WKUP2 for CPU2
    $02 constant PWR_EWUP3                      \ [0x02] Enable Wakeup pin WKUP3 for CPU2
    $03 constant PWR_EWUP4                      \ [0x03] Enable Wakeup pin WKUP4 for CPU2
    $04 constant PWR_EWUP5                      \ [0x04] Enable Wakeup pin WKUP5 for CPU2
    $09 constant PWR_EBLEWUP                    \ [0x09] Enable BLE host wakeup interrupt for CPU2
    $0a constant PWR_E802WUP                    \ [0x0a] Enable 802.15.4 host wakeup interrupt for CPU2
    $0c constant PWR_APC                        \ [0x0c] Apply pull-up and pull-down configuration for CPU2
    $0f constant PWR_EIWUL                      \ [0x0f] Enable internal wakeup line for CPU2
  [then]


  [ifdef] PWR_EXTSCR_DEF
    \
    \ @brief Power status clear register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant PWR_C1CSSF                     \ [0x00] Clear CPU1 Stop Standby flags
    $01 constant PWR_C2CSSF                     \ [0x01] Clear CPU2 Stop Standby flags
    $02 constant PWR_CCRPF                      \ [0x02] Clear Critical Radio system phase
    $08 constant PWR_C1SBF                      \ [0x08] System Standby flag for CPU1
    $09 constant PWR_C1STOPF                    \ [0x09] System Stop flag for CPU1
    $0a constant PWR_C2SBF                      \ [0x0a] System Standby flag for CPU2
    $0b constant PWR_C2STOPF                    \ [0x0b] System Stop flag for CPU2
    $0d constant PWR_CRPF                       \ [0x0d] Critical Radio system phase
    $0e constant PWR_C1DS                       \ [0x0e] CPU1 deepsleep mode
    $0f constant PWR_C2DS                       \ [0x0f] CPU2 deepsleep mode
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
  $1C constant PWR_CR5                  \ Power control register 5
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
  $58 constant PWR_PUCRH                \ Power Port H pull-up control register
  $5C constant PWR_PDCRH                \ Power Port H pull-down control register
  $80 constant PWR_C2CR1                \ CPU2 Power control register 1
  $84 constant PWR_C2CR3                \ CPU2 Power control register 3
  $88 constant PWR_EXTSCR               \ Power status clear register

: PWR_DEF ; [then]
