\
\ @file gicd.fs
\ @brief GICD
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GICD control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GICD_GICD_CTLR_ENABLEGRP0                        \ ENABLEGRP0
$00000002 constant GICD_GICD_CTLR_ENABLEGRP1                        \ ENABLEGRP1


\
\ @brief GICD interrupt controller type register
\ Address offset: 0x04
\ Reset value: 0x0000FC28
\

$0000001f constant GICD_GICD_TYPER_ITLINESNUMBER                    \ ITLINESNUMBER
$000000e0 constant GICD_GICD_TYPER_CPUNUMBER                        \ CPUNUMBER
$00000400 constant GICD_GICD_TYPER_SECURITYEXTN                     \ SECURITYEXTN
$0000f800 constant GICD_GICD_TYPER_LSPI                             \ LSPI


\
\ @brief GICD implementer identification register
\ Address offset: 0x08
\ Reset value: 0x0100143B
\

$00000fff constant GICD_GICD_IIDR_IMPLEMENTER                       \ IMPLEMENTER
$0000f000 constant GICD_GICD_IIDR_VARIANT                           \ VARIANT
$000f0000 constant GICD_GICD_IIDR_REVISION                          \ REVISION
$ff000000 constant GICD_GICD_IIDR_PRODUCTID                         \ PRODUCTID


\
\ @brief For interrupts ID
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR0_IGROUPR0                      \ IGROUPR0


\
\ @brief For interrupts ID
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR1_IGROUPR1                      \ IGROUPR1


\
\ @brief For interrupts ID
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR2_IGROUPR2                      \ IGROUPR2


\
\ @brief For interrupts ID = x*32 to ID = x*32+31
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR3_IGROUPR3                      \ IGROUPR3


\
\ @brief For interrupts ID = x*32 to ID = x*32+31
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR4_IGROUPR4                      \ IGROUPR4


\
\ @brief For interrupts ID
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR5_IGROUPR5                      \ IGROUPR5


\
\ @brief For interrupts ID
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR6_IGROUPR6                      \ IGROUPR6


\
\ @brief For interrupts ID
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR7_IGROUPR7                      \ IGROUPR7


\
\ @brief For interrupts ID
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_IGROUPR8_IGROUPR8                      \ IGROUPR8


\
\ @brief For interrupts ID = 0 to ID = 31
\ Address offset: 0x100
\ Reset value: 0x0000FFFF
\

$00000000 constant GICD_GICD_ISENABLER0_ISENABLER0                  \ ISENABLER0


\
\ @brief For interrupts ID
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER1_ISENABLER1                  \ ISENABLER1


\
\ @brief For interrupts ID
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER2_ISENABLER2                  \ ISENABLER2


\
\ @brief For interrupts ID
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER3_ISENABLER3                  \ ISENABLER3


\
\ @brief For interrupts ID
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER4_ISENABLER4                  \ ISENABLER4


\
\ @brief For interrupts ID
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER5_ISENABLER5                  \ ISENABLER5


\
\ @brief For interrupts ID
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER6_ISENABLER6                  \ ISENABLER6


\
\ @brief For interrupts ID
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER7_ISENABLER7                  \ ISENABLER7


\
\ @brief For interrupts ID
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISENABLER8_ISENABLER8                  \ ISENABLER8


\
\ @brief For interrupts ID = 0 to ID = 31
\ Address offset: 0x180
\ Reset value: 0x0000FFFF
\

$00000000 constant GICD_GICD_ICENABLER0_ICENABLER0                  \ ICENABLER0


\
\ @brief For interrupts ID
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER1_ICENABLER1                  \ ICENABLER1


\
\ @brief For interrupts ID
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER2_ICENABLER2                  \ ICENABLER2


\
\ @brief For interrupts ID
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER3_ICENABLER3                  \ ICENABLER3


\
\ @brief For interrupts ID
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER4_ICENABLER4                  \ ICENABLER4


\
\ @brief For interrupts ID
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER5_ICENABLER5                  \ ICENABLER5


\
\ @brief For interrupts ID
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER6_ICENABLER6                  \ ICENABLER6


\
\ @brief For interrupts ID
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER7_ICENABLER7                  \ ICENABLER7


\
\ @brief For interrupts ID
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICENABLER8_ICENABLER8                  \ ICENABLER8


\
\ @brief For interrupts ID
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR0_ISPENDR0                      \ ISPENDR0


\
\ @brief For interrupts ID
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR1_ISPENDR1                      \ ISPENDR1


\
\ @brief For interrupts ID
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR2_ISPENDR2                      \ ISPENDR2


\
\ @brief For interrupts ID
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR3_ISPENDR3                      \ ISPENDR3


\
\ @brief For interrupts ID
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR4_ISPENDR4                      \ ISPENDR4


\
\ @brief For interrupts ID
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR5_ISPENDR5                      \ ISPENDR5


\
\ @brief For interrupts ID
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR6_ISPENDR6                      \ ISPENDR6


\
\ @brief For interrupts ID
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR7_ISPENDR7                      \ ISPENDR7


\
\ @brief For interrupts ID
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISPENDR8_ISPENDR8                      \ ISPENDR8


\
\ @brief For interrupts ID
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR0_ICPENDR0                      \ ICPENDR0


\
\ @brief For interrupts ID
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR1_ICPENDR1                      \ ICPENDR1


\
\ @brief For interrupts ID
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR2_ICPENDR2                      \ ICPENDR2


\
\ @brief For interrupts ID
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR3_ICPENDR3                      \ ICPENDR3


\
\ @brief For interrupts ID
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR4_ICPENDR4                      \ ICPENDR4


\
\ @brief For interrupts ID
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR5_ICPENDR5                      \ ICPENDR5


\
\ @brief For interrupts ID
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR6_ICPENDR6                      \ ICPENDR6


\
\ @brief For interrupts ID
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR7_ICPENDR7                      \ ICPENDR7


\
\ @brief For interrupts ID
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICPENDR8_ICPENDR8                      \ ICPENDR8


\
\ @brief For interrupts ID
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER0_ISACTIVER0                  \ ISACTIVER0


\
\ @brief For interrupts ID
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER1_ISACTIVER1                  \ ISACTIVER1


\
\ @brief For interrupts ID
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER2_ISACTIVER2                  \ ISACTIVER2


\
\ @brief For interrupts ID
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER3_ISACTIVER3                  \ ISACTIVER3


\
\ @brief For interrupts ID
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER4_ISACTIVER4                  \ ISACTIVER4


\
\ @brief For interrupts ID
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER5_ISACTIVER5                  \ ISACTIVER5


\
\ @brief For interrupts ID
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER6_ISACTIVER6                  \ ISACTIVER6


\
\ @brief For interrupts ID
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER7_ISACTIVER7                  \ ISACTIVER7


\
\ @brief For interrupts ID
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ISACTIVER8_ISACTIVER8                  \ ISACTIVER8


\
\ @brief For interrupts ID
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER0_ICACTIVER0                  \ ICACTIVER0


\
\ @brief For interrupts ID
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER1_ICACTIVER1                  \ ICACTIVER1


\
\ @brief For interrupts ID
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER2_ICACTIVER2                  \ ICACTIVER2


\
\ @brief For interrupts ID
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER3_ICACTIVER3                  \ ICACTIVER3


\
\ @brief For interrupts ID
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER4_ICACTIVER4                  \ ICACTIVER4


\
\ @brief For interrupts ID
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER5_ICACTIVER5                  \ ICACTIVER5


\
\ @brief For interrupts ID
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER6_ICACTIVER6                  \ ICACTIVER6


\
\ @brief For interrupts ID
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER7_ICACTIVER7                  \ ICACTIVER7


\
\ @brief For interrupts ID
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_ICACTIVER8_ICACTIVER8                  \ ICACTIVER8


\
\ @brief GICD interrupt priority register 0
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR0_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR0_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR0_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR0_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 1
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR1_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR1_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR1_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR1_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 2
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR2_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR2_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR2_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR2_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 3
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR3_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR3_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR3_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR3_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 4
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR4_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR4_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR4_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR4_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 5
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR5_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR5_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR5_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR5_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 6
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR6_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR6_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR6_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR6_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 7
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR7_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR7_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR7_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR7_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 8
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR8_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR8_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR8_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR8_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 9
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR9_PRIORITY0                  \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR9_PRIORITY1                  \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR9_PRIORITY2                  \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR9_PRIORITY3                  \ PRIORITY3


\
\ @brief GICD interrupt priority register 10
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR10_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR10_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR10_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR10_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 11
\ Address offset: 0x42C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR11_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR11_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR11_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR11_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 12
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR12_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR12_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR12_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR12_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 13
\ Address offset: 0x434
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR13_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR13_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR13_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR13_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 14
\ Address offset: 0x438
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR14_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR14_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR14_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR14_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 15
\ Address offset: 0x43C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR15_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR15_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR15_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR15_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 16
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR16_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR16_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR16_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR16_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 17
\ Address offset: 0x444
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR17_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR17_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR17_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR17_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 18
\ Address offset: 0x448
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR18_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR18_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR18_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR18_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 19
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR19_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR19_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR19_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR19_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 20
\ Address offset: 0x450
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR20_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR20_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR20_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR20_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 21
\ Address offset: 0x454
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR21_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR21_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR21_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR21_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 22
\ Address offset: 0x458
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR22_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR22_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR22_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR22_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 23
\ Address offset: 0x45C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR23_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR23_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR23_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR23_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 24
\ Address offset: 0x460
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR24_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR24_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR24_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR24_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 25
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR25_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR25_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR25_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR25_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 26
\ Address offset: 0x468
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR26_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR26_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR26_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR26_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 27
\ Address offset: 0x46C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR27_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR27_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR27_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR27_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 28
\ Address offset: 0x470
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR28_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR28_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR28_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR28_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 29
\ Address offset: 0x474
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR29_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR29_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR29_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR29_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 30
\ Address offset: 0x478
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR30_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR30_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR30_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR30_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 31
\ Address offset: 0x47C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR31_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR31_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR31_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR31_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 32
\ Address offset: 0x480
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR32_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR32_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR32_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR32_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 33
\ Address offset: 0x484
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR33_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR33_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR33_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR33_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 34
\ Address offset: 0x488
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR34_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR34_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR34_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR34_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 35
\ Address offset: 0x48C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR35_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR35_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR35_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR35_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 36
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR36_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR36_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR36_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR36_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 37
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR37_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR37_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR37_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR37_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 38
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR38_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR38_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR38_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR38_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 39
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR39_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR39_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR39_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR39_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 40
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR40_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR40_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR40_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR40_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 41
\ Address offset: 0x4A4
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR41_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR41_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR41_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR41_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 42
\ Address offset: 0x4A8
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR42_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR42_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR42_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR42_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 43
\ Address offset: 0x4AC
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR43_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR43_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR43_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR43_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 44
\ Address offset: 0x4B0
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR44_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR44_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR44_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR44_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 45
\ Address offset: 0x4B4
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR45_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR45_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR45_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR45_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 46
\ Address offset: 0x4B8
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR46_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR46_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR46_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR46_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 47
\ Address offset: 0x4BC
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR47_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR47_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR47_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR47_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 48
\ Address offset: 0x4C0
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR48_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR48_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR48_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR48_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 49
\ Address offset: 0x4C4
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR49_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR49_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR49_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR49_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 50
\ Address offset: 0x4C8
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR50_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR50_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR50_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR50_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 51
\ Address offset: 0x4CC
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR51_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR51_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR51_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR51_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 52
\ Address offset: 0x4D0
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR52_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR52_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR52_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR52_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 53
\ Address offset: 0x4D4
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR53_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR53_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR53_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR53_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 54
\ Address offset: 0x4D8
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR54_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR54_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR54_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR54_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 55
\ Address offset: 0x4DC
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR55_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR55_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR55_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR55_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 56
\ Address offset: 0x4E0
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR56_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR56_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR56_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR56_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 57
\ Address offset: 0x4E4
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR57_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR57_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR57_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR57_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 58
\ Address offset: 0x4E8
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR58_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR58_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR58_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR58_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 59
\ Address offset: 0x4EC
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR59_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR59_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR59_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR59_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 60
\ Address offset: 0x4F0
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR60_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR60_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR60_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR60_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 61
\ Address offset: 0x4F4
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR61_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR61_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR61_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR61_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 62
\ Address offset: 0x4F8
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR62_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR62_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR62_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR62_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 63
\ Address offset: 0x4FC
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR63_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR63_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR63_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR63_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 64
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR64_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR64_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR64_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR64_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 65
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR65_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR65_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR65_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR65_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 66
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR66_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR66_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR66_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR66_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 67
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR67_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR67_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR67_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR67_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 68
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR68_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR68_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR68_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR68_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 69
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR69_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR69_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR69_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR69_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 70
\ Address offset: 0x518
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR70_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR70_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR70_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR70_PRIORITY3                 \ PRIORITY3


\
\ @brief GICD interrupt priority register 71
\ Address offset: 0x51C
\ Reset value: 0x00000000
\

$000000f8 constant GICD_GICD_IPRIORITYR71_PRIORITY0                 \ PRIORITY0
$0000f800 constant GICD_GICD_IPRIORITYR71_PRIORITY1                 \ PRIORITY1
$00f80000 constant GICD_GICD_IPRIORITYR71_PRIORITY2                 \ PRIORITY2
$f8000000 constant GICD_GICD_IPRIORITYR71_PRIORITY3                 \ PRIORITY3


\
\ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
\ Address offset: 0x800
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR0_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR0_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR0_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR0_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
\ Address offset: 0x804
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR1_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR1_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR1_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR1_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
\ Address offset: 0x808
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR2_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR2_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR2_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR2_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
\ Address offset: 0x80C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR3_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR3_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR3_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR3_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
\ Address offset: 0x810
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR4_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR4_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR4_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR4_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR5_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR5_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR5_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR5_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR6_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR6_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR6_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR6_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR7_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR7_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR7_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR7_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 8
\ Address offset: 0x820
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR8_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR8_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR8_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR8_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 9
\ Address offset: 0x824
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR9_CPU_TARGETS0                \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR9_CPU_TARGETS1                \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR9_CPU_TARGETS2                \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR9_CPU_TARGETS3                \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 10
\ Address offset: 0x828
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR10_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR10_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR10_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR10_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 11
\ Address offset: 0x82C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR11_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR11_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR11_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR11_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 12
\ Address offset: 0x830
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR12_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR12_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR12_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR12_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 13
\ Address offset: 0x834
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR13_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR13_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR13_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR13_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 14
\ Address offset: 0x838
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR14_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR14_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR14_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR14_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 15
\ Address offset: 0x83C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR15_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR15_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR15_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR15_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 16
\ Address offset: 0x840
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR16_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR16_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR16_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR16_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 17
\ Address offset: 0x844
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR17_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR17_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR17_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR17_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 18
\ Address offset: 0x848
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR18_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR18_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR18_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR18_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 19
\ Address offset: 0x84C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR19_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR19_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR19_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR19_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 20
\ Address offset: 0x850
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR20_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR20_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR20_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR20_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 21
\ Address offset: 0x854
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR21_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR21_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR21_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR21_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 22
\ Address offset: 0x858
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR22_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR22_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR22_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR22_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 23
\ Address offset: 0x85C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR23_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR23_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR23_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR23_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 24
\ Address offset: 0x860
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR24_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR24_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR24_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR24_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 25
\ Address offset: 0x864
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR25_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR25_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR25_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR25_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 26
\ Address offset: 0x868
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR26_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR26_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR26_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR26_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 27
\ Address offset: 0x86C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR27_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR27_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR27_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR27_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 28
\ Address offset: 0x870
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR28_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR28_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR28_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR28_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 29
\ Address offset: 0x874
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR29_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR29_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR29_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR29_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 30
\ Address offset: 0x878
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR30_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR30_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR30_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR30_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 31
\ Address offset: 0x87C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR31_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR31_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR31_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR31_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 32
\ Address offset: 0x880
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR32_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR32_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR32_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR32_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 33
\ Address offset: 0x884
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR33_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR33_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR33_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR33_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 34
\ Address offset: 0x888
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR34_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR34_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR34_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR34_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 35
\ Address offset: 0x88C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR35_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR35_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR35_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR35_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 36
\ Address offset: 0x890
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR36_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR36_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR36_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR36_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 37
\ Address offset: 0x894
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR37_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR37_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR37_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR37_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 38
\ Address offset: 0x898
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR38_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR38_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR38_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR38_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 39
\ Address offset: 0x89C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR39_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR39_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR39_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR39_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 40
\ Address offset: 0x8A0
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR40_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR40_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR40_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR40_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 41
\ Address offset: 0x8A4
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR41_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR41_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR41_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR41_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 42
\ Address offset: 0x8A8
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR42_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR42_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR42_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR42_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 43
\ Address offset: 0x8AC
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR43_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR43_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR43_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR43_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 44
\ Address offset: 0x8B0
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR44_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR44_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR44_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR44_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 45
\ Address offset: 0x8B4
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR45_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR45_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR45_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR45_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 46
\ Address offset: 0x8B8
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR46_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR46_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR46_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR46_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 47
\ Address offset: 0x8BC
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR47_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR47_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR47_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR47_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 48
\ Address offset: 0x8C0
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR48_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR48_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR48_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR48_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 49
\ Address offset: 0x8C4
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR49_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR49_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR49_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR49_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 50
\ Address offset: 0x8C8
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR50_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR50_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR50_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR50_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 51
\ Address offset: 0x8CC
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR51_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR51_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR51_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR51_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 52
\ Address offset: 0x8D0
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR52_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR52_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR52_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR52_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 53
\ Address offset: 0x8D4
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR53_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR53_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR53_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR53_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 54
\ Address offset: 0x8D8
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR54_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR54_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR54_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR54_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 55
\ Address offset: 0x8DC
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR55_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR55_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR55_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR55_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 56
\ Address offset: 0x8E0
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR56_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR56_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR56_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR56_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 57
\ Address offset: 0x8E4
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR57_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR57_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR57_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR57_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 58
\ Address offset: 0x8E8
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR58_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR58_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR58_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR58_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 59
\ Address offset: 0x8EC
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR59_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR59_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR59_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR59_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 60
\ Address offset: 0x8F0
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR60_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR60_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR60_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR60_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 61
\ Address offset: 0x8F4
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR61_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR61_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR61_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR61_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 62
\ Address offset: 0x8F8
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR62_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR62_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR62_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR62_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 63
\ Address offset: 0x8FC
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR63_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR63_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR63_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR63_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 64
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR64_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR64_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR64_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR64_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 65
\ Address offset: 0x904
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR65_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR65_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR65_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR65_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 66
\ Address offset: 0x908
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR66_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR66_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR66_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR66_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 67
\ Address offset: 0x90C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR67_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR67_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR67_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR67_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 68
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR68_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR68_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR68_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR68_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 69
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR69_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR69_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR69_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR69_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 70
\ Address offset: 0x918
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR70_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR70_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR70_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR70_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt processor target register 71
\ Address offset: 0x91C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_ITARGETSR71_CPU_TARGETS0               \ CPU_TARGETS0
$00000300 constant GICD_GICD_ITARGETSR71_CPU_TARGETS1               \ CPU_TARGETS1
$00030000 constant GICD_GICD_ITARGETSR71_CPU_TARGETS2               \ CPU_TARGETS2
$03000000 constant GICD_GICD_ITARGETSR71_CPU_TARGETS3               \ CPU_TARGETS3


\
\ @brief GICD interrupt configuration register
\ Address offset: 0xC00
\ Reset value: 0xAAAAAAAA
\

$00000003 constant GICD_GICD_ICFGR0_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR0_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR0_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR0_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR0_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR0_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR0_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR0_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR0_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR0_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR0_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR0_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR0_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR0_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR0_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR0_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register
\ Address offset: 0xC04
\ Reset value: 0x55540000
\

$00000003 constant GICD_GICD_ICFGR1_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR1_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR1_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR1_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR1_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR1_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR1_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR1_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR1_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR1_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR1_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR1_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR1_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR1_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR1_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR1_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 2
\ Address offset: 0xC08
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR2_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR2_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR2_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR2_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR2_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR2_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR2_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR2_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR2_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR2_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR2_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR2_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR2_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR2_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR2_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR2_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 3
\ Address offset: 0xC0C
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR3_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR3_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR3_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR3_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR3_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR3_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR3_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR3_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR3_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR3_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR3_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR3_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR3_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR3_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR3_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR3_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 4
\ Address offset: 0xC10
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR4_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR4_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR4_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR4_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR4_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR4_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR4_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR4_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR4_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR4_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR4_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR4_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR4_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR4_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR4_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR4_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 5
\ Address offset: 0xC14
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR5_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR5_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR5_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR5_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR5_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR5_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR5_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR5_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR5_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR5_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR5_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR5_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR5_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR5_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR5_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR5_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 6
\ Address offset: 0xC18
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR6_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR6_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR6_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR6_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR6_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR6_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR6_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR6_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR6_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR6_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR6_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR6_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR6_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR6_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR6_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR6_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 7
\ Address offset: 0xC1C
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR7_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR7_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR7_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR7_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR7_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR7_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR7_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR7_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR7_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR7_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR7_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR7_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR7_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR7_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR7_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR7_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 8
\ Address offset: 0xC20
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR8_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR8_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR8_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR8_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR8_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR8_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR8_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR8_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR8_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR8_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR8_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR8_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR8_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR8_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR8_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR8_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 9
\ Address offset: 0xC24
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR9_INT_CONFIG0                     \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR9_INT_CONFIG1                     \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR9_INT_CONFIG2                     \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR9_INT_CONFIG3                     \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR9_INT_CONFIG4                     \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR9_INT_CONFIG5                     \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR9_INT_CONFIG6                     \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR9_INT_CONFIG7                     \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR9_INT_CONFIG8                     \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR9_INT_CONFIG9                     \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR9_INT_CONFIG10                    \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR9_INT_CONFIG11                    \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR9_INT_CONFIG12                    \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR9_INT_CONFIG13                    \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR9_INT_CONFIG14                    \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR9_INT_CONFIG15                    \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 10
\ Address offset: 0xC28
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR10_INT_CONFIG0                    \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR10_INT_CONFIG1                    \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR10_INT_CONFIG2                    \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR10_INT_CONFIG3                    \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR10_INT_CONFIG4                    \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR10_INT_CONFIG5                    \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR10_INT_CONFIG6                    \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR10_INT_CONFIG7                    \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR10_INT_CONFIG8                    \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR10_INT_CONFIG9                    \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR10_INT_CONFIG10                   \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR10_INT_CONFIG11                   \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR10_INT_CONFIG12                   \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR10_INT_CONFIG13                   \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR10_INT_CONFIG14                   \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR10_INT_CONFIG15                   \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 11
\ Address offset: 0xC2C
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR11_INT_CONFIG0                    \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR11_INT_CONFIG1                    \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR11_INT_CONFIG2                    \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR11_INT_CONFIG3                    \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR11_INT_CONFIG4                    \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR11_INT_CONFIG5                    \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR11_INT_CONFIG6                    \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR11_INT_CONFIG7                    \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR11_INT_CONFIG8                    \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR11_INT_CONFIG9                    \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR11_INT_CONFIG10                   \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR11_INT_CONFIG11                   \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR11_INT_CONFIG12                   \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR11_INT_CONFIG13                   \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR11_INT_CONFIG14                   \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR11_INT_CONFIG15                   \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 12
\ Address offset: 0xC30
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR12_INT_CONFIG0                    \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR12_INT_CONFIG1                    \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR12_INT_CONFIG2                    \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR12_INT_CONFIG3                    \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR12_INT_CONFIG4                    \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR12_INT_CONFIG5                    \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR12_INT_CONFIG6                    \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR12_INT_CONFIG7                    \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR12_INT_CONFIG8                    \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR12_INT_CONFIG9                    \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR12_INT_CONFIG10                   \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR12_INT_CONFIG11                   \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR12_INT_CONFIG12                   \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR12_INT_CONFIG13                   \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR12_INT_CONFIG14                   \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR12_INT_CONFIG15                   \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 13
\ Address offset: 0xC34
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR13_INT_CONFIG0                    \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR13_INT_CONFIG1                    \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR13_INT_CONFIG2                    \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR13_INT_CONFIG3                    \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR13_INT_CONFIG4                    \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR13_INT_CONFIG5                    \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR13_INT_CONFIG6                    \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR13_INT_CONFIG7                    \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR13_INT_CONFIG8                    \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR13_INT_CONFIG9                    \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR13_INT_CONFIG10                   \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR13_INT_CONFIG11                   \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR13_INT_CONFIG12                   \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR13_INT_CONFIG13                   \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR13_INT_CONFIG14                   \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR13_INT_CONFIG15                   \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 14
\ Address offset: 0xC38
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR14_INT_CONFIG0                    \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR14_INT_CONFIG1                    \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR14_INT_CONFIG2                    \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR14_INT_CONFIG3                    \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR14_INT_CONFIG4                    \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR14_INT_CONFIG5                    \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR14_INT_CONFIG6                    \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR14_INT_CONFIG7                    \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR14_INT_CONFIG8                    \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR14_INT_CONFIG9                    \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR14_INT_CONFIG10                   \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR14_INT_CONFIG11                   \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR14_INT_CONFIG12                   \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR14_INT_CONFIG13                   \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR14_INT_CONFIG14                   \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR14_INT_CONFIG15                   \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 15
\ Address offset: 0xC3C
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR15_INT_CONFIG0                    \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR15_INT_CONFIG1                    \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR15_INT_CONFIG2                    \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR15_INT_CONFIG3                    \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR15_INT_CONFIG4                    \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR15_INT_CONFIG5                    \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR15_INT_CONFIG6                    \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR15_INT_CONFIG7                    \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR15_INT_CONFIG8                    \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR15_INT_CONFIG9                    \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR15_INT_CONFIG10                   \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR15_INT_CONFIG11                   \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR15_INT_CONFIG12                   \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR15_INT_CONFIG13                   \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR15_INT_CONFIG14                   \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR15_INT_CONFIG15                   \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 16
\ Address offset: 0xC40
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR16_INT_CONFIG0                    \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR16_INT_CONFIG1                    \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR16_INT_CONFIG2                    \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR16_INT_CONFIG3                    \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR16_INT_CONFIG4                    \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR16_INT_CONFIG5                    \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR16_INT_CONFIG6                    \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR16_INT_CONFIG7                    \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR16_INT_CONFIG8                    \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR16_INT_CONFIG9                    \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR16_INT_CONFIG10                   \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR16_INT_CONFIG11                   \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR16_INT_CONFIG12                   \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR16_INT_CONFIG13                   \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR16_INT_CONFIG14                   \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR16_INT_CONFIG15                   \ INT_CONFIG15


\
\ @brief GICD interrupt configuration register 17
\ Address offset: 0xC44
\ Reset value: 0x55555555
\

$00000003 constant GICD_GICD_ICFGR17_INT_CONFIG0                    \ INT_CONFIG0
$0000000c constant GICD_GICD_ICFGR17_INT_CONFIG1                    \ INT_CONFIG1
$00000030 constant GICD_GICD_ICFGR17_INT_CONFIG2                    \ INT_CONFIG2
$000000c0 constant GICD_GICD_ICFGR17_INT_CONFIG3                    \ INT_CONFIG3
$00000300 constant GICD_GICD_ICFGR17_INT_CONFIG4                    \ INT_CONFIG4
$00000c00 constant GICD_GICD_ICFGR17_INT_CONFIG5                    \ INT_CONFIG5
$00003000 constant GICD_GICD_ICFGR17_INT_CONFIG6                    \ INT_CONFIG6
$0000c000 constant GICD_GICD_ICFGR17_INT_CONFIG7                    \ INT_CONFIG7
$00030000 constant GICD_GICD_ICFGR17_INT_CONFIG8                    \ INT_CONFIG8
$000c0000 constant GICD_GICD_ICFGR17_INT_CONFIG9                    \ INT_CONFIG9
$00300000 constant GICD_GICD_ICFGR17_INT_CONFIG10                   \ INT_CONFIG10
$00c00000 constant GICD_GICD_ICFGR17_INT_CONFIG11                   \ INT_CONFIG11
$03000000 constant GICD_GICD_ICFGR17_INT_CONFIG12                   \ INT_CONFIG12
$0c000000 constant GICD_GICD_ICFGR17_INT_CONFIG13                   \ INT_CONFIG13
$30000000 constant GICD_GICD_ICFGR17_INT_CONFIG14                   \ INT_CONFIG14
$c0000000 constant GICD_GICD_ICFGR17_INT_CONFIG15                   \ INT_CONFIG15


\
\ @brief GICD private peripheral interrupt status register
\ Address offset: 0xD00
\ Reset value: 0x00000000
\

$00000200 constant GICD_GICD_PPISR_PPI6                             \ PPI6
$00000400 constant GICD_GICD_PPISR_PPI5                             \ PPI5
$00000800 constant GICD_GICD_PPISR_PPI4                             \ PPI4
$00001000 constant GICD_GICD_PPISR_PPI0                             \ PPI0
$00002000 constant GICD_GICD_PPISR_PPI1                             \ PPI1
$00004000 constant GICD_GICD_PPISR_PPI2                             \ PPI2
$00008000 constant GICD_GICD_PPISR_PPI3                             \ PPI3


\
\ @brief For interrupts ID = SPI number+32, from SPI [x*32+31] to SPI [x*32]
\ Address offset: 0xD08
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR1_SPISR1                          \ SPISR1


\
\ @brief For interrupts ID
\ Address offset: 0xD0C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR2_SPISR2                          \ SPISR2


\
\ @brief For interrupts ID
\ Address offset: 0xD10
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR3_SPISR3                          \ SPISR3


\
\ @brief For interrupts ID
\ Address offset: 0xD14
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR4_SPISR4                          \ SPISR4


\
\ @brief For interrupts ID
\ Address offset: 0xD18
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR5_SPISR5                          \ SPISR5


\
\ @brief For interrupts ID
\ Address offset: 0xD1C
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR6_SPISR6                          \ SPISR6


\
\ @brief For interrupts ID
\ Address offset: 0xD20
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_SPISR7_SPISR7                          \ SPISR7


\
\ @brief GICD software generated interrupt register
\ Address offset: 0xF00
\ Reset value: 0x00000000
\

$0000000f constant GICD_GICD_SGIR_SGIINTID                          \ SGIINTID
$00008000 constant GICD_GICD_SGIR_NSATT                             \ NSATT
$00030000 constant GICD_GICD_SGIR_CPUTARGETLIST                     \ CPUTARGETLIST
$03000000 constant GICD_GICD_SGIR_TARGETLISTFILTER                  \ TARGETLISTFILTER


\
\ @brief For SGI x*4 to SGI x*4+3
\ Address offset: 0xF10
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_CPENDSGIR0_SGI_CLEAR_PENDING0          \ SGI_CLEAR_PENDING0
$00000300 constant GICD_GICD_CPENDSGIR0_SGI_CLEAR_PENDING1          \ SGI_CLEAR_PENDING1
$00030000 constant GICD_GICD_CPENDSGIR0_SGI_CLEAR_PENDING2          \ SGI_CLEAR_PENDING2
$03000000 constant GICD_GICD_CPENDSGIR0_SGI_CLEAR_PENDING3          \ SGI_CLEAR_PENDING3


\
\ @brief For SGI x*4 to SGI x*4+3
\ Address offset: 0xF14
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_CPENDSGIR1_SGI_CLEAR_PENDING0          \ SGI_CLEAR_PENDING0
$00000300 constant GICD_GICD_CPENDSGIR1_SGI_CLEAR_PENDING1          \ SGI_CLEAR_PENDING1
$00030000 constant GICD_GICD_CPENDSGIR1_SGI_CLEAR_PENDING2          \ SGI_CLEAR_PENDING2
$03000000 constant GICD_GICD_CPENDSGIR1_SGI_CLEAR_PENDING3          \ SGI_CLEAR_PENDING3


\
\ @brief For SGI x*4 to SGI x*4+3
\ Address offset: 0xF18
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_CPENDSGIR2_SGI_CLEAR_PENDING0          \ SGI_CLEAR_PENDING0
$00000300 constant GICD_GICD_CPENDSGIR2_SGI_CLEAR_PENDING1          \ SGI_CLEAR_PENDING1
$00030000 constant GICD_GICD_CPENDSGIR2_SGI_CLEAR_PENDING2          \ SGI_CLEAR_PENDING2
$03000000 constant GICD_GICD_CPENDSGIR2_SGI_CLEAR_PENDING3          \ SGI_CLEAR_PENDING3


\
\ @brief For SGI x*4 to SGI x*4+3
\ Address offset: 0xF1C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_CPENDSGIR3_SGI_CLEAR_PENDING0          \ SGI_CLEAR_PENDING0
$00000300 constant GICD_GICD_CPENDSGIR3_SGI_CLEAR_PENDING1          \ SGI_CLEAR_PENDING1
$00030000 constant GICD_GICD_CPENDSGIR3_SGI_CLEAR_PENDING2          \ SGI_CLEAR_PENDING2
$03000000 constant GICD_GICD_CPENDSGIR3_SGI_CLEAR_PENDING3          \ SGI_CLEAR_PENDING3


\
\ @brief For SGI x*4 to SGI x*4+3
\ Address offset: 0xF20
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_SPENDSGIR0_SGI_SET_PENDING0            \ SGI_SET_PENDING0
$00000300 constant GICD_GICD_SPENDSGIR0_SGI_SET_PENDING1            \ SGI_SET_PENDING1
$00030000 constant GICD_GICD_SPENDSGIR0_SGI_SET_PENDING2            \ SGI_SET_PENDING2
$03000000 constant GICD_GICD_SPENDSGIR0_SGI_SET_PENDING3            \ SGI_SET_PENDING3


\
\ @brief For SGI x*4 to SGI x*4+3
\ Address offset: 0xF24
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_SPENDSGIR1_SGI_SET_PENDING0            \ SGI_SET_PENDING0
$00000300 constant GICD_GICD_SPENDSGIR1_SGI_SET_PENDING1            \ SGI_SET_PENDING1
$00030000 constant GICD_GICD_SPENDSGIR1_SGI_SET_PENDING2            \ SGI_SET_PENDING2
$03000000 constant GICD_GICD_SPENDSGIR1_SGI_SET_PENDING3            \ SGI_SET_PENDING3


\
\ @brief For SGI x*4 to SGI x*4+3
\ Address offset: 0xF28
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_SPENDSGIR2_SGI_SET_PENDING0            \ SGI_SET_PENDING0
$00000300 constant GICD_GICD_SPENDSGIR2_SGI_SET_PENDING1            \ SGI_SET_PENDING1
$00030000 constant GICD_GICD_SPENDSGIR2_SGI_SET_PENDING2            \ SGI_SET_PENDING2
$03000000 constant GICD_GICD_SPENDSGIR2_SGI_SET_PENDING3            \ SGI_SET_PENDING3


\
\ @brief For SGI x*4 to SGI x*4+3
\ Address offset: 0xF2C
\ Reset value: 0x00000000
\

$00000003 constant GICD_GICD_SPENDSGIR3_SGI_SET_PENDING0            \ SGI_SET_PENDING0
$00000300 constant GICD_GICD_SPENDSGIR3_SGI_SET_PENDING1            \ SGI_SET_PENDING1
$00030000 constant GICD_GICD_SPENDSGIR3_SGI_SET_PENDING2            \ SGI_SET_PENDING2
$03000000 constant GICD_GICD_SPENDSGIR3_SGI_SET_PENDING3            \ SGI_SET_PENDING3


\
\ @brief GICD peripheral ID4 register
\ Address offset: 0xFD0
\ Reset value: 0x00000004
\

$00000000 constant GICD_GICD_PIDR4_PIDR4                            \ PIDR4


\
\ @brief GICD peripheral ID5 to ID7 register 5
\ Address offset: 0xFD4
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_PIDR5_PIDR5                            \ PIDR5


\
\ @brief GICD peripheral ID5 to ID7 register 6
\ Address offset: 0xFD8
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_PIDR6_PIDR6                            \ PIDR6


\
\ @brief GICD peripheral ID5 to ID7 register 7
\ Address offset: 0xFDC
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_PIDR7_PIDR7                            \ PIDR7


\
\ @brief GICD peripheral ID0 register
\ Address offset: 0xFE0
\ Reset value: 0x00000090
\

$00000000 constant GICD_GICD_PIDR0_PIDR0                            \ PIDR0


\
\ @brief GICD peripheral ID1 register
\ Address offset: 0xFE4
\ Reset value: 0x000000B4
\

$00000000 constant GICD_GICD_PIDR1_PIDR1                            \ PIDR1


\
\ @brief GICD peripheral ID2 register
\ Address offset: 0xFE8
\ Reset value: 0x0000002B
\

$00000000 constant GICD_GICD_PIDR2_PIDR2                            \ PIDR2


\
\ @brief GICD peripheral ID3 register
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$00000000 constant GICD_GICD_PIDR3_PIDR3                            \ PIDR3


\
\ @brief GICD component ID0 register
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$00000000 constant GICD_GICD_CIDR0_CIDR0                            \ CIDR0


\
\ @brief GICD component ID1 register
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$00000000 constant GICD_GICD_CIDR1_CIDR1                            \ CIDR1


\
\ @brief GICD component ID2 register
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$00000000 constant GICD_GICD_CIDR2_CIDR2                            \ CIDR2


\
\ @brief GICD component ID3 register
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$00000000 constant GICD_GICD_CIDR3_CIDR3                            \ CIDR3


\
\ @brief GICD
\
$a0021000 constant GICD_GICD_CTLR  \ offset: 0x00 : GICD control register
$a0021004 constant GICD_GICD_TYPER  \ offset: 0x04 : GICD interrupt controller type register
$a0021008 constant GICD_GICD_IIDR  \ offset: 0x08 : GICD implementer identification register
$a0021080 constant GICD_GICD_IGROUPR0  \ offset: 0x80 : For interrupts ID
$a0021084 constant GICD_GICD_IGROUPR1  \ offset: 0x84 : For interrupts ID
$a0021088 constant GICD_GICD_IGROUPR2  \ offset: 0x88 : For interrupts ID
$a002108c constant GICD_GICD_IGROUPR3  \ offset: 0x8C : For interrupts ID = x*32 to ID = x*32+31
$a0021090 constant GICD_GICD_IGROUPR4  \ offset: 0x90 : For interrupts ID = x*32 to ID = x*32+31
$a0021094 constant GICD_GICD_IGROUPR5  \ offset: 0x94 : For interrupts ID
$a0021098 constant GICD_GICD_IGROUPR6  \ offset: 0x98 : For interrupts ID
$a002109c constant GICD_GICD_IGROUPR7  \ offset: 0x9C : For interrupts ID
$a00210a0 constant GICD_GICD_IGROUPR8  \ offset: 0xA0 : For interrupts ID
$a0021100 constant GICD_GICD_ISENABLER0  \ offset: 0x100 : For interrupts ID = 0 to ID = 31
$a0021104 constant GICD_GICD_ISENABLER1  \ offset: 0x104 : For interrupts ID
$a0021108 constant GICD_GICD_ISENABLER2  \ offset: 0x108 : For interrupts ID
$a002110c constant GICD_GICD_ISENABLER3  \ offset: 0x10C : For interrupts ID
$a0021110 constant GICD_GICD_ISENABLER4  \ offset: 0x110 : For interrupts ID
$a0021114 constant GICD_GICD_ISENABLER5  \ offset: 0x114 : For interrupts ID
$a0021118 constant GICD_GICD_ISENABLER6  \ offset: 0x118 : For interrupts ID
$a002111c constant GICD_GICD_ISENABLER7  \ offset: 0x11C : For interrupts ID
$a0021120 constant GICD_GICD_ISENABLER8  \ offset: 0x120 : For interrupts ID
$a0021180 constant GICD_GICD_ICENABLER0  \ offset: 0x180 : For interrupts ID = 0 to ID = 31
$a0021184 constant GICD_GICD_ICENABLER1  \ offset: 0x184 : For interrupts ID
$a0021188 constant GICD_GICD_ICENABLER2  \ offset: 0x188 : For interrupts ID
$a002118c constant GICD_GICD_ICENABLER3  \ offset: 0x18C : For interrupts ID
$a0021190 constant GICD_GICD_ICENABLER4  \ offset: 0x190 : For interrupts ID
$a0021194 constant GICD_GICD_ICENABLER5  \ offset: 0x194 : For interrupts ID
$a0021198 constant GICD_GICD_ICENABLER6  \ offset: 0x198 : For interrupts ID
$a002119c constant GICD_GICD_ICENABLER7  \ offset: 0x19C : For interrupts ID
$a00211a0 constant GICD_GICD_ICENABLER8  \ offset: 0x1A0 : For interrupts ID
$a0021200 constant GICD_GICD_ISPENDR0  \ offset: 0x200 : For interrupts ID
$a0021204 constant GICD_GICD_ISPENDR1  \ offset: 0x204 : For interrupts ID
$a0021208 constant GICD_GICD_ISPENDR2  \ offset: 0x208 : For interrupts ID
$a002120c constant GICD_GICD_ISPENDR3  \ offset: 0x20C : For interrupts ID
$a0021210 constant GICD_GICD_ISPENDR4  \ offset: 0x210 : For interrupts ID
$a0021214 constant GICD_GICD_ISPENDR5  \ offset: 0x214 : For interrupts ID
$a0021218 constant GICD_GICD_ISPENDR6  \ offset: 0x218 : For interrupts ID
$a002121c constant GICD_GICD_ISPENDR7  \ offset: 0x21C : For interrupts ID
$a0021220 constant GICD_GICD_ISPENDR8  \ offset: 0x220 : For interrupts ID
$a0021280 constant GICD_GICD_ICPENDR0  \ offset: 0x280 : For interrupts ID
$a0021284 constant GICD_GICD_ICPENDR1  \ offset: 0x284 : For interrupts ID
$a0021288 constant GICD_GICD_ICPENDR2  \ offset: 0x288 : For interrupts ID
$a002128c constant GICD_GICD_ICPENDR3  \ offset: 0x28C : For interrupts ID
$a0021290 constant GICD_GICD_ICPENDR4  \ offset: 0x290 : For interrupts ID
$a0021294 constant GICD_GICD_ICPENDR5  \ offset: 0x294 : For interrupts ID
$a0021298 constant GICD_GICD_ICPENDR6  \ offset: 0x298 : For interrupts ID
$a002129c constant GICD_GICD_ICPENDR7  \ offset: 0x29C : For interrupts ID
$a00212a0 constant GICD_GICD_ICPENDR8  \ offset: 0x2A0 : For interrupts ID
$a0021300 constant GICD_GICD_ISACTIVER0  \ offset: 0x300 : For interrupts ID
$a0021304 constant GICD_GICD_ISACTIVER1  \ offset: 0x304 : For interrupts ID
$a0021308 constant GICD_GICD_ISACTIVER2  \ offset: 0x308 : For interrupts ID
$a002130c constant GICD_GICD_ISACTIVER3  \ offset: 0x30C : For interrupts ID
$a0021310 constant GICD_GICD_ISACTIVER4  \ offset: 0x310 : For interrupts ID
$a0021314 constant GICD_GICD_ISACTIVER5  \ offset: 0x314 : For interrupts ID
$a0021318 constant GICD_GICD_ISACTIVER6  \ offset: 0x318 : For interrupts ID
$a002131c constant GICD_GICD_ISACTIVER7  \ offset: 0x31C : For interrupts ID
$a0021320 constant GICD_GICD_ISACTIVER8  \ offset: 0x320 : For interrupts ID
$a0021380 constant GICD_GICD_ICACTIVER0  \ offset: 0x380 : For interrupts ID
$a0021384 constant GICD_GICD_ICACTIVER1  \ offset: 0x384 : For interrupts ID
$a0021388 constant GICD_GICD_ICACTIVER2  \ offset: 0x388 : For interrupts ID
$a002138c constant GICD_GICD_ICACTIVER3  \ offset: 0x38C : For interrupts ID
$a0021390 constant GICD_GICD_ICACTIVER4  \ offset: 0x390 : For interrupts ID
$a0021394 constant GICD_GICD_ICACTIVER5  \ offset: 0x394 : For interrupts ID
$a0021398 constant GICD_GICD_ICACTIVER6  \ offset: 0x398 : For interrupts ID
$a002139c constant GICD_GICD_ICACTIVER7  \ offset: 0x39C : For interrupts ID
$a00213a0 constant GICD_GICD_ICACTIVER8  \ offset: 0x3A0 : For interrupts ID
$a0021400 constant GICD_GICD_IPRIORITYR0  \ offset: 0x400 : GICD interrupt priority register 0
$a0021404 constant GICD_GICD_IPRIORITYR1  \ offset: 0x404 : GICD interrupt priority register 1
$a0021408 constant GICD_GICD_IPRIORITYR2  \ offset: 0x408 : GICD interrupt priority register 2
$a002140c constant GICD_GICD_IPRIORITYR3  \ offset: 0x40C : GICD interrupt priority register 3
$a0021410 constant GICD_GICD_IPRIORITYR4  \ offset: 0x410 : GICD interrupt priority register 4
$a0021414 constant GICD_GICD_IPRIORITYR5  \ offset: 0x414 : GICD interrupt priority register 5
$a0021418 constant GICD_GICD_IPRIORITYR6  \ offset: 0x418 : GICD interrupt priority register 6
$a002141c constant GICD_GICD_IPRIORITYR7  \ offset: 0x41C : GICD interrupt priority register 7
$a0021420 constant GICD_GICD_IPRIORITYR8  \ offset: 0x420 : GICD interrupt priority register 8
$a0021424 constant GICD_GICD_IPRIORITYR9  \ offset: 0x424 : GICD interrupt priority register 9
$a0021428 constant GICD_GICD_IPRIORITYR10  \ offset: 0x428 : GICD interrupt priority register 10
$a002142c constant GICD_GICD_IPRIORITYR11  \ offset: 0x42C : GICD interrupt priority register 11
$a0021430 constant GICD_GICD_IPRIORITYR12  \ offset: 0x430 : GICD interrupt priority register 12
$a0021434 constant GICD_GICD_IPRIORITYR13  \ offset: 0x434 : GICD interrupt priority register 13
$a0021438 constant GICD_GICD_IPRIORITYR14  \ offset: 0x438 : GICD interrupt priority register 14
$a002143c constant GICD_GICD_IPRIORITYR15  \ offset: 0x43C : GICD interrupt priority register 15
$a0021440 constant GICD_GICD_IPRIORITYR16  \ offset: 0x440 : GICD interrupt priority register 16
$a0021444 constant GICD_GICD_IPRIORITYR17  \ offset: 0x444 : GICD interrupt priority register 17
$a0021448 constant GICD_GICD_IPRIORITYR18  \ offset: 0x448 : GICD interrupt priority register 18
$a002144c constant GICD_GICD_IPRIORITYR19  \ offset: 0x44C : GICD interrupt priority register 19
$a0021450 constant GICD_GICD_IPRIORITYR20  \ offset: 0x450 : GICD interrupt priority register 20
$a0021454 constant GICD_GICD_IPRIORITYR21  \ offset: 0x454 : GICD interrupt priority register 21
$a0021458 constant GICD_GICD_IPRIORITYR22  \ offset: 0x458 : GICD interrupt priority register 22
$a002145c constant GICD_GICD_IPRIORITYR23  \ offset: 0x45C : GICD interrupt priority register 23
$a0021460 constant GICD_GICD_IPRIORITYR24  \ offset: 0x460 : GICD interrupt priority register 24
$a0021464 constant GICD_GICD_IPRIORITYR25  \ offset: 0x464 : GICD interrupt priority register 25
$a0021468 constant GICD_GICD_IPRIORITYR26  \ offset: 0x468 : GICD interrupt priority register 26
$a002146c constant GICD_GICD_IPRIORITYR27  \ offset: 0x46C : GICD interrupt priority register 27
$a0021470 constant GICD_GICD_IPRIORITYR28  \ offset: 0x470 : GICD interrupt priority register 28
$a0021474 constant GICD_GICD_IPRIORITYR29  \ offset: 0x474 : GICD interrupt priority register 29
$a0021478 constant GICD_GICD_IPRIORITYR30  \ offset: 0x478 : GICD interrupt priority register 30
$a002147c constant GICD_GICD_IPRIORITYR31  \ offset: 0x47C : GICD interrupt priority register 31
$a0021480 constant GICD_GICD_IPRIORITYR32  \ offset: 0x480 : GICD interrupt priority register 32
$a0021484 constant GICD_GICD_IPRIORITYR33  \ offset: 0x484 : GICD interrupt priority register 33
$a0021488 constant GICD_GICD_IPRIORITYR34  \ offset: 0x488 : GICD interrupt priority register 34
$a002148c constant GICD_GICD_IPRIORITYR35  \ offset: 0x48C : GICD interrupt priority register 35
$a0021490 constant GICD_GICD_IPRIORITYR36  \ offset: 0x490 : GICD interrupt priority register 36
$a0021494 constant GICD_GICD_IPRIORITYR37  \ offset: 0x494 : GICD interrupt priority register 37
$a0021498 constant GICD_GICD_IPRIORITYR38  \ offset: 0x498 : GICD interrupt priority register 38
$a002149c constant GICD_GICD_IPRIORITYR39  \ offset: 0x49C : GICD interrupt priority register 39
$a00214a0 constant GICD_GICD_IPRIORITYR40  \ offset: 0x4A0 : GICD interrupt priority register 40
$a00214a4 constant GICD_GICD_IPRIORITYR41  \ offset: 0x4A4 : GICD interrupt priority register 41
$a00214a8 constant GICD_GICD_IPRIORITYR42  \ offset: 0x4A8 : GICD interrupt priority register 42
$a00214ac constant GICD_GICD_IPRIORITYR43  \ offset: 0x4AC : GICD interrupt priority register 43
$a00214b0 constant GICD_GICD_IPRIORITYR44  \ offset: 0x4B0 : GICD interrupt priority register 44
$a00214b4 constant GICD_GICD_IPRIORITYR45  \ offset: 0x4B4 : GICD interrupt priority register 45
$a00214b8 constant GICD_GICD_IPRIORITYR46  \ offset: 0x4B8 : GICD interrupt priority register 46
$a00214bc constant GICD_GICD_IPRIORITYR47  \ offset: 0x4BC : GICD interrupt priority register 47
$a00214c0 constant GICD_GICD_IPRIORITYR48  \ offset: 0x4C0 : GICD interrupt priority register 48
$a00214c4 constant GICD_GICD_IPRIORITYR49  \ offset: 0x4C4 : GICD interrupt priority register 49
$a00214c8 constant GICD_GICD_IPRIORITYR50  \ offset: 0x4C8 : GICD interrupt priority register 50
$a00214cc constant GICD_GICD_IPRIORITYR51  \ offset: 0x4CC : GICD interrupt priority register 51
$a00214d0 constant GICD_GICD_IPRIORITYR52  \ offset: 0x4D0 : GICD interrupt priority register 52
$a00214d4 constant GICD_GICD_IPRIORITYR53  \ offset: 0x4D4 : GICD interrupt priority register 53
$a00214d8 constant GICD_GICD_IPRIORITYR54  \ offset: 0x4D8 : GICD interrupt priority register 54
$a00214dc constant GICD_GICD_IPRIORITYR55  \ offset: 0x4DC : GICD interrupt priority register 55
$a00214e0 constant GICD_GICD_IPRIORITYR56  \ offset: 0x4E0 : GICD interrupt priority register 56
$a00214e4 constant GICD_GICD_IPRIORITYR57  \ offset: 0x4E4 : GICD interrupt priority register 57
$a00214e8 constant GICD_GICD_IPRIORITYR58  \ offset: 0x4E8 : GICD interrupt priority register 58
$a00214ec constant GICD_GICD_IPRIORITYR59  \ offset: 0x4EC : GICD interrupt priority register 59
$a00214f0 constant GICD_GICD_IPRIORITYR60  \ offset: 0x4F0 : GICD interrupt priority register 60
$a00214f4 constant GICD_GICD_IPRIORITYR61  \ offset: 0x4F4 : GICD interrupt priority register 61
$a00214f8 constant GICD_GICD_IPRIORITYR62  \ offset: 0x4F8 : GICD interrupt priority register 62
$a00214fc constant GICD_GICD_IPRIORITYR63  \ offset: 0x4FC : GICD interrupt priority register 63
$a0021500 constant GICD_GICD_IPRIORITYR64  \ offset: 0x500 : GICD interrupt priority register 64
$a0021504 constant GICD_GICD_IPRIORITYR65  \ offset: 0x504 : GICD interrupt priority register 65
$a0021508 constant GICD_GICD_IPRIORITYR66  \ offset: 0x508 : GICD interrupt priority register 66
$a002150c constant GICD_GICD_IPRIORITYR67  \ offset: 0x50C : GICD interrupt priority register 67
$a0021510 constant GICD_GICD_IPRIORITYR68  \ offset: 0x510 : GICD interrupt priority register 68
$a0021514 constant GICD_GICD_IPRIORITYR69  \ offset: 0x514 : GICD interrupt priority register 69
$a0021518 constant GICD_GICD_IPRIORITYR70  \ offset: 0x518 : GICD interrupt priority register 70
$a002151c constant GICD_GICD_IPRIORITYR71  \ offset: 0x51C : GICD interrupt priority register 71
$a0021800 constant GICD_GICD_ITARGETSR0  \ offset: 0x800 : For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
$a0021804 constant GICD_GICD_ITARGETSR1  \ offset: 0x804 : For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
$a0021808 constant GICD_GICD_ITARGETSR2  \ offset: 0x808 : For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
$a002180c constant GICD_GICD_ITARGETSR3  \ offset: 0x80C : For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
$a0021810 constant GICD_GICD_ITARGETSR4  \ offset: 0x810 : For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
$a0021814 constant GICD_GICD_ITARGETSR5  \ offset: 0x814 : For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
$a0021818 constant GICD_GICD_ITARGETSR6  \ offset: 0x818 : For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
$a002181c constant GICD_GICD_ITARGETSR7  \ offset: 0x81C : For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
$a0021820 constant GICD_GICD_ITARGETSR8  \ offset: 0x820 : GICD interrupt processor target register 8
$a0021824 constant GICD_GICD_ITARGETSR9  \ offset: 0x824 : GICD interrupt processor target register 9
$a0021828 constant GICD_GICD_ITARGETSR10  \ offset: 0x828 : GICD interrupt processor target register 10
$a002182c constant GICD_GICD_ITARGETSR11  \ offset: 0x82C : GICD interrupt processor target register 11
$a0021830 constant GICD_GICD_ITARGETSR12  \ offset: 0x830 : GICD interrupt processor target register 12
$a0021834 constant GICD_GICD_ITARGETSR13  \ offset: 0x834 : GICD interrupt processor target register 13
$a0021838 constant GICD_GICD_ITARGETSR14  \ offset: 0x838 : GICD interrupt processor target register 14
$a002183c constant GICD_GICD_ITARGETSR15  \ offset: 0x83C : GICD interrupt processor target register 15
$a0021840 constant GICD_GICD_ITARGETSR16  \ offset: 0x840 : GICD interrupt processor target register 16
$a0021844 constant GICD_GICD_ITARGETSR17  \ offset: 0x844 : GICD interrupt processor target register 17
$a0021848 constant GICD_GICD_ITARGETSR18  \ offset: 0x848 : GICD interrupt processor target register 18
$a002184c constant GICD_GICD_ITARGETSR19  \ offset: 0x84C : GICD interrupt processor target register 19
$a0021850 constant GICD_GICD_ITARGETSR20  \ offset: 0x850 : GICD interrupt processor target register 20
$a0021854 constant GICD_GICD_ITARGETSR21  \ offset: 0x854 : GICD interrupt processor target register 21
$a0021858 constant GICD_GICD_ITARGETSR22  \ offset: 0x858 : GICD interrupt processor target register 22
$a002185c constant GICD_GICD_ITARGETSR23  \ offset: 0x85C : GICD interrupt processor target register 23
$a0021860 constant GICD_GICD_ITARGETSR24  \ offset: 0x860 : GICD interrupt processor target register 24
$a0021864 constant GICD_GICD_ITARGETSR25  \ offset: 0x864 : GICD interrupt processor target register 25
$a0021868 constant GICD_GICD_ITARGETSR26  \ offset: 0x868 : GICD interrupt processor target register 26
$a002186c constant GICD_GICD_ITARGETSR27  \ offset: 0x86C : GICD interrupt processor target register 27
$a0021870 constant GICD_GICD_ITARGETSR28  \ offset: 0x870 : GICD interrupt processor target register 28
$a0021874 constant GICD_GICD_ITARGETSR29  \ offset: 0x874 : GICD interrupt processor target register 29
$a0021878 constant GICD_GICD_ITARGETSR30  \ offset: 0x878 : GICD interrupt processor target register 30
$a002187c constant GICD_GICD_ITARGETSR31  \ offset: 0x87C : GICD interrupt processor target register 31
$a0021880 constant GICD_GICD_ITARGETSR32  \ offset: 0x880 : GICD interrupt processor target register 32
$a0021884 constant GICD_GICD_ITARGETSR33  \ offset: 0x884 : GICD interrupt processor target register 33
$a0021888 constant GICD_GICD_ITARGETSR34  \ offset: 0x888 : GICD interrupt processor target register 34
$a002188c constant GICD_GICD_ITARGETSR35  \ offset: 0x88C : GICD interrupt processor target register 35
$a0021890 constant GICD_GICD_ITARGETSR36  \ offset: 0x890 : GICD interrupt processor target register 36
$a0021894 constant GICD_GICD_ITARGETSR37  \ offset: 0x894 : GICD interrupt processor target register 37
$a0021898 constant GICD_GICD_ITARGETSR38  \ offset: 0x898 : GICD interrupt processor target register 38
$a002189c constant GICD_GICD_ITARGETSR39  \ offset: 0x89C : GICD interrupt processor target register 39
$a00218a0 constant GICD_GICD_ITARGETSR40  \ offset: 0x8A0 : GICD interrupt processor target register 40
$a00218a4 constant GICD_GICD_ITARGETSR41  \ offset: 0x8A4 : GICD interrupt processor target register 41
$a00218a8 constant GICD_GICD_ITARGETSR42  \ offset: 0x8A8 : GICD interrupt processor target register 42
$a00218ac constant GICD_GICD_ITARGETSR43  \ offset: 0x8AC : GICD interrupt processor target register 43
$a00218b0 constant GICD_GICD_ITARGETSR44  \ offset: 0x8B0 : GICD interrupt processor target register 44
$a00218b4 constant GICD_GICD_ITARGETSR45  \ offset: 0x8B4 : GICD interrupt processor target register 45
$a00218b8 constant GICD_GICD_ITARGETSR46  \ offset: 0x8B8 : GICD interrupt processor target register 46
$a00218bc constant GICD_GICD_ITARGETSR47  \ offset: 0x8BC : GICD interrupt processor target register 47
$a00218c0 constant GICD_GICD_ITARGETSR48  \ offset: 0x8C0 : GICD interrupt processor target register 48
$a00218c4 constant GICD_GICD_ITARGETSR49  \ offset: 0x8C4 : GICD interrupt processor target register 49
$a00218c8 constant GICD_GICD_ITARGETSR50  \ offset: 0x8C8 : GICD interrupt processor target register 50
$a00218cc constant GICD_GICD_ITARGETSR51  \ offset: 0x8CC : GICD interrupt processor target register 51
$a00218d0 constant GICD_GICD_ITARGETSR52  \ offset: 0x8D0 : GICD interrupt processor target register 52
$a00218d4 constant GICD_GICD_ITARGETSR53  \ offset: 0x8D4 : GICD interrupt processor target register 53
$a00218d8 constant GICD_GICD_ITARGETSR54  \ offset: 0x8D8 : GICD interrupt processor target register 54
$a00218dc constant GICD_GICD_ITARGETSR55  \ offset: 0x8DC : GICD interrupt processor target register 55
$a00218e0 constant GICD_GICD_ITARGETSR56  \ offset: 0x8E0 : GICD interrupt processor target register 56
$a00218e4 constant GICD_GICD_ITARGETSR57  \ offset: 0x8E4 : GICD interrupt processor target register 57
$a00218e8 constant GICD_GICD_ITARGETSR58  \ offset: 0x8E8 : GICD interrupt processor target register 58
$a00218ec constant GICD_GICD_ITARGETSR59  \ offset: 0x8EC : GICD interrupt processor target register 59
$a00218f0 constant GICD_GICD_ITARGETSR60  \ offset: 0x8F0 : GICD interrupt processor target register 60
$a00218f4 constant GICD_GICD_ITARGETSR61  \ offset: 0x8F4 : GICD interrupt processor target register 61
$a00218f8 constant GICD_GICD_ITARGETSR62  \ offset: 0x8F8 : GICD interrupt processor target register 62
$a00218fc constant GICD_GICD_ITARGETSR63  \ offset: 0x8FC : GICD interrupt processor target register 63
$a0021900 constant GICD_GICD_ITARGETSR64  \ offset: 0x900 : GICD interrupt processor target register 64
$a0021904 constant GICD_GICD_ITARGETSR65  \ offset: 0x904 : GICD interrupt processor target register 65
$a0021908 constant GICD_GICD_ITARGETSR66  \ offset: 0x908 : GICD interrupt processor target register 66
$a002190c constant GICD_GICD_ITARGETSR67  \ offset: 0x90C : GICD interrupt processor target register 67
$a0021910 constant GICD_GICD_ITARGETSR68  \ offset: 0x910 : GICD interrupt processor target register 68
$a0021914 constant GICD_GICD_ITARGETSR69  \ offset: 0x914 : GICD interrupt processor target register 69
$a0021918 constant GICD_GICD_ITARGETSR70  \ offset: 0x918 : GICD interrupt processor target register 70
$a002191c constant GICD_GICD_ITARGETSR71  \ offset: 0x91C : GICD interrupt processor target register 71
$a0021c00 constant GICD_GICD_ICFGR0  \ offset: 0xC00 : GICD interrupt configuration register
$a0021c04 constant GICD_GICD_ICFGR1  \ offset: 0xC04 : GICD interrupt configuration register
$a0021c08 constant GICD_GICD_ICFGR2  \ offset: 0xC08 : GICD interrupt configuration register 2
$a0021c0c constant GICD_GICD_ICFGR3  \ offset: 0xC0C : GICD interrupt configuration register 3
$a0021c10 constant GICD_GICD_ICFGR4  \ offset: 0xC10 : GICD interrupt configuration register 4
$a0021c14 constant GICD_GICD_ICFGR5  \ offset: 0xC14 : GICD interrupt configuration register 5
$a0021c18 constant GICD_GICD_ICFGR6  \ offset: 0xC18 : GICD interrupt configuration register 6
$a0021c1c constant GICD_GICD_ICFGR7  \ offset: 0xC1C : GICD interrupt configuration register 7
$a0021c20 constant GICD_GICD_ICFGR8  \ offset: 0xC20 : GICD interrupt configuration register 8
$a0021c24 constant GICD_GICD_ICFGR9  \ offset: 0xC24 : GICD interrupt configuration register 9
$a0021c28 constant GICD_GICD_ICFGR10  \ offset: 0xC28 : GICD interrupt configuration register 10
$a0021c2c constant GICD_GICD_ICFGR11  \ offset: 0xC2C : GICD interrupt configuration register 11
$a0021c30 constant GICD_GICD_ICFGR12  \ offset: 0xC30 : GICD interrupt configuration register 12
$a0021c34 constant GICD_GICD_ICFGR13  \ offset: 0xC34 : GICD interrupt configuration register 13
$a0021c38 constant GICD_GICD_ICFGR14  \ offset: 0xC38 : GICD interrupt configuration register 14
$a0021c3c constant GICD_GICD_ICFGR15  \ offset: 0xC3C : GICD interrupt configuration register 15
$a0021c40 constant GICD_GICD_ICFGR16  \ offset: 0xC40 : GICD interrupt configuration register 16
$a0021c44 constant GICD_GICD_ICFGR17  \ offset: 0xC44 : GICD interrupt configuration register 17
$a0021d00 constant GICD_GICD_PPISR  \ offset: 0xD00 : GICD private peripheral interrupt status register
$a0021d08 constant GICD_GICD_SPISR1  \ offset: 0xD08 : For interrupts ID = SPI number+32, from SPI [x*32+31] to SPI [x*32]
$a0021d0c constant GICD_GICD_SPISR2  \ offset: 0xD0C : For interrupts ID
$a0021d10 constant GICD_GICD_SPISR3  \ offset: 0xD10 : For interrupts ID
$a0021d14 constant GICD_GICD_SPISR4  \ offset: 0xD14 : For interrupts ID
$a0021d18 constant GICD_GICD_SPISR5  \ offset: 0xD18 : For interrupts ID
$a0021d1c constant GICD_GICD_SPISR6  \ offset: 0xD1C : For interrupts ID
$a0021d20 constant GICD_GICD_SPISR7  \ offset: 0xD20 : For interrupts ID
$a0021f00 constant GICD_GICD_SGIR  \ offset: 0xF00 : GICD software generated interrupt register
$a0021f10 constant GICD_GICD_CPENDSGIR0  \ offset: 0xF10 : For SGI x*4 to SGI x*4+3
$a0021f14 constant GICD_GICD_CPENDSGIR1  \ offset: 0xF14 : For SGI x*4 to SGI x*4+3
$a0021f18 constant GICD_GICD_CPENDSGIR2  \ offset: 0xF18 : For SGI x*4 to SGI x*4+3
$a0021f1c constant GICD_GICD_CPENDSGIR3  \ offset: 0xF1C : For SGI x*4 to SGI x*4+3
$a0021f20 constant GICD_GICD_SPENDSGIR0  \ offset: 0xF20 : For SGI x*4 to SGI x*4+3
$a0021f24 constant GICD_GICD_SPENDSGIR1  \ offset: 0xF24 : For SGI x*4 to SGI x*4+3
$a0021f28 constant GICD_GICD_SPENDSGIR2  \ offset: 0xF28 : For SGI x*4 to SGI x*4+3
$a0021f2c constant GICD_GICD_SPENDSGIR3  \ offset: 0xF2C : For SGI x*4 to SGI x*4+3
$a0021fd0 constant GICD_GICD_PIDR4  \ offset: 0xFD0 : GICD peripheral ID4 register
$a0021fd4 constant GICD_GICD_PIDR5  \ offset: 0xFD4 : GICD peripheral ID5 to ID7 register 5
$a0021fd8 constant GICD_GICD_PIDR6  \ offset: 0xFD8 : GICD peripheral ID5 to ID7 register 6
$a0021fdc constant GICD_GICD_PIDR7  \ offset: 0xFDC : GICD peripheral ID5 to ID7 register 7
$a0021fe0 constant GICD_GICD_PIDR0  \ offset: 0xFE0 : GICD peripheral ID0 register
$a0021fe4 constant GICD_GICD_PIDR1  \ offset: 0xFE4 : GICD peripheral ID1 register
$a0021fe8 constant GICD_GICD_PIDR2  \ offset: 0xFE8 : GICD peripheral ID2 register
$a0021fec constant GICD_GICD_PIDR3  \ offset: 0xFEC : GICD peripheral ID3 register
$a0021ff0 constant GICD_GICD_CIDR0  \ offset: 0xFF0 : GICD component ID0 register
$a0021ff4 constant GICD_GICD_CIDR1  \ offset: 0xFF4 : GICD component ID1 register
$a0021ff8 constant GICD_GICD_CIDR2  \ offset: 0xFF8 : GICD component ID2 register
$a0021ffc constant GICD_GICD_CIDR3  \ offset: 0xFFC : GICD component ID3 register

