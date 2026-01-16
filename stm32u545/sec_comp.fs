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
$000000f0 constant SEC_COMP_COMP1_CSR_COMP1_INMSEL                  \ Comparator 1 Input Minus connection configuration bit
$00000300 constant SEC_COMP_COMP1_CSR_COMP1_INPSEL                  \ Comparator1 input plus selection bit
$00000800 constant SEC_COMP_COMP1_CSR_COMP1_WINMODE                 \ COMP1_WINMODE
$00004000 constant SEC_COMP_COMP1_CSR_COMP1_WINOUT                  \ COMP1_WINOUT
$00008000 constant SEC_COMP_COMP1_CSR_COMP1_POLARITY                \ Comparator 1 polarity selection bit
$00030000 constant SEC_COMP_COMP1_CSR_COMP1_HYST                    \ Comparator 1 hysteresis selection bits
$000c0000 constant SEC_COMP_COMP1_CSR_COMP1_PWRMODE                 \ COMP1_PWRMODE
$01f00000 constant SEC_COMP_COMP1_CSR_COMP1_BLANKSEL                \ COMP1_BLANKSEL
$40000000 constant SEC_COMP_COMP1_CSR_COMP1_VALUE                   \ Comparator 1 output status bit
$80000000 constant SEC_COMP_COMP1_CSR_COMP1_LOCK                    \ COMP1_CSR register lock bit


\
\ @brief Comparator 2 control and status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_COMP_COMP2_CSR_COM2_EN                       \ Comparator 2 enable bit
$000000f0 constant SEC_COMP_COMP2_CSR_COM2_INMSEL                   \ Comparator 2 Input Minus connection configuration bit
$00000300 constant SEC_COMP_COMP2_CSR_COM2_INPSEL                   \ Comparator 2 input plus selection bit
$00000800 constant SEC_COMP_COMP2_CSR_COM2_WINMODE                  \ COM2_WINMODE
$00004000 constant SEC_COMP_COMP2_CSR_COM2_WINOUT                   \ COM2_WINOUT
$00008000 constant SEC_COMP_COMP2_CSR_COM2_POLARITY                 \ Comparator 2 polarity selection bit
$00030000 constant SEC_COMP_COMP2_CSR_COM2_HYST                     \ Comparator 2 hysteresis selection bits
$000c0000 constant SEC_COMP_COMP2_CSR_COM2_PWRMODE                  \ COM2_PWRMODE
$01f00000 constant SEC_COMP_COMP2_CSR_COM2_BLANKSEL                 \ COM2_BLANKSEL
$40000000 constant SEC_COMP_COMP2_CSR_COM2_VALUE                    \ Comparator 2 output status bit
$80000000 constant SEC_COMP_COMP2_CSR_COM2_LOCK                     \ COMP2_CSR register lock bit


\
\ @brief Comparator
\
$56005400 constant SEC_COMP_COMP1_CSR  \ offset: 0x00 : Comparator 1 control and status register
$56005404 constant SEC_COMP_COMP2_CSR  \ offset: 0x04 : Comparator 2 control and status register

