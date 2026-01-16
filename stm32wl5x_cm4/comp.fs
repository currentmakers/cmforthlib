\
\ @file comp.fs
\ @brief Comparator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief COMP1_CSR
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP1_CSR_EN                                \ Comparator 1 enable bit
$0000000c constant COMP_COMP1_CSR_PWRMODE                           \ Power Mode of the comparator 1
$00000070 constant COMP_COMP1_CSR_INMSEL                            \ Comparator 1 input minus selection bits
$00000180 constant COMP_COMP1_CSR_INPSEL                            \ Comparator1 input plus selection bit
$00008000 constant COMP_COMP1_CSR_POLARITY                          \ Comparator 1 polarity selection bit
$00030000 constant COMP_COMP1_CSR_HYST                              \ Comparator 1 hysteresis selection bits
$001c0000 constant COMP_COMP1_CSR_BLANKING                          \ Comparator 1 blanking source selection bits
$00400000 constant COMP_COMP1_CSR_BRGEN                             \ Scaler bridge enable
$00800000 constant COMP_COMP1_CSR_SCALEN                            \ Voltage scaler enable bit
$06000000 constant COMP_COMP1_CSR_INMESEL                           \ comparator 1 input minus extended selection bits.
$40000000 constant COMP_COMP1_CSR_VALUE                             \ Comparator 1 output status bit
$80000000 constant COMP_COMP1_CSR_LOCK                              \ COMP1_CSR register lock bit


\
\ @brief COMP2_CSR
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP2_CSR_EN                                \ Comparator 2 enable bit
$0000000c constant COMP_COMP2_CSR_PWRMODE                           \ Power Mode of the comparator 2
$00000070 constant COMP_COMP2_CSR_INMSEL                            \ Comparator 2 input minus selection bits
$00000180 constant COMP_COMP2_CSR_INPSEL                            \ Comparator 1 input plus selection bit
$00000200 constant COMP_COMP2_CSR_WINMODE                           \ Windows mode selection bit
$00008000 constant COMP_COMP2_CSR_POLARITY                          \ Comparator 2 polarity selection bit
$00030000 constant COMP_COMP2_CSR_HYST                              \ Comparator 2 hysteresis selection bits
$001c0000 constant COMP_COMP2_CSR_BLANKING                          \ Comparator 2 blanking source selection bits
$00400000 constant COMP_COMP2_CSR_BRGEN                             \ Scaler bridge enable
$00800000 constant COMP_COMP2_CSR_SCALEN                            \ Voltage scaler enable bit
$06000000 constant COMP_COMP2_CSR_INMESEL                           \ comparator 2 input minus extended selection bits.
$40000000 constant COMP_COMP2_CSR_VALUE                             \ Comparator 2 output status bit
$80000000 constant COMP_COMP2_CSR_LOCK                              \ CSR register lock bit


\
\ @brief Comparator
\
$40010200 constant COMP_COMP1_CSR  \ offset: 0x00 : COMP1_CSR
$40010204 constant COMP_COMP2_CSR  \ offset: 0x04 : COMP2_CSR

