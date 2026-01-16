\
\ @file comp.fs
\ @brief Comparators
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief comparator control and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant COMP_CSR_PU10K                                   \ 10 kO pull-up resistor
$00000002 constant COMP_CSR_PU400K                                  \ 400 kO pull-up resistor
$00000004 constant COMP_CSR_PD10K                                   \ 10 kO pull-down resistor
$00000008 constant COMP_CSR_PD400K                                  \ 400 kO pull-down resistor
$00000010 constant COMP_CSR_CMP1EN                                  \ Comparator 1 enable
$00000020 constant COMP_CSR_SW1                                     \ SW1 analog switch enable
$00000080 constant COMP_CSR_CMP1OUT                                 \ Comparator 1 output
$00001000 constant COMP_CSR_SPEED                                   \ Comparator 2 speed mode
$00002000 constant COMP_CSR_CMP2OUT                                 \ Comparator 2 output
$00010000 constant COMP_CSR_VREFOUTEN                               \ VREFINT output enable
$00020000 constant COMP_CSR_WNDWE                                   \ Window mode enable
$001c0000 constant COMP_CSR_INSEL                                   \ Inverted input selection
$00e00000 constant COMP_CSR_OUTSEL                                  \ Comparator 2 output selection
$04000000 constant COMP_CSR_FCH3                                    \ Select GPIO port PA3 as fast ADC input channel CH3.
$08000000 constant COMP_CSR_FCH8                                    \ Select GPIO port PB0 as fast ADC input channel CH8.
$10000000 constant COMP_CSR_RCH13                                   \ Select GPIO port PC3 as re-routed ADC input channel CH13.
$20000000 constant COMP_CSR_CAIE                                    \ Channel Acquisition Interrupt Enable / Clear
$40000000 constant COMP_CSR_CAIF                                    \ Channel acquisition interrupt flag
$80000000 constant COMP_CSR_TSUSP                                   \ Suspend Timer Mode


\
\ @brief Comparators
\
$40007c00 constant COMP_CSR       \ offset: 0x00 : comparator control and status register

