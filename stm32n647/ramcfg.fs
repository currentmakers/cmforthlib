\
\ @file ramcfg.fs
\ @brief SRAM configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RAMCFG_DEF

  [ifdef] RAMCFG_RAMCFG_AXISRAM1CR_DEF
    \
    \ @brief RAMCFG AXISRAM1 control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase.
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM1ISR_DEF
    \
    \ @brief RAMCFG AXISRAM1 interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM1ERKEYR_DEF
    \
    \ @brief RAMCFG AXISRAM1 erase key register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM2CR_DEF
    \
    \ @brief RAMCFG AXISRAM2 control register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
    $14 constant RAMCFG_SRAMSD                  \ [0x14] Shutdown AXISRAMx
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM2ISR_DEF
    \
    \ @brief RAMCFG AXISRAM2 interrupt status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM2ERKEYR_DEF
    \
    \ @brief RAMCFG AXISRAM2 erase key register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM3CR_DEF
    \
    \ @brief RAMCFG AXISRAM3 control register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
    $14 constant RAMCFG_SRAMSD                  \ [0x14] Shutdown AXISRAMx
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM3ISR_DEF
    \
    \ @brief RAMCFG AXISRAM3 interrupt status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM3ERKEYR_DEF
    \
    \ @brief RAMCFG AXISRAM3 erase key register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM4CR_DEF
    \
    \ @brief RAMCFG AXISRAM4 control register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
    $14 constant RAMCFG_SRAMSD                  \ [0x14] Shutdown AXISRAMx
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM4ISR_DEF
    \
    \ @brief RAMCFG AXISRAM4 interrupt status register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM4ERKEYR_DEF
    \
    \ @brief RAMCFG AXISRAM4 erase key register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM5CR_DEF
    \
    \ @brief RAMCFG AXISRAM5 control register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
    $14 constant RAMCFG_SRAMSD                  \ [0x14] Shutdown AXISRAMx
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM5ISR_DEF
    \
    \ @brief RAMCFG AXISRAM5 interrupt status register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM5ERKEYR_DEF
    \
    \ @brief RAMCFG AXISRAM5 erase key register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM6CR_DEF
    \
    \ @brief RAMCFG AXISRAM6 control register
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
    $14 constant RAMCFG_SRAMSD                  \ [0x14] Shutdown AXISRAMx
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM6ISR_DEF
    \
    \ @brief RAMCFG AXISRAM6 interrupt status register
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_AXISRAM6ERKEYR_DEF
    \
    \ @brief RAMCFG AXISRAM6 erase key register
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_AHBSRAM1CR_DEF
    \
    \ @brief RAMCFG AHBSRAM1 control register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
  [then]


  [ifdef] RAMCFG_RAMCFG_AHBSRAM1ISR_DEF
    \
    \ @brief RAMCFG AHBSRAM1 interrupt status register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_AHBSRAM1ERKEYR_DEF
    \
    \ @brief RAMCFG AHBSRAM1 erase key register
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_AHBSRAM2CR_DEF
    \
    \ @brief RAMCFG AHBSRAM2 control register
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
  [then]


  [ifdef] RAMCFG_RAMCFG_AHBSRAM2ISR_DEF
    \
    \ @brief RAMCFG AHBSRAM2 interrupt status register
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_AHBSRAM2ERKEYR_DEF
    \
    \ @brief RAMCFG AHBSRAM2 erase key register
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_VENCRAMCR_DEF
    \
    \ @brief RAMCFG VENCRAM control register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
  [then]


  [ifdef] RAMCFG_RAMCFG_VENCRAMISR_DEF
    \
    \ @brief RAMCFG VENCRAM interrupt status register
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_VENCRAMERKEYR_DEF
    \
    \ @brief RAMCFG VENCRAM erase key register
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_BKPSRAMCR_DEF
    \
    \ @brief RAMCFG BKPSRAM control register
    \ Address offset: 0x480
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCE                    \ [0x00] ECC enable
    $04 constant RAMCFG_ALE                     \ [0x04] Address latch enable
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
  [then]


  [ifdef] RAMCFG_RAMCFG_BKPSRAMIER_DEF
    \
    \ @brief RAMCFG BKPSRAM interrupt enable register
    \ Address offset: 0x484
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEIE                    \ [0x00] ECC single error interrupt enable
    $01 constant RAMCFG_DEIE                    \ [0x01] ECC double error interrupt enable
  [then]


  [ifdef] RAMCFG_RAMCFG_BKPSRAMISR_DEF
    \
    \ @brief RAMCFG BKPSRAM interrupt status register
    \ Address offset: 0x488
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_SEC                     \ [0x00] ECC single error detected
    $01 constant RAMCFG_DED                     \ [0x01] ECC double-error interrupt enable
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_BKPSRAMESEAR_DEF
    \
    \ @brief RAMCFG BKPSRAM single error address register
    \ Address offset: 0x48C
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ESEA                    \ [0x00 : 11] ECC single error address
  [then]


  [ifdef] RAMCFG_RAMCFG_BKPSRAMEDEAR_DEF
    \
    \ @brief RAMCFG BKPSRAM double error address register
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_EDEA                    \ [0x00 : 11] ECC double error address
  [then]


  [ifdef] RAMCFG_RAMCFG_BKPSRAMICR_DEF
    \
    \ @brief RAMCFG BKPSRAM interrupt clear register
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_CSED                    \ [0x00] Clear ECC single-error interrupt
    $01 constant RAMCFG_CDED                    \ [0x01] Clear ECC double-error interrupt
  [then]


  [ifdef] RAMCFG_RAMCFG_BKPSRAMECCKEYR_DEF
    \
    \ @brief RAMCFG BKPSRAM ECC key register
    \ Address offset: 0x4A4
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ECCKEY                  \ [0x00 : 8] ECC write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_BKPSRAMERKEYR_DEF
    \
    \ @brief RAMCFG BKPSRAM erase key register
    \ Address offset: 0x4A8
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]


  [ifdef] RAMCFG_RAMCFG_FLEXRAMCR_DEF
    \
    \ @brief RAMCFG FLEXRAM control register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMER                  \ [0x08] SRAM erase
    $0c constant RAMCFG_SRAMHWERDIS             \ [0x0c] SRAM hardware erase disable
    $10 constant RAMCFG_ITCMCFG                 \ [0x10 : 2] Configuration of the FLEXMEM I-TCM extension
    $18 constant RAMCFG_DTCMCFG                 \ [0x18] Configuration of the FLEXMEM D-TCM extension
  [then]


  [ifdef] RAMCFG_RAMCFG_FLEXRAMISR_DEF
    \
    \ @brief RAMCFG FLEXRAM interrupt status register
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $08 constant RAMCFG_SRAMBUSY                \ [0x08] SRAM busy with erase operation
  [then]


  [ifdef] RAMCFG_RAMCFG_FLEXRAMERKEYR_DEF
    \
    \ @brief RAMCFG FLEXRAM erase key register
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant RAMCFG_ERASEKEY                \ [0x00 : 8] Erase write protection key
  [then]

  \
  \ @brief SRAM configuration controller
  \
  $00 constant RAMCFG_RAMCFG_AXISRAM1CR \ RAMCFG AXISRAM1 control register
  $08 constant RAMCFG_RAMCFG_AXISRAM1ISR    \ RAMCFG AXISRAM1 interrupt status register
  $28 constant RAMCFG_RAMCFG_AXISRAM1ERKEYR    \ RAMCFG AXISRAM1 erase key register
  $80 constant RAMCFG_RAMCFG_AXISRAM2CR \ RAMCFG AXISRAM2 control register
  $88 constant RAMCFG_RAMCFG_AXISRAM2ISR    \ RAMCFG AXISRAM2 interrupt status register
  $A8 constant RAMCFG_RAMCFG_AXISRAM2ERKEYR    \ RAMCFG AXISRAM2 erase key register
  $100 constant RAMCFG_RAMCFG_AXISRAM3CR    \ RAMCFG AXISRAM3 control register
  $108 constant RAMCFG_RAMCFG_AXISRAM3ISR    \ RAMCFG AXISRAM3 interrupt status register
  $128 constant RAMCFG_RAMCFG_AXISRAM3ERKEYR    \ RAMCFG AXISRAM3 erase key register
  $180 constant RAMCFG_RAMCFG_AXISRAM4CR    \ RAMCFG AXISRAM4 control register
  $188 constant RAMCFG_RAMCFG_AXISRAM4ISR    \ RAMCFG AXISRAM4 interrupt status register
  $1A8 constant RAMCFG_RAMCFG_AXISRAM4ERKEYR    \ RAMCFG AXISRAM4 erase key register
  $200 constant RAMCFG_RAMCFG_AXISRAM5CR    \ RAMCFG AXISRAM5 control register
  $208 constant RAMCFG_RAMCFG_AXISRAM5ISR    \ RAMCFG AXISRAM5 interrupt status register
  $228 constant RAMCFG_RAMCFG_AXISRAM5ERKEYR    \ RAMCFG AXISRAM5 erase key register
  $280 constant RAMCFG_RAMCFG_AXISRAM6CR    \ RAMCFG AXISRAM6 control register
  $288 constant RAMCFG_RAMCFG_AXISRAM6ISR    \ RAMCFG AXISRAM6 interrupt status register
  $2A8 constant RAMCFG_RAMCFG_AXISRAM6ERKEYR    \ RAMCFG AXISRAM6 erase key register
  $300 constant RAMCFG_RAMCFG_AHBSRAM1CR    \ RAMCFG AHBSRAM1 control register
  $308 constant RAMCFG_RAMCFG_AHBSRAM1ISR    \ RAMCFG AHBSRAM1 interrupt status register
  $328 constant RAMCFG_RAMCFG_AHBSRAM1ERKEYR    \ RAMCFG AHBSRAM1 erase key register
  $380 constant RAMCFG_RAMCFG_AHBSRAM2CR    \ RAMCFG AHBSRAM2 control register
  $388 constant RAMCFG_RAMCFG_AHBSRAM2ISR    \ RAMCFG AHBSRAM2 interrupt status register
  $3A8 constant RAMCFG_RAMCFG_AHBSRAM2ERKEYR    \ RAMCFG AHBSRAM2 erase key register
  $400 constant RAMCFG_RAMCFG_VENCRAMCR \ RAMCFG VENCRAM control register
  $408 constant RAMCFG_RAMCFG_VENCRAMISR    \ RAMCFG VENCRAM interrupt status register
  $428 constant RAMCFG_RAMCFG_VENCRAMERKEYR    \ RAMCFG VENCRAM erase key register
  $480 constant RAMCFG_RAMCFG_BKPSRAMCR \ RAMCFG BKPSRAM control register
  $484 constant RAMCFG_RAMCFG_BKPSRAMIER    \ RAMCFG BKPSRAM interrupt enable register
  $488 constant RAMCFG_RAMCFG_BKPSRAMISR    \ RAMCFG BKPSRAM interrupt status register
  $48C constant RAMCFG_RAMCFG_BKPSRAMESEAR    \ RAMCFG BKPSRAM single error address register
  $490 constant RAMCFG_RAMCFG_BKPSRAMEDEAR    \ RAMCFG BKPSRAM double error address register
  $494 constant RAMCFG_RAMCFG_BKPSRAMICR    \ RAMCFG BKPSRAM interrupt clear register
  $4A4 constant RAMCFG_RAMCFG_BKPSRAMECCKEYR    \ RAMCFG BKPSRAM ECC key register
  $4A8 constant RAMCFG_RAMCFG_BKPSRAMERKEYR    \ RAMCFG BKPSRAM erase key register
  $500 constant RAMCFG_RAMCFG_FLEXRAMCR \ RAMCFG FLEXRAM control register
  $508 constant RAMCFG_RAMCFG_FLEXRAMISR    \ RAMCFG FLEXRAM interrupt status register
  $528 constant RAMCFG_RAMCFG_FLEXRAMERKEYR    \ RAMCFG FLEXRAM erase key register

: RAMCFG_DEF ; [then]
