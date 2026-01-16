\
\ @file comp.fs
\ @brief COMP1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Comparator 1 control and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP1_CSR_EN                                \ COMP channel 1 enable bit
$000000f0 constant COMP_COMP1_CSR_INMSEL                            \ Comparator 2 signal selector for inverting input INM
$00000300 constant COMP_COMP1_CSR_INPSEL                            \ Comparator 2 signal selector for non-inverting input
$00000800 constant COMP_COMP1_CSR_WINMODE                           \ Comparator 2 non-inverting input selector for window mode
$00004000 constant COMP_COMP1_CSR_WINOUT                            \ Comparator 2 output selector
$00008000 constant COMP_COMP1_CSR_POLARITY                          \ Comparator 2 polarity selector
$00030000 constant COMP_COMP1_CSR_HYST                              \ Comparator 2 hysteresis selector
$000c0000 constant COMP_COMP1_CSR_PWRMODE                           \ Comparator 2 power mode selector
$01f00000 constant COMP_COMP1_CSR_BLANKSEL                          \ Comparator 2 blanking source selector
$40000000 constant COMP_COMP1_CSR_VALUE                             \ Comparator 2 output status
$80000000 constant COMP_COMP1_CSR_LOCK                              \ COMP2_CSR register lock


\
\ @brief Comparator 2 control and status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP2_CSR_EN                                \ COMP channel 1 enable bit
$000000f0 constant COMP_COMP2_CSR_INMSEL                            \ Comparator 2 signal selector for inverting input INM
$00000300 constant COMP_COMP2_CSR_INPSEL                            \ Comparator 2 signal selector for non-inverting input
$00000800 constant COMP_COMP2_CSR_WINMODE                           \ Comparator 2 non-inverting input selector for window mode
$00004000 constant COMP_COMP2_CSR_WINOUT                            \ Comparator 2 output selector
$00008000 constant COMP_COMP2_CSR_POLARITY                          \ Comparator 2 polarity selector
$00030000 constant COMP_COMP2_CSR_HYST                              \ Comparator 2 hysteresis selector
$000c0000 constant COMP_COMP2_CSR_PWRMODE                           \ Comparator 2 power mode selector
$01f00000 constant COMP_COMP2_CSR_BLANKSEL                          \ Comparator 2 blanking source selector
$40000000 constant COMP_COMP2_CSR_VALUE                             \ Comparator 2 output status
$80000000 constant COMP_COMP2_CSR_LOCK                              \ COMP2_CSR register lock


\
\ @brief COMP1
\
$40010200 constant COMP_COMP1_CSR  \ offset: 0x00 : Comparator 1 control and status register
$40010204 constant COMP_COMP2_CSR  \ offset: 0x04 : Comparator 2 control and status register

