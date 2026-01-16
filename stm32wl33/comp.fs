\
\ @file comp.fs
\ @brief COMP address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CSR register
\ Address offset: 0x00
\ Reset value: 0x    NULL
\

$00000001 constant COMP_CSR_EN                                      \ EN: Comparator enable bit This bit is set and cleared by software (only if LOCK not set). It switches on Comparator. 0: Comparator switched OFF 1: Comparator switched ON
$0000000c constant COMP_CSR_PWRMODE                                 \ PWRMODE[1:0]: Power Mode of the comparator These bits are set and cleared by software (only if LOCK not set). They control the power/speed of the Comparator. 00:High speed 01 or 10:Medium speed 11:Ultra low power
$00000070 constant COMP_CSR_INMSEL                                  \ INMSEL: Comparator input minus selection bits These bits are set and cleared by software (only if LOCK not set). They select which input is connected to the input minus of comparator. 000: 1/4 VREFINT 001: 1/2 VREFINT 010: 3/4VREFINT 011: VREFINT 100: DAC OUT 101: PA13 110: PB0 111: PB3
$00000180 constant COMP_CSR_INPSEL                                  \ INPSEL[1:0]: Comparator input plus selection bit This bit is set and cleared by software (only if LOCK not set). 00: PA14 01: PB1 1x: PB2
$00008000 constant COMP_CSR_POLARITY                                \ POLARITY: Comparator polarity selection bit This bit is set and cleared by software (only if LOCK not set). It inverts Comparator polarity. 0: Comparator output value not inverted 1: Comparator output value inverted
$00030000 constant COMP_CSR_HYST                                    \ HYST[1:0]: Comparator hysteresis selection bits These bits are set and cleared by software (only if LOCK not set). They select the Hysteresis voltage of the comparator . 00: No hysteresis 01: Low hysteresis 10: Medium hysteresis 11: High hysteresis
$001c0000 constant COMP_CSR_BLANKING                                \ BLANKING[2:0]: Comparator blanking source selection bits These bits select which timer output controls the comparator output blanking. 000: No blanking 001: TIM2 OC4 selected as blanking source 010: TIM16 OC1 selected as blanking source All other values: reserved
$00400000 constant COMP_CSR_BRGEN                                   \ BRGEN: Scaler bridge enable This bit is set and cleared by software (only if LOCK not set). This bit enable the bridge of the scaler. 0: Scaler resistor bridge disable 1: Scaler resistor bridge enable If SCALEN is set and BRGEN is reset, BG voltage reference is available but not 1/4BGAP, 1/2BGAP, 3/4 BGAP. BGAP value is sent instead of 1/4BGAP, 1/2BGAP, 3/4 BGAP. If SCALEN and BRGEN are set, 1/4 BGAP 1/2BGAP 3/4BGAP and BGAP voltage references are available.
$00800000 constant COMP_CSR_SCALEN                                  \ SCALEN: Voltage scaler enable bit This bit is set and cleared by software. This bit enable the outputs of the VREFINT divider available on the minus input of the Comparator 0: scaler disable 1: scaler enable
$40000000 constant COMP_CSR_VALUE                                   \ VALUE: Comparator output status bit This bit is read-only. It reflects the current comparator output taking into account POLARITY bit effect.
$80000000 constant COMP_CSR_LOCK                                    \ LOCK: COMP_CSR register lock bit This bit is set by software and cleared by a hardware system reset. It locks the whole content of the comparator control register, COMP1_CSR[31:0]. 0: COMP1_CSR[31:0] are read/write 1: COMP1_CSR[31:0] are read-only


\
\ @brief COMP address block description
\
$40009000 constant COMP_CSR       \ offset: 0x00 : CSR register

