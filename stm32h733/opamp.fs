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
    $01 constant OPAMP_FORCE_VP                 \ [0x01] Force internal reference on VP (reserved for test
    $02 constant OPAMP_VP_SEL                   \ [0x02 : 2] Operational amplifier PGA mode
    $05 constant OPAMP_VM_SEL                   \ [0x05 : 2] Inverting input selection
    $08 constant OPAMP_OPAHSM                   \ [0x08] Operational amplifier high-speed mode
    $0b constant OPAMP_CALON                    \ [0x0b] Calibration mode enabled
    $0c constant OPAMP_CALSEL                   \ [0x0c : 2] Calibration selection
    $0e constant OPAMP_PGA_GAIN                 \ [0x0e : 4] allows to switch from AOP offset trimmed values to AOP offset
    $12 constant OPAMP_USERTRIM                 \ [0x12] User trimming enable
    $1d constant OPAMP_TSTREF                   \ [0x1d] OPAMP calibration reference voltage output control (reserved for test)
    $1e constant OPAMP_CALOUT                   \ [0x1e] Operational amplifier calibration output
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


  [ifdef] OPAMP_OPAMP1_HSOTR_DEF
    \
    \ @brief OPAMP1 offset trimming register in low-power mode
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_TRIMLPOFFSETN            \ [0x00 : 5] Trim for NMOS differential pairs
    $08 constant OPAMP_TRIMLPOFFSETP            \ [0x08 : 5] Trim for PMOS differential pairs
  [then]


  [ifdef] OPAMP_OPAMP2_CSR_DEF
    \
    \ @brief OPAMP2 control/status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] Operational amplifier Enable
    $01 constant OPAMP_FORCE_VP                 \ [0x01] Force internal reference on VP (reserved for test)
    $05 constant OPAMP_VM_SEL                   \ [0x05 : 2] Inverting input selection
    $08 constant OPAMP_OPAHSM                   \ [0x08] Operational amplifier high-speed mode
    $0b constant OPAMP_CALON                    \ [0x0b] Calibration mode enabled
    $0c constant OPAMP_CALSEL                   \ [0x0c : 2] Calibration selection
    $0e constant OPAMP_PGA_GAIN                 \ [0x0e : 4] Operational amplifier Programmable amplifier gain value
    $12 constant OPAMP_USERTRIM                 \ [0x12] User trimming enable
    $1d constant OPAMP_TSTREF                   \ [0x1d] OPAMP calibration reference voltage output control (reserved for test)
    $1e constant OPAMP_CALOUT                   \ [0x1e] Operational amplifier calibration output
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


  [ifdef] OPAMP_OPAMP2_HSOTR_DEF
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
  $08 constant OPAMP_OPAMP1_HSOTR       \ OPAMP1 offset trimming register in low-power mode
  $10 constant OPAMP_OPAMP2_CSR         \ OPAMP2 control/status register
  $14 constant OPAMP_OPAMP2_OTR         \ OPAMP2 offset trimming register in normal mode
  $18 constant OPAMP_OPAMP2_HSOTR       \ OPAMP2 offset trimming register in low-power mode

: OPAMP_DEF ; [then]
