\
\ @file opamp1.fs
\ @brief Operational amplifiers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OPAMP1_DEF

  [ifdef] OPAMP1_OPAMP1_CSR_DEF
    \
    \ @brief OPAMP1 control/status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP1_OPAEN                   \ [0x00] Operational amplifier Enable Note: If OPAMP1 is unconnected in a specific package, it must remain disabled (keep OPAMP1_CSR register default value).
    $01 constant OPAMP1_FORCE_VP                \ [0x01] Force internal reference on VP (reserved for test)
    $02 constant OPAMP1_VP_SEL                  \ [0x02 : 2] Non inverted input selection
    $05 constant OPAMP1_VM_SEL                  \ [0x05 : 2] Inverting input selection
    $08 constant OPAMP1_OPAHSM                  \ [0x08] Operational amplifier high-speed mode The operational amplifier must be disable to change this configuration.
    $0b constant OPAMP1_CALON                   \ [0x0b] Calibration mode enabled
    $0c constant OPAMP1_CALSEL                  \ [0x0c : 2] Calibration selection It is used to select the offset calibration bus used to generate the internal reference voltage when CALON = 1 or FORCE_VP= 1.
    $0e constant OPAMP1_PGA_GAIN                \ [0x0e : 4] Operational amplifier Programmable amplifier gain value
    $12 constant OPAMP1_USERTRIM                \ [0x12] User trimming enable This bit allows to switch from 'factory' AOP offset trimmed values to 'user' AOP offset trimmed values This bit is active for both mode normal and high-power.
    $1d constant OPAMP1_TSTREF                  \ [0x1d] OPAMP calibration reference voltage output control (reserved for test)
    $1e constant OPAMP1_CALOUT                  \ [0x1e] Operational amplifier calibration output OPAMP output status flag. During the calibration mode, OPAMP is used as comparator.
  [then]


  [ifdef] OPAMP1_OPAMP1_OTR_DEF
    \
    \ @brief OPAMP1 trimming register in normal mode
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP1_TRIMOFFSETN             \ [0x00 : 5] Trim for NMOS differential pairs
    $08 constant OPAMP1_TRIMOFFSETP             \ [0x08 : 5] Trim for PMOS differential pairs
  [then]


  [ifdef] OPAMP1_OPAMP1_HSOTR_DEF
    \
    \ @brief OPAMP1 trimming register in high-speed mode
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP1_TRIMHSOFFSETN           \ [0x00 : 5] High-speed mode trim for NMOS differential pairs
    $08 constant OPAMP1_TRIMHSOFFSETP           \ [0x08 : 5] High-speed mode trim for PMOS differential pairs
  [then]


  [ifdef] OPAMP1_OPAMP_OR_DEF
    \
    \ @brief OPAMP option register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
  [then]

  \
  \ @brief Operational amplifiers
  \
  $00 constant OPAMP1_OPAMP1_CSR        \ OPAMP1 control/status register
  $04 constant OPAMP1_OPAMP1_OTR        \ OPAMP1 trimming register in normal mode
  $08 constant OPAMP1_OPAMP1_HSOTR      \ OPAMP1 trimming register in high-speed mode
  $0C constant OPAMP1_OPAMP_OR          \ OPAMP option register

: OPAMP1_DEF ; [then]
