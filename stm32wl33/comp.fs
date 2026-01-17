\
\ @file comp.fs
\ @brief COMP address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP_DEF

  [ifdef] COMP_CSR_DEF
    \
    \ @brief CSR register
    \ Address offset: 0x00
    \ Reset value: 0x    NULL
    \
    $00 constant COMP_EN                        \ [0x00] EN: Comparator enable bit This bit is set and cleared by software (only if LOCK not set). It switches on Comparator. 0: Comparator switched OFF 1: Comparator switched ON
    $02 constant COMP_PWRMODE                   \ [0x02 : 2] PWRMODE[1:0]: Power Mode of the comparator These bits are set and cleared by software (only if LOCK not set). They control the power/speed of the Comparator. 00:High speed 01 or 10:Medium speed 11:Ultra low power
    $04 constant COMP_INMSEL                    \ [0x04 : 3] INMSEL: Comparator input minus selection bits These bits are set and cleared by software (only if LOCK not set). They select which input is connected to the input minus of comparator. 000: 1/4 VREFINT 001: 1/2 VREFINT 010: 3/4VREFINT 011: VREFINT 100: DAC OUT 101: PA13 110: PB0 111: PB3
    $07 constant COMP_INPSEL                    \ [0x07 : 2] INPSEL[1:0]: Comparator input plus selection bit This bit is set and cleared by software (only if LOCK not set). 00: PA14 01: PB1 1x: PB2
    $0f constant COMP_POLARITY                  \ [0x0f] POLARITY: Comparator polarity selection bit This bit is set and cleared by software (only if LOCK not set). It inverts Comparator polarity. 0: Comparator output value not inverted 1: Comparator output value inverted
    $10 constant COMP_HYST                      \ [0x10 : 2] HYST[1:0]: Comparator hysteresis selection bits These bits are set and cleared by software (only if LOCK not set). They select the Hysteresis voltage of the comparator . 00: No hysteresis 01: Low hysteresis 10: Medium hysteresis 11: High hysteresis
    $12 constant COMP_BLANKING                  \ [0x12 : 3] BLANKING[2:0]: Comparator blanking source selection bits These bits select which timer output controls the comparator output blanking. 000: No blanking 001: TIM2 OC4 selected as blanking source 010: TIM16 OC1 selected as blanking source All other values: reserved
    $16 constant COMP_BRGEN                     \ [0x16] BRGEN: Scaler bridge enable This bit is set and cleared by software (only if LOCK not set). This bit enable the bridge of the scaler. 0: Scaler resistor bridge disable 1: Scaler resistor bridge enable If SCALEN is set and BRGEN is reset, BG voltage reference is available but not 1/4BGAP, 1/2BGAP, 3/4 BGAP. BGAP value is sent instead of 1/4BGAP, 1/2BGAP, 3/4 BGAP. If SCALEN and BRGEN are set, 1/4 BGAP 1/2BGAP 3/4BGAP and BGAP voltage references are available.
    $17 constant COMP_SCALEN                    \ [0x17] SCALEN: Voltage scaler enable bit This bit is set and cleared by software. This bit enable the outputs of the VREFINT divider available on the minus input of the Comparator 0: scaler disable 1: scaler enable
    $1e constant COMP_VALUE                     \ [0x1e] VALUE: Comparator output status bit This bit is read-only. It reflects the current comparator output taking into account POLARITY bit effect.
    $1f constant COMP_LOCK                      \ [0x1f] LOCK: COMP_CSR register lock bit This bit is set by software and cleared by a hardware system reset. It locks the whole content of the comparator control register, COMP1_CSR[31:0]. 0: COMP1_CSR[31:0] are read/write 1: COMP1_CSR[31:0] are read-only
  [then]

  \
  \ @brief COMP address block description
  \
  $00 constant COMP_CSR                 \ CSR register

: COMP_DEF ; [then]
