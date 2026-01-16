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
$00000002 constant OPAMP_OPAMP1_CSR_FORCE_VP                        \ Force internal reference on VP (reserved for test
$0000000c constant OPAMP_OPAMP1_CSR_VP_SEL                          \ Operational amplifier PGA mode
$00000060 constant OPAMP_OPAMP1_CSR_VM_SEL                          \ Inverting input selection
$00000100 constant OPAMP_OPAMP1_CSR_OPAHSM                          \ Operational amplifier high-speed mode
$00000800 constant OPAMP_OPAMP1_CSR_CALON                           \ Calibration mode enabled
$00003000 constant OPAMP_OPAMP1_CSR_CALSEL                          \ Calibration selection
$0003c000 constant OPAMP_OPAMP1_CSR_PGA_GAIN                        \ allows to switch from AOP offset trimmed values to AOP offset
$00040000 constant OPAMP_OPAMP1_CSR_USERTRIM                        \ User trimming enable
$20000000 constant OPAMP_OPAMP1_CSR_TSTREF                          \ OPAMP calibration reference voltage output control (reserved for test)
$40000000 constant OPAMP_OPAMP1_CSR_CALOUT                          \ Operational amplifier calibration output


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

$0000001f constant OPAMP_OPAMP1_HSOTR_TRIMLPOFFSETN                 \ Trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP1_HSOTR_TRIMLPOFFSETP                 \ Trim for PMOS differential pairs


\
\ @brief OPAMP2 control/status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP2_CSR_OPAEN                           \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP2_CSR_FORCE_VP                        \ Force internal reference on VP (reserved for test)
$00000060 constant OPAMP_OPAMP2_CSR_VM_SEL                          \ Inverting input selection
$00000100 constant OPAMP_OPAMP2_CSR_OPAHSM                          \ Operational amplifier high-speed mode
$00000800 constant OPAMP_OPAMP2_CSR_CALON                           \ Calibration mode enabled
$00003000 constant OPAMP_OPAMP2_CSR_CALSEL                          \ Calibration selection
$0003c000 constant OPAMP_OPAMP2_CSR_PGA_GAIN                        \ Operational amplifier Programmable amplifier gain value
$00040000 constant OPAMP_OPAMP2_CSR_USERTRIM                        \ User trimming enable
$20000000 constant OPAMP_OPAMP2_CSR_TSTREF                          \ OPAMP calibration reference voltage output control (reserved for test)
$40000000 constant OPAMP_OPAMP2_CSR_CALOUT                          \ Operational amplifier calibration output


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

$0000001f constant OPAMP_OPAMP2_HSOTR_TRIMLPOFFSETN                 \ Trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP2_HSOTR_TRIMLPOFFSETP                 \ Trim for PMOS differential pairs


\
\ @brief Operational amplifiers
\
$40009000 constant OPAMP_OPAMP1_CSR  \ offset: 0x00 : OPAMP1 control/status register
$40009004 constant OPAMP_OPAMP1_OTR  \ offset: 0x04 : OPAMP1 offset trimming register in normal mode
$40009008 constant OPAMP_OPAMP1_HSOTR  \ offset: 0x08 : OPAMP1 offset trimming register in low-power mode
$40009010 constant OPAMP_OPAMP2_CSR  \ offset: 0x10 : OPAMP2 control/status register
$40009014 constant OPAMP_OPAMP2_OTR  \ offset: 0x14 : OPAMP2 offset trimming register in normal mode
$40009018 constant OPAMP_OPAMP2_HSOTR  \ offset: 0x18 : OPAMP2 offset trimming register in low-power mode

