\
\ @file opamp.fs
\ @brief Operational amplifiers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control/status register
\ Address offset: 0x00
\ Reset value: 0x00010101
\

$00000001 constant OPAMP_CSR_OPA1PD                                 \ OPAMP1 power down
$00000002 constant OPAMP_CSR_S3SEL1                                 \ Switch 3 for OPAMP1 enable
$00000004 constant OPAMP_CSR_S4SEL1                                 \ Switch 4 for OPAMP1 enable
$00000008 constant OPAMP_CSR_S5SEL1                                 \ Switch 5 for OPAMP1 enable
$00000010 constant OPAMP_CSR_S6SEL1                                 \ Switch 6 for OPAMP1 enable
$00000020 constant OPAMP_CSR_OPA1CAL_L                              \ OPAMP1 offset calibration for P differential pair
$00000040 constant OPAMP_CSR_OPA1CAL_H                              \ OPAMP1 offset calibration for N differential pair
$00000080 constant OPAMP_CSR_OPA1LPM                                \ OPAMP1 low power mode
$00000100 constant OPAMP_CSR_OPA2PD                                 \ OPAMP2 power down
$00000200 constant OPAMP_CSR_S3SEL2                                 \ Switch 3 for OPAMP2 enable
$00000400 constant OPAMP_CSR_S4SEL2                                 \ Switch 4 for OPAMP2 enable
$00000800 constant OPAMP_CSR_S5SEL2                                 \ Switch 5 for OPAMP2 enable
$00001000 constant OPAMP_CSR_S6SEL2                                 \ Switch 6 for OPAMP2 enable
$00002000 constant OPAMP_CSR_OPA2CAL_L                              \ OPAMP2 offset Calibration for P differential pair
$00004000 constant OPAMP_CSR_OPA2CAL_H                              \ OPAMP2 offset calibration for N differential pair
$00008000 constant OPAMP_CSR_OPA2LPM                                \ OPAMP2 low power mode
$00010000 constant OPAMP_CSR_OPA3PD                                 \ OPAMP3 power down
$00020000 constant OPAMP_CSR_S3SEL3                                 \ Switch 3 for OPAMP3 Enable
$00040000 constant OPAMP_CSR_S4SEL3                                 \ Switch 4 for OPAMP3 enable
$00080000 constant OPAMP_CSR_S5SEL3                                 \ Switch 5 for OPAMP3 enable
$00100000 constant OPAMP_CSR_S6SEL3                                 \ Switch 6 for OPAMP3 enable
$00200000 constant OPAMP_CSR_OPA3CAL_L                              \ OPAMP3 offset Calibration for P differential pair
$00400000 constant OPAMP_CSR_OPA3CAL_H                              \ OPAMP3 offset calibration for N differential pair
$00800000 constant OPAMP_CSR_OPA3LPM                                \ OPAMP3 low power mode
$01000000 constant OPAMP_CSR_ANAWSEL1                               \ Switch SanA enable for OPAMP1
$02000000 constant OPAMP_CSR_ANAWSEL2                               \ Switch SanA enable for OPAMP2
$04000000 constant OPAMP_CSR_ANAWSEL3                               \ Switch SanA enable for OPAMP3
$08000000 constant OPAMP_CSR_S7SEL2                                 \ Switch 7 for OPAMP2 enable
$10000000 constant OPAMP_CSR_AOP_RANGE                              \ Power range selection
$20000000 constant OPAMP_CSR_OPA1CALOUT                             \ OPAMP1 calibration output
$40000000 constant OPAMP_CSR_OPA2CALOUT                             \ OPAMP2 calibration output
$80000000 constant OPAMP_CSR_OPA3CALOUT                             \ OPAMP3 calibration output


\
\ @brief offset trimming register for normal mode
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant OPAMP_OTR_AO1_OPT_OFFSET_TRIM                    \ OPAMP1, 10-bit offset trim value for normal mode
$000ffc00 constant OPAMP_OTR_AO2_OPT_OFFSET_TRIM                    \ OPAMP2, 10-bit offset trim value for normal mode
$3ff00000 constant OPAMP_OTR_AO3_OPT_OFFSET_TRIM                    \ OPAMP3, 10-bit offset trim value for normal mode
$80000000 constant OPAMP_OTR_OT_USER                                \ Select user or factory trimming value


\
\ @brief OPAMP offset trimming register for low power mode
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant OPAMP_LPOTR_AO1_OPT_OFFSET_TRIM_LP               \ OPAMP1, 10-bit offset trim value for low power mode
$000ffc00 constant OPAMP_LPOTR_AO2_OPT_OFFSET_TRIM_LP               \ OPAMP2, 10-bit offset trim value for low power mode
$3ff00000 constant OPAMP_LPOTR_AO3_OPT_OFFSET_TRIM_LP               \ OPAMP3, 10-bit offset trim value for low power mode


\
\ @brief Operational amplifiers
\
$40007c5c constant OPAMP_CSR      \ offset: 0x00 : control/status register
$40007c60 constant OPAMP_OTR      \ offset: 0x04 : offset trimming register for normal mode
$40007c64 constant OPAMP_LPOTR    \ offset: 0x08 : OPAMP offset trimming register for low power mode

