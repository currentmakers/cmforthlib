\
\ @file lcsc.fs
\ @brief LCSC interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LCSC_DEF

  [ifdef] LCSC_LCSC_CR0_DEF
    \
    \ @brief LCSC_CR0 register
    \ Address offset: 0x00
    \ Reset value: 0x000B005C
    \
    $00 constant LCSC_TMEAS                     \ [0x00 : 14] Measurement Time
    $10 constant LCSC_TCAP                      \ [0x10 : 6] Capture Time
    $18 constant LCSC_TICAP                     \ [0x18 : 3] Inter Capture Time
  [then]


  [ifdef] LCSC_LCSC_CR1_DEF
    \
    \ @brief LCSC_CR1 register
    \ Address offset: 0x04
    \ Reset value: 0x3C010C80
    \
    $00 constant LCSC_LCAB_DAMP_THRES           \ [0x00 : 8] LCAB_DAMP_THRES[7:0]: Damping threshold for LCA and LCB
    $0a constant LCSC_TREC_VCM                  \ [0x0a : 9] VCMBUFF Recovery Time
    $14 constant LCSC_TSTART_VCM                \ [0x14 : 11] VCMBUFF Starting Time
  [then]


  [ifdef] LCSC_LCSC_CR2_DEF
    \
    \ @brief LCSC_CR2 register
    \ Address offset: 0x08
    \ Reset value: 0x00008000
    \
    $00 constant LCSC_TAMP_PSC                  \ [0x00 : 8] Tamper measurement interval.
    $08 constant LCSC_LCT_DAMP_THRES            \ [0x08 : 8] Damping threshold for LCT
  [then]


  [ifdef] LCSC_LCSC_PULSE_CR_DEF
    \
    \ @brief LCSC_PULSE_CR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000070
    \
    $00 constant LCSC_LCAB_PULSE_WIDTH          \ [0x00 : 4] Low Pulse Width for LCA and LCB
    $08 constant LCSC_LCT_PULSE_WIDTH           \ [0x08 : 4] Low Pulse Width for LCT
  [then]


  [ifdef] LCSC_LCSC_ENR_DEF
    \
    \ @brief LCSC_ENR register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LCSC_CLKWISE_IE                \ [0x00] Clock Wise Interrupt and Wakeup Enable
    $01 constant LCSC_ACLKWISE_IE               \ [0x01] Anti Clock Wise Interrupt and Wakeup Enable
    $02 constant LCSC_TAMP_IE                   \ [0x02] Tamper Interrupt and Wakeup Enable
    $03 constant LCSC_CNT_OFB_WKP_IE            \ [0x03] LCAB Counter Out Of Bound wakeup enable
    $1f constant LCSC_LCSC_EN                   \ [0x1f] LCSC Enable
  [then]


  [ifdef] LCSC_LCSC_WHEEL_SR_DEF
    \
    \ @brief LCSC_WHEEL_SR register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LCSC_CLKWISE                   \ [0x00 : 16] Number of Clock Wise revolutions
    $10 constant LCSC_ACLKWISE                  \ [0x10 : 16] Number of Anti Clock Wise revolutions
  [then]


  [ifdef] LCSC_LCSC_CONFR_DEF
    \
    \ @brief LCSC_CONFR register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant LCSC_CLKWISE_THRES             \ [0x00 : 16] Number of Clock Wise revolutions target
    $10 constant LCSC_ACLKWISE_THRES            \ [0x10 : 16] Number of Anti Clock Wise revolutions target
  [then]


  [ifdef] LCSC_LCSC_COMP_CTN_DEF
    \
    \ @brief LCSC_COMP_CTN register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LCSC_CMP_LCA_CNT               \ [0x00 : 8] LCA Comparator last damping count
    $0a constant LCSC_CMP_LCB_CNT               \ [0x0a : 8] LCB Comparator last damping count
    $14 constant LCSC_CMP_LCT_CNT               \ [0x14 : 8] LCT Comparator last damping count
  [then]


  [ifdef] LCSC_LCSC_SR_DEF
    \
    \ @brief LCSC_SR register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LCSC_CLKWISE_STATE             \ [0x00 : 2] The current state of the LCSC clockwise FSM:
    $02 constant LCSC_ACLKWISE_STATE            \ [0x02 : 2] The current state of the LCSC anti clockwise FSM:
    $04 constant LCSC_LAST_DIR                  \ [0x04 : 2] The last direction detected:
  [then]


  [ifdef] LCSC_LCSC_STAT_DEF
    \
    \ @brief LCSC_STAT register
    \ Address offset: 0x24
    \ Reset value: 0xFF0000FF
    \
    $00 constant LCSC_MIN_LCAB_CNT              \ [0x00 : 8] The Minimum of CMP_LCA_CNT, CMP_LCB_CNT reached during the
    $08 constant LCSC_MAX_LCAB_CNT              \ [0x08 : 8] The Maximum of CMP_LCA_CNT, CMP_LCB_CNT reached during
    $10 constant LCSC_MIN_LCAB_CNT_BOUND        \ [0x10 : 8] The Minimum bound of CMP_LCA_COUNT,
    $18 constant LCSC_MAX_LCAB_CNT_BOUND        \ [0x18 : 8] The Maximum bound of CMP_LCA_COUNT,
  [then]


  [ifdef] LCSC_LCSC_TST_CFG_DEF
    \
    \ @brief LCSC Test Configuration Register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LCSC_TST_EN                    \ [0x00] Test Enable
    $01 constant LCSC_TST_CFG                   \ [0x01 : 3] DTB output selection
  [then]


  [ifdef] LCSC_LCSC_ANATST_CFG_DEF
    \
    \ @brief LCSC ANA Test Configuration Register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LCSC_VCMBUFF_ENOUT_SEL         \ [0x00] Selection of the signal to be used to supply the DAC in the LCSC
    $01 constant LCSC_VCMBUFF_ENOUT             \ [0x01] VCMBUFFER output buffer enable pin
    $02 constant LCSC_VCMBUFF_PWDN_SEL          \ [0x02] Selection of the signal to be used to supply the DAC in the LCSC
    $03 constant LCSC_VCMBUFF_PWDN              \ [0x03] VCMBUFF power-down pin
    $04 constant LCSC_COMP_PWDN_SEL             \ [0x04] Selection of the signal to be used to supply the COMP in the LCSC Analog part
    $05 constant LCSC_COMP_PWDN                 \ [0x05] COMP power-down pin
    $06 constant LCSC_DAC_PWDN_SEL              \ [0x06] Selection of the signal to be used to supply the DAC in the LCSC Analog part
    $07 constant LCSC_DAC_PWDN                  \ [0x07] DAC power-down pin
  [then]


  [ifdef] LCSC_LCSC_VER_DEF
    \
    \ @brief LCSC_VER register
    \ Address offset: 0x40
    \ Reset value: 0x00001000
    \
    $04 constant LCSC_REV                       \ [0x04 : 4] Revision of the RFIP to be used for metal fixes)
    $08 constant LCSC_VER                       \ [0x08 : 4] Version of the RFIP (to be used for cut upgrades)
    $0c constant LCSC_PROD                      \ [0x0c : 4] Used for major upgrades (new protocols support / new features)
  [then]


  [ifdef] LCSC_LCSC_ISR_DEF
    \
    \ @brief LCSC_ISR register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant LCSC_CLKWISE_F                 \ [0x00] Clock Wise Flag:
    $01 constant LCSC_ACLKWISE_F                \ [0x01] Anti Clock Wise Flag:
    $02 constant LCSC_TAMP_F                    \ [0x02] Tamper Flag
    $03 constant LCSC_CNT_OFB_F                 \ [0x03] Out of Bound Counter Flag
  [then]

  \
  \ @brief LCSC interrupt
  \
  $00 constant LCSC_LCSC_CR0            \ LCSC_CR0 register
  $04 constant LCSC_LCSC_CR1            \ LCSC_CR1 register
  $08 constant LCSC_LCSC_CR2            \ LCSC_CR2 register
  $0C constant LCSC_LCSC_PULSE_CR       \ LCSC_PULSE_CR register
  $10 constant LCSC_LCSC_ENR            \ LCSC_ENR register
  $14 constant LCSC_LCSC_WHEEL_SR       \ LCSC_WHEEL_SR register
  $18 constant LCSC_LCSC_CONFR          \ LCSC_CONFR register
  $1C constant LCSC_LCSC_COMP_CTN       \ LCSC_COMP_CTN register
  $20 constant LCSC_LCSC_SR             \ LCSC_SR register
  $24 constant LCSC_LCSC_STAT           \ LCSC_STAT register
  $28 constant LCSC_LCSC_TST_CFG        \ LCSC Test Configuration Register
  $2C constant LCSC_LCSC_ANATST_CFG     \ LCSC ANA Test Configuration Register
  $40 constant LCSC_LCSC_VER            \ LCSC_VER register
  $44 constant LCSC_LCSC_ISR            \ LCSC_ISR register

: LCSC_DEF ; [then]
