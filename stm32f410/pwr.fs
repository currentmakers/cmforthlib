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
    $09 constant PWR_FPDS                       \ [0x09] Flash power down in Stop mode
    $0d constant PWR_ADCDC1                     \ [0x0d] ADCDC1
    $0e constant PWR_VOS                        \ [0x0e : 2] Regulator voltage scaling output selection
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
    $03 constant PWR_BRR                        \ [0x03] Backup regulator ready
    $06 constant PWR_EWUP3                      \ [0x06] Enable WKUP3 pin
    $07 constant PWR_EWUP2                      \ [0x07] Enable WKUP2 pin
    $08 constant PWR_EWUP1                      \ [0x08] Enable WKUP1 pin
    $09 constant PWR_BRE                        \ [0x09] Backup regulator enable
    $0e constant PWR_VOSRDY                     \ [0x0e] Regulator voltage scaling output selection ready bit
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_CR                   \ power control register
  $04 constant PWR_CSR                  \ power control/status register

: PWR_DEF ; [then]
