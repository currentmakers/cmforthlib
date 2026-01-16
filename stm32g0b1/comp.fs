\
\ @file comp.fs
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

$00000001 constant COMP_COMP1_CSR_EN                                \ Comparator 1 enable bit This bit is controlled by software (if not locked). It enables the comparator 1:
$000000f0 constant COMP_COMP1_CSR_INMSEL                            \ Comparator 1 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP1_INM of the comparator 1: > 1000: 1/4 VREFINT
$00000300 constant COMP_COMP1_CSR_INPSEL                            \ Comparator 1 signal selector for non-inverting input This bitfield is controlled by software (if not locked). It selects the signal for the non-inverting input COMP1_INP of the comparator 1 (also see the WINMODE bit):
$00000800 constant COMP_COMP1_CSR_WINMODE                           \ Comparator 1 non-inverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP1_INP input of the comparator 1:
$00004000 constant COMP_COMP1_CSR_WINOUT                            \ Comparator 1 output selector This bit is controlled by software (if not locked). It selects the comparator 1 output:
$00008000 constant COMP_COMP1_CSR_POLARITY                          \ Comparator 1 polarity selector This bit is controlled by software (if not locked). It selects the comparator 1 output polarity:
$00030000 constant COMP_COMP1_CSR_HYST                              \ Comparator 1 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 1:
$000c0000 constant COMP_COMP1_CSR_PWRMODE                           \ Comparator 1 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 1: others: Reserved
$01f00000 constant COMP_COMP1_CSR_BLANKSEL                          \ Comparator 1 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: xxxx1: TIM1 OC4 xxx1x: TIM1 OC5 xx1xx: TIM2 OC3 x1xxx: TIM3 OC3 1xxxx: TIM15 OC2
$40000000 constant COMP_COMP1_CSR_VALUE                             \ Comparator 1 output status This bit is read-only. It reflects the level of the comparator 1 output after the polarity selector and blanking, as indicated in .
$80000000 constant COMP_COMP1_CSR_LOCK                              \ COMP1_CSR register lock This bit is set by software and cleared by a system reset. It locks the whole content of the comparator 1 control register COMP1_CSR[31:0]:


\
\ @brief Comparator 2 control and status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP2_CSR_EN                                \ Comparator 2 enable bit This bit is controlled by software (if not locked). It enables the comparator 2:
$000000f0 constant COMP_COMP2_CSR_INMSEL                            \ Comparator 2 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP2_INM of the comparator 2: > 1000: 1/4 VREFINT
$00000300 constant COMP_COMP2_CSR_INPSEL                            \ Comparator 2 signal selector for non-inverting input This bitfield is controlled by software (if not locked). It selects the signal for the non-inverting input COMP2_INP of the comparator 2 (also see the WINMODE bit):
$00000800 constant COMP_COMP2_CSR_WINMODE                           \ Comparator 2 non-inverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP2_INP input of the comparator 2:
$00004000 constant COMP_COMP2_CSR_WINOUT                            \ Comparator 2 output selector This bit is controlled by software (if not locked). It selects the comparator 2 output:
$00008000 constant COMP_COMP2_CSR_POLARITY                          \ Comparator 2 polarity selector This bit is controlled by software (if not locked). It selects the comparator 2 output polarity:
$00030000 constant COMP_COMP2_CSR_HYST                              \ Comparator 2 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 2:
$000c0000 constant COMP_COMP2_CSR_PWRMODE                           \ Comparator 2 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 2: others: Reserved
$01f00000 constant COMP_COMP2_CSR_BLANKSEL                          \ Comparator 2 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: xxxx1: TIM1 OC4 xxx1x: TIM1 OC5 xx1xx: TIM2 OC3 x1xxx: TIM3 OC3 1xxxx: TIM15 OC2
$40000000 constant COMP_COMP2_CSR_VALUE                             \ Comparator 2 output status This bit is read-only. It reflects the level of the comparator 2 output after the polarity selector and blanking, as indicated in .
$80000000 constant COMP_COMP2_CSR_LOCK                              \ COMP2_CSR register lock This bit is set by software and cleared by a system reset. It locks the whole content of the comparator 2 control register COMP2_CSR[31:0]:


\
\ @brief Comparator 2 control and status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP3_CSR_EN                                \ Comparator 3 enable bit This bit is controlled by software (if not locked). It enables the comparator 3:
$000000f0 constant COMP_COMP3_CSR_INMSEL                            \ Comparator 3 signal selector for inverting input INM This bitfield is controlled by software (if not locked). It selects the signal for the inverting input COMP3_INM of the comparator 3: > 1000: 1/4 VREFINT
$00000300 constant COMP_COMP3_CSR_INPSEL                            \ Comparator 3 signal selector for non-inverting input This bitfield is controlled by software (if not locked). It selects the signal for the non-inverting input COMP3_INP of the comparator 3 (also see the WINMODE bit):
$00000800 constant COMP_COMP3_CSR_WINMODE                           \ Comparator 3 non-inverting input selector for window mode This bit is controlled by software (if not locked). It selects the signal for COMP3_INP input of the comparator 3:
$00004000 constant COMP_COMP3_CSR_WINOUT                            \ Comparator 3 output selector This bit is controlled by software (if not locked). It selects the comparator 3 output:
$00008000 constant COMP_COMP3_CSR_POLARITY                          \ Comparator 2 polarity selector This bit is controlled by software (if not locked). It selects the comparator 3 output polarity:
$00030000 constant COMP_COMP3_CSR_HYST                              \ Comparator 3 hysteresis selector This bitfield is controlled by software (if not locked). It selects the hysteresis of the comparator 3:
$000c0000 constant COMP_COMP3_CSR_PWRMODE                           \ Comparator 3 power mode selector This bitfield is controlled by software (if not locked). It selects the power consumption and as a consequence the speed of the comparator 3: others: Reserved
$01f00000 constant COMP_COMP3_CSR_BLANKSEL                          \ Comparator 3 blanking source selector This bitfield is controlled by software (if not locked). It selects the blanking source: xxxx1: TIM1 OC4 xxx1x: TIM1 OC5 xx1xx: TIM2 OC3 x1xxx: TIM3 OC3 1xxxx: TIM15 OC2
$40000000 constant COMP_COMP3_CSR_VALUE                             \ Comparator 3 output status This bit is read-only. It reflects the level of the comparator 2 output after the polarity selector and blanking, as indicated in .
$80000000 constant COMP_COMP3_CSR_LOCK                              \ COMP3_CSR register lock This bit is set by software and cleared by a system reset. It locks the whole content of the comparator 3 control register COMP3_CSR[31:0]:


\
\ @brief Comparator
\
$40010200 constant COMP_COMP1_CSR  \ offset: 0x00 : Comparator 1 control and status register
$40010204 constant COMP_COMP2_CSR  \ offset: 0x04 : Comparator 2 control and status register
$40010208 constant COMP_COMP3_CSR  \ offset: 0x08 : Comparator 2 control and status register

