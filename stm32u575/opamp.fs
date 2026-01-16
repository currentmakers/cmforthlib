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

$00000001 constant OPAMP_OPAMP1_CSR_OPAEN                           \ OPAMP enable
$00000002 constant OPAMP_OPAMP1_CSR_OPALPM                          \ OPAMP low-power mode The OPAMP must be disabled to change this configuration.
$0000000c constant OPAMP_OPAMP1_CSR_OPAMODE                         \ OPAMP PGA mode 00 and 01: internal PGA disabled
$00000030 constant OPAMP_OPAMP1_CSR_PGA_GAIN                        \ OPAMP programmable amplifier gain value
$00000300 constant OPAMP_OPAMP1_CSR_VM_SEL                          \ Inverting input selection These bits are used only when OPAMODE = 00, 01 or 10. 1x: inverting input not externally connected
$00000400 constant OPAMP_OPAMP1_CSR_VP_SEL                          \ Non-inverted input selection
$00001000 constant OPAMP_OPAMP1_CSR_CALON                           \ Calibration mode enable
$00002000 constant OPAMP_OPAMP1_CSR_CALSEL                          \ Calibration selection
$00004000 constant OPAMP_OPAMP1_CSR_USERTRIM                        \ ‘factory’ or ‘user’ offset trimmed values selection This bit is active for normal and low-power modes.
$00008000 constant OPAMP_OPAMP1_CSR_CALOUT                          \ OPAMP calibration output During the calibration mode, the offset is trimmed when this signal toggles.
$40000000 constant OPAMP_OPAMP1_CSR_OPAHSM                          \ OPAMP high-speed mode This bit is effective for both normal and low-power modes.
$80000000 constant OPAMP_OPAMP1_CSR_OPA_RANGE                       \ OPAMP range setting This bit must be set before enabling the OPAMP and this bit affects all OPAMP instances.


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

$0000001f constant OPAMP_OPAMP1_LPOTR_TRIMLPOFFSETN                 \ Low-power mode trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP1_LPOTR_TRIMLPOFFSETP                 \ Low-power mode trim for PMOS differential pairs


\
\ @brief OPAMP2 control/status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP2_CRS_OPAEN                           \ OPAMP enable
$00000002 constant OPAMP_OPAMP2_CRS_OPALPM                          \ OPAMP low-power mode The OPAMP must be disabled to change this configuration.
$0000000c constant OPAMP_OPAMP2_CRS_OPAMODE                         \ OPAMP PGA mode 00 and 01: internal PGA disabled
$00000030 constant OPAMP_OPAMP2_CRS_PGA_GAIN                        \ OPAMP programmable amplifier gain value
$00000300 constant OPAMP_OPAMP2_CRS_VM_SEL                          \ Inverting input selection These bits are used only when OPAMODE = 00, 01 or 10. in PGA mode for filtering) 1x: inverting input not externally connected
$00000400 constant OPAMP_OPAMP2_CRS_VP_SEL                          \ Non inverted input selection
$00001000 constant OPAMP_OPAMP2_CRS_CALON                           \ Calibration mode enable
$00002000 constant OPAMP_OPAMP2_CRS_CALSEL                          \ Calibration selection
$00004000 constant OPAMP_OPAMP2_CRS_USERTRIM                        \ ‘factory’ or ‘user’ offset trimmed values selection This bit is active for normal and low-power modes.
$00008000 constant OPAMP_OPAMP2_CRS_CALOUT                          \ OPAMP calibration output During calibration mode, the offset is trimmed when this signal toggles.
$40000000 constant OPAMP_OPAMP2_CRS_OPAHSM                          \ OPAMP high-speed mode This bit is effective for both normal and high-speed modes.


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

$0000001f constant OPAMP_OPAMP2_LPOTR_TRIMLPOFFSETN                 \ Low-power mode trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP2_LPOTR_TRIMLPOFFSETP                 \ Low-power mode trim for PMOS differential pairs


\
\ @brief Operational amplifiers
\
$46005000 constant OPAMP_OPAMP1_CSR  \ offset: 0x00 : OPAMP1 control/status register
$46005004 constant OPAMP_OPAMP1_OTR  \ offset: 0x04 : OPAMP1 offset trimming register in normal mode
$46005008 constant OPAMP_OPAMP1_LPOTR  \ offset: 0x08 : OPAMP1 offset trimming register in low-power mode
$46005010 constant OPAMP_OPAMP2_CRS  \ offset: 0x10 : OPAMP2 control/status register
$46005014 constant OPAMP_OPAMP2_OTR  \ offset: 0x14 : OPAMP2 offset trimming register in normal mode
$46005018 constant OPAMP_OPAMP2_LPOTR  \ offset: 0x18 : OPAMP2 offset trimming register in low-power mode

