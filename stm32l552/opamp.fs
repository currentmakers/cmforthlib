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
    $00 constant OPAMP_OPAEN                    \ [0x00] Operational amplifier Enable
    $01 constant OPAMP_OPALPM                   \ [0x01] Operational amplifier Low Power Mode
    $02 constant OPAMP_OPAMODE                  \ [0x02 : 2] Operational amplifier PGA mode
    $04 constant OPAMP_PGA_GAIN                 \ [0x04 : 2] Operational amplifier Programmable amplifier gain value
    $08 constant OPAMP_VM_SEL                   \ [0x08 : 2] inverting input selection
    $0a constant OPAMP_VP_SEL                   \ [0x0a] non inverted input selection
    $0c constant OPAMP_CALON                    \ [0x0c] calibration mode enable
    $0d constant OPAMP_CALSEL                   \ [0x0d] calibration selection
    $0e constant OPAMP_USERTRIM                 \ [0x0e] User trimming enable
    $0f constant OPAMP_CALOUT                   \ [0x0f] Operational amplifier calibration output
    $1f constant OPAMP_OPA_RANGE                \ [0x1f] Operational amplifier power supply range for stability
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
    \ @brief OPAMP1 offset trimming register in low-powe mode
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_TRIMLPOFFSETN            \ [0x00 : 5] Trim for NMOS differential pairs
    $08 constant OPAMP_TRIMLPOFFSETP            \ [0x08 : 5] Trim for PMOS differential pairs
  [then]


  [ifdef] OPAMP_OPAMP2_CRS_DEF
    \
    \ @brief OPAMP2 control/status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] Operational amplifier Enable
    $01 constant OPAMP_OPALPM                   \ [0x01] Operational amplifier Low Power Mode
    $02 constant OPAMP_OPAMODE                  \ [0x02 : 2] Operational amplifier PGA mode
    $04 constant OPAMP_PGA_GAIN                 \ [0x04 : 2] Operational amplifier Programmable amplifier gain value
    $08 constant OPAMP_VM_SEL                   \ [0x08 : 2] inverting input selection
    $0a constant OPAMP_VP_SEL                   \ [0x0a] non inverted input selection
    $0c constant OPAMP_CALON                    \ [0x0c] calibration mode enable
    $0d constant OPAMP_CALSEL                   \ [0x0d] calibration selection
    $0e constant OPAMP_USERTRIM                 \ [0x0e] User trimming enable
    $0f constant OPAMP_CALOUT                   \ [0x0f] Operational amplifier calibration output
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
    $00 constant OPAMP_TRIMLPOFFSETN            \ [0x00 : 5] Trim for NMOS differential pairs
    $08 constant OPAMP_TRIMLPOFFSETP            \ [0x08 : 5] Trim for PMOS differential pairs
  [then]

  \
  \ @brief Operational amplifiers
  \
  $00 constant OPAMP_OPAMP1_CSR         \ OPAMP1 control/status register
  $04 constant OPAMP_OPAMP1_OTR         \ OPAMP1 offset trimming register in normal mode
  $08 constant OPAMP_OPAMP1_LPOTR       \ OPAMP1 offset trimming register in low-powe mode
  $10 constant OPAMP_OPAMP2_CRS         \ OPAMP2 control/status register
  $14 constant OPAMP_OPAMP2_OTR         \ OPAMP2 offset trimming register in normal mode
  $18 constant OPAMP_OPAMP2_LPOTR       \ OPAMP2 offset trimming register in low-power mode

: OPAMP_DEF ; [then]
