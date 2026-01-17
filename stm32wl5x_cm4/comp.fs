\
\ @file comp.fs
\ @brief Comparator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP_DEF

  [ifdef] COMP_COMP1_CSR_DEF
    \
    \ @brief COMP1_CSR
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] Comparator 1 enable bit
    $02 constant COMP_PWRMODE                   \ [0x02 : 2] Power Mode of the comparator 1
    $04 constant COMP_INMSEL                    \ [0x04 : 3] Comparator 1 input minus selection bits
    $07 constant COMP_INPSEL                    \ [0x07 : 2] Comparator1 input plus selection bit
    $0f constant COMP_POLARITY                  \ [0x0f] Comparator 1 polarity selection bit
    $10 constant COMP_HYST                      \ [0x10 : 2] Comparator 1 hysteresis selection bits
    $12 constant COMP_BLANKING                  \ [0x12 : 3] Comparator 1 blanking source selection bits
    $16 constant COMP_BRGEN                     \ [0x16] Scaler bridge enable
    $17 constant COMP_SCALEN                    \ [0x17] Voltage scaler enable bit
    $19 constant COMP_INMESEL                   \ [0x19 : 2] comparator 1 input minus extended selection bits.
    $1e constant COMP_VALUE                     \ [0x1e] Comparator 1 output status bit
    $1f constant COMP_LOCK                      \ [0x1f] COMP1_CSR register lock bit
  [then]


  [ifdef] COMP_COMP2_CSR_DEF
    \
    \ @brief COMP2_CSR
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] Comparator 2 enable bit
    $02 constant COMP_PWRMODE                   \ [0x02 : 2] Power Mode of the comparator 2
    $04 constant COMP_INMSEL                    \ [0x04 : 3] Comparator 2 input minus selection bits
    $07 constant COMP_INPSEL                    \ [0x07 : 2] Comparator 1 input plus selection bit
    $09 constant COMP_WINMODE                   \ [0x09] Windows mode selection bit
    $0f constant COMP_POLARITY                  \ [0x0f] Comparator 2 polarity selection bit
    $10 constant COMP_HYST                      \ [0x10 : 2] Comparator 2 hysteresis selection bits
    $12 constant COMP_BLANKING                  \ [0x12 : 3] Comparator 2 blanking source selection bits
    $16 constant COMP_BRGEN                     \ [0x16] Scaler bridge enable
    $17 constant COMP_SCALEN                    \ [0x17] Voltage scaler enable bit
    $19 constant COMP_INMESEL                   \ [0x19 : 2] comparator 2 input minus extended selection bits.
    $1e constant COMP_VALUE                     \ [0x1e] Comparator 2 output status bit
    $1f constant COMP_LOCK                      \ [0x1f] CSR register lock bit
  [then]

  \
  \ @brief Comparator
  \
  $00 constant COMP_COMP1_CSR           \ COMP1_CSR
  $04 constant COMP_COMP2_CSR           \ COMP2_CSR

: COMP_DEF ; [then]
