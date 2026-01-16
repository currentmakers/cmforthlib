\
\ @file gicd.fs
\ @brief GICD address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GICD_CTLR
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GICD_GICD_CTLR_ENABLEGRP0                        \ enable group 1 interrupts Global enable for forwarding pending group 1 interrupts from the GICD to the CPU interfaces
$00000002 constant GICD_GICD_CTLR_ENABLEGRP1                        \ enable group 1 interrupts Global enable for forwarding pending group 1 interrupts from the GICD to the CPU interfaces


\
\ @brief GICD_CTLRNS
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GICD_GICD_CTLRNS_ENABLE                          \ Global enable for forwarding pending group 1 interrupts from the GICD to the CPU interfaces
$00000002 constant GICD_GICD_CTLRNS_ENABLEGRP1                      \ enable group 1 interrupts Global enable for forwarding pending group 1 interrupts from the GICD to the CPU interfaces


\
\ @brief number of interrupt lines Indicates the number of interrupts that the GIC supports (0b00101 = Up to 192 interrupts, 160 external interrupts)
\ Address offset: 0x04
\ Reset value: 0x0000FC05
\

$0000001f constant GICD_GICD_TYPER_ITLINESNUMBER                    \ number of interrupt lines Indicates the number of interrupts that the GIC supports (0b00101 = Up to 192 interrupts, 160 external interrupts)
$000000e0 constant GICD_GICD_TYPER_CPUNUMBER                        \ number of processors interfaces Indicates the number of implemented processors interfaces in the GIC (0b000 = 1 processor)
$00000400 constant GICD_GICD_TYPER_SECURITYEXTN                     \ security extension Indicates whether the GIC implements the security extensions. This bit always returns a value of 1, indicating that the security extensions are implemented.
$0000f800 constant GICD_GICD_TYPER_LSPI                             \ lockable shared peripheral interrupt Returns the number of LSPIs that the interrupt controller contains (0b1111 = 31 LSPIs, these are the interrupts of IDs 32-62).


\
\ @brief GIC implementer (0x43B Arm implementation)
\ Address offset: 0x08
\ Reset value: 0x0100143B
\

$00000fff constant GICD_GICD_IIDR_IMPLEMENTER                       \ GIC implementer (0x43B Arm implementation)
$0000f000 constant GICD_GICD_IIDR_REVISION                          \ Indicates the minor revision number of the GIC
$000f0000 constant GICD_GICD_IIDR_VARIANT                           \ Indicates the major revision number of the GIC
$ff000000 constant GICD_GICD_IIDR_PRODUCTID                         \ product ID of the GIC


\
\ @brief GICD interrupt group register 0
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR0_IGROUPRX                      \ group of interrupts


\
\ @brief GICD interrupt group register 1
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR1_IGROUPRX                      \ group of interrupts


\
\ @brief GICD interrupt group register 2
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR2_IGROUPRX                      \ group of interrupts


\
\ @brief GICD interrupt group register 3
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR3_IGROUPRX                      \ group of interrupts


\
\ @brief GICD interrupt group register 4
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR4_IGROUPRX                      \ group of interrupts


\
\ @brief GICD interrupt group register 5
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR5_IGROUPRX                      \ group of interrupts


\
\ @brief GICD interrupt set-enable register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER0_ISENABLER0                  \ interrupt set-enable 0


\
\ @brief GICD interrupt set-enable register 1
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER1_ISENABLERX                  \ interrupt set-enable x


\
\ @brief GICD interrupt set-enable register 2
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER2_ISENABLERX                  \ interrupt set-enable x


\
\ @brief GICD interrupt set-enable register 3
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER3_ISENABLERX                  \ interrupt set-enable x


\
\ @brief GICD interrupt set-enable register 4
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER4_ISENABLERX                  \ interrupt set-enable x


\
\ @brief GICD interrupt set-enable register 5
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER5_ISENABLERX                  \ interrupt set-enable x


\
\ @brief GICD interrupt clear-enable register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER0_ICENABLER0                  \ interrupt clear-enable 0


\
\ @brief GICD interrupt clear-enable register 1
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER1_ICENABLERX                  \ interrupt clear-enable x


\
\ @brief GICD interrupt clear-enable register 2
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER2_ICENABLERX                  \ interrupt clear-enable x


\
\ @brief GICD interrupt clear-enable register 3
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER3_ICENABLERX                  \ interrupt clear-enable x


\
\ @brief GICD interrupt clear-enable register 4
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER4_ICENABLERX                  \ interrupt clear-enable x


\
\ @brief GICD interrupt clear-enable register 5
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER5_ICENABLERX                  \ interrupt clear-enable x


\
\ @brief GICD interrupt set-pending register 0
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR0_ISPENDRX                      \ interrupt set-pending x


\
\ @brief GICD interrupt set-pending register 1
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR1_ISPENDRX                      \ interrupt set-pending x


\
\ @brief GICD interrupt set-pending register 2
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR2_ISPENDRX                      \ interrupt set-pending x


\
\ @brief GICD interrupt set-pending register 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR3_ISPENDRX                      \ interrupt set-pending x


\
\ @brief GICD interrupt set-pending register 4
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR4_ISPENDRX                      \ interrupt set-pending x


\
\ @brief GICD interrupt set-pending register 5
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR5_ISPENDRX                      \ interrupt set-pending x


\
\ @brief GICD interrupt clear-pending register 0
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR0_ICPENDRX                      \ interrupt clear-pending x


\
\ @brief GICD interrupt clear-pending register 1
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR1_ICPENDRX                      \ interrupt clear-pending x


\
\ @brief GICD interrupt clear-pending register 2
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR2_ICPENDRX                      \ interrupt clear-pending x


\
\ @brief GICD interrupt clear-pending register 3
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR3_ICPENDRX                      \ interrupt clear-pending x


\
\ @brief GICD interrupt clear-pending register 4
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR4_ICPENDRX                      \ interrupt clear-pending x


\
\ @brief GICD interrupt clear-pending register 5
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR5_ICPENDRX                      \ interrupt clear-pending x


\
\ @brief GICD interrupt set-active register 0
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER0_ISACTIVERX                  \ interrupt set-active x


\
\ @brief GICD interrupt set-active register 1
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER1_ISACTIVERX                  \ interrupt set-active x


\
\ @brief GICD interrupt set-active register 2
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER2_ISACTIVERX                  \ interrupt set-active x


\
\ @brief GICD interrupt set-active register 3
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER3_ISACTIVERX                  \ interrupt set-active x


\
\ @brief GICD interrupt set-active register 4
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER4_ISACTIVERX                  \ interrupt set-active x


\
\ @brief GICD interrupt set-active register 5
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER5_ISACTIVERX                  \ interrupt set-active x


\
\ @brief GICD interrupt clear-active register 0
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER0_ICACTIVERX                  \ interrupt clear-active x


\
\ @brief GICD interrupt clear-active register 1
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER1_ICACTIVERX                  \ interrupt clear-active x


\
\ @brief GICD interrupt clear-active register 2
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER2_ICACTIVERX                  \ interrupt clear-active x


\
\ @brief GICD interrupt clear-active register 3
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER3_ICACTIVERX                  \ interrupt clear-active x


\
\ @brief GICD interrupt clear-active register 4
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER4_ICACTIVERX                  \ interrupt clear-active x


\
\ @brief GICD interrupt clear-active register 5
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER5_ICACTIVERX                  \ interrupt clear-active x


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR0_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR0_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR0_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR0_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR1_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR1_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR1_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR1_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR2_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR2_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR2_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR2_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR3_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR3_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR3_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR3_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR4_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR4_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR4_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR4_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR5_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR5_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR5_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR5_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR6_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR6_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR6_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR6_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR7_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR7_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR7_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR7_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR8_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR8_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR8_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR8_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR9_PRIORITY0                  \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR9_PRIORITY1                  \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR9_PRIORITY2                  \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR9_PRIORITY3                  \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR10_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR10_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR10_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR10_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x42C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR11_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR11_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR11_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR11_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR12_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR12_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR12_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR12_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x434
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR13_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR13_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR13_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR13_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x438
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR14_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR14_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR14_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR14_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x43C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR15_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR15_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR15_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR15_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR16_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR16_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR16_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR16_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x444
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR17_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR17_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR17_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR17_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x448
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR18_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR18_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR18_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR18_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR19_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR19_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR19_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR19_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x450
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR20_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR20_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR20_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR20_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x454
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR21_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR21_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR21_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR21_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x458
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR22_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR22_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR22_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR22_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x45C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR23_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR23_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR23_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR23_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x460
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR24_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR24_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR24_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR24_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR25_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR25_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR25_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR25_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x468
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR26_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR26_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR26_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR26_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x46C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR27_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR27_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR27_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR27_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x470
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR28_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR28_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR28_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR28_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x474
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR29_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR29_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR29_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR29_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x478
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR30_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR30_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR30_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR30_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x47C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR31_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR31_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR31_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR31_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x480
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR32_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR32_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR32_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR32_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x484
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR33_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR33_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR33_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR33_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x488
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR34_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR34_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR34_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR34_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x48C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR35_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR35_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR35_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR35_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR36_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR36_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR36_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR36_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR37_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR37_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR37_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR37_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR38_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR38_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR38_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR38_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR39_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR39_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR39_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR39_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR40_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR40_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR40_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR40_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x4A4
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR41_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR41_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR41_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR41_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x4A8
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR42_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR42_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR42_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR42_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x4AC
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR43_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR43_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR43_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR43_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x4B0
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR44_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR44_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR44_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR44_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x4B4
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR45_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR45_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR45_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR45_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x4B8
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR46_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR46_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR46_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR46_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief priority for interrupt ID = x * 4
\ Address offset: 0x4BC
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR47_PRIORITY0                 \ priority for interrupt ID = x * 4
$0000f800 constant GICD_GICD_IPRIORITYR47_PRIORITY1                 \ priority for interrupt ID = x * 4 + 1
$00f80000 constant GICD_GICD_IPRIORITYR47_PRIORITY2                 \ priority for interrupt ID = x * 4 + 2
$f8000000 constant GICD_GICD_IPRIORITYR47_PRIORITY3                 \ priority for interrupt ID = x * 4 + 3


\
\ @brief GICD interrupt processor target register 0
\ Address offset: 0x800
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR0_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR0_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR0_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR0_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief GICD interrupt processor target register 1
\ Address offset: 0x804
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR1_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR1_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR1_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR1_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief GICD interrupt processor target register 2
\ Address offset: 0x808
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR2_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR2_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR2_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR2_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief GICD interrupt processor target register 3
\ Address offset: 0x80C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR3_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR3_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR3_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR3_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief GICD interrupt processor target register 4
\ Address offset: 0x810
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR4_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR4_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR4_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR4_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief GICD interrupt processor target register 5
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR5_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR5_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR5_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR5_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief GICD interrupt processor target register 6
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR6_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR6_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR6_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR6_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief GICD interrupt processor target register 7
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR7_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR7_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR7_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR7_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x820
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR8_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR8_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR8_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR8_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x824
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR9_CPU_TARGETS0                \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR9_CPU_TARGETS1                \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR9_CPU_TARGETS2                \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR9_CPU_TARGETS3                \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x828
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR10_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR10_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR10_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR10_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x82C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR11_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR11_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR11_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR11_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x830
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR12_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR12_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR12_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR12_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x834
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR13_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR13_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR13_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR13_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x838
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR14_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR14_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR14_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR14_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x83C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR15_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR15_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR15_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR15_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x840
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR16_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR16_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR16_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR16_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x844
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR17_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR17_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR17_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR17_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x848
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR18_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR18_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR18_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR18_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x84C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR19_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR19_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR19_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR19_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x850
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR20_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR20_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR20_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR20_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x854
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR21_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR21_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR21_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR21_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x858
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR22_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR22_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR22_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR22_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x85C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR23_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR23_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR23_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR23_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x860
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR24_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR24_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR24_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR24_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x864
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR25_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR25_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR25_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR25_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x868
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR26_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR26_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR26_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR26_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x86C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR27_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR27_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR27_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR27_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x870
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR28_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR28_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR28_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR28_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x874
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR29_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR29_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR29_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR29_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x878
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR30_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR30_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR30_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR30_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x87C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR31_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR31_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR31_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR31_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x880
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR32_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR32_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR32_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR32_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x884
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR33_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR33_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR33_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR33_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x888
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR34_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR34_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR34_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR34_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x88C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR35_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR35_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR35_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR35_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x890
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR36_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR36_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR36_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR36_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x894
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR37_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR37_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR37_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR37_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x898
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR38_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR38_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR38_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR38_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x89C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR39_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR39_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR39_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR39_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x8A0
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR40_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR40_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR40_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR40_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x8A4
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR41_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR41_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR41_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR41_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x8A8
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR42_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR42_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR42_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR42_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x8AC
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR43_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR43_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR43_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR43_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x8B0
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR44_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR44_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR44_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR44_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x8B4
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR45_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR45_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR45_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR45_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x8B8
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR46_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR46_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR46_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR46_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief CPU(s) target for interrupt ID = x * 4
\ Address offset: 0x8BC
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR47_CPU_TARGETS0               \ CPU(s) target for interrupt ID = x * 4
$00000300 constant GICD_GICD_ITARGETSR47_CPU_TARGETS1               \ CPU(s) target for interrupt ID = x * 4 + 1
$00030000 constant GICD_GICD_ITARGETSR47_CPU_TARGETS2               \ CPU(s) target for interrupt ID = x * 4 + 2
$03000000 constant GICD_GICD_ITARGETSR47_CPU_TARGETS3               \ CPU(s) target for interrupt ID = x * 4 + 3


\
\ @brief interrupt config for interrupt ID = 0
\ Address offset: 0xC00
\ Reset value: 0xAAAAAAAA
\

$00000003 constant GICD_GICD_ICFGR0_INT_CONFIG0                     \ interrupt config for interrupt ID = 0
$0000000c constant GICD_GICD_ICFGR0_INT_CONFIG1                     \ interrupt config for interrupt ID = 1
$00000030 constant GICD_GICD_ICFGR0_INT_CONFIG2                     \ interrupt config for interrupt ID = 2
$000000c0 constant GICD_GICD_ICFGR0_INT_CONFIG3                     \ interrupt config for interrupt ID = 3
$00000300 constant GICD_GICD_ICFGR0_INT_CONFIG4                     \ interrupt config for interrupt ID = 4
$00000c00 constant GICD_GICD_ICFGR0_INT_CONFIG5                     \ interrupt config for interrupt ID = 5
$00003000 constant GICD_GICD_ICFGR0_INT_CONFIG6                     \ interrupt config for interrupt ID = 6
$0000c000 constant GICD_GICD_ICFGR0_INT_CONFIG7                     \ interrupt config for interrupt ID = 7
$00030000 constant GICD_GICD_ICFGR0_INT_CONFIG8                     \ interrupt config for interrupt ID = 8
$000c0000 constant GICD_GICD_ICFGR0_INT_CONFIG9                     \ interrupt config for interrupt ID = 9
$00300000 constant GICD_GICD_ICFGR0_INT_CONFIG10                    \ interrupt config for interrupt ID = 10
$00c00000 constant GICD_GICD_ICFGR0_INT_CONFIG11                    \ interrupt config for interrupt ID = 11
$03000000 constant GICD_GICD_ICFGR0_INT_CONFIG12                    \ interrupt config for interrupt ID = 12
$0c000000 constant GICD_GICD_ICFGR0_INT_CONFIG13                    \ interrupt config for interrupt ID = 13
$30000000 constant GICD_GICD_ICFGR0_INT_CONFIG14                    \ interrupt config for interrupt ID = 14
$c0000000 constant GICD_GICD_ICFGR0_INT_CONFIG15                    \ interrupt config for interrupt ID = 15


\
\ @brief GICD interrupt configuration register
\ Address offset: 0xC04
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ICFGR1_INT_CONFIG0                     \ interrupt config for interrupt ID = 16
$0000000c constant GICD_GICD_ICFGR1_INT_CONFIG1                     \ interrupt config for interrupt ID = 17
$00000030 constant GICD_GICD_ICFGR1_INT_CONFIG2                     \ interrupt config for interrupt ID = 18
$000000c0 constant GICD_GICD_ICFGR1_INT_CONFIG3                     \ interrupt config for interrupt ID = 19
$00000300 constant GICD_GICD_ICFGR1_INT_CONFIG4                     \ interrupt config for interrupt ID = 20
$00000c00 constant GICD_GICD_ICFGR1_INT_CONFIG5                     \ interrupt config for interrupt ID = 21
$00003000 constant GICD_GICD_ICFGR1_INT_CONFIG6                     \ interrupt config for interrupt ID = 22
$0000c000 constant GICD_GICD_ICFGR1_INT_CONFIG7                     \ interrupt config for interrupt ID = 23
$00030000 constant GICD_GICD_ICFGR1_INT_CONFIG8                     \ interrupt config for interrupt ID = 24
$000c0000 constant GICD_GICD_ICFGR1_INT_CONFIG9                     \ interrupt config for interrupt ID = 25
$00300000 constant GICD_GICD_ICFGR1_INT_CONFIG10                    \ interrupt config for interrupt ID = 26
$00c00000 constant GICD_GICD_ICFGR1_INT_CONFIG11                    \ interrupt config for interrupt ID = 27
$03000000 constant GICD_GICD_ICFGR1_INT_CONFIG12                    \ interrupt config for interrupt ID = 28
$0c000000 constant GICD_GICD_ICFGR1_INT_CONFIG13                    \ interrupt config for interrupt ID = 29
$30000000 constant GICD_GICD_ICFGR1_INT_CONFIG14                    \ interrupt config for interrupt ID = 30
$c0000000 constant GICD_GICD_ICFGR1_INT_CONFIG15                    \ interrupt config for interrupt ID = 31


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC08
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR2_INT_CONFIG0                     \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR2_INT_CONFIG1                     \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR2_INT_CONFIG2                     \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR2_INT_CONFIG3                     \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR2_INT_CONFIG4                     \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR2_INT_CONFIG5                     \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR2_INT_CONFIG6                     \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR2_INT_CONFIG7                     \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR2_INT_CONFIG8                     \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR2_INT_CONFIG9                     \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR2_INT_CONFIG10                    \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR2_INT_CONFIG11                    \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR2_INT_CONFIG12                    \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR2_INT_CONFIG13                    \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR2_INT_CONFIG14                    \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR2_INT_CONFIG15                    \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC0C
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR3_INT_CONFIG0                     \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR3_INT_CONFIG1                     \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR3_INT_CONFIG2                     \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR3_INT_CONFIG3                     \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR3_INT_CONFIG4                     \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR3_INT_CONFIG5                     \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR3_INT_CONFIG6                     \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR3_INT_CONFIG7                     \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR3_INT_CONFIG8                     \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR3_INT_CONFIG9                     \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR3_INT_CONFIG10                    \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR3_INT_CONFIG11                    \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR3_INT_CONFIG12                    \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR3_INT_CONFIG13                    \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR3_INT_CONFIG14                    \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR3_INT_CONFIG15                    \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC10
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR4_INT_CONFIG0                     \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR4_INT_CONFIG1                     \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR4_INT_CONFIG2                     \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR4_INT_CONFIG3                     \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR4_INT_CONFIG4                     \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR4_INT_CONFIG5                     \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR4_INT_CONFIG6                     \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR4_INT_CONFIG7                     \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR4_INT_CONFIG8                     \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR4_INT_CONFIG9                     \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR4_INT_CONFIG10                    \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR4_INT_CONFIG11                    \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR4_INT_CONFIG12                    \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR4_INT_CONFIG13                    \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR4_INT_CONFIG14                    \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR4_INT_CONFIG15                    \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC14
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR5_INT_CONFIG0                     \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR5_INT_CONFIG1                     \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR5_INT_CONFIG2                     \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR5_INT_CONFIG3                     \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR5_INT_CONFIG4                     \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR5_INT_CONFIG5                     \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR5_INT_CONFIG6                     \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR5_INT_CONFIG7                     \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR5_INT_CONFIG8                     \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR5_INT_CONFIG9                     \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR5_INT_CONFIG10                    \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR5_INT_CONFIG11                    \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR5_INT_CONFIG12                    \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR5_INT_CONFIG13                    \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR5_INT_CONFIG14                    \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR5_INT_CONFIG15                    \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC18
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR6_INT_CONFIG0                     \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR6_INT_CONFIG1                     \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR6_INT_CONFIG2                     \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR6_INT_CONFIG3                     \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR6_INT_CONFIG4                     \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR6_INT_CONFIG5                     \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR6_INT_CONFIG6                     \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR6_INT_CONFIG7                     \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR6_INT_CONFIG8                     \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR6_INT_CONFIG9                     \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR6_INT_CONFIG10                    \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR6_INT_CONFIG11                    \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR6_INT_CONFIG12                    \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR6_INT_CONFIG13                    \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR6_INT_CONFIG14                    \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR6_INT_CONFIG15                    \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC1C
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR7_INT_CONFIG0                     \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR7_INT_CONFIG1                     \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR7_INT_CONFIG2                     \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR7_INT_CONFIG3                     \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR7_INT_CONFIG4                     \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR7_INT_CONFIG5                     \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR7_INT_CONFIG6                     \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR7_INT_CONFIG7                     \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR7_INT_CONFIG8                     \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR7_INT_CONFIG9                     \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR7_INT_CONFIG10                    \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR7_INT_CONFIG11                    \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR7_INT_CONFIG12                    \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR7_INT_CONFIG13                    \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR7_INT_CONFIG14                    \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR7_INT_CONFIG15                    \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC20
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR8_INT_CONFIG0                     \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR8_INT_CONFIG1                     \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR8_INT_CONFIG2                     \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR8_INT_CONFIG3                     \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR8_INT_CONFIG4                     \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR8_INT_CONFIG5                     \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR8_INT_CONFIG6                     \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR8_INT_CONFIG7                     \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR8_INT_CONFIG8                     \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR8_INT_CONFIG9                     \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR8_INT_CONFIG10                    \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR8_INT_CONFIG11                    \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR8_INT_CONFIG12                    \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR8_INT_CONFIG13                    \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR8_INT_CONFIG14                    \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR8_INT_CONFIG15                    \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC24
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR9_INT_CONFIG0                     \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR9_INT_CONFIG1                     \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR9_INT_CONFIG2                     \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR9_INT_CONFIG3                     \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR9_INT_CONFIG4                     \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR9_INT_CONFIG5                     \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR9_INT_CONFIG6                     \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR9_INT_CONFIG7                     \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR9_INT_CONFIG8                     \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR9_INT_CONFIG9                     \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR9_INT_CONFIG10                    \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR9_INT_CONFIG11                    \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR9_INT_CONFIG12                    \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR9_INT_CONFIG13                    \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR9_INT_CONFIG14                    \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR9_INT_CONFIG15                    \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC28
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR10_INT_CONFIG0                    \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR10_INT_CONFIG1                    \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR10_INT_CONFIG2                    \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR10_INT_CONFIG3                    \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR10_INT_CONFIG4                    \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR10_INT_CONFIG5                    \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR10_INT_CONFIG6                    \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR10_INT_CONFIG7                    \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR10_INT_CONFIG8                    \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR10_INT_CONFIG9                    \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR10_INT_CONFIG10                   \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR10_INT_CONFIG11                   \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR10_INT_CONFIG12                   \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR10_INT_CONFIG13                   \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR10_INT_CONFIG14                   \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR10_INT_CONFIG15                   \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief interrupt config for interrupt ID = x * 16
\ Address offset: 0xC2C
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR11_INT_CONFIG0                    \ interrupt config for interrupt ID = x * 16
$0000000c constant GICD_GICD_ICFGR11_INT_CONFIG1                    \ interrupt config for interrupt ID = x * 16 + 1
$00000030 constant GICD_GICD_ICFGR11_INT_CONFIG2                    \ interrupt config for interrupt ID = x * 16 + 2
$000000c0 constant GICD_GICD_ICFGR11_INT_CONFIG3                    \ interrupt config for interrupt ID = x * 16 + 3
$00000300 constant GICD_GICD_ICFGR11_INT_CONFIG4                    \ interrupt config for interrupt ID = x * 16 + 4
$00000c00 constant GICD_GICD_ICFGR11_INT_CONFIG5                    \ interrupt config for interrupt ID = x * 16 + 5
$00003000 constant GICD_GICD_ICFGR11_INT_CONFIG6                    \ interrupt config for interrupt ID = x * 16 + 6
$0000c000 constant GICD_GICD_ICFGR11_INT_CONFIG7                    \ interrupt config for interrupt ID = x * 16 + 7
$00030000 constant GICD_GICD_ICFGR11_INT_CONFIG8                    \ interrupt config for interrupt ID = x * 16 + 8
$000c0000 constant GICD_GICD_ICFGR11_INT_CONFIG9                    \ interrupt config for interrupt ID = x * 16 + 9
$00300000 constant GICD_GICD_ICFGR11_INT_CONFIG10                   \ interrupt config for interrupt ID = x * 16 + 10
$00c00000 constant GICD_GICD_ICFGR11_INT_CONFIG11                   \ interrupt config for interrupt ID = x * 16 + 11
$03000000 constant GICD_GICD_ICFGR11_INT_CONFIG12                   \ interrupt config for interrupt ID = x * 16 + 12
$0c000000 constant GICD_GICD_ICFGR11_INT_CONFIG13                   \ interrupt config for interrupt ID = x * 16 + 13
$30000000 constant GICD_GICD_ICFGR11_INT_CONFIG14                   \ interrupt config for interrupt ID = x * 16 + 14
$c0000000 constant GICD_GICD_ICFGR11_INT_CONFIG15                   \ interrupt config for interrupt ID = x * 16 + 15


\
\ @brief virtual maintenance interrupt
\ Address offset: 0xD00
\ Reset value: 0x00000000
\

$00000200 constant GICD_GICD_PPISR_PPI6                             \ virtual maintenance interrupt
$00000400 constant GICD_GICD_PPISR_PPI5                             \ hypervisor timer event
$00000800 constant GICD_GICD_PPISR_PPI4                             \ virtual timer event
$00001000 constant GICD_GICD_PPISR_PPI0                             \ nFIQ (not used)
$00002000 constant GICD_GICD_PPISR_PPI1                             \ secure physical timer event
$00004000 constant GICD_GICD_PPISR_PPI2                             \ secure physical timer event
$00008000 constant GICD_GICD_PPISR_PPI3                             \ nIRQ (not used)


\
\ @brief GICD shared peripheral interrupt register 0
\ Address offset: 0xD04
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR0_SPISRX                          \ shared peripheral interrupt


\
\ @brief GICD shared peripheral interrupt register 1
\ Address offset: 0xD08
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR1_SPISRX                          \ shared peripheral interrupt


\
\ @brief GICD shared peripheral interrupt register 2
\ Address offset: 0xD0C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR2_SPISRX                          \ shared peripheral interrupt


\
\ @brief GICD shared peripheral interrupt register 3
\ Address offset: 0xD10
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR3_SPISRX                          \ shared peripheral interrupt


\
\ @brief GICD shared peripheral interrupt register 4
\ Address offset: 0xD14
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR4_SPISRX                          \ shared peripheral interrupt


\
\ @brief SGI interrupt ID The value of this field is the interrupt ID of the SGI to forward to the specified CPU interfaces, in the range 0-15 (for example: a value of 0b0011 specifies interrupt ID 3).
\ Address offset: 0xF00
\ Reset value: 0x00000000
\

$0000000f constant GICD_GICD_SGIR_SGIINTID                          \ SGI interrupt ID The value of this field is the interrupt ID of the SGI to forward to the specified CPU interfaces, in the range 0-15 (for example: a value of 0b0011 specifies interrupt ID 3).
$00008000 constant GICD_GICD_SGIR_NSATT                             \ non-secure attribute It specifies the required security value of the SGI: 0 - Forward the SGI specified in the SGIINTID field to a specified CPU interface only if the SGI is configured as group 0 on that interface. 1 - Forward the SGI specified in the SGIINTID field to a specified CPU interfaces only if the SGI is configured as group 1 on that interface. This field is writable only by a secure access. Any non-secure write to the GICD_SGIR generates an SGI only if the specified SGI is programmed as group 1.
$00030000 constant GICD_GICD_SGIR_CPUTARGETLIST                     \ CPU target list When TARGETLISTFILTER = 0b00, defines the CPU interfaces to which the GICD must forward the interrupt. Each bit of CPUTARGETLIST[1:0] refers to the corresponding CPU interface. If this field is 0 when TARGETLISTFILTER is 0b00, the GICD does not forward the interrupt to any CPU interface.
$03000000 constant GICD_GICD_SGIR_TARGETLISTFILTER                  \ target list filter Determines how the distributor must process the requested SGI 2: Forward the interrupt only to the CPU interface of the processor which requested the interrupt 3: Reserved, must be kept at reset value.


\
\ @brief GICD SGI clear-pending register 0
\ Address offset: 0xF10
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_CPENDSGIR0_SGI_CLEAR_PENDING0          \ clear-pending state for SGI [x * 4] Writing a 1 clears the pending state of the SGI [x * 4] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
$00000300 constant GICD_GICD_CPENDSGIR0_SGI_CLEAR_PENDING1          \ clear-pending state for SGI [x * 4 + 1] Writing a 1 clears the pending state of the SGI [x * 4 + 1] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
$00030000 constant GICD_GICD_CPENDSGIR0_SGI_CLEAR_PENDING2          \ clear-pending state for SGI [x * 4 + 2] Writing a 1 clears the pending state of the SGI [x * 4 + 2] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
$03000000 constant GICD_GICD_CPENDSGIR0_SGI_CLEAR_PENDING3          \ clear-pending state for SGI [x * 4 + 3] Writing a 1 clears the pending state of the SGI [x * 4 + 3] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.


\
\ @brief GICD SGI clear-pending register 1
\ Address offset: 0xF14
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_CPENDSGIR1_SGI_CLEAR_PENDING0          \ clear-pending state for SGI [x * 4] Writing a 1 clears the pending state of the SGI [x * 4] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
$00000300 constant GICD_GICD_CPENDSGIR1_SGI_CLEAR_PENDING1          \ clear-pending state for SGI [x * 4 + 1] Writing a 1 clears the pending state of the SGI [x * 4 + 1] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
$00030000 constant GICD_GICD_CPENDSGIR1_SGI_CLEAR_PENDING2          \ clear-pending state for SGI [x * 4 + 2] Writing a 1 clears the pending state of the SGI [x * 4 + 2] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
$03000000 constant GICD_GICD_CPENDSGIR1_SGI_CLEAR_PENDING3          \ clear-pending state for SGI [x * 4 + 3] Writing a 1 clears the pending state of the SGI [x * 4 + 3] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.


\
\ @brief GICD SGI clear-pending register 2
\ Address offset: 0xF18
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_CPENDSGIR2_SGI_CLEAR_PENDING0          \ clear-pending state for SGI [x * 4] Writing a 1 clears the pending state of the SGI [x * 4] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
$00000300 constant GICD_GICD_CPENDSGIR2_SGI_CLEAR_PENDING1          \ clear-pending state for SGI [x * 4 + 1] Writing a 1 clears the pending state of the SGI [x * 4 + 1] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
$00030000 constant GICD_GICD_CPENDSGIR2_SGI_CLEAR_PENDING2          \ clear-pending state for SGI [x * 4 + 2] Writing a 1 clears the pending state of the SGI [x * 4 + 2] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
$03000000 constant GICD_GICD_CPENDSGIR2_SGI_CLEAR_PENDING3          \ clear-pending state for SGI [x * 4 + 3] Writing a 1 clears the pending state of the SGI [x * 4 + 3] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.


\
\ @brief GICD SGI clear-pending register 3
\ Address offset: 0xF1C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_CPENDSGIR3_SGI_CLEAR_PENDING0          \ clear-pending state for SGI [x * 4] Writing a 1 clears the pending state of the SGI [x * 4] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
$00000300 constant GICD_GICD_CPENDSGIR3_SGI_CLEAR_PENDING1          \ clear-pending state for SGI [x * 4 + 1] Writing a 1 clears the pending state of the SGI [x * 4 + 1] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
$00030000 constant GICD_GICD_CPENDSGIR3_SGI_CLEAR_PENDING2          \ clear-pending state for SGI [x * 4 + 2] Writing a 1 clears the pending state of the SGI [x * 4 + 2] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
$03000000 constant GICD_GICD_CPENDSGIR3_SGI_CLEAR_PENDING3          \ clear-pending state for SGI [x * 4 + 3] Writing a 1 clears the pending state of the SGI [x * 4 + 3] for the corresponding source processor, and no longer targets the processor performing the write. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.


\
\ @brief GICD SGI set-pending register 0
\ Address offset: 0xF20
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_SPENDSGIR0_SGI_SET_PENDING0            \ set-pending state for SGI [x * 4] Writing a 1 sets the pending state of the SGI [x * 4] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
$00000300 constant GICD_GICD_SPENDSGIR0_SGI_SET_PENDING1            \ set-pending state for SGI [x * 4 + 1] Writing a 1 sets the pending state of the SGI [x * 4 + 1] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
$00030000 constant GICD_GICD_SPENDSGIR0_SGI_SET_PENDING2            \ set-pending state for SGI [x * 4 + 2] Writing a 1 sets the pending state of the SGI [x * 4 + 2] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
$03000000 constant GICD_GICD_SPENDSGIR0_SGI_SET_PENDING3            \ set-pending state for SGI [x * 4 + 3] Writing a 1 sets the pending state of the SGI [x * 4 + 3] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.


\
\ @brief GICD SGI set-pending register 1
\ Address offset: 0xF24
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_SPENDSGIR1_SGI_SET_PENDING0            \ set-pending state for SGI [x * 4] Writing a 1 sets the pending state of the SGI [x * 4] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
$00000300 constant GICD_GICD_SPENDSGIR1_SGI_SET_PENDING1            \ set-pending state for SGI [x * 4 + 1] Writing a 1 sets the pending state of the SGI [x * 4 + 1] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
$00030000 constant GICD_GICD_SPENDSGIR1_SGI_SET_PENDING2            \ set-pending state for SGI [x * 4 + 2] Writing a 1 sets the pending state of the SGI [x * 4 + 2] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
$03000000 constant GICD_GICD_SPENDSGIR1_SGI_SET_PENDING3            \ set-pending state for SGI [x * 4 + 3] Writing a 1 sets the pending state of the SGI [x * 4 + 3] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.


\
\ @brief GICD SGI set-pending register 2
\ Address offset: 0xF28
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_SPENDSGIR2_SGI_SET_PENDING0            \ set-pending state for SGI [x * 4] Writing a 1 sets the pending state of the SGI [x * 4] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
$00000300 constant GICD_GICD_SPENDSGIR2_SGI_SET_PENDING1            \ set-pending state for SGI [x * 4 + 1] Writing a 1 sets the pending state of the SGI [x * 4 + 1] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
$00030000 constant GICD_GICD_SPENDSGIR2_SGI_SET_PENDING2            \ set-pending state for SGI [x * 4 + 2] Writing a 1 sets the pending state of the SGI [x * 4 + 2] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
$03000000 constant GICD_GICD_SPENDSGIR2_SGI_SET_PENDING3            \ set-pending state for SGI [x * 4 + 3] Writing a 1 sets the pending state of the SGI [x * 4 + 3] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.


\
\ @brief GICD SGI set-pending register 3
\ Address offset: 0xF2C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_SPENDSGIR3_SGI_SET_PENDING0            \ set-pending state for SGI [x * 4] Writing a 1 sets the pending state of the SGI [x * 4] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4] is pending, from the corresponding source processor, on the reading processor.
$00000300 constant GICD_GICD_SPENDSGIR3_SGI_SET_PENDING1            \ set-pending state for SGI [x * 4 + 1] Writing a 1 sets the pending state of the SGI [x * 4 + 1] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 1] is pending, from the corresponding source processor, on the reading processor.
$00030000 constant GICD_GICD_SPENDSGIR3_SGI_SET_PENDING2            \ set-pending state for SGI [x * 4 + 2] Writing a 1 sets the pending state of the SGI [x * 4 + 2] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 2] is pending, from the corresponding source processor, on the reading processor.
$03000000 constant GICD_GICD_SPENDSGIR3_SGI_SET_PENDING3            \ set-pending state for SGI [x * 4 + 3] Writing a 1 sets the pending state of the SGI [x * 4 + 3] for the corresponding source processor. Writing a 0 has no effect. Reading a bit identifies whether the SGI [x * 4 + 3] is pending, from the corresponding source processor, on the reading processor.


\
\ @brief peripheral ID4
\ Address offset: 0xFD0
\ Reset value: 0x00000004
\

$00000000 constant GICD_GICD_PIDR4_PIDR4                            \ peripheral ID4


\
\ @brief peripheral ID5 to ID7
\ Address offset: 0xFD4
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_PIDR5_PIDRX                            \ peripheral ID5 to ID7


\
\ @brief peripheral ID5 to ID7
\ Address offset: 0xFD8
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_PIDR6_PIDRX                            \ peripheral ID5 to ID7


\
\ @brief peripheral ID5 to ID7
\ Address offset: 0xFDC
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_PIDR7_PIDRX                            \ peripheral ID5 to ID7


\
\ @brief peripheral ID0
\ Address offset: 0xFE0
\ Reset value: 0x00000090
\

$00000000 constant GICD_GICD_PIDR0_PIDR0                            \ peripheral ID0


\
\ @brief peripheral ID1
\ Address offset: 0xFE4
\ Reset value: 0x000000B4
\

$00000000 constant GICD_GICD_PIDR1_PIDR1                            \ peripheral ID1


\
\ @brief peripheral ID2
\ Address offset: 0xFE8
\ Reset value: 0x0000002B
\

$00000000 constant GICD_GICD_PIDR2_PIDR2                            \ peripheral ID2


\
\ @brief peripheral ID3
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_PIDR3_PIDR3                            \ peripheral ID3


\
\ @brief component ID0
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$00000000 constant GICD_GICD_CIDR0_CIDR0                            \ component ID0


\
\ @brief component ID1
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$00000000 constant GICD_GICD_CIDR1_CIDR1                            \ component ID1


\
\ @brief component ID2
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$00000000 constant GICD_GICD_CIDR2_CIDR2                            \ component ID2


\
\ @brief component ID3
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$00000000 constant GICD_GICD_CIDR3_CIDR3                            \ component ID3


\
\ @brief GICD address block description
\
$a0021000 constant GICD_GICD_CTLR  \ offset: 0x00 : GICD_CTLR
$a0021000 constant GICD_GICD_CTLRNS  \ offset: 0x00 : GICD_CTLRNS
$a0021004 constant GICD_GICD_TYPER  \ offset: 0x04 : number of interrupt lines Indicates the number of interrupts that the GIC supports (0b00101 = Up to 192 interrupts, 160 external interrupts)
$a0021008 constant GICD_GICD_IIDR  \ offset: 0x08 : GIC implementer (0x43B Arm implementation)
$a0021080 constant GICD_GICD_IGROUPR0  \ offset: 0x80 : GICD interrupt group register 0
$a0021084 constant GICD_GICD_IGROUPR1  \ offset: 0x84 : GICD interrupt group register 1
$a0021088 constant GICD_GICD_IGROUPR2  \ offset: 0x88 : GICD interrupt group register 2
$a002108c constant GICD_GICD_IGROUPR3  \ offset: 0x8C : GICD interrupt group register 3
$a0021090 constant GICD_GICD_IGROUPR4  \ offset: 0x90 : GICD interrupt group register 4
$a0021094 constant GICD_GICD_IGROUPR5  \ offset: 0x94 : GICD interrupt group register 5
$a0021100 constant GICD_GICD_ISENABLER0  \ offset: 0x100 : GICD interrupt set-enable register
$a0021104 constant GICD_GICD_ISENABLER1  \ offset: 0x104 : GICD interrupt set-enable register 1
$a0021108 constant GICD_GICD_ISENABLER2  \ offset: 0x108 : GICD interrupt set-enable register 2
$a002110c constant GICD_GICD_ISENABLER3  \ offset: 0x10C : GICD interrupt set-enable register 3
$a0021110 constant GICD_GICD_ISENABLER4  \ offset: 0x110 : GICD interrupt set-enable register 4
$a0021114 constant GICD_GICD_ISENABLER5  \ offset: 0x114 : GICD interrupt set-enable register 5
$a0021180 constant GICD_GICD_ICENABLER0  \ offset: 0x180 : GICD interrupt clear-enable register
$a0021184 constant GICD_GICD_ICENABLER1  \ offset: 0x184 : GICD interrupt clear-enable register 1
$a0021188 constant GICD_GICD_ICENABLER2  \ offset: 0x188 : GICD interrupt clear-enable register 2
$a002118c constant GICD_GICD_ICENABLER3  \ offset: 0x18C : GICD interrupt clear-enable register 3
$a0021190 constant GICD_GICD_ICENABLER4  \ offset: 0x190 : GICD interrupt clear-enable register 4
$a0021194 constant GICD_GICD_ICENABLER5  \ offset: 0x194 : GICD interrupt clear-enable register 5
$a0021200 constant GICD_GICD_ISPENDR0  \ offset: 0x200 : GICD interrupt set-pending register 0
$a0021204 constant GICD_GICD_ISPENDR1  \ offset: 0x204 : GICD interrupt set-pending register 1
$a0021208 constant GICD_GICD_ISPENDR2  \ offset: 0x208 : GICD interrupt set-pending register 2
$a002120c constant GICD_GICD_ISPENDR3  \ offset: 0x20C : GICD interrupt set-pending register 3
$a0021210 constant GICD_GICD_ISPENDR4  \ offset: 0x210 : GICD interrupt set-pending register 4
$a0021214 constant GICD_GICD_ISPENDR5  \ offset: 0x214 : GICD interrupt set-pending register 5
$a0021280 constant GICD_GICD_ICPENDR0  \ offset: 0x280 : GICD interrupt clear-pending register 0
$a0021284 constant GICD_GICD_ICPENDR1  \ offset: 0x284 : GICD interrupt clear-pending register 1
$a0021288 constant GICD_GICD_ICPENDR2  \ offset: 0x288 : GICD interrupt clear-pending register 2
$a002128c constant GICD_GICD_ICPENDR3  \ offset: 0x28C : GICD interrupt clear-pending register 3
$a0021290 constant GICD_GICD_ICPENDR4  \ offset: 0x290 : GICD interrupt clear-pending register 4
$a0021294 constant GICD_GICD_ICPENDR5  \ offset: 0x294 : GICD interrupt clear-pending register 5
$a0021300 constant GICD_GICD_ISACTIVER0  \ offset: 0x300 : GICD interrupt set-active register 0
$a0021304 constant GICD_GICD_ISACTIVER1  \ offset: 0x304 : GICD interrupt set-active register 1
$a0021308 constant GICD_GICD_ISACTIVER2  \ offset: 0x308 : GICD interrupt set-active register 2
$a002130c constant GICD_GICD_ISACTIVER3  \ offset: 0x30C : GICD interrupt set-active register 3
$a0021310 constant GICD_GICD_ISACTIVER4  \ offset: 0x310 : GICD interrupt set-active register 4
$a0021314 constant GICD_GICD_ISACTIVER5  \ offset: 0x314 : GICD interrupt set-active register 5
$a0021380 constant GICD_GICD_ICACTIVER0  \ offset: 0x380 : GICD interrupt clear-active register 0
$a0021384 constant GICD_GICD_ICACTIVER1  \ offset: 0x384 : GICD interrupt clear-active register 1
$a0021388 constant GICD_GICD_ICACTIVER2  \ offset: 0x388 : GICD interrupt clear-active register 2
$a002138c constant GICD_GICD_ICACTIVER3  \ offset: 0x38C : GICD interrupt clear-active register 3
$a0021390 constant GICD_GICD_ICACTIVER4  \ offset: 0x390 : GICD interrupt clear-active register 4
$a0021394 constant GICD_GICD_ICACTIVER5  \ offset: 0x394 : GICD interrupt clear-active register 5
$a0021400 constant GICD_GICD_IPRIORITYR0  \ offset: 0x400 : priority for interrupt ID = x * 4
$a0021404 constant GICD_GICD_IPRIORITYR1  \ offset: 0x404 : priority for interrupt ID = x * 4
$a0021408 constant GICD_GICD_IPRIORITYR2  \ offset: 0x408 : priority for interrupt ID = x * 4
$a002140c constant GICD_GICD_IPRIORITYR3  \ offset: 0x40C : priority for interrupt ID = x * 4
$a0021410 constant GICD_GICD_IPRIORITYR4  \ offset: 0x410 : priority for interrupt ID = x * 4
$a0021414 constant GICD_GICD_IPRIORITYR5  \ offset: 0x414 : priority for interrupt ID = x * 4
$a0021418 constant GICD_GICD_IPRIORITYR6  \ offset: 0x418 : priority for interrupt ID = x * 4
$a002141c constant GICD_GICD_IPRIORITYR7  \ offset: 0x41C : priority for interrupt ID = x * 4
$a0021420 constant GICD_GICD_IPRIORITYR8  \ offset: 0x420 : priority for interrupt ID = x * 4
$a0021424 constant GICD_GICD_IPRIORITYR9  \ offset: 0x424 : priority for interrupt ID = x * 4
$a0021428 constant GICD_GICD_IPRIORITYR10  \ offset: 0x428 : priority for interrupt ID = x * 4
$a002142c constant GICD_GICD_IPRIORITYR11  \ offset: 0x42C : priority for interrupt ID = x * 4
$a0021430 constant GICD_GICD_IPRIORITYR12  \ offset: 0x430 : priority for interrupt ID = x * 4
$a0021434 constant GICD_GICD_IPRIORITYR13  \ offset: 0x434 : priority for interrupt ID = x * 4
$a0021438 constant GICD_GICD_IPRIORITYR14  \ offset: 0x438 : priority for interrupt ID = x * 4
$a002143c constant GICD_GICD_IPRIORITYR15  \ offset: 0x43C : priority for interrupt ID = x * 4
$a0021440 constant GICD_GICD_IPRIORITYR16  \ offset: 0x440 : priority for interrupt ID = x * 4
$a0021444 constant GICD_GICD_IPRIORITYR17  \ offset: 0x444 : priority for interrupt ID = x * 4
$a0021448 constant GICD_GICD_IPRIORITYR18  \ offset: 0x448 : priority for interrupt ID = x * 4
$a002144c constant GICD_GICD_IPRIORITYR19  \ offset: 0x44C : priority for interrupt ID = x * 4
$a0021450 constant GICD_GICD_IPRIORITYR20  \ offset: 0x450 : priority for interrupt ID = x * 4
$a0021454 constant GICD_GICD_IPRIORITYR21  \ offset: 0x454 : priority for interrupt ID = x * 4
$a0021458 constant GICD_GICD_IPRIORITYR22  \ offset: 0x458 : priority for interrupt ID = x * 4
$a002145c constant GICD_GICD_IPRIORITYR23  \ offset: 0x45C : priority for interrupt ID = x * 4
$a0021460 constant GICD_GICD_IPRIORITYR24  \ offset: 0x460 : priority for interrupt ID = x * 4
$a0021464 constant GICD_GICD_IPRIORITYR25  \ offset: 0x464 : priority for interrupt ID = x * 4
$a0021468 constant GICD_GICD_IPRIORITYR26  \ offset: 0x468 : priority for interrupt ID = x * 4
$a002146c constant GICD_GICD_IPRIORITYR27  \ offset: 0x46C : priority for interrupt ID = x * 4
$a0021470 constant GICD_GICD_IPRIORITYR28  \ offset: 0x470 : priority for interrupt ID = x * 4
$a0021474 constant GICD_GICD_IPRIORITYR29  \ offset: 0x474 : priority for interrupt ID = x * 4
$a0021478 constant GICD_GICD_IPRIORITYR30  \ offset: 0x478 : priority for interrupt ID = x * 4
$a002147c constant GICD_GICD_IPRIORITYR31  \ offset: 0x47C : priority for interrupt ID = x * 4
$a0021480 constant GICD_GICD_IPRIORITYR32  \ offset: 0x480 : priority for interrupt ID = x * 4
$a0021484 constant GICD_GICD_IPRIORITYR33  \ offset: 0x484 : priority for interrupt ID = x * 4
$a0021488 constant GICD_GICD_IPRIORITYR34  \ offset: 0x488 : priority for interrupt ID = x * 4
$a002148c constant GICD_GICD_IPRIORITYR35  \ offset: 0x48C : priority for interrupt ID = x * 4
$a0021490 constant GICD_GICD_IPRIORITYR36  \ offset: 0x490 : priority for interrupt ID = x * 4
$a0021494 constant GICD_GICD_IPRIORITYR37  \ offset: 0x494 : priority for interrupt ID = x * 4
$a0021498 constant GICD_GICD_IPRIORITYR38  \ offset: 0x498 : priority for interrupt ID = x * 4
$a002149c constant GICD_GICD_IPRIORITYR39  \ offset: 0x49C : priority for interrupt ID = x * 4
$a00214a0 constant GICD_GICD_IPRIORITYR40  \ offset: 0x4A0 : priority for interrupt ID = x * 4
$a00214a4 constant GICD_GICD_IPRIORITYR41  \ offset: 0x4A4 : priority for interrupt ID = x * 4
$a00214a8 constant GICD_GICD_IPRIORITYR42  \ offset: 0x4A8 : priority for interrupt ID = x * 4
$a00214ac constant GICD_GICD_IPRIORITYR43  \ offset: 0x4AC : priority for interrupt ID = x * 4
$a00214b0 constant GICD_GICD_IPRIORITYR44  \ offset: 0x4B0 : priority for interrupt ID = x * 4
$a00214b4 constant GICD_GICD_IPRIORITYR45  \ offset: 0x4B4 : priority for interrupt ID = x * 4
$a00214b8 constant GICD_GICD_IPRIORITYR46  \ offset: 0x4B8 : priority for interrupt ID = x * 4
$a00214bc constant GICD_GICD_IPRIORITYR47  \ offset: 0x4BC : priority for interrupt ID = x * 4
$a0021800 constant GICD_GICD_ITARGETSR0  \ offset: 0x800 : GICD interrupt processor target register 0
$a0021804 constant GICD_GICD_ITARGETSR1  \ offset: 0x804 : GICD interrupt processor target register 1
$a0021808 constant GICD_GICD_ITARGETSR2  \ offset: 0x808 : GICD interrupt processor target register 2
$a002180c constant GICD_GICD_ITARGETSR3  \ offset: 0x80C : GICD interrupt processor target register 3
$a0021810 constant GICD_GICD_ITARGETSR4  \ offset: 0x810 : GICD interrupt processor target register 4
$a0021814 constant GICD_GICD_ITARGETSR5  \ offset: 0x814 : GICD interrupt processor target register 5
$a0021818 constant GICD_GICD_ITARGETSR6  \ offset: 0x818 : GICD interrupt processor target register 6
$a002181c constant GICD_GICD_ITARGETSR7  \ offset: 0x81C : GICD interrupt processor target register 7
$a0021820 constant GICD_GICD_ITARGETSR8  \ offset: 0x820 : CPU(s) target for interrupt ID = x * 4
$a0021824 constant GICD_GICD_ITARGETSR9  \ offset: 0x824 : CPU(s) target for interrupt ID = x * 4
$a0021828 constant GICD_GICD_ITARGETSR10  \ offset: 0x828 : CPU(s) target for interrupt ID = x * 4
$a002182c constant GICD_GICD_ITARGETSR11  \ offset: 0x82C : CPU(s) target for interrupt ID = x * 4
$a0021830 constant GICD_GICD_ITARGETSR12  \ offset: 0x830 : CPU(s) target for interrupt ID = x * 4
$a0021834 constant GICD_GICD_ITARGETSR13  \ offset: 0x834 : CPU(s) target for interrupt ID = x * 4
$a0021838 constant GICD_GICD_ITARGETSR14  \ offset: 0x838 : CPU(s) target for interrupt ID = x * 4
$a002183c constant GICD_GICD_ITARGETSR15  \ offset: 0x83C : CPU(s) target for interrupt ID = x * 4
$a0021840 constant GICD_GICD_ITARGETSR16  \ offset: 0x840 : CPU(s) target for interrupt ID = x * 4
$a0021844 constant GICD_GICD_ITARGETSR17  \ offset: 0x844 : CPU(s) target for interrupt ID = x * 4
$a0021848 constant GICD_GICD_ITARGETSR18  \ offset: 0x848 : CPU(s) target for interrupt ID = x * 4
$a002184c constant GICD_GICD_ITARGETSR19  \ offset: 0x84C : CPU(s) target for interrupt ID = x * 4
$a0021850 constant GICD_GICD_ITARGETSR20  \ offset: 0x850 : CPU(s) target for interrupt ID = x * 4
$a0021854 constant GICD_GICD_ITARGETSR21  \ offset: 0x854 : CPU(s) target for interrupt ID = x * 4
$a0021858 constant GICD_GICD_ITARGETSR22  \ offset: 0x858 : CPU(s) target for interrupt ID = x * 4
$a002185c constant GICD_GICD_ITARGETSR23  \ offset: 0x85C : CPU(s) target for interrupt ID = x * 4
$a0021860 constant GICD_GICD_ITARGETSR24  \ offset: 0x860 : CPU(s) target for interrupt ID = x * 4
$a0021864 constant GICD_GICD_ITARGETSR25  \ offset: 0x864 : CPU(s) target for interrupt ID = x * 4
$a0021868 constant GICD_GICD_ITARGETSR26  \ offset: 0x868 : CPU(s) target for interrupt ID = x * 4
$a002186c constant GICD_GICD_ITARGETSR27  \ offset: 0x86C : CPU(s) target for interrupt ID = x * 4
$a0021870 constant GICD_GICD_ITARGETSR28  \ offset: 0x870 : CPU(s) target for interrupt ID = x * 4
$a0021874 constant GICD_GICD_ITARGETSR29  \ offset: 0x874 : CPU(s) target for interrupt ID = x * 4
$a0021878 constant GICD_GICD_ITARGETSR30  \ offset: 0x878 : CPU(s) target for interrupt ID = x * 4
$a002187c constant GICD_GICD_ITARGETSR31  \ offset: 0x87C : CPU(s) target for interrupt ID = x * 4
$a0021880 constant GICD_GICD_ITARGETSR32  \ offset: 0x880 : CPU(s) target for interrupt ID = x * 4
$a0021884 constant GICD_GICD_ITARGETSR33  \ offset: 0x884 : CPU(s) target for interrupt ID = x * 4
$a0021888 constant GICD_GICD_ITARGETSR34  \ offset: 0x888 : CPU(s) target for interrupt ID = x * 4
$a002188c constant GICD_GICD_ITARGETSR35  \ offset: 0x88C : CPU(s) target for interrupt ID = x * 4
$a0021890 constant GICD_GICD_ITARGETSR36  \ offset: 0x890 : CPU(s) target for interrupt ID = x * 4
$a0021894 constant GICD_GICD_ITARGETSR37  \ offset: 0x894 : CPU(s) target for interrupt ID = x * 4
$a0021898 constant GICD_GICD_ITARGETSR38  \ offset: 0x898 : CPU(s) target for interrupt ID = x * 4
$a002189c constant GICD_GICD_ITARGETSR39  \ offset: 0x89C : CPU(s) target for interrupt ID = x * 4
$a00218a0 constant GICD_GICD_ITARGETSR40  \ offset: 0x8A0 : CPU(s) target for interrupt ID = x * 4
$a00218a4 constant GICD_GICD_ITARGETSR41  \ offset: 0x8A4 : CPU(s) target for interrupt ID = x * 4
$a00218a8 constant GICD_GICD_ITARGETSR42  \ offset: 0x8A8 : CPU(s) target for interrupt ID = x * 4
$a00218ac constant GICD_GICD_ITARGETSR43  \ offset: 0x8AC : CPU(s) target for interrupt ID = x * 4
$a00218b0 constant GICD_GICD_ITARGETSR44  \ offset: 0x8B0 : CPU(s) target for interrupt ID = x * 4
$a00218b4 constant GICD_GICD_ITARGETSR45  \ offset: 0x8B4 : CPU(s) target for interrupt ID = x * 4
$a00218b8 constant GICD_GICD_ITARGETSR46  \ offset: 0x8B8 : CPU(s) target for interrupt ID = x * 4
$a00218bc constant GICD_GICD_ITARGETSR47  \ offset: 0x8BC : CPU(s) target for interrupt ID = x * 4
$a0021c00 constant GICD_GICD_ICFGR0  \ offset: 0xC00 : interrupt config for interrupt ID = 0
$a0021c04 constant GICD_GICD_ICFGR1  \ offset: 0xC04 : GICD interrupt configuration register
$a0021c08 constant GICD_GICD_ICFGR2  \ offset: 0xC08 : interrupt config for interrupt ID = x * 16
$a0021c0c constant GICD_GICD_ICFGR3  \ offset: 0xC0C : interrupt config for interrupt ID = x * 16
$a0021c10 constant GICD_GICD_ICFGR4  \ offset: 0xC10 : interrupt config for interrupt ID = x * 16
$a0021c14 constant GICD_GICD_ICFGR5  \ offset: 0xC14 : interrupt config for interrupt ID = x * 16
$a0021c18 constant GICD_GICD_ICFGR6  \ offset: 0xC18 : interrupt config for interrupt ID = x * 16
$a0021c1c constant GICD_GICD_ICFGR7  \ offset: 0xC1C : interrupt config for interrupt ID = x * 16
$a0021c20 constant GICD_GICD_ICFGR8  \ offset: 0xC20 : interrupt config for interrupt ID = x * 16
$a0021c24 constant GICD_GICD_ICFGR9  \ offset: 0xC24 : interrupt config for interrupt ID = x * 16
$a0021c28 constant GICD_GICD_ICFGR10  \ offset: 0xC28 : interrupt config for interrupt ID = x * 16
$a0021c2c constant GICD_GICD_ICFGR11  \ offset: 0xC2C : interrupt config for interrupt ID = x * 16
$a0021d00 constant GICD_GICD_PPISR  \ offset: 0xD00 : virtual maintenance interrupt
$a0021d04 constant GICD_GICD_SPISR0  \ offset: 0xD04 : GICD shared peripheral interrupt register 0
$a0021d08 constant GICD_GICD_SPISR1  \ offset: 0xD08 : GICD shared peripheral interrupt register 1
$a0021d0c constant GICD_GICD_SPISR2  \ offset: 0xD0C : GICD shared peripheral interrupt register 2
$a0021d10 constant GICD_GICD_SPISR3  \ offset: 0xD10 : GICD shared peripheral interrupt register 3
$a0021d14 constant GICD_GICD_SPISR4  \ offset: 0xD14 : GICD shared peripheral interrupt register 4
$a0021f00 constant GICD_GICD_SGIR  \ offset: 0xF00 : SGI interrupt ID The value of this field is the interrupt ID of the SGI to forward to the specified CPU interfaces, in the range 0-15 (for example: a value of 0b0011 specifies interrupt ID 3).
$a0021f10 constant GICD_GICD_CPENDSGIR0  \ offset: 0xF10 : GICD SGI clear-pending register 0
$a0021f14 constant GICD_GICD_CPENDSGIR1  \ offset: 0xF14 : GICD SGI clear-pending register 1
$a0021f18 constant GICD_GICD_CPENDSGIR2  \ offset: 0xF18 : GICD SGI clear-pending register 2
$a0021f1c constant GICD_GICD_CPENDSGIR3  \ offset: 0xF1C : GICD SGI clear-pending register 3
$a0021f20 constant GICD_GICD_SPENDSGIR0  \ offset: 0xF20 : GICD SGI set-pending register 0
$a0021f24 constant GICD_GICD_SPENDSGIR1  \ offset: 0xF24 : GICD SGI set-pending register 1
$a0021f28 constant GICD_GICD_SPENDSGIR2  \ offset: 0xF28 : GICD SGI set-pending register 2
$a0021f2c constant GICD_GICD_SPENDSGIR3  \ offset: 0xF2C : GICD SGI set-pending register 3
$a0021fd0 constant GICD_GICD_PIDR4  \ offset: 0xFD0 : peripheral ID4
$a0021fd4 constant GICD_GICD_PIDR5  \ offset: 0xFD4 : peripheral ID5 to ID7
$a0021fd8 constant GICD_GICD_PIDR6  \ offset: 0xFD8 : peripheral ID5 to ID7
$a0021fdc constant GICD_GICD_PIDR7  \ offset: 0xFDC : peripheral ID5 to ID7
$a0021fe0 constant GICD_GICD_PIDR0  \ offset: 0xFE0 : peripheral ID0
$a0021fe4 constant GICD_GICD_PIDR1  \ offset: 0xFE4 : peripheral ID1
$a0021fe8 constant GICD_GICD_PIDR2  \ offset: 0xFE8 : peripheral ID2
$a0021fec constant GICD_GICD_PIDR3  \ offset: 0xFEC : peripheral ID3
$a0021ff0 constant GICD_GICD_CIDR0  \ offset: 0xFF0 : component ID0
$a0021ff4 constant GICD_GICD_CIDR1  \ offset: 0xFF4 : component ID1
$a0021ff8 constant GICD_GICD_CIDR2  \ offset: 0xFF8 : component ID2
$a0021ffc constant GICD_GICD_CIDR3  \ offset: 0xFFC : component ID3

