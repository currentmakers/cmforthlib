\
\ @file gicv.fs
\ @brief GICV address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GICV virtual machine control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GICV_GICV_CTLR_ENABLEGRP0                        \ Enables the signaling of group 0 virtual interrupts by the virtual CPU interface to the virtual machine.
$00000002 constant GICV_GICV_CTLR_ENABLEGRP1                        \ Enables the signaling of group 1 virtual interrupts by the virtual CPU interface to the virtual machine.
$00000004 constant GICV_GICV_CTLR_ACKCTL                            \ acknowledge control Controls whether a read of the GICV_IAR, when the highest priority pending interrupt is a group 1 interrupt, causes the CPU interface to acknowledge the interrupt. Arm deprecates use of this bit. Arm strongly recommends that software is written to operate with this bit always set to 0.
$00000008 constant GICV_GICV_CTLR_FIQEN                             \ FIQ enable for group 0 interrupts Controls whether interrupts marked as group 0 are presented as virtual FIQs.
$00000010 constant GICV_GICV_CTLR_CBPR                              \ BPR control Controls whether the GICV_BPR controls both group 0 and group 1 virtual interrupts.
$00000200 constant GICV_GICV_CTLR_EOIMODE                           \ end of interrupt mode Controls the behavior associated with the GICV_EOIR, GICV_AEOIR, and GICV_DIR registers.


\
\ @brief GICV VM priority mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000f8 constant GICV_GICV_PMR_PRIORITY                           \ priority mask level for the virtual CPU interface Only virtual interrupts with higher priority than the value in this register can be signaled to the processor


\
\ @brief GICV VM binary point register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant GICV_GICV_BPR_BINARY_POINT                       \ The value of this field controls how the 8-bit virtual interrupt priority field is split into a group priority field, used to determine virtual interrupt preemption, and a subpriority field. Minimun value is 2.


\
\ @brief GICV VM interrupt acknowledge register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_IAR_INTERRUPT_ID                       \ The interrupt ID
$00000400 constant GICV_GICV_IAR_CPUID                              \ If the GICH_LRx.HW bit is set to 0, indicating that the interrupt is triggered in software, then CPUID of the GICH_LRx, that indicate the CPU ID, are returned in the GICV_IAR.CPUID field. Otherwise GICV_IAR.CPUID field reads as zero.


\
\ @brief If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_EOIR_EOIINTID                          \ If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
$00000400 constant GICV_GICV_EOIR_CPUID                             \ On a multiprocessor implementation, if the write refers to an SGI, this field contains the CPUID value from the corresponding GICV_IAR access.


\
\ @brief GICV VM running priority register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000f8 constant GICV_GICV_RPR_PRIORITY                           \ current running priority on the virtual CPU interface


\
\ @brief GICV VM highest priority pending interrupt register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_HPPIR_PENDINTID                        \ The virtual interrupt ID of the highest priority pending virtual interrupt
$00000400 constant GICV_GICV_HPPIR_CPUID                            \ On a multiprocessor implementation, if GICH_LRx.HW bit=0, this field contains the CPUID value for that virtual interrupt. This identifies the virtual processor that generated the virtual interrupt.


\
\ @brief GICV VM aliased binary point register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000007 constant GICV_GICV_ABPR_BINARY_POINT                      \ The value of this field controls how the 8-bit virtual interrupt priority field is split into a group priority field, used to determine virtual interrupt preemption, and a subpriority field. Minimun value is 3.


\
\ @brief GICV VM aliased interrupt register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_AIAR_INTERRUPT_ID                      \ The interrupt ID. If the GICH_LRx.Grp1 bit is 0, the interrupt is Group 0. The spurious interrupt ID 1023 is returned and the interrupt is not acknowledged.
$00000400 constant GICV_GICV_AIAR_CPUID                             \ If the GICH_LRx.HW bit is set to 0, indicating that the interrupt is triggered in software, then CPUID of the GICH_LRx, that indicate the CPU ID, are returned in the GICV_AIAR.CPUID field. Otherwise GICV_AIAR.CPUID field reads as zero..


\
\ @brief If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_AEOIR_EOIINTID                         \ If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
$00000400 constant GICV_GICV_AEOIR_CPUID                            \ On a multiprocessor implementation, if the write refers to an SGI, this field contains the CPUID value from the corresponding GICV_IAR access.


\
\ @brief GICV VM aliased highest priority pending interrupt register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_AHPPIR_PENDINTID                       \ The virtual interrupt ID of the highest-priority pending virtual interrupt, if that virtual interrupt is a group 1 virtual interrupt. Otherwise, the spurious virtual interrupt ID, 1023.
$00000400 constant GICV_GICV_AHPPIR_CPUID                           \ If the GICH_LRx.HW bit in the matching List register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the physical ID from the corresponding field in the List register.


\
\ @brief GICV VM active priority register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000000 constant GICV_GICV_APR0_APR0                              \ active priority


\
\ @brief GICV VM CPU interface identification register
\ Address offset: 0xFC
\ Reset value: 0x0102143B
\

$00000000 constant GICV_GICV_IIDR_IIDR                              \ see description of GICC_IIDR register


\
\ @brief The interrupt ID
\ Address offset: 0x1000
\ Reset value: 0x00000000
\

$000003ff constant GICV_GICV_DIR_INTERRUPT_ID                       \ The interrupt ID
$00000400 constant GICV_GICV_DIR_CPUID                              \ This field identifies the processor that requested the interrupt.


\
\ @brief GICV address block description
\
$a0026000 constant GICV_GICV_CTLR  \ offset: 0x00 : GICV virtual machine control register
$a0026004 constant GICV_GICV_PMR  \ offset: 0x04 : GICV VM priority mask register
$a0026008 constant GICV_GICV_BPR  \ offset: 0x08 : GICV VM binary point register
$a002600c constant GICV_GICV_IAR  \ offset: 0x0C : GICV VM interrupt acknowledge register
$a0026010 constant GICV_GICV_EOIR  \ offset: 0x10 : If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
$a0026014 constant GICV_GICV_RPR  \ offset: 0x14 : GICV VM running priority register
$a0026018 constant GICV_GICV_HPPIR  \ offset: 0x18 : GICV VM highest priority pending interrupt register
$a002601c constant GICV_GICV_ABPR  \ offset: 0x1C : GICV VM aliased binary point register
$a0026020 constant GICV_GICV_AIAR  \ offset: 0x20 : GICV VM aliased interrupt register
$a0026024 constant GICV_GICV_AEOIR  \ offset: 0x24 : If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
$a0026028 constant GICV_GICV_AHPPIR  \ offset: 0x28 : GICV VM aliased highest priority pending interrupt register
$a00260d0 constant GICV_GICV_APR0  \ offset: 0xD0 : GICV VM active priority register
$a00260fc constant GICV_GICV_IIDR  \ offset: 0xFC : GICV VM CPU interface identification register
$a0027000 constant GICV_GICV_DIR  \ offset: 0x1000 : The interrupt ID

