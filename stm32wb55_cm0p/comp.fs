\
\ @file comp.fs
\ @brief Comparator instance 1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP_DEF

  [ifdef] COMP_COMP1_CSR_DEF
    \
    \ @brief Comparator control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP_COMP1_EN                  \ [0x00] Comparator enable
    $02 constant COMP_COMP1_PWRMODE             \ [0x02 : 2] Comparator power mode
    $04 constant COMP_COMP1_INMSEL              \ [0x04 : 3] Comparator input minus selection
    $07 constant COMP_COMP1_INPSEL              \ [0x07 : 2] Comparator input plus selection
    $0f constant COMP_COMP1_POLARITY            \ [0x0f] Comparator output polarity
    $10 constant COMP_COMP1_HYST                \ [0x10 : 2] Comparator hysteresis
    $12 constant COMP_COMP1_BLANKING            \ [0x12 : 3] Comparator blanking source
    $16 constant COMP_COMP1_BRGEN               \ [0x16] Comparator voltage scaler enable
    $17 constant COMP_COMP1_SCALEN              \ [0x17] Comparator scaler bridge enable
    $19 constant COMP_COMP1_INMESEL             \ [0x19 : 2] Comparator input minus extended selection
    $1e constant COMP_COMP1_VALUE               \ [0x1e] Comparator output level
    $1f constant COMP_COMP1_LOCK                \ [0x1f] Comparator lock
  [then]


  [ifdef] COMP_COMP2_CSR_DEF
    \
    \ @brief Comparator 2 control and status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant COMP_COMP2_EN                  \ [0x00] Comparator 2 enable bit
    $02 constant COMP_COMP2_PWRMODE             \ [0x02 : 2] Power Mode of the comparator 2
    $04 constant COMP_COMP2_INMSEL              \ [0x04 : 2] Comparator 2 input minus selection bits
    $07 constant COMP_COMP2_INPSEL              \ [0x07 : 2] Comparator 1 input plus selection bit
    $09 constant COMP_COMP2_WINMODE             \ [0x09] Windows mode selection bit
    $0f constant COMP_COMP2_POLARITY            \ [0x0f] Comparator 2 polarity selection bit
    $10 constant COMP_COMP2_HYST                \ [0x10 : 2] Comparator 2 hysteresis selection bits
    $12 constant COMP_COMP2_BLANKING            \ [0x12 : 3] Comparator 2 blanking source selection bits
    $16 constant COMP_COMP2_BRGEN               \ [0x16] Scaler bridge enable
    $17 constant COMP_COMP2_SCALEN              \ [0x17] Voltage scaler enable bit
    $19 constant COMP_COMP2_INMESEL             \ [0x19 : 2] comparator 2 input minus extended selection bits.
    $1e constant COMP_COMP2_VALUE               \ [0x1e] Comparator 2 output status bit
    $1f constant COMP_COMP2_LOCK                \ [0x1f] CSR register lock bit
  [then]

  \
  \ @brief Comparator instance 1
  \
  $00 constant COMP_COMP1_CSR           \ Comparator control and status register
  $04 constant COMP_COMP2_CSR           \ Comparator 2 control and status register

: COMP_DEF ; [then]
