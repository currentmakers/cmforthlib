\
\ @file opamp.fs
\ @brief OPAMP address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OPAMP_DEF

  [ifdef] OPAMP_OPAMP_CSR_DEF
    \
    \ @brief OPAMP control/status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] Operational amplifier Enable
    $01 constant OPAMP_OPALPM                   \ [0x01] Operational amplifier Low Power Mode The operational amplifier must be disable to change this configuration.
    $02 constant OPAMP_OPAMODE                  \ [0x02 : 2] Operational amplifier PGA mode
    $04 constant OPAMP_PGA_GAIN                 \ [0x04 : 2] Operational amplifier Programmable amplifier gain value
    $08 constant OPAMP_VM_SEL                   \ [0x08 : 2] Inverting input selection These bits are used only when OPAMODE = 00, 01 or 10. 1x: Inverting input not externally connected. These configurations are valid only when OPAMODE = 10 (PGA mode)
    $0a constant OPAMP_VP_SEL                   \ [0x0a] Non inverted input selection
    $0c constant OPAMP_CALON                    \ [0x0c] Calibration mode enabled
    $0d constant OPAMP_CALSEL                   \ [0x0d] Calibration selection
    $0e constant OPAMP_USERTRIM                 \ [0x0e] allows to switch from factory AOP offset trimmed values to AOP offset user trimmed values This bit is active for both mode normal and low-power.
    $0f constant OPAMP_CALOUT                   \ [0x0f] Operational amplifier calibration output During calibration mode offset is trimmed when this signal toggle.
    $1f constant OPAMP_OPA_RANGE                \ [0x1f] Operational amplifier power supply range for stability All AOP must be in power down to allow AOP-RANGE bit write. It applies to all AOP embedded in the product.
  [then]


  [ifdef] OPAMP_OPAMP_OTR_DEF
    \
    \ @brief OPAMP offset trimming register in normal mode
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_TRIMOFFSETN              \ [0x00 : 5] Trim for NMOS differential pairs
    $08 constant OPAMP_TRIMOFFSETP              \ [0x08 : 5] Trim for PMOS differential pairs
  [then]


  [ifdef] OPAMP_OPAMP_LPOTR_DEF
    \
    \ @brief OPAMP offset trimming register in low-power mode
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_TRIMLPOFFSETN            \ [0x00 : 5] Low-power mode trim for NMOS differential pairs
    $08 constant OPAMP_TRIMLPOFFSETP            \ [0x08 : 5] Low-power mode trim for PMOS differential pairs
  [then]

  \
  \ @brief OPAMP address block description
  \
  $00 constant OPAMP_OPAMP_CSR          \ OPAMP control/status register
  $04 constant OPAMP_OPAMP_OTR          \ OPAMP offset trimming register in normal mode
  $08 constant OPAMP_OPAMP_LPOTR        \ OPAMP offset trimming register in low-power mode

: OPAMP_DEF ; [then]
