\
\ @file comp.fs
\ @brief Comparator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP_DEF

  [ifdef] COMP_COMP_SR_DEF
    \
    \ @brief Comparator status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP_C1VAL                     \ [0x00] COMP Channel1 output status bit This bit is read-only. It reflects the current COMP Channel1 output taking into account POLARITY and BLANKING bits effect.
    $10 constant COMP_C1IF                      \ [0x10] COMP Channel1 interrupt flag This bit is set by hardware when the COMP Channel1 output is set This bit is cleared by software writing 1 the CC1IF bit in the COMP_ICFR register.
  [then]


  [ifdef] COMP_COMP_ICFR_DEF
    \
    \ @brief Comparator interrupt clear flag register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $10 constant COMP_CC1IF                     \ [0x10] Clear COMP Channel1 interrupt flag Writing 1 clears the C1IF flag in the COMP_SR register.
  [then]


  [ifdef] COMP_COMP_CFGR1_DEF
    \
    \ @brief Comparator configuration register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] COMP Channel1 enable This bit is set and cleared by software (only if LOCK not set). It enables the COMP Channel1.
    $01 constant COMP_BRGEN                     \ [0x01] Scaler bridge enable This bit is set and cleared by software (only if LOCK not set). This bit enables the bridge of the scaler. If SCALEN is set and BRGEN is reset, all four scaler outputs provide the same level V REF_COMP (similar to V REFINT ). If SCALEN and BRGEN are set, the four scaler outputs provide V REF_COMP , 3/4 V REF_COMP , 1/2 V REF_COMP and 1/4 V REF_COMP levels, respectively.
    $02 constant COMP_SCALEN                    \ [0x02] Voltage scaler enable This bit is set and cleared by software (only if LOCK not set). This bit enables the V REFINT scaler for the COMP channels.
    $03 constant COMP_POLARITY                  \ [0x03] COMP channel1 polarity selection This bit is set and cleared by software (only if LOCK not set). It inverts COMP channel1 polarity.
    $06 constant COMP_ITEN                      \ [0x06] COMP channel1 interrupt enable This bit is set and cleared by software (only if LOCK not set). This bit enable the interrupt generation of the COMP channel1.
    $08 constant COMP_HYST                      \ [0x08 : 2] COMP channel1 hysteresis selection These bits are set and cleared by software (only if LOCK not set). They select the hysteresis voltage of the COMP channel1.
    $0c constant COMP_PWRMODE                   \ [0x0c : 2] Power mode of the COMP channel1 These bits are set and cleared by software (only if LOCK not set). They control the power/speed of the COMP channel1.
    $10 constant COMP_INMSEL                    \ [0x10 : 4] COMP channel1 inverting input selection These bits are set and cleared by software (only if LOCK not set). They select which input is connected to the input minus of the COMP channel. Note: See Table 146: COMP1 inverting input assignment for more details.
    $14 constant COMP_INPSEL1                   \ [0x14] COMP noninverting input selection This bit is set and cleared by software (only if LOCK not set). They select which input is connected to the positive input of COMP channel. Note: See Table 145: COMP1 noninverting input assignment for more details.
    $16 constant COMP_INPSEL2                   \ [0x16] COMP noninverting input selection This bit is set and cleared by software (only if LOCK not set). They select which input is connected to the positive input of the COMP channel. See Table 145: COMP1 noninverting input assignment for more details.
    $18 constant COMP_BLANKING                  \ [0x18 : 4] COMP Channel1 blanking source selection Bits of this field are set and cleared by software (only if LOCK not set). The field selects the input source for COMP Channel1 output blanking: All other values: reserved
    $1f constant COMP_LOCK                      \ [0x1f] Lock This bit is set by software and cleared by a hardware system reset. It locks the whole content of the COMP Channel1 configuration register COMP_CFGR1[31:0]
  [then]


  [ifdef] COMP_COMP_CFGR2_DEF
    \
    \ @brief Comparator configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant COMP_INPSEL0                   \ [0x04] COMP non-inverting input selection This bit is set and cleared by software (only if LOCK not set). They select which input is connected to the positive input of COMP channel. See Table 145: COMP1 noninverting input assignment for more details.
    $1f constant COMP_LOCK                      \ [0x1f] Lock This bit is set by software and cleared by a hardware system reset. It locks the whole content of the COMP Channel1 configuration register COMP_CFGR2[31:0]
  [then]

  \
  \ @brief Comparator
  \
  $00 constant COMP_COMP_SR             \ Comparator status register
  $04 constant COMP_COMP_ICFR           \ Comparator interrupt clear flag register
  $0C constant COMP_COMP_CFGR1          \ Comparator configuration register 1
  $10 constant COMP_COMP_CFGR2          \ Comparator configuration register 2

: COMP_DEF ; [then]
