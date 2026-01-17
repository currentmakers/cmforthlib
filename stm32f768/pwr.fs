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
    \ @brief power control register
    \ Address offset: 0x00
    \ Reset value: 0x0000C000
    \
    $00 constant PWR_LPDS                       \ [0x00] Low-power deep sleep
    $01 constant PWR_PDDS                       \ [0x01] Power down deepsleep
    $03 constant PWR_CSBF                       \ [0x03] Clear standby flag
    $04 constant PWR_PVDE                       \ [0x04] Power voltage detector enable
    $05 constant PWR_PLS                        \ [0x05 : 3] PVD level selection
    $08 constant PWR_DBP                        \ [0x08] Disable backup domain write protection
    $09 constant PWR_FPDS                       \ [0x09] Flash power down in Stop mode
    $0a constant PWR_LPUDS                      \ [0x0a] Low-power regulator in deepsleep under-drive mode
    $0b constant PWR_MRUDS                      \ [0x0b] Main regulator in deepsleep under-drive mode
    $0d constant PWR_ADCDC1                     \ [0x0d] ADCDC1
    $0e constant PWR_VOS                        \ [0x0e : 2] Regulator voltage scaling output selection
    $10 constant PWR_ODEN                       \ [0x10] Over-drive enable
    $11 constant PWR_ODSWEN                     \ [0x11] Over-drive switching enabled
    $12 constant PWR_UDEN                       \ [0x12 : 2] Under-drive enable in stop mode
  [then]


  [ifdef] PWR_CSR1_DEF
    \
    \ @brief power control/status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUIF                       \ [0x00] Wakeup internal flag
    $01 constant PWR_SBF                        \ [0x01] Standby flag
    $02 constant PWR_PVDO                       \ [0x02] PVD output
    $03 constant PWR_BRR                        \ [0x03] Backup regulator ready
    $09 constant PWR_BRE                        \ [0x09] Backup regulator enable
    $0e constant PWR_VOSRDY                     \ [0x0e] Regulator voltage scaling output selection ready bit
    $10 constant PWR_ODRDY                      \ [0x10] Over-drive mode ready
    $11 constant PWR_ODSWRDY                    \ [0x11] Over-drive mode switching ready
    $12 constant PWR_UDRDY                      \ [0x12 : 2] Under-drive ready flag
  [then]


  [ifdef] PWR_CR2_DEF
    \
    \ @brief power control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CWUPF1                     \ [0x00] Clear Wakeup Pin flag for PA0
    $01 constant PWR_CWUPF2                     \ [0x01] Clear Wakeup Pin flag for PA2
    $02 constant PWR_CWUPF3                     \ [0x02] Clear Wakeup Pin flag for PC1
    $03 constant PWR_CWUPF4                     \ [0x03] Clear Wakeup Pin flag for PC13
    $04 constant PWR_CWUPF5                     \ [0x04] Clear Wakeup Pin flag for PI8
    $05 constant PWR_CWUPF6                     \ [0x05] Clear Wakeup Pin flag for PI11
    $08 constant PWR_WUPP1                      \ [0x08] Wakeup pin polarity bit for PA0
    $09 constant PWR_WUPP2                      \ [0x09] Wakeup pin polarity bit for PA2
    $0a constant PWR_WUPP3                      \ [0x0a] Wakeup pin polarity bit for PC1
    $0b constant PWR_WUPP4                      \ [0x0b] Wakeup pin polarity bit for PC13
    $0c constant PWR_WUPP5                      \ [0x0c] Wakeup pin polarity bit for PI8
    $0d constant PWR_WUPP6                      \ [0x0d] Wakeup pin polarity bit for PI11
  [then]


  [ifdef] PWR_CSR2_DEF
    \
    \ @brief power control/status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUPF1                      \ [0x00] Wakeup Pin flag for PA0
    $01 constant PWR_WUPF2                      \ [0x01] Wakeup Pin flag for PA2
    $02 constant PWR_WUPF3                      \ [0x02] Wakeup Pin flag for PC1
    $03 constant PWR_WUPF4                      \ [0x03] Wakeup Pin flag for PC13
    $04 constant PWR_WUPF5                      \ [0x04] Wakeup Pin flag for PI8
    $05 constant PWR_WUPF6                      \ [0x05] Wakeup Pin flag for PI11
    $08 constant PWR_EWUP1                      \ [0x08] Enable Wakeup pin for PA0
    $09 constant PWR_EWUP2                      \ [0x09] Enable Wakeup pin for PA2
    $0a constant PWR_EWUP3                      \ [0x0a] Enable Wakeup pin for PC1
    $0b constant PWR_EWUP4                      \ [0x0b] Enable Wakeup pin for PC13
    $0c constant PWR_EWUP5                      \ [0x0c] Enable Wakeup pin for PI8
    $0d constant PWR_EWUP6                      \ [0x0d] Enable Wakeup pin for PI11
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_CR1                  \ power control register
  $04 constant PWR_CSR1                 \ power control/status register
  $08 constant PWR_CR2                  \ power control register
  $0C constant PWR_CSR2                 \ power control/status register

: PWR_DEF ; [then]
