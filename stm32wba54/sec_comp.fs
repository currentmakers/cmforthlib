\
\ @file sec_comp.fs
\ @brief Comparator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief COMP1 control and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_COMP_COMP1_CSR_EN                            \ COMP1 enable
$000000f0 constant SEC_COMP_COMP1_CSR_INMSEL                        \ COMP1 signal selector for inverting input INM Controlled by software (if not locked), selects the signal for the inverting input COMP1_INM
$00000700 constant SEC_COMP_COMP1_CSR_INPSEL                        \ COMP1 signal selector for inverting input INM Controlled by software (if not locked), selects the signal for the inverting input COMP1_INM
$00000800 constant SEC_COMP_COMP1_CSR_WINMODE                       \ COMP1 noninverting input selector for window mode Controlled by software (if not locked), selects the signal for the COMP1_INP input of the COMP1.
$00004000 constant SEC_COMP_COMP1_CSR_WINOUT                        \ COMP1 output selector Controlled by software (if not locked), selects the COMP1 output.
$00008000 constant SEC_COMP_COMP1_CSR_POLARITY                      \ COMP1 polarity selector Controlled by software (if not locked), selects the COMP1 output polarity
$00030000 constant SEC_COMP_COMP1_CSR_HYST                          \ COMP1 hysteresis selector Controlled by software (if not locked), selects the COMP1 hysteresis.
$000c0000 constant SEC_COMP_COMP1_CSR_PWRMODE                       \ COMP1 power mode selector Controlled by software (if not locked), selects the power consumption and, as a consequence, the speed of the COMP1.
$01f00000 constant SEC_COMP_COMP1_CSR_BLANKSEL                      \ COMP1 blanking source selector.
$40000000 constant SEC_COMP_COMP1_CSR_VALUE                         \ COMP1 output status.
$80000000 constant SEC_COMP_COMP1_CSR_LOCK                          \ COMP1_CSR register lock.


\
\ @brief COMP2 control and status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_COMP_COMP2_CSR_EN                            \ COMP1 enable
$000000f0 constant SEC_COMP_COMP2_CSR_INMSEL                        \ COMP1 signal selector for inverting input INM Controlled by software (if not locked), selects the signal for the inverting input COMP1_INM
$00000300 constant SEC_COMP_COMP2_CSR_INPSEL                        \ COMP1 signal selector for inverting input INM Controlled by software (if not locked), selects the signal for the inverting input COMP1_INM
$00000800 constant SEC_COMP_COMP2_CSR_WINMODE                       \ COMP1 noninverting input selector for window mode Controlled by software (if not locked), selects the signal for the COMP1_INP input of the COMP1.
$00004000 constant SEC_COMP_COMP2_CSR_WINOUT                        \ COMP1 output selector Controlled by software (if not locked), selects the COMP1 output.
$00008000 constant SEC_COMP_COMP2_CSR_POLARITY                      \ COMP1 polarity selector Controlled by software (if not locked), selects the COMP1 output polarity
$00030000 constant SEC_COMP_COMP2_CSR_HYST                          \ COMP1 hysteresis selector Controlled by software (if not locked), selects the COMP1 hysteresis.
$000c0000 constant SEC_COMP_COMP2_CSR_PWRMODE                       \ COMP1 power mode selector Controlled by software (if not locked), selects the power consumption and, as a consequence, the speed of the COMP1.
$01f00000 constant SEC_COMP_COMP2_CSR_BLANKSEL                      \ COMP1 blanking source selector.
$40000000 constant SEC_COMP_COMP2_CSR_VALUE                         \ COMP1 output status.
$80000000 constant SEC_COMP_COMP2_CSR_LOCK                          \ COMP1_CSR register lock.


\
\ @brief Comparator
\
$56005400 constant SEC_COMP_COMP1_CSR  \ offset: 0x00 : COMP1 control and status register
$56005404 constant SEC_COMP_COMP2_CSR  \ offset: 0x04 : COMP2 control and status register

