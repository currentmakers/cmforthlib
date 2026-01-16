\
\ @file gich.fs
\ @brief GICH
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GICH hypervisor control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GICH_GICH_HCR_EN                                 \ EN
$00000002 constant GICH_GICH_HCR_UIE                                \ UIE
$00000004 constant GICH_GICH_HCR_LRENPIE                            \ LRENPIE
$00000008 constant GICH_GICH_HCR_NPIE                               \ NPIE
$00000010 constant GICH_GICH_HCR_VGRP0EIE                           \ VGRP0EIE
$00000020 constant GICH_GICH_HCR_VGRP0DIE                           \ VGRP0DIE
$00000040 constant GICH_GICH_HCR_VGRP1EIE                           \ VGRP1EIE
$00000080 constant GICH_GICH_HCR_VGRP1DIE                           \ VGRP1DIE
$f8000000 constant GICH_GICH_HCR_EOICOUNT                           \ EOICOUNT


\
\ @brief GICH VGIC type register
\ Address offset: 0x04
\ Reset value: 0x90000003
\

$0000001f constant GICH_GICH_VTR_LISTREGS                           \ LISTREGS
$1c000000 constant GICH_GICH_VTR_PREBITS                            \ PREBITS
$e0000000 constant GICH_GICH_VTR_PRIBITS                            \ PRIBITS


\
\ @brief GICH virtual machine control register
\ Address offset: 0x08
\ Reset value: 0x004D0000
\

$00000001 constant GICH_GICH_VMCR_VMGRP0EN                          \ VMGRP0EN
$00000002 constant GICH_GICH_VMCR_VMGRP1EN                          \ VMGRP1EN
$00000004 constant GICH_GICH_VMCR_VMACKCTL                          \ VMACKCTL
$00000008 constant GICH_GICH_VMCR_VMFIQEN                           \ VMFIQEN
$00000010 constant GICH_GICH_VMCR_VMCBPR                            \ VMCBPR
$00000200 constant GICH_GICH_VMCR_VEM                               \ VEM
$001c0000 constant GICH_GICH_VMCR_VMABP                             \ VMABP
$00e00000 constant GICH_GICH_VMCR_VMBP                              \ VMBP
$f8000000 constant GICH_GICH_VMCR_VMPRIMASK                         \ VMPRIMASK


\
\ @brief GICH maintenance interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GICH_GICH_MISR_EOI                               \ EOI
$00000002 constant GICH_GICH_MISR_U                                 \ U
$00000004 constant GICH_GICH_MISR_LRENP                             \ LRENP
$00000008 constant GICH_GICH_MISR_NP                                \ NP
$00000010 constant GICH_GICH_MISR_VGRP0E                            \ VGRP0E
$00000020 constant GICH_GICH_MISR_VGRP0D                            \ VGRP0D
$00000040 constant GICH_GICH_MISR_VGRP1E                            \ VGRP1E
$00000080 constant GICH_GICH_MISR_VGRP1D                            \ VGRP1D


\
\ @brief GICH end of interrupt status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant GICH_GICH_EISR0_EISR0                            \ EISR0


\
\ @brief GICH empty list status register
\ Address offset: 0x30
\ Reset value: 0x0000000F
\

$00000000 constant GICH_GICH_ELSR0_ELSR0                            \ ELSR0


\
\ @brief GICH active priority register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000000 constant GICH_GICH_APR0_APR0                              \ APR0


\
\ @brief GICH list register 0
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$000003ff constant GICH_GICH_LR0_VIRTUALID                          \ VIRTUALID
$000ffc00 constant GICH_GICH_LR0_PHYSICALID                         \ PHYSICALID
$0f800000 constant GICH_GICH_LR0_PRIORITY                           \ PRIORITY
$30000000 constant GICH_GICH_LR0_STATE                              \ STATE
$40000000 constant GICH_GICH_LR0_GRP1                               \ GRP1
$80000000 constant GICH_GICH_LR0_HW                                 \ HW


\
\ @brief GICH list register 1
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$000003ff constant GICH_GICH_LR1_VIRTUALID                          \ VIRTUALID
$000ffc00 constant GICH_GICH_LR1_PHYSICALID                         \ PHYSICALID
$0f800000 constant GICH_GICH_LR1_PRIORITY                           \ PRIORITY
$30000000 constant GICH_GICH_LR1_STATE                              \ STATE
$40000000 constant GICH_GICH_LR1_GRP1                               \ GRP1
$80000000 constant GICH_GICH_LR1_HW                                 \ HW


\
\ @brief GICH list register 2
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$000003ff constant GICH_GICH_LR2_VIRTUALID                          \ VIRTUALID
$000ffc00 constant GICH_GICH_LR2_PHYSICALID                         \ PHYSICALID
$0f800000 constant GICH_GICH_LR2_PRIORITY                           \ PRIORITY
$30000000 constant GICH_GICH_LR2_STATE                              \ STATE
$40000000 constant GICH_GICH_LR2_GRP1                               \ GRP1
$80000000 constant GICH_GICH_LR2_HW                                 \ HW


\
\ @brief GICH list register 3
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$000003ff constant GICH_GICH_LR3_VIRTUALID                          \ VIRTUALID
$000ffc00 constant GICH_GICH_LR3_PHYSICALID                         \ PHYSICALID
$0f800000 constant GICH_GICH_LR3_PRIORITY                           \ PRIORITY
$30000000 constant GICH_GICH_LR3_STATE                              \ STATE
$40000000 constant GICH_GICH_LR3_GRP1                               \ GRP1
$80000000 constant GICH_GICH_LR3_HW                                 \ HW


\
\ @brief GICH
\
$a0024000 constant GICH_GICH_HCR  \ offset: 0x00 : GICH hypervisor control register
$a0024004 constant GICH_GICH_VTR  \ offset: 0x04 : GICH VGIC type register
$a0024008 constant GICH_GICH_VMCR  \ offset: 0x08 : GICH virtual machine control register
$a0024010 constant GICH_GICH_MISR  \ offset: 0x10 : GICH maintenance interrupt status register
$a0024020 constant GICH_GICH_EISR0  \ offset: 0x20 : GICH end of interrupt status register
$a0024030 constant GICH_GICH_ELSR0  \ offset: 0x30 : GICH empty list status register
$a00240f0 constant GICH_GICH_APR0  \ offset: 0xF0 : GICH active priority register
$a0024100 constant GICH_GICH_LR0  \ offset: 0x100 : GICH list register 0
$a0024104 constant GICH_GICH_LR1  \ offset: 0x104 : GICH list register 1
$a0024108 constant GICH_GICH_LR2  \ offset: 0x108 : GICH list register 2
$a002410c constant GICH_GICH_LR3  \ offset: 0x10C : GICH list register 3

