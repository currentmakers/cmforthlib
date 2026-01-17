\
\ @file opamp.fs
\ @brief Operational amplifiers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OPAMP_DEF

  [ifdef] OPAMP_OPAMP1_CSR_DEF
    \
    \ @brief OPAMP1 control/status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] OPAMP enable
    $01 constant OPAMP_OPALPM                   \ [0x01] OPAMP low-power mode The OPAMP must be disabled to change this configuration.
    $02 constant OPAMP_OPAMODE                  \ [0x02 : 2] OPAMP PGA mode 00 and 01: internal PGA disabled
    $04 constant OPAMP_PGA_GAIN                 \ [0x04 : 2] OPAMP programmable amplifier gain value
    $08 constant OPAMP_VM_SEL                   \ [0x08 : 2] Inverting input selection These bits are used only when OPAMODE = 00, 01 or 10. 1x: inverting input not externally connected
    $0a constant OPAMP_VP_SEL                   \ [0x0a] Non-inverted input selection
    $0c constant OPAMP_CALON                    \ [0x0c] Calibration mode enable
    $0d constant OPAMP_CALSEL                   \ [0x0d] Calibration selection
    $0e constant OPAMP_USERTRIM                 \ [0x0e] ‘factory’ or ‘user’ offset trimmed values selection This bit is active for normal and low-power modes.
    $0f constant OPAMP_CALOUT                   \ [0x0f] OPAMP calibration output During the calibration mode, the offset is trimmed when this signal toggles.
    $1e constant OPAMP_OPAHSM                   \ [0x1e] OPAMP high-speed mode This bit is effective for both normal and low-power modes.
    $1f constant OPAMP_OPA_RANGE                \ [0x1f] OPAMP range setting This bit must be set before enabling the OPAMP and this bit affects all OPAMP instances.
  [then]


  [ifdef] OPAMP_OPAMP1_OTR_DEF
    \
    \ @brief OPAMP1 offset trimming register in normal mode
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_TRIMOFFSETN              \ [0x00 : 5] Trim for NMOS differential pairs
    $08 constant OPAMP_TRIMOFFSETP              \ [0x08 : 5] Trim for PMOS differential pairs
  [then]


  [ifdef] OPAMP_OPAMP1_LPOTR_DEF
    \
    \ @brief OPAMP1 offset trimming register in low-power mode
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_TRIMLPOFFSETN            \ [0x00 : 5] Low-power mode trim for NMOS differential pairs
    $08 constant OPAMP_TRIMLPOFFSETP            \ [0x08 : 5] Low-power mode trim for PMOS differential pairs
  [then]


  [ifdef] OPAMP_OPAMP2_CRS_DEF
    \
    \ @brief OPAMP2 control/status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] OPAMP enable
    $01 constant OPAMP_OPALPM                   \ [0x01] OPAMP low-power mode The OPAMP must be disabled to change this configuration.
    $02 constant OPAMP_OPAMODE                  \ [0x02 : 2] OPAMP PGA mode 00 and 01: internal PGA disabled
    $04 constant OPAMP_PGA_GAIN                 \ [0x04 : 2] OPAMP programmable amplifier gain value
    $08 constant OPAMP_VM_SEL                   \ [0x08 : 2] Inverting input selection These bits are used only when OPAMODE = 00, 01 or 10. in PGA mode for filtering) 1x: inverting input not externally connected
    $0a constant OPAMP_VP_SEL                   \ [0x0a] Non inverted input selection
    $0c constant OPAMP_CALON                    \ [0x0c] Calibration mode enable
    $0d constant OPAMP_CALSEL                   \ [0x0d] Calibration selection
    $0e constant OPAMP_USERTRIM                 \ [0x0e] ‘factory’ or ‘user’ offset trimmed values selection This bit is active for normal and low-power modes.
    $0f constant OPAMP_CALOUT                   \ [0x0f] OPAMP calibration output During calibration mode, the offset is trimmed when this signal toggles.
    $1e constant OPAMP_OPAHSM                   \ [0x1e] OPAMP high-speed mode This bit is effective for both normal and high-speed modes.
  [then]


  [ifdef] OPAMP_OPAMP2_OTR_DEF
    \
    \ @brief OPAMP2 offset trimming register in normal mode
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_TRIMOFFSETN              \ [0x00 : 5] Trim for NMOS differential pairs
    $08 constant OPAMP_TRIMOFFSETP              \ [0x08 : 5] Trim for PMOS differential pairs
  [then]


  [ifdef] OPAMP_OPAMP2_LPOTR_DEF
    \
    \ @brief OPAMP2 offset trimming register in low-power mode
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_TRIMLPOFFSETN            \ [0x00 : 5] Low-power mode trim for NMOS differential pairs
    $08 constant OPAMP_TRIMLPOFFSETP            \ [0x08 : 5] Low-power mode trim for PMOS differential pairs
  [then]

  \
  \ @brief Operational amplifiers
  \
  $00 constant OPAMP_OPAMP1_CSR         \ OPAMP1 control/status register
  $04 constant OPAMP_OPAMP1_OTR         \ OPAMP1 offset trimming register in normal mode
  $08 constant OPAMP_OPAMP1_LPOTR       \ OPAMP1 offset trimming register in low-power mode
  $10 constant OPAMP_OPAMP2_CRS         \ OPAMP2 control/status register
  $14 constant OPAMP_OPAMP2_OTR         \ OPAMP2 offset trimming register in normal mode
  $18 constant OPAMP_OPAMP2_LPOTR       \ OPAMP2 offset trimming register in low-power mode

: OPAMP_DEF ; [then]
