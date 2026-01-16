\
\ @file gich.fs
\ @brief GICH address block description
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

$00000001 constant GICH_GICH_HCR_EN                                 \ global enable bit for the virtual CPU interface
$00000002 constant GICH_GICH_HCR_UIE                                \ underflow interrupt enable. Enables the signaling of a maintenance interrupt when the list registers are empty, or hold only one valid entry.
$00000004 constant GICH_GICH_HCR_LRENPIE                            \ list register entry not present interrupt enable Enables the signaling of a maintenance interrupt while the virtual CPU interface does not have a corresponding valid list register entry for an EOI request.
$00000008 constant GICH_GICH_HCR_NPIE                               \ no pending interrupt enable Enables the signaling of a maintenance interrupt while no pending interrupts are present in the list registers.
$00000010 constant GICH_GICH_HCR_VGRP0EIE                           \ virtual machine enable group 0interrupt enable Enables the signaling of a maintenance interrupt while signaling of group 0interrupts from the virtual CPU interface to the connected virtual machine, is enabled.
$00000020 constant GICH_GICH_HCR_VGRP0DIE                           \ virtual machine disable group 0interrupt enable Enables the signaling of a maintenance interrupt while signaling of group 0interrupts from the virtual CPU interface to the connected virtual machine, is disabled.
$00000040 constant GICH_GICH_HCR_VGRP1EIE                           \ virtual machine enable group 1 interrupt enable Enables the signaling of a maintenance interrupt while signaling of group 1 interrupts from the virtual CPU interface to the connected virtual machine, is enabled.
$00000080 constant GICH_GICH_HCR_VGRP1DIE                           \ virtual machine disable group 1 interrupt enable Enables the signaling of a maintenance interrupt while signaling of group 1 interrupts from the virtual CPU interface to the connected virtual machine, is disabled.
$f8000000 constant GICH_GICH_HCR_EOICOUNT                           \ end-of-interrupt counter Counts the number of EOIs received that do not have a corresponding entry in the list registers. The virtual CPU interface increments this field automatically when a matching EOI is received. When EOIs that do not clear a bit in the active priorities register, GICH_APR does not cause an increment. Although not possible under correct operation, if an EOI occurs when the value of this field is 31, this field wraps to 0. The maintenance interrupt is asserted whenever this field is non-zero and the LRENPIE bit is set to 1.


\
\ @brief list registers Indicates the number of implemented list registers, minus one. For example, 0x3 means 4 list registers.
\ Address offset: 0x04
\ Reset value: 0x90000003
\

$0000001f constant GICH_GICH_VTR_LISTREGS                           \ list registers Indicates the number of implemented list registers, minus one. For example, 0x3 means 4 list registers.
$1c000000 constant GICH_GICH_VTR_PREBITS                            \ preemption bits Indicates the number of preemption bits implemented, minus one. For example, 0x4 means 5 bits of preemption and 32 preemption levels
$e0000000 constant GICH_GICH_VTR_PRIBITS                            \ priority bits Indicates the number of priority bits implemented, minus one. For example, 0x4 means 5 bits of priority and 32 priority levels.


\
\ @brief GICH virtual machine control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant GICH_GICH_VMCR_VMGRP0EN                          \ alias of GICV_CTLR.ENABLEGRP0
$00000002 constant GICH_GICH_VMCR_VMGRP1EN                          \ alias of GICV_CTLR.ENABLEGRP1
$00000004 constant GICH_GICH_VMCR_VMACKCTL                          \ alias of GICV_CTLR.ACKCTL
$00000008 constant GICH_GICH_VMCR_VMFIQEN                           \ alias of GICV_CTLR.FIQEN
$00000010 constant GICH_GICH_VMCR_VMCBPR                            \ alias of GICV_CTLR.CBPR
$00000200 constant GICH_GICH_VMCR_VEM                               \ alias of GICV_CTLR.EOIMODE
$001c0000 constant GICH_GICH_VMCR_VMABP                             \ alias of GICV_ABPR.BINARY_POINT.
$00e00000 constant GICH_GICH_VMCR_VMBP                              \ alias of GICV_BPR.BINARY_POINT
$f8000000 constant GICH_GICH_VMCR_VMPRIMASK                         \ alias of GICV_PMR.PRIORITY


\
\ @brief GICH maintenance interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GICH_GICH_MISR_EOI                               \ End of interrupt maintenance interrupt Asserted whenever at least one list register is asserting an EOI Interrupt., which means at least one bit in GICH_EISRx=1.
$00000002 constant GICH_GICH_MISR_U                                 \ underflow maintenance interrupt Asserted whenever GICH_HCR.UIE is set and if none, or only one, of the list register entries are marked as a valid interrupt, that is, if the corresponding GICH_LRx.STATE bits do not equal 0x0.
$00000004 constant GICH_GICH_MISR_LRENP                             \ list register entry not present maintenance interrupt Asserted whenever GICH_HCR.LRENPIE=1 and GICH_HCR.EOICOUNT is non-zero.
$00000008 constant GICH_GICH_MISR_NP                                \ no pending maintenance interrupt Asserted whenever GICH_HCR.NPIE=1 and no list register is in pending state.
$00000010 constant GICH_GICH_MISR_VGRP0E                            \ enabled group 0 maintenance interrupt Asserted whenever GICH_HCR.VGRP0EIE is set and GICH_VMCR.VMGRP0EN=1.
$00000020 constant GICH_GICH_MISR_VGRP0D                            \ disabled group 0 maintenance interrupt Asserted whenever GICH_HCR.VGRP0DIE is set and GICH_VMCR.VMGRP0EN=0.
$00000040 constant GICH_GICH_MISR_VGRP1E                            \ enabled group 1 maintenance interrupt Asserted whenever GICH_HCR.VGRP1EIE is set and GICH_VMCR.VMGRP1EN=1.
$00000080 constant GICH_GICH_MISR_VGRP1D                            \ disabled group 1 maintenance interrupt Asserted whenever GICH_HCR.VGRP1DIE is set and GICH_VMCR.VMGRP1EN=0.


\
\ @brief GICH end of interrupt status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant GICH_GICH_EISR0_EISR0                            \ end of interrupt status


\
\ @brief GICH empty list status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant GICH_GICH_ELSR0_ELSR0                            \ empty list status


\
\ @brief active priority
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000000 constant GICH_GICH_APR0_APR0                              \ active priority


\
\ @brief virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$000003ff constant GICH_GICH_LR0_VIRTUALID                          \ virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
$000ffc00 constant GICH_GICH_LR0_PHYSICALID                         \ physical ID The function of this bit depends on the value of the GICH_LR.HW bit, as follows. 1) When GICH_LR.HW is set to 0, bits [9:0] have the following meanings: - [19] EOI when this interrupt triggers an EOI maintenance interrupt - [12:10] CPUID If the interrupt has the VirtualID for an SGI, that is, 0-15. This field shows the requesting CPU ID. This appears in the relevant field of the virtual machine interrupt acknowledge register, GICV_IAR or GICV_AIAR. Otherwise, this field must be set to 0. 2) When GICH_LR.HW is set to 1, PHYSICALID[9:0] indicates the physical interrupt ID that the hypervisor forwards to the GICD. If the value of PHYSICALID is 0-15, or 1020-1023, behavior is unpredictable. If the value of PHYSICALID is 16-31, this field applies to the PPI associated with the same physical CPUID as the virtual CPU interface requesting the deactivation.
$0f800000 constant GICH_GICH_LR0_PRIORITY                           \ priority of the interrupt
$30000000 constant GICH_GICH_LR0_STATE                              \ state of the interrupt
$40000000 constant GICH_GICH_LR0_GRP1                               \ Indicates whether this virtual interrupt is a group 1 virtual interrupt
$80000000 constant GICH_GICH_LR0_HW                                 \ hardware interrupt Indicates whether this virtual interrupt is a hardware interrupt, meaning that it corresponds to a physical interrupt. Deactivation of the virtual interrupt also causes the deactivation of the physical interrupt with the ID that the PhysicalID field indicates.


\
\ @brief virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$000003ff constant GICH_GICH_LR1_VIRTUALID                          \ virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
$000ffc00 constant GICH_GICH_LR1_PHYSICALID                         \ physical ID The function of this bit depends on the value of the GICH_LR.HW bit, as follows. 1) When GICH_LR.HW is set to 0, bits [9:0] have the following meanings: - [19] EOI when this interrupt triggers an EOI maintenance interrupt - [12:10] CPUID If the interrupt has the VirtualID for an SGI, that is, 0-15. This field shows the requesting CPU ID. This appears in the relevant field of the virtual machine interrupt acknowledge register, GICV_IAR or GICV_AIAR. Otherwise, this field must be set to 0. 2) When GICH_LR.HW is set to 1, PHYSICALID[9:0] indicates the physical interrupt ID that the hypervisor forwards to the GICD. If the value of PHYSICALID is 0-15, or 1020-1023, behavior is unpredictable. If the value of PHYSICALID is 16-31, this field applies to the PPI associated with the same physical CPUID as the virtual CPU interface requesting the deactivation.
$0f800000 constant GICH_GICH_LR1_PRIORITY                           \ priority of the interrupt
$30000000 constant GICH_GICH_LR1_STATE                              \ state of the interrupt
$40000000 constant GICH_GICH_LR1_GRP1                               \ Indicates whether this virtual interrupt is a group 1 virtual interrupt
$80000000 constant GICH_GICH_LR1_HW                                 \ hardware interrupt Indicates whether this virtual interrupt is a hardware interrupt, meaning that it corresponds to a physical interrupt. Deactivation of the virtual interrupt also causes the deactivation of the physical interrupt with the ID that the PhysicalID field indicates.


\
\ @brief virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$000003ff constant GICH_GICH_LR2_VIRTUALID                          \ virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
$000ffc00 constant GICH_GICH_LR2_PHYSICALID                         \ physical ID The function of this bit depends on the value of the GICH_LR.HW bit, as follows. 1) When GICH_LR.HW is set to 0, bits [9:0] have the following meanings: - [19] EOI when this interrupt triggers an EOI maintenance interrupt - [12:10] CPUID If the interrupt has the VirtualID for an SGI, that is, 0-15. This field shows the requesting CPU ID. This appears in the relevant field of the virtual machine interrupt acknowledge register, GICV_IAR or GICV_AIAR. Otherwise, this field must be set to 0. 2) When GICH_LR.HW is set to 1, PHYSICALID[9:0] indicates the physical interrupt ID that the hypervisor forwards to the GICD. If the value of PHYSICALID is 0-15, or 1020-1023, behavior is unpredictable. If the value of PHYSICALID is 16-31, this field applies to the PPI associated with the same physical CPUID as the virtual CPU interface requesting the deactivation.
$0f800000 constant GICH_GICH_LR2_PRIORITY                           \ priority of the interrupt
$30000000 constant GICH_GICH_LR2_STATE                              \ state of the interrupt
$40000000 constant GICH_GICH_LR2_GRP1                               \ Indicates whether this virtual interrupt is a group 1 virtual interrupt
$80000000 constant GICH_GICH_LR2_HW                                 \ hardware interrupt Indicates whether this virtual interrupt is a hardware interrupt, meaning that it corresponds to a physical interrupt. Deactivation of the virtual interrupt also causes the deactivation of the physical interrupt with the ID that the PhysicalID field indicates.


\
\ @brief virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$000003ff constant GICH_GICH_LR3_VIRTUALID                          \ virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
$000ffc00 constant GICH_GICH_LR3_PHYSICALID                         \ physical ID The function of this bit depends on the value of the GICH_LR.HW bit, as follows. 1) When GICH_LR.HW is set to 0, bits [9:0] have the following meanings: - [19] EOI when this interrupt triggers an EOI maintenance interrupt - [12:10] CPUID If the interrupt has the VirtualID for an SGI, that is, 0-15. This field shows the requesting CPU ID. This appears in the relevant field of the virtual machine interrupt acknowledge register, GICV_IAR or GICV_AIAR. Otherwise, this field must be set to 0. 2) When GICH_LR.HW is set to 1, PHYSICALID[9:0] indicates the physical interrupt ID that the hypervisor forwards to the GICD. If the value of PHYSICALID is 0-15, or 1020-1023, behavior is unpredictable. If the value of PHYSICALID is 16-31, this field applies to the PPI associated with the same physical CPUID as the virtual CPU interface requesting the deactivation.
$0f800000 constant GICH_GICH_LR3_PRIORITY                           \ priority of the interrupt
$30000000 constant GICH_GICH_LR3_STATE                              \ state of the interrupt
$40000000 constant GICH_GICH_LR3_GRP1                               \ Indicates whether this virtual interrupt is a group 1 virtual interrupt
$80000000 constant GICH_GICH_LR3_HW                                 \ hardware interrupt Indicates whether this virtual interrupt is a hardware interrupt, meaning that it corresponds to a physical interrupt. Deactivation of the virtual interrupt also causes the deactivation of the physical interrupt with the ID that the PhysicalID field indicates.


\
\ @brief GICH address block description
\
$a0024000 constant GICH_GICH_HCR  \ offset: 0x00 : GICH hypervisor control register
$a0024004 constant GICH_GICH_VTR  \ offset: 0x04 : list registers Indicates the number of implemented list registers, minus one. For example, 0x3 means 4 list registers.
$a0024008 constant GICH_GICH_VMCR  \ offset: 0x08 : GICH virtual machine control register
$a0024010 constant GICH_GICH_MISR  \ offset: 0x10 : GICH maintenance interrupt status register
$a0024020 constant GICH_GICH_EISR0  \ offset: 0x20 : GICH end of interrupt status register
$a0024030 constant GICH_GICH_ELSR0  \ offset: 0x30 : GICH empty list status register
$a00240f0 constant GICH_GICH_APR0  \ offset: 0xF0 : active priority
$a0024100 constant GICH_GICH_LR0  \ offset: 0x100 : virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
$a0024104 constant GICH_GICH_LR1  \ offset: 0x104 : virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
$a0024108 constant GICH_GICH_LR2  \ offset: 0x108 : virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.
$a002410c constant GICH_GICH_LR3  \ offset: 0x10C : virtual ID This ID is returned to the guest OS when the interrupt is acknowledged through the VM interrupt acknowledge register, GICV_IAR. Each valid interrupt stored in the list registers must have a unique virtual ID for that virtual CPU interface. If the value of VIRTUALID is 1020-1023, behavior is unpredictable.

