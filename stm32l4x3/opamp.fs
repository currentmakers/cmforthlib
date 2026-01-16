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
$00000300 constant OPAMP_OPAMP1_CSR_VM_SEL                          \ Inverting input selection
$00000400 constant OPAMP_OPAMP1_CSR_VP_SEL                          \ Non inverted input selection
$00001000 constant OPAMP_OPAMP1_CSR_CALON                           \ Calibration mode enabled
$00002000 constant OPAMP_OPAMP1_CSR_CALSEL                          \ Calibration selection
$00004000 constant OPAMP_OPAMP1_CSR_USERTRIM                        \ allows to switch from factory AOP offset trimmed values to AOP offset user trimmed values
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
\ @brief OPAMP1 offset trimming register in low-power mode
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant OPAMP_OPAMP1_LPOTR_TRIMLPOFFSETN                 \ Trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP1_LPOTR_TRIMLPOFFSETP                 \ Trim for PMOS differential pairs


\
\ @brief Operational amplifiers
\
$40007800 constant OPAMP_OPAMP1_CSR  \ offset: 0x00 : OPAMP1 control/status register
$40007804 constant OPAMP_OPAMP1_OTR  \ offset: 0x04 : OPAMP1 offset trimming register in normal mode
$40007808 constant OPAMP_OPAMP1_LPOTR  \ offset: 0x08 : OPAMP1 offset trimming register in low-power mode

