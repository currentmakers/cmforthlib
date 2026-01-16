\
\ @file opamp.fs
\ @brief Operational amplifiers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OPAMP1 control/status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP1_CSR_OPAEN                           \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP1_CSR_OPALPM                          \ Operational amplifier Low Power Mode
$0000000c constant OPAMP_OPAMP1_CSR_OPAMODE                         \ Operational amplifier PGA mode
$00000030 constant OPAMP_OPAMP1_CSR_PGA_GAIN                        \ Operational amplifier Programmable amplifier gain value
$00000300 constant OPAMP_OPAMP1_CSR_VM_SEL                          \ inverting input selection
$00000400 constant OPAMP_OPAMP1_CSR_VP_SEL                          \ non inverted input selection
$00001000 constant OPAMP_OPAMP1_CSR_CALON                           \ calibration mode enable
$00002000 constant OPAMP_OPAMP1_CSR_CALSEL                          \ calibration selection
$00004000 constant OPAMP_OPAMP1_CSR_USERTRIM                        \ User trimming enable
$00008000 constant OPAMP_OPAMP1_CSR_CALOUT                          \ Operational amplifier calibration output
$80000000 constant OPAMP_OPAMP1_CSR_OPA_RANGE                       \ Operational amplifier power supply range for stability


\
\ @brief OPAMP1 offset trimming register in normal mode
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant OPAMP_OPAMP1_OTR_TRIMOFFSETN                     \ Trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP1_OTR_TRIMOFFSETP                     \ Trim for PMOS differential pairs


\
\ @brief OPAMP1 offset trimming register in low-powe mode
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant OPAMP_OPAMP1_LPOTR_TRIMLPOFFSETN                 \ Trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP1_LPOTR_TRIMLPOFFSETP                 \ Trim for PMOS differential pairs


\
\ @brief OPAMP2 control/status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP2_CRS_OPAEN                           \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP2_CRS_OPALPM                          \ Operational amplifier Low Power Mode
$0000000c constant OPAMP_OPAMP2_CRS_OPAMODE                         \ Operational amplifier PGA mode
$00000030 constant OPAMP_OPAMP2_CRS_PGA_GAIN                        \ Operational amplifier Programmable amplifier gain value
$00000300 constant OPAMP_OPAMP2_CRS_VM_SEL                          \ inverting input selection
$00000400 constant OPAMP_OPAMP2_CRS_VP_SEL                          \ non inverted input selection
$00001000 constant OPAMP_OPAMP2_CRS_CALON                           \ calibration mode enable
$00002000 constant OPAMP_OPAMP2_CRS_CALSEL                          \ calibration selection
$00004000 constant OPAMP_OPAMP2_CRS_USERTRIM                        \ User trimming enable
$00008000 constant OPAMP_OPAMP2_CRS_CALOUT                          \ Operational amplifier calibration output


\
\ @brief OPAMP2 offset trimming register in normal mode
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000001f constant OPAMP_OPAMP2_OTR_TRIMOFFSETN                     \ Trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP2_OTR_TRIMOFFSETP                     \ Trim for PMOS differential pairs


\
\ @brief OPAMP2 offset trimming register in low-power mode
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000001f constant OPAMP_OPAMP2_LPOTR_TRIMLPOFFSETN                 \ Trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP2_LPOTR_TRIMLPOFFSETP                 \ Trim for PMOS differential pairs


\
\ @brief Operational amplifiers
\
$40007800 constant OPAMP_OPAMP1_CSR  \ offset: 0x00 : OPAMP1 control/status register
$40007804 constant OPAMP_OPAMP1_OTR  \ offset: 0x04 : OPAMP1 offset trimming register in normal mode
$40007808 constant OPAMP_OPAMP1_LPOTR  \ offset: 0x08 : OPAMP1 offset trimming register in low-powe mode
$40007810 constant OPAMP_OPAMP2_CRS  \ offset: 0x10 : OPAMP2 control/status register
$40007814 constant OPAMP_OPAMP2_OTR  \ offset: 0x14 : OPAMP2 offset trimming register in normal mode
$40007818 constant OPAMP_OPAMP2_LPOTR  \ offset: 0x18 : OPAMP2 offset trimming register in low-power mode

