\
\ @file gich.fs
\ @brief GICH
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GICH_DEF

  [ifdef] GICH_GICH_HCR_DEF
    \
    \ @brief GICH hypervisor control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GICH_EN                        \ [0x00] EN
    $01 constant GICH_UIE                       \ [0x01] UIE
    $02 constant GICH_LRENPIE                   \ [0x02] LRENPIE
    $03 constant GICH_NPIE                      \ [0x03] NPIE
    $04 constant GICH_VGRP0EIE                  \ [0x04] VGRP0EIE
    $05 constant GICH_VGRP0DIE                  \ [0x05] VGRP0DIE
    $06 constant GICH_VGRP1EIE                  \ [0x06] VGRP1EIE
    $07 constant GICH_VGRP1DIE                  \ [0x07] VGRP1DIE
    $1b constant GICH_EOICOUNT                  \ [0x1b : 5] EOICOUNT
  [then]


  [ifdef] GICH_GICH_VTR_DEF
    \
    \ @brief GICH VGIC type register
    \ Address offset: 0x04
    \ Reset value: 0x90000003
    \
    $00 constant GICH_LISTREGS                  \ [0x00 : 5] LISTREGS
    $1a constant GICH_PREBITS                   \ [0x1a : 3] PREBITS
    $1d constant GICH_PRIBITS                   \ [0x1d : 3] PRIBITS
  [then]


  [ifdef] GICH_GICH_VMCR_DEF
    \
    \ @brief GICH virtual machine control register
    \ Address offset: 0x08
    \ Reset value: 0x004D0000
    \
    $00 constant GICH_VMGRP0EN                  \ [0x00] VMGRP0EN
    $01 constant GICH_VMGRP1EN                  \ [0x01] VMGRP1EN
    $02 constant GICH_VMACKCTL                  \ [0x02] VMACKCTL
    $03 constant GICH_VMFIQEN                   \ [0x03] VMFIQEN
    $04 constant GICH_VMCBPR                    \ [0x04] VMCBPR
    $09 constant GICH_VEM                       \ [0x09] VEM
    $12 constant GICH_VMABP                     \ [0x12 : 3] VMABP
    $15 constant GICH_VMBP                      \ [0x15 : 3] VMBP
    $1b constant GICH_VMPRIMASK                 \ [0x1b : 5] VMPRIMASK
  [then]


  [ifdef] GICH_GICH_MISR_DEF
    \
    \ @brief GICH maintenance interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GICH_EOI                       \ [0x00] EOI
    $01 constant GICH_U                         \ [0x01] U
    $02 constant GICH_LRENP                     \ [0x02] LRENP
    $03 constant GICH_NP                        \ [0x03] NP
    $04 constant GICH_VGRP0E                    \ [0x04] VGRP0E
    $05 constant GICH_VGRP0D                    \ [0x05] VGRP0D
    $06 constant GICH_VGRP1E                    \ [0x06] VGRP1E
    $07 constant GICH_VGRP1D                    \ [0x07] VGRP1D
  [then]


  [ifdef] GICH_GICH_EISR0_DEF
    \
    \ @brief GICH end of interrupt status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GICH_EISR0                     \ [0x00 : 32] EISR0
  [then]


  [ifdef] GICH_GICH_ELSR0_DEF
    \
    \ @brief GICH empty list status register
    \ Address offset: 0x30
    \ Reset value: 0x0000000F
    \
    $00 constant GICH_ELSR0                     \ [0x00 : 32] ELSR0
  [then]


  [ifdef] GICH_GICH_APR0_DEF
    \
    \ @brief GICH active priority register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant GICH_APR0                      \ [0x00 : 32] APR0
  [then]


  [ifdef] GICH_GICH_LR0_DEF
    \
    \ @brief GICH list register 0
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant GICH_VIRTUALID                 \ [0x00 : 10] VIRTUALID
    $0a constant GICH_PHYSICALID                \ [0x0a : 10] PHYSICALID
    $17 constant GICH_PRIORITY                  \ [0x17 : 5] PRIORITY
    $1c constant GICH_STATE                     \ [0x1c : 2] STATE
    $1e constant GICH_GRP1                      \ [0x1e] GRP1
    $1f constant GICH_HW                        \ [0x1f] HW
  [then]


  [ifdef] GICH_GICH_LR1_DEF
    \
    \ @brief GICH list register 1
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant GICH_VIRTUALID                 \ [0x00 : 10] VIRTUALID
    $0a constant GICH_PHYSICALID                \ [0x0a : 10] PHYSICALID
    $17 constant GICH_PRIORITY                  \ [0x17 : 5] PRIORITY
    $1c constant GICH_STATE                     \ [0x1c : 2] STATE
    $1e constant GICH_GRP1                      \ [0x1e] GRP1
    $1f constant GICH_HW                        \ [0x1f] HW
  [then]


  [ifdef] GICH_GICH_LR2_DEF
    \
    \ @brief GICH list register 2
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant GICH_VIRTUALID                 \ [0x00 : 10] VIRTUALID
    $0a constant GICH_PHYSICALID                \ [0x0a : 10] PHYSICALID
    $17 constant GICH_PRIORITY                  \ [0x17 : 5] PRIORITY
    $1c constant GICH_STATE                     \ [0x1c : 2] STATE
    $1e constant GICH_GRP1                      \ [0x1e] GRP1
    $1f constant GICH_HW                        \ [0x1f] HW
  [then]


  [ifdef] GICH_GICH_LR3_DEF
    \
    \ @brief GICH list register 3
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant GICH_VIRTUALID                 \ [0x00 : 10] VIRTUALID
    $0a constant GICH_PHYSICALID                \ [0x0a : 10] PHYSICALID
    $17 constant GICH_PRIORITY                  \ [0x17 : 5] PRIORITY
    $1c constant GICH_STATE                     \ [0x1c : 2] STATE
    $1e constant GICH_GRP1                      \ [0x1e] GRP1
    $1f constant GICH_HW                        \ [0x1f] HW
  [then]

  \
  \ @brief GICH
  \
  $00 constant GICH_GICH_HCR            \ GICH hypervisor control register
  $04 constant GICH_GICH_VTR            \ GICH VGIC type register
  $08 constant GICH_GICH_VMCR           \ GICH virtual machine control register
  $10 constant GICH_GICH_MISR           \ GICH maintenance interrupt status register
  $20 constant GICH_GICH_EISR0          \ GICH end of interrupt status register
  $30 constant GICH_GICH_ELSR0          \ GICH empty list status register
  $F0 constant GICH_GICH_APR0           \ GICH active priority register
  $100 constant GICH_GICH_LR0           \ GICH list register 0
  $104 constant GICH_GICH_LR1           \ GICH list register 1
  $108 constant GICH_GICH_LR2           \ GICH list register 2
  $10C constant GICH_GICH_LR3           \ GICH list register 3

: GICH_DEF ; [then]
