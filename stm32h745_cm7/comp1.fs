\
\ @file comp1.fs
\ @brief COMP1
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

$00000001 constant COMP1_SR_C1VAL                                   \ COMP channel 1 output status bit
$00000002 constant COMP1_SR_C2VAL                                   \ COMP channel 2 output status bit
$00010000 constant COMP1_SR_C1IF                                    \ COMP channel 1 Interrupt Flag
$00020000 constant COMP1_SR_C2IF                                    \ COMP channel 2 Interrupt Flag


\
\ @brief Comparator interrupt clear flag register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00010000 constant COMP1_ICFR_CC1IF                                 \ Clear COMP channel 1 Interrupt Flag
$00020000 constant COMP1_ICFR_CC2IF                                 \ Clear COMP channel 2 Interrupt Flag


\
\ @brief Comparator option register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000007ff constant COMP1_OR_AFOP                                    \ Selection of source for alternate function of output ports
$fffff800 constant COMP1_OR_OR                                      \ Option Register


\
\ @brief Comparator configuration register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant COMP1_CFGR1_EN                                   \ COMP channel 1 enable bit
$00000002 constant COMP1_CFGR1_BRGEN                                \ Scaler bridge enable
$00000004 constant COMP1_CFGR1_SCALEN                               \ Voltage scaler enable bit
$00000008 constant COMP1_CFGR1_POLARITY                             \ COMP channel 1 polarity selection bit
$00000040 constant COMP1_CFGR1_ITEN                                 \ COMP channel 1 interrupt enable
$00000300 constant COMP1_CFGR1_HYST                                 \ COMP channel 1 hysteresis selection bits
$00003000 constant COMP1_CFGR1_PWRMODE                              \ Power Mode of the COMP channel 1
$00070000 constant COMP1_CFGR1_INMSEL                               \ COMP channel 1 inverting input selection field
$00100000 constant COMP1_CFGR1_INPSEL                               \ COMP channel 1 non-inverting input selection bit
$0f000000 constant COMP1_CFGR1_BLANKING                             \ COMP channel 1 blanking source selection bits
$80000000 constant COMP1_CFGR1_LOCK                                 \ Lock bit


\
\ @brief Comparator configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant COMP1_CFGR2_EN                                   \ COMP channel 1 enable bit
$00000002 constant COMP1_CFGR2_BRGEN                                \ Scaler bridge enable
$00000004 constant COMP1_CFGR2_SCALEN                               \ Voltage scaler enable bit
$00000008 constant COMP1_CFGR2_POLARITY                             \ COMP channel 1 polarity selection bit
$00000010 constant COMP1_CFGR2_WINMODE                              \ Window comparator mode selection bit
$00000040 constant COMP1_CFGR2_ITEN                                 \ COMP channel 1 interrupt enable
$00000300 constant COMP1_CFGR2_HYST                                 \ COMP channel 1 hysteresis selection bits
$00003000 constant COMP1_CFGR2_PWRMODE                              \ Power Mode of the COMP channel 1
$00070000 constant COMP1_CFGR2_INMSEL                               \ COMP channel 1 inverting input selection field
$00100000 constant COMP1_CFGR2_INPSEL                               \ COMP channel 1 non-inverting input selection bit
$0f000000 constant COMP1_CFGR2_BLANKING                             \ COMP channel 1 blanking source selection bits
$80000000 constant COMP1_CFGR2_LOCK                                 \ Lock bit


\
\ @brief COMP1
\
$58003800 constant COMP1_SR       \ offset: 0x00 : Comparator status register
$58003804 constant COMP1_ICFR     \ offset: 0x04 : Comparator interrupt clear flag register
$58003808 constant COMP1_OR       \ offset: 0x08 : Comparator option register
$5800380c constant COMP1_CFGR1    \ offset: 0x0C : Comparator configuration register 1
$58003810 constant COMP1_CFGR2    \ offset: 0x10 : Comparator configuration register 2

