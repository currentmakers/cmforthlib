\
\ @file comp.fs
\ @brief COMP1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP_DEF

  [ifdef] COMP_COMP1_CSR_DEF
    \
    \ @brief Comparator 1 control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] COMP channel 1 enable bit
    $04 constant COMP_INMSEL                    \ [0x04 : 4] Comparator 2 signal selector for inverting input INM
    $08 constant COMP_INPSEL                    \ [0x08 : 2] Comparator 2 signal selector for non-inverting input
    $0b constant COMP_WINMODE                   \ [0x0b] Comparator 2 non-inverting input selector for window mode
    $0e constant COMP_WINOUT                    \ [0x0e] Comparator 2 output selector
    $0f constant COMP_POLARITY                  \ [0x0f] Comparator 2 polarity selector
    $10 constant COMP_HYST                      \ [0x10 : 2] Comparator 2 hysteresis selector
    $12 constant COMP_PWRMODE                   \ [0x12 : 2] Comparator 2 power mode selector
    $14 constant COMP_BLANKSEL                  \ [0x14 : 5] Comparator 2 blanking source selector
    $1e constant COMP_VALUE                     \ [0x1e] Comparator 2 output status
    $1f constant COMP_LOCK                      \ [0x1f] COMP2_CSR register lock
  [then]


  [ifdef] COMP_COMP2_CSR_DEF
    \
    \ @brief Comparator 2 control and status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] COMP channel 1 enable bit
    $04 constant COMP_INMSEL                    \ [0x04 : 4] Comparator 2 signal selector for inverting input INM
    $08 constant COMP_INPSEL                    \ [0x08 : 2] Comparator 2 signal selector for non-inverting input
    $0b constant COMP_WINMODE                   \ [0x0b] Comparator 2 non-inverting input selector for window mode
    $0e constant COMP_WINOUT                    \ [0x0e] Comparator 2 output selector
    $0f constant COMP_POLARITY                  \ [0x0f] Comparator 2 polarity selector
    $10 constant COMP_HYST                      \ [0x10 : 2] Comparator 2 hysteresis selector
    $12 constant COMP_PWRMODE                   \ [0x12 : 2] Comparator 2 power mode selector
    $14 constant COMP_BLANKSEL                  \ [0x14 : 5] Comparator 2 blanking source selector
    $1e constant COMP_VALUE                     \ [0x1e] Comparator 2 output status
    $1f constant COMP_LOCK                      \ [0x1f] COMP2_CSR register lock
  [then]

  \
  \ @brief COMP1
  \
  $00 constant COMP_COMP1_CSR           \ Comparator 1 control and status register
  $04 constant COMP_COMP2_CSR           \ Comparator 2 control and status register

: COMP_DEF ; [then]
