\
\ @file opamp.fs
\ @brief OPAMP address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OPAMP control/status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant OPAMP_OPAMP_CSR_OPAEN                            \ Operational amplifier Enable
$00000002 constant OPAMP_OPAMP_CSR_OPALPM                           \ Operational amplifier Low Power Mode The operational amplifier must be disable to change this configuration.
$0000000c constant OPAMP_OPAMP_CSR_OPAMODE                          \ Operational amplifier PGA mode
$00000030 constant OPAMP_OPAMP_CSR_PGA_GAIN                         \ Operational amplifier Programmable amplifier gain value
$00000300 constant OPAMP_OPAMP_CSR_VM_SEL                           \ Inverting input selection These bits are used only when OPAMODE = 00, 01 or 10. 1x: Inverting input not externally connected. These configurations are valid only when OPAMODE = 10 (PGA mode)
$00000400 constant OPAMP_OPAMP_CSR_VP_SEL                           \ Non inverted input selection
$00001000 constant OPAMP_OPAMP_CSR_CALON                            \ Calibration mode enabled
$00002000 constant OPAMP_OPAMP_CSR_CALSEL                           \ Calibration selection
$00004000 constant OPAMP_OPAMP_CSR_USERTRIM                         \ allows to switch from factory AOP offset trimmed values to AOP offset user trimmed values This bit is active for both mode normal and low-power.
$00008000 constant OPAMP_OPAMP_CSR_CALOUT                           \ Operational amplifier calibration output During calibration mode offset is trimmed when this signal toggle.
$80000000 constant OPAMP_OPAMP_CSR_OPA_RANGE                        \ Operational amplifier power supply range for stability All AOP must be in power down to allow AOP-RANGE bit write. It applies to all AOP embedded in the product.


\
\ @brief OPAMP offset trimming register in normal mode
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant OPAMP_OPAMP_OTR_TRIMOFFSETN                      \ Trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP_OTR_TRIMOFFSETP                      \ Trim for PMOS differential pairs


\
\ @brief OPAMP offset trimming register in low-power mode
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant OPAMP_OPAMP_LPOTR_TRIMLPOFFSETN                  \ Low-power mode trim for NMOS differential pairs
$00001f00 constant OPAMP_OPAMP_LPOTR_TRIMLPOFFSETP                  \ Low-power mode trim for PMOS differential pairs


\
\ @brief OPAMP address block description
\
$40007800 constant OPAMP_OPAMP_CSR  \ offset: 0x00 : OPAMP control/status register
$40007804 constant OPAMP_OPAMP_OTR  \ offset: 0x04 : OPAMP offset trimming register in normal mode
$40007808 constant OPAMP_OPAMP_LPOTR  \ offset: 0x08 : OPAMP offset trimming register in low-power mode

