\
\ @file comp.fs
\ @brief Comparators
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP_DEF

  [ifdef] COMP_CSR_DEF
    \
    \ @brief comparator control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP_PU10K                     \ [0x00] 10 kO pull-up resistor
    $01 constant COMP_PU400K                    \ [0x01] 400 kO pull-up resistor
    $02 constant COMP_PD10K                     \ [0x02] 10 kO pull-down resistor
    $03 constant COMP_PD400K                    \ [0x03] 400 kO pull-down resistor
    $04 constant COMP_CMP1EN                    \ [0x04] Comparator 1 enable
    $05 constant COMP_SW1                       \ [0x05] SW1 analog switch enable
    $07 constant COMP_CMP1OUT                   \ [0x07] Comparator 1 output
    $0c constant COMP_SPEED                     \ [0x0c] Comparator 2 speed mode
    $0d constant COMP_CMP2OUT                   \ [0x0d] Comparator 2 output
    $10 constant COMP_VREFOUTEN                 \ [0x10] VREFINT output enable
    $11 constant COMP_WNDWE                     \ [0x11] Window mode enable
    $12 constant COMP_INSEL                     \ [0x12 : 3] Inverted input selection
    $15 constant COMP_OUTSEL                    \ [0x15 : 3] Comparator 2 output selection
    $1a constant COMP_FCH3                      \ [0x1a] Select GPIO port PA3 as fast ADC input channel CH3.
    $1b constant COMP_FCH8                      \ [0x1b] Select GPIO port PB0 as fast ADC input channel CH8.
    $1c constant COMP_RCH13                     \ [0x1c] Select GPIO port PC3 as re-routed ADC input channel CH13.
    $1d constant COMP_CAIE                      \ [0x1d] Channel Acquisition Interrupt Enable / Clear
    $1e constant COMP_CAIF                      \ [0x1e] Channel acquisition interrupt flag
    $1f constant COMP_TSUSP                     \ [0x1f] Suspend Timer Mode
  [then]

  \
  \ @brief Comparators
  \
  $00 constant COMP_CSR                 \ comparator control and status register

: COMP_DEF ; [then]
