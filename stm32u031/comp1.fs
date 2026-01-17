\
\ @file comp1.fs
\ @brief COMP address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP1_DEF

  [ifdef] COMP1_COMP1_CSR_DEF
    \
    \ @brief Comparator 1 control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP1_EN                       \ [0x00] Comparator 1 enable bit This bit is controlled by software (if not locked). It enables the comparator 1:
    $04 constant COMP1_INMSEL                   \ [0x04 : 4] Comparator 1 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP_INM of the comparator 1: Refer to Table176: COMP1 inverting input assignment.
    $08 constant COMP1_INPSEL                   \ [0x08 : 3] Comparator 1 signal selector for noninverting input This bitfield is controlled by software (if not locked). It selects the signal for the noninverting input COMP_INP of the comparator 1 (also see the WINMODE bit): Refer to Table175: COMP1 noninverting input assignment.
    $0b constant COMP1_WINMODE                  \ [0x0b] Comparator 1 noninverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP_INP input of the comparator 1:
    $0e constant COMP1_WINOUT                   \ [0x0e] Comparator 1 output selector This bit is controlled by software (if not locked). It selects the comparator 1 output:
    $0f constant COMP1_POLARITY                 \ [0x0f] Comparator 1 polarity selector This bit is controlled by software (if not locked). It selects the comparator 1 output polarity:
    $10 constant COMP1_HYST                     \ [0x10 : 2] Comparator 1 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 1:
    $12 constant COMP1_PWRMODE                  \ [0x12 : 2] Comparator 1 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 1:
    $14 constant COMP1_BLANKSEL                 \ [0x14 : 5] Comparator 1 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: Others: Reserved, must not be used
    $1e constant COMP1_VALUE                    \ [0x1e] Comparator 1 output status This bit is read-only. It reflects the level of the comparator 1 output after the polarity selector and blanking, as indicated in Figure163.
    $1f constant COMP1_LOCK                     \ [0x1f] COMP_CSR register lock This bit is set by software and cleared by a system reset. It locks the comparator 3 control bits. When locked, all register bits are read-only.
  [then]


  [ifdef] COMP1_COMP2_CSR_DEF
    \
    \ @brief Comparator 2 control and status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant COMP1_EN                       \ [0x00] Comparator 2 enable bit This bit is controlled by software (if not locked). It enables the comparator 2:
    $04 constant COMP1_INMSEL                   \ [0x04 : 4] Comparator 2 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP_INM of the comparator 2: Refer to Table178: COMP2 inverting input assignment.
    $08 constant COMP1_INPSEL                   \ [0x08 : 2] Comparator 2 signal selector for noninverting input This bitfield is controlled by software (if not locked). It selects the signal for the noninverting input COMP_INP of the comparator 2 (also see the WINMODE bit): Refer to Table177: COMP2 noninverting input assignment.
    $0b constant COMP1_WINMODE                  \ [0x0b] Comparator 2 noninverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP_INP input of the comparator 2:
    $0e constant COMP1_WINOUT                   \ [0x0e] Comparator 2 output selector This bit is controlled by software (if not locked). It selects the comparator 2 output:
    $0f constant COMP1_POLARITY                 \ [0x0f] Comparator 2 polarity selector This bit is controlled by software (if not locked). It selects the comparator 2 output polarity:
    $10 constant COMP1_HYST                     \ [0x10 : 2] Comparator 2 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 2:
    $12 constant COMP1_PWRMODE                  \ [0x12 : 2] Comparator 2 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 2:
    $14 constant COMP1_BLANKSEL                 \ [0x14 : 5] Comparator 2 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: Others: Reserved, must not be used
    $1e constant COMP1_VALUE                    \ [0x1e] Comparator 2 output status This bit is read-only. It reflects the level of the comparator 2 output after the polarity selector and blanking, as indicated in Figure163.
    $1f constant COMP1_LOCK                     \ [0x1f] COMP_CSR register lock This bit is set by software and cleared by a system reset. It locks the comparator 3 control bits. When locked, all register bits are read-only.
  [then]

  \
  \ @brief COMP address block description
  \
  $00 constant COMP1_COMP1_CSR          \ Comparator 1 control and status register
  $04 constant COMP1_COMP2_CSR          \ Comparator 2 control and status register

: COMP1_DEF ; [then]
