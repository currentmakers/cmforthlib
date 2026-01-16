\
\ @file opamp1.fs
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

$00000001 constant OPAMP1_OPAMP1_CSR_OPAEN                          \ Operational amplifier Enable Note: If OPAMP1 is unconnected in a specific package, it must remain disabled (keep OPAMP1_CSR register default value).
$00000002 constant OPAMP1_OPAMP1_CSR_FORCE_VP                       \ Force internal reference on VP (reserved for test)
$0000000c constant OPAMP1_OPAMP1_CSR_VP_SEL                         \ Non inverted input selection
$00000060 constant OPAMP1_OPAMP1_CSR_VM_SEL                         \ Inverting input selection
$00000100 constant OPAMP1_OPAMP1_CSR_OPAHSM                         \ Operational amplifier high-speed mode The operational amplifier must be disable to change this configuration.
$00000800 constant OPAMP1_OPAMP1_CSR_CALON                          \ Calibration mode enabled
$00003000 constant OPAMP1_OPAMP1_CSR_CALSEL                         \ Calibration selection It is used to select the offset calibration bus used to generate the internal reference voltage when CALON = 1 or FORCE_VP= 1.
$0003c000 constant OPAMP1_OPAMP1_CSR_PGA_GAIN                       \ Operational amplifier Programmable amplifier gain value
$00040000 constant OPAMP1_OPAMP1_CSR_USERTRIM                       \ User trimming enable This bit allows to switch from 'factory' AOP offset trimmed values to 'user' AOP offset trimmed values This bit is active for both mode normal and high-power.
$20000000 constant OPAMP1_OPAMP1_CSR_TSTREF                         \ OPAMP calibration reference voltage output control (reserved for test)
$40000000 constant OPAMP1_OPAMP1_CSR_CALOUT                         \ Operational amplifier calibration output OPAMP output status flag. During the calibration mode, OPAMP is used as comparator.


\
\ @brief OPAMP1 trimming register in normal mode
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant OPAMP1_OPAMP1_OTR_TRIMOFFSETN                    \ Trim for NMOS differential pairs
$00001f00 constant OPAMP1_OPAMP1_OTR_TRIMOFFSETP                    \ Trim for PMOS differential pairs


\
\ @brief OPAMP1 trimming register in high-speed mode
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant OPAMP1_OPAMP1_HSOTR_TRIMHSOFFSETN                \ High-speed mode trim for NMOS differential pairs
$00001f00 constant OPAMP1_OPAMP1_HSOTR_TRIMHSOFFSETP                \ High-speed mode trim for PMOS differential pairs


\
\ @brief OPAMP option register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\


\
\ @brief Operational amplifiers
\
$40003400 constant OPAMP1_OPAMP1_CSR  \ offset: 0x00 : OPAMP1 control/status register
$40003404 constant OPAMP1_OPAMP1_OTR  \ offset: 0x04 : OPAMP1 trimming register in normal mode
$40003408 constant OPAMP1_OPAMP1_HSOTR  \ offset: 0x08 : OPAMP1 trimming register in high-speed mode
$4000340c constant OPAMP1_OPAMP_OR  \ offset: 0x0C : OPAMP option register

