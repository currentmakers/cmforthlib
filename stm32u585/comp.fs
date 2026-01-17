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
    \ @brief Comparator 1 control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP_COMP1_EN                  \ [0x00] Comparator 1 enable bit
    $04 constant COMP_COMP1_INMSEL              \ [0x04 : 4] Comparator 1 Input Minus connection configuration bit
    $08 constant COMP_COMP1_INPSEL              \ [0x08 : 2] Comparator1 input plus selection bit
    $0b constant COMP_COMP1_WINMODE             \ [0x0b] COMP1_WINMODE
    $0e constant COMP_COMP1_WINOUT              \ [0x0e] COMP1_WINOUT
    $0f constant COMP_COMP1_POLARITY            \ [0x0f] Comparator 1 polarity selection bit
    $10 constant COMP_COMP1_HYST                \ [0x10 : 2] Comparator 1 hysteresis selection bits
    $12 constant COMP_COMP1_PWRMODE             \ [0x12 : 2] COMP1_PWRMODE
    $14 constant COMP_COMP1_BLANKSEL            \ [0x14 : 5] COMP1_BLANKSEL
    $1e constant COMP_COMP1_VALUE               \ [0x1e] Comparator 1 output status bit
    $1f constant COMP_COMP1_LOCK                \ [0x1f] COMP1_CSR register lock bit
  [then]


  [ifdef] COMP_COMP2_CSR_DEF
    \
    \ @brief Comparator 2 control and status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant COMP_COM2_EN                   \ [0x00] Comparator 2 enable bit
    $04 constant COMP_COM2_INMSEL               \ [0x04 : 4] Comparator 2 Input Minus connection configuration bit
    $08 constant COMP_COM2_INPSEL               \ [0x08 : 2] Comparator 2 input plus selection bit
    $0b constant COMP_COM2_WINMODE              \ [0x0b] COM2_WINMODE
    $0e constant COMP_COM2_WINOUT               \ [0x0e] COM2_WINOUT
    $0f constant COMP_COM2_POLARITY             \ [0x0f] Comparator 2 polarity selection bit
    $10 constant COMP_COM2_HYST                 \ [0x10 : 2] Comparator 2 hysteresis selection bits
    $12 constant COMP_COM2_PWRMODE              \ [0x12 : 2] COM2_PWRMODE
    $14 constant COMP_COM2_BLANKSEL             \ [0x14 : 5] COM2_BLANKSEL
    $1e constant COMP_COM2_VALUE                \ [0x1e] Comparator 2 output status bit
    $1f constant COMP_COM2_LOCK                 \ [0x1f] COMP2_CSR register lock bit
  [then]

  \
  \ @brief Comparator
  \
  $00 constant COMP_COMP1_CSR           \ Comparator 1 control and status register
  $04 constant COMP_COMP2_CSR           \ Comparator 2 control and status register

: COMP_DEF ; [then]
