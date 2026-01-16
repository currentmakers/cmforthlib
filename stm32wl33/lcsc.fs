\
\ @file lcsc.fs
\ @brief LCSC interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LCSC_CR0 register
\ Address offset: 0x00
\ Reset value: 0x000B005C
\

$00003fff constant LCSC_LCSC_CR0_TMEAS                              \ Measurement Time
$003f0000 constant LCSC_LCSC_CR0_TCAP                               \ Capture Time
$07000000 constant LCSC_LCSC_CR0_TICAP                              \ Inter Capture Time


\
\ @brief LCSC_CR1 register
\ Address offset: 0x04
\ Reset value: 0x3C010C80
\

$000000ff constant LCSC_LCSC_CR1_LCAB_DAMP_THRES                    \ LCAB_DAMP_THRES[7:0]: Damping threshold for LCA and LCB
$0007fc00 constant LCSC_LCSC_CR1_TREC_VCM                           \ VCMBUFF Recovery Time
$7ff00000 constant LCSC_LCSC_CR1_TSTART_VCM                         \ VCMBUFF Starting Time


\
\ @brief LCSC_CR2 register
\ Address offset: 0x08
\ Reset value: 0x00008000
\

$000000ff constant LCSC_LCSC_CR2_TAMP_PSC                           \ Tamper measurement interval.
$0000ff00 constant LCSC_LCSC_CR2_LCT_DAMP_THRES                     \ Damping threshold for LCT


\
\ @brief LCSC_PULSE_CR register
\ Address offset: 0x0C
\ Reset value: 0x00000070
\

$0000000f constant LCSC_LCSC_PULSE_CR_LCAB_PULSE_WIDTH              \ Low Pulse Width for LCA and LCB
$00000f00 constant LCSC_LCSC_PULSE_CR_LCT_PULSE_WIDTH               \ Low Pulse Width for LCT


\
\ @brief LCSC_ENR register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LCSC_LCSC_ENR_CLKWISE_IE                         \ Clock Wise Interrupt and Wakeup Enable
$00000002 constant LCSC_LCSC_ENR_ACLKWISE_IE                        \ Anti Clock Wise Interrupt and Wakeup Enable
$00000004 constant LCSC_LCSC_ENR_TAMP_IE                            \ Tamper Interrupt and Wakeup Enable
$00000008 constant LCSC_LCSC_ENR_CNT_OFB_WKP_IE                     \ LCAB Counter Out Of Bound wakeup enable
$80000000 constant LCSC_LCSC_ENR_LCSC_EN                            \ LCSC Enable


\
\ @brief LCSC_WHEEL_SR register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LCSC_LCSC_WHEEL_SR_CLKWISE                       \ Number of Clock Wise revolutions
$ffff0000 constant LCSC_LCSC_WHEEL_SR_ACLKWISE                      \ Number of Anti Clock Wise revolutions


\
\ @brief LCSC_CONFR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant LCSC_LCSC_CONFR_CLKWISE_THRES                    \ Number of Clock Wise revolutions target
$ffff0000 constant LCSC_LCSC_CONFR_ACLKWISE_THRES                   \ Number of Anti Clock Wise revolutions target


\
\ @brief LCSC_COMP_CTN register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant LCSC_LCSC_COMP_CTN_CMP_LCA_CNT                   \ LCA Comparator last damping count
$0003fc00 constant LCSC_LCSC_COMP_CTN_CMP_LCB_CNT                   \ LCB Comparator last damping count
$0ff00000 constant LCSC_LCSC_COMP_CTN_CMP_LCT_CNT                   \ LCT Comparator last damping count


\
\ @brief LCSC_SR register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant LCSC_LCSC_SR_CLKWISE_STATE                       \ The current state of the LCSC clockwise FSM:
$0000000c constant LCSC_LCSC_SR_ACLKWISE_STATE                      \ The current state of the LCSC anti clockwise FSM:
$00000030 constant LCSC_LCSC_SR_LAST_DIR                            \ The last direction detected:


\
\ @brief LCSC_STAT register
\ Address offset: 0x24
\ Reset value: 0xFF0000FF
\

$000000ff constant LCSC_LCSC_STAT_MIN_LCAB_CNT                      \ The Minimum of CMP_LCA_CNT, CMP_LCB_CNT reached during the
$0000ff00 constant LCSC_LCSC_STAT_MAX_LCAB_CNT                      \ The Maximum of CMP_LCA_CNT, CMP_LCB_CNT reached during
$00ff0000 constant LCSC_LCSC_STAT_MIN_LCAB_CNT_BOUND                \ The Minimum bound of CMP_LCA_COUNT,
$ff000000 constant LCSC_LCSC_STAT_MAX_LCAB_CNT_BOUND                \ The Maximum bound of CMP_LCA_COUNT,


\
\ @brief LCSC Test Configuration Register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant LCSC_LCSC_TST_CFG_TST_EN                         \ Test Enable
$0000000e constant LCSC_LCSC_TST_CFG_TST_CFG                        \ DTB output selection


\
\ @brief LCSC ANA Test Configuration Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant LCSC_LCSC_ANATST_CFG_VCMBUFF_ENOUT_SEL           \ Selection of the signal to be used to supply the DAC in the LCSC
$00000002 constant LCSC_LCSC_ANATST_CFG_VCMBUFF_ENOUT               \ VCMBUFFER output buffer enable pin
$00000004 constant LCSC_LCSC_ANATST_CFG_VCMBUFF_PWDN_SEL            \ Selection of the signal to be used to supply the DAC in the LCSC
$00000008 constant LCSC_LCSC_ANATST_CFG_VCMBUFF_PWDN                \ VCMBUFF power-down pin
$00000010 constant LCSC_LCSC_ANATST_CFG_COMP_PWDN_SEL               \ Selection of the signal to be used to supply the COMP in the LCSC Analog part
$00000020 constant LCSC_LCSC_ANATST_CFG_COMP_PWDN                   \ COMP power-down pin
$00000040 constant LCSC_LCSC_ANATST_CFG_DAC_PWDN_SEL                \ Selection of the signal to be used to supply the DAC in the LCSC Analog part
$00000080 constant LCSC_LCSC_ANATST_CFG_DAC_PWDN                    \ DAC power-down pin


\
\ @brief LCSC_VER register
\ Address offset: 0x40
\ Reset value: 0x00001000
\

$000000f0 constant LCSC_LCSC_VER_REV                                \ Revision of the RFIP to be used for metal fixes)
$00000f00 constant LCSC_LCSC_VER_VER                                \ Version of the RFIP (to be used for cut upgrades)
$0000f000 constant LCSC_LCSC_VER_PROD                               \ Used for major upgrades (new protocols support / new features)


\
\ @brief LCSC_ISR register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant LCSC_LCSC_ISR_CLKWISE_F                          \ Clock Wise Flag:
$00000002 constant LCSC_LCSC_ISR_ACLKWISE_F                         \ Anti Clock Wise Flag:
$00000004 constant LCSC_LCSC_ISR_TAMP_F                             \ Tamper Flag
$00000008 constant LCSC_LCSC_ISR_CNT_OFB_F                          \ Out of Bound Counter Flag


\
\ @brief LCSC interrupt
\
$4000a000 constant LCSC_LCSC_CR0  \ offset: 0x00 : LCSC_CR0 register
$4000a004 constant LCSC_LCSC_CR1  \ offset: 0x04 : LCSC_CR1 register
$4000a008 constant LCSC_LCSC_CR2  \ offset: 0x08 : LCSC_CR2 register
$4000a00c constant LCSC_LCSC_PULSE_CR  \ offset: 0x0C : LCSC_PULSE_CR register
$4000a010 constant LCSC_LCSC_ENR  \ offset: 0x10 : LCSC_ENR register
$4000a014 constant LCSC_LCSC_WHEEL_SR  \ offset: 0x14 : LCSC_WHEEL_SR register
$4000a018 constant LCSC_LCSC_CONFR  \ offset: 0x18 : LCSC_CONFR register
$4000a01c constant LCSC_LCSC_COMP_CTN  \ offset: 0x1C : LCSC_COMP_CTN register
$4000a020 constant LCSC_LCSC_SR   \ offset: 0x20 : LCSC_SR register
$4000a024 constant LCSC_LCSC_STAT  \ offset: 0x24 : LCSC_STAT register
$4000a028 constant LCSC_LCSC_TST_CFG  \ offset: 0x28 : LCSC Test Configuration Register
$4000a02c constant LCSC_LCSC_ANATST_CFG  \ offset: 0x2C : LCSC ANA Test Configuration Register
$4000a040 constant LCSC_LCSC_VER  \ offset: 0x40 : LCSC_VER register
$4000a044 constant LCSC_LCSC_ISR  \ offset: 0x44 : LCSC_ISR register

