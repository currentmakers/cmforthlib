\
\ @file comp.fs
\ @brief Comparator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Comparator status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP_SR_C1VAL                               \ COMP Channel1 output status bit This bit is read-only. It reflects the current COMP Channel1 output taking into account POLARITY and BLANKING bits effect.
$00010000 constant COMP_COMP_SR_C1IF                                \ COMP Channel1 interrupt flag This bit is set by hardware when the COMP Channel1 output is set This bit is cleared by software writing 1 the CC1IF bit in the COMP_ICFR register.


\
\ @brief Comparator interrupt clear flag register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00010000 constant COMP_COMP_ICFR_CC1IF                             \ Clear COMP Channel1 interrupt flag Writing 1 clears the C1IF flag in the COMP_SR register.


\
\ @brief Comparator configuration register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant COMP_COMP_CFGR1_EN                               \ COMP Channel1 enable This bit is set and cleared by software (only if LOCK not set). It enables the COMP Channel1.
$00000002 constant COMP_COMP_CFGR1_BRGEN                            \ Scaler bridge enable This bit is set and cleared by software (only if LOCK not set). This bit enables the bridge of the scaler. If SCALEN is set and BRGEN is reset, all four scaler outputs provide the same level V REF_COMP (similar to V REFINT ). If SCALEN and BRGEN are set, the four scaler outputs provide V REF_COMP , 3/4 V REF_COMP , 1/2 V REF_COMP and 1/4 V REF_COMP levels, respectively.
$00000004 constant COMP_COMP_CFGR1_SCALEN                           \ Voltage scaler enable This bit is set and cleared by software (only if LOCK not set). This bit enables the V REFINT scaler for the COMP channels.
$00000008 constant COMP_COMP_CFGR1_POLARITY                         \ COMP channel1 polarity selection This bit is set and cleared by software (only if LOCK not set). It inverts COMP channel1 polarity.
$00000040 constant COMP_COMP_CFGR1_ITEN                             \ COMP channel1 interrupt enable This bit is set and cleared by software (only if LOCK not set). This bit enable the interrupt generation of the COMP channel1.
$00000300 constant COMP_COMP_CFGR1_HYST                             \ COMP channel1 hysteresis selection These bits are set and cleared by software (only if LOCK not set). They select the hysteresis voltage of the COMP channel1.
$00003000 constant COMP_COMP_CFGR1_PWRMODE                          \ Power mode of the COMP channel1 These bits are set and cleared by software (only if LOCK not set). They control the power/speed of the COMP channel1.
$000f0000 constant COMP_COMP_CFGR1_INMSEL                           \ COMP channel1 inverting input selection These bits are set and cleared by software (only if LOCK not set). They select which input is connected to the input minus of the COMP channel. Note: See Table 146: COMP1 inverting input assignment for more details.
$00100000 constant COMP_COMP_CFGR1_INPSEL1                          \ COMP noninverting input selection This bit is set and cleared by software (only if LOCK not set). They select which input is connected to the positive input of COMP channel. Note: See Table 145: COMP1 noninverting input assignment for more details.
$00400000 constant COMP_COMP_CFGR1_INPSEL2                          \ COMP noninverting input selection This bit is set and cleared by software (only if LOCK not set). They select which input is connected to the positive input of the COMP channel. See Table 145: COMP1 noninverting input assignment for more details.
$0f000000 constant COMP_COMP_CFGR1_BLANKING                         \ COMP Channel1 blanking source selection Bits of this field are set and cleared by software (only if LOCK not set). The field selects the input source for COMP Channel1 output blanking: All other values: reserved
$80000000 constant COMP_COMP_CFGR1_LOCK                             \ Lock This bit is set by software and cleared by a hardware system reset. It locks the whole content of the COMP Channel1 configuration register COMP_CFGR1[31:0]


\
\ @brief Comparator configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000010 constant COMP_COMP_CFGR2_INPSEL0                          \ COMP non-inverting input selection This bit is set and cleared by software (only if LOCK not set). They select which input is connected to the positive input of COMP channel. See Table 145: COMP1 noninverting input assignment for more details.
$80000000 constant COMP_COMP_CFGR2_LOCK                             \ Lock This bit is set by software and cleared by a hardware system reset. It locks the whole content of the COMP Channel1 configuration register COMP_CFGR2[31:0]


\
\ @brief Comparator
\
$40004000 constant COMP_COMP_SR   \ offset: 0x00 : Comparator status register
$40004004 constant COMP_COMP_ICFR  \ offset: 0x04 : Comparator interrupt clear flag register
$4000400c constant COMP_COMP_CFGR1  \ offset: 0x0C : Comparator configuration register 1
$40004010 constant COMP_COMP_CFGR2  \ offset: 0x10 : Comparator configuration register 2

