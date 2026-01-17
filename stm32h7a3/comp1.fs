\
\ @file comp1.fs
\ @brief COMP1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP1_DEF

  [ifdef] COMP1_SR_DEF
    \
    \ @brief Comparator status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP1_C1VAL                    \ [0x00] COMP channel 1 output status bit
    $01 constant COMP1_C2VAL                    \ [0x01] COMP channel 2 output status bit
    $10 constant COMP1_C1IF                     \ [0x10] COMP channel 1 Interrupt Flag
    $11 constant COMP1_C2IF                     \ [0x11] COMP channel 2 Interrupt Flag
  [then]


  [ifdef] COMP1_ICFR_DEF
    \
    \ @brief Comparator interrupt clear flag register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $10 constant COMP1_CC1IF                    \ [0x10] Clear COMP channel 1 Interrupt Flag
    $11 constant COMP1_CC2IF                    \ [0x11] Clear COMP channel 2 Interrupt Flag
  [then]


  [ifdef] COMP1_OR_DEF
    \
    \ @brief Comparator option register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant COMP1_AFOP                     \ [0x00 : 11] Selection of source for alternate function of output ports
    $0b constant COMP1_OR                       \ [0x0b : 21] Option Register
  [then]


  [ifdef] COMP1_CFGR1_DEF
    \
    \ @brief Comparator configuration register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant COMP1_EN                       \ [0x00] COMP channel 1 enable bit
    $01 constant COMP1_BRGEN                    \ [0x01] Scaler bridge enable
    $02 constant COMP1_SCALEN                   \ [0x02] Voltage scaler enable bit
    $03 constant COMP1_POLARITY                 \ [0x03] COMP channel 1 polarity selection bit
    $06 constant COMP1_ITEN                     \ [0x06] COMP channel 1 interrupt enable
    $08 constant COMP1_HYST                     \ [0x08 : 2] COMP channel 1 hysteresis selection bits
    $0c constant COMP1_PWRMODE                  \ [0x0c : 2] Power Mode of the COMP channel 1
    $10 constant COMP1_INMSEL                   \ [0x10 : 3] COMP channel 1 inverting input selection field
    $14 constant COMP1_INPSEL                   \ [0x14] COMP channel 1 non-inverting input selection bit
    $18 constant COMP1_BLANKING                 \ [0x18 : 4] COMP channel 1 blanking source selection bits
    $1f constant COMP1_LOCK                     \ [0x1f] Lock bit
  [then]


  [ifdef] COMP1_CFGR2_DEF
    \
    \ @brief Comparator configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant COMP1_EN                       \ [0x00] COMP channel 1 enable bit
    $01 constant COMP1_BRGEN                    \ [0x01] Scaler bridge enable
    $02 constant COMP1_SCALEN                   \ [0x02] Voltage scaler enable bit
    $03 constant COMP1_POLARITY                 \ [0x03] COMP channel 1 polarity selection bit
    $04 constant COMP1_WINMODE                  \ [0x04] Window comparator mode selection bit
    $06 constant COMP1_ITEN                     \ [0x06] COMP channel 1 interrupt enable
    $08 constant COMP1_HYST                     \ [0x08 : 2] COMP channel 1 hysteresis selection bits
    $0c constant COMP1_PWRMODE                  \ [0x0c : 2] Power Mode of the COMP channel 1
    $10 constant COMP1_INMSEL                   \ [0x10 : 3] COMP channel 1 inverting input selection field
    $14 constant COMP1_INPSEL                   \ [0x14] COMP channel 1 non-inverting input selection bit
    $18 constant COMP1_BLANKING                 \ [0x18 : 4] COMP channel 1 blanking source selection bits
    $1f constant COMP1_LOCK                     \ [0x1f] Lock bit
  [then]

  \
  \ @brief COMP1
  \
  $00 constant COMP1_SR                 \ Comparator status register
  $04 constant COMP1_ICFR               \ Comparator interrupt clear flag register
  $08 constant COMP1_OR                 \ Comparator option register
  $0C constant COMP1_CFGR1              \ Comparator configuration register 1
  $10 constant COMP1_CFGR2              \ Comparator configuration register 2

: COMP1_DEF ; [then]
