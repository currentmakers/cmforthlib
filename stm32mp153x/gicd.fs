\
\ @file gicd.fs
\ @brief GICD
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GICD_DEF

  [ifdef] GICD_GICD_CTLR_DEF
    \
    \ @brief GICD control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ENABLEGRP0                \ [0x00] ENABLEGRP0
    $01 constant GICD_ENABLEGRP1                \ [0x01] ENABLEGRP1
  [then]


  [ifdef] GICD_GICD_TYPER_DEF
    \
    \ @brief GICD interrupt controller type register
    \ Address offset: 0x04
    \ Reset value: 0x0000FC28
    \
    $00 constant GICD_ITLINESNUMBER             \ [0x00 : 5] ITLINESNUMBER
    $05 constant GICD_CPUNUMBER                 \ [0x05 : 3] CPUNUMBER
    $0a constant GICD_SECURITYEXTN              \ [0x0a] SECURITYEXTN
    $0b constant GICD_LSPI                      \ [0x0b : 5] LSPI
  [then]


  [ifdef] GICD_GICD_IIDR_DEF
    \
    \ @brief GICD implementer identification register
    \ Address offset: 0x08
    \ Reset value: 0x0100143B
    \
    $00 constant GICD_IMPLEMENTER               \ [0x00 : 12] IMPLEMENTER
    $0c constant GICD_VARIANT                   \ [0x0c : 4] VARIANT
    $10 constant GICD_REVISION                  \ [0x10 : 4] REVISION
    $18 constant GICD_PRODUCTID                 \ [0x18 : 8] PRODUCTID
  [then]


  [ifdef] GICD_GICD_IGROUPR0_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPR0                  \ [0x00 : 32] IGROUPR0
  [then]


  [ifdef] GICD_GICD_IGROUPR1_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPR1                  \ [0x00 : 32] IGROUPR1
  [then]


  [ifdef] GICD_GICD_IGROUPR2_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPR2                  \ [0x00 : 32] IGROUPR2
  [then]


  [ifdef] GICD_GICD_IGROUPR3_DEF
    \
    \ @brief For interrupts ID = x*32 to ID = x*32+31
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPR3                  \ [0x00 : 32] IGROUPR3
  [then]


  [ifdef] GICD_GICD_IGROUPR4_DEF
    \
    \ @brief For interrupts ID = x*32 to ID = x*32+31
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPR4                  \ [0x00 : 32] IGROUPR4
  [then]


  [ifdef] GICD_GICD_IGROUPR5_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPR5                  \ [0x00 : 32] IGROUPR5
  [then]


  [ifdef] GICD_GICD_IGROUPR6_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPR6                  \ [0x00 : 32] IGROUPR6
  [then]


  [ifdef] GICD_GICD_IGROUPR7_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPR7                  \ [0x00 : 32] IGROUPR7
  [then]


  [ifdef] GICD_GICD_IGROUPR8_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_IGROUPR8                  \ [0x00 : 32] IGROUPR8
  [then]


  [ifdef] GICD_GICD_ISENABLER0_DEF
    \
    \ @brief For interrupts ID = 0 to ID = 31
    \ Address offset: 0x100
    \ Reset value: 0x0000FFFF
    \
    $00 constant GICD_ISENABLER0                \ [0x00 : 32] ISENABLER0
  [then]


  [ifdef] GICD_GICD_ISENABLER1_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLER1                \ [0x00 : 32] ISENABLER1
  [then]


  [ifdef] GICD_GICD_ISENABLER2_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLER2                \ [0x00 : 32] ISENABLER2
  [then]


  [ifdef] GICD_GICD_ISENABLER3_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLER3                \ [0x00 : 32] ISENABLER3
  [then]


  [ifdef] GICD_GICD_ISENABLER4_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLER4                \ [0x00 : 32] ISENABLER4
  [then]


  [ifdef] GICD_GICD_ISENABLER5_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLER5                \ [0x00 : 32] ISENABLER5
  [then]


  [ifdef] GICD_GICD_ISENABLER6_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLER6                \ [0x00 : 32] ISENABLER6
  [then]


  [ifdef] GICD_GICD_ISENABLER7_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLER7                \ [0x00 : 32] ISENABLER7
  [then]


  [ifdef] GICD_GICD_ISENABLER8_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISENABLER8                \ [0x00 : 32] ISENABLER8
  [then]


  [ifdef] GICD_GICD_ICENABLER0_DEF
    \
    \ @brief For interrupts ID = 0 to ID = 31
    \ Address offset: 0x180
    \ Reset value: 0x0000FFFF
    \
    $00 constant GICD_ICENABLER0                \ [0x00 : 32] ICENABLER0
  [then]


  [ifdef] GICD_GICD_ICENABLER1_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLER1                \ [0x00 : 32] ICENABLER1
  [then]


  [ifdef] GICD_GICD_ICENABLER2_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLER2                \ [0x00 : 32] ICENABLER2
  [then]


  [ifdef] GICD_GICD_ICENABLER3_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLER3                \ [0x00 : 32] ICENABLER3
  [then]


  [ifdef] GICD_GICD_ICENABLER4_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLER4                \ [0x00 : 32] ICENABLER4
  [then]


  [ifdef] GICD_GICD_ICENABLER5_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLER5                \ [0x00 : 32] ICENABLER5
  [then]


  [ifdef] GICD_GICD_ICENABLER6_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLER6                \ [0x00 : 32] ICENABLER6
  [then]


  [ifdef] GICD_GICD_ICENABLER7_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLER7                \ [0x00 : 32] ICENABLER7
  [then]


  [ifdef] GICD_GICD_ICENABLER8_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICENABLER8                \ [0x00 : 32] ICENABLER8
  [then]


  [ifdef] GICD_GICD_ISPENDR0_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDR0                  \ [0x00 : 32] ISPENDR0
  [then]


  [ifdef] GICD_GICD_ISPENDR1_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDR1                  \ [0x00 : 32] ISPENDR1
  [then]


  [ifdef] GICD_GICD_ISPENDR2_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDR2                  \ [0x00 : 32] ISPENDR2
  [then]


  [ifdef] GICD_GICD_ISPENDR3_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDR3                  \ [0x00 : 32] ISPENDR3
  [then]


  [ifdef] GICD_GICD_ISPENDR4_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDR4                  \ [0x00 : 32] ISPENDR4
  [then]


  [ifdef] GICD_GICD_ISPENDR5_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDR5                  \ [0x00 : 32] ISPENDR5
  [then]


  [ifdef] GICD_GICD_ISPENDR6_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDR6                  \ [0x00 : 32] ISPENDR6
  [then]


  [ifdef] GICD_GICD_ISPENDR7_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDR7                  \ [0x00 : 32] ISPENDR7
  [then]


  [ifdef] GICD_GICD_ISPENDR8_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISPENDR8                  \ [0x00 : 32] ISPENDR8
  [then]


  [ifdef] GICD_GICD_ICPENDR0_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDR0                  \ [0x00 : 32] ICPENDR0
  [then]


  [ifdef] GICD_GICD_ICPENDR1_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDR1                  \ [0x00 : 32] ICPENDR1
  [then]


  [ifdef] GICD_GICD_ICPENDR2_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDR2                  \ [0x00 : 32] ICPENDR2
  [then]


  [ifdef] GICD_GICD_ICPENDR3_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDR3                  \ [0x00 : 32] ICPENDR3
  [then]


  [ifdef] GICD_GICD_ICPENDR4_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDR4                  \ [0x00 : 32] ICPENDR4
  [then]


  [ifdef] GICD_GICD_ICPENDR5_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDR5                  \ [0x00 : 32] ICPENDR5
  [then]


  [ifdef] GICD_GICD_ICPENDR6_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDR6                  \ [0x00 : 32] ICPENDR6
  [then]


  [ifdef] GICD_GICD_ICPENDR7_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDR7                  \ [0x00 : 32] ICPENDR7
  [then]


  [ifdef] GICD_GICD_ICPENDR8_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICPENDR8                  \ [0x00 : 32] ICPENDR8
  [then]


  [ifdef] GICD_GICD_ISACTIVER0_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVER0                \ [0x00 : 32] ISACTIVER0
  [then]


  [ifdef] GICD_GICD_ISACTIVER1_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVER1                \ [0x00 : 32] ISACTIVER1
  [then]


  [ifdef] GICD_GICD_ISACTIVER2_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVER2                \ [0x00 : 32] ISACTIVER2
  [then]


  [ifdef] GICD_GICD_ISACTIVER3_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVER3                \ [0x00 : 32] ISACTIVER3
  [then]


  [ifdef] GICD_GICD_ISACTIVER4_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVER4                \ [0x00 : 32] ISACTIVER4
  [then]


  [ifdef] GICD_GICD_ISACTIVER5_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVER5                \ [0x00 : 32] ISACTIVER5
  [then]


  [ifdef] GICD_GICD_ISACTIVER6_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVER6                \ [0x00 : 32] ISACTIVER6
  [then]


  [ifdef] GICD_GICD_ISACTIVER7_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVER7                \ [0x00 : 32] ISACTIVER7
  [then]


  [ifdef] GICD_GICD_ISACTIVER8_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ISACTIVER8                \ [0x00 : 32] ISACTIVER8
  [then]


  [ifdef] GICD_GICD_ICACTIVER0_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVER0                \ [0x00 : 32] ICACTIVER0
  [then]


  [ifdef] GICD_GICD_ICACTIVER1_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVER1                \ [0x00 : 32] ICACTIVER1
  [then]


  [ifdef] GICD_GICD_ICACTIVER2_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVER2                \ [0x00 : 32] ICACTIVER2
  [then]


  [ifdef] GICD_GICD_ICACTIVER3_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVER3                \ [0x00 : 32] ICACTIVER3
  [then]


  [ifdef] GICD_GICD_ICACTIVER4_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVER4                \ [0x00 : 32] ICACTIVER4
  [then]


  [ifdef] GICD_GICD_ICACTIVER5_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVER5                \ [0x00 : 32] ICACTIVER5
  [then]


  [ifdef] GICD_GICD_ICACTIVER6_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVER6                \ [0x00 : 32] ICACTIVER6
  [then]


  [ifdef] GICD_GICD_ICACTIVER7_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVER7                \ [0x00 : 32] ICACTIVER7
  [then]


  [ifdef] GICD_GICD_ICACTIVER8_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_ICACTIVER8                \ [0x00 : 32] ICACTIVER8
  [then]


  [ifdef] GICD_GICD_IPRIORITYR0_DEF
    \
    \ @brief GICD interrupt priority register 0
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR1_DEF
    \
    \ @brief GICD interrupt priority register 1
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR2_DEF
    \
    \ @brief GICD interrupt priority register 2
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR3_DEF
    \
    \ @brief GICD interrupt priority register 3
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR4_DEF
    \
    \ @brief GICD interrupt priority register 4
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR5_DEF
    \
    \ @brief GICD interrupt priority register 5
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR6_DEF
    \
    \ @brief GICD interrupt priority register 6
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR7_DEF
    \
    \ @brief GICD interrupt priority register 7
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR8_DEF
    \
    \ @brief GICD interrupt priority register 8
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR9_DEF
    \
    \ @brief GICD interrupt priority register 9
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR10_DEF
    \
    \ @brief GICD interrupt priority register 10
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR11_DEF
    \
    \ @brief GICD interrupt priority register 11
    \ Address offset: 0x42C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR12_DEF
    \
    \ @brief GICD interrupt priority register 12
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR13_DEF
    \
    \ @brief GICD interrupt priority register 13
    \ Address offset: 0x434
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR14_DEF
    \
    \ @brief GICD interrupt priority register 14
    \ Address offset: 0x438
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR15_DEF
    \
    \ @brief GICD interrupt priority register 15
    \ Address offset: 0x43C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR16_DEF
    \
    \ @brief GICD interrupt priority register 16
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR17_DEF
    \
    \ @brief GICD interrupt priority register 17
    \ Address offset: 0x444
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR18_DEF
    \
    \ @brief GICD interrupt priority register 18
    \ Address offset: 0x448
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR19_DEF
    \
    \ @brief GICD interrupt priority register 19
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR20_DEF
    \
    \ @brief GICD interrupt priority register 20
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR21_DEF
    \
    \ @brief GICD interrupt priority register 21
    \ Address offset: 0x454
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR22_DEF
    \
    \ @brief GICD interrupt priority register 22
    \ Address offset: 0x458
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR23_DEF
    \
    \ @brief GICD interrupt priority register 23
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR24_DEF
    \
    \ @brief GICD interrupt priority register 24
    \ Address offset: 0x460
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR25_DEF
    \
    \ @brief GICD interrupt priority register 25
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR26_DEF
    \
    \ @brief GICD interrupt priority register 26
    \ Address offset: 0x468
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR27_DEF
    \
    \ @brief GICD interrupt priority register 27
    \ Address offset: 0x46C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR28_DEF
    \
    \ @brief GICD interrupt priority register 28
    \ Address offset: 0x470
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR29_DEF
    \
    \ @brief GICD interrupt priority register 29
    \ Address offset: 0x474
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR30_DEF
    \
    \ @brief GICD interrupt priority register 30
    \ Address offset: 0x478
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR31_DEF
    \
    \ @brief GICD interrupt priority register 31
    \ Address offset: 0x47C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR32_DEF
    \
    \ @brief GICD interrupt priority register 32
    \ Address offset: 0x480
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR33_DEF
    \
    \ @brief GICD interrupt priority register 33
    \ Address offset: 0x484
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR34_DEF
    \
    \ @brief GICD interrupt priority register 34
    \ Address offset: 0x488
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR35_DEF
    \
    \ @brief GICD interrupt priority register 35
    \ Address offset: 0x48C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR36_DEF
    \
    \ @brief GICD interrupt priority register 36
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR37_DEF
    \
    \ @brief GICD interrupt priority register 37
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR38_DEF
    \
    \ @brief GICD interrupt priority register 38
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR39_DEF
    \
    \ @brief GICD interrupt priority register 39
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR40_DEF
    \
    \ @brief GICD interrupt priority register 40
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR41_DEF
    \
    \ @brief GICD interrupt priority register 41
    \ Address offset: 0x4A4
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR42_DEF
    \
    \ @brief GICD interrupt priority register 42
    \ Address offset: 0x4A8
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR43_DEF
    \
    \ @brief GICD interrupt priority register 43
    \ Address offset: 0x4AC
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR44_DEF
    \
    \ @brief GICD interrupt priority register 44
    \ Address offset: 0x4B0
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR45_DEF
    \
    \ @brief GICD interrupt priority register 45
    \ Address offset: 0x4B4
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR46_DEF
    \
    \ @brief GICD interrupt priority register 46
    \ Address offset: 0x4B8
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR47_DEF
    \
    \ @brief GICD interrupt priority register 47
    \ Address offset: 0x4BC
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR48_DEF
    \
    \ @brief GICD interrupt priority register 48
    \ Address offset: 0x4C0
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR49_DEF
    \
    \ @brief GICD interrupt priority register 49
    \ Address offset: 0x4C4
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR50_DEF
    \
    \ @brief GICD interrupt priority register 50
    \ Address offset: 0x4C8
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR51_DEF
    \
    \ @brief GICD interrupt priority register 51
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR52_DEF
    \
    \ @brief GICD interrupt priority register 52
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR53_DEF
    \
    \ @brief GICD interrupt priority register 53
    \ Address offset: 0x4D4
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR54_DEF
    \
    \ @brief GICD interrupt priority register 54
    \ Address offset: 0x4D8
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR55_DEF
    \
    \ @brief GICD interrupt priority register 55
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR56_DEF
    \
    \ @brief GICD interrupt priority register 56
    \ Address offset: 0x4E0
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR57_DEF
    \
    \ @brief GICD interrupt priority register 57
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR58_DEF
    \
    \ @brief GICD interrupt priority register 58
    \ Address offset: 0x4E8
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR59_DEF
    \
    \ @brief GICD interrupt priority register 59
    \ Address offset: 0x4EC
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR60_DEF
    \
    \ @brief GICD interrupt priority register 60
    \ Address offset: 0x4F0
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR61_DEF
    \
    \ @brief GICD interrupt priority register 61
    \ Address offset: 0x4F4
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR62_DEF
    \
    \ @brief GICD interrupt priority register 62
    \ Address offset: 0x4F8
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR63_DEF
    \
    \ @brief GICD interrupt priority register 63
    \ Address offset: 0x4FC
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR64_DEF
    \
    \ @brief GICD interrupt priority register 64
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR65_DEF
    \
    \ @brief GICD interrupt priority register 65
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR66_DEF
    \
    \ @brief GICD interrupt priority register 66
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR67_DEF
    \
    \ @brief GICD interrupt priority register 67
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR68_DEF
    \
    \ @brief GICD interrupt priority register 68
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR69_DEF
    \
    \ @brief GICD interrupt priority register 69
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR70_DEF
    \
    \ @brief GICD interrupt priority register 70
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_IPRIORITYR71_DEF
    \
    \ @brief GICD interrupt priority register 71
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $03 constant GICD_PRIORITY0                 \ [0x03 : 5] PRIORITY0
    $0b constant GICD_PRIORITY1                 \ [0x0b : 5] PRIORITY1
    $13 constant GICD_PRIORITY2                 \ [0x13 : 5] PRIORITY2
    $1b constant GICD_PRIORITY3                 \ [0x1b : 5] PRIORITY3
  [then]


  [ifdef] GICD_GICD_ITARGETSR0_DEF
    \
    \ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
    \ Address offset: 0x800
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR1_DEF
    \
    \ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
    \ Address offset: 0x804
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR2_DEF
    \
    \ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
    \ Address offset: 0x808
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR3_DEF
    \
    \ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
    \ Address offset: 0x80C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR4_DEF
    \
    \ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR5_DEF
    \
    \ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR6_DEF
    \
    \ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR7_DEF
    \
    \ @brief For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR8_DEF
    \
    \ @brief GICD interrupt processor target register 8
    \ Address offset: 0x820
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR9_DEF
    \
    \ @brief GICD interrupt processor target register 9
    \ Address offset: 0x824
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR10_DEF
    \
    \ @brief GICD interrupt processor target register 10
    \ Address offset: 0x828
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR11_DEF
    \
    \ @brief GICD interrupt processor target register 11
    \ Address offset: 0x82C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR12_DEF
    \
    \ @brief GICD interrupt processor target register 12
    \ Address offset: 0x830
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR13_DEF
    \
    \ @brief GICD interrupt processor target register 13
    \ Address offset: 0x834
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR14_DEF
    \
    \ @brief GICD interrupt processor target register 14
    \ Address offset: 0x838
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR15_DEF
    \
    \ @brief GICD interrupt processor target register 15
    \ Address offset: 0x83C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR16_DEF
    \
    \ @brief GICD interrupt processor target register 16
    \ Address offset: 0x840
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR17_DEF
    \
    \ @brief GICD interrupt processor target register 17
    \ Address offset: 0x844
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR18_DEF
    \
    \ @brief GICD interrupt processor target register 18
    \ Address offset: 0x848
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR19_DEF
    \
    \ @brief GICD interrupt processor target register 19
    \ Address offset: 0x84C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR20_DEF
    \
    \ @brief GICD interrupt processor target register 20
    \ Address offset: 0x850
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR21_DEF
    \
    \ @brief GICD interrupt processor target register 21
    \ Address offset: 0x854
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR22_DEF
    \
    \ @brief GICD interrupt processor target register 22
    \ Address offset: 0x858
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR23_DEF
    \
    \ @brief GICD interrupt processor target register 23
    \ Address offset: 0x85C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR24_DEF
    \
    \ @brief GICD interrupt processor target register 24
    \ Address offset: 0x860
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR25_DEF
    \
    \ @brief GICD interrupt processor target register 25
    \ Address offset: 0x864
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR26_DEF
    \
    \ @brief GICD interrupt processor target register 26
    \ Address offset: 0x868
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR27_DEF
    \
    \ @brief GICD interrupt processor target register 27
    \ Address offset: 0x86C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR28_DEF
    \
    \ @brief GICD interrupt processor target register 28
    \ Address offset: 0x870
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR29_DEF
    \
    \ @brief GICD interrupt processor target register 29
    \ Address offset: 0x874
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR30_DEF
    \
    \ @brief GICD interrupt processor target register 30
    \ Address offset: 0x878
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR31_DEF
    \
    \ @brief GICD interrupt processor target register 31
    \ Address offset: 0x87C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR32_DEF
    \
    \ @brief GICD interrupt processor target register 32
    \ Address offset: 0x880
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR33_DEF
    \
    \ @brief GICD interrupt processor target register 33
    \ Address offset: 0x884
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR34_DEF
    \
    \ @brief GICD interrupt processor target register 34
    \ Address offset: 0x888
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR35_DEF
    \
    \ @brief GICD interrupt processor target register 35
    \ Address offset: 0x88C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR36_DEF
    \
    \ @brief GICD interrupt processor target register 36
    \ Address offset: 0x890
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR37_DEF
    \
    \ @brief GICD interrupt processor target register 37
    \ Address offset: 0x894
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR38_DEF
    \
    \ @brief GICD interrupt processor target register 38
    \ Address offset: 0x898
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR39_DEF
    \
    \ @brief GICD interrupt processor target register 39
    \ Address offset: 0x89C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR40_DEF
    \
    \ @brief GICD interrupt processor target register 40
    \ Address offset: 0x8A0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR41_DEF
    \
    \ @brief GICD interrupt processor target register 41
    \ Address offset: 0x8A4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR42_DEF
    \
    \ @brief GICD interrupt processor target register 42
    \ Address offset: 0x8A8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR43_DEF
    \
    \ @brief GICD interrupt processor target register 43
    \ Address offset: 0x8AC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR44_DEF
    \
    \ @brief GICD interrupt processor target register 44
    \ Address offset: 0x8B0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR45_DEF
    \
    \ @brief GICD interrupt processor target register 45
    \ Address offset: 0x8B4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR46_DEF
    \
    \ @brief GICD interrupt processor target register 46
    \ Address offset: 0x8B8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR47_DEF
    \
    \ @brief GICD interrupt processor target register 47
    \ Address offset: 0x8BC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR48_DEF
    \
    \ @brief GICD interrupt processor target register 48
    \ Address offset: 0x8C0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR49_DEF
    \
    \ @brief GICD interrupt processor target register 49
    \ Address offset: 0x8C4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR50_DEF
    \
    \ @brief GICD interrupt processor target register 50
    \ Address offset: 0x8C8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR51_DEF
    \
    \ @brief GICD interrupt processor target register 51
    \ Address offset: 0x8CC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR52_DEF
    \
    \ @brief GICD interrupt processor target register 52
    \ Address offset: 0x8D0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR53_DEF
    \
    \ @brief GICD interrupt processor target register 53
    \ Address offset: 0x8D4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR54_DEF
    \
    \ @brief GICD interrupt processor target register 54
    \ Address offset: 0x8D8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR55_DEF
    \
    \ @brief GICD interrupt processor target register 55
    \ Address offset: 0x8DC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR56_DEF
    \
    \ @brief GICD interrupt processor target register 56
    \ Address offset: 0x8E0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR57_DEF
    \
    \ @brief GICD interrupt processor target register 57
    \ Address offset: 0x8E4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR58_DEF
    \
    \ @brief GICD interrupt processor target register 58
    \ Address offset: 0x8E8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR59_DEF
    \
    \ @brief GICD interrupt processor target register 59
    \ Address offset: 0x8EC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR60_DEF
    \
    \ @brief GICD interrupt processor target register 60
    \ Address offset: 0x8F0
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR61_DEF
    \
    \ @brief GICD interrupt processor target register 61
    \ Address offset: 0x8F4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR62_DEF
    \
    \ @brief GICD interrupt processor target register 62
    \ Address offset: 0x8F8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR63_DEF
    \
    \ @brief GICD interrupt processor target register 63
    \ Address offset: 0x8FC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR64_DEF
    \
    \ @brief GICD interrupt processor target register 64
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR65_DEF
    \
    \ @brief GICD interrupt processor target register 65
    \ Address offset: 0x904
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR66_DEF
    \
    \ @brief GICD interrupt processor target register 66
    \ Address offset: 0x908
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR67_DEF
    \
    \ @brief GICD interrupt processor target register 67
    \ Address offset: 0x90C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR68_DEF
    \
    \ @brief GICD interrupt processor target register 68
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR69_DEF
    \
    \ @brief GICD interrupt processor target register 69
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR70_DEF
    \
    \ @brief GICD interrupt processor target register 70
    \ Address offset: 0x918
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ITARGETSR71_DEF
    \
    \ @brief GICD interrupt processor target register 71
    \ Address offset: 0x91C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_CPU_TARGETS0              \ [0x00 : 2] CPU_TARGETS0
    $08 constant GICD_CPU_TARGETS1              \ [0x08 : 2] CPU_TARGETS1
    $10 constant GICD_CPU_TARGETS2              \ [0x10 : 2] CPU_TARGETS2
    $18 constant GICD_CPU_TARGETS3              \ [0x18 : 2] CPU_TARGETS3
  [then]


  [ifdef] GICD_GICD_ICFGR0_DEF
    \
    \ @brief GICD interrupt configuration register
    \ Address offset: 0xC00
    \ Reset value: 0xAAAAAAAA
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR1_DEF
    \
    \ @brief GICD interrupt configuration register
    \ Address offset: 0xC04
    \ Reset value: 0x55540000
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR2_DEF
    \
    \ @brief GICD interrupt configuration register 2
    \ Address offset: 0xC08
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR3_DEF
    \
    \ @brief GICD interrupt configuration register 3
    \ Address offset: 0xC0C
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR4_DEF
    \
    \ @brief GICD interrupt configuration register 4
    \ Address offset: 0xC10
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR5_DEF
    \
    \ @brief GICD interrupt configuration register 5
    \ Address offset: 0xC14
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR6_DEF
    \
    \ @brief GICD interrupt configuration register 6
    \ Address offset: 0xC18
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR7_DEF
    \
    \ @brief GICD interrupt configuration register 7
    \ Address offset: 0xC1C
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR8_DEF
    \
    \ @brief GICD interrupt configuration register 8
    \ Address offset: 0xC20
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR9_DEF
    \
    \ @brief GICD interrupt configuration register 9
    \ Address offset: 0xC24
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR10_DEF
    \
    \ @brief GICD interrupt configuration register 10
    \ Address offset: 0xC28
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR11_DEF
    \
    \ @brief GICD interrupt configuration register 11
    \ Address offset: 0xC2C
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR12_DEF
    \
    \ @brief GICD interrupt configuration register 12
    \ Address offset: 0xC30
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR13_DEF
    \
    \ @brief GICD interrupt configuration register 13
    \ Address offset: 0xC34
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR14_DEF
    \
    \ @brief GICD interrupt configuration register 14
    \ Address offset: 0xC38
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR15_DEF
    \
    \ @brief GICD interrupt configuration register 15
    \ Address offset: 0xC3C
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR16_DEF
    \
    \ @brief GICD interrupt configuration register 16
    \ Address offset: 0xC40
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_ICFGR17_DEF
    \
    \ @brief GICD interrupt configuration register 17
    \ Address offset: 0xC44
    \ Reset value: 0x55555555
    \
    $00 constant GICD_INT_CONFIG0               \ [0x00 : 2] INT_CONFIG0
    $02 constant GICD_INT_CONFIG1               \ [0x02 : 2] INT_CONFIG1
    $04 constant GICD_INT_CONFIG2               \ [0x04 : 2] INT_CONFIG2
    $06 constant GICD_INT_CONFIG3               \ [0x06 : 2] INT_CONFIG3
    $08 constant GICD_INT_CONFIG4               \ [0x08 : 2] INT_CONFIG4
    $0a constant GICD_INT_CONFIG5               \ [0x0a : 2] INT_CONFIG5
    $0c constant GICD_INT_CONFIG6               \ [0x0c : 2] INT_CONFIG6
    $0e constant GICD_INT_CONFIG7               \ [0x0e : 2] INT_CONFIG7
    $10 constant GICD_INT_CONFIG8               \ [0x10 : 2] INT_CONFIG8
    $12 constant GICD_INT_CONFIG9               \ [0x12 : 2] INT_CONFIG9
    $14 constant GICD_INT_CONFIG10              \ [0x14 : 2] INT_CONFIG10
    $16 constant GICD_INT_CONFIG11              \ [0x16 : 2] INT_CONFIG11
    $18 constant GICD_INT_CONFIG12              \ [0x18 : 2] INT_CONFIG12
    $1a constant GICD_INT_CONFIG13              \ [0x1a : 2] INT_CONFIG13
    $1c constant GICD_INT_CONFIG14              \ [0x1c : 2] INT_CONFIG14
    $1e constant GICD_INT_CONFIG15              \ [0x1e : 2] INT_CONFIG15
  [then]


  [ifdef] GICD_GICD_PPISR_DEF
    \
    \ @brief GICD private peripheral interrupt status register
    \ Address offset: 0xD00
    \ Reset value: 0x00000000
    \
    $09 constant GICD_PPI6                      \ [0x09] PPI6
    $0a constant GICD_PPI5                      \ [0x0a] PPI5
    $0b constant GICD_PPI4                      \ [0x0b] PPI4
    $0c constant GICD_PPI0                      \ [0x0c] PPI0
    $0d constant GICD_PPI1                      \ [0x0d] PPI1
    $0e constant GICD_PPI2                      \ [0x0e] PPI2
    $0f constant GICD_PPI3                      \ [0x0f] PPI3
  [then]


  [ifdef] GICD_GICD_SPISR1_DEF
    \
    \ @brief For interrupts ID = SPI number+32, from SPI [x*32+31] to SPI [x*32]
    \ Address offset: 0xD08
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISR1                    \ [0x00 : 32] SPISR1
  [then]


  [ifdef] GICD_GICD_SPISR2_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0xD0C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISR2                    \ [0x00 : 32] SPISR2
  [then]


  [ifdef] GICD_GICD_SPISR3_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0xD10
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISR3                    \ [0x00 : 32] SPISR3
  [then]


  [ifdef] GICD_GICD_SPISR4_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0xD14
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISR4                    \ [0x00 : 32] SPISR4
  [then]


  [ifdef] GICD_GICD_SPISR5_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0xD18
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISR5                    \ [0x00 : 32] SPISR5
  [then]


  [ifdef] GICD_GICD_SPISR6_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0xD1C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISR6                    \ [0x00 : 32] SPISR6
  [then]


  [ifdef] GICD_GICD_SPISR7_DEF
    \
    \ @brief For interrupts ID
    \ Address offset: 0xD20
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SPISR7                    \ [0x00 : 32] SPISR7
  [then]


  [ifdef] GICD_GICD_SGIR_DEF
    \
    \ @brief GICD software generated interrupt register
    \ Address offset: 0xF00
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGIINTID                  \ [0x00 : 4] SGIINTID
    $0f constant GICD_NSATT                     \ [0x0f] NSATT
    $10 constant GICD_CPUTARGETLIST             \ [0x10 : 2] CPUTARGETLIST
    $18 constant GICD_TARGETLISTFILTER          \ [0x18 : 2] TARGETLISTFILTER
  [then]


  [ifdef] GICD_GICD_CPENDSGIR0_DEF
    \
    \ @brief For SGI x*4 to SGI x*4+3
    \ Address offset: 0xF10
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_CLEAR_PENDING0        \ [0x00 : 2] SGI_CLEAR_PENDING0
    $08 constant GICD_SGI_CLEAR_PENDING1        \ [0x08 : 2] SGI_CLEAR_PENDING1
    $10 constant GICD_SGI_CLEAR_PENDING2        \ [0x10 : 2] SGI_CLEAR_PENDING2
    $18 constant GICD_SGI_CLEAR_PENDING3        \ [0x18 : 2] SGI_CLEAR_PENDING3
  [then]


  [ifdef] GICD_GICD_CPENDSGIR1_DEF
    \
    \ @brief For SGI x*4 to SGI x*4+3
    \ Address offset: 0xF14
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_CLEAR_PENDING0        \ [0x00 : 2] SGI_CLEAR_PENDING0
    $08 constant GICD_SGI_CLEAR_PENDING1        \ [0x08 : 2] SGI_CLEAR_PENDING1
    $10 constant GICD_SGI_CLEAR_PENDING2        \ [0x10 : 2] SGI_CLEAR_PENDING2
    $18 constant GICD_SGI_CLEAR_PENDING3        \ [0x18 : 2] SGI_CLEAR_PENDING3
  [then]


  [ifdef] GICD_GICD_CPENDSGIR2_DEF
    \
    \ @brief For SGI x*4 to SGI x*4+3
    \ Address offset: 0xF18
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_CLEAR_PENDING0        \ [0x00 : 2] SGI_CLEAR_PENDING0
    $08 constant GICD_SGI_CLEAR_PENDING1        \ [0x08 : 2] SGI_CLEAR_PENDING1
    $10 constant GICD_SGI_CLEAR_PENDING2        \ [0x10 : 2] SGI_CLEAR_PENDING2
    $18 constant GICD_SGI_CLEAR_PENDING3        \ [0x18 : 2] SGI_CLEAR_PENDING3
  [then]


  [ifdef] GICD_GICD_CPENDSGIR3_DEF
    \
    \ @brief For SGI x*4 to SGI x*4+3
    \ Address offset: 0xF1C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_CLEAR_PENDING0        \ [0x00 : 2] SGI_CLEAR_PENDING0
    $08 constant GICD_SGI_CLEAR_PENDING1        \ [0x08 : 2] SGI_CLEAR_PENDING1
    $10 constant GICD_SGI_CLEAR_PENDING2        \ [0x10 : 2] SGI_CLEAR_PENDING2
    $18 constant GICD_SGI_CLEAR_PENDING3        \ [0x18 : 2] SGI_CLEAR_PENDING3
  [then]


  [ifdef] GICD_GICD_SPENDSGIR0_DEF
    \
    \ @brief For SGI x*4 to SGI x*4+3
    \ Address offset: 0xF20
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_SET_PENDING0          \ [0x00 : 2] SGI_SET_PENDING0
    $08 constant GICD_SGI_SET_PENDING1          \ [0x08 : 2] SGI_SET_PENDING1
    $10 constant GICD_SGI_SET_PENDING2          \ [0x10 : 2] SGI_SET_PENDING2
    $18 constant GICD_SGI_SET_PENDING3          \ [0x18 : 2] SGI_SET_PENDING3
  [then]


  [ifdef] GICD_GICD_SPENDSGIR1_DEF
    \
    \ @brief For SGI x*4 to SGI x*4+3
    \ Address offset: 0xF24
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_SET_PENDING0          \ [0x00 : 2] SGI_SET_PENDING0
    $08 constant GICD_SGI_SET_PENDING1          \ [0x08 : 2] SGI_SET_PENDING1
    $10 constant GICD_SGI_SET_PENDING2          \ [0x10 : 2] SGI_SET_PENDING2
    $18 constant GICD_SGI_SET_PENDING3          \ [0x18 : 2] SGI_SET_PENDING3
  [then]


  [ifdef] GICD_GICD_SPENDSGIR2_DEF
    \
    \ @brief For SGI x*4 to SGI x*4+3
    \ Address offset: 0xF28
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_SET_PENDING0          \ [0x00 : 2] SGI_SET_PENDING0
    $08 constant GICD_SGI_SET_PENDING1          \ [0x08 : 2] SGI_SET_PENDING1
    $10 constant GICD_SGI_SET_PENDING2          \ [0x10 : 2] SGI_SET_PENDING2
    $18 constant GICD_SGI_SET_PENDING3          \ [0x18 : 2] SGI_SET_PENDING3
  [then]


  [ifdef] GICD_GICD_SPENDSGIR3_DEF
    \
    \ @brief For SGI x*4 to SGI x*4+3
    \ Address offset: 0xF2C
    \ Reset value: 0x00000000
    \
    $00 constant GICD_SGI_SET_PENDING0          \ [0x00 : 2] SGI_SET_PENDING0
    $08 constant GICD_SGI_SET_PENDING1          \ [0x08 : 2] SGI_SET_PENDING1
    $10 constant GICD_SGI_SET_PENDING2          \ [0x10 : 2] SGI_SET_PENDING2
    $18 constant GICD_SGI_SET_PENDING3          \ [0x18 : 2] SGI_SET_PENDING3
  [then]


  [ifdef] GICD_GICD_PIDR4_DEF
    \
    \ @brief GICD peripheral ID4 register
    \ Address offset: 0xFD0
    \ Reset value: 0x00000004
    \
    $00 constant GICD_PIDR4                     \ [0x00 : 32] PIDR4
  [then]


  [ifdef] GICD_GICD_PIDR5_DEF
    \
    \ @brief GICD peripheral ID5 to ID7 register 5
    \ Address offset: 0xFD4
    \ Reset value: 0x00000000
    \
    $00 constant GICD_PIDR5                     \ [0x00 : 32] PIDR5
  [then]


  [ifdef] GICD_GICD_PIDR6_DEF
    \
    \ @brief GICD peripheral ID5 to ID7 register 6
    \ Address offset: 0xFD8
    \ Reset value: 0x00000000
    \
    $00 constant GICD_PIDR6                     \ [0x00 : 32] PIDR6
  [then]


  [ifdef] GICD_GICD_PIDR7_DEF
    \
    \ @brief GICD peripheral ID5 to ID7 register 7
    \ Address offset: 0xFDC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_PIDR7                     \ [0x00 : 32] PIDR7
  [then]


  [ifdef] GICD_GICD_PIDR0_DEF
    \
    \ @brief GICD peripheral ID0 register
    \ Address offset: 0xFE0
    \ Reset value: 0x00000090
    \
    $00 constant GICD_PIDR0                     \ [0x00 : 32] PIDR0
  [then]


  [ifdef] GICD_GICD_PIDR1_DEF
    \
    \ @brief GICD peripheral ID1 register
    \ Address offset: 0xFE4
    \ Reset value: 0x000000B4
    \
    $00 constant GICD_PIDR1                     \ [0x00 : 32] PIDR1
  [then]


  [ifdef] GICD_GICD_PIDR2_DEF
    \
    \ @brief GICD peripheral ID2 register
    \ Address offset: 0xFE8
    \ Reset value: 0x0000002B
    \
    $00 constant GICD_PIDR2                     \ [0x00 : 32] PIDR2
  [then]


  [ifdef] GICD_GICD_PIDR3_DEF
    \
    \ @brief GICD peripheral ID3 register
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant GICD_PIDR3                     \ [0x00 : 32] PIDR3
  [then]


  [ifdef] GICD_GICD_CIDR0_DEF
    \
    \ @brief GICD component ID0 register
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant GICD_CIDR0                     \ [0x00 : 32] CIDR0
  [then]


  [ifdef] GICD_GICD_CIDR1_DEF
    \
    \ @brief GICD component ID1 register
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant GICD_CIDR1                     \ [0x00 : 32] CIDR1
  [then]


  [ifdef] GICD_GICD_CIDR2_DEF
    \
    \ @brief GICD component ID2 register
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant GICD_CIDR2                     \ [0x00 : 32] CIDR2
  [then]


  [ifdef] GICD_GICD_CIDR3_DEF
    \
    \ @brief GICD component ID3 register
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant GICD_CIDR3                     \ [0x00 : 32] CIDR3
  [then]

  \
  \ @brief GICD
  \
  $00 constant GICD_GICD_CTLR           \ GICD control register
  $04 constant GICD_GICD_TYPER          \ GICD interrupt controller type register
  $08 constant GICD_GICD_IIDR           \ GICD implementer identification register
  $80 constant GICD_GICD_IGROUPR0       \ For interrupts ID
  $84 constant GICD_GICD_IGROUPR1       \ For interrupts ID
  $88 constant GICD_GICD_IGROUPR2       \ For interrupts ID
  $8C constant GICD_GICD_IGROUPR3       \ For interrupts ID = x*32 to ID = x*32+31
  $90 constant GICD_GICD_IGROUPR4       \ For interrupts ID = x*32 to ID = x*32+31
  $94 constant GICD_GICD_IGROUPR5       \ For interrupts ID
  $98 constant GICD_GICD_IGROUPR6       \ For interrupts ID
  $9C constant GICD_GICD_IGROUPR7       \ For interrupts ID
  $A0 constant GICD_GICD_IGROUPR8       \ For interrupts ID
  $100 constant GICD_GICD_ISENABLER0    \ For interrupts ID = 0 to ID = 31
  $104 constant GICD_GICD_ISENABLER1    \ For interrupts ID
  $108 constant GICD_GICD_ISENABLER2    \ For interrupts ID
  $10C constant GICD_GICD_ISENABLER3    \ For interrupts ID
  $110 constant GICD_GICD_ISENABLER4    \ For interrupts ID
  $114 constant GICD_GICD_ISENABLER5    \ For interrupts ID
  $118 constant GICD_GICD_ISENABLER6    \ For interrupts ID
  $11C constant GICD_GICD_ISENABLER7    \ For interrupts ID
  $120 constant GICD_GICD_ISENABLER8    \ For interrupts ID
  $180 constant GICD_GICD_ICENABLER0    \ For interrupts ID = 0 to ID = 31
  $184 constant GICD_GICD_ICENABLER1    \ For interrupts ID
  $188 constant GICD_GICD_ICENABLER2    \ For interrupts ID
  $18C constant GICD_GICD_ICENABLER3    \ For interrupts ID
  $190 constant GICD_GICD_ICENABLER4    \ For interrupts ID
  $194 constant GICD_GICD_ICENABLER5    \ For interrupts ID
  $198 constant GICD_GICD_ICENABLER6    \ For interrupts ID
  $19C constant GICD_GICD_ICENABLER7    \ For interrupts ID
  $1A0 constant GICD_GICD_ICENABLER8    \ For interrupts ID
  $200 constant GICD_GICD_ISPENDR0      \ For interrupts ID
  $204 constant GICD_GICD_ISPENDR1      \ For interrupts ID
  $208 constant GICD_GICD_ISPENDR2      \ For interrupts ID
  $20C constant GICD_GICD_ISPENDR3      \ For interrupts ID
  $210 constant GICD_GICD_ISPENDR4      \ For interrupts ID
  $214 constant GICD_GICD_ISPENDR5      \ For interrupts ID
  $218 constant GICD_GICD_ISPENDR6      \ For interrupts ID
  $21C constant GICD_GICD_ISPENDR7      \ For interrupts ID
  $220 constant GICD_GICD_ISPENDR8      \ For interrupts ID
  $280 constant GICD_GICD_ICPENDR0      \ For interrupts ID
  $284 constant GICD_GICD_ICPENDR1      \ For interrupts ID
  $288 constant GICD_GICD_ICPENDR2      \ For interrupts ID
  $28C constant GICD_GICD_ICPENDR3      \ For interrupts ID
  $290 constant GICD_GICD_ICPENDR4      \ For interrupts ID
  $294 constant GICD_GICD_ICPENDR5      \ For interrupts ID
  $298 constant GICD_GICD_ICPENDR6      \ For interrupts ID
  $29C constant GICD_GICD_ICPENDR7      \ For interrupts ID
  $2A0 constant GICD_GICD_ICPENDR8      \ For interrupts ID
  $300 constant GICD_GICD_ISACTIVER0    \ For interrupts ID
  $304 constant GICD_GICD_ISACTIVER1    \ For interrupts ID
  $308 constant GICD_GICD_ISACTIVER2    \ For interrupts ID
  $30C constant GICD_GICD_ISACTIVER3    \ For interrupts ID
  $310 constant GICD_GICD_ISACTIVER4    \ For interrupts ID
  $314 constant GICD_GICD_ISACTIVER5    \ For interrupts ID
  $318 constant GICD_GICD_ISACTIVER6    \ For interrupts ID
  $31C constant GICD_GICD_ISACTIVER7    \ For interrupts ID
  $320 constant GICD_GICD_ISACTIVER8    \ For interrupts ID
  $380 constant GICD_GICD_ICACTIVER0    \ For interrupts ID
  $384 constant GICD_GICD_ICACTIVER1    \ For interrupts ID
  $388 constant GICD_GICD_ICACTIVER2    \ For interrupts ID
  $38C constant GICD_GICD_ICACTIVER3    \ For interrupts ID
  $390 constant GICD_GICD_ICACTIVER4    \ For interrupts ID
  $394 constant GICD_GICD_ICACTIVER5    \ For interrupts ID
  $398 constant GICD_GICD_ICACTIVER6    \ For interrupts ID
  $39C constant GICD_GICD_ICACTIVER7    \ For interrupts ID
  $3A0 constant GICD_GICD_ICACTIVER8    \ For interrupts ID
  $400 constant GICD_GICD_IPRIORITYR0   \ GICD interrupt priority register 0
  $404 constant GICD_GICD_IPRIORITYR1   \ GICD interrupt priority register 1
  $408 constant GICD_GICD_IPRIORITYR2   \ GICD interrupt priority register 2
  $40C constant GICD_GICD_IPRIORITYR3   \ GICD interrupt priority register 3
  $410 constant GICD_GICD_IPRIORITYR4   \ GICD interrupt priority register 4
  $414 constant GICD_GICD_IPRIORITYR5   \ GICD interrupt priority register 5
  $418 constant GICD_GICD_IPRIORITYR6   \ GICD interrupt priority register 6
  $41C constant GICD_GICD_IPRIORITYR7   \ GICD interrupt priority register 7
  $420 constant GICD_GICD_IPRIORITYR8   \ GICD interrupt priority register 8
  $424 constant GICD_GICD_IPRIORITYR9   \ GICD interrupt priority register 9
  $428 constant GICD_GICD_IPRIORITYR10  \ GICD interrupt priority register 10
  $42C constant GICD_GICD_IPRIORITYR11  \ GICD interrupt priority register 11
  $430 constant GICD_GICD_IPRIORITYR12  \ GICD interrupt priority register 12
  $434 constant GICD_GICD_IPRIORITYR13  \ GICD interrupt priority register 13
  $438 constant GICD_GICD_IPRIORITYR14  \ GICD interrupt priority register 14
  $43C constant GICD_GICD_IPRIORITYR15  \ GICD interrupt priority register 15
  $440 constant GICD_GICD_IPRIORITYR16  \ GICD interrupt priority register 16
  $444 constant GICD_GICD_IPRIORITYR17  \ GICD interrupt priority register 17
  $448 constant GICD_GICD_IPRIORITYR18  \ GICD interrupt priority register 18
  $44C constant GICD_GICD_IPRIORITYR19  \ GICD interrupt priority register 19
  $450 constant GICD_GICD_IPRIORITYR20  \ GICD interrupt priority register 20
  $454 constant GICD_GICD_IPRIORITYR21  \ GICD interrupt priority register 21
  $458 constant GICD_GICD_IPRIORITYR22  \ GICD interrupt priority register 22
  $45C constant GICD_GICD_IPRIORITYR23  \ GICD interrupt priority register 23
  $460 constant GICD_GICD_IPRIORITYR24  \ GICD interrupt priority register 24
  $464 constant GICD_GICD_IPRIORITYR25  \ GICD interrupt priority register 25
  $468 constant GICD_GICD_IPRIORITYR26  \ GICD interrupt priority register 26
  $46C constant GICD_GICD_IPRIORITYR27  \ GICD interrupt priority register 27
  $470 constant GICD_GICD_IPRIORITYR28  \ GICD interrupt priority register 28
  $474 constant GICD_GICD_IPRIORITYR29  \ GICD interrupt priority register 29
  $478 constant GICD_GICD_IPRIORITYR30  \ GICD interrupt priority register 30
  $47C constant GICD_GICD_IPRIORITYR31  \ GICD interrupt priority register 31
  $480 constant GICD_GICD_IPRIORITYR32  \ GICD interrupt priority register 32
  $484 constant GICD_GICD_IPRIORITYR33  \ GICD interrupt priority register 33
  $488 constant GICD_GICD_IPRIORITYR34  \ GICD interrupt priority register 34
  $48C constant GICD_GICD_IPRIORITYR35  \ GICD interrupt priority register 35
  $490 constant GICD_GICD_IPRIORITYR36  \ GICD interrupt priority register 36
  $494 constant GICD_GICD_IPRIORITYR37  \ GICD interrupt priority register 37
  $498 constant GICD_GICD_IPRIORITYR38  \ GICD interrupt priority register 38
  $49C constant GICD_GICD_IPRIORITYR39  \ GICD interrupt priority register 39
  $4A0 constant GICD_GICD_IPRIORITYR40  \ GICD interrupt priority register 40
  $4A4 constant GICD_GICD_IPRIORITYR41  \ GICD interrupt priority register 41
  $4A8 constant GICD_GICD_IPRIORITYR42  \ GICD interrupt priority register 42
  $4AC constant GICD_GICD_IPRIORITYR43  \ GICD interrupt priority register 43
  $4B0 constant GICD_GICD_IPRIORITYR44  \ GICD interrupt priority register 44
  $4B4 constant GICD_GICD_IPRIORITYR45  \ GICD interrupt priority register 45
  $4B8 constant GICD_GICD_IPRIORITYR46  \ GICD interrupt priority register 46
  $4BC constant GICD_GICD_IPRIORITYR47  \ GICD interrupt priority register 47
  $4C0 constant GICD_GICD_IPRIORITYR48  \ GICD interrupt priority register 48
  $4C4 constant GICD_GICD_IPRIORITYR49  \ GICD interrupt priority register 49
  $4C8 constant GICD_GICD_IPRIORITYR50  \ GICD interrupt priority register 50
  $4CC constant GICD_GICD_IPRIORITYR51  \ GICD interrupt priority register 51
  $4D0 constant GICD_GICD_IPRIORITYR52  \ GICD interrupt priority register 52
  $4D4 constant GICD_GICD_IPRIORITYR53  \ GICD interrupt priority register 53
  $4D8 constant GICD_GICD_IPRIORITYR54  \ GICD interrupt priority register 54
  $4DC constant GICD_GICD_IPRIORITYR55  \ GICD interrupt priority register 55
  $4E0 constant GICD_GICD_IPRIORITYR56  \ GICD interrupt priority register 56
  $4E4 constant GICD_GICD_IPRIORITYR57  \ GICD interrupt priority register 57
  $4E8 constant GICD_GICD_IPRIORITYR58  \ GICD interrupt priority register 58
  $4EC constant GICD_GICD_IPRIORITYR59  \ GICD interrupt priority register 59
  $4F0 constant GICD_GICD_IPRIORITYR60  \ GICD interrupt priority register 60
  $4F4 constant GICD_GICD_IPRIORITYR61  \ GICD interrupt priority register 61
  $4F8 constant GICD_GICD_IPRIORITYR62  \ GICD interrupt priority register 62
  $4FC constant GICD_GICD_IPRIORITYR63  \ GICD interrupt priority register 63
  $500 constant GICD_GICD_IPRIORITYR64  \ GICD interrupt priority register 64
  $504 constant GICD_GICD_IPRIORITYR65  \ GICD interrupt priority register 65
  $508 constant GICD_GICD_IPRIORITYR66  \ GICD interrupt priority register 66
  $50C constant GICD_GICD_IPRIORITYR67  \ GICD interrupt priority register 67
  $510 constant GICD_GICD_IPRIORITYR68  \ GICD interrupt priority register 68
  $514 constant GICD_GICD_IPRIORITYR69  \ GICD interrupt priority register 69
  $518 constant GICD_GICD_IPRIORITYR70  \ GICD interrupt priority register 70
  $51C constant GICD_GICD_IPRIORITYR71  \ GICD interrupt priority register 71
  $800 constant GICD_GICD_ITARGETSR0    \ For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
  $804 constant GICD_GICD_ITARGETSR1    \ For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
  $808 constant GICD_GICD_ITARGETSR2    \ For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
  $80C constant GICD_GICD_ITARGETSR3    \ For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
  $810 constant GICD_GICD_ITARGETSR4    \ For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
  $814 constant GICD_GICD_ITARGETSR5    \ For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
  $818 constant GICD_GICD_ITARGETSR6    \ For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
  $81C constant GICD_GICD_ITARGETSR7    \ For existing SGIs and PPIs, read of CPU targets field returns the number of the processor performing the read.
  $820 constant GICD_GICD_ITARGETSR8    \ GICD interrupt processor target register 8
  $824 constant GICD_GICD_ITARGETSR9    \ GICD interrupt processor target register 9
  $828 constant GICD_GICD_ITARGETSR10   \ GICD interrupt processor target register 10
  $82C constant GICD_GICD_ITARGETSR11   \ GICD interrupt processor target register 11
  $830 constant GICD_GICD_ITARGETSR12   \ GICD interrupt processor target register 12
  $834 constant GICD_GICD_ITARGETSR13   \ GICD interrupt processor target register 13
  $838 constant GICD_GICD_ITARGETSR14   \ GICD interrupt processor target register 14
  $83C constant GICD_GICD_ITARGETSR15   \ GICD interrupt processor target register 15
  $840 constant GICD_GICD_ITARGETSR16   \ GICD interrupt processor target register 16
  $844 constant GICD_GICD_ITARGETSR17   \ GICD interrupt processor target register 17
  $848 constant GICD_GICD_ITARGETSR18   \ GICD interrupt processor target register 18
  $84C constant GICD_GICD_ITARGETSR19   \ GICD interrupt processor target register 19
  $850 constant GICD_GICD_ITARGETSR20   \ GICD interrupt processor target register 20
  $854 constant GICD_GICD_ITARGETSR21   \ GICD interrupt processor target register 21
  $858 constant GICD_GICD_ITARGETSR22   \ GICD interrupt processor target register 22
  $85C constant GICD_GICD_ITARGETSR23   \ GICD interrupt processor target register 23
  $860 constant GICD_GICD_ITARGETSR24   \ GICD interrupt processor target register 24
  $864 constant GICD_GICD_ITARGETSR25   \ GICD interrupt processor target register 25
  $868 constant GICD_GICD_ITARGETSR26   \ GICD interrupt processor target register 26
  $86C constant GICD_GICD_ITARGETSR27   \ GICD interrupt processor target register 27
  $870 constant GICD_GICD_ITARGETSR28   \ GICD interrupt processor target register 28
  $874 constant GICD_GICD_ITARGETSR29   \ GICD interrupt processor target register 29
  $878 constant GICD_GICD_ITARGETSR30   \ GICD interrupt processor target register 30
  $87C constant GICD_GICD_ITARGETSR31   \ GICD interrupt processor target register 31
  $880 constant GICD_GICD_ITARGETSR32   \ GICD interrupt processor target register 32
  $884 constant GICD_GICD_ITARGETSR33   \ GICD interrupt processor target register 33
  $888 constant GICD_GICD_ITARGETSR34   \ GICD interrupt processor target register 34
  $88C constant GICD_GICD_ITARGETSR35   \ GICD interrupt processor target register 35
  $890 constant GICD_GICD_ITARGETSR36   \ GICD interrupt processor target register 36
  $894 constant GICD_GICD_ITARGETSR37   \ GICD interrupt processor target register 37
  $898 constant GICD_GICD_ITARGETSR38   \ GICD interrupt processor target register 38
  $89C constant GICD_GICD_ITARGETSR39   \ GICD interrupt processor target register 39
  $8A0 constant GICD_GICD_ITARGETSR40   \ GICD interrupt processor target register 40
  $8A4 constant GICD_GICD_ITARGETSR41   \ GICD interrupt processor target register 41
  $8A8 constant GICD_GICD_ITARGETSR42   \ GICD interrupt processor target register 42
  $8AC constant GICD_GICD_ITARGETSR43   \ GICD interrupt processor target register 43
  $8B0 constant GICD_GICD_ITARGETSR44   \ GICD interrupt processor target register 44
  $8B4 constant GICD_GICD_ITARGETSR45   \ GICD interrupt processor target register 45
  $8B8 constant GICD_GICD_ITARGETSR46   \ GICD interrupt processor target register 46
  $8BC constant GICD_GICD_ITARGETSR47   \ GICD interrupt processor target register 47
  $8C0 constant GICD_GICD_ITARGETSR48   \ GICD interrupt processor target register 48
  $8C4 constant GICD_GICD_ITARGETSR49   \ GICD interrupt processor target register 49
  $8C8 constant GICD_GICD_ITARGETSR50   \ GICD interrupt processor target register 50
  $8CC constant GICD_GICD_ITARGETSR51   \ GICD interrupt processor target register 51
  $8D0 constant GICD_GICD_ITARGETSR52   \ GICD interrupt processor target register 52
  $8D4 constant GICD_GICD_ITARGETSR53   \ GICD interrupt processor target register 53
  $8D8 constant GICD_GICD_ITARGETSR54   \ GICD interrupt processor target register 54
  $8DC constant GICD_GICD_ITARGETSR55   \ GICD interrupt processor target register 55
  $8E0 constant GICD_GICD_ITARGETSR56   \ GICD interrupt processor target register 56
  $8E4 constant GICD_GICD_ITARGETSR57   \ GICD interrupt processor target register 57
  $8E8 constant GICD_GICD_ITARGETSR58   \ GICD interrupt processor target register 58
  $8EC constant GICD_GICD_ITARGETSR59   \ GICD interrupt processor target register 59
  $8F0 constant GICD_GICD_ITARGETSR60   \ GICD interrupt processor target register 60
  $8F4 constant GICD_GICD_ITARGETSR61   \ GICD interrupt processor target register 61
  $8F8 constant GICD_GICD_ITARGETSR62   \ GICD interrupt processor target register 62
  $8FC constant GICD_GICD_ITARGETSR63   \ GICD interrupt processor target register 63
  $900 constant GICD_GICD_ITARGETSR64   \ GICD interrupt processor target register 64
  $904 constant GICD_GICD_ITARGETSR65   \ GICD interrupt processor target register 65
  $908 constant GICD_GICD_ITARGETSR66   \ GICD interrupt processor target register 66
  $90C constant GICD_GICD_ITARGETSR67   \ GICD interrupt processor target register 67
  $910 constant GICD_GICD_ITARGETSR68   \ GICD interrupt processor target register 68
  $914 constant GICD_GICD_ITARGETSR69   \ GICD interrupt processor target register 69
  $918 constant GICD_GICD_ITARGETSR70   \ GICD interrupt processor target register 70
  $91C constant GICD_GICD_ITARGETSR71   \ GICD interrupt processor target register 71
  $C00 constant GICD_GICD_ICFGR0        \ GICD interrupt configuration register
  $C04 constant GICD_GICD_ICFGR1        \ GICD interrupt configuration register
  $C08 constant GICD_GICD_ICFGR2        \ GICD interrupt configuration register 2
  $C0C constant GICD_GICD_ICFGR3        \ GICD interrupt configuration register 3
  $C10 constant GICD_GICD_ICFGR4        \ GICD interrupt configuration register 4
  $C14 constant GICD_GICD_ICFGR5        \ GICD interrupt configuration register 5
  $C18 constant GICD_GICD_ICFGR6        \ GICD interrupt configuration register 6
  $C1C constant GICD_GICD_ICFGR7        \ GICD interrupt configuration register 7
  $C20 constant GICD_GICD_ICFGR8        \ GICD interrupt configuration register 8
  $C24 constant GICD_GICD_ICFGR9        \ GICD interrupt configuration register 9
  $C28 constant GICD_GICD_ICFGR10       \ GICD interrupt configuration register 10
  $C2C constant GICD_GICD_ICFGR11       \ GICD interrupt configuration register 11
  $C30 constant GICD_GICD_ICFGR12       \ GICD interrupt configuration register 12
  $C34 constant GICD_GICD_ICFGR13       \ GICD interrupt configuration register 13
  $C38 constant GICD_GICD_ICFGR14       \ GICD interrupt configuration register 14
  $C3C constant GICD_GICD_ICFGR15       \ GICD interrupt configuration register 15
  $C40 constant GICD_GICD_ICFGR16       \ GICD interrupt configuration register 16
  $C44 constant GICD_GICD_ICFGR17       \ GICD interrupt configuration register 17
  $D00 constant GICD_GICD_PPISR         \ GICD private peripheral interrupt status register
  $D08 constant GICD_GICD_SPISR1        \ For interrupts ID = SPI number+32, from SPI [x*32+31] to SPI [x*32]
  $D0C constant GICD_GICD_SPISR2        \ For interrupts ID
  $D10 constant GICD_GICD_SPISR3        \ For interrupts ID
  $D14 constant GICD_GICD_SPISR4        \ For interrupts ID
  $D18 constant GICD_GICD_SPISR5        \ For interrupts ID
  $D1C constant GICD_GICD_SPISR6        \ For interrupts ID
  $D20 constant GICD_GICD_SPISR7        \ For interrupts ID
  $F00 constant GICD_GICD_SGIR          \ GICD software generated interrupt register
  $F10 constant GICD_GICD_CPENDSGIR0    \ For SGI x*4 to SGI x*4+3
  $F14 constant GICD_GICD_CPENDSGIR1    \ For SGI x*4 to SGI x*4+3
  $F18 constant GICD_GICD_CPENDSGIR2    \ For SGI x*4 to SGI x*4+3
  $F1C constant GICD_GICD_CPENDSGIR3    \ For SGI x*4 to SGI x*4+3
  $F20 constant GICD_GICD_SPENDSGIR0    \ For SGI x*4 to SGI x*4+3
  $F24 constant GICD_GICD_SPENDSGIR1    \ For SGI x*4 to SGI x*4+3
  $F28 constant GICD_GICD_SPENDSGIR2    \ For SGI x*4 to SGI x*4+3
  $F2C constant GICD_GICD_SPENDSGIR3    \ For SGI x*4 to SGI x*4+3
  $FD0 constant GICD_GICD_PIDR4         \ GICD peripheral ID4 register
  $FD4 constant GICD_GICD_PIDR5         \ GICD peripheral ID5 to ID7 register 5
  $FD8 constant GICD_GICD_PIDR6         \ GICD peripheral ID5 to ID7 register 6
  $FDC constant GICD_GICD_PIDR7         \ GICD peripheral ID5 to ID7 register 7
  $FE0 constant GICD_GICD_PIDR0         \ GICD peripheral ID0 register
  $FE4 constant GICD_GICD_PIDR1         \ GICD peripheral ID1 register
  $FE8 constant GICD_GICD_PIDR2         \ GICD peripheral ID2 register
  $FEC constant GICD_GICD_PIDR3         \ GICD peripheral ID3 register
  $FF0 constant GICD_GICD_CIDR0         \ GICD component ID0 register
  $FF4 constant GICD_GICD_CIDR1         \ GICD component ID1 register
  $FF8 constant GICD_GICD_CIDR2         \ GICD component ID2 register
  $FFC constant GICD_GICD_CIDR3         \ GICD component ID3 register

: GICD_DEF ; [then]
