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
    $03 constant PWR_SUBGHZSPINSSSEL            \ [0x03] sub-GHz SPI NSS source select
    $04 constant PWR_FPDR                       \ [0x04] Flash memory power down mode during LPRun for CPU1
    $05 constant PWR_FPDS                       \ [0x05] Flash memory power down mode during LPSleep for CPU1
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
    $01 constant PWR_PLS                        \ [0x01 : 3] Power voltage detector level selection.
    $06 constant PWR_PVME3                      \ [0x06] Peripheral voltage monitoring 3 enable: VDDA vs. 1.62V
  [then]


  [ifdef] PWR_CR3_DEF
    \
    \ @brief Power control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00008000
    \
    $00 constant PWR_EWUP1                      \ [0x00] Enable Wakeup pin WKUP1 for CPU1
    $01 constant PWR_EWUP2                      \ [0x01] Enable Wakeup pin WKUP2 for CPU1
    $02 constant PWR_EWUP3                      \ [0x02] Enable Wakeup pin WKUP3 for CPU1
    $07 constant PWR_EULPEN                     \ [0x07] Ultra-low-power enable
    $08 constant PWR_EWPVD                      \ [0x08] Enable wakeup PVD for CPU1
    $09 constant PWR_RRS                        \ [0x09] SRAM2 retention in Standby mode
    $0a constant PWR_APC                        \ [0x0a] Apply pull-up and pull-down configuration from CPU1
    $0b constant PWR_EWRFBUSY                   \ [0x0b] Enable Radio BUSY Wakeup from Standby for CPU1
    $0d constant PWR_EWRFIRQ                    \ [0x0d] akeup for CPU1
    $0e constant PWR_EC2H                       \ [0x0e] nable CPU2 Hold interrupt for CPU1
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
    $08 constant PWR_VBE                        \ [0x08] VBAT battery charging enable
    $09 constant PWR_VBRS                       \ [0x09] VBAT battery charging resistor selection
    $0b constant PWR_WRFBUSYP                   \ [0x0b] Wakeup Radio BUSY polarity
    $0f constant PWR_C2BOOT                     \ [0x0f] oot CPU2 after reset or wakeup from Stop or Standby modes.
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
    $08 constant PWR_WPVDF                      \ [0x08] Wakeup PVD flag
    $0b constant PWR_WRFBUSYF                   \ [0x0b] Radio BUSY wakeup flag
    $0e constant PWR_C2HF                       \ [0x0e] PU2 Hold interrupt flag
    $0f constant PWR_WUFI                       \ [0x0f] Internal wakeup interrupt flag
  [then]


  [ifdef] PWR_SR2_DEF
    \
    \ @brief Power status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant PWR_C2BOOTS                    \ [0x00] PU2 boot/wakeup request source information
    $01 constant PWR_RFBUSYS                    \ [0x01] Radio BUSY signal status
    $02 constant PWR_RFBUSYMS                   \ [0x02] Radio BUSY masked signal status
    $03 constant PWR_SMPSRDY                    \ [0x03] SMPS ready flag
    $04 constant PWR_LDORDY                     \ [0x04] LDO ready flag
    $05 constant PWR_RFEOLF                     \ [0x05] Radio end of life flag
    $06 constant PWR_REGMRS                     \ [0x06] regulator2 low power flag
    $07 constant PWR_FLASHRDY                   \ [0x07] Flash ready
    $08 constant PWR_REGLPS                     \ [0x08] regulator1 started
    $09 constant PWR_REGLPF                     \ [0x09] regulator1 low power flag
    $0a constant PWR_VOSF                       \ [0x0a] Voltage scaling flag
    $0b constant PWR_PVDO                       \ [0x0b] Power voltage detector output
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
    $08 constant PWR_CWPVDF                     \ [0x08] Clear wakeup PVD interrupt flag
    $0b constant PWR_CWRFBUSYF                  \ [0x0b] Clear wakeup Radio BUSY flag
    $0e constant PWR_CC2HF                      \ [0x0e] lear CPU2 Hold interrupt flag
  [then]


  [ifdef] PWR_CR5_DEF
    \
    \ @brief Power control register 5
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $0e constant PWR_RFEOLEN                    \ [0x0e] Enable Radio End Of Life detector enabled
    $0f constant PWR_SMPSEN                     \ [0x0f] Enable SMPS Step Down converter SMPS mode enabled.
  [then]


  [ifdef] PWR_PUCRA_DEF
    \
    \ @brief Power Port A pull-up control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] Port PA[y] pull-up bit y (y=0 to 13)
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] Port PA15 pull-up
  [then]


  [ifdef] PWR_PDCRA_DEF
    \
    \ @brief Power Port A pull-down control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] Port PA[y] pull-down (y=0 to 12)
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] ull-down
    $0f constant PWR_PD15                       \ [0x0f] PD15
  [then]


  [ifdef] PWR_PUCRB_DEF
    \
    \ @brief Power Port B pull-up control register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $07 constant PWR_PU7                        \ [0x07] PU7
    $08 constant PWR_PU8                        \ [0x08] PU8
    $09 constant PWR_PU9                        \ [0x09] PU9
    $0a constant PWR_PU10                       \ [0x0a] PU10
    $0b constant PWR_PU11                       \ [0x0b] PU11
    $0c constant PWR_PU12                       \ [0x0c] PU12
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] Port PB[y] pull-up (y=0 to 15)
  [then]


  [ifdef] PWR_PDCRB_DEF
    \
    \ @brief Power Port B pull-down control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] Port PB[y] pull-down (y=0 to 3)
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $07 constant PWR_PD7                        \ [0x07] PD7
    $08 constant PWR_PD8                        \ [0x08] PD8
    $09 constant PWR_PD9                        \ [0x09] PD9
    $0a constant PWR_PD10                       \ [0x0a] PD10
    $0b constant PWR_PD11                       \ [0x0b] PD11
    $0c constant PWR_PD12                       \ [0x0c] PD12
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] Port PB[y] pull-down (y=5 to 15)
  [then]


  [ifdef] PWR_PUCRC_DEF
    \
    \ @brief Power Port C pull-up control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] PU0
    $01 constant PWR_PU1                        \ [0x01] PU1
    $02 constant PWR_PU2                        \ [0x02] PU2
    $03 constant PWR_PU3                        \ [0x03] PU3
    $04 constant PWR_PU4                        \ [0x04] PU4
    $05 constant PWR_PU5                        \ [0x05] PU5
    $06 constant PWR_PU6                        \ [0x06] PU6
    $0d constant PWR_PU13                       \ [0x0d] PU13
    $0e constant PWR_PU14                       \ [0x0e] PU14
    $0f constant PWR_PU15                       \ [0x0f] Port PC[y] pull-up (y=13 to 15)
  [then]


  [ifdef] PWR_PDCRC_DEF
    \
    \ @brief Power Port C pull-down control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] PD0
    $01 constant PWR_PD1                        \ [0x01] PD1
    $02 constant PWR_PD2                        \ [0x02] PD2
    $03 constant PWR_PD3                        \ [0x03] PD3
    $04 constant PWR_PD4                        \ [0x04] PD4
    $05 constant PWR_PD5                        \ [0x05] PD5
    $06 constant PWR_PD6                        \ [0x06] PD6
    $0d constant PWR_PD13                       \ [0x0d] PD13
    $0e constant PWR_PD14                       \ [0x0e] PD14
    $0f constant PWR_PD15                       \ [0x0f] Port PC[y] pull-down (y=13 to 15)
  [then]


  [ifdef] PWR_PUCRH_DEF
    \
    \ @brief Power Port H pull-up control register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $03 constant PWR_PU3                        \ [0x03] pull-up
  [then]


  [ifdef] PWR_PDCRH_DEF
    \
    \ @brief Power Port H pull-down control register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $03 constant PWR_PD3                        \ [0x03] pull-down
  [then]


  [ifdef] PWR_C2CR1_DEF
    \
    \ @brief Power CPU2 control register 1 [dual core device only]
    \ Address offset: 0x80
    \ Reset value: 0x00000007
    \
    $00 constant PWR_LPMS                       \ [0x00 : 3] Low-power mode selection for CPU2
    $04 constant PWR_FPDR                       \ [0x04] Flash memory power down mode during LPRun for CPU2
    $05 constant PWR_FPDS                       \ [0x05] Flash memory power down mode during LPSleep for CPU2
  [then]


  [ifdef] PWR_C2CR3_DEF
    \
    \ @brief Power CPU2 control register 3 [dual core device only]
    \ Address offset: 0x84
    \ Reset value: 0x00008000
    \
    $00 constant PWR_EWUP1                      \ [0x00] Enable Wakeup pin WKUP1 for CPU2
    $01 constant PWR_EWUP2                      \ [0x01] Enable Wakeup pin WKUP2 for CPU2
    $02 constant PWR_EWUP3                      \ [0x02] Enable Wakeup pin WKUP3 for CPU2
    $08 constant PWR_EWPVD                      \ [0x08] Enable wakeup PVD for CPU2
    $0a constant PWR_APC                        \ [0x0a] Apply pull-up and pull-down configuration for CPU2
    $0b constant PWR_EWRFBUSY                   \ [0x0b] EWRFBUSY
    $0d constant PWR_EWRFIRQ                    \ [0x0d] akeup for CPU2
    $0f constant PWR_EIWUL                      \ [0x0f] Enable internal wakeup line for CPU2
  [then]


  [ifdef] PWR_EXTSCR_DEF
    \
    \ @brief Power extended status and status clear register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant PWR_C1CSSF                     \ [0x00] Clear CPU1 Stop Standby flags
    $01 constant PWR_C2CSSF                     \ [0x01] lear CPU2 Stop Standby flags
    $08 constant PWR_C1SBF                      \ [0x08] System Standby flag for CPU1. (no core states retained)
    $09 constant PWR_C1STOP2F                   \ [0x09] System Stop2 flag for CPU1. (partial core states retained)
    $0a constant PWR_C1STOPF                    \ [0x0a] System Stop0, 1 flag for CPU1. (All core states retained)
    $0b constant PWR_C2SBF                      \ [0x0b] ystem Standby flag for CPU2. (no core states retained)
    $0c constant PWR_C2STOP2F                   \ [0x0c] ystem Stop2 flag for CPU2. (partial core states retained)
    $0d constant PWR_C2STOPF                    \ [0x0d] ystem Stop0, 1 flag for CPU2. (All core states retained)
    $0e constant PWR_C1DS                       \ [0x0e] CPU1 deepsleep mode
    $0f constant PWR_C2DS                       \ [0x0f] PU2 deepsleep mode
  [then]


  [ifdef] PWR_SECCFGR_DEF
    \
    \ @brief Power security configuration register [dual core device only]
    \ Address offset: 0x8C
    \ Reset value: 0x00008000
    \
    $0f constant PWR_C2EWILA                    \ [0x0f] wakeup on CPU2 illegal access interrupt enable
  [then]


  [ifdef] PWR_SUBGHZSPICR_DEF
    \
    \ @brief Power SPI3 control register
    \ Address offset: 0x90
    \ Reset value: 0x00008000
    \
    $0f constant PWR_NSS                        \ [0x0f] sub-GHz SPI NSS control
  [then]


  [ifdef] PWR_RSSCMDR_DEF
    \
    \ @brief RSS Command register [dual core device only]
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant PWR_RSSCMD                     \ [0x00 : 8] RSS command
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
  $58 constant PWR_PUCRH                \ Power Port H pull-up control register
  $5C constant PWR_PDCRH                \ Power Port H pull-down control register
  $80 constant PWR_C2CR1                \ Power CPU2 control register 1 [dual core device only]
  $84 constant PWR_C2CR3                \ Power CPU2 control register 3 [dual core device only]
  $88 constant PWR_EXTSCR               \ Power extended status and status clear register
  $8C constant PWR_SECCFGR              \ Power security configuration register [dual core device only]
  $90 constant PWR_SUBGHZSPICR          \ Power SPI3 control register
  $98 constant PWR_RSSCMDR              \ RSS Command register [dual core device only]

: PWR_DEF ; [then]
