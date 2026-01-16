\
\ @file comp1.fs
\ @brief COMP address block description
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

$00000001 constant COMP1_COMP1_CSR_EN                               \ Comparator 1 enable bit This bit is controlled by software (if not locked). It enables the comparator 1:
$000000f0 constant COMP1_COMP1_CSR_INMSEL                           \ Comparator 1 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP_INM of the comparator 1: Refer to Table176: COMP1 inverting input assignment.
$00000700 constant COMP1_COMP1_CSR_INPSEL                           \ Comparator 1 signal selector for noninverting input This bitfield is controlled by software (if not locked). It selects the signal for the noninverting input COMP_INP of the comparator 1 (also see the WINMODE bit): Refer to Table175: COMP1 noninverting input assignment.
$00000800 constant COMP1_COMP1_CSR_WINMODE                          \ Comparator 1 noninverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP_INP input of the comparator 1:
$00004000 constant COMP1_COMP1_CSR_WINOUT                           \ Comparator 1 output selector This bit is controlled by software (if not locked). It selects the comparator 1 output:
$00008000 constant COMP1_COMP1_CSR_POLARITY                         \ Comparator 1 polarity selector This bit is controlled by software (if not locked). It selects the comparator 1 output polarity:
$00030000 constant COMP1_COMP1_CSR_HYST                             \ Comparator 1 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 1:
$000c0000 constant COMP1_COMP1_CSR_PWRMODE                          \ Comparator 1 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 1:
$01f00000 constant COMP1_COMP1_CSR_BLANKSEL                         \ Comparator 1 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: Others: Reserved, must not be used
$40000000 constant COMP1_COMP1_CSR_VALUE                            \ Comparator 1 output status This bit is read-only. It reflects the level of the comparator 1 output after the polarity selector and blanking, as indicated in Figure163.
$80000000 constant COMP1_COMP1_CSR_LOCK                             \ COMP_CSR register lock This bit is set by software and cleared by a system reset. It locks the comparator 3 control bits. When locked, all register bits are read-only.


\
\ @brief Comparator 2 control and status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant COMP1_COMP2_CSR_EN                               \ Comparator 2 enable bit This bit is controlled by software (if not locked). It enables the comparator 2:
$000000f0 constant COMP1_COMP2_CSR_INMSEL                           \ Comparator 2 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP_INM of the comparator 2: Refer to Table178: COMP2 inverting input assignment.
$00000300 constant COMP1_COMP2_CSR_INPSEL                           \ Comparator 2 signal selector for noninverting input This bitfield is controlled by software (if not locked). It selects the signal for the noninverting input COMP_INP of the comparator 2 (also see the WINMODE bit): Refer to Table177: COMP2 noninverting input assignment.
$00000800 constant COMP1_COMP2_CSR_WINMODE                          \ Comparator 2 noninverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP_INP input of the comparator 2:
$00004000 constant COMP1_COMP2_CSR_WINOUT                           \ Comparator 2 output selector This bit is controlled by software (if not locked). It selects the comparator 2 output:
$00008000 constant COMP1_COMP2_CSR_POLARITY                         \ Comparator 2 polarity selector This bit is controlled by software (if not locked). It selects the comparator 2 output polarity:
$00030000 constant COMP1_COMP2_CSR_HYST                             \ Comparator 2 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 2:
$000c0000 constant COMP1_COMP2_CSR_PWRMODE                          \ Comparator 2 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 2:
$01f00000 constant COMP1_COMP2_CSR_BLANKSEL                         \ Comparator 2 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: Others: Reserved, must not be used
$40000000 constant COMP1_COMP2_CSR_VALUE                            \ Comparator 2 output status This bit is read-only. It reflects the level of the comparator 2 output after the polarity selector and blanking, as indicated in Figure163.
$80000000 constant COMP1_COMP2_CSR_LOCK                             \ COMP_CSR register lock This bit is set by software and cleared by a system reset. It locks the comparator 3 control bits. When locked, all register bits are read-only.


\
\ @brief COMP address block description
\
$40010200 constant COMP1_COMP1_CSR  \ offset: 0x00 : Comparator 1 control and status register
$40010204 constant COMP1_COMP2_CSR  \ offset: 0x04 : Comparator 2 control and status register

