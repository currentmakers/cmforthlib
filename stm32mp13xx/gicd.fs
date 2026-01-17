\
\ @file gicd.fs
\ @brief GICD address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GICD_DEF

  [ifdef] GICD_GICD_CTLR_DEF
    \
    \ @brief GICD_CTLR
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ENABLEGRP0                \ [0x00] enable group 1 interrupts Global enable for forwarding pending group 1 interrupts from the GICD to the CPU interfaces
    $01 constant GICD_ENABLEGRP1                \ [0x01] enable group 1 interrupts Global enable for forwarding pending group 1 interrupts from the GICD to the CPU interfaces
  [then]


  [ifdef] GICD_GICD_CTLRNS_DEF
    \
    \ @brief GICD_CTLRNS
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ENABLE                    \ [0x00] Global enable for forwarding pending group 1 interrupts from the GICD to the CPU interfaces
    $01 constant GICD_ENABLEGRP1                \ [0x01] enable group 1 interrupts Global enable for forwarding pending group 1 interrupts from the GICD to the CPU interfaces
  [then]


  [ifdef] GICD_GICD_TYPER_DEF
    \
    \ @brief number of interrupt lines Indicates the number of interrupts that the GIC supports (0b00101 = Up to 192 interrupts, 160 external interrupts)
    \ Address offset: 0x04
    \ Reset value: 0x0000FC05
    \
    $00 constant GICD_ITLINESNUMBER             \ [0x00 : 5] number of interrupt lines Indicates the number of interrupts that the GIC supports (0b00101 = Up to 192 interrupts, 160 external interrupts)
    $05 constant GICD_CPUNUMBER                 \ [0x05 : 3] number of processors interfaces Indicates the number of implemented processors interfaces in the GIC (0b000 = 1 processor)
    $0a constant GICD_SECURITYEXTN              \ [0x0a] security extension Indicates whether the GIC implements the security extensions. This bit always returns a value of 1, indicating that the security extensions are implemented.
    $0b constant GICD_LSPI                      \ [0x0b : 5] lockable shared peripheral interrupt Returns the number of LSPIs that the interrupt controller contains (0b1111 = 31 LSPIs, these are the interrupts of IDs 32-62).
  [then]


  [ifdef] GICD_GICD_IIDR_DEF
    \
    \ @brief GIC implementer (0x43B Arm implementation)
    \ Address offset: 0x08
    \ Reset value: 0x0100143B
    \
    $00 constant GICD_IMPLEMENTER               \ [0x00 : 12] GIC implementer (0x43B Arm implementation)
    $0c constant GICD_REVISION                  \ [0x0c : 4] Indicates the minor revision number of the GIC
    $10 constant GICD_VARIANT                   \ [0x10 : 4] Indicates the major revision number of the GIC
    $18 constant GICD_PRODUCTID                 \ [0x18 : 8] product ID of the GIC
  [then]


  [ifdef] GICD_GICD_IGROUPR0_DEF
    \
    \ @brief GICD interrupt group register 0
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPRx                  \ [0x00 : 32] group of interrupts
  [then]


  [ifdef] GICD_GICD_IGROUPR1_DEF
    \
    \ @brief GICD interrupt group register 1
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPRx                  \ [0x00 : 32] group of interrupts
  [then]


  [ifdef] GICD_GICD_IGROUPR2_DEF
    \
    \ @brief GICD interrupt group register 2
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPRx                  \ [0x00 : 32] group of interrupts
  [then]


  [ifdef] GICD_GICD_IGROUPR3_DEF
    \
    \ @brief GICD interrupt group register 3
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPRx                  \ [0x00 : 32] group of interrupts
  [then]


  [ifdef] GICD_GICD_IGROUPR4_DEF
    \
    \ @brief GICD interrupt group register 4
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPRx                  \ [0x00 : 32] group of interrupts
  [then]


  [ifdef] GICD_GICD_IGROUPR5_DEF
    \
    \ @brief GICD interrupt group register 5
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPRx                  \ [0x00 : 32] group of interrupts
  [then]


  [ifdef] GICD_GICD_ISENABLER0_DEF
    \
    \ @brief GICD interrupt set-enable register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLER0                \ [0x00 : 32] interrupt set-enable 0
  [then]


  [ifdef] GICD_GICD_ISENABLER1_DEF
    \
    \ @brief GICD interrupt set-enable register 1
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLERx                \ [0x00 : 32] interrupt set-enable x
  [then]


  [ifdef] GICD_GICD_ISENABLER2_DEF
    \
    \ @brief GICD interrupt set-enable register 2
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLERx                \ [0x00 : 32] interrupt set-enable x
  [then]


  [ifdef] GICD_GICD_ISENABLER3_DEF
    \
    \ @brief GICD interrupt set-enable register 3
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLERx                \ [0x00 : 32] interrupt set-enable x
  [then]


  [ifdef] GICD_GICD_ISENABLER4_DEF
    \
    \ @brief GICD interrupt set-enable register 4
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLERx                \ [0x00 : 32] interrupt set-enable x
  [then]


  [ifdef] GICD_GICD_ISENABLER5_DEF
    \
    \ @brief GICD interrupt set-enable register 5
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLERx                \ [0x00 : 32] interrupt set-enable x
  [then]


  [ifdef] GICD_GICD_ICENABLER0_DEF
    \
    \ @brief GICD interrupt clear-enable register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLER0                \ [0x00 : 32] interrupt clear-enable 0
  [then]


  [ifdef] GICD_GICD_ICENABLER1_DEF
    \
    \ @brief GICD interrupt clear-enable register 1
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLERx                \ [0x00 : 32] interrupt clear-enable x
  [then]


  [ifdef] GICD_GICD_ICENABLER2_DEF
    \
    \ @brief GICD interrupt clear-enable register 2
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLERx                \ [0x00 : 32] interrupt clear-enable x
  [then]


  [ifdef] GICD_GICD_ICENABLER3_DEF
    \
    \ @brief GICD interrupt clear-enable register 3
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLERx                \ [0x00 : 32] interrupt clear-enable x
  [then]


  [ifdef] GICD_GICD_ICENABLER4_DEF
    \
    \ @brief GICD interrupt clear-enable register 4
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLERx                \ [0x00 : 32] interrupt clear-enable x
  [then]


  [ifdef] GICD_GICD_ICENABLER5_DEF
    \
    \ @brief GICD interrupt clear-enable register 5
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLERx                \ [0x00 : 32] interrupt clear-enable x
  [then]


  [ifdef] GICD_GICD_ISPENDR0_DEF
    \
    \ @brief GICD interrupt set-pending register 0
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDRx                  \ [0x00 : 32] interrupt set-pending x
  [then]


  [ifdef] GICD_GICD_ISPENDR1_DEF
    \
    \ @brief GICD interrupt set-pending register 1
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDRx                  \ [0x00 : 32] interrupt set-pending x
  [then]


  [ifdef] GICD_GICD_ISPENDR2_DEF
    \
    \ @brief GICD interrupt set-pending register 2
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDRx                  \ [0x00 : 32] interrupt set-pending x
  [then]


  [ifdef] GICD_GICD_ISPENDR3_DEF
    \
    \ @brief GICD interrupt set-pending register 3
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDRx                  \ [0x00 : 32] interrupt set-pending x
  [then]


  [ifdef] GICD_GICD_ISPENDR4_DEF
    \
    \ @brief GICD interrupt set-pending register 4
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDRx                  \ [0x00 : 32] interrupt set-pending x
  [then]


  [ifdef] GICD_GICD_ISPENDR5_DEF
    \
    \ @brief GICD interrupt set-pending register 5
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDRx                  \ [0x00 : 32] interrupt set-pending x
  [then]


  [ifdef] GICD_GICD_ICPENDR0_DEF
    \
    \ @brief GICD interrupt clear-pending register 0
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDRx                  \ [0x00 : 32] interrupt clear-pending x
  [then]


  [ifdef] GICD_GICD_ICPENDR1_DEF
    \
    \ @brief GICD interrupt clear-pending register 1
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDRx                  \ [0x00 : 32] interrupt clear-pending x
  [then]


  [ifdef] GICD_GICD_ICPENDR2_DEF
    \
    \ @brief GICD interrupt clear-pending register 2
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDRx                  \ [0x00 : 32] interrupt clear-pending x
  [then]


  [ifdef] GICD_GICD_ICPENDR3_DEF
    \
    \ @brief GICD interrupt clear-pending register 3
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDRx                  \ [0x00 : 32] interrupt clear-pending x
  [then]


  [ifdef] GICD_GICD_ICPENDR4_DEF
    \
    \ @brief GICD interrupt clear-pending register 4
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDRx                  \ [0x00 : 32] interrupt clear-pending x
  [then]


  [ifdef] GICD_GICD_ICPENDR5_DEF
    \
    \ @brief GICD interrupt clear-pending register 5
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDRx                  \ [0x00 : 32] interrupt clear-pending x
  [then]


  [ifdef] GICD_GICD_ISACTIVER0_DEF
    \
    \ @brief GICD interrupt set-active register 0
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVERx                \ [0x00 : 32] interrupt set-active x
  [then]


  [ifdef] GICD_GICD_ISACTIVER1_DEF
    \
    \ @brief GICD interrupt set-active register 1
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVERx                \ [0x00 : 32] interrupt set-active x
  [then]


  [ifdef] GICD_GICD_ISACTIVER2_DEF
    \
    \ @brief GICD interrupt set-active register 2
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVERx                \ [0x00 : 32] interrupt set-active x
  [then]


  [ifdef] GICD_GICD_ISACTIVER3_DEF
    \
    \ @brief GICD interrupt set-active register 3
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVERx                \ [0x00 : 32] interrupt set-active x
  [then]


  [ifdef] GICD_GICD_ISACTIVER4_DEF
    \
    \ @brief GICD interrupt set-active register 4
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVERx                \ [0x00 : 32] interrupt set-active x
  [then]


  [ifdef] GICD_GICD_ISACTIVER5_DEF
    \
    \ @brief GICD interrupt set-active register 5
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVERx                \ [0x00 : 32] interrupt set-active x
  [then]


  [ifdef] GICD_GICD_ICACTIVER0_DEF
    \
    \ @brief GICD interrupt clear-active register 0
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVERx                \ [0x00 : 32] interrupt clear-active x
  [then]


  [ifdef] GICD_GICD_ICACTIVER1_DEF
    \
    \ @brief GICD interrupt clear-active register 1
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVERx                \ [0x00 : 32] interrupt clear-active x
  [then]


  [ifdef] GICD_GICD_ICACTIVER2_DEF
    \
    \ @brief GICD interrupt clear-active register 2
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVERx                \ [0x00 : 32] interrupt clear-active x
  [then]


  [ifdef] GICD_GICD_ICACTIVER3_DEF
    \
    \ @brief GICD interrupt clear-active register 3
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVERx                \ [0x00 : 32] interrupt clear-active x
  [then]


  [ifdef] GICD_GICD_ICACTIVER4_DEF
    \
    \ @brief GICD interrupt clear-active register 4
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVERx                \ [0x00 : 32] interrupt clear-active x
  [then]


  [ifdef] GICD_GICD_ICACTIVER5_DEF
    \
    \ @brief GICD interrupt clear-active register 5
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVERx                \ [0x00 : 32] interrupt clear-active x
  [then]


  [ifdef] GICD_GICD_IPRIORITYR0_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR1_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR2_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR3_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR4_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR5_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR6_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR7_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR8_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR9_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR10_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR11_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x42C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR12_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR13_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x434
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR14_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x438
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR15_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x43C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR16_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR17_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x444
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR18_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x448
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR19_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR20_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR21_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x454
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR22_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x458
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR23_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR24_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x460
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR25_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR26_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x468
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR27_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x46C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR28_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x470
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR29_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x474
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR30_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x478
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR31_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x47C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR32_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x480
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR33_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x484
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR34_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x488
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR35_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x48C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR36_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR37_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR38_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR39_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR40_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR41_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x4A4
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR42_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x4A8
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR43_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x4AC
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR44_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x4B0
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR45_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x4B4
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR46_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x4B8
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR47_DEF
    \
    \ @brief priority for interrupt ID = x * 4
    \ Address offset: 0x4BC
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] priority for interrupt ID = x * 4
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] priority for interrupt ID = x * 4 + 1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] priority for interrupt ID = x * 4 + 2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] priority for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR0_DEF
    \
    \ @brief GICD interrupt processor target register 0
    \ Address offset: 0x800
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR1_DEF
    \
    \ @brief GICD interrupt processor target register 1
    \ Address offset: 0x804
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR2_DEF
    \
    \ @brief GICD interrupt processor target register 2
    \ Address offset: 0x808
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR3_DEF
    \
    \ @brief GICD interrupt processor target register 3
    \ Address offset: 0x80C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR4_DEF
    \
    \ @brief GICD interrupt processor target register 4
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR5_DEF
    \
    \ @brief GICD interrupt processor target register 5
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR6_DEF
    \
    \ @brief GICD interrupt processor target register 6
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR7_DEF
    \
    \ @brief GICD interrupt processor target register 7
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR8_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x820
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR9_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x824
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR10_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x828
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR11_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x82C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR12_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x830
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR13_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x834
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR14_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x838
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR15_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x83C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR16_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x840
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR17_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x844
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR18_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x848
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR19_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x84C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR20_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x850
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR21_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x854
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR22_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x858
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR23_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x85C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR24_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x860
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR25_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x864
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR26_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x868
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR27_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x86C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR28_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x870
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR29_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x874
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR30_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x878
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR31_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x87C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR32_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x880
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR33_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x884
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR34_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x888
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR35_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x88C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR36_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x890
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR37_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x894
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR38_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x898
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR39_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x89C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR40_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x8A0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR41_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x8A4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR42_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x8A8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR43_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x8AC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR44_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x8B0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR45_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x8B4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR46_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x8B8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ITARGETSR47_DEF
    \
    \ @brief CPU(s) target for interrupt ID = x * 4
    \ Address offset: 0x8BC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU(s) target for interrupt ID = x * 4
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU(s) target for interrupt ID = x * 4 + 1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU(s) target for interrupt ID = x * 4 + 2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU(s) target for interrupt ID = x * 4 + 3
  [then]


  [ifdef] GICD_GICD_ICFGR0_DEF
    \
    \ @brief interrupt config for interrupt ID = 0
    \ Address offset: 0xC00
    \ Reset value: 0xAAAAAAAA
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = 0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = 15
  [then]


  [ifdef] GICD_GICD_ICFGR1_DEF
    \
    \ @brief GICD interrupt configuration register
    \ Address offset: 0xC04
    \ Reset value: 0x00000000
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = 17
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = 18
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = 19
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = 20
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = 21
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = 22
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = 23
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = 24
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = 25
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = 26
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = 27
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = 28
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = 29
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = 30
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = 31
  [then]


  [ifdef] GICD_GICD_ICFGR2_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC08
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_ICFGR3_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC0C
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_ICFGR4_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC10
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_ICFGR5_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC14
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_ICFGR6_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC18
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_ICFGR7_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC1C
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_ICFGR8_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC20
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_ICFGR9_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC24
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_ICFGR10_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC28
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_ICFGR11_DEF
    \
    \ @brief interrupt config for interrupt ID = x * 16
    \ Address offset: 0xC2C
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] interrupt config for interrupt ID = x * 16
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] interrupt config for interrupt ID = x * 16 + 1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] interrupt config for interrupt ID = x * 16 + 2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] interrupt config for interrupt ID = x * 16 + 3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] interrupt config for interrupt ID = x * 16 + 4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] interrupt config for interrupt ID = x * 16 + 5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] interrupt config for interrupt ID = x * 16 + 6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] interrupt config for interrupt ID = x * 16 + 7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] interrupt config for interrupt ID = x * 16 + 8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] interrupt config for interrupt ID = x * 16 + 9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] interrupt config for interrupt ID = x * 16 + 10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] interrupt config for interrupt ID = x * 16 + 11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] interrupt config for interrupt ID = x * 16 + 12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] interrupt config for interrupt ID = x * 16 + 13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] interrupt config for interrupt ID = x * 16 + 14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] interrupt config for interrupt ID = x * 16 + 15
  [then]


  [ifdef] GICD_GICD_PPISR_DEF
    \
    \ @brief virtual maintenance interrupt
    \ Address offset: 0xD00
    \ Reset value: 0x00000000
    \
    $09 constant GICD_PPI6                      \ [0x09] virtual maintenance interrupt
    $0a constant GICD_PPI5                      \ [0x0a] hypervisor timer event
    $0b constant GICD_PPI4                      \ [0x0b] virtual timer event
    $0c constant GICD_PPI0                      \ [0x0c] nFIQ (not used)
    $0d constant GICD_PPI1                      \ [0x0d] secure physical timer event
    $0e constant GICD_PPI2                      \ [0x0e] secure physical timer event
    $0f constant GICD_PPI3                      \ [0x0f] nIRQ (not used)
  [then]


  [ifdef] GICD_GICD_SPISR0_DEF
    \
    \ @brief GICD shared peripheral interrupt register 0
    \ Address offset: 0xD04
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISRx                    \ [0x00 : 32] shared peripheral interrupt
  [then]


  [ifdef] GICD_GICD_SPISR1_DEF
    \
    \ @brief GICD shared peripheral interrupt register 1
    \ Address offset: 0xD08
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISRx                    \ [0x00 : 32] shared peripheral interrupt
  [then]


  [ifdef] GICD_GICD_SPISR2_DEF
    \
    \ @brief GICD shared peripheral interrupt register 2
    \ Address offset: 0xD0C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISRx                    \ [0x00 : 32] shared peripheral interrupt
  [then]


  [ifdef] GICD_GICD_SPISR3_DEF
    \
    \ @brief GICD shared peripheral interrupt register 3
    \ Address offset: 0xD10
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISRx                    \ [0x00 : 32] shared peripheral interrupt
  [then]


  [ifdef] GICD_GICD_SPISR4_DEF
    \
    \ @brief GICD shared peripheral interrupt register 4
    \ Address offset: 0xD14
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISRx                    \ [0x00 : 32] shared peripheral interrupt
  [then]


  [ifdef] GICD_GICD_SGIR_DEF
    \
    \ @brief SGI interrupt ID The value of this field is the interrupt ID of the SGI to forward to the specified CPU interfaces, in the range 0-15 (for example: a value of 0b0011 specifies interrupt ID 3).
    \ Address offset: 0xF00
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGIINTID                  \ [0x00 : 4] SGI interrupt ID The value of this field is the interrupt ID of the SGI to forward to the specified CPU interfaces, in the range 0-15 (for example: a value of 0b0011 specifies interrupt ID 3).
    $0f constant GICD_NSATT                     \ [0x0f] non-secure attribute It specifies the required security value of the SGI: 0 - Forward the SGI specified in the SGIINTID field to a specified CPU interface only if the SGI is configured as group 0 on that interface. 1 - Forward the SGI specified in the SGIINTID field to a specified CPU interfaces only if the SGI is configured as group 1 on that interface. This field is writable only by a secure access. Any non-secure write to the GICD_SGIR generates an SGI only if the specified SGI is programmed as group 1.
    $10 constant GICD_CPUTARGETLIST             \ [0x10 : 2] CPU target list When TARGETLISTFILTER = 0b00, defines the CPU interfaces to which the GICD must forward the interrupt. Each bit of CPUTARGETLIST[1:0] refers to the corresponding CPU interface. If this field is 0 when TARGETLISTFILTER is 0b00, the GICD does not forward the interrupt to any CPU interface.
    $18 constant GICD_TARGETLISTFILTER          \ [0x18 : 2] target list filter Determines how the distributor must process the requested SGI 2: Forward the interrupt only to the CPU interface of the processor which requested the interrupt 3: Reserved, must be kept at reset value.
  [then]


  [ifdef] GICD_GICD_CPENDSGIR0_DEF
    \
    \ @brief GICD SGI clear-pending register 0
    \ Address offset: 0xF10
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_CLEAR_PENDING0        \ [0x00 : 2] clear-pending state for SGI [x * 4] Writing a 1 clears the pending state of the SGI [x * 4] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
    $08 constant GICD_SGI_CLEAR_PENDING1        \ [0x08 : 2] clear-pending state for SGI [x * 4 + 1] Writing a 1 clears the pending state of the SGI [x * 4 + 1] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
    $10 constant GICD_SGI_CLEAR_PENDING2        \ [0x10 : 2] clear-pending state for SGI [x * 4 + 2] Writing a 1 clears the pending state of the SGI [x * 4 + 2] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
    $18 constant GICD_SGI_CLEAR_PENDING3        \ [0x18 : 2] clear-pending state for SGI [x * 4 + 3] Writing a 1 clears the pending state of the SGI [x * 4 + 3] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.
  [then]


  [ifdef] GICD_GICD_CPENDSGIR1_DEF
    \
    \ @brief GICD SGI clear-pending register 1
    \ Address offset: 0xF14
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_CLEAR_PENDING0        \ [0x00 : 2] clear-pending state for SGI [x * 4] Writing a 1 clears the pending state of the SGI [x * 4] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
    $08 constant GICD_SGI_CLEAR_PENDING1        \ [0x08 : 2] clear-pending state for SGI [x * 4 + 1] Writing a 1 clears the pending state of the SGI [x * 4 + 1] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
    $10 constant GICD_SGI_CLEAR_PENDING2        \ [0x10 : 2] clear-pending state for SGI [x * 4 + 2] Writing a 1 clears the pending state of the SGI [x * 4 + 2] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
    $18 constant GICD_SGI_CLEAR_PENDING3        \ [0x18 : 2] clear-pending state for SGI [x * 4 + 3] Writing a 1 clears the pending state of the SGI [x * 4 + 3] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.
  [then]


  [ifdef] GICD_GICD_CPENDSGIR2_DEF
    \
    \ @brief GICD SGI clear-pending register 2
    \ Address offset: 0xF18
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_CLEAR_PENDING0        \ [0x00 : 2] clear-pending state for SGI [x * 4] Writing a 1 clears the pending state of the SGI [x * 4] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
    $08 constant GICD_SGI_CLEAR_PENDING1        \ [0x08 : 2] clear-pending state for SGI [x * 4 + 1] Writing a 1 clears the pending state of the SGI [x * 4 + 1] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
    $10 constant GICD_SGI_CLEAR_PENDING2        \ [0x10 : 2] clear-pending state for SGI [x * 4 + 2] Writing a 1 clears the pending state of the SGI [x * 4 + 2] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
    $18 constant GICD_SGI_CLEAR_PENDING3        \ [0x18 : 2] clear-pending state for SGI [x * 4 + 3] Writing a 1 clears the pending state of the SGI [x * 4 + 3] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.
  [then]


  [ifdef] GICD_GICD_CPENDSGIR3_DEF
    \
    \ @brief GICD SGI clear-pending register 3
    \ Address offset: 0xF1C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_CLEAR_PENDING0        \ [0x00 : 2] clear-pending state for SGI [x * 4] Writing a 1 clears the pending state of the SGI [x * 4] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
    $08 constant GICD_SGI_CLEAR_PENDING1        \ [0x08 : 2] clear-pending state for SGI [x * 4 + 1] Writing a 1 clears the pending state of the SGI [x * 4 + 1] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
    $10 constant GICD_SGI_CLEAR_PENDING2        \ [0x10 : 2] clear-pending state for SGI [x * 4 + 2] Writing a 1 clears the pending state of the SGI [x * 4 + 2] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
    $18 constant GICD_SGI_CLEAR_PENDING3        \ [0x18 : 2] clear-pending state for SGI [x * 4 + 3] Writing a 1 clears the pending state of the SGI [x * 4 + 3] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.
  [then]


  [ifdef] GICD_GICD_SPENDSGIR0_DEF
    \
    \ @brief GICD SGI set-pending register 0
    \ Address offset: 0xF20
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_SET_PENDING0          \ [0x00 : 2] set-pending state for SGI [x * 4] Writing a 1 sets the pending state of the SGI [x * 4] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
    $08 constant GICD_SGI_SET_PENDING1          \ [0x08 : 2] set-pending state for SGI [x * 4 + 1] Writing a 1 sets the pending state of the SGI [x * 4 + 1] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
    $10 constant GICD_SGI_SET_PENDING2          \ [0x10 : 2] set-pending state for SGI [x * 4 + 2] Writing a 1 sets the pending state of the SGI [x * 4 + 2] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
    $18 constant GICD_SGI_SET_PENDING3          \ [0x18 : 2] set-pending state for SGI [x * 4 + 3] Writing a 1 sets the pending state of the SGI [x * 4 + 3] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.
  [then]


  [ifdef] GICD_GICD_SPENDSGIR1_DEF
    \
    \ @brief GICD SGI set-pending register 1
    \ Address offset: 0xF24
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_SET_PENDING0          \ [0x00 : 2] set-pending state for SGI [x * 4] Writing a 1 sets the pending state of the SGI [x * 4] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
    $08 constant GICD_SGI_SET_PENDING1          \ [0x08 : 2] set-pending state for SGI [x * 4 + 1] Writing a 1 sets the pending state of the SGI [x * 4 + 1] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
    $10 constant GICD_SGI_SET_PENDING2          \ [0x10 : 2] set-pending state for SGI [x * 4 + 2] Writing a 1 sets the pending state of the SGI [x * 4 + 2] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
    $18 constant GICD_SGI_SET_PENDING3          \ [0x18 : 2] set-pending state for SGI [x * 4 + 3] Writing a 1 sets the pending state of the SGI [x * 4 + 3] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.
  [then]


  [ifdef] GICD_GICD_SPENDSGIR2_DEF
    \
    \ @brief GICD SGI set-pending register 2
    \ Address offset: 0xF28
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_SET_PENDING0          \ [0x00 : 2] set-pending state for SGI [x * 4] Writing a 1 sets the pending state of the SGI [x * 4] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
    $08 constant GICD_SGI_SET_PENDING1          \ [0x08 : 2] set-pending state for SGI [x * 4 + 1] Writing a 1 sets the pending state of the SGI [x * 4 + 1] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
    $10 constant GICD_SGI_SET_PENDING2          \ [0x10 : 2] set-pending state for SGI [x * 4 + 2] Writing a 1 sets the pending state of the SGI [x * 4 + 2] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
    $18 constant GICD_SGI_SET_PENDING3          \ [0x18 : 2] set-pending state for SGI [x * 4 + 3] Writing a 1 sets the pending state of the SGI [x * 4 + 3] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.
  [then]


  [ifdef] GICD_GICD_SPENDSGIR3_DEF
    \
    \ @brief GICD SGI set-pending register 3
    \ Address offset: 0xF2C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_SET_PENDING0          \ [0x00 : 2] set-pending state for SGI [x * 4] Writing a 1 sets the pending state of the SGI [x * 4] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
    $08 constant GICD_SGI_SET_PENDING1          \ [0x08 : 2] set-pending state for SGI [x * 4 + 1] Writing a 1 sets the pending state of the SGI [x * 4 + 1] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
    $10 constant GICD_SGI_SET_PENDING2          \ [0x10 : 2] set-pending state for SGI [x * 4 + 2] Writing a 1 sets the pending state of the SGI [x * 4 + 2] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
    $18 constant GICD_SGI_SET_PENDING3          \ [0x18 : 2] set-pending state for SGI [x * 4 + 3] Writing a 1 sets the pending state of the SGI [x * 4 + 3] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.
  [then]


  [ifdef] GICD_GICD_PIDR4_DEF
    \
    \ @brief peripheral ID4
    \ Address offset: 0xFD0
    \ Reset value: 0x00000004
    \
    $00 constant GICD_PIDR4                     \ [0x00 : 32] peripheral ID4
  [then]


  [ifdef] GICD_GICD_PIDR5_DEF
    \
    \ @brief peripheral ID5 to ID7
    \ Address offset: 0xFD4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_PIDRx                     \ [0x00 : 32] peripheral ID5 to ID7
  [then]


  [ifdef] GICD_GICD_PIDR6_DEF
    \
    \ @brief peripheral ID5 to ID7
    \ Address offset: 0xFD8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_PIDRx                     \ [0x00 : 32] peripheral ID5 to ID7
  [then]


  [ifdef] GICD_GICD_PIDR7_DEF
    \
    \ @brief peripheral ID5 to ID7
    \ Address offset: 0xFDC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_PIDRx                     \ [0x00 : 32] peripheral ID5 to ID7
  [then]


  [ifdef] GICD_GICD_PIDR0_DEF
    \
    \ @brief peripheral ID0
    \ Address offset: 0xFE0
    \ Reset value: 0x00000090
    \
    $00 constant GICD_PIDR0                     \ [0x00 : 32] peripheral ID0
  [then]


  [ifdef] GICD_GICD_PIDR1_DEF
    \
    \ @brief peripheral ID1
    \ Address offset: 0xFE4
    \ Reset value: 0x000000B4
    \
    $00 constant GICD_PIDR1                     \ [0x00 : 32] peripheral ID1
  [then]


  [ifdef] GICD_GICD_PIDR2_DEF
    \
    \ @brief peripheral ID2
    \ Address offset: 0xFE8
    \ Reset value: 0x0000002B
    \
    $00 constant GICD_PIDR2                     \ [0x00 : 32] peripheral ID2
  [then]


  [ifdef] GICD_GICD_PIDR3_DEF
    \
    \ @brief peripheral ID3
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_PIDR3                     \ [0x00 : 32] peripheral ID3
  [then]


  [ifdef] GICD_GICD_CIDR0_DEF
    \
    \ @brief component ID0
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant GICD_CIDR0                     \ [0x00 : 32] component ID0
  [then]


  [ifdef] GICD_GICD_CIDR1_DEF
    \
    \ @brief component ID1
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant GICD_CIDR1                     \ [0x00 : 32] component ID1
  [then]


  [ifdef] GICD_GICD_CIDR2_DEF
    \
    \ @brief component ID2
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant GICD_CIDR2                     \ [0x00 : 32] component ID2
  [then]


  [ifdef] GICD_GICD_CIDR3_DEF
    \
    \ @brief component ID3
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant GICD_CIDR3                     \ [0x00 : 32] component ID3
  [then]

  \
  \ @brief GICD address block description
  \
  $00 constant GICD_GICD_CTLR           \ GICD_CTLR
  $00 constant GICD_GICD_CTLRNS         \ GICD_CTLRNS
  $04 constant GICD_GICD_TYPER          \ number of interrupt lines Indicates the number of interrupts that the GIC supports (0b00101 = Up to 192 interrupts, 160 external interrupts)
  $08 constant GICD_GICD_IIDR           \ GIC implementer (0x43B Arm implementation)
  $80 constant GICD_GICD_IGROUPR0       \ GICD interrupt group register 0
  $84 constant GICD_GICD_IGROUPR1       \ GICD interrupt group register 1
  $88 constant GICD_GICD_IGROUPR2       \ GICD interrupt group register 2
  $8C constant GICD_GICD_IGROUPR3       \ GICD interrupt group register 3
  $90 constant GICD_GICD_IGROUPR4       \ GICD interrupt group register 4
  $94 constant GICD_GICD_IGROUPR5       \ GICD interrupt group register 5
  $100 constant GICD_GICD_ISENABLER0    \ GICD interrupt set-enable register
  $104 constant GICD_GICD_ISENABLER1    \ GICD interrupt set-enable register 1
  $108 constant GICD_GICD_ISENABLER2    \ GICD interrupt set-enable register 2
  $10C constant GICD_GICD_ISENABLER3    \ GICD interrupt set-enable register 3
  $110 constant GICD_GICD_ISENABLER4    \ GICD interrupt set-enable register 4
  $114 constant GICD_GICD_ISENABLER5    \ GICD interrupt set-enable register 5
  $180 constant GICD_GICD_ICENABLER0    \ GICD interrupt clear-enable register
  $184 constant GICD_GICD_ICENABLER1    \ GICD interrupt clear-enable register 1
  $188 constant GICD_GICD_ICENABLER2    \ GICD interrupt clear-enable register 2
  $18C constant GICD_GICD_ICENABLER3    \ GICD interrupt clear-enable register 3
  $190 constant GICD_GICD_ICENABLER4    \ GICD interrupt clear-enable register 4
  $194 constant GICD_GICD_ICENABLER5    \ GICD interrupt clear-enable register 5
  $200 constant GICD_GICD_ISPENDR0      \ GICD interrupt set-pending register 0
  $204 constant GICD_GICD_ISPENDR1      \ GICD interrupt set-pending register 1
  $208 constant GICD_GICD_ISPENDR2      \ GICD interrupt set-pending register 2
  $20C constant GICD_GICD_ISPENDR3      \ GICD interrupt set-pending register 3
  $210 constant GICD_GICD_ISPENDR4      \ GICD interrupt set-pending register 4
  $214 constant GICD_GICD_ISPENDR5      \ GICD interrupt set-pending register 5
  $280 constant GICD_GICD_ICPENDR0      \ GICD interrupt clear-pending register 0
  $284 constant GICD_GICD_ICPENDR1      \ GICD interrupt clear-pending register 1
  $288 constant GICD_GICD_ICPENDR2      \ GICD interrupt clear-pending register 2
  $28C constant GICD_GICD_ICPENDR3      \ GICD interrupt clear-pending register 3
  $290 constant GICD_GICD_ICPENDR4      \ GICD interrupt clear-pending register 4
  $294 constant GICD_GICD_ICPENDR5      \ GICD interrupt clear-pending register 5
  $300 constant GICD_GICD_ISACTIVER0    \ GICD interrupt set-active register 0
  $304 constant GICD_GICD_ISACTIVER1    \ GICD interrupt set-active register 1
  $308 constant GICD_GICD_ISACTIVER2    \ GICD interrupt set-active register 2
  $30C constant GICD_GICD_ISACTIVER3    \ GICD interrupt set-active register 3
  $310 constant GICD_GICD_ISACTIVER4    \ GICD interrupt set-active register 4
  $314 constant GICD_GICD_ISACTIVER5    \ GICD interrupt set-active register 5
  $380 constant GICD_GICD_ICACTIVER0    \ GICD interrupt clear-active register 0
  $384 constant GICD_GICD_ICACTIVER1    \ GICD interrupt clear-active register 1
  $388 constant GICD_GICD_ICACTIVER2    \ GICD interrupt clear-active register 2
  $38C constant GICD_GICD_ICACTIVER3    \ GICD interrupt clear-active register 3
  $390 constant GICD_GICD_ICACTIVER4    \ GICD interrupt clear-active register 4
  $394 constant GICD_GICD_ICACTIVER5    \ GICD interrupt clear-active register 5
  $400 constant GICD_GICD_IPRIORITYR0   \ priority for interrupt ID = x * 4
  $404 constant GICD_GICD_IPRIORITYR1   \ priority for interrupt ID = x * 4
  $408 constant GICD_GICD_IPRIORITYR2   \ priority for interrupt ID = x * 4
  $40C constant GICD_GICD_IPRIORITYR3   \ priority for interrupt ID = x * 4
  $410 constant GICD_GICD_IPRIORITYR4   \ priority for interrupt ID = x * 4
  $414 constant GICD_GICD_IPRIORITYR5   \ priority for interrupt ID = x * 4
  $418 constant GICD_GICD_IPRIORITYR6   \ priority for interrupt ID = x * 4
  $41C constant GICD_GICD_IPRIORITYR7   \ priority for interrupt ID = x * 4
  $420 constant GICD_GICD_IPRIORITYR8   \ priority for interrupt ID = x * 4
  $424 constant GICD_GICD_IPRIORITYR9   \ priority for interrupt ID = x * 4
  $428 constant GICD_GICD_IPRIORITYR10  \ priority for interrupt ID = x * 4
  $42C constant GICD_GICD_IPRIORITYR11  \ priority for interrupt ID = x * 4
  $430 constant GICD_GICD_IPRIORITYR12  \ priority for interrupt ID = x * 4
  $434 constant GICD_GICD_IPRIORITYR13  \ priority for interrupt ID = x * 4
  $438 constant GICD_GICD_IPRIORITYR14  \ priority for interrupt ID = x * 4
  $43C constant GICD_GICD_IPRIORITYR15  \ priority for interrupt ID = x * 4
  $440 constant GICD_GICD_IPRIORITYR16  \ priority for interrupt ID = x * 4
  $444 constant GICD_GICD_IPRIORITYR17  \ priority for interrupt ID = x * 4
  $448 constant GICD_GICD_IPRIORITYR18  \ priority for interrupt ID = x * 4
  $44C constant GICD_GICD_IPRIORITYR19  \ priority for interrupt ID = x * 4
  $450 constant GICD_GICD_IPRIORITYR20  \ priority for interrupt ID = x * 4
  $454 constant GICD_GICD_IPRIORITYR21  \ priority for interrupt ID = x * 4
  $458 constant GICD_GICD_IPRIORITYR22  \ priority for interrupt ID = x * 4
  $45C constant GICD_GICD_IPRIORITYR23  \ priority for interrupt ID = x * 4
  $460 constant GICD_GICD_IPRIORITYR24  \ priority for interrupt ID = x * 4
  $464 constant GICD_GICD_IPRIORITYR25  \ priority for interrupt ID = x * 4
  $468 constant GICD_GICD_IPRIORITYR26  \ priority for interrupt ID = x * 4
  $46C constant GICD_GICD_IPRIORITYR27  \ priority for interrupt ID = x * 4
  $470 constant GICD_GICD_IPRIORITYR28  \ priority for interrupt ID = x * 4
  $474 constant GICD_GICD_IPRIORITYR29  \ priority for interrupt ID = x * 4
  $478 constant GICD_GICD_IPRIORITYR30  \ priority for interrupt ID = x * 4
  $47C constant GICD_GICD_IPRIORITYR31  \ priority for interrupt ID = x * 4
  $480 constant GICD_GICD_IPRIORITYR32  \ priority for interrupt ID = x * 4
  $484 constant GICD_GICD_IPRIORITYR33  \ priority for interrupt ID = x * 4
  $488 constant GICD_GICD_IPRIORITYR34  \ priority for interrupt ID = x * 4
  $48C constant GICD_GICD_IPRIORITYR35  \ priority for interrupt ID = x * 4
  $490 constant GICD_GICD_IPRIORITYR36  \ priority for interrupt ID = x * 4
  $494 constant GICD_GICD_IPRIORITYR37  \ priority for interrupt ID = x * 4
  $498 constant GICD_GICD_IPRIORITYR38  \ priority for interrupt ID = x * 4
  $49C constant GICD_GICD_IPRIORITYR39  \ priority for interrupt ID = x * 4
  $4A0 constant GICD_GICD_IPRIORITYR40  \ priority for interrupt ID = x * 4
  $4A4 constant GICD_GICD_IPRIORITYR41  \ priority for interrupt ID = x * 4
  $4A8 constant GICD_GICD_IPRIORITYR42  \ priority for interrupt ID = x * 4
  $4AC constant GICD_GICD_IPRIORITYR43  \ priority for interrupt ID = x * 4
  $4B0 constant GICD_GICD_IPRIORITYR44  \ priority for interrupt ID = x * 4
  $4B4 constant GICD_GICD_IPRIORITYR45  \ priority for interrupt ID = x * 4
  $4B8 constant GICD_GICD_IPRIORITYR46  \ priority for interrupt ID = x * 4
  $4BC constant GICD_GICD_IPRIORITYR47  \ priority for interrupt ID = x * 4
  $800 constant GICD_GICD_ITARGETSR0    \ GICD interrupt processor target register 0
  $804 constant GICD_GICD_ITARGETSR1    \ GICD interrupt processor target register 1
  $808 constant GICD_GICD_ITARGETSR2    \ GICD interrupt processor target register 2
  $80C constant GICD_GICD_ITARGETSR3    \ GICD interrupt processor target register 3
  $810 constant GICD_GICD_ITARGETSR4    \ GICD interrupt processor target register 4
  $814 constant GICD_GICD_ITARGETSR5    \ GICD interrupt processor target register 5
  $818 constant GICD_GICD_ITARGETSR6    \ GICD interrupt processor target register 6
  $81C constant GICD_GICD_ITARGETSR7    \ GICD interrupt processor target register 7
  $820 constant GICD_GICD_ITARGETSR8    \ CPU(s) target for interrupt ID = x * 4
  $824 constant GICD_GICD_ITARGETSR9    \ CPU(s) target for interrupt ID = x * 4
  $828 constant GICD_GICD_ITARGETSR10   \ CPU(s) target for interrupt ID = x * 4
  $82C constant GICD_GICD_ITARGETSR11   \ CPU(s) target for interrupt ID = x * 4
  $830 constant GICD_GICD_ITARGETSR12   \ CPU(s) target for interrupt ID = x * 4
  $834 constant GICD_GICD_ITARGETSR13   \ CPU(s) target for interrupt ID = x * 4
  $838 constant GICD_GICD_ITARGETSR14   \ CPU(s) target for interrupt ID = x * 4
  $83C constant GICD_GICD_ITARGETSR15   \ CPU(s) target for interrupt ID = x * 4
  $840 constant GICD_GICD_ITARGETSR16   \ CPU(s) target for interrupt ID = x * 4
  $844 constant GICD_GICD_ITARGETSR17   \ CPU(s) target for interrupt ID = x * 4
  $848 constant GICD_GICD_ITARGETSR18   \ CPU(s) target for interrupt ID = x * 4
  $84C constant GICD_GICD_ITARGETSR19   \ CPU(s) target for interrupt ID = x * 4
  $850 constant GICD_GICD_ITARGETSR20   \ CPU(s) target for interrupt ID = x * 4
  $854 constant GICD_GICD_ITARGETSR21   \ CPU(s) target for interrupt ID = x * 4
  $858 constant GICD_GICD_ITARGETSR22   \ CPU(s) target for interrupt ID = x * 4
  $85C constant GICD_GICD_ITARGETSR23   \ CPU(s) target for interrupt ID = x * 4
  $860 constant GICD_GICD_ITARGETSR24   \ CPU(s) target for interrupt ID = x * 4
  $864 constant GICD_GICD_ITARGETSR25   \ CPU(s) target for interrupt ID = x * 4
  $868 constant GICD_GICD_ITARGETSR26   \ CPU(s) target for interrupt ID = x * 4
  $86C constant GICD_GICD_ITARGETSR27   \ CPU(s) target for interrupt ID = x * 4
  $870 constant GICD_GICD_ITARGETSR28   \ CPU(s) target for interrupt ID = x * 4
  $874 constant GICD_GICD_ITARGETSR29   \ CPU(s) target for interrupt ID = x * 4
  $878 constant GICD_GICD_ITARGETSR30   \ CPU(s) target for interrupt ID = x * 4
  $87C constant GICD_GICD_ITARGETSR31   \ CPU(s) target for interrupt ID = x * 4
  $880 constant GICD_GICD_ITARGETSR32   \ CPU(s) target for interrupt ID = x * 4
  $884 constant GICD_GICD_ITARGETSR33   \ CPU(s) target for interrupt ID = x * 4
  $888 constant GICD_GICD_ITARGETSR34   \ CPU(s) target for interrupt ID = x * 4
  $88C constant GICD_GICD_ITARGETSR35   \ CPU(s) target for interrupt ID = x * 4
  $890 constant GICD_GICD_ITARGETSR36   \ CPU(s) target for interrupt ID = x * 4
  $894 constant GICD_GICD_ITARGETSR37   \ CPU(s) target for interrupt ID = x * 4
  $898 constant GICD_GICD_ITARGETSR38   \ CPU(s) target for interrupt ID = x * 4
  $89C constant GICD_GICD_ITARGETSR39   \ CPU(s) target for interrupt ID = x * 4
  $8A0 constant GICD_GICD_ITARGETSR40   \ CPU(s) target for interrupt ID = x * 4
  $8A4 constant GICD_GICD_ITARGETSR41   \ CPU(s) target for interrupt ID = x * 4
  $8A8 constant GICD_GICD_ITARGETSR42   \ CPU(s) target for interrupt ID = x * 4
  $8AC constant GICD_GICD_ITARGETSR43   \ CPU(s) target for interrupt ID = x * 4
  $8B0 constant GICD_GICD_ITARGETSR44   \ CPU(s) target for interrupt ID = x * 4
  $8B4 constant GICD_GICD_ITARGETSR45   \ CPU(s) target for interrupt ID = x * 4
  $8B8 constant GICD_GICD_ITARGETSR46   \ CPU(s) target for interrupt ID = x * 4
  $8BC constant GICD_GICD_ITARGETSR47   \ CPU(s) target for interrupt ID = x * 4
  $C00 constant GICD_GICD_ICFGR0        \ interrupt config for interrupt ID = 0
  $C04 constant GICD_GICD_ICFGR1        \ GICD interrupt configuration register
  $C08 constant GICD_GICD_ICFGR2        \ interrupt config for interrupt ID = x * 16
  $C0C constant GICD_GICD_ICFGR3        \ interrupt config for interrupt ID = x * 16
  $C10 constant GICD_GICD_ICFGR4        \ interrupt config for interrupt ID = x * 16
  $C14 constant GICD_GICD_ICFGR5        \ interrupt config for interrupt ID = x * 16
  $C18 constant GICD_GICD_ICFGR6        \ interrupt config for interrupt ID = x * 16
  $C1C constant GICD_GICD_ICFGR7        \ interrupt config for interrupt ID = x * 16
  $C20 constant GICD_GICD_ICFGR8        \ interrupt config for interrupt ID = x * 16
  $C24 constant GICD_GICD_ICFGR9        \ interrupt config for interrupt ID = x * 16
  $C28 constant GICD_GICD_ICFGR10       \ interrupt config for interrupt ID = x * 16
  $C2C constant GICD_GICD_ICFGR11       \ interrupt config for interrupt ID = x * 16
  $D00 constant GICD_GICD_PPISR         \ virtual maintenance interrupt
  $D04 constant GICD_GICD_SPISR0        \ GICD shared peripheral interrupt register 0
  $D08 constant GICD_GICD_SPISR1        \ GICD shared peripheral interrupt register 1
  $D0C constant GICD_GICD_SPISR2        \ GICD shared peripheral interrupt register 2
  $D10 constant GICD_GICD_SPISR3        \ GICD shared peripheral interrupt register 3
  $D14 constant GICD_GICD_SPISR4        \ GICD shared peripheral interrupt register 4
  $F00 constant GICD_GICD_SGIR          \ SGI interrupt ID The value of this field is the interrupt ID of the SGI to forward to the specified CPU interfaces, in the range 0-15 (for example: a value of 0b0011 specifies interrupt ID 3).
  $F10 constant GICD_GICD_CPENDSGIR0    \ GICD SGI clear-pending register 0
  $F14 constant GICD_GICD_CPENDSGIR1    \ GICD SGI clear-pending register 1
  $F18 constant GICD_GICD_CPENDSGIR2    \ GICD SGI clear-pending register 2
  $F1C constant GICD_GICD_CPENDSGIR3    \ GICD SGI clear-pending register 3
  $F20 constant GICD_GICD_SPENDSGIR0    \ GICD SGI set-pending register 0
  $F24 constant GICD_GICD_SPENDSGIR1    \ GICD SGI set-pending register 1
  $F28 constant GICD_GICD_SPENDSGIR2    \ GICD SGI set-pending register 2
  $F2C constant GICD_GICD_SPENDSGIR3    \ GICD SGI set-pending register 3
  $FD0 constant GICD_GICD_PIDR4         \ peripheral ID4
  $FD4 constant GICD_GICD_PIDR5         \ peripheral ID5 to ID7
  $FD8 constant GICD_GICD_PIDR6         \ peripheral ID5 to ID7
  $FDC constant GICD_GICD_PIDR7         \ peripheral ID5 to ID7
  $FE0 constant GICD_GICD_PIDR0         \ peripheral ID0
  $FE4 constant GICD_GICD_PIDR1         \ peripheral ID1
  $FE8 constant GICD_GICD_PIDR2         \ peripheral ID2
  $FEC constant GICD_GICD_PIDR3         \ peripheral ID3
  $FF0 constant GICD_GICD_CIDR0         \ component ID0
  $FF4 constant GICD_GICD_CIDR1         \ component ID1
  $FF8 constant GICD_GICD_CIDR2         \ component ID2
  $FFC constant GICD_GICD_CIDR3         \ component ID3

: GICD_DEF ; [then]
