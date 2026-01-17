\
\ @file opamp.fs
\ @brief Operational amplifiers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OPAMP_DEF

  [ifdef] OPAMP_CSR_DEF
    \
    \ @brief control/status register
    \ Address offset: 0x00
    \ Reset value: 0x00010101
    \
    $00 constant OPAMP_OPA1PD                   \ [0x00] OPAMP1 power down
    $01 constant OPAMP_S3SEL1                   \ [0x01] Switch 3 for OPAMP1 enable
    $02 constant OPAMP_S4SEL1                   \ [0x02] Switch 4 for OPAMP1 enable
    $03 constant OPAMP_S5SEL1                   \ [0x03] Switch 5 for OPAMP1 enable
    $04 constant OPAMP_S6SEL1                   \ [0x04] Switch 6 for OPAMP1 enable
    $05 constant OPAMP_OPA1CAL_L                \ [0x05] OPAMP1 offset calibration for P differential pair
    $06 constant OPAMP_OPA1CAL_H                \ [0x06] OPAMP1 offset calibration for N differential pair
    $07 constant OPAMP_OPA1LPM                  \ [0x07] OPAMP1 low power mode
    $08 constant OPAMP_OPA2PD                   \ [0x08] OPAMP2 power down
    $09 constant OPAMP_S3SEL2                   \ [0x09] Switch 3 for OPAMP2 enable
    $0a constant OPAMP_S4SEL2                   \ [0x0a] Switch 4 for OPAMP2 enable
    $0b constant OPAMP_S5SEL2                   \ [0x0b] Switch 5 for OPAMP2 enable
    $0c constant OPAMP_S6SEL2                   \ [0x0c] Switch 6 for OPAMP2 enable
    $0d constant OPAMP_OPA2CAL_L                \ [0x0d] OPAMP2 offset Calibration for P differential pair
    $0e constant OPAMP_OPA2CAL_H                \ [0x0e] OPAMP2 offset calibration for N differential pair
    $0f constant OPAMP_OPA2LPM                  \ [0x0f] OPAMP2 low power mode
    $10 constant OPAMP_OPA3PD                   \ [0x10] OPAMP3 power down
    $11 constant OPAMP_S3SEL3                   \ [0x11] Switch 3 for OPAMP3 Enable
    $12 constant OPAMP_S4SEL3                   \ [0x12] Switch 4 for OPAMP3 enable
    $13 constant OPAMP_S5SEL3                   \ [0x13] Switch 5 for OPAMP3 enable
    $14 constant OPAMP_S6SEL3                   \ [0x14] Switch 6 for OPAMP3 enable
    $15 constant OPAMP_OPA3CAL_L                \ [0x15] OPAMP3 offset Calibration for P differential pair
    $16 constant OPAMP_OPA3CAL_H                \ [0x16] OPAMP3 offset calibration for N differential pair
    $17 constant OPAMP_OPA3LPM                  \ [0x17] OPAMP3 low power mode
    $18 constant OPAMP_ANAWSEL1                 \ [0x18] Switch SanA enable for OPAMP1
    $19 constant OPAMP_ANAWSEL2                 \ [0x19] Switch SanA enable for OPAMP2
    $1a constant OPAMP_ANAWSEL3                 \ [0x1a] Switch SanA enable for OPAMP3
    $1b constant OPAMP_S7SEL2                   \ [0x1b] Switch 7 for OPAMP2 enable
    $1c constant OPAMP_AOP_RANGE                \ [0x1c] Power range selection
    $1d constant OPAMP_OPA1CALOUT               \ [0x1d] OPAMP1 calibration output
    $1e constant OPAMP_OPA2CALOUT               \ [0x1e] OPAMP2 calibration output
    $1f constant OPAMP_OPA3CALOUT               \ [0x1f] OPAMP3 calibration output
  [then]


  [ifdef] OPAMP_OTR_DEF
    \
    \ @brief offset trimming register for normal mode
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_AO1_OPT_OFFSET_TRIM      \ [0x00 : 10] OPAMP1, 10-bit offset trim value for normal mode
    $0a constant OPAMP_AO2_OPT_OFFSET_TRIM      \ [0x0a : 10] OPAMP2, 10-bit offset trim value for normal mode
    $14 constant OPAMP_AO3_OPT_OFFSET_TRIM      \ [0x14 : 10] OPAMP3, 10-bit offset trim value for normal mode
    $1f constant OPAMP_OT_USER                  \ [0x1f] Select user or factory trimming value
  [then]


  [ifdef] OPAMP_LPOTR_DEF
    \
    \ @brief OPAMP offset trimming register for low power mode
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_AO1_OPT_OFFSET_TRIM_LP   \ [0x00 : 10] OPAMP1, 10-bit offset trim value for low power mode
    $0a constant OPAMP_AO2_OPT_OFFSET_TRIM_LP   \ [0x0a : 10] OPAMP2, 10-bit offset trim value for low power mode
    $14 constant OPAMP_AO3_OPT_OFFSET_TRIM_LP   \ [0x14 : 10] OPAMP3, 10-bit offset trim value for low power mode
  [then]

  \
  \ @brief Operational amplifiers
  \
  $00 constant OPAMP_CSR                \ control/status register
  $04 constant OPAMP_OTR                \ offset trimming register for normal mode
  $08 constant OPAMP_LPOTR              \ OPAMP offset trimming register for low power mode

: OPAMP_DEF ; [then]
