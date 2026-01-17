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
    \ @brief Power control register (PWR_CR)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PWR_LPDS                       \ [0x00] Low Power Deep Sleep
    $01 constant PWR_PDDS                       \ [0x01] Power Down Deep Sleep
    $02 constant PWR_CWUF                       \ [0x02] Clear Wake-up Flag
    $03 constant PWR_CSBF                       \ [0x03] Clear STANDBY Flag
    $04 constant PWR_PVDE                       \ [0x04] Power Voltage Detector Enable
    $05 constant PWR_PLS                        \ [0x05 : 3] PVD Level Selection
    $08 constant PWR_DBP                        \ [0x08] Disable Backup Domain write protection
  [then]


  [ifdef] PWR_CSR_DEF
    \
    \ @brief Power control register (PWR_CR)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUF                        \ [0x00] Wake-Up Flag
    $01 constant PWR_SBF                        \ [0x01] STANDBY Flag
    $02 constant PWR_PVDO                       \ [0x02] PVD Output
    $08 constant PWR_EWUP                       \ [0x08] Enable WKUP pin
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_CR                   \ Power control register (PWR_CR)
  $04 constant PWR_CSR                  \ Power control register (PWR_CR)

: PWR_DEF ; [then]
