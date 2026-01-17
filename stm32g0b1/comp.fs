\
\ @file comp.fs
\ @brief Comparator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP_DEF

  [ifdef] COMP_COMP1_CSR_DEF
    \
    \ @brief Comparator 1 control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] Comparator 1 enable bit This bit is controlled by software (if not locked). It enables the comparator 1:
    $04 constant COMP_INMSEL                    \ [0x04 : 4] Comparator 1 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP1_INM of the comparator 1: > 1000: 1/4 VREFINT
    $08 constant COMP_INPSEL                    \ [0x08 : 2] Comparator 1 signal selector for non-inverting input This bitfield is controlled by software (if not locked). It selects the signal for the non-inverting input COMP1_INP of the comparator 1 (also see the WINMODE bit):
    $0b constant COMP_WINMODE                   \ [0x0b] Comparator 1 non-inverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP1_INP input of the comparator 1:
    $0e constant COMP_WINOUT                    \ [0x0e] Comparator 1 output selector This bit is controlled by software (if not locked). It selects the comparator 1 output:
    $0f constant COMP_POLARITY                  \ [0x0f] Comparator 1 polarity selector This bit is controlled by software (if not locked). It selects the comparator 1 output polarity:
    $10 constant COMP_HYST                      \ [0x10 : 2] Comparator 1 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 1:
    $12 constant COMP_PWRMODE                   \ [0x12 : 2] Comparator 1 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 1: others: Reserved
    $14 constant COMP_BLANKSEL                  \ [0x14 : 5] Comparator 1 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: xxxx1: TIM1 OC4 xxx1x: TIM1 OC5 xx1xx: TIM2 OC3 x1xxx: TIM3 OC3 1xxxx: TIM15 OC2
    $1e constant COMP_VALUE                     \ [0x1e] Comparator 1 output status This bit is read-only. It reflects the level of the comparator 1 output after the polarity selector and blanking, as indicated in .
    $1f constant COMP_LOCK                      \ [0x1f] COMP1_CSR register lock This bit is set by software and cleared by a system reset. It locks the whole content of the comparator 1 control register COMP1_CSR[31:0]:
  [then]


  [ifdef] COMP_COMP2_CSR_DEF
    \
    \ @brief Comparator 2 control and status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] Comparator 2 enable bit This bit is controlled by software (if not locked). It enables the comparator 2:
    $04 constant COMP_INMSEL                    \ [0x04 : 4] Comparator 2 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP2_INM of the comparator 2: > 1000: 1/4 VREFINT
    $08 constant COMP_INPSEL                    \ [0x08 : 2] Comparator 2 signal selector for non-inverting input This bitfield is controlled by software (if not locked). It selects the signal for the non-inverting input COMP2_INP of the comparator 2 (also see the WINMODE bit):
    $0b constant COMP_WINMODE                   \ [0x0b] Comparator 2 non-inverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP2_INP input of the comparator 2:
    $0e constant COMP_WINOUT                    \ [0x0e] Comparator 2 output selector This bit is controlled by software (if not locked). It selects the comparator 2 output:
    $0f constant COMP_POLARITY                  \ [0x0f] Comparator 2 polarity selector This bit is controlled by software (if not locked). It selects the comparator 2 output polarity:
    $10 constant COMP_HYST                      \ [0x10 : 2] Comparator 2 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 2:
    $12 constant COMP_PWRMODE                   \ [0x12 : 2] Comparator 2 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 2: others: Reserved
    $14 constant COMP_BLANKSEL                  \ [0x14 : 5] Comparator 2 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: xxxx1: TIM1 OC4 xxx1x: TIM1 OC5 xx1xx: TIM2 OC3 x1xxx: TIM3 OC3 1xxxx: TIM15 OC2
    $1e constant COMP_VALUE                     \ [0x1e] Comparator 2 output status This bit is read-only. It reflects the level of the comparator 2 output after the polarity selector and blanking, as indicated in .
    $1f constant COMP_LOCK                      \ [0x1f] COMP2_CSR register lock This bit is set by software and cleared by a system reset. It locks the whole content of the comparator 2 control register COMP2_CSR[31:0]:
  [then]


  [ifdef] COMP_COMP3_CSR_DEF
    \
    \ @brief Comparator 2 control and status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] Comparator 3 enable bit This bit is controlled by software (if not locked). It enables the comparator 3:
    $04 constant COMP_INMSEL                    \ [0x04 : 4] Comparator 3 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP3_INM of the comparator 3: > 1000: 1/4 VREFINT
    $08 constant COMP_INPSEL                    \ [0x08 : 2] Comparator 3 signal selector for non-inverting input This bitfield is controlled by software (if not locked). It selects the signal for the non-inverting input COMP3_INP of the comparator 3 (also see the WINMODE bit):
    $0b constant COMP_WINMODE                   \ [0x0b] Comparator 3 non-inverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP3_INP input of the comparator 3:
    $0e constant COMP_WINOUT                    \ [0x0e] Comparator 3 output selector This bit is controlled by software (if not locked). It selects the comparator 3 output:
    $0f constant COMP_POLARITY                  \ [0x0f] Comparator 2 polarity selector This bit is controlled by software (if not locked). It selects the comparator 3 output polarity:
    $10 constant COMP_HYST                      \ [0x10 : 2] Comparator 3 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 3:
    $12 constant COMP_PWRMODE                   \ [0x12 : 2] Comparator 3 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 3: others: Reserved
    $14 constant COMP_BLANKSEL                  \ [0x14 : 5] Comparator 3 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: xxxx1: TIM1 OC4 xxx1x: TIM1 OC5 xx1xx: TIM2 OC3 x1xxx: TIM3 OC3 1xxxx: TIM15 OC2
    $1e constant COMP_VALUE                     \ [0x1e] Comparator 3 output status This bit is read-only. It reflects the level of the comparator 2 output after the polarity selector and blanking, as indicated in .
    $1f constant COMP_LOCK                      \ [0x1f] COMP3_CSR register lock This bit is set by software and cleared by a system reset. It locks the whole content of the comparator 3 control register COMP3_CSR[31:0]:
  [then]

  \
  \ @brief Comparator
  \
  $00 constant COMP_COMP1_CSR           \ Comparator 1 control and status register
  $04 constant COMP_COMP2_CSR           \ Comparator 2 control and status register
  $08 constant COMP_COMP3_CSR           \ Comparator 2 control and status register

: COMP_DEF ; [then]
