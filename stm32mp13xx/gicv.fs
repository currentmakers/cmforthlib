\
\ @file gicv.fs
\ @brief GICV address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GICV_DEF

  [ifdef] GICV_GICV_CTLR_DEF
    \
    \ @brief GICV virtual machine control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GICV_ENABLEGRP0                \ [0x00] Enables the signaling of group 0 virtual interrupts by the virtual CPU interface to the virtual machine.
    $01 constant GICV_ENABLEGRP1                \ [0x01] Enables the signaling of group 1 virtual interrupts by the virtual CPU interface to the virtual machine.
    $02 constant GICV_ACKCTL                    \ [0x02] acknowledge control Controls whether a read of the GICV_IAR, when the highest priority pending interrupt is a group 1 interrupt, causes the CPU interface to acknowledge the interrupt. Arm deprecates use of this bit. Arm strongly recommends that software is written to operate with this bit always set to 0.
    $03 constant GICV_FIQEN                     \ [0x03] FIQ enable for group 0 interrupts Controls whether interrupts marked as group 0 are presented as virtual FIQs.
    $04 constant GICV_CBPR                      \ [0x04] BPR control Controls whether the GICV_BPR controls both group 0 and group 1 virtual interrupts.
    $09 constant GICV_EOIMODE                   \ [0x09] end of interrupt mode Controls the behavior associated with the GICV_EOIR, GICV_AEOIR, and GICV_DIR registers.
  [then]


  [ifdef] GICV_GICV_PMR_DEF
    \
    \ @brief GICV VM priority mask register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant GICV_PRIORITY                  \ [0x03 : 5] priority mask level for the virtual CPU interface Only virtual interrupts with higher priority than the value in this register can be signaled to the processor
  [then]


  [ifdef] GICV_GICV_BPR_DEF
    \
    \ @brief GICV VM binary point register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GICV_BINARY_POINT              \ [0x00 : 3] The value of this field controls how the 8-bit virtual interrupt priority field is split into a group priority field, used to determine virtual interrupt preemption, and a subpriority field. Minimun value is 2.
  [then]


  [ifdef] GICV_GICV_IAR_DEF
    \
    \ @brief GICV VM interrupt acknowledge register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GICV_INTERRUPT_ID              \ [0x00 : 10] The interrupt ID
    $0a constant GICV_CPUID                     \ [0x0a] If the GICH_LRx.HW bit is set to 0, indicating that the interrupt is triggered in software, then CPUID of the GICH_LRx, that indicate the CPU ID, are returned in the GICV_IAR.CPUID field. Otherwise GICV_IAR.CPUID field reads as zero.
  [then]


  [ifdef] GICV_GICV_EOIR_DEF
    \
    \ @brief If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GICV_EOIINTID                  \ [0x00 : 10] If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
    $0a constant GICV_CPUID                     \ [0x0a] On a multiprocessor implementation, if the write refers to an SGI, this field contains the CPUID value from the corresponding GICV_IAR access.
  [then]


  [ifdef] GICV_GICV_RPR_DEF
    \
    \ @brief GICV VM running priority register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $03 constant GICV_PRIORITY                  \ [0x03 : 5] current running priority on the virtual CPU interface
  [then]


  [ifdef] GICV_GICV_HPPIR_DEF
    \
    \ @brief GICV VM highest priority pending interrupt register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GICV_PENDINTID                 \ [0x00 : 10] The virtual interrupt ID of the highest priority pending virtual interrupt
    $0a constant GICV_CPUID                     \ [0x0a] On a multiprocessor implementation, if GICH_LRx.HW bit=0, this field contains the CPUID value for that virtual interrupt. This identifies the virtual processor that generated the virtual interrupt.
  [then]


  [ifdef] GICV_GICV_ABPR_DEF
    \
    \ @brief GICV VM aliased binary point register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GICV_BINARY_POINT              \ [0x00 : 3] The value of this field controls how the 8-bit virtual interrupt priority field is split into a group priority field, used to determine virtual interrupt preemption, and a subpriority field. Minimun value is 3.
  [then]


  [ifdef] GICV_GICV_AIAR_DEF
    \
    \ @brief GICV VM aliased interrupt register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GICV_INTERRUPT_ID              \ [0x00 : 10] The interrupt ID. If the GICH_LRx.Grp1 bit is 0, the interrupt is Group 0. The spurious interrupt ID 1023 is returned and the interrupt is not acknowledged.
    $0a constant GICV_CPUID                     \ [0x0a] If the GICH_LRx.HW bit is set to 0, indicating that the interrupt is triggered in software, then CPUID of the GICH_LRx, that indicate the CPU ID, are returned in the GICV_AIAR.CPUID field. Otherwise GICV_AIAR.CPUID field reads as zero..
  [then]


  [ifdef] GICV_GICV_AEOIR_DEF
    \
    \ @brief If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GICV_EOIINTID                  \ [0x00 : 10] If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
    $0a constant GICV_CPUID                     \ [0x0a] On a multiprocessor implementation, if the write refers to an SGI, this field contains the CPUID value from the corresponding GICV_IAR access.
  [then]


  [ifdef] GICV_GICV_AHPPIR_DEF
    \
    \ @brief GICV VM aliased highest priority pending interrupt register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GICV_PENDINTID                 \ [0x00 : 10] The virtual interrupt ID of the highest-priority pending virtual interrupt, if that virtual interrupt is a group 1 virtual interrupt. Otherwise, the spurious virtual interrupt ID, 1023.
    $0a constant GICV_CPUID                     \ [0x0a] If the GICH_LRx.HW bit in the matching List register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the physical ID from the corresponding field in the List register.
  [then]


  [ifdef] GICV_GICV_APR0_DEF
    \
    \ @brief GICV VM active priority register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant GICV_APR0                      \ [0x00 : 32] active priority
  [then]


  [ifdef] GICV_GICV_IIDR_DEF
    \
    \ @brief GICV VM CPU interface identification register
    \ Address offset: 0xFC
    \ Reset value: 0x0102143B
    \
    $00 constant GICV_IIDR                      \ [0x00 : 32] see description of GICC_IIDR register
  [then]


  [ifdef] GICV_GICV_DIR_DEF
    \
    \ @brief The interrupt ID
    \ Address offset: 0x1000
    \ Reset value: 0x00000000
    \
    $00 constant GICV_INTERRUPT_ID              \ [0x00 : 10] The interrupt ID
    $0a constant GICV_CPUID                     \ [0x0a] This field identifies the processor that requested the interrupt.
  [then]

  \
  \ @brief GICV address block description
  \
  $00 constant GICV_GICV_CTLR           \ GICV virtual machine control register
  $04 constant GICV_GICV_PMR            \ GICV VM priority mask register
  $08 constant GICV_GICV_BPR            \ GICV VM binary point register
  $0C constant GICV_GICV_IAR            \ GICV VM interrupt acknowledge register
  $10 constant GICV_GICV_EOIR           \ If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
  $14 constant GICV_GICV_RPR            \ GICV VM running priority register
  $18 constant GICV_GICV_HPPIR          \ GICV VM highest priority pending interrupt register
  $1C constant GICV_GICV_ABPR           \ GICV VM aliased binary point register
  $20 constant GICV_GICV_AIAR           \ GICV VM aliased interrupt register
  $24 constant GICV_GICV_AEOIR          \ If the GICH_LRx.HW bit in the matching list register is set to 1, indicating a hardware interrupt, then a deactivate request is sent to the physical Distributor, identifying the Physical ID from the corresponding field in the list register.
  $28 constant GICV_GICV_AHPPIR         \ GICV VM aliased highest priority pending interrupt register
  $D0 constant GICV_GICV_APR0           \ GICV VM active priority register
  $FC constant GICV_GICV_IIDR           \ GICV VM CPU interface identification register
  $1000 constant GICV_GICV_DIR          \ The interrupt ID

: GICV_DEF ; [then]
