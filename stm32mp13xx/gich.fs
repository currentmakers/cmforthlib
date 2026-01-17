\
\ @file gich.fs
\ @brief GICH address block description
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
    $00 constant GICH_EN                        \ [0x00] global enable bit for the virtual CPU interface
    $01 constant GICH_UIE                       \ [0x01] underflow interrupt enable. Enables the signaling of a maintenance interrupt when the list registers are empty, or hold only one valid entry.
    $02 constant GICH_LRENPIE                   \ [0x02] list register entry not present interrupt enable Enables the signaling of a maintenance interrupt while the virtual CPU interface does not have a corresponding valid list register entry for an EOI request.
    $03 constant GICH_NPIE                      \ [0x03] no pending interrupt enable Enables the signaling of a maintenance interrupt while no pending interrupts are present in the list registers.
    $04 constant GICH_VGRP0EIE                  \ [0x04] virtual machine enable group 0interrupt enable Enables the signaling of a maintenance interrupt while signaling of group 0interrupts from the virtual CPU interface to the connected virtual machine, is enabled.
    $05 constant GICH_VGRP0DIE                  \ [0x05] virtual machine disable group 0interrupt enable Enables the signaling of a maintenance interrupt while signaling of group 0interrupts from the virtual CPU interface to the connected virtual machine, is disabled.
    $06 constant GICH_VGRP1EIE                  \ [0x06] virtual machine enable group 1 interrupt enable Enables the signaling of a maintenance interrupt while signaling of group 1 interrupts from the virtual CPU interface to the connected virtual machine, is enabled.
    $07 constant GICH_VGRP1DIE                  \ [0x07] virtual machine disable group 1 interrupt enable Enables the signaling of a maintenance interrupt while signaling of group 1 interrupts from the virtual CPU interface to the connected virtual machine, is disabled.
    $1b constant GICH_EOICOUNT                  \ [0x1b : 5] end-of-interrupt counter Counts the number of EOIs received that do not have a corresponding entry in the list registers. The virtual CPU interface increments this field automatically when a matching EOI is received. When EOIs that do not clear a bit in the active priorities register, GICH_APR does not cause an increment. Although not possible under correct operation, if an EOI occurs when the value of this field is 31, this field wraps to 0. The maintenance interrupt is asserted whenever this field is non-zero and the LRENPIE bit is set to 1.
  [then]


  [ifdef] GICH_GICH_VTR_DEF
    \
    \ @brief list registers Indicates the number of implemented list registers, minus one. For example, 0x3 means 4 list registers.
    \ Address offset: 0x04
    \ Reset value: 0x90000003
    \
    $00 constant GICH_LISTREGS                  \ [0x00 : 5] list registers Indicates the number of implemented list registers, minus one. For example, 0x3 means 4 list registers.
    $1a constant GICH_PREBITS                   \ [0x1a : 3] preemption bits Indicates the number of preemption bits implemented, minus one. For example, 0x4 means 5 bits of preemption and 32 preemption levels
    $1d constant GICH_PRIBITS                   \ [0x1d : 3] priority bits Indicates the number of priority bits implemented, minus one. For example, 0x4 means 5 bits of priority and 32 priority levels.
  [then]


  [ifdef] GICH_GICH_VMCR_DEF
    \
    \ @brief GICH virtual machine control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GICH_VMGRP0EN                  \ [0x00] alias of GICV_CTLR.ENABLEGRP0
    $01 constant GICH_VMGRP1EN                  \ [0x01] alias of GICV_CTLR.ENABLEGRP1
    $02 constant GICH_VMACKCTL                  \ [0x02] alias of GICV_CTLR.ACKCTL
    $03 constant GICH_VMFIQEN                   \ [0x03] alias of GICV_CTLR.FIQEN
    $04 constant GICH_VMCBPR                    \ [0x04] alias of GICV_CTLR.CBPR
    $09 constant GICH_VEM                       \ [0x09] alias of GICV_CTLR.EOIMODE
    $12 constant GICH_VMABP                     \ [0x12 : 3] alias of GICV_ABPR.BINARY_POINT.
    $15 constant GICH_VMBP                      \ [0x15 : 3] alias of GICV_BPR.BINARY_POINT
    $1b constant GICH_VMPRIMASK                 \ [0x1b : 5] alias of GICV_PMR.PRIORITY
  [then]


  [ifdef] GICH_GICH_MISR_DEF
    \
    \ @brief GICH maintenance interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GICH_EOI                       \ [0x00] End of interrupt maintenance interrupt Asserted whenever at least one list register is asserting an EOI Interrupt., which means at least one bit in GICH_EISRx=1.
    $01 constant GICH_U                         \ [0x01] underflow maintenance interrupt Asserted whenever GICH_HCR.UIE is set and if none, or only one, of the list register entries are marked as a valid interrupt, that is, if the corresponding GICH_LRx.STATE bits do not equal 0x0.
    $02 constant GICH_LRENP                     \ [0x02] list register entry not present maintenance interrupt Asserted whenever GICH_HCR.LRENPIE=1 and GICH_HCR.EOICOUNT is non-zero.
    $03 constant GICH_NP                        \ [0x03] no pending maintenance interrupt Asserted whenever GICH_HCR.NPIE=1 and no list register is in pending state.
    $04 constant GICH_VGRP0E                    \ [0x04] enabled group 0 maintenance interrupt Asserted whenever GICH_HCR.VGRP0EIE is set and GICH_VMCR.VMGRP0EN=1.
    $05 constant GICH_VGRP0D                    \ [0x05] disabled group 0 maintenance interrupt Asserted whenever GICH_HCR.VGRP0DIE is set and GICH_VMCR.VMGRP0EN=0.
    $06 constant GICH_VGRP1E                    \ [0x06] enabled group 1 maintenance interrupt Asserted whenever GICH_HCR.VGRP1EIE is set and GICH_VMCR.VMGRP1EN=1.
    $07 constant GICH_VGRP1D                    \ [0x07] disabled group 1 maintenance interrupt Asserted whenever GICH_HCR.VGRP1DIE is set and GICH_VMCR.VMGRP1EN=0.
  [then]


  [ifdef] GICH_GICH_EISR0_DEF
    \
    \ @brief GICH end of interrupt status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GICH_EISR0                     \ [0x00 : 32] end of interrupt status
  [then]


  [ifdef] GICH_GICH_ELSR0_DEF
    \
    \ @brief GICH empty list status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant GICH_ELSR0                     \ [0x00 : 32] empty list status
  [then]


  [ifdef] GICH_GICH_APR0_DEF
    \
    \ @brief active priority
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant GICH_APR0                      \ [0x00 : 32] active priority
  [then]


  [ifdef] GICH_GICH_LR0_DEF
    \
    \ @brief virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant GICH_VIRTUALID                 \ [0x00 : 10] virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
    $0a constant GICH_PHYSICALID                \ [0x0a : 10] physical ID The function of this bit depends on the value of the GICH_LR.HW bit, as follows. 1) When GICH_LR.HW is set to 0, bits [9:0] have the following meanings: - [19] EOI when this interrupt triggers an EOI maintenance interrupt - [12:10] CPUID If the interrupt has the VirtualID for an SGI, that is, 0-15. This field shows the requesting CPU ID. This appears in the relevant field of the virtual machine interrupt acknowledge register, GICV_IAR or GICV_AIAR. Otherwise, this field must be set to 0. 2) When GICH_LR.HW is set to 1, PHYSICALID[9:0] indicates the physical interrupt ID that the hypervisor forwards to the GICD. If the value of PHYSICALID is 0-15, or 1020-1023, behavior is unpredictable. If the value of PHYSICALID is 16-31, this field applies to the PPI associated with the same physical CPUID as the virtual CPU interface requesting the deactivation.
    $17 constant GICH_PRIORITY                  \ [0x17 : 5] priority of the interrupt
    $1c constant GICH_STATE                     \ [0x1c : 2] state of the interrupt
    $1e constant GICH_GRP1                      \ [0x1e] Indicates whether this virtual interrupt is a group 1 virtual interrupt
    $1f constant GICH_HW                        \ [0x1f] hardware interrupt Indicates whether this virtual interrupt is a hardware interrupt, meaning that it corresponds to a physical interrupt. Deactivation of the virtual interrupt also causes the deactivation of the physical interrupt with the ID that the PhysicalID field indicates.
  [then]


  [ifdef] GICH_GICH_LR1_DEF
    \
    \ @brief virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant GICH_VIRTUALID                 \ [0x00 : 10] virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
    $0a constant GICH_PHYSICALID                \ [0x0a : 10] physical ID The function of this bit depends on the value of the GICH_LR.HW bit, as follows. 1) When GICH_LR.HW is set to 0, bits [9:0] have the following meanings: - [19] EOI when this interrupt triggers an EOI maintenance interrupt - [12:10] CPUID If the interrupt has the VirtualID for an SGI, that is, 0-15. This field shows the requesting CPU ID. This appears in the relevant field of the virtual machine interrupt acknowledge register, GICV_IAR or GICV_AIAR. Otherwise, this field must be set to 0. 2) When GICH_LR.HW is set to 1, PHYSICALID[9:0] indicates the physical interrupt ID that the hypervisor forwards to the GICD. If the value of PHYSICALID is 0-15, or 1020-1023, behavior is unpredictable. If the value of PHYSICALID is 16-31, this field applies to the PPI associated with the same physical CPUID as the virtual CPU interface requesting the deactivation.
    $17 constant GICH_PRIORITY                  \ [0x17 : 5] priority of the interrupt
    $1c constant GICH_STATE                     \ [0x1c : 2] state of the interrupt
    $1e constant GICH_GRP1                      \ [0x1e] Indicates whether this virtual interrupt is a group 1 virtual interrupt
    $1f constant GICH_HW                        \ [0x1f] hardware interrupt Indicates whether this virtual interrupt is a hardware interrupt, meaning that it corresponds to a physical interrupt. Deactivation of the virtual interrupt also causes the deactivation of the physical interrupt with the ID that the PhysicalID field indicates.
  [then]


  [ifdef] GICH_GICH_LR2_DEF
    \
    \ @brief virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant GICH_VIRTUALID                 \ [0x00 : 10] virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
    $0a constant GICH_PHYSICALID                \ [0x0a : 10] physical ID The function of this bit depends on the value of the GICH_LR.HW bit, as follows. 1) When GICH_LR.HW is set to 0, bits [9:0] have the following meanings: - [19] EOI when this interrupt triggers an EOI maintenance interrupt - [12:10] CPUID If the interrupt has the VirtualID for an SGI, that is, 0-15. This field shows the requesting CPU ID. This appears in the relevant field of the virtual machine interrupt acknowledge register, GICV_IAR or GICV_AIAR. Otherwise, this field must be set to 0. 2) When GICH_LR.HW is set to 1, PHYSICALID[9:0] indicates the physical interrupt ID that the hypervisor forwards to the GICD. If the value of PHYSICALID is 0-15, or 1020-1023, behavior is unpredictable. If the value of PHYSICALID is 16-31, this field applies to the PPI associated with the same physical CPUID as the virtual CPU interface requesting the deactivation.
    $17 constant GICH_PRIORITY                  \ [0x17 : 5] priority of the interrupt
    $1c constant GICH_STATE                     \ [0x1c : 2] state of the interrupt
    $1e constant GICH_GRP1                      \ [0x1e] Indicates whether this virtual interrupt is a group 1 virtual interrupt
    $1f constant GICH_HW                        \ [0x1f] hardware interrupt Indicates whether this virtual interrupt is a hardware interrupt, meaning that it corresponds to a physical interrupt. Deactivation of the virtual interrupt also causes the deactivation of the physical interrupt with the ID that the PhysicalID field indicates.
  [then]


  [ifdef] GICH_GICH_LR3_DEF
    \
    \ @brief virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant GICH_VIRTUALID                 \ [0x00 : 10] virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
    $0a constant GICH_PHYSICALID                \ [0x0a : 10] physical ID The function of this bit depends on the value of the GICH_LR.HW bit, as follows. 1) When GICH_LR.HW is set to 0, bits [9:0] have the following meanings: - [19] EOI when this interrupt triggers an EOI maintenance interrupt - [12:10] CPUID If the interrupt has the VirtualID for an SGI, that is, 0-15. This field shows the requesting CPU ID. This appears in the relevant field of the virtual machine interrupt acknowledge register, GICV_IAR or GICV_AIAR. Otherwise, this field must be set to 0. 2) When GICH_LR.HW is set to 1, PHYSICALID[9:0] indicates the physical interrupt ID that the hypervisor forwards to the GICD. If the value of PHYSICALID is 0-15, or 1020-1023, behavior is unpredictable. If the value of PHYSICALID is 16-31, this field applies to the PPI associated with the same physical CPUID as the virtual CPU interface requesting the deactivation.
    $17 constant GICH_PRIORITY                  \ [0x17 : 5] priority of the interrupt
    $1c constant GICH_STATE                     \ [0x1c : 2] state of the interrupt
    $1e constant GICH_GRP1                      \ [0x1e] Indicates whether this virtual interrupt is a group 1 virtual interrupt
    $1f constant GICH_HW                        \ [0x1f] hardware interrupt Indicates whether this virtual interrupt is a hardware interrupt, meaning that it corresponds to a physical interrupt. Deactivation of the virtual interrupt also causes the deactivation of the physical interrupt with the ID that the PhysicalID field indicates.
  [then]

  \
  \ @brief GICH address block description
  \
  $00 constant GICH_GICH_HCR            \ GICH hypervisor control register
  $04 constant GICH_GICH_VTR            \ list registers Indicates the number of implemented list registers, minus one. For example, 0x3 means 4 list registers.
  $08 constant GICH_GICH_VMCR           \ GICH virtual machine control register
  $10 constant GICH_GICH_MISR           \ GICH maintenance interrupt status register
  $20 constant GICH_GICH_EISR0          \ GICH end of interrupt status register
  $30 constant GICH_GICH_ELSR0          \ GICH empty list status register
  $F0 constant GICH_GICH_APR0           \ active priority
  $100 constant GICH_GICH_LR0           \ virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
  $104 constant GICH_GICH_LR1           \ virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
  $108 constant GICH_GICH_LR2           \ virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
  $10C constant GICH_GICH_LR3           \ virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.

: GICH_DEF ; [then]
