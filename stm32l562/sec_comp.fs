\
\ @file sec_comp.fs
\ @brief Comparator
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

$00000001 constant SEC_COMP_COMP1_CSR_COMP1_EN                      \ Comparator 1 enable bit
$0000000c constant SEC_COMP_COMP1_CSR_COMP1_PWRMODE                 \ Power Mode of the comparator 1
$00000070 constant SEC_COMP_COMP1_CSR_COMP1_INMSEL                  \ Comparator 1 Input Minus connection configuration bit
$00000080 constant SEC_COMP_COMP1_CSR_COMP1_INPSEL                  \ Comparator1 input plus selection bit
$00008000 constant SEC_COMP_COMP1_CSR_COMP1_POLARITY                \ Comparator 1 polarity selection bit
$00030000 constant SEC_COMP_COMP1_CSR_COMP1_HYST                    \ Comparator 1 hysteresis selection bits
$001c0000 constant SEC_COMP_COMP1_CSR_COMP1_BLANKING                \ Comparator 1 blanking source selection bits
$00400000 constant SEC_COMP_COMP1_CSR_COMP1_BRGEN                   \ Scaler bridge enable
$00800000 constant SEC_COMP_COMP1_CSR_COMP1_SCALEN                  \ Voltage scaler enable bit
$40000000 constant SEC_COMP_COMP1_CSR_COMP1_VALUE                   \ Comparator 1 output status bit
$80000000 constant SEC_COMP_COMP1_CSR_COMP1_LOCK                    \ COMP1_CSR register lock bit


\
\ @brief Comparator 2 control and status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_COMP_COMP2_CSR_COMP2_EN                      \ Comparator 2 enable bit
$0000000c constant SEC_COMP_COMP2_CSR_COMP2_PWRMODE                 \ Power Mode of the comparator 2
$00000070 constant SEC_COMP_COMP2_CSR_COMP2_INMSEL                  \ Comparator 2 Input Minus connection configuration bit
$00000080 constant SEC_COMP_COMP2_CSR_COMP2_INPSEL                  \ Comparator 2 Input Plus connection configuration bit
$00000200 constant SEC_COMP_COMP2_CSR_COMP2_WINMODE                 \ Windows mode selection bit
$00008000 constant SEC_COMP_COMP2_CSR_COMP2_POLARITY                \ Comparator 2 polarity selection bit
$00030000 constant SEC_COMP_COMP2_CSR_COMP2_HYST                    \ Comparator 2 hysteresis selection bits
$001c0000 constant SEC_COMP_COMP2_CSR_COMP2_BLANKING                \ Comparator 2 blanking source selection bits
$00400000 constant SEC_COMP_COMP2_CSR_COMP2_BRGEN                   \ Scaler bridge enable
$00800000 constant SEC_COMP_COMP2_CSR_COMP2_SCALEN                  \ Voltage scaler enable bit
$40000000 constant SEC_COMP_COMP2_CSR_COMP2_VALUE                   \ Comparator 2 output status bit
$80000000 constant SEC_COMP_COMP2_CSR_COMP2_LOCK                    \ COMP2_CSR register lock bit


\
\ @brief Comparator
\
$50010200 constant SEC_COMP_COMP1_CSR  \ offset: 0x00 : Comparator 1 control and status register
$50010204 constant SEC_COMP_COMP2_CSR  \ offset: 0x04 : Comparator 2 control and status register

