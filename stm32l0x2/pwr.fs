\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_CR_DEF
    \
    \ @brief power control register
    \ Address offset: 0x00
    \ Reset value: 0x00001000
    \
    $00 constant PWR_LPSDSR                     \ [0x00] Low-power deepsleep/Sleep/Low-power run
    $01 constant PWR_PDDS                       \ [0x01] Power down deepsleep
    $02 constant PWR_CWUF                       \ [0x02] Clear wakeup flag
    $03 constant PWR_CSBF                       \ [0x03] Clear standby flag
    $04 constant PWR_PVDE                       \ [0x04] Power voltage detector enable
    $05 constant PWR_PLS                        \ [0x05 : 3] PVD level selection
    $08 constant PWR_DBP                        \ [0x08] Disable backup domain write protection
    $09 constant PWR_ULP                        \ [0x09] Ultra-low-power mode
    $0a constant PWR_FWU                        \ [0x0a] Fast wakeup
    $0b constant PWR_VOS                        \ [0x0b : 2] Voltage scaling range selection
    $0d constant PWR_DS_EE_KOFF                 \ [0x0d] Deep sleep mode with Flash memory kept off
    $0e constant PWR_LPRUN                      \ [0x0e] Low power run mode
  [then]


  [ifdef] PWR_CSR_DEF
    \
    \ @brief power control/status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUF                        \ [0x00] Wakeup flag
    $01 constant PWR_SBF                        \ [0x01] Standby flag
    $02 constant PWR_PVDO                       \ [0x02] PVD output
    $03 constant PWR_VREFINTRDYF                \ [0x03] Internal voltage reference (VREFINT) ready flag This bit indicates the state of the internal voltage reference, VREFINT.
    $04 constant PWR_VOSF                       \ [0x04] Voltage Scaling select flag
    $05 constant PWR_REGLPF                     \ [0x05] Regulator LP flag
    $08 constant PWR_EWUP1                      \ [0x08] Enable WKUP pin 1
    $09 constant PWR_EWUP2                      \ [0x09] Enable WKUP pin 2
    $0a constant PWR_EWUP3                      \ [0x0a] Enable WKUP pin 3
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_CR                   \ power control register
  $04 constant PWR_CSR                  \ power control/status register

: PWR_DEF ; [then]
