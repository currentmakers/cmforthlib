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
    \ Reset value: 0x00000000
    \
    $00 constant PWR_LPDS                       \ [0x00] Low-power deep sleep
    $01 constant PWR_PDDS                       \ [0x01] Power down deepsleep
    $02 constant PWR_CWUF                       \ [0x02] Clear wakeup flag
    $03 constant PWR_CSBF                       \ [0x03] Clear standby flag
    $04 constant PWR_PVDE                       \ [0x04] Power voltage detector enable
    $05 constant PWR_PLS                        \ [0x05 : 3] PVD level selection
    $08 constant PWR_DBP                        \ [0x08] Disable backup domain write protection
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
    $03 constant PWR_VREFINTRDY                 \ [0x03] VREFINT reference voltage ready
    $08 constant PWR_EWUP1                      \ [0x08] Enable WKUP pin 1
    $09 constant PWR_EWUP2                      \ [0x09] Enable WKUP pin 2
    $0a constant PWR_EWUP3                      \ [0x0a] Enable WKUP pin 3
    $0b constant PWR_EWUP4                      \ [0x0b] Enable WKUP pin 4
    $0c constant PWR_EWUP5                      \ [0x0c] Enable WKUP pin 5
    $0d constant PWR_EWUP6                      \ [0x0d] Enable WKUP pin 6
    $0e constant PWR_EWUP7                      \ [0x0e] Enable WKUP pin 7
    $0f constant PWR_EWUP8                      \ [0x0f] Enable WKUP pin 8
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_CR                   \ power control register
  $04 constant PWR_CSR                  \ power control/status register

: PWR_DEF ; [then]
