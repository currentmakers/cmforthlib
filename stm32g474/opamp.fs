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
    $01 constant OPAMP_FORCE_VP                 \ [0x01] FORCE_VP
    $02 constant OPAMP_VP_SEL                   \ [0x02 : 2] VP_SEL
    $04 constant OPAMP_USERTRIM                 \ [0x04] USERTRIM
    $05 constant OPAMP_VM_SEL                   \ [0x05 : 2] VM_SEL
    $07 constant OPAMP_OPAHSM                   \ [0x07] OPAHSM
    $08 constant OPAMP_OPAINTOEN                \ [0x08] OPAINTOEN
    $0b constant OPAMP_CALON                    \ [0x0b] CALON
    $0c constant OPAMP_CALSEL                   \ [0x0c : 2] CALSEL
    $0e constant OPAMP_PGA_GAIN                 \ [0x0e : 5] PGA_GAIN
    $13 constant OPAMP_TRIMOFFSETP              \ [0x13 : 5] TRIMOFFSETP
    $18 constant OPAMP_TRIMOFFSETN              \ [0x18 : 5] TRIMOFFSETN
    $1e constant OPAMP_CALOUT                   \ [0x1e] CALOUT
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP2_CSR_DEF
    \
    \ @brief OPAMP2 control/status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] Operational amplifier Enable
    $01 constant OPAMP_FORCE_VP                 \ [0x01] FORCE_VP
    $02 constant OPAMP_VP_SEL                   \ [0x02 : 2] VP_SEL
    $04 constant OPAMP_USERTRIM                 \ [0x04] USERTRIM
    $05 constant OPAMP_VM_SEL                   \ [0x05 : 2] VM_SEL
    $07 constant OPAMP_OPAHSM                   \ [0x07] OPAHSM
    $08 constant OPAMP_OPAINTOEN                \ [0x08] OPAINTOEN
    $0b constant OPAMP_CALON                    \ [0x0b] CALON
    $0c constant OPAMP_CALSEL                   \ [0x0c : 2] CALSEL
    $0e constant OPAMP_PGA_GAIN                 \ [0x0e : 5] PGA_GAIN
    $13 constant OPAMP_TRIMOFFSETP              \ [0x13 : 5] TRIMOFFSETP
    $18 constant OPAMP_TRIMOFFSETN              \ [0x18 : 5] TRIMOFFSETN
    $1e constant OPAMP_CALOUT                   \ [0x1e] CALOUT
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP3_CSR_DEF
    \
    \ @brief OPAMP3 control/status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] Operational amplifier Enable
    $01 constant OPAMP_FORCE_VP                 \ [0x01] FORCE_VP
    $02 constant OPAMP_VP_SEL                   \ [0x02 : 2] VP_SEL
    $04 constant OPAMP_USERTRIM                 \ [0x04] USERTRIM
    $05 constant OPAMP_VM_SEL                   \ [0x05 : 2] VM_SEL
    $07 constant OPAMP_OPAHSM                   \ [0x07] OPAHSM
    $08 constant OPAMP_OPAINTOEN                \ [0x08] OPAINTOEN
    $0b constant OPAMP_CALON                    \ [0x0b] CALON
    $0c constant OPAMP_CALSEL                   \ [0x0c : 2] CALSEL
    $0e constant OPAMP_PGA_GAIN                 \ [0x0e : 5] PGA_GAIN
    $13 constant OPAMP_TRIMOFFSETP              \ [0x13 : 5] TRIMOFFSETP
    $18 constant OPAMP_TRIMOFFSETN              \ [0x18 : 5] TRIMOFFSETN
    $1e constant OPAMP_CALOUT                   \ [0x1e] CALOUT
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP4_CSR_DEF
    \
    \ @brief OPAMP4 control/status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] Operational amplifier Enable
    $01 constant OPAMP_FORCE_VP                 \ [0x01] FORCE_VP
    $02 constant OPAMP_VP_SEL                   \ [0x02 : 2] VP_SEL
    $04 constant OPAMP_USERTRIM                 \ [0x04] USERTRIM
    $05 constant OPAMP_VM_SEL                   \ [0x05 : 2] VM_SEL
    $07 constant OPAMP_OPAHSM                   \ [0x07] OPAHSM
    $08 constant OPAMP_OPAINTOEN                \ [0x08] OPAINTOEN
    $0b constant OPAMP_CALON                    \ [0x0b] CALON
    $0c constant OPAMP_CALSEL                   \ [0x0c : 2] CALSEL
    $0e constant OPAMP_PGA_GAIN                 \ [0x0e : 5] PGA_GAIN
    $13 constant OPAMP_TRIMOFFSETP              \ [0x13 : 5] TRIMOFFSETP
    $18 constant OPAMP_TRIMOFFSETN              \ [0x18 : 5] TRIMOFFSETN
    $1e constant OPAMP_CALOUT                   \ [0x1e] CALOUT
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP5_CSR_DEF
    \
    \ @brief OPAMP5 control/status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] Operational amplifier Enable
    $01 constant OPAMP_FORCE_VP                 \ [0x01] FORCE_VP
    $02 constant OPAMP_VP_SEL                   \ [0x02 : 2] VP_SEL
    $04 constant OPAMP_USERTRIM                 \ [0x04] USERTRIM
    $05 constant OPAMP_VM_SEL                   \ [0x05 : 2] VM_SEL
    $07 constant OPAMP_OPAHSM                   \ [0x07] OPAHSM
    $08 constant OPAMP_OPAINTOEN                \ [0x08] OPAINTOEN
    $0b constant OPAMP_CALON                    \ [0x0b] CALON
    $0c constant OPAMP_CALSEL                   \ [0x0c : 2] CALSEL
    $0e constant OPAMP_PGA_GAIN                 \ [0x0e : 5] PGA_GAIN
    $13 constant OPAMP_TRIMOFFSETP              \ [0x13 : 5] TRIMOFFSETP
    $18 constant OPAMP_TRIMOFFSETN              \ [0x18 : 5] TRIMOFFSETN
    $1e constant OPAMP_CALOUT                   \ [0x1e] CALOUT
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP6_CSR_DEF
    \
    \ @brief OPAMP6 control/status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_OPAEN                    \ [0x00] Operational amplifier Enable
    $01 constant OPAMP_FORCE_VP                 \ [0x01] FORCE_VP
    $02 constant OPAMP_VP_SEL                   \ [0x02 : 2] VP_SEL
    $04 constant OPAMP_USERTRIM                 \ [0x04] USERTRIM
    $05 constant OPAMP_VM_SEL                   \ [0x05 : 2] VM_SEL
    $07 constant OPAMP_OPAHSM                   \ [0x07] OPAHSM
    $08 constant OPAMP_OPAINTOEN                \ [0x08] OPAINTOEN
    $0b constant OPAMP_CALON                    \ [0x0b] CALON
    $0c constant OPAMP_CALSEL                   \ [0x0c : 2] CALSEL
    $0e constant OPAMP_PGA_GAIN                 \ [0x0e : 5] PGA_GAIN
    $13 constant OPAMP_TRIMOFFSETP              \ [0x13 : 5] TRIMOFFSETP
    $18 constant OPAMP_TRIMOFFSETN              \ [0x18 : 5] TRIMOFFSETN
    $1e constant OPAMP_CALOUT                   \ [0x1e] CALOUT
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP1_TCMR_DEF
    \
    \ @brief OPAMP1 control/status register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_VMS_SEL                  \ [0x00] VMS_SEL
    $01 constant OPAMP_VPS_SEL                  \ [0x01 : 2] VPS_SEL
    $03 constant OPAMP_T1CM_EN                  \ [0x03] T1CM_EN
    $04 constant OPAMP_T8CM_EN                  \ [0x04] T8CM_EN
    $05 constant OPAMP_T20CM_EN                 \ [0x05] T20CM_EN
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP2_TCMR_DEF
    \
    \ @brief OPAMP2 control/status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_VMS_SEL                  \ [0x00] VMS_SEL
    $01 constant OPAMP_VPS_SEL                  \ [0x01 : 2] VPS_SEL
    $03 constant OPAMP_T1CM_EN                  \ [0x03] T1CM_EN
    $04 constant OPAMP_T8CM_EN                  \ [0x04] T8CM_EN
    $05 constant OPAMP_T20CM_EN                 \ [0x05] T20CM_EN
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP3_TCMR_DEF
    \
    \ @brief OPAMP3 control/status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_VMS_SEL                  \ [0x00] VMS_SEL
    $01 constant OPAMP_VPS_SEL                  \ [0x01 : 2] VPS_SEL
    $03 constant OPAMP_T1CM_EN                  \ [0x03] T1CM_EN
    $04 constant OPAMP_T8CM_EN                  \ [0x04] T8CM_EN
    $05 constant OPAMP_T20CM_EN                 \ [0x05] T20CM_EN
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP4_TCMR_DEF
    \
    \ @brief OPAMP4 control/status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_VMS_SEL                  \ [0x00] VMS_SEL
    $01 constant OPAMP_VPS_SEL                  \ [0x01 : 2] VPS_SEL
    $03 constant OPAMP_T1CM_EN                  \ [0x03] T1CM_EN
    $04 constant OPAMP_T8CM_EN                  \ [0x04] T8CM_EN
    $05 constant OPAMP_T20CM_EN                 \ [0x05] T20CM_EN
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP5_TCMR_DEF
    \
    \ @brief OPAMP5 control/status register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_VMS_SEL                  \ [0x00] VMS_SEL
    $01 constant OPAMP_VPS_SEL                  \ [0x01 : 2] VPS_SEL
    $03 constant OPAMP_T1CM_EN                  \ [0x03] T1CM_EN
    $04 constant OPAMP_T8CM_EN                  \ [0x04] T8CM_EN
    $05 constant OPAMP_T20CM_EN                 \ [0x05] T20CM_EN
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]


  [ifdef] OPAMP_OPAMP6_TCMR_DEF
    \
    \ @brief OPAMP6 control/status register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant OPAMP_VMS_SEL                  \ [0x00] VMS_SEL
    $01 constant OPAMP_VPS_SEL                  \ [0x01 : 2] VPS_SEL
    $03 constant OPAMP_T1CM_EN                  \ [0x03] T1CM_EN
    $04 constant OPAMP_T8CM_EN                  \ [0x04] T8CM_EN
    $05 constant OPAMP_T20CM_EN                 \ [0x05] T20CM_EN
    $1f constant OPAMP_LOCK                     \ [0x1f] LOCK
  [then]

  \
  \ @brief Operational amplifiers
  \
  $00 constant OPAMP_OPAMP1_CSR         \ OPAMP1 control/status register
  $04 constant OPAMP_OPAMP2_CSR         \ OPAMP2 control/status register
  $08 constant OPAMP_OPAMP3_CSR         \ OPAMP3 control/status register
  $0C constant OPAMP_OPAMP4_CSR         \ OPAMP4 control/status register
  $10 constant OPAMP_OPAMP5_CSR         \ OPAMP5 control/status register
  $14 constant OPAMP_OPAMP6_CSR         \ OPAMP6 control/status register
  $18 constant OPAMP_OPAMP1_TCMR        \ OPAMP1 control/status register
  $1C constant OPAMP_OPAMP2_TCMR        \ OPAMP2 control/status register
  $20 constant OPAMP_OPAMP3_TCMR        \ OPAMP3 control/status register
  $24 constant OPAMP_OPAMP4_TCMR        \ OPAMP4 control/status register
  $28 constant OPAMP_OPAMP5_TCMR        \ OPAMP5 control/status register
  $2C constant OPAMP_OPAMP6_TCMR        \ OPAMP6 control/status register

: OPAMP_DEF ; [then]
